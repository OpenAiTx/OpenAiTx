[![Electron Logo](https://electronjs.org/images/electron-logo.svg)](https://electronjs.org)

[![GitHub Actions Build Status](https://github.com/electron/electron/actions/workflows/build.yml/badge.svg)](https://github.com/electron/electron/actions/workflows/build.yml)
[![Electron Discord Invite](https://img.shields.io/discord/745037351163527189?color=%237289DA&label=chat&logo=discord&logoColor=white)](https://discord.gg/electronjs)

:memo: Verfügbare Übersetzungen: 🇨🇳 🇧🇷 🇪🇸 🇯🇵 🇷🇺 🇫🇷 🇺🇸 🇩🇪.
Siehe diese Dokumente in anderen Sprachen in unserem [Crowdin](https://crowdin.com/project/electron)-Projekt.

Das Electron-Framework ermöglicht es Ihnen, plattformübergreifende Desktop-Anwendungen mit JavaScript, HTML und CSS zu schreiben. Es basiert auf [Node.js](https://nodejs.org/) und [Chromium](https://www.chromium.org) und wird unter anderem von [Visual Studio Code](https://github.com/Microsoft/vscode/) und vielen weiteren [Apps](https://electronjs.org/apps) verwendet.

Folgen Sie [@electronjs](https://twitter.com/electronjs) auf Twitter für wichtige Ankündigungen.

Dieses Projekt hält sich an den Contributor Covenant [Verhaltenskodex](https://github.com/electron/electron/tree/main/CODE_OF_CONDUCT.md).
Durch Ihre Teilnahme wird erwartet, dass Sie diesen Kodex einhalten. Bitte melden Sie inakzeptables Verhalten an [coc@electronjs.org](mailto:coc@electronjs.org).

## Installation

Um vorgefertigte Electron-Binärdateien zu installieren, verwenden Sie [`npm`](https://docs.npmjs.com/).
Die bevorzugte Methode ist, Electron als Entwicklungsabhängigkeit in Ihrer App zu installieren:

```sh
npm install electron --save-dev
```

Weitere Installationsoptionen und Tipps zur Fehlerbehebung finden Sie unter
[Installation](docs/tutorial/installation.md). Informationen zur Verwaltung von Electron-Versionen in Ihren Apps finden Sie unter
[Electron-Versionierung](docs/tutorial/electron-versioning.md).

## Plattformunterstützung

Jede Electron-Version stellt Binärdateien für macOS, Windows und Linux bereit.

* macOS (Big Sur und neuer): Electron stellt 64-Bit-Intel- und Apple-Silicon-/ARM-Binärdateien für macOS bereit.
* Windows (Windows 10 und neuer): Electron stellt `ia32` (`x86`), `x64` (`amd64`) und `arm64`-Binärdateien für Windows bereit. Unterstützung für Windows on ARM wurde in Electron 5.0.8 hinzugefügt. Die Unterstützung für Windows 7, 8 und 8.1 wurde [in Electron 23 entfernt, im Einklang mit Chromiums Windows-Ablaufpolitik](https://www.electronjs.org/blog/windows-7-to-8-1-deprecation-notice).
* Linux: Die vorgefertigten Binärdateien von Electron werden auf Ubuntu 20.04 gebaut. Sie wurden auch erfolgreich getestet auf:
  * Ubuntu 18.04 und neuer
  * Fedora 32 und neuer
  * Debian 10 und neuer

## Electron Fiddle

Verwenden Sie [`Electron Fiddle`](https://github.com/electron/fiddle),
um kleine Electron-Experimente zu erstellen, auszuführen und zu paketieren, um Codebeispiele für alle Electron-APIs zu sehen und
verschiedene Electron-Versionen auszuprobieren. Es wurde entwickelt, um Ihnen den Einstieg in Electron zu erleichtern.

## Ressourcen zum Lernen von Electron

* [electronjs.org/docs](https://electronjs.org/docs) – Die komplette Electron-Dokumentation
* [electron/fiddle](https://github.com/electron/fiddle) – Ein Tool zum Erstellen, Ausführen und Paketieren kleiner Electron-Experimente
* [electronjs.org/community#boilerplates](https://electronjs.org/community#boilerplates) – Beispiel-Starter-Apps, die von der Community erstellt wurden

## Programmatische Nutzung

Die meisten Menschen nutzen Electron über die Kommandozeile, aber wenn Sie `electron` in Ihrer **Node-App** (nicht Ihrer Electron-App) einbinden, wird der Dateipfad zur Binärdatei zurückgegeben. Verwenden Sie dies, um Electron aus Node-Skripten heraus zu starten:

```javascript
const electron = require('electron')
const proc = require('node:child_process')

// gibt etwas Ähnliches wie /Users/maf/.../Electron aus
console.log(electron)

// Electron starten
const child = proc.spawn(electron)
```

### Mirror

* [China](https://npmmirror.com/mirrors/electron/)

Weitere Informationen zur Verwendung eines benutzerdefinierten Mirrors finden Sie in den [Erweiterten Installationsanweisungen](https://www.electronjs.org/docs/latest/tutorial/installation#mirror).

## Übersetzungen der Dokumentation

Wir crowdsourcen Übersetzungen unserer Dokumentation über [Crowdin](https://crowdin.com/project/electron).
Derzeit akzeptieren wir Übersetzungen für Chinesisch (vereinfacht), Französisch, Deutsch, Japanisch, Portugiesisch,
Russisch und Spanisch.

## Beitrag leisten

Wenn Sie daran interessiert sind, Probleme zu melden/zu beheben und direkt zum Code beizutragen, finden Sie weitere Informationen dazu, was wir suchen und wie Sie anfangen können, in [CONTRIBUTING.md](CONTRIBUTING.md).

## Community

Informationen zum Melden von Fehlern, zur Hilfesuche, zu Drittanbieter-Tools und Beispielanwendungen
und mehr finden Sie auf der [Community-Seite](https://www.electronjs.org/community).

## Lizenz

[MIT](https://github.com/electron/electron/blob/main/LICENSE)

Bei der Verwendung von Electron-Logos stellen Sie bitte sicher, dass Sie die [OpenJS Foundation Trademark Policy](https://trademark-policy.openjsf.org/) beachten.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---