# 📦📦 unplugin Imagemin चित्र संपीड़न

[![NPM version](https://img.shields.io/npm/v/unplugin-imagemin?color=a1b858&label=)](https://www.npmjs.com/package/unplugin-imagemin)

> [!IMPORTANT]
> **टिप्स:**
> `1.0 लक्ष्यों` unplugin-imagemin संस्करण 1.0 जारी करने की तैयारी कर रहा है, जो निम्नलिखित लक्ष्यों को प्राप्त करने के बाद जारी किया जाएगा

- [x] squoosh के wasm सिंटैक्स को फिर से संशोधित करके सभी node संस्करणों का समर्थन करें
- [x] sharp निर्भरताओं को हटाएं
- [x] publicDir छवियों को संपीड़ित करने का समर्थन करें
- [x] css छवि संपीड़न समर्थन करें
- [x] पूर्ण कैश मोड का समर्थन करता है
- [x] Node 22 और अधिक का समर्थन करें
- [x] Type विकल्प
- [ ] farm, rsbuild, webpack, और अन्य फ्रेमवर्क का समर्थन करें

> [!WARNING]
नई सुविधाएँ और स्थिरता, अनुकूलता और प्रदर्शन संबंधी सुविधाएँ लगातार अपडेट की जा रही हैं  
नवीनतम संस्करण का उपयोग करने की सिफारिश की जाती है  `pnpm add unplugin-imagemin@latest -D`

> [!WARNING]
चूंकि Google [squoosh](https://github.com/GoogleChromeLabs/squoosh) अब node डायरेक्शन को मेंटेन नहीं करता, यह फोर्क निकला और कुछ अनुकूलता मुद्दों को संशोधित किया गया। विवरण के लिए देखें [squoosh-next](https://github.com/ErKeLost/squoosh-node-latest)

### ✨✨ परीक्षण में निरंतर पुनरावृत्त विकास

```bash
✨ : unplugin-imagemin
✔ : Process start with mode squoosh
✅ : [test1.png] [12.39 MB] -> [102.54 KB]
✔ : Process start with mode squoosh
✅ : [test2.png] [16.38 MB] -> [76.79 KB]
```

#### 🌈 विशेषताएँ

- 🍰 png jpeg webp avif svg tiff फॉर्मेट का समर्थन करता है
- 🦾 squoosh आधारित उच्च प्रदर्शन
- ✨ कई चित्र फॉर्मेट्स को कॉन्फ़िगर किया जा सकता है
- 🪐 बिल्ड समय पर कोड संपीड़ित करें
- 😃 कैशिंग तंत्र
- 🌈 आप बिल्ड समय पर विभिन्न चित्र प्रकारों को रूपांतरित कर सकते हैं

## Squoosh && Svgo

Unplugin-imagemin दो संपीड़न टूल्स का समर्थन करता है

[Squoosh](https://github.com/GoogleChromeLabs/squoosh) एक छवि संपीड़न वेब ऐप है जो कई फॉर्मेट्स के माध्यम से छवियों के आकार को कम करता है।  
**Squoosh** rust & wasm के साथ

[Svgo](https://github.com/svg/svgo) svg फॉर्मेट में चित्रों के संपीड़न का समर्थन करता है

## 📦 स्थापना

```bash
pnpm add unplugin-imagemin@latest -D
```

#### vite और rollup का समर्थन करता है

<details>
<summary>मूल</summary><br>

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
<summary>उन्नत</summary><br>

```ts
iimport { defineConfig } from 'vite';
import vue from '@vitejs/plugin-vue';
import imagemin from 'unplugin-imagemin/vite';
// https://vitejs.dev/config/
export default defineConfig({
  plugins: [
    vue(),
    imagemin({
      // डिफ़ॉल्ट true
      cache: false,
      // विभिन्न चित्रों को संपीड़ित करने के लिए डिफ़ॉल्ट कॉन्फ़िगरेशन विकल्प
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

DefaultConfiguration देखें [DefaultConfiguration](https://github.com/ErKeLost/unplugin-imagemin/blob/main/src/core/compressOptions.ts)

प्लगइन प्रॉपर्टी कॉन्फ़िगरेशन देखें [configuration](https://github.com/ErKeLost/unplugin-imagemin/blob/main/src/core/types/index.ts)

```typescript
export interface PluginOptions {
  /**
   * @description चित्र संकलन और रूपांतरण
   * @default []
   */
  conversion?: ConversionItemType[];
  /**
   * @description क्या कैशिंग चालू करनी है
   * @default true
   */
  cache?: boolean;
  /**
   * @description कैश फ़ाइल स्थान का पथ
   * @default ./node_modules/.cache/unplugin-imagemin/.unplugin-imagemin-cache
   */
  cacheLocation?: string;
  /**
   * @description संकलन विशेषता
   * @default CompressTypeOptions
   */
  compress?: CompressTypeOptions;
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-02

---