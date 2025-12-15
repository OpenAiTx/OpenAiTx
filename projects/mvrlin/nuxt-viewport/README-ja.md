# nuxt-viewport

[![npm version][npm-version-src]][npm-version-href]
[![npm downloads][npm-downloads-src]][npm-downloads-href]
[![License][license-src]][license-href]

> あなたの[Nuxt](https://nuxt.com/)️プロジェクトのためのカスタムビューポートを定義します

## 特徴

- ⚡️&nbsp; [MatchMedia API](https://developer.mozilla.org/en-US/docs/Web/API/Window/matchMedia)を用いた高速かつ軽量 ⚡️
- 🕶&nbsp; Cookieとユーザーエージェントからデバイスのビューポートを自動検出
- 👌&nbsp; 設定不要ですぐに開始可能
- 👴️&nbsp; IE9+対応

> **注意**\
> このバージョンはNuxt 3+およびNuxt Bridge専用です。Nuxt 2は[1.0.1](https://www.npmjs.com/package/nuxt-viewport/v/1.0.1)をご覧ください

## クイックセットアップ

1. `nuxt-viewport`依存関係をプロジェクトに追加

```bash
npx nuxi@latest module add nuxt-viewport
```

2. `nuxt.config.js` の `modules` セクションに `nuxt-viewport` を追加します。

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

トップレベルオプションの使用

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

## コンポーザブルとの使用法
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

## "@nuxt/bridge"での使用法
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

## 設定

### `breakpoints`

- 種類: オブジェクト

キーがビューポート名、値がビューポートサイズのオブジェクト。

### `cookie`

- 種類: オブジェクト

クッキーのオプションを持つオブジェクト。
詳細は https://www.npmjs.com/package/cookiejs#cookie-attributes を参照。

### `defaultBreakpoints`

- 種類: オブジェクト
- 検出可能なデバイス: `bot`、`desktop`、`mobile`、`tablet`、`tv`

検出されたデバイス名がキー、ブレークポイントキーが値のオブジェクト。

### `fallbackBreakpoint`

- 種類: 文字列
- デフォルト: `viewport`

デバイスが検出されなかった場合に使用されるブレークポイントキー。

### `feature`

- 種類: `'minWidth' | 'maxWidth'`
- デフォルト: `'minWidth'`

CSSメディア機能。

## デフォルト設定

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

## Tailwind CSSの設定例
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

## ページごとの設定
特定のページに対してグローバル設定を上書きするには、[`definePageMeta`](https://nuxt.com/docs/api/utils/define-page-meta)を使用します。
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
- タイプ: 文字列

現在のブレークポイント。

### `viewport.breakpointValue`
- タイプ: 数値

```js
// Example using defaults.

viewport.breakpointValue('desktop') // Result: 1024.
viewport.breakpointValue('tablet') // Result: 768.
viewport.breakpointValue('mobile') // Result: 320.
```

### `viewport.isGreaterThan`
- 型: ブール値

```js
// Example: viewport.breakpoint is "mobile".

viewport.isGreaterThan('mobile') // Result: false.
viewport.isGreaterThan('desktop') // Result: false.
```

### `viewport.isGreaterOrEquals`
- 種類: ブール値

```js
// Example: viewport.breakpoint is "mobile".

viewport.isGreaterOrEquals('mobile') // Result: true.
viewport.isGreaterOrEquals('desktop') // Result: false.
```

### `viewport.isLessThan`
- 型: ブール値

```js
// Example: viewport.breakpoint is "desktop".

viewport.isLessThan('desktopWide') // Result: true.
viewport.isLessThan('mobile') // Result: false.
```

### `viewport.isLessOrEquals`
- 種類: ブール値

```js
// Example: viewport.breakpoint is "tablet".

viewport.isLessOrEquals('tablet') // Result: true.
viewport.isLessOrEquals('mobile') // Result: false.
```

### `viewport.match`
- タイプ: ブール値

```js
// Example: viewport.breakpoint is "tablet".

viewport.match('tablet') // Result: true.
viewport.match('desktop') // Result: false.
```

### `viewport.matches`
- 型: ブール値

```js
// Example: viewport.breakpoint is "mobileWide".

viewport.matches('tablet', 'mobileWide') // Result: true.
viewport.matches('mobile', 'tablet') // Result: false.
```

### `viewport.queries`
- 種類: オブジェクト

生成されたメディアクエリを持つオブジェクト。

## 貢献方法

このモジュールにはCodeSandBox上でオンライン貢献できます:

[![Edit nuxt-viewport](https://codesandbox.io/static/img/play-codesandbox.svg)](https://codesandbox.io/s/github/mvrlin/nuxt-viewport/tree/main/?fontsize=14&hidenavigation=1&theme=dark)

またはローカルで:

1. このリポジトリをクローンする
2. `yarn install` または `npm install` で依存関係をインストールする
3. `yarn dev` または `npm run dev` で開発サーバーを起動する

## ライセンス

[MIT ライセンス](./LICENSE)

Copyright (c) mvrlin mvrlin@pm.me

<!-- バッジ -->
[npm-version-src]: https://img.shields.io/npm/v/nuxt-viewport/latest.svg?style=for-the-badge
[npm-version-href]: https://npmjs.com/package/nuxt-viewport

[npm-downloads-src]: https://img.shields.io/npm/dt/nuxt-viewport.svg?style=for-the-badge
[npm-downloads-href]: https://npmjs.com/package/nuxt-viewport

[license-src]: https://img.shields.io/npm/l/nuxt-viewport.svg?style=for-the-badge
[license-href]: https://npmjs.com/package/nuxt-viewport


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-15

---