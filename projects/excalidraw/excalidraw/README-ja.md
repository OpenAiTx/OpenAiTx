<a href="https://excalidraw.com/" target="_blank" rel="noopener">
  <picture>
    <source media="(prefers-color-scheme: dark)" alt="Excalidraw" srcset="https://excalidraw.nyc3.cdn.digitaloceanspaces.com/github/excalidraw_github_cover_2_dark.png" />
    <img alt="Excalidraw" src="https://excalidraw.nyc3.cdn.digitaloceanspaces.com/github/excalidraw_github_cover_2.png" />
  </picture>
</a>

<h4 align="center">
  <a href="https://excalidraw.com">Excalidraw エディター</a> |
  <a href="https://plus.excalidraw.com/blog">ブログ</a> |
  <a href="https://docs.excalidraw.com">ドキュメント</a> |
  <a href="https://plus.excalidraw.com">Excalidraw+</a>
</h4>

<div align="center">
  <h2>
    オープンソースの手描き風バーチャルホワイトボード。 </br>
    コラボレーション対応・エンドツーエンド暗号化。 </br>
  <br />
  </h2>
</div>

<br />
<p align="center">
  <a href="https://github.com/excalidraw/excalidraw/blob/master/LICENSE">
    <img alt="ExcalidrawはMITライセンスで公開されています。" src="https://img.shields.io/badge/license-MIT-blue.svg"  />
  </a>
  <a href="https://www.npmjs.com/package/@excalidraw/excalidraw">
    <img alt="npmダウンロード/月" src="https://img.shields.io/npm/dm/@excalidraw/excalidraw"  />
  </a>
  <a href="https://docs.excalidraw.com/docs/introduction/contributing">
    <img alt="PR歓迎！" src="https://img.shields.io/badge/PRs-welcome-brightgreen.svg?style=flat"  />
  </a>
  <a href="https://discord.gg/UexuTaE">
    <img alt="Discordでチャット" src="https://img.shields.io/discord/723672430744174682?color=738ad6&label=Chat%20on%20Discord&logo=discord&logoColor=ffffff&widge=false"/>
  </a>
  <a href="https://deepwiki.com/excalidraw/excalidraw">
    <img alt="DeepWikiに質問" src="https://deepwiki.com/badge.svg" />
  </a>
  <a href="https://twitter.com/excalidraw">
    <img alt="TwitterでExcalidrawをフォロー" src="https://img.shields.io/twitter/follow/excalidraw.svg?label=follow+@excalidraw&style=social&logo=twitter"/>
  </a>
</p>

<div align="center">
  <figure>
    <a href="https://excalidraw.com" target="_blank" rel="noopener">
      <img src="https://excalidraw.nyc3.cdn.digitaloceanspaces.com/github%2Fproduct_showcase.png" alt="製品ショーケース" />
    </a>
    <figcaption>
      <p align="center">
        美しい手描き風の図、ワイヤーフレーム、その他お好きなものを作成できます。
      </p>
    </figcaption>
  </figure>
</div>

## 機能

Excalidrawエディター（npmパッケージ）は以下をサポートします：

- 💯&nbsp;無料・オープンソース
- 🎨&nbsp;無限大のキャンバスベースホワイトボード
- ✍️&nbsp;手描き風スタイル
- 🌓&nbsp;ダークモード
- 🏗️&nbsp;カスタマイズ可能
- 📷&nbsp;画像サポート
- 😀&nbsp;図形ライブラリ対応
- 🌐&nbsp;多言語対応（i18n）
- 🖼️&nbsp;PNG、SVG、クリップボードへのエクスポート
- 💾&nbsp;オープンフォーマット - `.excalidraw` jsonファイルとしてエクスポート可能
- ⚒️&nbsp;多彩なツール - 四角形、円、ひし形、矢印、線、フリーハンド、消しゴム など
- ➡️&nbsp;矢印のバインディング＆ラベル付き矢印
- 🔙&nbsp;元に戻す／やり直し
- 🔍&nbsp;ズームとパン操作対応

## Excalidraw.com

[excalidraw.com](https://excalidraw.com) にホストされているアプリは、Excalidrawで構築できるものの最小限のショーケースです。その[ソースコード](https://github.com/excalidraw/excalidraw/tree/master/excalidraw-app)もこのリポジトリに含まれており、以下の機能があります：

- 📡&nbsp;PWA対応（オフライン動作）
- 🤼&nbsp;リアルタイムコラボレーション
- 🔒&nbsp;エンドツーエンド暗号化
- 💾&nbsp;ローカルファースト対応（ブラウザに自動保存）
- 🔗&nbsp;共有可能リンク（読み取り専用リンクとしてエクスポートし、他者と共有可能）

これらの機能は将来的にnpmパッケージ用のドロップインプラグインとして追加予定です。

## クイックスタート

**注意:** 以下の手順は、Excalidrawを自分のアプリに統合する際の [npmパッケージ](https://www.npmjs.com/package/@excalidraw/excalidraw) のインストール方法です。リポジトリをローカルで開発用に実行したい場合は、[開発ガイド](https://docs.excalidraw.com/docs/introduction/development) を参照してください。

`npm` または `yarn` でパッケージをインストールしてください。

```bash
npm install react react-dom @excalidraw/excalidraw
# または
yarn add react react-dom @excalidraw/excalidraw
```

詳細は[ドキュメント](https://docs.excalidraw.com/docs/@excalidraw/excalidraw/installation)をご覧ください！

## コントリビューション

- 機能が足りない、またはバグを発見した場合は[こちらで報告](https://github.com/excalidraw/excalidraw/issues)してください。
- 貢献したい方は、[コントリビューションガイド](https://docs.excalidraw.com/docs/introduction/contributing) をご覧いただくか、[Discord](https://discord.gg/UexuTaE)でご連絡ください。
- 翻訳にご協力いただける方は、[翻訳ガイド](https://docs.excalidraw.com/docs/introduction/contributing#translating) をご覧ください。

## インテグレーション

- [VScode拡張機能](https://marketplace.visualstudio.com/items?itemName=pomdtr.excalidraw-editor)
- [npmパッケージ](https://www.npmjs.com/package/@excalidraw/excalidraw)

## Excalidrawを統合している企業・サービス

[Google Cloud](https://googlecloudcheatsheet.withgoogle.com/architecture) • [Meta](https://meta.com/) • [CodeSandbox](https://codesandbox.io/) • [Obsidian Excalidraw](https://github.com/zsviczian/obsidian-excalidraw-plugin) • [Replit](https://replit.com/) • [Slite](https://slite.com/) • [Notion](https://notion.so/) • [HackerRank](https://www.hackerrank.com/) • 他多数

## スポンサーとサポート

本プロジェクトを気に入っていただけた場合は、[Open Collective](https://opencollective.com/excalidraw) でスポンサーになるか、[Excalidraw+](https://plus.excalidraw.com/) をご利用いただけます。

## Excalidrawを支援していただきありがとうございます

[<img src="https://opencollective.com/excalidraw/tiers/sponsors/0/avatar.svg?avatarHeight=120"/>](https://opencollective.com/excalidraw/tiers/sponsors/0/website) [<img src="https://opencollective.com/excalidraw/tiers/sponsors/1/avatar.svg?avatarHeight=120"/>](https://opencollective.com/excalidraw/tiers/sponsors/1/website) [<img src="https://opencollective.com/excalidraw/tiers/sponsors/2/avatar.svg?avatarHeight=120"/>](https://opencollective.com/excalidraw/tiers/sponsors/2/website) [<img src="https://opencollective.com/excalidraw/tiers/sponsors/3/avatar.svg?avatarHeight=120"/>](https://opencollective.com/excalidraw/tiers/sponsors/3/website) [<img src="https://opencollective.com/excalidraw/tiers/sponsors/4/avatar.svg?avatarHeight=120"/>](https://opencollective.com/excalidraw/tiers/sponsors/4/website) [<img src="https://opencollective.com/excalidraw/tiers/sponsors/5/avatar.svg?avatarHeight=120"/>](https://opencollective.com/excalidraw/tiers/sponsors/5/website) [<img src="https://opencollective.com/excalidraw/tiers/sponsors/6/avatar.svg?avatarHeight=120"/>](https://opencollective.com/excalidraw/tiers/sponsors/6/website) [<img src="https://opencollective.com/excalidraw/tiers/sponsors/7/avatar.svg?avatarHeight=120"/>](https://opencollective.com/excalidraw/tiers/sponsors/7/website) [<img src="https://opencollective.com/excalidraw/tiers/sponsors/8/avatar.svg?avatarHeight=120"/>](https://opencollective.com/excalidraw/tiers/sponsors/8/website) [<img src="https://opencollective.com/excalidraw/tiers/sponsors/9/avatar.svg?avatarHeight=120"/>](https://opencollective.com/excalidraw/tiers/sponsors/9/website) [<img src="https://opencollective.com/excalidraw/tiers/sponsors/10/avatar.svg?avatarHeight=120"/>](https://opencollective.com/excalidraw/tiers/sponsors/10/website)

<a href="https://opencollective.com/excalidraw#category-CONTRIBUTE" target="_blank"><img src="https://opencollective.com/excalidraw/tiers/backers.svg?avatarHeight=32"/></a>

最後に、以下の企業の無償サービス提供にも感謝いたします：

[![Vercel](./.github/assets/vercel.svg)](https://vercel.com) [![Sentry](./.github/assets/sentry.svg)](https://sentry.io) [![Crowdin](./.github/assets/crowdin.svg)](https://crowdin.com)

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---