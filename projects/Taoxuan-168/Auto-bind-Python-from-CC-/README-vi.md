<div align="right">
  <details>
    <summary >🌐 Ngôn ngữ</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

Tự động bind Python từ CC++
===================

> Một dự án đủ đơn giản, dễ sử dụng và có thể cấu hình để tự động bind code C/C++ thành code Python và tạo ra gói whl

> Dự án này được fork từ:
https://github.com/Neutree/c_cpp_project_framework
và phần biên dịch mã nguồn giữ nguyên như kho gốc


> Một số mã tham khảo về tự động binding bằng pybind11:
https://github.com/sipeed/MaixPy/tree/main/components/maix


## Khởi động nhanh

* 1. Clone kho này, vào thư mục /examples/demo
Dùng python project.py menuconfig để vào giao diện cấu hình chuỗi công cụ biên dịch cũng như đóng gói file whl
![alt text](https://raw.githubusercontent.com/Taoxuan-168/Auto-bind-Python-from-CC-/main/./assets/image.png)
> Trong đó x86 là biên dịch trên máy tính, arm64 là biên dịch cho MaixCam2, RISCV64 là biên dịch cho MaiCam/Pro
![alt text](https://raw.githubusercontent.com/Taoxuan-168/Auto-bind-Python-from-CC-/main/./assets/image-1.png)
* 2. Viết một hàm C/C++, và file hpp header, cần đặt tên giống file whl để dễ tự động nhận diện:
```C++
namespace add::test
{
    int add(int a, int b) 
    {
        return a + b;
    }
}
```
Viết chú thích @modul cho hàm tương ứng, phía sau ghi đường dẫn hàm:
```C++
namespace add::test
{
    /**
     * My function, add two integer.
     * @param a arg a, int type
     * @param b arg b, int type
     * @return int type, will a + b
     * @module add.test.add
     */
    int add(int a, int b);
}
```
Dòng đầu tiên là giới thiệu hàm, @param là giới thiệu tham số, @return là giới thiệu giá trị trả về (có thể để trống)
Nếu chỉ cần biên dịch và đóng gói thành tệp whl thì không cần sửa đổi main.cpp
Chỉ cần sử dụng python project build để bắt đầu biên dịch và đóng gói tệp whl
Sau khi biên dịch và cài đặt whl, có thể trực tiếp gọi:
```Python
import add
add.test.add(1,1)
```
Lưu ý:
-   Một tệp tiêu đề đại diện cho một tên mô-đun, chỉ ra mô-đun cần import, ví dụ add.hpp tương ứng với import add, tên mô-đun này phải bắt đầu bằng add
-   Chạy trực tiếp cpp_bind_python.py chỉ tạo ra tệp cpp đã liên kết, thêm tham số --doc DOC có thể tự động tạo tài liệu từ chú thích

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-06

---