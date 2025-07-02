# 📦📦 unplugin Imagemin Compresión de Imágenes

[![NPM version](https://img.shields.io/npm/v/unplugin-imagemin?color=a1b858&label=)](https://www.npmjs.com/package/unplugin-imagemin)

> [!IMPORTANT]
> **Consejos:**
> `Objetivos 1.0` unplugin-imagemin se está preparando para lanzar la versión 1.0, que se publicará tras lograr los siguientes objetivos

- [x] Soportar todas las versiones de node mediante la modificación de la sintaxis wasm de squoosh
- [x] eliminar dependencias de sharp
- [x] soportar compresión de imágenes en publicDir
- [x] soportar compresión de imágenes en css
- [x] Soporte para modo de caché completo
- [x] Soportar Node 22 y superiores
- [x] Opciones tipadas
- [ ] Soporte para farm, rsbuild, webpack y otros frameworks

> [!WARNING]
Nuevas funciones, estabilidad, compatibilidad y mejoras de rendimiento se están actualizando constantemente
Se recomienda usar la última versión  `pnpm add unplugin-imagemin@latest -D`

> [!WARNING]
Debido a que Google [squoosh](https://github.com/GoogleChromeLabs/squoosh) ya no mantiene la versión para node, este fork salió y corrigió algunos problemas de compatibilidad. Más detalles en [squoosh-next](https://github.com/ErKeLost/squoosh-node-latest)

### ✨✨ Desarrollo iterativo continuo en pruebas

```bash
✨ : unplugin-imagemin
✔ : Proceso iniciado en modo squoosh
✅ : [test1.png] [12.39 MB] -> [102.54 KB]
✔ : Proceso iniciado en modo squoosh
✅ : [test2.png] [16.38 MB] -> [76.79 KB]
```

#### 🌈 Características

- 🍰 Soporta formatos png jpeg webp avif svg tiff
- 🦾 Alto rendimiento basado en squoosh
- ✨ Se pueden configurar múltiples formatos de imagen
- 🪐 Comprime el código en tiempo de build
- 😃 Mecanismo de caché
- 🌈 Puedes convertir distintos tipos de imágenes en tiempo de build

## Squoosh && Svgo

Unplugin-imagemin soporta dos herramientas de compresión

[Squoosh](https://github.com/GoogleChromeLabs/squoosh) es una aplicación web de compresión de imágenes que reduce el tamaño de las imágenes en numerosos formatos.
**Squoosh** con rust & wasm

[Svgo](https://github.com/svg/svgo) Soporta la compresión de imágenes en formato svg

## 📦 Instalación

```bash
pnpm add unplugin-imagemin@latest -D
```

#### soporte para vite y rollup

<details>
<summary>Básico</summary><br>

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
<summary>Avanzado</summary><br>

```ts
iimport { defineConfig } from 'vite';
import vue from '@vitejs/plugin-vue';
import imagemin from 'unplugin-imagemin/vite';
// https://vitejs.dev/config/
export default defineConfig({
  plugins: [
    vue(),
    imagemin({
      // por defecto true
      cache: false,
      // Opciones de configuración predeterminadas para comprimir diferentes imágenes
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

DefaultConfiguration ver [DefaultConfiguration](https://github.com/ErKeLost/unplugin-imagemin/blob/main/src/core/compressOptions.ts)

Configuración de propiedades del plugin ver [configuration](https://github.com/ErKeLost/unplugin-imagemin/blob/main/src/core/types/index.ts)

```typescript
export interface PluginOptions {
  /**
   * @description Compilación y conversión de imágenes
   * @default []
   */
  conversion?: ConversionItemType[];
  /**
   * @description Si se debe activar la caché
   * @default true
   */
  cache?: boolean;
  /**
   * @description Ruta a la ubicación del archivo de caché
   * @default ./node_modules/.cache/unplugin-imagemin/.unplugin-imagemin-cache
   */
  cacheLocation?: string;
  /**
   * @description Atributo de compilación
   * @default CompressTypeOptions
   */
  compress?: CompressTypeOptions;
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-02

---