
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
https://github.com/MIKANOoOo/asmr-downloader.git && cd asmroner
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

  # 导出单个作品或指定数量热门榜链接 & 导出到指定目录
./asmroner export RJ01544940 -o ./downloads
./asmroner export hot100 -n 20 -o ./downloads
./asmroner export hot100 -n 10 -o ./downloads
更多内容参考常见问题中的guide

# Web 播放界面
./asmroner listen -p 8080 ./syncdata
```

## 📸 Tangkapan Layar

| Pengaturan | Pencarian |
|:---:|:---:|
| ![Pengaturan](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/config.png) | ![Pencarian](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/search.png) |
| **Unduh** | **Sinkronisasi** |
| ![Unduh](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/download.png) | ![Sinkronisasi](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/sync.png) |
| **Sinkronisasi & Unduh** | **Statistik** |
| ![Sinkronisasi & Unduh](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/sync-down.png) | ![Statistik](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/sync-report.png) |
| **Antarmuka Web** | **Antarmuka Web 2** |
| ![Antarmuka Web](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/listen.png) | ![Antarmuka Web 2](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/listen2.png) |
| **Antarmuka export** | **Antarmuka export 2** |
| ![Antarmuka export](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/export1.png) | ![Antarmuka export 2](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/export2.png) |

<details>
<summary><b>✨ Fitur dan Keunggulan</b></summary>

- **Pencarian**: RJID tunggal/massal, sintaks pencarian lanjutan, ekspor hasil ke CSV/JSON
- **Unduh**: Unduh karya tunggal/massal/populer, pembatasan otomatis, coba ulang, eksponensial backoff
- **Sinkronisasi**: Sinkronisasi metadata, kontrol unduhan massal, pelacakan status, coba ulang jika gagal
- **Antarmuka Web**: Penjelajahan visual, pemutaran dalam browser, desain responsif
- **Pengaturan**: Inisialisasi interaktif, mendukung proxy, pembatasan, jitter, dan konfigurasi lanjutan lainnya

</details>

<details>
<summary><b>⚙️ Penjelasan Berkas Konfigurasi</b></summary>

Lokasi berkas konfigurasi: `~/.asmroner/config.toml` (format TOML)

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
<summary><b>📋 Tinjauan Cepat Opsi Perintah</b></summary>

| Perintah | Opsi | Keterangan |
|------|------|------|
| `search` | `-c` | Jumlah hasil pencarian (default 10) |
| `search download` | `-d`, `-s` | Direktori unduh, jumlah unduhan |
| `search export` | `-f`, `-n` | Nama file ekspor (.csv/.json), jumlah ekspor |
| `download` | `-d`, `-n` | Direktori unduh, jumlah hot100 |
| `sync download` | `-d` | Direktori unduh |
| `sync retry` | `-d` | Direktori file gagal |
| `sync export` | `-s`, `-f` | Status (failed/success), file ekspor |
| `listen` | `-p` | Port (default 9999) |
| `export` | `-o`, `-n` | Direktori ekspor, jumlah hot100 |

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
| Cobra + Viper | Framework CLI + Manajemen Konfigurasi |
| GORM + SQLite | Persistensi Data |
| Resty | Klien HTTP (mendukung proxy HTTP/SOCKS5) |
| Pond | Pool Pekerja Konkuren |
| x/time/rate | Pembatasan Laju Token Bucket |
| Gin | Layanan Web |
| Tailwind + Plyr | Antarmuka Frontend + Pemutar Audio |

</details>

<details>
<summary><b>🔧 Masalah Umum</b></summary>

**File konfigurasi tidak ditemukan** → Jalankan `./asmroner config` untuk inisialisasi

**Gagal mengunduh (stream error)** → Program akan mencoba ulang otomatis; jika masih gagal, gunakan `sync retry` untuk mencoba ulang, atau cek `.asmroner-data/download_errors.log`

**Antarmuka web tidak dapat diakses** → Pastikan port tidak digunakan, coba gunakan `-p` untuk menentukan port lain

**Hasil pencarian kosong** → Periksa sintaks query, coba sederhanakan kondisi

**Metode unduh untuk perintah export** → Lihat [guide](/dist/guide.pdf) 

</details>

## 🤝 Kontribusi

Silakan ajukan Pull Request! Fork → Buat cabang baru → Komit perubahan → Ajukan PR.

## 📄 Lisensi

Proyek ini menggunakan lisensi MIT, lihat detailnya pada file [LICENSE](/LICENSE).


## 🙏 致谢

- 特别感谢 [go-asmr-spider](https://github.com/DiheChen/go-asmr-spider)
- 感谢所有贡献者和用户！

---

**ASMRoner** — 每天晚上都有不同的妹妹陪你入睡 :)

*最后更新：2026 年 2 月*


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-05

---