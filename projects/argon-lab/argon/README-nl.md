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
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=id">Bahasa Indonesisch</a>
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

**Reis door de tijd in je MongoDB-database. Vertak, herstel en experimenteer zonder angst.**

## Wat is Argon?

Argon geeft MongoDB superkrachten met **Git-achtige vertakkingen** en **tijdreizen**. Maak directe databasevertakkingen, herstel naar elk moment in de geschiedenis, en verlies nooit meer data.

### 🎯 Belangrijkste Voordelen

- **⚡ Directe Vertakkingen** - Kloon je volledige database in 1 ms (niet uren)
- **⏰ Tijdreizen** - Raadpleeg je data van elk moment in de geschiedenis met **220.000+ queries/sec**
- **🔄 Veilig Herstellen** - Bekijk wijzigingen voorafgaand aan herstel
- **💾 Geen Opslagkosten** - Vertakkingen delen data efficiënt met 90% compressie
- **🔌 Naadloos Inzetbaar** - Werkt met bestaande MongoDB-code
- **🚀 Enterprise Prestaties** - 26x snellere tijdreizen-queries na de laatste optimalisaties
- **✅ Uitgebreide Tests** - Grondige testdekking voor betrouwbaarheid
- **🗜️ Slimme Compressie** - Automatische WAL-compressie vermindert opslag met 80-90%

## Snelle Demo

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
## Git-achtige workflow voor MongoDB

### 🔄 **Stap 1: Importeren ("git clone" voor databases)**

```bash
# Bring your existing MongoDB into Argon
argon import preview --uri "mongodb://localhost:27017" --database myapp
argon import database --uri "mongodb://localhost:27017" --database myapp --project myapp
# ✅ Your existing data now has time travel capabilities!
```
### 🧪 **Stap 2: Branch ("git checkout -b")**

```bash
# Create branches for testing, staging, experiments
argon branches create staging --project myapp
argon branches create experiment-v2 --project myapp
# Full database copies created instantly 🚀
```
### 📊 **Stap 3: Tijdreizen ("git log" voor data)**

```bash
# See your data's history
argon time-travel info --project myapp --branch main
argon time-travel query --project myapp --branch main --lsn 1000
# Compare data across time like Git commits
```
### 🚨 **Stap 4: Herstellen ("git reset" voor rampen)**

```bash
# "Someone deleted all users!"
argon restore reset --time "5 minutes ago"
# Crisis averted in seconds, not hours
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

- 🤝 [Community Gids](https://raw.githubusercontent.com/argon-lab/argon/master/./COMMUNITY.md) - Doe mee!
- 📋 [Roadmap](https://raw.githubusercontent.com/argon-lab/argon/master/./ROADMAP.md) - Zie wat er aankomt
- 🐛 [Meld Problemen](https://github.com/argon-lab/argon/issues)
- 💬 [Discussies](https://github.com/argon-lab/argon/discussions)
- 🏗️ [Bijdragen](https://raw.githubusercontent.com/argon-lab/argon/master/./CONTRIBUTING.md) - Help Argon ontwikkelen
- 📧 [Contact](https://www.argonlabs.tech)

---

<div align="center">

**Geef je MongoDB een tijdmachine. Verlies nooit meer data.**

⭐ **Geef ons een ster** als Argon je dag redt!

[Begin nu →](https://raw.githubusercontent.com/argon-lab/argon/master/docs/QUICK_START.md) | [Live Demo →](https://console.argonlabs.tech)

</div>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-21

---