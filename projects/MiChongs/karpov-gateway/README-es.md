# Karpov Gateway

> Pasarela API integrada + consola. Backend en Go (Gin + gRPC) + frontend en Next.js (App Router + shadcn/ui), con pool de credenciales, verificación por correo, OAuth2 SSO de Linux.do, facturación por cuota, y autenticación de dos factores TOTP.

[![Licencia: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](./LICENSE)
[![Go](https://img.shields.io/badge/Go-1.24+-00ADD8?logo=go)](https://go.dev/)
[![Next.js](https://img.shields.io/badge/Next.js-16-black?logo=next.js)](https://nextjs.org/)

## ✨ Características

- **Pasarela REST unificada** — Modo de proceso único o multi servicio, gateway → auth/music/pool/quota/billing/worker backend gRPC desplegables independientemente
- **Pool de credenciales (encriptado)** — Encriptación de sobre KEK + DEK, AES-256-GCM con AAD, clave maestra derivada POOL_KEK_HEX
- **Registro y activación por correo electrónico** — SMTP para envío de código / enlace de activación, doble seguridad (código + enlace por correo), si SMTP no configurado pasa automáticamente a LogSender
- **Inicio de sesión OAuth2 con terceros** — SSO de Linux.do (PKCE S256 + firma HMAC en cookie de estado), decisiones de tres estados login / vinculación / desvinculación, token encriptado en base de datos
- **Cuotas / Facturación** — PlanQuotaMiddleware protege en capa gateway, validación secundaria interna en servicio de negocio según plan + ámbito
- **Autenticación de dos factores TOTP** — `pquerna/otp` + protección contra reenvío en Redis
- **Registro de auditoría** — JSON estructurado, archivos separados por tipo, rotación diaria
- **CSRF + Sesión** — cookie `sid` httpOnly + doble validación con encabezado `X-CSRF-Token`
- **Consola shadcn/ui** — Next.js 16 App Router + Radix + Tailwind v4

## 🏗 Estructura del repositorio

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

## 🚀 Inicio Rápido

### 1. Requisitos Previos

| Herramienta | Versión |
| ----------- | ------- |
| Go          | 1.24+   |
| Node.js     | 20.11+  |
| pnpm        | 9+      |
| Docker      | 24+     |
| PostgreSQL  | 14+     |
| Redis       | 7+      |

### 2. Iniciar Dependencias (Postgres + Redis + pgAdmin)

```bash
cd deploy/compose
cp .env.example .env       # 改强密码！
docker compose up -d
```
### 3. Iniciar el backend de Gateway


```bash
cd gateway
cp .env.example .env       # 与 deploy/compose/.env 的 PG/Redis 密码保持一致
go mod download
go run ./cmd/qqmusic-gateway
# 默认 :8080 (HTTP) + :9000 (gRPC)
# 首次启动会在 stderr 打印一个 superadmin 账号 + 临时密码
```

### 4. Iniciar la consola web

```bash
cd web
cp .env.example .env.local
pnpm install
pnpm dev
# http://localhost:3000
```

## 🐳 Despliegue de producción (Docker Compose en máquina única)

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

Notas importantes:

- Cambiar `NEXT_PUBLIC_APP_URL` **requiere** ejecutar `docker compose build --no-cache web`, porque se inserta inline en el paquete del cliente
- Después de usar un proxy inverso (Nginx/Caddy) es obligatorio activar `TRUST_PROXY=true`, de lo contrario X-Forwarded-Proto no funcionará
- Si cambia la KEK, todas las credenciales antiguas / tokens OAuth antiguos **serán inaccesibles**

## 🔐 OAuth2 (Linux.do) Integración

1. Visita [https://connect.linux.do](https://connect.linux.do) para registrar una aplicación
2. La URL de callback debe ser: `https://your-domain/v1/auth/oauth/linuxdo/callback`
3. Coloca el client_id / client_secret obtenido en el archivo `.env`:
   ```
   OAUTH_LINUXDO_ENABLED=true
   OAUTH_LINUXDO_CLIENT_ID=...
   OAUTH_LINUXDO_CLIENT_SECRET=...
   OAUTH_LINUXDO_MIN_TRUST_LEVEL=1
   OAUTH_PUBLIC_BASE=https://your-domain
   OAUTH_FRONTEND_BASE=https://your-domain
   ```
4. Reinicie el gateway, la página de inicio de sesión / página de registro mostrará automáticamente "Linux.do inicio de sesión con un clic"

## 🧪 Prueba / Lint

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

## 📦 Dependencias clave

**Backend**：

- [gin-gonic/gin](https://github.com/gin-gonic/gin) — Framework HTTP
- [grpc-ecosystem](https://github.com/grpc-ecosystem) — gRPC + gateway
- [jackc/pgx](https://github.com/jackc/pgx/v5) — Driver de PostgreSQL
- [redis/go-redis](https://github.com/redis/go-redis) — Cliente Redis
- [golang.org/x/oauth2](https://pkg.go.dev/golang.org/x/oauth2) — OAuth2 / PKCE
- [pquerna/otp](https://github.com/pquerna/otp) — TOTP

**Frontend**：

- [Next.js 16](https://nextjs.org/) (App Router + Turbopack)
- [shadcn/ui](https://ui.shadcn.com/) + [Radix](https://www.radix-ui.com/)
- [Tailwind CSS v4](https://tailwindcss.com/)
- [next-auth-csrf](https://github.com/edge-runtime/) CSRF seguro para edge

## 📜 Licencia

MIT — ver [LICENSE](./LICENSE)

## 🤝 Contribuciones

PR / Issues bienvenidos. Antes de enviar PR por favor:

1. `golangci-lint run` + `gofmt -l .` sin errores
2. `go test -race ./...` sin errores
3. Cambios en web ejecutar `pnpm lint && pnpm typecheck`
4. No subir `.env` / `data/.kek` ni ningún archivo con contraseñas reales

## 🔒 Seguridad

Si encuentras problemas de seguridad contacta directamente al mantenedor, **no** abras un issue público.

---

Construido con ❤️ por [MiChongs](https://github.com/MiChongs)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-04

---