<div align="right">
  <details>
    <summary >🌐 ภาษา</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# Argon - เครื่องย้อนเวลาสำหรับ MongoDB 🚀

[![Build Status](https://github.com/argon-lab/argon/actions/workflows/ci.yml/badge.svg)](https://github.com/argon-lab/argon/actions/workflows/ci.yml)
[![Go Report](https://goreportcard.com/badge/github.com/argon-lab/argon)](https://goreportcard.com/report/github.com/argon-lab/argon)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

[![Homebrew](https://img.shields.io/badge/Homebrew-argonctl-orange?logo=homebrew)](https://github.com/argon-lab/homebrew-tap)
[![npm](https://img.shields.io/npm/v/argonctl?logo=npm&label=npm)](https://www.npmjs.com/package/argonctl)
[![PyPI](https://img.shields.io/pypi/v/argon-mongodb?logo=pypi&label=PyPI)](https://pypi.org/project/argon-mongodb/)

**เดินทางข้ามเวลาในฐานข้อมูล MongoDB ของคุณ สร้าง branch กู้คืน และทดลองได้โดยไม่ต้องกลัว**

## Argon คืออะไร?

Argon มอบพลังพิเศษให้กับ MongoDB ด้วย **การแตก branch แบบ Git** และ **ย้อนเวลา** สร้าง branch ฐานข้อมูลได้ทันที กู้คืนข้อมูลไปยังจุดใดก็ได้ในอดีต และไม่สูญเสียข้อมูลอีกต่อไป

### 🎯 คุณสมบัติเด่น

- **⚡ สร้าง Branch ทันที** - โคลนฐานข้อมูลทั้งชุดใน 1 มิลลิวินาที (ไม่ต้องรอเป็นชั่วโมง)
- **⏰ ย้อนเวลา** - ค้นหาข้อมูลในอดีตได้ทุกจุดด้วย **220,000+ คำสั่ง/วินาที**
- **🔄 กู้คืนอย่างปลอดภัย** - แสดงตัวอย่างการเปลี่ยนแปลงก่อนกู้คืนจริง
- **💾 ไม่เปลืองพื้นที่จัดเก็บ** - Branch ทุกอันใช้ข้อมูลร่วมกันอย่างมีประสิทธิภาพ บีบอัดได้ถึง 90%
- **🔌 ใช้งานร่วมกับโค้ด MongoDB เดิมได้ทันที**
- **🚀 ประสิทธิภาพระดับองค์กร** - สั่งย้อนเวลาเร็วขึ้น 26 เท่าหลังอัปเดตล่าสุด
- **✅ ทดสอบอย่างครอบคลุม** - มีชุดทดสอบมากมาย เพื่อความน่าเชื่อถือ
- **🗜️ บีบอัดอัตโนมัติ** - WAL Compression ลดพื้นที่จัดเก็บลง 80-90%

## ตัวอย่างการใช้งานอย่างรวดเร็ว

```bash
# Install
brew install argon-lab/tap/argonctl    # macOS
npm install -g argonctl                 # Cross-platform

# Step 1: Import your existing MongoDB (like "git clone")
argon import database --uri "mongodb://localhost:27017" --database myapp --project myapp
# ✅ Your data now has time travel capabilities!

# Step 2: Use Argon like Git for your database
argon branches create test-env           # Branch like "git checkout -b"
argon time-travel query --project myapp --branch main --lsn 1000

# Step 3: Disaster recovery made simple
argon restore preview --time "1 hour ago"
argon restore reset --time "before disaster"
```
## เวิร์กโฟลว์แบบ Git สำหรับ MongoDB

### 🔄 **ขั้นตอนที่ 1: นำเข้า ("git clone" สำหรับฐานข้อมูล)**

```bash
# Bring your existing MongoDB into Argon
argon import preview --uri "mongodb://localhost:27017" --database myapp
argon import database --uri "mongodb://localhost:27017" --database myapp --project myapp
# ✅ Your existing data now has time travel capabilities!
```
### 🧪 **ขั้นตอนที่ 2: สร้างสาขา ("git checkout -b")**

```bash
# Create branches for testing, staging, experiments
argon branches create staging --project myapp
argon branches create experiment-v2 --project myapp
# Full database copies created instantly 🚀
```
### 📊 **ขั้นตอนที่ 3: เดินทางข้ามเวลา ("git log" สำหรับข้อมูล)**

```bash
# See your data's history
argon time-travel info --project myapp --branch main
argon time-travel query --project myapp --branch main --lsn 1000
# Compare data across time like Git commits
```
### 🚨 **ขั้นตอนที่ 4: กู้คืน ("git reset" สำหรับเหตุการณ์ร้ายแรง)**

```bash
# "Someone deleted all users!"
argon restore reset --time "5 minutes ago"
# Crisis averted in seconds, not hours
```
## วิธีการทำงาน

Argon สกัดกั้นการทำงานของ MongoDB และบันทึกลงใน **Write-Ahead Log (WAL)** เพื่อให้สามารถ:
- แตกสายข้อมูลทันทีด้วยตัวชี้เมตาดาต้า
- เดินทางข้ามเวลาโดยการเล่นซ้ำการทำงาน
- ประสิทธิภาพแบบ zero-copy

โค้ด MongoDB เดิมของคุณสามารถใช้งานได้โดยไม่ต้องเปลี่ยนแปลง - เพียงแค่เพิ่ม `ENABLE_WAL=true`

## การติดตั้ง


```bash
# CLI
brew install argon-lab/tap/argonctl    # macOS
npm install -g argonctl                 # Node.js
pip install argon-mongodb               # Python SDK

# From Source
git clone https://github.com/argon-lab/argon
cd argon/cli && go build -o argon
```
## เอกสารประกอบ

- 📖 [คู่มือเริ่มต้นอย่างรวดเร็ว](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/QUICK_START.md)
- 🛠️ [ข้อมูลอ้างอิง API](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/API_REFERENCE.md)
- 💡 [กรณีการใช้งาน](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/USE_CASES.md)
- 🏗️ [สถาปัตยกรรม](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/ARCHITECTURE.md)

## ชุมชน

- 🤝 [คู่มือชุมชน](https://raw.githubusercontent.com/argon-lab/argon/master/./COMMUNITY.md) - มีส่วนร่วมได้เลย!
- 📋 [แผนงาน](https://raw.githubusercontent.com/argon-lab/argon/master/./ROADMAP.md) - ดูว่ามีอะไรใหม่บ้าง
- 🐛 [แจ้งปัญหา](https://github.com/argon-lab/argon/issues)
- 💬 [พูดคุย](https://github.com/argon-lab/argon/discussions)
- 🏗️ [ร่วมพัฒนา](https://raw.githubusercontent.com/argon-lab/argon/master/./CONTRIBUTING.md) - ช่วยสร้าง Argon ไปด้วยกัน
- 📧 [ติดต่อ](https://www.argonlabs.tech)

---

<div align="center">

**ให้ MongoDB ของคุณย้อนเวลากลับไปได้ ไม่ต้องสูญเสียข้อมูลอีกต่อไป**

⭐ **กด Star ให้เรา** หาก Argon ช่วยงานคุณ!

[เริ่มต้นใช้งาน →](https://raw.githubusercontent.com/argon-lab/argon/master/docs/QUICK_START.md) | [ทดลองใช้งานจริง →](https://console.argonlabs.tech)

</div>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-21

---