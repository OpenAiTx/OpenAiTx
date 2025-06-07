<p align="center"><img src="https://ohmyzsh.s3.amazonaws.com/omz-ansi-github.png" alt="Oh My Zsh"></p>

Oh My Zsh es un framework de código abierto, impulsado por la comunidad, para gestionar la configuración de tu [zsh](https://www.zsh.org/).

Suena aburrido. Intentémoslo de nuevo.

**Oh My Zsh no te convertirá en un desarrollador 10x... pero puede que te sientas como uno.**

Una vez instalado, tu terminal será la sensación del momento _o te devolvemos tu dinero_. Con cada pulsación en tu línea de comandos, aprovecharás cientos de potentes plugins y hermosos temas. Extraños se acercarán a ti en las cafeterías y te preguntarán: _"¡Eso es increíble! ¿Eres algún tipo de genio?"_

Finalmente, empezarás a recibir la atención que siempre sentiste merecer. ...o quizás uses el tiempo que ahorras para empezar a usar hilo dental más a menudo. 😬

Para saber más, visita [ohmyz.sh](https://ohmyz.sh), sigue a [@ohmyzsh](https://x.com/ohmyzsh) en X (anteriormente Twitter), y únete a nosotros en [Discord](https://discord.gg/ohmyzsh).

[![CI](https://github.com/ohmyzsh/ohmyzsh/workflows/CI/badge.svg)](https://github.com/ohmyzsh/ohmyzsh/actions?query=workflow%3ACI)
[![X (formerly Twitter) Follow](https://img.shields.io/twitter/follow/ohmyzsh?label=%40ohmyzsh&logo=x&style=flat)](https://twitter.com/intent/follow?screen_name=ohmyzsh)
[![Mastodon Follow](https://img.shields.io/mastodon/follow/111169632522566717?label=%40ohmyzsh&domain=https%3A%2F%2Fmstdn.social&logo=mastodon&style=flat)](https://mstdn.social/@ohmyzsh)
[![Servidor de Discord](https://img.shields.io/discord/642496866407284746)](https://discord.gg/ohmyzsh)
[![Gitpod listo](https://img.shields.io/badge/Gitpod-ready-blue?logo=gitpod)](https://gitpod.io/#https://github.com/ohmyzsh/ohmyzsh)

<details>
<summary>Tabla de Contenidos</summary>

- [Primeros Pasos](#getting-started)
  - [Compatibilidad con Sistemas Operativos](#operating-system-compatibility)
  - [Prerrequisitos](#prerequisites)
  - [Instalación Básica](#basic-installation)
    - [Inspección Manual](#manual-inspection)
- [Usando Oh My Zsh](#using-oh-my-zsh)
  - [Plugins](#plugins)
    - [Habilitar Plugins](#enabling-plugins)
    - [Uso de Plugins](#using-plugins)
  - [Temas](#themes)
    - [Seleccionar un Tema](#selecting-a-theme)
  - [Preguntas Frecuentes (FAQ)](#faq)
- [Temas Avanzados](#advanced-topics)
  - [Instalación Avanzada](#advanced-installation)
    - [Directorio Personalizado](#custom-directory)
    - [Instalación No Interactiva](#unattended-install)
    - [Instalación desde un Repositorio Bifurcado](#installing-from-a-forked-repository)
    - [Instalación Manual](#manual-installation)
  - [Problemas de Instalación](#installation-problems)
  - [Plugins y Temas Personalizados](#custom-plugins-and-themes)
  - [Habilitar GNU ls en sistemas macOS y freeBSD](#enable-gnu-ls-in-macos-and-freebsd-systems)
  - [Omitir Alias](#skip-aliases)
  - [Prompt git asíncrono](#async-git-prompt)
- [Actualizaciones](#getting-updates)
  - [Verbosidad de las Actualizaciones](#updates-verbosity)
  - [Actualizaciones Manuales](#manual-updates)
- [Desinstalar Oh My Zsh](#uninstalling-oh-my-zsh)
- [¿Cómo Contribuyo a Oh My Zsh?](#how-do-i-contribute-to-oh-my-zsh)
  - [No nos envíes temas](#do-not-send-us-themes)
- [Contribuidores](#contributors)
- [Síguenos](#follow-us)
- [Merchandising](#merchandise)
- [Licencia](#license)
- [Acerca de Planet Argon](#about-planet-argon)

</details>

## Primeros Pasos

### Compatibilidad con Sistemas Operativos

| S.O.           | Estado |
| :------------- | :----: |
| Android        |   ✅   |
| freeBSD        |   ✅   |
| LCARS          |   🛸   |
| Linux          |   ✅   |
| macOS          |   ✅   |
| OS/2 Warp      |   ❌   |
| Windows (WSL2) |   ✅   |

### Prerrequisitos

- [Zsh](https://www.zsh.org) debe estar instalado (v4.3.9 o más reciente está bien, pero preferimos 5.0.8 o superior). Si no está preinstalado (ejecuta `zsh --version` para confirmar), revisa las siguientes instrucciones en la wiki: [Installing ZSH](https://github.com/ohmyzsh/ohmyzsh/wiki/Installing-ZSH)
- `curl` o `wget` deben estar instalados
- `git` debe estar instalado (recomendado v2.4.11 o superior)

### Instalación Básica

Oh My Zsh se instala ejecutando uno de los siguientes comandos en tu terminal. Puedes instalarlo desde la línea de comandos usando `curl`, `wget` u otra herramienta similar.

| Método    | Comando                                                                                           |
| :-------- | :------------------------------------------------------------------------------------------------ |
| **curl**  | `sh -c "$(curl -fsSL https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh)"` |
| **wget**  | `sh -c "$(wget -O- https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh)"`   |
| **fetch** | `sh -c "$(fetch -o - https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh)"` |

Alternativamente, el instalador también está disponible fuera de GitHub. Puede que debas usar esta URL si estás en un país como China o India (para ciertos ISP) que bloquean `raw.githubusercontent.com`:

| Método    | Comando                                           |
| :-------- | :------------------------------------------------ |
| **curl**  | `sh -c "$(curl -fsSL https://install.ohmyz.sh/)"` |
| **wget**  | `sh -c "$(wget -O- https://install.ohmyz.sh/)"`   |
| **fetch** | `sh -c "$(fetch -o - https://install.ohmyz.sh/)"` |

_Ten en cuenta que cualquier `.zshrc` previo será renombrado a `.zshrc.pre-oh-my-zsh`. Después de la instalación, puedes mover la configuración que deseas preservar al nuevo `.zshrc`._

#### Inspección Manual

Es buena idea inspeccionar el script de instalación de proyectos que aún no conoces. Puedes hacerlo descargando primero el script de instalación, revisándolo para asegurarte de que todo esté bien, y luego ejecutándolo:

```sh
wget https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh
sh install.sh
```

Si la URL anterior no responde o falla, puede que tengas que sustituir la URL por `https://install.ohmyz.sh` para obtener el script.

## Usando Oh My Zsh

### Plugins

Oh My Zsh viene con un montón de plugins para que los aproveches. Puedes ver la carpeta [plugins](https://github.com/ohmyzsh/ohmyzsh/tree/master/plugins) y/o la [wiki](https://github.com/ohmyzsh/ohmyzsh/wiki/Plugins) para ver lo que está disponible actualmente.

#### Habilitar Plugins

Una vez que encuentres un plugin (o varios) que quieras usar con Oh My Zsh, tendrás que habilitarlos en el archivo `.zshrc`. Encontrarás el archivo zshrc en tu directorio `$HOME`. Ábrelo con tu editor de texto favorito y verás un lugar para listar todos los plugins que deseas cargar.

```sh
vi ~/.zshrc
```

Por ejemplo, puede verse así:

```sh
plugins=(
  git
  bundler
  dotenv
  macos
  rake
  rbenv
  ruby
)
```

_Ten en cuenta que los plugins se separan por espacios en blanco (espacios, tabulaciones, saltos de línea...). **No** uses comas entre ellos o fallará._

#### Uso de Plugins

Cada plugin incorporado incluye un **README** que lo documenta. Este README debe mostrar los alias (si el plugin agrega alguno) y funciones extra incluidas en ese plugin en particular.

### Temas

Lo admitimos. Al principio en el mundo de Oh My Zsh, nos entusiasmamos demasiado con los temas. Ahora tenemos más de ciento cincuenta temas incluidos. La mayoría tiene [capturas de pantalla](https://github.com/ohmyzsh/ohmyzsh/wiki/Themes) en la wiki (¡estamos trabajando en actualizarlas!). ¡Échales un vistazo!

#### Seleccionar un Tema

_El tema de Robby es el predeterminado. No es el más llamativo. No es el más simple. Es simplemente el adecuado (para él)._

Cuando encuentres un tema que quieras usar, tendrás que editar el archivo `~/.zshrc`. Verás una variable de entorno (en mayúsculas) que se parece a esto:

```sh
ZSH_THEME="robbyrussell"
```

Para usar un tema diferente, simplemente cambia el valor para que coincida con el nombre de tu tema deseado. Por ejemplo:

```sh
ZSH_THEME="agnoster" # (este es uno de los elegantes)
# ver https://github.com/ohmyzsh/ohmyzsh/wiki/Themes#agnoster
```

<!-- prettier-ignore-start -->
> [!NOTE]
> Muchas veces verás capturas de pantalla de un tema de zsh, lo probarás y verás que no se ve igual en tu terminal.
>
> Esto se debe a que muchos temas requieren instalar una [Fuente Powerline](https://github.com/powerline/fonts) o una [Nerd Font](https://github.com/ryanoasis/nerd-fonts) para renderizarse correctamente. Sin ellas, estos temas mostrarán símbolos extraños en el prompt. Consulta [las FAQ](https://github.com/ohmyzsh/ohmyzsh/wiki/FAQ#i-have-a-weird-character-in-my-prompt) para más información.
>
> Además, ten en cuenta que los temas solo controlan el aspecto de tu prompt, es decir, el texto que ves antes o después del cursor, donde escribirás tus comandos. Los temas no controlan cosas como los colores de la ventana del terminal (conocidos como _esquema de colores_) ni la fuente de tu terminal. Estos son ajustes que puedes cambiar en tu emulador de terminal. Para más información, consulta [qué es un tema zsh](https://github.com/ohmyzsh/ohmyzsh/wiki/FAQ#what-is-a-zsh-theme).
<!-- prettier-ignore-end -->

Abre una nueva ventana de terminal y tu prompt debería verse así:

![Tema Agnoster](https://cloud.githubusercontent.com/assets/2618447/6316862/70f58fb6-ba03-11e4-82c9-c083bf9a6574.png)

Si no encuentras un tema adecuado para tus necesidades, revisa la wiki para [ver más temas](https://github.com/ohmyzsh/ohmyzsh/wiki/External-themes).

Si te sientes atrevido, puedes dejar que la computadora seleccione uno al azar cada vez que abras una nueva terminal.

```sh
ZSH_THEME="random" # (...por favor que sea pie... por favor que sea algún pie...)
```

Y si quieres elegir un tema aleatorio de una lista de tus favoritos:

```sh
ZSH_THEME_RANDOM_CANDIDATES=(
  "robbyrussell"
  "agnoster"
)
```

Si solo sabes cuáles temas no te gustan, puedes agregarlos de manera similar a una lista de ignorados:

```sh
ZSH_THEME_RANDOM_IGNORED=(pygmalion tjkirch_mod)
```

### FAQ

Si tienes más preguntas o problemas, puedes encontrar una solución en nuestras [FAQ](https://github.com/ohmyzsh/ohmyzsh/wiki/FAQ).

## Temas Avanzados

Si eres de los que les gusta ensuciarse las manos, estas secciones pueden interesarte.

### Instalación Avanzada

Algunos usuarios pueden querer instalar Oh My Zsh manualmente, o cambiar la ruta por defecto u otros ajustes que acepta el instalador (estos ajustes también están documentados al inicio del script de instalación).

#### Directorio Personalizado

La ubicación predeterminada es `~/.oh-my-zsh` (oculta en tu directorio home, puedes acceder con `cd ~/.oh-my-zsh`).

Si deseas cambiar el directorio de instalación usando la variable de entorno `ZSH`, hazlo ejecutando `export ZSH=/tu/ruta` antes de instalar, o estableciéndolo antes de terminar la tubería de instalación así:

```sh
ZSH="$HOME/.dotfiles/oh-my-zsh" sh install.sh
```

#### Instalación No Interactiva

Si ejecutas el script de instalación de Oh My Zsh como parte de una instalación automatizada, puedes pasar la opción `--unattended` al script `install.sh`. Esto hará que no intente cambiar el shell por defecto, y tampoco ejecutará `zsh` al terminar la instalación.

```sh
sh -c "$(curl -fsSL https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh)" "" --unattended
```

Si estás en China, India u otro país que bloquee `raw.githubusercontent.com`, puede que tengas que sustituir la URL por `https://install.ohmyz.sh` para instalarlo.

#### Instalación desde un Repositorio Bifurcado

El script de instalación también acepta estas variables para permitir la instalación de un repositorio diferente:

- `REPO` (por defecto: `ohmyzsh/ohmyzsh`): toma la forma de `owner/repository`. Si defines esta variable, el instalador buscará el repositorio en `https://github.com/{owner}/{repository}`.

- `REMOTE` (por defecto: `https://github.com/${REPO}.git`): es la URL completa del clon del repositorio git. Puedes usar este ajuste si quieres instalar desde un fork que no está en GitHub (GitLab, Bitbucket...) o si quieres clonar por SSH en lugar de HTTPS (`git@github.com:user/project.git`).

  _NOTA: no es compatible con la variable `REPO`. Este ajuste tendrá prioridad._

- `BRANCH` (por defecto: `master`): puedes usar este ajuste si quieres cambiar la rama por defecto a la que se hace checkout al clonar el repositorio. Esto puede ser útil para probar un Pull Request, o si quieres usar una rama distinta a `master`.

Por ejemplo:

```sh
REPO=apjanke/oh-my-zsh BRANCH=edge sh install.sh
```

#### Instalación Manual

##### 1. Clona el Repositorio <!-- omit in toc -->

```sh
git clone https://github.com/ohmyzsh/ohmyzsh.git ~/.oh-my-zsh
```

##### 2. _Opcionalmente_, Haz una Copia de Seguridad de tu Archivo `~/.zshrc` <!-- omit in toc -->

```sh
cp ~/.zshrc ~/.zshrc.orig
```

##### 3. Crea un Nuevo Archivo de Configuración de Zsh <!-- omit in toc -->

Puedes crear un nuevo archivo de configuración de zsh copiando la plantilla que hemos incluido para ti.

```sh
cp ~/.oh-my-zsh/templates/zshrc.zsh-template ~/.zshrc
```

##### 4. Cambia tu Shell Predeterminado <!-- omit in toc -->

```sh
chsh -s $(which zsh)
```

Debes cerrar sesión y volver a entrar para ver este cambio.

##### 5. Inicializa tu Nueva Configuración de Zsh <!-- omit in toc -->

Cuando abras una nueva ventana de terminal, debería cargar zsh con la configuración de Oh My Zsh.

### Problemas de Instalación

Si tienes algún problema al instalar, aquí hay algunas soluciones comunes.

- _Podrías_ necesitar modificar tu `PATH` en `~/.zshrc` si no encuentras algunos comandos tras cambiar a `oh-my-zsh`.
- Si instalaste manualmente o cambiaste la ubicación de instalación, revisa la variable de entorno `ZSH` en `~/.zshrc`.

### Plugins y Temas Personalizados

Si quieres sobrescribir cualquier comportamiento por defecto, solo agrega un nuevo archivo (con extensión `.zsh`) en el directorio `custom/`.

Si tienes varias funciones que van bien juntas, puedes ponerlas en un archivo `XYZ.plugin.zsh` en el directorio `custom/plugins/` y luego habilitar este plugin.

Si quieres sobrescribir la funcionalidad de un plugin distribuido con Oh My Zsh, crea un plugin con el mismo nombre en el directorio `custom/plugins/` y será cargado en lugar del de `plugins/`.

### Habilitar GNU ls en sistemas macOS y freeBSD

<a name="enable-gnu-ls"></a>

El comportamiento por defecto en Oh My Zsh es usar BSD `ls` en sistemas macOS y FreeBSD. Si tienes instalado GNU `ls` (como comando `gls`), puedes elegir usarlo en su lugar. Para hacerlo, puedes usar la configuración basada en zstyle antes de cargar `oh-my-zsh.sh`:

```zsh
zstyle ':omz:lib:theme-and-appearance' gnu-ls yes
```

_Nota: esto no es compatible con `DISABLE_LS_COLORS=true`_

### Omitir Alias

<a name="remove-directories-aliases"></a>

Si quieres omitir los alias por defecto de Oh My Zsh (los definidos en los archivos `lib/*`) o alias de plugins, puedes usar las siguientes configuraciones en tu archivo `~/.zshrc`, **antes de cargar Oh My Zsh**. Ten en cuenta que hay varias formas de omitir alias, dependiendo de tus necesidades.

```sh
# Omitir todos los alias, en archivos lib y plugins habilitados
zstyle ':omz:*' aliases no

# Omitir todos los alias en archivos lib
zstyle ':omz:lib:*' aliases no
# Omitir solo los alias definidos en el archivo lib directories.zsh
zstyle ':omz:lib:directories' aliases no

# Omitir todos los alias de plugins
zstyle ':omz:plugins:*' aliases no
# Omitir solo los alias del plugin git
zstyle ':omz:plugins:git' aliases no
```

Puedes combinarlos considerando que los ámbitos más específicos tienen prioridad:

```sh
# Omitir todos los alias de plugins, excepto los del plugin git
zstyle ':omz:plugins:*' aliases no
zstyle ':omz:plugins:git' aliases yes
```

Una versión anterior de esta característica usaba el siguiente ajuste, que ha sido eliminado:

```sh
zstyle ':omz:directories' aliases no
```

En su lugar, ahora puedes usar:

```sh
zstyle ':omz:lib:directories' aliases no
```

#### Aviso <!-- omit in toc -->

> Esta función está actualmente en fase de pruebas y puede estar sujeta a cambios en el futuro. Tampoco es compatible actualmente con gestores de plugins como zpm o zinit, que no cargan el script de inicio (`oh-my-zsh.sh`) donde se implementa esta característica.

> Tampoco detecta actualmente los "alias" definidos como funciones. Ejemplo de esto son las funciones `gccd`, `ggf` o `ggl` del plugin git.

### Prompt git asíncrono

Las funciones de prompt asíncrono son una característica experimental (incluida el 3 de abril de 2024) que permite a Oh My Zsh renderizar información del prompt de manera asíncrona. Esto puede mejorar el rendimiento del prompt, pero puede que no funcione bien en algunas configuraciones. Esperamos que no sea un problema, pero si ves problemas con esta función, puedes desactivarla agregando lo siguiente en tu archivo .zshrc, antes de cargar Oh My Zsh:

```sh
zstyle ':omz:alpha:lib:git' async-prompt no
```

Si tu problema es que el prompt git dejó de aparecer, puedes forzarlo agregando la siguiente configuración antes de cargar `oh-my-zsh.sh`. Si aún no funciona, por favor abre un issue con tu caso.

```sh
zstyle ':omz:alpha:lib:git' async-prompt force
```

## Actualizaciones

Por defecto, se te pedirá buscar actualizaciones cada 2 semanas. Puedes elegir otros modos de actualización agregando una línea a tu archivo `~/.zshrc`, **antes de cargar Oh My Zsh**:

1. Actualización automática sin pedir confirmación:

   ```sh
   zstyle ':omz:update' mode auto
   ```

2. Solo ofrecer un recordatorio cada pocos días, si hay actualizaciones disponibles:

   ```sh
   zstyle ':omz:update' mode reminder
   ```

3. Para desactivar completamente las actualizaciones automáticas:

   ```sh
   zstyle ':omz:update' mode disabled
   ```

NOTA: puedes controlar cada cuánto tiempo Oh My Zsh busca actualizaciones con la siguiente configuración:

```sh
# Esto buscará actualizaciones cada 7 días
zstyle ':omz:update' frequency 7
# Esto buscará actualizaciones cada vez que abras el terminal (no recomendado)
zstyle ':omz:update' frequency 0
```

### Verbosidad de las Actualizaciones

También puedes limitar la verbosidad de las actualizaciones con las siguientes configuraciones:

```sh
zstyle ':omz:update' verbose default # prompt de actualización por defecto

zstyle ':omz:update' verbose minimal # solo unas pocas líneas

zstyle ':omz:update' verbose silent # solo errores
```

### Actualizaciones Manuales

Si quieres actualizar en cualquier momento (¿alguien acaba de publicar un nuevo plugin y no quieres esperar una semana?) solo tienes que ejecutar:

```sh
omz update
```

> [!NOTE]
> Si deseas automatizar este proceso en un script, debes llamar directamente al script `upgrade`, así:
>
> ```sh
> $ZSH/tools/upgrade.sh
> ```
>
> Consulta más opciones en las [FAQ: ¿Cómo actualizo Oh My Zsh?](https://github.com/ohmyzsh/ohmyzsh/wiki/FAQ#how-do-i-update-oh-my-zsh).
>
> **EL USO DE `omz update --unattended` HA SIDO ELIMINADO, YA QUE TIENE EFECTOS SECUNDARIOS**.

¡Magia! 🎉

## Desinstalar Oh My Zsh

Oh My Zsh no es para todos. Te extrañaremos, pero queremos que esta separación sea fácil.

Si quieres desinstalar `oh-my-zsh`, simplemente ejecuta `uninstall_oh_my_zsh` desde la línea de comandos. Se eliminará a sí mismo y restaurará tu configuración previa de `bash` o `zsh`.

## ¿Cómo Contribuyo a Oh My Zsh?

Antes de participar en nuestra encantadora comunidad, por favor lee el [código de conducta](CODE_OF_CONDUCT.md).

Estoy lejos de ser un experto en [Zsh](https://www.zsh.org/) y sospecho que hay muchas formas de mejorar – si tienes ideas para hacer la configuración más fácil de mantener (y más rápida), ¡no dudes en hacer un fork y enviar pull requests!

También necesitamos personas que prueben los pull requests. Así que echa un vistazo a [los issues abiertos](https://github.com/ohmyzsh/ohmyzsh/issues) y ayuda donde puedas.

Consulta [Contributing](CONTRIBUTING.md) para más detalles.

### No nos envíes temas

Tenemos (más que) suficientes temas por ahora. Por favor, añade tu tema a la página wiki de [temas externos](https://github.com/ohmyzsh/ohmyzsh/wiki/External-themes).

## Contribuidores

Oh My Zsh tiene una vibrante comunidad de usuarios felices y contribuyentes encantadores. Sin toda la ayuda y tiempo de nuestros contribuidores, no sería tan genial.

¡Muchas gracias!

<a href="https://github.com/ohmyzsh/ohmyzsh/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=ohmyzsh/ohmyzsh" width="100%"/>
</a>

## Síguenos

Estamos en redes sociales:

- [@ohmyzsh](https://x.com/ohmyzsh) en X (anteriormente Twitter). Deberías seguirnos.
- [Facebook](https://www.facebook.com/Oh-My-Zsh-296616263819290/) danos un toque.
- [Instagram](https://www.instagram.com/_ohmyzsh/) etiquétenos en tu publicación mostrando Oh My Zsh.
- [Discord](https://discord.gg/ohmyzsh) ¡para charlar con nosotros!

## Merchandising

Tenemos
[stickers, camisetas y tazas de café disponibles](https://shop.planetargon.com/collections/oh-my-zsh?utm_source=github)
para que muestres tu amor por Oh My Zsh. ¡De nuevo, serás la sensación del momento!

## Licencia

Oh My Zsh se publica bajo la [licencia MIT](LICENSE.txt).

## Acerca de Planet Argon

![Planet Argon](https://pa-github-assets.s3.amazonaws.com/PARGON_logo_digital_COL-small.jpg)

Oh My Zsh fue iniciado por el equipo de [Planet Argon](https://www.planetargon.com/?utm_source=github), una [agencia de desarrollo Ruby on Rails](https://www.planetargon.com/services/ruby-on-rails-development?utm_source=github). Consulta nuestros [otros proyectos open source](https://www.planetargon.com/open-source?utm_source=github).

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---