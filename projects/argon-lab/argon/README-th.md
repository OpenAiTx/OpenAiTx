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

Argon มอบพลังพิเศษให้ MongoDB ด้วย **การสร้าง branch แบบ Git** และ **การเดินทางข้ามเวลา** สร้าง branch ฐานข้อมูลแบบทันที กู้คืนไปยังจุดใดก็ได้ในอดีต และไม่ต้องกังวลกับการสูญหายของข้อมูลอีกต่อไป

### 🎯 คุณประโยชน์หลัก

- **⚡ สร้าง Branch ทันที** - โคลนฐานข้อมูลทั้งชุดได้ใน 1 มิลลิวินาที (ไม่ใช่เป็นชั่วโมง)
- **⏰ เดินทางข้ามเวลา** - เรียกดูข้อมูลจากจุดเวลาใดก็ได้ในอดีต
- **🔄 กู้คืนอย่างปลอดภัย** - แสดงตัวอย่างการเปลี่ยนแปลงก่อนกู้คืน
- **💾 ประหยัดพื้นที่จัดเก็บ** - Branch ต่างๆ ใช้ข้อมูลร่วมกันอย่างมีประสิทธิภาพ
- **🔌 ใช้งานร่วมกับโค้ด MongoDB เดิมได้ทันที**

## สาธิตการใช้งานเบื้องต้น

```bash
# Install
brew install argon-lab/tap/argonctl    # macOS
npm install -g argonctl                 # Cross-platform

# Create a time-travel enabled database
export ENABLE_WAL=true
argon projects create myapp

# Your app crashed after bad migration? No problem!
argon restore preview --time "1 hour ago"
argon restore reset --time "before disaster"

# Need a test environment? Branch instantly!
argon branches create test-env
# Full database copy created in 1ms 🚀
```
## กรณีการใช้งานในโลกจริง

### 🚨 **การกู้คืนจากภัยพิบัติ**

```bash
# "Someone deleted all users!"
argon restore reset --time "5 minutes ago"
# Crisis averted in seconds, not hours
```
### 🧪 **การทดสอบอย่างปลอดภัย**

```bash
# Test with real production data
argon branches create staging --from production
# Run risky migrations fearlessly
```
### 📊 **การวิเคราะห์ข้อมูล**

```bash
# Compare data across time
argon time-travel diff --from "last week" --to "today"
# See exactly what changed
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

- 🐛 [รายงานปัญหา](https://github.com/argon-lab/argon/issues)
- 💬 [พูดคุย](https://github.com/argon-lab/argon/discussions)
- 📧 [ติดต่อ](https://www.argonlabs.tech)

---

<div align="center">

**ให้ MongoDB ของคุณมีไทม์แมชชีน ไม่ต้องสูญเสียข้อมูลอีกต่อไป**

⭐ **กดดาวให้เรา** หาก Argon ช่วยคุณได้!

[เริ่มต้นใช้งาน →](https://raw.githubusercontent.com/argon-lab/argon/master/docs/QUICK_START.md) | [ทดลองใช้งานจริง →](https://console.argonlabs.tech)

</div>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---