## Create React App [![Build & Test](https://github.com/facebook/create-react-app/actions/workflows/build-and-test.yml/badge.svg?branch=main)](https://github.com/facebook/create-react-app/actions/workflows/build-and-test.yml) [![PRs Welcome](https://img.shields.io/badge/PRs-welcome-green.svg)](https://github.com/facebook/create-react-app/blob/main/CONTRIBUTING.md)

> [!WAARSCHUWING]
>
> ## Verouderd
>
> Create React App was een van de belangrijkste tools om een React-project op te starten in 2017-2021, maar bevindt zich nu in langdurige stasis en we raden aan om te migreren naar een van de React-frameworks die worden beschreven op [Start een nieuw React-project](https://react.dev/learn/start-a-new-react-project).
>
> Als je een tutorial volgt om React te leren, is het nog steeds waardevol om de tutorial af te maken, maar we raden niet aan om productie-apps te starten op basis van Create React App.

<img alt="Logo" align="right" src="https://create-react-app.dev/img/logo.svg" width="20%" />

Maak React-apps zonder buildconfiguratie.

- [Een app maken](#creating-an-app) – Hoe maak je een nieuwe app.
- [Gebruikershandleiding](https://facebook.github.io/create-react-app/) – Hoe ontwikkel je apps die zijn opgestart met Create React App.

Create React App werkt op macOS, Windows en Linux.<br>
Als iets niet werkt, [maak dan een issue aan](https://github.com/facebook/create-react-app/issues/new).<br>
Als je vragen hebt of hulp nodig hebt, stel die dan in [GitHub Discussions](https://github.com/facebook/create-react-app/discussions).

## Snel Overzicht

```sh
npx create-react-app my-app
cd my-app
npm start
```

Als je eerder `create-react-app` wereldwijd hebt geïnstalleerd via `npm install -g create-react-app`, raden we aan het pakket te verwijderen met `npm uninstall -g create-react-app` of `yarn global remove create-react-app` zodat npx altijd de nieuwste versie gebruikt.

_([npx](https://medium.com/@maybekatz/introducing-npx-an-npm-package-runner-55f7d4bd282b) wordt meegeleverd met npm 5.2+ en hoger, zie [instructies voor oudere npm-versies](https://gist.github.com/gaearon/4064d3c23a77c74a3614c498a8bb1c5f))_

Open vervolgens [http://localhost:3000/](http://localhost:3000/) om je app te bekijken.<br>
Wanneer je klaar bent om naar productie te gaan, maak je een geminificeerde bundel met `npm run build`.

<p align='center'>
<img src='https://cdn.jsdelivr.net/gh/facebook/create-react-app@27b42ac7efa018f2541153ab30d63180f5fa39e0/screencast.svg' width='600' alt='npm start'>
</p>

### Meteen Beginnen

Je hoeft **geen** tools als webpack of Babel te installeren of te configureren.<br>
Ze zijn vooraf geconfigureerd en verborgen, zodat jij je op de code kunt richten.

Maak een project aan en je kunt direct aan de slag.

## Een App Maken

**Je hebt Node 14.0.0 of hoger nodig op je lokale ontwikkelmachine** (maar het is niet vereist op de server). We raden aan de nieuwste LTS-versie te gebruiken. Je kunt [nvm](https://github.com/creationix/nvm#installation) (macOS/Linux) of [nvm-windows](https://github.com/coreybutler/nvm-windows#node-version-manager-nvm-for-windows) gebruiken om tussen Node-versies te wisselen voor verschillende projecten.

Om een nieuwe app te maken, kun je een van de volgende methoden kiezen:

### npx

```sh
npx create-react-app my-app
```

_([npx](https://medium.com/@maybekatz/introducing-npx-an-npm-package-runner-55f7d4bd282b) is een pakketrunner die wordt meegeleverd met npm 5.2+ en hoger, zie [instructies voor oudere npm-versies](https://gist.github.com/gaearon/4064d3c23a77c74a3614c498a8bb1c5f))_

### npm

```sh
npm init react-app my-app
```

_`npm init <initializer>` is beschikbaar in npm 6+_

### Yarn

```sh
yarn create react-app my-app
```

_[`yarn create <starter-kit-package>`](https://yarnpkg.com/lang/en/docs/cli/create/) is beschikbaar vanaf Yarn 0.25+_

Dit maakt een map genaamd `my-app` aan in de huidige map.<br>
In die map genereert het de initiële projectstructuur en installeert het de transitieve afhankelijkheden:

```
my-app
├── README.md
├── node_modules
├── package.json
├── .gitignore
├── public
│   ├── favicon.ico
│   ├── index.html
│   └── manifest.json
└── src
    ├── App.css
    ├── App.js
    ├── App.test.js
    ├── index.css
    ├── index.js
    ├── logo.svg
    └── serviceWorker.js
    └── setupTests.js
```

Geen configuratie of ingewikkelde mappenstructuren, alleen de bestanden die je nodig hebt om je app te bouwen.<br>
Als de installatie klaar is, kun je je projectmap openen:

```sh
cd my-app
```

Binnen het nieuw aangemaakte project kun je een aantal ingebouwde commando's uitvoeren:

### `npm start` of `yarn start`

Start de app in ontwikkelmodus.<br>
Open [http://localhost:3000](http://localhost:3000) om deze in de browser te bekijken.

De pagina laadt automatisch opnieuw als je wijzigingen aanbrengt in de code.<br>
Je ziet de buildfouten en lintwaarschuwingen in de console.

<p align='center'>
<img src='https://cdn.jsdelivr.net/gh/marionebl/create-react-app@9f6282671c54f0874afd37a72f6689727b562498/screencast-error.svg' width='600' alt='Build errors'>
</p>

### `npm test` of `yarn test`

Start de test watcher in interactieve modus.<br>
Standaard worden tests uitgevoerd die betrekking hebben op bestanden die sinds de laatste commit zijn gewijzigd.

[Lees meer over testen.](https://facebook.github.io/create-react-app/docs/running-tests)

### `npm run build` of `yarn build`

Bouwt de app voor productie in de map `build`.<br>
React wordt correct gebundeld in productie-modus en de build wordt geoptimaliseerd voor de beste prestaties.

De build wordt geminificeerd en de bestandsnamen bevatten hashes.<br>

Je app is klaar om te worden gedeployed.

## Gebruikershandleiding

Je vindt gedetailleerde instructies over het gebruik van Create React App en veel tips in [de documentatie](https://facebook.github.io/create-react-app/).

## Hoe Update je naar Nieuwe Versies?

Raadpleeg de [Gebruikershandleiding](https://facebook.github.io/create-react-app/docs/updating-to-new-releases) voor deze en andere informatie.

## Filosofie

- **Eén afhankelijkheid:** Er is maar één build-afhankelijkheid. Het gebruikt webpack, Babel, ESLint en andere geweldige projecten, maar biedt een samenhangende ervaring daar bovenop.

- **Geen configuratie vereist:** Je hoeft niets te configureren. Een redelijk goede configuratie voor zowel ontwikkel- als productie-builds is voor je geregeld, zodat jij je op het schrijven van code kunt richten.

- **Geen lock-in:** Je kunt op elk moment “ejecten” naar een aangepaste setup. Voer één commando uit en alle configuratie- en build-afhankelijkheden worden direct in je project geplaatst, zodat je precies verder kunt waar je was gebleven.

## Wat is Inbegrepen?

Je omgeving bevat alles wat je nodig hebt om een moderne single-page React-app te bouwen:

- Ondersteuning voor React, JSX, ES6, TypeScript en Flow-syntax.
- Taaluitbreidingen buiten ES6, zoals de object spread operator.
- Autoprefixed CSS, zodat je geen `-webkit-` of andere voorvoegsels nodig hebt.
- Een snelle interactieve unit testrunner met ingebouwde ondersteuning voor dekkingrapportage.
- Een live ontwikkelserver die waarschuwt voor veelvoorkomende fouten.
- Een buildscript dat JS, CSS en afbeeldingen bundelt voor productie, met hashes en sourcemaps.
- Een offline-first [service worker](https://developers.google.com/web/fundamentals/getting-started/primers/service-workers) en een [webapp manifest](https://developers.google.com/web/fundamentals/engage-and-retain/web-app-manifest/), die voldoen aan alle [Progressive Web App](https://facebook.github.io/create-react-app/docs/making-a-progressive-web-app) criteria. (_Let op: het gebruik van de service worker is opt-in sinds `react-scripts@2.0.0` en hoger_)
- Probleemloze updates voor bovenstaande tools met één afhankelijkheid.

Bekijk [deze gids](https://github.com/nitishdayal/cra_closer_look) voor een overzicht van hoe deze tools samenwerken.

Het compromis is dat **deze tools vooraf geconfigureerd zijn om op een specifieke manier te werken**. Als je project meer maatwerk vereist, kun je ["ejecten"](https://facebook.github.io/create-react-app/docs/available-scripts#npm-run-eject) en het aanpassen, maar dan moet je deze configuratie zelf onderhouden.

## Populaire Alternatieven

Create React App is uitermate geschikt voor:

- **React leren** in een comfortabele en uitgebreide ontwikkelomgeving.
- **Nieuwe single-page React-applicaties starten.**
- **Voorbeelden maken** met React voor je libraries en componenten.

Hier zijn een paar veelvoorkomende gevallen waarin je misschien iets anders wilt proberen:

- Wil je **React uitproberen** zonder honderden transitieve build-tool-afhankelijkheden, overweeg dan [een enkel HTML-bestand of een online sandbox te gebruiken](https://reactjs.org/docs/getting-started.html#try-react).

- Als je **React-code wilt integreren met een server-side template framework** zoals Rails, Django of Symfony, of als je **geen single-page app bouwt**, overweeg dan [nwb](https://github.com/insin/nwb) of [Neutrino](https://neutrino.js.org/) die flexibeler zijn. Voor Rails kun je specifiek [Rails Webpacker](https://github.com/rails/webpacker) gebruiken. Voor Symfony probeer [Symfony's webpack Encore](https://symfony.com/doc/current/frontend/encore/reactjs.html).

- Als je een **React-component wilt publiceren**, kan [nwb](https://github.com/insin/nwb) [dit ook doen](https://github.com/insin/nwb#react-components-and-libraries), evenals [Neutrino's react-components preset](https://neutrino.js.org/packages/react-components/).

- Wil je **server rendering** doen met React en Node.js, kijk dan naar [Next.js](https://nextjs.org/) of [Razzle](https://github.com/jaredpalmer/razzle). Create React App is backend-agnostisch en produceert alleen statische HTML/JS/CSS-bundels.

- Als je website **voornamelijk statisch** is (bijvoorbeeld een portfolio of blog), overweeg dan [Gatsby](https://www.gatsbyjs.org/) of [Next.js](https://nextjs.org/). In tegenstelling tot Create React App, pre-rendert Gatsby de website naar HTML tijdens het bouwen. Next.js ondersteunt zowel server rendering als pre-rendering.

- Ten slotte, als je **meer maatwerk** nodig hebt, kijk dan naar [Neutrino](https://neutrino.js.org/) en de [React preset](https://neutrino.js.org/packages/react/).

Al deze tools werken met weinig tot geen configuratie.

Wil je de build liever zelf configureren, [volg dan deze gids](https://reactjs.org/docs/add-react-to-a-website.html).

## React Native

Op zoek naar iets soortgelijks, maar dan voor React Native?<br>
Bekijk [Expo CLI](https://github.com/expo/expo-cli).

## Bijdragen

We ontvangen graag jouw hulp bij `create-react-app`! Zie [CONTRIBUTING.md](CONTRIBUTING.md) voor meer informatie over waar we naar op zoek zijn en hoe je kunt beginnen.

## Create React App ondersteunen

Create React App is een door de gemeenschap onderhouden project en alle bijdragers zijn vrijwilligers. Als je de toekomstige ontwikkeling van Create React App wilt ondersteunen, overweeg dan te doneren aan onze [Open Collective](https://opencollective.com/create-react-app).

## Dankbetuigingen

Dit project bestaat dankzij alle mensen die [bijdragen](CONTRIBUTING.md).<br>
<a href="https://github.com/facebook/create-react-app/graphs/contributors"><img src="https://opencollective.com/create-react-app/contributors.svg?width=890&button=false" /></a>

Dank aan [Netlify](https://www.netlify.com/) voor het hosten van onze documentatie.

## Erkenningen

We zijn dankbaar voor de auteurs van bestaande gerelateerde projecten voor hun ideeën en samenwerking:

- [@eanplatter](https://github.com/eanplatter)
- [@insin](https://github.com/insin)
- [@mxstbr](https://github.com/mxstbr)

## Licentie

Create React App is open source software [gelicentieerd als MIT](https://github.com/facebook/create-react-app/blob/main/LICENSE). Het Create React App-logo is gelicentieerd onder een [Creative Commons Attribution 4.0 International license](https://creativecommons.org/licenses/by/4.0/).

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---