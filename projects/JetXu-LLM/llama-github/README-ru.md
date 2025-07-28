
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
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# llama-github

[Детальная документация] https://deepwiki.com/JetXu-LLM/llama-github

[![PyPI version](https://badge.fury.io/py/llama-github.svg)](https://badge.fury.io/py/llama-github)
[![Downloads](https://static.pepy.tech/badge/Llama-github)](https://pepy.tech/project/Llama-github)
[![License](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)

Llama-github — это мощный инструмент, который помогает вам находить (на основе Agentic RAG) наиболее релевантные фрагменты кода, задачи и информацию о репозиториях с GitHub по вашим запросам, превращая их в ценный контекст знаний. Он расширяет возможности LLM-чат-ботов, AI-агентов и Auto-dev-агентов для решения сложных задач программирования. Независимо от того, являетесь ли вы разработчиком, ищущим быстрое решение, или инженером, внедряющим продвинутых Auto Dev AI-агентов, llama-github делает процесс быстрым и эффективным.

Если вам понравился этот проект или вы считаете, что у него есть потенциал, пожалуйста, поставьте ⭐️. Ваша поддержка — наша главная мотивация!

## Архитектура
![High Level Architecture](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/./docs/high_level_architecture.drawio.svg)

## Установка
```
pip install llama-github
```

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
context = github_rag.retrieve_context(
    query, # In professional mode, one query will take nearly 1 min to generate final contexts. You could set log level to INFO to monitor the retrieval progress
    # simple_mode = True
)

print(context)
```

Для более продвинутого использования и примеров, пожалуйста, обратитесь к [документации](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/docs/usage.md).

## Ключевые особенности

- **🔍 Интеллектуальный поиск по GitHub**: Используйте возможности llama-github для поиска наиболее релевантных фрагментов кода, задач и информации о репозиториях на GitHub на основе пользовательских запросов. Наши продвинутые методы поиска обеспечивают быстрый и эффективный доступ к самой важной информации.

- **⚡ Кэширование пула репозиториев**: Llama-github использует инновационный механизм кэширования пула репозиториев. Благодаря кэшированию репозиториев (включая README, структуру, код и задачи) между потоками, llama-github значительно ускоряет поиск по GitHub и минимизирует расход токенов GitHub API. Разворачивайте llama-github в многопоточных продакшн-средах уверенно, зная, что он будет работать оптимально и экономить ваши ресурсы.

- **🧠 Анализ вопросов на базе LLM**: Используйте современные языковые модели для анализа пользовательских вопросов и генерации наиболее эффективных стратегий и критериев поиска. Llama-github интеллектуально разбивает сложные запросы, обеспечивая получение самой релевантной информации из огромной сети репозиториев GitHub.

- **📚 Комплексное формирование контекста**: Генерируйте насыщенные, контекстно релевантные ответы, гармонично объединяя информацию из GitHub с возможностями рассуждения современных языковых моделей. Llama-github отлично справляется даже с самыми сложными и длинными вопросами, предоставляя развернутые и информативные ответы с глубоким контекстом для поддержки ваших задач разработки.

- **🚀 Высокая производительность за счет асинхронности**: Llama-github изначально разработан с учетом полного использования потенциала асинхронного программирования. Благодаря тщательно реализованным асинхронным механизмам по всему коду, llama-github может обрабатывать несколько запросов одновременно, значительно повышая общую производительность. Оцените разницу, когда llama-github эффективно справляется с большими объемами задач без ущерба для скорости и качества.

- **🔧 Гибкая интеграция LLM**: Просто интегрируйте llama-github с различными LLM-провайдерами, моделями эмбеддингов и моделями повторной оценки, чтобы адаптировать возможности библиотеки под ваши задачи. Наша расширяемая архитектура позволяет настраивать и улучшать функциональность llama-github, обеспечивая ее идеальную интеграцию в вашу среду разработки.

- **🔒 Надежные варианты аутентификации**: Llama-github поддерживает как персональные токены доступа, так и аутентификацию через GitHub App, предоставляя вам гибкость для интеграции в любые процессы разработки. Независимо от того, индивидуальный ли вы разработчик или работаете в организации, llama-github обеспечит надежную и безопасную аутентификацию.

- **🛠️ Логирование и обработка ошибок**: Мы понимаем важность бесперебойной работы и удобства отладки. Именно поэтому llama-github оснащен комплексными механизмами логирования и обработки ошибок. Получайте глубокое понимание работы библиотеки, быстро диагностируйте проблемы и поддерживайте стабильный и надежный рабочий процесс.

## 🤖 Попробуйте нашего AI-ассистента для обзора PR: LlamaPReview

Если вам полезен llama-github, вас также может заинтересовать наш AI-ассистент для ревью PR на GitHub — LlamaPReview. Он создан для дополнения вашего процесса разработки и повышения качества кода.

### Ключевые особенности LlamaPReview:
- 🚀 Установка в один клик, не требует настройки, полностью автоматическая работа
- 💯 В настоящее время бесплатен — не требуется карта или платежные данные
- 🧠 Автоматические ревью PR на базе AI с глубоким пониманием кода
- 🌐 Поддержка нескольких языков программирования

**LlamaPReview использует продвинутый поиск контекста и анализ на базе LLM из llama-github** для предоставления интеллектуальных, контекстно-осведомленных код-ревью. Это как если бы ваш PR проверял сеньор-разработчик, обладающий полным контекстом репозитория, автоматически!

👉 [Установить LlamaPReview сейчас](https://github.com/marketplace/llamapreview/) (Бесплатно)

Используя llama-github для поиска контекста и LlamaPReview для код-ревью, вы создаете мощную AI-усиленную среду разработки.

## Видение и дорожная карта

### Видение

Наше видение — стать ключевым модулем в будущем AI-решений для разработки, органично интегрированным с GitHub для поддержки LLM в автоматическом решении сложных задач программирования.

![Архитектура видения](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/./docs/vision.drawio.svg)

### Дорожная карта

Для подробного ознакомления с нашей дорожной картой проекта, пожалуйста, посетите [Project Roadmap](https://github.com/users/JetXu-LLM/projects/2).

## Благодарности

Мы выражаем признательность следующим open-source проектам за их поддержку и вклад:

- **[LangChain](https://github.com/langchain-ai/langchain)**: За предоставление базовой платформы, которая обеспечивает возможности промптинга и обработки LLM в llama-github.
- **[Jina.ai](https://github.com/jina-ai/reader)**: За предоставление s.jina.ai API, а также открытых моделей повторной оценки и эмбеддингов, повышающих точность и релевантность создаваемых контекстов в llama-github.

Их вклад был ключевым в развитии llama-github, и мы настоятельно рекомендуем ознакомиться с их проектами для поиска новых инновационных решений.

## Внесение вклада

Мы приветствуем ваш вклад в llama-github! Пожалуйста, ознакомьтесь с нашими [правилами участия](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/CONTRIBUTING.md) для получения дополнительной информации.

## Лицензия

Этот проект лицензируется на условиях лицензии Apache 2.0. Подробности смотрите в файле [LICENSE](LICENSE).

## Контакты

Если у вас есть вопросы, предложения или отзывы, пожалуйста, свяжитесь с нами по [email Jet Xu](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/mailto:Voldemort.xu@foxmail.com).

---

Спасибо, что выбрали llama-github! Мы надеемся, что эта библиотека улучшит ваш опыт разработки с AI и поможет вам с легкостью создавать мощные приложения.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-28

---