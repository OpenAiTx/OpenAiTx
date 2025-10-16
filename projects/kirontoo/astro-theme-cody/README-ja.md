<a name="readme-top"></a>
<div align="center">
  
[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![MIT License][license-shield]][license-url]
[![Netlify Status](https://api.netlify.com/api/v1/badges/3d9506ce-9212-47ae-b686-fb932a24f940/deploy-status)](https://app.netlify.com/sites/astro-theme-cody/deploys)  

<a href='https://ko-fi.com/F1F2J3RV9' target='_blank'><img height='36' style='border:0px;height:36px;' src='https://storage.ko-fi.com/cdn/kofi2.png?v=6' border='0' alt='Buy Me a Coffee at ko-fi.com' /></a>


  <p align="center">
    <h1>Astro テーマ Cody</h1>
  <p>
    Astroで構築されたミニマリストのブログテーマです。自分のブログを始めたい方にとって、迅速かつ簡単なスタータービルドです。
  </p>
    <a href="https://astro-theme-cody.netlify.app">デモを見る</a>
    ·
    <a href="https://github.com/kirontoo/astro-theme-cody/issues">バグを報告する</a>
    ·
    <a href="https://github.com/kirontoo/astro-theme-cody/issues">機能をリクエストする</a>
  </p>
  </p>
</div>

![demo-preview](https://github.com/kirontoo/astro-theme-cody/assets/28286622/d585dcb2-6d5f-4a68-871c-b6028cfcc27f)


## 目次
- [動機](#motivation)
- [主な特徴](#key-features)
- [デモ](#demo)
- [クイックスタート](#quick-start)
- [コマンド](#commands)
- [ウェブサイトの設定](#configuring-your-website)
  - [サイト設定、ソーシャルメディアリンク、ナビゲーションバーリンク](#site-config-social-media-links-and-navbar-links)
  - [投稿とプロジェクトの追加](#adding-posts-and-projects)
  - [多言語対応](#multi-language-support)
- [デプロイ](#deploy)
- [追加機能](#extra-funtionality)
- [クレジット](#credit)

## モチベーション
既に多くのブログテーマが存在しますが、ターミナル/開発者向けの雰囲気を持ち、
他のテーマにはないいくつかの機能を備えたものが欲しかったからです。

## 主な特徴:
- Astro v4 高速 🚀
- TailwindCSS ユーティリティクラス
- アクセシブルでセマンティックなHTMLマークアップ
- レスポンシブ & SEOフレンドリー
- 多言語対応
- TailwindとCSS変数を使ったダーク/ライトモード
- ピン留めされた投稿とプロジェクト
- 最適化された画像のための [Astro Assets 統合](https://docs.astro.build/en/guides/assets/)
- MD & [MDX](https://docs.astro.build/en/guides/markdown-content/#mdx-only-features) 投稿
- ページネーション
- [PageFind](https://pagefind.app/) を使った投稿検索
- [自動RSSフィード](https://docs.astro.build/en/guides/rss)
- 自動生成される [サイトマップ](https://docs.astro.build/en/guides/integrations-guide/sitemap/)
- [Astro Icon](https://github.com/natemoo-re/astro-icon) SVGアイコンコンポーネント
- トップへ戻るボタン

## デモ
デモはこちらからご覧ください [here](https://astro-theme-cody.netlify.app)。

## クイックスタート
このテンプレートから[新しいリポジトリを作成](https://github.com/new?template_name=astro-theme-cody&template_owner=kirontoo)してください。

```
# npm 7+
npm create astro@latest -- --template kirontoo/astro-theme-cody

# pnpm
pnpm dlx create-astro --template kirontoo/astro-theme-cody
```
<p align="right">(<a href="#readme-top">トップに戻る</a>)</p>


## コマンド

すべてのコマンドはプロジェクトのルートディレクトリから、ターミナルで実行します：

| コマンド                   | 操作                                             |
| :------------------------ | :------------------------------------------------ |
| `pnpm install`             | 依存関係をインストールします                        |
| `pnpm run dev`             | `localhost:4321`でローカル開発サーバーを起動します  |
| `pnpm run build`           | 本番用サイトを`./dist/`にビルドします               |
| `pnpm run preview`         | デプロイ前にビルドをローカルでプレビューします       |
| `pnpm run astro ...`       | `astro add`や`astro check`などのCLIコマンドを実行します |
| `pnpm run astro -- --help` | Astro CLIの使い方ヘルプを表示します                 |

<p align="right">(<a href="#readme-top">トップに戻る</a>)</p>

## ウェブサイトの設定

### サイト設定、ソーシャルメディアリンク、ナビバーリンク
サイト設定、ソーシャルメディアリンク、およびナビバーリンクはすべて[`src/consts.ts`](https://github.com/kirontoo/astro-theme-cody/blob/main/src/consts.ts)に配置されています。  
ここでサイトのデフォルトタイトル、説明、言語、プロフィール、ソーシャルメディアリンク、表示するナビゲーションバーリンクを設定できます。

### 投稿とプロジェクトの追加
このテーマは[コンテンツコレクション](https://docs.astro.build/en/guides/content-collections/)を利用して、MarkdownやMDXファイルを整理し、  
スキーマによるフロントマターの型チェックを行います -> `src/content/config.ts`。

ブログ投稿の例は`src/content/blog`に、プロジェクトの例は`src/content/project`にあります。

#### ブログ投稿のフロントマター
| プロパティ (* = 必須) | 説明                                       |
|:---------------------| :----------------------------------------- |
| title *              | 投稿のタイトル。最大150文字まで                 |
| description *        | 投稿の短い説明。SEOにも使用されます。最大250文字まで。 |
| pubDate *            | 公開日                                       |
| updateDate           | 投稿が更新された日付（任意）。利用可能な場合はこの日付が公開日より優先され、投稿の並び順に使われます。|
| heroImage            | 投稿のカバー画像（任意）。`src`と`alt`プロパティの両方を含めてください。例は`src/content/blog/first-post.md`を参照してください。|


| ogImage | SEOに使用されるオプションの画像。 |
| tags | オプションのタグを使用して投稿をカテゴリやトピックに整理します。すべてのタグは `yourdomain.com/tags` に表示されます。 |
| series | オプションのシリーズを使用して投稿をシリーズとして整理します。すべてのシリーズは `yourdomain.com/series` に表示されます。 |
| draft | オプションのブール値。投稿の公開を取り下げます。|
| order | 1〜5のオプションの数値で、特定の投稿を上部にピン留めします。ピン留めできる投稿は最大5件までです。|
| hide  | オプションのブール値。`/blog` ページで投稿を非表示にします。`/archive` では表示されます。|

#### プロジェクトのfrontmatter

| プロパティ (* = 必須) | 説明 |
|:-----------------------| :----------|
| title * | プロジェクトのタイトル。最大150文字まで |
| description * | プロジェクトの短い説明。SEOにも使用されます。|
| pubDate * | 公開日 |
| heroImage | プロジェクトのオプションのカバー画像。`src` と `alt` プロパティの両方を含めてください。例は `src/pages/projects/project-1.md` を参照。|
| ogImage | SEOに使用されるオプションの画像。 |
| stack * | プロジェクトで使用した技術のリストで、アイコンとして表示されます。このテーマはSVG Logosライブラリを使用しており、必要なアイコンは [icones.js.org](https://icones.js.org/collection/vscode-icons) で見つけられます。|
| platform | ウェブサイトまたはデモへのリンク |
| website | ウェブサイトまたはデモへのリンク |
| github | GitHubリポジトリのリンク |
| draft | オプションのブール値。プロジェクトの公開を取り下げます。|
| order | 1〜5のオプションの数値で、特定のプロジェクトを上部にピン留めします。ピン留めできるプロジェクトは最大5件までです。|

<p align="right">(<a href="#readme-top">トップに戻る</a>)</p>

### 多言語サポート
ブログの多言語サポートの設定方法は [wiki](https://github.com/kirontoo/astro-theme-cody/wiki/Set-up-multi%E2%80%90language-support) を参照してください。

## デプロイ
Astroは様々なプラットフォームでAstroサイトをデプロイするための優れたドキュメントを提供しています。
こちらでご覧いただけます [here](https://docs.astro.build/en/guides/deploy/)。

## 追加機能
RSSフィードなどの他の機能を追加するには [Astro Recipes](https://docs.astro.build/en/recipes/) をチェックしてください。


## クレジット

このテーマはテーマ [Astro Cactus](https://astro-theme-cactus.netlify.app) と [Hugo Risotto](https://risotto.joeroe.io) をベースにしています。

<p align="right">(<a href="#readme-top">トップに戻る</a>)</p>

[contributors-shield]: https://img.shields.io/github/contributors/kirontoo/astro-theme-cody.svg?style=for-the-badge
[contributors-url]: https://github.com/kirontoo/astro-theme-cody/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/kirontoo/astro-theme-cody.svg?style=for-the-badge
[forks-url]: https://github.com/kirontoo/astro-theme-cody/network/members
[stars-shield]: https://img.shields.io/github/stars/kirontoo/astro-theme-cody.svg?style=for-the-badge
[stars-url]: https://github.com/kirontoo/astro-theme-cody/stargazers
[issues-shield]: https://img.shields.io/github/issues/kirontoo/astro-theme-cody.svg?style=for-the-badge
[issues-url]: https://github.com/kirontoo/astro-theme-cody/issues
[license-shield]: https://img.shields.io/github/license/kirontoo/astro-theme-cody.svg?style=for-the-badge
[license-url]: https://github.com/kirontoo/astro-theme-cody/blob/master/LICENSE.txt


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-16

---