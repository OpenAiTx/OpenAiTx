<p align="right">
   <strong>English</strong> | <a href="https://raw.githubusercontent.com/Portkey-AI/gateway/main/.github/README.cn.md">中文</a> | <a href="https://raw.githubusercontent.com/Portkey-AI/gateway/main/.github/README.jp.md">日本語</a>
</p>

<div align="center">

<a href="https://portkey.sh/report-github"><img src="https://raw.githubusercontent.com/siddharthsambharia-portkey/Portkey-Product-Images/refs/heads/main/LLM%20Report%20Campaign%20Frame.png"></img></a>
<br>

# AI Gateway
#### Маршрутизация к 250+ LLM через один быстрый и удобный API

<img src="https://cfassets.portkey.ai/sdk.gif" width="550px" alt="Демонстрация возможностей маршрутизации LLM в Portkey AI Gateway" style="margin-left:-35px">

[Документация](https://portkey.wiki/gh-1) | [Для предприятий](https://portkey.wiki/gh-2) | [Облачный шлюз](https://portkey.wiki/gh-3) | [Изменения](https://portkey.wiki/gh-4) | [API Reference](https://portkey.wiki/gh-5)


[![Лицензия](https://img.shields.io/github/license/Ileriayo/markdown-badges)](https://raw.githubusercontent.com/Portkey-AI/gateway/main/LICENSE)
[![Discord](https://img.shields.io/discord/1143393887742861333)](https://portkey.wiki/gh-6)
[![Twitter](https://img.shields.io/twitter/url/https/twitter/follow/portkeyai?style=social&label=Follow%20%40PortkeyAI)](https://portkey.wiki/gh-7)
[![npm версия](https://badge.fury.io/js/%40portkey-ai%2Fgateway.svg)](https://portkey.wiki/gh-8)
[![Better Stack Badge](https://uptime.betterstack.com/status-badges/v1/monitor/q94g.svg)](https://portkey.wiki/gh-9)

<a href="https://us-east-1.console.aws.amazon.com/cloudformation/home?region=us-east-1#/stacks/quickcreate?stackName=portkey-gateway&templateURL=https://portkey-gateway-ec2-quicklaunch.s3.us-east-1.amazonaws.com/portkey-gateway-ec2-quicklaunch.template.yaml"><img src="https://img.shields.io/badge/Deploy_to_EC2-232F3E?style=for-the-badge&logo=amazonwebservices&logoColor=white" alt="Deploy to AWS EC2" width="105"/></a> [![Ask DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/Portkey-AI/gateway)
</div>

<br/>

[**AI Gateway**](https://portkey.wiki/gh-10) предназначен для быстрой, надежной и безопасной маршрутизации к более чем 1600 языковым, визуальным, аудио- и имидж-моделям. Это легковесное, с открытым исходным кодом и готовое к корпоративному внедрению решение, позволяющее интегрироваться с любой языковой моделью менее чем за 2 минуты.

- [x] **Молниеносно быстрый** (<1мс задержка) и очень компактный (122 Кб)
- [x] **Проверен в бою**, обрабатывает более 10 млрд токенов ежедневно
- [x] **Готов для предприятий** — повышенная безопасность, масштабируемость и кастомные развертывания

<br>

#### Что можно сделать с AI Gateway?
- Интеграция с любым LLM менее чем за 2 минуты — [Быстрый старт](#quickstart-2-mins)
- Предотвращайте простои с помощью **[автоматических повторов](https://portkey.wiki/gh-11)** и **[резервирования](https://portkey.wiki/gh-12)**
- Масштабируйте AI-приложения с помощью **[балансировки нагрузки](https://portkey.wiki/gh-13)** и **[условной маршрутизации](https://portkey.wiki/gh-14)**
- Защитите свои AI-развертывания с помощью **[защитных ограничений](https://portkey.wiki/gh-15)**
- Используйте не только текст, но и **[мультимодальные возможности](https://portkey.wiki/gh-16)**
- Исследуйте интеграции **[агентных рабочих процессов](https://portkey.wiki/gh-17)**

<br><br>

> [!TIP]
> Поставьте звезду этому репозиторию — это поможет другим разработчикам узнать об AI Gateway 🙏🏻
>
> ![star-2](https://github.com/user-attachments/assets/53597dce-6333-4ecc-a154-eb05532954e4)
> 
<br>


<br>

## Быстрый старт (2 минуты)

### 1. Установите AI Gateway

```bash
# Запустите шлюз локально (нужны Node.js и npm)
npx @portkey-ai/gateway
```
> Шлюз работает по адресу `http://localhost:8787/v1`
> 
> Консоль шлюза доступна по адресу `http://localhost:8787/public/`

<sup>
Руководства по развертыванию:
&nbsp; <a href="https://portkey.wiki/gh-18"><img height="12" width="12" src="https://cfassets.portkey.ai/logo/dew-color.svg" /> Portkey Cloud (рекомендуется)</a>
&nbsp; <a href="https://raw.githubusercontent.com/Portkey-AI/gateway/main/docs/installation-deployments.md#docker"><img height="12" width="12" src="https://cdn.simpleicons.org/docker/3776AB" /> Docker</a>
&nbsp; <a href="https://raw.githubusercontent.com/Portkey-AI/gateway/main/docs/installation-deployments.md#nodejs-server"><img height="12" width="12" src="https://cdn.simpleicons.org/node.js/3776AB" /> Node.js</a>
&nbsp; <a href="https://raw.githubusercontent.com/Portkey-AI/gateway/main/docs/installation-deployments.md#cloudflare-workers"><img height="12" width="12" src="https://cdn.simpleicons.org/cloudflare/3776AB" /> Cloudflare</a>
&nbsp; <a href="https://raw.githubusercontent.com/Portkey-AI/gateway/main/docs/installation-deployments.md#replit"><img height="12" width="12" src="https://cdn.simpleicons.org/replit/3776AB" /> Replit</a>
&nbsp; <a href="https://raw.githubusercontent.com/Portkey-AI/gateway/main/docs/installation-deployments.md"> Другие...</a>

</sup>

### 2. Отправьте первый запрос

<!-- <details open>
<summary>Python Example</summary> -->
```python
# pip install -qU portkey-ai

from portkey_ai import Portkey

# Клиент совместимый с OpenAI
client = Portkey(
    provider="openai", # или 'anthropic', 'bedrock', 'groq' и др.
    Authorization="sk-***" # API-ключ от провайдера
)

# Отправьте запрос через ваш AI Gateway
client.chat.completions.create(
    messages=[{"role": "user", "content": "What's the weather like?"}],
    model="gpt-4o-mini"
)
```



<sup>Поддерживаемые библиотеки:
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/javascript/3776AB" /> JS](https://portkey.wiki/gh-19)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/python/3776AB" /> Python](https://portkey.wiki/gh-20)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/gnubash/3776AB" /> REST](https://portkey.sh/gh-84)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/openai/3776AB" /> OpenAI SDKs](https://portkey.wiki/gh-21)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/langchain/3776AB" /> Langchain](https://portkey.wiki/gh-22)
&nbsp; [LlamaIndex](https://portkey.wiki/gh-23)
&nbsp; [Autogen](https://portkey.wiki/gh-24)
&nbsp; [CrewAI](https://portkey.wiki/gh-25)
&nbsp; [Еще..](https://portkey.wiki/gh-26)
</sup>

В консоли шлюза (`http://localhost:8787/public/`) вы можете видеть все ваши локальные логи в одном месте.

<img src="https://github.com/user-attachments/assets/362bc916-0fc9-43f1-a39e-4bd71aac4a3a" width="400" />


### 3. Маршрутизация и защитные ограничения
`Configs` в шлюзе LLM позволяют создавать правила маршрутизации, повышать надежность и настраивать защитные ограничения.
```python
config = {
  "retry": {"attempts": 5},

  "output_guardrails": [{
    "default.contains": {"operator": "none", "words": ["Apple"]},
    "deny": True
  }]
}

# Примените конфиг к клиенту
client = client.with_options(config=config)

client.chat.completions.create(
    model="gpt-4o-mini",
    messages=[{"role": "user", "content": "Reply randomly with Apple or Bat"}]
)

# Ответ всегда будет "Bat", так как guardrail запрещает любые ответы, содержащие "Apple". Retry-конфиг попробует 5 раз, прежде чем сдаться.
```
<div align="center">
<img src="https://portkey.ai/blog/content/images/size/w1600/2024/11/image-15.png" width=600 title="Поток запроса через AI Gateway Portkey с повторами и защитными ограничениями" alt="Поток запроса через AI Gateway Portkey с повторами и защитными ограничениями"/>
</div>

Вы можете делать гораздо больше с помощью config'ов в вашем AI Gateway. [Перейти к примерам  →](https://portkey.wiki/gh-27)

<br/>

### Корпоративная версия (частные развертывания)

<sup>

[<img height="12" width="12" src="https://cfassets.portkey.ai/amazon-logo.svg" /> AWS](https://portkey.wiki/gh-28)
&nbsp; [<img height="12" width="12" src="https://cfassets.portkey.ai/azure-logo.svg" /> Azure](https://portkey.wiki/gh-29)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/googlecloud/3776AB" /> GCP](https://portkey.wiki/gh-30)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/redhatopenshift/3776AB" /> OpenShift](https://portkey.wiki/gh-31)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/kubernetes/3776AB" /> Kubernetes](https://portkey.wiki/gh-85)

</sup>

[Корпоративная версия](https://portkey.wiki/gh-86) LLM Gateway предлагает расширенные возможности по **управлению организациями**, **гибернации**, **безопасности** и [другим функциям](https://portkey.wiki/gh-87) "из коробки". [Сравнить функционал →](https://portkey.wiki/gh-32)

Архитектура корпоративного развертывания для поддерживаемых платформ доступна здесь — [**Частные облачные развертывания для бизнеса**](https://portkey.wiki/gh-33)

<a href="https://portkey.sh/demo-13"><img src="https://portkey.ai/blog/content/images/2024/08/Get-API-Key--5-.png" height=50 alt="Записаться на демонстрацию корпоративного AI Gateway" /></a><br/>


<br>

<hr>

### AI Engineering Hours

Присоединяйтесь к еженедельным встречам сообщества каждую пятницу (8:00 по PT), чтобы начать внедрение AI Gateway! [Каждую пятницу](https://portkey.wiki/gh-35)

<a href="https://portkey.wiki/gh-35"><img width="500" src="https://github.com/user-attachments/assets/c2885699-f197-4289-b819-21eb839fbae1" /></a>

Протоколы встреч [публикуются здесь](https://portkey.wiki/gh-36).


<hr>

### LLMs в продакшене 2025

Инсайты от анализа более 2 триллионов токенов в 90+ регионах и 650+ командах в продакшене. Что вы найдете в отчете:
- Тренды, формирующие внедрение AI и рост провайдеров LLM.
- Бенчмарки для оптимизации скорости, стоимости и надежности.
- Стратегии масштабирования AI-систем промышленного уровня.

<a href="https://portkey.sh/report-github"><img width="500" src="https://raw.githubusercontent.com/siddharthsambharia-portkey/Portkey-Product-Images/refs/heads/main/LLM%20Report%20Campaign%20Image.png" /></a>

<a href="https://portkey.sh/report-github">**Получить отчет**</a>
<hr>


## Основные возможности
### Надежная маршрутизация
- <a href="https://portkey.wiki/gh-37">**Фолбэки**</a>: Переключение на другого провайдера или модель при неудачных запросах через LLM-шлюз. Вы можете указать ошибки, при которых будет срабатывать фолбэк. Повышает надежность вашего приложения.
- <a href="https://portkey.wiki/gh-38">**Автоматические повторы**</a>: Автоматически повторяет неудачные запросы до 5 раз. Используется экспоненциальная стратегия увеличения интервалов между попытками, чтобы избежать перегрузки сети.
- <a href="https://portkey.wiki/gh-39">**Балансировка нагрузки**</a>: Распределяет запросы LLM между несколькими API-ключами или AI-провайдерами с учетом весов для обеспечения высокой доступности и оптимальной производительности.
- <a href="https://portkey.wiki/gh-40">**Таймауты запросов**</a>: Управляйте "непослушными" LLM и задержками, устанавливая детализированные таймауты запросов, что позволяет автоматически завершать запросы, превышающие заданную длительность.
- <a href="https://portkey.wiki/gh-41">**Мультимодальный LLM-шлюз**</a>: Вызывайте модели для vision, аудио (text-to-speech и speech-to-text), генерации изображений от разных провайдеров — всё с привычным OpenAI API.
- <a href="https://portkey.wiki/gh-42">**Реальные API**</a>: Вызывайте realtime API, запущенные OpenAI, через интегрированный websockets-сервер.

### Безопасность и точность
- <a href="https://portkey.wiki/gh-88">**Ограничители (Guardrails)**</a>: Проверяйте входные и выходные данные LLM на соответствие вашим требованиям. Выберите из 40+ встроенных ограничителей для соблюдения стандартов безопасности и точности. Вы можете <a href="https://portkey.wiki/gh-43">добавить свои собственные ограничители</a> или выбрать из наших <a href="https://portkey.wiki/gh-44">многочисленных партнеров</a>.
- [**Безопасное управление ключами**](https://portkey.wiki/gh-45): Используйте свои ключи или генерируйте виртуальные ключи на лету.
- [**Контроль доступа на основе ролей**](https://portkey.wiki/gh-46): Точный контроль доступа для ваших пользователей, рабочих пространств и API-ключей.
- <a href="https://portkey.wiki/gh-47">**Соответствие требованиям и конфиденциальность данных**</a>: AI-шлюз соответствует SOC2, HIPAA, GDPR и CCPA.

### Управление затратами
- [**Умное кэширование**](https://portkey.wiki/gh-48): Кэшируйте ответы LLM для снижения расходов и улучшения задержки. Поддерживает простое и семантическое* кэширование.
- [**Аналитика использования**](https://portkey.wiki/gh-49): Мониторинг и анализ использования AI и LLM, включая объем запросов, задержки, расходы и частоту ошибок.
- [**Оптимизация провайдеров***](https://portkey.wiki/gh-89): Автоматически переключайтесь на наиболее выгодного провайдера на основе моделей использования и цен.

### Совместная работа и рабочие процессы
- <a href="https://portkey.ai/docs/integrations/agents">**Поддержка агентов**</a>: Бесшовная интеграция с популярными фреймворками агентов для создания сложных AI-приложений. Шлюз интегрируется с [Autogen](https://portkey.wiki/gh-50), [CrewAI](https://portkey.wiki/gh-51), [LangChain](https://portkey.wiki/gh-52), [LlamaIndex](https://portkey.wiki/gh-53), [Phidata](https://portkey.wiki/gh-54), [Control Flow](https://portkey.wiki/gh-55) и даже [Custom Agents](https://portkey.wiki/gh-56).
- [**Управление шаблонами промптов***](https://portkey.wiki/gh-57): Создавайте, управляйте и версионируйте шаблоны промптов совместно через универсальную песочницу.

<br/><br/>

<sup>
*&nbsp;Доступно в облачной и корпоративной версиях
</sup>

<br>

## Кулинарные книги

### ☄️ В тренде
- Использование моделей от [Nvidia NIM](https://raw.githubusercontent.com/Portkey-AI/gateway/main/cookbook/providers/nvidia.ipynb) с AI Gateway
- Мониторинг [агентов CrewAI](https://raw.githubusercontent.com/Portkey-AI/gateway/main/cookbook/monitoring-agents/CrewAI_with_Telemetry.ipynb) с помощью Portkey!
- Сравнение [Топ-10 моделей LMSYS](https://raw.githubusercontent.com/Portkey-AI/gateway/main/cookbook/use-cases/LMSYS%20Series/comparing-top10-LMSYS-models-with-Portkey.ipynb) через AI Gateway.

### 🚨 Последние
* [Создание синтетических датасетов с помощью Nemotron](https://raw.githubusercontent.com/Portkey-AI/gateway/main/cookbook/use-cases/Nemotron_GPT_Finetuning_Portkey.ipynb)
* [Использование LLM Gateway с AI SDK от Vercel](https://raw.githubusercontent.com/Portkey-AI/gateway/main/cookbook/integrations/vercel-ai.md)
* [Мониторинг Llama Agents с помощью LLM Gateway Portkey](https://raw.githubusercontent.com/Portkey-AI/gateway/main/cookbook/monitoring-agents/Llama_Agents_with_Telemetry.ipynb)

[Посмотреть все кулинарные книги →](https://portkey.wiki/gh-58)
<br/><br/>

## Поддерживаемые провайдеры

Изучите интеграции Gateway с [45+ провайдерами](https://portkey.wiki/gh-59) и [8+ фреймворками агентов](https://portkey.wiki/gh-90).

|                                                                                                                            | Провайдер                                                                                   | Поддержка | Поток |
| -------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------ | --------- | ----- |
| <img src="docs/images/openai.png" width=35 />                                                                              | [OpenAI](https://portkey.wiki/gh-60)                           | ✅       | ✅      |
| <img src="docs/images/azure.png" width=35>                                                                                 | [Azure OpenAI](https://portkey.wiki/gh-61)               | ✅       | ✅      |
| <img src="docs/images/anyscale.png" width=35>                                                                              | [Anyscale](https://portkey.wiki/gh-62) | ✅       | ✅      |
| <img src="https://upload.wikimedia.org/wikipedia/commons/2/2d/Google-favicon-2015.png" width=35>                           | [Google Gemini](https://portkey.wiki/gh-63)             | ✅       | ✅      |
| <img src="docs/images/anthropic.png" width=35>                                                                             | [Anthropic](https://portkey.wiki/gh-64)                     | ✅       | ✅      |
| <img src="docs/images/cohere.png" width=35>                                                                                | [Cohere](https://portkey.wiki/gh-65)                           | ✅       | ✅      |
| <img src="https://assets-global.website-files.com/64f6f2c0e3f4c5a91c1e823a/654693d569494912cfc0c0d4_favicon.svg" width=35> | [Together AI](https://portkey.wiki/gh-66)                 | ✅       | ✅      |
| <img src="https://www.perplexity.ai/favicon.svg" width=35>                                                                 | [Perplexity](https://portkey.wiki/gh-67)                | ✅       | ✅      |
| <img src="https://docs.mistral.ai/img/favicon.ico" width=35>                                                               | [Mistral](https://portkey.wiki/gh-68)                      | ✅       | ✅      |
| <img src="https://docs.nomic.ai/img/nomic-logo.png" width=35>                                                              | [Nomic](https://portkey.wiki/gh-69)                             | ✅       | ✅      |
| <img src="https://files.readme.io/d38a23e-small-studio-favicon.png" width=35>                                              | [AI21](https://portkey.wiki/gh-91)                                    | ✅       | ✅      |
| <img src="https://platform.stability.ai/small-logo-purple.svg" width=35>                                                   | [Stability AI](https://portkey.wiki/gh-71)               | ✅       | ✅      |
| <img src="https://deepinfra.com/_next/static/media/logo.4a03fd3d.svg" width=35>                                            | [DeepInfra](https://portkey.sh/gh-92)                               | ✅       | ✅      |
| <img src="https://ollama.com/public/ollama.png" width=35>                                                                  | [Ollama](https://portkey.wiki/gh-72)                           | ✅       | ✅      |
| <img src="https://novita.ai/favicon.ico" width=35>                                                                         | [Novita AI](https://portkey.wiki/gh-73)                              | ✅       | ✅      | `/chat/completions`, `/completions` |


> [Посмотреть полный список из 200+ поддерживаемых моделей здесь](https://portkey.wiki/gh-74)
<br>

<br>

## Агенты
Шлюз бесшовно интегрируется с популярными фреймворками агентов. [Прочитайте документацию здесь](https://portkey.wiki/gh-75).


| Фреймворк | Вызов 200+ LLM | Продв. маршрутизация | Кэширование | Логирование и трейсинг* | Наблюдаемость* | Управление промптами* |
|------------------------------|--------|----------------------|-------------|-----------------------|-------------------|-----------------------|
| [Autogen](https://portkey.wiki/gh-93)    | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [CrewAI](https://portkey.wiki/gh-94)             | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [LangChain](https://portkey.wiki/gh-95)             | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [Phidata](https://portkey.wiki/gh-96)             | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [Llama Index](https://portkey.wiki/gh-97)             | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [Control Flow](https://portkey.wiki/gh-98) | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [Создайте своих агентов](https://portkey.wiki/gh-99) | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |

<br>

*Доступно в [облачном приложении](https://portkey.wiki/gh-76). Подробная документация [здесь](https://portkey.wiki/gh-100).


## Корпоративная версия Gateway
Сделайте свое AI-приложение более <ins>надежным</ins> и <ins>совместимым с будущими версиями</ins>, обеспечивая при этом полную <ins>безопасность данных</ins> и <ins>конфиденциальность</ins>.

✅&nbsp; Безопасное управление ключами — для контроля доступа по ролям и отслеживания <br>
✅&nbsp; Простое и семантическое кэширование — чтобы быстрее обслуживать повторные запросы и экономить средства <br>
✅&nbsp; Контроль доступа и входящие правила — чтобы управлять, какие IP и регионы могут подключаться к вашим развертываниям <br>
✅&nbsp; Редактирование PII — автоматическое удаление конфиденциальных данных из ваших запросов для предотвращения случайной утечки <br>
✅&nbsp; Соответствие SOC2, ISO, HIPAA, GDPR — лучшие практики безопасности <br>
✅&nbsp; Профессиональная поддержка — вместе с приоритетом внедрения функций <br>

[Записаться на звонок для обсуждения корпоративных внедрений](https://portkey.sh/demo-13)

<br>

## Вклад

Самый простой способ внести вклад — выбрать задачу с тегом `good first issue` 💪. Ознакомьтесь с руководством по вкладу [здесь](https://raw.githubusercontent.com/Portkey-AI/gateway/main/.github/CONTRIBUTING.md).

Баг-репорт? [Оставьте здесь](https://portkey.wiki/gh-78) | Запрос фичи? [Оставьте здесь](https://portkey.wiki/gh-78)

### Начало работы с сообществом
Присоединяйтесь к нашим еженедельным AI Engineering Hours каждую пятницу (8 AM PT), чтобы:
- Познакомиться с другими участниками и членами сообщества
- Изучить продвинутые функции Gateway и паттерны внедрения
- Поделиться своим опытом и получить помощь
- Быть в курсе последних приоритетов разработки

[Присоединиться к следующей сессии →](https://portkey.wiki/gh-101) | [Заметки о встречах](https://portkey.wiki/gh-102)

<br>

## Сообщество

Присоединяйтесь к нашему растущему сообществу по всему миру для помощи, идей и обсуждений по AI.

- Читайте наш официальный [Блог](https://portkey.wiki/gh-78)
- Общайтесь с нами в [Discord](https://portkey.wiki/community)
- Следите за нами в [Twitter](https://portkey.wiki/gh-79)
- Подписывайтесь на нас в [LinkedIn](https://portkey.wiki/gh-80)
- Прочитайте документацию на [японском языке](https://raw.githubusercontent.com/Portkey-AI/gateway/main/.github/README.jp.md)
- Смотрите нас на [YouTube](https://portkey.wiki/gh-103)
- Присоединяйтесь к нашему [Dev-сообществу](https://portkey.wiki/gh-82)
<!-- - Вопросы с тегом #portkey на [Stack Overflow](https://stackoverflow.com/questions/tagged/portkey) -->

![Rubeus Social Share (4)](https://github.com/Portkey-AI/gateway/assets/971978/89d6f0af-a95d-4402-b451-14764c40d03f)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---