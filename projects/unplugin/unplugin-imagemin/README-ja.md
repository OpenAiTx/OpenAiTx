# 📦📦 unplugin Imagemin 画像圧縮

[![NPM version](https://img.shields.io/npm/v/unplugin-imagemin?color=a1b858&label=)](https://www.npmjs.com/package/unplugin-imagemin)

> [!IMPORTANT]
> **ヒント:**
> `1.0 goals` unplugin-imagemin はバージョン1.0のリリースを準備中です。以下の目標達成後にリリースされます。

- [x] squooshのwasm構文を再修正し、すべてのnodeバージョンをサポート
- [x] sharp依存の削除
- [x] publicDir画像の圧縮をサポート
- [x] css画像圧縮をサポート
- [x] フルキャッシュモード対応
- [x] Node 22以降をサポート
- [x] 型オプション対応
- [ ] farm, rsbuild, webpack 他フレームワーク対応

> [!WARNING]
新機能や安定性、互換性、パフォーマンス機能は継続的にアップデートされています。
最新版の利用を推奨します  `pnpm add unplugin-imagemin@latest -D`

> [!WARNING]
Googleの [squoosh](https://github.com/GoogleChromeLabs/squoosh) はnode向けの保守を終了したため、このfockが登場し、いくつかの互換性問題を修正しました。詳細は [squoosh-next](https://github.com/ErKeLost/squoosh-node-latest)

### ✨✨ テスト中の継続的な反復開発

```bash
✨ : unplugin-imagemin
✔ : Process start with mode squoosh
✅ : [test1.png] [12.39 MB] -> [102.54 KB]
✔ : Process start with mode squoosh
✅ : [test2.png] [16.38 MB] -> [76.79 KB]
```

#### 🌈 特徴

- 🍰 png jpeg webp avif svg tiff フォーマット対応
- 🦾 squooshベースの高パフォーマンス
- ✨ 複数画像フォーマットの設定が可能
- 🪐 ビルド時にコード圧縮
- 😃 キャッシュ機構
- 🌈 ビルド時に異なる画像タイプに変換可能

## Squoosh && Svgo

Unplugin-imagemin は2つの圧縮ツールをサポートしています

[Squoosh](https://github.com/GoogleChromeLabs/squoosh) は多くのフォーマットを通じて画像サイズを削減する画像圧縮Webアプリです。
**Squoosh** はrust & wasmベース

[Svgo](https://github.com/svg/svgo) はsvgフォーマット画像の圧縮をサポート

## 📦 インストール

```bash
pnpm add unplugin-imagemin@latest -D
```

#### viteおよびrollup対応

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
<summary>上級</summary><br>

```ts
iimport { defineConfig } from 'vite';
import vue from '@vitejs/plugin-vue';
import imagemin from 'unplugin-imagemin/vite';
// https://vitejs.dev/config/
export default defineConfig({
  plugins: [
    vue(),
    imagemin({
      // デフォルトは true
      cache: false,
      // 各画像のデフォルト圧縮オプション
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
```
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

Squoosh デフォルト設定

デフォルト設定については [DefaultConfiguration](https://github.com/ErKeLost/unplugin-imagemin/blob/main/src/core/compressOptions.ts) を参照してください。

プラグインのプロパティ設定については [configuration](https://github.com/ErKeLost/unplugin-imagemin/blob/main/src/core/types/index.ts) を参照してください。

```typescript
export interface PluginOptions {
  /**
   * @description 画像のコンパイルおよび変換
   * @default []
   */
  conversion?: ConversionItemType[];
  /**
   * @description キャッシュを有効にするかどうか
   * @default true
   */
  cache?: boolean;
  /**
   * @description キャッシュファイルの保存場所
   * @default ./node_modules/.cache/unplugin-imagemin/.unplugin-imagemin-cache
   */
  cacheLocation?: string;
  /**
   * @description コンパイル属性
   * @default CompressTypeOptions
   */
  compress?: CompressTypeOptions;
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-02

---