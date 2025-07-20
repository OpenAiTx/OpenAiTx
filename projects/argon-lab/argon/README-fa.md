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

**در پایگاه داده MongoDB خود در زمان سفر کنید. بدون نگرانی شاخه بسازید، بازیابی کنید و آزمایش نمایید.**

## آرگون چیست؟

آرگون به MongoDB قدرت‌های ویژه‌ای می‌دهد با **شاخه‌بندی شبیه گیت** و **سفر در زمان**. شاخه‌های پایگاه داده را به‌صورت فوری بسازید، به هر نقطه‌ای از تاریخ بازگردید و هرگز داده‌ای را از دست ندهید.

### 🎯 مزایای کلیدی

- **⚡ شاخه‌های فوری** - کل پایگاه داده خود را در ۱ میلی‌ثانیه (نه ساعت‌ها) کلون کنید
- **⏰ سفر در زمان** - داده‌های خود را از هر نقطه‌ای در گذشته بازیابی کنید
- **🔄 بازیابی امن** - قبل از بازیابی تغییرات را پیش‌نمایش کنید
- **💾 بدون هزینه ذخیره‌سازی** - شاخه‌ها داده را به‌صورت بهینه به اشتراک می‌گذارند
- **🔌 سازگاری کامل** - با کدهای فعلی MongoDB شما کار می‌کند

## نمایش سریع

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
## موارد استفاده در دنیای واقعی

### 🚨 **بازیابی پس از فاجعه**

```bash
# "Someone deleted all users!"
argon restore reset --time "5 minutes ago"
# Crisis averted in seconds, not hours
```
### 🧪 **تست ایمن**

```bash
# Test with real production data
argon branches create staging --from production
# Run risky migrations fearlessly
```
### 📊 **تحلیل داده‌ها**

```bash
# Compare data across time
argon time-travel diff --from "last week" --to "today"
# See exactly what changed
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

- 🐛 [گزارش مشکلات](https://github.com/argon-lab/argon/issues)
- 💬 [بحث‌ها](https://github.com/argon-lab/argon/discussions)
- 📧 [تماس](https://www.argonlabs.tech)

---

<div align="center">

**به MongoDB خود یک ماشین زمان بدهید. دیگر هرگز داده‌ای را از دست ندهید.**

⭐ **اگر Argon به شما کمک کرد، ما را ستاره‌دار کنید!**

[شروع کنید →](https://raw.githubusercontent.com/argon-lab/argon/master/docs/QUICK_START.md) | [دموی زنده →](https://console.argonlabs.tech)

</div>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---