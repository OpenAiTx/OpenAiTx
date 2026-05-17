[![GoDoc](https://img.shields.io/badge/godoc-reference-blue.svg)](https://pkg.go.dev/github.com/charlievieth/fastwalk)
[![Test fastwalk on macOS](https://github.com/charlievieth/fastwalk/actions/workflows/macos.yml/badge.svg)](https://github.com/charlievieth/fastwalk/actions/workflows/macos.yml)
[![Test fastwalk on Linux](https://github.com/charlievieth/fastwalk/actions/workflows/linux.yml/badge.svg)](https://github.com/charlievieth/fastwalk/actions/workflows/linux.yml)
[![Test fastwalk on Windows](https://github.com/charlievieth/fastwalk/actions/workflows/windows.yml/badge.svg)](https://github.com/charlievieth/fastwalk/actions/workflows/windows.yml)

# fastwalk

Golang向けの高速並列ディレクトリトラバーサル。

パッケージfastwalkは、[`filepath.WalkDir`](https://pkg.go.dev/io/fs#WalkDirFunc)の高速並列版を提供し、
macOSで約2.5倍、Linuxで約4倍、Windowsで約6倍高速で、
メモリ使用量は50%削減し、メモリアロケーションも25%少なくなっています。
さらに、OSを問わず[godirwalk](https://github.com/karrick/godirwalk)より約4～5倍高速です。

golang.org/x/tools/internal/fastwalk（https://pkg.go.dev/golang.org/x/tools@v0.1.9/internal/fastwalk）に触発され、そこから派生しています。

## 特徴

* 高速：複数のゴルーチンがファイルシステムのstatを行い、[`filepath.WalkDirFunc`](https://pkg.go.dev/io/fs#WalkDirFunc)のコールバックを並行して呼び出します
* 安全なシンボリックリンクのトラバーサル（[`Config.Follow`](https://pkg.go.dev/github.com/charlievieth/fastwalk#Config)）
* [`filepath.WalkDir`](https://pkg.go.dev/path/filepath#WalkDir)と同じ動作およびコールバックシグネチャ
* 重複ファイルやディレクトリを無視するラッパー関数を提供：
	[`IgnoreDuplicateFiles()`](https://pkg.go.dev/github.com/charlievieth/fastwalk#IgnoreDuplicateFiles)
	および
	[`IgnoreDuplicateDirs()`](https://pkg.go.dev/github.com/charlievieth/fastwalk#IgnoreDuplicateDirs)
* macOS、Linux、Windowsで広範にテスト済み

## 使い方

使い方は[`filepath.WalkDir`](https://pkg.go.dev/io/fs#WalkDirFunc)と同じですが、
[`fastwalk.Walk`](https://pkg.go.dev/github.com/charlievieth/fastwalk#Walk)の[`walkFn`](https://pkg.go.dev/path/filepath@go1.17.7#WalkFunc)引数は並行使用に安全である必要があります。

サンプルは[examples](./examples)ディレクトリにあります。

<!-- TODO: this example is large move it to an examples folder -->





以下の例は、POSIXの非常に簡単なバージョンの
[find](https://pubs.opengroup.org/onlinepubs/007904975/utilities/find.html)ユーティリティです：
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

## ベンチマーク

ベンチマークは `go1.17.6` を使用して作成されており、`bench_comp` メイクターゲットで生成できます：
```sh
$ make bench_comp
```

### ダーウィン

**ハードウェア:**
```
goos: darwin
goarch: arm64
cpu: Apple M1 Max
```

#### [`filepath.WalkDir`](https://pkg.go.dev/path/filepath@go1.17.7#WalkDir) と [`fastwalk.Walk()`](https://pkg.go.dev/github.com/charlievieth/fastwalk#Walk) の比較:
```
              filepath       fastwalk       delta
time/op       27.9ms ± 1%    13.0ms ± 1%    -53.33%
alloc/op      4.33MB ± 0%    2.14MB ± 0%    -50.55%
allocs/op     50.9k ± 0%     37.7k ± 0%     -26.01%
```

#### [`godirwalk.Walk()`](https://pkg.go.dev/github.com/karrick/godirwalk@v1.16.1#Walk) と [`fastwalk.Walk()`](https://pkg.go.dev/github.com/charlievieth/fastwalk#Walk):
```
              godirwalk      fastwalk       delta
time/op       58.5ms ± 3%    18.0ms ± 2%    -69.30%
alloc/op      25.3MB ± 0%    2.1MB ± 0%     -91.55%
allocs/op     57.6k ± 0%     37.7k ± 0%     -34.59%
```

### Linux

**ハードウェア：**
```
goos: linux
goarch: amd64
cpu: Intel(R) Core(TM) i9-9900K CPU @ 3.60GHz
drive: Samsung SSD 970 PRO 1TB
```

#### [`filepath.WalkDir`](https://pkg.go.dev/path/filepath@go1.17.7#WalkDir) と [`fastwalk.Walk()`](https://pkg.go.dev/github.com/charlievieth/fastwalk#Walk) の比較:

```
              filepath       fastwalk       delta
time/op       10.1ms ± 2%    2.8ms ± 2%     -72.83%
alloc/op      2.44MB ± 0%    1.70MB ± 0%    -30.46%
allocs/op     47.2k ± 0%     36.9k ± 0%     -21.80%
```

#### [`godirwalk.Walk()`](https://pkg.go.dev/github.com/karrick/godirwalk@v1.16.1#Walk) と [`fastwalk.Walk()`](https://pkg.go.dev/github.com/charlievieth/fastwalk#Walk) の比較:

```
              filepath       fastwalk       delta
time/op       13.7ms ±16%    2.8ms ± 2%     -79.88%
alloc/op      7.48MB ± 0%    1.70MB ± 0%    -77.34%
allocs/op     53.8k ± 0%     36.9k ± 0%     -31.38%
```

### Windows

**ハードウェア:**
```
goos: windows
goarch: amd64
pkg: github.com/charlievieth/fastwalk
cpu: Intel(R) Core(TM) i9-9900K CPU @ 3.60GHz
```

#### [`filepath.WalkDir`](https://pkg.go.dev/path/filepath@go1.17.7#WalkDir) と [`fastwalk.Walk()`](https://pkg.go.dev/github.com/charlievieth/fastwalk#Walk) の比較:

```
              filepath       fastwalk       delta
time/op       88.0ms ± 1%    14.6ms ± 1%    -83.47%
alloc/op      5.68MB ± 0%    6.76MB ± 0%    +19.01%
allocs/op     69.6k ± 0%     90.4k ± 0%     +29.87%
```

#### [`godirwalk.Walk()`](https://pkg.go.dev/github.com/karrick/godirwalk@v1.16.1#Walk) と [`fastwalk.Walk()`](https://pkg.go.dev/github.com/charlievieth/fastwalk#Walk):

```
              filepath       fastwalk       delta
time/op       87.4ms ± 1%    14.6ms ± 1%    -83.34%
alloc/op      6.14MB ± 0%    6.76MB ± 0%    +10.24%
allocs/op     100k ± 0%      90k ± 0%       -9.59%
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-17

---