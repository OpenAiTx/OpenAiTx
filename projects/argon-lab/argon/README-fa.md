<div align="right">
  <details>
    <summary >🌐 زبان</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=en">انگلیسی</a>
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

# آرگون - ماشین زمان MongoDB 🚀

[![Build Status](https://github.com/argon-lab/argon/actions/workflows/ci.yml/badge.svg)](https://github.com/argon-lab/argon/actions/workflows/ci.yml)
[![Go Report](https://goreportcard.com/badge/github.com/argon-lab/argon)](https://goreportcard.com/report/github.com/argon-lab/argon)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

[![Homebrew](https://img.shields.io/badge/Homebrew-argonctl-orange?logo=homebrew)](https://github.com/argon-lab/homebrew-tap)
[![npm](https://img.shields.io/npm/v/argonctl?logo=npm&label=npm)](https://www.npmjs.com/package/argonctl)
[![PyPI](https://img.shields.io/pypi/v/argon-mongodb?logo=pypi&label=PyPI)](https://pypi.org/project/argon-mongodb/)

**در پایگاه داده MongoDB خود در زمان سفر کنید. شاخه بسازید، بازیابی کنید و بدون ترس آزمایش کنید.**

## آرگون چیست؟

آرگون قابلیت‌های فراوانی به MongoDB می‌دهد با **انشعاب شبیه به گیت** و **سفر در زمان**. به سرعت شاخه‌های پایگاه داده بسازید، به هر نقطه‌ای در تاریخ بازگردید و هرگز داده‌ای را از دست ندهید.

### 🎯 مزایای کلیدی

- **⚡ شاخه‌های فوری** - پایگاه داده خود را تنها در ۱ میلی‌ثانیه شبیه‌سازی کنید (نه چند ساعت)
- **⏰ سفر در زمان** - داده‌های خود را از هر نقطه‌ای در تاریخ با **بیش از ۲۲۰,۰۰۰ کوئری در ثانیه** مشاهده کنید
- **🔄 بازیابی امن** - پیش‌نمایش تغییرات پیش از بازگردانی
- **💾 بدون هزینه ذخیره‌سازی** - شاخه‌ها داده‌ها را با فشرده‌سازی ۹۰٪ به اشتراک می‌گذارند
- **🔌 سازگار با کد موجود** - با کد فعلی MongoDB شما کار می‌کند
- **🚀 عملکرد سازمانی** - ۲۶ برابر سریع‌تر در کوئری‌های سفر در زمان پس از بهینه‌سازی‌های اخیر
- **✅ تست جامع** - پوشش تست گسترده برای اطمینان از قابلیت اطمینان
- **🗜️ فشرده‌سازی هوشمند** - فشرده‌سازی خودکار WAL باعث کاهش حجم ذخیره‌سازی تا ۸۰-۹۰٪ می‌شود

## نمایش سریع

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
## گردش کار شبیه به Git برای MongoDB

### 🔄 **گام ۱: وارد کردن (معادل "git clone" برای پایگاه‌های داده)**

```bash
# Bring your existing MongoDB into Argon
argon import preview --uri "mongodb://localhost:27017" --database myapp
argon import database --uri "mongodb://localhost:27017" --database myapp --project myapp
# ✅ Your existing data now has time travel capabilities!
```
### 🧪 **گام ۲: شاخه ("git checkout -b")**

```bash
# Create branches for testing, staging, experiments
argon branches create staging --project myapp
argon branches create experiment-v2 --project myapp
# Full database copies created instantly 🚀
```
### 📊 **گام ۳: سفر در زمان ("git log" برای داده‌ها)**

```bash
# See your data's history
argon time-travel info --project myapp --branch main
argon time-travel query --project myapp --branch main --lsn 1000
# Compare data across time like Git commits
```
### 🚨 **گام ۴: بازیابی ("git reset" برای مواقع بحرانی)**

```bash
# "Someone deleted all users!"
argon restore reset --time "5 minutes ago"
# Crisis averted in seconds, not hours
```
## نحوه کار

آرگون عملیات‌های MongoDB را رهگیری کرده و آن‌ها را در یک **لاگ پیش‌نویس (WAL)** ثبت می‌کند که امکان موارد زیر را فراهم می‌آورد:
- انشعاب فوری از طریق اشاره‌گرهای متادیتا
- سفر در زمان با بازپخش عملیات‌ها
- کارایی بدون کپی

کد فعلی MongoDB شما بدون تغییر کار می‌کند - فقط کافیست `ENABLE_WAL=true` را اضافه کنید.

## نصب


```bash
# CLI
brew install argon-lab/tap/argonctl    # macOS
npm install -g argonctl                 # Node.js
pip install argon-mongodb               # Python SDK

# From Source
git clone https://github.com/argon-lab/argon
cd argon/cli && go build -o argon
```
## مستندات

- 📖 [راهنمای شروع سریع](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/QUICK_START.md)
- 🛠️ [مرجع API](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/API_REFERENCE.md)
- 💡 [موارد استفاده](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/USE_CASES.md)
- 🏗️ [معماری](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/ARCHITECTURE.md)

## جامعه

- 🤝 [راهنمای جامعه](https://raw.githubusercontent.com/argon-lab/argon/master/./COMMUNITY.md) - مشارکت کنید!
- 📋 [نقشه راه](https://raw.githubusercontent.com/argon-lab/argon/master/./ROADMAP.md) - ببینید چه چیزی در راه است
- 🐛 [گزارش مشکلات](https://github.com/argon-lab/argon/issues)
- 💬 [بحث‌ها](https://github.com/argon-lab/argon/discussions)
- 🏗️ [مشارکت در توسعه](https://raw.githubusercontent.com/argon-lab/argon/master/./CONTRIBUTING.md) - به ساخت Argon کمک کنید
- 📧 [تماس با ما](https://www.argonlabs.tech)

---

<div align="center">

**به MongoDB خود یک ماشین زمان بدهید. هرگز داده‌ای را از دست ندهید.**

⭐ **اگر Argon روز شما را نجات داد، به ما ستاره بدهید!**

[شروع کنید →](https://raw.githubusercontent.com/argon-lab/argon/master/docs/QUICK_START.md) | [دموی زنده →](https://console.argonlabs.tech)

</div>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-21

---