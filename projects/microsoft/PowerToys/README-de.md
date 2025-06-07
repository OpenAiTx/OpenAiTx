# Microsoft PowerToys

![Hero image for Microsoft PowerToys](doc/images/overview/PT_hero_image.png)

[Wie man PowerToys verwendet][usingPowerToys-docs-link] | [Downloads & Versionshinweise][github-release-link] | [Beitrag zu PowerToys](#contributing) | [Was passiert gerade](#whats-happening) | [Roadmap](#powertoys-roadmap)

## Über

Microsoft PowerToys ist eine Sammlung von Dienstprogrammen für Power-User, um ihre Windows-Erfahrung zu optimieren und effizienter zu gestalten. Für weitere Informationen zu [PowerToys-Überblicken und der Nutzung der Tools][usingPowerToys-docs-link] oder anderen Tools und Ressourcen für [Windows-Entwicklungsumgebungen](https://learn.microsoft.com/windows/dev-environment/overview), besuchen Sie [learn.microsoft.com][usingPowerToys-docs-link]!

|              | Aktuelle Dienstprogramme: |              |
|--------------|--------------------------|--------------|
| [Advanced Paste](https://aka.ms/PowerToysOverview_AdvancedPaste) | [Always on Top](https://aka.ms/PowerToysOverview_AoT) | [PowerToys Awake](https://aka.ms/PowerToysOverview_Awake) |
| [Color Picker](https://aka.ms/PowerToysOverview_ColorPicker) | [Command Not Found](https://aka.ms/PowerToysOverview_CmdNotFound) | [Command Palette](https://aka.ms/PowerToysOverview_CmdPal) |
| [Crop And Lock](https://aka.ms/PowerToysOverview_CropAndLock) | [Umgebungsvariablen](https://aka.ms/PowerToysOverview_EnvironmentVariables) | [FancyZones](https://aka.ms/PowerToysOverview_FancyZones) |
| [Datei-Explorer-Add-ons](https://aka.ms/PowerToysOverview_FileExplorerAddOns) | [File Locksmith](https://aka.ms/PowerToysOverview_FileLocksmith) | [Hosts-Datei-Editor](https://aka.ms/PowerToysOverview_HostsFileEditor) |
| [Bildgrößenänderer](https://aka.ms/PowerToysOverview_ImageResizer) | [Tastatur-Manager](https://aka.ms/PowerToysOverview_KeyboardManager) | [Maus-Dienstprogramme](https://aka.ms/PowerToysOverview_MouseUtilities) |
| [Mouse Without Borders](https://aka.ms/PowerToysOverview_MouseWithoutBorders) | [New+](https://aka.ms/PowerToysOverview_NewPlus) | [Als Nur-Text einfügen](https://aka.ms/PowerToysOverview_PastePlain) |
| [Peek](https://aka.ms/PowerToysOverview_Peek) | [PowerRename](https://aka.ms/PowerToysOverview_PowerRename) | [PowerToys Run](https://aka.ms/PowerToysOverview_PowerToysRun) |
| [Quick Accent](https://aka.ms/PowerToysOverview_QuickAccent) | [Registry Preview](https://aka.ms/PowerToysOverview_RegistryPreview) | [Bildschirmlineal](https://aka.ms/PowerToysOverview_ScreenRuler) |
| [Shortcut Guide](https://aka.ms/PowerToysOverview_ShortcutGuide) | [Text Extractor](https://aka.ms/PowerToysOverview_TextExtractor) | [Workspaces](https://aka.ms/PowerToysOverview_Workspaces) |
| [ZoomIt](https://aka.ms/PowerToysOverview_ZoomIt) |

## Installation und Ausführung von Microsoft PowerToys

### Anforderungen

- Windows 11 oder Windows 10 Version 2004 (Codename 20H1 / Buildnummer 19041) oder neuer.
- x64- oder ARM64-Prozessor
- Unser Installationsprogramm installiert folgende Komponenten:
   - [Microsoft Edge WebView2 Runtime](https://go.microsoft.com/fwlink/p/?LinkId=2124703) Bootstrapper. Dies installiert die neueste Version.

### Über GitHub mit EXE [Empfohlen]

Gehen Sie zur [Microsoft PowerToys GitHub-Releases-Seite][github-release-link] und klicken Sie unten auf `Assets`, um die in der Version verfügbaren Dateien anzuzeigen. Bitte verwenden Sie das passende PowerToys-Installationsprogramm, das zur Architektur und zum Installationsbereich Ihres Rechners passt. Für die meisten ist dies `x64` und pro Benutzer.

<!-- items that need to be updated release to release -->
[github-next-release-work]: https://github.com/microsoft/PowerToys/issues?q=is%3Aissue+milestone%3A%22PowerToys+0.92%22
[github-current-release-work]: https://github.com/microsoft/PowerToys/issues?q=is%3Aissue+milestone%3A%22PowerToys+0.91%22
[ptUserX64]: https://github.com/microsoft/PowerToys/releases/download/v0.91.1/PowerToysUserSetup-0.91.1-x64.exe 
[ptUserArm64]: https://github.com/microsoft/PowerToys/releases/download/v0.91.1/PowerToysUserSetup-0.91.1-arm64.exe 
[ptMachineX64]: https://github.com/microsoft/PowerToys/releases/download/v0.91.1/PowerToysSetup-0.91.1-x64.exe 
[ptMachineArm64]: https://github.com/microsoft/PowerToys/releases/download/v0.91.1/PowerToysSetup-0.91.1-arm64.exe
 
|  Beschreibung   | Dateiname | sha256-Hash |
|----------------|-----------|-------------|
| Pro Benutzer - x64       | [PowerToysUserSetup-0.91.1-x64.exe][ptUserX64] | 42EA4A3E8C79A5456476D19E72B3E2AB9393A89C4DC7442EB7EE5A1E3490D38A |
| Pro Benutzer - ARM64     | [PowerToysUserSetup-0.91.1-arm64.exe][ptUserArm64] | F3F433FE04049F9197411D792AADEBF34E3BE7FE16327BD8B73D2A046ED8BAF6 |
| Für alle Benutzer - x64  | [PowerToysSetup-0.91.1-x64.exe][ptMachineX64] | EC4BC3A8625775866B0ED4577CCF83E6EC7B1A0AD267379DDBAF4FE49C7B5BDD |
| Für alle Benutzer - ARM64| [PowerToysSetup-0.91.1-arm64.exe][ptMachineArm64] | 9CB8911008420D0E446AE3D5CE365E447FA4DF9DCF9337F3A80F933C00FC3689 |

Dies ist unsere bevorzugte Methode.

### Über den Microsoft Store

Installieren Sie PowerToys von der [PowerToys-Seite im Microsoft Store][microsoft-store-link]. Sie müssen den [neuen Microsoft Store](https://blogs.windows.com/windowsExperience/2021/06/24/building-a-new-open-microsoft-store-on-windows-11/) verwenden, der sowohl für Windows 11 als auch Windows 10 verfügbar ist.

### Über WinGet

Laden Sie PowerToys über [WinGet][winget-link] herunter. Updates von PowerToys über winget berücksichtigen den aktuellen Installationsbereich. Um PowerToys zu installieren, führen Sie den folgenden Befehl in der Befehlszeile / PowerShell aus:

#### Benutzerbereich-Installer [Standard]
```powershell
winget install Microsoft.PowerToys -s winget
```

#### Systemweiter Installer

```powershell
winget install --scope machine Microsoft.PowerToys -s winget
```

### Weitere Installationsmethoden

Es gibt [community-getriebene Installationsmethoden](./doc/unofficialInstallMethods.md) wie Chocolatey und Scoop. Wenn dies Ihre bevorzugten Installationslösungen sind, finden Sie dort die Anleitungen.

## Drittanbieter-Run-Plugins

Es gibt eine Sammlung von [Drittanbieter-Plugins](./doc/thirdPartyRunPlugins.md), die von der Community erstellt wurden und nicht mit PowerToys ausgeliefert werden.

## Beiträge

Dieses Projekt begrüßt Beiträge aller Art. Neben der Implementierung von Features und Fehlerbehebungen können Sie auch bei der Spezifikation, dem Design, der Dokumentation oder dem Auffinden von Fehlern helfen. Wir freuen uns, mit der Power-User-Community zusammenzuarbeiten, um eine Tool-Sammlung zu entwickeln, die Ihnen hilft, das Beste aus Windows herauszuholen.

Wir bitten Sie, **bevor Sie mit der Arbeit an einem Feature beginnen, das Sie beitragen möchten**, unseren [Beitragsleitfaden](CONTRIBUTING.md) zu lesen. Wir unterstützen Sie gerne bei der besten Herangehensweise, geben Anleitung und Mentoring während der Feature-Entwicklung und helfen, doppelte Arbeit zu vermeiden.

Die meisten Beiträge erfordern, dass Sie eine [Contributor License Agreement (CLA)][oss-CLA] akzeptieren, in der Sie uns die Rechte zur Nutzung Ihres Beitrags einräumen und bestätigen, dass Sie dazu berechtigt sind.

Für Hinweise zur Entwicklung für PowerToys lesen Sie bitte die [Entwicklerdokumentation](/doc/devdocs) für einen detaillierten Überblick. Hier erfahren Sie auch, wie Sie Ihren Rechner zum Kompilieren einrichten.

## Was passiert gerade

### PowerToys Roadmap

Unsere [priorisierte Roadmap][roadmap] mit Features und Dienstprogrammen, auf die sich das Kernteam konzentriert.

### 0.91 – Mai 2025 Update

In diesem Release lag unser Fokus auf neuen Features, Stabilität und Automatisierung.

**✨Highlights**

 - Fokus auf deutliche Leistungsverbesserungen der Command Palette und Behebung vieler Fehler. Neue Features sind u.a.:
 - Möglichkeit, dass die Command Palette beliebige Dateien mit einem Fallback-Befehl durchsucht.
 - Option, die globale Hotkey der Command Palette als Low-Level-Tastatur-Hook auszuführen.
 - Neuer Fallback-Befehl zum Öffnen von URLs für die WebSearch-Erweiterung, sodass Nutzer URLs direkt aus der Command Palette im Browser öffnen können.
 - Sie können nun eigene Formate in den Datums- und Zeit-Plugins von PT Run und Command Palette definieren. Danke [@htcfreek](https://github.com/htcfreek)!

### Advanced Paste

 - Behebung eines Problems, bei dem Advanced Paste die OCR-Engine für bestimmte englische Sprach-Tags (z.B. en-CA) nicht erstellen konnte, durch Initialisierung mit der Sprache des Benutzerprofils. Danke [@cryolithic](https://github.com/cryolithic)!

### Color Picker

 - Behebung eines Ressourcenlecks, das zu Hängern oder Abstürzen führte, durch korrektes Freigeben des Graphics-Objekts. Danke [@dcog989](https://github.com/dcog989)!
 - Behebung eines Problems, bei dem Color Picker beim Drücken von Backspace beendet wurde, indem das Schließen nur bei Fokus erfolgt und das Verhalten von Escape/Backspace angeglichen wurde. Danke [@PesBandi](https://github.com/PesBandi)!
 - Unterstützung für Oklab- und Oklch-Farbformate im Color Picker hinzugefügt. Danke [@lemonyte](https://github.com/lemonyte)!

### Command Not Found

 - Das WinGet Command Not Found Script aktualisiert, sodass experimentelle Features nur aktiviert werden, wenn sie tatsächlich existieren.

### Command Palette

 - Bug-Template aktualisiert, sodass das Command Palette Modul enthalten ist.
 - Ein Problem behoben, bei dem das Toast-Fenster nicht für DPI skaliert wurde und dadurch Layout-Probleme bei Display-Skalierung verursachte.
 - Ein Problem behoben, bei dem die Navigation per Pfeiltasten nicht funktionierte, wenn sich der Cursor an Position 0 befand, sowie kontinuierliche Navigation wie bei PT Run v1 hinzugefügt. Danke [@davidegiacometti](https://github.com/davidegiacometti)!
 - Den Code der Zeit- und Datumserweiterung vereinfacht und übersichtlicher gestaltet.
 - Ein Problem behoben, bei dem Groß-/Kleinschreibung im Befehl zu einem Fehler beim Verschieben zum Mauszeiger führte, indem der Befehl in Kleinbuchstaben umgewandelt wird.
 - Fallback-Befehl zum Öffnen von URLs für die WebSearch-Erweiterung hinzugefügt, damit URLs direkt aus der Command Palette geöffnet werden können. Danke [@htcfreek](https://github.com/htcfreek)!
 - Einstellung zum Aktivieren/Deaktivieren des System-Tray-Icons in CmdPal hinzugefügt und Terminologie an Windows 11 angepasst. Danke [@davidegiacometti](https://github.com/davidegiacometti)!
 - Alias-Update-Problem behoben, indem der alte Alias entfernt wird, wenn ein neuer gesetzt wird.
 - GitHub-Groß-/Kleinschreibungs-Konflikt gelöst, indem Exts und exts in ein neues ext-Verzeichnis migriert wurden, für konsistente Struktur und Vermeidung von Pfad-Fragmentierung.
 - Problem behoben, bei dem der Befehl "Neue Erweiterung erstellen" leere Dateinamen erzeugte.
 - Möglichkeit hinzugefügt, den globalen Hotkey als Low-Level-Tastatur-Hook auszuführen.
 - Unterstützung für JUMBO-Thumbnails hinzugefügt, sodass hochauflösende Icons zugänglich sind.
 - Abstürze behoben, wenn CmdPal sich automatisch versteckte, während ein MSAL-Dialog geöffnet war, indem das Verstecken verhindert wird, falls deaktiviert.
 - Unterstützung für sofortige Auswahl des Suchtexts beim Laden einer Seite hinzugefügt.
 - Fehler behoben, bei dem die Einstellungsseiten von Erweiterungen nach dem erneuten Öffnen nicht neu geladen wurden, durch Aktualisierung des Einstellungsformulars beim Speichern der Erweiterungseinstellungen.
 - Ein Problem behoben, bei dem die Command Palette nicht aus dem Runner gestartet werden konnte.
 - Die PowerToys Run v1 Rechnerlogik in die Command Palette übernommen, Einstellungssupport hinzugefügt und das Fallback-Verhalten verbessert.
 - Unterstützung für Tastaturkürzel bei Listeneinträgen wiederhergestellt.
 - Barrierefreiheit in der Command Palette verbessert durch korrekte Beschriftungen, feinere Animationen, bessere Lokalisierung und Behebung von a11y-bezogenen Problemen.
 - Eigene Formatunterstützung für das Zeit- und Datumsplugin übernommen, Einstellungen neu geordnet, Fehlermeldungen verbessert und Abstürze bei Randfällen behoben. Danke [@htcfreek](https://github.com/htcfreek)!
 - Fallback-Element für Systembefehle hinzugefügt.
 - Fehler im Windows-Systembefehl behoben, bei dem die Tastenaufforderung fälschlich "Leer" für die Aktion "Papierkorb öffnen" anzeigte. Danke [@jironemo](https://github.com/jironemo)!
 - Fehler behoben, bei dem die "Weitere Befehle"-Liste Befehle zeigte, die nicht sichtbar sein sollten. Danke [@davidegiacometti](https://github.com/davidegiacometti)!
 - Fehler behoben, bei dem die Detailansicht in der Command Palette ein übergroßes Symbol und falsch ausgerichteten Text zeigte, jetzt an Windows Search angepasst.
 - Fehler behoben, bei dem leerer Bildschirminhalt und Befehlsleistenbefehle bei langen Beschriftungen abgeschnitten wurden, für korrektes Layout und Sichtbarkeit.
 - CmdPal’s WinGet-Integration verbessert, Versionsanzeige für installierte Pakete korrigiert, Updates mit Icons ermöglicht und die Vorschau-API auf eine stabile Version umgestellt.
 - Fehler behoben, bei dem Befehle für ContentPage erst nach dem Beenden aktualisiert wurden, indem Kontextmenüs bei Änderungen vollständig initialisiert werden.
 - Fallback-Unterstützung für die TimeDate-Erweiterung hinzugefügt, sodass direkte Datums-/Zeitabfragen ohne Vorselektion möglich sind.
 - Import von Common.Dotnet.AotCompatibility.props über mehrere CmdPal-Projektdateien hinzugefügt, um AoT-Kompilierungsunterstützung zu verbessern.
 - Absturz in CmdPal-Einstellungen behoben, der durch einen fehlenden HotKey bei fehlender settings.json verursacht wurde. Danke [@davidegiacometti](https://github.com/davidegiacometti)!
 - Unterstützung für filterbare, verschachtelte Kontextmenüs in CmdPal hinzugefügt, einschließlich Suchfeld zur Beibehaltung des Fokusverhaltens.
 - CmdPal-Klassen refaktoriert, um die JSON-Serialisierung zu verbessern und neue Serialisierungskontexte für bessere Performance und Wartbarkeit eingeführt.
 - Unterstützung für Ahead-of-Time (AoT)-Kompilierung hinzugefügt.
 - Retry-Mechanismus für CmdPal-Start hinzugefügt.
 - Einige ungenutzte Dateien aus CmdPal.Common entfernt, um den Code zu vereinfachen und die AoT-Kompatibilität zu erleichtern.
 - Fehler behoben, bei dem ein Race-Condition beim Aktualisieren von SearchText den Cursor im Eingabefeld immer ans Zeilenende setzte – jetzt wird SearchText erst nach tatsächlicher Änderung aktualisiert.
 - Unterstützung für die Dateisuche im Fallback-Befehl hinzugefügt.
 - AoT-bezogenen Code bereinigt, um doppelte Operationen beim Testen zu verhindern.
 - CmdPal-Ladezeit verkürzt, indem der Start von Erweiterungen parallelisiert und Timeouts hinzugefügt wurden, damit fehlerhafte Erweiterungen andere nicht blockieren.
 - UI-Verhalten verbessert, indem die Detailansicht ausgeblendet wird, sobald die Liste geleert wird, um inkonsistente Zustände zu vermeiden.
 - Möglichkeit hinzugefügt, den Fallback-Befehl in CmdPal zurückzusetzen, wenn kein passender Befehl gefunden wird, für sauberes Neu-Laden.
 - Leck im CmdPal-Erweiterungstemplate durch falsche ComServer-Nutzung behoben.
 - CmdPal-Fenster am Maximieren durch Doppelklick auf die Titelleiste gehindert, um das gewünschte Fensterverhalten beizubehalten. Danke [@davidegiacometti](https://github.com/davidegiacometti)!
 - Problem behoben, bei dem die Einstellungsoberfläche zu klein startete, durch DPI-bewusste Fenstermaße und Mindestbreite/-höhe mit WinUIEx.
 - Weißes Blitzen und einmalige Animationen in CmdPal durch Verhüllen des Fensters statt Ausblenden behoben.
 - Fehler behoben, bei dem alle Erweiterungseinstellungen beim Start geladen wurden, jetzt Lazy-Loading, um Initialisierung zu beschleunigen.
 - Schutz für CmdPal gegen Abstürze bei Adaptive Card-Parse-Fehler hinzugefügt.
 - shell:AppsFolder in CmdPal durch URI-Aktivierung ersetzt, um Zuverlässigkeit zu verbessern.
 - Möglichkeit hinzugefügt, CmdPal-Einstellungen aus den PowerToys-Einstellungen zu öffnen.
 - CmdPal kann nun Erweiterungsdetails beobachten und dynamisch aktualisieren, indem Eigenschaftsänderungen am ausgewählten Element verfolgt werden.
 - Toolkit-Version im CmdPal-Erweiterungstemplate auf 0.2.0 angehoben.

### Bildgrößenänderer

 - Problem behoben, bei dem das Löschen eines Image Resizer-Profils das falsche Profil entfernte.

### Tastatur-Manager

 - Problem behoben, bei dem eine Modifizierertaste, wenn sie ohne Links-/Rechts-Spezifikation gesetzt wurde, durch falsches Tasten-Tracking hängen blieb, indem gedrückte Tasten verfolgt und korrekt gesendet werden. Danke [@mantaionut](https://github.com/mantaionut)!

### PowerRename

 - Zeitformatierung in PowerRename erweitert, indem 12-Stunden-Formate mit AM/PM-Unterstützung hinzugefügt wurden. Danke [@bitmap4](https://github.com/bitmap4)!

### PowerToys Run

 - Unterstützung für eigene Formate im "Zeit und Datum"-Plugin hinzugefügt und Fehlermeldungen bei ungültigen Formaten verbessert. Danke [@htcfreek](https://github.com/htcfreek)!
 - Zwei Abstürze behoben: einen für WFT bei sehr frühen Daten und einen bei der Berechnung der Kalenderwoche im Monat für sehr späte Daten (z.B. 31.12.9999), UI-Einstellungen neu geordnet. Danke [@htcfreek](https://github.com/htcfreek)!
 - Problem behoben, bei dem Groß-/Kleinschreibung im Befehl zu Fehlern beim Verschieben zum Mauszeiger führte, indem der Befehl in Kleinbuchstaben umgewandelt wird.
 - Versionsdetails zu Plugin-Fehlermeldungen für "Ladefehler" und "Init-Fehler" hinzugefügt. Danke [@htcfreek](https://github.com/htcfreek)!
 - Das Ergebnismodell erweitert, um die nutzungsbasierte Sortierung zu verhindern und Plugin-Entwicklern mehr Kontrolle über die Sortierung zu geben. Danke [@CoreyHayward](https://github.com/CoreyHayward) und [@htcfreek](https://github.com/htcfreek)!

### Quick Accent

 - Zuordnung der Buchstaben in GetDefaultLetterKeyEPO aktualisiert, indem "ǔ" durch "ŭ" für die VK_U-Taste ersetzt wurde, um die Esperanto-Phonetik korrekt abzubilden. Danke [@OlegKharchevkin](https://github.com/OlegKharchevkin)!
 - Problem behoben, bei dem Quick Accent mit der Bildschirmtastatur nicht korrekt funktionierte. Danke [@davidegiacometti](https://github.com/davidegiacometti)!

### Registry Preview

 - Registry Preview erweitert, sodass Registry-Schlüssel und -Werte eingefügt werden können, ohne die Dateikopfzeile manuell zu schreiben, und eine neue Schaltfläche zum Zurücksetzen der App hinzugefügt. Danke [@htcfreek](https://github.com/htcfreek)!

### Einstellungen

 - Problem behoben, bei dem die Einstellungen-App gelegentlich ein leeres Icon in der Taskleiste zeigte, indem die Icon-Zuweisung bis zur Fensteraktivierung verzögert wurde.
 - Möglichkeit hinzugefügt, das "Was ist neu"-Fenster zu maximieren, um das Lesen zu erleichtern.

### Workspaces

 - Fehler behoben, bei denen Steam-Spiele nicht korrekt erfasst oder gestartet wurden, durch Aktualisierung des Fensterfilters und Integration des Steam-URL-Protokolls.

### Dokumentation

 - QuickNotes zur Drittanbieter-Plugin-Dokumentation für PowerToys Run hinzugefügt. Danke [@ruslanlap](https://github.com/ruslanlap)!
 - Weather- und Pomodoro-Plugins zur PowerToys Run Drittanbieter-Plugin-Dokumentation hinzugefügt. Danke [@ruslanlap](https://github.com/ruslanlap)!
 - Das Linear-Plugin zur PowerToys Run Drittanbieter-Plugin-Dokumentation hinzugefügt. Danke [@vednig](https://github.com/vednig)!
 - Formatierungsprobleme in Dokumentationsdateien behoben und Informationen zu Beitragenden und Teammitgliedern aktualisiert. Danke [@DanielEScherzer](https://github.com/DanielEScherzer) und [@RokyZevon](https://github.com/RokyZevon)!

### Entwicklung

 - GitHub Action aktualisiert, damit .NET 9 für MSStore-Release unterstützt wird.
 - Platzhalter für Version in bug_report.yml aktualisiert, um falsche v0.70.0-Versionen in Fehlerberichten zu verhindern.
 - GitHub Action aktualisiert, um actions/setup-dotnet von Version 3 auf Version 4 für MSStore-Release zu aktualisieren.
 - securityContext zu WinGet-Konfigurationsdateien hinzugefügt, damit ein einzelner UAC für erhöhte Ressourcen in einem separaten Prozess angefordert werden kann. Danke [@mdanish-kh](https://github.com/mdanish-kh)!
 - Dateiendungen für Protokolldateien von .txt auf .log geändert, um korrekte Zuordnungen und Tool-Kompatibilität zu unterstützen, und Protokolle für Workspace hinzugefügt. Danke [@benwa](https://github.com/benwa)!
 - Testframework-Abhängigkeiten aktualisiert und Paketversionen über Komponenten hinweg vereinheitlicht.
 - Abhängigkeiten aktualisiert, um Schwachstellen zu beheben.
 - Sicherheit des Repositories verbessert, indem GitHub Actions und Docker-Tags auf unveränderliche Commit-Hashes fixiert und automatisierte Schwachstellen-Scans über Dependency Review Workflow integriert wurden. Danke [@Nick2bad4u](https://github.com/Nick2bad4u)!
 - Boost-Abhängigkeiten auf neuere Version aktualisiert.
 - Toolkit auf die neueste Version aktualisiert, AoT-bezogene Warnungen unterdrückt.
 - Problem behoben, bei dem fehlende Signaturen für neue Dateien zu Build-Fehlern führten.
 - Release-Pipeline aktualisiert, um das Veröffentlichen privater Symbole für 100 Jahre zu verhindern.
 - Fuzzing für PowerRename eingeführt, um Zuverlässigkeit zu verbessern, und Anleitung für die Erweiterung des Fuzzings auf andere C++-Module hinzugefügt.
 - Zentrale Vorab-Erstellung generierter Ordner für alle .csproj-Projekte hinzugefügt, um Build-Fehler zu vermeiden.
 - WinAppSDK auf die neueste Version 1.7 aktualisiert.
 - Boost-Abhängigkeiten für das PowerRename Fuzzing-Projekt auf die neueste Version angehoben.
 - ADO-Bereichspfad in tsa.json aktualisiert, um Fehler in der TSA-Pipeline durch veraltete Pfade zu beheben.
 - AoT-Unterstützung für CmdPal mit Grundlagenarbeit eingeleitet.

### Tool/Allgemein

 - Unterstützung für die automatische Erstellung von Fehlerberichten hinzugefügt, indem eine vorausgefüllte GitHub-Issue-URL mit System- und Diagnosedaten generiert wird. Danke [@donlaci](https://github.com/donlaci)!
 - Skripte zum lokalen Erstellen des Installers hinzugefügt, damit CmdPal auch lokal gestartet werden kann.
 - Export-PFX-Logik entfernt, um harte Passwortnutzung zu vermeiden und PSScriptAnalyzer-Sicherheitswarnungen zu beheben.
 - PowerShell-Skript und CI-Integration hinzugefügt, um die konsistente Nutzung von Common.Dotnet.CsWinRT.props in allen C#-Projekten im src-Ordner durchzusetzen.

### Was für Version 0.92 geplant ist

Für [v0.92][github-next-release-work] arbeiten wir an folgenden Punkten:

 - Weitere Verbesserungen an der Command Palette
 - Neue UI-Automatisierungstests
 - Verbesserungen am Installer
 - Upgrade der Editor-Oberfläche des Tastatur-Managers
 - Stabilität / Fehlerbehebungen

## PowerToys Community

Das PowerToys-Team ist äußerst dankbar für die [Unterstützung einer großartigen, aktiven Community][community-link]. Ihre Arbeit ist unglaublich wichtig. PowerToys wäre heute nicht das, was es ist, ohne Ihre Hilfe beim Melden von Fehlern, Aktualisieren der Dokumentation, Mitgestalten des Designs oder Entwickeln von Features. Wir möchten Danke sagen und Ihre Arbeit würdigen. Monat für Monat helfen Sie direkt dabei, PowerToys besser zu machen.

## Verhaltenskodex

Dieses Projekt folgt dem [Microsoft Open Source Code of Conduct][oss-conduct-code].

## Datenschutzerklärung

Die Anwendung protokolliert grundlegende Diagnosedaten (Telemetrie). Weitere Informationen zum Datenschutz und darüber, welche Daten wir erfassen, finden Sie in unserer [PowerToys Daten- und Datenschutzdokumentation](https://aka.ms/powertoys-data-and-privacy-documentation).

[oss-CLA]: https://cla.opensource.microsoft.com
[oss-conduct-code]: CODE_OF_CONDUCT.md
[community-link]: COMMUNITY.md
[github-release-link]: https://aka.ms/installPowerToys
[microsoft-store-link]: https://aka.ms/getPowertoys
[winget-link]: https://github.com/microsoft/winget-cli#installing-the-client
[roadmap]: https://github.com/microsoft/PowerToys/wiki/Roadmap
[privacy-link]: http://go.microsoft.com/fwlink/?LinkId=521839
[loc-bug]: https://github.com/microsoft/PowerToys/issues/new?assignees=&labels=&template=translation_issue.md&title=
[usingPowerToys-docs-link]: https://aka.ms/powertoys-docs

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---