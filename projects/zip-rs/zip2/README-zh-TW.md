zip
========

[![Build Status](https://github.com/zip-rs/zip2/actions/workflows/ci.yaml/badge.svg)](https://github.com/Pr0methean/zip/actions?query=branch%3Amaster+workflow%3ACI)
[![Crates.io version](https://img.shields.io/crates/v/zip.svg)](https://crates.io/crates/zip)

[文件說明](https://docs.rs/zip/latest/zip/)

資訊
----

一個用於 Rust 的 zip 函式庫，支援簡單 ZIP 檔案的讀取與寫入。原先託管於 https://github.com/zip-rs/zip2。

支援的壓縮格式：

* stored（即無壓縮）
* deflate
* deflate64（僅支援解壓縮）
* bzip2
* zstd
* lzma（僅支援解壓縮）
* xz（僅支援解壓縮）

目前不支援的 zip 擴充功能：

* 多磁碟（Multi-disk）

功能
--------

可用的功能有：

* `aes-crypto`：啟用對以 AES 加密的檔案進行解密。支援 AE-1 及 AE-2 方法。
* `deflate`：啟用壓縮與解壓縮未指定實作（未來版本可能更動）的 deflate 壓縮演算法，這是 zip 檔案的預設格式。支援壓縮品質 1..=264。
* `deflate-flate2`：與任何啟用後端的 `flate2` 功能標誌結合，可支援壓縮品質 1..=9 的 deflate 壓縮。
* `deflate-zopfli`：啟用使用 `zopfli` 函式庫的 deflate 壓縮（當壓縮品質為 10..=264 時使用）。這是最有效的 `deflate` 實作之一，但同時也是最慢的之一。
* `deflate64`：啟用 deflate64 壓縮演算法。僅支援解壓縮。
* `lzma`：啟用 LZMA 壓縮演算法。僅支援解壓縮。
* `bzip2`：啟用 BZip2 壓縮演算法。
* `time`：啟用使用 [time](https://github.com/rust-lang-deprecated/time) crate 的相關功能。
* `chrono`：啟用將最後修改的 `zip::DateTime` 與 `chrono::NaiveDateTime` 互轉。
* `jiff-02`：啟用將最後修改的 `zip::DateTime` 與 `jiff::civil::DateTime` 互轉。
* `nt-time`：啟用將 NTFS 額外欄位中儲存的時間戳記以 `nt_time::FileTime` 回傳。
* `zstd`：啟用 Zstandard 壓縮演算法。

預設情況下會啟用 `aes-crypto`、`bzip2`、`deflate`、`deflate64`、`lzma`、`time` 與 `zstd`。

MSRV
----

目前最低支援的 Rust 版本為 **1.75**。新增功能時，我們遵循以下規則：

- 我們將始終支援一個已穩定至少 6 個月的小版本 Rust。
- 任何 MSRV（最低支援 Rust 版本）的變更，將伴隨**次版號**升級。

範例
--------

請參閱 [examples 目錄](https://raw.githubusercontent.com/zip-rs/zip2/master/examples) 以了解：
   * 如何將檔案寫入 zip。
   * 如何將一個目錄下的檔案寫入 zip（使用 [walkdir](https://github.com/BurntSushi/walkdir)）。
   * 如何解壓縮 zip 檔案。
   * 如何從 zip 解壓縮單一檔案。
   * 如何從標準輸入讀取 zip。
   * 如何將目錄新增至現有壓縮檔。

模糊測試（Fuzzing）
-------

模糊測試支援 [cargo afl](https://rust-fuzz.github.io/book/afl.html)。安裝 cargo afl：

```bash
cargo install cargo-afl
```

開始針對 zip 解壓縮進行模糊測試：

```bash
cargo +nightly afl build --all-features --manifest-path fuzz_read/Cargo.toml
cargo +nightly afl run fuzz_read/target/debug/fuzz_read
```

開始針對 zip 建立進行模糊測試：

```bash
cargo +nightly afl build --all-features --manifest-path fuzz_write/Cargo.toml
cargo +nightly afl run fuzz_write/target/debug/fuzz_write
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---