<div align="center">
  <img
    alt="logo"
    width="100"
    src="https://p.chilfish.top/weibo/icon.webp"
  />

  <div>
    <a href="https://deepwiki.com/Chilfish/Weibo-archiver"><img src="https://deepwiki.com/badge.svg" alt="Ask DeepWiki"></a>
    <img src="https://wakatime.com/badge/user/0842a71f-c026-4b09-8aa0-f8398b4c3423/project/3416f224-f0dc-4b08-805c-af30dbd396b2.svg" alt="wakatime">
    <img alt="GitHub Repo stars" src="https://img.shields.io/github/stars/chilfish/weibo-archiver">
    <img alt="GitHub Downloads" src="https://img.shields.io/github/downloads/chilfish/weibo-archiver/total">
    <img alt="beta build" src="https://github.com/Chilfish/Weibo-archiver/actions/workflows/beta-build.yml/badge.svg">
  </div>
</div>

## Weibo-archiver

あなたの新浪微博の思い出をアーカイブし、アカウントが完全に消される前に備えましょう 😭 公式サイト：[weibo-archiver.chilfish.top](https://weibo-archiver.chilfish.top)

![封面](https://p.chilfish.top/weibo/cover.webp)

### 使用方法

詳細は [オンラインドキュメント] をご参照ください

> 旧バージョンは [v0.5 ブランチ](https://github.com/Chilfish/Weibo-archiver/tree/v0.5) または https://weibo.chilfish.top/ で確認可能です。[ドキュメント：旧バージョンからの移行](https://weibo-archiver.chilfish.top/docs/intro.html#从旧版本迁移) の説明もご覧ください

### 開発者向け

プロジェクトは monorepo 構成で、pnpm を使用して管理しているため、まず pnpm をインストールしてください：`npm i -g pnpm`

packages ディレクトリ内：

- [/core](packages/core/) はユーティリティ関数やデータ処理のコアを含みます

apps ディレクトリ内は最終的なアプリケーションです

- [/web](apps/web-v2/) は微博データを閲覧するためのウェブページで、現在 [vercel] 上でホスティングされています
- [/monkey](apps/monkey/) は油猴スクリプト（Tampermonkey スクリプト）としてパッケージ化するためのものです
- [/cli](apps/cli) Nodejs コマンドライン版

> Vercel に直接デプロイする前に、Vercel のプロジェクト設定で Root Directory を `apps/web-v2` に設定する必要があります。これによりプロジェクトが正しく認識されビルドされます。

server ディレクトリ内には Go 言語で書かれたローカルサーバーがあり、画像のダウンロードや微博データの閲覧に使用されます。具体的な使い方は [ローカルサーバー使用説明](https://raw.githubusercontent.com/Chilfish/Weibo-archiver/main/server/README.md) を参照してください。

### 謝辞

- [speechless] に基本的なアイデアを提供していただき感謝します
- [vite-plugin-monkey] が油猴スクリプトへのパッケージングツールを提供
- Shadcn/ui が美しい UI コンポーネントライブラリを提供
- [vercel] がオンラインクラウドプラットフォームを提供😚
- Github Copilot & v0.dev 😇

### スポンサー

このプロジェクトが役に立った場合、私にスポンサーを検討していただけると嬉しいです😇これによりこのプロジェクトのメンテナンスのモチベーションが上がります：[スポンサーリンク]

[releases]: https://raw.githubusercontent.com/Chilfish/Weibo-archiver/monkey/weibo-archiver.user.js
[scripts.zip]: https://github.com/Chilfish/Weibo-archiver/raw/monkey/scripts.zip
[speechless]: https://github.com/meterscao/Speechless
[naive-ui]: https://www.naiveui.com/zh-CN/os-theme
[#1]: https://github.com/Chilfish/Weibo-archiver/issues/1
[#5]: https://github.com/Chilfish/Weibo-archiver/issues/5
[Node.js 官网]: https://nodejs.org/en/download
[vite-plugin-monkey]: https://github.com/lisonge/vite-plugin-monkey
[镜像地址]: https://p.chilfish.top/weibo-archiver.user.js
[项目的 Todo]: https://github.com/Chilfish/Weibo-archiver/issues/7
[赞助地址]: https://chilfish.top/sponsors
[vercel]: https://vercel.com
[使用教程]: https://docs.qq.com/doc/DTWttbXlMUGxZZnZq
[actions]: https://github.com/Chilfish/Weibo-archiver/actions/workflows/beta-build.yml?query=branch:main+event:push+is:success
[微博网页版]: https://weibo.com
[在线文档]: https://weibo-archiver.chilfish.top/docs/


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-06

---