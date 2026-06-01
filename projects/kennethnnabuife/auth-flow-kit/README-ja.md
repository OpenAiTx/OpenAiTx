# @kendevelops/auth-flow-kit

**React** と **Next.js 13–16 (App Router)** 向けの初心者に優しい認証ツールキット。

これは Next.js アプリのための文字通り **最も簡単で最短のセットアップ** です。  
追加のラッパーファイルは **不要** です。

---

提供内容：

- グローバル認証状態（Redux / Zustand スタイル、だがセットアップ不要）  
- 事前構築された認証UI画面（ログイン、サインアップ、リセット）  
- どこでも使えるシンプルな `useAuth()` フック

このライブラリは認証が初めての方でも **理解しやすい** ように意図的に設計されています。

---

## 🔄 永続化セットアップ不要

auth-flow-kit は認証状態をデフォルトでメモリ内に保持し、アプリがリロードされると自動的にセッションを復元します。

**実際に意味すること：**

開発者の視点から：

> 「ページをリフレッシュしてもログイン状態が維持されている」

それだけです。

---

## 📦 インストール

```bash
npm install @kendevelops/auth-flow-kit
```

```bash
yarn add @kendevelops/auth-flow-kit
```

```bash
bun add @kendevelops/auth-flow-kit
```

---

# 🚀 Usage with Next.js App Router (Recommended)

---

## Step 1: Wrap your app in `app/layout.tsx`

> Yes, `layout.tsx` can be a client component when it hosts providers. This is normal.

```tsx
// app/layout.tsx
"use client";

import { AuthProvider } from "@kendevelops/auth-flow-kit";

export default function RootLayout({
  children,
}: {
  children: React.ReactNode;
}) {
  return (
    <html lang="en">
      <body>
        <AuthProvider
          config={{
            baseURL: "https://your-backend-url.com",
            endpoints: {
              login: "/auth/login",
              signup: "/auth/signup",
              forgot: "/auth/forgot",
            },
          }}
        >
          {children}
        </AuthProvider>
      </body>
    </html>
  );
}
```

This makes auth **global** and available everywhere.

---

## Step 2: Use auth screens in `app/page.tsx`

```tsx
// app/page.tsx
"use client";

import {
  LoginScreen,
  SignupScreen,
  PasswordResetScreen,
  Protected,
  useAuth,
} from "@kendevelops/auth-flow-kit";

import { useEffect, useState } from "react";

export default function Home() {
  const { user } = useAuth();
  const [page, setPage] = useState<"login" | "signup" | "reset" | "dashboard">(
    "login",
  );

  // Keep UI in sync with auth (important on refresh)
  useEffect(() => {
    if (user) setPage("dashboard");
  }, [user]);

  return (
    <>
      {page === "login" && <LoginScreen />}
      {page === "signup" && <SignupScreen />}
      {page === "reset" && <PasswordResetScreen />}

      {page === "dashboard" && (
        <Protected>
          <Dashboard />
        </Protected>
      )}
    </>
  );
}

function Dashboard() {
  const { user, logout } = useAuth();

  return (
    <div>
      <h1>Dashboard</h1>
      <p>Welcome {user?.name}</p>
      <button onClick={logout}>Logout</button>
    </div>
  );
}
```

---

# 🔒 Protecting Components

Wrap anything that requires authentication:

```tsx
<Protected>
  <SecretArea />
</Protected>
```

- 読み込み中 → ローディング状態を表示
- 認証されていない場合 → 何も表示しない（または設定されていればリダイレクト）

---

# 🧠 どこでも `useAuth()` を使う方法

```tsx
"use client";
import { useAuth } from "@kendevelops/auth-flow-kit";

export default function Navbar() {
  const { user, logout } = useAuth();

  return (
    <nav>
      {user ? (
        <>
          <span>Hello {user.name}</span>
          <button onClick={logout}>Logout</button>
        </>
      ) : (
        <span>Not logged in</span>
      )}
    </nav>
  );
}
```

---

# 🌐 React (Non‑Next.js) Usage

```tsx
import { AuthProvider, LoginScreen } from "@kendevelops/auth-flow-kit";

export default function App() {
  return (
    <AuthProvider
      config={{
        baseURL: "https://your-backend-url.com",
        endpoints: {
          login: "/auth/login",
          signup: "/auth/signup",
          forgot: "/auth/forgot",
        },
      }}
    >
      <LoginScreen />
    </AuthProvider>
  );
}
```

---

# 🛠 バックエンド要件

このセクションでは、バックエンドが実装すべき正確なAPI契約を定義します。ライブラリは3種類のリクエストを行い、特定のJSONレスポンス形式を期待します。

---

## POST `/auth/login`

**リクエストボディ:**

```json
{
  "email": "user@example.com",
  "password": "secret123"
}
```

**成功レスポンス (200):**

```json
{
  "accessToken": "your-token-here",
  "user": {
    "id": "usr_abc123",
    "name": "Jane Doe",
    "email": "user@example.com"
  }
}
```

**エラー応答（4xx）：**

```json
{ "message": "Invalid email or password" }
```

`message` フィールドはログインフォームでユーザーに直接表示されます。

---

## POST `/auth/signup`

**リクエストボディ:**

```json
{
  "name": "Jane Doe",
  "email": "user@example.com",
  "password": "secret123"
}
```

> サインアップフォームに追加フィールドを含めて渡すことができます — ライブラリはペイロード全体をそのまま転送します。

**成功レスポンス（200）：** ログインレスポンスと同じ形式です。

```json
{
  "accessToken": "your-token-here",
  "user": {
    "id": "usr_xyz789",
    "name": "Jane Doe",
    "email": "user@example.com"
  }
}
```

---

## POST `/auth/forgot` _(オプション)_

`<PasswordResetScreen />` を使用する場合のみ必要です。

**リクエストボディ:**

```json
{ "email": "user@example.com" }
```
**Response:** すべての `2xx` は成功として扱われます。ライブラリはレスポンスボディを読み取りません — 「メールを確認してください」という確認メッセージを表示するだけです。`404` は `config.endpoints.forgot` の修正方法に関するガイダンス付きの詳細なコンソールエラーを記録します。

---

## レスポンスフィールドリファレンス

| フィールド           | 型       | 必須     | 説明                                                                                              |
| -------------------- | -------- | -------- | ------------------------------------------------------------------------------------------------- |
| `accessToken`        | string   | ✅       | `localStorage` に保存され、認証されたリクエストで `Authorization: Bearer <token>` として送信されます。 |
| `user`               | object   | ✅       | `localStorage` に保存され、`useAuth().user` を通じて利用可能です。                               |
| `user.id`            | string   | ✅       | ユニークなユーザー識別子。                                                                       |
| `user.name`          | string   | ✅       | UIで使用される表示名。                                                                            |
| `user.email`         | string   | ✅       | ユーザーのメールアドレス。                                                                        |
| `refreshToken`       | string   | ❌       | 受け入れられますが、現在ライブラリでは使用されていません。近日中に更新予定です。独自のロジックで使用可能です。 |

---

## セッション永続化の仕組み

auth-flow-kit は永続化を完全にクライアント側で処理します — **バックエンドにセッション復元や `/me` エンドポイントは不要です。**

ログインまたはサインアップ成功時：

- `accessToken` を `afk_access_token` として `localStorage` に保存
- `user` を `afk_user` として `localStorage` に保存

ページ再読み込み時、`AuthProvider` は `localStorage` から直接 `afk_user` を読み取り、セッションを即座に復元します — ネットワークリクエストは行いません。

ログアウト時は両方のキーが削除されます。

---

# 🎯 このライブラリが対象とするユーザー

- 認証を気にせずすぐにアプリ開発に取り掛かりたい開発者
- MVP ビルダー
- SaaS ダッシュボード
- 社内ツール
- 認証を学びたい学習者


すでにバックエンドがあり、認証を**動作させたい**だけなら、このライブラリが最適です。

---

# 🎉 サマリー

**auth-flow-kit** は以下を提供します：

- グローバル認証状態（リデューサーやストア不要）
- 事前構築された認証UI画面
- シンプルなバックエンド要件
- リフレッシュ安全な認証
- Next.jsやプレーンなReactで動作

混乱のない認証を。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-01

---