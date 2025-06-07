<p align="center">
  <a href="https://storybook.js.org/">
    <picture>
      <source media="(prefers-color-scheme: dark)" srcset="https://user-images.githubusercontent.com/263385/199832481-bbbf5961-6a26-481d-8224-51258cce9b33.png">
      <img src="https://user-images.githubusercontent.com/321738/63501763-88dbf600-c4cc-11e9-96cd-94adadc2fd72.png" alt="Storybook" width="400" />
    </picture>
    
  </a>
  
</p>

<p align="center">Buduj niezawodne komponenty UI szybciej</p>

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
Storybook to warsztat frontendowy do budowania komponentów UI i stron w izolacji. Tysiące zespołów używa go do rozwoju, testowania i dokumentacji interfejsów użytkownika. Dowiedz się więcej na https://storybook.js.org!
</p>

<center>
  <img src="https://raw.githubusercontent.com/storybookjs/storybook/main/media/storybook-intro.gif" width="100%" />
</center>

<p align="center">
  Zobacz README dla:<br/>
  <a href="https://github.com/storybookjs/storybook/blob/main/README.md" title="latest"><img alt="latest" src="https://img.shields.io/npm/v/@storybook/react/latest?style=for-the-badge&logo=storybook&logoColor=ffffff&color=66BF3C" /></a>
  <a href="https://github.com/storybookjs/storybook/blob/next/README.md" title="next"><img alt="next" src="https://img.shields.io/npm/v/@storybook/react/next?style=for-the-badge&logo=storybook&logoColor=ffffff&color=1EA7FD" /></a>
</p>

## Spis treści

- 🚀 [Pierwsze kroki](#getting-started)
- 📒 [Projekty](#projects)
  - 🛠 [Obsługiwane frameworki i przykłady](#supported-frameworks)
  - 🔗[Dodatki](#addons)
- 🏅 [Odznaki i materiały prezentacyjne](#badges--presentation-materials)
- 👥 [Społeczność](#community)
- 👏 [Współtworzenie](#contributing)
  - 👨‍💻 [Skrypty developerskie](#development-scripts)
  - 💸 [Sponsorzy](#sponsors)
  - 💵 [Wspierający](#backers)
- :memo: [Licencja](#license)

## Pierwsze kroki

Odwiedź [stronę Storybook](https://storybook.js.org), aby dowiedzieć się więcej o Storybooku i rozpocząć pracę.

### Dokumentacja

Dokumentację znajdziesz na [stronie dokumentacji Storybook](https://storybook.js.org/docs).

### Przykłady

Zobacz [Encyklopedię komponentów](https://storybook.js.org/showcase), aby sprawdzić, jak wiodące zespoły używają Storybooka.

Użyj [storybook.new](https://storybook.new), aby szybko stworzyć przykładowy projekt w Stackblitz.

Storybook zawiera wiele [dodatków](https://storybook.js.org/docs/configure/user-interface/storybook-addons) do projektowania komponentów, dokumentacji, testowania, interakcji itp. API Storybooka pozwala na konfigurowanie i rozszerzanie na różne sposoby. Został on nawet rozszerzony o wsparcie dla React Native, Androida, iOS i Fluttera w rozwoju mobilnym.

### Społeczność

W przypadku dodatkowej pomocy, podziel się swoim problemem w [Dyskusjach GitHub repozytorium](https://github.com/storybookjs/storybook/discussions/new?category=help).

## Projekty

### Obsługiwane frameworki

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

### Dodatki

| Dodatki                                                                    |                                                                            |
| ------------------------------------------------------------------------- | -------------------------------------------------------------------------- |
| [a11y](code/addons/a11y/)                                                 | Testuj komponenty pod kątem dostępności w Storybooku                       |
| [actions](code/core/src/actions/)                                         | Rejestruj akcje podczas interakcji użytkownika z komponentami w UI Storybooka |
| [backgrounds](code/core/src/backgrounds)                                  | Pozwala użytkownikom wybierać tła w UI Storybooka                          |
| [cssresources](https://github.com/storybookjs/addon-cssresources)         | Dynamicznie dodawaj/usuwaj zasoby CSS do iframe komponentu                 |
| [design assets](https://github.com/storybookjs/addon-design-assets)       | Przeglądaj obrazy, filmy i linki obok swojej historii                      |
| [docs](code/addons/docs/)                                                 | Dodaj wysokiej jakości dokumentację do swoich komponentów                  |
| [events](https://github.com/storybookjs/addon-events)                     | Interaktywnie wysyłaj zdarzenia do komponentów nasłuchujących EventEmitter |
| [google-analytics](https://github.com/storybookjs/addon-google-analytics) | Raportuje statystyki Google Analytics dla historii                         |
| [graphql](https://github.com/storybookjs/addon-graphql)                   | Zapytania do serwera GraphQL w ramach historii Storybooka                  |
| [jest](code/addons/jest/)                                                 | Przeglądaj wyniki testów jednostkowych komponentów w Storybooku            |
| [links](code/addons/links/)                                               | Twórz linki między historiami                                              |
| [measure](code/core/src/measure/)                                         | Wizualna inspekcja układu i modelu pudełka w UI Storybooka                 |
| [outline](code/core/src/outline/)                                         | Wizualne debugowanie układu CSS i wyrównania w UI Storybooka               |
| [query params](https://github.com/storybookjs/addon-queryparams)          | Symuluj parametry zapytania                                                |
| [viewport](code/core/src/viewport/)                                       | Zmieniaj rozmiary i układy dla responsywnych komponentów w Storybooku      |

Zobacz [Tabelę wsparcia dodatków/frameworków](https://storybook.js.org/docs/configure/integration/frameworks-feature-support)

Aby stale poprawiać doświadczenie użytkownika, z czasem musimy wycofać lub usunąć niektóre dodatki na rzecz nowych, lepszych narzędzi.

Jeśli korzystasz z info/notes, zalecamy migrację do [docs](code/addons/docs/), a [tutaj znajdziesz przewodnik](code/addons/docs/docs/recipes.md#migrating-from-notesinfo-addons).

Jeśli używasz contexts, zalecamy migrację do [toolbars](https://github.com/storybookjs/storybook/tree/next/code/addons/toolbars), a [tutaj znajdziesz przewodnik](https://github.com/storybookjs/storybook/blob/next/MIGRATION.md#deprecated-addon-contexts).

Jeśli korzystasz z addon-storyshots, zalecamy migrację do [test-runner Storybook](https://github.com/storybookjs/test-runner) i [tutaj znajdziesz przewodnik](https://storybook.js.org/docs/writing-tests/storyshots-migration-guide).

## Odznaki i materiały prezentacyjne

Mamy odznakę! Podlinkuj ją do swojego działającego przykładu Storybooka.

![Storybook](https://cdn.jsdelivr.net/gh/storybookjs/brand@main/badge/badge-storybook.svg)

```md
[![Storybook](https://cdn.jsdelivr.net/gh/storybookjs/brand@main/badge/badge-storybook.svg)](link do strony)
```

Jeśli szukasz materiałów do prezentacji Storybooka, takich jak logotypy, materiały wideo czy kolory, których używamy, znajdziesz je wszystkie w naszym [repozytorium brandingu](https://github.com/storybookjs/brand).

## Społeczność

- Tweety przez [@storybookjs](https://x.com/storybookjs)
- Blogowanie na [storybook.js.org](https://storybook.js.org/blog/) i [Medium](https://medium.com/storybookjs)
- Czat na [Discordzie](https://discord.gg/storybook)
- Filmy i streamy na [YouTube](https://www.youtube.com/channel/UCr7Quur3eIyA_oe8FNYexfg)

## Współtworzenie

Wkład w rozwój Storybooka jest zawsze mile widziany!

- 📥 Pull requesty i 🌟 gwiazdki są zawsze mile widziane.
- Przeczytaj nasz [przewodnik współtworzenia](CONTRIBUTING.md), aby zacząć,
  lub znajdź nas na [Discordzie](https://discord.gg/storybook) — chętnie Cię poprowadzimy.

Szukasz pierwszego zadania?

- Oznaczamy zadania [![Good First Issue](https://img.shields.io/github/issues/storybookjs/storybook/good%20first%20issue.svg)](https://github.com/storybookjs/storybook/issues?q=is%3Aopen+is%3Aissue+label%3A%22good+first+issue%22), gdy uważamy, że nadają się dla osób nowych w bazie kodu lub OSS ogólnie.
- [Skontaktuj się z nami](https://discord.gg/storybook), znajdziemy coś odpowiedniego do Twoich umiejętności i zainteresowań.

### Skrypty developerskie

Storybook jest zorganizowany jako monorepozytorium. Przydatne skrypty:

#### `yarn start`

> Uruchamia szablon piaskownicy Storybooka z testowymi historiami

#### `yarn task`

> Jak wyżej, ale daje opcje dostosowania piaskownicy (np. wybór innych frameworków)

#### `yarn lint`

> Sprawdza zgodność kodu z zasadami lintowania — używa remark & eslint

- `yarn lint:js` - sprawdza kod JS
- `yarn lint:md` - sprawdza markdown + przykłady kodu
- `yarn lint:js --fix` - automatycznie naprawia JS

#### `yarn test`

> Sprawdza, czy wszystkie testy jednostkowe przechodzą — używa jest

- `yarn run test --core --watch` - uruchamia testy core w trybie watch

### Sponsorzy

Zostań sponsorem, aby Twój logotyp i adres strony pojawiły się w naszym README na Githubie. \[[Zostań sponsorem](https://opencollective.com/storybook#sponsor)]

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

### Wspierający

Wspierając nas regularną darowizną, możesz pomóc nam i naszej pracy. \[[Zostań wspierającym](https://opencollective.com/storybook#backer)]

<a href="https://opencollective.com/storybook"><img src="https://opencollective.com/storybook/tiers/backers.svg?limit=80&button=false&avatarHeight=46&width=750"></a>

## Licencja

[MIT](https://github.com/storybookjs/storybook/blob/main/LICENSE)

-koniec-

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---