
<div align="right">
  <details>
    <summary >🌐 Lingua</summary>
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

## Che cos'è?

[![CI](https://github.com/dronnix/bwarr/actions/workflows/ci.yml/badge.svg)](https://github.com/dronnix/bwarr/actions)
[![codecov](https://codecov.io/gh/dronnix/bwarr/branch/main/graph/badge.svg)](https://codecov.io/gh/dronnix/bwarr)
[![Go Reference](https://pkg.go.dev/badge/github.com/dronnix/bwarr.svg)](https://pkg.go.dev/github.com/dronnix/bwarr)
[![Go Report Card](https://goreportcard.com/badge/github.com/dronnix/bwarr)](https://goreportcard.com/report/github.com/dronnix/bwarr)

La Black-White Array (nota anche come BWArr) è una struttura dati ordinata e veloce basata su array con ***$O(\log N)$*** **allocazioni di memoria**.

## Struttura Dati
L’idea del Black-White Array è stata inventata e pubblicata dal professor [Z. George Mou](https://www.cs.brandeis.edu/~mou/) in [Black-White Array: A New Data Structure for
Dynamic Data Sets](https://arxiv.org/abs/2004.09051). Questo repository contiene la prima implementazione pubblica.

![Professor Z. George Mou](https://www.cs.brandeis.edu/~mou/mou.gif)

### Caratteristiche principali:
- $O(\log N)$ allocazioni di memoria per gli inserimenti - nessuna pressione sul GC;
- Operazioni di inserimento, cancellazione e ricerca rapide con complessità temporale ammortizzata $O(\log N)$;
- Basato su array e senza puntatori, ideale per la CPU: località di cache / iterazione sequenziale / ecc;
- Supporta nativamente elementi duplicati (comportamento multiset) - non è necessario incapsulare i valori in struct per renderli unici;
- Sostituzione diretta per `github.com/google/btree` e `github.com/petar/GoLLRB`;
- Basso overhead di memoria - nessun puntatore per elemento, rappresentazione compatta;
- Facilmente serializzabile;

### Compromessi
- Una ogni $N$ operazioni di inserimento ha complessità $O(N)$, anche se l’ammortizzata rimane $O(\log N)$. Nei sistemi real-time può introdurre picchi di latenza per collezioni con milioni di elementi. Può essere mitigato con inserimenti asincroni/in background.
- Per un numero ridotto di elementi le operazioni `Search()/Delete()` possono richiedere $O((\log N)^2)$. Il 50% degli elementi richiede tempo $O(\log N)$, il 75%  - $O(2\log N)$, l’87,5% - $O(3\log N)$, ecc.
- Quando si cancellano lunghe serie di elementi, un’operazione `Max()/Min()` può richiedere $O(N/4)$. La complessità ammortizzata per serie di chiamate rimane $O(\log N)$.
- Quando si cancellano lunghe serie di elementi, il passo di iterazione può richiedere $O(N/4)$. La complessità ammortizzata per l’iterazione sull’intera collezione rimane $O(\log N)$ per elemento.

### Caso d’uso
Collezioni in memoria con rapporto lettura-scrittura 1:1 < r:w < 10:1. BWArr è ottimizzato per inserimenti e cancellazioni massicce (con basse allocazioni e frammentazione), garantendo comunque ricerca e iterazione rapide.

###  Benchmark

Benchmark in confronto con [Google BTree](https://github.com/google/btree).

#### Inserimento 
Misura il tempo, allocazioni e KB allocati per inserire N valori int64 unici e casuali in una struttura dati vuota. Sia BWArr che BTree partono vuoti e inseriscono tutti i valori uno per uno.

![Prestazioni inserimento](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_unique_values.png?raw=true)
![Inserimento allocazioni](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_unique_values_allocs.png?raw=true)
![Inserimento alloc_Bytes](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_unique_values_bytes.png?raw=true)

Allocazioni su valori più piccoli: 

![Inserimento allocazioni piccoli](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_performance_allocs_detailed.png?raw=true)


#### Get 
Misura il tempo necessario per cercare N valori tramite le loro chiavi in una struttura dati pre-popolata. La struttura dati viene popolata con tutti i valori prima dell'avvio della misurazione, quindi ogni valore viene recuperato tramite chiave.

![Prestazioni Get](https://github.com/dronnix/bwarr-bench/blob/main/images/get_all_values_by_key.png?raw=true)

#### Iterazione
Misura il tempo necessario per iterare su tutti i N valori in ordine ordinato e non ordinato.
![Prestazioni iterazione ordinata](https://github.com/dronnix/bwarr-bench/blob/main/images/ordered_iteration_over_all_values.png?raw=true)
![Prestazioni iterazione non ordinata](https://github.com/dronnix/bwarr-bench/blob/main/images/unordered_iteration_over_all_values.png?raw=true)

#### Ulteriori benchmark
Ulteriori benchmark e dettagli sono disponibili nel repository [bwarr-bench](https://github.com/dronnix/bwarr-bench).
Verranno aggiunti altri metodi, inoltre sono previsti benchmark separati per le architetture AMD64 e ARM64.

## Installazione

Richiede Go 1.22 o superiore.

```bash
go get github.com/dronnix/bwarr
```

Quindi importa nel tuo codice:

```go
import "github.com/dronnix/bwarr"
```

## Utilizzo

### Esempio di base

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