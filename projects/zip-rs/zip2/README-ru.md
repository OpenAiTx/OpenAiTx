zip
========

[![Build Status](https://github.com/zip-rs/zip2/actions/workflows/ci.yaml/badge.svg)](https://github.com/Pr0methean/zip/actions?query=branch%3Amaster+workflow%3ACI)
[![Crates.io version](https://img.shields.io/crates/v/zip.svg)](https://crates.io/crates/zip)

[Документация](https://docs.rs/zip/latest/zip/)

Информация
----

Библиотека zip для Rust, поддерживающая чтение и запись простых ZIP-файлов. Ранее размещалась по адресу 
https://github.com/zip-rs/zip2.

Поддерживаемые форматы сжатия:

* stored (т.е. без сжатия)
* deflate
* deflate64 (только распаковка)
* bzip2
* zstd
* lzma (только распаковка)
* xz (только распаковка)

В данный момент не поддерживаются расширения zip:

* Мульти-диск

Возможности
--------

Доступные возможности:

* `aes-crypto`: Включает расшифровку файлов, зашифрованных с помощью AES. Поддерживает методы AE-1 и AE-2.
* `deflate`: Включает сжатие и распаковку с помощью неопределённой реализации (может измениться в будущих версиях)
  алгоритма сжатия deflate, который является стандартным для zip-файлов. Поддерживает уровни сжатия 1..=264.
* `deflate-flate2`: Используйте вместе с любым флагом функции `flate2`, включающим backend, для поддержки сжатия deflate
  с качеством 1..=9.
* `deflate-zopfli`: Включает сжатие файлов с помощью библиотеки `zopfli` (используется при качестве сжатия 10..=264). Это
  самая эффективная доступная реализация deflate, но и одна из самых медленных.
* `deflate64`: Включает алгоритм сжатия deflate64. Поддерживается только распаковка.
* `lzma`: Включает алгоритм сжатия LZMA. Поддерживается только распаковка.
* `bzip2`: Включает алгоритм сжатия BZip2.
* `time`: Включает функции, использующие [time](https://github.com/rust-lang-deprecated/time) crate.
* `chrono`: Включает преобразование даты последнего изменения `zip::DateTime` в/из `chrono::NaiveDateTime`.
* `jiff-02`: Включает преобразование даты последнего изменения `zip::DateTime` в/из `jiff::civil::DateTime`.
* `nt-time`: Включает возврат временных меток, хранящихся в дополнительном поле NTFS, как `nt_time::FileTime`.
* `zstd`: Включает алгоритм сжатия Zstandard.

По умолчанию включены `aes-crypto`, `bzip2`, `deflate`, `deflate64`, `lzma`, `time` и `zstd`.

MSRV
----

Минимально поддерживаемая версия Rust (MSRV) в настоящее время — **1.75**. При добавлении новых функций мы придерживаемся следующих принципов:

- Мы всегда поддерживаем минорную версию Rust, стабильную не менее 6 месяцев.
- Любое изменение MSRV сопровождается увеличением **минорной** версии.

Примеры
--------

См. [каталог с примерами](https://raw.githubusercontent.com/zip-rs/zip2/master/examples) для:
   * Как записать файл в zip.
   * Как записать директорию файлов в zip (с использованием [walkdir](https://github.com/BurntSushi/walkdir)).
   * Как распаковать zip-файл.
   * Как извлечь отдельный файл из zip.
   * Как прочитать zip из стандартного ввода.
   * Как добавить директорию в существующий архив.

Фаззинг
-------

Поддержка фаззинга осуществляется через [cargo afl](https://rust-fuzz.github.io/book/afl.html). Для установки cargo afl:

```bash
cargo install cargo-afl
```

Для начала фаззинга извлечения zip:

```bash
cargo +nightly afl build --all-features --manifest-path fuzz_read/Cargo.toml
cargo +nightly afl run fuzz_read/target/debug/fuzz_read
```

Для начала фаззинга создания zip:

```bash
cargo +nightly afl build --all-features --manifest-path fuzz_write/Cargo.toml
cargo +nightly afl run fuzz_write/target/debug/fuzz_write
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---