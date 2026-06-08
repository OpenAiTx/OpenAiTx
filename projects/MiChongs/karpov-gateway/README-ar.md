
<div align="right">
  <details>
    <summary >🌐 اللغة</summary>
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

# بوابة كاربوف

> بوابة API موحدة + لوحة تحكم. خلفية Go (Gin + gRPC) + واجهة أمامية Next.js (App Router + shadcn/ui)، مزودة بمسبح الاعتماديات، تحقق البريد الإلكتروني، OAuth2 SSO من Linux.do، حساب الحصص والفوترة، تحقق TOTP ثنائي الخطوة.

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](./LICENSE)
[![Go](https://img.shields.io/badge/Go-1.24+-00ADD8?logo=go)](https://go.dev/)
[![Next.js](https://img.shields.io/badge/Next.js-16-black?logo=next.js)](https://nextjs.org/)

## ✨ الميزات

- **بوابة REST موحدة** — وضع العملية الأحادية أو نمط الخدمات المتعددة، بوابة gateway → المصادقة/auth، الموسيقى/music، المسبح/pool، الحصص/quota، الفوترة/billing، العامل/worker، يمكن نشر الخلفيات gRPC بشكل مستقل
- **تجمع بيانات الاعتماد (مشفر)** — تشفير الظرف KEK + DEK، AES-256-GCM مع AAD، اشتقاق المفتاح الرئيسي POOL_KEK_HEX
- **تسجيل البريد الإلكتروني + التفعيل** — إرسال رمز / رابط تفعيل عبر SMTP، حماية مزدوجة (رمز التحقق + رابط البريد)، في حال عدم تكوين SMTP يتم التحويل التلقائي إلى LogSender
- **تسجيل الدخول عبر OAuth2 لطرف ثالث** — SSO من Linux.do (PKCE S256 + توقيع state cookie بـ HMAC)، ثلاث حالات قرار (تسجيل الدخول / ربط / إلغاء الربط)، تخزين token مشفر
- **الحصص / الفوترة** — PlanQuotaMiddleware كحماية في طبقة gateway، تحقق ثانوي داخل الخدمة التجارية حسب الخطة + النطاق
- **التحقق بخطوتين TOTP** — `pquerna/otp` + حماية من إعادة الاستخدام عبر Redis
- **سجلات التدقيق** — JSON منظم، ملفات منفصلة حسب النوع، تدوير يومي
- **CSRF + جلسة** — تحقق مزدوج عبر cookie httpOnly باسم `sid` + رأس `X-CSRF-Token`
- **وحدة تحكم shadcn/ui** — Next.js 16 App Router + Radix + Tailwind v4

## 🏗 هيكل المستودع

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

## 🚀 البدء السريع

### 1. المتطلبات المسبقة

| الأداة      | الإصدار  |
| ----------- | -------- |
| Go          | 1.24+    |
| Node.js     | 20.11+   |
| pnpm        | 9+       |
| Docker      | 24+      |
| PostgreSQL  | 14+      |
| Redis       | 7+       |

### 2. تشغيل الاعتمادات (Postgres + Redis + pgAdmin)

```bash
cd deploy/compose
cp .env.example .env       # 改强密码！
docker compose up -d
```

### 3. بدء تشغيل بوابة Gateway الخلفية

```bash
cd gateway
cp .env.example .env       # 与 deploy/compose/.env 的 PG/Redis 密码保持一致
go mod download
go run ./cmd/qqmusic-gateway
# 默认 :8080 (HTTP) + :9000 (gRPC)
# 首次启动会在 stderr 打印一个 superadmin 账号 + 临时密码
```

### 4. تشغيل وحدة التحكم في الويب

```bash
cd web
cp .env.example .env.local
pnpm install
pnpm dev
# http://localhost:3000
```

## 🐳 النشر الإنتاجي (Docker Compose على جهاز واحد)

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
ملاحظات:

- عند تغيير `NEXT_PUBLIC_APP_URL` **يجب** تنفيذ `docker compose build --no-cache web`، لأنه سيتم تضمينه مباشرة في حزمة العميل
- بعد استخدام العكس العكسي (Nginx/Caddy) يجب تفعيل `TRUST_PROXY=true`، وإلا لن يعمل X-Forwarded-Proto
- بمجرد تغيير KEK، فإن جميع مخازن بيانات الاعتماد القديمة / رموز OAuth القديمة **لن تكون قابلة للقراءة**

## 🔐 دمج OAuth2 (Linux.do)

1. اذهب إلى [https://connect.linux.do](https://connect.linux.do) وقدم طلبًا للتطبيق
2. أدخل عنوان الاستدعاء التالي: `https://your-domain/v1/auth/oauth/linuxdo/callback`
3. ضع client_id / client_secret الذي حصلت عليه في ملف `.env`:

   ```
   OAUTH_LINUXDO_ENABLED=true
   OAUTH_LINUXDO_CLIENT_ID=...
   OAUTH_LINUXDO_CLIENT_SECRET=...
   OAUTH_LINUXDO_MIN_TRUST_LEVEL=1
   OAUTH_PUBLIC_BASE=https://your-domain
   OAUTH_FRONTEND_BASE=https://your-domain
   ```
4. أعد تشغيل البوابة، ستظهر تلقائيًا صفحة تسجيل الدخول / التسجيل "Linux.do تسجيل دخول بنقرة واحدة"

## 🧪 اختبار / Lint

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

## 📦 الاعتمادات الرئيسية

**الخلفية**:

- [gin-gonic/gin](https://github.com/gin-gonic/gin) — إطار عمل HTTP
- [grpc-ecosystem](https://github.com/grpc-ecosystem) — gRPC + gateway
- [jackc/pgx](https://github.com/jackc/pgx/v5) — برنامج تشغيل PostgreSQL
- [redis/go-redis](https://github.com/redis/go-redis) — عميل Redis
- [golang.org/x/oauth2](https://pkg.go.dev/golang.org/x/oauth2) — OAuth2 / PKCE
- [pquerna/otp](https://github.com/pquerna/otp) — TOTP

**الواجهة الأمامية**:

- [Next.js 16](https://nextjs.org/) (App Router + Turbopack)
- [shadcn/ui](https://ui.shadcn.com/) + [Radix](https://www.radix-ui.com/)
- [Tailwind CSS v4](https://tailwindcss.com/)
- [next-auth-csrf](https://github.com/edge-runtime/) CSRF آمن للحواف

## 📜 الرخصة

MIT — راجع [LICENSE](./LICENSE)

## 🤝 المساهمة

PR / Issue مرحب به. قبل تقديم PR يرجى:

1. تأكد أن `golangci-lint run` + `gofmt -l .` جميعها خضراء
2. تأكد أن `go test -race ./...` جميعها خضراء
3. في تعديلات الويب شغّل `pnpm lint && pnpm typecheck`
4. لا تقم بتضمين ملفات `.env` / `data/.kek` أو أي ملفات تحتوي على كلمات مرور حقيقية

## 🔒 الأمان

في حال اكتشاف مشكلة أمنية يرجى التواصل مباشرة مع المسؤول، **ولا** تفتح issue علني.

---

تم البناء بحب بواسطة [MiChongs](https://github.com/MiChongs)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-08

---