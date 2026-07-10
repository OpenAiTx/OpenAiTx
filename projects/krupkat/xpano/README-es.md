[![tests](https://github.com/krupkat/xpano/actions/workflows/test.yml/badge.svg)](https://github.com/krupkat/xpano/actions/workflows/test.yml)
[![clang-format](https://github.com/krupkat/xpano/actions/workflows/clang-format-check.yml/badge.svg)](https://github.com/krupkat/xpano/actions/workflows/clang-format-check.yml)
[![clang-tidy](https://github.com/krupkat/xpano/actions/workflows/clang-tidy-check.yml/badge.svg)](https://github.com/krupkat/xpano/actions/workflows/clang-tidy-check.yml)

# xpano

Xpano es una herramienta para la unión de panoramas con enfoque en la simplicidad y facilidad de uso, las principales características incluyen:

- Detección automática de grupos de imágenes que pueden unirse en panoramas
- Vista previa + zoom + desplazamiento de los panoramas calculados
- Modo de recorte, relleno automático de bordes, tipos de proyección seleccionables
- Ajustes de proyección: cabeceo, guiñada y alabeo
- Exportación de panoramas en resolución completa incluyendo metadatos exif


## Construido con

La aplicación utiliza la excelente biblioteca [OpenCV](https://opencv.org/) para la manipulación de imágenes y su módulo de [unión](https://docs.opencv.org/4.x/d1/d46/group__stitching.html) para calcular los panoramas.

Otras dependencias incluyen [imgui](https://github.com/ocornut/imgui), [SDL](https://github.com/libsdl-org/SDL), [spdlog](https://github.com/gabime/spdlog/), [Catch2](https://github.com/catchorg/Catch2), [nativefiledialog-extended](https://github.com/btzy/nativefiledialog-extended), [alpaca](https://github.com/p-ranav/alpaca), [thread-pool](https://github.com/bshoshany/thread-pool), [expected](https://github.com/TartanLlama/expected), [Exiv2](https://github.com/Exiv2/exiv2), [multiblend](https://horman.net/multiblend/), [SIMDe](https://github.com/simd-everywhere/simde) y las fuentes [Google Noto](https://fonts.google.com/noto).

## Demo

Mira la demo en [YouTube](https://youtu.be/MyiTC3i1hK0).

![Main Xpano gui](https://gist.githubusercontent.com/krupkat/55ca0f085c944fb1ea2a7dc2a779f141/raw/f90afd675b1c0430db06a46984cbe5309908ddc1/1.webp)

## Instalación

Instala directamente desde Flathub o la Microsoft Store:

<a href='https://flathub.org/apps/details/cz.krupkat.Xpano'><img height='70' alt='Download from Flathub' src='https://flathub.org/assets/badges/flathub-badge-en.png'/></a>&nbsp;&nbsp;<a href='https://apps.microsoft.com/store/detail/9PGQ5X33L0SC?launch=true&mode=full'><img height='70' alt='Download from the Microsoft Store' src='https://get.microsoft.com/images/en-US%20dark.svg'/></a>

Obtén paquetes adicionales:

- Ejecutables para Windows y MacOS desde [GitHub](https://github.com/krupkat/xpano/releases)
- Paquetes para Ubuntu desde mi [Launchpad PPA](https://launchpad.net/~krupkat/+archive/ubuntu/code)
- Paquetes Nix desde [nixpkgs](https://search.nixos.org/packages?channel=unstable&show=xpano)
- Archlinux AUR: [xpano-git](https://aur.archlinux.org/packages/xpano-git)

## Línea de comandos

Xpano tiene soporte básico de CLI, puedes ejecutarlo de forma totalmente automática en la línea de comandos, o lanzar la interfaz gráfica con la opción `--gui`.

```
Xpano [<input files>] [--output=<path>] [--gui] [--help] [--version]
```

## Desarrollo

El proyecto se puede compilar ejecutando un único script desde el directorio `misc/build`. Necesitarás al menos CMake 3.21, git y un compilador con soporte para C++20.

### NixOS

Ejecuta el script de compilación desde la raíz del repositorio:

```
nix-shell misc/build/nix/default.nix
./misc/build/build-nixos.sh
```

Posibles problemas al ejecutar - [solución de problemas](https://gist.github.com/krupkat/cd0adbd584e2bfe154accdb393076fc3).

### MacOS

Requisitos previos de la biblioteca: SDL2, spdlog, catch2

Instalar con brew: `brew install sdl2 spdlog catch2`

Instalar con macports: `sudo port install libsdl2 spdlog catch2` (para detalles: [#96](https://github.com/krupkat/xpano/pull/96#issuecomment-1575589249))

Ejecute el script de compilación desde la raíz del repositorio:

```
./misc/build/build-macos.sh
```

### Ubuntu 24.04

Prerequisitos de la biblioteca:

```
sudo apt install libgtk-3-dev libopencv-dev libsdl2-dev libspdlog-dev catch2
```

Ejecute el script de compilación desde la raíz del repositorio:

```
./misc/build/build-ubuntu-24.sh
```

### Ubuntu 22.04

Requisitos previos de la biblioteca:

```
sudo apt install libgtk-3-dev libopencv-dev libsdl2-dev libspdlog-dev
```

Ejecute el script de compilación desde la raíz del repositorio:

```
./misc/build/build-ubuntu-22.sh
```

### Windows

Abra el perfil "Developer PowerShell for VS 2022" en Windows Terminal y ejecute el script de compilación desde la raíz del repositorio:

```
./misc/build/build-windows-latest.ps1
```

## Contribuciones

Las contribuciones son más que bienvenidas, hay un par de ideas para mejoras en los [problemas abiertos](https://github.com/krupkat/xpano/issues) que podrías asumir; si comienzas a trabajar en uno de ellos, por favor añade un comentario allí.

Por favor revisa las [pautas de contribución](https://github.com/krupkat/xpano/blob/main/CONTRIBUTING.md) para más detalles sobre el formato y estilo de codificación.

## Licencia

Distribuido bajo la licencia *GPL-3.0-or-later*. Consulta el texto completo de la [licencia](https://github.com/krupkat/xpano/blob/main/LICENSE) para más información.

## Contacto

Tomas Krupka - [krupkat.cz](https://krupkat.cz)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-10

---