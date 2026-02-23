
<div align="right">
  <details>
    <summary >🌐 Taal</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Chocolatey-for-wine

Chocolatey pakketbeheerder automatische installatie in wine, handig om snel programma’s te installeren in wine (en vervolgens bugs te vinden in wine ;) )  
Voor sommige bugs zijn er workarounds toegevoegd, zoals voor Visual Studio Community 2022 en nodejs, zie verderop.  

Omdat ik me verveelde tijdens de lockdown heb ik een aangepaste winetricks(.ps1) geschreven met werkwoorden die ik handig vind. Voer gewoon 'winetricks' uit om ze te zien.
Voor sommige werkwoorden is een volledige herstart van wine nodig (vanwege recente wijzigingen in wine). Je ziet dan een berichtvenster en de sessie wordt beëindigd. Start gewoon powershell opnieuw en probeer het werkwoord opnieuw. Als dit eenmaal is gedaan, is het voor geen enkel werkwoord meer nodig.  

Voorbeeld:  

'winetricks vs22_interactiveinstaller'  ( --> sessie zal worden beëindigd)  

doe 'wine powershell'  

doe 'winetricks vs22_interactiveinstaller'  


(Trouwens, via 'winetricks vs22_interactive_installer' kun je selecteren wat je wilt installeren via de Visual Studio 2022 installer; 'winetricks vs22_interactive_installer' bracht me nu binnen tien minuten naar het hoofdprogramma (gekozen voor Desktopontwikkeling met C++)).

Installatie :
- Download en pak het release zip-bestand uit en doe 'wine ChoCinstaller_0.5c.751.exe' (duurt ongeveer een minuut om te voltooien)

Optioneel:
- Voer de installer uit zoals 'wine ChoCinstaller_0.5a.751.exe /s' , dan worden de installatiebestanden (zoals Powershell*.msi en dotnet48) opgeslagen in 
  MijnDocumenten en hoeven ze niet opnieuw te worden gedownload als je een nieuwe prefix aanmaakt)
Optioneel:
- Voer de installer uit zoals 'wine ChoCinstaller_0.5a.751.exe /q' om het automatisch openen van het powershell-venster te voorkomen (dus alleen installeren). 

Optioneel:
- Controleer of alles goed is gegaan: "choco install chromium" en  "start chrome.exe (--no-sandbox is niet meer nodig vanaf wine-8,4)" 

![Screenshot van 2022-08-26 12-31-18](https://user-images.githubusercontent.com/26839562/186885380-d5a617c4-9cf4-4831-a475-2bd85a3b5784.png)
Over PowerShell:

Tip: Chocolatey installeert meestal de nieuwste versie van een programma, wat nieuwe wine bugs kan blootleggen. Je kunt meer geluk hebben met een oudere versie van de software.  
Voorbeeld:  

choco search --exact microsoft-edge --all (--> lijst van alle versies)  

choco install microsoft-edge --version --version='135.0.3179.98'

Algemene info:

- 'wine powershell.exe' start de PowerShell-Core console.

 
Over ConEmu:

ConEmu-console heeft last van enkele wine-bugs:
  - Ctrl^C om een programma af te sluiten dat niet terugkeert naar de console werkt niet. Gebruik Shift^Ctrl^C in plaats daarvan.
  - Tekst selecteren in het ConEmu-venster (voor kopiëren/plakken) markeert de selectie niet. Er is een zeer trieste hack inbegrepen tegen recente wine-versies die dit omzeilt, dus markering zou nu gewoon moeten werken.
   
Over winetricks(.ps1):

- Als je het niet oproept ('winetricks' in powershell-console), wordt er niets gedownload en is er dus geen overhead.
- Veel werkwoorden (zoals powershell 5.1) hebben enkele essentiële bestanden nodig om dingen uit msu-pakketten te extraheren. Het installeren van deze essentiële bestanden vereist eerst enorme downloads en kost veel tijd bij het eerste gebruik. Maar zodra dingen zijn gecachet, gaat het snel. Bijvoorbeeld, als je 'winetricks ps51' wilt proberen, duurt dat ongeveer 15 minuten. Sommige andere werkwoorden kunnen bij eerste gebruik 5 minuten duren. Maar nadat je een werkwoord eenmaal hebt gebruikt, is deze hinder verdwenen.
- Bestanden worden gecachet in de map Mijn Documenten. Als je alle werkwoorden oproept, neemt dat ongeveer 800 MB in beslag.
- Hopelijk betere 64-bit ondersteuning voor diverse werkwoorden.
- Mogelijkheid om een bestand te extraheren en (proberen) te installeren vanuit een msu-bestand. Doe 'winetricks install_dll_from_msu' om te zien hoe.
- Een rudimentaire Powershell 5.1.
- Experimentele dotnet481-installatie, en dotnet35 (mogelijk nodig voor apps die niet tevreden zijn met de huidige dotnet48-installatie).
- Autotab-completion. Let op: bij gebruik van meerdere werkwoorden vanaf de commandoregel moeten ze nu gescheiden worden door een komma
  vanaf nu (dit is hoe powershell meerdere argumenten afhandelt)
  Dus 'winetricks riched20 gdiplus' werkt niet meer, gebruik 'winetricks riched20,gdiplus' in plaats daarvan
- Sommige programma's kunnen niet worden geïnstalleerd/uitgevoerd via Chocolatey vanwege wine-bugs. Ik heb enkele workarounds toegevoegd in winetricks voor hen, zie hieronder.
- Speciale werkwoorden (winetricks vs19, vs22 en vs22_interactive_installer) om werkende Visual Studio Community 2019 en 2022 te installeren (zie screenshot, >10 min. om te installeren en vereist ca. 10GB!, na installatie start devenv.exe vanuit map c:\Program Files (x86)\Microsoft Visual Studio\2019\Community\Common7\IDE/)
  ![screenshot](https://github.com/PietJankbal/Chocolatey-for-wine/assets/26839562/d576a619-c752-4eb1-81c2-6f6b66b50ff6)
- Speciaal werkwoord om toegang te krijgen tot diverse unix-commando's zoals grep, sed, file, less, curl enz. enz. (winetricks git.portable, Disclaimer: sommige commando's werken nog niet vanwege wine-bugs
- Ook zijn enkele powershell-scripts inbegrepen, aangepast van codefragmenten gevonden op internet:
    - Hoe een exe te embedden in een powershell-script via Invoke-ReflectivePEInjection (de exe verschijnt niet in tasklist).
    - Hoe mooie messageboxes te maken
    - Een powershell-script (ps1) omzetten naar een exe.
    - En enkele andere
 
     
Over systeemprogramma's:

Feature is toegevoegd om eenvoudige systeemprogramma's zoals bijvoorbeeld setx.exe te vervangen door een functie in
c:\\Program Files\Powershell\7\profile.ps1. Of systeemprogramma's toevoegen die ontbreken zoals getmac.exe.
Als programma's falen door onvoldoende volwassen of ontbrekende systeemprogramma's zou men een
functie kunnen schrijven die teruggeeft wat het programma verwacht.
Zoals in profile.ps1 heb ik (onder andere) een wmic.exe toegevoegd die iets meer opties ondersteunt,
en een basis setx.exe.
Of je kunt gewoon de argumenten manipuleren die aan het systeemprogramma worden doorgegeven. Zie profile.ps1 en choc_install.ps1.
Geen garantie dat dit ook werkt voor complexere programma's... 
 
Notities:

  - Gebruik NIET op een bestaande wineprefix, alleen op een vers nieuw aangemaakte prefix! De installer installeert domweg dotnet48 zelf en rommelt met registersleutels.
    Als je al een dotnet-versie hebt geïnstalleerd met de reguliere winetricks.sh, zal het waarschijnlijk mislukken, en zelfs als het lukt, eindig je waarschijnlijk met een kapotte prefix.
    Als je programma’s moet installeren met de reguliere winetricks.sh, gebruik dan GEEN van de dotnet* werkwoorden.
    Trouwens, de 'Arial' en 'd3dcompiler_47' werkwoorden zijn standaard al geïnstalleerd.
  - WINEARCH=win32 wordt _niet_ ondersteund!
  - Updaten vanaf een vorige versie wordt voorlopig niet (nog) ondersteund, misschien later

Compileer:
  - Als je zelf wilt compileren in plaats van binaries te downloaden: zie compilatie-instructies in mainv1.c en installer.c
  - Kopieer daarna choc_install.ps1 naar dezelfde map
  - Voer vervolgens 'wine ChoCinstaller_0.5a.735.exe' uit
  


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-23

---