## What is it?

[![CI](https://github.com/dronnix/bwarr/actions/workflows/ci.yml/badge.svg)](https://github.com/dronnix/bwarr/actions)
[![codecov](https://codecov.io/gh/dronnix/bwarr/branch/main/graph/badge.svg)](https://codecov.io/gh/dronnix/bwarr)
[![Go Reference](https://pkg.go.dev/badge/github.com/dronnix/bwarr.svg)](https://pkg.go.dev/github.com/dronnix/bwarr)
[![Go Report Card](https://goreportcard.com/badge/github.com/dronnix/bwarr)](https://goreportcard.com/report/github.com/dronnix/bwarr)

The Black-White Array (aka BWArr) is a fast, ordered data structure based on arrays with ***$O(\log N)$*** **memory allocations**.

## Data Structure
The idea of Black-White Array was invented and published by professor [Z. George Mou](https://www.cs.brandeis.edu/~mou/) in [Black-White Array: A New Data Structure for
Dynamic Data Sets](https://arxiv.org/abs/2004.09051). This repository contains the first public implementation.

![Professor Z. George Mou](https://www.cs.brandeis.edu/~mou/mou.gif)

### Key features:
- $O(\log N)$ memory allocations for Inserts - no pressure on GC;
- Fast insert, delete, and search operations $O(\log N)$ time amortized complexity;
- Array-based and pointerless makes it CPU-friendly: cache locality / sequential iteration / etc;
- Supports duplicate elements natively (multiset behavior) - no need for wrapping values into structs to make them unique;
- Drop-in replacement for `github.com/google/btree` and `github.com/petar/GoLLRB`;
- Low memory overhead - no pointers per element, compact memory representation;
- Easily serializable;

### Tradeoffs
- One per $N$ insert operations complexity falls down to $O(N)$, though amortized remains $O(\log N)$. For real-time systems, it may introduce latency spikes for collections with millions of elements. Could be mitigated by async/background inserts.
- For a small number of elements `Search()/Delete()` operations may take $O((\log N)^2)$. 50% of elements take $O(\log N)$ time, 75%  - $O(2\log N)$, 87.5% - $O(3\log N)$, etc.
- When deleting long series of elements, a `Max()/Min()` operation can take $O(N/4)$. Amortized complexity for series of calls remains $O(\log N)$.
- When deleting long series of elements, iteration step can take $O(N/4)$. Amortized complexity for iteration over the whole collection remains $O(\log N)$ per element.

###  Benchmarks

Benchmarks in comparison with [Google BTree](https://github.com/google/btree).

#### Insert 
Measures the time, allocs and allocated KBs to insert N unique random int64 values into an empty data structure. Both BWArr and BTree start empty and insert all values one by one.

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


