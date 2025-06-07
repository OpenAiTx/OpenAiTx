<h1 align="center">
  <img src="https://raw.githubusercontent.com/neovim/neovim.github.io/master/logos/neovim-logo-300x87.png" alt="Neovim">

  <a href="https://neovim.io/doc/">Документация</a> |
  <a href="https://app.element.io/#/room/#neovim:matrix.org">Чат</a>
</h1>

[![Анализ Coverity Scan](https://scan.coverity.com/projects/2227/badge.svg)](https://scan.coverity.com/projects/2227)
[![Пакеты](https://repology.org/badge/tiny-repos/neovim.svg)](https://repology.org/metapackage/neovim)
[![Debian CI](https://badges.debian.net/badges/debian/testing/neovim/version.svg)](https://buildd.debian.org/neovim)
[![Загрузки](https://img.shields.io/github/downloads/neovim/neovim/total.svg?maxAge=2592001)](https://github.com/neovim/neovim/releases/)

Neovim — это проект, который стремится агрессивно рефакторить [Vim](https://www.vim.org/), чтобы:

- Упростить сопровождение и поощрять [вклад](CONTRIBUTING.md)
- Разделить работу между несколькими разработчиками
- Включить [продвинутые интерфейсы] без изменений ядра
- Максимально повысить [расширяемость](https://neovim.io/doc/user/ui.html)

Смотрите страницу вики [Введение](https://github.com/neovim/neovim/wiki/Introduction) и [Дорожную карту] для получения дополнительной информации.

Возможности
-----------

- Современные [GUI](https://github.com/neovim/neovim/wiki/Related-projects#gui)
- [Доступ к API](https://github.com/neovim/neovim/wiki/Related-projects#api-clients)
  из любого языка, включая C/C++, C#, Clojure, D, Elixir, Go, Haskell, Java/Kotlin,
  JavaScript/Node.js, Julia, Lisp, Lua, Perl, Python, Racket, Ruby, Rust
- Встроенный, скриптуемый [терминальный эмулятор](https://neovim.io/doc/user/terminal.html)
- Асинхронное [управление задачами](https://github.com/neovim/neovim/pull/2247)
- [Общие данные (shada)](https://github.com/neovim/neovim/pull/2506) между несколькими экземплярами редактора
- Поддержка [базовых директорий XDG](https://github.com/neovim/neovim/pull/3470)
- Совместимость с большинством плагинов Vim, включая Ruby и Python плагины

Смотрите [`:help nvim-features`][nvim-features] для полного списка, и [`:help news`][nvim-news] для примечательных изменений в последней версии!

Установка из пакета
-------------------

Готовые пакеты для Windows, macOS и Linux доступны на странице
[Релизы](https://github.com/neovim/neovim/releases/).

[Управляемые пакеты] есть в [Homebrew], [Debian], [Ubuntu], [Fedora], [Arch Linux], [Void Linux], [Gentoo] и других!

Установка из исходников
-----------------------

Смотрите [BUILD.md](./BUILD.md) и [поддерживаемые платформы](https://neovim.io/doc/user/support.html#supported-platforms) для подробностей.

Сборка основана на CMake, но Makefile предоставлен для удобства.
После установки зависимостей выполните следующую команду.

    make CMAKE_BUILD_TYPE=RelWithDebInfo
    sudo make install

Чтобы установить в нестандартную директорию:

    make CMAKE_BUILD_TYPE=RelWithDebInfo CMAKE_INSTALL_PREFIX=/full/path/
    make install

Подсказки по CMake для анализа сборки:

- `cmake --build build --target help` выводит все цели сборки.
- `build/CMakeCache.txt` (или `cmake -LAH build/`) содержит итоговые значения всех переменных CMake.
- `build/compile_commands.json` показывает полные вызовы компилятора для каждого единичного файла.

Переход с Vim
-------------

Смотрите [`:help nvim-from-vim`](https://neovim.io/doc/user/nvim.html#nvim-from-vim) для инструкций.

Структура проекта
-----------------

    ├─ cmake/           Утилиты CMake
    ├─ cmake.config/    Определения CMake
    ├─ cmake.deps/      Подпроект для загрузки и сборки зависимостей (опционально)
    ├─ runtime/         Плагины и документация
    ├─ src/nvim/        Исходный код приложения (см. src/nvim/README.md)
    │  ├─ api/          Подсистема API
    │  ├─ eval/         Подсистема Vimscript
    │  ├─ event/        Подсистема event-loop
    │  ├─ generators/   Генерация кода (предкомпиляция)
    │  ├─ lib/          Универсальные структуры данных
    │  ├─ lua/          Подсистема Lua
    │  ├─ msgpack_rpc/  Подсистема RPC
    │  ├─ os/           Низкоуровневый платформенный код
    │  └─ tui/          Встроенный UI
    └─ test/            Тесты (см. test/README.md)

Лицензия
--------

Вклады в Neovim начиная с [b17d96][license-commit] лицензированы под лицензией
Apache 2.0, за исключением вкладов, скопированных из Vim (отмечены токеном
`vim-patch`). Подробнее см. в LICENSE.

    Vim — это Charityware.  Вы можете использовать и копировать его сколько угодно,
    но рекомендуется сделать пожертвование для нуждающихся детей в Уганде.  Пожалуйста,
    смотрите раздел kcc в документации Vim или посетите сайт ICCF по следующим адресам:

            https://iccf-holland.org/
            https://www.vim.org/iccf/
            https://www.iccf.nl/

    Вы также можете спонсировать разработку Vim.  Спонсоры Vim могут голосовать за новые
    функции.  Деньги всё равно идут в Уганду.

[license-commit]: https://github.com/neovim/neovim/commit/b17d9691a24099c9210289f16afb1a498a89d803
[nvim-features]: https://neovim.io/doc/user/vim_diff.html#nvim-features
[nvim-news]: https://neovim.io/doc/user/news.html
[Roadmap]: https://neovim.io/roadmap/
[продвинутые интерфейсы]: https://github.com/neovim/neovim/wiki/Related-projects#gui
[Управляемые пакеты]: ./INSTALL.md#install-from-package
[Debian]: https://packages.debian.org/testing/neovim
[Ubuntu]: https://packages.ubuntu.com/search?keywords=neovim
[Fedora]: https://packages.fedoraproject.org/pkgs/neovim/neovim/
[Arch Linux]: https://www.archlinux.org/packages/?q=neovim
[Void Linux]: https://voidlinux.org/packages/?arch=x86_64&q=neovim
[Gentoo]: https://packages.gentoo.org/packages/app-editors/neovim
[Homebrew]: https://formulae.brew.sh/formula/neovim

<!-- vim: set tw=80: -->

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---