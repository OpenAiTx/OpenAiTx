<img src="https://raw.githubusercontent.com/vodemn/m3_lightmeter/main/resources/social_preview.png" width="100%" />

![](https://github.com/vodemn/m3_lightmeter/actions/workflows/pr_check.yml/badge.svg)
![](https://github.com/vodemn/m3_lightmeter/actions/workflows/create_release.yml/badge.svg)

# 目次

- [目次](#table-of-contents)
- [背景](#backstory)
- [スクリーンショット](#screenshots)
- [開発](#development)
- [サポート](#support)
- [iOSの制限](#ios-limitations)

# 背景

しばらく前に[Material Lightmeter](https://play.google.com/store/apps/details?id=com.vodemn.lightmeter&hl=en&gl=US)アプリの開発を始めました。残念ながら、このアプリの最後のアップデートはこのリポジトリ作成のほぼ1年前でした。Google Playの好意的なレビューで「素晴らしいアプリですが、もう更新されていないのが残念です」とあったのを読んで、アップデートを行い、このアプリをオープンソースにしようと決めました。もしかすると誰かがいつかこのプロジェクトに貢献してくれるかもしれません。

しかし、既存のリポジトリには経験不足でプッシュしてしまった機密データが含まれていたため、新しいリポジトリを作らなければなりませんでした。そして新しいリポジトリを作るなら、アプリを一から書き直そうと考えました。

それでは、Material You（別名M3）に触発された新しいLightmeterアプリをご覧ください。

# スクリーンショット

<p float="center">
  <img src="https://raw.githubusercontent.com/vodemn/m3_lightmeter/main/screenshots/generated/ios/iphone65inch/light_metering-reflected.png" width="18.8%" />
  <img src="https://raw.githubusercontent.com/vodemn/m3_lightmeter/main/screenshots/generated/ios/iphone65inch/light_equipment-profiles.png" width="18.8%" />
  <img src="https://raw.githubusercontent.com/vodemn/m3_lightmeter/main/screenshots/generated/ios/iphone65inch/light_settings.png" width="18.8%" />
  <img src="https://raw.githubusercontent.com/vodemn/m3_lightmeter/main/screenshots/generated/ios/iphone65inch/light_timer.png" width="18.8%" />
  <img src="https://raw.githubusercontent.com/vodemn/m3_lightmeter/main/screenshots/generated/ios/iphone65inch/dark_metering-reflected.png" width="18.8%" />
</p>

# 開発

### 1. Flutterのインストール

このアプリをビルドするにはFlutter 3.24.5 stableをインストールする必要があります。[インストール方法](https://docs.flutter.dev/get-started/install)。

### 2. プロジェクトのセットアップ

#### gitで無視されたファイルの復元：

macOSの場合は以下のスクリプトを実行するだけです：

```console
sh scripts/setup_fork.sh
```
スクリプトの内容を使ってファイルを手動で作成することもできます。

#### 依存関係の取得

> VSCodeを使用している場合は、次のようにワークスペースを開くことができます：_ファイル -> ファイルからワークスペースを開く -> m3_lightmeter.code-workspace_。それ以外の場合は、iapフォルダから`flutter pub get`コマンドを実行する必要があります。

次に、以下のコマンドを実行して必要な依存関係をすべて取得し、翻訳ファイルを生成できます：


```console
flutter pub get
flutter pub run intl_utils:generate
```
### 3. ビルド

- Android用の[Build .apk](https://raw.githubusercontent.com/vodemn/m3_lightmeter/main/.github/workflows/build_apk.yml)ワークフローを確認してください
- iOS用の[Build .ipa](https://raw.githubusercontent.com/vodemn/m3_lightmeter/main/.github/workflows/build_ipa.yml)ワークフローを確認してください

# サポート

バグを報告したり新機能を提案するには、新しい[issue](https://github.com/vodemn/m3_lightmeter/issues)を開いてください。プロジェクトに貢献する場合は、自由にプルリクエストを開いてください。ただし、この[スタイルガイド](https://raw.githubusercontent.com/vodemn/m3_lightmeter/main/doc/style_guide.md)に従う必要があります。

その他の質問がある場合は、[メール](https://raw.githubusercontent.com/vodemn/m3_lightmeter/main/mailto:contact.vodemn@gmail.com?subject="Lightmeter")でご連絡ください。

# iOSの制限

Android版のアプリにはあるがiOSにはない機能のリストです。

## 入射光測定

Appleは周囲光センサーからのルクスストリームを読み取るAPIを提供していません。ルクスはフロントカメラの画像ストリームに基づいて計算できますが、これは反射光となります。したがって、iOSで入射光測定を実装する方法はありません。

## 音量ボタンの動作

これは[実装可能](https://stackoverflow.com/questions/70161271/ios-override-hardware-volume-buttons-same-as-zello)ですが、アプリは[2.5.9](https://developer.apple.com/app-store/review/guidelines/#software-requirements)により却下されます。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-24

---