
<div align="right">
  <details>
    <summary >🌐 زبان</summary>
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

# درگاه کارپوف

> درگاه API یکپارچه + کنسول مدیریت. بک‌اند Go (Gin + gRPC) + فرانت‌اند Next.js (App Router + shadcn/ui)، مجهز به استخر اعتبارنامه، تأیید ایمیل، OAuth2 SSO لینوکس، سهمیه‌بندی و صورتحساب، احراز هویت دومرحله‌ای TOTP.

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](./LICENSE)
[![Go](https://img.shields.io/badge/Go-1.24+-00ADD8?logo=go)](https://go.dev/)
[![Next.js](https://img.shields.io/badge/Next.js-16-black?logo=next.js)](https://nextjs.org/)

## ✨ ویژگی‌ها

- **درگاه REST یکپارچه** — حالت تک‌فرآیندی یا چند سرویس، gateway → auth/music/pool/quota/billing/worker بک‌اند gRPC با قابلیت استقرار مستقل
- **استخر اعتبارنامه (رمزنگاری‌شده)** — رمزگذاری پاکت KEK + DEK، AES-256-GCM با AAD، مشتق‌سازی کلید اصلی POOL_KEK_HEX
- **ثبت‌نام ایمیلی + فعال‌سازی** — ارسال کد/لینک فعال‌سازی از طریق SMTP، دوگانه حفاظتی (کد تأیید + لینک ایمیل)، در صورت عدم پیکربندی SMTP، به طور خودکار به LogSender کاهش می‌یابد
- **ورود سوم شخص OAuth2** — SSO لینوکس.do (PKCE S256 + امضای HMAC روی state cookie)، تصمیم سه حالته ورود/اتصال/قطع اتصال، رمزنگاری token و ذخیره در پایگاه داده
- **سهمیه/صورتحساب** — PlanQuotaMiddleware پوشش‌دهنده در لایه gateway، بررسی ثانویه بر اساس plan + scope در سرویس‌های تجاری
- **TOTP دو مرحله‌ای** — `pquerna/otp` + محافظت در برابر تکرار با Redis
- **گزارش حسابرسی** — JSON ساختاریافته، فایل‌بندی بر اساس type، چرخش روزانه
- **CSRF + جلسه** — کوکی httpOnly با نام `sid` + بررسی دوگانه با هدر `X-CSRF-Token`
- **کنترل پنل shadcn/ui** — Next.js 16 App Router + Radix + Tailwind v4

## 🏗 ساختار مخزن

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

## 🚀 شروع سریع

### 1. پیش‌نیازها

| ابزار       | نسخه    |
| ----------- | ------- |
| Go          | 1.24+   |
| Node.js     | 20.11+  |
| pnpm        | 9+      |
| Docker      | 24+     |
| PostgreSQL  | 14+     |
| Redis       | 7+      |

### 2. راه‌اندازی وابستگی‌ها (Postgres + Redis + pgAdmin)

```bash
cd deploy/compose
cp .env.example .env       # 改强密码！
docker compose up -d
```

### 3. راه‌اندازی بخش پشتیبان Gateway

```bash
cd gateway
cp .env.example .env       # 与 deploy/compose/.env 的 PG/Redis 密码保持一致
go mod download
go run ./cmd/qqmusic-gateway
# 默认 :8080 (HTTP) + :9000 (gRPC)
# 首次启动会在 stderr 打印一个 superadmin 账号 + 临时密码
```

### 4. راه‌اندازی کنسول وب

```bash
cd web
cp .env.example .env.local
pnpm install
pnpm dev
# http://localhost:3000
```

## 🐳 استقرار تولیدی (Docker Compose تک‌ماشین)

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

نکات مهم:

- اگر مقدار `NEXT_PUBLIC_APP_URL` تغییر کند، **حتماً باید** دستور `docker compose build --no-cache web` اجرا شود، چون این مقدار در bundle سمت کلاینت قرار می‌گیرد.
- پس از فعال‌سازی پراکسی معکوس (Nginx/Caddy)، حتماً باید `TRUST_PROXY=true` فعال شود، وگرنه X-Forwarded-Proto کار نمی‌کند.
- اگر KEK تغییر کند، دیگر نمی‌توان به استخر اعتبارنامه‌های قدیمی / توکن‌های OAuth قدیمی دسترسی داشت.

## 🔐 اتصال OAuth2 (Linux.do)

1. به [https://connect.linux.do](https://connect.linux.do) مراجعه و اپلیکیشن ثبت کنید.
2. آدرس بازگشت را این مقدار قرار دهید: `https://your-domain/v1/auth/oauth/linuxdo/callback`
3. مقادیر client_id و client_secret دریافتی را در فایل `.env` وارد کنید:
   ```
   OAUTH_LINUXDO_ENABLED=true
   OAUTH_LINUXDO_CLIENT_ID=...
   OAUTH_LINUXDO_CLIENT_SECRET=...
   OAUTH_LINUXDO_MIN_TRUST_LEVEL=1
   OAUTH_PUBLIC_BASE=https://your-domain
   OAUTH_FRONTEND_BASE=https://your-domain
   ```
4. پس از راه‌اندازی مجدد gateway، صفحه ورود / ثبت‌نام به طور خودکار گزینه "Linux.do ورود با یک کلیک" را نمایش می‌دهد.

## 🧪 تست / Lint

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

## 📦 وابستگی‌های کلیدی

**بک‌اند**:

- [gin-gonic/gin](https://github.com/gin-gonic/gin) — فریمورک HTTP
- [grpc-ecosystem](https://github.com/grpc-ecosystem) — gRPC + gateway
- [jackc/pgx](https://github.com/jackc/pgx/v5) — درایور PostgreSQL
- [redis/go-redis](https://github.com/redis/go-redis) — کلاینت Redis
- [golang.org/x/oauth2](https://pkg.go.dev/golang.org/x/oauth2) — OAuth2 / PKCE
- [pquerna/otp](https://github.com/pquerna/otp) — TOTP

**فرانت‌اند**:

- [Next.js 16](https://nextjs.org/) (App Router + Turbopack)
- [shadcn/ui](https://ui.shadcn.com/) + [Radix](https://www.radix-ui.com/)
- [Tailwind CSS v4](https://tailwindcss.com/)
- [next-auth-csrf](https://github.com/edge-runtime/) امنیت CSRF در edge

## 📜 مجوز

MIT — مراجعه به [LICENSE](./LICENSE)

## 🤝 مشارکت

PR / Issue خوش‌آمدید. پیش از ارسال PR لطفاً:

1. `golangci-lint run` + `gofmt -l .` همه سبز
2. `go test -race ./...` همه سبز
3. تغییرات وب را با `pnpm lint && pnpm typecheck` اجرا کنید
4. لطفاً فایل‌های `.env` / `data/.kek` یا هر فایلی که شامل رمز عبور واقعی است ارسال نکنید

## 🔒 امنیت

در صورت کشف مشکل امنیتی مستقیماً با maintainer تماس بگیرید، **هرگز** public issue باز نکنید.

---

ساخته شده با ❤️ توسط [MiChongs](https://github.com/MiChongs)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-08

---