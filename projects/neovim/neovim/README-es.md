<h1 align="center">
  <img src="https://raw.githubusercontent.com/neovim/neovim.github.io/master/logos/neovim-logo-300x87.png" alt="Neovim">

  <a href="https://neovim.io/doc/">Documentación</a> |
  <a href="https://app.element.io/#/room/#neovim:matrix.org">Chat</a>
</h1>

[![Análisis de Coverity Scan](https://scan.coverity.com/projects/2227/badge.svg)](https://scan.coverity.com/projects/2227)
[![Paquetes](https://repology.org/badge/tiny-repos/neovim.svg)](https://repology.org/metapackage/neovim)
[![Debian CI](https://badges.debian.net/badges/debian/testing/neovim/version.svg)](https://buildd.debian.org/neovim)
[![Descargas](https://img.shields.io/github/downloads/neovim/neovim/total.svg?maxAge=2592001)](https://github.com/neovim/neovim/releases/)

Neovim es un proyecto que busca refactorizar de manera agresiva [Vim](https://www.vim.org/) para:

- Simplificar el mantenimiento y fomentar las [contribuciones](CONTRIBUTING.md)
- Dividir el trabajo entre varios desarrolladores
- Permitir [interfaces de usuario avanzadas] sin modificaciones al núcleo
- Maximizar la [extensibilidad](https://neovim.io/doc/user/ui.html)

Consulta la página wiki de la [Introducción](https://github.com/neovim/neovim/wiki/Introduction) y la [Hoja de ruta]
para más información.

Características
---------------

- [Interfaces gráficas modernas](https://github.com/neovim/neovim/wiki/Related-projects#gui)
- [Acceso a la API](https://github.com/neovim/neovim/wiki/Related-projects#api-clients)
  desde cualquier lenguaje, incluyendo C/C++, C#, Clojure, D, Elixir, Go, Haskell, Java/Kotlin,
  JavaScript/Node.js, Julia, Lisp, Lua, Perl, Python, Racket, Ruby, Rust
- [Emulador de terminal](https://neovim.io/doc/user/terminal.html) embebido y programable
- [Control de tareas asíncrono](https://github.com/neovim/neovim/pull/2247)
- [Datos compartidos (shada)](https://github.com/neovim/neovim/pull/2506) entre múltiples instancias del editor
- Soporte de [directorios base XDG](https://github.com/neovim/neovim/pull/3470)
- Compatible con la mayoría de los complementos de Vim, incluidos los de Ruby y Python

Consulta [`:help nvim-features`][nvim-features] para la lista completa, y [`:help news`][nvim-news] para los cambios destacados en la última versión.

Instalar desde paquete
----------------------

Los paquetes precompilados para Windows, macOS y Linux se encuentran en la
página de [Lanzamientos](https://github.com/neovim/neovim/releases/).

¡[Paquetes gestionados] están en [Homebrew], [Debian], [Ubuntu], [Fedora], [Arch Linux], [Void Linux], [Gentoo] y más!

Instalar desde el código fuente
-------------------------------

Consulta [BUILD.md](./BUILD.md) y [plataformas soportadas](https://neovim.io/doc/user/support.html#supported-platforms) para más detalles.

La compilación se basa en CMake, pero se proporciona un Makefile como conveniencia.
Después de instalar las dependencias, ejecuta el siguiente comando.

    make CMAKE_BUILD_TYPE=RelWithDebInfo
    sudo make install

Para instalar en una ubicación personalizada:

    make CMAKE_BUILD_TYPE=RelWithDebInfo CMAKE_INSTALL_PREFIX=/ruta/completa/
    make install

Sugerencias de CMake para inspeccionar la compilación:

- `cmake --build build --target help` muestra todos los objetivos de compilación.
- `build/CMakeCache.txt` (o `cmake -LAH build/`) contiene los valores resueltos de todas las variables de CMake.
- `build/compile_commands.json` muestra las invocaciones completas del compilador para cada unidad de traducción.

Transición desde Vim
--------------------

Consulta [`:help nvim-from-vim`](https://neovim.io/doc/user/nvim.html#nvim-from-vim) para instrucciones.

Estructura del proyecto
-----------------------

    ├─ cmake/           Utilidades de CMake
    ├─ cmake.config/    Definiciones de CMake
    ├─ cmake.deps/      Subproyecto para obtener y compilar dependencias (opcional)
    ├─ runtime/         Complementos y documentación
    ├─ src/nvim/        Código fuente de la aplicación (ver src/nvim/README.md)
    │  ├─ api/          Subsistema de API
    │  ├─ eval/         Subsistema Vimscript
    │  ├─ event/        Subsistema de bucle de eventos
    │  ├─ generators/   Generación de código (pre-compilación)
    │  ├─ lib/          Estructuras de datos genéricas
    │  ├─ lua/          Subsistema de Lua
    │  ├─ msgpack_rpc/  Subsistema RPC
    │  ├─ os/           Código de plataforma de bajo nivel
    │  └─ tui/          Interfaz de usuario incorporada
    └─ test/            Pruebas (ver test/README.md)

Licencia
--------

Las contribuciones a Neovim desde [b17d96][license-commit] están licenciadas bajo la
licencia Apache 2.0, excepto las contribuciones copiadas de Vim (identificadas por el
token `vim-patch`). Consulta LICENSE para más detalles.

    Vim es Charityware. Puedes usarlo y copiarlo tanto como quieras, pero se te anima
    a hacer una donación para niños necesitados en Uganda. Por favor, consulta la
    sección kcc de la documentación de Vim o visita el sitio web de ICCF, disponible en estas URLs:

            https://iccf-holland.org/
            https://www.vim.org/iccf/
            https://www.iccf.nl/

    También puedes patrocinar el desarrollo de Vim. Los patrocinadores de Vim pueden votar
    por características. El dinero va a Uganda de todos modos.

[license-commit]: https://github.com/neovim/neovim/commit/b17d9691a24099c9210289f16afb1a498a89d803
[nvim-features]: https://neovim.io/doc/user/vim_diff.html#nvim-features
[nvim-news]: https://neovim.io/doc/user/news.html
[Roadmap]: https://neovim.io/roadmap/
[interfaces de usuario avanzadas]: https://github.com/neovim/neovim/wiki/Related-projects#gui
[Paquetes gestionados]: ./INSTALL.md#install-from-package
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