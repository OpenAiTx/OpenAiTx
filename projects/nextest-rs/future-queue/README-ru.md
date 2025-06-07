# future-queue

[![future-queue on crates.io](https://img.shields.io/crates/v/future-queue)](https://crates.io/crates/future-queue)
[![Документация (последний релиз)](https://img.shields.io/badge/docs-latest-brightgreen.svg)](https://docs.rs/future-queue/)
[![Документация (main)](https://img.shields.io/badge/docs-main-purple)](https://nextest-rs.github.io/future-queue/rustdoc/future_queue)
[![Изменения](https://img.shields.io/badge/changelog-latest-blue)](https://raw.githubusercontent.com/nextest-rs/future-queue/main/CHANGELOG.md)
[![Лицензия](https://img.shields.io/badge/license-Apache-green.svg)](https://raw.githubusercontent.com/nextest-rs/future-queue/main/LICENSE-APACHE)
[![Лицензия](https://img.shields.io/badge/license-MIT-green.svg)](https://raw.githubusercontent.com/nextest-rs/future-queue/main/LICENSE-MIT)

`future_queue` предоставляет способы выполнения нескольких future:

* параллельно
* в порядке их запуска
* с глобальными ограничениями
* и с необязательной группой, указанной для каждой future, с собственными ограничениями.

Этот крейт является частью [организации nextest](https://github.com/nextest-rs) на GitHub и
разработан для удовлетворения потребностей [cargo-nextest](https://nexte.st).

## Мотивация

Асинхронное программирование в Rust часто использует адаптер под названием
[`buffer_unordered`](https://docs.rs/futures/latest/futures/stream/trait.StreamExt.html#method.buffer_unordered):
этот адаптер принимает поток future[^1] и выполняет их все с ограничением на максимальное
количество параллельных операций.

* Future запускаются в том порядке, в котором поток их возвращает.
* После запуска future опрашиваются одновременно, а завершённые возвращаются в произвольном
  порядке (отсюда и `unordered`).

Обычные случаи использования `buffer_unordered` включают:

* Одновременная отправка сетевых запросов с ограничением по параллелизму, чтобы не перегружать
  удалённый сервер.
* Запуск тестов с помощью инструмента вроде [cargo-nextest](https://nexte.st).

`buffer_unordered` хорошо подходит для многих случаев. Однако одна из проблем заключается в том,
что он считает все future равнозначными: нельзя указать, что некоторые future потребляют больше
ресурсов, чем другие, или что некоторые подмножества future должны быть взаимоисключающими.

В частности, для nextest некоторые тесты могут быть значительно тяжелее других, и таких тестов
следует запускать одновременно меньше. Также необходимо, чтобы некоторые тесты были взаимоисключающими,
или имели другие ограничения параллелизма.

[^1]: Этот адаптер принимает поток future для максимальной универсальности. На практике это часто
    *итератор* future, преобразованный с помощью
    [`stream::iter`](https://docs.rs/futures/latest/futures/stream/fn.iter.html).

## О крейте

Крейт предоставляет два адаптера для потоков.

### 1. Адаптер `future_queue`

Адаптер [`future_queue`](StreamExt::future_queue) позволяет выполнять несколько future одновременно,
ограничивая параллелизм максимальным *весом*.

Вместо потока future этот адаптер принимает поток пар
`(usize, F)`, где `usize` — это вес каждой future,
а `F` — это `FnOnce(FutureQueueContext) -> impl Future`. Этот адаптер будет
планировать и буферизовать future до тех пор, пока постановка в очередь следующей future
не превысит максимальный вес.

* Максимальный вес никогда не превышается во время выполнения future.
* Если вес отдельной future больше максимального, его вес будет установлен равным максимальному.

После планирования всех возможных future этот адаптер будет ждать завершения некоторых из текущих
future и только после уменьшения общего веса ниже максимального будет планировать новые.

Вес future может быть равен нулю, в этом случае она не учитывается в максимальном весе.

Если все веса равны 1, то `future_queue` полностью эквивалентен `buffer_unordered`.

#### Примеры

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

### 2. Адаптер `future_queue_grouped`

Адаптер [`future_queue_grouped`](StreamExt::future_queue_grouped) аналогичен `future_queue`,
но позволяет указывать необязательную *группу* для каждой future. Для каждой группы задаётся
максимальный вес, и future будет запущена только если не превышены ни глобальный, ни групповой вес.

Адаптер работает максимально справедливо с учётом ограничений: он будет планировать future в
порядке их поступления из потока, без переупорядочивания по весу. Когда future из группы
завершается, future из этой группы, находящиеся в очереди, будут планироваться с приоритетом
перед остальными.

Как и в [`future_queue`](StreamExt::future_queue):

* Максимальные глобальный и групповой веса никогда не превышаются во время выполнения future.
* При учёте глобального веса, если вес отдельной future больше максимального, его вес будет
  установлен равным максимальному.
* *Если future принадлежит группе:* при учёте группового веса, если вес превышает максимальный
  вес группы, он будет установлен равным максимальному весу группы.

#### Примеры

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

## Минимально поддерживаемая версия Rust (MSRV)

Минимально поддерживаемая версия Rust — **Rust 1.70.** В любое время поддерживаются как минимум
последние шесть месяцев стабильных релизов Rust.

Пока крейт находится в пререлизе (0.x.x), MSRV может быть увеличен в патч-релизе. После
выхода версии 1.x повышение MSRV будет сопровождаться новым минорным релизом.

## Примечания

Ранее этот крейт назывался `buffer-unordered-weighted`. Он был переименован в `future-queue`,
чтобы название лучше отражало его назначение, а не способ реализации.

## Вклад

См. файл [CONTRIBUTING](https://raw.githubusercontent.com/nextest-rs/future-queue/main/CONTRIBUTING.md) для информации о том, как помочь проекту.

## Лицензия

Этот проект доступен на условиях [лицензии Apache 2.0](https://raw.githubusercontent.com/nextest-rs/future-queue/main/LICENSE-APACHE)
или [лицензии MIT](https://raw.githubusercontent.com/nextest-rs/future-queue/main/LICENSE-MIT).

Код основан на проекте [futures-rs](https://github.com/rust-lang/futures-rs) и используется
в соответствии с лицензиями Apache 2.0 и MIT.

<!--
README.md генерируется из README.tpl с помощью cargo readme. Для регенерации запустите из корня репозитория:

./scripts/regenerate-readmes.sh
-->

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---