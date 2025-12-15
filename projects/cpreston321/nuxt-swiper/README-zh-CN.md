# Nuxt Swiper

[![npm](https://img.shields.io/npm/v/nuxt-swiper?style=flat-square)](https://www.npmjs.com/package/nuxt-swiper/)
[![Downloads](https://img.shields.io/npm/dt/nuxt-swiper.svg?style=flat-square)](https://www.npmjs.com/package/nuxt-swiper)
[![License](https://img.shields.io/npm/l/nuxt-swiper?style=flat-square)](/LICENSE)

> [!IMPORTANT]
> ***Nuxt Swiper*** 以 Swiper.js 作为基础，使用其 web 组件。在使用此模块并报告任何与 Nuxt Swiper 无直接关系的问题之前，请确保阅读 Swiper.js 的[文档](https://swiperjs.com/element)。如果存在底层错误，请向 Swiper.js 的[仓库](https://github.com/nolimits4web/swiper/issues)提交问题。

> [!NOTE]
> 如果您想学习如何在 **Vue.js** 中使用 web 组件，请参考此处的文档：[Vue.js Web 组件](https://vuejs.org/guide/extras/web-components.html)

## 功能

- 📖 开源
- 🪄 支持 TypeScript
- ✅ 自动导入已启用
- ✨ 开箱即用，如魔法般简单

## 安装

### 在线尝试

[![Open in StackBlitz](https://developer.stackblitz.com/img/open_in_stackblitz.svg)](https://stackblitz.com/github/cpreston321/nuxt-swiper/tree/main/examples/swiper-basic?file=app.vue)

### 第 1 步：安装模块

```bash
npx nuxi@latest module add swiper
```

## 用法

> [!注意]
> 由于这些是网页组件，它们使用短横线命名法，而不是 Vue 使用的驼峰命名法。

| Swiper 组件（网页组件） |
| ---------------------- |
| `<swiper-container/>`     |
| `<swiper-slide />`        |

### 模块选项

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

### 基本用法

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

## 高级用法

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
## 💻 开发

<details>
  <summary>本地开发</summary>

- 克隆此仓库
- 安装最新的 LTS 版本的 [Node.js](https://nodejs.org/en/)
- 使用 `corepack enable` 启用 [Corepack](https://github.com/nodejs/corepack)
- 使用 `pnpm install` 安装依赖
- 使用 `pnpm dev:prepare` 生成类型存根
- 使用 `pnpm dev` 运行测试

</details>

## 致谢

[`Swiper.js`](https://swiperjs.com/) 由 [@nolimits4web](https://github.com/nolimits4web) 开发。

[`Nuxt Swiper`](#nuxt-swiper) 由 [@cpreston321](https://github.com/cpreston321) 开发。

## 📧 联系方式

**X**（原名 Twitter） - [@christian_ggg](https://x.com/christian_ggg)

如果你喜欢我的工作，也欢迎 [请我喝咖啡](https://www.buymeacoffee.com/cpreston321) ☕️

[![buymeacoffee](https://www.buymeacoffee.com/assets/img/custom_images/yellow_img.png)](https://www.buymeacoffee.com/cpreston321)

## 贡献者

[![contributors](https://contrib.rocks/image?repo=cpreston321/nuxt-swiper)](https://contrib.rocks/image?repo=cpreston321/nuxt-swiper)

---

[MIT](./LICENSE) 许可证 © 2025 [CP](https://github.com/cpreston321)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-15

---