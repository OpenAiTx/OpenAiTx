<p align="center">
  <a href="https://storybook.js.org/">
    <picture>
      <source media="(prefers-color-scheme: dark)" srcset="https://user-images.githubusercontent.com/263385/199832481-bbbf5961-6a26-481d-8224-51258cce9b33.png">
      <img src="https://user-images.githubusercontent.com/321738/63501763-88dbf600-c4cc-11e9-96cd-94adadc2fd72.png" alt="Storybook" width="400" />
    </picture>
  </a>
</p>

<p align="center">堅牢なUIコンポーネントをより速く構築</p>

<br/>

<p align="center">
  <a href="https://circleci.com/gh/storybookjs/storybook">
    <img src="https://circleci.com/gh/storybookjs/storybook.svg?style=shield" alt="Build Status on CircleCI" />
  </a>
  <a href="https://codecov.io/gh/storybookjs/storybook">
    <img src="https://codecov.io/gh/storybookjs/storybook/branch/main/graph/badge.svg" alt="codecov" />
  </a>
  <a href="https://github.com/storybookjs/storybook/blob/main/LICENSE">
    <img src="https://img.shields.io/github/license/storybookjs/storybook.svg" alt="License" />
  </a>
  <br/>
  <a href="https://discord.gg/storybook">
    <img src="https://img.shields.io/badge/discord-join-7289DA.svg?logo=discord&longCache=true&style=flat" />
  </a>
  <a href="https://storybook.js.org/community/">
    <img src="https://img.shields.io/badge/community-join-4BC424.svg" alt="Storybook Community" />
  </a>
  <a href="#backers">
    <img src="https://opencollective.com/storybook/backers/badge.svg" alt="Backers on Open Collective" />
  </a>
  <a href="#sponsors">
    <img src="https://opencollective.com/storybook/tiers/sponsors/badge.svg" alt="Sponsors on Open Collective" />
  </a>
  <a href="https://x.com/intent/follow?screen_name=storybookjs">
    <img src="https://img.shields.io/twitter/follow/storybookjs?color=blue&logo=twitter" alt="Official Twitter Handle" />
  </a>
  <a href="https://api.securityscorecards.dev/projects/github.com/storybookjs/storybook">
    <img src="https://api.securityscorecards.dev/projects/github.com/storybookjs/storybook/badge" alt="OpenSSF Scorecard"/>
  </a>
</p>

<p align="center">
Storybookは、UIコンポーネントやページを個別に構築するためのフロントエンドワークショップです。数千のチームが、UI開発・テスト・ドキュメント作成にStorybookを利用しています。詳細は https://storybook.js.org でご確認ください！
</p>

<center>
  <img src="https://raw.githubusercontent.com/storybookjs/storybook/main/media/storybook-intro.gif" width="100%" />
</center>

<p align="center">
  各種READMEはこちら：<br/>
  <a href="https://github.com/storybookjs/storybook/blob/main/README.md" title="latest"><img alt="latest" src="https://img.shields.io/npm/v/@storybook/react/latest?style=for-the-badge&logo=storybook&logoColor=ffffff&color=66BF3C" /></a>
  <a href="https://github.com/storybookjs/storybook/blob/next/README.md" title="next"><img alt="next" src="https://img.shields.io/npm/v/@storybook/react/next?style=for-the-badge&logo=storybook&logoColor=ffffff&color=1EA7FD" /></a>
</p>

## 目次

- 🚀 [はじめに](#getting-started)
- 📒 [プロジェクト一覧](#projects)
  - 🛠 [対応フレームワーク＆サンプル](#supported-frameworks)
  - 🔗[アドオン](#addons)
- 🏅 [バッジ＆発表資料](#badges--presentation-materials)
- 👥 [コミュニティ](#community)
- 👏 [コントリビュート](#contributing)
  - 👨‍💻 [開発用スクリプト](#development-scripts)
  - 💸 [スポンサー](#sponsors)
  - 💵 [支援者](#backers)
- :memo: [ライセンス](#license)

## はじめに

[Storybook公式サイト](https://storybook.js.org) で、Storybookについて詳しく知り、使い始めましょう。

### ドキュメント

ドキュメントは [Storybookのドキュメントサイト](https://storybook.js.org/docs) で閲覧できます。

### サンプル

[Component Encyclopedia](https://storybook.js.org/showcase) で、主要なチームがどのようにStorybookを利用しているかを見てみましょう。

[storybook.new](https://storybook.new) を使えば、Stackblitz上で素早くサンプルプロジェクトを作成できます。

Storybookには、コンポーネント設計・ドキュメント化・テスト・インタラクティブ性向上など多くの[アドオン](https://storybook.js.org/docs/configure/user-interface/storybook-addons)が用意されています。StorybookのAPIを使えば、さまざまな方法で設定や拡張が可能です。また、React Native・Android・iOS・Flutterなどモバイル開発にも拡張されています。

### コミュニティ

追加のサポートが必要な場合は、[GitHub Discussions](https://github.com/storybookjs/storybook/discussions/new?category=help)で質問を共有してください。

## プロジェクト一覧

### 対応フレームワーク

| レンダラー                                                      | デモ                                                                                                                                                                         |                                                                                                                                                       |
| -------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------- |
| [React](code/renderers/react)                                  | [![Storybook demo](https://img.shields.io/npm/v/@storybook/react/latest?style=flat-square&color=blue&label)](https://next--630511d655df72125520f051.chromatic.com/)          | [![React](https://img.shields.io/npm/dm/@storybook/react?style=flat-square&color=eee)](code/renderers/react)                                          |
| [Angular](code/frameworks/angular/)                            | [![Storybook demo](https://img.shields.io/npm/v/@storybook/angular/latest?style=flat-square&color=blue&label)](https://next--6322ce6af69825592bbb28fc.chromatic.com/)        | [![Angular](https://img.shields.io/npm/dm/@storybook/angular?style=flat-square&color=eee)](code/frameworks/angular/)                                  |
| [Vue 3](code/renderers/vue3)                                   | [![Storybook demo](https://img.shields.io/npm/v/@storybook/vue3/latest?style=flat-square&color=blue&label)](https://next--630513346a8e284ae244d415.chromatic.com/)           | [![Vue 3](https://img.shields.io/npm/dm/@storybook/vue3?style=flat-square&color=eee)](code/renderers/vue3/)                                           |
| [Web components](code/renderers/web-components)                | [![Storybook demo](https://img.shields.io/npm/v/@storybook/web-components/latest?style=flat-square&color=blue&label)](https://next--638db5bf49adfdfe8cf545e0.chromatic.com/) | [![Svelte](https://img.shields.io/npm/dm/@storybook/web-components?style=flat-square&color=eee)](code/renderers/web-components)                       |
| [React Native](https://github.com/storybookjs/react-native)    | [![](https://img.shields.io/npm/v/@storybook/react-native/latest?style=flat-square&color=blue&label)](/)                                                                     | [![React Native](https://img.shields.io/npm/dm/@storybook/react-native?style=flat-square&color=eee)](https://github.com/storybookjs/react-native)     |
| [HTML](code/renderers/html)                                    | [![Storybook demo](https://img.shields.io/npm/v/@storybook/html/latest?style=flat-square&color=blue&label)](https://next--63dd39a158cf6fc05199b4bb.chromatic.com/)           | [![HTML](https://img.shields.io/npm/dm/@storybook/html?style=flat-square&color=eee)](code/renderers/html)                                             |
| [Ember](code/frameworks/ember/)                                | [![](https://img.shields.io/npm/v/@storybook/ember/latest?style=flat-square&color=blue&label)](/)                                                                            | [![Ember](https://img.shields.io/npm/dm/@storybook/ember?style=flat-square&color=eee)](code/frameworks/ember/)                                        |
| [Svelte](code/renderers/svelte)                                | [![Storybook demo](https://img.shields.io/npm/v/@storybook/svelte/latest?style=flat-square&color=blue&label)](https://next--630873996e4e3557791c069c.chromatic.com/)         | [![Svelte](https://img.shields.io/npm/dm/@storybook/svelte?style=flat-square&color=eee)](code/renderers/svelte)                                       |
| [Preact](code/renderers/preact)                                | [![Storybook demo](https://img.shields.io/npm/v/@storybook/preact/latest?style=flat-square&color=blue&label)](https://next--63b588a512565bfaace15e7c.chromatic.com/)         | [![Preact](https://img.shields.io/npm/dm/@storybook/preact?style=flat-square&color=eee)](code/renderers/preact)                                       |
| [Qwik](https://github.com/literalpie/storybook-framework-qwik) | [![](https://img.shields.io/npm/v/storybook-framework-qwik/latest?style=flat-square&color=blue&label)](/)                                                                    | [![Qwik](https://img.shields.io/npm/dm/storybook-framework-qwik?style=flat-square&color=eee)](https://github.com/literalpie/storybook-framework-qwik) |
| [SolidJS](https://github.com/storybookjs/solidjs)              | [![](https://img.shields.io/npm/v/storybook-solidjs/latest?style=flat-square&color=blue&label)](/)                                                                           | [![SolidJS](https://img.shields.io/npm/dm/storybook-solidjs?style=flat-square&color=eee)](https://github.com/storybookjs/solidjs)                     |
| [Android, iOS, Flutter](https://github.com/storybookjs/native) | [![](https://img.shields.io/npm/v/@storybook/native/latest?style=flat-square&color=blue&label)](/)                                                                           | [![Native](https://img.shields.io/npm/dm/@storybook/native?style=flat-square&color=eee)](https://github.com/storybookjs/native)                       |

### アドオン

| アドオン                                                                    | 説明                                                                     |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------ |
| [a11y](code/addons/a11y/)                                                 | Storybookでユーザーアクセシビリティをテスト                              |
| [actions](code/core/src/actions/)                                         | Storybook UI上でのユーザー操作を記録                                     |
| [backgrounds](code/core/src/backgrounds)                                  | Storybook UIで背景色を選択できる                                         |
| [cssresources](https://github.com/storybookjs/addon-cssresources)         | コンポーネントiframeにCSSリソースを動的に追加/削除                       |
| [design assets](https://github.com/storybookjs/addon-design-assets)       | ストーリーと一緒に画像・動画・Webリンクを表示                             |
| [docs](code/addons/docs/)                                                 | コンポーネントに高品質なドキュメントを追加                               |
| [events](https://github.com/storybookjs/addon-events)                     | EventEmitterに対応したコンポーネントへイベントをインタラクティブに発火   |
| [google-analytics](https://github.com/storybookjs/addon-google-analytics) | ストーリーにGoogleアナリティクスをレポート                               |
| [graphql](https://github.com/storybookjs/addon-graphql)                   | Storybookストーリー内でGraphQLサーバーへクエリ                            |
| [jest](code/addons/jest/)                                                 | Storybookでコンポーネントのユニットテスト結果を表示                      |
| [links](code/addons/links/)                                               | ストーリー間にリンクを作成                                               |
| [measure](code/core/src/measure/)                                         | Storybook UI内でレイアウトやボックスモデルを視覚的に確認                  |
| [outline](code/core/src/outline/)                                         | Storybook UI内でCSSレイアウトや整列を視覚的にデバッグ                     |
| [query params](https://github.com/storybookjs/addon-queryparams)          | クエリパラメータをモック                                                 |
| [viewport](code/core/src/viewport/)                                       | Storybookでレスポンシブ対応コンポーネントの表示サイズやレイアウトを変更   |

[アドオン/フレームワークのサポート表](https://storybook.js.org/docs/configure/integration/frameworks-feature-support)もご覧ください。

より良い体験のため、新しいツールへの移行に伴い一部アドオンを非推奨または削除する場合があります。

info/notesアドオンをご利用の場合は、[docs](code/addons/docs/)への移行を強く推奨します。[移行ガイド](code/addons/docs/docs/recipes.md#migrating-from-notesinfo-addons)もご利用ください。

contextsアドオンをご利用の場合は、[toolbars](https://github.com/storybookjs/storybook/tree/next/code/addons/toolbars)への移行を推奨します。[移行ガイド](https://github.com/storybookjs/storybook/blob/next/MIGRATION.md#deprecated-addon-contexts)も参照ください。

addon-storyshotsをご利用の場合は、Storybook [test-runner](https://github.com/storybookjs/test-runner)への移行を推奨します。[移行ガイド](https://storybook.js.org/docs/writing-tests/storyshots-migration-guide)もご覧ください。

## バッジ＆発表資料

Storybookバッジをご利用ください。ご自身のStorybookの公開例にリンクしましょう。

![Storybook](https://cdn.jsdelivr.net/gh/storybookjs/brand@main/badge/badge-storybook.svg)

```md
[![Storybook](https://cdn.jsdelivr.net/gh/storybookjs/brand@main/badge/badge-storybook.svg)](link to site)
```

Storybookのプレゼン資料として使えるロゴ・動画・カラーパレット等は、[brandリポジトリ](https://github.com/storybookjs/brand)で提供しています。

## コミュニティ

- [@storybookjs](https://x.com/storybookjs) でツイート
- [storybook.js.org](https://storybook.js.org/blog/) および [Medium](https://medium.com/storybookjs) でブログ発信
- [Discord](https://discord.gg/storybook) でチャット
- [YouTube](https://www.youtube.com/channel/UCr7Quur3eIyA_oe8FNYexfg) で動画・配信

## コントリビュート

Storybookへの貢献はいつでも大歓迎です！

- 📥 プルリクエストや 🌟 スターも歓迎します。
- [コントリビュートガイド](CONTRIBUTING.md)を読んで始めてみましょう。
  または [Discord](https://discord.gg/storybook) でお話しください。丁寧にサポートします。

初めて取り組むIssueをお探しですか？

- [![Good First Issue](https://img.shields.io/github/issues/storybookjs/storybook/good%20first%20issue.svg)](https://github.com/storybookjs/storybook/issues?q=is%3Aopen+is%3Aissue+label%3A%22good+first+issue%22) のラベル付きIssueは、コードベースやOSS初心者の方におすすめです。
- [Discordでご相談ください](https://discord.gg/storybook)。あなたのスキルや興味に合うタスクを一緒に見つけます。

### 開発用スクリプト

Storybookはモノレポ構成です。主なスクリプトは以下の通りです：

#### `yarn start`

> テスト用ストーリー付きのサンドボックステンプレートStorybookを起動

#### `yarn task`

> 上記に加え、サンドボックスのカスタマイズ（他フレームワーク選択など）が可能

#### `yarn lint`

> コードがLintルールに準拠しているかをチェック（remark & eslint使用）

- `yarn lint:js` - JSチェック
- `yarn lint:md` - Markdown＋コードサンプルチェック
- `yarn lint:js --fix` - JSを自動修正

#### `yarn test`

> ユニットテストがすべてパスするかチェック（jest使用）

- `yarn run test --core --watch` - コアテストをウォッチモードで実行

### スポンサー

スポンサーになると、GitHubのREADMEにロゴとWebサイトURLを掲載できます。 \[[スポンサーになる](https://opencollective.com/storybook#sponsor)]

<a href="https://opencollective.com/storybook/tiers/sponsors/0/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/0/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/1/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/1/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/2/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/2/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/3/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/3/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/4/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/4/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/5/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/5/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/6/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/6/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/7/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/7/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/8/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/8/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/9/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/9/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/10/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/10/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/11/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/11/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/12/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/12/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/13/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/13/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/14/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/14/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/15/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/15/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/16/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/16/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/17/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/17/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/18/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/18/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/19/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/19/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/20/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/20/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/21/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/21/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/22/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/22/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/23/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/23/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/24/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/24/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/25/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/25/avatar.svg?requireActive=true"></a>

### 支援者

定期的な寄付により、私たちの活動を支援できます。 \[[支援者になる](https://opencollective.com/storybook#backer)]

<a href="https://opencollective.com/storybook"><img src="https://opencollective.com/storybook/tiers/backers.svg?limit=80&button=false&avatarHeight=46&width=750"></a>

## ライセンス

[MIT](https://github.com/storybookjs/storybook/blob/main/LICENSE)

-the end-

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---