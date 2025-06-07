## Create React App [![Build & Test](https://github.com/facebook/create-react-app/actions/workflows/build-and-test.yml/badge.svg?branch=main)](https://github.com/facebook/create-react-app/actions/workflows/build-and-test.yml) [![PRs Welcome](https://img.shields.io/badge/PRs-welcome-green.svg)](https://github.com/facebook/create-react-app/blob/main/CONTRIBUTING.md)

> [!ACHTUNG]
>
> ## Veraltet
>
> Create React App war eines der wichtigsten Tools, um ein React-Projekt in den Jahren 2017–2021 schnell zum Laufen zu bringen. Es befindet sich nun im Langzeit-Stasis-Modus und wir empfehlen, auf eines der in [Ein neues React-Projekt starten](https://react.dev/learn/start-a-new-react-project) dokumentierten React-Frameworks umzusteigen.
>
> Wenn du ein Tutorial verfolgst, um React zu lernen, lohnt es sich, das Tutorial fortzusetzen, aber wir empfehlen nicht, produktive Anwendungen auf Basis von Create React App zu starten.

<img alt="Logo" align="right" src="https://create-react-app.dev/img/logo.svg" width="20%" />

Erstelle React-Apps ohne Build-Konfiguration.

- [Erstellen einer App](#creating-an-app) – Wie man eine neue App erstellt.
- [Benutzerhandbuch](https://facebook.github.io/create-react-app/) – Wie man Apps entwickelt, die mit Create React App gestartet wurden.

Create React App funktioniert auf macOS, Windows und Linux.<br>
Wenn etwas nicht funktioniert, bitte [ein Issue melden](https://github.com/facebook/create-react-app/issues/new).<br>
Wenn du Fragen hast oder Hilfe benötigst, frage in den [GitHub Discussions](https://github.com/facebook/create-react-app/discussions).

## Kurzübersicht

```sh
npx create-react-app my-app
cd my-app
npm start
```

Wenn du `create-react-app` zuvor global mit `npm install -g create-react-app` installiert hast, empfehlen wir, das Paket mit `npm uninstall -g create-react-app` oder `yarn global remove create-react-app` zu deinstallieren, um sicherzustellen, dass npx immer die neueste Version verwendet.

_([npx](https://medium.com/@maybekatz/introducing-npx-an-npm-package-runner-55f7d4bd282b) ist ab npm 5.2+ enthalten, siehe [Anleitung für ältere npm-Versionen](https://gist.github.com/gaearon/4064d3c23a77c74a3614c498a8bb1c5f))_

Anschließend öffne [http://localhost:3000/](http://localhost:3000/), um deine App zu sehen.<br>
Wenn du bereit bist, für die Produktion zu deployen, erstelle ein minimiertes Bundle mit `npm run build`.

<p align='center'>
<img src='https://cdn.jsdelivr.net/gh/facebook/create-react-app@27b42ac7efa018f2541153ab30d63180f5fa39e0/screencast.svg' width='600' alt='npm start'>
</p>

### Sofort loslegen

Du **musst** keine Tools wie webpack oder Babel installieren oder konfigurieren.<br>
Sie sind vorkonfiguriert und versteckt, sodass du dich auf den Code konzentrieren kannst.

Erstelle ein Projekt und du kannst direkt starten.

## Erstellen einer App

**Du benötigst Node 14.0.0 oder neuer auf deinem lokalen Entwicklungsrechner** (aber nicht auf dem Server erforderlich). Wir empfehlen die neueste LTS-Version. Du kannst [nvm](https://github.com/creationix/nvm#installation) (macOS/Linux) oder [nvm-windows](https://github.com/coreybutler/nvm-windows#node-version-manager-nvm-for-windows) verwenden, um zwischen Node-Versionen für verschiedene Projekte zu wechseln.

Um eine neue App zu erstellen, kannst du eine der folgenden Methoden wählen:

### npx

```sh
npx create-react-app my-app
```

_([npx](https://medium.com/@maybekatz/introducing-npx-an-npm-package-runner-55f7d4bd282b) ist ein Tool zum Ausführen von Paketen und ab npm 5.2+ enthalten, siehe [Anleitung für ältere npm-Versionen](https://gist.github.com/gaearon/4064d3c23a77c74a3614c498a8bb1c5f))_

### npm

```sh
npm init react-app my-app
```

_`npm init <initializer>` ist ab npm 6+ verfügbar_

### Yarn

```sh
yarn create react-app my-app
```

_[`yarn create <starter-kit-package>`](https://yarnpkg.com/lang/en/docs/cli/create/) ist ab Yarn 0.25+ verfügbar_

Es wird ein Verzeichnis namens `my-app` im aktuellen Ordner erstellt.<br>
Darin wird die Anfangsstruktur des Projekts generiert und die transitiven Abhängigkeiten installiert:

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

Keine Konfiguration oder komplizierte Ordnerstrukturen, nur die Dateien, die du zum Erstellen deiner App benötigst.<br>
Sobald die Installation abgeschlossen ist, kannst du deinen Projektordner öffnen:

```sh
cd my-app
```

Im neu erstellten Projekt kannst du einige integrierte Befehle ausführen:

### `npm start` oder `yarn start`

Startet die App im Entwicklungsmodus.<br>
Öffne [http://localhost:3000](http://localhost:3000) im Browser, um sie anzusehen.

Die Seite wird automatisch neu geladen, wenn du Code änderst.<br>
Build-Fehler und Lint-Warnungen werden in der Konsole angezeigt.

<p align='center'>
<img src='https://cdn.jsdelivr.net/gh/marionebl/create-react-app@9f6282671c54f0874afd37a72f6689727b562498/screencast-error.svg' width='600' alt='Build errors'>
</p>

### `npm test` oder `yarn test`

Startet den Test-Watcher im interaktiven Modus.<br>
Standardmäßig werden Tests ausgeführt, die sich auf Dateien beziehen, die seit dem letzten Commit geändert wurden.

[Mehr zum Testen lesen.](https://facebook.github.io/create-react-app/docs/running-tests)

### `npm run build` oder `yarn build`

Erstellt die App für die Produktion im `build`-Verzeichnis.<br>
React wird im Produktionsmodus gebündelt und der Build für bestmögliche Performance optimiert.

Das Build ist minifiziert und die Dateinamen enthalten Hashes.<br>

Deine App ist bereit zum Deployen.

## Benutzerhandbuch

Detaillierte Anleitungen zur Nutzung von Create React App sowie viele Tipps findest du in [der Dokumentation](https://facebook.github.io/create-react-app/).

## Wie auf neue Versionen aktualisieren?

Siehe hierzu das [Benutzerhandbuch](https://facebook.github.io/create-react-app/docs/updating-to-new-releases) für diese und weitere Informationen.

## Philosophie

- **Eine Abhängigkeit:** Es gibt nur eine Build-Abhängigkeit. Es verwendet webpack, Babel, ESLint und andere großartige Projekte, bietet aber ein stimmiges, kuratiertes Erlebnis darüber hinaus.

- **Keine Konfiguration erforderlich:** Du musst nichts konfigurieren. Eine vernünftige Konfiguration für Entwicklungs- und Produktions-Builds wird für dich übernommen, sodass du dich auf das Schreiben von Code konzentrieren kannst.

- **Kein Lock-In:** Du kannst jederzeit zu einer eigenen Konfiguration „ausbrechen“. Führe einen einzigen Befehl aus, und alle Konfigurationen und Build-Abhängigkeiten werden direkt in dein Projekt verschoben, sodass du nahtlos weitermachen kannst.

## Was ist enthalten?

Deine Umgebung enthält alles, was du zum Erstellen einer modernen Single-Page-React-App benötigst:

- Unterstützung für React, JSX, ES6, TypeScript und Flow-Syntax.
- Sprach-Extras über ES6 hinaus wie den Spread-Operator für Objekte.
- Autoprefixed CSS, damit du kein `-webkit-` oder andere Präfixe benötigst.
- Einen schnellen, interaktiven Unit-Test-Runner mit integrierter Unterstützung für Coverage-Reporting.
- Einen Live-Entwicklungsserver, der auf häufige Fehler hinweist.
- Ein Build-Skript, das JS, CSS und Bilder für die Produktion bündelt, mit Hashes und Sourcemaps.
- Ein Offline-First-[Service Worker](https://developers.google.com/web/fundamentals/getting-started/primers/service-workers) und ein [Web-App-Manifest](https://developers.google.com/web/fundamentals/engage-and-retain/web-app-manifest/), die alle [Progressive Web App](https://facebook.github.io/create-react-app/docs/making-a-progressive-web-app)-Kriterien erfüllen. (_Hinweis: Die Nutzung des Service Workers ist ab `react-scripts@2.0.0` optional_)
- Mühelose Updates für die obigen Tools mit nur einer Abhängigkeit.

Einen Überblick, wie diese Tools zusammenarbeiten, findest du in [diesem Guide](https://github.com/nitishdayal/cra_closer_look).

Der Kompromiss ist, dass **diese Tools vorkonfiguriert sind, um auf eine bestimmte Weise zu funktionieren**. Wenn dein Projekt mehr Anpassungen benötigt, kannst du ["ausbrechen"](https://facebook.github.io/create-react-app/docs/available-scripts#npm-run-eject) und es anpassen, musst dann aber die Konfiguration selbst pflegen.

## Beliebte Alternativen

Create React App eignet sich besonders für:

- **React lernen** in einer komfortablen und funktionsreichen Entwicklungsumgebung.
- **Start neuer Single-Page-React-Anwendungen.**
- **Erstellen von Beispielen** mit React für deine Bibliotheken und Komponenten.

Hier sind einige typische Fälle, in denen du etwas anderes ausprobieren solltest:

- Wenn du **React ausprobieren** möchtest, ohne hunderte transitive Build-Tool-Abhängigkeiten, nutze stattdessen [eine einzelne HTML-Datei oder eine Online-Sandbox](https://reactjs.org/docs/getting-started.html#try-react).

- Wenn du **React-Code mit einem serverseitigen Template-Framework** wie Rails, Django oder Symfony integrieren musst oder **keine Single-Page-App** baust, nutze [nwb](https://github.com/insin/nwb) oder [Neutrino](https://neutrino.js.org/), die flexibler sind. Für Rails kannst du [Rails Webpacker](https://github.com/rails/webpacker) verwenden. Für Symfony probiere [Symfonys webpack Encore](https://symfony.com/doc/current/frontend/encore/reactjs.html).

- Wenn du eine **React-Komponente veröffentlichen** möchtest, kann [nwb](https://github.com/insin/nwb) [das ebenfalls](https://github.com/insin/nwb#react-components-and-libraries), ebenso wie [Neutrinos react-components preset](https://neutrino.js.org/packages/react-components/).

- Für **Server-Rendering** mit React und Node.js, schaue dir [Next.js](https://nextjs.org/) oder [Razzle](https://github.com/jaredpalmer/razzle) an. Create React App ist backend-agnostisch und produziert nur statische HTML/JS/CSS-Bundles.

- Wenn deine Website **hauptsächlich statisch** ist (z.B. Portfolio oder Blog), nutze [Gatsby](https://www.gatsbyjs.org/) oder [Next.js](https://nextjs.org/). Im Gegensatz zu Create React App rendert Gatsby die Website bereits beim Build als HTML vor. Next.js unterstützt sowohl Server-Rendering als auch Pre-Rendering.

- Wenn du schließlich **mehr Anpassung** brauchst, sieh dir [Neutrino](https://neutrino.js.org/) und dessen [React-Preset](https://neutrino.js.org/packages/react/) an.

Alle obigen Tools funktionieren mit wenig bis gar keiner Konfiguration.

Wenn du den Build lieber selbst konfigurieren möchtest, [folge dieser Anleitung](https://reactjs.org/docs/add-react-to-a-website.html).

## React Native

Suchst du etwas Ähnliches für React Native?<br>
Sieh dir [Expo CLI](https://github.com/expo/expo-cli) an.

## Mitwirken

Wir freuen uns über jede helfende Hand bei `create-react-app`! Sieh dir [CONTRIBUTING.md](CONTRIBUTING.md) für weitere Informationen darüber an, was wir suchen und wie du starten kannst.

## Create React App unterstützen

Create React App ist ein von der Community gepflegtes Projekt, alle Mitwirkenden sind Freiwillige. Wenn du die zukünftige Entwicklung von Create React App unterstützen möchtest, erwäge bitte eine Spende an unser [Open Collective](https://opencollective.com/create-react-app).

## Danksagungen

Dieses Projekt existiert dank all der Menschen, die [beitragen](CONTRIBUTING.md).<br>
<a href="https://github.com/facebook/create-react-app/graphs/contributors"><img src="https://opencollective.com/create-react-app/contributors.svg?width=890&button=false" /></a>

Danke an [Netlify](https://www.netlify.com/) für das Hosting unserer Dokumentation.

## Anerkennungen

Wir sind den Autoren bestehender, verwandter Projekte dankbar für ihre Ideen und Zusammenarbeit:

- [@eanplatter](https://github.com/eanplatter)
- [@insin](https://github.com/insin)
- [@mxstbr](https://github.com/mxstbr)

## Lizenz

Create React App ist Open-Source-Software [lizenziert unter MIT](https://github.com/facebook/create-react-app/blob/main/LICENSE). Das Create React App-Logo ist lizenziert unter einer [Creative Commons Attribution 4.0 International-Lizenz](https://creativecommons.org/licenses/by/4.0/).

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---