# fastbloom
[![Github](https://img.shields.io/badge/github-8da0cb?style=for-the-badge&labelColor=555555&logo=github)](https://github.com/tomtomwombat/fastbloom)
[![Crates.io](https://img.shields.io/badge/crates.io-fc8d62?style=for-the-badge&labelColor=555555&logo=rust)](https://crates.io/crates/fastbloom)
[![docs.rs](https://img.shields.io/badge/docs.rs-66c2a5?style=for-the-badge&labelColor=555555&logo=docs.rs)](https://docs.rs/fastbloom)
![Downloads](https://img.shields.io/crates/d/fastbloom?style=for-the-badge)

Le filtre de Bloom le plus rapide en Rust. Aucune compromission sur la précision. Support complet de la concurrence et compatible avec n'importe quel hachageur.

## Aperçu

fastbloom est un filtre de Bloom rapide, flexible et précis implémenté en Rust. Le hachageur par défaut de fastbloom est SipHash-1-3 utilisant des clés randomisées, mais il peut être initialisé ou configuré pour utiliser n'importe quel hachageur. fastbloom est 2 à 20 fois plus rapide et d'une précision bien supérieure aux implémentations existantes de filtres de Bloom. `AtomicBloomFilter` de fastbloom est un filtre de Bloom concurrent qui évite la contention sur les verrous.

## Utilisation

En raison d’un algorithme différent (amélioré !) dans la version 0.17.x, la sérialisation/désérialisation des filtres de Bloom est incompatible avec les versions antérieures.

```toml
# Cargo.toml
[dependencies]
fastbloom = "0.17.0"
```
Utilisation de base :
```rust
use fastbloom::BloomFilter;

let mut filter = BloomFilter::with_num_bits(1024).expected_items(2);
filter.insert("42");
filter.insert("🦀");
```
Instancier avec un taux de faux positifs cible :
```rust
use fastbloom::BloomFilter;

let filter = BloomFilter::with_false_pos(0.001).items(["42", "🦀"].iter());
assert!(filter.contains("42"));
assert!(filter.contains("🦀"));
```
Utilisez n'importe quel hacheur :
```rust
use fastbloom::BloomFilter;
use foldhash::fast::RandomState;

let filter = BloomFilter::with_num_bits(1024)
    .hasher(RandomState::default())
    .items(["42", "🦀"].iter());
```
Prise en charge complète de la concurrence. `AtomicBloomFilter` est un remplacement direct de `RwLock<OtherBloomFilter>` car toutes les méthodes prennent `&self` :
```rust
use fastbloom::AtomicBloomFilter;

let filter = AtomicBloomFilter::with_num_bits(1024).expected_items(2);
filter.insert("42");
filter.insert("🦀");
```

## Contexte
Les filtres de Bloom sont des structures de données d'appartenance approximative économes en espace, basées sur un tableau de bits sous-jacent pour suivre l'appartenance des éléments. Pour insérer/vérifier l'appartenance, un certain nombre de bits sont définis/vérifiés à des positions basées sur le hachage de l'élément. Des faux positifs lors d'une vérification d'appartenance sont possibles, mais pas de faux négatifs. Une fois construit, ni l'utilisation mémoire sous-jacente du filtre de Bloom ni le nombre de bits par élément ne changent. [Voir plus.](https://en.wikipedia.org/wiki/Bloom_filter)

```text
hash(4) ──────┬─────┬───────────────┐
              ↓     ↓               ↓
0 0 0 0 0 0 0 1 0 0 1 0 0 0 0 0 0 0 1 0
  ↑           ↑           ↑
  └───────────┴───────────┴──── hash(3) (not in the set)
```
## Implémentation

fastbloom est extrêmement rapide car il dérive efficacement de nombreux bits d’index à partir de **seulement un vrai hachage par élément** et exploite d’autres résultats de recherche sur les filtres de Bloom. fastbloom utilise la « composition de hachage » sur deux moitiés de 32 bits d’un hachage original de 64 bits. Chaque hachage ultérieur est dérivé en combinant la valeur du hachage original avec une constante différente en utilisant l’arithmétique modulaire et des opérations bit à bit. Cela donne un ensemble de fonctions de hachage qui sont effectivement indépendantes et uniformément distribuées, bien qu’elles soient dérivées de la même fonction de hachage originale. Calculer la composition de deux hachages originaux est plus rapide que de recalculer le hachage avec une graine différente. Cette technique est [expliquée en détail dans cet article.](https://www.eecs.harvard.edu/~michaelm/postscripts/rsa2008.pdf)

## Vitesse
- AMD Ryzen 9 5900X 12-Core Processor             (3,70 GHz)
- Système d’exploitation 64 bits, processeur x64

![perf-non-member](https://github.com/user-attachments/assets/a825d2f7-4cd7-4b6b-a447-fd7f3dab356b)
![perf-member](https://github.com/user-attachments/assets/998f9470-b91f-460c-ad2d-1f197160c210)
> Hacheurs utilisés :
> - xxhash : sbbf
> - Sip1-3 : bloom, bloomfilter, probabilistic-collections
> - foldhash : fastbloom
> 
> [Source du benchmark](https://github.com/tomtomwombat/bench-bloom-filters)

## Précision

fastbloom ne compromet pas la précision. Voici une comparaison des taux de faux positifs avec d’autres crates de filtres de Bloom :

![fp](https://github.com/user-attachments/assets/17ddaab7-c63f-456a-9e2e-b22c7f994386)

[Source du benchmark](https://github.com/tomtomwombat/bench-bloom-filters)

## Fonctionnalités disponibles

- **`rand`** - Activé par défaut, cela permet à `DefaultHasher` de puiser son état aléatoire via `thread_rng()` au lieu de sources matérielles. Obtenir de l’entropie depuis une source en espace utilisateur est considérablement plus rapide, mais nécessite des dépendances supplémentaires. Désactiver cette fonctionnalité via `default-features = false` fait que `DefaultHasher` utilise `foldhash` pour son entropie, ce qui aura une empreinte code bien plus simple au prix de la vitesse.
- **`serde`** - Les `BloomFilter` implémentent `Serialize` et `Deserialize` lorsque cela est possible.
- **`loom`** - Les `AtomicBloomFilter` utilisent les atomiques [loom](https://github.com/tokio-rs/loom), ce qui les rend compatibles avec les tests loom.

## Références
- [Filtre de Bloom - Wikipédia](https://fr.wikipedia.org/wiki/Filtre_de_Bloom)
- [Filtres de Bloom démystifiés : Dissiper 30 ans de mathématiques erronées avec Coq !](https://gopiandcode.uk/logs/log-bloomfilters-debunked.html)
- [Démonstration interactive du filtre de Bloom](https://www.jasondavies.com/bloomfilter/)
- [Filtres de Bloom efficaces en cache, hachage et espace](https://web.archive.org/web/20070623102632/http://algo2.iti.uni-karlsruhe.de/singler/publications/cacheefficientbloomfilters-wea2007.pdf)
- [Moins de hachage, même performance : Construire un meilleur filtre de Bloom](https://www.eecs.harvard.edu/~michaelm/postscripts/rsa2008.pdf)
- [Une alternative rapide à la réduction modulo](https://lemire.me/blog/2016/06/27/a-fast-alternative-to-the-modulo-reduction/)


## Licence

Sous licence soit

 * Licence Apache, Version 2.0
   ([LICENSE-APACHE](LICENSE-APACHE) ou http://www.apache.org/licenses/LICENSE-2.0)
 * Licence MIT
   ([LICENSE-MIT](LICENSE-MIT) ou http://opensource.org/licenses/MIT)

à votre choix.

## Contribution

Sauf indication explicite contraire de votre part, toute contribution soumise
intentionnellement pour inclusion dans l’œuvre par vous, telle que définie dans la licence Apache-2.0, sera
doublement licenciée comme ci-dessus, sans conditions ou termes supplémentaires.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-15

---