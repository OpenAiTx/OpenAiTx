
<div align="right">
  <details>
    <summary >🌐 ภาษา</summary>
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

> เกตเวย์ API แบบรวมศูนย์ + คอนโซลควบคุม ระบบหลังบ้าน Go (Gin + gRPC) + ส่วนหน้า Next.js (App Router + shadcn/ui) มาพร้อมกับพูลข้อมูลรับรอง, การยืนยันอีเมล, Linux.do OAuth2 SSO, ระบบคิดค่าบริการตามโควต้า, TOTP ยืนยันตัวตนสองขั้นตอน

[![ใบอนุญาต: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](./LICENSE)
[![Go](https://img.shields.io/badge/Go-1.24+-00ADD8?logo=go)](https://go.dev/)
[![Next.js](https://img.shields.io/badge/Next.js-16-black?logo=next.js)](https://nextjs.org/)

## ✨ คุณสมบัติ

- **REST Gateway เดียว** — โหมดโปรเซสเดียวหรือหลาย service, gateway → auth/music/pool/quota/billing/worker gRPC backend แยกดีพลอยได้อิสระ
- **พูลข้อมูลประจำตัว (encrypted)** — KEK + DEK การเข้ารหัสซองจดหมาย, AES-256-GCM พร้อม AAD, POOL_KEK_HEX ต้นทางคีย์หลัก
- **สมัครสมาชิกอีเมล + เปิดใช้งาน** — SMTP ส่งรหัส/ลิงก์เปิดใช้งาน, ระบบสองชั้น (รหัสยืนยัน + ลิงก์อีเมล), หากไม่ได้ตั้ง SMTP จะลดระดับเป็น LogSender อัตโนมัติ
- **OAuth2 ล็อกอินบุคคลที่สาม** — Linux.do SSO (PKCE S256 + HMAC เซ็น cookie สถานะ), ตัดสินใจสามสถานะ: ล็อกอิน/ผูกบัญชี/ยกเลิกผูก, token เข้ารหัสบันทึกลงฐานข้อมูล
- **โควตา / การคิดเงิน** — PlanQuotaMiddleware ที่ชั้น gateway ป้องกัน, ภายใน business service ตรวจซ้ำตาม plan + scope
- **TOTP สองขั้นตอน** — `pquerna/otp` + ป้องกันรีเพลย์ด้วย Redis
- **บันทึกตรวจสอบ** — JSON แบบโครงสร้าง, แยกไฟล์ตาม type, หมุนเวียนรายวัน
- **CSRF + เซสชัน** — cookie `sid` httpOnly + header `X-CSRF-Token` ตรวจสอบสองขั้นตอน
- **คอนโซล shadcn/ui** — Next.js 16 App Router + Radix + Tailwind v4

## 🏗 โครงสร้างคลังเก็บ

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

## 🚀 เริ่มต้นอย่างรวดเร็ว

### 1. ข้อกำหนดเบื้องต้น

| เครื่องมือ      | เวอร์ชัน    |
| --------------- | ---------- |
| Go              | 1.24+      |
| Node.js         | 20.11+     |
| pnpm            | 9+         |
| Docker          | 24+        |
| PostgreSQL      | 14+        |
| Redis           | 7+         |

### 2. เริ่มต้นบริการที่จำเป็น (Postgres + Redis + pgAdmin)

```bash
cd deploy/compose
cp .env.example .env       # 改强密码！
docker compose up -d
```

### 3. เริ่มต้น Gateway ฝั่งหลัง

```bash
cd gateway
cp .env.example .env       # 与 deploy/compose/.env 的 PG/Redis 密码保持一致
go mod download
go run ./cmd/qqmusic-gateway
# 默认 :8080 (HTTP) + :9000 (gRPC)
# 首次启动会在 stderr 打印一个 superadmin 账号 + 临时密码
```

### 4. เริ่มต้นคอนโซลเว็บ

```bash
cd web
cp .env.example .env.local
pnpm install
pnpm dev
# http://localhost:3000
```

## 🐳 การปรับใช้งานในระบบการผลิต (Docker Compose แบบเครื่องเดียว)

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
ข้อควรระวัง:

- เมื่อเปลี่ยน `NEXT_PUBLIC_APP_URL` **จำเป็นต้อง** รัน `docker compose build --no-cache web` เพราะค่าดังกล่าวจะถูก inline เข้าไปใน client bundle
- หลังจากใช้งาน reverse proxy (Nginx/Caddy) ต้องเปิด `TRUST_PROXY=true` มิฉะนั้น X-Forwarded-Proto จะไม่ทำงาน
- เมื่อ KEK ถูกเปลี่ยน แหล่งข้อมูลเก่า / token OAuth เก่า **จะไม่สามารถอ่านได้**

## 🔐 การเชื่อมต่อ OAuth2 (Linux.do)

1. ไปที่ [https://connect.linux.do](https://connect.linux.do) เพื่อสมัครแอปพลิเคชัน
2. กรอก callback address เป็น: `https://your-domain/v1/auth/oauth/linuxdo/callback`
3. นำ client_id / client_secret ที่ได้รับมาใส่ไว้ใน `.env`:

   ```
   OAUTH_LINUXDO_ENABLED=true
   OAUTH_LINUXDO_CLIENT_ID=...
   OAUTH_LINUXDO_CLIENT_SECRET=...
   OAUTH_LINUXDO_MIN_TRUST_LEVEL=1
   OAUTH_PUBLIC_BASE=https://your-domain
   OAUTH_FRONTEND_BASE=https://your-domain
   ```
4. รีสตาร์ท gateway หน้าเข้าสู่ระบบ / หน้าลงทะเบียนจะปรากฏ "Linux.do เข้าสู่ระบบด้วยคลิกเดียว" โดยอัตโนมัติ

## 🧪 ทดสอบ / Lint

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

## 📦 ขึ้นอยู่กับไลบรารีสำคัญ

**ฝั่ง Backend**：

- [gin-gonic/gin](https://github.com/gin-gonic/gin) — เฟรมเวิร์ก HTTP
- [grpc-ecosystem](https://github.com/grpc-ecosystem) — gRPC + gateway
- [jackc/pgx](https://github.com/jackc/pgx/v5) — ไดรเวอร์ PostgreSQL
- [redis/go-redis](https://github.com/redis/go-redis) — ไคลเอนต์ Redis
- [golang.org/x/oauth2](https://pkg.go.dev/golang.org/x/oauth2) — OAuth2 / PKCE
- [pquerna/otp](https://github.com/pquerna/otp) — TOTP

**ฝั่ง Frontend**：

- [Next.js 16](https://nextjs.org/) (App Router + Turbopack)
- [shadcn/ui](https://ui.shadcn.com/) + [Radix](https://www.radix-ui.com/)
- [Tailwind CSS v4](https://tailwindcss.com/)
- [next-auth-csrf](https://github.com/edge-runtime/) edge-safe CSRF

## 📜 ใบอนุญาต

MIT — ดูที่ [LICENSE](./LICENSE)

## 🤝 การมีส่วนร่วม

PR / Issue ยินดีต้อนรับ ก่อนส่ง PR กรุณา：

1. `golangci-lint run` + `gofmt -l .` ต้องผ่านทั้งหมด
2. `go test -race ./...` ต้องผ่านทั้งหมด
3. หากแก้ไข Web ให้รัน `pnpm lint && pnpm typecheck`
4. ห้ามส่งไฟล์ `.env` / `data/.kek` หรือไฟล์ที่มีรหัสผ่านจริงใด ๆ

## 🔒 ความปลอดภัย

หากพบปัญหาด้านความปลอดภัย กรุณาติดต่อ maintainer โดยตรง **ห้าม**เปิด public issue

---

สร้างด้วย ❤️ โดย [MiChongs](https://github.com/MiChongs)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-08

---