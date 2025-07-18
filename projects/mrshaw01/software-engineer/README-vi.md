<div align="right">
  <details>
    <summary >🌐 Ngôn ngữ</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

<div align="center">
  <h1>Kỹ Sư Phần Mềm</h1>
  <p>
    <img src="https://img.shields.io/github/actions/workflow/status/mrshaw01/software-engineer/pre-commit.yml?branch=main&label=pre-commit&logo=pre-commit&logoColor=white" alt="pre-commit status">
  </p>

  <p>
    <img src="https://img.shields.io/github/last-commit/mrshaw01/software-engineer" alt="Last Commit">
    <img src="https://img.shields.io/github/issues/mrshaw01/software-engineer" alt="Issues">
    <img src="https://img.shields.io/github/issues-pr/mrshaw01/software-engineer" alt="Pull Requests">
  </p>
</div>

Một bộ sưu tập được chọn lọc, chất lượng cao về các tài nguyên học tập tập trung vào **Python** và sắp tới là **C/C++**, được thiết kế để xây dựng nền tảng vững chắc về kỹ thuật phần mềm và hiểu biết ở cấp độ hệ thống.

## Cấu Trúc Kho Lưu Trữ

```text
.
├── python-basic/           # Essential Python syntax, data types, and operations
├── python-advanced/        # Decorators, threading, logging, JSON, and more
├── python-OOP/             # Deep dive into Python's object-oriented programming
├── cpp-basic/              # Fundamentals of C++: syntax, memory, pointers, etc.
├── cpp-advanced/           # Advanced C++: RAII, noexcept, smart pointers, RVO, etc.
├── cpp-OOP/                # Object-oriented programming in C++
├── CUDA/                   # GPU programming with CUDA (host & device code)
├── MPI/                    # Message Passing Interface programming and demos
├── docs/                   # System-level notes on performance, Python-C++ interop, mixed precision, etc.
└── README.md               # Project overview (this file)
```
## Cách Sử Dụng

Mỗi thư mục được đánh số chứa một tệp `README.md` giải thích các khái niệm, cùng với các tệp `.py` có thể chạy được. Ví dụ:


```bash
cd python-advanced/08-decorators
python basic_function_decorator.py
```
Một số script yêu cầu thư viện bên thứ ba (ví dụ: `numpy`, `scipy`, `torch`).

Tất cả mã đều tương thích với **Python 3.7+** và được viết theo tiêu chí **tối giản, tập trung, và dễ kiểm thử**.

## Điểm Nổi Bật

### Python

- **Thành thạo OOP**: Lớp, kế thừa, metaclass, descriptor (`python-OOP/`)
- **Chủ đề nâng cao**: Decorator, context manager, lưu trữ hàm, đồng thời
- **Cấu trúc dữ liệu**: List, tuple, dict, set cùng ví dụ thực tiễn

### C++

- **C++ Cơ bản**: Cú pháp, hàm, con trỏ, struct, phạm vi, enum (`cpp-basic/`)
- **C++ Hiện đại**: RAII, smart pointer, move semantics, alignment, RVO (`cpp-advanced/`)
- **C++ OOP**: Lớp, phạm vi truy cập, kế thừa, đa hình, template

### Hệ thống & Hiệu năng

- **Lập trình CUDA**: Mô hình host/device, khởi chạy kernel, quản lý bộ nhớ (`CUDA/`)
- **Lập trình MPI**: Chương trình phân tán thực tế, phép toán ma trận, kiểm thử (`MPI/`)
- **Tài liệu**: Giao tiếp Python-C++, xử lý GIL, tối ưu CUDA, huấn luyện mixed precision (`docs/`)

## Triết Lý Học Tập

- Ví dụ nhỏ, mô-đun — không dùng notebook rối rắm
- Rõ ràng giữa khái niệm, mã, và bình luận
- Nhấn mạnh thiết kế, hiệu năng, và khả năng bảo trì
- Xây dựng kiến thức dần dần — lý tưởng cho người học nghiêm túc và chuyên gia

## Lịch Sử Star

<a href="https://www.star-history.com/#mrshaw01/software-engineer&Date">
 <picture>
   <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=mrshaw01/software-engineer&type=Date&theme=dark" />
   <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=mrshaw01/software-engineer&type=Date" />
   <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=mrshaw01/software-engineer&type=Date" />
 </picture>
</a>

## 🤝 Đóng Góp

Tìm thấy lỗi, sai chính tả, hoặc muốn mở rộng? Hãy mở PR — tất cả đóng góp đều được chào đón.

<p align="center">
  <a href="https://github.com/mrshaw01/software-engineer/graphs/contributors">
    <img src="https://contrib.rocks/image?repo=mrshaw01/software-engineer" />
  </a>
</p>

## 📄 Giấy phép

MIT License — tự do sử dụng, chỉnh sửa và chia sẻ cho mục đích học tập và giảng dạy.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---