# 📦📦 unplugin Imagemin ضغط الصور

[![NPM version](https://img.shields.io/npm/v/unplugin-imagemin?color=a1b858&label=)](https://www.npmjs.com/package/unplugin-imagemin)

> [!IMPORTANT]
> **نصائح:**
> `1.0 الأهداف` unplugin-imagemin يستعد لإصدار النسخة 1.0، وسيتم إصدارها بعد تحقيق الأهداف التالية

- [x] دعم جميع إصدارات node من خلال إعادة تعديل صياغة wasm لـ squoosh
- [x] إزالة الاعتمادات على sharp
- [x] دعم ضغط صور publicDir
- [x] دعم ضغط الصور في css
- [x] دعم وضع التخزين المؤقت الكامل
- [x] دعم Node 22 وأكثر
- [x] خيارات النوع
- [ ] دعم farm، rsbuild، webpack، وأطر عمل أخرى

> [!WARNING]
يتم تحديث الميزات الجديدة والاستقرار والتوافق وميزات الأداء باستمرار
يوصى باستخدام أحدث إصدار  `pnpm add unplugin-imagemin@latest -D`

> [!WARNING]
نظرًا لأن Google [squoosh](https://github.com/GoogleChromeLabs/squoosh) لم تعد تدعم اتجاه node، تم إنشاء هذا التفرع وتم تعديل بعض مشاكل التوافق. التفاصيل [squoosh-next](https://github.com/ErKeLost/squoosh-node-latest)

### ✨✨ تطوير تكراري مستمر قيد الاختبار

```bash
✨ : unplugin-imagemin
✔ : بدأت العملية بوضع squoosh
✅ : [test1.png] [12.39 MB] -> [102.54 KB]
✔ : بدأت العملية بوضع squoosh
✅ : [test2.png] [16.38 MB] -> [76.79 KB]
```

#### 🌈 الميزات

- 🍰 دعم تنسيقات png jpeg webp avif svg tiff
- 🦾 أداء عالي بالاعتماد على squoosh
- ✨ يمكن تكوين صيغ صور متعددة
- 🪐 ضغط الكود عند وقت البناء
- 😃 آلية التخزين المؤقت
- 🌈 يمكنك تحويل أنواع صور مختلفة عند البناء

## Squoosh && Svgo

يدعم unplugin-imagemin أداتي ضغط

[Squoosh](https://github.com/GoogleChromeLabs/squoosh) هو تطبيق ويب لضغط الصور يقلل من أحجام الصور عبر العديد من التنسيقات.
**Squoosh** مع rust & wasm

[Svgo](https://github.com/svg/svgo) يدعم ضغط الصور بتنسيق svg

## 📦 التثبيت

```bash
pnpm add unplugin-imagemin@latest -D
```

#### يدعم vite و rollup

<details>
<summary>أساسي</summary><br>

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
<summary>متقدم</summary><br>

```ts
iimport { defineConfig } from 'vite';
import vue from '@vitejs/plugin-vue';
import imagemin from 'unplugin-imagemin/vite';
// https://vitejs.dev/config/
export default defineConfig({
  plugins: [
    vue(),
    imagemin({
      // الافتراضي true
      cache: false,
      // خيارات التكوين الافتراضية لضغط الصور المختلفة
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

الإعداد الافتراضي لـ Squoosh

DefaultConfiguration راجع [DefaultConfiguration](https://github.com/ErKeLost/unplugin-imagemin/blob/main/src/core/compressOptions.ts)

إعدادات خصائص الإضافة راجع [configuration](https://github.com/ErKeLost/unplugin-imagemin/blob/main/src/core/types/index.ts)

```typescript
export interface PluginOptions {
  /**
   * @description تجميع وتحويل الصور
   * @default []
   */
  conversion?: ConversionItemType[];
  /**
   * @description ما إذا كان سيتم تفعيل التخزين المؤقت
   * @default true
   */
  cache?: boolean;
  /**
   * @description مسار موقع ملف التخزين المؤقت
   * @default ./node_modules/.cache/unplugin-imagemin/.unplugin-imagemin-cache
   */
  cacheLocation?: string;
  /**
   * @description خاصية التجميع
   * @default CompressTypeOptions
   */
  compress?: CompressTypeOptions;
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-02

---