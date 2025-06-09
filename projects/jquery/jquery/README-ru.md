# [jQuery](https://jquery.com/) — Новая волна JavaScript

Встречи сейчас проводятся на платформе [matrix.org](https://matrix.to/#/#jquery_meeting:gitter.im).

Протоколы встреч можно найти на [meetings.jquery.org](https://meetings.jquery.org/category/core/).

Последняя версия jQuery доступна по адресу [https://jquery.com/download/](https://jquery.com/download/).

## Поддержка версий

| Версия | Ветка      | Статус   |
| ------- | ---------- | -------- |
| 4.x     | main       | Бета     |
| 3.x     | 3.x-stable | Активна  |
| 2.x     | 2.x-stable | Неактивна|
| 1.x     | 1.x-stable | Неактивна|

После выхода финальной версии 4.0.0, ветка 3.x будет получать обновления ещё некоторое время. Ветки 2.x и 1.x больше не поддерживаются.

Коммерческая поддержка неактивных версий доступна у [HeroDevs](https://herodevs.com/nes).

Узнайте больше о нашей [поддержке версий](https://jquery.com/support/).

## Руководства по вкладу

В духе разработки ПО с открытым исходным кодом, jQuery всегда поощряет вклад сообщества в исходный код. Прежде чем приступить к написанию кода, обязательно внимательно прочитайте эти важные руководства:

1. [Как принять участие](https://contribute.jquery.org/)
2. [Гид по стилю для ядра](https://contribute.jquery.org/style-guide/js/)
3. [Написание кода для проектов jQuery](https://contribute.jquery.org/code/)

### Ссылки на задачи/PR

Задачи и PR на GitHub обычно упоминаются через `gh-NUMBER`, где `NUMBER` — это числовой идентификатор задачи или PR. Найти такую задачу или PR можно по адресу `https://github.com/jquery/jquery/issues/NUMBER`.

Ранее jQuery использовал другой баг-трекер — на базе Trac — доступный по адресу [bugs.jquery.com](https://bugs.jquery.com/). Он сохранён только для чтения, чтобы можно было ссылаться на прошлые обсуждения. При ссылке на такие задачи в исходном коде jQuery используется паттерн `trac-NUMBER`, где `NUMBER` — числовой идентификатор задачи. Найти такую задачу можно по адресу `https://bugs.jquery.com/ticket/NUMBER`.

## Окружения для использования jQuery

- [Поддержка браузеров](https://jquery.com/browser-support/)
- jQuery также поддерживает Node, расширения браузера и другие не-браузерные окружения.

## Что нужно для сборки собственного jQuery

Для сборки jQuery вам потребуется последняя версия Node.js/npm и git 1.7 или новее. Более ранние версии могут работать, но не поддерживаются.

Для Windows необходимо скачать и установить [git](https://git-scm.com/downloads) и [Node.js](https://nodejs.org/en/download/).

Пользователям macOS рекомендуется установить [Homebrew](https://brew.sh/). После установки Homebrew выполните `brew install git` для установки git
и `brew install node` для установки Node.js.

Пользователи Linux/BSD должны использовать соответствующие пакетные менеджеры для установки git и Node.js, либо собирать из исходников,
если предпочитаете такой способ. Всё просто.

## Как собрать свой jQuery

Сначала [клонируйте репозиторий jQuery](https://help.github.com/en/github/creating-cloning-and-archiving-repositories/cloning-a-repository).

Затем войдите в директорию jquery, установите зависимости и запустите скрипт сборки:

```bash
cd jquery
npm install
npm run build
```

Собранная версия jQuery будет размещена в директории `dist/`, вместе с минифицированной копией и сопутствующим map-файлом.

## Сборка всех релизных файлов jQuery

Чтобы собрать все варианты jQuery, выполните следующую команду:

```bash
npm run build:all
```

Это создаст все варианты, которые включаются в релиз jQuery, включая `jquery.js`, `jquery.slim.js`, `jquery.module.js` и `jquery.slim.module.js` вместе с их минифицированными файлами и sourcemap.

`jquery.module.js` и `jquery.slim.module.js` — это [ECMAScript модули](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Guide/Modules), которые экспортируют `jQuery` и `$` как именованные экспорты и размещаются в директории `dist-module/`, а не в `dist/`.

## Сборка кастомного jQuery

Скрипт сборки можно использовать для создания кастомной версии jQuery, включающей только нужные вам модули.

Можно исключить любой модуль, кроме `core`. При исключении `selector` он не удаляется, а заменяется небольшим враппером вокруг нативного `querySelectorAll` (см. ниже для подробностей).

### Помощь по скрипту сборки

Чтобы увидеть полный список доступных опций для скрипта сборки, выполните:

```bash
npm run build -- --help
```

### Модули

Чтобы исключить модуль, передайте его путь относительно папки `src` (без расширения `.js`) в опцию `--exclude`. При использовании опции `--include` дефолтные модули не включаются, и сборка создаётся только из указанных вами модулей.

Примеры модулей, которые можно исключать или включать:

- **ajax**: Вся функциональность AJAX: `$.ajax()`, `$.get()`, `$.post()`, `$.ajaxSetup()`, `.load()`, транспорты и шорткаты событий ajax, такие как `.ajaxStart()`.
- **ajax/xhr**: Только транспорт AJAX через XMLHTTPRequest.
- **ajax/script**: Только транспорт AJAX через `<script>`; используется для загрузки скриптов.
- **ajax/jsonp**: Только транспорт AJAX для JSONP; зависит от транспорта ajax/script.
- **css**: Метод `.css()`. Также убирает **все** модули, зависящие от css (включая **effects**, **dimensions** и **offset**).
- **css/showHide**: Неанимированные `.show()`, `.hide()` и `.toggle()`; можно исключить, если вы используете классы или явные вызовы `.css()` для установки свойства `display`. Также удаляет модуль **effects**.
- **deprecated**: Методы, отмеченные как устаревшие, но ещё не удалённые.
- **dimensions**: Методы `.width()` и `.height()`, включая вариации `inner-` и `outer-`.
- **effects**: Метод `.animate()` и его шорткаты, такие как `.slideUp()` или `.hide("slow")`.
- **event**: Методы `.on()` и `.off()`, а также вся функциональность событий.
- **event/trigger**: Методы `.trigger()` и `.triggerHandler()`.
- **offset**: Методы `.offset()`, `.position()`, `.offsetParent()`, `.scrollLeft()` и `.scrollTop()`.
- **wrap**: Методы `.wrap()`, `.wrapAll()`, `.wrapInner()` и `.unwrap()`.
- **core/ready**: Исключите модуль ready, если размещаете скрипты в конце body. Любые ready-колбэки, привязанные через `jQuery()`, будут просто вызваны немедленно. Однако, `jQuery(document).ready()` не будет функцией, и `.on("ready", ...)` или подобное не сработает.
- **deferred**: Исключить jQuery.Deferred. Это также исключает все модули, зависящие от Deferred, включая **ajax**, **effects** и **queue**, но заменяет **core/ready** на **core/ready-no-deferred**.
- **exports/global**: Исключить привязку глобальных переменных jQuery ($ и jQuery) к window.
- **exports/amd**: Исключить определение AMD.

- **selector**: Полный селекторный движок jQuery. При исключении этого модуля он заменяется примитивным движком на основе метода браузера `querySelectorAll`, который не поддерживает расширения селекторов jQuery или расширенные семантики. Подробности см. в файле [selector-native.js](https://github.com/jquery/jquery/blob/main/src/selector-native.js).

*Примечание*: Исключение полного модуля `selector` также исключает все расширения селекторов jQuery (такие как `effects/animatedSelector` и `css/hiddenVisibleSelectors`).

##### Имя AMD

Вы можете задать имя модуля для определения AMD в jQuery. По умолчанию оно установлено в "jquery", что удобно для плагинов и сторонних библиотек, но могут быть случаи, когда вам нужно изменить это. Передайте его в параметр `--amd`:

```bash
npm run build -- --amd="custom-name"
```

Или, чтобы определить анонимно, оставьте имя пустым.

```bash
npm run build -- --amd
```

##### Имя файла и директория

Имя собранного файла jQuery по умолчанию — `jquery.js`; он размещается в директории `dist/`. Имя файла можно изменить через `--filename`, а директорию — через `--dir`. `--dir` задаётся относительно корня проекта.

```bash
npm run build -- --slim --filename="jquery.slim.js" --dir="/tmp"
```

Это создаст облегченную версию jQuery и разместит её по пути `tmp/jquery.slim.js`.

##### Режим ECMAScript Module (ESM)

По умолчанию jQuery генерирует обычный JavaScript-файл скрипта. Также можно сгенерировать ECMAScript-модуль, экспортирующий `jQuery` как экспорт по умолчанию, с помощью параметра `--esm`:

```bash
npm run build -- --filename=jquery.module.js --esm
```

##### Factory-режим

По умолчанию jQuery зависит от глобального `window`. Для окружений, где его нет, можно сгенерировать factory-сборку, которая экспортирует функцию, принимающую `window` как параметр, который вы можете передать извне (см. [`README` опубликованного пакета](build/fixtures/README.md) для инструкций по использованию). Такую factory можно сгенерировать с помощью параметра `--factory`:

```bash
npm run build -- --filename=jquery.factory.js --factory
```

Эту опцию можно комбинировать с другими, такими как `--esm` или `--slim`:

```bash
npm run build -- --filename=jquery.factory.slim.module.js --factory --esm --slim --dir="/dist-module"
```

#### Примеры кастомных сборок

Создайте кастомную сборку с помощью `npm run build`, перечислив модули для исключения. Исключение верхнеуровневого модуля также исключает соответствующую директорию модулей.

Исключить всю функциональность **ajax**:

```bash
npm run build -- --exclude=ajax
```

Исключение **css** удаляет модули, зависящие от CSS: **effects**, **offset**, **dimensions**.

```bash
npm run build -- --exclude=css
```

Исключить несколько модулей (`-e` — это алиас для `--exclude`):

```bash
npm run build -- -e ajax/jsonp -e css -e deprecated -e dimensions -e effects -e offset -e wrap
```

Есть специальный алиас для генерации сборки с такой же конфигурацией, как у официальной jQuery Slim:

```bash
npm run build -- --filename=jquery.slim.js --slim
```

Или чтобы создать slim-сборку в виде esm-модуля:

```bash
npm run build -- --filename=jquery.slim.module.js --slim --esm
```
```

*Неофициальные пользовательские сборки регулярно не тестируются. Используйте их на свой страх и риск.*

## Запуск модульных тестов

Убедитесь, что у вас установлены все необходимые зависимости:

```bash
npm install
```

Запустите `npm start`, чтобы jQuery автоматически пересобирался в процессе работы:

```bash
npm start
```

Запустите модульные тесты с помощью локального сервера, поддерживающего PHP. Убедитесь, что вы запускаете сайт из корневой директории, а не из директории "test". База данных не требуется. Для Windows и Mac доступны предварительно настроенные локальные php-серверы. Вот некоторые варианты:

- Windows: [WAMP download](https://www.wampserver.com/en/)
- Mac: [MAMP download](https://www.mamp.info/en/downloads/)
- Linux: [Setting up LAMP](https://www.linux.com/training-tutorials/easy-lamp-server-installation/)
- [Mongoose (most platforms)](https://code.google.com/p/mongoose/)

## Основы работы с Git

Поскольку исходный код обрабатывается системой контроля версий Git, полезно знать некоторые используемые функции.

### Очистка

Если вы хотите очистить рабочую директорию до состояния upstream, можно использовать следующие команды (помните, что всё, над чем вы работали, будет удалено):

```bash
git reset --hard upstream/main
git clean -fdx
```

### Перебазирование (Rebasing)

Для feature/topic-веток всегда используйте флаг `--rebase` с командой `git pull`, или если вы обычно работаете со многими временными ветками "для pull request в github", выполните следующее для автоматизации:

```bash
git config branch.autosetuprebase local
```

(подробнее см. в `man git-config`)

### Разрешение конфликтов слияния

Если при слиянии возникают конфликты, вместо ручного редактирования конфликтующих файлов вы можете использовать инструмент
`git mergetool`. Хотя инструмент по умолчанию `xxdiff` выглядит устаревшим, он довольно полезен.

Вот некоторые команды, которые можно использовать:

- `Ctrl + Alt + M` — автомерджить насколько возможно
- `b` — перейти к следующему конфликту слияния
- `s` — изменить порядок конфликтующих строк
- `u` — отменить слияние
- `левая кнопка мыши` — отметить блок как победитель
- `средняя кнопка мыши` — отметить строку как победитель
- `Ctrl + S` — сохранить
- `Ctrl + Q` — выйти

## Справочник по [QUnit](https://api.qunitjs.com)

### Методы тестирования

```js
expect( numAssertions );
stop();
start();
```

*Примечание*: Возможное в будущем добавление аргумента к stop/start в QUnit игнорируется в этом наборе тестов, чтобы start и stop можно было передавать как колбэки без учета их параметров.

### Проверки (assertions) в тестах

```js
ok( value, [message] );
equal( actual, expected, [message] );
notEqual( actual, expected, [message] );
deepEqual( actual, expected, [message] );
notDeepEqual( actual, expected, [message] );
strictEqual( actual, expected, [message] );
notStrictEqual( actual, expected, [message] );
throws( block, [expected], [message] );
```

## Справочник по удобным методам набора тестов

Смотрите [test/data/testinit.js](https://github.com/jquery/jquery/blob/main/test/data/testinit.js).

### Возвращает массив элементов с заданными ID

```js
q( ... );
```

Пример:

```js
q( "main", "foo", "bar" );

=> [ div#main, span#foo, input#bar ]
```

### Проверяет, что выборка соответствует заданным ID

```js
t( testName, selector, [ "array", "of", "ids" ] );
```

Пример:

```js
t("Проверить что-то", "//[a]", ["foo", "bar"]);
```

### Генерирует нативное DOM-событие без использования jQuery

```js
fireNative( node, eventType );
```

Пример:

```js
fireNative( jQuery( "#elem" )[ 0 ], "click" );
```

### Добавляет случайное число к url для предотвращения кеширования

```js
url( "some/url" );
```

Пример:

```js
url( "index.html" );

=> "data/index.html?10538358428943"


url( "mock.php?foo=bar" );

=> "data/mock.php?foo=bar&10538358345554"
```

### Запуск тестов в iframe

Некоторые тесты могут требовать документа, отличного от стандартного тестового шаблона,
и их можно запускать в отдельном iframe. Основной код теста и проверки остаются в главных файлах тестов jQuery; только минимальная разметка тестового шаблона и код инициализации должны быть размещены в файле iframe.

```js
testIframe( testName, fileName,
  function testCallback(
      assert, jQuery, window, document,
	  [ additional args ] ) {
	...
  } );
```

Это загружает страницу, формируя url с fileName `"./data/" + fileName`.
Страница в iframe определяет, когда произойдет вызов колбэка теста, подключая скрипт "/test/data/iframeTest.js" и вызывая
`startIframeTest( [ additional args ] )` в нужный момент. Обычно это происходит после document ready или после срабатывания `window.onload`.

`testCallback` получает объект QUnit `assert`, созданный функцией `testIframe` для этого теста, далее глобальные `jQuery`, `window` и `document` из iframe. Если код iframe передает какие-либо аргументы в `startIframeTest`, они следуют после аргумента `document`.

## Вопросы?

Если у вас есть вопросы, пожалуйста, задавайте их на
[форуме Developing jQuery Core](https://forum.jquery.com/developing-jquery-core) или в #jquery на [libera](https://web.libera.chat/).
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---