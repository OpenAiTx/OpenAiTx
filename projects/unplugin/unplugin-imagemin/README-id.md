# 📦📦 unplugin Imagemin Kompresi Gambar

[![NPM version](https://img.shields.io/npm/v/unplugin-imagemin?color=a1b858&label=)](https://www.npmjs.com/package/unplugin-imagemin)

> [!IMPORTANT]
> **Tips:**
> `1.0 goals` unplugin-imagemin sedang mempersiapkan rilis versi 1.0, yang akan dirilis setelah mencapai tujuan berikut

- [x] Mendukung semua versi node dengan memodifikasi ulang sintaks wasm dari squoosh
- [x] menghapus dependensi sharp
- [x] mendukung kompresi gambar di publicDir
- [x] mendukung kompresi gambar pada css
- [x] Mendukung mode cache penuh
- [x] Mendukung Node 22 dan di atasnya
- [x] Opsi tipe
- [ ] Mendukung farm, rsbuild, webpack, dan framework lainnya

> [!WARNING]
Fitur baru, stabilitas, kompatibilitas, dan performa terus diperbarui
Disarankan menggunakan versi terbaru `pnpm add unplugin-imagemin@latest -D`

> [!WARNING]
Karena Google [squoosh](https://github.com/GoogleChromeLabs/squoosh) tidak lagi memelihara arah node, fork ini muncul dan memperbaiki beberapa isu kompatibilitas. Detail [squoosh-next](https://github.com/ErKeLost/squoosh-node-latest)

### ✨✨ Pengembangan iteratif berkelanjutan dalam pengujian

```bash
✨ : unplugin-imagemin
✔ : Proses mulai dengan mode squoosh
✅ : [test1.png] [12.39 MB] -> [102.54 KB]
✔ : Proses mulai dengan mode squoosh
✅ : [test2.png] [16.38 MB] -> [76.79 KB]
```

#### 🌈 Fitur

- 🍰 Mendukung Format png jpeg webp avif svg tiff
- 🦾 Performa Tinggi berbasis squoosh
- ✨ Beberapa format gambar dapat dikonfigurasi
- 🪐 Kompresi kode saat build
- 😃 Mekanisme Caching
- 🌈 Anda dapat mengonversi berbagai tipe gambar saat build

## Squoosh && Svgo

Unplugin-imagemin mendukung dua alat kompresi

[Squoosh](https://github.com/GoogleChromeLabs/squoosh) adalah aplikasi web kompresi gambar yang mengurangi ukuran gambar melalui berbagai format.
**Squoosh** dengan rust & wasm

[Svgo](https://github.com/svg/svgo) Mendukung kompresi gambar dalam format svg

## 📦 Instalasi

```bash
pnpm add unplugin-imagemin@latest -D
```

#### mendukung vite dan rollup

<details>
<summary>Dasar</summary><br>

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
<summary>Lanjutan</summary><br>

```ts
iimport { defineConfig } from 'vite';
import vue from '@vitejs/plugin-vue';
import imagemin from 'unplugin-imagemin/vite';
// https://vitejs.dev/config/
export default defineConfig({
  plugins: [
    vue(),
    imagemin({
      // default true
      cache: false,
      // Opsi konfigurasi default untuk kompresi gambar yang berbeda
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

Squoosh DefaultConfiguration

DefaultConfiguration lihat [DefaultConfiguration](https://github.com/ErKeLost/unplugin-imagemin/blob/main/src/core/compressOptions.ts)

Konfigurasi properti plugin lihat [configuration](https://github.com/ErKeLost/unplugin-imagemin/blob/main/src/core/types/index.ts)

```typescript
export interface PluginOptions {
  /**
   * @description Kompilasi dan konversi gambar
   * @default []
   */
  conversion?: ConversionItemType[];
  /**
   * @description Apakah akan mengaktifkan cache
   * @default true
   */
  cache?: boolean;
  /**
   * @description Jalur lokasi file cache
   * @default ./node_modules/.cache/unplugin-imagemin/.unplugin-imagemin-cache
   */
  cacheLocation?: string;
  /**
   * @description Atribut kompilasi
   * @default CompressTypeOptions
   */
  compress?: CompressTypeOptions;
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-02

---