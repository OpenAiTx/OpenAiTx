# arcade-songs

[![Coding Style](https://img.shields.io/badge/code_style-airbnb-%234B32C3)](https://github.com/airbnb/javascript) [![Gitmoji](https://img.shields.io/badge/commit_style-%20😜%20😍-%23FFDD67)](https://gitmoji.dev) [![Translation status](https://hosted.weblate.org/widgets/arcade-songs/-/svg-badge.svg)](https://hosted.weblate.org/engage/arcade-songs/) [![FOSSA Status](https://app.fossa.com/api/projects/git%2Bgithub.com%2Fzetaraku%2Farcade-songs.svg?type=shield)](https://app.fossa.com/projects/git%2Bgithub.com%2Fzetaraku%2Farcade-songs?ref=badge_shield)

アーケードゲームの楽曲と譜面の検索インターフェースを提供するユーティリティサイト。

## 前提条件

- [Node.js](https://nodejs.org/)（LTSバージョン以上）
- [Yarn](https://yarnpkg.com/)

## セットアップ

```sh
# install dependencies
yarn install
```

- `.env.example` ファイルを `.env` としてコピーし、必要な項目を入力します。

## 開発

```sh
# serve with hot reload at localhost
yarn run dev

# serve with hot reload on local network
yarn run dev:host
```
- 各ディレクトリの詳細な説明については、[Nuxtドキュメント](https://nuxtjs.org)をご覧ください。

## 本番環境用ビルド

### SSGによる静的ホスティング（推奨）


```sh
# Build the application (if needed), generate every route as a HTML file and statically export to dist/ directory (used for static hosting).
yarn run generate

# serve the dist/ directory like your static hosting would do (Netlify, Vercel, Surge, etc), great for testing before deploying.
yarn run serve
```

### SSRによるサーバーホスティング

```sh
# Build and optimize your application with webpack for production.
yarn run build

# Start the production server (after running nuxt build). Use it for Node.js hosting like Heroku, Digital Ocean, etc.
yarn run start
```
## データソース

参照: <https://github.com/zetaraku/arcade-songs-fetch>

## 貢献について

[![翻訳状況](https://hosted.weblate.org/widgets/arcade-songs/-/287x66-grey.png)](https://hosted.weblate.org/engage/arcade-songs/)

**arcade-songs** は現在、開発者と翻訳者の両方が翻訳を容易に行えるよう設計されたウェブツール [Weblate](https://weblate.org/) を使って翻訳されています。

翻訳に問題を見つけた場合、以下のいずれかで改善にご協力いただけます：

- [Weblateで直接編集する](https://hosted.weblate.org/projects/arcade-songs/arcade-songs/)
- 問題を指摘するために[イシューを開く](https://github.com/zetaraku/arcade-songs/issues)
- 編集内容を提出するために[プルリクエストを作成する](https://github.com/zetaraku/arcade-songs/pulls)

翻訳ファイルは `locales/` にあります。

ご意見やご提案がある場合は、[イシューを開く](https://github.com/zetaraku/arcade-songs/issues)か[問い合わせフォームを利用する](https://arcade-songs-report.zetaraku.dev/)ことができます。

## 貢献者 ✨

- **韓国語** 翻訳
  - [Sungsoo Han (lomotos10)](https://github.com/lomotos10)
  - [DDinghoya (DDinghoya)](https://github.com/DDinghoya)
- **スペイン語** 翻訳
  - [gallegonovato (gallegonovato)](https://github.com/gallegonovato)
  - [Onyx (VendettaCalls)](https://github.com/VendettaCalls)
- **インドネシア語** 翻訳
  - [Echo (echocentrical)](https://github.com/echocentrical)

## 特別な感謝 ✨

- **maimai** の内部レベル情報
  - [maimai譜面定数ちほー🏖☀️ (@maiLv_Chihooooo)](https://twitter.com/maiLv_Chihooooo)
- **CHUNITHM** の内部レベル情報
  - [CHUNITHM譜面定数メインフレーム (@RCMF_chunithm)](https://twitter.com/RCMF_chunithm)
  - [chunirec チュウニズム非公式スコア管理ツール (@chunirec)](https://twitter.com/chunirec)
- **オンゲキ** の内部レベル情報

  - [オンゲキ譜面定数部 (@ongeki_level)](https://twitter.com/ongeki_level)
  - [OngekiScoreLog - オンゲキ非公式スコアツール (@ongeki_score)](https://twitter.com/ongeki_score)
- **ノスタルジア** の内部レベル情報
  - [EXP? (@exponent_iidx)](https://twitter.com/exponent_iidx)
  - [Nosdata (@nosdata)](https://twitter.com/nosdata)
- **maimai China ver. (舞萌DX)** の譜面情報
  - [CrazyKid (@CrazyKidCN)](https://github.com/CrazyKidCN)
- *…そして譜面データの提供や問題報告にご協力いただいているすべてのプレイヤーの皆様！*

## ライセンス

Copyright © 2022 Raku Zeta.

[MITライセンス](./LICENSE) の下でライセンスされています。

[![FOSSA Status](https://app.fossa.com/api/projects/git%2Bgithub.com%2Fzetaraku%2Farcade-songs.svg?type=large)](https://app.fossa.com/projects/git%2Bgithub.com%2Fzetaraku%2Farcade-songs?ref=badge_large)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-07

---