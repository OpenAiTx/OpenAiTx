<div align="right">
  <details>
    <summary >🌐 Taal</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=en">Engels</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=fr">Frans</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=de">Duits</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=es">Spaans</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=it">Italiaans</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=pt">Portugees</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=pl">Pools</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=tr">Turks</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=vi">Vietnamees</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# Argon - MongoDB Tijdmachine 🚀

[![Build Status](https://github.com/argon-lab/argon/actions/workflows/ci.yml/badge.svg)](https://github.com/argon-lab/argon/actions/workflows/ci.yml)
[![Go Report](https://goreportcard.com/badge/github.com/argon-lab/argon)](https://goreportcard.com/report/github.com/argon-lab/argon)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

[![Homebrew](https://img.shields.io/badge/Homebrew-argonctl-orange?logo=homebrew)](https://github.com/argon-lab/homebrew-tap)
[![npm](https://img.shields.io/npm/v/argonctl?logo=npm&label=npm)](https://www.npmjs.com/package/argonctl)
[![PyPI](https://img.shields.io/pypi/v/argon-mongodb?logo=pypi&label=PyPI)](https://pypi.org/project/argon-mongodb/)

**Reis door de tijd in je MongoDB-database. Maak vertakkingen, herstel, en experimenteer zonder angst.**

## Wat is Argon?

Argon geeft MongoDB superkrachten met **Git-achtige vertakkingen** en **tijdreizen**. Maak direct databasevertakkingen, herstel naar elk punt in de geschiedenis, en verlies nooit meer data.

### 🎯 Belangrijkste Voordelen

- **⚡ Directe Vertakkingen** - Clone je hele database in 1ms (niet in uren)
- **⏰ Tijdreizen** - Raadpleeg je data vanuit elk moment in de geschiedenis
- **🔄 Veilig Herstel** - Bekijk wijzigingen vooraf voordat je herstelt
- **💾 Geen Opslagkosten** - Vertakkingen delen efficiënt data
- **🔌 Direct Compatibel** - Werkt met bestaande MongoDB-code

## Snelle Demo

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
## Praktijkvoorbeelden

### 🚨 **Rampenherstel**

```bash
# "Someone deleted all users!"
argon restore reset --time "5 minutes ago"
# Crisis averted in seconds, not hours
```
### 🧪 **Veilig Testen**

```bash
# Test with real production data
argon branches create staging --from production
# Run risky migrations fearlessly
```
### 📊 **Gegevensanalyse**

```bash
# Compare data across time
argon time-travel diff --from "last week" --to "today"
# See exactly what changed
```
## Hoe het werkt

Argon onderschept MongoDB-bewerkingen en logt ze naar een **Write-Ahead Log (WAL)**, waarmee het volgende mogelijk wordt:
- Direct vertakken via metadata-pointers
- Tijdreizen door bewerkingen opnieuw af te spelen
- Zero-copy efficiëntie

Je bestaande MongoDB-code werkt ongewijzigd - voeg gewoon `ENABLE_WAL=true` toe.

## Installatie


```bash
# CLI
brew install argon-lab/tap/argonctl    # macOS
npm install -g argonctl                 # Node.js
pip install argon-mongodb               # Python SDK

# From Source
git clone https://github.com/argon-lab/argon
cd argon/cli && go build -o argon
```
## Documentatie

- 📖 [Snelstartgids](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/QUICK_START.md)
- 🛠️ [API Referentie](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/API_REFERENCE.md)
- 💡 [Gebruiksscenario's](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/USE_CASES.md)
- 🏗️ [Architectuur](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/ARCHITECTURE.md)

## Community

- 🐛 [Meld Problemen](https://github.com/argon-lab/argon/issues)
- 💬 [Discussies](https://github.com/argon-lab/argon/discussions)
- 📧 [Contact](https://www.argonlabs.tech)

---

<div align="center">

**Geef je MongoDB een tijdmachine. Verlies nooit meer data.**

⭐ **Geef ons een ster** als Argon je dag redt!

[Begin direct →](https://raw.githubusercontent.com/argon-lab/argon/master/docs/QUICK_START.md) | [Live Demo →](https://console.argonlabs.tech)

</div>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---