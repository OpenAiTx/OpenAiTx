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

# Argon - MongoDB Wehikuł Czasu 🚀

[![Build Status](https://github.com/argon-lab/argon/actions/workflows/ci.yml/badge.svg)](https://github.com/argon-lab/argon/actions/workflows/ci.yml)
[![Go Report](https://goreportcard.com/badge/github.com/argon-lab/argon)](https://goreportcard.com/report/github.com/argon-lab/argon)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

[![Homebrew](https://img.shields.io/badge/Homebrew-argonctl-orange?logo=homebrew)](https://github.com/argon-lab/homebrew-tap)
[![npm](https://img.shields.io/npm/v/argonctl?logo=npm&label=npm)](https://www.npmjs.com/package/argonctl)
[![PyPI](https://img.shields.io/pypi/v/argon-mongodb?logo=pypi&label=PyPI)](https://pypi.org/project/argon-mongodb/)

**Podróżuj w czasie w swojej bazie danych MongoDB. Twórz gałęzie, przywracaj i eksperymentuj bez obaw.**

## Czym jest Argon?

Argon daje MongoDB supermoce dzięki **rozgałęzianiu podobnemu do Gita** oraz **podróżom w czasie**. Twórz natychmiastowe gałęzie bazy danych, przywracaj do dowolnego punktu w historii i nigdy więcej nie trać danych.

### 🎯 Kluczowe Zalety

- **⚡ Natychmiastowe Gałęzie** - Sklonuj całą bazę danych w 1 ms (zamiast godzin)
- **⏰ Podróże w Czasie** - Zapytaj dane z dowolnego punktu w historii z wydajnością **ponad 220 000 zapytań/sek**
- **🔄 Bezpieczne Przywracanie** - Podgląd zmian przed przywróceniem
- **💾 Brak Kosztów Przechowywania** - Gałęzie współdzielą dane z 90% kompresją
- **🔌 Kompatybilność Plug-and-Play** - Działa z istniejącym kodem MongoDB
- **🚀 Wydajność Enterprise** - 26x szybsze zapytania podróży w czasie po najnowszych optymalizacjach
- **✅ Kompleksowe Testy** - Szeroki zakres testów zapewniających niezawodność
- **🗜️ Inteligentna Kompresja** - Automatyczna kompresja WAL zmniejsza zużycie dysku o 80-90%

## Szybka Demonstracja

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
## Przepływ pracy podobny do Git dla MongoDB

### 🔄 **Krok 1: Import (odpowiednik "git clone" dla baz danych)**

```bash
# Bring your existing MongoDB into Argon
argon import preview --uri "mongodb://localhost:27017" --database myapp
argon import database --uri "mongodb://localhost:27017" --database myapp --project myapp
# ✅ Your existing data now has time travel capabilities!
```
### 🧪 **Krok 2: Utworzenie gałęzi ("git checkout -b")**

```bash
# Create branches for testing, staging, experiments
argon branches create staging --project myapp
argon branches create experiment-v2 --project myapp
# Full database copies created instantly 🚀
```
### 📊 **Krok 3: Podróż w czasie ("git log" dla danych)**

```bash
# See your data's history
argon time-travel info --project myapp --branch main
argon time-travel query --project myapp --branch main --lsn 1000
# Compare data across time like Git commits
```
### 🚨 **Krok 4: Przywracanie ("git reset" w przypadku katastrof)**

```bash
# "Someone deleted all users!"
argon restore reset --time "5 minutes ago"
# Crisis averted in seconds, not hours
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
- 🛠️ [Referencja API](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/API_REFERENCE.md)
- 💡 [Przypadki użycia](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/USE_CASES.md)
- 🏗️ [Architektura](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/ARCHITECTURE.md)

## Społeczność

- 🤝 [Przewodnik społeczności](https://raw.githubusercontent.com/argon-lab/argon/master/./COMMUNITY.md) - Dołącz do nas!
- 📋 [Mapa drogowa](https://raw.githubusercontent.com/argon-lab/argon/master/./ROADMAP.md) - Zobacz, co nadchodzi
- 🐛 [Zgłoś błędy](https://github.com/argon-lab/argon/issues)
- 💬 [Dyskusje](https://github.com/argon-lab/argon/discussions)
- 🏗️ [Współtworzenie](https://raw.githubusercontent.com/argon-lab/argon/master/./CONTRIBUTING.md) - Pomóż rozwijać Argon
- 📧 [Kontakt](https://www.argonlabs.tech)

---

<div align="center">

**Daj swojej bazie MongoDB wehikuł czasu. Już nigdy nie utracisz danych.**

⭐ **Oznacz nas gwiazdką**, jeśli Argon uratował Twój dzień!

[Zaczynamy →](https://raw.githubusercontent.com/argon-lab/argon/master/docs/QUICK_START.md) | [Demo na żywo →](https://console.argonlabs.tech)

</div>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-21

---