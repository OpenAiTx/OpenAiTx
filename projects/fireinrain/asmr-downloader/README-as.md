
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
git clone https://github.com/fireinrain/asmroner.git && cd asmroner
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

# Web 播放界面
./asmroner listen -p 8080 ./syncdata
```

## 📸 স্ক্ৰীনশ্বট

| সংৰূপণ | সন্ধান |
|:---:|:---:|
| ![সংৰূপণ](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/config.png) | ![সন্ধান](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/search.png) |
| **ডাউনলোড** | **ছিংক্ৰনাইজ** |
| ![ডাউনলোড](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/download.png) | ![ছিংক্ৰনাইজ](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/sync.png) |
| **ছিংক্ৰন ডাউনলোড** | **পৰিসংখ্যা** |
| ![ছিংক্ৰন ডাউনলোড](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/sync-down.png) | ![পৰিসংখ্যা](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/sync-report.png) |
| **Web ইণ্টাৰফেচ** | **Web ইণ্টাৰফেচ 2** |
| ![Web ইণ্টাৰফেচ](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/listen.png) | ![Web ইণ্টাৰফেচ 2](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/listen2.png) |

<details>
<summary><b>✨ ফিচাৰ বিশেষত্ব</b></summary>

- **সন্ধান**: একক/বহু RJID, উন্নত সন্ধান সিন্টেক্স, ফলাফল ৰপ্তানি CSV/JSON
- **ডাউনলোড**: একক/বহু/জনপ্ৰিয় সৃষ্টি ডাউনলোড, স্বয়ংক্ৰিয় লিমিট, পুনৰ চেষ্টা, এক্সপ’নেনশিয়েল বেকঅফ
- **ছিংক্ৰনাইজ**: মেটাডাটা ছিংক, বহুল ডাউনলোড নিয়ন্ত্ৰণ, অৱস্থা ট্ৰেকিং, বিফল পুনৰ চেষ্টা
- **Web ইণ্টাৰফেচ**: ভিজ্যুয়েলাইজড ব্রাউজিং, ব্ৰাউজাৰত প্লেব্যাক, ৰেস্প’নছিভ ডিজাইন
- **সংৰূপণ**: ইণ্টাৰেক্টিভ ইনিশিয়ালাইজ, প্ৰক্সি, লিমিট, জিটাৰ আদি উন্নত সংৰূপণ সমৰ্থন

</details>

<details>
<summary><b>⚙️ সংৰূপণ ফাইল বিৱৰণ</b></summary>

সংৰূপণ ফাইল পথ: `~/.asmroner/config.toml` (TOML ফৰ্মেট)

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
<summary><b>📋 আদেশ বিকল্প চিটচিট</b></summary>

| আদেশ | বিকল্প | বিৱৰণ |
|------|------|------|
| `search` | `-c` | অনুসন্ধান ফলাফল সংখ্যা (ডিফল্ট ১০) |
| `search download` | `-d`, `-s` | ডাউনলোড ডাইৰেক্টৰি, ডাউনলোড সংখ্যা |
| `search export` | `-f`, `-n` | এক্সপোৰ্ট ফাইল নাম (.csv/.json), এক্সপোৰ্ট সংখ্যা |
| `download` | `-d`, `-n` | ডাউনলোড ডাইৰেক্টৰি, hot100 সংখ্যা |
| `sync download` | `-d` | ডাউনলোড ডাইৰেক্টৰি |
| `sync retry` | `-d` | বিফল হোৱা ফাইল থকা ডাইৰেক্টৰি |
| `sync export` | `-s`, `-f` | অৱস্থা (failed/success), এক্সপোৰ্ট ফাইল |
| `listen` | `-p` | পোর্ট (ডিফল্ট ৯৯৯৯) |

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
<summary><b>🛠 প্ৰযুক্তি ষ্টেক</b></summary>

| উপাদান | ব্যৱহাৰ |
|------|------|
| Cobra + Viper | CLI ফ্ৰেমৱাৰ্ক + সংৰক্ষণ ব্যৱস্থাপনা |
| GORM + SQLite | ডাটা স্থায়ীকৰণ |
| Resty | HTTP ক্লায়েন্ট (HTTP/SOCKS5 প্ৰক্সি সমৰ্থিত) |
| Pond | সমান্তৰাল কৰ্মপুল |
| x/time/rate | টোকেন বাকচ সীমাবদ্ধকৰণ |
| Gin | ৱেব সেৱা |
| Tailwind + Plyr | ফ্ৰণ্টএণ্ড ইণ্টাৰফেছ + অডিঅ' প্লেবেক |

</details>

<details>
<summary><b>🔧 সাধাৰণ সমস্যাসমূহ</b></summary>

**সংৰক্ষণ ফাইল পোৱা নগল** → `./asmroner config` চলাই আৰম্ভ কৰক

**ডাউনলোড বিফল (stream error)** → প্ৰগ্ৰামে স্বয়ংক্ৰিয়ভাৱে পুনৰ চেষ্টা কৰে; এতিয়াও বিফল হ'লে, `sync retry` ব্যৱহাৰ কৰি পুনৰ চেষ্টা কৰক, বা `.asmroner-data/download_errors.log` চাওক

**ৱেব ইণ্টাৰফেছ উপলব্ধ নহয়** → নিশ্চিত কৰক যে পোৰ্ট ব্যৱহৃত হোৱা নাই, `-p` ব্যৱহাৰ কৰি অন্য পোৰ্ট নিৰ্দেশনা কৰক

**সন্ধান ফলাফল খালী** → অনুসন্ধান সিন্টাক্স পৰীক্ষা কৰক, চৰ্ত সহজ কৰক

</details>

## 🤝 অৱদান

Pull Request জমা দিবলৈ স্বাগতম! Fork কৰক → নতুন শাখা খুলক → পৰিবর্তন জমা কৰক → PR আৰম্ভ কৰক।

## 📄 অনুজ্ঞাপত্ৰ

এই প্ৰকল্পত MIT অনুজ্ঞাপত্ৰ ব্যৱহৃত হৈছে, বিস্তারিত জানিবলৈ [LICENSE](/LICENSE) ফাইল চাওক।

## 🙏 কৃতজ্ঞতা


- বিশেষ ধন্যবাদ [go-asmr-spider](https://github.com/DiheChen/go-asmr-spider)
- সকলো অৱদানকাৰী আৰু ব্যৱহাৰকাৰীক ধন্যবাদ!

---

**ASMRoner** — প্ৰতিদিন ৰাতি বিভিন্ন ভনী আপোনাৰ সৈতে শুই যাবলৈ আহে :)

*শেষবাৰৰ বাবে আপডেট: ২০২৬ চনৰ ফেব্ৰুৱাৰী*


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-17

---