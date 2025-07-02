# 📦📦 unplugin Imagemin فشرده‌سازی تصاویر

[![NPM version](https://img.shields.io/npm/v/unplugin-imagemin?color=a1b858&label=)](https://www.npmjs.com/package/unplugin-imagemin)

> [!IMPORTANT]
> **نکات:**
> `1.0 goals` افزونه unplugin-imagemin در حال آماده‌سازی برای انتشار نسخه ۱.۰ است که پس از دستیابی به اهداف زیر منتشر خواهد شد

- [x] پشتیبانی از تمام نسخه‌های node با بازنویسی نحوی wasm از squoosh
- [x] حذف وابستگی sharp
- [x] پشتیبانی از فشرده‌سازی تصاویر publicDir
- [x] پشتیبانی از فشرده‌سازی تصویر در css
- [x] پشتیبانی از حالت کش کامل
- [x] پشتیبانی از Node 22 و بالاتر
- [x] گزینه‌های نوعی (Type options)
- [ ] پشتیبانی از farm، rsbuild، webpack و سایر فریم‌ورک‌ها

> [!WARNING]
ویژگی‌های جدید و پایداری، سازگاری و عملکرد به طور مداوم به‌روزرسانی می‌شوند  
توصیه می‌شود از آخرین نسخه استفاده کنید  `pnpm add unplugin-imagemin@latest -D`

> [!WARNING]
از آنجا که گوگل [squoosh](https://github.com/GoogleChromeLabs/squoosh) دیگر مسیر node را پشتیبانی نمی‌کند، این fork منتشر شد و برخی مشکلات سازگاری را اصلاح کرد. جزئیات [squoosh-next](https://github.com/ErKeLost/squoosh-node-latest)

### ✨✨ توسعه پیوسته و تکرارشونده در مرحله آزمایش

```bash
✨ : unplugin-imagemin
✔ : Process start with mode squoosh
✅ : [test1.png] [12.39 MB] -> [102.54 KB]
✔ : Process start with mode squoosh
✅ : [test2.png] [16.38 MB] -> [76.79 KB]
```

#### 🌈 ویژگی‌ها

- 🍰 پشتیبانی از فرمت‌های png، jpeg، webp، avif، svg، tiff
- 🦾 عملکرد بالا مبتنی بر squoosh
- ✨ قابلیت پیکربندی چندین فرمت تصویر
- 🪐 فشرده‌سازی کد در زمان build
- 😃 مکانیزم کش
- 🌈 امکان تبدیل انواع مختلف تصاویر در زمان build

## Squoosh && Svgo

افزونه unplugin-imagemin از دو ابزار فشرده‌سازی پشتیبانی می‌کند

[Squoosh](https://github.com/GoogleChromeLabs/squoosh) یک برنامه وب برای فشرده‌سازی تصویر است که اندازه تصاویر را در فرمت‌های مختلف کاهش می‌دهد.
**Squoosh** با rust و wasm

[Svgo](https://github.com/svg/svgo) پشتیبانی از فشرده‌سازی تصاویر با فرمت svg

## 📦 نصب

```bash
pnpm add unplugin-imagemin@latest -D
```

#### پشتیبانی از vite و rollup

<details>
<summary>ساده</summary><br>

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
<summary>پیشرفته</summary><br>

```ts
iimport { defineConfig } from 'vite';
import vue from '@vitejs/plugin-vue';
import imagemin from 'unplugin-imagemin/vite';
// https://vitejs.dev/config/
export default defineConfig({
  plugins: [
    vue(),
    imagemin({
      // پیش‌فرض true
      cache: false,
      // گزینه‌های پیکربندی پیش‌فرض برای فشرده‌سازی تصاویر مختلف
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

پیکربندی پیش‌فرض Squoosh

DefaultConfiguration را در [DefaultConfiguration](https://github.com/ErKeLost/unplugin-imagemin/blob/main/src/core/compressOptions.ts) ببینید

پیکربندی ویژگی‌های پلاگین را در [configuration](https://github.com/ErKeLost/unplugin-imagemin/blob/main/src/core/types/index.ts) ببینید

```typescript
export interface PluginOptions {
  /**
   * @description کامپایل و تبدیل تصویر
   * @default []
   */
  conversion?: ConversionItemType[];
  /**
   * @description آیا کش فعال باشد یا خیر
   * @default true
   */
  cache?: boolean;
  /**
   * @description مسیر محل ذخیره فایل کش
   * @default ./node_modules/.cache/unplugin-imagemin/.unplugin-imagemin-cache
   */
  cacheLocation?: string;
  /**
   * @description ویژگی فشرده‌سازی
   * @default CompressTypeOptions
   */
  compress?: CompressTypeOptions;
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-02

---