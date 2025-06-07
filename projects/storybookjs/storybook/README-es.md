<p align="center">
  <a href="https://storybook.js.org/">
    <picture>
      <source media="(prefers-color-scheme: dark)" srcset="https://user-images.githubusercontent.com/263385/199832481-bbbf5961-6a26-481d-8224-51258cce9b33.png">
      <img src="https://user-images.githubusercontent.com/321738/63501763-88dbf600-c4cc-11e9-96cd-94adadc2fd72.png" alt="Storybook" width="400" />
    </picture>
    
  </a>
  
</p>

<p align="center">Construye componentes de UI a prueba de errores más rápido</p>

<br/>

<p align="center">
  <a href="https://circleci.com/gh/storybookjs/storybook">
    <img src="https://circleci.com/gh/storybookjs/storybook.svg?style=shield" alt="Estado de compilación en CircleCI" />
  </a>
  <a href="https://codecov.io/gh/storybookjs/storybook">
    <img src="https://codecov.io/gh/storybookjs/storybook/branch/main/graph/badge.svg" alt="codecov" />
  </a>
  <a href="https://github.com/storybookjs/storybook/blob/main/LICENSE">
    <img src="https://img.shields.io/github/license/storybookjs/storybook.svg" alt="Licencia" />
  </a>
  <br/>
  <a href="https://discord.gg/storybook">
    <img src="https://img.shields.io/badge/discord-join-7289DA.svg?logo=discord&longCache=true&style=flat" />
  </a>
  <a href="https://storybook.js.org/community/">
    <img src="https://img.shields.io/badge/community-join-4BC424.svg" alt="Comunidad de Storybook" />
  </a>
  <a href="#backers">
    <img src="https://opencollective.com/storybook/backers/badge.svg" alt="Patrocinadores en Open Collective" />
  </a>
  <a href="#sponsors">
    <img src="https://opencollective.com/storybook/tiers/sponsors/badge.svg" alt="Sponsors en Open Collective" />
  </a>
  <a href="https://x.com/intent/follow?screen_name=storybookjs">
    <img src="https://img.shields.io/twitter/follow/storybookjs?color=blue&logo=twitter" alt="Cuenta oficial de Twitter" />
  </a>
  <a href="https://api.securityscorecards.dev/projects/github.com/storybookjs/storybook">
    <img src="https://api.securityscorecards.dev/projects/github.com/storybookjs/storybook/badge" alt="OpenSSF Scorecard"/>
  </a>
</p>

<p align="center">
Storybook es un taller para frontend para construir componentes y páginas de UI en aislamiento. Miles de equipos lo usan para desarrollo, pruebas y documentación de UI. ¡Descubre más en https://storybook.js.org!
</p>

<center>
  <img src="https://raw.githubusercontent.com/storybookjs/storybook/main/media/storybook-intro.gif" width="100%" />
</center>

<p align="center">
  Ver README para:<br/>
  <a href="https://github.com/storybookjs/storybook/blob/main/README.md" title="latest"><img alt="latest" src="https://img.shields.io/npm/v/@storybook/react/latest?style=for-the-badge&logo=storybook&logoColor=ffffff&color=66BF3C" /></a>
  <a href="https://github.com/storybookjs/storybook/blob/next/README.md" title="next"><img alt="next" src="https://img.shields.io/npm/v/@storybook/react/next?style=for-the-badge&logo=storybook&logoColor=ffffff&color=1EA7FD" /></a>
</p>

## Tabla de contenido

- 🚀 [Comenzando](#getting-started)
- 📒 [Proyectos](#projects)
  - 🛠 [Frameworks soportados y ejemplos](#supported-frameworks)
  - 🔗[Addons](#addons)
- 🏅 [Insignias y materiales de presentación](#badges--presentation-materials)
- 👥 [Comunidad](#community)
- 👏 [Contribuir](#contributing)
  - 👨‍💻 [Scripts de desarrollo](#development-scripts)
  - 💸 [Sponsors](#sponsors)
  - 💵 [Patrocinadores](#backers)
- :memo: [Licencia](#license)

## Comenzando

Visita el [sitio web de Storybook](https://storybook.js.org) para saber más sobre Storybook y cómo comenzar.

### Documentación

La documentación se encuentra en el [sitio de documentación de Storybook](https://storybook.js.org/docs).

### Ejemplos

Consulta la [Enciclopedia de Componentes](https://storybook.js.org/showcase) para ver cómo los equipos líderes utilizan Storybook.

Usa [storybook.new](https://storybook.new) para crear rápidamente un proyecto de ejemplo en Stackblitz.

Storybook incluye muchos [addons](https://storybook.js.org/docs/configure/user-interface/storybook-addons) para diseño de componentes, documentación, pruebas, interactividad, etc. La API de Storybook permite configurarlo y extenderlo de diversas maneras. Incluso ha sido extendido para soportar React Native, Android, iOS y Flutter para desarrollo móvil.

### Comunidad

Para ayuda adicional, comparte tu problema en [GitHub Discussions del repositorio](https://github.com/storybookjs/storybook/discussions/new?category=help).

## Proyectos

### Frameworks soportados

| Renderizador                                                   | Demo                                                                                                                                                                         |                                                                                                                                                       |
| -------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------- |
| [React](code/renderers/react)                                  | [![Demo de Storybook](https://img.shields.io/npm/v/@storybook/react/latest?style=flat-square&color=blue&label)](https://next--630511d655df72125520f051.chromatic.com/)          | [![React](https://img.shields.io/npm/dm/@storybook/react?style=flat-square&color=eee)](code/renderers/react)                                          |
| [Angular](code/frameworks/angular/)                            | [![Demo de Storybook](https://img.shields.io/npm/v/@storybook/angular/latest?style=flat-square&color=blue&label)](https://next--6322ce6af69825592bbb28fc.chromatic.com/)        | [![Angular](https://img.shields.io/npm/dm/@storybook/angular?style=flat-square&color=eee)](code/frameworks/angular/)                                  |
| [Vue 3](code/renderers/vue3)                                   | [![Demo de Storybook](https://img.shields.io/npm/v/@storybook/vue3/latest?style=flat-square&color=blue&label)](https://next--630513346a8e284ae244d415.chromatic.com/)           | [![Vue 3](https://img.shields.io/npm/dm/@storybook/vue3?style=flat-square&color=eee)](code/renderers/vue3/)                                           |
| [Web components](code/renderers/web-components)                | [![Demo de Storybook](https://img.shields.io/npm/v/@storybook/web-components/latest?style=flat-square&color=blue&label)](https://next--638db5bf49adfdfe8cf545e0.chromatic.com/) | [![Svelte](https://img.shields.io/npm/dm/@storybook/web-components?style=flat-square&color=eee)](code/renderers/web-components)                       |
| [React Native](https://github.com/storybookjs/react-native)    | [![](https://img.shields.io/npm/v/@storybook/react-native/latest?style=flat-square&color=blue&label)](/)                                                                     | [![React Native](https://img.shields.io/npm/dm/@storybook/react-native?style=flat-square&color=eee)](https://github.com/storybookjs/react-native)     |
| [HTML](code/renderers/html)                                    | [![Demo de Storybook](https://img.shields.io/npm/v/@storybook/html/latest?style=flat-square&color=blue&label)](https://next--63dd39a158cf6fc05199b4bb.chromatic.com/)           | [![HTML](https://img.shields.io/npm/dm/@storybook/html?style=flat-square&color=eee)](code/renderers/html)                                             |
| [Ember](code/frameworks/ember/)                                | [![](https://img.shields.io/npm/v/@storybook/ember/latest?style=flat-square&color=blue&label)](/)                                                                            | [![Ember](https://img.shields.io/npm/dm/@storybook/ember?style=flat-square&color=eee)](code/frameworks/ember/)                                        |
| [Svelte](code/renderers/svelte)                                | [![Demo de Storybook](https://img.shields.io/npm/v/@storybook/svelte/latest?style=flat-square&color=blue&label)](https://next--630873996e4e3557791c069c.chromatic.com/)         | [![Svelte](https://img.shields.io/npm/dm/@storybook/svelte?style=flat-square&color=eee)](code/renderers/svelte)                                       |
| [Preact](code/renderers/preact)                                | [![Demo de Storybook](https://img.shields.io/npm/v/@storybook/preact/latest?style=flat-square&color=blue&label)](https://next--63b588a512565bfaace15e7c.chromatic.com/)         | [![Preact](https://img.shields.io/npm/dm/@storybook/preact?style=flat-square&color=eee)](code/renderers/preact)                                       |
| [Qwik](https://github.com/literalpie/storybook-framework-qwik) | [![](https://img.shields.io/npm/v/storybook-framework-qwik/latest?style=flat-square&color=blue&label)](/)                                                                    | [![Qwik](https://img.shields.io/npm/dm/storybook-framework-qwik?style=flat-square&color=eee)](https://github.com/literalpie/storybook-framework-qwik) |
| [SolidJS](https://github.com/storybookjs/solidjs)              | [![](https://img.shields.io/npm/v/storybook-solidjs/latest?style=flat-square&color=blue&label)](/)                                                                           | [![SolidJS](https://img.shields.io/npm/dm/storybook-solidjs?style=flat-square&color=eee)](https://github.com/storybookjs/solidjs)                     |
| [Android, iOS, Flutter](https://github.com/storybookjs/native) | [![](https://img.shields.io/npm/v/@storybook/native/latest?style=flat-square&color=blue&label)](/)                                                                           | [![Native](https://img.shields.io/npm/dm/@storybook/native?style=flat-square&color=eee)](https://github.com/storybookjs/native)                       |

### Addons

| Addons                                                                    |                                                                            |
| ------------------------------------------------------------------------- | -------------------------------------------------------------------------- |
| [a11y](code/addons/a11y/)                                                 | Prueba los componentes para accesibilidad de usuario en Storybook          |
| [actions](code/core/src/actions/)                                         | Registra acciones mientras los usuarios interactúan con los componentes en la UI de Storybook          |
| [backgrounds](code/core/src/backgrounds)                                  | Permite a los usuarios elegir fondos en la UI de Storybook                 |
| [cssresources](https://github.com/storybookjs/addon-cssresources)         | Añade/elimina dinámicamente recursos CSS al iframe del componente          |
| [design assets](https://github.com/storybookjs/addon-design-assets)       | Visualiza imágenes, videos y enlaces web junto a tu historia               |
| [docs](code/addons/docs/)                                                 | Añade documentación de alta calidad a tus componentes                      |
| [events](https://github.com/storybookjs/addon-events)                     | Dispara eventos de manera interactiva a componentes que responden a EventEmitter |
| [google-analytics](https://github.com/storybookjs/addon-google-analytics) | Reporta analíticas de Google sobre las historias                           |
| [graphql](https://github.com/storybookjs/addon-graphql)                   | Consulta un servidor GraphQL dentro de las historias de Storybook          |
| [jest](code/addons/jest/)                                                 | Visualiza los resultados de las pruebas unitarias de los componentes en Storybook |
| [links](code/addons/links/)                                               | Crea enlaces entre historias                                               |
| [measure](code/core/src/measure/)                                         | Inspecciona visualmente el diseño y modelo de caja dentro de la UI de Storybook |
| [outline](code/core/src/outline/)                                         | Depura visualmente el diseño y alineación CSS dentro de la UI de Storybook |
| [query params](https://github.com/storybookjs/addon-queryparams)          | Simula parámetros de consulta                                              |
| [viewport](code/core/src/viewport/)                                       | Cambia tamaños y diseños de pantalla para componentes responsivos usando Storybook |

Consulta la [Tabla de soporte de Addons/Frameworks](https://storybook.js.org/docs/configure/integration/frameworks-feature-support)

Para seguir mejorando tu experiencia, eventualmente debemos deprecar o eliminar ciertos addons en favor de nuevas y mejores herramientas.

Si usas info/notes, te recomendamos migrar a [docs](code/addons/docs/) y [aquí hay una guía](code/addons/docs/docs/recipes.md#migrating-from-notesinfo-addons) para ayudarte.

Si usas contexts, te recomendamos migrar a [toolbars](https://github.com/storybookjs/storybook/tree/next/code/addons/toolbars) y [aquí hay una guía](https://github.com/storybookjs/storybook/blob/next/MIGRATION.md#deprecated-addon-contexts) para ayudarte.

Si usas addon-storyshots, te recomendamos migrar al [test-runner](https://github.com/storybookjs/test-runner) de Storybook y [aquí hay una guía](https://storybook.js.org/docs/writing-tests/storyshots-migration-guide) para ayudarte.

## Insignias y materiales de presentación

¡Tenemos una insignia! Enlázala a tu ejemplo de Storybook en vivo.

![Storybook](https://cdn.jsdelivr.net/gh/storybookjs/brand@main/badge/badge-storybook.svg)

```md
[![Storybook](https://cdn.jsdelivr.net/gh/storybookjs/brand@main/badge/badge-storybook.svg)](enlace al sitio)
```

Si buscas material para usar en tu presentación de Storybook, como logotipos, vídeos y los colores que usamos, puedes encontrarlo todo en nuestro [repositorio de marca](https://github.com/storybookjs/brand).

## Comunidad

- Publicaciones en [@storybookjs](https://x.com/storybookjs)
- Blog en [storybook.js.org](https://storybook.js.org/blog/) y [Medium](https://medium.com/storybookjs)
- Chat en [Discord](https://discord.gg/storybook)
- Videos y streams en [YouTube](https://www.youtube.com/channel/UCr7Quur3eIyA_oe8FNYexfg)

## Contribuir

¡Las contribuciones a Storybook siempre son bienvenidas!

- 📥 Los pull requests y las 🌟 estrellas siempre son bienvenidos.
- Lee nuestra [guía de contribución](CONTRIBUTING.md) para comenzar,
  o encuéntranos en [Discord](https://discord.gg/storybook), nos tomaremos el tiempo de guiarte.

¿Buscas una primera incidencia para abordar?

- Etiquetamos las incidencias con [![Good First Issue](https://img.shields.io/github/issues/storybookjs/storybook/good%20first%20issue.svg)](https://github.com/storybookjs/storybook/issues?q=is%3Aopen+is%3Aissue+label%3A%22good+first+issue%22) cuando pensamos que son adecuadas para personas nuevas en la base de código o en OSS en general.
- [Habla con nosotros](https://discord.gg/storybook), encontraremos algo que se adapte a tus habilidades e intereses de aprendizaje.

### Scripts de desarrollo

Storybook está organizado como un monorepo. Los scripts útiles incluyen:

#### `yarn start`

> Ejecuta una plantilla de Storybook sandbox con historias de prueba

#### `yarn task`

> Como el anterior, pero te da opciones para personalizar el sandbox (por ejemplo, seleccionar otros frameworks)

#### `yarn lint`

> comprobación booleana para saber si el código cumple con las reglas de linting - usa remark & eslint

- `yarn lint:js` - comprobará js
- `yarn lint:md` - comprobará markdown + ejemplos de código
- `yarn lint:js --fix` - corregirá automáticamente js

#### `yarn test`

> comprobación booleana para saber si todas las pruebas unitarias pasan - usa jest

- `yarn run test --core --watch` - ejecutará las pruebas principales en modo watch

### Sponsors

Hazte sponsor para que tu logotipo y URL aparezcan en nuestro README de Github. \[[Hazte sponsor](https://opencollective.com/storybook#sponsor)]

<a href="https://opencollective.com/storybook/tiers/sponsors/0/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/0/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/1/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/1/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/2/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/2/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/3/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/3/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/4/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/4/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/5/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/5/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/6/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/6/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/7/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/7/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/8/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/8/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/9/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/9/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/10/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/10/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/11/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/11/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/12/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/12/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/13/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/13/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/14/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/14/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/15/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/15/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/16/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/16/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/17/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/17/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/18/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/18/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/19/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/19/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/20/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/20/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/21/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/21/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/22/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/22/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/23/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/23/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/24/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/24/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/25/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/25/avatar.svg?requireActive=true"></a>

### Patrocinadores

Al hacer una donación recurrente, puedes apoyarnos y apoyar nuestro trabajo. \[[Hazte patrocinador](https://opencollective.com/storybook#backer)]

<a href="https://opencollective.com/storybook"><img src="https://opencollective.com/storybook/tiers/backers.svg?limit=80&button=false&avatarHeight=46&width=750"></a>

## Licencia

[MIT](https://github.com/storybookjs/storybook/blob/main/LICENSE)

-fin-

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---