
# unplugin-starter

[![NPM 版本](https://img.shields.io/npm/v/unplugin-starter?color=a1b858&label=)](https://www.npmjs.com/package/unplugin-starter)

[unplugin](https://github.com/unjs/unplugin) 的起始模板。

## 模板使用

要使用此模板，请使用以下命令克隆：


```bash
npx degit unplugin/unplugin-starter my-unplugin
```
并将所有的 `unplugin-starter` 全局替换为你的插件名称。

然后你就可以开始开发你的 unplugin 了 🔥

要测试你的插件，运行：`pnpm run dev`
要发布新版本，运行：`pnpm run release`

## 安装


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
示例: [`playground/`](./playground/)

<br></details>

<details>
<summary>Rollup 打包工具</summary><br>
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
> 该模块兼容 Nuxt 2 和 [Nuxt Vite](https://github.com/nuxt/vite)

<br></details>

<details>
<summary>Vue CLI</summary><br>



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