zip
========

[![Build Status](https://github.com/zip-rs/zip2/actions/workflows/ci.yaml/badge.svg)](https://github.com/Pr0methean/zip/actions?query=branch%3Amaster+workflow%3ACI)
[![Crates.io version](https://img.shields.io/crates/v/zip.svg)](https://crates.io/crates/zip)

[Dokumentation](https://docs.rs/zip/latest/zip/)

Info
----

Eine ZIP-Bibliothek für Rust, die das Lesen und Schreiben von einfachen ZIP-Dateien unterstützt. Früher gehostet unter 
https://github.com/zip-rs/zip2.

Unterstützte Komprimierungsformate:

* gespeichert (d.h. keine)
* deflate
* deflate64 (nur Dekomprimierung)
* bzip2
* zstd
* lzma (nur Dekomprimierung)
* xz (nur Dekomprimierung)

Derzeit nicht unterstützte ZIP-Erweiterungen:

* Multi-Disk

Funktionen
----------

Die verfügbaren Funktionen sind:

* `aes-crypto`: Ermöglicht die Entschlüsselung von Dateien, die mit AES verschlüsselt wurden. Unterstützt die Methoden AE-1 und AE-2.
* `deflate`: Aktiviert das Komprimieren und Dekomprimieren einer nicht näher spezifizierten Implementierung (die sich in zukünftigen Versionen ändern kann) des Deflate-Komprimierungsalgorithmus, welcher der Standard für ZIP-Dateien ist. Unterstützt Komprimierungsqualität 1..=264.
* `deflate-flate2`: Kombinieren Sie dies mit jedem `flate2` Feature-Flag, das ein Backend aktiviert, um Deflate-Komprimierung mit Qualität 1..=9 zu unterstützen.
* `deflate-zopfli`: Ermöglicht das Deflaten von Dateien mit der `zopfli`-Bibliothek (wird verwendet, wenn die Komprimierungsqualität 10..=264 ist). Dies ist die effektivste verfügbare `deflate`-Implementierung, aber auch eine der langsamsten.
* `deflate64`: Aktiviert den Deflate64-Komprimierungsalgorithmus. Nur Dekomprimierung wird unterstützt.
* `lzma`: Aktiviert den LZMA-Komprimierungsalgorithmus. Nur Dekomprimierung wird unterstützt.
* `bzip2`: Aktiviert den BZip2-Komprimierungsalgorithmus.
* `time`: Aktiviert Funktionen unter Verwendung des [time](https://github.com/rust-lang-deprecated/time) Crates.
* `chrono`: Ermöglicht die Umwandlung von zuletzt geändertem `zip::DateTime` zu und von `chrono::NaiveDateTime`.
* `jiff-02`: Ermöglicht die Umwandlung von zuletzt geändertem `zip::DateTime` zu und von `jiff::civil::DateTime`.
* `nt-time`: Ermöglicht die Rückgabe von Zeitstempeln, die im NTFS-Extra-Feld als `nt_time::FileTime` gespeichert sind.
* `zstd`: Aktiviert den Zstandard-Komprimierungsalgorithmus.

Standardmäßig sind `aes-crypto`, `bzip2`, `deflate`, `deflate64`, `lzma`, `time` und `zstd` aktiviert.

MSRV
----

Unsere aktuell minimal unterstützte Rust-Version ist **1.75**. Beim Hinzufügen von Funktionen folgen wir diesen Richtlinien:

- Wir unterstützen immer eine Rust-Nebenversion, die seit mindestens 6 Monaten stabil ist.
- Jede Änderung an der MSRV wird von einem **Minor**-Versionssprung begleitet.

Beispiele
---------

Siehe das [Beispielverzeichnis](https://raw.githubusercontent.com/zip-rs/zip2/master/examples) für:
   * Wie man eine Datei in ein ZIP schreibt.
   * Wie man ein Verzeichnis von Dateien in ein ZIP schreibt (unter Verwendung von [walkdir](https://github.com/BurntSushi/walkdir)).
   * Wie man eine ZIP-Datei extrahiert.
   * Wie man eine einzelne Datei aus einem ZIP extrahiert.
   * Wie man ein ZIP von der Standardeingabe liest.
   * Wie man ein Verzeichnis zu einem bestehenden Archiv hinzufügt.

Fuzzing
-------

Fuzzing wird über [cargo afl](https://rust-fuzz.github.io/book/afl.html) unterstützt. Um cargo afl zu installieren:

```bash
cargo install cargo-afl
```

Um mit dem Fuzzing der ZIP-Extraktion zu beginnen:

```bash
cargo +nightly afl build --all-features --manifest-path fuzz_read/Cargo.toml
cargo +nightly afl run fuzz_read/target/debug/fuzz_read
```

Um mit dem Fuzzing der ZIP-Erstellung zu beginnen:

```bash
cargo +nightly afl build --all-features --manifest-path fuzz_write/Cargo.toml
cargo +nightly afl run fuzz_write/target/debug/fuzz_write
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---