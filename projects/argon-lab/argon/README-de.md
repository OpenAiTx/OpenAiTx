<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
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

# Argon - MongoDB Zeitmaschine 🚀

[![Build Status](https://github.com/argon-lab/argon/actions/workflows/ci.yml/badge.svg)](https://github.com/argon-lab/argon/actions/workflows/ci.yml)
[![Go Report](https://goreportcard.com/badge/github.com/argon-lab/argon)](https://goreportcard.com/report/github.com/argon-lab/argon)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

[![Homebrew](https://img.shields.io/badge/Homebrew-argonctl-orange?logo=homebrew)](https://github.com/argon-lab/homebrew-tap)
[![npm](https://img.shields.io/npm/v/argonctl?logo=npm&label=npm)](https://www.npmjs.com/package/argonctl)
[![PyPI](https://img.shields.io/pypi/v/argon-mongodb?logo=pypi&label=PyPI)](https://pypi.org/project/argon-mongodb/)

**Reise durch die Zeit in deiner MongoDB-Datenbank. Branching, Wiederherstellung und Experimente ohne Angst.**

## Was ist Argon?

Argon verleiht MongoDB Superkräfte mit **Git-ähnlichem Branching** und **Zeitreisen**. Erstelle sofort Datenbank-Branches, stelle jeden beliebigen Zeitpunkt der Historie wieder her und verliere nie wieder Daten.

### 🎯 Zentrale Vorteile

- **⚡ Sofortige Branches** – Klone deine gesamte Datenbank in 1 ms (statt Stunden)
- **⏰ Zeitreisen** – Frage deine Daten zu jedem beliebigen Zeitpunkt der Historie mit **220.000+ Abfragen/Sek.** ab
- **🔄 Sicheres Wiederherstellen** – Vorschau der Änderungen vor dem Wiederherstellen
- **💾 Keine Speicherkosten** – Branches teilen Daten effizient mit 90 % Kompression
- **🔌 Plug-and-Play-Kompatibilität** – Funktioniert mit bestehendem MongoDB-Code
- **🚀 Enterprise-Performance** – 26x schnellere Zeitreise-Abfragen nach den neuesten Optimierungen
- **✅ Umfassende Tests** – Umfassende Testabdeckung für maximale Zuverlässigkeit
- **🗜️ Intelligente Komprimierung** – Automatische WAL-Komprimierung reduziert Speicherbedarf um 80-90 %

## Schnell-Demo

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
## Git-ähnlicher Workflow für MongoDB

### 🔄 **Schritt 1: Importieren ("git clone" für Datenbanken)**

```bash
# Bring your existing MongoDB into Argon
argon import preview --uri "mongodb://localhost:27017" --database myapp
argon import database --uri "mongodb://localhost:27017" --database myapp --project myapp
# ✅ Your existing data now has time travel capabilities!
```
### 🧪 **Schritt 2: Branch ("git checkout -b")**

```bash
# Create branches for testing, staging, experiments
argon branches create staging --project myapp
argon branches create experiment-v2 --project myapp
# Full database copies created instantly 🚀
```
### 📊 **Schritt 3: Zeitreise ("git log" für Daten)**

```bash
# See your data's history
argon time-travel info --project myapp --branch main
argon time-travel query --project myapp --branch main --lsn 1000
# Compare data across time like Git commits
```
### 🚨 **Schritt 4: Wiederherstellen („git reset“ bei Katastrophen)**

```bash
# "Someone deleted all users!"
argon restore reset --time "5 minutes ago"
# Crisis averted in seconds, not hours
```
## Funktionsweise

Argon fängt MongoDB-Operationen ab und protokolliert sie in einem **Write-Ahead Log (WAL)**, was Folgendes ermöglicht:
- Sofortiges Branching über Metadatenzeiger
- Zeitreisen durch das Wiederholen von Operationen
- Zero-Copy-Effizienz

Ihr bestehender MongoDB-Code funktioniert unverändert – fügen Sie einfach `ENABLE_WAL=true` hinzu.

## Installation


```bash
# CLI
brew install argon-lab/tap/argonctl    # macOS
npm install -g argonctl                 # Node.js
pip install argon-mongodb               # Python SDK

# From Source
git clone https://github.com/argon-lab/argon
cd argon/cli && go build -o argon
```
## Dokumentation

- 📖 [Schnellstart-Anleitung](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/QUICK_START.md)
- 🛠️ [API-Referenz](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/API_REFERENCE.md)
- 💡 [Anwendungsfälle](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/USE_CASES.md)
- 🏗️ [Architektur](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/ARCHITECTURE.md)

## Community

- 🤝 [Community-Leitfaden](https://raw.githubusercontent.com/argon-lab/argon/master/./COMMUNITY.md) - Mach mit!
- 📋 [Roadmap](https://raw.githubusercontent.com/argon-lab/argon/master/./ROADMAP.md) - Sieh, was kommt
- 🐛 [Probleme melden](https://github.com/argon-lab/argon/issues)
- 💬 [Diskussionen](https://github.com/argon-lab/argon/discussions)
- 🏗️ [Mitwirken](https://raw.githubusercontent.com/argon-lab/argon/master/./CONTRIBUTING.md) - Hilf mit, Argon zu entwickeln
- 📧 [Kontakt](https://www.argonlabs.tech)

---

<div align="center">

**Gib deiner MongoDB eine Zeitmaschine. Verliere nie wieder Daten.**

⭐ **Gib uns einen Stern**, wenn Argon deinen Tag rettet!

[Jetzt starten →](https://raw.githubusercontent.com/argon-lab/argon/master/docs/QUICK_START.md) | [Live-Demo →](https://console.argonlabs.tech)

</div>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-21

---