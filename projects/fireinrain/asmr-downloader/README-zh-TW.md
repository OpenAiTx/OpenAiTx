
<div align="right">
  <details>
    <summary >🌐 語言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=fireinrain&project=asmr-downloader&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=fireinrain&project=asmr-downloader&lang=zh-CN">簡體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=fireinrain&project=asmr-downloader&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=fireinrain&project=asmr-downloader&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=fireinrain&project=asmr-downloader&lang=ko">韓國語</a>
        | <a href="https://openaitx.github.io/view.html?user=fireinrain&project=asmr-downloader&lang=hi">印地語</a>
        | <a href="https://openaitx.github.io/view.html?user=fireinrain&project=asmr-downloader&lang=th">泰語</a>
        | <a href="https://openaitx.github.io/view.html?user=fireinrain&project=asmr-downloader&lang=fr">法語</a>
        | <a href="https://openaitx.github.io/view.html?user=fireinrain&project=asmr-downloader&lang=de">德語</a>
        | <a href="https://openaitx.github.io/view.html?user=fireinrain&project=asmr-downloader&lang=es">西班牙語</a>
        | <a href="https://openaitx.github.io/view.html?user=fireinrain&project=asmr-downloader&lang=it">義大利語</a>
        | <a href="https://openaitx.github.io/view.html?user=fireinrain&project=asmr-downloader&lang=ru">俄語</a>
        | <a href="https://openaitx.github.io/view.html?user=fireinrain&project=asmr-downloader&lang=pt">葡萄牙語</a>
        | <a href="https://openaitx.github.io/view.html?user=fireinrain&project=asmr-downloader&lang=nl">荷蘭語</a>
        | <a href="https://openaitx.github.io/view.html?user=fireinrain&project=asmr-downloader&lang=pl">波蘭語</a>
        | <a href="https://openaitx.github.io/view.html?user=fireinrain&project=asmr-downloader&lang=ar">阿拉伯語</a>
        | <a href="https://openaitx.github.io/view.html?user=fireinrain&project=asmr-downloader&lang=fa">波斯語</a>
        | <a href="https://openaitx.github.io/view.html?user=fireinrain&project=asmr-downloader&lang=tr">土耳其語</a>
        | <a href="https://openaitx.github.io/view.html?user=fireinrain&project=asmr-downloader&lang=vi">越南語</a>
        | <a href="https://openaitx.github.io/view.html?user=fireinrain&project=asmr-downloader&lang=id">印尼語</a>
        | <a href="https://openaitx.github.io/view.html?user=fireinrain&project=asmr-downloader&lang=as">阿薩姆語</
      </div>
    </div>
  </details>
</div>


## 📖 專案簡介

ASMRoner 是一款 Go 語言命令列工具，用於搜尋、下載、同步 asmr.one 聲音作品，並提供簡易的網頁播放介面。

> 🌐 衍生作品：[asmr.furina.in](https://asmr.furina.in) — 一個簡潔乾淨的線上 ASMR 聽音頁面

## 🚀 快速開始

```bash
git clone https://github.com/fireinrain/asmroner.git && cd asmroner
go build -o asmroner
./asmroner config   # 交互式初始化配置
```

## 📋 常用指令

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

## 📸 截圖

| 設定 | 搜尋 |
|:---:|:---:|
| ![設定](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/config.png) | ![搜尋](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/search.png) |
| **下載** | **同步** |
| ![下載](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/download.png) | ![同步](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/sync.png) |
| **同步下載** | **統計** |
| ![同步下載](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/sync-down.png) | ![統計](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/sync-report.png) |
| **Web 介面** | **Web 介面 2** |
| ![Web介面](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/listen.png) | ![Web介面2](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/listen2.png) |

<details>
<summary><b>✨ 功能特性</b></summary>

- **搜尋**：單個／批次 RJID、高級搜尋語法、結果匯出 CSV/JSON
- **下載**：單個／批次／熱門作品下載，自動限速、重試、指數退避
- **同步**：中繼資料同步、批次下載控制、狀態追蹤、失敗重試
- **Web 介面**：視覺化瀏覽、瀏覽器內播放、響應式設計
- **設定**：互動式初始化，支援代理、限速、抖動等進階設定

</details>

<details>
<summary><b>⚙️ 設定檔說明</b></summary>

設定檔路徑：`~/.asmroner/config.toml`（TOML 格式）

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
<summary><b>📋 命令選項速查</b></summary>

| 命令 | 選項 | 說明 |
|------|------|------|
| `search` | `-c` | 搜尋結果數量（預設 10） |
| `search download` | `-d`, `-s` | 下載目錄、下載數量 |
| `search export` | `-f`, `-n` | 匯出檔名（.csv/.json）、匯出數量 |
| `download` | `-d`, `-n` | 下載目錄、hot100 數量 |
| `sync download` | `-d` | 下載目錄 |
| `sync retry` | `-d` | 失敗檔案所在目錄 |
| `sync export` | `-s`, `-f` | 狀態（failed/success）、匯出檔案 |
| `listen` | `-p` | 連接埠（預設 9999） |

</details>

<details>
<summary><b>📁 專案結構</b></summary>


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
<summary><b>🛠 技術棧</b></summary>

| 組件 | 用途 |
|------|------|
| Cobra + Viper | CLI 框架 + 配置管理 |
| GORM + SQLite | 數據持久化 |
| Resty | HTTP 客戶端（支援 HTTP/SOCKS5 代理） |
| Pond | 並發工作池 |
| x/time/rate | 令牌桶限流 |
| Gin | Web 服務 |
| Tailwind + Plyr | 前端介面 + 音訊播放 |

</details>

<details>
<summary><b>🔧 常見問題</b></summary>

**找不到配置文件** → 執行 `./asmroner config` 初始化

**下載失敗（stream error）** → 程式會自動重試；若仍失敗，請用 `sync retry` 重試，或查看 `.asmroner-data/download_errors.log`

**Web 介面無法訪問** → 確認埠未被占用，嘗試用 `-p` 指定其他埠

**搜尋結果為空** → 檢查查詢語法，嘗試簡化條件

</details>

## 🤝 貢獻

歡迎提交 Pull Request！Fork → 新建分支 → 提交更改 → 發起 PR。

## 📄 許可證

本專案採用 MIT 許可證，詳情請參閱 [LICENSE](/LICENSE) 檔案。

## 🙏 致謝


- 特別感謝 [go-asmr-spider](https://github.com/DiheChen/go-asmr-spider)
- 感謝所有貢獻者和使用者！

---

**ASMRoner** — 每天晚上都有不同的妹妹陪你入睡 :)

*最後更新：2026 年 2 月*


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-17

---