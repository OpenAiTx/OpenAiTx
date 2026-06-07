<div align="center">
  <img src="https://raw.githubusercontent.com/ismamz/next-transition-router/main/example/app/icon.svg" alt="next-transition-router" width="100" height="100" />
  <h1>next-transition-router</h1>
</div>

Ajoutez facilement des transitions animées entre les pages en utilisant Next.js App Router et votre bibliothèque d'animation préférée.

- [**Démo en direct utilisant GSAP**](https://next-transition-router.vercel.app) (code source : [/example](/example)).
- [**Démo Stackblitz utilisant Framer Motion**](https://stackblitz.com/edit/next-transition-router-framer-motion).

## Fonctionnalités

- Détection automatique des liens internes pour gérer les transitions de page ([option `auto`](#auto-enabled)).
- Utilisez un composant `Link` personnalisé pour gérer manuellement les transitions de page ([quand `auto` est désactivé](#handle-links-custom-link-component-vs-auto-detection)).
- Exclusivement destiné à être utilisé avec [Next.js App Router](https://nextjs.org/docs/app) (v14.0.0 ou supérieur).
- Ajoutez rapidement des transitions animées entre les pages avec JavaScript ou CSS.
- Intégration transparente avec [GSAP](https://gsap.com/resources/React/) ou toute autre bibliothèque d'animation de votre choix (voir [exemple minimal avec GSAP](#minimal-example-using-gsap)).
- Si JavaScript est désactivé, l'accessibilité du routeur n'est pas compromise.
- Très léger ; la taille du bundle est inférieure à 8 Ko.
- Axé sur des animations personnalisables, sans viser l'[API View Transitions](https://developer.mozilla.org/en-US/docs/Web/API/View_Transitions_API).

Si vous souhaitez utiliser l’API View Transitions, consultez [next-view-transitions](https://github.com/shuding/next-view-transitions).

> [!WARNING]
> Ce projet est actuellement en version Beta. Veuillez noter que l’API peut évoluer au fur et à mesure des améliorations et affinements des fonctionnalités.

## Installation

Installez le package avec votre gestionnaire de paquets préféré :

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

## Utilisation

### `TransitionRouter`

Créez un composant client (par exemple : `app/providers.tsx`) pour utiliser le fournisseur `TransitionRouter` :

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
> Il doit s'agir d'un composant client car vous devez passer des fonctions DOM en tant que props au provider.

Après cela, vous devez importer ce composant dans le composant de mise en page (par exemple : `app/layout.tsx`).

#### Rappels asynchrones

Les rappels `leave` et `enter` prennent en charge les fonctions asynchrones.

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

#### Paramètres `from` et `to` pour le rappel `leave`

Le rappel `leave` reçoit les paramètres `from` et `to`, qui sont des chaînes avec les chemins de la page précédente et suivante. Utile si vous souhaitez animer la transition de manière conditionnelle en fonction de la page.

```tsx
const onLeave = (next, from, to) => {
  someAnimation(from, to).then(next);
};
```

> [!NOTE]
> Lors de l'utilisation de la méthode `router.back()`, le paramètre `to` sera indéfini. Voir [navigation programmatique](#programmatic-navigation).

### Gestion des liens (composant `Link` personnalisé vs détection automatique)

Pour déterminer comment gérer les liens, `TransitionRouter` peut recevoir une prop `auto` (`boolean`).

#### `auto` désactivé (par défaut)

Utilisez le composant `Link` personnalisé au lieu du composant natif [`Link` de Next.js](https://nextjs.org/docs/app/api-reference/components/link) pour déclencher les transitions.

```tsx
import { Link } from "next-transition-router";

export function Example() {
  return <Link href="/about">About</Link>;
}
```

> [!ASTUCE]
> Utilisez `import { Link as TransitionLink } from "next-transition-router"` pour éviter les conflits de noms.

#### `auto` activé

Lorsque `auto` est activé, le `TransitionRouter` intercepte les clics sur les liens internes, sauf les liens d’ancrage, et déclenche les transitions de page. Dans ce cas, vous n’avez pas besoin d’utiliser le composant `Link` personnalisé.

Pour ignorer un lien dans ce mode, ajoutez simplement l’attribut `data-transition-ignore` au lien.

### Navigation programmatique

Utilisez le hook `useTransitionRouter` pour gérer la navigation (`push`, `replace`, `back`).

C’est similaire à [Next.js `useRouter`](https://nextjs.org/docs/app/api-reference/functions/use-router) avec un support de transition ajouté.

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
> La navigation arrière et avant du navigateur ne déclenche pas les transitions de page, et [c'est intentionnel](https://github.com/ismamz/next-transition-router/issues/2).

### État de la transition

Utilisez le hook `useTransitionState` pour déterminer l’étape actuelle de la transition.

Valeurs possibles de `stage` : `'entering' | 'leaving' | 'none'`.

De plus, vous avez l’état `isReady` (`boolean`).

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

> [!CONSEIL]
> Cela est utile, par exemple, si vous souhaitez déclencher une animation de révélation après la fin de la transition de page.

### Nettoyage

`TransitionRouter` gère les fonctions de nettoyage pour les rappels `leave` et `enter`, afin de prévenir les fuites de mémoire.

Similaire au hook `useEffect` de React, vous pouvez retourner une fonction de nettoyage pour annuler l’animation.

#### Exemple minimal utilisant GSAP

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

## Optimisation des performances

Lors du chevauchement des animations de sortie avec le chargement de la page (courant pour des transitions fluides), le rendu React peut provoquer des saccades d'animation. Utilisez `requestAnimationFrame` et `startTransition` pour prioriser les performances d'animation :

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
Cela empêche les mises à jour React d'interférer avec votre chronologie d'animation tout en maintenant le timing visuel.

## API

### `TransitionRouter`

| Prop       | Type       | Valeur par défaut | Description                                       |
| ---------- | ---------- | ----------------- | ------------------------------------------------- |
| `leave`    | `function` | `next => next()`  | Fonction pour gérer l'animation de sortie         |
| `enter`    | `function` | `next => next()`  | Fonction pour gérer l'animation d'entrée          |
| `auto`     | `boolean`  | `false`           | Indicateur pour activer/désactiver la détection automatique des liens |

### `useTransitionState`

| Propriété | Type                                | Description                                        |
|-----------|------------------------------------|----------------------------------------------------|
| `stage`   | `'entering' \| 'leaving' \| 'none'` | Indique l'étape actuelle de la transition.         |
| `isReady` | `boolean`                          | Indique si la nouvelle page est prête à être animée. |

## Avertissement

Ce paquet peut ne pas couvrir tous les cas d'utilisation. Si vous avez un scénario spécifique, veuillez [ouvrir un ticket](https://github.com/ismamz/next-transition-router/issues/new/choose), et nous pourrons étudier la possibilité d'étendre la fonctionnalité.

## Licence

MIT.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-07

---