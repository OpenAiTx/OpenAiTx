# Akira

A modern SaaS starter kit built with Next.js, Tailwind CSS, and shadcn/ui. Auth, payments, database, and email — all pre-configured so you can skip the setup and start building.

![Akira](https://raw.githubusercontent.com/sachigoyal/akira/main/./public/og.png)

## Stack

- **Framework:** [Next.js](https://nextjs.org) (App Router)
- **Styling:** [Tailwind CSS](https://tailwindcss.com) + [shadcn/ui](https://ui.shadcn.com)
- **Auth:** [Better Auth](https://www.better-auth.com) (Google, GitHub, email)
- **Database:** [Neon](https://neon.tech) Postgres + [Drizzle ORM](https://orm.drizzle.team)
- **Payments:** [Dodo Payments](https://dodopayments.com)
- **Animations:** [Motion](https://motion.dev)
- **Email:** [Resend](https://resend.com) + [React Email](https://react.email)
- **Runtime:** [Bun](https://bun.sh)

## Getting Started

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

## Project Structure

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