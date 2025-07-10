<p align="center">
  <a href="https://www.jukeboxhq.com">
    <img height="500" src="https://raw.githubusercontent.com/skeptrunedev/jukebox/main/frontend/public/opengraph-image.jpg" alt="Trieve Logo">
  </a>
</p>

<p align="center">
  <a href="https://hub.docker.com/r/skeptrune/jukebox-server" style="text-decoration: none;">
    <img src="https://img.shields.io/docker/pulls/skeptrune/jukebox-server?style=flat-square" alt="Docker Pulls" />
  </a>
  <a href="https://github.com/skeptrunedev/jukebox/stargazers" style="text-decoration: none;">
    <img src="https://img.shields.io/github/stars/skeptrunedev/jukebox?style=flat-square" alt="GitHub stars" />
  </a>
  <a href="https://x.com/skeptrune" style="text-decoration: none;">
    <img src="https://img.shields.io/badge/follow%20on-x.com-1da1f2?logo=x&style=flat-square" alt="Follow on X (Twitter)" />
  </a>
</p>

---
# Biến Mọi Thiết Bị Thành Một Jukebox Hợp Tác

**Jukebox** cho phép bạn tạo ngay một danh sách phát nhạc chia sẻ với bạn bè—không cần ứng dụng, không cần đăng nhập, không có quảng cáo. Chỉ cần tạo một box, chia sẻ liên kết và bắt đầu thêm bài hát cùng nhau. Hoàn hảo cho các bữa tiệc, chuyến đi, hoặc bất kỳ buổi tụ họp nhóm nào!

- 🌐 **Nguồn Mở Thay Thế Cho Danh Sách Phát Hợp Tác Của Spotify**
- 🕵️ **Không Cần Tài Khoản**: Sử dụng ẩn danh—không cần đăng ký hoặc email
- ✨ **Chia Sẻ Liên Kết, Thêm Bài Hát Cùng Nhau**: Mọi người đều có thể đóng góp theo thời gian thực
- 🚀 **Không Cần Tải Ứng Dụng**: Hoạt động trên mọi thiết bị, ngay trong trình duyệt của bạn
- 🎵 **Tích Hợp YouTube**: Tìm kiếm và phát gần như bất kỳ bài hát nào tức thì
- 📱 **Thân Thiện Với Thiết Bị Di Động**: Thiết kế cho điện thoại, máy tính bảng và máy tính để bàn
- ⚖️ **Xếp Hàng Công Bằng**: Bài hát được tự động sắp xếp để mọi người đều có lượt
- 🆓 **Hoàn Toàn Miễn Phí, Không Quảng Cáo**

---

## Thử Ngay

1. **Tạo Một Jukebox**: Truy cập trang chủ và tạo một box mới
2. **Chia Sẻ Liên Kết**: Gửi liên kết mời cho bạn bè của bạn
3. **Thêm Bài Hát**: Tìm kiếm trên YouTube hoặc thêm bài hát thủ công
4. **Phát Nhạc**: Sử dụng trình phát tích hợp để nghe cùng nhau

---
## Tính năng

- Danh sách phát cộng tác: Thêm, xếp hàng và phát nhạc cùng nhau
- Sử dụng ẩn danh: Không cần đăng nhập hoặc tài khoản
- Tìm kiếm & phát nhạc YouTube: Truy cập thư viện nhạc khổng lồ
- Giao diện ưu tiên di động, phản hồi nhanh
- Mã nguồn mở (Giấy phép MIT)
- Triển khai dễ dàng với Docker

### Triển khai với Docker Compose

Khởi động tất cả dịch vụ:

```bash
docker-compose up -d
```

Triển khai lại dịch vụ không gián đoạn sau khi cập nhật image:

```bash
bash ./redeploy.sh
```
---

## Bắt đầu

### Yêu cầu tiên quyết

- Node.js 16+
- npm hoặc yarn
- Khóa YouTube Data API v3 (miễn phí từ Google)

### Thiết lập YouTube API

1. Truy cập [Google Cloud Console](https://console.cloud.google.com/)
2. Tạo một dự án mới hoặc chọn một dự án hiện có
3. Kích hoạt **YouTube Data API v3**
4. Tạo thông tin xác thực (API Key)
5. Sao chép khóa API của bạn

### Cài đặt
```bash
# Sao chép kho lưu trữ
git clone <your-repo-url>
cd jukebox

# Cài đặt các phụ thuộc cho server
cd server
yarn install

# Cài đặt các phụ thuộc cho frontend
cd ../frontend
yarn install

# Cấu hình biến môi trường
cd ../server
cp .env.example .env
# Chỉnh sửa .env và thêm khóa API YouTube của bạn

# Chạy các bản di trú cơ sở dữ liệu
```
yarn migrate

# Khởi động các máy chủ phát triển
# Backend:
cd server
yarn dev
# Worker:
cd server
yarn dev:worker
# Frontend (trong một terminal mới):
cd frontend
yarn dev
```

---

## Giấy phép

MIT

---
## Đóng góp & Phản hồi

- Mở một issue hoặc pull request trên [GitHub](https://github.com/skeptrunedev/jukebox)
- Yêu cầu tính năng? Nhắn tin cho [@skeptrune trên X (Twitter)](https://twitter.com/skeptrune)

---

## Lịch sử thay đổi

Xem [Lịch sử thay đổi](https://jukebox.skeptrune.com#changelog) để biết các cập nhật và tính năng mới nhất.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-10

---