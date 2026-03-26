
<div align="right">
  <details>
    <summary >🌐 Язык</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# llama-github

[Подробная документация] https://deepwiki.com/JetXu-LLM/llama-github

[![PyPI version](https://badge.fury.io/py/llama-github.svg)](https://badge.fury.io/py/llama-github)
[![Downloads](https://static.pepy.tech/badge/Llama-github)](https://pepy.tech/project/Llama-github)
[![License](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)

Llama-github — это мощный инструмент, который помогает вам получать (на основе Agentic RAG) наиболее релевантные фрагменты кода, задачи и информацию о репозиториях из GitHub по вашим запросам, преобразуя их в ценный контекст знаний. Он расширяет возможности LLM-чатботов, AI-агентов и Auto-dev-агентов для решения сложных задач программирования. Будь вы разработчиком, ищущим быстрые решения, или инженером, внедряющим продвинутых Auto Dev AI агентов, llama-github делает этот процесс простым и эффективным.
Если вам нравится этот проект или вы считаете, что у него есть потенциал, пожалуйста, поставьте ему ⭐️. Ваша поддержка — наша главная мотивация!

## Архитектура
![Высокоуровневая архитектура](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/./docs/high_level_architecture.drawio.svg)

## Установка

```
pip install llama-github
```

Текущий поддерживаемый целевой рантайм: Python `3.10+`.

## Использование

Вот простой пример того, как использовать llama-github:

```python
from llama_github import GithubRAG

# Initialize GithubRAG with your credentials
github_rag = GithubRAG(
    github_access_token="your_github_access_token", 
    openai_api_key="your_openai_api_key", # Optional in Simple Mode
    jina_api_key="your_jina_api_key" # Optional - unless you want high concurrency production deployment (s.jina.ai API will be used in llama-github)
)

# Retrieve context for a coding question (simple_mode is default set to False)
query = "How to create a NumPy array in Python?"
contexts = github_rag.retrieve_context(
    query,
    # simple_mode = True
)

print(contexts[0]["url"])
print(contexts[0]["context"])
```
`retrieve_context()` возвращает список словарей контекста. Каждый элемент содержит как минимум `context` и `url`.

Для более продвинутого использования и примеров, пожалуйста, обратитесь к [документации](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/docs/usage.md). Также доступны работающие примеры с низкой стоимостью в [`examples/`](examples).

## Ключевые особенности

- **🔍 Интеллектуальный поиск на GitHub**: Используйте возможности llama-github для поиска максимально релевантных фрагментов кода, задач и информации о репозиториях на GitHub на основе пользовательских запросов. Наши продвинутые методы поиска обеспечивают быстрый и эффективный доступ к самой полезной информации.

- **⚡ Кеширование пула репозиториев**: В llama-github реализован инновационный механизм кеширования пула репозиториев. За счёт кеширования репозиториев (включая README, структуры, код и задачи) между потоками, llama-github значительно ускоряет поиск на GitHub и снижает расход токенов GitHub API.

- **🧠 Анализ вопросов на базе LLM**: Используйте современные языковые модели для анализа пользовательских вопросов и генерации эффективных стратегий и критериев поиска. Llama-github интеллектуально разбивает сложные запросы, чтобы вы получали наиболее релевантную информацию из огромной сети репозиториев GitHub.

- **📚 Комплексная генерация контекста**: Создавайте насыщенные, контекстуально релевантные ответы, бесшовно объединяя данные, полученные с GitHub, с возможностями рассуждения современных языковых моделей. Llama-github отлично справляется даже с самыми сложными и длинными вопросами, предоставляя подробные и содержательные ответы с обширным контекстом для поддержки ваших задач разработки.

- **🚀 Превосходная асинхронная обработка**: Llama-github изначально спроектирован для использования всех преимуществ асинхронного программирования. Благодаря тщательно реализованным асинхронным механизмам по всему коду, llama-github способен обрабатывать несколько запросов одновременно, значительно увеличивая общую производительность.

- **🔧 Гибкая интеграция LLM**: Легко интегрируйте llama-github с различными провайдерами LLM, моделями встраивания, моделями повторного ранжирования или внедрённой совместимой с LangChain чат-моделью, чтобы адаптировать возможности библиотеки под ваши нужды.

- **🔒 Надёжные варианты аутентификации**: Llama-github поддерживает как персональные токены доступа, так и аутентификацию через GitHub App, что предоставляет гибкость интеграции в различные сценарии разработки. Будь вы индивидуальным разработчиком или работаете в организации, llama-github обеспечит безопасные и надёжные механизмы аутентификации.

- **🛠️ Логирование и обработка ошибок**: Мы понимаем важность бесперебойной работы и удобной диагностики. Поэтому llama-github оснащён комплексной системой логирования и обработки ошибок. Получайте подробную информацию о работе библиотеки, быстро диагностируйте проблемы и поддерживайте стабильный и надёжный процесс разработки.

## 🤖 Попробуйте нашего помощника по AI-рецензированию PR: LlamaPReview

Если вам нравится llama-github, возможно, вас заинтересует наш AI-помощник для рецензирования PR на GitHub — LlamaPReview. Он создан для дополнения вашего рабочего процесса и повышения качества кода.

### Ключевые особенности LlamaPReview:
- 🚀 Установка в один клик, не требует настройки, полностью автоматический запуск
- 💯 Сейчас бесплатен — не требуется карта или платёжная информация
- 🧠 Автоматические AI-рецензии PR с глубоким пониманием кода
- 🌐 Поддержка нескольких языков программирования

**LlamaPReview использует расширенный поиск контекста и анализ на базе LLM от llama-github**, чтобы предоставлять интеллектуальные, контекстно-осведомлённые код-ревью. Это как если бы опытный разработчик, обладающий полным контекстом репозитория, автоматически просматривал каждый ваш PR!

👉 [Установить LlamaPReview сейчас](https://github.com/marketplace/llamapreview/) (Бесплатно)

Используя llama-github для получения контекста и LlamaPReview для код-ревью, вы создаёте мощную, улучшенную ИИ среду разработки.

## Видение и дорожная карта


### Видение

Наше видение — стать ключевым модулем в будущем решений для разработки на основе искусственного интеллекта, интегрируясь с GitHub для расширения возможностей LLM по автоматическому решению сложных задач программирования.

![Архитектура видения](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/./docs/vision.drawio.svg)

### Дорожная карта

Для просмотра исторической дорожной карты, пожалуйста, посетите [Видение и дорожная карта](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/VISION_AND_ROADMAP.md).

## Благодарности

Мы выражаем благодарность следующим проектам с открытым исходным кодом за их поддержку и вклад:

- **[LangChain](https://github.com/langchain-ai/langchain)**: За предоставление основного фреймворка, который обеспечивает возможности подсказок и обработки LLM в llama-github.
- **[Jina.ai](https://github.com/jina-ai/reader)**: За предоставление s.jina.ai API, а также открытых моделей ранжирования и эмбеддингов, повышающих точность и релевантность генерируемых контекстов в llama-github.

Их вклад был крайне важен для разработки llama-github, и мы рекомендуем ознакомиться с их проектами для поиска инновационных решений.

## Вклад

Мы приветствуем вклад в llama-github! Пожалуйста, ознакомьтесь с нашими [правилами участия](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/CONTRIBUTING.md) для получения дополнительной информации.

## Лицензия

Этот проект лицензирован на условиях лицензии Apache 2.0. Подробнее см. файл [LICENSE](LICENSE).

## Контакты

Если у вас есть вопросы, предложения или отзывы, пожалуйста, обращайтесь к нам по [email Jet Xu](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/mailto:Voldemort.xu@foxmail.com).

---

Спасибо, что выбрали llama-github! Мы надеемся, что эта библиотека улучшит ваш опыт разработки AI и поможет легко создавать мощные приложения.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-26

---