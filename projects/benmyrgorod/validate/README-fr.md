# validate
[![Build Status](https://travis-ci.org/dealancer/validate.svg?branch=v2)](https://travis-ci.org/dealancer/validate)
[![codecov](https://codecov.io/gh/dealancer/validate/branch/v2/graph/badge.svg)](https://codecov.io/gh/dealancer/validate)
[![Go Report Card](https://goreportcard.com/badge/gopkg.in/dealancer/validate.v2)](https://goreportcard.com/report/gopkg.in/dealancer/validate.v2)
[![GoDoc](https://godoc.org/gopkg.in/dealancer/validate.v2?status.svg)](https://godoc.org/gopkg.in/dealancer/validate.v2)
[![GitHub release](https://img.shields.io/github/release/dealancer/validate.svg)](https://github.com/dealancer/validate/releases)
[![License](https://img.shields.io/github/license/dealancer/validate.svg)](./LICENSE)

Le package **validate** valide récursivement les structures Go et les types basés sur des tags.
Il fournit une syntaxe puissante pour effectuer la validation des sous-structures, des maps, des slices, des tableaux et des pointeurs. Le package permet également d'exécuter des méthodes de validation personnalisées.

Utilisez ce package pour vous assurer que le contenu de la structure est au format dont vous avez besoin.
Par exemple, le package **validate** est utile lors du déchargement de YAML ou JSON.

## Installation

1. Utilisez `go get` pour télécharger le package validate.
   ```
   go get gopkg.in/dealancer/validate.v2
   ```
2. Importez le package validate dans votre projet.
   ```go
   import "gopkg.in/dealancer/validate.v2"
   ```
## Types

Ce package prend en charge une grande variété de types.

* La plupart des types intégrés :
  * `int`, `int8` `int16`, `int32`, `int64`
  * `uint`, `uint8`, `uint16`, `uint32`, `uint64`
  * `float32`, `float64`
  * `uintptr`
  * `string`
* Types aliasés :
  * `time.Duration`
  * `byte` (`uint8`)
  * `rune` (`int32`)
  * par ex. `type Enum string`
* Types complexes :
  * Struct
  * Map
  * Slice
  * Array
  * Pointer

## Validateurs

Ce package fournit les validateurs suivants.

* Les validateurs `eq` (égal), `ne` (différent), `gt` (plus grand que), `lt` (plus petit que), `gte` (plus grand ou égal à), `lte` (plus petit ou égal à) comparent une valeur numérique d’un nombre ou comparent un nombre d’éléments dans une chaîne, une map, un slice, ou un tableau.
* Le validateur `empty` vérifie si une chaîne, une map, un slice, ou un tableau est (non) vide.
* Le validateur `nil` vérifie si un pointeur est (non) nil.
* Le validateur `one_of` vérifie si un nombre ou une chaîne contient un des éléments donnés.
* Le validateur `format` vérifie si une chaîne est dans un des formats suivants : `alpha`, `alnum`, `alpha_unicode`, `alnum_unicode`, `numeric`, `number`, `hexadecimal`, `hexcolor`, `rgb`, `rgba`, `hsl`, `hsla`, `email`, `url`, `uri`, `urn_rfc2141`, `file`, `base64`, `base64url`, `isbn`, `isbn10`, `isbn13`, `eth_addr`, `btc_addr`, `btc_addr_bech32`, `uuid`, `uuid3`, `uuid4`, `uuid5`, `ascii`, `ascii_print`, `datauri`, `latitude`, `longitude`, `ssn`, `ipv4`, `ipv6`, `ip`, `cidrv4`, `cidrv6`, `cidr`, `mac`, `hostname`, `hostname_rfc1123`, `fqdn`, `url_encoded`, `dir`, `postcode`.

## Opérateurs

Les opérateurs suivants sont utilisés. Ils sont listés dans l’ordre décroissant de leur priorité.

* `[]` (crochets) sont utilisés pour valider les clés de map.
* `>` (signe supérieur) est utilisé pour valider les valeurs des maps, slices, tableaux ou pour déréférencer un pointeur.


* `&` (esperluette) est utilisé pour effectuer plusieurs validations avec une logique ET.
* `|` (barre verticale) est utilisé pour effectuer plusieurs validations avec une logique OU.
* `=` (signe égal) est utilisé pour séparer le type de validateur de la valeur.
* `,` (virgule) est utilisé pour spécifier plusieurs jetons pour un validateur (par exemple `one_of`).

## Utilisation

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

Voir [GoDoc](https://godoc.org/gopkg.in/dealancer/validate.v2) pour la référence complète.

## Crédits

Ce projet a été écrit par Ben Myrgorod avant l'existence des outils Vibe Coding. Inspiré par [go-playground/validator](https://github.com/go-playground/validator).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-02

---