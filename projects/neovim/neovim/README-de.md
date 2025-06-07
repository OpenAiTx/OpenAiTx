<h1 align="center">
  <img src="https://raw.githubusercontent.com/neovim/neovim.github.io/master/logos/neovim-logo-300x87.png" alt="Neovim">

  <a href="https://neovim.io/doc/">Dokumentation</a> |
  <a href="https://app.element.io/#/room/#neovim:matrix.org">Chat</a>
</h1>

[![Coverity Scan analysis](https://scan.coverity.com/projects/2227/badge.svg)](https://scan.coverity.com/projects/2227)
[![Pakete](https://repology.org/badge/tiny-repos/neovim.svg)](https://repology.org/metapackage/neovim)
[![Debian CI](https://badges.debian.net/badges/debian/testing/neovim/version.svg)](https://buildd.debian.org/neovim)
[![Downloads](https://img.shields.io/github/downloads/neovim/neovim/total.svg?maxAge=2592001)](https://github.com/neovim/neovim/releases/)

Neovim ist ein Projekt, das darauf abzielt, [Vim](https://www.vim.org/) radikal zu refaktorieren, um:

- Die Wartung zu vereinfachen und [Beiträge](CONTRIBUTING.md) zu fördern
- Die Arbeit auf mehrere Entwickler aufzuteilen
- [Erweiterte Benutzeroberflächen] ohne Änderungen am Kern zu ermöglichen
- Die [Erweiterbarkeit](https://neovim.io/doc/user/ui.html) zu maximieren

Weitere Informationen finden Sie auf der Wiki-Seite [Einführung](https://github.com/neovim/neovim/wiki/Introduction) und im [Fahrplan].

Funktionen
----------

- Moderne [GUIs](https://github.com/neovim/neovim/wiki/Related-projects#gui)
- [API-Zugriff](https://github.com/neovim/neovim/wiki/Related-projects#api-clients)
  aus jeder Sprache, darunter C/C++, C#, Clojure, D, Elixir, Go, Haskell, Java/Kotlin,
  JavaScript/Node.js, Julia, Lisp, Lua, Perl, Python, Racket, Ruby, Rust
- Eingebetteter, skriptbarer [Terminal-Emulator](https://neovim.io/doc/user/terminal.html)
- Asynchrone [Jobsteuerung](https://github.com/neovim/neovim/pull/2247)
- [Geteilte Daten (shada)](https://github.com/neovim/neovim/pull/2506) zwischen mehreren Editor-Instanzen
- Unterstützung von [XDG-Basisverzeichnissen](https://github.com/neovim/neovim/pull/3470)
- Kompatibel mit den meisten Vim-Plugins, einschließlich Ruby- und Python-Plugins

Die vollständige Liste finden Sie unter [`:help nvim-features`][nvim-features] und die wichtigsten Änderungen der neuesten Version unter [`:help news`][nvim-news]!

Installation aus Paket
----------------------

Vorgefertigte Pakete für Windows, macOS und Linux finden Sie auf der
[Releases](https://github.com/neovim/neovim/releases/)-Seite.

[Verwaltete Pakete] sind in [Homebrew], [Debian], [Ubuntu], [Fedora], [Arch Linux], [Void Linux], [Gentoo] und mehr verfügbar!

Installation aus dem Quellcode
------------------------------

Siehe [BUILD.md](./BUILD.md) und [unterstützte Plattformen](https://neovim.io/doc/user/support.html#supported-platforms) für Details.

Der Build basiert auf CMake, aber ein Makefile wird als Komfort bereitgestellt.
Nach der Installation der Abhängigkeiten führen Sie folgenden Befehl aus:

    make CMAKE_BUILD_TYPE=RelWithDebInfo
    sudo make install

Um an einen nicht standardmäßigen Ort zu installieren:

    make CMAKE_BUILD_TYPE=RelWithDebInfo CMAKE_INSTALL_PREFIX=/voller/pfad/
    make install

CMake-Hinweise zum Überprüfen des Builds:

- `cmake --build build --target help` listet alle Build-Ziele auf.
- `build/CMakeCache.txt` (oder `cmake -LAH build/`) enthält die aufgelösten Werte aller CMake-Variablen.
- `build/compile_commands.json` zeigt die vollständigen Compiler-Aufrufe für jede Übersetzungseinheit.

Umstieg von Vim
---------------

Siehe [`:help nvim-from-vim`](https://neovim.io/doc/user/nvim.html#nvim-from-vim) für Anweisungen.

Projektstruktur
---------------

    ├─ cmake/           CMake-Tools
    ├─ cmake.config/    CMake-Definitionen
    ├─ cmake.deps/      Subprojekt zum Herunterladen und Bauen von Abhängigkeiten (optional)
    ├─ runtime/         Plugins und Dokumentation
    ├─ src/nvim/        Quellcode der Anwendung (siehe src/nvim/README.md)
    │  ├─ api/          API-Subsystem
    │  ├─ eval/         Vimscript-Subsystem
    │  ├─ event/        Event-Loop-Subsystem
    │  ├─ generators/   Codegenerierung (vor der Kompilierung)
    │  ├─ lib/          Generische Datenstrukturen
    │  ├─ lua/          Lua-Subsystem
    │  ├─ msgpack_rpc/  RPC-Subsystem
    │  ├─ os/           Low-Level-Plattform-Code
    │  └─ tui/          Eingebaute Benutzeroberfläche (UI)
    └─ test/            Tests (siehe test/README.md)

Lizenz
------

Neovim-Beiträge seit [b17d96][license-commit] stehen unter der
Apache 2.0-Lizenz, außer Beiträge, die von Vim kopiert wurden (gekennzeichnet durch das
`vim-patch`-Token). Details siehe LICENSE.

    Vim ist Charityware.  Sie können es beliebig nutzen und kopieren, aber Sie werden
    ermutigt, eine Spende für bedürftige Kinder in Uganda zu machen.  Bitte lesen Sie
    den kcc-Abschnitt der Vim-Dokumentation oder besuchen Sie die ICCF-Webseite unter diesen URLs:

            https://iccf-holland.org/
            https://www.vim.org/iccf/
            https://www.iccf.nl/

    Sie können auch die Entwicklung von Vim sponsern.  Vim-Sponsoren können über
    Features abstimmen.  Das Geld geht trotzdem nach Uganda.

[license-commit]: https://github.com/neovim/neovim/commit/b17d9691a24099c9210289f16afb1a498a89d803
[nvim-features]: https://neovim.io/doc/user/vim_diff.html#nvim-features
[nvim-news]: https://neovim.io/doc/user/news.html
[Fahrplan]: https://neovim.io/roadmap/
[erweiterte Benutzeroberflächen]: https://github.com/neovim/neovim/wiki/Related-projects#gui
[Verwaltete Pakete]: ./INSTALL.md#install-from-package
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