![terminal-logos](https://github.com/microsoft/terminal/assets/91625426/333ddc76-8ab2-4eb4-a8c0-4d7b953b1179)

[![Terminal Build Status](https://dev.azure.com/shine-oss/terminal/_apis/build/status%2FTerminal%20CI?branchName=main)](https://dev.azure.com/shine-oss/terminal/_build/latest?definitionId=1&branchName=main)

# Willkommen im Windows Terminal-, Konsolen- und Kommandozeilen-Repository

<details>
  <summary><strong>Inhaltsverzeichnis</strong></summary>

- [Installation und Ausführung von Windows Terminal](#installation-und-ausführung-von-windows-terminal)
  - [Microsoft Store \[Empfohlen\]](#microsoft-store-empfohlen)
  - [Weitere Installationsmethoden](#weitere-installationsmethoden)
    - [Über GitHub](#über-github)
    - [Über Windows Package Manager CLI (auch bekannt als winget)](#über-windows-package-manager-cli-auch-bekannt-als-winget)
    - [Über Chocolatey (inoffiziell)](#über-chocolatey-inoffiziell)
    - [Über Scoop (inoffiziell)](#über-scoop-inoffiziell)
- [Installation von Windows Terminal Canary](#installation-von-windows-terminal-canary)
- [Windows Terminal Roadmap](#windows-terminal-roadmap)
- [Überblick Terminal & Konsole](#überblick-terminal--konsole)
  - [Windows Terminal](#windows-terminal)
  - [Der Windows Console Host](#der-windows-console-host)
  - [Geteilte Komponenten](#geteilte-komponenten)
  - [Erstellung des neuen Windows Terminals](#erstellung-des-neuen-windows-terminals)
- [Ressourcen](#ressourcen)
- [FAQ](#faq)
  - [Ich habe das neue Terminal gebaut und ausgeführt, aber es sieht aus wie die alte Konsole](#ich-habe-das-neue-terminal-gebaut-und-ausgeführt-aber-es-sieht-aus-wie-die-alte-konsole)
- [Dokumentation](#dokumentation)
- [Mitarbeit](#mitarbeit)
- [Kommunikation mit dem Team](#kommunikation-mit-dem-team)
- [Entwicklerhinweise](#entwicklerhinweise)
- [Voraussetzungen](#voraussetzungen)
- [Code kompilieren](#code-kompilieren)
  - [Kompilieren in PowerShell](#kompilieren-in-powershell)
  - [Kompilieren in Cmd](#kompilieren-in-cmd)
- [Ausführen & Debuggen](#ausführen--debuggen)
  - [Hinweise zur Programmierung](#hinweise-zur-programmierung)
- [Verhaltenskodex](#verhaltenskodex)

</details>

<br />

Dieses Repository enthält den Quellcode für:

* [Windows Terminal](https://aka.ms/terminal)
* [Windows Terminal Preview](https://aka.ms/terminal-preview)
* Den Windows Console Host (`conhost.exe`)
* Komponenten, die von beiden Projekten gemeinsam genutzt werden
* [ColorTool](./src/tools/ColorTool)
* [Beispielprojekte](./samples),
  die zeigen, wie die Windows Console APIs verwendet werden können

Verwandte Repositories sind:

* [Windows Terminal Dokumentation](https://docs.microsoft.com/windows/terminal)
  ([Repo: Dokumentation beitragen](https://github.com/MicrosoftDocs/terminal))
* [Console API Dokumentation](https://github.com/MicrosoftDocs/Console-Docs)
* [Cascadia Code Schriftart](https://github.com/Microsoft/Cascadia-Code)

## Installation und Ausführung von Windows Terminal

> [!HINWEIS]
> Windows Terminal erfordert Windows 10 2004 (Build 19041) oder neuer

### Microsoft Store [Empfohlen]

Installieren Sie das [Windows Terminal aus dem Microsoft Store][store-install-link].
Dadurch erhalten Sie immer automatisch die neueste Version, sobald wir neue Builds veröffentlichen.

Dies ist unsere bevorzugte Installationsmethode.

### Weitere Installationsmethoden

#### Über GitHub

Für Nutzer, die Windows Terminal nicht aus dem Microsoft Store installieren können, können veröffentlichte Builds manuell von der [Releases-Seite](https://github.com/microsoft/terminal/releases) dieses Repositories heruntergeladen werden.

Laden Sie die Datei `Microsoft.WindowsTerminal_<versionNumber>.msixbundle` aus dem Abschnitt **Assets** herunter. Um die App zu installieren, können Sie einfach doppelt auf die `.msixbundle`-Datei klicken, und das App-Installationsprogramm sollte automatisch starten. Falls dies aus irgendeinem Grund fehlschlägt, versuchen Sie den folgenden Befehl in einer PowerShell-Eingabeaufforderung:

```powershell
# HINWEIS: Wenn Sie PowerShell 7+ verwenden, führen Sie bitte
# Import-Module Appx -UseWindowsPowerShell
# aus, bevor Sie Add-AppxPackage verwenden.

Add-AppxPackage Microsoft.WindowsTerminal_<versionNumber>.msixbundle
```

> [!HINWEIS]
> Wenn Sie Terminal manuell installieren:
>
> * Möglicherweise müssen Sie das [VC++ v14 Desktop Framework Package](https://docs.microsoft.com/troubleshoot/cpp/c-runtime-packages-desktop-bridge#how-to-install-and-update-desktop-framework-packages) installieren.
>   Dies ist nur bei älteren Windows 10-Versionen und nur dann erforderlich, wenn ein Fehler bezüglich fehlender Framework-Pakete auftritt.
> * Terminal wird sich nicht automatisch aktualisieren, wenn neue Builds veröffentlicht werden. Sie müssen regelmäßig die neueste Terminal-Version installieren, um alle Fehlerbehebungen und Verbesserungen zu erhalten!

#### Über Windows Package Manager CLI (auch bekannt als winget)

[winget](https://github.com/microsoft/winget-cli)-Nutzer können die neueste Terminal-Version installieren, indem sie das Paket `Microsoft.WindowsTerminal` installieren:

```powershell
winget install --id Microsoft.WindowsTerminal -e
```

> [!HINWEIS]
> Abhängigkeitssupport ist verfügbar in WinGet-Version [1.6.2631 oder neuer](https://github.com/microsoft/winget-cli/releases). Um die stabile Terminal-Version 1.18 oder neuer zu installieren, stellen Sie bitte sicher, dass Sie die aktualisierte Version des WinGet-Clients haben.

#### Über Chocolatey (inoffiziell)

[Chocolatey](https://chocolatey.org)-Nutzer können die neueste Terminal-Version installieren, indem sie das Paket `microsoft-windows-terminal` installieren:

```powershell
choco install microsoft-windows-terminal
```

Um Windows Terminal mit Chocolatey zu aktualisieren, führen Sie Folgendes aus:

```powershell
choco upgrade microsoft-windows-terminal
```

Falls Sie Probleme bei der Installation/Aktualisierung des Pakets haben, besuchen Sie bitte die [Windows Terminal Paketseite](https://chocolatey.org/packages/microsoft-windows-terminal) und befolgen Sie den [Chocolatey-Triage-Prozess](https://chocolatey.org/docs/package-triage-process).

#### Über Scoop (inoffiziell)

[Scoop](https://scoop.sh)-Nutzer können die neueste Terminal-Version installieren, indem sie das Paket `windows-terminal` installieren:

```powershell
scoop bucket add extras
scoop install windows-terminal
```

Um Windows Terminal mit Scoop zu aktualisieren, führen Sie Folgendes aus:

```powershell
scoop update windows-terminal
```

Falls Sie Probleme bei der Installation/Aktualisierung des Pakets haben, suchen Sie bitte auf der [Issues-Seite](https://github.com/lukesampson/scoop-extras/issues) des Scoop Extras Buckets nach ähnlichen Problemen oder melden Sie ein neues.

---

## Installation von Windows Terminal Canary
Windows Terminal Canary ist ein Nightly-Build von Windows Terminal. Dieser Build enthält den neuesten Code aus unserem `main`-Branch und gibt Ihnen die Möglichkeit, Funktionen auszuprobieren, bevor sie in die Windows Terminal Preview gelangen.

Windows Terminal Canary ist unsere am wenigsten stabile Variante. Es können Fehler auftreten, die wir noch nicht entdeckt haben.

Windows Terminal Canary ist als App Installer Distribution und als Portable ZIP Distribution erhältlich.

Die App Installer Distribution unterstützt automatische Updates. Aufgrund von Plattformbeschränkungen funktioniert dieser Installer nur unter Windows 11.

Die Portable ZIP Distribution ist eine portable Anwendung. Sie wird sich nicht automatisch aktualisieren und überprüft nicht automatisch auf Updates. Diese Portable ZIP Distribution funktioniert unter Windows 10 (19041+) und Windows 11.

| Distribution  | Architektur     | Link                                                 |
|---------------|:---------------:|------------------------------------------------------|
| App Installer | x64, arm64, x86 | [Download](https://aka.ms/terminal-canary-installer) |
| Portable ZIP  | x64             | [Download](https://aka.ms/terminal-canary-zip-x64)   |
| Portable ZIP  | ARM64           | [Download](https://aka.ms/terminal-canary-zip-arm64) |
| Portable ZIP  | x86             | [Download](https://aka.ms/terminal-canary-zip-x86)   |

_Erfahren Sie mehr über die [Arten von Windows Terminal Distributionen](https://learn.microsoft.com/windows/terminal/distributions)._

---

## Windows Terminal Roadmap

Der Plan für das Windows Terminal [wird hier beschrieben](/doc/roadmap-2023.md) und wird aktualisiert, sobald das Projekt fortschreitet.

## Überblick Terminal & Konsole

Bitte nehmen Sie sich ein paar Minuten Zeit, um den folgenden Überblick zu lesen, bevor Sie in den Code einsteigen:

### Windows Terminal

Windows Terminal ist eine neue, moderne, funktionsreiche und produktive Terminalanwendung für Kommandozeilen-Nutzer. Sie enthält viele der am häufigsten von der Windows-Kommandozeilen-Community gewünschten Funktionen, wie Unterstützung für Tabs, Rich Text, Globalisierung, Konfigurierbarkeit, Theming & Styling und mehr.

Das Terminal muss außerdem unsere Ziele und Anforderungen erfüllen, um sicherzustellen, dass es schnell und effizient bleibt und nicht übermäßig viel Speicher oder Energie verbraucht.

### Der Windows Console Host

Der Windows Console Host, `conhost.exe`, ist die ursprüngliche Kommandozeilen-Benutzererfahrung von Windows. Er hostet auch die Kommandozeilen-Infrastruktur von Windows sowie den Windows Console API-Server, die Eingabe-Engine, die Rendering-Engine, Benutzereinstellungen usw. Der Code des Console Hosts in diesem Repository ist der tatsächliche Quellcode, aus dem das `conhost.exe` in Windows selbst gebaut wird.

Seit der Übernahme der Windows-Kommandozeile im Jahr 2014 hat das Team mehrere neue Funktionen zur Konsole hinzugefügt, darunter Hintergrundtransparenz, zeilenbasierte Auswahl, Unterstützung für [ANSI / Virtual Terminal Sequenzen](https://de.wikipedia.org/wiki/ANSI-Escape-Sequenz), [24-Bit Farben](https://devblogs.microsoft.com/commandline/24-bit-color-in-the-windows-console/), eine [Pseudokonsole ("ConPTY")](https://devblogs.microsoft.com/commandline/windows-command-line-introducing-the-windows-pseudo-console-conpty/) und mehr.

Da das Hauptziel der Windows-Konsole jedoch die Rückwärtskompatibilität ist, konnten wir viele der in den letzten Jahren von der Community (und dem Team) gewünschten Funktionen wie Tabs, Unicode-Text und Emojis nicht hinzufügen.

Diese Einschränkungen führten zur Entwicklung des neuen Windows Terminals.

> Mehr über die Entwicklung der Kommandozeile im Allgemeinen und die Windows-Kommandozeile im Speziellen erfahren Sie in [dieser begleitenden Blogreihe](https://devblogs.microsoft.com/commandline/windows-command-line-backgrounder/) des Command-Line-Teams.

### Geteilte Komponenten

Während der Überarbeitung der Windows-Konsole haben wir ihren Code erheblich modernisiert, logische Einheiten sauber in Module und Klassen getrennt, wichtige Erweiterungspunkte eingeführt, mehrere alte, selbst entwickelte Collections und Container durch sicherere, effizientere [STL-Container](https://docs.microsoft.com/de-de/cpp/standard-library/stl-containers?view=vs-2022) ersetzt und den Code durch die Verwendung von Microsofts [Windows Implementation Libraries - WIL](https://github.com/Microsoft/wil) einfacher und sicherer gemacht.

Diese Überarbeitung führte dazu, dass mehrere der wichtigsten Komponenten der Konsole für die Wiederverwendung in jeder Terminal-Implementierung unter Windows zur Verfügung stehen. Diese Komponenten umfassen eine neue DirectWrite-basierte Textlayout- und Rendering-Engine, einen Textpuffer, der sowohl UTF-16 als auch UTF-8 speichern kann, einen VT-Parser/-Emitter und mehr.

### Erstellung des neuen Windows Terminals

Als wir mit der Planung der neuen Windows Terminal-Anwendung begannen, haben wir mehrere Ansätze und Technologiestacks geprüft und bewertet. Letztlich haben wir uns entschieden, dass unsere Ziele am besten erreicht werden, indem wir weiter in unsere C++-Codebasis investieren. Dadurch konnten wir mehrere der oben genannten modernisierten Komponenten sowohl in der bestehenden Konsole als auch im neuen Terminal wiederverwenden. Außerdem erkannten wir, dass wir so den Großteil des Terminal-Kerns selbst als wiederverwendbares UI-Control erstellen können, das andere in ihre eigenen Anwendungen integrieren können.

Das Ergebnis dieser Arbeit finden Sie in diesem Repository, bereitgestellt als Windows Terminal-Anwendung, die Sie entweder aus dem Microsoft Store oder [direkt aus den Releases dieses Repositories](https://github.com/microsoft/terminal/releases) herunterladen können.

---

## Ressourcen

Weitere Informationen zu Windows Terminal finden Sie in diesen Ressourcen:

* [Command-Line Blog](https://devblogs.microsoft.com/commandline)
* [Command-Line Backgrounder Blogreihe](https://devblogs.microsoft.com/commandline/windows-command-line-backgrounder/)
* Windows Terminal Launch: [Terminal "Sizzle Video"](https://www.youtube.com/watch?v=8gw0rXPMMPE&list=PLEHMQNlPj-Jzh9DkNpqipDGCZZuOwrQwR&index=2&t=0s)
* Windows Terminal Launch: [Build 2019 Session](https://www.youtube.com/watch?v=KMudkRcwjCw)
* Run As Radio: [Show 645 - Windows Terminal mit Richard Turner](https://www.runasradio.com/Shows/Show/645)
* Azure Devops Podcast: [Episode 54 - Kayla Cinnamon und Rich Turner über DevOps im Windows Terminal Team](http://azuredevopspodcast.clear-measure.com/kayla-cinnamon-and-rich-turner-on-devops-on-the-windows-terminal-team-episode-54)
* Microsoft Ignite 2019 Session: [The Modern Windows Command Line: Windows Terminal - BRK3321](https://myignite.techcommunity.microsoft.com/sessions/81329?source=sessions)

---

## FAQ

### Ich habe das neue Terminal gebaut und ausgeführt, aber es sieht aus wie die alte Konsole

Ursache: Sie starten die falsche Solution in Visual Studio.

Lösung: Stellen Sie sicher, dass Sie das Projekt `CascadiaPackage` in Visual Studio bauen und bereitstellen.

> [!HINWEIS]
> `OpenConsole.exe` ist lediglich ein lokal gebautes `conhost.exe`, die klassische Windows-Konsole, die die Kommandozeilen-Infrastruktur von Windows hostet. OpenConsole wird vom Windows Terminal verwendet, um sich mit Kommandozeilenanwendungen zu verbinden und mit ihnen zu kommunizieren (über [ConPty](https://devblogs.microsoft.com/commandline/windows-command-line-introducing-the-windows-pseudo-console-conpty/)).

---

## Dokumentation

Alle Projektdokumentationen befinden sich unter [aka.ms/terminal-docs](https://aka.ms/terminal-docs). Wenn Sie zur Dokumentation beitragen möchten, reichen Sie bitte einen Pull Request im [Windows Terminal Documentation-Repository](https://github.com/MicrosoftDocs/terminal) ein.

---

## Mitarbeit

Wir freuen uns darauf, gemeinsam mit Ihnen, unserer großartigen Community, Windows Terminal zu entwickeln und zu verbessern!

***BEVOR Sie an einer Funktion/Fehlerbehebung arbeiten***, lesen und befolgen Sie bitte unseren [Beitragsleitfaden](./CONTRIBUTING.md), um unnötigen oder doppelten Aufwand zu vermeiden.

## Kommunikation mit dem Team

Der einfachste Weg, mit dem Team zu kommunizieren, ist über GitHub Issues.

Bitte melden Sie neue Fehler, Feature-Anfragen und Vorschläge, aber **suchen Sie vorher nach ähnlichen offenen/geschlossenen Issues, bevor Sie ein neues Issue erstellen.**

Wenn Sie eine Frage haben, die Ihrer Meinung nach (noch) kein eigenes Issue wert ist, kontaktieren Sie uns gerne über Twitter:

* Christopher Nguyen, Produktmanager: [@nguyen_dows](https://twitter.com/nguyen_dows)
* Dustin Howett, Entwicklungsleiter: [@dhowett](https://twitter.com/DHowett)
* Mike Griese, Senior Developer: [@zadjii@mastodon.social](https://mastodon.social/@zadjii)
* Carlos Zamora, Entwickler: [@cazamor_msft](https://twitter.com/cazamor_msft)
* Pankaj Bhojwani, Entwickler
* Leonard Hecker, Entwickler: [@LeonardHecker](https://twitter.com/LeonardHecker)

## Entwicklerhinweise

## Voraussetzungen

Sie können Ihre Umgebung auf zwei Arten konfigurieren, um Terminal zu bauen:

### Verwendung der WinGet-Konfigurationsdatei

Nachdem Sie das Repository geklont haben, können Sie eine [WinGet-Konfigurationsdatei](https://learn.microsoft.com/de-de/windows/package-manager/configuration/#use-a-winget-configuration-file-to-configure-your-machine) verwenden, um Ihre Umgebung einzurichten. Die [Standard-Konfigurationsdatei](.config/configuration.winget) installiert Visual Studio 2022 Community & die restlichen benötigten Tools. Im Verzeichnis [.config](.config) gibt es zwei weitere Varianten der Konfigurationsdatei für die Enterprise- & Professional-Editionen von Visual Studio 2022. Um die Standard-Konfigurationsdatei auszuführen, können Sie entweder die Datei im Explorer doppelklicken oder den folgenden Befehl ausführen:

```powershell
winget configure .config\configuration.winget
```

### Manuelle Konfiguration

* Sie müssen Windows 10 2004 (Build >= 10.0.19041.0) oder neuer ausführen, um Windows Terminal nutzen zu können.
* Sie müssen den [Entwicklermodus in den Windows-Einstellungen](https://docs.microsoft.com/de-de/windows/uwp/get-started/enable-your-device-for-development) aktivieren, um Windows Terminal lokal zu installieren und auszuführen.
* Sie müssen [PowerShell 7 oder neuer](https://github.com/PowerShell/PowerShell/releases/latest) installiert haben.
* Sie müssen das [Windows 11 (10.0.22621.0) SDK](https://developer.microsoft.com/de-de/windows/downloads/windows-sdk/) installiert haben.
* Sie müssen mindestens [VS 2022](https://visualstudio.microsoft.com/de/downloads/) installiert haben.
* Sie müssen die folgenden Workloads über den VS-Installer installieren. Hinweis: Das Öffnen der Solution in VS 2022 wird Sie [automatisch zur Installation fehlender Komponenten auffordern](https://devblogs.microsoft.com/setup/configure-visual-studio-across-your-organization-with-vsconfig/):
  * Desktop-Entwicklung mit C++
  * Entwicklung für universelle Windows-Plattform (UWP)
  * **Folgende Einzelkomponenten**
    * C++ (v143) Universal Windows Platform Tools
* Sie müssen das [.NET Framework Targeting Pack](https://docs.microsoft.com/de-de/dotnet/framework/install/guide-for-developers#to-install-the-net-framework-developer-pack-or-targeting-pack) installieren, um Testprojekte zu bauen.

## Code kompilieren

OpenConsole.sln kann innerhalb von Visual Studio oder über die Befehlszeile mit einer Reihe von Hilfsskripten und Tools im Verzeichnis **/tools** kompiliert werden:

### Kompilieren in PowerShell

```powershell
Import-Module .\tools\OpenConsole.psm1
Set-MsBuildDevEnvironment
Invoke-OpenConsoleBuild
```

### Kompilieren in Cmd

```shell
.\tools\razzle.cmd
bcz
```

## Ausführen & Debuggen

Um Windows Terminal in VS zu debuggen, klicken Sie mit der rechten Maustaste auf `CascadiaPackage` (im Solution Explorer) und gehen Sie zu den Eigenschaften. Im Debug-Menü ändern Sie "Application process" und "Background task process" auf "Nur nativ".

Sie sollten dann das Terminal-Projekt mit <kbd>F5</kbd> bauen und debuggen können. Stellen Sie sicher, dass Sie entweder die Plattform "x64" oder "x86" auswählen – das Terminal wird nicht für "Any Cpu" gebaut (weil das Terminal eine C++-Anwendung und keine C#-Anwendung ist).

> 👉 Sie können das Terminal _nicht_ direkt starten, indem Sie WindowsTerminal.exe ausführen. Mehr Details dazu finden Sie unter [#926](https://github.com/microsoft/terminal/issues/926), [#4043](https://github.com/microsoft/terminal/issues/4043)

### Hinweise zur Programmierung

Bitte lesen Sie diese kurzen Dokumente zu unseren Programmierpraktiken.

> 👉 Falls Sie etwas vermissen, tragen Sie gerne zu unserer Dokumentation bei – an beliebiger Stelle im Repository oder indem Sie neue Dokumente verfassen!

Dies ist ein fortlaufender Prozess, da wir lernen, was für effektive Beiträge zu unserem Projekt erforderlich ist.

* [Coding Style](./doc/STYLE.md)
* [Code Organization](./doc/ORGANIZATION.md)
* [Ausnahmen in unserem Legacy-Code](./doc/EXCEPTIONS.md)
* [Hilfreiche Smart Pointer und Makros für das Interfacing mit Windows in WIL](./doc/WIL.md)

---

## Verhaltenskodex

Dieses Projekt hat den [Microsoft Open Source Code of Conduct][conduct-code] übernommen. Weitere Informationen finden Sie in der [Code of Conduct FAQ][conduct-FAQ] oder kontaktieren Sie [opencode@microsoft.com][conduct-email] bei weiteren Fragen oder Kommentaren.

[conduct-code]: https://opensource.microsoft.com/codeofconduct/
[conduct-FAQ]: https://opensource.microsoft.com/codeofconduct/faq/
[conduct-email]: mailto:opencode@microsoft.com
[store-install-link]: https://aka.ms/terminal

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---