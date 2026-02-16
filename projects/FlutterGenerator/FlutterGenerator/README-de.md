
<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=en">Englisch</a>
        | <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=ja">Japanisch</a>
        | <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=ko">Koreanisch</a>
        | <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=hi">Hindi</a>
        | <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=th">Thailändisch</a>
        | <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=fr">Französisch</a>
        | <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=es">Spanisch</a>
        | <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=it">Italienisch</a>
        | <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=pt">Portugiesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=nl">Niederländisch</a>
        | <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=pl">Polnisch</a>
        | <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=ar">Arabisch</a>
        | <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=fa">Persisch</a>
        | <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=tr">Türkisch</a>
        | <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=vi">Vietnamesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=as">অসমীয়া</
      </div>
    </div>
  </details>

</div>

# FlutterGenerator Installation

1. Laden Sie die PY (fwGenerator.py) von den [GitHub Releases](https://github.com/FlutterGenerator/FlutterGenerator/releases) herunter und installieren Sie sie
2. Laden Sie Termux herunter, führen Sie fwGenerator.py aus, kopieren Sie die Datei und laden Sie sie mit dem Namen in Ihr Github hoch.
```
.github/workflows
```
# Flutter YML Alt 32bit 64bit
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
# Archiv|Flutter Versionscode
```
https://docs.flutter.dev/release/archive
```
# Befehle auf Termux
```
termux-setup-storage
apt update
apt upgrade
pkg install python -y
python fwGenerator.py /storage/emulated/0/MT2/apks/arm64-v8a/libflutter.so
```
# Anleitungsvideo
[![Auf Youtube abspielen](https://img.youtube.com/vi/oT6yT8LP1yY/0.jpg)](https://www.youtube.com/watch?v=oT6yT8LP1yY)

# [Flutter-SO-Build](https://github.com/FlutterGenerator/Flutter-SO-Build)

# Info

**🚀 Dart-Version: 𒁍 2.7.0-dev.2.1 ➢ 3.11.0**

**🚀 Flutter-Version: 𒁍 v1.12.13+hotfix.5 ➢ 3.41.0**


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-16

---