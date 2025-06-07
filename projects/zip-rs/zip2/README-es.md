zip
========

[![Build Status](https://github.com/zip-rs/zip2/actions/workflows/ci.yaml/badge.svg)](https://github.com/Pr0methean/zip/actions?query=branch%3Amaster+workflow%3ACI)
[![Crates.io version](https://img.shields.io/crates/v/zip.svg)](https://crates.io/crates/zip)

[Documentación](https://docs.rs/zip/latest/zip/)

Información
----

Una biblioteca zip para Rust que permite leer y escribir archivos ZIP simples. Anteriormente alojada en 
https://github.com/zip-rs/zip2.

Formatos de compresión soportados:

* almacenado (es decir, ninguno)
* deflate
* deflate64 (solo descompresión)
* bzip2
* zstd
* lzma (solo descompresión)
* xz (solo descompresión)

Extensiones zip actualmente no soportadas:

* Multi-disco

Características
--------

Las características disponibles son:

* `aes-crypto`: Permite la descifrado de archivos que fueron cifrados con AES. Soporta los métodos AE-1 y AE-2.
* `deflate`: Permite comprimir y descomprimir con una implementación no especificada (que puede cambiar en futuras versiones) del algoritmo de compresión deflate, que es el predeterminado para archivos zip. Soporta calidad de compresión 1..=264.
* `deflate-flate2`: Combina esto con cualquier bandera de característica de `flate2` que habilite un back-end, para soportar compresión deflate en calidad 1..=9.
* `deflate-zopfli`: Permite comprimir archivos usando la biblioteca `zopfli` (usada cuando la calidad de compresión es 10..=264). Esta es la implementación de `deflate` más efectiva disponible, pero también una de las más lentas.
* `deflate64`: Permite el algoritmo de compresión deflate64. Solo se soporta la descompresión.
* `lzma`: Permite el algoritmo de compresión LZMA. Solo se soporta la descompresión.
* `bzip2`: Permite el algoritmo de compresión BZip2.
* `time`: Permite características que usan el crate [time](https://github.com/rust-lang-deprecated/time).
* `chrono`: Permite convertir el campo `zip::DateTime` de última modificación hacia y desde `chrono::NaiveDateTime`.
* `jiff-02`: Permite convertir el campo `zip::DateTime` de última modificación hacia y desde `jiff::civil::DateTime`.
* `nt-time`: Permite devolver las marcas de tiempo almacenadas en el campo extra NTFS como `nt_time::FileTime`.
* `zstd`: Permite el algoritmo de compresión Zstandard.

Por defecto, `aes-crypto`, `bzip2`, `deflate`, `deflate64`, `lzma`, `time` y `zstd` están habilitados.

MSRV
----

Nuestra versión mínima de Rust soportada actualmente es **1.75**. Al agregar características,
seguiremos estas pautas:

- Siempre soportaremos una versión menor de Rust que haya sido estable durante al menos 6 meses.
- Cualquier cambio al MSRV irá acompañado de un aumento de versión **minor**.

Ejemplos
--------

Consulta el [directorio de ejemplos](https://raw.githubusercontent.com/zip-rs/zip2/master/examples) para:
   * Cómo escribir un archivo en un zip.
   * Cómo escribir un directorio de archivos en un zip (usando [walkdir](https://github.com/BurntSushi/walkdir)).
   * Cómo extraer un archivo zip.
   * Cómo extraer un solo archivo de un zip.
   * Cómo leer un zip desde la entrada estándar.
   * Cómo añadir un directorio a un archivo existente.

Fuzzing
-------

El soporte para fuzzing es a través de [cargo afl](https://rust-fuzz.github.io/book/afl.html). Para instalar cargo afl:

```bash
cargo install cargo-afl
```

Para comenzar a fuzzear la extracción de zip:

```bash
cargo +nightly afl build --all-features --manifest-path https://raw.githubusercontent.com/zip-rs/zip2/master/fuzz_read/Cargo.toml
cargo +nightly afl run https://raw.githubusercontent.com/zip-rs/zip2/master/fuzz_read/target/debug/fuzz_read
```

Para comenzar a fuzzear la creación de zip:

```bash
cargo +nightly afl build --all-features --manifest-path https://raw.githubusercontent.com/zip-rs/zip2/master/fuzz_write/Cargo.toml
cargo +nightly afl run https://raw.githubusercontent.com/zip-rs/zip2/master/fuzz_write/target/debug/fuzz_write
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---