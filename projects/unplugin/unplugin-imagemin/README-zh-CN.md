# 📦📦 unplugin Imagemin 图片压缩

[![NPM version](https://img.shields.io/npm/v/unplugin-imagemin?color=a1b858&label=)](https://www.npmjs.com/package/unplugin-imagemin)

> [!IMPORTANT]
> **提示：**
> `1.0 目标` unplugin-imagemin 正在准备发布 1.0 版本，发布前需达成以下目标

- [x] 通过重新修改 squoosh 的 wasm 语法支持所有 node 版本
- [x] 移除 sharp 依赖
- [x] 支持压缩 publicDir 目录下的图片
- [x] 支持 CSS 图片压缩
- [x] 支持全缓存模式
- [x] 支持 Node 22 及以上
- [x] 类型选项
- [ ] 支持 farm、rsbuild、webpack 及其他框架

> [!WARNING]
新特性、稳定性、兼容性及性能相关功能正在不断更新
建议使用最新版  `pnpm add unplugin-imagemin@latest -D`

> [!WARNING]
由于 Google [squoosh](https://github.com/GoogleChromeLabs/squoosh) 已不再维护 node 方向，因此本项目进行了部分兼容性修复。详情见 [squoosh-next](https://github.com/ErKeLost/squoosh-node-latest)

### ✨✨ 测试中持续迭代开发

```bash
✨ : unplugin-imagemin
✔ : Process start with mode squoosh
✅ : [test1.png] [12.39 MB] -> [102.54 KB]
✔ : Process start with mode squoosh
✅ : [test2.png] [16.38 MB] -> [76.79 KB]
```

#### 🌈 特性

- 🍰 支持 png、jpeg、webp、avif、svg、tiff 格式
- 🦾 基于 squoosh 的高性能
- ✨ 多种图片格式可配置
- 🪐 构建时压缩代码中的图片
- 😃 缓存机制
- 🌈 构建时可转换不同类型的图片

## Squoosh && Svgo

Unplugin-imagemin 支持两种压缩工具

[Squoosh](https://github.com/GoogleChromeLabs/squoosh) 是一个图片压缩 web 应用，可通过多种格式减小图片体积。
**Squoosh** 基于 rust & wasm

[Svgo](https://github.com/svg/svgo) 支持 svg 格式图片的压缩

## 📦 安装

```bash
pnpm add unplugin-imagemin@latest -D
```

#### 支持 vite 和 rollup

<details>
<summary>基础用法</summary><br>

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
<summary>进阶用法</summary><br>

```ts
iimport { defineConfig } from 'vite';
import vue from '@vitejs/plugin-vue';
import imagemin from 'unplugin-imagemin/vite';
// https://vitejs.dev/config/
export default defineConfig({
  plugins: [
    vue(),
    imagemin({
      // 默认为 true
      cache: false,
      // 压缩不同图片的默认配置选项
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

## 🌸 DefaultConfiguration

Squoosh 默认配置

默认配置参见 [DefaultConfiguration](https://github.com/ErKeLost/unplugin-imagemin/blob/main/src/core/compressOptions.ts)

插件属性配置参见 [configuration](https://github.com/ErKeLost/unplugin-imagemin/blob/main/src/core/types/index.ts)

```typescript
export interface PluginOptions {
  /**
   * @description 图片编译与转换
   * @default []
   */
  conversion?: ConversionItemType[];
  /**
   * @description 是否开启缓存
   * @default true
   */
  cache?: boolean;
  /**
   * @description 缓存文件位置路径
   * @default ./node_modules/.cache/unplugin-imagemin/.unplugin-imagemin-cache
   */
  cacheLocation?: string;
  /**
   * @description 编译属性
   * @default CompressTypeOptions
   */
  compress?: CompressTypeOptions;
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-02

---