# @kendevelops/auth-flow-kit

Un kit de herramientas de autenticación amigable para principiantes para **React** y **Next.js 13–16 (App Router)**.

Esta es literalmente la **configuración más simple y corta** para tus aplicaciones Next.js.  
No necesitas archivos adicionales de envoltura.

---

Te ofrece:

- Estado global de autenticación (estilo Redux / Zustand, pero sin configuración)  
- Pantallas de UI de autenticación preconstruidas (Inicio de sesión, Registro, Restablecer)  
- Un hook simple `useAuth()` que puedes usar en cualquier lugar

Esta biblioteca está diseñada intencionalmente para ser **fácil de entender**, incluso si eres nuevo en autenticación.

---

## 🔄 No se requiere configuración de persistencia

auth-flow-kit mantiene el estado de autenticación en memoria por defecto, y restaura automáticamente la sesión cuando la aplicación se recarga.

**Lo que esto significa en la práctica:**

Desde el punto de vista del desarrollador:

> "Refresco la página y sigo conectado."

Eso es todo.

---

## 📦 Instalación

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

- Mientras se carga → muestra un estado de carga
- Si no está autenticado → no renderiza nada (o redirige si está configurado)

---

# 🧠 Usando `useAuth()` en cualquier lugar

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

# 🛠 Requisitos del Backend

Esta sección define el contrato exacto de la API que debe implementar tu backend. La biblioteca realiza tres tipos de solicitudes y espera formas específicas de respuestas JSON.

---

## POST `/auth/login`

**Cuerpo de la solicitud:**

```json
{
  "email": "user@example.com",
  "password": "secret123"
}
```

**Respuesta exitosa (200):**

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

**Respuesta de error (4xx):**

```json
{ "message": "Invalid email or password" }
```

El campo `message` se muestra directamente al usuario en el formulario de inicio de sesión.

---

## POST `/auth/signup`

**Cuerpo de la solicitud:**

```json
{
  "name": "Jane Doe",
  "email": "user@example.com",
  "password": "secret123"
}
```
> Puedes incluir campos adicionales en tu formulario de registro y pasarlos — la biblioteca envía la carga completa tal cual.

**Respuesta exitosa (200):** La misma estructura que la respuesta de inicio de sesión.


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

## POST `/auth/forgot` _(opcional)_

Solo necesario si usas `<PasswordResetScreen />`.

**Cuerpo de la solicitud:**

```json
{ "email": "user@example.com" }
```
**Respuesta:** Cualquier código `2xx` se trata como éxito. La biblioteca no lee el cuerpo de la respuesta — solo muestra una confirmación de "Revisa tu correo electrónico". Un `404` registra un error descriptivo en la consola con indicaciones para corregir `config.endpoints.forgot`.

---

## Referencia de campos de respuesta

| Campo          | Tipo   | Requerido | Descripción                                                                                         |
| -------------- | ------ | -------- | --------------------------------------------------------------------------------------------------- |
| `accessToken`  | string | ✅       | Se guarda en `localStorage` y se envía como `Authorization: Bearer <token>` en solicitudes autenticadas.     |
| `user`         | object | ✅       | Se guarda en `localStorage` y se expone vía `useAuth().user`.                                          |
| `user.id`      | string | ✅       | Identificador único de usuario.                                                                             |
| `user.name`    | string | ✅       | Nombre para mostrar usado en tu interfaz.                                                                       |
| `user.email`   | string | ✅       | Dirección de correo electrónico del usuario.                                                                               |
| `refreshToken` | string | ❌       | Aceptado pero no usado por la biblioteca por ahora, se actualizará pronto. Puedes incluirlo para tu propia lógica. |

---

## Cómo funciona la persistencia de sesión

auth-flow-kit maneja la persistencia completamente en el cliente — **tu backend no necesita un punto de restauración de sesión ni un endpoint `/me`.**

Al iniciar sesión o registrarse con éxito:

- `accessToken` se guarda en `localStorage` como `afk_access_token`
- `user` se guarda en `localStorage` como `afk_user`

Al recargar la página, `AuthProvider` lee `afk_user` directamente desde `localStorage` y restaura la sesión al instante — no se realiza ninguna solicitud de red.

Al cerrar sesión, ambas claves se eliminan.

---

# 🎯 Para quién es esta biblioteca

- Desarrolladores que quieren comenzar a construir su app antes de preocuparse por la autenticación
- Constructores de MVP
- Paneles SaaS
- Herramientas internas
- Estudiantes que quieren entender la autenticación


Si ya tienes un backend y solo quieres que la autenticación **funcione**, esta biblioteca es para ti.

---

# 🎉 Resumen

**auth-flow-kit** te ofrece:

- Estado global de autenticación (sin reductores, sin almacenes)
- Pantallas de UI de autenticación preconstruidas
- Requisitos simples para el backend
- Autenticación segura con refresco
- Funciona con Next.js y React simple

Autenticación, sin el caos.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-01

---