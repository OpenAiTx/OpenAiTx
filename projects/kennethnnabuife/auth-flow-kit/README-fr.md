# @kendevelops/auth-flow-kit

Une boîte à outils d'authentification conviviale pour les débutants, pour **React** et **Next.js 13–16 (App Router)**.

C'est littéralement la **configuration la plus simple et la plus courte** pour vos applications Next.js.  
Vous n'avez **pas** besoin de fichiers wrapper supplémentaires.

---

Elle vous offre :

- Un état d'authentification global (style Redux / Zustand, mais sans aucune configuration)  
- Des écrans d'authentification préconçus (Connexion, Inscription, Réinitialisation)  
- Un hook simple `useAuth()` que vous pouvez utiliser partout

Cette bibliothèque est volontairement conçue pour être **facile à comprendre**, même si vous débutez en authentification.

---

## 🔄 Aucune configuration de persistance nécessaire

auth-flow-kit conserve l'état d'authentification en mémoire par défaut, et restaure automatiquement la session lorsque l'application se recharge.

**Ce que cela signifie en pratique :**

Du point de vue du développeur :

> « Je rafraîchis la page et je suis toujours connecté. »

C'est tout.

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

- Pendant le chargement → affiche un état de chargement
- Si non authentifié → ne rend rien (ou redirige si configuré)

---

# 🧠 Utiliser `useAuth()` n'importe où

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

# 🛠 Exigences du Backend

Cette section définit le contrat API exact que votre backend doit implémenter. La bibliothèque effectue trois types de requêtes et attend des réponses JSON spécifiques.

---

## POST `/auth/login`

**Corps de la requête :**

```json
{
  "email": "user@example.com",
  "password": "secret123"
}
```

**Réponse de succès (200) :**

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

**Réponse d'erreur (4xx) :**

```json
{ "message": "Invalid email or password" }
```

Le champ `message` est affiché directement à l'utilisateur dans le formulaire de connexion.

---

## POST `/auth/signup`

**Corps de la requête :**

```json
{
  "name": "Jane Doe",
  "email": "user@example.com",
  "password": "secret123"
}
```

> Vous pouvez inclure des champs supplémentaires dans votre formulaire d'inscription et les transmettre — la bibliothèque transmet la charge utile complète telle quelle.

**Réponse de succès (200) :** Même format que la réponse de connexion.

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

## POST `/auth/forgot` _(optionnel)_

Nécessaire uniquement si vous utilisez `<PasswordResetScreen />`.

**Corps de la requête :**

```json
{ "email": "user@example.com" }
```

**Réponse :** Toute réponse `2xx` est considérée comme un succès. La bibliothèque ne lit pas le corps de la réponse — elle affiche simplement une confirmation "Vérifiez votre email". Un `404` génère une erreur descriptive dans la console avec des conseils pour corriger `config.endpoints.forgot`.

---

## Référence des champs de réponse

| Champ          | Type   | Requis   | Description                                                                                         |
| -------------- | ------ | -------- | --------------------------------------------------------------------------------------------------- |
| `accessToken`  | string | ✅       | Stocké dans `localStorage` et envoyé comme `Authorization: Bearer <token>` lors des requêtes authentifiées.     |
| `user`         | object | ✅       | Stocké dans `localStorage` et accessible via `useAuth().user`.                                          |
| `user.id`      | string | ✅       | Identifiant unique de l'utilisateur.                                                                             |
| `user.name`    | string | ✅       | Nom affiché utilisé dans votre interface.                                                                       |
| `user.email`   | string | ✅       | Adresse email de l'utilisateur.                                                                               |
| `refreshToken` | string | ❌       | Accepté mais non utilisé par la bibliothèque pour l’instant, mise à jour prochaine. Vous pouvez l’inclure pour votre propre logique. |

---

## Fonctionnement de la persistance de session

auth-flow-kit gère la persistance entièrement côté client — **votre backend n’a pas besoin d’un point de restauration de session ni d’un endpoint `/me`.**

Lors d’une connexion ou inscription réussie :

- `accessToken` est sauvegardé dans `localStorage` sous `afk_access_token`
- `user` est sauvegardé dans `localStorage` sous `afk_user`

Au rechargement de la page, `AuthProvider` lit directement `afk_user` depuis `localStorage` et restaure la session instantanément — aucune requête réseau n’est effectuée.

À la déconnexion, les deux clés sont supprimées.

---

# 🎯 Pour Qui Est Cette Bibliothèque

- Les développeurs qui veulent commencer à construire leur application avant de gérer l’authentification
- Les créateurs de MVP
- Les tableaux de bord SaaS
- Les outils internes
- Les apprenants qui veulent comprendre l’authentification

Si vous avez déjà un backend et que vous voulez juste que l’authentification **fonctionne**, cette bibliothèque est pour vous.

---

# 🎉 Résumé

**auth-flow-kit** vous offre :

- Un état d’authentification global (pas de reducers, pas de stores)
- Des écrans UI d’authentification préconstruits
- Des exigences backend simples
- Une authentification sécurisée contre le rafraîchissement
- Fonctionne avec Next.js et React simple

L’authentification, sans le chaos.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-01

---