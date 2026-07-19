
<div align="right">
  <details>
    <summary >🌐 Bahasa</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

## Apa itu?

[![CI](https://github.com/dronnix/bwarr/actions/workflows/ci.yml/badge.svg)](https://github.com/dronnix/bwarr/actions)
[![codecov](https://codecov.io/gh/dronnix/bwarr/branch/main/graph/badge.svg)](https://codecov.io/gh/dronnix/bwarr)
[![Go Reference](https://pkg.go.dev/badge/github.com/dronnix/bwarr.svg)](https://pkg.go.dev/github.com/dronnix/bwarr)
[![Go Report Card](https://goreportcard.com/badge/github.com/dronnix/bwarr)](https://goreportcard.com/report/github.com/dronnix/bwarr)

Black-White Array (dikenal juga sebagai BWArr) adalah struktur data cepat dan terurut berbasis array dengan ***$O(\log N)$*** **alokasi memori**.

## Struktur Data
Ide Black-White Array ditemukan dan dipublikasikan oleh profesor [Z. George Mou](https://www.cs.brandeis.edu/~mou/) dalam [Black-White Array: A New Data Structure for Dynamic Data Sets](https://arxiv.org/abs/2004.09051). Repositori ini berisi implementasi publik pertama.

![Profesor Z. George Mou](https://www.cs.brandeis.edu/~mou/mou.gif)

### Fitur utama:
- Alokasi memori $O(\log N)$ untuk Insert - tidak membebani GC;
- Operasi insert, delete, dan search cepat dengan kompleksitas waktu rata-rata $O(\log N)$;
- Berbasis array dan tanpa pointer membuatnya ramah CPU: cache locality / iterasi berurutan / dll;
- Mendukung elemen duplikat secara native (perilaku multiset) - tidak perlu membungkus nilai dalam struct agar unik;
- Dapat langsung menggantikan `github.com/google/btree` dan `github.com/petar/GoLLRB`;
- Overhead memori rendah - tanpa pointer per elemen, representasi memori yang ringkas;
- Mudah untuk diserialisasi;

### Kompromi
- Satu dari setiap $N$ operasi insert memiliki kompleksitas $O(N)$, meskipun rata-ratanya tetap $O(\log N)$. Untuk sistem real-time, hal ini dapat menyebabkan lonjakan latensi pada koleksi dengan jutaan elemen. Dapat diatasi dengan insert async/background.
- Untuk jumlah elemen kecil, operasi `Search()/Delete()` dapat memakan waktu $O((\log N)^2)$. 50% elemen memerlukan waktu $O(\log N)$, 75%  - $O(2\log N)$, 87.5% - $O(3\log N)$, dst.
- Ketika menghapus serangkaian elemen yang panjang, operasi `Max()/Min()` dapat memakan waktu $O(N/4)$. Kompleksitas rata-rata untuk serangkaian pemanggilan tetap $O(\log N)$.
- Ketika menghapus serangkaian elemen yang panjang, langkah iterasi dapat memakan waktu $O(N/4)$. Kompleksitas rata-rata untuk iterasi seluruh koleksi tetap $O(\log N)$ per elemen.

### Kasus penggunaan
Koleksi in-memory dengan rasio baca-tulis 1:1 < r:w < 10:1. BWArr dioptimalkan untuk proses insert dan delete yang intensif (dengan alokasi dan fragmentasi rendah), namun tetap menyediakan pencarian dan iterasi yang cepat.

###  Benchmark

Benchmark dibandingkan dengan [Google BTree](https://github.com/google/btree).

#### Insert 
Mengukur waktu, alokasi, dan KB yang dialokasikan untuk menyisipkan N nilai int64 acak unik ke dalam struktur data kosong. Baik BWArr maupun BTree mulai dari kosong dan menyisipkan semua nilai satu per satu.

![Performa Insert](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_unique_values.png?raw=true)
![Insert Allocs](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_unique_values_allocs.png?raw=true)
![Insert Alloc_Bytes](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_unique_values_bytes.png?raw=true)

Alokasi pada nilai yang lebih kecil:

![Insert Allocs kecil](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_performance_allocs_detailed.png?raw=true)



#### Get 
Mengukur waktu untuk mencari N nilai berdasarkan kunci mereka dalam struktur data yang telah diisi sebelumnya. Struktur data diisi dengan semua nilai sebelum pengukuran waktu dimulai, lalu setiap nilai diambil berdasarkan kunci.

![Kinerja Get](https://github.com/dronnix/bwarr-bench/blob/main/images/get_all_values_by_key.png?raw=true)

#### Iterate
Mengukur waktu untuk mengiterasi semua N nilai dalam urutan terurut dan tidak terurut.
![Kinerja Iterate Terurut](https://github.com/dronnix/bwarr-bench/blob/main/images/ordered_iteration_over_all_values.png?raw=true)
![Kinerja Iterate Tidak Terurut](https://github.com/dronnix/bwarr-bench/blob/main/images/unordered_iteration_over_all_values.png?raw=true)

#### Benchmark Lainnya
Benchmark tambahan dan detail tersedia di repositori [bwarr-bench](https://github.com/dronnix/bwarr-bench).
Metode lain akan ditambahkan, dan juga akan ada benchmark terpisah untuk arsitektur AMD64 dan ARM64.

## Instalasi

Memerlukan Go 1.22 atau lebih tinggi.

```bash
go get github.com/dronnix/bwarr
```

Lalu impor ke dalam kode Anda:

```go
import "github.com/dronnix/bwarr"
```

## Penggunaan

### Contoh Dasar

```go
package main

import (
    "cmp"
    "fmt"

    "github.com/dronnix/bwarr"
)

func main() {
    // Create a BWArr with an integer comparison function
    // The second parameter (10) is the initial capacity hint
    bwa := bwarr.New(func(a, b int64) int {
        return cmp.Compare(a, b)
    }, 10)

    // Insert elements
    bwa.Insert(42)
    bwa.Insert(17)
    bwa.Insert(99)
    bwa.Insert(23)
    bwa.Insert(8)

    fmt.Printf("Length: %d\n", bwa.Len()) // Output: Length: 5

    // Get an element
    val, found := bwa.Get(42)
    if found {
        fmt.Printf("Found: %d\n", val) // Output: Found: 42
    }

    // Delete an element
    deleted, found := bwa.Delete(17)
    if found {
        fmt.Printf("Deleted: %d\n", deleted) // Output: Deleted: 17
    }

    // Iterate in ascending order
    fmt.Println("Elements in sorted order:")
    bwa.Ascend(func(item int64) bool {
        fmt.Printf("  %d\n", item)
        return true // return false to stop iteration early
    })
    // Output:
    //   8
    //   23
    //   42
    //   99
}
```




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-19

---