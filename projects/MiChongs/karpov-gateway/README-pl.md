
<div align="right">
  <details>
    <summary >🌐 Język</summary>
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

> Zintegrowana brama API + konsola. Backend w Go (Gin + gRPC) + frontend Next.js (App Router + shadcn/ui), wbudowany pul kredencyjny, weryfikacja mailowa, Linux.do OAuth2 SSO, rozliczanie limitów, dwuskładnikowe uwierzytelnianie TOTP.

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](./LICENSE)
[![Go](https://img.shields.io/badge/Go-1.24+-00ADD8?logo=go)](https://go.dev/)
[![Next.js](https://img.shields.io/badge/Next.js-16-black?logo=next.js)](https://nextjs.org/)

## ✨ Funkcje

- **Ujednolicony REST Gateway** — Tryb pojedynczego procesu lub wielu serwisów, gateway → auth/music/pool/quota/billing/worker gRPC backendy mogą być wdrażane niezależnie
- **Pula poświadczeń (zaszyfrowana)** — Szyfrowanie kopertowe KEK + DEK, AES-256-GCM z AAD, główny klucz POOL_KEK_HEX pochodny
- **Rejestracja e-mail + aktywacja** — SMTP wysyłanie kodów / linków aktywacyjnych, podwójne zabezpieczenie (kod weryfikacyjny + link mailowy), brak konfiguracji SMTP automatycznie przełącza do LogSender
- **Logowanie OAuth2 przez osoby trzecie** — Linux.do SSO (PKCE S256 + podpis HMAC dla state cookie), trzy tryby (logowanie / powiązanie / odłączenie), tokeny szyfrowane i zapisywane
- **Limity / rozliczenia** — PlanQuotaMiddleware jako ochrona na poziomie gateway, wewnątrz usług biznesowych dodatkowa weryfikacja planu + zakresu
- **TOTP dwuskładnikowe** — `pquerna/otp` + ochrona przed powtórzeniami w Redis
- **Dzienniki audytu** — Strukturalny JSON, pliki według typu, rotacja dzienna
- **CSRF + Sesja** — Podwójna weryfikacja: httpOnly cookie `sid` + nagłówek `X-CSRF-Token`
- **Konsola shadcn/ui** — Next.js 16 App Router + Radix + Tailwind v4

## 🏗 Struktura repozytorium

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

## 🚀 Szybki start

### 1. Wymagania wstępne

| Narzędzie  | Wersja  |
| ---------- | ------- |
| Go         | 1.24+   |
| Node.js    | 20.11+  |
| pnpm       | 9+      |
| Docker     | 24+     |
| PostgreSQL | 14+     |
| Redis      | 7+      |

### 2. Uruchomienie zależności (Postgres + Redis + pgAdmin)

```bash
cd deploy/compose
cp .env.example .env       # 改强密码！
docker compose up -d
```

### 3. Uruchomienie backendu Gateway

```bash
cd gateway
cp .env.example .env       # 与 deploy/compose/.env 的 PG/Redis 密码保持一致
go mod download
go run ./cmd/qqmusic-gateway
# 默认 :8080 (HTTP) + :9000 (gRPC)
# 首次启动会在 stderr 打印一个 superadmin 账号 + 临时密码
```

### 4. Uruchomienie konsoli Web

```bash
cd web
cp .env.example .env.local
pnpm install
pnpm dev
# http://localhost:3000
```

## 🐳 Wdrożenie produkcyjne (Docker Compose - pojedyncza maszyna)

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

Uwagi:

- Po zmianie `NEXT_PUBLIC_APP_URL` **koniecznie** wykonać `docker compose build --no-cache web`, ponieważ zostanie ona osadzona bezpośrednio w paczce klienta
- Po zastosowaniu odwrotnego proxy (Nginx/Caddy) należy ustawić `TRUST_PROXY=true`, w przeciwnym razie X-Forwarded-Proto nie zadziała
- Po zmianie KEK wszystkie stare pule poświadczeń / stare tokeny OAuth **będą całkowicie nieczytelne**

## 🔐 Integracja OAuth2 (Linux.do)

1. Przejdź na [https://connect.linux.do](https://connect.linux.do), aby zarejestrować aplikację
2. Jako adres zwrotny wpisz: `https://your-domain/v1/auth/oauth/linuxdo/callback`
3. Uzyskane wartości client_id / client_secret wpisz do pliku `.env`:
   ```
   OAUTH_LINUXDO_ENABLED=true
   OAUTH_LINUXDO_CLIENT_ID=...
   OAUTH_LINUXDO_CLIENT_SECRET=...
   OAUTH_LINUXDO_MIN_TRUST_LEVEL=1
   OAUTH_PUBLIC_BASE=https://your-domain
   OAUTH_FRONTEND_BASE=https://your-domain
   ```
4. Uruchom ponownie gateway, na stronie logowania / rejestracji automatycznie pojawi się "Linux.do Jedno kliknięcie logowania"

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

## 📦 Kluczowe zależności

**Backend**:

- [gin-gonic/gin](https://github.com/gin-gonic/gin) — framework HTTP
- [grpc-ecosystem](https://github.com/grpc-ecosystem) — gRPC + gateway
- [jackc/pgx](https://github.com/jackc/pgx/v5) — sterownik PostgreSQL
- [redis/go-redis](https://github.com/redis/go-redis) — klient Redis
- [golang.org/x/oauth2](https://pkg.go.dev/golang.org/x/oauth2) — OAuth2 / PKCE
- [pquerna/otp](https://github.com/pquerna/otp) — TOTP

**Frontend**:

- [Next.js 16](https://nextjs.org/) (App Router + Turbopack)
- [shadcn/ui](https://ui.shadcn.com/) + [Radix](https://www.radix-ui.com/)
- [Tailwind CSS v4](https://tailwindcss.com/)
- [next-auth-csrf](https://github.com/edge-runtime/) edge-safe CSRF

## 📜 Licencja

MIT — zobacz [LICENSE](./LICENSE)

## 🤝 Wkład

PR / Issue mile widziane. Przed zgłoszeniem PR wykonaj:

1. `golangci-lint run` + `gofmt -l .` wszystko na zielono
2. `go test -race ./...` wszystko na zielono
3. Zmiany w Web uruchom `pnpm lint && pnpm typecheck`
4. Nie przesyłaj plików `.env` / `data/.kek` ani żadnych zawierających prawdziwe hasła

## 🔒 Bezpieczeństwo

W przypadku wykrycia problemów bezpieczeństwa skontaktuj się bezpośrednio z maintainerem, **nie** zakładaj publicznego issue.

---

Stworzone z ❤️ przez [MiChongs](https://github.com/MiChongs)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-08

---