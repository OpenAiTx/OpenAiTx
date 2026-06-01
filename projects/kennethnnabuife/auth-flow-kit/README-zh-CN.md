# @kendevelops/auth-flow-kit

一个适合初学者的 **React** 和 **Next.js 13–16（App Router）** 认证工具包。

这实际上是你 Next.js 应用中**最简单且最短的设置**。
你**不**需要额外的包装文件。

---

它为你提供：

- 全局认证状态（类似 Redux / Zustand，但无需配置）
- 预构建的认证 UI 界面（登录、注册、重置）
- 一个简单的 `useAuth()` 钩子，随处可用

本库特意设计得**易于理解**，即使你是认证新手也能轻松上手。

---

## 🔄 无需持久化设置

auth-flow-kit 默认将认证状态保存在内存中，并在应用重新加载时自动恢复会话。

**这在实际中的意义是：**

从开发者的角度看：

> “我刷新页面，仍然保持登录状态。”

就是这么简单。

---

## 📦 安装

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

- 加载时 → 显示加载状态
- 未认证时 → 不渲染任何内容（或如果配置了则重定向）

---

# 🧠 在任何地方使用 `useAuth()` 

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

# 🛠 后端需求

本节定义了您的后端必须实现的精确 API 合约。该库发起三种类型的请求，并期望特定的 JSON 响应格式。

---

## POST `/auth/login`

**请求体：**

```json
{
  "email": "user@example.com",
  "password": "secret123"
}
```

**成功响应 (200):**

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

**错误响应 (4xx)：**

```json
{ "message": "Invalid email or password" }
```

`message` 字段直接显示在登录表单中给用户。

---

## POST `/auth/signup`

**请求体：**

```json
{
  "name": "Jane Doe",
  "email": "user@example.com",
  "password": "secret123"
}
```

> 您可以在注册表单中包含额外字段并传递它们——库会按原样转发完整的负载。

**成功响应 (200)：** 与登录响应形状相同。

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

## POST `/auth/forgot` _(可选)_

仅当您使用 `<PasswordResetScreen />` 时需要。

**请求体：**

```json
{ "email": "user@example.com" }
```
**响应：** 任何 `2xx` 状态码都视为成功。库不会读取响应体 —— 它只是显示“请检查您的电子邮件”确认信息。`404` 会在控制台记录描述性错误，并提供修复 `config.endpoints.forgot` 的指导。

---

## 响应字段参考

| 字段             | 类型   | 必填     | 描述                                                                                              |
| -------------- | ------ | -------- | --------------------------------------------------------------------------------------------------- |
| `accessToken`  | string | ✅       | 存储在 `localStorage` 中，并在认证请求中作为 `Authorization: Bearer <token>` 发送。                  |
| `user`         | object | ✅       | 存储在 `localStorage` 中，并通过 `useAuth().user` 公开。                                           |
| `user.id`      | string | ✅       | 唯一用户标识符。                                                                                   |
| `user.name`    | string | ✅       | 在您的用户界面中使用的显示名称。                                                                    |
| `user.email`   | string | ✅       | 用户的电子邮件地址。                                                                               |
| `refreshToken` | string | ❌       | 库当前接受但未使用，未来会更新。您可以自行包含它以实现自己的逻辑。                                  |

---

## 会话持久化工作原理

auth-flow-kit 完全在客户端处理持久化 —— **您的后端无需会话恢复或 `/me` 端点。**

登录或注册成功时：

- `accessToken` 作为 `afk_access_token` 保存到 `localStorage`
- `user` 作为 `afk_user` 保存到 `localStorage`

页面重新加载时，`AuthProvider` 直接从 `localStorage` 读取 `afk_user` 并即时恢复会话 —— 不会发起网络请求。

登出时，两个键都会被移除。

---

# 🎯 这个库适合谁

- 希望直接开始构建应用而不必担心认证的开发者
- MVP 构建者
- SaaS 仪表盘
- 内部工具
- 想要理解认证机制的学习者

如果你已经有了后端，只想让认证**正常工作**，这个库适合你。

---

# 🎉 总结

**auth-flow-kit** 为你提供：

- 全局认证状态（无 reducer，无 store）
- 预构建的认证 UI 界面
- 简单的后端需求
- 支持刷新安全的认证
- 兼容 Next.js 和纯 React

认证，不再混乱。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-01

---