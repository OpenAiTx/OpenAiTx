# Akira

Next.js, Tailwind CSS, 그리고 shadcn/ui로 구축된 현대적인 SaaS 스타터 키트입니다. 인증, 결제, 데이터베이스, 이메일 — 모두 미리 구성되어 있어 설정을 건너뛰고 바로 개발을 시작할 수 있습니다.

![Akira](https://raw.githubusercontent.com/sachigoyal/akira/main/./public/og.png)

## 스택

- **프레임워크:** [Next.js](https://nextjs.org) (앱 라우터)
- **스타일링:** [Tailwind CSS](https://tailwindcss.com) + [shadcn/ui](https://ui.shadcn.com)
- **인증:** [Better Auth](https://www.better-auth.com) (Google, GitHub, 이메일)
- **데이터베이스:** [Neon](https://neon.tech) Postgres + [Drizzle ORM](https://orm.drizzle.team)
- **결제:** [Dodo Payments](https://dodopayments.com)
- **애니메이션:** [Motion](https://motion.dev)
- **이메일:** [Resend](https://resend.com) + [React Email](https://react.email)
- **런타임:** [Bun](https://bun.sh)

## 시작하기

```bash
# Install dependencies
bun install

# Set up environment variables
cp .env.example .env

# Run database migrations
bunx drizzle-kit push

# Start the dev server
bun dev
```

## 프로젝트 구조

```
src/
├── app/          # Next.js App Router pages and API routes
├── components/   # React components (UI, auth, email templates)
├── db/           # Drizzle schema and migrations
└── lib/          # Auth config, utilities
```

## License

[MIT](LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-30

---