# ProxyAsLocalModel

Проксирование удалённого LLM API как локальной модели. Особенно полезно для использования пользовательских LLM в JetBrains AI Assistant.

Работает на базе Ktor и kotlinx.serialization. Спасибо их безрефлексивным возможностям.

## История этого проекта

В настоящее время JetBrains AI Assistant предоставляет бесплатный тариф с очень ограниченными квотами. Я попробовал, и моя квота быстро закончилась.

Я уже приобрёл токены других LLM API, таких как Gemini и Qwen. Поэтому я задумался об их использовании в AI Assistant. К сожалению, поддерживаются только локальные модели из LM Studio и Ollama. Поэтому я начал работать над этим прокси-приложением, которое проксирует сторонние LLM API как API LM Studio и Ollama, чтобы я мог использовать их в своих IDE от JetBrains.

Это довольно простая задача, поэтому я начал использовать официальные SDK в качестве клиентов и написал простой сервер на Ktor, предоставляющий эндпоинты, как у LM Studio и Ollama. Проблема возникла, когда я попытался распространить это приложение в виде нативного образа GraalVM. Официальные Java SDK используют слишком много динамических функций, что затрудняет компиляцию в нативный образ, даже с использованием tracing agent. Поэтому я решил самостоятельно реализовать простой клиент для streaming chat completion API на Ktor и kotlinx.serialization, которые оба не используют рефлексию, функциональны и поддерживают стиль DSL.

Как видите, это приложение распространяется как fat runnable jar и как нативный образ GraalVM, что делает его кроссплатформенным и быстрым при запуске.

Разработка этого приложения укрепила мою уверенность в Kotlin/Ktor/kotlinx.serialization. В мире Kotlin больше функционального программирования и меньше рефлексии, что делает его более подходящим для GraalVM native image, с более быстрым запуском и меньшим потреблением памяти.

## В настоящее время поддерживается

Проксирование из: OpenAI, Claude, DashScope(Alibaba Qwen), Gemini, Deepseek, Mistral, SiliconFlow.

Проксирование как: LM Studio, Ollama.

Только streaming chat completion API.
## Как использовать

Это приложение является прокси-сервером, распространяется в виде fat-jar, готового к запуску, и нативного образа GraalVM (Windows x64).

Запустите приложение, и вы увидите сообщение справки:

```
2025-05-02 10:43:53 INFO  Help - Похоже, вы запускаете программу здесь впервые.
2025-05-02 10:43:53 INFO  Help - Файл конфигурации по умолчанию создан по адресу your_path\config.yml с аннотациями схемы.
2025-05-02 10:43:53 INFO  Config - Наблюдение за файлом конфигурации начато по адресу your_path\config.yml
2025-05-02 10:43:53 INFO  LM Studio Server - LM Studio Server запущен на порту 1234
2025-05-02 10:43:53 INFO  Ollama Server - Ollama Server запущен на порту 11434
2025-05-02 10:43:53 INFO  Model List - Список моделей загружен: []
```

Затем вы можете отредактировать файл конфигурации для настройки вашего прокси-сервера.

## Файл конфигурации

Этот файл конфигурации автоматически перезагружается при изменении. Будут обновлены только затронутые части сервера.

При первом создании файла конфигурации он будет сгенерирован с аннотациями схемы. Это обеспечит автодополнение и проверку в вашем редакторе.
## Пример файла конфигурации

```yaml
# $schema: https://github.com/Stream29/ProxyAsLocalModel/raw/master/config_v3.schema.json
lmStudio:
  port: 1234 # Это значение по умолчанию
  enabled: true # Это значение по умолчанию
  host: 0.0.0.0 # Это значение по умолчанию
  path: /your/path # Будет добавлен перед исходными конечными точками, значение по умолчанию — пустое
ollama:
  port: 11434 # Это значение по умолчанию
  enabled: true # Это значение по умолчанию
  host: 0.0.0.0 # Это значение по умолчанию
  path: /your/path # Будет добавлен перед исходными конечными точками, значение по умолчанию — пустое
client:
  socketTimeout: 1919810 # Long.MAX_VALUE по умолчанию, в миллисекундах
  connectionTimeout: 1919810 # Long.MAX_VALUE по умолчанию, в миллисекундах
  requestTimeout: 1919810 # Long.MAX_VALUE по умолчанию, в миллисекундах
  retry: 3 # Это значение по умолчанию
  delayBeforeRetry: 1000 # Это значение по умолчанию, в миллисекундах

apiProviders:
  OpenAI:
    type: OpenAi
    baseUrl: https://api.openai.com/v1
    apiKey: <your_api_key>
    modelList:
      - gpt-4o
  Claude:
    type: Claude
    apiKey: <your_api_key>
    modelList:
      - claude-3-7-sonnet
  Qwen:
    type: DashScope
    apiKey: <your_api_key>
    modelList: # Это значение по умолчанию
      - qwen-max
      - qwen-plus
      - qwen-turbo
      - qwen-long
  DeepSeek:
    type: DeepSeek
    apiKey: <your_api_key>
    modelList: # Это значение по умолчанию
      - deepseek-chat
      - deepseek-reasoner
  Mistral:
    type: Mistral
    apiKey: <your_api_key>
    modelList: # Это значение по умолчанию
      - codestral-latest
      - mistral-large
  SiliconFlow:
    type: SiliconFlow
    apiKey: <your_api_key>
    modelList:
      - Qwen/Qwen3-235B-A22B
      - Pro/deepseek-ai/DeepSeek-V3
      - THUDM/GLM-4-32B-0414
  OpenRouter:
    type: OpenRouter
    apiKey: <your_api_key>
    modelList:
      - openai/gpt-4o
  Gemini:
    type: Gemini
    apiKey: <your_api_key>
    modelList:
      - gemini-2.5-flash-preview-04-17
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-10

---