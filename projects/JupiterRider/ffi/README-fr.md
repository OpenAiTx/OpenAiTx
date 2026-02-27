# ffi
[![Go Reference](https://pkg.go.dev/badge/github.com/jupiterrider/ffi.svg)](https://pkg.go.dev/github.com/jupiterrider/ffi)

Une liaison purego pour libffi.

## Objectif
Vous pouvez utiliser [purego](https://github.com/ebitengine/purego) pour appeler du code C sans cgo. ffi fournit des fonctionnalités supplémentaires (par exemple passer et retourner des structures par valeur).

## OS/Architecture supportés
- darwin/amd64
- darwin/arm64
- freebsd/amd64
- freebsd/arm64
- linux/amd64
- linux/arm64
- linux/riscv64
- windows/amd64
- windows/arm64

## Exigences logicielles
[libffi](https://github.com/libffi/libffi) est préinstallé sur la plupart des distributions, car il est aussi une dépendance de Python et Ruby. Sinon, vous pouvez l’installer explicitement :

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
Note : Utilisez ce flag de build `-gcflags="github.com/ebitengine/purego/internal/fakecgo=-std"` lors de la compilation croisée ou si CGO_ENABLED est défini à 0 (FreeBSD uniquement).

### Windows
La version AMD64 de libffi est déjà intégrée dans cette bibliothèque et est extraite et chargée à l'exécution. Cette fonctionnalité peut être désactivée en utilisant le tag de build `ffi_no_embed` ou la variable d'environnement `FFI_NO_EMBED=1`.

### macOS
Aucune exigence supplémentaire. Les binaires libffi sont également intégrés.

## Exemples
Dans cet exemple, nous créons notre propre bibliothèque, qui se compose de deux définitions de type et d'une fonction :

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

Compilez le code en une bibliothèque partagée :

```sh
gcc -shared -o libitem.so -fPIC item.c
```

Le code Go consommateur :

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

Vous pouvez trouver plus d'exemples dans le dossier [examples](examples) de ce dépôt.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-27

---