# [jQuery](https://jquery.com/) — JavaScript di Nuova Generazione

Le riunioni si tengono attualmente sulla piattaforma [matrix.org](https://matrix.to/#/#jquery_meeting:gitter.im).

I verbali delle riunioni sono disponibili su [meetings.jquery.org](https://meetings.jquery.org/category/core/).

L'ultima versione di jQuery è disponibile su [https://jquery.com/download/](https://jquery.com/download/).

## Supporto delle versioni

| Versione | Branch     | Stato    |
| -------- | ---------- | -------- |
| 4.x      | main       | Beta     |
| 3.x      | 3.x-stable | Attiva   |
| 2.x      | 2.x-stable | Inattiva |
| 1.x      | 1.x-stable | Inattiva |

Una volta che la versione finale 4.0.0 sarà rilasciata, il branch 3.x continuerà a ricevere aggiornamenti per un periodo limitato. I branch 2.x e 1.x non sono più supportati.

Il supporto commerciale per le versioni inattive è disponibile tramite [HeroDevs](https://herodevs.com/nes).

Scopri di più sul nostro [supporto delle versioni](https://jquery.com/support/).

## Guide al contributo

Nello spirito dello sviluppo software open source, jQuery incoraggia sempre la partecipazione della comunità al contributo del codice. Per aiutarti a iniziare e prima di scrivere codice, assicurati di leggere attentamente queste importanti linee guida:

1. [Partecipa](https://contribute.jquery.org/)
2. [Guida di stile del Core](https://contribute.jquery.org/style-guide/js/)
3. [Scrivere codice per i progetti jQuery](https://contribute.jquery.org/code/)

### Riferimenti a issue/PR

Le issue/PR su GitHub vengono solitamente riferite tramite `gh-NUMERO`, dove `NUMERO` è l'ID numerico della issue/PR. Puoi trovare tale issue/PR su `https://github.com/jquery/jquery/issues/NUMERO`.

jQuery in passato ha utilizzato un diverso bug tracker - basato su Trac - disponibile su [bugs.jquery.com](https://bugs.jquery.com/). È mantenuto in modalità sola lettura per consentire il riferimento a discussioni passate. Quando il codice sorgente di jQuery fa riferimento a una di queste issue, utilizza il pattern `trac-NUMERO`, dove `NUMERO` è l'ID numerico della issue. Puoi trovare tale issue su `https://bugs.jquery.com/ticket/NUMERO`.

## Ambienti in cui usare jQuery

- [Supporto browser](https://jquery.com/browser-support/)
- jQuery supporta anche Node, estensioni browser e altri ambienti non browser.

## Cosa serve per costruire la propria versione di jQuery

Per costruire jQuery, devi avere l'ultima versione di Node.js/npm e git 1.7 o superiore. Versioni precedenti potrebbero funzionare, ma non sono supportate.

Per Windows, devi scaricare e installare [git](https://git-scm.com/downloads) e [Node.js](https://nodejs.org/en/download/).

Gli utenti macOS dovrebbero installare [Homebrew](https://brew.sh/). Una volta installato Homebrew, esegui `brew install git` per installare git,
e `brew install node` per installare Node.js.

Gli utenti Linux/BSD dovrebbero utilizzare i rispettivi gestori di pacchetti per installare git e Node.js, oppure compilare dal sorgente
se preferiscono. Facile facile.

## Come costruire la propria versione di jQuery

Prima, [clona il repository git di jQuery](https://help.github.com/en/github/creating-cloning-and-archiving-repositories/cloning-a-repository).

Poi, entra nella directory jquery, installa le dipendenze ed esegui lo script di build:

```bash
cd jquery
npm install
npm run build
```

La versione compilata di jQuery verrà posizionata nella directory `dist/`, insieme a una copia minificata e al relativo file di mappa.

## Compilare tutti i file di rilascio di jQuery

Per compilare tutte le varianti di jQuery, esegui il seguente comando:

```bash
npm run build:all
```

Questo creerà tutte le varianti incluse in una release di jQuery, inclusi `jquery.js`, `jquery.slim.js`, `jquery.module.js` e `jquery.slim.module.js` insieme ai relativi file minificati e sourcemap.

`jquery.module.js` e `jquery.slim.module.js` sono [moduli ECMAScript](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Guide/Modules) che esportano `jQuery` e `$` come named exports e sono collocati nella directory `dist-module/` invece che in `dist/`.

## Costruire una versione personalizzata di jQuery

Lo script di build può essere utilizzato per creare una versione personalizzata di jQuery che include solo i moduli di cui hai bisogno.

Qualsiasi modulo può essere escluso tranne `core`. Quando si esclude `selector`, non viene rimosso ma sostituito con un piccolo wrapper attorno al nativo `querySelectorAll` (vedi sotto per maggiori informazioni).

### Aiuto sullo script di build

Per vedere l'elenco completo delle opzioni disponibili per lo script di build, esegui:

```bash
npm run build -- --help
```

### Moduli

Per escludere un modulo, passa il suo percorso relativo alla cartella `src` (senza l'estensione `.js`) all'opzione `--exclude`. Quando si utilizza l'opzione `--include`, le inclusioni predefinite vengono rimosse e viene creata una build solo con quei moduli.

Alcuni esempi di moduli che possono essere esclusi o inclusi sono:

- **ajax**: Tutte le funzionalità AJAX: `$.ajax()`, `$.get()`, `$.post()`, `$.ajaxSetup()`, `.load()`, trasporti e abbreviazioni di eventi ajax come `.ajaxStart()`.
- **ajax/xhr**: Solo il trasporto AJAX XMLHTTPRequest.
- **ajax/script**: Solo il trasporto AJAX tramite `<script>`; utilizzato per recuperare script.
- **ajax/jsonp**: Solo il trasporto AJAX JSONP; dipende dal trasporto ajax/script.
- **css**: Il metodo `.css()`. Rimuove anche **tutti** i moduli che dipendono da css (inclusi **effects**, **dimensions** e **offset**).
- **css/showHide**: `.show()`, `.hide()` e `.toggle()` non animati; può essere escluso se utilizzi classi o chiamate esplicite a `.css()` per impostare la proprietà `display`. Rimuove anche il modulo **effects**.
- **deprecated**: Metodi documentati come deprecati ma non ancora rimossi.
- **dimensions**: I metodi `.width()` e `.height()`, incluse le varianti `inner-` e `outer-`.
- **effects**: Il metodo `.animate()` e le sue abbreviazioni come `.slideUp()` o `.hide("slow")`.
- **event**: I metodi `.on()` e `.off()` e tutta la funzionalità degli eventi.
- **event/trigger**: I metodi `.trigger()` e `.triggerHandler()`.
- **offset**: I metodi `.offset()`, `.position()`, `.offsetParent()`, `.scrollLeft()` e `.scrollTop()`.
- **wrap**: I metodi `.wrap()`, `.wrapAll()`, `.wrapInner()` e `.unwrap()`.
- **core/ready**: Escludi il modulo ready se posizioni i tuoi script alla fine del body. Qualsiasi callback ready associato con `jQuery()` verrà semplicemente chiamato immediatamente. Tuttavia, `jQuery(document).ready()` non sarà una funzione e `.on("ready", ...)` o simili non verranno attivati.
- **deferred**: Esclude jQuery.Deferred. Questo esclude anche tutti i moduli che dipendono da Deferred, inclusi **ajax**, **effects** e **queue**, ma sostituisce **core/ready** con **core/ready-no-deferred**.
- **exports/global**: Esclude l'assegnazione delle variabili globali jQuery ($ e jQuery) alla finestra globale.
- **exports/amd**: Esclude la definizione AMD.

- **selector**: Il motore selettore jQuery completo. Quando questo modulo è escluso, viene sostituito con un motore selettore rudimentale basato sul metodo `querySelectorAll` del browser che non supporta le estensioni dei selettori jQuery o semantiche avanzate. Vedi il file [selector-native.js](https://github.com/jquery/jquery/blob/main/src/selector-native.js) per dettagli.

*Nota*: L'esclusione del modulo completo `selector` escluderà anche tutte le estensioni dei selettori jQuery (come `effects/animatedSelector` e `css/hiddenVisibleSelectors`).

##### Nome AMD

Puoi impostare il nome del modulo per la definizione AMD di jQuery. Per impostazione predefinita è impostato su "jquery", il che si integra bene con plugin e librerie di terze parti, ma potrebbero esserci casi in cui desideri cambiarlo. Passalo al parametro `--amd`:

```bash
npm run build -- --amd="nome-personalizzato"
```

Oppure, per definirlo in modo anonimo, lascia il nome vuoto.

```bash
npm run build -- --amd
```

##### Nome file e directory

Il nome predefinito del file jQuery compilato è `jquery.js`; viene posizionato nella directory `dist/`. È possibile cambiare il nome file usando `--filename` e la directory usando `--dir`. `--dir` è relativa alla root del progetto.

```bash
npm run build -- --slim --filename="jquery.slim.js" --dir="/tmp"
```

Questo creerà una versione slim di jQuery e la posizionerà in `tmp/jquery.slim.js`.

##### Modalità ECMAScript Module (ESM)

Per impostazione predefinita, jQuery genera un file JavaScript script normale. Puoi anche generare un modulo ECMAScript che esporta `jQuery` come export di default usando il parametro `--esm`:

```bash
npm run build -- --filename=jquery.module.js --esm
```

##### Modalità Factory

Per impostazione predefinita, jQuery dipende da una `window` globale. Per ambienti che non la possiedono, puoi generare una build factory che espone una funzione che accetta `window` come parametro che puoi fornire esternamente (vedi [`README` del pacchetto pubblicato](build/fixtures/README.md) per istruzioni d'uso). Puoi generare tale factory usando il parametro `--factory`:

```bash
npm run build -- --filename=jquery.factory.js --factory
```

Questa opzione può essere combinata con altre come `--esm` o `--slim`:

```bash
npm run build -- --filename=jquery.factory.slim.module.js --factory --esm --slim --dir="/dist-module"
```

#### Esempi di build personalizzate

Crea una build personalizzata usando `npm run build`, elencando i moduli da escludere. L'esclusione di un modulo di primo livello esclude anche la sua corrispondente directory di moduli.

Escludi tutte le funzionalità **ajax**:

```bash
npm run build -- --exclude=ajax
```

L'esclusione di **css** rimuove i moduli che dipendono da CSS: **effects**, **offset**, **dimensions**.

```bash
npm run build -- --exclude=css
```

Escludi un insieme di moduli (`-e` è un alias di `--exclude`):

```bash
npm run build -- -e ajax/jsonp -e css -e deprecated -e dimensions -e effects -e offset -e wrap
```

Esiste un alias speciale per generare una build con la stessa configurazione della versione ufficiale jQuery Slim:

```bash
npm run build -- --filename=jquery.slim.js --slim
```

Oppure, per creare la build slim come modulo esm:

```bash
npm run build -- --filename=jquery.slim.module.js --slim --esm
```
```

*Le build personalizzate non ufficiali non sono regolarmente testate. Usale a tuo rischio e pericolo.*

## Esecuzione dei test unitari

Assicurati di avere le dipendenze necessarie:

```bash
npm install
```

Avvia `npm start` per la compilazione automatica di jQuery mentre lavori:

```bash
npm start
```

Esegui i test unitari con un server locale che supporta PHP. Assicurati di eseguire il sito dalla directory root, non dalla directory "test". Non è richiesto alcun database. Server locali PHP preconfigurati sono disponibili per Windows e Mac. Ecco alcune opzioni:

- Windows: [Scarica WAMP](https://www.wampserver.com/en/)
- Mac: [Scarica MAMP](https://www.mamp.info/en/downloads/)
- Linux: [Configurazione di LAMP](https://www.linux.com/training-tutorials/easy-lamp-server-installation/)
- [Mongoose (molte piattaforme)](https://code.google.com/p/mongoose/)

## Git essenziale

Poiché il codice sorgente è gestito tramite il sistema di versionamento Git, è utile conoscere alcune funzionalità utilizzate.

### Pulizia

Se vuoi ripristinare la tua directory di lavoro allo stato dell'upstream, puoi usare i seguenti comandi (ricorda che tutto su cui hai lavorato andrà perso dopo questi comandi):

```bash
git reset --hard upstream/main
git clean -fdx
```

### Rebase

Per i branch di funzionalità/argomento, dovresti sempre usare il flag `--rebase` con `git pull`, oppure se gestisci spesso diversi branch temporanei "da inviare come pull request su github", esegui il seguente comando per automatizzare questo comportamento:

```bash
git config branch.autosetuprebase local
```

(vedi `man git-config` per maggiori informazioni)

### Gestione dei conflitti di merge

Se ottieni conflitti di merge durante unione, invece di modificare manualmente i file in conflitto, puoi usare la funzionalità
`git mergetool`. Anche se lo strumento predefinito `xxdiff` sembra brutto/vecchio, è piuttosto utile.

Di seguito alcuni comandi che possono essere utilizzati lì:

- `Ctrl + Alt + M` - auto-unisci il più possibile
- `b` - vai al prossimo conflitto di merge
- `s` - cambia l'ordine delle righe in conflitto
- `u` - annulla una fusione
- `tasto sinistro del mouse` - segna un blocco come vincente
- `tasto centrale del mouse` - segna una riga come vincente
- `Ctrl + S` - salva
- `Ctrl + Q` - esci

## Riferimento [QUnit](https://api.qunitjs.com)

### Metodi di test

```js
expect( numAssertions );
stop();
start();
```

*Nota*: l'eventuale aggiunta di un argomento a stop/start da parte di QUnit viene ignorata in questa suite di test, così che start e stop possano essere passati come callback senza preoccuparsi dei loro parametri.

### Asserzioni di test

```js
ok( value, [message] );
equal( actual, expected, [message] );
notEqual( actual, expected, [message] );
deepEqual( actual, expected, [message] );
notDeepEqual( actual, expected, [message] );
strictEqual( actual, expected, [message] );
notStrictEqual( actual, expected, [message] );
throws( block, [expected], [message] );
```

## Riferimento ai metodi di convenienza della suite di test

Vedi [test/data/testinit.js](https://github.com/jquery/jquery/blob/main/test/data/testinit.js).

### Restituisce un array di elementi con gli ID forniti

```js
q( ... );
```

Esempio:

```js
q( "main", "foo", "bar" );

=> [ div#main, span#foo, input#bar ]
```

### Verifica che una selezione corrisponda agli ID forniti

```js
t( testName, selector, [ "array", "of", "ids" ] );
```

Esempio:

```js
t("Check for something", "//[a]", ["foo", "bar"]);
```

### Genera un evento DOM nativo senza passare da jQuery

```js
fireNative( node, eventType );
```

Esempio:

```js
fireNative( jQuery( "#elem" )[ 0 ], "click" );
```

### Aggiungi un numero casuale all’url per evitare la cache

```js
url( "some/url" );
```

Esempio:

```js
url( "index.html" );

=> "data/index.html?10538358428943"


url( "mock.php?foo=bar" );

=> "data/mock.php?foo=bar&10538358345554"
```

### Esegui i test in un iframe

Alcuni test possono richiedere un documento diverso dal test fixture standard e
questi possono essere eseguiti in un iframe separato. Il codice di test effettivo e le asserzioni
rimangono nei file di test principali di jQuery; solo il markup minimo della fixture di test
e il codice di setup dovrebbero essere inseriti nel file dell’iframe.

```js
testIframe( testName, fileName,
  function testCallback(
      assert, jQuery, window, document,
	  [ additional args ] ) {
	...
  } );
```

Questo carica una pagina, costruendo un url con fileName `"./data/" + fileName`.
La pagina nell'iframe determina quando eseguire la callback nel test
includendo lo script "/test/data/iframeTest.js" e chiamando
`startIframeTest( [ additional args ] )` quando appropriato. Spesso ciò
avviene dopo che il document ready o `window.onload` sono stati eseguiti.

La `testCallback` riceve l’oggetto QUnit `assert` creato da `testIframe`
per questo test, seguito dai globali `jQuery`, `window` e `document` dell’iframe. Se il codice nell’iframe passa argomenti a `startIframeTest`,
questi seguono l’argomento `document`.

## Domande?

Se hai domande, sentiti libero di chiedere sul
[forum Developing jQuery Core](https://forum.jquery.com/developing-jquery-core) o su #jquery su [libera](https://web.libera.chat/).
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---