

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

### Utilisation

Il existe deux façons de l'utiliser : côté client ou côté serveur. Utilisez côté serveur si possible — cela fonctionne mieux car la canarie est dans le HTML dès le départ, donc les scrapers qui n'exécutent pas JavaScript la verront quand même.

**Côté serveur (recommandé) :**

Si vous utilisez un framework basé sur React (Next.js, Remix, etc.), ajoutez le composant `<Canary />` à votre mise en page racine :

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

Pour les frameworks non-React, utilisez l’utilitaire `getCanaryHtml()` et insérez-le au début de votre balise `<body>`.

**Côté client :**

Si vous créez un site statique ou préférez l’injection côté client, importez l’auto-initialisation dans votre fichier d’entrée :

```ts
// Your main entry file (e.g., main.ts, index.ts, App.tsx)
import '@fuzzycanary/core/auto'
```

C'est tout. Le canari sera automatiquement injecté lorsque la page se charge.

## Notes sur le SEO

Fuzzy Canary s'injecte désormais pour chaque visiteur, y compris les robots d'indexation. Si vous vous inquiétez de l'impact sur l'indexation ou le classement, envisagez de tester dans un environnement de préproduction avant de déployer en production.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-25

---