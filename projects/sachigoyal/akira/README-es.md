# Akira

Un kit de inicio SaaS moderno construido con Next.js, Tailwind CSS y shadcn/ui. Autenticación, pagos, base de datos y correo electrónico — todo preconfigurado para que puedas omitir la configuración y comenzar a construir.

![Akira](https://raw.githubusercontent.com/sachigoyal/akira/main/./public/og.png)

## Stack

- **Framework:** [Next.js](https://nextjs.org) (App Router)
- **Estilizado:** [Tailwind CSS](https://tailwindcss.com) + [shadcn/ui](https://ui.shadcn.com)
- **Autenticación:** [Better Auth](https://www.better-auth.com) (Google, GitHub, correo electrónico)
- **Base de datos:** [Neon](https://neon.tech) Postgres + [Drizzle ORM](https://orm.drizzle.team)
- **Pagos:** [Dodo Payments](https://dodopayments.com)
- **Animaciones:** [Motion](https://motion.dev)
- **Correo electrónico:** [Resend](https://resend.com) + [React Email](https://react.email)
- **Runtime:** [Bun](https://bun.sh)

## Comenzando

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

## Estructura del Proyecto

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