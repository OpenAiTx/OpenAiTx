# future-queue

[![future-queue on crates.io](https://img.shields.io/crates/v/future-queue)](https://crates.io/crates/future-queue)
[![Documentation (latest release)](https://img.shields.io/badge/docs-latest-brightgreen.svg)](https://docs.rs/future-queue/)
[![Documentation (main)](https://img.shields.io/badge/docs-main-purple)](https://nextest-rs.github.io/future-queue/rustdoc/future_queue)
[![Changelog](https://img.shields.io/badge/changelog-latest-blue)](https://raw.githubusercontent.com/nextest-rs/future-queue/main/CHANGELOG.md)
[![License](https://img.shields.io/badge/license-Apache-green.svg)](https://raw.githubusercontent.com/nextest-rs/future-queue/main/LICENSE-APACHE)
[![License](https://img.shields.io/badge/license-MIT-green.svg)](https://raw.githubusercontent.com/nextest-rs/future-queue/main/LICENSE-MIT)

`future_queue` 提供了以下几种运行多个 future 的方式：

* 并发执行
* 按照被生成的顺序执行
* 全局并发上限
* 可选为每个 future 指定分组，并为每个分组单独设置并发上限

该 crate 隶属于 GitHub 上的 [nextest 组织](https://github.com/nextest-rs)，
旨在满足 [cargo-nextest](https://nexte.st) 的需求。

## 动机

Rust 的异步编程通常使用名为
[`buffer_unordered`](https://docs.rs/futures/latest/futures/stream/trait.StreamExt.html#method.buffer_unordered)
的适配器：该适配器接收一个 future 的流[^1]，并在限定的最大并发数下执行所有 future。

* future 按照流返回的顺序被启动。
* 一旦启动，future 会被同时轮询，并且完成的 future 输出以任意顺序返回（因此称为 `unordered`）。

`buffer_unordered` 的常见用例包括：

* 并发发送网络请求，但限制最大并发数以避免过载远程服务器。
* 使用类似 [cargo-nextest](https://nexte.st) 的工具并发运行测试。

`buffer_unordered` 适用于许多场景。然而，其问题在于：它将所有 future 视为资源消耗相同，无法区分某些 future 比其他 future 消耗更多资源，或者某些 future 的子集需要互斥执行。

对于 nextest，部分测试比其他测试更重，需要限制同时运行的数量。此外，部分测试需要与其他测试互斥执行，或者需要设置其他并发限制。

[^1]: 该适配器为最大通用性而接收一个 future 流。实际使用中通常是 future 的 *迭代器*，通过
    [`stream::iter`](https://docs.rs/futures/latest/futures/stream/fn.iter.html) 转换而来。

## 关于本 crate

本 crate 提供了针对流的两个适配器。

### 1. `future_queue` 适配器

[`future_queue`](https://raw.githubusercontent.com/nextest-rs/future-queue/main/src/stream_ext.rs) 适配器可同时运行多个 future，
并将并发数限制为最大 *权重*。

与接收 future 流不同，该适配器接收
`(usize, F)` 元组流，其中 `usize` 表示每个 future 的权重，
`F` 是 `FnOnce(FutureQueueContext) -> impl Future`。适配器会调度和缓存 future，直到再排队一个 future 会超过最大权重为止。

* 在运行 future 时，最大权重绝不会被超过。
* 如果单个 future 的权重大于最大权重，则其权重会被设置为最大权重。

所有可调度的 future 被安排后，适配器会等待当前运行的某些 future 完成，并且运行中的总权重降到最大权重以下，然后才调度新 future。

future 的权重可以为零，此时它不会计入最大权重。

如果所有权重均为 1，则 `future_queue` 等价于 `buffer_unordered`。

#### 示例

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

### 2. `future_queue_grouped` 适配器

[`future_queue_grouped`](https://raw.githubusercontent.com/nextest-rs/future-queue/main/src/stream_ext.rs) 适配器类似于 `future_queue`，
但可以为每个 future 可选指定一个 *分组*。每个分组有自己的最大权重，只有当全局和分组权重都未被超过时，future 才会被调度。

在给定约束下，该适配器尽可能公平：它会按照流返回 future 的顺序调度，不会根据权重重新排序。当某个分组的 future 完成后，该分组中已排队的 future 会被优先调度，再调度流中其他分组的 future。

同样地，参考 [`future_queue`](https://raw.githubusercontent.com/nextest-rs/future-queue/main/src/stream_ext.rs)：

* 在运行 future 时，全局和分组的最大权重都不会被超过。
* 全局权重统计时，如果单个 future 的权重大于最大权重，则其权重被设置为最大权重。
* *如果 future 属于分组*：分组权重统计时，如果其权重大于该分组最大权重，则权重被设置为分组最大权重。

#### 示例

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

## 最低支持的 Rust 版本（MSRV）

最低支持的 Rust 版本为 **Rust 1.70**。始终支持至少过去六个月的 Rust 稳定版。

在 crate 处于预发布（0.x.x）期间，MSRV 可能会在补丁版本中提升。一旦 crate 达到 1.x，任何 MSRV 提升都将伴随次版本号提升。

## 备注

本 crate 之前名为 `buffer-unordered-weighted`。更名为 `future-queue`，以更准确描述 crate 的功能，而非实现方式。

## 贡献

参见 [CONTRIBUTING](https://raw.githubusercontent.com/nextest-rs/future-queue/main/CONTRIBUTING.md) 文件了解如何参与贡献。

## 许可协议

本项目可在 [Apache 2.0 许可证](https://raw.githubusercontent.com/nextest-rs/future-queue/main/LICENSE-APACHE) 或
[MIT 许可证](https://raw.githubusercontent.com/nextest-rs/future-queue/main/LICENSE-MIT) 下使用。

代码源自 [futures-rs](https://github.com/rust-lang/futures-rs)，并遵循 Apache 2.0 和 MIT 协议。

<!--
README.md 由 cargo readme 从 README.tpl 生成。要重新生成，请在仓库根目录下运行：

./scripts/regenerate-readmes.sh
-->

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---