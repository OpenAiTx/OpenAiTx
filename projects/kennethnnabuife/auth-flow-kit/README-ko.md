# @kendevelops/auth-flow-kit

초보자 친화적인 **React** 및 **Next.js 13–16 (App Router)**용 인증 툴킷입니다.

이것은 Next.js 앱을 위한 **가장 간단하고 짧은 설정**입니다.  
추가 래퍼 파일이 **필요하지 않습니다**.

---

다음 기능을 제공합니다:

- 전역 인증 상태 (Redux / Zustand 스타일이지만 설정 불필요)  
- 미리 만들어진 인증 UI 화면 (로그인, 회원가입, 비밀번호 재설정)  
- 어디서나 사용할 수 있는 간단한 `useAuth()` 훅

이 라이브러리는 인증에 익숙하지 않은 분들도 **쉽게 이해할 수 있도록** 의도적으로 설계되었습니다.

---

## 🔄 별도의 지속성 설정 불필요

auth-flow-kit은 기본적으로 인증 상태를 메모리에 저장하며, 앱이 다시 로드될 때 세션을 자동으로 복원합니다.

**실제로 의미하는 바는 다음과 같습니다:**

개발자 입장에서:

> "페이지를 새로고침해도 여전히 로그인 상태입니다."

그게 전부입니다.

---

## 📦 설치

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

- 로딩 중 → 로딩 상태를 표시합니다
- 인증되지 않은 경우 → 아무 것도 렌더링하지 않음 (또는 설정된 경우 리디렉션)

---

# 🧠 `useAuth()`를 어디서나 사용하기

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

# 🛠 백엔드 요구사항

이 섹션은 백엔드가 반드시 구현해야 하는 정확한 API 계약을 정의합니다. 라이브러리는 세 가지 유형의 요청을 보내며 특정 JSON 응답 형태를 기대합니다.

---

## POST `/auth/login`

**요청 본문:**

```json
{
  "email": "user@example.com",
  "password": "secret123"
}
```

**성공 응답 (200):**

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

**오류 응답 (4xx):**

```json
{ "message": "Invalid email or password" }
```

`message` 필드는 로그인 폼에서 사용자에게 직접 표시됩니다.

---

## POST `/auth/signup`

**요청 본문:**

```json
{
  "name": "Jane Doe",
  "email": "user@example.com",
  "password": "secret123"
}
```
> 가입 양식에 추가 필드를 포함하고 전달할 수 있습니다 — 라이브러리는 전체 페이로드를 그대로 전달합니다.

**성공 응답 (200):** 로그인 응답과 동일한 형태입니다.


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

## POST `/auth/forgot` _(선택 사항)_

`<PasswordResetScreen />`를 사용하는 경우에만 필요합니다.

**요청 본문:**

```json
{ "email": "user@example.com" }
```
**응답:** 모든 `2xx`는 성공으로 간주됩니다. 라이브러리는 응답 본문을 읽지 않고 "이메일을 확인하세요"라는 확인 메시지만 표시합니다. `404`는 `config.endpoints.forgot` 수정에 대한 안내와 함께 설명적인 콘솔 오류를 기록합니다.

---

## 응답 필드 참조

| 필드           | 유형    | 필수 여부 | 설명                                                                                              |
| -------------- | ------- | -------- | ------------------------------------------------------------------------------------------------- |
| `accessToken`  | 문자열  | ✅       | `localStorage`에 저장되며 인증된 요청 시 `Authorization: Bearer <token>`로 전송됩니다.             |
| `user`         | 객체    | ✅       | `localStorage`에 저장되고 `useAuth().user`를 통해 노출됩니다.                                      |
| `user.id`      | 문자열  | ✅       | 고유 사용자 식별자입니다.                                                                         |
| `user.name`    | 문자열  | ✅       | UI에서 사용되는 표시 이름입니다.                                                                  |
| `user.email`   | 문자열  | ✅       | 사용자의 이메일 주소입니다.                                                                        |
| `refreshToken` | 문자열  | ❌       | 현재 라이브러리에서 사용하지 않지만 수락됩니다. 곧 업데이트 예정이며, 자체 로직에 포함할 수 있습니다. |

---

## 세션 지속성 작동 방식

auth-flow-kit은 클라이언트 측에서만 지속성을 처리합니다 — **백엔드에 세션 복원이나 `/me` 엔드포인트가 필요 없습니다.**

로그인 또는 회원가입 성공 시:

- `accessToken`은 `afk_access_token`으로 `localStorage`에 저장됩니다.
- `user`는 `afk_user`로 `localStorage`에 저장됩니다.

페이지가 새로 고침되면 `AuthProvider`가 `localStorage`에서 직접 `afk_user`를 읽어 세션을 즉시 복원합니다 — 네트워크 요청이 발생하지 않습니다.

로그아웃 시 두 키 모두 삭제됩니다.

---

# 🎯 이 라이브러리가 대상인 사람들

- 인증 걱정 없이 바로 앱 개발에 착수하고 싶은 개발자
- MVP 빌더
- SaaS 대시보드
- 내부 도구
- 인증을 이해하고자 하는 학습자

이미 백엔드가 있고 단지 인증이 **작동하기만** 원한다면, 이 라이브러리가 바로 당신을 위한 것입니다.

---

# 🎉 요약

**auth-flow-kit**이 제공하는 것:

- 전역 인증 상태 (리듀서나 스토어 불필요)
- 미리 만들어진 인증 UI 화면
- 간단한 백엔드 요구사항
- 리프레시 안전 인증
- Next.js 및 일반 React와 호환

혼란 없이 인증을.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-01

---