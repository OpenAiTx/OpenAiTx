
<div align="right">
  <details>
    <summary >🌐 Taal</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=en">Engels</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=fr">Frans</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=de">Duits</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=es">Spaans</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=it">Italiaans</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=pt">Portugees</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=pl">Pools</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=tr">Turks</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=vi">Vietnamees</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=id">Indonesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

## Wat is het?

[![CI](https://github.com/dronnix/bwarr/actions/workflows/ci.yml/badge.svg)](https://github.com/dronnix/bwarr/actions)
[![codecov](https://codecov.io/gh/dronnix/bwarr/branch/main/graph/badge.svg)](https://codecov.io/gh/dronnix/bwarr)
[![Go Reference](https://pkg.go.dev/badge/github.com/dronnix/bwarr.svg)](https://pkg.go.dev/github.com/dronnix/bwarr)
[![Go Report Card](https://goreportcard.com/badge/github.com/dronnix/bwarr)](https://goreportcard.com/report/github.com/dronnix/bwarr)

De Black-White Array (ook wel BWArr genoemd) is een snelle, geordende datastructuur gebaseerd op arrays met ***$O(\log N)$*** **geheugenallocaties**.

## Datastructuur
Het concept van Black-White Array werd uitgevonden en gepubliceerd door professor [Z. George Mou](https://www.cs.brandeis.edu/~mou/) in [Black-White Array: A New Data Structure for
Dynamic Data Sets](https://arxiv.org/abs/2004.09051). Deze repository bevat de eerste publieke implementatie.

![Professor Z. George Mou](https://www.cs.brandeis.edu/~mou/mou.gif)

### Belangrijkste kenmerken:
- $O(\log N)$ geheugentoewijzingen voor Inserts - geen druk op GC;
- Snelle insert-, delete- en zoekoperaties $O(\log N)$ tijdscomplexiteit gemiddeld;
- Array-gebaseerd en pointerloos maakt het CPU-vriendelijk: cachelocaliteit / sequentiële iteratie / etc;
- Ondersteunt dubbele elementen van nature (multiset-gedrag) - geen noodzaak om waarden in structs te wikkelen om ze uniek te maken;
- Direct te vervangen voor `github.com/google/btree` en `github.com/petar/GoLLRB`;
- Lage geheugenkosten - geen pointers per element, compacte geheugenrepresentatie;
- Eenvoudig te serialiseren;

### Afwegingen
- Eén per $N$ insert-operaties valt de complexiteit terug naar $O(N)$, hoewel gemiddeld $O(\log N)$ blijft. Voor real-time systemen kan dit latentiepieken veroorzaken bij collecties met miljoenen elementen. Kan worden beperkt door async/background inserts.
- Voor een klein aantal elementen kunnen `Search()/Delete()` operaties $O((\log N)^2)$ kosten. 50% van de elementen kosten $O(\log N)$ tijd, 75%  - $O(2\log N)$, 87,5% - $O(3\log N)$, enz.
- Bij het verwijderen van lange reeksen elementen kan een `Max()/Min()` operatie $O(N/4)$ kosten. Gemiddelde complexiteit voor reeksen aanroepen blijft $O(\log N)$.
- Bij het verwijderen van lange reeksen elementen kan een iteratiestap $O(N/4)$ kosten. Gemiddelde complexiteit voor iteratie over de hele collectie blijft $O(\log N)$ per element.

### Gebruikssituatie
In-memory collecties met een lees-schrijfverhouding van 1:1 < r:w < 10:1. BWArr is geoptimaliseerd voor zware inserties en verwijderingen (met weinig toewijzingen en fragmentatie), terwijl het toch snelle zoek- en iteratie biedt.

###  Benchmarks

Benchmarks in vergelijking met [Google BTree](https://github.com/google/btree).

#### Insert 
Meet de tijd, allocaties en toegewezen KBs om N unieke willekeurige int64 waarden in een lege datastructuur te plaatsen. Zowel BWArr als BTree starten leeg en voegen alle waarden één voor één toe.

![Insert prestaties](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_unique_values.png?raw=true)
![Insert Allocs](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_unique_values_allocs.png?raw=true)
![Insert Alloc_Bytes](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_unique_values_bytes.png?raw=true)

Allocaties bij kleinere waarden: 

![Insert Allocs klein](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_performance_allocs_detailed.png?raw=true)


#### Ophalen
Meet de tijd die nodig is om N waarden op te zoeken via hun sleutels in een vooraf gevulde datastructuur. De datastructuur wordt gevuld met alle waarden voordat de timing begint, daarna wordt elke waarde opgehaald via de sleutel.

![Ophalen prestatie](https://github.com/dronnix/bwarr-bench/blob/main/images/get_all_values_by_key.png?raw=true)

#### Itereren
Meet de tijd om door alle N waarden te itereren in gesorteerde en niet-gesorteerde volgorde.
![Prestatie gesorteerd itereren](https://github.com/dronnix/bwarr-bench/blob/main/images/ordered_iteration_over_all_values.png?raw=true)
![Prestatie ongesorteerd itereren](https://github.com/dronnix/bwarr-bench/blob/main/images/unordered_iteration_over_all_values.png?raw=true)

#### Meer benchmarks
Aanvullende benchmarks en details zijn beschikbaar in de [bwarr-bench](https://github.com/dronnix/bwarr-bench) repository.
Er zullen meer methoden worden toegevoegd, verwacht ook aparte benchmarks voor AMD64 en ARM64 architecturen.

## Installatie

Vereist Go 1.22 of hoger.

```bash
go get github.com/dronnix/bwarr
```
  
Importeer het vervolgens in je code:

```go
import "github.com/dronnix/bwarr"
```

## Gebruik

### Basisvoorbeeld

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