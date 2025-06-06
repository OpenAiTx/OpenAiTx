## Vue 2 ha llegado al final de su vida útil

**Estás viendo el repositorio ahora inactivo de Vue 2. El repositorio mantenido activamente para la última versión de Vue es [vuejs/core](https://github.com/vuejs/core).**

Vue llegó al final de su vida útil el 31 de diciembre de 2023. Ya no recibe nuevas características, actualizaciones ni correcciones. Sin embargo, sigue estando disponible en todos los canales de distribución existentes (CDNs, gestores de paquetes, Github, etc).

Si vas a empezar un nuevo proyecto, por favor comienza con la última versión de Vue (3.x). También recomendamos encarecidamente a los usuarios actuales de Vue 2 que actualicen ([guía](https://v3-migration.vuejs.org/)), aunque reconocemos que no todos los usuarios tienen la capacidad o el incentivo para hacerlo. Si debes permanecer en Vue 2 pero tienes requisitos de cumplimiento o seguridad respecto a software sin mantenimiento, consulta [Vue 2 NES](https://www.herodevs.com/support/nes-vue?utm_source=vuejs-github&utm_medium=vue2-readme).

<p align="center"><a href="https://vuejs.org" target="_blank" rel="noopener noreferrer"><img width="100" src="https://vuejs.org/images/logo.png" alt="Vue logo"></a></p>

<p align="center">
  <a href="https://circleci.com/gh/vuejs/vue/tree/dev"><img src="https://img.shields.io/circleci/project/github/vuejs/vue/dev.svg?sanitize=true" alt="Build Status"></a>
  <a href="https://codecov.io/github/vuejs/vue?branch=dev"><img src="https://img.shields.io/codecov/c/github/vuejs/vue/dev.svg?sanitize=true" alt="Coverage Status"></a>
  <a href="https://npmcharts.com/compare/vue?minimal=true"><img src="https://img.shields.io/npm/dm/vue.svg?sanitize=true" alt="Downloads"></a>
  <a href="https://www.npmjs.com/package/vue"><img src="https://img.shields.io/npm/v/vue.svg?sanitize=true" alt="Version"></a>
  <a href="https://www.npmjs.com/package/vue"><img src="https://img.shields.io/npm/l/vue.svg?sanitize=true" alt="License"></a>
  <a href="https://chat.vuejs.org/"><img src="https://img.shields.io/badge/chat-on%20discord-7289da.svg?sanitize=true" alt="Chat"></a>
</p>

## Patrocinadores

Vue.js es un proyecto de código abierto con licencia MIT cuyo desarrollo continuo es posible en su totalidad gracias al apoyo de estos increíbles [patrocinadores](https://github.com/vuejs/core/blob/main/BACKERS.md). Si deseas unirte a ellos, por favor considera [patrocinar el desarrollo de Vue](https://vuejs.org/sponsor/).

<p align="center">
  <h3 align="center">Patrocinador Especial</h3>
</p>

<p align="center">
  <a target="_blank" href="https://github.com/appwrite/appwrite">
  <img alt="special sponsor appwrite" src="https://sponsors.vuejs.org/images/appwrite.svg" width="300">
  </a>
</p>

<p align="center">
  <a target="_blank" href="https://vuejs.org/sponsor/">
    <img alt="sponsors" src="https://sponsors.vuejs.org/sponsors.svg?v3">
  </a>
</p>

---

## Introducción

Vue (pronunciado `/vjuː/`, como "view") es un **framework progresivo** para construir interfaces de usuario. Está diseñado desde cero para ser adoptado incrementalmente y puede escalar fácilmente entre una biblioteca y un framework dependiendo de los diferentes casos de uso. Consta de una biblioteca principal accesible que se enfoca solo en la capa de vista, y un ecosistema de bibliotecas de soporte que te ayuda a abordar la complejidad en grandes aplicaciones de una sola página (SPA).

#### Compatibilidad con Navegadores

Vue.js es compatible con todos los navegadores que sean [compatibles con ES5](https://compat-table.github.io/compat-table/es5/) (IE8 y versiones anteriores no son compatibles).

## Ecosistema

| Proyecto              | Estado                                                       | Descripción                                             |
| --------------------- | ------------------------------------------------------------ | ------------------------------------------------------- |
| [vue-router]          | [![vue-router-status]][vue-router-package]                   | Enrutamiento para aplicaciones de una sola página       |
| [vuex]                | [![vuex-status]][vuex-package]                               | Gestión de estado a gran escala                         |
| [vue-cli]             | [![vue-cli-status]][vue-cli-package]                         | Generador de proyectos                                  |
| [vue-loader]          | [![vue-loader-status]][vue-loader-package]                   | Cargador de Componentes de Archivo Único (`*.vue`) para webpack |
| [vue-server-renderer] | [![vue-server-renderer-status]][vue-server-renderer-package] | Soporte para renderizado del lado del servidor          |
| [vue-class-component] | [![vue-class-component-status]][vue-class-component-package] | Decorador TypeScript para API basada en clases          |
| [vue-rx]              | [![vue-rx-status]][vue-rx-package]                           | Integración con RxJS                                    |
| [vue-devtools]        | [![vue-devtools-status]][vue-devtools-package]               | Extensión de DevTools para navegador                    |

[vue-router]: https://github.com/vuejs/vue-router
[vuex]: https://github.com/vuejs/vuex
[vue-cli]: https://github.com/vuejs/vue-cli
[vue-loader]: https://github.com/vuejs/vue-loader
[vue-server-renderer]: https://github.com/vuejs/vue/tree/dev/packages/vue-server-renderer
[vue-class-component]: https://github.com/vuejs/vue-class-component
[vue-rx]: https://github.com/vuejs/vue-rx
[vue-devtools]: https://github.com/vuejs/vue-devtools
[vue-router-status]: https://img.shields.io/npm/v/vue-router.svg
[vuex-status]: https://img.shields.io/npm/v/vuex.svg
[vue-cli-status]: https://img.shields.io/npm/v/@vue/cli.svg
[vue-loader-status]: https://img.shields.io/npm/v/vue-loader.svg
[vue-server-renderer-status]: https://img.shields.io/npm/v/vue-server-renderer.svg
[vue-class-component-status]: https://img.shields.io/npm/v/vue-class-component.svg
[vue-rx-status]: https://img.shields.io/npm/v/vue-rx.svg
[vue-devtools-status]: https://img.shields.io/chrome-web-store/v/nhdogjmejiglipccpnnnanhbledajbpd.svg
[vue-router-package]: https://npmjs.com/package/vue-router
[vuex-package]: https://npmjs.com/package/vuex
[vue-cli-package]: https://npmjs.com/package/@vue/cli
[vue-loader-package]: https://npmjs.com/package/vue-loader
[vue-server-renderer-package]: https://npmjs.com/package/vue-server-renderer
[vue-class-component-package]: https://npmjs.com/package/vue-class-component
[vue-rx-package]: https://npmjs.com/package/vue-rx
[vue-devtools-package]: https://chrome.google.com/webstore/detail/vuejs-devtools/nhdogjmejiglipccpnnnanhbledajbpd

## Documentación

Para ver [ejemplos en vivo](https://v2.vuejs.org/v2/examples/) y la documentación, visita [vuejs.org](https://v2.vuejs.org).

## Preguntas

Para preguntas y soporte, por favor utiliza [el foro oficial](https://forum.vuejs.org) o [el chat de la comunidad](https://chat.vuejs.org/). La lista de issues de este repositorio es **exclusivamente** para reportes de errores y solicitudes de características.

## Issues

Por favor asegúrate de leer la [Lista de Comprobación para Reporte de Issues](https://github.com/vuejs/vue/blob/dev/.github/CONTRIBUTING.md#issue-reporting-guidelines) antes de abrir un issue. Los issues que no sigan las directrices pueden ser cerrados inmediatamente.

## Registro de Cambios

Los cambios detallados de cada versión están documentados en las [notas de lanzamiento](https://github.com/vuejs/vue/releases).

## Mantente en contacto

- [Twitter](https://twitter.com/vuejs)
- [Blog](https://medium.com/the-vue-point)
- [Bolsa de trabajo](https://vuejobs.com/?ref=vuejs)

## Contribución

Por favor asegúrate de leer la [Guía de Contribución](https://github.com/vuejs/vue/blob/dev/.github/CONTRIBUTING.md) antes de enviar un pull request. Si tienes un proyecto/componente/herramienta relacionado con Vue, agrégalo con un pull request a [esta lista curada](https://github.com/vuejs/awesome-vue)!

¡Gracias a todas las personas que ya han contribuido a Vue!

<a href="https://github.com/vuejs/vue/graphs/contributors"><img src="https://opencollective.com/vuejs/contributors.svg?width=890" /></a>

## Licencia

[MIT](https://opensource.org/licenses/MIT)

Copyright (c) 2013-presente, Yuxi (Evan) You

---

[Powered By DeepAiTx](https://github.com/DeepAiTx)

---