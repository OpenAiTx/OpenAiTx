<img src=".github/splash.png" alt="Tauri" />

[![status](https://img.shields.io/badge/status-stable-blue.svg)](https://github.com/tauri-apps/tauri/tree/dev)
[![License](https://img.shields.io/badge/License-MIT%20or%20Apache%202-green.svg)](https://opencollective.com/tauri)
[![test core](https://img.shields.io/github/actions/workflow/status/tauri-apps/tauri/test-core.yml?label=test%20core&logo=github)](https://github.com/tauri-apps/tauri/actions/workflows/test-core.yml)
[![FOSSA Status](https://app.fossa.com/api/projects/git%2Bgithub.com%2Ftauri-apps%2Ftauri.svg?type=shield)](https://app.fossa.com/projects/git%2Bgithub.com%2Ftauri-apps%2Ftauri?ref=badge_shield)
[![Chat Server](https://img.shields.io/badge/chat-discord-7289da.svg)](https://discord.gg/SpmNs4S)
[![website](https://img.shields.io/badge/website-tauri.app-purple.svg)](https://tauri.app)
[![https://good-labs.github.io/greater-good-affirmation/assets/images/badge.svg](https://good-labs.github.io/greater-good-affirmation/assets/images/badge.svg)](https://good-labs.github.io/greater-good-affirmation)
[![support](https://img.shields.io/badge/sponsor-Open%20Collective-blue.svg)](https://opencollective.com/tauri)

## Введение

Tauri — это фреймворк для создания крошечных, невероятно быстрых исполняемых файлов для всех основных настольных платформ. Разработчики могут интегрировать любой фронтенд-фреймворк, компилирующийся в HTML, JS и CSS для построения пользовательского интерфейса. Бэкенд приложения — это бинарный файл на Rust с API, с которым может взаимодействовать фронтенд.

Пользовательский интерфейс в приложениях Tauri в настоящее время использует [`tao`](https://docs.rs/tao) в качестве библиотеки управления окнами на macOS, Windows, Linux, Android и iOS. Для рендеринга вашего приложения Tauri использует [WRY](https://github.com/tauri-apps/wry) — библиотеку, предоставляющую унифицированный интерфейс к системному webview, используя WKWebView на macOS и iOS, WebView2 на Windows, WebKitGTK на Linux и Android System WebView на Android.

Чтобы узнать больше о том, как все эти компоненты работают вместе, ознакомьтесь с документом [ARCHITECTURE.md](https://github.com/tauri-apps/tauri/blob/dev/ARCHITECTURE.md).

## Начало работы

Если вы хотите создать приложение на Tauri, посетите [сайт документации](https://tauri.app).

Самый быстрый способ начать — установить [необходимые зависимости](https://v2.tauri.app/start/prerequisites/) для вашей системы и создать новый проект с помощью [`create-tauri-app`](https://github.com/tauri-apps/create-tauri-app/#usage). Например, используя `npm`:

```sh
npm create tauri-app@latest
```

## Возможности

Возможности Tauri включают, но не ограничиваются:

- Встроенный сборщик приложений для создания пакетов в форматах `.app`, `.dmg`, `.deb`, `.rpm`, `.AppImage` и установщиков Windows, таких как `.exe` (через NSIS) и `.msi` (через WiX).
- Встроенное самостоятельное обновление (только для настольных ОС)
- Значки в системном трее
- Родные уведомления
- Родной протокол WebView (tauri не создает локальный http(s) сервер для обслуживания содержимого WebView)
- GitHub Action для упрощения CI
- Расширение для VS Code

### Платформы

Tauri в настоящее время поддерживает разработку и распространение на следующих платформах:

| Платформа  | Версии                                                                                                         |
| :--------- | :------------------------------------------------------------------------------------------------------------- |
| Windows    | 7 и выше                                                                                                       |
| macOS      | 10.15 и выше                                                                                                   |
| Linux      | webkit2gtk 4.0 для Tauri v1 (например, Ubuntu 18.04). webkit2gtk 4.1 для Tauri v2 (например, Ubuntu 22.04).    |
| iOS/iPadOS | 9 и выше                                                                                                       |
| Android    | 7 и выше (в настоящее время 8 и выше)                                                                          |

## Вклад в проект

Перед тем как начать работу над чем-либо, лучше сначала проверить, существует ли уже такая задача. Также рекомендуется зайти на сервер Discord и уточнить у команды, имеет ли это смысл или кто-то другой уже работает над этим.

Пожалуйста, ознакомьтесь с [руководством по внесению вклада](./.github/CONTRIBUTING.md) перед созданием pull request.

Спасибо всем, кто вносит вклад в Tauri!

### Документация

Документация в многоязычной системе — это сложная задача. Поэтому мы предпочитаем использовать встроенную документацию в исходном коде на Rust и JS, насколько это возможно. Ознакомьтесь с репозиторием для сайта документации для получения дополнительной информации: <https://github.com/tauri-apps/tauri-docs>

## Партнеры

<table>
  <tbody>
    <tr>
      <td align="center" valign="middle">
        <a href="https://crabnebula.dev" target="_blank">
          <img src=".github/sponsors/crabnebula.svg" alt="CrabNebula" width="283">
        </a>
      </td>
    </tr>
  </tbody>
</table>

Полный список спонсоров смотрите на нашем [сайте](https://tauri.app#sponsors) и на [Open Collective](https://opencollective.com/tauri).

## Организация

Tauri стремится быть устойчивым коллективом, основанным на принципах, которые направляют [устойчивые сообщества свободного и открытого ПО](https://sfosc.org). В связи с этим он стал Программой в рамках [Commons Conservancy](https://commonsconservancy.org/), и вы можете поддержать проект финансово через [Open Collective](https://opencollective.com/tauri).

## Лицензии

Код: (c) 2015 - настоящее время — Программа Tauri в рамках The Commons Conservancy.

MIT или MIT/Apache 2.0, где применимо.

Логотип: CC-BY-NC-ND

- Оригинальные дизайны логотипа Tauri: [Alve Larsson](https://alve.io/), [Daniel Thompson-Yvetot](https://github.com/nothingismagick) и [Guillaume Chau](https://github.com/akryum)

[![FOSSA Status](https://app.fossa.com/api/projects/git%2Bgithub.com%2Ftauri-apps%2Ftauri.svg?type=large)](https://app.fossa.com/projects/git%2Bgithub.com%2Ftauri-apps%2Ftauri?ref=badge_large)


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---