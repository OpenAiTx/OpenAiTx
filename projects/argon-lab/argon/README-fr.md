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

**Voyagez dans le temps avec votre base de données MongoDB. Branchez, restaurez et expérimentez sans crainte.**

## Qu'est-ce qu'Argon ?

Argon donne des super-pouvoirs à MongoDB grâce à des **branches façon Git** et au **voyage dans le temps**. Créez des branches de base de données instantanées, restaurez à n'importe quel moment du passé et ne perdez plus jamais de données.

### 🎯 Principaux avantages

- **⚡ Branches instantanées** - Clonez toute votre base de données en 1 ms (pas en heures)
- **⏰ Voyage dans le temps** - Interrogez vos données à n'importe quel moment de l'historique
- **🔄 Restauration sûre** - Prévisualisez les modifications avant de restaurer
- **💾 Aucun coût de stockage** - Les branches partagent efficacement les données
- **🔌 Compatible immédiatement** - Fonctionne avec le code MongoDB existant

## Démo rapide

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
## Cas d'utilisation réels

### 🚨 **Récupération après sinistre**

```bash
# "Someone deleted all users!"
argon restore reset --time "5 minutes ago"
# Crisis averted in seconds, not hours
```
### 🧪 **Tests sûrs**

```bash
# Test with real production data
argon branches create staging --from production
# Run risky migrations fearlessly
```
### 📊 **Analyse des données**

```bash
# Compare data across time
argon time-travel diff --from "last week" --to "today"
# See exactly what changed
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
- 💡 [Cas d'utilisation](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/USE_CASES.md)
- 🏗️ [Architecture](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/ARCHITECTURE.md)

## Communauté

- 🐛 [Signaler un problème](https://github.com/argon-lab/argon/issues)
- 💬 [Discussions](https://github.com/argon-lab/argon/discussions)
- 📧 [Contact](https://www.argonlabs.tech)

---

<div align="center">

**Donnez à votre MongoDB une machine à remonter le temps. Ne perdez plus jamais de données.**

⭐ **Ajoutez-nous en favori** si Argon vous sauve la mise !

[Commencer →](https://raw.githubusercontent.com/argon-lab/argon/master/docs/QUICK_START.md) | [Démo en direct →](https://console.argonlabs.tech)

</div>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---