# Marsdev

Cadena de herramientas multiplataforma para Sega Mega Drive / Super 32X / Sharp X68000.

English | [日本語](https://raw.githubusercontent.com/andwn/marsdev/master/README-ja.md)


## Compilar e Instalar

### 1.1 Dependencias

Instale los siguientes paquetes, según su sistema operativo:
  * Debian: `apt install build-essential texinfo wget`
  * RedHat: `yum install gcc gcc-c++ texinfo-tex wget`
  * Arch: `pacman -S base-devel texinfo wget`
  * Gentoo: `emerge sys-apps/texinfo net-misc/wget`
  * macOS: `xcode-select --install && brew install wget`


### 2. Cadena de herramientas GCC

Clone el repositorio:
 - `git clone https://github.com/andwn/marsdev --recurse-submodules`
 - `cd marsdev`

---
**NOTA**

Hay dos variables que controlan en qué directorio se construye e instala Marsdev:
 - `MARS_BUILD_DIR` = (REPOSITORY_ROOT)/mars
 - `MARS_INSTALL_DIR` = /opt/toolchains/mars

Si desea cambiar la ubicación de cualquiera de ellos, use un comando export como este:
 - `export MARS_INSTALL_DIR=/path/to/mars`

Si olvida `--recurse-submodules` entonces ejecute:
 - `git submodule init && git submodule update`

Además, se **recomienda encarecidamente** usar algo como `-j8`, reemplazando el 8 por
el número de núcleos de CPU que tenga. Me he encontrado con problemas extraños e inexplicables con `-j`
por sí solo, así que por favor especifique un número.

---

Tiene 2 opciones para construir GCC:
 - `make m68k-toolchain` - Sin Newlib
 - `make m68k-toolchain-newlib` - Con Newlib

Para 32X, también debe construirse la cadena de herramientas `sh`.
Las opciones son las mismas, reemplazando `m68k` en los comandos anteriores por `sh`.

Si desea una versión diferente de GCC, o construir lenguajes específicos:
 - `make m68k-toolchain-newlib GCC_VER=12.4.0 LANGS=c,c++`


### 3. (Opcional) SGDK

SGDK requiere Java, así que instálelo.
  * Debian: `apt install openjdk-11-jre`
  * RedHat: `yum install java-11-openjdk`
  * Arch: `pacman -S jdk11-openjdk`
  * Gentoo: `emerge dev-java/openjdk`
  * macOS: `brew install java`

---
**Nota para macOS**

OpenJDK necesita ser añadido al PATH.
 - Abra `~/.zshrc` (o `~/.bashrc` si todavía usa bash) y agregue la línea:
    - `export PATH="/usr/local/opt/openjdk/bin:$PATH"`
 - Reinicie la terminal o ejecute `source ~/.zshrc`

---

Construya SGDK:
 - `make sgdk`

Se puede especificar una versión específica de SGDK con `SGDK_VER=<git tag>`,
pero no puedo garantizar que versiones distintas a la predeterminada funcionen.
Las personas aventureras que quieran probar los últimos cambios también pueden especificar `SGDK_VER=master`.

### 4.1 (Opcional) Otras Herramientas

Los siguientes objetivos también están disponibles:
 - `make x68k-tools` - Compatibilidad con Sharp X68000
 - `make mdtools-sik` - Contiene mdtiler y algunas cosas de Echo (requiere libpng)
 - `make mdtools-flamewing` - Herramientas de compresión para datos en juegos Sonic (requiere boost)

 ### 4.2 (Experimental) LLVM

Se necesitan cmake, ninja y python3:
 - Debian: `apt install cmake ninja-build python3`
 - (TODO: Completar los demás)

LLVM con clang para M68k puede ser construido:
 - `make m68k-llvm`
 
Las pruebas aún no se han realizado y los proyectos de ejemplo/esqueleto aún necesitan ser creados.


### 5. Instalación

Simplemente ejecuta `sudo make install`. Recuerda la ruta del script de configuración del entorno,
y considera agregarla a tu ~/.bashrc (o ~/.zshrc).


## Ejemplos

El directorio `examples` contiene varios proyectos esqueleto/ejemplo para basar otros.
Para más información sobre cada uno lee [examples/README.md](https://raw.githubusercontent.com/andwn/marsdev/master/examples/README.md).

Debería ser tan fácil como un `make` para cualquiera de ellos.


## Preguntas Frecuentes Ocasionales

### Lo que sea, solo quiero usar SGDK en Linux

Instala:

 - `sudo apt install -y git build-essential texinfo wget openjdk-11-jre`
 - `git clone https://github.com/andwn/marsdev && cd marsdev`
 - `make sgdk -j8`
 - `sudo make install`

Compilar:

 - Toma el makefile de dentro de `examples/sgdk-skeleton` y colócalo en tu proyecto.
 - `source /opt/toolchains/mars/mars.sh`
 - `make`

### ¿Puedo compilar un proyecto Gendev con Marsdev o viceversa?

No fácilmente. Necesitarás modificar el Makefile para que funcione.
Empieza comparando tu Makefile actual con uno de los proyectos de ejemplo.
El documento de [Migración](https://raw.githubusercontent.com/andwn/marsdev/master/doc/migration.md) puede ser útil aquí.

### ¿Cómo puedo saber si un problema que tengo con SGDK es causado por Marsdev?

Debería ser posible compilar tu proyecto tal cual con una versión oficial de SGDK.
El Makefile incluido es solo un envoltorio para `make -f $GDK/makefile.gen`.

Si el problema persiste, es culpa de SGDK. Si el problema se resuelve, es culpa de Marsdev.

### ¿Cómo uso esto con mi IDE favorito?

Hay muchos de estos, y todos tienen diferentes lugares donde configurar las rutas.
En general, lo único que DEBERÍAS hacer es apuntar a los encabezados.

 * Encabezados GCC: `$(MARSDEV)/m68k-elf/lib/gcc/m68k-elf/$(GCC_VER)/include`
 * Encabezados SGDK: `$(MARSDEV)/m68k-elf/include`
 * Encabezados Newlib: `$(MARSDEV)/m68k-elf/m68k-elf/include`
 
Si tu IDE te permite configurar lo que hacen los botones de construir/ejecutar, simplemente haz que ejecute algo como esto.

 * Construir: `make MARSDEV=/ruta/a/mars`
 * Ejecutar: `/ruta/a/un/emulador out.bin`


### ¿Y qué pasa con Windows?

Recomiendo encarecidamente usar [WSL](https://learn.microsoft.com/en-us/windows/wsl/install)
y seguir las instrucciones para Debian.
También podrías intentar usar el Dockerfile, aunque ese fue aportado por otros
y yo no lo pruebo personalmente.
Solía usar [MSYS2](https://raw.githubusercontent.com/andwn/marsdev/master/doc/install_msys_legacy.md), pero no se puede exagerar lo lento y torpe que es.

Un apéndice, si solo estás aquí para usar SGDK y no usas Linux o macOS entonces
creo que Marsdev te será de poco beneficio de todos modos.


### No me gusta instalar en /opt. Quiero la forma antigua ~/mars

Eso es fácil.
1. `export MARS_BUILD_DIR=${HOME}/mars`
2. Realiza los pasos 1 - 4 normalmente
3. Omite el paso de instalación, en su lugar agrega a tu `~/.bashrc`:
```
export MARSDEV=${HOME}/mars
export GDK=${MARSDEV}/m68k-elf
```

### ¡Esto tarda tanto en compilar!

GCC es un programa grande, así que solo tenemos que tener paciencia.


# Cosas por hacer

 - [ ] Terminar de portar las partes importantes de libdos y lograr que Newlib funcione con él


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-23

---