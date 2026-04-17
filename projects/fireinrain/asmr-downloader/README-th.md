
<div align="right">
  <details>
    <summary >🌐 ภาษา</summary>
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


## 📖 แนะนำโครงการ

ASMRoner เป็นเครื่องมือบรรทัดคำสั่งภาษา Go สำหรับค้นหา ดาวน์โหลด และซิงค์ผลงานเสียงจาก asmr.one พร้อมทั้งมีอินเตอร์เฟซเว็บสำหรับเล่นเสียงแบบง่าย

> 🌐 ผลงานที่เกี่ยวข้อง: [asmr.furina.in](https://asmr.furina.in) — หน้าฟัง ASMR ออนไลน์ที่เรียบง่ายและสะอาด

## 🚀 เริ่มต้นอย่างรวดเร็ว

```bash
git clone https://github.com/fireinrain/asmroner.git && cd asmroner
go build -o asmroner
./asmroner config   # 交互式初始化配置
```

## 📋 คำสั่งที่ใช้บ่อย

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

## 📸 ภาพหน้าจอ

| การตั้งค่า | ค้นหา |
|:---:|:---:|
| ![การตั้งค่า](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/config.png) | ![ค้นหา](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/search.png) |
| **ดาวน์โหลด** | **ซิงค์** |
| ![ดาวน์โหลด](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/download.png) | ![ซิงค์](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/sync.png) |
| **ซิงค์และดาวน์โหลด** | **สถิติ** |
| ![ซิงค์และดาวน์โหลด](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/sync-down.png) | ![สถิติ](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/sync-report.png) |
| **Web อินเทอร์เฟซ** | **Web อินเทอร์เฟซ 2** |
| ![Webอินเทอร์เฟซ](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/listen.png) | ![Webอินเทอร์เฟซ2](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/listen2.png) |

<details>
<summary><b>✨ คุณลักษณะเด่น</b></summary>

- **ค้นหา**: RJID เดี่ยว/กลุ่ม, ไวยากรณ์ค้นหาขั้นสูง, ส่งออกผลลัพธ์เป็น CSV/JSON
- **ดาวน์โหลด**: ดาวน์โหลดผลงานเดี่ยว/กลุ่ม/ยอดนิยม, จำกัดความเร็วอัตโนมัติ, รีทราย, ถอยกลับแบบเอ็กซ์โพเนนเชียล
- **ซิงค์**: ซิงค์ข้อมูลเมตา, ควบคุมการดาวน์โหลดกลุ่ม, ติดตามสถานะ, รีทรายที่ล้มเหลว
- **Web อินเทอร์เฟซ**: เรียกดูแบบภาพ, เล่นในเบราว์เซอร์, ดีไซน์ตอบสนองทุกอุปกรณ์
- **การตั้งค่า**: อินเทอร์เฟซโต้ตอบ, รองรับพร็อกซี, จำกัดความเร็ว, การหน่วง และตั้งค่าขั้นสูงอื่นๆ

</details>

<details>
<summary><b>⚙️ คำอธิบายไฟล์ตั้งค่า</b></summary>

ที่อยู่ไฟล์ตั้งค่า: `~/.asmroner/config.toml` (รูปแบบไฟล์ TOML)

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
<summary><b>📋 สรุปตัวเลือกคำสั่ง</b></summary>

| คำสั่ง | ตัวเลือก | คำอธิบาย |
|------|------|------|
| `search` | `-c` | จำนวนผลลัพธ์การค้นหา (ค่าเริ่มต้น 10) |
| `search download` | `-d`, `-s` | ไดเรกทอรีดาวน์โหลด, จำนวนดาวน์โหลด |
| `search export` | `-f`, `-n` | ชื่อไฟล์ส่งออก (.csv/.json), จำนวนส่งออก |
| `download` | `-d`, `-n` | ไดเรกทอรีดาวน์โหลด, จำนวน hot100 |
| `sync download` | `-d` | ไดเรกทอรีดาวน์โหลด |
| `sync retry` | `-d` | ไดเรกทอรีไฟล์ที่ล้มเหลว |
| `sync export` | `-s`, `-f` | สถานะ (failed/success), ไฟล์ส่งออก |
| `listen` | `-p` | พอร์ต (ค่าเริ่มต้น 9999) |

</details>

<details>
<summary><b>📁 โครงสร้างโปรเจกต์</b></summary>


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
<summary><b>🛠 สแต็คเทคโนโลยี</b></summary>

| ส่วนประกอบ | การใช้งาน |
|------|------|
| Cobra + Viper | เฟรมเวิร์ก CLI + การจัดการคอนฟิก |
| GORM + SQLite | การจัดเก็บข้อมูลถาวร |
| Resty | ไคลเอนต์ HTTP (รองรับ HTTP/SOCKS5 proxy) |
| Pond | พูลงานแบบขนาน |
| x/time/rate | การจำกัดอัตราแบบถังโทเคน |
| Gin | บริการเว็บ |
| Tailwind + Plyr | อินเทอร์เฟซฝั่งหน้า + เล่นเสียง |

</details>

<details>
<summary><b>🔧 คำถามที่พบบ่อย</b></summary>

**ไม่พบไฟล์คอนฟิก** → รัน `./asmroner config` เพื่อเริ่มต้น

**ดาวน์โหลดล้มเหลว (stream error)** → โปรแกรมจะลองใหม่อัตโนมัติ; หากยังล้มเหลว ให้ใช้ `sync retry` หรือตรวจสอบ `.asmroner-data/download_errors.log`

**ไม่สามารถเข้าถึงหน้าเว็บ** → ตรวจสอบว่าไม่มีการใช้พอร์ตนั้น ลองใช้ `-p` ระบุพอร์ตอื่น

**ผลการค้นหาว่างเปล่า** → ตรวจสอบไวยากรณ์ค้นหา ลองลดเงื่อนไขให้เรียบง่ายขึ้น

</details>

## 🤝 การมีส่วนร่วม

ยินดีต้อนรับการส่ง Pull Request! Fork → สร้าง branch ใหม่ → ส่งการเปลี่ยนแปลง → เปิด PR

## 📄 ใบอนุญาต

โปรเจกต์นี้ใช้สัญญาอนุญาต MIT รายละเอียดดูที่ไฟล์ [LICENSE](/LICENSE)

## 🙏 ขอบคุณ


- ขอขอบคุณเป็นพิเศษ [go-asmr-spider](https://github.com/DiheChen/go-asmr-spider)
- ขอบคุณผู้มีส่วนร่วมและผู้ใช้ทุกท่าน!

---

**ASMRoner** — ทุกค่ำคืนจะมีสาวๆต่างคนคอยกล่อมคุณเข้านอน :)

*อัปเดตล่าสุด: กุมภาพันธ์ 2026*


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-17

---