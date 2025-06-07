zip
========

[![Build Status](https://github.com/zip-rs/zip2/actions/workflows/ci.yaml/badge.svg)](https://github.com/Pr0methean/zip/actions?query=branch%3Amaster+workflow%3ACI)
[![Crates.io versie](https://img.shields.io/crates/v/zip.svg)](https://crates.io/crates/zip)

[Documentatie](https://docs.rs/zip/latest/zip/)

Info
----

Een zip-bibliotheek voor Rust die het lezen en schrijven van eenvoudige ZIP-bestanden ondersteunt. Voorheen gehost op 
https://github.com/zip-rs/zip2.

Ondersteunde compressieformaten:

* opgeslagen (d.w.z. geen)
* deflate
* deflate64 (alleen decompressie)
* bzip2
* zstd
* lzma (alleen decompressie)
* xz (alleen decompressie)

Momenteel niet-ondersteunde zip-extensies:

* Multi-disk

Functies
--------

De beschikbare functies zijn:

* `aes-crypto`: Schakelt het ontsleutelen in van bestanden die met AES zijn versleuteld. Ondersteunt AE-1 en AE-2 methoden.
* `deflate`: Schakelt compressie en decompressie in van een ongespecificeerde implementatie (die in toekomstige versies kan veranderen) van het deflate-compressie-algoritme, dat standaard is voor zip-bestanden. Ondersteunt compressiekwaliteit 1..=264.
* `deflate-flate2`: Combineer dit met een `flate2` feature flag die een back-end inschakelt, om deflate-compressie te ondersteunen op kwaliteit 1..=9.
* `deflate-zopfli`: Schakelt deflate-compressie in met de `zopfli`-bibliotheek (gebruikt bij compressiekwaliteit 10..=264). Dit is de meest effectieve beschikbare `deflate`-implementatie, maar ook een van de langzaamste.
* `deflate64`: Schakelt het deflate64-compressie-algoritme in. Alleen decompressie wordt ondersteund.
* `lzma`: Schakelt het LZMA-compressie-algoritme in. Alleen decompressie wordt ondersteund.
* `bzip2`: Schakelt het BZip2-compressie-algoritme in.
* `time`: Schakelt functies in die gebruik maken van de [time](https://github.com/rust-lang-deprecated/time) crate.
* `chrono`: Schakelt het omzetten van last-modified `zip::DateTime` naar en van `chrono::NaiveDateTime` in.
* `jiff-02`: Schakelt het omzetten van last-modified `zip::DateTime` naar en van `jiff::civil::DateTime` in.
* `nt-time`: Schakelt het teruggeven van tijdstempels die zijn opgeslagen in het NTFS-extra veld als `nt_time::FileTime` in.
* `zstd`: Schakelt het Zstandard-compressie-algoritme in.

Standaard zijn `aes-crypto`, `bzip2`, `deflate`, `deflate64`, `lzma`, `time` en `zstd` ingeschakeld.

MSRV
----

Onze huidige Minimum Supported Rust Version is **1.75**. Bij het toevoegen van functies volgen wij deze richtlijnen:

- We ondersteunen altijd een minor Rust-versie die minstens 6 maanden stabiel is geweest.
- Elke wijziging aan de MSRV gaat gepaard met een **minor** versie-update.

Voorbeelden
-----------

Zie de [examples directory](https://raw.githubusercontent.com/zip-rs/zip2/master/examples) voor:
   * Hoe een bestand naar een zip te schrijven.
   * Hoe een directory met bestanden naar een zip te schrijven (met behulp van [walkdir](https://github.com/BurntSushi/walkdir)).
   * Hoe een zip-bestand te uitpakken.
   * Hoe één enkel bestand uit een zip te halen.
   * Hoe een zip-bestand vanaf de standaardinvoer te lezen.
   * Hoe een directory toe te voegen aan een bestaande archief.

Fuzzing
-------

Fuzzing-ondersteuning is mogelijk via [cargo afl](https://rust-fuzz.github.io/book/afl.html). Om cargo afl te installeren:

```bash
cargo install cargo-afl
```

Om te starten met fuzzing van zip-extractie:

```bash
cargo +nightly afl build --all-features --manifest-path fuzz_read/Cargo.toml
cargo +nightly afl run fuzz_read/target/debug/fuzz_read
```

Om te starten met fuzzing van zip-creatie:

```bash
cargo +nightly afl build --all-features --manifest-path fuzz_write/Cargo.toml
cargo +nightly afl run fuzz_write/target/debug/fuzz_write
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---