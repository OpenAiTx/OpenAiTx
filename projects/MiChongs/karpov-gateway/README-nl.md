
<div align="right">
  <details>
    <summary >🌐 Taal</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=MiChongs&project=karpov-gateway&lang=en">Engels</a>
        | <a href="https://openaitx.github.io/view.html?user=MiChongs&project=karpov-gateway&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=MiChongs&project=karpov-gateway&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=MiChongs&project=karpov-gateway&lang=ja">Japans</a>
        | <a href="https://openaitx.github.io/view.html?user=MiChongs&project=karpov-gateway&lang=ko">Koreaans</a>
        | <a href="https://openaitx.github.io/view.html?user=MiChongs&project=karpov-gateway&lang=hi">Hindi</a>
        | <a href="https://openaitx.github.io/view.html?user=MiChongs&project=karpov-gateway&lang=th">Thais</a>
        | <a href="https://openaitx.github.io/view.html?user=MiChongs&project=karpov-gateway&lang=fr">Frans</a>
        | <a href="https://openaitx.github.io/view.html?user=MiChongs&project=karpov-gateway&lang=de">Duits</a>
        | <a href="https://openaitx.github.io/view.html?user=MiChongs&project=karpov-gateway&lang=es">Spaans</a>
        | <a href="https://openaitx.github.io/view.html?user=MiChongs&project=karpov-gateway&lang=it">Italiaans</a>
        | <a href="https://openaitx.github.io/view.html?user=MiChongs&project=karpov-gateway&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=MiChongs&project=karpov-gateway&lang=pt">Portugees</a>
        | <a href="https://openaitx.github.io/view.html?user=MiChongs&project=karpov-gateway&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=MiChongs&project=karpov-gateway&lang=pl">Pools</a>
        | <a href="https://openaitx.github.io/view.html?user=MiChongs&project=karpov-gateway&lang=ar">Arabisch</a>
        | <a href="https://openaitx.github.io/view.html?user=MiChongs&project=karpov-gateway&lang=fa">Perzisch</a>
        | <a href="https://openaitx.github.io/view.html?user=MiChongs&project=karpov-gateway&lang=tr">Turks</a>
        | <a href="https://openaitx.github.io/view.html?user=MiChongs&project=karpov-gateway&lang=vi">Vietnamees</a>
        | <a href="https://openaitx.github.io/view.html?user=MiChongs&project=karpov-gateway&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=MiChongs&project=karpov-gateway&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Karpov Gateway

> Alles-in-één API Gateway + Console. Go backend (Gin + gRPC) + Next.js frontend (App Router + shadcn/ui), met inbegrip van credential pool, e-mailverificatie, Linux.do OAuth2 SSO, quotabeheer & facturering, TOTP tweestapsverificatie.

[![Licentie: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](./LICENSE)
[![Go](https://img.shields.io/badge/Go-1.24+-00ADD8?logo=go)](https://go.dev/)
[![Next.js](https://img.shields.io/badge/Next.js-16-black?logo=next.js)](https://nextjs.org/)

## ✨ Functies

- **Uniforme REST Gateway** — Single-process of multi-service modus, gateway → auth/music/pool/quota/billing/worker gRPC backend kan onafhankelijk worden ingezet
- **Credential Pool (encrypted)** — KEK + DEK envelopversleuteling, AES-256-GCM met AAD, POOL_KEK_HEX hoofdkey-afleiding
- **E-mailregistratie + activatie** — SMTP code verzending / activatielink, dubbele beveiliging (verificatiecode + e-maillink), bij geen SMTP-configuratie automatisch demote naar LogSender
- **OAuth2 externe login** — Linux.do SSO (PKCE S256 + HMAC gesigneerde state cookie), login / koppelen / ontkoppelen drie statusbeslissingen, token encryptie en opslag
- **Quota / Billing** — PlanQuotaMiddleware vangt af op gateway-niveau, business service intern dubbele controle op plan + scope
- **TOTP tweestaps** — `pquerna/otp` + Redis replay bescherming
- **Auditlog** — Gestructureerde JSON, per type gescheiden bestanden, dagelijks roterend
- **CSRF + Session** — `sid` httpOnly cookie + `X-CSRF-Token` header dubbele verificatie
- **shadcn/ui Console** — Next.js 16 App Router + Radix + Tailwind v4

## 🏗 Repositorystructuur

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

## 🚀 Snelstart

### 1. Vereisten

| Hulpmiddel | Versie  |
| ---------- | ------- |
| Go         | 1.24+   |
| Node.js    | 20.11+  |
| pnpm       | 9+      |
| Docker     | 24+     |
| PostgreSQL | 14+     |
| Redis      | 7+      |

### 2. Start afhankelijkheden (Postgres + Redis + pgAdmin)

```bash
cd deploy/compose
cp .env.example .env       # 改强密码！
docker compose up -d
```

### 3. Start de Gateway backend

```bash
cd gateway
cp .env.example .env       # 与 deploy/compose/.env 的 PG/Redis 密码保持一致
go mod download
go run ./cmd/qqmusic-gateway
# 默认 :8080 (HTTP) + :9000 (gRPC)
# 首次启动会在 stderr 打印一个 superadmin 账号 + 临时密码
```

### 4. Start de webconsole

```bash
cd web
cp .env.example .env.local
pnpm install
pnpm dev
# http://localhost:3000
```

## 🐳 Productie-implementatie (Docker Compose standalone)

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

Let op:

- Als `NEXT_PUBLIC_APP_URL` wordt gewijzigd, **moet** je `docker compose build --no-cache web` uitvoeren, omdat het inline in de client bundle wordt opgenomen.
- Na een reverse proxy (Nginx/Caddy) moet `TRUST_PROXY=true` worden ingeschakeld, anders werkt X-Forwarded-Proto niet.
- Zodra KEK is gewijzigd, zijn oude credential pools / oude OAuth tokens **volledig onleesbaar**.

## 🔐 OAuth2 (Linux.do) integratie

1. Ga naar [https://connect.linux.do](https://connect.linux.do) om een applicatie aan te vragen.
2. Vul als callback-adres in: `https://your-domain/v1/auth/oauth/linuxdo/callback`
3. Zet de verkregen client_id / client_secret in `.env`:
   ```
   OAUTH_LINUXDO_ENABLED=true
   OAUTH_LINUXDO_CLIENT_ID=...
   OAUTH_LINUXDO_CLIENT_SECRET=...
   OAUTH_LINUXDO_MIN_TRUST_LEVEL=1
   OAUTH_PUBLIC_BASE=https://your-domain
   OAUTH_FRONTEND_BASE=https://your-domain
   ```
4. Herstart de gateway, de loginpagina / registratiepagina toont automatisch "Linux.do One-click login"

## 🧪 Testen / Lint

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

## 📦 Kritieke afhankelijkheden

**Backend**:

- [gin-gonic/gin](https://github.com/gin-gonic/gin) — HTTP-framework
- [grpc-ecosystem](https://github.com/grpc-ecosystem) — gRPC + gateway
- [jackc/pgx](https://github.com/jackc/pgx/v5) — PostgreSQL-driver
- [redis/go-redis](https://github.com/redis/go-redis) — Redis-client
- [golang.org/x/oauth2](https://pkg.go.dev/golang.org/x/oauth2) — OAuth2 / PKCE
- [pquerna/otp](https://github.com/pquerna/otp) — TOTP

**Frontend**:

- [Next.js 16](https://nextjs.org/) (App Router + Turbopack)
- [shadcn/ui](https://ui.shadcn.com/) + [Radix](https://www.radix-ui.com/)
- [Tailwind CSS v4](https://tailwindcss.com/)
- [next-auth-csrf](https://github.com/edge-runtime/) edge-veilige CSRF

## 📜 Licentie

MIT — Zie [LICENSE](./LICENSE)

## 🤝 Bijdragen

PR / Issue welkom. Voordat je een PR indient:

1. `golangci-lint run` + `gofmt -l .` alles groen
2. `go test -race ./...` alles groen
3. Bij webwijzigingen voer `pnpm lint && pnpm typecheck` uit
4. Dien geen `.env` / `data/.kek` of bestanden met echte wachtwoorden in

## 🔒 Beveiliging

Neem bij beveiligingsproblemen direct contact op met de maintainer, **open geen** publieke issue.

---

Gebouwd met ❤️ door [MiChongs](https://github.com/MiChongs)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-08

---