<div align="center">

<h1 style="border-bottom: none">
    <b><a href="https://next.yearning.io">Yearning</a></b><br />
</h1>
</div>

 Một nền tảng mạnh mẽ, triển khai cục bộ được thiết kế cho việc phát hiện SQL liền mạch và kiểm toán truy vấn, dành riêng cho các DBA và nhà phát triển. Tập trung vào quyền riêng tư và hiệu suất, nền tảng này cung cấp một môi trường trực quan và an toàn cho kiểm toán MYSQL.

---
[![OSCS Status](https://www.oscs1024.com/platform/badge/cookieY/Yearning.svg?size=small)](https://www.murphysec.com/dr/nDuoncnUbuFMdrZsh7)
![Platform Support](https://img.shields.io/badge/-x86_x64%20ARM%20Supports%20%E2%86%92-rgb(84,56,255)?style=flat-square&logoColor=white&logo=linux)
[![][github-license-shield]][github-license-link]
![GitHub top language](https://img.shields.io/github/languages/top/cookieY/Yearning?color=369eff&label=golang&labelColor=black&logo=golang&logoColor=white&style=flat-square)
[![][github-forks-shield]][github-forks-link]
[![][github-stars-shield]][github-stars-link]
[![Downloads](https://img.shields.io/github/downloads/cookieY/Yearning/total?labelColor=black&logo=download&logoColor=white&style=flat-square)](https://github.com/cookieY/Yearning/releases/latest)

English | [简体中文](https://raw.githubusercontent.com/cookieY/Yearning/next/README.zh-CN.md) | [日本語](https://raw.githubusercontent.com/cookieY/Yearning/next/README.ja-JP.md)

## ✨ Tính năng

- **Trợ lý AI**: Trợ lý AI của chúng tôi cung cấp các gợi ý tối ưu hóa SQL theo thời gian thực, nâng cao hiệu suất SQL. Nó cũng hỗ trợ chuyển đổi từ văn bản sang SQL, cho phép người dùng nhập ngôn ngữ tự nhiên và nhận về các câu lệnh SQL đã được tối ưu hóa.
  
- **Kiểm toán SQL**: Tạo phiếu kiểm toán SQL với quy trình phê duyệt và kiểm tra cú pháp tự động. Xác thực các câu lệnh SQL về tính chính xác, bảo mật và tuân thủ. Các câu lệnh rollback được tự động tạo cho các thao tác DDL/DML, với lịch sử ghi nhận đầy đủ để truy xuất nguồn gốc.

- **Kiểm toán truy vấn**: Kiểm toán các truy vấn của người dùng, hạn chế nguồn dữ liệu và cơ sở dữ liệu, và ẩn danh các trường nhạy cảm. Các bản ghi truy vấn được lưu lại để tham khảo trong tương lai.

- **Quy tắc kiểm tra**: Bộ kiểm tra cú pháp tự động của chúng tôi hỗ trợ nhiều quy tắc kiểm tra, phù hợp với hầu hết các tình huống kiểm tra tự động.

- **Tập trung vào quyền riêng tư**: Yearning là giải pháp mã nguồn mở, triển khai cục bộ, đảm bảo an toàn cho cơ sở dữ liệu và các câu lệnh SQL của bạn. Nó bao gồm cơ chế mã hóa để bảo vệ dữ liệu nhạy cảm, đảm bảo an toàn ngay cả khi bị truy cập trái phép.

- **RBAC (Kiểm soát truy cập dựa trên vai trò)**: Tạo và quản lý các vai trò với quyền hạn cụ thể, hạn chế truy cập vào các lệnh truy vấn, chức năng kiểm toán và các thao tác nhạy cảm khác dựa trên vai trò người dùng.

> \[!TIP]
> Để biết thêm thông tin chi tiết, vui lòng truy cập [Hướng dẫn Yearning](https://next.yearning.io)


## ⚙️ Cài đặt

Tải về [phiên bản mới nhất](https://github.com/cookieY/Yearning/releases/latest) và giải nén. Đảm bảo bạn đã cấu hình `./config.toml` trước khi tiếp tục.

### Cài đặt thủ công

```bash
## Khởi tạo cơ sở dữ liệu
./Yearning install

## Khởi động Yearning
./Yearning run

## Trợ giúp
./Yearning --help
```

### 🚀 Triển khai với Docker
[![][docker-release-shield]][docker-release-link]
[![][docker-size-shield]][docker-size-link]
[![][docker-pulls-shield]][docker-pulls-link]
```bash
## Khởi tạo cơ sở dữ liệu
docker run --rm -it -p8000:8000 -e SECRET_KEY=$SECRET_KEY -e MYSQL_USER=$MYSQL_USER -e MYSQL_ADDR=$MYSQL_ADDR -e MYSQL_PASSWORD=$MYSQL_PASSWORD -e MYSQL_DB=$Yearning_DB -e Y_LANG=zh_CN yeelabs/yearning "/opt/Yearning install"

## Khởi động Yearning
docker run -d -it -p8000:8000 -e SECRET_KEY=$SECRET_KEY -e MYSQL_USER=$MYSQL_USER -e MYSQL_ADDR=$MYSQL_ADDR -e MYSQL_PASSWORD=$MYSQL_PASSWORD -e MYSQL_DB=$Yearning_DB -e Y_LANG=zh_CN yeelabs/yearning
```
## 🤖 Trợ lý AI

Trợ lý AI của chúng tôi tận dụng mô hình ngôn ngữ lớn để cung cấp các gợi ý tối ưu hóa SQL và chuyển đổi văn bản thành SQL. Dù sử dụng prompt mặc định hay tùy chỉnh, Trợ lý AI sẽ cải thiện hiệu suất SQL bằng cách tối ưu hóa các câu lệnh và chuyển đổi đầu vào ngôn ngữ tự nhiên thành truy vấn SQL.

![Text to SQL](https://raw.githubusercontent.com/cookieY/Yearning/next/img/text2sql.jpg)

## 🔖 Kiểm tra SQL tự động

Bộ kiểm tra SQL tự động đánh giá các câu lệnh SQL dựa trên các quy tắc và cú pháp được xác định trước. Nó đảm bảo rằng các câu lệnh tuân thủ các tiêu chuẩn mã hóa cụ thể, thực tiễn tốt nhất và yêu cầu về bảo mật, cung cấp một lớp xác thực mạnh mẽ.

![SQL Audit](https://raw.githubusercontent.com/cookieY/Yearning/next/img/audit.png)

## 💡 Tô sáng cú pháp SQL và tự động hoàn thành

Nâng cao hiệu quả viết truy vấn của bạn với chức năng tô sáng cú pháp SQL và tự động hoàn thành. Những tính năng này giúp người dùng dễ dàng phân biệt các thành phần khác nhau của truy vấn SQL, như từ khóa, tên bảng, tên cột và toán tử, giúp việc đọc và hiểu cấu trúc truy vấn dễ dàng hơn.

![SQL Query](https://raw.githubusercontent.com/cookieY/Yearning/next/img/query.png)

## ⏺️ Ghi nhận Lệnh/Truy vấn

Nền tảng của chúng tôi hỗ trợ kiểm toán các câu lệnh lệnh và truy vấn của người dùng. Tính năng này cho phép bạn theo dõi và ghi lại tất cả các thao tác truy vấn, bao gồm nguồn dữ liệu, cơ sở dữ liệu, và xử lý các trường nhạy cảm, đảm bảo tuân thủ quy định và cung cấp khả năng truy xuất lịch sử truy vấn.

![Order/Query Record](https://raw.githubusercontent.com/cookieY/Yearning/next/img/record.png)

Bằng cách tập trung vào các tính năng chính này, Yearning nâng cao trải nghiệm người dùng, tối ưu hóa hiệu suất SQL, và đảm bảo tuân thủ cũng như truy xuất nguồn gốc mạnh mẽ trong các hoạt động cơ sở dữ liệu.

## 🛠️ Công cụ đề xuất

- [Spug - Nền tảng Tự động hóa Vận hành nhẹ mã nguồn mở](https://github.com/openspug/spug)

## ☎️ Liên hệ

Mọi thắc mắc, vui lòng gửi email đến: henry@yearning.io
## 📋 Giấy phép

Yearning được cấp phép theo giấy phép AGPL. Xem [LICENSE](LICENSE) để biết chi tiết.

2024 © Henry Yee

---

Với Yearning, trải nghiệm một phương pháp kiểm toán và tối ưu hóa SQL tinh gọn, an toàn và hiệu quả.


[docker-pulls-link]: https://hub.docker.com/r/yeelabs/yearning
[docker-pulls-shield]: https://img.shields.io/docker/pulls/yeelabs/yearning?color=45cc11&labelColor=black&style=flat-square
[docker-release-link]: https://hub.docker.com/r/yeelabs/yearning
[docker-release-shield]: https://img.shields.io/docker/v/yeelabs/yearning?color=369eff&label=docker&labelColor=black&logo=docker&logoColor=white&style=flat-square
[docker-size-link]: https://hub.docker.com/r/yeelabs/yearning
[docker-size-shield]: https://img.shields.io/docker/image-size/yeelabs/yearning?color=369eff&labelColor=black&style=flat-square
[github-forks-shield]: https://img.shields.io/github/forks/cookieY/Yearning?color=8ae8ff&labelColor=black&style=flat-square
[github-forks-link]: https://github.com/cookieY/Yearning/network/members
[github-stars-link]: https://github.com/cookieY/Yearning/network/stargazers
[github-stars-shield]: https://img.shields.io/github/stars/cookieY/Yearning?color=ffcb47&labelColor=black&style=flat-square
[github-license-link]: https://github.com/cookieY/Yearning/blob/main/LICENSE
[github-license-shield]: https://img.shields.io/badge/AGPL%203.0-white?labelColor=black&style=flat-square


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-29

---