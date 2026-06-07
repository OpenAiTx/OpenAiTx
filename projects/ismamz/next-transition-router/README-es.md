<div align="center">
  <img src="https://raw.githubusercontent.com/ismamz/next-transition-router/main/example/app/icon.svg" alt="next-transition-router" width="100" height="100" />
  <h1>next-transition-router</h1>
</div>

Agrega fácilmente transiciones animadas entre páginas usando Next.js App Router y tu biblioteca de animación favorita.

- [**Demostración en vivo usando GSAP**](https://next-transition-router.vercel.app) (código fuente: [/example](/example)).
- [**Demostración en Stackblitz usando Framer Motion**](https://stackblitz.com/edit/next-transition-router-framer-motion).

## Características

- Detecta automáticamente enlaces internos para manejar transiciones de página ([bandera `auto` opcional](#auto-enabled)).
- Usa un componente `Link` personalizado para manejar manualmente las transiciones de página ([cuando `auto` está deshabilitado](#handle-links-custom-link-component-vs-auto-detection)).
- Exclusivamente para usarse con [Next.js App Router](https://nextjs.org/docs/app) (v14.0.0 o superior).
- Añade rápidamente transiciones animadas entre páginas usando JavaScript o CSS.
- Se integra perfectamente con [GSAP](https://gsap.com/resources/React/) o cualquier otra biblioteca de animación de tu elección (ver [ejemplo mínimo con GSAP](#minimal-example-using-gsap)).
- Si JavaScript está deshabilitado, la accesibilidad del router no se ve comprometida.
- Es realmente ligero; el tamaño del paquete es menor a 8 KB.
- Enfocado en animaciones personalizables, sin apuntar a la [View Transitions API](https://developer.mozilla.org/en-US/docs/Web/API/View_Transitions_API).

Si buscas usar la View Transitions API, revisa [next-view-transitions](https://github.com/shuding/next-view-transitions).

> [!WARNING]
> Este proyecto está actualmente en Beta. Ten en cuenta que la API puede cambiar a medida que se mejoran y refinan las funcionalidades.

## Instalación

Instala el paquete usando tu gestor de paquetes preferido:

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

## Uso

### `TransitionRouter`

Cree un componente cliente (por ejemplo: `app/providers.tsx`) para usar el proveedor `TransitionRouter`:

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

> [!NOTA]
> Debe ser un componente cliente porque tienes que pasar funciones DOM como props al proveedor.

Después de eso, debes importar ese componente en el componente de diseño (por ejemplo: `app/layout.tsx`).

#### Callbacks Asíncronos

Los callbacks `leave` y `enter` soportan funciones asíncronas.

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

#### Parámetros `from` y `to` para el callback `leave`

El callback `leave` recibe los parámetros `from` y `to`, que son cadenas con las rutas de la página anterior y la siguiente. Útil si quieres animar la transición condicionalmente según la página.

```tsx
const onLeave = (next, from, to) => {
  someAnimation(from, to).then(next);
};
```

> [!NOTA]
> Al usar el método `router.back()`, el parámetro `to` será indefinido. Ver [navegación programática](#programmatic-navigation).

### Manejo de enlaces (componente `Link` personalizado vs detección automática)

Para determinar cómo manejar los enlaces, `TransitionRouter` puede recibir una prop `auto` (`boolean`).

#### `auto` deshabilitado (por defecto)

Usa el componente `Link` personalizado en lugar del componente nativo [`Link` de Next.js](https://nextjs.org/docs/app/api-reference/components/link) para activar transiciones.

```tsx
import { Link } from "next-transition-router";

export function Example() {
  return <Link href="/about">About</Link>;
}
```

> [!TIP]
> Usa `import { Link as TransitionLink } from "next-transition-router"` para evitar conflictos de nombres.

#### `auto` habilitado

Cuando `auto` está habilitado, el `TransitionRouter` intercepta eventos de clic en enlaces internos, excepto enlaces ancla, y desencadena transiciones de página. En este caso no necesitas usar el componente `Link` personalizado.

Para ignorar un enlace en este modo, simplemente añade el atributo `data-transition-ignore` al enlace.

### Navegación programática

Usa el hook `useTransitionRouter` para gestionar la navegación (`push`, `replace`, `back`).

Es similar a [Next.js `useRouter`](https://nextjs.org/docs/app/api-reference/functions/use-router) con soporte adicional para transiciones.

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
> La navegación hacia adelante y hacia atrás del navegador no activa las transiciones de página, y [esto es intencional](https://github.com/ismamz/next-transition-router/issues/2).

### Estado de transición

Usa el hook `useTransitionState` para determinar la etapa actual de la transición.

Valores posibles de `stage`: `'entering' | 'leaving' | 'none'`.

Además, tienes el estado `isReady` (`boolean`).

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
> Esto es útil, por ejemplo, si desea activar una animación de revelación después de que finalice la transición de la página.

### Limpieza

`TransitionRouter` gestiona funciones de limpieza para los callbacks de `leave` y `enter`, para evitar fugas de memoria.

Similar al hook `useEffect` de React, puede devolver una función de limpieza para cancelar la animación.

#### Ejemplo mínimo usando GSAP

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

## Optimización del Rendimiento

Cuando se superponen animaciones de salida con la carga de la página (común para transiciones suaves), el renderizado de React puede causar interrupciones en la animación. Usa `requestAnimationFrame` y `startTransition` para priorizar el rendimiento de la animación:

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
Esto evita que las actualizaciones de React interfieran con la línea de tiempo de tu animación mientras se mantiene la sincronización visual.

## API

### `TransitionRouter`

| Prop       | Tipo       | Valor Predeterminado | Descripción                                        |
| ---------- | ---------- | -------------------- | ------------------------------------------------- |
| `leave`    | `function` | `next => next()`     | Función para manejar la animación de salida       |
| `enter`    | `function` | `next => next()`     | Función para manejar la animación de entrada      |
| `auto`     | `boolean`  | `false`              | Bandera para habilitar/deshabilitar la auto-detección de enlaces |

### `useTransitionState`

| Propiedad | Tipo                                | Descripción                                        |
|-----------|------------------------------------|---------------------------------------------------|
| `stage`   | `'entering' \| 'leaving' \| 'none'` | Indica la etapa actual de la transición.          |
| `isReady` | `boolean`                          | Indica si la nueva página está lista para ser animada. |

## Descargo de responsabilidad

Este paquete puede no cubrir todos los casos de uso. Si requieres un escenario específico, por favor [abre un issue](https://github.com/ismamz/next-transition-router/issues/new/choose), y podemos explorar la posibilidad de extender la funcionalidad.

## Licencia

MIT.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-07

---