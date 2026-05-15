<div align="center">

<a href="https://github.com/oljc/arco-admin">
  <img width="180" src="https://github.com/user-attachments/assets/09c91ec6-1de8-400e-878c-e1066667ff08" alt="Arco admin logo">
</a>

<h1 align="center">Arco Admin</h1>
<p align="center">すぐに使える機能豊富な中・バックエンド管理システムフレームワーク、最新技術スタックの標準化プロジェクト。</p> 

簡体字中国語 | [English](https://raw.githubusercontent.com/oljc/arco-admin/main/./README.en-US.md)

[![Netlify Status](https://api.netlify.com/api/v1/badges/4177124c-546f-4726-a842-00b72bf864fa/deploy-status)](https://arco-admin.netlify.app)
<a href="https://nodejs.org/en/about/previous-releases" target="_blank"><img alt="node compatibility" src="https://img.shields.io/node/v/vite.svg"></a>
<img alt="License" src="https://img.shields.io/github/license/oljc/arco-admin">
<img alt="Commit" src="https://img.shields.io/github/last-commit/oljc/arco-admin.svg">
<img alt="Version" src="https://img.shields.io/github/package-json/v/oljc/arco-admin/main">

[![Vercel](https://vercel.com/button)](https://vercel.com/new/clone?repository-url=https%3A%2F%2Fgithub.com%2Foljc%2Farco-admin&project-name=arco-admin&build-command=pnpm%20run%20build&install-command=pnpm%20i&output-directory=dist)
[![Netlify](https://www.netlify.com/img/deploy/button.svg)](https://app.netlify.com/start/deploy?repository=https://github.com/oljc/arco-admin)
[![EdgeOne Pages](https://cdnstatic.tencentcs.com/edgeone/pages/deploy.svg)](https://edgeone.ai/pages/new?repository-url=https%3A%2F%2Fgithub.com%2Foljc%2Farco-admin&repository-name=arco-admin&project-name=arco-admin&install-command=pnpm%20i&build-command=pnpm%20run%20build&output-directory=dist)

<img width="600" src="https://github.com/user-attachments/assets/49f985f1-bd8b-4ff6-9d38-25becb7a579e" alt="edgeone" />

本プロジェクトのCDN高速化およびセキュリティ保護は[Tencent EdgeOne](https://edgeone.ai/zh?from=github)の支援を受けています

</div>

## 特徴
+ ⚡️ 最新の Vue と Vite バージョンを追従。
+ 👍🏻 [Vue](https://cn.vuejs.org) + 公式推奨の [Vue Router](https://router.vuejs.org/zh) + [Pinia](https://pinia.vuejs.org/zh) マネージャー。
+ 🔩 バイトダンス提供の企業向けデザインエコシステム [ArcoDesign](https://arco.design/) コンポーネントライブラリ。
+ 🎨 [Less](https://less.bootcss.com/) CSS プリプロセッサ。
+ 📚 [i18n](https://github.com/intlify/vue-i18n-next/tree/master/packages/vue-i18n#readme) + [i18n-ally](https://github.com/lokalise/i18n-ally) を用いたより簡単で標準化された自動国際化ソリューション。
+ ⌨️ 多様な業務シーンページ、二次ラップコンポーネント、フレームワークサポート設定で簡単にパーソナライズ可能。
+ 🧚🏻 プロジェクトは完全に `ESM` 標準のモジュール文法を採用し、現代フロントエンド開発の大統一トレンドに対応。
+ 📦 各種`依存`、`Vite`のアップデート、廃止、統合機能などに合わせて設定を継続的に最適化し、最良のパッケージング効果を実現。


---

<img src="https://github.com/user-attachments/assets/da090081-a568-4882-837e-38fd1dbe0a7f">

## バージョン
- 国際化バージョン：[i18n ブランチ](https://github.com/oljc/arco-admin/tree/i18n)

## 規範
コード品質の向上、エラーの削減、そしてプロジェクト全体のコードスタイルの一貫性を確保することで、コード品質とスタイルの管理をより簡単にします。

+ **コード規範：**  [ESLint](https://eslint.org/) + [Stylelint](https://stylelint.io) + [Prettier](https://prettier.io)<br/>
    *事前に定義された規範により、コードの構文、スタイル、フォーマットの静的チェックと規範を通じてコードの品質と可読性を保証します*

+ **コミット規範：**  [Husky](https://typicode.github.io/husky/#/) + [Lint-Staged](https://github.com/okonet/lint-staged) + [Commitlint](https://commitlint.js.org)<br/>
  *コードコミット時に事前設定されたコードスタイルのチェック、フォーマット、およびメッセージ検証を通じて、各コミットのコード品質とスタイルの一貫性を保持します*

## ブラウザサポート

| <img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/edge/edge_48x48.png" alt="Edge" width="24px" height="24px" /><br/>Edge | <img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/firefox/firefox_48x48.png" alt="Firefox" width="24px" height="24px" /><br/>Firefox | <img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/chrome/chrome_48x48.png" alt="Chrome" width="24px" height="24px" /><br/>Chrome | <img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/safari/safari_48x48.png" alt="Safari" width="24px" height="24px" /><br/>Safari | <img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/samsung-internet/samsung-internet_48x48.png" alt="Samsung" width="24px" height="24px" /><br/>Samsung | <img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/opera/opera_48x48.png" alt="Opera" width="24px" height="24px" /><br/>Opera | <img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/electron/electron_48x48.png" alt="Electron" width="24px" height="24px" /><br/>Electron |
| --------- | --------- | --------- | --------- | --------- | --------- | --------- |
| Edge >=16| >= 31 | >= 49| >= 31| last 2 versions| >= 36 | last 2 versions

## 使用
1. このリポジトリをクローンする
```bash
git clone https://github.com/oljc/arco-admin
```
2. 依存関係のインストール
```bash
pnpm i
```
3. 运行
```bash
pnpm run dev
```

#### VsCode 拡張機能のおすすめ

| [<img src="https://vue.gallerycdn.vsassets.io/extensions/vue/volar/2.2.4/1740301455362/Microsoft.VisualStudio.Services.Icons.Default" width="24px" height="24px" /><br>Official](https://marketplace.visualstudio.com/items?itemName=Vue.volar) | [<img src="https://dbaeumer.gallerycdn.vsassets.io/extensions/dbaeumer/vscode-eslint/2.4.2/1687441427519/Microsoft.VisualStudio.Services.Icons.Default" width="24px" height="24px" /><br>ESLint](https://marketplace.visualstudio.com/items?itemName=dbaeumer.vscode-eslint) |[<img src="https://esbenp.gallerycdn.vsassets.io/extensions/esbenp/prettier-vscode/10.1.0/1690819498575/Microsoft.VisualStudio.Services.Icons.Default" width="24px" height="24px" /><br>Prettier](https://marketplace.visualstudio.com/items?itemName=esbenp.prettier-vscode) |[<img src="https://lokalise.gallerycdn.vsassets.io/extensions/lokalise/i18n-ally/2.12.0/1695476646920/Microsoft.VisualStudio.Services.Icons.Default" width="24px" height="24px" /><br>i18n Ally](https://marketplace.visualstudio.com/items?itemName=Lokalise.i18n-ally) |[<img src="https://stylelint.gallerycdn.vsassets.io/extensions/stylelint/vscode-stylelint/1.3.0/1698920117910/Microsoft.VisualStudio.Services.Icons.Default" width="25px" height="25px" /><br>Stylelint](https://marketplace.visualstudio.com/items?itemName=stylelint.vscode-stylelint)|[<img src="https://editorconfig.gallerycdn.vsassets.io/extensions/editorconfig/editorconfig/0.16.4/1607315835386/Microsoft.VisualStudio.Services.Icons.Default" width="25px" height="25px" /><br>EditorConfig](https://marketplace.visualstudio.com/items?itemName=EditorConfig.EditorConfig)|[<img src="https://antfu.gallerycdn.vsassets.io/extensions/antfu/vite/0.2.5/1622972526798/Microsoft.VisualStudio.Services.Icons.Default" width="25px" height="25px" /><br>Vite](https://marketplace.visualstudio.com/items?itemName=antfu.vite)|
| --- | --- | --- | ---| --- | --- | --- |

## 実績
Vite公式の[awesome-vite](https://github.com/vitejs/awesome-vite#vue-3)コミュニティ厳選プロジェクトリストに収録されています 🎉 

## 貢献
あらゆる形の貢献を歓迎します。すべての参加を真剣に受け止めます。<br/><br/>
<a href="https://github.com/oljc/arco-admin/graphs/contributors"><img src="https://contrib.rocks/image?repo=oljc/arco-admin" />
</a><br/>

# ライセンス
本プロジェクトは[MITライセンス](./LICENSE)に従っています。

[![トレンドチャート](https://starchart.cc/oljc/arco-admin.svg)](https://starchart.cc/oljc/arco-admin)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-15

---