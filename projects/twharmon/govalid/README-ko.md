# Govalid

[![](https://goreportcard.com/badge/github.com/twharmon/govalid)](https://goreportcard.com/report/github.com/twharmon/govalid)

Govalid를 사용하여 구조체를 검증하세요.

## 기본 예제
```go
package main

import (
	"errors"
	"fmt"
	"log"
	"strings"
	"unicode/utf8"

	"github.com/twharmon/govalid"
)

type Post struct {
	// ID has no constraints
	ID int

	// Title is required, must be at least 3 characters long, and
	// cannot be more than 20 characters long
	Title string `valid:"req|min:3|max:20"`

	// Body is not required, cannot be more than 10000 charachers,
	// and must be "fun" (a custom rule defined below).
	Body string `valid:"max:10000|fun"`
}

func main() {
	// Add custom string rule "fun" that can be used on any string field
	// in any struct.
	govalid.Rule("fun", func(v any) error {
		switch tv := v.(type) {
		case string:
			if float64(strings.Count(tv, "!"))/float64(utf8.RuneCountInString(tv)) > 0.001 {
				return nil
			}
			// return a validation error with govalid.Error
			return govalid.NewValidationError("must contain more exclamation marks")
		default:
			// return a non validation (internal) error
			return errors.New("fun constraint must be applied to string only")
		}
	})
	fmt.Println(govalid.Validate(&Post{
		ID:    5,
		Title: "Hi",
		Body:  "Hello world!",
	}))
}
```
## 오류 값
`govalid.Validate`를 호출하여 구조체를 검증할 때, 검증 규칙이 충족되지 않으면 오류를 반환합니다. 이 오류는 검증 전용 오류(`govalid.ValidationError`의 구현체)일 수도 있고, 검증 처리 중 문제를 나타내는 다른 오류일 수도 있습니다. 이를 통해 잘못된 데이터로 인한 오류와 `valid` 태그를 `max:not-a-number`와 같이 잘못 설정한 경우와 같은 검증 로직 문제로 인한 오류를 구분할 수 있습니다.


```go
if err := govalid.Validate(value); err != nil {
	if verr, ok := err.(govalid.ValidationError); ok {
		fmt.Println("validation error", verr)
	} else {
		fmt.Println("some other error", err)
	}
}
```
## Dive 사용법
`dive` 규칙은 포인터, 슬라이스, 배열 및 구조체 내의 요소에 검증 규칙을 적용하는 데 사용됩니다. `dive` 규칙을 만나면 검증기는 컬렉션의 요소 또는 포인터가 가리키는 값으로 "들어가서" 나머지 규칙을 각 요소 또는 역참조된 값에 적용하도록 지시합니다.

### 참고 사항
- **포인터**: `dive` 규칙은 포인터를 역참조하고 나머지 규칙을 가리키는 값에 적용합니다.
- **슬라이스/배열**: `dive` 규칙은 슬라이스 또는 배열의 각 요소를 순회하며 나머지 규칙을 각 요소에 적용합니다.
- **구조체**: `dive` 규칙은 구조체를 해당 필드 태그에 따라 검증합니다. `dive` 이후의 나머지 규칙은 구조체에 대해 의미가 없습니다.

### 예제

#### 포인터


```go
type Example struct {
    Field *string `valid:"req|dive|min:3"`
}
```
이 예제에서, Field는 널이 아닌 문자열 포인터여야 하며, 문자열은 최소 3자 이상이어야 합니다.

#### 슬라이스/배열
```go
type Example struct {
    Field []string `valid:"req|dive|min:3"`
}
```
이 예제에서, 필드는 nil이 아닌 문자열 슬라이스여야 하며, 슬라이스 내 각 문자열은 최소 3자 이상이어야 합니다.

#### 구조체
```go
type Inner struct {
    Name string `valid:"req"`
}

type Outer struct {
    InnerStruct Inner `valid:"dive"`
}
```
이 예제에서 InnerStruct 필드는 Inner 구조체에 정의된 검증 태그에 따라 검증됩니다.


## 기여하기

풀 리퀘스트를 만드세요.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-31

---