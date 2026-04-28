
<div align="right">
  <details>
    <summary >🌐 Ngôn ngữ</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# cq - Bộ máy truy vấn SQL hiệu năng cao cho tập tin CSV

 [![Xây dựng và kiểm tra đa nền tảng (với hệ thống zig build)](https://github.com/baldimario/cq/actions/workflows/build-zig-cross.yml/badge.svg)](https://github.com/baldimario/cq/actions/workflows/build-zig-cross.yml)

Một bộ xử lý truy vấn SQL nhẹ, nhanh được viết bằng C cho phép thực thi các truy vấn SQL trực tiếp trên tập tin CSV mà không cần cơ sở dữ liệu. Để xem tài liệu đầy đủ, hãy xem thư mục /doc.

 ![cq đang hoạt động](https://raw.githubusercontent.com/baldimario/cq/main/assets/cq.png)

## Tài liệu

- Bắt đầu: `doc/GettingStarted.md`
- Cài đặt: `doc/Installation.md`
- Giao diện dòng lệnh: `doc/CLI.md`
- **TUI (Giao diện người dùng trên Terminal)**: `doc/TUI.md`
- Kiến trúc: `doc/Architecture.md`
- Kiểm thử: `doc/Testing.md`
- Lộ trình phát triển: `doc/Roadmap.md`
- Đóng góp: `doc/Contributing.md`

## Bắt đầu nhanh

Biên dịch: `make`

### Dòng lệnh

Chạy một truy vấn mẫu:
`./build/cq -q "SELECT name, age FROM 'data.csv' WHERE age > 25" -p`

### Giao diện TUI

Khởi động TUI tương tác:
`./build/cqtui data/`

Tính năng:
- Duyệt và mở các tệp CSV dưới dạng bảng
- Thực thi truy vấn SQL một cách tương tác
- Giao diện đa tab cho nhiều bảng
- Điều hướng bằng bàn phím
- Không có phụ thuộc bên ngoài

## Các tệp SQL ví dụ

Kho lưu trữ bao gồm các tệp SQL ví dụ trong thư mục assets/ (example_between.sql, example_aggregation.sql, v.v.). Xem chi tiết trong assets/.

## Tổng quan về dữ liệu & tính năng

- Xem thư mục /doc để biết các phần chi tiết về kiểu dữ liệu, định dạng ngày tháng, định dạng CSV và nhiều hơn nữa.

## Giấy phép

Giấy phép MIT. Xem tệp LICENSE để biết chi tiết.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-28

---