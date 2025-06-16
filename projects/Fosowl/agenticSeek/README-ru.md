# AgenticSeek: Приватная локальная альтернатива Manus.

<p align="center">
<img align="center" src="https://raw.githubusercontent.com/Fosowl/agenticSeek/main/media/agentic_seek_logo.png" width="300" height="300" alt="Agentic Seek Logo">
<p>

  English | [中文](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_CHS.md) | [繁體中文](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_CHT.md) | [Français](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_FR.md) | [日本語](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_JP.md) | [Português (Brasil)](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_PTBR.md) | [Español](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_ES.md)

*Полностью локальная альтернатива Manus AI*: этот голосовой AI-ассистент автономно просматривает веб, пишет код и планирует задачи, сохраняя все данные только на вашем устройстве. Оптимизирован для локальных моделей рассуждения, полностью работает на вашем оборудовании, обеспечивая полную приватность и отсутствие облачной зависимости.

[![Visit AgenticSeek](https://img.shields.io/static/v1?label=Website&message=AgenticSeek&color=blue&style=flat-square)](https://fosowl.github.io/agenticSeek.html) ![License](https://img.shields.io/badge/license-GPL--3.0-green) [![Discord](https://img.shields.io/badge/Discord-Join%20Us-7289DA?logo=discord&logoColor=white)](https://discord.gg/8hGDaME3TC) [![Twitter](https://img.shields.io/twitter/url/https/twitter.com/fosowl.svg?style=social&label=Update%20%40Fosowl)](https://x.com/Martin993886460) [![GitHub stars](https://img.shields.io/github/stars/Fosowl/agenticSeek?style=social)](https://github.com/Fosowl/agenticSeek/stargazers)

### Почему AgenticSeek?

* 🔒 Полностью локальный и приватный — Всё работает на вашем компьютере: никаких облаков, никакой передачи данных. Ваши файлы, диалоги и поисковые запросы остаются приватными.

* 🌐 Умный веб-браузер — AgenticSeek может самостоятельно просматривать интернет: искать, читать, извлекать информацию, заполнять веб-формы — полностью без рук.

* 💻 Автономный помощник по программированию — Нужен код? Он может писать, отлаживать и запускать программы на Python, C, Go, Java и других языках — полностью автономно.

* 🧠 Умный выбор агента — Вы задаёте вопрос, и он автоматически выбирает лучшего агента для задачи. Как команда экспертов, готовых помочь.

* 📋 Планирование и выполнение сложных задач — От планирования путешествий до реализации сложных проектов — может разбивать большие задачи на этапы и выполнять их с помощью нескольких AI-агентов.

* 🎙️ Голосовое управление — Современное, быстрое, футуристичное распознавание речи и синтез позволяет общаться с ним голосом, как с личным AI из фантастики. (В разработке)

### **Демонстрация**

> *Можешь найти проект agenticSeek, узнать какие навыки требуются, затем открыть CV_candidates.zip и сказать, кто из кандидатов лучше всего подходит для проекта?*

https://github.com/user-attachments/assets/b8ca60e9-7b3b-4533-840e-08f9ac426316

Дисклеймер: Эта демонстрация, включая все показанные файлы (например, CV_candidates.zip), полностью вымышлена. Мы не корпорация, мы ищем open-source контрибьюторов, а не кандидатов.

> 🛠⚠️️ **Активная разработка**

> 🙏 Этот проект начался как хобби и не имеет ни дорожной карты, ни финансирования. Он превзошёл все ожидания, попав в GitHub Trending. Вклад, обратная связь и терпение очень ценятся.

## Необходимое ПО

Перед началом убедитесь, что у вас установлено следующее ПО:

*   **Git:** Для клонирования репозитория. [Скачать Git](https://git-scm.com/downloads)
*   **Python 3.10.x:** Настоятельно рекомендуется использовать Python версии 3.10.x. Использование других версий может привести к ошибкам зависимостей. [Скачать Python 3.10](https://www.python.org/downloads/release/python-3100/) (выберите версию 3.10.x).
*   **Docker Engine & Docker Compose:** Для запуска встроенных сервисов, таких как SearxNG.
    *   Установите Docker Desktop (включает Docker Compose V2): [Windows](https://docs.docker.com/desktop/install/windows-install/) | [Mac](https://docs.docker.com/desktop/install/mac-install/) | [Linux](https://docs.docker.com/desktop/install/linux-install/)
    *   Либо установите Docker Engine и Docker Compose отдельно для Linux: [Docker Engine](https://docs.docker.com/engine/install/) | [Docker Compose](https://docs.docker.com/compose/install/) (убедитесь, что установили Compose V2, например, `sudo apt-get install docker-compose-plugin`).

### 1. **Клонируйте репозиторий и настройте**

```sh
git clone https://github.com/Fosowl/agenticSeek.git
cd agenticSeek
mv .env.example .env
```

### 2. Измените содержимое файла .env

```sh
SEARXNG_BASE_URL="http://127.0.0.1:8080"
REDIS_BASE_URL="redis://redis:6379/0"
WORK_DIR="/Users/mlg/Documents/workspace_for_ai"
OLLAMA_PORT="11434"
LM_STUDIO_PORT="1234"
CUSTOM_ADDITIONAL_LLM_PORT="11435"
OPENAI_API_KEY='optional'
DEEPSEEK_API_KEY='optional'
OPENROUTER_API_KEY='optional'
TOGETHER_API_KEY='optional'
GOOGLE_API_KEY='optional'
ANTHROPIC_API_KEY='optional'
```

Обновите файл `.env` своими значениями по мере необходимости:

- **SEARXNG_BASE_URL**: Оставьте без изменений 
- **REDIS_BASE_URL**: Оставьте без изменений 
- **WORK_DIR**: Путь к вашей рабочей директории на локальном устройстве. AgenticSeek сможет читать и взаимодействовать с этими файлами.
- **OLLAMA_PORT**: Порт для сервиса Ollama.
- **LM_STUDIO_PORT**: Порт для сервиса LM Studio.
- **CUSTOM_ADDITIONAL_LLM_PORT**: Порт для дополнительного собственного LLM-сервиса.

**API-ключи полностью опциональны для пользователей, которые запускают LLM локально. Это основное назначение проекта. Оставьте пустыми, если у вас достаточно ресурсов.**

### 3. **Запустите Docker**

Убедитесь, что Docker установлен и запущен на вашей системе. Запустить Docker можно следующими командами:

- **Linux/macOS:**  
    Откройте терминал и выполните:
    ```sh
    sudo systemctl start docker
    ```
    Или запустите Docker Desktop из меню приложений, если он установлен.

- **Windows:**  
    Запустите Docker Desktop из меню "Пуск".

Проверьте, что Docker работает, выполнив:
```sh
docker info
```
Если вы видите информацию о вашей установке Docker, значит всё работает корректно.

См. таблицу [Локальных провайдеров](#list-of-local-providers) ниже для сводки.

Следующий шаг: [Запуск AgenticSeek локально](#start-services-and-run)

*Обратитесь к разделу [Устранение неполадок](#troubleshooting), если возникнут проблемы.*
*Если ваше оборудование не поддерживает локальный запуск LLM, смотрите [Настройка для работы с API](#setup-to-run-with-an-api).*
*За подробным описанием `config.ini` смотрите [Раздел Конфигурации](#config).*

---

## Настройка для запуска LLM локально на вашем устройстве

**Требования к оборудованию:**

Для локального запуска LLM необходимы соответствующие ресурсы. Минимум — GPU, способный запускать Magistral, Qwen или Deepseek 14B. См. раздел FAQ для рекомендаций по моделям и производительности.

**Настройте локального провайдера**  

Запустите локального провайдера, например с помощью ollama:

```sh
ollama serve
```

См. ниже список поддерживаемых локальных провайдеров.

**Обновите config.ini**

Измените файл config.ini, установив provider_name на поддерживаемого провайдера и provider_model на LLM, поддерживаемую вашим провайдером. Рекомендуем использовать модели рассуждения, такие как *Magistral* или *Deepseek*.

См. **FAQ** в конце README для требований к оборудованию.

```sh
[MAIN]
is_local = True # Локальный запуск или через удалённого провайдера.
provider_name = ollama # или lm-studio, openai и т.д.
provider_model = deepseek-r1:14b # выберите модель, подходящую вашему оборудованию
provider_server_address = 127.0.0.1:11434
agent_name = Jarvis # имя вашего AI
recover_last_session = True # восстанавливать предыдущую сессию
save_session = True # сохранять текущую сессию
speak = False # синтез речи
listen = False # распознавание речи, только для CLI, экспериментально
jarvis_personality = False # использовать стиль личности "Jarvis" (экспериментально)
languages = en zh # список языков, синтез речи по умолчанию на первом в списке
[BROWSER]
headless_browser = True # не меняйте, если не используете CLI на хосте
stealth_mode = True # использовать undetected selenium для уменьшения обнаружения браузера
```

**Внимание**:

- Формат файла `config.ini` не поддерживает комментарии. 
Не копируйте и не вставляйте пример конфигурации напрямую: комментарии вызовут ошибки. Вместо этого вручную измените файл `config.ini`, исключив все комментарии.

- Не указывайте provider_name как `openai`, если используете LM-studio для запуска LLM. Установите `lm-studio`.

- Некоторые провайдеры (например, lm-studio) требуют наличие `http://` перед IP. Например, `http://127.0.0.1:1234`

**Список локальных провайдеров**

| Провайдер   | Локальный? | Описание                                                 |
|-------------|------------|----------------------------------------------------------|
| ollama      | Да         | Запуск LLM локально с помощью ollama как LLM-провайдера  |
| lm-studio   | Да         | Запуск LLM локально с помощью LM studio (установите `provider_name` как `lm-studio`)|
| openai      | Да         | Использование совместимого с openai API (например, сервер llama.cpp)  |

Следующий шаг: [Запуск сервисов и AgenticSeek](#Start-services-and-Run)  

*Смотрите раздел [Устранение неполадок](#troubleshooting), если возникли проблемы.*
*Если ваше оборудование не поддерживает локальный запуск LLM, смотрите [Настройка для работы с API](#setup-to-run-with-an-api).*
*Для подробных объяснений `config.ini` смотрите [Раздел Конфигурации](#config).*

## Настройка для работы с API

В этом режиме используются внешние облачные провайдеры LLM. Вам понадобится API-ключ от выбранного сервиса.

**1. Выберите API-провайдера и получите API-ключ:**

Смотрите [Список API-провайдеров](#list-of-api-providers) ниже. Посетите их сайты, зарегистрируйтесь и получите API-ключ.

**2. Установите свой API-ключ как переменную окружения:**


*   **Linux/macOS:**
    Откройте терминал и используйте команду `export`. Лучше добавить эту команду в профиль оболочки (например, `~/.bashrc`, `~/.zshrc`) для постоянства.
    ```sh
    export PROVIDER_API_KEY="your_api_key_here" 
    # Замените PROVIDER_API_KEY на конкретное имя переменной, например, OPENAI_API_KEY, GOOGLE_API_KEY
    ```
    Пример для TogetherAI:
    ```sh
    export TOGETHER_API_KEY="xxxxxxxxxxxxxxxxxxxxxx"
    ```
*   **Windows:**
*   **Командная строка (Временно для текущей сессии):**
    ```cmd
    set PROVIDER_API_KEY=your_api_key_here
    ```
*   **PowerShell (Временно для текущей сессии):**
    ```powershell
    $env:PROVIDER_API_KEY="your_api_key_here"
    ```
*   **Постоянно:** Найдите "переменные среды" в поисковой строке Windows, нажмите "Изменить системные переменные среды", затем нажмите кнопку "Переменные среды...". Добавьте новую пользовательскую переменную с соответствующим именем (например, `OPENAI_API_KEY`) и вашим ключом в качестве значения.

*(См. FAQ: [Как установить API ключи?](#how-do-i-set-api-keys) для получения подробностей).*

**3. Обновите `config.ini`:**
```ini
[MAIN]
is_local = False
provider_name = openai # Или google, deepseek, togetherAI, huggingface
provider_model = gpt-3.5-turbo # Или gemini-1.5-flash, deepseek-chat, mistralai/Mixtral-8x7B-Instruct-v0.1 и т.д.
provider_server_address = # Обычно игнорируется или может быть оставлен пустым, когда is_local = False для большинства API
# ... другие настройки ...
```
*Внимание:* Убедитесь, что в значениях `config.ini` нет пробелов в конце строк.

**Список API провайдеров**

| Провайдер    | `provider_name` | Локальный? | Описание                                            | Ссылка для получения API ключа                |
|--------------|-----------------|------------|-----------------------------------------------------|-----------------------------------------------|
| OpenAI       | `openai`        | Нет        | Использовать модели ChatGPT через API OpenAI.       | [platform.openai.com/signup](https://platform.openai.com/signup) |
| Google Gemini| `google`        | Нет        | Использовать модели Google Gemini через Google AI Studio. | [aistudio.google.com/keys](https://aistudio.google.com/keys) |
| Deepseek     | `deepseek`      | Нет        | Использовать модели Deepseek через их API.          | [platform.deepseek.com](https://platform.deepseek.com) |
| Hugging Face | `huggingface`   | Нет        | Использовать модели через Hugging Face Inference API.| [huggingface.co/settings/tokens](https://huggingface.co/settings/tokens) |
| TogetherAI   | `togetherAI`    | Нет        | Использовать различные open-source модели через TogetherAI API.| [api.together.ai/settings/api-keys](https://api.together.ai/settings/api-keys) |

*Примечание:*
*   Мы не рекомендуем использовать `gpt-4o` или другие модели OpenAI для сложного веб-сёрфинга и планирования задач, так как текущие оптимизации подсказок ориентированы на модели вроде Deepseek.
*   Задания на программирование/bash могут сталкиваться с ошибками при использовании Gemini, поскольку он может не строго следовать форматированию подсказок, оптимизированных для Deepseek.
*   Параметр `provider_server_address` в `config.ini` обычно не используется, когда `is_local = False`, так как конечная точка API обычно зашита в соответствующей библиотеке провайдера.

Следующий шаг: [Запустите сервисы и AgenticSeek](#Start-services-and-Run)

*См. раздел **Известные проблемы**, если у вас возникают сложности.*

*См. раздел **Config** для подробного объяснения файла конфигурации.*

---

## Запуск сервисов и работа

По умолчанию AgenticSeek полностью запускается в docker.

Запустите необходимые сервисы. Это запустит все сервисы из docker-compose.yml, включая:
    - searxng
    - redis (требуется для searxng)
    - frontend
    - backend (если используется `full`)

```sh
./start_services.sh full # MacOS
start ./start_services.cmd full # Window
```

**Внимание:** На этом этапе будут загружены и распакованы все образы Docker, что может занять до 30 минут. После запуска сервисов дождитесь полной загрузки backend-сервиса (вы должны увидеть **backend: "GET /health HTTP/1.1" 200 OK** в логе) перед отправкой каких-либо сообщений. При первом запуске backend-сервис может запускаться до 5 минут.

Перейдите на `http://localhost:3000/` — вы должны увидеть веб-интерфейс.

*Устранение проблем с запуском сервисов:* Если эти скрипты не срабатывают, убедитесь, что Docker Engine запущен и Docker Compose (V2, `docker compose`) корректно установлен. Проверьте сообщения об ошибках в терминале. См. [FAQ: Помогите! Я получаю ошибку при запуске AgenticSeek или его скриптов.](#faq-troubleshooting)

**Необязательно:** Запуск на хосте (CLI-режим):

Чтобы использовать CLI-интерфейс, необходимо установить пакет на хосте:

```sh
./install.sh
./install.bat # windows
```

Запустите сервисы:

```sh
./start_services.sh # MacOS
start ./start_services.cmd # Window
```

Используйте CLI: `python3 cli.py`

---

## Использование

Убедитесь, что сервисы запущены командой `./start_services.sh full`, и перейдите на `localhost:3000` для доступа к веб-интерфейсу.

Вы также можете использовать преобразование речи в текст, установив `listen = True` в конфиге. Только для CLI-режима.

Для выхода просто скажите/напишите `goodbye`.

Вот несколько примеров использования:

> *Сделай игру "змейка" на python!*

> *Найди лучшие кафе в Ренне (Франция) через интернет и сохрани список из трёх с их адресами в rennes_cafes.txt.*

> *Напиши программу на Go для вычисления факториала числа, сохрани как factorial.go в свою рабочую папку*

> *Найди в папке summer_pictures все файлы JPG, переименуй их с сегодняшней датой и сохрани список переименованных файлов в photos_list.txt*

> *Ищи онлайн популярные научно-фантастические фильмы 2024 года и выбери три для просмотра сегодня вечером. Сохрани список в movie_night.txt.*

> *Найди последние новости об ИИ за 2025 год, выбери три статьи и напиши скрипт на Python для парсинга их заголовков и кратких описаний. Сохрани скрипт как news_scraper.py, а описания в ai_news.txt в /home/projects*

> *В пятницу найди бесплатный API для котировок акций, зарегистрируйся с supersuper7434567@gmail.com, затем напиши скрипт на Python для ежедневного получения цен Tesla по этому API и сохрани результаты в stock_prices.csv*

*Обратите внимание, что заполнение форм пока экспериментальное и может не работать.*

После ввода вашего запроса AgenticSeek выделит для задачи подходящего агента.

Поскольку это ранний прототип, система маршрутизации агентов может не всегда выбирать правильного агента по вашему запросу.

Поэтому старайтесь максимально чётко формулировать, что вы хотите и как AI должен действовать. Например, если вы хотите, чтобы он провёл веб-поиск, не говорите:

`Ты знаешь хорошие страны для одиночных путешествий?`

Вместо этого спросите:

`Сделай веб-поиск и выясни, какие страны лучше всего подходят для одиночных путешествий`

---

## **Настройка для запуска LLM на вашем сервере**  

Если у вас есть мощный компьютер или сервер, который вы хотите использовать удалённо со своего ноутбука, вы можете запустить LLM на удалённом сервере с помощью нашего собственного llm-сервера.

На вашем "сервере", где будет запущена AI-модель, получите IP-адрес

```sh
ip a | grep "inet " | grep -v 127.0.0.1 | awk '{print $2}' | cut -d/ -f1 # локальный ip
curl https://ipinfo.io/ip # публичный ip
```

Примечание: для Windows или macOS используйте соответственно ipconfig или ifconfig для определения IP-адреса.

Клонируйте репозиторий и перейдите в папку `server/`.


```sh
git clone --depth 1 https://github.com/Fosowl/agenticSeek.git
cd agenticSeek/llm_server/
```

Установите специфические для сервера зависимости:

```sh
pip3 install -r requirements.txt
```

Запустите серверный скрипт.

```sh
python3 app.py --provider ollama --port 3333
```

Вы можете выбрать между использованием `ollama` и `llamacpp` как сервиса LLM.


Теперь на вашем персональном компьютере:

Измените файл `config.ini`, чтобы установить `provider_name` в `server` и `provider_model` в `deepseek-r1:xxb`.
Установите `provider_server_address` на IP-адрес машины, где будет запускаться модель.

```sh
[MAIN]
is_local = False
provider_name = server
provider_model = deepseek-r1:70b
provider_server_address = x.x.x.x:3333
```

Следующий шаг: [Запустите сервисы и AgenticSeek](#Start-services-and-Run)  

---

## Преобразование речи в текст

Внимание: функция распознавания речи работает только в CLI-режиме на данный момент.

Обратите внимание, что сейчас речь в текст работает только на английском языке.

Функция распознавания речи по умолчанию отключена. Чтобы включить её, установите опцию listen в True в файле config.ini:

```
listen = True
```

Когда функция включена, перед началом обработки вашего ввода она будет слушать ключевое слово-триггер, которым является имя агента. Вы можете изменить имя агента, изменив значение `agent_name` в файле *config.ini*:

```
agent_name = Friday
```

Для оптимального распознавания рекомендуется использовать распространённое английское имя, например "John" или "Emma", в качестве имени агента.

Как только вы увидите, что транскрипция начала появляться, произнесите имя агента вслух, чтобы разбудить его (например, "Friday").

Чётко озвучьте свой запрос.

Завершите свой запрос подтверждающей фразой, чтобы система приступила к выполнению. Примеры подтверждающих фраз:
```
"do it", "go ahead", "execute", "run", "start", "thanks", "would ya", "please", "okay?", "proceed", "continue", "go on", "do that", "go it", "do you understand?"
```

## Config

Пример конфигурации:
```
[MAIN]
is_local = True
provider_name = ollama
provider_model = deepseek-r1:32b
provider_server_address = http://127.0.0.1:11434 # Пример для Ollama; используйте http://127.0.0.1:1234 для LM-Studio
agent_name = Friday
recover_last_session = False
save_session = False
speak = False
listen = False

jarvis_personality = False
languages = en zh # Список языков для TTS и, возможно, маршрутизации.
[BROWSER]
headless_browser = False
stealth_mode = False
```

**Пояснение к настройкам `config.ini`**:

*   **Раздел `[MAIN]`:**
    *   `is_local`: `True`, если используется локальный LLM-провайдер (Ollama, LM-Studio, локальный сервер совместимый с OpenAI) или опция самостоятельного размещения. `False`, если используется облачный API (OpenAI, Google и др.).
    *   `provider_name`: Указывает провайдера LLM.
        *   Локальные варианты: `ollama`, `lm-studio`, `openai` (для локальных серверов, совместимых с OpenAI), `server` (для самостоятельного размещения).
        *   Варианты API: `openai`, `google`, `deepseek`, `huggingface`, `togetherAI`.
    *   `provider_model`: Конкретное название или ID модели для выбранного провайдера (например, `deepseekcoder:6.7b` для Ollama, `gpt-3.5-turbo` для OpenAI API, `mistralai/Mixtral-8x7B-Instruct-v0.1` для TogetherAI).
    *   `provider_server_address`: Адрес вашего LLM-провайдера.
        *   Для локальных провайдеров: например, `http://127.0.0.1:11434` для Ollama, `http://127.0.0.1:1234` для LM-Studio.
        *   Для типа провайдера `server`: адрес вашего собственного сервера LLM (например, `http://your_server_ip:3333`).
        *   Для облачных API (`is_local = False`): часто игнорируется или может быть пустым, так как конечная точка API обычно обрабатывается клиентской библиотекой.
    *   `agent_name`: Имя AI-ассистента (например, Friday). Используется как ключевое слово для активации распознавания речи, если оно включено.
    *   `recover_last_session`: `True` — попытка восстановить состояние предыдущей сессии, `False` — начать новую.
    *   `save_session`: `True` — сохранить состояние текущей сессии для возможного восстановления, иначе `False`.
    *   `speak`: `True` — включить голосовой вывод (TTS), `False` — отключить.
    *   `listen`: `True` — включить голосовой ввод (распознавание речи, только CLI режим), `False` — отключить.
    *   `work_dir`: **Важное значение:** Каталог, в котором AgenticSeek будет читать и записывать файлы. **Убедитесь, что этот путь существует и доступен на вашей системе.**
    *   `jarvis_personality`: `True` — использовать более "Jarvis-подобный" системный prompt (экспериментально), `False` — стандартный prompt.
    *   `languages`: Перечисление языков через запятую (например, `en, zh, fr`). Используется для выбора голоса TTS (по умолчанию — первый язык) и может помочь маршрутизатору LLM. Не указывайте слишком много или очень похожих языков для эффективности.
*   **Раздел `[BROWSER]`:**
    *   `headless_browser`: `True` — запускать автоматизированный браузер без видимого окна (рекомендуется для веб-интерфейса или неинтерактивного использования). `False` — показать окно браузера (удобно для CLI или отладки).
    *   `stealth_mode`: `True` — включить меры против обнаружения автоматизации браузера. Может потребовать ручной установки расширений, например, anticaptcha.


В этом разделе приводится сводка поддерживаемых типов LLM-провайдеров. Настройте их в `config.ini`.

**Локальные провайдеры (на вашем оборудовании):**

| Имя провайдера в `config.ini` | `is_local` | Описание                                                                  | Раздел настройки                                                    |
|-------------------------------|------------|---------------------------------------------------------------------------|---------------------------------------------------------------------|
| `ollama`                      | `True`     | Использовать Ollama для локального запуска LLM.                           | [Настройка локального LLM](#setup-for-running-llm-locally-on-your-machine) |
| `lm-studio`                   | `True`     | Использовать LM-Studio для локального запуска LLM.                        | [Настройка локального LLM](#setup-for-running-llm-locally-on-your-machine) |
| `openai` (для локального сервера) | `True` | Подключение к локальному серверу с OpenAI-совместимым API (например, llama.cpp). | [Настройка локального LLM](#setup-for-running-llm-locally-on-your-machine) |
| `server`                      | `False`    | Подключение к самостоятельному серверу AgenticSeek LLM на другом устройстве. | [Настройка собственного сервера LLM](#setup-to-run-the-llm-on-your-own-server) |

**API-провайдеры (облачные):**

| Имя провайдера в `config.ini` | `is_local` | Описание                                        | Раздел настройки                                       |
|-------------------------------|------------|--------------------------------------------------|--------------------------------------------------------|
| `openai`                      | `False`    | Использовать официальный API OpenAI (например, GPT-3.5, GPT-4). | [Настройка с API](#setup-to-run-with-an-api)           |
| `google`                      | `False`    | Использовать модели Gemini от Google через API.  | [Настройка с API](#setup-to-run-with-an-api)           |
| `deepseek`                    | `False`    | Использовать официальный API Deepseek.           | [Настройка с API](#setup-to-run-with-an-api)           |
| `huggingface`                 | `False`    | Использовать API Hugging Face Inference.         | [Настройка с API](#setup-to-run-with-an-api)           |
| `togetherAI`                  | `False`    | Использовать API TogetherAI для различных open моделей. | [Настройка с API](#setup-to-run-with-an-api)           |

---
## Поиск и устранение неисправностей

Если вы сталкиваетесь с проблемами, этот раздел поможет вам.

# Известные проблемы

## Проблемы с ChromeDriver

**Пример ошибки:** `SessionNotCreatedException: Message: session not created: This version of ChromeDriver only supports Chrome version XXX`

*   **Причина:** Установленная версия ChromeDriver не совместима с вашей версией браузера Google Chrome.
*   **Решение:**
    1.  **Проверьте версию Chrome:** Откройте Google Chrome, перейдите в `Настройки > О Chrome`, чтобы узнать версию (например, "Версия 120.0.6099.110").
    2.  **Скачайте подходящий ChromeDriver:**
        *   Для версий Chrome 115 и новее: Перейдите на страницу [Chrome for Testing (CfT) JSON Endpoints](https://googlechromelabs.github.io/chrome-for-testing/). Найдите канал "stable" и скачайте ChromeDriver для вашей ОС, соответствующий основной версии Chrome.
        *   Для более старых версий (редко): Попробуйте найти их на странице [ChromeDriver - WebDriver for Chrome](https://chromedriver.chromium.org/downloads).
        *   На изображении ниже показан пример CfT страницы:
            ![Download Chromedriver specific version from Chrome for Testing page](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/media/chromedriver_readme.png)
    3.  **Установите ChromeDriver:**
        *   Убедитесь, что скачанный `chromedriver` (или `chromedriver.exe` на Windows) находится в каталоге, который прописан в переменной PATH вашей системы (например, `/usr/local/bin` на Linux/macOS или папка со скриптами, добавленная в PATH на Windows).
        *   Либо поместите его в корневую папку проекта `agenticSeek`.
        *   Проверьте, что драйвер исполняемый (например, выполните `chmod +x chromedriver` на Linux/macOS).
    4.  Подробнее смотрите в разделе [ChromeDriver Installation](#chromedriver-installation) в основном руководстве по установке.

Если этот раздел неполный или вы столкнулись с другими проблемами ChromeDriver, попробуйте поискать похожие [GitHub Issues](https://github.com/Fosowl/agenticSeek/issues) или создайте новую заявку.

`Exception: Failed to initialize browser: Message: session not created: This version of ChromeDriver only supports Chrome version 113
Current browser version is 134.0.6998.89 with binary path`

Это возникает, если версии браузера и chromedriver не совпадают.

Вам нужно скачать последнюю версию по адресу:

https://developer.chrome.com/docs/chromedriver/downloads

Если вы используете Chrome версии 115 или новее, перейдите по адресу:

https://googlechromelabs.github.io/chrome-for-testing/

И скачайте chromedriver, соответствующий вашей ОС.

![alt text](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/media/chromedriver_readme.png)

Если этот раздел неполный, пожалуйста, создайте issue.

## Проблемы connection adapters

```
Exception: Provider lm-studio failed: HTTP request failed: No connection adapters were found for '127.0.0.1:1234/v1/chat/completions'` (Примечание: порт может отличаться)
```

*   **Причина:** В `provider_server_address` в `config.ini` для `lm-studio` (или других локальных серверов, совместимых с OpenAI) отсутствует префикс `http://` или указан неверный порт.
*   **Решение:**
    *   Убедитесь, что адрес начинается с `http://`. По умолчанию для LM-Studio: `http://127.0.0.1:1234`.
    *   Исправьте `config.ini`: `provider_server_address = http://127.0.0.1:1234` (или ваш реальный порт LM-Studio).

## Не указан базовый URL SearxNG

```
raise ValueError("SearxNG base URL must be provided either as an argument or via the SEARXNG_BASE_URL environment variable.")
ValueError: SearxNG base URL must be provided either as an argument or via the SEARXNG_BASE_URL environment variable.`
```

## FAQ

**В: Какое железо мне нужно?**  

| Размер модели | GPU  | Комментарий                                               |
|--------------|------|-----------------------------------------------------------|
| 7B           | 8ГБ VRAM | ⚠️ Не рекомендуется. Низкая производительность, частые галлюцинации, агенты-планировщики, скорее всего, не будут работать. |
| 14B          | 12ГБ VRAM (например, RTX 3060) | ✅ Подходит для простых задач. Может испытывать трудности с веб-браузингом и планированием. |
| 32B          | 24+ ГБ VRAM (например, RTX 4090) | 🚀 Большинство задач успешно, могут быть сложности с планированием задач. |
| 70B+         | 48+ ГБ VRAM | 💪 Отлично. Рекомендуется для продвинутых сценариев. |

**В: Я получаю ошибку — что делать?**  

Убедитесь, что локальный сервер запущен (`ollama serve`), ваш `config.ini` соответствует провайдеру, и все зависимости установлены. Если ничего не помогает — создайте issue.

**В: Может ли всё работать полностью локально?**  

Да, с провайдерами Ollama, lm-studio или server, все компоненты — распознавание речи, LLM и синтез речи — работают локально. Не локальные варианты (OpenAI или другие API) — опциональны.

**В: Почему стоит использовать AgenticSeek, если есть Manus?**

В отличие от Manus, AgenticSeek ориентирован на независимость от внешних систем, что даёт больше контроля, приватности и позволяет избежать затрат на API.

**В: Кто стоит за проектом?**

Проект создан мной и двумя друзьями, которые также являются мейнтейнерами и контрибьюторами из open-source сообщества на GitHub. Мы — просто группа энтузиастов, не стартап и не связаны с какими-либо организациями.

Любой аккаунт AgenticSeek на X, кроме моего личного (https://x.com/Martin993886460), — это подделка.

## Вклад

Мы ищем разработчиков для улучшения AgenticSeek! Смотрите открытые issue или обсуждения.

[Руководство по вкладу](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/docs/CONTRIBUTING.md)

[![Star History Chart](https://api.star-history.com/svg?repos=Fosowl/agenticSeek&type=Date)](https://www.star-history.com/#Fosowl/agenticSeek&Date)

## Мейнтейнеры:

 > [Fosowl](https://github.com/Fosowl) | Парижское время 

 > [antoineVIVIES](https://github.com/antoineVIVIES) | Тайбэйское время 

 > [steveh8758](https://github.com/steveh8758) | Тайбэйское время 

## Особая благодарность:

 > [tcsenpai](https://github.com/tcsenpai) и [plitc](https://github.com/plitc) за помощь с docker-изация backend

## Спонсоры:

5$ и более — здесь отображаются ежемесячные спонсоры:
- **tatra-labs**

Certainly! Please provide the content for Part 4 of 4 that you would like translated.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-16

---