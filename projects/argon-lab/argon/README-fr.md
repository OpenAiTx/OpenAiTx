<div align="right">
  <details>
    <summary >🌐 Langue</summary>
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

# Argon - Machine à remonter le temps MongoDB 🚀

[![Build Status](https://github.com/argon-lab/argon/actions/workflows/ci.yml/badge.svg)](https://github.com/argon-lab/argon/actions/workflows/ci.yml)
[![Go Report](https://goreportcard.com/badge/github.com/argon-lab/argon)](https://goreportcard.com/report/github.com/argon-lab/argon)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

[![Homebrew](https://img.shields.io/badge/Homebrew-argonctl-orange?logo=homebrew)](https://github.com/argon-lab/homebrew-tap)
[![npm](https://img.shields.io/npm/v/argonctl?logo=npm&label=npm)](https://www.npmjs.com/package/argonctl)
[![PyPI](https://img.shields.io/pypi/v/argon-mongodb?logo=pypi&label=PyPI)](https://pypi.org/project/argon-mongodb/)

**Voyagez dans le temps avec votre base de données MongoDB. Bifurquez, restaurez et expérimentez sans crainte.**

## Qu'est-ce qu'Argon ?

Argon dote MongoDB de super-pouvoirs grâce à la **bifurcation façon Git** et au **voyage dans le temps**. Créez instantanément des branches de base de données, restaurez à n'importe quel moment de l'historique, et ne perdez plus jamais vos données.

### 🎯 Principaux avantages

- **⚡ Branches instantanées** - Clonez toute votre base de données en 1ms (pas en heures)
- **⏰ Voyage dans le temps** - Interrogez vos données à n'importe quel moment du passé avec **220 000+ requêtes/sec**
- **🔄 Restauration sécurisée** - Prévisualisez les modifications avant de restaurer
- **💾 Coût de stockage nul** - Les branches partagent efficacement les données avec 90% de compression
- **🔌 Compatible plug-and-play** - Fonctionne avec le code MongoDB existant
- **🚀 Performance d'entreprise** - Requêtes de voyage dans le temps 26x plus rapides après les dernières optimisations
- **✅ Tests complets** - Couverture de tests étendue assurant la fiabilité
- **🗜️ Compression intelligente** - La compression automatique du WAL réduit le stockage de 80 à 90 %

## Démo rapide

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
## Flux de travail type Git pour MongoDB

### 🔄 **Étape 1 : Importer ("git clone" pour les bases de données)**

```bash
# Bring your existing MongoDB into Argon
argon import preview --uri "mongodb://localhost:27017" --database myapp
argon import database --uri "mongodb://localhost:27017" --database myapp --project myapp
# ✅ Your existing data now has time travel capabilities!
```
### 🧪 **Étape 2 : Branche ("git checkout -b")**

```bash
# Create branches for testing, staging, experiments
argon branches create staging --project myapp
argon branches create experiment-v2 --project myapp
# Full database copies created instantly 🚀
```
### 📊 **Étape 3 : Voyage dans le temps ("git log" pour les données)**

```bash
# See your data's history
argon time-travel info --project myapp --branch main
argon time-travel query --project myapp --branch main --lsn 1000
# Compare data across time like Git commits
```
### 🚨 **Étape 4 : Restaurer ("git reset" en cas de catastrophe)**

```bash
# "Someone deleted all users!"
argon restore reset --time "5 minutes ago"
# Crisis averted in seconds, not hours
```
## Fonctionnement

Argon intercepte les opérations MongoDB et les enregistre dans un **journal d’écriture anticipée (WAL)**, permettant :
- Création instantanée de branches via des pointeurs de métadonnées
- Voyage dans le temps en rejouant les opérations
- Efficacité sans copie

Votre code MongoDB existant fonctionne sans modification - il suffit d’ajouter `ENABLE_WAL=true`.

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
## Documentation

- 📖 [Guide de démarrage rapide](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/QUICK_START.md)
- 🛠️ [Référence API](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/API_REFERENCE.md)
- 💡 [Cas d’utilisation](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/USE_CASES.md)
- 🏗️ [Architecture](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/ARCHITECTURE.md)

## Communauté

- 🤝 [Guide de la communauté](https://raw.githubusercontent.com/argon-lab/argon/master/./COMMUNITY.md) - Participez !
- 📋 [Feuille de route](https://raw.githubusercontent.com/argon-lab/argon/master/./ROADMAP.md) - Découvrez ce qui arrive
- 🐛 [Signaler un problème](https://github.com/argon-lab/argon/issues)
- 💬 [Discussions](https://github.com/argon-lab/argon/discussions)
- 🏗️ [Contribuer](https://raw.githubusercontent.com/argon-lab/argon/master/./CONTRIBUTING.md) - Aidez à construire Argon
- 📧 [Contact](https://www.argonlabs.tech)

---

<div align="center">

**Donnez à votre MongoDB une machine à remonter le temps. Ne perdez plus jamais de données.**

⭐ **Ajoutez-nous en favori** si Argon vous a sauvé la mise !

[Commencer →](https://raw.githubusercontent.com/argon-lab/argon/master/docs/QUICK_START.md) | [Démo en direct →](https://console.argonlabs.tech)

</div>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-21

---