# 3ムスケティアーズ

<div align="center">
<img src="https://raw.githubusercontent.com/flemay/3musketeers/main/src/assets/logo/hero-v2.svg" width="300">

**どこからでも同じ方法でアプリをテスト、ビルド、デプロイ！**

[![ビルドステータス][linkGitHubActionsProjectBadge]][linkGitHubActionsProject]
[![ライセンス][linkLicenseBadge]][linkLicense]

</div>

<details>
  <summary>目次</summary>

<!-- START doctoc generated TOC please keep comment here to allow auto update -->
<!-- DON'T EDIT THIS SECTION, INSTEAD RE-RUN doctoc TO UPDATE -->

- [概要](#overview)
- [3ムスケティアーズのウェブサイト](#3-musketeers-website)
  - [前提条件](#prerequisites)
  - [開発](#development)
  - [デプロイ](#deployment)
    - [0. CloudflareアカウントIDとAPIトークン](#0-cloudflare-account-id-and-api-token)
    - [1. Envファイル](#1-envfile)
    - [2. 作成](#2-create)
    - [3. デプロイ](#3-deploy)
    - [4. 削除](#4-delete)
  - [CI/CD](#cicd)
  - [ビジュアル要素](#visual-elements)
- [貢献](#contributing)
- [ライセンス](#license)

<!-- END doctoc generated TOC please keep comment here to allow auto update -->

</details>

## 概要

<!-- Part of src/content/docs/about/what-is-3musketeers.md -->
3ムスケティアは、ソフトウェアを繰り返しかつ一貫して開発するためのパターンです。  
Makeをオーケストレーションツールとして活用し、DockerおよびDocker Composeを使用してアプリケーションのテスト、ビルド、実行、デプロイを行います。  
各アプリケーションのMakeおよびDocker/Composeコマンドはアプリケーションのソースコードの一部として管理されており、ローカルまたはCI/CDサーバーで実行する場合でも同じ方法で呼び出されます。  

> [!NOTE]  
> 詳細については、[公式ウェブサイト][link3Musketeers]をご覧ください。  

## 3ムスケティアのウェブサイト  

このリポジトリは、[Astro Starlight][linkAstroStarlight]で構築された[3ムスケティアのウェブサイト][link3Musketeers]です。  
このセクションでは、3ムスケティアの手法を用いた開発、テスト、デプロイ方法について説明します。  

### 前提条件  

- [Docker](https://www.docker.com/)  
- [Compose](https://docs.docker.com/compose/)  
- [Make](https://www.gnu.org/software/make/)  
- [Cloudflare][linkCloudflarePages]アカウント  

### 開発  






```bash
# Create a .env file
make envfile ENVFILE=env.example
# Install dependencies
make deps copyDepsToHost

# Format and check
make fmt check

# Start Astro server for local development
make dev
# Wait till the message 'dev-1  | 20:13:41 watching for file changes...' appears
# Access the website in your browser at http://127.0.0.1:4321/
# \<ctrl-c\> to stop

# Build static site
make build

# Serve static site for local development
make previewDev
# Access the website in your browser at http://127.0.0.1:4321/
# \<ctrl-c\> to stop

# Serve static website in the background
make preview

# Test static website
make testPreview

# Clean
make clean
```
### デプロイメント

3ムスケティアーズのウェブサイトは[Cloudflare Pages][linkCloudflarePages]にデプロイされています。  
このセクションでは、[Wrangler CLI][linkCloudflareWranglerCLI]を使用してPagesプロジェクトを作成、デプロイ、削除する方法を示します。  
これは新しい変更をプレビューするのに便利です。

ビルド、テスト、デプロイはGitHub Actionsで行われるため、  
このセクションでは[Direct Upload][linkCloudflareDirectUpload]と  
[Run Wrangler in CI/CD][linkCloudflareWranglerCICD]の指示に従います。

> [!NOTE]
> このセクションでは静的サイトが
> `make build`で生成されている必要があります

#### 0. CloudflareアカウントIDとAPIトークン

Wrangler CLIを使用してCloudflare Pagesとやり取りするには、CloudflareアカウントIDと  
APIトークンが必要です。

1. アカウントID: [アカウントとゾーンIDの確認][linkCloudflareFindAccountAndZoneIDs]  
1. APIトークン  
   1. [APIトークンの作成][linkCloudflareCreateAPIToken]  
   1. `Edit Cloudflare Workers`テンプレートを使用  
   1. `Token name`を更新  
   1. 権限:  
      1. アカウント - Cloudflare Pages - 編集  
      1. 他の権限は削除  
   1. ご自身のアカウントを含める  
   1. 短期間のTTLを設定  
   1. `Continue to summary`をクリック  
1. これらの値は次のセクション`1. Envfile`で使用されます

#### 1. Envfile

以下のセクションでは`.env`ファイルの値を使用します。正しい値で`.env`ファイルを  
（`env.template`を基に）作成してください。

例：



```bash
# .env
ENV_CLOUDFLARE_BRANCH_NAME=main
ENV_CLOUDFLARE_PROJECT_NAME=random-project-name
ENV_SECRET_CLOUDFLARE_ACCOUNT_ID=id-from-previous-section
ENV_SECRET_CLOUDFLARE_API_TOKEN=token-from-previous-section
```
検証：


```bash
make shell
# Check the env vars are correctly set
env | grep ENV_
# List current projects on CloudFlare
deno task deploy:list
exit
```
#### 2. 作成

このセクションでは新しいPagesプロジェクトを作成します。このステップは
`ENV_CLOUDFLARE_PROJECT_NAME`がステップ`1. Envfile`に記載されていなかった場合のみ必要です。


```bash
make shell
# Create a new project
deno task deploy:create
# The new project and its domain should be listed
deno task deploy:list
# Project is empty which should not be hosted
curl -I https://${ENV_CLOUDFLARE_PROJECT_NAME}.pages.dev
#HTTP/2 522
#...
# Exit the container
exit
```

#### 3. デプロイ

このセクションでは、既存のCloudflare Pagesプロジェクトにウェブサイトをデプロイします。

```bash
make shell
# Deploy the files to the project
deno task deploy
# Project is no longer empty!
curl -I https://${ENV_CLOUDFLARE_PROJECT_NAME}.pages.dev
#HTTP/2 200
#...
# Exit the container
exit
```

注：`make deploy`も使用可能です。

#### 4. 削除

このセクションでは、Cloudflare Pagesプロジェクトの削除方法を示します。

```bash
make shell
deno task deploy:delete
#? Are you sure you want to delete "<ENV_CLOUDFLARE_PROJECT_NAME>"? This action cannot be undone. › y
# Check the project is no longer listed
deno task deploy:list
exit
```

> [!重要]
> セクション
> `0. CloudflareアカウントIDとAPIトークン`で作成したCloudFlareトークンは削除可能です

### CI/CD

[GitHub Actions][linkGitHubActions] はPRのテストおよび
`main` ブランチの変更をCloudflare Pagesにデプロイするために使用されています。

- GitHub Actions専用のCloudflare APIトークンが作成されています
- Cloudflare Pagesへのデプロイに必要な環境変数は
  GitHub Actionsの[variables][linkGitHubActionsVariables]および
  [secrets][linkGitHubActionsSecrets]に設定されています
- GitHub Actionsのワークフローは3 Musketeersパターンに従っています

### ビジュアル要素

- 3 Musketeersロゴ
  - 私が[Procreate][linkProcreate]とVectornatorで作成
    - 使用した便利なツールは`offset path`と`mask objects`
  - 2048px×2048pxのSVG画像
  - 画像は`./src/assets/logo/`フォルダにあります
- ファビコン
  - 元画像はロゴのpng形式の書き出し
  - [favicon.io][linkFaviconio]のウェブサイトを使用
  - 生成されたコンテンツは`./public/favicon_io`にあります
  - HTMLの`<link>`タグを`<head>`にコピーする手順は
    `./astro.config.mjs`に設定されています
- ソーシャルメディアプレビュー
  - Twitter、Facebook、GitHubなどでウェブサイトのプレビューを表示するためのもの
  - 新しく1280x640pxのベクター画像を作成し、中央に縮小したロゴを配置
    - サイズはGitHubのGeneral設定で推奨されているもの
  - [artegence記事][linkArtegenceArticle]によると、異なるソーシャルプラットフォームで機能する理想的な画像は
    - 1200x630pxである
    - ロゴ（630x630）が中央に配置されている
    - png形式を使用（非常に高品質で透過あり）
    - jpg形式を使用（高品質で非常に良いサイズ圧縮）


  - ソーシャルイメージはリポジトリの一般設定でも設定されています
  - Astro Starlight は `<head>` セクション内のすべての `<meta>` タグを設定します
- 図表
  - [Mermaid][linkMermaid] は図表の生成に使用されています
  - すべての図表はディレクトリ [diagrams](diagrams) にあります
- [demo][linkDemo] は [charmbracelet/vhs][linkVHS] によって生成されました

## 貢献

[CONTRIBUTING.md](https://raw.githubusercontent.com/flemay/3musketeers/main/CONTRIBUTING.md)

感謝は [contributors][linkContributors] に送ります。

## ライセンス

[MIT][linkLicense]

[link3Musketeers]: https://3musketeers.pages.dev
[linkArtegenceArticle]: https://artegence.com/blog/social-media-tags-guide-part-2-preparing-a-perfect-image-for-the-ogimage-tag/
[linkAstroStarlight]: https://starlight.astro.build/
[linkCloudflareCreateAPIToken]: https://dash.cloudflare.com/profile/api-tokens
[linkCloudflareDirectUpload]: https://developers.cloudflare.com/pages/get-started/direct-upload/
[linkCloudflareFindAccountAndZoneIDs]: https://developers.cloudflare.com/fundamentals/setup/find-account-and-zone-ids/
[linkCloudflarePages]: https://pages.cloudflare.com/
[linkCloudflareWranglerCICD]: https://developers.cloudflare.com/workers/wrangler/ci-cd/
[linkCloudflareWranglerCLI]: https://developers.cloudflare.com/workers/wrangler/
[linkCompose]: https://docs.docker.com/compose
[linkContributors]: CONTRIBUTORS
[linkDemo]: demo
[linkDocker]: https://www.docker.com
[linkFaviconio]: https://favicon.io
[linkGitHubActions]: https://github.com/features/actions
[linkGitHubActionsProject]: https://github.com/flemay/3musketeers/actions
[linkGitHubActionsProjectBadge]: https://img.shields.io/github/actions/workflow/status/flemay/3musketeers/deploy.yml?style=for-the-badge&logo=github
[linkGitHubActionsSecrets]: https://docs.github.com/en/actions/security-guides/encrypted-secrets
[linkGitHubActionsVariables]: https://docs.github.com/en/actions/learn-github-actions/variables
[linkLicense]: LICENSE
[linkLicenseBadge]: https://img.shields.io/badge/License-MIT-green.svg?style=for-the-badge
[linkMake]: https://www.gnu.org/software/make
[linkMermaid]: https://mermaid.js.org/
[linkPatternOverview]: ./docs/guide/assets/diagrams-overview.svg
[linkProcreate]: https://procreate.art/
[linkVHS]: https://github.com/charmbracelet/vhs


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-20

---