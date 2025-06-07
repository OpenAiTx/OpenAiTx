# future-queue

[![future-queue su crates.io](https://img.shields.io/crates/v/future-queue)](https://crates.io/crates/future-queue)
[![Documentazione (ultima versione)](https://img.shields.io/badge/docs-latest-brightgreen.svg)](https://docs.rs/future-queue/)
[![Documentazione (main)](https://img.shields.io/badge/docs-main-purple)](https://nextest-rs.github.io/future-queue/rustdoc/future_queue)
[![Changelog](https://img.shields.io/badge/changelog-latest-blue)](https://raw.githubusercontent.com/nextest-rs/future-queue/main/CHANGELOG.md)
[![Licenza](https://img.shields.io/badge/license-Apache-green.svg)](https://raw.githubusercontent.com/nextest-rs/future-queue/main/LICENSE-APACHE)
[![Licenza](https://img.shields.io/badge/license-MIT-green.svg)](https://raw.githubusercontent.com/nextest-rs/future-queue/main/LICENSE-MIT)

`future_queue` offre diversi modi per eseguire più future:

* concorrenti
* nell'ordine in cui vengono create
* con limiti globali
* e con un gruppo opzionale specificato per ogni future, ciascuno con i propri limiti.

Questo crate fa parte dell'[organizzazione nextest](https://github.com/nextest-rs) su GitHub, ed
è progettato per soddisfare le esigenze di [cargo-nextest](https://nexte.st).

## Motivazione

La programmazione asincrona in Rust utilizza spesso un adattatore chiamato
[`buffer_unordered`](https://docs.rs/futures/latest/futures/stream/trait.StreamExt.html#method.buffer_unordered):
questo adattatore prende uno stream di future[^1], ed esegue tutte le future limitando la concorrenza
ad un massimo specificato.

* Le future vengono avviate nell'ordine in cui vengono restituite dallo stream.
* Una volta avviate, le future vengono eseguite contemporaneamente e i risultati delle future completate
  vengono restituiti in ordine arbitrario (da qui `unordered`).

Casi d’uso comuni per `buffer_unordered` includono:

* Invio di richieste di rete in modo concorrente, ma limitando la concorrenza per evitare di sovraccaricare il server remoto.
* Esecuzione di test con uno strumento come [cargo-nextest](https://nexte.st).

`buffer_unordered` funziona bene in molti casi. Tuttavia, un problema è che tratta tutte le future
allo stesso modo: non c’è modo di specificare che alcune future consumano più risorse di altre,
o che alcuni sottoinsiemi di future debbano essere mutuamente esclusi da altri.

Per nextest in particolare, alcuni test possono essere molto più pesanti di altri, e di questi test
dovrebbero essere eseguiti meno contemporaneamente. Inoltre, alcuni test devono essere mutuamente esclusivi
da altri, o devono essere imposti altri limiti di concorrenza.

[^1]: Questo adattatore prende uno stream di future per la massima generalità. In pratica spesso si tratta
    di un *iteratore* di future, convertito tramite
    [`stream::iter`](https://docs.rs/futures/latest/futures/stream/fn.iter.html).

## Informazioni su questo crate

Questo crate fornisce due adattatori per gli stream.

### 1. L'adattatore `future_queue`

L’adattatore [`future_queue`](StreamExt::future_queue) può eseguire più future contemporaneamente,
limitando la concorrenza a un peso massimo.

Invece di accettare uno stream di future, questo adattatore accetta uno stream di
coppie `(usize, F)`, dove `usize` indica il peso di ciascuna future,
e `F` è `FnOnce(FutureQueueContext) -> impl Future`. Questo adattatore
programmerà e metterà in coda le future da eseguire fino a quando la successiva future
farebbe superare il peso massimo.

* Il peso massimo non viene mai superato mentre le future sono in esecuzione.
* Se il peso di una singola future è maggiore del peso massimo, il suo peso verrà
  impostato al peso massimo.

Una volta che tutte le future possibili sono state programmate, questo adattatore attende che alcune delle future
attualmente in esecuzione siano completate, e che il peso corrente delle future in esecuzione scenda sotto il peso massimo,
prima di programmare nuove future.

Il peso di una future può essere zero, in tal caso non conta per il peso massimo.

Se tutti i pesi sono 1, allora `future_queue` è esattamente identico a `buffer_unordered`.

#### Esempi

```rust
use futures::{channel::oneshot, stream, StreamExt as _};
use future_queue::{StreamExt as _};

let (send_one, recv_one) = oneshot::channel();
let (send_two, recv_two) = oneshot::channel();

let stream_of_futures = stream::iter(
    vec![(1, recv_one), (2, recv_two)],
).map(|(weight, future)| {
    (weight, move |_cx| future)
});
let mut queue = stream_of_futures.future_queue(10);

send_two.send("hello")?;
assert_eq!(queue.next().await, Some(Ok("hello")));

send_one.send("world")?;
assert_eq!(queue.next().await, Some(Ok("world")));

assert_eq!(queue.next().await, None);
```

### 2. L'adattatore `future_queue_grouped`

L’adattatore [`future_queue_grouped`](StreamExt::future_queue_grouped) è simile a `future_queue`,
ma permette di specificare un *gruppo* opzionale per ciascuna future. Ogni gruppo ha un peso massimo,
e una future verrà programmata solo se sia il peso massimo globale che quello del gruppo
non vengono superati.

L’adattatore è il più equo possibile date le restrizioni: programmerà le future nell’ordine in cui
vengono restituite dallo stream, senza alcun riordino in base al peso. Quando una future di un gruppo termina,
le future in coda di questo gruppo saranno programmate preferenzialmente rispetto alle altre future dello stream.

Come con [`future_queue`](StreamExt::future_queue):

* I pesi massimi globali e di gruppo non vengono mai superati mentre le future sono in esecuzione.
* Nel calcolo del peso globale, se il peso di una singola future è maggiore del peso massimo,
  il suo peso verrà impostato al peso massimo.
* *Se una future appartiene a un gruppo:* Nel calcolo del peso di gruppo, se il suo peso è
  maggiore del peso massimo del gruppo, il suo peso verrà impostato al massimo del gruppo.

#### Esempi

```rust
use futures::{channel::oneshot, stream, StreamExt as _};
use future_queue::{FutureQueueContext, StreamExt as _};

let (send_one, recv_one) = oneshot::channel();
let (send_two, recv_two) = oneshot::channel();

let stream_of_futures = stream::iter(
    vec![
        (1, Some("group1"), recv_one),
        (2, None, recv_two),
    ],
).map(|(weight, group, future)| {
    (weight, group, move |_cx| future)
});
let mut queue = stream_of_futures.future_queue_grouped(10, [("group1", 5)]);

send_two.send("hello")?;
assert_eq!(queue.next().await, Some(Ok("hello")));

send_one.send("world")?;
assert_eq!(queue.next().await, Some(Ok("world")));

assert_eq!(queue.next().await, None);
```

## Versione minima supportata di Rust (MSRV)

La versione minima di Rust supportata è **Rust 1.70.** In ogni momento, sono supportate almeno le ultime sei versioni stabili di Rust degli ultimi sei mesi.

Finché questo crate è in pre-release (0.x.x) la MSRV può essere aggiornata anche in una patch release. Una volta che il crate raggiungerà la versione 1.x, ogni aggiornamento della MSRV sarà accompagnato da una nuova versione minor.

## Note

Questo crate si chiamava precedentemente `buffer-unordered-weighted`. È stato rinominato in `future-queue` per essere
più descrittivo riguardo a ciò che fa, piuttosto che come è implementato.

## Contribuire

Consulta il file [CONTRIBUTING](https://raw.githubusercontent.com/nextest-rs/future-queue/main/CONTRIBUTING.md) per sapere come contribuire.

## Licenza

Questo progetto è disponibile secondo i termini della [licenza Apache 2.0](https://raw.githubusercontent.com/nextest-rs/future-queue/main/LICENSE-APACHE) o
della [licenza MIT](https://raw.githubusercontent.com/nextest-rs/future-queue/main/LICENSE-MIT).

Il codice deriva da [futures-rs](https://github.com/rust-lang/futures-rs), ed è utilizzato sotto
licenza Apache 2.0 e MIT.

<!--
README.md è generato da README.tpl tramite cargo readme. Per rigenerare, eseguire dalla radice del repository:

./scripts/regenerate-readmes.sh
-->

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---