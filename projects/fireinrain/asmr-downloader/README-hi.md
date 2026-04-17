
<div align="right">
  <details>
    <summary >🌐 भाषा</summary>
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


## 📖 परियोजना परिचय

ASMRoner एक Go भाषा की कमांड लाइन टूल है, जो asmr.one ऑडियो कार्यों को खोजने, डाउनलोड करने, सिंक करने और सरल वेब प्लेयर इंटरफ़ेस प्रदान करने के लिए उपयोग होती है।

> 🌐 डेरिवेटिव प्रोजेक्ट: [asmr.furina.in](https://asmr.furina.in) — एक सरल और साफ-सुथरा ऑनलाइन ASMR सुनने का पृष्ठ

## 🚀 त्वरित शुरुआत

```bash
git clone https://github.com/fireinrain/asmroner.git && cd asmroner
go build -o asmroner
./asmroner config   # 交互式初始化配置
```

## 📋 सामान्य आदेश

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

## 📸 स्क्रीनशॉट

| कॉन्फ़िगरेशन | खोज |
|:---:|:---:|
| ![कॉन्फ़िगरेशन](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/config.png) | ![खोज](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/search.png) |
| **डाउनलोड** | **सिंक** |
| ![डाउनलोड](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/download.png) | ![सिंक](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/sync.png) |
| **सिंक डाउनलोड** | **सांख्यिकी** |
| ![सिंक डाउनलोड](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/sync-down.png) | ![सांख्यिकी](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/sync-report.png) |
| **Web इंटरफ़ेस** | **Web इंटरफ़ेस 2** |
| ![Web इंटरफ़ेस](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/listen.png) | ![Web इंटरफ़ेस 2](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/listen2.png) |

<details>
<summary><b>✨ फीचर विशेषताएँ</b></summary>

- **खोज**: एकल/बैच RJID, उन्नत खोज सिंटैक्स, परिणाम निर्यात CSV/JSON
- **डाउनलोड**: एकल/बैच/लोकप्रिय कृतियों की डाउनलोडिंग, स्वचालित लिमिटिंग, पुनः प्रयास, एक्सपोनेंशियल बैकऑफ
- **सिंक**: मेटाडाटा सिंक, बैच डाउनलोड नियंत्रण, स्थिति ट्रैकिंग, असफलता पर पुनः प्रयास
- **Web इंटरफ़ेस**: विज़ुअल ब्राउज़िंग, ब्राउज़र में प्लेबैक, उत्तरदायी डिज़ाइन
- **कॉन्फ़िगरेशन**: इंटरैक्टिव इनिशियलाइज़ेशन, प्रॉक्सी, लिमिटिंग, जिटर आदि उन्नत सेटिंग्स सपोर्ट

</details>

<details>
<summary><b>⚙️ कॉन्फ़िगरेशन फ़ाइल विवरण</b></summary>

कॉन्फ़िगरेशन फ़ाइल पथ: `~/.asmroner/config.toml` (TOML फ़ॉर्मेट)

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
<summary><b>📋 कमांड विकल्प त्वरित संदर्भ</b></summary>

| कमांड | विकल्प | विवरण |
|-------|-------|-------|
| `search` | `-c` | खोज परिणामों की संख्या (डिफ़ॉल्ट 10) |
| `search download` | `-d`, `-s` | डाउनलोड डायरेक्टरी, डाउनलोड संख्या |
| `search export` | `-f`, `-n` | एक्सपोर्ट फाइल नाम (.csv/.json), एक्सपोर्ट संख्या |
| `download` | `-d`, `-n` | डाउनलोड डायरेक्टरी, hot100 संख्या |
| `sync download` | `-d` | डाउनलोड डायरेक्टरी |
| `sync retry` | `-d` | असफल फाइलों की डायरेक्टरी |
| `sync export` | `-s`, `-f` | स्थिति (failed/success), एक्सपोर्ट फाइल |
| `listen` | `-p` | पोर्ट (डिफ़ॉल्ट 9999) |

</details>

<details>
<summary><b>📁 प्रोजेक्ट संरचना</b></summary>


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
<summary><b>🛠 तकनीकी स्टैक</b></summary>

| घटक | उपयोग |
|------|------|
| Cobra + Viper | CLI फ्रेमवर्क + कॉन्फ़िगरेशन प्रबंधन |
| GORM + SQLite | डेटा स्थायित्व |
| Resty | HTTP क्लाइंट (HTTP/SOCKS5 प्रॉक्सी समर्थन) |
| Pond | समवर्ती कार्य पूल |
| x/time/rate | टोकन बकेट रेट लिमिटिंग |
| Gin | वेब सेवा |
| Tailwind + Plyr | फ्रंटेंड इंटरफेस + ऑडियो प्लेयर |

</details>

<details>
<summary><b>🔧 सामान्य समस्याएँ</b></summary>

**कॉन्फ़िगरेशन फ़ाइल नहीं मिली** → `./asmroner config` चलाकर प्रारंभ करें

**डाउनलोड विफल (stream error)** → प्रोग्राम ऑटो रीट्राई करेगा; अगर फिर भी विफल हो, तो `sync retry` से पुनः प्रयास करें या `.asmroner-data/download_errors.log` देखें

**वेब इंटरफ़ेस एक्सेस नहीं हो रहा** → सुनिश्चित करें कि पोर्ट व्यस्त नहीं है, `-p` से कोई अन्य पोर्ट आज़माएँ

**सर्च परिणाम खाली** → क्वेरी सिंटैक्स जांचें, शर्तों को सरल करें

</details>

## 🤝 योगदान

Pull Request आमंत्रित हैं! Fork → नई ब्रांच बनाएं → बदलाव सबमिट करें → PR शुरू करें।

## 📄 लाइसेंस

यह परियोजना MIT लाइसेंस के अंतर्गत है, अधिक जानकारी के लिए [LICENSE](/LICENSE) फ़ाइल देखें।

## 🙏 धन्यवाद


- विशेष धन्यवाद [go-asmr-spider](https://github.com/DiheChen/go-asmr-spider)
- सभी योगदानकर्ताओं और उपयोगकर्ताओं का धन्यवाद!

---

**ASMRoner** — हर रात अलग-अलग बहनें आपके साथ सोने के लिए होंगी :)

*अंतिम अपडेट: फरवरी 2026*


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-17

---