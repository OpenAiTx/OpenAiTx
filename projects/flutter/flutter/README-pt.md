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

Flutter é o SDK do Google para criar experiências de usuário bonitas e rápidas para
dispositivos móveis, web e desktop a partir de uma única base de código. O Flutter funciona com código existente, é utilizado por desenvolvedores e organizações no mundo todo, e é gratuito e de código aberto.

## Documentação

* [Instale o Flutter](https://flutter.dev/get-started/)
* [Documentação do Flutter](https://docs.flutter.dev/)
* [Wiki de desenvolvimento](./docs/README.md)
* [Contribuindo para o Flutter](https://github.com/flutter/flutter/blob/main/CONTRIBUTING.md)

Para anúncios sobre novos lançamentos, siga a lista de e-mails
[flutter-announce@googlegroups.com](https://groups.google.com/forum/#!forum/flutter-announce).
Nossa documentação também acompanha as [mudanças incompatíveis](https://docs.flutter.dev/release/breaking-changes) entre versões.

## Termos de serviço

A ferramenta Flutter pode ocasionalmente baixar recursos dos servidores do Google. Ao
baixar ou usar o SDK do Flutter, você concorda com os Termos de Serviço do Google:
https://policies.google.com/terms

Por exemplo, ao instalar do GitHub (em vez de um arquivo pré-empacotado),
a ferramenta Flutter fará o download do SDK do Dart dos servidores do Google
imediatamente na primeira execução, pois é utilizado para executar a própria ferramenta `flutter`.
Isso também ocorrerá quando o Flutter for atualizado (por exemplo, ao executar o comando `flutter upgrade`).

## Sobre o Flutter

Acreditamos que o Flutter irá ajudar você a criar aplicativos bonitos e rápidos, com um modelo de desenvolvimento produtivo, extensível e aberto, seja para iOS, Android, web, Windows, macOS, Linux ou integrando como toolkit de UI para a plataforma de sua escolha.

### Experiências de usuário bonitas

Queremos permitir que designers entreguem toda a sua visão criativa sem serem
forçados a reduzi-la devido a limitações do framework subjacente.
A [arquitetura em camadas](https://docs.flutter.dev/resources/inside-flutter) do Flutter oferece controle sobre cada pixel da tela e suas poderosas capacidades de composição permitem sobrepor e animar gráficos, vídeo, texto e controles sem limitações. O Flutter inclui um [conjunto completo de widgets][widget catalog] que proporciona experiências perfeitas em pixels, seja desenvolvendo para iOS ([Cupertino]) ou outras plataformas ([Material]), além de oferecer suporte para personalização ou criação de novos componentes visuais.

<p align="center"><img src="https://github.com/flutter/website/blob/main/src/content/assets/images/docs/homepage/reflectly-hero-600px.png?raw=true" alt="Reflectly hero image"></p>

### Resultados rápidos

Flutter é rápido. Ele é alimentado por bibliotecas de gráficos 2D aceleradas por hardware como [Skia] (que é a base do Chrome e Android) e [Impeller]. O Flutter foi arquitetado para suportar gráficos sem falhas e sem travamentos na velocidade nativa do seu dispositivo.

O código Flutter é alimentado pela [plataforma Dart], de classe mundial, que permite
compilação para código de máquina ARM 32-bit e 64-bit para iOS e Android,
JavaScript e WebAssembly para web, assim como Intel x64 e ARM
para dispositivos desktop.

<p align="center"><img src="https://github.com/flutter/website/blob/main/src/content/assets/images/docs/homepage/dart-diagram-small.png?raw=true" alt="Dart diagram"></p>

### Desenvolvimento produtivo

O Flutter oferece [hot reload com estado][Hot reload], permitindo que você faça alterações no seu código
e veja os resultados instantaneamente sem reiniciar o aplicativo ou perder seu estado.

[![Hot reload animation][]][Hot reload]

### Modelo extensível e aberto

O Flutter funciona com qualquer ferramenta de desenvolvimento (ou nenhuma), e também inclui
plug-ins de editor tanto para o [Visual Studio Code] quanto para o [IntelliJ / Android Studio].
O Flutter oferece [dezenas de milhares de pacotes][Flutter packages] para acelerar seu
desenvolvimento, independentemente da sua plataforma alvo. E acessar outros códigos nativos
é fácil, com suporte para FFI ([no Android][Android FFI], [no iOS][iOS FFI],
[no macOS][macOS FFI] e [no Windows][Windows FFI]) assim como
[APIs específicas de plataforma][platform channels].

O Flutter é um projeto totalmente open source e recebemos contribuições de braços abertos.
Informações sobre como começar podem ser encontradas em nosso
[guia de contribuição](CONTRIBUTING.md).

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