
<div align="right">
  <details>
    <summary >🌐 Ngôn ngữ</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

[![Trạng thái](https://img.shields.io/badge/status-active-brightgreen)](https://github.com/seuusuario/wakeonweb)
[![Giấy phép](https://img.shields.io/badge/license-MIT-blue)](LICENSE)

# Your LastFM

Một ứng dụng Node.js chạy trong container, đồng bộ các bản scrobble từ **Last.fm**, lưu trữ chúng trong cơ sở dữ liệu **SQLite** cục bộ và cung cấp một bảng điều khiển web.

<img width="1718" height="1066" alt="image" src="https://github.com/user-attachments/assets/97d5a9f1-b39a-42ea-9acf-2b4546426a11" />
---

## Dự án

**Your LastFM** là một ứng dụng Node.js được thiết kế để **tự động đồng bộ các scrobble nhạc** từ Last.fm. Ứng dụng lưu giữ lịch sử nghe nhạc của bạn vào cơ sở dữ liệu SQLite cục bộ và cung cấp một giao diện web để trực quan hóa dữ liệu.

Dự án được đóng gói hoàn toàn bằng **Docker**, sử dụng một entrypoint tự động để xử lý khởi tạo cơ sở dữ liệu và thực hiện tuần tự (Đồng bộ trước, sau đó khởi chạy Web API). Ngoài ra, dự án sử dụng **PM2** làm trình quản lý tiến trình bên trong container để đảm bảo dịch vụ web luôn hoạt động và ổn định.

## Tính năng
### Bảng điều khiển web tương tác

- Giao diện web sạch sẽ, hiện đại để trực quan hóa hoạt động nghe nhạc của bạn.

### Tự động đồng bộ Scrobble từ Last.fm

- Định kỳ lấy và lưu trữ lịch sử nghe nhạc (scrobble) của bạn từ Last.fm.
- Đảm bảo dữ liệu của bạn luôn được cập nhật mà không cần thao tác thủ công.

### Cơ sở dữ liệu lịch sử nhạc cục bộ

- Lưu trữ tất cả scrobble vào cơ sở dữ liệu SQLite cục bộ.
- Cho phép truy vấn nhanh và truy cập dữ liệu nghe nhạc lịch sử khi ngoại tuyến.

### Xem Scrobble gần đây

- Hiển thị các bài hát bạn nghe gần nhất.
- Logic thay thế hình ảnh thông minh cho bài hát, album và nghệ sĩ.

### So sánh với bạn bè (Chế độ tương thích)

- So sánh gu âm nhạc của bạn với bạn bè trên Last.fm.
- Hiển thị mức độ tương thích (Rất thấp → Siêu).
- Hiển thị nghệ sĩ, album và bài hát hàng đầu chung.
- Tính toán và chuẩn hóa mức độ tương thích dựa trên dữ liệu nghe thực tế.

### Thẻ nhạc có thể chia sẻ

- Tạo hình ảnh động dựa trên dữ liệu nghe nhạc của bạn.
- Bố cục tối ưu cho bài đăng trên feed và story instagram (9:16)

- Được xây dựng bằng node-canvas để render hình ảnh phía máy chủ.

## Điều kiện tiên quyết

* [Docker](https://docs.docker.com/get-docker/)
* [Docker Compose](https://docs.docker.com/compose/install/)

## Cài đặt

### Tạo file `.env`

```env
LASTFM_API_KEY=your_lastfm_api_key
LASTFM_USERNAME=your_lastfm_username
```

Last.fm: Tạo một tài khoản API [tại đây](https://www.last.fm/api/account/create) để lấy API Key của bạn.

### Docker Compose

```yml
services:
  your-lastfm:
    image: gomaink/your-lastfm
    container_name: your-lastfm
    ports:
      - "1533:1533"
    env_file:
      - .env
    volumes:
      - ./data:/app/data
    restart: unless-stopped
```

Trên terminal:
`docker compose up -d`

Sau đó truy cập:
```
http://localhost:1533
```

(hoặc thay thế `localhost` bằng địa chỉ IP máy chủ của bạn)

## Giấy phép

Dự án này được cấp phép theo Giấy phép MIT.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-27

---