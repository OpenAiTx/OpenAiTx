
<div align="right">
  <details>
    <summary >🌐 Taal</summary>
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


## 📖 Projectoverzicht

ASMRoner is een Go-commandoregeltool voor het zoeken, downloaden, synchroniseren van asmr.one audiowerken en biedt een eenvoudige webafspeelinterface.

> 🌐 Afgeleide project: [asmr.furina.in](https://asmr.furina.in) — een eenvoudige en schone online ASMR luisterpagina

## 🚀 Snel aan de slag

```bash
https://github.com/MIKANOoOo/asmr-downloader.git && cd asmroner
go build -o asmroner
./asmroner config   # 交互式初始化配置
```

## 📋 Veelgebruikte commando's

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

## 📸 Screenshots

| Configuratie | Zoeken |
|:---:|:---:|
| ![Configuratie](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/config.png) | ![Zoeken](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/search.png) |
| **Downloaden** | **Synchroniseren** |
| ![Downloaden](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/download.png) | ![Synchroniseren](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/sync.png) |
| **Synchronisatie-download** | **Statistieken** |
| ![Synchronisatie-download](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/sync-down.png) | ![Statistieken](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/sync-report.png) |
| **Web-interface** | **Web-interface 2** |
| ![Web-interface](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/listen.png) | ![Web-interface 2](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/listen2.png) |
| **Export-interface** | **Export-interface 2** |
| ![Export-interface](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/export1.png) | ![Export-interface 2](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/export2.png) |

<details>
<summary><b>✨ Functies & Kenmerken</b></summary>

- **Zoeken**: Enkelvoudig/bulk RJID, geavanceerde zoekopdrachten, resultaten exporteren naar CSV/JSON
- **Downloaden**: Enkelvoudig/bulk/download van populaire werken, automatische snelheidsbeperking, herhalingen, exponentiële back-off
- **Synchroniseren**: Metagegevens-synchronisatie, bulk downloadbeheer, status tracking, herhaalde pogingen bij fouten
- **Web-interface**: Visueel bladeren, afspelen in browser, responsief ontwerp
- **Configuratie**: Interactieve setup, ondersteuning voor proxy, snelheidsbeperking, jitter en andere geavanceerde opties

</details>

<details>
<summary><b>⚙️ Configuratiebestand uitleg</b></summary>

Pad naar configuratiebestand: `~/.asmroner/config.toml` (TOML-formaat)

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
<summary><b>📋 Overzicht van commandoregelopties</b></summary>

| Commando | Optie | Beschrijving |
|----------|-------|--------------|
| `search` | `-c` | Aantal zoekresultaten (standaard 10) |
| `search download` | `-d`, `-s` | Downloadmap, aantal downloads |
| `search export` | `-f`, `-n` | Bestandsnaam voor export (.csv/.json), aantal exporten |
| `download` | `-d`, `-n` | Downloadmap, hot100 aantal |
| `sync download` | `-d` | Downloadmap |
| `sync retry` | `-d` | Map met mislukte bestanden |
| `sync export` | `-s`, `-f` | Status (failed/success), exportbestand |
| `listen` | `-p` | Poort (standaard 9999) |
| `export` | `-o`, `-n` | Exportmap, hot100 aantal |

</details>

<details>
<summary><b>📁 Projectstructuur</b></summary>


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
<summary><b>🛠 Technische Stack</b></summary>

| Component | Doel |
|-----------|------|
| Cobra + Viper | CLI-framework + configuratiebeheer |
| GORM + SQLite | Gegevenspersistentie |
| Resty | HTTP-client (ondersteunt HTTP/SOCKS5 proxy) |
| Pond | Concurrentie werkpool |
| x/time/rate | Token bucket rate limiting |
| Gin | Webdienst |
| Tailwind + Plyr | Frontend-interface + audioweergave |

</details>

<details>
<summary><b>🔧 Veelgestelde Vragen</b></summary>

**Configuratiebestand niet gevonden** → Voer `./asmroner config` uit om te initialiseren

**Download mislukt (stream error)** → Het programma probeert automatisch opnieuw; als het nog mislukt, gebruik `sync retry` of bekijk `.asmroner-data/download_errors.log`

**Webinterface niet bereikbaar** → Controleer of de poort vrij is, probeer eventueel een andere poort met `-p`

**Geen zoekresultaten** → Controleer de query-syntax, probeer de voorwaarden te vereenvoudigen

**Downloadmethode voor het export-commando** → Zie [gids](/dist/guide.pdf) 

</details>

## 🤝 Bijdragen

Pull Requests zijn welkom! Fork → nieuwe branch → wijzigingen committen → PR openen.

## 📄 Licentie

Dit project gebruikt de MIT-licentie, zie het [LICENSE](/LICENSE) bestand voor details.


## 🙏 致谢

- 特别感谢 [go-asmr-spider](https://github.com/DiheChen/go-asmr-spider)
- 感谢所有贡献者和用户！

---

**ASMRoner** — 每天晚上都有不同的妹妹陪你入睡 :)

*最后更新：2026 年 2 月*


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-05

---