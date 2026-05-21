# Примеры Agent2Agent (A2A)

<a href="https://studio.firebase.google.com/new?template=https%3A%2F%2Fgithub.com%2Fa2aproject%2Fa2a-samples%2Ftree%2Fmain%2F.firebase-studio">
  <picture>
    <source
      media="(prefers-color-scheme: dark)"
      srcset="https://cdn.firebasestudio.dev/btn/try_light_20.svg">
    <source
      media="(prefers-color-scheme: light)"
      srcset="https://cdn.firebasestudio.dev/btn/try_dark_20.svg">
    <img
      height="20"
      alt="Попробовать в Firebase Studio"
      src="https://cdn.firebasestudio.dev/btn/try_blue_20.svg">
  </picture>
</a>

<div style="text-align: right;">
  <details>
    <summary>🌐 Язык</summary>
    <div style="text-align: center;">
      <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=en">English</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=zh-CN">简体中文</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=zh-TW">繁體中文</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ja">日本語</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ko">한국어</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=hi">हिन्दी</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=th">ไทย</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=fr">Français</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=de">Deutsch</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=es">Español</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=it">Italiano</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ru">Русский</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=pt">Português</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=nl">Nederlands</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=pl">Polski</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ar">العربية</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=fa">فارسی</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=tr">Türkçe</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=vi">Tiếng Việt</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ru">Русский</a>
    </div>
  </details>
</div>

Добро пожаловать в официальный репозиторий примеров кода и демонстраций для [Agent2Agent (A2A) Protocol](https://goo.gle/a2a).

Мы рады приветствовать вас здесь! Независимо от того, изучаете ли вы архитектуры мультиагентов впервые или строите сложные интероперабельные сети агентов, этот репозиторий предоставляет простые, вдохновляющие и доступные учебные ресурсы для ускорения вашего развития.

## Почему Agent2Agent?

В мире разнообразных AI-фреймворков и экосистем агентам нужен общий язык для общения, сотрудничества и безопасной передачи задач. Протокол A2A устанавливает стандартизированный, открытый стандарт для мультиагентной совместимости.

Наши примеры показывают, как просто решать сложные мультиагентные задачи на разных языках и в различных приложениях.

## Быстрый старт

Начните работу немедленно, запустив агента Helloworld и связавшись с ним через наш Python CLI-хост.

1. **Запустите сервер агента**:
   Откройте терминал и запустите сервер агента Helloworld:

   ```bash
   cd samples/python/agents/helloworld
   uv run .
   ```

2. **Запустите клиент хоста**:
   Откройте второй терминал и запустите CLI-клиент, чтобы отправить задачу агенту:

   ```bash
   cd samples/python/agents/helloworld
   uv run test_client.py
   ```

## Структура репозитория

Репозиторий организован по нескольким ключевым директориям в зависимости от языка программирования:

| Директория | Описание |
| --- | --- |
| [samples](/samples) | Основные примеры A2A, организованные по языкам программирования. |
| [samples/python](/samples/python) | Демонстрирует реализацию агентов на Python с использованием A2A Python SDK. |
| [samples/go](/samples/go) | Демонстрирует реализацию агентов на Go с использованием A2A Go SDK. |
| [samples/dotnet](/samples/dotnet) | Демонстрирует реализацию агентов на C# с использованием A2A .NET SDK. |
| [samples/java](/samples/java) | Демонстрирует реализацию агентов на Java с использованием A2A Java SDK. |
| [samples/js](/samples/js) | Демонстрирует реализацию агентов на Node.js с использованием A2A JavaScript SDK. |

## Вклад в проект

Мы приветствуем и поощряем вклад всех уровней! Если у вас есть идея для нового примера, исправления ошибки или улучшения документации, ознакомьтесь с нашим [Руководством по вкладу](https://raw.githubusercontent.com/a2aproject/a2a-samples/main/CONTRIBUTING.md).

## Получение помощи

Мы стремимся создать дружелюбное и поддерживающее сообщество. Если у вас есть вопросы, отзывы или вы столкнулись с проблемами, пожалуйста, обращайтесь на нашу [страницу с вопросами](https://github.com/a2aproject/a2a-samples/issues).

## Связанные репозитории

| Репозиторий | Категория | Описание |
| --- | --- | --- |
| [A2A](https://github.com/a2aproject/A2A) | Основная спецификация | Спецификация A2A и документация. |
| [a2a-inspector](https://github.com/a2aproject/a2a-inspector) | Инструменты | UI-инструмент для инспекции агентов с поддержкой A2A. |
| [a2a-tck](https://github.com/a2aproject/a2a-tck) | Тестирование | Набор тестов для проверки соответствия протоколу A2A. |
| [a2a-itk](https://github.com/a2aproject/a2a-itk) | Тестирование | Набор инструментов для проверки совместимости различных реализаций A2A SDK и версий с помощью мульти-хоп модели и различных транспортных протоколов. |
| [a2a-python](https://github.com/a2aproject/a2a-python) | SDK (Python) | Официальный Python SDK для A2A. |
| [a2a-go](https://github.com/a2aproject/a2a-go) | SDK (Go) | Официальный Go SDK для A2A. |
| [a2a-java](https://github.com/a2aproject/a2a-java) | SDK (Java) | Официальный Java SDK для A2A. |
| [a2a-js](https://github.com/a2aproject/a2a-js) | SDK (JavaScript) | Официальный Node.js/JavaScript SDK для A2A. |
| [a2a-dotnet](https://github.com/a2aproject/a2a-dotnet) | SDK (C#/.NET) | Официальный C#/.NET SDK для A2A. |
| [a2a-rs](https://github.com/a2aproject/a2a-rs) | SDK (Rust) | Официальный Rust SDK для A2A. |

## Отказ от ответственности

**Важное замечание:** Приведённый пример кода предназначен только для демонстрационных целей и иллюстрирует механику
Протокол Agent-to-Agent (A2A). При разработке производственных приложений крайне важно рассматривать любого агента, действующего вне вашего непосредственного контроля, как потенциально ненадежную сущность.

Все данные, полученные от внешнего агента, включая, но не ограничиваясь AgentCard, сообщениями, артефактами и статусами задач, должны рассматриваться как недоверенный ввод. Например, вредоносный агент может предоставить AgentCard, содержащий сфабрикованные данные в своих полях (например, описание, имя, skills.description). Если эти данные используются без очистки для формирования запросов к большой языковой модели (LLM), это может подвергнуть ваше приложение атакам внедрения запросов. Неспособность правильно валидировать и очищать эти данные перед использованием может привести к уязвимостям безопасности вашего приложения.

> Разработчики несут ответственность за реализацию соответствующих мер безопасности, таких как валидация вводимых данных и безопасная обработка учетных данных, чтобы защитить свои системы и пользователей.










---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-21

---