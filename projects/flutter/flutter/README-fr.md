<a href="https://flutter.dev/">
  <h1 align="center">
    <picture>
      <source media="(prefers-color-scheme: dark)" srcset="https://storage.googleapis.com/cms-storage-bucket/6e19fee6b47b36ca613f.png">
      <img alt="Flutter" src="https://storage.googleapis.com/cms-storage-bucket/c823e53b3a1a7b0d36a9.png">
    </picture>
  </h1>
</a>

[![Statut CI Flutter](https://flutter-dashboard.appspot.com/api/public/build-status-badge?repo=flutter)](https://flutter-dashboard.appspot.com/#/build?repo=flutter)
[![Badge Discord][]][Instructions Discord]
[![Compte Twitter][]][Badge Twitter]
[![Badge BlueSky][]][Compte BlueSky]
[![codecov](https://codecov.io/gh/flutter/flutter/branch/master/graph/badge.svg?token=11yDrJU2M2)](https://codecov.io/gh/flutter/flutter)
[![CII Best Practices](https://bestpractices.coreinfrastructure.org/projects/5631/badge)](https://bestpractices.coreinfrastructure.org/projects/5631)
[![SLSA 1](https://slsa.dev/images/gh-badge-level1.svg)](https://slsa.dev)

Flutter est le SDK de Google pour créer de magnifiques expériences utilisateur rapides pour le mobile, le web et le bureau à partir d'une seule base de code. Flutter fonctionne avec du code existant, est utilisé par des développeurs et organisations dans le monde entier, et est gratuit et open source.

## Documentation

* [Installer Flutter](https://flutter.dev/get-started/)
* [Documentation Flutter](https://docs.flutter.dev/)
* [Wiki de développement](./docs/README.md)
* [Contribuer à Flutter](https://github.com/flutter/flutter/blob/main/CONTRIBUTING.md)

Pour les annonces concernant les nouvelles versions, suivez la liste de diffusion [flutter-announce@googlegroups.com](https://groups.google.com/forum/#!forum/flutter-announce). Notre documentation suit également les [changements majeurs](https://docs.flutter.dev/release/breaking-changes) entre les versions.

## Conditions d’utilisation

L’outil Flutter peut occasionnellement télécharger des ressources depuis les serveurs de Google. En téléchargeant ou en utilisant le SDK Flutter, vous acceptez les Conditions d’utilisation de Google : https://policies.google.com/terms

Par exemple, lorsqu’il est installé depuis GitHub (contrairement à une archive préemballée), l’outil Flutter téléchargera le SDK Dart depuis les serveurs de Google dès le premier lancement, car il est utilisé pour exécuter l’outil `flutter` lui-même. Cela se produira également lors d’une mise à jour de Flutter (par exemple en lançant la commande `flutter upgrade`).

## À propos de Flutter

Nous pensons que Flutter vous aidera à créer des applications belles et rapides, avec un modèle de développement productif, extensible et ouvert, que vous visiez iOS ou Android, le web, Windows, macOS, Linux ou l’intégration comme kit d’interface utilisateur pour la plateforme de votre choix.

### De magnifiques expériences utilisateur

Nous voulons permettre aux designers de réaliser pleinement leur vision créative sans être contraints de la limiter à cause des restrictions du framework sous-jacent. L’[architecture en couches] de Flutter vous donne le contrôle de chaque pixel à l’écran et ses puissantes capacités de composition vous permettent de superposer et d’animer graphiques, vidéos, textes et contrôles sans aucune limitation. Flutter inclut un [ensemble complet de widgets][catalogue des widgets] offrant des expériences pixel-perfect que vous développiez pour iOS ([Cupertino]) ou d’autres plateformes ([Material]), ainsi qu’un support pour personnaliser ou créer entièrement de nouveaux composants visuels.

<p align="center"><img src="https://github.com/flutter/website/blob/main/src/content/assets/images/docs/homepage/reflectly-hero-600px.png?raw=true" alt="Image principale Reflectly"></p>

### Des résultats rapides

Flutter est rapide. Il est propulsé par des bibliothèques graphiques 2D accélérées matériellement comme [Skia] (qui sous-tend Chrome et Android) et [Impeller]. Nous avons conçu Flutter pour supporter des graphiques fluides, sans saccades, à la vitesse native de votre appareil.

Le code Flutter est propulsé par la [plateforme Dart] de classe mondiale, qui permet la compilation en code machine ARM 32 bits et 64 bits pour iOS et Android, JavaScript et WebAssembly pour le web, ainsi qu’Intel x64 et ARM pour les ordinateurs de bureau.

<p align="center"><img src="https://github.com/flutter/website/blob/main/src/content/assets/images/docs/homepage/dart-diagram-small.png?raw=true" alt="Diagramme Dart"></p>

### Un développement productif

Flutter propose le [hot reload avec état][Hot reload], vous permettant de modifier votre code et de voir instantanément les résultats sans redémarrer votre application ou perdre son état.

[![Animation hot reload][]][Hot reload]

### Un modèle extensible et ouvert

Flutter fonctionne avec n’importe quel outil de développement (ou aucun), et inclut également des plug-ins d’éditeur pour [Visual Studio Code] et [IntelliJ / Android Studio]. Flutter propose [des dizaines de milliers de packages][Packages Flutter] pour accélérer votre développement, quelle que soit votre plateforme cible. L’accès à d’autres codes natifs est également simple, avec la prise en charge de FFI ([sur Android][Android FFI], [sur iOS][iOS FFI], [sur macOS][macOS FFI], et [sur Windows][Windows FFI]) ainsi que des [API spécifiques à la plateforme][canaux plateforme].

Flutter est un projet entièrement open-source, et nous accueillons volontiers les contributions. Vous trouverez les informations pour bien démarrer dans notre [guide du contributeur](CONTRIBUTING.md).

[flutter.dev]: https://flutter.dev
[Instructions Discord]: ./docs/contributing/Chat.md
[Badge Discord]: https://img.shields.io/discord/608014603317936148?logo=discord
[Compte Twitter]: https://img.shields.io/twitter/follow/flutterdev.svg?style=social&label=Follow
[Badge Twitter]: https://twitter.com/intent/follow?screen_name=flutterdev
[Badge BlueSky]: https://img.shields.io/badge/Bluesky-0285FF?logo=bluesky&logoColor=fff&label=Follow%20me%20on&color=0285FF
[Compte BlueSky]: https://bsky.app/profile/flutter.dev
[architecture en couches]: https://docs.flutter.dev/resources/inside-flutter
[vue d’ensemble de l’architecture]: https://docs.flutter.dev/resources/architectural-overview
[catalogue des widgets]: https://flutter.dev/widgets/
[Cupertino]: https://docs.flutter.dev/development/ui/widgets/cupertino
[Material]: https://docs.flutter.dev/development/ui/widgets/material
[Skia]: https://skia.org/
[plateforme Dart]: https://dart.dev/
[Animation hot reload]: https://github.com/flutter/website/blob/main/src/content/assets/images/docs/tools/android-studio/hot-reload.gif?raw=true
[Hot reload]: https://docs.flutter.dev/development/tools/hot-reload
[Visual Studio Code]: https://marketplace.visualstudio.com/items?itemName=Dart-Code.flutter
[IntelliJ / Android Studio]: https://plugins.jetbrains.com/plugin/9212-flutter
[Packages Flutter]: https://pub.dev/flutter
[Android FFI]: https://docs.flutter.dev/development/platform-integration/android/c-interop
[iOS FFI]: https://docs.flutter.dev/development/platform-integration/ios/c-interop
[macOS FFI]: https://docs.flutter.dev/development/platform-integration/macos/c-interop
[Windows FFI]: https://docs.flutter.dev/development/platform-integration/windows/building#integrating-with-windows
[canaux plateforme]: https://docs.flutter.dev/development/platform-integration/platform-channels
[exemple d’interop]: https://github.com/flutter/flutter/tree/main/examples/platform_channel
[Impeller]: https://docs.flutter.dev/perf/impeller

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---