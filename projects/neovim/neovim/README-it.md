<h1 align="center">
  <img src="https://raw.githubusercontent.com/neovim/neovim.github.io/master/logos/neovim-logo-300x87.png" alt="Neovim">

  <a href="https://neovim.io/doc/">Documentazione</a> |
  <a href="https://app.element.io/#/room/#neovim:matrix.org">Chat</a>
</h1>

[![Analisi Coverity Scan](https://scan.coverity.com/projects/2227/badge.svg)](https://scan.coverity.com/projects/2227)
[![Pacchetti](https://repology.org/badge/tiny-repos/neovim.svg)](https://repology.org/metapackage/neovim)
[![Debian CI](https://badges.debian.net/badges/debian/testing/neovim/version.svg)](https://buildd.debian.org/neovim)
[![Download](https://img.shields.io/github/downloads/neovim/neovim/total.svg?maxAge=2592001)](https://github.com/neovim/neovim/releases/)

Neovim è un progetto che mira a rifattorizzare in modo aggressivo [Vim](https://www.vim.org/) al fine di:

- Semplificare la manutenzione e incoraggiare le [contribuzioni](CONTRIBUTING.md)
- Suddividere il lavoro tra più sviluppatori
- Abilitare [interfacce avanzate (UI)] senza modifiche al core
- Massimizzare l’[estensibilità](https://neovim.io/doc/user/ui.html)

Consulta la pagina wiki [Introduzione](https://github.com/neovim/neovim/wiki/Introduction) e la [Roadmap]
per maggiori informazioni.

Caratteristiche
---------------

- Moderne [GUI](https://github.com/neovim/neovim/wiki/Related-projects#gui)
- [Accesso API](https://github.com/neovim/neovim/wiki/Related-projects#api-clients)
  da qualsiasi linguaggio, inclusi C/C++, C#, Clojure, D, Elixir, Go, Haskell, Java/Kotlin,
  JavaScript/Node.js, Julia, Lisp, Lua, Perl, Python, Racket, Ruby, Rust
- [Emulatore di terminale](https://neovim.io/doc/user/terminal.html) integrato e programmabile
- [Controllo dei processi asincrono](https://github.com/neovim/neovim/pull/2247)
- [Dati condivisi (shada)](https://github.com/neovim/neovim/pull/2506) tra più istanze dell’editor
- Supporto alle [cartelle base XDG](https://github.com/neovim/neovim/pull/3470)
- Compatibile con la maggior parte dei plugin Vim, inclusi quelli Ruby e Python

Consulta [`:help nvim-features`][nvim-features] per l’elenco completo e [`:help news`][nvim-news] per le novità più importanti dell’ultima versione!

Installazione tramite pacchetto
-------------------------------

Pacchetti precompilati per Windows, macOS e Linux si trovano nella pagina
[Releases](https://github.com/neovim/neovim/releases/).

[Pacchetti gestiti] sono disponibili su [Homebrew], [Debian], [Ubuntu], [Fedora], [Arch Linux], [Void Linux], [Gentoo] e altri!

Installazione dal sorgente
--------------------------

Consulta [BUILD.md](./BUILD.md) e [piattaforme supportate](https://neovim.io/doc/user/support.html#supported-platforms) per i dettagli.

La build si basa su CMake, ma è fornito anche un Makefile per comodità.
Dopo aver installato le dipendenze, esegui il seguente comando.

    make CMAKE_BUILD_TYPE=RelWithDebInfo
    sudo make install

Per installare in una posizione diversa da quella predefinita:

    make CMAKE_BUILD_TYPE=RelWithDebInfo CMAKE_INSTALL_PREFIX=/percorso/completo/
    make install

Suggerimenti CMake per ispezionare la build:

- `cmake --build build --target help` elenca tutti i target di build.
- `build/CMakeCache.txt` (o `cmake -LAH build/`) contiene i valori risolti di tutte le variabili CMake.
- `build/compile_commands.json` mostra tutte le invocazioni del compilatore per ogni unità di traduzione.

Transizione da Vim
------------------

Consulta [`:help nvim-from-vim`](https://neovim.io/doc/user/nvim.html#nvim-from-vim) per le istruzioni.

Struttura del progetto
----------------------

    ├─ cmake/           Utility CMake
    ├─ cmake.config/    Definizioni CMake
    ├─ cmake.deps/      sottoprogetto per scaricare e compilare dipendenze (opzionale)
    ├─ runtime/         plugin e documentazione
    ├─ src/nvim/        codice sorgente dell’applicazione (vedi src/nvim/README.md)
    │  ├─ api/          sottosistema API
    │  ├─ eval/         sottosistema Vimscript
    │  ├─ event/        sottosistema event-loop
    │  ├─ generators/   generazione codice (pre-compilazione)
    │  ├─ lib/          strutture dati generiche
    │  ├─ lua/          sottosistema Lua
    │  ├─ msgpack_rpc/  sottosistema RPC
    │  ├─ os/           codice di basso livello per la piattaforma
    │  └─ tui/          UI integrata
    └─ test/            test (vedi test/README.md)

Licenza
-------

I contributi a Neovim successivi a [b17d96][license-commit] sono rilasciati sotto licenza
Apache 2.0, eccetto per i contributi copiati da Vim (identificati dal token
`vim-patch`). Vedi LICENSE per i dettagli.

    Vim è Charityware.  Puoi usarlo e copiarlo quanto vuoi, ma sei
    incoraggiato a fare una donazione per i bambini bisognosi in Uganda.  Consulta la
    sezione kcc della documentazione Vim oppure visita il sito ICCF, disponibile ai seguenti indirizzi:

            https://iccf-holland.org/
            https://www.vim.org/iccf/
            https://www.iccf.nl/

    Puoi anche sponsorizzare lo sviluppo di Vim.  Gli sponsor di Vim possono votare per
    nuove funzionalità.  In ogni caso, il denaro va in Uganda.

[license-commit]: https://github.com/neovim/neovim/commit/b17d9691a24099c9210289f16afb1a498a89d803
[nvim-features]: https://neovim.io/doc/user/vim_diff.html#nvim-features
[nvim-news]: https://neovim.io/doc/user/news.html
[Roadmap]: https://neovim.io/roadmap/
[advanced UIs]: https://github.com/neovim/neovim/wiki/Related-projects#gui
[Pacchetti gestiti]: ./INSTALL.md#install-from-package
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