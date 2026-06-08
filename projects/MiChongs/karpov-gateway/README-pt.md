
<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
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

> Gateway de API integrado + Console. Backend em Go (Gin + gRPC) + Frontend Next.js (App Router + shadcn/ui), com pool de credenciais, verificação por e-mail, OAuth2 SSO via Linux.do, cobrança por cotas, autenticação em duas etapas TOTP.

[![Licença: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](./LICENSE)
[![Go](https://img.shields.io/badge/Go-1.24+-00ADD8?logo=go)](https://go.dev/)
[![Next.js](https://img.shields.io/badge/Next.js-16-black?logo=next.js)](https://nextjs.org/)

## ✨ Funcionalidades

- **Gateway REST unificado** — Modo de processo único ou multi-serviço, gateway → auth/music/pool/quota/billing/worker backends gRPC podem ser implantados de forma independente
- **Pool de credenciais (criptografado)** — Criptografia envelope KEK + DEK, AES-256-GCM com AAD, derivação da chave mestra POOL_KEK_HEX
- **Registro por e-mail + ativação** — SMTP para envio de código/link de ativação, dupla proteção (código de verificação + link por e-mail), se SMTP não configurado faz downgrade automático para LogSender
- **Login por terceiros OAuth2** — Linux.do SSO (PKCE S256 + cookie state assinado com HMAC), decisão em três estados: login/vincular/desvincular, tokens criptografados no banco
- **Quota / Billing** — PlanQuotaMiddleware faz proteção na camada gateway, validação secundária interna do serviço de negócios por plano + escopo
- **TOTP em dois fatores** — `pquerna/otp` + proteção contra replay com Redis
- **Log de auditoria** — JSON estruturado, arquivos separados por tipo, rotação diária
- **CSRF + Sessão** — Cookie `sid` httpOnly + validação dupla no cabeçalho `X-CSRF-Token`
- **Console shadcn/ui** — Next.js 16 App Router + Radix + Tailwind v4

## 🏗 Estrutura do repositório

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

## 🚀 Início Rápido

### 1. Requisitos prévios

| Ferramenta | Versão  |
| ---------- | ------- |
| Go         | 1.24+   |
| Node.js    | 20.11+  |
| pnpm       | 9+      |
| Docker     | 24+     |
| PostgreSQL | 14+     |
| Redis      | 7+      |

### 2. Iniciar dependências (Postgres + Redis + pgAdmin)

```bash
cd deploy/compose
cp .env.example .env       # 改强密码！
docker compose up -d
```

### 3. Iniciar o backend do Gateway

```bash
cd gateway
cp .env.example .env       # 与 deploy/compose/.env 的 PG/Redis 密码保持一致
go mod download
go run ./cmd/qqmusic-gateway
# 默认 :8080 (HTTP) + :9000 (gRPC)
# 首次启动会在 stderr 打印一个 superadmin 账号 + 临时密码
```

### 4. Inicie o Console Web

```bash
cd web
cp .env.example .env.local
pnpm install
pnpm dev
# http://localhost:3000
```

## 🐳 Deploy de Produção (Docker Compose em máquina única)

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

Observações:

- Ao alterar o `NEXT_PUBLIC_APP_URL`, é **obrigatório** rodar `docker compose build --no-cache web`, pois ele será incluído diretamente no client bundle
- Após usar proxy reverso (Nginx/Caddy), é obrigatório ativar `TRUST_PROXY=true`, caso contrário o X-Forwarded-Proto não funcionará
- Após alterar o KEK, o antigo pool de credenciais / antigos tokens OAuth **não poderão mais ser lidos**

## 🔐 Integração OAuth2 (Linux.do)

1. Acesse [https://connect.linux.do](https://connect.linux.do) para registrar seu aplicativo
2. Defina o endereço de callback como: `https://your-domain/v1/auth/oauth/linuxdo/callback`
3. Copie o client_id / client_secret obtido para o arquivo `.env`:
   ```
   OAUTH_LINUXDO_ENABLED=true
   OAUTH_LINUXDO_CLIENT_ID=...
   OAUTH_LINUXDO_CLIENT_SECRET=...
   OAUTH_LINUXDO_MIN_TRUST_LEVEL=1
   OAUTH_PUBLIC_BASE=https://your-domain
   OAUTH_FRONTEND_BASE=https://your-domain
   ```
4. Reinicie o gateway, a página de login / registro exibirá automaticamente "Linux.do Login com um clique"

## 🧪 Teste / Lint

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

## 📦 Dependências principais

**Backend**:

- [gin-gonic/gin](https://github.com/gin-gonic/gin) — Framework HTTP
- [grpc-ecosystem](https://github.com/grpc-ecosystem) — gRPC + gateway
- [jackc/pgx](https://github.com/jackc/pgx/v5) — Driver PostgreSQL
- [redis/go-redis](https://github.com/redis/go-redis) — Cliente Redis
- [golang.org/x/oauth2](https://pkg.go.dev/golang.org/x/oauth2) — OAuth2 / PKCE
- [pquerna/otp](https://github.com/pquerna/otp) — TOTP

**Frontend**:

- [Next.js 16](https://nextjs.org/) (App Router + Turbopack)
- [shadcn/ui](https://ui.shadcn.com/) + [Radix](https://www.radix-ui.com/)
- [Tailwind CSS v4](https://tailwindcss.com/)
- [next-auth-csrf](https://github.com/edge-runtime/) CSRF seguro para edge

## 📜 Licença

MIT — veja [LICENSE](./LICENSE)

## 🤝 Contribuindo

PR / Issue são bem-vindos. Antes de enviar PR:

1. `golangci-lint run` + `gofmt -l .` tudo verde
2. `go test -race ./...` tudo verde
3. Alterações Web rode `pnpm lint && pnpm typecheck`
4. Não envie `.env` / `data/.kek` ou qualquer arquivo contendo senhas reais

## 🔒 Segurança

Em caso de problemas de segurança, contate diretamente o maintainer, **não** abra issue pública.

---

Construído com ❤️ por [MiChongs](https://github.com/MiChongs)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-08

---