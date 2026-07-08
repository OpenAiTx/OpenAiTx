## それは何ですか？

[![CI](https://github.com/dronnix/bwarr/actions/workflows/ci.yml/badge.svg)](https://github.com/dronnix/bwarr/actions)
[![codecov](https://codecov.io/gh/dronnix/bwarr/branch/main/graph/badge.svg)](https://codecov.io/gh/dronnix/bwarr)
[![Go Reference](https://pkg.go.dev/badge/github.com/dronnix/bwarr.svg)](https://pkg.go.dev/github.com/dronnix/bwarr)
[![Go Report Card](https://goreportcard.com/badge/github.com/dronnix/bwarr)](https://goreportcard.com/report/github.com/dronnix/bwarr)

ブラックホワイト配列（別名BWArr）は、配列に基づく高速かつ順序付きのデータ構造で、***$O(\log N)$*** **のメモリアロケーション**を特徴としています。

## データ構造
ブラックホワイト配列のアイデアは、教授[Z. George Mou](https://www.cs.brandeis.edu/~mou/)によって考案され、[Black-White Array: A New Data Structure for
Dynamic Data Sets](https://arxiv.org/abs/2004.09051)にて発表されました。このリポジトリは最初の公開実装を含みます。

![Professor Z. George Mou](https://www.cs.brandeis.edu/~mou/mou.gif)

### 主な特徴：
- 挿入時に$O(\log N)$のメモリアロケーション - GCへの負荷が少ない；
- 挿入、削除、検索操作が高速で、$O(\log N)$の振幅時間複雑度；
- 配列ベースでポインタを使わず、CPUフレンドリー：キャッシュ局所性／連続イテレーション等に適する；
- 重複要素をネイティブにサポート（マルチセットの振る舞い） - ユニークにするために値を構造体にラップする必要なし；
- `github.com/google/btree`や`github.com/petar/GoLLRB`の代替にそのまま使える；
- メモリオーバーヘッドが低い - 要素ごとのポインタなし、コンパクトなメモリ表現；
- シリアライズが容易；

### トレードオフ
- $N$回の挿入操作のうち1回は$O(N)$の複雑度になるが、振幅時間は$O(\log N)$のまま。リアルタイムシステムでは、数百万要素のコレクションでレイテンシのスパイクが発生する可能性がある。非同期／バックグラウンド挿入で緩和可能。
- 要素数が少ない場合、`Search()/Delete()`操作は$O((\log N)^2)$になることがある。50%の要素は$O(\log N)$、75%は$O(2\log N)$、87.5%は$O(3\log N)$など。
- 長い連続した要素を削除する際、`Max()/Min()`操作は$O(N/4)$になることがある。連続呼び出しの振幅複雑度は$O(\log N)$のまま。
- 長い連続した要素を削除する際、イテレーションステップは$O(N/4)$になることがある。全体コレクションのイテレーションの振幅複雑度は要素あたり$O(\log N)$のまま。

### ベンチマーク

[Google BTree](https://github.com/google/btree)との比較ベンチマーク。

#### 挿入
N個のユニークなランダムint64値を空のデータ構造に挿入する際の時間、割り当て回数、割り当てバイト数を測定。BWArrとBTreeはどちらも空から開始し、値を一つずつ挿入します。

![挿入性能](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_unique_values.png?raw=true)
![挿入アロケーション数](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_unique_values_allocs.png?raw=true)
![挿入割り当てバイト数](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_unique_values_bytes.png?raw=true)
小さい値への割り当て：

![Insert Allocs small](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_performance_allocs_detailed.png?raw=true)


#### Get
事前に値が格納されたデータ構造内で、N個の値をキーで検索する時間を測定します。タイミングを開始する前にすべての値がデータ構造に格納され、その後各値がキーで取得されます。

![Get performance](https://github.com/dronnix/bwarr-bench/blob/main/images/get_all_values_by_key.png?raw=true)

#### Iterate
ソート済みおよび非ソートの順序で、すべてのN個の値を反復処理する時間を測定します。
![Ordered Iterate performance](https://github.com/dronnix/bwarr-bench/blob/main/images/ordered_iteration_over_all_values.png?raw=true)
![Unordered Iterate performance](https://github.com/dronnix/bwarr-bench/blob/main/images/unordered_iteration_over_all_values.png?raw=true)

#### 追加ベンチマーク
追加のベンチマークや詳細は[ bwarr-bench](https://github.com/dronnix/bwarr-bench)リポジトリで利用可能です。
さらに多くのメソッドが追加される予定であり、AMD64とARM64アーキテクチャ向けの別々のベンチマークも予定しています。

## インストール

Go 1.22以降が必要です。


```bash
go get github.com/dronnix/bwarr
```

それからコード内でインポートします：

```go
import "github.com/dronnix/bwarr"
```

## 使用法

### 基本例

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