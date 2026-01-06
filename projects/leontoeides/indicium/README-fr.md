# indicium
![Crates.io Version](https://img.shields.io/crates/v/indicium)
![Crates.io MSRV](https://img.shields.io/crates/msrv/indicium)
![Crates.io License](https://img.shields.io/crates/l/indicium)
![Crates.io Total Downloads](https://img.shields.io/crates/d/indicium)

Une recherche simple en mémoire pour des collections (`Vec`, `HashMap`, `BTreeMap`, etc.)
et des magasins clé-valeur. Offre la complétion automatique et la correspondance approximative.

Il existe de nombreux moteurs de recherche incroyables disponibles pour Rust. Beaucoup semblent
nécessiter la compilation d’un binaire serveur séparé. Je voulais quelque chose de simple et
léger - une crate facile à utiliser qui pourrait rechercher commodément des structures et
collections dans mon propre binaire. Alors, j’ai créé `indicium`.

<img src="https://www.arkiteq.io/crates/indicium/banner.jpg" alt="Indicium: A Simple In-Memory Search for Rust" width="400"/>

Bien que `indicium` ait été conçu pour les applications web, c’est une recherche en mémoire et
elle ne s’adapte pas indéfiniment ni à l’échelle du cloud (c’est-à-dire à l’échelle de Facebook ou Google).
Même dans un tel environnement, ce serait toujours un moyen pratique de rechercher
de grandes listes (comme des devises, langues, pays, etc.) C’est aussi idéal pour
des applications où une limite d’échelle est prévue (c’est-à-dire la recherche dans une liste
d’actifs d’entreprise, liste d’utilisateurs dans un intranet d’entreprise, etc.)

Indicium peut facilement gérer des millions d’enregistrements sans sourciller grâce
au [BTreeMap](https://cglab.ca/~abeinges/blah/rust-btree-case/) de Rust. Cette
crate est principalement limitée par la mémoire disponible. Cependant, selon la nature
de votre jeu de données et s’il y a des mots-clés répétés de nombreuses fois,
les performances peuvent commencer à se dégrader à un certain point.

# Installation

Configurez les dépendances dans le fichier `Cargo.toml` de votre projet :

```toml
[dependencies]
indicium = "0.6"
```

# Notes de version

* Les notes de version sont disponibles sur
  [GitHub](https://github.com/leontoeides/indicium/releases).

* Le [journal des modifications](https://github.com/leontoeides/indicium/blob/master/CHANGELOG.md) complet est
  disponible sur GitHub.

# Guide de démarrage rapide

Pour notre exemple de **Guide de démarrage rapide**, nous allons effectuer une recherche à l’intérieur de la
`struct` suivante :


```rust
struct MyStruct {
    title: String,
    year: u16,
    body: String,
}
```

## 1. Implémentation de Indexable

Pour commencer, nous devons rendre notre enregistrement indexable. Nous allons le faire en implémentant le
trait `Indexable` pour notre `struct`. L'idée est de retourner une `String` pour chaque
champ que nous souhaitons indexer. Exemple :

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

N'oubliez pas que vous pouvez rendre les nombres, identifiants numériques, énumérations et autres
types dans votre `struct` (ou autres types complexes) indexables en les convertissant en
`String` et en les incluant dans le `Vec<String>` retourné.

## 2. Indexation d'une collection

Pour indexer une collection existante, nous pouvons itérer sur la collection. Pour chaque
enregistrement, nous l'insérerons dans l'index de recherche. Cela devrait ressembler à
ces deux exemples :

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

Tant que le trait `Indexable` a été implémenté pour votre type de valeur, les exemples ci-dessus
indexeront un `Vec` ou un `HashMap` préalablement rempli. Cependant,
la méthode préférée pour les grandes collections est de `insert` dans le `SearchIndex` au fur et à mesure
que vous insérez dans votre collection (Vec, HashMap, etc.)

Il est recommandé d'encapsuler votre collection cible (votre `Vec`, `HashMap`, etc.)
et ce `SearchIndex` ensemble dans un nouveau type `struct`. Ensuite, implémentez les
méthodes `insert`, `replace`, `remove`, etc. pour ce nouveau type `struct` qui
mettront à jour à la fois la collection et l'index de recherche. Cela garantira que votre
collection et l'index sont toujours synchronisés.

Une fois l'index peuplé, vous pouvez utiliser les méthodes `search` et `autocomplete`.

## 3. Recherche

La méthode `search` renverra des clés comme résultats de recherche. Chaque clé résultante
peut ensuite être utilisée pour récupérer l'enregistrement complet dans sa collection.

Utilisation basique :


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

La recherche ne prend en charge que les correspondances exactes de mots-clés. Pour les recherches `Live`, la correspondance approximative
n'est appliquée qu'au dernier mot-clé. Envisagez de fournir la fonctionnalité `autocomplete`
à vos utilisateurs pour les aider à construire leur recherche au fur et à mesure de la frappe.

## 4. Autocomplétion

La méthode `autocomplete` fournira plusieurs options d'autocomplétion pour le
dernier mot-clé dans la chaîne fournie.

Utilisation basique :

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

# Points Bonus

## 5. Ordre Personnalisé des Résultats

À l'exception de `SearchType::Or` qui utilise le score de pertinence, les résultats
de recherche sont retournés dans l'ordre défini par l'implémentation `Ord`
de votre type de clé. Cela signifie que vous pouvez contrôler l'ordre des résultats
en utilisant un type de clé personnalisé au lieu de simples entiers ou chaînes.

Par exemple, si vous souhaitez que les éléments populaires apparaissent en premier
dans les résultats de recherche, vous pouvez créer une clé qui trie par popularité :

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

Maintenant, lorsque vous effectuez une recherche, les résultats reviennent automatiquement triés par popularité. Aucune
étape de tri supplémentaire n'est nécessaire.

Ce modèle fonctionne pour tout signal de classement : récence, scores de pertinence, ordre de tri manuel, etc. Il suffit de changer ce que `Ord` compare.

### Utilisation des clés pour les recherches

Après la recherche, vous récupérez généralement l'enregistrement complet de votre collection :


```rust
let results = search_index.search("dawn");

for key in results {
    if let Some(record) = my_records.get(key) {
        println!("{:?}", record);
    }
}
```
Parce que les traits `Eq` et `Hash` que nous avons implémentés dans l'exemple ne regardent que le champ `id` (pas `popularity`), vous pouvez toujours utiliser directement les clés des résultats de recherche pour les recherches dans `HashMap`.

# État du Crate

Ce crate est maintenu de manière passive. Ce crate fait ce qu'on attend de lui et
le fait assez bien, à mon avis. Des mises à jour fréquentes ne sont pas prévues.




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-06

---