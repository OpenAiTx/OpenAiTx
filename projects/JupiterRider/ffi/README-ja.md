# ffi
[![Go Reference](https://pkg.go.dev/badge/github.com/jupiterrider/ffi.svg)](https://pkg.go.dev/github.com/jupiterrider/ffi)

libffi の purego バインディング。

## 目的
[cgo を使わずに C コードを呼び出すために、[purego](https://github.com/ebitengine/purego) を使用できます。ffi は、構造体の値渡しなどの追加機能を提供します。

## 対応 OS/アーキテクチャ
- darwin/amd64
- darwin/arm64
- freebsd/amd64
- freebsd/arm64
- linux/amd64
- linux/arm64
- linux/riscv64
- windows/amd64
- windows/arm64

## ソフトウェア要件
[libffi](https://github.com/libffi/libffi) は、Python や Ruby の依存関係でもあるため、ほとんどのディストリビューションにプリインストールされています。インストールされていない場合は、明示的にインストールできます。

### Arch Linux
```sh
sudo pacman -S libffi
```
### Debian、Ubuntu

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
注意: クロスコンパイル時や CGO_ENABLED を 0 に設定している場合（FreeBSD のみ）には、ビルドフラグ `-gcflags="github.com/ebitengine/purego/internal/fakecgo=-std"` を使用してください。

### Windows
libffi の AMD64 バージョンはすでにこのライブラリに組み込まれており、実行時に抽出されてロードされます。この機能はビルドタグ `ffi_no_embed` または環境変数 `FFI_NO_EMBED=1` を使って無効化できます。

### macOS
追加の要件はありません。libffi のバイナリも組み込まれています。

## Examples
この例では、2つの型定義と1つの関数からなる独自のライブラリを作成します：

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

コードを共有ライブラリにコンパイルする: 

```sh
gcc -shared -o libitem.so -fPIC item.c
```

消費するGoコード:

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
このリポジトリの[examples](examples)フォルダ内にさらに多くの例があります。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-27

---