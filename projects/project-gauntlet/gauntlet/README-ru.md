# Gauntlet

[![Discord](https://discord.com/api/guilds/1205606511603359785/widget.png?style=shield)](https://discord.gg/gFTqYUkBrW)

<img align="right" width="100" height="100" src="https://raw.githubusercontent.com/project-gauntlet/gauntlet/main/assets/linux/icon_256.png">

Кроссплатформенный веб-ориентированный лаунчер приложений с плагинами на базе React

> [!WARNING]
> Лаунчер разрабатывается одним разработчиком в свободное время.
> Изменения могут происходить медленно, но стабильно.
>
> Возможно появление несовместимых изменений, которые будут документированы в [changelog](https://raw.githubusercontent.com/project-gauntlet/gauntlet/main/CHANGELOG.md).

![image](https://github.com/user-attachments/assets/81339462-9cc3-469e-8cdc-ca74918bceab)

## Демонстрация

Немного устаревшая демонстрация

https://github.com/user-attachments/assets/19964ed6-9cd9-48d4-9835-6be04de14b66

## Возможности

- Плагин-ориентированный
  - Плагины пишутся на TypeScript
  - Расширенный API для плагинов 
      - Создание UI-вью
      - Одноразовые команды
      - Динамическое предоставление списка одноразовых команд
      - Отображение быстрого "инлайн" контента прямо под главной строкой поиска на основе её значения
      - Получение содержимого буфера обмена и добавление в него
  - Плагины распространяются как отдельная ветка в Git-репозитории, что означает отсутствие необходимости в центральном сервере для распространения плагинов
  - Идентификаторы плагинов — это просто URL Git-репозиториев
  - UI для плагинов на базе [React](https://github.com/facebook/react)
    - Реализовано с помощью собственного React Reconciler (без Electron)
  - [Deno JavaScript Runtime](https://github.com/denoland/deno)
    - Deno позволяет изолировать код плагинов на JavaScript для повышения безопасности
    - Плагины обязаны явно указывать, какие разрешения им необходимы для работы
    - Node.js используется для запуска инструментов для плагинов, но как разработчик плагинов вы всегда пишете код, который работает в Deno
- С самого начала разрабатывался с учетом кроссплатформенности
- Команды и вью можно запускать/открывать с помощью пользовательских глобальных горячих клавиш
- К командам или вью можно назначать пользовательские поисковые алиасы
- Поддержка пользовательских тем
- Встроенная функциональность предоставляется вместе с комплектными плагинами
  - Приложения: отображает установленные на системе приложения в результатах поиска
    - Плагин также отслеживает окна и к каким приложениям они принадлежат, поэтому открытие уже запущенного приложения по умолчанию поднимает ранее созданное окно
      - В настоящий момент поддерживаются не все системы. См. [поддержка функций](https://gauntlet.sh/docs/feature-support)
  - Калькулятор: показывает результат математических операций прямо под главной строкой поиска
    - Включает конвертацию валют по курсам обмена
    - Работает на базе [Numbat](https://github.com/sharkdp/numbat)
- Сортировка результатов поиска по "frecency"
   - Frecency — это комбинация частоты и недавности использования
   - Чем чаще используется элемент, тем выше он будет в списке результатов, но элементы, часто использовавшиеся в прошлом, будут ранжироваться ниже, чем те, которые недавно использовались столько же раз
   - Результаты сопоставляются по словам через подстроку

##### Поддержка ОС

##### Официально
- <img src="https://cdn.jsdelivr.net/gh/simple-icons/simple-icons@develop/icons/linux.svg" width="18" height="18" /> Linux X11
- <img src="https://cdn.jsdelivr.net/gh/simple-icons/simple-icons@develop/icons/apple.svg" width="18" height="18" /> macOS M1

##### Частично
- <img src="https://cdn.jsdelivr.net/gh/simple-icons/simple-icons@develop/icons/linux.svg" width="18" height="18" /> Linux Wayland
  - Gnome Wayland пока не поддерживается, см. [#40](https://github.com/project-gauntlet/gauntlet/issues/40)
- <img src="https://img.icons8.com/windows/32/windows-11.png" width="18" height="18" /> Windows
- <img src="https://cdn.jsdelivr.net/gh/simple-icons/simple-icons@develop/icons/apple.svg" width="18" height="18" /> macOS Intel

## Начало работы

### Установка Gauntlet

См. [Установка](https://gauntlet.sh/docs/installation)

### Глобальная горячая клавиша

Главное окно можно открыть с помощью глобальной горячей клавиши или через CLI-команду:
- Глобальная горячая клавиша (можно изменить в настройках)
  - Windows: <kbd>ALT</kbd> + <kbd>Пробел</kbd>
  - Linux X11: <kbd>Super</kbd> + <kbd>Пробел</kbd>
  - Linux Wayland
    - Глобальная горячая клавиша может не поддерживаться, см. [поддержка функций](https://gauntlet.sh/docs/feature-support)
    - Используйте CLI-команду, вызывая её через специфичный для WM способ
  - macOS: <kbd>CMD</kbd> + <kbd>Пробел</kbd>
- CLI-команда
  - `gauntlet open`

### Установка плагина

Плагины устанавливаются через интерфейс настроек. Для установки используйте URL Git-репозитория плагина, например: `https://github.com/project-gauntlet/readme-demo-plugin.git`

![](https://raw.githubusercontent.com/project-gauntlet/gauntlet/main/docs/settings_ui.png)

### Создание собственного плагина

См. [Начало разработки плагинов](https://gauntlet.sh/docs/plugin-development/getting-started)

## Темы оформления

См. [Темы оформления](https://gauntlet.sh/docs/theming)

## Сборка Gauntlet

Вам потребуется:
- NodeJS
- Rust
- Компилятор Protobuf
- CMake (не используется самим проектом, но требуется одной из зависимостей)
- В Linux: `libxkbcommon-dev` (примечание: название может отличаться в зависимости от дистрибутива)

### Dev

Для сборки dev выполните:
```bash
npm ci
npm run build
npm run build-dev-plugin
cargo build
```
В dev-режиме (без флага "release") приложение будет использовать только директории внутри папки проекта для хранения состояния и кэша, чтобы не затрагивать глобальную установку

### Not-yet-packaged

Для сборки неупакованного релизного бинарного файла выполните:
```bash
npm ci
npm run build
cargo build --release --features release
```

### Packaged
Для сборки пакетированной версии под конкретную ОС выполните одну из команд:

macOS:
```bash
npm run build-macos-project --workspace @project-gauntlet/build
```

Windows:
```bash
npm run build-windows-project --workspace @project-gauntlet/build
```

Linux:
```bash
npm run build-linux-project --workspace @project-gauntlet/build
```

Но выпуск новой версии должен осуществляться через GitHub Actions

## Вклад

Если вы хотите помочь в разработке Gauntlet, вы можете сделать это не только через код:
- Сообщить об ошибке или проблеме UI/UX
- Создать плагин

Для простых задач вы можете смело открывать issue или PR и решать их самостоятельно. 
Для более значимых изменений, пожалуйста, свяжитесь с авторами в Discord (ссылка-приглашение в начале README) и обсудите сначала.

Любой вклад приветствуется.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-19

---