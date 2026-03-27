# sharrr

**One-time end-to-end encrypted file transfer.**

Transfer files (of virtually unlimited size) asynchronously and in the most secure way possible.

Learn more about the [technical implementation](https://sharrr.com/about). See how [sharrr compares](https://github.com/stophecom/sharrr-svelte/blob/main/src/routes/about/comparison.md) to other services.

Website: [www.sharrr.com](https://sharrr.com)

Help keep this project running: [Make a donation](https://donate.stripe.com/28oeV1gKP3bv4b6144)

## Developing

Before you start, add an `.env` file at the root of the project. See below.

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

#### Postgres Database

Using Vercel Postgres Database currently, but can be done with any Prisma compatible database.

### Tests

```bash
# Run unit tests with vitest
# Important: Node 19+ is required (Support for crypto modules)
pnpm run test:unit


# E2E tests with playwright
pnpm run test

```

### Building

To create a production version of your app:

```bash
pnpm run build
```

You can preview the production build with `pnpm run preview`.

### Maintenance

There is a Github workflow `cron-cleanup-files.yml` that runs every day to cleanup old files.
See `src/routes/api/v1/cron/+server.ts` for more info.

You can trigger the cron job locally with:

```bash
curl --request POST \
     --url 'http://localhost:3000/api/v1/cron' \
     --header 'Authorization: Bearer API_SECRET_KEY'

```

## Self hosting

> **Note**
> The project currently runs un Vercel, uses S3 for storage and Vercel Postgres DB. Self-hosting requires you to replace those 3rd party solutions.

### Current setup

#### ENV Variables

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

### With Docker (WIP)

You'll need to edit the environment variables within the `.env` file.

> **Note**
> To run the app in Docker you still need to connect your own DB. Same goes if you want to run your own S3 storage solution. This part is not covered yet.

Once you've done that, you can do the following:

```bash
# to start the docker container
sudo docker compose up -d

# to stop the docker container
sudo docker compose down

# to check logs
sudo docker logs sharrr
```

## About

About the author: [stophe.com](https://stophe.com)

Need additional privacy and security options? Checkout [scrt.link](https://scrt.link).

### Stack

- SvelteKit
- Tailwind CSS
- PostgreSQL (Database)
- Prisma (ORM)
- Doppler (For env handling)

This project is tested with BrowserStack.

### Infrastructure

- Website and Postgres on [Vercel](https://vercel.com/)
- S3 Object Storage with [flow.swiss](https://flow.swiss)

### License

[MIT](https://opensource.org/license/mit/) (Code)

[CC BY-NC-ND](https://creativecommons.org/licenses/by-nc-nd/4.0/) (Creatives)
