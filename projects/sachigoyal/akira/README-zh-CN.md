# Akira

一个使用 Next.js、Tailwind CSS 和 shadcn/ui 构建的现代 SaaS 启动套件。身份验证、支付、数据库和电子邮件——全部预配置，让你跳过设置，直接开始构建。

![Akira](https://raw.githubusercontent.com/sachigoyal/akira/main/./public/og.png)

## 技术栈

- **框架：** [Next.js](https://nextjs.org)（App Router）
- **样式：** [Tailwind CSS](https://tailwindcss.com) + [shadcn/ui](https://ui.shadcn.com)
- **身份验证：** [Better Auth](https://www.better-auth.com)（Google、GitHub、邮箱）
- **数据库：** [Neon](https://neon.tech) Postgres + [Drizzle ORM](https://orm.drizzle.team)
- **支付：** [Dodo Payments](https://dodopayments.com)
- **动画：** [Motion](https://motion.dev)
- **邮件：** [Resend](https://resend.com) + [React Email](https://react.email)
- **运行时：** [Bun](https://bun.sh)

## 快速开始

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

## 项目结构

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