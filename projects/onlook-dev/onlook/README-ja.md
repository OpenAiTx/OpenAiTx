<!-- 戻るリンクの互換性向上: 参照: https://github.com/othneildrew/Best-README-Template/pull/73 -->

<div align="center">
<img width="800" alt="header image" src="https://raw.githubusercontent.com/onlook-dev/onlook/main/assets/web-preview.png">
<h3 align="center">Onlook</h3>
  <p align="center">
    デザイナーのためのカーソル
    <br />
    <a href="https://docs.onlook.com"><strong>ドキュメントを探索する »</strong></a>
    <br />
    <br />
    <a href="https://youtu.be/RSX_3EaO5eU?feature=shared">デモを見る</a>
    ·
    <a href="https://github.com/onlook-dev/onlook/issues/new?labels=bug&template=bug-report---.md">バグを報告</a>
    ·
    <a href="https://github.com/onlook-dev/onlook/issues/new?labels=enhancement&template=feature-request---.md">機能リクエスト</a>
  </p>
  <!-- PROJECT SHIELDS -->
<!--
*** 読みやすさのため、マークダウンの「参照スタイル」リンクを使用しています。
*** 参照リンクは丸括弧 ( ) ではなく角括弧 [ ] で囲まれます。
*** このドキュメントの末尾に、contributors-url、forks-url などの参照変数の宣言があります。
*** これは省略可能な簡潔な構文です。
*** https://www.markdownguide.org/basic-syntax/#reference-style-links
-->
<!-- [![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![Apache License][license-shield]][license-url] -->

[![Discord][discord-shield]][discord-url]
[![LinkedIn][linkedin-shield]][linkedin-url]
[![Twitter][twitter-shield]][twitter-url]

[中文](https://www.readme-i18n.com/onlook-dev/onlook?lang=zh) | 
[Español](https://www.readme-i18n.com/onlook-dev/onlook?lang=es) | 
[Deutsch](https://www.readme-i18n.com/onlook-dev/onlook?lang=de) | 
[français](https://www.readme-i18n.com/onlook-dev/onlook?lang=fr) | 
[Português](https://www.readme-i18n.com/onlook-dev/onlook?lang=pt) | 
[Русский](https://www.readme-i18n.com/onlook-dev/onlook?lang=ru) | 
[日本語](https://www.readme-i18n.com/onlook-dev/onlook?lang=ja) | 
[한국어](https://www.readme-i18n.com/onlook-dev/onlook?lang=ko)

</div>

# デザイナーのためのカーソル – オープンソースのビジュアルファースト コードエディタ

AIを活用したNext.js + TailwindCSSでウェブサイト、プロトタイプ、デザインを作成。ブラウザDOMで直接編集できるビジュアルエディタ。リアルタイムでコードと共にデザイン。Bolt.new、Lovable、V0、Replit Agent、Figma Make、Webflowなどのオープンソース代替。

### 🚧 🚧 🚧 Onlook for Webは現在開発中です 🚧 🚧 🚧

Onlook for Webを素晴らしいプロンプトtoビルド体験にするため、積極的にコントリビューターを募集しています。
提案されている全機能（および既知の問題）のリストは[open issues](https://github.com/onlook-dev/onlook/issues)をご覧ください。さらに、[Discord](https://discord.gg/hERDfFZCsH)に参加して何百人もの開発者とコラボレーションしましょう。

## Onlookでできること:

- [x] 数秒でNext.jsアプリを作成
  - [x] テキストまたは画像から開始
  - [ ] プリビルトテンプレートを利用
  - [ ] Figmaからインポート
  - [ ] GitHubリポジトリから開始
- [x] アプリをビジュアルに編集
  - [x] Figma風UIを使用
  - [x] アプリをリアルタイムでプレビュー
  - [x] ブランドアセットやトークンを管理
  - [x] ページを作成・ナビゲート
  - [ ] レイヤーをブラウズ – _以前は[Onlook Desktop](https://github.com/onlook-dev/desktop)に搭載_
  - [ ] コンポーネントの検出と利用 – _以前は[Onlook Desktop](https://github.com/onlook-dev/desktop)に搭載_
  - [ ] プロジェクト画像の管理 – _以前は[Onlook Desktop](https://github.com/onlook-dev/desktop)に搭載_
- [x] 開発ツール
  - [x] リアルタイムコードエディタ
  - [x] チェックポイントから保存および復元
  - [x] CLIでコマンド実行
  - [x] アプリマーケットプレイスと連携
  - [ ] ローカルでコード編集 – _以前は[Onlook Desktop](https://github.com/onlook-dev/desktop)に搭載_
- [ ] アプリを数秒でデプロイ
  - [ ] 共有用リンクを生成
  - [ ] カスタムドメインを紐付け
- [ ] チームとコラボレーション
  - [ ] リアルタイム編集
  - [ ] コメントを残す

![Onlook-GitHub-Example](https://github.com/user-attachments/assets/642de37a-72cc-4056-8eb7-8eb42714cdc4)

### Onlook for Desktop（別名 Onlook Alpha）

Onlook Webは早期プレビュー段階です。ダウンロード可能なデスクトップエレクトロンアプリをお探しの場合は、[Onlook Desktop](https://github.com/onlook-dev/desktop)に移動しました。

なぜWebへの移行なのか？その決断については
[ElectronからWebへの移行](https://docs.onlook.com/docs/developer/electron-to-web-migration)をお読みください。

## はじめに

[ホステッドアプリ](https://onlook.com) または [ローカル実行](https://docs.onlook.com/docs/developer/running-locally) でまもなく利用可能です。

### 使い方

OnlookはどのNext.js + TailwindCSSプロジェクトでも動作します。あなたのプロジェクトをOnlookにインポートするか、エディタ内でゼロから開始できます。

AIチャットを使ってプロジェクトの作成や編集が可能です。いつでも要素を右クリックして、その要素のコード上の正確な位置を開くことができます。

<img width="600" alt="image" src="https://github.com/user-attachments/assets/4ad9f411-b172-4430-81ef-650f4f314666" />

<br>

新しいdivを描画し、親コンテナ内でドラッグ＆ドロップで再配置できます。

<img width="600" alt="image" src="https://raw.githubusercontent.com/onlook-dev/onlook/main/assets/insert-div.png">

<br>

サイトデザインとコードを並べてプレビュー。

<img width="600" alt="image" src="https://raw.githubusercontent.com/onlook-dev/onlook/main/assets/code-connect.png">

<br>

OnlookのエディタツールバーでTailwindスタイルを調整し、オブジェクトを直接操作、レイアウトの試行ができます。

<img width="600" alt="image" src="https://raw.githubusercontent.com/onlook-dev/onlook/main/assets/text-styling.png" />

## ドキュメント

完全なドキュメントは[docs.onlook.com](https://docs.onlook.com)へ

コントリビュート方法は、ドキュメント内の[Onlookへの貢献](https://docs.onlook.com/docs/developer/contributing)をご覧ください。

## 仕組み

<img width="676" alt="architecture" src="https://raw.githubusercontent.com/onlook-dev/onlook/main/assets/architecture.png">

1. アプリ作成時に、コードをWebコンテナにロード
2. コンテナがコードを実行・提供
3. エディタがプレビュリンクを受け取りiFrameに表示
4. エディタがコンテナからコードを読み取りインデックス作成
5. 要素とコード上の位置を対応付けるためにコードをインストルメント化
6. 要素が編集されると、iFrame内・コード内の要素を編集
7. AIチャットもコードアクセス・理解・編集ツールを持つ

このアーキテクチャは理論的には、DOM要素を宣言的に表示する任意の言語やフレームワーク（例: jsx/tsx/html）にスケールできます。現在はNext.jsとTailwindCSSでの動作に注力しています。

詳細なウォークスルーは[アーキテクチャドキュメント](https://docs.onlook.com/docs/developer/architecture)をご覧ください。

### 技術スタック

#### フロントエンド

- [Next.js](https://nextjs.org/) - フルスタック
- [TailwindCSS](https://tailwindcss.com/) - スタイリング
- [tRPC](https://trpc.io/) - サーバーインターフェース

#### データベース

- [Supabase](https://supabase.com/) - 認証、データベース、ストレージ
- [Drizzle](https://orm.drizzle.team/) - ORM

#### AI

- [AI SDK](https://ai-sdk.dev/) - LLMクライアント
- [Anthropic](https://ai-sdk.dev/) - LLMモデルプロバイダー
- [Morph Fast Apply](https://morphllm.com) - 高速適用モデルプロバイダー
- [Relace](https://relace.ai) - 高速適用モデルプロバイダー

#### サンドボックスとホスティング

- [CodeSandboxSDK](https://codesandbox.io/docs/sdk) - 開発用サンドボックス
- [Freestyle](https://www.freestyle.sh/) - ホスティング

#### 実行環境

- [Bun](https://bun.sh/) - モノレポ、ランタイム、バンドラー
- [Docker](https://www.docker.com/) - コンテナ管理

## 貢献方法
![image](https://github.com/user-attachments/assets/ecc94303-df23-46ae-87dc-66b040396e0b)

もし改善の提案がある場合は、リポジトリをフォークして
プルリクエストを作成してください。また、
[課題を作成](https://github.com/onlook-dev/onlook/issues)することもできます。

手順や行動規範については、[CONTRIBUTING.md](https://raw.githubusercontent.com/onlook-dev/onlook/main/CONTRIBUTING.md)をご覧ください。

#### コントリビューター

<a href="https://github.com/onlook-dev/onlook/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=onlook-dev/onlook" />
</a>

## お問い合わせ

![image](https://github.com/user-attachments/assets/60684b68-1925-4550-8efd-51a1509fc953)

- チーム: [Discord](https://discord.gg/hERDfFZCsH) -
  [Twitter](https://twitter.com/onlookdev) -
  [LinkedIn](https://www.linkedin.com/company/onlook-dev/) -
  [Email](mailto:contact@onlook.com)
- プロジェクト:
  [https://github.com/onlook-dev/onlook](https://github.com/onlook-dev/onlook)
- ウェブサイト: [https://onlook.com](https://onlook.com)

## ライセンス

Apache 2.0ライセンスの下で配布されています。詳細は
[LICENSE.md](https://raw.githubusercontent.com/onlook-dev/onlook/main/LICENSE.md)をご覧ください。

<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->

[contributors-shield]: https://img.shields.io/github/contributors/onlook-dev/studio.svg?style=for-the-badge
[contributors-url]: https://github.com/onlook-dev/onlook/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/onlook-dev/studio.svg?style=for-the-badge
[forks-url]: https://github.com/onlook-dev/onlook/network/members
[stars-shield]: https://img.shields.io/github/stars/onlook-dev/studio.svg?style=for-the-badge
[stars-url]: https://github.com/onlook-dev/onlook/stargazers
[issues-shield]: https://img.shields.io/github/issues/onlook-dev/studio.svg?style=for-the-badge
[issues-url]: https://github.com/onlook-dev/onlook/issues
[license-shield]: https://img.shields.io/github/license/onlook-dev/studio.svg?style=for-the-badge
[license-url]: https://github.com/onlook-dev/onlook/blob/master/LICENSE.txt
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?logo=linkedin&colorB=555
[linkedin-url]: https://www.linkedin.com/company/onlook-dev
[twitter-shield]: https://img.shields.io/badge/-Twitter-black?logo=x&colorB=555
[twitter-url]: https://x.com/onlookdev
[discord-shield]: https://img.shields.io/badge/-Discord-black?logo=discord&colorB=555
[discord-url]: https://discord.gg/hERDfFZCsH
[React.js]: https://img.shields.io/badge/react-%2320232a.svg?logo=react&logoColor=%2361DAFB
[React-url]: https://reactjs.org/
[TailwindCSS]: https://img.shields.io/badge/tailwindcss-%2338B2AC.svg?logo=tailwind-css&logoColor=white
[Tailwind-url]: https://tailwindcss.com/
[Electron.js]: https://img.shields.io/badge/Electron-191970?logo=Electron&logoColor=white
[Electron-url]: https://www.electronjs.org/
[Vite.js]: https://img.shields.io/badge/vite-%23646CFF.svg?logo=vite&logoColor=white
[Vite-url]: https://vitejs.dev/
[product-screenshot]: https://raw.githubusercontent.com/onlook-dev/onlook/main/assets/brand.png
[weave-shield]: https://img.shields.io/endpoint?url=https%3A%2F%2Fapp.workweave.ai%2Fapi%2Frepository%2Fbadge%2Forg_pWcXBHJo3Li2Te2Y4WkCPA33%2F820087727&cacheSeconds=3600&labelColor=#131313
[weave-url]: https://app.workweave.ai/reports/repository/org_pWcXBHJo3Li2Te2Y4WkCPA33/820087727

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---