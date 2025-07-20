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

# Argon - MongoDB टाइम मशीन 🚀

[![Build Status](https://github.com/argon-lab/argon/actions/workflows/ci.yml/badge.svg)](https://github.com/argon-lab/argon/actions/workflows/ci.yml)
[![Go Report](https://goreportcard.com/badge/github.com/argon-lab/argon)](https://goreportcard.com/report/github.com/argon-lab/argon)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

[![Homebrew](https://img.shields.io/badge/Homebrew-argonctl-orange?logo=homebrew)](https://github.com/argon-lab/homebrew-tap)
[![npm](https://img.shields.io/npm/v/argonctl?logo=npm&label=npm)](https://www.npmjs.com/package/argonctl)
[![PyPI](https://img.shields.io/pypi/v/argon-mongodb?logo=pypi&label=PyPI)](https://pypi.org/project/argon-mongodb/)

**अपने MongoDB डेटाबेस में समय की यात्रा करें। ब्रांच करें, पुनर्स्थापित करें, और बिना डर के प्रयोग करें।**

## Argon क्या है?

Argon MongoDB को **Git-जैसी ब्रांचिंग** और **टाइम ट्रैवल** के साथ सुपरपावर देता है। तुरंत डेटाबेस ब्रांच बनाएं, इतिहास के किसी भी बिंदु पर पुनर्स्थापित करें, और कभी भी डेटा न खोएं।

### 🎯 प्रमुख लाभ

- **⚡ तुरंत ब्रांच** - पूरे डेटाबेस को 1ms में क्लोन करें (घंटों में नहीं)
- **⏰ समय यात्रा** - इतिहास के किसी भी बिंदु से अपना डेटा क्वेरी करें
- **🔄 सुरक्षित पुनर्स्थापना** - पुनर्स्थापित करने से पहले बदलावों का पूर्वावलोकन करें
- **💾 शून्य स्टोरेज लागत** - ब्रांचेस कुशलतापूर्वक डेटा साझा करती हैं
- **🔌 ड्रॉप-इन संगत** - मौजूदा MongoDB कोड के साथ काम करता है

## त्वरित डेमो

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
## वास्तविक-विश्व उपयोग मामलों

### 🚨 **आपदा पुनर्प्राप्ति**

```bash
# "Someone deleted all users!"
argon restore reset --time "5 minutes ago"
# Crisis averted in seconds, not hours
```
### 🧪 **सुरक्षित परीक्षण**

```bash
# Test with real production data
argon branches create staging --from production
# Run risky migrations fearlessly
```
### 📊 **डेटा विश्लेषण**

```bash
# Compare data across time
argon time-travel diff --from "last week" --to "today"
# See exactly what changed
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

- 📖 [त्वरित प्रारंभ मार्गदर्शिका](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/QUICK_START.md)
- 🛠️ [एपीआई संदर्भ](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/API_REFERENCE.md)
- 💡 [उपयोग के मामले](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/USE_CASES.md)
- 🏗️ [आर्किटेक्चर](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/ARCHITECTURE.md)

## समुदाय

- 🐛 [समस्याएँ रिपोर्ट करें](https://github.com/argon-lab/argon/issues)
- 💬 [चर्चाएँ](https://github.com/argon-lab/argon/discussions)
- 📧 [संपर्क करें](https://www.argonlabs.tech)

---

<div align="center">

**अपने MongoDB को एक टाइम मशीन दें। अब कभी भी डेटा न खोएं।**

⭐ **हमें स्टार दें** यदि Argon ने आपका दिन बचाया है!

[शुरू करें →](https://raw.githubusercontent.com/argon-lab/argon/master/docs/QUICK_START.md) | [लाइव डेमो →](https://console.argonlabs.tech)

</div>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---