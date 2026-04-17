
<div align="right">
  <details>
    <summary >🌐 Bahasa</summary>
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


## 📖 Deskripsi Proyek

ASMRoner adalah alat baris perintah berbasis Go untuk mencari, mengunduh, menyinkronkan karya audio asmr.one, serta menyediakan antarmuka web pemutar sederhana.

> 🌐 Proyek turunan: [asmr.furina.in](https://asmr.furina.in) — Sebuah halaman mendengarkan ASMR online yang sederhana dan bersih

## 🚀 Mulai Cepat

```bash
git clone https://github.com/fireinrain/asmroner.git && cd asmroner
go build -o asmroner
./asmroner config   # 交互式初始化配置
```

## 📋 Perintah Umum

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

## 📸 Tangkapan Layar

| Pengaturan | Pencarian |
|:---:|:---:|
| ![Pengaturan](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/config.png) | ![Pencarian](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/search.png) |
| **Unduh** | **Sinkronisasi** |
| ![Unduh](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/download.png) | ![Sinkronisasi](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/sync.png) |
| **Unduh Sinkronisasi** | **Statistik** |
| ![Unduh Sinkronisasi](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/sync-down.png) | ![Statistik](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/sync-report.png) |
| **Antarmuka Web** | **Antarmuka Web 2** |
| ![Antarmuka Web](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/listen.png) | ![Antarmuka Web 2](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/listen2.png) |

<details>
<summary><b>✨ Fitur Utama</b></summary>

- **Pencarian**: RJID tunggal/massal, sintaks pencarian lanjutan, ekspor hasil ke CSV/JSON
- **Unduhan**: Unduhan tunggal/massal/karya populer, pembatasan otomatis, percobaan ulang, backoff eksponensial
- **Sinkronisasi**: Sinkronisasi metadata, kontrol unduhan massal, pelacakan status, percobaan ulang gagal
- **Antarmuka Web**: Penjelajahan visual, pemutaran di dalam browser, desain responsif
- **Pengaturan**: Inisialisasi interaktif, dukungan proxy, pembatasan, jitter, dan pengaturan lanjutan lainnya

</details>

<details>
<summary><b>⚙️ Penjelasan File Konfigurasi</b></summary>

Path file konfigurasi: `~/.asmroner/config.toml` (format TOML)

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
<summary><b>📋 Ringkasan Opsi Perintah</b></summary>

| Perintah | Opsi | Keterangan |
|----------|------|-----------|
| `search` | `-c` | Jumlah hasil pencarian (default 10) |
| `search download` | `-d`, `-s` | Direktori unduhan, jumlah unduhan |
| `search export` | `-f`, `-n` | Nama file ekspor (.csv/.json), jumlah ekspor |
| `download` | `-d`, `-n` | Direktori unduhan, jumlah hot100 |
| `sync download` | `-d` | Direktori unduhan |
| `sync retry` | `-d` | Direktori file gagal |
| `sync export` | `-s`, `-f` | Status (failed/success), file ekspor |
| `listen` | `-p` | Port (default 9999) |

</details>

<details>
<summary><b>📁 Struktur Proyek</b></summary>

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
<summary><b>🛠 Teknologi Stack</b></summary>

| Komponen | Kegunaan |
|------|------|
| Cobra + Viper | Kerangka CLI + Manajemen Konfigurasi |
| GORM + SQLite | Persistensi Data |
| Resty | Klien HTTP (mendukung proxy HTTP/SOCKS5) |
| Pond | Pool Pekerja Konkuren |
| x/time/rate | Pembatasan Laju Token Bucket |
| Gin | Layanan Web |
| Tailwind + Plyr | Antarmuka Frontend + Pemutar Audio |

</details>

<details>
<summary><b>🔧 FAQ</b></summary>

**File konfigurasi tidak ditemukan** → Jalankan `./asmroner config` untuk inisialisasi

**Gagal mengunduh (stream error)** → Program akan mencoba ulang secara otomatis; jika masih gagal, gunakan `sync retry` untuk mencoba lagi, atau cek `.asmroner-data/download_errors.log`

**Antarmuka web tidak dapat diakses** → Pastikan port tidak digunakan, coba tentukan port lain dengan `-p`

**Hasil pencarian kosong** → Periksa sintaks kueri, coba sederhanakan kondisi

</details>

## 🤝 Kontribusi

Silakan ajukan Pull Request! Fork → Buat cabang baru → Komit perubahan → Buka PR.

## 📄 Lisensi

Proyek ini menggunakan Lisensi MIT, silakan lihat file [LICENSE](/LICENSE) untuk detailnya.

## 🙏 Ucapan Terima Kasih


- Terima kasih khusus kepada [go-asmr-spider](https://github.com/DiheChen/go-asmr-spider)
- Terima kasih kepada semua kontributor dan pengguna!

---

**ASMRoner** — Setiap malam ada saudari berbeda yang menemani tidurmu :)

*Pembaruan terakhir: Februari 2026*


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-17

---