## Qu'est-ce que c'est ?

[![CI](https://github.com/dronnix/bwarr/actions/workflows/ci.yml/badge.svg)](https://github.com/dronnix/bwarr/actions)
[![codecov](https://codecov.io/gh/dronnix/bwarr/branch/main/graph/badge.svg)](https://codecov.io/gh/dronnix/bwarr)
[![Go Reference](https://pkg.go.dev/badge/github.com/dronnix/bwarr.svg)](https://pkg.go.dev/github.com/dronnix/bwarr)
[![Go Report Card](https://goreportcard.com/badge/github.com/dronnix/bwarr)](https://goreportcard.com/report/github.com/dronnix/bwarr)

Le Black-White Array (alias BWArr) est une structure de données ordonnée rapide basée sur des tableaux avec ***$O(\log N)$*** **allocations mémoire**.

## Structure de données
L'idée du Black-White Array a été inventée et publiée par le professeur [Z. George Mou](https://www.cs.brandeis.edu/~mou/) dans [Black-White Array: A New Data Structure for
Dynamic Data Sets](https://arxiv.org/abs/2004.09051). Ce dépôt contient la première implémentation publique.

![Professeur Z. George Mou](https://www.cs.brandeis.edu/~mou/mou.gif)

### Caractéristiques clés :
- $O(\log N)$ allocations mémoire pour les insertions - pas de pression sur le GC ;
- Opérations d'insertion, suppression et recherche rapides avec une complexité amortie en temps $O(\log N)$ ;
- Basé sur des tableaux et sans pointeurs, ce qui le rend adapté au CPU : localité du cache / itération séquentielle / etc ;
- Supporte nativement les éléments dupliqués (comportement multiset) - pas besoin d'encapsuler les valeurs dans des structures pour les rendre uniques ;
- Remplacement direct de `github.com/google/btree` et `github.com/petar/GoLLRB` ;
- Faible surcharge mémoire - pas de pointeurs par élément, représentation mémoire compacte ;
- Facilement sérialisable ;

### Compromis
- Une opération sur $N$ insertions peut atteindre une complexité de $O(N)$, bien que l'amortissement reste $O(\log N)$. Pour les systèmes temps réel, cela peut provoquer des pics de latence pour des collections de millions d’éléments. Peut être atténué par des insertions asynchrones/en arrière-plan.
- Pour un petit nombre d’éléments, les opérations `Search()/Delete()` peuvent prendre $O((\log N)^2)$. 50% des éléments prennent $O(\log N)$ temps, 75% - $O(2\log N)$, 87,5% - $O(3\log N)$, etc.
- Lors de la suppression de longues séries d’éléments, une opération `Max()/Min()` peut prendre $O(N/4)$. La complexité amortie pour une série d’appels reste $O(\log N)$.
- Lors de la suppression de longues séries d’éléments, une étape d’itération peut prendre $O(N/4)$. La complexité amortie pour l’itération sur toute la collection reste $O(\log N)$ par élément.

###  Benchmarks

Benchmarks en comparaison avec [Google BTree](https://github.com/google/btree).

#### Insertion 
Mesure du temps, des allocations et des KB alloués pour insérer N valeurs int64 uniques et aléatoires dans une structure de données vide. BWArr et BTree commencent vides et insèrent toutes les valeurs une par une.

![Performance d'insertion](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_unique_values.png?raw=true)
![Allocations d'insertion](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_unique_values_allocs.png?raw=true)
![Octets alloués à l'insertion](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_unique_values_bytes.png?raw=true)

Allocations sur de plus petites valeurs : 

![Insert Allocs small](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_performance_allocs_detailed.png?raw=true)


#### Get 
Mesure le temps nécessaire pour rechercher N valeurs par leurs clés dans une structure de données pré-remplie. La structure de données est remplie avec toutes les valeurs avant le début du chronométrage, puis chaque valeur est récupérée par clé.

![Get performance](https://github.com/dronnix/bwarr-bench/blob/main/images/get_all_values_by_key.png?raw=true)

#### Itérer
Mesure le temps nécessaire pour itérer à travers toutes les N valeurs dans des ordres triés et non triés.
![Ordered Iterate performance](https://github.com/dronnix/bwarr-bench/blob/main/images/ordered_iteration_over_all_values.png?raw=true)
![Unordered Iterate performance](https://github.com/dronnix/bwarr-bench/blob/main/images/unordered_iteration_over_all_values.png?raw=true)

#### Plus de benchmarks
Des benchmarks supplémentaires et des détails sont disponibles dans le dépôt [bwarr-bench](https://github.com/dronnix/bwarr-bench).
D’autres méthodes seront ajoutées, attendez-vous également à des benchmarks séparés pour les architectures AMD64 et ARM64.

## Installation

Nécessite Go 1.22 ou supérieur.

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
    "fmt"

    "github.com/dronnix/bwarr"
)

func main() {
    // Create a BWArr with an integer comparison function
    // The second parameter (10) is the initial capacity hint
    bwa := bwarr.New(func(a, b int64) int {
        return int(a - b)
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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-08

---