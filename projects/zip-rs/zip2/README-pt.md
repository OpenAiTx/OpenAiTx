zip
========

[![Build Status](https://github.com/zip-rs/zip2/actions/workflows/ci.yaml/badge.svg)](https://github.com/Pr0methean/zip/actions?query=branch%3Amaster+workflow%3ACI)
[![Crates.io version](https://img.shields.io/crates/v/zip.svg)](https://crates.io/crates/zip)

[Documentação](https://docs.rs/zip/latest/zip/)

Informações
----

Uma biblioteca zip para Rust que suporta leitura e escrita de arquivos ZIP simples. Anteriormente hospedada em 
https://github.com/zip-rs/zip2.

Formatos de compressão suportados:

* armazenado (ou seja, nenhum)
* deflate
* deflate64 (apenas descompressão)
* bzip2
* zstd
* lzma (apenas descompressão)
* xz (apenas descompressão)

Extensões zip atualmente não suportadas:

* Multi-disco

Funcionalidades
--------

As funcionalidades disponíveis são:

* `aes-crypto`: Habilita a descriptografia de arquivos que foram criptografados com AES. Suporta métodos AE-1 e AE-2.
* `deflate`: Habilita compressão e descompressão com uma implementação não especificada (que pode mudar em versões futuras) do algoritmo de compressão deflate, que é o padrão para arquivos zip. Suporta qualidade de compressão 1..=264.
* `deflate-flate2`: Combine isso com qualquer flag de funcionalidade `flate2` que habilite um back-end, para suportar compressão deflate com qualidade 1..=9.
* `deflate-zopfli`: Habilita compressão deflate de arquivos com a biblioteca `zopfli` (usada quando a qualidade de compressão é 10..=264). Esta é a implementação `deflate` mais eficaz disponível, mas também uma das mais lentas.
* `deflate64`: Habilita o algoritmo de compressão deflate64. Apenas descompressão é suportada.
* `lzma`: Habilita o algoritmo de compressão LZMA. Apenas descompressão é suportada.
* `bzip2`: Habilita o algoritmo de compressão BZip2.
* `time`: Habilita funcionalidades usando o crate [time](https://github.com/rust-lang-deprecated/time).
* `chrono`: Habilita conversão de `zip::DateTime` (data de última modificação) para e de `chrono::NaiveDateTime`.
* `jiff-02`: Habilita conversão de `zip::DateTime` (data de última modificação) para e de `jiff::civil::DateTime`.
* `nt-time`: Habilita o retorno de timestamps armazenados no campo extra NTFS como `nt_time::FileTime`.
* `zstd`: Habilita o algoritmo de compressão Zstandard.

Por padrão, `aes-crypto`, `bzip2`, `deflate`, `deflate64`, `lzma`, `time` e `zstd` estão habilitados.

MSRV
----

Nossa Versão Mínima Suportada do Rust atualmente é **1.75**. Ao adicionar funcionalidades,
seguiremos estas diretrizes:

- Sempre suportaremos uma versão menor do Rust que esteja estável por pelo menos 6 meses.
- Qualquer alteração na MSRV será acompanhada de um incremento de **versão menor**.

Exemplos
--------

Veja o [diretório de exemplos](https://raw.githubusercontent.com/zip-rs/zip2/master/examples) para:
   * Como escrever um arquivo em um zip.
   * Como escrever um diretório de arquivos em um zip (usando [walkdir](https://github.com/BurntSushi/walkdir)).
   * Como extrair um arquivo zip.
   * Como extrair um único arquivo de um zip.
   * Como ler um zip da entrada padrão.
   * Como adicionar um diretório a um arquivo zip já existente.

Fuzzing
-------

O suporte a fuzzing é feito por meio do [cargo afl](https://rust-fuzz.github.io/book/afl.html). Para instalar o cargo afl:

```bash
cargo install cargo-afl
```

Para iniciar o fuzzing da extração de zip:

```bash
cargo +nightly afl build --all-features --manifest-path fuzz_read/Cargo.toml
cargo +nightly afl run fuzz_read/target/debug/fuzz_read
```

Para iniciar o fuzzing da criação de zip:

```bash
cargo +nightly afl build --all-features --manifest-path fuzz_write/Cargo.toml
cargo +nightly afl run fuzz_write/target/debug/fuzz_write
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---