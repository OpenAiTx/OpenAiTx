# Fudge
これは富士フイルムの公式カメラアプリのクロスプラットフォームのオープンソース代替品です。  

[ウェブサイト](https://fudge.danielc.dev/) | [Google Play](https://play.google.com/store/apps/details?id=dev.danielc.fujiapp) | [F-Droid](https://apt.izzysoft.de/fdroid/index/apk/dev.danielc.fujiapp)

<img src="https://raw.githubusercontent.com/petabyt/fudge/master/fastlane/metadata/android/en-US/images/phoneScreenshots/1.png" width='250'><img src="https://raw.githubusercontent.com/petabyt/fudge/master/fastlane/metadata/android/en-US/images/phoneScreenshots/2.png" width='250'><img src="https://raw.githubusercontent.com/petabyt/fudge/master/fastlane/metadata/android/en-US/images/phoneScreenshots/4.png" width='250'>

このアプリはまだ完成していないため、高い期待はしないでください。富士のPTP/IP実装には多くの独特な癖やバグがあり、すべてのカメラで動作する安定したクライアントを作るのは簡単ではありません。

## ロードマップ
- フロントエンドの書き換え（https://github.com/petabyt/fudge/issues/26 を参照）
- ライブビュー＆リモート撮影
- Bluetoothペアリングの実装

## コンパイル方法
```
git clone https://github.com/petabyt/fudge.git --depth 1 --recurse-submodules
```

### Androidのコンパイル
Android Studioでandroid/を開きます。

### デスクトップアプリのコンパイル
デスクトップユーティリティはまだ開発中です。
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