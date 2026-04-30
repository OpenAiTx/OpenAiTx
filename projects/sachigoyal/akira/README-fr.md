# Akira

Un kit de démarrage SaaS moderne construit avec Next.js, Tailwind CSS et shadcn/ui. Authentification, paiements, base de données et email — tout est préconfiguré pour que vous puissiez passer l’installation et commencer à construire.

![Akira](https://raw.githubusercontent.com/sachigoyal/akira/main/./public/og.png)

## Stack

- **Framework :** [Next.js](https://nextjs.org) (App Router)
- **Style :** [Tailwind CSS](https://tailwindcss.com) + [shadcn/ui](https://ui.shadcn.com)
- **Auth :** [Better Auth](https://www.better-auth.com) (Google, GitHub, email)
- **Base de données :** [Neon](https://neon.tech) Postgres + [Drizzle ORM](https://orm.drizzle.team)
- **Paiements :** [Dodo Payments](https://dodopayments.com)
- **Animations :** [Motion](https://motion.dev)
- **Email :** [Resend](https://resend.com) + [React Email](https://react.email)
- **Runtime :** [Bun](https://bun.sh)

## Pour commencer

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

## Structure du projet

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