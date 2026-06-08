
<div align="right">
  <details>
    <summary >🌐 Ngôn ngữ</summary>
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

> Cổng API tích hợp + Bảng điều khiển. Backend Go (Gin + gRPC) + Frontend Next.js (App Router + shadcn/ui), tích hợp sẵn kho thông tin xác thực, xác minh email, Linux.do OAuth2 SSO, tính toán hạn mức & phí, xác thực hai bước TOTP.

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](./LICENSE)
[![Go](https://img.shields.io/badge/Go-1.24+-00ADD8?logo=go)](https://go.dev/)
[![Next.js](https://img.shields.io/badge/Next.js-16-black?logo=next.js)](https://nextjs.org/)

## ✨ Tính năng

- **Cổng REST thống nhất** — Chế độ đơn tiến trình hoặc đa dịch vụ, gateway → auth/music/pool/quota/billing/worker gRPC backend có thể triển khai độc lập
- **Kho lưu trữ chứng chỉ (mã hóa)** — KEK + DEK mã hóa phong bì, AES-256-GCM với AAD, POOL_KEK_HEX dẫn xuất khóa chính
- **Đăng ký email + kích hoạt** — Gửi mã SMTP / liên kết kích hoạt, bảo hiểm kép (mã xác thực + liên kết email), không cấu hình SMTP tự động hạ cấp về LogSender
- **Đăng nhập OAuth2 bên thứ ba** — Linux.do SSO (PKCE S256 + HMAC ký state cookie), ba trạng thái quyết định đăng nhập / liên kết / hủy liên kết, token mã hóa lưu trữ
- **Chỉ tiêu / tính phí** — PlanQuotaMiddleware bảo vệ ở tầng gateway, dịch vụ kinh doanh nội bộ kiểm tra lần hai theo plan + scope
- **TOTP hai bước** — `pquerna/otp` + Redis bảo vệ chống phát lại
- **Nhật ký kiểm toán** — JSON có cấu trúc, phân file theo type, cuộn lại mỗi ngày
- **CSRF + Session** — cookie `sid` httpOnly + tiêu đề `X-CSRF-Token` kiểm tra kép
- **Bảng điều khiển shadcn/ui** — Next.js 16 App Router + Radix + Tailwind v4

## 🏗 Cấu trúc kho lưu trữ

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

## 🚀 Bắt đầu nhanh

### 1. Yêu cầu trước

| Công cụ     | Phiên bản |
| ----------- | --------- |
| Go          | 1.24+     |
| Node.js     | 20.11+    |
| pnpm        | 9+        |
| Docker      | 24+       |
| PostgreSQL  | 14+       |
| Redis       | 7+        |

### 2. Khởi động các phụ thuộc (Postgres + Redis + pgAdmin)

```bash
cd deploy/compose
cp .env.example .env       # 改强密码！
docker compose up -d
```

### 3. Khởi động Gateway backend

```bash
cd gateway
cp .env.example .env       # 与 deploy/compose/.env 的 PG/Redis 密码保持一致
go mod download
go run ./cmd/qqmusic-gateway
# 默认 :8080 (HTTP) + :9000 (gRPC)
# 首次启动会在 stderr 打印一个 superadmin 账号 + 临时密码
```

### 4. Khởi động bảng điều khiển Web

```bash
cd web
cp .env.example .env.local
pnpm install
pnpm dev
# http://localhost:3000
```

## 🐳 Triển khai sản xuất (Docker Compose đơn máy)

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

Lưu ý:

- Khi thay đổi `NEXT_PUBLIC_APP_URL`, **bắt buộc** phải chạy lại `docker compose build --no-cache web`, vì biến này sẽ được nhúng trực tiếp vào client bundle
- Khi triển khai sau reverse proxy (Nginx/Caddy) thì phải bật `TRUST_PROXY=true`, nếu không X-Forwarded-Proto sẽ không hoạt động
- Nếu thay đổi KEK, toàn bộ kho thông tin xác thực cũ / token OAuth cũ **đều không thể đọc được**

## 🔐 Tích hợp OAuth2 (Linux.do)

1. Truy cập [https://connect.linux.do](https://connect.linux.do) để đăng ký ứng dụng
2. Địa chỉ callback nhập: `https://your-domain/v1/auth/oauth/linuxdo/callback`
3. Ghi lại client_id / client_secret nhận được vào file `.env`:
   ```
   OAUTH_LINUXDO_ENABLED=true
   OAUTH_LINUXDO_CLIENT_ID=...
   OAUTH_LINUXDO_CLIENT_SECRET=...
   OAUTH_LINUXDO_MIN_TRUST_LEVEL=1
   OAUTH_PUBLIC_BASE=https://your-domain
   OAUTH_FRONTEND_BASE=https://your-domain
   ```
4. Khởi động lại gateway, trang đăng nhập / đăng ký sẽ tự động xuất hiện "Linux.do Đăng nhập một lần"

## 🧪 Kiểm thử / Lint

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

## 📦 Các phụ thuộc chính

**Backend**：

- [gin-gonic/gin](https://github.com/gin-gonic/gin) — Khung HTTP
- [grpc-ecosystem](https://github.com/grpc-ecosystem) — gRPC + gateway
- [jackc/pgx](https://github.com/jackc/pgx/v5) — Trình điều khiển PostgreSQL
- [redis/go-redis](https://github.com/redis/go-redis) — Khách hàng Redis
- [golang.org/x/oauth2](https://pkg.go.dev/golang.org/x/oauth2) — OAuth2 / PKCE
- [pquerna/otp](https://github.com/pquerna/otp) — TOTP

**Frontend**：

- [Next.js 16](https://nextjs.org/) (App Router + Turbopack)
- [shadcn/ui](https://ui.shadcn.com/) + [Radix](https://www.radix-ui.com/)
- [Tailwind CSS v4](https://tailwindcss.com/)
- [next-auth-csrf](https://github.com/edge-runtime/) edge-safe CSRF

## 📜 Giấy phép

MIT — Xem [LICENSE](./LICENSE)

## 🤝 Đóng góp

Hoan nghênh PR / Issue. Trước khi gửi PR vui lòng:

1. `golangci-lint run` + `gofmt -l .` phải xanh hoàn toàn
2. `go test -race ./...` phải xanh hoàn toàn
3. Thay đổi Web chạy `pnpm lint && pnpm typecheck`
4. Không gửi `.env` / `data/.kek` hoặc bất kỳ file nào chứa mật khẩu thật

## 🔒 Bảo mật

Nếu phát hiện vấn đề bảo mật vui lòng liên hệ trực tiếp maintainer, **không** mở public issue.

---

Được xây dựng với ❤️ bởi [MiChongs](https://github.com/MiChongs)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-08

---