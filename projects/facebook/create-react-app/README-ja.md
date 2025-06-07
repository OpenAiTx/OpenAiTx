## Create React App [![Build & Test](https://github.com/facebook/create-react-app/actions/workflows/build-and-test.yml/badge.svg?branch=main)](https://github.com/facebook/create-react-app/actions/workflows/build-and-test.yml) [![PRs Welcome](https://img.shields.io/badge/PRs-welcome-green.svg)](https://github.com/facebook/create-react-app/blob/main/CONTRIBUTING.md)

> [!CAUTION]
>
> ## 非推奨
>
> Create React Appは2017年から2021年にかけてReactプロジェクトの立ち上げにおける主要なツールの一つでしたが、現在は長期的な静止状態となっており、[新しいReactプロジェクトの開始](https://react.dev/learn/start-a-new-react-project)で紹介されているReactフレームワークへの移行を推奨します。
>
> Reactの学習のためにチュートリアルを進めている場合は引き続き価値がありますが、Create React Appをベースにした本番アプリの新規開発は推奨していません。

<img alt="Logo" align="right" src="https://create-react-app.dev/img/logo.svg" width="20%" />

ビルド設定なしでReactアプリを作成できます。

- [アプリの作成](#creating-an-app) – 新しいアプリの作成方法。
- [ユーザーガイド](https://facebook.github.io/create-react-app/) – Create React Appでブートストラップされたアプリの開発方法。

Create React AppはmacOS、Windows、Linuxで動作します。<br>
何か問題が発生した場合は、[issueを提出](https://github.com/facebook/create-react-app/issues/new)してください。<br>
質問やヘルプが必要な場合は、[GitHub Discussions](https://github.com/facebook/create-react-app/discussions)でご相談ください。

## クイック概要

```sh
npx create-react-app my-app
cd my-app
npm start
```

以前に`npm install -g create-react-app`で`create-react-app`をグローバルインストールしている場合は、`npm uninstall -g create-react-app`または`yarn global remove create-react-app`でアンインストールすることを推奨します。これにより、npxが常に最新バージョンを使用します。

_([npx](https://medium.com/@maybekatz/introducing-npx-an-npm-package-runner-55f7d4bd282b)はnpm 5.2+以降に付属しています。古いnpmバージョンの手順は[こちら](https://gist.github.com/gaearon/4064d3c23a77c74a3614c498a8bb1c5f)をご覧ください)_

その後、[http://localhost:3000/](http://localhost:3000/)を開いてアプリを確認できます。<br>
本番環境にデプロイする準備ができたら、`npm run build`で縮小バンドルを作成します。

<p align='center'>
<img src='https://cdn.jsdelivr.net/gh/facebook/create-react-app@27b42ac7efa018f2541153ab30d63180f5fa39e0/screencast.svg' width='600' alt='npm start'>
</p>

### すぐに始める

webpackやBabelのようなツールをインストール・設定する必要は**ありません**。<br>
それらは事前に設定されており、隠蔽されているため、コードに集中できます。

プロジェクトを作成すれば、すぐに開発を始められます。

## アプリの作成

**ローカル開発マシンにNode 14.0.0以降が必要です**（サーバー上には不要）。最新のLTSバージョンの使用を推奨します。プロジェクトごとにNodeバージョンを切り替えるには、[nvm](https://github.com/creationix/nvm#installation)（macOS/Linux）や[nvm-windows](https://github.com/coreybutler/nvm-windows#node-version-manager-nvm-for-windows)を使用できます。

新しいアプリを作成するには、以下のいずれかの方法を選択できます。

### npx

```sh
npx create-react-app my-app
```

_([npx](https://medium.com/@maybekatz/introducing-npx-an-npm-package-runner-55f7d4bd282b)はnpm 5.2+以降に付属するパッケージランナーです。古いnpmバージョンの手順は[こちら](https://gist.github.com/gaearon/4064d3c23a77c74a3614c498a8bb1c5f))_

### npm

```sh
npm init react-app my-app
```

_`npm init <initializer>`はnpm 6+で利用可能_

### Yarn

```sh
yarn create react-app my-app
```

_[`yarn create <starter-kit-package>`](https://yarnpkg.com/lang/en/docs/cli/create/)はYarn 0.25+で利用可能_

これにより、現在のフォルダ内に`my-app`というディレクトリが作成されます。<br>
このディレクトリ内に初期プロジェクト構造が生成され、依存関係がインストールされます。

```
my-app
├── README.md
├── node_modules
├── package.json
├── .gitignore
├── public
│   ├── favicon.ico
│   ├── index.html
│   └── manifest.json
└── src
    ├── App.css
    ├── App.js
    ├── App.test.js
    ├── index.css
    ├── index.js
    ├── logo.svg
    └── serviceWorker.js
    └── setupTests.js
```

設定や複雑なフォルダー構成は不要で、アプリ構築に必要なファイルのみが用意されます。<br>
インストールが完了したら、プロジェクトフォルダを開きます。

```sh
cd my-app
```

新しく作成したプロジェクト内で、いくつかの組み込みコマンドを実行できます。

### `npm start` または `yarn start`

アプリを開発モードで起動します。<br>
[http://localhost:3000](http://localhost:3000)をブラウザで開いて表示します。

コードを変更するとページが自動的にリロードされます。<br>
ビルドエラーやLint警告はコンソールに表示されます。

<p align='center'>
<img src='https://cdn.jsdelivr.net/gh/marionebl/create-react-app@9f6282671c54f0874afd37a72f6689727b562498/screencast-error.svg' width='600' alt='Build errors'>
</p>

### `npm test` または `yarn test`

インタラクティブモードでテストウォッチャーを実行します。<br>
デフォルトでは、直前のコミット以降に変更されたファイルに関連するテストが実行されます。

[テストについて詳しくはこちら。](https://facebook.github.io/create-react-app/docs/running-tests)

### `npm run build` または `yarn build`

アプリを本番用に`build`フォルダにビルドします。<br>
本番モードでReactを正しくバンドルし、パフォーマンス最適化も行われます。

ビルドは縮小され、ファイル名にはハッシュが含まれます。<br>

アプリのデプロイ準備が整います。

## ユーザーガイド

Create React Appの使い方や多くのヒントは[公式ドキュメント](https://facebook.github.io/create-react-app/)に詳細に記載されています。

## 新しいバージョンへのアップデート方法

こちらやその他の情報は[ユーザーガイド](https://facebook.github.io/create-react-app/docs/updating-to-new-releases)を参照してください。

## フィロソフィー

- **依存は1つだけ:** ビルド依存は1つだけです。webpack、Babel、ESLintなどの素晴らしいプロジェクトを活用しつつ、それらを統合した体験を提供します。

- **設定不要:** 何も設定する必要はありません。開発用・本番用ビルドの適切な設定が用意されているため、コードを書くことに集中できます。

- **ロックインなし:** いつでもカスタムセットアップに「イジェクト」できます。1つのコマンドを実行するだけで、全ての設定とビルド依存がプロジェクト内に移動され、自由にカスタマイズできます。

## 含まれるもの

モダンなシングルページReactアプリを構築するために必要なものが全て揃っています：

- React、JSX、ES6、TypeScriptおよびFlow構文サポート。
- オブジェクトスプレッド演算子など、ES6以外の言語拡張。
- `-webkit-`等のプレフィックス不要な自動プレフィックス付きCSS。
- カバレッジレポート対応の高速インタラクティブユニットテストランナー。
- よくあるミスを警告するライブ開発サーバー。
- ハッシュとソースマップ付きで、JS・CSS・画像を本番用にバンドルするビルドスクリプト。
- オフラインファーストの[サービスワーカー](https://developers.google.com/web/fundamentals/getting-started/primers/service-workers)と[Webアプリアイコンマニフェスト](https://developers.google.com/web/fundamentals/engage-and-retain/web-app-manifest/)。全ての[Progressive Web App](https://facebook.github.io/create-react-app/docs/making-a-progressive-web-app)基準を満たします。(_注: サービスワーカーの使用は`react-scripts@2.0.0`以降でオプトインになりました_)
- これらツールのアップデートも1つの依存だけで簡単。

これらのツールの連携概要は[このガイド](https://github.com/nitishdayal/cra_closer_look)をご覧ください。

**これらのツールは特定の方法で動作するようにプリセットされています。** より多くのカスタマイズが必要な場合は["イジェクト"](https://facebook.github.io/create-react-app/docs/available-scripts#npm-run-eject)して設定を変更できますが、その場合は以降の設定管理が必要になります。

## 人気のある代替案

Create React Appは以下の用途に最適です：

- 機能豊富な開発環境で**Reactを学ぶ**。
- **新しいシングルページReactアプリケーションの開始**。
- ライブラリやコンポーネントの**Reactによるサンプル作成**。

以下のような場合は他の選択肢も検討してください：

- **Reactを試したい**が多数のビルドツール依存は避けたい場合、[単一HTMLファイルやオンラインサンドボックス](https://reactjs.org/docs/getting-started.html#try-react)の利用を検討してください。

- Rails、Django、Symfony等の**サーバーサイドテンプレートフレームワークとReactコードを統合したい**、または**シングルページアプリでない場合**は、より柔軟な[nwb](https://github.com/insin/nwb)や[Neutrino](https://neutrino.js.org/)を検討してください。Railsには[Webpacker](https://github.com/rails/webpacker)、Symfonyには[webpack Encore](https://symfony.com/doc/current/frontend/encore/reactjs.html)も使えます。

- **Reactコンポーネントを公開したい**場合、[nwb](https://github.com/insin/nwb)や[Neutrinoのreact-componentsプリセット](https://neutrino.js.org/packages/react-components/)も利用可能です。

- ReactとNode.jsで**サーバーレンダリング**したい場合は、[Next.js](https://nextjs.org/)や[Razzle](https://github.com/jaredpalmer/razzle)を検討してください。Create React Appはバックエンドに依存せず、静的なHTML/JS/CSSバンドルのみを生成します。

- ウェブサイトが**ほぼ静的**（ポートフォリオやブログなど）の場合は、[Gatsby](https://www.gatsbyjs.org/)や[Next.js](https://nextjs.org/)を検討してください。Gatsbyはビルド時にHTMLをプリレンダリングし、Next.jsはサーバーレンダリングとプリレンダリングの両方に対応しています。

- **さらなるカスタマイズ**が必要な場合は、[Neutrino](https://neutrino.js.org/)やその[Reactプリセット](https://neutrino.js.org/packages/react/)をご覧ください。

これらのツールはほとんど設定不要、または最小限の設定で動作します。

自分でビルド設定をしたい場合は、[このガイド](https://reactjs.org/docs/add-react-to-a-website.html)に従ってください。

## React Native

React Native向けの類似ツールをお探しですか？<br>
[Expo CLI](https://github.com/expo/expo-cli)をご覧ください。

## コントリビューション

`create-react-app`へのご協力を歓迎します！詳細や始め方については[CONTRIBUTING.md](CONTRIBUTING.md)をご覧ください。

## Create React Appのサポート

Create React Appはコミュニティによって維持されているプロジェクトで、全てのコントリビューターはボランティアです。今後の開発を支援いただける場合は、[Open Collective](https://opencollective.com/create-react-app)への寄付をご検討ください。

## クレジット

本プロジェクトは[コントリビューター](CONTRIBUTING.md)の皆さんのおかげで成り立っています。<br>
<a href="https://github.com/facebook/create-react-app/graphs/contributors"><img src="https://opencollective.com/create-react-app/contributors.svg?width=890&button=false" /></a>

ドキュメントのホスティングには[Netlify](https://www.netlify.com/)に感謝いたします。

## 謝辞

既存の関連プロジェクトの作者の皆様のアイデアと協力に感謝します：

- [@eanplatter](https://github.com/eanplatter)
- [@insin](https://github.com/insin)
- [@mxstbr](https://github.com/mxstbr)

## ライセンス

Create React Appは[MITライセンス](https://github.com/facebook/create-react-app/blob/main/LICENSE)のオープンソースソフトウェアです。Create React Appのロゴは[Creative Commons Attribution 4.0 International license](https://creativecommons.org/licenses/by/4.0/)の下でライセンスされています。

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---