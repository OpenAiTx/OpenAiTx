# Karpov Gateway

> Integrated API Gateway + Console. Go backend (Gin + gRPC) + Next.js frontend (App Router + shadcn/ui), comes with credential pool, email verification, Linux.do OAuth2 SSO, quota billing, TOTP two-factor authentication.

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](./LICENSE)
[![Go](https://img.shields.io/badge/Go-1.24+-00ADD8?logo=go)](https://go.dev/)
[![Next.js](https://img.shields.io/badge/Next.js-16-black?logo=next.js)](https://nextjs.org/)

## ✨ Features

- **Unified REST Gateway** — Single process or multi-service mode, gateway → auth/music/pool/quota/billing/worker gRPC backends can be deployed independently
- **Credential Pool (encrypted)** — KEK + DEK envelope encryption, AES-256-GCM with AAD, POOL_KEK_HEX master key derivation
- **Email Registration + Activation** — SMTP code sending / activation links, double insurance (verification code + email link), auto demote to LogSender if SMTP not configured
- **OAuth2 Third-Party Login** — Linux.do SSO (PKCE S256 + HMAC signed state cookie), login / bind / unbind tri-state decision, token encrypted storage
- **Quota / Billing** — PlanQuotaMiddleware fallback at gateway layer, business service internal secondary validation by plan + scope
- **TOTP Two-Factor** — `pquerna/otp` + Redis replay protection
- **Audit Logs** — Structured JSON, split by type, rotated daily
- **CSRF + Session** — `sid` httpOnly cookie + `X-CSRF-Token` header double verification
- **shadcn/ui Console** — Next.js 16 App Router + Radix + Tailwind v4

## 🏗 Repository Structure

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

## 🚀 Quick Start

### 1. Prerequisites

| Tool       | Version |
| ---------- | ------- |
| Go         | 1.24+   |
| Node.js    | 20.11+  |
| pnpm       | 9+      |
| Docker     | 24+     |
| PostgreSQL | 14+     |
| Redis      | 7+      |

### 2. Start Dependencies (Postgres + Redis + pgAdmin)

```bash
cd deploy/compose
cp .env.example .env       # 改强密码！
docker compose up -d
```

### 3. Starting the Gateway Backend

```bash
cd gateway
cp .env.example .env       # 与 deploy/compose/.env 的 PG/Redis 密码保持一致
go mod download
go run ./cmd/qqmusic-gateway
# 默认 :8080 (HTTP) + :9000 (gRPC)
# 首次启动会在 stderr 打印一个 superadmin 账号 + 临时密码
```

### 4. Start the Web Console

```bash
cd web
cp .env.example .env.local
pnpm install
pnpm dev
# http://localhost:3000
```

## 🐳 Production Deployment (Docker Compose Standalone)

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

Notes:

- If `NEXT_PUBLIC_APP_URL` is changed, you **must** run `docker compose build --no-cache web` because it will be inlined into the client bundle.
- When using a reverse proxy (Nginx/Caddy), `TRUST_PROXY=true` must be enabled, otherwise X-Forwarded-Proto will not work.
- Once the KEK changes, all old credential pools / old OAuth tokens become **unreadable**.

## 🔐 OAuth2 (Linux.do) Integration

1. Go to [https://connect.linux.do](https://connect.linux.do) to apply for an application.
2. Set the callback URL to: `https://your-domain/v1/auth/oauth/linuxdo/callback`
3. Write the obtained client_id / client_secret into `.env`:
   ```
   OAUTH_LINUXDO_ENABLED=true
   OAUTH_LINUXDO_CLIENT_ID=...
   OAUTH_LINUXDO_CLIENT_SECRET=...
   OAUTH_LINUXDO_MIN_TRUST_LEVEL=1
   OAUTH_PUBLIC_BASE=https://your-domain
   OAUTH_FRONTEND_BASE=https://your-domain
   ```
4. Restart the gateway, and the login page / registration page will automatically display "Linux.do One-Click Login"

## 🧪 Test / Lint

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

## 📦 Key Dependencies

**Backend**：

- [gin-gonic/gin](https://github.com/gin-gonic/gin) — HTTP framework
- [grpc-ecosystem](https://github.com/grpc-ecosystem) — gRPC + gateway
- [jackc/pgx](https://github.com/jackc/pgx/v5) — PostgreSQL driver
- [redis/go-redis](https://github.com/redis/go-redis) — Redis client
- [golang.org/x/oauth2](https://pkg.go.dev/golang.org/x/oauth2) — OAuth2 / PKCE
- [pquerna/otp](https://github.com/pquerna/otp) — TOTP

**Frontend**：

- [Next.js 16](https://nextjs.org/) (App Router + Turbopack)
- [shadcn/ui](https://ui.shadcn.com/) + [Radix](https://www.radix-ui.com/)
- [Tailwind CSS v4](https://tailwindcss.com/)
- [next-auth-csrf](https://github.com/edge-runtime/) edge-safe CSRF

## 📜 License

MIT — see [LICENSE](./LICENSE)

## 🤝 Contributing

PR / Issue welcome. Before submitting PR, please:

1. `golangci-lint run` + `gofmt -l .` all green
2. `go test -race ./...` all green
3. For web changes run `pnpm lint && pnpm typecheck`
4. Do not commit `.env` / `data/.kek` or any files containing real passwords

## 🔒 Security

If you find security issues, please contact the maintainer directly, **do not** open a public issue.

---

Built with ❤️ by [MiChongs](https://github.com/MiChongs)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-04

---