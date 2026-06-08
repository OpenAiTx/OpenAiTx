
<div align="right">
  <details>
    <summary >🌐 언어</summary>
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

# 카르포프 게이트웨이

> 통합 API 게이트웨이 + 콘솔. Go 백엔드(Gin + gRPC) + Next.js 프론트엔드(App Router + shadcn/ui), 내장 인증서 풀, 이메일 인증, Linux.do OAuth2 SSO, 할당량 과금, TOTP 2단계 인증 제공.

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](./LICENSE)
[![Go](https://img.shields.io/badge/Go-1.24+-00ADD8?logo=go)](https://go.dev/)
[![Next.js](https://img.shields.io/badge/Next.js-16-black?logo=next.js)](https://nextjs.org/)

## ✨ 기능

- **통합 REST 게이트웨이** — 단일 프로세스 또는 다중 서비스 모드, gateway → auth/music/pool/quota/billing/worker gRPC 백엔드 독립 배포 가능
- **자격 증명 풀 (암호화)** — KEK + DEK 봉투 암호화, AES-256-GCM with AAD, POOL_KEK_HEX 마스터 키 파생
- **이메일 가입 + 활성화** — SMTP 코드 전송 / 활성화 링크, 이중 보호(인증 코드 + 이메일 링크), SMTP 미설정 시 자동으로 LogSender로 강등
- **OAuth2 제3자 로그인** — Linux.do SSO(PKCE S256 + HMAC 서명 state 쿠키), 로그인/연동/해제 3상태 판단, 토큰 암호화 저장
- **쿼터 / 과금** — PlanQuotaMiddleware가 gateway 레이어에서 기본 제공, business service 내부에서 plan + scope 이중 검증
- **TOTP 2단계** — `pquerna/otp` + Redis 재사용 방지
- **감사 로그** — 구조화된 JSON, type별 파일 분리, 일 단위 롤링
- **CSRF + 세션** — `sid` httpOnly 쿠키 + `X-CSRF-Token` 헤더 이중 검증
- **shadcn/ui 콘솔** — Next.js 16 App Router + Radix + Tailwind v4

## 🏗 저장소 구조

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
## 🚀 빠른 시작

### 1. 사전 요구사항

| 도구       | 버전    |
| ---------- | ------- |
| Go         | 1.24+   |
| Node.js    | 20.11+  |
| pnpm       | 9+      |
| Docker     | 24+     |
| PostgreSQL | 14+     |
| Redis      | 7+      |

### 2. 의존성 시작 (Postgres + Redis + pgAdmin)


```bash
cd deploy/compose
cp .env.example .env       # 改强密码！
docker compose up -d
```

### 3. Gateway 백엔드 시작하기

```bash
cd gateway
cp .env.example .env       # 与 deploy/compose/.env 的 PG/Redis 密码保持一致
go mod download
go run ./cmd/qqmusic-gateway
# 默认 :8080 (HTTP) + :9000 (gRPC)
# 首次启动会在 stderr 打印一个 superadmin 账号 + 临时密码
```

### 4. 웹 콘솔 시작하기

```bash
cd web
cp .env.example .env.local
pnpm install
pnpm dev
# http://localhost:3000
```

## 🐳 생산 배포 (Docker Compose 단일 머신)

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
주의사항：

- `NEXT_PUBLIC_APP_URL`를 변경한 경우 **반드시** `docker compose build --no-cache web`를 실행해야 합니다. 클라이언트 번들에 인라인 되기 때문입니다.
- 리버스 프록시(Nginx/Caddy) 뒤에서는 반드시 `TRUST_PROXY=true`를 설정해야 하며, 그렇지 않으면 X-Forwarded-Proto가 작동하지 않습니다.
- KEK가 변경되면 이전 자격 증명 풀 / 이전 OAuth 토큰은 **모두 읽을 수 없습니다**

## 🔐 OAuth2 (Linux.do) 연동

1. [https://connect.linux.do](https://connect.linux.do)에서 애플리케이션을 신청합니다.
2. 콜백 주소를 다음과 같이 입력합니다: `https://your-domain/v1/auth/oauth/linuxdo/callback`
3. 받은 client_id / client_secret를 `.env`에 작성합니다:

   ```
   OAUTH_LINUXDO_ENABLED=true
   OAUTH_LINUXDO_CLIENT_ID=...
   OAUTH_LINUXDO_CLIENT_SECRET=...
   OAUTH_LINUXDO_MIN_TRUST_LEVEL=1
   OAUTH_PUBLIC_BASE=https://your-domain
   OAUTH_FRONTEND_BASE=https://your-domain
   ```
4. 게이트웨이를 재시작하면 로그인 페이지 / 회원가입 페이지에 자동으로 "Linux.do 원클릭 로그인"이 표시됩니다.

## 🧪 테스트 / 린트

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

## 📦 주요 의존성

**백엔드**：

- [gin-gonic/gin](https://github.com/gin-gonic/gin) — HTTP 프레임워크
- [grpc-ecosystem](https://github.com/grpc-ecosystem) — gRPC + 게이트웨이
- [jackc/pgx](https://github.com/jackc/pgx/v5) — PostgreSQL 드라이버
- [redis/go-redis](https://github.com/redis/go-redis) — Redis 클라이언트
- [golang.org/x/oauth2](https://pkg.go.dev/golang.org/x/oauth2) — OAuth2 / PKCE
- [pquerna/otp](https://github.com/pquerna/otp) — TOTP

**프론트엔드**：

- [Next.js 16](https://nextjs.org/) (앱 라우터 + Turbopack)
- [shadcn/ui](https://ui.shadcn.com/) + [Radix](https://www.radix-ui.com/)
- [Tailwind CSS v4](https://tailwindcss.com/)
- [next-auth-csrf](https://github.com/edge-runtime/) 에지 안전 CSRF

## 📜 라이선스

MIT — [LICENSE](./LICENSE) 참조

## 🤝 기여

PR / Issue 환영합니다. PR 제출 전 다음을 확인하세요：

1. `golangci-lint run` + `gofmt -l .` 모두 성공
2. `go test -race ./...` 모두 성공
3. 웹 변경 시 `pnpm lint && pnpm typecheck` 실행
4. `.env` / `data/.kek` 또는 실제 비밀번호가 포함된 파일을 제출하지 마세요

## 🔒 보안

보안 문제 발견 시 maintainer에게 직접 연락해 주세요, **공개 이슈는 삼가해 주세요**.

---

❤️ [MiChongs](https://github.com/MiChongs)가 빌드했습니다.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-08

---