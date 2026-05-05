
<div align="right">
  <details>
    <summary >🌐 ভাষা</summary>
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


## 📖 প্ৰকল্পৰ পৰিচয়

ASMRoner এটা Go ভাষাৰ আদেশ শাৰী সঁজুলি, যি asmr.one ৰ অডিঅ' সৃষ্টি সন্ধান, ডাউনলোড, ছিঙ্ক্ৰনাইজ কৰাৰ লগতে সহজ Web প্লেয়াৰ ইণ্টাৰফেচ প্ৰদান কৰে।

> 🌐 উদ্ভৱ গীত: [asmr.furina.in](https://asmr.furina.in) — এটা পরিষ্কাৰ আৰু সহজ অনলাইন ASMR শুনাৰ পৃষ্ঠা

## 🚀 তৎকাল আৰম্ভ কৰক

```bash
https://github.com/MIKANOoOo/asmr-downloader.git && cd asmroner
go build -o asmroner
./asmroner config   # 交互式初始化配置
```

## 📋 প্ৰচলিত নিৰ্দেশসমূহ

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

## 📸 স্ক্ৰীনশ্বট

| সংৰূপণ | সন্ধান |
|:---:|:---:|
| ![সংৰূপণ](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/config.png) | ![সন্ধান](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/search.png) |
| **ডাউনলোড** | **ছিংক্ৰনাইজ** |
| ![ডাউনলোড](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/download.png) | ![ছিংক্ৰনাইজ](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/sync.png) |
| **ছিংক্ৰনাইজড ডাউনলোড** | **পৰিসংখ্যা** |
| ![ছিংক্ৰনাইজড ডাউনলোড](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/sync-down.png) | ![পৰিসংখ্যা](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/sync-report.png) |
| **Web ইণ্টাৰফেচ** | **Web ইণ্টাৰফেচ 2** |
| ![Web ইণ্টাৰফেচ](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/listen.png) | ![Web ইণ্টাৰফেচ 2](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/listen2.png) |
| **export ইণ্টাৰফেচ** | **export ইণ্টাৰফেচ 2** |
| ![export ইণ্টাৰফেচ](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/export1.png) | ![export ইণ্টাৰফেচ 2](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/export2.png) |

<details>
<summary><b>✨ ফিচাৰ বৈশিষ্ট্য</b></summary>

- **সন্ধান**: একক/বাল্ক RJID, উন্নত সন্ধান সিন্টেক্স, ফলাফল CSV/JSON ৰূপে এক্সপোর্ট
- **ডাউনলোড**: একক/বাল্ক/জনপ্ৰিয় ফাইল ডাউনলোড, স্বয়ংক্ৰিয় লিমিট, পুনৰ চেষ্টা, এক্সপ’নেনশিয়েল বেকঅফ
- **ছিংক্ৰনাইজ**: মেটাডাটা ছিংক্ৰনাইজ, বাল্ক ডাউনলোড নিয়ন্ত্ৰণ, অৱস্থা অনুগমন, বিফলতাত পুনৰ চেষ্টা
- **Web ইণ্টাৰফেচ**: ভিজুৱেলাইজড ব্ৰাউজিং, ব্ৰাউজাৰভিত্তিক প্লেব্যাক, ৰেসপন্সিভ ডিজাইন
- **সংৰূপণ**: ইন্টাৰেক্টিভ ইনিশিয়ালাইজ, প্ৰক্সি, ৰেট-লিমিট, জিটাৰ আদি উন্নত সংৰূপণ সমৰ্থিত

</details>

<details>
<summary><b>⚙️ সংৰূপণ ফাইল বিৱৰণ</b></summary>

সংৰূপণ ফাইলৰ পথ: `~/.asmroner/config.toml` (TOML ফৰ্মেট)

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
<summary><b>📋 আদেশ বিকল্প চিটচিটা</b></summary>

| আদেশ | বিকল্প | বিৱৰণ |
|------|------|------|
| `search` | `-c` | সন্ধান ফলাফলৰ সংখ্যা (ডিফল্ট 10) |
| `search download` | `-d`, `-s` | ডাউনলোড ডাইৰেক্টৰি, ডাউনলোড সংখ্যা |
| `search export` | `-f`, `-n` | এক্সপোৰ্ট ফাইলনাম (.csv/.json), এক্সপোৰ্ট সংখ্যা |
| `download` | `-d`, `-n` | ডাউনলোড ডাইৰেক্টৰি, hot100 সংখ্যা |
| `sync download` | `-d` | ডাউনলোড ডাইৰেক্টৰি |
| `sync retry` | `-d` | বিফল ফাইল থকা ডাইৰেক্টৰি |
| `sync export` | `-s`, `-f` | অৱস্থা (failed/success), এক্সপোৰ্ট ফাইল |
| `listen` | `-p` | পোৰ্ট (ডিফল্ট 9999) |
| `export` | `-o`, `-n` | এক্সপোৰ্ট ডাইৰেক্টৰি, hot100 সংখ্যা |

</details>

<details>
<summary><b>📁 প্ৰকল্পৰ গঠন</b></summary>

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
<summary><b>🛠 প্ৰযুক্তি স্টেক</b></summary>

| উপাদান | ব্যৱহাৰ |
|------|------|
| Cobra + Viper | CLI ফ্ৰেমৱৰ্ক + সংৰক্ষণ ব্যৱস্থাপনা |
| GORM + SQLite | ডাটা স্থায়ীকৰণ |
| Resty | HTTP ক্লায়েন্ট (HTTP/SOCKS5 প্ৰক্সি সমৰ্থিত) |
| Pond | একসাথে কাম কৰাৰ পুল |
| x/time/rate | টোকেন বাকচ সীমিতকৰণ |
| Gin | ৱেব সেৱা |
| Tailwind + Plyr | ফ্ৰণ্টএণ্ড ইণ্টাৰফেচ + অডিঅ' প্লে'ব্যাক |

</details>

<details>
<summary><b>🔧 সাধাৰণ সমস্যা</b></summary>

**সংৰক্ষণ ফাইল পোৱা নগ’ল** → `./asmroner config` চলাই আৰম্ভ কৰক

**ডাউনলোড বিফল (stream error)** → প্ৰগ্ৰামে স্বয়ংক্ৰিয়ভাৱে পুনৰ চেষ্টা কৰিব; যদি এতিয়াও বিফল, `sync retry` ব্যৱহাৰ কৰি পুনৰ চেষ্টা কৰক, অথবা চাওক `.asmroner-data/download_errors.log`

**ৱেব ইণ্টাৰফেচ এক্সেছ কৰিব নোৱাৰি** → নিশ্চিত কৰক প'ৰ্ট দখল হোৱা নাই, `-p` ব্যৱহাৰ কৰি অন্য প'ৰ্ট নিৰ্ধাৰণ কৰক

**সন্ধান ফলাফল খালী** → অনুসন্ধান বাক্য পৰীক্ষা কৰক, চৰ্ত সহজ কৰক

**export নিৰ্দেশৰ লগত ডাউনলোড পদ্ধতি** → [guide](/dist/guide.pdf) চাওক

</details>

## 🤝 অৱদান

Pull Request জমা দিয়াৰ বাবে স্বাগতম! Fork কৰক → নতুন শাখা বনাওক → পৰিবর্তন জমা কৰক → PR আৰম্ভ কৰক।

## 📄 অনুমতি পত্ৰ

এই প্ৰকল্পটো MIT অনুমতি পত্ৰ গ্ৰহণ কৰিছে, বিৱৰণৰ বাবে [LICENSE](/LICENSE) ফাইল চাওক।


## 🙏 致谢

- 特别感谢 [go-asmr-spider](https://github.com/DiheChen/go-asmr-spider)
- 感谢所有贡献者和用户！

---

**ASMRoner** — 每天晚上都有不同的妹妹陪你入睡 :)

*最后更新：2026 年 2 月*


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-05

---