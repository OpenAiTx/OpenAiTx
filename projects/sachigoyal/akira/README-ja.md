# Akira

Next.js、Tailwind CSS、shadcn/uiで構築されたモダンなSaaSスターターキット。認証、決済、データベース、メールがすべて事前設定されているため、セットアップをスキップしてすぐに開発を始められます。

![Akira](https://raw.githubusercontent.com/sachigoyal/akira/main/./public/og.png)

## スタック

- **フレームワーク:** [Next.js](https://nextjs.org)（App Router）
- **スタイリング:** [Tailwind CSS](https://tailwindcss.com) + [shadcn/ui](https://ui.shadcn.com)
- **認証:** [Better Auth](https://www.better-auth.com)（Google、GitHub、メール）
- **データベース:** [Neon](https://neon.tech) Postgres + [Drizzle ORM](https://orm.drizzle.team)
- **決済:** [Dodo Payments](https://dodopayments.com)
- **アニメーション:** [Motion](https://motion.dev)
- **メール:** [Resend](https://resend.com) + [React Email](https://react.email)
- **ランタイム:** [Bun](https://bun.sh)

## はじめに

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

## プロジェクト構成

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