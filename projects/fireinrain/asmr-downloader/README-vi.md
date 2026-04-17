
<div align="right">
  <details>
    <summary >🌐 Ngôn ngữ</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=fireinrain&project=asmr-downloader&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=fireinrain&project=asmr-downloader&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=fireinrain&project=asmr-downloader&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=fireinrain&project=asmr-downloader&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=fireinrain&project=asmr-downloader&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=fireinrain&project=asmr-downloader&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=fireinrain&project=asmr-downloader&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=fireinrain&project=asmr-downloader&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=fireinrain&project=asmr-downloader&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=fireinrain&project=asmr-downloader&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=fireinrain&project=asmr-downloader&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=fireinrain&project=asmr-downloader&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=fireinrain&project=asmr-downloader&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=fireinrain&project=asmr-downloader&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=fireinrain&project=asmr-downloader&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=fireinrain&project=asmr-downloader&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=fireinrain&project=asmr-downloader&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=fireinrain&project=asmr-downloader&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=fireinrain&project=asmr-downloader&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=fireinrain&project=asmr-downloader&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=fireinrain&project=asmr-downloader&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>


## 📖 Giới thiệu dự án

ASMRoner là một công cụ dòng lệnh viết bằng Go, dùng để tìm kiếm, tải về, đồng bộ các tác phẩm âm thanh từ asmr.one, đồng thời cung cấp giao diện phát Web đơn giản.

> 🌐 Sản phẩm liên quan: [asmr.furina.in](https://asmr.furina.in) — Trang nghe ASMR trực tuyến đơn giản và sạch sẽ

## 🚀 Bắt đầu nhanh

```bash
git clone https://github.com/fireinrain/asmroner.git && cd asmroner
go build -o asmroner
./asmroner config   # 交互式初始化配置
```

## 📋 Lệnh thường dùng

```bash
# 搜索
./asmroner search "护士" -c 20
./asmroner search "护士,-中出@duration:1h" -c 50

# 下载
./asmroner download RJ01037721 -d ./downloads
./asmroner download RJ01037721,RJ02000001 -d ./downloads
./asmroner download hot100 -n 10 -d ./downloads

# 搜索 + 下载/导出
./asmroner search download "护士" -d ./downloads -s 20
./asmroner search export "护士" -n 100 -f data.json

# 同步元数据 & 批量下载
./asmroner sync
./asmroner sync download -d ./downloads
./asmroner sync retry -d ./downloads
./asmroner sync report

# Web 播放界面
./asmroner listen -p 8080 ./syncdata
```

## 📸 Ảnh chụp màn hình

| Cấu hình | Tìm kiếm |
|:---:|:---:|
| ![Cấu hình](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/config.png) | ![Tìm kiếm](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/search.png) |
| **Tải xuống** | **Đồng bộ** |
| ![Tải xuống](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/download.png) | ![Đồng bộ](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/sync.png) |
| **Đồng bộ tải xuống** | **Thống kê** |
| ![Đồng bộ tải xuống](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/sync-down.png) | ![Thống kê](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/sync-report.png) |
| **Giao diện Web** | **Giao diện Web 2** |
| ![Giao diện Web](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/listen.png) | ![Giao diện Web 2](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/listen2.png) |

<details>
<summary><b>✨ Tính năng nổi bật</b></summary>

- **Tìm kiếm**: Tìm theo RJID đơn/lô, cú pháp tìm kiếm nâng cao, xuất kết quả CSV/JSON
- **Tải xuống**: Tải từng cái/lô/tác phẩm hot, tự động giới hạn tốc độ, thử lại, thoái lui lũy tiến
- **Đồng bộ**: Đồng bộ metadata, kiểm soát tải lô, theo dõi trạng thái, thử lại khi thất bại
- **Giao diện Web**: Duyệt trực quan, phát trong trình duyệt, thiết kế đáp ứng
- **Cấu hình**: Khởi tạo tương tác, hỗ trợ proxy, giới hạn tốc độ, jitter và cấu hình nâng cao

</details>

<details>
<summary><b>⚙️ Hướng dẫn cấu hình</b></summary>

Đường dẫn file cấu hình: `~/.asmroner/config.toml` (định dạng TOML)

```toml
[user]
account = "guest"
password = "guest"

[downloader]
api_url = ""                # 留空自动获取最快站点
proxy_url = ""              # 支持 http / socks5
max_workers = 5
max_retries = 3
sync_data_folder = "./syncdata"
sync_wanted_size = "200MB"  # 同步容量限制
prefer_media = "all"        # all | mp3>wav>flac

[limit]
sync_qps = 2
sync_jitter_min = 100       # ms
sync_jitter_max = 500
download_qps = 0.2
download_jitter_min = 2000
download_jitter_max = 5000
```
</details>

<details>
<summary><b>📋 Bảng tra cứu nhanh tùy chọn lệnh</b></summary>

| Lệnh | Tùy chọn | Giải thích |
|------|------|------|
| `search` | `-c` | Số lượng kết quả tìm kiếm (mặc định 10) |
| `search download` | `-d`, `-s` | Thư mục tải về, số lượng tải về |
| `search export` | `-f`, `-n` | Tên file xuất (.csv/.json), số lượng xuất |
| `download` | `-d`, `-n` | Thư mục tải về, số lượng hot100 |
| `sync download` | `-d` | Thư mục tải về |
| `sync retry` | `-d` | Thư mục chứa file thất bại |
| `sync export` | `-s`, `-f` | Trạng thái (failed/success), file xuất |
| `listen` | `-p` | Cổng (mặc định 9999) |

</details>

<details>
<summary><b>📁 Cấu trúc dự án</b></summary>


```
asmroner/
├── cmd/                # 命令行接口（config/download/search/sync/listen）
├── internal/
│   ├── engine/        # 核心下载引擎（限流、重试、并发控制）
│   ├── logger/        # 结构化日志系统
│   ├── model/         # 数据模型与查询参数解析
│   ├── database/      # SQLite 数据库
│   ├── consts/        # 常量定义
│   └── utils/         # 工具函数
├── webui/             # 内嵌 Web 界面（Tailwind + Plyr）
├── main.go
└── go.mod
```
</details>

<details>
<summary><b>🛠 Ngăn xếp kỹ thuật</b></summary>

| Thành phần | Mục đích |
|------|------|
| Cobra + Viper | Khung CLI + Quản lý cấu hình |
| GORM + SQLite | Lưu trữ dữ liệu bền vững |
| Resty | HTTP client (hỗ trợ HTTP/SOCKS5 proxy) |
| Pond | Bể công việc song song |
| x/time/rate | Giới hạn tốc độ theo thùng token |
| Gin | Dịch vụ Web |
| Tailwind + Plyr | Giao diện frontend + Phát âm thanh |

</details>

<details>
<summary><b>🔧 Câu hỏi thường gặp</b></summary>

**Không tìm thấy file cấu hình** → Chạy `./asmroner config` để khởi tạo

**Tải về thất bại (stream error)** → Chương trình sẽ tự động thử lại; nếu vẫn lỗi, dùng `sync retry` để thử lại, hoặc kiểm tra `.asmroner-data/download_errors.log`

**Không thể truy cập giao diện Web** → Đảm bảo port không bị chiếm dụng, thử dùng `-p` để chỉ định port khác

**Kết quả tìm kiếm rỗng** → Kiểm tra cú pháp truy vấn, thử đơn giản hóa điều kiện

</details>

## 🤝 Đóng góp

Chào mừng gửi Pull Request! Fork → Tạo nhánh mới → Gửi thay đổi → Mở PR.

## 📄 Giấy phép

Dự án này sử dụng giấy phép MIT, chi tiết xem trong file [LICENSE](/LICENSE).

## 🙏 Lời cảm ơn


- Đặc biệt cảm ơn [go-asmr-spider](https://github.com/DiheChen/go-asmr-spider)
- Cảm ơn tất cả các nhà đóng góp và người dùng!

---

**ASMRoner** — Mỗi tối đều có một cô em khác nhau cùng bạn đi vào giấc ngủ :)

*Lần cập nhật cuối: Tháng 2 năm 2026*


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-17

---