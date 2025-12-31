# Govalid

[![](https://goreportcard.com/badge/github.com/twharmon/govalid)](https://goreportcard.com/report/github.com/twharmon/govalid)

Govalidを使用して構造体を検証します。

## 基本例
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

## エラー値
構造体の検証のために `govalid.Validate` を呼び出すと、検証ルールが満たされない場合にエラーを返します。このエラーは、検証固有のエラー（`govalid.ValidationError` の実装）であるか、検証処理の問題を示す別のエラーである場合があります。これにより、無効なデータによるエラーと、`valid` タグに `max:not-a-number` のような誤った設定がある検証ロジックの問題によるエラーを区別できます。

```go
if err := govalid.Validate(value); err != nil {
	if verr, ok := err.(govalid.ValidationError); ok {
		fmt.Println("validation error", verr)
	} else {
		fmt.Println("some other error", err)
	}
}
```

## Diveの使用法
`dive`ルールは、ポインタ、スライス、配列、および構造体内の要素に検証ルールを適用するために使用されます。`dive`ルールに遭遇すると、バリデータはコレクションの要素やポインタが指す値に「潜り込み」、残りのルールを各要素または参照解除された値に適用するよう指示されます。

### 注意事項
- **ポインタ**: `dive`ルールはポインタを参照解除し、指している値に残りのルールを適用します。
- **スライス／配列**: `dive`ルールはスライスや配列の各要素を反復処理し、残りのルールを各要素に適用します。
- **構造体**: `dive`ルールは構造体をそのフィールドタグに従って検証します。`dive`の後の残りのルールは構造体には意味を持ちません。

### 例

#### ポインタ

```go
type Example struct {
    Field *string `valid:"req|dive|min:3"`
}
```
この例では、Field は文字列への非nilポインタでなければならず、その文字列は少なくとも3文字以上でなければなりません。

#### スライス/配列
```go
type Example struct {
    Field []string `valid:"req|dive|min:3"`
}
```
この例では、フィールドはnilでない文字列のスライスでなければならず、スライス内の各文字列は少なくとも3文字以上でなければなりません。

#### 構造体
```go
type Inner struct {
    Name string `valid:"req"`
}

type Outer struct {
    InnerStruct Inner `valid:"dive"`
}
```
この例では、InnerStructフィールドはInner構造体で定義されたバリデーションタグに従って検証されます。


## 貢献する

プルリクエストを作成してください。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-31

---