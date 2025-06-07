# Microsoft PowerToys

![Hero image voor Microsoft PowerToys](doc/images/overview/PT_hero_image.png)

[Hoe PowerToys te gebruiken][usingPowerToys-docs-link] | [Downloads & Release-opmerkingen][github-release-link] | [Bijdragen aan PowerToys](#bijdragen) | [Wat gebeurt er](#wat-gebeurt-er) | [Roadmap](#powertoys-roadmap)

## Over

Microsoft PowerToys is een set hulpprogramma's voor power users om hun Windows-ervaring te verfijnen en te stroomlijnen voor meer productiviteit. Voor meer informatie over [PowerToys-overzichten en het gebruik van de hulpprogramma's][usingPowerToys-docs-link], of andere tools en bronnen voor [Windows ontwikkelomgevingen](https://learn.microsoft.com/windows/dev-environment/overview), ga naar [learn.microsoft.com][usingPowerToys-docs-link]!

|              | Huidige hulpprogramma's: |              |
|--------------|--------------------------|--------------|
| [Geavanceerd plakken](https://aka.ms/PowerToysOverview_AdvancedPaste) | [Altijd bovenaan](https://aka.ms/PowerToysOverview_AoT) | [PowerToys Awake](https://aka.ms/PowerToysOverview_Awake) |
| [Kleurkiezer](https://aka.ms/PowerToysOverview_ColorPicker) | [Commando niet gevonden](https://aka.ms/PowerToysOverview_CmdNotFound) | [Command Palette](https://aka.ms/PowerToysOverview_CmdPal) |
| [Bijsnijden en vergrendelen](https://aka.ms/PowerToysOverview_CropAndLock) | [Omgevingsvariabelen](https://aka.ms/PowerToysOverview_EnvironmentVariables) | [FancyZones](https://aka.ms/PowerToysOverview_FancyZones) |
| [Bestandsverkenner-invoegtoepassingen](https://aka.ms/PowerToysOverview_FileExplorerAddOns) | [Bestandsvergrendelaar](https://aka.ms/PowerToysOverview_FileLocksmith) | [Hosts-bestand editor](https://aka.ms/PowerToysOverview_HostsFileEditor) |
| [Afbeeldingsgrootte wijzigen](https://aka.ms/PowerToysOverview_ImageResizer) | [Toetsenbordbeheer](https://aka.ms/PowerToysOverview_KeyboardManager) | [Muis-hulpprogramma's](https://aka.ms/PowerToysOverview_MouseUtilities) |
| [Muis zonder grenzen](https://aka.ms/PowerToysOverview_MouseWithoutBorders) | [Nieuw+](https://aka.ms/PowerToysOverview_NewPlus) | [Plakken als platte tekst](https://aka.ms/PowerToysOverview_PastePlain) |
| [Peek](https://aka.ms/PowerToysOverview_Peek) | [PowerRename](https://aka.ms/PowerToysOverview_PowerRename) | [PowerToys Run](https://aka.ms/PowerToysOverview_PowerToysRun) |
| [Quick Accent](https://aka.ms/PowerToysOverview_QuickAccent) | [Registervoorbeeld](https://aka.ms/PowerToysOverview_RegistryPreview) | [Schermliniaal](https://aka.ms/PowerToysOverview_ScreenRuler) |
| [Sneltoetsgids](https://aka.ms/PowerToysOverview_ShortcutGuide) | [Tekstextractor](https://aka.ms/PowerToysOverview_TextExtractor) | [Werkruimtes](https://aka.ms/PowerToysOverview_Workspaces) |
| [ZoomIt](https://aka.ms/PowerToysOverview_ZoomIt) |

## Microsoft PowerToys installeren en uitvoeren

### Vereisten

- Windows 11 of Windows 10 versie 2004 (codenaam 20H1 / buildnummer 19041) of nieuwer.
- x64- of ARM64-processor
- Onze installer zal de volgende items installeren:
   - [Microsoft Edge WebView2 Runtime](https://go.microsoft.com/fwlink/p/?LinkId=2124703) bootstrapper. Hiermee wordt de nieuwste versie geïnstalleerd.

### Via GitHub met EXE [Aanbevolen]

Ga naar de [Microsoft PowerToys GitHub releases pagina][github-release-link] en klik onderaan op `Assets` om de beschikbare bestanden te tonen. Gebruik de juiste PowerToys-installatiebestand die past bij de architectuur en installatiescope van jouw machine. Voor de meesten is dit `x64` en per gebruiker.

<!-- items that need to be updated release to release -->
[github-next-release-work]: https://github.com/microsoft/PowerToys/issues?q=is%3Aissue+milestone%3A%22PowerToys+0.92%22
[github-current-release-work]: https://github.com/microsoft/PowerToys/issues?q=is%3Aissue+milestone%3A%22PowerToys+0.91%22
[ptUserX64]: https://github.com/microsoft/PowerToys/releases/download/v0.91.1/PowerToysUserSetup-0.91.1-x64.exe 
[ptUserArm64]: https://github.com/microsoft/PowerToys/releases/download/v0.91.1/PowerToysUserSetup-0.91.1-arm64.exe 
[ptMachineX64]: https://github.com/microsoft/PowerToys/releases/download/v0.91.1/PowerToysSetup-0.91.1-x64.exe 
[ptMachineArm64]: https://github.com/microsoft/PowerToys/releases/download/v0.91.1/PowerToysSetup-0.91.1-arm64.exe
 
|  Omschrijving   | Bestandsnaam | sha256-hash |
|-----------------|-------------|-------------|
| Per gebruiker - x64       | [PowerToysUserSetup-0.91.1-x64.exe][ptUserX64] | 42EA4A3E8C79A5456476D19E72B3E2AB9393A89C4DC7442EB7EE5A1E3490D38A |
| Per gebruiker - ARM64     | [PowerToysUserSetup-0.91.1-arm64.exe][ptUserArm64] | F3F433FE04049F9197411D792AADEBF34E3BE7FE16327BD8B73D2A046ED8BAF6 |
| Systeemwijd - x64   | [PowerToysSetup-0.91.1-x64.exe][ptMachineX64] | EC4BC3A8625775866B0ED4577CCF83E6EC7B1A0AD267379DDBAF4FE49C7B5BDD |
| Systeemwijd - ARM64 | [PowerToysSetup-0.91.1-arm64.exe][ptMachineArm64] | 9CB8911008420D0E446AE3D5CE365E447FA4DF9DCF9337F3A80F933C00FC3689 |

Dit is onze voorkeursmethode.

### Via Microsoft Store

Installeer vanuit de [Microsoft Store PowerToys-pagina][microsoft-store-link]. Je moet de [nieuwe Microsoft Store](https://blogs.windows.com/windowsExperience/2021/06/24/building-a-new-open-microsoft-store-on-windows-11/) gebruiken, die beschikbaar is voor zowel Windows 11 als Windows 10.

### Via WinGet

Download PowerToys van [WinGet][winget-link]. Bijwerken van PowerToys via winget respecteert de huidige installatiescope van PowerToys. Om PowerToys te installeren, voer je het volgende commando uit vanaf de opdrachtregel / PowerShell:

#### Installer voor gebruiker [standaard]
```powershell
winget install Microsoft.PowerToys -s winget
```

#### Installer voor het hele systeem

```powershell
winget install --scope machine Microsoft.PowerToys -s winget
```

### Andere installatiemethoden

Er zijn [door de community ondersteunde installatiemethoden](./doc/unofficialInstallMethods.md) zoals Chocolatey en Scoop. Als dit jouw voorkeursoplossingen zijn, vind je daar de instructies.

## Plug-ins van derden voor Run

Er is een verzameling [plug-ins van derden](./doc/thirdPartyRunPlugins.md) die door de community zijn gemaakt en niet worden meegeleverd met PowerToys.

## Bijdragen

Dit project verwelkomt bijdragen van alle soorten. Naast het coderen van functies / het oplossen van bugs, kun je ook helpen door specificaties te schrijven, ontwerp, documentatie en het vinden van bugs. We werken graag samen met de power user-community om een set tools te bouwen waarmee je het maximale uit Windows haalt.

We vragen dat **je voordat je aan een functie werkt die je wilt bijdragen**, ons [Contributor's Guide](CONTRIBUTING.md) leest. We helpen je graag met het bepalen van de beste aanpak, bieden begeleiding en mentorship tijdens de ontwikkeling van functies, en helpen om verspilde of dubbele inspanningen te voorkomen.

De meeste bijdragen vereisen dat je akkoord gaat met een [Contributor License Agreement (CLA)][oss-CLA] waarin je verklaart dat je ons het recht geeft om je bijdrage te gebruiken en dat je hiervoor toestemming hebt.

Voor begeleiding over ontwikkelen voor PowerToys, lees de [ontwikkelaarsdocumentatie](/doc/devdocs) voor een gedetailleerd overzicht. Dit bevat onder andere hoe je je computer instelt om te kunnen compileren.

## Wat gebeurt er

### PowerToys Roadmap

Onze [geprioriteerde roadmap][roadmap] van functies en hulpprogramma's waarop het kernteam zich richt.

### 0.91 - Update mei 2025

In deze release hebben we ons gericht op nieuwe functies, stabiliteit en automatisering.

**✨Hoogtepunten**

 - We hebben ons sterk gericht op het verbeteren van de prestaties van Command Palette en het oplossen van veel bugs. Enkele nieuwe functies die we hebben toegevoegd zijn:
 - Mogelijkheid toegevoegd voor Command Palette om elk bestand te zoeken met een fallback-commando.
 - Mogelijkheid toegevoegd om van de Command Palette globale sneltoets een low-level keyboard hook te maken.
 - Open URL fallback-commando toegevoegd voor de WebSearch-extensie, waardoor gebruikers direct URL’s in de browser kunnen openen vanuit Command Palette.
 - Je kunt nu aangepaste formaten definiëren in de Datum- en Tijd-plug-ins van PT Run en Command Palette. Dank aan [@htcfreek](https://github.com/htcfreek)!

### Geavanceerd plakken

 - Opgelost: Advanced Paste kon geen OCR-engine maken voor bepaalde Engelse taal-tags (bijv. en-CA) door de OCR-engine te initialiseren met de taal van het gebruikersprofiel. Dank aan [@cryolithic](https://github.com/cryolithic)!

### Kleurkiezer

 - Opgelost: een resourcelek veroorzaakte vastlopen of crashes door het Graphics-object correct af te voeren. Dank aan [@dcog989](https://github.com/dcog989)!
 - Opgelost: Color Picker sloot af bij het indrukken van Backspace door te zorgen dat deze alleen sluit als deze is gefocust en Escape/Backspace-gedrag te stroomlijnen. Dank aan [@PesBandi](https://github.com/PesBandi)!
 - Ondersteuning toegevoegd voor Oklab- en Oklch-kleurformaten in Color Picker. Dank aan [@lemonyte](https://github.com/lemonyte)!

### Commando niet gevonden

 - WinGet Command Not Found-script bijgewerkt om experimentele functies alleen in te schakelen als ze daadwerkelijk bestaan.

### Command Palette

 - Bugtemplate bijgewerkt om Command Palette-module op te nemen.
 - Opgelost: het toastvenster werd niet geschaald voor DPI, wat lay-outproblemen veroorzaakte bij display scaling.
 - Opgelost: toetsenbordnavigatie omhoog/omlaag verplaatste de selectie niet als de caret op positie 0 stond, en continue navigatie toegevoegd zoals PT Run v1. Dank aan [@davidegiacometti](https://github.com/davidegiacometti)!
 - Tijd- en datumeigenschappen bijgewerkt om eenvoudiger en duidelijker te maken.
 - Opgelost: hoofdlettergebruik in het commando veroorzaakte falen bij het gaan naar de muisaanwijzer, opgelost door het commando in kleine letters te zetten.
 - Open URL fallback-commando toegevoegd voor de WebSearch-extensie, waardoor gebruikers direct URL’s in de browser kunnen openen vanuit Command Palette. Dank aan [@htcfreek](https://github.com/htcfreek)!
 - Instelling toegevoegd om systeemvakpictogram in CmdPal in/uit te schakelen en terminologie afgestemd op Windows 11. Dank aan [@davidegiacometti](https://github.com/davidegiacometti)!
 - Opgelost: alias-updateprobleem door de oude alias te verwijderen als er een nieuwe wordt ingesteld.
 - GitHub-hoofdletterconflict opgelost door Exts en exts te migreren naar een nieuwe ext-directory, wat zorgt voor een consistente structuur tussen platforms en padfragmentatie voorkomt.
 - Opgelost: het commando 'Nieuwe extensie maken' genereerde lege bestandsnamen.
 - Mogelijkheid toegevoegd om van de globale sneltoets een low-level keyboard hook te maken.
 - Ondersteuning toegevoegd voor JUMBO-thumbnails, waarmee toegang tot hoge resolutie-iconen mogelijk is.
 - Crashes opgelost wanneer CmdPal zichzelf automatisch verborg terwijl een MSAL-dialoog was geopend, door te voorkomen dat CmdPal zich verbergt als deze is uitgeschakeld.
 - Ondersteuning toegevoegd voor direct selecteren van zoektekst bij het laden van een pagina.
 - Opgelost: extensie-instellingenpagina’s werden niet opnieuw geladen bij heropenen door het instellingenformulier bij te werken wanneer extensie-instellingen worden opgeslagen.
 - Opgelost: Command Palette kon niet worden gestart vanuit de runner.
 - PowerToys Run v1 rekenmachine-logica gerefactord en geporteerd naar Command Palette, ondersteuning voor instellingen toegevoegd en fallback-gedrag verbeterd.
 - Ondersteuning opnieuw toegevoegd voor sneltoetsen op lijstitems.
 - Toegankelijkheid verbeterd in Command Palette door juiste labels toe te voegen, animaties te verfijnen, lokalisatie te verbeteren en a11y-gerelateerde problemen op te lossen.
 - Ondersteuning voor aangepast formaat overgenomen naar de Tijd- en Datum-plug-in, instellingen herordend en opgeschoond, foutmeldingen verbeterd en edge-case crashes verholpen voor robuuster en gebruiksvriendelijker gedrag. Dank aan [@htcfreek](https://github.com/htcfreek)!
 - Fallback-item toegevoegd voor systeemcommando.
 - Opgelost: in Windows Systeemcommando werd het prompt voor de toets foutief weergegeven als "Leeg" voor de "Prullenbak openen"-actie. Dank aan [@jironemo](https://github.com/jironemo)!
 - Opgelost: de lijst 'meer commando's' toonde commando's die niet zichtbaar mochten zijn. Dank aan [@davidegiacometti](https://github.com/davidegiacometti)!
 - Opgelost: het detailscherm in Command Palette toonde een te groot pictogram en verkeerd uitgelijnde tekst, nu in lijn met Windows Search-gedrag.
 - Opgelost: lege scherminhoud en commando’s werden afgekapt bij lange labels, waardoor nu de lay-out en zichtbaarheid correct zijn.
 - WinGet-integratie in CmdPal verbeterd door versie-informatie voor geïnstalleerde pakketten te tonen, updates met iconen mogelijk te maken en de preview winget API te migreren naar een stabiele versie.
 - Opgelost: commando’s voor ContentPage werden pas bijgewerkt na afsluiten, door contextmenu’s volledig te initialiseren bij wijziging.
 - Fallback-ondersteuning toegevoegd aan de TimeDate-extensie, waarmee directe datum/tijd-queries mogelijk zijn zonder vooraf het commando te selecteren.
 - Import van Common.Dotnet.AotCompatibility.props toegevoegd aan meerdere CmdPal-projectbestanden voor betere AOT-compilatieondersteuning.
 - Opgelost: crash in CmdPal-instellingen veroorzaakt door een ontbrekende HotKey wanneer settings.json ontbreekt of geen hotkey bevat. Dank aan [@davidegiacometti](https://github.com/davidegiacometti)!
 - Ondersteuning toegevoegd voor filterbare, geneste contextmenu’s in CmdPal, inclusief een zoekvak om focusgedrag te behouden.
 - CmdPal-klassen gerefactord voor betere JSON-serialisatie en nieuwe serialisatiecontexten geïntroduceerd voor betere prestaties en onderhoudbaarheid.
 - Ondersteuning toegevoegd voor ahead-of-time (AoT)-compilatie.
 - Retry-mechanisme toegevoegd voor CmdPal-opstart.
 - Ongebruikte bestanden uit CmdPal.Common verwijderd om de codebase te vereenvoudigen en AoT-compatibel te maken.
 - Opgelost: raceconditie in het bijwerken van SearchText waardoor de cursor automatisch naar het einde van de regel sprong, nu wordt SearchText alleen bijgewerkt na daadwerkelijke wijziging.
 - Ondersteuning toegevoegd voor zoeken naar elk bestand in fallback-commando.
 - AoT-gerelateerde code opgeschoond om dubbele handelingen tijdens testen te voorkomen.
 - CmdPal laadtijd verkort door extensie-opstart te paralleliseren en time-outs toe te voegen om slecht functionerende extensies anderen niet te laten blokkeren.
 - UI-gedrag verbeterd door het detailscherm te sluiten wanneer de lijst wordt geleegd, waardoor inconsistente visuele staten worden vermeden.
 - Ondersteuning toegevoegd om het fallback-commando in CmdPal te verwijderen als er geen overeenkomend commando wordt gevonden, voor een schoner herlaadgedrag.
 - Lek in CmdPal-extensiesjabloon opgelost door onjuist ComServer-gebruik.
 - Voorkomen dat CmdPal-venster wordt gemaximaliseerd bij dubbelklikken op de titelbalk om het beoogde venster-gedrag te behouden. Dank aan [@davidegiacometti](https://github.com/davidegiacometti)!
 - Opgelost: de Settings UI werd te klein geopend door vensterafmetingen DPI-bewust te maken en een minimale breedte en hoogte te forceren via WinUIEx.
 - Witte flits en eenmalige animatieproblemen in CmdPal opgelost door het venster te verbergen in plaats van te verstoppen.
 - Opgelost: alle extensie-instellingen werden bij opstart opgehaald door lazy-loading te implementeren, waardoor de initialisatie wordt verkleind.
 - Ondersteuning toegevoegd voor bescherming van CmdPal tegen crashes bij Adaptive Card parse-fout.
 - shell:AppsFolder vervangen door URI-activering in CmdPal voor verbeterde betrouwbaarheid.
 - Mogelijkheid toegevoegd om CmdPal-instellingen te openen vanuit PowerToys-instellingen.
 - Mogelijkheid toegevoegd voor CmdPal om extensiedetails dynamisch bij te werken door propertywijzigingen van het geselecteerde item te volgen.
 - Toolkit-versie in CmdPal-extensiesjabloon opgehoogd naar 0.2.0.

### Afbeeldingsgrootte wijzigen

 - Opgelost: bij het verwijderen van een preset werd de verkeerde preset verwijderd.

### Toetsenbordbeheer

 - Opgelost: een modifier-toets bleef hangen als niet links of rechts was gespecificeerd, door de ingedrukte toetsen bij te houden en de juiste toets te sturen. Dank aan [@mantaionut](https://github.com/mantaionut)!

### PowerRename

 - Tijdsnotatie van PowerRename uitgebreid met 12-uurs tijdsformaat en AM/PM-ondersteuning. Dank aan [@bitmap4](https://github.com/bitmap4)!

### PowerToys Run

 - Ondersteuning toegevoegd voor aangepaste formaten in de plug-in "Tijd en Datum" en foutmeldingen verbeterd voor ongeldige invoerformaten. Dank aan [@htcfreek](https://github.com/htcfreek)!
 - Opgelost: twee crashes, één voor WFT op zeer vroege datums en een andere voor het berekenen van de week van de maand op zeer late datums (bijv. 31.12.9999), en UI-instellingen herordend. Dank aan [@htcfreek](https://github.com/htcfreek)!
 - Opgelost: hoofdlettergebruik in het commando veroorzaakte falen bij het gaan naar de muisaanwijzer, opgelost door het commando in kleine letters te zetten.
 - Versiedetails toegevoegd aan plug-in foutmeldingen voor 'Laadfout' en 'Init-fout'. Dank aan [@htcfreek](https://github.com/htcfreek)!
 - Resultaatmodel verbeterd door ondersteuning toe te voegen voor het voorkomen van sortering op gebruik, waardoor plug-in ontwikkelaars meer controle krijgen over het sorteren. Dank aan [@CoreyHayward](https://github.com/CoreyHayward) en [@htcfreek](https://github.com/htcfreek)!

### Quick Accent

 - Lettermapping in GetDefaultLetterKeyEPO bijgewerkt, "ǔ" vervangen door "ŭ" voor de VK_U-toets voor een nauwkeurige weergave van Esperanto-fonologie. Dank aan [@OlegKharchevkin](https://github.com/OlegKharchevkin)!
 - Opgelost: Quick Accent werkte niet goed bij gebruik van het schermtoetsenbord. Dank aan [@davidegiacometti](https://github.com/davidegiacometti)!

### Registervoorbeeld

 - Register Preview verbeterd om register-sleutels en -waarden te plakken zonder handmatig de header te schrijven, en een nieuwe knop toegevoegd voor het resetten van de app. Dank aan [@htcfreek](https://github.com/htcfreek)!

### Instellingen

 - Opgelost: de Settings-app toonde af en toe een blanco pictogram op de taakbalk door toewijzing van het pictogram uit te stellen tot het venster is geactiveerd.
 - Mogelijkheid toegevoegd om het venster "Wat is nieuw" te maximaliseren voor comfortabeler lezen.

### Werkruimtes

 - Bugs opgelost waarbij Steam-games niet correct werden vastgelegd of gestart door het bijwerken van vensterfiltering en integratie van Steam URL-protocolafhandeling.

### Documentatie

 - QuickNotes toegevoegd aan de documentatie van plug-ins van derden voor PowerToys Run. Dank aan [@ruslanlap](https://github.com/ruslanlap)!
 - Weather- en Pomodoro-plug-ins toegevoegd aan de documentatie van plug-ins van derden voor PowerToys Run. Dank aan [@ruslanlap](https://github.com/ruslanlap)!
 - De Linear-plug-in toegevoegd aan de documentatie van plug-ins van derden voor PowerToys Run. Dank aan [@vednig](https://github.com/vednig)!
 - Opmaakproblemen in documentatiebestanden opgelost en informatie over bijdragers en teamleden bijgewerkt. Dank aan [@DanielEScherzer](https://github.com/DanielEScherzer) en [@RokyZevon](https://github.com/RokyZevon)!

### Ontwikkeling

 - GitHub Action bijgewerkt om .NET 9 te installeren voor MSStore-releaseondersteuning.
 - Versie-placeholder bijgewerkt in bug_report.yml om onjuiste v0.70.0-versies in probleemrapporten te voorkomen.
 - GitHub Action bijgewerkt om actions/setup-dotnet te upgraden van versie 3 naar versie 4 voor MSStore-release.
 - securityContext toegevoegd aan WinGet-configuratiebestanden, waardoor aanroepen vanuit gebruikerscontext mogelijk zijn en een enkele UAC wordt gevraagd voor verhoogde resources in een apart proces. Dank aan [@mdanish-kh](https://github.com/mdanish-kh)!
 - Logbestandextensies gewijzigd van .txt naar .log voor betere bestandstoewijzing en toolingcompatibiliteit, en logs toegevoegd voor Workspace. Dank aan [@benwa](https://github.com/benwa)!
 - Testframework-afhankelijkheden geüpgraded en pakketversies tussen componenten gelijkgetrokken.
 - Afhankelijkheden geüpgraded om kwetsbaarheden te verhelpen.
 - Repositorybeveiliging verbeterd door GitHub Actions en Docker-tags te pinnen aan onveranderlijke commits en geautomatiseerde afhankelijkheidscontrole te integreren via Dependency Review Workflow. Dank aan [@Nick2bad4u](https://github.com/Nick2bad4u)!
 - Boost-afhankelijkheden geüpgraded naar een nieuwere versie.
 - Toolkit geüpgraded naar de nieuwste versie, AoT-gerelateerde waarschuwingen onderdrukt.
 - Opgelost: ontbrekende ondertekening voor nieuw toegevoegde bestanden veroorzaakte build-fouten.
 - Releasepipeline bijgewerkt om het publiceren van private symbolen gedurende 100 jaar te voorkomen.
 - Fuzzing voor PowerRename geïntroduceerd om de betrouwbaarheid te verbeteren en setup-instructies toegevoegd voor uitbreiding naar andere C++-modules.
 - Gecentraliseerde pre-creatie van gegenereerde mappen voor alle .csproj-projecten toegevoegd om build-fouten te voorkomen.
 - WinAppSDK bijgewerkt naar de nieuwste 1.7-versie.
 - Boost-afhankelijkheden geüpgraded naar de nieuwste versie voor het PowerRename Fuzzing-project.
 - Het ADO-gebiedspad in tsa.json bijgewerkt om TSA-pipelinefouten te verhelpen door een verouderd pad.
 - AoT-ondersteuning voor CmdPal geïnitieerd met fundamenteel werk in uitvoering.
  
### Tool/Algemeen

 - Ondersteuning toegevoegd voor het automatiseren van bugrapporten door een vooraf ingevulde GitHub-issue-URL te genereren met systeem- en diagnostische informatie. Dank aan [@donlaci](https://github.com/donlaci)!
 - Scripts toegevoegd om de installer lokaal te bouwen, zodat CmdPal ook lokaal kan worden gestart.
 - Export PFX-logica verwijderd om hardcoded wachtwoordgebruik te elimineren en PSScriptAnalyzer-beveiligingswaarschuwing op te lossen.
 - PowerShell-script en CI-integratie toegevoegd om consistent gebruik van Common.Dotnet.CsWinRT.props in alle C#-projecten onder de src-map af te dwingen.
   
### Wat wordt gepland voor versie 0.92

Voor [v0.92][github-next-release-work] werken we aan de onderstaande punten:

 - Verdere verfijning van Command Palette
 - Nieuwe UI-automatiseringstests
 - Werken aan installer-upgrades
 - Upgrade van de editor-UI van Keyboard Manager
 - Stabiliteits- / bugfixes

## PowerToys Community

Het PowerToys-team is enorm dankbaar voor de [ondersteuning van een geweldige actieve community][community-link]. Het werk dat jullie doen is ontzettend belangrijk. PowerToys zou niet zijn wat het nu is zonder jullie hulp bij het rapporteren van bugs, bijwerken van documentatie, begeleiden van het ontwerp of schrijven van functies. We willen jullie bedanken en jullie werk erkennen. Maand na maand helpen jullie direct mee om van PowerToys betere software te maken.

## Gedragscode

Dit project hanteert de [Microsoft Open Source Gedragscode][oss-conduct-code].

## Privacyverklaring

De applicatie registreert basis diagnostische gegevens (telemetrie). Voor meer informatie over privacy en wat we verzamelen, zie onze [PowerToys Data- en Privacydocumentatie](https://aka.ms/powertoys-data-and-privacy-documentation).

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