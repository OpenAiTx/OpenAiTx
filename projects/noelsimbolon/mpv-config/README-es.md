# configuración de mpv

![logo de mpv](https://raw.githubusercontent.com/mpv-player/mpv.io/master/source/images/mpv-logo-128.png)

## Resumen

**mpv** es un reproductor multimedia gratuito (en el sentido de libertad y gratis), de código abierto y multiplataforma. Soporta
una gran variedad de formatos de archivos multimedia, códecs de audio y video, y tipos de subtítulos.

Este repositorio contiene mis configuraciones personales de mpv y scripts que uso y que son significativamente mejores que los mpv, VLC y MPC por defecto. Antes de instalar, por favor tómese su tiempo para leer todo este README ya que problemas comunes pueden solucionarse fácilmente simplemente leyendo cuidadosamente.


## Vista previa

[![preview.png](https://i.postimg.cc/8zNHHPHy/preview.png)](https://postimg.cc/VdZnsw2M)

## Instalación

### Windows

Aquí están los pasos para instalar mpv y usar mis archivos de configuración en Windows:
* Descargue la última versión de 64 bits de mpv para Windows de shinchiro desde [mpv.io/installation](https://mpv.io/installation/) o directamente desde [aquí](https://sourceforge.net/projects/mpv-player-windows/files/) y extráigalo donde guste. Esta es ahora su carpeta mpv
* Ejecute `mpv-install.bat`, que se encuentra en la carpeta `installer`, con privilegios de administrador haciendo clic derecho y seleccionando Ejecutar como administrador
* Descargue este repositorio como archivo ZIP (o puede clonarlo usando git)
* Cree una carpeta llamada `portable_config` (**esto es importante**), ubicada en el mismo directorio que `mpv.exe`
* Extraiga o copie el contenido de este repositorio que ha descargado a la carpeta `portable_config`
* Para que algunos scripts funcionen, necesita modificarlos un poco desde la versión de lanzamiento:
  * Para que el script `mpv-gif.lua` funcione, requiere [FFmpeg](https://ffmpeg.org/) con libass habilitado y accesible desde la terminal. Consulte las [instrucciones de instalación](https://github.com/Scheliux/mpv-gif-generator#installation) del repositorio fuente del script para más información.
  * **(Opcional)** Por defecto, el script `mpv-gif.lua` guarda los GIFs en `C:/Program Files/mpv/gifs`. Para modificar esto, abra `gif.conf`, que se encuentra en la carpeta `portable_config/script-opts`, con un editor de texto y especifique la `dir`, que es el directorio de salida para los GIFs, como desee. Por ejemplo `dir="C:/Users/USERNAME/Pictures/mpv-gifs"`.
* **(Opcional)** Cree su propia configuración de mpv. Puede hacerlo modificando mis archivos de configuración y/o creando los suyos desde cero o modificando configuraciones de otros. Consulte la sección de [enlaces útiles](#useful-links) para guías de configuración de mpv.
* Ya está todo listo.

### Linux

Aquí están los pasos para instalar mpv y usar mis archivos de configuración en Linux:

* Instale mpv y xclip (interfaz CLI del portapapeles) usando el gestor de paquetes que viene con su distribución Linux. xclip es necesario para que los scripts [copy-time.lua](https://github.com/noelsimbolon/mpv-config/blob/linux/scripts/copy-time.lua) y [seek-to.lua](https://github.com/noelsimbolon/mpv-config/blob/linux/scripts/seek-to.lua) funcionen correctamente. El nombre del paquete para mpv y xclip también puede variar dependiendo de su distribución Linux. Aquí, tomaré Arch Linux, que usa `pacman` como gestor de paquetes, como ejemplo
  
  ```
  sudo pacman -S mpv xclip
  ```
  Si, por ejemplo, usas Fedora Linux, que viene con `dnf` como su gestor de paquetes, puedes instalar mpv y xclip con el siguiente comando en su lugar.

  ```
  sudo dnf install mpv xclip
  ```
Si utilizas otras distribuciones de Linux, consulta la documentación del gestor de paquetes de tu distribución para saber cómo instalar paquetes.

* Descarga este repositorio como un archivo ZIP (o puedes clonarlo usando git) y extráelo/cópialo en tu directorio estándar de configuración de mpv que es `~/.config/mpv`
* Algunas cosas a destacar:
  * Para que el script `mpv-gif.lua` funcione, requiere [FFmpeg](https://ffmpeg.org/) con libass habilitado y accesible desde la terminal. Consulta las [instrucciones de instalación](https://github.com/Scheliux/mpv-gif-generator#installation) del repositorio fuente del script para más información.
  * **(Opcional)** Por defecto, el script `mpv-gif.lua` guarda los GIFs en `~/Videos/mpv-gifs`. Para modificar esto, abre `gif.conf`, que se encuentra en la carpeta `portable_config/script-opts`, con un editor de texto y especifica el `dir`, que es el directorio de salida para los GIFs, como prefieras. Por ejemplo `dir="~/Videos"`.
* **(Opcional)** Haz tu propia configuración de mpv. Puedes hacerlo modificando mis archivos de configuración y/o creando los tuyos desde cero o modificando configuraciones de otros. Consulta la sección de [enlaces útiles](#useful-links) para guías de configuración de mpv.
* Ya estás listo.

## Scripts

Scripts de fuentes externas:

* audio-visualizer.lua ([fuente](https://github.com/mfcc64/mpv-scripts#visualizerlua))\
  Varias visualizaciones de audio. Solo funciona si abres archivos de audio.
  
* autoload.lua ([fuente](https://github.com/mpv-player/mpv/blob/master/TOOLS/lua/autoload.lua))\
  Carga automáticamente las entradas de la lista de reproducción antes y después del archivo que se está reproduciendo, escaneando el directorio.

* copy-timestamp.lua ([fuente](https://github.com/linguisticmind/mpv-scripts/tree/master/copy-timestamp))\
  Copia el código de tiempo actual en formato HH:MM:SS.MS al portapapeles. Multiplataforma (Mac, Windows, Linux).

* cycle-commands.lua ([fuente](https://github.com/CogentRedTester/mpv-scripts#cycle-commands))\
  Cicla a través de una serie de comandos con una pulsación de tecla. Cada iteración del ciclo puede contener tantos comandos como se desee. Los detalles de sintaxis están al inicio del archivo.

* cycle-profile.lua ([fuente](https://github.com/CogentRedTester/mpv-scripts#cycle-profile))\
  Cicla a través de una lista de perfiles enviados mediante un mensaje de script y muestra la descripción del perfil en el OSD. Más detalles al inicio del archivo.

* modernz.lua ([fuente](https://github.com/Samillion/ModernZ))\
  Un reemplazo moderno para la interfaz OSC de MPV que mantiene la funcionalidad del OSC por defecto.

* mpv-gif.lua ([fuente](https://github.com/Scheliux/mpv-gif-generator))\
  Script para generar GIFs a partir de la reproducción de video. Requiere FFmpeg con libass habilitado. Actualmente la exportación de GIFs con subtítulos no funciona correctamente.

* playlistmanager.lua ([fuente](https://github.com/jonniek/mpv-playlistmanager))\
  Permite ver e interactuar con tu lista de reproducción de una forma intuitiva.

* seek-to.lua ([fuente](https://github.com/dexeonify/mpv-config/blob/main/scripts/seek-to.lua))\
  Salta a una marca de tiempo absoluta especificada mediante entrada de teclado o pegada desde el portapapeles.


* sponsorblock-minimal.lua ([fuente](https://codeberg.org/jouni/mpv_sponsorblock_minimal))\
  Omite segmentos de patrocinadores en videos de YouTube.

* thumbfast.lua ([fuente](https://github.com/po5/thumbfast))\
  Generador de miniaturas de alto rendimiento en tiempo real para mpv. **El script no muestra miniaturas por sí solo**, está diseñado para usarse junto con un script de interfaz que llame a thumbfast.

Los archivos de configuración para estos scripts se encuentran en la carpeta `script-opts`. También modifiqué algunas de las combinaciones de teclas predeterminadas de estos scripts. Para ver mis modificaciones, busca las combinaciones de teclas de los scripts en `input.conf`.

## Shaders

Los shaders incluidos en la carpeta `shaders`:

* ArtCNN_C4F32 ([fuente](https://github.com/Artoriuz/ArtCNN/blob/main/GLSL/ArtCNN_C4F32.glsl))\
  Usado para escalado de luminancia.

* nnedi3-nns128-win8x4 ([fuente](https://github.com/bjin/mpv-prescalers/tree/master))\
  Usado para escalado de luminancia.

Usa shaders según tu preferencia y capacidades del sistema. Para más información sobre shaders, lee los recursos en la sección [enlaces útiles](#useful-links).

## Enlaces Útiles

* [tutorial de mpv](https://thewiki.moe/tutorials/mpv/) por The Wiki
* [guía mpv.conf](https://iamscum.wordpress.com/guides/videoplayback-guide/mpv-conf/) por iamscum
* [Guía de Configuración de mpv para Ver Videos](https://kokomins.wordpress.com/2019/10/14/mpv-config-guide/) por Kokomins
* [Remuestreo en mpv](https://artoriuz.github.io/blog/mpv_upscaling.html) por João Vitor Chrisóstomo

## Enlaces Oficiales

* [página principal de mpv](https://mpv.io/)  
* [wiki de mpv](https://github.com/mpv-player/mpv/wiki)
* [FAQ de mpv](https://github.com/mpv-player/mpv/wiki/FAQ)
* [manual de mpv](https://mpv.io/manual/stable/)
* [Scripts de Usuario para mpv](https://github.com/mpv-player/mpv/wiki/User-Scripts)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-08

---