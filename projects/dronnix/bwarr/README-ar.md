
<div align="right">
  <details>
    <summary >🌐 اللغة</summary>
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

## ما هو؟

[![CI](https://github.com/dronnix/bwarr/actions/workflows/ci.yml/badge.svg)](https://github.com/dronnix/bwarr/actions)
[![codecov](https://codecov.io/gh/dronnix/bwarr/branch/main/graph/badge.svg)](https://codecov.io/gh/dronnix/bwarr)
[![Go Reference](https://pkg.go.dev/badge/github.com/dronnix/bwarr.svg)](https://pkg.go.dev/github.com/dronnix/bwarr)
[![Go Report Card](https://goreportcard.com/badge/github.com/dronnix/bwarr)](https://goreportcard.com/report/github.com/dronnix/bwarr)

مصفوفة الأسود والأبيض (المعروفة أيضًا بـ BWArr) هي بنية بيانات سريعة ومرتبة قائمة على المصفوفات مع ***$O(\log N)$*** **تخصيصات الذاكرة**.

## هيكلية البيانات
تم اختراع مصفوفة الأبيض والأسود ونشرها من قبل الأستاذ [زد. جورج مو](https://www.cs.brandeis.edu/~mou/) في [مصفوفة الأبيض والأسود: هيكلية بيانات جديدة لمجموعات البيانات الديناميكية](https://arxiv.org/abs/2004.09051). يحتوي هذا المستودع على أول تطبيق عام لها.

![الأستاذ زد. جورج مو](https://www.cs.brandeis.edu/~mou/mou.gif)

### الميزات الرئيسية:
- تخصيصات الذاكرة $O(\log N)$ لعمليات الإدراج - بدون ضغط على جامع القمامة (GC)؛
- إدراج، حذف وبحث سريع مع تعقيد زمني $O(\log N)$ بشكل متوسط؛
- يعتمد على المصفوفات ودون مؤشرات مما يجعله صديقاً للمعالج: محلية التخزين المؤقت / التكرار التسلسلي / إلخ؛
- يدعم العناصر المكررة بشكل أصلي (سلوك مجموعة متعددة) - لا حاجة لتغليف القيم داخل هياكل لجعلها فريدة؛
- يمكن استخدامه كبديل مباشر لـ `github.com/google/btree` و `github.com/petar/GoLLRB`;
- استهلاك منخفض للذاكرة - بدون مؤشرات لكل عنصر، تمثيل ذاكرة مضغوط؛
- سهل التسلسل؛

### الموازنة
- في كل $N$ عملية إدراج، ينخفض التعقيد إلى $O(N)$، ولكن المتوسط يبقى $O(\log N)$. بالنسبة للأنظمة الفورية، قد يسبب ارتفاعات في زمن التأخير عند التعامل مع ملايين العناصر. يمكن التخفيف من ذلك عبر عمليات الإدراج غير المتزامنة/في الخلفية.
- عند وجود عدد قليل من العناصر، قد تستغرق عمليات `Search()/Delete()` وقتاً $O((\log N)^2)$. 50% من العناصر تحتاج $O(\log N)$، 75% - $O(2\log N)$، 87.5% - $O(3\log N)$، إلخ.
- عند حذف سلسلة طويلة من العناصر، قد تستغرق عملية `Max()/Min()` وقتاً $O(N/4)$. متوسط التعقيد لسلسلة من الاستدعاءات يبقى $O(\log N)$.
- عند حذف سلسلة طويلة من العناصر، قد تستغرق خطوة التكرار وقتاً $O(N/4)$. يبقى متوسط التعقيد للتكرار عبر كامل المجموعة $O(\log N)$ لكل عنصر.

### حالة الاستخدام
مجموعات في الذاكرة بنسبة قراءة إلى كتابة 1:1 < r:w < 10:1. تم تحسين BWArr للإدراجات والحذوفات الكثيفة (مع تقليل التخصيصات والتجزئة)، مع الحفاظ على سرعة البحث والتكرار.

### الاختبارات المعيارية

اختبارات معيارية بالمقارنة مع [Google BTree](https://github.com/google/btree).

#### إدراج 
يقيس الوقت، وعدد التخصيصات، والذاكرة المخصصة بالكيلوبايت لإدراج N من القيم العشوائية الفريدة من نوع int64 في هيكل بيانات فارغ. يبدأ كل من BWArr و BTree فارغين ويتم إدراج جميع القيم واحدة تلو الأخرى.

![أداء الإدراج](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_unique_values.png?raw=true)
![تخصيصات الإدراج](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_unique_values_allocs.png?raw=true)
![بايتات التخصيص في الإدراج](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_unique_values_bytes.png?raw=true)

التخصيصات للقيم الصغيرة:

![تخصيصات الإدراج للقيم الصغيرة](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_performance_allocs_detailed.png?raw=true)



#### الاستعلام (Get)
يقيس الوقت اللازم للبحث عن N من القيم بواسطة مفاتيحها في بنية بيانات مملوءة مسبقًا. يتم ملء بنية البيانات بجميع القيم قبل بدء التوقيت، ثم يتم استرجاع كل قيمة بواسطة المفتاح الخاص بها.

![أداء الاستعلام](https://github.com/dronnix/bwarr-bench/blob/main/images/get_all_values_by_key.png?raw=true)

#### التكرار (Iterate)
يقيس الوقت اللازم للتكرار عبر جميع قيم N بترتيب مرتب وغير مرتب.
![أداء التكرار المرتب](https://github.com/dronnix/bwarr-bench/blob/main/images/ordered_iteration_over_all_values.png?raw=true)
![أداء التكرار غير المرتب](https://github.com/dronnix/bwarr-bench/blob/main/images/unordered_iteration_over_all_values.png?raw=true)

#### المزيد من الاختبارات المعيارية
اختبارات معيارية إضافية وتفاصيل أخرى متوفرة في مستودع [bwarr-bench](https://github.com/dronnix/bwarr-bench).
سيتم إضافة المزيد من الطرق، كما يمكنكم توقع اختبارات معيارية منفصلة لمعمارية AMD64 و ARM64.

## التثبيت

يتطلب Go 1.22 أو أعلى.

```bash
go get github.com/dronnix/bwarr
```
ثم قم بالاستيراد في الكود الخاص بك:


```go
import "github.com/dronnix/bwarr"
```

## الاستخدام

### مثال أساسي

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