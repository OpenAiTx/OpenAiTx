## Vue 2 heeft End of Life bereikt

**Je bekijkt nu de inactieve repository voor Vue 2. De actief onderhouden repository voor de nieuwste versie van Vue is [vuejs/core](https://github.com/vuejs/core).**

Vue heeft op 31 december 2023 End of Life bereikt. Het ontvangt geen nieuwe functies, updates of fixes meer. Het is echter nog steeds beschikbaar op alle bestaande distributiekanalen (CDNs, package managers, Github, enz.).

Als je een nieuw project start, begin dan met de nieuwste versie van Vue (3.x). We raden huidige gebruikers van Vue 2 ook sterk aan om te upgraden ([gids](https://v3-migration.vuejs.org/)), maar we begrijpen ook dat niet alle gebruikers de capaciteit of motivatie hebben om dit te doen. Als je op Vue 2 moet blijven maar ook nalevings- of beveiligingseisen hebt met betrekking tot niet-onderhouden software, kijk dan naar [Vue 2 NES](https://www.herodevs.com/support/nes-vue?utm_source=vuejs-github&utm_medium=vue2-readme).

<p align="center"><a href="https://vuejs.org" target="_blank" rel="noopener noreferrer"><img width="100" src="https://vuejs.org/images/logo.png" alt="Vue logo"></a></p>

<p align="center">
  <a href="https://circleci.com/gh/vuejs/vue/tree/dev"><img src="https://img.shields.io/circleci/project/github/vuejs/vue/dev.svg?sanitize=true" alt="Build Status"></a>
  <a href="https://codecov.io/github/vuejs/vue?branch=dev"><img src="https://img.shields.io/codecov/c/github/vuejs/vue/dev.svg?sanitize=true" alt="Coverage Status"></a>
  <a href="https://npmcharts.com/compare/vue?minimal=true"><img src="https://img.shields.io/npm/dm/vue.svg?sanitize=true" alt="Downloads"></a>
  <a href="https://www.npmjs.com/package/vue"><img src="https://img.shields.io/npm/v/vue.svg?sanitize=true" alt="Version"></a>
  <a href="https://www.npmjs.com/package/vue"><img src="https://img.shields.io/npm/l/vue.svg?sanitize=true" alt="License"></a>
  <a href="https://chat.vuejs.org/"><img src="https://img.shields.io/badge/chat-on%20discord-7289da.svg?sanitize=true" alt="Chat"></a>
</p>

## Sponsors

Vue.js is een open source project met MIT-licentie waarvan de voortdurende ontwikkeling volledig mogelijk wordt gemaakt door de steun van deze geweldige [backers](https://github.com/vuejs/core/blob/main/BACKERS.md). Wil je ook bijdragen? Overweeg dan om [Vue te sponsoren](https://vuejs.org/sponsor/).

<p align="center">
  <h3 align="center">Speciale Sponsor</h3>
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

## Introductie

Vue (uitgesproken als `/vjuː/`, zoals "view") is een **progressief framework** voor het bouwen van gebruikersinterfaces. Het is vanaf de basis ontworpen om incrementeel te kunnen worden toegepast, en kan eenvoudig opschalen tussen een bibliotheek en een framework afhankelijk van verschillende gebruiksscenario's. Het bestaat uit een toegankelijke kernbibliotheek die zich alleen richt op de weergavelaag, en een ecosysteem van ondersteunende bibliotheken die helpen bij het beheersen van complexiteit in grote Single-Page Applications.

#### Browsercompatibiliteit

Vue.js ondersteunt alle browsers die [ES5-compatibel](https://compat-table.github.io/compat-table/es5/) zijn (IE8 en lager worden niet ondersteund).

## Ecosysteem

| Project               | Status                                                       | Beschrijving                                             |
| --------------------- | ------------------------------------------------------------ | -------------------------------------------------------- |
| [vue-router]          | [![vue-router-status]][vue-router-package]                   | Routing voor single-page applicaties                     |
| [vuex]                | [![vuex-status]][vuex-package]                               | State management op grote schaal                         |
| [vue-cli]             | [![vue-cli-status]][vue-cli-package]                         | Project scaffolding                                      |
| [vue-loader]          | [![vue-loader-status]][vue-loader-package]                   | Single File Component (`*.vue`-bestand) loader voor webpack |
| [vue-server-renderer] | [![vue-server-renderer-status]][vue-server-renderer-package] | Server-side rendering ondersteuning                      |
| [vue-class-component] | [![vue-class-component-status]][vue-class-component-package] | TypeScript-decorator voor een class-based API            |
| [vue-rx]              | [![vue-rx-status]][vue-rx-package]                           | RxJS-integratie                                          |
| [vue-devtools]        | [![vue-devtools-status]][vue-devtools-package]               | Browser DevTools-extensie                                |

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

## Documentatie

Bekijk [live voorbeelden](https://v2.vuejs.org/v2/examples/) en documentatie op [vuejs.org](https://v2.vuejs.org).

## Vragen

Voor vragen en ondersteuning gebruik [het officiële forum](https://forum.vuejs.org) of de [community chat](https://chat.vuejs.org/). De issuelijst van deze repo is **uitsluitend** bedoeld voor bugrapporten en feature requests.

## Issues

Lees eerst de [Issue Reporting Checklist](https://github.com/vuejs/vue/blob/dev/.github/CONTRIBUTING.md#issue-reporting-guidelines) voordat je een issue aanmaakt. Issues die niet aan de richtlijnen voldoen, kunnen direct worden gesloten.

## Changelog

Gedetailleerde wijzigingen per release zijn te vinden in de [release notes](https://github.com/vuejs/vue/releases).

## Blijf op de hoogte

- [Twitter](https://twitter.com/vuejs)
- [Blog](https://medium.com/the-vue-point)
- [Job Board](https://vuejobs.com/?ref=vuejs)

## Bijdragen

Lees eerst de [Contributing Guide](https://github.com/vuejs/vue/blob/dev/.github/CONTRIBUTING.md) voordat je een pull request indient. Heb je een Vue-gerelateerd project/component/tool? Voeg het toe met een pull request aan [deze samengestelde lijst](https://github.com/vuejs/awesome-vue)!

Dank aan iedereen die al aan Vue heeft bijgedragen!

<a href="https://github.com/vuejs/vue/graphs/contributors"><img src="https://opencollective.com/vuejs/contributors.svg?width=890" /></a>

## Licentie

[MIT](https://opensource.org/licenses/MIT)

Copyright (c) 2013-heden, Yuxi (Evan) You

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---