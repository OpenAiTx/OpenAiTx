<div align="center">
  <img src="https://raw.githubusercontent.com/ismamz/next-transition-router/main/example/app/icon.svg" alt="next-transition-router" width="100" height="100" />
  <h1>next-transition-router</h1>
</div>

Next.js App Router とお好みのアニメーションライブラリを使って、ページ間のアニメーション遷移を簡単に追加できます。

- [**GSAPを使ったライブデモ**](https://next-transition-router.vercel.app)（ソースコード: [/example](/example)）。
- [**Framer Motionを使ったStackblitzデモ**](https://stackblitz.com/edit/next-transition-router-framer-motion)。

## 特徴

- 内部リンクを自動検出してページ遷移を処理（[オプションの `auto` フラグ](#auto-enabled)）。
- カスタム `Link` コンポーネントを使用して手動でページ遷移を処理（[`auto` が無効の場合](#handle-links-custom-link-component-vs-auto-detection)）。
- [Next.js App Router](https://nextjs.org/docs/app)（v14.0.0以上）専用。
- JavaScript または CSS を使ってページ間にアニメーション遷移を素早く追加。
- [GSAP](https://gsap.com/resources/React/) や任意のアニメーションライブラリとシームレスに統合可能（[最小限のGSAP例](#minimal-example-using-gsap)を参照）。
- JavaScriptが無効でもルーターのアクセシビリティは損なわれません。
- 非常に軽量で、バンドルサイズは8KB未満。
- [View Transitions API](https://developer.mozilla.org/en-US/docs/Web/API/View_Transitions_API) には対応せず、カスタマイズ可能なアニメーションに注力。

View Transitions API を使いたい場合は、[next-view-transitions](https://github.com/shuding/next-view-transitions) をご覧ください。

> [!WARNING]
> 本プロジェクトは現在ベータ版です。機能の拡張や改良に伴い、APIが変更される可能性がありますのでご注意ください。

## インストール

お好みのパッケージマネージャーを使ってパッケージをインストールしてください：

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

## 使用法

### `TransitionRouter`

`TransitionRouter` プロバイダーを使用するためにクライアントコンポーネント（例：`app/providers.tsx`）を作成します：

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
> プロバイダーにDOM関数をpropsとして渡す必要があるため、クライアントコンポーネントである必要があります。

その後、そのコンポーネントをレイアウトコンポーネント（例：`app/layout.tsx`）にインポートしてください。

#### 非同期コールバック

`leave` と `enter` のコールバックは非同期関数をサポートしています。

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

#### `leave` コールバックの `from` と `to` パラメータ

`leave` コールバックは `from` と `to` パラメータを受け取ります。これらは前のページと次のページのパスを表す文字列です。ページに基づいて条件付きでトランジションをアニメーションさせたい場合に便利です。

```tsx
const onLeave = (next, from, to) => {
  someAnimation(from, to).then(next);
};
```

> [!注意]
> `router.back()` メソッドを使用する場合、`to` パラメータは未定義になります。[プログラムによるナビゲーション](#programmatic-navigation)を参照してください。

### リンクの扱い（カスタム `Link` コンポーネント vs 自動検出）

リンクの扱いを決定するために、`TransitionRouter` は `auto` プロパティ（`boolean`）を受け取ることができます。

#### `auto` 無効（デフォルト）

トランジションをトリガーするために、ネイティブの [Next.js の `Link` コンポーネント](https://nextjs.org/docs/app/api-reference/components/link) の代わりにカスタム `Link` コンポーネントを使用します。

```tsx
import { Link } from "next-transition-router";

export function Example() {
  return <Link href="/about">About</Link>;
}
```

> [!TIP]
> 名前の競合を避けるために、`import { Link as TransitionLink } from "next-transition-router"` を使用してください。

#### `auto` 有効時

`auto` が有効な場合、`TransitionRouter` は内部リンク（アンカーリンクを除く）のクリックイベントをインターセプトし、ページ遷移をトリガーします。この場合、カスタムの `Link` コンポーネントを使用する必要はありません。

このモードでリンクを無視するには、単にリンクに `data-transition-ignore` 属性を追加してください。

### プログラム的なナビゲーション

ナビゲーション（`push`、`replace`、`back`）を管理するには、`useTransitionRouter` フックを使用します。

これは、トランジションサポートを追加した [Next.js の `useRouter`](https://nextjs.org/docs/app/api-reference/functions/use-router) に似ています。

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
> ブラウザの「戻る」および「進む」ナビゲーションはページ遷移をトリガーしません。これは[意図された動作です](https://github.com/ismamz/next-transition-router/issues/2)。

### トランジション状態

`useTransitionState` フックを使って、トランジションの現在の段階を判別します。

可能な `stage` の値： `'entering' | 'leaving' | 'none'`。

さらに、`isReady` ステート（`boolean`）も利用できます。

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
> これは、例えばページ遷移が終了した後にリビールアニメーションをトリガーしたい場合に便利です。

### クリーンアップ

`TransitionRouter` は、メモリリークを防ぐために `leave` と `enter` のコールバックのクリーンアップ関数を管理します。

React の `useEffect` フックと同様に、アニメーションをキャンセルするためのクリーンアップ関数を返すことができます。

#### GSAP を使った最小限の例

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

## パフォーマンス最適化

ページ読み込みと重なる退出アニメーション（スムーズな遷移のために一般的）では、Reactのレンダリングがアニメーションのカクつきを引き起こすことがあります。`requestAnimationFrame`と`startTransition`を使用してアニメーションのパフォーマンスを優先しましょう：

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
これは、Reactの更新がアニメーションタイムラインに干渉するのを防ぎつつ、視覚的なタイミングを維持します。

## API

### `TransitionRouter`

| Prop       | Type       | Default Value    | Description                                       |
| ---------- | ---------- | ---------------- | ------------------------------------------------- |
| `leave`    | `function` | `next => next()` | 離脱アニメーションを処理する関数                    |
| `enter`    | `function` | `next => next()` | 進入アニメーションを処理する関数                    |
| `auto`     | `boolean`  | `false`          | リンクの自動検出を有効／無効にするフラグ              |

### `useTransitionState`

| Property  | Type                                | Description                                        |
|-----------|-------------------------------------|----------------------------------------------------|
| `stage`   | `'entering' \| 'leaving' \| 'none'` | トランジションの現在のステージを示します。           |
| `isReady` | `boolean`                           | 新しいページがアニメーションの準備ができているかを示します。 |

## 免責事項

このパッケージはすべてのユースケースをカバーしているわけではありません。特定のシナリオが必要な場合は、[issueを開いて](https://github.com/ismamz/next-transition-router/issues/new/choose)いただければ、機能拡張の可能性を検討します。

## ライセンス

MIT。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-07

---