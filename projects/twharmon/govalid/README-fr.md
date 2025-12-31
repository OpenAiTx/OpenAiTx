# Govalid

[![](https://goreportcard.com/badge/github.com/twharmon/govalid)](https://goreportcard.com/report/github.com/twharmon/govalid)

Utilisez Govalid pour valider des structures.

## Exemple de base
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

## Valeurs d'erreur
Lorsque vous appelez `govalid.Validate` pour valider une structure, il renvoie une erreur si les règles de validation ne sont pas respectées. Cette erreur peut être soit une erreur spécifique à la validation (une implémentation de `govalid.ValidationError`), soit une autre erreur indiquant un problème lors du traitement de la validation. Cela vous permet de distinguer les erreurs causées par des données invalides de celles causées par des problèmes dans votre logique de validation, comme définir la balise `valid` à `max:not-a-number`.

```go
if err := govalid.Validate(value); err != nil {
	if verr, ok := err.(govalid.ValidationError); ok {
		fmt.Println("validation error", verr)
	} else {
		fmt.Println("some other error", err)
	}
}
```

## Utilisation de Dive
La règle `dive` est utilisée pour appliquer des règles de validation aux éléments à l'intérieur des pointeurs, slices, tableaux et structs. Lorsque la règle `dive` est rencontrée, elle indique au validateur de "plonger" dans les éléments de la collection ou la valeur pointée par un pointeur et d'appliquer les règles restantes à chaque élément ou à la valeur déréférencée.

### Notes
- **Pointeurs** : La règle `dive` va déréférencer le pointeur et appliquer les règles restantes à la valeur pointée.
- **Slices/Tableaux** : La règle `dive` va itérer sur chaque élément du slice ou tableau et appliquer les règles restantes à chaque élément.
- **Structs** : La règle `dive` va valider la struct selon ses propres tags de champ. Les règles restantes après `dive` n'ont pas de sens pour les structs.

### Exemples

#### Pointeurs

```go
type Example struct {
    Field *string `valid:"req|dive|min:3"`
}
```
Dans cet exemple, le champ doit être un pointeur non nil vers une chaîne, et la chaîne doit comporter au moins 3 caractères.

#### Slices/Tableaux
```go
type Example struct {
    Field []string `valid:"req|dive|min:3"`
}
```
Dans cet exemple, le champ doit être une tranche non nulle de chaînes, et chaque chaîne dans la tranche doit comporter au moins 3 caractères.

#### Structures
```go
type Inner struct {
    Name string `valid:"req"`
}

type Outer struct {
    InnerStruct Inner `valid:"dive"`
}
```
Dans cet exemple, le champ InnerStruct sera validé selon les tags de validation définis dans la structure Inner.


## Contribuer

Faites une demande de tirage.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-31

---