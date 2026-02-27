# ffi
[![Go Reference](https://pkg.go.dev/badge/github.com/jupiterrider/ffi.svg)](https://pkg.go.dev/github.com/jupiterrider/ffi)

一个纯 Go 绑定的 libffi。

## 目的
你可以使用 [purego](https://github.com/ebitengine/purego) 调用 C 代码而无需 cgo。ffi 提供了额外的功能（例如按值传递和返回结构体）。

## 支持的操作系统/架构
- darwin/amd64
- darwin/arm64
- freebsd/amd64
- freebsd/arm64
- linux/amd64
- linux/arm64
- linux/riscv64
- windows/amd64
- windows/arm64

## 软件要求
[libffi](https://github.com/libffi/libffi) 在大多数发行版中已预装，因为它也是 Python 和 Ruby 的依赖项。如果没有，你可以显式安装它：

### Arch Linux
```sh
sudo pacman -S libffi
```

### Debian，Ubuntu
```sh
sudo apt install libffi8
```

### 费多拉
```sh
sudo dnf install libffi
```

### FreeBSD
```sh
pkg install libffi
```
注意：交叉编译或设置 CGO_ENABLED 为 0（仅限 FreeBSD）时，请使用此 `-gcflags="github.com/ebitengine/purego/internal/fakecgo=-std"` 构建标志。

### Windows
AMD64 版本的 libffi 已嵌入此库中，并在运行时提取和加载。此功能可通过使用构建标签 `ffi_no_embed` 或环境变量 `FFI_NO_EMBED=1` 禁用。

### macOS
无其他要求。libffi 二进制文件也已嵌入。

## 示例
在此示例中，我们创建自己的库，该库包含两个类型定义和一个函数：

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

将代码编译成共享库：

```sh
gcc -shared -o libitem.so -fPIC item.c
```

使用的 Go 代码：

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
您可以在此代码库的 [examples](examples) 文件夹中找到更多示例。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-27

---