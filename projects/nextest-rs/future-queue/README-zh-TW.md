# future-queue

[![future-queue on crates.io](https://img.shields.io/crates/v/future-queue)](https://crates.io/crates/future-queue)
[![Documentation (latest release)](https://img.shields.io/badge/docs-latest-brightgreen.svg)](https://docs.rs/future-queue/)
[![Documentation (main)](https://img.shields.io/badge/docs-main-purple)](https://nextest-rs.github.io/future-queue/rustdoc/future_queue)
[![Changelog](https://img.shields.io/badge/changelog-latest-blue)](https://raw.githubusercontent.com/nextest-rs/future-queue/main/CHANGELOG.md)
[![License](https://img.shields.io/badge/license-Apache-green.svg)](https://raw.githubusercontent.com/nextest-rs/future-queue/main/LICENSE-APACHE)
[![License](https://img.shields.io/badge/license-MIT-green.svg)](https://raw.githubusercontent.com/nextest-rs/future-queue/main/LICENSE-MIT)

`future_queue` 提供了執行多個 future 的方式：

* 並發執行
* 依照它們被啟動的順序
* 全域限制
* 並可為每個 future 指定一個可選的群組，每個群組有其自己的限制。

這個 crate 屬於 GitHub 上的 [nextest 組織](https://github.com/nextest-rs)，
並設計來滿足 [cargo-nextest](https://nexte.st) 的需求。

## 動機

Rust 的非同步程式設計經常使用一個稱為
[`buffer_unordered`](https://docs.rs/futures/latest/futures/stream/trait.StreamExt.html#method.buffer_unordered) 的 adaptor：
這個 adaptor 接收一個 future 的 stream[^1]，並以最大併發數限制來執行所有 future。

* futures 會按照 stream 回傳它們的順序被啟動。
* 一旦被啟動，futures 會同時被 poll，完成的 future 輸出會以任意順序回傳（因此稱為 `unordered`）。

`buffer_unordered` 的常見使用情境包括：

* 並發發送網路請求，但限制併發數以避免壓垮遠端伺服器。
* 使用像 [cargo-nextest](https://nexte.st) 這樣的工具執行測試。

`buffer_unordered` 適用於許多情境。然而，它的一個問題是將所有 future 視為同等消耗：無法指定某些 future 消耗的資源比其他多，或是某些 future 的子集需要彼此互斥。

對 nextest 而言，某些測試可能比其他測試更重，因此同時執行的這類測試數量應更少。此外，某些測試需要與其他測試互斥，或者對它們施加其他併發限制。

[^1]: 為了最大通用性，這個 adaptor 接收的是 future 的 stream。實務上，這通常是一個 *iterator*，經由
    [`stream::iter`](https://docs.rs/futures/latest/futures/stream/fn.iter.html) 轉換而來。

## 關於本 crate

本 crate 為 stream 提供了兩個 adaptor。

### 1. `future_queue` adaptor

[`future_queue`](StreamExt::future_queue) adaptor 能同時執行多個 future，
並將併發數限制在最大「權重」。

這個 adaptor 並不是接收一個 future 的 stream，而是接收一個
`(usize, F)` 組合的 stream，其中 `usize` 表示每個 future 的權重，
而 `F` 是 `FnOnce(FutureQueueContext) -> impl Future`。這個 adaptor
會排程並緩衝要執行的 futures，直到佇列中的下一個 future 會超過最大權重才停止。

* 當 futures 執行時，最大權重永遠不會被超過。
* 如果單一 future 的權重大於最大權重，其權重會被設為最大權重。

一旦所有能排程的 futures 都已安排，這個 adaptor 會等到部分目前執行中的 futures 完成，
且目前執行中的權重降到最大權重以下，再安排新的 future。

future 的權重可以是零，此時它不會計入最大權重。

如果所有權重都是 1，則 `future_queue` 等同於 `buffer_unordered`。

#### 範例

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

### 2. `future_queue_grouped` adaptor

[`future_queue_grouped`](StreamExt::future_queue_grouped) adaptor 類似於 `future_queue`，
但允許為每個 future 指定一個可選的「群組」。每個群組有一個最大權重，
只有當全域最大權重與該群組權重皆未超過時，future 才會被排程。

此 adaptor 會在限制條件下盡可能公平：它會按照 stream 回傳的順序排程 futures，
不會根據權重重新排序。當某群組的 future 完成時，該群組中排隊的 futures 會被優先排程，
再輪到來自其他群組的 future。

與 [`future_queue`](StreamExt::future_queue) 一樣：

* 當 futures 執行時，最大全域權重與群組權重都不會被超過。
* 計算全域權重時，若單一 future 的權重大於最大權重，其權重會被設為最大權重。
* *若 future 屬於某個群組：* 計算群組權重時，若其權重大於最大群組權重，其權重會被設為最大群組權重。

#### 範例

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

## 最低支援 Rust 版本（MSRV）

最低支援的 Rust 版本為 **Rust 1.70。** 任一時刻，至少支援過去六個月的 Rust 穩定版。

在這個 crate 為預發佈（0.x.x）期間，MSRV 可能會在 patch 版升級時調高。當這個 crate 達到 1.x 後，
任何 MSRV 的調升都會隨著新的次版本一同發佈。

## 備註

本 crate 原名為 `buffer-unordered-weighted`，後來更名為 `future-queue`，
以更清楚描述 crate 的功能而非實作方式。

## 貢獻方式

請參閱 [CONTRIBUTING](https://raw.githubusercontent.com/nextest-rs/future-queue/main/CONTRIBUTING.md) 文件了解如何參與貢獻。

## 授權條款

本專案可依 [Apache 2.0 授權](https://raw.githubusercontent.com/nextest-rs/future-queue/main/LICENSE-APACHE) 或
[MIT 授權](https://raw.githubusercontent.com/nextest-rs/future-queue/main/LICENSE-MIT) 進行使用。

本程式碼源自 [futures-rs](https://github.com/rust-lang/futures-rs)，
並依 Apache 2.0 與 MIT 授權條款使用。

<!--
README.md 是由 cargo readme 依據 README.tpl 產生。如需重新產生，請於專案根目錄執行：

./scripts/regenerate-readmes.sh
-->

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---