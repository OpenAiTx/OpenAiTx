![terminal-logos](https://github.com/microsoft/terminal/assets/91625426/333ddc76-8ab2-4eb4-a8c0-4d7b953b1179)

[![Terminal Build Status](https://dev.azure.com/shine-oss/terminal/_apis/build/status%2FTerminal%20CI?branchName=main)](https://dev.azure.com/shine-oss/terminal/_build/latest?definitionId=1&branchName=main)

# Benvenuto nel repository di Windows Terminal, Console e Command-Line

<details>
  <summary><strong>Indice</strong></summary>

- [Installazione ed esecuzione di Windows Terminal](#installazione-ed-esecuzione-di-windows-terminal)
  - [Microsoft Store \[Raccomandato\]](#microsoft-store-raccomandato)
  - [Altri metodi di installazione](#altri-metodi-di-installazione)
    - [Tramite GitHub](#tramite-github)
    - [Tramite Windows Package Manager CLI (alias winget)](#tramite-windows-package-manager-cli-alias-winget)
    - [Tramite Chocolatey (non ufficiale)](#tramite-chocolatey-non-ufficiale)
    - [Tramite Scoop (non ufficiale)](#tramite-scoop-non-ufficiale)
- [Installazione di Windows Terminal Canary](#installazione-di-windows-terminal-canary)
- [Roadmap di Windows Terminal](#roadmap-di-windows-terminal)
- [Panoramica su Terminale & Console](#panoramica-su-terminale--console)
  - [Windows Terminal](#windows-terminal)
  - [L'host della Console di Windows](#lhost-della-console-di-windows)
  - [Componenti condivisi](#componenti-condivisi)
  - [Creazione del nuovo Windows Terminal](#creazione-del-nuovo-windows-terminal)
- [Risorse](#risorse)
- [FAQ](#faq)
  - [Ho compilato e avviato il nuovo Terminal, ma sembra identico alla vecchia console](#ho-compilato-e-avviato-il-nuovo-terminal-ma-sembra-identico-alla-vecchia-console)
- [Documentazione](#documentazione)
- [Contribuire](#contribuire)
- [Comunicare con il Team](#comunicare-con-il-team)
- [Guida per sviluppatori](#guida-per-sviluppatori)
- [Prerequisiti](#prerequisiti)
- [Compilazione del codice](#compilazione-del-codice)
  - [Compilazione in PowerShell](#compilazione-in-powershell)
  - [Compilazione in Cmd](#compilazione-in-cmd)
- [Esecuzione & Debug](#esecuzione--debug)
  - [Guida alla scrittura del codice](#guida-alla-scrittura-del-codice)
- [Codice di condotta](#codice-di-condotta)

</details>

<br />

Questo repository contiene il codice sorgente per:

* [Windows Terminal](https://aka.ms/terminal)
* [Windows Terminal Preview](https://aka.ms/terminal-preview)
* L'host della console di Windows (`conhost.exe`)
* Componenti condivisi tra i due progetti
* [ColorTool](./src/tools/ColorTool)
* [Progetti di esempio](./samples)
  che mostrano come utilizzare le API della Console di Windows

Repository correlati includono:

* [Documentazione di Windows Terminal](https://docs.microsoft.com/windows/terminal)
  ([Repo: Contribuisci alla documentazione](https://github.com/MicrosoftDocs/terminal))
* [Documentazione API della Console](https://github.com/MicrosoftDocs/Console-Docs)
* [Font Cascadia Code](https://github.com/Microsoft/Cascadia-Code)

## Installazione ed esecuzione di Windows Terminal

> [!NOTA]
> Windows Terminal richiede Windows 10 2004 (build 19041) o successivo

### Microsoft Store [Raccomandato]

Installa [Windows Terminal dal Microsoft Store][store-install-link].
In questo modo avrai sempre la versione più recente quando rilasciamo nuove build
con aggiornamenti automatici.

Questo è il nostro metodo preferito.

### Altri metodi di installazione

#### Tramite GitHub

Per gli utenti che non riescono a installare Windows Terminal dal Microsoft Store,
le build rilasciate possono essere scaricate manualmente dalla [pagina delle Release
di questo repository](https://github.com/microsoft/terminal/releases).

Scarica il file `Microsoft.WindowsTerminal_<versionNumber>.msixbundle` dalla sezione
**Assets**. Per installare l'app, puoi semplicemente fare doppio clic sul file
`.msixbundle` e l'installer dell'app dovrebbe avviarsi automaticamente. Se ciò non
dovesse funzionare, prova il seguente comando in una console PowerShell:

```powershell
# NOTA: Se usi PowerShell 7+, esegui prima
# Import-Module Appx -UseWindowsPowerShell
# prima di usare Add-AppxPackage.

Add-AppxPackage Microsoft.WindowsTerminal_<versionNumber>.msixbundle
```

> [!NOTA]
> Se installi Terminal manualmente:
>
> * Potresti dover installare il [VC++ v14 Desktop Framework Package](https://docs.microsoft.com/troubleshoot/cpp/c-runtime-packages-desktop-bridge#how-to-install-and-update-desktop-framework-packages).
>   Questo è necessario solo su vecchie build di Windows 10 e solo se ricevi un errore relativo a pacchetti framework mancanti.
> * Terminal non si aggiornerà automaticamente quando vengono rilasciate nuove build, quindi dovrai
>   installare regolarmente l’ultima release di Terminal per ricevere tutte le correzioni e i miglioramenti più recenti!

#### Tramite Windows Package Manager CLI (alias winget)

Gli utenti di [winget](https://github.com/microsoft/winget-cli) possono scaricare e installare
l’ultima versione di Terminal installando il pacchetto `Microsoft.WindowsTerminal`:

```powershell
winget install --id Microsoft.WindowsTerminal -e
```

> [!NOTA]
> Il supporto alle dipendenze è disponibile in WinGet versione [1.6.2631 o successiva](https://github.com/microsoft/winget-cli/releases). Per installare la versione stabile di Terminal 1.18 o successive, assicurati di avere la versione aggiornata del client WinGet.

#### Tramite Chocolatey (non ufficiale)

Gli utenti di [Chocolatey](https://chocolatey.org) possono scaricare e installare
l’ultima versione di Terminal installando il pacchetto `microsoft-windows-terminal`:

```powershell
choco install microsoft-windows-terminal
```

Per aggiornare Windows Terminal con Chocolatey, esegui:

```powershell
choco upgrade microsoft-windows-terminal
```

Se riscontri problemi durante l’installazione/aggiornamento del pacchetto, visita la
[pagina del pacchetto Windows Terminal](https://chocolatey.org/packages/microsoft-windows-terminal) e segui il
[processo di triage di Chocolatey](https://chocolatey.org/docs/package-triage-process)

#### Tramite Scoop (non ufficiale)

Gli utenti di [Scoop](https://scoop.sh) possono scaricare e installare l’ultima versione di Terminal
installando il pacchetto `windows-terminal`:

```powershell
scoop bucket add extras
scoop install windows-terminal
```

Per aggiornare Windows Terminal tramite Scoop, esegui:

```powershell
scoop update windows-terminal
```

Se riscontri problemi durante l’installazione/aggiornamento del pacchetto, cerca o segnala il problema sulla [pagina delle issue](https://github.com/lukesampson/scoop-extras/issues) del repository Scoop Extras bucket.

---

## Installazione di Windows Terminal Canary
Windows Terminal Canary è una build notturna di Windows Terminal. Questa build contiene il codice più recente dal nostro ramo `main`, offrendoti la possibilità di provare le funzionalità prima che arrivino in Windows Terminal Preview.

Windows Terminal Canary è la nostra versione meno stabile, quindi potresti riscontrare bug prima che li individuiamo.

Windows Terminal Canary è disponibile come distribuzione App Installer e distribuzione Portable ZIP.

La distribuzione App Installer supporta gli aggiornamenti automatici. A causa di limitazioni della piattaforma, questo installer funziona solo su Windows 11.

La distribuzione Portable ZIP è un’applicazione portatile. Non si aggiornerà automaticamente e non verificherà automaticamente la presenza di aggiornamenti. Questa distribuzione ZIP portatile funziona su Windows 10 (19041+) e Windows 11.

| Distribuzione | Architettura    | Link                                                 |
|---------------|:---------------:|------------------------------------------------------|
| App Installer | x64, arm64, x86 | [scarica](https://aka.ms/terminal-canary-installer)  |
| Portable ZIP  | x64             | [scarica](https://aka.ms/terminal-canary-zip-x64)    |
| Portable ZIP  | ARM64           | [scarica](https://aka.ms/terminal-canary-zip-arm64)  |
| Portable ZIP  | x86             | [scarica](https://aka.ms/terminal-canary-zip-x86)    |

_Per saperne di più sui [tipi di distribuzioni di Windows Terminal](https://learn.microsoft.com/windows/terminal/distributions)._

---

## Roadmap di Windows Terminal

Il piano per Windows Terminal [è descritto qui](/doc/roadmap-2023.md) e
verrà aggiornato man mano che il progetto procede.

## Panoramica su Terminale & Console

Ti invitiamo a dedicare alcuni minuti per consultare la panoramica qui sotto prima di immergerti nel codice:

### Windows Terminal

Windows Terminal è una nuova applicazione terminale moderna, ricca di funzionalità, produttiva
per gli utenti della riga di comando. Include molte delle funzionalità richieste più frequentemente
dalla community della riga di comando di Windows, tra cui supporto per schede, testo avanzato,
globalizzazione, configurabilità, temi & stili, e altro ancora.

Il Terminal dovrà inoltre rispettare i nostri obiettivi e criteri per garantire che rimanga
veloce ed efficiente, senza consumare grandi quantità di memoria o energia.

### L'host della Console di Windows

L’host della Console di Windows, `conhost.exe`, è l'esperienza originale della riga di comando di Windows.
Ospita anche l'infrastruttura della riga di comando di Windows e il server delle API Console di Windows,
motore di input, motore di rendering, preferenze utente, ecc. Il codice dell’host della console in questo
repository è il sorgente effettivo da cui viene compilato il `conhost.exe` di Windows.

Da quando abbiamo preso in carico la riga di comando di Windows nel 2014, il team ha aggiunto
diverse nuove funzionalità alla Console, tra cui trasparenza dello sfondo,
selezione su base di riga, supporto per [sequenze ANSI / Virtual Terminal](https://en.wikipedia.org/wiki/ANSI_escape_code),
[colore a 24 bit](https://devblogs.microsoft.com/commandline/24-bit-color-in-the-windows-console/),
una [Pseudoconsole ("ConPTY")](https://devblogs.microsoft.com/commandline/windows-command-line-introducing-the-windows-pseudo-console-conpty/),
e altro ancora.

Tuttavia, poiché l'obiettivo principale della Console di Windows è mantenere la compatibilità all'indietro,
non abbiamo potuto aggiungere molte delle funzionalità richieste dalla community (e dal team)
negli ultimi anni, tra cui schede, testo unicode ed emoji.

Queste limitazioni ci hanno portato a creare il nuovo Windows Terminal.

> Puoi leggere di più sull’evoluzione della riga di comando in generale, e di quella di Windows in particolare, in [questa serie di post sul blog](https://devblogs.microsoft.com/commandline/windows-command-line-backgrounder/) del team Command-Line.

### Componenti condivisi

Durante la revisione della Console di Windows, abbiamo modernizzato notevolmente il suo codice sorgente,
separando chiaramente le entità logiche in moduli e classi, introducendo alcuni
punti chiave di estensibilità, sostituendo diverse vecchie collezioni e contenitori
"fatti in casa" con [contenitori STL](https://docs.microsoft.com/en-us/cpp/standard-library/stl-containers?view=vs-2022)
più sicuri ed efficienti, e semplificando il codice utilizzando le [Windows Implementation Libraries - WIL](https://github.com/Microsoft/wil) di Microsoft.

Questa revisione ha permesso di rendere disponibili diversi componenti chiave della Console
per il riutilizzo in qualsiasi implementazione di terminale su Windows. Questi componenti includono un
nuovo motore di layout e rendering del testo basato su DirectWrite, un buffer di testo capace di
memorizzare sia UTF-16 che UTF-8, un parser/emettitore VT, e altro ancora.

### Creazione del nuovo Windows Terminal

Quando abbiamo iniziato a pianificare la nuova applicazione Windows Terminal, abbiamo esplorato e
valutato diversi approcci e stack tecnologici. Abbiamo infine deciso che i nostri obiettivi
sarebbero stati meglio raggiunti continuando a investire nel nostro codice C++, che ci avrebbe permesso
di riutilizzare molti dei componenti modernizzati menzionati prima sia nella Console esistente
che nel nuovo Terminal. Inoltre, abbiamo realizzato che ciò ci avrebbe permesso di costruire gran parte
del core del Terminal stesso come un controllo UI riutilizzabile che altri possono incorporare nelle proprie applicazioni.

Il risultato di questo lavoro è contenuto in questo repository e distribuito come
applicazione Windows Terminal che puoi scaricare dal Microsoft Store, o
[direttamente dalle release di questo repo](https://github.com/microsoft/terminal/releases).

---

## Risorse

Per ulteriori informazioni su Windows Terminal, potresti trovare utili e interessanti queste risorse:

* [Command-Line Blog](https://devblogs.microsoft.com/commandline)
* [Serie di post Command-Line Backgrounder](https://devblogs.microsoft.com/commandline/windows-command-line-backgrounder/)
* Lancio di Windows Terminal: [Video "Sizzle" del Terminal](https://www.youtube.com/watch?v=8gw0rXPMMPE&list=PLEHMQNlPj-Jzh9DkNpqipDGCZZuOwrQwR&index=2&t=0s)
* Lancio di Windows Terminal: [Sessione Build 2019](https://www.youtube.com/watch?v=KMudkRcwjCw)
* Run As Radio: [Show 645 - Windows Terminal con Richard Turner](https://www.runasradio.com/Shows/Show/645)
* Azure Devops Podcast: [Episodio 54 - Kayla Cinnamon e Rich Turner su DevOps
  nel team Windows Terminal](http://azuredevopspodcast.clear-measure.com/kayla-cinnamon-and-rich-turner-on-devops-on-the-windows-terminal-team-episode-54)
* Microsoft Ignite 2019 Session: [La moderna riga di comando di Windows: Windows Terminal - BRK3321](https://myignite.techcommunity.microsoft.com/sessions/81329?source=sessions)

---

## FAQ

### Ho compilato e avviato il nuovo Terminal, ma sembra identico alla vecchia console

Causa: Stai avviando la soluzione sbagliata in Visual Studio.

Soluzione: Assicurati di compilare e distribuire il progetto `CascadiaPackage` in Visual Studio.

> [!NOTA]
> `OpenConsole.exe` è solo un `conhost.exe` compilato localmente, la classica
> Console di Windows che ospita l'infrastruttura della riga di comando. OpenConsole
> viene usato da Windows Terminal per connettersi e comunicare con le applicazioni
> della riga di comando (tramite
> [ConPty](https://devblogs.microsoft.com/commandline/windows-command-line-introducing-the-windows-pseudo-console-conpty/)).

---

## Documentazione

Tutta la documentazione del progetto si trova su [aka.ms/terminal-docs](https://aka.ms/terminal-docs). Se vuoi contribuire alla documentazione, invia una pull request sul [repository della documentazione di Windows Terminal](https://github.com/MicrosoftDocs/terminal).

---

## Contribuire

Siamo entusiasti di lavorare insieme a te, nostra fantastica community, per costruire e
migliorare Windows Terminal\!

***PRIMA di iniziare a lavorare su una funzionalità/correzione***, leggi e segui la nostra
[Guida per i Contributori](./CONTRIBUTING.md) per
evitare sforzi inutili o duplicati.

## Comunicare con il Team

Il modo più semplice per comunicare con il team è tramite le issue di GitHub.

Apri nuove issue, richieste di funzionalità e suggerimenti, ma **cerca sempre
issue simili già aperte/chiuse prima di crearne una nuova.**

Se vuoi fare una domanda che ritieni non valga una issue
(per ora), contattaci su Twitter:

* Christopher Nguyen, Product Manager:
  [@nguyen_dows](https://twitter.com/nguyen_dows)
* Dustin Howett, Engineering Lead: [@dhowett](https://twitter.com/DHowett)
* Mike Griese, Senior Developer: [@zadjii@mastodon.social](https://mastodon.social/@zadjii)
* Carlos Zamora, Developer: [@cazamor_msft](https://twitter.com/cazamor_msft)
* Pankaj Bhojwani, Developer
* Leonard Hecker, Developer: [@LeonardHecker](https://twitter.com/LeonardHecker)

## Guida per sviluppatori

## Prerequisiti

Puoi configurare il tuo ambiente per compilare Terminal in due modi:

### Utilizzando un file di configurazione WinGet

Dopo aver clonato il repository, puoi usare un [file di configurazione WinGet](https://learn.microsoft.com/en-us/windows/package-manager/configuration/#use-a-winget-configuration-file-to-configure-your-machine)
per configurare il tuo ambiente. Il [file di configurazione predefinito](.config/configuration.winget) installa Visual Studio 2022 Community e tutti gli strumenti richiesti. Sono disponibili altre due varianti del file di configurazione nella directory [.config](.config) per le edizioni Enterprise e Professional di Visual Studio 2022. Per eseguire il file di configurazione predefinito, puoi fare doppio clic sul file da Esplora risorse o eseguire il seguente comando:

```powershell
winget configure .config\configuration.winget
```

### Configurazione manuale

* Devi eseguire Windows 10 2004 (build >= 10.0.19041.0) o successivo per eseguire
  Windows Terminal
* Devi [abilitare la Modalità sviluppatore nelle impostazioni di Windows](https://docs.microsoft.com/en-us/windows/uwp/get-started/enable-your-device-for-development)
  per installare ed eseguire localmente Windows Terminal
* Devi aver installato [PowerShell 7 o successivo](https://github.com/PowerShell/PowerShell/releases/latest)
* Devi aver installato [Windows 11 (10.0.22621.0) SDK](https://developer.microsoft.com/en-us/windows/downloads/windows-sdk/)
* Devi aver installato almeno [VS 2022](https://visualstudio.microsoft.com/downloads/)
* Devi installare i seguenti workload tramite il programma di installazione di VS. Nota: Aprendo
  la soluzione in VS 2022 ti verrà [richiesto di installare automaticamente i componenti mancanti](https://devblogs.microsoft.com/setup/configure-visual-studio-across-your-organization-with-vsconfig/):
  * Sviluppo Desktop con C++
  * Sviluppo Universal Windows Platform
  * **I seguenti Componenti Individuali**
    * C++ (v143) Universal Windows Platform Tools
* Devi installare il [.NET Framework Targeting Pack](https://docs.microsoft.com/dotnet/framework/install/guide-for-developers#to-install-the-net-framework-developer-pack-or-targeting-pack) per compilare i progetti di test

## Compilazione del codice

OpenConsole.sln può essere compilato da Visual Studio o da riga di comando
usando una serie di script e strumenti nella directory **/tools**:

### Compilazione in PowerShell

```powershell
Import-Module .\tools\OpenConsole.psm1
Set-MsBuildDevEnvironment
Invoke-OpenConsoleBuild
```

### Compilazione in Cmd

```shell
.\tools\razzle.cmd
bcz
```

## Esecuzione & Debug

Per effettuare il debug di Windows Terminal in VS, clicca col tasto destro su `CascadiaPackage` (in Esplora Soluzioni) e vai su proprietà. Nel menu Debug, cambia "Processo applicazione" e "Processo attività in background" su "Solo Native".

Dovresti quindi poter compilare e fare debug del progetto Terminal premendo
<kbd>F5</kbd>. Assicurati di selezionare la piattaforma "x64" o "x86" - Terminal non si compila per "Any Cpu" (perché Terminal è un'applicazione C++, non C#).

> 👉 Non potrai _avviare_ direttamente il Terminal eseguendo WindowsTerminal.exe. Per maggiori dettagli sul perché, vedi
> [#926](https://github.com/microsoft/terminal/issues/926),
> [#4043](https://github.com/microsoft/terminal/issues/4043)

### Guida alla scrittura del codice

Consulta queste brevi guide sulle nostre pratiche di codifica.

> 👉 Se noti che manca qualcosa in queste guide, sentiti libero di contribuire a
> qualsiasi file di documentazione nel repository (o scriverne di nuovi!)

Questo è un lavoro in corso mentre impariamo cosa dovremo fornire per essere efficaci contributori al nostro progetto.

* [Stile di Codifica](./doc/STYLE.md)
* [Organizzazione del Codice](./doc/ORGANIZATION.md)
* [Eccezioni nel nostro codice legacy](./doc/EXCEPTIONS.md)
* [Smart pointer e macro utili per l’interfacciamento con Windows in WIL](./doc/WIL.md)

---

## Codice di condotta

Questo progetto ha adottato il [Codice di Condotta Open Source di Microsoft][conduct-code]. Per ulteriori informazioni, consulta le [FAQ sul Codice di Condotta][conduct-FAQ] o contatta [opencode@microsoft.com][conduct-email] per eventuali domande o commenti aggiuntivi.

[conduct-code]: https://opensource.microsoft.com/codeofconduct/
[conduct-FAQ]: https://opensource.microsoft.com/codeofconduct/faq/
[conduct-email]: mailto:opencode@microsoft.com
[store-install-link]: https://aka.ms/terminal

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---