# Nuxt Swiper

[![npm](https://img.shields.io/npm/v/nuxt-swiper?style=flat-square)](https://www.npmjs.com/package/nuxt-swiper/)
[![Downloads](https://img.shields.io/npm/dt/nuxt-swiper.svg?style=flat-square)](https://www.npmjs.com/package/nuxt-swiper)
[![License](https://img.shields.io/npm/l/nuxt-swiper?style=flat-square)](/LICENSE)

> [!IMPORTANT]
> ***Nuxt Swiper*** utilise Swiper.js comme base en utilisant ses composants web. Veuillez vous assurer de lire la [documentation](https://swiperjs.com/element) de Swiper.js avant d’utiliser ce module et de signaler tout problème qui ne serait pas directement lié à Nuxt Swiper. S’il y a un bug sous-jacent, merci de soumettre un problème au [dépôt](https://github.com/nolimits4web/swiper/issues) de Swiper.js.

> [!NOTE]
> Si vous souhaitez apprendre comment utiliser les composants web dans **Vue.js**, veuillez consulter la documentation ici : [Vue.js Web Components](https://vuejs.org/guide/extras/web-components.html)

## Fonctionnalités

- 📖 Open Source
- 🪄 Support TypeScript
- ✅ Importations Automatiques Activées
- ✨ Fonctionne immédiatement comme par magie

## Installation

### Essayez en ligne

[![Open in StackBlitz](https://developer.stackblitz.com/img/open_in_stackblitz.svg)](https://stackblitz.com/github/cpreston321/nuxt-swiper/tree/main/examples/swiper-basic?file=app.vue)

### Étape 1 : Installer le module

```bash
npx nuxi@latest module add swiper
```

## Utilisation

> [!NOTE]
> Étant donné qu'il s'agit de composants web, ils utilisent la convention de nommage en kebab-case contrairement à la convention camelCase utilisée par Vue.

| Composants Swiper (WebComponent) |
| -------------------------------- |
| `<swiper-container/>`     |
| `<swiper-slide />`        |

### Options du module

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

### Utilisation de base

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

## Utilisation avancée

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

## 💻 Développement

<details>
  <summary>Développement local</summary>

- Clonez ce dépôt
- Installez la dernière version LTS de [Node.js](https://nodejs.org/en/)
- Activez [Corepack](https://github.com/nodejs/corepack) en utilisant `corepack enable`
- Installez les dépendances avec `pnpm install`
- Générez les stubs de type avec `pnpm dev:prepare`
- Lancez les tests avec `pnpm dev`

</details>

## Crédits

[`Swiper.js`](https://swiperjs.com/) est développé par [@nolimits4web](https://github.com/nolimits4web).

[`Nuxt Swiper`](#nuxt-swiper) est développé par [@cpreston321](https://github.com/cpreston321).

## 📧 Contact

**X** (anciennement connu sous le nom Twitter) - [@christian_ggg](https://x.com/christian_ggg)

Aussi, si vous aimez mon travail, n’hésitez pas à [m’offrir un café](https://www.buymeacoffee.com/cpreston321) ☕️

[![buymeacoffee](https://www.buymeacoffee.com/assets/img/custom_images/yellow_img.png)](https://www.buymeacoffee.com/cpreston321)

## Contributeurs

[![contributors](https://contrib.rocks/image?repo=cpreston321/nuxt-swiper)](https://contrib.rocks/image?repo=cpreston321/nuxt-swiper)

---

[MIT](./LICENSE) Licence © 2025 [CP](https://github.com/cpreston321)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-15

---