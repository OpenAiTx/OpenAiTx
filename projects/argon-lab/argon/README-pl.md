<div align="right">
  <details>
    <summary >🌐 Język</summary>
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

# Argon - Maszyna Czasu dla MongoDB 🚀

[![Build Status](https://github.com/argon-lab/argon/actions/workflows/ci.yml/badge.svg)](https://github.com/argon-lab/argon/actions/workflows/ci.yml)
[![Go Report](https://goreportcard.com/badge/github.com/argon-lab/argon)](https://goreportcard.com/report/github.com/argon-lab/argon)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

[![Homebrew](https://img.shields.io/badge/Homebrew-argonctl-orange?logo=homebrew)](https://github.com/argon-lab/homebrew-tap)
[![npm](https://img.shields.io/npm/v/argonctl?logo=npm&label=npm)](https://www.npmjs.com/package/argonctl)
[![PyPI](https://img.shields.io/pypi/v/argon-mongodb?logo=pypi&label=PyPI)](https://pypi.org/project/argon-mongodb/)

**Podróżuj w czasie w swojej bazie MongoDB. Twórz gałęzie, przywracaj i eksperymentuj bez obaw.**

## Czym jest Argon?

Argon daje MongoDB supermoce dzięki **gałęziom jak w Gicie** i **podróżom w czasie**. Twórz natychmiastowe gałęzie bazy danych, przywracaj do dowolnego punktu w historii i nigdy więcej nie trać danych.

### 🎯 Kluczowe korzyści

- **⚡ Natychmiastowe gałęzie** – Sklonuj całą bazę danych w 1 ms (nie w godziny)
- **⏰ Podróże w czasie** – Zapytaj o dane z dowolnego punktu w historii
- **🔄 Bezpieczne przywracanie** – Podglądaj zmiany przed przywróceniem
- **💾 Zerowy koszt przechowywania** – Gałęzie efektywnie współdzielą dane
- **🔌 Kompatybilność plug-and-play** – Działa z istniejącym kodem MongoDB

## Szybka demonstracja

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
## Przypadki użycia w rzeczywistych warunkach

### 🚨 **Odzyskiwanie po awarii**

```bash
# "Someone deleted all users!"
argon restore reset --time "5 minutes ago"
# Crisis averted in seconds, not hours
```
### 🧪 **Bezpieczne testowanie**

```bash
# Test with real production data
argon branches create staging --from production
# Run risky migrations fearlessly
```
### 📊 **Analiza danych**

```bash
# Compare data across time
argon time-travel diff --from "last week" --to "today"
# See exactly what changed
```
## Jak to działa

Argon przechwytuje operacje MongoDB i zapisuje je w **dzienniku zapisu uprzedniego (WAL)**, umożliwiając:
- Natychmiastowe rozgałęzianie poprzez wskaźniki metadanych
- Podróż w czasie przez odtwarzanie operacji
- Wydajność bez kopiowania

Twój istniejący kod MongoDB działa bez zmian – wystarczy dodać `ENABLE_WAL=true`.

## Instalacja


```bash
# CLI
brew install argon-lab/tap/argonctl    # macOS
npm install -g argonctl                 # Node.js
pip install argon-mongodb               # Python SDK

# From Source
git clone https://github.com/argon-lab/argon
cd argon/cli && go build -o argon
```
## Dokumentacja

- 📖 [Przewodnik Szybkiego Startu](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/QUICK_START.md)
- 🛠️ [Dokumentacja API](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/API_REFERENCE.md)
- 💡 [Przypadki użycia](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/USE_CASES.md)
- 🏗️ [Architektura](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/ARCHITECTURE.md)

## Społeczność

- 🐛 [Zgłoś problemy](https://github.com/argon-lab/argon/issues)
- 💬 [Dyskusje](https://github.com/argon-lab/argon/discussions)
- 📧 [Kontakt](https://www.argonlabs.tech)

---

<div align="center">

**Daj swojej bazie MongoDB wehikuł czasu. Już nigdy nie stracisz danych.**

⭐ **Dodaj nas do ulubionych**, jeśli Argon uratował Ci dzień!

[Zacznij tutaj →](https://raw.githubusercontent.com/argon-lab/argon/master/docs/QUICK_START.md) | [Demo na żywo →](https://console.argonlabs.tech)

</div>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---