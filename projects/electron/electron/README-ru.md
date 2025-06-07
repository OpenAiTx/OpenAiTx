[![Логотип Electron](https://electronjs.org/images/electron-logo.svg)](https://electronjs.org)

[![Статус сборки GitHub Actions](https://github.com/electron/electron/actions/workflows/build.yml/badge.svg)](https://github.com/electron/electron/actions/workflows/build.yml)
[![Приглашение в Discord Electron](https://img.shields.io/discord/745037351163527189?color=%237289DA&label=chat&logo=discord&logoColor=white)](https://discord.gg/electronjs)

:memo: Доступные переводы: 🇨🇳 🇧🇷 🇪🇸 🇯🇵 🇷🇺 🇫🇷 🇺🇸 🇩🇪.
Просмотрите эти документы на других языках в нашем проекте на [Crowdin](https://crowdin.com/project/electron).

Фреймворк Electron позволяет создавать кроссплатформенные настольные приложения с использованием JavaScript, HTML и CSS. Он основан на [Node.js](https://nodejs.org/) и [Chromium](https://www.chromium.org) и используется в [Visual Studio Code](https://github.com/Microsoft/vscode/) и многих других [приложениях](https://electronjs.org/apps).

Следите за [@electronjs](https://twitter.com/electronjs) в Twitter для важных объявлений.

Этот проект придерживается [кодекса поведения](https://github.com/electron/electron/tree/main/CODE_OF_CONDUCT.md) Contributor Covenant.
Участвуя, вы обязуетесь соблюдать этот кодекс. Сообщайте о недопустимом поведении на [coc@electronjs.org](mailto:coc@electronjs.org).

## Установка

Чтобы установить готовые бинарные файлы Electron, используйте [`npm`](https://docs.npmjs.com/).
Рекомендуемый способ — установить Electron как зависимость для разработки в вашем приложении:

```sh
npm install electron --save-dev
```

Больше вариантов установки и советы по устранению неполадок см. в разделе [установка](docs/tutorial/installation.md). Информацию о том, как управлять версиями Electron в ваших приложениях, см. в разделе [Версионирование Electron](docs/tutorial/electron-versioning.md).

## Поддержка платформ

Каждый релиз Electron предоставляет бинарные файлы для macOS, Windows и Linux.

* macOS (Big Sur и выше): Electron предоставляет 64-битные бинарные файлы для Intel и Apple Silicon / ARM для macOS.
* Windows (Windows 10 и выше): Electron предоставляет бинарные файлы `ia32` (`x86`), `x64` (`amd64`) и `arm64` для Windows. Поддержка Windows на ARM была добавлена в Electron 5.0.8. Поддержка Windows 7, 8 и 8.1 была [удалена в Electron 23, в соответствии с политикой прекращения поддержки Windows в Chromium](https://www.electronjs.org/blog/windows-7-to-8-1-deprecation-notice).
* Linux: Готовые бинарные файлы Electron собираются на Ubuntu 20.04. Также подтверждена их работа на:
  * Ubuntu 18.04 и новее
  * Fedora 32 и новее
  * Debian 10 и новее

## Electron Fiddle

Используйте [`Electron Fiddle`](https://github.com/electron/fiddle) для сборки, запуска и упаковки небольших экспериментов с Electron, чтобы просматривать примеры кода для всех API Electron и пробовать разные версии Electron. Этот инструмент предназначен для упрощения ваших первых шагов с Electron.

## Ресурсы для изучения Electron

* [electronjs.org/docs](https://electronjs.org/docs) — Вся документация по Electron
* [electron/fiddle](https://github.com/electron/fiddle) — Инструмент для создания, запуска и упаковки небольших экспериментов с Electron
* [electronjs.org/community#boilerplates](https://electronjs.org/community#boilerplates) — Примерные стартовые приложения, созданные сообществом

## Программное использование

Большинство пользователей запускают Electron из командной строки, но если вы подключаете `electron` внутри **Node-приложения** (не вашего Electron-приложения), он вернет путь к бинарному файлу. Используйте это для запуска Electron из Node-скриптов:

```javascript
const electron = require('electron')
const proc = require('node:child_process')

// выведет что-то вроде /Users/maf/.../Electron
console.log(electron)

// запуск Electron
const child = proc.spawn(electron)
```

### Зеркала

* [Китай](https://npmmirror.com/mirrors/electron/)

См. [Расширенные инструкции по установке](https://www.electronjs.org/docs/latest/tutorial/installation#mirror), чтобы узнать, как использовать собственное зеркало.

## Переводы документации

Мы осуществляем перевод нашей документации с помощью [Crowdin](https://crowdin.com/project/electron).
В настоящее время мы принимаем переводы на китайский (упрощённый), французский, немецкий, японский, португальский, русский и испанский языки.

## Вклад

Если вы заинтересованы в сообщении/исправлении ошибок и хотите напрямую вносить вклад в кодовую базу, пожалуйста, ознакомьтесь с [CONTRIBUTING.md](CONTRIBUTING.md) для получения дополнительной информации о том, что нам нужно и как начать.

## Сообщество

Информацию о сообщении об ошибках, получении помощи, поиске сторонних инструментов и примеров приложений и многое другое можно найти на [странице сообщества](https://www.electronjs.org/community).

## Лицензия

[MIT](https://github.com/electron/electron/blob/main/LICENSE)

Используя логотипы Electron, убедитесь, что соблюдаете [Политику товарных знаков OpenJS Foundation](https://trademark-policy.openjsf.org/).

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---