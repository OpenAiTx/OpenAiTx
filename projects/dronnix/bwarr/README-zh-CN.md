
<div align="right">
  <details>
    <summary >🌐 语言</summary>
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

## 这是什么？

[![CI](https://github.com/dronnix/bwarr/actions/workflows/ci.yml/badge.svg)](https://github.com/dronnix/bwarr/actions)
[![codecov](https://codecov.io/gh/dronnix/bwarr/branch/main/graph/badge.svg)](https://codecov.io/gh/dronnix/bwarr)
[![Go Reference](https://pkg.go.dev/badge/github.com/dronnix/bwarr.svg)](https://pkg.go.dev/github.com/dronnix/bwarr)
[![Go Report Card](https://goreportcard.com/badge/github.com/dronnix/bwarr)](https://goreportcard.com/report/github.com/dronnix/bwarr)

黑白数组（Black-White Array，简称 BWArr）是一种基于数组的快速有序数据结构，具有***$O(\log N)$*** **内存分配**的特性。

## 数据结构
黑白数组（Black-White Array）的概念由 [Z. George Mou](https://www.cs.brandeis.edu/~mou/) 教授发明并发表于 [Black-White Array: A New Data Structure for Dynamic Data Sets](https://arxiv.org/abs/2004.09051)。本仓库包含了首个公开实现。

![Z. George Mou 教授](https://www.cs.brandeis.edu/~mou/mou.gif)

### 主要特性：
- 插入操作只需 $O(\log N)$ 次内存分配，对 GC 压力小；
- 插入、删除和查找操作均摊时间复杂度为 $O(\log N)$，速度快；
- 基于数组且无指针，CPU 友好：缓存局部性好 / 顺序迭代 / 等等；
- 原生支持重复元素（多重集行为）— 无需将值包装为结构体以保证唯一性；
- 可直接替换 `github.com/google/btree` 和 `github.com/petar/GoLLRB`；
- 内存开销低—每个元素无指针，内存表示紧凑；
- 易于序列化；

### 权衡
- 每 $N$ 次插入操作中有一次复杂度降为 $O(N)$，但均摊仍为 $O(\log N)$。对于实时系统，数百万元素时可能引入延迟峰值。可通过异步或后台插入缓解。
- 对于元素较少的情况，`Search()/Delete()` 操作可能需 $O((\log N)^2)$。其中 50% 元素耗时 $O(\log N)$，75% - $O(2\log N)$，87.5% - $O(3\log N)$，以此类推。
- 删除长序列元素时，`Max()/Min()` 操作可能需 $O(N/4)$。连续调用的均摊复杂度仍为 $O(\log N)$。
- 删除长序列元素时，迭代步骤可能需 $O(N/4)$。对整个集合迭代的均摊复杂度仍为每个元素 $O(\log N)$。

### 使用场景
适用于内存中读写比 1:1 < r:w < 10:1 的集合。BWArr 针对大量插入与删除（低分配和低碎片）进行了优化，同时仍能保证快速的查找与迭代。

### 基准测试

与 [Google BTree](https://github.com/google/btree) 的基准性能对比。

#### 插入
测量将 N 个唯一随机 int64 值插入空数据结构所需的时间、分配次数及分配的 KB。BWArr 和 BTree 均从空开始，逐个插入所有值。

![插入性能](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_unique_values.png?raw=true)
![插入分配次数](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_unique_values_allocs.png?raw=true)
![插入分配字节数](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_unique_values_bytes.png?raw=true)

小规模数据分配情况：

![小规模插入分配](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_performance_allocs_detailed.png?raw=true)



#### Get
衡量在一个预先填充的数据结构中，通过键查找N个值所需的时间。数据结构在计时开始前已填充所有值，然后通过键检索每个值。

![Get性能](https://github.com/dronnix/bwarr-bench/blob/main/images/get_all_values_by_key.png?raw=true)

#### Iterate
衡量以排序和未排序方式遍历所有N个值所需的时间。
![有序遍历性能](https://github.com/dronnix/bwarr-bench/blob/main/images/ordered_iteration_over_all_values.png?raw=true)
![无序遍历性能](https://github.com/dronnix/bwarr-bench/blob/main/images/unordered_iteration_over_all_values.png?raw=true)

#### 更多基准测试
更多基准测试和详细信息可在 [bwarr-bench](https://github.com/dronnix/bwarr-bench) 仓库中获得。
将会添加更多方法，并且还会针对AMD64和ARM64架构提供独立的基准测试。

## 安装

需要Go 1.22或更高版本。

```bash
go get github.com/dronnix/bwarr
```
然后在你的代码中导入：


```go
import "github.com/dronnix/bwarr"
```

## 用法

### 基本示例

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