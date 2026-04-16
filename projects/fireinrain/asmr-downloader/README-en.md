
## 📖 Project Introduction

ASMRoner is a Go language command-line tool for searching, downloading, and syncing asmr.one audio works, and provides a simple web playback interface.

> 🌐 Derivative work: [asmr.furina.in](https://asmr.furina.in) — a clean and simple online ASMR listening page

## 🚀 Quick Start

```bash
git clone https://github.com/fireinrain/asmroner.git && cd asmroner
go build -o asmroner
./asmroner config   # 交互式初始化配置
```

## 📋 Common Commands

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

## 📸 Screenshots

| Configuration | Search |
|:---:|:---:|
| ![Configuration](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/config.png) | ![Search](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/search.png) |
| **Download** | **Sync** |
| ![Download](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/download.png) | ![Sync](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/sync.png) |
| **Sync Download** | **Statistics** |
| ![Sync Download](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/sync-down.png) | ![Statistics](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/sync-report.png) |
| **Web Interface** | **Web Interface 2** |
| ![Web Interface](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/listen.png) | ![Web Interface 2](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/listen2.png) |

<details>
<summary><b>✨ Features</b></summary>

- **Search**: Single/batch RJID, advanced search syntax, export results as CSV/JSON
- **Download**: Single/batch/popular works download, automatic rate limiting, retries, exponential backoff
- **Sync**: Metadata synchronization, batch download control, status tracking, failure retries
- **Web Interface**: Visual browsing, in-browser playback, responsive design
- **Configuration**: Interactive initialization, supports proxy, rate limiting, jitter, and other advanced settings

</details>

<details>
<summary><b>⚙️ Configuration File Description</b></summary>

Configuration file path: `~/.asmroner/config.toml` (TOML format)

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
<summary><b>📋 Command Options Quick Reference</b></summary>

| Command | Option | Description |
|------|------|------|
| `search` | `-c` | Number of search results (default 10) |
| `search download` | `-d`, `-s` | Download directory, download quantity |
| `search export` | `-f`, `-n` | Export filename (.csv/.json), export quantity |
| `download` | `-d`, `-n` | Download directory, hot100 quantity |
| `sync download` | `-d` | Download directory |
| `sync retry` | `-d` | Directory of failed files |
| `sync export` | `-s`, `-f` | Status (failed/success), export file |
| `listen` | `-p` | Port (default 9999) |

</details>

<details>
<summary><b>📁 Project Structure</b></summary>


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
<summary><b>🛠 Tech Stack</b></summary>

| Component | Purpose |
|------|------|
| Cobra + Viper | CLI framework + configuration management |
| GORM + SQLite | Data persistence |
| Resty | HTTP client (supports HTTP/SOCKS5 proxy) |
| Pond | Concurrent worker pool |
| x/time/rate | Token bucket rate limiting |
| Gin | Web service |
| Tailwind + Plyr | Frontend UI + audio playback |

</details>

<details>
<summary><b>🔧 FAQ</b></summary>

**Configuration file not found** → Run `./asmroner config` to initialize

**Download failed (stream error)** → The program will automatically retry; if it still fails, retry with `sync retry` or check `.asmroner-data/download_errors.log`

**Web interface inaccessible** → Confirm the port is not in use, try specifying another port with `-p`

**Search results empty** → Check query syntax, try simplifying conditions

</details>

## 🤝 Contribution

Pull Requests are welcome! Fork → Create a branch → Make changes → Open a PR.

## 📄 License

This project uses the MIT License. See the [LICENSE](/LICENSE) file for details.

## 🙏 Acknowledgments

- Special thanks to [go-asmr-spider](https://github.com/DiheChen/go-asmr-spider)
- Thanks to all contributors and users!

---

**ASMRoner** — A different sister accompanies you to sleep every night :)

*Last updated: February 2026*


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-16

---