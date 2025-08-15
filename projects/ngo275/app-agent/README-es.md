# AppAgent

<div align="center">
  <img width="200" src="https://github.com/user-attachments/assets/7f86c185-0fc1-46c3-888a-c915602f27ee" alt="AppAgent" />
  <h2>De ASO a Lanzamiento, Todo Simplificado.</h2>
</div>

[AppAgent](https://app-agent.ai) es una herramienta con inteligencia artificial que gestiona el ASO y el proceso de lanzamiento de tu aplicación. AppAgent es una alternativa de código abierto a herramientas de ASO, como App Radar, AppTweak, AppFollow y Sensor Tower. AppAgent tiene inteligencia artificial y funciona de forma autónoma.

https://github.com/user-attachments/assets/e34baeef-ceab-4fdb-9a7c-e6a5ab80dbba

---

## ¿Por qué AppAgent?

Gracias a los rápidos avances en IA, crear una aplicación nunca ha sido tan fácil. Sin embargo, las herramientas populares de ASO (App Radar, AppTweak, Sensor Tower, etc.) siguen siendo prohibitivamente caras y innecesariamente complejas para desarrolladores independientes y equipos pequeños. Lo que realmente se necesita es una plataforma que gestione de forma autónoma todo — desde la selección multilingüe de palabras clave hasta la generación de contenido para ASO — simplificando no solo las palabras clave, sino todo el proceso de lanzamiento.

App Store Connect también introdujo fricciones en el flujo de trabajo de lanzamiento. Por eso adopté un enfoque basado en IA y construí AppAgent desde cero, reinventando cómo deberían funcionar juntos el ASO y los lanzamientos de aplicaciones en una plataforma única, fluida y eficiente.

---

## Funcionalidades

### ASO Autónomo (Beta)

https://github.com/user-attachments/assets/09172b8c-c690-42b2-a394-8b65e80c25ad

- **Investigación autónoma de palabras clave**
  - No más búsqueda manual de palabras clave.
  - Funciona de forma autónoma, sin importar locales ni mercados.
  - Busca competidores y te permite gestionar la lista de competidores auto-curada.
  - Investiga palabras clave y finaliza la lista con IA basada en los competidores.
- **Optimización de tienda impulsada por IA**
  - Sugerencias instantáneas basadas en los metadatos de tu aplicación.
  - Generación de contenido ASO amigable para todos los idiomas.
  - No se necesita nivel experto en marketing, solo clic y listo.

### Gestión de Lanzamientos

https://github.com/user-attachments/assets/9148a814-ae24-4005-adb6-d113933b67d3
- **Localiza tus notas de la versión**  
  - Genera notas de la versión en todos los idiomas.  
  - No más copiar y pegar con ChatGPT para todos los idiomas que soportas.  
- **Sincronización con la tienda**  
  - Sincroniza datos con App Store Connect. Google Play llegará pronto.  
  - No más entrada manual de datos en App Store Connect.  
  - Envía todos los cambios a App Store Connect con un solo clic.  
  - Envía para revisión de la app con un solo clic.  

---

## Tecnología utilizada

- [Next.js](https://nextjs.org/) – Framework  
- [TypeScript](https://www.typescriptlang.org/) – Lenguaje  
- [Tailwind](https://tailwindcss.com/) – CSS  
- [shadcn/ui](https://ui.shadcn.com) - Componentes UI  
- [Prisma](https://prisma.io) - ORM [![Hecho con Prisma](https://made-with.prisma.io/dark.svg)](https://prisma.io)  
- [PostgreSQL](https://www.postgresql.org/) - Base de datos  
- [NextAuth.js](https://next-auth.js.org/) – Autenticación  
- [PostHog](https://posthog.com/) – Analíticas  
- [Resend](https://resend.com) – Email  
- [Stripe](https://stripe.com) – Pagos  
- [Vercel](https://vercel.com/) – Hosting  

---

## Primeros pasos

### 1. Clona el repositorio  


```bash
git clone https://github.com/ngo275/app-agent.git
```

### 2. Copiar .env.sample a .env y cambiar los valores

```bash
cp .env.sample .env
```
Aquí está la lista de variables de entorno que necesitas configurar:

- `NEXTAUTH_SECRET`
  - Una clave secreta para NextAuth.js. Puedes generar una cadena aleatoria usando `openssl rand -base64 32`.
- `NEXTAUTH_URL`
  - La URL de tu aplicación. Por ejemplo, `http://localhost:3000`.
- `NEXT_PUBLIC_BASE_URL`
  - La URL de tu aplicación. Por ejemplo, `http://localhost:3000`.
- `NEXT_PUBLIC_MARKETING_URL`
  - La URL de tu página de marketing. Por ejemplo, `http://localhost:3000`.
- `GOOGLE_CLIENT_ID`
  - El ID de cliente de tu aplicación OAuth de Google. Usado para el inicio de sesión con Google. No es necesario si no usas inicio de sesión con Google.
- `GOOGLE_CLIENT_SECRET`
  - El secreto de cliente de tu aplicación OAuth de Google. Usado para el inicio de sesión con Google. No es necesario si no usas inicio de sesión con Google.
- `RESEND_API_KEY`
  - La clave API de tu cuenta Resend. Usada para enviar correos electrónicos.
- `NEXT_PUBLIC_POSTHOG_KEY`
  - La clave de tu cuenta PostHog. Usada para análisis. No es necesario si no usas PostHog.
- `OPENAI_API_KEY`
  - La clave API de tu cuenta OpenAI. Usada para el uso de LLM.
- `UPSTASH_REDIS_REST_URL`
  - La URL de tu cuenta Upstash. Usada para caché.
- `UPSTASH_REDIS_REST_TOKEN`
  - El token de tu cuenta Upstash. Usado para caché.
- `NEXT_PUBLIC_FREE_PLAN_ENABLED`
  - Si el plan gratuito está habilitado. Ponlo en `true` para habilitar el plan gratuito.
- `NEXT_PUBLIC_STRIPE_PUBLISHABLE_KEY`
  - La clave pública de tu cuenta Stripe. Usada para pagos. Si configuras `NEXT_PUBLIC_FREE_PLAN_ENABLED` en `true`, no es necesario.
- `STRIPE_SECRET_KEY`
  - La clave secreta de tu cuenta Stripe. Usada para pagos. Si configuras `NEXT_PUBLIC_FREE_PLAN_ENABLED` en `true`, no es necesario.
- `STRIPE_WEBHOOK_SECRET`
  - El secreto webhook de tu cuenta Stripe. Usado para webhooks. Si configuras `NEXT_PUBLIC_FREE_PLAN_ENABLED` en `true`, no es necesario.
- `STRIPE_PRO_PRICE_ID`
  - El ID de precio de tu plan Pro en Stripe. Usado para pagos. Si configuras `NEXT_PUBLIC_FREE_PLAN_ENABLED` en `true`, no es necesario.
- `DATABASE_URL`
  - La URL de tu base de datos PostgreSQL. Además de una máquina local, puedes usar [Supabase](https://supabase.com/) o [Neon](https://neon.tech/) para servicios gratuitos.

### 3. Instalar dependencias


```bash
yarn

# Or with NPM
npm install
```

### 4. Configurar la base de datos

```bash
yarn prisma generate
yarn prisma migrate deploy

# Or with NPM
npm run prisma generate
npm run prisma migrate deploy
```

### 5. Ejecutar el servidor de desarrollo

```bash
yarn dev

# Or with NPM
npm run dev
```

Visite [http://localhost:3000](http://localhost:3000) para ver la aplicación.

---

## Contribuciones

¡Las contribuciones son bienvenidas! No dude en enviar un PR.

Si desea contribuir, por favor bifurque el repositorio y envíe un PR.

---

## Licencia

AppAgent es de código abierto bajo la Licencia Pública General Affero de GNU Versión 3 (AGPLv3) o cualquier versión posterior. Puede encontrarla [aquí](https://github.com/ngo275/app-agent/blob/main/LICENSE).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-15

---