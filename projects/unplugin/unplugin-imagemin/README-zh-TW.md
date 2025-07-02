# 📦📦 unplugin Imagemin 圖片壓縮

[![NPM version](https://img.shields.io/npm/v/unplugin-imagemin?color=a1b858&label=)](https://www.npmjs.com/package/unplugin-imagemin)

> [!IMPORTANT]
> **提示：**
> `1.0 目標` unplugin-imagemin 正準備釋出 1.0 版本，將在實現以下目標後釋出

- [x] 透過重新修改 squoosh 的 wasm 語法，支援所有 node 版本
- [x] 移除 sharp 依賴
- [x] 支援壓縮 publicDir 圖片
- [x] 支援 css 中圖片壓縮
- [x] 支援完整快取模式
- [x] 支援 Node 22 及以上
- [x] 型別選項
- [ ] 支援 farm、rsbuild、webpack 及其他框架

> [!WARNING]
新功能、穩定性、相容性與效能特性持續更新中
建議使用最新版  `pnpm add unplugin-imagemin@latest -D`

> [!WARNING]
由於 Google [squoosh](https://github.com/GoogleChromeLabs/squoosh) 已不再維護 node 方向，因此本分支出現並修正了一些相容性問題。詳情請見 [squoosh-next](https://github.com/ErKeLost/squoosh-node-latest)

### ✨✨ 測試中持續迭代開發

```bash
✨ : unplugin-imagemin
✔ : Process start with mode squoosh
✅ : [test1.png] [12.39 MB] -> [102.54 KB]
✔ : Process start with mode squoosh
✅ : [test2.png] [16.38 MB] -> [76.79 KB]
```

#### 🌈 功能特點

- 🍰 支援 png、jpeg、webp、avif、svg、tiff 格式
- 🦾 基於 squoosh 的高效能
- ✨ 可配置多種圖片格式
- 🪐 建構時壓縮代碼中的圖片
- 😃 快取機制
- 🌈 可以在建構時轉換不同圖片類型

## Squoosh && Svgo

Unplugin-imagemin 支援兩種壓縮工具

[Squoosh](https://github.com/GoogleChromeLabs/squoosh) 是一款圖片壓縮 Web 應用程式，可通過多種格式減少圖片大小。
**Squoosh** 採用 rust & wasm

[Svgo](https://github.com/svg/svgo) 支援壓縮 svg 格式圖片

## 📦 安裝

```bash
pnpm add unplugin-imagemin@latest -D
```

#### 支援 vite 和 rollup

<details>
<summary>基本</summary><br>

```ts
import { defineConfig } from 'vite';
import vue from '@vitejs/plugin-vue';
import imagemin from 'unplugin-imagemin/vite';
// https://vitejs.dev/config/
export default defineConfig({
  plugins: [vue(), imagemin()],
});
```

<br></details>

<details>
<summary>進階</summary><br>

```ts
iimport { defineConfig } from 'vite';
import vue from '@vitejs/plugin-vue';
import imagemin from 'unplugin-imagemin/vite';
// https://vitejs.dev/config/
export default defineConfig({
  plugins: [
    vue(),
    imagemin({
      // 預設為 true
      cache: false,
      // 壓縮不同圖片的預設配置選項
      compress: {
        jpg: {
          quality: 10,
        },
        jpeg: {
          quality: 10,
        },
        png: {
          quality: 10,
        },
```typescript
        webp: {
          quality: 10,
        },
      },
      conversion: [
        { from: 'jpeg', to: 'webp' },
        { from: 'png', to: 'webp' },
        { from: 'JPG', to: 'jpeg' },
      ],
    }),
  ],
});

```

<br></details>

## 🌸 預設組態

Squoosh 預設組態

預設組態請參見 [DefaultConfiguration](https://github.com/ErKeLost/unplugin-imagemin/blob/main/src/core/compressOptions.ts)

外掛屬性組態請參見 [configuration](https://github.com/ErKeLost/unplugin-imagemin/blob/main/src/core/types/index.ts)

```typescript
export interface PluginOptions {
  /**
   * @description 圖片編譯與轉換
   * @default []
   */
  conversion?: ConversionItemType[];
  /**
   * @description 是否啟用快取
   * @default true
   */
  cache?: boolean;
  /**
   * @description 快取檔案位置路徑
   * @default ./node_modules/.cache/unplugin-imagemin/.unplugin-imagemin-cache
   */
  cacheLocation?: string;
  /**
   * @description 編譯屬性
   * @default CompressTypeOptions
   */
  compress?: CompressTypeOptions;
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-02

---