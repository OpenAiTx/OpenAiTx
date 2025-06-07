<h1 align="center">
  <img src="https://raw.githubusercontent.com/neovim/neovim.github.io/master/logos/neovim-logo-300x87.png" alt="Neovim">

  <a href="https://neovim.io/doc/">Documentation</a> |
  <a href="https://app.element.io/#/room/#neovim:matrix.org">Chat</a>
</h1>

[![Analyse Coverity Scan](https://scan.coverity.com/projects/2227/badge.svg)](https://scan.coverity.com/projects/2227)
[![Paquets](https://repology.org/badge/tiny-repos/neovim.svg)](https://repology.org/metapackage/neovim)
[![Debian CI](https://badges.debian.net/badges/debian/testing/neovim/version.svg)](https://buildd.debian.org/neovim)
[![Téléchargements](https://img.shields.io/github/downloads/neovim/neovim/total.svg?maxAge=2592001)](https://github.com/neovim/neovim/releases/)

Neovim est un projet qui cherche à refondre de manière agressive [Vim](https://www.vim.org/) afin de :

- Simplifier la maintenance et encourager les [contributions](CONTRIBUTING.md)
- Répartir le travail entre plusieurs développeurs
- Permettre des [interfaces avancées] sans modifications du noyau
- Maximiser l’[extensibilité](https://neovim.io/doc/user/ui.html)

Voir la page wiki [Introduction](https://github.com/neovim/neovim/wiki/Introduction) et la [Feuille de route]
pour plus d’informations.

Fonctionnalités
---------------

- [Interfaces graphiques](https://github.com/neovim/neovim/wiki/Related-projects#gui) modernes
- [Accès à l’API](https://github.com/neovim/neovim/wiki/Related-projects#api-clients)
  depuis n’importe quel langage, y compris C/C++, C#, Clojure, D, Elixir, Go, Haskell, Java/Kotlin,
  JavaScript/Node.js, Julia, Lisp, Lua, Perl, Python, Racket, Ruby, Rust
- [Émulateur de terminal](https://neovim.io/doc/user/terminal.html) intégré et scriptable
- [Contrôle des tâches asynchrone](https://github.com/neovim/neovim/pull/2247)
- [Partage de données (shada)](https://github.com/neovim/neovim/pull/2506) entre plusieurs instances de l’éditeur
- Prise en charge des [répertoires de base XDG](https://github.com/neovim/neovim/pull/3470)
- Compatible avec la plupart des plugins Vim, y compris les plugins Ruby et Python

Voir [`:help nvim-features`][nvim-features] pour la liste complète, et [`:help news`][nvim-news] pour les changements notables de la dernière version !

Installation via un paquet
--------------------------

Des paquets précompilés pour Windows, macOS et Linux sont disponibles sur la page
[Releases](https://github.com/neovim/neovim/releases/).

Des [paquets gérés] sont présents dans [Homebrew], [Debian], [Ubuntu], [Fedora], [Arch Linux], [Void Linux], [Gentoo], et bien d’autres !

Installation depuis les sources
------------------------------

Voir [BUILD.md](./BUILD.md) et les [plateformes supportées](https://neovim.io/doc/user/support.html#supported-platforms) pour plus de détails.

La compilation est basée sur CMake, mais un Makefile est fourni pour plus de commodité.
Après avoir installé les dépendances, lancez la commande suivante.

    make CMAKE_BUILD_TYPE=RelWithDebInfo
    sudo make install

Pour installer dans un emplacement non par défaut :

    make CMAKE_BUILD_TYPE=RelWithDebInfo CMAKE_INSTALL_PREFIX=/chemin/complet/
    make install

Astuces CMake pour inspecter la compilation :

- `cmake --build build --target help` liste toutes les cibles de compilation.
- `build/CMakeCache.txt` (ou `cmake -LAH build/`) contient les valeurs résolues de toutes les variables CMake.
- `build/compile_commands.json` montre les appels complets du compilateur pour chaque unité de traduction.

Transition depuis Vim
---------------------

Voir [`:help nvim-from-vim`](https://neovim.io/doc/user/nvim.html#nvim-from-vim) pour les instructions.

Structure du projet
-------------------

    ├─ cmake/           utilitaires CMake
    ├─ cmake.config/    définitions CMake
    ├─ cmake.deps/      sous-projet pour récupérer et construire les dépendances (optionnel)
    ├─ runtime/         plugins et documentation
    ├─ src/nvim/        code source de l’application (voir src/nvim/README.md)
    │  ├─ api/          sous-système API
    │  ├─ eval/         sous-système Vimscript
    │  ├─ event/        sous-système boucle d’évènements
    │  ├─ generators/   génération de code (pré-compilation)
    │  ├─ lib/          structures de données génériques
    │  ├─ lua/          sous-système Lua
    │  ├─ msgpack_rpc/  sous-système RPC
    │  ├─ os/           code bas niveau pour la plateforme
    │  └─ tui/          interface utilisateur intégrée
    └─ test/            tests (voir test/README.md)

Licence
-------

Les contributions à Neovim depuis [b17d96][license-commit] sont sous licence
Apache 2.0, sauf pour les contributions issues de Vim (identifiées par le
jeton `vim-patch`). Voir LICENSE pour plus de détails.

    Vim est Charityware.  Vous pouvez l’utiliser et le copier autant que vous le souhaitez, mais vous êtes
    encouragé à faire un don pour les enfants nécessiteux en Ouganda.  Veuillez consulter la section kcc de la documentation de Vim ou visiter le site ICCF, accessible aux adresses suivantes :

            https://iccf-holland.org/
            https://www.vim.org/iccf/
            https://www.iccf.nl/

    Vous pouvez également sponsoriser le développement de Vim.  Les sponsors de Vim peuvent voter pour
    des fonctionnalités.  L’argent va de toute façon en Ouganda.

[license-commit]: https://github.com/neovim/neovim/commit/b17d9691a24099c9210289f16afb1a498a89d803
[nvim-features]: https://neovim.io/doc/user/vim_diff.html#nvim-features
[nvim-news]: https://neovim.io/doc/user/news.html
[Roadmap]: https://neovim.io/roadmap/
[interfaces avancées]: https://github.com/neovim/neovim/wiki/Related-projects#gui
[paquets gérés]: ./INSTALL.md#install-from-package
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