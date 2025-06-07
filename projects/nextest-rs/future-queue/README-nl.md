# future-queue

[![future-queue op crates.io](https://img.shields.io/crates/v/future-queue)](https://crates.io/crates/future-queue)
[![Documentatie (laatste release)](https://img.shields.io/badge/docs-latest-brightgreen.svg)](https://docs.rs/future-queue/)
[![Documentatie (main)](https://img.shields.io/badge/docs-main-purple)](https://nextest-rs.github.io/future-queue/rustdoc/future_queue)
[![Changelog](https://img.shields.io/badge/changelog-latest-blue)](https://raw.githubusercontent.com/nextest-rs/future-queue/main/CHANGELOG.md)
[![Licentie](https://img.shields.io/badge/license-Apache-green.svg)](https://raw.githubusercontent.com/nextest-rs/future-queue/main/LICENSE-APACHE)
[![Licentie](https://img.shields.io/badge/license-MIT-green.svg)](https://raw.githubusercontent.com/nextest-rs/future-queue/main/LICENSE-MIT)

`future_queue` biedt mogelijkheden om meerdere futures uit te voeren:

* gelijktijdig
* in de volgorde waarin ze zijn gestart
* met globale limieten
* en met een optionele groep die voor elke future kan worden opgegeven, met eigen limieten.

Deze crate is onderdeel van de [nextest-organisatie](https://github.com/nextest-rs) op GitHub, en
is ontworpen om te voldoen aan de behoeften van [cargo-nextest](https://nexte.st).

## Motivatie

Asynchroon programmeren in Rust gebruikt vaak een adaptor genaamd
[`buffer_unordered`](https://docs.rs/futures/latest/futures/stream/trait.StreamExt.html#method.buffer_unordered):
deze adaptor neemt een stream van futures[^1], en voert alle futures uit met een maximum
aan gelijktijdigheid.

* Futures worden gestart in de volgorde waarin de stream ze teruggeeft.
* Zodra gestart, worden futures gelijktijdig gepolld, en voltooide future-uitvoeren worden in
  willekeurige volgorde teruggegeven (vandaar `unordered`).

Veelvoorkomende gebruikssituaties voor `buffer_unordered` zijn onder meer:

* Het gelijktijdig verzenden van netwerkverzoeken, maar het beperken van de mate van gelijktijdigheid om
  overbelasting van de externe server te voorkomen.
* Tests uitvoeren met een tool zoals [cargo-nextest](https://nexte.st).

`buffer_unordered` werkt goed voor veel gebruikssituaties. Echter, één probleem is dat alle
futures als even zwaar worden behandeld: er is geen manier om aan te geven dat sommige futures
meer middelen verbruiken dan andere, of dat bepaalde subsets van futures wederzijds uitgesloten moeten zijn van anderen.

Voor nextest in het bijzonder kunnen sommige tests veel zwaarder zijn dan andere, en moeten er minder van die tests
gelijktijdig worden uitgevoerd. Ook moeten sommige tests wederzijds uitgesloten zijn van anderen, of
moeten er andere gelijktijdigheidslimieten op worden toegepast.

[^1]: Deze adaptor neemt een stream van futures voor maximale generaliteit. In de praktijk is dit vaak
    een *iterator* van futures, geconverteerd met
    [`stream::iter`](https://docs.rs/futures/latest/futures/stream/fn.iter.html).

## Over deze crate

Deze crate biedt twee adaptors op streams.

### 1. De `future_queue` adaptor

De [`future_queue`](StreamExt::future_queue) adaptor kan meerdere futures gelijktijdig uitvoeren,
waarbij de gelijktijdigheid wordt beperkt tot een maximale *gewicht*.

In plaats van een stream van futures te nemen, neemt deze adaptor een stream van
`(usize, F)` paren, waarbij de `usize` het gewicht van elke future aangeeft,
en `F` is `FnOnce(FutureQueueContext) -> impl Future`. Deze adaptor zal
futures inplannen en bufferen om uit te voeren, totdat het inplannen van de volgende future het maximale gewicht zou overschrijden.

* Het maximale gewicht wordt nooit overschreden tijdens het uitvoeren van futures.
* Als het gewicht van een individuele future groter is dan het maximale gewicht, wordt het gewicht
  gelijkgesteld aan het maximale gewicht.

Zodra alle mogelijke futures zijn ingepland, wacht deze adaptor tot enkele van de momenteel
uitgevoerde futures zijn voltooid, en het huidige gewicht van draaiende futures onder het maximale gewicht is gezakt, voordat nieuwe futures worden ingepland.

Het gewicht van een future kan nul zijn, in welk geval deze niet meetelt voor het maximale gewicht.

Als alle gewichten 1 zijn, dan is `future_queue` exact hetzelfde als `buffer_unordered`.

#### Voorbeelden

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

send_two.send("hallo")?;
assert_eq!(queue.next().await, Some(Ok("hallo")));

send_one.send("wereld")?;
assert_eq!(queue.next().await, Some(Ok("wereld")));

assert_eq!(queue.next().await, None);
```

### 2. De `future_queue_grouped` adaptor

De [`future_queue_grouped`](StreamExt::future_queue_grouped) adaptor lijkt op `future_queue`,
maar het is mogelijk om een optionele *groep* voor elke future op te geven. Elke groep heeft een maximaal
gewicht, en een future wordt alleen ingepland als zowel het maximale gewicht als het groepsgewicht
niet worden overschreden.

De adaptor is zo eerlijk mogelijk binnen de gegeven beperkingen: hij plant futures in
in de volgorde waarin ze door de stream worden teruggegeven, zonder herordening op basis van gewicht. Wanneer een
future uit een groep voltooid is, worden futures die in deze groep in de wachtrij staan met voorrang ingepland
boven andere futures uit de aangeboden stream.

Net als bij [`future_queue`](StreamExt::future_queue):

* De maximale globale en groepsgewichten worden nooit overschreden tijdens het uitvoeren van futures.
* Bij het verrekenen met globale gewichten, als het gewicht van een individuele future groter is dan
  het maximale gewicht, wordt het gewicht gelijkgesteld aan het maximale gewicht.
* *Als een future tot een groep behoort:* Bij het verrekenen met het groepsgewicht, als het gewicht
  groter is dan het maximale groepsgewicht, wordt het gewicht gelijkgesteld aan het maximale groepsgewicht.

#### Voorbeelden

```rust
use futures::{channel::oneshot, stream, StreamExt as _};
use future_queue::{FutureQueueContext, StreamExt as _};

let (send_one, recv_one) = oneshot::channel();
let (send_two, recv_two) = oneshot::channel();

let stream_of_futures = stream::iter(
    vec![
        (1, Some("groep1"), recv_one),
        (2, None, recv_two),
    ],
).map(|(weight, group, future)| {
    (weight, group, move |_cx| future)
});
let mut queue = stream_of_futures.future_queue_grouped(10, [("groep1", 5)]);

send_two.send("hallo")?;
assert_eq!(queue.next().await, Some(Ok("hallo")));

send_one.send("wereld")?;
assert_eq!(queue.next().await, Some(Ok("wereld")));

assert_eq!(queue.next().await, None);
```

## Minimale ondersteunde Rust-versie (MSRV)

De minimaal ondersteunde Rust-versie is **Rust 1.70.** Op elk moment worden ten minste de laatste zes maanden
van stabiele Rust-releases ondersteund.

Zolang deze crate een pre-release (0.x.x) is, kan de MSRV verhoogd worden in een patchrelease. Zodra
deze crate versie 1.x heeft bereikt, zal elke verhoging van de MSRV gepaard gaan met een nieuw minor-versienummer.

## Opmerkingen

Deze crate heette voorheen `buffer-unordered-weighted`. Het is hernoemd naar `future-queue` om
beter te beschrijven wat de crate doet, in plaats van hoe het geïmplementeerd is.

## Bijdragen

Zie het [CONTRIBUTING](https://raw.githubusercontent.com/nextest-rs/future-queue/main/CONTRIBUTING.md) bestand voor hoe je kunt bijdragen.

## Licentie

Dit project is beschikbaar onder de voorwaarden van ofwel de [Apache 2.0-licentie](https://raw.githubusercontent.com/nextest-rs/future-queue/main/LICENSE-APACHE) of
de [MIT-licentie](https://raw.githubusercontent.com/nextest-rs/future-queue/main/LICENSE-MIT).

De code is afgeleid van [futures-rs](https://github.com/rust-lang/futures-rs), en wordt gebruikt onder
de Apache 2.0- en MIT-licenties.

<!--
README.md wordt gegenereerd uit README.tpl door cargo readme. Om te regenereren, voer uit vanuit de hoofdmap van de repository:

./scripts/regenerate-readmes.sh
-->

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---