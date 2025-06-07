# Prompt flow

[![Python package](https://img.shields.io/pypi/v/promptflow)](https://pypi.org/project/promptflow/)
[![Python](https://img.shields.io/pypi/pyversions/promptflow.svg?maxAge=2592000)](https://pypi.python.org/pypi/promptflow/)
[![PyPI - Downloads](https://img.shields.io/pypi/dm/promptflow)](https://pypi.org/project/promptflow/)
[![CLI](https://img.shields.io/badge/CLI-reference-blue)](https://microsoft.github.io/promptflow/reference/pf-command-reference.html)
[![vsc extension](https://img.shields.io/visual-studio-marketplace/i/prompt-flow.prompt-flow?logo=Visual%20Studio&label=Extension%20)](https://marketplace.visualstudio.com/items?itemName=prompt-flow.prompt-flow)

[![Doc](https://img.shields.io/badge/Doc-online-green)](https://microsoft.github.io/promptflow/index.html)
[![Issue](https://img.shields.io/github/issues/microsoft/promptflow)](https://github.com/microsoft/promptflow/issues/new/choose)
[![Discussions](https://img.shields.io/github/discussions/microsoft/promptflow)](https://github.com/microsoft/promptflow/issues/new/choose)
[![CONTRIBUTING](https://img.shields.io/badge/Contributing-8A2BE2)](https://github.com/microsoft/promptflow/blob/main/CONTRIBUTING.md)
[![License: MIT](https://img.shields.io/github/license/microsoft/promptflow)](https://github.com/microsoft/promptflow/blob/main/LICENSE)

> Присоединяйтесь к нам и помогайте делать prompt flow лучше, участвуя в [обсуждениях](https://github.com/microsoft/promptflow/discussions),
> открывая [issues](https://github.com/microsoft/promptflow/issues/new/choose),
> отправляя [PRs](https://github.com/microsoft/promptflow/pulls).

**Prompt flow** — это набор инструментов для разработки, предназначенный для упрощения полного цикла разработки AI-приложений на базе LLM: от идеи, прототипирования, тестирования, оценки до внедрения в производство и мониторинга. Он значительно облегчает работу с промт-инжинирингом и позволяет создавать LLM-приложения промышленного качества.

С помощью prompt flow вы сможете:

- **Создавать и итеративно развивать потоки**
    - Создавать исполняемые [потоки](https://microsoft.github.io/promptflow/concepts/concept-flows.html), которые связывают LLM, промты, Python-код и другие [инструменты](https://microsoft.github.io/promptflow/concepts/concept-tools.html) вместе.
    - Отлаживать и итеративно улучшать ваши потоки, особенно [трассировать взаимодействие с LLM](https://microsoft.github.io/promptflow/how-to-guides/tracing/index.html) с легкостью.
- **Оценивать качество и производительность потока**
    - Оценивать качество и производительность вашего потока на больших датасетах.
    - Интегрировать тестирование и оценку в вашу CI/CD систему для обеспечения качества потока.
- **Оптимизированный цикл разработки для продакшена**
    - Развернуть ваш поток на выбранной платформе или легко интегрировать в кодовую базу приложения.
    - (Опционально, но настоятельно рекомендуется) Работать в команде, используя облачную версию [Prompt flow в Azure AI](https://learn.microsoft.com/en-us/azure/machine-learning/prompt-flow/overview-what-is-prompt-flow?view=azureml-api-2).

------

## Установка

Для быстрого старта вы можете использовать готовую среду разработки. **Нажмите на кнопку ниже**, чтобы открыть репозиторий в GitHub Codespaces и продолжить изучение readme!

[![Open in GitHub Codespaces](https://github.com/codespaces/badge.svg)](https://codespaces.new/microsoft/promptflow?quickstart=1)

Если вы хотите начать работу в своей локальной среде, сначала установите пакеты:

Убедитесь, что у вас есть окружение Python, рекомендуется `python>=3.9, <=3.11`.

```sh
pip install promptflow promptflow-tools
```

## Быстрый старт ⚡

**Создайте чат-бота с помощью prompt flow**

Выполните команду для инициализации prompt flow из шаблона чата — будет создана папка `my_chatbot` и сгенерированы необходимые файлы:

```sh
pf flow init --flow ./my_chatbot --type chat
```

**Настройте подключение для вашего API-ключа**

Для ключа OpenAI создайте подключение с помощью команды, используя файл `openai.yaml` в папке `my_chatbot`, который хранит ваш ключ OpenAI (переопределите ключи и имя с помощью --set, чтобы избежать изменений в yaml-файле):

```sh
pf connection create --file ./my_chatbot/openai.yaml --set api_key=<your_api_key> --name open_ai_connection
```

Для ключа Azure OpenAI создайте подключение с помощью команды, используя файл `azure_openai.yaml`:

```sh
pf connection create --file ./my_chatbot/azure_openai.yaml --set api_key=<your_api_key> api_base=<your_api_base> --name open_ai_connection
```

**Общайтесь с вашим потоком**

В папке `my_chatbot` есть файл `flow.dag.yaml`, в котором описан поток: входные и выходные данные, узлы, подключения и модель LLM и т.д.

> Обратите внимание, что в узле `chat` используется подключение с именем `open_ai_connection` (указано в поле `connection`) и модель `gpt-35-turbo` (указано в поле `deployment_name`). Поле deployment_name определяет модель OpenAI или имя развертывания Azure OpenAI.

Взаимодействуйте с вашим чат-ботом, выполнив: (нажмите `Ctrl + C` для завершения сессии)

```sh
pf flow test --flow ./my_chatbot --interactive
```

**Ключевая ценность: обеспечение “Высокого качества” от прототипа до производства**

Изучите наш [**15-минутный туториал**](https://raw.githubusercontent.com/microsoft/promptflow/main/examples/tutorials/flow-fine-tuning-evaluation/promptflow-quality-improvement.md), который проведет вас через тюнинг промта ➡ пакетное тестирование ➡ оценку, — всё для обеспечения высокого качества, готового к продакшену.

Следующий шаг! Продолжайте с разделом **Tutorial** 👇, чтобы глубже погрузиться в prompt flow.

## Туториал 🏃‍♂️

Prompt flow — это инструмент для **создания LLM-приложений высокого качества**, процесс разработки в prompt flow включает следующие этапы: создание потока, улучшение качества потока, развертывание потока в продакшен.

### Разрабатывайте свои LLM-приложения

#### Расширение для VS Code

Мы также предлагаем расширение для VS Code (дизайнер потоков) для интерактивной разработки потоков с помощью UI.

<img src="https://raw.githubusercontent.com/microsoft/promptflow/main/docs/media/readme/vsc.png" alt="vsc" width="1000"/>

Вы можете установить его из <a href="https://marketplace.visualstudio.com/items?itemName=prompt-flow.prompt-flow">visualstudio marketplace</a>.

#### Подробное изучение разработки потоков

[Начало работы с prompt flow](https://raw.githubusercontent.com/microsoft/promptflow/main/docs/how-to-guides/quick-start.md): пошаговое руководство по запуску первого потока.

### Изучайте на примерах

[Туториал: Чат с PDF](https://github.com/microsoft/promptflow/blob/main/examples/tutorials/e2e-development/chat-with-pdf.md): пошаговое руководство по созданию качественного чат-приложения с prompt flow, включая разработку потока и оценку с метриками.
> Больше примеров можно найти [здесь](https://microsoft.github.io/promptflow/tutorials/index.html#samples). Мы приветствуем новые кейсы от сообщества!

### Настройка для контрибьюторов

Если вы хотите внести вклад, начните с нашего руководства по настройке разработки: [dev_setup.md](https://raw.githubusercontent.com/microsoft/promptflow/main/docs/dev/dev_setup.md).

Следующий шаг! Перейдите к разделу **Contributing** 👇, чтобы принять участие в развитии prompt flow.

## Внесение вклада

Этот проект приветствует вклады и предложения. Большинство изменений требует согласия с
Contributor License Agreement (CLA), подтверждающего ваши права на вклад и согласие предоставить их нам. Подробнее: https://cla.opensource.microsoft.com.

Когда вы отправляете pull request, CLA-бот автоматически определяет, нужно ли вам дать согласие,
и помечает PR соответствующим образом (например, статус, комментарий). Просто следуйте инструкциям
бота. Это нужно сделать только один раз для всех репозиториев, использующих наш CLA.

В проекте принят [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/).
Подробнее — в [FAQ](https://opensource.microsoft.com/codeofconduct/faq/) или
по вопросам обращайтесь на [opencode@microsoft.com](mailto:opencode@microsoft.com).

## Товарные знаки

В проекте могут использоваться товарные знаки или логотипы проектов, продуктов или сервисов. Разрешенное использование товарных знаков или логотипов Microsoft подчиняется
[правилам использования товарных знаков Microsoft](https://www.microsoft.com/en-us/legal/intellectualproperty/trademarks/usage/general).
Использование товарных знаков или логотипов Microsoft в изменённых версиях этого проекта не должно вводить в заблуждение или подразумевать спонсорство Microsoft.
Использование товарных знаков или логотипов третьих сторон регулируется их политиками.

## Кодекс поведения

В этом проекте принят
[Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/).
Для получения дополнительной информации смотрите
[FAQ по Кодексу поведения](https://opensource.microsoft.com/codeofconduct/faq/)
или обращайтесь по адресу [opencode@microsoft.com](mailto:opencode@microsoft.com)
с любыми дополнительными вопросами или комментариями.

## Сбор данных

Программное обеспечение может собирать информацию о вас и вашем использовании ПО и
отправлять её в Microsoft, если включена телеметрия.
Microsoft может использовать эту информацию для предоставления сервисов и улучшения своих продуктов и услуг.
Вы можете включить или отключить телеметрию, как описано в репозитории.
Также в программном обеспечении есть функции, которые позволяют вам и Microsoft
собирать данные от пользователей ваших приложений. Если вы используете такие функции,
вы должны соблюдать применимое законодательство, включая предоставление соответствующих уведомлений
пользователям ваших приложений вместе с копией политики конфиденциальности Microsoft.
Наша политика конфиденциальности: https://go.microsoft.com/fwlink/?LinkID=824704.
Подробнее о сборе и использовании данных смотрите в документации и политике конфиденциальности.
Использование программного обеспечения означает ваше согласие с этими правилами.

### Настройка телеметрии

Сбор телеметрии включен по умолчанию.

Чтобы отказаться, выполните команду `pf config set telemetry.enabled=false`.

## Лицензия

Copyright (c) Microsoft Corporation. All rights reserved.

Лицензировано на условиях лицензии [MIT](LICENSE).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---