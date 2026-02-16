
<div align="right">
  <details>
    <summary >🌐 Taal</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=en">Engels</a>
        | <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=ja">Japans</a>
        | <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=ko">Koreaans</a>
        | <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=hi">Hindi</a>
        | <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=th">Thais</a>
        | <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=fr">Frans</a>
        | <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=de">Duits</a>
        | <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=es">Spaans</a>
        | <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=it">Italiaans</a>
        | <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=pt">Portugees</a>
        | <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=pl">Pools</a>
        | <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=ar">Arabisch</a>
        | <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=fa">Perzisch</a>
        | <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=tr">Turks</a>
        | <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=vi">Vietnamees</a>
        | <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=id">Bahasa Indonesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=as">অসমীয়া</
      </div>
    </div>
  </details>

</div>

# FlutterGenerator Installatie

1. Download en installeer het PY-bestand (fwGenerator.py) van [GitHub Releases](https://github.com/FlutterGenerator/FlutterGenerator/releases)
2. Download Termux en voer fwGenerator.py uit, kopieer het bestand en upload het naar je Github met de naam.
```
.github/workflows
```
# Flutter YML Oud 32bit 64bit
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
# Archief|Flutter Versiecode
```
https://docs.flutter.dev/release/archive
```
# Commando's op Termux
```
termux-setup-storage
apt update
apt upgrade
pkg install python -y
python fwGenerator.py /storage/emulated/0/MT2/apks/arm64-v8a/libflutter.so
```
# Tutorial Video
[![Afspelen op Youtube](https://img.youtube.com/vi/oT6yT8LP1yY/0.jpg)](https://www.youtube.com/watch?v=oT6yT8LP1yY)

# [Flutter-SO-Build](https://github.com/FlutterGenerator/Flutter-SO-Build)

# Info

**🚀 Dart Versie: 𒁍 2.7.0-dev.2.1 ➢ 3.11.0**

**🚀 Flutter Versie: 𒁍 v1.12.13+hotfix.5 ➢ 3.41.0**


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-16

---