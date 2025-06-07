zip
========

[![Build Status](https://github.com/zip-rs/zip2/actions/workflows/ci.yaml/badge.svg)](https://github.com/Pr0methean/zip/actions?query=branch%3Amaster+workflow%3ACI)
[![Crates.io version](https://img.shields.io/crates/v/zip.svg)](https://crates.io/crates/zip)

[Dokümantasyon](https://docs.rs/zip/latest/zip/)

Bilgi
----

Rust için, basit ZIP dosyalarının okunmasını ve yazılmasını destekleyen bir zip kütüphanesi. Daha önce şu adreste barındırılıyordu: 
https://github.com/zip-rs/zip2.

Desteklenen sıkıştırma formatları:

* stored (yani sıkıştırmasız)
* deflate
* deflate64 (sadece açma)
* bzip2
* zstd
* lzma (sadece açma)
* xz (sadece açma)

Şu anda desteklenmeyen zip uzantıları:

* Çoklu disk

Özellikler
--------

Mevcut özellikler şunlardır:

* `aes-crypto`: AES ile şifrelenmiş dosyaların şifresinin çözülmesini etkinleştirir. AE-1 ve AE-2 yöntemlerini destekler.
* `deflate`: ZIP dosyaları için varsayılan olan deflate sıkıştırma algoritmasının belirtilmemiş bir uygulamasının (gelecek sürümlerde değişebilir) sıkıştırma ve açmasını etkinleştirir. Sıkıştırma kalitesi 1..=264 destekler.
* `deflate-flate2`: Herhangi bir `flate2` arka uç özelliği ile birleştirildiğinde, 1..=9 kalitesinde deflate sıkıştırmayı destekler.
* `deflate-zopfli`: `zopfli` kütüphanesi ile dosyaların deflate edilmesini etkinleştirir (sıkıştırma kalitesi 10..=264 olduğunda kullanılır). Bu, mevcut en etkili `deflate` uygulamasıdır ancak en yavaşlardan biridir.
* `deflate64`: deflate64 sıkıştırma algoritmasını etkinleştirir. Sadece açma desteklenmektedir.
* `lzma`: LZMA sıkıştırma algoritmasını etkinleştirir. Sadece açma desteklenmektedir.
* `bzip2`: BZip2 sıkıştırma algoritmasını etkinleştirir.
* `time`: [time](https://github.com/rust-lang-deprecated/time) crate'i kullanan özellikleri etkinleştirir.
* `chrono`: Son değişiklik zamanı `zip::DateTime`'ın `chrono::NaiveDateTime`'a dönüştürülmesini ve tersi işlemi etkinleştirir.
* `jiff-02`: Son değişiklik zamanı `zip::DateTime`'ın `jiff::civil::DateTime`'a dönüştürülmesini ve tersi işlemi etkinleştirir.
* `nt-time`: NTFS ek alanında saklanan zaman damgalarının `nt_time::FileTime` olarak döndürülmesini etkinleştirir.
* `zstd`: Zstandard sıkıştırma algoritmasını etkinleştirir.

Varsayılan olarak `aes-crypto`, `bzip2`, `deflate`, `deflate64`, `lzma`, `time` ve `zstd` etkindir.

MSRV
----

Şu anki Minimum Desteklenen Rust Sürümümüz **1.75**'tir. Özellik eklerken şu kurallara uyacağız:

- Her zaman en az 6 aydır kararlı olan bir küçük Rust sürümünü destekleyeceğiz.
- MSRV'deki herhangi bir değişiklik **minör** sürüm artışı ile duyurulacaktır.

Örnekler
--------

Aşağıdaki konular için [örnekler dizinine](https://raw.githubusercontent.com/zip-rs/zip2/master/examples) bakın:
   * Bir dosyanın bir zip'e nasıl yazılacağı.
   * Bir dosya dizininin zip'e nasıl yazılacağı ([walkdir](https://github.com/BurntSushi/walkdir) kullanarak).
   * Bir zip dosyasının nasıl çıkarılacağı.
   * Zip'ten tek bir dosyanın nasıl çıkarılacağı.
   * Zip'in standart girdiden nasıl okunacağı.
   * Var olan bir arşive bir dizinin nasıl ekleneceği.

Fuzzing
-------

Fuzzing desteği [cargo afl](https://rust-fuzz.github.io/book/afl.html) üzerinden sağlanmaktadır. cargo afl'yi yüklemek için:

```bash
cargo install cargo-afl
```

Zip çıkarma için fuzzing başlatmak için:

```bash
cargo +nightly afl build --all-features --manifest-path fuzz_read/Cargo.toml
cargo +nightly afl run fuzz_read/target/debug/fuzz_read
```

Zip oluşturma için fuzzing başlatmak için:

```bash
cargo +nightly afl build --all-features --manifest-path fuzz_write/Cargo.toml
cargo +nightly afl run fuzz_write/target/debug/fuzz_write
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---