<translate-content># unplugin-check-syntax

[![npm version](https://badge.fury.io/js/@winner-fed%2Funplugin-check-syntax.svg)](https://badge.fury.io/js/@winner-fed%2Funplugin-check-syntax)

汎用の構文チェックプラグインで、複数のビルドツール（Webpack、Vite、Rollup、esbuild、Rspack など）をサポートし、JavaScript および HTML ファイル内の ECMAScript 構文互換性をチェックします。このプラグインは [rsbuild-plugin-check-syntax](https://github.com/rspack-contrib/rsbuild-plugin-check-syntax) を参考にしています。

## 機能特徴

- 🔧 **複数ビルドツール対応**: Webpack、Vite、Rollup、esbuild、Rspack などをサポート
- 📝 **複数ファイルタイプ**: JavaScript ファイルと HTML ファイル内のインラインスクリプトに対応
- 🎯 **正確な位置特定**: sourcemap をサポートし、ソースファイルの位置を追跡可能
- ⚙️ **柔軟な設定**: ファイル除外、手動インクルード、エラータイプフィルターなどのオプション対応
- 📁 **スマートファイル検出**: glob パターンで追加の JS/HTML ファイルを手動でインクルード可能
- 🌐 **Browserslist 統合**: browserslist 設定を自動で ECMAScript バージョンに変換対応

## インストール

```bash
npm install @winner-fed/unplugin-check-syntax --save-dev
```
<translate-content>
## 使用方法

### Vite
</translate-content>
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
### ロールアップ


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
## 配置オプション


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
## 使用例

### 基本設定


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
### 排除ファイル


```ts
checkSyntax({
  targets: ['> 1%', 'last 2 versions'],
  // 排除 node_modules 和测试文件
  exclude: [/node_modules/, /\.test\.js$/],
  // 排除特定输出文件
  excludeOutput: [/vendor\.js$/],
})
```
### 追加ファイルの包含


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
### カスタムエラー出力


```ts
checkSyntax({
  targets: ['> 1%', 'last 2 versions'],
  // 只显示错误原因，不显示代码片段
  excludeErrorLogs: ['code', 'output'],
})
```
## 移行ガイド

もし `@rsbuild/plugin-check-syntax` から移行している場合：


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
## 動作原理

1. **ビルド後チェック**: プラグインはビルド完了後に出力ファイルをチェックします
2. **構文解析**: Acorn パーサーを使用して JavaScript の構文を解析します
3. **互換性検証**: 設定された ECMAScript バージョンに基づいて構文の互換性を検証します
4. **エラー報告**: ファイルの位置やソースコードの断片を含む詳細なエラー情報を提供します
5. **Sourcemap 対応**: sourcemap が存在する場合、元のソースファイルを追跡します

## ライセンス

MIT ライセンス

## 貢献

Issue と Pull Request の提出を歓迎します！



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-21

---