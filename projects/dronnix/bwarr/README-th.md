<div align="right">
  <details>
    <summary >🌐 ภาษา</summary>
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

## มันคืออะไร?

[![CI](https://github.com/dronnix/bwarr/actions/workflows/ci.yml/badge.svg)](https://github.com/dronnix/bwarr/actions)
[![codecov](https://codecov.io/gh/dronnix/bwarr/branch/main/graph/badge.svg)](https://codecov.io/gh/dronnix/bwarr)
[![Go Reference](https://pkg.go.dev/badge/github.com/dronnix/bwarr.svg)](https://pkg.go.dev/github.com/dronnix/bwarr)
[![Go Report Card](https://goreportcard.com/badge/github.com/dronnix/bwarr)](https://goreportcard.com/report/github.com/dronnix/bwarr)

Black-White Array (หรือ BWArr) คือโครงสร้างข้อมูลที่มีลำดับและประสิทธิภาพสูงโดยอิงกับอาร์เรย์ ซึ่งมี ***$O(\log N)$*** **การจองหน่วยความจำ**

## โครงสร้างข้อมูล
แนวคิดของ Black-White Array ถูกคิดค้นและเผยแพร่โดยศาสตราจารย์ [Z. George Mou](https://www.cs.brandeis.edu/~mou/) ในเอกสาร [Black-White Array: A New Data Structure for Dynamic Data Sets](https://arxiv.org/abs/2004.09051) ที่เก็บนี้ประกอบด้วยการนำไปใช้งานสาธารณะครั้งแรก

![Professor Z. George Mou](https://www.cs.brandeis.edu/~mou/mou.gif)

### คุณสมบัติหลัก:
- การจัดสรรหน่วยความจำ $O(\log N)$ สำหรับการแทรกข้อมูล - ไม่กดดัน GC;
- การแทรก ลบ และค้นหาเร็ว ความซับซ้อนแบบเฉลี่ย $O(\log N)$;
- ใช้ Array และไม่มี pointer ทำให้เป็นมิตรกับ CPU: cache locality / การวนลูปแบบลำดับ / ฯลฯ;
- รองรับ element ซ้ำโดยตรง (multiset) - ไม่ต้องห่อค่าใน struct เพื่อทำให้เป็นเอกลักษณ์;
- สามารถใช้แทน `github.com/google/btree` และ `github.com/petar/GoLLRB` ได้ทันที;
- ใช้หน่วยความจำต่ำ - ไม่มี pointer ต่อ element, จัดเก็บข้อมูลแบบแน่น;
- สามารถ serialize ได้ง่าย;

### จุดแลกเปลี่ยน
- ทุกๆ $N$ การแทรก ความซับซ้อนจะลดลงไปที่ $O(N)$ แต่แบบเฉลี่ยยังคง $O(\log N)$ สำหรับระบบเรียลไทม์ อาจเกิด latency spikes ใน collection ที่มีล้าน element สามารถลดผลกระทบได้ด้วย async/background insert
- สำหรับ element จำนวนน้อย `Search()/Delete()` อาจใช้ $O((\log N)^2)$ 50% ของ element ใช้เวลา $O(\log N)$, 75%  - $O(2\log N)$, 87.5% - $O(3\log N)$ เป็นต้น
- เมื่อลบ element จำนวนมากติดกัน การดำเนินการ `Max()/Min()` อาจใช้ $O(N/4)$ ความซับซ้อนแบบเฉลี่ยสำหรับหลายครั้งยังคง $O(\log N)$
- เมื่อลบ element จำนวนมากติดกัน ขั้นตอนการวนลูปอาจใช้ $O(N/4)$ ความซับซ้อนแบบเฉลี่ยสำหรับวนลูปทั้ง collection ยังคง $O(\log N)$ ต่อ element

### กรณีใช้งาน
Collection ในหน่วยความจำที่มีอัตราส่วนอ่าน:เขียน 1:1 < r:w < 10:1 BWArr เหมาะสำหรับการแทรกและลบหนัก (จัดสรรและ fragment ต่ำ) และยังค้นหาและวนลูปได้เร็ว

###  การวัดประสิทธิภาพ

เปรียบเทียบกับ [Google BTree](https://github.com/google/btree)

#### Insert 
วัดเวลา การจัดสรร และ KB ที่จัดสรรในการแทรกค่าจำนวนเต็ม int64 แบบสุ่ม N ค่าไม่ซ้ำกันในโครงสร้างข้อมูลว่าง ทั้ง BWArr และ BTree เริ่มจากว่างและแทรกค่าทีละตัว

![Insert performance](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_unique_values.png?raw=true)
![Insert Allocs](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_unique_values_allocs.png?raw=true)
![Insert Alloc_Bytes](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_unique_values_bytes.png?raw=true)

การจัดสรรบนค่าขนาดเล็ก: 

![Insert Allocs small](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_performance_allocs_detailed.png?raw=true)




#### Get 
วัดเวลาที่ใช้ในการค้นหา N ค่าโดยใช้คีย์ในโครงสร้างข้อมูลที่เติมข้อมูลไว้ล่วงหน้า โครงสร้างข้อมูลจะถูกเติมค่าทั้งหมดก่อนเริ่มจับเวลา จากนั้นจึงดึงค่าทีละรายการโดยใช้คีย์

![ประสิทธิภาพการ Get](https://github.com/dronnix/bwarr-bench/blob/main/images/get_all_values_by_key.png?raw=true)

#### Iterate
วัดเวลาที่ใช้ในการวนลูปผ่านค่า N ทั้งหมด ทั้งแบบเรียงลำดับและไม่เรียงลำดับ
![ประสิทธิภาพการวนลูปแบบเรียงลำดับ](https://github.com/dronnix/bwarr-bench/blob/main/images/ordered_iteration_over_all_values.png?raw=true)
![ประสิทธิภาพการวนลูปแบบไม่เรียงลำดับ](https://github.com/dronnix/bwarr-bench/blob/main/images/unordered_iteration_over_all_values.png?raw=true)

#### การทดสอบประสิทธิภาพเพิ่มเติม
สามารถดูการทดสอบประสิทธิภาพและรายละเอียดเพิ่มเติมได้ที่ [bwarr-bench](https://github.com/dronnix/bwarr-bench) จะมีการเพิ่มเมธอดใหม่ ๆ และแยกผลการทดสอบระหว่างสถาปัตยกรรม AMD64 กับ ARM64

## การติดตั้ง

ต้องใช้ Go 1.22 หรือสูงกว่า


```bash
go get github.com/dronnix/bwarr
```

จากนั้นนำเข้าในโค้ดของคุณ:

```go
import "github.com/dronnix/bwarr"
```

## การใช้งาน

### ตัวอย่างพื้นฐาน

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