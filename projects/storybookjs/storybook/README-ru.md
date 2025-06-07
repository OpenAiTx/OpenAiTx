<p align="center">
  <a href="https://storybook.js.org/">
    <picture>
      <source media="(prefers-color-scheme: dark)" srcset="https://user-images.githubusercontent.com/263385/199832481-bbbf5961-6a26-481d-8224-51258cce9b33.png">
      <img src="https://user-images.githubusercontent.com/321738/63501763-88dbf600-c4cc-11e9-96cd-94adadc2fd72.png" alt="Storybook" width="400" />
    </picture>
  </a>
</p>

<p align="center">Создавайте надежные UI-компоненты быстрее</p>

<br/>

<p align="center">
  <a href="https://circleci.com/gh/storybookjs/storybook">
    <img src="https://circleci.com/gh/storybookjs/storybook.svg?style=shield" alt="Build Status on CircleCI" />
  </a>
  <a href="https://codecov.io/gh/storybookjs/storybook">
    <img src="https://codecov.io/gh/storybookjs/storybook/branch/main/graph/badge.svg" alt="codecov" />
  </a>
  <a href="https://github.com/storybookjs/storybook/blob/main/LICENSE">
    <img src="https://img.shields.io/github/license/storybookjs/storybook.svg" alt="License" />
  </a>
  <br/>
  <a href="https://discord.gg/storybook">
    <img src="https://img.shields.io/badge/discord-join-7289DA.svg?logo=discord&longCache=true&style=flat" />
  </a>
  <a href="https://storybook.js.org/community/">
    <img src="https://img.shields.io/badge/community-join-4BC424.svg" alt="Storybook Community" />
  </a>
  <a href="#backers">
    <img src="https://opencollective.com/storybook/backers/badge.svg" alt="Backers on Open Collective" />
  </a>
  <a href="#sponsors">
    <img src="https://opencollective.com/storybook/tiers/sponsors/badge.svg" alt="Sponsors on Open Collective" />
  </a>
  <a href="https://x.com/intent/follow?screen_name=storybookjs">
    <img src="https://img.shields.io/twitter/follow/storybookjs?color=blue&logo=twitter" alt="Official Twitter Handle" />
  </a>
  <a href="https://api.securityscorecards.dev/projects/github.com/storybookjs/storybook">
    <img src="https://api.securityscorecards.dev/projects/github.com/storybookjs/storybook/badge" alt="OpenSSF Scorecard"/>
  </a>
</p>

<p align="center">
Storybook — это фронтенд-лаборатория для создания UI-компонентов и страниц в изоляции. Тысячи команд используют его для разработки, тестирования и документирования пользовательских интерфейсов. Узнайте больше на https://storybook.js.org!
</p>

<center>
  <img src="https://raw.githubusercontent.com/storybookjs/storybook/main/media/storybook-intro.gif" width="100%" />
</center>

<p align="center">
  Смотрите README для:<br/>
  <a href="https://github.com/storybookjs/storybook/blob/main/README.md" title="latest"><img alt="latest" src="https://img.shields.io/npm/v/@storybook/react/latest?style=for-the-badge&logo=storybook&logoColor=ffffff&color=66BF3C" /></a>
  <a href="https://github.com/storybookjs/storybook/blob/next/README.md" title="next"><img alt="next" src="https://img.shields.io/npm/v/@storybook/react/next?style=for-the-badge&logo=storybook&logoColor=ffffff&color=1EA7FD" /></a>
</p>

## Содержание

- 🚀 [Начало работы](#getting-started)
- 📒 [Проекты](#projects)
  - 🛠 [Поддерживаемые фреймворки и примеры](#supported-frameworks)
  - 🔗[Плагины](#addons)
- 🏅 [Бейджи и презентационные материалы](#badges--presentation-materials)
- 👥 [Сообщество](#community)
- 👏 [Вклад в проект](#contributing)
  - 👨‍💻 [Скрипты разработки](#development-scripts)
  - 💸 [Спонсоры](#sponsors)
  - 💵 [Поддержка](#backers)
- :memo: [Лицензия](#license)

## Начало работы

Посетите [сайт Storybook](https://storybook.js.org), чтобы узнать больше о Storybook и начать работу.

### Документация

Документация доступна на [сайте документации Storybook](https://storybook.js.org/docs).

### Примеры

Посмотрите [Энциклопедию компонентов](https://storybook.js.org/showcase), чтобы узнать, как ведущие команды используют Storybook.

Используйте [storybook.new](https://storybook.new), чтобы быстро создать пример проекта в Stackblitz.

Storybook поставляется с множеством [плагинов](https://storybook.js.org/docs/configure/user-interface/storybook-addons) для дизайна компонентов, документации, тестирования, интерактивности и многого другого. API Storybook позволяет настраивать и расширять его различными способами. Storybook также расширен для поддержки разработки на React Native, Android, iOS и Flutter для мобильных устройств.

### Сообщество

Для получения дополнительной помощи опубликуйте ваш вопрос в [GitHub Discussions репозитория](https://github.com/storybookjs/storybook/discussions/new?category=help).

## Проекты

### Поддерживаемые фреймворки

| Рендерер                                                       | Демо                                                                                                                                                                         |                                                                                                                                                       |
| -------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------- |
| [React](code/renderers/react)                                  | [![Storybook demo](https://img.shields.io/npm/v/@storybook/react/latest?style=flat-square&color=blue&label)](https://next--630511d655df72125520f051.chromatic.com/)          | [![React](https://img.shields.io/npm/dm/@storybook/react?style=flat-square&color=eee)](code/renderers/react)                                          |
| [Angular](code/frameworks/angular/)                            | [![Storybook demo](https://img.shields.io/npm/v/@storybook/angular/latest?style=flat-square&color=blue&label)](https://next--6322ce6af69825592bbb28fc.chromatic.com/)        | [![Angular](https://img.shields.io/npm/dm/@storybook/angular?style=flat-square&color=eee)](code/frameworks/angular/)                                  |
| [Vue 3](code/renderers/vue3)                                   | [![Storybook demo](https://img.shields.io/npm/v/@storybook/vue3/latest?style=flat-square&color=blue&label)](https://next--630513346a8e284ae244d415.chromatic.com/)           | [![Vue 3](https://img.shields.io/npm/dm/@storybook/vue3?style=flat-square&color=eee)](code/renderers/vue3/)                                           |
| [Web components](code/renderers/web-components)                | [![Storybook demo](https://img.shields.io/npm/v/@storybook/web-components/latest?style=flat-square&color=blue&label)](https://next--638db5bf49adfdfe8cf545e0.chromatic.com/) | [![Svelte](https://img.shields.io/npm/dm/@storybook/web-components?style=flat-square&color=eee)](code/renderers/web-components)                       |
| [React Native](https://github.com/storybookjs/react-native)    | [![](https://img.shields.io/npm/v/@storybook/react-native/latest?style=flat-square&color=blue&label)](/)                                                                     | [![React Native](https://img.shields.io/npm/dm/@storybook/react-native?style=flat-square&color=eee)](https://github.com/storybookjs/react-native)     |
| [HTML](code/renderers/html)                                    | [![Storybook demo](https://img.shields.io/npm/v/@storybook/html/latest?style=flat-square&color=blue&label)](https://next--63dd39a158cf6fc05199b4bb.chromatic.com/)           | [![HTML](https://img.shields.io/npm/dm/@storybook/html?style=flat-square&color=eee)](code/renderers/html)                                             |
| [Ember](code/frameworks/ember/)                                | [![](https://img.shields.io/npm/v/@storybook/ember/latest?style=flat-square&color=blue&label)](/)                                                                            | [![Ember](https://img.shields.io/npm/dm/@storybook/ember?style=flat-square&color=eee)](code/frameworks/ember/)                                        |
| [Svelte](code/renderers/svelte)                                | [![Storybook demo](https://img.shields.io/npm/v/@storybook/svelte/latest?style=flat-square&color=blue&label)](https://next--630873996e4e3557791c069c.chromatic.com/)         | [![Svelte](https://img.shields.io/npm/dm/@storybook/svelte?style=flat-square&color=eee)](code/renderers/svelte)                                       |
| [Preact](code/renderers/preact)                                | [![Storybook demo](https://img.shields.io/npm/v/@storybook/preact/latest?style=flat-square&color=blue&label)](https://next--63b588a512565bfaace15e7c.chromatic.com/)         | [![Preact](https://img.shields.io/npm/dm/@storybook/preact?style=flat-square&color=eee)](code/renderers/preact)                                       |
| [Qwik](https://github.com/literalpie/storybook-framework-qwik) | [![](https://img.shields.io/npm/v/storybook-framework-qwik/latest?style=flat-square&color=blue&label)](/)                                                                    | [![Qwik](https://img.shields.io/npm/dm/storybook-framework-qwik?style=flat-square&color=eee)](https://github.com/literalpie/storybook-framework-qwik) |
| [SolidJS](https://github.com/storybookjs/solidjs)              | [![](https://img.shields.io/npm/v/storybook-solidjs/latest?style=flat-square&color=blue&label)](/)                                                                           | [![SolidJS](https://img.shields.io/npm/dm/storybook-solidjs?style=flat-square&color=eee)](https://github.com/storybookjs/solidjs)                     |
| [Android, iOS, Flutter](https://github.com/storybookjs/native) | [![](https://img.shields.io/npm/v/@storybook/native/latest?style=flat-square&color=blue&label)](/)                                                                           | [![Native](https://img.shields.io/npm/dm/@storybook/native?style=flat-square&color=eee)](https://github.com/storybookjs/native)                       |

### Плагины

| Плагины                                                                    |                                                                            |
| ------------------------------------------------------------------------- | -------------------------------------------------------------------------- |
| [a11y](code/addons/a11y/)                                                 | Тестируйте компоненты на доступность для пользователей в Storybook          |
| [actions](code/core/src/actions/)                                         | Логируйте действия при взаимодействии пользователей с компонентами в UI     |
| [backgrounds](code/core/src/backgrounds)                                  | Позволяет выбирать фоны в интерфейсе Storybook                             |
| [cssresources](https://github.com/storybookjs/addon-cssresources)         | Динамически добавляйте/удаляйте CSS-ресурсы в iframe компонента            |
| [design assets](https://github.com/storybookjs/addon-design-assets)       | Просматривайте изображения, видео и ссылки рядом с вашими историями         |
| [docs](code/addons/docs/)                                                 | Добавляйте качественную документацию к вашим компонентам                   |
| [events](https://github.com/storybookjs/addon-events)                     | Интерактивно отправляйте события компонентам, реагирующим на EventEmitter  |
| [google-analytics](https://github.com/storybookjs/addon-google-analytics) | Отчеты Google Analytics по историям                                        |
| [graphql](https://github.com/storybookjs/addon-graphql)                   | Выполнение запросов к GraphQL-серверу внутри историй Storybook             |
| [jest](code/addons/jest/)                                                 | Просмотр результатов юнит-тестов компонентов в Storybook                   |
| [links](code/addons/links/)                                               | Создавайте ссылки между историями                                          |
| [measure](code/core/src/measure/)                                         | Визуальный анализ layout и box-модели в Storybook UI                       |
| [outline](code/core/src/outline/)                                         | Визуальная отладка CSS-раскладки и выравнивания в Storybook UI             |
| [query params](https://github.com/storybookjs/addon-queryparams)          | Мокаем параметры запроса                                                   |
| [viewport](code/core/src/viewport/)                                       | Изменяйте размеры экрана и макеты для адаптивных компонентов с помощью Storybook |

Смотрите [Таблицу поддержки плагинов/фреймворков](https://storybook.js.org/docs/configure/integration/frameworks-feature-support)

Для улучшения вашего опыта мы со временем вынуждены устаревать или удалять некоторые плагины в пользу новых и лучших инструментов.

Если вы используете info/notes, настоятельно рекомендуем перейти на [docs](code/addons/docs/), а [здесь инструкция](code/addons/docs/docs/recipes.md#migrating-from-notesinfo-addons).

Если вы используете contexts, настоятельно рекомендуем перейти на [toolbars](https://github.com/storybookjs/storybook/tree/next/code/addons/toolbars), а [здесь инструкция](https://github.com/storybookjs/storybook/blob/next/MIGRATION.md#deprecated-addon-contexts).

Если вы используете addon-storyshots, настоятельно рекомендуем перейти на [test-runner](https://github.com/storybookjs/test-runner), а [здесь инструкция](https://storybook.js.org/docs/writing-tests/storyshots-migration-guide).

## Бейджи и презентационные материалы

У нас есть бейдж! Ссылайтесь на ваш живой пример Storybook.

![Storybook](https://cdn.jsdelivr.net/gh/storybookjs/brand@main/badge/badge-storybook.svg)

```md
[![Storybook](https://cdn.jsdelivr.net/gh/storybookjs/brand@main/badge/badge-storybook.svg)](ссылка на сайт)
```

Если вам нужны материалы для вашей презентации Storybook (логотипы, видео, палитра цветов), всё это можно найти в нашем [репозитории бренда](https://github.com/storybookjs/brand).

## Сообщество

- Твиттер: [@storybookjs](https://x.com/storybookjs)
- Блог на [storybook.js.org](https://storybook.js.org/blog/) и [Medium](https://medium.com/storybookjs)
- Чат в [Discord](https://discord.gg/storybook)
- Видео и стримы на [YouTube](https://www.youtube.com/channel/UCr7Quur3eIyA_oe8FNYexfg)

## Вклад в проект

Вклад в Storybook всегда приветствуется!

- 📥 Pull requests и 🌟 Stars всегда приветствуются.
- Прочитайте наше [руководство по вкладу](CONTRIBUTING.md) для начала работы,
  или найдите нас в [Discord](https://discord.gg/storybook) — мы поможем вам разобраться.

Ищете первую задачу?

- Мы помечаем задачи как [![Good First Issue](https://img.shields.io/github/issues/storybookjs/storybook/good%20first%20issue.svg)](https://github.com/storybookjs/storybook/issues?q=is%3Aopen+is%3Aissue+label%3A%22good+first+issue%22), если они хорошо подходят новичкам или тем, кто только начинает с open source.
- [Напишите нам](https://discord.gg/storybook), мы подберем задачу под ваши навыки и интересы.

### Скрипты разработки

Storybook организован как монорепозиторий. Полезные скрипты:

#### `yarn start`

> Запускает Storybook-песочницу с тестовыми историями

#### `yarn task`

> То же, но позволяет настраивать песочницу (например, выбирать другие фреймворки)

#### `yarn lint`

> Проверка кода на соответствие правилам линтера — используется remark и eslint

- `yarn lint:js` — проверяет js
- `yarn lint:md` — проверяет markdown и примеры кода
- `yarn lint:js --fix` — автоматически исправляет js

#### `yarn test`

> Проверка успешного прохождения всех юнит-тестов — используется jest

- `yarn run test --core --watch` — запускает core-тесты в режиме наблюдения

### Спонсоры

Станьте спонсором, чтобы ваш логотип и ссылка на сайт появились в нашем README на Github. \[[Стать спонсором](https://opencollective.com/storybook#sponsor)]

<a href="https://opencollective.com/storybook/tiers/sponsors/0/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/0/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/1/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/1/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/2/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/2/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/3/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/3/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/4/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/4/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/5/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/5/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/6/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/6/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/7/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/7/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/8/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/8/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/9/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/9/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/10/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/10/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/11/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/11/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/12/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/12/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/13/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/13/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/14/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/14/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/15/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/15/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/16/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/16/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/17/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/17/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/18/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/18/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/19/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/19/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/20/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/20/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/21/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/21/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/22/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/22/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/23/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/23/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/24/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/24/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/25/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/25/avatar.svg?requireActive=true"></a>

### Поддержка

Регулярные пожертвования помогают нам и нашей работе. \[[Стать поддерживающим](https://opencollective.com/storybook#backer)]

<a href="https://opencollective.com/storybook"><img src="https://opencollective.com/storybook/tiers/backers.svg?limit=80&button=false&avatarHeight=46&width=750"></a>

## Лицензия

[MIT](https://github.com/storybookjs/storybook/blob/main/LICENSE)

-the end-

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---