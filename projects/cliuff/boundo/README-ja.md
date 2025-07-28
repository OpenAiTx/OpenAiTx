<p align="center">
  <img src="https://raw.githubusercontent.com/cliuff/boundo/main/doconfig/markdown/shot1.png" width="270" alt="スクリーンショット 1">
  <img src="https://raw.githubusercontent.com/cliuff/boundo/main/doconfig/markdown/shot2.png" width="270" alt="スクリーンショット 2">
  <img src="https://raw.githubusercontent.com/cliuff/boundo/main/doconfig/markdown/shot3.png" width="270" alt="スクリーンショット 3">
</p>

# Boundo メタアプリ：情報 & マネージャー

Boundo メタアプリはあなたのアプリとその先すべてに関するものです。  
電話内のアプリ情報を確認し、カテゴリに整理しましょう。  
Android愛好家向けに設計され、Meta-appは**Android**および**Wear OS**で利用可能です。

### 1. 開発
**1.1 必要条件**
- Android Studio `Meerkat` (AGP `8.9`)
- Java `17`、Kotlin `2.1.21`、Gradle `8.13`

**1.2 自動署名の設定**
- `doconfig`ディレクトリ内の`custom.properties.template`ファイルを**コピー**し、  
  `custom.properties`に**名前を変更**して必要な**変更**を加える

**1.3 ユニバーサルAPKのビルド（アプリAPI機能含む、リリースバリアント）**
- セクション1.2で指定された署名設定を行う
- [BundleTool Releases](https://github.com/google/bundletool/releases)からBundleToolのバイナリをダウンロードし、  
  このプロジェクトの`doconfig/bundletool.jar`として保存する
- コマンドラインからGradleタスクを実行 `gradlew :app:genUniversalApks`
- このプロジェクト内の`app/build/outputs/app-universal-release.apks`を確認する

**1.4 FOSS版のビルド（機能制限あり）**
- セクション1.2で指定された署名設定を行う
- [BundleTool Releases](https://github.com/google/bundletool/releases)からBundleToolのバイナリをダウンロードし、  
  このプロジェクトの`doconfig/bundletool.jar`として保存する
- コマンドラインからGradleタスクを実行 `gradlew :app:genFossApks`
- このプロジェクト内の`app/build/outputs/app-universal-foss.apks`を確認する

### 2. ダウンロード
[<img alt='Google Playで入手' src='https://play.google.com/intl/en_us/badges/static/images/badges/en_badge_web_generic.png' height='100'/>](https://raw.githubusercontent.com/cliuff/boundo/main/
https://play.google.com/store/apps/details?id=com.madness.collision&pcampaignid=pcampaignidMKT-Other-global-all-co-prtnr-py-PartBadge-Mar2515-1)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-28

---