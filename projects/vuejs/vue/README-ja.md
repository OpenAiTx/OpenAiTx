## Vue 2はサポート終了（End of Life）となりました

**あなたがご覧になっているのは、現在非アクティブなVue 2のリポジトリです。最新バージョンのVueの積極的にメンテナンスされているリポジトリは[vuejs/core](https://github.com/vuejs/core)です。**

Vueは2023年12月31日をもってサポート終了（End of Life）となりました。今後、新機能やアップデート、修正は提供されません。ただし、既存の配布チャネル（CDN、パッケージマネージャ、Githubなど）での利用は引き続き可能です。

新規プロジェクトを始める場合は、必ず最新バージョンのVue（3.x）から始めてください。また、現在Vue 2をご利用中の方にも、アップグレードを強く推奨いたします（[ガイド](https://v3-migration.vuejs.org/)）。ただし、全ての利用者がすぐに移行できるわけではないことも理解しています。どうしてもVue 2を使い続ける必要があり、かつ保守されていないソフトウェアのコンプライアンスやセキュリティ要件がある場合は、[Vue 2 NES](https://www.herodevs.com/support/nes-vue?utm_source=vuejs-github&utm_medium=vue2-readme)をご覧ください。

<p align="center"><a href="https://vuejs.org" target="_blank" rel="noopener noreferrer"><img width="100" src="https://vuejs.org/images/logo.png" alt="Vue logo"></a></p>

<p align="center">
  <a href="https://circleci.com/gh/vuejs/vue/tree/dev"><img src="https://img.shields.io/circleci/project/github/vuejs/vue/dev.svg?sanitize=true" alt="Build Status"></a>
  <a href="https://codecov.io/github/vuejs/vue?branch=dev"><img src="https://img.shields.io/codecov/c/github/vuejs/vue/dev.svg?sanitize=true" alt="Coverage Status"></a>
  <a href="https://npmcharts.com/compare/vue?minimal=true"><img src="https://img.shields.io/npm/dm/vue.svg?sanitize=true" alt="Downloads"></a>
  <a href="https://www.npmjs.com/package/vue"><img src="https://img.shields.io/npm/v/vue.svg?sanitize=true" alt="Version"></a>
  <a href="https://www.npmjs.com/package/vue"><img src="https://img.shields.io/npm/l/vue.svg?sanitize=true" alt="License"></a>
  <a href="https://chat.vuejs.org/"><img src="https://img.shields.io/badge/chat-on%20discord-7289da.svg?sanitize=true" alt="Chat"></a>
</p>

## スポンサー

Vue.jsはMITライセンスのオープンソースプロジェクトであり、これまでの開発はすべてこれら素晴らしい[支援者](https://github.com/vuejs/core/blob/main/BACKERS.md)のサポートによって実現しています。あなたも支援者に加わりたい場合は、[Vueの開発をスポンサーする](https://vuejs.org/sponsor/)ことをご検討ください。

<p align="center">
  <h3 align="center">特別スポンサー</h3>
</p>

<p align="center">
  <a target="_blank" href="https://github.com/appwrite/appwrite">
  <img alt="special sponsor appwrite" src="https://sponsors.vuejs.org/images/appwrite.svg" width="300">
  </a>
</p>

<p align="center">
  <a target="_blank" href="https://vuejs.org/sponsor/">
    <img alt="sponsors" src="https://sponsors.vuejs.org/sponsors.svg?v3">
  </a>
</p>

---

## はじめに

Vue（発音は「ビュー」/vjuː/）は、ユーザーインターフェース構築のための**プログレッシブフレームワーク**です。最初から段階的に導入できるよう設計されており、用途に応じてライブラリからフレームワークまで柔軟にスケールします。ビュー層のみに特化した扱いやすいコアライブラリと、大規模なシングルページアプリケーションの複雑さに対応するためのサポートライブラリ群で構成されています。

#### ブラウザ対応状況

Vue.jsは[ES5に準拠した](https://compat-table.github.io/compat-table/es5/)全てのブラウザをサポートします（IE8以前はサポート対象外です）。

## エコシステム

| プロジェクト               | ステータス                                                       | 説明                                               |
| ------------------------- | --------------------------------------------------------------- | -------------------------------------------------- |
| [vue-router]              | [![vue-router-status]][vue-router-package]                      | シングルページアプリケーションのルーティング         |
| [vuex]                    | [![vuex-status]][vuex-package]                                  | 大規模な状態管理                                   |
| [vue-cli]                 | [![vue-cli-status]][vue-cli-package]                            | プロジェクトの足場構築                             |
| [vue-loader]              | [![vue-loader-status]][vue-loader-package]                      | webpack用シングルファイルコンポーネント（`*.vue`）ローダー |
| [vue-server-renderer]     | [![vue-server-renderer-status]][vue-server-renderer-package]    | サーバサイドレンダリングのサポート                  |
| [vue-class-component]     | [![vue-class-component-status]][vue-class-component-package]    | クラスベースAPI用TypeScriptデコレーター             |
| [vue-rx]                  | [![vue-rx-status]][vue-rx-package]                              | RxJSとの統合                                       |
| [vue-devtools]            | [![vue-devtools-status]][vue-devtools-package]                  | ブラウザ用DevTools拡張機能                         |

[vue-router]: https://github.com/vuejs/vue-router
[vuex]: https://github.com/vuejs/vuex
[vue-cli]: https://github.com/vuejs/vue-cli
[vue-loader]: https://github.com/vuejs/vue-loader
[vue-server-renderer]: https://github.com/vuejs/vue/tree/dev/packages/vue-server-renderer
[vue-class-component]: https://github.com/vuejs/vue-class-component
[vue-rx]: https://github.com/vuejs/vue-rx
[vue-devtools]: https://github.com/vuejs/vue-devtools
[vue-router-status]: https://img.shields.io/npm/v/vue-router.svg
[vuex-status]: https://img.shields.io/npm/v/vuex.svg
[vue-cli-status]: https://img.shields.io/npm/v/@vue/cli.svg
[vue-loader-status]: https://img.shields.io/npm/v/vue-loader.svg
[vue-server-renderer-status]: https://img.shields.io/npm/v/vue-server-renderer.svg
[vue-class-component-status]: https://img.shields.io/npm/v/vue-class-component.svg
[vue-rx-status]: https://img.shields.io/npm/v/vue-rx.svg
[vue-devtools-status]: https://img.shields.io/chrome-web-store/v/nhdogjmejiglipccpnnnanhbledajbpd.svg
[vue-router-package]: https://npmjs.com/package/vue-router
[vuex-package]: https://npmjs.com/package/vuex
[vue-cli-package]: https://npmjs.com/package/@vue/cli
[vue-loader-package]: https://npmjs.com/package/vue-loader
[vue-server-renderer-package]: https://npmjs.com/package/vue-server-renderer
[vue-class-component-package]: https://npmjs.com/package/vue-class-component
[vue-rx-package]: https://npmjs.com/package/vue-rx
[vue-devtools-package]: https://chrome.google.com/webstore/detail/vuejs-devtools/nhdogjmejiglipccpnnnanhbledajbpd

## ドキュメント

[ライブサンプル](https://v2.vuejs.org/v2/examples/)やドキュメントについては、[vuejs.org](https://v2.vuejs.org)をご覧ください。

## 質問

ご質問やサポートについては、[公式フォーラム](https://forum.vuejs.org)または[コミュニティチャット](https://chat.vuejs.org/)をご利用ください。このリポジトリのIssueリストは**バグ報告と機能要望専用**です。

## イシュー

イシューを投稿する前に、必ず[イシュー報告チェックリスト](https://github.com/vuejs/vue/blob/dev/.github/CONTRIBUTING.md#issue-reporting-guidelines)をお読みください。ガイドラインに沿っていないイシューは即時クローズされる場合があります。

## 変更履歴

各リリースごとの詳細な変更内容は[リリースノート](https://github.com/vuejs/vue/releases)でご確認いただけます。

## 最新情報をフォロー

- [Twitter](https://twitter.com/vuejs)
- [ブログ](https://medium.com/the-vue-point)
- [求人掲示板](https://vuejobs.com/?ref=vuejs)

## 貢献について

プルリクエストを行う前に、必ず[貢献ガイド](https://github.com/vuejs/vue/blob/dev/.github/CONTRIBUTING.md)をお読みください。Vue関連のプロジェクト・コンポーネント・ツールをお持ちの場合は、[このキュレーションリスト](https://github.com/vuejs/awesome-vue)にプルリクエストで追加してください！

既にVueに貢献してくださった全ての皆様に感謝いたします！

<a href="https://github.com/vuejs/vue/graphs/contributors"><img src="https://opencollective.com/vuejs/contributors.svg?width=890" /></a>

## ライセンス

[MIT](https://opensource.org/licenses/MIT)

Copyright (c) 2013-present, Yuxi (Evan) You

---

[Powered By DeepAiTx](https://github.com/DeepAiTx)

---