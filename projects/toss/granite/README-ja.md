# Granite &middot; [![Apache 2.0 License](https://img.shields.io/badge/license-Apache-blue.svg)](https://github.com/toss/slash/blob/main/LICENSE) [![NPM badge](https://img.shields.io/npm/v/@granite-js/react-native?logo=npm)](https://www.npmjs.com/package/@granite-js/react-native) [![codecov](https://codecov.io/gh/toss/granite/graph/badge.svg?token=LCP519I5BN)](https://codecov.io/gh/toss/granite)

Graniteは、ブラウンフィールド統合、200KBのバンドルサイズ、およびAWS対応インフラストラクチャを備えたマイクロサービスアプリ向けのエンタープライズグレードのReact Nativeフレームワークです。

- **既存のアプリにReact Nativeを追加** - 現在のiOSおよびAndroidアプリにReact Native画面を簡単に統合。
- **小さなバンドル** - バンドル分割とスマートな最適化により、200KBの小さなマイクロサービスバンドルを作成。
- **高速ビルド** - ESBuildを使用してJavaScriptバンドルのビルド時間を数秒に抑制。
- **完全なAWSセットアップ** - フルデプロイメント制御を備えた完全なインフラ構成。
- **ワンクリックインフラ** - CLIコマンド一つでCDNとインフラをセットアップ。
- **シンプルなデフォルト設定** - 事前設定によりセットアップではなく開発に集中可能。
- **包括的なエンドツーエンドテスト** - すべての機能にエンドツーエンドテストが付属。
- **高速ネイティブビルド** - プリビルトフレームワークでネイティブビルド時間を短縮。（作業中）

## はじめに

Graniteの使用開始は簡単です。まず、CLIを使って新しいGraniteアプリを作成しましょう：

```sh
npx create-granite-app@latest
```
React Nativeコンポーネントを書き終えたら、単一のコマンドでアプリをビルドします：


```sh
npm run granite build
```
### インフラストラクチャのセットアップ

Graniteはインフラストラクチャのセットアップを簡単にするために[Pulumi](https://www.pulumi.com/)を使用しています。  
`@granite-js/pulumi-aws`を使った数行のコードで、React Nativeのインフラ全体をAWSにデプロイできます:

```typescript
import * as pulumi from '@pulumi/pulumi';
import * as aws from '@pulumi/aws';
import { ReactNativeBundleCDN } from '@granite-js/pulumi-aws';

const config = new pulumi.Config();

new ReactNativeBundleCDN('myReactNativeBundleCDN', {
  bucketName: config.require('bucketName'),
  region: config.require('region'),
});
```
### アプリのデプロイ

単一のコマンドでアプリを本番環境にデプロイします。Forgeが残りの作業を処理します - バンドルのアップロードとCDNへの配置。


```sh
npm run granite-forge deploy --bucket your-s3-bucket-name
```
簡単なステップバイステップガイドについては、当社の[はじめにガイド](https://granite.run/guides/quick-start/create-your-app.html)をご覧ください。

## 貢献について

コミュニティの皆様からの貢献を歓迎します。詳細な貢献ガイドは以下をご覧ください。

[CONTRIBUTING](https://github.com/toss/granite/blob/main/.github/CONTRIBUTING.md)

## ライセンス

Apache 2.0 © Viva Republica, Inc. 詳細は[LICENSE](./LICENSE)をご参照ください。

<a title="Toss" href="https://toss.im">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://static.toss.im/logos/png/4x/logo-toss-reverse.png">
    <img alt="Toss" src="https://static.toss.im/logos/png/4x/logo-toss.png" width="100">
  </picture>
</a>



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-14

---