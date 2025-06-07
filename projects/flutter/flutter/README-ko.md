<a href="https://flutter.dev/">
  <h1 align="center">
    <picture>
      <source media="(prefers-color-scheme: dark)" srcset="https://storage.googleapis.com/cms-storage-bucket/6e19fee6b47b36ca613f.png">
      <img alt="Flutter" src="https://storage.googleapis.com/cms-storage-bucket/c823e53b3a1a7b0d36a9.png">
    </picture>
  </h1>
</a>

[![Flutter CI Status](https://flutter-dashboard.appspot.com/api/public/build-status-badge?repo=flutter)](https://flutter-dashboard.appspot.com/#/build?repo=flutter)
[![Discord badge][]][Discord instructions]
[![Twitter handle][]][Twitter badge]
[![BlueSky badge][]][BlueSky handle]
[![codecov](https://codecov.io/gh/flutter/flutter/branch/master/graph/badge.svg?token=11yDrJU2M2)](https://codecov.io/gh/flutter/flutter)
[![CII Best Practices](https://bestpractices.coreinfrastructure.org/projects/5631/badge)](https://bestpractices.coreinfrastructure.org/projects/5631)
[![SLSA 1](https://slsa.dev/images/gh-badge-level1.svg)](https://slsa.dev)

Flutter는 모바일, 웹, 데스크톱을 위한 아름답고 빠른 사용자 경험을 하나의 코드베이스로 제작할 수 있도록 도와주는 Google의 SDK입니다. Flutter는 기존 코드와 함께 작동하며, 전 세계 개발자와 조직에서 사용되고 있으며, 무료이자 오픈 소스입니다.

## 문서

* [Flutter 설치하기](https://flutter.dev/get-started/)
* [Flutter 문서](https://docs.flutter.dev/)
* [개발 위키](./docs/README.md)
* [Flutter 기여하기](https://github.com/flutter/flutter/blob/main/CONTRIBUTING.md)

새로운 릴리스에 대한 공지는 [flutter-announce@googlegroups.com](https://groups.google.com/forum/#!forum/flutter-announce) 메일링 리스트를 구독하세요. 또한, 우리의 문서는 릴리스별 [주요 변경사항](https://docs.flutter.dev/release/breaking-changes)을 추적합니다.

## 서비스 약관

Flutter 도구는 때때로 Google 서버에서 리소스를 다운로드할 수 있습니다. Flutter SDK를 다운로드하거나 사용하는 것은 Google 서비스 약관(https://policies.google.com/terms)에 동의하는 것으로 간주됩니다.

예를 들어, 사전 패키징된 아카이브가 아닌 GitHub에서 설치한 경우, Flutter 도구는 최초 실행 시 Google 서버에서 Dart SDK를 즉시 다운로드합니다. 이는 `flutter` 도구 자체를 실행하는 데 필요합니다. 또한 Flutter를 업그레이드할 때(예: `flutter upgrade` 명령 실행 시)도 동일하게 발생합니다.

## Flutter 소개

Flutter가 iOS, Android, 웹, Windows, macOS, Linux 또는 선택한 플랫폼의 UI 툴킷으로 임베드하든, 생산적이고 확장 가능하며 오픈된 개발 모델로 아름답고 빠른 앱을 제작하는 데 도움이 되리라 믿습니다.

### 아름다운 사용자 경험

우리는 디자이너가 기본 프레임워크의 한계로 인해 창의적인 비전을 희석시키지 않고도 전체 비전을 실현할 수 있기를 바랍니다. Flutter의 [계층화된 아키텍처]는 화면의 모든 픽셀을 제어할 수 있게 하며, 강력한 합성 기능으로 그래픽, 비디오, 텍스트, 컨트롤을 제한 없이 오버레이 및 애니메이션할 수 있습니다. Flutter는 iOS([Cupertino]) 또는 기타 플랫폼([Material])을 위한 픽셀 단위의 완벽한 경험을 제공하는 [위젯 세트][widget catalog]를 포함하고 있으며, 완전히 새로운 시각적 컴포넌트의 커스터마이징이나 생성도 지원합니다.

<p align="center"><img src="https://github.com/flutter/website/blob/main/src/content/assets/images/docs/homepage/reflectly-hero-600px.png?raw=true" alt="Reflectly hero image"></p>

### 빠른 결과

Flutter는 빠릅니다. [Skia](https://skia.org/) (Chrome과 Android의 기반) 및 [Impeller]와 같은 하드웨어 가속 2D 그래픽 라이브러리로 구동됩니다. Flutter는 기기의 네이티브 속도에서 끊김 없는 그래픽을 지원할 수 있도록 설계되었습니다.

Flutter 코드는 세계적인 수준의 [Dart 플랫폼]으로 구동되며, iOS 및 Android용 32비트 및 64비트 ARM 머신 코드, 웹용 JavaScript와 WebAssembly, 데스크톱 기기용 Intel x64 및 ARM으로 컴파일이 가능합니다.

<p align="center"><img src="https://github.com/flutter/website/blob/main/src/content/assets/images/docs/homepage/dart-diagram-small.png?raw=true" alt="Dart diagram"></p>

### 생산적인 개발

Flutter는 [상태 유지 핫 리로드][Hot reload]를 제공합니다. 코드를 수정하면 앱을 재시작하거나 상태를 잃지 않고도 즉시 결과를 볼 수 있습니다.

[![Hot reload animation][]][Hot reload]

### 확장 가능하고 오픈된 모델

Flutter는 어떤 개발 도구(혹은 도구 없이도)와도 함께 사용할 수 있으며, [Visual Studio Code]와 [IntelliJ / Android Studio]용 에디터 플러그인도 포함되어 있습니다. Flutter는 대상 플랫폼에 관계없이 개발을 가속화할 수 있는 [수만 개의 패키지][Flutter packages]를 제공합니다. 또한, 네이티브 코드 접근도 쉽습니다. [FFI 지원]( [Android][Android FFI], [iOS][iOS FFI], [macOS][macOS FFI], [Windows][Windows FFI])과 [플랫폼별 API][platform channels]를 모두 지원합니다.

Flutter는 완전히 오픈 소스 프로젝트이며, 여러분의 기여를 환영합니다. 시작하는 방법은 [기여자 가이드](CONTRIBUTING.md)에서 확인할 수 있습니다.

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