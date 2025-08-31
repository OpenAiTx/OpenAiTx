# Fudge
Ceci est une alternative open-source multiplateforme à l'application officielle de Fujifilm.  

[Site Web](https://fudge.danielc.dev/) | [Google Play](https://play.google.com/store/apps/details?id=dev.danielc.fujiapp) | [F-Droid](https://apt.izzysoft.de/fdroid/index/apk/dev.danielc.fujiapp)

<img src="https://raw.githubusercontent.com/petabyt/fudge/master/fastlane/metadata/android/en-US/images/phoneScreenshots/1.png" width='250'><img src="https://raw.githubusercontent.com/petabyt/fudge/master/fastlane/metadata/android/en-US/images/phoneScreenshots/2.png" width='250'><img src="https://raw.githubusercontent.com/petabyt/fudge/master/fastlane/metadata/android/en-US/images/phoneScreenshots/4.png" width='250'>

Cette application n'est pas encore terminée, ne vous attendez donc pas à des performances élevées. L'implémentation de PTP/IP par Fuji comporte de nombreuses particularités et bugs, il n'est donc pas facile de créer un client stable qui fonctionne avec tous les appareils photo.

## Feuille de route
- Réécriture du frontend (voir https://github.com/petabyt/fudge/issues/26)
- Liveview & prise de vue à distance
- Implémentation de l'appairage Bluetooth

## Compilation
```
git clone https://github.com/petabyt/fudge.git --depth 1 --recurse-submodules
```

### Compilation Android
Ouvrez android/ dans Android Studio.

### Compilation de l'application de bureau
L'utilitaire de bureau est encore en cours de développement.
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