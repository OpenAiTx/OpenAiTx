<div align="right">
  <details>
    <summary >🌐 言語</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# メーカーやインディハッカー向けに設計されたオープンソースの軽量Trello代替品。

シンプルさ、速度、スケーラビリティに注力。
モダンなスタックで構築：Tailwind CSS、shadcn/ui、Supabase、Stripe統合。
無制限のプロジェクト、チームコラボレーション、ダーク/ライトモード、シームレスなユーザー体験をサポート。
不要な複雑さなしに完全なコントロールを望むソロ開発者や小規模チームに最適。

## 🌟 このプロジェクトが役立つと思ったら、スターを付けてください！他の人が見つけやすくなります。

# デプロイメントガイド

## 概要
このアプリケーションは現在、Stripe統合にSupabase Edge Functionsの代わりにローカルのNext.js APIルートを使用しています。これによりデプロイが簡単になり、標準の.envファイルを使用して設定できます。

## 環境変数の設定

### 1. .env.localファイルを作成
`.env.example`を`.env.local`にコピーし、実際の値を入力してください：


```bash
cp .env.example .env.local
```
### 2. 必要な環境変数

#### Supabase の設定
- `NEXT_PUBLIC_SUPABASE_URL` - あなたの Supabase プロジェクトの URL
- `NEXT_PUBLIC_SUPABASE_ANON_KEY` - あなたの Supabase 匿名キー
- `SUPABASE_SERVICE_ROLE_KEY` - あなたの Supabase サービスロールキー（サーバー側のみ）

#### Stripe の設定（任意）
- `STRIPE_SECRET_KEY` - あなたの Stripe シークレットキー（サーバー側のみ）
- `NEXT_PUBLIC_STRIPE_PUBLISHABLE_KEY` - あなたの Stripe 公開可能キー
- `STRIPE_WEBHOOK_SECRET` - あなたの Stripe webhook シークレット

#### サイトの設定
- `NEXT_PUBLIC_SITE_URL` - あなたのサイト URL（本番用）
- `NEXTAUTH_URL` - あなたのサイト URL（上記と同じ）
- `NEXTAUTH_SECRET` - NextAuth 用のランダムなシークレット

## ローカル開発

1. 依存関係をインストールします:

```bash
npm install
```
2. `.env.local` に環境変数を設定します

3. 開発サーバーを起動します：

```bash
npm run dev
```
4. Stripe CLI を使用してローカルで Stripe ウェブフックをテストする:

```bash
stripe listen --forward-to localhost:3000/api/stripe/webhook
```
## 本番環境へのデプロイ


### Vercelへのデプロイ

1. **Vercelにデプロイする:**

```bash
npx vercel
```
2. **環境変数:**
   VercelのダッシュボードまたはCLIを通じてすべての環境変数を追加してください

3. **Stripe Webhook設定:**
   - WebhookのURLを次に設定: `https://your-domain.vercel.app/api/stripe/webhook`

## APIエンドポイント

アプリケーションは現在、以下のローカルAPIルートを使用しています:

- `POST /api/stripe/checkout` - Stripeのチェックアウトセッションを作成
- `POST /api/stripe/webhook` - StripeのWebhookイベントを処理

## ローカルAPIルートの利点

1. **展開が簡単** - 個別のエッジ関数を展開する必要がありません
2. **環境変数** - 標準の.envファイルをサポート
3. **デバッグが容易** - ローカルでのデバッグが簡単
4. **フレームワーク統合** - Next.jsとの統合が向上
5. **ベンダーロックインなし** - Next.jsをサポートする任意のプラットフォームに展開可能

## トラブルシューティング

1. **Webhookの問題:**
   - `STRIPE_WEBHOOK_SECRET`がStripeのWebhookエンドポイントと一致していることを確認
   - StripeダッシュボードでWebhookログを確認
   - WebhookのURLが正しいか検証

2. **環境変数:**
   - 必要な変数がすべて設定されていることを確認
   - 変数名のタイプミスをチェック
   - Supabaseサービスロールキーに適切な権限があるか確認

3. **CORSの問題:**
   - APIルートには適切なCORSヘッダーが含まれている
   - 必要に応じてドメインがホワイトリストに登録されていることを確認

## セキュリティノート

- `STRIPE_SECRET_KEY`や`SUPABASE_SERVICE_ROLE_KEY`をクライアントに絶対に公開しないこと
- クライアント側変数には`NEXT_PUBLIC_`プレフィックスのみを使用
- Webhookのシークレットは定期的にローテーションすること
- StripeダッシュボードでWebhookの配信状況を監視すること



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-23

---