## Vue 2 достиг конца срока поддержки (End of Life)

**Вы просматриваете неактивный репозиторий Vue 2. Актуальный и поддерживаемый репозиторий последней версии Vue находится здесь: [vuejs/core](https://github.com/vuejs/core).**

Vue достиг конца срока поддержки 31 декабря 2023 года. Он больше не получает новых функций, обновлений или исправлений. Тем не менее, он все еще доступен через все существующие каналы распространения (CDN, менеджеры пакетов, Github и др.).

Если вы начинаете новый проект, пожалуйста, используйте последнюю версию Vue (3.x). Мы также настоятельно рекомендуем текущим пользователям Vue 2 выполнить обновление ([руководство](https://v3-migration.vuejs.org/)), однако мы понимаем, что не у всех пользователей есть возможность или мотивация сделать это. Если вы вынуждены оставаться на Vue 2, но у вас есть требования по соответствию или безопасности для неподдерживаемого ПО, ознакомьтесь с [Vue 2 NES](https://www.herodevs.com/support/nes-vue?utm_source=vuejs-github&utm_medium=vue2-readme).

<p align="center"><a href="https://vuejs.org" target="_blank" rel="noopener noreferrer"><img width="100" src="https://vuejs.org/images/logo.png" alt="Vue logo"></a></p>

<p align="center">
  <a href="https://circleci.com/gh/vuejs/vue/tree/dev"><img src="https://img.shields.io/circleci/project/github/vuejs/vue/dev.svg?sanitize=true" alt="Build Status"></a>
  <a href="https://codecov.io/github/vuejs/vue?branch=dev"><img src="https://img.shields.io/codecov/c/github/vuejs/vue/dev.svg?sanitize=true" alt="Coverage Status"></a>
  <a href="https://npmcharts.com/compare/vue?minimal=true"><img src="https://img.shields.io/npm/dm/vue.svg?sanitize=true" alt="Downloads"></a>
  <a href="https://www.npmjs.com/package/vue"><img src="https://img.shields.io/npm/v/vue.svg?sanitize=true" alt="Version"></a>
  <a href="https://www.npmjs.com/package/vue"><img src="https://img.shields.io/npm/l/vue.svg?sanitize=true" alt="License"></a>
  <a href="https://chat.vuejs.org/"><img src="https://img.shields.io/badge/chat-on%20discord-7289da.svg?sanitize=true" alt="Chat"></a>
</p>

## Спонсоры

Vue.js — это проект с открытым исходным кодом под лицензией MIT, развитие которого полностью обеспечивается поддержкой этих замечательных [спонсоров](https://github.com/vuejs/core/blob/main/BACKERS.md). Если вы хотите присоединиться к ним, пожалуйста, рассмотрите возможность [поддержать развитие Vue](https://vuejs.org/sponsor/).

<p align="center">
  <h3 align="center">Особый спонсор</h3>
</p>

<p align="center">
  <a target="_blank" href="https://github.com/appwrite/appwrite">
  <img alt="special sponsor appwrite" src="https://sponsors.vuejs.org/images/appwrite.svg" width="300">
  </a>
</p>

<p align="center">
  <a target="_blank" href="https://vuejs.org/sponsor/">
    <img alt="sponsors" src="https://sponsors.vuejs.org/sponsors.svg?v3">
  </a>
</p>

---

## Введение

Vue (произносится как `/vjuː/`, аналогично "view") — это **прогрессивный фреймворк** для создания пользовательских интерфейсов. Он спроектирован с самого начала так, чтобы быть поэтапно внедряемым и легко масштабироваться от библиотеки до полноценного фреймворка в зависимости от различных сценариев использования. Он состоит из удобной для освоения основной библиотеки, фокусирующейся только на слое представления, и экосистемы вспомогательных библиотек, которые помогают вам справляться со сложностью в крупных одностраничных приложениях (SPA).

#### Совместимость с браузерами

Vue.js поддерживает все браузеры, совместимые со стандартом [ES5](https://compat-table.github.io/compat-table/es5/) (IE8 и ниже не поддерживаются).

## Экосистема

| Проект                | Статус                                                        | Описание                                                |
| --------------------- | ------------------------------------------------------------- | ------------------------------------------------------- |
| [vue-router]          | [![vue-router-status]][vue-router-package]                    | Маршрутизация для одностраничных приложений             |
| [vuex]                | [![vuex-status]][vuex-package]                                | Управление состоянием для крупных приложений            |
| [vue-cli]             | [![vue-cli-status]][vue-cli-package]                          | Шаблоны и генерация проектов                            |
| [vue-loader]          | [![vue-loader-status]][vue-loader-package]                    | Загрузчик компонентов Single File Component (`*.vue`) для webpack |
| [vue-server-renderer] | [![vue-server-renderer-status]][vue-server-renderer-package]  | Поддержка серверного рендеринга                         |
| [vue-class-component] | [![vue-class-component-status]][vue-class-component-package]  | Декоратор TypeScript для API на основе классов          |
| [vue-rx]              | [![vue-rx-status]][vue-rx-package]                            | Интеграция с RxJS                                       |
| [vue-devtools]        | [![vue-devtools-status]][vue-devtools-package]                | Расширение DevTools для браузера                        |

[vue-router]: https://github.com/vuejs/vue-router
[vuex]: https://github.com/vuejs/vuex
[vue-cli]: https://github.com/vuejs/vue-cli
[vue-loader]: https://github.com/vuejs/vue-loader
[vue-server-renderer]: https://github.com/vuejs/vue/tree/dev/packages/vue-server-renderer
[vue-class-component]: https://github.com/vuejs/vue-class-component
[vue-rx]: https://github.com/vuejs/vue-rx
[vue-devtools]: https://github.com/vuejs/vue-devtools
[vue-router-status]: https://img.shields.io/npm/v/vue-router.svg
[vuex-status]: https://img.shields.io/npm/v/vuex.svg
[vue-cli-status]: https://img.shields.io/npm/v/@vue/cli.svg
[vue-loader-status]: https://img.shields.io/npm/v/vue-loader.svg
[vue-server-renderer-status]: https://img.shields.io/npm/v/vue-server-renderer.svg
[vue-class-component-status]: https://img.shields.io/npm/v/vue-class-component.svg
[vue-rx-status]: https://img.shields.io/npm/v/vue-rx.svg
[vue-devtools-status]: https://img.shields.io/chrome-web-store/v/nhdogjmejiglipccpnnnanhbledajbpd.svg
[vue-router-package]: https://npmjs.com/package/vue-router
[vuex-package]: https://npmjs.com/package/vuex
[vue-cli-package]: https://npmjs.com/package/@vue/cli
[vue-loader-package]: https://npmjs.com/package/vue-loader
[vue-server-renderer-package]: https://npmjs.com/package/vue-server-renderer
[vue-class-component-package]: https://npmjs.com/package/vue-class-component
[vue-rx-package]: https://npmjs.com/package/vue-rx
[vue-devtools-package]: https://chrome.google.com/webstore/detail/vuejs-devtools/nhdogjmejiglipccpnnnanhbledajbpd

## Документация

Для просмотра [живых примеров](https://v2.vuejs.org/v2/examples/) и документации посетите [vuejs.org](https://v2.vuejs.org).

## Вопросы

Для вопросов и получения поддержки используйте [официальный форум](https://forum.vuejs.org) или [чат сообщества](https://chat.vuejs.org/). Список задач данного репозитория предназначен **исключительно** для сообщений об ошибках и запросов новых функций.

## Проблемы (Issues)

Пожалуйста, обязательно ознакомьтесь с [чек-листом по созданию задач](https://github.com/vuejs/vue/blob/dev/.github/CONTRIBUTING.md#issue-reporting-guidelines) перед созданием новой задачи. Задачи, не соответствующие этим правилам, могут быть закрыты немедленно.

## Список изменений

Подробные изменения для каждого релиза документируются в [заметках о релизах](https://github.com/vuejs/vue/releases).

## Будьте на связи

- [Twitter](https://twitter.com/vuejs)
- [Блог](https://medium.com/the-vue-point)
- [Доска вакансий](https://vuejobs.com/?ref=vuejs)

## Вклад в проект

Пожалуйста, обязательно ознакомьтесь с [Руководством по вкладу](https://github.com/vuejs/vue/blob/dev/.github/CONTRIBUTING.md) перед отправкой pull request. Если у вас есть проект/компонент/инструмент, связанный с Vue, добавьте его с помощью pull request в [этот список](https://github.com/vuejs/awesome-vue)!

Спасибо всем, кто уже внес вклад в развитие Vue!

<a href="https://github.com/vuejs/vue/graphs/contributors"><img src="https://opencollective.com/vuejs/contributors.svg?width=890" /></a>

## Лицензия

[MIT](https://opensource.org/licenses/MIT)

Copyright (c) 2013-настоящее время, Юси (Эван) Ю

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---