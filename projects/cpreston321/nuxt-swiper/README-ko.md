# Nuxt Swiper

[![npm](https://img.shields.io/npm/v/nuxt-swiper?style=flat-square)](https://www.npmjs.com/package/nuxt-swiper/)
[![Downloads](https://img.shields.io/npm/dt/nuxt-swiper.svg?style=flat-square)](https://www.npmjs.com/package/nuxt-swiper)
[![License](https://img.shields.io/npm/l/nuxt-swiper?style=flat-square)](/LICENSE)

> [!IMPORTANT]
> ***Nuxt Swiper***는 Swiper.js를 기반으로 웹 컴포넌트를 사용합니다. 이 모듈을 사용하기 전에 Swiper.js [문서](https://swiperjs.com/element)를 반드시 읽어보시고 Nuxt Swiper와 직접 관련이 없는 문제는 보고하지 마십시오. 근본적인 버그가 있을 경우 Swiper.js [저장소](https://github.com/nolimits4web/swiper/issues)에 이슈를 제출해 주세요.

> [!NOTE]
> **Vue.js**에서 웹 컴포넌트를 사용하는 방법을 배우고 싶다면 다음 문서를 참고하세요: [Vue.js 웹 컴포넌트](https://vuejs.org/guide/extras/web-components.html)

## 기능

- 📖 오픈 소스
- 🪄 TypeScript 지원
- ✅ 자동 임포트 활성화
- ✨ 마법처럼 바로 작동

## 설정

### 온라인에서 사용해보기

[![Open in StackBlitz](https://developer.stackblitz.com/img/open_in_stackblitz.svg)](https://stackblitz.com/github/cpreston321/nuxt-swiper/tree/main/examples/swiper-basic?file=app.vue)

### 1단계: 모듈 설치하기

```bash
npx nuxi@latest module add swiper
```

## 사용법

> [!참고]
> 이들은 웹 컴포넌트이기 때문에 Vue에서 사용하는 camelCase 명명법 대신 kebab-case 명명법을 사용합니다.

| Swiper 컴포넌트 (웹컴포넌트) |
| ----------------------------- |
| `<swiper-container/>`         |
| `<swiper-slide />`             |

### 모듈 옵션

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

### 기본 사용법

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

## 고급 사용법

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
## 💻 개발

<details>
  <summary>로컬 개발</summary>

- 이 저장소를 클론하세요
- 최신 LTS 버전의 [Node.js](https://nodejs.org/en/)를 설치하세요
- `corepack enable` 명령어로 [Corepack](https://github.com/nodejs/corepack)을 활성화하세요
- `pnpm install`로 의존성을 설치하세요
- `pnpm dev:prepare`로 타입 스텁을 생성하세요
- `pnpm dev`로 테스트를 실행하세요

</details>

## 크레딧

[`Swiper.js`](https://swiperjs.com/)는 [@nolimits4web](https://github.com/nolimits4web)에 의해 개발되었습니다.

[`Nuxt Swiper`](#nuxt-swiper)는 [@cpreston321](https://github.com/cpreston321)에 의해 개발되었습니다.

## 📧 연락처

**X** (이전 이름: 트위터) - [@christian_ggg](https://x.com/christian_ggg)

또한, 제 작업이 마음에 드신다면, [커피 한 잔 사주기](https://www.buymeacoffee.com/cpreston321)를 통해 응원해 주세요 ☕️

[![buymeacoffee](https://www.buymeacoffee.com/assets/img/custom_images/yellow_img.png)](https://www.buymeacoffee.com/cpreston321)

## 기여자

[![contributors](https://contrib.rocks/image?repo=cpreston321/nuxt-swiper)](https://contrib.rocks/image?repo=cpreston321/nuxt-swiper)

---

[MIT](./LICENSE) 라이선스 © 2025 [CP](https://github.com/cpreston321)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-15

---