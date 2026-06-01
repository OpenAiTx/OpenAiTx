# @kendevelops/auth-flow-kit

A beginner‑friendly authentication toolkit for **React** and **Next.js 13–16 (App Router)**.

This is literally the **simplest and shortest setup** for your Next.js apps.
You do **not** need extra wrapper files.

---

It gives you:

- Global auth state (Redux / Zustand‑style, but zero setup)
- Prebuilt auth UI screens (Login, Signup, Reset)
- A simple `useAuth()` hook you can use anywhere

This library is intentionally designed to be **easy to understand**, even if you are new to authentication.

---

## 🔄 No Persistence Setup Needed

auth-flow-kit keeps authentication state in memory by default, and automatically restores the session when the app reloads.

**What this means in practice:**

From a developer's point of view:

> "I refresh the page and I'm still logged in."

That's it.

---

## 📦 Installation

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

- While loading → shows a loading state
- If not authenticated → renders nothing (or redirects if configured)

---

# 🧠 Using `useAuth()` Anywhere

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

# 🛠 Backend Requirements

This section defines the exact API contract your backend must implement. The library makes three types of requests and expects specific JSON response shapes.

---

## POST `/auth/login`

**Request body:**

```json
{
  "email": "user@example.com",
  "password": "secret123"
}
```

**Success response (200):**

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

**Error response (4xx):**

```json
{ "message": "Invalid email or password" }
```

The `message` field is displayed directly to the user in the login form.

---

## POST `/auth/signup`

**Request body:**

```json
{
  "name": "Jane Doe",
  "email": "user@example.com",
  "password": "secret123"
}
```

> You can include extra fields in your signup form and pass them through — the library forwards the full payload as-is.

**Success response (200):** Same shape as the login response.

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

## POST `/auth/forgot` _(optional)_

Only needed if you use `<PasswordResetScreen />`.

**Request body:**

```json
{ "email": "user@example.com" }
```

**Response:** Any `2xx` is treated as success. The library does not read the response body — it just shows a "Check your email" confirmation. A `404` logs a descriptive console error with guidance on fixing `config.endpoints.forgot`.

---

## Response field reference

| Field          | Type   | Required | Description                                                                                         |
| -------------- | ------ | -------- | --------------------------------------------------------------------------------------------------- |
| `accessToken`  | string | ✅       | Stored in `localStorage` and sent as `Authorization: Bearer <token>` on authenticated requests.     |
| `user`         | object | ✅       | Stored in `localStorage` and exposed via `useAuth().user`.                                          |
| `user.id`      | string | ✅       | Unique user identifier.                                                                             |
| `user.name`    | string | ✅       | Display name used in your UI.                                                                       |
| `user.email`   | string | ✅       | User's email address.                                                                               |
| `refreshToken` | string | ❌       | Accepted but not used by the library for now, updating soon. You can include it for your own logic. |

---

## How session persistence works

auth-flow-kit handles persistence entirely on the client — **your backend does not need a session restore or `/me` endpoint.**

On successful login or signup:

- `accessToken` is saved to `localStorage` as `afk_access_token`
- `user` is saved to `localStorage` as `afk_user`

On page reload, `AuthProvider` reads `afk_user` directly from `localStorage` and restores the session instantly — no network request is made.

On logout, both keys are removed.

---

# 🎯 Who This Library Is For

- Developers who want to go straight into building their app before worrying about auth
- MVP builders
- SaaS dashboards
- Internal tools
- Learners who want to understand authentication

If you already have a backend and just want auth to **work**, this library is for you.

---

# 🎉 Summary

**auth-flow-kit** gives you:

- Global auth state (no reducers, no stores)
- Prebuilt auth UI screens
- Simple backend requirements
- Refresh‑safe authentication
- Works with Next.js and plain React

Authentication, without the chaos.
