# validate
[![Build Status](https://travis-ci.org/dealancer/validate.svg?branch=v2)](https://travis-ci.org/dealancer/validate)
[![codecov](https://codecov.io/gh/dealancer/validate/branch/v2/graph/badge.svg)](https://codecov.io/gh/dealancer/validate)
[![Go Report Card](https://goreportcard.com/badge/gopkg.in/dealancer/validate.v2)](https://goreportcard.com/report/gopkg.in/dealancer/validate.v2)
[![GoDoc](https://godoc.org/gopkg.in/dealancer/validate.v2?status.svg)](https://godoc.org/gopkg.in/dealancer/validate.v2)
[![GitHub release](https://img.shields.io/github/release/dealancer/validate.svg)](https://github.com/dealancer/validate/releases)
[![License](https://img.shields.io/github/license/dealancer/validate.svg)](./LICENSE)

Package **validate** validates Go struct and types recursively based on tags.
It provides powerful syntax to perform validation for substructs, maps, slices, arrays, and pointers. Package also allows to run custom validation methods.

Use this package to make sure that the content of the struct is in the format you need.
For example, **validate** package is useful when unmarshalling YAML or JSON.

## Installation

1. Use `go get` to download validate package.
   ```
   go get gopkg.in/dealancer/validate.v2
   ```
2. Import validate package into your project.
   ```go
   import "gopkg.in/dealancer/validate.v2"
   ```


## Types

This package supports a wide variety of types.

* Most of the built-in types:
  * `int`, `int8` `int16`, `int32`, `int64`
  * `uint`, `uint8`, `uint16`, `uint32`, `uint64`
  * `float32`, `float64`
  * `uintptr`
  * `string`
* Aliased types:
  * `time.Duration`
  * `byte` (`uint8`)
  * `rune` (`int32`)
  * e.g. `type Enum string`
* Complex types:
  * Struct
  * Map
  * Slice
  * Array
  * Pointer

## Validators

This package provides the following validators.

* `eq` (equals), `ne` (not equals), `gt` (greater than), `lt` (less than), `gte` (greater than or equal to), `lte` (less than or equal to) validators compare a numeric value of a number or compare a count of elements in a string, a map, a slice, or an array.
* `empty` validator checks if a string, a map, a slice, or an array is (not) empty.
* `nil` validator checks if a pointer is (not) nil.
* `one_of` validator checks if a number or a string contains any of the given elements.
* `format` validator checks if a string in one of the following formats: `alpha`, `alnum`, `alpha_unicode`, `alnum_unicode`, `numeric`, `number`, `hexadecimal`, `hexcolor`, `rgb`, `rgba`, `hsl`, `hsla`, `email`, `url`, `uri`, `urn_rfc2141`, `file`, `base64`, `base64url`, `isbn`, `isbn10`, `isbn13`, `eth_addr`, `btc_addr`, `btc_addr_bech32`, `uuid`, `uuid3`, `uuid4`, `uuid5`, `ascii`, `ascii_print`, `datauri`, `latitude`, `longitude`, `ssn`, `ipv4`, `ipv6`, `ip`, `cidrv4`, `cidrv6`, `cidr`, `mac`, `hostname`, `hostname_rfc1123`, `fqdn`, `url_encoded`, `dir`, `postcode`.

## Operators

Following operators are used. There are listed in the descending order of their precedence.

* `[]` (brackets) are used to validate map keys.
* `>` (greater-than sign) is used to validate values of maps, slices, arrays or to dereference a pointer.
* `&` (ampersand) is used to perform multiple validators using AND logic.
* `|` (vertical bar) is used to perform multiple validators using OR logic.
* `=` (equal sign) is used to separate validator type from value.
* `,` (comma) is used to specify multiple tokens for a validator (e.g. `one_of`).

## Usage

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

See [GoDoc](https://godoc.org/gopkg.in/dealancer/validate.v2) for the complete reference.

## Credits

This project has been written by Ben Myrgorod before Vibe Coding tools existed. Insipred by [go-playground/validator](https://github.com/go-playground/validator).
