# ffi
[![Go Reference](https://pkg.go.dev/badge/github.com/jupiterrider/ffi.svg)](https://pkg.go.dev/github.com/jupiterrider/ffi)

libffi를 위한 purego 바인딩입니다.

## 목적
[cgo 없이](https://github.com/ebitengine/purego) C 코드를 호출하기 위해 purego를 사용할 수 있습니다. ffi는 추가 기능(예: 값으로 구조체 전달 및 반환)을 제공합니다.

## 지원 OS/아키텍처
- darwin/amd64
- darwin/arm64
- freebsd/amd64
- freebsd/arm64
- linux/amd64
- linux/arm64
- linux/riscv64
- windows/amd64
- windows/arm64

## 소프트웨어 요구사항
[libffi](https://github.com/libffi/libffi)는 Python과 Ruby의 의존성이기 때문에 대부분의 배포판에 사전 설치되어 있습니다. 설치되어 있지 않다면 명시적으로 설치할 수 있습니다:

### Arch Linux
```sh
sudo pacman -S libffi
```
### 데비안, 우분투

```sh
sudo apt install libffi8
```

### 페도라
```sh
sudo dnf install libffi
```

### FreeBSD
```sh
pkg install libffi
```
참고: 교차 컴파일 시 또는 CGO_ENABLED가 0으로 설정된 경우(FreeBSD 전용) 이 `-gcflags="github.com/ebitengine/purego/internal/fakecgo=-std"` 빌드 플래그를 사용하세요.

### Windows
libffi의 AMD64 버전은 이미 이 라이브러리에 내장되어 있으며 런타임에 추출되어 로드됩니다. 이 기능은 빌드 태그 `ffi_no_embed` 또는 환경 변수 `FFI_NO_EMBED=1`을 사용하여 비활성화할 수 있습니다.

### macOS
추가 요구 사항이 없습니다. libffi 바이너리도 함께 내장되어 있습니다.

## 예제
이 예제에서는 두 개의 타입 정의와 하나의 함수로 구성된 자체 라이브러리를 만듭니다:

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

코드를 공유 라이브러리로 컴파일하십시오:

```sh
gcc -shared -o libitem.so -fPIC item.c
```

소비하는 Go 코드:

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

이 저장소의 [examples](examples) 폴더 안에서 더 많은 예제를 찾을 수 있습니다.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-27

---