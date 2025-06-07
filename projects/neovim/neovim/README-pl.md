<h1 align="center">
  <img src="https://raw.githubusercontent.com/neovim/neovim.github.io/master/logos/neovim-logo-300x87.png" alt="Neovim">

  <a href="https://neovim.io/doc/">Dokumentacja</a> |
  <a href="https://app.element.io/#/room/#neovim:matrix.org">Czat</a>
</h1>

[![Analiza Coverity Scan](https://scan.coverity.com/projects/2227/badge.svg)](https://scan.coverity.com/projects/2227)
[![Pakiety](https://repology.org/badge/tiny-repos/neovim.svg)](https://repology.org/metapackage/neovim)
[![Debian CI](https://badges.debian.net/badges/debian/testing/neovim/version.svg)](https://buildd.debian.org/neovim)
[![Pobrania](https://img.shields.io/github/downloads/neovim/neovim/total.svg?maxAge=2592001)](https://github.com/neovim/neovim/releases/)

Neovim to projekt, który ma na celu zdecydowaną refaktoryzację [Vim](https://www.vim.org/), aby:

- Uprościć utrzymanie i zachęcić do [współpracy](CONTRIBUTING.md)
- Rozdzielić pracę pomiędzy wielu deweloperów
- Umożliwić [zaawansowane interfejsy użytkownika] bez modyfikacji rdzenia
- Zmaksymalizować [rozszerzalność](https://neovim.io/doc/user/ui.html)

Zobacz stronę wiki [Wprowadzenie](https://github.com/neovim/neovim/wiki/Introduction) oraz [Roadmap]
po więcej informacji.

Funkcje
--------

- Nowoczesne [GUI](https://github.com/neovim/neovim/wiki/Related-projects#gui)
- [Dostęp do API](https://github.com/neovim/neovim/wiki/Related-projects#api-clients)
  z dowolnego języka, w tym C/C++, C#, Clojure, D, Elixir, Go, Haskell, Java/Kotlin,
  JavaScript/Node.js, Julia, Lisp, Lua, Perl, Python, Racket, Ruby, Rust
- Wbudowany, skryptowalny [emulator terminala](https://neovim.io/doc/user/terminal.html)
- Asynchroniczna [kontrola zadań](https://github.com/neovim/neovim/pull/2247)
- [Współdzielone dane (shada)](https://github.com/neovim/neovim/pull/2506) pomiędzy wieloma instancjami edytora
- Obsługa [katalogów bazowych XDG](https://github.com/neovim/neovim/pull/3470)
- Kompatybilny z większością wtyczek Vim, w tym wtyczkami Ruby i Python

Zobacz [`:help nvim-features`][nvim-features] dla pełnej listy oraz [`:help news`][nvim-news], aby poznać ważne zmiany w najnowszej wersji!

Instalacja z pakietu
--------------------

Gotowe pakiety dla Windows, macOS i Linux znajdują się na stronie
[Wydania](https://github.com/neovim/neovim/releases/).

[Zarządzane pakiety] są dostępne w [Homebrew], [Debian], [Ubuntu], [Fedora], [Arch Linux], [Void Linux], [Gentoo] i wielu innych!

Instalacja ze źródeł
--------------------

Szczegóły znajdziesz w [BUILD.md](./BUILD.md) oraz na stronie [obsługiwane platformy](https://neovim.io/doc/user/support.html#supported-platforms).

Budowanie wykorzystuje CMake, ale Makefile jest dostępny dla wygody.
Po zainstalowaniu zależności uruchom poniższe polecenie.

    make CMAKE_BUILD_TYPE=RelWithDebInfo
    sudo make install

Aby zainstalować do niestandardowej lokalizacji:

    make CMAKE_BUILD_TYPE=RelWithDebInfo CMAKE_INSTALL_PREFIX=/pelna/sciezka/
    make install

Wskazówki CMake dotyczące inspekcji budowy:

- `cmake --build build --target help` wyświetla wszystkie cele budowania.
- `build/CMakeCache.txt` (lub `cmake -LAH build/`) zawiera rozstrzygnięte wartości wszystkich zmiennych CMake.
- `build/compile_commands.json` pokazuje pełne wywołania kompilatora dla każdej jednostki translacji.

Przechodzenie z Vim
--------------------

Zobacz [`:help nvim-from-vim`](https://neovim.io/doc/user/nvim.html#nvim-from-vim) po instrukcje.

Struktura projektu
--------------

    ├─ cmake/           Narzędzia CMake
    ├─ cmake.config/    Definicje CMake
    ├─ cmake.deps/      Podprojekt pobierający i budujący zależności (opcjonalnie)
    ├─ runtime/         Wtyczki i dokumentacja
    ├─ src/nvim/        Kod źródłowy aplikacji (zobacz src/nvim/README.md)
    │  ├─ api/          Podsystem API
    │  ├─ eval/         Podsystem Vimscript
    │  ├─ event/        Podsystem pętli zdarzeń
    │  ├─ generators/   Generowanie kodu (przed kompilacją)
    │  ├─ lib/          Ogólne struktury danych
    │  ├─ lua/          Podsystem Lua
    │  ├─ msgpack_rpc/  Podsystem RPC
    │  ├─ os/           Niskopoziomowy kod platformowy
    │  └─ tui/          Wbudowany interfejs tekstowy
    └─ test/            Testy (zobacz test/README.md)

Licencja
-------

Wkłady do Neovim od [b17d96][license-commit] objęte są licencją Apache 2.0, z wyjątkiem fragmentów skopiowanych z Vim (oznaczonych tokenem `vim-patch`). Szczegóły w pliku LICENSE.

    Vim jest Charityware.  Możesz go używać i kopiować dowolnie, ale zachęcamy do
    przekazania datku na rzecz potrzebujących dzieci w Ugandzie.  Zobacz sekcję
    kcc w dokumentacji vim lub odwiedź stronę ICCF, dostępną pod tymi adresami:

            https://iccf-holland.org/
            https://www.vim.org/iccf/
            https://www.iccf.nl/

    Możesz również sponsorować rozwój Vima.  Sponsorzy mogą głosować na funkcje.
    Pieniądze i tak trafiają do Ugandy.

[license-commit]: https://github.com/neovim/neovim/commit/b17d9691a24099c9210289f16afb1a498a89d803
[nvim-features]: https://neovim.io/doc/user/vim_diff.html#nvim-features
[nvim-news]: https://neovim.io/doc/user/news.html
[Roadmap]: https://neovim.io/roadmap/
[advanced UIs]: https://github.com/neovim/neovim/wiki/Related-projects#gui
[Zarządzane pakiety]: ./INSTALL.md#install-from-package
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