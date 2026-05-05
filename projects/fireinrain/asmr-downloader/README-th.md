
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
https://github.com/MIKANOoOo/asmr-downloader.git && cd asmroner
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

  # 导出单个作品或指定数量热门榜链接 & 导出到指定目录
./asmroner export RJ01544940 -o ./downloads
./asmroner export hot100 -n 20 -o ./downloads
./asmroner export hot100 -n 10 -o ./downloads
更多内容参考常见问题中的guide

# Web 播放界面
./asmroner listen -p 8080 ./syncdata
```

## 📸 ตัวอย่างหน้าจอ

| การตั้งค่า | ค้นหา |
|:---:|:---:|
| ![การตั้งค่า](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/config.png) | ![ค้นหา](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/search.png) |
| **ดาวน์โหลด** | **ซิงค์** |
| ![ดาวน์โหลด](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/download.png) | ![ซิงค์](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/sync.png) |
| **ซิงค์ดาวน์โหลด** | **สถิติ** |
| ![ซิงค์ดาวน์โหลด](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/sync-down.png) | ![สถิติ](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/sync-report.png) |
| **Web อินเทอร์เฟซ** | **Web อินเทอร์เฟซ 2** |
| ![Webอินเทอร์เฟซ](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/listen.png) | ![Webอินเทอร์เฟซ2](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/listen2.png) |
| **export อินเทอร์เฟซ** | **export อินเทอร์เฟซ 2** |
| ![exportอินเทอร์เฟซ](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/export1.png) | ![exportอินเทอร์เฟซ2](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/export2.png) |

<details>
<summary><b>✨ ฟีเจอร์เด่น</b></summary>

- **ค้นหา**: ค้นหา RJID เดี่ยว/หลายรายการ, คำสั่งค้นหาขั้นสูง, ส่งออกผลลัพธ์เป็น CSV/JSON
- **ดาวน์โหลด**: ดาวน์โหลดเดี่ยว/หลายรายการ/ผลงานยอดนิยม, ควบคุมความเร็วอัตโนมัติ, รีทไร, ถอยหลังแบบเลขชี้กำลัง
- **ซิงค์**: ซิงค์ข้อมูลเมตา, ควบคุมการดาวน์โหลดชุดใหญ่, ติดตามสถานะ, รีทไรงานที่ล้มเหลว
- **Web อินเทอร์เฟซ**: เรียกดูแบบกราฟิก, เล่นในเบราว์เซอร์, ออกแบบให้ตอบสนองทุกอุปกรณ์
- **การตั้งค่า**: กำหนดค่าแบบอินเตอร์แอคทีฟ, รองรับพร็อกซี, ควบคุมความเร็ว, jitter และการตั้งค่าขั้นสูงอื่นๆ

</details>

<details>
<summary><b>⚙️ คำอธิบายไฟล์ตั้งค่า</b></summary>

เส้นทางไฟล์ตั้งค่า: `~/.asmroner/config.toml` (รูปแบบ TOML)

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
<summary><b>📋 ตารางออปชั่นคำสั่งด่วน</b></summary>

| คำสั่ง | ออปชั่น | คำอธิบาย |
|------|------|------|
| `search` | `-c` | จำนวนผลลัพธ์ที่ค้นหา (ค่าเริ่มต้น 10) |
| `search download` | `-d`, `-s` | ไดเรกทอรีดาวน์โหลด, จำนวนดาวน์โหลด |
| `search export` | `-f`, `-n` | ชื่อไฟล์ส่งออก (.csv/.json), จำนวนส่งออก |
| `download` | `-d`, `-n` | ไดเรกทอรีดาวน์โหลด, จำนวน hot100 |
| `sync download` | `-d` | ไดเรกทอรีดาวน์โหลด |
| `sync retry` | `-d` | ไดเรกทอรีไฟล์ที่ล้มเหลว |
| `sync export` | `-s`, `-f` | สถานะ (failed/success), ไฟล์ส่งออก |
| `listen` | `-p` | พอร์ต (ค่าเริ่มต้น 9999) |
| `export` | `-o`, `-n` | ไดเรกทอรีส่งออก, จำนวน hot100 |

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
<summary><b>🛠 สแต็กเทคโนโลยี</b></summary>

| องค์ประกอบ | การใช้งาน |
|------|------|
| Cobra + Viper | เฟรมเวิร์ก CLI + การจัดการคอนฟิก |
| GORM + SQLite | การจัดเก็บข้อมูลถาวร |
| Resty | ไคลเอนต์ HTTP (รองรับ HTTP/SOCKS5 proxy) |
| Pond | พูลงานแบบขนาน |
| x/time/rate | การจำกัดอัตราแบบ token bucket |
| Gin | บริการเว็บ |
| Tailwind + Plyr | ส่วนติดต่อผู้ใช้ฝั่งหน้าเว็บ + การเล่นไฟล์เสียง |

</details>

<details>
<summary><b>🔧 คำถามที่พบบ่อย</b></summary>

**ไม่พบไฟล์คอนฟิก** → รัน `./asmroner config` เพื่อเริ่มต้น

**ดาวน์โหลดล้มเหลว (stream error)** → โปรแกรมจะลองใหม่อัตโนมัติ; หากยังล้มเหลว ให้ใช้ `sync retry` เพื่อพยายามอีกครั้ง หรือดูที่ `.asmroner-data/download_errors.log`

**ไม่สามารถเข้าถึงเว็บอินเทอร์เฟซ** → ตรวจสอบว่าไม่มีการใช้พอร์ตดังกล่าว และลองใช้ `-p` เพื่อระบุพอร์ตอื่น

**ผลการค้นหาว่างเปล่า** → ตรวจสอบไวยากรณ์การค้นหา และลองลดเงื่อนไขให้ง่ายขึ้น

**วิธีดาวน์โหลดที่ใช้ร่วมกับคำสั่ง export** → ดู [guide](/dist/guide.pdf) 

</details>

## 🤝 การมีส่วนร่วม

ยินดีต้อนรับการส่ง Pull Request! Fork → สร้าง branch ใหม่ → ส่งการเปลี่ยนแปลง → เปิด PR

## 📄 ใบอนุญาต

โปรเจกต์นี้ใช้สัญญาอนุญาต MIT รายละเอียดดูได้ที่ไฟล์ [LICENSE](/LICENSE)


## 🙏 致谢

- 特别感谢 [go-asmr-spider](https://github.com/DiheChen/go-asmr-spider)
- 感谢所有贡献者和用户！

---

**ASMRoner** — 每天晚上都有不同的妹妹陪你入睡 :)

*最后更新：2026 年 2 月*


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-05

---