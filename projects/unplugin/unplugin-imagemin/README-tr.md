# 📦📦 unplugin Imagemin Resim Sıkıştırma

[![NPM sürümü](https://img.shields.io/npm/v/unplugin-imagemin?color=a1b858&label=)](https://www.npmjs.com/package/unplugin-imagemin)

> [!IMPORTANT]
> **İpuçları:**
> `1.0 hedefleri` unplugin-imagemin, 1.0 sürümünü yayınlamaya hazırlanıyor, aşağıdaki hedeflere ulaşıldıktan sonra yayınlanacak

- [x] Squoosh'un wasm sözdizimini yeniden düzenleyerek tüm node sürümlerini destekle
- [x] sharp bağımlılıklarını kaldır
- [x] publicDir resimlerini sıkıştırmayı destekle
- [x] css ile resim sıkıştırmayı destekle
- [x] Tam önbellek modunu destekler
- [x] Node 22 ve üstünü destekler
- [x] Tip seçenekleri
- [ ] farm, rsbuild, webpack ve diğer frameworkleri destekler

> [!WARNING]
Yeni özellikler, stabilite, uyumluluk ve performans özellikleri sürekli olarak güncellenmektedir
En son sürümü kullanmanız önerilir  `pnpm add unplugin-imagemin@latest -D`

> [!WARNING]
Google [squoosh](https://github.com/GoogleChromeLabs/squoosh) artık node yönünü desteklemediği için, bu fock ortaya çıktı ve bazı uyumluluk sorunlarını düzeltti. Detaylar için [squoosh-next](https://github.com/ErKeLost/squoosh-node-latest)

### ✨✨ Testte sürekli yinelemeli geliştirme

```bash
✨ : unplugin-imagemin
✔ : İşlem squoosh modu ile başlatıldı
✅ : [test1.png] [12.39 MB] -> [102.54 KB]
✔ : İşlem squoosh modu ile başlatıldı
✅ : [test2.png] [16.38 MB] -> [76.79 KB]
```

#### 🌈 Özellikler

- 🍰 png jpeg webp avif svg tiff Formatlarını Destekler
- 🦾 squoosh tabanlı Yüksek Performans
- ✨ Birden fazla resim formatı yapılandırılabilir
- 🪐 Derleme sırasında kodu sıkıştırır
- 😃 Önbellekleme Mekanizması
- 🌈 Derleme sırasında farklı resim türlerine dönüştürebilirsiniz

## Squoosh && Svgo

Unplugin-imagemin iki sıkıştırma aracını destekler

[Squoosh](https://github.com/GoogleChromeLabs/squoosh) birçok format aracılığıyla resim boyutlarını azaltan bir resim sıkıştırma web uygulamasıdır.
**Squoosh** rust & wasm ile

[Svgo](https://github.com/svg/svgo) svg formatındaki resimlerin sıkıştırılmasını destekler

## 📦 Kurulum

```bash
pnpm add unplugin-imagemin@latest -D
```

#### vite ve rollup desteği

<details>
<summary>Temel</summary><br>

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
<summary>Gelişmiş</summary><br>

```ts
iimport { defineConfig } from 'vite';
import vue from '@vitejs/plugin-vue';
import imagemin from 'unplugin-imagemin/vite';
// https://vitejs.dev/config/
export default defineConfig({
  plugins: [
    vue(),
    imagemin({
      // varsayılan true
      cache: false,
      // Farklı resimleri sıkıştırmak için varsayılan yapılandırma seçenekleri
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

## 🌸 VarsayılanYapılandırma

Squoosh VarsayılanYapılandırma

VarsayılanYapılandırma için bakınız [DefaultConfiguration](https://github.com/ErKeLost/unplugin-imagemin/blob/main/src/core/compressOptions.ts)

Eklenti özelliği yapılandırması için bakınız [configuration](https://github.com/ErKeLost/unplugin-imagemin/blob/main/src/core/types/index.ts)

```typescript
export interface PluginOptions {
  /**
   * @description Resim derleme ve dönüştürme
   * @default []
   */
  conversion?: ConversionItemType[];
  /**
   * @description Önbelleğin açılıp açılmayacağı
   * @default true
   */
  cache?: boolean;
  /**
   * @description Önbellek dosyasının konumunun yolu
   * @default ./node_modules/.cache/unplugin-imagemin/.unplugin-imagemin-cache
   */
  cacheLocation?: string;
  /**
   * @description Derleme özelliği
   * @default CompressTypeOptions
   */
  compress?: CompressTypeOptions;
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-02

---