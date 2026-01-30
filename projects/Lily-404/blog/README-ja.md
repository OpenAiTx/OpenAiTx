
<div align="right">
  <details>
    <summary >🌐 言語</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Jimmyのブログ

Next.js 15+ をベースに構築されたミニマルな個人ブログシステムです。

## 技術スタック

- **フレームワーク**: Next.js 13+ (App Router)
- **スタイル**: Tailwind CSS
- **アイコン**: Lucide Icons
- **テーマ**: ダーク/ライトモード切替対応
- **デプロイ**: Vercel

## 機能特徴

- 📝 Markdown記事対応
- 🌓 ダーク/ライトテーマ切替
- 📱 レスポンシブデザイン
- ⚡ 高速読み込み
- 📅 記事タイムライン表示
- 🔐 オンライン管理画面（GitHub APIで直接記事作成）

## プロジェクト構成

```
.
├── app/
│   ├── lib/           # 工具函数和数据处理
│   ├── posts/         # 博客文章
│   └── page.tsx       # 首页
├── content/
│   ├── notes/         # 随笔
│   └── posts/         # 文章
├── components/        # React 组件
├── public/            # 静态资源
└── styles/            # 全局样式
```

## インストールと実行

1. プロジェクトをクローンする

```bash
git clone https://github.com/Lily-404/blog.git
cd jimmy-blog
```
2. 依存関係のインストール


```bash
npm install
```
3. 開発サーバーの起動


```bash
npm run dev
```
4. プロダクションビルドの作成


```bash
npm run build
```

## 新しい記事の追加

### 方法1：オンライン管理画面（推奨）

1. `/admin` ページにアクセス
2. 管理者パスワードでログイン
3. 記事情報を入力して送信
4. GitHub API により記事が自動作成され、Vercel が自動で再デプロイ

### 方法2：ファイルを手動で追加

1. `content/posts` ディレクトリに新しい Markdown ファイルを作成
2. ファイル名の形式：xxx.md`
3. ファイルの先頭にメタデータを追加：

```markdown
---
title: 文章标题
date: YYYY-MM-DD
tags: ["标签1","标签2","标签3"]
---
```

## 随筆を追加する

1. `content/notes` ディレクトリに新しいMarkdownファイルを作成する
2. ファイル命名形式：`YYYY-MM-DD-title.md`
3. ファイルの先頭にメタデータを追加する：

```markdown
---
date: YYYY-MM-DD
---
```

## 管理バックエンドの設定

管理バックエンドは GitHub OAuth を使用して認証を行い、リポジトリの所有者または協力者のみがアクセスできます。

### 1. GitHub OAuth アプリの作成

1. [GitHub 設定 > 開発者設定 > OAuth Apps](https://github.com/settings/developers) にアクセス
2. 「New OAuth App」をクリック
3. 情報を入力：
   - **Application name**: `Jimmy Blog Admin`（または任意の名称）
   - **Homepage URL**: `https://あなたのドメイン.com`（本番環境）または `http://localhost:3000`（ローカル開発）
   - **Authorization callback URL**: 
     - 本番環境: `https://あなたのドメイン.com/api/auth/github/callback`
     - ローカル開発: `http://localhost:3000/api/auth/github/callback`
4. 「Register application」をクリック
5. **Client ID** を記録
6. 「Generate a new client secret」をクリックし、**Client secret** を記録

### 2. 環境変数の設定

Vercel プロジェクト設定で以下の環境変数を追加：

- `GITHUB_CLIENT_ID`: GitHub OAuth App の Client ID
- `GITHUB_CLIENT_SECRET`: GitHub OAuth App の Client Secret
- `GITHUB_OWNER`: GitHub ユーザー名（デフォルト: `Lily-404`、ユーザー権限の検証用）
- `GITHUB_REPO`: リポジトリ名（デフォルト: `blog`）
- `GITHUB_REDIRECT_URI`: OAuth コールバック URL（任意、デフォルトは自動生成）
- `NEXT_PUBLIC_BASE_URL`: サイトの URL（コールバック URL 生成用、本番環境では必須）
  - 本番環境: `https://www.jimmy-blog.top`
  - ローカル開発: `http://localhost:3000`

### 3. ローカル開発用設定

プロジェクトのルートディレクトリに `.env.local` ファイルを作成：

```env
GITHUB_CLIENT_ID=你的Client_ID
GITHUB_CLIENT_SECRET=你的Client_Secret
GITHUB_OWNER=Lily-404
GITHUB_REPO=blog
NEXT_PUBLIC_BASE_URL=http://localhost:3000
```

### 4. 本番環境の設定（Vercel）

Vercel プロジェクト設定で、以下を必ず設定してください：

```env
NEXT_PUBLIC_BASE_URL=https://www.jimmy-blog.top
```

⚠️ **注意**: 
- `.env.local` ファイルは `.gitignore` に追加されており、Git にコミットされません
- ローカル開発時は、OAuth App のコールバック URL を `http://localhost:3000/api/auth/github/callback` に設定してください
- **本番環境では `NEXT_PUBLIC_BASE_URL` を `https://www.jimmy-blog.top` に設定してください**
- 本番環境の OAuth App コールバック URL は次のように設定してください: `https://www.jimmy-blog.top/api/auth/github/callback`

## デプロイ

本プロジェクトは Vercel デプロイが設定されており、自動デプロイをサポートしています。コードを GitHub リポジトリにプッシュするだけで、Vercel が自動でビルドとデプロイを行います。

### 管理画面を使う利点

- ✅ ローカル開発環境が不要
- ✅ いつでもどこでも記事を追加できる
- ✅ Vercel の再デプロイを自動トリガー
- ✅ 完全無料（GitHub OAuth と Vercel は無料枠内）
- ✅ 安全（GitHub OAuth 認証、リポジトリ所有者・協力者のみアクセス可能）
- ✅ パスワード管理不要、GitHub アカウントでログイン可能

## コントリビュート

Issue や Pull Request の提出を歓迎します！

## ライセンス

MIT ライセンス


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-30

---