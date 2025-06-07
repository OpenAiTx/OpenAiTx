<p align="center"><img src="https://raw.githubusercontent.com/MonkeyGG2/monkeygg2.github.io/main/imgs/icon-256-256.png" height="200"></p>

<div align="center">
<a href="https://discord.com/invite/yPYyZ78qCB"><img alt="Discord" src="https://img.shields.io/discord/1051660971900407839?label=discord"></a>
<a href="https://github.com/MonkeyGG2/monkeygg2.github.io"><img alt="Github Repo stars" src="https://img.shields.io/github/stars/MonkeyGG2/monkeygg2.github.io?label=github%20stars"></a>
<a href="https://github.com/MonkeyGG2/monkeygg2.github.io"><img alt="GitHub Repo forks" src="https://img.shields.io/github/forks/MonkeyGG2/monkeygg2.github.io?label=github%20forks"></a>
<a href="https://codeberg.org/MonkeyGG2/pages"><img alt="Codeberg Repo stars" src="https://img.shields.io/badge/dynamic/json.svg?label=codeberg%20stars&url=https://codeberg.org/api/v1/repos/MonkeyGG2/pages&query=stars_count"></a>
<a href="https://codeberg.org/MonkeyGG2/pages"><img alt="Codeberg Repo forks" src="https://img.shields.io/badge/dynamic/json.svg?label=codeberg%20forks&url=https://codeberg.org/api/v1/repos/MonkeyGG2/pages&query=forks_count"></a>
<a href="http://www.wtfpl.net/about"><img alt="License: WTFPL" src="https://img.shields.io/badge/License-WTFPL-brightgreen.svg"></a>
</div>
<h1 align="center">MonkeyGG2</h1>
<p align="center" style="opacity: 0.65;">Deine freundliche Nachbarschafts-Spieleseite.</p>
<br>

Willkommen bei MonkeyGG2, einer funktionsreichen Spieleseite, die für dich erstellt wurde! Mit über 150 Spielen zur Auswahl bietet MonkeyGG2 ein einzigartiges und anpassbares Spielerlebnis. Egal ob du Gamer, Entwickler oder ein ganz normaler Nutzer bist, MonkeyGG2 bietet eine nahtlose und angenehme Spielumgebung.

> Gib uns doch einen Stern! Besonders, wenn du dieses Repository geforkt hast oder auf andere Weise davon profitierst.

## Funktionen

-   Über 150 Spiele
-   Einfach zu bedienen
-   Einfach zu deployen
-   Anpassbar
-   Proxy
-   Und mehr...

## Anpassung

### Einstellungen

#### Cloaking

Cloaking bezieht sich darauf, die Seite in einem `about:blank` Tab zu öffnen. Dieses Verhalten ist standardmäßig erzwungen, kann aber deaktiviert werden. Voreinstellungen für den Weiterleitungslink sind verfügbar, können aber auch manuell konfiguriert werden.

#### Masking

Masking bezieht sich auf das Ändern des Symbols und des Tab-Titels des about:blank Tabs. Voreinstellungen für Symbol und Tab-Titel sind verfügbar, können aber ebenfalls manuell konfiguriert werden.

#### Shortcuts

Eigene Tastenkombinationen können erstellt werden, um verschiedene Aufgaben auszuführen. Zum Beispiel das Spiel beenden, den Tab maskieren oder benutzerdefiniertes JavaScript ausführen – all das wird unterstützt.
> Hinweis: Wenn du eigenes JavaScript ausführst, stelle sicher, dass du weißt, was du tust. Falls etwas schiefgeht, hilft ein Neuladen der Seite immer weiter.

#### Theme

Die folgenden Theme-Anpassungen werden derzeit unterstützt:
- Hintergrundanimation umschalten (bei Performance-Bedenken im Spielbetrieb wird sie automatisch deaktiviert)
- Hintergrundfarbe
- Blockfarbe
- Buttonfarbe
- Spielfarbe
- Hover-Farbe
- Scrollbar-Farbe
- Scroll-Track-Farbe
- Schriftfarbe

> Hinweis: Falls du versehentlich die Farben so veränderst, dass die Seite unbenutzbar wird, musst du deine Cookies und den lokalen Speicher löschen.

### Erweiterte Anpassung

> Hinweis: Die folgenden Anpassungen sind nur für Besitzer dieses Repositorys oder Forks davon verfügbar.

Die Datei `config.jsonc` ist so formatiert, dass sie die Konfiguration für die gesamte Seite enthält. Aktuell werden folgende Elemente unterstützt:
- Spiele
- Themes (kommt bald)
- Proxy-Konfiguration

#### Spiele

Jeder Spieleintrag hat einen Schlüssel, der den Anzeigenamen des Spiels repräsentiert. Der Wert sollte ein Objekt mit drei Schlüssel-Wert-Paaren sein:
- `"path"`: Pfad zum Spiel aus dem Verzeichnis `./games`
- `"aliases"`: Liste von Alternativnamen für das Spiel zur Verbesserung der Suche
- `"categories"`: Liste von Kategorien, zu denen das Spiel gehört (Unterstützung für Icons kommt bald)

Das manuelle Hinzufügen eines Eintrags ist möglich, aber mühsam, besonders wenn du die Liste alphanumerisch sortieren möchtest (für die Funktionalität ist das aber nicht notwendig!).
Deshalb wurde das Skript `add-game-entry.js` erstellt – ein einfacher Weg, ein neues Spiel der Konfiguration hinzuzufügen, ohne die Datei manuell bearbeiten zu müssen.

```bash
# Du kannst jede JS-Laufzeitumgebung wie node.js, bun oder deno verwenden.
# In diesem Beispiel wird bun genutzt, da Abhängigkeiten automatisch installiert werden.
bun add-game-script.js
# Beantworte die folgenden Fragen und die Konfiguration wird aktualisiert.
```

#### Themes

Theme-Standard noch nicht implementiert (TODO)

#### Proxy

Proxy-Konfigurationsoptionen befinden sich unter dem Schlüssel **"config"**. 
Der Wert für den Schlüssel `"proxy"` ist ein boolescher Wert, der die Proxy-Funktion aktiviert oder deaktiviert. Ist `"proxy"` auf false gesetzt, erscheint beim Versuch, auf den Proxy zuzugreifen, ein Fehlerdialog.
Der Wert für den Schlüssel `"proxyPath"` ist der Pfad zum Proxy. Es kann ein absoluter oder relativer Pfad sein, aber der Proxy muss **CORS** unterstützen, da die Proxy-Seite als iframe auf der Seite angezeigt wird.


## Bereitstellung

### Ohne Proxy

[![Run on Replit](https://binbashbanana.github.io/deploy-buttons/buttons/remade/replit.svg)](https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Remix on Glitch](https://binbashbanana.github.io/deploy-buttons/buttons/remade/glitch.svg)](https://glitch.com/edit/#!/import/github/MonkeyGG2/monkeygg2.github.io)
[![Deploy to IBM Cloud](https://binbashbanana.github.io/deploy-buttons/buttons/remade/ibmcloud.svg)](https://cloud.ibm.com/devops/setup/deploy?repository=https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Deploy to Amplify Console](https://binbashbanana.github.io/deploy-buttons/buttons/remade/amplifyconsole.svg)](https://console.aws.amazon.com/amplify/home#/deploy?repo=https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Run on Google Cloud](https://binbashbanana.github.io/deploy-buttons/buttons/remade/googlecloud.svg)](https://deploy.cloud.run/?git_repo=https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Deploy to Oracle Cloud](https://binbashbanana.github.io/deploy-buttons/buttons/remade/oraclecloud.svg)](https://cloud.oracle.com/resourcemanager/stacks/create?zipUrl=https://github.com/MonkeyGG2/monkeygg2.github.io/archive/refs/heads/main.zip)
[![Deploy with Vercel](https://binbashbanana.github.io/deploy-buttons/buttons/remade/vercel.svg)](https://vercel.com/new/clone?repository-url=https%3A%2F%2Fgithub.com%2FMonkeyGG2%2Fmonkeygg2.github.io)
[![Deploy with Netlify](https://binbashbanana.github.io/deploy-buttons/buttons/remade/netlify.svg)](https://app.netlify.com/start/deploy?repository=https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Deploy to Render](https://binbashbanana.github.io/deploy-buttons/buttons/remade/render.svg)](https://render.com/deploy?repo=https://github.com/MonkeyGG2/monkeygg2.github.io)

Alternativ kannst du dieses Repository einfach auf [GitHub](https://github.com/MonkeyGG2/monkeygg2.github.io) oder [Codeberg](https://codeberg.org/MonkeyGG2/pages) forken und auf GitHub Pages bzw. Codeberg Pages deployen.

### Mit Proxy

Besuche die [VioletGG2](https://github.com/MonkeyGG2/VioletGG2) Seite, um mehr über das Hosting von MonkeyGG2 mit Proxy zu erfahren.

### Lokale Ausführung

```bash
# WARNUNG: Wenn du einen Ordner namens "monkeygg2" hast, werden alle Dateien in diesem Ordner entfernt!
# Bitte ändere ggf. den Namen im folgenden Befehl.
git clone https://github.com/MonkeyGG2/monkeygg2.github.io.git monkeygg2
cd monkeygg2
# Von hier aus kannst du jedes Tool für statische Server verwenden, "live-server" aus npm wird hier genutzt
npm install -g live-server # nur, wenn noch nicht installiert
npx live-server
```

## Lizenz

Veröffentlicht unter der WTFPL-Lizenz. Siehe [hier](https://github.com/MonkeyGG2/monkeygg2.github.io/blob/main/LICENSE) für weitere Details.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---