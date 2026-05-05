
<div align="right">
  <details>
    <summary >🌐 زبان</summary>
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


## 📖 معرفی پروژه

ASMRoner یک ابزار خط فرمان نوشته‌شده با زبان Go است که برای جستجو، دانلود، همگام‌سازی آثار صوتی asmr.one و ارائه رابط پخش ساده وب استفاده می‌شود.

> 🌐 پروژه مشتق شده: [asmr.furina.in](https://asmr.furina.in) — یک صفحه شنیدن آنلاین ASMR ساده و تمیز

## 🚀 شروع سریع

```bash
https://github.com/MIKANOoOo/asmr-downloader.git && cd asmroner
go build -o asmroner
./asmroner config   # 交互式初始化配置
```

## 📋 دستورات پرکاربرد

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

## 📸 اسکرین‌شات

| تنظیمات | جستجو |
|:---:|:---:|
| ![تنظیمات](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/config.png) | ![جستجو](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/search.png) |
| **دانلود** | **همگام‌سازی** |
| ![دانلود](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/download.png) | ![همگام‌سازی](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/sync.png) |
| **دانلود همگام** | **آمار** |
| ![دانلود همگام](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/sync-down.png) | ![آمار](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/sync-report.png) |
| **رابط وب** | **رابط وب ۲** |
| ![رابط وب](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/listen.png) | ![رابط وب ۲](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/listen2.png) |
| **رابط export** | **رابط export ۲** |
| ![رابط export](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/export1.png) | ![رابط export ۲](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/export2.png) |

<details>
<summary><b>✨ ویژگی‌های عملکردی</b></summary>

- **جستجو**: RJID تکی/گروهی، دستور جستجوی پیشرفته، خروجی نتایج به CSV/JSON
- **دانلود**: دانلود تکی/گروهی/آثار محبوب، محدودیت خودکار سرعت، تلاش مجدد، عقب‌نشینی نمایی
- **همگام‌سازی**: همگام‌سازی متادیتا، کنترل دانلود گروهی، پیگیری وضعیت، تلاش مجدد در خطا
- **رابط وب**: مرور بصری، پخش در مرورگر، طراحی واکنش‌گرا
- **تنظیمات**: راه‌اندازی تعاملی، پشتیبانی از پراکسی، محدودیت سرعت، اعمال jitter و تنظیمات پیشرفته دیگر

</details>

<details>
<summary><b>⚙️ توضیحات فایل تنظیمات</b></summary>

مسیر فایل تنظیمات: `~/.asmroner/config.toml` (فرمت TOML)

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
<summary><b>📋 مرور سریع گزینه‌های دستوری</b></summary>

| دستور | گزینه | توضیحات |
|-------|-------|---------|
| `search` | `-c` | تعداد نتایج جستجو (پیش‌فرض ۱۰) |
| `search download` | `-d`, `-s` | مسیر دانلود، تعداد دانلود |
| `search export` | `-f`, `-n` | نام فایل خروجی (.csv/.json)، تعداد خروجی |
| `download` | `-d`, `-n` | مسیر دانلود، تعداد hot100 |
| `sync download` | `-d` | مسیر دانلود |
| `sync retry` | `-d` | مسیر فایل‌های ناموفق |
| `sync export` | `-s`, `-f` | وضعیت (failed/success)، فایل خروجی |
| `listen` | `-p` | پورت (پیش‌فرض ۹۹۹۹) |
| `export` | `-o`, `-n` | مسیر خروجی، تعداد hot100 |

</details>

<details>
<summary><b>📁 ساختار پروژه</b></summary>

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
<summary><b>🛠 فناوری مورد استفاده</b></summary>

| مؤلفه | کاربرد |
|------|------|
| Cobra + Viper | چارچوب CLI + مدیریت پیکربندی |
| GORM + SQLite | پایداری داده‌ها |
| Resty | کلاینت HTTP (پشتیبانی از پراکسی HTTP/SOCKS5) |
| Pond | استخر کار همزمان |
| x/time/rate | محدودسازی سرعت به روش سطل توکن |
| Gin | سرویس وب |
| Tailwind + Plyr | رابط کاربری فرانت‌اند + پخش صوتی |

</details>

<details>
<summary><b>🔧 سوالات متداول</b></summary>

**فایل پیکربندی پیدا نشد** → اجرای `./asmroner config` برای مقداردهی اولیه

**دانلود ناموفق (stream error)** → برنامه به طور خودکار تلاش مجدد می‌کند؛ اگر هنوز شکست خورد، با `sync retry` دوباره تلاش کنید یا فایل `.asmroner-data/download_errors.log` را بررسی نمایید

**عدم دسترسی به رابط وب** → مطمئن شوید پورت اشغال نشده و با گزینه `-p` پورت دیگری را امتحان کنید

**نتیجه جستجو خالی است** → نحو جستجو را بررسی کرده و شرایط را ساده‌تر کنید

**روش دانلود متناسب با دستور export** → به [راهنما](/dist/guide.pdf) مراجعه کنید

</details>

## 🤝 مشارکت

ارسال Pull Request خوشامد می‌گوییم! Fork → ایجاد شاخه جدید → ارسال تغییرات → ایجاد PR.

## 📄 مجوز

این پروژه تحت مجوز MIT ارائه شده است. جزئیات بیشتر در فایل [LICENSE](/LICENSE) موجود است.


## 🙏 致谢

- 特别感谢 [go-asmr-spider](https://github.com/DiheChen/go-asmr-spider)
- 感谢所有贡献者和用户！

---

**ASMRoner** — 每天晚上都有不同的妹妹陪你入睡 :)

*最后更新：2026 年 2 月*


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-05

---