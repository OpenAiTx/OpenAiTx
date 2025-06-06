## Vue 2 ha raggiunto la Fine del Ciclo di Vita

**Stai visualizzando il repository ora inattivo di Vue 2. Il repository attivamente mantenuto per l'ultima versione di Vue è [vuejs/core](https://github.com/vuejs/core).**

Vue ha raggiunto la Fine del Ciclo di Vita il 31 dicembre 2023. Non riceverà più nuove funzionalità, aggiornamenti o correzioni. Tuttavia, è ancora disponibile su tutti i canali di distribuzione esistenti (CDN, gestori di pacchetti, Github, ecc).

Se stai iniziando un nuovo progetto, ti consigliamo di iniziare con l'ultima versione di Vue (3.x). Raccomandiamo inoltre vivamente agli utenti attuali di Vue 2 di eseguire l'aggiornamento ([guida](https://v3-migration.vuejs.org/)), ma riconosciamo anche che non tutti gli utenti hanno la possibilità o l'interesse a farlo. Se sei costretto a rimanere su Vue 2 ma hai anche requisiti di conformità o sicurezza riguardo a software non più mantenuto, dai un'occhiata a [Vue 2 NES](https://www.herodevs.com/support/nes-vue?utm_source=vuejs-github&utm_medium=vue2-readme).

<p align="center"><a href="https://vuejs.org" target="_blank" rel="noopener noreferrer"><img width="100" src="https://vuejs.org/images/logo.png" alt="Vue logo"></a></p>

<p align="center">
  <a href="https://circleci.com/gh/vuejs/vue/tree/dev"><img src="https://img.shields.io/circleci/project/github/vuejs/vue/dev.svg?sanitize=true" alt="Build Status"></a>
  <a href="https://codecov.io/github/vuejs/vue?branch=dev"><img src="https://img.shields.io/codecov/c/github/vuejs/vue/dev.svg?sanitize=true" alt="Coverage Status"></a>
  <a href="https://npmcharts.com/compare/vue?minimal=true"><img src="https://img.shields.io/npm/dm/vue.svg?sanitize=true" alt="Downloads"></a>
  <a href="https://www.npmjs.com/package/vue"><img src="https://img.shields.io/npm/v/vue.svg?sanitize=true" alt="Version"></a>
  <a href="https://www.npmjs.com/package/vue"><img src="https://img.shields.io/npm/l/vue.svg?sanitize=true" alt="License"></a>
  <a href="https://chat.vuejs.org/"><img src="https://img.shields.io/badge/chat-on%20discord-7289da.svg?sanitize=true" alt="Chat"></a>
</p>

## Sponsor

Vue.js è un progetto open source con licenza MIT il cui sviluppo continuo è reso possibile interamente dal supporto di questi fantastici [sostenitori](https://github.com/vuejs/core/blob/main/BACKERS.md). Se vuoi unirti a loro, considera di [sponsorizzare lo sviluppo di Vue](https://vuejs.org/sponsor/).

<p align="center">
  <h3 align="center">Sponsor Speciale</h3>
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

## Introduzione

Vue (pronunciato `/vjuː/`, come "view") è un **framework progressivo** per la creazione di interfacce utente. È stato progettato fin dall'inizio per essere adottabile in modo incrementale e può facilmente scalare da una libreria a un framework a seconda dei diversi casi d'uso. Consiste in una libreria core accessibile che si concentra solo sul livello della vista e in un ecosistema di librerie di supporto che aiutano a gestire la complessità nelle grandi Applicazioni a Pagina Singola.

#### Compatibilità con i Browser

Vue.js supporta tutti i browser che sono [compatibili con ES5](https://compat-table.github.io/compat-table/es5/) (IE8 e versioni precedenti non sono supportati).

## Ecosistema

| Progetto              | Stato                                                        | Descrizione                                             |
| --------------------- | ------------------------------------------------------------ | ------------------------------------------------------- |
| [vue-router]          | [![vue-router-status]][vue-router-package]                   | Routing per applicazioni a pagina singola               |
| [vuex]                | [![vuex-status]][vuex-package]                               | Gestione dello stato su larga scala                     |
| [vue-cli]             | [![vue-cli-status]][vue-cli-package]                         | Impalcatura del progetto                                |
| [vue-loader]          | [![vue-loader-status]][vue-loader-package]                   | Loader per Componenti a File Singolo (`*.vue`) per webpack |
| [vue-server-renderer] | [![vue-server-renderer-status]][vue-server-renderer-package] | Supporto al rendering lato server                       |
| [vue-class-component] | [![vue-class-component-status]][vue-class-component-package] | Decoratore TypeScript per un'API basata su classi       |
| [vue-rx]              | [![vue-rx-status]][vue-rx-package]                           | Integrazione RxJS                                       |
| [vue-devtools]        | [![vue-devtools-status]][vue-devtools-package]               | Estensione DevTools per il browser                      |

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

## Documentazione

Per consultare [esempi dal vivo](https://v2.vuejs.org/v2/examples/) e la documentazione, visita [vuejs.org](https://v2.vuejs.org).

## Domande

Per domande e supporto utilizza [il forum ufficiale](https://forum.vuejs.org) o la [chat della community](https://chat.vuejs.org/). L'elenco delle issue di questo repository è **esclusivamente** per segnalazioni di bug e richieste di funzionalità.

## Issue

Assicurati di leggere la [Checklist per la Segnalazione delle Issue](https://github.com/vuejs/vue/blob/dev/.github/CONTRIBUTING.md#issue-reporting-guidelines) prima di aprire una issue. Le segnalazioni che non rispettano le linee guida potrebbero essere chiuse immediatamente.

## Changelog

Le modifiche dettagliate per ogni rilascio sono documentate nelle [note di rilascio](https://github.com/vuejs/vue/releases).

## Rimani in Contatto

- [Twitter](https://twitter.com/vuejs)
- [Blog](https://medium.com/the-vue-point)
- [Bacheca Lavoro](https://vuejobs.com/?ref=vuejs)

## Contribuzione

Assicurati di leggere la [Guida alle Contribuzioni](https://github.com/vuejs/vue/blob/dev/.github/CONTRIBUTING.md) prima di inviare una pull request. Se hai un progetto/componente/strumento relativo a Vue, aggiungilo con una pull request a [questa lista curata](https://github.com/vuejs/awesome-vue)!

Grazie a tutte le persone che hanno già contribuito a Vue!

<a href="https://github.com/vuejs/vue/graphs/contributors"><img src="https://opencollective.com/vuejs/contributors.svg?width=890" /></a>

## Licenza

[MIT](https://opensource.org/licenses/MIT)

Copyright (c) 2013-presente, Yuxi (Evan) You

---

[Powered By DeepAiTx](https://github.com/DeepAiTx)

---