
<div align="right">
  <details>
    <summary >🌐 語言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=MiChongs&project=karpov-gateway&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=MiChongs&project=karpov-gateway&lang=zh-CN">簡體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=MiChongs&project=karpov-gateway&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=MiChongs&project=karpov-gateway&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=MiChongs&project=karpov-gateway&lang=ko">韓國語</a>
        | <a href="https://openaitx.github.io/view.html?user=MiChongs&project=karpov-gateway&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=MiChongs&project=karpov-gateway&lang=th">泰語</a>
        | <a href="https://openaitx.github.io/view.html?user=MiChongs&project=karpov-gateway&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=MiChongs&project=karpov-gateway&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=MiChongs&project=karpov-gateway&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=MiChongs&project=karpov-gateway&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=MiChongs&project=karpov-gateway&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=MiChongs&project=karpov-gateway&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=MiChongs&project=karpov-gateway&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=MiChongs&project=karpov-gateway&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=MiChongs&project=karpov-gateway&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=MiChongs&project=karpov-gateway&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=MiChongs&project=karpov-gateway&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=MiChongs&project=karpov-gateway&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=MiChongs&project=karpov-gateway&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=MiChongs&project=karpov-gateway&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Karpov Gateway

> 一體化 API 閘道 + 控制台。Go 後端（Gin + gRPC）+ Next.js 前端（App Router + shadcn/ui），內建憑證池、郵件驗證、Linux.do OAuth2 SSO、配額計費、TOTP 雙重驗證。

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](./LICENSE)
[![Go](https://img.shields.io/badge/Go-1.24+-00ADD8?logo=go)](https://go.dev/)
[![Next.js](https://img.shields.io/badge/Next.js-16-black?logo=next.js)](https://nextjs.org/)

## ✨ 功能

- **統一 REST 閘道** — 可單一進程或多服務模式運行，gateway → auth/music/pool/quota/billing/worker gRPC 後端可獨立部署
- **憑證池（加密）** — KEK + DEK 信封加密，AES-256-GCM with AAD，POOL_KEK_HEX 主金鑰衍生
- **郵箱註冊 + 啟用** — SMTP 發送驗證碼／啟用連結，雙重保護（驗證碼 + 郵件連結），未設定 SMTP 則自動降級至 LogSender
- **OAuth2 第三方登入** — Linux.do SSO（PKCE S256 + HMAC 簽名 state cookie），登入／綁定／解除綁定三態決策，token 加密入庫
- **配額／計費** — PlanQuotaMiddleware 在 gateway 層作為兜底，業務服務內部依 plan + scope 進行二次校驗
- **TOTP 雙重驗證** — `pquerna/otp` + Redis 重放保護
- **稽核日誌** — 結構化 JSON，依 type 分檔，每日滾動
- **CSRF + Session** — `sid` httpOnly cookie + `X-CSRF-Token` 標頭雙重驗證
- **shadcn/ui 控制台** — Next.js 16 App Router + Radix + Tailwind v4

## 🏗 倉庫結構

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

## 🚀 快速開始

### 1. 前置要求

| 工具       | 版本    |
| ---------- | ------- |
| Go         | 1.24+   |
| Node.js    | 20.11+  |
| pnpm       | 9+      |
| Docker     | 24+     |
| PostgreSQL | 14+     |
| Redis      | 7+      |

### 2. 啟動依賴（Postgres + Redis + pgAdmin）

```bash
cd deploy/compose
cp .env.example .env       # 改强密码！
docker compose up -d
```

### 3. 啟動 Gateway 後端

```bash
cd gateway
cp .env.example .env       # 与 deploy/compose/.env 的 PG/Redis 密码保持一致
go mod download
go run ./cmd/qqmusic-gateway
# 默认 :8080 (HTTP) + :9000 (gRPC)
# 首次启动会在 stderr 打印一个 superadmin 账号 + 临时密码
```

### 4. 啟動 Web 控制台

```bash
cd web
cp .env.example .env.local
pnpm install
pnpm dev
# http://localhost:3000
```

## 🐳 生產部署（Docker Compose 單機）

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

- 更改 `NEXT_PUBLIC_APP_URL` 後**必須**執行 `docker compose build --no-cache web`，因為它會被 inline 到 client bundle 裡
- 反向代理（Nginx/Caddy）後必須開啟 `TRUST_PROXY=true`，否則 X-Forwarded-Proto 不會生效
- KEK 一旦改變，舊憑據池 / 舊 OAuth token **全部無法讀取**

## 🔐 OAuth2 (Linux.do) 接入

1. 前往 [https://connect.linux.do](https://connect.linux.do) 申請應用
2. 回調地址填寫：`https://your-domain/v1/auth/oauth/linuxdo/callback`
3. 將取得的 client_id / client_secret 寫入 `.env`：
   ```
   OAUTH_LINUXDO_ENABLED=true
   OAUTH_LINUXDO_CLIENT_ID=...
   OAUTH_LINUXDO_CLIENT_SECRET=...
   OAUTH_LINUXDO_MIN_TRUST_LEVEL=1
   OAUTH_PUBLIC_BASE=https://your-domain
   OAUTH_FRONTEND_BASE=https://your-domain
   ```
4. 重新啟動 gateway，登入頁 / 註冊頁會自動出現「Linux.do 一鍵登入」

## 🧪 測試 / Lint

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

## 📦 關鍵依賴

**後端**：

- [gin-gonic/gin](https://github.com/gin-gonic/gin) — HTTP 框架
- [grpc-ecosystem](https://github.com/grpc-ecosystem) — gRPC + gateway
- [jackc/pgx](https://github.com/jackc/pgx/v5) — PostgreSQL 驅動
- [redis/go-redis](https://github.com/redis/go-redis) — Redis 客戶端
- [golang.org/x/oauth2](https://pkg.go.dev/golang.org/x/oauth2) — OAuth2 / PKCE
- [pquerna/otp](https://github.com/pquerna/otp) — TOTP

**前端**：

- [Next.js 16](https://nextjs.org/)（App Router + Turbopack）
- [shadcn/ui](https://ui.shadcn.com/) + [Radix](https://www.radix-ui.com/)
- [Tailwind CSS v4](https://tailwindcss.com/)
- [next-auth-csrf](https://github.com/edge-runtime/) edge-safe CSRF

## 📜 授權條款

MIT — 見 [LICENSE](./LICENSE)

## 🤝 貢獻指南

歡迎 PR / Issue。提交 PR 前請：

1. `golangci-lint run` + `gofmt -l .` 全綠
2. `go test -race ./...` 全綠
3. Web 更動請跑 `pnpm lint && pnpm typecheck`
4. 請勿提交 `.env` / `data/.kek` 或任何包含真實密碼的檔案

## 🔒 安全性

若發現安全問題，請直接聯繫 maintainer，**不要**開 public issue。

---

Built with ❤️ by [MiChongs](https://github.com/MiChongs)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-08

---