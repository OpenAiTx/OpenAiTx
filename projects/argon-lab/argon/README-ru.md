<div align="right">
  <details>
    <summary >🌐 Язык</summary>
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

# Argon - Машина времени для MongoDB 🚀

[![Build Status](https://github.com/argon-lab/argon/actions/workflows/ci.yml/badge.svg)](https://github.com/argon-lab/argon/actions/workflows/ci.yml)
[![Go Report](https://goreportcard.com/badge/github.com/argon-lab/argon)](https://goreportcard.com/report/github.com/argon-lab/argon)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

[![Homebrew](https://img.shields.io/badge/Homebrew-argonctl-orange?logo=homebrew)](https://github.com/argon-lab/homebrew-tap)
[![npm](https://img.shields.io/npm/v/argonctl?logo=npm&label=npm)](https://www.npmjs.com/package/argonctl)
[![PyPI](https://img.shields.io/pypi/v/argon-mongodb?logo=pypi&label=PyPI)](https://pypi.org/project/argon-mongodb/)

**Путешествуйте во времени по вашей базе данных MongoDB. Ветвитесь, восстанавливайте и экспериментируйте без страха.**

## Что такое Argon?

Argon наделяет MongoDB суперспособностями с помощью **ветвления в стиле Git** и **путешествий во времени**. Создавайте мгновенные ветки базы данных, восстанавливайтесь в любой момент истории и больше никогда не теряйте данные.

### 🎯 Ключевые преимущества

- **⚡ Мгновенные ветки** — Клонируйте всю вашу базу данных за 1 мс (а не часы)
- **⏰ Путешествия во времени** — Запрашивайте данные в любой момент истории с **220 000+ запросов/сек**
- **🔄 Безопасное восстановление** — Предварительный просмотр изменений перед восстановлением
- **💾 Нулевая стоимость хранения** — Ветки эффективно разделяют данные с 90% сжатием
- **🔌 Совместимость без изменений** — Работает с существующим кодом MongoDB
- **🚀 Корпоративная производительность** — В 26 раз быстрее запросы во времени после последних оптимизаций
- **✅ Комплексное тестирование** — Обширное покрытие тестами для надежности
- **🗜️ Умное сжатие** — Автоматическое сжатие WAL сокращает хранение на 80-90%

## Быстрая демонстрация

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
## Git-подобный рабочий процесс для MongoDB

### 🔄 **Шаг 1: Импорт (аналог "git clone" для баз данных)**

```bash
# Bring your existing MongoDB into Argon
argon import preview --uri "mongodb://localhost:27017" --database myapp
argon import database --uri "mongodb://localhost:27017" --database myapp --project myapp
# ✅ Your existing data now has time travel capabilities!
```
### 🧪 **Шаг 2: Ветка ("git checkout -b")**

```bash
# Create branches for testing, staging, experiments
argon branches create staging --project myapp
argon branches create experiment-v2 --project myapp
# Full database copies created instantly 🚀
```
### 📊 **Шаг 3: Путешествие во времени ("git log" для данных)**

```bash
# See your data's history
argon time-travel info --project myapp --branch main
argon time-travel query --project myapp --branch main --lsn 1000
# Compare data across time like Git commits
```
### 🚨 **Шаг 4: Восстановление (git reset для катастроф)**

```bash
# "Someone deleted all users!"
argon restore reset --time "5 minutes ago"
# Crisis averted in seconds, not hours
```
## Как это работает

Argon перехватывает операции MongoDB и записывает их в **журнал предзаписи (WAL)**, обеспечивая:
- Мгновенное ветвление с помощью указателей метаданных
- Путешествия во времени путем воспроизведения операций
- Эффективность без копирования

Ваш существующий код MongoDB работает без изменений — просто добавьте `ENABLE_WAL=true`.

## Установка


```bash
# CLI
brew install argon-lab/tap/argonctl    # macOS
npm install -g argonctl                 # Node.js
pip install argon-mongodb               # Python SDK

# From Source
git clone https://github.com/argon-lab/argon
cd argon/cli && go build -o argon
```
## Документация

- 📖 [Краткое руководство по запуску](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/QUICK_START.md)
- 🛠️ [Справочник API](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/API_REFERENCE.md)
- 💡 [Примеры использования](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/USE_CASES.md)
- 🏗️ [Архитектура](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/ARCHITECTURE.md)

## Сообщество

- 🤝 [Руководство для сообщества](https://raw.githubusercontent.com/argon-lab/argon/master/./COMMUNITY.md) — Присоединяйтесь!
- 📋 [Дорожная карта](https://raw.githubusercontent.com/argon-lab/argon/master/./ROADMAP.md) — Узнайте о планах
- 🐛 [Сообщить о проблеме](https://github.com/argon-lab/argon/issues)
- 💬 [Обсуждения](https://github.com/argon-lab/argon/discussions)
- 🏗️ [Внесите свой вклад](https://raw.githubusercontent.com/argon-lab/argon/master/./CONTRIBUTING.md) — Помогите развивать Argon
- 📧 [Контакты](https://www.argonlabs.tech)

---

<div align="center">

**Дайте вашей MongoDB машину времени. Больше никогда не теряйте данные.**

⭐ **Поставьте звезду**, если Argon помог вам!

[Начать →](https://raw.githubusercontent.com/argon-lab/argon/master/docs/QUICK_START.md) | [Демо-версия →](https://console.argonlabs.tech)

</div>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-21

---