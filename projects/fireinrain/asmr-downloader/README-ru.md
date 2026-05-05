
<div align="right">
  <details>
    <summary >🌐 Язык</summary>
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


## 📖 Описание проекта

ASMRoner — это инструмент командной строки на Go для поиска, скачивания, синхронизации аудиозаписей с asmr.one, а также предоставления простого веб-интерфейса для прослушивания.

> 🌐 Производное приложение: [asmr.furina.in](https://asmr.furina.in) — чистая и минималистичная онлайн-страница для прослушивания ASMR

## 🚀 Быстрый старт

```bash
https://github.com/MIKANOoOo/asmr-downloader.git && cd asmroner
go build -o asmroner
./asmroner config   # 交互式初始化配置
```

## 📋 Часто используемые команды

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

## 📸 Скриншоты

| Конфигурация | Поиск |
|:---:|:---:|
| ![Конфигурация](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/config.png) | ![Поиск](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/search.png) |
| **Загрузка** | **Синхронизация** |
| ![Загрузка](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/download.png) | ![Синхронизация](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/sync.png) |
| **Синхронизация и загрузка** | **Статистика** |
| ![Синхронизация и загрузка](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/sync-down.png) | ![Статистика](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/sync-report.png) |
| **Web интерфейс** | **Web интерфейс 2** |
| ![Web интерфейс](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/listen.png) | ![Web интерфейс 2](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/listen2.png) |
| **export интерфейс** | **export интерфейс 2** |
| ![export интерфейс](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/export1.png) | ![export интерфейс 2](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/export2.png) |

<details>
<summary><b>✨ Характеристики</b></summary>

- **Поиск**: одиночный/массовый RJID, расширенный поисковый синтаксис, экспорт результатов в CSV/JSON
- **Загрузка**: одиночная/массовая/популярные загрузки, автоматическое ограничение скорости, повторные попытки, экспоненциальное отступление
- **Синхронизация**: синхронизация метаданных, массовый контроль загрузки, отслеживание состояния, повторные попытки при ошибках
- **Web интерфейс**: визуальный просмотр, воспроизведение в браузере, адаптивный дизайн
- **Конфигурация**: интерактивная инициализация, поддержка прокси, ограничения скорости, jitter и другие расширенные настройки

</details>

<details>
<summary><b>⚙️ Описание конфигурационного файла</b></summary>

Путь к конфигурационному файлу: `~/.asmroner/config.toml` (формат TOML)

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
<summary><b>📋 Быстрая справка по опциям команд</b></summary>

| Команда | Опция | Описание |
|---------|-------|----------|
| `search` | `-c` | Количество результатов поиска (по умолчанию 10) |
| `search download` | `-d`, `-s` | Каталог загрузки, количество загрузок |
| `search export` | `-f`, `-n` | Имя экспортируемого файла (.csv/.json), количество экспорта |
| `download` | `-d`, `-n` | Каталог загрузки, количество hot100 |
| `sync download` | `-d` | Каталог загрузки |
| `sync retry` | `-d` | Каталог с неудавшимися файлами |
| `sync export` | `-s`, `-f` | Статус (failed/success), экспортируемый файл |
| `listen` | `-p` | Порт (по умолчанию 9999) |
| `export` | `-o`, `-n` | Каталог экспорта, количество hot100 |

</details>

<details>
<summary><b>📁 Структура проекта</b></summary>

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
<summary><b>🛠 Технологический стек</b></summary>

| Компонент | Назначение |
|-----------|-----------|
| Cobra + Viper | CLI-фреймворк + управление конфигурацией |
| GORM + SQLite | Хранение данных |
| Resty | HTTP-клиент (поддержка HTTP/SOCKS5 прокси) |
| Pond | Пул параллельных задач |
| x/time/rate | Ограничение скорости по токен-бакету |
| Gin | Веб-сервис |
| Tailwind + Plyr | Фронтенд-интерфейс + воспроизведение аудио |

</details>

<details>
<summary><b>🔧 Частые вопросы</b></summary>

**Файл конфигурации не найден** → Запустите `./asmroner config` для инициализации

**Сбой загрузки (stream error)** → Программа автоматически повторяет попытку; если ошибка сохраняется, используйте `sync retry` для повторной попытки или проверьте `.asmroner-data/download_errors.log`

**Веб-интерфейс недоступен** → Убедитесь, что порт не занят, попробуйте задать другой порт через `-p`

**Результаты поиска пусты** → Проверьте синтаксис запроса, попробуйте упростить условия

**Сопутствующий способ загрузки для export-команды** → См. [guide](/dist/guide.pdf)

</details>

## 🤝 Вклад

Добро пожаловать к отправке Pull Request! Fork → создание новой ветки → внесение изменений → открытие PR.

## 📄 Лицензия

Этот проект использует лицензию MIT, подробности смотрите в файле [LICENSE](/LICENSE).


## 🙏 致谢

- 特别感谢 [go-asmr-spider](https://github.com/DiheChen/go-asmr-spider)
- 感谢所有贡献者和用户！

---

**ASMRoner** — 每天晚上都有不同的妹妹陪你入睡 :)

*最后更新：2026 年 2 月*


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-05

---