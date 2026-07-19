
<div align="right">
  <details>
    <summary >🌐 Dil</summary>
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

## Nedir?

[![CI](https://github.com/dronnix/bwarr/actions/workflows/ci.yml/badge.svg)](https://github.com/dronnix/bwarr/actions)
[![codecov](https://codecov.io/gh/dronnix/bwarr/branch/main/graph/badge.svg)](https://codecov.io/gh/dronnix/bwarr)
[![Go Reference](https://pkg.go.dev/badge/github.com/dronnix/bwarr.svg)](https://pkg.go.dev/github.com/dronnix/bwarr)
[![Go Report Card](https://goreportcard.com/badge/github.com/dronnix/bwarr)](https://goreportcard.com/report/github.com/dronnix/bwarr)

Black-White Array (diğer adıyla BWArr), dizilere dayalı, ***$O(\log N)$*** **bellek tahsisi** ile hızlı ve sıralı bir veri yapısıdır.

## Veri Yapısı
Black-White Array fikri, profesör [Z. George Mou](https://www.cs.brandeis.edu/~mou/) tarafından [Black-White Array: A New Data Structure for
Dynamic Data Sets](https://arxiv.org/abs/2004.09051) adlı çalışmada icat edilip yayımlandı. Bu depo, ilk halka açık uygulamayı içermektedir.

![Profesör Z. George Mou](https://www.cs.brandeis.edu/~mou/mou.gif)

### Temel Özellikler:
- Ekleme işlemleri için $O(\log N)$ bellek tahsisi - GC üzerinde baskı yok;
- Hızlı ekleme, silme ve arama işlemleri $O(\log N)$ zamansal ortalama karmaşıklık;
- Dizi tabanlı ve işaretsiz olduğu için CPU dostu: önbellek lokalitesi / ardışık yineleme / vb;
- Yerleşik olarak yinelenen elemanları destekler (multiset davranışı) - değerleri benzersiz yapmak için yapı içine sarmaya gerek yok;
- `github.com/google/btree` ve `github.com/petar/GoLLRB` için tak-çalıştır yedeği;
- Düşük bellek yükü - eleman başına işaretçi yok, kompakt bellek temsili;
- Kolayca serileştirilebilir;

### Takaslar
- Her $N$ ekleme işleminden biri $O(N)$ karmaşıklığa düşer, ancak ortalamada $O(\log N)$ kalır. Gerçek zamanlı sistemlerde, milyonlarca elemandan oluşan koleksiyonlarda gecikme sıçramaları oluşturabilir. Bu, asenkron/arka plan eklemeleriyle hafifletilebilir.
- Az sayıda elemanda `Search()/Delete()` işlemleri $O((\log N)^2)$ sürebilir. Elemanların %50’si $O(\log N)$, %75’i  - $O(2\log N)$, %87.5’i - $O(3\log N)$ sürede tamamlanır, vb.
- Uzun eleman serileri silinirken, bir `Max()/Min()` işlemi $O(N/4)$ sürebilir. Çağrı serileri için ortalama karmaşıklık $O(\log N)$ olarak kalır.
- Uzun eleman serileri silinirken, yineleme adımı $O(N/4)$ sürebilir. Tüm koleksiyonda yineleme başına ortalama karmaşıklık $O(\log N)$ olarak kalır.

### Kullanım Senaryosu
Bellekte, okuma-yazma oranı 1:1 < o:y < 10:1 olan koleksiyonlar. BWArr, hızlı ekleme ve silmeler (düşük tahsis ve parçalanma ile) için optimize edilmiştir ve hâlâ hızlı arama ve yineleme sunar.

###  Karşılaştırmalı Testler

Karşılaştırmalı testler [Google BTree](https://github.com/google/btree) ile yapılmıştır.

#### Ekleme 
Boş bir veri yapısına N adet benzersiz rastgele int64 değeri eklemek için geçen süreyi, tahsisleri ve tahsis edilen KB’ları ölçer. Hem BWArr hem de BTree boş başlar ve tüm değerler tek tek eklenir.

![Ekleme performansı](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_unique_values.png?raw=true)
![Ekleme Tahsisleri](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_unique_values_allocs.png?raw=true)
![Ekleme Tahsis_Baytları](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_unique_values_bytes.png?raw=true)

Küçük değerlerdeki tahsisler: 

![Küçük Ekleme Tahsisleri](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_performance_allocs_detailed.png?raw=true)


#### Get 
N adet değerin anahtarlarıyla, önceden doldurulmuş bir veri yapısında aranması için geçen süreyi ölçer. Veri yapısı, zamanlama başlamadan önce tüm değerlerle doldurulur, ardından her değer anahtarıyla alınır.

![Get performance](https://github.com/dronnix/bwarr-bench/blob/main/images/get_all_values_by_key.png?raw=true)

#### Iterate
Tüm N değeri sıralı ve sırasız şekilde dolaşmak için geçen süreyi ölçer.
![Ordered Iterate performance](https://github.com/dronnix/bwarr-bench/blob/main/images/ordered_iteration_over_all_values.png?raw=true)
![Unordered Iterate performance](https://github.com/dronnix/bwarr-bench/blob/main/images/unordered_iteration_over_all_values.png?raw=true)

#### Daha fazla kıyaslama
Ek kıyaslamalar ve detaylar [bwarr-bench](https://github.com/dronnix/bwarr-bench) deposunda mevcuttur.
Daha fazla yöntem eklenecek, ayrıca AMD64 ve ARM64 mimarileri için ayrı kıyaslamalar bekleyin.

## Kurulum

Go 1.22 veya üstü gereklidir.

```bash
go get github.com/dronnix/bwarr
```

Daha sonra kodunuza şunu ekleyin:

```go
import "github.com/dronnix/bwarr"
```

## Kullanım

### Temel Örnek

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