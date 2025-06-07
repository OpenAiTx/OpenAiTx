<p align="center"><img src="https://ohmyzsh.s3.amazonaws.com/omz-ansi-github.png" alt="Oh My Zsh"></p>

Oh My Zsh ist ein Open-Source-, gemeinschaftsbasiertes Framework zur Verwaltung deiner [zsh](https://www.zsh.org/) Konfiguration.

Klingt langweilig. Versuchen wir es nochmal.

**Oh My Zsh wird dich nicht zum 10x-Entwickler machen... aber du könntest dich so fühlen.**

Nach der Installation wird deine Terminal-Shell zum Gesprächsthema der Stadt _oder du bekommst dein Geld zurück!_ Mit jedem Tastendruck am Kommando-Prompt nutzt du Hunderte leistungsstarker Plugins und wunderschöner Themes. Fremde werden dich in Cafés ansprechen und fragen: _"Das ist ja erstaunlich! Bist du so eine Art Genie?"_

Endlich bekommst du die Aufmerksamkeit, die du immer verdient hast. ...oder du nutzt die gewonnene Zeit, um öfter Zahnseide zu verwenden. 😬

Um mehr zu erfahren, besuche [ohmyz.sh](https://ohmyz.sh), folge [@ohmyzsh](https://x.com/ohmyzsh) auf X (früher Twitter) und tritt unserem [Discord](https://discord.gg/ohmyzsh) bei.

[![CI](https://github.com/ohmyzsh/ohmyzsh/workflows/CI/badge.svg)](https://github.com/ohmyzsh/ohmyzsh/actions?query=workflow%3ACI)
[![X (formerly Twitter) Follow](https://img.shields.io/twitter/follow/ohmyzsh?label=%40ohmyzsh&logo=x&style=flat)](https://twitter.com/intent/follow?screen_name=ohmyzsh)
[![Mastodon Follow](https://img.shields.io/mastodon/follow/111169632522566717?label=%40ohmyzsh&domain=https%3A%2F%2Fmstdn.social&logo=mastodon&style=flat)](https://mstdn.social/@ohmyzsh)
[![Discord server](https://img.shields.io/discord/642496866407284746)](https://discord.gg/ohmyzsh)
[![Gitpod ready](https://img.shields.io/badge/Gitpod-ready-blue?logo=gitpod)](https://gitpod.io/#https://github.com/ohmyzsh/ohmyzsh)

<details>
<summary>Inhaltsverzeichnis</summary>

- [Erste Schritte](#getting-started)
  - [Betriebssystem-Kompatibilität](#operating-system-compatibility)
  - [Voraussetzungen](#prerequisites)
  - [Basisinstallation](#basic-installation)
    - [Manuelle Überprüfung](#manual-inspection)
- [Oh My Zsh verwenden](#using-oh-my-zsh)
  - [Plugins](#plugins)
    - [Plugins aktivieren](#enabling-plugins)
    - [Plugins verwenden](#using-plugins)
  - [Themes](#themes)
    - [Theme auswählen](#selecting-a-theme)
  - [FAQ](#faq)
- [Erweiterte Themen](#advanced-topics)
  - [Erweiterte Installation](#advanced-installation)
    - [Benutzerdefiniertes Verzeichnis](#custom-directory)
    - [Unbeaufsichtigte Installation](#unattended-install)
    - [Installation aus einem geforkten Repository](#installing-from-a-forked-repository)
    - [Manuelle Installation](#manual-installation)
  - [Installationsprobleme](#installation-problems)
  - [Eigene Plugins und Themes](#custom-plugins-and-themes)
  - [GNU ls unter macOS und freeBSD aktivieren](#enable-gnu-ls-in-macos-and-freebsd-systems)
  - [Aliase überspringen](#skip-aliases)
  - [Asynchrones git-Prompt](#async-git-prompt)
- [Updates erhalten](#getting-updates)
  - [Update-Verbosity](#updates-verbosity)
  - [Manuelle Updates](#manual-updates)
- [Oh My Zsh deinstallieren](#uninstalling-oh-my-zsh)
- [Wie kann ich zu Oh My Zsh beitragen?](#how-do-i-contribute-to-oh-my-zsh)
  - [Sende uns keine Themes](#do-not-send-us-themes)
- [Mitwirkende](#contributors)
- [Folge uns](#follow-us)
- [Merchandise](#merchandise)
- [Lizenz](#license)
- [Über Planet Argon](#about-planet-argon)

</details>

## Erste Schritte

### Betriebssystem-Kompatibilität

| Betriebssystem | Status |
| :------------- | :----: |
| Android        |   ✅   |
| freeBSD        |   ✅   |
| LCARS          |   🛸   |
| Linux          |   ✅   |
| macOS          |   ✅   |
| OS/2 Warp      |   ❌   |
| Windows (WSL2) |   ✅   |

### Voraussetzungen

- [Zsh](https://www.zsh.org) sollte installiert sein (v4.3.9 oder neuer ist ausreichend, empfohlen wird 5.0.8 oder neuer). Falls nicht vorinstalliert (prüfe mit `zsh --version`), siehe folgende Wiki-Anleitung: [Installing ZSH](https://github.com/ohmyzsh/ohmyzsh/wiki/Installing-ZSH)
- `curl` oder `wget` sollte installiert sein
- `git` sollte installiert sein (empfohlen v2.4.11 oder höher)

### Basisinstallation

Oh My Zsh wird installiert, indem einer der folgenden Befehle im Terminal ausgeführt wird. Die Installation ist über die Kommandozeile mit `curl`, `wget` oder einem ähnlichen Tool möglich.

| Methode   | Befehl                                                                                           |
| :-------- | :------------------------------------------------------------------------------------------------ |
| **curl**  | `sh -c "$(curl -fsSL https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh)"` |
| **wget**  | `sh -c "$(wget -O- https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh)"`   |
| **fetch** | `sh -c "$(fetch -o - https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh)"` |

Alternativ ist der Installer auch außerhalb von GitHub gespiegelt. Diese URL kann nötig sein, wenn du dich in einem Land wie China oder Indien befindest (bei bestimmten ISPs), das `raw.githubusercontent.com` blockiert:

| Methode   | Befehl                                           |
| :-------- | :------------------------------------------------ |
| **curl**  | `sh -c "$(curl -fsSL https://install.ohmyz.sh/)"` |
| **wget**  | `sh -c "$(wget -O- https://install.ohmyz.sh/)"`   |
| **fetch** | `sh -c "$(fetch -o - https://install.ohmyz.sh/)"` |

_Beachte, dass jede vorherige `.zshrc` in `.zshrc.pre-oh-my-zsh` umbenannt wird. Nach der Installation kannst du die zu erhaltenden Konfigurationen in die neue `.zshrc` übernehmen._

#### Manuelle Überprüfung

Es ist ratsam, Installationsskripte von unbekannten Projekten vorher zu überprüfen. Lade dazu zuerst das Installationsskript herunter, sieh es dir an, und führe es dann aus:

```sh
wget https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh
sh install.sh
```

Falls die obige URL nicht erreichbar ist, verwende stattdessen `https://install.ohmyz.sh`.

## Oh My Zsh verwenden

### Plugins

Oh My Zsh kommt mit einer riesigen Menge an Plugins, die du nutzen kannst. Sieh im [plugins](https://github.com/ohmyzsh/ohmyzsh/tree/master/plugins)-Verzeichnis und/oder im [Wiki](https://github.com/ohmyzsh/ohmyzsh/wiki/Plugins) nach, was aktuell verfügbar ist.

#### Plugins aktivieren

Sobald du ein Plugin (oder mehrere) gefunden hast, das du mit Oh My Zsh nutzen möchtest, musst du es in der `.zshrc` aktivieren. Die zshrc-Datei findest du in deinem `$HOME`-Verzeichnis. Öffne sie mit deinem bevorzugten Texteditor und du findest eine Stelle, an der alle zu ladenden Plugins aufgeführt sind.

```sh
vi ~/.zshrc
```

Zum Beispiel könnte das so aussehen:

```sh
plugins=(
  git
  bundler
  dotenv
  macos
  rake
  rbenv
  ruby
)
```

_Beachte, dass die Plugins durch Leerzeichen (Spaces, Tabs, Zeilenumbrüche...) getrennt werden. **Keine** Kommas verwenden, sonst funktioniert es nicht._

#### Plugins verwenden

Jedes eingebaute Plugin enthält eine **README**, die es dokumentiert. Diese README zeigt die Aliase (falls das Plugin welche hinzufügt) und weitere Funktionen, die im jeweiligen Plugin enthalten sind.

### Themes

Wir geben es zu. Am Anfang waren wir bei Oh My Zsh vielleicht etwas zu begeistert von Themes. Jetzt sind über 150 Themes gebündelt. Die meisten haben [Screenshots](https://github.com/ohmyzsh/ohmyzsh/wiki/Themes) im Wiki (Wir arbeiten an Updates!). Schau sie dir an!

#### Theme auswählen

_Robbys Theme ist das Standard-Theme. Es ist nicht das schickste. Es ist nicht das einfachste. Es ist einfach das richtige (für ihn)._

Wenn du ein Theme gefunden hast, das du verwenden möchtest, musst du die Datei `~/.zshrc` bearbeiten. Dort findest du eine Umgebungsvariable (in Großbuchstaben), die so aussieht:

```sh
ZSH_THEME="robbyrussell"
```

Um ein anderes Theme zu nutzen, ändere einfach den Wert entsprechend dem Namen des gewünschten Themes. Zum Beispiel:

```sh
ZSH_THEME="agnoster" # (das ist eines der schickeren)
# siehe https://github.com/ohmyzsh/ohmyzsh/wiki/Themes#agnoster
```

<!-- prettier-ignore-start -->
> [!HINWEIS]
> Häufig siehst du Screenshots eines Zsh-Themes, probierst es aus und stellst fest, dass es bei dir anders aussieht.
>
> Das liegt daran, dass viele Themes die Installation einer [Powerline Font](https://github.com/powerline/fonts) oder einer [Nerd Font](https://github.com/ryanoasis/nerd-fonts) benötigen, um korrekt dargestellt zu werden. Ohne diese Fonts werden seltsame Prompt-Symbole angezeigt. Weitere Informationen findest du in [der FAQ](https://github.com/ohmyzsh/ohmyzsh/wiki/FAQ#i-have-a-weird-character-in-my-prompt).
>
> Beachte außerdem, dass Themes nur beeinflussen, wie dein Prompt aussieht. Das ist der Text vor oder nach dem Cursor, wo du deine Befehle eintippst. Themes steuern **nicht** die Farben deines Terminalfensters (das ist das _Farbschema_) oder die Schriftart. Diese kannst du in deinem Terminal-Emulator einstellen. Weitere Informationen findest du unter [Was ist ein Zsh-Theme?](https://github.com/ohmyzsh/ohmyzsh/wiki/FAQ#what-is-a-zsh-theme).
<!-- prettier-ignore-end -->

Öffne ein neues Terminalfenster und dein Prompt sollte nun so ähnlich aussehen:

![Agnoster theme](https://cloud.githubusercontent.com/assets/2618447/6316862/70f58fb6-ba03-11e4-82c9-c083bf9a6574.png)

Falls du kein passendes Theme gefunden hast, schau im Wiki nach [weiteren Themes](https://github.com/ohmyzsh/ohmyzsh/wiki/External-themes).

Wenn du experimentierfreudig bist, kannst du bei jedem neuen Terminalstart ein zufälliges Theme auswählen lassen.

```sh
ZSH_THEME="random" # (...bitte lass es Kuchen sein... bitte sei Kuchen..)
```

Und falls du aus einer Liste deiner Lieblingsthemes zufällig wählen möchtest:

```sh
ZSH_THEME_RANDOM_CANDIDATES=(
  "robbyrussell"
  "agnoster"
)
```

Wenn du nur weißt, welche Themes du nicht magst, kannst du diese ähnlich auf eine Ignorierliste setzen:

```sh
ZSH_THEME_RANDOM_IGNORED=(pygmalion tjkirch_mod)
```

### FAQ

Falls du weitere Fragen oder Probleme hast, findest du vielleicht eine Lösung in unserer [FAQ](https://github.com/ohmyzsh/ohmyzsh/wiki/FAQ).

## Erweiterte Themen

Wenn du gerne tiefer eintauchst, sind diese Abschnitte interessant für dich.

### Erweiterte Installation

Manche Nutzer möchten Oh My Zsh manuell installieren oder den Standardpfad bzw. andere Einstellungen anpassen, die der Installer akzeptiert (diese Einstellungen sind auch am Anfang des Installationsskripts dokumentiert).

#### Benutzerdefiniertes Verzeichnis

Der Standardpfad ist `~/.oh-my-zsh` (versteckt im Home-Verzeichnis, zugänglich mit `cd ~/.oh-my-zsh`)

Um das Installationsverzeichnis mit der Umgebungsvariable `ZSH` zu ändern, führe entweder `export ZSH=/dein/pfad` vor der Installation aus oder setze sie am Ende der Installationspipeline wie folgt:

```sh
ZSH="$HOME/.dotfiles/oh-my-zsh" sh install.sh
```

#### Unbeaufsichtigte Installation

Wenn du das Oh My Zsh-Installationsskript im Rahmen einer automatisierten Installation ausführst, kannst du das Flag `--unattended` an das Skript `install.sh` übergeben. Dadurch wird der Wechsel der Standardshell übersprungen und auch kein automatischer Start von `zsh` nach der Installation durchgeführt.

```sh
sh -c "$(curl -fsSL https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh)" "" --unattended
```

Wenn du dich in China, Indien oder einem anderen Land befindest, das `raw.githubusercontent.com` blockiert, verwende stattdessen `https://install.ohmyz.sh`.

#### Installation aus einem geforkten Repository

Das Installationsskript akzeptiert auch diese Variablen, um die Installation aus einem anderen Repository zu ermöglichen:

- `REPO` (Standard: `ohmyzsh/ohmyzsh`): erwartet das Format `owner/repository`. Wenn du diese Variable setzt, sucht der Installer nach einem Repository unter `https://github.com/{owner}/{repository}`.

- `REMOTE` (Standard: `https://github.com/${REPO}.git`): dies ist die vollständige URL des Git-Repositories. Verwende diese Einstellung, wenn du aus einem Fork installieren möchtest, der nicht auf GitHub liegt (z. B. GitLab, Bitbucket...) oder wenn du mit SSH statt HTTPS klonen möchtest (`git@github.com:user/project.git`).

  _Hinweis: Das ist nicht kompatibel mit der `REPO`-Variable. Diese Einstellung hat Vorrang._

- `BRANCH` (Standard: `master`): verwende diese Einstellung, wenn du beim Klonen einen anderen Branch als Standard auschecken möchtest. Das kann nützlich sein, um einen Pull Request zu testen oder einen anderen Branch zu verwenden.

Beispiel:

```sh
REPO=apjanke/oh-my-zsh BRANCH=edge sh install.sh
```

#### Manuelle Installation

##### 1. Repository klonen <!-- omit in toc -->

```sh
git clone https://github.com/ohmyzsh/ohmyzsh.git ~/.oh-my-zsh
```

##### 2. _Optional_: Bestehende `~/.zshrc` sichern <!-- omit in toc -->

```sh
cp ~/.zshrc ~/.zshrc.orig
```

##### 3. Neue Zsh-Konfigurationsdatei erstellen <!-- omit in toc -->

Du kannst eine neue Zsh-Konfigurationsdatei erstellen, indem du die bereitgestellte Vorlage kopierst.

```sh
cp ~/.oh-my-zsh/templates/zshrc.zsh-template ~/.zshrc
```

##### 4. Standardshell ändern <!-- omit in toc -->

```sh
chsh -s $(which zsh)
```

Du musst dich ab- und wieder anmelden, damit diese Änderung wirksam wird.

##### 5. Neue Zsh-Konfiguration initialisieren <!-- omit in toc -->

Öffne ein neues Terminalfenster, dann sollte Zsh mit Oh My Zsh-Konfiguration geladen werden.

### Installationsprobleme

Falls es bei der Installation Probleme gibt, hier ein paar häufige Lösungen.

- Möglicherweise musst du deine `PATH`-Variable in `~/.zshrc` anpassen, falls du nach dem Wechsel zu oh-my-zsh einige Befehle nicht findest.
- Wenn du manuell installiert oder den Installationspfad geändert hast, prüfe die Umgebungsvariable `ZSH` in `~/.zshrc`.

### Eigene Plugins und Themes

Um Standardfunktionen zu überschreiben, füge einfach eine neue Datei (mit der Endung `.zsh`) im Verzeichnis `custom/` hinzu.

Hast du mehrere Funktionen, die gut zusammenpassen, kannst du sie als `XYZ.plugin.zsh`-Datei in das Verzeichnis `custom/plugins/` legen und dieses Plugin dann aktivieren.

Möchtest du die Funktionalität eines mit Oh My Zsh ausgelieferten Plugins überschreiben, erstelle ein Plugin gleichen Namens im Verzeichnis `custom/plugins/`. Dieses wird dann anstelle des Originals geladen.

### GNU ls unter macOS und freeBSD aktivieren

<a name="enable-gnu-ls"></a>

Standardmäßig verwendet Oh My Zsh auf macOS- und FreeBSD-Systemen BSD-`ls`. Wenn GNU `ls` installiert ist (als `gls`-Befehl), kannst du es stattdessen verwenden. Dazu folgende zstyle-Konfiguration vor dem Laden von `oh-my-zsh.sh` verwenden:

```zsh
zstyle ':omz:lib:theme-and-appearance' gnu-ls yes
```

_Hinweis: Das ist nicht kompatibel mit `DISABLE_LS_COLORS=true`_

### Aliase überspringen

<a name="remove-directories-aliases"></a>

Wenn du die Standard-Oh My Zsh-Aliase (die in `lib/*` definiert sind) oder Plugin-Aliase überspringen möchtest, kannst du folgende Einstellungen in deiner `~/.zshrc` **vor dem Laden von Oh My Zsh** verwenden. Es gibt verschiedene Möglichkeiten, Aliase zu überspringen, je nach Bedarf.

```sh
# Alle Aliase in lib-Dateien und aktivierten Plugins überspringen
zstyle ':omz:*' aliases no

# Alle Aliase in lib-Dateien überspringen
zstyle ':omz:lib:*' aliases no
# Nur Aliase im directories.zsh-lib-File überspringen
zstyle ':omz:lib:directories' aliases no

# Alle Plugin-Aliase überspringen
zstyle ':omz:plugins:*' aliases no
# Nur die Aliase vom git-Plugin überspringen
zstyle ':omz:plugins:git' aliases no
```

Du kannst diese Einstellungen auch kombinieren, wobei spezifischere Bereiche Vorrang haben:

```sh
# Alle Plugin-Aliase überspringen, außer für das git-Plugin
zstyle ':omz:plugins:*' aliases no
zstyle ':omz:plugins:git' aliases yes
```

Eine frühere Version dieser Funktion nutzte folgende Einstellung, die entfernt wurde:

```sh
zstyle ':omz:directories' aliases no
```

Stattdessen kannst du nun Folgendes verwenden:

```sh
zstyle ':omz:lib:directories' aliases no
```

#### Hinweis <!-- omit in toc -->

> Diese Funktion befindet sich derzeit in der Testphase und kann sich zukünftig ändern. Sie ist aktuell nicht kompatibel mit Plugin-Managern wie zpm oder zinit, die das Init-Skript (`oh-my-zsh.sh`) nicht einbinden, in dem diese Funktion umgesetzt ist.

> Sie erkennt auch keine "Aliase", die als Funktionen definiert sind (z. B. `gccd`, `ggf` oder `ggl` aus dem git-Plugin).

### Asynchrones git-Prompt

Asynchrone Prompt-Funktionen sind ein experimentelles Feature (seit 3. April 2024), das es Oh My Zsh ermöglicht, Prompt-Informationen asynchron zu rendern. Das kann die Prompt-Performance verbessern, funktioniert aber möglicherweise nicht mit allen Setups. Wenn es Probleme gibt, kannst du das Feature deaktivieren, indem du Folgendes in deiner .zshrc **vor** dem Laden von Oh My Zsh setzt:

```sh
zstyle ':omz:alpha:lib:git' async-prompt no
```

Falls das git-Prompt einfach nicht mehr erscheint, versuche, es mit folgender Konfiguration zu erzwingen (ebenfalls vor dem Laden von `oh-my-zsh.sh`). Falls es trotzdem nicht funktioniert, öffne bitte ein Issue.

```sh
zstyle ':omz:alpha:lib:git' async-prompt force
```

## Updates erhalten

Standardmäßig wirst du alle 2 Wochen aufgefordert, nach Updates zu suchen. Du kannst andere Update-Modi wählen, indem du eine Zeile in deine `~/.zshrc` **vor** dem Laden von Oh My Zsh einfügst:

1. Automatisches Update ohne Bestätigungsabfrage:

   ```sh
   zstyle ':omz:update' mode auto
   ```

2. Nur eine Erinnerung alle paar Tage, wenn Updates verfügbar sind:

   ```sh
   zstyle ':omz:update' mode reminder
   ```

3. Automatische Updates komplett deaktivieren:

   ```sh
   zstyle ':omz:update' mode disabled
   ```

HINWEIS: Du kannst steuern, wie oft Oh My Zsh nach Updates sucht, mit folgender Einstellung:

```sh
# Prüft alle 7 Tage auf Updates
zstyle ':omz:update' frequency 7
# Prüft bei jedem Terminalstart (nicht empfohlen)
zstyle ':omz:update' frequency 0
```

### Update-Verbosity

Du kannst die Update-Ausgabe mit folgenden Einstellungen steuern:

```sh
zstyle ':omz:update' verbose default # Standard-Update-Prompt

zstyle ':omz:update' verbose minimal # nur wenige Zeilen

zstyle ':omz:update' verbose silent # nur Fehler
```

### Manuelle Updates

Wenn du jederzeit ein Update durchführen möchtest (z. B. weil ein neues Plugin veröffentlicht wurde und du nicht warten möchtest), führe einfach aus:

```sh
omz update
```

> [!HINWEIS]
> Wenn du diesen Prozess in einem Skript automatisieren willst, rufe direkt das `upgrade`-Skript auf:
>
> ```sh
> $ZSH/tools/upgrade.sh
> ```
>
> Weitere Optionen findest du in der [FAQ: Wie aktualisiere ich Oh My Zsh?](https://github.com/ohmyzsh/ohmyzsh/wiki/FAQ#how-do-i-update-oh-my-zsh).
>
> **DIE VERWENDUNG VON `omz update --unattended` WURDE ENTFERNT, DA ES NEBENWIRKUNGEN HAT.**

Magie! 🎉

## Oh My Zsh deinstallieren

Oh My Zsh ist nicht für jeden. Wir werden dich vermissen, aber wir wollen dir einen einfachen Abschied ermöglichen.

Wenn du `oh-my-zsh` deinstallieren möchtest, führe einfach `uninstall_oh_my_zsh` in der Kommandozeile aus. Dadurch wird Oh My Zsh entfernt und deine vorherige `bash`- oder `zsh`-Konfiguration wiederhergestellt.

## Wie kann ich zu Oh My Zsh beitragen?

Bevor du an unserer großartigen Community teilnimmst, lese bitte den [Code of Conduct](CODE_OF_CONDUCT.md).

Ich bin weit davon entfernt, ein [Zsh](https://www.zsh.org/)-Experte zu sein, und vermute, es gibt viele Wege zur Verbesserung – wenn du Ideen hast, wie die Konfiguration einfacher zu warten (und schneller) gemacht werden kann, zögere nicht, einen Fork zu erstellen und Pull Requests zu schicken!

Wir brauchen auch Leute, die Pull Requests testen. Schau dir [die offenen Issues](https://github.com/ohmyzsh/ohmyzsh/issues) an und hilf, wo du kannst.

Weitere Infos findest du unter [Contributing](CONTRIBUTING.md).

### Sende uns keine Themes

Wir haben (mehr als) genug Themes für den Moment. Bitte füge dein Theme der [External Themes](https://github.com/ohmyzsh/ohmyzsh/wiki/External-themes) Wiki-Seite hinzu.

## Mitwirkende

Oh My Zsh hat eine lebendige Community von glücklichen Nutzern und tollen Mitwirkenden. Ohne ihre Zeit und Hilfe wäre es nicht so großartig.

Vielen Dank!

<a href="https://github.com/ohmyzsh/ohmyzsh/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=ohmyzsh/ohmyzsh" width="100%"/>
</a>

## Folge uns

Wir sind in sozialen Medien aktiv:

- [@ohmyzsh](https://x.com/ohmyzsh) auf X (früher Twitter). Folge uns!
- [Facebook](https://www.facebook.com/Oh-My-Zsh-296616263819290/) poke uns.
- [Instagram](https://www.instagram.com/_ohmyzsh/) tagge uns in deinem Oh My Zsh-Post!
- [Discord](https://discord.gg/ohmyzsh) zum Chatten!

## Merchandise

Wir haben [Sticker, Shirts und Kaffeetassen](https://shop.planetargon.com/collections/oh-my-zsh?utm_source=github) für dich, um deine Liebe zu Oh My Zsh zu zeigen. Du wirst wieder zum Gesprächsthema der Stadt!

## Lizenz

Oh My Zsh wird unter der [MIT-Lizenz](LICENSE.txt) veröffentlicht.

## Über Planet Argon

![Planet Argon](https://pa-github-assets.s3.amazonaws.com/PARGON_logo_digital_COL-small.jpg)

Oh My Zsh wurde vom Team von [Planet Argon](https://www.planetargon.com/?utm_source=github) gestartet, einer [Ruby on Rails-Entwicklungsagentur](https://www.planetargon.com/services/ruby-on-rails-development?utm_source=github). Schau dir auch unsere [anderen Open-Source-Projekte](https://www.planetargon.com/open-source?utm_source=github) an.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---