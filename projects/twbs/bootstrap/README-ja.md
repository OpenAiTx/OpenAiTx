<p align="center">
  <a href="https://getbootstrap.com/">
    <img src="https://getbootstrap.com/docs/5.3/assets/brand/bootstrap-logo-shadow.png" alt="Bootstrap logo" width="200" height="165">
  </a>
</p>

<h3 align="center">Bootstrap</h3>

<p align="center">
  スマートで直感的、かつ強力なフロントエンドフレームワークで、より速く簡単なWeb開発を実現します。
  <br>
  <a href="https://getbootstrap.com/docs/5.3/"><strong>Bootstrap ドキュメントを探索する »</strong></a>
  <br>
  <br>
  <a href="https://github.com/twbs/bootstrap/issues/new?assignees=-&labels=bug&template=bug_report.yml">バグを報告</a>
  ·
  <a href="https://github.com/twbs/bootstrap/issues/new?assignees=&labels=feature&template=feature_request.yml">機能をリクエスト</a>
  ·
  <a href="https://themes.getbootstrap.com/">テーマ</a>
  ·
  <a href="https://blog.getbootstrap.com/">ブログ</a>
</p>


## Bootstrap 5

デフォルトブランチは、Bootstrap 5 リリースの開発用です。Bootstrap 4 の readme、ドキュメント、ソースコードを参照するには [`v4-dev` ブランチ](https://github.com/twbs/bootstrap/tree/v4-dev) をご覧ください。


## 目次

- [クイックスタート](#quick-start)
- [ステータス](#status)
- [同梱内容](#whats-included)
- [バグと機能リクエスト](#bugs-and-feature-requests)
- [ドキュメント](#documentation)
- [コントリビュート](#contributing)
- [コミュニティ](#community)
- [バージョニング](#versioning)
- [作成者](#creators)
- [謝辞](#thanks)
- [著作権とライセンス](#copyright-and-license)


## クイックスタート

いくつかのクイックスタートオプションを用意しています：

- [最新リリースをダウンロード](https://github.com/twbs/bootstrap/archive/v5.3.6.zip)
- リポジトリをクローン：`git clone https://github.com/twbs/bootstrap.git`
- [npm](https://www.npmjs.com/) でインストール：`npm install bootstrap@v5.3.6`
- [yarn](https://yarnpkg.com/) でインストール：`yarn add bootstrap@v5.3.6`
- [Bun](https://bun.sh/) でインストール：`bun add bootstrap@v5.3.6`
- [Composer](https://getcomposer.org/) でインストール：`composer require twbs/bootstrap:5.3.6`
- [NuGet](https://www.nuget.org/) でインストール：CSS: `Install-Package bootstrap` Sass: `Install-Package bootstrap.sass`

フレームワークの内容、テンプレート、サンプルなどについては、[はじめにページ](https://getbootstrap.com/docs/5.3/getting-started/introduction/)をご覧ください。


## ステータス

[![Build Status](https://img.shields.io/github/actions/workflow/status/twbs/bootstrap/js.yml?branch=main&label=JS%20Tests&logo=github)](https://github.com/twbs/bootstrap/actions/workflows/js.yml?query=workflow%3AJS+branch%3Amain)
[![npm version](https://img.shields.io/npm/v/bootstrap?logo=npm&logoColor=fff)](https://www.npmjs.com/package/bootstrap)
[![Gem version](https://img.shields.io/gem/v/bootstrap?logo=rubygems&logoColor=fff)](https://rubygems.org/gems/bootstrap)
[![Meteor Atmosphere](https://img.shields.io/badge/meteor-twbs%3Abootstrap-blue?logo=meteor&logoColor=fff)](https://atmospherejs.com/twbs/bootstrap)
[![Packagist Prerelease](https://img.shields.io/packagist/vpre/twbs/bootstrap?logo=packagist&logoColor=fff)](https://packagist.org/packages/twbs/bootstrap)
[![NuGet](https://img.shields.io/nuget/vpre/bootstrap?logo=nuget&logoColor=fff)](https://www.nuget.org/packages/bootstrap/absoluteLatest)
[![Coverage Status](https://img.shields.io/coveralls/github/twbs/bootstrap/main?logo=coveralls&logoColor=fff)](https://coveralls.io/github/twbs/bootstrap?branch=main)
[![CSS gzip size](https://img.badgesize.io/twbs/bootstrap/main/dist/css/bootstrap.min.css?compression=gzip&label=CSS%20gzip%20size)](https://github.com/twbs/bootstrap/blob/main/dist/css/bootstrap.min.css)
[![CSS Brotli size](https://img.badgesize.io/twbs/bootstrap/main/dist/css/bootstrap.min.css?compression=brotli&label=CSS%20Brotli%20size)](https://github.com/twbs/bootstrap/blob/main/dist/css/bootstrap.min.css)
[![JS gzip size](https://img.badgesize.io/twbs/bootstrap/main/dist/js/bootstrap.min.js?compression=gzip&label=JS%20gzip%20size)](https://github.com/twbs/bootstrap/blob/main/dist/js/bootstrap.min.js)
[![JS Brotli size](https://img.badgesize.io/twbs/bootstrap/main/dist/js/bootstrap.min.js?compression=brotli&label=JS%20Brotli%20size)](https://github.com/twbs/bootstrap/blob/main/dist/js/bootstrap.min.js)
[![Backers on Open Collective](https://img.shields.io/opencollective/backers/bootstrap?logo=opencollective&logoColor=fff)](#backers)
[![Sponsors on Open Collective](https://img.shields.io/opencollective/sponsors/bootstrap?logo=opencollective&logoColor=fff)](#sponsors)


## 同梱内容

ダウンロードには以下のディレクトリおよびファイルが含まれており、共通アセットを論理的にグループ化し、コンパイル済みと圧縮済み（minified）の両方を提供しています。

<details>
  <summary>ダウンロード内容</summary>

  ```text
  bootstrap/
  ├── css/
  │   ├── bootstrap-grid.css
  │   ├── bootstrap-grid.css.map
  │   ├── bootstrap-grid.min.css
  │   ├── bootstrap-grid.min.css.map
  │   ├── bootstrap-grid.rtl.css
  │   ├── bootstrap-grid.rtl.css.map
  │   ├── bootstrap-grid.rtl.min.css
  │   ├── bootstrap-grid.rtl.min.css.map
  │   ├── bootstrap-reboot.css
  │   ├── bootstrap-reboot.css.map
  │   ├── bootstrap-reboot.min.css
  │   ├── bootstrap-reboot.min.css.map
  │   ├── bootstrap-reboot.rtl.css
  │   ├── bootstrap-reboot.rtl.css.map
  │   ├── bootstrap-reboot.rtl.min.css
  │   ├── bootstrap-reboot.rtl.min.css.map
  │   ├── bootstrap-utilities.css
  │   ├── bootstrap-utilities.css.map
  │   ├── bootstrap-utilities.min.css
  │   ├── bootstrap-utilities.min.css.map
  │   ├── bootstrap-utilities.rtl.css
  │   ├── bootstrap-utilities.rtl.css.map
  │   ├── bootstrap-utilities.rtl.min.css
  │   ├── bootstrap-utilities.rtl.min.css.map
  │   ├── bootstrap.css
  │   ├── bootstrap.css.map
  │   ├── bootstrap.min.css
  │   ├── bootstrap.min.css.map
  │   ├── bootstrap.rtl.css
  │   ├── bootstrap.rtl.css.map
  │   ├── bootstrap.rtl.min.css
  │   └── bootstrap.rtl.min.css.map
  └── js/
      ├── bootstrap.bundle.js
      ├── bootstrap.bundle.js.map
      ├── bootstrap.bundle.min.js
      ├── bootstrap.bundle.min.js.map
      ├── bootstrap.esm.js
      ├── bootstrap.esm.js.map
      ├── bootstrap.esm.min.js
      ├── bootstrap.esm.min.js.map
      ├── bootstrap.js
      ├── bootstrap.js.map
      ├── bootstrap.min.js
      └── bootstrap.min.js.map
  ```
</details>

コンパイル済みのCSSおよびJS（`bootstrap.*`）、および圧縮済み（minified）のCSSおよびJS（`bootstrap.min.*`）を提供しています。[ソースマップ](https://web.dev/articles/source-maps)（`bootstrap.*.map`）は一部のブラウザの開発者ツールで利用できます。バンドルされたJSファイル（`bootstrap.bundle.js` および `bootstrap.bundle.min.js`）には [Popper](https://popper.js.org/docs/v2/) が含まれています。


## バグと機能リクエスト

バグや機能のリクエストがありますか？まず [イシューガイドライン](https://github.com/twbs/bootstrap/blob/main/.github/CONTRIBUTING.md#using-the-issue-tracker) をお読みいただき、既存およびクローズされたイシューを検索してください。もし問題やアイデアがまだ扱われていなければ、[新しいイシューを作成してください](https://github.com/twbs/bootstrap/issues/new/choose)。


## ドキュメント

Bootstrapのドキュメントは、このリポジトリのルートディレクトリに含まれており、[Astro](https://astro.build/) で構築され、GitHub Pages（<https://getbootstrap.com/>）で公開されています。ドキュメントはローカルでも実行できます。

ドキュメント検索は [AlgoliaのDocSearch](https://docsearch.algolia.com/) により提供されています。

### ドキュメントをローカルで実行する

1. `npm install` を実行して、Astro（サイトビルダー）を含むNode.js依存パッケージをインストールします。
2. `npm run test`（または特定のnpmスクリプト）を実行して、配布用CSSとJavaScriptファイル、およびドキュメントアセットを再構築します。
3. ルートの `/bootstrap` ディレクトリから、コマンドラインで `npm run docs-serve` を実行します。
4. ブラウザで `http://localhost:9001/` を開きます。

Astroの使い方については、[公式ドキュメント](https://docs.astro.build/en/getting-started/)を参照してください。

### 過去リリースのドキュメント

すべての過去リリースのドキュメントは <https://getbootstrap.com/docs/versions/> から参照できます。

[過去リリース](https://github.com/twbs/bootstrap/releases) とそのドキュメントもダウンロード可能です。


## コントリビュート

[コントリビュートガイドライン](https://github.com/twbs/bootstrap/blob/main/.github/CONTRIBUTING.md)をお読みください。イシュー作成、コーディング規約、開発に関する注意事項が含まれています。

さらに、プルリクエストにJavaScriptの修正や機能追加が含まれる場合は、[該当するユニットテスト](https://github.com/twbs/bootstrap/tree/main/js/tests)を必ず含めてください。すべてのHTMLおよびCSSは、[Mark Otto](https://github.com/mdo) が管理する [Code Guide](https://github.com/mdo/code-guide) に準拠する必要があります。

エディタ設定は [editor config](https://github.com/twbs/bootstrap/blob/main/.editorconfig) で提供されており、一般的なテキストエディタで簡単に利用できます。詳細やプラグインのダウンロードは <https://editorconfig.org/> をご覧ください。


## コミュニティ

Bootstrapの開発情報を入手し、プロジェクトメンテナーやコミュニティメンバーと交流しましょう。

- [Xの@getbootstrap](https://x.com/getbootstrap) をフォロー
- [公式Bootstrapブログ](https://blog.getbootstrap.com/) を購読
- [GitHub Discussions](https://github.com/twbs/bootstrap/discussions) で質問や議論
- [コミュニティDiscord](https://discord.gg/bZUvakRU3M) や [Bootstrap subreddit](https://www.reddit.com/r/bootstrap/) で議論
- IRCで他のBootstrapユーザーとチャット。`irc.libera.chat` サーバーの `#bootstrap` チャンネルにて。
- Stack Overflowでの実装サポート（[`bootstrap-5`](https://stackoverflow.com/questions/tagged/bootstrap-5) タグ）
- 開発者は、npm等でBootstrapの機能を拡張・追加するパッケージ配布時に `bootstrap` キーワードを利用してください。[npm](https://www.npmjs.com/browse/keyword/bootstrap) などでの発見性が高まります。


## バージョニング

リリースサイクルの透明性と後方互換性の維持のため、Bootstrapは[セマンティックバージョニング](https://semver.org/)に準拠しています。時には間違うこともありますが、可能な限りこのルールに従っています。

各リリースバージョンの変更履歴は [GitHubプロジェクトのリリースセクション](https://github.com/twbs/bootstrap/releases) をご覧ください。リリースの概要は [公式Bootstrapブログ](https://blog.getbootstrap.com/) のアナウンスポストにも掲載されています。


## 作成者

**Mark Otto**

- <https://x.com/mdo>
- <https://github.com/mdo>

**Jacob Thornton**

- <https://x.com/fat>
- <https://github.com/fat>


## 謝辞

<a href="https://www.browserstack.com/">
  <img src="https://live.browserstack.com/images/opensource/browserstack-logo.svg" alt="BrowserStack" width="192" height="42">
</a>

[BrowserStack](https://www.browserstack.com/) に、実際のブラウザでテストできるインフラを提供していただき、感謝いたします！

<a href="https://www.netlify.com/">
  <img src="https://www.netlify.com/v3/img/components/full-logo-light.svg" alt="Netlify" width="147" height="40">
</a>

[Netlify](https://www.netlify.com/) に、Deploy Preview を提供いただき、感謝いたします！


## スポンサー

スポンサーになることでこのプロジェクトを支援できます。あなたのロゴがここに表示され、Webサイトへのリンクが付きます。[[スポンサーになる](https://opencollective.com/bootstrap#sponsor)]

[![OC sponsor 0](https://opencollective.com/bootstrap/sponsor/0/avatar.svg)](https://opencollective.com/bootstrap/sponsor/0/website)
[![OC sponsor 1](https://opencollective.com/bootstrap/sponsor/1/avatar.svg)](https://opencollective.com/bootstrap/sponsor/1/website)
[![OC sponsor 2](https://opencollective.com/bootstrap/sponsor/2/avatar.svg)](https://opencollective.com/bootstrap/sponsor/2/website)
[![OC sponsor 3](https://opencollective.com/bootstrap/sponsor/3/avatar.svg)](https://opencollective.com/bootstrap/sponsor/3/website)
[![OC sponsor 4](https://opencollective.com/bootstrap/sponsor/4/avatar.svg)](https://opencollective.com/bootstrap/sponsor/4/website)
[![OC sponsor 5](https://opencollective.com/bootstrap/sponsor/5/avatar.svg)](https://opencollective.com/bootstrap/sponsor/5/website)
[![OC sponsor 6](https://opencollective.com/bootstrap/sponsor/6/avatar.svg)](https://opencollective.com/bootstrap/sponsor/6/website)
[![OC sponsor 7](https://opencollective.com/bootstrap/sponsor/7/avatar.svg)](https://opencollective.com/bootstrap/sponsor/7/website)
[![OC sponsor 8](https://opencollective.com/bootstrap/sponsor/8/avatar.svg)](https://opencollective.com/bootstrap/sponsor/8/website)
[![OC sponsor 9](https://opencollective.com/bootstrap/sponsor/9/avatar.svg)](https://opencollective.com/bootstrap/sponsor/9/website)


## バッカー

すべてのバッカーに感謝します！ 🙏 [[バッカーになる](https://opencollective.com/bootstrap#backer)]

[![Backers](https://opencollective.com/bootstrap/backers.svg?width=890)](https://opencollective.com/bootstrap#backers)


## 著作権とライセンス

コードおよびドキュメントの著作権は2011-2025 [Bootstrap Authors](https://github.com/twbs/bootstrap/graphs/contributors) に帰属します。コードは [MITライセンス](https://github.com/twbs/bootstrap/blob/main/LICENSE) のもとで公開されています。ドキュメントは [Creative Commons](https://creativecommons.org/licenses/by/3.0/) のもとで公開されています。

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---