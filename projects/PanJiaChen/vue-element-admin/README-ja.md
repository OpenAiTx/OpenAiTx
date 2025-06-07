<p align="center">
  <img width="320" src="https://wpimg.wallstcn.com/ecc53a42-d79b-42e2-8852-5126b810a4c8.svg">
</p>

<p align="center">
  <a href="https://github.com/vuejs/vue">
    <img src="https://img.shields.io/badge/vue-2.6.10-brightgreen.svg" alt="vue">
  </a>
  <a href="https://github.com/ElemeFE/element">
    <img src="https://img.shields.io/badge/element--ui-2.7.0-brightgreen.svg" alt="element-ui">
  </a>
  <a href="https://travis-ci.org/PanJiaChen/vue-element-admin" rel="nofollow">
    <img src="https://travis-ci.org/PanJiaChen/vue-element-admin.svg?branch=master" alt="Build Status">
  </a>
  <a href="https://github.com/PanJiaChen/vue-element-admin/blob/master/LICENSE">
    <img src="https://img.shields.io/github/license/mashape/apistatus.svg" alt="license">
  </a>
  <a href="https://github.com/PanJiaChen/vue-element-admin/releases">
    <img src="https://img.shields.io/github/release/PanJiaChen/vue-element-admin.svg" alt="GitHub release">
  </a>
  <a href="https://gitter.im/vue-element-admin/discuss">
    <img src="https://badges.gitter.im/Join%20Chat.svg" alt="gitter">
  </a>
  <a href="https://panjiachen.github.io/vue-element-admin-site/donate">
    <img src="https://img.shields.io/badge/%24-donate-ff69b4.svg" alt="donate">
  </a>
</p>

English | [简体中文](./README.zh-CN.md) | [日本語](./README.ja.md) | [Spanish](./README.es.md)

<!-- <p align="center">
  <b>SPONSORED BY</b>
</p>
<table align="center" cellspacing="0" cellpadding="0">
  <tbody>
    <tr>
      <td align="center" valign="middle">
       <a href="" title="" target="_blank" style="padding-right: 20px;">
        <img height="200px" style="padding-right: 20px;" src="" title="variantForm">
        </a>
      </td>
    </tr>
  </tbody> 
</table>-->

## はじめに

[vue-element-admin](https://panjiachen.github.io/vue-element-admin)は、管理画面向けの本番運用可能なフロントエンドソリューションです。[vue](https://github.com/vuejs/vue)をベースとし、UIツールキットとして[element-ui](https://github.com/ElemeFE/element)を使用しています。

[vue-element-admin](https://panjiachen.github.io/vue-element-admin)は、最新のvue開発スタックに基づいており、組み込みのi18nソリューション、エンタープライズアプリケーション向けの典型的なテンプレート、多くの優れた機能を備えています。大規模かつ複雑なシングルページアプリケーションの構築を支援します。どのようなニーズでも、このプロジェクトが役立つと信じています。

- [プレビュー](https://panjiachen.github.io/vue-element-admin)

- [ドキュメント](https://panjiachen.github.io/vue-element-admin-site/)

- [Gitter](https://gitter.im/vue-element-admin/discuss)

- [寄付](https://panjiachen.github.io/vue-element-admin-site/donate/)

- [Wiki](https://github.com/PanJiaChen/vue-element-admin/wiki)

- [Gitee](https://panjiachen.gitee.io/vue-element-admin/)（国内ユーザーはこちらでオンラインプレビュー可能）

- ベーステンプレート推奨：[vue-admin-template](https://github.com/PanJiaChen/vue-admin-template)
- デスクトップ版：[electron-vue-admin](https://github.com/PanJiaChen/electron-vue-admin)
- TypeScript版：[vue-typescript-admin-template](https://github.com/Armour/vue-typescript-admin-template)（クレジット: [@Armour](https://github.com/Armour)）
- [awesome-project](https://github.com/PanJiaChen/vue-element-admin/issues/2312)

**`v4.1.0+`バージョン以降、デフォルトのmasterブランチはi18nをサポートしません。[i18n Branch](https://github.com/PanJiaChen/vue-element-admin/tree/i18n)を使用してください。masterブランチと同様に更新されます。**

**現在のバージョンは`v4.0+`で`vue-cli`をベースに構築されています。問題が発生した場合は[issue](https://github.com/PanJiaChen/vue-element-admin/issues/new)に投稿してください。旧バージョンを使用したい場合は、[tag/3.11.0](https://github.com/PanJiaChen/vue-element-admin/tree/tag/3.11.0)ブランチに切り替えてください（`vue-cli`非依存）。**

**このプロジェクトは低バージョンのブラウザ（例：IE）をサポートしていません。必要に応じてpolyfillを追加してください。**

## 準備

ローカルに[node](https://nodejs.org/)と[git](https://git-scm.com/)をインストールする必要があります。本プロジェクトは[ES2015+](https://es6.ruanyifeng.com/)、[vue](https://cn.vuejs.org/index.html)、[vuex](https://vuex.vuejs.org/zh-cn/)、[vue-router](https://router.vuejs.org/zh-cn/)、[vue-cli](https://github.com/vuejs/vue-cli)、[axios](https://github.com/axios/axios)、[element-ui](https://github.com/ElemeFE/element)に基づいており、すべてのリクエストデータは[Mock.js](https://github.com/nuysoft/Mock)でシミュレートされています。これらの知識を事前に理解・学習しておくと、プロジェクトの利用が大いに役立ちます。

[![Edit on CodeSandbox](https://codesandbox.io/static/img/play-codesandbox.svg)](https://codesandbox.io/s/github/PanJiaChen/vue-element-admin/tree/CodeSandbox)

<p align="center">
  <img width="900" src="https://wpimg.wallstcn.com/a5894c1b-f6af-456e-82df-1151da0839bf.png">
</p>

## スポンサー

スポンサーになり、あなたのロゴをGitHubのREADMEに掲載し、あなたのサイトへのリンクを追加しましょう。[[スポンサーになる]](https://www.patreon.com/panjiachen)

### Akveo
<a href="https://store.akveo.com/products/vue-java-admin-dashboard-spring?utm_campaign=akveo_store-Vue-Vue_demo%2Fgithub&utm_source=vue_admin&utm_medium=referral&utm_content=github_banner"><img width="500px" src="https://raw.githubusercontent.com/PanJiaChen/vue-element-admin-site/master/docs/.vuepress/public/images/vue-java-banner.png" /></a><p>Vue管理画面用Javaバックエンドが20%割引の39$で購入可能。クーポンコード：SWB0RAZPZR1M
</p>

### Flatlogic

<a href="https://flatlogic.com/admin-dashboards?from=vue-element-admin"><img width="150px" src="https://wpimg.wallstcn.com/9c0b719b-5551-4c1e-b776-63994632d94a.png" /></a><p>Vue、React、Angularで作られた管理画面ダッシュボードテンプレート。</p>

## 特長

```
- ログイン / ログアウト

- 権限認証
  - ページ権限
  - ディレクティブ権限
  - 権限設定ページ
  - 2段階ログイン

- 複数環境ビルド
  - 開発（dev）
  - sit
  - ステージテスト（stage）
  - 本番（prod）

- グローバル機能
  - I18n
  - 複数動的テーマ
  - 動的サイドバー（多階層ルーティング対応）
  - 動的パンくずリスト
  - タグビュー（タブページ・右クリック操作サポート）
  - Svg スプライト
  - モックデータ
  - フルスクリーン
  - レスポンシブサイドバー

- エディター
  - リッチテキストエディター
  - Markdownエディター
  - JSONエディター

- Excel
  - Excelエクスポート
  - Excelアップロード
  - 可視化Excel
  - zipエクスポート

- テーブル
  - 動的テーブル
  - ドラッグ＆ドロップテーブル
  - インライン編集テーブル

- エラーページ
  - 401
  - 404

- コンポーネント
  - アバターアップロード
  - トップへ戻る
  - ドラッグダイアログ
  - ドラッグセレクト
  - ドラッグかんばん
  - ドラッグリスト
  - スプリットペイン
  - ドロップゾーン
  - スティッキー
  - CountTo

- 高度なサンプル
- エラーログ
- ダッシュボード
- ガイドページ
- ECharts
- クリップボード
- Markdownからhtml
```

## はじめ方

```bash
# プロジェクトをクローン
git clone https://github.com/PanJiaChen/vue-element-admin.git

# プロジェクトディレクトリへ移動
cd vue-element-admin

# 依存関係をインストール
npm install

# 開発サーバー起動
npm run dev
```

これで自動的に http://localhost:9527 が開きます。

## ビルド

```bash
# テスト環境用ビルド
npm run build:stage

# 本番環境用ビルド
npm run build:prod
```

## 上級者向け

```bash
# リリース環境のプレビュー
npm run preview

# リリース環境のプレビュー＋静的リソース解析
npm run preview -- --report

# コードフォーマットチェック
npm run lint

# コードフォーマットチェック＆自動修正
npm run lint -- --fix
```

詳細は[ドキュメント](https://panjiachen.github.io/vue-element-admin-site/guide/essentials/deploy.html)を参照してください。

## 変更履歴

各リリースの詳細な変更点は[リリースノート](https://github.com/PanJiaChen/vue-element-admin/releases)に記載されています。

## オンラインデモ

[プレビュー](https://panjiachen.github.io/vue-element-admin)

## 寄付

本プロジェクトが役立った場合は、作者にジュース一杯をごちそうください :tropical_drink:

![donate](https://wpimg.wallstcn.com/bd273f0d-83a0-4ef2-92e1-9ac8ed3746b9.png)

[Paypal Me](https://www.paypal.me/panfree23)

[Buy me a coffee](https://www.buymeacoffee.com/Pan)

## ブラウザサポート

モダンブラウザおよびInternet Explorer 10以上。

| [<img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/edge/edge_48x48.png" alt="IE / Edge" width="24px" height="24px" />](https://godban.github.io/browsers-support-badges/)</br>IE / Edge | [<img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/firefox/firefox_48x48.png" alt="Firefox" width="24px" height="24px" />](https://godban.github.io/browsers-support-badges/)</br>Firefox | [<img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/chrome/chrome_48x48.png" alt="Chrome" width="24px" height="24px" />](https://godban.github.io/browsers-support-badges/)</br>Chrome | [<img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/safari/safari_48x48.png" alt="Safari" width="24px" height="24px" />](https://godban.github.io/browsers-support-badges/)</br>Safari |
| --------- | --------- | --------- | --------- |
| IE10, IE11, Edge | 最新2バージョン | 最新2バージョン | 最新2バージョン |

## ライセンス

[MIT](https://github.com/PanJiaChen/vue-element-admin/blob/master/LICENSE)

Copyright (c) 2017-present PanJiaChen

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---