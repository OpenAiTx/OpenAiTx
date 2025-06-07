# future-queue

[![future-queue on crates.io](https://img.shields.io/crates/v/future-queue)](https://crates.io/crates/future-queue)
[![Documentation (latest release)](https://img.shields.io/badge/docs-latest-brightgreen.svg)](https://docs.rs/future-queue/)
[![Documentation (main)](https://img.shields.io/badge/docs-main-purple)](https://nextest-rs.github.io/future-queue/rustdoc/future_queue)
[![Changelog](https://img.shields.io/badge/changelog-latest-blue)](https://raw.githubusercontent.com/nextest-rs/future-queue/main/CHANGELOG.md)
[![License](https://img.shields.io/badge/license-Apache-green.svg)](https://raw.githubusercontent.com/nextest-rs/future-queue/main/LICENSE-APACHE)
[![License](https://img.shields.io/badge/license-MIT-green.svg)](https://raw.githubusercontent.com/nextest-rs/future-queue/main/LICENSE-MIT)

`future_queue` udostępnia sposoby uruchamiania kilku future’ów:

* współbieżnie
* w kolejności, w jakiej są uruchamiane
* z globalnymi limitami
* oraz z opcjonalną grupą określoną dla każdego future, z własnymi limitami.

Ta biblioteka jest częścią [organizacji nextest](https://github.com/nextest-rs) na GitHubie i została zaprojektowana, aby spełniać potrzeby [cargo-nextest](https://nexte.st).

## Motywacja

Programowanie asynchroniczne w Rust często korzysta z adaptera o nazwie
[`buffer_unordered`](https://docs.rs/futures/latest/futures/stream/trait.StreamExt.html#method.buffer_unordered):
ten adapter przyjmuje strumień future’ów[^1] i wykonuje je wszystkie z ograniczeniem do maksymalnej liczby współbieżności.

* Future’y są uruchamiane w kolejności, w jakiej zwraca je strumień.
* Po uruchomieniu, future’y są sprawdzane jednocześnie, a zakończone wyniki są zwracane w dowolnej kolejności (stąd `unordered`).

Typowe zastosowania `buffer_unordered` to:

* Wysyłanie żądań sieciowych współbieżnie, ale z ograniczeniem liczby współbieżności, aby nie przeciążać zdalnego serwera.
* Uruchamianie testów za pomocą narzędzia takiego jak [cargo-nextest](https://nexte.st).

`buffer_unordered` sprawdza się w wielu przypadkach. Jednak problem polega na tym, że traktuje wszystkie future’y jako równie obciążające: nie ma sposobu, aby określić, że niektóre future’y zużywają więcej zasobów niż inne, lub że pewne podzbiory future’ów powinny być wzajemnie wykluczone.

W przypadku nextest niektóre testy mogą być znacznie cięższe niż inne i mniej takich testów powinno być wykonywanych jednocześnie. Dodatkowo, niektóre testy muszą być wzajemnie wykluczone lub muszą mieć nałożone inne limity współbieżności.

[^1]: Ten adapter przyjmuje strumień future’ów dla maksymalnej ogólności. W praktyce jest to często *iterator* future’ów, przekonwertowany za pomocą
    [`stream::iter`](https://docs.rs/futures/latest/futures/stream/fn.iter.html).

## O tej bibliotece

Ta biblioteka udostępnia dwa adaptery dla strumieni.

### 1. Adapter `future_queue`

Adapter [`future_queue`](StreamExt::future_queue) pozwala uruchomić kilka future’ów jednocześnie, ograniczając współbieżność do maksymalnej *wagi*.

Zamiast przyjmować strumień future’ów, adapter ten przyjmuje strumień par `(usize, F)`, gdzie `usize` oznacza wagę każdego future, a `F` to `FnOnce(FutureQueueContext) -> impl Future`. Adapter ten będzie planował i buforował future’y do uruchomienia, dopóki dodanie kolejnego future nie przekroczy maksymalnej wagi.

* Maksymalna waga nigdy nie jest przekraczana podczas uruchamiania future’ów.
* Jeśli waga pojedynczego future jest większa niż maksymalna waga, jej wartość zostanie ustawiona na maksymalną wagę.

Gdy wszystkie możliwe future’y zostaną zaplanowane, adapter poczeka, aż niektóre z obecnie wykonywanych future’ów się zakończą i bieżąca waga spadnie poniżej maksimum, zanim zaplanuje kolejne future’y.

Waga future może być równa zero, wtedy nie liczy się ona do maksymalnej wagi.

Jeśli wszystkie wagi są równe 1, to `future_queue` działa dokładnie tak samo jak `buffer_unordered`.

#### Przykłady

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

### 2. Adapter `future_queue_grouped`

Adapter [`future_queue_grouped`](StreamExt::future_queue_grouped) działa podobnie jak `future_queue`, z tą różnicą, że można określić opcjonalną *grupę* dla każdego future. Każda grupa ma swoją maksymalną wagę i future zostanie zaplanowany tylko wtedy, gdy zarówno globalny limit, jak i limit grupy nie zostaną przekroczone.

Adapter jest tak sprawiedliwy, jak to możliwe przy danych ograniczeniach: planuje future’y w kolejności zwracanej przez strumień, bez zmiany kolejności na podstawie wagi. Gdy future z grupy zostanie ukończony, przyszłe future’y z tej grupy będą planowane w pierwszej kolejności przed innymi ze strumienia.

Podobnie jak w [`future_queue`](StreamExt::future_queue):

* Maksymalne globalne i grupowe wagi nigdy nie są przekraczane podczas uruchamiania future’ów.
* Przy rozliczaniu względem globalnej wagi, jeśli waga pojedynczego future przekracza maksimum, zostanie ustawiona na to maksimum.
* *Jeśli future należy do grupy:* Przy rozliczaniu względem wagi grupy, jeśli waga przekracza maksimum dla grupy, zostanie ustawiona na to maksimum.

#### Przykłady

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

## Minimalna wspierana wersja Rust (MSRV)

Minimalna wspierana wersja Rust to **Rust 1.70.** W każdym momencie wspierane są co najmniej ostatnie sześć miesięcy stabilnych wydań Rust.

Dopóki biblioteka jest w wersji pre-release (0.x.x), MSRV może być podnoszone w wydaniu typu patch. Po osiągnięciu wersji 1.x, każda zmiana MSRV będzie wiązała się z nową wersją minor.

## Uwagi

Ta biblioteka wcześniej nazywała się `buffer-unordered-weighted`. Została przemianowana na `future-queue`, aby lepiej oddać, co robi, zamiast jak jest zaimplementowana.

## Współpraca

Zobacz plik [CONTRIBUTING](https://raw.githubusercontent.com/nextest-rs/future-queue/main/CONTRIBUTING.md), aby dowiedzieć się, jak możesz pomóc.

## Licencja

Ten projekt jest dostępny na warunkach [licencji Apache 2.0](https://raw.githubusercontent.com/nextest-rs/future-queue/main/LICENSE-APACHE) lub [licencji MIT](https://raw.githubusercontent.com/nextest-rs/future-queue/main/LICENSE-MIT).

Kod pochodzi z projektu [futures-rs](https://github.com/rust-lang/futures-rs) i jest używany na warunkach licencji Apache 2.0 oraz MIT.

<!--
README.md jest generowany z README.tpl przez cargo readme. Aby wygenerować ponownie, uruchom z katalogu głównego repozytorium:

./scripts/regenerate-readmes.sh
-->

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---