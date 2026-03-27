# sharrr

**Transfert de fichiers chiffré de bout en bout et ponctuel.**

Transférez des fichiers (de taille pratiquement illimitée) de manière asynchrone et la plus sécurisée possible.

En savoir plus sur la [mise en œuvre technique](https://sharrr.com/about). Voir comment [sharrr se compare](https://github.com/stophecom/sharrr-svelte/blob/main/src/routes/about/comparison.md) à d’autres services.

Site web : [www.sharrr.com](https://sharrr.com)

Aidez à maintenir ce projet : [Faire un don](https://donate.stripe.com/28oeV1gKP3bv4b6144)

## Développement

Avant de commencer, ajoutez un fichier `.env` à la racine du projet. Voir ci-dessous.

```bash
# Initial installation
pnpm i

# Run dev server
pnpm run dev

# or start the server and open the app in a new browser tab
pnpm run dev -- --open
```

### DB

#### Prisma ORM

```bash
# Init primsa
npx prisma init

# Push schema to Postgres
npx prisma db push

# Open prisma studio locally
npx prisma studio

# After changes in DB are made. Should not be necessary.
# https://www.prisma.io/docs/concepts/components/prisma-client#4-evolving-your-application
npx prisma generate
```

#### Base de données Postgres

Utilisation actuelle de la base de données Vercel Postgres, mais cela peut être fait avec n'importe quelle base de données compatible Prisma.

### Tests

```bash
# Run unit tests with vitest
# Important: Node 19+ is required (Support for crypto modules)
pnpm run test:unit


# E2E tests with playwright
pnpm run test

```

### Construction

Pour créer une version de production de votre application :

```bash
pnpm run build
```

Vous pouvez prévisualiser la version de production avec `pnpm run preview`.

### Maintenance

Il existe un workflow Github `cron-cleanup-files.yml` qui s'exécute tous les jours pour nettoyer les anciens fichiers.
Voir `src/routes/api/v1/cron/+server.ts` pour plus d'informations.

Vous pouvez déclencher la tâche cron localement avec :

```bash
curl --request POST \
     --url 'http://localhost:3000/api/v1/cron' \
     --header 'Authorization: Bearer API_SECRET_KEY'

```

## Auto-hébergement

> **Note**
> Le projet fonctionne actuellement sur Vercel, utilise S3 pour le stockage et Vercel Postgres DB. L’auto-hébergement nécessite de remplacer ces solutions tierces.

### Configuration actuelle

#### Variables ENV

```bash
# Postgres
POSTGRES_PRISMA_URL='postgres://'
POSTGRES_URL_NON_POOLING='postgres://' # Direct Connection

# S3 compatible object storage e.g. AWS
S3_ENDPOINT='<string>'
S3_ACCESS_KEY='<string>'
S3_SECRET_KEY='<string>'
PUBLIC_S3_BUCKET='<string>'

# Vercel specific, but can be easily replaced.
VERCEL_URL='http://localhost:3000'
PUBLIC_ENV='development' # preview/production

# Only used for cron jobs that run using Github Actions.
API_SECRET_KEY='<string>'
```

### Avec Docker (en cours)

Vous devrez modifier les variables d'environnement dans le fichier `.env`.

> **Note**
> Pour exécuter l'application dans Docker, vous devez toujours connecter votre propre base de données. Il en va de même si vous souhaitez utiliser votre propre solution de stockage S3. Cette partie n'est pas encore couverte.

Une fois cela fait, vous pouvez procéder comme suit :

```bash
# to start the docker container
sudo docker compose up -d

# to stop the docker container
sudo docker compose down

# to check logs
sudo docker logs sharrr
```

## À propos

À propos de l'auteur : [stophe.com](https://stophe.com)

Besoin d'options supplémentaires de confidentialité et de sécurité ? Consultez [scrt.link](https://scrt.link).

### Stack

- SvelteKit
- Tailwind CSS
- PostgreSQL (Base de données)
- Prisma (ORM)
- Doppler (Pour la gestion des variables d'environnement)

Ce projet est testé avec BrowserStack.

### Infrastructure

- Site web et Postgres sur [Vercel](https://vercel.com/)
- Stockage d'objets S3 avec [flow.swiss](https://flow.swiss)

### Licence

[MIT](https://opensource.org/license/mit/) (Code)

[CC BY-NC-ND](https://creativecommons.org/licenses/by-nc-nd/4.0/) (Créations)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-27

---