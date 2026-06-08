
<div align="right">
  <details>
    <summary >🌐 Язык</summary>
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

> Интегрированный API-шлюз и консоль. Бэкенд на Go (Gin + gRPC) + фронтенд на Next.js (App Router + shadcn/ui), встроенный пул учетных данных, верификация по email, OAuth2 SSO через Linux.do, тарификация по квотам, двухфакторная аутентификация TOTP.

[![Лицензия: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](./LICENSE)
[![Go](https://img.shields.io/badge/Go-1.24+-00ADD8?logo=go)](https://go.dev/)
[![Next.js](https://img.shields.io/badge/Next.js-16-black?logo=next.js)](https://nextjs.org/)

## ✨ Возможности

- **Единый REST шлюз** — однопроцессный или мультисервисный режим, gateway → auth/music/pool/quota/billing/worker gRPC-бэкенды могут разворачиваться отдельно
- **Хранилище учетных данных (зашифрованное)** — конвертное шифрование KEK + DEK, AES-256-GCM с AAD, производное главного ключа POOL_KEK_HEX
- **Регистрация по email + активация** — отправка кода/ссылки через SMTP, двойная защита (код подтверждения + ссылка), при отсутствии SMTP автоматически переводится в LogSender
- **Вход через OAuth2** — Linux.do SSO (PKCE S256 + HMAC-подписанный state cookie), три состояния (вход/привязка/отвязка), токены шифруются при сохранении
- **Квоты / биллинг** — PlanQuotaMiddleware на уровне gateway, бизнес-сервисы проводят вторичную проверку по plan + scope
- **TOTP двухфакторная аутентификация** — `pquerna/otp` + защита от повторного использования через Redis
- **Аудит-логи** — структурированный JSON, файлы по типу, ежедневная ротация
- **CSRF + сессия** — httpOnly cookie `sid` + двойная проверка заголовка `X-CSRF-Token`
- **shadcn/ui консоль** — Next.js 16 App Router + Radix + Tailwind v4

## 🏗 Структура репозитория

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

## 🚀 Быстрый старт

### 1. Предварительные требования

| Инструмент  | Версия  |
| ----------- | ------- |
| Go          | 1.24+   |
| Node.js     | 20.11+  |
| pnpm        | 9+      |
| Docker      | 24+     |
| PostgreSQL  | 14+     |
| Redis       | 7+      |

### 2. Запуск зависимостей (Postgres + Redis + pgAdmin)

```bash
cd deploy/compose
cp .env.example .env       # 改强密码！
docker compose up -d
```

### 3. Запуск Gateway backend

```bash
cd gateway
cp .env.example .env       # 与 deploy/compose/.env 的 PG/Redis 密码保持一致
go mod download
go run ./cmd/qqmusic-gateway
# 默认 :8080 (HTTP) + :9000 (gRPC)
# 首次启动会在 stderr 打印一个 superadmin 账号 + 临时密码
```

### 4. Запуск веб-консоли

```bash
cd web
cp .env.example .env.local
pnpm install
pnpm dev
# http://localhost:3000
```

## 🐳 Производственное развертывание (Docker Compose на одном сервере)

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

Важные замечания:

- После изменения `NEXT_PUBLIC_APP_URL` **обязательно** выполните `docker compose build --no-cache web`, так как этот параметр будет встроен в клиентский бандл
- При использовании обратного прокси (Nginx/Caddy) обязательно установите `TRUST_PROXY=true`, иначе X-Forwarded-Proto не будет работать
- После изменения KEK все старые пулы учетных данных / старые OAuth токены **станут недоступны для чтения**

## 🔐 Подключение OAuth2 (Linux.do)

1. Перейдите на [https://connect.linux.do](https://connect.linux.do) для регистрации приложения
2. В качестве callback-адреса укажите: `https://your-domain/v1/auth/oauth/linuxdo/callback`
3. Полученные client_id / client_secret пропишите в `.env`:
   ```
   OAUTH_LINUXDO_ENABLED=true
   OAUTH_LINUXDO_CLIENT_ID=...
   OAUTH_LINUXDO_CLIENT_SECRET=...
   OAUTH_LINUXDO_MIN_TRUST_LEVEL=1
   OAUTH_PUBLIC_BASE=https://your-domain
   OAUTH_FRONTEND_BASE=https://your-domain
   ```
4. Перезапустите gateway, на странице входа / регистрации автоматически появится "Linux.do One-click Login"

## 🧪 Тестирование / Lint

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

## 📦 Ключевые зависимости

**Бэкенд**:

- [gin-gonic/gin](https://github.com/gin-gonic/gin) — HTTP-фреймворк
- [grpc-ecosystem](https://github.com/grpc-ecosystem) — gRPC + gateway
- [jackc/pgx](https://github.com/jackc/pgx/v5) — драйвер PostgreSQL
- [redis/go-redis](https://github.com/redis/go-redis) — клиент Redis
- [golang.org/x/oauth2](https://pkg.go.dev/golang.org/x/oauth2) — OAuth2 / PKCE
- [pquerna/otp](https://github.com/pquerna/otp) — TOTP

**Фронтенд**:

- [Next.js 16](https://nextjs.org/) (App Router + Turbopack)
- [shadcn/ui](https://ui.shadcn.com/) + [Radix](https://www.radix-ui.com/)
- [Tailwind CSS v4](https://tailwindcss.com/)
- [next-auth-csrf](https://github.com/edge-runtime/) edge-safe CSRF

## 📜 Лицензия

MIT — см. [LICENSE](./LICENSE)

## 🤝 Вклад

PR / Issue приветствуются. Перед созданием PR:

1. `golangci-lint run` + `gofmt -l .` — всё зелёное
2. `go test -race ./...` — всё зелёное
3. Для изменений Web запустить `pnpm lint && pnpm typecheck`
4. Не добавляйте `.env` / `data/.kek` или любые файлы с настоящими паролями

## 🔒 Безопасность

При обнаружении проблем безопасности свяжитесь с maintainer напрямую, **не** создавайте public issue.

---

Сделано с ❤️ [MiChongs](https://github.com/MiChongs)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-08

---