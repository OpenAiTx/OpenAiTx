# ffi
[![Referencia Go](https://pkg.go.dev/badge/github.com/jupiterrider/ffi.svg)](https://pkg.go.dev/github.com/jupiterrider/ffi)

Un enlace purego para libffi.

## Propósito
Puedes usar [purego](https://github.com/ebitengine/purego) para llamar código C sin cgo. ffi proporciona funcionalidades adicionales (por ejemplo, pasar y retornar estructuras por valor).

## Sistemas Operativos/Arquitecturas Soportados
- darwin/amd64
- darwin/arm64
- freebsd/amd64
- freebsd/arm64
- linux/amd64
- linux/arm64
- linux/riscv64
- windows/amd64
- windows/arm64

## Requisitos de Software
[libffi](https://github.com/libffi/libffi) está preinstalado en la mayoría de las distribuciones, porque también es una dependencia de Python y Ruby. Si no, puedes instalarlo explícitamente:

### Arch Linux
```sh
sudo pacman -S libffi
```
### Debian, Ubuntu

```sh
sudo apt install libffi8
```

### Fedora
```sh
sudo dnf install libffi
```

### FreeBSD
```sh
pkg install libffi
```
Nota: Use esta bandera de compilación `-gcflags="github.com/ebitengine/purego/internal/fakecgo=-std"` al compilar de forma cruzada o si CGO_ENABLED está establecido en 0 (solo FreeBSD).

### Windows
La versión AMD64 de libffi ya está incrustada en esta biblioteca y se extrae y carga en tiempo de ejecución. Esta función puede desactivarse usando la etiqueta de compilación `ffi_no_embed` o la variable de entorno `FFI_NO_EMBED=1`.

### macOS
No se requieren más requisitos. Los binarios de libffi también están incrustados.

## Ejemplos
En este ejemplo creamos nuestra propia biblioteca, que consiste en dos definiciones de tipo y una función:

```c
#include <stdbool.h>
#include <string.h>

typedef enum {
    GROCERIES,
    HOUSEHOLD,
    BEAUTY
} Category;

typedef struct {
    const char *name;
    double price;
    Category category;
} Item;

bool IsItemValid(Item item)
{
    if (!item.name || strlen(item.name) == 0)
    {
        return false;
    }

    if (item.price < 0)
    {
        return false;
    }

    if (item.category > BEAUTY)
    {
        return false;
    }

    return true;
}
```
Compilar el código en una biblioteca compartida:


```sh
gcc -shared -o libitem.so -fPIC item.c
```

El código Go que consume:

```golang
package main

import (
	"fmt"

	"github.com/jupiterrider/ffi"
)

type Category uint32

const (
	Groceries Category = iota
	Household
	Beauty
)

type Item struct {
	Name     *byte
	Price    float64
	Category Category
}

func main() {
	// load the library
	lib, err := ffi.Load("./libitem.so")
	if err != nil {
		panic(err)
	}

	// create a new ffi.Type which defines the fields of the Item struct
	typeItem := ffi.NewType(&ffi.TypePointer, &ffi.TypeDouble, &ffi.TypeUint32)

	// get the IsItemValid function and describe its signature
	// (for bool we use ffi.TypeUint8)
	isItemValid, err := lib.Prep("IsItemValid", &ffi.TypeUint8, &typeItem)
	if err != nil {
		panic(err)
	}

	var item Item
	// strings are null-terminated and converted into a byte pointer
	item.Name = &[]byte("Apple\x00")[0]
	item.Price = 0.22
	item.Category = Groceries

	// the return value is stored in a 64-bit integer type, because libffi
	// cannot handle smaller integer types as return value
	var result ffi.Arg

	// call the C function
	// (keep in mind that you have to pass pointers and not the values themselves)
	isItemValid.Call(&result, &item)

	if result.Bool() {
		fmt.Println("Item is valid!")
	} else {
		fmt.Println("Item is not valid!")
	}
}
```

Puedes encontrar más ejemplos dentro de la carpeta [examples](examples) de este repositorio.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-27

---