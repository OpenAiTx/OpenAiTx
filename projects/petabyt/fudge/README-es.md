# Fudge
Esta es una alternativa multiplataforma de código abierto a la aplicación oficial de cámaras de Fujifilm.  

[Sitio web](https://fudge.danielc.dev/) | [Google Play](https://play.google.com/store/apps/details?id=dev.danielc.fujiapp) | [F-Droid](https://apt.izzysoft.de/fdroid/index/apk/dev.danielc.fujiapp)

<img src="https://raw.githubusercontent.com/petabyt/fudge/master/fastlane/metadata/android/en-US/images/phoneScreenshots/1.png" width='250'><img src="https://raw.githubusercontent.com/petabyt/fudge/master/fastlane/metadata/android/en-US/images/phoneScreenshots/2.png" width='250'><img src="https://raw.githubusercontent.com/petabyt/fudge/master/fastlane/metadata/android/en-US/images/phoneScreenshots/4.png" width='250'>

Esta aplicación aún no está terminada, así que no pongas expectativas altas. La implementación de PTP/IP de Fuji tiene muchas peculiaridades y errores diferentes, por lo que no es fácil crear un cliente estable que funcione para todas las cámaras.

## Hoja de ruta
- Reescritura del frontend (ver https://github.com/petabyt/fudge/issues/26)
- Visualización en vivo y captura remota
- Implementar emparejamiento Bluetooth

## Compilación
```
git clone https://github.com/petabyt/fudge.git --depth 1 --recurse-submodules
```

### Compilación de Android
Abre android/ en Android Studio.

### Compilación de la aplicación de escritorio
La utilidad de escritorio aún está en desarrollo.
```
# Ubuntu/Debian deps:
sudo apt install cmake ninja-build libgtk-3-dev libusb-1.0-0-dev libvulkan-dev libglfw3-dev
```
```
cd desktop
cmake -B build -G Ninja && cmake --build build
```
MinGW/osxcross is also supported for cross compiling.

# Credits
[libjpeg-turbo](https://github.com/libjpeg-turbo/libjpeg-turbo) (IJG License, Modified (3-clause) BSD License)  
This software is based in part on the work of the Independent JPEG Group.

[ezxml](https://ezxml.sourceforge.net/) (MIT License)

[lua 5.3](https://www.lua.org/license.html) (MIT License)

[com.jsibbold:zoomage](https://github.com/jsibbold/zoomage/blob/master/LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-31

---