<picture>
  <source media="(prefers-color-scheme: light)" srcset="docs/static/img/logo-dark.svg">
  <source media="(prefers-color-scheme: dark)" srcset="docs/static/img/logo-light.svg">
  <img alt="Логотип LangChain" src="docs/static/img/logo-dark.svg" width="80%">
</picture>

<div>
<br>
</div>

[![Примечания к релизу](https://img.shields.io/github/release/langchain-ai/langchain?style=flat-square)](https://github.com/langchain-ai/langchain/releases)
[![CI](https://github.com/langchain-ai/langchain/actions/workflows/check_diffs.yml/badge.svg)](https://github.com/langchain-ai/langchain/actions/workflows/check_diffs.yml)
[![PyPI - Лицензия](https://img.shields.io/pypi/l/langchain-core?style=flat-square)](https://opensource.org/licenses/MIT)
[![PyPI - Загрузки](https://img.shields.io/pypi/dm/langchain-core?style=flat-square)](https://pypistats.org/packages/langchain-core)
[![График звезд на GitHub](https://img.shields.io/github/stars/langchain-ai/langchain?style=flat-square)](https://star-history.com/#langchain-ai/langchain)
[![Открытые задачи](https://img.shields.io/github/issues-raw/langchain-ai/langchain?style=flat-square)](https://github.com/langchain-ai/langchain/issues)
[![Открыть в Dev Containers](https://img.shields.io/static/v1?label=Dev%20Containers&message=Open&color=blue&logo=visualstudiocode&style=flat-square)](https://vscode.dev/redirect?url=vscode://ms-vscode-remote.remote-containers/cloneInVolume?url=https://github.com/langchain-ai/langchain)
[<img src="https://github.com/codespaces/badge.svg" title="Открыть в Github Codespace" width="150" height="20">](https://codespaces.new/langchain-ai/langchain)
[![Twitter](https://img.shields.io/twitter/url/https/twitter.com/langchainai.svg?style=social&label=Follow%20%40LangChainAI)](https://twitter.com/langchainai)
[![CodSpeed Badge](https://img.shields.io/endpoint?url=https://codspeed.io/badge.json)](https://codspeed.io/langchain-ai/langchain)

> [!ПРИМЕЧАНИЕ]
> Ищете библиотеку JS/TS? Ознакомьтесь с [LangChain.js](https://github.com/langchain-ai/langchainjs).

LangChain — это фреймворк для создания приложений на основе LLM. Он помогает объединять взаимосвязанные компоненты и сторонние интеграции, чтобы упростить разработку ИИ-приложений, а также обеспечивает защиту ваших решений на будущее по мере развития базовых технологий.

```bash
pip install -U langchain
```

Чтобы узнать больше о LangChain, ознакомьтесь с
[документацией](https://python.langchain.com/docs/introduction/). Если вы ищете более
гибкую настройку или оркестрацию агентов, обратите внимание на
[LangGraph](https://langchain-ai.github.io/langgraph/) — наш фреймворк для построения управляемых рабочих процессов агентов.

## Зачем использовать LangChain?

LangChain помогает разработчикам создавать приложения на базе LLM с помощью стандартного интерфейса для моделей, эмбеддингов, векторных хранилищ и других компонентов.

Используйте LangChain для:
- **Дополнения данных в реальном времени**. Легко подключайте LLM к различным источникам данных и внешним/внутренним системам, используя обширную библиотеку интеграций LangChain с поставщиками моделей, инструментами, векторными хранилищами, ретриверами и другими сервисами.
- **Взаимодействие между моделями**. Меняйте модели по мере того, как ваша команда инженеров экспериментирует, чтобы подобрать оптимальное решение для ваших задач. По мере развития отрасли быстро адаптируйтесь — абстракции LangChain позволяют двигаться вперед без потери инерции.

## Экосистема LangChain
Хотя фреймворк LangChain можно использовать отдельно, он также безупречно интегрируется с любыми продуктами LangChain, предоставляя разработчикам полный набор инструментов для создания приложений на базе LLM.

Для повышения эффективности разработки LLM-приложений используйте LangChain вместе с:

- [LangSmith](http://www.langchain.com/langsmith) — полезен для оценки агентов и
мониторинга. Отлаживайте неудачные запуски LLM-приложений, оценивайте траектории агентов, получайте видимость в продакшене и улучшайте производительность со временем.
- [LangGraph](https://langchain-ai.github.io/langgraph/) — создавайте агентов, которые могут надежно выполнять сложные задачи с помощью LangGraph, нашего низкоуровневого фреймворка оркестрации агентов. LangGraph предлагает настраиваемую архитектуру, долговременную память и процессы с участием человека — и уже используется в продакшене такими компаниями, как LinkedIn, Uber, Klarna и GitLab.
- [LangGraph Platform](https://langchain-ai.github.io/langgraph/concepts/langgraph_platform/) — развертывайте и масштабируйте агентов без усилий с помощью специализированной платформы для долгосрочных, сохраняющих состояние рабочих процессов. Открывайте, переиспользуйте, настраивайте и делитесь агентами между командами — и быстро итерационно работайте с помощью визуального прототипирования в
[LangGraph Studio](https://langchain-ai.github.io/langgraph/concepts/langgraph_studio/).

## Дополнительные ресурсы
- [Учебные пособия](https://python.langchain.com/docs/tutorials/): Простые пошаговые примеры для знакомства с LangChain.
- [Руководства "Как сделать"](https://python.langchain.com/docs/how_to/): Быстрые и практичные фрагменты кода по таким темам, как вызов инструментов, кейсы применения RAG и многое другое.
- [Концептуальные руководства](https://python.langchain.com/docs/concepts/): Объяснения ключевых концепций фреймворка LangChain.
- [API Reference](https://python.langchain.com/api_reference/): Подробная справка по основным пакетам и интеграциям LangChain.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---