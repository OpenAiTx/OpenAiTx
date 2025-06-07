<a href="https://flutter.dev/">
  <h1 align="center">
    <picture>
      <source media="(prefers-color-scheme: dark)" srcset="https://storage.googleapis.com/cms-storage-bucket/6e19fee6b47b36ca613f.png">
      <img alt="Flutter" src="https://storage.googleapis.com/cms-storage-bucket/c823e53b3a1a7b0d36a9.png">
    </picture>
  </h1>
</a>

[![Flutter CI 狀態](https://flutter-dashboard.appspot.com/api/public/build-status-badge?repo=flutter)](https://flutter-dashboard.appspot.com/#/build?repo=flutter)
[![Discord badge][]][Discord instructions]
[![Twitter handle][]][Twitter badge]
[![BlueSky badge][]][BlueSky handle]
[![codecov](https://codecov.io/gh/flutter/flutter/branch/master/graph/badge.svg?token=11yDrJU2M2)](https://codecov.io/gh/flutter/flutter)
[![CII Best Practices](https://bestpractices.coreinfrastructure.org/projects/5631/badge)](https://bestpractices.coreinfrastructure.org/projects/5631)
[![SLSA 1](https://slsa.dev/images/gh-badge-level1.svg)](https://slsa.dev)

Flutter 是 Google 推出的 SDK，可用於從單一代碼庫打造美觀且快速的使用者體驗，涵蓋行動裝置、網頁與桌面平台。Flutter 可與現有代碼結合，廣泛被全球開發者與組織採用，且完全免費與開源。

## 文件

* [安裝 Flutter](https://flutter.dev/get-started/)
* [Flutter 文件](https://docs.flutter.dev/)
* [開發 Wiki](./docs/README.md)
* [貢獻 Flutter](https://github.com/flutter/flutter/blob/main/CONTRIBUTING.md)

若需最新版本發布通知，請訂閱
[flutter-announce@googlegroups.com](https://groups.google.com/forum/#!forum/flutter-announce)
郵件清單。我們的文件也會追蹤[版本間的破壞性變更](https://docs.flutter.dev/release/breaking-changes)。

## 服務條款

Flutter 工具可能會不定期從 Google 伺服器下載資源。下載或使用 Flutter SDK 即表示您同意 Google 服務條款：
https://policies.google.com/terms

例如，若您從 GitHub 安裝（而非從預先封裝的壓縮檔安裝），Flutter 工具在首次執行時會立即從 Google 伺服器下載 Dart SDK，因為它用於執行 `flutter` 工具本身。升級 Flutter（例如執行 `flutter upgrade` 指令）時也會發生此情況。

## 關於 Flutter

我們認為 Flutter 能幫助你打造美觀、快速的應用程式，無論目標平台是 iOS、Android、網頁、Windows、macOS、Linux，或是作為你選擇平台的 UI 工具組。它擁有高生產力、可擴展且開放的開發模式。

### 美觀的使用者體驗

我們希望設計師能夠完整實現他們的創意，不必因底層框架的限制而妥協。Flutter 的[分層架構][layered architecture]讓你能掌控螢幕上的每一個像素，強大的合成能力讓你可以不受限制地疊加與動畫化圖形、影片、文字和控制元件。Flutter 提供完整的[元件集][widget catalog]，可實現像素級精準的體驗，不論你是為 iOS（[Cupertino]）還是其他平台（[Material]）開發，也支援自訂或全新視覺元件的建立。

<p align="center"><img src="https://github.com/flutter/website/blob/main/src/content/assets/images/docs/homepage/reflectly-hero-600px.png?raw=true" alt="Reflectly hero image"></p>

### 快速的效能

Flutter 速度極快。它由硬體加速的 2D 圖形庫如 [Skia]（Chrome 與 Android 的基礎）和 [Impeller] 提供動力。我們設計 Flutter 以支援裝置原生速度下無延遲、不卡頓的圖形顯示。

Flutter 程式碼由世界級的 [Dart 平台][Dart platform]驅動，可編譯為 iOS 與 Android 的 32 位元與 64 位元 ARM 機器碼、網頁用的 JavaScript 與 WebAssembly，以及桌面裝置用的 Intel x64 和 ARM。

<p align="center"><img src="https://github.com/flutter/website/blob/main/src/content/assets/images/docs/homepage/dart-diagram-small.png?raw=true" alt="Dart diagram"></p>

### 高生產力的開發

Flutter 提供[有狀態熱重載][Hot reload]，讓你修改代碼後能立即看到效果，無需重啟應用或丟失狀態。

[![Hot reload animation][]][Hot reload]

### 可擴展與開放的模式

Flutter 可與任何開發工具（甚至完全不用工具）配合，也提供 [Visual Studio Code] 與 [IntelliJ / Android Studio] 的編輯器外掛。Flutter 擁有[數萬個套件][Flutter packages]，無論你的目標平台為何都能加速開發。調用其他原生代碼也很容易，支援 FFI（[Android][Android FFI]、[iOS][iOS FFI]、[macOS][macOS FFI]、[Windows][Windows FFI]）以及[平台特定 API][platform channels]。

Flutter 是完全開源的專案，歡迎社群貢獻。如何開始貢獻，請參見我們的
[貢獻者指南](CONTRIBUTING.md)。

[flutter.dev]: https://flutter.dev
[Discord instructions]: ./docs/contributing/Chat.md
[Discord badge]: https://img.shields.io/discord/608014603317936148?logo=discord
[Twitter handle]: https://img.shields.io/twitter/follow/flutterdev.svg?style=social&label=Follow
[Twitter badge]: https://twitter.com/intent/follow?screen_name=flutterdev
[BlueSky badge]: https://img.shields.io/badge/Bluesky-0285FF?logo=bluesky&logoColor=fff&label=Follow%20me%20on&color=0285FF
[BlueSky handle]: https://bsky.app/profile/flutter.dev
[layered architecture]: https://docs.flutter.dev/resources/inside-flutter
[architectural overview]: https://docs.flutter.dev/resources/architectural-overview
[widget catalog]: https://flutter.dev/widgets/
[Cupertino]: https://docs.flutter.dev/development/ui/widgets/cupertino
[Material]: https://docs.flutter.dev/development/ui/widgets/material
[Skia]: https://skia.org/
[Dart platform]: https://dart.dev/
[Hot reload animation]: https://github.com/flutter/website/blob/main/src/content/assets/images/docs/tools/android-studio/hot-reload.gif?raw=true
[Hot reload]: https://docs.flutter.dev/development/tools/hot-reload
[Visual Studio Code]: https://marketplace.visualstudio.com/items?itemName=Dart-Code.flutter
[IntelliJ / Android Studio]: https://plugins.jetbrains.com/plugin/9212-flutter
[Flutter packages]: https://pub.dev/flutter
[Android FFI]: https://docs.flutter.dev/development/platform-integration/android/c-interop
[iOS FFI]: https://docs.flutter.dev/development/platform-integration/ios/c-interop
[macOS FFI]: https://docs.flutter.dev/development/platform-integration/macos/c-interop
[Windows FFI]: https://docs.flutter.dev/development/platform-integration/windows/building#integrating-with-windows
[platform channels]: https://docs.flutter.dev/development/platform-integration/platform-channels
[interop example]: https://github.com/flutter/flutter/tree/main/examples/platform_channel
[Impeller]: https://docs.flutter.dev/perf/impeller


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---