
<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

<div align="center">
  <br />
<br />
<a href="https://kanba.co">
  <img alt="Kanba" src="https://www.kanba.co/dark-hero.png" style=" width: 800px " />
</a>
    <br />
<br />
</div>

<div align="center">
  <br />
<br />
<a href="https://vercel.com/oss">
  <img alt="Vercel OSS Program" src="https://vercel.com/oss/program-badge.svg" />
</a>
    <br />
<br />
</div>
# Alternativa open-source y ligera a Trello diseñada para creadores y desarrolladores independientes.

Enfocada en la simplicidad, velocidad y escalabilidad.
Construida con stack moderno: Tailwind CSS, shadcn/ui, Supabase, integración con Stripe.
Soporta proyectos ilimitados, colaboración en equipo, modo oscuro/claro y experiencia de usuario fluida.
Perfecta para desarrolladores individuales y equipos pequeños que desean control total sin complejidad innecesaria.

## 🌟 Si encuentras útil este proyecto, ¡considera darle una estrella! Así ayudas a que otros lo descubran también.

# Guía de Despliegue

## Visión General
Esta aplicación ahora utiliza rutas API locales de Next.js en lugar de Supabase Edge Functions para la integración con Stripe. Esto simplifica el despliegue y permite usar archivos .env estándar para la configuración.

## Configuración de Variables de Entorno

### 1. Crear archivo .env.local
Copia `.env.example` a `.env.local` y rellena con tus valores reales:

```bash
cp .env.example .env.local
```

### 2. Variables de Entorno Requeridas

#### Configuración de Supabase
- `NEXT_PUBLIC_SUPABASE_URL` - La URL de tu proyecto Supabase
- `NEXT_PUBLIC_SUPABASE_ANON_KEY` - Tu clave anónima de Supabase
- `SUPABASE_SERVICE_ROLE_KEY` - Tu clave de rol de servicio de Supabase (solo del lado del servidor)

#### Configuración de Stripe (opcional)
- `STRIPE_SECRET_KEY` - Tu clave secreta de Stripe (solo del lado del servidor)
- `NEXT_PUBLIC_STRIPE_PUBLISHABLE_KEY` - Tu clave pública de Stripe
- `STRIPE_WEBHOOK_SECRET` - Tu secreto de webhook de Stripe

#### Configuración del Sitio
- `NEXT_PUBLIC_SITE_URL` - La URL de tu sitio (para producción)
- `NEXTAUTH_URL` - La URL de tu sitio (igual que arriba)
- `NEXTAUTH_SECRET` - Un secreto aleatorio para NextAuth

## Desarrollo Local

1. Instala las dependencias:
```bash
npm install
```

2. Configura tus variables de entorno en `.env.local`

3. Ejecuta el servidor de desarrollo:
```bash
npm run dev
```

4. Prueba los webhooks de Stripe localmente usando Stripe CLI:
```bash
stripe listen --forward-to localhost:3000/api/stripe/webhook
```

## Despliegue en Producción


### Despliegue en Vercel

1. **Desplegar en Vercel:**
```bash
npx vercel
```
2. **Variables de Entorno:**
   Agregue todas las variables de entorno a través del panel de Vercel o la CLI

3. **Configuración del Webhook de Stripe:**
   - Apunte el webhook a: `https://tu-dominio.vercel.app/api/stripe/webhook`

## Puntos finales de la API

La aplicación ahora utiliza estas rutas de API locales:

- `POST /api/stripe/checkout` - Crea sesiones de pago de Stripe
- `POST /api/stripe/webhook` - Maneja eventos de webhook de Stripe

## Beneficios de las Rutas de API Locales

1. **Despliegue Más Simple** - No es necesario desplegar funciones edge por separado
2. **Variables de Entorno** - Soporte estándar para archivos .env
3. **Mejor Depuración** - Más fácil de depurar localmente
4. **Integración con Framework** - Mejor integración con Next.js
5. **Sin Dependencia de Proveedor** - Se puede desplegar en cualquier plataforma que soporte Next.js

## Resolución de Problemas

1. **Problemas con Webhooks:**
   - Asegúrese de que `STRIPE_WEBHOOK_SECRET` coincida con el endpoint de webhook de Stripe
   - Revise los registros del webhook en el panel de Stripe
   - Verifique que la URL del webhook sea correcta

2. **Variables de Entorno:**
   - Asegúrese de que todas las variables requeridas estén configuradas
   - Revise errores de tipeo en los nombres de las variables
   - Verifique que la clave de rol de servicio de Supabase tenga los permisos adecuados

3. **Problemas de CORS:**
   - Las rutas de la API incluyen los encabezados CORS adecuados
   - Asegúrese de que su dominio esté en la lista blanca si es necesario

## Notas de Seguridad

- Nunca exponga `STRIPE_SECRET_KEY` o `SUPABASE_SERVICE_ROLE_KEY` al cliente
- Use el prefijo `NEXT_PUBLIC_` solo para variables del lado del cliente
- Rote sus secretos de webhook regularmente
- Monitoree la entrega de webhooks en el panel de Stripe



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-01

---