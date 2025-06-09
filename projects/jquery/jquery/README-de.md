# [jQuery](https://jquery.com/) — Neue Welle JavaScript

Die Meetings finden derzeit auf der [matrix.org Plattform](https://matrix.to/#/#jquery_meeting:gitter.im) statt.

Protokolle der Meetings sind unter [meetings.jquery.org](https://meetings.jquery.org/category/core/) zu finden.

Die neueste Version von jQuery ist unter [https://jquery.com/download/](https://jquery.com/download/) verfügbar.

## Versionsunterstützung

| Version | Branch     | Status    |
| ------- | ---------- | --------- |
| 4.x     | main       | Beta      |
| 3.x     | 3.x-stable | Aktiv     |
| 2.x     | 2.x-stable | Inaktiv   |
| 1.x     | 1.x-stable | Inaktiv   |

Sobald 4.0.0 final veröffentlicht ist, wird der 3.x-Branch noch für eine begrenzte Zeit Updates erhalten. Die 2.x- und 1.x-Branches werden nicht mehr unterstützt.

Kommerzieller Support für inaktive Versionen ist von [HeroDevs](https://herodevs.com/nes) verfügbar.

Mehr über unsere [Versionsunterstützung](https://jquery.com/support/).

## Beiträge und Leitfäden

Im Sinne der Open-Source-Softwareentwicklung ermutigt jQuery immer zur Mitwirkung durch die Community. Damit du gut starten kannst und bevor du mit dem Coden beginnst, solltest du diese wichtigen Beitragsrichtlinien sorgfältig lesen:

1. [Mitmachen](https://contribute.jquery.org/)
2. [Core Style Guide](https://contribute.jquery.org/style-guide/js/)
3. [Code für jQuery-Projekte schreiben](https://contribute.jquery.org/code/)

### Verweise auf Issues/PRs

GitHub-Issues/PRs werden in der Regel mit `gh-NUMBER` referenziert, wobei `NUMBER` die numerische ID des Issues/PRs ist. Du findest ein solches Issue/PR unter `https://github.com/jquery/jquery/issues/NUMBER`.

jQuery hat früher einen anderen Bugtracker auf Trac-Basis verwendet, erreichbar unter [bugs.jquery.com](https://bugs.jquery.com/). Er wird im Read-Only-Modus gehalten, damit auf vergangene Diskussionen verwiesen werden kann. Wenn im jQuery-Quellcode auf eines dieser Issues verwiesen wird, wird das Muster `trac-NUMBER` verwendet, wobei `NUMBER` die numerische ID des Issues ist. Du findest ein solches Issue unter `https://bugs.jquery.com/ticket/NUMBER`.

## Umgebungen, in denen jQuery verwendet werden kann

- [Browser-Unterstützung](https://jquery.com/browser-support/)
- jQuery unterstützt auch Node, Browser-Erweiterungen und andere Nicht-Browser-Umgebungen.

## Was du benötigst, um dein eigenes jQuery zu bauen

Um jQuery zu bauen, benötigst du die neueste Version von Node.js/npm und git 1.7 oder neuer. Ältere Versionen könnten funktionieren, werden aber nicht unterstützt.

Für Windows musst du [git](https://git-scm.com/downloads) und [Node.js](https://nodejs.org/en/download/) herunterladen und installieren.

macOS-Nutzer sollten [Homebrew](https://brew.sh/) installieren. Nach der Installation von Homebrew führe `brew install git` aus, um git zu installieren, und `brew install node`, um Node.js zu installieren.

Linux/BSD-Nutzer sollten ihre jeweiligen Paketmanager verwenden, um git und Node.js zu installieren, oder selbst kompilieren,
wenn sie das bevorzugen. Ganz einfach.

## Wie man sein eigenes jQuery baut

Zuerst [klone das jQuery Git-Repository](https://help.github.com/en/github/creating-cloning-and-archiving-repositories/cloning-a-repository).

Dann gehe ins jquery-Verzeichnis, installiere die Abhängigkeiten und führe das Build-Skript aus:

```bash
cd jquery
npm install
npm run build
```

Die gebaute Version von jQuery wird im `dist/`-Verzeichnis abgelegt, zusammen mit einer minimierten Kopie und der zugehörigen Map-Datei.

## Alle jQuery-Release-Dateien bauen

Um alle Varianten von jQuery zu bauen, führe folgenden Befehl aus:

```bash
npm run build:all
```

Dies erstellt alle Varianten, die jQuery in einem Release enthält, einschließlich `jquery.js`, `jquery.slim.js`, `jquery.module.js` und `jquery.slim.module.js` sowie deren zugehörigen minimierten Dateien und Sourcemaps.

`jquery.module.js` und `jquery.slim.module.js` sind [ECMAScript-Module](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Guide/Modules), die `jQuery` und `$` als benannte Exports bereitstellen und im Verzeichnis `dist-module/` statt im `dist/`-Verzeichnis abgelegt werden.

## Ein eigenes jQuery anpassen

Das Build-Skript kann verwendet werden, um eine individuelle Version von jQuery zu erstellen, die nur die benötigten Module enthält.

Jedes Modul kann ausgeschlossen werden, außer `core`. Wenn `selector` ausgeschlossen wird, wird es nicht entfernt, sondern durch einen kleinen Wrapper um das native `querySelectorAll` ersetzt (siehe unten für mehr Informationen).

### Build-Skript-Hilfe

Um die vollständige Liste der verfügbaren Optionen für das Build-Skript zu sehen, führe Folgendes aus:

```bash
npm run build -- --help
```

### Module

Um ein Modul auszuschließen, übergib seinen Pfad relativ zum `src`-Ordner (ohne `.js`-Erweiterung) an die Option `--exclude`. Wenn du die Option `--include` verwendest, werden die Standardmodule nicht eingebunden und es wird ein Build nur mit den angegebenen Modulen erstellt.

Einige Beispielmodule, die ausgeschlossen oder eingeschlossen werden können, sind:

- **ajax**: Alle AJAX-Funktionalitäten: `$.ajax()`, `$.get()`, `$.post()`, `$.ajaxSetup()`, `.load()`, Transports und AJAX-Event-Shorthands wie `.ajaxStart()`.
- **ajax/xhr**: Nur der XMLHTTPRequest-AJAX-Transport.
- **ajax/script**: Nur der `<script>`-AJAX-Transport; wird verwendet, um Skripte zu laden.
- **ajax/jsonp**: Nur der JSONP-AJAX-Transport; hängt vom ajax/script-Transport ab.
- **css**: Die `.css()`-Methode. Entfernt außerdem **alle** Module, die von css abhängen (einschließlich **effects**, **dimensions** und **offset**).
- **css/showHide**: Nicht animierte `.show()`, `.hide()` und `.toggle()`; kann ausgeschlossen werden, wenn du Klassen oder explizite `.css()`-Aufrufe verwendest, um die `display`-Eigenschaft zu setzen. Entfernt auch das **effects**-Modul.
- **deprecated**: Methoden, die als veraltet dokumentiert, aber noch nicht entfernt wurden.
- **dimensions**: Die Methoden `.width()` und `.height()`, einschließlich der `inner-` und `outer-` Varianten.
- **effects**: Die Methode `.animate()` und ihre Kurzformen wie `.slideUp()` oder `.hide("slow")`.
- **event**: Die Methoden `.on()` und `.off()` und sämtliche Event-Funktionalität.
- **event/trigger**: Die Methoden `.trigger()` und `.triggerHandler()`.
- **offset**: Die Methoden `.offset()`, `.position()`, `.offsetParent()`, `.scrollLeft()` und `.scrollTop()`.
- **wrap**: Die Methoden `.wrap()`, `.wrapAll()`, `.wrapInner()` und `.unwrap()`.
- **core/ready**: Schließe das ready-Modul aus, wenn du deine Skripte am Ende des Body platzierst. Alle mit `jQuery()` gebundenen ready-Callbacks werden sofort aufgerufen. Allerdings ist `jQuery(document).ready()` dann keine Funktion und `.on("ready", ...)` oder ähnliches wird nicht ausgelöst.
- **deferred**: Schließe jQuery.Deferred aus. Dadurch werden auch alle Module ausgeschlossen, die von Deferred abhängen, einschließlich **ajax**, **effects** und **queue**, aber **core/ready** wird durch **core/ready-no-deferred** ersetzt.
- **exports/global**: Entfernt das Hinzufügen der globalen jQuery-Variablen ($ und jQuery) zum window.
- **exports/amd**: Entfernt die AMD-Definition.

- **selector**: Die vollständige jQuery-Selektor-Engine. Wenn dieses Modul ausgeschlossen wird, wird es durch eine rudimentäre Selektor-Engine auf Basis der Browser-Methode `querySelectorAll` ersetzt, die keine jQuery-Selektor-Erweiterungen oder erweiterte Semantik unterstützt. Siehe die Datei [selector-native.js](https://github.com/jquery/jquery/blob/main/src/selector-native.js) für Details.

*Hinweis*: Das Ausschließen des vollständigen `selector`-Moduls schließt auch alle jQuery-Selektor-Erweiterungen aus (wie `effects/animatedSelector` und `css/hiddenVisibleSelectors`).

##### AMD-Name

Du kannst den Modulnamen für die AMD-Definition von jQuery festlegen. Standardmäßig ist er auf "jquery" gesetzt, was gut mit Plugins und Drittanbieter-Bibliotheken funktioniert, aber es kann Fälle geben, in denen du ihn ändern möchtest. Übergebe ihn an den `--amd`-Parameter:

```bash
npm run build -- --amd="custom-name"
```

Oder lasse den Namen leer, um anonym zu definieren.

```bash
npm run build -- --amd
```

##### Dateiname und Verzeichnis

Der Standardname für die gebaute jQuery-Datei ist `jquery.js`; sie wird im Verzeichnis `dist/` abgelegt. Es ist möglich, den Dateinamen mit `--filename` und das Verzeichnis mit `--dir` zu ändern. `--dir` ist relativ zum Projektstamm.

```bash
npm run build -- --slim --filename="jquery.slim.js" --dir="/tmp"
```

Dies würde eine schlanke Version von jQuery erstellen und unter `tmp/jquery.slim.js` ablegen.

##### ECMAScript-Modul (ESM)-Modus

Standardmäßig erzeugt jQuery eine reguläre JavaScript-Datei für Skripte. Du kannst auch ein ECMAScript-Modul erzeugen, das `jQuery` als Default-Export exportiert, indem du den Parameter `--esm` verwendest:

```bash
npm run build -- --filename=jquery.module.js --esm
```

##### Factory-Modus

Standardmäßig hängt jQuery von einem globalen `window` ab. Für Umgebungen, die kein solches haben, kannst du ein Factory-Build erzeugen, das eine Funktion bereitstellt, welche `window` als Parameter akzeptiert, den du extern angeben kannst (siehe [`README` des veröffentlichten Pakets](build/fixtures/README.md) für Anweisungen zur Verwendung). Du kannst ein solches Factory-Build mit dem Parameter `--factory` erzeugen:

```bash
npm run build -- --filename=jquery.factory.js --factory
```

Diese Option kann mit anderen wie `--esm` oder `--slim` kombiniert werden:

```bash
npm run build -- --filename=jquery.factory.slim.module.js --factory --esm --slim --dir="/dist-module"
```

#### Beispiele für eigene Builds

Erstelle einen eigenen Build mit `npm run build`, indem du die auszuschließenden Module auflistest. Das Ausschließen eines Top-Level-Moduls schließt auch das entsprechende Modulverzeichnis aus.

Schließe alle **ajax**-Funktionalitäten aus:

```bash
npm run build -- --exclude=ajax
```

Das Ausschließen von **css** entfernt alle Module, die von CSS abhängen: **effects**, **offset**, **dimensions**.

```bash
npm run build -- --exclude=css
```

Schließe mehrere Module aus (`-e` ist ein Alias für `--exclude`):

```bash
npm run build -- -e ajax/jsonp -e css -e deprecated -e dimensions -e effects -e offset -e wrap
```

Es gibt einen speziellen Alias, um einen Build mit der gleichen Konfiguration wie der offizielle jQuery Slim Build zu erzeugen:

```bash
npm run build -- --filename=jquery.slim.js --slim
```

Oder, um den Slim-Build als esm-Modul zu erstellen:

```bash
npm run build -- --filename=jquery.slim.module.js --slim --esm
```
```

*Inoffizielle, benutzerdefinierte Builds werden nicht regelmäßig getestet. Verwendung auf eigene Gefahr.*

## Ausführen der Unit-Tests

Stellen Sie sicher, dass Sie die notwendigen Abhängigkeiten installiert haben:

```bash
npm install
```

Starten Sie `npm start`, um jQuery während der Arbeit automatisch zu bauen:

```bash
npm start
```

Führen Sie die Unit-Tests mit einem lokalen Server aus, der PHP unterstützt. Stellen Sie sicher, dass Sie die Seite aus dem Stammverzeichnis und nicht aus dem "test"-Verzeichnis starten. Es ist keine Datenbank erforderlich. Vorgefertigte lokale PHP-Server sind für Windows und Mac verfügbar. Hier einige Optionen:

- Windows: [WAMP herunterladen](https://www.wampserver.com/en/)
- Mac: [MAMP herunterladen](https://www.mamp.info/en/downloads/)
- Linux: [LAMP einrichten](https://www.linux.com/training-tutorials/easy-lamp-server-installation/)
- [Mongoose (meiste Plattformen)](https://code.google.com/p/mongoose/)

## Wesentliches zu Git

Da der Quellcode mit dem Versionskontrollsystem Git verwaltet wird, ist es nützlich, einige verwendete Funktionen zu kennen.

### Bereinigen

Wenn Sie Ihr Arbeitsverzeichnis auf den Status von Upstream zurücksetzen möchten, können Sie die folgenden Befehle verwenden (beachten Sie, dass danach alles, woran Sie gearbeitet haben, weg ist):

```bash
git reset --hard upstream/main
git clean -fdx
```

### Rebasen

Für Feature-/Themen-Branches sollten Sie immer das `--rebase`-Flag bei `git pull` verwenden oder, wenn Sie häufig viele temporäre "für einen GitHub Pull Request"-Branches verwalten, können Sie Folgendes ausführen, um dies zu automatisieren:

```bash
git config branch.autosetuprebase local
```

(siehe `man git-config` für weitere Informationen)

### Umgang mit Merge-Konflikten

Wenn Sie beim Mergen auf Merge-Konflikte stoßen, können Sie anstatt die Konfliktdateien manuell zu bearbeiten, die Funktion `git mergetool` verwenden. Auch wenn das Standard-Tool `xxdiff` altmodisch aussieht, ist es ziemlich nützlich.

Folgende Befehle können dort verwendet werden:

- `Strg + Alt + M` - Automatisches Mergen so weit wie möglich
- `b` - Zum nächsten Merge-Konflikt springen
- `s` - Die Reihenfolge der Konfliktzeilen ändern
- `u` - Einen Merge rückgängig machen
- `linke Maustaste` - Einen Block als Gewinner markieren
- `mittlere Maustaste` - Eine Zeile als Gewinner markieren
- `Strg + S` - Speichern
- `Strg + Q` - Beenden

## [QUnit](https://api.qunitjs.com) Referenz

### Testmethoden

```js
expect( numAssertions );
stop();
start();
```

*Hinweis*: QUnits spätere Hinzufügung eines Arguments zu stop/start wird in dieser Testsuite ignoriert, so dass start und stop als Callbacks ohne Berücksichtigung ihrer Parameter übergeben werden können.

### Test-Assertions

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

## Referenz der Convenience-Methoden für die Testsuite

Siehe [test/data/testinit.js](https://raw.githubusercontent.com/jquery/jquery/main/test/data/testinit.js).

### Gibt ein Array von Elementen mit den angegebenen IDs zurück

```js
q( ... );
```

Beispiel:

```js
q( "main", "foo", "bar" );

=> [ div#main, span#foo, input#bar ]
```

### Prüft, ob eine Selektion den angegebenen IDs entspricht

```js
t( testName, selector, [ "array", "of", "ids" ] );
```

Beispiel:

```js
t("Check for something", "//[a]", ["foo", "bar"]);
```

### Löst ein natives DOM-Event aus, ohne jQuery zu verwenden

```js
fireNative( node, eventType );
```

Beispiel:

```js
fireNative( jQuery( "#elem" )[ 0 ], "click" );
```

### Fügt der URL eine Zufallszahl hinzu, um Caching zu verhindern

```js
url( "some/url" );
```

Beispiel:

```js
url( "index.html" );

=> "data/index.html?10538358428943"


url( "mock.php?foo=bar" );

=> "data/mock.php?foo=bar&10538358345554"
```

### Tests in einem iframe ausführen

Einige Tests erfordern möglicherweise ein anderes Dokument als das Standard-Test-Setup und können in einem separaten iframe ausgeführt werden. Der eigentliche Testcode und die Assertions verbleiben in den Haupt-Testdateien von jQuery; nur das minimale Test-Setup-Markup und Setup-Code sollten in die iframe-Datei gelegt werden.

```js
testIframe( testName, fileName,
  function testCallback(
      assert, jQuery, window, document,
	  [ additional args ] ) {
	...
  } );
```

Dies lädt eine Seite, indem eine URL mit fileName `"./data/" + fileName` gebaut wird. Die iframe-Seite bestimmt, wann der Callback im Test ausgelöst wird, indem sie das Skript "/test/data/iframeTest.js" einbindet und `startIframeTest( [ additional args ] )` bei Bedarf aufruft. Oft ist dies nach document ready oder wenn `window.onload` ausgelöst wurde.

Der `testCallback` erhält das von `testIframe` für diesen Test erstellte QUnit-`assert`-Objekt, gefolgt vom globalen `jQuery`, `window` und `document` aus dem iframe. Wenn der iframe-Code irgendwelche Argumente an `startIframeTest` übergibt, folgen diese nach dem Argument `document`.

## Fragen?

Wenn Sie Fragen haben, können Sie diese gerne im
[Developing jQuery Core Forum](https://forum.jquery.com/developing-jquery-core) oder in #jquery auf [libera](https://web.libera.chat/) stellen.
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---