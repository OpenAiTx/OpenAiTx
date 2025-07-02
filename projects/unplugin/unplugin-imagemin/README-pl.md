# 📦📦 unplugin Imagemin Kompresja obrazów

[![Wersja NPM](https://img.shields.io/npm/v/unplugin-imagemin?color=a1b858&label=)](https://www.npmjs.com/package/unplugin-imagemin)

> [!IMPORTANT]
> **Wskazówki:**
> `Cele 1.0` unplugin-imagemin przygotowuje się do wydania wersji 1.0, która zostanie opublikowana po osiągnięciu poniższych celów

- [x] Wsparcie wszystkich wersji node poprzez ponowną modyfikację składni wasm squoosh
- [x] Usunięcie zależności sharp
- [x] Wsparcie kompresji obrazów w publicDir
- [x] Wsparcie kompresji obrazów w css
- [x] Obsługa pełnego trybu cache
- [x] Wsparcie dla Node 22 i nowszych
- [x] Opcje typów
- [ ] Wsparcie dla farm, rsbuild, webpack i innych frameworków

> [!WARNING]
Nowe funkcje oraz stabilność, kompatybilność i wydajność są stale aktualizowane
Zalecane użycie najnowszej wersji  `pnpm add unplugin-imagemin@latest -D`

> [!WARNING]
Ponieważ Google [squoosh](https://github.com/GoogleChromeLabs/squoosh) nie utrzymuje już kierunku node, powstał ten fork i poprawiono pewne problemy z kompatybilnością. Szczegóły [squoosh-next](https://github.com/ErKeLost/squoosh-node-latest)

### ✨✨ Ciągły rozwój iteracyjny w fazie testów

```bash
✨ : unplugin-imagemin
✔ : Proces uruchomiony z trybem squoosh
✅ : [test1.png] [12.39 MB] -> [102.54 KB]
✔ : Proces uruchomiony z trybem squoosh
✅ : [test2.png] [16.38 MB] -> [76.79 KB]
```

#### 🌈 Funkcje

- 🍰 Obsługa formatów png jpeg webp avif svg tiff
- 🦾 Wysoka wydajność oparta na squoosh
- ✨ Możliwość konfiguracji wielu formatów obrazów
- 🪐 Kompresja kodu podczas budowania
- 😃 Mechanizm cache
- 🌈 Możliwość konwersji różnych typów obrazów podczas budowania

## Squoosh && Svgo

Unplugin-imagemin obsługuje dwa narzędzia do kompresji

[Squoosh](https://github.com/GoogleChromeLabs/squoosh) to webowa aplikacja do kompresji obrazów, która zmniejsza rozmiary obrazów w wielu formatach.
**Squoosh** z rust & wasm

[Svgo](https://github.com/svg/svgo) Obsługa kompresji obrazów w formacie svg

## 📦 Instalacja

```bash
pnpm add unplugin-imagemin@latest -D
```

#### wsparcie dla vite i rollup

<details>
<summary>Podstawowa</summary><br>

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
<summary>Zaawansowana</summary><br>

```ts
iimport { defineConfig } from 'vite';
import vue from '@vitejs/plugin-vue';
import imagemin from 'unplugin-imagemin/vite';
// https://vitejs.dev/config/
export default defineConfig({
  plugins: [
    vue(),
    imagemin({
      // domyślnie true
      cache: false,
      // Domyślne opcje konfiguracyjne do kompresji różnych obrazów
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

## 🌸 DomyślnaKonfiguracja

Squoosh DomyślnaKonfiguracja

DomyślnaKonfiguracja zobacz [DefaultConfiguration](https://github.com/ErKeLost/unplugin-imagemin/blob/main/src/core/compressOptions.ts)

Konfiguracja właściwości wtyczki zobacz [configuration](https://github.com/ErKeLost/unplugin-imagemin/blob/main/src/core/types/index.ts)

```typescript
export interface PluginOptions {
  /**
   * @description Kompilacja i konwersja obrazów
   * @default []
   */
  conversion?: ConversionItemType[];
  /**
   * @description Czy włączyć cache
   * @default true
   */
  cache?: boolean;
  /**
   * @description Ścieżka do lokalizacji pliku cache
   * @default ./node_modules/.cache/unplugin-imagemin/.unplugin-imagemin-cache
   */
  cacheLocation?: string;
  /**
   * @description Atrybut kompilacji
   * @default CompressTypeOptions
   */
  compress?: CompressTypeOptions;
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-02

---