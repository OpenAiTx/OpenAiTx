# fastbloom
[![Github](https://img.shields.io/badge/github-8da0cb?style=for-the-badge&labelColor=555555&logo=github)](https://github.com/tomtomwombat/fastbloom)
[![Crates.io](https://img.shields.io/badge/crates.io-fc8d62?style=for-the-badge&labelColor=555555&logo=rust)](https://crates.io/crates/fastbloom)
[![docs.rs](https://img.shields.io/badge/docs.rs-66c2a5?style=for-the-badge&labelColor=555555&logo=docs.rs)](https://docs.rs/fastbloom)
![Downloads](https://img.shields.io/crates/d/fastbloom?style=for-the-badge)

El filtro Bloom más rápido en Rust. Sin compromisos en la precisión. Soporte completo para concurrencia y compatible con cualquier función hash.

## Visión general

fastbloom es un filtro Bloom rápido, flexible y preciso implementado en Rust. El hasher predeterminado de fastbloom es SipHash-1-3 usando claves aleatorias, pero puede ser inicializado o configurado para usar cualquier función hash. fastbloom es entre 2 y 20 veces más rápido y mucho más preciso que las implementaciones existentes de filtros Bloom. `AtomicBloomFilter` de fastbloom es un filtro Bloom concurrente que evita la contención de bloqueos.

## Uso

Debido a un algoritmo diferente (¡mejorado!) en la versión 0.17.x, los filtros Bloom tienen serialización/deserialización incompatible con versiones anteriores.

```toml
# Cargo.toml
[dependencies]
fastbloom = "0.17.0"
```
Uso básico:
```rust
use fastbloom::BloomFilter;

let mut filter = BloomFilter::with_num_bits(1024).expected_items(2);
filter.insert("42");
filter.insert("🦀");
```
Instanciar con una tasa objetivo de falsos positivos:
```rust
use fastbloom::BloomFilter;

let filter = BloomFilter::with_false_pos(0.001).items(["42", "🦀"].iter());
assert!(filter.contains("42"));
assert!(filter.contains("🦀"));
```
Usa cualquier hasher:
```rust
use fastbloom::BloomFilter;
use foldhash::fast::RandomState;

let filter = BloomFilter::with_num_bits(1024)
    .hasher(RandomState::default())
    .items(["42", "🦀"].iter());
```
Soporte completo para concurrencia. `AtomicBloomFilter` es un reemplazo directo para `RwLock<OtherBloomFilter>` porque todos los métodos toman `&self`:
```rust
use fastbloom::AtomicBloomFilter;

let filter = AtomicBloomFilter::with_num_bits(1024).expected_items(2);
filter.insert("42");
filter.insert("🦀");
```

## Antecedentes
Los filtros de Bloom son estructuras de datos de conjuntos de membresía aproximada y espacio eficiente, soportadas por un arreglo subyacente de bits para rastrear la pertenencia de elementos. Para insertar/verificar la pertenencia, se establecen/verifican varios bits en posiciones basadas en el hash del elemento. Son posibles falsos positivos en una verificación de membresía, pero no falsos negativos. Una vez construido, ni el uso de memoria subyacente del filtro de Bloom ni el número de bits por elemento cambian. [Ver más.](https://es.wikipedia.org/wiki/Filtro_de_Bloom)

```text
hash(4) ──────┬─────┬───────────────┐
              ↓     ↓               ↓
0 0 0 0 0 0 0 1 0 0 1 0 0 0 0 0 0 0 1 0
  ↑           ↑           ↑
  └───────────┴───────────┴──── hash(3) (not in the set)
```
## Implementación

fastbloom es extremadamente rápido porque deriva eficientemente muchos bits de índice a partir de **solo un hash real por elemento** y aprovecha otros hallazgos de investigación sobre filtros Bloom. fastbloom emplea "composición de hashes" sobre dos mitades de 32 bits de un hash original de 64 bits. Cada hash subsecuente se deriva combinando el valor del hash original con una constante diferente usando aritmética modular y operaciones a nivel de bits. Esto resulta en un conjunto de funciones hash que son efectivamente independientes y uniformemente distribuidas, aunque se derivan de la misma función hash original. Calcular la composición de dos hashes originales es más rápido que volver a calcular el hash con una semilla diferente. Esta técnica se [explica en profundidad en este artículo.](https://www.eecs.harvard.edu/~michaelm/postscripts/rsa2008.pdf)

## Velocidad
- Procesador AMD Ryzen 9 5900X de 12 núcleos             (3.70 GHz)
- Sistema operativo de 64 bits, procesador basado en x64

![perf-non-member](https://github.com/user-attachments/assets/a825d2f7-4cd7-4b6b-a447-fd7f3dab356b)
![perf-member](https://github.com/user-attachments/assets/998f9470-b91f-460c-ad2d-1f197160c210)
> Hashers usados:
> - xxhash: sbbf
> - Sip1-3: bloom, bloomfilter, probabilistic-collections
> - foldhash: fastbloom
> 
> [Fuente del benchmark](https://github.com/tomtomwombat/bench-bloom-filters)

## Precisión

fastbloom no compromete la precisión. A continuación se muestra una comparación de las tasas de falsos positivos con otros crates de filtros Bloom:

![fp](https://github.com/user-attachments/assets/17ddaab7-c63f-456a-9e2e-b22c7f994386)

[Fuente del benchmark](https://github.com/tomtomwombat/bench-bloom-filters)

## Características Disponibles

- **`rand`** - Habilitado por defecto, esto hace que `DefaultHasher` obtenga su estado aleatorio usando `thread_rng()` en lugar de fuentes de hardware. Obtener entropía desde una fuente en espacio de usuario es considerablemente más rápido, pero requiere dependencias adicionales para lograrlo. Deshabilitar esta característica usando `default-features = false` hace que `DefaultHasher` obtenga su entropía usando `foldhash`, lo que tendrá una huella de código mucho más simple a costa de la velocidad.
- **`serde`** - `BloomFilter`s implementan `Serialize` y `Deserialize` cuando es posible.
- **`loom`** - `AtomicBloomFilter`s usan atómicos de [loom](https://github.com/tokio-rs/loom), haciéndolo compatible con pruebas loom.

## Referencias
- [Filtro Bloom - Wikipedia](https://es.wikipedia.org/wiki/Filtro_Bloom)
- [Filtros Bloom desacreditados: Desmintiendo 30 años de malas matemáticas con Coq](https://gopiandcode.uk/logs/log-bloomfilters-debunked.html)
- [Demostración Interactiva de Filtro Bloom](https://www.jasondavies.com/bloomfilter/)
- [Filtros Bloom eficientes en caché, hash y espacio](https://web.archive.org/web/20070623102632/http://algo2.iti.uni-karlsruhe.de/singler/publications/cacheefficientbloomfilters-wea2007.pdf)
- [Menos hashing, mismo rendimiento: Construyendo un mejor filtro Bloom](https://www.eecs.harvard.edu/~michaelm/postscripts/rsa2008.pdf)
- [Una alternativa rápida a la reducción módulo](https://lemire.me/blog/2016/06/27/a-fast-alternative-to-the-modulo-reduction/)


## Licencia

Licenciado bajo cualquiera de

 * Licencia Apache, Versión 2.0
   ([LICENSE-APACHE](LICENSE-APACHE) o http://www.apache.org/licenses/LICENSE-2.0)
 * Licencia MIT
   ([LICENSE-MIT](LICENSE-MIT) o http://opensource.org/licenses/MIT)

a su elección.

## Contribución

A menos que usted indique explícitamente lo contrario, cualquier contribución intencionadamente enviada
para su inclusión en el trabajo por usted, según se define en la licencia Apache-2.0, será
licenciada de forma dual como se indica arriba, sin términos o condiciones adicionales.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-15

---