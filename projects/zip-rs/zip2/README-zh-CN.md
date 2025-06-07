zip
========

[![Build Status](https://github.com/zip-rs/zip2/actions/workflows/ci.yaml/badge.svg)](https://github.com/Pr0methean/zip/actions?query=branch%3Amaster+workflow%3ACI)
[![Crates.io version](https://img.shields.io/crates/v/zip.svg)](https://crates.io/crates/zip)

[文档](https://docs.rs/zip/latest/zip/)

信息
----

这是一个用于 Rust 的 zip 库，支持读取和写入简单的 ZIP 文件。此前托管于 https://github.com/zip-rs/zip2。

支持的压缩格式：

* stored（即无压缩）
* deflate
* deflate64（仅支持解压缩）
* bzip2
* zstd
* lzma（仅支持解压缩）
* xz（仅支持解压缩）

当前不支持的 zip 扩展：

* 多磁盘（Multi-disk）

特性
--------

可用的特性有：

* `aes-crypto`：启用对使用 AES 加密的文件进行解密。支持 AE-1 和 AE-2 方法。
* `deflate`：启用对 deflate 压缩算法的压缩和解压缩（实现未指定，未来版本可能更改），这是 zip 文件的默认算法。支持压缩质量 1..=264。
* `deflate-flate2`：与任何启用了后端的 `flate2` 特性标志结合使用，以支持 1..=9 级的 deflate 压缩。
* `deflate-zopfli`：启用使用 `zopfli` 库对文件进行 deflate 压缩（用于压缩质量为 10..=264 时）。这是目前最有效的 `deflate` 实现，但也是最慢的之一。
* `deflate64`：启用 deflate64 压缩算法。仅支持解压缩。
* `lzma`：启用 LZMA 压缩算法。仅支持解压缩。
* `bzip2`：启用 BZip2 压缩算法。
* `time`：启用基于 [time](https://github.com/rust-lang-deprecated/time) crate 的功能。
* `chrono`：启用将最后修改的 `zip::DateTime` 与 `chrono::NaiveDateTime` 之间的转换。
* `jiff-02`：启用将最后修改的 `zip::DateTime` 与 `jiff::civil::DateTime` 之间的转换。
* `nt-time`：启用将存储在 NTFS 扩展字段中的时间戳作为 `nt_time::FileTime` 返回。
* `zstd`：启用 Zstandard 压缩算法。

默认启用的特性有：`aes-crypto`、`bzip2`、`deflate`、`deflate64`、`lzma`、`time` 和 `zstd`。

MSRV（最低支持 Rust 版本）
----

我们当前的最低支持 Rust 版本是 **1.75**。在添加特性时，我们遵循以下准则：

- 我们始终支持已经稳定至少 6 个月的小版本 Rust 版本。
- 任何 MSRV 的变更都会伴随一次**小版本**的升级。

示例
--------

请参见 [示例目录](https://raw.githubusercontent.com/zip-rs/zip2/master/examples) 以了解：
   * 如何写入一个文件到 zip。
   * 如何将一个目录中的文件写入 zip（使用 [walkdir](https://github.com/BurntSushi/walkdir)）。
   * 如何解压 zip 文件。
   * 如何从 zip 中解压单个文件。
   * 如何从标准输入读取 zip。
   * 如何向已有归档追加一个目录。

模糊测试（Fuzzing）
-------

模糊测试支持通过 [cargo afl](https://rust-fuzz.github.io/book/afl.html) 实现。安装 cargo afl：

```bash
cargo install cargo-afl
```

开始对 zip 解压进行模糊测试：

```bash
cargo +nightly afl build --all-features --manifest-path fuzz_read/Cargo.toml
cargo +nightly afl run fuzz_read/target/debug/fuzz_read
```

开始对 zip 创建进行模糊测试：

```bash
cargo +nightly afl build --all-features --manifest-path fuzz_write/Cargo.toml
cargo +nightly afl run fuzz_write/target/debug/fuzz_write
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---