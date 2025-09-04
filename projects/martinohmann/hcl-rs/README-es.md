# hcl-rs

[![Estado de la compilación](https://github.com/martinohmann/hcl-rs/workflows/ci/badge.svg)](https://github.com/martinohmann/hcl-rs/actions?query=workflow%3Aci)
[![Licencia: Apache 2.0](https://img.shields.io/badge/License-Apache_2.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)
[![Licencia: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

Este repositorio contiene los siguientes crates de Rust alrededor del Lenguaje de Configuración Hashicorp (HCL):

- [`hcl-rs`](https://github.com/martinohmann/hcl-rs/blob/main/crates/hcl-rs):
  Biblioteca HCL con soporte para `serde` y evaluación de expresiones.
- [`hcl-edit`](https://github.com/martinohmann/hcl-rs/blob/main/crates/hcl-edit):
  Analiza y modifica documentos HCL preservando espacios en blanco y comentarios.
- [`hcl-primitives`](https://github.com/martinohmann/hcl-rs/blob/main/crates/hcl-primitives):
  Primitivas usadas por los sub-lenguajes HCL.
- [`hcl2json`](https://github.com/martinohmann/hcl-rs/blob/main/crates/hcl2json):
  Programa CLI para convertir HCL a JSON.

## Paridad de características con la implementación go-hcl

Los crates en este repositorio intentan seguir de cerca estas especificaciones que
son parte de la [implementación HCL Go](https://github.com/hashicorp/hcl) de Hashicorp:

- [Modelo de Información Agnóstico a la Sintaxis HCL](https://github.com/hashicorp/hcl/blob/main/spec.md)
- [Especificación de Sintaxis Nativa HCL](https://github.com/hashicorp/hcl/blob/main/hclsyntax/spec.md)
- [Especificación de Sintaxis JSON HCL](https://github.com/hashicorp/hcl/blob/main/json/spec.md)

A nivel del parser debería soportar todas las características que go-hcl soporta hoy.
Sin embargo, las implementaciones para el formateo y la evaluación de expresiones en `hcl-rs`
son relativamente básicas en este momento. Hay planes para mover las capacidades de formateo y
evaluación de expresiones a `hcl-edit` (que es usado por `hcl-rs` internamente y también contiene la implementación del parser) y hacerlas más
potentes.

Otra cosa que no está incluida (todavía), es el soporte para esquemas HCL para
validar que un documento HCL analizado solo contenga un conjunto permitido de
bloques con atributos esperados (por ejemplo, para habilitar la validación de que una configuración
terraform dada solo contenga bloques `resource` y `data` bien formados, etc.).




Además, el soporte de esquemas puede facilitar la codificación de configuraciones más complejas utilizando tipos personalizados. Estas configuraciones son actualmente difíciles de ensamblar debido a las limitaciones del modelo `serde`.

## Contribuciones

¡Las contribuciones son bienvenidas! Por favor, lea
[`CONTRIBUTING.md`](https://github.com/martinohmann/hcl-rs/blob/main/CONTRIBUTING.md)
antes de crear un PR.

## Licencia

Si no se indica lo contrario, el código fuente dentro de este repositorio está licenciado
bajo cualquiera de las [Licencia Apache, Versión
2.0](https://github.com/martinohmann/hcl-rs/blob/main/LICENSE-APACHE) o la [licencia MIT](https://github.com/martinohmann/hcl-rs/blob/main/LICENSE-MIT) a su
opción.






---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-04

---