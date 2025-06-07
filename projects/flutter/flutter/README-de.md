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

Flutter ist das SDK von Google zur Entwicklung schöner, schneller Nutzererlebnisse für
Mobile, Web und Desktop aus einer einzigen Codebasis. Flutter funktioniert mit bestehendem
Code, wird von Entwicklern und Unternehmen weltweit genutzt und ist kostenlos sowie
Open Source.

## Dokumentation

* [Flutter installieren](https://flutter.dev/get-started/)
* [Flutter-Dokumentation](https://docs.flutter.dev/)
* [Entwicklungs-Wiki](./docs/README.md)
* [Beitrag zu Flutter](https://github.com/flutter/flutter/blob/main/CONTRIBUTING.md)

Für Ankündigungen zu neuen Releases abonniere die
[flutter-announce@googlegroups.com](https://groups.google.com/forum/#!forum/flutter-announce)
Mailingliste. Unsere Dokumentation listet auch [Breaking
Changes](https://docs.flutter.dev/release/breaking-changes) über alle Releases hinweg auf.

## Nutzungsbedingungen

Das Flutter-Tool lädt gelegentlich Ressourcen von Google-Servern herunter. Mit dem
Herunterladen oder der Nutzung des Flutter SDK stimmst du den Google-Nutzungsbedingungen zu:
https://policies.google.com/terms

Zum Beispiel lädt das Flutter-Tool beim ersten Start das Dart SDK von Google-Servern
herunter, wenn Flutter von GitHub installiert wurde (im Gegensatz zu einem vorgepackten
Archiv), da dieses zur Ausführung des `flutter`-Tools selbst benötigt wird.
Dies geschieht auch bei einem Flutter-Upgrade (z.B. durch Ausführen des Befehls `flutter
upgrade`).

## Über Flutter

Wir glauben, dass Flutter dir hilft, schöne, schnelle Apps mit einem produktiven,
erweiterbaren und offenen Entwicklungsmodell zu erstellen – egal, ob du für iOS oder Android,
Web, Windows, macOS, Linux entwickelst oder Flutter als UI-Toolkit für eine Plattform
deiner Wahl einbettest.

### Schöne Nutzererlebnisse

Wir möchten Designer:innen in die Lage versetzen, ihre gesamte kreative Vision umzusetzen,
ohne sie aufgrund von Einschränkungen des zugrundeliegenden Frameworks verwässern zu müssen.
Die [geschichtete Architektur] von Flutter gibt dir die Kontrolle über jeden Pixel auf dem
Bildschirm und die leistungsstarke Kompositions-Engine ermöglicht es, Grafiken, Videos,
Text und Steuerelemente ohne Einschränkungen zu überlagern und zu animieren. Flutter enthält
eine vollständige [Widget-Bibliothek][widget catalog], die pixelgenaue Erlebnisse bietet –
egal, ob du für iOS ([Cupertino]) oder andere Plattformen ([Material]) entwickelst, zusammen
mit der Unterstützung, visuelle Komponenten anzupassen oder komplett neue zu erstellen.

<p align="center"><img src="https://github.com/flutter/website/blob/main/src/content/assets/images/docs/homepage/reflectly-hero-600px.png?raw=true" alt="Reflectly hero image"></p>

### Schnelle Ergebnisse

Flutter ist schnell. Es wird von hardwarebeschleunigten 2D-Grafikbibliotheken wie [Skia]
(der auch Chrome und Android zugrunde liegt) und [Impeller] angetrieben. Wir haben Flutter so
entwickelt, dass es ruckelfreie, flüssige Grafiken mit nativer Geschwindigkeit deines Geräts
unterstützt.

Flutter-Code läuft auf der erstklassigen [Dart-Plattform], die die Kompilierung zu 32-Bit-
und 64-Bit-ARM-Maschinencode für iOS und Android, JavaScript und WebAssembly für das Web
sowie Intel x64 und ARM für Desktopgeräte ermöglicht.

<p align="center"><img src="https://github.com/flutter/website/blob/main/src/content/assets/images/docs/homepage/dart-diagram-small.png?raw=true" alt="Dart diagram"></p>

### Produktive Entwicklung

Flutter bietet [Stateful Hot Reload][Hot reload], sodass du Änderungen am Code vornehmen und
die Ergebnisse sofort sehen kannst, ohne deine App neu zu starten oder ihren Zustand zu
verlieren.

[![Hot reload animation][]][Hot reload]

### Erweiterbares und offenes Modell

Flutter funktioniert mit jedem Entwicklungstool (oder auch ganz ohne) und bietet außerdem
Editor-Plug-ins für sowohl [Visual Studio Code] als auch [IntelliJ / Android Studio].
Flutter stellt [Zehntausende Pakete][Flutter packages] bereit, um deine Entwicklung zu
beschleunigen – unabhängig von der Zielplattform. Der Zugriff auf nativen Code ist
ebenfalls einfach, mit Unterstützung für FFI ([unter Android][Android FFI], [unter iOS][iOS FFI],
[unter macOS][macOS FFI] und [unter Windows][Windows FFI]) sowie für
[plattform-spezifische APIs][platform channels].

Flutter ist ein vollständig Open-Source-Projekt und wir freuen uns über Beiträge.
Informationen zum Einstieg findest du in unserem
[Beitragsleitfaden](CONTRIBUTING.md).

[flutter.dev]: https://flutter.dev
[Discord instructions]: ./docs/contributing/Chat.md
[Discord badge]: https://img.shields.io/discord/608014603317936148?logo=discord
[Twitter handle]: https://img.shields.io/twitter/follow/flutterdev.svg?style=social&label=Follow
[Twitter badge]: https://twitter.com/intent/follow?screen_name=flutterdev
[BlueSky badge]: https://img.shields.io/badge/Bluesky-0285FF?logo=bluesky&logoColor=fff&label=Follow%20me%20on&color=0285FF
[BlueSky handle]: https://bsky.app/profile/flutter.dev
[geschichtete Architektur]: https://docs.flutter.dev/resources/inside-flutter
[architectural overview]: https://docs.flutter.dev/resources/architectural-overview
[widget catalog]: https://flutter.dev/widgets/
[Cupertino]: https://docs.flutter.dev/development/ui/widgets/cupertino
[Material]: https://docs.flutter.dev/development/ui/widgets/material
[Skia]: https://skia.org/
[Dart-Plattform]: https://dart.dev/
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