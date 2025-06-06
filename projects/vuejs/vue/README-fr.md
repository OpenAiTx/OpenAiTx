## Vue 2 est arrivé en fin de vie

**Vous consultez le dépôt désormais inactif de Vue 2. Le dépôt activement maintenu pour la dernière version de Vue est [vuejs/core](https://github.com/vuejs/core).**

Vue est arrivé en fin de vie le 31 décembre 2023. Il ne reçoit plus de nouvelles fonctionnalités, mises à jour ou correctifs. Cependant, il reste disponible sur tous les canaux de distribution existants (CDN, gestionnaires de paquets, Github, etc).

Si vous démarrez un nouveau projet, veuillez utiliser la dernière version de Vue (3.x). Nous recommandons également fortement aux utilisateurs actuels de Vue 2 de migrer ([guide](https://v3-migration.vuejs.org/)), mais nous reconnaissons aussi que tous les utilisateurs n'ont pas la capacité ou la motivation de le faire. Si vous devez rester sur Vue 2 mais que vous avez des exigences de conformité ou de sécurité concernant les logiciels non maintenus, consultez [Vue 2 NES](https://www.herodevs.com/support/nes-vue?utm_source=vuejs-github&utm_medium=vue2-readme).

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

Vue.js est un projet open source sous licence MIT dont le développement continu est rendu possible uniquement grâce au soutien de ces formidables [soutiens](https://github.com/vuejs/core/blob/main/BACKERS.md). Si vous souhaitez les rejoindre, veuillez envisager de [soutenir le développement de Vue](https://vuejs.org/sponsor/).

<p align="center">
  <h3 align="center">Sponsor spécial</h3>
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

## Introduction

Vue (prononcé `/vjuː/`, comme "vue") est un **framework progressif** pour la création d'interfaces utilisateur. Il est conçu dès le départ pour être adoptable de manière incrémentielle, et peut facilement évoluer d'une bibliothèque à un framework complet selon les cas d'utilisation. Il se compose d'une bibliothèque centrale accessible qui se concentre uniquement sur la couche vue, et d'un écosystème de bibliothèques de support qui vous aide à gérer la complexité dans de grandes applications monopage.

#### Compatibilité avec les navigateurs

Vue.js prend en charge tous les navigateurs [compatibles ES5](https://compat-table.github.io/compat-table/es5/) (IE8 et versions inférieures non pris en charge).

## Écosystème

| Projet                | Statut                                                       | Description                                             |
| --------------------- | ------------------------------------------------------------ | ------------------------------------------------------- |
| [vue-router]          | [![vue-router-status]][vue-router-package]                   | Routage d'applications monopage                         |
| [vuex]                | [![vuex-status]][vuex-package]                               | Gestion d'état à grande échelle                         |
| [vue-cli]             | [![vue-cli-status]][vue-cli-package]                         | Génération de projets                                   |
| [vue-loader]          | [![vue-loader-status]][vue-loader-package]                   | Chargeur de composants monofichier (`*.vue`) pour webpack |
| [vue-server-renderer] | [![vue-server-renderer-status]][vue-server-renderer-package] | Prise en charge du rendu côté serveur                   |
| [vue-class-component] | [![vue-class-component-status]][vue-class-component-package] | Décorateur TypeScript pour une API basée sur les classes |
| [vue-rx]              | [![vue-rx-status]][vue-rx-package]                           | Intégration RxJS                                        |
| [vue-devtools]        | [![vue-devtools-status]][vue-devtools-package]               | Extension DevTools pour le navigateur                   |

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

## Documentation

Pour consulter des [exemples en direct](https://v2.vuejs.org/v2/examples/) et la documentation, rendez-vous sur [vuejs.org](https://v2.vuejs.org).

## Questions

Pour toute question ou demande de support, veuillez utiliser [le forum officiel](https://forum.vuejs.org) ou [le chat communautaire](https://chat.vuejs.org/). La liste des issues de ce dépôt est **exclusivement** réservée aux rapports de bugs et demandes de fonctionnalités.

## Problèmes

Veuillez vous assurer de lire la [checklist de signalement d'anomalie](https://github.com/vuejs/vue/blob/dev/.github/CONTRIBUTING.md#issue-reporting-guidelines) avant d'ouvrir un ticket. Les issues ne respectant pas ces recommandations peuvent être fermées immédiatement.

## Journal des modifications

Les changements détaillés pour chaque version sont documentés dans les [notes de version](https://github.com/vuejs/vue/releases).

## Restez en contact

- [Twitter](https://twitter.com/vuejs)
- [Blog](https://medium.com/the-vue-point)
- [Job Board](https://vuejobs.com/?ref=vuejs)

## Contribution

Veuillez lire le [guide de contribution](https://github.com/vuejs/vue/blob/dev/.github/CONTRIBUTING.md) avant de proposer une pull request. Si vous avez un projet/composant/outil lié à Vue, ajoutez-le via une pull request à [cette liste sélectionnée](https://github.com/vuejs/awesome-vue) !

Merci à toutes les personnes ayant déjà contribué à Vue !

<a href="https://github.com/vuejs/vue/graphs/contributors"><img src="https://opencollective.com/vuejs/contributors.svg?width=890" /></a>

## Licence

[MIT](https://opensource.org/licenses/MIT)

Copyright (c) 2013-présent, Yuxi (Evan) You

---

[Powered By DeepAiTx](https://github.com/DeepAiTx)

---