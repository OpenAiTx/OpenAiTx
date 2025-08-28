
<div align="center"><p><a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=en"><img src="https://img.shields.io/badge/EN-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=zh-CN"><img src="https://img.shields.io/badge/简中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=zh-TW"><img src="https://img.shields.io/badge/繁中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=ja"><img src="https://img.shields.io/badge/日本語-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=ko"><img src="https://img.shields.io/badge/한국어-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=hi"><img src="https://img.shields.io/badge/हिन्दी-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=th"><img src="https://img.shields.io/badge/ไทย-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=fr"><img src="https://img.shields.io/badge/Français-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=de"><img src="https://img.shields.io/badge/Deutsch-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=es"><img src="https://img.shields.io/badge/Español-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=it"><img src="https://img.shields.io/badge/Italiano-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=ru"><img src="https://img.shields.io/badge/Русский-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=pt"><img src="https://img.shields.io/badge/Português-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=nl"><img src="https://img.shields.io/badge/Nederlands-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=pl"><img src="https://img.shields.io/badge/Polski-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=ar"><img src="https://img.shields.io/badge/العربية-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=fa"><img src="https://img.shields.io/badge/فارسی-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=tr"><img src="https://img.shields.io/badge/Türkçe-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=vi"><img src="https://img.shields.io/badge/Tiếng Việt-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=id"><img src="https://img.shields.io/badge/Bahasa Indonesia-white" alt="version"></a> </p></div>

# Улучшенный сервер PubChem MCP для AI-ассистентов

🧪 Продвинутый, надежный и ориентированный на конфиденциальность сервер MCP, позволяющий AI-ассистентам интеллектуально искать и получать информацию о химических соединениях из PubChem.

Этот сервер PubChem MCP служит мощным мостом между AI-ассистентами (например, в AnythingLLM) и обширной химической базой данных PubChem. Он использует Model Context Protocol (MCP), чтобы дать AI-моделям возможность выполнять умные, устойчивые поиски химических соединений и программно получать их подробные свойства.

---

## ✨ Основные возможности

Это не просто еще одна оболочка PubChem. Сервер был полностью переработан для высокой надежности и интеллектуальности:

-   **🧠 Умный резервный поиск**: Если поиск по распространенному названию (например, «Витамин D») не удается, сервер автоматически выполняет более глубокий поиск в базе данных PubChem Substance, чтобы найти правильное соединение. Это значительно повышает успешность при неоднозначных запросах.
-   **🛡️ Надежная обработка ошибок и повторные попытки**: Сервер спроектирован так, чтобы аккуратно обрабатывать ошибки API. Если возникает ошибка «Сервер занят» от PubChem, он автоматически подождет и повторит запрос, обеспечивая успех ваших запросов даже при высокой нагрузке.
-   **🔒 Опциональная поддержка Tor-прокси**: Вы полностью контролируете свою конфиденциальность. Простой файл `config.ini` позволяет направлять все запросы через сеть Tor (через SOCKS5 или HTTP-прокси), предотвращая раскрытие вашего IP-адреса. Сервер по умолчанию безопасен и **никогда** не раскроет ваш IP в случае сбоя соединения с прокси.
-   **🔎 Поиск одного и нескольких соединений**: Легко обрабатывает запросы на одно или несколько соединений в одном сообщении.
-   **🧪 Получение подробных свойств**: Доступ к ключевым химическим свойствам, таким как название IUPAC, молекулярная формула, молекулярная масса и, что важно, **моноизотопная масса**.

---

---

### 🚀 Не требуется установка: попробуйте онлайн на Smithery.ai

Если вы новичок в серверах MCP или просто хотите протестировать возможности этого инструмента без локальной установки, доступна живая хостинговая версия на Smithery.ai. Это позволяет общаться с агентом прямо в вашем браузере.

[**<-- Исследуйте живого агента PubChem на Smithery.ai -->**](https://smithery.ai/server/@Milor123/smithery-pubchem-deploy)

**Как начать:**

1.  Нажмите на ссылку выше, чтобы перейти на страницу сервера.
2.  Войдите, используя свою учетную запись **GitHub** или **Google**.
3.  Нажмите кнопку **"Explore capabilities"** для открытия интерфейса чата и начните тестирование!

> **✅ Рекомендуемые модели для лучших результатов**
>
> Для достижения максимальной точности, особенно при работе с длинными десятичными числами, мы настоятельно рекомендуем использовать мощные модели. Следующие варианты протестированы и отлично работают с этим инструментом:
>
> *   **Claude 3 Sonnet от Anthropic**
> *   **OpenAI GPT-4 Turbo** (или более новые версии, такие как GPT-4o)
>
> Мы подтвердили, что обе модели корректно обрабатывают полную точность десятичных чисел, возвращаемых инструментом, без округления.

---

## 🚀 Быстрый старт и установка

Этот сервер предназначен для локального запуска, либо на вашем рабочем столе, либо в среде Docker AnythingLLM.

### 1. Зависимости

Этот проект использует несколько библиотек Python. Убедитесь, что они установлены в вашей среде.

Создайте файл `requirements.txt` со следующим содержимым:
```txt
requests
bs4 
mcp 
pubchempy
pandas
PySocks
```

Установите их с помощью `uv` или `pip`:
```bash
uv venv
.venv\Scripts\activate
uv pip install -r requirements.txt
```
*(Примечание: `PySocks` требуется только если вы планируете использовать функцию Tor SOCKS5 proxy.)*

### 2. Конфигурация

Сервер настраивается с помощью файла `config.ini`, который **автоматически создается** при первом запуске. Этот файл появится в той же директории, что и скрипт `pubchem_server.py`.

**Стандартный `config.ini`:**
```ini
[proxy]
# Change 'use_proxy' to 'true' to route all requests through a proxy.
# Essential for protecting your privacy if you use Tor.
use_proxy = false

# Defines the proxy type. Options:
#   socks5h  -> (Recommended for Tor) The native SOCKS proxy for Tor. More secure.
#   http     -> An HTTP proxy. If using Tor, requires additional configuration.
proxy_type = socks5h

# The proxy address. THIS IS A CRITICAL SETTING!
#   - If you run this script on your DESKTOP, use: 127.0.0.1
#   - If you run this script inside DOCKER, use: host.docker.internal
host = 127.0.0.1

# The proxy port.
#   9050 -> Default port for Tor's SOCKS proxy.
#   8118 -> Default port for Tor's HTTP proxy (if enabled).
port = 9050
```

### 3. Интеграция с AnythingLLM

Следуйте официальной документации, чтобы добавить это как пользовательский MCP сервер. Ключевой момент — указать `command` на ваш исполняемый файл Python и скрипт `pubchem_server.py`.

**Пример для AnythingLLM Desktop (`plugins/anythingllm_mcp_servers.json`):**
```json
{
  "mcpServers": {
    "pubchem": {
      "name": "PubChem Server (Enhanced)",
      "transport": "stdio",
      "command": "\"C:\\path\\to\\your\\.venv\\Scripts\\python.exe\" \"C:\\path\\to\\your\\project\\pubchem_server.py\"",
      "cwd": "C:\\path\\to\\your\\project"
    }
  }
}
```


### 3.1 Примеры реализации с AnythingLLM

Вот несколько примеров взаимодействия с агентом. Эти тесты были проведены с помощью AnythingLLM Desktop, подключаясь к различным большим языковым моделям через OpenRouter.

Важный вывод из наших тестов — это значимость выбранной модели. Мы **настоятельно не рекомендуем использовать малые или локальные модели** для этой задачи. Малые модели часто испытывают трудности с корректным разбором данных, возвращаемых инструментом, что приводит к ошибкам, таким как галлюцинированные значения, неправильное форматирование или, что особенно критично, **округление десятичных чисел**, что нивелирует преимущество высокоточного инструмента.

Для обеспечения целостности ваших результатов всегда полезно проверять необработанные данные, возвращаемые MCP. Узнать, как это сделать, вы сможете в следующем разделе: [3.2 Как проверить выводы MCP в логах](#32-how-to-verify-mcp-outputs-in-the-logs).

<img width="837" height="1060" alt="imagen" src="https://github.com/user-attachments/assets/5a16c7a2-d65d-4d64-98dd-f3cb4cae9b22" />

С другой стороны, несколько моделей показали отличные результаты. Мы достигли выдающихся результатов с **Google `Gemini 2.5 Flash lite`**. Эта модель проявила высокую точность при работе с длинными десятичными числами и корректном форматировании итоговой Markdown-таблицы.

Google gemini 2.5 flash lite без промпта и с промптом сохраняет идеальные десятичные значения (в примере используется температура 0.6)

<img width="1089" height="1061" alt="imagen" src="https://github.com/user-attachments/assets/4574efa5-d6d9-49e3-a665-a39a427f09a1" />

Для данной задачи моя личная рекомендация — **`Gemini 2.5 Flash lite`** благодаря ее стабильной точности и надежности.

### 3.2 Как проверить выводы MCP в логах

Лучший способ убедиться, что агент получает корректные данные и что LLM не допускает ошибок — это проверить отладочный лог-файл, создаваемый сервером MCP.

Этот сервер настроен на автоматическое создание лог-файла в подпапке вашего проектного каталога. Местоположение будет:

```
your-project-folder/
└── logs_mcp/
    └── mcp_debug.log
```

Внутри файла `mcp_debug.log` вы найдете точные JSON-данные, которые инструмент отправляет обратно в LLM *до* того, как модель их обработает. Вы можете вручную проверить этот JSON, чтобы убедиться в любых значениях, особенно в длинных десятичных числах из свойств, таких как `monoisotopic_mass`, гарантируя, что LLM не внес никаких ошибок округления или галлюцинаций в окончательном ответе.

---

## 📊 Использование

После интеграции ваш AI-ассистент будет автоматически использовать этот инструмент при запросе химической информации. Основной предоставляемый инструмент — `search_compounds_by_name`.

### Пример запроса

Этот запрос демонстрирует способность инструмента работать со списком соединений с различными типами названий и получать множество свойств.

```
@agent
Please use your PubChem tool to find information on the following compounds:

- Thiamine (Vitamin B1)
- Riboflavin (Vitamin B2)
- Folic Acid
- Hydroxocobalamin

For each compound found, please retrieve the IUPAC Name, Molecular Formula, and Monoisotopic Mass.

Present all the results in a single Markdown table.
```

Агент вызовет инструмент `search_compounds_by_name`, который будет интеллектуально искать каждый соединение, извлекать его данные и возвращать их LLM для форматирования.

---

## 🛠 MCP Инструмент

### `search_compounds_by_name`

Осуществляет поиск нескольких соединений по названию, поочередно, используя умную стратегию отката с паузами и повторными попытками для максимальной надежности.

**Параметры:**
-   `names` (List[str]): Список названий соединений. Пример: `["Aspirin", "Ibuprofen"]`

**Возвращает:** Список словарей, где каждый словарь содержит либо информацию о найденном соединении, либо сообщение об ошибке с деталями, почему поиск для данного соединения не удался.

---

## 🙏 Благодарности

Данный проект был вдохновлен и построен на основе оригинального [PubChem-MCP-Server](https://github.com/JackKuo666/PubChem-MCP-Server), созданного **JackKuo666**.

Хотя этот репозиторий не является прямым форком, оригинальный проект был важной отправной точкой. Эта версия расширяет исходную концепцию, делая упор на максимальную надежность, интеллектуальные стратегии поиска и конфиденциальность пользователя через интеграцию Tor 🧅.

Огромное спасибо автору оригинального проекта за отличную работу и за то, что он поделился ею с сообществом.

---

## ⚠️ Отказ от ответственности

Этот инструмент предназначен для исследовательских и образовательных целей. Пожалуйста, уважайте условия использования PubChem и используйте этот инструмент ответственно.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-27

---