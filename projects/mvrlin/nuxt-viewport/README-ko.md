# nuxt-viewport

[![npm 버전][npm-version-src]][npm-version-href]
[![npm 다운로드][npm-downloads-src]][npm-downloads-href]
[![라이선스][license-src]][license-href]

> [Nuxt](https://nuxt.com/)️ 프로젝트를 위한 커스텀 뷰포트 정의

## 기능

- ⚡️&nbsp; [MatchMedia API](https://developer.mozilla.org/en-US/docs/Web/API/Window/matchMedia) 로 빠르고 가벼움 ⚡️
- 🕶&nbsp; 쿠키 및 User-Agent에서 디바이스 뷰포트를 자동 감지
- 👌&nbsp; 설정 없이 바로 시작 가능
- 👴️&nbsp; IE9+ 지원

> **참고**\
> 이 버전은 Nuxt 3+ 및 Nuxt Bridge 전용입니다. Nuxt 2는 [1.0.1](https://www.npmjs.com/package/nuxt-viewport/v/1.0.1) 참고

## 빠른 설치

1. 프로젝트에 `nuxt-viewport` 의존성 추가

```bash
npx nuxi@latest module add nuxt-viewport
```

2. `nuxt.config.js`의 `modules` 섹션에 `nuxt-viewport`를 추가합니다.

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

최상위 옵션 사용하기

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

## 사용법
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

## 조합형과의 사용법
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

## "@nuxt/bridge" 사용법
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

## 구성

### `breakpoints`

- 유형: 객체

키가 뷰포트 이름이고 값이 뷰포트 크기인 객체입니다.

### `cookie`

- 유형: 객체

쿠키 옵션을 포함하는 객체입니다.  
자세한 내용은 https://www.npmjs.com/package/cookiejs#cookie-attributes 를 참조하세요.

### `defaultBreakpoints`

- 유형: 객체  
- 감지 가능한 장치: `bot`, `desktop`, `mobile`, `tablet`, `tv`

키가 감지된 장치 이름이고 값이 브레이크포인트 키인 객체입니다.

### `fallbackBreakpoint`

- 유형: 문자열  
- 기본값: `viewport`

장치가 감지되지 않았을 때 사용할 브레이크포인트 키입니다.

### `feature`

- 유형: `'minWidth' | 'maxWidth'`  
- 기본값: `'minWidth'`

CSS 미디어 기능입니다.

## 기본 구성

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

## Tailwind CSS 예제 구성
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

## 페이지별 설정
특정 페이지에 대해 전역 구성을 [`definePageMeta`](https://nuxt.com/docs/api/utils/define-page-meta)를 사용하여 재정의할 수 있습니다.
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
- 유형: 문자열

현재 브레이크포인트.

### `viewport.breakpointValue`
- 유형: 숫자

```js
// Example using defaults.

viewport.breakpointValue('desktop') // Result: 1024.
viewport.breakpointValue('tablet') // Result: 768.
viewport.breakpointValue('mobile') // Result: 320.
```

### `viewport.isGreaterThan`
- 유형: 불리언

```js
// Example: viewport.breakpoint is "mobile".

viewport.isGreaterThan('mobile') // Result: false.
viewport.isGreaterThan('desktop') // Result: false.
```

### `viewport.isGreaterOrEquals`
- 유형: 불리언

```js
// Example: viewport.breakpoint is "mobile".

viewport.isGreaterOrEquals('mobile') // Result: true.
viewport.isGreaterOrEquals('desktop') // Result: false.
```

### `viewport.isLessThan`
- 유형: 불리언

```js
// Example: viewport.breakpoint is "desktop".

viewport.isLessThan('desktopWide') // Result: true.
viewport.isLessThan('mobile') // Result: false.
```

### `viewport.isLessOrEquals`
- 타입: 불리언

```js
// Example: viewport.breakpoint is "tablet".

viewport.isLessOrEquals('tablet') // Result: true.
viewport.isLessOrEquals('mobile') // Result: false.
```

### `viewport.match`
- 유형: 불리언

```js
// Example: viewport.breakpoint is "tablet".

viewport.match('tablet') // Result: true.
viewport.match('desktop') // Result: false.
```

### `viewport.matches`
- 유형: 불리언

```js
// Example: viewport.breakpoint is "mobileWide".

viewport.matches('tablet', 'mobileWide') // Result: true.
viewport.matches('mobile', 'tablet') // Result: false.
```
### `viewport.queries`
- 유형: 객체

생성된 미디어 쿼리를 포함하는 객체입니다.

## 기여하기

CodeSandBox를 통해 온라인으로 이 모듈에 기여할 수 있습니다:

[![Edit nuxt-viewport](https://codesandbox.io/static/img/play-codesandbox.svg)](https://codesandbox.io/s/github/mvrlin/nuxt-viewport/tree/main/?fontsize=14&hidenavigation=1&theme=dark)

또는 로컬에서:

1. 이 저장소를 클론하세요
2. `yarn install` 또는 `npm install`로 의존성을 설치하세요
3. `yarn dev` 또는 `npm run dev`로 개발 서버를 시작하세요

## 라이선스

[MIT 라이선스](./LICENSE)

저작권 (c) mvrlin mvrlin@pm.me

<!-- 배지 -->
[npm-version-src]: https://img.shields.io/npm/v/nuxt-viewport/latest.svg?style=for-the-badge
[npm-version-href]: https://npmjs.com/package/nuxt-viewport

[npm-downloads-src]: https://img.shields.io/npm/dt/nuxt-viewport.svg?style=for-the-badge
[npm-downloads-href]: https://npmjs.com/package/nuxt-viewport

[license-src]: https://img.shields.io/npm/l/nuxt-viewport.svg?style=for-the-badge
[license-href]: https://npmjs.com/package/nuxt-viewport



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-15

---