[![Logo Electron](https://electronjs.org/images/electron-logo.svg)](https://electronjs.org)

[![Statut de Build GitHub Actions](https://github.com/electron/electron/actions/workflows/build.yml/badge.svg)](https://github.com/electron/electron/actions/workflows/build.yml)
[![Invitation Discord Electron](https://img.shields.io/discord/745037351163527189?color=%237289DA&label=chat&logo=discord&logoColor=white)](https://discord.gg/electronjs)

:memo: Traductions disponibles : 🇨🇳 🇧🇷 🇪🇸 🇯🇵 🇷🇺 🇫🇷 🇺🇸 🇩🇪.
Consultez ces documents dans d'autres langues sur notre projet [Crowdin](https://crowdin.com/project/electron).

Le framework Electron vous permet d’écrire des applications de bureau multiplateformes
en utilisant JavaScript, HTML et CSS. Il est basé sur [Node.js](https://nodejs.org/) et
[Chromium](https://www.chromium.org) et est utilisé par
[Visual Studio Code](https://github.com/Microsoft/vscode/) et de nombreuses autres [applications](https://electronjs.org/apps).

Suivez [@electronjs](https://twitter.com/electronjs) sur Twitter pour des annonces
importantes.

Ce projet adhère au [code de conduite](https://github.com/electron/electron/tree/main/CODE_OF_CONDUCT.md)
Contributor Covenant. En participant, vous êtes tenu de respecter ce code. Veuillez signaler tout comportement inacceptable à [coc@electronjs.org](mailto:coc@electronjs.org).

## Installation

Pour installer les binaires Electron précompilés, utilisez [`npm`](https://docs.npmjs.com/).
La méthode privilégiée consiste à installer Electron comme dépendance de développement dans votre
application :

```sh
npm install electron --save-dev
```

Pour plus d’options d’installation et des conseils de dépannage, consultez
[installation](docs/tutorial/installation.md). Pour savoir comment gérer les versions d’Electron dans vos applications, consultez
[Versionnage d’Electron](docs/tutorial/electron-versioning.md).

## Prise en charge des plateformes

Chaque version d’Electron fournit des binaires pour macOS, Windows et Linux.

* macOS (Big Sur et versions ultérieures) : Electron fournit des binaires 64 bits pour Intel et Apple Silicon / ARM pour macOS.
* Windows (Windows 10 et versions ultérieures) : Electron fournit des binaires `ia32` (`x86`), `x64` (`amd64`) et `arm64` pour Windows. La prise en charge de Windows sur ARM a été ajoutée dans Electron 5.0.8. La prise en charge de Windows 7, 8 et 8.1 a été [supprimée dans Electron 23, conformément à la politique de dépréciation de Windows par Chromium](https://www.electronjs.org/blog/windows-7-to-8-1-deprecation-notice).
* Linux : Les binaires précompilés d’Electron sont construits sur Ubuntu 20.04. Ils ont aussi été vérifiés pour fonctionner sur :
  * Ubuntu 18.04 et ultérieur
  * Fedora 32 et ultérieur
  * Debian 10 et ultérieur

## Electron Fiddle

Utilisez [`Electron Fiddle`](https://github.com/electron/fiddle)
pour créer, exécuter et empaqueter de petites expérimentations Electron, pour consulter des exemples de code de toutes les API d’Electron et
pour essayer différentes versions d’Electron. Il est conçu pour faciliter vos débuts avec
Electron.

## Ressources pour apprendre Electron

* [electronjs.org/docs](https://electronjs.org/docs) - Toute la documentation d’Electron
* [electron/fiddle](https://github.com/electron/fiddle) - Un outil pour créer, exécuter et empaqueter de petites expérimentations Electron
* [electronjs.org/community#boilerplates](https://electronjs.org/community#boilerplates) - Exemples d’applications de démarrage créées par la communauté

## Utilisation programmatique

La plupart des utilisateurs utilisent Electron via la ligne de commande, mais si vous requérez `electron` dans votre **application Node** (et non votre application Electron), cela retournera le chemin du fichier
binaire. Utilisez ceci pour lancer Electron depuis des scripts Node :

```javascript
const electron = require('electron')
const proc = require('node:child_process')

// affichera quelque chose comme /Users/maf/.../Electron
console.log(electron)

// lancer Electron
const child = proc.spawn(electron)
```

### Miroirs

* [Chine](https://npmmirror.com/mirrors/electron/)

Consultez les [Instructions d’installation avancée](https://www.electronjs.org/docs/latest/tutorial/installation#mirror) pour apprendre à utiliser un miroir personnalisé.

## Traductions de la documentation

Nous collaborons à la traduction de notre documentation via [Crowdin](https://crowdin.com/project/electron).
Nous acceptons actuellement des traductions en chinois (simplifié), français, allemand, japonais, portugais,
russe et espagnol.

## Contribuer

Si vous souhaitez signaler/corriger des problèmes et contribuer directement à la base de code, veuillez consulter [CONTRIBUTING.md](CONTRIBUTING.md) pour plus d’informations sur ce que nous recherchons et comment commencer.

## Communauté

Des informations sur le signalement de bugs, l’obtention d’aide, la recherche d’outils tiers et d’exemples d’applications,
et plus encore, sont disponibles sur la [page Communauté](https://www.electronjs.org/community).

## Licence

[MIT](https://github.com/electron/electron/blob/main/LICENSE)

Lorsque vous utilisez les logos Electron, assurez-vous de respecter la [politique de marque de l’OpenJS Foundation](https://trademark-policy.openjsf.org/).


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---