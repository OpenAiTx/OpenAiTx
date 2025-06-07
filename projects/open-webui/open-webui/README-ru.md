# Open WebUI 👋

![GitHub stars](https://img.shields.io/github/stars/open-webui/open-webui?style=social)
![GitHub forks](https://img.shields.io/github/forks/open-webui/open-webui?style=social)
![GitHub watchers](https://img.shields.io/github/watchers/open-webui/open-webui?style=social)
![GitHub repo size](https://img.shields.io/github/repo-size/open-webui/open-webui)
![GitHub language count](https://img.shields.io/github/languages/count/open-webui/open-webui)
![GitHub top language](https://img.shields.io/github/languages/top/open-webui/open-webui)
![GitHub last commit](https://img.shields.io/github/last-commit/open-webui/open-webui?color=red)
[![Discord](https://img.shields.io/badge/Discord-Open_WebUI-blue?logo=discord&logoColor=white)](https://discord.gg/5rJgQTnV4s)
[![](https://img.shields.io/static/v1?label=Sponsor&message=%E2%9D%A4&logo=GitHub&color=%23fe8e86)](https://github.com/sponsors/tjbck)

**Open WebUI — это [расширяемая](https://docs.openwebui.com/features/plugin/), многофункциональная и удобная для пользователя саморазвёртываемая AI-платформа, предназначенная для полностью оффлайн работы.** Поддерживает различные LLM-раннеры, такие как **Ollama** и **OpenAI-совместимые API**, а также имеет **встроенный механизм вывода** для RAG, что делает её **мощным решением для развертывания ИИ**.

![Open WebUI Demo](./demo.gif)

> [!TIP]  
> **Ищете [корпоративный план](https://docs.openwebui.com/enterprise)?** – **[Свяжитесь с нашей командой продаж уже сегодня!](mailto:sales@openwebui.com)**
>
> Получите **расширенные возможности**, включая **кастомизацию тем и брендирования**, **поддержку SLA**, **версии с длительной поддержкой (LTS)** и многое другое!

Для получения дополнительной информации обязательно ознакомьтесь с нашей [документацией Open WebUI](https://docs.openwebui.com/).

## Ключевые возможности Open WebUI ⭐

- 🚀 **Лёгкая установка**: Простой запуск с помощью Docker или Kubernetes (kubectl, kustomize или helm) для беспроблемного опыта с поддержкой образов с тегами `:ollama` и `:cuda`.

- 🤝 **Интеграция Ollama/OpenAI API**: Легко интегрируйте OpenAI-совместимые API для гибких диалогов наряду с моделями Ollama. Настраивайте URL OpenAI API для связи с **LMStudio, GroqCloud, Mistral, OpenRouter и другими**.

- 🛡️ **Гибкие разрешения и пользовательские группы**: Администраторы могут создавать детализированные роли и права пользователей, обеспечивая безопасную среду. Такая детализация повышает безопасность и позволяет индивидуализировать пользовательский опыт, способствуя вовлечённости и ответственности.

- 📱 **Адаптивный дизайн**: Наслаждайтесь удобством на ПК, ноутбуке и мобильных устройствах.

- 📱 **Прогрессивное веб-приложение (PWA) для мобильных**: Ощутите работу как в нативном приложении с возможностью оффлайн-доступа по localhost и удобным интерфейсом.

- ✒️🔢 **Полная поддержка Markdown и LaTeX**: Улучшайте взаимодействие с LLM с помощью расширенных возможностей Markdown и LaTeX.

- 🎤📹 **Голосовые/видеозвонки без рук**: Бесшовная коммуникация благодаря интегрированным функциям голосовых и видеозвонков, делая чат более динамичным и интерактивным.

- 🛠️ **Конструктор моделей**: Лёгкое создание моделей Ollama через веб-интерфейс. Создавайте и добавляйте кастомных персонажей/агентов, настраивайте элементы чата и импортируйте модели через интеграцию с [Open WebUI Community](https://openwebui.com/).

- 🐍 **Встроенный инструмент вызова Python-функций**: Расширяйте LLM с помощью встроенного редактора кода. Подключайте свои чистые Python-функции (BYOF), обеспечивая лёгкую интеграцию с LLM.

- 📚 **Локальная интеграция RAG**: Новое поколение чатов с поддержкой Retrieval Augmented Generation (RAG). Интегрируйте работу с документами прямо в чат — загружайте документы или добавляйте их в библиотеку и получайте доступ с помощью команды `#` перед запросом.

- 🔍 **Веб-поиск для RAG**: Выполняйте поиск в интернете через провайдеров, таких как `SearXNG`, `Google PSE`, `Brave Search`, `serpstack`, `serper`, `Serply`, `DuckDuckGo`, `TavilySearch`, `SearchApi` и `Bing`, и внедряйте результаты прямо в чат.

- 🌐 **Возможность веб-браузинга**: Встраивайте веб-сайты в чат, используя команду `#`, за которой следует URL. Это расширяет ваши диалоги и делает их богаче.

- 🎨 **Интеграция генерации изображений**: Лёгкое добавление генерации изображений через API AUTOMATIC1111 или ComfyUI (локально), а также DALL-E от OpenAI (внешне), что обогащает чат визуальным контентом.

- ⚙️ **Многомодельные диалоги**: Общайтесь одновременно с несколькими моделями, используя их уникальные преимущества для оптимальных ответов.

- 🔐 **Контроль доступа на основе ролей (RBAC)**: Безопасный доступ с ограниченными правами; доступ к Ollama и создание/загрузка моделей разрешены только администраторам.

- 🌐🌍 **Мультиязычная поддержка**: Используйте Open WebUI на предпочитаемом языке благодаря поддержке i18n. Присоединяйтесь к развитию новых языков! Мы ищем контрибьюторов!

- 🧩 **Пайплайны, поддержка плагинов Open WebUI**: Интегрируйте пользовательскую логику и Python-библиотеки с помощью [Pipelines Plugin Framework](https://github.com/open-webui/pipelines). Запустите свой экземпляр Pipelines, укажите URL OpenAI как URL Pipelines и открывайте новые возможности. [Примеры](https://github.com/open-webui/pipelines/tree/main/examples): **Function Calling**, **ограничение скорости** пользователей, **мониторинг использования** (например, через Langfuse), **живой перевод с LibreTranslate** для мультиязычной поддержки, **фильтрация токсичных сообщений** и многое другое.

- 🌟 **Постоянные обновления**: Мы регулярно улучшаем Open WebUI, добавляя новые функции и исправления.

Хотите узнать больше о возможностях Open WebUI? Ознакомьтесь с [документацией Open WebUI](https://docs.openwebui.com/features) для полного обзора!

## Спонсоры 🙌

#### Emerald

<table>
  <tr>
    <td>
      <a href="https://n8n.io/" target="_blank">
        <img src="https://docs.openwebui.com/sponsors/logos/n8n.png" alt="n8n" style="width: 8rem; height: 8rem; border-radius: .75rem;" />
      </a>
    </td>
    <td>
      N8N • Есть ли у вашего интерфейса бэкенд?<br>Попробуйте <a href="https://n8n.io/">n8n</a>
    </td>
  </tr>
  <tr>
    <td>
      <a href="https://warp.dev/open-webui" target="_blank">
        <img src="https://docs.openwebui.com/sponsors/logos/warp.png" alt="n8n" style="width: 8rem; height: 8rem; border-radius: .75rem;" />
      </a>
    </td>
    <td>
      <a href="https://warp.dev/open-webui">Warp</a> • Интеллектуальный терминал для разработчиков
    </td>
  </tr>
</table>

---

Мы чрезвычайно благодарны нашим спонсорам за щедрую поддержку. Их вклад позволяет нам поддерживать и развивать проект, обеспечивая качество для нашего сообщества. Спасибо!

## Как установить 🚀

### Установка через Python pip 🐍

Open WebUI можно установить с помощью pip, менеджера пакетов Python. Перед установкой убедитесь, что используете **Python 3.11** для предотвращения проблем с совместимостью.

1. **Установите Open WebUI**:
   Откройте терминал и выполните следующую команду:

   ```bash
   pip install open-webui
   ```

2. **Запуск Open WebUI**:
   После установки запустите Open WebUI командой:

   ```bash
   open-webui serve
   ```

Это запустит сервер Open WebUI, доступный по адресу [http://localhost:8080](http://localhost:8080)

### Быстрый старт с Docker 🐳

> [!NOTE]  
> В некоторых Docker-средах может потребоваться дополнительная настройка. Если возникли проблемы с подключением, обратитесь к подробной инструкции в [документации Open WebUI](https://docs.openwebui.com/).

> [!WARNING]
> При установке Open WebUI через Docker обязательно добавьте `-v open-webui:/app/backend/data` в команду. Это важно для правильного монтирования базы данных и предотвращения потери данных.

> [!TIP]  
> Для использования Open WebUI с Ollama или ускорением CUDA рекомендуем использовать официальные образы с тегами `:cuda` или `:ollama`. Для активации CUDA установите [Nvidia CUDA container toolkit](https://docs.nvidia.com/dgx/nvidia-container-runtime-upgrade/) на вашем Linux/WSL.

### Установка с настройками по умолчанию

- **Если Ollama установлена на вашем компьютере**, используйте команду:

  ```bash
  docker run -d -p 3000:8080 --add-host=host.docker.internal:host-gateway -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:main
  ```

- **Если Ollama на другом сервере**, используйте команду:

  Для подключения к Ollama на другом сервере укажите URL сервера в переменной `OLLAMA_BASE_URL`:

  ```bash
  docker run -d -p 3000:8080 -e OLLAMA_BASE_URL=https://example.com -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:main
  ```

- **Для запуска Open WebUI с поддержкой Nvidia GPU**, используйте команду:

  ```bash
  docker run -d -p 3000:8080 --gpus all --add-host=host.docker.internal:host-gateway -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:cuda
  ```

### Установка только для использования OpenAI API

- **Если вы используете только OpenAI API**, используйте команду:

  ```bash
  docker run -d -p 3000:8080 -e OPENAI_API_KEY=your_secret_key -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:main
  ```

### Установка Open WebUI с интегрированной поддержкой Ollama

Этот способ использует один контейнер, объединяющий Open WebUI и Ollama, что позволяет быстро развернуть всё одной командой. Выберите подходящую команду для вашего оборудования:

- **С поддержкой GPU**:
  Используйте ресурсы GPU с помощью команды:

  ```bash
  docker run -d -p 3000:8080 --gpus=all -v ollama:/root/.ollama -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:ollama
  ```

- **Только CPU**:
  Если не используете GPU, выполните:

  ```bash
  docker run -d -p 3000:8080 -v ollama:/root/.ollama -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:ollama
  ```

Обе команды обеспечивают простую установку Open WebUI и Ollama, позволяя быстро приступить к работе.

После установки доступ к Open WebUI осуществляется по адресу [http://localhost:3000](http://localhost:3000). Приятной работы! 😄

### Другие способы установки

Доступны и другие способы установки: нативная (без Docker), Docker Compose, Kustomize, Helm. Посетите нашу [документацию Open WebUI](https://docs.openwebui.com/getting-started/) или присоединяйтесь к нашему [Discord-сообществу](https://discord.gg/5rJgQTnV4s) для подробной поддержки.

### Решение проблем

Возникли проблемы с подключением? Ознакомьтесь с разделом [Решение проблем](https://docs.openwebui.com/troubleshooting/) в нашей документации. Для дополнительной помощи и общения присоединяйтесь к [Open WebUI Discord](https://discord.gg/5rJgQTnV4s).

#### Open WebUI: ошибка соединения с сервером

Если возникли проблемы с подключением, чаще всего это связано с тем, что docker-контейнер WebUI не может достичь сервера Ollama по адресу 127.0.0.1:11434 (host.docker.internal:11434) внутри контейнера. Используйте флаг `--network=host` в команде docker для решения. При этом порт изменится с 3000 на 8080, то есть ссылка будет: `http://localhost:8080`.

**Пример команды Docker**:

```bash
docker run -d --network=host -v open-webui:/app/backend/data -e OLLAMA_BASE_URL=http://127.0.0.1:11434 --name open-webui --restart always ghcr.io/open-webui/open-webui:main
```

### Обновление Docker-установки

Для обновления локальной установки до последней версии используйте [Watchtower](https://containrrr.dev/watchtower/):

```bash
docker run --rm --volume /var/run/docker.sock:/var/run/docker.sock containrrr/watchtower --run-once open-webui
```

В конце команды замените `open-webui` на имя вашего контейнера, если оно другое.

Смотрите наше руководство по обновлению в [документации Open WebUI](https://docs.openwebui.com/getting-started/updating).

### Использование ветки dev 🌙

> [!WARNING]
> Ветка `:dev` содержит последние нестабильные функции и изменения. Используйте на свой страх и риск — возможны баги или незавершённые функции.

Если хотите протестировать самые свежие функции и готовы к возможной нестабильности, используйте тег `:dev`:

```bash
docker run -d -p 3000:8080 -v open-webui:/app/backend/data --name open-webui --add-host=host.docker.internal:host-gateway --restart always ghcr.io/open-webui/open-webui:dev
```

### Оффлайн-режим

Для запуска Open WebUI в оффлайн-среде установите переменную окружения `HF_HUB_OFFLINE` в `1`, чтобы предотвратить загрузку моделей из интернета.

```bash
export HF_HUB_OFFLINE=1
```

## Что дальше? 🌟

Изучите планы по развитию в [дорожной карте Open WebUI](https://docs.openwebui.com/roadmap/).

## Лицензия 📜

Этот проект распространяется по лицензии [Open WebUI License](LICENSE), модифицированной BSD-3-Clause. Вы получаете все права классической BSD-3: можно использовать, изменять и распространять ПО, включая коммерческое применение, с минимальными ограничениями. Единственное дополнительное требование — сохранять брендинг "Open WebUI", как описано в файле LICENSE. Полные условия — в [LICENSE](LICENSE). 📄

## Поддержка 💬

Есть вопросы, предложения или нужна помощь? Откройте issue или присоединяйтесь к нашему
[Discord-сообществу Open WebUI](https://discord.gg/5rJgQTnV4s), чтобы связаться с нами! 🤝

## История звёзд

<a href="https://star-history.com/#open-webui/open-webui&Date">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=open-webui/open-webui&type=Date&theme=dark" />
    <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=open-webui/open-webui&type=Date" />
    <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=open-webui/open-webui&type=Date" />
  </picture>
</a>

---

Создано [Timothy Jaeryang Baek](https://github.com/tjbck) — вместе сделаем Open WebUI ещё лучше! 💪

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---