# Fudge
这是一个跨平台的开源替代方案，取代富士官方相机应用。

[网站](https://fudge.danielc.dev/) | [Google Play](https://play.google.com/store/apps/details?id=dev.danielc.fujiapp) | [F-Droid](https://apt.izzysoft.de/fdroid/index/apk/dev.danielc.fujiapp)

<img src="https://raw.githubusercontent.com/petabyt/fudge/master/fastlane/metadata/android/en-US/images/phoneScreenshots/1.png" width='250'><img src="https://raw.githubusercontent.com/petabyt/fudge/master/fastlane/metadata/android/en-US/images/phoneScreenshots/2.png" width='250'><img src="https://raw.githubusercontent.com/petabyt/fudge/master/fastlane/metadata/android/en-US/images/phoneScreenshots/4.png" width='250'>

该应用尚未完成，因此不要抱有过高期望。富士的PTP/IP实现存在许多不同的怪癖和漏洞，因此很难创建一个适用于所有相机的稳定客户端。

## 路线图
- 前端重写（见 https://github.com/petabyt/fudge/issues/26）
- 实时取景和远程拍摄
- 实现蓝牙配对

## 编译
```
git clone https://github.com/petabyt/fudge.git --depth 1 --recurse-submodules
```

### 编译 Android
在 Android Studio 中打开 android/。

### 编译桌面应用
桌面工具仍在开发中。
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