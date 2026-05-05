
<div align="right">
  <details>
    <summary >🌐 Lingua</summary>
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


## 📖 Introduzione al progetto

ASMRoner è uno strumento da linea di comando scritto in Go, progettato per cercare, scaricare, sincronizzare le opere audio da asmr.one e fornire una semplice interfaccia Web per la riproduzione.

> 🌐 Progetto derivato: [asmr.furina.in](https://asmr.furina.in) — Una pagina di ascolto ASMR online semplice e pulita

## 🚀 Guida rapida

```bash
https://github.com/MIKANOoOo/asmr-downloader.git && cd asmroner
go build -o asmroner
./asmroner config   # 交互式初始化配置
```

## 📋 Comandi comuni

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

## 📸 Screenshot

| Configurazione | Ricerca |
|:---:|:---:|
| ![Configurazione](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/config.png) | ![Ricerca](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/search.png) |
| **Download** | **Sincronizzazione** |
| ![Download](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/download.png) | ![Sincronizzazione](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/sync.png) |
| **Download sincronizzato** | **Statistiche** |
| ![Download sincronizzato](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/sync-down.png) | ![Statistiche](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/sync-report.png) |
| **Interfaccia Web** | **Interfaccia Web 2** |
| ![Interfaccia Web](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/listen.png) | ![Interfaccia Web 2](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/listen2.png) |
| **Interfaccia export** | **Interfaccia export 2** |
| ![Interfaccia export](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/export1.png) | ![Interfaccia export 2](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/export2.png) |

<details>
<summary><b>✨ Funzionalità</b></summary>

- **Ricerca**: RJID singolo/multiplo, sintassi di ricerca avanzata, esportazione dei risultati in CSV/JSON
- **Download**: Download singolo/multiplo/popolari, limitazione automatica, retry, backoff esponenziale
- **Sincronizzazione**: Sincronizzazione metadata, controllo download multipli, tracciamento stato, retry su fallimento
- **Interfaccia Web**: Navigazione visuale, riproduzione nel browser, design responsivo
- **Configurazione**: Inizializzazione interattiva, supporto proxy, limitazione, jitter e altre configurazioni avanzate

</details>

<details>
<summary><b>⚙️ Descrizione del file di configurazione</b></summary>

Percorso del file di configurazione: `~/.asmroner/config.toml` (formato TOML)

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
<summary><b>📋 Riepilogo opzioni comando</b></summary>

| Comando | Opzione | Descrizione |
|---------|---------|-------------|
| `search` | `-c` | Numero dei risultati della ricerca (predefinito 10) |
| `search download` | `-d`, `-s` | Directory di download, numero di download |
| `search export` | `-f`, `-n` | Nome file di esportazione (.csv/.json), numero di esportazione |
| `download` | `-d`, `-n` | Directory di download, quantità hot100 |
| `sync download` | `-d` | Directory di download |
| `sync retry` | `-d` | Directory dei file falliti |
| `sync export` | `-s`, `-f` | Stato (failed/success), file di esportazione |
| `listen` | `-p` | Porta (predefinito 9999) |
| `export` | `-o`, `-n` | Directory di esportazione, quantità hot100 |

</details>

<details>
<summary><b>📁 Struttura del progetto</b></summary>


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
<summary><b>🛠 Stack Tecnico</b></summary>

| Componente | Utilizzo |
|------|------|
| Cobra + Viper | Framework CLI + Gestione configurazioni |
| GORM + SQLite | Persistenza dei dati |
| Resty | Client HTTP (supporta proxy HTTP/SOCKS5) |
| Pond | Pool di lavoro concorrente |
| x/time/rate | Rate limiting a secchiello di token |
| Gin | Servizio Web |
| Tailwind + Plyr | Interfaccia frontend + Riproduzione audio |

</details>

<details>
<summary><b>🔧 Domande Frequenti</b></summary>

**File di configurazione non trovato** → Eseguire `./asmroner config` per inizializzare

**Download fallito (stream error)** → Il programma riprova automaticamente; se continua a fallire, riprovare con `sync retry` o consultare `.asmroner-data/download_errors.log`

**Interfaccia web non accessibile** → Verificare che la porta non sia occupata, provare a specificare un'altra porta con `-p`

**Nessun risultato di ricerca** → Controllare la sintassi della query, provare a semplificare le condizioni

**Metodo di download per il comando export** → Fare riferimento alla [guida](/dist/guide.pdf)

</details>

## 🤝 Contribuire

Sono benvenuti i Pull Request! Fork → Nuovo branch → Invia modifiche → Apri PR.

## 📄 Licenza

Questo progetto è distribuito con licenza MIT, per maggiori dettagli consultare il file [LICENSE](/LICENSE).


## 🙏 致谢

- 特别感谢 [go-asmr-spider](https://github.com/DiheChen/go-asmr-spider)
- 感谢所有贡献者和用户！

---

**ASMRoner** — 每天晚上都有不同的妹妹陪你入睡 :)

*最后更新：2026 年 2 月*


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-05

---