[![Maven Central](https://img.shields.io/maven-central/v/dev.kotbase/couchbase-lite)](
https://central.sonatype.com/namespace/dev.kotbase)
[![Kotlin](https://img.shields.io/badge/kotlin-2.2.20-blue.svg?logo=kotlin)](http://kotlinlang.org)
[![GitHub License](https://img.shields.io/github/license/jeffdgr8/kotbase)](LICENSE)
[![Couchbase Community](https://img.shields.io/badge/couchbase-community-ea2328?logo=couchbase&logoColor=ea2328)](
https://www.couchbase.com/developers/community/)
[![Slack Channel](https://img.shields.io/badge/chat-%23couchbase-4a154b.svg?logo=slack)](
https://kotlinlang.slack.com/messages/couchbase/)

# Kotbase

**Kot**lin マルチプラットフォームライブラリ for Couch**base** Lite

## はじめに

Kotbase は [Kotlin Multiplatform](https://www.jetbrains.com/kotlin-multiplatform/) と埋め込み型 NoSQL JSON ドキュメントデータベースの [Couchbase Lite](
https://www.couchbase.com/products/lite/) を組み合わせたものです。Couchbase Lite はスタンドアロンのクライアントデータベースとして使用でき、また [Couchbase Server](https://www.couchbase.com/products/server/) と [Sync
Gateway](https://www.couchbase.com/products/sync-gateway/) または [Capella App Services](
https://www.couchbase.com/products/capella/app-services/) と組み合わせてクラウドからエッジへのデータ同期を行うことができます。主な特徴は以下の通りです:

* [SQL++](https://www.couchbase.com/products/n1ql/)、キー/バリュー、全文検索、およびベクター検索クエリ
* オブザーバブルクエリ、ドキュメント、データベース、レプリケーター
* バイナリドキュメント添付ファイル（blob）
* ピアツーピアおよびクラウドからエッジへのデータ同期

Kotbase は Android と JVM 向けに完全な Enterprise および Community Edition API サポートを提供します（[Java SDK 経由](
https://github.com/couchbase/couchbase-lite-java-ce-root)）、ネイティブ iOS と macOS 向けに（[Objective-C SDK 経由](
https://github.com/couchbase/couchbase-lite-ios)）、そしてネイティブ Linux と Windows 向けに実験的サポートを提供します（[C SDK 経由](
https://github.com/couchbase/couchbase-lite-C)）。

## インストール

共有モジュールの **build.gradle.kts** にある **commonMain** ソースセットの依存関係に Community または Enterprise Edition の依存関係を追加してください:



```kotlin
kotlin {
    sourceSets {
        commonMain.dependencies {
            // Community Edition
            implementation("dev.kotbase:couchbase-lite:3.2.4-1.2.0")
            // or Enterprise Edition
            implementation("dev.kotbase:couchbase-lite-ee:3.2.4-1.2.0")
        }
    }
}
```

> **注意**
> Couchbase Lite Community Editionは無料でオープンソースです。Enterprise Editionは開発および
> テストには無料ですが、本番環境での使用には[Couchbaseからのライセンス](https://www.couchbase.com/pricing/#couchbase-mobile)が必要です。
> [Community版とEnterprise版の違いはこちら。](https://www.couchbase.com/products/editions/mobile/)
> 
> KotbaseはMaven Centralに公開されています。Couchbase Lite Enterprise Editionの依存関係には
> さらにCouchbase Mavenリポジトリが必要です。

```kotlin
repositories {
    mavenCentral()
    maven("https://mobile.maven.couchbase.com/maven2/dev/")
}
```
### ネイティブプラットフォーム

ネイティブプラットフォームのターゲットは、Couchbase Lite依存のネイティブバイナリにもリンクする必要があります。詳細は[対応プラットフォーム](https://kotbase.dev/current/platforms/)を参照してください。

### Linux

Linux上で動作するJVMまたはネイティブLinuxをターゲットにする場合、特定バージョンのlibicu依存関係が必要です。（`libLiteCore.so: libicuuc.so.71: cannot open shared object file: No such file or directory`のようなエラーが表示され、期待されるバージョンが示されます。）必要なバージョンがディストリビューションのパッケージマネージャーで利用できない場合は、[GitHub](https://github.com/unicode-org/icu/releases)からダウンロードできます。

## ドキュメント

Kotbaseのドキュメントは[kotbase.dev](https://kotbase.dev/)で入手でき、[入門例](https://kotbase.dev/current/getting-started/)、[使用ガイド](https://kotbase.dev/current/databases/)、および[APIリファレンス](https://kotbase.dev/api/)が含まれています。

## Java SDKとの違い

KotbaseのAPIはCouchbase Liteの[Java](https://raw.githubusercontent.com/jeffdgr8/kotbase/main/
https://docs.couchbase.com/couchbase-lite/current/java/quickstart.html)および[Android KTX](https://raw.githubusercontent.com/jeffdgr8/kotbase/main/
https://docs.couchbase.com/couchbase-lite/current/android/quickstart.html) SDKに整合しています。既存のKotlinコードの移行は、インポートパッケージを`com.couchbase.lite`から`kotbase`に変更するだけで済む場合がありますが、一部例外があります：

* Javaのコールバック関数型インターフェースはKotlinの関数型として実装されています。
* `File`、`URL`、`URI`のAPIは文字列として表現されます。
* `Date`のAPIはKotlinの`Instant`を使用します。
* `InputStream`のAPIは[kotlinx-ioの`Source`](https://kotlinlang.org/api/kotlinx-io/kotlinx-io-core/kotlinx.io/-source/)を使用します。
* `Executor`のAPIはKotlinの`CoroutineContext`を使用します。
* 証明書APIは生の`ByteArray`またはプラットフォーム固有のコードで利用可能です。
* `CouchbaseLite.init()`を明示的に呼び出す必要はありません。JVMおよびAndroidプラットフォームコードではカスタムパラメータで初期化関数を呼び出すことも可能です。
* 一般的なエラー条件に対してKotlin例外を検出しスローするよう努めていますが、Appleプラットフォームでは`NSError`が漏れる可能性があります。[発生した場合は報告](https://github.com/jeffdgr8/kotbase/issues/new)してください。
* 一部の非推奨APIは省略されています。
* Java SDKにはない、Javaが演算子オーバーロードをサポートしていないために存在しない[`Fragment`のサブスクリプトAPI](












  https://kotbase.dev/current/kotlin-extensions/#fragment-subscripts) は、[Swift](https://raw.githubusercontent.com/jeffdgr8/kotbase/main/
  https://docs.couchbase.com/mobile/3.1.10/couchbase-lite-swift/Classes/Fragment.html)、[Objective-C](https://raw.githubusercontent.com/jeffdgr8/kotbase/main/
  https://docs.couchbase.com/mobile/3.1.10/couchbase-lite-objc/Protocols/CBLFragment.html)、および [.NET](https://raw.githubusercontent.com/jeffdgr8/kotbase/main/
  https://docs.couchbase.com/mobile/3.1.10/couchbase-lite-net/api/Couchbase.Lite.IFragment.html) と同様に Kotbase で利用可能です。
* Android KTX SDK の設定ファクトリー API は、Kotlin の名前付き引数を直接サポートするコンストラクターの使用を推奨して非推奨となりました。

## 拡張ライブラリ

Kotbase は Couchbase Lite の公式 API の上に便利な拡張を追加のライブラリアーティファクトとして含んでいます。

### Kotbase KTX

[KTX 拡張](https://raw.githubusercontent.com/jeffdgr8/kotbase/main/couchbase-lite-ktx/README.md) には、優れた [MOLO17 による Kotlin 拡張](https://github.com/MOLO17/couchbase-lite-kotlin) と、クエリの作成、クエリ結果のマッピング、ドキュメントの作成、変更の `Flow` の監視などの便利な関数が含まれています。

#### インストール方法




```kotlin
// Community Edition
implementation("dev.kotbase:couchbase-lite-ktx:3.2.4-1.2.0")
// or Enterprise Edition
implementation("dev.kotbase:couchbase-lite-ee-ktx:3.2.4-1.2.0")
```

### Kotbase Kermit

[Kotbase Kermit](https://raw.githubusercontent.com/jeffdgr8/kotbase/main/couchbase-lite-kermit/README.md) は、[Kermit](https://kermit.touchlab.co/) にログを出力する Couchbase Lite のカスタムロガーです。Kermit はログをコンソールを含む任意の数のログ出力先に送ることができます。

#### インストール


```kotlin
// Community Edition
implementation("dev.kotbase:couchbase-lite-kermit:3.2.4-1.2.0")
// or Enterprise Edition
implementation("dev.kotbase:couchbase-lite-ee-kermit:3.2.4-1.2.0")
```

### Kotbase ページング

[ページング拡張機能](https://raw.githubusercontent.com/jeffdgr8/kotbase/main/couchbase-lite-paging/README.md)はGoogleの[AndroidX Paging](https://developer.android.com/topic/libraries/architecture/paging/v3-overview)を基に構築されています。Kotbase Pagingはユーザー提供のデータベースクエリに基づいてlimit/offsetページングクエリを実行する[`PagingSource`](https://developer.android.com/reference/kotlin/androidx/paging/PagingSource)を提供します。

#### インストール




```kotlin
// Community Edition
implementation("dev.kotbase:couchbase-lite-paging:3.2.4-1.2.0")
// or Enterprise Edition
implementation("dev.kotbase:couchbase-lite-ee-paging:3.2.4-1.2.0")
```
## ロードマップ

* [x] ドキュメントサイト ([kotbase.dev](https://kotbase.dev/))
* [x] `NSInputStream` との相互運用 ~~(Okio [#1123](https://github.com/square/okio/pull/1123))~~ (kotlinx-io [#174](
  https://github.com/Kotlin/kotlinx-io/pull/174))
* [x] Linux ARM64 サポート
* [x] 公開リリース
* [ ] サンプルアプリ
    * [x] [はじめに](examples/getting-started)
    * [x] [はじめに Compose Multiplatform](examples/getting-started-compose)
    * [x] [Kotbase Notes](examples/kotbase-notes)
    * [ ] Kotbase Notes 用 SwiftUI
* [x] Couchbase Lite [3.1 API](https://docs.couchbase.com/couchbase-lite/3.1/cbl-whatsnew.html) - スコープとコレクション
* [x] バージョンドキュメント
* [x] Couchbase Lite [3.2 API](https://docs.couchbase.com/couchbase-lite/3.2/cbl-whatsnew.html) - [ベクター検索](
  https://www.couchbase.com/products/vector-search/)
* [ ] Couchbase Lite [3.3 API](https://docs.couchbase.com/couchbase-lite/3.3/cbl-whatsnew.html) - マルチピアレプリケータ
* [ ] Couchbase Lite [4.0 API](https://docs.couchbase.com/couchbase-lite/4.0/cbl-whatsnew.html) - バージョンベクター
* [ ] Linux & MinGW プラットフォームでの URLEndpointListener
* [ ] Swift エクスポート](https://youtrack.jetbrains.com/issue/KT-64572)、`@ObjCName`、および/または `@ShouldRefineInSwift` を使用して Couchbase Lite と Swift API の整合性を向上
* [ ] 非同期コルーチン API

## 開発

* Linux でプロジェクトをビルドする際は、libicu 依存関係を必ずインストールしてください。
* Windows で git リポジトリをチェックアウトする際は、[開発者モード](
  https://learn.microsoft.com/en-us/windows/apps/get-started/enable-your-device-for-development) を有効にし、
  git でシンボリックリンクを `git config --global core.symlinks true` で有効にしてください。




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-20

---