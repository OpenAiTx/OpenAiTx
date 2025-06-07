<a href="https://flutter.dev/">
  <h1 align="center">
    <picture>
      <source media="(prefers-color-scheme: dark)" srcset="https://storage.googleapis.com/cms-storage-bucket/6e19fee6b47b36ca613f.png">
      <img alt="Flutter" src="https://storage.googleapis.com/cms-storage-bucket/c823e53b3a1a7b0d36a9.png">
    </picture>
  </h1>
</a>

[![Flutter CI 状态](https://flutter-dashboard.appspot.com/api/public/build-status-badge?repo=flutter)](https://flutter-dashboard.appspot.com/#/build?repo=flutter)
[![Discord 徽章][]][Discord instructions]
[![Twitter 账号][]][Twitter badge]
[![BlueSky 徽章][]][BlueSky handle]
[![codecov](https://codecov.io/gh/flutter/flutter/branch/master/graph/badge.svg?token=11yDrJU2M2)](https://codecov.io/gh/flutter/flutter)
[![CII 最佳实践](https://bestpractices.coreinfrastructure.org/projects/5631/badge)](https://bestpractices.coreinfrastructure.org/projects/5631)
[![SLSA 1](https://slsa.dev/images/gh-badge-level1.svg)](https://slsa.dev)

Flutter 是 Google 推出的 SDK，可通过单一代码库为移动端、Web 和桌面端打造美观、快速的用户体验。Flutter 能与现有代码协作，被全球开发者和组织广泛使用，且完全免费并开源。

## 文档

* [安装 Flutter](https://flutter.dev/get-started/)
* [Flutter 文档](https://docs.flutter.dev/)
* [开发维基](./docs/README.md)
* [为 Flutter 做贡献](https://github.com/flutter/flutter/blob/main/CONTRIBUTING.md)

获取新版本发布的公告，请关注 [flutter-announce@googlegroups.com](https://groups.google.com/forum/#!forum/flutter-announce) 邮件列表。我们的文档也会跟踪各版本之间的[重大变更](https://docs.flutter.dev/release/breaking-changes)。

## 服务条款

Flutter 工具可能偶尔会从 Google 服务器下载资源。下载或使用 Flutter SDK 即表示您同意 Google 服务条款：https://policies.google.com/terms

例如，从 GitHub 安装时（而非预打包归档），首次运行 Flutter 工具会立即从 Google 服务器下载 Dart SDK，因为 `flutter` 工具本身需要用到它。在升级 Flutter 时（如运行 `flutter upgrade` 命令）也会发生此操作。

## 关于 Flutter

我们相信，无论您面向 iOS、Android、Web、Windows、macOS、Linux，还是将其嵌入为自选平台的 UI 工具包，Flutter 都能帮助您创建美观、快速的应用，并提供高效、可扩展、开放的开发模式。

### 美观的用户体验

我们希望设计师能够充分发挥创意，无需因底层框架的限制而妥协。Flutter 的[分层架构]让您能够掌控屏幕上的每一个像素，其强大的合成功能可让您无障碍地叠加并动画化图形、视频、文本及控件。Flutter 包含完整的[组件库][widget catalog]，无论是为 iOS（[Cupertino]）还是其他平台（[Material]）开发，都能实现像素级的体验，并支持自定义或全新创建视觉组件。

<p align="center"><img src="https://github.com/flutter/website/blob/main/src/content/assets/images/docs/homepage/reflectly-hero-600px.png?raw=true" alt="Reflectly hero image"></p>

### 极速响应

Flutter 速度极快。它由硬件加速的 2D 图形库（如 [Skia]，该库同样支持 Chrome 和 Android）和 [Impeller] 驱动。我们架构设计让 Flutter 能以您设备的原生速度实现无卡顿、无延迟的图形渲染。

Flutter 代码基于世界级的 [Dart 平台]，可编译为 iOS 和 Android 的 32 位及 64 位 ARM 机器码、Web 的 JavaScript 与 WebAssembly，以及桌面设备的 Intel x64 与 ARM 架构。

<p align="center"><img src="https://github.com/flutter/website/blob/main/src/content/assets/images/docs/homepage/dart-diagram-small.png?raw=true" alt="Dart diagram"></p>

### 高效的开发体验

Flutter 提供[有状态热重载][Hot reload]，让您无需重启应用或丢失状态，即可即时看到代码变更的效果。

[![热重载动画][]][Hot reload]

### 可扩展与开放的模式

Flutter 可与任何开发工具协作（也可以不用开发工具），并为 [Visual Studio Code] 和 [IntelliJ / Android Studio] 提供了编辑器插件。Flutter 提供[数万个软件包][Flutter packages]，加快您的开发速度，无论目标平台为何。访问其他原生代码也非常简单，支持 FFI（[Android][Android FFI]、[iOS][iOS FFI]、[macOS][macOS FFI]、[Windows][Windows FFI]）以及[平台特定 API][platform channels]。

Flutter 是一个完全开源的项目，欢迎大家贡献。如何参与请参见我们的[贡献者指南](CONTRIBUTING.md)。

[flutter.dev]: https://flutter.dev
[Discord instructions]: ./docs/contributing/Chat.md
[Discord 徽章]: https://img.shields.io/discord/608014603317936148?logo=discord
[Twitter 账号]: https://img.shields.io/twitter/follow/flutterdev.svg?style=social&label=Follow
[Twitter badge]: https://twitter.com/intent/follow?screen_name=flutterdev
[BlueSky 徽章]: https://img.shields.io/badge/Bluesky-0285FF?logo=bluesky&logoColor=fff&label=Follow%20me%20on&color=0285FF
[BlueSky handle]: https://bsky.app/profile/flutter.dev
[分层架构]: https://docs.flutter.dev/resources/inside-flutter
[architectural overview]: https://docs.flutter.dev/resources/architectural-overview
[widget catalog]: https://flutter.dev/widgets/
[Cupertino]: https://docs.flutter.dev/development/ui/widgets/cupertino
[Material]: https://docs.flutter.dev/development/ui/widgets/material
[Skia]: https://skia.org/
[Dart 平台]: https://dart.dev/
[热重载动画]: https://github.com/flutter/website/blob/main/src/content/assets/images/docs/tools/android-studio/hot-reload.gif?raw=true
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