<h1 align="center">
  <img src="https://raw.githubusercontent.com/neovim/neovim.github.io/master/logos/neovim-logo-300x87.png" alt="Neovim">

  <a href="https://neovim.io/doc/">Documentatie</a> |
  <a href="https://app.element.io/#/room/#neovim:matrix.org">Chat</a>
</h1>

[![Coverity Scan analyse](https://scan.coverity.com/projects/2227/badge.svg)](https://scan.coverity.com/projects/2227)
[![Pakketten](https://repology.org/badge/tiny-repos/neovim.svg)](https://repology.org/metapackage/neovim)
[![Debian CI](https://badges.debian.net/badges/debian/testing/neovim/version.svg)](https://buildd.debian.org/neovim)
[![Downloads](https://img.shields.io/github/downloads/neovim/neovim/total.svg?maxAge=2592001)](https://github.com/neovim/neovim/releases/)

Neovim is een project dat erop gericht is om [Vim](https://www.vim.org/) grondig te herstructureren met als doel:

- Het onderhoud te vereenvoudigen en [bijdragen](CONTRIBUTING.md) aan te moedigen
- Het werk te verdelen over meerdere ontwikkelaars
- [Geavanceerde gebruikersinterfaces (UIs)] mogelijk te maken zonder aanpassingen aan de kern
- Maximale [uitbreidbaarheid](https://neovim.io/doc/user/ui.html) te realiseren

Zie de [Introductie](https://github.com/neovim/neovim/wiki/Introduction) wiki-pagina en de [Roadmap] voor meer informatie.

Functies
--------

- Moderne [GUI's](https://github.com/neovim/neovim/wiki/Related-projects#gui)
- [API-toegang](https://github.com/neovim/neovim/wiki/Related-projects#api-clients)
  vanuit elke taal, waaronder C/C++, C#, Clojure, D, Elixir, Go, Haskell, Java/Kotlin,
  JavaScript/Node.js, Julia, Lisp, Lua, Perl, Python, Racket, Ruby, Rust
- Ingebouwde, scriptbare [terminalemulator](https://neovim.io/doc/user/terminal.html)
- Asynchrone [taakbesturing](https://github.com/neovim/neovim/pull/2247)
- [Gedeelde data (shada)](https://github.com/neovim/neovim/pull/2506) tussen meerdere editor-instanties
- Ondersteuning voor [XDG-basisdirectory’s](https://github.com/neovim/neovim/pull/3470)
- Compatibel met de meeste Vim-plugins, inclusief Ruby- en Python-plugins

Zie [`:help nvim-features`][nvim-features] voor de volledige lijst en [`:help news`][nvim-news] voor belangrijke wijzigingen in de nieuwste versie!

Installeren via pakket
----------------------

Voorgebouwde pakketten voor Windows, macOS en Linux zijn te vinden op de
[Releases](https://github.com/neovim/neovim/releases/) pagina.

[Beheerde pakketten] zijn beschikbaar in [Homebrew], [Debian], [Ubuntu], [Fedora], [Arch Linux], [Void Linux], [Gentoo], en meer!

Installeren vanaf broncode
--------------------------

Zie [BUILD.md](./BUILD.md) en [ondersteunde platformen](https://neovim.io/doc/user/support.html#supported-platforms) voor details.

De build is gebaseerd op CMake, maar een Makefile is bijgevoegd voor het gemak.
Na het installeren van de afhankelijkheden voert u het volgende commando uit.

    make CMAKE_BUILD_TYPE=RelWithDebInfo
    sudo make install

Om te installeren op een niet-standaard locatie:

    make CMAKE_BUILD_TYPE=RelWithDebInfo CMAKE_INSTALL_PREFIX=/volledig/pad/
    make install

CMake-tips voor het inspecteren van de build:

- `cmake --build build --target help` toont alle build targets.
- `build/CMakeCache.txt` (of `cmake -LAH build/`) bevat de uiteindelijke waarden van alle CMake-variabelen.
- `build/compile_commands.json` toont de volledige compiler-aanroepen voor elke vertaalunit.

Overstappen van Vim
-------------------

Zie [`:help nvim-from-vim`](https://neovim.io/doc/user/nvim.html#nvim-from-vim) voor instructies.

Projectindeling
---------------

    ├─ cmake/           CMake-hulpprogramma's
    ├─ cmake.config/    CMake-definities
    ├─ cmake.deps/      subproject om afhankelijkheden op te halen en te bouwen (optioneel)
    ├─ runtime/         plugins en documentatie
    ├─ src/nvim/        broncode van de applicatie (zie src/nvim/README.md)
    │  ├─ api/          API-subsysteem
    │  ├─ eval/         Vimscript-subsysteem
    │  ├─ event/        event-loop-subsysteem
    │  ├─ generators/   codegeneratie (pre-compilatie)
    │  ├─ lib/          generieke datastructuren
    │  ├─ lua/          Lua-subsysteem
    │  ├─ msgpack_rpc/  RPC-subsysteem
    │  ├─ os/           laag-niveau platformcode
    │  └─ tui/          ingebouwde UI
    └─ test/            tests (zie test/README.md)

Licentie
--------

Neovim-bijdragen sinds [b17d96][license-commit] zijn gelicentieerd onder de
Apache 2.0-licentie, behalve bijdragen die uit Vim zijn gekopieerd (herkenbaar aan de
`vim-patch`-token). Zie LICENSE voor details.

    Vim is Charityware.  U mag het zoveel gebruiken en kopiëren als u wilt, maar u wordt
    aangemoedigd om een donatie te doen voor kansarme kinderen in Oeganda.  Zie de
    kcc-sectie van de vim-documentatie of bezoek de ICCF-website, bereikbaar via deze URL's:

            https://iccf-holland.org/
            https://www.vim.org/iccf/
            https://www.iccf.nl/

    U kunt ook de ontwikkeling van Vim sponsoren.  Vim-sponsoren kunnen stemmen op
    functies.  Het geld gaat hoe dan ook naar Oeganda.

[license-commit]: https://github.com/neovim/neovim/commit/b17d9691a24099c9210289f16afb1a498a89d803
[nvim-features]: https://neovim.io/doc/user/vim_diff.html#nvim-features
[nvim-news]: https://neovim.io/doc/user/news.html
[Roadmap]: https://neovim.io/roadmap/
[advanced UIs]: https://github.com/neovim/neovim/wiki/Related-projects#gui
[Managed packages]: ./INSTALL.md#install-from-package
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