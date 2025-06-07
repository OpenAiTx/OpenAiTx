<a href="https://flutter.dev/">
  <h1 align="center">
    <picture>
      <source media="(prefers-color-scheme: dark)" srcset="https://storage.googleapis.com/cms-storage-bucket/6e19fee6b47b36ca613f.png">
      <img alt="Flutter" src="https://storage.googleapis.com/cms-storage-bucket/c823e53b3a1a7b0d36a9.png">
    </picture>
  </h1>
</a>

[![Estado de CI de Flutter](https://flutter-dashboard.appspot.com/api/public/build-status-badge?repo=flutter)](https://flutter-dashboard.appspot.com/#/build?repo=flutter)
[![Insignia de Discord][]][Instrucciones de Discord]
[![Cuenta de Twitter][]][Insignia de Twitter]
[![Insignia de BlueSky][]][Cuenta de BlueSky]
[![codecov](https://codecov.io/gh/flutter/flutter/branch/master/graph/badge.svg?token=11yDrJU2M2)](https://codecov.io/gh/flutter/flutter)
[![CII Mejores Prácticas](https://bestpractices.coreinfrastructure.org/projects/5631/badge)](https://bestpractices.coreinfrastructure.org/projects/5631)
[![SLSA 1](https://slsa.dev/images/gh-badge-level1.svg)](https://slsa.dev)

Flutter es el SDK de Google para crear experiencias de usuario hermosas y rápidas para
móvil, web y escritorio desde una única base de código. Flutter funciona con código
existente, es utilizado por desarrolladores y organizaciones de todo el mundo, y es gratuito y
de código abierto.

## Documentación

* [Instalar Flutter](https://flutter.dev/get-started/)
* [Documentación de Flutter](https://docs.flutter.dev/)
* [Wiki de desarrollo](./docs/README.md)
* [Contribuir a Flutter](https://github.com/flutter/flutter/blob/main/CONTRIBUTING.md)

Para anuncios sobre nuevos lanzamientos, sigue la
[lista de correo flutter-announce@googlegroups.com](https://groups.google.com/forum/#!forum/flutter-announce).
Nuestra documentación también sigue los [cambios incompatibles](https://docs.flutter.dev/release/breaking-changes) entre versiones.

## Términos de servicio

La herramienta de Flutter puede descargar ocasionalmente recursos desde los servidores de Google. Al
descargar o usar el SDK de Flutter, aceptas los Términos de Servicio de Google:
https://policies.google.com/terms

Por ejemplo, cuando se instala desde GitHub (en lugar de desde un archivo preempaquetado),
la herramienta de Flutter descargará el SDK de Dart desde los servidores de Google
inmediatamente la primera vez que se ejecute, ya que es necesario para ejecutar la propia herramienta `flutter`.
Esto también ocurrirá cuando Flutter se actualice (por ejemplo, al ejecutar el comando `flutter
upgrade`).

## Acerca de Flutter

Creemos que Flutter te ayudará a crear aplicaciones hermosas y rápidas, con un modelo de desarrollo productivo,
extensible y abierto, ya sea que apuntes a iOS o Android,
web, Windows, macOS, Linux o lo integres como el kit de herramientas UI para la plataforma de tu elección.

### Experiencias de usuario hermosas

Queremos permitir que los diseñadores transmitan toda su visión creativa sin verse
obligados a limitarse debido a las restricciones del framework subyacente.
La [arquitectura en capas] de Flutter te da control sobre cada píxel en la
pantalla y sus potentes capacidades de composición te permiten superponer y animar
gráficos, video, texto y controles sin limitaciones. Flutter incluye un
[conjunto completo de widgets][catálogo de widgets] que ofrecen experiencias perfectas píxel a píxel tanto si
estás desarrollando para iOS ([Cupertino]) como para otras plataformas ([Material]), junto con
soporte para personalizar o crear nuevos componentes visuales completamente.

<p align="center"><img src="https://github.com/flutter/website/blob/main/src/content/assets/images/docs/homepage/reflectly-hero-600px.png?raw=true" alt="Imagen principal de Reflectly"></p>

### Resultados rápidos

Flutter es rápido. Está impulsado por bibliotecas de gráficos 2D aceleradas por hardware
como [Skia] (que también utilizan Chrome y Android) e
[Impeller]. Diseñamos Flutter para
soportar gráficos sin fallos ni saltos, a la velocidad nativa de tu dispositivo.

El código Flutter funciona sobre la plataforma [Dart] de clase mundial, que permite
compilación a código máquina ARM de 32 y 64 bits para iOS y Android,
JavaScript y WebAssembly para web, así como Intel x64 y ARM
para dispositivos de escritorio.

<p align="center"><img src="https://github.com/flutter/website/blob/main/src/content/assets/images/docs/homepage/dart-diagram-small.png?raw=true" alt="Diagrama de Dart"></p>

### Desarrollo productivo

Flutter ofrece [hot reload con estado][Hot reload], permitiéndote realizar cambios en tu código
y ver los resultados al instante sin reiniciar tu aplicación ni perder su estado.

[![Animación de hot reload][]][Hot reload]

### Modelo extensible y abierto

Flutter funciona con cualquier herramienta de desarrollo (o ninguna), e incluye además
complementos de editor tanto para [Visual Studio Code] como para [IntelliJ / Android Studio].
Flutter proporciona [decenas de miles de paquetes][Paquetes Flutter] para acelerar tu
desarrollo, independientemente de la plataforma objetivo. Y acceder a otro código nativo
es sencillo, con soporte tanto para FFI ([en Android][Android FFI], [en iOS][iOS FFI],
[en macOS][macOS FFI], y [en Windows][Windows FFI]) como para
[APIs específicas de plataforma][canales de plataforma].

Flutter es un proyecto completamente de código abierto, y damos la bienvenida a las contribuciones.
La información sobre cómo comenzar se encuentra en nuestra
[guía para colaboradores](CONTRIBUTING.md).

[flutter.dev]: https://flutter.dev
[Instrucciones de Discord]: ./docs/contributing/Chat.md
[Insignia de Discord]: https://img.shields.io/discord/608014603317936148?logo=discord
[Cuenta de Twitter]: https://img.shields.io/twitter/follow/flutterdev.svg?style=social&label=Follow
[Insignia de Twitter]: https://twitter.com/intent/follow?screen_name=flutterdev
[Insignia de BlueSky]: https://img.shields.io/badge/Bluesky-0285FF?logo=bluesky&logoColor=fff&label=Follow%20me%20on&color=0285FF
[Cuenta de BlueSky]: https://bsky.app/profile/flutter.dev
[arquitectura en capas]: https://docs.flutter.dev/resources/inside-flutter
[visión general de la arquitectura]: https://docs.flutter.dev/resources/architectural-overview
[catálogo de widgets]: https://flutter.dev/widgets/
[Cupertino]: https://docs.flutter.dev/development/ui/widgets/cupertino
[Material]: https://docs.flutter.dev/development/ui/widgets/material
[Skia]: https://skia.org/
[Dart]: https://dart.dev/
[Animación de hot reload]: https://github.com/flutter/website/blob/main/src/content/assets/images/docs/tools/android-studio/hot-reload.gif?raw=true
[Hot reload]: https://docs.flutter.dev/development/tools/hot-reload
[Visual Studio Code]: https://marketplace.visualstudio.com/items?itemName=Dart-Code.flutter
[IntelliJ / Android Studio]: https://plugins.jetbrains.com/plugin/9212-flutter
[Paquetes Flutter]: https://pub.dev/flutter
[Android FFI]: https://docs.flutter.dev/development/platform-integration/android/c-interop
[iOS FFI]: https://docs.flutter.dev/development/platform-integration/ios/c-interop
[macOS FFI]: https://docs.flutter.dev/development/platform-integration/macos/c-interop
[Windows FFI]: https://docs.flutter.dev/development/platform-integration/windows/building#integrating-with-windows
[canales de plataforma]: https://docs.flutter.dev/development/platform-integration/platform-channels
[ejemplo de interoperabilidad]: https://github.com/flutter/flutter/tree/main/examples/platform_channel
[Impeller]: https://docs.flutter.dev/perf/impeller

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---