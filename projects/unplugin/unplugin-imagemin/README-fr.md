# 📦📦 unplugin Imagemin Compression d’images

[![Version NPM](https://img.shields.io/npm/v/unplugin-imagemin?color=a1b858&label=)](https://www.npmjs.com/package/unplugin-imagemin)

> [!IMPORTANT]
> **Conseils :**
> `Objectifs 1.0` unplugin-imagemin se prépare à publier la version 1.0, qui sera publiée après avoir atteint les objectifs suivants

- [x] Prend en charge toutes les versions de node en remodifiant la syntaxe wasm de squoosh
- [x] suppression de la dépendance à sharp
- [x] prise en charge de la compression des images dans publicDir
- [x] prise en charge de la compression des images dans le css
- [x] Prend en charge le mode cache complet
- [x] Prend en charge Node 22 et plus
- [x] Options de type
- [ ] Prend en charge farm, rsbuild, webpack et autres frameworks

> [!WARNING]
De nouvelles fonctionnalités ainsi que des améliorations de stabilité, de compatibilité et de performance sont constamment mises à jour
Il est recommandé d’utiliser la dernière version `pnpm add unplugin-imagemin@latest -D`

> [!WARNING]
Puisque Google [squoosh](https://github.com/GoogleChromeLabs/squoosh) ne maintient plus la version node, ce fork a été créé et certains problèmes de compatibilité ont été corrigés. Détails [squoosh-next](https://github.com/ErKeLost/squoosh-node-latest)

### ✨✨ Développement itératif continu en test

```bash
✨ : unplugin-imagemin
✔ : Processus démarré avec le mode squoosh
✅ : [test1.png] [12.39 MB] -> [102.54 KB]
✔ : Processus démarré avec le mode squoosh
✅ : [test2.png] [16.38 MB] -> [76.79 KB]
```

#### 🌈 Fonctionnalités

- 🍰 Prise en charge des formats png, jpeg, webp, avif, svg, tiff
- 🦾 Haute performance basée sur squoosh
- ✨ Plusieurs formats d’image configurables
- 🪐 Compression du code à la compilation
- 😃 Mécanisme de cache
- 🌈 Conversion de différents types d’images à la compilation

## Squoosh && Svgo

Unplugin-imagemin prend en charge deux outils de compression

[Squoosh](https://github.com/GoogleChromeLabs/squoosh) est une application web de compression d’images qui réduit la taille des images via de nombreux formats.
**Squoosh** avec rust & wasm

[Svgo](https://github.com/svg/svgo) Prise en charge de la compression des images au format svg

## 📦 Installation

```bash
pnpm add unplugin-imagemin@latest -D
```

#### prise en charge de vite et rollup

<details>
<summary>Basique</summary><br>

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
<summary>Avancé</summary><br>

```ts
iimport { defineConfig } from 'vite';
import vue from '@vitejs/plugin-vue';
import imagemin from 'unplugin-imagemin/vite';
// https://vitejs.dev/config/
export default defineConfig({
  plugins: [
    vue(),
    imagemin({
      // true par défaut
      cache: false,
      // Options de configuration par défaut pour la compression de différents types d’images
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

DefaultConfiguration voir [DefaultConfiguration](https://github.com/ErKeLost/unplugin-imagemin/blob/main/src/core/compressOptions.ts)

La configuration des propriétés du plugin se trouve dans [configuration](https://github.com/ErKeLost/unplugin-imagemin/blob/main/src/core/types/index.ts)

```typescript
export interface PluginOptions {
  /**
   * @description Compilation et conversion d'image
   * @default []
   */
  conversion?: ConversionItemType[];
  /**
   * @description Activer ou non la mise en cache
   * @default true
   */
  cache?: boolean;
  /**
   * @description Chemin de l'emplacement du fichier de cache
   * @default ./node_modules/.cache/unplugin-imagemin/.unplugin-imagemin-cache
   */
  cacheLocation?: string;
  /**
   * @description Attribut de compilation
   * @default CompressTypeOptions
   */
  compress?: CompressTypeOptions;
}
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-02

---