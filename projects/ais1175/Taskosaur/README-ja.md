# タスコサウル

<img src="https://raw.githubusercontent.com/Taskosaur/Taskosaur/main/frontend/public/taskosaur-logo.svg" alt="Taskosaur ロゴ" width="128">

### 会話型AIタスク実行によるオープンソースプロジェクト管理

### 📹 Taskosaurの実演を見る

[![Taskosaur デモ - AIがシンプルなリクエストを完全なプロジェクトに変える](https://img.youtube.com/vi/sv2lsteRKac/maxresdefault.jpg)](https://youtu.be/sv2lsteRKac)

*クリックして視聴: Taskosaurでの会話型AIタスク実行の仕組みを見る*

Taskosaurは、アプリ内でのタスク実行に特化した会話型AIを備えたオープンソースのプロジェクト管理プラットフォームです。AIアシスタントは自然な会話を通じて、タスク作成からワークフロー管理までプロジェクト管理業務を直接アプリ内で処理します。

<!-- バッジ -->

![Node.js](https://img.shields.io/badge/node-%3E%3D22.0.0-brightgreen.svg)
![TypeScript](https://img.shields.io/badge/typescript-%5E5.0.0-blue.svg)
![NestJS](https://img.shields.io/badge/nestjs-%5E11.0.0-red.svg)
![Next.js](https://img.shields.io/badge/nextjs-15.2.2-black.svg)
![PostgreSQL](https://img.shields.io/badge/postgresql-%3E%3D16-blue.svg)
![Redis](https://img.shields.io/badge/redis-%3E%3D7-red.svg)
![AI](https://img.shields.io/badge/AI-Powered-purple.svg)

Taskosaurは従来のプロジェクト管理機能と会話型AIタスク実行を融合し、自然な会話でプロジェクトを管理できます。メニューやフォームを操作する代わりに、必要なことを説明するだけでタスク作成、作業割り当て、ワークフロー管理が可能です。

## 主な特徴

- 🤖 **会話型AIによるタスク実行** - アプリ内で自然な会話を通じてプロジェクトタスクを実行
- 💬 **自然言語コマンド** - 「先週の高優先度バグでスプリントを作成」などを自動実行
- 🏠 **セルフホスト** - データは自社インフラに保持
- 💰 **お好きなLLMを利用可能** - OpenAI、Anthropic、OpenRouter、ローカルモデルのAPIキーを使用
- 🔧 **アプリ内ブラウザ自動化** - AIがインターフェースを操作し、直接アプリ内でアクションを実行
- 📊 **完全なプロジェクト管理機能** - カンバンボード、スプリント、タスク依存関係、時間追跡
- 🌐 **オープンソース** - Business Source License（BSL）で提供

## 目次

- [主な特徴](#主な特徴)
- [クイックスタート](#クイックスタート)
  - [前提条件](#prerequisites)
  - [Dockerセットアップ（推奨）](#docker-setup-recommended)
  - [手動セットアップ](#manual-setup)
- [開発](#development)
- [プロジェクト構造](#project-structure)
- [デプロイ](#deployment)
- [APIドキュメント](#api-documentation)
- [貢献](#contributing)
- [ライセンス](#license)
- [サポート](#support)

## クイックスタート

### 前提条件

- Node.js 22+ および npm 10+
- PostgreSQL 16+（またはDocker）
- Redis 7+（またはDocker）

### Dockerセットアップ（推奨）

Taskosaurを最速で始める方法はDocker Composeを使うことです：

1. **リポジトリをクローンする**

   ```bash
   git clone https://github.com/Taskosaur/Taskosaur.git taskosaur
   cd taskosaur
   ```

2. **環境変数の設定**
   ```bash
   cp .env.example .env
   ```
   これにより、アプリで使用される.envファイルが作成されます。必要に応じて値をカスタマイズしてください。
   
3. **Docker Composeで起動する**

   ```bash
   docker compose -f docker-compose.dev.yml up
   ```
   これにより自動的に：
   - ✅ PostgreSQL と Redis を起動します
   - ✅ すべての依存関係をインストールします
   - ✅ Prisma クライアントを生成します
   - ✅ データベースマイグレーションを実行します
   - ✅ サンプルデータでデータベースをシードします
   - ✅ バックエンドとフロントエンドの両方を起動します

4. **アプリケーションにアクセスする**
   - フロントエンド: http://localhost:3001
   - バックエンドAPI: http://localhost:3000
   - APIドキュメント: http://localhost:3000/api/docs

詳細なDockerドキュメントは[DOCKER_DEV_SETUP.md](https://raw.githubusercontent.com/ais1175/Taskosaur/main/DOCKER_DEV_SETUP.md)を参照してください。

### 手動セットアップ

サービスをローカルで実行したい場合：

1. **リポジトリをクローンする**


   ```bash
   git clone https://github.com/Taskosaur/Taskosaur.git taskosaur
   cd taskosaur
   ```
2. **依存関係のインストール**


   ```bash
   npm install
   ```

3. **環境設定**

   ルートディレクトリに `.env` ファイルを作成します：

   ```env
   # Database Configuration
   DATABASE_URL="postgresql://taskosaur:taskosaur@localhost:5432/taskosaur"

   # Application
   NODE_ENV=development

   # Authentication & Security
   JWT_SECRET="your-jwt-secret-key-change-this"
   JWT_REFRESH_SECRET="your-refresh-secret-key-change-this-too"
   JWT_EXPIRES_IN="15m"
   JWT_REFRESH_EXPIRES_IN="7d"

   # Encryption for sensitive data
   ENCRYPTION_KEY="your-64-character-hex-encryption-key-change-this-to-random-value"

   # Redis Configuration (for Bull Queue)
   REDIS_HOST=localhost
   REDIS_PORT=6379
   REDIS_PASSWORD=

   # Email Configuration (optional, for notifications)
   SMTP_HOST=smtp.example.com
   SMTP_PORT=587
   SMTP_USER=your-email@taskosaur.com
   SMTP_PASS=your-app-password
   SMTP_FROM=noreply@taskosaur.com
   EMAIL_DOMAIN="taskosaur.com"

   # Frontend URL (for email links and CORS)
   FRONTEND_URL=http://localhost:3001
   CORS_ORIGIN="http://localhost:3001"

   # Backend API URL (for frontend to connect to backend)
   NEXT_PUBLIC_API_BASE_URL=http://localhost:3000/api

   # File Upload
   UPLOAD_DEST="./uploads"
   MAX_FILE_SIZE=10485760

   # Queue Configuration
   MAX_CONCURRENT_JOBS=5
   JOB_RETRY_ATTEMPTS=3
   ```

4. **データベースの設定**

   ```bash
   # Run database migrations
   npm run db:migrate

   # Seed the database (idempotent - safe to run multiple times)
   npm run db:seed

   # Or seed with admin user only
   npm run db:seed:admin
   ```

5. **アプリケーションを起動する**

   ```bash
   # Development mode (runs both frontend and backend)
   npm run dev

   # Or start individually
   npm run dev:frontend    # Start frontend only (port 3001)
   npm run dev:backend     # Start backend only (port 3000)
   ```

6. **アプリケーションへのアクセス**
   - フロントエンド: http://localhost:3001
   - バックエンドAPI: http://localhost:3000
   - APIドキュメント: http://localhost:3000/api/docs

## 開発

### 利用可能なコマンド

すべてのコマンドはルートディレクトリから実行されます:

#### 開発

```bash
npm run dev              # Start both frontend and backend concurrently
npm run dev:frontend     # Start frontend only (Next.js on port 3001)
npm run dev:backend      # Start backend only (NestJS on port 3000)
```

#### ビルド

```bash
npm run build            # Build all workspaces (frontend + backend)
npm run build:frontend   # Build frontend for production
npm run build:backend    # Build backend for production
npm run build:dist       # Build complete distribution package
```

#### データベース操作

すべてのシードコマンドは**冪等**であり、複数回実行しても安全です：

```bash
npm run db:migrate         # Run database migrations
npm run db:migrate:deploy  # Deploy migrations (production)
npm run db:reset           # Reset database (deletes all data!)
npm run db:seed            # Seed database with sample data
npm run db:seed:admin      # Seed database with admin user only
npm run db:generate        # Generate Prisma client
npm run db:studio          # Open Prisma Studio (database GUI)
npm run prisma             # Run Prisma CLI commands directly
```

#### テスト

```bash
npm run test               # Run all tests
npm run test:frontend      # Run frontend tests
npm run test:backend       # Run backend unit tests
npm run test:watch         # Run backend tests in watch mode
npm run test:cov           # Run backend tests with coverage
npm run test:e2e           # Run backend end-to-end tests
```

#### コード品質

```bash
npm run lint               # Lint all workspaces
npm run lint:frontend      # Lint frontend code
npm run lint:backend       # Lint backend code
npm run format             # Format backend code with Prettier
```

#### クリーンアップ

```bash
npm run clean              # Clean all build artifacts
npm run clean:frontend     # Clean frontend build artifacts
npm run clean:backend      # Clean backend build artifacts
```

### Gitフック

**Husky**による自動コード品質チェック：

- **Pre-commit**：各コミット前にすべてのワークスペースでリンターを実行
- コード品質と一貫性を保証
- `--no-verify`でバイパス可能（緊急時のみ）

```bash
git commit -m "feat: add feature"  # Runs checks automatically
```

## プロジェクト構成

```
taskosaur/
├── backend/                # NestJS Backend (Port 3000)
│   ├── src/
│   │   ├── modules/       # Feature modules
│   │   ├── common/        # Shared utilities
│   │   ├── config/        # Configuration
│   │   └── gateway/       # WebSocket gateway
│   ├── prisma/            # Database schema and migrations
│   ├── public/            # Static files
│   └── uploads/           # File uploads
├── frontend/              # Next.js Frontend (Port 3001)
│   ├── src/
│   │   ├── app/          # App Router pages
│   │   ├── components/   # React components
│   │   ├── contexts/     # React contexts
│   │   ├── hooks/        # Custom hooks
│   │   ├── lib/          # Utilities
│   │   └── types/        # TypeScript types
│   └── public/           # Static assets
├── docker/               # Docker configuration
│   └── entrypoint-dev.sh # Development entrypoint script
├── scripts/              # Build and utility scripts
├── .env.example          # Environment variables template
├── docker-compose.dev.yml # Docker Compose for development
└── package.json          # Root package configuration
```

## 会話型AIタスク実行の設定

### 3ステップで会話型AIタスク実行を有効化：

1. **組織設定に移動**

   ```
   Go to Settings → Organization Settings → AI Assistant Settings
   ```

2. **LLM APIキーを追加する**

   - 「AIチャットを有効にする」をONに切り替えます
   - 任意の対応プロバイダーからAPIキーを追加します：
     - **OpenRouter**（100以上のモデル、無料オプションあり）：`https://openrouter.ai/api/v1`
     - **OpenAI**（GPTモデル）：`https://api.openai.com/v1`
     - **Anthropic**（Claudeモデル）：`https://api.anthropic.com/v1`
     - **Local AI**（Ollamaなど）：ローカルエンドポイント

3. **AIで管理を開始する**
   - AIチャットパネル（きらめきアイコン）を開きます
   - 次のように入力します：_「Website Redesignという新しいプロジェクトを5つのタスクで作成して」_
   - AIがワークフローを自動的に実行します

### 会話型AIによるタスク実行の仕組み

Taskosaurの会話型AIタスク実行は、アプリ内でのタスク実行に会話型AIを活用し、単なる提案ではなく直接アクションを行います：

- **アプリ内会話実行** - AIと自然に会話しながらアプリ内で直接タスクを実行
- **直接ブラウザ自動化** - AIがリアルタイムでインターフェースを操作しボタンをクリック
- **複雑なワークフロー実行** - 会話を通じて多段階の操作をシームレスに処理
- **コンテキスト認識アクション** - 現在のプロジェクトやワークスペースの状況を理解
- **自然言語インターフェース** - コマンドを覚える必要なし、自然に話すだけ

**会話型AIタスク実行のコマンド例：**

```
"Set up a new marketing workspace with Q1 campaign project"
"Move all high-priority bugs to in-progress and assign to John"
"Create a sprint with tasks from last week's backlog"
"Generate a report of Sarah's completed tasks this month"
"Set up automated workflow: when task is marked done, create review subtask"
```
## 特徴

_Taskosaurは積極的に開発中です。以下の機能は当社の計画中の機能を示しており、多くはすでに実装済みであり、その他は進行中です。_

### 🤖 会話型AIタスク実行機能

🎯 **アプリ内会話型タスク実行**

- **アプリ内チャットインターフェース**：Taskosaur内でAIと直接会話してタスクを実行
- **ブラウザベースのタスク実行**：AIがインターフェースを操作し、フォーム入力やタスクをリアルタイムで完了
- **多段階ワークフロー処理**：単一の会話コマンドで複雑なワークフローを実行
- **コンテキスト理解**：AIが現在の作業スペース、プロジェクト、チームの状況を認識
- **能動的提案**：AIがボトルネックを特定し、会話を通じて改善案を提案

🧠 **自然言語処理**

- 複雑なプロジェクト管理のリクエストを理解
- 会話入力からアクション、パラメータ、コンテキストを抽出
- 現在のコンテキストから不足情報を推測

⚡ **アクション実行**

- リアルタイムのブラウザ自動化
- 複数タスクの一括操作
- 既存のワークフロー内で動作

🚀 **プロジェクトワークフローサポート**

- スプリント計画とタスク分析
- チームのキャパシティに基づくタスク割り当て
- プロジェクトのタイムライン予測

**会話型AIタスク実行の例：**

- 「Q1マーケティングキャンペーンを設定：作業スペース作成、チーム追加、標準テンプレートで3つのプロジェクトをセットアップ」
- 「期限切れのタスクをすべて分析し、チームのキャパシティと優先順位に基づいて再スケジュール」
- 「自動化ワークフロー作成：高優先度バグ→シニア開発者に割り当て→チームリーダーに通知」
- 「スプリント振り返りを作成し、チームのベロシティ分析と改善提案を生成」
- 「旧プロジェクトから新しい作業スペースへすべてのデザインタスクを移行し、割り当てを更新」

### 組織管理

- **マルチテナントアーキテクチャ**：分離されたデータを持つ複数組織のサポートを計画中  
- **ワークスペース組織**：プロジェクトをワークスペース内でグループ化し整理  
- **ロールベースアクセス制御**：詳細な権限管理を実装（管理者、マネージャー、メンバー、閲覧者）  
- **チーム管理**：組織を跨いだチームメンバーの招待と管理  

### プロジェクト管理

- **柔軟なプロジェクト構造**：カスタムワークフローでプロジェクト作成と管理  
- **スプリント計画**：計画と追跡が可能なアジャイルスプリント管理を予定  
- **タスク依存関係**：様々な依存タイプを持つタスク間の関係を検討中  
- **カスタムワークフロー**：異なるプロジェクトニーズに応じたカスタムステータスワークフロー実装  

### タスク管理

- **多彩なタスクタイプ**：タスク、バグ、エピック、ストーリー、サブタスクをサポート  
- **優先度管理**：最低から最高までのタスク優先度設定  
- **カスタムフィールド**：プロジェクト固有のデータを捕捉するカスタムフィールド追加  
- **ラベル＆タグ**：カスタマイズ可能なラベルでタスクを整理  
- **時間追跡**：詳細なログでタスクの作業時間を追跡  
- **ファイル添付**：タスクにファイルやドキュメントを添付  
- **コメント＆メンション**：@メンション付きコメントで協力  
- **タスクウォッチャー**：タスクの更新と通知を購読  

### 複数のビュー

- **カンバンボード**：ドラッグ＆ドロップによる視覚的タスク管理  
- **カレンダービュー**：予定スケジュールとタイムラインの可視化を計画中  
- **ガントチャート**：プロジェクトのタイムラインと依存関係の可視化を予定  
- **リストビュー**：従来の表形式タスクリスト  
- **分析ダッシュボード**：プロジェクト指標、バーンダウンチャート、チームベロシティを目指す  

### 自動化＆統合

- **自動化ルール**：カスタム自動化ワークフローを計画中  
- **メール通知**：タスク更新の自動メールアラート  
- **リアルタイム更新**：WebSocket接続によるライブ更新  
- **アクティビティログ**：すべての変更の包括的な監査ログ

- **検索機能**: プロジェクトやタスク全体でのグローバル検索に向けて作業中

### 分析とレポート

- **スプリントバーンダウンチャート**: 予定されたスプリントの進捗追跡
- **チームベロシティ**: 時間経過に伴うチームパフォーマンスの監視予定
- **タスク分布**: タスク割り当てと作業負荷分析に向けて作業中
- **カスタムレポート**: プロジェクト固有のレポート生成予定

## クイックスタート

### 前提条件

- Node.js 22以上とnpm
- PostgreSQL 13以上
- Redis 6以上（バックグラウンドジョブ用）

### インストール

1. **リポジトリをクローンする**

   ```bash
   git clone https://github.com/Taskosaur/Taskosaur.git taskosaur
   cd taskosaur
   ```

2. **依存関係のインストール**

   ```bash
   npm install
   ```

   これにより自動的に以下が行われます：
   - すべてのワークスペース依存関係（フロントエンドおよびバックエンド）のインストール
   - コード品質のためのHusky gitフックの設定

3. **環境設定**

   ルートディレクトリに以下の構成で `.env` ファイルを作成してください：

   ```env
   # Database Configuration
   DATABASE_URL="postgresql://your-db-username:your-db-password@localhost:5432/taskosaur"

   # Authentication
   JWT_SECRET="your-jwt-secret-key-change-this"
   JWT_REFRESH_SECRET="your-refresh-secret-key-change-this-too"
   JWT_EXPIRES_IN="15m"
   JWT_REFRESH_EXPIRES_IN="7d"

   # Redis Configuration (for Bull Queue)
   REDIS_HOST=localhost
   REDIS_PORT=6379
   REDIS_PASSWORD=

   # Email Configuration (for notifications)
   SMTP_HOST=smtp.gmail.com
   SMTP_PORT=587
   SMTP_USER=your-email@gmail.com
   SMTP_PASS=your-app-password
   SMTP_FROM=noreply@taskosaur.com

   # Frontend URL (for email links)
   FRONTEND_URL=http://localhost:3000

   # File Upload
   UPLOAD_DEST="./uploads"
   MAX_FILE_SIZE=10485760

   # Queue Configuration
   MAX_CONCURRENT_JOBS=5
   JOB_RETRY_ATTEMPTS=3

   # Frontend Configuration
   NEXT_PUBLIC_API_BASE_URL=http://localhost:3001/api
   ```

4. **データベースの設定**

   ```bash
   # Run database migrations
   npm run db:migrate

   # Seed the database with core data
   npm run db:seed
   ```

5. **アプリケーションの起動**

   ```bash
   # Development mode (with hot reload for both frontend and backend)
   npm run dev

   # Or start individually
   npm run dev:frontend    # Start frontend only
   npm run dev:backend     # Start backend only
   ```

6. **アプリケーションへのアクセス**
   - フロントエンド: [http://localhost:3000](http://localhost:3000)
   - バックエンドAPI: [http://localhost:3001/api](http://localhost:3001/api)
   - APIドキュメント: [http://localhost:3001/api/docs](http://localhost:3001/api/docs)

## 開発

### 利用可能なコマンド

すべてのコマンドはルートディレクトリから実行されます。環境変数はルートの `.env` ファイルから自動的に読み込まれます。

#### 開発

```bash
# Start both frontend and backend
npm run dev

# Start individually
npm run dev:frontend       # Start frontend dev server
npm run dev:backend        # Start backend dev server with hot reload
```

#### ビルド

```bash
# Build all workspaces
npm run build

# Build individually
npm run build:frontend     # Build frontend for production
npm run build:backend      # Build backend for production
npm run build:dist         # Build complete distribution package
```

#### データベース操作

```bash
npm run db:migrate         # Run database migrations
npm run db:migrate:deploy  # Deploy migrations (production)
npm run db:reset           # Reset database (deletes all data!)
npm run db:seed            # Seed database with core data
npm run db:seed:admin      # Seed database with admin user
npm run db:generate        # Generate Prisma client
npm run db:studio          # Open Prisma Studio
npm run prisma             # Run Prisma CLI commands
```

#### テスト

```bash
npm run test               # Run all tests
npm run test:frontend      # Run frontend tests
npm run test:backend       # Run backend unit tests
npm run test:watch         # Run backend tests in watch mode
npm run test:cov           # Run backend tests with coverage
npm run test:e2e           # Run backend end-to-end tests
```

#### コード品質

```bash
npm run lint               # Lint all workspaces
npm run lint:frontend      # Lint frontend code
npm run lint:backend       # Lint backend code
npm run format             # Format backend code with Prettier
```

#### クリーンアップ

```bash
npm run clean              # Clean all workspaces and root
npm run clean:frontend     # Clean frontend build artifacts
npm run clean:backend      # Clean backend build artifacts
```

### コード品質とGitフック

**Prettier**、**ESLint**、および**Husky**による自動コード整形とリント。

```bash
# Lint all workspaces
npm run lint                # Lint all workspaces

# Lint individually
npm run lint:frontend       # Frontend only
npm run lint:backend        # Backend only

# Format backend code
npm run format              # Format backend code with Prettier
```

**プリコミットフック**: Huskyを使用して、コミットのたびにコードを自動でフォーマット、リント、および検証します。

```bash
# Commits run checks automatically
git commit -m "feat: add feature"

# Bypass checks in emergencies only
git commit -m "fix: urgent hotfix" --no-verify
```

## プロジェクト構成

```
taskosaur/
├── backend/                 # NestJS Backend
│   ├── src/
│   │   ├── modules/        # Feature modules
│   │   ├── config/         # Configuration files
│   │   ├── gateway/        # WebSocket gateway
│   │   └── prisma/         # Database service
│   ├── prisma/             # Database schema and migrations
│   └── uploads/            # File uploads
├── frontend/               # Next.js Frontend
│   ├── src/
│   │   ├── app/           # App Router pages
│   │   ├── components/    # React components
│   │   ├── contexts/      # React contexts
│   │   ├── hooks/         # Custom hooks
│   │   ├── styles/        # CSS styles
│   │   ├── types/         # TypeScript types
│   │   └── utils/         # Utility functions
│   └── public/            # Static assets
└── README.md
```

## 展開

### 本番環境への展開

#### Dockerを使用する（推奨）

```bash
# Clone the repository
git clone https://github.com/Taskosaur/Taskosaur.git taskosaur
cd taskosaur

# Setup environment variables
cp .env.example .env
```

**⚠️ 重要:** `.env` を編集し、安全な本番用の値に更新してください:
- `JWT_SECRET`、`JWT_REFRESH_SECRET`、`ENCRYPTION_KEY` に強力でユニークなシークレットを生成する
- 安全なデータベース認証情報を設定する
- ドメインURLを設定する（`FRONTEND_URL`、`CORS_ORIGIN`、`NEXT_PUBLIC_API_BASE_URL`）
- メール通知のためのSMTP設定を構成する
- **本番環境で例示/デフォルト値を絶対に使用しないでください**

```bash
# Build and run with Docker Compose
docker-compose -f docker-compose.prod.yml up -d
```

#### 手動デプロイ

**本番環境の前提条件：**

- Node.js 22+ LTS
- PostgreSQL 13+
- Redis 6+
- リバースプロキシ（Nginx推奨）

**デプロイ手順：**

```bash
# From root directory
npm install

# Run database migrations
npm run db:migrate:deploy

# Generate Prisma client
npm run db:generate

# Build distribution package
npm run build:dist

# Start the application
# Backend: dist/main.js
# Frontend: dist/public/
# Serve with your preferred Node.js process manager (PM2, systemd, etc.)
```

#### 本番環境用の環境変数

本番用に `.env` ファイルを更新してください：

```env
NODE_ENV=production

# Database Configuration
DATABASE_URL="postgresql://username:password@your-db-host:5432/taskosaur"

# Authentication
JWT_SECRET="your-secure-production-jwt-secret"
JWT_REFRESH_SECRET="your-secure-production-refresh-secret"

# Redis Configuration
REDIS_HOST="your-redis-host"
REDIS_PORT=6379
REDIS_PASSWORD="your-redis-password"

# CORS Configuration
CORS_ORIGIN="https://your-domain.com"

# Frontend Configuration
NEXT_PUBLIC_API_BASE_URL=https://api.your-domain.com/api
FRONTEND_URL=https://your-domain.com
```
#### ホスティングプラットフォーム

**推奨プラットフォーム:**

- **バックエンド**: Railway、Render、DigitalOcean App Platform
- **フロントエンド**: Vercel、Netlify、Railway
- **データベース**: Railway PostgreSQL、Supabase、AWS RDS
- **Redis**: Railway Redis、Redis Cloud、AWS ElastiCache

## APIドキュメント

APIドキュメントはSwaggerを使って自動生成されています:

- 開発環境: http://localhost:3000/api/docs
- 本番環境: `https://api.your-domain.com/api/docs`

## コントリビュート

コントリビューションを歓迎します！詳細は[コントリビューションガイドライン](https://raw.githubusercontent.com/ais1175/Taskosaur/main/CONTRIBUTING.md)をご覧ください。

1. リポジトリをフォークする
2. フィーチャーブランチを作成する (`git checkout -b feature/amazing-feature`)
3. 変更をコミットする (`git commit -m 'feat: add amazing feature'`)
4. ブランチにプッシュする (`git push origin feature/amazing-feature`)
5. プルリクエストを作成する

### 開発ガイドライン

- **コードスタイル**: 既存のコードスタイルに従い、コミット時にリンターが自動実行されます
- **TypeScript**: 厳密なTypeScriptを使い、適切な型注釈を行う
- **テスト**: 新機能やバグ修正に対してテストを書く
- **ドキュメント**: API変更があった場合はドキュメントを更新する
- **コミットメッセージ**: 一般的なコミットメッセージ規約を使う (feat, fix, docsなど)

## ライセンス

本プロジェクトはBusiness Source Licenseの下でライセンスされています。詳細は[LICENSE](https://raw.githubusercontent.com/ais1175/Taskosaur/main/LICENSE.md)ファイルをご覧ください。

## 謝辞


- [NestJS](https://nestjs.com/) - バックエンドフレームワーク
- [Next.js](https://nextjs.org/) - フロントエンドフレームワーク
- [Prisma](https://prisma.io/) - データベースORM
- [Tailwind CSS](https://tailwindcss.com/) - CSSフレームワーク

## サポート

- メール: support@taskosaur.com
- Discord: [コミュニティに参加](https://discord.gg/5cpHUSxePp)
- Issues: [GitHub Issues](https://github.com/Taskosaur/Taskosaur/issues)
- Discussions: [GitHub Discussions](https://github.com/Taskosaur/Taskosaur/discussions)

---

Taskosaurチームによる愛を込めた制作


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-13

---