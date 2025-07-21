<translate-content># unplugin-starter

[![NPM 버전](https://img.shields.io/npm/v/unplugin-starter?color=a1b858&label=)](https://www.npmjs.com/package/unplugin-starter)

[unplugin](https://github.com/unjs/unplugin)용 스타터 템플릿입니다.

## 템플릿 사용법

이 템플릿을 사용하려면 다음을 사용하여 클론하세요:
</translate-content>
```bash
npx degit unplugin/unplugin-starter my-unplugin
```
<translate-content>
그리고 `unplugin-starter`를 당신의 플러그인 이름으로 전역 대체하세요.

그런 다음 unplugin 개발을 시작할 수 있습니다 🔥

플러그인을 테스트하려면, 다음을 실행하세요: `pnpm run dev`
새 버전을 릴리스하려면, 다음을 실행하세요: `pnpm run release`

## 설치
</translate-content>
```bash
npm i unplugin-starter
```
<translate-content>
<details>
<summary>Vite</summary><br>
</translate-content>
```ts
// vite.config.ts
import Starter from 'unplugin-starter/vite'

export default defineConfig({
  plugins: [
    Starter({ /* options */ }),
  ],
})
```
예시: [`playground/`](./playground/)

<br></details>

<details>
<summary>롤업</summary><br>
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
<summary>웹팩</summary><br>
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
> 이 모듈은 Nuxt 2와 [Nuxt Vite](https://github.com/nuxt/vite) 모두에서 작동합니다.

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