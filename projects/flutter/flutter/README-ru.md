<a href="https://flutter.dev/">
  <h1 align="center">
    <picture>
      <source media="(prefers-color-scheme: dark)" srcset="https://storage.googleapis.com/cms-storage-bucket/6e19fee6b47b36ca613f.png">
      <img alt="Flutter" src="https://storage.googleapis.com/cms-storage-bucket/c823e53b3a1a7b0d36a9.png">
    </picture>
  </h1>
</a>

[![Статус CI Flutter](https://flutter-dashboard.appspot.com/api/public/build-status-badge?repo=flutter)](https://flutter-dashboard.appspot.com/#/build?repo=flutter)
[![Discord badge][]][Discord instructions]
[![Twitter handle][]][Twitter badge]
[![BlueSky badge][]][BlueSky handle]
[![codecov](https://codecov.io/gh/flutter/flutter/branch/master/graph/badge.svg?token=11yDrJU2M2)](https://codecov.io/gh/flutter/flutter)
[![CII Best Practices](https://bestpractices.coreinfrastructure.org/projects/5631/badge)](https://bestpractices.coreinfrastructure.org/projects/5631)
[![SLSA 1](https://slsa.dev/images/gh-badge-level1.svg)](https://slsa.dev)

Flutter — это SDK от Google для создания красивых и быстрых пользовательских интерфейсов для мобильных устройств, веба и настольных платформ из единой кодовой базы. Flutter работает с существующим кодом, используется разработчиками и организациями по всему миру, а также является бесплатным и с открытым исходным кодом.

## Документация

* [Установка Flutter](https://flutter.dev/get-started/)
* [Документация по Flutter](https://docs.flutter.dev/)
* [Вики по разработке](./docs/README.md)
* [Вклад в развитие Flutter](https://github.com/flutter/flutter/blob/main/CONTRIBUTING.md)

Для получения информации о новых релизах подпишитесь на рассылку
[flutter-announce@googlegroups.com](https://groups.google.com/forum/#!forum/flutter-announce).
В нашей документации также отслеживаются [критические изменения](https://docs.flutter.dev/release/breaking-changes) между версиями.

## Условия использования

Инструмент Flutter может время от времени загружать ресурсы с серверов Google. Загружая или используя Flutter SDK, вы соглашаетесь с Условиями использования Google: https://policies.google.com/terms

Например, при установке из GitHub (а не из заранее упакованного архива) инструмент Flutter загрузит Dart SDK с серверов Google при первом запуске, поскольку он необходим для работы самой утилиты `flutter`. Это также произойдет при обновлении Flutter (например, при выполнении команды `flutter upgrade`).

## О Flutter

Мы считаем, что Flutter поможет вам создавать красивые и быстрые приложения с продуктивной, расширяемой и открытой моделью разработки, независимо от того, разрабатываете ли вы для iOS или Android, веба, Windows, macOS, Linux или встраиваете его как UI-инструментарий для выбранной вами платформы.

### Красивые пользовательские интерфейсы

Мы хотим дать дизайнерам возможность реализовать свое творческое видение без необходимости урезать его из-за ограничений базового фреймворка. [Слоистая архитектура] Flutter предоставляет полный контроль над каждым пикселем на экране, а мощные возможности компоновки позволяют накладывать и анимировать графику, видео, текст и элементы управления без ограничений. Flutter включает полный [набор виджетов][widget catalog], обеспечивающих идеальное отображение как для iOS ([Cupertino]), так и для других платформ ([Material]), а также поддержку кастомизации или создания совершенно новых визуальных компонентов.

<p align="center"><img src="https://github.com/flutter/website/blob/main/src/content/assets/images/docs/homepage/reflectly-hero-600px.png?raw=true" alt="Изображение Reflectly"></p>

### Быстрые результаты

Flutter быстр. Он работает на аппаратно-ускоряемых 2D графических библиотеках, таких как [Skia] (используется в Chrome и Android) и [Impeller]. Мы спроектировали Flutter так, чтобы поддерживать безупречную графику без лагов с нативной скоростью вашего устройства.

Код Flutter работает на платформе [Dart], которая обеспечивает компиляцию в 32-битный и 64-битный ARM-машинный код для iOS и Android, JavaScript и WebAssembly для веба, а также Intel x64 и ARM для настольных устройств.

<p align="center"><img src="https://github.com/flutter/website/blob/main/src/content/assets/images/docs/homepage/dart-diagram-small.png?raw=true" alt="Диаграмма Dart"></p>

### Продуктивная разработка

Flutter предлагает [stateful hot reload][Hot reload], позволяя вносить изменения в код и мгновенно видеть результат без перезапуска приложения и потери его состояния.

[![Анимация горячей перезагрузки][]][Hot reload]

### Расширяемая и открытая модель

Flutter работает с любыми инструментами разработки (или вовсе без них), а также включает плагины редакторов для [Visual Studio Code] и [IntelliJ / Android Studio]. Flutter предоставляет [десятки тысяч пакетов][Flutter packages] для ускорения вашей разработки вне зависимости от целевой платформы. Доступ к другому нативному коду прост благодаря поддержке FFI ([на Android][Android FFI], [на iOS][iOS FFI], [на macOS][macOS FFI], [на Windows][Windows FFI]), а также [платформенно-специфическим API][platform channels].

Flutter — полностью открытый проект, и мы приветствуем вклад сообщества.
Информацию о том, как начать, можно найти в нашем [руководстве для участников](CONTRIBUTING.md).

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