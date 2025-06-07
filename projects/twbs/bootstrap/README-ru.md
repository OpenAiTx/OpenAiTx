<p align="center">
  <a href="https://getbootstrap.com/">
    <img src="https://getbootstrap.com/docs/5.3/assets/brand/bootstrap-logo-shadow.png" alt="Bootstrap logo" width="200" height="165">
  </a>
</p>

<h3 align="center">Bootstrap</h3>

<p align="center">
  Современный, интуитивно понятный и мощный фреймворк для фронтенда, ускоряющий и упрощающий веб-разработку.
  <br>
  <a href="https://getbootstrap.com/docs/5.3/"><strong>Изучить документацию Bootstrap »</strong></a>
  <br>
  <br>
  <a href="https://github.com/twbs/bootstrap/issues/new?assignees=-&labels=bug&template=bug_report.yml">Сообщить об ошибке</a>
  ·
  <a href="https://github.com/twbs/bootstrap/issues/new?assignees=&labels=feature&template=feature_request.yml">Запросить функцию</a>
  ·
  <a href="https://themes.getbootstrap.com/">Темы</a>
  ·
  <a href="https://blog.getbootstrap.com/">Блог</a>
</p>


## Bootstrap 5

Наша основная ветка предназначена для разработки релиза Bootstrap 5. Перейдите к ветке [`v4-dev`](https://github.com/twbs/bootstrap/tree/v4-dev), чтобы ознакомиться с readme, документацией и исходным кодом Bootstrap 4.


## Содержание

- [Быстрый старт](#quick-start)
- [Статус](#status)
- [Что включено](#whats-included)
- [Ошибки и запросы функций](#bugs-and-feature-requests)
- [Документация](#documentation)
- [Вклад в проект](#contributing)
- [Сообщество](#community)
- [Версионирование](#versioning)
- [Авторы](#creators)
- [Благодарности](#thanks)
- [Авторские права и лицензия](#copyright-and-license)


## Быстрый старт

Доступно несколько вариантов быстрого старта:

- [Скачать последний релиз](https://github.com/twbs/bootstrap/archive/v5.3.6.zip)
- Клонировать репозиторий: `git clone https://github.com/twbs/bootstrap.git`
- Установить через [npm](https://www.npmjs.com/): `npm install bootstrap@v5.3.6`
- Установить через [yarn](https://yarnpkg.com/): `yarn add bootstrap@v5.3.6`
- Установить через [Bun](https://bun.sh/): `bun add bootstrap@v5.3.6`
- Установить через [Composer](https://getcomposer.org/): `composer require twbs/bootstrap:5.3.6`
- Установить через [NuGet](https://www.nuget.org/): CSS: `Install-Package bootstrap` Sass: `Install-Package bootstrap.sass`

Ознакомьтесь со страницей [Начало работы](https://getbootstrap.com/docs/5.3/getting-started/introduction/) для получения информации о содержимом фреймворка, шаблонах, примерах и многом другом.


## Статус

[![Build Status](https://img.shields.io/github/actions/workflow/status/twbs/bootstrap/js.yml?branch=main&label=JS%20Tests&logo=github)](https://github.com/twbs/bootstrap/actions/workflows/js.yml?query=workflow%3AJS+branch%3Amain)
[![npm version](https://img.shields.io/npm/v/bootstrap?logo=npm&logoColor=fff)](https://www.npmjs.com/package/bootstrap)
[![Gem version](https://img.shields.io/gem/v/bootstrap?logo=rubygems&logoColor=fff)](https://rubygems.org/gems/bootstrap)
[![Meteor Atmosphere](https://img.shields.io/badge/meteor-twbs%3Abootstrap-blue?logo=meteor&logoColor=fff)](https://atmospherejs.com/twbs/bootstrap)
[![Packagist Prerelease](https://img.shields.io/packagist/vpre/twbs/bootstrap?logo=packagist&logoColor=fff)](https://packagist.org/packages/twbs/bootstrap)
[![NuGet](https://img.shields.io/nuget/vpre/bootstrap?logo=nuget&logoColor=fff)](https://www.nuget.org/packages/bootstrap/absoluteLatest)
[![Coverage Status](https://img.shields.io/coveralls/github/twbs/bootstrap/main?logo=coveralls&logoColor=fff)](https://coveralls.io/github/twbs/bootstrap?branch=main)
[![CSS gzip size](https://img.badgesize.io/twbs/bootstrap/main/dist/css/bootstrap.min.css?compression=gzip&label=CSS%20gzip%20size)](https://github.com/twbs/bootstrap/blob/main/dist/css/bootstrap.min.css)
[![CSS Brotli size](https://img.badgesize.io/twbs/bootstrap/main/dist/css/bootstrap.min.css?compression=brotli&label=CSS%20Brotli%20size)](https://github.com/twbs/bootstrap/blob/main/dist/css/bootstrap.min.css)
[![JS gzip size](https://img.badgesize.io/twbs/bootstrap/main/dist/js/bootstrap.min.js?compression=gzip&label=JS%20gzip%20size)](https://github.com/twbs/bootstrap/blob/main/dist/js/bootstrap.min.js)
[![JS Brotli size](https://img.badgesize.io/twbs/bootstrap/main/dist/js/bootstrap.min.js?compression=brotli&label=JS%20Brotli%20size)](https://github.com/twbs/bootstrap/blob/main/dist/js/bootstrap.min.js)
[![Backers on Open Collective](https://img.shields.io/opencollective/backers/bootstrap?logo=opencollective&logoColor=fff)](#backers)
[![Sponsors on Open Collective](https://img.shields.io/opencollective/sponsors/bootstrap?logo=opencollective&logoColor=fff)](#sponsors)


## Что включено

В скачанном архиве вы найдете следующие директории и файлы, логически сгруппированные для удобства и предоставляющие как скомпилированные, так и минифицированные версии.

<details>
  <summary>Содержимое архива</summary>

  ```text
  bootstrap/
  ├── css/
  │   ├── bootstrap-grid.css
  │   ├── bootstrap-grid.css.map
  │   ├── bootstrap-grid.min.css
  │   ├── bootstrap-grid.min.css.map
  │   ├── bootstrap-grid.rtl.css
  │   ├── bootstrap-grid.rtl.css.map
  │   ├── bootstrap-grid.rtl.min.css
  │   ├── bootstrap-grid.rtl.min.css.map
  │   ├── bootstrap-reboot.css
  │   ├── bootstrap-reboot.css.map
  │   ├── bootstrap-reboot.min.css
  │   ├── bootstrap-reboot.min.css.map
  │   ├── bootstrap-reboot.rtl.css
  │   ├── bootstrap-reboot.rtl.css.map
  │   ├── bootstrap-reboot.rtl.min.css
  │   ├── bootstrap-reboot.rtl.min.css.map
  │   ├── bootstrap-utilities.css
  │   ├── bootstrap-utilities.css.map
  │   ├── bootstrap-utilities.min.css
  │   ├── bootstrap-utilities.min.css.map
  │   ├── bootstrap-utilities.rtl.css
  │   ├── bootstrap-utilities.rtl.css.map
  │   ├── bootstrap-utilities.rtl.min.css
  │   ├── bootstrap-utilities.rtl.min.css.map
  │   ├── bootstrap.css
  │   ├── bootstrap.css.map
  │   ├── bootstrap.min.css
  │   ├── bootstrap.min.css.map
  │   ├── bootstrap.rtl.css
  │   ├── bootstrap.rtl.css.map
  │   ├── bootstrap.rtl.min.css
  │   └── bootstrap.rtl.min.css.map
  └── js/
      ├── bootstrap.bundle.js
      ├── bootstrap.bundle.js.map
      ├── bootstrap.bundle.min.js
      ├── bootstrap.bundle.min.js.map
      ├── bootstrap.esm.js
      ├── bootstrap.esm.js.map
      ├── bootstrap.esm.min.js
      ├── bootstrap.esm.min.js.map
      ├── bootstrap.js
      ├── bootstrap.js.map
      ├── bootstrap.min.js
      └── bootstrap.min.js.map
  ```
</details>

Мы предоставляем скомпилированные CSS и JS (`bootstrap.*`), а также скомпилированные и минифицированные CSS и JS (`bootstrap.min.*`). [Source maps](https://web.dev/articles/source-maps) (`bootstrap.*.map`) доступны для использования с инструментами разработчика в некоторых браузерах. JS-файлы с бандлом (`bootstrap.bundle.js` и минифицированный `bootstrap.bundle.min.js`) включают [Popper](https://popper.js.org/docs/v2/).


## Ошибки и запросы функций

Обнаружили ошибку или хотите предложить новую функцию? Пожалуйста, сначала ознакомьтесь с [руководством по работе с задачами](https://github.com/twbs/bootstrap/blob/main/.github/CONTRIBUTING.md#using-the-issue-tracker) и выполните поиск среди существующих и закрытых задач. Если ваша проблема или идея еще не описана, [откройте новую задачу](https://github.com/twbs/bootstrap/issues/new/choose).


## Документация

Документация Bootstrap, находящаяся в корне этого репозитория, построена с помощью [Astro](https://astro.build/) и публично размещается на GitHub Pages по адресу <https://getbootstrap.com/>. Документацию также можно запускать локально.

Поиск по документации осуществляется с помощью [Algolia DocSearch](https://docsearch.algolia.com/).

### Локальный запуск документации

1. Выполните `npm install` для установки зависимостей Node.js, включая Astro (сборщик сайта).
2. Выполните `npm run test` (или другой скрипт npm) для пересборки распределяемых файлов CSS и JavaScript, а также ассетов документации.
3. Из корневого каталога `/bootstrap` выполните команду `npm run docs-serve` в командной строке.
4. Откройте `http://localhost:9001/` в вашем браузере, и вуаля.

Узнайте больше об использовании Astro, прочитав его [документацию](https://docs.astro.build/en/getting-started/).

### Документация для предыдущих релизов

Вы можете найти всю документацию к предыдущим релизам на <https://getbootstrap.com/docs/versions/>.

[Предыдущие релизы](https://github.com/twbs/bootstrap/releases) и их документация также доступны для загрузки.


## Вклад в проект

Пожалуйста, ознакомьтесь с нашими [рекомендациями по внесению вклада](https://github.com/twbs/bootstrap/blob/main/.github/CONTRIBUTING.md). Там содержатся инструкции по созданию задач, стандартам кодирования и заметки по разработке.

Кроме того, если ваш pull request содержит патчи или функции на JavaScript, необходимо добавить [соответствующие модульные тесты](https://github.com/twbs/bootstrap/tree/main/js/tests). Весь HTML и CSS должны соответствовать [Code Guide](https://github.com/mdo/code-guide), поддерживаемому [Марк Отто](https://github.com/mdo).

Настройки редактора доступны в [editor config](https://github.com/twbs/bootstrap/blob/main/.editorconfig) для удобства использования в распространенных текстовых редакторах. Подробнее читайте и скачивайте плагины на <https://editorconfig.org/>.


## Сообщество

Получайте обновления о разработке Bootstrap и общайтесь с поддерживающими проект и участниками сообщества.

- Подписывайтесь на [@getbootstrap в X](https://x.com/getbootstrap).
- Читайте и подписывайтесь на [Официальный блог Bootstrap](https://blog.getbootstrap.com/).
- Задавайте вопросы и изучайте [наши обсуждения на GitHub](https://github.com/twbs/bootstrap/discussions).
- Общайтесь, задавайте вопросы и многое другое на [сообществе Discord](https://discord.gg/bZUvakRU3M) или [сабреддите Bootstrap](https://www.reddit.com/r/bootstrap/).
- Чат с другими пользователями Bootstrap в IRC. Сервер `irc.libera.chat`, канал `#bootstrap`.
- Помощь по реализации можно найти на Stack Overflow (тег [`bootstrap-5`](https://stackoverflow.com/questions/tagged/bootstrap-5)).
- Разработчики должны использовать ключевое слово `bootstrap` для пакетов, которые модифицируют или расширяют функциональность Bootstrap при распространении через [npm](https://www.npmjs.com/browse/keyword/bootstrap) или аналогичные механизмы для максимальной видимости.


## Версионирование

Для прозрачности нашего цикла релизов и стремления к поддержанию обратной совместимости Bootstrap поддерживается в соответствии с [рекомендациями по семантическому версионированию](https://semver.org/). Иногда мы ошибаемся, но стараемся следовать этим правилам, когда это возможно.

Смотрите [раздел Releases нашего проекта на GitHub](https://github.com/twbs/bootstrap/releases) для просмотра изменений в каждой версии Bootstrap. Анонсы релизов в [официальном блоге Bootstrap](https://blog.getbootstrap.com/) содержат краткие обзоры наиболее важных изменений в каждом релизе.


## Авторы

**Марк Отто**

- <https://x.com/mdo>
- <https://github.com/mdo>

**Джейкоб Торнтон**

- <https://x.com/fat>
- <https://github.com/fat>


## Благодарности

<a href="https://www.browserstack.com/">
  <img src="https://live.browserstack.com/images/opensource/browserstack-logo.svg" alt="BrowserStack" width="192" height="42">
</a>

Благодарим [BrowserStack](https://www.browserstack.com/) за предоставление инфраструктуры, которая позволяет нам тестировать в реальных браузерах!

<a href="https://www.netlify.com/">
  <img src="https://www.netlify.com/v3/img/components/full-logo-light.svg" alt="Netlify" width="147" height="40">
</a>

Спасибо [Netlify](https://www.netlify.com/) за предоставление предварительных просмотров Deploy Previews!


## Спонсоры

Поддержите этот проект, став спонсором. Ваш логотип появится здесь со ссылкой на ваш сайт. [[Стать спонсором](https://opencollective.com/bootstrap#sponsor)]

[![OC sponsor 0](https://opencollective.com/bootstrap/sponsor/0/avatar.svg)](https://opencollective.com/bootstrap/sponsor/0/website)
[![OC sponsor 1](https://opencollective.com/bootstrap/sponsor/1/avatar.svg)](https://opencollective.com/bootstrap/sponsor/1/website)
[![OC sponsor 2](https://opencollective.com/bootstrap/sponsor/2/avatar.svg)](https://opencollective.com/bootstrap/sponsor/2/website)
[![OC sponsor 3](https://opencollective.com/bootstrap/sponsor/3/avatar.svg)](https://opencollective.com/bootstrap/sponsor/3/website)
[![OC sponsor 4](https://opencollective.com/bootstrap/sponsor/4/avatar.svg)](https://opencollective.com/bootstrap/sponsor/4/website)
[![OC sponsor 5](https://opencollective.com/bootstrap/sponsor/5/avatar.svg)](https://opencollective.com/bootstrap/sponsor/5/website)
[![OC sponsor 6](https://opencollective.com/bootstrap/sponsor/6/avatar.svg)](https://opencollective.com/bootstrap/sponsor/6/website)
[![OC sponsor 7](https://opencollective.com/bootstrap/sponsor/7/avatar.svg)](https://opencollective.com/bootstrap/sponsor/7/website)
[![OC sponsor 8](https://opencollective.com/bootstrap/sponsor/8/avatar.svg)](https://opencollective.com/bootstrap/sponsor/8/website)
[![OC sponsor 9](https://opencollective.com/bootstrap/sponsor/9/avatar.svg)](https://opencollective.com/bootstrap/sponsor/9/website)


## Поддержавшие

Спасибо всем нашим поддержавшим! 🙏 [[Стать поддержавшим](https://opencollective.com/bootstrap#backer)]

[![Backers](https://opencollective.com/bootstrap/backers.svg?width=890)](https://opencollective.com/bootstrap#backers)


## Авторские права и лицензия

Код и документация защищены авторским правом 2011-2025 [Авторы Bootstrap](https://github.com/twbs/bootstrap/graphs/contributors). Код распространяется под [лицензией MIT](https://github.com/twbs/bootstrap/blob/main/LICENSE). Документация распространяется под лицензией [Creative Commons](https://creativecommons.org/licenses/by/3.0/).

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---