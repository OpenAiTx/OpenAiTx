# nuxt-viewport

[![versión npm][npm-version-src]][npm-version-href]
[![descargas npm][npm-downloads-src]][npm-downloads-href]
[![Licencia][license-src]][license-href]

> Define puntos de vista personalizados para tu proyecto [Nuxt](https://nuxt.com/)️

## Características

- ⚡️&nbsp; Rápido y ligero con [MatchMedia API](https://developer.mozilla.org/en-US/docs/Web/API/Window/matchMedia) ⚡️
- 🕶&nbsp; Detecta automáticamente el viewport del dispositivo desde Cookie y User-Agent
- 👌&nbsp; Sin configuración para empezar
- 👴️&nbsp; Compatible con IE9+

> **Nota**\
> Esta versión es solo para Nuxt 3+ y Nuxt Bridge. Para Nuxt 2 ver [1.0.1](https://www.npmjs.com/package/nuxt-viewport/v/1.0.1)

## Configuración rápida

1. Añade la dependencia `nuxt-viewport` a tu proyecto

```bash
npx nuxi@latest module add nuxt-viewport
```

2. Añade `nuxt-viewport` a la sección `modules` de `nuxt.config.js`

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

usando opciones de nivel superior

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
## Uso

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

## Uso con composable
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
## Uso con "@nuxt/bridge"

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

## Configuración

### `breakpoints`

- Tipo: Objeto

Un objeto donde la clave es el nombre del viewport, y el valor es el tamaño del viewport.

### `cookie`

- Tipo: Objeto

Un objeto con opciones para cookie.
Ver más https://www.npmjs.com/package/cookiejs#cookie-attributes

### `defaultBreakpoints`

- Tipo: Objeto
- Dispositivos detectables: `bot`, `desktop`, `mobile`, `tablet`, `tv`

Un objeto donde la clave es el nombre del dispositivo detectado, y el valor es la clave del breakpoint.

### `fallbackBreakpoint`

- Tipo: Cadena
- Predeterminado: `viewport`

La clave del breakpoint a usar, si el dispositivo no fue detectado.

### `feature`

- Tipo: `'minWidth' | 'maxWidth'`
- Predeterminado: `'minWidth'`

Característica CSS media.

## Configuración predeterminada

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

## Ejemplo de configuración para Tailwind CSS
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

## Configuración por página
Puedes sobrescribir la configuración global para páginas específicas usando [`definePageMeta`](https://nuxt.com/docs/api/utils/define-page-meta).
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
- Tipo: Cadena

Punto de interrupción actual.

### `viewport.breakpointValue`
- Tipo: Número

```js
// Example using defaults.

viewport.breakpointValue('desktop') // Result: 1024.
viewport.breakpointValue('tablet') // Result: 768.
viewport.breakpointValue('mobile') // Result: 320.
```

### `viewport.isGreaterThan`
- Tipo: Booleano

```js
// Example: viewport.breakpoint is "mobile".

viewport.isGreaterThan('mobile') // Result: false.
viewport.isGreaterThan('desktop') // Result: false.
```

### `viewport.isGreaterOrEquals`
- Tipo: Booleano

```js
// Example: viewport.breakpoint is "mobile".

viewport.isGreaterOrEquals('mobile') // Result: true.
viewport.isGreaterOrEquals('desktop') // Result: false.
```

### `viewport.isLessThan`
- Tipo: Booleano

```js
// Example: viewport.breakpoint is "desktop".

viewport.isLessThan('desktopWide') // Result: true.
viewport.isLessThan('mobile') // Result: false.
```

### `viewport.isLessOrEquals`
- Tipo: Booleano

```js
// Example: viewport.breakpoint is "tablet".

viewport.isLessOrEquals('tablet') // Result: true.
viewport.isLessOrEquals('mobile') // Result: false.
```

### `viewport.match`
- Tipo: Booleano

```js
// Example: viewport.breakpoint is "tablet".

viewport.match('tablet') // Result: true.
viewport.match('desktop') // Result: false.
```

### `viewport.matches`
- Tipo: Booleano

```js
// Example: viewport.breakpoint is "mobileWide".

viewport.matches('tablet', 'mobileWide') // Result: true.
viewport.matches('mobile', 'tablet') // Result: false.
```

### `viewport.queries`
- Tipo: Objeto

Objeto con consultas de medios generadas.

## Contribuir

Puedes contribuir a este módulo en línea con CodeSandBox:

[![Editar nuxt-viewport](https://codesandbox.io/static/img/play-codesandbox.svg)](https://codesandbox.io/s/github/mvrlin/nuxt-viewport/tree/main/?fontsize=14&hidenavigation=1&theme=dark)

O localmente:

1. Clona este repositorio
2. Instala las dependencias usando `yarn install` o `npm install`
3. Inicia el servidor de desarrollo usando `yarn dev` o `npm run dev`

## Licencia

[Licencia MIT](./LICENSE)

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