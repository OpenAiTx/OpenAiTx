# validate
[![Build Status](https://travis-ci.org/dealancer/validate.svg?branch=v2)](https://travis-ci.org/dealancer/validate)
[![codecov](https://codecov.io/gh/dealancer/validate/branch/v2/graph/badge.svg)](https://codecov.io/gh/dealancer/validate)
[![Go Report Card](https://goreportcard.com/badge/gopkg.in/dealancer/validate.v2)](https://goreportcard.com/report/gopkg.in/dealancer/validate.v2)
[![GoDoc](https://godoc.org/gopkg.in/dealancer/validate.v2?status.svg)](https://godoc.org/gopkg.in/dealancer/validate.v2)
[![GitHub release](https://img.shields.io/github/release/dealancer/validate.svg)](https://github.com/dealancer/validate/releases)
[![License](https://img.shields.io/github/license/dealancer/validate.svg)](./LICENSE)

パッケージ**validate**はタグに基づいてGoの構造体および型を再帰的に検証します。
サブ構造体、マップ、スライス、配列、ポインタの検証を行うための強力な構文を提供します。パッケージはカスタム検証メソッドの実行も可能です。

このパッケージを使用して、構造体の内容が必要な形式であることを確認してください。
例えば、**validate**パッケージはYAMLやJSONのアンマーシャリング時に便利です。

## インストール

1. `go get`を使ってvalidateパッケージをダウンロードします。
   ```
   go get gopkg.in/dealancer/validate.v2
   ```
2. プロジェクトにvalidateパッケージをインポートします。
   ```go
   import "gopkg.in/dealancer/validate.v2"
   ```
## 種類

このパッケージは多種多様な型をサポートしています。

* ほとんどの組み込み型：
  * `int`、`int8`、`int16`、`int32`、`int64`
  * `uint`、`uint8`、`uint16`、`uint32`、`uint64`
  * `float32`、`float64`
  * `uintptr`
  * `string`
* 別名型：
  * `time.Duration`
  * `byte`（`uint8`）
  * `rune`（`int32`）
  * 例：`type Enum string`
* 複合型：
  * 構造体（Struct）
  * マップ（Map）
  * スライス（Slice）
  * 配列（Array）
  * ポインタ（Pointer）

## バリデータ

このパッケージは次のバリデータを提供します。

* `eq`（等しい）、`ne`（等しくない）、`gt`（より大きい）、`lt`（より小さい）、`gte`（以上）、`lte`（以下）バリデータは、数値の数値的値を比較するか、文字列、マップ、スライス、配列の要素数を比較します。
* `empty` バリデータは、文字列、マップ、スライス、配列が（空であるか）空でないかをチェックします。
* `nil` バリデータは、ポインタが（nilであるか）nilでないかをチェックします。
* `one_of` バリデータは、数値または文字列が指定された要素のいずれかを含むかをチェックします。
* `format` バリデータは、文字列が次のいずれかの形式であるかをチェックします：`alpha`、`alnum`、`alpha_unicode`、`alnum_unicode`、`numeric`、`number`、`hexadecimal`、`hexcolor`、`rgb`、`rgba`、`hsl`、`hsla`、`email`、`url`、`uri`、`urn_rfc2141`、`file`、`base64`、`base64url`、`isbn`、`isbn10`、`isbn13`、`eth_addr`、`btc_addr`、`btc_addr_bech32`、`uuid`、`uuid3`、`uuid4`、`uuid5`、`ascii`、`ascii_print`、`datauri`、`latitude`、`longitude`、`ssn`、`ipv4`、`ipv6`、`ip`、`cidrv4`、`cidrv6`、`cidr`、`mac`、`hostname`、`hostname_rfc1123`、`fqdn`、`url_encoded`、`dir`、`postcode`。

## 演算子

以下の演算子が使用されます。優先度の高い順にリストされています。

* `[]`（ブラケット）はマップのキーを検証するために使用されます。
* `>`（大なり記号）はマップ、スライス、配列の値を検証するか、ポインタの参照外しに使用されます。


* `&`（アンパサンド）は、AND論理を使用して複数のバリデータを実行するために使用されます。  
* `|`（縦棒）は、OR論理を使用して複数のバリデータを実行するために使用されます。  
* `=`（等号）は、バリデータの種類と値を区切るために使用されます。  
* `,`（コンマ）は、バリデータに複数のトークンを指定するために使用されます（例：`one_of`）。  

## 使用方法

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

完全なリファレンスについては、[GoDoc](https://godoc.org/gopkg.in/dealancer/validate.v2) を参照してください。

## クレジット

このプロジェクトは、Vibe Coding ツールが存在する前に Ben Myrgorod によって書かれました。[go-playground/validator](https://github.com/go-playground/validator) に触発されています。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-02

---