# [jQuery](https://jquery.com/) — New Wave JavaScript

Vergaderingen worden momenteel gehouden op het [matrix.org platform](https://matrix.to/#/#jquery_meeting:gitter.im).

Notulen van vergaderingen zijn te vinden op [meetings.jquery.org](https://meetings.jquery.org/category/core/).

De nieuwste versie van jQuery is beschikbaar op [https://jquery.com/download/](https://jquery.com/download/).

## Versieondersteuning

| Versie  | Branch      | Status    |
| ------- | ----------- | --------- |
| 4.x     | main        | Beta      |
| 3.x     | 3.x-stable  | Actief    |
| 2.x     | 2.x-stable  | Inactief  |
| 1.x     | 1.x-stable  | Inactief  |

Zodra 4.0.0 definitief wordt uitgebracht, zal de 3.x branch nog een beperkte tijd updates ontvangen. De 2.x en 1.x branches worden niet langer ondersteund.

Commerciële ondersteuning voor inactieve versies is beschikbaar via [HeroDevs](https://herodevs.com/nes).

Lees meer over onze [versieondersteuning](https://jquery.com/support/).

## Richtlijnen voor bijdragen

In de geest van open source softwareontwikkeling moedigt jQuery altijd bijdragen van de community aan. Om je op weg te helpen en voordat je begint met het schrijven van code, lees deze belangrijke richtlijnen voor bijdragen zorgvuldig door:

1. [Meedoen](https://contribute.jquery.org/)
2. [Core Stijlgids](https://contribute.jquery.org/style-guide/js/)
3. [Code schrijven voor jQuery projecten](https://contribute.jquery.org/code/)

### Verwijzingen naar issues/PR's

GitHub issues/PR's worden meestal verwezen via `gh-NUMBER`, waarbij `NUMBER` de numerieke ID van het issue of de PR is. Je kunt zo'n issue/PR vinden op `https://github.com/jquery/jquery/issues/NUMBER`.

jQuery heeft in het verleden een andere bugtracker gebruikt - gebaseerd op Trac - beschikbaar op [bugs.jquery.com](https://bugs.jquery.com/). Deze wordt alleen-lezen gehouden zodat het mogelijk blijft om naar eerdere discussies te verwijzen. Wanneer in de jQuery-bron naar een van die issues wordt verwezen, wordt het patroon `trac-NUMBER` gebruikt, waarbij `NUMBER` de numerieke ID van het issue is. Je kunt zo'n issue vinden op `https://bugs.jquery.com/ticket/NUMBER`.

## Omgevingen waarin jQuery gebruikt kan worden

- [Browserondersteuning](https://jquery.com/browser-support/)
- jQuery ondersteunt ook Node, browserextensies en andere niet-browseromgevingen.

## Wat je nodig hebt om je eigen jQuery te bouwen

Om jQuery te bouwen heb je de nieuwste Node.js/npm en git 1.7 of later nodig. Eerdere versies kunnen werken, maar worden niet ondersteund.

Voor Windows moet je [git](https://git-scm.com/downloads) en [Node.js](https://nodejs.org/en/download/) downloaden en installeren.

macOS-gebruikers zouden [Homebrew](https://brew.sh/) moeten installeren. Zodra Homebrew geïnstalleerd is, voer `brew install git` uit om git te installeren,
en `brew install node` om Node.js te installeren.

Linux/BSD-gebruikers dienen hun geschikte pakketbeheerders te gebruiken om git en Node.js te installeren, of van bron te bouwen
als je dat wilt. Simpel.

## Hoe bouw je je eigen jQuery

Eerst, [clon de jQuery git repo](https://help.github.com/en/github/creating-cloning-and-archiving-repositories/cloning-a-repository).

Ga vervolgens de jquery-map in, installeer afhankelijkheden en voer het build-script uit:

```bash
cd jquery
npm install
npm run build
```

De gebouwde versie van jQuery wordt geplaatst in de map `dist/`, samen met een geminificeerde kopie en bijbehorend map-bestand.

## Bouw alle jQuery release-bestanden

Om alle varianten van jQuery te bouwen, voer je het volgende commando uit:

```bash
npm run build:all
```

Dit zal alle varianten creëren die jQuery bij een release bevat, inclusief `jquery.js`, `jquery.slim.js`, `jquery.module.js` en `jquery.slim.module.js` met hun bijbehorende geminificeerde bestanden en sourcemaps.

`jquery.module.js` en `jquery.slim.module.js` zijn [ECMAScript modules](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Guide/Modules) die `jQuery` en `$` als named exports exporteren en worden geplaatst in de map `dist-module/` in plaats van de map `dist/`.

## Een aangepaste jQuery bouwen

Het build-script kan worden gebruikt om een aangepaste versie van jQuery te maken die alleen de modules bevat die je nodig hebt.

Elke module kan worden uitgesloten, behalve `core`. Wanneer `selector` wordt uitgesloten, wordt deze niet verwijderd maar vervangen door een kleine wrapper rond de native `querySelectorAll` (zie hieronder voor meer informatie).

### Build-script help

Om de volledige lijst met beschikbare opties voor het build-script te zien, voer je het volgende uit:

```bash
npm run build -- --help
```

### Modules

Om een module uit te sluiten, geef je het pad ten opzichte van de map `src` (zonder de `.js` extensie) door aan de `--exclude` optie. Wanneer je de `--include` optie gebruikt, worden de standaard modules niet meegebouwd en wordt er een build gemaakt met alleen die modules.

Enkele voorbeeldmodules die kunnen worden uitgesloten of opgenomen zijn:

- **ajax**: Alle AJAX-functionaliteit: `$.ajax()`, `$.get()`, `$.post()`, `$.ajaxSetup()`, `.load()`, transports en ajax event-shorthands zoals `.ajaxStart()`.
- **ajax/xhr**: Alleen de XMLHTTPRequest AJAX transport.
- **ajax/script**: Alleen de `<script>` AJAX transport; gebruikt om scripts op te halen.
- **ajax/jsonp**: Alleen de JSONP AJAX transport; is afhankelijk van de ajax/script transport.
- **css**: De `.css()` methode. Verwijdert ook **alle** modules die van css afhankelijk zijn (inclusief **effects**, **dimensions**, en **offset**).
- **css/showHide**: Niet-geanimeerde `.show()`, `.hide()` en `.toggle()`; kan worden uitgesloten als je klassen of expliciete `.css()`-aanroepen gebruikt om de `display`-eigenschap in te stellen. Verwijdert ook de **effects** module.
- **deprecated**: Methoden die als verouderd zijn gedocumenteerd maar nog niet zijn verwijderd.
- **dimensions**: De `.width()` en `.height()` methoden, inclusief `inner-` en `outer-` varianten.
- **effects**: De `.animate()` methode en zijn snelkoppelingen zoals `.slideUp()` of `.hide("slow")`.
- **event**: De `.on()` en `.off()` methoden en alle event-functionaliteit.
- **event/trigger**: De `.trigger()` en `.triggerHandler()` methoden.
- **offset**: De `.offset()`, `.position()`, `.offsetParent()`, `.scrollLeft()`, en `.scrollTop()` methoden.
- **wrap**: De `.wrap()`, `.wrapAll()`, `.wrapInner()`, en `.unwrap()` methoden.
- **core/ready**: Sluit de ready-module uit als je je scripts aan het einde van de body plaatst. Alle ready-callbacks gebonden met `jQuery()` worden dan direct aangeroepen. Echter, `jQuery(document).ready()` zal geen functie zijn en `.on("ready", ...)` of iets dergelijks wordt niet getriggerd.
- **deferred**: Sluit jQuery.Deferred uit. Dit sluit ook alle modules uit die afhankelijk zijn van Deferred, waaronder **ajax**, **effects** en **queue**, maar vervangt **core/ready** door **core/ready-no-deferred**.
- **exports/global**: Sluit het koppelen van globale jQuery-variabelen ($ en jQuery) aan het window uit.
- **exports/amd**: Sluit de AMD-definitie uit.

- **selector**: De volledige jQuery selector-engine. Wanneer deze module wordt uitgesloten, wordt deze vervangen door een eenvoudige selector-engine gebaseerd op de `querySelectorAll` methode van de browser, die geen jQuery selector-extensies of verbeterde semantiek ondersteunt. Zie het bestand [selector-native.js](https://github.com/jquery/jquery/blob/main/src/selector-native.js) voor details.

*Opmerking*: Het uitsluiten van de volledige `selector`-module sluit ook alle jQuery selector-extensies uit (zoals `effects/animatedSelector` en `css/hiddenVisibleSelectors`).

##### AMD-naam

Je kunt de modulenaam instellen voor jQuery's AMD-definitie. Standaard staat deze op "jquery", wat goed werkt met plugins en bibliotheken van derden, maar er kunnen gevallen zijn waarin je dit wilt wijzigen. Geef het door aan de `--amd` parameter:

```bash
npm run build -- --amd="custom-name"
```

Of, om anoniem te definiëren, laat je de naam leeg.

```bash
npm run build -- --amd
```

##### Bestandsnaam en map

De standaardnaam voor het gebouwde jQuery-bestand is `jquery.js`; het wordt geplaatst onder de map `dist/`. Het is mogelijk om de bestandsnaam te wijzigen met `--filename` en de map met `--dir`. `--dir` is relatief aan de projectroot.

```bash
npm run build -- --slim --filename="jquery.slim.js" --dir="/tmp"
```

Dit zou een slanke versie van jQuery maken en deze plaatsen onder `tmp/jquery.slim.js`.

##### ECMAScript Module (ESM) modus

Standaard genereert jQuery een reguliere JavaScript-bestand. Je kunt ook een ECMAScript-module genereren die `jQuery` als standaardexport exporteert met behulp van de `--esm` parameter:

```bash
npm run build -- --filename=jquery.module.js --esm
```

##### Factory-modus

Standaard is jQuery afhankelijk van een globale `window`. Voor omgevingen die dit niet hebben, kun je een factory-build genereren die een functie blootstelt die `window` als parameter accepteert, welke je extern kunt aanleveren (zie [`README` van het gepubliceerde pakket](build/fixtures/README.md) voor gebruiksinstructies). Je kunt zo'n factory genereren met de `--factory` parameter:

```bash
npm run build -- --filename=jquery.factory.js --factory
```

Deze optie kan gecombineerd worden met andere zoals `--esm` of `--slim`:

```bash
npm run build -- --filename=jquery.factory.slim.module.js --factory --esm --slim --dir="/dist-module"
```

#### Voorbeelden van aangepaste builds

Maak een aangepaste build met `npm run build`, waarbij je de uit te sluiten modules opsomt. Het uitsluiten van een top-level module sluit ook de bijbehorende map met modules uit.

Sluit alle **ajax**-functionaliteit uit:

```bash
npm run build -- --exclude=ajax
```

Het uitsluiten van **css** verwijdert modules die van CSS afhankelijk zijn: **effects**, **offset**, **dimensions**.

```bash
npm run build -- --exclude=css
```

Sluit een reeks modules uit (`-e` is een alias voor `--exclude`):

```bash
npm run build -- -e ajax/jsonp -e css -e deprecated -e dimensions -e effects -e offset -e wrap
```

Er is een speciale alias om een build te genereren met dezelfde configuratie als de officiële jQuery Slim build:

```bash
npm run build -- --filename=jquery.slim.js --slim
```

Of, om de slanke build als een esm-module te maken:

```bash
npm run build -- --filename=jquery.slim.module.js --slim --esm
```
```

*Niet-officiële aangepaste builds worden niet regelmatig getest. Gebruik ze op eigen risico.*

## Het uitvoeren van de unittests

Zorg ervoor dat je de benodigde afhankelijkheden hebt geïnstalleerd:

```bash
npm install
```

Start `npm start` om jQuery automatisch te bouwen terwijl je werkt:

```bash
npm start
```

Voer de unittests uit met een lokale server die PHP ondersteunt. Zorg ervoor dat je de site vanaf de hoofdmap draait, niet vanuit de "test"-map. Er is geen database vereist. Voorgeconfigureerde lokale php-servers zijn beschikbaar voor Windows en Mac. Hier zijn enkele opties:

- Windows: [WAMP download](https://www.wampserver.com/en/)
- Mac: [MAMP download](https://www.mamp.info/en/downloads/)
- Linux: [LAMP installeren](https://www.linux.com/training-tutorials/easy-lamp-server-installation/)
- [Mongoose (de meeste platformen)](https://code.google.com/p/mongoose/)

## Essentiële Git

Omdat de broncode wordt beheerd met het Git versiebeheersysteem, is het handig om enkele gebruikte functies te kennen.

### Opruimen

Als je je werkdirectory wilt terugzetten naar de status van upstream, kun je de volgende commando's gebruiken (let op: alles waar je aan gewerkt hebt is dan weg):

```bash
git reset --hard upstream/main
git clean -fdx
```

### Rebasen

Voor feature/topic branches dien je altijd de `--rebase` vlag te gebruiken bij `git pull`, of als je vaak veel tijdelijke branches beheert die bedoeld zijn voor een github pull request, kun je het volgende uitvoeren om dit te automatiseren:

```bash
git config branch.autosetuprebase local
```

(zie `man git-config` voor meer informatie)

### Omgaan met merge conflicten

Als je merge conflicten krijgt tijdens het mergen, kun je in plaats van de conflicterende bestanden handmatig te bewerken, de functie
`git mergetool` gebruiken. Hoewel de standaardtool `xxdiff` er slecht/oud uitziet, is deze vrij handig.

De volgende commando's kunnen daar gebruikt worden:

- `Ctrl + Alt + M` - automerge zoveel mogelijk
- `b` - ga naar het volgende merge conflict
- `s` - wijzig de volgorde van de conflicterende regels
- `u` - ongedaan maken van een merge
- `linkermuisknop` - markeer een blok als winnaar
- `middelste muisknop` - markeer een regel als winnaar
- `Ctrl + S` - opslaan
- `Ctrl + Q` - afsluiten

## [QUnit](https://api.qunitjs.com) Referentie

### Testmethoden

```js
expect( numAssertions );
stop();
start();
```

*Opmerking*: QUnit's uiteindelijke toevoeging van een argument aan stop/start wordt in deze testsuite genegeerd zodat start en stop als callbacks kunnen worden doorgegeven zonder dat je je zorgen hoeft te maken over hun parameters.

### Testasserties

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

## Referentie van handige testmethoden

Zie [test/data/testinit.js](https://github.com/jquery/jquery/blob/main/test/data/testinit.js).

### Retourneert een array van elementen met de gegeven IDs

```js
q( ... );
```

Voorbeeld:

```js
q( "main", "foo", "bar" );

=> [ div#main, span#foo, input#bar ]
```

### Controleert of een selectie overeenkomt met de gegeven IDs

```js
t( testName, selector, [ "array", "of", "ids" ] );
```

Voorbeeld:

```js
t("Check for something", "//[a]", ["foo", "bar"]);
```

### Vuur een native DOM event af zonder gebruik van jQuery

```js
fireNative( node, eventType );
```

Voorbeeld:

```js
fireNative( jQuery( "#elem" )[ 0 ], "click" );
```

### Voeg een willekeurig getal toe aan url om caching te voorkomen

```js
url( "some/url" );
```

Voorbeeld:

```js
url( "index.html" );

=> "data/index.html?10538358428943"


url( "mock.php?foo=bar" );

=> "data/mock.php?foo=bar&10538358345554"
```

### Draai tests in een iframe

Sommige tests vereisen mogelijk een document anders dan de standaard test fixture,
deze kunnen in een apart iframe uitgevoerd worden. De daadwerkelijke testcode en asserties
blijven in jQuery's hoofdtestbestanden; alleen de minimale test fixture markup
en set-up code moet in het iframe-bestand geplaatst worden.

```js
testIframe( testName, fileName,
  function testCallback(
      assert, jQuery, window, document,
	  [ additional args ] ) {
	...
  } );
```

Dit laadt een pagina en construeert een url met fileName `"./data/" + fileName`.
De pagina in het iframe bepaalt wanneer de callback in de test wordt uitgevoerd door
het includen van het script "/test/data/iframeTest.js" en het aanroepen van
`startIframeTest( [ additional args ] )` wanneer gepast. Vaak is dit na document ready of `window.onload`.

De `testCallback` ontvangt het QUnit `assert` object dat is aangemaakt door `testIframe`
voor deze test, gevolgd door de globale `jQuery`, `window`, en `document` van
het iframe. Als de iframe-code argumenten meegeeft aan `startIframeTest`,
volgen deze na het `document` argument.

## Vragen?

Als je vragen hebt, stel ze gerust op het
[Developing jQuery Core forum](https://forum.jquery.com/developing-jquery-core) of in #jquery op [libera](https://web.libera.chat/).
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---