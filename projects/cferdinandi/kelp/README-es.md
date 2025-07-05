# Kelp

Una biblioteca de UI para personas que aman HTML, impulsada por CSS moderno y Web Components.

**[Leer la documentación &rarr;](https://kelpui.com)**

_**Nota:** Kelp está actualmente en desarrollo en alpha. Siéntete libre de usarlo, experimentar y reportar errores, pero comprende que las cosas pueden y van a cambiar con el tiempo._



## Inicio Rápido

Kelp funciona sin ningún paso de compilación.

[El CDN](https://cdn.jsdelivr.net/npm/kelpui/) es la forma más rápida y simple de empezar, pero puedes [descargar los archivos desde GitHub](https://github.com/cferdinandi/kelp) si lo prefieres.

```html
<link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/kelpui@0/css/kelp.css">
```

Kelp utiliza control de versiones semántico. Puedes obtener una versión mayor, menor o de parche desde el CDN con la sintaxis `@1.2.3`. Puedes encontrar todas las versiones disponibles [en los lanzamientos](https://github.com/cferdinandi/kelp/tags).



## Demo

El archivo `index.html` incluido es una demo tipo "kitchen sink" de Kelp. Incluye cada característica y componente en un solo archivo gigante.

Mientras esté en beta, Kelp no tiene paso de compilación. El componente web utiliza importaciones ES y requiere un servidor local para ejecutarse.

Usa tu servidor preferido, o utiliza el `http-server` incluido ejecutando `npm run dev`.

```bash
npm install
npm run dev
```

A medida que Kelp se acerque a la versión v1, utilizará un paso de compilación para que esto no sea necesario.



## Pruebas

Kelp utiliza...

- [Playwright](https://playwright.dev) para pruebas
- [Biome](https://biomejs.dev) para linting y formato
- Un proceso de integración continua en despliegues y PRs

```bash
# Ejecutar pruebas
npm run test

# Ejecutar linter
npm run lint
```



## Licencia

Libre para usar bajo la [Licencia Kelp Commons](https://github.com/cferdinandi/kelp/blob/main/LICENSE.md). También hay [opciones de licencia comercial](/license/) disponibles.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---