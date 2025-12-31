# Govalid

[![](https://goreportcard.com/badge/github.com/twharmon/govalid)](https://goreportcard.com/report/github.com/twharmon/govalid)

Usa Govalid para validar estructuras.

## Ejemplo Básico
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

## Valores de Error
Cuando llamas a `govalid.Validate` para validar una estructura, devuelve un error si no se cumplen las reglas de validación. Este error puede ser un error específico de validación (una implementación de `govalid.ValidationError`) o un error diferente que indica un problema en el procesamiento de la validación. Esto te permite distinguir entre errores causados por datos inválidos y aquellos causados por problemas en tu lógica de validación, como establecer la etiqueta `valid` en `max:not-a-number`.

```go
if err := govalid.Validate(value); err != nil {
	if verr, ok := err.(govalid.ValidationError); ok {
		fmt.Println("validation error", verr)
	} else {
		fmt.Println("some other error", err)
	}
}
```
## Uso de Dive
La regla `dive` se utiliza para aplicar reglas de validación a elementos dentro de punteros, slices, arrays y structs. Cuando se encuentra la regla `dive`, indica al validador que "se sumerja" en los elementos de la colección o en el valor apuntado por un puntero y aplique las reglas restantes a cada elemento o al valor desreferenciado.

### Notas
- **Punteros**: La regla `dive` desreferenciará el puntero y aplicará las reglas restantes al valor al que apunta.
- **Slices/Arrays**: La regla `dive` iterará sobre cada elemento del slice o array y aplicará las reglas restantes a cada elemento.
- **Structs**: La regla `dive` validará el struct según sus propias etiquetas de campo. Las reglas restantes después de `dive` no tienen significado para structs.

### Ejemplos

#### Punteros


```go
type Example struct {
    Field *string `valid:"req|dive|min:3"`
}
```
En este ejemplo, el Campo debe ser un puntero no nulo a una cadena, y la cadena debe tener al menos 3 caracteres.

#### Slices/Arrays
```go
type Example struct {
    Field []string `valid:"req|dive|min:3"`
}
```
En este ejemplo, el Campo debe ser una slice de cadenas no nula, y cada cadena en la slice debe tener al menos 3 caracteres de longitud.

#### Estructuras
```go
type Inner struct {
    Name string `valid:"req"`
}

type Outer struct {
    InnerStruct Inner `valid:"dive"`
}
```
En este ejemplo, el campo InnerStruct será validado según las etiquetas de validación definidas en la estructura Inner.


## Contribuir

Hacer una solicitud de extracción.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-31

---