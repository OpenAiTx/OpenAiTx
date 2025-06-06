# [React](https://react.dev/) &middot; [![GitHub license](https://img.shields.io/badge/license-MIT-blue.svg)](https://github.com/facebook/react/blob/main/LICENSE) [![npm version](https://img.shields.io/npm/v/react.svg?style=flat)](https://www.npmjs.com/package/react) [![(Runtime) Build and Test](https://github.com/facebook/react/actions/workflows/runtime_build_and_test.yml/badge.svg)](https://github.com/facebook/react/actions/workflows/runtime_build_and_test.yml) [![(Compiler) TypeScript](https://github.com/facebook/react/actions/workflows/compiler_typescript.yml/badge.svg?branch=main)](https://github.com/facebook/react/actions/workflows/compiler_typescript.yml) [![PRs Welcome](https://img.shields.io/badge/PRs-welcome-brightgreen.svg)](https://legacy.reactjs.org/docs/how-to-contribute.html#your-first-pull-request)

React — это библиотека JavaScript для создания пользовательских интерфейсов.

* **Декларативность:** React упрощает создание интерактивных пользовательских интерфейсов. Проектируйте простые представления для каждого состояния вашего приложения, и React будет эффективно обновлять и отображать только те компоненты, которые действительно нужно изменить при изменении данных. Декларативные представления делают ваш код более предсказуемым, понятным и легким для отладки.
* **Компонентный подход:** Создавайте инкапсулированные компоненты, которые управляют своим собственным состоянием, а затем комбинируйте их для построения сложных интерфейсов. Поскольку логика компонентов написана на JavaScript, а не в шаблонах, вы можете легко передавать богатые данные через ваше приложение и держать состояние вне DOM.
* **Один раз изучил — пиши везде:** Мы не делаем предположений относительно остального стека технологий, поэтому вы можете разрабатывать новые функции на React, не переписывая существующий код. React также может выполнять серверный рендеринг с помощью [Node](https://nodejs.org/en) и использоваться для создания мобильных приложений с помощью [React Native](https://reactnative.dev/).

[Узнайте, как использовать React в своем проекте](https://react.dev/learn).

## Установка

React изначально разрабатывался для поэтапного внедрения, и **вы можете использовать столько React, сколько вам нужно**:

* Используйте [Быстрый старт](https://react.dev/learn), чтобы познакомиться с React.
* [Добавьте React в существующий проект](https://react.dev/learn/add-react-to-an-existing-project), чтобы использовать столько React, сколько потребуется.
* [Создайте новое приложение на React](https://react.dev/learn/start-a-new-react-project), если вам нужен мощный инструмент для работы с JavaScript.

## Документация

Документацию по React можно найти [на сайте](https://react.dev/).

Ознакомьтесь с разделом [Начало работы](https://react.dev/learn) для быстрого обзора.

Документация разделена на несколько разделов:

* [Быстрый старт](https://react.dev/learn)
* [Учебник](https://react.dev/learn/tutorial-tic-tac-toe)
* [Мышление в стиле React](https://react.dev/learn/thinking-in-react)
* [Установка](https://react.dev/learn/installation)
* [Описание UI](https://react.dev/learn/describing-the-ui)
* [Добавление интерактивности](https://react.dev/learn/adding-interactivity)
* [Управление состоянием](https://react.dev/learn/managing-state)
* [Продвинутые руководства](https://react.dev/learn/escape-hatches)
* [Справочник по API](https://react.dev/reference/react)
* [Где получить поддержку](https://react.dev/community)
* [Руководство по участию](https://legacy.reactjs.org/docs/how-to-contribute.html)

Вы можете улучшить документацию, отправив pull request в [этот репозиторий](https://github.com/reactjs/react.dev).

## Примеры

У нас есть несколько примеров [на сайте](https://react.dev/). Вот первый пример, чтобы начать работу:

```jsx
import { createRoot } from 'react-dom/client';

function HelloMessage({ name }) {
  return <div>Hello {name}</div>;
}

const root = createRoot(document.getElementById('container'));
root.render(<HelloMessage name="Taylor" />);
```

Этот пример отобразит "Hello Taylor" в контейнере на странице.

Вы заметите, что мы использовали синтаксис, похожий на HTML; [мы называем его JSX](https://react.dev/learn#writing-markup-with-jsx). Для использования React JSX не обязателен, но он делает код более читабельным, а писать его похоже на написание HTML.

## Участие

Основная цель этого репозитория — продолжать развитие ядра React, делая его быстрее и удобнее. Разработка React ведется открыто на GitHub, и мы благодарны сообществу за исправления ошибок и улучшения. Прочитайте ниже, чтобы узнать, как вы можете принять участие в развитии React.

### [Кодекс поведения](https://code.fb.com/codeofconduct)

Facebook приняла Кодекс поведения, которому мы ожидаем, что участники проекта будут следовать. Пожалуйста, ознакомьтесь с [полным текстом](https://code.fb.com/codeofconduct), чтобы понять, какие действия допускаются, а какие нет.

### [Руководство по участию](https://legacy.reactjs.org/docs/how-to-contribute.html)

Прочитайте наше [руководство по участию](https://legacy.reactjs.org/docs/how-to-contribute.html), чтобы узнать о нашем процессе разработки, о том, как предлагать исправления и улучшения, а также как собирать и тестировать ваши изменения в React.

### [Хорошие первые задачи](https://github.com/facebook/react/labels/good%20first%20issue)

Чтобы помочь вам начать и познакомиться с процессом участия, у нас есть список [хороших первых задач](https://github.com/facebook/react/labels/good%20first%20issue), которые содержат баги с относительно небольшим объёмом работы. Это отличное место для старта.

### Лицензия

React распространяется по [лицензии MIT](./LICENSE).

---

[Powered By DeepAiTx](https://github.com/DeepAiTx)

---