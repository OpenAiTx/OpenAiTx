<div align="right">
  <details>
    <summary >🌐 Bahasa</summary>
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

# Argon - Mesin Waktu MongoDB 🚀

[![Build Status](https://github.com/argon-lab/argon/actions/workflows/ci.yml/badge.svg)](https://github.com/argon-lab/argon/actions/workflows/ci.yml)
[![Go Report](https://goreportcard.com/badge/github.com/argon-lab/argon)](https://goreportcard.com/report/github.com/argon-lab/argon)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

[![Homebrew](https://img.shields.io/badge/Homebrew-argonctl-orange?logo=homebrew)](https://github.com/argon-lab/homebrew-tap)
[![npm](https://img.shields.io/npm/v/argonctl?logo=npm&label=npm)](https://www.npmjs.com/package/argonctl)
[![PyPI](https://img.shields.io/pypi/v/argon-mongodb?logo=pypi&label=PyPI)](https://pypi.org/project/argon-mongodb/)

**Menjelajahi waktu di database MongoDB Anda. Membuat cabang, mengembalikan, dan bereksperimen tanpa rasa takut.**

## Apa itu Argon?

Argon memberikan kekuatan super pada MongoDB dengan **branching seperti Git** dan **perjalanan waktu**. Buat cabang database secara instan, kembalikan ke titik mana pun dalam sejarah, dan jangan pernah kehilangan data lagi.

### 🎯 Keuntungan Utama

- **⚡ Cabang Instan** - Kloning seluruh database Anda dalam 1ms (bukan jam)
- **⏰ Perjalanan Waktu** - Query data Anda dari titik mana saja dalam sejarah dengan **220.000+ query/detik**
- **🔄 Pemulihan Aman** - Pratinjau perubahan sebelum mengembalikan
- **💾 Tanpa Biaya Penyimpanan** - Cabang berbagi data secara efisien dengan kompresi 90%
- **🔌 Kompatibel Plug-and-Play** - Bekerja dengan kode MongoDB yang sudah ada
- **🚀 Performa Enterprise** - Query perjalanan waktu 26x lebih cepat setelah optimasi terbaru
- **✅ Pengujian Komprehensif** - Cakupan pengujian luas untuk memastikan keandalan
- **🗜️ Kompresi Cerdas** - Kompresi WAL otomatis mengurangi penyimpanan 80-90%

## Demo Cepat

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
## Alur Kerja Mirip Git untuk MongoDB

### 🔄 **Langkah 1: Impor ("git clone" untuk basis data)**

```bash
# Bring your existing MongoDB into Argon
argon import preview --uri "mongodb://localhost:27017" --database myapp
argon import database --uri "mongodb://localhost:27017" --database myapp --project myapp
# ✅ Your existing data now has time travel capabilities!
```
### 🧪 **Langkah 2: Cabang ("git checkout -b")**

```bash
# Create branches for testing, staging, experiments
argon branches create staging --project myapp
argon branches create experiment-v2 --project myapp
# Full database copies created instantly 🚀
```
### 📊 **Langkah 3: Perjalanan Waktu ("git log" untuk data)**

```bash
# See your data's history
argon time-travel info --project myapp --branch main
argon time-travel query --project myapp --branch main --lsn 1000
# Compare data across time like Git commits
```
### 🚨 **Langkah 4: Pulihkan ("git reset" untuk bencana)**

```bash
# "Someone deleted all users!"
argon restore reset --time "5 minutes ago"
# Crisis averted in seconds, not hours
```
## Cara Kerjanya

Argon mencegat operasi MongoDB dan mencatatnya ke **Write-Ahead Log (WAL)**, memungkinkan:
- Percabangan instan melalui penunjuk metadata
- Perjalanan waktu dengan memutar ulang operasi
- Efisiensi tanpa penyalinan data

Kode MongoDB Anda yang sudah ada tetap berfungsi tanpa perubahan - cukup tambahkan `ENABLE_WAL=true`.

## Instalasi


```bash
# CLI
brew install argon-lab/tap/argonctl    # macOS
npm install -g argonctl                 # Node.js
pip install argon-mongodb               # Python SDK

# From Source
git clone https://github.com/argon-lab/argon
cd argon/cli && go build -o argon
```
## Dokumentasi

- 📖 [Panduan Mulai Cepat](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/QUICK_START.md)
- 🛠️ [Referensi API](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/API_REFERENCE.md)
- 💡 [Kasus Penggunaan](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/USE_CASES.md)
- 🏗️ [Arsitektur](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/ARCHITECTURE.md)

## Komunitas

- 🤝 [Panduan Komunitas](https://raw.githubusercontent.com/argon-lab/argon/master/./COMMUNITY.md) - Bergabunglah!
- 📋 [Peta Jalan](https://raw.githubusercontent.com/argon-lab/argon/master/./ROADMAP.md) - Lihat yang akan datang
- 🐛 [Laporkan Masalah](https://github.com/argon-lab/argon/issues)
- 💬 [Diskusi](https://github.com/argon-lab/argon/discussions)
- 🏗️ [Berkontribusi](https://raw.githubusercontent.com/argon-lab/argon/master/./CONTRIBUTING.md) - Bantu bangun Argon
- 📧 [Kontak](https://www.argonlabs.tech)

---

<div align="center">

**Beri MongoDB Anda mesin waktu. Jangan pernah kehilangan data lagi.**

⭐ **Beri bintang** jika Argon membantu Anda hari ini!

[Mulai Sekarang →](https://raw.githubusercontent.com/argon-lab/argon/master/docs/QUICK_START.md) | [Demo Langsung →](https://console.argonlabs.tech)

</div>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-21

---