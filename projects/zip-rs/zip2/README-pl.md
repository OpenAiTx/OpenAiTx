zip
========

[![Build Status](https://github.com/zip-rs/zip2/actions/workflows/ci.yaml/badge.svg)](https://github.com/Pr0methean/zip/actions?query=branch%3Amaster+workflow%3ACI)
[![Crates.io version](https://img.shields.io/crates/v/zip.svg)](https://crates.io/crates/zip)

[Dokumentacja](https://docs.rs/zip/latest/zip/)

Informacje
----------

Biblioteka zip dla języka Rust, umożliwiająca odczyt i zapis prostych plików ZIP. Wcześniej dostępna pod adresem 
https://github.com/zip-rs/zip2.

Obsługiwane formaty kompresji:

* stored (tj. brak kompresji)
* deflate
* deflate64 (tylko dekompresja)
* bzip2
* zstd
* lzma (tylko dekompresja)
* xz (tylko dekompresja)

Aktualnie nieobsługiwane rozszerzenia ZIP:

* Multi-dysk

Funkcje
--------

Dostępne funkcje to:

* `aes-crypto`: Umożliwia deszyfrowanie plików zaszyfrowanych za pomocą AES. Obsługuje metody AE-1 i AE-2.
* `deflate`: Umożliwia kompresję i dekompresję niezdefiniowanej implementacji (która może się zmienić w przyszłych wersjach) algorytmu kompresji deflate, będącego domyślnym dla plików zip. Obsługuje jakość kompresji 1..=264.
* `deflate-flate2`: Połącz to z dowolnym flagiem funkcji `flate2` umożliwiającym backend, aby obsłużyć kompresję deflate na poziomie jakości 1..=9.
* `deflate-zopfli`: Umożliwia kompresję plików za pomocą biblioteki `zopfli` (używanej gdy jakość kompresji to 10..=264). Jest to najskuteczniejsza dostępna implementacja `deflate`, ale także jedna z najwolniejszych.
* `deflate64`: Umożliwia algorytm kompresji deflate64. Obsługiwana jest tylko dekompresja.
* `lzma`: Umożliwia algorytm kompresji LZMA. Obsługiwana jest tylko dekompresja.
* `bzip2`: Umożliwia algorytm kompresji BZip2.
* `time`: Umożliwia funkcje wykorzystujące bibliotekę [time](https://github.com/rust-lang-deprecated/time).
* `chrono`: Umożliwia konwersję ostatniej modyfikacji `zip::DateTime` do i z `chrono::NaiveDateTime`.
* `jiff-02`: Umożliwia konwersję ostatniej modyfikacji `zip::DateTime` do i z `jiff::civil::DateTime`.
* `nt-time`: Umożliwia zwracanie znaczników czasu przechowywanych w polu dodatkowym NTFS jako `nt_time::FileTime`.
* `zstd`: Umożliwia algorytm kompresji Zstandard.

Domyślnie włączone są funkcje: `aes-crypto`, `bzip2`, `deflate`, `deflate64`, `lzma`, `time` oraz `zstd`.

MSRV
----

Aktualnie minimalna wspierana wersja Rust to **1.75**. Przy dodawaniu nowych funkcji stosujemy następujące zasady:

- Zawsze wspieramy wersję Rust, która jest stabilna od co najmniej 6 miesięcy.
- Każda zmiana MSRV będzie wiązała się z podbiciem **wersji minor**.

Przykłady
---------

Zobacz [katalog z przykładami](https://raw.githubusercontent.com/zip-rs/zip2/master/examples) aby dowiedzieć się:
   * Jak zapisać plik do archiwum zip.
   * Jak zapisać katalog plików do zip (z wykorzystaniem [walkdir](https://github.com/BurntSushi/walkdir)).
   * Jak rozpakować plik zip.
   * Jak rozpakować pojedynczy plik z archiwum zip.
   * Jak odczytać archiwum zip ze standardowego wejścia.
   * Jak dodać katalog do istniejącego archiwum

Fuzzing
-------

Obsługa fuzzingu dostępna jest przez [cargo afl](https://rust-fuzz.github.io/book/afl.html). Aby zainstalować cargo afl:

```bash
cargo install cargo-afl
```

Aby rozpocząć fuzzing rozpakowywania zip:

```bash
cargo +nightly afl build --all-features --manifest-path fuzz_read/Cargo.toml
cargo +nightly afl run fuzz_read/target/debug/fuzz_read
```

Aby rozpocząć fuzzing tworzenia zip:

```bash
cargo +nightly afl build --all-features --manifest-path fuzz_write/Cargo.toml
cargo +nightly afl run fuzz_write/target/debug/fuzz_write
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---