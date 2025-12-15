# nuxt-viewport

[![version npm][npm-version-src]][npm-version-href]
[![téléchargements npm][npm-downloads-src]][npm-downloads-href]
[![Licence][license-src]][license-href]

> Définissez des viewports personnalisés pour votre projet [Nuxt](https://nuxt.com/)️

## Fonctionnalités

- ⚡️&nbsp; Rapide & léger avec l'[API MatchMedia](https://developer.mozilla.org/en-US/docs/Web/API/Window/matchMedia) ⚡️
- 🕶&nbsp; Détecte automatiquement le viewport de l'appareil via Cookie & User-Agent
- 👌&nbsp; Aucune configuration nécessaire pour commencer
- 👴️&nbsp; Compatible IE9+

> **Note**\
> Cette version est uniquement pour Nuxt 3+ & Nuxt Bridge. Pour Nuxt 2, voir [1.0.1](https://www.npmjs.com/package/nuxt-viewport/v/1.0.1)

## Installation rapide

1. Ajoutez la dépendance `nuxt-viewport` à votre projet

```bash
npx nuxi@latest module add nuxt-viewport
```
2. Ajoutez `nuxt-viewport` à la section `modules` de `nuxt.config.js`


```js
{
  modules: [
    [
      'nuxt-viewport', {
        /* Viewport options */
      }
    ],
  ]
}
```

utilisation des options de niveau supérieur

```js
{
  modules: [
    'nuxt-viewport',
  ],

  viewport: {
    /* Viewport options */
  },
}
```

## Utilisation
```vue
<script setup>
import { useNuxtApp } from '#app'
const { $viewport } = useNuxtApp()

watch($viewport.breakpoint, (newBreakpoint, oldBreakpoint) => {
  console.log('Breakpoint updated:', oldBreakpoint, '->', newBreakpoint)
})
</script>

<template>
  <div>
    <div v-if="$viewport.isLessThan('tablet')">Should render only on mobile</div>
    <div v-else>Current breakpoint: {{ $viewport.breakpoint }}</div>
  </div>
</template>
```
## Utilisation avec composable

```vue
<script setup>
const viewport = useViewport()

watch(viewport.breakpoint, (newBreakpoint, oldBreakpoint) => {
  console.log('Breakpoint updated:', oldBreakpoint, '->', newBreakpoint)
})
</script>

<template>
  <div>
    <div v-if="viewport.isLessThan('tablet')">Should render only on mobile</div>
    <div v-else>Current breakpoint: {{ viewport.breakpoint }}</div>
  </div>
</template>
```

## Utilisation avec "@nuxt/bridge"
```vue
<script setup>
const viewport = useViewport()

watch(viewport.breakpoint, (newBreakpoint, oldBreakpoint) => {
  console.log('Breakpoint updated:', oldBreakpoint, '->', newBreakpoint)
})
</script>

<template>
  <div>
    <div v-if="viewport.isLessThan('tablet')">Should render only on mobile</div>
    <div v-else>Current breakpoint: {{ $viewport.breakpoint }}</div>
  </div>
</template>
```

## Configuration

### `breakpoints`

- Type : Objet

Un objet où la clé est le nom du viewport, et la valeur est la taille du viewport.

### `cookie`

- Type : Objet

Un objet avec des options pour le cookie.
Voir plus https://www.npmjs.com/package/cookiejs#cookie-attributes

### `defaultBreakpoints`

- Type : Objet
- Appareils détectables : `bot`, `desktop`, `mobile`, `tablet`, `tv`

Un objet où la clé est le nom de l’appareil détecté, et la valeur est la clé du breakpoint.

### `fallbackBreakpoint`

- Type : Chaîne
- Par défaut : `viewport`

La clé du breakpoint à utiliser si l’appareil n’a pas été détecté.

### `feature`

- Type : `'minWidth' | 'maxWidth'`
- Par défaut : `'minWidth'`

Caractéristique media CSS.

## Configuration par défaut

```js
{
  // ...
  viewport: {
    breakpoints: {
      desktop: 1024,
      desktopMedium: 1280,
      desktopWide: 1600,

      mobile: 320,
      mobileMedium: 375,
      mobileWide: 425,

      tablet: 768,
    },

    cookie: {
      expires: 365, // 365 days
      name: 'viewport',
      path: '/',
      sameSite: 'Strict',
      secure: true,
    },

    defaultBreakpoints: {
      desktop: 'desktop',
      mobile: 'mobile',
      tablet: 'tablet',
    },

    fallbackBreakpoint: 'desktop',

    feature: 'minWidth',
  },
  // ...
}
```

## Exemple de configuration pour Tailwind CSS
```js
{
  // ...
  viewport: {
    breakpoints: {
      xs: 320,
      sm: 640,
      md: 768,
      lg: 1024,
      xl: 1280,
      '2xl': 1536,
    },

    defaultBreakpoints: {
      desktop: 'lg',
      mobile: 'xs',
      tablet: 'md',
    },

    fallbackBreakpoint: 'lg'
  },
  // ...
}
```
## Configuration par page
Vous pouvez remplacer la configuration globale pour des pages spécifiques en utilisant [`definePageMeta`](https://nuxt.com/docs/api/utils/define-page-meta).

```vue
<script setup>
definePageMeta({
  viewport: {
    breakpoints: {
      desktop: 1024,
      mobile: 320,
      tablet: 768
    },
    cookie: {
      name: 'viewport-per-page'
    }
    // Other fields will be inherited from the global configuration
  }
})
</script>
```

## API

### `viewport.breakpoint`
- Type : Chaîne

Point de rupture actuel.

### `viewport.breakpointValue`
- Type : Nombre

```js
// Example using defaults.

viewport.breakpointValue('desktop') // Result: 1024.
viewport.breakpointValue('tablet') // Result: 768.
viewport.breakpointValue('mobile') // Result: 320.
```

### `viewport.isGreaterThan`
- Type : Booléen

```js
// Example: viewport.breakpoint is "mobile".

viewport.isGreaterThan('mobile') // Result: false.
viewport.isGreaterThan('desktop') // Result: false.
```

### `viewport.isGreaterOrEquals`
- Type : Booléen

```js
// Example: viewport.breakpoint is "mobile".

viewport.isGreaterOrEquals('mobile') // Result: true.
viewport.isGreaterOrEquals('desktop') // Result: false.
```

### `viewport.isLessThan`
- Type : Booléen

```js
// Example: viewport.breakpoint is "desktop".

viewport.isLessThan('desktopWide') // Result: true.
viewport.isLessThan('mobile') // Result: false.
```

### `viewport.isLessOrEquals`
- Type : Booléen

```js
// Example: viewport.breakpoint is "tablet".

viewport.isLessOrEquals('tablet') // Result: true.
viewport.isLessOrEquals('mobile') // Result: false.
```

### `viewport.match`
- Type : Booléen

```js
// Example: viewport.breakpoint is "tablet".

viewport.match('tablet') // Result: true.
viewport.match('desktop') // Result: false.
```

### `viewport.matches`
- Type : Booléen

```js
// Example: viewport.breakpoint is "mobileWide".

viewport.matches('tablet', 'mobileWide') // Result: true.
viewport.matches('mobile', 'tablet') // Result: false.
```

### `viewport.queries`
- Type : Objet

Objet avec des requêtes média générées.

## Contribution

Vous pouvez contribuer à ce module en ligne avec CodeSandBox :

[![Modifier nuxt-viewport](https://codesandbox.io/static/img/play-codesandbox.svg)](https://codesandbox.io/s/github/mvrlin/nuxt-viewport/tree/main/?fontsize=14&hidenavigation=1&theme=dark)

Ou localement :

1. Clonez ce dépôt
2. Installez les dépendances avec `yarn install` ou `npm install`
3. Lancez le serveur de développement avec `yarn dev` ou `npm run dev`

## Licence

[Licence MIT](./LICENSE)

Copyright (c) mvrlin mvrlin@pm.me

<!-- Badges -->
[npm-version-src]: https://img.shields.io/npm/v/nuxt-viewport/latest.svg?style=for-the-badge
[npm-version-href]: https://npmjs.com/package/nuxt-viewport

[npm-downloads-src]: https://img.shields.io/npm/dt/nuxt-viewport.svg?style=for-the-badge
[npm-downloads-href]: https://npmjs.com/package/nuxt-viewport

[license-src]: https://img.shields.io/npm/l/nuxt-viewport.svg?style=for-the-badge
[license-href]: https://npmjs.com/package/nuxt-viewport


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-15

---