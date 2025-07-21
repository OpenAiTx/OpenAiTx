<div align="right">
  <details>
    <summary >🌐 Lingua</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=cklwblove&project=unplugin-check-syntax&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=cklwblove&project=unplugin-check-syntax&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=cklwblove&project=unplugin-check-syntax&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=cklwblove&project=unplugin-check-syntax&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=cklwblove&project=unplugin-check-syntax&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=cklwblove&project=unplugin-check-syntax&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=cklwblove&project=unplugin-check-syntax&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=cklwblove&project=unplugin-check-syntax&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=cklwblove&project=unplugin-check-syntax&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=cklwblove&project=unplugin-check-syntax&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=cklwblove&project=unplugin-check-syntax&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=cklwblove&project=unplugin-check-syntax&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=cklwblove&project=unplugin-check-syntax&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=cklwblove&project=unplugin-check-syntax&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=cklwblove&project=unplugin-check-syntax&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=cklwblove&project=unplugin-check-syntax&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=cklwblove&project=unplugin-check-syntax&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=cklwblove&project=unplugin-check-syntax&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=cklwblove&project=unplugin-check-syntax&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=cklwblove&project=unplugin-check-syntax&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# unplugin-check-syntax

[![npm version](https://badge.fury.io/js/@winner-fed%2Funplugin-check-syntax.svg)](https://badge.fury.io/js/@winner-fed%2Funplugin-check-syntax)

Un plugin generico per il controllo della sintassi, compatibile con diversi strumenti di build (Webpack, Vite, Rollup, esbuild, Rspack, ecc.), utilizzato per verificare la compatibilità della sintassi ECMAScript nei file JavaScript e HTML. Questo plugin si ispira a [rsbuild-plugin-check-syntax](https://github.com/rspack-contrib/rsbuild-plugin-check-syntax).

## Caratteristiche

- 🔧 **Supporto multi-build tool**: compatibile con Webpack, Vite, Rollup, esbuild, Rspack, ecc.
- 📝 **Supporto multi-file**: compatibile con file JavaScript e script inline all'interno di file HTML
- 🎯 **Localizzazione precisa**: supporto sourcemap, permette di risalire alla posizione nel file sorgente
- ⚙️ **Configurazione flessibile**: supporta esclusioni di file, inclusioni manuali, filtri per tipo di errore e altre opzioni
- 📁 **Rilevamento intelligente dei file**: compatibile con la modalità glob per includere manualmente ulteriori file JS/HTML
- 🌐 **Integrazione Browserslist**: la configurazione browserslist viene convertita automaticamente nella versione ECMAScript

## Installazione


```bash
npm install @winner-fed/unplugin-check-syntax --save-dev
```
## Metodo di utilizzo

### Vite


```ts
// vite.config.ts
import { defineConfig } from 'vite'
import checkSyntax from '@winner-fed/unplugin-check-syntax/vite'

export default defineConfig({
  plugins: [
    checkSyntax({
      targets: ['> 1%', 'last 2 versions'],
      // 或者直接指定 ECMAScript 版本
      // ecmaVersion: 'es2015'
    }),
  ],
})
```
### Webpack


```js
// webpack.config.js
const checkSyntax = require('@winner-fed/unplugin-check-syntax/webpack')

module.exports = {
  plugins: [
    checkSyntax({
      targets: ['> 1%', 'last 2 versions'],
    }),
  ],
}
```
### Rollup


```js
// rollup.config.js
import checkSyntax from '@winner-fed/unplugin-check-syntax/rollup'

export default {
  plugins: [
    checkSyntax({
      targets: ['> 1%', 'last 2 versions'],
    }),
  ],
}
```
### esbuild


```js
// esbuild.config.js
const { build } = require('esbuild')
const checkSyntax = require('@winner-fed/unplugin-check-syntax/esbuild')

build({
  plugins: [
    checkSyntax({
      targets: ['> 1%', 'last 2 versions'],
    }),
  ],
})
```
### Rspack


```js
// rspack.config.js
const checkSyntax = require('@winner-fed/unplugin-check-syntax/rspack')

module.exports = {
  plugins: [
    checkSyntax({
      targets: ['> 1%', 'last 2 versions'],
    }),
  ],
}
```
## Opzioni di configurazione


```ts
interface CheckSyntaxOptions {
  /**
   * 目标浏览器范围，使用 browserslist 格式
   */
  targets?: string[];
  
  /**
   * 直接指定 ECMAScript 版本（优先级高于 targets）
   */
  ecmaVersion?: 'es3' | 'es5' | 'es2015' | 'es2016' | 'es2017' | 'es2018' | 'es2019' | 'es2020' | 'es2021' | 'es2022' | 'latest';
  
  /**
   * 排除源文件检查，支持正则表达式
   */
  exclude?: RegExp | RegExp[];
  
  /**
   * 排除输出文件检查，支持正则表达式  
   */
  excludeOutput?: RegExp | RegExp[];
  
  /**
   * 手动包含额外的 JS 或 HTML 文件进行语法检查
   * 支持文件路径（相对于项目根目录）或 glob 模式
   */
  include?: string[];
  
  /**
   * 排除特定的错误日志类型
   */
  excludeErrorLogs?: ('source' | 'output' | 'reason' | 'code')[];
}
```
## Esempio di utilizzo

### Configurazione di base


```ts
// 使用 browserslist 配置
checkSyntax({
  targets: ['> 1%', 'last 2 versions', 'not dead'],
})

// 直接指定 ECMAScript 版本
checkSyntax({
  ecmaVersion: 'es2015',
})
```
### Escludi file


```ts
checkSyntax({
  targets: ['> 1%', 'last 2 versions'],
  // 排除 node_modules 和测试文件
  exclude: [/node_modules/, /\.test\.js$/],
  // 排除特定输出文件
  excludeOutput: [/vendor\.js$/],
})
```
### Includere file aggiuntivi


```ts
checkSyntax({
  targets: ['> 1%', 'last 2 versions'],
  // 手动包含额外的文件进行检查
  include: [
    'src/legacy/**/*.js',        // 包含 legacy 目录下的所有 JS 文件
    'public/scripts/app.js',     // 包含特定的公共脚本文件
    'docs/**/*.html',            // 包含文档中的 HTML 文件
    '/absolute/path/to/file.js'  // 支持绝对路径
  ],
})
```
### Output di errore personalizzato


```ts
checkSyntax({
  targets: ['> 1%', 'last 2 versions'],
  // 只显示错误原因，不显示代码片段
  excludeErrorLogs: ['code', 'output'],
})
```
## Guida alla migrazione

Se stai migrando da `@rsbuild/plugin-check-syntax`:


```diff
- import { pluginCheckSyntax } from '@rsbuild/plugin-check-syntax'
+ import checkSyntax from '@winner-fed/unplugin-check-syntax/vite' // 或其他构建工具

export default defineConfig({
  plugins: [
-   pluginCheckSyntax({
+   checkSyntax({
      targets: ['> 1%', 'last 2 versions'],
    }),
  ],
})
```
## Principio di funzionamento

1. **Controllo dopo la build**: Il plugin controlla i file di output dopo il completamento della build
2. **Analisi sintattica**: Utilizza il parser Acorn per controllare la sintassi JavaScript
3. **Verifica di compatibilità**: Verifica la compatibilità della sintassi in base alla versione ECMAScript configurata
4. **Segnalazione errori**: Fornisce informazioni dettagliate sugli errori, inclusa la posizione del file e frammenti di codice sorgente
5. **Supporto Sourcemap**: Se esiste una sourcemap, viene effettuato il tracciamento al file sorgente originale

## Licenza

Licenza MIT

## Contributi

Sono benvenuti Issue e Pull Request!



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-21

---