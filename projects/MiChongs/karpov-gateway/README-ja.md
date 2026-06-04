# Karpov Gateway

> 統合 API ゲートウェイ + コンソール。Go バックエンド（Gin + gRPC）+ Next.js フロントエンド（App Router + shadcn/ui）、資格情報プール、メール認証、Linux.do OAuth2 SSO、クォータ課金、TOTP 二段階認証を内蔵。

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](./LICENSE)
[![Go](https://img.shields.io/badge/Go-1.24+-00ADD8?logo=go)](https://go.dev/)
[![Next.js](https://img.shields.io/badge/Next.js-16-black?logo=next.js)](https://nextjs.org/)

## ✨ 機能

- **統一 REST ゲートウェイ** — 単一プロセスまたはマルチサービスモード、gateway → auth/music/pool/quota/billing/worker gRPC バックエンドは独立デプロイ可能
- **資格情報プール (暗号化済み)** — KEK + DEK エンベロープ暗号化、AES-256-GCM with AAD、POOL_KEK_HEX マスターキー派生
- **メール登録 + 有効化** — SMTP コード送信 / 有効化リンク、二重保険（認証コード + メールリンク）、SMTP 未設定時は自動的に LogSender に降格
- **OAuth2 サードパーティログイン** — Linux.do SSO（PKCE S256 + HMAC 署名 state cookie）、ログイン / バインド / バインド解除の三状態判定、トークン暗号化保存
- **クォータ / 課金** — PlanQuotaMiddleware が gateway 層でカバー、ビジネスサービス内で plan + scope による二重検証
- **TOTP 二段階認証** — `pquerna/otp` + Redis リプレイ防止
- **監査ログ** — 構造化 JSON、タイプ別ファイル、日次ローテーション
- **CSRF + セッション** — `sid` httpOnly cookie + `X-CSRF-Token` ヘッダーによる二重検証
- **shadcn/ui コンソール** — Next.js 16 App Router + Radix + Tailwind v4

## 🏗 リポジトリ構造

```
karpov-gateway/
├── gateway/             # Go 后端 (Gin + gRPC)
│   ├── cmd/             # 各 service 入口 (gateway/auth/music/pool/...)
│   ├── internal/        # 业务实现 (private)
│   ├── api/             # protobuf 定义
│   ├── migrations/      # PostgreSQL schema
│   ├── go.mod           # Go 模块 (go 1.24+)
│   └── Dockerfile
├── web/                 # Next.js 16 前端控制台
│   ├── src/             # App Router pages + components
│   ├── middleware.ts    # CSRF / session / CSP nonce
│   ├── package.json     # pnpm workspace
│   └── Dockerfile
├── deploy/
│   ├── compose/         # 本地开发 (PG + Redis + pgAdmin)
│   └── compose-prod/    # 生产单机 (gateway + web + PG + Redis 全栈)
└── .github/workflows/   # GitHub Actions CI (lint / test / build / govulncheck / gosec)
```

## 🚀 クイックスタート

### 1. 前提条件

| ツール       | バージョン |
| ------------ | ---------- |
| Go           | 1.24以上   |
| Node.js      | 20.11以上  |
| pnpm         | 9以上     |
| Docker       | 24以上    |
| PostgreSQL   | 14以上    |
| Redis        | 7以上     |

### 2. 起動依存関係（Postgres + Redis + pgAdmin）

```bash
cd deploy/compose
cp .env.example .env       # 改强密码！
docker compose up -d
```

### 3. Gateway バックエンドの起動

```bash
cd gateway
cp .env.example .env       # 与 deploy/compose/.env 的 PG/Redis 密码保持一致
go mod download
go run ./cmd/qqmusic-gateway
# 默认 :8080 (HTTP) + :9000 (gRPC)
# 首次启动会在 stderr 打印一个 superadmin 账号 + 临时密码
```

### 4. Webコンソールの起動

```bash
cd web
cp .env.example .env.local
pnpm install
pnpm dev
# http://localhost:3000
```

## 🐳 本番環境へのデプロイ (Docker Compose 単一ホスト)

```bash
cd deploy/compose-prod
cp .env.example .env
# 编辑 .env：填入真域名 / 强密码 / SMTP 凭据 / OAuth client
nano .env

# 生成 KEK
openssl rand -hex 32     # → 写到 POOL_KEK_HEX=

docker compose up -d --build
docker compose logs -f gateway
```

注意事項：

- `NEXT_PUBLIC_APP_URL` を変更したら**必ず** `docker compose build --no-cache web` を実行してください。これはクライアントバンドルにインラインで組み込まれるためです。
- リバースプロキシ（Nginx/Caddy）を使用する場合は必ず `TRUST_PROXY=true` を設定してください。そうしないと X-Forwarded-Proto が機能しません。
- KEK が変更されると、古いクレデンシャルストア / 古い OAuth トークンは**すべて読み取れなくなります**

## 🔐 OAuth2 (Linux.do) 接続

1. [https://connect.linux.do](https://connect.linux.do) でアプリを申請してください
2. コールバックURLに以下を入力してください：`https://your-domain/v1/auth/oauth/linuxdo/callback`
3. 取得した client_id / client_secret を `.env` に記入してください：
   ```
   OAUTH_LINUXDO_ENABLED=true
   OAUTH_LINUXDO_CLIENT_ID=...
   OAUTH_LINUXDO_CLIENT_SECRET=...
   OAUTH_LINUXDO_MIN_TRUST_LEVEL=1
   OAUTH_PUBLIC_BASE=https://your-domain
   OAUTH_FRONTEND_BASE=https://your-domain
   ```
4. Restart the gateway, and the login/register page will automatically show "Linux.do One-Click Login"

## 🧪 テスト / Lint

```bash
# Go
cd gateway
go vet ./...
go test -race ./...
golangci-lint run --timeout=5m

# Web
cd web
pnpm lint
pnpm typecheck
```
## 📦 重要な依存関係

**バックエンド**：

- [gin-gonic/gin](https://github.com/gin-gonic/gin) — HTTP フレームワーク
- [grpc-ecosystem](https://github.com/grpc-ecosystem) — gRPC + gateway
- [jackc/pgx](https://github.com/jackc/pgx/v5) — PostgreSQL ドライバー
- [redis/go-redis](https://github.com/redis/go-redis) — Redis クライアント
- [golang.org/x/oauth2](https://pkg.go.dev/golang.org/x/oauth2) — OAuth2 / PKCE
- [pquerna/otp](https://github.com/pquerna/otp) — TOTP

**フロントエンド**：

- [Next.js 16](https://nextjs.org/) (App Router + Turbopack)
- [shadcn/ui](https://ui.shadcn.com/) + [Radix](https://www.radix-ui.com/)
- [Tailwind CSS v4](https://tailwindcss.com/)
- [next-auth-csrf](https://github.com/edge-runtime/) エッジセーフ CSRF

## 📜 ライセンス

MIT — [LICENSE](./LICENSE) を参照

## 🤝 貢献

PR / Issue 大歓迎。PR 提出前に：

1. `golangci-lint run` + `gofmt -l .` が全て成功
2. `go test -race ./...` が全て成功
3. Web の変更は `pnpm lint && pnpm typecheck` を実行
4. `.env` / `data/.kek` または実際のパスワードを含むファイルはコミットしないこと

## 🔒 セキュリティ

セキュリティ問題を発見した場合は直接 maintainer に連絡してください。**公開 issue は立てないでください**。

---

Built with ❤️ by [MiChongs](https://github.com/MiChongs)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-04

---