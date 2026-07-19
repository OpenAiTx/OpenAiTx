
<div align="right">
  <details>
    <summary >🌐 Ngôn ngữ</summary>
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

## Nó là gì?

[![CI](https://github.com/dronnix/bwarr/actions/workflows/ci.yml/badge.svg)](https://github.com/dronnix/bwarr/actions)
[![codecov](https://codecov.io/gh/dronnix/bwarr/branch/main/graph/badge.svg)](https://codecov.io/gh/dronnix/bwarr)
[![Go Reference](https://pkg.go.dev/badge/github.com/dronnix/bwarr.svg)](https://pkg.go.dev/github.com/dronnix/bwarr)
[![Go Report Card](https://goreportcard.com/badge/github.com/dronnix/bwarr)](https://goreportcard.com/report/github.com/dronnix/bwarr)

Black-White Array (còn gọi là BWArr) là một cấu trúc dữ liệu nhanh, có thứ tự dựa trên mảng với ***$O(\log N)$*** **phân bổ bộ nhớ**.

## Cấu Trúc Dữ Liệu
Ý tưởng về Mảng Đen-Trắng (Black-White Array) được phát minh và công bố bởi giáo sư [Z. George Mou](https://www.cs.brandeis.edu/~mou/) trong bài báo [Black-White Array: A New Data Structure for Dynamic Data Sets](https://arxiv.org/abs/2004.09051). Kho lưu trữ này chứa bản hiện thực công khai đầu tiên.

![Giáo sư Z. George Mou](https://www.cs.brandeis.edu/~mou/mou.gif)

### Tính năng chính:
- Cấp phát bộ nhớ $O(\log N)$ cho thao tác chèn - không gây áp lực cho GC;
- Các thao tác chèn, xóa, tìm kiếm nhanh với độ phức tạp trung bình $O(\log N)$;
- Dựa trên mảng và không dùng con trỏ, thân thiện CPU: tối ưu locality cache / duyệt tuần tự / v.v;
- Hỗ trợ phần tử trùng lặp một cách tự nhiên (hành vi multiset) - không cần bao bọc giá trị vào struct để làm duy nhất;
- Thay thế trực tiếp cho `github.com/google/btree` và `github.com/petar/GoLLRB`;
- Chiếm dụng bộ nhớ thấp - không có con trỏ trên mỗi phần tử, biểu diễn bộ nhớ gọn nhẹ;
- Dễ dàng tuần tự hóa;

### Cân nhắc đánh đổi
- Một trên mỗi $N$ thao tác chèn có độ phức tạp giảm xuống $O(N)$, tuy nhiên trung bình vẫn là $O(\log N)$. Đối với hệ thống thời gian thực, có thể gây đột biến độ trễ với tập hợp hàng triệu phần tử. Có thể giảm thiểu bằng chèn bất đồng bộ/nền.
- Với số phần tử nhỏ, thao tác `Search()/Delete()` có thể tốn $O((\log N)^2)$. 50% phần tử tốn $O(\log N)$, 75% - $O(2\log N)$, 87.5% - $O(3\log N)$, v.v.
- Khi xóa dãy phần tử dài, thao tác `Max()/Min()` có thể tốn $O(N/4)$. Độ phức tạp trung bình cho chuỗi lệnh vẫn là $O(\log N)$.
- Khi xóa dãy phần tử dài, bước duyệt có thể tốn $O(N/4)$. Độ phức tạp trung bình khi duyệt toàn bộ tập hợp vẫn là $O(\log N)$ trên mỗi phần tử.

### Trường hợp sử dụng
Bộ sưu tập trong bộ nhớ với tỷ lệ đọc-ghi 1:1 < r:w < 10:1. BWArr được tối ưu cho chèn/xóa nặng (với ít cấp phát và phân mảnh), đồng thời vẫn cung cấp tìm kiếm và duyệt nhanh.

###  Hiệu năng đo đạc

So sánh benchmark với [Google BTree](https://github.com/google/btree).

#### Chèn 
Đo thời gian, số lần cấp phát và bộ nhớ cấp phát (KB) để chèn N giá trị int64 ngẫu nhiên duy nhất vào một cấu trúc dữ liệu rỗng. Cả BWArr và BTree đều bắt đầu rỗng và chèn từng giá trị một.

![Hiệu năng Chèn](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_unique_values.png?raw=true)
![Chèn Allocs](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_unique_values_allocs.png?raw=true)
![Chèn Alloc_Bytes](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_unique_values_bytes.png?raw=true)

Cấp phát trên giá trị nhỏ hơn:

![Chèn Allocs nhỏ](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_performance_allocs_detailed.png?raw=true)



#### Lấy 
Đo thời gian truy xuất N giá trị theo khóa trong một cấu trúc dữ liệu đã được khởi tạo sẵn. Cấu trúc dữ liệu được điền đầy đủ các giá trị trước khi bắt đầu đo thời gian, sau đó mỗi giá trị được truy xuất theo khóa.

![Hiệu suất Lấy](https://github.com/dronnix/bwarr-bench/blob/main/images/get_all_values_by_key.png?raw=true)

#### Duyệt qua
Đo thời gian để duyệt qua tất cả N giá trị theo thứ tự đã sắp xếp và chưa sắp xếp.
![Hiệu suất duyệt theo thứ tự](https://github.com/dronnix/bwarr-bench/blob/main/images/ordered_iteration_over_all_values.png?raw=true)
![Hiệu suất duyệt không theo thứ tự](https://github.com/dronnix/bwarr-bench/blob/main/images/unordered_iteration_over_all_values.png?raw=true)

#### Thêm các bài kiểm tra hiệu năng khác
Các bài kiểm tra hiệu năng bổ sung và chi tiết có sẵn tại kho [bwarr-bench](https://github.com/dronnix/bwarr-bench).
Nhiều phương pháp hơn sẽ được bổ sung, cũng như các bài kiểm tra riêng biệt cho kiến trúc AMD64 và ARM64.

## Cài đặt

Yêu cầu Go 1.22 hoặc cao hơn.

```bash
go get github.com/dronnix/bwarr
```

Sau đó hãy nhập vào mã của bạn:

```go
import "github.com/dronnix/bwarr"
```

## Sử dụng

### Ví dụ cơ bản

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