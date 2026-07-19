
<div align="right">
  <details>
    <summary >🌐 Langue</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

## Qu'est-ce que c'est ?

[![CI](https://github.com/dronnix/bwarr/actions/workflows/ci.yml/badge.svg)](https://github.com/dronnix/bwarr/actions)
[![codecov](https://codecov.io/gh/dronnix/bwarr/branch/main/graph/badge.svg)](https://codecov.io/gh/dronnix/bwarr)
[![Go Reference](https://pkg.go.dev/badge/github.com/dronnix/bwarr.svg)](https://pkg.go.dev/github.com/dronnix/bwarr)
[![Go Report Card](https://goreportcard.com/badge/github.com/dronnix/bwarr)](https://goreportcard.com/report/github.com/dronnix/bwarr)

Le Black-White Array (ou BWArr) est une structure de données rapide et ordonnée basée sur des tableaux avec ***$O(\log N)$*** **allocations mémoire**.

## Structure de données
L’idée du tableau Black-White a été inventée et publiée par le professeur [Z. George Mou](https://www.cs.brandeis.edu/~mou/) dans [Black-White Array: A New Data Structure for Dynamic Data Sets](https://arxiv.org/abs/2004.09051). Ce dépôt contient la première implémentation publique.

![Professeur Z. George Mou](https://www.cs.brandeis.edu/~mou/mou.gif)

### Principales caractéristiques :
- $O(\log N)$ allocations mémoire pour les insertions - aucune pression sur le GC ;
- Opérations rapides d’insertion, suppression et recherche avec une complexité amortie de $O(\log N)$ ;
- Basé sur un tableau et sans pointeur, ce qui le rend adapté au CPU : localité du cache / itération séquentielle / etc ;
- Prise en charge native des éléments dupliqués (comportement multiset) - inutile d’envelopper les valeurs dans des structures pour les rendre uniques ;
- Remplacement direct pour `github.com/google/btree` et `github.com/petar/GoLLRB` ;
- Faible surcharge mémoire - pas de pointeurs par élément, représentation mémoire compacte ;
- Facilement sérialisable ;

### Compromis
- Une fois tous les $N$ insertions, la complexité tombe à $O(N)$, mais l’amortie reste à $O(\log N)$. Pour les systèmes temps réel, cela peut provoquer des pics de latence pour les collections contenant des millions d’éléments. Peut être atténué par des insertions asynchrones/en arrière-plan.
- Pour un petit nombre d’éléments, les opérations `Search()/Delete()` peuvent prendre $O((\log N)^2)$. 50% des éléments prennent $O(\log N)$, 75%  - $O(2\log N)$, 87.5% - $O(3\log N)$, etc.
- Lors de la suppression de longues séries d’éléments, une opération `Max()/Min()` peut prendre $O(N/4)$. La complexité amortie pour une série d’appels reste à $O(\log N)$.
- Lors de la suppression de longues séries d’éléments, une étape d’itération peut prendre $O(N/4)$. La complexité amortie pour l’itération sur toute la collection reste à $O(\log N)$ par élément.

### Cas d’utilisation
Collections en mémoire avec un ratio lecture-écriture 1:1 < r:w < 10:1. BWArr est optimisé pour les insertions et suppressions massives (faibles allocations et fragmentation), tout en offrant une recherche et une itération rapides.

###  Benchmarks

Benchmarks en comparaison avec [Google BTree](https://github.com/google/btree).

#### Insertion
Mesure le temps, les allocations et les KB alloués pour insérer N valeurs int64 uniques et aléatoires dans une structure de données vide. BWArr et BTree commencent tous deux vides et insèrent toutes les valeurs une à une.

![Performance d’insertion](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_unique_values.png?raw=true)
![Allocations d’insertion](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_unique_values_allocs.png?raw=true)
![Bytes alloués lors de l’insertion](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_unique_values_bytes.png?raw=true)

Allocations sur de petites valeurs :

![Allocations d’insertion petites](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_performance_allocs_detailed.png?raw=true)



#### Get 
Mesure le temps nécessaire pour rechercher N valeurs par leurs clés dans une structure de données pré-remplie. La structure de données est remplie avec toutes les valeurs avant le début du chronométrage, puis chaque valeur est récupérée par sa clé.

![Performance Get](https://github.com/dronnix/bwarr-bench/blob/main/images/get_all_values_by_key.png?raw=true)

#### Itération
Mesure le temps nécessaire pour itérer sur les N valeurs, dans un ordre trié et non trié.
![Performance d’itération ordonnée](https://github.com/dronnix/bwarr-bench/blob/main/images/ordered_iteration_over_all_values.png?raw=true)
![Performance d’itération non ordonnée](https://github.com/dronnix/bwarr-bench/blob/main/images/unordered_iteration_over_all_values.png?raw=true)

#### Autres benchmarks
Des benchmarks supplémentaires et des détails sont disponibles dans le dépôt [bwarr-bench](https://github.com/dronnix/bwarr-bench).
D’autres méthodes seront ajoutées, des benchmarks séparés pour les architectures AMD64 et ARM64 sont également prévus.

## Installation

Requiert Go 1.22 ou version supérieure.

```bash
go get github.com/dronnix/bwarr
```

Puis importez dans votre code :

```go
import "github.com/dronnix/bwarr"
```

## Utilisation

### Exemple de base

```go
package main

import (
    "cmp"
    "fmt"

    "github.com/dronnix/bwarr"
)

func main() {
    // Create a BWArr with an integer comparison function
    // The second parameter (10) is the initial capacity hint
    bwa := bwarr.New(func(a, b int64) int {
        return cmp.Compare(a, b)
    }, 10)

    // Insert elements
    bwa.Insert(42)
    bwa.Insert(17)
    bwa.Insert(99)
    bwa.Insert(23)
    bwa.Insert(8)

    fmt.Printf("Length: %d\n", bwa.Len()) // Output: Length: 5

    // Get an element
    val, found := bwa.Get(42)
    if found {
        fmt.Printf("Found: %d\n", val) // Output: Found: 42
    }

    // Delete an element
    deleted, found := bwa.Delete(17)
    if found {
        fmt.Printf("Deleted: %d\n", deleted) // Output: Deleted: 17
    }

    // Iterate in ascending order
    fmt.Println("Elements in sorted order:")
    bwa.Ascend(func(item int64) bool {
        fmt.Printf("  %d\n", item)
        return true // return false to stop iteration early
    })
    // Output:
    //   8
    //   23
    //   42
    //   99
}
```




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-19

---