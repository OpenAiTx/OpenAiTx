<div align="right">
  <details>
    <summary >🌐 भाषा</summary>
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

# आर्गन - MongoDB टाइम मशीन 🚀

[![Build Status](https://github.com/argon-lab/argon/actions/workflows/ci.yml/badge.svg)](https://github.com/argon-lab/argon/actions/workflows/ci.yml)
[![Go Report](https://goreportcard.com/badge/github.com/argon-lab/argon)](https://goreportcard.com/report/github.com/argon-lab/argon)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

[![Homebrew](https://img.shields.io/badge/Homebrew-argonctl-orange?logo=homebrew)](https://github.com/argon-lab/homebrew-tap)
[![npm](https://img.shields.io/npm/v/argonctl?logo=npm&label=npm)](https://www.npmjs.com/package/argonctl)
[![PyPI](https://img.shields.io/pypi/v/argon-mongodb?logo=pypi&label=PyPI)](https://pypi.org/project/argon-mongodb/)

**अपनी MongoDB डाटाबेस में समय की यात्रा करें। ब्रांच करें, पुनर्स्थापित करें, और बिना डर के प्रयोग करें।**

## आर्गन क्या है?

आर्गन MongoDB को **Git जैसी ब्रांचिंग** और **टाइम ट्रैवल** जैसी सुपरपावर देता है। तुरंत डाटाबेस ब्रांच बनाएं, इतिहास के किसी भी बिंदु पर पुनर्स्थापित करें, और कभी भी डेटा न खोएं।

### 🎯 मुख्य लाभ

- **⚡ तुरंत ब्रांच** - अपनी पूरी डाटाबेस को 1ms में क्लोन करें (घंटों में नहीं)
- **⏰ टाइम ट्रैवल** - इतिहास के किसी भी बिंदु से अपने डेटा को क्वेरी करें, **220,000+ क्वेरी/सेकंड** के साथ
- **🔄 सुरक्षित पुनर्स्थापना** - पुनर्स्थापित करने से पहले बदलावों का पूर्वावलोकन करें
- **💾 शून्य स्टोरेज लागत** - ब्रांचेस डेटा को कुशलतापूर्वक साझा करती हैं, 90% कंप्रेशन के साथ
- **🔌 ड्रॉप-इन कम्पैटिबल** - मौजूदा MongoDB कोड के साथ काम करता है
- **🚀 एंटरप्राइज प्रदर्शन** - नवीनतम ऑप्टिमाइजेशन के बाद 26x तेज टाइम ट्रैवल क्वेरीज़
- **✅ व्यापक परीक्षण** - विश्वसनीयता सुनिश्चित करने के लिए विस्तृत परीक्षण कवरेज
- **🗜️ स्मार्ट कंप्रेशन** - स्वचालित WAL कंप्रेशन से स्टोरेज 80-90% तक कम

## त्वरित डेमो

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
## MongoDB के लिए Git-जैसा वर्कफ़्लो

### 🔄 **चरण 1: आयात करें ("git clone" डेटाबेस के लिए)**

```bash
# Bring your existing MongoDB into Argon
argon import preview --uri "mongodb://localhost:27017" --database myapp
argon import database --uri "mongodb://localhost:27017" --database myapp --project myapp
# ✅ Your existing data now has time travel capabilities!
```
### 🧪 **चरण 2: ब्रांच ("git checkout -b")**

```bash
# Create branches for testing, staging, experiments
argon branches create staging --project myapp
argon branches create experiment-v2 --project myapp
# Full database copies created instantly 🚀
```
### 📊 **चरण 3: समय यात्रा ("git log" डेटा के लिए)**

```bash
# See your data's history
argon time-travel info --project myapp --branch main
argon time-travel query --project myapp --branch main --lsn 1000
# Compare data across time like Git commits
```
### 🚨 **चरण 4: पुनर्स्थापित करें ("git reset" आपदाओं के लिए)**

```bash
# "Someone deleted all users!"
argon restore reset --time "5 minutes ago"
# Crisis averted in seconds, not hours
```
## यह कैसे काम करता है

आर्गन MongoDB संचालन को इंटरसेप्ट करता है और उन्हें **Write-Ahead Log (WAL)** में लॉग करता है, जिससे सक्षम होता है:
- मेटाडाटा पॉइंटर्स के माध्यम से त्वरित ब्रांचिंग
- ऑपरेशनों को फिर से चलाकर टाइम ट्रैवल
- शून्य-कॉपी दक्षता

आपका मौजूदा MongoDB कोड बिना किसी बदलाव के चलता है - बस `ENABLE_WAL=true` जोड़ें।

## स्थापना


```bash
# CLI
brew install argon-lab/tap/argonctl    # macOS
npm install -g argonctl                 # Node.js
pip install argon-mongodb               # Python SDK

# From Source
git clone https://github.com/argon-lab/argon
cd argon/cli && go build -o argon
```
## प्रलेखन

- 📖 [त्वरित प्रारंभ गाइड](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/QUICK_START.md)
- 🛠️ [एपीआई संदर्भ](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/API_REFERENCE.md)
- 💡 [उपयोग के मामले](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/USE_CASES.md)
- 🏗️ [आर्किटेक्चर](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/ARCHITECTURE.md)

## समुदाय

- 🤝 [समुदाय गाइड](https://raw.githubusercontent.com/argon-lab/argon/master/./COMMUNITY.md) - भाग लें!
- 📋 [रोडमैप](https://raw.githubusercontent.com/argon-lab/argon/master/./ROADMAP.md) - जानें आगे क्या है
- 🐛 [समस्याएँ रिपोर्ट करें](https://github.com/argon-lab/argon/issues)
- 💬 [चर्चाएँ](https://github.com/argon-lab/argon/discussions)
- 🏗️ [योगदान दें](https://raw.githubusercontent.com/argon-lab/argon/master/./CONTRIBUTING.md) - Argon के निर्माण में मदद करें
- 📧 [संपर्क करें](https://www.argonlabs.tech)

---

<div align="center">

**अपने MongoDB को एक टाइम मशीन दें। अब कभी भी डेटा न खोएं।**

⭐ **हमें स्टार दें** यदि Argon ने आपका दिन बचाया है!

[शुरू करें →](https://raw.githubusercontent.com/argon-lab/argon/master/docs/QUICK_START.md) | [लाइव डेमो →](https://console.argonlabs.tech)

</div>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-21

---