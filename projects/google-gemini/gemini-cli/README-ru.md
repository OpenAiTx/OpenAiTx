# Gemini CLI

[![Gemini CLI CI](https://github.com/google-gemini/gemini-cli/actions/workflows/ci.yml/badge.svg)](https://github.com/google-gemini/gemini-cli/actions/workflows/ci.yml)

![Gemini CLI Screenshot](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/assets/gemini-screenshot.png)

Этот репозиторий содержит Gemini CLI — инструмент командной строки для работы с ИИ, который соединяет ваши инструменты, понимает ваш код и ускоряет рабочие процессы.

С помощью Gemini CLI вы можете:

- Выполнять запросы и редактировать крупные кодовые базы внутри и за пределами 1M токенов контекстного окна Gemini.
- Генерировать новые приложения из PDF или эскизов, используя мультимодальные возможности Gemini.
- Автоматизировать операционные задачи, такие как запросы pull request или выполнение сложных rebase-операций.
- Использовать инструменты и MCP-серверы для подключения новых возможностей, включая [генерацию медиа с помощью Imagen, Veo или Lyria](https://github.com/GoogleCloudPlatform/vertex-ai-creative-studio/tree/main/experiments/mcp-genmedia).
- Подкреплять свои запросы с помощью встроенного инструмента [Google Search](https://ai.google.dev/gemini-api/docs/grounding), интегрированного в Gemini.

## Быстрый старт

1. **Требования:** Убедитесь, что у вас установлена [Node.js версии 18](https://nodejs.org/en/download) или выше.
2. **Запуск CLI:** Выполните следующую команду в терминале:

   ```bash
   npx https://github.com/google-gemini/gemini-cli
   ```

   Или установите так:

   ```bash
   npm install -g @google/gemini-cli
   gemini
   ```

3. **Выберите цветовую тему**
4. **Аутентификация:** При появлении запроса войдите в свою личную учетную запись Google. Это даст вам до 60 запросов к модели в минуту и 1 000 запросов в день через Gemini.

Теперь вы готовы использовать Gemini CLI!

### Для расширенного использования или увеличения лимитов:

Если вам нужен определенный тип модели или требуется больше запросов, используйте API-ключ:

1. Сгенерируйте ключ в [Google AI Studio](https://aistudio.google.com/apikey).
2. Установите его как переменную окружения в своем терминале. Замените `YOUR_API_KEY` на сгенерированный ключ.

   ```bash
   export GEMINI_API_KEY="YOUR_API_KEY"
   ```

Для других методов аутентификации, включая аккаунты Google Workspace, смотрите руководство [authentication](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/cli/authentication.md).

## Примеры

После запуска CLI вы можете начать взаимодействие с Gemini прямо из вашей оболочки.

Вы можете начать проект из новой директории:

```sh
cd new-project/
gemini
> Напиши мне Discord-бота на Gemini, который отвечает на вопросы, используя файл FAQ.md, который я предоставлю
```

Или работать с существующим проектом:

```sh
git clone https://github.com/google-gemini/gemini-cli
cd gemini-cli
gemini
> Дай мне сводку всех изменений, внесённых вчера
```

### Следующие шаги

- Узнайте, как [вносить вклад или собирать из исходников](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/CONTRIBUTING.md).
- Изучите доступные **[CLI-команды](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/cli/commands.md)**.
- Если у вас возникли проблемы, ознакомьтесь с **[руководством по устранению неполадок](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/troubleshooting.md)**.
- Для получения полной документации смотрите [полную документацию](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/index.md).
- Ознакомьтесь с [популярными задачами](#popular-tasks) для вдохновения.

### Устранение неполадок

Перейдите к [руководству по устранению неполадок](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/troubleshooting.md), если у вас возникли проблемы.

## Популярные задачи

### Исследование новой кодовой базы

Начните с перехода (`cd`) в существующий или только что клонированный репозиторий и запуска `gemini`.

```text
> Опиши основные компоненты архитектуры этой системы.
```

```text
> Какие механизмы безопасности реализованы?
```

### Работа с вашим кодом

```text
> Реализуй черновик для задачи GitHub issue #123.
```

```text
> Помоги перенести этот проект на последнюю версию Java. Начни с плана.
```

### Автоматизация рабочих процессов

Используйте MCP-серверы для интеграции локальных инструментов вашей системы с корпоративными средами сотрудничества.

```text
> Создай презентацию, показывающую историю git за последние 7 дней, сгруппированную по функциям и участникам команды.
```

```text
> Сделай полноэкранное веб-приложение для отображения наиболее обсуждаемых задач GitHub на стенде.
```

### Взаимодействие с вашей системой

```text
> Конвертируй все изображения в этой директории в png и переименуй их, используя даты из exif-данных.
```

```text
> Организуй мои PDF-счета по месяцам расходов.
```

## Условия использования и уведомление о конфиденциальности

Подробнее об условиях использования и уведомлении о конфиденциальности, применимых к использованию Gemini CLI, смотрите в разделе [Условия использования и уведомление о конфиденциальности](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/tos-privacy.md).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---