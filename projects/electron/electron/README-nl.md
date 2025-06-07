[![Electron Logo](https://electronjs.org/images/electron-logo.svg)](https://electronjs.org)

[![GitHub Actions Build Status](https://github.com/electron/electron/actions/workflows/build.yml/badge.svg)](https://github.com/electron/electron/actions/workflows/build.yml)
[![Electron Discord Invite](https://img.shields.io/discord/745037351163527189?color=%237289DA&label=chat&logo=discord&logoColor=white)](https://discord.gg/electronjs)

:memo: Beschikbare vertalingen: 🇨🇳 🇧🇷 🇪🇸 🇯🇵 🇷🇺 🇫🇷 🇺🇸 🇩🇪.
Bekijk deze documenten in andere talen op ons [Crowdin](https://crowdin.com/project/electron) project.

Het Electron-framework stelt je in staat om cross-platform desktopapplicaties te schrijven met JavaScript, HTML en CSS. Het is gebaseerd op [Node.js](https://nodejs.org/) en [Chromium](https://www.chromium.org) en wordt gebruikt door [Visual Studio Code](https://github.com/Microsoft/vscode/) en vele andere [apps](https://electronjs.org/apps).

Volg [@electronjs](https://twitter.com/electronjs) op Twitter voor belangrijke aankondigingen.

Dit project hanteert de Contributor Covenant [gedragscode](https://github.com/electron/electron/tree/main/CODE_OF_CONDUCT.md). Door deel te nemen, wordt van je verwacht dat je deze code naleeft. Meld onacceptabel gedrag aan [coc@electronjs.org](mailto:coc@electronjs.org).

## Installatie

Om vooraf gebouwde Electron-binaries te installeren, gebruik [`npm`](https://docs.npmjs.com/).
De aanbevolen methode is om Electron als een ontwikkelingsafhankelijkheid toe te voegen aan je app:

```sh
npm install electron --save-dev
```

Voor meer installatie-opties en tips voor probleemoplossing, zie [installatie](docs/tutorial/installation.md). Voor informatie over het beheren van Electron-versies in je apps, zie [Electron versiebeheer](docs/tutorial/electron-versioning.md).

## Platformondersteuning

Elke Electron-release levert binaries voor macOS, Windows en Linux.

* macOS (Big Sur en hoger): Electron levert 64-bit Intel- en Apple Silicon / ARM-binaries voor macOS.
* Windows (Windows 10 en hoger): Electron levert `ia32` (`x86`), `x64` (`amd64`) en `arm64` binaries voor Windows. Windows on ARM-ondersteuning is toegevoegd in Electron 5.0.8. Ondersteuning voor Windows 7, 8 en 8.1 is [verwijderd in Electron 23, in lijn met het afbouwbeleid van Chromium voor Windows](https://www.electronjs.org/blog/windows-7-to-8-1-deprecation-notice).
* Linux: De vooraf gebouwde binaries van Electron zijn gebouwd op Ubuntu 20.04. Ze zijn ook getest op:
  * Ubuntu 18.04 en nieuwer
  * Fedora 32 en nieuwer
  * Debian 10 en nieuwer

## Electron Fiddle

Gebruik [`Electron Fiddle`](https://github.com/electron/fiddle)
om kleine Electron-experimenten te bouwen, uit te voeren en te verpakken, om codevoorbeelden te zien voor alle Electron-API's, en om verschillende versies van Electron uit te proberen. Het is ontworpen om je start met Electron makkelijker te maken.

## Hulpbronnen om Electron te leren

* [electronjs.org/docs](https://electronjs.org/docs) - Alle Electron-documentatie
* [electron/fiddle](https://github.com/electron/fiddle) - Een tool om kleine Electron-experimenten te bouwen, uit te voeren en te verpakken
* [electronjs.org/community#boilerplates](https://electronjs.org/community#boilerplates) - Voorbeeld-startapps gemaakt door de community

## Programmeerbaar gebruik

De meeste mensen gebruiken Electron via de opdrachtregel, maar als je `electron` aanroept binnen je **Node-app** (niet je Electron-app) retourneert het het bestandspad naar de binary. Gebruik dit om Electron te starten vanuit Node-scripts:

```javascript
const electron = require('electron')
const proc = require('node:child_process')

// zal iets vergelijkbaars printen als /Users/maf/.../Electron
console.log(electron)

// Electron starten
const child = proc.spawn(electron)
```

### Mirrors

* [China](https://npmmirror.com/mirrors/electron/)

Zie de [Geavanceerde installatie-instructies](https://www.electronjs.org/docs/latest/tutorial/installation#mirror) om te leren hoe je een aangepaste mirror gebruikt.

## Documentatievertalingen

We crowdsourcen vertalingen voor onze documentatie via [Crowdin](https://crowdin.com/project/electron).
We accepteren momenteel vertalingen voor Vereenvoudigd Chinees, Frans, Duits, Japans, Portugees, Russisch en Spaans.

## Bijdragen

Als je geïnteresseerd bent in het rapporteren/oplossen van problemen en direct wilt bijdragen aan de codebase, zie [CONTRIBUTING.md](CONTRIBUTING.md) voor meer informatie over wat we zoeken en hoe je kunt beginnen.

## Community

Informatie over het rapporteren van bugs, hulp krijgen, het vinden van tools van derden en voorbeeld-apps, en meer is te vinden op de [Communitypagina](https://www.electronjs.org/community).

## Licentie

[MIT](https://github.com/electron/electron/blob/main/LICENSE)

Bij het gebruik van Electron-logo's, zorg ervoor dat je het [OpenJS Foundation Trademark Policy](https://trademark-policy.openjsf.org/) volgt.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---