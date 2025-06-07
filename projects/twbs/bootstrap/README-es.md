<p align="center">
  <a href="https://getbootstrap.com/">
    <img src="https://getbootstrap.com/docs/5.3/assets/brand/bootstrap-logo-shadow.png" alt="Bootstrap logo" width="200" height="165">
  </a>
</p>

<h3 align="center">Bootstrap</h3>

<p align="center">
  Un framework de front-end elegante, intuitivo y potente para un desarrollo web más rápido y sencillo.
  <br>
  <a href="https://getbootstrap.com/docs/5.3/"><strong>Explora la documentación de Bootstrap »</strong></a>
  <br>
  <br>
  <a href="https://github.com/twbs/bootstrap/issues/new?assignees=-&labels=bug&template=bug_report.yml">Reportar un error</a>
  ·
  <a href="https://github.com/twbs/bootstrap/issues/new?assignees=&labels=feature&template=feature_request.yml">Solicitar una función</a>
  ·
  <a href="https://themes.getbootstrap.com/">Temas</a>
  ·
  <a href="https://blog.getbootstrap.com/">Blog</a>
</p>


## Bootstrap 5

Nuestra rama predeterminada es para el desarrollo de nuestra versión Bootstrap 5. Dirígete a la [rama `v4-dev`](https://github.com/twbs/bootstrap/tree/v4-dev) para ver el readme, la documentación y el código fuente de Bootstrap 4.


## Tabla de contenidos

- [Inicio rápido](#inicio-rápido)
- [Estado](#estado)
- [Qué está incluido](#qué-está-incluido)
- [Errores y solicitudes de funciones](#errores-y-solicitudes-de-funciones)
- [Documentación](#documentación)
- [Contribuir](#contribuir)
- [Comunidad](#comunidad)
- [Versionado](#versionado)
- [Creadores](#creadores)
- [Agradecimientos](#agradecimientos)
- [Derechos de autor y licencia](#derechos-de-autor-y-licencia)


## Inicio rápido

Varias opciones de inicio rápido están disponibles:

- [Descarga la última versión](https://github.com/twbs/bootstrap/archive/v5.3.6.zip)
- Clona el repositorio: `git clone https://github.com/twbs/bootstrap.git`
- Instala con [npm](https://www.npmjs.com/): `npm install bootstrap@v5.3.6`
- Instala con [yarn](https://yarnpkg.com/): `yarn add bootstrap@v5.3.6`
- Instala con [Bun](https://bun.sh/): `bun add bootstrap@v5.3.6`
- Instala con [Composer](https://getcomposer.org/): `composer require twbs/bootstrap:5.3.6`
- Instala con [NuGet](https://www.nuget.org/): CSS: `Install-Package bootstrap` Sass: `Install-Package bootstrap.sass`

Lee la [página de introducción](https://getbootstrap.com/docs/5.3/getting-started/introduction/) para obtener información sobre el contenido del framework, plantillas, ejemplos y más.


## Estado

[![Build Status](https://img.shields.io/github/actions/workflow/status/twbs/bootstrap/js.yml?branch=main&label=JS%20Tests&logo=github)](https://github.com/twbs/bootstrap/actions/workflows/js.yml?query=workflow%3AJS+branch%3Amain)
[![npm version](https://img.shields.io/npm/v/bootstrap?logo=npm&logoColor=fff)](https://www.npmjs.com/package/bootstrap)
[![Gem version](https://img.shields.io/gem/v/bootstrap?logo=rubygems&logoColor=fff)](https://rubygems.org/gems/bootstrap)
[![Meteor Atmosphere](https://img.shields.io/badge/meteor-twbs%3Abootstrap-blue?logo=meteor&logoColor=fff)](https://atmospherejs.com/twbs/bootstrap)
[![Packagist Prerelease](https://img.shields.io/packagist/vpre/twbs/bootstrap?logo=packagist&logoColor=fff)](https://packagist.org/packages/twbs/bootstrap)
[![NuGet](https://img.shields.io/nuget/vpre/bootstrap?logo=nuget&logoColor=fff)](https://www.nuget.org/packages/bootstrap/absoluteLatest)
[![Coverage Status](https://img.shields.io/coveralls/github/twbs/bootstrap/main?logo=coveralls&logoColor=fff)](https://coveralls.io/github/twbs/bootstrap?branch=main)
[![CSS gzip size](https://img.badgesize.io/twbs/bootstrap/main/dist/css/bootstrap.min.css?compression=gzip&label=CSS%20gzip%20size)](https://github.com/twbs/bootstrap/blob/main/dist/css/bootstrap.min.css)
[![CSS Brotli size](https://img.badgesize.io/twbs/bootstrap/main/dist/css/bootstrap.min.css?compression=brotli&label=CSS%20Brotli%20size)](https://github.com/twbs/bootstrap/blob/main/dist/css/bootstrap.min.css)
[![JS gzip size](https://img.badgesize.io/twbs/bootstrap/main/dist/js/bootstrap.min.js?compression=gzip&label=JS%20gzip%20size)](https://github.com/twbs/bootstrap/blob/main/dist/js/bootstrap.min.js)
[![JS Brotli size](https://img.badgesize.io/twbs/bootstrap/main/dist/js/bootstrap.min.js?compression=brotli&label=JS%20Brotli%20size)](https://github.com/twbs/bootstrap/blob/main/dist/js/bootstrap.min.js)
[![Backers on Open Collective](https://img.shields.io/opencollective/backers/bootstrap?logo=opencollective&logoColor=fff)](#backers)
[![Sponsors on Open Collective](https://img.shields.io/opencollective/sponsors/bootstrap?logo=opencollective&logoColor=fff)](#sponsors)


## Qué está incluido

Dentro de la descarga encontrarás los siguientes directorios y archivos, agrupando lógicamente los recursos comunes y proporcionando tanto variaciones compiladas como minificadas.

<details>
  <summary>Contenido de la descarga</summary>

  ```text
  bootstrap/
  ├── css/
  │   ├── bootstrap-grid.css
  │   ├── bootstrap-grid.css.map
  │   ├── bootstrap-grid.min.css
  │   ├── bootstrap-grid.min.css.map
  │   ├── bootstrap-grid.rtl.css
  │   ├── bootstrap-grid.rtl.css.map
  │   ├── bootstrap-grid.rtl.min.css
  │   ├── bootstrap-grid.rtl.min.css.map
  │   ├── bootstrap-reboot.css
  │   ├── bootstrap-reboot.css.map
  │   ├── bootstrap-reboot.min.css
  │   ├── bootstrap-reboot.min.css.map
  │   ├── bootstrap-reboot.rtl.css
  │   ├── bootstrap-reboot.rtl.css.map
  │   ├── bootstrap-reboot.rtl.min.css
  │   ├── bootstrap-reboot.rtl.min.css.map
  │   ├── bootstrap-utilities.css
  │   ├── bootstrap-utilities.css.map
  │   ├── bootstrap-utilities.min.css
  │   ├── bootstrap-utilities.min.css.map
  │   ├── bootstrap-utilities.rtl.css
  │   ├── bootstrap-utilities.rtl.css.map
  │   ├── bootstrap-utilities.rtl.min.css
  │   ├── bootstrap-utilities.rtl.min.css.map
  │   ├── bootstrap.css
  │   ├── bootstrap.css.map
  │   ├── bootstrap.min.css
  │   ├── bootstrap.min.css.map
  │   ├── bootstrap.rtl.css
  │   ├── bootstrap.rtl.css.map
  │   ├── bootstrap.rtl.min.css
  │   └── bootstrap.rtl.min.css.map
  └── js/
      ├── bootstrap.bundle.js
      ├── bootstrap.bundle.js.map
      ├── bootstrap.bundle.min.js
      ├── bootstrap.bundle.min.js.map
      ├── bootstrap.esm.js
      ├── bootstrap.esm.js.map
      ├── bootstrap.esm.min.js
      ├── bootstrap.esm.min.js.map
      ├── bootstrap.js
      ├── bootstrap.js.map
      ├── bootstrap.min.js
      └── bootstrap.min.js.map
  ```
</details>

Proveemos CSS y JS compilados (`bootstrap.*`), así como CSS y JS compilados y minificados (`bootstrap.min.*`). Los [mapas de origen](https://web.dev/articles/source-maps) (`bootstrap.*.map`) están disponibles para su uso con ciertas herramientas de desarrollo de los navegadores. Los archivos JS empaquetados (`bootstrap.bundle.js` y el minificado `bootstrap.bundle.min.js`) incluyen [Popper](https://popper.js.org/docs/v2/).


## Errores y solicitudes de funciones

¿Tienes un error o una solicitud de función? Por favor, primero lee las [directrices para issues](https://github.com/twbs/bootstrap/blob/main/.github/CONTRIBUTING.md#using-the-issue-tracker) y busca issues existentes o cerrados. Si tu problema o idea aún no ha sido abordado, [abre un nuevo issue](https://github.com/twbs/bootstrap/issues/new/choose).


## Documentación

La documentación de Bootstrap, incluida en este repositorio en el directorio raíz, está construida con [Astro](https://astro.build/) y alojada públicamente en GitHub Pages en <https://getbootstrap.com/>. La documentación también puede ejecutarse localmente.

La búsqueda en la documentación está potenciada por [DocSearch de Algolia](https://docsearch.algolia.com/).

### Ejecutar la documentación localmente

1. Ejecuta `npm install` para instalar las dependencias de Node.js, incluido Astro (el generador del sitio).
2. Ejecuta `npm run test` (o un script específico de npm) para reconstruir los archivos distribuidos de CSS y JavaScript, así como los recursos de la documentación.
3. Desde el directorio raíz `/bootstrap`, ejecuta `npm run docs-serve` en la línea de comandos.
4. Abre `http://localhost:9001/` en tu navegador, y voilà.

Aprende más sobre el uso de Astro leyendo su [documentación](https://docs.astro.build/en/getting-started/).

### Documentación de versiones anteriores

Puedes encontrar toda nuestra documentación de versiones anteriores en <https://getbootstrap.com/docs/versions/>.

[Versiones anteriores](https://github.com/twbs/bootstrap/releases) y su documentación también están disponibles para descargar.


## Contribuir

Por favor, lee nuestras [directrices de contribución](https://github.com/twbs/bootstrap/blob/main/.github/CONTRIBUTING.md). Se incluyen instrucciones para abrir issues, estándares de codificación y notas sobre desarrollo.

Además, si tu pull request contiene parches o funciones de JavaScript, debes incluir [pruebas unitarias relevantes](https://github.com/twbs/bootstrap/tree/main/js/tests). Todo el HTML y CSS debe cumplir con la [Guía de Código](https://github.com/mdo/code-guide), mantenida por [Mark Otto](https://github.com/mdo).

Las preferencias de editor están disponibles en la [configuración del editor](https://github.com/twbs/bootstrap/blob/main/.editorconfig) para facilitar su uso en editores de texto comunes. Lee más y descarga plugins en <https://editorconfig.org/>.


## Comunidad

Recibe actualizaciones sobre el desarrollo de Bootstrap y chatea con los mantenedores del proyecto y miembros de la comunidad.

- Sigue a [@getbootstrap en X](https://x.com/getbootstrap).
- Lee y suscríbete a [El Blog Oficial de Bootstrap](https://blog.getbootstrap.com/).
- Haz preguntas y explora [nuestras discusiones en GitHub](https://github.com/twbs/bootstrap/discussions).
- Debate, haz preguntas y más en [el Discord de la comunidad](https://discord.gg/bZUvakRU3M) o en el [subreddit de Bootstrap](https://www.reddit.com/r/bootstrap/).
- Chatea con otros Bootstrappers en IRC. En el servidor `irc.libera.chat`, en el canal `#bootstrap`.
- Puedes encontrar ayuda de implementación en Stack Overflow (etiquetado [`bootstrap-5`](https://stackoverflow.com/questions/tagged/bootstrap-5)).
- Los desarrolladores deben usar la palabra clave `bootstrap` en los paquetes que modifiquen o añadan funcionalidad a Bootstrap al distribuirse mediante [npm](https://www.npmjs.com/browse/keyword/bootstrap) o mecanismos de entrega similares para máxima visibilidad.


## Versionado

Por transparencia en nuestro ciclo de lanzamientos y con el objetivo de mantener la compatibilidad hacia atrás, Bootstrap se mantiene bajo [las directrices de Versionado Semántico](https://semver.org/). A veces cometemos errores, pero nos adherimos a esas reglas siempre que es posible.

Consulta [la sección de Lanzamientos de nuestro proyecto en GitHub](https://github.com/twbs/bootstrap/releases) para ver los registros de cambios de cada versión de Bootstrap. Las publicaciones de anuncios de lanzamientos en [el blog oficial de Bootstrap](https://blog.getbootstrap.com/) contienen resúmenes de los cambios más relevantes realizados en cada versión.


## Creadores

**Mark Otto**

- <https://x.com/mdo>
- <https://github.com/mdo>

**Jacob Thornton**

- <https://x.com/fat>
- <https://github.com/fat>


## Agradecimientos

<a href="https://www.browserstack.com/">
  <img src="https://live.browserstack.com/images/opensource/browserstack-logo.svg" alt="BrowserStack" width="192" height="42">
</a>

¡Gracias a [BrowserStack](https://www.browserstack.com/) por proporcionar la infraestructura que nos permite probar en navegadores reales!

<a href="https://www.netlify.com/">
  <img src="https://www.netlify.com/v3/img/components/full-logo-light.svg" alt="Netlify" width="147" height="40">
</a>

¡Gracias a [Netlify](https://www.netlify.com/) por proporcionarnos Deploy Previews!


## Patrocinadores

Apoya este proyecto convirtiéndote en patrocinador. Tu logo aparecerá aquí con un enlace a tu sitio web. [[Conviértete en patrocinador](https://opencollective.com/bootstrap#sponsor)]

[![OC sponsor 0](https://opencollective.com/bootstrap/sponsor/0/avatar.svg)](https://opencollective.com/bootstrap/sponsor/0/website)
[![OC sponsor 1](https://opencollective.com/bootstrap/sponsor/1/avatar.svg)](https://opencollective.com/bootstrap/sponsor/1/website)
[![OC sponsor 2](https://opencollective.com/bootstrap/sponsor/2/avatar.svg)](https://opencollective.com/bootstrap/sponsor/2/website)
[![OC sponsor 3](https://opencollective.com/bootstrap/sponsor/3/avatar.svg)](https://opencollective.com/bootstrap/sponsor/3/website)
[![OC sponsor 4](https://opencollective.com/bootstrap/sponsor/4/avatar.svg)](https://opencollective.com/bootstrap/sponsor/4/website)
[![OC sponsor 5](https://opencollective.com/bootstrap/sponsor/5/avatar.svg)](https://opencollective.com/bootstrap/sponsor/5/website)
[![OC sponsor 6](https://opencollective.com/bootstrap/sponsor/6/avatar.svg)](https://opencollective.com/bootstrap/sponsor/6/website)
[![OC sponsor 7](https://opencollective.com/bootstrap/sponsor/7/avatar.svg)](https://opencollective.com/bootstrap/sponsor/7/website)
[![OC sponsor 8](https://opencollective.com/bootstrap/sponsor/8/avatar.svg)](https://opencollective.com/bootstrap/sponsor/8/website)
[![OC sponsor 9](https://opencollective.com/bootstrap/sponsor/9/avatar.svg)](https://opencollective.com/bootstrap/sponsor/9/website)


## Patrocinadores individuales

¡Gracias a todos nuestros patrocinadores! 🙏 [[Conviértete en patrocinador individual](https://opencollective.com/bootstrap#backer)]

[![Backers](https://opencollective.com/bootstrap/backers.svg?width=890)](https://opencollective.com/bootstrap#backers)


## Derechos de autor y licencia

Código y documentación copyright 2011-2025 de los [Autores de Bootstrap](https://github.com/twbs/bootstrap/graphs/contributors). Código liberado bajo la [Licencia MIT](https://github.com/twbs/bootstrap/blob/main/LICENSE). Documentación liberada bajo [Creative Commons](https://creativecommons.org/licenses/by/3.0/).

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---