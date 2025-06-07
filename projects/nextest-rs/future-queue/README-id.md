# future-queue

[![future-queue on crates.io](https://img.shields.io/crates/v/future-queue)](https://crates.io/crates/future-queue)
[![Documentation (latest release)](https://img.shields.io/badge/docs-latest-brightgreen.svg)](https://docs.rs/future-queue/)
[![Documentation (main)](https://img.shields.io/badge/docs-main-purple)](https://nextest-rs.github.io/future-queue/rustdoc/future_queue)
[![Changelog](https://img.shields.io/badge/changelog-latest-blue)](https://raw.githubusercontent.com/nextest-rs/future-queue/main/CHANGELOG.md)
[![License](https://img.shields.io/badge/license-Apache-green.svg)](https://raw.githubusercontent.com/nextest-rs/future-queue/main/LICENSE-APACHE)
[![License](https://img.shields.io/badge/license-MIT-green.svg)](https://raw.githubusercontent.com/nextest-rs/future-queue/main/LICENSE-MIT)

`future_queue` menyediakan cara untuk menjalankan beberapa future:

* secara konkuren
* dalam urutan saat mereka dibuat
* dengan batas global
* dan dengan grup opsional yang ditentukan untuk setiap future, masing-masing dengan batasnya sendiri.

Crate ini merupakan bagian dari [organisasi nextest](https://github.com/nextest-rs) di GitHub, dan
dirancang untuk memenuhi kebutuhan [cargo-nextest](https://nexte.st).

## Motivasi

Pemrograman async di Rust sering menggunakan adaptor yang disebut
[`buffer_unordered`](https://docs.rs/futures/latest/futures/stream/trait.StreamExt.html#method.buffer_unordered):
adaptor ini mengambil stream dari future[^1], dan mengeksekusi semua future yang dibatasi oleh jumlah konkuren maksimum.

* Future dimulai dalam urutan saat stream mengembalikannya.
* Setelah dimulai, future akan di-poll secara bersamaan, dan output future yang selesai akan dikembalikan dalam
  urutan acak (oleh karena itu disebut `unordered`).

Penggunaan umum untuk `buffer_unordered` meliputi:

* Mengirim permintaan jaringan secara konkuren, namun membatasi tingkat konkuren untuk menghindari
  membebani server jarak jauh.
* Menjalankan pengujian dengan alat seperti [cargo-nextest](https://nexte.st).

`buffer_unordered` bekerja dengan baik untuk banyak kasus penggunaan. Namun, satu masalahnya adalah memperlakukan
semua future sebagai sama beratnya: tidak ada cara untuk menyatakan bahwa beberapa future mengonsumsi lebih banyak sumber daya
daripada yang lain, atau bahwa beberapa subset future harus saling dikecualikan.

Untuk nextest secara khusus, beberapa pengujian bisa jauh lebih berat daripada yang lain, dan lebih sedikit pengujian tersebut
yang sebaiknya dijalankan secara bersamaan. Selain itu, beberapa pengujian perlu saling dikecualikan, atau
batas konkuren lain diterapkan pada mereka.

[^1]: Adaptor ini mengambil stream dari future untuk generalitas maksimum. Dalam praktiknya, ini seringkali
    berupa *iterator* dari future, diubah menggunakan
    [`stream::iter`](https://docs.rs/futures/latest/futures/stream/fn.iter.html).

## Tentang crate ini

Crate ini menyediakan dua adaptor pada stream.

### 1. Adaptor `future_queue`

Adaptor [`future_queue`](https://raw.githubusercontent.com/nextest-rs/future-queue/main/src/stream_ext.rs) dapat menjalankan beberapa future secara bersamaan,
membatasi tingkat konkuren ke *bobot* maksimum.

Alih-alih mengambil stream dari future, adaptor ini mengambil stream dari
pasangan `(usize, F)`, di mana `usize` menunjukkan bobot dari setiap future,
dan `F` adalah `FnOnce(FutureQueueContext) -> impl Future`. Adaptor ini akan
menjadwalkan dan menampung future untuk dijalankan hingga mengantrikan future berikutnya akan
melebihi bobot maksimum.

* Bobot maksimum tidak pernah terlampaui saat future sedang dijalankan.
* Jika bobot sebuah future lebih besar dari bobot maksimum, bobotnya akan
  diatur ke bobot maksimum.

Setelah semua future yang memungkinkan dijadwalkan, adaptor ini akan menunggu hingga beberapa future yang sedang berjalan selesai, dan bobot saat ini dari future yang berjalan turun di bawah bobot maksimum, sebelum menjadwalkan future baru.

Bobot sebuah future dapat bernilai nol, dalam hal ini tidak dihitung terhadap bobot maksimum.

Jika semua bobot adalah 1, maka `future_queue` sama persis dengan `buffer_unordered`.

#### Contoh

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

### 2. Adaptor `future_queue_grouped`

Adaptor [`future_queue_grouped`](https://raw.githubusercontent.com/nextest-rs/future-queue/main/src/stream_ext.rs) mirip dengan `future_queue`,
kecuali memungkinkan untuk menentukan *grup* opsional untuk setiap future. Setiap grup memiliki bobot maksimum,
dan sebuah future hanya akan dijadwalkan jika baik bobot maksimum global maupun bobot grup tidak terlampaui.

Adaptor ini seadil mungkin di bawah batasan yang ada: akan menjadwalkan future dalam
urutan saat dikembalikan oleh stream, tanpa melakukan pengurutan ulang berdasarkan bobot. Ketika sebuah future dari grup selesai, future yang sudah mengantri dalam grup ini akan diutamakan
sebelum future lain dari stream yang disediakan.

Seperti pada [`future_queue`](https://raw.githubusercontent.com/nextest-rs/future-queue/main/src/stream_ext.rs):

* Bobot maksimum global dan grup tidak pernah terlampaui saat future sedang dijalankan.
* Dalam menghitung bobot global, jika bobot sebuah future lebih besar dari bobot maksimum, bobotnya akan diatur ke bobot maksimum.
* *Jika sebuah future termasuk dalam grup:* Dalam menghitung bobot grup, jika bobotnya
  lebih besar dari bobot maksimum grup, bobotnya akan diatur ke bobot maksimum grup.

#### Contoh

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

## Versi Minimum Rust yang Didukung (MSRV)

Versi minimum Rust yang didukung adalah **Rust 1.70.** Setiap saat, setidaknya enam bulan terakhir
rilis Rust stabil didukung.

Selama crate ini masih pra-rilis (0.x.x) MSRV-nya dapat dinaikkan pada rilis patch. Setelah
crate ini mencapai versi 1.x, setiap kenaikan MSRV akan disertai dengan versi minor baru.

## Catatan

Crate ini sebelumnya bernama `buffer-unordered-weighted`. Namanya diubah menjadi `future-queue` agar
lebih deskriptif tentang apa yang dilakukan crate ini daripada bagaimana implementasinya.

## Kontribusi

Lihat berkas [CONTRIBUTING](https://raw.githubusercontent.com/nextest-rs/future-queue/main/CONTRIBUTING.md) untuk cara berkontribusi.

## Lisensi

Proyek ini tersedia di bawah ketentuan [lisensi Apache 2.0](https://raw.githubusercontent.com/nextest-rs/future-queue/main/LICENSE-APACHE) atau
[lisensi MIT](https://raw.githubusercontent.com/nextest-rs/future-queue/main/LICENSE-MIT).

Kode ini diturunkan dari [futures-rs](https://github.com/rust-lang/futures-rs), dan digunakan di bawah
lisensi Apache 2.0 dan MIT.

<!--
README.md dihasilkan dari README.tpl oleh cargo readme. Untuk regenerasi, jalankan dari root repositori:

./scripts/regenerate-readmes.sh
-->

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---