# future-queue

[![future-queue auf crates.io](https://img.shields.io/crates/v/future-queue)](https://crates.io/crates/future-queue)
[![Dokumentation (letztes Release)](https://img.shields.io/badge/docs-latest-brightgreen.svg)](https://docs.rs/future-queue/)
[![Dokumentation (main)](https://img.shields.io/badge/docs-main-purple)](https://nextest-rs.github.io/future-queue/rustdoc/future_queue)
[![Changelog](https://img.shields.io/badge/changelog-latest-blue)](https://raw.githubusercontent.com/nextest-rs/future-queue/main/CHANGELOG.md)
[![Lizenz](https://img.shields.io/badge/license-Apache-green.svg)](https://raw.githubusercontent.com/nextest-rs/future-queue/main/LICENSE-APACHE)
[![Lizenz](https://img.shields.io/badge/license-MIT-green.svg)](https://raw.githubusercontent.com/nextest-rs/future-queue/main/LICENSE-MIT)

`future_queue` bietet Möglichkeiten, mehrere Futures auszuführen:

* gleichzeitig
* in der Reihenfolge, in der sie gestartet werden
* mit globalen Begrenzungen
* und mit einer optionalen Gruppe, die für jede Future angegeben werden kann und ihre eigenen Begrenzungen hat.

Dieses Crate ist Teil der [nextest-Organisation](https://github.com/nextest-rs) auf GitHub und
wurde entwickelt, um die Anforderungen von [cargo-nextest](https://nexte.st) zu erfüllen.

## Motivation

Asynchrone Programmierung in Rust verwendet häufig einen Adapter namens
[`buffer_unordered`](https://docs.rs/futures/latest/futures/stream/trait.StreamExt.html#method.buffer_unordered):
Dieser Adapter nimmt einen Stream von Futures[^1] und führt alle Futures mit einer maximalen
Gleichzeitigkeit aus.

* Futures werden in der Reihenfolge gestartet, in der sie vom Stream zurückgegeben werden.
* Einmal gestartet, werden Futures gleichzeitig abgefragt, und die Ausgaben der abgeschlossenen Futures werden in
  beliebiger Reihenfolge zurückgegeben (daher das `unordered`).

Häufige Anwendungsfälle für `buffer_unordered` sind:

* Gleichzeitiges Senden von Netzwerkanfragen, aber Begrenzung der Anzahl, um den Remote-Server nicht zu überlasten.
* Ausführen von Tests mit einem Tool wie [cargo-nextest](https://nexte.st).

`buffer_unordered` funktioniert in vielen Anwendungsfällen gut. Ein Problem dabei ist jedoch, dass alle Futures als gleich aufwendig behandelt werden: Es gibt keine Möglichkeit anzugeben, dass einige Futures mehr Ressourcen verbrauchen als andere, oder dass einige Teilmengen von Futures gegenseitig ausgeschlossen werden sollen.

Gerade bei nextest können einige Tests deutlich ressourcenintensiver sein als andere, und von diesen sollten weniger gleichzeitig ausgeführt werden. Außerdem müssen einige Tests gegenseitig ausgeschlossen werden, oder es sollten andere Begrenzungen der Gleichzeitigkeit auf sie angewendet werden.

[^1]: Dieser Adapter nimmt einen Stream von Futures für maximale Allgemeingültigkeit. In der Praxis ist dies oft ein *Iterator* von Futures, der mit
    [`stream::iter`](https://docs.rs/futures/latest/futures/stream/fn.iter.html) umgewandelt wird.

## Über dieses Crate

Dieses Crate stellt zwei Adapter für Streams bereit.

### 1. Der `future_queue`-Adapter

Der [`future_queue`](https://raw.githubusercontent.com/nextest-rs/future-queue/main/src/stream_ext.rs#L41)-Adapter kann mehrere Futures gleichzeitig ausführen und die Gleichzeitigkeit auf ein maximales *Gewicht* begrenzen.

Anstatt einen Stream von Futures zu nehmen, erwartet dieser Adapter einen Stream von
`(usize, F)`-Tupeln, wobei das `usize` das Gewicht jeder Future angibt
und `F` ist `FnOnce(FutureQueueContext) -> impl Future`. Dieser Adapter plant und puffert Futures so, dass das Planen der nächsten Future das maximale Gewicht nicht überschreitet.

* Das maximale Gewicht wird beim Ausführen der Futures nie überschritten.
* Wenn das Gewicht einer einzelnen Future größer als das maximale Gewicht ist, wird ihr Gewicht
  auf das maximale Gewicht gesetzt.

Sobald alle möglichen Futures geplant sind, wartet dieser Adapter, bis einige der aktuell ausgeführten Futures abgeschlossen sind und das aktuelle Gewicht der laufenden Futures unter das maximale Gewicht fällt, bevor neue Futures eingeplant werden.

Das Gewicht einer Future kann null sein, in diesem Fall zählt sie nicht zum maximalen Gewicht.

Sind alle Gewichte 1, ist `future_queue` exakt das gleiche wie `buffer_unordered`.

#### Beispiele

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

### 2. Der `future_queue_grouped`-Adapter

Der [`future_queue_grouped`](https://raw.githubusercontent.com/nextest-rs/future-queue/main/src/stream_ext.rs#L110)-Adapter ist wie `future_queue`,
allerdings kann für jede Future optional eine *Gruppe* angegeben werden. Jede Gruppe hat ein maximales Gewicht und eine Future wird nur dann eingeplant, wenn sowohl das maximale Gesamtgewicht als auch das Gruppen-Gewicht nicht überschritten werden.

Der Adapter ist unter den gegebenen Bedingungen so fair wie möglich: Er plant Futures in der Reihenfolge ein, in der sie vom Stream zurückgegeben werden, ohne Umsortierung nach Gewicht. Wenn eine Future einer Gruppe abgeschlossen ist, werden wartende Futures dieser Gruppe bevorzugt eingeplant, bevor andere Futures aus dem bereitgestellten Stream eingeplant werden.

Wie bei [`future_queue`](https://raw.githubusercontent.com/nextest-rs/future-queue/main/src/stream_ext.rs#L41):

* Die maximalen globalen und Gruppen-Gewichte werden beim Ausführen der Futures nie überschritten.
* Bei der Berücksichtigung des globalen Gewichts wird, wenn das Gewicht einer einzelnen Future größer als das maximale Gewicht ist, ihr Gewicht auf das maximale Gewicht gesetzt.
* *Wenn eine Future zu einer Gruppe gehört:* Bei der Berücksichtigung des Gruppen-Gewichts wird, wenn ihr Gewicht größer als das maximale Gruppen-Gewicht ist, ihr Gewicht auf das maximale Gruppen-Gewicht gesetzt.

#### Beispiele

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

## Minimale unterstützte Rust-Version (MSRV)

Die minimal unterstützte Rust-Version ist **Rust 1.70.** Es werden immer mindestens die letzten sechs Monate der Rust-Stable-Releases unterstützt.

Solange dieses Crate eine Vorabversion (0.x.x) ist, kann die MSRV auch in einem Patch-Release angehoben werden. Sobald dieses Crate 1.x erreicht hat, wird jede Anhebung der MSRV mit einer neuen Minor-Version veröffentlicht.

## Hinweise

Dieses Crate hieß früher `buffer-unordered-weighted`. Es wurde in `future-queue` umbenannt, um besser zu beschreiben, was das Crate tut, und nicht wie es implementiert ist.

## Mitwirken

Siehe die [CONTRIBUTING](https://raw.githubusercontent.com/nextest-rs/future-queue/main/CONTRIBUTING.md)-Datei für Hinweise zur Mitarbeit.

## Lizenz

Dieses Projekt ist unter den Bedingungen der [Apache 2.0 Lizenz](https://raw.githubusercontent.com/nextest-rs/future-queue/main/LICENSE-APACHE) oder
der [MIT-Lizenz](https://raw.githubusercontent.com/nextest-rs/future-queue/main/LICENSE-MIT) verfügbar.

Der Code basiert auf [futures-rs](https://github.com/rust-lang/futures-rs) und wird unter den Apache 2.0- und MIT-Lizenzen verwendet.

<!--
README.md wird aus README.tpl durch cargo readme generiert. Um es zu regenerieren, führe im Repository-Stammverzeichnis aus:

./scripts/regenerate-readmes.sh
-->

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---