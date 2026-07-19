
<div align="right">
  <details>
    <summary >🌐 Language</summary>
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

## What is it?

[![CI](https://github.com/dronnix/bwarr/actions/workflows/ci.yml/badge.svg)](https://github.com/dronnix/bwarr/actions)
[![codecov](https://codecov.io/gh/dronnix/bwarr/branch/main/graph/badge.svg)](https://codecov.io/gh/dronnix/bwarr)
[![Go Reference](https://pkg.go.dev/badge/github.com/dronnix/bwarr.svg)](https://pkg.go.dev/github.com/dronnix/bwarr)
[![Go Report Card](https://goreportcard.com/badge/github.com/dronnix/bwarr)](https://goreportcard.com/report/github.com/dronnix/bwarr)

The Black-White Array (aka BWArr) is a fast, ordered data structure based on arrays with ***$O(\log N)$*** **memory allocations**.

## Data Structure
The concept of the Black-White Array was created and published by Professor [Z. George Mou](https://www.cs.brandeis.edu/~mou/) in [Black-White Array: A New Data Structure for Dynamic Data Sets](https://arxiv.org/abs/2004.09051). This repository presents the first public implementation.

![Professor Z. George Mou](https://www.cs.brandeis.edu/~mou/mou.gif)

### Key features:
- $O(\log N)$ memory allocations for Inserts - minimal pressure on GC;
- Fast insert, delete, and search operations with $O(\log N)$ amortized time complexity;
- Array-based and pointerless, making it CPU-friendly: cache locality / sequential iteration / etc;
- Natively supports duplicate elements (multiset behavior) - no need to wrap values in structs for uniqueness;
- Drop-in replacement for `github.com/google/btree` and `github.com/petar/GoLLRB`;
- Low memory overhead - no per-element pointers, compact memory representation;
- Easily serializable;

### Tradeoffs
- Once every $N$ insert operations, complexity drops to $O(N)$, though amortized stays at $O(\log N)$. For real-time systems, this may introduce latency spikes for collections with millions of elements. Can be alleviated by async/background inserts.
- For a small number of elements, `Search()/Delete()` operations may take $O((\log N)^2)$. 50% of elements take $O(\log N)$ time, 75% - $O(2\log N)$, 87.5% - $O(3\log N)$, etc.
- When deleting long series of elements, a `Max()/Min()` operation can take $O(N/4)$. The amortized complexity for a series of calls remains $O(\log N)$.
- When deleting long series of elements, the iteration step can take $O(N/4)$. Amortized complexity for iterating over the entire collection remains $O(\log N)$ per element.

### Use-case
In-memory collections with read-write ratio 1:1 < r:w < 10:1. BWArr is optimized for heavy insertions and deletions (with low allocations and fragmentation), while still offering fast search and iteration.

###  Benchmarks

Benchmarks compared with [Google BTree](https://github.com/google/btree).

#### Insert 
Measures the time, allocations, and allocated KBs to insert N unique random int64 values into an empty data structure. Both BWArr and BTree start empty and insert all values one by one.

![Insert performance](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_unique_values.png?raw=true)
![Insert Allocs](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_unique_values_allocs.png?raw=true)
![Insert Alloc_Bytes](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_unique_values_bytes.png?raw=true)

Allocations on smaller values: 

![Insert Allocs small](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_performance_allocs_detailed.png?raw=true)



#### Get 
Measures the time to look up N values by their keys in a pre-populated data structure. The data structure is populated with all values before timing starts, then each value is retrieved by key.

![Get performance](https://github.com/dronnix/bwarr-bench/blob/main/images/get_all_values_by_key.png?raw=true)

#### Iterate
Measures the time to iterate through all N values in sorted and non-sorted orders.
![Ordered Iterate performance](https://github.com/dronnix/bwarr-bench/blob/main/images/ordered_iteration_over_all_values.png?raw=true)
![Unordered Iterate performance](https://github.com/dronnix/bwarr-bench/blob/main/images/unordered_iteration_over_all_values.png?raw=true)

#### More benchmarks
Additional benchmarks and details are available in the [bwarr-bench](https://github.com/dronnix/bwarr-bench) repository.
More methods will be added, also expect separate benchmarks for AMD64 and ARM64 architectures.

## Installation

Requires Go 1.22 or higher.

```bash
go get github.com/dronnix/bwarr
```

Then import in your code:

```go
import "github.com/dronnix/bwarr"
```

## Usage

### Basic Example

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