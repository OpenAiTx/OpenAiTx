zip
========

[![Build Status](https://github.com/zip-rs/zip2/actions/workflows/ci.yaml/badge.svg)](https://github.com/Pr0methean/zip/actions?query=branch%3Amaster+workflow%3ACI)
[![Crates.io version](https://img.shields.io/crates/v/zip.svg)](https://crates.io/crates/zip)

[Documentazione](https://docs.rs/zip/latest/zip/)

Informazioni
----

Una libreria zip per Rust che supporta la lettura e la scrittura di file ZIP semplici. Precedentemente ospitata su 
https://github.com/zip-rs/zip2.

Formati di compressione supportati:

* stored (cioè nessuna)
* deflate
* deflate64 (solo decompressione)
* bzip2
* zstd
* lzma (solo decompressione)
* xz (solo decompressione)

Estensioni zip attualmente non supportate:

* Multi-disco

Funzionalità
--------

Le funzionalità disponibili sono:

* `aes-crypto`: Abilita la decrittazione di file che sono stati criptati con AES. Supporta i metodi AE-1 e AE-2.
* `deflate`: Abilita la compressione e decompressione di una implementazione non specificata (che potrebbe cambiare nelle versioni future) dell’algoritmo di compressione deflate, che è quello predefinito per i file zip. Supporta qualità di compressione 1..=264.
* `deflate-flate2`: Combina questa con qualsiasi flag di funzionalità `flate2` che abilita un back-end, per supportare la compressione deflate a qualità 1..=9.
* `deflate-zopfli`: Abilita la compressione deflate dei file con la libreria `zopfli` (usata quando la qualità di compressione è 10..=264). Questa è l’implementazione `deflate` più efficace disponibile, ma anche tra le più lente.
* `deflate64`: Abilita l’algoritmo di compressione deflate64. Solo decompressione supportata.
* `lzma`: Abilita l’algoritmo di compressione LZMA. Solo decompressione supportata.
* `bzip2`: Abilita l’algoritmo di compressione BZip2.
* `time`: Abilita le funzionalità che utilizzano il pacchetto [time](https://github.com/rust-lang-deprecated/time).
* `chrono`: Abilita la conversione dell’ultimo modificato `zip::DateTime` da e verso `chrono::NaiveDateTime`.
* `jiff-02`: Abilita la conversione dell’ultimo modificato `zip::DateTime` da e verso `jiff::civil::DateTime`.
* `nt-time`: Abilita la restituzione dei timestamp memorizzati nel campo extra NTFS come `nt_time::FileTime`.
* `zstd`: Abilita l’algoritmo di compressione Zstandard.

Per impostazione predefinita, sono abilitati `aes-crypto`, `bzip2`, `deflate`, `deflate64`, `lzma`, `time` e `zstd`.

MSRV
----

La nostra versione minima supportata di Rust è **1.75**. Quando aggiungiamo funzionalità,
seguiamo queste linee guida:

- Supporteremo sempre una versione minore di Rust che è stabile da almeno 6 mesi.
- Qualsiasi modifica alla MSRV sarà accompagnata da un incremento di **versione minore**.

Esempi
--------

Vedi la [directory degli esempi](https://raw.githubusercontent.com/zip-rs/zip2/master/examples) per:
   * Come scrivere un file in uno zip.
   * Come scrivere una directory di file in uno zip (usando [walkdir](https://github.com/BurntSushi/walkdir)).
   * Come estrarre un file zip.
   * Come estrarre un singolo file da uno zip.
   * Come leggere uno zip dallo standard input.
   * Come aggiungere una directory a un archivio esistente

Fuzzing
-------

Il supporto al fuzzing è fornito tramite [cargo afl](https://rust-fuzz.github.io/book/afl.html). Per installare cargo afl:

```bash
cargo install cargo-afl
```

Per iniziare il fuzzing dell’estrazione zip:

```bash
cargo +nightly afl build --all-features --manifest-path fuzz_read/Cargo.toml
cargo +nightly afl run fuzz_read/target/debug/fuzz_read
```

Per iniziare il fuzzing della creazione zip:

```bash
cargo +nightly afl build --all-features --manifest-path fuzz_write/Cargo.toml
cargo +nightly afl run fuzz_write/target/debug/fuzz_write
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---