# future-queue

[![future-queue on crates.io](https://img.shields.io/crates/v/future-queue)](https://crates.io/crates/future-queue)
[![Documentation (latest release)](https://img.shields.io/badge/docs-latest-brightgreen.svg)](https://docs.rs/future-queue/)
[![Documentation (main)](https://img.shields.io/badge/docs-main-purple)](https://nextest-rs.github.io/future-queue/rustdoc/future_queue)
[![Changelog](https://img.shields.io/badge/changelog-latest-blue)](https://raw.githubusercontent.com/nextest-rs/future-queue/main/CHANGELOG.md)
[![License](https://img.shields.io/badge/license-Apache-green.svg)](https://raw.githubusercontent.com/nextest-rs/future-queue/main/LICENSE-APACHE)
[![License](https://img.shields.io/badge/license-MIT-green.svg)](https://raw.githubusercontent.com/nextest-rs/future-queue/main/LICENSE-MIT)

`future_queue`は、複数のFutureを以下のように実行する方法を提供します。

* 並行して
* スポーンされた順番に
* グローバルな制限付きで
* 各Futureごとに指定可能なグループごとの制限付きで

このクレートはGitHub上の [nextest organization](https://github.com/nextest-rs) の一部であり、
[cargo-nextest](https://nexte.st) のニーズに応えるために設計されています。

## 動機

Rustの非同期プログラミングでは、[`buffer_unordered`](https://docs.rs/futures/latest/futures/stream/trait.StreamExt.html#method.buffer_unordered) というアダプタがよく使われます。このアダプタはFutureのストリーム[^1]を受け取り、同時実行数を最大値まで制限しつつ全てのFutureを実行します。

* Futureはストリームが返す順番で開始されます。
* 開始されたFutureは同時にポーリングされ、完了したFutureの出力は任意の順番（unordered）で返されます。

`buffer_unordered`のよくあるユースケースは以下の通りです。

* ネットワークリクエストを並行して送信するが、リモートサーバへの過負荷を防ぐために同時実行数を制限する場合
* [cargo-nextest](https://nexte.st) のようなツールでテストを実行する場合

`buffer_unordered`は多くのケースで有効ですが、全てのFutureを等価な負荷として扱うという問題があります。つまり、あるFutureが他のFutureより多くのリソースを消費する場合や、Futureのサブセットを互いに排他的にしたい場合に対応できません。

特にnextestでは、一部のテストが他よりも重い場合があり、それらのテストは同時に少数だけ実行する必要があります。また、一部のテストは互いに排他的である必要があったり、他の並行制限を設ける必要があります。

[^1]: このアダプタは最大限の汎用性のためにFutureのストリームを受け取ります。実際には、多くの場合*イテレータ*のFutureを [`stream::iter`](https://docs.rs/futures/latest/futures/stream/fn.iter.html) を使ってストリームに変換して使います。

## このクレートについて

このクレートはストリームに対する2つのアダプタを提供します。

### 1. `future_queue`アダプタ

[`future_queue`](StreamExt::future_queue) アダプタは、複数のFutureを同時に実行しつつ、並行度を最大*重み*で制限できます。

このアダプタはFutureのストリームではなく、`(usize, F)`のペアのストリームを受け取ります。ここで`usize`は各Futureの重みを表し、`F`は`FnOnce(FutureQueueContext) -> impl Future`です。このアダプタは次のFutureをキューイングしたときに最大重みを超えない範囲で、Futureをスケジューリングしてバッファします。

* 実行中のFutureの間は、最大重みが超過されることはありません。
* 個々のFutureの重みが最大重みを超えている場合は、そのFutureの重みは最大重みに設定されます。

全てのFutureがスケジューリングされた後は、現在実行中のFutureの一部が完了し、実行中の合計重みが最大重みを下回るまで新たなFutureのスケジューリングを待ちます。

Futureの重みは0にすることもでき、その場合は最大重みにカウントされません。

全ての重みが1の場合、`future_queue`は`buffer_unordered`と全く同じ動作となります。

#### 使用例

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

### 2. `future_queue_grouped`アダプタ

[`future_queue_grouped`](StreamExt::future_queue_grouped) アダプタは`future_queue`と似ていますが、各Futureにオプションで*グループ*を指定できる点が異なります。各グループには最大重みが設定されており、Futureはグローバル・グループ両方の重みが超過しない場合のみスケジューリングされます。

このアダプタは、与えられた制約下で可能な限り公平に動作します：Futureはストリームが返す順でスケジューリングされ、重みによる並び替えは行いません。あるグループのFutureが完了した場合、そのグループのキューイング済みFutureが他のストリームからのFutureより優先的にスケジューリングされます。

[`future_queue`](StreamExt::future_queue)と同様に：

* 実行中のFutureの間は、グローバルおよびグループの最大重みが超過されることはありません。
* グローバル重みの計算時、個々のFutureの重みが最大重みを超える場合は、その重みは最大重みに設定されます。
* *Futureがグループに属する場合*：グループ重みの計算時、その重みが最大グループ重みを超える場合は、その重みは最大グループ重みに設定されます。

#### 使用例

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

## サポートされる最小Rustバージョン（MSRV）

サポートされる最小Rustバージョンは**Rust 1.70**です。常に、少なくとも直近6か月間のRust安定版リリースをサポートします。

本クレートがプレリリース（0.x.x）の間は、パッチリリースでMSRVが上がる可能性があります。1.xに到達した後は、MSRVの更新は新しいマイナーバージョンと共に行われます。

## 注意事項

このクレートは以前は`buffer-unordered-weighted`という名前でしたが、クレートの機能をより明確に示すために`future-queue`へと名称変更されました。

## コントリビュート

協力方法については [CONTRIBUTING](https://raw.githubusercontent.com/nextest-rs/future-queue/main/CONTRIBUTING.md) ファイルをご覧ください。

## ライセンス

このプロジェクトは [Apache 2.0ライセンス](https://raw.githubusercontent.com/nextest-rs/future-queue/main/LICENSE-APACHE) または
[MITライセンス](https://raw.githubusercontent.com/nextest-rs/future-queue/main/LICENSE-MIT) のいずれかの条件で利用できます。

コードは [futures-rs](https://github.com/rust-lang/futures-rs) から派生しており、Apache 2.0およびMITライセンス下で使用されています。

<!--
README.md はREADME.tplからcargo readmeで生成されています。再生成するにはリポジトリのルートで以下を実行してください：

./scripts/regenerate-readmes.sh
-->

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---