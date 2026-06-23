# Протокол Agent2Agent (A2A)

[![PyPI - Version](https://img.shields.io/pypi/v/a2a-sdk)](https://pypi.org/project/a2a-sdk)
[![Apache License](https://img.shields.io/badge/License-Apache_2.0-blue.svg)](LICENSE)
<a href="https://codewiki.google/github.com/a2aproject/a2a">
  <img src="https://www.gstatic.com/_/boq-sdlc-agents-ui/_/r/Mvosg4klCA4.svg" alt="Ask Code Wiki" height="20">
</a>

<div style="text-align: left;">
  <details>
    <summary>🌐 Язык</summary>
    <div>
      <div style="text-align: center;">
        <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=as">অসমীয়া</a>
      </div>
    </div>
  </details>
</div>

<!-- markdownlint-disable MD041 -->
<div style="text-align: center;">
  <div class="centered-logo-text-group">
    <img src="https://raw.githubusercontent.com/a2aproject/A2A/main/docs/assets/a2a_logo/color/SVG/a2a_color.svg" alt="Логотип протокола Agent2Agent" width="100">
    <h1>Протокол Agent2Agent (A2A)</h1>
  </div>
</div>

**Открытый протокол, обеспечивающий связь и совместимость между непрозрачными агентными приложениями.**

Протокол Agent2Agent (A2A) решает важную задачу в сфере ИИ: позволяет агентам генеративного ИИ, созданным на разных фреймворках различными компаниями и работающим на отдельных серверах, эффективно общаться и сотрудничать — как агенты, а не просто как инструменты. Цель A2A — предоставить общий язык для агентов, содействуя более взаимосвязанной, мощной и инновационной экосистеме ИИ.

С помощью A2A агенты могут:

- Обнаруживать возможности друг друга.
- Согласовывать способы взаимодействия (текст, формы, медиа).
- Безопасно сотрудничать над длительными задачами.
- Работать, не раскрывая внутреннее состояние, память или инструменты.

## Курс DeepLearning.AI

[![A2A DeepLearning.AI](https://img.youtube.com/vi/4gYm0Rp7VHc/maxresdefault.jpg)](https://goo.gle/dlai-a2a)

Присоединяйтесь к короткому курсу [A2A: Протокол Agent2Agent](https://goo.gle/dlai-a2a), созданному в партнерстве с Google Cloud и IBM Research и преподаваемому [Холтом Скиннером](https://github.com/holtskinner), [Иваном Нардини](https://github.com/inardini) и [Санди Бесен](https://github.com/sandijean90).

**Чему вы научитесь:**

- **Сделать агентов совместимыми с A2A:** Открывать агентов, созданных на таких фреймворках, как Google ADK, LangGraph или BeeAI, как A2A-серверы.
- **Соединять агентов:** Создавать A2A-клиенты с нуля или с помощью интеграций для подключения к агентам, совместимым с A2A.
- **Оркестровка рабочих процессов:** Строить последовательные и иерархические рабочие процессы из совместимых с A2A агентов.
- **Мультиагентные системы:** Создавать мультиагентную систему для здравоохранения на разных фреймворках и увидеть, как A2A обеспечивает сотрудничество.
- **A2A и MCP:** Узнать, как A2A дополняет MCP, позволяя агентам сотрудничать друг с другом.

## Почему A2A?

По мере распространения ИИ-агентов их способность к взаимодействию становится критически важной для построения сложных, многофункциональных приложений. Цели A2A:

- **Ликвидировать изолированность:** Соединять агентов из разных экосистем.
- **Обеспечить сложное сотрудничество:** Позволять специализированным агентам работать вместе над задачами, которые не может выполнить один агент.
- **Продвигать открытые стандарты:** Содействовать сообществу в разработке стандартов общения агентов, стимулируя инновации и широкое внедрение.
- **Сохранять непрозрачность:** Позволять агентам сотрудничать без необходимости раскрывать внутреннюю память, проприетарную логику или конкретные реализации инструментов, повышая безопасность и защищая интеллектуальную собственность.

### Ключевые особенности

- **Стандартизированная коммуникация:** JSON-RPC 2.0 через HTTP(S).
- **Обнаружение агентов:** Через "Карты агентов" с описанием возможностей и информации о подключении.
- **Гибкое взаимодействие:** Поддержка синхронного запроса/ответа, потоковой передачи (SSE) и асинхронных push-уведомлений.
- **Богатый обмен данными:** Работа с текстом, файлами и структурированными данными JSON.
- **Готовность для предприятий:** Проектировано с учетом безопасности, аутентификации и наблюдаемости.

## Начало работы

- 📚 **Изучите документацию:** Посетите [Сайт документации протокола Agent2Agent](https://a2a-protocol.org) для полного обзора, спецификации протокола, учебников и руководств.
- 📝 **Просмотрите спецификацию:** [Спецификация протокола A2A](https://a2a-protocol.org/latest/specification/)
- Используйте SDK:
    - [🐍 A2A Python SDK](https://github.com/a2aproject/a2a-python) `pip install a2a-sdk`
    - [🐿️ A2A Go SDK](https://github.com/a2aproject/a2a-go) `go get github.com/a2aproject/a2a-go`
    - [🧑‍💻 A2A JS SDK](https://github.com/a2aproject/a2a-js) `npm install @a2a-js/sdk`
    - [☕️ A2A Java SDK](https://github.com/a2aproject/a2a-java) с использованием maven
    - [🔷 A2A .NET SDK](https://github.com/a2aproject/a2a-dotnet) с использованием [NuGet](https://www.nuget.org/packages/A2A) `dotnet add package A2A`
    - [🦀 A2A Rust SDK](https://github.com/a2aproject/a2a-rs) `cargo add a2a-lf`
- 🎬 Используйте наши [примеры](https://github.com/a2aproject/a2a-samples), чтобы увидеть A2A в действии

## Вклад

Мы приветствуем участие сообщества для развития и улучшения протокола A2A!

- **Вопросы и обсуждения:** Присоединяйтесь к нашим [GitHub обсуждениям](https://github.com/a2aproject/A2A/discussions).
- **Ошибки и отзывы:** Сообщайте о проблемах или предлагайте улучшения через [GitHub Issues](https://github.com/a2aproject/A2A/issues).
- **Руководство по вкладу:** Ознакомьтесь с нашим [CONTRIBUTING.md](https://raw.githubusercontent.com/a2aproject/A2A/main/CONTRIBUTING.md) для информации о том, как внести вклад.
- **Приватный отзыв:** Используйте эту [Google Форму](https://goo.gle/a2a-feedback).
- **Партнерская программа:** Клиенты Google Cloud могут присоединиться к партнерской программе через эту [форму](https://goo.gle/a2a-partner).

## Что дальше

### Улучшения протокола

- **Обнаружение агентов:**
    - Формализовать включение схем авторизации и опциональных учетных данных непосредственно в `AgentCard`.
- **Сотрудничество агентов:**
    - Исследовать метод `QuerySkill()` для динамической проверки неподдерживаемых или неожиданных навыков.
- **Жизненный цикл задачи и UX:**
    - Поддержка динамического согласования UX _внутри_ задачи (например, агент добавляет аудио/видео во время разговора).
- **Методы клиента и транспорт:**
    - Исследовать расширение поддержки на клиентские методы (помимо управления задачами).
    - Улучшения надежности потоковой передачи и механизмов push-уведомлений.

## О проекте

Протокол A2A — это проект с открытым исходным кодом под эгидой Linux Foundation, внесённый Google. Лицензируется по [лицензии Apache 2.0](LICENSE) и открыт для вклада со стороны сообщества.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-23

---