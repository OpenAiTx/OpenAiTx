# 📦📦 unplugin Imagemin Beeldcompressie

[![NPM versie](https://img.shields.io/npm/v/unplugin-imagemin?color=a1b858&label=)](https://www.npmjs.com/package/unplugin-imagemin)

> [!IMPORTANT]
> **Tips:**
> `1.0 doelen` unplugin-imagemin bereidt zich voor om versie 1.0 uit te brengen, die wordt uitgebracht na het behalen van de volgende doelen

- [x] Ondersteuning voor alle node-versies door het wasm-syntaxis van squoosh opnieuw te wijzigen
- [x] sharp-dependenties verwijderen
- [x] ondersteuning voor compressie van afbeeldingen in publicDir
- [x] ondersteuning voor css-compressie van afbeeldingen
- [x] Volledige cachemodus ondersteund
- [x] Ondersteuning voor Node 22 en hoger
- [x] Type-opties
- [ ] Ondersteunt farm, rsbuild, webpack en andere frameworks

> [!WARNING]
Nieuwe functies en stabiliteit, compatibiliteit en prestatiekenmerken worden voortdurend bijgewerkt
Aanbevolen om de nieuwste versie te gebruiken  `pnpm add unplugin-imagemin@latest -D`

> [!WARNING]
Aangezien Google [squoosh](https://github.com/GoogleChromeLabs/squoosh) de node-richting niet langer onderhoudt, is deze fork uitgebracht en zijn enkele compatibiliteitsproblemen aangepast. Details [squoosh-next](https://github.com/ErKeLost/squoosh-node-latest)

### ✨✨ Continue iteratieve ontwikkeling in testfase

```bash
✨ : unplugin-imagemin
✔ : Proces gestart met modus squoosh
✅ : [test1.png] [12.39 MB] -> [102.54 KB]
✔ : Proces gestart met modus squoosh
✅ : [test2.png] [16.38 MB] -> [76.79 KB]
```

#### 🌈 Kenmerken

- 🍰 Ondersteunt png jpeg webp avif svg tiff Formaat
- 🦾 Hoge prestaties gebaseerd op squoosh
- ✨ Meerdere afbeeldingsformaten kunnen worden geconfigureerd
- 🪐 Comprimeer de code tijdens buildtijd
- 😃 Cachemechanisme
- 🌈 Je kunt verschillende afbeeldingssoorten converteren tijdens buildtijd

## Squoosh && Svgo

Unplugin-imagemin ondersteunt twee compressietools

[Squoosh](https://github.com/GoogleChromeLabs/squoosh) is een webapp voor beeldcompressie die afbeeldingsgroottes reduceert via diverse formaten.
**Squoosh** met rust & wasm

[Svgo](https://github.com/svg/svgo) Ondersteunt compressie van afbeeldingen in svg-formaat

## 📦 Installatie

```bash
pnpm add unplugin-imagemin@latest -D
```

#### ondersteuning voor vite en rollup

<details>
<summary>Basis</summary><br>

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
<summary>Geavanceerd</summary><br>

```ts
iimport { defineConfig } from 'vite';
import vue from '@vitejs/plugin-vue';
import imagemin from 'unplugin-imagemin/vite';
// https://vitejs.dev/config/
export default defineConfig({
  plugins: [
    vue(),
    imagemin({
      // standaard true
      cache: false,
      // Standaard configuratieopties voor het comprimeren van verschillende afbeeldingen
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
```markdown
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

## 🌸 StandaardConfiguratie

Squoosh StandaardConfiguratie

StandaardConfiguratie zie [DefaultConfiguration](https://github.com/ErKeLost/unplugin-imagemin/blob/main/src/core/compressOptions.ts)

Plugin eigenschapconfiguratie zie [configuration](https://github.com/ErKeLost/unplugin-imagemin/blob/main/src/core/types/index.ts)

```typescript
export interface PluginOptions {
  /**
   * @description Afbeeldingscompilatie en conversie
   * @default []
   */
  conversion?: ConversionItemType[];
  /**
   * @description Of caching moet worden ingeschakeld
   * @default true
   */
  cache?: boolean;
  /**
   * @description Pad naar de cachebestandslocatie
   * @default ./node_modules/.cache/unplugin-imagemin/.unplugin-imagemin-cache
   */
  cacheLocation?: string;
  /**
   * @description Compilatie-attribuut
   * @default CompressTypeOptions
   */
  compress?: CompressTypeOptions;
}
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-02

---