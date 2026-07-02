# validate
[![Build Status](https://travis-ci.org/dealancer/validate.svg?branch=v2)](https://travis-ci.org/dealancer/validate)
[![codecov](https://codecov.io/gh/dealancer/validate/branch/v2/graph/badge.svg)](https://codecov.io/gh/dealancer/validate)
[![Go Report Card](https://goreportcard.com/badge/gopkg.in/dealancer/validate.v2)](https://goreportcard.com/report/gopkg.in/dealancer/validate.v2)
[![GoDoc](https://godoc.org/gopkg.in/dealancer/validate.v2?status.svg)](https://godoc.org/gopkg.in/dealancer/validate.v2)
[![GitHub release](https://img.shields.io/github/release/dealancer/validate.svg)](https://github.com/dealancer/validate/releases)
[![License](https://img.shields.io/github/license/dealancer/validate.svg)](./LICENSE)

包 **validate** 基于标签递归验证 Go 结构体和类型。  
它提供强大的语法来验证子结构体、映射、切片、数组和指针。该包还允许运行自定义验证方法。

使用此包确保结构体的内容符合您需要的格式。  
例如，**validate** 包在反序列化 YAML 或 JSON 时非常有用。

## 安装

1. 使用 `go get` 下载 validate 包。
   ```
   go get gopkg.in/dealancer/validate.v2
   ```
2. 将 validate 包导入到您的项目中。
   ```go
   import "gopkg.in/dealancer/validate.v2"
   ```
## 类型

本包支持多种类型。

* 大多数内置类型：
  * `int`，`int8` `int16`，`int32`，`int64`
  * `uint`，`uint8`，`uint16`，`uint32`，`uint64`
  * `float32`，`float64`
  * `uintptr`
  * `string`
* 别名类型：
  * `time.Duration`
  * `byte`（`uint8`）
  * `rune`（`int32`）
  * 例如 `type Enum string`
* 复杂类型：
  * 结构体
  * 映射
  * 切片
  * 数组
  * 指针

## 验证器

本包提供以下验证器。

* `eq`（等于），`ne`（不等于），`gt`（大于），`lt`（小于），`gte`（大于等于），`lte`（小于等于）验证器比较数字的数值或比较字符串、映射、切片或数组中元素的数量。
* `empty` 验证器检查字符串、映射、切片或数组是否（不）为空。
* `nil` 验证器检查指针是否（不）为 nil。
* `one_of` 验证器检查数字或字符串是否包含给定元素中的任意一个。
* `format` 验证器检查字符串是否符合以下格式之一：`alpha`，`alnum`，`alpha_unicode`，`alnum_unicode`，`numeric`，`number`，`hexadecimal`，`hexcolor`，`rgb`，`rgba`，`hsl`，`hsla`，`email`，`url`，`uri`，`urn_rfc2141`，`file`，`base64`，`base64url`，`isbn`，`isbn10`，`isbn13`，`eth_addr`，`btc_addr`，`btc_addr_bech32`，`uuid`，`uuid3`，`uuid4`，`uuid5`，`ascii`，`ascii_print`，`datauri`，`latitude`，`longitude`，`ssn`，`ipv4`，`ipv6`，`ip`，`cidrv4`，`cidrv6`，`cidr`，`mac`，`hostname`，`hostname_rfc1123`，`fqdn`，`url_encoded`，`dir`，`postcode`。

## 操作符

使用以下操作符。它们按优先级从高到低列出。

* `[]`（方括号）用于验证映射键。
* `>`（大于号）用于验证映射、切片、数组的值或解引用指针。


* `&`（和号）用于使用 AND 逻辑执行多个验证器。  
* `|`（竖线）用于使用 OR 逻辑执行多个验证器。  
* `=`（等号）用于分隔验证器类型和值。  
* `,`（逗号）用于为验证器指定多个标记（例如 `one_of`）。  

## 用法

```go
type Registration struct {
    // Username should be between 3 and 25 characters and in alphanumeric unicode format
    Username string `validate:"gte=3 & lte=25 & format=alnum_unicode"`

    // Email should be empty or in the email format
    Email string `validate:"empty=true | format=email"`

    // Password is validated using a custom validation method
    Password string

    // Role should be one of "admin", "publisher", or "author"
    Role string `validate:"one_of=admin,publisher,author"`

    // URLs should not be empty, URLs values should be in the url format
    URLs []string `validate:"empty=false > format=url"`

    // Retired (pointer) should not be nil
    Retired *bool `validate:"nil=false"`

    // Some complex field with validation
    Complex []map[*string]int `validate:"gte=1 & lte=2 | eq=4 > empty=false [nil=false > empty=false] > ne=0"`
}

// Custom validation
func (r Registration) Validate() error {
    if !StrongPass(r.Password) {
        return errors.New("Password should be strong!")
    }

    return nil
}

type Registrations struct {
	r []Registration `validate:"gte=2"` // There should be at least two registrations
}
```

```go
registrations := Registrations{
	r: []Registration{
		Registration{
			Username: "admin",
		},
	},
}

if err := validate.Validate(&registrations); err != nil {
	panic(err)
}
```

请参阅 [GoDoc](https://godoc.org/gopkg.in/dealancer/validate.v2) 获取完整参考。

## 致谢

该项目由 Ben Myrgorod 在 Vibe Coding 工具存在之前编写。灵感来自 [go-playground/validator](https://github.com/go-playground/validator)。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-02

---