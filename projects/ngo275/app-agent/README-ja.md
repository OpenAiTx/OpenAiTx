# AppAgent

<div align="center">
  <img width="200" src="https://github.com/user-attachments/assets/7f86c185-0fc1-46c3-888a-c915602f27ee" alt="AppAgent" />
  <h2>ASOからリリースまで、すべてを効率化。</h2>
</div>

[AppAgent](https://app-agent.ai) は、アプリのASOとリリースプロセスを管理するAIファーストのツールです。AppAgentは、App Radar、AppTweak、AppFollow、Sensor TowerなどのASOツールのオープンソース代替です。AppAgentはAIを中心に設計され、自律的に動作します。

https://github.com/user-attachments/assets/e34baeef-ceab-4fdb-9a7c-e6a5ab80dbba

---

## なぜAppAgentなのか？

急速なAIの進歩により、アプリ作成はかつてないほど簡単になりました。しかし、人気のASOツール（App Radar、AppTweak、Sensor Towerなど）は、インディーデベロッパーや小規模チームにとっては依然として高価で複雑すぎます。本当に必要なのは、多言語のキーワード選定からASOコンテンツ生成まで自律的に処理し、キーワードだけでなくリリース全体のプロセスを効率化するプラットフォームです。

App Store Connectもリリースワークフローに摩擦を生んでいます。だからこそ、私はAIファーストのアプローチを取り、ASOとアプリリリースを一つのシームレスで効率的なプラットフォームに再構築し、AppAgentを開発しました。

---

## 特徴

### 自律型ASO（ベータ）

https://github.com/user-attachments/assets/09172b8c-c690-42b2-a394-8b65e80c25ad

- **自律的なキーワードリサーチ**
  - 手動でのキーワード探しは不要。
  - ロケールや市場に関係なく自律的に実行。
  - 競合を見つけて、自動でキュレーションされた競合リストを管理。
  - 競合を基にAIがキーワードを調査しリストを確定。
- **AI駆動のストア最適化**
  - アプリのメタデータに基づく即時提案。
  - 全言語対応のASOフレンドリーなコンテンツ生成。
  - 専門的なマーケティング知識は不要、クリックするだけ。

### リリース管理

https://github.com/user-attachments/assets/9148a814-ae24-4005-adb6-d113933b67d3
- **リリースノートのローカライズ**
  - すべての言語でリリースノートを生成します。
  - サポートするすべての言語でChatGPTのコピー＆ペーストはもう不要です。
- **ストア同期**
  - App Store Connectとデータを同期します。Google Playもまもなく対応予定です。
  - App Store Connectでの手動データ入力はもう不要です。
  - 変更をすべてApp Store Connectにワンクリックでプッシュします。
  - アプリ審査への提出もワンクリックで行えます。

---

## 技術スタック

- [Next.js](https://nextjs.org/) – フレームワーク
- [TypeScript](https://www.typescriptlang.org/) – 言語
- [Tailwind](https://tailwindcss.com/) – CSS
- [shadcn/ui](https://ui.shadcn.com) - UIコンポーネント
- [Prisma](https://prisma.io) - ORM [![Made with Prisma](https://made-with.prisma.io/dark.svg)](https://prisma.io)
- [PostgreSQL](https://www.postgresql.org/) - データベース
- [NextAuth.js](https://next-auth.js.org/) – 認証
- [PostHog](https://posthog.com/) – 分析
- [Resend](https://resend.com) – メール
- [Stripe](https://stripe.com) – 決済
- [Vercel](https://vercel.com/) – ホスティング

---

## はじめに

### 1. リポジトリをクローンする


```bash
git clone https://github.com/ngo275/app-agent.git
```

### 2. .env.sample を .env にコピーし、値を変更する

```bash
cp .env.sample .env
```
以下は設定が必要な環境変数の一覧です：

- `NEXTAUTH_SECRET`
  - NextAuth.js用の秘密鍵。`openssl rand -base64 32`でランダムな文字列を生成できます。
- `NEXTAUTH_URL`
  - アプリのURL。例：`http://localhost:3000`。
- `NEXT_PUBLIC_BASE_URL`
  - アプリのURL。例：`http://localhost:3000`。
- `NEXT_PUBLIC_MARKETING_URL`
  - マーケティングページのURL。例：`http://localhost:3000`。
- `GOOGLE_CLIENT_ID`
  - Google OAuthアプリケーションのクライアントID。Googleログインで使用。Googleログインを使わない場合は不要。
- `GOOGLE_CLIENT_SECRET`
  - Google OAuthアプリケーションのクライアントシークレット。Googleログインで使用。Googleログインを使わない場合は不要。
- `RESEND_API_KEY`
  - ResendアカウントのAPIキー。メール送信に使用。
- `NEXT_PUBLIC_POSTHOG_KEY`
  - PostHogアカウントのキー。分析に使用。PostHogを使わない場合は不要。
- `OPENAI_API_KEY`
  - OpenAIアカウントのAPIキー。LLM利用に使用。
- `UPSTASH_REDIS_REST_URL`
  - UpstashアカウントのURL。キャッシュに使用。
- `UPSTASH_REDIS_REST_TOKEN`
  - Upstashアカウントのトークン。キャッシュに使用。
- `NEXT_PUBLIC_FREE_PLAN_ENABLED`
  - 無料プランを有効にするかどうか。無料プランを有効にするには`true`に設定。
- `NEXT_PUBLIC_STRIPE_PUBLISHABLE_KEY`
  - Stripeアカウントの公開可能キー。決済に使用。`NEXT_PUBLIC_FREE_PLAN_ENABLED`を`true`に設定している場合は不要。
- `STRIPE_SECRET_KEY`
  - Stripeアカウントのシークレットキー。決済に使用。`NEXT_PUBLIC_FREE_PLAN_ENABLED`を`true`に設定している場合は不要。
- `STRIPE_WEBHOOK_SECRET`
  - StripeアカウントのWebhookシークレット。Webhookに使用。`NEXT_PUBLIC_FREE_PLAN_ENABLED`を`true`に設定している場合は不要。
- `STRIPE_PRO_PRICE_ID`
  - StripeのProプランの価格ID。決済に使用。`NEXT_PUBLIC_FREE_PLAN_ENABLED`を`true`に設定している場合は不要。
- `DATABASE_URL`
  - PostgreSQLデータベースのURL。ローカルマシン以外では、[Supabase](https://supabase.com/)や[Neon](https://neon.tech/)の無料サービスを利用可能。

### 3. 依存関係のインストール


```bash
yarn

# Or with NPM
npm install
```

### 4. データベースの設定

```bash
yarn prisma generate
yarn prisma migrate deploy

# Or with NPM
npm run prisma generate
npm run prisma migrate deploy
```

### 5. 開発サーバーを起動する

```bash
yarn dev

# Or with NPM
npm run dev
```

[http://localhost:3000](http://localhost:3000) にアクセスしてアプリをご覧ください。

---

## 貢献について

貢献は大歓迎です！ぜひPRを提出してください。

貢献したい場合は、リポジトリをフォークしてPRを提出してください。

---

## ライセンス

AppAgentはGNU Affero General Public License Version 3（AGPLv3）またはそれ以降のバージョンの下でオープンソースとして公開されています。詳細は[こちら](https://github.com/ngo275/app-agent/blob/main/LICENSE)でご確認いただけます。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-15

---