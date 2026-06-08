
<div align="right">
  <details>
    <summary >🌐 Lingua</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=MiChongs&project=karpov-gateway&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=MiChongs&project=karpov-gateway&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=MiChongs&project=karpov-gateway&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=MiChongs&project=karpov-gateway&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=MiChongs&project=karpov-gateway&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=MiChongs&project=karpov-gateway&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=MiChongs&project=karpov-gateway&lang=th">ไทย</a>
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

> Gateway API integrato + Console di controllo. Backend Go (Gin + gRPC) + Frontend Next.js (App Router + shadcn/ui), include pool delle credenziali, verifica email, OAuth2 SSO Linux.do, conteggio delle quote, verifica a due fattori TOTP.

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](./LICENSE)
[![Go](https://img.shields.io/badge/Go-1.24+-00ADD8?logo=go)](https://go.dev/)
[![Next.js](https://img.shields.io/badge/Next.js-16-black?logo=next.js)](https://nextjs.org/)

## ✨ Caratteristiche

- **Gateway REST unificato** — modalità a processo singolo o multi-service, gateway → auth/music/pool/quota/billing/worker backend gRPC possono essere distribuiti indipendentemente
- **Pool delle credenziali (encrypted)** — KEK + DEK crittografia a busta, AES-256-GCM con AAD, chiave principale POOL_KEK_HEX derivata
- **Registrazione email + attivazione** — invio codice SMTP / link di attivazione, doppia sicurezza (codice + link email), se SMTP non configurato demote automatico a LogSender
- **Login OAuth2 di terze parti** — Linux.do SSO (PKCE S256 + firma HMAC state cookie), decisione a tre stati login / associazione / disassociazione, token criptato e salvato
- **Quota / Fatturazione** — PlanQuotaMiddleware a livello gateway, verifica secondaria interna ai servizi business secondo plan + scope
- **TOTP a due fattori** — `pquerna/otp` + protezione replay Redis
- **Log di audit** — JSON strutturato, file separati per tipo, rotazione giornaliera
- **CSRF + Sessione** — cookie httpOnly `sid` + doppia verifica header `X-CSRF-Token`
- **Console shadcn/ui** — Next.js 16 App Router + Radix + Tailwind v4

## 🏗 Struttura del repository

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

## 🚀 Avvio Rapido

### 1. Requisiti Preliminari

| Strumento  | Versione |
| ---------- | -------- |
| Go         | 1.24+    |
| Node.js    | 20.11+   |
| pnpm       | 9+       |
| Docker     | 24+      |
| PostgreSQL | 14+      |
| Redis      | 7+       |

### 2. Avvio delle dipendenze (Postgres + Redis + pgAdmin)

```bash
cd deploy/compose
cp .env.example .env       # 改强密码！
docker compose up -d
```

### 3. Avvio del backend Gateway

```bash
cd gateway
cp .env.example .env       # 与 deploy/compose/.env 的 PG/Redis 密码保持一致
go mod download
go run ./cmd/qqmusic-gateway
# 默认 :8080 (HTTP) + :9000 (gRPC)
# 首次启动会在 stderr 打印一个 superadmin 账号 + 临时密码
```

### 4. Avviare la console Web

```bash
cd web
cp .env.example .env.local
pnpm install
pnpm dev
# http://localhost:3000
```

## 🐳 Distribuzione di produzione (Docker Compose singolo nodo)

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

Note:

- Quando si modifica `NEXT_PUBLIC_APP_URL` **è necessario** eseguire `docker compose build --no-cache web`, perché verrà inserito direttamente nel client bundle
- Dopo il reverse proxy (Nginx/Caddy) è indispensabile abilitare `TRUST_PROXY=true`, altrimenti X-Forwarded-Proto non avrà effetto
- Una volta modificato KEK, tutte le vecchie pool di credenziali / vecchi token OAuth **diventano illeggibili**

## 🔐 Integrazione OAuth2 (Linux.do)

1. Vai su [https://connect.linux.do](https://connect.linux.do) per richiedere un'applicazione
2. Inserisci come indirizzo di callback: `https://your-domain/v1/auth/oauth/linuxdo/callback`
3. Scrivi il client_id / client_secret ottenuti nel file `.env`:
   ```
   OAUTH_LINUXDO_ENABLED=true
   OAUTH_LINUXDO_CLIENT_ID=...
   OAUTH_LINUXDO_CLIENT_SECRET=...
   OAUTH_LINUXDO_MIN_TRUST_LEVEL=1
   OAUTH_PUBLIC_BASE=https://your-domain
   OAUTH_FRONTEND_BASE=https://your-domain
   ```
4. Riavviare il gateway, la pagina di login / registrazione mostrerà automaticamente "Linux.do Accesso One-Click"

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

## 📦 Dipendenze Chiave

**Backend**:

- [gin-gonic/gin](https://github.com/gin-gonic/gin) — Framework HTTP
- [grpc-ecosystem](https://github.com/grpc-ecosystem) — gRPC + gateway
- [jackc/pgx](https://github.com/jackc/pgx/v5) — Driver PostgreSQL
- [redis/go-redis](https://github.com/redis/go-redis) — Client Redis
- [golang.org/x/oauth2](https://pkg.go.dev/golang.org/x/oauth2) — OAuth2 / PKCE
- [pquerna/otp](https://github.com/pquerna/otp) — TOTP

**Frontend**:

- [Next.js 16](https://nextjs.org/) (App Router + Turbopack)
- [shadcn/ui](https://ui.shadcn.com/) + [Radix](https://www.radix-ui.com/)
- [Tailwind CSS v4](https://tailwindcss.com/)
- [next-auth-csrf](https://github.com/edge-runtime/) CSRF edge-safe

## 📜 Licenza

MIT — Vedi [LICENSE](./LICENSE)

## 🤝 Contribuire

PR / Issue benvenuti. Prima di inviare una PR, per favore:

1. `golangci-lint run` + `gofmt -l .` tutto verde
2. `go test -race ./...` tutto verde
3. Per modifiche web eseguire `pnpm lint && pnpm typecheck`
4. Non inviare file `.env` / `data/.kek` o qualsiasi file con password reali

## 🔒 Sicurezza

Se trovi problemi di sicurezza contatta direttamente il maintainer, **NON** aprire issue pubbliche.

---

Creato con ❤️ da [MiChongs](https://github.com/MiChongs)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-08

---