# validate
[![Build Status](https://travis-ci.org/dealancer/validate.svg?branch=v2)](https://travis-ci.org/dealancer/validate)
[![codecov](https://codecov.io/gh/dealancer/validate/branch/v2/graph/badge.svg)](https://codecov.io/gh/dealancer/validate)
[![Go Report Card](https://goreportcard.com/badge/gopkg.in/dealancer/validate.v2)](https://goreportcard.com/report/gopkg.in/dealancer/validate.v2)
[![GoDoc](https://godoc.org/gopkg.in/dealancer/validate.v2?status.svg)](https://godoc.org/gopkg.in/dealancer/validate.v2)
[![GitHub release](https://img.shields.io/github/release/dealancer/validate.svg)](https://github.com/dealancer/validate/releases)
[![License](https://img.shields.io/github/license/dealancer/validate.svg)](./LICENSE)

El paquete **validate** valida structs y tipos de Go de forma recursiva basándose en etiquetas.
Proporciona una sintaxis potente para realizar validaciones en subestructuras, mapas, slices, arrays y punteros. El paquete también permite ejecutar métodos de validación personalizados.

Use este paquete para asegurarse de que el contenido del struct está en el formato que necesita.
Por ejemplo, el paquete **validate** es útil al deserializar YAML o JSON.

## Instalación

1. Use `go get` para descargar el paquete validate.
   ```
   go get gopkg.in/dealancer/validate.v2
   ```
2. Importe el paquete validate en su proyecto.
   ```go
   import "gopkg.in/dealancer/validate.v2"
   ```
## Tipos

Este paquete soporta una amplia variedad de tipos.

* La mayoría de los tipos incorporados:
  * `int`, `int8` `int16`, `int32`, `int64`
  * `uint`, `uint8`, `uint16`, `uint32`, `uint64`
  * `float32`, `float64`
  * `uintptr`
  * `string`
* Tipos con alias:
  * `time.Duration`
  * `byte` (`uint8`)
  * `rune` (`int32`)
  * p.ej. `type Enum string`
* Tipos complejos:
  * Struct
  * Mapa
  * Slice
  * Array
  * Puntero

## Validadores

Este paquete proporciona los siguientes validadores.

* Los validadores `eq` (igual), `ne` (diferente), `gt` (mayor que), `lt` (menor que), `gte` (mayor o igual que), `lte` (menor o igual que) comparan un valor numérico de un número o comparan un conteo de elementos en un string, un mapa, un slice o un array.
* El validador `empty` verifica si un string, un mapa, un slice o un array está (no) vacío.
* El validador `nil` verifica si un puntero es (no) nil.
* El validador `one_of` verifica si un número o un string contiene alguno de los elementos dados.
* El validador `format` verifica si un string está en uno de los siguientes formatos: `alpha`, `alnum`, `alpha_unicode`, `alnum_unicode`, `numeric`, `number`, `hexadecimal`, `hexcolor`, `rgb`, `rgba`, `hsl`, `hsla`, `email`, `url`, `uri`, `urn_rfc2141`, `file`, `base64`, `base64url`, `isbn`, `isbn10`, `isbn13`, `eth_addr`, `btc_addr`, `btc_addr_bech32`, `uuid`, `uuid3`, `uuid4`, `uuid5`, `ascii`, `ascii_print`, `datauri`, `latitude`, `longitude`, `ssn`, `ipv4`, `ipv6`, `ip`, `cidrv4`, `cidrv6`, `cidr`, `mac`, `hostname`, `hostname_rfc1123`, `fqdn`, `url_encoded`, `dir`, `postcode`.

## Operadores

Se usan los siguientes operadores. Están listados en orden descendente de precedencia.

* `[]` (corchetes) se usan para validar claves de mapas.
* `>` (signo mayor que) se usa para validar valores de mapas, slices, arrays o para desreferenciar un puntero.


* `&` (ampersand) se usa para ejecutar múltiples validadores usando lógica AND.
* `|` (barra vertical) se usa para ejecutar múltiples validadores usando lógica OR.
* `=` (signo igual) se usa para separar el tipo de validador del valor.
* `,` (coma) se usa para especificar múltiples tokens para un validador (p. ej., `one_of`).

## Uso

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

Vea [GoDoc](https://godoc.org/gopkg.in/dealancer/validate.v2) para la referencia completa.

## Créditos

Este proyecto ha sido escrito por Ben Myrgorod antes de que existieran las herramientas de Vibe Coding. Inspirado por [go-playground/validator](https://github.com/go-playground/validator).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-02

---