

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

### 使い方

使用方法は2つあります：クライアントサイドかサーバーサイドです。可能であればサーバーサイドを使ってください。HTMLに最初からカナリアがあるため、JavaScriptを実行しないスクレイパーでも検出できます。

**サーバーサイド（推奨）：**

Reactベースのフレームワーク（Next.js、Remixなど）を使用している場合は、ルートレイアウトに `<Canary />` コンポーネントを追加してください：

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

非Reactフレームワークの場合は、`getCanaryHtml()` ユーティリティを使用し、`<body>` タグの先頭に挿入してください。

**クライアントサイド：**

静的サイトを構築している場合やクライアントサイドでの挿入を好む場合は、エントリーファイルに自動初期化をインポートしてください：

```ts
// Your main entry file (e.g., main.ts, index.ts, App.tsx)
import '@fuzzycanary/core/auto'
```

以上です。ページが読み込まれると自動的にカナリアが注入されます。

## SEOに関する注意点

Fuzzy Canaryは、クローラーを含むすべての訪問者に対して注入を行います。インデックス作成やランキングへの影響が心配な場合は、本番環境に展開する前にステージング環境でテストすることを検討してください。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-25

---