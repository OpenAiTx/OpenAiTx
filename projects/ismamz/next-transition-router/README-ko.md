<div align="center">
  <img src="https://raw.githubusercontent.com/ismamz/next-transition-router/main/example/app/icon.svg" alt="next-transition-router" width="100" height="100" />
  <h1>next-transition-router</h1>
</div>

Next.js App Router와 좋아하는 애니메이션 라이브러리를 사용하여 페이지 간 애니메이션 전환을 쉽게 추가하세요.

- [**GSAP를 사용한 라이브 데모**](https://next-transition-router.vercel.app) (소스 코드: [/example](/example)).
- [**Framer Motion을 사용한 Stackblitz 데모**](https://stackblitz.com/edit/next-transition-router-framer-motion).

## 특징

- 페이지 전환을 처리하기 위해 내부 링크를 자동으로 감지 ([선택적 `auto` 플래그](#auto-enabled)).
- 사용자 정의 `Link` 컴포넌트를 사용하여 수동으로 페이지 전환 처리 ([`auto`가 비활성화된 경우](#handle-links-custom-link-component-vs-auto-detection)).
- [Next.js App Router](https://nextjs.org/docs/app) (v14.0.0 이상)와 독점적으로 사용.
- JavaScript 또는 CSS를 사용하여 페이지 간 애니메이션 전환을 빠르게 추가.
- [GSAP](https://gsap.com/resources/React/) 또는 원하는 다른 애니메이션 라이브러리와 원활하게 통합 (자세한 내용은 [최소 GSAP 예제](#minimal-example-using-gsap) 참조).
- JavaScript가 비활성화된 경우에도 라우터의 접근성 손상 없음.
- 매우 가벼우며 번들 크기가 8 KB 미만임.
- [View Transitions API](https://developer.mozilla.org/en-US/docs/Web/API/View_Transitions_API)를 목표로 하지 않고 맞춤형 애니메이션에 집중.

View Transitions API를 사용하려면 [next-view-transitions](https://github.com/shuding/next-view-transitions)를 확인하세요.

> [!WARNING]
> 이 프로젝트는 현재 베타 버전입니다. 기능이 개선되고 정제됨에 따라 API가 변경될 수 있음을 참고하세요.

## 설치

선호하는 패키지 관리자를 사용하여 패키지를 설치하세요:

```sh
pnpm add next-transition-router
```

```sh
yarn add next-transition-router
```

```sh
npm install next-transition-router
```

```sh
bun add next-transition-router
```
## 사용법

### `TransitionRouter`

`TransitionRouter` 프로바이더를 사용하기 위해 클라이언트 컴포넌트(예: `app/providers.tsx`)를 생성합니다:


```tsx
"use client";

import { TransitionRouter } from "next-transition-router";

export function Providers({ children }: { children: React.ReactNode }) {
  return (
    <TransitionRouter
      leave={(next) => {
        someAnimation().then(next);
      }}
      enter={(next) => {
        anotherAnimation().then(next);
      }}
    >
      {children}
    </TransitionRouter>
  );
}
```

> [!NOTE]
> DOM 함수를 프로바이더에 props로 전달해야 하기 때문에 클라이언트 컴포넌트여야 합니다.

그 후에, 해당 컴포넌트를 레이아웃 컴포넌트(e.g.: `app/layout.tsx`)에 임포트해야 합니다.

#### 비동기 콜백

`leave`와 `enter` 콜백은 비동기 함수도 지원합니다.

```tsx
"use client";

import { TransitionRouter } from "next-transition-router";

export function Providers({ children }: { children: React.ReactNode }) {
  return (
    <TransitionRouter
      leave={async (next) => {
        await someAsyncAnimation();
        next();
      }}
      enter={async (next) => {
        await anotherAsyncAnimation();
        next();
      }}
    >
      {children}
    </TransitionRouter>
  );
}
```

#### `leave` 콜백의 `from` 및 `to` 매개변수

`leave` 콜백은 이전 페이지 경로와 다음 페이지 경로를 나타내는 문자열인 `from` 및 `to` 매개변수를 받습니다. 페이지에 따라 전환 애니메이션을 조건부로 적용하려는 경우에 유용합니다.

```tsx
const onLeave = (next, from, to) => {
  someAnimation(from, to).then(next);
};
```

> [!참고]
> `router.back()` 메서드를 사용할 때 `to` 매개변수는 정의되지 않습니다. [프로그래밍 방식 내비게이션](#programmatic-navigation)을 참조하세요.

### 링크 처리 (맞춤형 `Link` 컴포넌트 vs 자동 감지)

링크를 처리하는 방법을 결정하기 위해 `TransitionRouter`는 `auto` 속성(`boolean`)을 받을 수 있습니다.

#### `auto` 비활성화(기본값)

전환을 트리거하기 위해 네이티브 [`Next.js의 Link` 컴포넌트](https://nextjs.org/docs/app/api-reference/components/link) 대신 맞춤형 `Link` 컴포넌트를 사용하세요.

```tsx
import { Link } from "next-transition-router";

export function Example() {
  return <Link href="/about">About</Link>;
}
```

> [!TIP]
> 이름 충돌을 피하기 위해 `import { Link as TransitionLink } from "next-transition-router"`를 사용하세요.

#### `auto` 활성화

`auto`가 활성화되면, `TransitionRouter`는 앵커 링크를 제외한 내부 링크의 클릭 이벤트를 가로채 페이지 전환을 트리거합니다. 이 경우 커스텀 `Link` 컴포넌트를 사용할 필요가 없습니다.

이 모드에서 링크를 무시하려면, 해당 링크에 `data-transition-ignore` 속성을 추가하세요.

### 프로그래밍 방식 내비게이션

`useTransitionRouter` 훅을 사용하여 내비게이션(`push`, `replace`, `back`)을 관리하세요.

이는 전환 지원이 추가된 [Next.js `useRouter`](https://nextjs.org/docs/app/api-reference/functions/use-router)와 유사합니다.

```tsx
"use client";

import { useTransitionRouter } from "next-transition-router";

export function Programmatic() {
  const router = useTransitionRouter();

  return (
    <button
      onClick={() => {
        alert("Do something before navigating away");
        router.push("/about");
      }}
    >
      Go to /about
    </button>
  );
}
```

> [!IMPORTANT]
> 뒤로 가기 및 앞으로 가기 브라우저 탐색은 페이지 전환을 트리거하지 않으며, [이것은 의도된 동작입니다](https://github.com/ismamz/next-transition-router/issues/2).

### 전환 상태

`useTransitionState` 훅을 사용하여 전환의 현재 단계를 확인하세요.

가능한 `stage` 값: `'entering' | 'leaving' | 'none'`.

추가로, `isReady` 상태(`boolean`)가 있습니다.

```tsx
"use client";

import { useTransitionState } from "next-transition-router";

export function Example() {
  const { stage, isReady } = useTransitionState();

  return (
    <div>
      <p>Current stage: {stage}</p>
      <p>Page ready: {isReady ? "Yes" : "No"}</p>
    </div>
  );
}
```

> [!TIP]
> 예를 들어, 페이지 전환이 끝난 후 리빌 애니메이션을 트리거하고 싶을 때 유용합니다.

### 정리

`TransitionRouter`는 메모리 누수를 방지하기 위해 `leave` 및 `enter` 콜백에 대한 정리 함수를 관리합니다.

React의 `useEffect` 훅과 유사하게, 애니메이션을 취소하는 정리 함수를 반환할 수 있습니다.

#### GSAP을 사용한 최소 예제

```tsx
"use client";

import { gsap } from "gsap";
import { TransitionRouter } from "next-transition-router";

export function Providers({ children }: { children: React.ReactNode }) {
  return (
    <TransitionRouter
      leave={(next) => {
        const tween = gsap.fromTo("main", { autoAlpha: 1 }, { autoAlpha: 0, onComplete: next });
        return () => tween.kill();
      }}
      enter={(next) => {
        const tween = gsap.fromTo("main", { autoAlpha: 0 }, { autoAlpha: 1, onComplete: next });
        return () => tween.kill();
      }}
    >
      {children}
    </TransitionRouter>
  );
}
```

## 성능 최적화

종료 애니메이션과 페이지 로딩을 겹쳐 실행할 때(부드러운 전환을 위해 일반적임), React 렌더링이 애니메이션 끊김을 유발할 수 있습니다. `requestAnimationFrame`과 `startTransition`을 사용하여 애니메이션 성능에 우선순위를 부여하세요:

```tsx
import { startTransition } from "react";

enter={(next) => {
  const tl = gsap.timeline()
    .to(".overlay", { y: "-100%", duration: 0.5 })
    .call(() => {
      requestAnimationFrame(() => startTransition(next));
    }, undefined, "<50%"); // Overlap timing preserved
    
  return () => tl.kill();
}}
```
이것은 React 업데이트가 애니메이션 타임라인에 간섭하는 것을 방지하면서 시각적 타이밍을 유지합니다.

## API

### `TransitionRouter`

| Prop       | Type       | Default Value    | Description                                       |
| ---------- | ---------- | ---------------- | ------------------------------------------------- |
| `leave`    | `function` | `next => next()` | 떠나는 애니메이션을 처리하는 함수                  |
| `enter`    | `function` | `next => next()` | 들어오는 애니메이션을 처리하는 함수                 |
| `auto`     | `boolean`  | `false`          | 링크의 자동 감지 활성화/비활성화 플래그             |

### `useTransitionState`

| Property  | Type                                | Description                                        |
|-----------|-------------------------------------|----------------------------------------------------|
| `stage`   | `'entering' \| 'leaving' \| 'none'` | 전환의 현재 단계를 나타냅니다.                       |
| `isReady` | `boolean`                           | 새 페이지가 애니메이션 준비가 되었는지 나타냅니다.  |

## 면책 조항

이 패키지는 모든 사용 사례를 다루지 않을 수 있습니다. 특정 시나리오가 필요한 경우 [이슈를 열어주세요](https://github.com/ismamz/next-transition-router/issues/new/choose), 기능 확장 가능성을 모색할 수 있습니다.

## 라이선스

MIT.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-07

---