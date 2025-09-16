
# mcp-chat

<div align="right">
  <details>
    <summary >🌐 Язык</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=as">অসমীয়া</
      </div>
    </div>
  </details>

</div>

Открытый универсальный клиент MCP для тестирования и оценки MCP-серверов и агентов

<p align="center">
  <img width="600" src="https://raw.githubusercontent.com/Flux159/mcp-chat/refs/heads/main/mcpchat.svg">
</p>

## Быстрый старт

Убедитесь, что вы экспортировали `ANTHROPIC_API_KEY` в вашей среде или в файле .env в корневой папке проекта. Получить API-ключ можно, зарегистрировавшись на [странице ключей Anthropic Console](https://console.anthropic.com/settings/keys).

Простой пример использования: запуск интерактивного чата с сервером MCP файловой системы через CLI:

```shell
npx mcp-chat --server "npx -y @modelcontextprotocol/server-filesystem /Users/$USER/Desktop"
```

Это откроет окно чата, с помощью которого вы сможете взаимодействовать с серверами и общаться с LLM.

## Конфигурация

Вы также можете просто указать ваш claude_desktop_config.json (Mac):

```shell
npx mcp-chat --config "~/Library/Application Support/Claude/claude_desktop_config.json"
```

Или (Windows):

```shell
npx mcp-chat --config "%APPDATA%\Claude\claude_desktop_config.json"
```

## Web mode

https://github.com/user-attachments/assets/b7e8a648-8084-4955-8cdf-fc6eb141572e

You can also run mcp-chat in web mode by specifying the `--web` flag (make sure to have `ANTHROPIC_API_KEY` exported in your environment):

```shell
npx mcp-chat --web
```

В веб-режиме вы можете начинать новые чаты, отправлять сообщения модели и динамически настраивать серверы mcp через пользовательский интерфейс — нет необходимости указывать это в командной строке. Кроме того, чаты, созданные через веб-интерфейс, сохраняются в ~/.mcpchats/chats так же, как и чаты, созданные через CLI.

## Возможности

- [x] Запуск через CLI в интерактивном режиме или непосредственная передача запросов с помощью `-p`
- [x] Веб-режим для общения с моделями через веб-интерфейс `--web`
- [x] Подключение к любому серверу MCP (JS, Python, Docker) в продакшене или во время разработки
- [x] Выбор между моделями с помощью `-m`
- [x] Настройка системного промпта с помощью `--system`
- [x] Сохранение истории чата с настройками в `~/.mcpchat/chats`, включая веб-чаты
- [x] Сохранение и восстановление команд в `~/.mcpchat/history`
- [x] Просмотр результата вызова инструментов и аргументов прямо в чате для облегчения отладки серверов mcp

## Использование CLI

Запуск запросов через CLI с флагом `-p`:

```shell
npx mcp-chat --server "npx mcp-server-kubernetes" -p "List the pods in the default namespace"
```

Это запускает запрос с помощью kubernetes mcp-server и завершает работу после получения ответа в stdout.

Выберите модель для общения через CLI с помощью флага `-m`:

```shell
npx mcp-chat --server "npx mcp-server-kubernetes" -m "claude-3.5"
```

Использует модель `claude-3.5` для общения. Обратите внимание, что в настоящее время поддерживаются только модели Anthropic.

Пользовательский системный запрос:

Флаг `--system` может использоваться для указания системного запроса:

```shell
npx mcp-chat --system "Explain the output to the user in pirate speak." --server "npx mcp-server-kubernetes" -p "List the pods in the default namespace"
```

## Переменные окружения (ENV vars)

Mcp-chat поддерживает передачу переменных окружения на серверы mcp. Однако это не стандартизировано в спецификации mcp, и другие клиенты могут не использовать динамические значения переменных окружения — подробнее читайте [здесь](https://github.com/Flux159/mcp-server-kubernetes/issues/148#issuecomment-2950181666) о стандартных stdio клиентах mcp.

```shell
KUBECONFIG="~/.kube/config" npx mcp-chat --server "npx mcp-server-kubernetes"
```

## Для разработчиков mcp-серверов

Вы можете передать локальную сборку python или node mcp-сервера, чтобы протестировать его с mcp-chat:

Node JS:

```shell
# Directly executing built script
npx mcp-chat --server "/path/to/mcp-server-kubernetes/dist/index.js"
# Using node / bun
npx mcp-chat --server "node /path/to/mcp-server-kubernetes/dist/index.js"
```

Python:

```shell
# Python: Using uv
npx mcp-chat --server "uv --directory /path/to/mcp-server-weather/ run weather.py"
# Using python / python3 - make sure to run in venv or install deps globally
npx mcp-chat --server "/path/to/mcp-server-weather/weather.py"
```

## Разработка

Установите зависимости и запустите CLI:

```shell
git clone https://github.com/Flux159/mcp-chat
bun install
bun run dev
```
Для разработки mcp-chat при подключении к mcp-server выполните сборку и запустите CLI с флагом сервера:


```shell
npm run build && node dist/index.js --server "npx mcp-server-kubernetes" -p "List the pods in the default namespace"
```

Тестирование:

```shell
bun run test
```

Здание:

```shell
bun run build
```

Публикация:

```shell
bun run publish
```

Публикация Docker:

```shell
bun run dockerbuild
```

### Структура проекта

```
├── src/
│   ├── index.ts            # Main client implementation & CLI params
│   ├── constants.ts        # Default constants
│   ├── interactive.ts      # Interactive chat prompt handling & logic
├── test/                   # Test files
│   ├── cli.test.ts         # Test CLI params
│   ├── config.test.ts      # Test config file parsing
```

## Публикация нового релиза

Перейдите на страницу [releases](https://github.com/Flux159/mcp-chat/releases), нажмите "Draft New Release", затем "Choose a tag" и создайте новый тег, введя новый номер версии в формате semver "v{major}.{minor}.{patch}". После этого укажите заголовок релиза "Release v{major}.{minor}.{patch}" и описание / список изменений при необходимости, затем нажмите "Publish Release".

Это создаст новый тег, который запустит сборку нового релиза через workflow cd.yml. После успешного завершения новый релиз будет опубликован в npm. Обратите внимание, что нет необходимости вручную обновлять версию в package.json, так как workflow автоматически обновит номер версии в файле package.json и отправит коммит в main.

## Лицензия

[MIT License](https://github.com/Flux159/mcp-chat/blob/main/LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-16

---