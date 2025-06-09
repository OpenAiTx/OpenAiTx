<p align="center">
  <a href="https://whispering.bradenwong.com">
    <img width="180" src="https://raw.githubusercontent.com/braden-w/whispering/main/apps/app/src-tauri/recorder-state-icons/studio_microphone.png" alt="Whispering">
  </a>
  <h1 align="center">Whispering</h1>
  <p align="center">Бесшовное диктование на базе модели Whisper от OpenAI</p>
</p>

<p align="center">
  <!-- Latest Version Badge -->
  <img src="https://img.shields.io/github/v/release/braden-w/whispering?style=flat-square&label=Latest%20Version&color=brightgreen" />
  <!-- License Badge -->
  <a href="LICENSE" target="_blank">
    <img alt="MIT License" src="https://img.shields.io/github/license/braden-w/whispering.svg?style=flat-square" />
  </a>
  <!-- Badges for Technologies -->
  <img alt="TypeScript" src="https://img.shields.io/badge/-TypeScript-blue?style=flat-square&logo=typescript&logoColor=white" />
  <img alt="Rust" src="https://img.shields.io/badge/-Rust-orange?style=flat-square&logo=rust&logoColor=white" />
  <!-- Platform Support Badges -->
  <a href="https://chrome.google.com/webstore/detail/whispering/oilbfihknpdbpfkcncojikmooipnlglo" target="_blank">
    <img alt="Chrome" src="https://img.shields.io/chrome-web-store/stars/oilbfihknpdbpfkcncojikmooipnlglo?color=blue&label=Chrome&style=flat-square&logo=google-chrome&logoColor=white" />
  </a>
  <a href="https://github.com/braden-w/whispering/releases" target="_blank">
    <img alt="macOS" src="https://img.shields.io/badge/-macOS-black?style=flat-square&logo=apple&logoColor=white" />
  </a>
  <a href="https://github.com/braden-w/whispering/releases" target="_blank">
    <img alt="Windows" src="https://img.shields.io/badge/-Windows-blue?style=flat-square&logo=windows&logoColor=white" />
  </a>
  <a href="https://github.com/braden-w/whispering/releases" target="_blank">
    <img alt="Linux" src="https://img.shields.io/badge/-Linux-yellow?style=flat-square&logo=linux&logoColor=white" />
  </a>
</p>


## О проекте

Whispering — это приложение с открытым исходным кодом для транскрипции, предоставляющее глобальную функцию преобразования речи в текст с возможностями такими как горячие клавиши и автоматическое копирование и вставка для максимально удобного диктования.

В основе лежит модель Whisper от OpenAI, что делает его значительно более точным, чем встроенные средства диктовки.

> **Важное примечание**: Whispering предназначен в первую очередь как инструмент для транскрипции, а не для записи. Для длительных записей, где важна надежность, рекомендуется использовать специализированное приложение для записи на вашем телефоне или устройстве, использующее нативные API записи. Это гарантирует оптимальное качество звука и стабильность записи.

## Демонстрации

https://github.com/user-attachments/assets/eca93701-10a0-4d91-b38a-f715bd7e0357

https://github.com/user-attachments/assets/a7934f1f-d08b-4037-9bbc-aadd1b13501e

## Основные возможности

1. **Глобальная транскрипция**: Доступ к функции преобразования речи в текст модели Whisper в любом месте с помощью глобальной горячей клавиши или в два клика.
2. **Кроссплатформенный опыт**:
   - Десктопное приложение: Позволяет использовать глобальную транскрипцию во всех приложениях.
   - Расширение для браузера: Обеспечивает глобальную транскрипцию в браузере через связь с веб-приложением.
3. **Интеграция с чатами**: Расширение для браузера добавляет кнопку записи на сайтах ChatGPT и Claude, позволяя вводить голосом и сразу транскрибировать речь в интерфейсе чата.
4. **Управление транскрипциями**: Просматривайте и редактируйте транскрипции в приложении Whispering для повышения точности и ясности.
5. **Автоматическая интеграция с буфером обмена**: После завершения транскрипции текст автоматически копируется в буфер обмена. Также доступна опция автоматической вставки.

## Как хранятся мои данные?

Whispering сохраняет максимум данных локально на вашем устройстве, включая записи и текстовые транскрипции. Такой подход обеспечивает максимальную конфиденциальность и безопасность данных. Вот как обрабатываются ваши данные:

1. **Локальное хранение**: Голосовые записи и транскрипции хранятся в IndexedDB, которая используется как blob-хранилище и место для хранения всех ваших данных, таких как текст и транскрипции.

2. **Сервис транскрипции**: Единственные данные, которые могут быть отправлены во внешний сервис — это ваша запись для транскрипции, если вы выберете такой вариант. Возможны следующие опции:
   - Внешние сервисы, такие как OpenAI или Groq
   - Локальный сервис транскрипции, например `faster-whisper-server`, который хранит все на устройстве

3. **Настраиваемые параметры**: Вы можете изменить сервис транскрипции в настройках для максимальной работы в локальном режиме.


## Установка

### Веб-приложение

Перейдите на [whispering.bradenwong.com](https://whispering.bradenwong.com/), где размещена последняя версия папки `apps/app` на Vercel.

### Расширение для Chrome

Установите расширение Chrome из интернет-магазина Chrome [здесь](https://chrome.google.com/webstore/detail/whispering/oilbfihknpdbpfkcncojikmooipnlglo).

### Десктопное приложение

Чтобы загрузить и установить десктопное приложение Whispering, следуйте инструкциям для вашей операционной системы:

#### Windows

1. Скачайте установочный пакет с расширением `.msi` со [страницы последних релизов](https://github.com/braden-w/whispering/releases).
2. Откройте скачанный файл `.msi`, чтобы запустить установщик.
3. Если появится предупреждение о небезопасности, нажмите `More Info` -> `Run Anyway`, чтобы продолжить установку.
4. Следуйте инструкциям на экране для завершения установки.

#### macOS

Для macOS выполните следующие шаги по установке Whispering:

1. **Скачайте установочный пакет**:
   - Перейдите на [страницу последних релизов](https://github.com/braden-w/whispering/releases).
   - Выберите подходящий пакет:
     - Для Apple Silicon: `Whispering_x.x.x_aarch64.dmg`
     - Для Intel: `Whispering_x.x.x_x64.dmg`

2. **Установите приложение**:
   - Откройте скачанный файл `.dmg`.
   - Перетащите приложение Whispering в папку Applications.

3. **Запуск Whispering**:
   - Откройте Whispering из папки Applications.
   - Если появится предупреждение о непроверенном разработчике:
     - Нажмите `Cancel`
     - Кликните правой кнопкой мыши по приложению в Finder и выберите `Open`

4. **Устранение ошибок** (только для Apple Silicon):
   Если появляется ошибка `"Whispering" is damaged and can't be opened`:
   - Откройте Терминал
   - Выполните следующую команду:
     ```bash
     xattr -cr /Applications/Whispering.app
     ```
   - Попробуйте снова открыть приложение

После выполнения этих шагов Whispering будет готов к использованию на вашем macOS устройстве.

#### Linux

Для Linux доступно несколько способов установки. Выберите подходящий для вашей среды:

1. **AppImage**:

   - Скачайте файл `.AppImage` со [страницы последних релизов](https://github.com/braden-w/whispering/releases).
   - Сделайте файл исполняемым:
     ```bash
     chmod +x whispering_x.x.x_amd64.AppImage
     ```
   - Запустите AppImage:
     ```bash
     ./whispering_x.x.x_amd64.AppImage
     ```

2. **DEB-пакет (Debian/Ubuntu)**:
   - Скачайте файл `.deb` со [страницы последних релизов](https://github.com/braden-w/whispering/releases).
   - Установите пакет с помощью `dpkg`:
     ```bash
     sudo dpkg -i whispering_x.x.x_amd64.deb
     ```
   - Разрешите возможные зависимости:
     ```bash
     sudo apt-get install -f
     ```

После установки приложение будет готово к использованию.

## Использование

### Расширение для Chrome

После установки расширения для Chrome вы найдете иконку Whispering на панели расширений Chrome. Кликните по этой иконке, чтобы открыть расширение. Нажмите кнопку с микрофоном для записи голоса, затем нажмите квадратную кнопку для завершения. Ваша транскрипция появится в текстовом поле ниже.

Для использования функции ChatGPT или Claude перейдите на соответствующую веб-страницу. В интерфейсе чата появится новая кнопка записи. Кликните по этой кнопке для начала и окончания записи, после чего транскрибированный текст автоматически вставится в поле ввода чата.

Для доступа к функции горячих клавиш нажмите <kbd>Control</kbd> + <kbd>Shift</kbd> + <kbd>X</kbd> или <kbd>Command</kbd> + <kbd>Shift</kbd> + <kbd>X</kbd> (в дальнейшем можно настроить через ярлыки расширения Chrome) для начала записи с любого сайта. Транскрипция автоматически скопируется в буфер обмена и вставится в текущее поле ввода.

Расширение для Chrome взаимодействует с [whispering.bradenwong.com](https://whispering.bradenwong.com) и автоматически попытается создать вкладку в фоновом режиме, если не найдет уже открытую. Большинство ошибок связано с нарушением этого взаимодействия, например, в редких случаях, когда вкладка "засыпает".

### Веб-приложение

Веб-приложение доступно по адресу [whispering.bradenwong.com](https://whispering.bradenwong.com). Нажмите кнопку с микрофоном для записи голоса, затем квадратную для завершения. Транскрипция появится в текстовом поле.

### Десктопное приложение

После установки десктопного приложения Whispering нажмите <kbd>Control/Command</kbd> + <kbd>Shift</kbd> + <kbd>;</kbd> (настраивается в настройках) для начала записи из любого места на вашем рабочем столе. Транскрипция будет автоматически скопирована в буфер обмена и вставлена, однако обе функции можно отключить в настройках.

## Технологии

#### Веб и десктоп

Приложение Whispering построено с использованием следующих технологий и библиотек:

- [Svelte 5](https://svelte.dev): Выбранная библиотека реактивного UI.
- [SvelteKit](https://kit.svelte.dev/docs): Для роутинга и статической генерации сайта, используется как для сайта, так и для статического фронтенда приложения Tauri.
- [Tauri](https://tauri.studio/en/docs/intro/): Фреймворк десктопного приложения.
- [Effect-TS](https://github.com/Effect-TS/effect): Для добавления элементов функционального программирования и написания максимально типобезопасных функций, где ошибки входят в возвращаемый тип сигнатуры функции.
- [Svelte Sonner](https://svelte-sonner.vercel.app/): Простая, настраиваемая библиотека всплывающих уведомлений для приложений на Svelte. Используется для отображения ошибок, возникших через Effect-TS, с помощью функции `renderAsToast`.
- [TanStack Table](https://tanstack.com/table): Для работы с таблицами данных.
- [IndexedDB](https://developer.mozilla.org/en-US/docs/Web/API/IndexedDB_API): Низкоуровневый API для хранения больших объемов структурированных данных в браузере. Синхронизируется с Tanstack Table.
- [ShadCN-Svelte](https://github.com/huntabyte/shadcn-svelte): Выбранная библиотека UI-компонентов.
- [TailwindCSS](https://tailwindcss.com/docs): CSS-фреймворк с утилитарным подходом для быстрой разработки пользовательских интерфейсов.
- [Turborepo](https://turborepo.org/): Для управления монорепозиторием, чтобы `apps/app` и `apps/extension` могли использовать одну и ту же кодовую базу, что значительно уменьшает дублирование кода и обеспечивает единый источник истины.
- [Rust](https://www.rust-lang.org): Для расширения возможностей десктопного приложения, например, с помощью crate `enigo` для автоматической вставки.
- [Vercel](https://vercel.com/): Хостинг, подходящий для хобби-проекта и интеграции с Turborepo.
- [Zapsplat.com](https://www.zapsplat.com/): Библиотека звуковых эффектов без лицензионных отчислений.

#### Расширение

Расширение Chrome Whispering построено с использованием:

- [Plasmo](https://docs.plasmo.com/): Фреймворк для создания расширений Chrome. Используется [relay flow](https://docs.plasmo.com/framework/messaging#relay-flow) для коммуникации с сайтом Whispering.
- [Effect-TS](https://github.com/Effect-TS/effect): Для добавления элементов функционального программирования и написания максимально типобезопасных функций, где ошибки входят в возвращаемый тип сигнатуры функции.
- [React](https://reactjs.org): Библиотека реактивного UI для расширения Chrome, поскольку Plasmo, к сожалению, не поддерживает Svelte 5.
- [ShadCN](https://github.com/shadcn): Библиотека UI-компонентов для расширения Chrome.
- [TailwindCSS](https://tailwindcss.com/docs): CSS-фреймворк с утилитарным подходом для быстрого создания пользовательских интерфейсов.
- [Chrome API](https://developer.chrome.com/docs/extensions/reference/): API для расширений Chrome.
- [Zapsplat.com](https://www.zapsplat.com/): Библиотека звуковых эффектов без авторских отчислений.

## Запуск Whispering в режиме локальной разработки

Чтобы настроить проект на вашем локальном компьютере, выполните следующие шаги:

1. Клонируйте репозиторий: `git clone https://github.com/braden-w/whispering.git`
2. Перейдите в каталог проекта: `cd whispering`
3. Установите необходимые зависимости: `pnpm i`

Чтобы запустить настольное приложение Whispering и сайт в режиме разработки:

4. Перейдите в каталог приложения: `cd apps/app`
5. Запустите сервер разработки: `pnpm tauri dev`

Настольное приложение должно автоматически открыться для локальной разработки. Для разработки веб-приложения откройте браузер и перейдите по адресу `http://localhost:5173`.

Чтобы запустить расширение Whispering для Chrome в режиме разработки:

4. Перейдите в каталог расширения: `cd apps/extension`
5. Запустите сервер разработки: `pnpm dev --target=chrome-mv3`

Чтобы разрабатывать расширение для Chrome, загрузите его в Chrome, перейдя по адресу `chrome://extensions`, включив режим разработчика и загрузив папку `apps/extension/build/{platform}-{manifest-version}-dev` как распакованное расширение.

## Соберите исполняемый файл самостоятельно

Если у вас есть сомнения относительно надежности установщиков или вы хотите получить больший контроль, вы всегда можете собрать исполняемый файл самостоятельно. Это требует большего количества настроек, но гарантирует, что вы запускаете ожидаемый вами код. В этом и заключается красота open-source ПО!

### Chrome

1. Перейдите в каталог расширения: `cd apps/extension`
2. Установите необходимые зависимости: `pnpm i`
3. Выполните сборку Plasmo: `pnpm plasmo build --target=chrome-mv3`
4. Результат будет находиться в `apps/extension/build/chrome-mv3-prod`, который можно загрузить в Chrome как распакованное расширение.
5. Также вы можете собрать расширение для Chrome Web Store: `pnpm plasmo build --target=chrome-mv3 --release`

### Firefox

1. Перейдите в каталог расширения: `cd apps/extension`
2. Установите необходимые зависимости: `pnpm i`
3. Выполните сборку Plasmo: `pnpm plasmo build --target=firefox-mv3`
4. Результат будет находиться в `apps/extension/build/firefox-mv3-prod`, который можно загрузить в Chrome как распакованное расширение.
5. Также вы можете собрать расширение для Chrome Web Store: `pnpm plasmo build --target=firefox-mv3 --release`

### Desktop

1. Перейдите в каталог приложения: `cd apps/app`
2. Установите необходимые зависимости: `pnpm i`
3. Выполните сборку Tauri: `pnpm tauri build`
4. Исполняемый файл будет находиться в каталоге `apps/app/target/release`.

## Вклад в проект

Мы приветствуем вклад сообщества! Если вы хотите внести свой вклад в Whispering, пожалуйста, выполните следующие шаги:

1. Форкните репозиторий.
2. Создайте новую ветку для вашей функции или исправления: `git checkout -b feature/your-feature-name` или `git checkout -b fix/your-bugfix-name`
3. Внесите изменения и сделайте коммит с описательным сообщением.
4. Отправьте вашу ветку в форкнутый репозиторий: `git push origin your-branch-name`
5. Создайте pull request из вашего форка в оригинальный репозиторий.

Пожалуйста, убедитесь, что ваш код соответствует установленным соглашениям и хорошо документирован.

## Лицензия

Whispering распространяется под [лицензией MIT](https://opensource.org/licenses/MIT).

## Спонсоры

Этот проект поддерживают следующие замечательные люди и организации:

<!-- sponsors --><a href="https://github.com/DavidGP"><img src="https://github.com/DavidGP.png" width="60px" alt="" /></a><a href="https://github.com/cgbur"><img src="https://github.com/cgbur.png" width="60px" alt="Chris Burgess" /></a><a href="https://github.com/Wstnn"><img src="https://github.com/Wstnn.png" width="60px" alt="" /></a><a href="https://github.com/rkhrkh"><img src="https://github.com/rkhrkh.png" width="60px" alt="" /></a><a href="https://github.com/doxgt"><img src="https://github.com/doxgt.png" width="60px" alt="" /></a><a href="https://github.com/worldoptimizer"><img src="https://github.com/worldoptimizer.png" width="60px" alt="Max Ziebell" /></a><a href="https://github.com/AlpSantoGlobalMomentumLLC"><img src="https://github.com/AlpSantoGlobalMomentumLLC.png" width="60px" alt="" /></a><!-- sponsors -->

## Поддержка и обратная связь

Если вы столкнулись с проблемами или у вас есть предложения по улучшению, пожалуйста, создайте issue на [вкладке GitHub issues](https://github.com/braden-w/whispering/issues) или свяжитесь со мной по адресу [whispering@bradenwong.com](mailto:whispering@bradenwong.com). Я очень ценю вашу обратную связь!

Спасибо, что используете Whispering, и приятной работы!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---