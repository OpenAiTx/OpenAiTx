<translate-content># unplugin-check-syntax

[![npm version](https://badge.fury.io/js/@winner-fed%2Funplugin-check-syntax.svg)](https://badge.fury.io/js/@winner-fed%2Funplugin-check-syntax)

범용 문법 검사 플러그인으로, Webpack, Vite, Rollup, esbuild, Rspack 등 다양한 빌드 도구를 지원하며 JavaScript와 HTML 파일 내 ECMAScript 문법 호환성을 검사합니다. 이 플러그인은 [rsbuild-plugin-check-syntax](https://github.com/rspack-contrib/rsbuild-plugin-check-syntax)를 참고하였습니다.

## 기능 특징

- 🔧 **다중 빌드 도구 지원**: Webpack, Vite, Rollup, esbuild, Rspack 등 지원
- 📝 **다중 파일 유형**: JavaScript 파일 및 HTML 파일 내 인라인 스크립트 지원
- 🎯 **정확한 위치 지정**: sourcemap 지원으로 소스 파일 위치 추적 가능
- ⚙️ **유연한 구성**: 파일 제외, 수동 포함, 오류 유형 필터링 등의 옵션 지원
- 📁 **스마트 파일 탐색**: glob 패턴으로 추가 JS/HTML 파일 수동 포함 지원
- 🌐 **Browserslist 통합**: browserslist 설정을 자동으로 ECMAScript 버전으로 변환 지원

## 설치

```bash
npm install @winner-fed/unplugin-check-syntax --save-dev
```
## 사용 방법

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
### 웹팩


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
### 롤업


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
## 구성 옵션


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
## 사용 예제

### 기본 구성


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
### 제외 파일


```ts
checkSyntax({
  targets: ['> 1%', 'last 2 versions'],
  // 排除 node_modules 和测试文件
  exclude: [/node_modules/, /\.test\.js$/],
  // 排除特定输出文件
  excludeOutput: [/vendor\.js$/],
})
```
### 추가 파일 포함


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
### 사용자 정의 오류 출력


```ts
checkSyntax({
  targets: ['> 1%', 'last 2 versions'],
  // 只显示错误原因，不显示代码片段
  excludeErrorLogs: ['code', 'output'],
})
```
## 마이그레이션 가이드

만약 당신이 `@rsbuild/plugin-check-syntax`에서 마이그레이션 중이라면:


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
## 작동 원리

1. **빌드 후 검사**: 플러그인은 빌드가 완료된 후 출력 파일을 검사합니다  
2. **구문 분석**: Acorn 파서를 사용하여 JavaScript 구문을 검사합니다  
3. **호환성 검증**: 구성된 ECMAScript 버전에 따라 구문 호환성을 검증합니다  
4. **오류 보고**: 파일 위치와 소스 코드 조각을 포함한 자세한 오류 정보를 제공합니다  
5. **Sourcemap 지원**: sourcemap이 존재하는 경우 원본 소스 파일까지 추적합니다  

## 라이선스

MIT License

## 기여

이슈 및 풀 리퀘스트 제출을 환영합니다!



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-21

---