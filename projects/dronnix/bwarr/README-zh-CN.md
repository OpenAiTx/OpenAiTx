## 它是什么？

[![CI](https://github.com/dronnix/bwarr/actions/workflows/ci.yml/badge.svg)](https://github.com/dronnix/bwarr/actions)
[![codecov](https://codecov.io/gh/dronnix/bwarr/branch/main/graph/badge.svg)](https://codecov.io/gh/dronnix/bwarr)
[![Go Reference](https://pkg.go.dev/badge/github.com/dronnix/bwarr.svg)](https://pkg.go.dev/github.com/dronnix/bwarr)
[![Go Report Card](https://goreportcard.com/badge/github.com/dronnix/bwarr)](https://goreportcard.com/report/github.com/dronnix/bwarr)

黑白数组（又名 BWArr）是一种基于数组的快速有序数据结构，具有***$O(\log N)$*** **内存分配**。

## 数据结构
黑白数组的思想由教授 [Z. George Mou](https://www.cs.brandeis.edu/~mou/) 在论文 [Black-White Array: A New Data Structure for
Dynamic Data Sets](https://arxiv.org/abs/2004.09051) 中提出并发表。本仓库包含首个公开实现。

![Z. George Mou 教授](https://www.cs.brandeis.edu/~mou/mou.gif)

### 主要特性：
- 插入操作的内存分配为 $O(\log N)$ - 不会对 GC 造成压力；
- 快速的插入、删除和搜索操作，摊销时间复杂度为 $O(\log N)$；
- 基于数组且无指针，CPU 友好：缓存局部性 / 顺序迭代 / 等；
- 原生支持重复元素（多重集合行为） - 无需将值封装到结构体中以保证唯一性；
- 可替代 `github.com/google/btree` 和 `github.com/petar/GoLLRB`；
- 低内存开销 - 每个元素无指针，内存表示紧凑；
- 易于序列化；

### 权衡
- 每 $N$ 次插入操作中，有一次复杂度降至 $O(N)$，但摊销后仍为 $O(\log N)$。对于实时系统，百万级元素集合可能会出现延迟峰值。可通过异步/后台插入缓解。
- 元素数量较少时，`Search()/Delete()` 操作可能达到 $O((\log N)^2)$。50% 的元素耗时为 $O(\log N)$，75% 为 $O(2\log N)$，87.5% 为 $O(3\log N)$，以此类推。
- 删除大量元素时，`Max()/Min()` 操作可能耗时 $O(N/4)$。连续调用的摊销复杂度仍为 $O(\log N)$。
- 删除大量元素时，迭代步骤可能耗时 $O(N/4)$。遍历整个集合的摊销复杂度仍为每元素 $O(\log N)$。

### 基准测试

与 [Google BTree](https://github.com/google/btree) 的基准比较。

#### 插入
测量向空数据结构插入 N 个唯一随机 int64 值时的时间、分配次数和分配字节数。BWArr 和 BTree 均从空开始，逐个插入所有值。

![插入性能](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_unique_values.png?raw=true)
![插入分配次数](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_unique_values_allocs.png?raw=true)
![插入分配字节数](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_unique_values_bytes.png?raw=true)
较小值的分配：

![插入分配小图](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_performance_allocs_detailed.png?raw=true)


#### 查询
测量在预先填充的数据结构中通过键查找 N 个值所需的时间。数据结构在计时开始前已填充所有值，然后通过键检索每个值。

![查询性能](https://github.com/dronnix/bwarr-bench/blob/main/images/get_all_values_by_key.png?raw=true)

#### 迭代
测量按排序和未排序顺序迭代所有 N 个值所需的时间。
![有序迭代性能](https://github.com/dronnix/bwarr-bench/blob/main/images/ordered_iteration_over_all_values.png?raw=true)
![无序迭代性能](https://github.com/dronnix/bwarr-bench/blob/main/images/unordered_iteration_over_all_values.png?raw=true)

#### 更多基准测试
更多基准测试和详细信息可在 [bwarr-bench](https://github.com/dronnix/bwarr-bench) 仓库中获取。
将添加更多方法，同时也将提供针对 AMD64 和 ARM64 架构的单独基准测试。

## 安装

需要 Go 1.22 或更高版本。


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