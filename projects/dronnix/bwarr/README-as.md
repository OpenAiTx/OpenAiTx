<div align="right">
  <details>
    <summary >🌐 ভাষা</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=hi">হিন্দী</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=th">থাই</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=fr">ফ্ৰেঞ্চ</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=de">জার্মান</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=es">স্পেনী</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=it">ইটালীয়</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=ru">ৰাছিয়ান</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=pt">পৰ্তুগীজ</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=nl">ডাচ</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=pl">প'লিশ</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=ar">আৰবী</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=fa">ফাৰ্ছী</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=tr">তুৰ্কী</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=vi">ভিয়েটনামী</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=id">ইন্দোনেছিয়ান</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

## এইটো কি?

[![CI](https://github.com/dronnix/bwarr/actions/workflows/ci.yml/badge.svg)](https://github.com/dronnix/bwarr/actions)
[![codecov](https://codecov.io/gh/dronnix/bwarr/branch/main/graph/badge.svg)](https://codecov.io/gh/dronnix/bwarr)
[![Go Reference](https://pkg.go.dev/badge/github.com/dronnix/bwarr.svg)](https://pkg.go.dev/github.com/dronnix/bwarr)
[![Go Report Card](https://goreportcard.com/badge/github.com/dronnix/bwarr)](https://goreportcard.com/report/github.com/dronnix/bwarr)

ব্লেক-হোয়াইট এৰে (Black-White Array) (অর্থাৎ BWArr) হৈছে এটা দ্ৰুত, সুশৃঙ্খল ডাটা স্ট্ৰাকচাৰ যি এৰে'ৰ আধাৰত নিৰ্মিত আৰু ***$O(\log N)$*** **মেম'ৰি এল'কেশ্বন** থাকে।

## ডাটা গঠন
Black-White Array ৰ ধাৰণা অধ্যাপক [Z. George Mou](https://www.cs.brandeis.edu/~mou/) এ আৱিষ্কাৰ আৰু প্ৰকাশ কৰিছিল [Black-White Array: A New Data Structure for
Dynamic Data Sets](https://arxiv.org/abs/2004.09051) ত। এই ৰিপ’জিটৰীত প্ৰথমবাৰৰ বাবে পাব্লিক ইমপ্লিমেণ্টেচন সংৰক্ষিত।

![Professor Z. George Mou](https://www.cs.brandeis.edu/~mou/mou.gif)

### মুখ্য বৈশিষ্ট্যসমূহ:
- $O(\log N)$ মেম'ৰি এল'কেশ্বন ইনচাৰ্টৰ বাবে - GC ৰ ওপৰত কোনো চাপ নহয়;
- দ্ৰুত ইনচাৰ্ট, ডিলিট, আৰু চাৰ্ছ অপাৰেচন $O(\log N)$ সময়ৰ এম’ৰ্টাইজড কম্প্লেক্সিটি;
- এৰে-ভিত্তিক আৰু পইণ্টাৰ-নথকা—CPU-ফ্ৰেণ্ডলি: কেশ লোকেলিটি / অনুক্ৰমিক ইটাৰেচন / আদি;
- স্বাভাৱিকভাৱে ডুপ্লিকেট এলিমেণ্ট সমৰ্থন কৰে (multiset আচৰণ) - মানবোৰক ইউনিক কৰিবলৈ ষ্ট্ৰাক্টত ৰেপ কৰাৰ প্ৰয়োজন নাই;
- `github.com/google/btree` আৰু `github.com/petar/GoLLRB` ৰ ড্ৰপ-ইন ৰিপ্লেছমেণ্ট;
- কম মেম'ৰি খৰচ - প্ৰতিটো এলিমেণ্টৰ বাবে পইণ্টাৰ নাই, কম্পেক্ট মেম'ৰি ৰূপ;
- সহজে ছিৰিয়েলাইজ কৰিব পৰা যায়;

### সীমাবদ্ধতা
- প্ৰতিটো $N$ টা ইনচাৰ্ট অপাৰেচনত কম্প্লেক্সিটি $O(N)$লৈ নামি যায়, যদিও এম’ৰ্টাইজড $O(\log N)$ থাকে। ৰিয়েল-টাইম ছিষ্টেমত এইটো লেটেনচি স্পাইক সৃষ্টি কৰিব পাৰে, বিশেষকৈ লাখ লাখ এলিমেণ্ট থকা সংগ্ৰহসমূহত। এইটো async/background ইনচাৰ্টৰে হ্ৰাস কৰিব পাৰি।
- কম এলিমেণ্টত `Search()/Delete()` অপাৰেচন $O((\log N)^2)$ সময় ল’ব পাৰে। ৫০% এলিমেণ্টত $O(\log N)$ সময়, ৭৫% ত  - $O(2\log N)$, ৮৭.৫% ত - $O(3\log N)$ আদি।
- দীঘলীয়া এলিমেণ্টৰ শৃংখলা ডিলিট কৰোঁতে, `Max()/Min()` অপাৰেচন $O(N/4)$ সময় লৈ পাৰে। এম’ৰ্টাইজড কম্প্লেক্সিটি কলৰ শৃংখলাৰ বাবে $O(\log N)$ থাকে।
- দীঘলীয়া এলিমেণ্টৰ শৃংখলা ডিলিট কৰোঁতে, ইটাৰেচন ষ্টেপ $O(N/4)$ সময় লৈ পাৰে। সম্পূৰ্ণ সংগ্ৰহৰ ওপৰত এম’ৰ্টাইজড ইটাৰেচনৰ কম্প্লেক্সিটি প্ৰতিটো এলিমেণ্টত $O(\log N)$ হয়।

### ব্যৱহাৰ ক্ষেত্ৰ
মেম'ৰিত সংৰক্ষিত সংগ্ৰহবোৰত পঢ়া-লিখাৰ অনুপাত ১:১ < r:w < ১০:১। BWArr বিশেষকৈ অধিক ইনচাৰ্ট আৰু ডিলিটৰ বাবে (কম এল'কেশ্বন আৰু ফ্ৰেগমেণ্টেচনসহ), লগতে দ্ৰুত চাৰ্ছ আৰু ইটাৰেচন দিয়া হয়।

### বেঞ্চমাৰ্কসমূহ

[Google BTree](https://github.com/google/btree) ৰ সৈতে তুলনামূলক বেঞ্চমাৰ্ক।

#### ইনচাৰ্ট 
এটা খালী ডাটা গঠনত N টা অনন্য ৰেণ্ডম int64 মান ইনচাৰ্ট কৰিবলৈ সময়, এল'ক, আৰু KB এল'কেটেড মাপ হয়। BWArr আৰু BTree দুয়োটাই খালী অৱস্থা পৰা আৰম্ভ হয় আৰু মানবোৰ এটা এটা কৰি ইনচাৰ্ট হয়।

![Insert performance](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_unique_values.png?raw=true)
![Insert Allocs](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_unique_values_allocs.png?raw=true)
![Insert Alloc_Bytes](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_unique_values_bytes.png?raw=true)

সৰু মানত এল'কেশ্যন:

![Insert Allocs small](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_performance_allocs_detailed.png?raw=true)



#### Get 
এটা পূৰ্বতে তথ্যৰে পূৰণ কৰা ডাটা গঠন এটাত N টা মানৰ কী অনুসৰি সন্ধান কৰিবলৈ সময় মাপে। ডাটা গঠনটোত সকলো মান পূৰ্বে সংৰক্ষণ কৰা হয়, তাৰ পাছত প্ৰতিটো মান কী দ্বারা উদ্ধাৰ কৰা হয়।

![Get performance](https://github.com/dronnix/bwarr-bench/blob/main/images/get_all_values_by_key.png?raw=true)

#### Iterate
N টা মান শাৰীত আৰু অশাৰীতভাৱে পৰ্যবেক্ষণ কৰিবলৈ সময় মাপে।
![Ordered Iterate performance](https://github.com/dronnix/bwarr-bench/blob/main/images/ordered_iteration_over_all_values.png?raw=true)
![Unordered Iterate performance](https://github.com/dronnix/bwarr-bench/blob/main/images/unordered_iteration_over_all_values.png?raw=true)

#### More benchmarks
অধিক বেঞ্চমাৰ্ক আৰু বিৱৰণ [bwarr-bench](https://github.com/dronnix/bwarr-bench) ৰিপজিটৰিত উপলব্ধ।
অধিক পদ্ধতি সংযোজন কৰা হ'ব, লগতে AMD64 আৰু ARM64 স্থাপত্যৰ বাবে পৃথক বেঞ্চমাৰ্কৰো আশা কৰিব পাৰি।

## Installation

Go 1.22 অথবা তাতকৈ নতুন সংস্কৰণৰ প্ৰয়োজন।

```bash
go get github.com/dronnix/bwarr
```

তাৰ পিছত আপোনাৰ ক'ডত ইম্পোৰ্ট কৰক:

```go
import "github.com/dronnix/bwarr"
```

## ব্যৱহাৰ

### মৌলিক উদাহৰণ

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