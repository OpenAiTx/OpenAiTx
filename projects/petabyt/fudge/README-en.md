# Fudge
This is a cross-platform open-source alternative to Fujifilm's official camera app.  

[Website](https://fudge.danielc.dev/) | [Google Play](https://play.google.com/store/apps/details?id=dev.danielc.fujiapp) | [F-Droid](https://apt.izzysoft.de/fdroid/index/apk/dev.danielc.fujiapp)

<img src="https://raw.githubusercontent.com/petabyt/fudge/master/fastlane/metadata/android/en-US/images/phoneScreenshots/1.png" width='250'><img src="https://raw.githubusercontent.com/petabyt/fudge/master/fastlane/metadata/android/en-US/images/phoneScreenshots/2.png" width='250'><img src="https://raw.githubusercontent.com/petabyt/fudge/master/fastlane/metadata/android/en-US/images/phoneScreenshots/4.png" width='250'>

This app isn't finished yet, so don't set high expectations. Fuji's implementation of PTP/IP has many different quirks and bugs, so it's not easy to create a stable client that works for all cameras.

## Roadmap
- Frontend rewrite (see https://github.com/petabyt/fudge/issues/26)
- Liveview & Remote capture
- Implement Bluetooth pairing

## Compiling
```
git clone https://github.com/petabyt/fudge.git --depth 1 --recurse-submodules
```
### Compiling Android
Open android/ in Android Studio.

### Compiling desktop app
Desktop utility is still a work in progress.

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