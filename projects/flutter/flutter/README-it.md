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

Flutter è l’SDK di Google per creare esperienze utente belle e veloci per dispositivi mobili, web e desktop da un’unica base di codice. Flutter funziona con il codice esistente, è utilizzato da sviluppatori e organizzazioni in tutto il mondo, ed è gratuito e open source.

## Documentazione

* [Installa Flutter](https://flutter.dev/get-started/)
* [Documentazione Flutter](https://docs.flutter.dev/)
* [Wiki di sviluppo](./docs/README.md)
* [Contribuire a Flutter](https://github.com/flutter/flutter/blob/main/CONTRIBUTING.md)

Per annunci sulle nuove versioni, segui la mailing list [flutter-announce@googlegroups.com](https://groups.google.com/forum/#!forum/flutter-announce). La nostra documentazione tiene traccia anche delle [modifiche che interrompono la compatibilità](https://docs.flutter.dev/release/breaking-changes) tra le versioni.

## Termini di servizio

Lo strumento Flutter può occasionalmente scaricare risorse dai server Google. Scaricando o utilizzando l’SDK Flutter, accetti i Termini di servizio di Google: https://policies.google.com/terms

Ad esempio, quando viene installato da GitHub (anziché da un archivio preconfezionato), lo strumento Flutter scaricherà l’SDK Dart dai server Google immediatamente al primo avvio, poiché necessario per eseguire lo stesso strumento `flutter`. Questo avverrà anche durante l’aggiornamento di Flutter (ad esempio eseguendo il comando `flutter upgrade`).

## Informazioni su Flutter

Pensiamo che Flutter ti aiuterà a creare app belle e veloci, con un modello di sviluppo produttivo, estendibile e aperto, sia che tu stia sviluppando per iOS o Android, web, Windows, macOS, Linux oppure lo stia integrando come toolkit UI per una piattaforma a tua scelta.

### Esperienze utente straordinarie

Vogliamo permettere ai designer di realizzare la loro visione creativa senza essere costretti a compromessi dovuti alle limitazioni del framework sottostante. La [architettura a livelli] di Flutter ti dà il controllo su ogni pixel dello schermo e le sue potenti capacità di compositing ti permettono di sovrapporre e animare grafica, video, testo e controlli senza limiti. Flutter include un set completo di [widget][widget catalog] che garantiscono esperienze perfette al pixel sia che tu sviluppi per iOS ([Cupertino]) o altre piattaforme ([Material]), oltre al supporto per la personalizzazione o la creazione di nuovi componenti visivi.

<p align="center"><img src="https://github.com/flutter/website/blob/main/src/content/assets/images/docs/homepage/reflectly-hero-600px.png?raw=true" alt="Immagine hero di Reflectly"></p>

### Risultati rapidi

Flutter è veloce. È alimentato da librerie grafiche 2D accelerate via hardware come [Skia] (che è alla base di Chrome e Android) e [Impeller]. Abbiamo progettato Flutter per supportare grafica fluida e senza interruzioni alla velocità nativa del tuo dispositivo.

Il codice Flutter è alimentato dalla piattaforma [Dart] di livello mondiale, che consente la compilazione in codice macchina ARM a 32 e 64 bit per iOS e Android, JavaScript e WebAssembly per il web, nonché Intel x64 e ARM per dispositivi desktop.

<p align="center"><img src="https://github.com/flutter/website/blob/main/src/content/assets/images/docs/homepage/dart-diagram-small.png?raw=true" alt="Diagramma Dart"></p>

### Sviluppo produttivo

Flutter offre [hot reload con stato][Hot reload], permettendoti di apportare modifiche al tuo codice e vedere i risultati istantaneamente senza riavviare l’app o perdere lo stato.

[![Animazione hot reload][]][Hot reload]

### Modello estendibile e aperto

Flutter funziona con qualsiasi strumento di sviluppo (o anche senza), e include plug-in per gli editor sia per [Visual Studio Code] che per [IntelliJ / Android Studio]. Flutter offre [decine di migliaia di pacchetti][Flutter packages] per velocizzare lo sviluppo, indipendentemente dalla piattaforma di destinazione. L’accesso ad altro codice nativo è semplice, con il supporto sia per FFI ([su Android][Android FFI], [su iOS][iOS FFI], [su macOS][macOS FFI] e [su Windows][Windows FFI]) sia per [API specifiche della piattaforma][platform channels].

Flutter è un progetto completamente open source e accogliamo volentieri contributi. Le informazioni su come iniziare sono disponibili nella nostra [guida per i contributori](CONTRIBUTING.md).

[flutter.dev]: https://flutter.dev
[Discord instructions]: ./docs/contributing/Chat.md
[Discord badge]: https://img.shields.io/discord/608014603317936148?logo=discord
[Twitter handle]: https://img.shields.io/twitter/follow/flutterdev.svg?style=social&label=Follow
[Twitter badge]: https://twitter.com/intent/follow?screen_name=flutterdev
[BlueSky badge]: https://img.shields.io/badge/Bluesky-0285FF?logo=bluesky&logoColor=fff&label=Follow%20me%20on&color=0285FF
[BlueSky handle]: https://bsky.app/profile/flutter.dev
[architettura a livelli]: https://docs.flutter.dev/resources/inside-flutter
[architectural overview]: https://docs.flutter.dev/resources/architectural-overview
[widget catalog]: https://flutter.dev/widgets/
[Cupertino]: https://docs.flutter.dev/development/ui/widgets/cupertino
[Material]: https://docs.flutter.dev/development/ui/widgets/material
[Skia]: https://skia.org/
[Dart]: https://dart.dev/
[Animazione hot reload]: https://github.com/flutter/website/blob/main/src/content/assets/images/docs/tools/android-studio/hot-reload.gif?raw=true
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