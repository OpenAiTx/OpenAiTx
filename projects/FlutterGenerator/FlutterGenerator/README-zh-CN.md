# FlutterGenerator 安装

1. 从 [GitHub Releases](https://github.com/FlutterGenerator/FlutterGenerator/releases) 下载并安装 PY（fwGenerator.py）
2. 下载 Termux 并运行 fwGenerator.py，复制文件并以该名称上传到你的 GitHub。
```
.github/workflows
```
# Flutter YML 旧版 32位 64位
```
name: Flutter Build

on:
  push:
    branches:
      - main
  pull_request:
    branches:
      - main

jobs:
  build:
    runs-on: ubuntu-latest

    steps:
      - name: Checkout repository
        uses: actions/checkout@v6

      - name: Set up JDK
        uses: actions/setup-java@v5
        with:
          distribution: 'temurin'
          java-version: '17'

      - name: Set up Flutter
        uses: subosito/flutter-action@v2
        with:
          flutter-version: '{flutter_sdk_version}'

      - name: Print Flutter version
        run: flutter --version

      - name: Create and set up Flutter project
        run: |
          flutter create flutter_so
          cd flutter_so
          flutter pub get

      - name: Build APK for arm64 and armeabi-v7a
        run: |
          cd flutter_so
          flutter build apk --release --target-platform android-arm,android-arm64

      - name: Upload libflutter.so for arm64
        uses: actions/upload-artifact@v5
        with:
          name: libflutter_so_arm64
          path: flutter_so/build/app/intermediates/merged_native_libs/release/out/lib/arm64-v8a/libflutter.so

      - name: Upload libflutter.so for armeabi-v7a
        uses: actions/upload-artifact@v5
        with:
          name: libflutter_so_armeabi_v7a
          path: flutter_so/build/app/intermediates/merged_native_libs/release/out/lib/armeabi-v7a/libflutter.so
```
# MT 管理器
```
libflutter.so search (stable) and (beta) and (dev)
version code
```
# 存档|Flutter 版本代码
```
https://docs.flutter.dev/release/archive
```
# Termux上的命令
```
termux-setup-storage
apt update
apt upgrade
pkg install python -y
python fwGenerator.py /storage/emulated/0/MT2/apks/arm64-v8a/libflutter.so
```
# 教程视频
[![在YouTube上播放](https://img.youtube.com/vi/oT6yT8LP1yY/0.jpg)](https://www.youtube.com/watch?v=oT6yT8LP1yY)

# [Flutter-SO-Build](https://github.com/FlutterGenerator/Flutter-SO-Build)

# 信息

**🚀 Dart 版本：𒁍 2.7.0-dev.2.1 ➢ 3.10.3**

**🚀 Flutter 版本：𒁍 v1.12.13+hotfix.5 ➢ 3.38.4**


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-11

---