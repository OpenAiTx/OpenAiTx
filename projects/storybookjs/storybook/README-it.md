<p align="center">
  <a href="https://storybook.js.org/">
    <picture>
      <source media="(prefers-color-scheme: dark)" srcset="https://user-images.githubusercontent.com/263385/199832481-bbbf5961-6a26-481d-8224-51258cce9b33.png">
      <img src="https://user-images.githubusercontent.com/321738/63501763-88dbf600-c4cc-11e9-96cd-94adadc2fd72.png" alt="Storybook" width="400" />
    </picture>
    
  </a>
  
</p>

<p align="center">Costruisci componenti UI a prova di errore più velocemente</p>

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
Storybook è un laboratorio frontend per costruire componenti UI e pagine in isolamento. Migliaia di team lo usano per sviluppo UI, test e documentazione. Scopri di più su https://storybook.js.org!
</p>

<center>
  <img src="https://raw.githubusercontent.com/storybookjs/storybook/main/media/storybook-intro.gif" width="100%" />
</center>

<p align="center">
  Consulta il README per:<br/>
  <a href="https://github.com/storybookjs/storybook/blob/main/README.md" title="latest"><img alt="latest" src="https://img.shields.io/npm/v/@storybook/react/latest?style=for-the-badge&logo=storybook&logoColor=ffffff&color=66BF3C" /></a>
  <a href="https://github.com/storybookjs/storybook/blob/next/README.md" title="next"><img alt="next" src="https://img.shields.io/npm/v/@storybook/react/next?style=for-the-badge&logo=storybook&logoColor=ffffff&color=1EA7FD" /></a>
</p>

## Indice

- 🚀 [Primi passi](#getting-started)
- 📒 [Progetti](#projects)
  - 🛠 [Framework supportati & Esempi](#supported-frameworks)
  - 🔗[Addon](#addons)
- 🏅 [Badge & Materiali di presentazione](#badges--presentation-materials)
- 👥 [Community](#community)
- 👏 [Contribuire](#contributing)
  - 👨‍💻 [Script di sviluppo](#development-scripts)
  - 💸 [Sponsor](#sponsors)
  - 💵 [Sostenitori](#backers)
- :memo: [Licenza](#license)

## Primi passi

Visita il [sito web di Storybook](https://storybook.js.org) per saperne di più su Storybook e iniziare.

### Documentazione

La documentazione è disponibile sul [sito della documentazione di Storybook](https://storybook.js.org/docs).

### Esempi

Consulta l'[Enciclopedia dei Componenti](https://storybook.js.org/showcase) per vedere come i migliori team utilizzano Storybook.

Usa [storybook.new](https://storybook.new) per creare rapidamente un progetto di esempio su Stackblitz.

Storybook include molti [addon](https://storybook.js.org/docs/configure/user-interface/storybook-addons) per design dei componenti, documentazione, test, interattività e altro. L'API di Storybook permette di configurare ed estendere in diversi modi. È stato persino esteso per supportare lo sviluppo mobile con React Native, Android, iOS e Flutter.

### Community

Per ulteriore aiuto, condividi il tuo problema nelle [Discussions di GitHub del repository](https://github.com/storybookjs/storybook/discussions/new?category=help).

## Progetti

### Framework supportati

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

### Addon

| Addon                                                                    |                                                                            |
| ------------------------------------------------------------------------ | -------------------------------------------------------------------------- |
| [a11y](code/addons/a11y/)                                                | Testa i componenti per l'accessibilità in Storybook                        |
| [actions](code/core/src/actions/)                                        | Registra le azioni mentre gli utenti interagiscono con i componenti in UI   |
| [backgrounds](code/core/src/backgrounds)                                 | Permette agli utenti di scegliere gli sfondi nell'UI di Storybook          |
| [cssresources](https://github.com/storybookjs/addon-cssresources)        | Aggiungi/rimuovi dinamicamente risorse CSS all'iframe del componente       |
| [design assets](https://github.com/storybookjs/addon-design-assets)      | Visualizza immagini, video e link web insieme alla tua storia              |
| [docs](code/addons/docs/)                                                | Aggiungi documentazione di alta qualità ai tuoi componenti                 |
| [events](https://github.com/storybookjs/addon-events)                    | Lancia eventi interattivi verso componenti che rispondono a EventEmitter   |
| [google-analytics](https://github.com/storybookjs/addon-google-analytics)| Riporta Google Analytics sulle storie                                      |
| [graphql](https://github.com/storybookjs/addon-graphql)                  | Esegui query su un server GraphQL all'interno delle storie Storybook       |
| [jest](code/addons/jest/)                                                | Visualizza i risultati dei test unitari dei componenti in Storybook        |
| [links](code/addons/links/)                                              | Crea collegamenti tra storie                                               |
| [measure](code/core/src/measure/)                                        | Ispeziona visivamente layout e box model nell'UI di Storybook              |
| [outline](code/core/src/outline/)                                        | Debugga visivamente il layout CSS e l'allineamento nell'UI di Storybook    |
| [query params](https://github.com/storybookjs/addon-queryparams)         | Mock dei parametri di query                                                |
| [viewport](code/core/src/viewport/)                                      | Cambia dimensioni e layout di visualizzazione per componenti responsivi    |

Consulta la [Tabella di Supporto Addon / Framework](https://storybook.js.org/docs/configure/integration/frameworks-feature-support)

Per continuare a migliorare la tua esperienza, dobbiamo talvolta deprecare o rimuovere alcuni addon in favore di strumenti nuovi e migliori.

Se usi info/notes, ti consigliamo vivamente di migrare a [docs](code/addons/docs/), e [qui trovi una guida](code/addons/docs/docs/recipes.md#migrating-from-notesinfo-addons) che ti aiuta.

Se usi contexts, ti consigliamo vivamente di migrare a [toolbars](https://github.com/storybookjs/storybook/tree/next/code/addons/toolbars) e [qui trovi una guida](https://github.com/storybookjs/storybook/blob/next/MIGRATION.md#deprecated-addon-contexts).

Se usi addon-storyshots, ti consigliamo vivamente di migrare allo [storybook test-runner](https://github.com/storybookjs/test-runner) e [qui trovi una guida](https://storybook.js.org/docs/writing-tests/storyshots-migration-guide).

## Badge & Materiali di presentazione

Abbiamo un badge! Collegalo al tuo esempio Storybook online.

![Storybook](https://cdn.jsdelivr.net/gh/storybookjs/brand@main/badge/badge-storybook.svg)

```md
[![Storybook](https://cdn.jsdelivr.net/gh/storybookjs/brand@main/badge/badge-storybook.svg)](link al sito)
```

Se cerchi materiale da usare nelle presentazioni su Storybook, come loghi, video e colori che usiamo, puoi trovare tutto nel nostro [repository brand](https://github.com/storybookjs/brand).

## Community

- Tweet su [@storybookjs](https://x.com/storybookjs)
- Blog su [storybook.js.org](https://storybook.js.org/blog/) e su [Medium](https://medium.com/storybookjs)
- Chat su [Discord](https://discord.gg/storybook)
- Video e streaming su [YouTube](https://www.youtube.com/channel/UCr7Quur3eIyA_oe8FNYexfg)

## Contribuire

I contributi a Storybook sono sempre benvenuti!

- 📥 Pull request e 🌟 Stelle sono sempre ben accetti.
- Leggi la nostra [guida per contribuire](CONTRIBUTING.md) per iniziare,
  oppure trovaci su [Discord](https://discord.gg/storybook), ti guideremo volentieri.

Cerchi un primo problema su cui lavorare?

- Contrassegniamo i problemi con [![Good First Issue](https://img.shields.io/github/issues/storybookjs/storybook/good%20first%20issue.svg)](https://github.com/storybookjs/storybook/issues?q=is%3Aopen+is%3Aissue+label%3A%22good+first+issue%22) quando li riteniamo adatti a chi è nuovo nella codebase o nell’OSS in generale.
- [Parla con noi](https://discord.gg/storybook), troveremo qualcosa che si adatta alle tue competenze e ai tuoi interessi di apprendimento.

### Script di sviluppo

Storybook è organizzato come un monorepo. Gli script utili includono:

#### `yarn start`

> Esegue uno Storybook di esempio sandbox con storie di test

#### `yarn task`

> Come sopra, ma offre opzioni per personalizzare la sandbox (es. selezionare altri framework)

#### `yarn lint`

> Controllo booleano se il codice rispetta le regole di linting - usa remark & eslint

- `yarn lint:js` - controlla js
- `yarn lint:md` - controlla markdown + esempi di codice
- `yarn lint:js --fix` - corregge automaticamente js

#### `yarn test`

> Controllo booleano se tutti i test unitari passano - usa jest

- `yarn run test --core --watch` - esegue i test core in modalità watch

### Sponsor

Diventa sponsor per avere il tuo logo e sito web nel nostro README su Github. \[[Diventa uno sponsor](https://opencollective.com/storybook#sponsor)]

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

### Sostenitori

Sostenendoci con una donazione ricorrente, puoi supportare noi e il nostro lavoro. \[[Diventa sostenitore](https://opencollective.com/storybook#backer)]

<a href="https://opencollective.com/storybook"><img src="https://opencollective.com/storybook/tiers/backers.svg?limit=80&button=false&avatarHeight=46&width=750"></a>

## Licenza

[MIT](https://github.com/storybookjs/storybook/blob/main/LICENSE)

-the end-

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---