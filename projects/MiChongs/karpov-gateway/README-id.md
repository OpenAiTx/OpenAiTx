
<div align="right">
  <details>
    <summary >🌐 Bahasa</summary>
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

> Gateway API terintegrasi + Konsol. Backend Go (Gin + gRPC) + Frontend Next.js (App Router + shadcn/ui), dilengkapi dengan pool kredensial, verifikasi email, Linux.do OAuth2 SSO, kuota & penagihan, verifikasi dua langkah TOTP.

[![Lisensi: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](./LICENSE)
[![Go](https://img.shields.io/badge/Go-1.24+-00ADD8?logo=go)](https://go.dev/)
[![Next.js](https://img.shields.io/badge/Next.js-16-black?logo=next.js)](https://nextjs.org/)

## ✨ Fitur

- **Gateway REST Terpadu** — Mode proses tunggal atau multi layanan, gateway → auth/music/pool/quota/billing/worker backend gRPC dapat dideploy secara independen
- **Kolam Kredensial (terenkripsi)** — Enkripsi amplop KEK + DEK, AES-256-GCM dengan AAD, kunci induk POOL_KEK_HEX turunan
- **Registrasi Email + Aktivasi** — SMTP kirim kode / tautan aktivasi, asuransi ganda (kode verifikasi + tautan email), jika SMTP tidak dikonfigurasi otomatis turun ke LogSender
- **Login Pihak Ketiga OAuth2** — Linux.do SSO (PKCE S256 + cookie state tanda tangan HMAC), keputusan tiga status login / binding / unbinding, token dienkripsi saat disimpan
- **Kuota / Penagihan** — PlanQuotaMiddleware sebagai cadangan di lapisan gateway, validasi ulang berdasarkan plan + scope di internal business service
- **TOTP Dua Langkah** — `pquerna/otp` + perlindungan replay Redis
- **Log Audit** — JSON terstruktur, file per type, rolling harian
- **CSRF + Sesi** — cookie httpOnly `sid` + header `X-CSRF-Token` verifikasi ganda
- **Konsol shadcn/ui** — Next.js 16 App Router + Radix + Tailwind v4

## 🏗 Struktur Repository

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

## 🚀 Mulai Cepat

### 1. Persyaratan Awal

| Alat       | Versi   |
| ---------- | ------- |
| Go         | 1.24+   |
| Node.js    | 20.11+  |
| pnpm       | 9+      |
| Docker     | 24+     |
| PostgreSQL | 14+     |
| Redis      | 7+      |

### 2. Menjalankan Dependensi (Postgres + Redis + pgAdmin)

```bash
cd deploy/compose
cp .env.example .env       # 改强密码！
docker compose up -d
```

### 3. Mulai Backend Gateway

```bash
cd gateway
cp .env.example .env       # 与 deploy/compose/.env 的 PG/Redis 密码保持一致
go mod download
go run ./cmd/qqmusic-gateway
# 默认 :8080 (HTTP) + :9000 (gRPC)
# 首次启动会在 stderr 打印一个 superadmin 账号 + 临时密码
```

### 4. Memulai Konsol Web

```bash
cd web
cp .env.example .env.local
pnpm install
pnpm dev
# http://localhost:3000
```

## 🐳 Deployment Produksi (Docker Compose Standalone)

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

Catatan Penting:

- Jika `NEXT_PUBLIC_APP_URL` diubah, **HARUS** menjalankan `docker compose build --no-cache web`, karena ini akan di-inline ke client bundle
- Setelah reverse proxy (Nginx/Caddy) harus mengaktifkan `TRUST_PROXY=true`, jika tidak maka X-Forwarded-Proto tidak berfungsi
- Jika KEK berubah, pool kredensial lama / token OAuth lama **tidak dapat dibaca**

## 🔐 Integrasi OAuth2 (Linux.do)

1. Kunjungi [https://connect.linux.do](https://connect.linux.do) untuk mendaftar aplikasi
2. Isi alamat callback: `https://your-domain/v1/auth/oauth/linuxdo/callback`
3. Masukkan client_id / client_secret yang diperoleh ke `.env`:
   ```
   OAUTH_LINUXDO_ENABLED=true
   OAUTH_LINUXDO_CLIENT_ID=...
   OAUTH_LINUXDO_CLIENT_SECRET=...
   OAUTH_LINUXDO_MIN_TRUST_LEVEL=1
   OAUTH_PUBLIC_BASE=https://your-domain
   OAUTH_FRONTEND_BASE=https://your-domain
   ```
4. Restart gateway, halaman login / halaman registrasi akan otomatis menampilkan "Linux.do One-click Login"

## 🧪 Pengujian / Lint

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

## 📦 Ketergantungan Utama

**Backend**：

- [gin-gonic/gin](https://github.com/gin-gonic/gin) — Kerangka HTTP
- [grpc-ecosystem](https://github.com/grpc-ecosystem) — gRPC + gateway
- [jackc/pgx](https://github.com/jackc/pgx/v5) — Driver PostgreSQL
- [redis/go-redis](https://github.com/redis/go-redis) — Klien Redis
- [golang.org/x/oauth2](https://pkg.go.dev/golang.org/x/oauth2) — OAuth2 / PKCE
- [pquerna/otp](https://github.com/pquerna/otp) — TOTP

**Frontend**：

- [Next.js 16](https://nextjs.org/) (App Router + Turbopack)
- [shadcn/ui](https://ui.shadcn.com/) + [Radix](https://www.radix-ui.com/)
- [Tailwind CSS v4](https://tailwindcss.com/)
- [next-auth-csrf](https://github.com/edge-runtime/) CSRF aman edge

## 📜 Lisensi

MIT — Lihat [LICENSE](./LICENSE)

## 🤝 Kontribusi

PR / Issue dipersilakan. Sebelum mengajukan PR, harap:

1. `golangci-lint run` + `gofmt -l .` harus hijau semua
2. `go test -race ./...` harus hijau semua
3. Perubahan Web jalankan `pnpm lint && pnpm typecheck`
4. Jangan commit `.env` / `data/.kek` atau file apa pun yang berisi password asli

## 🔒 Keamanan

Jika menemukan masalah keamanan, harap langsung hubungi maintainer, **JANGAN** buka public issue.

---

Dibuat dengan ❤️ oleh [MiChongs](https://github.com/MiChongs)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-08

---