# Free Oberon programming environment

» [free.oberon.org](https://free.oberon.org/en)

Oberon is a general-purpose programming language–the direct descendant of Pascal and Modula-2. It is both simpler and much more powerful than Pascal and Modula.

Free Oberon is a cross-platform integrated development environment for the Oberon programming language, designed in the classic pseudo-graphic style–the famous blue screen of Pascal. Available for Windows, macOS and Linux.

Fob is a convenient console-based Oberon compiler.

![Free Oberon screenshot](http://free.oberon.org/images/screenshot.png)

![Game of Life animation in Oberon](http://free.oberon.org/images/life.gif)

*See English text below.*

# Free Oberon programming environment

Oberon is a general-purpose programming language, the direct descendant of Pascal and Modula-2. It is both simpler and much more powerful than Pascal and Modula.

Free Oberon is a cross-platform integrated development environment for the Oberon programming language, created in the classic pseudo-graphic style—the famous blue screen of Pascal. Available for Windows, Mac OS and Linux.

Fob is a console compiler for the Oberon language.

* Version 1.1.0-alpha.7
* Riga, January 11, 2023
* Website: [free.oberon.org](https://free.oberon.org)

# Installation

## Installation on Linux

1. Dependencies:

   Allegro (development packages), Git, GCC

   On Debian / Ubuntu / Linux Mint OS, etc.:
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

   On Fedora OS:

   ```
   sudo dnf install -y git gcc glibc-devel allegro5-devel allegro5-addon-image allegro5-addon-audio allegro5-addon-acodec allegro5-addon-dialog allegro5-devel allegro5-addon-image-devel allegro5-addon-audio-devel allegro5-addon-acodec-devel allegro5-addon-dialog-devel
   ```
   On Arch Linux:

   ```
   sudo pacman -Sy git gcc pkgconf glibc allegro
   ```

   On OpenSUSE:
   ```
   sudo zypper install -y git gcc glibc-devel liballegro5_2-devel liballegro_audio5_2-devel liballegro_image5_2-devel liballegro_primitives5_2-devel liballegro_dialog5_2-devel liballegro_acodec5_2-devel liballegro_acodec5_2-devel liballegro_font5_2-devel
   ```

2. Download Free Oberon as a tar.gz archive from the website
   [free.oberon.org](https://free.oberon.org/download)
   and unpack it in your home directory (or any other location).

   Option (latest build):

   On the website https://github.com/kekcleader/FreeOberon.git
   click the green "Code" button and "Download ZIP",
   unpack the archive in your home directory.
   Rename the `FreeOberon-main` directory to `FreeOberon`.

3. While in the unpacked directory, run `install.sh`.
  ```
  ./install.sh
  ```
4. (optional) Add the following line to the end of the `~/.bashrc` file:

  ```
  alias fo='cd ~/FreeOberon;./FreeOberon'
  ```
  This will allow you to run Free Oberon with the command `fo`.

  To run Free Oberon in a specific language, specify the language (en or ru):
  ```
  ./FreeOberon --lang ru
  ```
  или
  ```
  fo --lang ru
  ```

## Installation on Windows

Download the archive from the website [free.oberon.org](https://free.oberon.org), extract it to a path that contains no non-Latin characters, and run `FreeOberon.exe`.

Note. If you want to build your own Free Oberon version for Windows from source code, refer to Appendix A of the [Free Oberon documentation on free.oberon.org](http://free.oberon.org/files/FreeOberon_v1.1.0.pdf).


# Usage

Run Free Oberon and type the text of a program module in Oberon language (or open a sample program file, for example `Life.Mod`). Press `F9` to compile and run the program.
Source code files of your programs are saved in the `Programs` subdirectory, and compiled executable files are saved in the `bin` subdirectory. The script `Data/bin/compile.sh` (`Data\bin\compile.bat`) is used on Linux (Windows) during compilation. You can edit these scripts.

You can write programs consisting of multiple modules. Open the main module and press `F9`. Free Oberon will automatically compile and link them in the correct order.

If you compile a program whose main module file is not located directly in the `Programs` subdirectory, then the compiled executable file will be located next to it, not in the `_Build` subdirectory.

If an error is found in one of the program modules, the corresponding file will open, and the location and nature of the error will be indicated. To recompile, go back to the main module window and press `F9` again.

[Version History](https://raw.githubusercontent.com/kekcleader/FreeOberon/main/HISTORY.md)

______


*ENGLISH*

* Version 1.1.0-alpha.7
* Riga, January 11, 2023
* Website: [free.oberon.org](https://free.oberon.org/en)

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

   On OS Fedora:

   ```
   sudo dnf install -y git gcc glibc-devel allegro5-devel allegro5-addon-image allegro5-addon-audio allegro5-addon-acodec allegro5-addon-dialog allegro5-devel allegro5-addon-image-devel allegro5-addon-audio-devel allegro5-addon-acodec-devel allegro5-addon-dialog-devel argro5-addon-dialog-devel
   ```

   On Arch Linux:
   ```
   sudo pacman -Sy git gcc pkgconf glibc allegro
   ```

   On openSUSE:
   ```
   sudo zypper install -y git gcc glibc-devel liballegro5_2-devel liballegro_audio5_2-devel liballegro_image5_2-devel liballegro_primitives5_2-devel liballegro_dialog5_2-devel liballegro_acodec5_2-devel liballegro_acodec5_2-devel liballegro_font5_2-devel
   ```

2. Download Free Oberon in tar.gz format from
   [free.oberon.org](https://free.oberon.org/en/download)
   and unpack it inside the home directory (or in any other location).

   Option (edge build):

   Go to https://github.com/kekcleader/FreeOberon.git and
   click the green button labeled "Code" and then click "Download ZIP",
   unpack the archive inside your home directory.
   Rename the directory `FreeOberon-main` to `FreeOberon`.

3. Inside the unpacked directory, run `install.sh`.
  ```
  ./install.sh
  ```

4. (optional) Append the following line to the end of file `~/.bashrc`:
  ```
  alias fo='cd ~/FreeOberon;./FreeOberon'
  ```
  This will allow you to launch Free Oberon using the `fo` command.

  To run Free Oberon in a specific language, specify it (en or ru):
  ```
  ./FreeOberon --lang ru
  ```
  or
  ```
  fo --lang ru
  ```

## Install on Windows

Download Free Oberon in a ZIP archive (from [free.oberon.org](https://free.oberon.org/en)), extract it to a path on the disk that does not have any non-latin characters in it, and launch `FreeOberon.exe`.

Note. If you want to recompile Free Oberon under Windows from the source code, refer to Appendix A of the [Free Oberon documentation on free.oberon.org](https://free.oberon.org/files/FreeOberon_v1.1.0_en.pdf).


# Usage

Run Free Oberon and type the text of an Oberon module (or open a sample program such as `Life.Mod`) and press `F9` to compile and run the program.
The source code files of your programs are saved in the `Programs` subdirectory, and the compiled executables are saved in the `bin` subdirectory. The script `Data/bin/compile.sh` (`Data\bin\compile.bat`) is used on Linux (Windows) for compilation. You can edit these scripts.

You can write programs consisting of several modules. Open the main module and press `F9`. Free Oberon automatically compiles and links them in the correct order.

If you compile a program whose main module file is not directly in the `Programs` subdirectory, the compiled executable will be located next to it and not in the `_Build` subdirectory.

If an error occurs during the compilation of one of the modules, the corresponding file will be open and error position and message will be indicated. To recompile, go to the main module window again and press `F9`.

[Version history](https://raw.githubusercontent.com/kekcleader/FreeOberon/main/HISTORY.md)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-23

---