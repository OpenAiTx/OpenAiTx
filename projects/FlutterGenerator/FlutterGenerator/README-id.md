
<div align="right">
  <details>
    <summary >🌐 Bahasa</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Instalasi FlutterGenerator

1. Unduh dan pasang PY (fwGenerator.py) dari [GitHub Releases](https://github.com/FlutterGenerator/FlutterGenerator/releases)
2. Unduh Termux dan jalankan fwGenerator.py lalu salin file tersebut dan unggah ke Github Anda dengan nama tersebut.
```
.github/workflows
```
# Flutter YML Lama 32bit 64bit
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
        uses: actions/upload-artifact@v6
        with:
          name: libflutter_so_arm64
          path: flutter_so/build/app/intermediates/merged_native_libs/release/out/lib/arm64-v8a/libflutter.so

      - name: Upload libflutter.so for armeabi-v7a
        uses: actions/upload-artifact@v6
        with:
          name: libflutter_so_armeabi_v7a
          path: flutter_so/build/app/intermediates/merged_native_libs/release/out/lib/armeabi-v7a/libflutter.so
```
# MT Manager
```
libflutter.so search (stable) and (beta) and (dev)
version code
```
# Arsip|Kode Versi Flutter
```
https://docs.flutter.dev/release/archive
```
# Perintah pada Termux
```
termux-setup-storage
apt update
apt upgrade
pkg install python -y
python fwGenerator.py /storage/emulated/0/MT2/apks/arm64-v8a/libflutter.so
```
# Video Tutorial
[![Putar di Youtube](https://img.youtube.com/vi/oT6yT8LP1yY/0.jpg)](https://www.youtube.com/watch?v=oT6yT8LP1yY)

# [Flutter-SO-Build](https://github.com/FlutterGenerator/Flutter-SO-Build)

# Info

**🚀 Versi Dart: 𒁍 2.7.0-dev.2.1 ➢ 3.10.7**

**🚀 Versi Flutter: 𒁍 v1.12.13+hotfix.5 ➢ 3.38.6**


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-30

---