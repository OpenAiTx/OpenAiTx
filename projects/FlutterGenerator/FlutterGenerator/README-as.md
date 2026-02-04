
<div align="right">
  <details>
    <summary >🌐 ভাষা</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=en">ইংৰাজী</a>
        | <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=zh-CN">সৰল চীনী</a>
        | <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=zh-TW">জটিল চীনী</a>
        | <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=ja">জাপানী</a>
        | <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=ko">কোৰিয়ান</a>
        | <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=hi">হিন্দী</a>
        | <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=th">থাই</a>
        | <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=fr">ফ্ৰেঞ্চ</a>
        | <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=de">জার্মান</a>
        | <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=es">স্পেনিছ</a>
        | <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=it">ইটালিয়ান</a>
        | <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=ru">ৰাছিয়ান</a>
        | <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=pt">পৰ্তুগীজ</a>
        | <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=nl">ডাচ</a>
        | <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=pl">পোলিশ</a>
        | <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=ar">আৰবী</a>
        | <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=fa">ফাৰ্ছী</a>
        | <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=tr">তুৰ্কি</a>
        | <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=vi">ভিয়েটনামী</a>
        | <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=id">ইণ্ডোনেছিয়ান</a>
        | <a href="https://openaitx.github.io/view.html?user=FlutterGenerator&project=FlutterGenerator&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# FlutterGenerator স্থাপন

1. [GitHub Releases](https://github.com/FlutterGenerator/FlutterGenerator/releases) ৰ পৰা PY (fwGenerator.py) ডাউনলোড আৰু ইনষ্টল কৰক
2. Termux ডাউনলোড কৰক আৰু fwGenerator.py চলাও, তাৰপিছত ফাইলটো কপি কৰি আপোনাৰ Gihab ত নামসহ আপল'ড কৰক।
```
.github/workflows
```
# ফ্লাটাৰ YML পুৰণি ৩২বিট ৬৪বিট
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
# এম.টি. মেনেজাৰ
```
libflutter.so search (stable) and (beta) and (dev)
version code
```
# আৰ্হাইভ|Flutter সংস্কৰণ ক'ড
```
https://docs.flutter.dev/release/archive
```
# টার্মাক্সত আদেশসমূহ
```
termux-setup-storage
apt update
apt upgrade
pkg install python -y
python fwGenerator.py /storage/emulated/0/MT2/apks/arm64-v8a/libflutter.so
```
# টিউটোৰিয়েল ভিডিঅ'
[![ইউটিউবত চলাও](https://img.youtube.com/vi/oT6yT8LP1yY/0.jpg)](https://www.youtube.com/watch?v=oT6yT8LP1yY)

# [Flutter-SO-Build](https://github.com/FlutterGenerator/Flutter-SO-Build)

# তথ্য

**🚀 Dart সংস্কৰণ: 𒁍 2.7.0-dev.2.1 ➢ 3.10.8**

**🚀 Flutter সংস্কৰণ: 𒁍 v1.12.13+hotfix.5 ➢ 3.38.9**


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-04

---