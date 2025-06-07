<h1 align="center">
  <a href="https://reactnative.dev/">
    React Native
  </a>
</h1>

<p align="center">
  <strong>Учитесь один раз, пишите везде:</strong><br>
  Создавайте мобильные приложения с помощью React.
</p>

<p align="center">
  <a href="https://github.com/facebook/react-native/blob/HEAD/LICENSE">
    <img src="https://img.shields.io/badge/license-MIT-blue.svg" alt="React Native распространяется по лицензии MIT." />
  </a>
  <a href="https://www.npmjs.org/package/react-native">
    <img src="https://img.shields.io/npm/v/react-native?color=brightgreen&label=npm%20package" alt="Текущая версия npm-пакета." />
  </a>
  <a href="https://reactnative.dev/docs/contributing">
    <img src="https://img.shields.io/badge/PRs-welcome-brightgreen.svg" alt="PRs приветствуются!" />
  </a>
  <a href="https://twitter.com/intent/follow?screen_name=reactnative">
    <img src="https://img.shields.io/twitter/follow/reactnative.svg?label=Follow%20@reactnative" alt="Подписаться на @reactnative" />
  </a>
</p>

<h3 align="center">
  <a href="https://reactnative.dev/docs/getting-started">Начало работы</a>
  <span> · </span>
  <a href="https://reactnative.dev/docs/tutorial">Изучите основы</a>
  <span> · </span>
  <a href="https://reactnative.dev/showcase">Примеры</a>
  <span> · </span>
  <a href="https://reactnative.dev/docs/contributing">Вклад</a>
  <span> · </span>
  <a href="https://reactnative.dev/help">Сообщество</a>
  <span> · </span>
  <a href="https://github.com/facebook/react-native/blob/HEAD/.github/SUPPORT.md">Поддержка</a>
</h3>

React Native переносит декларативный UI-фреймворк [**React**][r] на iOS и Android. С помощью React Native вы используете нативные UI-компоненты и получаете полный доступ к платформе.

- **Декларативность.** React облегчает создание интерактивных пользовательских интерфейсов. Декларативные представления делают ваш код более предсказуемым и простым для отладки.
- **Компонентный подход.** Создавайте инкапсулированные компоненты, которые управляют своим состоянием, а затем объединяйте их для построения сложных интерфейсов.
- **Скорость разработки.** Смотрите изменения локально за считанные секунды. Изменения в JavaScript-коде можно применять без пересборки нативного приложения.
- **Портируемость.** Переиспользуйте код между iOS, Android и [другими платформами][p].

React Native разрабатывается и поддерживается множеством компаний и индивидуальных участников. Подробнее читайте в нашем [обзоре экосистемы][e].

[r]: https://react.dev/
[p]: https://reactnative.dev/docs/out-of-tree-platforms
[e]: https://github.com/facebook/react-native/blob/HEAD/ECOSYSTEM.md

## Содержание

- [Требования](#-requirements)
- [Создание первого приложения на React Native](#-building-your-first-react-native-app)
- [Документация](#-documentation)
- [Обновление](#-upgrading)
- [Как внести вклад](#-how-to-contribute)
- [Кодекс поведения](#code-of-conduct)
- [Лицензия](#-license)


## 📋 Требования

Приложения на React Native могут быть ориентированы на iOS 15.1 и Android 7.0 (API 24) или новее. Вы можете использовать Windows, macOS или Linux в качестве операционной системы для разработки, однако сборка и запуск приложений для iOS возможны только на macOS. Для обхода этого ограничения можно использовать такие инструменты, как [Expo](https://expo.dev).

## 🎉 Создание первого приложения на React Native

Следуйте [руководству по началу работы](https://reactnative.dev/docs/getting-started). Рекомендуемый способ установки React Native зависит от вашего проекта. Здесь вы найдете краткие инструкции для наиболее распространённых случаев:

- [Опробовать React Native][hello-world]
- [Создать новое приложение][new-app]
- [Добавить React Native в существующее приложение][existing]

[hello-world]: https://snack.expo.dev/@samples/hello-world
[new-app]: https://reactnative.dev/docs/getting-started
[existing]: https://reactnative.dev/docs/integration-with-existing-apps

## 📖 Документация

Полная документация по React Native доступна на нашем [сайте][docs].

Документация React Native рассматривает компоненты, API и темы, специфичные для React Native. Для получения дополнительной информации о React API, который используется как в React Native, так и в React DOM, обратитесь к [документации React][r-docs].

Исходный код документации и сайта React Native размещён в отдельном репозитории [**@facebook/react-native-website**][repo-website].

[docs]: https://reactnative.dev/docs/getting-started
[r-docs]: https://react.dev/learn
[repo-website]: https://github.com/facebook/react-native-website

## 🚀 Обновление

Переход на новые версии React Native может предоставить вам доступ к большему количеству API, компонентам, инструментам для разработчиков и другим преимуществам. Инструкции смотрите в [руководстве по обновлению][u].

Выпуски React Native обсуждаются [в этом репозитории обсуждений](https://github.com/reactwg/react-native-releases/discussions).

[u]: https://reactnative.dev/docs/upgrading
[repo-releases]: https://github.com/react-native-community/react-native-releases

## 👏 Как внести вклад

Основная цель этого репозитория — дальнейшее развитие ядра React Native. Мы хотим сделать процесс внесения вклада в проект максимально простым и прозрачным и благодарим сообщество за исправления ошибок и улучшения. Ниже вы узнаете, как принять участие в улучшении React Native.

### [Кодекс поведения][code]

Facebook принял Кодекс поведения, которому должны следовать все участники проекта.
Пожалуйста, ознакомьтесь с [полным текстом][code], чтобы понять, какие действия допустимы, а какие нет.

[code]: https://code.fb.com/codeofconduct/

### [Руководство по вкладу][contribute]

Прочитайте наше [**руководство по вкладу**][contribute], чтобы узнать о процессе разработки, способах предложения исправлений и улучшений, а также о том, как собрать и протестировать ваши изменения для React Native.

[contribute]: https://reactnative.dev/docs/contributing

### [Дорожная карта развития][roadmap]

Вы можете узнать больше о нашем видении развития React Native в [**дорожной карте**][roadmap].

[roadmap]: https://github.com/facebook/react-native/wiki/Roadmap

### Простые задачи для начала

У нас есть список [простых задач для новичков][gfi], которые содержат баги с относительно небольшим объёмом работы. Это отличная возможность начать, получить опыт и ознакомиться с процессом вклада.

[gfi]: https://github.com/facebook/react-native/labels/good%20first%20issue

### Обсуждения

Более масштабные обсуждения и предложения ведутся в [**@react-native-community/discussions-and-proposals**][repo-meta].

[repo-meta]: https://github.com/react-native-community/discussions-and-proposals

## 📄 Лицензия

React Native распространяется по лицензии MIT, как указано в файле [LICENSE][l].

[l]: https://github.com/facebook/react-native/blob/main/LICENSE

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---