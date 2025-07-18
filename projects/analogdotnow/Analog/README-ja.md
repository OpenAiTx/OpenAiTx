<translate-content><p align="center">
  <h1 align="center">Analog</h1>
  <p align="center">すべてを変えるオープンソースカレンダー</p>
</p>

## はじめに

Analogをローカルマシンで起動するには、次の手順に従ってください。

### 前提条件

以下がインストールされていることを確認してください：

- **Bun**：高速なJavaScriptランタイム、パッケージマネージャー、バンドラー、テストランナーです。
  - [インストールガイド](https://bun.sh/docs/installation)
- **Docker Desktop**：PostgreSQLデータベースを実行するためのものです。
  - [インストールガイド](https://www.docker.com/products/docker-desktop/)

### セットアップ

1.  **リポジトリをクローンする**：
</translate-content>
    ```bash
    git clone https://github.com/jeanmeijer/analog.git
    cd analog
    ```
2.  **依存関係をインストールする**:


    ```bash
    bun install
    ```
3.  **環境変数の設定**：
    サンプル環境ファイルをコピーします：


    ```bash
    cp .env.example .env
    ```
    次に、新しく作成した `.env` ファイルを開きます。`DATABASE_URL` と `BETTER_AUTH_URL` のデフォルト値が設定されています。以下を設定する必要があります：
    - `BETTER_AUTH_SECRET`：ターミナルで `openssl rand -hex 32` を実行して安全なシークレットを生成してください。
      <br/><br/>

4.  **Google OAuth を設定する**：

- `GOOGLE_CLIENT_ID` と `GOOGLE_CLIENT_SECRET`：
  1. [Google Cloud Console](https://console.cloud.google.com/)でGoogleプロジェクトを作成します。
  2. [Better Authのドキュメントのステップ1](https://www.better-auth.com/docs/authentication/google)に従ってGoogle OAuthの認証情報を設定します。
  3. [Google Cloud Console APIs](https://console.cloud.google.com/apis/library/calendar-json.googleapis.com)でGoogleカレンダーAPIを有効化します。
  4. テストユーザーとして自身を追加します：
     - Google OAuthの[`Audience`](https://console.cloud.google.com/auth/audience)タブを見つけます。
     - 「テストユーザー」欄の「ユーザーを追加」をクリックします。
     - テキストボックスにメールアドレスを入力し、「保存」をクリックします。

5. **Microsoft OAuth を設定する**（任意）：

- `MICROSOFT_CLIENT_ID` と `MICROSOFT_CLIENT_SECRET`：
  1. [Microsoft Azure ポータル](https://portal.azure.com/)にアクセスし、Microsoft Entra ID → アプリ登録に移動します。
  2. 新しいアプリケーションを登録し、リダイレクトURIを (`http://localhost:3000/api/auth/callback/microsoft`) に設定します。
  3. アプリケーション（クライアント）IDをコピーし、証明書とシークレットで新しいクライアントシークレットを作成します。
  4. APIのアクセス許可に移動し、「+許可の追加」をクリック、Microsoft Graph → 委任された権限を選択し、以下を追加します：
     - `Calendars.Read`, `Calendars.ReadWrite`, `User.Read`, `offline_access`

### データベースのセットアップ

AnalogはDrizzle ORMを使ったPostgreSQLを使用します。Dockerを使ってデータベースを起動できます：

1.  **PostgreSQLデータベースコンテナを起動する**：


    ```bash
    bun run docker:up
    ```
<translate-content>
    このコマンドは `docker-compose.yml` を使用してPostgreSQLコンテナを起動します。

2.  **データベースの初期化**：
    データベースコンテナが起動して正常な状態になったら、データベースを初期化します：
</translate-content>
    ```bash
    bun run db:push
    ```
### アプリケーションの実行

環境とデータベースの設定が完了したら、開発サーバーを起動できます：


```bash
bun run dev
```
アプリケーションは、ブラウザで [http://localhost:3000](http://localhost:3000) からアクセスできるようになっています。

## 技術スタック

- **Web**: Next.js、TypeScript、Tailwind v4、Bun、tRPC、TanStack Query、shadcn/ui
- **データベース**: Drizzle と PostgreSQL
- **認証**: Better Auth を使用した Google OAuth

## ロードマップ

作業進行中。

## 貢献について

このプロジェクトへの貢献方法の詳細は、[CONTRIBUTING.md](https://raw.githubusercontent.com/analogdotnow/Analog/main/./CONTRIBUTING.md) をご覧ください。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---