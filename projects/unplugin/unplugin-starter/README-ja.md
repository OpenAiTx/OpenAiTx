
# unplugin-starter

[![NPM version](https://img.shields.io/npm/v/unplugin-starter?color=a1b858&label=)](https://www.npmjs.com/package/unplugin-starter)

[unplugin](https://github.com/unjs/unplugin) のスターターテンプレート。

## テンプレートの使用方法

このテンプレートを使用するには、次のコマンドでクローンしてください：


```bash
npx degit unplugin/unplugin-starter my-unplugin
```


そして、`unplugin-starter` をあなたのプラグイン名にグローバル置換してください。

これで unplugin の開発を始めることができます 🔥

プラグインをテストするには、`pnpm run dev` を実行します
新しいバージョンをリリースするには、`pnpm run release` を実行します

## インストール


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
</details>

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
</details>

```ts
// nuxt.config.js
export default defineNuxtConfig({
  modules: [
    ['unplugin-starter/nuxt', { /* options */ }],
  ],
})
```
> このモジュールは Nuxt 2 と [Nuxt Vite](https://github.com/nuxt/vite) の両方で動作します

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