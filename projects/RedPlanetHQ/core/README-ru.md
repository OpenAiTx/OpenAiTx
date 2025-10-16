<div align="right">
  <details>
    <summary >🌐 Язык</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

<div align="center">
  <a href="https://core.heysol.ai">
    <img src="https://github.com/user-attachments/assets/89066cdd-204b-46c2-8ad4-4935f5ca9edd" width="200px" alt="Логотип CORE" />
  </a>

### CORE: Ваш личный слой памяти для AI-приложений

<p align="center">
    <a href="https://deepwiki.com/RedPlanetHQ/core">
        <img src="https://deepwiki.com/badge.svg" alt="Значок DeepWiki" />
    </a>
</p>
<p align="center">
    <a href="https://docs.heysol.ai/introduction"><b>Документация</b></a> •
    <a href="https://discord.gg/YGUZcvDjUa"><b>Discord</b></a>
</p>
</div>

## 🔥 Основные результаты исследований

Память CORE достигает **88.24%** средней точности на датасете Locomo по всем задачам рассуждения, значительно превосходя другие поставщики памяти. Подробнее читайте в этом [блоге](https://blog.heysol.ai/core-build-memory-knowledge-graph-for-individuals-and-achieved-sota-on-locomo-benchmark/).

<img width="6048" height="3428" alt="benchmark" src="https://github.com/user-attachments/assets/2e5fdac5-02ed-4d00-9312-c21d09974e1f" />
(1) Вопросы с одним переходом требуют ответа на основе одной сессии; (2) Многопереходные вопросы требуют синтеза информации из нескольких разных сессий; (3) Вопросы по знаниям открытого домена могут быть решены интеграцией предоставленной спикером информации с внешними знаниями, такими как здравый смысл или факты о мире; (4) Временные вопросы требуют рассуждений по времени и фиксации временных данных внутри разговора;

## Обзор

**Проблема** 

Разработчики теряют время, вновь объясняя контекст ИИ-инструментам. Достигли лимита токенов в Claude? Начинайте заново и теряете всё. Перешли с ChatGPT/Claude на Cursor? Опять объясняете контекст. Ваши разговоры, решения и идеи исчезают между сессиями. С каждым новым ИИ-инструментом стоимость переключения контекста растёт.

**Решение** - **CORE** (**Contextual Observation & Recall Engine**)

CORE — это открытый и единый слой постоянной памяти для всех ваших ИИ-инструментов. Ваш контекст переходит с Cursor на Claude, с ChatGPT на Claude Code. Одна база знаний запоминает, кто что сказал, когда и почему. Подключитесь один раз — помните везде. Перестаньте управлять контекстом и начните создавать.

## 🚀 Самостоятельный хостинг CORE
Хотите запустить CORE на собственной инфраструктуре? Самостоятельный хостинг даёт вам полный контроль над данными и развертыванием.

**Требования**:

- Установлены Docker (20.10.0+) и Docker Compose (2.20.0+)
- Ключ OpenAI API

> **Примечание по Open-Source моделям:** Мы тестировали OSS-решения, такие как Ollama и GPT-модели, но их качество извлечения фактов и построения графа оказалось недостаточным. Мы активно ищем новые варианты.

### Установка

1. Клонируйте репозиторий:
```
git clone https://github.com/RedPlanetHQ/core.git
cd core
```
2. Настройте переменные окружения в `core/.env`:
```
OPENAI_API_KEY=your_openai_api_key
```
3. Запустите службу
```
docker-compose up -d
```
После развертывания вы можете настроить ваших AI-провайдеров (OpenAI, Anthropic) и начать строить свой граф памяти.

👉 [Просмотреть полный гид по самостоятельному размещению](https://docs.heysol.ai/self-hosting/docker)

Примечание: Мы пробовали использовать open-source модели, такие как Ollama или GPT OSS, но генерация фактов была некачественной, мы все еще ищем способы улучшить это, после чего будет поддержка OSS моделей.

## 🚀 CORE Cloud
**Постройте свой единый граф памяти за 5 минут:**

Не хотите управлять инфраструктурой? CORE Cloud позволяет мгновенно создать вашу личную систему памяти — без настроек, без серверов, просто память, которая работает.

1. **Зарегистрируйтесь** на [core.heysol.ai](https://core.heysol.ai) и создайте свой аккаунт
2. **Визуализируйте свой граф памяти** и посмотрите, как CORE автоматически формирует связи между фактами
3. **Проверьте систему** — задайте вопрос «Что ты знаешь обо мне?» в разделе беседы
4. Подключите свои инструменты:
   - [Claude](https://docs.heysol.ai/providers/claude) и [Cursor](https://docs.heysol.ai/providers/cursor) — программирование с контекстом
   - [CLaude Code CLI](https://docs.heysol.ai/providers/claude-code) и [Codex CLI](https://docs.heysol.ai/providers/codex) — программирование в терминале с памятью
   - [Добавить расширение для браузера](https://docs.heysol.ai/providers/browser-extension) — перенесите свою память на любой сайт
   - [Linear](https://docs.heysol.ai/integrations/linear), [Github](https://docs.heysol.ai/integrations/github) — автоматическое добавление контекста проекта

## 🧩 Ключевые возможности

### 🧠 **Единая, переносимая память**: 
Добавляйте и вспоминайте свою память через **Cursor, Windsurf, Claude Desktop, Claude Code, Gemini CLI, AWS's Kiro, VS Code и Roo Code** с помощью MCP

![core-claude](https://github.com/user-attachments/assets/56c98288-ee87-4cd0-8b02-860aca1c7f9a)


### 🕸️ **Темпоральный + Реализованный граф знаний**: 

Запоминайте историю каждого факта — отслеживайте, кто что сказал, когда и почему с богатыми связями и полной провенансом, а не просто плоским хранением

![core-memory-graph](https://github.com/user-attachments/assets/5d1ee659-d519-4624-85d1-e0497cbdd60a)


### 🌐 **Расширение для браузера**: 

Сохраняйте беседы и контент из ChatGPT, Grok, Gemini, Twitter, YouTube, блогов и любых веб-страниц прямо в свою память CORE.


**Как использовать расширение**
1. [Скачайте расширение](https://chromewebstore.google.com/detail/core-extension/cglndoindnhdbfcbijikibfjoholdjcc) из Интернет-магазина Chrome.
2. Войдите в [панель CORE](https://core.heysol.ai)
   - Перейдите в Настройки (нижний левый угол)
   - Откройте API Key → Сгенерировать новый ключ → Назовите его “extension.”
3. Откройте расширение, вставьте ваш API-ключ и сохраните.

https://github.com/user-attachments/assets/6e629834-1b9d-4fe6-ae58-a9068986036a


### 💬 **Чат с памятью**: 
Задавайте вопросы типа "Каковы мои предпочтения в письме?" и мгновенно получайте инсайты из подключённых знаний

![chat-with-memory](https://github.com/user-attachments/assets/d798802f-bd51-4daf-b2b5-46de7d206f66)


### ⚡ **Автосинхронизация из приложений**:

Автоматически фиксируйте релевантный контекст из Linear, Slack, Notion, GitHub и других подключённых приложений в память CORE

📖 **[Посмотреть все интеграции](https://raw.githubusercontent.com/RedPlanetHQ/core/main/./integrations/README.md)** — Полный список поддерживаемых сервисов и их возможностей

![core-slack](https://github.com/user-attachments/assets/d5fefe38-221e-4076-8a44-8ed673960f03)


### 🔗 **MCP Integration Hub**: 

Подключите Linear, Slack, GitHub, Notion один раз к CORE — затем используйте все их инструменты в Claude, Cursor или любом MCP-клиенте через единый URL


![core-linear-claude](https://github.com/user-attachments/assets/7d59d92b-8c56-4745-a7ab-9a3c0341aa32)



## Как CORE создаёт память

<img width="12885" height="3048" alt="memory-ingest-diagram" src="https://github.com/user-attachments/assets/c51679de-8260-4bee-bebf-aff32c6b8e13" />

Конвейер сбора данных CORE состоит из четырёх фаз, предназначенных для фиксации изменяющегося контекста:

1. **Нормализация**: Связывает новую информацию с недавним контекстом, разбивает длинные документы на связные фрагменты с сохранением перекрестных ссылок и стандартизирует термины, чтобы к моменту извлечения знаний CORE работал с чистым, контекстуализированным входом вместо неструктурированного текста.
2. **Извлечение**: Извлекает смысл из нормализованного текста, выявляя сущности (люди, инструменты, проекты, концепции), превращая их в утверждения с контекстом, источником и временем, и отображая отношения. Например, “Мы написали CORE на Next.js” превращается в: Сущности (Core, Next.js), Утверждение (CORE был разработан с использованием Next.js), и Отношение (был разработан с использованием).
3. **Разрешение**: Обнаруживает противоречия, отслеживает изменения предпочтений и сохраняет несколько точек зрения с указанием происхождения вместо их перезаписи, чтобы память отражала весь ваш путь, а не только последний снимок.
4. **Интеграция графа**: Связывает сущности, утверждения и эпизоды в временной граф знаний, который связывает факты с их контекстом и историей, превращая разрозненные данные в живую сеть знаний, которую агенты действительно могут использовать.

Результат: Вместо плоской базы данных CORE дает вам память, которая растет и меняется вместе с вами — сохраняя контекст, эволюцию и владение, чтобы агенты могли реально ее использовать.


![memory-ingest-eg](https://github.com/user-attachments/assets/1d0a8007-153a-4842-9586-f6f4de43e647)

## Как CORE извлекает из памяти

<img width="10610" height="3454" alt="memory-search-diagram" src="https://github.com/user-attachments/assets/3541893e-f7c9-42b9-8fad-6dabf138dbeb" />

Когда вы задаете вопрос CORE, он не просто ищет текст — он исследует весь ваш граф знаний, чтобы найти самые полезные ответы.

1. **Поиск**: CORE просматривает память одновременно с разных сторон — поиск по ключевым словам для точных совпадений, семантический поиск для связанных идей даже при иной формулировке, и обход графа для следования связям между связанными концепциями.
2. **Переупорядочивание**: Полученные результаты сортируются так, чтобы выделить самые релевантные и разнообразные, гарантируя, что вы увидите не только очевидные совпадения, но и более глубокие связи.
3. **Фильтрация**: CORE применяет интеллектуальные фильтры по времени, надежности и силе связей, чтобы отображалась только самая значимая информация.
4. **Вывод**: Вы получаете как факты (четкие утверждения), так и эпизоды (оригинальный контекст, из которого они взяты), чтобы восстановление всегда было привязано к контексту, времени и истории.

Результат: CORE не просто вспоминает факты — он возвращает их в правильном контексте, времени и истории, чтобы агенты реагировали так, как вы бы это запомнили.

## Документация

Изучайте нашу документацию, чтобы максимально эффективно использовать CORE

- [Основные понятия](https://docs.heysol.ai/concepts/memory_graph)
- [Самостоятельный хостинг](https://docs.heysol.ai/self-hosting/overview)
- [Подключение Core MCP к Claude](https://docs.heysol.ai/providers/claude)
- [Подключение Core MCP к Cursor](https://docs.heysol.ai/providers/cursor)
- [Подключение Core MCP к Claude Code](https://docs.heysol.ai/providers/claude-code)
- [Подключение Core MCP к Codex](https://docs.heysol.ai/providers/codex) 

- [Основные понятия](https://docs.heysol.ai/overview)
- [API справочник](https://docs.heysol.ai/api-reference/get-user-profile)

## 🔒 Безопасность

CORE серьезно относится к безопасности. Мы применяем отраслевые стандарты защиты данных:

- **Шифрование данных**: Все данные при передаче (TLS 1.3) и на хранении (AES-256)
- **Аутентификация**: OAuth 2.0 и аутентификация через магическую ссылку
- **Контроль доступа**: Изоляция по рабочим пространствам и разрешения на основе ролей
- **Сообщение о уязвимостях**: Пожалуйста, сообщайте о проблемах безопасности на harshith@poozle.dev

Для получения подробной информации о безопасности смотрите нашу [Политику безопасности](https://raw.githubusercontent.com/RedPlanetHQ/core/main/SECURITY.md).

## 🧑‍💻 Поддержка

Есть вопросы или отзывы? Мы готовы помочь:

- Discord: [Присоединиться к каналу core-support](https://discord.gg/YGUZcvDjUa)
- Документация: [docs.heysol.ai](https://docs.heysol.ai)
- Email: manik@poozle.dev

## Рекомендации по использованию

**Хранить:**

- История переписки
- Настройки пользователя
- Контекст задачи
- Справочные материалы

**Не хранить:**

- Конфиденциальные данные (ПДн)
- Учетные данные
- Системные журналы
- Временные данные

## 👥 Участники

<a href="https://github.com/RedPlanetHQ/core/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=RedPlanetHQ/core" />
</a>















---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-16

---