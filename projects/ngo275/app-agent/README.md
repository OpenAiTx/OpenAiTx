# AppAgent

<div align="center">
  <img width="200" src="https://github.com/user-attachments/assets/7f86c185-0fc1-46c3-888a-c915602f27ee" alt="AppAgent" />
  <h2>From ASO to Release, All Streamlined.</h2>
</div>

[AppAgent](https://app-agent.ai) is an AI-first tool that manages your app's ASO and release process. AppAgent is an open-source alternative to ASO tools, such as App Radar, AppTweak, AppFollow, and Sensor Tower. AppAgent is AI-first and works autonomously.

https://github.com/user-attachments/assets/e34baeef-ceab-4fdb-9a7c-e6a5ab80dbba

---

## Why AppAgent?

Thanks to rapid AI advancements, creating an app has never been easier. Yet popular ASO tools (App Radar, AppTweak, Sensor Tower, etc.) remain prohibitively expensive and unnecessarily complex for indie developers and small teams. What’s truly needed is a platform that autonomously handles everything—from multilingual keyword selection to ASO content generation—streamlining not just keywords, but the entire release process.

App Store Connect also introduced friction into the release workflow. That’s why I took an AI-first approach and built AppAgent from the ground up, reimagining how ASO and app releases should work together in one seamless, efficient platform.

---

## Features

### Autonomous ASO (Beta)

https://github.com/user-attachments/assets/09172b8c-c690-42b2-a394-8b65e80c25ad

- **Autonomous keyword research**
  - No more manual keyword hunting.
  - Run autonomously, regardless of locales and markets.
  - Go find competitors and have you manage the auto-curated competitor list.
  - Research keywords and finalize the list with AI based on the competitors.
- **AI-powered store optimization**
  - Instant suggestions based on your app's metadata.
  - ASO friendly contents generation for all languages.
  - No expert-level marketing needed, just click and go.

### Release Management

https://github.com/user-attachments/assets/9148a814-ae24-4005-adb6-d113933b67d3

- **Localize your release notes**
  - Generate release notes in all languages.
  - No more ChatGPT copy-pasting for all languages you support.
- **Store synchronization**
  - Sync data with App Store Connect. Google Play is coming soon.
  - No more manual data entry on App Store Connect.
  - Push all changes to App Store Connect with a single click.
  - Submit to app review with a single click.

---

## Tech Stack

- [Next.js](https://nextjs.org/) – Framework
- [TypeScript](https://www.typescriptlang.org/) – Language
- [Tailwind](https://tailwindcss.com/) – CSS
- [shadcn/ui](https://ui.shadcn.com) - UI Components
- [Prisma](https://prisma.io) - ORM [![Made with Prisma](https://made-with.prisma.io/dark.svg)](https://prisma.io)
- [PostgreSQL](https://www.postgresql.org/) - Database
- [NextAuth.js](https://next-auth.js.org/) – Authentication
- [PostHog](https://posthog.com/) – Analytics
- [Resend](https://resend.com) – Email
- [Stripe](https://stripe.com) – Payments
- [Vercel](https://vercel.com/) – Hosting

---

## Getting Started

### 1. Clone the repository

```bash
git clone https://github.com/ngo275/app-agent.git
```

### 2. Copy .env.sample to .env and change the values

```bash
cp .env.sample .env
```

Here's the list of environment variables you need to set:

- `NEXTAUTH_SECRET`
  - A secret key for NextAuth.js. You can generate a random string using `openssl rand -base64 32`.
- `NEXTAUTH_URL`
  - The URL of your app. For example, `http://localhost:3000`.
- `NEXT_PUBLIC_BASE_URL`
  - The URL of your app. For example, `http://localhost:3000`.
- `NEXT_PUBLIC_MARKETING_URL`
  - The URL of your marketing page. For example, `http://localhost:3000`.
- `GOOGLE_CLIENT_ID`
  - The client ID of your Google OAuth application. Used for Google Login. Not necessary if you don't use Google Login.
- `GOOGLE_CLIENT_SECRET`
  - The client secret of your Google OAuth application. Used for Google Login. Not necessary if you don't use Google Login.
- `RESEND_API_KEY`
  - The API key of your Resend account. Used for sending emails.
- `NEXT_PUBLIC_POSTHOG_KEY`
  - The key of your PostHog account. Used for analytics. Not necessary if you don't use PostHog.
- `OPENAI_API_KEY`
  - The API key of your OpenAI account. Used for LLM usage.
- `UPSTASH_REDIS_REST_URL`
  - The URL of your Upstash account. Used for caching.
- `UPSTASH_REDIS_REST_TOKEN`
  - The token of your Upstash account. Used for caching.
- `NEXT_PUBLIC_FREE_PLAN_ENABLED`
  - Whether the free plan is enabled. Set to `true` to enable the free plan.
- `NEXT_PUBLIC_STRIPE_PUBLISHABLE_KEY`
  - The publishable key of your Stripe account. Used for payments. If you set `NEXT_PUBLIC_FREE_PLAN_ENABLED` to `true`, this is not necessary.
- `STRIPE_SECRET_KEY`
  - The secret key of your Stripe account. Used for payments. If you set `NEXT_PUBLIC_FREE_PLAN_ENABLED` to `true`, this is not necessary.
- `STRIPE_WEBHOOK_SECRET`
  - The webhook secret of your Stripe account. Used for webhooks. If you set `NEXT_PUBLIC_FREE_PLAN_ENABLED` to `true`, this is not necessary.
- `STRIPE_PRO_PRICE_ID`
  - The price ID of your Stripe Pro plan. Used for payments. If you set `NEXT_PUBLIC_FREE_PLAN_ENABLED` to `true`, this is not necessary.
- `DATABASE_URL`
  - The URL of your PostgreSQL database. Beside a local machine, you can use [Supabase](https://supabase.com/) or [Neon](https://neon.tech/) for free services.

### 3. Install dependencies

```bash
yarn

# Or with NPM
npm install
```

### 4. Set up DB

```bash
yarn prisma generate
yarn prisma migrate deploy

# Or with NPM
npm run prisma generate
npm run prisma migrate deploy
```

### 5. Run the development server

```bash
yarn dev

# Or with NPM
npm run dev
```

Visit [http://localhost:3000](http://localhost:3000) to see the app.

---

## Contributing

Contributions are welcome! Please feel free to submit a PR.

If you'd like to contribute, please fork the repository and submit a PR.

---

## License

AppAgent is open-source under the GNU Affero General Public License Version 3 (AGPLv3) or any later version. You can find it [here](https://github.com/ngo275/app-agent/blob/main/LICENSE).
