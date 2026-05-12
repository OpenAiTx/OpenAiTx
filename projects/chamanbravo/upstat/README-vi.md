
<div align="right">
  <details>
    <summary >🌐 Ngôn ngữ</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

<div align="center" width="100%">
    <img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/upstat.png" width="128" alt="" />
</div>

# Upstat

> công cụ giám sát trạng thái tự lưu trữ đơn giản và dễ sử dụng

![](https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/dashboard.png)

## 💻 Trình diễn trực tiếp

Thử ngay.

Máy chủ demo (Vị trí: Singapore): [https://demo.upstat.com](https://upstat.chamanbudhathoki.com.np/)

Tên đăng nhập: `demo`
Mật khẩu: `demodemo`

## ⭐ Tính năng

Cần thêm nhiều tính năng nữa nhưng hiện tại...

- Giám sát thời gian hoạt động cho HTTP(s)
- Biểu đồ trạng thái và độ trễ
- Thông báo qua Discord
- Khoảng thời gian 60 giây
- Giao diện UI/UX đẹp, phản ứng nhanh, mượt mà
- Nhiều trang trạng thái
- Ánh xạ trang trạng thái tới các tên miền cụ thể
- Biểu đồ ping
- Thông tin chứng chỉ
- PWA
- Hỗ trợ cơ sở dữ liệu Sqlite & Postgres

Và hàng tá tính năng nhỏ sẽ được bổ sung.

## 🔧 Cách cài đặt

### 🐳 Docker

Đối với Sqlite

```bash
curl https://raw.githubusercontent.com/chamanbravo/upstat/main/docker-compose-sqlite.yml -o docker-compose.yml
docker compose up
```

Dành cho Postgres

```bash
curl -O https://raw.githubusercontent.com/chamanbravo/upstat/main/docker-compose.yml
docker compose up
```

Upstat hiện đang chạy trên http://localhost:3000

> [!QUAN TRỌNG]
> Hãy đảm bảo thay đổi các giá trị môi trường trước khi triển khai.

### 💪🏻 Không dùng Docker

Yêu cầu:

- Node.js 14 / 16 / 18 / 20.4
- npm 9
- Golang 1.21+
- Postgres (Tùy chọn)

```shell
cp .sample.env .env
```

```shell
air
cd web && npm run dev
```

## Công nghệ sử dụng

- React
- Shadcn
- Golang
- Postgres/Sqlite

## 🙌 Đóng góp

Tôi hoan nghênh mọi đóng góp! Đóng góp chính là yếu tố làm cho cộng đồng mã nguồn mở trở thành một nơi tuyệt vời để học hỏi, truyền cảm hứng và sáng tạo. Mọi đóng góp của bạn đều **được đánh giá rất cao**.

Nếu bạn có đề xuất để cải thiện dự án, hãy fork repo, thực hiện thay đổi và tạo pull request. Bạn cũng có thể mở một issue với tag "enhancement".
Đừng quên cho dự án một ngôi sao! Cảm ơn bạn rất nhiều!

1. Fork dự án
2. Tạo nhánh tính năng của bạn (`git checkout -b feature/AmazingFeature`)
3. Commit các thay đổi của bạn (`git commit -m 'Add some AmazingFeature'`)
4. Đẩy lên nhánh (`git push origin feature/AmazingFeature`)
5. Mở Pull Request

## Người đóng góp

<a href="https://github.com/chamanbravo/upstat/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=chamanbravo/upstat" />
</a>

## 📄 Giấy phép

Dự án này được cấp phép theo [Giấy phép MIT](https://opensource.org/license/mit/).

## 🖼 Thêm ảnh chụp màn hình

Tạo một Monitor

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/create.png" width="512" alt="" />

Trang Monitor

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/chart.png" width="512" alt="" />

Settings Page

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/settings.png" width="512" alt="" />

Notifications

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/notifications.png" width="512" alt="" />

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/discord_notification.png" width="512" alt="" />


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-12

---