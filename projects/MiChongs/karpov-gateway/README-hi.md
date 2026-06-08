<div align="right">
  <details>
    <summary >🌐 भाषा</summary>
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

# कार्पोव गेटवे

> एकीकृत API गेटवे + कंसोल। Go बैकएंड (Gin + gRPC) + Next.js फ्रंटएंड (App Router + shadcn/ui), इसमें क्रेडेंशियल पूल, ईमेल सत्यापन, Linux.do OAuth2 SSO, कोटा बिलिंग, TOTP दो चरणीय सत्यापन शामिल है।

[![लाइसेंस: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](./LICENSE)
[![Go](https://img.shields.io/badge/Go-1.24+-00ADD8?logo=go)](https://go.dev/)
[![Next.js](https://img.shields.io/badge/Next.js-16-black?logo=next.js)](https://nextjs.org/)


## ✨ विशेषताएँ

- **統一 REST गेटवे** — एकल प्रक्रिया या बहु सेवा मोड, gateway → auth/music/pool/quota/billing/worker gRPC बैकएंड स्वतंत्र रूप से डिप्लॉय हो सकते हैं
- **क्रेडेंशियल पूल (encrypted)** — KEK + DEK लिफाफा एन्क्रिप्शन, AES-256-GCM with AAD, POOL_KEK_HEX मास्टर कुंजी डेरिवेशन
- **ईमेल रजिस्ट्रेशन + एक्टिवेशन** — SMTP कोड भेजना / एक्टिवेशन लिंक, डबल सुरक्षा (वेरिफिकेशन कोड + ईमेल लिंक), SMTP न हो तो ऑटो LogSender में डिमोट
- **OAuth2 थर्ड-पार्टी लॉगिन** — Linux.do SSO (PKCE S256 + HMAC साइन स्टेट कुकी), लॉगिन / बाइंड / अनबाइंड तीन स्थिति निर्णय, टोकन एन्क्रिप्ट होकर स्टोर
- **कोटा / बिलिंग** — PlanQuotaMiddleware गेटवे लेयर पर, बिजनेस सर्विस में योजना + स्कोप के अनुसार द्वितीय सत्यापन
- **TOTP टू-स्टेप** — `pquerna/otp` + Redis रिप्ले प्रोटेक्शन
- **ऑडिट लॉग** — संरचित JSON, टाइप के अनुसार फाइल में, रोजाना रोटेशन
- **CSRF + सत्र** — `sid` httpOnly कुकी + `X-CSRF-Token` हेडर दोहरी सत्यापन
- **shadcn/ui कंसोल** — Next.js 16 App Router + Radix + Tailwind v4

## 🏗 रिपॉजिटरी संरचना

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

## 🚀 त्वरित प्रारंभ

### 1. पूर्व आवश्यकताएँ

| उपकरण      | संस्करण |
| ---------- | ------- |
| Go         | 1.24+   |
| Node.js    | 20.11+  |
| pnpm       | 9+      |
| Docker     | 24+     |
| PostgreSQL | 14+     |
| Redis      | 7+      |

### 2. निर्भरता प्रारंभ करें (Postgres + Redis + pgAdmin)

```bash
cd deploy/compose
cp .env.example .env       # 改强密码！
docker compose up -d
```

### 3. Gateway बैकएंड प्रारंभ करें

```bash
cd gateway
cp .env.example .env       # 与 deploy/compose/.env 的 PG/Redis 密码保持一致
go mod download
go run ./cmd/qqmusic-gateway
# 默认 :8080 (HTTP) + :9000 (gRPC)
# 首次启动会在 stderr 打印一个 superadmin 账号 + 临时密码
```

### 4. वेब कंसोल प्रारंभ करें

```bash
cd web
cp .env.example .env.local
pnpm install
pnpm dev
# http://localhost:3000
```

## 🐳 उत्पादन परिनियोजन (Docker Compose सिंगल मशीन)

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

ध्यान देने योग्य बातें:

- `NEXT_PUBLIC_APP_URL` बदलने के बाद **अनिवार्य रूप से** `docker compose build --no-cache web` चलाएँ, क्योंकि यह client bundle में inline हो जाएगा
- रिवर्स प्रॉक्सी (Nginx/Caddy) के बाद अनिवार्य रूप से `TRUST_PROXY=true` चालू करें, अन्यथा X-Forwarded-Proto काम नहीं करेगा
- KEK बदलते ही पुराने क्रेडेंशियल पूल / पुराने OAuth टोकन **पूरी तरह अपठनीय** हो जाएंगे

## 🔐 OAuth2 (Linux.do) एकीकरण

1. [https://connect.linux.do](https://connect.linux.do) पर ऐप्लिकेशन के लिए आवेदन करें
2. callback पता भरें: `https://your-domain/v1/auth/oauth/linuxdo/callback`
3. प्राप्त client_id / client_secret को `.env` में लिखें:
   ```
   OAUTH_LINUXDO_ENABLED=true
   OAUTH_LINUXDO_CLIENT_ID=...
   OAUTH_LINUXDO_CLIENT_SECRET=...
   OAUTH_LINUXDO_MIN_TRUST_LEVEL=1
   OAUTH_PUBLIC_BASE=https://your-domain
   OAUTH_FRONTEND_BASE=https://your-domain
   ```
4. gateway को पुनः प्रारंभ करें, लॉगिन पृष्ठ / पंजीकरण पृष्ठ पर "Linux.do एक-क्लिक लॉगिन" अपने आप दिखाई देगा

## 🧪 परीक्षण / Lint

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

## 📦 मुख्य निर्भरता

**बैकएंड**：

- [gin-gonic/gin](https://github.com/gin-gonic/gin) — HTTP फ्रेमवर्क
- [grpc-ecosystem](https://github.com/grpc-ecosystem) — gRPC + गेटवे
- [jackc/pgx](https://github.com/jackc/pgx/v5) — PostgreSQL ड्राइवर
- [redis/go-redis](https://github.com/redis/go-redis) — Redis क्लाइंट
- [golang.org/x/oauth2](https://pkg.go.dev/golang.org/x/oauth2) — OAuth2 / PKCE
- [pquerna/otp](https://github.com/pquerna/otp) — TOTP

**फ्रंटएंड**：

- [Next.js 16](https://nextjs.org/) (App Router + Turbopack)
- [shadcn/ui](https://ui.shadcn.com/) + [Radix](https://www.radix-ui.com/)
- [Tailwind CSS v4](https://tailwindcss.com/)
- [next-auth-csrf](https://github.com/edge-runtime/) एज-सेफ CSRF

## 📜 लाइसेंस

MIT — देखें [LICENSE](./LICENSE)

## 🤝 योगदान

PR / Issue का स्वागत है। PR भेजने से पहले कृपया:

1. `golangci-lint run` + `gofmt -l .` सभी हरे
2. `go test -race ./...` सभी हरे
3. वेब में बदलाव पर `pnpm lint && pnpm typecheck` चलाएं
4. कृपया `.env` / `data/.kek` या कोई भी असली पासवर्ड वाली फाइल सबमिट न करें

## 🔒 सुरक्षा

अगर कोई सुरक्षा समस्या मिले तो सीधे मेंटेनर से संपर्क करें, **पब्लिक issue न खोलें**।

---

[MiChongs](https://github.com/MiChongs) द्वारा ❤️ से निर्मित


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-08

---