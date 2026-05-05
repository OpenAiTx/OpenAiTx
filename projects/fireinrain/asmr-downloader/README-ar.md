
<div align="right">
  <details>
    <summary >🌐 اللغة</summary>
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


## 📖 مقدمة المشروع

ASMRoner هو أداة سطر أوامر مكتوبة بلغة Go، تُستخدم للبحث عن أعمال asmr.one الصوتية وتنزيلها ومزامنتها، كما توفر واجهة ويب بسيطة لتشغيل الملفات.

> 🌐 منتج مشتق: [asmr.furina.in](https://asmr.furina.in) — صفحة استماع ASMR عبر الإنترنت بسيطة ونظيفة

## 🚀 البدء السريع

```bash
https://github.com/MIKANOoOo/asmr-downloader.git && cd asmroner
go build -o asmroner
./asmroner config   # 交互式初始化配置
```

## 📋 الأوامر الشائعة

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

## 📸 لقطات الشاشة

| الإعدادات | البحث |
|:---:|:---:|
| ![الإعدادات](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/config.png) | ![البحث](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/search.png) |
| **تنزيل** | **مزامنة** |
| ![التنزيل](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/download.png) | ![المزامنة](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/sync.png) |
| **تنزيل متزامن** | **إحصائيات** |
| ![التنزيل المتزامن](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/sync-down.png) | ![الإحصائيات](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/sync-report.png) |
| **واجهة الويب** | **واجهة الويب 2** |
| ![واجهة الويب](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/listen.png) | ![واجهة الويب 2](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/listen2.png) |
| **واجهة export** | **واجهة export 2** |
| ![واجهة export](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/export1.png) | ![واجهة export 2](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/export2.png) |

<details>
<summary><b>✨ الميزات</b></summary>

- **البحث**: بحث فردي/مجمع برقم RJID، صيغ بحث متقدمة، تصدير النتائج إلى CSV/JSON
- **التنزيل**: تنزيل فردي/مجمع/الأعمال الشائعة، تحديد تلقائي للسرعة، إعادة المحاولة، تراجع أسي
- **المزامنة**: مزامنة البيانات الوصفية، التحكم في التنزيل المجمع، تتبع الحالة، إعادة محاولة الفشل
- **واجهة الويب**: تصفح مرئي، تشغيل داخل المتصفح، تصميم متجاوب
- **الإعدادات**: تهيئة تفاعلية، دعم البروكسي، تحديد السرعة، التذبذب والإعدادات المتقدمة

</details>

<details>
<summary><b>⚙️ شرح ملف الإعدادات</b></summary>

مسار ملف الإعدادات: `~/.asmroner/config.toml` (صيغة TOML)

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
<summary><b>📋 مرجع سريع لخيارات الأوامر</b></summary>

| الأمر | الخيار | الشرح |
|-------|-------|-------|
| `search` | `-c` | عدد نتائج البحث (الافتراضي 10) |
| `search download` | `-d`, `-s` | مجلد التنزيل، عدد التنزيلات |
| `search export` | `-f`, `-n` | اسم ملف التصدير (.csv/.json)، عدد التصدير |
| `download` | `-d`, `-n` | مجلد التنزيل، عدد hot100 |
| `sync download` | `-d` | مجلد التنزيل |
| `sync retry` | `-d` | مجلد الملفات الفاشلة |
| `sync export` | `-s`, `-f` | الحالة (failed/success)، ملف التصدير |
| `listen` | `-p` | المنفذ (الافتراضي 9999) |
| `export` | `-o`, `-n` | مجلد التصدير، عدد hot100 |

</details>

<details>
<summary><b>📁 هيكل المشروع</b></summary>


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
<summary><b>🛠 التقنية المستخدمة</b></summary>

| المكون | الغرض |
|------|------|
| Cobra + Viper | إطار CLI + إدارة الإعدادات |
| GORM + SQLite | تخزين البيانات الدائم |
| Resty | عميل HTTP (يدعم بروكسي HTTP/SOCKS5) |
| Pond | تجمع عمل متوازي |
| x/time/rate | تحديد السرعة بطريقة دلو الرموز |
| Gin | خدمة الويب |
| Tailwind + Plyr | واجهة أمامية + تشغيل الصوتيات |

</details>

<details>
<summary><b>🔧 الأسئلة الشائعة</b></summary>

**ملف الإعدادات غير موجود** → شغل الأمر `./asmroner config` للتهيئة

**فشل التحميل (stream error)** → البرنامج سيعيد المحاولة تلقائياً؛ إذا استمر الفشل، استخدم `sync retry` لإعادة المحاولة، أو راجع `.asmroner-data/download_errors.log`

**تعذر الوصول إلى واجهة الويب** → تأكد أن المنفذ غير مستخدم، وحاول استخدام الخيار `-p` لتحديد منفذ آخر

**نتائج البحث فارغة** → تحقق من صياغة الاستعلام وجرب تبسيط الشروط

**طريقة التحميل المرتبطة بتعليمة export** → راجع [guide](/dist/guide.pdf)

</details>

## 🤝 المساهمة

نرحب بإرسال طلبات السحب (Pull Request)! قم بعمل Fork → أنشئ فرعًا جديدًا → قدم التعديلات → افتح PR.

## 📄 الرخصة

هذا المشروع مرخص تحت رخصة MIT، للمزيد من التفاصيل راجع ملف [LICENSE](/LICENSE).


## 🙏 致谢

- 特别感谢 [go-asmr-spider](https://github.com/DiheChen/go-asmr-spider)
- 感谢所有贡献者和用户！

---

**ASMRoner** — 每天晚上都有不同的妹妹陪你入睡 :)

*最后更新：2026 年 2 月*


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-05

---