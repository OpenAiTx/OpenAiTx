# gfold

[![latest release tag](https://img.shields.io/github/v/tag/nickgerace/gfold?sort=semver&logo=git&logoColor=white&label=version&style=for-the-badge&color=blue)](https://github.com/nickgerace/gfold/releases/latest)
[![crates.io version](https://img.shields.io/crates/v/gfold?style=for-the-badge&logo=rust&color=orange)](https://crates.io/crates/gfold)
[![build status](https://img.shields.io/github/actions/workflow/status/nickgerace/gfold/ci.yml?branch=main&style=for-the-badge&logo=github&logoColor=white)](https://github.com/nickgerace/gfold/actions)
[![calver](https://img.shields.io/badge/calver-YYYY.MM.MICRO-cyan.svg?style=for-the-badge)](https://calver.org)

`gfold` es una herramienta CLI que te ayuda a mantener un seguimiento de múltiples repositorios Git.

[![A GIF showcasing gfold in action](https://raw.githubusercontent.com/nickgerace/gfold/main/assets/demo.gif)](https://raw.githubusercontent.com/nickgerace/gfold/main/assets/demo.gif)

Si prefieres usar el modo de visualización clásico por defecto, y evitar establecer la bandera cada vez, puedes configurarlo en el archivo de configuración (ver sección **Uso**).

## Anuncio (febrero de 2025)

Todas las versiones ahora siguen el esquema de versionado [CalVer](https://calver.org/), comenzando con `2025.2.1`.
Este cambio es compatible tanto hacia adelante como hacia atrás con el esquema de versionado [Semantic Versioning](https://semver.org/spec/v2.0.0.html), que se usó desde la primera versión hasta la versión `4.6.0`.

*No se requiere ninguna acción por parte del usuario final específicamente para el cambio del esquema de versionado.*

Este anuncio eventualmente será removido de este [README](https://raw.githubusercontent.com/nickgerace/gfold/main/./README.md) y será trasladado al [CHANGELOG](https://raw.githubusercontent.com/nickgerace/gfold/main/./CHANGELOG.md).

## Descripción

Esta aplicación muestra información relevante para múltiples repositorios Git en uno o varios directorios.
Solo lee del sistema de archivos y nunca escribirá en él.
Aunque esta herramienta pueda parecer limitada en alcance y propósito, esto es por diseño.

Por defecto, `gfold` examina cada repositorio Git mediante un recorrido desde el directorio de trabajo actual.
Si deseas apuntar a otro directorio, puedes pasar su ruta (relativa o absoluta) como primer argumento o cambiar la ruta por defecto en el archivo de configuración.

Después del recorrido, `gfold` utiliza [rayon](https://github.com/rayon-rs/rayon) para realizar un análisis concurrente y solo de lectura de todos los repositorios Git detectados.
El análisis se realiza utilizando la biblioteca [git2-rs](https://github.com/rust-lang/git2-rs).

## Uso

Proporciona la bandera `-h/--help` para ver todas las opciones para usar esta aplicación.

```shell
# Operate in the current working directory or in the location provided by a config file, if one exists.
gfold

# Operate in the parent directory.
gfold ..

# Operate in the home directory (first method).
gfold $HOME

# Operate in the home directory (second method).
gfold ~/

# Operate with an absolute path.
gfold /this/is/an/absolute/path

# Operate with a relative path.
gfold ../../this/is/a/relative/path

# Operate with three paths.
gfold ~/src ~/projects ~/code
```

### Archivo de Configuración

Si te encuentras proporcionando los mismos argumentos con frecuencia, puedes crear y usar un archivo de configuración.  
`gfold` no incluye un archivo de configuración por defecto y los archivos de configuración son completamente opcionales.

¿Cómo funciona?  
Al ejecutarse, `gfold` buscará un archivo de configuración en las siguientes rutas (en orden):

- `$XDG_CONFIG_HOME/gfold.toml`
- `$XDG_CONFIG_HOME/gfold/config.toml`
- `$HOME/.config/gfold.toml`

`$XDG_CONFIG_HOME` se refiere a la variable de entorno literal `XDG_CONFIG_HOME`, pero por defecto usará la ruta específica del sistema operativo si no está establecida (consulta [`user_dirs`](https://github.com/uncenter/user_dirs) para más información).

Si se encuentra un archivo de configuración, `gfold` lo leerá y usará las opciones especificadas dentro.

Para crear un archivo de configuración, puedes usar el indicador `--dry-run` para imprimir TOML válido.  
Aquí hay un ejemplo de flujo de trabajo para crear un archivo de configuración en macOS, Linux y plataformas similares:

```shell
gfold -d classic -c never ~/ --dry-run > $HOME/.config/gfold.toml
```

Aquí están los contenidos del archivo de configuración resultante:

```toml
paths = ['/home/neloth']
display_mode = 'Classic'
color_mode = 'Never'
```

Supongamos que creaste un archivo de configuración, pero quieres ejecutar `gfold` con configuraciones completamente diferentes _y_ quieres asegurarte de no heredar accidentalmente opciones del archivo de configuración.
En ese caso, puedes ignorar tu archivo de configuración usando la opción `-i`.


```shell
gfold -i
```

Puede restaurar el archivo de configuración a sus valores predeterminados utilizando la misma bandera.

```shell
gfold -i > $HOME/.config/gfold.toml
```

Además, puedes ignorar el archivo de configuración existente, configurar opciones específicas y usar valores predeterminados para las opciones no especificadas, todo a la vez.
Aquí hay un ejemplo donde queremos usar el modo de visualización clásico y anular todas las demás configuraciones con sus valores predeterminados:

```shell
gfold -i -d classic > $HOME/.config/gfold.toml
```

Puedes hacer una copia de seguridad de un archivo de configuración y rastrear su historial con `git`.
En macOS, Linux y la mayoría de los sistemas, puedes enlazar el archivo a un repositorio `git`.

```shell
ln -s <path-to-repository>/gfold.toml $HOME/.config/gfold.toml
```
Ahora, puede actualizar el archivo de configuración dentro de su repositorio e incluir el enlace como parte de su flujo de trabajo de configuración del entorno.

## Instalación

[![Estado del empaquetado](https://repology.org/badge/vertical-allrepos/gfold.svg)](https://repology.org/project/gfold/versions)

### Homebrew (macOS y Linux)

Puede usar [Homebrew](https://brew.sh) para instalar `gfold` usando la [fórmula principal](https://formulae.brew.sh/formula/gfold).

Sin embargo, puede encontrarse con una colisión de nombres en macOS si [coreutils](https://formulae.brew.sh/formula/coreutils) está instalado vía `brew`.
Consulte la sección de [solución de problemas](#troubleshooting-and-known-issues) para una solución alternativa y más información.


```shell
brew install gfold
```

### Arch Linux

Puedes usar [pacman](https://wiki.archlinux.org/title/Pacman) para instalar `gfold` desde el [repositorio extra](https://archlinux.org/packages/extra/x86_64/gfold/).

```shell
pacman -S gfold
```

### Nix y NixOS

Puedes instalar `gfold` desde [nixpkgs](https://github.com/NixOS/nixpkgs/blob/master/pkgs/applications/version-management/gfold/default.nix):

```shell
nix-env --install gfold
```

Si estás utilizando [flakes](https://nixos.wiki/wiki/Flakes), puedes instalar usando el comando `nix` directamente.

```shell
nix profile install "nixpkgs#gfold"
```

### Cargo

Puedes usar [cargo](https://crates.io) para instalar el [crate](https://crates.io/crates/gfold) en casi cualquier plataforma.

```shell
cargo install gfold
```

Utilice la bandera `--locked` si desea que Cargo use `Cargo.lock`.

```shell
cargo install --locked gfold
```

Mantener la crate actualizada es fácil con [cargo-update](https://crates.io/crates/cargo-update).

```shell
cargo install cargo-update
cargo install-update -a
```
### Descargar un Binario

Si no desea usar uno de los métodos de instalación mencionados anteriormente y no quiere clonar el repositorio, puede descargar un binario desde la página de [releases](https://github.com/nickgerace/gfold/releases).
Para un ejemplo de cómo hacerlo, consulte la guía de [instalación manual](https://raw.githubusercontent.com/nickgerace/gfold/main/./docs/MANUAL_INSTALL.md).

### Compilar Desde el Código Fuente

Si desea un ejemplo de cómo compilar desde el código fuente, consulte la guía de [instalación manual](https://raw.githubusercontent.com/nickgerace/gfold/main/./docs/MANUAL_INSTALL.md).

### Obsoleto: Homebrew Tap (solo macOS)

El [tap ubicado en nickgerace/homebrew-nickgerace](https://github.com/nickgerace/homebrew-nickgerace/blob/main/Formula/gfold.rb) ha sido descontinuado.
Por favor, use el paquete principal de Homebrew mencionado anteriormente.

### ¿No está listado el Método de Instalación Preferido?

¡Por favor [abra un issue](https://github.com/nickgerace/gfold/issues/new)!

## Compatibilidad

`gfold` está diseñado para ejecutarse en _cualquier_ objetivo Rust 🦀 de nivel uno.
Por favor [abra un issue](https://github.com/nickgerace/gfold/issues) si su plataforma no es compatible.

## Resolución de Problemas y Problemas Conocidos

Si encuentra un comportamiento inesperado o un error y desea ver más detalles, ejecute con mayor nivel de verbosidad.


```shell
gfold -vvv
```

Si el problema persiste, por favor [informe un problema](https://github.com/nickgerace/gfold/issues).
Adjunte los registros relevantes de la ejecución con _partes sensibles redactadas_ para ayudar a resolver su problema.

### Colisión de Coreutils en macOS

Si `fold` de [GNU Coreutils](https://www.gnu.org/software/coreutils/) está instalado en macOS vía `brew`, se llamará `gfold`.
Puede evitar esta colisión con alias de shell, funciones de shell y/o cambios en el `PATH`.
Aquí hay un ejemplo con la `o` eliminada de `gfold`:

```shell
alias gfld=$HOME/.cargo/bin/gfold
```

## Comunidad

Para más información y agradecimientos a los usuarios y a la "comunidad" en general, por favor consulte el archivo **[AGRADECIMIENTOS DE LA COMUNIDAD](https://raw.githubusercontent.com/nickgerace/gfold/main/./docs/COMMUNITY_THANKS.md)**.

- [Paquetes para NixOS, Arch Linux y más](https://repology.org/project/gfold/versions)
- ["Cien binarios en Rust"](https://www.wezm.net/v2/posts/2020/100-rust-binaries/page2/), un artículo que presentó a `gfold`
- [nvim-gfold.lua](https://github.com/AckslD/nvim-gfold.lua), un plugin de `neovim` para `gfold` _([anuncio en Reddit](https://www.reddit.com/r/neovim/comments/t209wy/introducing_nvimgfoldlua/))_


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-04

---