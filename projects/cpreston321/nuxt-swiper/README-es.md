# Nuxt Swiper

[![npm](https://img.shields.io/npm/v/nuxt-swiper?style=flat-square)](https://www.npmjs.com/package/nuxt-swiper/)
[![Downloads](https://img.shields.io/npm/dt/nuxt-swiper.svg?style=flat-square)](https://www.npmjs.com/package/nuxt-swiper)
[![License](https://img.shields.io/npm/l/nuxt-swiper?style=flat-square)](/LICENSE)

> [!IMPORTANT]
> ***Nuxt Swiper*** utiliza Swiper.js como su base usando sus componentes web. Por favor, asegúrate de leer la [documentación](https://swiperjs.com/element) de Swiper.js antes de usar este módulo y reportar cualquier problema que no esté directamente relacionado con Nuxt Swiper. Si hay un error subyacente, por favor envía un issue al [repositorio](https://github.com/nolimits4web/swiper/issues) de Swiper.js.

> [!NOTE]
> Si quieres aprender cómo usar componentes web en **Vue.js** por favor consulta la documentación aquí: [Vue.js Web Components](https://vuejs.org/guide/extras/web-components.html)

## Características

- 📖 Código Abierto
- 🪄 Soporte para TypeScript
- ✅ Importaciones Automáticas Habilitadas
- ✨ Funciona Directamente sin Configuración como por Arte de Magia

## Configuración

### Pruébalo en línea

[![Open in StackBlitz](https://developer.stackblitz.com/img/open_in_stackblitz.svg)](https://stackblitz.com/github/cpreston321/nuxt-swiper/tree/main/examples/swiper-basic?file=app.vue)

### Paso 1: Instalar el módulo

```bash
npx nuxi@latest module add swiper
```

## Uso

> [!NOTA]
> Dado que estos son componentes web, utilizan la convención de nomenclatura kebab-case en lugar de la convención camelCase que usa Vue.

| Componentes Swiper (WebComponent) |
| --------------------------------- |
| `<swiper-container/>`             |
| `<swiper-slide />`                |

### Opciones del Módulo

```ts
interface ModuleOptions {
  /**
   * Enable custom Swiper composables to help you access Swiper instance.
   * @example ```vue
   * <script setup>
   * const swiperRef = ref<null>(null)
   * const swiper = useSwiper(swiperRef, { loop: true, autoplay: { delay: 5000 })
   *
   * const next = () => swiper.next()
   * </script>
   *
   * <template>
   *  <swiper-container ref="swiperRef" :init="false">
   *    <swiper-slide>Slide 1</swiper-slide>
   *    <swiper-slide>Slide 2</swiper-slide>
   *  </swiper-container>
   * </template>
   * ```
   * @default true
   */
  enableComposables?: boolean

  /**
   * Bundle Swiper custom elements.
   * if disabled, you need to import swiper css and modules manually.
   * @see https://swiperjs.com/element#core-version--modules
   * @default true
   */
  bundled?: boolean
}
```
### Uso Básico


```vue
<script setup lang="ts">
// Create 10 slides
const containerRef = ref(null)
const slides = ref(Array.from({ length: 10 }))

const swiper = useSwiper(containerRef)

onMounted(() => {
  // Access Swiper instance
  // Read more about Swiper instance: https://swiperjs.com/swiper-api#methods--properties
  console.log(swiper.instance)
})
</script>

<template>
  <ClientOnly>
    <swiper-container ref="containerRef">
      <swiper-slide
        v-for="(slide, idx) in slides"
        :key="idx"
        style="background-color: rgb(32, 233, 70); color: white;"
      >
        Slide {{ idx + 1 }}
      </swiper-slide>
    </swiper-container>
  </ClientOnly>

  <!-- Go back one slide -->
  <button @click="swiper.prev()">
    Prev
  </button>
  <!-- Go forward one slide -->
  <button @click="swiper.next()">
    Next
  </button>
</template>

<style lang="css">
swiper-slide {
  display: flex;
  justify-content: center;
  align-items: center;
  font-size: 18px;
  height: 20vh;
  font-size: 4rem;
  font-weight: bold;
  font-family: 'Roboto', sans-serif;
}
</style>
```

## Uso Avanzado

```vue
<script setup lang="ts">
const containerRef = ref(null)
const slides = ref(Array.from({ length: 10 }))
const swiper = useSwiper(containerRef, {
  effect: 'creative',
  loop: true,
  autoplay: {
    delay: 5000,
  },
  creativeEffect: {
    prev: {
      shadow: true,
      translate: [0, 0, -400],
    },
    next: {
      shadow: true,
      translate: [0, 0, -400],
    },
  },
})

onMounted(() => {
  console.log(swiper.instance)
})
</script>

<template>
  <ClientOnly>
    <swiper-container ref="containerRef" :init="false">
      <swiper-slide
        v-for="(slide, idx) in slides"
        :key="idx"
        style="background-color: rgb(32, 233, 70); color: white;"
      >
        Slide {{ idx + 1 }}
      </swiper-slide>
    </swiper-container>
  </ClientOnly>
</template>

<style lang="css">
swiper-slide {
  display: flex;
  justify-content: center;
  align-items: center;
  font-size: 18px;
  height: 20vh;
  font-size: 4rem;
  font-weight: bold;
  font-family: 'Roboto', sans-serif;
}
</style>
```

## 💻 Desarrollo

<details>
  <summary>Desarrollo local</summary>

- Clona este repositorio
- Instala la última versión LTS de [Node.js](https://nodejs.org/en/)
- Habilita [Corepack](https://github.com/nodejs/corepack) usando `corepack enable`
- Instala las dependencias usando `pnpm install`
- Genera los stubs de tipos usando `pnpm dev:prepare`
- Ejecuta las pruebas usando `pnpm dev`

</details>

## Créditos

[`Swiper.js`](https://swiperjs.com/) es desarrollado por [@nolimits4web](https://github.com/nolimits4web).

[`Nuxt Swiper`](#nuxt-swiper) es desarrollado por [@cpreston321](https://github.com/cpreston321).

## 📧 Contacto

**X** (anteriormente conocido como Twitter) - [@christian_ggg](https://x.com/christian_ggg)

Además, si te gusta mi trabajo, siéntete libre de [invitarme a un café](https://www.buymeacoffee.com/cpreston321) ☕️

[![buymeacoffee](https://www.buymeacoffee.com/assets/img/custom_images/yellow_img.png)](https://www.buymeacoffee.com/cpreston321)

## Colaboradores

[![contributors](https://contrib.rocks/image?repo=cpreston321/nuxt-swiper)](https://contrib.rocks/image?repo=cpreston321/nuxt-swiper)

---

[MIT](./LICENSE) Licencia © 2025 [CP](https://github.com/cpreston321)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-15

---