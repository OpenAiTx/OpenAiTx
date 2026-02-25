

![Banner](https://raw.githubusercontent.com/vivienhenz24/fuzzy-canary/main/./readme-banner.png)

# Fuzzy Canary

AI companies are scraping everyone's sites for training data. If you're self-hosting your blog, there's not much you can do about it, except maybe make them think your site contains content they won't want. Fuzzy Canary plants invisible links (to porn websites...) in your HTML that trigger scrapers' content safeguards.

<div align="center">

[![npm](https://img.shields.io/npm/v/@fuzzycanary/core)](https://www.npmjs.com/package/@fuzzycanary/core)
[![CI](https://img.shields.io/github/actions/workflow/status/vivienhenz24/fuzzyfrontend/ci.yml?branch=main&label=CI)](https://github.com/vivienhenz24/fuzzyfrontend/actions)
[![License](https://img.shields.io/npm/l/@fuzzycanary/core)](https://github.com/vivienhenz24/fuzzyfrontend/blob/main/LICENSE)
[![npm downloads](https://img.shields.io/npm/dm/@fuzzycanary/core)](https://www.npmjs.com/package/@fuzzycanary/core)
[![Bundle size](https://img.shields.io/bundlephobia/minzip/%40fuzzycanary%2Fcore)](https://bundlephobia.com/package/@fuzzycanary/core)

</div>

## Getting Started

### Installation

```bash
npm i @fuzzycanary/core
# or
pnpm add @fuzzycanary/core
```

### 用法

有两种使用方式：客户端或服务器端。如果可以，使用服务器端——因为 canary 从一开始就在 HTML 中，所以不运行 JavaScript 的爬虫仍然能看到它，效果更好。

**服务器端（推荐）：**

如果你使用基于 React 的框架（Next.js、Remix 等），将 `<Canary />` 组件添加到你的根布局中：

```tsx
// Next.js App Router: app/layout.tsx
// Other React frameworks: your root layout file
import { Canary } from '@fuzzycanary/core/react'

export default function RootLayout({ children }) {
  return (
    <html>
      <body>
        <Canary />
        {children}
      </body>
    </html>
  )
}
```
对于非 React 框架，使用 `getCanaryHtml()` 工具并将其插入到 `<body>` 标签的开头。

**客户端：**

如果您正在构建静态站点或更喜欢客户端注入，请在入口文件中导入自动初始化：


```ts
// Your main entry file (e.g., main.ts, index.ts, App.tsx)
import '@fuzzycanary/core/auto'
```
就是这样。页面加载时会自动注入金丝雀。

## 关于SEO的说明

Fuzzy Canary现在会对每个访问者注入，包括爬虫。如果您担心这会影响索引或排名，建议先在预发布环境中测试，再推向生产环境。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-25

---