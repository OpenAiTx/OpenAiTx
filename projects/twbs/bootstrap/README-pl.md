<p align="center">
  <a href="https://getbootstrap.com/">
    <img src="https://getbootstrap.com/docs/5.3/assets/brand/bootstrap-logo-shadow.png" alt="Bootstrap logo" width="200" height="165">
  </a>
</p>

<h3 align="center">Bootstrap</h3>

<p align="center">
  Elegancki, intuicyjny i potężny framework front-endowy do szybszego i łatwiejszego tworzenia stron internetowych.
  <br>
  <a href="https://getbootstrap.com/docs/5.3/"><strong>Poznaj dokumentację Bootstrap »</strong></a>
  <br>
  <br>
  <a href="https://github.com/twbs/bootstrap/issues/new?assignees=-&labels=bug&template=bug_report.yml">Zgłoś błąd</a>
  ·
  <a href="https://github.com/twbs/bootstrap/issues/new?assignees=&labels=feature&template=feature_request.yml">Zaproponuj funkcję</a>
  ·
  <a href="https://themes.getbootstrap.com/">Motywy</a>
  ·
  <a href="https://blog.getbootstrap.com/">Blog</a>
</p>


## Bootstrap 5

Nasza domyślna gałąź (branch) służy do rozwoju wersji Bootstrap 5. Przejdź do gałęzi [`v4-dev`](https://github.com/twbs/bootstrap/tree/v4-dev), aby zobaczyć plik readme, dokumentację i kod źródłowy Bootstrap 4.


## Spis treści

- [Szybki start](#szybki-start)
- [Status](#status)
- [Co zawiera paczka](#co-zawiera-paczka)
- [Błędy i propozycje funkcji](#błędy-i-propozycje-funkcji)
- [Dokumentacja](#dokumentacja)
- [Współtworzenie](#współtworzenie)
- [Społeczność](#społeczność)
- [Wersjonowanie](#wersjonowanie)
- [Twórcy](#twórcy)
- [Podziękowania](#podziękowania)
- [Prawa autorskie i licencja](#prawa-autorskie-i-licencja)


## Szybki start

Dostępnych jest kilka opcji szybkiego startu:

- [Pobierz najnowszą wersję](https://github.com/twbs/bootstrap/archive/v5.3.6.zip)
- Sklonuj repozytorium: `git clone https://github.com/twbs/bootstrap.git`
- Zainstaluj przez [npm](https://www.npmjs.com/): `npm install bootstrap@v5.3.6`
- Zainstaluj przez [yarn](https://yarnpkg.com/): `yarn add bootstrap@v5.3.6`
- Zainstaluj przez [Bun](https://bun.sh/): `bun add bootstrap@v5.3.6`
- Zainstaluj przez [Composer](https://getcomposer.org/): `composer require twbs/bootstrap:5.3.6`
- Zainstaluj przez [NuGet](https://www.nuget.org/): CSS: `Install-Package bootstrap` Sass: `Install-Package bootstrap.sass`

Przeczytaj stronę [Pierwsze kroki](https://getbootstrap.com/docs/5.3/getting-started/introduction/), aby uzyskać informacje o zawartości frameworka, szablonach, przykładach i nie tylko.


## Status

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


## Co zawiera paczka

W pobranej paczce znajdziesz następujące katalogi i pliki, logicznie pogrupowane zasoby oraz zarówno skompilowane, jak i zminifikowane warianty.

<details>
  <summary>Zawartość paczki</summary>

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

Dostarczamy skompilowane CSS i JS (`bootstrap.*`), a także skompilowane i zminifikowane CSS oraz JS (`bootstrap.min.*`). [Mapy źródłowe](https://web.dev/articles/source-maps) (`bootstrap.*.map`) są dostępne do wykorzystania z narzędziami deweloperskimi niektórych przeglądarek. Dołączone pliki JS (`bootstrap.bundle.js` i zminifikowany `bootstrap.bundle.min.js`) zawierają [Popper](https://popper.js.org/docs/v2/).


## Błędy i propozycje funkcji

Masz błąd lub propozycję funkcji? Najpierw przeczytaj [wytyczne zgłaszania problemów](https://github.com/twbs/bootstrap/blob/main/.github/CONTRIBUTING.md#using-the-issue-tracker) i wyszukaj istniejące lub zamknięte zgłoszenia. Jeśli Twój problem lub pomysł nie został jeszcze poruszony, [otwórz nowe zgłoszenie](https://github.com/twbs/bootstrap/issues/new/choose).


## Dokumentacja

Dokumentacja Bootstrap, zawarta w tym repozytorium w katalogu głównym, jest budowana za pomocą [Astro](https://astro.build/) i publicznie hostowana na GitHub Pages pod adresem <https://getbootstrap.com/>. Dokumentację można również uruchomić lokalnie.

Wyszukiwanie w dokumentacji jest wspierane przez [DocSearch firmy Algolia](https://docsearch.algolia.com/).

### Uruchamianie dokumentacji lokalnie

1. Uruchom `npm install`, aby zainstalować zależności Node.js, w tym Astro (generator strony).
2. Uruchom `npm run test` (lub konkretny skrypt npm), aby odbudować dystrybuowane pliki CSS i JavaScript oraz zasoby dokumentacji.
3. Z katalogu głównego `/bootstrap` uruchom w terminalu `npm run docs-serve`.
4. Otwórz `http://localhost:9001/` w przeglądarce i gotowe.

Dowiedz się więcej o korzystaniu z Astro, czytając jego [dokumentację](https://docs.astro.build/en/getting-started/).

### Dokumentacja dla poprzednich wersji

Wszystkie poprzednie wersje dokumentacji znajdziesz na <https://getbootstrap.com/docs/versions/>.

[Poprzednie wydania](https://github.com/twbs/bootstrap/releases) oraz ich dokumentacja są również dostępne do pobrania.


## Współtworzenie

Przeczytaj nasze [wytyczne dla współtwórców](https://github.com/twbs/bootstrap/blob/main/.github/CONTRIBUTING.md). Znajdziesz tam instrukcje dotyczące zgłaszania problemów, standardów kodowania oraz uwagi dotyczące rozwoju.

Jeśli Twój pull request zawiera poprawki lub funkcje w JavaScript, musisz dołączyć [odpowiednie testy jednostkowe](https://github.com/twbs/bootstrap/tree/main/js/tests). Cały kod HTML i CSS powinien być zgodny z [Code Guide](https://github.com/mdo/code-guide), utrzymywanym przez [Marka Otto](https://github.com/mdo).

Preferencje edytora są dostępne w pliku [editor config](https://github.com/twbs/bootstrap/blob/main/.editorconfig) do łatwego wykorzystania w popularnych edytorach tekstowych. Przeczytaj więcej i pobierz wtyczki na <https://editorconfig.org/>.


## Społeczność

Otrzymuj aktualizacje dotyczące rozwoju Bootstrap oraz rozmawiaj z opiekunami projektu i członkami społeczności.

- Obserwuj [@getbootstrap na X](https://x.com/getbootstrap).
- Czytaj i subskrybuj [Oficjalny Blog Bootstrap](https://blog.getbootstrap.com/).
- Zadawaj pytania i przeglądaj [nasze dyskusje GitHub](https://github.com/twbs/bootstrap/discussions).
- Dyskutuj, zadawaj pytania i więcej na [społecznościowym Discordzie](https://discord.gg/bZUvakRU3M) lub [subreddicie Bootstrap](https://www.reddit.com/r/bootstrap/).
- Rozmawiaj z innymi użytkownikami Bootstrap na IRC. Na serwerze `irc.libera.chat`, w kanale `#bootstrap`.
- Pomoc w implementacji znajdziesz na Stack Overflow (tag [`bootstrap-5`](https://stackoverflow.com/questions/tagged/bootstrap-5)).
- Programiści powinni używać słowa kluczowego `bootstrap` w paczkach, które modyfikują lub rozszerzają funkcjonalność Bootstrap przy dystrybucji przez [npm](https://www.npmjs.com/browse/keyword/bootstrap) lub podobne mechanizmy, aby zapewnić maksymalną wykrywalność.


## Wersjonowanie

W trosce o przejrzystość cyklu wydawniczego oraz dążenie do zachowania kompatybilności wstecznej, Bootstrap jest utrzymywany zgodnie z [wytycznymi Semantic Versioning](https://semver.org/). Czasem popełniamy błędy, ale stosujemy się do tych zasad, kiedy tylko to możliwe.

Zobacz [sekcję Releases w naszym projekcie GitHub](https://github.com/twbs/bootstrap/releases) po changelogi dla każdej wersji Bootstrap. Wpisy ogłaszające wydania na [oficjalnym blogu Bootstrap](https://blog.getbootstrap.com/) zawierają podsumowania najważniejszych zmian w każdej wersji.


## Twórcy

**Mark Otto**

- <https://x.com/mdo>
- <https://github.com/mdo>

**Jacob Thornton**

- <https://x.com/fat>
- <https://github.com/fat>


## Podziękowania

<a href="https://www.browserstack.com/">
  <img src="https://live.browserstack.com/images/opensource/browserstack-logo.svg" alt="BrowserStack" width="192" height="42">
</a>

Podziękowania dla [BrowserStack](https://www.browserstack.com/) za udostępnienie infrastruktury umożliwiającej testowanie w prawdziwych przeglądarkach!

<a href="https://www.netlify.com/">
  <img src="https://www.netlify.com/v3/img/components/full-logo-light.svg" alt="Netlify" width="147" height="40">
</a>

Podziękowania dla [Netlify](https://www.netlify.com/) za zapewnienie nam Deploy Previews!


## Sponsorzy

Wesprzyj ten projekt, zostając sponsorem. Twoje logo pojawi się tutaj z odnośnikiem do Twojej strony internetowej. [[Zostań sponsorem](https://opencollective.com/bootstrap#sponsor)]

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


## Wspierający

Dziękujemy wszystkim naszym wspierającym! 🙏 [[Zostań wspierającym](https://opencollective.com/bootstrap#backer)]

[![Backers](https://opencollective.com/bootstrap/backers.svg?width=890)](https://opencollective.com/bootstrap#backers)


## Prawa autorskie i licencja

Kod i dokumentacja objęte prawem autorskim 2011-2025 [Autorzy Bootstrap](https://github.com/twbs/bootstrap/graphs/contributors). Kod udostępniany na [Licencji MIT](https://github.com/twbs/bootstrap/blob/main/LICENSE). Dokumentacja udostępniana na licencji [Creative Commons](https://creativecommons.org/licenses/by/3.0/).

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---