
<div align="right">
  <details>
    <summary >🌐 ভাষা</summary>
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

# কাৰ্পভ গেটৱে

> একত্ৰিত API গেটৱে + নিয়ন্ত্ৰণ কনচোল। Go বেকএণ্ড (Gin + gRPC) + Next.js ফ্ৰণ্টএণ্ড (App Router + shadcn/ui), নিজা প্ৰমাণীকৰণ পুল, ই-মেইল ভেৰিফিকেশ্যন, Linux.do OAuth2 SSO, কোটাৰ হিচাপ, TOTP দুবাৰীয়া ভেৰিফিকেশ্যনসহ।

[![অনুজ্ঞাপত্ৰ: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](./LICENSE)
[![Go](https://img.shields.io/badge/Go-1.24+-00ADD8?logo=go)](https://go.dev/)
[![Next.js](https://img.shields.io/badge/Next.js-16-black?logo=next.js)](https://nextjs.org/)

## ✨ বৈশিষ্ট্যবোৰ

- **একীভূত REST গেটৱে** — একক প্ৰক্ৰিয়া বা বহু service ৰূপত, gateway → auth/music/pool/quota/billing/worker gRPC পিছৰ অংশ স্বতন্ত্ৰভাৱে মোতায়েন কৰিব পাৰি
- **প্ৰমাণপত্ৰ সংৰক্ষণ (গোপনীয়)** — KEK + DEK খাম এনক্ৰিপচন, AES-256-GCM with AAD, POOL_KEK_HEX মুখ্য চাবি ডেৰিভেশন
- **ই-মেইল ৰেজিষ্ট্ৰেশ্বন + সক্ৰিয়কৰণ** — SMTP ক'ড পঠিয়াব/সক্ৰিয় লিংক, দ্বৈত সুৰক্ষা (ভেৰিফিকেশ্বন ক'ড + ই-মেইল লিংক), SMTP সংৰূপ নোহোৱিলে স্বয়ংক্ৰিয়ভাৱে LogSender লৈ নামি যায়
- **OAuth2 তৃতীয় পক্ষ লগইন** — Linux.do SSO (PKCE S256 + HMAC স্বাক্ষৰিত state কুকি), লগইন / সংলগ্ন / বিযুক্ত তিনিটা অৱস্থাৰ সিদ্ধান্ত, ট'কেন এনক্ৰিপ্ট কৰি সংৰক্ষণ
- **কোট/বিলিং** — PlanQuotaMiddleware গেটৱে স্তৰত সংৰক্ষিত, business service ভিতৰত plan + scope অনুৰূপ দ্বিতীয়বাৰ পৰীক্ষা
- **TOTP দুচৰণ** — `pquerna/otp` + Redis পুনৰাবৃত্তি সুৰক্ষা
- **অডিট লগ** — গঠনমূলক JSON, type অনুসৰি পৃথক ফাইল, প্ৰতিদিনে ঘূৰে
- **CSRF + ছেছন** — `sid` httpOnly কুকি + `X-CSRF-Token` শিৰোনাম দ্বৈত পৰীক্ষা
- **shadcn/ui কণ্ট্ৰ'ল পেনেল** — Next.js 16 App Router + Radix + Tailwind v4

## 🏗 ৰেপ’জিট'ৰী গঠন

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

## 🚀 দ্ৰুত আৰম্ভণি

### 1. পূৰ্বৰ প্ৰয়োজনীয়তা

| সঁজুলি      | সংস্কৰণ   |
| ------------ | ---------- |
| Go           | 1.24+      |
| Node.js      | 20.11+     |
| pnpm         | 9+         |
| Docker       | 24+        |
| PostgreSQL   | 14+        |
| Redis        | 7+         |

### 2. নিৰ্ভৰতা আৰম্ভ কৰা (Postgres + Redis + pgAdmin)

```bash
cd deploy/compose
cp .env.example .env       # 改强密码！
docker compose up -d
```

### ৩. Gateway পিছৰ অংশ আৰম্ভ কৰক

```bash
cd gateway
cp .env.example .env       # 与 deploy/compose/.env 的 PG/Redis 密码保持一致
go mod download
go run ./cmd/qqmusic-gateway
# 默认 :8080 (HTTP) + :9000 (gRPC)
# 首次启动会在 stderr 打印一个 superadmin 账号 + 临时密码
```

### 4. ৱেব কন্ট্ৰোল পেনেল আৰম্ভ কৰক

```bash
cd web
cp .env.example .env.local
pnpm install
pnpm dev
# http://localhost:3000
```

## 🐳 উৎপাদন স্থাপন (Docker Compose একক যন্ত্ৰ)

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

সাৱধানতা:

- `NEXT_PUBLIC_APP_URL` সলনি কৰিলে **অবশ্যেই** `docker compose build --no-cache web` চলাব লাগিব, কিয়নো এইটো client bundle-ত inline কৰা হয়
- বিপৰীত প্ৰক্সি (Nginx/Caddy) ব্যৱহাৰ কৰাৰ পিছত `TRUST_PROXY=true` খুলিবই লাগিব, নহ’লে X-Forwarded-Proto কাম কৰিব নোৱাৰিব
- KEK সলনি হলেই, পুৰণি credential pool / পুৰণি OAuth token **সমূহ একো পঢ়িব নোৱাৰিব**

## 🔐 OAuth2 (Linux.do) সংযোগ

1. [https://connect.linux.do](https://connect.linux.do) লৈ গৈ আবেদন কৰক
2. Callback address-ত লিখক: `https://your-domain/v1/auth/oauth/linuxdo/callback`
3. Client_id / client_secret যি পাব, সেইটো `.env`-ত লিখক:
   ```
   OAUTH_LINUXDO_ENABLED=true
   OAUTH_LINUXDO_CLIENT_ID=...
   OAUTH_LINUXDO_CLIENT_SECRET=...
   OAUTH_LINUXDO_MIN_TRUST_LEVEL=1
   OAUTH_PUBLIC_BASE=https://your-domain
   OAUTH_FRONTEND_BASE=https://your-domain
   ```
4. gateway পুনৰ আৰম্ভ কৰক, লগইন পৃষ্ঠা / পঞ্জীয়ন পৃষ্ঠা স্বয়ংক্ৰিয়ভাৱে "Linux.do এক-ক্লিক লগইন" দেখুৱাব

## 🧪 পৰীক্ষা / Lint

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

## 📦 মুখ্য নিৰ্ভৰশীলতা

**বেকএন্ড**ঃ

- [gin-gonic/gin](https://github.com/gin-gonic/gin) — HTTP ফ্ৰেমৱাৰ্ক
- [grpc-ecosystem](https://github.com/grpc-ecosystem) — gRPC + gateway
- [jackc/pgx](https://github.com/jackc/pgx/v5) — PostgreSQL ড্ৰাইভাৰ
- [redis/go-redis](https://github.com/redis/go-redis) — Redis ক্লায়েন্ট
- [golang.org/x/oauth2](https://pkg.go.dev/golang.org/x/oauth2) — OAuth2 / PKCE
- [pquerna/otp](https://github.com/pquerna/otp) — TOTP

**ফ্ৰণ্টএন্ড**ঃ

- [Next.js 16](https://nextjs.org/) (App Router + Turbopack)
- [shadcn/ui](https://ui.shadcn.com/) + [Radix](https://www.radix-ui.com/)
- [Tailwind CSS v4](https://tailwindcss.com/)
- [next-auth-csrf](https://github.com/edge-runtime/) edge-safe CSRF

## 📜 লাইচেঞ্চ

MIT — চাওক [LICENSE](./LICENSE)

## 🤝 অৱদান

PR / Issue স্বাগতম। PR দিয়াৰ আগতে অনুগ্ৰহ কৰি:

1. `golangci-lint run` + `gofmt -l .` সম্পূৰ্ণ সঠিক
2. `go test -race ./...` সম্পূৰ্ণ সঠিক
3. Web পৰিবৰ্তন চলাও `pnpm lint && pnpm typecheck`
4. অনুগ্ৰহ কৰি `.env` / `data/.kek` বা যিকোনো বাস্তব পাছৱৰ্ড থকা ফাইল জমা নিদিব

## 🔒 সুৰক্ষা

সুৰক্ষাৰ সমস্যা পালে দয়া কৰি সোজাকৈ maintainer-ক যোগাযোগ কৰক, **public issue** খুলিব নালাগে।

---

[MiChongs](https://github.com/MiChongs) দ্বাৰা ❤️-সহ নিৰ্মিত


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-08

---