
<div align="right">
  <details>
    <summary >🌐 زبان</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=en">انگلیسی</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=fr">فرانسوی</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=de">آلمانی</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=es">اسپانیایی</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=it">ایتالیایی</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=ru">روسی</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=pt">پرتغالی</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=nl">هلندی</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=pl">لهستانی</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=tr">ترکی</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=vi">ویتنامی</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=id">اندونزیایی</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

## این چیست؟

[![CI](https://github.com/dronnix/bwarr/actions/workflows/ci.yml/badge.svg)](https://github.com/dronnix/bwarr/actions)
[![codecov](https://codecov.io/gh/dronnix/bwarr/branch/main/graph/badge.svg)](https://codecov.io/gh/dronnix/bwarr)
[![Go Reference](https://pkg.go.dev/badge/github.com/dronnix/bwarr.svg)](https://pkg.go.dev/github.com/dronnix/bwarr)
[![Go Report Card](https://goreportcard.com/badge/github.com/dronnix/bwarr)](https://goreportcard.com/report/github.com/dronnix/bwarr)

آرایه سیاه-سفید (یا BWArr) یک ساختار داده سریع و مرتب مبتنی بر آرایه‌ها با ***$O(\log N)$*** **تخصیص حافظه** است.
## ساختار داده
ایده آرایه سیاه-سفید توسط پروفسور [زد. جورج مو](https://www.cs.brandeis.edu/~mou/) در مقاله [Black-White Array: A New Data Structure for Dynamic Data Sets](https://arxiv.org/abs/2004.09051) ابداع و منتشر شده است. این مخزن شامل اولین پیاده‌سازی عمومی آن است.

![پروفسور زد. جورج مو](https://www.cs.brandeis.edu/~mou/mou.gif)

### ویژگی‌های کلیدی:
- تخصیص حافظه $O(\log N)$ برای درج‌ها - بدون فشار بر جمع‌آوری زباله؛
- عملیات درج، حذف و جستجوی سریع با پیچیدگی زمانی سرشکن $O(\log N)$؛
- مبتنی بر آرایه و بدون اشاره‌گر، مناسب پردازنده: محلی‌سازی کش / پیمایش ترتیبی / و غیره؛
- پشتیبانی ذاتی از عناصر تکراری (رفتار چندمجموعه‌ای) - نیازی به بسته‌بندی مقادیر برای یکتا کردن نیست؛
- جایگزین مستقیم برای `github.com/google/btree` و `github.com/petar/GoLLRB`؛
- سربار حافظه پایین - بدون اشاره‌گر به ازای هر عنصر، نمایش فشرده در حافظه؛
- به‌راحتی قابل سریال‌سازی؛

### مصالحه‌ها
- در هر $N$ عملیات درج، پیچیدگی به $O(N)$ کاهش می‌یابد، هرچند سرشکن همچنان $O(\log N)$ باقی می‌ماند. برای سیستم‌های بلادرنگ، ممکن است در مجموعه‌های با میلیون‌ها عنصر، جهش تأخیر ایجاد کند. می‌توان آن را با درج‌های پس‌زمینه یا ناهمزمان کاهش داد.
- برای تعداد کم عناصر، عملیات `Search()/Delete()` ممکن است $O((\log N)^2)$ زمان ببرد. ۵۰٪ عناصر در $O(\log N)$، ۷۵٪ در $O(2\log N)$، ۸۷.۵٪ در $O(3\log N)$ و غیره زمان می‌برند.
- هنگام حذف سری طولانی از عناصر، عملیات `Max()/Min()` می‌تواند $O(N/4)$ زمان ببرد. پیچیدگی سرشکن برای سری فراخوانی‌ها $O(\log N)$ باقی می‌ماند.
- هنگام حذف سری طولانی از عناصر، هر گام پیمایش می‌تواند $O(N/4)$ زمان ببرد. پیچیدگی سرشکن پیمایش کل مجموعه $O(\log N)$ به ازای هر عنصر باقی می‌ماند.

### کاربرد
مجموعه‌های در حافظه با نسبت خواندن به نوشتن 1:1 < r:w < 10:1. BWArr برای درج و حذف سنگین بهینه شده است (با تخصیص و تکه‌تکه شدن کم)، در حالی که جستجو و پیمایش سریع را نیز فراهم می‌کند.

### بنچمارک‌ها

بنچمارک‌ها در مقایسه با [Google BTree](https://github.com/google/btree).

#### درج
زمان، تعداد تخصیص‌ها و کیلوبایت‌های تخصیص‌یافته برای درج N مقدار تصادفی int64 یکتا به یک ساختار داده خالی را اندازه‌گیری می‌کند. هر دو BWArr و BTree از حالت خالی شروع و همه مقادیر را یکی‌یکی درج می‌کنند.

![عملکرد درج](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_unique_values.png?raw=true)
![تخصیص درج](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_unique_values_allocs.png?raw=true)
![تخصیص بایت درج](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_unique_values_bytes.png?raw=true)

تخصیص‌ها روی مقادیر کوچک‌تر:

![تخصیص درج کوچک](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_performance_allocs_detailed.png?raw=true)




#### دریافت
مدت زمان جستجوی N مقدار بر اساس کلید آن‌ها را در یک ساختار داده از پیش پر شده اندازه‌گیری می‌کند. ساختار داده قبل از شروع زمان‌گیری با همه مقادیر پر می‌شود، سپس هر مقدار با استفاده از کلید خود بازیابی می‌شود.

![عملکرد دریافت](https://github.com/dronnix/bwarr-bench/blob/main/images/get_all_values_by_key.png?raw=true)

#### پیمایش
مدت زمان پیمایش همه N مقدار به صورت مرتب و غیر مرتب را اندازه‌گیری می‌کند.
![عملکرد پیمایش مرتب](https://github.com/dronnix/bwarr-bench/blob/main/images/ordered_iteration_over_all_values.png?raw=true)
![عملکرد پیمایش غیر مرتب](https://github.com/dronnix/bwarr-bench/blob/main/images/unordered_iteration_over_all_values.png?raw=true)

#### بنچمارک‌های بیشتر
بنچمارک‌های اضافی و جزئیات بیشتر در مخزن [bwarr-bench](https://github.com/dronnix/bwarr-bench) موجود است.
روش‌های بیشتری افزوده خواهند شد و همچنین بنچمارک‌های جداگانه برای معماری‌های AMD64 و ARM64 انتظار می‌رود.

## نصب

نیازمند Go نسخه ۱.۲۲ یا بالاتر است.

```bash
go get github.com/dronnix/bwarr
```
سپس در کد خود وارد کنید:


```go
import "github.com/dronnix/bwarr"
```

## نحوه استفاده

### مثال پایه

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