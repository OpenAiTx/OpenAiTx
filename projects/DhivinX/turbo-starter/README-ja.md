<p align="center">
  <a href="https://turborepo.com/" target="blank"><img src="https://user-images.githubusercontent.com/4060187/106504110-82f58d00-6494-11eb-87b7-a16d4f68bc5a.png" width="350" alt="Turborepo ロゴ" /></a>
<p>

<p align="center">
  <a href="https://vuejs.org/" target="blank"><img src="https://upload.wikimedia.org/wikipedia/commons/thumb/9/95/Vue.js_Logo_2.svg/2367px-Vue.js_Logo_2.svg.png" width="88" alt="Vue ロゴ" /></a>
  <a href="https://nuxt.com/" target="blank"><img src="https://upload.wikimedia.org/wikipedia/commons/thumb/a/ae/Nuxt_logo.svg/1200px-Nuxt_logo.svg.png" width="105" alt="Nuxt ロゴ" /></a>
  <a href="https://nestjs.com/" target="blank"><img src="https://nestjs.com/img/logo-small.svg" width="88" alt="Nest ロゴ" /></a>
</p>


# スターターキット：TurboRepoを使ったソフトウェア開発プロジェクト

このリポジトリは、革新的なソフトウェアアプリケーションの迅速な構築を可能にする、すぐに使えるツールキットとプロジェクトスケルトンを提供します。TurboRepo、NestJS、Vue 3 + Vite、TypeScript、Nuxt.jsといった先進的な技術とフレームワークを活用し、スムーズで効率的なソフトウェア開発を促進します。

## 目次
- [特徴と内容](#features-and-contents)
- [前提条件](#prerequisites)
- [はじめに](#getting-started)
- [Dockerでのはじめ方](#getting-started-with-docker)
- [環境変数](#environment-variables)
- [Volar と Visual Studio Code（テイクオーバーモード）](#volar-and-visual-studio-code-takeover-mode)
- [トップレベルスクリプト](#top-level-scripts)
- [Visual Studio Code 拡張機能](#visual-studio-code-extensions)
- [機能改善とバグ報告](#enhancements-and-bug-reports)
- [貢献](#contribution)
- [ライセンス](#license)

## 特徴と内容

- **TurboRepo**：このリポジトリは、複数の関連リポジトリを単一プロジェクトで管理しやすくするツールであるTurboRepoに対応しています。これにより、機能開発に集中しつつTurboRepoが構成管理を担当します。

- **NestJS**：アプリケーションのバックエンドは、スケーラブルでモジュール化されたAPI作成を可能にするNode.jsベースのフレームワーク、NestJSで構築されています。TypeScriptと完全に統合されており、高性能で可読性の高いコードを実現します。

- **Vue 3 + Vite**：ユーザーインターフェースは、人気のJavaScriptフレームワークの最新バージョンであるVue 3をベースにしています。さらに、高速かつモダンなUIビルドツールであるViteを使用しています。

- **TypeScript**：プロジェクト全体はTypeScriptで記述されており、コードの安全性を高め、リファクタリングや保守を容易にします。

- **Nuxt.js**：また、このリポジトリにはVue.jsのSSR（サーバーサイドレンダリング）アプリケーションを作成するためのフレームワーク、Nuxt.jsのサンプル設定も含まれています。これによりSEO性能と高速なコンテンツロードを保証します。

- **Electron**: このプロジェクトはElectronを使用してデスクトップアプリケーションとしてもパッケージ化でき、クロスプラットフォームのアプリケーションを作成できます。

- **Capacitor**: Capacitorが統合されており、ウェブ技術を使ってネイティブモバイルアプリを構築可能です。

- **Docker**: Dockerを利用してアプリケーションのコンテナ化およびデプロイ管理を行います。

- **Shared Package**: リポジトリにはコードの再利用性と保守性を高めるための共有パッケージが組み込まれています。

- **VitestおよびJestによるテスト設定**: リポジトリにはVitestとJestを使ったテストの事前設定が含まれています。VueコンポーネントやTypeScriptコードのユニットテストを簡単に作成・実行可能です。提供されたテスト設定を利用し、Vitestの高速テスト機能とJestの堅牢なテストフレームワークの力を活用してください。

## 前提条件

開発環境にグローバルインストールを推奨します:

- [pnpm](https://pnpm.io/pnpm-cli)
- [nest-cli](https://docs.nestjs.com/cli/overview)

## はじめに

```bash

# 1. Clone the repository
git clone https://github.com/DhivinX/turbo-starter.git

# 2. Enter your newly-cloned folder
cd turbo-starter

# 3. Install the project and build packages in libs folder
pnpm install

# 4. Dev: Run web with hot reload 
pnpm dev-web # or make dev-web

# 5. Dev: Run API project with hot reload 
# Note that you need to create the .env file in the project root directory beforehand

# You should copy the .env.example file and rename it to .env
cp .env.example .env

# Then you can configure database access and other server settings
pnpm dev-api # or make dev-api

# 6. Or run API and WEB projects with hot reload parallel
pnpm dev # or make dev

```

## Dockerの始め方

```bash

# 1. Clone the repository
git clone https://github.com/DhivinX/turbo-starter.git

# 2. Enter your newly-cloned folder
cd turbo-starter

# 3. Install the project and build packages in libs folder
pnpm install

# 4. Copy env.example to .env.local and pass wished variables:
# Change DATABASE_HOST to "postgres"
cp .env.example .env.local

# 5. Build image:
make docker-build-local

# 6. Run API and WEB projects development process with hot reload in docker container 
make docker-run-local

```

## 環境変数

### .env.example

```bash
# Frontend: API server connection configuration
VITE_WEB_DEFAULT_LOCALE="en"
VITE_WEB_API_URL="http://localhost"
VITE_WEB_API_PORT=3000

# Backend public url
API_PUBLIC_URL=http://localhost:3000

# HTTP / HTTPS server config
API_HTTP_PORT=3000

# Cross-Origin Resource Sharing domain origins
# More info: https://developer.mozilla.org/en-US/docs/Web/HTTP/CORS
API_HTTP_CORS=["http://localhost", "http://localhost:8080", "http://localhost:8081", "http://localhost:8082", "app://localhost", "capacitor://localhost"]

# Keys required for hashing passwords and tokens
# They should be filled with random, unique strings
API_SECRETS_PWDSALT="123456"
API_SECRETS_JWT="123456"

# Database type: postgres, mysql, sqlite etc.
# More info: https://typeorm.io
DATABASE_TYPE="postgres"

# Database connection config
DATABASE_HOST="localhost"
DATABASE_PORT=5432

# Database name and user credentials
DATABASE_NAME="turbonv"
DATABASE_USER="postgres"
DATABASE_PASSWORD="root"

# Disable this in the production version of the application
# More info: https://typeorm.io/faq#how-do-i-update-a-database-schema
DATABASE_ENABLE_SYNC=true
```
## Volar と Visual Studio Code（テイクオーバーモード）

`Volar` は現在 `Vue - Official` 拡張機能となったため、バージョン 2.0 ではテイクオーバーモードは不要です。以前にこの拡張機能を無効にしていた場合は、組み込みの `TypeScript and JavaScript Language Features` 拡張機能を有効にしてください。

## トップレベルスクリプト

#### 開発

* `dev` - すべてのアプリケーションをホットリロードで同時に実行
* `dev-api` - API プロジェクトをホットリロードで実行
* `dev-web` - WEB プロジェクトをホットリロードで実行
* `dev-web-electron` - WEB プロジェクトを Electron アプリケーションでホットリロード実行
* `dev-nuxt` - Nuxt アプリケーションをホットリロードで実行
* `dev-mobile` - モバイルアプリケーションをホットリロードで実行

#### ビルド

* `build` - すべてのパッケージとアプリケーションをビルド
* `build-api` - API プロジェクトアプリケーションをビルド
* `build-web` - WEB プロジェクトアプリケーションをビルド
* `build-web-electron` - WEB プロジェクトを含む Electron アプリケーションをビルド
* `build-nuxt` - Nuxt アプリケーションをビルド
* `build-mobile` - モバイルアプリケーションをビルド

#### 実行

* `start` - すべてのアプリケーションを起動
* `start-api` - API プロジェクトアプリケーションを起動
* `start-web` - dist フォルダのファイルを提供するローカルの静的ウェブサーバーを起動
* `start-nuxt` - Nuxt アプリケーションを起動

#### モバイル

* `mobile-android` - モバイルアプリケーションをビルドし Android Studio で開く
* `mobile-ios` - モバイルアプリケーションをビルドし Xcode で開く

#### 共通

* `test` - すべてのパッケージとアプリケーションのテストを実行

* `lint` - すべてのパッケージとアプリケーションのリントを実行します
* `clean` - すべてのパッケージとアプリケーションからdistディレクトリを削除します

## Visual Studio Code 拡張機能

```json

{
  "recommendations": [
    "vue.volar",
    "dbaeumer.vscode-eslint",
    "editorconfig.editorconfig",
    "visualstudioexptteam.vscodeintellicode",
    "mikestead.dotenv",
    "firsttris.vscode-jest-runner"
  ]
}

```

### 必須

* `vue.volar` - Vue言語機能（Volar）
* `syler.sass-indented` - Sass構文のハイライト。
* `dbaeumer.vscode-eslint` - VS Code ESLint拡張機能。
* `editorconfig.editorconfig` - VS Code用のEditorConfig。

### 任意

* `mikestead.dotenv` - DotENV - dotenvファイル構文のサポート
* `visualstudioexptteam.vscodeintellicode` - IntelliCode

## 改善点およびバグ報告

バグを見つけた場合や改善案がある場合は、GitHubの[issues](https://github.com/DhivinX/turbo-starter/issues)に投稿してください。

## 貢献

このスターターの改良案がある場合や新機能を追加したい場合は、プルリクエストを自由に送ってください。あなたの貢献が他の開発者のプロジェクト開始をより迅速にします！

## ライセンス

このスターターキットはMITライセンスのもとで提供されています。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-04

---