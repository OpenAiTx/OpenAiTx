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

Flutter to zestaw SDK firmy Google do tworzenia pięknych, szybkich doświadczeń użytkownika na urządzenia mobilne, webowe i desktopowe z jednej bazy kodu. Flutter współpracuje z istniejącym kodem, jest używany przez deweloperów i organizacje na całym świecie oraz jest darmowy i open source.

## Dokumentacja

* [Zainstaluj Fluttera](https://flutter.dev/get-started/)
* [Dokumentacja Fluttera](https://docs.flutter.dev/)
* [Wiki deweloperskie](./docs/README.md)
* [Współtworzenie Fluttera](https://github.com/flutter/flutter/blob/main/CONTRIBUTING.md)

Aby uzyskać informacje o nowych wydaniach, śledź listę mailingową
[flutter-announce@googlegroups.com](https://groups.google.com/forum/#!forum/flutter-announce).
Nasza dokumentacja śledzi również [zmiany niekompatybilne wstecznie](https://docs.flutter.dev/release/breaking-changes) pomiędzy wydaniami.

## Warunki korzystania z usługi

Narzędzie Flutter może sporadycznie pobierać zasoby z serwerów Google. Pobierając lub używając Flutter SDK, akceptujesz Warunki korzystania z usług Google: https://policies.google.com/terms

Na przykład, gdy Flutter jest instalowany z GitHub (w przeciwieństwie do zarchiwizowanej paczki), narzędzie Flutter przy pierwszym uruchomieniu pobiera Dart SDK z serwerów Google, ponieważ jest on używany do uruchamiania samego narzędzia `flutter`. To samo dzieje się podczas aktualizacji Fluttera (np. po wykonaniu polecenia `flutter upgrade`).

## O Flutterze

Uważamy, że Flutter pomoże Ci tworzyć piękne, szybkie aplikacje, przy wydajnym, elastycznym i otwartym modelu rozwoju, niezależnie czy celujesz w iOS, Androida, web, Windows, macOS, Linux czy osadzasz Fluttera jako zestaw narzędzi UI dla wybranej przez siebie platformy.

### Piękne doświadczenia użytkownika

Chcemy, aby projektanci mogli realizować swoją pełną wizję kreatywną bez konieczności jej ograniczania przez możliwości frameworka. [Warstwowa architektura] Fluttera daje Ci kontrolę nad każdym pikselem na ekranie, a potężne możliwości kompozycji pozwalają nakładać i animować grafikę, wideo, tekst i kontrolki bez ograniczeń. Flutter zawiera pełny [zestaw widgetów][widget catalog], które zapewniają perfekcyjne odwzorowanie wyglądu, niezależnie czy budujesz dla iOS ([Cupertino]), czy innych platform ([Material]), a także wsparcie dla personalizacji lub tworzenia zupełnie nowych komponentów wizualnych.

<p align="center"><img src="https://github.com/flutter/website/blob/main/src/content/assets/images/docs/homepage/reflectly-hero-600px.png?raw=true" alt="Reflectly hero image"></p>

### Szybkie rezultaty

Flutter jest szybki. Jego działanie opiera się na sprzętowo przyspieszanych bibliotekach grafiki 2D takich jak [Skia] (wykorzystywana również przez Chrome i Androida) oraz [Impeller]. Flutter został zaprojektowany tak, aby zapewniać płynną grafikę bez zacięć z natywną prędkością Twojego urządzenia.

Kod Fluttera bazuje na światowej klasy [platformie Dart], która umożliwia kompilację do 32- i 64-bitowego kodu maszynowego ARM dla iOS i Androida, JavaScriptu i WebAssembly dla weba, jak również Intel x64 i ARM dla komputerów stacjonarnych.

<p align="center"><img src="https://github.com/flutter/website/blob/main/src/content/assets/images/docs/homepage/dart-diagram-small.png?raw=true" alt="Dart diagram"></p>

### Produktywny rozwój

Flutter oferuje [stanowy hot reload][Hot reload], który pozwala na wprowadzanie zmian w kodzie i natychmiastowe oglądanie rezultatów bez restartowania aplikacji czy utraty jej stanu.

[![Hot reload animation][]][Hot reload]

### Elastyczny i otwarty model

Flutter działa z każdym narzędziem programistycznym (lub bez żadnego), a także zawiera wtyczki edytora zarówno dla [Visual Studio Code], jak i [IntelliJ / Android Studio]. Flutter oferuje [dziesiątki tysięcy paczek][Flutter packages], które przyspieszają Twój rozwój niezależnie od docelowej platformy. Dostęp do natywnego kodu jest łatwy dzięki wsparciu zarówno dla FFI ([na Androidzie][Android FFI], [na iOS][iOS FFI], [na macOS][macOS FFI], i [na Windows][Windows FFI]), jak i [API specyficznych dla platformy][platform channels].

Flutter jest w pełni otwartoźródłowym projektem i zapraszamy do współtworzenia. Informacje jak zacząć znajdziesz w naszym [przewodniku dla współtwórców](CONTRIBUTING.md).

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