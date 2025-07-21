<div align="right">
  <details>
    <summary >🌐 भाषा</summary>
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

एक सामान्य सिंटैक्स जांच प्लगइन, जो कई बिल्ड टूल्स (Webpack, Vite, Rollup, esbuild, Rspack आदि) को सपोर्ट करता है, JavaScript और HTML फाइलों में ECMAScript सिंटैक्स कम्पैटिबिलिटी को जांचने के लिए। यह प्लगइन [rsbuild-plugin-check-syntax](https://github.com/rspack-contrib/rsbuild-plugin-check-syntax) से प्रेरित है।

## फ़ीचर विशेषताएँ

- 🔧 **मल्टी-बिल्ड टूल सपोर्ट**: Webpack, Vite, Rollup, esbuild, Rspack आदि को सपोर्ट करता है
- 📝 **मल्टी-फाइल टाइप**: JavaScript फाइलों और HTML फाइलों के इनलाइन स्क्रिप्ट का सपोर्ट
- 🎯 **सटीक लोकेशन**: Sourcemap सपोर्ट, जिससे स्रोत फाइल की स्थिति का पता लगाया जा सकता है
- ⚙️ **लचीला कॉन्फ़िगरेशन**: फाइलों को बाहर करने, मैन्युअल इनक्लूजन, एरर टाइप फिल्टरिंग आदि विकल्पों का सपोर्ट
- 📁 **स्मार्ट फाइल डिस्कवरी**: Glob मोड के माध्यम से अतिरिक्त JS/HTML फाइलों को मैन्युअली जोड़ सकते हैं
- 🌐 **Browserslist इंटीग्रेशन**: Browserslist कॉन्फ़िगरेशन को अपने आप ECMAScript वर्शन में बदलने का सपोर्ट

## इंस्टॉलेशन


```bash
npm install @winner-fed/unplugin-check-syntax --save-dev
```
## उपयोग विधि

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
### वेबपैक


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
### रोलअप


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
### एसबिल्ड


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
###Rspack


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
## कॉन्फ़िगरेशन विकल्प


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
## उपयोग उदाहरण

### मूल विन्यास


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
### फ़ाइलें बाहर रखें


```ts
checkSyntax({
  targets: ['> 1%', 'last 2 versions'],
  // 排除 node_modules 和测试文件
  exclude: [/node_modules/, /\.test\.js$/],
  // 排除特定输出文件
  excludeOutput: [/vendor\.js$/],
})
```
### अतिरिक्त फ़ाइलें शामिल करें


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
### कस्टम त्रुटि आउटपुट


```ts
checkSyntax({
  targets: ['> 1%', 'last 2 versions'],
  // 只显示错误原因，不显示代码片段
  excludeErrorLogs: ['code', 'output'],
})
```
## माइग्रेशन गाइड

यदि आप `@rsbuild/plugin-check-syntax` से माइग्रेट कर रहे हैं:


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
## कार्य सिद्धांत

1. **निर्माण के बाद जांच**: प्लगइन निर्माण पूरा होने के बाद आउटपुट फाइलों की जांच करता है
2. **सिंटैक्स पार्सिंग**: Acorn पार्सर का उपयोग कर JavaScript सिंटैक्स की जांच करता है
3. **अनुकूलता सत्यापन**: कॉन्फ़िगर की गई ECMAScript संस्करण के अनुसार सिंटैक्स अनुकूलता की पुष्टि करता है
4. **त्रुटि रिपोर्टिंग**: विस्तृत त्रुटि जानकारी प्रदान करता है, जिसमें फाइल स्थान और स्रोत कोड अंश शामिल हैं
5. **Sourcemap समर्थन**: यदि sourcemap मौजूद है, तो वह मूल स्रोत फाइल तक पता लगाता है

## लाइसेंस

MIT License

## योगदान

Issue और Pull Request सबमिट करने का स्वागत है!



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-21

---