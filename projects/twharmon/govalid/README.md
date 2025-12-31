# Govalid

[![](https://goreportcard.com/badge/github.com/twharmon/govalid)](https://goreportcard.com/report/github.com/twharmon/govalid)

Use Govalid to validate structs.

## Basic Example
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

## Error Values
When you call `govalid.Validate` to validate a struct, it returns an error if the validation rules are not met. This error may either be a validation-specific error (an implementation of `govalid.ValidationError`) or a different error indicating a problem in processing the validation. This allows you to distinguish between errors caused by invalid data and those caused by issues in your validation logic, such as setting the `valid` tag to `max:not-a-number`.

```go
if err := govalid.Validate(value); err != nil {
	if verr, ok := err.(govalid.ValidationError); ok {
		fmt.Println("validation error", verr)
	} else {
		fmt.Println("some other error", err)
	}
}
```

## Dive Usage
The `dive` rule is used to apply validation rules to elements within pointers, slices, arrays, and structs. When the `dive` rule is encountered, it instructs the validator to "dive" into the elements of the collection or the value pointed to by a pointer and apply the remaining rules to each element or the dereferenced value.

### Notes
- **Pointers**: The `dive` rule will dereference the pointer and apply the remaining rules to the value it points to.
- **Slices/Arrays**: The `dive` rule will iterate over each element in the slice or array and apply the remaining rules to each element.
- **Structs**: The `dive` rule will validate the struct according to its own field tags. The remaining rules after `dive` have no meaning for structs.

### Examples

#### Pointers

```go
type Example struct {
    Field *string `valid:"req|dive|min:3"`
}
```
In this example, the Field must be a non-nil pointer to a string, and the string must be at least 3 characters long.

#### Slices/Arrays
```go
type Example struct {
    Field []string `valid:"req|dive|min:3"`
}
```
In this example, the Field must be a non-nil slice of strings, and each string in the slice must be at least 3 characters long.

#### Structs
```go
type Inner struct {
    Name string `valid:"req"`
}

type Outer struct {
    InnerStruct Inner `valid:"dive"`
}
```
In this example, the InnerStruct field will be validated according to the validation tags defined in the Inner struct.


## Contribute

Make a pull request.
