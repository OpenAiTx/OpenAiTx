# future-queue

[![future-queue sur crates.io](https://img.shields.io/crates/v/future-queue)](https://crates.io/crates/future-queue)
[![Documentation (dernière version)](https://img.shields.io/badge/docs-latest-brightgreen.svg)](https://docs.rs/future-queue/)
[![Documentation (main)](https://img.shields.io/badge/docs-main-purple)](https://nextest-rs.github.io/future-queue/rustdoc/future_queue)
[![Changelog](https://img.shields.io/badge/changelog-latest-blue)](https://raw.githubusercontent.com/nextest-rs/future-queue/main/CHANGELOG.md)
[![Licence](https://img.shields.io/badge/license-Apache-green.svg)](https://raw.githubusercontent.com/nextest-rs/future-queue/main/LICENSE-APACHE)
[![Licence](https://img.shields.io/badge/license-MIT-green.svg)](https://raw.githubusercontent.com/nextest-rs/future-queue/main/LICENSE-MIT)

`future_queue` fournit des moyens d’exécuter plusieurs futures :

* en concurrence
* dans l’ordre où elles sont lancées
* avec des limites globales
* et avec un groupe optionnel spécifié pour chaque future, avec ses propres limites.

Ce crate fait partie de l’[organisation nextest](https://github.com/nextest-rs) sur GitHub, et
est conçu pour répondre aux besoins de [cargo-nextest](https://nexte.st).

## Motivation

La programmation asynchrone en Rust utilise souvent un adaptateur appelé
[`buffer_unordered`](https://docs.rs/futures/latest/futures/stream/trait.StreamExt.html#method.buffer_unordered) :
cet adaptateur prend un flux de futures[^1], et exécute toutes les futures avec une limite
maximale de concurrence.

* Les futures sont lancées dans l’ordre où le flux les retourne.
* Une fois lancées, les futures sont sondées simultanément, et les sorties des futures terminées
  sont retournées dans un ordre arbitraire (d’où le terme `unordered`).

Cas d’utilisation courants de `buffer_unordered` :

* Envoyer des requêtes réseau en concurrence, mais en limitant le niveau de concurrence pour éviter
  de submerger le serveur distant.
* Exécuter des tests avec un outil comme [cargo-nextest](https://nexte.st).

`buffer_unordered` fonctionne bien dans de nombreux cas. Cependant, un inconvénient est qu’il
considère toutes les futures comme ayant le même coût : il n’est pas possible d’indiquer que
certaines futures consomment plus de ressources que d’autres, ou que certains sous-ensembles de
futures doivent être mutuellement exclusifs.

Pour nextest en particulier, certains tests peuvent être beaucoup plus lourds que d’autres, et
moins de ces tests devraient être exécutés simultanément. De plus, certains tests doivent être
mutuellement exclusifs ou soumis à d’autres limites de concurrence.

[^1]: Cet adaptateur prend un flux de futures pour une généralité maximale. En pratique, il
    s’agit souvent d’un *itérateur* de futures, converti via
    [`stream::iter`](https://docs.rs/futures/latest/futures/stream/fn.iter.html).

## À propos de ce crate

Ce crate fournit deux adaptateurs sur les flux.

### 1. L’adaptateur `future_queue`

L’adaptateur [`future_queue`](StreamExt::future_queue) peut exécuter plusieurs futures en
même temps, en limitant la concurrence à un *poids* maximum.

Au lieu de prendre un flux de futures, cet adaptateur prend un flux de paires
`(usize, F)`, où le `usize` indique le poids de chaque future,
et `F` est `FnOnce(FutureQueueContext) -> impl Future`. Cet adaptateur va
planifier et mettre en tampon des futures à exécuter jusqu’à ce que l’ajout de la prochaine
future dépasse le poids maximal.

* Le poids maximal n’est jamais dépassé pendant l’exécution des futures.
* Si le poids d’une future individuelle est supérieur au poids maximal, son poids sera fixé
  au poids maximal.

Une fois que toutes les futures possibles sont planifiées, cet adaptateur attendra que certaines
des futures en cours d’exécution se terminent, et que le poids actuel des futures actives passe
en dessous du poids maximal, avant de planifier de nouvelles futures.

Le poids d’une future peut être zéro, auquel cas elle ne compte pas dans le poids maximal.

Si tous les poids valent 1, alors `future_queue` est exactement identique à `buffer_unordered`.

#### Exemples

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

### 2. L’adaptateur `future_queue_grouped`

L’adaptateur [`future_queue_grouped`](StreamExt::future_queue_grouped) est similaire à
`future_queue`, sauf qu’il est possible de spécifier un *groupe* optionnel pour chaque future.
Chaque groupe a un poids maximal, et une future ne sera planifiée que si le poids maximal
global et le poids du groupe ne sont pas dépassés.

L’adaptateur est aussi équitable que possible sous les contraintes données : il planifie les
futures dans l’ordre où elles sont retournées par le flux, sans réorganisation basée sur le poids.
Lorsqu’une future d’un groupe se termine, les futures en attente de ce groupe seront planifiées
en priorité par rapport aux autres futures du flux.

Comme pour [`future_queue`](StreamExt::future_queue) :

* Les poids maximaux globaux et de groupe ne sont jamais dépassés pendant l’exécution des futures.
* Pour le poids global, si le poids d’une future individuelle dépasse le poids maximal, son
  poids sera fixé à la valeur maximale.
* *Si une future appartient à un groupe :* pour le poids du groupe, si son poids dépasse le
  poids maximal du groupe, il sera fixé à la valeur maximale du groupe.

#### Exemples

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

## Version minimale de Rust supportée (MSRV)

La version minimale de Rust supportée est **Rust 1.70.** À tout moment, au moins les six derniers
mois de versions stables de Rust sont supportés.

Tant que ce crate est en pré-version (0.x.x), la MSRV peut être augmentée lors d’une version de
correction. Une fois que ce crate aura atteint la version 1.x, tout changement de MSRV sera
accompagné d’une nouvelle version mineure.

## Notes

Ce crate s’appelait auparavant `buffer-unordered-weighted`. Il a été renommé en `future-queue`
pour être plus descriptif sur ce qu’il fait plutôt que sur sa manière d’implémentation.

## Contribuer

Voir le fichier [CONTRIBUTING](https://raw.githubusercontent.com/nextest-rs/future-queue/main/CONTRIBUTING.md) pour savoir comment contribuer.

## Licence

Ce projet est disponible sous les termes de la [licence Apache 2.0](https://raw.githubusercontent.com/nextest-rs/future-queue/main/LICENSE-APACHE) ou de la [licence MIT](https://raw.githubusercontent.com/nextest-rs/future-queue/main/LICENSE-MIT).

Le code est dérivé de [futures-rs](https://github.com/rust-lang/futures-rs), et est utilisé sous
licence Apache 2.0 et MIT.

<!--
README.md est généré à partir de README.tpl par cargo readme. Pour régénérer, exécutez à la racine du dépôt :

./scripts/regenerate-readmes.sh
-->

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---