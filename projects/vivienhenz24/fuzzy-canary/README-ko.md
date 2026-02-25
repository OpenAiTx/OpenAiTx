

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
### 사용법

사용 방법은 두 가지가 있습니다: 클라이언트 측 또는 서버 측. 가능하면 서버 측을 사용하세요—서버 측이 더 잘 작동합니다. 왜냐하면 카나리가 처음부터 HTML에 포함되어 있기 때문에 자바스크립트를 실행하지 않는 스크래퍼도 이를 볼 수 있기 때문입니다.

**서버 측 (권장):**

React 기반 프레임워크(Next.js, Remix 등)를 사용하는 경우, 루트 레이아웃에 `<Canary />` 컴포넌트를 추가하세요:


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

비-React 프레임워크의 경우, `getCanaryHtml()` 유틸리티를 사용하여 `<body>` 태그 시작 부분에 삽입하세요.

**클라이언트 측:**

정적 사이트를 구축하거나 클라이언트 측 주입을 선호하는 경우, 진입 파일에서 자동 초기화를 가져오세요:

```ts
// Your main entry file (e.g., main.ts, index.ts, App.tsx)
import '@fuzzycanary/core/auto'
```

그게 다입니다. 페이지가 로드될 때 자동으로 캐너리가 주입됩니다.

## SEO에 대한 참고 사항

Fuzzy Canary는 이제 크롤러를 포함한 모든 방문자에게 주입됩니다. 인덱싱이나 순위에 미치는 영향이 걱정된다면, 프로덕션에 배포하기 전에 스테이징 환경에서 테스트하는 것을 고려하세요.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-25

---