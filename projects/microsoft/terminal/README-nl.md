![terminal-logos](https://github.com/microsoft/terminal/assets/91625426/333ddc76-8ab2-4eb4-a8c0-4d7b953b1179)

[![Terminal Build Status](https://dev.azure.com/shine-oss/terminal/_apis/build/status%2FTerminal%20CI?branchName=main)](https://dev.azure.com/shine-oss/terminal/_build/latest?definitionId=1&branchName=main)

# Welkom bij de Windows Terminal, Console en Command-Line repository

<details>
  <summary><strong>Inhoudsopgave</strong></summary>

- [Windows Terminal installeren en uitvoeren](#windows-terminal-installeren-en-uitvoeren)
  - [Microsoft Store \[Aanbevolen\]](#microsoft-store-aanbevolen)
  - [Andere installatiemethoden](#andere-installatiemethoden)
    - [Via GitHub](#via-github)
    - [Via Windows Package Manager CLI (ook wel winget)](#via-windows-package-manager-cli-ook-wel-winget)
    - [Via Chocolatey (onofficieel)](#via-chocolatey-onofficieel)
    - [Via Scoop (onofficieel)](#via-scoop-onofficieel)
- [Windows Terminal Canary installeren](#windows-terminal-canary-installeren)
- [Windows Terminal Roadmap](#windows-terminal-roadmap)
- [Terminal & Console Overzicht](#terminal--console-overzicht)
  - [Windows Terminal](#windows-terminal)
  - [De Windows Console Host](#de-windows-console-host)
  - [Gedeelde Componenten](#gedeelde-componenten)
  - [Het maken van de nieuwe Windows Terminal](#het-maken-van-de-nieuwe-windows-terminal)
- [Bronnen](#bronnen)
- [FAQ](#faq)
  - [Ik heb de nieuwe Terminal gebouwd en uitgevoerd, maar deze lijkt op de oude console](#ik-heb-de-nieuwe-terminal-gebouwd-en-uitgevoerd-maar-deze-lijkt-op-de-oude-console)
- [Documentatie](#documentatie)
- [Bijdragen](#bijdragen)
- [Communiceren met het Team](#communiceren-met-het-team)
- [Ontwikkelaarsrichtlijnen](#ontwikkelaarsrichtlijnen)
- [Vereisten](#vereisten)
- [De code bouwen](#de-code-bouwen)
  - [Bouwen in PowerShell](#bouwen-in-powershell)
  - [Bouwen in Cmd](#bouwen-in-cmd)
- [Uitvoeren & Debuggen](#uitvoeren--debuggen)
  - [Codeerrichtlijnen](#codeerrichtlijnen)
- [Gedragscode](#gedragscode)

</details>

<br />

Deze repository bevat de broncode voor:

* [Windows Terminal](https://aka.ms/terminal)
* [Windows Terminal Preview](https://aka.ms/terminal-preview)
* De Windows console host (`conhost.exe`)
* Componenten die gedeeld worden tussen beide projecten
* [ColorTool](./src/tools/ColorTool)
* [Voorbeeldprojecten](./samples)
  die laten zien hoe de Windows Console API's gebruikt kunnen worden

Gerelateerde repositories zijn onder andere:

* [Windows Terminal Documentatie](https://docs.microsoft.com/windows/terminal)
  ([Repo: Draag bij aan de documentatie](https://github.com/MicrosoftDocs/terminal))
* [Console API Documentatie](https://github.com/MicrosoftDocs/Console-Docs)
* [Cascadia Code Lettertype](https://github.com/Microsoft/Cascadia-Code)

## Windows Terminal installeren en uitvoeren

> [!NOTE]
> Windows Terminal vereist Windows 10 2004 (build 19041) of nieuwer

### Microsoft Store [Aanbevolen]

Installeer de [Windows Terminal vanuit de Microsoft Store][store-install-link].
Hierdoor heb je altijd de nieuwste versie wanneer we nieuwe builds uitbrengen
met automatische updates.

Dit is onze voorkeursmethode.

### Andere installatiemethoden

#### Via GitHub

Voor gebruikers die Windows Terminal niet vanuit de Microsoft Store kunnen installeren,
kunnen de uitgebrachte builds handmatig worden gedownload van de [Releases-pagina](https://github.com/microsoft/terminal/releases) van deze repository.

Download het `Microsoft.WindowsTerminal_<versionNumber>.msixbundle` bestand uit
de sectie **Assets**. Om de app te installeren, kun je simpelweg dubbelklikken op het
`.msixbundle` bestand, waarna de app-installatie automatisch zou moeten starten. Als dat
om wat voor reden dan ook niet lukt, kun je het volgende commando proberen in een PowerShell-prompt:

```powershell
# OPMERKING: Als je PowerShell 7+ gebruikt, voer dan
# Import-Module Appx -UseWindowsPowerShell
# uit voordat je Add-AppxPackage gebruikt.

Add-AppxPackage Microsoft.WindowsTerminal_<versionNumber>.msixbundle
```

> [!NOTE]
> Als je Terminal handmatig installeert:
>
> * Mogelijk moet je het [VC++ v14 Desktop Framework Package](https://docs.microsoft.com/troubleshoot/cpp/c-runtime-packages-desktop-bridge#how-to-install-and-update-desktop-framework-packages) installeren.
>   Dit is alleen nodig op oudere builds van Windows 10 en alleen als je een foutmelding krijgt over ontbrekende frameworkpakketten.
> * Terminal zal niet automatisch updaten wanneer er nieuwe builds uitkomen, dus je zult
>   regelmatig de nieuwste Terminal-release moeten installeren om de laatste
>   fixes en verbeteringen te ontvangen!

#### Via Windows Package Manager CLI (ook wel winget)

[winget](https://github.com/microsoft/winget-cli) gebruikers kunnen de nieuwste Terminal-release downloaden en installeren
door het `Microsoft.WindowsTerminal` pakket te installeren:

```powershell
winget install --id Microsoft.WindowsTerminal -e
```

> [!NOTE]
> Ondersteuning voor afhankelijkheden is beschikbaar in WinGet versie [1.6.2631 of nieuwer](https://github.com/microsoft/winget-cli/releases). Om de stabiele Terminal-release 1.18 of nieuwer te installeren, zorg ervoor dat je de bijgewerkte versie van de WinGet-client hebt.

#### Via Chocolatey (onofficieel)

[Chocolatey](https://chocolatey.org) gebruikers kunnen de nieuwste Terminal-release downloaden en installeren door het
`microsoft-windows-terminal` pakket te installeren:

```powershell
choco install microsoft-windows-terminal
```

Om Windows Terminal te upgraden met Chocolatey, voer het volgende uit:

```powershell
choco upgrade microsoft-windows-terminal
```

Als je problemen ondervindt bij het installeren/upgraden van het pakket ga dan naar de
[Windows Terminal pakketpagina](https://chocolatey.org/packages/microsoft-windows-terminal) en volg het
[Chocolatey triageproces](https://chocolatey.org/docs/package-triage-process)

#### Via Scoop (onofficieel)

[Scoop](https://scoop.sh) gebruikers kunnen de nieuwste Terminal-release downloaden en installeren door het
`windows-terminal` pakket te installeren:

```powershell
scoop bucket add extras
scoop install windows-terminal
```

Om Windows Terminal te updaten met Scoop, voer het volgende uit:

```powershell
scoop update windows-terminal
```

Als je problemen ondervindt bij het installeren/updaten van het pakket, zoek dan of meld het op de [issues pagina](https://github.com/lukesampson/scoop-extras/issues) van de Scoop Extras bucket repository.

---

## Windows Terminal Canary installeren
Windows Terminal Canary is een nachtelijke build van Windows Terminal. Deze build bevat de nieuwste code van onze `main` branch, zodat je de kans krijgt om functies te proberen voordat ze beschikbaar zijn in Windows Terminal Preview.

Windows Terminal Canary is onze minst stabiele versie, dus je kunt bugs tegenkomen voordat wij ze hebben gevonden.

Windows Terminal Canary is beschikbaar als een App Installer distributie en een Portable ZIP distributie.

De App Installer distributie ondersteunt automatische updates. Door platformbeperkingen werkt deze installer alleen op Windows 11.

De Portable ZIP distributie is een draagbare applicatie. Deze zal niet automatisch updaten en zal ook niet automatisch controleren op updates. Deze portable ZIP distributie werkt op Windows 10 (19041+) en Windows 11.

| Distributie   | Architectuur    | Link                                                 |
|---------------|:---------------:|------------------------------------------------------|
| App Installer | x64, arm64, x86 | [download](https://aka.ms/terminal-canary-installer) |
| Portable ZIP  | x64             | [download](https://aka.ms/terminal-canary-zip-x64)   |
| Portable ZIP  | ARM64           | [download](https://aka.ms/terminal-canary-zip-arm64) |
| Portable ZIP  | x86             | [download](https://aka.ms/terminal-canary-zip-x86)   |

_Lees meer over de [typen Windows Terminal distributies](https://learn.microsoft.com/windows/terminal/distributions)._

---

## Windows Terminal Roadmap

Het plan voor de Windows Terminal [wordt hier beschreven](/doc/roadmap-2023.md) en
zal worden bijgewerkt naarmate het project vordert.

## Terminal & Console Overzicht

Neem een paar minuten de tijd om onderstaand overzicht te bekijken voordat je in de
code duikt:

### Windows Terminal

Windows Terminal is een nieuwe, moderne, uitgebreide en productieve terminalapplicatie
voor command-line gebruikers. Het bevat veel van de meest gevraagde functies
door de Windows command-line gemeenschap, zoals ondersteuning voor tabbladen, rijke
tekst, globalisatie, configureerbaarheid, thematisering & styling, en meer.

De Terminal moet ook voldoen aan onze doelstellingen en criteria om ervoor te zorgen dat deze snel en efficiënt blijft en geen grote hoeveelheden geheugen of stroom verbruikt.

### De Windows Console Host

De Windows Console host, `conhost.exe`, is de oorspronkelijke command-line gebruikerservaring van Windows. Het host ook de command-line infrastructuur van Windows en de Windows Console API-server, invoermotor, rendering engine, gebruikersvoorkeuren, enzovoort. De console host code in deze repository is de werkelijke bron waaruit de
`conhost.exe` in Windows zelf is gebouwd.

Sinds de overname van de Windows command-line in 2014 heeft het team
meerdere nieuwe functies toegevoegd aan de Console, waaronder achtergrondtransparantie,
lijngebaseerde selectie, ondersteuning voor [ANSI / Virtual Terminal
sequenties](https://en.wikipedia.org/wiki/ANSI_escape_code), [24-bit
kleur](https://devblogs.microsoft.com/commandline/24-bit-color-in-the-windows-console/),
een [Pseudoconsole
("ConPTY")](https://devblogs.microsoft.com/commandline/windows-command-line-introducing-the-windows-pseudo-console-conpty/),
en meer.

Echter, omdat het primaire doel van de Windows Console is om achterwaartse compatibiliteit te behouden, konden we veel functies die de community
(en het team) de afgelopen jaren wilde (zoals tabbladen, unicode tekst en emoji) niet toevoegen.

Deze beperkingen hebben geleid tot het creëren van de nieuwe Windows Terminal.

> Je kunt meer lezen over de evolutie van de command-line in het algemeen, en de
> Windows command-line specifiek in [deze bijbehorende reeks blogposts](https://devblogs.microsoft.com/commandline/windows-command-line-backgrounder/)
> op de blog van het Command-Line-team.

### Gedeelde Componenten

Tijdens het vernieuwen van de Windows Console hebben we de codebase aanzienlijk gemoderniseerd, logische entiteiten netjes gescheiden in modules en klassen, enkele belangrijke uitbreidbaarheidspunten geïntroduceerd, verschillende oude, zelfgemaakte collecties en containers vervangen door veiligere en efficiëntere [STL containers](https://docs.microsoft.com/en-us/cpp/standard-library/stl-containers?view=vs-2022), en de code eenvoudiger en veiliger gemaakt door gebruik te maken van Microsoft's [Windows Implementation Libraries - WIL](https://github.com/Microsoft/wil).

Deze vernieuwing heeft ertoe geleid dat verschillende belangrijke componenten van de Console herbruikbaar zijn in iedere terminalimplementatie op Windows. Deze componenten omvatten een nieuwe DirectWrite-gebaseerde tekstlayout en rendering engine, een tekstbuffer die zowel UTF-16 als UTF-8 kan opslaan, een VT-parser/emitter en meer.

### Het maken van de nieuwe Windows Terminal

Toen we begonnen met het plannen van de nieuwe Windows Terminal-applicatie, onderzochten en evalueerden we verschillende benaderingen en technologiestapels. Uiteindelijk hebben we besloten dat onze doelen het beste bereikt konden worden door verder te investeren in onze C++ codebase,
waardoor we verschillende van de eerder genoemde gemoderniseerde componenten zowel in de bestaande Console als in de nieuwe Terminal konden hergebruiken. Verder realiseerden we ons dat dit ons in staat zou stellen om een groot deel van de kern van de Terminal zelf te bouwen als een herbruikbare UI-control die anderen in hun eigen applicaties kunnen opnemen.

Het resultaat van dit werk is te vinden in deze repo en wordt geleverd als de
Windows Terminal applicatie die je kunt downloaden uit de Microsoft Store, of
[direct vanuit de releases van deze repo](https://github.com/microsoft/terminal/releases).

---

## Bronnen

Voor meer informatie over Windows Terminal kun je mogelijk deze bronnen nuttig en interessant vinden:

* [Command-Line Blog](https://devblogs.microsoft.com/commandline)
* [Command-Line Backgrounder Blogreeks](https://devblogs.microsoft.com/commandline/windows-command-line-backgrounder/)
* Windows Terminal Launch: [Terminal "Sizzle Video"](https://www.youtube.com/watch?v=8gw0rXPMMPE&list=PLEHMQNlPj-Jzh9DkNpqipDGCZZuOwrQwR&index=2&t=0s)
* Windows Terminal Launch: [Build 2019 Sessie](https://www.youtube.com/watch?v=KMudkRcwjCw)
* Run As Radio: [Show 645 - Windows Terminal met Richard Turner](https://www.runasradio.com/Shows/Show/645)
* Azure Devops Podcast: [Aflevering 54 - Kayla Cinnamon en Rich Turner over DevOps op het Windows Terminal team](http://azuredevopspodcast.clear-measure.com/kayla-cinnamon-and-rich-turner-on-devops-on-the-windows-terminal-team-episode-54)
* Microsoft Ignite 2019 Sessie: [De Moderne Windows Command Line: Windows Terminal - BRK3321](https://myignite.techcommunity.microsoft.com/sessions/81329?source=sessions)

---

## FAQ

### Ik heb de nieuwe Terminal gebouwd en uitgevoerd, maar deze lijkt op de oude console

Oorzaak: Je start de verkeerde oplossing in Visual Studio.

Oplossing: Zorg ervoor dat je het `CascadiaPackage` project bouwt & uitrolt in Visual Studio.

> [!NOTE]
> `OpenConsole.exe` is slechts een lokaal gebouwde `conhost.exe`, de klassieke
> Windows Console die de command-line infrastructuur van Windows host. OpenConsole
> wordt gebruikt door Windows Terminal om verbinding te maken met en te communiceren met command-line
> applicaties (via
> [ConPty](https://devblogs.microsoft.com/commandline/windows-command-line-introducing-the-windows-pseudo-console-conpty/)).

---

## Documentatie

Alle projectdocumentatie bevindt zich op [aka.ms/terminal-docs](https://aka.ms/terminal-docs). Als je wilt bijdragen aan de documentatie, dien dan een pull request in op de [Windows Terminal Documentatie repo](https://github.com/MicrosoftDocs/terminal).

---

## Bijdragen

We zijn enthousiast om samen te werken met jou, onze geweldige community, om Windows Terminal te bouwen en te verbeteren!

***VOORDAT je begint aan een functie/fix***, lees & volg onze
[Richtlijnen voor bijdragers](./CONTRIBUTING.md) om
onnodig of dubbel werk te voorkomen.

## Communiceren met het Team

De makkelijkste manier om met het team te communiceren is via GitHub issues.

Maak nieuwe issues, feature requests en suggesties aan, maar **zoek eerst naar vergelijkbare open/dichte bestaande issues voordat je een nieuw issue aanmaakt.**

Als je een vraag wilt stellen waarvan je denkt dat deze nog geen issue waard is,
neem dan contact met ons op via Twitter:

* Christopher Nguyen, Product Manager:
  [@nguyen_dows](https://twitter.com/nguyen_dows)
* Dustin Howett, Engineering Lead: [@dhowett](https://twitter.com/DHowett)
* Mike Griese, Senior Developer: [@zadjii@mastodon.social](https://mastodon.social/@zadjii)
* Carlos Zamora, Developer: [@cazamor_msft](https://twitter.com/cazamor_msft)
* Pankaj Bhojwani, Developer
* Leonard Hecker, Developer: [@LeonardHecker](https://twitter.com/LeonardHecker)

## Ontwikkelaarsrichtlijnen

## Vereisten

Je kunt je omgeving op twee manieren configureren om Terminal te bouwen:

### Met een WinGet-configuratiebestand

Na het klonen van de repository kun je een [WinGet-configuratiebestand](https://learn.microsoft.com/en-us/windows/package-manager/configuration/#use-a-winget-configuration-file-to-configure-your-machine)
gebruiken om je omgeving in te stellen. Het [standaard configuratiebestand](.config/configuration.winget) installeert Visual Studio 2022 Community en de rest van de vereiste tools. Er zijn twee andere varianten van het configuratiebestand beschikbaar in de [.config](.config) directory voor Enterprise & Professional edities van Visual Studio 2022. Om het standaard configuratiebestand uit te voeren, kun je het bestand dubbelklikken in de verkenner of het volgende commando uitvoeren:

```powershell
winget configure .config\configuration.winget
```

### Handmatige configuratie

* Je moet Windows 10 2004 (build >= 10.0.19041.0) of nieuwer draaien om
  Windows Terminal te kunnen uitvoeren
* Je moet [Developer Mode in de Windows Instellingen app inschakelen](https://docs.microsoft.com/en-us/windows/uwp/get-started/enable-your-device-for-development)
  om Windows Terminal lokaal te installeren en uit te voeren
* Je moet [PowerShell 7 of nieuwer](https://github.com/PowerShell/PowerShell/releases/latest) geïnstalleerd hebben
* Je moet het [Windows 11 (10.0.22621.0) SDK](https://developer.microsoft.com/en-us/windows/downloads/windows-sdk/)
  geïnstalleerd hebben
* Je moet ten minste [VS 2022](https://visualstudio.microsoft.com/downloads/) geïnstalleerd hebben
* Je moet de volgende Workloads installeren via de VS Installer. Let op: Het openen
  van de oplossing in VS 2022 zal je [automatisch vragen om ontbrekende componenten te installeren](https://devblogs.microsoft.com/setup/configure-visual-studio-across-your-organization-with-vsconfig/):
  * Desktopontwikkeling met C++
  * Universal Windows Platform ontwikkeling
  * **De volgende individuele componenten**
    * C++ (v143) Universal Windows Platform Tools
* Je moet het [.NET Framework Targeting Pack](https://docs.microsoft.com/dotnet/framework/install/guide-for-developers#to-install-the-net-framework-developer-pack-or-targeting-pack) installeren om testprojecten te kunnen bouwen

## De code bouwen

OpenConsole.sln kan worden gebouwd vanuit Visual Studio of vanaf de opdrachtregel
met behulp van een set handige scripts & tools in de **/tools** directory:

### Bouwen in PowerShell

```powershell
Import-Module .\tools\OpenConsole.psm1
Set-MsBuildDevEnvironment
Invoke-OpenConsoleBuild
```

### Bouwen in Cmd

```shell
.\tools\razzle.cmd
bcz
```

## Uitvoeren & Debuggen

Om de Windows Terminal te debuggen in VS, klik met de rechtermuisknop op `CascadiaPackage` (in de Solution Explorer) en ga naar eigenschappen. In het Debug-menu wijzig je "Application process" en "Background task process" naar "Native Only".

Je zou nu het Terminal-project moeten kunnen bouwen & debuggen door op
<kbd>F5</kbd> te drukken. Zorg ervoor dat je het "x64" of het "x86" platform selecteert - de
Terminal wordt niet gebouwd voor "Any Cpu" (omdat de Terminal een C++ applicatie is,
geen C# applicatie).

> 👉 Je kunt de Terminal _niet_ direct starten door WindowsTerminal.exe uit te voeren. Voor meer details waarom, zie
> [#926](https://github.com/microsoft/terminal/issues/926),
> [#4043](https://github.com/microsoft/terminal/issues/4043)

### Codeerrichtlijnen

Bekijk deze korte documenten hieronder over onze codeerpraktijken.

> 👉 Als je iets mist in deze documenten, voel je vrij om bij te dragen aan
> een van onze documentatiebestanden ergens in de repository (of schrijf er zelf een!)

Dit is een work in progress terwijl we leren wat we mensen moeten bieden
om effectieve bijdragers aan ons project te zijn.

* [Codeerstijl](./doc/STYLE.md)
* [Codeorganisatie](./doc/ORGANIZATION.md)
* [Uitzonderingen in onze legacy codebase](./doc/EXCEPTIONS.md)
* [Handige smart pointers en macro's voor interfacing met Windows in WIL](./doc/WIL.md)

---

## Gedragscode

Dit project heeft de [Microsoft Open Source Code of Conduct][conduct-code] aangenomen. Voor meer informatie zie de [Gedragscode FAQ][conduct-FAQ] of neem contact op met [opencode@microsoft.com][conduct-email] bij aanvullende vragen of opmerkingen.

[conduct-code]: https://opensource.microsoft.com/codeofconduct/
[conduct-FAQ]: https://opensource.microsoft.com/codeofconduct/faq/
[conduct-email]: mailto:opencode@microsoft.com
[store-install-link]: https://aka.ms/terminal

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---