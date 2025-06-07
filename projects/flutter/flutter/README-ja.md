<a href="https://flutter.dev/">
  <h1 align="center">
    <picture>
      <source media="(prefers-color-scheme: dark)" srcset="https://storage.googleapis.com/cms-storage-bucket/6e19fee6b47b36ca613f.png">
      <img alt="Flutter" src="https://storage.googleapis.com/cms-storage-bucket/c823e53b3a1a7b0d36a9.png">
    </picture>
  </h1>
</a>

[![Flutter CI ステータス](https://flutter-dashboard.appspot.com/api/public/build-status-badge?repo=flutter)](https://flutter-dashboard.appspot.com/#/build?repo=flutter)
[![Discord バッジ][]][Discord instructions]
[![Twitter ハンドル][]][Twitter badge]
[![BlueSky バッジ][]][BlueSky handle]
[![codecov](https://codecov.io/gh/flutter/flutter/branch/master/graph/badge.svg?token=11yDrJU2M2)](https://codecov.io/gh/flutter/flutter)
[![CII ベストプラクティス](https://bestpractices.coreinfrastructure.org/projects/5631/badge)](https://bestpractices.coreinfrastructure.org/projects/5631)
[![SLSA 1](https://slsa.dev/images/gh-badge-level1.svg)](https://slsa.dev)

Flutterは、Googleが開発した、モバイル、Web、デスクトップ向けに単一のコードベースから美しく高速なユーザーエクスペリエンスを作成するためのSDKです。Flutterは既存のコードと連携し、世界中の開発者や組織によって利用されており、無料かつオープンソースです。

## ドキュメント

* [Flutterのインストール](https://flutter.dev/get-started/)
* [Flutterドキュメント](https://docs.flutter.dev/)
* [開発Wiki](./docs/README.md)
* [Flutterへの貢献](https://github.com/flutter/flutter/blob/main/CONTRIBUTING.md)

新しいリリースに関するアナウンスは、
[flutter-announce@googlegroups.com](https://groups.google.com/forum/#!forum/flutter-announce)
メーリングリストをご覧ください。また、ドキュメントではリリースごとの[破壊的変更](https://docs.flutter.dev/release/breaking-changes)も追跡しています。

## 利用規約

Flutterツールは、Googleのサーバーからリソースをダウンロードする場合があります。Flutter SDKをダウンロードまたは使用することで、Googleの利用規約に同意したことになります:
https://policies.google.com/terms

例えば、FlutterをGitHubからインストールした場合（事前パッケージ化されたアーカイブからではなく）、最初の実行時にFlutterツールがGoogleサーバーからDart SDKを即座にダウンロードします（`flutter`ツール自体の実行に利用します）。これはFlutterをアップグレードする際（例: `flutter upgrade`コマンドの実行時）にも発生します。

## Flutterについて

Flutterは、美しく高速なアプリを生産的で拡張性があり、オープンな開発モデルで作成できるよう支援するものです。iOSやAndroid、Web、Windows、macOS、Linux、あるいはお好みのプラットフォームのUIツールキットとして組み込む場合にも対応します。

### 美しいユーザーエクスペリエンス

デザイナーが基盤となるフレームワークの制約によって妥協せず、創造性を最大限に発揮できるようにしたいと考えています。Flutterの[階層化アーキテクチャ][layered architecture]により、画面上のすべてのピクセルを制御でき、強力な合成機能によってグラフィック、ビデオ、テキスト、コントロールを制限なく重ねたりアニメーションさせたりできます。Flutterには、iOS（[Cupertino]）や他のプラットフォーム（[Material]）向けにピクセルパーフェクトな体験を提供する[ウィジェットのセット][widget catalog]が含まれており、カスタマイズや新しいビジュアルコンポーネントの作成もサポートしています。

<p align="center"><img src="https://github.com/flutter/website/blob/main/src/content/assets/images/docs/homepage/reflectly-hero-600px.png?raw=true" alt="Reflectly hero image"></p>

### 高速な結果

Flutterは高速です。[Skia]（ChromeやAndroidの基盤）や[Impeller]などのハードウェアアクセラレーション2Dグラフィックスライブラリにより、デバイス本来の速度でグリッチやカクつきのないグラフィックスを実現しています。

Flutterのコードは世界トップクラスの[Dartプラットフォーム]によって動作し、iOSとAndroid向けの32ビットおよび64ビットARMマシンコード、Web向けのJavaScriptやWebAssembly、そしてデスクトップデバイス向けのIntel x64やARMへのコンパイルが可能です。

<p align="center"><img src="https://github.com/flutter/website/blob/main/src/content/assets/images/docs/homepage/dart-diagram-small.png?raw=true" alt="Dart diagram"></p>

### 生産的な開発

Flutterは[ステートフルホットリロード][Hot reload]を提供しており、コードの変更をアプリの再起動や状態の喪失なしに即座に確認できます。

[![ホットリロードアニメーション][]][Hot reload]

### 拡張可能でオープンなモデル

Flutterは任意の開発ツール（あるいはツールなし）で動作し、[Visual Studio Code]や[IntelliJ / Android Studio]向けのエディタープラグインも提供しています。Flutterは[数万のパッケージ][Flutter packages]を提供しており、ターゲットプラットフォームに関わらず開発を加速します。また、FFIによる他のネイティブコードへのアクセスも簡単で、[Android][Android FFI]、[iOS][iOS FFI]、[macOS][macOS FFI]、[Windows][Windows FFI]に対応、さらに[プラットフォーム固有のAPI][platform channels]も利用可能です。

Flutterは完全なオープンソースプロジェクトであり、皆様からの貢献を歓迎しています。
開始方法については[コントリビューターガイド](CONTRIBUTING.md)をご参照ください。

[flutter.dev]: https://flutter.dev
[Discord instructions]: ./docs/contributing/Chat.md
[Discord バッジ]: https://img.shields.io/discord/608014603317936148?logo=discord
[Twitter ハンドル]: https://img.shields.io/twitter/follow/flutterdev.svg?style=social&label=Follow
[Twitter badge]: https://twitter.com/intent/follow?screen_name=flutterdev
[BlueSky バッジ]: https://img.shields.io/badge/Bluesky-0285FF?logo=bluesky&logoColor=fff&label=Follow%20me%20on&color=0285FF
[BlueSky handle]: https://bsky.app/profile/flutter.dev
[layered architecture]: https://docs.flutter.dev/resources/inside-flutter
[architectural overview]: https://docs.flutter.dev/resources/architectural-overview
[widget catalog]: https://flutter.dev/widgets/
[Cupertino]: https://docs.flutter.dev/development/ui/widgets/cupertino
[Material]: https://docs.flutter.dev/development/ui/widgets/material
[Skia]: https://skia.org/
[Dart platform]: https://dart.dev/
[ホットリロードアニメーション]: https://github.com/flutter/website/blob/main/src/content/assets/images/docs/tools/android-studio/hot-reload.gif?raw=true
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