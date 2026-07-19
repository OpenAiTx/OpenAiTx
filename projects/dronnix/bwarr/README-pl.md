
<div align="right">
  <details>
    <summary >🌐 Język</summary>
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

## Co to jest?

[![CI](https://github.com/dronnix/bwarr/actions/workflows/ci.yml/badge.svg)](https://github.com/dronnix/bwarr/actions)
[![codecov](https://codecov.io/gh/dronnix/bwarr/branch/main/graph/badge.svg)](https://codecov.io/gh/dronnix/bwarr)
[![Go Reference](https://pkg.go.dev/badge/github.com/dronnix/bwarr.svg)](https://pkg.go.dev/github.com/dronnix/bwarr)
[![Go Report Card](https://goreportcard.com/badge/github.com/dronnix/bwarr)](https://goreportcard.com/report/github.com/dronnix/bwarr)

Black-White Array (znana również jako BWArr) to szybka, uporządkowana struktura danych oparta na tablicach z ***$O(\log N)$*** **alokacjami pamięci**.

## Struktura danych
Koncepcja Black-White Array została opracowana i opublikowana przez profesora [Z. George Mou](https://www.cs.brandeis.edu/~mou/) w artykule [Black-White Array: A New Data Structure for Dynamic Data Sets](https://arxiv.org/abs/2004.09051). To repozytorium zawiera pierwszą publiczną implementację.

![Profesor Z. George Mou](https://www.cs.brandeis.edu/~mou/mou.gif)

### Kluczowe cechy:
- $O(\log N)$ alokacji pamięci przy wstawieniach - brak obciążenia dla GC;
- Szybkie operacje wstawiania, usuwania i wyszukiwania z $O(\log N)$ złożonością czasową amortyzowaną;
- Struktura oparta o tablicę i bez wskaźników, przyjazna dla CPU: lokalność pamięci podręcznej / sekwencyjna iteracja / itp.;
- Wspiera natywnie duplikaty elementów (zachowanie multiset) - nie trzeba opakowywać wartości w struktury dla zapewnienia unikalności;
- Może zastąpić `github.com/google/btree` oraz `github.com/petar/GoLLRB`;
- Niski narzut pamięci - brak wskaźników na element, kompaktowa reprezentacja pamięci;
- Łatwo serializowalna;

### Kompromisy
- Raz na $N$ operacji wstawiania złożoność spada do $O(N)$, choć amortyzowana pozostaje $O(\log N)$. Dla systemów czasu rzeczywistego może powodować opóźnienia przy kolekcjach z milionami elementów. Można łagodzić przez asynchroniczne/w tle wstawienia.
- Dla niewielkiej liczby elementów operacje `Search()/Delete()` mogą zajmować $O((\log N)^2)$. 50% elementów wymaga $O(\log N)$ czasu, 75%  - $O(2\log N)$, 87.5% - $O(3\log N)$, itd.
- Przy usuwaniu długich serii elementów operacja `Max()/Min()` może trwać $O(N/4)$. Złożoność amortyzowana dla serii wywołań pozostaje $O(\log N)$.
- Przy usuwaniu długich serii elementów krok iteracji może trwać $O(N/4)$. Złożoność amortyzowana dla iteracji przez całą kolekcję pozostaje $O(\log N)$ na element.

### Zastosowanie
Kolekcje w pamięci operacyjnej z proporcją odczyt-zapis 1:1 < r:w < 10:1. BWArr jest zoptymalizowany pod duże liczby wstawień i usunięć (przy niskiej liczbie alokacji i fragmentacji), zapewniając jednocześnie szybkie wyszukiwanie i iterację.

###  Benchmarki

Benchmarki w porównaniu z [Google BTree](https://github.com/google/btree).

#### Wstawianie 
Mierzy czas, liczbę alokacji i KB alokowane do wstawienia N unikalnych losowych wartości int64 do pustej struktury danych. Zarówno BWArr jak i BTree zaczynają puste i wstawiają wszystkie wartości po kolei.

![Wydajność wstawiania](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_unique_values.png?raw=true)
![Wstawianie Allocs](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_unique_values_allocs.png?raw=true)
![Wstawianie Alloc_Bytes](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_unique_values_bytes.png?raw=true)

Alokacje dla mniejszych wartości: 

![Wstawianie Allocs małe](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_performance_allocs_detailed.png?raw=true)



#### Pobieranie (Get)
Mierzy czas wyszukiwania N wartości według ich kluczy w uprzednio wypełnionej strukturze danych. Struktura danych jest wypełniana wszystkimi wartościami przed rozpoczęciem pomiaru czasu, a następnie każda wartość jest pobierana po kluczu.

![Wydajność pobierania](https://github.com/dronnix/bwarr-bench/blob/main/images/get_all_values_by_key.png?raw=true)

#### Iteracja
Mierzy czas iteracji przez wszystkie N wartości w porządku posortowanym i nieposortowanym.
![Wydajność iteracji uporządkowanej](https://github.com/dronnix/bwarr-bench/blob/main/images/ordered_iteration_over_all_values.png?raw=true)
![Wydajność iteracji nieuporządkowanej](https://github.com/dronnix/bwarr-bench/blob/main/images/unordered_iteration_over_all_values.png?raw=true)

#### Więcej benchmarków
Dodatkowe benchmarki i szczegóły dostępne są w repozytorium [bwarr-bench](https://github.com/dronnix/bwarr-bench).
Będą dodawane kolejne metody, a także osobne benchmarki dla architektur AMD64 i ARM64.

## Instalacja

Wymaga Go w wersji 1.22 lub wyższej.

```bash
go get github.com/dronnix/bwarr
```

Następnie zaimportuj w swoim kodzie:

```go
import "github.com/dronnix/bwarr"
```

## Użytkowanie

### Podstawowy przykład

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