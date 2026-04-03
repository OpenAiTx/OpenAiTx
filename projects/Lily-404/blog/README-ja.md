
<div align="right">
  <details>
    <summary >🌐 言語</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=en">英語</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=zh-CN">簡体中国語</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=zh-TW">繁体中国語</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=ko">韓国語</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=hi">ヒンディー語</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=th">タイ語</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=fr">フランス語</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=de">ドイツ語</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=es">スペイン語</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=it">イタリア語</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=ru">ロシア語</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=pt">ポルトガル語</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=nl">オランダ語</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=pl">ポーランド語</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=ar">アラビア語</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=fa">ペルシャ語</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=tr">トルコ語</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=vi">ベトナム語</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=id">インドネシア語</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=as">アッサム語</a>
      </div>
    </div>
  </details>
</div>

# Jimmyのブログ

Next.js 15+ をベースに構築されたシンプルな個人ブログシステムで、オンライン創作と静的デプロイに対応しています。

## 技術スタック

- **フレームワーク**: Next.js 15+（App Router）
- **言語**: TypeScript
- **スタイル**: Tailwind CSS
- **アイコン**: Lucide Icons
- **内容**: Markdown + Gray Matter + Remark
- **認証**: GitHub OAuth
- **デプロイ**: Vercel

## 機能特徴

### 読者側

- 📝 Markdown + GFM 記事レンダリング（数式表示対応）
- 🏷️ タグによる絞り込み、ページング、アーカイブ（年別/タグ別）
- 📚 記事目次ナビゲーション（TOC）とコードブロックのワンクリックコピー
- 📱 レスポンシブレイアウトとダーク/ライトテーマ切り替え
- 🔥 ホバー創作カレンダーのヒートマップ（記事 + エッセイ）
- 📡 RSS 配信出力（`/rss.xml`）

### 創作側（管理画面）

- 🔐 GitHub OAuth ログイン（オーナー/協力者権限確認）
- ✍️ 記事/エッセイのオンライン作成、編集、削除
- 🆔 ファイルIDのカスタマイズ + 自動衝突回避
- 👀 編集 / プレビュー / 分割画面の三つの執筆モード
- 📊 創作統計パネル（総数、週/月の産出、人気タグ）

### エンジニアリング側

- ⚡ マルチページ静的出力（`force-static`）による性能と安定性向上
- 🧭 組み込み sitemap と robots
- 🧩 コンテンツ読込キャッシュとモジュール型API構造

## プロジェクト構成

```
.
├── app/               # 页面、API 路由、Server Actions
│   ├── api/           # 接口（OAuth、统计、校验、Markdown 等）
│   ├── actions/       # 内容管理相关服务端动作
│   ├── posts/         # 文章详情页
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
2. GitHub OAuthでログイン
3. 記事情報を入力して送信
4. 記事がGitHub APIを通じて自動作成され、Vercelが自動的に再デプロイします

### 方法2：手動でファイルを追加

1. `content/posts` ディレクトリに新しいMarkdownファイルを作成
2. ファイルの命名形式：`xxx.md`
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
- ローカル開発時は、OAuth アプリのコールバック URL を `http://localhost:3000/api/auth/github/callback` に設定してください
- **本番環境では `NEXT_PUBLIC_BASE_URL` を `https://www.jimmy-blog.top` に設定してください**
- 本番環境の OAuth アプリのコールバック URL は次のように設定してください: `https://www.jimmy-blog.top/api/auth/github/callback`

## デプロイ

本プロジェクトは Vercel デプロイが設定されており、自動デプロイに対応しています。コードを GitHub リポジトリにプッシュするだけで、Vercel が自動的にビルド・デプロイします。

### 管理画面を使うメリット

- ✅ ローカル開発環境が不要
- ✅ いつでもどこでも記事を追加可能
- ✅ Vercel の再デプロイを自動でトリガー
- ✅ 完全無料（GitHub OAuth と Vercel は無料枠で利用可）
- ✅ セキュア（GitHub OAuth 認証、リポジトリ所有者/コラボレーターのみアクセス可）
- ✅ パスワード管理不要、GitHub アカウントでログイン可能
- ✅ 既存コンテンツもオンライン編集対応（新規だけでなく）
- ✅ ファイル ID の衝突を自動処理、上書きや手動リネーム不要
- ✅ 管理画面に創作統計が標準搭載、継続的なコンテンツ運用に便利

## プロジェクト分析と今後の計画

- プロジェクト分析ドキュメント：[`docs/project-analysis.md`](https://raw.githubusercontent.com/Lily-404/blog/main/docs/project-analysis.md)
- 今後の計画ドキュメント：[`docs/future-roadmap.md`](https://raw.githubusercontent.com/Lily-404/blog/main/docs/future-roadmap.md)

## 貢献

Issue や Pull Request の提出を歓迎します！

## ライセンス

MIT License


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-03

---