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

Flutter is Google's SDK voor het creëren van prachtige, snelle gebruikerservaringen voor mobiel, web en desktop vanuit één enkele codebase. Flutter werkt met bestaande code, wordt gebruikt door ontwikkelaars en organisaties over de hele wereld, en is gratis en open source.

## Documentatie

* [Flutter installeren](https://flutter.dev/get-started/)
* [Flutter documentatie](https://docs.flutter.dev/)
* [Development wiki](./docs/README.md)
* [Bijdragen aan Flutter](https://github.com/flutter/flutter/blob/main/CONTRIBUTING.md)

Voor aankondigingen over nieuwe releases, volg de
[flutter-announce@googlegroups.com](https://groups.google.com/forum/#!forum/flutter-announce)
mailinglijst. Onze documentatie volgt ook [brekende
wijzigingen](https://docs.flutter.dev/release/breaking-changes) tussen releases.

## Servicevoorwaarden

De Flutter-tool kan af en toe bronnen van Google-servers downloaden. Door de Flutter SDK te downloaden of te gebruiken, ga je akkoord met de Google Servicevoorwaarden: https://policies.google.com/terms

Wanneer je bijvoorbeeld vanuit GitHub installeert (in tegenstelling tot een vooraf verpakt archief), zal de Flutter-tool de Dart SDK van Google-servers downloaden zodra deze voor het eerst wordt uitgevoerd, omdat deze wordt gebruikt om de `flutter`-tool zelf uit te voeren. Dit gebeurt ook wanneer Flutter wordt bijgewerkt (bijvoorbeeld door het uitvoeren van het commando `flutter upgrade`).

## Over Flutter

Wij denken dat Flutter je zal helpen om prachtige, snelle apps te maken, met een productief, uitbreidbaar en open ontwikkelmodel, of je nu richt op iOS of Android, web, Windows, macOS, Linux, of het embedt als de UI-toolkit voor een platform naar keuze.

### Prachtige gebruikerservaringen

Wij willen ontwerpers in staat stellen hun volledige creatieve visie te realiseren zonder deze te moeten afzwakken vanwege beperkingen van het onderliggende framework. Flutter's [gelaagde architectuur] geeft je controle over elke pixel op het scherm en de krachtige compositie-mogelijkheden maken het mogelijk om graphics, video, tekst en besturingselementen zonder beperking te overlappen en te animeren. Flutter bevat een volledige [set van widgets][widget catalogus] die pixel-perfecte ervaringen leveren, of je nu bouwt voor iOS ([Cupertino]) of andere platforms ([Material]), samen met ondersteuning voor het aanpassen of volledig nieuwe visuele componenten maken.

<p align="center"><img src="https://github.com/flutter/website/blob/main/src/content/assets/images/docs/homepage/reflectly-hero-600px.png?raw=true" alt="Reflectly hero image"></p>

### Snelle resultaten

Flutter is snel. Het wordt aangedreven door hardwareversnelde 2D-grafische bibliotheken zoals [Skia] (die ook wordt gebruikt in Chrome en Android) en [Impeller]. We hebben Flutter zo ontworpen dat het probleemloze, vloeiende graphics ondersteunt op de native snelheid van je apparaat.

Flutter-code draait op het toonaangevende [Dart-platform], dat compilatie mogelijk maakt naar 32-bit en 64-bit ARM machinecode voor iOS en Android, JavaScript en WebAssembly voor het web, evenals Intel x64 en ARM voor desktopapparaten.

<p align="center"><img src="https://github.com/flutter/website/blob/main/src/content/assets/images/docs/homepage/dart-diagram-small.png?raw=true" alt="Dart diagram"></p>

### Productieve ontwikkeling

Flutter biedt [stateful hot reload][Hot reload], waarmee je wijzigingen in je code direct kunt zien zonder je app opnieuw te starten of de huidige status te verliezen.

[![Hot reload animatie][]][Hot reload]

### Uitbreidbaar en open model

Flutter werkt met elke ontwikkeltool (of zelfs zonder), en bevat ook editor-plug-ins voor zowel [Visual Studio Code] als [IntelliJ / Android Studio]. Flutter biedt [tien­duizenden pakketten][Flutter packages] om je ontwikkeling te versnellen, ongeacht je doelplatform. En toegang tot andere native code is eenvoudig, met ondersteuning voor zowel FFI ([op Android][Android FFI], [op iOS][iOS FFI], [op macOS][macOS FFI], en [op Windows][Windows FFI]) als [platformspecifieke API's][platform channels].

Flutter is een volledig open-source project en we verwelkomen bijdragen. Informatie over hoe je kunt beginnen vind je in onze [bijdragersgids](CONTRIBUTING.md).

[flutter.dev]: https://flutter.dev
[Discord instructions]: ./docs/contributing/Chat.md
[Discord badge]: https://img.shields.io/discord/608014603317936148?logo=discord
[Twitter handle]: https://img.shields.io/twitter/follow/flutterdev.svg?style=social&label=Follow
[Twitter badge]: https://twitter.com/intent/follow?screen_name=flutterdev
[BlueSky badge]: https://img.shields.io/badge/Bluesky-0285FF?logo=bluesky&logoColor=fff&label=Follow%20me%20on&color=0285FF
[BlueSky handle]: https://bsky.app/profile/flutter.dev
[gelaagde architectuur]: https://docs.flutter.dev/resources/inside-flutter
[architectural overview]: https://docs.flutter.dev/resources/architectural-overview
[widget catalogus]: https://flutter.dev/widgets/
[Cupertino]: https://docs.flutter.dev/development/ui/widgets/cupertino
[Material]: https://docs.flutter.dev/development/ui/widgets/material
[Skia]: https://skia.org/
[Dart-platform]: https://dart.dev/
[Hot reload animatie]: https://github.com/flutter/website/blob/main/src/content/assets/images/docs/tools/android-studio/hot-reload.gif?raw=true
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