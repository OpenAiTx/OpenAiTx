# sharrr

**ワンタイムのエンドツーエンド暗号化ファイル転送。**

ほぼ無制限のサイズのファイルを非同期に、かつ最も安全な方法で転送します。

[技術的な実装](https://sharrr.com/about)について詳しく知ることができます。[sharrrの比較](https://github.com/stophecom/sharrr-svelte/blob/main/src/routes/about/comparison.md)もご覧ください。

ウェブサイト: [www.sharrr.com](https://sharrr.com)

このプロジェクトの継続を支援してください: [寄付をする](https://donate.stripe.com/28oeV1gKP3bv4b6144)

## 開発

開始する前に、プロジェクトのルートに `.env` ファイルを追加してください。以下を参照してください。

```bash
# Initial installation
pnpm i

# Run dev server
pnpm run dev

# or start the server and open the app in a new browser tab
pnpm run dev -- --open
```

### DB

#### Prisma ORM

```bash
# Init primsa
npx prisma init

# Push schema to Postgres
npx prisma db push

# Open prisma studio locally
npx prisma studio

# After changes in DB are made. Should not be necessary.
# https://www.prisma.io/docs/concepts/components/prisma-client#4-evolving-your-application
npx prisma generate
```

#### Postgres データベース

現在は Vercel Postgres データベースを使用していますが、Prisma 対応の任意のデータベースで実行可能です。

### テスト

```bash
# Run unit tests with vitest
# Important: Node 19+ is required (Support for crypto modules)
pnpm run test:unit


# E2E tests with playwright
pnpm run test

```

### ビルド

アプリの本番バージョンを作成するには：

```bash
pnpm run build
```

`pnpm run preview` コマンドでプロダクションビルドをプレビューできます。

### メンテナンス

毎日実行される Github ワークフロー `cron-cleanup-files.yml` が古いファイルをクリーンアップします。
詳細は `src/routes/api/v1/cron/+server.ts` を参照してください。

ローカルで cron ジョブを手動で起動するには、以下を実行します：

```bash
curl --request POST \
     --url 'http://localhost:3000/api/v1/cron' \
     --header 'Authorization: Bearer API_SECRET_KEY'

```

## セルフホスティング

> **注意**
> 現在プロジェクトはVercel上で動作しており、ストレージにS3、データベースにVercel Postgresを使用しています。セルフホスティングではこれらのサードパーティのソリューションを置き換える必要があります。

### 現在のセットアップ

#### 環境変数

```bash
# Postgres
POSTGRES_PRISMA_URL='postgres://'
POSTGRES_URL_NON_POOLING='postgres://' # Direct Connection

# S3 compatible object storage e.g. AWS
S3_ENDPOINT='<string>'
S3_ACCESS_KEY='<string>'
S3_SECRET_KEY='<string>'
PUBLIC_S3_BUCKET='<string>'

# Vercel specific, but can be easily replaced.
VERCEL_URL='http://localhost:3000'
PUBLIC_ENV='development' # preview/production

# Only used for cron jobs that run using Github Actions.
API_SECRET_KEY='<string>'
```

### Dockerを使って（作業中）

`.env` ファイル内の環境変数を編集する必要があります。

> **注意**
> Dockerでアプリを実行するには、独自のDBに接続する必要があります。独自のS3ストレージソリューションを実行する場合も同様です。この部分はまだカバーされていません。

それが終わったら、次のことができます：

```bash
# to start the docker container
sudo docker compose up -d

# to stop the docker container
sudo docker compose down

# to check logs
sudo docker logs sharrr
```

## 概要

著者について: [stophe.com](https://stophe.com)

追加のプライバシーとセキュリティオプションが必要ですか？ [scrt.link](https://scrt.link) をご覧ください。

### スタック

- SvelteKit
- Tailwind CSS
- PostgreSQL（データベース）
- Prisma（ORM）
- Doppler（環境変数管理）

このプロジェクトは BrowserStack でテストされています。

### インフラ

- ウェブサイトと Postgres は [Vercel](https://vercel.com/) 上でホスト
- S3 オブジェクトストレージは [flow.swiss](https://flow.swiss) を使用

### ライセンス

[MIT](https://opensource.org/license/mit/)（コード）

[CC BY-NC-ND](https://creativecommons.org/licenses/by-nc-nd/4.0/)（クリエイティブ）


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-27

---