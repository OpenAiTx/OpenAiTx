# Visual Studio Code - Open Source ("Code - OSS")

[![Запросы на новые функции](https://img.shields.io/github/issues/microsoft/vscode/feature-request.svg)](https://github.com/microsoft/vscode/issues?q=is%3Aopen+is%3Aissue+label%3Afeature-request+sort%3Areactions-%2B1-desc)
[![Ошибки](https://img.shields.io/github/issues/microsoft/vscode/bug.svg)](https://github.com/microsoft/vscode/issues?utf8=✓&q=is%3Aissue+is%3Aopen+label%3Abug)
[![Gitter](https://img.shields.io/badge/chat-on%20gitter-yellow.svg)](https://gitter.im/Microsoft/vscode)

## Репозиторий

Этот репозиторий ("`Code - OSS`") — место, где мы (Microsoft) совместно с сообществом разрабатываем продукт [Visual Studio Code](https://code.visualstudio.com). Здесь мы не только работаем над кодом и задачами, но также публикуем нашу [дорожную карту](https://github.com/microsoft/vscode/wiki/Roadmap), [ежемесячные планы итераций](https://github.com/microsoft/vscode/wiki/Iteration-Plans) и [планы завершения релиза](https://github.com/microsoft/vscode/wiki/Running-the-Endgame). Этот исходный код доступен всем согласно стандартной [лицензии MIT](https://github.com/microsoft/vscode/blob/main/LICENSE.txt).

## Visual Studio Code

<p align="center">
  <img alt="VS Code в действии" src="https://user-images.githubusercontent.com/35271042/118224532-3842c400-b438-11eb-923d-a5f66fa6785a.png">
</p>

[Visual Studio Code](https://code.visualstudio.com) — это дистрибутив репозитория `Code - OSS` с фирменными доработками Microsoft, распространяемый по традиционной [лицензии продукта Microsoft](https://code.visualstudio.com/License/).

[Visual Studio Code](https://code.visualstudio.com) сочетает простоту редактора кода с тем, что нужно разработчикам для основного цикла редактирования, сборки и отладки. Он обеспечивает полный функционал для редактирования, навигации и понимания кода, а также лёгкую отладку, расширяемую архитектуру и лёгкую интеграцию с существующими инструментами.

Visual Studio Code обновляется ежемесячно — с новыми возможностями и исправлениями ошибок. Скачать его для Windows, macOS и Linux можно на [официальном сайте Visual Studio Code](https://code.visualstudio.com/Download). Чтобы получать последние обновления ежедневно, установите [Insiders-сборку](https://code.visualstudio.com/insiders).

## Участие

Существует множество способов принять участие в этом проекте, например:

* [Сообщайте об ошибках и предлагайте новые функции](https://github.com/microsoft/vscode/issues) и помогайте нам верифицировать их после внесения изменений
* Просматривайте [изменения в исходном коде](https://github.com/microsoft/vscode/pulls)
* Проверяйте [документацию](https://github.com/microsoft/vscode-docs) и делайте pull-запросы — от исправления опечаток до добавления нового контента

Если вы заинтересованы в исправлении ошибок и непосредственном участии в разработке,
ознакомьтесь с документом [Как внести вклад](https://github.com/microsoft/vscode/wiki/How-to-Contribute), где рассматриваются следующие вопросы:

* [Как собрать и запустить из исходников](https://github.com/microsoft/vscode/wiki/How-to-Contribute)
* [Процесс разработки, включая отладку и запуск тестов](https://github.com/microsoft/vscode/wiki/How-to-Contribute#debugging)
* [Рекомендации по написанию кода](https://github.com/microsoft/vscode/wiki/Coding-Guidelines)
* [Отправка pull-запросов](https://github.com/microsoft/vscode/wiki/How-to-Contribute#pull-requests)
* [Как найти задачу для работы](https://github.com/microsoft/vscode/wiki/How-to-Contribute#where-to-contribute)
* [Вклад в переводы](https://aka.ms/vscodeloc)

## Обратная связь

* Задайте вопрос на [Stack Overflow](https://stackoverflow.com/questions/tagged/vscode)
* [Запросите новую функцию](CONTRIBUTING.md)
* Голосуйте за [популярные запросы на функции](https://github.com/microsoft/vscode/issues?q=is%3Aopen+is%3Aissue+label%3Afeature-request+sort%3Areactions-%2B1-desc)
* [Сообщите об ошибке](https://github.com/microsoft/vscode/issues)
* Общайтесь с авторами расширений на [GitHub Discussions](https://github.com/microsoft/vscode-discussions/discussions) или [Slack](https://aka.ms/vscode-dev-community)
* Подписывайтесь на [@code](https://twitter.com/code) и делитесь своими впечатлениями!

Подробнее обо всех каналах обратной связи читайте в нашем [вики](https://github.com/microsoft/vscode/wiki/Feedback-Channels), а также о других доступных каналах, поддерживаемых сообществом.

## Связанные проекты

Многие основные компоненты и расширения VS Code находятся в отдельных репозиториях на GitHub. Например, репозитории [адаптера отладки node](https://github.com/microsoft/vscode-node-debug) и [адаптера отладки mono](https://github.com/microsoft/vscode-mono-debug) существуют отдельно друг от друга. Для полного списка, пожалуйста, посетите страницу [Связанные проекты](https://github.com/microsoft/vscode/wiki/Related-Projects) в нашем [вики](https://github.com/microsoft/vscode/wiki).

## Встроенные расширения

VS Code включает набор встроенных расширений, которые находятся в папке [extensions](extensions), включая грамматики и сниппеты для многих языков. Расширения, обеспечивающие полноценную поддержку языка (автодополнение кода, переход к определению) для языка, имеют суффикс `language-features`. Например, расширение `json` обеспечивает подсветку для `JSON`, а расширение `json-language-features` — полноценную языковую поддержку для `JSON`.

## Контейнер для разработки

Этот репозиторий содержит контейнер для разработки Visual Studio Code Dev Containers / GitHub Codespaces.

* Для [Dev Containers](https://aka.ms/vscode-remote/download/containers) используйте команду **Dev Containers: Clone Repository in Container Volume...**, которая создаёт Docker-том для лучшей производительности диска на macOS и Windows.
  * Если у вас уже установлены VS Code и Docker, вы также можете кликнуть [здесь](https://vscode.dev/redirect?url=vscode://ms-vscode-remote.remote-containers/cloneInVolume?url=https://github.com/microsoft/vscode) для начала работы. Это автоматически установит расширение Dev Containers при необходимости, склонирует исходный код в том контейнера и запустит dev-контейнер для использования.

* Для Codespaces установите расширение [GitHub Codespaces](https://marketplace.visualstudio.com/items?itemName=GitHub.codespaces) в VS Code и используйте команду **Codespaces: Create New Codespace**.

Docker / Codespace должны иметь как минимум **4 ядра и 6 ГБ ОЗУ (рекомендуется 8 ГБ)** для полной сборки. Дополнительную информацию смотрите в [README контейнера разработки](.devcontainer/README.md).

## Кодекс поведения

В этом проекте принят [Кодекс поведения Microsoft Open Source](https://opensource.microsoft.com/codeofconduct/). Подробнее см. [FAQ по кодексу поведения](https://opensource.microsoft.com/codeofconduct/faq/) или обращайтесь по адресу [opencode@microsoft.com](mailto:opencode@microsoft.com) с любыми дополнительными вопросами или комментариями.

## Лицензия

Copyright (c) Microsoft Corporation. Все права защищены.

Лицензировано по [MIT](LICENSE.txt) лицензии.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---