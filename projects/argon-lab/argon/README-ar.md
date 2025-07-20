<div align="right">
  <details>
    <summary >🌐 اللغة</summary>
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

# أرجون - آلة الزمن لقاعدة بيانات MongoDB 🚀

[![حالة البناء](https://github.com/argon-lab/argon/actions/workflows/ci.yml/badge.svg)](https://github.com/argon-lab/argon/actions/workflows/ci.yml)
[![تقرير Go](https://goreportcard.com/badge/github.com/argon-lab/argon)](https://goreportcard.com/report/github.com/argon-lab/argon)
[![الترخيص: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

[![Homebrew](https://img.shields.io/badge/Homebrew-argonctl-orange?logo=homebrew)](https://github.com/argon-lab/homebrew-tap)
[![npm](https://img.shields.io/npm/v/argonctl?logo=npm&label=npm)](https://www.npmjs.com/package/argonctl)
[![PyPI](https://img.shields.io/pypi/v/argon-mongodb?logo=pypi&label=PyPI)](https://pypi.org/project/argon-mongodb/)

**سافر عبر الزمن في قاعدة بيانات MongoDB الخاصة بك. أنشئ فروعاً، استعد، وجرب بدون خوف.**

## ما هو أرجون؟

يمنح أرجون قاعدة بيانات MongoDB قدرات خارقة مع **تشعبات تشبه Git** و**سفر عبر الزمن**. أنشئ فروعاً فورية لقاعدة البيانات، واستعد لأي نقطة زمنية، ولا تفقد بياناتك أبداً.

### 🎯 الفوائد الرئيسية

- **⚡ فروع فورية** - استنسخ قاعدة بياناتك بالكامل في 1 مللي ثانية (وليس ساعات)
- **⏰ سفر عبر الزمن** - استعلم عن بياناتك من أي لحظة في التاريخ
- **🔄 استعادة آمنة** - استعرض التغييرات قبل الاستعادة
- **💾 دون تكلفة تخزين إضافية** - الفروع تشارك البيانات بكفاءة
- **🔌 متوافق بشكل مباشر** - يعمل مع كود MongoDB الحالي

## عرض سريع

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
## حالات الاستخدام في العالم الحقيقي

### 🚨 **استعادة البيانات بعد الكوارث**

```bash
# "Someone deleted all users!"
argon restore reset --time "5 minutes ago"
# Crisis averted in seconds, not hours
```
### 🧪 **الاختبار الآمن**

```bash
# Test with real production data
argon branches create staging --from production
# Run risky migrations fearlessly
```
### 📊 **تحليل البيانات**

```bash
# Compare data across time
argon time-travel diff --from "last week" --to "today"
# See exactly what changed
```
## كيف يعمل

يقوم Argon باعتراض عمليات MongoDB وتسجيلها في **سجل الكتابة المسبقة (WAL)**، مما يتيح:
- إنشاء الفروع الفورية عبر مؤشرات البيانات الوصفية
- السفر عبر الزمن من خلال إعادة تشغيل العمليات
- الكفاءة بدون نسخ البيانات

كود MongoDB الحالي لديك يعمل دون أي تغيير - فقط أضف `ENABLE_WAL=true`.

## التثبيت


```bash
# CLI
brew install argon-lab/tap/argonctl    # macOS
npm install -g argonctl                 # Node.js
pip install argon-mongodb               # Python SDK

# From Source
git clone https://github.com/argon-lab/argon
cd argon/cli && go build -o argon
```
## التوثيق

- 📖 [دليل البدء السريع](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/QUICK_START.md)
- 🛠️ [مرجع واجهة برمجة التطبيقات](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/API_REFERENCE.md)
- 💡 [حالات الاستخدام](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/USE_CASES.md)
- 🏗️ [البنية](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/ARCHITECTURE.md)

## المجتمع

- 🐛 [الإبلاغ عن المشكلات](https://github.com/argon-lab/argon/issues)
- 💬 [المناقشات](https://github.com/argon-lab/argon/discussions)
- 📧 [اتصل بنا](https://www.argonlabs.tech)

---

<div align="center">

**امنح قاعدة بيانات MongoDB آلة زمنية. لن تفقد بياناتك مجددًا.**

⭐ **ضع نجمة لنا** إذا أنقذك Argon في يومك!

[ابدأ الآن →](https://raw.githubusercontent.com/argon-lab/argon/master/docs/QUICK_START.md) | [عرض توضيحي مباشر →](https://console.argonlabs.tech)

</div>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---