# indicium
![Versión en Crates.io](https://img.shields.io/crates/v/indicium)
![MSRV en Crates.io](https://img.shields.io/crates/msrv/indicium)
![Licencia en Crates.io](https://img.shields.io/crates/l/indicium)
![Descargas Totales en Crates.io](https://img.shields.io/crates/d/indicium)

Una búsqueda simple en memoria para colecciones (`Vec`, `HashMap`, `BTreeMap`, etc.)  
y almacenes clave-valor. Incluye autocompletado y coincidencia difusa.

Existen muchos motores de búsqueda increíbles disponibles para Rust. Muchos parecen  
requerir compilar un binario servidor separado. Quería algo simple y  
ligero: un crate fácil de usar que pudiera buscar cómodamente estructuras y  
colecciones dentro de mi propio binario. Así que creé `indicium`.

<img src="https://www.arkiteq.io/crates/indicium/banner.jpg" alt="Indicium: Una Búsqueda Simple en Memoria para Rust" width="400"/>

Aunque `indicium` fue hecho pensando en aplicaciones web, es una búsqueda en memoria y  
no escala indefinidamente ni a tamaño nube (es decir, tamaño Facebook o Google).  
Incluso en un entorno así, seguiría siendo una forma conveniente de buscar  
listas grandes (como monedas, idiomas, países, etc.) También es ideal para  
aplicaciones donde se anticipa un límite de escala (es decir, buscar en una lista de  
activos de una empresa, lista de usuarios en una intranet corporativa, etc.)

Indicium puede manejar fácilmente millones de registros sin sudar gracias  
a [BTreeMap](https://cglab.ca/~abeinges/blah/rust-btree-case/) de Rust. Este  
crate está principalmente limitado por la memoria disponible. Sin embargo, dependiendo  
de la naturaleza de su conjunto de datos y si hay palabras clave que se repiten muchas veces,  
el rendimiento puede comenzar a degradarse en algún punto.

# Instalación

Configure las dependencias en el archivo `Cargo.toml` de su proyecto:

```toml
[dependencies]
indicium = "0.6"
```

# Notas de la Versión

* Las notas de la versión están disponibles en
  [GitHub](https://github.com/leontoeides/indicium/releases).

* El [registro de cambios](https://github.com/leontoeides/indicium/blob/master/CHANGELOG.md) completo está
  disponible en GitHub.

# Guía de Inicio Rápido

Para nuestro ejemplo de **Guía de Inicio Rápido**, buscaremos dentro de la
siguiente `struct`:


```rust
struct MyStruct {
    title: String,
    year: u16,
    body: String,
}
```

## 1. Implementando Indexable

Para comenzar, debemos hacer que nuestro registro sea indexable. Lo haremos implementando el
rasgo `Indexable` para nuestra `struct`. La idea es devolver un `String` para cada
campo que queramos indexar. Ejemplo:

```rust
use indicium::simple::Indexable;

impl Indexable for MyStruct {
    fn strings(&self) -> Vec<String> {
        vec![
            self.title.clone(),
            self.year.to_string(),
            self.body.clone(),
        ]
    }
}
```

No olvides que puedes hacer que los números, identificadores numéricos, enumeraciones y otros
tipos en tu `struct` (u otros tipos complejos) sean indexables convirtiéndolos a
un `String` e incluyéndolos en el `Vec<String>` que se devuelve.

## 2. Indexación de una Colección

Para indexar una colección existente, podemos iterar sobre la colección. Para cada
registro, lo insertaremos en el índice de búsqueda. Esto debería verse algo
como estos dos ejemplos:

#### Vec

```rust
use indicium::simple::SearchIndex;

let my_vec: Vec<MyStruct> = Vec::new();

// In the case of a `Vec` collection, we use the index as our key. A
// `Vec` index is a `usize` type. Therefore we will instantiate
// `SearchIndex` as `SearchIndex<usize>`.

let mut search_index: SearchIndex<usize> = SearchIndex::default();

my_vec
    .iter()
    .enumerate()
    .for_each(|(index, element)|
        search_index.insert(&index, element)
    );
```

#### HashMap

```rust
use std::collections::HashMap;
use indicium::simple::SearchIndex;

let my_hash_map: HashMap<String, MyStruct> = HashMap::new();

// In the case of a `HashMap` collection, we use the hash map's key as
// the `SearchIndex` key. In our hypothetical example, we will use
// MyStruct's `title` as a the key which is a `String` type. Therefore
// we will instantiate `HashMap<K, V>` as HashMap<String, MyStruct> and
// `SearchIndex<K>` as `SearchIndex<String>`.

let mut search_index: SearchIndex<String> = SearchIndex::default();

my_hash_map
    .iter()
    .for_each(|(key, value)|
        search_index.insert(key, value)
    );
```

Mientras que el rasgo `Indexable` esté implementado para tu tipo de valor, los ejemplos anteriores
indexarán un `Vec` o `HashMap` previamente poblado. Sin embargo, el
método preferido para colecciones grandes es `insertar` en el `SearchIndex` conforme
inserta en tu colección (Vec, HashMap, etc.)

Se recomienda envolver tu colección objetivo (tu `Vec`, `HashMap`, etc.)
y este `SearchIndex` juntos en un nuevo tipo de `struct`. Luego, implementa los
métodos `insert`, `replace`, `remove`, etc. para este nuevo tipo de `struct` que
actualizará tanto la colección como el índice de búsqueda. Esto asegurará que tanto tu
colección como el índice estén siempre sincronizados.

Una vez que el índice ha sido poblado, puedes usar los métodos `search` y `autocomplete`.

## 3. Búsqueda

El método `search` devolverá claves como resultados de la búsqueda. Cada clave resultante
puede usarse para recuperar el registro completo de su colección.

Uso básico:


```rust
let mut search_index: SearchIndex<usize> = SearchIndex::default();

search_index.insert(&0, &"Harold Godwinson");
search_index.insert(&1, &"Edgar Ætheling");
search_index.insert(&2, &"William the Conqueror");
search_index.insert(&3, &"William Rufus");
search_index.insert(&4, &"Henry Beauclerc");

let resulting_keys: Vec<&usize> = search_index.search("William");

assert_eq!(resulting_keys, vec![&2, &3]);

// Demonstrating fuzzy matching:

let resulting_keys: Vec<&usize> = search_index.search("Harry");

assert_eq!(resulting_keys, vec![&0]);
```

La búsqueda solo admite coincidencias exactas de palabras clave. Para búsquedas `en vivo`, la coincidencia aproximada
solo se aplica a la última palabra clave. Considere proporcionar la función de `autocompletar`
a sus usuarios para ayudarlos a construir su búsqueda mientras escriben.

## 4. Autocompletado

El método `autocomplete` proporcionará varias opciones de autocompletado para la
última palabra clave en la cadena proporcionada.

Uso básico:

```rust
let mut search_index: SearchIndex<usize> =
    SearchIndexBuilder::default()
        .autocomplete_type(&AutocompleteType::Global)
        .build();

search_index.insert(&0, &"apple");
search_index.insert(&1, &"ball");
search_index.insert(&3, &"bird");
search_index.insert(&4, &"birthday");
search_index.insert(&5, &"red");

let autocomplete_options: Vec<String> =
    search_index.autocomplete("a very big bi");

assert_eq!(
    autocomplete_options,
    vec!["a very big bird", "a very big birthday"]
);

// Demonstrating fuzzy matching:

let autocomplete_options: Vec<String> =
    search_index.autocomplete("a very big birf");

assert_eq!(
    autocomplete_options,
    vec!["a very big bird", "a very big birthday"]
);
```

# Puntos Extra

## 5. Ordenación Personalizada de Resultados

Con la excepción de `SearchType::Or`, que utiliza puntuación de relevancia, los resultados de búsqueda se devuelven en el orden definido por la implementación de `Ord` de tu tipo de clave.  
Esto significa que puedes controlar el orden de los resultados usando un tipo de clave personalizado en lugar de enteros o cadenas simples.

Por ejemplo, si quieres que los elementos populares aparezcan primero en los resultados de búsqueda,  
puedes crear una clave que ordene por popularidad:



```rust
use std::cmp::Ordering;
use std::hash::{Hash, Hasher};

/// A search key that sorts results by popularity (highest first).
#[derive(Debug, Clone)]
pub struct RankedKey {
    pub id: String,
    pub popularity: u32,
}

impl Ord for RankedKey {
    fn cmp(&self, other: &Self) -> Ordering {
        // Higher popularity comes first
        other.popularity.cmp(&self.popularity)
    }
}

impl PartialOrd for RankedKey {
    fn partial_cmp(&self, other: &Self) -> Option {
        Some(self.cmp(other))
    }
}

// For equality and lookups, we only compare the id, not popularity. This lets
// us find records in a HashMap using just the id.

impl PartialEq for RankedKey {
    fn eq(&self, other: &Self) -> bool {
        self.id == other.id
    }
}

impl Eq for RankedKey {}

impl Hash for RankedKey {
    fn hash(&self, state: &mut H) {
        self.id.hash(state);
    }
}
```

Ahora, cuando buscas, los resultados se devuelven automáticamente ordenados por popularidad. No
se necesita un paso adicional de ordenamiento.

Este patrón funciona para cualquier señal de clasificación: actualidad, puntuaciones de relevancia, orden
manual, etc. Solo cambia lo que `Ord` compara.

### Uso de Claves para Búsquedas

Después de buscar, normalmente obtendrás el registro completo de tu colección:

```rust
let results = search_index.search("dawn");

for key in results {
    if let Some(record) = my_records.get(key) {
        println!("{:?}", record);
    }
}
```

Debido a que los traits `Eq` y `Hash` que implementamos en el ejemplo solo consideran
el campo `id` (no `popularity`), aún puedes usar las claves de resultados de búsqueda
directamente para búsquedas en `HashMap`.

# Estado del Crate

Este crate se mantiene de forma pasiva. Este crate hace lo que se espera que haga y
lo hace bastante bien, en mi opinión. No se esperan actualizaciones frecuentes.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-06

---