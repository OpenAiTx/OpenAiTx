# Karpov Gateway

> Passerelle API intégrée + console. Backend Go (Gin + gRPC) + frontend Next.js (App Router + shadcn/ui), avec pool d’identifiants, vérification par e-mail, OAuth2 SSO Linux.do, facturation par quota, authentification à deux facteurs TOTP.

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](./LICENSE)
[![Go](https://img.shields.io/badge/Go-1.24+-00ADD8?logo=go)](https://go.dev/)
[![Next.js](https://img.shields.io/badge/Next.js-16-black?logo=next.js)](https://nextjs.org/)

## ✨ Fonctionnalités

- **Passerelle REST unifiée** — Mode monoprocessus ou multi-service, backend gRPC gateway → auth/music/pool/quota/billing/worker déployable indépendamment
- **Pool d’identifiants (chiffré)** — Chiffrement en enveloppe KEK + DEK, AES-256-GCM avec AAD, dérivation de clé maître POOL_KEK_HEX
- **Inscription par e-mail + activation** — Envoi SMTP de code / lien d’activation, double sécurité (code + lien e-mail), bascule automatique vers LogSender si SMTP non configuré
- **Connexion tierce OAuth2** — SSO Linux.do (PKCE S256 + signature HMAC du cookie state), décisions login / liaison / délier en trois états, chiffrement des tokens en base
- **Quota / facturation** — PlanQuotaMiddleware garantit la protection côté gateway, validation interne des services business selon plan + scope
- **Authentification à deux facteurs TOTP** — `pquerna/otp` + protection contre rejouage Redis
- **Logs d’audit** — JSON structuré, fichiers séparés par type, rotation quotidienne
- **CSRF + Session** — Double validation via cookie httpOnly `sid` + en-tête `X-CSRF-Token`
- **Console shadcn/ui** — Next.js 16 App Router + Radix + Tailwind v4

## 🏗 Structure du dépôt

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

## 🚀 Démarrage rapide

### 1. Exigences préalables

| Outil       | Version |
| ----------- | ------- |
| Go          | 1.24+   |
| Node.js     | 20.11+  |
| pnpm        | 9+      |
| Docker      | 24+     |
| PostgreSQL  | 14+     |
| Redis       | 7+      |

### 2. Démarrage des dépendances (Postgres + Redis + pgAdmin)

```bash
cd deploy/compose
cp .env.example .env       # 改强密码！
docker compose up -d
```

### 3. Démarrage du backend Gateway

```bash
cd gateway
cp .env.example .env       # 与 deploy/compose/.env 的 PG/Redis 密码保持一致
go mod download
go run ./cmd/qqmusic-gateway
# 默认 :8080 (HTTP) + :9000 (gRPC)
# 首次启动会在 stderr 打印一个 superadmin 账号 + 临时密码
```

### 4. Démarrage de la console Web

```bash
cd web
cp .env.example .env.local
pnpm install
pnpm dev
# http://localhost:3000
```

## 🐳 Déploiement en production (Docker Compose sur machine unique)

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

Remarques :

- `NEXT_PUBLIC_APP_URL` modifié **doit absolument** être suivi par `docker compose build --no-cache web`, car il est intégré en ligne dans le bundle client
- Après un proxy inverse (Nginx/Caddy), il faut activer `TRUST_PROXY=true`, sinon X-Forwarded-Proto ne fonctionne pas
- Si la KEK change, l'ancien pool d'identifiants / anciens tokens OAuth **deviennent tous illisibles**

## 🔐 OAuth2 (Linux.do) intégration

1. Allez sur [https://connect.linux.do](https://connect.linux.do) pour créer une application
2. L'adresse de callback doit être : `https://your-domain/v1/auth/oauth/linuxdo/callback`
3. Insérez le client_id / client_secret obtenu dans `.env` :
   ```
   OAUTH_LINUXDO_ENABLED=true
   OAUTH_LINUXDO_CLIENT_ID=...
   OAUTH_LINUXDO_CLIENT_SECRET=...
   OAUTH_LINUXDO_MIN_TRUST_LEVEL=1
   OAUTH_PUBLIC_BASE=https://your-domain
   OAUTH_FRONTEND_BASE=https://your-domain
   ```
4. Redémarrez la passerelle, la page de connexion / la page d'inscription affichera automatiquement "Linux.do connexion en un clic"

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

## 📦 Dépendances clés

**Backend** :

- [gin-gonic/gin](https://github.com/gin-gonic/gin) — Framework HTTP
- [grpc-ecosystem](https://github.com/grpc-ecosystem) — gRPC + passerelle
- [jackc/pgx](https://github.com/jackc/pgx/v5) — Pilote PostgreSQL
- [redis/go-redis](https://github.com/redis/go-redis) — Client Redis
- [golang.org/x/oauth2](https://pkg.go.dev/golang.org/x/oauth2) — OAuth2 / PKCE
- [pquerna/otp](https://github.com/pquerna/otp) — TOTP

**Frontend** :

- [Next.js 16](https://nextjs.org/) (App Router + Turbopack)
- [shadcn/ui](https://ui.shadcn.com/) + [Radix](https://www.radix-ui.com/)
- [Tailwind CSS v4](https://tailwindcss.com/)
- [next-auth-csrf](https://github.com/edge-runtime/) CSRF sécurisé pour edge

## 📜 Licence

MIT — voir [LICENSE](./LICENSE)

## 🤝 Contribution

PR / Issue bienvenus. Avant de proposer une PR, veuillez :

1. `golangci-lint run` + `gofmt -l .` tout vert
2. `go test -race ./...` tout vert
3. Pour les modifications Web, exécutez `pnpm lint && pnpm typecheck`
4. Ne pas soumettre `.env` / `data/.kek` ni aucun fichier contenant des mots de passe réels

## 🔒 Sécurité

Pour toute faille de sécurité, contactez directement le mainteneur, **ne pas** ouvrir d’issue publique.

---

Conçu avec ❤️ par [MiChongs](https://github.com/MiChongs)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-04

---