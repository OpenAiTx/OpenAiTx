## Vue 2 osiągnął koniec cyklu życia (End of Life)

**Przeglądasz obecnie nieaktywny repozytorium Vue 2. Aktywnie utrzymywane repozytorium najnowszej wersji Vue to [vuejs/core](https://github.com/vuejs/core).**

Vue osiągnął koniec cyklu życia 31 grudnia 2023 roku. Nie otrzymuje już nowych funkcji, aktualizacji ani poprawek. Jednak nadal jest dostępny we wszystkich istniejących kanałach dystrybucji (CDN-y, menedżery pakietów, Github itp.).

Jeśli zaczynasz nowy projekt, prosimy rozpocząć od najnowszej wersji Vue (3.x). Zdecydowanie zalecamy również obecnym użytkownikom Vue 2 przejście na nowszą wersję ([przewodnik](https://v3-migration.vuejs.org/)), jednak rozumiemy, że nie wszyscy użytkownicy mają możliwości lub motywację, by to zrobić. Jeśli musisz pozostać przy Vue 2, a jednocześnie masz wymagania dotyczące zgodności lub bezpieczeństwa związane z nieutrzymywanym oprogramowaniem, sprawdź [Vue 2 NES](https://www.herodevs.com/support/nes-vue?utm_source=vuejs-github&utm_medium=vue2-readme).

<p align="center"><a href="https://vuejs.org" target="_blank" rel="noopener noreferrer"><img width="100" src="https://vuejs.org/images/logo.png" alt="Vue logo"></a></p>

<p align="center">
  <a href="https://circleci.com/gh/vuejs/vue/tree/dev"><img src="https://img.shields.io/circleci/project/github/vuejs/vue/dev.svg?sanitize=true" alt="Build Status"></a>
  <a href="https://codecov.io/github/vuejs/vue?branch=dev"><img src="https://img.shields.io/codecov/c/github/vuejs/vue/dev.svg?sanitize=true" alt="Coverage Status"></a>
  <a href="https://npmcharts.com/compare/vue?minimal=true"><img src="https://img.shields.io/npm/dm/vue.svg?sanitize=true" alt="Downloads"></a>
  <a href="https://www.npmjs.com/package/vue"><img src="https://img.shields.io/npm/v/vue.svg?sanitize=true" alt="Version"></a>
  <a href="https://www.npmjs.com/package/vue"><img src="https://img.shields.io/npm/l/vue.svg?sanitize=true" alt="License"></a>
  <a href="https://chat.vuejs.org/"><img src="https://img.shields.io/badge/chat-on%20discord-7289da.svg?sanitize=true" alt="Chat"></a>
</p>

## Sponsorzy

Vue.js to projekt open source na licencji MIT, którego ciągły rozwój jest możliwy wyłącznie dzięki wsparciu tych niesamowitych [darczyńców](https://github.com/vuejs/core/blob/main/BACKERS.md). Jeśli chciałbyś do nich dołączyć, rozważ [wsparcie rozwoju Vue](https://vuejs.org/sponsor/).

<p align="center">
  <h3 align="center">Specjalny Sponsor</h3>
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

## Wprowadzenie

Vue (wymawiane `/vjuː/`, jak "view") to **progresywny framework** do budowania interfejsów użytkownika. Został zaprojektowany od podstaw, by można go było stopniowo wdrażać i łatwo skalować od biblioteki do frameworka w zależności od różnych przypadków użycia. Składa się z przystępnej biblioteki głównej skupionej wyłącznie na warstwie widoku oraz ekosystemu bibliotek wspierających, które pomagają radzić sobie ze złożonością w dużych aplikacjach typu Single-Page.

#### Zgodność z przeglądarkami

Vue.js obsługuje wszystkie przeglądarki [zgodne z ES5](https://compat-table.github.io/compat-table/es5/) (IE8 i starsze nie są obsługiwane).

## Ekosystem

| Projekt               | Status                                                       | Opis                                                    |
| --------------------- | ------------------------------------------------------------ | ------------------------------------------------------- |
| [vue-router]          | [![vue-router-status]][vue-router-package]                   | Routing aplikacji typu single-page                      |
| [vuex]                | [![vuex-status]][vuex-package]                               | Zarządzanie stanem na dużą skalę                        |
| [vue-cli]             | [![vue-cli-status]][vue-cli-package]                         | Tworzenie szkieletu projektu                            |
| [vue-loader]          | [![vue-loader-status]][vue-loader-package]                   | Loader komponentów pojedynczych plików (`*.vue`) dla webpacka |
| [vue-server-renderer] | [![vue-server-renderer-status]][vue-server-renderer-package] | Wsparcie renderowania po stronie serwera                |
| [vue-class-component] | [![vue-class-component-status]][vue-class-component-package] | Dekorator TypeScript dla API opartego na klasach        |
| [vue-rx]              | [![vue-rx-status]][vue-rx-package]                           | Integracja RxJS                                         |
| [vue-devtools]        | [![vue-devtools-status]][vue-devtools-package]               | Rozszerzenie DevTools dla przeglądarek                  |

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

## Dokumentacja

Aby zobaczyć [przykłady na żywo](https://v2.vuejs.org/v2/examples/) i dokumentację, odwiedź [vuejs.org](https://v2.vuejs.org).

## Pytania

W przypadku pytań i wsparcia prosimy korzystać z [oficjalnego forum](https://forum.vuejs.org) lub [czatu społeczności](https://chat.vuejs.org/). Lista zgłoszeń tego repozytorium służy **wyłącznie** do zgłaszania błędów i propozycji nowych funkcji.

## Zgłoszenia błędów

Przed otwarciem zgłoszenia koniecznie zapoznaj się z [Checklistą zgłoszeń błędów](https://github.com/vuejs/vue/blob/dev/.github/CONTRIBUTING.md#issue-reporting-guidelines). Zgłoszenia niezgodne z tymi wytycznymi mogą zostać natychmiast zamknięte.

## Dziennik zmian

Szczegółowe zmiany dla każdego wydania są dokumentowane w [informacjach o wydaniach](https://github.com/vuejs/vue/releases).

## Bądź na bieżąco

- [Twitter](https://twitter.com/vuejs)
- [Blog](https://medium.com/the-vue-point)
- [Oferty pracy](https://vuejobs.com/?ref=vuejs)

## Współtworzenie

Przed przesłaniem pull requesta zapoznaj się z [przewodnikiem dla współtwórców](https://github.com/vuejs/vue/blob/dev/.github/CONTRIBUTING.md). Jeśli masz projekt/komponent/narzędzie związane z Vue, dodaj je za pomocą pull requesta do [tej listy](https://github.com/vuejs/awesome-vue)!

Dziękujemy wszystkim, którzy już przyczynili się do rozwoju Vue!

<a href="https://github.com/vuejs/vue/graphs/contributors"><img src="https://opencollective.com/vuejs/contributors.svg?width=890" /></a>

## Licencja

[MIT](https://opensource.org/licenses/MIT)

Copyright (c) 2013-obecnie, Yuxi (Evan) You

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---