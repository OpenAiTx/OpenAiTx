zip
========

[![Build Status](https://github.com/zip-rs/zip2/actions/workflows/ci.yaml/badge.svg)](https://github.com/Pr0methean/zip/actions?query=branch%3Amaster+workflow%3ACI)
[![Crates.io version](https://img.shields.io/crates/v/zip.svg)](https://crates.io/crates/zip)

[Documentation](https://docs.rs/zip/latest/zip/)

Informations
------------

Une bibliothèque zip pour Rust qui prend en charge la lecture et l’écriture de fichiers ZIP simples. Précédemment hébergée sur
https://github.com/zip-rs/zip2.

Formats de compression pris en charge :

* stocké (c’est-à-dire aucun)
* deflate
* deflate64 (décompression uniquement)
* bzip2
* zstd
* lzma (décompression uniquement)
* xz (décompression uniquement)

Extensions zip actuellement non prises en charge :

* Multi-disque

Fonctionnalités
---------------

Les fonctionnalités disponibles sont :

* `aes-crypto` : Active le déchiffrement des fichiers qui ont été chiffrés avec AES. Prend en charge les méthodes AE-1 et AE-2.
* `deflate` : Active la compression et la décompression d’une implémentation non spécifiée (qui peut changer dans de futures versions) de l’algorithme de compression deflate, qui est le défaut pour les fichiers zip. Prend en charge une qualité de compression de 1..=264.
* `deflate-flate2` : À combiner avec n’importe quel indicateur de fonctionnalité `flate2` qui active un back-end, afin de prendre en charge la compression deflate avec une qualité de 1..=9.
* `deflate-zopfli` : Active la compression des fichiers avec la bibliothèque `zopfli` (utilisée lorsque la qualité de compression est de 10..=264). Il s’agit de l’implémentation `deflate` la plus efficace disponible, mais aussi l’une des plus lentes.
* `deflate64` : Active l’algorithme de compression deflate64. Seule la décompression est prise en charge.
* `lzma` : Active l’algorithme de compression LZMA. Seule la décompression est prise en charge.
* `bzip2` : Active l’algorithme de compression BZip2.
* `time` : Active les fonctionnalités utilisant la bibliothèque [time](https://github.com/rust-lang-deprecated/time).
* `chrono` : Permet de convertir la date de dernière modification `zip::DateTime` vers et depuis `chrono::NaiveDateTime`.
* `jiff-02` : Permet de convertir la date de dernière modification `zip::DateTime` vers et depuis `jiff::civil::DateTime`.
* `nt-time` : Permet de retourner les horodatages stockés dans le champ supplémentaire NTFS sous forme de `nt_time::FileTime`.
* `zstd` : Active l’algorithme de compression Zstandard.

Par défaut, `aes-crypto`, `bzip2`, `deflate`, `deflate64`, `lzma`, `time` et `zstd` sont activés.

MSRV
----

Notre version minimale actuellement prise en charge de Rust est **1.75**. Lors de l’ajout de fonctionnalités,
nous suivrons les lignes directrices suivantes :

- Nous prendrons toujours en charge une version mineure de Rust qui est stable depuis au moins 6 mois.
- Toute modification du MSRV sera accompagnée d’une augmentation de version **mineure**.

Exemples
--------

Voir le [répertoire des exemples](https://raw.githubusercontent.com/zip-rs/zip2/master/examples) pour :
   * Comment écrire un fichier dans un zip.
   * Comment écrire un répertoire de fichiers dans un zip (en utilisant [walkdir](https://github.com/BurntSushi/walkdir)).
   * Comment extraire un fichier zip.
   * Comment extraire un fichier unique d’un zip.
   * Comment lire un zip depuis l’entrée standard.
   * Comment ajouter un répertoire à une archive existante

Fuzzing
-------

La prise en charge du fuzzing se fait via [cargo afl](https://rust-fuzz.github.io/book/afl.html). Pour installer cargo afl :

```bash
cargo install cargo-afl
```

Pour commencer le fuzzing de l’extraction zip :

```bash
cargo +nightly afl build --all-features --manifest-path fuzz_read/Cargo.toml
cargo +nightly afl run fuzz_read/target/debug/fuzz_read
```

Pour commencer le fuzzing de la création zip :

```bash
cargo +nightly afl build --all-features --manifest-path fuzz_write/Cargo.toml
cargo +nightly afl run fuzz_write/target/debug/fuzz_write
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---