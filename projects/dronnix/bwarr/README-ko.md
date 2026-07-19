
<div align="right">
  <details>
    <summary >🌐 언어</summary>
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

## 이게 뭐죠?

[![CI](https://github.com/dronnix/bwarr/actions/workflows/ci.yml/badge.svg)](https://github.com/dronnix/bwarr/actions)
[![codecov](https://codecov.io/gh/dronnix/bwarr/branch/main/graph/badge.svg)](https://codecov.io/gh/dronnix/bwarr)
[![Go Reference](https://pkg.go.dev/badge/github.com/dronnix/bwarr.svg)](https://pkg.go.dev/github.com/dronnix/bwarr)
[![Go Report Card](https://goreportcard.com/badge/github.com/dronnix/bwarr)](https://goreportcard.com/report/github.com/dronnix/bwarr)

Black-White Array (약칭 BWArr)는 배열을 기반으로 한 빠르고 정렬된 데이터 구조로, ***$O(\log N)$*** **메모리 할당**을 제공합니다.

## 데이터 구조
Black-White Array의 아이디어는 교수 [Z. George Mou](https://www.cs.brandeis.edu/~mou/)에 의해 고안되고 [Black-White Array: A New Data Structure for Dynamic Data Sets](https://arxiv.org/abs/2004.09051)에 발표되었습니다. 이 저장소는 최초의 공개 구현을 포함하고 있습니다.

![Professor Z. George Mou](https://www.cs.brandeis.edu/~mou/mou.gif)

### 주요 특징:
- $O(\log N)$ 메모리 할당으로 삽입 - GC에 부담 없음;
- 빠른 삽입, 삭제, 검색 연산 $O(\log N)$ 시간의 상환 복잡도;
- 배열 기반, 포인터 없음 - CPU 친화적: 캐시 지역성 / 순차 반복 등;
- 중복 요소를 기본적으로 지원 (멀티셋 동작) - 고유하게 만들기 위해 값을 구조체로 래핑할 필요 없음;
- `github.com/google/btree`, `github.com/petar/GoLLRB`의 대체품으로 바로 사용 가능;
- 낮은 메모리 오버헤드 - 요소당 포인터 없음, 메모리 표현이 compact;
- 직렬화가 용이함;

### 트레이드오프
- $N$ 번 중 한 번 삽입 연산의 복잡도가 $O(N)$으로 떨어질 수 있으나, 상환 복잡도는 $O(\log N)$을 유지합니다. 실시간 시스템에서는 수백만 요소의 컬렉션에서 지연이 발생할 수 있습니다. 비동기/백그라운드 삽입으로 완화 가능.
- 요소 수가 적을 때 `Search()/Delete()` 연산이 $O((\log N)^2)$이 걸릴 수 있습니다. 50%의 요소는 $O(\log N)$, 75%는 $O(2\log N)$, 87.5%는 $O(3\log N)$ 등.
- 긴 연속 요소 삭제 시, `Max()/Min()` 연산이 $O(N/4)$ 소요될 수 있습니다. 일련의 호출에 대한 상환 복잡도는 $O(\log N)$ 유지.
- 긴 연속 요소 삭제 시, 반복 단계가 $O(N/4)$ 소요될 수 있습니다. 전체 컬렉션 반복의 상환 복잡도는 요소당 $O(\log N)$ 유지.

### 사용 사례
읽기-쓰기 비율이 1:1 < r:w < 10:1인 인메모리 컬렉션. BWArr은 적은 할당과 단편화로 대량 삽입 및 삭제에 최적화되었으며, 여전히 빠른 검색과 반복을 제공합니다.

### 벤치마크

[Google BTree](https://github.com/google/btree)와의 비교 벤치마크.

#### 삽입 
N개의 고유한 랜덤 int64 값을 빈 데이터 구조에 삽입할 때의 시간, 할당 수, 할당된 KB를 측정합니다. BWArr과 BTree 모두 빈 상태에서 시작하여 값을 하나씩 삽입합니다.

![Insert performance](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_unique_values.png?raw=true)
![Insert Allocs](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_unique_values_allocs.png?raw=true)
![Insert Alloc_Bytes](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_unique_values_bytes.png?raw=true)

작은 값에 대한 할당: 

![Insert Allocs small](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_performance_allocs_detailed.png?raw=true)



#### Get 
미리 채워진 데이터 구조에서 N개의 값을 키로 조회하는 데 걸리는 시간을 측정합니다. 데이터 구조는 타이밍 시작 전에 모든 값으로 채워진 후, 각 값이 키로 조회됩니다.

![Get performance](https://github.com/dronnix/bwarr-bench/blob/main/images/get_all_values_by_key.png?raw=true)

#### Iterate
정렬된 순서와 비정렬된 순서로 모든 N개의 값을 반복(iterate)하는 데 걸리는 시간을 측정합니다.
![Ordered Iterate performance](https://github.com/dronnix/bwarr-bench/blob/main/images/ordered_iteration_over_all_values.png?raw=true)
![Unordered Iterate performance](https://github.com/dronnix/bwarr-bench/blob/main/images/unordered_iteration_over_all_values.png?raw=true)

#### More benchmarks
추가 벤치마크와 자세한 내용은 [bwarr-bench](https://github.com/dronnix/bwarr-bench) 저장소에서 확인할 수 있습니다.
더 많은 메서드가 추가될 예정이며, AMD64와 ARM64 아키텍처에 대한 개별 벤치마크도 제공될 예정입니다.

## 설치

Go 1.22 이상이 필요합니다.

```bash
go get github.com/dronnix/bwarr
```

그런 다음 코드에서 가져오십시오:

```go
import "github.com/dronnix/bwarr"
```

## 사용법

### 기본 예제

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