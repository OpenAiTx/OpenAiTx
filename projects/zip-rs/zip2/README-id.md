zip
========

[![Build Status](https://github.com/zip-rs/zip2/actions/workflows/ci.yaml/badge.svg)](https://github.com/Pr0methean/zip/actions?query=branch%3Amaster+workflow%3ACI)
[![Crates.io version](https://img.shields.io/crates/v/zip.svg)](https://crates.io/crates/zip)

[Dokumentasi](https://docs.rs/zip/latest/zip/)

Info
----

Sebuah library zip untuk Rust yang mendukung pembacaan dan penulisan file ZIP sederhana. Sebelumnya dihosting di 
https://github.com/zip-rs/zip2.

Format kompresi yang didukung:

* stored (tanpa kompresi)
* deflate
* deflate64 (hanya dekompresi)
* bzip2
* zstd
* lzma (hanya dekompresi)
* xz (hanya dekompresi)

Ekstensi zip yang saat ini tidak didukung:

* Multi-disk

Fitur
-----

Fitur yang tersedia adalah:

* `aes-crypto`: Mengaktifkan dekripsi file yang dienkripsi dengan AES. Mendukung metode AE-1 dan AE-2.
* `deflate`: Mengaktifkan kompresi dan dekompresi menggunakan implementasi tidak spesifik (yang dapat berubah di versi mendatang) dari algoritma kompresi deflate, yang merupakan default untuk file zip. Mendukung kualitas kompresi 1..=264.
* `deflate-flate2`: Gabungkan dengan flag fitur `flate2` mana pun yang mengaktifkan back-end, untuk mendukung kompresi deflate pada kualitas 1..=9.
* `deflate-zopfli`: Mengaktifkan kompresi deflate menggunakan library `zopfli` (digunakan saat kualitas kompresi 10..=264). Ini adalah implementasi `deflate` paling efektif yang tersedia, namun juga salah satu yang paling lambat.
* `deflate64`: Mengaktifkan algoritma kompresi deflate64. Hanya dekompresi yang didukung.
* `lzma`: Mengaktifkan algoritma kompresi LZMA. Hanya dekompresi yang didukung.
* `bzip2`: Mengaktifkan algoritma kompresi BZip2.
* `time`: Mengaktifkan fitur yang menggunakan crate [time](https://github.com/rust-lang-deprecated/time).
* `chrono`: Mengaktifkan konversi `zip::DateTime` yang terakhir dimodifikasi ke dan dari `chrono::NaiveDateTime`.
* `jiff-02`: Mengaktifkan konversi `zip::DateTime` yang terakhir dimodifikasi ke dan dari `jiff::civil::DateTime`.
* `nt-time`: Mengaktifkan pengembalian timestamp yang disimpan di extra field NTFS sebagai `nt_time::FileTime`.
* `zstd`: Mengaktifkan algoritma kompresi Zstandard.

Secara default `aes-crypto`, `bzip2`, `deflate`, `deflate64`, `lzma`, `time` dan `zstd` diaktifkan.

MSRV
----

Minimum Supported Rust Version (MSRV) kami saat ini adalah **1.75**. Ketika menambah fitur,
kami akan mengikuti pedoman berikut:

- Kami akan selalu mendukung versi minor Rust yang telah stabil setidaknya 6 bulan.
- Perubahan pada MSRV akan diikuti dengan kenaikan versi **minor**.

Contoh
------

Lihat [direktori contoh](https://raw.githubusercontent.com/zip-rs/zip2/master/examples) untuk:
   * Cara menulis file ke dalam zip.
   * Cara menulis direktori file ke dalam zip (menggunakan [walkdir](https://github.com/BurntSushi/walkdir)).
   * Cara mengekstrak file zip.
   * Cara mengekstrak satu file dari zip.
   * Cara membaca zip dari standar input.
   * Cara menambahkan direktori ke arsip yang sudah ada.

Fuzzing
-------

Dukungan fuzzing tersedia melalui [cargo afl](https://rust-fuzz.github.io/book/afl.html). Untuk menginstal cargo afl:

```bash
cargo install cargo-afl
```

Untuk memulai fuzzing ekstraksi zip:

```bash
cargo +nightly afl build --all-features --manifest-path fuzz_read/Cargo.toml
cargo +nightly afl run fuzz_read/target/debug/fuzz_read
```

Untuk memulai fuzzing pembuatan zip:

```bash
cargo +nightly afl build --all-features --manifest-path fuzz_write/Cargo.toml
cargo +nightly afl run fuzz_write/target/debug/fuzz_write
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---