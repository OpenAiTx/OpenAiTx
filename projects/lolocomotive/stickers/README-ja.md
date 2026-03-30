# ステッカー

広告なしのシンプルなWhatsApp用Androidステッカー作成アプリ。

[![](https://upload.wikimedia.org/wikipedia/commons/7/78/Google_Play_Store_badge_EN.svg)](https://play.google.com/store/apps/details?id=de.loicezt.stickers)

または最新の[GitHubリリース](https://github.com/lolocomotive/stickers/releases)からダウンロード

## 機能

- クイックモード: 画像をアプリに共有すると自動的にWhatsAppに追加される
- エディター
    - ステッカーを好きなだけトリミング
    - サイズ、フォント、色を変えたテキストを追加
    - 色やブラシサイズの異なる描画、元に戻す/やり直し対応
    - 各要素は独自のレイヤーを持ち、テキストの上や下に描画可能
- インポート/エクスポート
    - `.zip`形式でパックを共有やバックアップ可能
    - さまざまな形式からインポート（独自の`.zip`形式、`.wastickers`、`.stickify`など、ほとんどが画像と簡単なマニフェストを含むZIPファイルなので他も追加しやすい）
- 複数のパックとそのメタデータ（作者、タイトル、トレイアイコンなど）を作成、編集、削除可能

## スクリーンショット

| ホーム                             | パックビュー                      | エディター                             |
|-----------------------------------|-----------------------------------|---------------------------------------|
| ![home.png](https://raw.githubusercontent.com/lolocomotive/stickers/main/screenshots/home.png) | ![pack.png](https://raw.githubusercontent.com/lolocomotive/stickers/main/screenshots/pack.png) | ![editor.png](https://raw.githubusercontent.com/lolocomotive/stickers/main/screenshots/editor.png) |

## ビルド

`flutter run` で問題なく動作しますが、リリース版をビルドしたい場合は次のいずれかが必要です：

<details>
<summary>独自の署名キーを使用する</summary>

`android/` に `key.properties` を作成し、



```properties
storeFile=path/to/keystore.jks
keyAlias=your key alias
storePassword=your store password
keyPassword=your key password
```

詳細はこちら: https://docs.flutter.dev/deployment/android#sign-the-app

</details>

または

<details>
<summary>デバッグ署名設定を使用する</summary>

`android/app/build.gradle` の29行目付近で

```
buildTypes {
  release {
    signingConfig signingConfigs.release
  }
}
```

`signingConfigs.release` を `signingConfigs.debug` に置き換え、削除してください

```
def keystoreProperties = new Properties()
def keystorePropertiesFile = rootProject.file("key.properties")
if (keystorePropertiesFile.exists()) {
    keystorePropertiesFile.withReader('UTF-8') { reader ->
        keystoreProperties.load(reader)
    }
}
```

and

```
signingConfigs {
    create("release") {
        keyAlias = keystoreProperties["keyAlias"]
        keyPassword = keystoreProperties["keyPassword"]
        storeFile = new File(keystoreProperties["storeFile"])
        storePassword = keystoreProperties["storePassword"]
    }
}
```
そして、それは*動作するはず*です、テスト用にのみ使用してください。
</details>

そして、次にあなたがする必要があるのは


```
flutter build apk
```

## 貢献について

プルリクエスト、機能要望、バグ報告など、どんな貢献も大歓迎です！
私の行幅は80ではなく120に設定しているので、ファイル全体を再フォーマットする際は注意してください。
vscodeを使用している場合は、`.vscode/settings.json` に以下を設定してください。

```json
{
  "dart.lineLength": 120,
  "[dart]": {
    "editor.rulers": [
      120
    ]
  }
}
```
また、コードはまだあまりよくドキュメント化されていないため、読もうとする方にはあらかじめお詫びします。

## TODO

将来的に取り組む予定の機能

- [ ] ホーム画面で複数のパックを同時に選択する機能
- [ ] テキストに背景を追加するオプションを追加
- [ ] ステッカーの画像レイヤー
- [ ] 既存のステッカーから開始
- [ ] GIFからアニメーションステッカーを作成
- [ ] ビデオのトリミングと回転

## iOSサポート

私はApple製品を所有していないため、iOS向けのビルドやiOSアプリのテストはできません。Flutter製の
アプリなので、だいたい動くはずです。
iOSサポートを追加したい場合は歓迎します！以下の点に注意してください：

- `image_editor`はiOSでWEBPをサポートするように修正する必要があります（私はAndroidでのみ
  WEBPサポートを追加しました）
- `whatsapp_stickers_plus`パッケージは動作しない可能性があります（Androidでは動きませんでした）。
- iOSアプリのように見せたい場合、多くのウィジェットを`.adaptive`相当のものに置き換える必要があります




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-30

---