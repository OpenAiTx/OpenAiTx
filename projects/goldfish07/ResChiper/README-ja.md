# ResChiper

<h1 align="center">
  <img src="https://raw.githubusercontent.com/goldfish07/ResChiper/release/0.1.0-rc6/artifacts/reschiper-banner.png" alt="failed to load artifacts/logo.png"/>
  <p align="center" style="font-size: 0.3em">AABリソース難読化ツール</p>
</h1>

[![License](https://img.shields.io/badge/license-Apache_2.0-maroon)](LICENSE)
![Android Gradle Plugin](https://img.shields.io/badge/Dependency-AGP/8.8.0-4CAF50)
[![BundleTool](https://img.shields.io/badge/Dependency-Bundletool/1.17.2-red)](https://github.com/google/bundletool)
![JDK Version](https://img.shields.io/badge/JDK-17-blue)
![Gradle Version](https://img.shields.io/badge/Gradle_Wrapper-8.8-darkgreen)
[![ResChiper Version](https://img.shields.io/badge/release-0.1.0--rc6-%23C6782A.svg?style=flat)](https://github.com/goldfish07/ResChiper/releases/tag/0.1.0-rc6)

## 目次

- [はじめに](#introduction)
- [始め方](#getting-started)
    - [要件](#requirements)
    - [インストール](#installation)
    - [使い方](#usage)
- [設定オプション](#configuration-options)
- [例](#example)
- [ホワイトリスト](#whitelist)
- [出力](#output)
- [謝辞](#acknowledgments)
- [ライセンス](#license)

## はじめに

ResChiperはAndroid AABリソースの難読化を目的としたツールです。
リソースの不正アクセスを防ぎ、アプリのAABサイズを削減することができます。

## 始め方

この手順に従って、AndroidプロジェクトにAABリソース難読化ツールを統合してください。

## 要件

ResChiperを使用する前に、アプリが以下の要件を満たしていることを確認してください。

- **Java開発キット（JDK）**：ResChiperはJDK 17を必要とします。アプリがJDK 17で設定されていることを確認してください。
- **Android Gradleプラグイン（AGP）**：バージョン8.0以降。

## インストール

#### 1. ResChiper Gradleプラグインを追加

プロジェクトのルートレベルの`build.gradle`ファイルの`buildscript`セクションにResChiper Gradleプラグインを追加します：

```gradle
buildscript {
  dependencies {
    classpath "io.github.goldfish07.reschiper:plugin:<latest_version>"
  }
  
  repositories {
    mavenCentral()
    google()
   }
}
```

#### 2. プラグインの適用

アプリレベルの `build.gradle` ファイルで、ResChiper プラグインを適用します:

```gradle
apply plugin: "io.github.goldfish07.reschiper"
```

#### 3. プラグインの設定

`app/build.gradle` ファイルで、ResChiper プラグインを設定し、希望する設定を指定します。以下は設定例です：


```gradle
resChiper {
    enableObfuscation = true //by default res obfuscate is enabled
    obfuscationMode = "default" //["dir", "file", "default"]
    obfuscatedBundleName = "reschiper-app.aab" // Obfuscated file name, must end with '.aab'
    //mappingFile = file("path/to/your/mapping.txt").toPath() // Mapping file used for incremental obfuscation
    whiteList = [
                  //Whitelist rule (directory name to exclude)
                  "res/raw", // raw dir will not be obfuscated
                  "res/xml", // xml dir will not be obfuscated

                  //Whitelist rule (file name to exclude)
                  "res/raw/*", // all files inside raw directory will not be obfuscated
                  "res/raw/success_tick.json", // success_tick.json file will not be obfuscated
                  "res/xml/*", // all files inside xml directory will not be obfuscated

                  // White list rules (resource name to exclude)
                  "*.R.raw.*",
                  "*.R.xml.*",

                  // for google-services
                  "*.R.string.google_api_key",
                  "*.R.string.google_app_id",
                  "*.R.string.default_web_client_id",
                  "*.R.string.gcm_defaultSenderId",
                  "*.R.string.ga_trackingId",
                  "*.R.string.firebase_database_url",
                  "*.R.string.google_crash_reporting_api_key",
                  "*.R.string.google_storage_bucket",
                  "*.R.integer.google_play_services_version",
                  
                  //firebase
                  "*.R.string.project_id",
                  //firebase crashlytics
                  "*.R.string.com.google.firebase.crashlytics.mapping_file_id",
                  "*.R.bool.com.crashlytics.useFirebaseAppId",
                  "*.R.string.com.crashlytics.useFirebaseAppId",
                  "*.R.string.google_app_id",
                  "*.R.bool.com.crashlytics.CollectDeviceIdentifiers",
                  "*.R.string.com.crashlytics.CollectDeviceIdentifiers",
                  "*.R.bool.com.crashlytics.CollectUserIdentifiers",
                  "*.R.string.com.crashlytics.CollectUserIdentifiers",
                  "*.R.string.com.crashlytics.ApiEndpoint",
                  "*.R.string.com.crashlytics.android.build_id",
                  "*.R.bool.com.crashlytics.RequireBuildId",
                  "*.R.string.com.crashlytics.RequireBuildId",
                  "*.R.bool.com.crashlytics.CollectCustomLogs",
                  "*.R.string.com.crashlytics.CollectCustomLogs",
                  "*.R.bool.com.crashlytics.Trace",
                  "*.R.string.com.crashlytics.Trace",
                  "*.R.string.com.crashlytics.CollectCustomKeys"
    ]
    mergeDuplicateResources = true // allow the merge of duplicate resources
    enableFileFiltering = true
    enableFilterStrings = true
    fileFilterList = [ // file filter rules
                         "META-INF/*",
//                       "*/armeabi-v7a/*",
//                       "*/arm64-v8a/*",
//                       "*/x86/*",
//                       "*/x86_64/*"
    ]
    unusedStringFile = "path/to/your/unused_strings.txt" // strings will be filtered in this file
    localeWhiteList = ["en", "in", "fr"] //keep en,en-xx,in,in-xx,fr,fr-xx and remove others locale.
}
```

## 使い方

リソースを難読化し、難読化されたAABを生成するには、プロジェクトのルートディレクトリで以下のGradleコマンドを実行してください。:


```cmd
./gradle clean :app:resChiperDebug --stacktrace
```
このコマンドはプロジェクトのルートから難読化プロセスを実行し、難読化されたAABは
`app/build/outputs/bundle/debug` ディレクトリに生成されます。

## 設定オプション

ResChiper拡張機能は、リソース難読化のための様々な設定オプションを提供しており、難読化の有効/無効、
マッピングファイルの指定、リソースのホワイトリスト設定などが含まれます。

- `enableObfuscation`: リソース難読化の有効化または無効化。<br>
- `obfuscationMode`: ディレクトリのみを難読化する場合は `obfuscationMode = "dir"`、ファイルのみを難読化する場合は
  `obfuscationMode = "file"`、ディレクトリとファイルの両方を難読化する場合は `obfuscationMode = "default"` を設定します。<br>
- `enableFilterStrings`: 未使用のファイルスプリットを行単位で入力し、文字列の削除をサポート。<br>
- `enableFileFiltering`: バンドルパッケージ内のファイルフィルタリングをサポート。現在は `META-INFO/` と `lib/` パスのみ対応。<br>
- `obfuscatedBundleName`: 難読化されたAABファイルの名前。<br>
- `mergeDuplicateResources`: 重複するリソースファイルを排除し、パッケージサイズを削減。<br>
- `mappingFile`: ProGuardのマッピングファイルへのパス（難読化にmapping.txtを使用する場合のみ設定）。<br>
- `whiteList`: 難読化から除外するリソース名のセット。<br>
- `fileFilterList`: 除外するファイルパターンのリスト。<br>
- `unusedStringFile`: 未使用文字列を含むファイルへのパス。<br>
- `localeWhiteList`: AABに含めるロケールのセット。

## 例

設定例の一部は[こちら](https://github.com/goldfish07/ResChiper/wiki/Example-Configuration-Options)で確認できます。

## ホワイトリスト

ビルドプロセス中に難読化されないリソースです。<br>
ホワイトリストの設定は[こちら](https://github.com/goldfish07/ResChiper/wiki/WhiteList)で確認可能です。

## 出力

難読化プロセスの実行後、以下の出力ファイルが生成されます：

- **aab:** 難読化されたバンドルパッケージで、難読化されたリソースを含むAndroid App Bundle (AAB)です。
- **resources-mapping.txt:** リソース難読化のマッピングが記録されたファイルです。将来の難読化プロセスの入力として使用でき、
  インクリメンタルな難読化を実現します。これは、継続的に管理したい場合に特に有用です。



  異なるビルド間での一貫性を確保します。
- **-duplicated.txt:** このログファイルはマージされたリソースに関する情報を提供します。難読化プロセス中にマージされた
  重複リソースを特定し追跡するのに役立ちます。

これらの出力ファイルはResChiperツールを実行した結果生成され、プロジェクトのビルド出力内の該当ディレクトリに
配置されます。

## 謝辞

ResChiperは以下のプロジェクトおよびツールに触発されています：

* [AabResGuard](https://github.com/bytedance/AabResGuard/)
* [AndResGuard](https://github.com/shwenzhang/AndResGuard/)
* [BundleTool](https://github.com/google/bundletool)

## ライセンス

[![Apache License v2.0 logo](https://raw.githubusercontent.com/goldfish07/ResChiper/release/0.1.0-rc6/artifacts/apache-licence-logo.png)](https://www.apache.org/licenses/LICENSE-2.0.txt)

    Copyright (C) 2023 goldfish07 (Ayush Bisht) <ayushbisht5663@gmail.com>
    本ファイルはResChiperの一部です。

    ResChiperはフリーソフトウェアです。Apache License バージョン2.0に基づき、
    再配布および改変が可能です。ライセンスはApache Software Foundationにより
    公開されており、バージョン2.0またはそれ以降の任意のバージョンを適用できます。

    Apache License バージョン2.0（「ライセンス」）の条件に従いライセンスされており、
    本ファイルを使用する際はライセンスに従う必要があります。
    ライセンスの全文は以下のURLから入手可能です。

        http://www.apache.org/licenses/LICENSE-2.0

    適用法令により要求される場合や書面での合意がない限り、
    本ソフトウェアは「現状のまま」提供され、明示または黙示の保証は一切ありません。
    ライセンスに基づく特定の権利および制限についてはライセンス文書を参照してください。




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-02

---