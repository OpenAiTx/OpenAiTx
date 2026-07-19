
<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
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

## Was ist das?

[![CI](https://github.com/dronnix/bwarr/actions/workflows/ci.yml/badge.svg)](https://github.com/dronnix/bwarr/actions)
[![codecov](https://codecov.io/gh/dronnix/bwarr/branch/main/graph/badge.svg)](https://codecov.io/gh/dronnix/bwarr)
[![Go Reference](https://pkg.go.dev/badge/github.com/dronnix/bwarr.svg)](https://pkg.go.dev/github.com/dronnix/bwarr)
[![Go Report Card](https://goreportcard.com/badge/github.com/dronnix/bwarr)](https://goreportcard.com/report/github.com/dronnix/bwarr)

Das Black-White Array (auch BWArr genannt) ist eine schnelle, geordnete Datenstruktur, die auf Arrays basiert und ***$O(\log N)$*** **Speicherzuweisungen** benötigt.

## Datenstruktur
Die Idee des Black-White Arrays wurde von Professor [Z. George Mou](https://www.cs.brandeis.edu/~mou/) in [Black-White Array: A New Data Structure for Dynamic Data Sets](https://arxiv.org/abs/2004.09051) erfunden und veröffentlicht. Dieses Repository enthält die erste öffentliche Implementierung.

![Professor Z. George Mou](https://www.cs.brandeis.edu/~mou/mou.gif)

### Hauptmerkmale:
- $O(\log N)$ Speicherallokationen für Einfügungen – keine Belastung für den GC;
- Schnelle Einfüge-, Lösch- und Suchoperationen mit $O(\log N)$ amortisierter Laufzeit;
- Array-basiert und ohne Zeiger, dadurch CPU-freundlich: Cache-Lokalität / sequentielle Iteration / usw.;
- Unterstützt doppelte Elemente nativ (Multiset-Verhalten) – keine Notwendigkeit, Werte in Strukturen zu verpacken, um sie eindeutig zu machen;
- Drop-in-Ersatz für `github.com/google/btree` und `github.com/petar/GoLLRB`;
- Geringer Speicheraufwand – keine Zeiger pro Element, kompakte Speicherrepräsentation;
- Einfach serialisierbar;

### Kompromisse
- Bei jeder $N$-ten Einfügung sinkt die Komplexität auf $O(N)$, bleibt aber amortisiert bei $O(\log N)$. Für Echtzeitsysteme kann dies bei Sammlungen mit Millionen von Elementen zu Latenzspitzen führen. Kann durch asynchrone/hintergrundbasierte Einfügungen abgemildert werden.
- Bei einer kleinen Anzahl von Elementen können `Search()/Delete()`-Operationen $O((\log N)^2)$ benötigen. 50% der Elemente brauchen $O(\log N)$ Zeit, 75% – $O(2\log N)$, 87,5% – $O(3\log N)$, usw.
- Beim Löschen langer Serien von Elementen kann eine `Max()/Min()`-Operation $O(N/4)$ benötigen. Die amortisierte Komplexität für Serien von Aufrufen bleibt bei $O(\log N)$.
- Beim Löschen langer Serien von Elementen kann ein Iterationsschritt $O(N/4)$ benötigen. Die amortisierte Komplexität für die Iteration über die gesamte Sammlung bleibt bei $O(\log N)$ pro Element.

### Anwendungsfall
In-Memory-Sammlungen mit einem Lese-Schreib-Verhältnis von 1:1 < r:w < 10:1. BWArr ist für umfangreiche Einfügungen und Löschungen optimiert (mit wenig Allokationen und Fragmentierung), bietet aber trotzdem schnelle Suche und Iteration.

###  Benchmarks

Benchmarks im Vergleich mit [Google BTree](https://github.com/google/btree).

#### Einfügen 
Misst die Zeit, Allokationen und allokierten KBs, um N eindeutige zufällige int64-Werte in eine leere Datenstruktur einzufügen. Sowohl BWArr als auch BTree starten leer und fügen alle Werte nacheinander ein.

![Insert performance](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_unique_values.png?raw=true)
![Insert Allocs](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_unique_values_allocs.png?raw=true)
![Insert Alloc_Bytes](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_unique_values_bytes.png?raw=true)

Allokationen bei kleineren Werten: 

![Insert Allocs small](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_performance_allocs_detailed.png?raw=true)



#### Get 
Misst die Zeit, um N Werte anhand ihrer Schlüssel in einer vorab gefüllten Datenstruktur nachzuschlagen. Die Datenstruktur wird mit allen Werten befüllt, bevor die Zeitmessung beginnt, danach wird jeder Wert anhand des Schlüssels abgerufen.

![Get performance](https://github.com/dronnix/bwarr-bench/blob/main/images/get_all_values_by_key.png?raw=true)

#### Iterate
Misst die Zeit, um alle N Werte in sortierter und nicht sortierter Reihenfolge zu durchlaufen.
![Ordered Iterate performance](https://github.com/dronnix/bwarr-bench/blob/main/images/ordered_iteration_over_all_values.png?raw=true)
![Unordered Iterate performance](https://github.com/dronnix/bwarr-bench/blob/main/images/unordered_iteration_over_all_values.png?raw=true)

#### Weitere Benchmarks
Zusätzliche Benchmarks und Details sind im [bwarr-bench](https://github.com/dronnix/bwarr-bench) Repository verfügbar.
Weitere Methoden werden hinzugefügt, außerdem werden separate Benchmarks für AMD64- und ARM64-Architekturen erwartet.

## Installation

Erfordert Go 1.22 oder höher.

```bash
go get github.com/dronnix/bwarr
```

Dann importieren Sie in Ihrem Code:

```go
import "github.com/dronnix/bwarr"
```

## Verwendung

### Einfaches Beispiel

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