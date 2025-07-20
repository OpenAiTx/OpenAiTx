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

# オープンソースで軽量なTrello代替、メイカーやインディーハッカー向けに設計。

シンプルさ、速度、スケーラビリティにフォーカス。
最新のスタック（Tailwind CSS、shadcn/ui、Supabase、Stripe連携）で構築。
無制限プロジェクト、チームコラボレーション、ダーク/ライトモード、シームレスなユーザー体験をサポート。
不要な複雑さなく、完全なコントロールを求めるソロ開発者や小規模チームに最適。

## 🌟 このプロジェクトが役立つと感じたら、ぜひスターを付けてください！他の人にも発見されやすくなります。

# デプロイガイド

## 概要
このアプリケーションは、Stripe連携のためにSupabase Edge Functionsの代わりにローカルのNext.js APIルートを使用するようになりました。これによりデプロイが簡単になり、標準の.envファイルで設定が可能です。

## 環境変数の設定

### 1. .env.localファイルを作成
`.env.example`を`.env.local`にコピーし、実際の値を入力してください：


```bash
cp .env.example .env.local
```
### 2. 必要な環境変数

#### Supabaseの設定
- `NEXT_PUBLIC_SUPABASE_URL` - あなたのSupabaseプロジェクトのURL
- `NEXT_PUBLIC_SUPABASE_ANON_KEY` - あなたのSupabase匿名キー
- `SUPABASE_SERVICE_ROLE_KEY` - あなたのSupabaseサービスロールキー（サーバーサイドのみ）

#### Stripeの設定（任意）
- `STRIPE_SECRET_KEY` - あなたのStripeシークレットキー（サーバーサイドのみ）
- `NEXT_PUBLIC_STRIPE_PUBLISHABLE_KEY` - あなたのStripe公開可能キー
- `STRIPE_WEBHOOK_SECRET` - あなたのStripeウェブフックシークレット

#### サイトの設定
- `NEXT_PUBLIC_SITE_URL` - あなたのサイトURL（本番用）
- `NEXTAUTH_URL` - あなたのサイトURL（上記と同じ）
- `NEXTAUTH_SECRET` - NextAuth用のランダムなシークレット

## ローカル開発

1. 依存関係をインストールします：

```bash
npm install
```
2. `.env.local` に環境変数を設定します

3. 開発サーバーを起動します:

```bash
npm run dev
```
4. Stripe CLIを使用してローカルでStripeのウェブフックをテストする:

```bash
stripe listen --forward-to localhost:3000/api/stripe/webhook
```
## 本番環境へのデプロイ


### Vercelへのデプロイ

1. **Vercelにデプロイする:**

```bash
npx vercel
```
2. **環境変数：**  
   VercelのダッシュボードまたはCLIを通じてすべての環境変数を追加してください  

3. **Stripe Webhookの設定：**  
   - Webhookの送信先を次に設定してください：`https://your-domain.vercel.app/api/stripe/webhook`  

## APIエンドポイント  

アプリケーションは現在、以下のローカルAPIルートを使用しています：  

- `POST /api/stripe/checkout` - Stripeのチェックアウトセッションを作成  
- `POST /api/stripe/webhook` - StripeのWebhookイベントを処理  

## ローカルAPIルートの利点  

1. **デプロイが簡単** - 別のエッジ関数をデプロイする必要がありません  
2. **環境変数のサポート** - 標準の.envファイルが利用可能  
3. **デバッグが容易** - ローカルでのデバッグが簡単になります  
4. **フレームワークとの統合** - Next.jsとの統合が向上  
5. **ベンダーロックインなし** - Next.jsをサポートする任意のプラットフォームにデプロイ可能  

## トラブルシューティング  

1. **Webhookの問題：**  
   - `STRIPE_WEBHOOK_SECRET`がStripeのWebhookエンドポイントと一致していることを確認  
   - StripeダッシュボードでWebhookログを確認  
   - WebhookのURLが正しいことを検証  

2. **環境変数：**  
   - 必要なすべての変数が設定されているか確認  
   - 変数名のタイプミスをチェック  
   - Supabaseのサービスロールキーに適切な権限があることを確認  

3. **CORSの問題：**  
   - APIルートに適切なCORSヘッダーが含まれている  
   - 必要に応じてドメインがホワイトリストに登録されていることを確認  

## セキュリティに関する注意  

- `STRIPE_SECRET_KEY`や`SUPABASE_SERVICE_ROLE_KEY`をクライアントに公開しないこと  
- クライアント側変数には`NEXT_PUBLIC_`プレフィックスのみ使用  
- Webhookシークレットは定期的にローテーションすること  
- StripeダッシュボードでWebhook配信を監視すること  



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---