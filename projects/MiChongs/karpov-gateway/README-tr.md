
<div align="right">
  <details>
    <summary >🌐 Dil</summary>
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

> Entegre API Ağ Geçidi + Kontrol Paneli. Go arka uç (Gin + gRPC) + Next.js ön uç (App Router + shadcn/ui), yerleşik kimlik havuzu, e-posta doğrulama, Linux.do OAuth2 SSO, kota ve faturalandırma, TOTP iki adımlı doğrulama.

[![Lisans: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](./LICENSE)
[![Go](https://img.shields.io/badge/Go-1.24+-00ADD8?logo=go)](https://go.dev/)
[![Next.js](https://img.shields.io/badge/Next.js-16-black?logo=next.js)](https://nextjs.org/)

## ✨ Özellikler

- **Birleşik REST Ağ Geçidi** — Tek süreçli veya çoklu servis modunda, gateway → auth/music/pool/quota/billing/worker gRPC arka uçları bağımsız dağıtılabilir
- **Kimlik Bilgisi Havuzu (şifreli)** — KEK + DEK zarf şifrelemesi, AES-256-GCM with AAD, POOL_KEK_HEX ana anahtardan türetme
- **E-posta ile Kayıt + Aktivasyon** — SMTP kod gönderimi / aktivasyon bağlantısı, çift güvenlik (doğrulama kodu + e-posta bağlantısı), SMTP yapılandırılmamışsa otomatik olarak LogSender’a düşer
- **OAuth2 Üçüncü Taraf Girişi** — Linux.do SSO (PKCE S256 + HMAC imzalı state cookie), giriş / bağlama / bağlantı kesme üçlü karar, token şifrelenip veritabanında saklanır
- **Kota / Faturalandırma** — PlanQuotaMiddleware gateway katmanında son kontrol, iş servisinde plan + kapsam ile ikinci doğrulama
- **TOTP İki Adımlı** — `pquerna/otp` + Redis tekrar oynatma koruması
- **Denetim Günlüğü** — Yapısal JSON, türe göre dosya ayrımı, günlük döngü
- **CSRF + Oturum** — `sid` httpOnly çerez + `X-CSRF-Token` başlığı ile çift doğrulama
- **shadcn/ui kontrol paneli** — Next.js 16 App Router + Radix + Tailwind v4

## 🏗 Depo Yapısı

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

## 🚀 Hızlı Başlangıç

### 1. Ön Gereksinimler

| Araç       | Sürüm   |
| ---------- | ------- |
| Go         | 1.24+   |
| Node.js    | 20.11+  |
| pnpm       | 9+      |
| Docker     | 24+     |
| PostgreSQL | 14+     |
| Redis      | 7+      |

### 2. Bağımlılıkları Başlatma (Postgres + Redis + pgAdmin)

```bash
cd deploy/compose
cp .env.example .env       # 改强密码！
docker compose up -d
```

### 3. Gateway arka ucunu başlatın

```bash
cd gateway
cp .env.example .env       # 与 deploy/compose/.env 的 PG/Redis 密码保持一致
go mod download
go run ./cmd/qqmusic-gateway
# 默认 :8080 (HTTP) + :9000 (gRPC)
# 首次启动会在 stderr 打印一个 superadmin 账号 + 临时密码
```

### 4. Web Konsolunu Başlatma

```bash
cd web
cp .env.example .env.local
pnpm install
pnpm dev
# http://localhost:3000
```

## 🐳 Üretim Dağıtımı (Docker Compose Tek Makine)

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

Dikkat edilmesi gerekenler:

- `NEXT_PUBLIC_APP_URL` değiştirildiğinde **mutlaka** `docker compose build --no-cache web` komutu çalıştırılmalı, çünkü bu değer client bundle içine gömülür.
- Ters proxy (Nginx/Caddy) kullanıldığında `TRUST_PROXY=true` açılmalı, aksi halde X-Forwarded-Proto çalışmaz.
- KEK değiştirildiğinde, eski kimlik havuzu / eski OAuth token'ları **tamamen okunamaz** olur.

## 🔐 OAuth2 (Linux.do) Entegrasyonu

1. [https://connect.linux.do](https://connect.linux.do) adresinden uygulama başvurusu yapın
2. Callback adresine şunu yazın: `https://your-domain/v1/auth/oauth/linuxdo/callback`
3. Aldığınız client_id / client_secret bilgilerini `.env` dosyasına yazın:
   ```
   OAUTH_LINUXDO_ENABLED=true
   OAUTH_LINUXDO_CLIENT_ID=...
   OAUTH_LINUXDO_CLIENT_SECRET=...
   OAUTH_LINUXDO_MIN_TRUST_LEVEL=1
   OAUTH_PUBLIC_BASE=https://your-domain
   OAUTH_FRONTEND_BASE=https://your-domain
   ```
4. Gateway'i yeniden başlatın, giriş / kayıt sayfasında otomatik olarak "Linux.do Tek Tıkla Giriş" görünür.

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

## 📦 Temel Bağımlılıklar

**Arka Uç**：

- [gin-gonic/gin](https://github.com/gin-gonic/gin) — HTTP çerçevesi
- [grpc-ecosystem](https://github.com/grpc-ecosystem) — gRPC + gateway
- [jackc/pgx](https://github.com/jackc/pgx/v5) — PostgreSQL sürücüsü
- [redis/go-redis](https://github.com/redis/go-redis) — Redis istemcisi
- [golang.org/x/oauth2](https://pkg.go.dev/golang.org/x/oauth2) — OAuth2 / PKCE
- [pquerna/otp](https://github.com/pquerna/otp) — TOTP

**Ön Uç**：

- [Next.js 16](https://nextjs.org/) (App Router + Turbopack)
- [shadcn/ui](https://ui.shadcn.com/) + [Radix](https://www.radix-ui.com/)
- [Tailwind CSS v4](https://tailwindcss.com/)
- [next-auth-csrf](https://github.com/edge-runtime/) edge-safe CSRF

## 📜 Lisans

MIT — Bkz. [LICENSE](./LICENSE)

## 🤝 Katkı Sağlama

PR / Issue hoş geldiniz. PR göndermeden önce lütfen:

1. `golangci-lint run` + `gofmt -l .` tamamen yeşil
2. `go test -race ./...` tamamen yeşil
3. Web değişikliklerinde `pnpm lint && pnpm typecheck` çalıştırın
4. `.env` / `data/.kek` veya gerçek şifre içeren herhangi bir dosya göndermeyin

## 🔒 Güvenlik

Bir güvenlik sorunu bulursanız doğrudan maintainer ile iletişime geçin, **kesinlikle** public issue açmayın.

---

[MiChongs](https://github.com/MiChongs) tarafından sevgiyle hazırlandı


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-08

---