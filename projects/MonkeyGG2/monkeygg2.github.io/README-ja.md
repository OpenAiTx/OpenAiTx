<p align="center"><img src="https://raw.githubusercontent.com/MonkeyGG2/monkeygg2.github.io/main/imgs/icon-256-256.png" height="200"></p>

<div align="center">
<a href="https://discord.com/invite/yPYyZ78qCB"><img alt="Discord" src="https://img.shields.io/discord/1051660971900407839?label=discord"></a>
<a href="https://github.com/MonkeyGG2/monkeygg2.github.io"><img alt="Github Repo stars" src="https://img.shields.io/github/stars/MonkeyGG2/monkeygg2.github.io?label=github%20stars"></a>
<a href="https://github.com/MonkeyGG2/monkeygg2.github.io"><img alt="GitHub Repo forks" src="https://img.shields.io/github/forks/MonkeyGG2/monkeygg2.github.io?label=github%20forks"></a>
<a href="https://codeberg.org/MonkeyGG2/pages"><img alt="Codeberg Repo stars" src="https://img.shields.io/badge/dynamic/json.svg?label=codeberg%20stars&url=https://codeberg.org/api/v1/repos/MonkeyGG2/pages&query=stars_count"></a>
<a href="https://codeberg.org/MonkeyGG2/pages"><img alt="Codeberg Repo forks" src="https://img.shields.io/badge/dynamic/json.svg?label=codeberg%20forks&url=https://codeberg.org/api/v1/repos/MonkeyGG2/pages&query=forks_count"></a>
<a href="http://www.wtfpl.net/about"><img alt="License: WTFPL" src="https://img.shields.io/badge/License-WTFPL-brightgreen.svg"></a>
</div>
<h1 align="center">MonkeyGG2</h1>
<p align="center" style="opacity: 0.65;">あなたの身近なゲームサイト。</p>
<br>

MonkeyGG2へようこそ！150本以上のゲームから選べる、機能満載のゲームサイトです。MonkeyGG2は、ユニークでカスタマイズ可能なゲーミング体験を提供します。ゲーマー、開発者、または一般の方でも、MonkeyGG2はシームレスで快適なゲーム環境を提供します。

> ぜひスターを付けてください！このリポジトリをフォークした場合や、何らかの用途で役立った場合は特にお願いします。

## 特徴

-   150本以上のゲーム
-   使いやすい
-   デプロイが簡単
-   カスタマイズ可能
-   プロキシ対応
-   さらに多くの機能...

## カスタマイズ

### 設定

#### クローク（Cloaking）

クロークとは、ページを `about:blank` タブで開くことを指します。この挙動はデフォルトで有効ですが、無効にすることも可能です。リダイレクトリンク用のプリセットも用意されていますが、手動で設定することも可能です。

#### マスキング（Masking）

マスキングとは、about:blankタブのアイコンやタブタイトルを変更することです。アイコンやタブタイトル用のプリセットも用意されていますが、手動で設定することも可能です。

#### ショートカット

カスタムキーボードショートカットを作成して、さまざまなタスクを実行できます。例えば、ゲームの終了、タブのマスキング、カスタムJavaScriptの実行などがサポートされています。
> 注意: カスタムJavaScriptを実行したい場合は、内容をよく理解していることを確認してください。もし何か問題が発生した場合は、ページをリロードすれば解決します。

#### テーマ

現在サポートされているテーマカスタマイズは以下の通りです:
- 背景アニメーションの切り替え（ゲーム中は自動的に無効化されるので、パフォーマンスの心配は不要です）
- 背景色
- ブロック色
- ボタン色
- ゲーム色
- ホバー色
- スクロールバーの色
- スクロールトラックの色
- フォント色

> 注意: サイトが使用できないほど色を誤って変更した場合は、クッキーとローカルストレージをクリアする必要があります。

### 詳細なカスタマイズ

> 免責事項: 以下のカスタマイズは、このリポジトリまたはそのフォークの所有者のみが利用可能です。

`config.jsonc` ファイルは、サイト全体の設定を含む形式になっています。現在サポートされている項目は以下の通りです:
- ゲーム
- テーマ（近日対応予定）
- プロキシ設定

#### ゲーム

各ゲームエントリは、ゲームの表示名をキーとし、値は3つのキーと値のペアを含むオブジェクトである必要があります:
- `"path"`: `./games` ディレクトリからのゲームへのパス
- `"aliases"`: 検索性向上のためのゲームの別名リスト
- `"categories"`: ゲームが該当するカテゴリのリスト（アイコン追加のサポートは近日対応予定）

エントリを手動で追加することもできますが、リストをアルファベット順で並べたい場合は特に面倒です（ただし、設定が動作するのに必須ではありません）。
このため、`add-game-entry.js` スクリプトが作成されました。ファイルを手動で編集せずに簡単に新しいゲームを設定に追加できます。

```bash
# node.js, bun, denoなど任意のjsランタイムが利用できます
# この例では依存関係が自動インストールされるbunを使用します
bun add-game-script.js
# 続くプロンプトに答えると設定が更新されます
```

#### テーマ

テーマ標準はまだ実装されていません（TODO）

#### プロキシ

プロキシ設定オプションは **"config"** キーの下にあります。
キー `"proxy"` の値は、プロキシ機能を有効または無効にするブール値です。`"proxy"` がfalseの場合、ユーザーがプロキシへアクセスしようとするとエラーダイアログが表示されます。
キー `"proxyPath"` の値はプロキシへのパスです。絶対パスまたは相対パスが利用できますが、プロキシページはサイト内でiframeとして表示されるため、**CORS** に対応している必要があります。

## デプロイ

### プロキシなし

[![Run on Replit](https://binbashbanana.github.io/deploy-buttons/buttons/remade/replit.svg)](https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Remix on Glitch](https://binbashbanana.github.io/deploy-buttons/buttons/remade/glitch.svg)](https://glitch.com/edit/#!/import/github/MonkeyGG2/monkeygg2.github.io)
[![Deploy to IBM Cloud](https://binbashbanana.github.io/deploy-buttons/buttons/remade/ibmcloud.svg)](https://cloud.ibm.com/devops/setup/deploy?repository=https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Deploy to Amplify Console](https://binbashbanana.github.io/deploy-buttons/buttons/remade/amplifyconsole.svg)](https://console.aws.amazon.com/amplify/home#/deploy?repo=https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Run on Google Cloud](https://binbashbanana.github.io/deploy-buttons/buttons/remade/googlecloud.svg)](https://deploy.cloud.run/?git_repo=https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Deploy to Oracle Cloud](https://binbashbanana.github.io/deploy-buttons/buttons/remade/oraclecloud.svg)](https://cloud.oracle.com/resourcemanager/stacks/create?zipUrl=https://github.com/MonkeyGG2/monkeygg2.github.io/archive/refs/heads/main.zip)
[![Deploy with Vercel](https://binbashbanana.github.io/deploy-buttons/buttons/remade/vercel.svg)](https://vercel.com/new/clone?repository-url=https%3A%2F%2Fgithub.com%2FMonkeyGG2%2Fmonkeygg2.github.io)
[![Deploy with Netlify](https://binbashbanana.github.io/deploy-buttons/buttons/remade/netlify.svg)](https://app.netlify.com/start/deploy?repository=https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Deploy to Render](https://binbashbanana.github.io/deploy-buttons/buttons/remade/render.svg)](https://render.com/deploy?repo=https://github.com/MonkeyGG2/monkeygg2.github.io)

もしくは、[GitHub](https://github.com/MonkeyGG2/monkeygg2.github.io) または [Codeberg](https://codeberg.org/MonkeyGG2/pages) 上でこのリポジトリをフォークし、それぞれGitHub PagesまたはCodeberg Pagesにデプロイすることもできます。

### プロキシあり

MonkeyGG2をプロキシでホスティングする方法については、[VioletGG2](https://github.com/MonkeyGG2/VioletGG2) のページをご覧ください。

### ローカルで実行

```bash
# 警告: "monkeygg2"という名前のフォルダが既に存在する場合、このコマンドはそのフォルダ内の全ファイルを削除します
# 以下2つのコマンド内のディレクトリ名を変更してください
git clone https://github.com/MonkeyGG2/monkeygg2.github.io.git monkeygg2
cd monkeygg2
# ここからは任意の静的サーバーツールが利用可能です。ここではnpmの"live-server"を使用します
npm install -g live-server # まだインストールしていない場合のみ
npx live-server
```

## ライセンス

本ソフトウェアはWTFPLライセンスの下で配布されています。詳細は[こちら](https://github.com/MonkeyGG2/monkeygg2.github.io/blob/main/LICENSE)をご覧ください。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---