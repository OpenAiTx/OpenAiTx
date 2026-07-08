## 이것은 무엇인가?

[![CI](https://github.com/dronnix/bwarr/actions/workflows/ci.yml/badge.svg)](https://github.com/dronnix/bwarr/actions)
[![codecov](https://codecov.io/gh/dronnix/bwarr/branch/main/graph/badge.svg)](https://codecov.io/gh/dronnix/bwarr)
[![Go Reference](https://pkg.go.dev/badge/github.com/dronnix/bwarr.svg)](https://pkg.go.dev/github.com/dronnix/bwarr)
[![Go Report Card](https://goreportcard.com/badge/github.com/dronnix/bwarr)](https://goreportcard.com/report/github.com/dronnix/bwarr)

블랙-화이트 배열(또는 BWArr)은 ***$O(\log N)$*** **메모리 할당**을 기반으로 하는 빠르고 정렬된 배열 기반 데이터 구조입니다.

## 데이터 구조
블랙-화이트 배열의 아이디어는 교수 [Z. George Mou](https://www.cs.brandeis.edu/~mou/)에 의해 고안되어 [Black-White Array: A New Data Structure for
Dynamic Data Sets](https://arxiv.org/abs/2004.09051) 논문에서 발표되었습니다. 이 저장소는 최초의 공개 구현체를 포함합니다.

![교수 Z. George Mou](https://www.cs.brandeis.edu/~mou/mou.gif)

### 주요 특징:
- 삽입 시 $O(\log N)$ 메모리 할당 - GC 부담 없음;
- 삽입, 삭제, 검색 연산이 빠름 - 암모타이즈드 시간 복잡도 $O(\log N)$;
- 배열 기반이며 포인터를 사용하지 않아 CPU 친화적: 캐시 지역성 / 순차 반복 등;
- 중복 요소를 기본 지원 (멀티셋 동작) - 값을 구조체로 감싸서 고유하게 만들 필요 없음;
- `github.com/google/btree` 및 `github.com/petar/GoLLRB`의 대체제로 바로 사용 가능;
- 낮은 메모리 오버헤드 - 요소 당 포인터 없음, 컴팩트한 메모리 표현;
- 쉽게 직렬화 가능;

### 트레이드오프
- $N$번 삽입 중 한 번의 복잡도는 $O(N)$까지 떨어지지만, 암모타이즈드 복잡도는 여전히 $O(\log N)$입니다. 실시간 시스템에서는 수백만 개 요소를 가진 컬렉션에서 지연 스파이크가 발생할 수 있습니다. 비동기/백그라운드 삽입으로 완화 가능.
- 적은 수의 요소에 대해 `Search()/Delete()` 연산은 $O((\log N)^2)$가 될 수 있습니다. 50% 요소는 $O(\log N)$, 75%는 $O(2\log N)$, 87.5%는 $O(3\log N)$ 등을 차지합니다.
- 긴 연속 요소 삭제 시 `Max()/Min()` 연산이 $O(N/4)$를 차지할 수 있습니다. 연속 호출에 대한 암모타이즈드 복잡도는 $O(\log N)$입니다.
- 긴 연속 요소 삭제 시 반복 단계가 $O(N/4)$를 차지할 수 있습니다. 전체 컬렉션 반복의 암모타이즈드 복잡도는 요소당 $O(\log N)$입니다.

### 벤치마크

[Google BTree](https://github.com/google/btree)와 비교한 벤치마크입니다.

#### 삽입
빈 데이터 구조에 N개의 고유한 임의 int64 값을 삽입하는 데 걸리는 시간, 할당 수 및 할당된 KB 수를 측정합니다. BWArr와 BTree 모두 빈 상태에서 시작하여 모든 값을 하나씩 삽입합니다.

![삽입 성능](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_unique_values.png?raw=true)
![삽입 할당](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_unique_values_allocs.png?raw=true)
![삽입 할당_바이트](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_unique_values_bytes.png?raw=true)
작은 값에 대한 할당:

![Insert Allocs small](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_performance_allocs_detailed.png?raw=true)


#### Get 
미리 채워진 데이터 구조에서 키로 N개의 값을 조회하는 데 걸리는 시간을 측정합니다. 데이터 구조는 타이밍이 시작되기 전에 모든 값으로 채워지고, 각 값은 키로 검색됩니다.

![Get performance](https://github.com/dronnix/bwarr-bench/blob/main/images/get_all_values_by_key.png?raw=true)

#### Iterate
정렬된 순서와 정렬되지 않은 순서로 모든 N개의 값을 반복하는 데 걸리는 시간을 측정합니다.
![Ordered Iterate performance](https://github.com/dronnix/bwarr-bench/blob/main/images/ordered_iteration_over_all_values.png?raw=true)
![Unordered Iterate performance](https://github.com/dronnix/bwarr-bench/blob/main/images/unordered_iteration_over_all_values.png?raw=true)

#### 추가 벤치마크
추가 벤치마크 및 세부 정보는 [bwarr-bench](https://github.com/dronnix/bwarr-bench) 저장소에서 확인할 수 있습니다.
더 많은 메서드가 추가될 예정이며, AMD64 및 ARM64 아키텍처별 별도 벤치마크도 기대할 수 있습니다.

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