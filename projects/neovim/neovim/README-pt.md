<h1 align="center">
  <img src="https://raw.githubusercontent.com/neovim/neovim.github.io/master/logos/neovim-logo-300x87.png" alt="Neovim">

  <a href="https://neovim.io/doc/">Documentação</a> |
  <a href="https://app.element.io/#/room/#neovim:matrix.org">Chat</a>
</h1>

[![Coverity Scan analysis](https://scan.coverity.com/projects/2227/badge.svg)](https://scan.coverity.com/projects/2227)
[![Packages](https://repology.org/badge/tiny-repos/neovim.svg)](https://repology.org/metapackage/neovim)
[![Debian CI](https://badges.debian.net/badges/debian/testing/neovim/version.svg)](https://buildd.debian.org/neovim)
[![Downloads](https://img.shields.io/github/downloads/neovim/neovim/total.svg?maxAge=2592001)](https://github.com/neovim/neovim/releases/)

Neovim é um projeto que busca refatorar agressivamente o [Vim](https://www.vim.org/) para:

- Simplificar a manutenção e incentivar [contribuições](CONTRIBUTING.md)
- Dividir o trabalho entre vários desenvolvedores
- Permitir [UIs avançadas] sem modificações no núcleo
- Maximizar a [extensibilidade](https://neovim.io/doc/user/ui.html)

Veja a página da wiki [Introdução](https://github.com/neovim/neovim/wiki/Introduction) e o [Roteiro] para mais informações.

Funcionalidades
---------------

- [GUIs](https://github.com/neovim/neovim/wiki/Related-projects#gui) modernas
- [Acesso à API](https://github.com/neovim/neovim/wiki/Related-projects#api-clients)
  a partir de qualquer linguagem, incluindo C/C++, C#, Clojure, D, Elixir, Go, Haskell, Java/Kotlin,
  JavaScript/Node.js, Julia, Lisp, Lua, Perl, Python, Racket, Ruby, Rust
- [Emulador de terminal](https://neovim.io/doc/user/terminal.html) embutido e scriptável
- [Controle de tarefas assíncronas](https://github.com/neovim/neovim/pull/2247)
- [Dados compartilhados (shada)](https://github.com/neovim/neovim/pull/2506) entre múltiplas instâncias do editor
- Suporte a [diretórios base XDG](https://github.com/neovim/neovim/pull/3470)
- Compatível com a maioria dos plugins do Vim, incluindo plugins Ruby e Python

Consulte [`:help nvim-features`][nvim-features] para a lista completa, e [`:help news`][nvim-news] para mudanças notáveis na versão mais recente!

Instale a partir de pacotes
---------------------------

Pacotes pré-compilados para Windows, macOS e Linux podem ser encontrados na
página de [Lançamentos](https://github.com/neovim/neovim/releases/).

[Pacotes gerenciados] estão disponíveis no [Homebrew], [Debian], [Ubuntu], [Fedora], [Arch Linux], [Void Linux], [Gentoo] e mais!

Instale a partir do código-fonte
-------------------------------

Veja [BUILD.md](./BUILD.md) e [plataformas suportadas](https://neovim.io/doc/user/support.html#supported-platforms) para mais detalhes.

A compilação é baseada em CMake, mas um Makefile é fornecido para conveniência.
Após instalar as dependências, execute o seguinte comando.

    make CMAKE_BUILD_TYPE=RelWithDebInfo
    sudo make install

Para instalar em um local não padrão:

    make CMAKE_BUILD_TYPE=RelWithDebInfo CMAKE_INSTALL_PREFIX=/caminho/completo/
    make install

Dicas do CMake para inspecionar a compilação:

- `cmake --build build --target help` lista todos os alvos de compilação.
- `build/CMakeCache.txt` (ou `cmake -LAH build/`) contém os valores resolvidos de todas as variáveis do CMake.
- `build/compile_commands.json` mostra todas as invocações do compilador para cada unidade de tradução.

Transição do Vim
----------------

Veja [`:help nvim-from-vim`](https://neovim.io/doc/user/nvim.html#nvim-from-vim) para instruções.

Estrutura do projeto
--------------------

    ├─ cmake/           Utilitários do CMake
    ├─ cmake.config/    Definições do CMake
    ├─ cmake.deps/      Subprojeto para buscar e compilar dependências (opcional)
    ├─ runtime/         Plugins e documentações
    ├─ src/nvim/        Código-fonte da aplicação (veja src/nvim/README.md)
    │  ├─ api/          Subsistema da API
    │  ├─ eval/         Subsistema Vimscript
    │  ├─ event/        Subsistema de loop de eventos
    │  ├─ generators/   Geração de código (pré-compilação)
    │  ├─ lib/          Estruturas de dados genéricas
    │  ├─ lua/          Subsistema Lua
    │  ├─ msgpack_rpc/  Subsistema RPC
    │  ├─ os/           Código de plataforma de baixo nível
    │  └─ tui/          UI embutida
    └─ test/            Testes (veja test/README.md)

Licença
-------

Contribuições para o Neovim desde o [b17d96][license-commit] são licenciadas sob a
licença Apache 2.0, exceto por contribuições copiadas do Vim (identificadas pelo
token `vim-patch`). Veja LICENSE para detalhes.

    Vim é Charityware.  Você pode usar e copiar o quanto quiser, mas é
    incentivado a fazer uma doação para crianças carentes em Uganda.  Por favor, veja a
    seção kcc da documentação do vim ou visite o site da ICCF, disponível nestes URLs:

            https://iccf-holland.org/
            https://www.vim.org/iccf/
            https://www.iccf.nl/

    Você também pode patrocinar o desenvolvimento do Vim.  Patrocinadores do Vim podem votar em
    funcionalidades.  O dinheiro vai para Uganda de qualquer forma.

[license-commit]: https://github.com/neovim/neovim/commit/b17d9691a24099c9210289f16afb1a498a89d803
[nvim-features]: https://neovim.io/doc/user/vim_diff.html#nvim-features
[nvim-news]: https://neovim.io/doc/user/news.html
[Roadmap]: https://neovim.io/roadmap/
[advanced UIs]: https://github.com/neovim/neovim/wiki/Related-projects#gui
[Pacotes gerenciados]: ./INSTALL.md#install-from-package
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