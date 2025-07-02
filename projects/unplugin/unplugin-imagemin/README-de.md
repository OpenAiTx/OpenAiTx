# 📦📦 unplugin Imagemin Bildkomprimierung

[![NPM version](https://img.shields.io/npm/v/unplugin-imagemin?color=a1b858&label=)](https://www.npmjs.com/package/unplugin-imagemin)

> [!IMPORTANT]
> **Tipps:**
> `1.0 Ziele` unplugin-imagemin bereitet die Veröffentlichung der Version 1.0 vor, die nach Erreichung der folgenden Ziele veröffentlicht wird

- [x] Unterstützung aller Node-Versionen durch erneute Modifizierung der wasm-Syntax von squoosh
- [x] Entfernen der sharp-Abhängigkeiten
- [x] Unterstützung der Komprimierung von Bildern im publicDir
- [x] Unterstützung der Komprimierung von Bildern in CSS
- [x] Unterstützt vollständigen Cache-Modus
- [x] Unterstützung für Node 22 und mehr
- [x] Typ-Optionen
- [ ] Unterstützt farm, rsbuild, webpack und andere Frameworks

> [!WARNING]
Neue Features sowie Stabilitäts-, Kompatibilitäts- und Performance-Optimierungen werden ständig aktualisiert.
Es wird empfohlen, die neueste Version zu verwenden  `pnpm add unplugin-imagemin@latest -D`

> [!WARNING]
Da Google [squoosh](https://github.com/GoogleChromeLabs/squoosh) die Node-Entwicklung nicht mehr weiterführt, entstand dieser Fork und behebt einige Kompatibilitätsprobleme. Details unter [squoosh-next](https://github.com/ErKeLost/squoosh-node-latest)

### ✨✨ Kontinuierliche iterative Entwicklung im Test

```bash
✨ : unplugin-imagemin
✔ : Prozess startet mit Modus squoosh
✅ : [test1.png] [12.39 MB] -> [102.54 KB]
✔ : Prozess startet mit Modus squoosh
✅ : [test2.png] [16.38 MB] -> [76.79 KB]
```

#### 🌈 Funktionen

- 🍰 Unterstützung für png, jpeg, webp, avif, svg, tiff Formate
- 🦾 Hohe Performance basierend auf squoosh
- ✨ Mehrere Bildformate konfigurierbar
- 🪐 Komprimierung des Codes zur Build-Zeit
- 😃 Caching-Mechanismus
- 🌈 Verschiedene Bildtypen können zur Build-Zeit konvertiert werden

## Squoosh & Svgo

Unplugin-imagemin unterstützt zwei Komprimierungs-Tools

[Squoosh](https://github.com/GoogleChromeLabs/squoosh) ist eine Bildkomprimierungs-Web-App, die Bildgrößen über zahlreiche Formate reduziert.
**Squoosh** mit Rust & Wasm

[Svgo](https://github.com/svg/svgo) unterstützt die Komprimierung von Bildern im SVG-Format

## 📦 Installation

```bash
pnpm add unplugin-imagemin@latest -D
```

#### Unterstützt vite und rollup

<details>
<summary>Grundlegend</summary><br>

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
<summary>Erweitert</summary><br>

```ts
iimport { defineConfig } from 'vite';
import vue from '@vitejs/plugin-vue';
import imagemin from 'unplugin-imagemin/vite';
// https://vitejs.dev/config/
export default defineConfig({
  plugins: [
    vue(),
    imagemin({
      // standardmäßig true
      cache: false,
      // Standard-Konfigurationsoptionen für die Komprimierung verschiedener Bilder
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

## 🌸 DefaultConfiguration

Squoosh DefaultConfiguration

DefaultConfiguration siehe [DefaultConfiguration](https://github.com/ErKeLost/unplugin-imagemin/blob/main/src/core/compressOptions.ts)

Plugineigenschaft-Konfiguration siehe [configuration](https://github.com/ErKeLost/unplugin-imagemin/blob/main/src/core/types/index.ts)

```typescript
export interface PluginOptions {
  /**
   * @description Bildkompilierung und -konvertierung
   * @default []
   */
  conversion?: ConversionItemType[];
  /**
   * @description Ob Caching aktiviert werden soll
   * @default true
   */
  cache?: boolean;
  /**
   * @description Pfad zum Speicherort der Cache-Datei
   * @default ./node_modules/.cache/unplugin-imagemin/.unplugin-imagemin-cache
   */
  cacheLocation?: string;
  /**
   * @description Kompilierungsattribut
   * @default CompressTypeOptions
   */
  compress?: CompressTypeOptions;
}
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-02

---