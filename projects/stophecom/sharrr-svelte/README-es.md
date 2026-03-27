# sharrr

**Transferencia de archivos cifrada de extremo a extremo y de una sola vez.**

Transfiere archivos (de tamaño prácticamente ilimitado) de forma asincrónica y de la manera más segura posible.

Aprende más sobre la [implementación técnica](https://sharrr.com/about). Mira cómo [sharrr se compara](https://github.com/stophecom/sharrr-svelte/blob/main/src/routes/about/comparison.md) con otros servicios.

Sitio web: [www.sharrr.com](https://sharrr.com)

Ayuda a mantener este proyecto en funcionamiento: [Haz una donación](https://donate.stripe.com/28oeV1gKP3bv4b6144)

## Desarrollo

Antes de comenzar, agrega un archivo `.env` en la raíz del proyecto. Ver más abajo.

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

#### Base de datos Postgres

Actualmente se utiliza la base de datos Vercel Postgres, pero se puede hacer con cualquier base de datos compatible con Prisma.

### Pruebas

```bash
# Run unit tests with vitest
# Important: Node 19+ is required (Support for crypto modules)
pnpm run test:unit


# E2E tests with playwright
pnpm run test

```

### Construcción

Para crear una versión de producción de tu aplicación:

```bash
pnpm run build
```

Puede previsualizar la compilación de producción con `pnpm run preview`.

### Mantenimiento

Hay un flujo de trabajo de Github `cron-cleanup-files.yml` que se ejecuta todos los días para limpiar archivos antiguos.
Consulte `src/routes/api/v1/cron/+server.ts` para más información.

Puede activar el trabajo cron localmente con:

```bash
curl --request POST \
     --url 'http://localhost:3000/api/v1/cron' \
     --header 'Authorization: Bearer API_SECRET_KEY'

```

## Autoalojamiento

> **Nota**
> El proyecto actualmente se ejecuta en Vercel, utiliza S3 para almacenamiento y Vercel Postgres DB. El autoalojamiento requiere que reemplaces esas soluciones de terceros.

### Configuración actual

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

### Con Docker (En progreso)

Necesitarás editar las variables de entorno dentro del archivo `.env`.

> **Nota**
> Para ejecutar la aplicación en Docker aún necesitas conectar tu propia base de datos. Lo mismo aplica si quieres usar tu propia solución de almacenamiento S3. Esta parte aún no está cubierta.

Una vez que hayas hecho eso, puedes hacer lo siguiente:

```bash
# to start the docker container
sudo docker compose up -d

# to stop the docker container
sudo docker compose down

# to check logs
sudo docker logs sharrr
```

## Acerca de

Acerca del autor: [stophe.com](https://stophe.com)

¿Necesitas opciones adicionales de privacidad y seguridad? Visita [scrt.link](https://scrt.link).

### Stack

- SvelteKit
- Tailwind CSS
- PostgreSQL (Base de datos)
- Prisma (ORM)
- Doppler (Para manejo de variables de entorno)

Este proyecto ha sido probado con BrowserStack.

### Infraestructura

- Sitio web y Postgres en [Vercel](https://vercel.com/)
- Almacenamiento de objetos S3 con [flow.swiss](https://flow.swiss)

### Licencia

[MIT](https://opensource.org/license/mit/) (Código)

[CC BY-NC-ND](https://creativecommons.org/licenses/by-nc-nd/4.0/) (Creativos)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-27

---