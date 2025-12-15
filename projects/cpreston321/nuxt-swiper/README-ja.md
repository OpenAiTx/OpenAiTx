# Nuxt Swiper

[![npm](https://img.shields.io/npm/v/nuxt-swiper?style=flat-square)](https://www.npmjs.com/package/nuxt-swiper/)
[![Downloads](https://img.shields.io/npm/dt/nuxt-swiper.svg?style=flat-square)](https://www.npmjs.com/package/nuxt-swiper)
[![License](https://img.shields.io/npm/l/nuxt-swiper?style=flat-square)](/LICENSE)

> [!IMPORTANT]
> ***Nuxt Swiper*** は、基盤として Swiper.js のウェブコンポーネントを利用しています。このモジュールを使用する前に、Swiper.js の[ドキュメント](https://swiperjs.com/element)を必ずお読みください。また、Nuxt Swiper に直接関係しない問題を報告する場合は注意してください。根本的なバグがある場合は、Swiper.js の[リポジトリ](https://github.com/nolimits4web/swiper/issues)にイシューを提出してください。

> [!NOTE]
> **Vue.js** でウェブコンポーネントの使い方を学びたい場合は、こちらのドキュメントをご参照ください：[Vue.js Web Components](https://vuejs.org/guide/extras/web-components.html)

## 特徴

- 📖 オープンソース
- 🪄 TypeScript サポート
- ✅ 自動インポート対応
- ✨ すぐに使える、まるで魔法のように

## セットアップ

### オンラインで試す

[![Open in StackBlitz](https://developer.stackblitz.com/img/open_in_stackblitz.svg)](https://stackblitz.com/github/cpreston321/nuxt-swiper/tree/main/examples/swiper-basic?file=app.vue)

### ステップ 1: モジュールをインストールする

```bash
npx nuxi@latest module add swiper
```

## 使用法

> [!注意]
> これらはウェブコンポーネントであるため、Vueが使用するcamelCase命名規則ではなく、kebab-case命名規則を使用します。

| Swiper コンポーネント（WebComponent） |
| -------------------------------- |
| `<swiper-container/>`     |
| `<swiper-slide />`        |

### モジュールオプション

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

### 基本的な使い方

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

## 高度な使用法

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
## 💻 開発

<details>
  <summary>ローカル開発</summary>

- このリポジトリをクローンする
- 最新のLTSバージョンの[Node.js](https://nodejs.org/en/)をインストールする
- `corepack enable`で[Corepack](https://github.com/nodejs/corepack)を有効にする
- `pnpm install`で依存関係をインストールする
- `pnpm dev:prepare`で型スタブを生成する
- `pnpm dev`でテストを実行する

</details>

## クレジット

[`Swiper.js`](https://swiperjs.com/)は[@nolimits4web](https://github.com/nolimits4web)によって開発されました。

[`Nuxt Swiper`](#nuxt-swiper)は[@cpreston321](https://github.com/cpreston321)によって開発されました。

## 📧 連絡先

**X**（旧Twitter） - [@christian_ggg](https://x.com/christian_ggg)

また、もし私の仕事を気に入っていただけたら、ぜひ[コーヒーをご馳走してください](https://www.buymeacoffee.com/cpreston321)☕️

[![buymeacoffee](https://www.buymeacoffee.com/assets/img/custom_images/yellow_img.png)](https://www.buymeacoffee.com/cpreston321)

## 貢献者

[![contributors](https://contrib.rocks/image?repo=cpreston321/nuxt-swiper)](https://contrib.rocks/image?repo=cpreston321/nuxt-swiper)

---

[MIT](./LICENSE) ライセンス © 2025 [CP](https://github.com/cpreston321)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-15

---