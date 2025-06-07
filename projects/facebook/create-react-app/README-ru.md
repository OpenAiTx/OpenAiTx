## Create React App [![Build & Test](https://github.com/facebook/create-react-app/actions/workflows/build-and-test.yml/badge.svg?branch=main)](https://github.com/facebook/create-react-app/actions/workflows/build-and-test.yml) [![PRs Welcome](https://img.shields.io/badge/PRs-welcome-green.svg)](https://github.com/facebook/create-react-app/blob/main/CONTRIBUTING.md)

> [!CAUTION]
>
> ## Устарело
>
> Create React App был одним из ключевых инструментов для быстрого запуска проектов на React в 2017–2021 годах, сейчас он находится в долгосрочной стагнации, и мы рекомендуем перейти на один из React-фреймворков, описанных в разделе [Начало нового проекта на React](https://react.dev/learn/start-a-new-react-project).
>
> Если вы проходите учебное пособие по изучению React, продолжение обучения по вашему туториалу все еще имеет смысл, но мы не рекомендуем начинать новые production-приложения на основе Create React App.

<img alt="Logo" align="right" src="https://create-react-app.dev/img/logo.svg" width="20%" />

Создавайте React-приложения без необходимости настройки сборки.

- [Создание приложения](#creating-an-app) – Как создать новое приложение.
- [Руководство пользователя](https://facebook.github.io/create-react-app/) – Как разрабатывать приложения, созданные с помощью Create React App.

Create React App работает на macOS, Windows и Linux.<br>
Если что-то не работает, пожалуйста, [создайте обращение](https://github.com/facebook/create-react-app/issues/new).<br>
Если у вас есть вопросы или нужна помощь, задайте их в [GitHub Discussions](https://github.com/facebook/create-react-app/discussions).

## Быстрый старт

```sh
npx create-react-app my-app
cd my-app
npm start
```

Если вы ранее устанавливали `create-react-app` глобально с помощью `npm install -g create-react-app`, мы рекомендуем удалить этот пакет командой `npm uninstall -g create-react-app` или `yarn global remove create-react-app`, чтобы npx всегда использовал последнюю версию.

_([npx](https://medium.com/@maybekatz/introducing-npx-an-npm-package-runner-55f7d4bd282b) доступен в npm версии 5.2+ и выше, смотрите [инструкции для старых версий npm](https://gist.github.com/gaearon/4064d3c23a77c74a3614c498a8bb1c5f))_

Затем откройте [http://localhost:3000/](http://localhost:3000/), чтобы увидеть ваше приложение.<br>
Когда вы будете готовы к деплою в production, создайте минифицированный бандл с помощью `npm run build`.

<p align='center'>
<img src='https://cdn.jsdelivr.net/gh/facebook/create-react-app@27b42ac7efa018f2541153ab30d63180f5fa39e0/screencast.svg' width='600' alt='npm start'>
</p>

### Начните сразу

Вам **не нужно** устанавливать или настраивать инструменты, такие как webpack или Babel.<br>
Они уже преднастроены и скрыты, чтобы вы могли сосредоточиться на коде.

Создайте проект — и вы готовы приступить к работе.

## Создание приложения

**Вам потребуется Node версии 14.0.0 или выше на вашей локальной машине для разработки** (на сервере это не требуется). Мы рекомендуем использовать последнюю LTS-версию. Для переключения между версиями Node вы можете использовать [nvm](https://github.com/creationix/nvm#installation) (macOS/Linux) или [nvm-windows](https://github.com/coreybutler/nvm-windows#node-version-manager-nvm-for-windows).

Для создания нового приложения вы можете выбрать один из следующих способов:

### npx

```sh
npx create-react-app my-app
```

_([npx](https://medium.com/@maybekatz/introducing-npx-an-npm-package-runner-55f7d4bd282b) — это инструмент для запуска пакетов, который входит в состав npm 5.2+ и выше, смотрите [инструкции для старых версий npm](https://gist.github.com/gaearon/4064d3c23a77c74a3614c498a8bb1c5f))_

### npm

```sh
npm init react-app my-app
```

_`npm init <initializer>` доступен в npm 6+_

### Yarn

```sh
yarn create react-app my-app
```

_[`yarn create <starter-kit-package>`](https://yarnpkg.com/lang/en/docs/cli/create/) доступен в Yarn 0.25+_

Будет создана директория с именем `my-app` внутри текущей папки.<br>
Внутри нее будет сгенерирована структура проекта и установлены все транзитивные зависимости:

```
my-app
├── README.md
├── node_modules
├── package.json
├── .gitignore
├── public
│   ├── favicon.ico
│   ├── index.html
│   └── manifest.json
└── src
    ├── App.css
    ├── App.js
    ├── App.test.js
    ├── index.css
    ├── index.js
    ├── logo.svg
    └── serviceWorker.js
    └── setupTests.js
```

Без лишней конфигурации или сложных структур папок — только необходимые файлы для разработки вашего приложения.<br>
После завершения установки вы можете открыть папку с проектом:

```sh
cd my-app
```

Внутри только что созданного проекта доступны некоторые встроенные команды:

### `npm start` или `yarn start`

Запускает приложение в режиме разработки.<br>
Откройте [http://localhost:3000](http://localhost:3000) для просмотра в браузере.

Страница будет автоматически перезагружаться при изменении кода.<br>
Ошибки сборки и предупреждения линтера будут отображаться в консоли.

<p align='center'>
<img src='https://cdn.jsdelivr.net/gh/marionebl/create-react-app@9f6282671c54f0874afd37a72f6689727b562498/screencast-error.svg' width='600' alt='Build errors'>
</p>

### `npm test` или `yarn test`

Запускает watcher для тестов в интерактивном режиме.<br>
По умолчанию выполняет тесты для файлов, изменённых с момента последнего коммита.

[Подробнее о тестировании.](https://facebook.github.io/create-react-app/docs/running-tests)

### `npm run build` или `yarn build`

Собирает приложение для production в папку `build`.<br>
Корректно собирает React в production-режиме и оптимизирует сборку для максимальной производительности.

Сборка минифицирована, имена файлов содержат хэши.<br>

Ваше приложение готово к деплою.

## Руководство пользователя

Подробные инструкции по использованию Create React App и множество советов вы найдете в [документации](https://facebook.github.io/create-react-app/).

## Как обновиться до новых версий?

Пожалуйста, обратитесь к [Руководству пользователя](https://facebook.github.io/create-react-app/docs/updating-to-new-releases) для этой и другой информации.

## Философия

- **Одна зависимость:** Только одна зависимость для сборки. Используется webpack, Babel, ESLint и другие отличные проекты, но поверх них предоставляется единый, выверенный опыт.

- **Без необходимости конфигурирования:** Вам не нужно ничего настраивать. Хорошая конфигурация для разработки и production уже сделана за вас, чтобы вы могли сосредоточиться на написании кода.

- **Без блокировки:** В любой момент вы можете “извлечь” (eject) всю конфигурацию и зависимости сборки в ваш проект одной командой, чтобы полностью контролировать процесс.

## Что включено?

Ваша среда будет включать все необходимое для создания современного одностраничного приложения на React:

- Поддержка React, JSX, ES6, TypeScript и Flow.
- Дополнительные возможности языка поверх ES6, такие как оператор spread для объектов.
- Автоматическая префиксация CSS, чтобы вам не нужны были `-webkit-` и другие префиксы.
- Быстрый интерактивный запуск юнит-тестов с поддержкой отчётов о покрытии.
- Сервер разработки с предупреждениями о распространённых ошибках.
- Скрипт сборки для объединения JS, CSS и изображений для production с хэшами и sourcemap.
- Ориентированный на офлайн [service worker](https://developers.google.com/web/fundamentals/getting-started/primers/service-workers) и [web app manifest](https://developers.google.com/web/fundamentals/engage-and-retain/web-app-manifest/), соответствующие всем критериям [Progressive Web App](https://facebook.github.io/create-react-app/docs/making-a-progressive-web-app). (_Примечание: Использование service worker является опциональным начиная с `react-scripts@2.0.0` и выше_)
- Беспроблемные обновления указанных выше инструментов через одну зависимость.

Ознакомьтесь с [этим гайдом](https://github.com/nitishdayal/cra_closer_look) для обзора того, как эти инструменты работают вместе.

Обратная сторона — **эти инструменты преднастроены для работы определённым образом**. Если вашему проекту требуется больше кастомизации, вы можете ["извлечь"](https://facebook.github.io/create-react-app/docs/available-scripts#npm-run-eject) конфигурацию и настроить всё под себя, но тогда вам придётся поддерживать конфигурацию самостоятельно.

## Популярные альтернативы

Create React App отлично подходит для:

- **Изучения React** в удобной и функциональной среде разработки.
- **Создания новых одностраничных React-приложений.**
- **Создания примеров** для ваших библиотек и компонентов на React.

Вот несколько типовых случаев, когда стоит попробовать что-то другое:

- Если вы хотите **попробовать React** без сотен зависимостей для сборки, [используйте один HTML-файл или онлайн-песочницу](https://reactjs.org/docs/getting-started.html#try-react).

- Если вам нужно **интегрировать код React с серверным шаблонизатором** (Rails, Django или Symfony), либо вы **не делаете одностраничное приложение**, рассмотрите [nwb](https://github.com/insin/nwb) или [Neutrino](https://neutrino.js.org/), которые более гибкие. Для Rails можно использовать [Rails Webpacker](https://github.com/rails/webpacker). Для Symfony попробуйте [webpack Encore от Symfony](https://symfony.com/doc/current/frontend/encore/reactjs.html).

- Если вам нужно **опубликовать React-компонент**, [nwb](https://github.com/insin/nwb) [тоже поддерживает это](https://github.com/insin/nwb#react-components-and-libraries), как и [react-components пресет в Neutrino](https://neutrino.js.org/packages/react-components/).

- Для **серверного рендеринга** с React и Node.js смотрите [Next.js](https://nextjs.org/) или [Razzle](https://github.com/jaredpalmer/razzle). Create React App не зависит от backend и создаёт только статические HTML/JS/CSS-бандлы.

- Если ваш сайт **преимущественно статичный** (например, портфолио или блог), рассмотрите [Gatsby](https://www.gatsbyjs.org/) или [Next.js](https://nextjs.org/). В отличие от Create React App, Gatsby заранее генерирует HTML при сборке. Next.js поддерживает и серверный рендеринг, и предварительный рендеринг.

- Если вам нужна **большая гибкость**, попробуйте [Neutrino](https://neutrino.js.org/) и его [React пресет](https://neutrino.js.org/packages/react/).

Все эти инструменты могут работать практически без дополнительной настройки.

Если вы предпочитаете настраивать сборку самостоятельно, [следуйте этому руководству](https://reactjs.org/docs/add-react-to-a-website.html).

## React Native

Ищете что-то похожее для React Native?<br>
Посмотрите [Expo CLI](https://github.com/expo/expo-cli).

## Вклад

Мы будем рады вашей помощи в проекте `create-react-app`! Смотрите [CONTRIBUTING.md](CONTRIBUTING.md) для дополнительной информации о том, что нам нужно и как начать.

## Поддержка Create React App

Create React App — проект, поддерживаемый сообществом, все участники — волонтёры. Если вы хотите поддержать будущее развитие Create React App, рассмотрите возможность пожертвования на наш [Open Collective](https://opencollective.com/create-react-app).

## Благодарности

Этот проект существует благодаря всем, кто [вносит вклад](CONTRIBUTING.md).<br>
<a href="https://github.com/facebook/create-react-app/graphs/contributors"><img src="https://opencollective.com/create-react-app/contributors.svg?width=890&button=false" /></a>

Спасибо [Netlify](https://www.netlify.com/) за хостинг нашей документации.

## Признательность

Мы благодарны авторам схожих проектов за их идеи и сотрудничество:

- [@eanplatter](https://github.com/eanplatter)
- [@insin](https://github.com/insin)
- [@mxstbr](https://github.com/mxstbr)

## Лицензия

Create React App — это open source ПО [с лицензией MIT](https://github.com/facebook/create-react-app/blob/main/LICENSE). Логотип Create React App лицензирован по [Creative Commons Attribution 4.0 International license](https://creativecommons.org/licenses/by/4.0/).

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---