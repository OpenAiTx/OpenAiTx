# React Native Passkeys

これは、iOS、Android、Webで同じAPIを使ってパスキーを作成および認証するためのExpoモジュールです。ライブラリは標準の[`navigator.credentials`](https://w3c.github.io/webappsec-credential-management/#framework-credential-management)に近い設計を目指しています。具体的には、クロスプラットフォームで利用可能な`get`と`create`関数のAPIを提供します。

私たちが行う適応は、base64-urlエンコードされた文字列をバッファに自動変換するなどの簡単な工夫です。これはネイティブ側に値を渡しやすくするためでもあります。

さらに、特定の機能のサポートを示すフラグ関数などの便利な機能も含まれています。

## インストール

```sh
npx expo install react-native-passkeys
```

## iOS セットアップ

#### 1. Apple App Site Association (AASA) ファイルをホストする

iOSでパスキーを機能させるには、ドメイン上にAASAファイルをホストする必要があります。 このファイルは、あなたのアプリが認証しようとしているドメインを扱うことが許可されていることを検証するために使用されます。 有効なSSL証明書を持つサイトでホストする必要があります。

ファイルは次の場所にホストする必要があります：

```
https://<your_domain>/.well-known/apple-app-site-association
```
  
このファイルには `.json` 拡張子はありませんが、形式はjsonです。ファイルの内容は次のようなものになります。  
  
```json
{
  "webcredentials": {
    "apps": ["<teamID>.<bundleID>"]
  }
}
```

`<teamID>` をあなたの Apple チームIDに、`<bundleID>` をあなたのアプリのバンドル識別子に置き換えてください。

#### 2. 関連ドメインの追加

以下をあなたの `app.json` に追加してください：

```json
{
  "expo": {
    "ios": {
      "associatedDomains": ["webcredentials:<your_domain>"]
    }
  }
}
```

`<your_domain>` を AASA ファイルをホストしているドメインに置き換えてください。例えば、AASA ファイルを `https://example.com/.well-known/apple-app-site-association` にホストしている場合は、`associatedDomains` 配列に `example.com` を追加します。

#### 3. 最小デプロイメントターゲットの追加

以下を `app.json` に追加してください：

```json
{
  "expo": {
    "plugins": [
      [
        "expo-build-properties",
        {
          "ios": {
            "deploymentTarget": "15.0"
          }
        }
      ]
    ]
  }
}
```

#### 4. アプリを事前構築して実行する

```sh
npx expo prebuild -p ios
npx expo run:ios # or build in the cloud with EAS
```

## Android セットアップ

#### 1. `assetlinks.json` ファイルをホストする

Passkeys を Android で動作させるには、ドメイン上に `assetlinks.json` ファイルをホストする必要があります。 このファイルは、アプリが認証しようとしているドメインを処理する許可があることを検証するために使用されます。 有効な SSL 証明書を持つサイトでホストする必要があります。

ファイルは以下の場所にホストする必要があります：

```
https://<your_domain>/.well-known/assetlinks.json
```
そして、このような形になります（[Android Asset Links Assistant](https://developers.google.com/digital-asset-links/tools/generator)を使ってこのファイルを生成できます）：


```json
[
  {
    "relation": ["delegate_permission/common.handle_all_urls"],
    "target": {
      "namespace": "android_app",
      "package_name": "<package_name>",
      "sha256_cert_fingerprints": ["<sha256_cert_fingerprint>"]
    }
  }
]
```

`<package_name>` をアプリのパッケージ名に、`<sha256_cert_fingerprint>` をアプリの SHA256 証明書のフィンガープリントに置き換えてください。

#### 2. Expo ビルドプロパティの変更

次に、`app.json` の `compileSdkVersion` を少なくとも 34 に変更する必要があります。

```json
{
  "expo": {
    "plugins": [
      [
        "expo-build-properties",
        {
          "android": {
            "compileSdkVersion": 34
          }
        }
      ]
    ]
  }
}
```

#### 3. アプリを事前構築して実行する

```sh
npx expo prebuild -p android
npx expo run:android # or build in the cloud with EAS
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-25

---