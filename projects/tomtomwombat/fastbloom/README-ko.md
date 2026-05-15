# fastbloom
[![Github](https://img.shields.io/badge/github-8da0cb?style=for-the-badge&labelColor=555555&logo=github)](https://github.com/tomtomwombat/fastbloom)
[![Crates.io](https://img.shields.io/badge/crates.io-fc8d62?style=for-the-badge&labelColor=555555&logo=rust)](https://crates.io/crates/fastbloom)
[![docs.rs](https://img.shields.io/badge/docs.rs-66c2a5?style=for-the-badge&labelColor=555555&logo=docs.rs)](https://docs.rs/fastbloom)
![Downloads](https://img.shields.io/crates/d/fastbloom?style=for-the-badge)

Rust에서 가장 빠른 Bloom 필터입니다. 정확도 손실 없이 완전한 동시성 지원과 모든 해셔와 호환됩니다.

## 개요

fastbloom은 Rust로 구현된 빠르고 유연하며 정확한 Bloom 필터입니다. fastbloom의 기본 해셔는 무작위 키를 사용하는 SipHash-1-3이지만, 시드를 설정하거나 어떤 해셔든 사용할 수 있도록 구성할 수 있습니다. fastbloom은 기존 Bloom 필터 구현보다 2~20배 빠르고 훨씬 더 정확합니다. fastbloom의 `AtomicBloomFilter`는 락 경합을 피하는 동시성 Bloom 필터입니다.

## 사용법

0.17.x 버전에서 다른(개선된!) 알고리즘 때문에 Bloom 필터의 직렬화/역직렬화가 이전 버전과 호환되지 않습니다.

```toml
# Cargo.toml
[dependencies]
fastbloom = "0.17.0"
```
기본 사용법:
```rust
use fastbloom::BloomFilter;

let mut filter = BloomFilter::with_num_bits(1024).expected_items(2);
filter.insert("42");
filter.insert("🦀");
```
목표 오탐률로 인스턴스화:
```rust
use fastbloom::BloomFilter;

let filter = BloomFilter::with_false_pos(0.001).items(["42", "🦀"].iter());
assert!(filter.contains("42"));
assert!(filter.contains("🦀"));
```
임의의 해시 함수를 사용하세요:
```rust
use fastbloom::BloomFilter;
use foldhash::fast::RandomState;

let filter = BloomFilter::with_num_bits(1024)
    .hasher(RandomState::default())
    .items(["42", "🦀"].iter());
```
완전한 동시성 지원. `AtomicBloomFilter`는 모든 메서드가 `&self`를 받기 때문에 `RwLock<OtherBloomFilter>`의 대체제로 바로 사용할 수 있습니다:
```rust
use fastbloom::AtomicBloomFilter;

let filter = AtomicBloomFilter::with_num_bits(1024).expected_items(2);
filter.insert("42");
filter.insert("🦀");
```

## 배경  
블룸 필터는 항목의 멤버십을 추적하기 위해 기본 비트 배열을 지원하는 공간 효율적인 근사 멤버십 집합 데이터 구조입니다. 멤버십 삽입/확인을 위해 항목의 해시를 기반으로 한 위치에서 여러 비트를 설정/확인합니다. 멤버십 확인 시 거짓 긍정은 발생할 수 있지만 거짓 부정은 발생하지 않습니다. 한 번 구성되면 블룸 필터의 기본 메모리 사용량이나 항목당 비트 수는 변경되지 않습니다. [자세히 보기.](https://en.wikipedia.org/wiki/Bloom_filter)

```text
hash(4) ──────┬─────┬───────────────┐
              ↓     ↓               ↓
0 0 0 0 0 0 0 1 0 0 1 0 0 0 0 0 0 0 1 0
  ↑           ↑           ↑
  └───────────┴───────────┴──── hash(3) (not in the set)
```
## 구현

fastbloom은 각 아이템당 **단 하나의 실제 해시만으로도** 많은 인덱스 비트를 효율적으로 파생시키고, Bloom 필터에 관한 다른 연구 결과를 활용하기 때문에 매우 빠릅니다. fastbloom은 원래 64비트 해시의 두 32비트 절반에 대해 "해시 합성(hash composition)"을 사용합니다. 각 후속 해시는 원래 해시 값에 서로 다른 상수를 모듈러 산술과 비트 연산을 이용해 결합하여 파생됩니다. 이로 인해 같은 원래 해시 함수에서 파생되었음에도 불구하고 효과적으로 독립적이고 균등 분포된 해시 함수 집합이 만들어집니다. 두 원래 해시의 합성을 계산하는 것이 다른 시드를 사용해 해시를 다시 계산하는 것보다 빠릅니다. 이 기법은 [이 논문에서 자세히 설명되어 있습니다.](https://www.eecs.harvard.edu/~michaelm/postscripts/rsa2008.pdf)

## 속도
- AMD Ryzen 9 5900X 12코어 프로세서             (3.70 GHz)
- 64비트 운영체제, x64 기반 프로세서

![perf-non-member](https://github.com/user-attachments/assets/a825d2f7-4cd7-4b6b-a447-fd7f3dab356b)
![perf-member](https://github.com/user-attachments/assets/998f9470-b91f-460c-ad2d-1f197160c210)
> 사용된 해시 함수:
> - xxhash: sbbf
> - Sip1-3: bloom, bloomfilter, probabilistic-collections
> - foldhash: fastbloom
> 
> [벤치마크 출처](https://github.com/tomtomwombat/bench-bloom-filters)

## 정확도

fastbloom은 정확도를 희생하지 않습니다. 아래는 다른 Bloom 필터 크레이트들과의 오탐률 비교입니다:

![fp](https://github.com/user-attachments/assets/17ddaab7-c63f-456a-9e2e-b22c7f994386)

[벤치마크 출처](https://github.com/tomtomwombat/bench-bloom-filters)

## 사용 가능한 기능

- **`rand`** - 기본 활성화되어 있으며, `DefaultHasher`가 하드웨어 소스 대신 `thread_rng()`를 사용해 랜덤 상태를 생성합니다. 사용자 공간 소스에서 엔트로피를 얻는 것이 훨씬 빠르지만, 이를 위해 추가 의존성이 필요합니다. 이 기능을 `default-features = false`로 비활성화하면 `DefaultHasher`가 `foldhash`를 사용해 엔트로피를 생성하며, 속도는 느리지만 코드가 훨씬 단순해집니다.
- **`serde`** - 가능할 경우 `BloomFilter`가 `Serialize`와 `Deserialize`를 구현합니다.
- **`loom`** - `AtomicBloomFilter`는 [loom](https://github.com/tokio-rs/loom) 원자적 연산을 사용하여 loom 테스트와 호환됩니다.

## 참고 문헌
- [Bloom filter - 위키백과](https://en.wikipedia.org/wiki/Bloom_filter)
- [Bloom filters debunked: Dispelling 30 Years of bad math with Coq!](https://gopiandcode.uk/logs/log-bloomfilters-debunked.html)
- [Bloom Filter Interactive Demonstration](https://www.jasondavies.com/bloomfilter/)
- [Cache-, Hash- and Space-Efficient Bloom Filters](https://web.archive.org/web/20070623102632/http://algo2.iti.uni-karlsruhe.de/singler/publications/cacheefficientbloomfilters-wea2007.pdf)
- [Less hashing, same performance: Building a better Bloom filter](https://www.eecs.harvard.edu/~michaelm/postscripts/rsa2008.pdf)
- [A fast alternative to the modulo reduction](https://lemire.me/blog/2016/06/27/a-fast-alternative-to-the-modulo-reduction/)


## 라이선스

다음 중 하나의 라이선스 하에 허가됩니다

 * Apache 라이선스, 버전 2.0
   ([LICENSE-APACHE](LICENSE-APACHE) 또는 http://www.apache.org/licenses/LICENSE-2.0)
 * MIT 라이선스
   ([LICENSE-MIT](LICENSE-MIT) 또는 http://opensource.org/licenses/MIT)

선택에 따라 적용됩니다.

## 기여

명시적으로 달리 명시하지 않는 한, Apache-2.0 라이선스에 정의된 바와 같이
귀하가 작업에 포함시키기 위해 의도적으로 제출한 모든 기여는
추가 조건 없이 위와 같이 이중 라이선스가 적용됩니다.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-15

---