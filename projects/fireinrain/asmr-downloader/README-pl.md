
<div align="right">
  <details>
    <summary >🌐 Język</summary>
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


## 📖 Opis projektu

ASMRoner to narzędzie wiersza poleceń napisane w Go, służące do wyszukiwania, pobierania i synchronizacji nagrań audio z asmr.one oraz udostępniające prosty interfejs Web do odtwarzania.

> 🌐 Projekt pochodny: [asmr.furina.in](https://asmr.furina.in) — prosta i czysta strona do słuchania ASMR online

## 🚀 Szybki start

```bash
git clone https://github.com/fireinrain/asmroner.git && cd asmroner
go build -o asmroner
./asmroner config   # 交互式初始化配置
```

## 📋 Najczęściej używane polecenia

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

## 📸 Zrzuty ekranu

| Konfiguracja | Wyszukiwanie |
|:---:|:---:|
| ![Konfiguracja](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/config.png) | ![Wyszukiwanie](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/search.png) |
| **Pobieranie** | **Synchronizacja** |
| ![Pobieranie](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/download.png) | ![Synchronizacja](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/sync.png) |
| **Pobieranie z synchronizacją** | **Statystyki** |
| ![Pobieranie z synchronizacją](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/sync-down.png) | ![Statystyki](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/sync-report.png) |
| **Interfejs Web** | **Interfejs Web 2** |
| ![Interfejs Web](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/listen.png) | ![Interfejs Web 2](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/listen2.png) |

<details>
<summary><b>✨ Cechy funkcjonalne</b></summary>

- **Wyszukiwanie**: pojedynczy/zbiorczy RJID, zaawansowana składnia wyszukiwania, eksport wyników do CSV/JSON
- **Pobieranie**: pobieranie pojedynczych/zbiorczych/popularnych pozycji, automatyczne ograniczanie przepustowości, ponawianie, wykładnicze opóźnianie
- **Synchronizacja**: synchronizacja metadanych, kontrola pobierania zbiorczego, śledzenie statusu, ponawianie nieudanych prób
- **Interfejs Web**: wizualna przeglądarka, odtwarzanie w przeglądarce, responsywny design
- **Konfiguracja**: interaktywna inicjalizacja, wsparcie dla proxy, ograniczania przepustowości, jitter i innych zaawansowanych ustawień

</details>

<details>
<summary><b>⚙️ Opis pliku konfiguracyjnego</b></summary>

Ścieżka pliku konfiguracyjnego: `~/.asmroner/config.toml` (format TOML)

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
<summary><b>📋 Szybka ściągawka opcji poleceń</b></summary>

| Polecenie | Opcje | Opis |
|------|------|------|
| `search` | `-c` | Liczba wyników wyszukiwania (domyślnie 10) |
| `search download` | `-d`, `-s` | Katalog pobierania, liczba pobrań |
| `search export` | `-f`, `-n` | Nazwa pliku eksportu (.csv/.json), liczba eksportów |
| `download` | `-d`, `-n` | Katalog pobierania, liczba hot100 |
| `sync download` | `-d` | Katalog pobierania |
| `sync retry` | `-d` | Katalog z nieudanymi plikami |
| `sync export` | `-s`, `-f` | Status (failed/success), plik eksportu |
| `listen` | `-p` | Port (domyślnie 9999) |

</details>

<details>
<summary><b>📁 Struktura projektu</b></summary>


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
<summary><b>🛠 Stos technologiczny</b></summary>

| Komponent | Zastosowanie |
|------|------|
| Cobra + Viper | Framework CLI + zarządzanie konfiguracją |
| GORM + SQLite | Trwałość danych |
| Resty | Klient HTTP (wsparcie dla proxy HTTP/SOCKS5) |
| Pond | Współbieżna pula zadań |
| x/time/rate | Ograniczanie przepustowości token bucket |
| Gin | Serwer WWW |
| Tailwind + Plyr | Interfejs frontendowy + odtwarzanie audio |

</details>

<details>
<summary><b>🔧 Najczęstsze pytania</b></summary>

**Nie znaleziono pliku konfiguracyjnego** → Uruchom `./asmroner config`, aby zainicjować

**Błąd pobierania (stream error)** → Program automatycznie ponowi próbę; jeśli nadal się nie uda, użyj `sync retry` lub sprawdź `.asmroner-data/download_errors.log`

**Brak dostępu do interfejsu WWW** → Upewnij się, że port nie jest zajęty, spróbuj określić inny port za pomocą `-p`

**Brak wyników wyszukiwania** → Sprawdź składnię zapytania, spróbuj uprościć warunki

</details>

## 🤝 Wkład

Zachęcamy do przesyłania Pull Requestów! Fork → utwórz nową gałąź → wprowadź zmiany → otwórz PR.

## 📄 Licencja

Projekt udostępniany na licencji MIT, szczegóły w pliku [LICENSE](/LICENSE).

## 🙏 Podziękowania


- Specjalne podziękowania dla [go-asmr-spider](https://github.com/DiheChen/go-asmr-spider)
- Dziękujemy wszystkim współtwórcom i użytkownikom!

---

**ASMRoner** — Każdego wieczoru inna dziewczyna towarzyszy Ci przy zasypianiu :)

*Ostatnia aktualizacja: luty 2026*


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-17

---