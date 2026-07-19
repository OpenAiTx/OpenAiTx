
<div align="right">
  <details>
    <summary >🌐 言語</summary>
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

## これは何ですか？

[![CI](https://github.com/dronnix/bwarr/actions/workflows/ci.yml/badge.svg)](https://github.com/dronnix/bwarr/actions)
[![codecov](https://codecov.io/gh/dronnix/bwarr/branch/main/graph/badge.svg)](https://codecov.io/gh/dronnix/bwarr)
[![Go Reference](https://pkg.go.dev/badge/github.com/dronnix/bwarr.svg)](https://pkg.go.dev/github.com/dronnix/bwarr)
[![Go Report Card](https://goreportcard.com/badge/github.com/dronnix/bwarr)](https://goreportcard.com/report/github.com/dronnix/bwarr)

Black-White Array（略して BWArr）は、配列に基づく高速で順序付けられたデータ構造であり、***$O(\log N)$*** **のメモリアロケーション**を実現します。

## データ構造
Black-White Array のアイデアは教授 [Z. George Mou](https://www.cs.brandeis.edu/~mou/) によって考案され、[Black-White Array: A New Data Structure for Dynamic Data Sets](https://arxiv.org/abs/2004.09051) で発表されました。このリポジトリは初の公開実装を含んでいます。

![Professor Z. George Mou](https://www.cs.brandeis.edu/~mou/mou.gif)

### 主な特徴:
- 挿入時のメモリアロケーションは $O(\log N)$ - GCへの負担なし；
- 挿入、削除、検索操作は高速で、時間のアモチゼーション複雑度 $O(\log N)$；
- 配列ベースでポインタなし、CPUフレンドリー：キャッシュ局所性／順次イテレーション／など；
- 重複要素をネイティブにサポート（マルチセット挙動）- 値をユニーク化するための構造体ラップ不要；
- `github.com/google/btree` や `github.com/petar/GoLLRB` のドロップイン代替；
- 低メモリオーバーヘッド - 要素ごとにポインタなし、コンパクトなメモリ表現；
- シリアライズ容易；

### トレードオフ
- $N$ 回の挿入操作ごとに複雑度が $O(N)$ になることがあるが、アモチゼーションでは $O(\log N)$。リアルタイムシステムでは、数百万要素のコレクションでレイテンシスパイクが発生する可能性。非同期／バックグラウンド挿入で緩和可能。
- 要素数が少ない場合、`Search()/Delete()` 操作は $O((\log N)^2)$ になることがある。50%の要素は $O(\log N)$、75% は $O(2\log N)$、87.5% は $O(3\log N)$ など。
- 長い連続要素を削除する場合、`Max()/Min()` 操作は $O(N/4)$ かかることがある。呼び出しの連続ではアモチゼーション複雑度は $O(\log N)$。
- 長い連続要素を削除する場合、イテレーションステップは $O(N/4)$ かかることがある。全コレクションのイテレーションでは各要素 $O(\log N)$ のアモチゼーション複雑度。

### ユースケース
メモリ内コレクションで読取:書込比率 1:1 < r:w < 10:1。BWArr は大量の挿入・削除（低アロケーション・断片化）に最適化され、検索やイテレーションも高速。

### ベンチマーク

[Google BTree](https://github.com/google/btree) と比較したベンチマーク。

#### 挿入
空のデータ構造へ N 個のユニークな int64 ランダム値を挿入する際の時間、アロケーション数、割り当てKB数を計測。BWArr と BTree はどちらも空から開始し、値を一つずつ挿入。

![Insert performance](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_unique_values.png?raw=true)
![Insert Allocs](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_unique_values_allocs.png?raw=true)
![Insert Alloc_Bytes](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_unique_values_bytes.png?raw=true)

小さい値の場合のアロケーション：

![Insert Allocs small](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_performance_allocs_detailed.png?raw=true)



#### 取得
事前に全ての値が格納されたデータ構造から、N個の値をキーで検索するのにかかる時間を計測します。タイミングの計測前にデータ構造に全ての値を格納し、その後各値をキーで取得します。

![Get performance](https://github.com/dronnix/bwarr-bench/blob/main/images/get_all_values_by_key.png?raw=true)

#### イテレート
N個全ての値をソート順・非ソート順でイテレートするのにかかる時間を計測します。
![Ordered Iterate performance](https://github.com/dronnix/bwarr-bench/blob/main/images/ordered_iteration_over_all_values.png?raw=true)
![Unordered Iterate performance](https://github.com/dronnix/bwarr-bench/blob/main/images/unordered_iteration_over_all_values.png?raw=true)

#### その他のベンチマーク
追加のベンチマークや詳細は [bwarr-bench](https://github.com/dronnix/bwarr-bench) リポジトリで確認できます。
今後さらに多くのメソッドが追加され、AMD64およびARM64アーキテクチャ向けの個別ベンチマークも予定しています。

## インストール

Go 1.22 以上が必要です。

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