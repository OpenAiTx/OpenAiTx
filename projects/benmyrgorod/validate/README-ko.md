# validate
[![Build Status](https://travis-ci.org/dealancer/validate.svg?branch=v2)](https://travis-ci.org/dealancer/validate)
[![codecov](https://codecov.io/gh/dealancer/validate/branch/v2/graph/badge.svg)](https://codecov.io/gh/dealancer/validate)
[![Go Report Card](https://goreportcard.com/badge/gopkg.in/dealancer/validate.v2)](https://goreportcard.com/report/gopkg.in/dealancer/validate.v2)
[![GoDoc](https://godoc.org/gopkg.in/dealancer/validate.v2?status.svg)](https://godoc.org/gopkg.in/dealancer/validate.v2)
[![GitHub release](https://img.shields.io/github/release/dealancer/validate.svg)](https://github.com/dealancer/validate/releases)
[![License](https://img.shields.io/github/license/dealancer/validate.svg)](./LICENSE)

패키지 **validate**는 태그를 기반으로 Go 구조체와 타입을 재귀적으로 검증합니다.
서브구조체, 맵, 슬라이스, 배열, 포인터에 대한 검증을 수행하는 강력한 문법을 제공합니다. 패키지는 또한 사용자 정의 검증 메서드를 실행할 수 있도록 허용합니다.

이 패키지를 사용하여 구조체의 내용이 필요한 형식인지 확인할 수 있습니다.
예를 들어, **validate** 패키지는 YAML 또는 JSON을 언마샬링할 때 유용합니다.

## 설치

1. `go get`을 사용하여 validate 패키지를 다운로드합니다.
   ```
   go get gopkg.in/dealancer/validate.v2
   ```
2. validate 패키지를 프로젝트에 가져옵니다.
   ```go
   import "gopkg.in/dealancer/validate.v2"
   ```

## 타입

이 패키지는 다양한 타입을 지원합니다.

* 대부분의 내장 타입:
  * `int`, `int8` `int16`, `int32`, `int64`
  * `uint`, `uint8`, `uint16`, `uint32`, `uint64`
  * `float32`, `float64`
  * `uintptr`
  * `string`
* 별칭 타입:
  * `time.Duration`
  * `byte` (`uint8`)
  * `rune` (`int32`)
  * 예: `type Enum string`
* 복합 타입:
  * 구조체
  * 맵
  * 슬라이스
  * 배열
  * 포인터

## 검증기

이 패키지는 다음과 같은 검증기를 제공합니다.

* `eq` (같음), `ne` (같지 않음), `gt` (보다 큼), `lt` (보다 작음), `gte` (보다 크거나 같음), `lte` (보다 작거나 같음) 검증기는 숫자의 값이나 문자열, 맵, 슬라이스, 배열의 요소 개수를 비교합니다.
* `empty` 검증기는 문자열, 맵, 슬라이스, 배열이 비어있는지(또는 비어있지 않은지) 확인합니다.
* `nil` 검증기는 포인터가 nil인지(또는 아닌지) 확인합니다.
* `one_of` 검증기는 숫자나 문자열이 주어진 요소 중 하나를 포함하는지 확인합니다.
* `format` 검증기는 문자열이 다음 형식 중 하나인지 확인합니다: `alpha`, `alnum`, `alpha_unicode`, `alnum_unicode`, `numeric`, `number`, `hexadecimal`, `hexcolor`, `rgb`, `rgba`, `hsl`, `hsla`, `email`, `url`, `uri`, `urn_rfc2141`, `file`, `base64`, `base64url`, `isbn`, `isbn10`, `isbn13`, `eth_addr`, `btc_addr`, `btc_addr_bech32`, `uuid`, `uuid3`, `uuid4`, `uuid5`, `ascii`, `ascii_print`, `datauri`, `latitude`, `longitude`, `ssn`, `ipv4`, `ipv6`, `ip`, `cidrv4`, `cidrv6`, `cidr`, `mac`, `hostname`, `hostname_rfc1123`, `fqdn`, `url_encoded`, `dir`, `postcode`.

## 연산자

다음 연산자가 사용됩니다. 우선순위가 높은 순서대로 나열되어 있습니다.

* `[]` (대괄호)는 맵 키를 검증하는 데 사용됩니다.
* `>` (부등호)는 맵, 슬라이스, 배열의 값을 검증하거나 포인터를 역참조하는 데 사용됩니다.

* `&` (앤퍼샌드)는 AND 논리를 사용하여 여러 유효성 검사기를 수행하는 데 사용됩니다.
* `|` (수직 막대)는 OR 논리를 사용하여 여러 유효성 검사기를 수행하는 데 사용됩니다.
* `=` (등호)는 유효성 검사 유형과 값을 구분하는 데 사용됩니다.
* `,` (쉼표)는 유효성 검사기에서 여러 토큰을 지정하는 데 사용됩니다(예: `one_of`).

## 사용법

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

전체 참조는 [GoDoc](https://godoc.org/gopkg.in/dealancer/validate.v2)에서 확인하세요.

## 크레딧

이 프로젝트는 Vibe 코딩 도구가 존재하기 전에 Ben Myrgorod에 의해 작성되었습니다. [go-playground/validator](https://github.com/go-playground/validator)에서 영감을 받았습니다.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-02

---