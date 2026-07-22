<div align="center">

  <img src="https://github.com/tapframe/NuvioTV/blob/main/assets/brand/app_logo_wordmark.png" alt="Nuvio" width="300" />
  <br />
  <br />

  [![Contributors][contributors-shield]][contributors-url]
  [![Forks][forks-shield]][forks-url]
  [![Stargazers][stars-shield]][stars-url]
  [![Issues][issues-shield]][issues-url]
  [![License][license-shield]][license-url]

  <p>
    Kotlin Multiplatform と Compose Multiplatform で構築された、Android と iOS 向けのモダンなメディアハブ。
    <br />
    Stremio アドオンエコシステム・クロスプラットフォーム
  </p>

</div>

## 概要

Nuvio は、オリジナルの React Native アプリを Kotlin Multiplatform で書き直したものです。Android と iOS で共有の Compose UI を提供しつつ、再生に特化した体験、コレクションツール、視聴進捗フロー、ダウンロード、そして以前のアプリを形作った Stremio アドオンエコシステムの統合を維持しています。

モバイルアプリは [composeApp](./composeApp) の単一の共有コードベースから構築されており、Android と iOS のネイティブプラットフォームエントリーポイントを備えています。

## インストール

### Android

最新の Android ビルドは [GitHub Releases](https://github.com/NuvioMedia/NuvioMobile/releases/latest) からダウンロードしてください。

### iOS

- [TestFlight](https://testflight.apple.com/join/u4y7MHK9)

## 開発

```bash
git clone https://github.com/NuvioMedia/NuvioMobile.git
cd NuvioMobile
./scripts/run-mobile.sh android
# or
./scripts/run-mobile.sh ios
```

### プロジェクト構成

- `composeApp/` は共通のKotlinマルチプラットフォームおよびComposeマルチプラットフォームアプリコードを含みます。
- `composeApp/src/commonMain/` は共通のUI、機能、リポジトリ、およびプラットフォーム非依存のロジックを含みます。
- `composeApp/src/androidMain/` はAndroid固有の統合を含みます。
- `composeApp/src/iosMain/` はiOS固有の統合を含みます。
- `iosApp/` はネイティブのXcodeプロジェクトとiOSのエントリーポイントを含みます。

便利なコマンド:

```bash
./gradlew :composeApp:assembleDebug
./gradlew :composeApp:compileKotlinIosSimulatorArm64
./scripts/build-distribution.sh
```
Versioningは、iOSおよびAndroidのビルドの共通の信頼できる情報源として使用される`iosApp/Configuration/Version.xcconfig`から管理されています。

## 法的事項およびDMCA

Nuvioは、ユーザーがインストールした拡張機能および/またはユーザー提供のソースによって提供されるメタデータの閲覧およびメディア再生のためのクライアント側インターフェースとしてのみ機能します。これは、ユーザーが所有するか、またはアクセスする権限を持つコンテンツを対象としています。

Nuvioは、第三者の拡張機能、カタログ、ソース、またはコンテンツプロバイダーとは一切関係ありません。メディアコンテンツのホスティング、保存、配布は行っていません。

完全な法的情報には、当社の免責事項全文、第三者拡張機能ポリシー、DMCA/著作権情報が含まれており、詳細は[法的事項および免責事項ページ](https://nuvioapp.space/legal)をご覧ください。

## 使用技術

- Kotlin Multiplatform
- Compose Multiplatform
- Kotlin
- AndroidX Media3
- AVFoundationおよびネイティブiOS統合

## スター履歴

<a href="https://www.star-history.com/#NuvioMedia/NuvioMobile&type=date&legend=top-left">
 <picture>
   <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=NuvioMedia/NuvioMobile&type=date&theme=dark&legend=top-left" />
   <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=NuvioMedia/NuvioMobile&type=date&legend=top-left" />
   <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=NuvioMedia/NuvioMobile&type=date&legend=top-left" />
 </picture>
</a>

<!-- MARKDOWN LINKS & IMAGES -->
[contributors-shield]: https://img.shields.io/github/contributors/NuvioMedia/NuvioMobile.svg?style=for-the-badge
[contributors-url]: https://github.com/NuvioMedia/NuvioMobile/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/NuvioMedia/NuvioMobile.svg?style=for-the-badge
[forks-url]: https://github.com/NuvioMedia/NuvioMobile/network/members
[stars-shield]: https://img.shields.io/github/stars/NuvioMedia/NuvioMobile.svg?style=for-the-badge
[stars-url]: https://github.com/NuvioMedia/NuvioMobile/stargazers
[issues-shield]: https://img.shields.io/github/issues/NuvioMedia/NuvioMobile.svg?style=for-the-badge
[issues-url]: https://github.com/NuvioMedia/NuvioMobile/issues
[license-shield]: https://img.shields.io/github/license/NuvioMedia/NuvioMobile.svg?style=for-the-badge
[license-url]: https://github.com/NuvioMedia/NuvioMobile/blob/main/LICENSE


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-22

---