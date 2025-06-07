<div align="center"><a name="readme-top"></a>

<img height="180" src="https://gw.alipayobjects.com/zos/rmsportal/KDpgvguMpGfqaHPjicRK.svg">

<h1>Ant Design</h1>

エンタープライズクラスのUIデザイン言語およびReact UIライブラリ。

[![CI status][github-action-image]][github-action-url] [![codecov][codecov-image]][codecov-url] [![NPM version][npm-image]][npm-url] [![NPM downloads][download-image]][download-url]

[![][bundlephobia-image]][bundlephobia-url] [![][jsdelivr-image]][jsdelivr-url] [![FOSSA Status][fossa-image]][fossa-url] [![DeepWiki][deepwiki-image]][deepwiki-url]

[![Follow Twitter][twitter-image]][twitter-url] [![Renovate status][renovate-image]][renovate-dashboard-url] [![][issues-helper-image]][issues-helper-url] [![dumi][dumi-image]][dumi-url] [![Issues need help][help-wanted-image]][help-wanted-url]

[Changelog](./CHANGELOG.en-US.md) · [バグ報告][github-issues-url] · [機能リクエスト][github-issues-url] · English · [中文](./README-zh_CN.md)

## ❤️ スポンサーと支援者 [![](https://opencollective.com/ant-design/tiers/sponsors/badge.svg?label=Sponsors&color=brightgreen)](https://opencollective.com/ant-design#support) [![](https://opencollective.com/ant-design/tiers/backers/badge.svg?label=Backers&color=brightgreen)](https://opencollective.com/ant-design#support)

[![](https://opencollective.com/ant-design/tiers/sponsors.svg?avatarHeight=72)](https://opencollective.com/ant-design/contribute/sponsors-218/checkout) [![](https://opencollective.com/ant-design/tiers/backers.svg?avatarHeight=72)](https://opencollective.com/ant-design/contribute/backers-217/checkout)

[npm-image]: https://img.shields.io/npm/v/antd.svg?style=flat-square
[npm-url]: https://npmjs.org/package/antd
[github-action-image]: https://github.com/ant-design/ant-design/actions/workflows/test.yml/badge.svg
[github-action-url]: https://github.com/ant-design/ant-design/actions/workflows/test.yml
[codecov-image]: https://img.shields.io/codecov/c/github/ant-design/ant-design/master.svg?style=flat-square
[codecov-url]: https://codecov.io/gh/ant-design/ant-design/branch/master
[download-image]: https://img.shields.io/npm/dm/antd.svg?style=flat-square
[download-url]: https://npmjs.org/package/antd
[fossa-image]: https://app.fossa.io/api/projects/git%2Bgithub.com%2Fant-design%2Fant-design.svg?type=shield
[fossa-url]: https://app.fossa.io/projects/git%2Bgithub.com%2Fant-design%2Fant-design?ref=badge_shield
[help-wanted-image]: https://flat.badgen.net/github/label-issues/ant-design/ant-design/help%20wanted/open
[help-wanted-url]: https://github.com/ant-design/ant-design/issues?q=is%3Aopen+is%3Aissue+label%3A%22help+wanted%22
[twitter-image]: https://img.shields.io/twitter/follow/AntDesignUI.svg?label=Ant%20Design
[twitter-url]: https://twitter.com/AntDesignUI
[jsdelivr-image]: https://data.jsdelivr.com/v1/package/npm/antd/badge
[jsdelivr-url]: https://www.jsdelivr.com/package/npm/antd
[bundlephobia-image]: https://badgen.net/bundlephobia/minzip/antd?style=flat-square
[bundlephobia-url]: https://bundlephobia.com/package/antd
[issues-helper-image]: https://img.shields.io/badge/using-actions--cool-blue?style=flat-square
[issues-helper-url]: https://github.com/actions-cool
[renovate-image]: https://img.shields.io/badge/renovate-enabled-brightgreen.svg?style=flat-square
[renovate-dashboard-url]: https://github.com/ant-design/ant-design/issues/32498
[dumi-image]: https://img.shields.io/badge/docs%20by-dumi-blue?style=flat-square
[dumi-url]: https://github.com/umijs/dumi
[github-issues-url]: https://new-issue.ant.design
[deepwiki-url]: https://deepwiki.com/ant-design/ant-design
[deepwiki-image]: https://img.shields.io/badge/Chat%20with-DeepWiki%20🤖-20B2AA?style=flat-square

</div>

[![](https://user-images.githubusercontent.com/507615/209472919-6f7e8561-be8c-4b0b-9976-eb3c692aa20a.png)](https://ant.design)

## ✨ 特徴

- 🌈 Webアプリケーション向けに設計されたエンタープライズクラスのUI。
- 📦 高品質なReactコンポーネントをすぐに利用可能。
- 🛡 型の予測がしやすいTypeScriptで記述。
- ⚙️ デザインリソースと開発ツールのフルパッケージ。
- 🌍 数十言語に対応した国際化サポート。
- 🎨 CSS-in-JSベースの強力なテーマカスタマイズ。

## 🖥 対応環境

- 最新のブラウザ
- サーバーサイドレンダリング
- [Electron](https://www.electronjs.org/)

| [<img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/edge/edge_48x48.png" alt="Edge" width="24px" height="24px" />](https://godban.github.io/browsers-support-badges/)<br>Edge | [<img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/firefox/firefox_48x48.png" alt="Firefox" width="24px" height="24px" />](https://godban.github.io/browsers-support-badges/)<br>Firefox | [<img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/chrome/chrome_48x48.png" alt="Chrome" width="24px" height="24px" />](https://godban.github.io/browsers-support-badges/)<br>Chrome | [<img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/safari/safari_48x48.png" alt="Safari" width="24px" height="24px" />](https://godban.github.io/browsers-support-badges/)<br>Safari | [<img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/electron/electron_48x48.png" alt="Electron" width="24px" height="24px" />](https://godban.github.io/browsers-support-badges/)<br>Electron |
| --- | --- | --- | --- | --- |
| Edge | 最新2バージョン | 最新2バージョン | 最新2バージョン | 最新2バージョン |

## 📦 インストール

```bash
npm install antd
```

```bash
yarn add antd
```

```bash
pnpm add antd
```

```bash
bun add antd
```

## 🔨 使い方

```tsx
import { Button, DatePicker } from 'antd';

export default () => (
  <>
    <Button type="primary">PRESS ME</Button>
    <DatePicker placeholder="select date" />
  </>
);
```

## 🔗 リンク

- [ホームページ](https://ant.design/)
- [コンポーネント一覧](https://ant.design/components/overview)
- [変更履歴](CHANGELOG.en-US.md)
- [rc-components](https://react-component.github.io/)
- [🆕 Ant Design X](https://x.ant.design/index-cn)
- [Ant Design Pro](https://pro.ant.design/)
- [Pro Components](https://procomponents.ant.design)
- [Ant Design Mobile](https://mobile.ant.design)
- [Ant Design Mini](https://mini.ant.design)
- [Ant Design Charts](https://charts.ant.design)
- [Ant Design Web3](https://web3.ant.design)
- [ランディングページ](https://landing.ant.design)
- [Ant Motion](https://motion.ant.design)
- [Scaffold Market](https://scaffold.ant.design)
- [開発者向けガイド](https://github.com/ant-design/ant-design/wiki/Development)
- [バージョン管理リリースノート](https://github.com/ant-design/ant-design/wiki/%E8%BD%AE%E5%80%BC%E8%A7%84%E5%88%99%E5%92%8C%E7%89%88%E6%9C%AC%E5%8F%91%E5%B8%83%E6%B5%81%E7%A8%8B)
- [FAQ](https://ant.design/docs/react/faq)
- [オンラインプレイグラウンド](https://u.ant.design/reproduce)（バグ報告用）
- [テーマのカスタマイズ](https://ant.design/docs/react/customize-theme)
- [コラボレーター申請方法](https://github.com/ant-design/ant-design/wiki/Collaborators#how-to-apply-for-being-a-collaborator)

## ⌨️ 開発

無料のオンラインフロントエンド開発環境 [opensumi.run](https://opensumi.run) をご利用ください。

[![opensumi.run](https://custom-icon-badges.demolab.com/badge/opensumi-run-blue.svg?logo=opensumi)](https://opensumi.run/ide/ant-design/ant-design)

またはローカルでクローン：

```bash
$ git clone git@github.com:ant-design/ant-design.git
$ cd ant-design
$ npm install
$ npm start
```

ブラウザで http://127.0.0.1:8001 を開いてください。詳細は[開発ガイド](https://github.com/ant-design/ant-design/wiki/Development)をご覧ください。

## 🤝 コントリビューション [![PRs Welcome](https://img.shields.io/badge/PRs-welcome-brightgreen.svg?style=flat-square)](https://makeapullrequest.com)

<table>
<tr>
  <td>
    <a href="https://next.ossinsight.io/widgets/official/compose-recent-top-contributors?repo_id=34526884" target="_blank" style="display: block" align="center">
      <picture>
        <source media="(prefers-color-scheme: dark)" srcset="https://next.ossinsight.io/widgets/official/compose-recent-top-contributors/thumbnail.png?repo_id=34526884&image_size=auto&color_scheme=dark" width="280">
        <img alt="Top Contributors of ant-design/ant-design - Last 28 days" src="https://next.ossinsight.io/widgets/official/compose-recent-top-contributors/thumbnail.png?repo_id=34526884&image_size=auto&color_scheme=light" width="280">
      </picture>
    </a>
  </td>
  <td rowspan="2">
    <a href="https://next.ossinsight.io/widgets/official/compose-last-28-days-stats?repo_id=34526884" target="_blank" style="display: block" align="center">
      <picture>
        <source media="(prefers-color-scheme: dark)" srcset="https://next.ossinsight.io/widgets/official/compose-last-28-days-stats/thumbnail.png?repo_id=34526884&image_size=auto&color_scheme=dark" width="655" height="auto">
        <img alt="Performance Stats of ant-design/ant-design - Last 28 days" src="https://next.ossinsight.io/widgets/official/compose-last-28-days-stats/thumbnail.png?repo_id=34526884&image_size=auto&color_scheme=light" width="655" height="auto">
      </picture>
    </a>
  </td>
</tr>
<tr>
  <td>
    <a href="https://next.ossinsight.io/widgets/official/compose-org-active-contributors?period=past_28_days&activity=new&owner_id=12101536&repo_ids=34526884" target="_blank" style="display: block" align="center">
      <picture>
        <source media="(prefers-color-scheme: dark)" srcset="https://next.ossinsight.io/widgets/official/compose-org-active-contributors/thumbnail.png?period=past_28_days&activity=new&owner_id=12101536&repo_ids=34526884&image_size=2x3&color_scheme=dark" width="273" height="auto">
        <img alt="New participants of ant-design - past 28 days" src="https://next.ossinsight.io/widgets/official/compose-org-active-contributors/thumbnail.png?period=past_28_days&activity=new&owner_id=12101536&repo_ids=34526884&image_size=2x3&color_scheme=light" width="273" height="auto">
      </picture>
    </a>
  </td>
</tr>
</table>

<a href="https://openomy.app/github/ant-design/ant-design" target="_blank" style="display: block; width: 100%;" align="center">
  <img src="https://openomy.app/svg?repo=ant-design/ant-design&chart=bubble&latestMonth=3" target="_blank" alt="Contribution Leaderboard" style="display: block; width: 100%;" />
</a>

より良い antd を共に作りましょう。

皆さまからの貢献を心よりお待ちしています。始める前に、[コントリビューションガイド](https://ant.design/docs/react/contributing)をご一読ください。[Pull Request](https://github.com/ant-design/ant-design/pulls) や [GitHub Issues](https://github.com/ant-design/ant-design/issues) でお気軽にアイデアを共有してください。コードベースの改善に興味がある方は、[開発ガイド](https://github.com/ant-design/ant-design/wiki/Development)をご参照の上、コーディングをお楽しみください！ :)

コラボレーターの方は、[Pull Request原則](https://github.com/ant-design/ant-design/wiki/PR-principle)に従い、[Pull Requestテンプレート](https://github.com/ant-design/ant-design/wiki/PR-principle#pull-request-template)を利用してPRを作成してください。

## Issue資金提供

[Issuehunt](https://issuehunt.io/repos/3452688) を利用して、見てみたい・実装してほしい特定の機能に投票・支援できます。バックログをチェックし、ご協力ください：

[![Let's fund issues in this repository](https://raw.githubusercontent.com/BoostIO/issuehunt-materials/master/v1/issuehunt-button-v1.svg)](https://issuehunt.io/repos/34526884)


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---