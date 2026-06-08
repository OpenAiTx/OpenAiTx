
<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
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

> Integriertes API-Gateway + Konsole. Go-Backend (Gin + gRPC) + Next.js-Frontend (App Router + shadcn/ui), mit integriertem Credential-Pool, E-Mail-Verifizierung, Linux.do OAuth2 SSO, Kontingentabrechnung, TOTP Zwei-Faktor-Authentifizierung.

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](./LICENSE)
[![Go](https://img.shields.io/badge/Go-1.24+-00ADD8?logo=go)](https://go.dev/)
[![Next.js](https://img.shields.io/badge/Next.js-16-black?logo=next.js)](https://nextjs.org/)

## ✨ Funktionen

- **Einheitliches REST-Gateway** — Einzelprozess- oder Multi-Service-Modus, Gateway → Auth/Musik/Pool/Quota/Billing/Worker gRPC-Backend kann unabhängig bereitgestellt werden
- **Credential-Pool (verschlüsselt)** — KEK + DEK Umschlagverschlüsselung, AES-256-GCM mit AAD, POOL_KEK_HEX Master-Schlüsselableitung
- **E-Mail-Registrierung + Aktivierung** — SMTP-Codeversand / Aktivierungslink, doppelte Absicherung (Verifizierungscode + E-Mail-Link), bei nicht konfiguriertem SMTP automatische Herabstufung auf LogSender
- **OAuth2 Drittanbieter-Login** — Linux.do SSO (PKCE S256 + HMAC-signierter State-Cookie), Login / Bindung / Entbindung Drei-Zustands-Entscheidung, Token verschlüsselt gespeichert
- **Kontingent / Abrechnung** — PlanQuotaMiddleware als Fallback im Gateway, interne Zweitprüfung im Business-Service nach Plan + Scope
- **TOTP Zwei-Faktor** — `pquerna/otp` + Redis Wiedergabeschutz
- **Audit-Log** — Strukturiertes JSON, nach Typ in Dateien, täglicher Roll-over
- **CSRF + Session** — `sid` httpOnly Cookie + `X-CSRF-Token` Header Doppelprüfung
- **shadcn/ui Konsole** — Next.js 16 App Router + Radix + Tailwind v4

## 🏗 Repository-Struktur

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

## 🚀 Schnellstart

### 1. Voraussetzungen

| Werkzeug   | Version |
| ---------- | ------- |
| Go         | 1.24+   |
| Node.js    | 20.11+  |
| pnpm       | 9+      |
| Docker     | 24+     |
| PostgreSQL | 14+     |
| Redis      | 7+      |

### 2. Abhängigkeiten starten (Postgres + Redis + pgAdmin)

```bash
cd deploy/compose
cp .env.example .env       # 改强密码！
docker compose up -d
```

### 3. Starten des Gateway-Backends

```bash
cd gateway
cp .env.example .env       # 与 deploy/compose/.env 的 PG/Redis 密码保持一致
go mod download
go run ./cmd/qqmusic-gateway
# 默认 :8080 (HTTP) + :9000 (gRPC)
# 首次启动会在 stderr 打印一个 superadmin 账号 + 临时密码
```

### 4. Starten der Web-Konsole

```bash
cd web
cp .env.example .env.local
pnpm install
pnpm dev
# http://localhost:3000
```

## 🐳 Produktionsbereitstellung (Docker Compose Einzelbetrieb)

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

Hinweise:

- Wenn `NEXT_PUBLIC_APP_URL` geändert wird, **muss** `docker compose build --no-cache web` ausgeführt werden, da dies in das Client-Bundle eingebunden wird.
- Nach Reverse Proxy (Nginx/Caddy) muss `TRUST_PROXY=true` aktiviert werden, sonst funktioniert X-Forwarded-Proto nicht.
- Sobald KEK geändert wird, sind alle alten Credential Pools / alten OAuth Tokens **nicht mehr lesbar**.

## 🔐 OAuth2 (Linux.do) Integration

1. Gehe zu [https://connect.linux.do](https://connect.linux.do) und beantrage eine Anwendung.
2. Trage als Callback-Adresse ein: `https://your-domain/v1/auth/oauth/linuxdo/callback`
3. Schreibe die erhaltenen client_id / client_secret in die `.env`:
   ```
   OAUTH_LINUXDO_ENABLED=true
   OAUTH_LINUXDO_CLIENT_ID=...
   OAUTH_LINUXDO_CLIENT_SECRET=...
   OAUTH_LINUXDO_MIN_TRUST_LEVEL=1
   OAUTH_PUBLIC_BASE=https://your-domain
   OAUTH_FRONTEND_BASE=https://your-domain
   ```
4. Starten Sie das Gateway neu, auf der Login-/Registrierungsseite erscheint automatisch "Linux.do Ein-Klick-Login"

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

## 📦 Wichtige Abhängigkeiten

**Backend**:

- [gin-gonic/gin](https://github.com/gin-gonic/gin) — HTTP-Framework
- [grpc-ecosystem](https://github.com/grpc-ecosystem) — gRPC + Gateway
- [jackc/pgx](https://github.com/jackc/pgx/v5) — PostgreSQL-Treiber
- [redis/go-redis](https://github.com/redis/go-redis) — Redis-Client
- [golang.org/x/oauth2](https://pkg.go.dev/golang.org/x/oauth2) — OAuth2 / PKCE
- [pquerna/otp](https://github.com/pquerna/otp) — TOTP

**Frontend**:

- [Next.js 16](https://nextjs.org/) (App Router + Turbopack)
- [shadcn/ui](https://ui.shadcn.com/) + [Radix](https://www.radix-ui.com/)
- [Tailwind CSS v4](https://tailwindcss.com/)
- [next-auth-csrf](https://github.com/edge-runtime/) Edge-sicheres CSRF

## 📜 Lizenz

MIT — siehe [LICENSE](./LICENSE)

## 🤝 Beitrag leisten

PR / Issue willkommen. Bitte vor dem PR:

1. `golangci-lint run` + `gofmt -l .` alles grün
2. `go test -race ./...` alles grün
3. Bei Web-Änderungen: `pnpm lint && pnpm typecheck` ausführen
4. Keine `.env` / `data/.kek` oder Dateien mit echten Passwörtern einreichen

## 🔒 Sicherheit

Bei Sicherheitsproblemen direkt den Maintainer kontaktieren, **keinen** öffentlichen Issue eröffnen.

---

Erstellt mit ❤️ von [MiChongs](https://github.com/MiChongs)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-08

---