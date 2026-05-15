# fastbloom
[![Github](https://img.shields.io/badge/github-8da0cb?style=for-the-badge&labelColor=555555&logo=github)](https://github.com/tomtomwombat/fastbloom)
[![Crates.io](https://img.shields.io/badge/crates.io-fc8d62?style=for-the-badge&labelColor=555555&logo=rust)](https://crates.io/crates/fastbloom)
[![docs.rs](https://img.shields.io/badge/docs.rs-66c2a5?style=for-the-badge&labelColor=555555&logo=docs.rs)](https://docs.rs/fastbloom)
![Downloads](https://img.shields.io/crates/d/fastbloom?style=for-the-badge)

Rustで最速のブルームフィルター。精度を犠牲にしません。完全な並行処理対応で、あらゆるハッシャーと互換性があります。

## 概要

fastbloomはRustで実装された高速で柔軟かつ高精度なブルームフィルターです。fastbloomのデフォルトハッシャーはランダム化されたキーを使用するSipHash-1-3ですが、シードを設定したり任意のハッシャーを使用するように構成できます。fastbloomは既存のブルームフィルター実装よりも2〜20倍高速で、はるかに高精度です。fastbloomの`AtomicBloomFilter`はロック競合を回避する並行ブルームフィルターです。

## 使用法

0.17.xでは異なる（改善された！）アルゴリズムのため、ブルームフィルターのシリアライズ/デシリアライズは以前のバージョンと互換性がありません。

```toml
# Cargo.toml
[dependencies]
fastbloom = "0.17.0"
```
基本的な使い方:
```rust
use fastbloom::BloomFilter;

let mut filter = BloomFilter::with_num_bits(1024).expected_items(2);
filter.insert("42");
filter.insert("🦀");
```
ターゲットの誤検出率を指定してインスタンス化する:
```rust
use fastbloom::BloomFilter;

let filter = BloomFilter::with_false_pos(0.001).items(["42", "🦀"].iter());
assert!(filter.contains("42"));
assert!(filter.contains("🦀"));
```
任意のハッシャーを使用してください:
```rust
use fastbloom::BloomFilter;
use foldhash::fast::RandomState;

let filter = BloomFilter::with_num_bits(1024)
    .hasher(RandomState::default())
    .items(["42", "🦀"].iter());
```
完全な同時実行サポート。`AtomicBloomFilter`はすべてのメソッドが`&self`を取るため、`RwLock<OtherBloomFilter>`の代わりにそのまま使えます：
```rust
use fastbloom::AtomicBloomFilter;

let filter = AtomicBloomFilter::with_num_bits(1024).expected_items(2);
filter.insert("42");
filter.insert("🦀");
```

## 背景
ブルームフィルターは、アイテムの所属を追跡するための基盤となるビット配列によってサポートされる、空間効率の良い近似的な集合メンバーシップデータ構造です。メンバーシップの挿入/確認には、アイテムのハッシュに基づいた位置の複数のビットが設定/確認されます。メンバーシップチェックでの偽陽性はあり得ますが、偽陰性はありません。構築後は、ブルームフィルターの基盤となるメモリ使用量もアイテムあたりのビット数も変わりません。[詳細はこちら。](https://en.wikipedia.org/wiki/Bloom_filter)

```text
hash(4) ──────┬─────┬───────────────┐
              ↓     ↓               ↓
0 0 0 0 0 0 0 1 0 0 1 0 0 0 0 0 0 0 1 0
  ↑           ↑           ↑
  └───────────┴───────────┴──── hash(3) (not in the set)
```
## 実装

fastbloom は、**各アイテムごとに実際のハッシュを1回だけ計算**し、多くのインデックスビットを効率的に導出することで非常に高速です。また、Bloomフィルターに関する他の研究成果を活用しています。fastbloom は、元の64ビットハッシュの2つの32ビット半分に対して「ハッシュ合成」を行います。各後続のハッシュは、元のハッシュ値と異なる定数を組み合わせ、モジュラー演算とビット演算を用いて導出されます。これにより、同じ元のハッシュ関数から派生したにもかかわらず、実質的に独立かつ均一に分布したハッシュ関数の集合が得られます。2つの元のハッシュの合成を計算する方が、異なるシードで再度ハッシュを計算するよりも高速です。この手法は[この論文で詳細に説明されています。](https://www.eecs.harvard.edu/~michaelm/postscripts/rsa2008.pdf)

## 速度
- AMD Ryzen 9 5900X 12コアプロセッサ             (3.70 GHz)
- 64ビットオペレーティングシステム、x64ベースプロセッサ

![perf-non-member](https://github.com/user-attachments/assets/a825d2f7-4cd7-4b6b-a447-fd7f3dab356b)
![perf-member](https://github.com/user-attachments/assets/998f9470-b91f-460c-ad2d-1f197160c210)
> 使用したハッシャー:
> - xxhash: sbbf
> - Sip1-3: bloom, bloomfilter, probabilistic-collections
> - foldhash: fastbloom
> 
> [ベンチマークソース](https://github.com/tomtomwombat/bench-bloom-filters)

## 精度

fastbloom は精度を犠牲にしません。以下は他のBloomフィルタークレートとの誤検知率の比較です:

![fp](https://github.com/user-attachments/assets/17ddaab7-c63f-456a-9e2e-b22c7f994386)

[ベンチマークソース](https://github.com/tomtomwombat/bench-bloom-filters)

## 利用可能な機能

- **`rand`** - デフォルトで有効。`DefaultHasher` がハードウェアソースではなく `thread_rng()` を使用して乱数状態を取得します。ユーザースペースのソースからエントロピーを得る方がかなり高速ですが、追加の依存関係が必要です。この機能を `default-features = false` で無効にすると、`DefaultHasher` は `foldhash` を使ってエントロピーを取得し、速度の代わりにコードフットプリントがよりシンプルになります。
- **`serde`** - 可能な場合に `BloomFilter` が `Serialize` と `Deserialize` を実装します。
- **`loom`** - `AtomicBloomFilter` は [loom](https://github.com/tokio-rs/loom) のアトミックを使用し、loomテストに対応します。

## 参考文献
- [Bloom filter - Wikipedia](https://en.wikipedia.org/wiki/Bloom_filter)
- [Bloom filters debunked: Dispelling 30 Years of bad math with Coq!](https://gopiandcode.uk/logs/log-bloomfilters-debunked.html)
- [Bloom Filter Interactive Demonstration](https://www.jasondavies.com/bloomfilter/)
- [Cache-, Hash- and Space-Efficient Bloom Filters](https://web.archive.org/web/20070623102632/http://algo2.iti.uni-karlsruhe.de/singler/publications/cacheefficientbloomfilters-wea2007.pdf)
- [Less hashing, same performance: Building a better Bloom filter](https://www.eecs.harvard.edu/~michaelm/postscripts/rsa2008.pdf)
- [A fast alternative to the modulo reduction](https://lemire.me/blog/2016/06/27/a-fast-alternative-to-the-modulo-reduction/)


## ライセンス

以下のいずれかの条件でライセンスされています

 * Apache License, Version 2.0
   ([LICENSE-APACHE](LICENSE-APACHE) または http://www.apache.org/licenses/LICENSE-2.0)
 * MIT ライセンス
   ([LICENSE-MIT](LICENSE-MIT) または http://opensource.org/licenses/MIT)

お好みで選択可能です。

## 貢献

明示的に異なる表記がない限り、Apache-2.0ライセンスで定義される
あなたによって意図的に提出された、本作品への貢献は、
追加の条項や条件なしに、上記の二重ライセンスとなります。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-15

---