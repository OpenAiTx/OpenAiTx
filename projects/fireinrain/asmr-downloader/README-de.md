
<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
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


## 📖 Projektübersicht

ASMRoner ist ein Kommandozeilen-Tool in Go, mit dem Sie asmr.one-Audios suchen, herunterladen, synchronisieren und eine einfache Web-Wiedergabeoberfläche bereitstellen können.

> 🌐 Abgeleitetes Projekt: [asmr.furina.in](https://asmr.furina.in) — Eine schlichte und saubere Online-ASMR-Hörseite

## 🚀 Schnellstart

```bash
git clone https://github.com/fireinrain/asmroner.git && cd asmroner
go build -o asmroner
./asmroner config   # 交互式初始化配置
```

## 📋 Häufig verwendete Befehle

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

| Konfiguration | Suche |
|:---:|:---:|
| ![Konfiguration](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/config.png) | ![Suche](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/search.png) |
| **Download** | **Synchronisieren** |
| ![Download](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/download.png) | ![Synchronisieren](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/sync.png) |
| **Synchronisierter Download** | **Statistik** |
| ![Synchronisierter Download](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/sync-down.png) | ![Statistik](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/sync-report.png) |
| **Web-Oberfläche** | **Web-Oberfläche 2** |
| ![Web-Oberfläche](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/listen.png) | ![Web-Oberfläche 2](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/listen2.png) |

<details>
<summary><b>✨ Funktionsmerkmale</b></summary>

- **Suche**: Einzel-/Batch-RJID, erweiterte Suchsyntax, Export von Ergebnissen als CSV/JSON
- **Download**: Einzel-/Batch-/Top-Downloads, automatische Drosselung, Wiederholungen, exponentielles Backoff
- **Synchronisieren**: Metadaten-Sync, Batch-Download-Kontrolle, Status-Tracking, Fehlerwiederholung
- **Web-Oberfläche**: Visuelle Ansicht, Wiedergabe im Browser, responsives Design
- **Konfiguration**: Interaktive Initialisierung, Unterstützung für Proxy, Drosselung, Jitter und weitere erweiterte Optionen

</details>

<details>
<summary><b>⚙️ Konfigurationsdatei-Erklärung</b></summary>

Pfad der Konfigurationsdatei: `~/.asmroner/config.toml` (TOML-Format)

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
<summary><b>📋 Befehlsoptionen Schnellreferenz</b></summary>

| Befehl | Option | Beschreibung |
|--------|--------|--------------|
| `search` | `-c` | Anzahl der Suchergebnisse (Standard 10) |
| `search download` | `-d`, `-s` | Download-Verzeichnis, Anzahl der Downloads |
| `search export` | `-f`, `-n` | Exportdateiname (.csv/.json), Anzahl der Exporte |
| `download` | `-d`, `-n` | Download-Verzeichnis, hot100 Anzahl |
| `sync download` | `-d` | Download-Verzeichnis |
| `sync retry` | `-d` | Verzeichnis der fehlgeschlagenen Dateien |
| `sync export` | `-s`, `-f` | Status (failed/success), Exportdatei |
| `listen` | `-p` | Port (Standard 9999) |

</details>

<details>
<summary><b>📁 Projektstruktur</b></summary>

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
<summary><b>🛠 Technologiestack</b></summary>

| Komponente | Zweck |
|------|------|
| Cobra + Viper | CLI-Framework + Konfigurationsmanagement |
| GORM + SQLite | Datenpersistenz |
| Resty | HTTP-Client (unterstützt HTTP/SOCKS5 Proxy) |
| Pond | Parallel-Arbeits-Pool |
| x/time/rate | Token-Bucket-Rate-Limiting |
| Gin | Webdienst |
| Tailwind + Plyr | Frontend-Interface + Audiowiedergabe |

</details>

<details>
<summary><b>🔧 Häufige Fragen</b></summary>

**Konfigurationsdatei nicht gefunden** → Führen Sie `./asmroner config` zur Initialisierung aus

**Download fehlgeschlagen (stream error)** → Das Programm versucht es automatisch erneut; falls weiterhin Fehler, nutzen Sie `sync retry` oder prüfen Sie `.asmroner-data/download_errors.log`

**Web-Oberfläche nicht erreichbar** → Prüfen Sie, ob der Port frei ist, versuchen Sie `-p`, um einen anderen Port anzugeben

**Keine Suchergebnisse** → Überprüfen Sie die Suchsyntax, versuchen Sie die Bedingungen zu vereinfachen

</details>

## 🤝 Beitrag

Pull Requests sind willkommen! Fork → Neuen Branch erstellen → Änderungen committen → PR eröffnen.

## 📄 Lizenz

Dieses Projekt verwendet die MIT-Lizenz, Details finden Sie in der Datei [LICENSE](/LICENSE).

## 🙏 Danksagung

- Besonderer Dank an [go-asmr-spider](https://github.com/DiheChen/go-asmr-spider)
- Danke an alle Mitwirkenden und Nutzer!

---

**ASMRoner** — Jeden Abend begleitet dich eine andere Schwester in den Schlaf :)

*Letzte Aktualisierung: Februar 2026*


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-17

---