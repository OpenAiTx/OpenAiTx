# 📦📦 unplugin Imagemin Compressão de Imagens

[![NPM version](https://img.shields.io/npm/v/unplugin-imagemin?color=a1b858&label=)](https://www.npmjs.com/package/unplugin-imagemin)

> [!IMPORTANT]
> **Dicas:**
> `Objetivos 1.0` unplugin-imagemin está se preparando para lançar a versão 1.0, que será lançada após atingir os seguintes objetivos

- [x] Suportar todas as versões do node ao remodificar a sintaxe wasm do squoosh
- [x] remover dependências do sharp
- [x] suportar compressão de imagens do publicDir
- [x] suportar compressão de imagens em css
- [x] Suporte ao modo de cache total
- [x] Suporte ao Node 22 e superiores
- [x] Opções de tipo
- [ ] Suporte a farm, rsbuild, webpack e outros frameworks

> [!WARNING]
Novos recursos, estabilidade, compatibilidade e desempenho estão sendo constantemente atualizados  
Recomendado utilizar a versão mais recente  `pnpm add unplugin-imagemin@latest -D`

> [!WARNING]
Como o Google [squoosh](https://github.com/GoogleChromeLabs/squoosh) não mantém mais a direção node, este fork surgiu e revisou alguns problemas de compatibilidade. Detalhes em [squoosh-next](https://github.com/ErKeLost/squoosh-node-latest)

### ✨✨ Desenvolvimento iterativo contínuo em teste

```bash
✨ : unplugin-imagemin
✔ : Processo iniciado com o modo squoosh
✅ : [test1.png] [12.39 MB] -> [102.54 KB]
✔ : Processo iniciado com o modo squoosh
✅ : [test2.png] [16.38 MB] -> [76.79 KB]
```

#### 🌈 Funcionalidades

- 🍰 Suporte aos formatos png jpeg webp avif svg tiff
- 🦾 Alto desempenho baseado em squoosh
- ✨ Diversos formatos de imagem podem ser configurados
- 🪐 Comprime o código no momento do build
- 😃 Mecanismo de cache
- 🌈 Você pode converter diferentes tipos de imagens durante o build

## Squoosh && Svgo

Unplugin-imagemin suporta duas ferramentas de compressão

[Squoosh](https://github.com/GoogleChromeLabs/squoosh) é um aplicativo web de compressão de imagens que reduz o tamanho das imagens em vários formatos.  
**Squoosh** com rust & wasm

[Svgo](https://github.com/svg/svgo) Suporte à compressão de imagens no formato svg

## 📦 Instalação

```bash
pnpm add unplugin-imagemin@latest -D
```

#### suporte a vite e rollup

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
<summary>Avançado</summary><br>

```ts
iimport { defineConfig } from 'vite';
import vue from '@vitejs/plugin-vue';
import imagemin from 'unplugin-imagemin/vite';
// https://vitejs.dev/config/
export default defineConfig({
  plugins: [
    vue(),
    imagemin({
      // padrão true
      cache: false,
      // Opções de configuração padrão para comprimir diferentes imagens
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

DefaultConfiguration veja [DefaultConfiguration](https://github.com/ErKeLost/unplugin-imagemin/blob/main/src/core/compressOptions.ts)

Configuração de propriedades do plugin veja [configuration](https://github.com/ErKeLost/unplugin-imagemin/blob/main/src/core/types/index.ts)

```typescript
export interface PluginOptions {
  /**
   * @description Compilação e conversão de imagens
   * @default []
   */
  conversion?: ConversionItemType[];
  /**
   * @description Se deseja ativar o cache
   * @default true
   */
  cache?: boolean;
  /**
   * @description Caminho para o local do arquivo de cache
   * @default ./node_modules/.cache/unplugin-imagemin/.unplugin-imagemin-cache
   */
  cacheLocation?: string;
  /**
   * @description Atributo de compilação
   * @default CompressTypeOptions
   */
  compress?: CompressTypeOptions;
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-02

---