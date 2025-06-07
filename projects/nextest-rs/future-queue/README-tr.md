# future-queue

[![future-queue on crates.io](https://img.shields.io/crates/v/future-queue)](https://crates.io/crates/future-queue)
[![Documentation (latest release)](https://img.shields.io/badge/docs-latest-brightgreen.svg)](https://docs.rs/future-queue/)
[![Documentation (main)](https://img.shields.io/badge/docs-main-purple)](https://nextest-rs.github.io/future-queue/rustdoc/future_queue)
[![Changelog](https://img.shields.io/badge/changelog-latest-blue)](https://raw.githubusercontent.com/nextest-rs/future-queue/main/CHANGELOG.md)
[![License](https://img.shields.io/badge/license-Apache-green.svg)](https://raw.githubusercontent.com/nextest-rs/future-queue/main/LICENSE-APACHE)
[![License](https://img.shields.io/badge/license-MIT-green.svg)](https://raw.githubusercontent.com/nextest-rs/future-queue/main/LICENSE-MIT)

`future_queue` birden fazla future'ın çalıştırılması için yollar sunar:

* aynı anda (concurrently)
* başlatıldıkları sırayla
* global sınırlar ile
* ve her future için isteğe bağlı olarak belirtilen, kendine ait sınırları olan bir grup ile.

Bu crate, GitHub'daki [nextest organizasyonunun](https://github.com/nextest-rs) bir parçasıdır ve
[cargo-nextest](https://nexte.st) ihtiyaçlarını karşılamak üzere tasarlanmıştır.

## Motivasyon

Rust'ta asenkron programlama genellikle
[`buffer_unordered`](https://docs.rs/futures/latest/futures/stream/trait.StreamExt.html#method.buffer_unordered)
adında bir adaptör kullanır: bu adaptör, bir future akışı[^1] alır ve tüm future'ları belirli bir
eşzamanlılık sınırına kadar çalıştırır.

* Future'lar, akışın onları döndürdüğü sırayla başlatılır.
* Başlatıldıktan sonra, future'lar aynı anda poll edilir ve tamamlanan future çıktıları,
  rastgele bir sırada döndürülür (`unordered` bu yüzden kullanılır).

`buffer_unordered` için yaygın kullanım örnekleri şunlardır:

* Ağ isteklerini aynı anda göndermek, ancak uzak sunucuyu aşırı yüklememek için eşzamanlılık miktarını sınırlamak.
* [cargo-nextest](https://nexte.st) gibi bir araçla testleri çalıştırmak.

`buffer_unordered` birçok kullanım durumu için iyi çalışır. Ancak, bununla ilgili bir sorun,
tüm future'ları eşit derecede zorlayıcı olarak değerlendirmesidir: bazı future'ların diğerlerinden
daha fazla kaynak tükettiğini veya bazı future alt kümelerinin diğerlerinden karşılıklı olarak
hariç tutulması gerektiğini belirtmenin bir yolu yoktur.

Özellikle nextest için, bazı testler diğerlerinden çok daha ağır olabilir ve bu testlerden
daha azı aynı anda çalıştırılmalıdır. Ayrıca, bazı testlerin diğerlerinden karşılıklı olarak
hariç tutulması veya başka eşzamanlılık sınırları uygulanması gerekebilir.

[^1]: Bu adaptör, maksimum genel kullanım için bir future akışı alır. Pratikte, bu genellikle
    [`stream::iter`](https://docs.rs/futures/latest/futures/stream/fn.iter.html) ile çevrilen bir
    *iterator* olur.

## Bu crate hakkında

Bu crate, akışlar (streams) üzerinde iki adaptör sağlar.

### 1. `future_queue` adaptörü

[`future_queue`](StreamExt::future_queue) adaptörü, birden fazla future'ı aynı anda
çalıştırabilir ve eşzamanlılığı maksimum bir *ağırlık* ile sınırlar.

Bu adaptör, bir future akışı almak yerine,
`(usize, F)` çiftlerinden oluşan bir akış alır. Burada `usize`, her future'ın ağırlığını,
`F` ise `FnOnce(FutureQueueContext) -> impl Future` fonksiyonunu belirtir. Bu adaptör,
bir sonraki future'ı sıraya eklemek maksimum ağırlığı aşacaksa, future'ları sıraya alır ve
çalıştırır.

* Future'lar çalıştırılırken maksimum ağırlık asla aşılmaz.
* Bir future'ın ağırlığı maksimum ağırlıktan büyükse, ağırlığı maksimum ağırlığa ayarlanır.

Tüm olası future'lar sıraya alındığında, bu adaptör mevcut future'ların bazıları tamamlanana ve
çalışan future'ların mevcut ağırlığı maksimum ağırlığın altına düşene kadar bekler, sonra yeni
future'ları sıraya alır.

Bir future'ın ağırlığı sıfır olabilir, bu durumda maksimum ağırlığa dahil edilmez.

Tüm ağırlıklar 1 ise, `future_queue` tam olarak `buffer_unordered` ile aynıdır.

#### Örnekler

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

### 2. `future_queue_grouped` adaptörü

[`future_queue_grouped`](StreamExt::future_queue_grouped) adaptörü, `future_queue` gibidir,
ancak her future için isteğe bağlı bir *grup* belirtmek mümkündür. Her grubun bir maksimum
ağırlığı vardır ve bir future yalnızca hem maksimum ağırlık hem de grup ağırlığı aşılmamışsa
sıraya alınır.

Adaptör, verilen kısıtlamalar altında mümkün olduğunca adildir: future'ları, akışın onları
döndürdüğü sırayla sıraya alır, ağırlığa göre herhangi bir yeniden sıralama yapmaz.
Bir gruptan bir future tamamlandığında, bu gruptaki sıradaki future'lar, sağlanan akıştan gelen
diğer future'lardan önce tercihli olarak sıraya alınacaktır.

[`future_queue`](StreamExt::future_queue) ile olduğu gibi:

* Future'lar çalıştırılırken, maksimum global ve grup ağırlıkları asla aşılmaz.
* Global ağırlıklar için hesaplarken, bir future'ın ağırlığı maksimum ağırlıktan büyükse,
  ağırlığı maksimum ağırlığa ayarlanır.
* *Eğer bir future bir gruba aitse:* Grup ağırlığı için hesaplarken, ağırlığı maksimum grup
  ağırlığından büyükse, ağırlığı maksimum grup ağırlığına ayarlanır.

#### Örnekler

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

## Desteklenen Minimum Rust Sürümü (MSRV)

Desteklenen minimum Rust sürümü **Rust 1.70.** Her zaman, en az son altı ayın Rust stable sürümleri desteklenir.

Bu crate bir ön sürümdeyken (0.x.x), MSRV bir yama sürümünde yükseltilebilir. Crate 1.x sürümüne
ulaştığında, herhangi bir MSRV yükseltmesi yeni bir minör sürümle birlikte gelir.

## Notlar

Bu crate daha önce `buffer-unordered-weighted` olarak adlandırılıyordu. Crate'in ne yaptığına dair
daha açıklayıcı olması için adı `future-queue` olarak değiştirildi.

## Katkı Sağlama

Yardımcı olmak için [CONTRIBUTING](https://raw.githubusercontent.com/nextest-rs/future-queue/main/CONTRIBUTING.md) dosyasına bakın.

## Lisans

Bu proje, [Apache 2.0 lisansı](https://raw.githubusercontent.com/nextest-rs/future-queue/main/LICENSE-APACHE)
veya [MIT lisansı](https://raw.githubusercontent.com/nextest-rs/future-queue/main/LICENSE-MIT) şartları altında mevcuttur.

Kod, [futures-rs](https://github.com/rust-lang/futures-rs) projesinden türetilmiştir ve Apache 2.0 ile MIT lisansları altında kullanılmaktadır.

<!--
README.md, cargo readme ile README.tpl dosyasından üretilmiştir. Yeniden oluşturmak için depo kökünden şunu çalıştırın:

./scripts/regenerate-readmes.sh
-->

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---