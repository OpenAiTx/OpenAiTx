
# unplugin-starter

[![NPM version](https://img.shields.io/npm/v/unplugin-starter?color=a1b858&label=)](https://www.npmjs.com/package/unplugin-starter)

Starter template for [unplugin](https://github.com/unjs/unplugin).

## Template Usage

To use this template, clone it down using:


```bash
npx degit unplugin/unplugin-starter my-unplugin
```
And do a global replacement of `unplugin-starter` with your plugin name.

Then you can start developing your unplugin 🔥

To test your plugin, run: `pnpm run dev`
To release a new version, run: `pnpm run release`

## Install


```bash
npm i unplugin-starter
```


<details>
<summary>Vite</summary><br>


```ts
// vite.config.ts
import Starter from 'unplugin-starter/vite'

export default defineConfig({
  plugins: [
    Starter({ /* options */ }),
  ],
})
```
Example: [`playground/`](./playground/)

<br></details>

<details>
<summary>Rollup</summary><br>


```ts
// rollup.config.js
import Starter from 'unplugin-starter/rollup'

export default {
  plugins: [
    Starter({ /* options */ }),
  ],
}
```
<br></details>

<details>
<summary>Webpack</summary><br>
</details>

```ts
// webpack.config.js
module.exports = {
  /* ... */
  plugins: [
    require('unplugin-starter/webpack')({ /* options */ })
  ]
}
```
<br></details>

<details>
<summary>Nuxt</summary><br>


```ts
// nuxt.config.js
export default defineNuxtConfig({
  modules: [
    ['unplugin-starter/nuxt', { /* options */ }],
  ],
})
```
> This module works for both Nuxt 2 and [Nuxt Vite](https://github.com/nuxt/vite)

<br></details>

<details>
<summary>Vue CLI</summary><br>
</details>

```ts
// vue.config.js
module.exports = {
  configureWebpack: {
    plugins: [
      require('unplugin-starter/webpack')({ /* options */ }),
    ],
  },
}
```
<br></details>

<details>
<summary>esbuild</summary><br>
</details>

```ts
// esbuild.config.js
import { build } from 'esbuild'
import Starter from 'unplugin-starter/esbuild'

build({
  plugins: [Starter()],
})
```
<br></details>



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-21

---