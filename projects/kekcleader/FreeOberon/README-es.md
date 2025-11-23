# Entorno de programación Free Oberon

» [free.oberon.org](https://free.oberon.org/en)

Oberon es un lenguaje de programación de propósito general, descendiente directo de Pascal y Modula-2. Es a la vez más simple y mucho más poderoso que Pascal y Modula.

Free Oberon es un entorno de desarrollo integrado multiplataforma para el lenguaje de programación Oberon, diseñado en el estilo clásico pseudo-gráfico–la famosa pantalla azul de Pascal. Disponible para Windows, macOS y Linux.

Fob es un compilador de Oberon basado en consola y muy conveniente.

![Captura de pantalla de Free Oberon](http://free.oberon.org/images/screenshot.png)

![Animación del Juego de la Vida en Oberon](http://free.oberon.org/images/life.gif)

*Ver el texto en inglés abajo.*

# Среда программирования Free Oberon

Оберон — язык программирования общего назначения, прямой наследник Паскаля и Модулы-2. Он одновременно и проще, и намного мощнее, чем Паскаль и Модула.

Free Oberon представляет собой кроссплатформенную интегрированную среду разработки на языке программирования Оберон, выполненную в классическом псевдографическом стиле — знаменитого синего экрана Паскаля. Поставляется для Виндоуса, Мак-ОС и Линукса.

Fob — это консольный компилятор языка Оберон.

* Версия 1.1.0-alpha.7
* Рига, 11 января 2023 г.
* Сайт: [free.oberon.org](https://free.oberon.org)

# Установка

## Установка на Линукс

1. Зависимости:

   Allegro (пакеты разработки), Git, GCC

   На ОС Дебиан / Убунту / Линукс Минт и т. п.:
   ```
   sudo apt-get update
   sudo apt-get install -y git gcc libc-dev liballegro5-dev
   ```
   или:
   ```
   su
   apt-get update
   apt-get install -y git gcc libc-dev liballegro5-dev
   ```
   En el SO Fedora:


   ```
   sudo dnf install -y git gcc glibc-devel allegro5-devel allegro5-addon-image allegro5-addon-audio allegro5-addon-acodec allegro5-addon-dialog allegro5-devel allegro5-addon-image-devel allegro5-addon-audio-devel allegro5-addon-acodec-devel allegro5-addon-dialog-devel
   ```
   En Arch Linux:

   ```
   sudo pacman -Sy git gcc pkgconf glibc allegro
   ```
   En OpenSUSE:

   ```
   sudo zypper install -y git gcc glibc-devel liballegro5_2-devel liballegro_audio5_2-devel liballegro_image5_2-devel liballegro_primitives5_2-devel liballegro_dialog5_2-devel liballegro_acodec5_2-devel liballegro_acodec5_2-devel liballegro_font5_2-devel
   ```
2. Descargue Free Oberon en formato tar.gz desde el sitio
   [free.oberon.org](https://free.oberon.org/download)
   y descomprímalo en el directorio personal (o en cualquier otro lugar).

   Opción (la compilación más reciente):

   En el sitio https://github.com/kekcleader/FreeOberon.git
   haga clic en el botón verde «Code» y luego en «Download ZIP»,
   descomprima el archivo en el directorio personal.
   Cambie el nombre del directorio `FreeOberon-main` a `FreeOberon`.

3. Estando en el directorio descomprimido, ejecute `install.sh`.

  ```
  ./install.sh
  ```
4. (opcional) Añada al final del archivo `~/.bashrc` la línea:

  ```
  alias fo='cd ~/FreeOberon;./FreeOberon'
  ```
  Esto permitirá ejecutar Free Oberon con el comando `fo`.

  Para ejecutar Free Oberon en un idioma específico, indique el idioma (en o ru):
  ```
  ./FreeOberon --lang ru
  ```
  или
  ```
  fo --lang ru
  ```

## Instalación en Windows

Descargue el archivo desde el sitio [free.oberon.org](https://free.oberon.org), descomprímalo en una ruta que no contenga caracteres no latinos, y ejecute `FreeOberon.exe`.

Nota. Si desea compilar por sí mismo la versión de Free Oberon para Windows desde el código fuente, consulte el Apéndice A de la [documentación de Free Oberon en free.oberon.org](http://free.oberon.org/files/FreeOberon_v1.1.0.pdf).


# Uso

Inicie Free Oberon y escriba el texto del módulo del programa en el lenguaje Oberon (o abra un archivo con un ejemplo de programa, por ejemplo `Life.Mod`). Presione `F9` para compilar y ejecutar el programa.
Los archivos con el código fuente de sus programas se guardan en el subdirectorio `Programs`, y los archivos ejecutables compilados se guardan en el subdirectorio `bin`. El script `Data/bin/compile.sh` (`Data\bin\compile.bat`) se usa en Linux (Windows) durante la compilación. Puede editar estos scripts.

Se pueden escribir programas compuestos por varios módulos. Abra el módulo principal y presione `F9`. Free Oberon los compilará y enlazará automáticamente en el orden correcto.

Si compila un programa cuyo archivo del módulo principal no se encuentra directamente en el subdirectorio `Programs`, el archivo ejecutable compilado estará junto a él, y no en el subdirectorio `_Build`.

Si se encuentra un error en uno de los módulos del programa, se abrirá el archivo correspondiente, indicando el lugar y el tipo de error. Para recompilar, regrese a la ventana del módulo principal y presione `F9` nuevamente.

[Historial de versiones](https://raw.githubusercontent.com/kekcleader/FreeOberon/main/HISTORY.md)

______


*ENGLISH*

* Version 1.1.0-alpha.7
* Riga, 11 de enero de 2023
* Sitio web: [free.oberon.org](https://free.oberon.org/en)

# Install

## Install on Linux

1. Dependencies:

   Allegro (development packages), Git, GCC

   On OS Debian / Ubuntu / Linux Mint and so on:

   ```
   sudo apt-get update
   sudo apt-get install -y git gcc libc-dev liballegro5-dev
   ```
   or:
   ```
   su
   apt-get update
   apt-get install -y git gcc libc-dev liballegro5-dev
   ```
   En el sistema operativo Fedora:


   ```
   sudo dnf install -y git gcc glibc-devel allegro5-devel allegro5-addon-image allegro5-addon-audio allegro5-addon-acodec allegro5-addon-dialog allegro5-devel allegro5-addon-image-devel allegro5-addon-audio-devel allegro5-addon-acodec-devel allegro5-addon-dialog-devel argro5-addon-dialog-devel
   ```
   En Arch Linux:

   ```
   sudo pacman -Sy git gcc pkgconf glibc allegro
   ```

   En openSUSE:
   ```
   sudo zypper install -y git gcc glibc-devel liballegro5_2-devel liballegro_audio5_2-devel liballegro_image5_2-devel liballegro_primitives5_2-devel liballegro_dialog5_2-devel liballegro_acodec5_2-devel liballegro_acodec5_2-devel liballegro_font5_2-devel
   ```
2. Descargue Free Oberon en formato tar.gz desde
   [free.oberon.org](https://free.oberon.org/en/download)
   y descomprímalo dentro del directorio home (o en cualquier otro lugar).

   Opción (compilación edge):

   Vaya a https://github.com/kekcleader/FreeOberon.git y
   haga clic en el botón verde etiquetado como "Code" y luego en "Download ZIP",
   descomprima el archivo dentro de su directorio home.
   Cambie el nombre del directorio `FreeOberon-main` a `FreeOberon`.

3. Dentro del directorio descomprimido, ejecute `install.sh`.

  ```
  ./install.sh
  ```

4. (opcional) Agregue la siguiente línea al final del archivo `~/.bashrc`:
  ```
  alias fo='cd ~/FreeOberon;./FreeOberon'
  ```
  Esto le permitirá iniciar Free Oberon usando el comando `fo`.

  Para ejecutar Free Oberon en un idioma específico, especifíquelo (en o ru):
  ```
  ./FreeOberon --lang ru
  ```
  or
  ```
  fo --lang ru
  ```

## Instalar en Windows

Descargue Free Oberon en un archivo ZIP (desde [free.oberon.org](https://free.oberon.org/en)), extráigalo en una ruta del disco que no contenga caracteres no latinos, y ejecute `FreeOberon.exe`.

Nota. Si desea recompilar Free Oberon bajo Windows desde el código fuente, consulte el Apéndice A de la [documentación de Free Oberon en free.oberon.org](https://free.oberon.org/files/FreeOberon_v1.1.0_en.pdf).


# Uso

Ejecute Free Oberon y escriba el texto de un módulo Oberon (o abra un programa de ejemplo como `Life.Mod`) y presione `F9` para compilar y ejecutar el programa.
Los archivos de código fuente de sus programas se guardan en el subdirectorio `Programs`, y los ejecutables compilados se guardan en el subdirectorio `bin`. El script `Data/bin/compile.sh` (`Data\bin\compile.bat`) se usa en Linux (Windows) para la compilación. Puede editar estos scripts.

Puede escribir programas que consistan en varios módulos. Abra el módulo principal y presione `F9`. Free Oberon los compila y enlaza automáticamente en el orden correcto.

Si compila un programa cuyo archivo del módulo principal no está directamente en el subdirectorio `Programs`, el ejecutable compilado estará ubicado junto a él y no en el subdirectorio `_Build`.

Si ocurre un error durante la compilación de uno de los módulos, se abrirá el archivo correspondiente y se indicará la posición y el mensaje del error. Para recompilar, vuelva a la ventana del módulo principal y presione `F9`.

[Historial de versiones](https://raw.githubusercontent.com/kekcleader/FreeOberon/main/HISTORY.md)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-23

---