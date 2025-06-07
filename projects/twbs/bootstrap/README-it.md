<p align="center">
  <a href="https://getbootstrap.com/">
    <img src="https://getbootstrap.com/docs/5.3/assets/brand/bootstrap-logo-shadow.png" alt="Bootstrap logo" width="200" height="165">
  </a>
</p>

<h3 align="center">Bootstrap</h3>

<p align="center">
  Framework front-end elegante, intuitivo e potente per uno sviluppo web più veloce e semplice.
  <br>
  <a href="https://getbootstrap.com/docs/5.3/"><strong>Esplora la documentazione di Bootstrap »</strong></a>
  <br>
  <br>
  <a href="https://github.com/twbs/bootstrap/issues/new?assignees=-&labels=bug&template=bug_report.yml">Segnala un bug</a>
  ·
  <a href="https://github.com/twbs/bootstrap/issues/new?assignees=&labels=feature&template=feature_request.yml">Richiedi una funzionalità</a>
  ·
  <a href="https://themes.getbootstrap.com/">Temi</a>
  ·
  <a href="https://blog.getbootstrap.com/">Blog</a>
</p>


## Bootstrap 5

Il nostro branch predefinito è dedicato allo sviluppo della versione Bootstrap 5. Vai al [branch `v4-dev`](https://github.com/twbs/bootstrap/tree/v4-dev) per visualizzare il readme, la documentazione e il codice sorgente di Bootstrap 4.


## Indice

- [Avvio rapido](#avvio-rapido)
- [Stato](#stato)
- [Cosa è incluso](#cosa-è-incluso)
- [Bug e richieste di funzionalità](#bug-e-richieste-di-funzionalità)
- [Documentazione](#documentazione)
- [Contributi](#contributi)
- [Comunità](#comunità)
- [Versionamento](#versionamento)
- [Creatori](#creatori)
- [Ringraziamenti](#ringraziamenti)
- [Copyright e licenza](#copyright-e-licenza)


## Avvio rapido

Sono disponibili diverse opzioni di avvio rapido:

- [Scarica l’ultima versione](https://github.com/twbs/bootstrap/archive/v5.3.6.zip)
- Clona il repository: `git clone https://github.com/twbs/bootstrap.git`
- Installa con [npm](https://www.npmjs.com/): `npm install bootstrap@v5.3.6`
- Installa con [yarn](https://yarnpkg.com/): `yarn add bootstrap@v5.3.6`
- Installa con [Bun](https://bun.sh/): `bun add bootstrap@v5.3.6`
- Installa con [Composer](https://getcomposer.org/): `composer require twbs/bootstrap:5.3.6`
- Installa con [NuGet](https://www.nuget.org/): CSS: `Install-Package bootstrap` Sass: `Install-Package bootstrap.sass`

Consulta la [pagina di introduzione](https://getbootstrap.com/docs/5.3/getting-started/introduction/) per informazioni sui contenuti del framework, template, esempi e altro ancora.


## Stato

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


## Cosa è incluso

All’interno del download troverai le seguenti directory e file, che raggruppano logicamente le risorse comuni e forniscono sia le versioni compilate che minificate.

<details>
  <summary>Contenuto del download</summary>

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

Forniamo CSS e JS compilati (`bootstrap.*`), così come CSS e JS compilati e minificati (`bootstrap.min.*`). Le [source map](https://web.dev/articles/source-maps) (`bootstrap.*.map`) sono disponibili per l’uso con alcuni strumenti per sviluppatori dei browser. I file JS bundle (`bootstrap.bundle.js` e il minificato `bootstrap.bundle.min.js`) includono [Popper](https://popper.js.org/docs/v2/).


## Bug e richieste di funzionalità

Hai trovato un bug o vuoi richiedere una funzionalità? Per prima cosa leggi le [linee guida sulle issue](https://github.com/twbs/bootstrap/blob/main/.github/CONTRIBUTING.md#using-the-issue-tracker) e cerca problemi esistenti o chiusi. Se il tuo problema o idea non è ancora stato affrontato, [apri una nuova issue](https://github.com/twbs/bootstrap/issues/new/choose).


## Documentazione

La documentazione di Bootstrap, inclusa in questo repository nella directory principale, è costruita con [Astro](https://astro.build/) ed è ospitata pubblicamente su GitHub Pages all’indirizzo <https://getbootstrap.com/>. La documentazione può anche essere eseguita localmente.

La ricerca nella documentazione è alimentata da [DocSearch di Algolia](https://docsearch.algolia.com/).

### Eseguire la documentazione in locale

1. Esegui `npm install` per installare le dipendenze Node.js, incluso Astro (il generatore del sito).
2. Esegui `npm run test` (o uno script npm specifico) per ricostruire i file CSS e JavaScript distribuiti, così come le risorse della documentazione.
3. Dalla directory principale `/bootstrap`, esegui `npm run docs-serve` da linea di comando.
4. Apri `http://localhost:9001/` nel tuo browser, et voilà.

Scopri di più su Astro leggendo la sua [documentazione](https://docs.astro.build/en/getting-started/).

### Documentazione per versioni precedenti

Puoi trovare la documentazione di tutte le versioni precedenti su <https://getbootstrap.com/docs/versions/>.

[Le versioni precedenti](https://github.com/twbs/bootstrap/releases) e la relativa documentazione sono disponibili anche per il download.


## Contributi

Ti invitiamo a leggere le nostre [linee guida per i contributori](https://github.com/twbs/bootstrap/blob/main/.github/CONTRIBUTING.md). Sono incluse indicazioni su come aprire issue, standard di codifica e note sullo sviluppo.

Inoltre, se la tua pull request contiene patch o funzionalità JavaScript, devi includere [i relativi test unitari](https://github.com/twbs/bootstrap/tree/main/js/tests). Tutto l’HTML e il CSS deve essere conforme alla [Code Guide](https://github.com/mdo/code-guide), mantenuta da [Mark Otto](https://github.com/mdo).

Le preferenze dell’editor sono disponibili nel [file editor config](https://github.com/twbs/bootstrap/blob/main/.editorconfig) per un utilizzo semplice nei comuni editor di testo. Scopri di più e scarica i plugin su <https://editorconfig.org/>.


## Comunità

Ricevi aggiornamenti sullo sviluppo di Bootstrap e chatta con i manutentori del progetto e con la community.

- Segui [@getbootstrap su X](https://x.com/getbootstrap).
- Leggi e iscriviti a [The Official Bootstrap Blog](https://blog.getbootstrap.com/).
- Fai domande e partecipa alle [nostre discussioni su GitHub](https://github.com/twbs/bootstrap/discussions).
- Discuti, poni domande e altro sulla [community Discord](https://discord.gg/bZUvakRU3M) o sul [subreddit di Bootstrap](https://www.reddit.com/r/bootstrap/).
- Chatta con altri utenti Bootstrap su IRC. Sul server `irc.libera.chat`, nel canale `#bootstrap`.
- Per aiuto nell’implementazione puoi consultare Stack Overflow (tag [`bootstrap-5`](https://stackoverflow.com/questions/tagged/bootstrap-5)).
- Gli sviluppatori dovrebbero usare la parola chiave `bootstrap` nei pacchetti che modificano o estendono le funzionalità di Bootstrap quando distribuiti tramite [npm](https://www.npmjs.com/browse/keyword/bootstrap) o simili, per massima visibilità.


## Versionamento

Per trasparenza riguardo il ciclo di rilascio e per mantenere la compatibilità all’indietro, Bootstrap è mantenuto secondo le [linee guida Semantic Versioning](https://semver.org/). A volte possiamo commettere errori, ma seguiamo queste regole ogni volta che è possibile.

Consulta [la sezione Releases del nostro progetto su GitHub](https://github.com/twbs/bootstrap/releases) per i changelog di ogni versione di Bootstrap. Gli annunci di rilascio pubblicati su [il blog ufficiale di Bootstrap](https://blog.getbootstrap.com/) contengono i riassunti delle modifiche più importanti di ogni versione.


## Creatori

**Mark Otto**

- <https://x.com/mdo>
- <https://github.com/mdo>

**Jacob Thornton**

- <https://x.com/fat>
- <https://github.com/fat>


## Ringraziamenti

<a href="https://www.browserstack.com/">
  <img src="https://live.browserstack.com/images/opensource/browserstack-logo.svg" alt="BrowserStack" width="192" height="42">
</a>

Grazie a [BrowserStack](https://www.browserstack.com/) per averci fornito l’infrastruttura che ci permette di testare su browser reali!

<a href="https://www.netlify.com/">
  <img src="https://www.netlify.com/v3/img/components/full-logo-light.svg" alt="Netlify" width="147" height="40">
</a>

Grazie a [Netlify](https://www.netlify.com/) per averci fornito i Deploy Preview!


## Sponsor

Sostieni questo progetto diventando uno sponsor. Il tuo logo apparirà qui con un link al tuo sito web. [[Diventa uno sponsor](https://opencollective.com/bootstrap#sponsor)]

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


## Sostenitori

Grazie a tutti i nostri sostenitori! 🙏 [[Diventa un sostenitore](https://opencollective.com/bootstrap#backer)]

[![Backers](https://opencollective.com/bootstrap/backers.svg?width=890)](https://opencollective.com/bootstrap#backers)


## Copyright e licenza

Codice e documentazione copyright 2011-2025 degli [Autori di Bootstrap](https://github.com/twbs/bootstrap/graphs/contributors). Codice rilasciato sotto [Licenza MIT](https://github.com/twbs/bootstrap/blob/main/LICENSE). Documentazione rilasciata sotto [Creative Commons](https://creativecommons.org/licenses/by/3.0/).


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---