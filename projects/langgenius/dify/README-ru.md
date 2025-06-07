![cover-v5-optimized](./images/GitHub_README_if.png)

<p align="center">
  📌 <a href="https://dify.ai/blog/introducing-dify-workflow-file-upload-a-demo-on-ai-podcast">Введение в загрузку файлов Dify Workflow: Воссоздание подкаста Google NotebookLM</a>
</p>

<p align="center">
  <a href="https://cloud.dify.ai">Dify Cloud</a> ·
  <a href="https://docs.dify.ai/getting-started/install-self-hosted">Самостоятельный хостинг</a> ·
  <a href="https://docs.dify.ai">Документация</a> ·
  <a href="https://dify.ai/pricing">Обзор редакций Dify</a>
</p>

<p align="center">
    <a href="https://dify.ai" target="_blank">
        <img alt="Static Badge" src="https://img.shields.io/badge/Product-F04438"></a>
    <a href="https://dify.ai/pricing" target="_blank">
        <img alt="Static Badge" src="https://img.shields.io/badge/free-pricing?logo=free&color=%20%23155EEF&label=pricing&labelColor=%20%23528bff"></a>
    <a href="https://discord.gg/FngNHpbcY7" target="_blank">
        <img src="https://img.shields.io/discord/1082486657678311454?logo=discord&labelColor=%20%235462eb&logoColor=%20%23f5f5f5&color=%20%235462eb"
            alt="chat on Discord"></a>
    <a href="https://reddit.com/r/difyai" target="_blank">  
        <img src="https://img.shields.io/reddit/subreddit-subscribers/difyai?style=plastic&logo=reddit&label=r%2Fdifyai&labelColor=white"
            alt="join Reddit"></a>
    <a href="https://twitter.com/intent/follow?screen_name=dify_ai" target="_blank">
        <img src="https://img.shields.io/twitter/follow/dify_ai?logo=X&color=%20%23f5f5f5"
            alt="follow on X(Twitter)"></a>
    <a href="https://www.linkedin.com/company/langgenius/" target="_blank">
        <img src="https://custom-icon-badges.demolab.com/badge/LinkedIn-0A66C2?logo=linkedin-white&logoColor=fff"
            alt="follow on LinkedIn"></a>
    <a href="https://hub.docker.com/u/langgenius" target="_blank">
        <img alt="Docker Pulls" src="https://img.shields.io/docker/pulls/langgenius/dify-web?labelColor=%20%23FDB062&color=%20%23f79009"></a>
    <a href="https://github.com/langgenius/dify/graphs/commit-activity" target="_blank">
        <img alt="Commits last month" src="https://img.shields.io/github/commit-activity/m/langgenius/dify?labelColor=%20%2332b583&color=%20%2312b76a"></a>
    <a href="https://github.com/langgenius/dify/" target="_blank">
        <img alt="Issues closed" src="https://img.shields.io/github/issues-search?query=repo%3Alanggenius%2Fdify%20is%3Aclosed&label=issues%20closed&labelColor=%20%237d89b0&color=%20%235d6b98"></a>
    <a href="https://github.com/langgenius/dify/discussions/" target="_blank">
        <img alt="Discussion posts" src="https://img.shields.io/github/discussions/langgenius/dify?labelColor=%20%239b8afb&color=%20%237a5af8"></a>
</p>

<p align="center">
  <a href="./README.md"><img alt="README in English" src="https://img.shields.io/badge/English-d9d9d9"></a>
  <a href="./README_TW.md"><img alt="繁體中文文件" src="https://img.shields.io/badge/繁體中文-d9d9d9"></a>
  <a href="./README_CN.md"><img alt="简体中文版自述文件" src="https://img.shields.io/badge/简体中文-d9d9d9"></a>
  <a href="./README_JA.md"><img alt="日本語のREADME" src="https://img.shields.io/badge/日本語-d9d9d9"></a>
  <a href="./README_ES.md"><img alt="README en Español" src="https://img.shields.io/badge/Español-d9d9d9"></a>
  <a href="./README_FR.md"><img alt="README en Français" src="https://img.shields.io/badge/Français-d9d9d9"></a>
  <a href="./README_KL.md"><img alt="README tlhIngan Hol" src="https://img.shields.io/badge/Klingon-d9d9d9"></a>
  <a href="./README_KR.md"><img alt="README in Korean" src="https://img.shields.io/badge/한국어-d9d9d9"></a>
  <a href="./README_AR.md"><img alt="README بالعربية" src="https://img.shields.io/badge/العربية-d9d9d9"></a>
  <a href="./README_TR.md"><img alt="Türkçe README" src="https://img.shields.io/badge/Türkçe-d9d9d9"></a>
  <a href="./README_VI.md"><img alt="README Tiếng Việt" src="https://img.shields.io/badge/Ti%E1%BA%BFng%20Vi%E1%BB%87t-d9d9d9"></a>
  <a href="./README_DE.md"><img alt="README in Deutsch" src="https://img.shields.io/badge/German-d9d9d9"></a>
  <a href="./README_BN.md"><img alt="README in বাংলা" src="https://img.shields.io/badge/বাংলা-d9d9d9"></a>
</p>

Dify — это платформа для разработки приложений LLM с открытым исходным кодом. Интуитивно понятный интерфейс сочетает в себе агентные AI-воркфлоу, RAG-пайплайн, возможности агентов, управление моделями, функции наблюдаемости и многое другое, что позволяет быстро перейти от прототипа к промышленной эксплуатации.

## Быстрый старт

> Перед установкой Dify убедитесь, что ваш компьютер соответствует следующим минимальным системным требованиям:
>
> - CPU >= 2 ядра
> - RAM >= 4 ГБ

</br>

Самый простой способ запустить сервер Dify — использовать [docker compose](docker/docker-compose.yaml). Перед запуском Dify с помощью следующих команд убедитесь, что у вас установлены [Docker](https://docs.docker.com/get-docker/) и [Docker Compose](https://docs.docker.com/compose/install/):

```bash
cd dify
cd docker
cp .env.example .env
docker compose up -d
```

После запуска вы можете получить доступ к панели управления Dify в браузере по адресу [http://localhost/install](http://localhost/install) и начать процесс инициализации.

#### Получение помощи

Если у вас возникли проблемы с настройкой Dify, обратитесь к нашему [FAQ](https://docs.dify.ai/getting-started/install-self-hosted/faqs). Если проблемы сохраняются, обратитесь к [сообществу и нам](#community--contact).

> Если вы хотите внести вклад в разработку Dify или заняться дополнительной разработкой, ознакомьтесь с нашим [руководством по развертыванию из исходного кода](https://docs.dify.ai/getting-started/install-self-hosted/local-source-code)

## Ключевые возможности

**1. Воркфлоу**:  
Создавайте и тестируйте мощные AI-воркфлоу на визуальном холсте, используя все перечисленные ниже возможности и даже больше.

**2. Широкая поддержка моделей**:  
Бесшовная интеграция с сотнями проприетарных и open-source LLM от десятков провайдеров и решений для самостоятельного хостинга, включая GPT, Mistral, Llama3 и любые модели, совместимые с OpenAI API. Полный список поддерживаемых провайдеров моделей можно найти [здесь](https://docs.dify.ai/getting-started/readme/model-providers).

![providers-v5](https://github.com/langgenius/dify/assets/13230914/5a17bdbe-097a-4100-8363-40255b70f6e3)

**3. Prompt IDE**:  
Интуитивный интерфейс для создания промптов, сравнения производительности моделей и добавления дополнительных функций, таких как преобразование текста в речь, в чат-приложения.

**4. RAG-пайплайн**:  
Расширенные возможности RAG, охватывающие все этапы: от загрузки документов до их поиска, с поддержкой извлечения текста из PDF, PPT и других популярных форматов документов "из коробки".

**5. Возможности агентов**:  
Вы можете определить агентов на основе LLM Function Calling или ReAct и добавить для них готовые или пользовательские инструменты. Dify предоставляет более 50 встроенных инструментов для AI-агентов, таких как Google Search, DALL·E, Stable Diffusion и WolframAlpha.

**6. LLMOps**:  
Мониторинг и анализ логов приложений и их производительности со временем. Вы можете постоянно совершенствовать промпты, датасеты и модели на основе производственных данных и аннотаций.

**7. Backend-as-a-Service**:  
Все возможности Dify доступны через API, что позволяет легко интегрировать Dify в вашу бизнес-логику.

## Сравнение возможностей

<table style="width: 100%;">
  <tr>
    <th align="center">Возможность</th>
    <th align="center">Dify.AI</th>
    <th align="center">LangChain</th>
    <th align="center">Flowise</th>
    <th align="center">OpenAI Assistants API</th>
  </tr>
  <tr>
    <td align="center">Подход к программированию</td>
    <td align="center">API + Ориентирован на приложения</td>
    <td align="center">Python-код</td>
    <td align="center">Ориентирован на приложения</td>
    <td align="center">Ориентирован на API</td>
  </tr>
  <tr>
    <td align="center">Поддерживаемые LLM</td>
    <td align="center">Большое разнообразие</td>
    <td align="center">Большое разнообразие</td>
    <td align="center">Большое разнообразие</td>
    <td align="center">Только OpenAI</td>
  </tr>
  <tr>
    <td align="center">RAG-движок</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
  </tr>
  <tr>
    <td align="center">Агент</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
    <td align="center">✅</td>
  </tr>
  <tr>
    <td align="center">Воркфлоу</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
  </tr>
  <tr>
    <td align="center">Наблюдаемость</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
    <td align="center">❌</td>
  </tr>
  <tr>
    <td align="center">Корпоративные функции (SSO/Контроль доступа)</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
    <td align="center">❌</td>
    <td align="center">❌</td>
  </tr>
  <tr>
    <td align="center">Локальное развертывание</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
  </tr>
</table>

## Использование Dify

- **Облако </br>**  
  Мы предоставляем сервис [Dify Cloud](https://dify.ai) для всех желающих без необходимости установки. Он включает все возможности версии для самостоятельного развертывания и предоставляет 200 бесплатных вызовов GPT-4 в рамках плана "песочница".

- **Самостоятельный хостинг Dify Community Edition</br>**  
  Быстро запустите Dify в своей среде с помощью этого [руководства по запуску](#quick-start).  
  Используйте нашу [документацию](https://docs.dify.ai) для получения дополнительных сведений и более подробных инструкций.

- **Dify для предприятий / организаций</br>**  
  Мы предоставляем дополнительные функции, ориентированные на корпоративных пользователей. [Оставьте свой вопрос через этот чат-бот](https://udify.app/chat/22L1zSxg6yW1cWQg) или [напишите нам на почту](mailto:business@dify.ai?subject=[GitHub]Business%20License%20Inquiry), чтобы обсудить корпоративные потребности. </br>
  > Для стартапов и малого бизнеса, использующих AWS, обратите внимание на [Dify Premium на AWS Marketplace](https://aws.amazon.com/marketplace/pp/prodview-t22mebxzwjhu6) и разверните Dify в своем AWS VPC в один клик. Это доступное AMI-решение с возможностью создавать приложения с собственным логотипом и брендингом.

## Оставайтесь в курсе

Добавьте Dify в избранное на GitHub и мгновенно получайте уведомления о новых релизах.

![star-us](https://github.com/langgenius/dify/assets/13230914/b823edc1-6388-4e25-ad45-2f6b187adbb4)

## Расширенная настройка

Если вам нужно настроить конфигурацию, обратитесь к комментариям в нашем файле [.env.example](docker/.env.example) и обновите соответствующие значения в вашем `.env`-файле. Также может понадобиться изменить сам файл `docker-compose.yaml`, например, версии образов, настройки портов или маунты томов — в зависимости от вашей среды и требований. После изменений перезапустите `docker-compose up -d`. Полный список доступных переменных окружения смотрите [здесь](https://docs.dify.ai/getting-started/install-self-hosted/environments).

Если вы хотите настроить отказоустойчивое развертывание, доступны [Helm Charts](https://helm.sh/) и YAML-файлы от сообщества, позволяющие развернуть Dify в Kubernetes.

- [Helm Chart от @LeoQuote](https://github.com/douban/charts/tree/master/charts/dify)
- [Helm Chart от @BorisPolonsky](https://github.com/BorisPolonsky/dify-helm)
- [Helm Chart от @magicsong](https://github.com/magicsong/ai-charts)
- [YAML-файл от @Winson-030](https://github.com/Winson-030/dify-kubernetes)
- [YAML-файл от @wyy-holding](https://github.com/wyy-holding/dify-k8s)

#### Развертывание с помощью Terraform

Разверните Dify на облачной платформе одним кликом с помощью [terraform](https://www.terraform.io/)

##### Azure Global

- [Azure Terraform от @nikawang](https://github.com/nikawang/dify-azure-terraform)

##### Google Cloud

- [Google Cloud Terraform от @sotazum](https://github.com/DeNA/dify-google-cloud-terraform)

#### Развертывание с помощью AWS CDK

Разверните Dify на AWS с помощью [CDK](https://aws.amazon.com/cdk/)

##### AWS

- [AWS CDK от @KevinZhao](https://github.com/aws-samples/solution-for-deploying-dify-on-aws)

## Вклад в проект

Если вы хотите внести код, ознакомьтесь с нашим [руководством для участников](https://github.com/langgenius/dify/blob/main/CONTRIBUTING.md).  
Также, пожалуйста, поддержите Dify, рассказывая о нем в социальных сетях, на мероприятиях и конференциях.

> Мы ищем участников для перевода Dify на другие языки, кроме китайского и английского. Если вы хотите помочь, смотрите [i18n README](https://github.com/langgenius/dify/blob/main/web/i18n/README.md) и оставьте комментарий в канале `global-users` на нашем [Discord Community Server](https://discord.gg/8Tpq4AcN9c).

## Сообщество и контакты

- [GitHub Discussion](https://github.com/langgenius/dify/discussions). Лучше всего подходит для: обратной связи и вопросов.
- [GitHub Issues](https://github.com/langgenius/dify/issues). Лучше всего подходит для: сообщений об ошибках и предложений новых функций. Смотрите [руководство для участников](https://github.com/langgenius/dify/blob/main/CONTRIBUTING.md).
- [Discord](https://discord.gg/FngNHpbcY7). Лучше всего подходит для: обмена вашими приложениями и общения с сообществом.
- [X(Twitter)](https://twitter.com/dify_ai). Лучше всего подходит для: обмена приложениями и общения с сообществом.

**Участники**

<a href="https://github.com/langgenius/dify/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=langgenius/dify" />
</a>

## История звёзд

[![Star History Chart](https://api.star-history.com/svg?repos=langgenius/dify&type=Date)](https://star-history.com/#langgenius/dify&Date)

## Сообщения о безопасности

В целях вашей безопасности не публикуйте вопросы безопасности на GitHub. Вместо этого отправьте свои вопросы на security@dify.ai, и мы дадим вам подробный ответ.

## Лицензия

Этот репозиторий распространяется по [Dify Open Source License](LICENSE), которая по сути является Apache 2.0 с некоторыми дополнительными ограничениями.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---