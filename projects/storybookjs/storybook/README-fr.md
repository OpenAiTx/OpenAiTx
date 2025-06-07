<p align="center">
  <a href="https://storybook.js.org/">
    <picture>
      <source media="(prefers-color-scheme: dark)" srcset="https://user-images.githubusercontent.com/263385/199832481-bbbf5961-6a26-481d-8224-51258cce9b33.png">
      <img src="https://user-images.githubusercontent.com/321738/63501763-88dbf600-c4cc-11e9-96cd-94adadc2fd72.png" alt="Storybook" width="400" />
    </picture>
    
  </a>
  
</p>

<p align="center">Construisez des composants d’interface utilisateur infaillibles plus rapidement</p>

<br/>

<p align="center">
  <a href="https://circleci.com/gh/storybookjs/storybook">
    <img src="https://circleci.com/gh/storybookjs/storybook.svg?style=shield" alt="Statut de build sur CircleCI" />
  </a>
  <a href="https://codecov.io/gh/storybookjs/storybook">
    <img src="https://codecov.io/gh/storybookjs/storybook/branch/main/graph/badge.svg" alt="codecov" />
  </a>
  <a href="https://github.com/storybookjs/storybook/blob/main/LICENSE">
    <img src="https://img.shields.io/github/license/storybookjs/storybook.svg" alt="Licence" />
  </a>
  <br/>
  <a href="https://discord.gg/storybook">
    <img src="https://img.shields.io/badge/discord-join-7289DA.svg?logo=discord&longCache=true&style=flat" />
  </a>
  <a href="https://storybook.js.org/community/">
    <img src="https://img.shields.io/badge/community-join-4BC424.svg" alt="Communauté Storybook" />
  </a>
  <a href="#backers">
    <img src="https://opencollective.com/storybook/backers/badge.svg" alt="Contributeurs sur Open Collective" />
  </a>
  <a href="#sponsors">
    <img src="https://opencollective.com/storybook/tiers/sponsors/badge.svg" alt="Sponsors sur Open Collective" />
  </a>
  <a href="https://x.com/intent/follow?screen_name=storybookjs">
    <img src="https://img.shields.io/twitter/follow/storybookjs?color=blue&logo=twitter" alt="Compte Twitter officiel" />
  </a>
  <a href="https://api.securityscorecards.dev/projects/github.com/storybookjs/storybook">
    <img src="https://api.securityscorecards.dev/projects/github.com/storybookjs/storybook/badge" alt="OpenSSF Scorecard"/>
  </a>
</p>

<p align="center">
Storybook est un atelier frontend pour construire des composants et des pages UI en isolation. Des milliers d’équipes l’utilisent pour le développement, le test et la documentation d’interfaces. En savoir plus sur https://storybook.js.org !
</p>

<center>
  <img src="https://raw.githubusercontent.com/storybookjs/storybook/main/media/storybook-intro.gif" width="100%" />
</center>

<p align="center">
  Voir le README pour :<br/>
  <a href="https://github.com/storybookjs/storybook/blob/main/README.md" title="latest"><img alt="latest" src="https://img.shields.io/npm/v/@storybook/react/latest?style=for-the-badge&logo=storybook&logoColor=ffffff&color=66BF3C" /></a>
  <a href="https://github.com/storybookjs/storybook/blob/next/README.md" title="next"><img alt="next" src="https://img.shields.io/npm/v/@storybook/react/next?style=for-the-badge&logo=storybook&logoColor=ffffff&color=1EA7FD" /></a>
</p>

## Table des matières

- 🚀 [Démarrage rapide](#getting-started)
- 📒 [Projets](#projects)
  - 🛠 [Frameworks supportés & Exemples](#supported-frameworks)
  - 🔗[Addons](#addons)
- 🏅 [Badges & Matériel de présentation](#badges--presentation-materials)
- 👥 [Communauté](#community)
- 👏 [Contribuer](#contributing)
  - 👨‍💻 [Scripts de développement](#development-scripts)
  - 💸 [Sponsors](#sponsors)
  - 💵 [Contributeurs](#backers)
- :memo: [Licence](#license)

## Démarrage rapide

Visitez le [site Web de Storybook](https://storybook.js.org) pour en savoir plus sur Storybook et commencer.

### Documentation

La documentation est disponible sur le [site de documentation de Storybook](https://storybook.js.org/docs).

### Exemples

Consultez [l'Encyclopédie des composants](https://storybook.js.org/showcase) pour voir comment les équipes leaders utilisent Storybook.

Utilisez [storybook.new](https://storybook.new) pour créer rapidement un projet d’exemple sur Stackblitz.

Storybook est livré avec de nombreux [addons](https://storybook.js.org/docs/configure/user-interface/storybook-addons) pour la conception de composants, la documentation, les tests, l’interactivité, etc. L’API de Storybook permet la configuration et l’extension de multiples façons. Il a même été étendu pour supporter le développement mobile avec React Native, Android, iOS, et Flutter.

### Communauté

Pour obtenir de l’aide supplémentaire, partagez votre problème dans les [Discussions GitHub du dépôt](https://github.com/storybookjs/storybook/discussions/new?category=help).

## Projets

### Frameworks supportés

| Rendu                                                          | Démo                                                                                                                                                                         |                                                                                                                                                       |
| -------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------- |
| [React](code/renderers/react)                                  | [![Démo Storybook](https://img.shields.io/npm/v/@storybook/react/latest?style=flat-square&color=blue&label)](https://next--630511d655df72125520f051.chromatic.com/)          | [![React](https://img.shields.io/npm/dm/@storybook/react?style=flat-square&color=eee)](code/renderers/react)                                          |
| [Angular](code/frameworks/angular/)                            | [![Démo Storybook](https://img.shields.io/npm/v/@storybook/angular/latest?style=flat-square&color=blue&label)](https://next--6322ce6af69825592bbb28fc.chromatic.com/)        | [![Angular](https://img.shields.io/npm/dm/@storybook/angular?style=flat-square&color=eee)](code/frameworks/angular/)                                  |
| [Vue 3](code/renderers/vue3)                                   | [![Démo Storybook](https://img.shields.io/npm/v/@storybook/vue3/latest?style=flat-square&color=blue&label)](https://next--630513346a8e284ae244d415.chromatic.com/)           | [![Vue 3](https://img.shields.io/npm/dm/@storybook/vue3?style=flat-square&color=eee)](code/renderers/vue3/)                                           |
| [Web components](code/renderers/web-components)                | [![Démo Storybook](https://img.shields.io/npm/v/@storybook/web-components/latest?style=flat-square&color=blue&label)](https://next--638db5bf49adfdfe8cf545e0.chromatic.com/) | [![Svelte](https://img.shields.io/npm/dm/@storybook/web-components?style=flat-square&color=eee)](code/renderers/web-components)                       |
| [React Native](https://github.com/storybookjs/react-native)    | [![](https://img.shields.io/npm/v/@storybook/react-native/latest?style=flat-square&color=blue&label)](/)                                                                     | [![React Native](https://img.shields.io/npm/dm/@storybook/react-native?style=flat-square&color=eee)](https://github.com/storybookjs/react-native)     |
| [HTML](code/renderers/html)                                    | [![Démo Storybook](https://img.shields.io/npm/v/@storybook/html/latest?style=flat-square&color=blue&label)](https://next--63dd39a158cf6fc05199b4bb.chromatic.com/)           | [![HTML](https://img.shields.io/npm/dm/@storybook/html?style=flat-square&color=eee)](code/renderers/html)                                             |
| [Ember](code/frameworks/ember/)                                | [![](https://img.shields.io/npm/v/@storybook/ember/latest?style=flat-square&color=blue&label)](/)                                                                            | [![Ember](https://img.shields.io/npm/dm/@storybook/ember?style=flat-square&color=eee)](code/frameworks/ember/)                                        |
| [Svelte](code/renderers/svelte)                                | [![Démo Storybook](https://img.shields.io/npm/v/@storybook/svelte/latest?style=flat-square&color=blue&label)](https://next--630873996e4e3557791c069c.chromatic.com/)         | [![Svelte](https://img.shields.io/npm/dm/@storybook/svelte?style=flat-square&color=eee)](code/renderers/svelte)                                       |
| [Preact](code/renderers/preact)                                | [![Démo Storybook](https://img.shields.io/npm/v/@storybook/preact/latest?style=flat-square&color=blue&label)](https://next--63b588a512565bfaace15e7c.chromatic.com/)         | [![Preact](https://img.shields.io/npm/dm/@storybook/preact?style=flat-square&color=eee)](code/renderers/preact)                                       |
| [Qwik](https://github.com/literalpie/storybook-framework-qwik) | [![](https://img.shields.io/npm/v/storybook-framework-qwik/latest?style=flat-square&color=blue&label)](/)                                                                    | [![Qwik](https://img.shields.io/npm/dm/storybook-framework-qwik?style=flat-square&color=eee)](https://github.com/literalpie/storybook-framework-qwik) |
| [SolidJS](https://github.com/storybookjs/solidjs)              | [![](https://img.shields.io/npm/v/storybook-solidjs/latest?style=flat-square&color=blue&label)](/)                                                                           | [![SolidJS](https://img.shields.io/npm/dm/storybook-solidjs?style=flat-square&color=eee)](https://github.com/storybookjs/solidjs)                     |
| [Android, iOS, Flutter](https://github.com/storybookjs/native) | [![](https://img.shields.io/npm/v/@storybook/native/latest?style=flat-square&color=blue&label)](/)                                                                           | [![Native](https://img.shields.io/npm/dm/@storybook/native?style=flat-square&color=eee)](https://github.com/storybookjs/native)                       |

### Addons

| Addons                                                                    |                                                                            |
| ------------------------------------------------------------------------- | -------------------------------------------------------------------------- |
| [a11y](code/addons/a11y/)                                                 | Testez l’accessibilité des composants dans Storybook                       |
| [actions](code/core/src/actions/)                                         | Enregistrez les actions lors de l’interaction utilisateur avec les composants dans l’UI Storybook |
| [backgrounds](code/core/src/backgrounds)                                  | Permettez aux utilisateurs de choisir les arrière-plans dans l’UI Storybook |
| [cssresources](https://github.com/storybookjs/addon-cssresources)         | Ajoutez/supprimez dynamiquement des ressources CSS à l’iframe du composant |
| [design assets](https://github.com/storybookjs/addon-design-assets)       | Affichez des images, vidéos, et liens web à côté de votre story            |
| [docs](code/addons/docs/)                                                 | Ajoutez une documentation de haute qualité à vos composants                |
| [events](https://github.com/storybookjs/addon-events)                     | Déclenchez des événements de façon interactive pour les composants qui écoutent EventEmitter |
| [google-analytics](https://github.com/storybookjs/addon-google-analytics) | Rapporte les statistiques Google Analytics sur les stories                 |
| [graphql](https://github.com/storybookjs/addon-graphql)                   | Interrogez un serveur GraphQL dans les stories Storybook                   |
| [jest](code/addons/jest/)                                                 | Consultez les résultats des tests unitaires de composants dans Storybook   |
| [links](code/addons/links/)                                               | Créez des liens entre les stories                                          |
| [measure](code/core/src/measure/)                                         | Inspectez visuellement la mise en page et le box model dans l’UI Storybook |
| [outline](code/core/src/outline/)                                         | Déboguez visuellement la mise en page CSS et l’alignement dans l’UI Storybook |
| [query params](https://github.com/storybookjs/addon-queryparams)          | Simulez des paramètres de requête                                          |
| [viewport](code/core/src/viewport/)                                       | Modifiez la taille d’affichage et la mise en page pour les composants responsives via Storybook |

Voir [Tableau de support Addon / Framework](https://storybook.js.org/docs/configure/integration/frameworks-feature-support)

Pour continuer d’améliorer votre expérience, nous devons parfois déprécier ou retirer certains addons au profit de nouveaux outils plus performants.

Si vous utilisez info/notes, nous vous recommandons fortement de migrer vers [docs](code/addons/docs/), et [voici un guide](code/addons/docs/docs/recipes.md#migrating-from-notesinfo-addons) pour vous aider.

Si vous utilisez contexts, nous vous recommandons fortement de migrer vers [toolbars](https://github.com/storybookjs/storybook/tree/next/code/addons/toolbars) et [voici un guide](https://github.com/storybookjs/storybook/blob/next/MIGRATION.md#deprecated-addon-contexts) pour vous aider.

Si vous utilisez addon-storyshots, nous vous recommandons de migrer vers le [test-runner](https://github.com/storybookjs/test-runner) de Storybook et [voici un guide](https://storybook.js.org/docs/writing-tests/storyshots-migration-guide) pour vous accompagner.

## Badges & Matériel de présentation

Nous avons un badge ! Liez-le à votre exemple Storybook en ligne.

![Storybook](https://cdn.jsdelivr.net/gh/storybookjs/brand@main/badge/badge-storybook.svg)

```md
[![Storybook](https://cdn.jsdelivr.net/gh/storybookjs/brand@main/badge/badge-storybook.svg)](lien vers le site)
```

Si vous cherchez du matériel pour vos présentations Storybook, comme des logos, des vidéos, et les couleurs que nous utilisons, tout est disponible sur notre [dépôt brand](https://github.com/storybookjs/brand).

## Communauté

- Tweets via [@storybookjs](https://x.com/storybookjs)
- Blog sur [storybook.js.org](https://storybook.js.org/blog/) et [Medium](https://medium.com/storybookjs)
- Chat sur [Discord](https://discord.gg/storybook)
- Vidéos et diffusions sur [YouTube](https://www.youtube.com/channel/UCr7Quur3eIyA_oe8FNYexfg)

## Contribuer

Les contributions à Storybook sont toujours les bienvenues !

- 📥 Les pull requests et 🌟 les étoiles sont toujours appréciées.
- Lisez notre [guide de contribution](CONTRIBUTING.md) pour commencer,
  ou retrouvez-nous sur [Discord](https://discord.gg/storybook), nous prendrons le temps de vous accompagner.

Vous cherchez un premier ticket à traiter ?

- Nous étiquetons les issues avec [![Good First Issue](https://img.shields.io/github/issues/storybookjs/storybook/good%20first%20issue.svg)](https://github.com/storybookjs/storybook/issues?q=is%3Aopen+is%3Aissue+label%3A%22good+first+issue%22) lorsqu’elles sont adaptées aux nouveaux venus dans la base de code ou l’open source en général.
- [Contactez-nous](https://discord.gg/storybook), nous trouverons quelque chose qui correspond à vos compétences et à vos envies d’apprentissage.

### Scripts de développement

Storybook est organisé comme un monorepo. Les scripts utiles comprennent :

#### `yarn start`

> Lance un Storybook sandbox avec des stories de test

#### `yarn task`

> Comme ci-dessus, mais vous permet de personnaliser le sandbox (par exemple, choisir d’autres frameworks)

#### `yarn lint`

> Vérification booléenne de la conformité du code aux règles de linting - utilise remark & eslint

- `yarn lint:js` - vérifiera le JS
- `yarn lint:md` - vérifiera le Markdown + les exemples de code
- `yarn lint:js --fix` - corrigera automatiquement le JS

#### `yarn test`

> Vérification booléenne que tous les tests unitaires passent - utilise jest

- `yarn run test --core --watch` - lancera les tests du core en mode watch

### Sponsors

Devenez sponsor pour voir votre logo et l’URL de votre site sur notre README sur Github. \[[Devenir sponsor](https://opencollective.com/storybook#sponsor)]

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

### Contributeurs

En faisant un don récurrent, vous pouvez nous soutenir ainsi que notre travail. \[[Devenir contributeur](https://opencollective.com/storybook#backer)]

<a href="https://opencollective.com/storybook"><img src="https://opencollective.com/storybook/tiers/backers.svg?limit=80&button=false&avatarHeight=46&width=750"></a>

## Licence

[MIT](https://github.com/storybookjs/storybook/blob/main/LICENSE)

-la fin-

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---