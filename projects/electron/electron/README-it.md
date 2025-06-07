[![Logo Electron](https://electronjs.org/images/electron-logo.svg)](https://electronjs.org)

[![Stato Build GitHub Actions](https://github.com/electron/electron/actions/workflows/build.yml/badge.svg)](https://github.com/electron/electron/actions/workflows/build.yml)
[![Invito Discord Electron](https://img.shields.io/discord/745037351163527189?color=%237289DA&label=chat&logo=discord&logoColor=white)](https://discord.gg/electronjs)

:memo: Traduzioni disponibili: 🇨🇳 🇧🇷 🇪🇸 🇯🇵 🇷🇺 🇫🇷 🇺🇸 🇩🇪.
Consulta questi documenti in altre lingue sul nostro progetto [Crowdin](https://crowdin.com/project/electron).

Il framework Electron consente di scrivere applicazioni desktop multipiattaforma
utilizzando JavaScript, HTML e CSS. Si basa su [Node.js](https://nodejs.org/) e
[Chromium](https://www.chromium.org) ed è utilizzato da
[Visual Studio Code](https://github.com/Microsoft/vscode/) e molte altre [applicazioni](https://electronjs.org/apps).

Segui [@electronjs](https://twitter.com/electronjs) su Twitter per annunci
importanti.

Questo progetto aderisce al Contributor Covenant
[codice di condotta](https://github.com/electron/electron/tree/main/CODE_OF_CONDUCT.md).
Partecipando, ti aspettiamo che rispetti tale codice. Segnala comportamenti inaccettabili a [coc@electronjs.org](mailto:coc@electronjs.org).

## Installazione

Per installare i binari precompilati di Electron, usa [`npm`](https://docs.npmjs.com/).
Il metodo preferito è installare Electron come dipendenza di sviluppo nella tua
app:

```sh
npm install electron --save-dev
```

Per altre opzioni di installazione e suggerimenti per la risoluzione dei problemi, consulta
[installazione](docs/tutorial/installation.md). Per informazioni su come gestire le versioni di Electron nelle tue app, consulta
[versionamento di Electron](docs/tutorial/electron-versioning.md).

## Supporto piattaforme

Ogni rilascio di Electron fornisce binari per macOS, Windows e Linux.

* macOS (da Big Sur in poi): Electron fornisce binari Intel 64-bit e Apple Silicon / ARM per macOS.
* Windows (da Windows 10 in poi): Electron fornisce binari `ia32` (`x86`), `x64` (`amd64`) e `arm64` per Windows. Il supporto a Windows on ARM è stato aggiunto in Electron 5.0.8. Il supporto per Windows 7, 8 e 8.1 è stato [rimosso in Electron 23, in linea con la politica di deprecazione di Windows di Chromium](https://www.electronjs.org/blog/windows-7-to-8-1-deprecation-notice).
* Linux: I binari precompilati di Electron sono costruiti su Ubuntu 20.04. Sono stati anche verificati su:
  * Ubuntu 18.04 e versioni successive
  * Fedora 32 e versioni successive
  * Debian 10 e versioni successive

## Electron Fiddle

Usa [`Electron Fiddle`](https://github.com/electron/fiddle)
per creare, eseguire e impacchettare piccoli esperimenti con Electron, vedere esempi di codice per tutte le API di Electron e
provare diverse versioni di Electron. È progettato per rendere più facile l'inizio del tuo percorso con
Electron.

## Risorse per imparare Electron

* [electronjs.org/docs](https://electronjs.org/docs) - Tutta la documentazione di Electron
* [electron/fiddle](https://github.com/electron/fiddle) - Uno strumento per creare, eseguire e impacchettare piccoli esperimenti con Electron
* [electronjs.org/community#boilerplates](https://electronjs.org/community#boilerplates) - App di esempio create dalla comunità per iniziare

## Uso programmatico

La maggior parte degli utenti utilizza Electron dalla linea di comando, ma se richiedi `electron` all'interno della tua **app Node** (non della tua app Electron) restituirà il percorso del file
binario. Usa questo metodo per avviare Electron da script Node:

```javascript
const electron = require('electron')
const proc = require('node:child_process')

// stamperà qualcosa di simile a /Users/maf/.../Electron
console.log(electron)

// avvia Electron
const child = proc.spawn(electron)
```

### Mirror

* [Cina](https://npmmirror.com/mirrors/electron/)

Consulta le [Istruzioni di installazione avanzata](https://www.electronjs.org/docs/latest/tutorial/installation#mirror) per sapere come utilizzare un mirror personalizzato.

## Traduzioni della documentazione

Le traduzioni della nostra documentazione sono realizzate tramite crowdsourcing su [Crowdin](https://crowdin.com/project/electron).
Attualmente accettiamo traduzioni in cinese (semplificato), francese, tedesco, giapponese, portoghese,
russo e spagnolo.

## Contribuire

Se sei interessato a segnalare/correggere problemi e contribuire direttamente al codice sorgente, consulta [CONTRIBUTING.md](CONTRIBUTING.md) per ulteriori informazioni su cosa cerchiamo e su come iniziare.

## Comunità

Informazioni su come segnalare bug, ricevere aiuto, trovare strumenti di terze parti e app di esempio,
e altro ancora sono disponibili nella [pagina della Comunità](https://www.electronjs.org/community).

## Licenza

[MIT](https://github.com/electron/electron/blob/main/LICENSE)

Quando utilizzi i loghi Electron, assicurati di seguire la [OpenJS Foundation Trademark Policy](https://trademark-policy.openjsf.org/).

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---