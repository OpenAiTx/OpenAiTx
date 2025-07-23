<p align="center">
    <img alt="ovCompose Logo" src="https://raw.githubusercontent.com/Tencent-TDS/ovCompose-multiplatform-core/ov/compose-1.6.1/img/ovCompose.svg" />
</p>

### English
ovCompose（オンラインビデオコンポーズ）は、Tencentの主要なフロントエンドグループであるOteam内のTencent Videoチームが立ち上げたクロスプラットフォーム開発フレームワークです。Compose Multiplatformエコシステムに基づいており、Jetbrains Compose Multiplatformの制限、特にHarmonyOSプラットフォームのサポート不足とiOSでの混合レイアウトレンダリングの制約を解決することを目指しています。ovComposeは、ビジネスが完全なクロスプラットフォームアプリを構築しやすくします。

[ovCompose](https://raw.githubusercontent.com/Tencent-TDS/ovCompose-multiplatform-core/ov/compose-1.6.1/README_ovCompose_en.md)の詳細はこちら

### 中文
ovCompose（online-video-compose）是腾讯大前端领域Oteam中，腾讯视频团队基于 Compose Multiplatform 生态推出的跨平台开发框架，旨在弥补Jetbrains Compose Multiplatform不支持鸿蒙平台的遗憾与解决iOS平台混排受限的问题，便于业务构建全跨端App。

详情请见 [ovCompose](https://raw.githubusercontent.com/Tencent-TDS/ovCompose-multiplatform-core/ov/compose-1.6.1/README_ovCompose_zh.md)

---
# Android Jetpack

[![Revved up by Gradle Enterprise](https://img.shields.io/badge/Revved%20up%20by-Gradle%20Enterprise-06A0CE?logo=Gradle&labelColor=02303A)](https://ge.androidx.dev)

Jetpackは、開発者が高品質なアプリをより簡単に書けるよう支援するライブラリ、ツール、ガイダンスのスイートです。これらのコンポーネントはベストプラクティスの遵守を助け、ボイラープレートコードの作成から解放し、複雑なタスクを簡素化するので、開発者は重要なコードに集中できます。

Jetpackは、プラットフォームAPIから分離された`androidx.*`パッケージライブラリで構成されています。これは、後方互換性を提供し、Androidプラットフォームよりも頻繁に更新されることを意味し、常に最新かつ最高のJetpackコンポーネントを利用できるようにします。

公式のAARおよびJARバイナリは[Google Maven](https://maven.google.com)を通じて配布されています。

使用方法の詳細は[Android Jetpackのランディングページ](https://developer.android.com/jetpack)をご覧ください。

# Contribution Guide

GitHub経由の貢献については、[GitHub Contribution Guide](https://raw.githubusercontent.com/Tencent-TDS/ovCompose-multiplatform-core/ov/compose-1.6.1/CONTRIBUTING.md)を参照してください。

注意：GitHub経由の貢献ワークフローは現在実験的であり、以下のプロジェクトへの貢献のみ受け付けています：
* [Activity](activity)
* [AppCompat](appcompat)
* [Biometric](biometric)
* [Collection](collection)
* [Compose Compiler](compose/compiler)
* [Compose Runtime](compose/runtime)
* [Core](core)
* [DataStore](datastore)
* [Fragment](fragment)
* [Lifecycle](lifecycle)
* [Navigation](navigation)
* [Paging](paging)
* [Room](room)
* [WorkManager](work)

## Code Review Etiquette
Jetpackに貢献する際は、[コードレビューマナー](https://raw.githubusercontent.com/Tencent-TDS/ovCompose-multiplatform-core/ov/compose-1.6.1/code-review.md)に従ってください。

## Accepted Types of Contributions
* バグ修正 - 対応するバグ報告が[Android Issue Tracker](https://issuetracker.google.com/issues/new?component=192731&template=842428)に必要です
* 各バグ修正にはテストが伴うことが期待されます
* スペルミスの修正
* ドキュメントの更新
* テスト未カバー領域への新規テスト追加
* AndroidXチームメンバーによる機能要求バグの承認がある場合の既存ライブラリへの新機能追加

現在、新規モジュールの受け入れは行っていません。

## Checking Out the Code

セットアップ方法と開発ワークフローについては[オンボーディングドキュメント](https://raw.githubusercontent.com/Tencent-TDS/ovCompose-multiplatform-core/ov/compose-1.6.1/docs/onboarding.md)をご覧ください。

### Continuous integration
[継続的インテグレーションシステム](https://ci.android.com/builds/branches/aosp-androidx-main/grid?)は、進行中（かつ不安定な可能性がある）ライブラリを新しい変更がマージされるたびにビルドします。これらのAARやJARを手動でダウンロードして試すことができます。

## Password and Contributor Agreement before making a change
初めての貢献をアップロードする前に、パスワード設定と貢献者契約への同意が必要です：

HTTPSパスワードを生成：
https://android-review.googlesource.com/new-password

Google Contributor Licenses Agreementに同意：
https://android-review.googlesource.com/settings/new-agreement

## Getting reviewed
* repo uploadを実行後、[r.android.com](http://r.android.com)を開く
* アカウントにサインイン（まだなければ作成）
* 適切なレビュアーを追加（修正するファイルの最も多くの変更を行った人物をgit logで調べるか、プロジェクトのOWNERSファイルを確認）

## Handling binary dependencies
AndroidXはすべてのバイナリGradle依存関係をgitで管理しています。これらはチェックアウトの`prebuilts/androidx/internal`および`prebuilts/androidx/external`ディレクトリに格納されています。これらの依存関係は`google()`または`mavenCentral()`からも入手可能です。ビルドの独立性を保つためにコピーを保存しています。[importMavenツール](https://raw.githubusercontent.com/Tencent-TDS/ovCompose-multiplatform-core/ov/compose-1.6.1/development/importMaven/README.md)を使って新しい依存関係を取り込むことができます。

## Publish

`gradle.properties`でリモートMavenを設定してください。



```
maven.remote.url=https:xxx
maven.remote.username=xxx
maven.remote.password=xxx
```
Publish artifacts to remote or local maven, see [MULTIPLATFORM.md](https://raw.githubusercontent.com/Tencent-TDS/ovCompose-multiplatform-core/ov/compose-1.6.1/MULTIPLATFORM.md) for more details.
```
./gradlew :mpp:publishComposeJb -Pcompose.platforms=android,ohosArm64,uikit
./gradlew :mpp:publishComposeJbToMavenLocal -Pcompose.platforms=android,ohosArm64,uikit
```





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-15

---