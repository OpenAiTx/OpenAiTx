# Karpov Gateway

> 一体化 API 网关 + 控制台。Go 后端（Gin + gRPC）+ Next.js 前端（App Router + shadcn/ui），自带凭据池、邮件验证、Linux.do OAuth2 SSO、配额计费、TOTP 二步验证。

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](./LICENSE)
[![Go](https://img.shields.io/badge/Go-1.24+-00ADD8?logo=go)](https://go.dev/)
[![Next.js](https://img.shields.io/badge/Next.js-16-black?logo=next.js)](https://nextjs.org/)

## ✨ Features

- **统一 REST 网关** — 单进程或多 service 模式，gateway → auth/music/pool/quota/billing/worker gRPC 后端可独立部署
- **凭据池 (encrypted)** — KEK + DEK 信封加密，AES-256-GCM with AAD，POOL_KEK_HEX 主密钥派生
- **邮箱注册 + 激活** — SMTP 发码 / 激活链接，双重保险（验证码 + 邮件链接），未配置 SMTP 自动 demote 到 LogSender
- **OAuth2 第三方登录** — Linux.do SSO（PKCE S256 + HMAC 签名 state cookie），登录 / 绑定 / 解绑三态决策，token 加密落库
- **配额 / 计费** — PlanQuotaMiddleware 在 gateway 层兜底，business service 内部按 plan + scope 二次校验
- **TOTP 二步** — `pquerna/otp` + Redis 重放保护
- **审计日志** — 结构化 JSON，按 type 分文件，每天滚动
- **CSRF + Session** — `sid` httpOnly cookie + `X-CSRF-Token` 头双校验
- **shadcn/ui 控制台** — Next.js 16 App Router + Radix + Tailwind v4

## 🏗 仓库结构

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

### 1. 前置要求

| 工具       | 版本    |
| ---------- | ------- |
| Go         | 1.24+   |
| Node.js    | 20.11+  |
| pnpm       | 9+      |
| Docker     | 24+     |
| PostgreSQL | 14+     |
| Redis      | 7+      |

### 2. 启动依赖（Postgres + Redis + pgAdmin）

```bash
cd deploy/compose
cp .env.example .env       # 改强密码！
docker compose up -d
```

### 3. 启动 Gateway 后端

```bash
cd gateway
cp .env.example .env       # 与 deploy/compose/.env 的 PG/Redis 密码保持一致
go mod download
go run ./cmd/qqmusic-gateway
# 默认 :8080 (HTTP) + :9000 (gRPC)
# 首次启动会在 stderr 打印一个 superadmin 账号 + 临时密码
```

### 4. 启动 Web 控制台

```bash
cd web
cp .env.example .env.local
pnpm install
pnpm dev
# http://localhost:3000
```

## 🐳 生产部署 (Docker Compose 单机)

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

注意事项：

- `NEXT_PUBLIC_APP_URL` 改了**必须** `docker compose build --no-cache web`，因为它会被 inline 进 client bundle
- 反向代理（Nginx/Caddy）后必须开 `TRUST_PROXY=true`，否则 X-Forwarded-Proto 不生效
- KEK 一旦改变，旧凭据池 / 旧 OAuth token **全部不可读**

## 🔐 OAuth2 (Linux.do) 接入

1. 去 [https://connect.linux.do](https://connect.linux.do) 申请应用
2. 回调地址填：`https://your-domain/v1/auth/oauth/linuxdo/callback`
3. 把拿到的 client_id / client_secret 写到 `.env`：
   ```
   OAUTH_LINUXDO_ENABLED=true
   OAUTH_LINUXDO_CLIENT_ID=...
   OAUTH_LINUXDO_CLIENT_SECRET=...
   OAUTH_LINUXDO_MIN_TRUST_LEVEL=1
   OAUTH_PUBLIC_BASE=https://your-domain
   OAUTH_FRONTEND_BASE=https://your-domain
   ```
4. 重启 gateway，登录页 / 注册页会自动出现 "Linux.do 一键登录"

## 🧪 测试 / Lint

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

## 📦 关键依赖

**后端**：

- [gin-gonic/gin](https://github.com/gin-gonic/gin) — HTTP 框架
- [grpc-ecosystem](https://github.com/grpc-ecosystem) — gRPC + gateway
- [jackc/pgx](https://github.com/jackc/pgx/v5) — PostgreSQL 驱动
- [redis/go-redis](https://github.com/redis/go-redis) — Redis 客户端
- [golang.org/x/oauth2](https://pkg.go.dev/golang.org/x/oauth2) — OAuth2 / PKCE
- [pquerna/otp](https://github.com/pquerna/otp) — TOTP

**前端**：

- [Next.js 16](https://nextjs.org/) (App Router + Turbopack)
- [shadcn/ui](https://ui.shadcn.com/) + [Radix](https://www.radix-ui.com/)
- [Tailwind CSS v4](https://tailwindcss.com/)
- [next-auth-csrf](https://github.com/edge-runtime/) edge-safe CSRF

## 📜 License

MIT — 见 [LICENSE](./LICENSE)

## 🤝 Contributing

PR / Issue 欢迎。提 PR 前请：

1. `golangci-lint run` + `gofmt -l .` 全绿
2. `go test -race ./...` 全绿
3. Web 改动跑 `pnpm lint && pnpm typecheck`
4. 不要提交 `.env` / `data/.kek` 或任何包含真实密码的文件

## 🔒 Security

发现安全问题请直接联系 maintainer，**不要**开 public issue。

---

Built with ❤️ by [MiChongs](https://github.com/MiChongs)
