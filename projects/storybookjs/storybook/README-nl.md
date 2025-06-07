<p align="center">
  <a href="https://storybook.js.org/">
    <picture>
      <source media="(prefers-color-scheme: dark)" srcset="https://user-images.githubusercontent.com/263385/199832481-bbbf5961-6a26-481d-8224-51258cce9b33.png">
      <img src="https://user-images.githubusercontent.com/321738/63501763-88dbf600-c4cc-11e9-96cd-94adadc2fd72.png" alt="Storybook" width="400" />
    </picture>
    
  </a>
  
</p>

<p align="center">Bouw sneller onverwoestbare UI-componenten</p>

<br/>

<p align="center">
  <a href="https://circleci.com/gh/storybookjs/storybook">
    <img src="https://circleci.com/gh/storybookjs/storybook.svg?style=shield" alt="Build Status on CircleCI" />
  </a>
  <a href="https://codecov.io/gh/storybookjs/storybook">
    <img src="https://codecov.io/gh/storybookjs/storybook/branch/main/graph/badge.svg" alt="codecov" />
  </a>
  <a href="https://github.com/storybookjs/storybook/blob/main/LICENSE">
    <img src="https://img.shields.io/github/license/storybookjs/storybook.svg" alt="License" />
  </a>
  <br/>
  <a href="https://discord.gg/storybook">
    <img src="https://img.shields.io/badge/discord-join-7289DA.svg?logo=discord&longCache=true&style=flat" />
  </a>
  <a href="https://storybook.js.org/community/">
    <img src="https://img.shields.io/badge/community-join-4BC424.svg" alt="Storybook Community" />
  </a>
  <a href="#backers">
    <img src="https://opencollective.com/storybook/backers/badge.svg" alt="Backers on Open Collective" />
  </a>
  <a href="#sponsors">
    <img src="https://opencollective.com/storybook/tiers/sponsors/badge.svg" alt="Sponsors on Open Collective" />
  </a>
  <a href="https://x.com/intent/follow?screen_name=storybookjs">
    <img src="https://img.shields.io/twitter/follow/storybookjs?color=blue&logo=twitter" alt="Official Twitter Handle" />
  </a>
  <a href="https://api.securityscorecards.dev/projects/github.com/storybookjs/storybook">
    <img src="https://api.securityscorecards.dev/projects/github.com/storybookjs/storybook/badge" alt="OpenSSF Scorecard"/>
  </a>
</p>

<p align="center">
Storybook is een frontend-werkplaats voor het bouwen van UI-componenten en pagina's in isolatie. Duizenden teams gebruiken het voor UI-ontwikkeling, testen en documentatie. Ontdek meer op https://storybook.js.org!
</p>

<center>
  <img src="https://raw.githubusercontent.com/storybookjs/storybook/main/media/storybook-intro.gif" width="100%" />
</center>

<p align="center">
  Bekijk README voor:<br/>
  <a href="https://github.com/storybookjs/storybook/blob/main/README.md" title="latest"><img alt="latest" src="https://img.shields.io/npm/v/@storybook/react/latest?style=for-the-badge&logo=storybook&logoColor=ffffff&color=66BF3C" /></a>
  <a href="https://github.com/storybookjs/storybook/blob/next/README.md" title="next"><img alt="next" src="https://img.shields.io/npm/v/@storybook/react/next?style=for-the-badge&logo=storybook&logoColor=ffffff&color=1EA7FD" /></a>
</p>

## Inhoudsopgave

- 🚀 [Aan de slag](#getting-started)
- 📒 [Projecten](#projects)
  - 🛠 [Ondersteunde Frameworks & Voorbeelden](#supported-frameworks)
  - 🔗[Add-ons](#addons)
- 🏅 [Badges & Presentatiemateriaal](#badges--presentation-materials)
- 👥 [Community](#community)
- 👏 [Bijdragen](#contributing)
  - 👨‍💻 [Ontwikkelscripts](#development-scripts)
  - 💸 [Sponsoren](#sponsors)
  - 💵 [Backers](#backers)
- :memo: [Licentie](#license)

## Aan de slag

Bezoek de [Storybook website](https://storybook.js.org) voor meer informatie over Storybook en om te beginnen.

### Documentatie

Documentatie is te vinden op de [Storybook documentatiesite](https://storybook.js.org/docs).

### Voorbeelden

Bekijk de [Component Encyclopedia](https://storybook.js.org/showcase) om te zien hoe toonaangevende teams Storybook gebruiken.

Gebruik [storybook.new](https://storybook.new) om snel een voorbeeldproject te maken in Stackblitz.

Storybook wordt geleverd met veel [add-ons](https://storybook.js.org/docs/configure/user-interface/storybook-addons) voor componentdesign, documentatie, testen, interactiviteit, enzovoort. De Storybook API maakt het mogelijk om op verschillende manieren te configureren en uit te breiden. Het is zelfs uitgebreid om React Native, Android, iOS en Flutter-ontwikkeling voor mobiel te ondersteunen.

### Community

Voor extra hulp, deel je probleem in [de GitHub Discussions van de repo](https://github.com/storybookjs/storybook/discussions/new?category=help).

## Projecten

### Ondersteunde Frameworks

| Renderer                                                       | Demo                                                                                                                                                                         |                                                                                                                                                       |
| -------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------- |
| [React](code/renderers/react)                                  | [![Storybook demo](https://img.shields.io/npm/v/@storybook/react/latest?style=flat-square&color=blue&label)](https://next--630511d655df72125520f051.chromatic.com/)          | [![React](https://img.shields.io/npm/dm/@storybook/react?style=flat-square&color=eee)](code/renderers/react)                                          |
| [Angular](code/frameworks/angular/)                            | [![Storybook demo](https://img.shields.io/npm/v/@storybook/angular/latest?style=flat-square&color=blue&label)](https://next--6322ce6af69825592bbb28fc.chromatic.com/)        | [![Angular](https://img.shields.io/npm/dm/@storybook/angular?style=flat-square&color=eee)](code/frameworks/angular/)                                  |
| [Vue 3](code/renderers/vue3)                                   | [![Storybook demo](https://img.shields.io/npm/v/@storybook/vue3/latest?style=flat-square&color=blue&label)](https://next--630513346a8e284ae244d415.chromatic.com/)           | [![Vue 3](https://img.shields.io/npm/dm/@storybook/vue3?style=flat-square&color=eee)](code/renderers/vue3/)                                           |
| [Web components](code/renderers/web-components)                | [![Storybook demo](https://img.shields.io/npm/v/@storybook/web-components/latest?style=flat-square&color=blue&label)](https://next--638db5bf49adfdfe8cf545e0.chromatic.com/) | [![Svelte](https://img.shields.io/npm/dm/@storybook/web-components?style=flat-square&color=eee)](code/renderers/web-components)                       |
| [React Native](https://github.com/storybookjs/react-native)    | [![](https://img.shields.io/npm/v/@storybook/react-native/latest?style=flat-square&color=blue&label)](/)                                                                     | [![React Native](https://img.shields.io/npm/dm/@storybook/react-native?style=flat-square&color=eee)](https://github.com/storybookjs/react-native)     |
| [HTML](code/renderers/html)                                    | [![Storybook demo](https://img.shields.io/npm/v/@storybook/html/latest?style=flat-square&color=blue&label)](https://next--63dd39a158cf6fc05199b4bb.chromatic.com/)           | [![HTML](https://img.shields.io/npm/dm/@storybook/html?style=flat-square&color=eee)](code/renderers/html)                                             |
| [Ember](code/frameworks/ember/)                                | [![](https://img.shields.io/npm/v/@storybook/ember/latest?style=flat-square&color=blue&label)](/)                                                                            | [![Ember](https://img.shields.io/npm/dm/@storybook/ember?style=flat-square&color=eee)](code/frameworks/ember/)                                        |
| [Svelte](code/renderers/svelte)                                | [![Storybook demo](https://img.shields.io/npm/v/@storybook/svelte/latest?style=flat-square&color=blue&label)](https://next--630873996e4e3557791c069c.chromatic.com/)         | [![Svelte](https://img.shields.io/npm/dm/@storybook/svelte?style=flat-square&color=eee)](code/renderers/svelte)                                       |
| [Preact](code/renderers/preact)                                | [![Storybook demo](https://img.shields.io/npm/v/@storybook/preact/latest?style=flat-square&color=blue&label)](https://next--63b588a512565bfaace15e7c.chromatic.com/)         | [![Preact](https://img.shields.io/npm/dm/@storybook/preact?style=flat-square&color=eee)](code/renderers/preact)                                       |
| [Qwik](https://github.com/literalpie/storybook-framework-qwik) | [![](https://img.shields.io/npm/v/storybook-framework-qwik/latest?style=flat-square&color=blue&label)](/)                                                                    | [![Qwik](https://img.shields.io/npm/dm/storybook-framework-qwik?style=flat-square&color=eee)](https://github.com/literalpie/storybook-framework-qwik) |
| [SolidJS](https://github.com/storybookjs/solidjs)              | [![](https://img.shields.io/npm/v/storybook-solidjs/latest?style=flat-square&color=blue&label)](/)                                                                           | [![SolidJS](https://img.shields.io/npm/dm/storybook-solidjs?style=flat-square&color=eee)](https://github.com/storybookjs/solidjs)                     |
| [Android, iOS, Flutter](https://github.com/storybookjs/native) | [![](https://img.shields.io/npm/v/@storybook/native/latest?style=flat-square&color=blue&label)](/)                                                                           | [![Native](https://img.shields.io/npm/dm/@storybook/native?style=flat-square&color=eee)](https://github.com/storybookjs/native)                       |

### Add-ons

| Add-ons                                                                   |                                                                            |
| ------------------------------------------------------------------------- | -------------------------------------------------------------------------- |
| [a11y](code/addons/a11y/)                                                 | Test componenten op toegankelijkheid voor gebruikers in Storybook           |
| [actions](code/core/src/actions/)                                         | Log acties terwijl gebruikers met componenten interacteren in de Storybook UI |
| [backgrounds](code/core/src/backgrounds)                                  | Laat gebruikers achtergronden kiezen in de Storybook UI                     |
| [cssresources](https://github.com/storybookjs/addon-cssresources)         | Dynamisch CSS-resources toevoegen/verwijderen aan het component iframe      |
| [design assets](https://github.com/storybookjs/addon-design-assets)       | Bekijk afbeeldingen, video's en weblinks naast je story                     |
| [docs](code/addons/docs/)                                                 | Voeg hoogwaardige documentatie toe aan je componenten                       |
| [events](https://github.com/storybookjs/addon-events)                     | Interactief events afvuren naar componenten die reageren op EventEmitter    |
| [google-analytics](https://github.com/storybookjs/addon-google-analytics) | Rapporteert Google Analytics over stories                                   |
| [graphql](https://github.com/storybookjs/addon-graphql)                   | Voer GraphQL-queries uit binnen Storybook stories                           |
| [jest](code/addons/jest/)                                                 | Bekijk de resultaten van unittests van componenten in Storybook             |
| [links](code/addons/links/)                                               | Maak links tussen stories                                                   |
| [measure](code/core/src/measure/)                                         | Inspecteer visueel de layout en box model in de Storybook UI                |
| [outline](code/core/src/outline/)                                         | Visueel debuggen van de CSS-layout en uitlijning in de Storybook UI         |
| [query params](https://github.com/storybookjs/addon-queryparams)          | Mock query parameters                                                       |
| [viewport](code/core/src/viewport/)                                       | Verander weergavegroottes en layouts voor responsieve componenten met Storybook |

Zie de [Add-on / Framework Ondersteuningstabel](https://storybook.js.org/docs/configure/integration/frameworks-feature-support)

Om je ervaring te blijven verbeteren, moeten we soms bepaalde add-ons afschaffen of verwijderen ten gunste van nieuwe en betere tools.

Als je info/notes gebruikt, raden we sterk aan om over te stappen naar [docs](code/addons/docs/), [hier is een gids](code/addons/docs/docs/recipes.md#migrating-from-notesinfo-addons) die je helpt.

Als je contexts gebruikt, raden we sterk aan over te stappen naar [toolbars](https://github.com/storybookjs/storybook/tree/next/code/addons/toolbars), [hier is een gids](https://github.com/storybookjs/storybook/blob/next/MIGRATION.md#deprecated-addon-contexts) om je te helpen.

Als je addon-storyshots gebruikt, raden we aan over te stappen naar de Storybook [test-runner](https://github.com/storybookjs/test-runner), [hier is een gids](https://storybook.js.org/docs/writing-tests/storyshots-migration-guide) die je helpt.

## Badges & Presentatiemateriaal

We hebben een badge! Link deze naar je live Storybook voorbeeld.

![Storybook](https://cdn.jsdelivr.net/gh/storybookjs/brand@main/badge/badge-storybook.svg)

```md
[![Storybook](https://cdn.jsdelivr.net/gh/storybookjs/brand@main/badge/badge-storybook.svg)](link naar site)
```

Als je op zoek bent naar materiaal voor je Storybook-presentatie, zoals logo's, videomateriaal en de kleuren die we gebruiken, vind je alles in onze [brand repo](https://github.com/storybookjs/brand).

## Community

- Tweeten via [@storybookjs](https://x.com/storybookjs)
- Bloggen op [storybook.js.org](https://storybook.js.org/blog/) en [Medium](https://medium.com/storybookjs)
- Chatten op [Discord](https://discord.gg/storybook)
- Video's en streams op [YouTube](https://www.youtube.com/channel/UCr7Quur3eIyA_oe8FNYexfg)

## Bijdragen

Bijdragen aan Storybook zijn altijd welkom!

- 📥 Pull requests en 🌟 sterren zijn altijd welkom.
- Lees onze [bijdragegids](CONTRIBUTING.md) om te beginnen,
  of vind ons op [Discord](https://discord.gg/storybook), we nemen de tijd om je te begeleiden.

Op zoek naar een eerste issue om aan te pakken?

- We taggen issues met [![Good First Issue](https://img.shields.io/github/issues/storybookjs/storybook/good%20first%20issue.svg)](https://github.com/storybookjs/storybook/issues?q=is%3Aopen+is%3Aissue+label%3A%22good+first+issue%22) als we denken dat deze geschikt zijn voor mensen die nieuw zijn met de codebase of OSS in het algemeen.
- [Praat met ons](https://discord.gg/storybook), we vinden iets dat past bij jouw vaardigheden en leerinteresses.

### Ontwikkelscripts

Storybook is georganiseerd als een monorepo. Nuttige scripts zijn onder andere:

#### `yarn start`

> Start een sandbox template storybook met testverhalen

#### `yarn task`

> Zoals hierboven, maar geeft je opties om de sandbox aan te passen (bijvoorbeeld andere frameworks selecteren)

#### `yarn lint`

> Boolean check of de code voldoet aan lintingregels - gebruikt remark & eslint

- `yarn lint:js` - controleert js
- `yarn lint:md` - controleert markdown + codevoorbeelden
- `yarn lint:js --fix` - zal js automatisch corrigeren

#### `yarn test`

> Boolean check of alle unittests slagen - gebruikt jest

- `yarn run test --core --watch` - draait core tests in watch-modus

### Sponsoren

Word sponsor om je logo en website-URL op onze README op Github te tonen. \[[Word sponsor](https://opencollective.com/storybook#sponsor)]

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

### Backers

Door een terugkerende donatie te doen, kun je ons en ons werk ondersteunen. \[[Word backer](https://opencollective.com/storybook#backer)]

<a href="https://opencollective.com/storybook"><img src="https://opencollective.com/storybook/tiers/backers.svg?limit=80&button=false&avatarHeight=46&width=750"></a>

## Licentie

[MIT](https://github.com/storybookjs/storybook/blob/main/LICENSE)

-einde-

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---