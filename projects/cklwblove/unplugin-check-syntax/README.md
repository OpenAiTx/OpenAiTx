# unplugin-check-syntax

[![npm version](https://badge.fury.io/js/@winner-fed%2Funplugin-check-syntax.svg)](https://badge.fury.io/js/@winner-fed%2Funplugin-check-syntax)

一个通用的语法检查插件，支持多种构建工具（Webpack、Vite、Rollup、esbuild、Rspack 等），用于检查 JavaScript 和 HTML 文件中的 ECMAScript 语法兼容性。该插件参考了 [rsbuild-plugin-check-syntax](https://github.com/rspack-contrib/rsbuild-plugin-check-syntax)。

## 功能特性

- 🔧 **多构建工具支持**: 支持 Webpack、Vite、Rollup、esbuild、Rspack 等
- 📝 **多文件类型**: 支持 JavaScript 文件和 HTML 文件中的内联脚本
- 🎯 **精确定位**: 支持 sourcemap，可以追溯到源文件位置
- ⚙️ **灵活配置**: 支持文件排除、手动包含、错误类型过滤等选项
- 📁 **智能文件发现**: 支持 glob 模式手动包含额外的 JS/HTML 文件
- 🌐 **Browserslist 集成**: 支持 browserslist 配置自动转换为 ECMAScript 版本

## 安装

```bash
npm install @winner-fed/unplugin-check-syntax --save-dev
```

## 使用方法

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

## 配置选项

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

## 使用示例

### 基础配置

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

### 排除文件

```ts
checkSyntax({
  targets: ['> 1%', 'last 2 versions'],
  // 排除 node_modules 和测试文件
  exclude: [/node_modules/, /\.test\.js$/],
  // 排除特定输出文件
  excludeOutput: [/vendor\.js$/],
})
```

### 包含额外文件

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

### 自定义错误输出

```ts
checkSyntax({
  targets: ['> 1%', 'last 2 versions'],
  // 只显示错误原因，不显示代码片段
  excludeErrorLogs: ['code', 'output'],
})
```

## 迁移指南

如果你正在从 `@rsbuild/plugin-check-syntax` 迁移：

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

## 工作原理

1. **构建后检查**: 插件在构建完成后检查输出文件
2. **语法解析**: 使用 Acorn 解析器检查 JavaScript 语法
3. **兼容性验证**: 根据配置的 ECMAScript 版本验证语法兼容性
4. **错误报告**: 提供详细的错误信息，包括文件位置和源码片段
5. **Sourcemap 支持**: 如果存在 sourcemap，会追溯到原始源文件

## 许可证

MIT License

## 贡献

欢迎提交 Issue 和 Pull Request！
