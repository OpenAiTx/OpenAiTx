## Create React App [![Build & Test](https://github.com/facebook/create-react-app/actions/workflows/build-and-test.yml/badge.svg?branch=main)](https://github.com/facebook/create-react-app/actions/workflows/build-and-test.yml) [![PRs Welcome](https://img.shields.io/badge/PRs-welcome-green.svg)](https://github.com/facebook/create-react-app/blob/main/CONTRIBUTING.md)

> [!CAUTION]
>
> ## Deprecato
>
> Create React App è stato uno degli strumenti chiave per avviare un progetto React tra il 2017 e il 2021; ora è in stato di stasi a lungo termine e ti consigliamo di migrare a uno dei framework React documentati in [Avvia un Nuovo Progetto React](https://react.dev/learn/start-a-new-react-project).
>
> Se stai seguendo un tutorial per imparare React, ha comunque senso continuare il tutorial, ma non raccomandiamo di iniziare applicazioni in produzione basate su Create React App.

<img alt="Logo" align="right" src="https://create-react-app.dev/img/logo.svg" width="20%" />

Crea app React senza configurazione di build.

- [Creazione di un'App](#creating-an-app) – Come creare una nuova app.
- [Guida Utente](https://facebook.github.io/create-react-app/) – Come sviluppare app bootstrap con Create React App.

Create React App funziona su macOS, Windows e Linux.<br>
Se qualcosa non funziona, ti preghiamo di [segnalare un problema](https://github.com/facebook/create-react-app/issues/new).<br>
Se hai domande o hai bisogno di aiuto, chiedi nelle [GitHub Discussions](https://github.com/facebook/create-react-app/discussions).

## Panoramica Rapida

```sh
npx create-react-app my-app
cd my-app
npm start
```

Se hai precedentemente installato `create-react-app` globalmente tramite `npm install -g create-react-app`, ti consigliamo di disinstallare il pacchetto usando `npm uninstall -g create-react-app` o `yarn global remove create-react-app` per assicurarti che npx usi sempre l'ultima versione.

_([npx](https://medium.com/@maybekatz/introducing-npx-an-npm-package-runner-55f7d4bd282b) è incluso in npm 5.2+ e versioni successive, vedi [istruzioni per versioni npm più vecchie](https://gist.github.com/gaearon/4064d3c23a77c74a3614c498a8bb1c5f))_

Poi apri [http://localhost:3000/](http://localhost:3000/) per vedere la tua app.<br>
Quando sei pronto per il deploy in produzione, crea un bundle minificato con `npm run build`.

<p align='center'>
<img src='https://cdn.jsdelivr.net/gh/facebook/create-react-app@27b42ac7efa018f2541153ab30d63180f5fa39e0/screencast.svg' width='600' alt='npm start'>
</p>

### Inizia Subito

Non **devi** installare o configurare strumenti come webpack o Babel.<br>
Sono preconfigurati e nascosti così puoi concentrarti solo sul codice.

Crea un progetto, e sei pronto a partire.

## Creazione di un'App

**Dovrai avere Node 14.0.0 o versione successiva sulla tua macchina di sviluppo locale** (ma non è richiesto sul server). Raccomandiamo di usare l'ultima versione LTS. Puoi usare [nvm](https://github.com/creationix/nvm#installation) (macOS/Linux) o [nvm-windows](https://github.com/coreybutler/nvm-windows#node-version-manager-nvm-for-windows) per cambiare versione di Node tra diversi progetti.

Per creare una nuova app, puoi scegliere uno dei seguenti metodi:

### npx

```sh
npx create-react-app my-app
```

_([npx](https://medium.com/@maybekatz/introducing-npx-an-npm-package-runner-55f7d4bd282b) è uno strumento runner di pacchetti incluso in npm 5.2+ e versioni successive, vedi [istruzioni per versioni npm più vecchie](https://gist.github.com/gaearon/4064d3c23a77c74a3614c498a8bb1c5f))_

### npm

```sh
npm init react-app my-app
```

_`npm init <initializer>` è disponibile in npm 6+_

### Yarn

```sh
yarn create react-app my-app
```

_[`yarn create <starter-kit-package>`](https://yarnpkg.com/lang/en/docs/cli/create/) è disponibile in Yarn 0.25+_

Verrà creata una cartella chiamata `my-app` all'interno della cartella corrente.<br>
All'interno di quella cartella, verrà generata la struttura iniziale del progetto e installate le dipendenze transitive:

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

Nessuna configurazione o strutture di cartelle complicate, solo i file necessari per costruire la tua app.<br>
Una volta terminata l’installazione, puoi aprire la cartella del tuo progetto:

```sh
cd my-app
```

All'interno del progetto appena creato, puoi eseguire alcuni comandi integrati:

### `npm start` o `yarn start`

Avvia l'app in modalità sviluppo.<br>
Apri [http://localhost:3000](http://localhost:3000) per visualizzarla nel browser.

La pagina si ricaricherà automaticamente se apporti modifiche al codice.<br>
Vedrai gli errori di build e gli avvisi di lint nella console.

<p align='center'>
<img src='https://cdn.jsdelivr.net/gh/marionebl/create-react-app@9f6282671c54f0874afd37a72f6689727b562498/screencast-error.svg' width='600' alt='Build errors'>
</p>

### `npm test` o `yarn test`

Esegue il watcher dei test in modalità interattiva.<br>
Per impostazione predefinita, esegue i test relativi ai file modificati dall'ultimo commit.

[Leggi di più sui test.](https://facebook.github.io/create-react-app/docs/running-tests)

### `npm run build` o `yarn build`

Costruisce l'app per la produzione nella cartella `build`.<br>
Esegue il bundle di React in modalità produzione e ottimizza la build per ottenere le migliori prestazioni.

La build è minificata e i nomi dei file includono hash.<br>

La tua app è pronta per essere distribuita.

## Guida Utente

Puoi trovare istruzioni dettagliate su come usare Create React App e molti suggerimenti nella [sua documentazione](https://facebook.github.io/create-react-app/).

## Come Aggiornare alle Nuove Versioni?

Fai riferimento alla [Guida Utente](https://facebook.github.io/create-react-app/docs/updating-to-new-releases) per questa e altre informazioni.

## Filosofia

- **Una Dipendenza:** C'è solo una dipendenza di build. Usa webpack, Babel, ESLint e altri progetti straordinari, ma offre un'esperienza curata e coesa sopra di essi.

- **Nessuna Configurazione Richiesta:** Non devi configurare nulla. Una configurazione ragionevole sia per le build di sviluppo che di produzione viene gestita per te, così puoi concentrarti sulla scrittura del codice.

- **Nessun Vincolo:** Puoi “esportare” su una configurazione personalizzata in qualsiasi momento. Esegui un solo comando, e tutte le configurazioni e le dipendenze di build verranno spostate direttamente nel tuo progetto, così potrai continuare da dove avevi lasciato.

## Cosa è Incluso?

Il tuo ambiente avrà tutto ciò di cui hai bisogno per costruire una moderna app React single-page:

- Supporto per React, JSX, ES6, TypeScript e Flow.
- Estensioni di linguaggio oltre ES6 come l’operatore spread degli oggetti.
- CSS autoprefissato, quindi non hai bisogno di `-webkit-` o altri prefissi.
- Un runner di test unitari interattivo e veloce con supporto integrato per la copertura.
- Un server di sviluppo live che avvisa su errori comuni.
- Uno script di build per raggruppare JS, CSS e immagini per la produzione, con hash e sourcemap.
- Un [service worker](https://developers.google.com/web/fundamentals/getting-started/primers/service-workers) orientato all’offline e un [manifesto app web](https://developers.google.com/web/fundamentals/engage-and-retain/web-app-manifest/), che soddisfano tutti i criteri di una [Progressive Web App](https://facebook.github.io/create-react-app/docs/making-a-progressive-web-app). (_Nota: l'utilizzo del service worker è opzionale da `react-scripts@2.0.0` in poi_)
- Aggiornamenti semplici per gli strumenti sopra con una sola dipendenza.

Consulta [questa guida](https://github.com/nitishdayal/cra_closer_look) per una panoramica di come questi strumenti lavorano insieme.

Il compromesso è che **questi strumenti sono preconfigurati per funzionare in un modo specifico**. Se il tuo progetto ha bisogno di più personalizzazione, puoi ["esportare"](https://facebook.github.io/create-react-app/docs/available-scripts#npm-run-eject) e personalizzarlo, ma dovrai mantenere tu stesso questa configurazione.

## Alternative Popolari

Create React App è perfetto per:

- **Imparare React** in un ambiente di sviluppo confortevole e ricco di funzionalità.
- **Avviare nuove applicazioni React single-page.**
- **Creare esempi** con React per le tue librerie e componenti.

Ecco alcuni casi comuni in cui potresti voler provare qualcosa di diverso:

- Se vuoi **provare React** senza centinaia di dipendenze di strumenti di build, considera [l'uso di un singolo file HTML o di una sandbox online](https://reactjs.org/docs/getting-started.html#try-react).

- Se hai bisogno di **integrare codice React con un framework di template server-side** come Rails, Django o Symfony, o se **non stai costruendo una single-page app**, considera di usare [nwb](https://github.com/insin/nwb), o [Neutrino](https://neutrino.js.org/) che sono più flessibili. Per Rails specificamente, puoi usare [Rails Webpacker](https://github.com/rails/webpacker). Per Symfony, prova [webpack Encore di Symfony](https://symfony.com/doc/current/frontend/encore/reactjs.html).

- Se hai bisogno di **pubblicare un componente React**, [nwb](https://github.com/insin/nwb) può [fare anche questo](https://github.com/insin/nwb#react-components-and-libraries), così come il [preset react-components di Neutrino](https://neutrino.js.org/packages/react-components/).

- Se vuoi fare **server rendering** con React e Node.js, dai un’occhiata a [Next.js](https://nextjs.org/) o [Razzle](https://github.com/jaredpalmer/razzle). Create React App è agnostico rispetto al backend e produce solo bundle statici HTML/JS/CSS.

- Se il tuo sito è **principalmente statico** (ad esempio, un portfolio o un blog), considera di usare [Gatsby](https://www.gatsbyjs.org/) o [Next.js](https://nextjs.org/). A differenza di Create React App, Gatsby prerenderizza il sito in HTML al momento della build. Next.js supporta sia il server rendering che il prerendering.

- Infine, se hai bisogno di **più personalizzazione**, dai un’occhiata a [Neutrino](https://neutrino.js.org/) e al suo [preset React](https://neutrino.js.org/packages/react/).

Tutti gli strumenti sopra possono funzionare con poca o nessuna configurazione.

Se preferisci configurare la build da solo, [segui questa guida](https://reactjs.org/docs/add-react-to-a-website.html).

## React Native

Cerchi qualcosa di simile, ma per React Native?<br>
Dai un’occhiata a [Expo CLI](https://github.com/expo/expo-cli).

## Contribuire

Ci piacerebbe avere il tuo aiuto su `create-react-app`! Consulta [CONTRIBUTING.md](CONTRIBUTING.md) per maggiori informazioni su cosa cerchiamo e come iniziare.

## Sostenere Create React App

Create React App è un progetto mantenuto dalla comunità e tutti i contributori sono volontari. Se vuoi sostenere lo sviluppo futuro di Create React App, considera di donare al nostro [Open Collective](https://opencollective.com/create-react-app).

## Crediti

Questo progetto esiste grazie a tutte le persone che [contribuiscono](CONTRIBUTING.md).<br>
<a href="https://github.com/facebook/create-react-app/graphs/contributors"><img src="https://opencollective.com/create-react-app/contributors.svg?width=890&button=false" /></a>

Grazie a [Netlify](https://www.netlify.com/) per l’hosting della nostra documentazione.

## Ringraziamenti

Siamo grati agli autori dei progetti correlati esistenti per le loro idee e collaborazione:

- [@eanplatter](https://github.com/eanplatter)
- [@insin](https://github.com/insin)
- [@mxstbr](https://github.com/mxstbr)

## Licenza

Create React App è un software open source [con licenza MIT](https://github.com/facebook/create-react-app/blob/main/LICENSE). Il logo di Create React App è concesso con [licenza Creative Commons Attribution 4.0 International](https://creativecommons.org/licenses/by/4.0/).


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---