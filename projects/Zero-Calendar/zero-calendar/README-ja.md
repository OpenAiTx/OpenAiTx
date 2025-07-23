
# Zero Calendar

[![Vercelでデプロイ](https://vercel.com/button)](https://vercel.com/new/clone?repository-url=https%3A%2F%2Fgithub.com%2FZero-Calendar%2Fzero-calendar)

**未来のスケジューリングのためのオープンソースAI搭載カレンダー**

## Zero Calendarとは？
Zero Calendarは、ユーザーがスケジュールを賢く管理できるオープンソースのAIカレンダーソリューションで、Googleカレンダーやその他のカレンダープロバイダーなどの外部サービスと統合します。私たちの目標は、AIエージェントを通じてスケジューリングを近代化し改善し、時間管理の方法を真に革新することです。

## なぜZero Calendarなのか？
現在のほとんどのカレンダーサービスは、クローズドソースであったり、データを大量に収集したり、インテリジェントな機能が不足しています。Zero Calendarは違います：

✅ **オープンソース** – 隠された意図なし、完全に透明。  
🦾 **AI駆動** - AIアシスタントとLLMでスケジューリングを強化。  
🔒 **データプライバシー最優先** – あなたのスケジュール、あなたのデータ。Zero Calendarはデータを追跡、収集、販売しません。  
⚙️ **セルフホスティング自由** – 簡単に自分のカレンダーアプリを運用可能。  
📅 **統合カレンダー** – Googleカレンダー、Outlookなど複数のカレンダープロバイダーを接続。  
🎨 **カスタマイズ可能なUI＆機能** – 自分好みにカレンダー体験を調整可能。  
🚀 **開発者フレンドリー** – 拡張性と統合を念頭に構築。  

## 技術スタック
Zero Calendarは現代的で信頼性の高い技術で構築されています：

- **フロントエンド**: Next.js, React, TypeScript, TailwindCSS, Shadcn UI  
- **バックエンド**: Next.js APIルート, サーバーアクション  
- **データベース**: Vercel KV (Redis)  
- **認証**: NextAuth.js, Google OAuth  
- **AI**: AI SDK, Groq  

## はじめに

### 前提条件
必要なバージョン：  
- Node.js (v18以上)  
- npm (v9以上) または pnpm (v8以上)  

アプリケーションを実行する前に、サービスのセットアップと環境変数の設定が必要です。環境変数の詳細は環境変数セクションを参照してください。

### セットアップオプション

#### クイックスタートガイド

1. **クローンしてインストール**
```bash
# Clone the repository
git clone https://github.com/Zero-Calendar/zero-calendar.git
cd zero-calendar

# Install dependencies
npm install
# or
pnpm install
```
2. **環境設定**
- プロジェクトのルートにある `.env.example` を `.env.local` にコピーする

```bash
cp .env.example .env.local
```
- 環境変数を設定します（下記参照）

3. **アプリを起動する**
```bash
npm run dev
# or
pnpm dev
```
4. **ブラウザで開く**  
- http://localhost:3000 にアクセスしてください  

### 環境変数  
プロジェクトのルートに `.env.local` ファイルを作成し、以下の変数を設定してください:


```
# NextAuth
NEXTAUTH_SECRET=     # Required: Secret key for authentication (generate with `openssl rand -hex 32`)
NEXTAUTH_URL=        # Required: URL of your application (http://localhost:3000 for local dev)

# Google OAuth (Required for Google Calendar integration)
GOOGLE_CLIENT_ID=    # Required for Google Calendar integration
GOOGLE_CLIENT_SECRET=# Required for Google Calendar integration

# Vercel KV (Redis)
KV_URL=              # Required: Vercel KV URL
KV_REST_API_URL=     # Required: Vercel KV REST API URL
KV_REST_API_TOKEN=   # Required: Vercel KV REST API token
KV_REST_API_READ_ONLY_TOKEN= # Required: Vercel KV REST API read-only token

# AI Integration
GROQ_API_KEY=        # Required for AI features
```
### Google OAuth 設定（Google カレンダー統合に必須）

1. [Google Cloud Console](https://console.cloud.google.com/) にアクセスします
2. 新しいプロジェクトを作成します
3. Google Cloud プロジェクトに以下の API を追加します：
   - Google カレンダー API
   - Google People API
4. Google OAuth2 API を有効化します
5. OAuth 2.0 資格情報を作成します（ウェブアプリケーションタイプ）
6. 承認済みリダイレクト URI を追加します：
   - 開発環境: `http://localhost:3000/api/auth/callback/google`
   - 本番環境: `https://your-production-url/api/auth/callback/google`
7. `.env.local` に追加します：

```
GOOGLE_CLIENT_ID=your_client_id
GOOGLE_CLIENT_SECRET=your_client_secret
```
8. テストユーザーとして自分を追加する:
   - OAuth同意画面に移動
   - 「テストユーザー」下の「ユーザーを追加」をクリック
   - 自分のメールアドレスを追加し、「保存」をクリック

> **警告**
>
> Google Cloud Consoleの承認済みリダイレクトURIは、`.env.local`に設定したものとプロトコル（http/https）、ドメイン、パスを含めて完全に一致している必要があります。

### Vercel KV 設定

1. アカウントをお持ちでない場合はVercelアカウントを作成
2. Vercel CLIをインストール: `npm i -g vercel`
3. Vercelにログイン: `vercel login`
4. プロジェクトをリンク: `vercel link`
5. VercelダッシュボードからKVデータベースを作成
6. KVの環境変数をプロジェクトに追加: `vercel env pull .env.local`

## 機能

- 🤖 **AIアシスタント**: 自然言語でカレンダーと対話
- 🔄 **Googleカレンダー連携**: 既存のGoogleカレンダーと同期
- 🎨 **カスタマイズ可能なUI**: ダークモードや個人設定
- 🔄 **繰り返しイベント**: 例外対応を含む繰り返しイベントの完全サポート
- 🌐 **タイムゾーン管理**: グローバルスケジューリングのための完全なタイムゾーン対応
- 📤 **インポート/エクスポート**: ICSおよびCSV形式でカレンダーデータの入出力
- ⌨️ **キーボードショートカット**: 効率的なカレンダー管理のためのパワーユーザー向けショートカット
- 🔔 **イベント管理**: イベントの作成、編集、削除を簡単に
- 🔒 **安全な認証**: メール/パスワードまたはGoogle OAuthでログイン

### キーボードショートカット

Zero Calendarにはパワーユーザー向けのキーボードショートカットがあります:

| ショートカット | 動作 |
|----------|--------|
| `←` | 前の月へ |
| `→` | 次の月へ |
| `T` | 今日に移動 |
| `N` | 新しいイベントを作成 |
| `?` | キーボードショートカットを表示 |
| `/` | 検索にフォーカス |
| `M` | 月表示に切り替え |
| `W` | 週表示に切り替え |
| `D` | 日表示に切り替え |
| `A` | AIアシスタントの切り替え |
| `S` | 設定に移動 |
| `Esc` | ダイアログを閉じる |

## コントリビュート
[コントリビュートガイド](https://raw.githubusercontent.com/Zero-Calendar/zero-calendar/main/.github/CONTRIBUTING.md)をご参照ください。

## ライセンス

Zero Calendarは[GPLv3ライセンス](https://raw.githubusercontent.com/Zero-Calendar/zero-calendar/main/LICENSE.md)の下で公開されているオープンソースソフトウェアです。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-17

---