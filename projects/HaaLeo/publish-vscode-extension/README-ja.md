# VS Code 拡張機能の公開 — GitHub Action

[![Build, Lint, Test and Deploy](https://img.shields.io/github/actions/workflow/status/HaaLeo/publish-vscode-extension/CI.yml?style=flat-square&label=Lint%2C%20Build%2C%20Test%20and%20Deploy)](https://github.com/HaaLeo/publish-vscode-extension/actions?query=workflow%3A%22Build%2C+Lint%2C+Test+and+Deploy%22) [![Coverage Status](https://img.shields.io/coveralls/github/HaaLeo/publish-vscode-extension?style=flat-square)](https://coveralls.io/github/HaaLeo/publish-vscode-extension)  
[![License](https://img.shields.io/badge/license-MIT-brightgreen.svg?style=flat-square)](https://raw.githubusercontent.com/HaaLeo/publish-vscode-extension/master/LICENSE.txt) [![Stars](https://img.shields.io/github/stars/HaaLeo/publish-vscode-extension.svg?label=Stars&logo=github&style=flat-square)](https://github.com/HaaLeo/publish-vscode-extension/stargazers)  
[![Donate](https://img.shields.io/badge/☕️-Buy%20Me%20a%20Coffee-blue.svg?&style=flat-square)](https://www.paypal.me/LeoHanisch/3eur)

VS Code 拡張機能を [Open VSX Registry](https://open-vsx.org/) または [Visual Studio Marketplace](https://marketplace.visualstudio.com) に公開するための GitHub Action。

> **v2** のすべての破壊的変更は [changelog](https://raw.githubusercontent.com/HaaLeo/publish-vscode-extension/master/CHANGELOG.md#changelog) に記載されています

## 使い方

GitHub Action を使用するには、ワークフローファイル内で単に [アクションを参照](https://help.github.com/en/actions/configuring-and-managing-workflows/configuring-a-workflow#referencing-actions-in-your-workflow) してください。

### 例

以下の例は、新しいタグが作成されたときに Open VSX Registry と Visual Studio Marketplace の両方に拡張機能を公開するワークフローを示しています：

```yaml
on:
  push:
    tags:
      - "*"

name: Deploy Extension
jobs:
  deploy:
    runs-on: ubuntu-latest
    steps:
      - uses: actions/checkout@v4
      - uses: actions/setup-node@v4
        with:
          node-version: 20
      - run: npm ci
      - name: Publish to Open VSX Registry
        uses: HaaLeo/publish-vscode-extension@v2
        with:
          pat: ${{ secrets.OPEN_VSX_TOKEN }}
      - name: Publish to Visual Studio Marketplace
        uses: HaaLeo/publish-vscode-extension@v2
        with:
          pat: ${{ secrets.VS_MARKETPLACE_TOKEN }}
          registryUrl: https://marketplace.visualstudio.com
```
拡張機能を一度だけパッケージ化し、**同一の** `.vsix` ファイルを両方のレジストリに公開するには、代わりに以下の2つの手順を使用できます：


```yaml
- name: Publish to Open VSX Registry
  uses: HaaLeo/publish-vscode-extension@v2
  id: publishToOpenVSX
  with:
    pat: ${{ secrets.OPEN_VSX_TOKEN }}
- name: Publish to Visual Studio Marketplace
  uses: HaaLeo/publish-vscode-extension@v2
  with:
    pat: ${{ secrets.VS_MARKETPLACE_TOKEN }}
    registryUrl: https://marketplace.visualstudio.com
    extensionFile: ${{ steps.publishToOpenVSX.outputs.vsixPath }}
```
より完全で複雑な例については、[`HaaLeo/vscode-timing`](https://github.com/HaaLeo/vscode-timing/blob/master/.github/workflows/cicd.yml#L1) のワークフローを参照してください。

### Open VSX レジストリ

Open VSX レジストリに公開するには、[拡張機能の名前空間](https://github.com/eclipse/openvsx/wiki/Publishing-Extensions#2-create-the-namespace)が**事前に**作成されていることを確認してください。  
`pat` パラメーターには [Open VSX アクセストークン](https://github.com/eclipse/openvsx/wiki/Publishing-Extensions#1-create-an-access-token) を設定する必要があります。  
さらに、ライセンスが付与されている拡張機能のみを公開することを確認してください。  
Open VSX のタイムラインおよび拡張機能のライセンスに関する詳細は、[Brian King のブログ](https://blogs.eclipse.org/post/brian-king/open-vsx-registry-under-new-management)（「Licensing」および「Timeline」セクション）をご覧ください。

現在、この GitHub アクションではライセンス条項を明示していない拡張機能の公開も可能です。  
しかし、この動作は非推奨であり、将来のリリースでは未ライセンスの拡張機能は拒否されます。  
したがって、[MIT ライセンス](https://choosealicense.com/licenses/mit/) のような（許容的な）ライセンスを付与して拡張機能を公開することを強く推奨します。

### Visual Studio Marketplace

VS Marketplace に拡張機能をアップロードするには、対応する [アクセストークン](https://code.visualstudio.com/api/working-with-extensions/publishing-extension#get-a-personal-access-token) を `pat` オプションに設定する必要があります。  
さらに、`registryUrl` は `https://marketplace.visualstudio.com` に設定してください。


## 入力パラメーター

以下の入力パラメーターを任意に、またはすべて設定できます：

|名前 |型 |必須? |デフォルト |説明
|-|-|-|-|-
|`pat` |string  |はい |-|対応するレジストリへのパーソナルアクセストークン。
|`extensionFile` |string  |いいえ | - |公開する vsix ファイルへのパス。このオプションは `packagePath` と同時に設定された場合に優先されます。
|`registryUrl` |string  |いいえ |`https://open-vsx.org` |このベース URL のレジストリ API を使用します。
|`packagePath` |string |いいえ | `./` |パッケージングおよび公開する拡張機能へのパス。`extensionFile` が設定されている場合は `packagePath` は無視されます。
|`baseContentUrl` |string |いいえ | - |README.md 内のすべての相対リンクにこの URL を前置します。
|`baseImagesUrl` |string |いいえ | - |README.md 内のすべての相対画像リンクにこの URL を前置します。
|`yarn` |boolean |いいえ | `false` |拡張機能のファイルをパッケージングする際に npm の代わりに yarn を使用します。
|`dryRun` |boolean |いいえ | `false` |このオプションを `true` に設定すると、拡張機能のパッケージングは行うが公開は行いません。このオプション使用時は `pat` をダミー値に設定してください。
|`noVerify` |boolean| いいえ |`false` |提案された API（enableProposedApi: true）を使用する拡張機能を Visual Studio Marketplace に公開可能にします。vsce の `--noVerify` コマンドライン引数に類似。
|`preRelease` |boolean| いいえ |`false` |拡張機能のリリースをプレリリースとしてマークします。パッケージング時のみ考慮されます。
|`dependencies` |boolean| いいえ |`true` |`package.json` に定義された依存関係が `node_modules` に存在するかをチェックします。pnpm または yarn v2+ の PnP 使用時は `false` に設定してください。
|`skipDuplicate` |boolean| いいえ |`false` |マーケットプレイスにすでに存在するバージョンの場合、静かに失敗します。vsce CLI の `--skip-duplicate` オプションと同等です。
|`target` |string| いいえ | - |拡張機能が実行される対象アーキテクチャ。複数のターゲットはスペースで区切ります。例： `'win32-x64 linux-x64'`


## 出力

このアクションは以下の出力を公開します：

|名前 |型 |説明
|-|-|-
|`vsixPath` |string |パッケージ化および公開されたVSIXファイルへのパス。

## コントリビューション

バグを見つけた場合や機能が不足している場合は、遠慮なく[issueを提出してください](https://github.com/HaaLeo/publish-vscode-extension/issues/new/choose)。  
プルリクエストも歓迎します！  
コード変更の提出を始めるには、まず[CONTRIBUTING.md](https://raw.githubusercontent.com/HaaLeo/publish-vscode-extension/master/./CONTRIBUTING.md)ファイルをご覧ください。

## サポート

この拡張機能を気に入ったら、ぜひ[リポジトリにスターを付けてください](https://github.com/HaaLeo/publish-vscode-extension/stargazers)。私は常に新しいアイデアやフィードバックを求めています。  
さらに、[PayPal経由での寄付も可能です](https://www.paypal.me/LeoHanisch/3eur)。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-07

---