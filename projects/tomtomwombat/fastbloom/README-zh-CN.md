# fastbloom
[![Github](https://img.shields.io/badge/github-8da0cb?style=for-the-badge&labelColor=555555&logo=github)](https://github.com/tomtomwombat/fastbloom)
[![Crates.io](https://img.shields.io/badge/crates.io-fc8d62?style=for-the-badge&labelColor=555555&logo=rust)](https://crates.io/crates/fastbloom)
[![docs.rs](https://img.shields.io/badge/docs.rs-66c2a5?style=for-the-badge&labelColor=555555&logo=docs.rs)](https://docs.rs/fastbloom)
![Downloads](https://img.shields.io/crates/d/fastbloom?style=for-the-badge)

Rust中最快的布隆过滤器。无精度妥协。完全支持并发，兼容任何哈希函数。

## 概述

fastbloom是一个用Rust实现的快速、灵活且精准的布隆过滤器。fastbloom的默认哈希函数是使用随机密钥的SipHash-1-3，但可以通过种子或配置使用任何哈希函数。fastbloom比现有布隆过滤器实现快2到20倍，且精度高出数个数量级。fastbloom的`AtomicBloomFilter`是一个避免锁争用的并发布隆过滤器。

## 用法

由于0.17.x版本采用了不同（改进的！）算法，布隆过滤器的序列化/反序列化与之前版本不兼容。

```toml
# Cargo.toml
[dependencies]
fastbloom = "0.17.0"
```
基本用法：
```rust
use fastbloom::BloomFilter;

let mut filter = BloomFilter::with_num_bits(1024).expected_items(2);
filter.insert("42");
filter.insert("🦀");
```
以目标误报率实例化：
```rust
use fastbloom::BloomFilter;

let filter = BloomFilter::with_false_pos(0.001).items(["42", "🦀"].iter());
assert!(filter.contains("42"));
assert!(filter.contains("🦀"));
```
使用任何哈希器：
```rust
use fastbloom::BloomFilter;
use foldhash::fast::RandomState;

let filter = BloomFilter::with_num_bits(1024)
    .hasher(RandomState::default())
    .items(["42", "🦀"].iter());
```
完全支持并发。`AtomicBloomFilter` 是 `RwLock<OtherBloomFilter>` 的直接替代品，因为所有方法都接收 `&self`：
```rust
use fastbloom::AtomicBloomFilter;

let filter = AtomicBloomFilter::with_num_bits(1024).expected_items(2);
filter.insert("42");
filter.insert("🦀");
```

## 背景
布隆过滤器是一种空间高效的近似成员集合数据结构，由底层的位数组支持，用于跟踪项目成员资格。插入/检查成员时，会根据项目的哈希值设置/检查多个位的位置。成员检查可能出现误报，但不会出现漏报。构建完成后，布隆过滤器的底层内存使用量和每个项目的位数都不会改变。[查看更多。](https://en.wikipedia.org/wiki/Bloom_filter)

```text
hash(4) ──────┬─────┬───────────────┐
              ↓     ↓               ↓
0 0 0 0 0 0 0 1 0 0 1 0 0 0 0 0 0 0 1 0
  ↑           ↑           ↑
  └───────────┴───────────┴──── hash(3) (not in the set)
```
## 实现

fastbloom 之所以极其快速，是因为它通过**每个元素仅使用一次真实哈希**高效地派生出多个索引位，并利用了关于布隆过滤器的其他研究成果。fastbloom 对原始 64 位哈希的两个 32 位半部分采用“哈希组合”技术。每个后续哈希通过将原始哈希值与不同常数结合，使用模运算和按位操作导出。这样得到的一组哈希函数实际上是独立且均匀分布的，尽管它们是从相同的原始哈希函数派生的。计算两个原始哈希的组合比分别使用不同种子重新计算哈希要快。这一技术在[这篇论文中有详细解释。](https://www.eecs.harvard.edu/~michaelm/postscripts/rsa2008.pdf)

## 速度
- AMD Ryzen 9 5900X 12核处理器             (3.70 GHz)
- 64 位操作系统，基于 x64 的处理器

![perf-non-member](https://github.com/user-attachments/assets/a825d2f7-4cd7-4b6b-a447-fd7f3dab356b)
![perf-member](https://github.com/user-attachments/assets/998f9470-b91f-460c-ad2d-1f197160c210)
> 使用的哈希器：
> - xxhash: sbbf
> - Sip1-3: bloom, bloomfilter, probabilistic-collections
> - foldhash: fastbloom
> 
> [基准测试来源](https://github.com/tomtomwombat/bench-bloom-filters)

## 准确度

fastbloom 并不牺牲准确度。以下是与其他布隆过滤器库的误报率对比：

![fp](https://github.com/user-attachments/assets/17ddaab7-c63f-456a-9e2e-b22c7f994386)

[基准测试来源](https://github.com/tomtomwombat/bench-bloom-filters)

## 可用特性

- **`rand`** - 默认启用，该特性使 `DefaultHasher` 使用 `thread_rng()` 作为随机状态源，而非硬件源。从用户空间获取熵明显更快，但需要额外依赖。禁用此特性（使用 `default-features = false`）则使 `DefaultHasher` 使用 `foldhash` 获取熵，代码更简洁但速度较慢。
- **`serde`** - 当可能时，`BloomFilter` 实现了 `Serialize` 和 `Deserialize`。
- **`loom`** - `AtomicBloomFilter` 使用 [loom](https://github.com/tokio-rs/loom) 的原子操作，支持 loom 测试。

## 参考资料
- [布隆过滤器 - 维基百科](https://en.wikipedia.org/wiki/Bloom_filter)
- [布隆过滤器破解：用 Coq 驳斥 30 年的错误数学！](https://gopiandcode.uk/logs/log-bloomfilters-debunked.html)
- [布隆过滤器交互式演示](https://www.jasondavies.com/bloomfilter/)
- [缓存、哈希和空间高效的布隆过滤器](https://web.archive.org/web/20070623102632/http://algo2.iti.uni-karlsruhe.de/singler/publications/cacheefficientbloomfilters-wea2007.pdf)
- [更少哈希，性能不变：构建更好的布隆过滤器](https://www.eecs.harvard.edu/~michaelm/postscripts/rsa2008.pdf)
- [模运算的快速替代方法](https://lemire.me/blog/2016/06/27/a-fast-alternative-to-the-modulo-reduction/)


## 许可证

可选择以下任一许可证

 * Apache 许可证，版本 2.0
   ([LICENSE-APACHE](LICENSE-APACHE) 或 http://www.apache.org/licenses/LICENSE-2.0)
 * MIT 许可证
   ([LICENSE-MIT](LICENSE-MIT) 或 http://opensource.org/licenses/MIT)

由您选择。

## 贡献

除非您明确说明，否则任何您有意提交用于包含在本作品中的贡献，
根据 Apache-2.0 许可证定义，应按上述双重许可授权，
且无任何额外条款或条件。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-15

---