# nuxt-viewport

[![npm version][npm-version-src]][npm-version-href]
[![npm downloads][npm-downloads-src]][npm-downloads-href]
[![License][license-src]][license-href]

> 为您的 [Nuxt](https://nuxt.com/)️ 项目定义自定义视口

## 功能特点

- ⚡️&nbsp; 使用 [MatchMedia API](https://developer.mozilla.org/en-US/docs/Web/API/Window/matchMedia) 的快速轻量 ⚡️
- 🕶&nbsp; 自动从 Cookie 和 User-Agent 检测设备视口
- 👌&nbsp; 零配置即可开始使用
- 👴️&nbsp; 支持 IE9+

> **注意**\
> 本版本仅适用于 Nuxt 3+ 和 Nuxt Bridge。Nuxt 2 请参见 [1.0.1](https://www.npmjs.com/package/nuxt-viewport/v/1.0.1)

## 快速安装

1. 将 `nuxt-viewport` 依赖添加到您的项目中

```bash
npx nuxi@latest module add nuxt-viewport
```
2. 在 `nuxt.config.js` 的 `modules` 部分添加 `nuxt-viewport`


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

使用顶级选项

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

## 使用方法
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

## 与可组合函数一起使用
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

## 与 "@nuxt/bridge" 一起使用
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

## 配置

### `breakpoints`

- 类型：对象

一个对象，键是视口名称，值是视口大小。

### `cookie`

- 类型：对象

一个带有 cookie 选项的对象。
详情见 https://www.npmjs.com/package/cookiejs#cookie-attributes

### `defaultBreakpoints`

- 类型：对象
- 可检测设备：`bot`，`desktop`，`mobile`，`tablet`，`tv`

一个对象，键是检测到的设备名称，值是断点键。

### `fallbackBreakpoint`

- 类型：字符串
- 默认值：`viewport`

未检测到设备时使用的断点键。

### `feature`

- 类型：`'minWidth' | 'maxWidth'`
- 默认值：`'minWidth'`

CSS 媒体特性。

## 默认配置

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

## Tailwind CSS 示例配置
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

## 每页配置
您可以使用 [`definePageMeta`](https://nuxt.com/docs/api/utils/define-page-meta) 为特定页面覆盖全局配置。
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
- 类型：字符串

当前断点。

### `viewport.breakpointValue`
- 类型：数字

```js
// Example using defaults.

viewport.breakpointValue('desktop') // Result: 1024.
viewport.breakpointValue('tablet') // Result: 768.
viewport.breakpointValue('mobile') // Result: 320.
```

### `viewport.isGreaterThan`
- 类型：布尔值

```js
// Example: viewport.breakpoint is "mobile".

viewport.isGreaterThan('mobile') // Result: false.
viewport.isGreaterThan('desktop') // Result: false.
```

### `viewport.isGreaterOrEquals`
- 类型：布尔值

```js
// Example: viewport.breakpoint is "mobile".

viewport.isGreaterOrEquals('mobile') // Result: true.
viewport.isGreaterOrEquals('desktop') // Result: false.
```

### `viewport.isLessThan`
- 类型：布尔值

```js
// Example: viewport.breakpoint is "desktop".

viewport.isLessThan('desktopWide') // Result: true.
viewport.isLessThan('mobile') // Result: false.
```

### `viewport.isLessOrEquals`
- 类型: 布尔值

```js
// Example: viewport.breakpoint is "tablet".

viewport.isLessOrEquals('tablet') // Result: true.
viewport.isLessOrEquals('mobile') // Result: false.
```

### `viewport.match`
- 类型：布尔值

```js
// Example: viewport.breakpoint is "tablet".

viewport.match('tablet') // Result: true.
viewport.match('desktop') // Result: false.
```

### `viewport.matches`
- 类型：布尔值

```js
// Example: viewport.breakpoint is "mobileWide".

viewport.matches('tablet', 'mobileWide') // Result: true.
viewport.matches('mobile', 'tablet') // Result: false.
```

### `viewport.queries`
- 类型：对象

包含生成的媒体查询的对象。

## 贡献

您可以通过 CodeSandBox 在线贡献此模块：

[![编辑 nuxt-viewport](https://codesandbox.io/static/img/play-codesandbox.svg)](https://codesandbox.io/s/github/mvrlin/nuxt-viewport/tree/main/?fontsize=14&hidenavigation=1&theme=dark)

或者本地贡献：

1. 克隆此仓库
2. 使用 `yarn install` 或 `npm install` 安装依赖
3. 使用 `yarn dev` 或 `npm run dev` 启动开发服务器

## 许可证

[MIT 许可证](./LICENSE)

版权所有 (c) mvrlin mvrlin@pm.me

<!-- 徽章 -->
[npm-version-src]: https://img.shields.io/npm/v/nuxt-viewport/latest.svg?style=for-the-badge
[npm-version-href]: https://npmjs.com/package/nuxt-viewport

[npm-downloads-src]: https://img.shields.io/npm/dt/nuxt-viewport.svg?style=for-the-badge
[npm-downloads-href]: https://npmjs.com/package/nuxt-viewport

[license-src]: https://img.shields.io/npm/l/nuxt-viewport.svg?style=for-the-badge
[license-href]: https://npmjs.com/package/nuxt-viewport


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-15

---