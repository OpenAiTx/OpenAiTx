zip
========

[![Build Status](https://github.com/zip-rs/zip2/actions/workflows/ci.yaml/badge.svg)](https://github.com/Pr0methean/zip/actions?query=branch%3Amaster+workflow%3ACI)
[![Crates.io version](https://img.shields.io/crates/v/zip.svg)](https://crates.io/crates/zip)

[ドキュメント](https://docs.rs/zip/latest/zip/)

情報
----

Rust向けのZIPライブラリで、シンプルなZIPファイルの読み書きをサポートします。以前は https://github.com/zip-rs/zip2 でホストされていました。

サポートされている圧縮フォーマット:

* stored（圧縮なし）
* deflate
* deflate64（展開のみ対応）
* bzip2
* zstd
* lzma（展開のみ対応）
* xz（展開のみ対応）

現在サポートされていないZIP拡張機能:

* マルチディスク

機能
--------

利用可能な機能は以下の通りです:

* `aes-crypto`: AESで暗号化されたファイルの復号を有効にします。AE-1およびAE-2方式をサポートします。
* `deflate`: deflate圧縮アルゴリズム（バージョンによって実装が変更される可能性あり）による圧縮・展開を有効にします。ZIPファイルのデフォルトです。圧縮品質1..=264をサポートします。
* `deflate-flate2`: いずれかの`flate2`バックエンド機能フラグと組み合わせて、圧縮品質1..=9のdeflate圧縮をサポートします。
* `deflate-zopfli`: `zopfli`ライブラリによるファイル圧縮（圧縮品質10..=264で使用）を有効にします。最も高効率な`deflate`実装ですが、動作速度は遅い部類です。
* `deflate64`: deflate64圧縮アルゴリズムを有効にします。展開のみ対応です。
* `lzma`: LZMA圧縮アルゴリズムを有効にします。展開のみ対応です。
* `bzip2`: BZip2圧縮アルゴリズムを有効にします。
* `time`: [time](https://github.com/rust-lang-deprecated/time)クレートを用いた機能を有効にします。
* `chrono`: 最終更新`zip::DateTime`を`chrono::NaiveDateTime`との相互変換を有効にします。
* `jiff-02`: 最終更新`zip::DateTime`を`jiff::civil::DateTime`との相互変換を有効にします。
* `nt-time`: NTFSエクストラフィールドに格納されているタイムスタンプを`nt_time::FileTime`として返します。
* `zstd`: Zstandard圧縮アルゴリズムを有効にします。

デフォルトで`aes-crypto`、`bzip2`、`deflate`、`deflate64`、`lzma`、`time`、`zstd`が有効です。

MSRV
----

現在のサポートされる最小Rustバージョンは**1.75**です。機能追加時は以下の指針に従います:

- 少なくとも6ヶ月以上安定しているマイナーRustバージョンを常にサポートします。
- MSRVの変更時は**マイナーバージョン**アップを伴います。

サンプル
--------

[examples ディレクトリ](https://raw.githubusercontent.com/zip-rs/zip2/master/examples)を参照してください:

   * ファイルをzipに書き込む方法
   * ディレクトリ内のファイル群をzipに書き込む方法（[walkdir](https://github.com/BurntSushi/walkdir)使用）
   * zipファイルを展開する方法
   * zip内の単一ファイルを展開する方法
   * 標準入力からzipを読み取る方法
   * 既存アーカイブにディレクトリを追加する方法

ファジング
-------

ファジングサポートは[cargo afl](https://rust-fuzz.github.io/book/afl.html)経由です。cargo aflのインストール:

```bash
cargo install cargo-afl
```

zip展開のファジングを開始するには:

```bash
cargo +nightly afl build --all-features --manifest-path fuzz_read/Cargo.toml
cargo +nightly afl run fuzz_read/target/debug/fuzz_read
```

zip作成のファジングを開始するには:

```bash
cargo +nightly afl build --all-features --manifest-path fuzz_write/Cargo.toml
cargo +nightly afl run fuzz_write/target/debug/fuzz_write
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---