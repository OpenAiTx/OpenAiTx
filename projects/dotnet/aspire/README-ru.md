# .NET Aspire

[![Tests](https://github.com/dotnet/aspire/actions/workflows/tests.yml/badge.svg?branch=main&event=push)](https://github.com/dotnet/aspire/actions/workflows/tests.yml)
[![Build Status](https://dev.azure.com/dnceng-public/public/_apis/build/status%2Fdotnet%2Faspire%2Fdotnet.aspire?branchName=main)](https://dev.azure.com/dnceng-public/public/_build/latest?definitionId=274&branchName=main)
[![Help Wanted](https://img.shields.io/github/issues/dotnet/aspire/help%20wanted?style=flat&color=%24EC820&label=help%20wanted)](https://github.com/dotnet/aspire/labels/help%20wanted)
[![Good First Issue](https://img.shields.io/github/issues/dotnet/aspire/good%20first%20issue?style=flat&color=%24EC820&label=good%20first%20issue)](https://github.com/dotnet/aspire/labels/good%20first%20issue)
[![Discord](https://img.shields.io/discord/732297728826277939?style=flat&logo=discord&logoColor=white&label=Join%20our%20Discord&labelColor=512bd4&color=cyan)](https://discord.com/invite/h87kDAHQgJ)

## Что такое .NET Aspire?

.NET Aspire — это продуманная, готовая к облаку платформа для построения наблюдаемых, готовых к промышленной эксплуатации распределённых приложений. .NET Aspire поставляется в виде набора пакетов NuGet, которые решают определённые задачи, связанные с облачными технологиями. Облачные приложения часто состоят из небольших, взаимосвязанных компонентов или микросервисов, а не единой монолитной кодовой базы. Как правило, такие приложения используют множество сервисов, таких как базы данных, системы обмена сообщениями и кэширования.

.NET Aspire помогает в следующем:

[Оркестрация](https://learn.microsoft.com/dotnet/aspire/get-started/aspire-overview?#orchestration): .NET Aspire предоставляет возможности для запуска и соединения многопроектных приложений и их зависимостей.

[Интеграции](https://learn.microsoft.com/dotnet/aspire/get-started/aspire-overview?#net-aspire-integrations): Интеграции .NET Aspire — это NuGet-пакеты для часто используемых сервисов, таких как Redis или Postgres, со стандартизированными интерфейсами, которые обеспечивают стабильное и бесшовное подключение к вашему приложению.

[Инструментарий](https://learn.microsoft.com/dotnet/aspire/get-started/aspire-overview?#project-templates-and-tooling): .NET Aspire поставляется с шаблонами проектов и инструментами для Visual Studio и dotnet CLI, которые помогают создавать и взаимодействовать с приложениями .NET Aspire.

Чтобы узнать больше, ознакомьтесь с полной [обзорной документацией по .NET Aspire](https://learn.microsoft.com/dotnet/aspire/). Примеры доступны в [репозитории примеров .NET Aspire](https://github.com/dotnet/aspire-samples). Вы можете найти [пример eShop здесь](https://github.com/dotnet/eshop) и [Azure-версию здесь](https://github.com/Azure-Samples/eShopOnAzure).

## Что находится в этом репозитории?

Хост приложения .NET Aspire, дашборд, инфраструктура сервис-дискавери и все интеграции .NET Aspire. Здесь также содержатся шаблоны проектов.

## Использование последних ежедневных сборок

Следуйте инструкциям в [docs/using-latest-daily.md](https://raw.githubusercontent.com/dotnet/aspire/main/docs/using-latest-daily.md), чтобы начать использовать .NET Aspire с последней ежедневной сборкой.

## Как я могу внести вклад?

Мы приветствуем вклад! Многие люди по всему миру помогли сделать .NET лучше.

Следуйте инструкциям в [docs/contributing.md](https://raw.githubusercontent.com/dotnet/aspire/main/docs/contributing.md) для работы с кодом в этом репозитории.

## Сообщение о проблемах безопасности и уязвимостях

Проблемы безопасности и ошибки следует сообщать конфиденциально по электронной почте в Microsoft Security Response Center (MSRC) <secure@microsoft.com>. Вы должны получить ответ в течение 24 часов. Если по какой-то причине вы не получили ответа, пожалуйста, продублируйте сообщение, чтобы убедиться, что оно было получено. Дополнительную информацию, включая PGP-ключ MSRC, можно найти в [Security TechCenter](https://www.microsoft.com/msrc/faqs-report-an-issue). Вы также можете найти эти инструкции в [Security doc](https://raw.githubusercontent.com/dotnet/aspire/main/SECURITY.md) этого репозитория.

Также смотрите информацию о связанной [программе Bug Bounty для Microsoft .NET Core и ASP.NET Core](https://www.microsoft.com/msrc/bounty-dot-net-core).

### Примечание о контейнерах, используемых в интеграциях ресурсов и клиентов .NET Aspire

Команда .NET не может оценивать сторонние контейнеры, для которых реализована поддержка API, на предмет их пригодности для конкретных требований заказчиков.

Вы должны самостоятельно оценить любые контейнеры, которые вы выбираете для компоновки и автоматизации с помощью Aspire, чтобы убедиться, что они соответствуют вашим требованиям, требованиям вашего работодателя или государства по вопросам безопасности, а также криптографическим и иным нормативным или корпоративным стандартам, которые могут применяться к вашему использованию контейнеров.

## .NET Foundation

.NET Aspire — это проект [.NET Foundation](https://www.dotnetfoundation.org/projects).

Существует множество проектов, связанных с .NET, на GitHub.

* [Главный репозиторий .NET](https://github.com/Microsoft/dotnet) — ссылки на сотни проектов .NET от Microsoft и сообщества.
* [Главная страница ASP.NET Core](https://docs.microsoft.com/aspnet/core) — лучшее место для начала знакомства с ASP.NET Core.

Этот проект принял [кодекс поведения Contributor Covenant](https://contributor-covenant.org), чтобы прояснить ожидаемое поведение в нашем сообществе. Подробнее см. [.NET Foundation Code of Conduct](https://www.dotnetfoundation.org/code-of-conduct).

## Лицензия

Код в этом репозитории лицензирован по лицензии [MIT](https://raw.githubusercontent.com/dotnet/aspire/main/LICENSE.TXT).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-19

---