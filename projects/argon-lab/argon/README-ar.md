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

**سافر عبر الزمن في قاعدة بيانات MongoDB الخاصة بك. أنشئ فروعًا، استعد، وجرب بدون خوف.**

## ما هو أرجون؟

يمنح أرجون قاعدة بيانات MongoDB قدرات خارقة مع **تفرعات شبيهة بـ Git** و**سفر عبر الزمن**. أنشئ فروع قاعدة بيانات فورية، استعد لأي نقطة زمنية في التاريخ، ولا تفقد بياناتك مرة أخرى.

### 🎯 الفوائد الرئيسية

- **⚡ فروع فورية** - استنسخ قاعدة بياناتك بالكامل في 1 مللي ثانية (بدلاً من ساعات)
- **⏰ السفر عبر الزمن** - استعلم بياناتك من أي نقطة زمنية بمعدل **220,000+ استعلام/ثانية**
- **🔄 استعادة آمنة** - استعرض التغييرات قبل الاستعادة
- **💾 تكلفة تخزين صفرية** - الفروع تشارك البيانات بكفاءة مع ضغط 90%
- **🔌 متوافق فورياً** - يعمل مع كود MongoDB الحالي دون تعديل
- **🚀 أداء مؤسسي** - استعلامات السفر عبر الزمن أسرع بـ 26 مرة بعد آخر التحسينات
- **✅ اختبارات شاملة** - تغطية اختبارية واسعة لضمان الموثوقية
- **🗜️ ضغط ذكي** - ضغط WAL تلقائي يقلل التخزين بنسبة 80-90%

## عرض سريع

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
## سير عمل يشبه Git لـ MongoDB

### 🔄 **الخطوة 1: الاستيراد ("git clone" لقواعد البيانات)**

```bash
# Bring your existing MongoDB into Argon
argon import preview --uri "mongodb://localhost:27017" --database myapp
argon import database --uri "mongodb://localhost:27017" --database myapp --project myapp
# ✅ Your existing data now has time travel capabilities!
```
### 🧪 **الخطوة 2: إنشاء فرع ("git checkout -b")**

```bash
# Create branches for testing, staging, experiments
argon branches create staging --project myapp
argon branches create experiment-v2 --project myapp
# Full database copies created instantly 🚀
```
### 📊 **الخطوة 3: السفر عبر الزمن ("git log" للبيانات)**

```bash
# See your data's history
argon time-travel info --project myapp --branch main
argon time-travel query --project myapp --branch main --lsn 1000
# Compare data across time like Git commits
```
### 🚨 **الخطوة 4: الاستعادة ("git reset" في حالات الكوارث)**

```bash
# "Someone deleted all users!"
argon restore reset --time "5 minutes ago"
# Crisis averted in seconds, not hours
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
- 🏗️ [الهندسة المعمارية](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/ARCHITECTURE.md)

## المجتمع

- 🤝 [دليل المجتمع](https://raw.githubusercontent.com/argon-lab/argon/master/./COMMUNITY.md) - شارك في المجتمع!
- 📋 [خارطة الطريق](https://raw.githubusercontent.com/argon-lab/argon/master/./ROADMAP.md) - تعرف على ما هو قادم
- 🐛 [الإبلاغ عن المشكلات](https://github.com/argon-lab/argon/issues)
- 💬 [المناقشات](https://github.com/argon-lab/argon/discussions)
- 🏗️ [المساهمة](https://raw.githubusercontent.com/argon-lab/argon/master/./CONTRIBUTING.md) - ساعد في بناء Argon
- 📧 [الاتصال](https://www.argonlabs.tech)

---

<div align="center">

**امنح قاعدة بيانات MongoDB الخاصة بك آلة زمنية. لن تفقد بياناتك مرة أخرى.**

⭐ **ضع نجمة لنا** إذا أنقذك Argon في يومك!

[ابدأ الآن →](https://raw.githubusercontent.com/argon-lab/argon/master/docs/QUICK_START.md) | [عرض توضيحي مباشر →](https://console.argonlabs.tech)

</div>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-21

---