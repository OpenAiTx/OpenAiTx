# Govalid

[![](https://goreportcard.com/badge/github.com/twharmon/govalid)](https://goreportcard.com/report/github.com/twharmon/govalid)

使用 Govalid 验证结构体。

## 基本示例
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

## 错误值
当你调用 `govalid.Validate` 来验证结构体时，如果验证规则未通过，它会返回一个错误。该错误可能是特定于验证的错误（实现了 `govalid.ValidationError` 接口），也可能是指示验证处理过程中出现问题的其他错误。这样你就可以区分由无效数据引起的错误和由验证逻辑中的问题（例如将 `valid` 标签设置为 `max:not-a-number`）引起的错误。

```go
if err := govalid.Validate(value); err != nil {
	if verr, ok := err.(govalid.ValidationError); ok {
		fmt.Println("validation error", verr)
	} else {
		fmt.Println("some other error", err)
	}
}
```

## Dive 使用方法
`dive` 规则用于对指针、切片、数组和结构体中的元素应用验证规则。遇到 `dive` 规则时，验证器会“深入”集合的元素或指针指向的值，并对每个元素或解引用的值应用剩余的规则。

### 注意事项
- **指针**：`dive` 规则会解引用指针，并将剩余的规则应用于它指向的值。
- **切片/数组**：`dive` 规则会遍历切片或数组中的每个元素，并将剩余的规则应用于每个元素。
- **结构体**：`dive` 规则会根据结构体自身的字段标签验证结构体。`dive` 之后的剩余规则对结构体无意义。

### 示例

#### 指针

```go
type Example struct {
    Field *string `valid:"req|dive|min:3"`
}
```
在此示例中，Field 必须是指向字符串的非 nil 指针，并且该字符串的长度必须至少为 3 个字符。

#### 切片/数组
```go
type Example struct {
    Field []string `valid:"req|dive|min:3"`
}
```
在此示例中，字段必须是非空的字符串切片，并且切片中的每个字符串长度必须至少为3个字符。

#### 结构体
```go
type Inner struct {
    Name string `valid:"req"`
}

type Outer struct {
    InnerStruct Inner `valid:"dive"`
}
```
在此示例中，InnerStruct 字段将根据 Inner 结构体中定义的验证标签进行验证。


## 贡献

提交拉取请求。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-31

---