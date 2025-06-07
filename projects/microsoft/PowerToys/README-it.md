# Microsoft PowerToys

![Immagine principale di Microsoft PowerToys](doc/images/overview/PT_hero_image.png)

[Come usare PowerToys][usingPowerToys-docs-link] | [Download e Note di rilascio][github-release-link] | [Come contribuire a PowerToys](#contributing) | [Novità](#whats-happening) | [Roadmap](#powertoys-roadmap)

## Informazioni

Microsoft PowerToys è un insieme di utilità per utenti esperti che consente di ottimizzare e rendere più efficiente l'esperienza Windows per una maggiore produttività. Per maggiori informazioni sulle [panoramiche di PowerToys e su come utilizzare le utilità][usingPowerToys-docs-link], o su altri strumenti e risorse per [ambienti di sviluppo Windows](https://learn.microsoft.com/windows/dev-environment/overview), visita [learn.microsoft.com][usingPowerToys-docs-link]!

|              | Utilità attuali: |              |
|--------------|------------------|--------------|
| [Advanced Paste](https://aka.ms/PowerToysOverview_AdvancedPaste) | [Always on Top](https://aka.ms/PowerToysOverview_AoT) | [PowerToys Awake](https://aka.ms/PowerToysOverview_Awake) |
| [Color Picker](https://aka.ms/PowerToysOverview_ColorPicker) | [Command Not Found](https://aka.ms/PowerToysOverview_CmdNotFound) | [Command Palette](https://aka.ms/PowerToysOverview_CmdPal) |
| [Crop And Lock](https://aka.ms/PowerToysOverview_CropAndLock) | [Environment Variables](https://aka.ms/PowerToysOverview_EnvironmentVariables) | [FancyZones](https://aka.ms/PowerToysOverview_FancyZones) |
| [File Explorer Add-ons](https://aka.ms/PowerToysOverview_FileExplorerAddOns) | [File Locksmith](https://aka.ms/PowerToysOverview_FileLocksmith) | [Hosts File Editor](https://aka.ms/PowerToysOverview_HostsFileEditor) |
| [Image Resizer](https://aka.ms/PowerToysOverview_ImageResizer) | [Keyboard Manager](https://aka.ms/PowerToysOverview_KeyboardManager) | [Utilità Mouse](https://aka.ms/PowerToysOverview_MouseUtilities) |
| [Mouse Without Borders](https://aka.ms/PowerToysOverview_MouseWithoutBorders) | [New+](https://aka.ms/PowerToysOverview_NewPlus) | [Incolla come Testo Semplice](https://aka.ms/PowerToysOverview_PastePlain) |
| [Peek](https://aka.ms/PowerToysOverview_Peek) | [PowerRename](https://aka.ms/PowerToysOverview_PowerRename) | [PowerToys Run](https://aka.ms/PowerToysOverview_PowerToysRun) |
| [Quick Accent](https://aka.ms/PowerToysOverview_QuickAccent) | [Registry Preview](https://aka.ms/PowerToysOverview_RegistryPreview) | [Screen Ruler](https://aka.ms/PowerToysOverview_ScreenRuler) |
| [Shortcut Guide](https://aka.ms/PowerToysOverview_ShortcutGuide) | [Text Extractor](https://aka.ms/PowerToysOverview_TextExtractor) | [Workspaces](https://aka.ms/PowerToysOverview_Workspaces) |
| [ZoomIt](https://aka.ms/PowerToysOverview_ZoomIt) |

## Installazione ed esecuzione di Microsoft PowerToys

### Requisiti

- Windows 11 o Windows 10 versione 2004 (nome in codice 20H1 / numero build 19041) o successivi.
- Processore x64 o ARM64
- Il nostro programma di installazione installerà i seguenti elementi:
   - Bootstrapper di [Microsoft Edge WebView2 Runtime](https://go.microsoft.com/fwlink/p/?LinkId=2124703). Verrà installata la versione più recente.

### Tramite GitHub con EXE [Consigliato]

Vai alla [pagina dei rilasci di Microsoft PowerToys su GitHub][github-release-link] e clicca su `Assets` in fondo per visualizzare i file disponibili nella release. Usa il programma di installazione di PowerToys appropriato in base all'architettura della tua macchina e all'ambito di installazione. Per la maggior parte degli utenti è `x64` e per utente.

<!-- items that need to be updated release to release -->
[github-next-release-work]: https://github.com/microsoft/PowerToys/issues?q=is%3Aissue+milestone%3A%22PowerToys+0.92%22
[github-current-release-work]: https://github.com/microsoft/PowerToys/issues?q=is%3Aissue+milestone%3A%22PowerToys+0.91%22
[ptUserX64]: https://github.com/microsoft/PowerToys/releases/download/v0.91.1/PowerToysUserSetup-0.91.1-x64.exe 
[ptUserArm64]: https://github.com/microsoft/PowerToys/releases/download/v0.91.1/PowerToysUserSetup-0.91.1-arm64.exe 
[ptMachineX64]: https://github.com/microsoft/PowerToys/releases/download/v0.91.1/PowerToysSetup-0.91.1-x64.exe 
[ptMachineArm64]: https://github.com/microsoft/PowerToys/releases/download/v0.91.1/PowerToysSetup-0.91.1-arm64.exe
 
|  Descrizione   | Nome file | hash sha256 |
|----------------|-----------|-------------|
| Per utente - x64       | [PowerToysUserSetup-0.91.1-x64.exe][ptUserX64] | 42EA4A3E8C79A5456476D19E72B3E2AB9393A89C4DC7442EB7EE5A1E3490D38A |
| Per utente - ARM64     | [PowerToysUserSetup-0.91.1-arm64.exe][ptUserArm64] | F3F433FE04049F9197411D792AADEBF34E3BE7FE16327BD8B73D2A046ED8BAF6 |
| Per macchina - x64     | [PowerToysSetup-0.91.1-x64.exe][ptMachineX64] | EC4BC3A8625775866B0ED4577CCF83E6EC7B1A0AD267379DDBAF4FE49C7B5BDD |
| Per macchina - ARM64   | [PowerToysSetup-0.91.1-arm64.exe][ptMachineArm64] | 9CB8911008420D0E446AE3D5CE365E447FA4DF9DCF9337F3A80F933C00FC3689 |

Questo è il nostro metodo preferito.

### Tramite Microsoft Store

Installa dalla [pagina PowerToys del Microsoft Store][microsoft-store-link]. Devi utilizzare il [nuovo Microsoft Store](https://blogs.windows.com/windowsExperience/2021/06/24/building-a-new-open-microsoft-store-on-windows-11/) che è disponibile sia per Windows 11 sia per Windows 10.

### Tramite WinGet
Scarica PowerToys da [WinGet][winget-link]. L'aggiornamento di PowerToys tramite winget rispetterà l'ambito di installazione attuale. Per installare PowerToys, esegui il seguente comando dalla riga di comando / PowerShell:

#### Installazione per utente [default]
```powershell
winget install Microsoft.PowerToys -s winget
```

#### Installazione per macchina

```powershell
winget install --scope machine Microsoft.PowerToys -s winget
```

### Altri metodi di installazione

Esistono [metodi di installazione guidati dalla community](./doc/unofficialInstallMethods.md) come Chocolatey e Scoop. Se queste sono le tue soluzioni preferite, puoi trovare lì le istruzioni di installazione.

## Plugin Run di Terze Parti

Esiste una raccolta di [plugin di terze parti](./doc/thirdPartyRunPlugins.md) creati dalla community che non sono distribuiti con PowerToys.

## Come contribuire

Questo progetto accoglie contributi di ogni tipo. Oltre allo sviluppo di funzionalità/correzione di bug, altri modi per aiutare includono la scrittura delle specifiche, il design, la documentazione e la segnalazione di bug. Siamo entusiasti di collaborare con la community degli utenti esperti per costruire un set di strumenti che ti aiuti a ottenere il massimo da Windows.

Ti chiediamo che **prima di iniziare a lavorare su una funzionalità che desideri contribuire**, leggi la nostra [Guida per i contributori](CONTRIBUTING.md). Saremo felici di lavorare con te per trovare il miglior approccio, fornirti guida e mentorship durante lo sviluppo e aiutarti a evitare sforzi inutili o duplicati.

La maggior parte dei contributi richiede di accettare un [Contributor License Agreement (CLA)][oss-CLA] dichiarando che ci concedi i diritti di utilizzare il tuo contributo e che hai il permesso di farlo.

Per orientamenti sullo sviluppo per PowerToys, leggi la [documentazione per sviluppatori](/doc/devdocs) per una spiegazione dettagliata, inclusa la configurazione del tuo computer per la compilazione.

## Novità

### Roadmap di PowerToys

La nostra [roadmap prioritaria][roadmap] delle funzionalità e delle utilità su cui il team principale si sta concentrando.

### 0.91 - Aggiornamento Maggio 2025

In questa versione ci siamo concentrati su nuove funzionalità, stabilità e automazione.

**✨In evidenza**

 - Ci siamo concentrati sul miglioramento significativo delle prestazioni della Command Palette e sulla correzione di numerosi bug. Alcune delle nuove funzionalità aggiunte sono:
 - Aggiunta la possibilità per la Command Palette di cercare qualsiasi file utilizzando un comando di fallback.
 - Aggiunta la possibilità di rendere la scorciatoia globale della Command Palette un hook di tastiera di basso livello.
 - Aggiunto comando di fallback per aprire URL nell'estensione WebSearch, consentendo agli utenti di aprire direttamente URL nel browser dalla Command Palette.
 - Ora puoi definire formati personalizzati nei plugin Data e Ora di PT Run e Command Palette. Grazie [@htcfreek](https://github.com/htcfreek)!

### Advanced Paste

 - Corretto un problema per cui Advanced Paste non riusciva a creare il motore OCR per alcuni tag di lingua inglese (ad esempio, en-CA) inizializzando il motore OCR con la lingua del profilo utente. Grazie [@cryolithic](https://github.com/cryolithic)!

### Color Picker

 - Corretto un problema in cui una perdita di risorse causava blocchi o crash smaltendo correttamente l'oggetto Graphics. Grazie [@dcog989](https://github.com/dcog989)!
 - Corretto un problema per cui Color Picker si chiudeva premendo Backspace assicurandosi che si chiuda solo quando è focalizzato e allineando il comportamento di Escape/Backspace. Grazie [@PesBandi](https://github.com/PesBandi)!
 - Aggiunto il supporto per i formati colore Oklab e Oklch in Color Picker. Grazie [@lemonyte](https://github.com/lemonyte)!

### Command Not Found

 - Aggiornato lo script WinGet Command Not Found per abilitare le funzionalità sperimentali solo se effettivamente esistono.

### Command Palette

 - Aggiornato il template dei bug per includere il modulo Command Palette.
 - Corretto un problema per cui la finestra toast non veniva scalata per il DPI, causando problemi di layout con lo scaling del display.
 - Corretto un problema per cui la navigazione con tastiera Su/Giù non spostava la selezione quando il cursore era alla posizione 0, e aggiunta la navigazione continua come PT Run v1. Grazie [@davidegiacometti](https://github.com/davidegiacometti)!
 - Aggiornato il codice dell'estensione Data e Ora per semplificarlo e migliorarne la chiarezza.
 - Corretto un problema per cui la capitalizzazione nel comando causava errori nel tentativo di andare al puntatore del mouse, risolto convertendo il comando in minuscolo.
 - Aggiunto comando di fallback per aprire URL nell'estensione WebSearch, consentendo di aprire direttamente URL nel browser dalla Command Palette. Grazie [@htcfreek](https://github.com/htcfreek)!
 - Aggiunta un'impostazione per abilitare/disabilitare l'icona nella system tray in CmdPal e allineato la terminologia con Windows 11. Grazie [@davidegiacometti](https://github.com/davidegiacometti)!
 - Corretto un problema di aggiornamento degli alias rimuovendo quello vecchio quando ne viene impostato uno nuovo.
 - Risolto un conflitto di maiuscole/minuscole su GitHub migrando Exts ed exts in una nuova directory ext, assicurando una struttura coerente e prevenendo la frammentazione dei percorsi.
 - Corretto un problema per cui il comando 'Crea nuova estensione' generava nomi file vuoti.
 - Aggiunta la possibilità di rendere la scorciatoia globale un hook di tastiera di basso livello.
 - Aggiunto il supporto per le miniature JUMBO, consentendo l'accesso a icone ad alta risoluzione.
 - Corretto crash quando CmdPal si nascondeva automaticamente mentre era aperta una finestra di dialogo MSAL, impedendo a CmdPal di nascondersi se è disabilitato.
 - Aggiunto il supporto per la selezione immediata del testo di ricerca quando una pagina viene caricata.
 - Corretto un bug per cui le pagine delle impostazioni delle estensioni non venivano ricaricate alla riapertura aggiornando il form delle impostazioni quando vengono salvate.
 - Corretto un problema per cui la Command Palette non si avviava dal runner.
 - Rifattorizzata e portata la logica della calcolatrice di PowerToys Run v1 in Command Palette, aggiunto il supporto alle impostazioni e migliorato il comportamento di fallback.
 - Riaggiunto il supporto alle scorciatoie da tastiera per gli elementi della lista.
 - Migliorata l'accessibilità in Command Palette aggiungendo etichette corrette, raffinando le animazioni, migliorando la localizzazione e correggendo problemi relativi all'accessibilità.
 - Portato il supporto ai formati personalizzati nel plugin Data e Ora, riordinato e ripulito le impostazioni, migliorato i messaggi di errore e corretto crash edge-case per un comportamento più robusto e user-friendly. Grazie [@htcfreek](https://github.com/htcfreek)!
 - Aggiunto elemento di fallback per comando di sistema.
 - Corretto un bug in Windows System Command dove il prompt del tasto mostrava erroneamente "Empty" per l'azione "Apri Cestino". Grazie [@jironemo](https://github.com/jironemo)!
 - Corretto un problema per cui la lista 'altri comandi' mostrava comandi che non dovevano essere visibili. Grazie [@davidegiacometti](https://github.com/davidegiacometti)!
 - Corretto un problema per cui la vista dettagli in Command Palette mostrava un'icona sovradimensionata e testo non allineato, allineandolo al comportamento di Windows Search.
 - Corretto un bug in cui contenuti vuoti e comandi della barra comandi venivano tagliati con etichette lunghe, garantendo layout e visibilità corretti.
 - Migliorata l'integrazione WinGet di CmdPal correggendo la visualizzazione della versione per i pacchetti installati, consentendo aggiornamenti con icone e migrando l'API winget preview a una versione stabile.
 - Corretto un bug per cui i comandi per ContentPage non venivano aggiornati fino all'uscita, assicurando che i menu contestuali siano completamente inizializzati quando cambiano.
 - Aggiunto supporto di fallback all'estensione TimeDate, abilitando query dirette senza dover selezionare il comando prima.
 - Importato Common.Dotnet.AotCompatibility.props in diversi file di progetto CmdPal per migliorare il supporto alla compilazione AOT.
 - Corretto un crash nelle impostazioni CmdPal causato da HotKey nullo quando settings.json è assente o manca una scorciatoia definita. Grazie [@davidegiacometti](https://github.com/davidegiacometti)!
 - Aggiunto supporto per menu contestuali nidificati e filtrabili in CmdPal, inclusa una casella di ricerca per mantenere il focus.
 - Rifattorizzate le classi CmdPal per migliorare la serializzazione JSON e introdotti nuovi contesti di serializzazione per migliori prestazioni e manutenibilità.
 - Aggiunto supporto per la compilazione ahead-of-time (AoT).
 - Aggiunto meccanismo di retry per l'avvio di CmdPal.
 - Rimossi alcuni file inutilizzati da CmdPal.Common per semplificare il codebase e facilitarne la marcatura come AoT-compatibile.
 - Corretto un bug per cui una race condition nell'aggiornamento di SearchText causava lo spostamento automatico del cursore alla fine della riga, assicurando che SearchText venga aggiornato solo dopo il reale cambiamento.
 - Aggiunto supporto alla ricerca di qualsiasi file nel comando di fallback.
 - Pulito codice relativo ad AoT per prevenire operazioni duplicate durante i test.
 - Ridotto il tempo di caricamento di CmdPal parallelizzando l'avvio delle estensioni e aggiungendo timeout per evitare che estensioni malfunzionanti blocchino le altre.
 - Migliorato il comportamento UI chiudendo il pannello dettagli quando la lista si svuota, evitando stati visivi incoerenti.
 - Aggiunto supporto per annullare il comando di fallback in CmdPal quando non viene trovato nessun comando corrispondente, garantendo un comportamento di ricarica più pulito.
 - Corretta una perdita nel template delle estensioni CmdPal risolvendo l'uso improprio di ComServer.
 - Impedita la massimizzazione della finestra CmdPal tramite doppio click sulla barra del titolo per mantenere il comportamento previsto. Grazie [@davidegiacometti](https://github.com/davidegiacometti)!
 - Corretto un problema per cui la UI delle Impostazioni veniva avviata troppo piccola rendendo le dimensioni DPI-aware e imponendo larghezza e altezza minime tramite WinUIEx.
 - Risolti problemi di flash bianco e di animazione unica in CmdPal oscurando la finestra invece di nasconderla.
 - Corretto un bug per cui tutte le impostazioni delle estensioni venivano caricate all'avvio tramite caricamento lazy delle impostazioni, riducendo l'overhead di inizializzazione.
 - Aggiunto supporto per proteggere CmdPal da crash su errore di parsing Adaptive Card.
 - Sostituita shell:AppsFolder con attivazione tramite URI in CmdPal per migliorarne l'affidabilità.
 - Aggiunta possibilità di aprire le impostazioni CmdPal da PowerToys Settings.
 - Aggiunta possibilità per CmdPal di osservare e aggiornare dinamicamente i dettagli delle estensioni monitorando i cambiamenti delle proprietà sull'elemento selezionato.
 - Aggiornata la versione della toolkit utilizzata nel template dell'estensione CmdPal alla 0.2.0.

### Image Resizer

 - Corretto un problema per cui l'eliminazione di un preset di Image Resizer rimuoveva il preset sbagliato.

### Keyboard Manager

 - Corretto un problema per cui un tasto modificatore, se impostato senza specificare sinistra o destra, rimaneva bloccato per una gestione errata del tasto, tracciando i tasti premuti e inviando quello corretto. Grazie [@mantaionut](https://github.com/mantaionut)!

### PowerRename

 - Migliorate le capacità di formattazione oraria di PowerRename aggiungendo pattern orari a 12 ore con supporto AM/PM. Grazie [@bitmap4](https://github.com/bitmap4)!

### PowerToys Run

 - Aggiunto supporto per formati personalizzati nel plugin "Ora e data" e migliorati i messaggi di errore per input non validi. Grazie [@htcfreek](https://github.com/htcfreek)!
 - Correzione di due crash: uno per WFT su date molto anticipate e un altro per il calcolo della settimana del mese su date molto avanzate (ad es. 31.12.9999), e riordino delle impostazioni UI. Grazie [@htcfreek](https://github.com/htcfreek)!
 - Corretto un problema per cui la capitalizzazione nel comando causava errori nel tentativo di andare al puntatore del mouse, risolto convertendo il comando in minuscolo.
 - Aggiunti dettagli di versione ai messaggi di errore dei plugin per 'Errore di caricamento' ed 'Errore di inizializzazione'. Grazie [@htcfreek](https://github.com/htcfreek)!
 - Migliorato il modello dei risultati aggiungendo il supporto per prevenire l'ordinamento in base all'uso, offrendo agli sviluppatori dei plugin maggiore controllo sul comportamento di ordinamento. Grazie [@CoreyHayward](https://github.com/CoreyHayward) e [@htcfreek](https://github.com/htcfreek)!

### Quick Accent

 - Aggiornata la mappatura delle lettere in GetDefaultLetterKeyEPO, sostituendo "ǔ" con "ŭ" per il tasto VK_U per riflettere accuratamente la fonetica esperanto. Grazie [@OlegKharchevkin](https://github.com/OlegKharchevkin)!
 - Corretto un problema per cui Quick Accent non funzionava correttamente con la tastiera su schermo. Grazie [@davidegiacometti](https://github.com/davidegiacometti)!

### Registry Preview

 - Migliorato Registry Preview per supportare l'incolla di chiavi e valori di registro senza dover scrivere manualmente l'header del file, e aggiunto un nuovo pulsante per il reset dell'app. Grazie [@htcfreek](https://github.com/htcfreek)!

### Impostazioni

 - Corretto un problema per cui l'app Impostazioni mostrava casualmente un'icona vuota nella barra delle applicazioni rinviando l'assegnazione dell'icona fino all'attivazione della finestra.
 - Aggiunta la possibilità di massimizzare la finestra "Novità" per una lettura più confortevole.

### Workspaces

 - Corretti bug per cui i giochi Steam non venivano catturati o avviati correttamente aggiornando il filtro delle finestre e integrando la gestione del protocollo URL Steam.

### Documentazione

 - Aggiunto QuickNotes alla documentazione dei plugin di terze parti per PowerToys Run. Grazie [@ruslanlap](https://github.com/ruslanlap)!
 - Aggiunti i plugin Weather e Pomodoro alla documentazione dei plugin di terze parti per PowerToys Run. Grazie [@ruslanlap](https://github.com/ruslanlap)!
 - Aggiunto il plugin Linear alla documentazione dei plugin di terze parti di PowerToys Run. Grazie [@vednig](https://github.com/vednig)!
 - Correzione di problemi di formattazione nei file di documentazione e aggiornate le informazioni sui contributor e membri del team. Grazie [@DanielEScherzer](https://github.com/DanielEScherzer) e [@RokyZevon](https://github.com/RokyZevon)!

### Sviluppo

 - Aggiornata GitHub Action per installare .NET 9 a supporto del rilascio MSStore.
 - Aggiornato il placeholder di versione in bug_report.yml per evitare versioni errate v0.70.0 nei report.
 - Aggiornata GitHub Action per aggiornare actions/setup-dotnet dalla versione 3 alla 4 per il rilascio MSStore.
 - Aggiunto securityContext ai file di configurazione WinGet, consentendo l'invocazione dal contesto utente e chiedendo un solo UAC per risorse elevate in un processo separato. Grazie [@mdanish-kh](https://github.com/mdanish-kh)!
 - Cambiata l'estensione dei file di log da .txt a .log per supportare corrette associazioni di file e compatibilità con gli strumenti, aggiunti log per Workspace. Grazie [@benwa](https://github.com/benwa)!
 - Aggiornate le dipendenze dei framework di test e allineate le versioni dei pacchetti tra i componenti.
 - Aggiornate le dipendenze per correggere vulnerabilità.
 - Migliorata la sicurezza del repository bloccando le GitHub Actions e i tag Docker a commit immutabili e integrando la scansione automatica delle vulnerabilità tramite Dependency Review Workflow. Grazie [@Nick2bad4u](https://github.com/Nick2bad4u)!
 - Aggiornate le dipendenze Boost a una versione più recente.
 - Aggiornata la toolkit all'ultima versione, soppressi i warning relativi ad AoT.
 - Corretto un problema per cui la mancata firma di nuovi file causava errori di build.
 - Aggiornata la pipeline di rilascio per evitare la pubblicazione di simboli privati per 100 anni.
 - Introdotto il fuzzing per PowerRename per migliorarne l'affidabilità e aggiunta guida per estendere il fuzzing ad altri moduli C++.
 - Aggiunta la creazione centralizzata delle cartelle generate per tutti i progetti .csproj per prevenire errori di build.
 - Aggiornata WinAppSDK all'ultima versione 1.7.
 - Aggiornate le dipendenze Boost all'ultima versione per il progetto PowerRename Fuzzing.
 - Aggiornato il percorso area ADO in tsa.json per risolvere errori nella pipeline TSA causati da un percorso deprecato.
 - Avviato il supporto AoT per CmdPal con lavori fondamentali in corso.

### Tool/Generale

 - Aggiunto supporto per automatizzare la creazione di report di bug generando un URL GitHub precompilato con informazioni di sistema e diagnostica. Grazie [@donlaci](https://github.com/donlaci)!
 - Aggiunti script per la build locale dell'installer, assicurando che CmdPal possa essere avviato anche in ambiente locale.
 - Rimossa la logica di esportazione PFX per eliminare password hardcoded e risolvere l'avviso di sicurezza PSScriptAnalyzer.
 - Aggiunto script PowerShell e integrazione CI per imporre l'uso coerente di Common.Dotnet.CsWinRT.props in tutti i progetti C# sotto la cartella src.

### Cosa è pianificato per la versione 0.92

Per [v0.92][github-next-release-work], lavoreremo sui seguenti punti:

 - Ulteriore perfezionamento di Command Palette
 - Nuovi test di UI Automation
 - Lavori sugli aggiornamenti dell'installer
 - Upgrade dell'editor UI di Keyboard Manager
 - Stabilità / correzione bug

## Community PowerToys

Il team di PowerToys è estremamente grato di avere il [supporto di una fantastica community attiva][community-link]. Il vostro lavoro è estremamente importante. PowerToys non sarebbe quello che è oggi senza il vostro aiuto nella segnalazione di bug, aggiornamento della documentazione, guida nel design o sviluppo di funzionalità. Vogliamo ringraziarvi e prenderci il tempo per riconoscere il vostro lavoro. Mese dopo mese, aiutate direttamente a rendere PowerToys un software migliore.

## Codice di Condotta

Questo progetto ha adottato il [Codice di Condotta Microsoft Open Source][oss-conduct-code].

## Informativa sulla privacy

L'applicazione registra dati diagnostici di base (telemetria). Per ulteriori informazioni sulla privacy e su cosa raccogliamo, consulta la nostra [documentazione su dati e privacy di PowerToys](https://aka.ms/powertoys-data-and-privacy-documentation).

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