[![GoDoc](https://img.shields.io/badge/godoc-reference-blue.svg)](https://pkg.go.dev/github.com/charlievieth/fastwalk)
[![Test fastwalk on macOS](https://github.com/charlievieth/fastwalk/actions/workflows/macos.yml/badge.svg)](https://github.com/charlievieth/fastwalk/actions/workflows/macos.yml)
[![Test fastwalk on Linux](https://github.com/charlievieth/fastwalk/actions/workflows/linux.yml/badge.svg)](https://github.com/charlievieth/fastwalk/actions/workflows/linux.yml)
[![Test fastwalk on Windows](https://github.com/charlievieth/fastwalk/actions/workflows/windows.yml/badge.svg)](https://github.com/charlievieth/fastwalk/actions/workflows/windows.yml)

# fastwalk

Golang을 위한 빠른 병렬 디렉터리 탐색기.

fastwalk 패키지는 [`filepath.WalkDir`](https://pkg.go.dev/io/fs#WalkDirFunc)의 빠른 병렬 버전을 제공하며,
macOS에서는 약 2.5배, Linux에서는 약 4배, Windows에서는 약 6배 더 빠르고,
메모리 할당은 50% 적으며, 메모리 할당 횟수는 25% 적게 요구합니다.
또한, OS 전반에 걸쳐 [godirwalk](https://github.com/karrick/godirwalk)보다 약 4-5배 빠릅니다.

[golang.org/x/tools/internal/fastwalk](https://pkg.go.dev/golang.org/x/tools@v0.1.9/internal/fastwalk)에서 영감을 받고 기반하여 작성되었습니다.

## 특징

* 빠름: 여러 고루틴이 파일 시스템 상태를 확인하고
  [`filepath.WalkDirFunc`](https://pkg.go.dev/io/fs#WalkDirFunc) 콜백을 동시에 호출
* 안전한 심볼릭 링크 탐색 ([`Config.Follow`](https://pkg.go.dev/github.com/charlievieth/fastwalk#Config))
* [`filepath.WalkDir`](https://pkg.go.dev/path/filepath#WalkDir)와 동일한 동작 및 콜백 시그니처
* 중복 파일과 디렉터리를 무시하는 래퍼 함수 제공:
	[`IgnoreDuplicateFiles()`](https://pkg.go.dev/github.com/charlievieth/fastwalk#IgnoreDuplicateFiles)
	및
	[`IgnoreDuplicateDirs()`](https://pkg.go.dev/github.com/charlievieth/fastwalk#IgnoreDuplicateDirs)
* macOS, Linux, Windows에서 광범위하게 테스트됨

## 사용법

사용법은 [`filepath.WalkDir`](https://pkg.go.dev/io/fs#WalkDirFunc)와 같지만,
[`fastwalk.Walk`](https://pkg.go.dev/github.com/charlievieth/fastwalk#Walk)에 전달되는 [`walkFn`](https://pkg.go.dev/path/filepath@go1.17.7#WalkFunc) 인자는 동시 사용에 안전해야 합니다.

예제는 [examples](./examples) 디렉터리에서 확인할 수 있습니다.

<!-- TODO: 이 예제는 크므로 examples 폴더로 이동하세요 -->




아래 예제는 POSIX의 매우 간단한 버전의  
[find](https://pubs.opengroup.org/onlinepubs/007904975/utilities/find.html) 유틸리티입니다:
```go
// fwfind is a an example program that is similar to POSIX find,
// but faster and worse (it's an example).
package main

import (
	"flag"
	"fmt"
	"io/fs"
	"os"
	"path/filepath"

	"github.com/charlievieth/fastwalk"
)

const usageMsg = `Usage: %[1]s [-L] [-name] [PATH...]:

%[1]s is a poor replacement for the POSIX find utility

`

func main() {
	flag.Usage = func() {
		fmt.Fprintf(os.Stdout, usageMsg, filepath.Base(os.Args[0]))
		flag.PrintDefaults()
	}
	pattern := flag.String("name", "", "Pattern to match file names against.")
	followLinks := flag.Bool("L", false, "Follow symbolic links")
	flag.Parse()

	// If no paths are provided default to the current directory: "."
	args := flag.Args()
	if len(args) == 0 {
		args = append(args, ".")
	}

	// Follow links if the "-L" flag is provided
	conf := fastwalk.Config{
		Follow: *followLinks,
	}

	walkFn := func(path string, d fs.DirEntry, err error) error {
		if err != nil {
			fmt.Fprintf(os.Stderr, "%s: %v\n", path, err)
			return nil // returning the error stops iteration
		}
		if *pattern != "" {
			if ok, err := filepath.Match(*pattern, d.Name()); !ok {
				// invalid pattern (err != nil) or name does not match
				return err
			}
		}
		_, err = fmt.Println(path)
		return err
	}
	for _, root := range args {
		if err := fastwalk.Walk(&conf, root, walkFn); err != nil {
			fmt.Fprintf(os.Stderr, "%s: %v\n", root, err)
			os.Exit(1)
		}
	}
}
```

## 벤치마크

벤치마크는 `go1.17.6`을 사용하여 생성되었으며 `bench_comp` 메이크 타겟으로 생성할 수 있습니다:
```sh
$ make bench_comp
```

### 다윈

**하드웨어:**
```
goos: darwin
goarch: arm64
cpu: Apple M1 Max
```

#### [`filepath.WalkDir`](https://pkg.go.dev/path/filepath@go1.17.7#WalkDir) 대 [`fastwalk.Walk()`](https://pkg.go.dev/github.com/charlievieth/fastwalk#Walk):
```
              filepath       fastwalk       delta
time/op       27.9ms ± 1%    13.0ms ± 1%    -53.33%
alloc/op      4.33MB ± 0%    2.14MB ± 0%    -50.55%
allocs/op     50.9k ± 0%     37.7k ± 0%     -26.01%
```

#### [`godirwalk.Walk()`](https://pkg.go.dev/github.com/karrick/godirwalk@v1.16.1#Walk) vs. [`fastwalk.Walk()`](https://pkg.go.dev/github.com/charlievieth/fastwalk#Walk):
```
              godirwalk      fastwalk       delta
time/op       58.5ms ± 3%    18.0ms ± 2%    -69.30%
alloc/op      25.3MB ± 0%    2.1MB ± 0%     -91.55%
allocs/op     57.6k ± 0%     37.7k ± 0%     -34.59%
```

### 리눅스

**하드웨어:**
```
goos: linux
goarch: amd64
cpu: Intel(R) Core(TM) i9-9900K CPU @ 3.60GHz
drive: Samsung SSD 970 PRO 1TB
```

#### [`filepath.WalkDir`](https://pkg.go.dev/path/filepath@go1.17.7#WalkDir) 대 [`fastwalk.Walk()`](https://pkg.go.dev/github.com/charlievieth/fastwalk#Walk):

```
              filepath       fastwalk       delta
time/op       10.1ms ± 2%    2.8ms ± 2%     -72.83%
alloc/op      2.44MB ± 0%    1.70MB ± 0%    -30.46%
allocs/op     47.2k ± 0%     36.9k ± 0%     -21.80%
```

#### [`godirwalk.Walk()`](https://pkg.go.dev/github.com/karrick/godirwalk@v1.16.1#Walk) vs. [`fastwalk.Walk()`](https://pkg.go.dev/github.com/charlievieth/fastwalk#Walk):

```
              filepath       fastwalk       delta
time/op       13.7ms ±16%    2.8ms ± 2%     -79.88%
alloc/op      7.48MB ± 0%    1.70MB ± 0%    -77.34%
allocs/op     53.8k ± 0%     36.9k ± 0%     -31.38%
```

### 윈도우

**하드웨어:**
```
goos: windows
goarch: amd64
pkg: github.com/charlievieth/fastwalk
cpu: Intel(R) Core(TM) i9-9900K CPU @ 3.60GHz
```

#### [`filepath.WalkDir`](https://pkg.go.dev/path/filepath@go1.17.7#WalkDir) 대 [`fastwalk.Walk()`](https://pkg.go.dev/github.com/charlievieth/fastwalk#Walk):

```
              filepath       fastwalk       delta
time/op       88.0ms ± 1%    14.6ms ± 1%    -83.47%
alloc/op      5.68MB ± 0%    6.76MB ± 0%    +19.01%
allocs/op     69.6k ± 0%     90.4k ± 0%     +29.87%
```

#### [`godirwalk.Walk()`](https://pkg.go.dev/github.com/karrick/godirwalk@v1.16.1#Walk) 대 [`fastwalk.Walk()`](https://pkg.go.dev/github.com/charlievieth/fastwalk#Walk):

```
              filepath       fastwalk       delta
time/op       87.4ms ± 1%    14.6ms ± 1%    -83.34%
alloc/op      6.14MB ± 0%    6.76MB ± 0%    +10.24%
allocs/op     100k ± 0%      90k ± 0%       -9.59%
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-17

---