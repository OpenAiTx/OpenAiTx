<div align="center">
  <img src="https://raw.githubusercontent.com/ismamz/next-transition-router/main/example/app/icon.svg" alt="next-transition-router" width="100" height="100" />
  <h1>next-transition-router</h1>
</div>

轻松使用 Next.js App Router 及您喜欢的动画库，在页面之间添加动画过渡效果。

- [**使用 GSAP 的在线演示**](https://next-transition-router.vercel.app)（源码：[/example](/example)）。
- [**使用 Framer Motion 的 Stackblitz 演示**](https://stackblitz.com/edit/next-transition-router-framer-motion)。

## 特性

- 自动检测内部链接以处理页面过渡（[可选的 `auto` 标志](#auto-enabled)）。
- 使用自定义的 `Link` 组件手动处理页面过渡（[当 `auto` 被禁用时](#handle-links-custom-link-component-vs-auto-detection)）。
- 专门用于 [Next.js App Router](https://nextjs.org/docs/app)（版本 14.0.0 或更高）。
- 快速通过 JavaScript 或 CSS 添加页面之间的动画过渡。
- 无缝集成 [GSAP](https://gsap.com/resources/React/) 或您选择的任何其他动画库（参见 [使用 GSAP 的最小示例](#minimal-example-using-gsap)）。
- 如果禁用 JavaScript，路由的可访问性不受影响。
- 非常轻量；打包大小小于 8 KB。
- 专注于可定制动画，不针对 [View Transitions API](https://developer.mozilla.org/en-US/docs/Web/API/View_Transitions_API)。

如果您想使用 View Transitions API，请查看 [next-view-transitions](https://github.com/shuding/next-view-transitions)。

> [!WARNING]
> 本项目目前处于测试阶段。请注意，随着功能的增强和完善，API 可能会发生变化。

## 安装

使用您喜欢的包管理器安装此包：

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

## 使用方法

### `TransitionRouter`

创建一个客户端组件（例如：`app/providers.tsx`）来使用 `TransitionRouter` 提供程序：

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

> [!注意]
> 它应该是一个客户端组件，因为你必须将 DOM 函数作为属性传递给提供者。

之后，你应该在布局组件中导入该组件（例如：`app/layout.tsx`）。

#### 异步回调

`leave` 和 `enter` 回调支持异步函数。

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

#### `leave` 回调的 `from` 和 `to` 参数

`leave` 回调接收 `from` 和 `to` 参数，它们是包含前一个和下一个页面路径的字符串。  
如果你想基于页面有条件地执行动画过渡，这非常有用。
```tsx
const onLeave = (next, from, to) => {
  someAnimation(from, to).then(next);
};
```

> [!注意]
> 使用 `router.back()` 方法时，`to` 参数将为未定义。请参见[编程式导航](#programmatic-navigation)。

### 处理链接（自定义 `Link` 组件与自动检测）

为了确定如何处理链接，`TransitionRouter` 可以接收一个 `auto` 属性（`boolean` 类型）。

#### 关闭 `auto`（默认）

使用自定义的 `Link` 组件，而不是原生的 [Next.js 中的 `Link` 组件](https://nextjs.org/docs/app/api-reference/components/link) 来触发过渡。

```tsx
import { Link } from "next-transition-router";

export function Example() {
  return <Link href="/about">About</Link>;
}
```

> [!提示]
> 使用 `import { Link as TransitionLink } from "next-transition-router"` 以避免命名冲突。

#### 启用 `auto`

当启用 `auto` 时，`TransitionRouter` 会拦截内部链接（锚点链接除外）的点击事件，并触发页面过渡。在这种情况下，您无需使用自定义的 `Link` 组件。

要在此模式下忽略某个链接，只需给该链接添加 `data-transition-ignore` 属性。

### 编程式导航

使用 `useTransitionRouter` 钩子来管理导航（`push`、`replace`、`back`）。

它类似于 [Next.js 的 `useRouter`](https://nextjs.org/docs/app/api-reference/functions/use-router)，但增加了过渡支持。

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
> 浏览器的前进和后退导航不会触发页面过渡，[这是故意设计的](https://github.com/ismamz/next-transition-router/issues/2)。

### 过渡状态

使用 `useTransitionState` 钩子来确定过渡的当前阶段。

可能的 `stage` 值：`'entering' | 'leaving' | 'none'`。

此外，你还有 `isReady` 状态（`boolean`）。

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
> 例如，如果您想在页面过渡结束后触发一个显示动画，这非常有用。

### 清理

`TransitionRouter` 管理 `leave` 和 `enter` 回调的清理函数，以防止内存泄漏。

类似于 React 的 `useEffect` 钩子，您可以返回一个清理函数来取消动画。

#### 使用 GSAP 的最小示例

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

## 性能优化

当退出动画与页面加载重叠时（常见于平滑过渡），React 渲染可能导致动画卡顿。使用 `requestAnimationFrame` 和 `startTransition` 来优先保证动画性能：

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
这防止了 React 更新干扰您的动画时间线，同时保持视觉时序。

## API

### `TransitionRouter`

| 属性       | 类型       | 默认值          | 描述                                              |
| ---------- | ---------- | --------------- | ------------------------------------------------- |
| `leave`    | `function` | `next => next()` | 处理离开动画的函数                                 |
| `enter`    | `function` | `next => next()` | 处理进入动画的函数                                 |
| `auto`     | `boolean`  | `false`          | 启用/禁用链接自动检测的标志                         |

### `useTransitionState`

| 属性       | 类型                                | 描述                                               |
|------------|-----------------------------------|----------------------------------------------------|
| `stage`    | `'entering' \| 'leaving' \| 'none'` | 指示当前过渡的阶段                                 |
| `isReady`  | `boolean`                         | 指示新页面是否准备好进行动画                       |

## 免责声明

此包可能无法涵盖所有使用场景。如果您有特定需求，请[打开问题](https://github.com/ismamz/next-transition-router/issues/new/choose)，我们可以探讨扩展功能的可能性。

## 许可证

MIT。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-07

---