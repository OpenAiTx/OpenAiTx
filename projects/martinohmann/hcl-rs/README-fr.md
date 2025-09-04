# hcl-rs

[![Build Status](https://github.com/martinohmann/hcl-rs/workflows/ci/badge.svg)](https://github.com/martinohmann/hcl-rs/actions?query=workflow%3Aci)
[![License: Apache 2.0](https://img.shields.io/badge/License-Apache_2.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

Ce dépôt contient les crates Rust suivantes autour du Hashicorp
Configuration Language (HCL) :

- [`hcl-rs`](https://github.com/martinohmann/hcl-rs/blob/main/crates/hcl-rs) :
  Bibliothèque HCL avec support de `serde` et de l’évaluation d’expressions.
- [`hcl-edit`](https://github.com/martinohmann/hcl-rs/blob/main/crates/hcl-edit) :
  Analyse et modification de documents HCL tout en préservant les espaces et commentaires.
- [`hcl-primitives`](https://github.com/martinohmann/hcl-rs/blob/main/crates/hcl-primitives) :
  Primitives utilisées par les sous-langages HCL.
- [`hcl2json`](https://github.com/martinohmann/hcl-rs/blob/main/crates/hcl2json) :
  Programme CLI pour convertir HCL en JSON.

## Parité fonctionnelle avec l’implémentation go-hcl

Les crates de ce dépôt essaient de suivre de près ces spécifications qui
font partie de l’implémentation [HCL Go](https://github.com/hashicorp/hcl) de Hashicorp :

- [Modèle d’information syntaxe-agnostique HCL](https://github.com/hashicorp/hcl/blob/main/spec.md)
- [Spécification syntaxe native HCL](https://github.com/hashicorp/hcl/blob/main/hclsyntax/spec.md)
- [Spécification syntaxe JSON HCL](https://github.com/hashicorp/hcl/blob/main/json/spec.md)

Au niveau du parseur, il devrait supporter toutes les fonctionnalités présentes dans go-hcl aujourd’hui.
Cependant, les implémentations pour le formatage et l’évaluation d’expressions dans `hcl-rs`
sont pour l’instant relativement basiques. Il est prévu de déplacer les capacités de formatage et
d’évaluation d’expressions dans `hcl-edit` (utilisé par `hcl-rs` en interne et contenant aussi l’implémentation du parseur)
et de les rendre plus puissantes.

Autre point non inclus (encore), le support des schémas HCL
pour valider qu’un document HCL analysé ne contient qu’un ensemble autorisé
de blocs avec des attributs attendus (par exemple pour permettre la validation qu’une configuration
terraform donnée ne contient que des blocs `resource` et `data` bien formés, etc.).




De plus, la prise en charge des schémas peut faciliter l’encodage de configurations plus complexes
en utilisant des types personnalisés. Ces configurations sont actuellement
difficiles à assembler en raison des limitations du modèle `serde`.

## Contribution

Les contributions sont les bienvenues ! Veuillez lire
[`CONTRIBUTING.md`](https://github.com/martinohmann/hcl-rs/blob/main/CONTRIBUTING.md)
avant de créer une PR.

## Licence

Sauf indication contraire, le code source contenu dans ce dépôt est licencié
sous l’une des licences [Apache License, Version
2.0](https://github.com/martinohmann/hcl-rs/blob/main/LICENSE-APACHE) ou [licence
MIT](https://github.com/martinohmann/hcl-rs/blob/main/LICENSE-MIT) selon votre
choix.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-04

---