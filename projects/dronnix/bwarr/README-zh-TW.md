
<div align="right">
  <details>
    <summary >🌐 語言</summary>
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

## 這是什麼？

[![CI](https://github.com/dronnix/bwarr/actions/workflows/ci.yml/badge.svg)](https://github.com/dronnix/bwarr/actions)
[![codecov](https://codecov.io/gh/dronnix/bwarr/branch/main/graph/badge.svg)](https://codecov.io/gh/dronnix/bwarr)
[![Go Reference](https://pkg.go.dev/badge/github.com/dronnix/bwarr.svg)](https://pkg.go.dev/github.com/dronnix/bwarr)
[![Go Report Card](https://goreportcard.com/badge/github.com/dronnix/bwarr)](https://goreportcard.com/report/github.com/dronnix/bwarr)

Black-White Array（簡稱 BWArr）是一種快速、有序的資料結構，基於陣列，具有 ***$O(\log N)$*** **記憶體分配** 的特性。
## 資料結構
黑白陣列（Black-White Array）的概念由教授 [Z. George Mou](https://www.cs.brandeis.edu/~mou/) 在 [Black-White Array: A New Data Structure for Dynamic Data Sets](https://arxiv.org/abs/2004.09051) 發明並發表。此存儲庫包含首個公開實作。

![Professor Z. George Mou](https://www.cs.brandeis.edu/~mou/mou.gif)

### 主要特點：
- 插入操作僅需 $O(\log N)$ 次記憶體配置——對垃圾回收無壓力；
- 快速插入、刪除和查詢操作，時間均攤複雜度為 $O(\log N)$；
- 基於陣列且無指標，CPU 友好：快取區域性／順序迭代／等；
- 原生支援重複元素（多重集合行為）——無需將值包裝成結構以使其唯一；
- 可直接取代 `github.com/google/btree` 和 `github.com/petar/GoLLRB`；
- 低記憶體負擔——每個元素無指標，記憶體表現緊湊；
- 易於序列化；

### 折衷方案
- 每 $N$ 次插入操作中，有一次複雜度會降至 $O(N)$，但均攤仍為 $O(\log N)$。對即時系統而言，對數百萬元素集合可能引入延遲尖峰。可透過非同步／背景插入來緩解。
- 元素數量少時 `Search()/Delete()` 操作可能需要 $O((\log N)^2)$。50% 元素需 $O(\log N)$ 時間，75% - $O(2\log N)$，87.5% - $O(3\log N)$，依此類推。
- 當刪除長串元素時，`Max()/Min()` 操作可能需 $O(N/4)$。多次呼叫的均攤複雜度維持 $O(\log N)$。
- 當刪除長串元素時，迭代步驟可能需 $O(N/4)$。整體集合迭代的均攤複雜度維持每個元素 $O(\log N)$。

### 使用案例
記憶體內集合，讀寫比介於 1:1 < r:w < 10:1。BWArr 對大量插入與刪除進行最佳化（低配置與碎片化），同時提供快速查詢與迭代。

### 基準測試

與 [Google BTree](https://github.com/google/btree) 的基準測試比較。

#### 插入 
測量將 N 個唯一隨機 int64 值插入空資料結構所需的時間、配置次數及配置 KB。BWArr 和 BTree 均從空集合開始，一次插入所有值。

![Insert performance](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_unique_values.png?raw=true)
![Insert Allocs](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_unique_values_allocs.png?raw=true)
![Insert Alloc_Bytes](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_unique_values_bytes.png?raw=true)

少量值的配置：

![Insert Allocs small](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_performance_allocs_detailed.png?raw=true)




#### 取得
衡量在預先填充的資料結構中，根據鍵查找 N 個值所需的時間。資料結構在計時開始前已填充所有值，然後每個值都依鍵來取得。

![取得效能](https://github.com/dronnix/bwarr-bench/blob/main/images/get_all_values_by_key.png?raw=true)

#### 遍歷
衡量以排序與未排序方式遍歷所有 N 個值所需的時間。
![排序遍歷效能](https://github.com/dronnix/bwarr-bench/blob/main/images/ordered_iteration_over_all_values.png?raw=true)
![未排序遍歷效能](https://github.com/dronnix/bwarr-bench/blob/main/images/unordered_iteration_over_all_values.png?raw=true)

#### 更多效能測試
更多效能測試與細節可在 [bwarr-bench](https://github.com/dronnix/bwarr-bench) 儲存庫中取得。
將會新增更多方法，並提供 AMD64 與 ARM64 架構的獨立效能測試。

## 安裝

需要 Go 1.22 或更高版本。

```bash
go get github.com/dronnix/bwarr
```

然後在您的程式碼中導入：

```go
import "github.com/dronnix/bwarr"
```

## 使用方式

### 基本範例

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