<div align="right">
  <details>
    <summary >🌐 ภาษา</summary>
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

ปลั๊กอินตรวจสอบไวยากรณ์ที่ใช้งานได้ทั่วไป รองรับเครื่องมือสร้างหลายแบบ (Webpack, Vite, Rollup, esbuild, Rspack ฯลฯ) สำหรับตรวจสอบความเข้ากันได้ของไวยากรณ์ ECMAScript ในไฟล์ JavaScript และ HTML ปลั๊กอินนี้อ้างอิงจาก [rsbuild-plugin-check-syntax](https://github.com/rspack-contrib/rsbuild-plugin-check-syntax)

## คุณสมบัติ

- 🔧 **รองรับเครื่องมือสร้างหลายแบบ**: รองรับ Webpack, Vite, Rollup, esbuild, Rspack ฯลฯ
- 📝 **รองรับหลายประเภทไฟล์**: รองรับไฟล์ JavaScript และสคริปต์แบบอินไลน์ในไฟล์ HTML
- 🎯 **ระบุจุดผิดพลาดได้แม่นยำ**: รองรับ sourcemap สามารถย้อนกลับไปยังตำแหน่งไฟล์ต้นฉบับได้
- ⚙️ **ปรับแต่งได้ยืดหยุ่น**: รองรับการยกเว้นไฟล์, การเพิ่มไฟล์แบบกำหนดเอง, การกรองประเภทข้อผิดพลาด ฯลฯ
- 📁 **ค้นหาไฟล์อย่างชาญฉลาด**: รองรับโหมด glob เพื่อเพิ่มไฟล์ JS/HTML เพิ่มเติมด้วยตนเอง
- 🌐 **ผสานกับ Browserslist**: รองรับการแปลงค่าการตั้งค่า browserslist ไปเป็นเวอร์ชัน ECMAScript อัตโนมัติ

## การติดตั้ง


```bash
npm install @winner-fed/unplugin-check-syntax --save-dev
```
## วิธีการใช้งาน

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
### เว็บแพ็ค


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
### โรลอัป


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
### อาร์เอสแพ็ค

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
## ตัวเลือกการกำหนดค่า


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
## ตัวอย่างการใช้งาน

### การตั้งค่าพื้นฐาน


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
### ไฟล์ที่ยกเว้น


```ts
checkSyntax({
  targets: ['> 1%', 'last 2 versions'],
  // 排除 node_modules 和测试文件
  exclude: [/node_modules/, /\.test\.js$/],
  // 排除特定输出文件
  excludeOutput: [/vendor\.js$/],
})
```
### รวมไฟล์เพิ่มเติม


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
### การแสดงข้อผิดพลาดแบบกำหนดเอง


```ts
checkSyntax({
  targets: ['> 1%', 'last 2 versions'],
  // 只显示错误原因，不显示代码片段
  excludeErrorLogs: ['code', 'output'],
})
```
## คู่มือการย้าย

หากคุณกำลังย้ายจาก `@rsbuild/plugin-check-syntax`


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
## หลักการทำงาน

1. **ตรวจสอบหลังการสร้าง**: ปลั๊กอินจะตรวจสอบไฟล์ผลลัพธ์หลังจากการสร้างเสร็จสิ้น
2. **วิเคราะห์ไวยากรณ์**: ใช้ตัวแปลความหมาย Acorn เพื่อตรวจสอบไวยากรณ์ JavaScript
3. **ตรวจสอบความเข้ากันได้**: ตรวจสอบความเข้ากันได้ของไวยากรณ์ตามเวอร์ชัน ECMAScript ที่กำหนดไว้
4. **รายงานข้อผิดพลาด**: ให้ข้อมูลข้อผิดพลาดโดยละเอียด รวมถึงตำแหน่งไฟล์และส่วนของซอร์สโค้ด
5. **รองรับ Sourcemap**: หากมี sourcemap จะย้อนกลับไปยังไฟล์ต้นฉบับดั้งเดิม

## ใบอนุญาต

MIT License

## การมีส่วนร่วม

ยินดีต้อนรับการส่ง Issue และ Pull Request!



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-21

---