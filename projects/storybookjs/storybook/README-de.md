<p align="center">
  <a href="https://storybook.js.org/">
    <picture>
      <source media="(prefers-color-scheme: dark)" srcset="https://user-images.githubusercontent.com/263385/199832481-bbbf5961-6a26-481d-8224-51258cce9b33.png">
      <img src="https://user-images.githubusercontent.com/321738/63501763-88dbf600-c4cc-11e9-96cd-94adadc2fd72.png" alt="Storybook" width="400" />
    </picture>
    
  </a>
  
</p>

<p align="center">Erstellen Sie schnell unverwüstliche UI-Komponenten</p>

<br/>

<p align="center">
  <a href="https://circleci.com/gh/storybookjs/storybook">
    <img src="https://circleci.com/gh/storybookjs/storybook.svg?style=shield" alt="Build-Status auf CircleCI" />
  </a>
  <a href="https://codecov.io/gh/storybookjs/storybook">
    <img src="https://codecov.io/gh/storybookjs/storybook/branch/main/graph/badge.svg" alt="codecov" />
  </a>
  <a href="https://github.com/storybookjs/storybook/blob/main/LICENSE">
    <img src="https://img.shields.io/github/license/storybookjs/storybook.svg" alt="Lizenz" />
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
    <img src="https://img.shields.io/twitter/follow/storybookjs?color=blue&logo=twitter" alt="Offizieller Twitter-Handle" />
  </a>
  <a href="https://api.securityscorecards.dev/projects/github.com/storybookjs/storybook">
    <img src="https://api.securityscorecards.dev/projects/github.com/storybookjs/storybook/badge" alt="OpenSSF Scorecard"/>
  </a>
</p>

<p align="center">
Storybook ist eine Frontend-Workshop-Umgebung zur Erstellung von UI-Komponenten und Seiten in Isolation. Tausende Teams nutzen es für UI-Entwicklung, Tests und Dokumentation. Mehr erfahren unter https://storybook.js.org!
</p>

<center>
  <img src="https://raw.githubusercontent.com/storybookjs/storybook/main/media/storybook-intro.gif" width="100%" />
</center>

<p align="center">
  README ansehen für:<br/>
  <a href="https://github.com/storybookjs/storybook/blob/main/README.md" title="latest"><img alt="latest" src="https://img.shields.io/npm/v/@storybook/react/latest?style=for-the-badge&logo=storybook&logoColor=ffffff&color=66BF3C" /></a>
  <a href="https://github.com/storybookjs/storybook/blob/next/README.md" title="next"><img alt="next" src="https://img.shields.io/npm/v/@storybook/react/next?style=for-the-badge&logo=storybook&logoColor=ffffff&color=1EA7FD" /></a>
</p>

## Inhaltsverzeichnis

- 🚀 [Erste Schritte](#getting-started)
- 📒 [Projekte](#projects)
  - 🛠 [Unterstützte Frameworks & Beispiele](#supported-frameworks)
  - 🔗[Addons](#addons)
- 🏅 [Badges & Präsentationsmaterial](#badges--presentation-materials)
- 👥 [Community](#community)
- 👏 [Mitwirken](#contributing)
  - 👨‍💻 [Entwicklungsskripte](#development-scripts)
  - 💸 [Sponsoren](#sponsors)
  - 💵 [Unterstützer](#backers)
- :memo: [Lizenz](#license)

## Erste Schritte

Besuchen Sie die [Storybook-Website](https://storybook.js.org), um mehr über Storybook zu erfahren und loszulegen.

### Dokumentation

Die Dokumentation finden Sie auf der [Storybook-Dokumentationsseite](https://storybook.js.org/docs).

### Beispiele

Sehen Sie sich die [Component Encyclopedia](https://storybook.js.org/showcase) an, um zu sehen, wie führende Teams Storybook nutzen.

Nutzen Sie [storybook.new](https://storybook.new), um schnell ein Beispielprojekt in Stackblitz zu erstellen.

Storybook bietet zahlreiche [Addons](https://storybook.js.org/docs/configure/user-interface/storybook-addons) für Komponentendesign, Dokumentation, Tests, Interaktivität usw. Die Storybook-API ermöglicht eine vielseitige Konfiguration und Erweiterung. Es wurde sogar erweitert, um React Native, Android, iOS und Flutter für die Mobile-Entwicklung zu unterstützen.

### Community

Für weitere Hilfe teilen Sie Ihr Anliegen in den [GitHub Discussions des Repos](https://github.com/storybookjs/storybook/discussions/new?category=help).

## Projekte

### Unterstützte Frameworks

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

### Addons

| Addons                                                                    |                                                                            |
| ------------------------------------------------------------------------- | -------------------------------------------------------------------------- |
| [a11y](code/addons/a11y/)                                                 | Testen Sie Komponenten auf Barrierefreiheit in Storybook                   |
| [actions](code/core/src/actions/)                                         | Aktionen protokollieren, während Nutzer mit Komponenten in der Storybook-UI interagieren |
| [backgrounds](code/core/src/backgrounds)                                  | Benutzer können Hintergründe in der Storybook-UI auswählen                 |
| [cssresources](https://github.com/storybookjs/addon-cssresources)         | Dynamisches Hinzufügen/Entfernen von CSS-Ressourcen im Komponenten-Iframe  |
| [design assets](https://github.com/storybookjs/addon-design-assets)       | Bilder, Videos und Weblinks neben Ihrer Story anzeigen                     |
| [docs](code/addons/docs/)                                                 | Hochwertige Dokumentation zu Ihren Komponenten hinzufügen                  |
| [events](https://github.com/storybookjs/addon-events)                     | Interaktives Auslösen von Events für Komponenten, die auf EventEmitter reagieren |
| [google-analytics](https://github.com/storybookjs/addon-google-analytics) | Google Analytics für Stories berichten                                     |
| [graphql](https://github.com/storybookjs/addon-graphql)                   | Einen GraphQL-Server innerhalb von Storybook-Stories abfragen              |
| [jest](code/addons/jest/)                                                 | Testergebnisse von Komponenten-Unit-Tests in Storybook anzeigen            |
| [links](code/addons/links/)                                               | Verknüpfungen zwischen Stories erstellen                                   |
| [measure](code/core/src/measure/)                                         | Layout und Box-Modell visuell in der Storybook-UI inspizieren              |
| [outline](code/core/src/outline/)                                         | CSS-Layout und Ausrichtung visuell in der Storybook-UI debuggen            |
| [query params](https://github.com/storybookjs/addon-queryparams)          | Query-Parameter simulieren                                                 |
| [viewport](code/core/src/viewport/)                                       | Anzeigegrößen und Layouts für responsive Komponenten mit Storybook anpassen |

Siehe [Addon / Framework Support Table](https://storybook.js.org/docs/configure/integration/frameworks-feature-support)

Um Ihr Erlebnis weiter zu verbessern, müssen wir gelegentlich bestimmte Addons zugunsten neuer und besserer Tools veralten lassen oder entfernen.

Wenn Sie info/notes verwenden, empfehlen wir dringend, auf [docs](code/addons/docs/) umzusteigen. [Hier finden Sie eine Anleitung](code/addons/docs/docs/recipes.md#migrating-from-notesinfo-addons).

Wenn Sie contexts verwenden, empfehlen wir dringend, auf [toolbars](https://github.com/storybookjs/storybook/tree/next/code/addons/toolbars) umzusteigen. [Hier finden Sie eine Anleitung](https://github.com/storybookjs/storybook/blob/next/MIGRATION.md#deprecated-addon-contexts).

Wenn Sie addon-storyshots verwenden, empfehlen wir dringend, auf den Storybook [test-runner](https://github.com/storybookjs/test-runner) umzusteigen. [Hier finden Sie eine Anleitung](https://storybook.js.org/docs/writing-tests/storyshots-migration-guide).

## Badges & Präsentationsmaterial

Wir haben ein Badge! Verlinken Sie es mit Ihrem Live-Storybook-Beispiel.

![Storybook](https://cdn.jsdelivr.net/gh/storybookjs/brand@main/badge/badge-storybook.svg)

```md
[![Storybook](https://cdn.jsdelivr.net/gh/storybookjs/brand@main/badge/badge-storybook.svg)](Link zur Website)
```

Wenn Sie Material für Ihre Storybook-Präsentation suchen, wie Logos, Videomaterial und Farben, finden Sie alles in unserem [brand repo](https://github.com/storybookjs/brand).

## Community

- Twittern über [@storybookjs](https://x.com/storybookjs)
- Bloggen auf [storybook.js.org](https://storybook.js.org/blog/) und [Medium](https://medium.com/storybookjs)
- Chatten auf [Discord](https://discord.gg/storybook)
- Videos und Streams auf [YouTube](https://www.youtube.com/channel/UCr7Quur3eIyA_oe8FNYexfg)

## Mitwirken

Beiträge zu Storybook sind immer willkommen!

- 📥 Pull Requests und 🌟 Sterne sind immer willkommen.
- Lesen Sie unseren [Beitragsleitfaden](CONTRIBUTING.md), um loszulegen,  
  oder finden Sie uns auf [Discord](https://discord.gg/storybook), wir nehmen uns Zeit, Sie zu unterstützen.

Suchen Sie ein erstes Issue, um einzusteigen?

- Wir markieren Issues mit [![Good First Issue](https://img.shields.io/github/issues/storybookjs/storybook/good%20first%20issue.svg)](https://github.com/storybookjs/storybook/issues?q=is%3Aopen+is%3Aissue+label%3A%22good+first+issue%22), wenn sie sich gut für Neueinsteiger eignen – sowohl im Codebase als auch in Open Source allgemein.
- [Sprechen Sie uns an](https://discord.gg/storybook), wir finden etwas Passendes für Ihre Fähigkeiten und Lernziele.

### Entwicklungsskripte

Storybook ist als Monorepo organisiert. Nützliche Skripte sind:

#### `yarn start`

> Startet ein Sandbox-Template-Storybook mit Test-Stories

#### `yarn task`

> Wie oben, aber mit Optionen zur Anpassung der Sandbox (z.B. Auswahl anderer Frameworks)

#### `yarn lint`

> Prüft, ob der Code den Linting-Regeln entspricht – nutzt remark & eslint

- `yarn lint:js` – prüft JavaScript
- `yarn lint:md` – prüft Markdown + Codebeispiele
- `yarn lint:js --fix` – behebt JavaScript-Probleme automatisch

#### `yarn test`

> Prüft, ob alle Unit-Tests erfolgreich sind – nutzt jest

- `yarn run test --core --watch` – führt Core-Tests im Watch-Modus aus

### Sponsoren

Werden Sie Sponsor und Ihr Logo sowie Ihre Website-URL erscheinen in unserem README auf Github. \[[Sponsor werden](https://opencollective.com/storybook#sponsor)]

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

### Unterstützer

Mit einer regelmäßigen Spende können Sie uns und unsere Arbeit unterstützen. \[[Unterstützer werden](https://opencollective.com/storybook#backer)]

<a href="https://opencollective.com/storybook"><img src="https://opencollective.com/storybook/tiers/backers.svg?limit=80&button=false&avatarHeight=46&width=750"></a>

## Lizenz

[MIT](https://github.com/storybookjs/storybook/blob/main/LICENSE)

-ende-

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---