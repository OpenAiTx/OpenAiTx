# AppAgent

<div align="center">
  <img width="200" src="https://github.com/user-attachments/assets/7f86c185-0fc1-46c3-888a-c915602f27ee" alt="AppAgent" />
  <h2>De l'ASO à la publication, tout en fluidité.</h2>
</div>

[AppAgent](https://app-agent.ai) est un outil axé sur l'IA qui gère le processus d'ASO et de publication de votre application. AppAgent est une alternative open-source aux outils ASO, tels que App Radar, AppTweak, AppFollow, et Sensor Tower. AppAgent est axé sur l'IA et fonctionne de manière autonome.

https://github.com/user-attachments/assets/e34baeef-ceab-4fdb-9a7c-e6a5ab80dbba

---

## Pourquoi AppAgent ?

Grâce aux avancées rapides de l'IA, créer une application n'a jamais été aussi facile. Pourtant, les outils ASO populaires (App Radar, AppTweak, Sensor Tower, etc.) restent prohibitifs en termes de coût et inutilement complexes pour les développeurs indépendants et les petites équipes. Ce qui est vraiment nécessaire, c’est une plateforme qui gère de manière autonome tout — de la sélection multilingue des mots-clés à la génération de contenu ASO — rationalisant non seulement les mots-clés, mais l'ensemble du processus de publication.

App Store Connect a également introduit des frictions dans le flux de travail de publication. C’est pourquoi j’ai adopté une approche centrée sur l’IA et construit AppAgent de zéro, réimaginant comment l’ASO et les publications d’applications devraient fonctionner ensemble dans une plateforme fluide et efficace.

---

## Fonctionnalités

### ASO autonome (Beta)

https://github.com/user-attachments/assets/09172b8c-c690-42b2-a394-8b65e80c25ad

- **Recherche autonome de mots-clés**
  - Fini la chasse manuelle aux mots-clés.
  - Fonctionne de façon autonome, quel que soit le lieu et le marché.
  - Trouvez les concurrents et gérez la liste des concurrents auto-curatée.
  - Recherchez les mots-clés et finalisez la liste avec l’IA basée sur les concurrents.
- **Optimisation du store propulsée par l’IA**
  - Suggestions instantanées basées sur les métadonnées de votre application.
  - Génération de contenus ASO adaptés à toutes les langues.
  - Pas besoin d’expertise marketing, cliquez et c’est parti.

### Gestion des publications

https://github.com/user-attachments/assets/9148a814-ae24-4005-adb6-d113933b67d3

- **Localisez vos notes de version**
  - Générez des notes de version dans toutes les langues.
  - Plus besoin de copier-coller avec ChatGPT pour toutes les langues que vous supportez.
- **Synchronisation du store**
  - Synchronisez les données avec App Store Connect. Google Play arrive bientôt.
  - Plus besoin de saisie manuelle des données sur App Store Connect.
  - Poussez toutes les modifications vers App Store Connect en un clic.
  - Soumettez pour revue d’application en un clic.

---

## Stack technologique

- [Next.js](https://nextjs.org/) – Framework
- [TypeScript](https://www.typescriptlang.org/) – Langage
- [Tailwind](https://tailwindcss.com/) – CSS
- [shadcn/ui](https://ui.shadcn.com) - Composants UI
- [Prisma](https://prisma.io) - ORM [![Made with Prisma](https://made-with.prisma.io/dark.svg)](https://prisma.io)
- [PostgreSQL](https://www.postgresql.org/) - Base de données
- [NextAuth.js](https://next-auth.js.org/) – Authentification
- [PostHog](https://posthog.com/) – Analytique
- [Resend](https://resend.com) – Email
- [Stripe](https://stripe.com/) – Paiements
- [Vercel](https://vercel.com/) – Hébergement

---

## Prise en main

### 1. Clonez le dépôt

```bash
git clone https://github.com/ngo275/app-agent.git
```

### 2. Copier .env.sample en .env et modifier les valeurs

```bash
cp .env.sample .env
```
Voici la liste des variables d'environnement que vous devez définir :

- `NEXTAUTH_SECRET`
  - Une clé secrète pour NextAuth.js. Vous pouvez générer une chaîne aléatoire avec `openssl rand -base64 32`.
- `NEXTAUTH_URL`
  - L'URL de votre application. Par exemple, `http://localhost:3000`.
- `NEXT_PUBLIC_BASE_URL`
  - L'URL de votre application. Par exemple, `http://localhost:3000`.
- `NEXT_PUBLIC_MARKETING_URL`
  - L'URL de votre page marketing. Par exemple, `http://localhost:3000`.
- `GOOGLE_CLIENT_ID`
  - L'identifiant client de votre application OAuth Google. Utilisé pour la connexion Google. Pas nécessaire si vous n'utilisez pas la connexion Google.
- `GOOGLE_CLIENT_SECRET`
  - Le secret client de votre application OAuth Google. Utilisé pour la connexion Google. Pas nécessaire si vous n'utilisez pas la connexion Google.
- `RESEND_API_KEY`
  - La clé API de votre compte Resend. Utilisée pour l'envoi d'emails.
- `NEXT_PUBLIC_POSTHOG_KEY`
  - La clé de votre compte PostHog. Utilisée pour l'analytics. Pas nécessaire si vous n'utilisez pas PostHog.
- `OPENAI_API_KEY`
  - La clé API de votre compte OpenAI. Utilisée pour l'utilisation de LLM.
- `UPSTASH_REDIS_REST_URL`
  - L'URL de votre compte Upstash. Utilisée pour la mise en cache.
- `UPSTASH_REDIS_REST_TOKEN`
  - Le jeton de votre compte Upstash. Utilisé pour la mise en cache.
- `NEXT_PUBLIC_FREE_PLAN_ENABLED`
  - Indique si le plan gratuit est activé. Mettez `true` pour activer le plan gratuit.
- `NEXT_PUBLIC_STRIPE_PUBLISHABLE_KEY`
  - La clé publiable de votre compte Stripe. Utilisée pour les paiements. Si vous mettez `NEXT_PUBLIC_FREE_PLAN_ENABLED` à `true`, ce n'est pas nécessaire.
- `STRIPE_SECRET_KEY`
  - La clé secrète de votre compte Stripe. Utilisée pour les paiements. Si vous mettez `NEXT_PUBLIC_FREE_PLAN_ENABLED` à `true`, ce n'est pas nécessaire.
- `STRIPE_WEBHOOK_SECRET`
  - Le secret webhook de votre compte Stripe. Utilisé pour les webhooks. Si vous mettez `NEXT_PUBLIC_FREE_PLAN_ENABLED` à `true`, ce n'est pas nécessaire.
- `STRIPE_PRO_PRICE_ID`
  - L'identifiant de prix de votre plan Pro Stripe. Utilisé pour les paiements. Si vous mettez `NEXT_PUBLIC_FREE_PLAN_ENABLED` à `true`, ce n'est pas nécessaire.
- `DATABASE_URL`
  - L'URL de votre base de données PostgreSQL. En dehors d'une machine locale, vous pouvez utiliser [Supabase](https://supabase.com/) ou [Neon](https://neon.tech/) pour des services gratuits.

### 3. Installer les dépendances


```bash
yarn

# Or with NPM
npm install
```
### 4. Configurer la base de données


```bash
yarn prisma generate
yarn prisma migrate deploy

# Or with NPM
npm run prisma generate
npm run prisma migrate deploy
```

### 5. Exécuter le serveur de développement

```bash
yarn dev

# Or with NPM
npm run dev
```

Visitez [http://localhost:3000](http://localhost:3000) pour voir l'application.

---

## Contribution

Les contributions sont les bienvenues ! N'hésitez pas à soumettre une PR.

Si vous souhaitez contribuer, veuillez forker le dépôt et soumettre une PR.

---

## Licence

AppAgent est open-source sous la licence GNU Affero General Public License Version 3 (AGPLv3) ou toute version ultérieure. Vous pouvez la trouver [ici](https://github.com/ngo275/app-agent/blob/main/LICENSE).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-15

---