[![Electron ロゴ](https://electronjs.org/images/electron-logo.svg)](https://electronjs.org)

[![GitHub Actions ビルドステータス](https://github.com/electron/electron/actions/workflows/build.yml/badge.svg)](https://github.com/electron/electron/actions/workflows/build.yml)
[![Electron Discord 招待](https://img.shields.io/discord/745037351163527189?color=%237289DA&label=chat&logo=discord&logoColor=white)](https://discord.gg/electronjs)

:memo: 利用可能な翻訳: 🇨🇳 🇧🇷 🇪🇸 🇯🇵 🇷🇺 🇫🇷 🇺🇸 🇩🇪  
他の言語でこれらのドキュメントを閲覧するには [Crowdin](https://crowdin.com/project/electron) プロジェクトをご覧ください。

Electron フレームワークは、JavaScript、HTML、CSS を使ってクロスプラットフォームのデスクトップアプリケーションを作成できます。[Node.js](https://nodejs.org/) および [Chromium](https://www.chromium.org) をベースとしており、[Visual Studio Code](https://github.com/Microsoft/vscode/) やその他多くの[アプリ](https://electronjs.org/apps)で利用されています。

重要なお知らせは Twitter の [@electronjs](https://twitter.com/electronjs) をフォローしてください。

このプロジェクトは Contributor Covenant の [行動規範](https://github.com/electron/electron/tree/main/CODE_OF_CONDUCT.md) を遵守しています。参加する際は、この規範を守ることが求められます。不適切な行動は [coc@electronjs.org](mailto:coc@electronjs.org) までご報告ください。

## インストール

事前ビルド済みの Electron バイナリをインストールするには [`npm`](https://docs.npmjs.com/) を使用します。推奨される方法は、Electron を開発依存としてあなたのアプリにインストールすることです:

```sh
npm install electron --save-dev
```

その他のインストールオプションやトラブルシューティングについては[インストールガイド](docs/tutorial/installation.md)をご覧ください。アプリでの Electron バージョン管理については [Electron バージョニング](docs/tutorial/electron-versioning.md) を参照してください。

## プラットフォームサポート

各 Electron リリースでは macOS、Windows、Linux 向けのバイナリを提供しています。

* macOS（Big Sur 以降）：Electron は macOS 向けに 64-bit Intel および Apple Silicon / ARM バイナリを提供します。
* Windows（Windows 10 以降）：Electron は Windows 向けに `ia32`（`x86`）、`x64`（`amd64`）、`arm64` バイナリを提供します。Windows on ARM のサポートは Electron 5.0.8 で追加されました。Windows 7、8、8.1 のサポートは [Chromium の Windows 非推奨ポリシーに従い、Electron 23 で削除されました](https://www.electronjs.org/blog/windows-7-to-8-1-deprecation-notice)。
* Linux：Electron の事前ビルドバイナリは Ubuntu 20.04 上でビルドされています。また、以下のディストリビューションで動作確認されています:
  * Ubuntu 18.04 以降
  * Fedora 32 以降
  * Debian 10 以降

## Electron Fiddle

[`Electron Fiddle`](https://github.com/electron/fiddle) を使うと、小規模な Electron 実験のビルド、実行、パッケージ化、すべての Electron API のコード例の確認、異なるバージョンの Electron の試用ができます。Electron の入門をより簡単にするために設計されています。

## Electron 学習リソース

* [electronjs.org/docs](https://electronjs.org/docs) - Electron の全ドキュメント
* [electron/fiddle](https://github.com/electron/fiddle) - 小規模な Electron 実験をビルド、実行、パッケージ化するツール
* [electronjs.org/community#boilerplates](https://electronjs.org/community#boilerplates) - コミュニティによるサンプルスターターアプリ

## プログラムによる利用

ほとんどの人はコマンドラインから Electron を利用しますが、**Node アプリ**（Electron アプリではなく）で `electron` を require すると、バイナリへのファイルパスが返されます。これを使って Node スクリプトから Electron を起動できます:

```javascript
const electron = require('electron')
const proc = require('node:child_process')

// 例: /Users/maf/.../Electron のようなパスを出力
console.log(electron)

// Electron を起動
const child = proc.spawn(electron)
```

### ミラー

* [中国](https://npmmirror.com/mirrors/electron/)

カスタムミラーの使い方については[高度なインストール手順](https://www.electronjs.org/docs/latest/tutorial/installation#mirror)を参照してください。

## ドキュメント翻訳

ドキュメントの翻訳は [Crowdin](https://crowdin.com/project/electron) を通じてクラウドソーシングされています。現在、中国語（簡体字）、フランス語、ドイツ語、日本語、ポルトガル語、ロシア語、スペイン語の翻訳を受け付けています。

## コントリビューション

問題の報告・修正やコードベースへの直接的な貢献にご興味がある方は、詳細と開始方法について [CONTRIBUTING.md](CONTRIBUTING.md) をご覧ください。

## コミュニティ

バグ報告、ヘルプの取得、サードパーティ製ツールやサンプルアプリの発見などの情報は [コミュニティページ](https://www.electronjs.org/community) にあります。

## ライセンス

[MIT](https://github.com/electron/electron/blob/main/LICENSE)

Electron のロゴを使用する場合は、[OpenJS Foundation 商標ポリシー](https://trademark-policy.openjsf.org/)に従ってください。

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---