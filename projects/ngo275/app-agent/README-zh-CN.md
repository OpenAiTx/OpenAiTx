# AppAgent

<div align="center">
  <img width="200" src="https://github.com/user-attachments/assets/7f86c185-0fc1-46c3-888a-c915602f27ee" alt="AppAgent" />
  <h2>从ASO到发布，一切流畅无阻。</h2>
</div>

[AppAgent](https://app-agent.ai) 是一款以 AI 为核心的工具，管理您的应用 ASO 和发布流程。AppAgent 是 App Radar、AppTweak、AppFollow 和 Sensor Tower 等 ASO 工具的开源替代品。AppAgent 以 AI 为先，自动运行。

https://github.com/user-attachments/assets/e34baeef-ceab-4fdb-9a7c-e6a5ab80dbba

---

## 为什么选择 AppAgent？

得益于 AI 的快速发展，创建应用从未如此简单。然而，流行的 ASO 工具（App Radar、AppTweak、Sensor Tower 等）对独立开发者和小团队来说仍然价格昂贵且过于复杂。真正需要的是一个能够自主处理一切的平台——从多语言关键词选择到 ASO 内容生成——不仅简化关键词管理，更优化整个发布流程。

App Store Connect 也为发布工作流增加了摩擦。因此，我采用了以 AI 为先的方法，从零开始构建了 AppAgent，重新构想了 ASO 和应用发布如何在一个无缝高效的平台中协同工作。

---

## 功能

### 自主ASO（测试版）

https://github.com/user-attachments/assets/09172b8c-c690-42b2-a394-8b65e80c25ad

- **自主关键词研究**
  - 不再需要手动搜索关键词。
  - 自动运行，无论地区和市场如何。
  - 自动寻找竞争对手，并由您管理自动整理的竞争对手列表。
  - 基于竞争对手，使用 AI 研究关键词并最终确定列表。
- **AI 驱动的商店优化**
  - 根据您的应用元数据即时提供建议。
  - 支持所有语言的 ASO 友好内容生成。
  - 不需要营销专家，只需点击即可完成。

### 发布管理

https://github.com/user-attachments/assets/9148a814-ae24-4005-adb6-d113933b67d3
- **本地化您的发布说明**
  - 生成所有语言的发布说明。
  - 不再需要为所有支持的语言使用 ChatGPT 复制粘贴。
- **商店同步**
  - 与 App Store Connect 同步数据。Google Play 即将支持。
  - 不再需要在 App Store Connect 上手动输入数据。
  - 一键推送所有更改到 App Store Connect。
  - 一键提交应用审核。

---

## 技术栈

- [Next.js](https://nextjs.org/) – 框架
- [TypeScript](https://www.typescriptlang.org/) – 语言
- [Tailwind](https://tailwindcss.com/) – CSS
- [shadcn/ui](https://ui.shadcn.com) - UI 组件
- [Prisma](https://prisma.io) - ORM [![Made with Prisma](https://made-with.prisma.io/dark.svg)](https://prisma.io)
- [PostgreSQL](https://www.postgresql.org/) - 数据库
- [NextAuth.js](https://next-auth.js.org/) – 认证
- [PostHog](https://posthog.com/) – 分析
- [Resend](https://resend.com) – 邮件
- [Stripe](https://stripe.com) – 支付
- [Vercel](https://vercel.com/) – 托管

---

## 快速开始

### 1. 克隆仓库


```bash
git clone https://github.com/ngo275/app-agent.git
```

### 2. 复制 .env.sample 到 .env 并更改数值

```bash
cp .env.sample .env
```
以下是您需要设置的环境变量列表：

- `NEXTAUTH_SECRET`  
  - NextAuth.js 的密钥。您可以使用 `openssl rand -base64 32` 生成一个随机字符串。  
- `NEXTAUTH_URL`  
  - 您应用的 URL。例如，`http://localhost:3000`。  
- `NEXT_PUBLIC_BASE_URL`  
  - 您应用的 URL。例如，`http://localhost:3000`。  
- `NEXT_PUBLIC_MARKETING_URL`  
  - 您的营销页面的 URL。例如，`http://localhost:3000`。  
- `GOOGLE_CLIENT_ID`  
  - 您 Google OAuth 应用的客户端 ID。用于 Google 登录。如果不使用 Google 登录，则不必设置。  
- `GOOGLE_CLIENT_SECRET`  
  - 您 Google OAuth 应用的客户端密钥。用于 Google 登录。如果不使用 Google 登录，则不必设置。  
- `RESEND_API_KEY`  
  - 您 Resend 账户的 API 密钥。用于发送邮件。  
- `NEXT_PUBLIC_POSTHOG_KEY`  
  - 您 PostHog 账户的密钥。用于分析。如果不使用 PostHog，则不必设置。  
- `OPENAI_API_KEY`  
  - 您 OpenAI 账户的 API 密钥。用于调用大型语言模型（LLM）。  
- `UPSTASH_REDIS_REST_URL`  
  - 您 Upstash 账户的 URL。用于缓存。  
- `UPSTASH_REDIS_REST_TOKEN`  
  - 您 Upstash 账户的令牌。用于缓存。  
- `NEXT_PUBLIC_FREE_PLAN_ENABLED`  
  - 是否启用免费计划。设置为 `true` 以启用免费计划。  
- `NEXT_PUBLIC_STRIPE_PUBLISHABLE_KEY`  
  - 您 Stripe 账户的发布密钥。用于支付。如果您将 `NEXT_PUBLIC_FREE_PLAN_ENABLED` 设置为 `true`，则不必设置。  
- `STRIPE_SECRET_KEY`  
  - 您 Stripe 账户的密钥。用于支付。如果您将 `NEXT_PUBLIC_FREE_PLAN_ENABLED` 设置为 `true`，则不必设置。  
- `STRIPE_WEBHOOK_SECRET`  
  - 您 Stripe 账户的 Webhook 密钥。用于 Webhook。如果您将 `NEXT_PUBLIC_FREE_PLAN_ENABLED` 设置为 `true`，则不必设置。  
- `STRIPE_PRO_PRICE_ID`  
  - 您 Stripe 专业版计划的价格 ID。用于支付。如果您将 `NEXT_PUBLIC_FREE_PLAN_ENABLED` 设置为 `true`，则不必设置。  
- `DATABASE_URL`  
  - 您 PostgreSQL 数据库的 URL。除本地机器外，您可以使用 [Supabase](https://supabase.com/) 或 [Neon](https://neon.tech/) 的免费服务。  

### 3. 安装依赖项


```bash
yarn

# Or with NPM
npm install
```

### 4. 设置数据库

```bash
yarn prisma generate
yarn prisma migrate deploy

# Or with NPM
npm run prisma generate
npm run prisma migrate deploy
```

### 5. 运行开发服务器

```bash
yarn dev

# Or with NPM
npm run dev
```

访问 [http://localhost:3000](http://localhost:3000) 查看应用。

---

## 贡献

欢迎贡献！请随时提交 PR。

如果您想贡献，请先 fork 仓库并提交 PR。

---

## 许可证

AppAgent 是开源的，遵循 GNU Affero 通用公共许可证第 3 版（AGPLv3）或更高版本。您可以在[这里](https://github.com/ngo275/app-agent/blob/main/LICENSE)找到许可证。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-15

---