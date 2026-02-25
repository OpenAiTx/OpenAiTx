

![Banner](https://raw.githubusercontent.com/vivienhenz24/fuzzy-canary/main/./readme-banner.png)

# Fuzzy Canary

AI companies are scraping everyone's sites for training data. If you're self-hosting your blog, there's not much you can do about it, except maybe make them think your site contains content they won't want. Fuzzy Canary plants invisible links (to porn websites...) in your HTML that trigger scrapers' content safeguards.

<div align="center">

[![npm](https://img.shields.io/npm/v/@fuzzycanary/core)](https://www.npmjs.com/package/@fuzzycanary/core)
[![CI](https://img.shields.io/github/actions/workflow/status/vivienhenz24/fuzzyfrontend/ci.yml?branch=main&label=CI)](https://github.com/vivienhenz24/fuzzyfrontend/actions)
[![License](https://img.shields.io/npm/l/@fuzzycanary/core)](https://github.com/vivienhenz24/fuzzyfrontend/blob/main/LICENSE)
[![npm downloads](https://img.shields.io/npm/dm/@fuzzycanary/core)](https://www.npmjs.com/package/@fuzzycanary/core)
[![Bundle size](https://img.shields.io/bundlephobia/minzip/%40fuzzycanary%2Fcore)](https://bundlephobia.com/package/@fuzzycanary/core)

</div>

## Getting Started

### Installation

```bash
npm i @fuzzycanary/core
# or
pnpm add @fuzzycanary/core
```

### Uso

Hay dos formas de usarlo: del lado del cliente o del lado del servidor. Usa el lado del servidor si puedes—funciona mejor porque el canario está en el HTML desde el inicio, así que los scrapers que no ejecutan JavaScript aún lo verán.

**Lado del servidor (recomendado):**

Si estás usando un framework basado en React (Next.js, Remix, etc.), añade el componente `<Canary />` a tu diseño raíz:

```tsx
// Next.js App Router: app/layout.tsx
// Other React frameworks: your root layout file
import { Canary } from '@fuzzycanary/core/react'

export default function RootLayout({ children }) {
  return (
    <html>
      <body>
        <Canary />
        {children}
      </body>
    </html>
  )
}
```

Para frameworks que no sean React, utiliza la utilidad `getCanaryHtml()` e insértala al inicio de tu etiqueta `<body>`.

**Lado del cliente:**

Si estás construyendo un sitio estático o prefieres la inyección del lado del cliente, importa la auto-inicialización en tu archivo de entrada:

```ts
// Your main entry file (e.g., main.ts, index.ts, App.tsx)
import '@fuzzycanary/core/auto'
```

Eso es todo. Inyectará automáticamente el canario cuando se cargue la página.

## Notas sobre SEO

Fuzzy Canary ahora se inyecta para cada visitante, incluidos los rastreadores. Si te preocupa cómo esto afecta la indexación o el posicionamiento, considera probar en un entorno de pruebas antes de implementarlo en producción.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-25

---