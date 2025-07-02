# 📦📦 unplugin Imagemin Compressione delle immagini

[![NPM version](https://img.shields.io/npm/v/unplugin-imagemin?color=a1b858&label=)](https://www.npmjs.com/package/unplugin-imagemin)

> [!IMPORTANT]
> **Suggerimenti:**
> `Obiettivi 1.0` unplugin-imagemin si sta preparando a rilasciare la versione 1.0, che sarà pubblicata dopo aver raggiunto i seguenti obiettivi

- [x] Supportare tutte le versioni di node rimodificando la sintassi wasm di squoosh
- [x] rimuovere la dipendenza da sharp
- [x] supportare la compressione delle immagini in publicDir
- [x] supportare la compressione delle immagini nei css
- [x] Supporta la modalità cache completa
- [x] Supporta Node 22 e superiori
- [x] Opzioni tipizzate
- [ ] Supporta farm, rsbuild, webpack e altri framework

> [!WARNING]
Nuove funzionalità e stabilità, compatibilità e prestazioni sono costantemente aggiornate.
Si consiglia di utilizzare l'ultima versione `pnpm add unplugin-imagemin@latest -D`

> [!WARNING]
Poiché Google [squoosh](https://github.com/GoogleChromeLabs/squoosh) non mantiene più la direzione node, questo fork è stato creato e sono stati corretti alcuni problemi di compatibilità. Dettagli su [squoosh-next](https://github.com/ErKeLost/squoosh-node-latest)

### ✨✨ Sviluppo iterativo continuo in fase di test

```bash
✨ : unplugin-imagemin
✔ : Process start with mode squoosh
✅ : [test1.png] [12.39 MB] -> [102.54 KB]
✔ : Process start with mode squoosh
✅ : [test2.png] [16.38 MB] -> [76.79 KB]
```

#### 🌈 Caratteristiche

- 🍰 Supporta i formati png jpeg webp avif svg tiff
- 🦾 Alte prestazioni basate su squoosh
- ✨ È possibile configurare più formati immagine
- 🪐 Comprimi il codice in fase di build
- 😃 Meccanismo di cache
- 🌈 Puoi convertire diversi tipi di immagini in fase di build

## Squoosh && Svgo

Unplugin-imagemin supporta due strumenti di compressione

[Squoosh](https://github.com/GoogleChromeLabs/squoosh) è un'app web per la compressione delle immagini che riduce le dimensioni tramite numerosi formati.
**Squoosh** con rust & wasm

[Svgo](https://github.com/svg/svgo) Supporta la compressione delle immagini in formato svg

## 📦 Installazione

```bash
pnpm add unplugin-imagemin@latest -D
```

#### supporta vite e rollup

<details>
<summary>Base</summary><br>

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
<summary>Avanzato</summary><br>

```ts
iimport { defineConfig } from 'vite';
import vue from '@vitejs/plugin-vue';
import imagemin from 'unplugin-imagemin/vite';
// https://vitejs.dev/config/
export default defineConfig({
  plugins: [
    vue(),
    imagemin({
      // di default true
      cache: false,
      // Opzioni di configurazione predefinite per comprimere diversi tipi di immagini
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

Squoosh DefaultConfiguration

DefaultConfiguration vedi [DefaultConfiguration](https://github.com/ErKeLost/unplugin-imagemin/blob/main/src/core/compressOptions.ts)

Configurazione delle proprietà del plugin vedi [configuration](https://github.com/ErKeLost/unplugin-imagemin/blob/main/src/core/types/index.ts)

```typescript
export interface PluginOptions {
  /**
   * @description Compilazione e conversione delle immagini
   * @default []
   */
  conversion?: ConversionItemType[];
  /**
   * @description Se abilitare la cache
   * @default true
   */
  cache?: boolean;
  /**
   * @description Percorso della posizione del file di cache
   * @default ./node_modules/.cache/unplugin-imagemin/.unplugin-imagemin-cache
   */
  cacheLocation?: string;
  /**
   * @description Attributo di compilazione
   * @default CompressTypeOptions
   */
  compress?: CompressTypeOptions;
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-02

---