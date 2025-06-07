<p align="center">
  <a href="https://getbootstrap.com/">
    <img src="https://getbootstrap.com/docs/5.3/assets/brand/bootstrap-logo-shadow.png" alt="Bootstrap logo" width="200" height="165">
  </a>
</p>

<h3 align="center">Bootstrap</h3>

<p align="center">
  Snel, intuïtief en krachtig front-end framework voor snellere en eenvoudigere webontwikkeling.
  <br>
  <a href="https://getbootstrap.com/docs/5.3/"><strong>Ontdek de Bootstrap-documentatie »</strong></a>
  <br>
  <br>
  <a href="https://github.com/twbs/bootstrap/issues/new?assignees=-&labels=bug&template=bug_report.yml">Bug melden</a>
  ·
  <a href="https://github.com/twbs/bootstrap/issues/new?assignees=&labels=feature&template=feature_request.yml">Functie aanvragen</a>
  ·
  <a href="https://themes.getbootstrap.com/">Thema’s</a>
  ·
  <a href="https://blog.getbootstrap.com/">Blog</a>
</p>


## Bootstrap 5

Onze standaardbranch is bedoeld voor de ontwikkeling van onze Bootstrap 5-release. Ga naar de [`v4-dev` branch](https://github.com/twbs/bootstrap/tree/v4-dev) om de readme, documentatie en broncode van Bootstrap 4 te bekijken.


## Inhoudsopgave

- [Snel aan de slag](#quick-start)
- [Status](#status)
- [Wat is inbegrepen](#whats-included)
- [Bugs en functieaanvragen](#bugs-and-feature-requests)
- [Documentatie](#documentation)
- [Bijdragen](#contributing)
- [Community](#community)
- [Versiebeheer](#versioning)
- [Makers](#creators)
- [Bedankt](#thanks)
- [Auteursrecht en licentie](#copyright-and-license)


## Snel aan de slag

Er zijn verschillende opties om snel aan de slag te gaan:

- [Download de laatste release](https://github.com/twbs/bootstrap/archive/v5.3.6.zip)
- Clone de repo: `git clone https://github.com/twbs/bootstrap.git`
- Installeer met [npm](https://www.npmjs.com/): `npm install bootstrap@v5.3.6`
- Installeer met [yarn](https://yarnpkg.com/): `yarn add bootstrap@v5.3.6`
- Installeer met [Bun](https://bun.sh/): `bun add bootstrap@v5.3.6`
- Installeer met [Composer](https://getcomposer.org/): `composer require twbs/bootstrap:5.3.6`
- Installeer met [NuGet](https://www.nuget.org/): CSS: `Install-Package bootstrap` Sass: `Install-Package bootstrap.sass`

Lees de [Aan de slag-pagina](https://getbootstrap.com/docs/5.3/getting-started/introduction/) voor informatie over de frameworkinhoud, sjablonen, voorbeelden en meer.


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


## Wat is inbegrepen

Binnen de download vind je de volgende mappen en bestanden, logisch gegroepeerd op gemeenschappelijke onderdelen en voorzien van zowel gecompileerde als geminimaliseerde varianten.

<details>
  <summary>Downloadinhoud</summary>

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

We leveren gecompileerde CSS en JS (`bootstrap.*`), evenals gecompileerde en geminimaliseerde CSS en JS (`bootstrap.min.*`). [Source maps](https://web.dev/articles/source-maps) (`bootstrap.*.map`) zijn beschikbaar voor gebruik met de ontwikkelaarstools van bepaalde browsers. Gebundelde JS-bestanden (`bootstrap.bundle.js` en de geminimaliseerde `bootstrap.bundle.min.js`) bevatten [Popper](https://popper.js.org/docs/v2/).


## Bugs en functieaanvragen

Heb je een bug of een functieaanvraag? Lees eerst de [richtlijnen voor issues](https://github.com/twbs/bootstrap/blob/main/.github/CONTRIBUTING.md#using-the-issue-tracker) en zoek naar bestaande en gesloten issues. Als je probleem of idee nog niet is behandeld, [open dan een nieuw issue](https://github.com/twbs/bootstrap/issues/new/choose).


## Documentatie

De documentatie van Bootstrap, opgenomen in deze repo in de hoofdmap, is gebouwd met [Astro](https://astro.build/) en publiekelijk gehost op GitHub Pages op <https://getbootstrap.com/>. De documentatie kan ook lokaal worden uitgevoerd.

Documentatiezoekopdrachten worden mogelijk gemaakt door [Algolia's DocSearch](https://docsearch.algolia.com/).

### Documentatie lokaal uitvoeren

1. Voer `npm install` uit om de Node.js-afhankelijkheden te installeren, inclusief Astro (de sitebouwer).
2. Voer `npm run test` uit (of een specifiek npm-script) om de gedistribueerde CSS- en JavaScript-bestanden, evenals onze doc-assets, opnieuw op te bouwen.
3. Voer in de hoofdmap `/bootstrap` het commando `npm run docs-serve` uit op de opdrachtregel.
4. Open `http://localhost:9001/` in je browser, en voilà.

Lees meer over het gebruik van Astro in de [documentatie](https://docs.astro.build/en/getting-started/).

### Documentatie van eerdere versies

Je kunt alle documentatie van onze eerdere releases vinden op <https://getbootstrap.com/docs/versions/>.

[Eerdere releases](https://github.com/twbs/bootstrap/releases) en hun documentatie zijn ook beschikbaar voor download.


## Bijdragen

Lees onze [bijdragingsrichtlijnen](https://github.com/twbs/bootstrap/blob/main/.github/CONTRIBUTING.md) zorgvuldig door. Hierin staan aanwijzingen voor het openen van issues, codestandaarden en opmerkingen over ontwikkeling.

Bovendien, als je pull request JavaScript-patches of -functies bevat, moet je [relevante unittests](https://github.com/twbs/bootstrap/tree/main/js/tests) toevoegen. Alle HTML en CSS moet voldoen aan de [Code Guide](https://github.com/mdo/code-guide), onderhouden door [Mark Otto](https://github.com/mdo).

Editorvoorkeuren zijn beschikbaar in de [editorconfig](https://github.com/twbs/bootstrap/blob/main/.editorconfig) voor gebruiksgemak in gangbare teksteditors. Lees meer en download plugins op <https://editorconfig.org/>.


## Community

Blijf op de hoogte van de ontwikkeling van Bootstrap en chat met de projectonderhouders en leden van de community.

- Volg [@getbootstrap op X](https://x.com/getbootstrap).
- Lees en abonneer je op [De Officiële Bootstrap Blog](https://blog.getbootstrap.com/).
- Stel vragen en verken [onze GitHub Discussions](https://github.com/twbs/bootstrap/discussions).
- Bespreek, stel vragen en meer op [de community Discord](https://discord.gg/bZUvakRU3M) of [Bootstrap subreddit](https://www.reddit.com/r/bootstrap/).
- Chat met andere Bootstrappers op IRC. Op de server `irc.libera.chat`, in het `#bootstrap` kanaal.
- Hulp bij implementatie kan gevonden worden op Stack Overflow (getagd [`bootstrap-5`](https://stackoverflow.com/questions/tagged/bootstrap-5)).
- Ontwikkelaars zouden het trefwoord `bootstrap` moeten gebruiken voor pakketten die de functionaliteit van Bootstrap aanpassen of uitbreiden bij distributie via [npm](https://www.npmjs.com/browse/keyword/bootstrap) of vergelijkbare distributiemechanismen voor maximale vindbaarheid.


## Versiebeheer

Voor transparantie in onze releasecyclus en het streven naar achterwaartse compatibiliteit, wordt Bootstrap onderhouden volgens [de Semantic Versioning-richtlijnen](https://semver.org/). Soms maken we fouten, maar we houden ons waar mogelijk aan deze regels.

Bekijk [de Releases-sectie van ons GitHub-project](https://github.com/twbs/bootstrap/releases) voor de changelogs van elke releaseversie van Bootstrap. Aankondigingsposts van releases op [de officiële Bootstrap-blog](https://blog.getbootstrap.com/) bevatten samenvattingen van de meest opmerkelijke wijzigingen in elke release.


## Makers

**Mark Otto**

- <https://x.com/mdo>
- <https://github.com/mdo>

**Jacob Thornton**

- <https://x.com/fat>
- <https://github.com/fat>


## Bedankt

<a href="https://www.browserstack.com/">
  <img src="https://live.browserstack.com/images/opensource/browserstack-logo.svg" alt="BrowserStack" width="192" height="42">
</a>

Dank aan [BrowserStack](https://www.browserstack.com/) voor het leveren van de infrastructuur waarmee we in echte browsers kunnen testen!

<a href="https://www.netlify.com/">
  <img src="https://www.netlify.com/v3/img/components/full-logo-light.svg" alt="Netlify" width="147" height="40">
</a>

Dank aan [Netlify](https://www.netlify.com/) voor het voorzien van Deploy Previews!


## Sponsors

Ondersteun dit project door sponsor te worden. Jouw logo verschijnt hier met een link naar je website. [[Word sponsor](https://opencollective.com/bootstrap#sponsor)]

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


## Backers

Dank aan al onze backers! 🙏 [[Word backer](https://opencollective.com/bootstrap#backer)]

[![Backers](https://opencollective.com/bootstrap/backers.svg?width=890)](https://opencollective.com/bootstrap#backers)


## Auteursrecht en licentie

Code en documentatie auteursrecht 2011-2025 de [Bootstrap Authors](https://github.com/twbs/bootstrap/graphs/contributors). Code vrijgegeven onder de [MIT-licentie](https://github.com/twbs/bootstrap/blob/main/LICENSE). Documentatie vrijgegeven onder [Creative Commons](https://creativecommons.org/licenses/by/3.0/).

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---