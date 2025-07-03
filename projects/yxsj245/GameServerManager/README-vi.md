# Giới thiệu Dự án
<div align="center">

# ![logo3](https://github.com/user-attachments/assets/8d1a37bd-5955-4dc2-b314-aecb04f985dc)

**Giúp việc triển khai, quản lý và bảo trì máy chủ game trở nên đơn giản và hiệu quả**

[![GitHub Stars](https://badgen.net/github/stars/yxsj245/GameServerManager)](https://github.com/yxsj245/GameServerManager/stargazers)
[![GitHub Release](https://badgen.net/github/release/yxsj245/GameServerManager)](https://github.com/yxsj245/GameServerManager/releases)
[![Docker Pulls](https://badgen.net/docker/pulls/xiaozhu674/gameservermanager)](https://hub.docker.com/r/xiaozhu674/gameservermanager)
[![License](https://badgen.net/github/license/yxsj245/GameServerManager)](https://github.com/yxsj245/GameServerManager/blob/main/LICENSE)

[📖 Tài liệu](http://blogpage.xiaozhuhouses.asia/html6/index.html#/) • [🌐 Trang chủ](http://blogpage.xiaozhuhouses.asia/html5/index.html) • [💬 Nhóm QQ](https://qm.qq.com/q/oNd4HvMj6M)

</div>

---

## 📋 Giới thiệu dự án

GameServerManager (viết tắt GSManager) là một nền tảng quản lý máy chủ game hiện đại dựa trên công nghệ **Docker**, được thiết kế nhằm đơn giản hóa quá trình triển khai, quản lý và bảo trì máy chủ game.

### ✨ Tính năng cốt lõi

- 🐳 **Docker hóa** - Vận hành hoàn toàn dựa trên Docker, cách ly môi trường, tương thích tối ưu
- 🎯 **Triển khai một chạm** - Hỗ trợ triển khai nhanh nhiều tựa game phổ biến
- 🌐 **Giao diện quản lý Web** - Giao diện React hiện đại, trực quan, dễ sử dụng
- 🔧 **Terminal thời gian thực** - Terminal Web tích hợp, hỗ trợ thực thi lệnh trực tiếp
- 📊 **Giám sát tài nguyên** - Theo dõi tài nguyên máy chủ theo thời gian thực
- 🔐 **Quản lý phân quyền** - Hệ thống xác thực người dùng và kiểm soát quyền đầy đủ
- 🎮 **Hỗ trợ đa game** - Hỗ trợ nhiều máy chủ game nổi tiếng trên nền tảng Steam
- 💾 **Lưu trữ dữ liệu bền vững** - Mapping dữ liệu game và file cấu hình ra ngoài, an toàn, đáng tin cậy

![Bảng thông tin container](http://images.server.xiaozhuhouses.asia:40061/i/2025/06/09/wbnc63.png)

---

## 🚀 Bắt đầu nhanh

### Script cài đặt tự động

```bash
rm -f install.py && wget http://blogpage.xiaozhuhouses.asia/api/api1/install.py && python3 install.py
```
> Đối với debian (tự cài docker) và centos, vui lòng cài đặt thủ công, xem chi tiết tại trang tài liệu

---

## 🎮 Game được hỗ trợ

| Tên game | Tên tiếng Trung | Steam ID | Tải ẩn danh | Trạng thái |
|---------|--------|----------|----------|------|
| **Game phổ biến** | | | | |
| Palworld | Ảo Thú Palu | 2394010 | ✅ | 🟢 Hỗ trợ đầy đủ |
| Rust | Rust | 258550 | ✅ | 🟢 Hỗ trợ đầy đủ |
| Satisfactory | Nhà Máy Hạnh Phúc | 1690800 | ✅ | 🟢 Hỗ trợ đầy đủ |
| Valheim | Thần Điện Anh Linh | 896660 | ✅ | 🟢 Hỗ trợ đầy đủ |
| 7 Days to Die | 7 Ngày Tới Chết | 294420 | ✅ | 🟢 Hỗ trợ đầy đủ |
| Project Zomboid | Dự Án Diệt Thây Ma | 380870 | ✅ | 🟢 Hỗ trợ đầy đủ |
| ARK: Survival Evolved | ARK: Sinh Tồn Tiến Hóa | 376030 | ✅ | 🟢 Hỗ trợ đầy đủ |
| **Game bắn súng** | | | | |
| Left 4 Dead 2 | Left 4 Dead 2 | 222860 | ❌ | 🟡 Yêu cầu bản quyền |
| Team Fortress 2 | Team Fortress 2 | 232250 | ✅ | 🟢 Hỗ trợ đầy đủ |
| Squad | Biệt Đội Chiến Thuật | 403240 | ✅ | 🟢 Hỗ trợ đầy đủ |
| Insurgency: Sandstorm | Nổi Loạn: Bão Cát | 581330 | ✅ | 🟢 Hỗ trợ đầy đủ |
| Killing Floor 2 | Killing Floor 2 | 232130 | ✅ | 🟢 Hỗ trợ đầy đủ |
| Insurgency (2014) | Nổi Loạn 2 | 237410 | ✅ | 🟢 Hỗ trợ đầy đủ |
| MORDHAU | MORDHAU | 629800 | ✅ | 🟢 Hỗ trợ đầy đủ |
| No More Room in Hell | Không Còn Chỗ Trong Địa Ngục | 317670 | ✅ | 🟢 Hỗ trợ đầy đủ |
| Fistful of Frags | Fistful of Frags | 295230 | ✅ | 🟢 Hỗ trợ đầy đủ |
| Half-Life | Half-Life | 90 | ✅ | 🟢 Hỗ trợ đầy đủ |
| Half-Life 2: Deathmatch | Half-Life 2 | 232370 | ✅ | 🟢 Hỗ trợ đầy đủ |
| Operation: Harsh Doorstop | Chiến Dịch: Cửa Gắt Gao | 950900 | ✅ | 🟢 Hỗ trợ đầy đủ |
| Vox Machinae | Vox Machinae | 944490 | ✅ | 🟡 Cần cấu hình |
| **Game indie** | | | | |
| Unturned | Unturned | 1110390 | ✅ | 🟢 Hỗ trợ đầy đủ |
| Don't Starve Together | Đừng Để Chết Đói Cùng Nhau | 343050 | ✅ | 🟡 Cần cấu hình |
| Last Oasis | Ốc Đảo Cuối Cùng | 920720 | ✅ | 🟢 Hỗ trợ đầy đủ |
| Hurtworld | Hurtworld | 405100 | ✅ | 🟢 Hỗ trợ đầy đủ |
| Soulmask | Mặt Nạ Linh Hồn | 3017300 | ✅ | 🟢 Hỗ trợ đầy đủ |
| **Game mô phỏng** | | | | |
| Euro Truck Simulator 2 | Euro Truck Simulator 2 | 1948160 | ✅ | 🟡 Cần cấu hình |
| American Truck Simulator | American Truck Simulator | 2239530 | ✅ | 🟡 Cần cấu hình |
| ECO | Sinh Tồn Sinh Thái | 739590 | ✅ | 🟡 Cần cấu hình |

> Nhiều game khác sẽ tiếp tục được bổ sung...

---

## 🏗️ Kiến trúc công nghệ

### Stack công nghệ frontend
- **React 18** - Framework frontend hiện đại
- **Ant Design** - Thư viện UI cấp doanh nghiệp
- **Monaco Editor** - Trình biên tập mã nguồn
- **Xterm.js** - Mô phỏng terminal trên web
- **Vite** - Công cụ build nhanh

### Stack công nghệ backend
- **Python 3.13** - Ngôn ngữ phát triển chính
- **Flask** - Khung Web
- **Gunicorn** - Máy chủ WSGI
- **Docker** - Công nghệ container hóa
- **SteamCMD** - Công cụ dòng lệnh Steam
- **Aria2** - Trình tải đa giao thức

---

## 📁 Cấu trúc dự án

```
GameServerManager/
├── app/                    # Ứng dụng frontend
│   ├── src/               # Mã nguồn React
│   ├── public/            # Tài nguyên tĩnh
│   └── package.json       # Phụ thuộc frontend
├── server/                # Dịch vụ backend
│   ├── api_server.py      # Máy chủ API chính
│   ├── game_installer.py  # Trình cài đặt game
│   ├── pty_manager.py     # Trình quản lý terminal
│   ├── auth_middleware.py # Middleware xác thực
│   └── installgame.json   # Tệp cấu hình game
├── docker-compose.yml     # Tệp điều phối Docker
├── Dockerfile            # Tệp dựng ảnh Docker
└── README.md             # Tài liệu dự án
```

---

## 🔧 Hướng dẫn cấu hình

### Cấu hình cổng
- **5000** - Giao diện quản lý Web
- **27015-27020** - Dải cổng máy chủ game Steam

### Ánh xạ thư mục dữ liệu
- `./game_data` → `/home/steam/games` - Thư mục dữ liệu game
- `./game_file` → `/home/steam/.config` - Thư mục cấu hình game
- `./game_file` → `/home/steam/.local` - Thư mục lưu trữ game

### Biến môi trường
- `TZ=Asia/Shanghai` - Thiết lập múi giờ
- `USE_GUNICORN=true` - Bật Gunicorn
- `GUNICORN_TIMEOUT=120` - Thời gian chờ yêu cầu
- `GUNICORN_PORT=5000` - Cổng dịch vụ

---

## 🤝 Hướng dẫn đóng góp

Chúng tôi hoan nghênh mọi hình thức đóng góp!

1. **Fork** dự án này
2. Tạo nhánh tính năng của bạn (`git checkout -b feature/AmazingFeature`)
3. Gửi thay đổi của bạn (`git commit -m 'Add some AmazingFeature'`)
4. Đẩy lên nhánh (`git push origin feature/AmazingFeature`)
5. Mở một **Pull Request**

---

## 📞 Hỗ trợ & Phản hồi

- 🐛 **Báo lỗi**：[GitHub Issues](https://github.com/yxsj245/GameServerManager/issues)
- 💬 **Nhóm QQ**：1040201322
- 📖 **Tài liệu chi tiết**：[Xem tài liệu](http://blogpage.xiaozhuhouses.asia/html6/index.html#/)

---

## 📄 Giấy phép mã nguồn mở

Dự án này sử dụng giấy phép [AGPL-3.0 license](LICENSE).

---

## 👨‍💻 Về tác giả

Dự án này được phát triển và duy trì độc lập bởi **又菜又爱玩的小朱**.

Nếu dự án này hữu ích với bạn, hãy ⭐ Star để ủng hộ nhé!

---

## 📈 Thống kê dự án

![Star History](https://api.star-history.com/svg?repos=yxsj245/GameServerManager&type=Date)

---

<div align="center">

**🎮 Quản lý máy chủ game trở nên đơn giản và thú vị!**

</div>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-03

---