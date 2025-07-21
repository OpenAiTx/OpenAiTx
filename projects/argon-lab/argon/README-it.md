<div align="right">
  <details>
    <summary >🌐 Lingua</summary>
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

# Argon - Macchina del Tempo per MongoDB 🚀

[![Build Status](https://github.com/argon-lab/argon/actions/workflows/ci.yml/badge.svg)](https://github.com/argon-lab/argon/actions/workflows/ci.yml)
[![Go Report](https://goreportcard.com/badge/github.com/argon-lab/argon)](https://goreportcard.com/report/github.com/argon-lab/argon)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

[![Homebrew](https://img.shields.io/badge/Homebrew-argonctl-orange?logo=homebrew)](https://github.com/argon-lab/homebrew-tap)
[![npm](https://img.shields.io/npm/v/argonctl?logo=npm&label=npm)](https://www.npmjs.com/package/argonctl)
[![PyPI](https://img.shields.io/pypi/v/argon-mongodb?logo=pypi&label=PyPI)](https://pypi.org/project/argon-mongodb/)

**Viaggia nel tempo nel tuo database MongoDB. Ramifica, ripristina ed esegui esperimenti senza paura.**

## Che cos'è Argon?

Argon offre a MongoDB superpoteri con **ramificazioni in stile Git** e **viaggi nel tempo**. Crea rami del database istantanei, ripristina a qualsiasi punto della cronologia e non perdere mai più i dati.

### 🎯 Vantaggi Principali

- **⚡ Rami Istantanei** - Clona l'intero database in 1ms (non ore)
- **⏰ Viaggi nel Tempo** - Interroga i tuoi dati da qualsiasi punto della cronologia con **220.000+ query/sec**
- **🔄 Ripristino Sicuro** - Visualizza in anteprima le modifiche prima del ripristino
- **💾 Nessun Costo di Storage** - I rami condividono dati in modo efficiente con compressione al 90%
- **🔌 Compatibile Plug-and-Play** - Funziona con il codice MongoDB esistente
- **🚀 Prestazioni Enterprise** - Query di viaggio nel tempo 26x più veloci dopo le ultime ottimizzazioni
- **✅ Test Completi** - Copertura di test estesa per garantire affidabilità
- **🗜️ Compressione Intelligente** - Compressione WAL automatica riduce lo storage dell'80-90%

## Demo Rapida

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
## Workflow in stile Git per MongoDB

### 🔄 **Passaggio 1: Importa ("git clone" per i database)**

```bash
# Bring your existing MongoDB into Argon
argon import preview --uri "mongodb://localhost:27017" --database myapp
argon import database --uri "mongodb://localhost:27017" --database myapp --project myapp
# ✅ Your existing data now has time travel capabilities!
```
### 🧪 **Passaggio 2: Branch ("git checkout -b")**

```bash
# Create branches for testing, staging, experiments
argon branches create staging --project myapp
argon branches create experiment-v2 --project myapp
# Full database copies created instantly 🚀
```
### 📊 **Passaggio 3: Viaggio nel tempo ("git log" per i dati)**

```bash
# See your data's history
argon time-travel info --project myapp --branch main
argon time-travel query --project myapp --branch main --lsn 1000
# Compare data across time like Git commits
```
### 🚨 **Fase 4: Ripristina ("git reset" per disastri)**

```bash
# "Someone deleted all users!"
argon restore reset --time "5 minutes ago"
# Crisis averted in seconds, not hours
```
## Come funziona

Argon intercetta le operazioni di MongoDB e le registra in un **Write-Ahead Log (WAL)**, consentendo:
- Branching istantaneo tramite puntatori di metadati
- Viaggi nel tempo riproducendo le operazioni
- Efficienza senza copia

Il tuo codice MongoDB esistente funziona senza modifiche: basta aggiungere `ENABLE_WAL=true`.

## Installazione


```bash
# CLI
brew install argon-lab/tap/argonctl    # macOS
npm install -g argonctl                 # Node.js
pip install argon-mongodb               # Python SDK

# From Source
git clone https://github.com/argon-lab/argon
cd argon/cli && go build -o argon
```
## Documentazione

- 📖 [Guida Rapida](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/QUICK_START.md)
- 🛠️ [Riferimento API](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/API_REFERENCE.md)
- 💡 [Casi d'Uso](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/USE_CASES.md)
- 🏗️ [Architettura](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/ARCHITECTURE.md)

## Comunità

- 🤝 [Guida della Comunità](https://raw.githubusercontent.com/argon-lab/argon/master/./COMMUNITY.md) - Partecipa!
- 📋 [Roadmap](https://raw.githubusercontent.com/argon-lab/argon/master/./ROADMAP.md) - Scopri cosa arriverà
- 🐛 [Segnala Problemi](https://github.com/argon-lab/argon/issues)
- 💬 [Discussioni](https://github.com/argon-lab/argon/discussions)
- 🏗️ [Contribuisci](https://raw.githubusercontent.com/argon-lab/argon/master/./CONTRIBUTING.md) - Aiuta a costruire Argon
- 📧 [Contatti](https://www.argonlabs.tech)

---

<div align="center">

**Dai a MongoDB una macchina del tempo. Non perdere mai più dati.**

⭐ **Metti una stella** se Argon ti ha salvato la giornata!

[Inizia →](https://raw.githubusercontent.com/argon-lab/argon/master/docs/QUICK_START.md) | [Demo Live →](https://console.argonlabs.tech)

</div>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-21

---