<img src="https://github.com/user-attachments/assets/47d67430-386d-4675-82ad-d4734d3262d9" width=128 height=128>

# TensorZero

**TensorZero создает цикл обратной связи для оптимизации LLM-приложений — превращая производственные данные в более умные, быстрые и дешевые модели.**

1. Интегрируйте наш шлюз моделей
2. Отправляйте метрики или обратную связь
3. Оптимизируйте промпты, модели и стратегии инференса
4. Наблюдайте, как ваши LLM улучшаются со временем

Это обеспечивает **циклическое обучение и работу с данными для LLM**, объединяя:

- [x] **Инференс:** единый API для всех LLM, с задержкой <1 мс (P99)
- [x] **Наблюдаемость:** инференс и обратная связь → в вашу базу данных
- [x] **Оптимизация:** от промптов до дообучения и RL
- [x] **Оценки:** сравнение промптов, моделей, стратегий инференса
- [x] **Эксперименты:** встроенное A/B тестирование, маршрутизация, фолбэки

---

<p align="center">
  <b><a href="https://www.tensorzero.com/" target="_blank">Веб-сайт</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs" target="_blank">Документация</a></b>
  ·
  <b><a href="https://www.x.com/tensorzero" target="_blank">Twitter</a></b>
  ·
  <b><a href="https://www.tensorzero.com/slack" target="_blank">Slack</a></b>
  ·
  <b><a href="https://www.tensorzero.com/discord" target="_blank">Discord</a></b>
  <br>
  <br>
  <b><a href="https://www.tensorzero.com/docs/quickstart" target="_blank">Быстрый старт (5 минут)</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs/gateway/tutorial" target="_blank">Полный туториал</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs/gateway/deployment" target="_blank">Руководство по развертыванию</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs/gateway/api-reference" target="_blank">API Reference</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs/gateway/deployment" target="_blank">Configuration Reference</a></b>
</p>

---

<table>
  <tr>
    <td width="30%" valign="top"><b>Что такое TensorZero?</b></td>
    <td width="70%" valign="top">TensorZero — это open-source фреймворк для создания LLM-приложений промышленного уровня. Он объединяет шлюз LLM, наблюдаемость, оптимизацию, оценки и проведение экспериментов.</td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>Чем TensorZero отличается от других LLM-фреймворков?</b></td>
    <td width="70%" valign="top">
      1. TensorZero позволяет оптимизировать сложные LLM-приложения на основе производственных метрик и обратной связи от пользователей.<br>
      2. TensorZero поддерживает требования промышленных LLM-приложений: низкая задержка, высокая пропускная способность, строгая типизация, самостоятельное размещение, GitOps, настраиваемость и др.<br>
      3. TensorZero объединяет весь стек LLMOps, создавая кумулятивные преимущества. Например, LLM-оценки могут использоваться для дообучения моделей вместе с AI-судьями.
    </td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>Могу ли я использовать TensorZero с ___?</b></td>
    <td width="70%" valign="top">Да. Поддерживаются все основные языки программирования. Вы можете использовать TensorZero с нашим Python-клиентом, любым OpenAI SDK или нашим HTTP API.</td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>Готов ли TensorZero к промышленному использованию?</b></td>
    <td width="70%" valign="top">Да. Вот кейс: <b><a href="https://www.tensorzero.com/blog/case-study-automating-code-changelogs-at-a-large-bank-with-llms">Автоматизация changelog’ов кода в крупном банке с помощью LLM</a></b></td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>Сколько стоит TensorZero?</b></td>
    <td width="70%" valign="top">Ничего. TensorZero полностью open-source и для самостоятельного размещения. Нет платных функций.</td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>Кто разрабатывает TensorZero?</b></td>
    <td width="70%" valign="top">В нашей технической команде есть бывший мейнтейнер компилятора Rust, исследователи машинного обучения (Stanford, CMU, Oxford, Columbia) с тысячами цитирований, и директор по продукту стартапа-декакорна. Нас поддерживают те же инвесторы, что и ведущие open-source проекты (например, ClickHouse, CockroachDB) и AI-лаборатории (например, OpenAI, Anthropic).</td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>Как начать пользоваться?</b></td>
    <td width="70%" valign="top">Вы можете внедрять TensorZero поэтапно. Наш <b><a href="https://www.tensorzero.com/docs/quickstart">Быстрый старт</a></b> показывает путь от обычного OpenAI-обертки до промышленного LLM-приложения с наблюдаемостью и дообучением всего за 5 минут.</td>
  </tr>
</table>

---

## Возможности

### 🌐 Шлюз LLM

> **Интегрируйтесь с TensorZero один раз и получите доступ ко всем основным LLM-провайдерам.**

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b>Провайдеры моделей</b></td>
    <td width="50%" align="center" valign="middle"><b>Возможности</b></td>
  </tr>
  <tr>
    <td width="50%" align="left" valign="top">
      <p>
        Шлюз TensorZero нативно поддерживает:
      </p>
      <ul>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/anthropic">Anthropic</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/aws-bedrock">AWS Bedrock</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/aws-sagemaker">AWS SageMaker</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/azure">Azure OpenAI Service</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/deepseek">DeepSeek</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/fireworks">Fireworks</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/gcp-vertex-ai-anthropic">GCP Vertex AI Anthropic</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/gcp-vertex-ai-gemini">GCP Vertex AI Gemini</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/google-ai-studio-gemini">Google AI Studio (Gemini API)</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/hyperbolic">Hyperbolic</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/mistral">Mistral</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/openai">OpenAI</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/together">Together</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/vllm">vLLM</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/xai">xAI</a></b></li>
      </ul>
      <p>
        <em>
          Нужен другой провайдер?
          Скорее всего, он поддерживается, потому что TensorZero интегрируется с <b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/openai-compatible">любым OpenAI-совместимым API (например, Ollama)</a></b>.
        </em>
      </p>
    </td>
    <td width="50%" align="left" valign="top">
      <p>
        Шлюз TensorZero поддерживает продвинутые возможности, такие как:
      </p>
      <ul>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/retries-fallbacks">Повторы и фолбэки</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations">Оптимизации времени инференса</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/prompt-templates-schemas">Шаблоны и схемы промптов</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/tutorial#experimentation">Эксперименты (A/B тестирование)</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/configuration-reference">Конфигурация как код (GitOps)</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/batch-inference">Пакетный инференс</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/multimodal-inference">Мультимодальный инференс (VLMs)</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-caching">Кэширование инференса</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/metrics-feedback">Метрики и обратная связь</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/episodes">Многошаговые LLM-процессы (эпизоды)</a></b></li>
        <li><em>и многое другое…</em></li>
      </ul>
      <p>
        Шлюз TensorZero написан на Rust 🦀 с учетом <b>производительности</b> (&lt;1 мс p99 задержки при 10k QPS).
        См. <b><a href="https://www.tensorzero.com/docs/gateway/benchmarks">Бенчмарки</a></b>.<br>
      </p>
      <p>
        Вы можете запускать инференс с помощью <b>клиента TensorZero</b> (рекомендуется), <b>клиента OpenAI</b> или <b>HTTP API</b>.
      </p>
    </td>
  </tr>
</table>

<br>

<details open>
<summary><b>Использование: Python &mdash; Клиент TensorZero (рекомендуется)</b></summary>

Вы можете получить доступ к любому провайдеру через Python-клиент TensorZero.

1. `pip install tensorzero`
2. Опционально: настройте конфигурацию TensorZero.
3. Запустите инференс:

```python
from tensorzero import TensorZeroGateway  # или AsyncTensorZeroGateway


with TensorZeroGateway.build_embedded(clickhouse_url="...", config_file="...") as client:
    response = client.inference(
        model_name="openai::gpt-4o-mini",
        # Можно легко попробовать других провайдеров: "anthropic::claude-3-7-sonnet-20250219"
        input={
            "messages": [
                {
                    "role": "user",
                    "content": "Напиши хайку об искусственном интеллекте.",
                }
            ]
        },
    )
```

Смотрите **[Быстрый старт](https://www.tensorzero.com/docs/quickstart)** для получения дополнительной информации.

</details>

<details>
<summary><b>Использование: Python &mdash; Клиент OpenAI</b></summary>

Вы можете получить доступ к любому провайдеру через Python-клиент OpenAI с TensorZero.

1. `pip install tensorzero`
2. Опционально: настройте конфигурацию TensorZero.
3. Запустите инференс:

```python
from openai import OpenAI  # или AsyncOpenAI
from tensorzero import patch_openai_client

client = OpenAI()
patch_openai_client(
    client,
    clickhouse_url="http://chuser:chpassword@localhost:8123/tensorzero",
    config_file="config/tensorzero.toml",
    async_setup=False,
)

response = client.chat.completions.create(
    model="tensorzero::model_name::openai::gpt-4o-mini",
    # Легко попробуйте других провайдеров: "tensorzero::model_name::anthropic::claude-3-7-sonnet-20250219"
    messages=[
        {
            "role": "user",
            "content": "Напиши хайку об искусственном интеллекте.",
        }
    ],
)
```

Смотрите **[Быстрый старт](https://www.tensorzero.com/docs/quickstart)** для получения дополнительной информации.

</details>

<details>
<summary><b>Использование: JavaScript / TypeScript (Node) &mdash; OpenAI Client</b></summary>

Вы можете получить доступ к любому провайдеру, используя OpenAI Node client с TensorZero.

1. Разверните `tensorzero/gateway` с помощью Docker.
   **[Подробная инструкция →](https://www.tensorzero.com/docs/gateway/deployment)**
2. Настройте конфигурацию TensorZero.
3. Запустите инференс:

```ts
import OpenAI from "openai";

const client = new OpenAI({
  baseURL: "http://localhost:3000/openai/v1",
});

const response = await client.chat.completions.create({
  model: "tensorzero::model_name::openai::gpt-4o-mini",
  // Легко попробуйте других провайдеров: "tensorzero::model_name::anthropic::claude-3-7-sonnet-20250219"
  messages: [
    {
      role: "user",
      content: "Напиши хайку об искусственном интеллекте.",
    },
  ],
});
```

Смотрите **[Быстрый старт](https://www.tensorzero.com/docs/quickstart)** для получения дополнительной информации.

</details>

<details>
<summary><b>Использование: Другие языки и платформы &mdash; HTTP API</b></summary>

TensorZero поддерживает практически любой язык программирования или платформу через HTTP API.

1. Разверните `tensorzero/gateway` с помощью Docker.
   **[Подробная инструкция →](https://www.tensorzero.com/docs/gateway/deployment)**
2. Необязательно: настройте конфигурацию TensorZero.
3. Запустите инференс:

```bash
curl -X POST "http://localhost:3000/inference" \
  -H "Content-Type: application/json" \
  -d '{
    "model_name": "openai::gpt-4o-mini",
    "input": {
      "messages": [
        {
          "role": "user",
          "content": "Напиши хайку об искусственном интеллекте."
        }
      ]
    }
  }'
```

Смотрите **[Быстрый старт](https://www.tensorzero.com/docs/quickstart)** для получения дополнительной информации.

</details>

<br>

### 📈 Оптимизация LLM

> **Отправляйте производственные метрики и обратную связь от пользователей для легкой оптимизации ваших промптов, моделей и стратегий инференса — через UI или программно.**

#### Оптимизация модели

Оптимизируйте закрытые и открытые модели с помощью обучения с учителем (SFT) и обучения с предпочтениями (DPO).

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b>Обучение с учителем &mdash; UI</b></td>
    <td width="50%" align="center" valign="middle"><b>Обучение с предпочтениями (DPO) &mdash; Jupyter Notebook</b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/cf7acf66-732b-43b3-af2a-5eba1ce40f6f"></td>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/a67a0634-04a7-42b0-b934-9130cb7cdf51"></td>
  </tr>
</table>

#### Оптимизация во время инференса

Увеличьте производительность, динамически обновляя ваши промпты с помощью релевантных примеров, объединяя ответы из нескольких инференсов и многое другое.

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#best-of-n-sampling">Best-of-N Sampling</a></b></td>
    <td width="50%" align="center" valign="middle"><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#mixture-of-n-sampling">Mixture-of-N Sampling</a></b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/c0edfa4c-713c-4996-9964-50c0d26e6970"></td>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/75b5bf05-4c1f-43c4-b158-d69d1b8d05be"></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#dynamic-in-context-learning-dicl">Dynamic In-Context Learning (DICL)</a></b></td>
    <td width="50%" align="center" valign="middle"><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#chain-of-thought-cot">Chain-of-Thought (CoT)</a></b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/d8489e92-ce93-46ac-9aab-289ce19bb67d"></td>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/ea13d73c-76a4-4e0c-a35b-0c648f898311" height="320"></td>
  </tr>
</table>

_Скоро будет больше..._

<br>

#### Оптимизация промптов

Оптимизируйте ваши промпты программно с помощью исследовательских техник оптимизации.

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#best-of-n-sampling">MIPROv2</a></b></td>
    <td width="50%" align="center" valign="middle"><b><a href="https://github.com/tensorzero/tensorzero/tree/main/examples/gsm8k-custom-recipe-dspy">Интеграция с DSPy</a></b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/d81a7c37-382f-4c46-840f-e6c2593301db" alt="MIPROv2 diagram"></td>
    <td width="50%" align="center" valign="middle">
      TensorZero поставляется с несколькими рецептами оптимизации, но вы также можете легко создавать свои собственные.
      В этом примере показано, как оптимизировать функцию TensorZero с помощью произвольного инструмента — здесь DSPy, популярной библиотеки для автоматизированной инженерии промптов.
    </td>
  </tr>
</table>

_Скоро будет больше..._

<br>

### 🔍 Наблюдаемость LLM

> **Приближайтесь для отладки отдельных вызовов API или отслеживайте метрики по моделям и промптам с течением времени — всё это с помощью open-source UI TensorZero.**

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b>Наблюдаемость » Инференс</b></td>
    <td width="50%" align="center" valign="middle"><b>Наблюдаемость » Функция</b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/2cc3cc9a-f33f-4e94-b8de-07522326f80a"></td>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/00ae6605-8fa0-4efd-8238-ae8ea589860f"></td>
  </tr>
</table>

<br>

### 📊 Оценки LLM

> **Сравнивайте промпты, модели и стратегии инференса с помощью TensorZero Evaluations — с поддержкой эвристик и судей на базе LLM.**

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b>Оценка » UI</b></td>
    <td width="50%" align="center" valign="middle"><b>Оценка » CLI</b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/f4bf54e3-1b63-46c8-be12-2eaabf615699"></td>
    <td width="50%" align="left" valign="middle">
<pre><code class="language-bash">docker compose run --rm evaluations \
  --evaluation-name extract_data \
  --dataset-name hard_test_cases \
  --variant-name gpt_4o \
  --concurrency 5</code></pre>
<pre><code class="language-bash">Run ID: 01961de9-c8a4-7c60-ab8d-15491a9708e4
Number of datapoints: 100
██████████████████████████████████████ 100/100
exact_match: 0.83 ± 0.03
semantic_match: 0.98 ± 0.01
item_count: 7.15 ± 0.39</code></pre>
    </td>
  </tr>
</table>

## Демонстрация

> **Смотрите, как LLM улучшают извлечение данных в реальном времени с TensorZero!**
>
> **[Динамическое обучение в контексте (DICL)](https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#dynamic-in-context-learning-dicl)** — это мощная оптимизация на этапе инференса, доступная из коробки с TensorZero.
> Она повышает производительность LLM, автоматически включая релевантные исторические примеры в prompt, без необходимости дообучения модели.

https://github.com/user-attachments/assets/4df1022e-886e-48c2-8f79-6af3cdad79cb

## Инженерия LLM с TensorZero

<br>
<p align="center" >
  <a href="https://www.tensorzero.com/docs">
    <picture>
      <source media="(prefers-color-scheme: light)" srcset="https://github.com/user-attachments/assets/34a92c18-242e-4d76-a99c-861283de68a6">
      <source media="(prefers-color-scheme: dark)" srcset="https://github.com/user-attachments/assets/e8bc699b-6378-4c2a-9cc1-6d189025e270">
      <img alt="TensorZero Flywheel" src="https://github.com/user-attachments/assets/34a92c18-242e-4d76-a99c-861283de68a6" width=720>
    </picture>
  </a>
</p>
<br>

1. **[TensorZero Gateway](https://www.tensorzero.com/docs/gateway/)** — это высокопроизводительный шлюз моделей, написанный на Rust 🦀, который предоставляет унифицированный API-интерфейс для всех основных LLM-провайдеров, обеспечивая бесшовную интеграцию между платформами и резервирование.
2. Он поддерживает структурированный инференс на основе схем с задержкой &lt;1мс P99 (см. **[Бенчмарки](https://www.tensorzero.com/docs/gateway/benchmarks)**), а также встроенную наблюдаемость, эксперименты и **[оптимизации на этапе инференса](https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations)**.
3. Также осуществляется сбор downstream-метрик и обратной связи, связанных с этими инференсами, с полноценной поддержкой многошаговых LLM-систем.
4. Все хранится в хранилище данных ClickHouse, которое вы контролируете, для получения масштабируемой, быстрой и удобной для разработчика аналитики в реальном времени.
5. Со временем **[TensorZero Recipes](https://www.tensorzero.com/docs/recipes)** используют этот структурированный датасет для оптимизации ваших prompt'ов и моделей: запускайте готовые решения для типовых рабочих процессов, таких как дообучение, или создавайте свои собственные — с полной свободой на любом языке и платформе.
6. Наконец, функции экспериментов шлюза и GitOps-оркестрация позволяют вам с уверенностью итерационно улучшать и внедрять решения — будь то одна LLM или тысячи LLM.

Наша цель — помочь инженерам строить, управлять и оптимизировать новое поколение LLM-приложений: системы, которые учатся на реальном опыте.
Подробнее о нашем **[видении и дорожной карте](https://www.tensorzero.com/docs/vision-roadmap/)**.

## Начало работы

**Начните строить уже сегодня.**
**[Быстрый старт](https://www.tensorzero.com/docs/quickstart)** покажет, как легко развернуть LLM-приложение с TensorZero.
Если хотите погрузиться глубже, **[Туториал](https://www.tensorzero.com/docs/gateway/tutorial)** научит, как собрать простого чат-бота, почтового копилота, систему погодного RAG и pipeline для структурированного извлечения данных.

**Есть вопросы?**
Пишите нам в **[Slack](https://www.tensorzero.com/slack)** или **[Discord](https://www.tensorzero.com/discord)**.

**Используете TensorZero на работе?**
Пишите на **[hello@tensorzero.com](mailto:hello@tensorzero.com)**, чтобы бесплатно создать Slack или Teams-канал для вашей команды.

**Работайте с нами.**
Мы **[ищем сотрудников в Нью-Йорке](https://www.tensorzero.com/jobs)**.
Также будем рады **[open-source вкладам](https://github.com/tensorzero/tensorzero/blob/main/CONTRIBUTING.md)**!

## Примеры

Мы работаем над серией **полных исполняемых примеров**, иллюстрирующих работу с данными и обучением в TensorZero.

> **[Оптимизация извлечения данных (NER) с TensorZero](https://github.com/tensorzero/tensorzero/tree/main/examples/data-extraction-ner)**
>
> В этом примере показано, как использовать TensorZero для оптимизации pipeline извлечения данных.
> Мы демонстрируем такие техники, как дообучение и динамическое обучение в контексте (DICL).
> В итоге оптимизированная модель GPT-4o Mini превосходит GPT-4o в этой задаче — при меньших затратах и задержках — используя небольшой объем обучающих данных.

> **[Agentic RAG — Многошаговые ответы на вопросы с LLM](https://github.com/tensorzero/tensorzero/tree/main/examples/rag-retrieval-augmented-generation/simple-agentic-rag/)**
>
> В этом примере показано, как построить многошагового retrieval-агента с помощью TensorZero.
> Агент итеративно ищет информацию в Википедии и сам решает, когда у него достаточно контекста для ответа на сложный вопрос.

> **[Написание хайку для судьи со скрытыми предпочтениями](https://github.com/tensorzero/tensorzero/tree/main/examples/haiku-hidden-preferences)**
>
> В этом примере GPT-4o Mini дообучается генерировать хайку под определенный вкус.
> Вы увидите работу "data flywheel in a box" TensorZero: лучшие варианты приводят к лучшим данным, а лучшие данные — к лучшим вариантам.
> Вы увидите прогресс при многократном дообучении LLM.

> **[Улучшение шахматных навыков LLM с помощью Best-of-N Sampling](https://github.com/tensorzero/tensorzero/tree/main/examples/chess-puzzles/)**
>
> Этот пример показывает, как best-of-N sampling может значительно повысить шахматные способности LLM, выбирая наиболее перспективные ходы из нескольких сгенерированных вариантов.

> **[Улучшение математических рассуждений с помощью кастомного recipe для автоматизированной инженерии prompt'ов (DSPy)](https://github.com/tensorzero/tensorzero/tree/main/examples/gsm8k-custom-recipe-dspy)**
>
> TensorZero предоставляет ряд готовых рецептов оптимизации для стандартных инженерных рабочих процессов LLM.
> Но вы также можете легко создавать собственные рецепты и workflow!
> В этом примере показано, как оптимизировать функцию TensorZero с помощью любого инструмента — здесь, DSPy.

_& многие другие уже на подходе!_

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---