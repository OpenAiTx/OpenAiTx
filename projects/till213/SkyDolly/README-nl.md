
<div align="right">
  <details>
    <summary >🌐 Taal</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=as">অসমীয়া</
      </div>
    </div>
  </details>

</div>

[![Pre-Release](https://img.shields.io/github/v/tag/till213/skydolly?include_prereleases&label=Pre-Release)](https://github.com/till213/skydolly/releases)
![Licentie: MIT](https://img.shields.io/badge/%E2%9A%96%EF%B8%8F%20License-MIT-brightgreen)
![C++20](https://img.shields.io/badge/C%2B%2B-20-%2300599C?logo=cplusplus)
![Ondersteunde Compilers](https://img.shields.io/badge/%E2%9A%99%EF%B8%8F%20Compilers-GCC%2C%20clang%2C%20MSVC-informational)

![Unit Tests](https://github.com/till213/SkyDolly/actions/workflows/unit-tests.yml/badge.svg?event=push)

# Sky Dolly
Sky Dolly - Het zwarte schaap voor jouw vluchtopnamen.

## Over
Sky Dolly maakt verbinding met een actieve Flight Simulator 2020-instantie en registreert diverse simulatievariabelen voor weergave.

![Sky Dolly v0.11.0](https://raw.githubusercontent.com/till213/SkyDolly/main/./img/SkyDolly-v0.11.0.png)

De verbinding wordt gemaakt via SimConnect, een standaard API geïntroduceerd met Flight Simulator X om met de flightsimulator te verbinden.

Zie ook [ABOUT.md](https://raw.githubusercontent.com/till213/SkyDolly/main/ABOUT.md).

## Functies
- Opnemen / Pauzeren / Afspelen
- Formatievluchten (meerdere vliegtuigen, weergave tijdens opname, "vliegen met formatie", tijdsverschil)
- Instelbare opnamesamplefrequentie: vast of variabel ("auto")
- Instelbare afspeelsnelheid ("slow motion", "timelapse"), herhaal afspelen
- Positie, snelheid en basisvluchtbesturingsvariabelen (rolroeren, richtingsroer, flaps, landingsgestel, ...) worden opgenomen
- Pluginarchitectuur met diverse import/export-plugins (CSV, GPX, IGC, KML)
- Locatiemodule met meer dan 100 standaardlocaties en import/exportmogelijkheden
- Database (SQLite) gebaseerde persistentie ("logboek")

Bekijk de (preview) release trailer op [YouTube](https://www.youtube.com/watch?v=_n4qRtm78_I):

[![Sky Dolly - Flight Recorder & Replay for Flight Simulator 2020 (Cinematic Teaser Trailer)](https://img.youtube.com/vi/_n4qRtm78_I/0.jpg)](https://www.youtube.com/watch?v=_n4qRtm78_I "Sky Dolly - Flight Recorder & Replay for Flight Simulator 2020 (Cinematic Teaser Trailer)")

Voor meer video's gemaakt met Sky Dolly zie ook [SHOWCASE](https://raw.githubusercontent.com/till213/SkyDolly/main/SHOWCASE.md). Nieuwe en aankomende functies vind je in de [CHANGELOG](https://raw.githubusercontent.com/till213/SkyDolly/main/CHANGELOG.md).

## Basisgebruik

- Start een vlucht
- Klik op "Opnemen" (toets R)
- Je kunt de opname pauzeren (toets P)
- Stop de opname (toets R) en klik op "Afspelen" (spatiebalk)
- Pas de afspeelsnelheid aan en zoek de afspeelpositie, ook tijdens het afspelen
- Opgenomen vluchten worden automatisch opgeslagen in het "logboek"
- Selecteer een vlucht in het logboek en druk op "Laden" (of dubbelklik op de rij) om de opgeslagen vlucht te laden

### Formatie-opname & -weergave

#### Opnemen

- Schakel over naar de module "Formation" (toets F2)
- Klik op "Opnemen" (toets R)
- Elk opgenomen vliegtuig wordt toegevoegd aan de huidige vlucht
- Terwijl bestaande vliegtuigen worden afgespeeld tijdens de opname met "auto" sample rate kun je nog steeds de sample rate van de opname wijzigen

#### Positie

- Het laatst opgenomen vliegtuig wordt het "gebruikersvliegtuig" (dat door de camera in de vluchtsimulator gevolgd wordt)
- Selecteer een positie ten opzichte van het huidige "gebruikersvliegtuig" voordat je opneemt

#### Afspelen

- Klik gewoon op "Afspelen", "Pauzeren" en navigeer in de tijdlijn, net zoals bij een enkele vliegtuigvlucht
- Wijzig het "gebruikersvliegtuig" (ook tijdens het afspelen) om van cockpit naar cockpit te springen
- Neem de controle over het "gebruikersvliegtuig" door "Neem controle" of "Vlieg met Formation" te selecteren

#### Formaties beheren

- Je kunt afzonderlijke vliegtuigen uit een vlucht ("formatie") verwijderen
- Er moet minimaal één vliegtuig per vlucht zijn, dus het laatste vliegtuig kan niet worden verwijderd
- Voeg een tijdsvertraging toe aan het geselecteerde vliegtuig ("multiplayer formatievlucht synchronisatie")
- Om een nieuwe, enkele vliegtuigvlucht te starten, ga terug naar de module "Logboek" (toets F1) en klik op "Opnemen" (toets R)

Waarom probeer je het niet met een van de begeleide ["Tell Tours"](https://github.com/till213/Tell-Tours)? :)

## Downloaden

Ga naar [Releases](https://github.com/till213/SkyDolly/releases) en download de nieuwste release.

Laatste (pre-)release: **Sky Dolly 0.19.2**

Bereken en vergelijk je checksum met de [gepubliceerde SHA-256 checksums](https://raw.githubusercontent.com/till213/SkyDolly/main/SHASUM256.md) om de integriteit van je gedownloade kopie te verifiëren.

## Bouwen

Raadpleeg de [BUILD](https://raw.githubusercontent.com/till213/SkyDolly/main/BUILD.md) documentatie.

## Gerelateerde projecten

- https://github.com/nguyenquyhy/Flight-Recorder - Een .Net gebaseerde applicatie voor vluchtregistratie en herhaling
- https://github.com/saltysimulations/saltyreplay/ - Een applicatie voor registratie & herhaling met een webgebruikersinterface
- https://github.com/SAHorowitz/MSFS2020-PilotPathRecorder - Registreert de vlucht en genereert Google Earth (KML-formaat) "herhalingen"
- https://github.com/Elephant42/FS_Tool - Een eenvoudige tool die het mogelijk maakt de locatie van het vliegtuig en de simulatietijd in te stellen
- https://github.com/pyviator/msfs-geoshot - Maakt screenshots en "geotagged" deze automatisch
- https://github.com/ijl20/msfs_logger_replay - IGC-logger en herhaling (voor FSX)
- https://joinfs.net/ - Maakt het mogelijk om multiplayer-vluchten te synchroniseren tussen verschillende vluchtsimulators (MSFS, Prepar3D/FSX, XPlane). Biedt ook een vluchtrecorder met formatievluchtopname ("overdub").
- https://github.com/paulalexandrow/a32nx-webremote - WebRemote voor FlyByWire's A32NX: bedien cockpitfunctionaliteiten van de FBW A320, via FSUIPC7
- https://flightloganalyzer.com/ - FlightLog Analyzer analyseert het MSFS logboek en heeft een CSV-export die leesbaar is door Sky Dolly
- https://github.com/BojoteX/FSAutoSave/ - FSAutoSave slaat automatisch (of op verzoek) vluchtplannen op
- https://github.com/mracko/MSFS-Landing-Inspector - Analyseert je landing prestaties
- [Points of Interest (Google Maps)](https://www.google.com/maps/d/viewer?mid=1KUg5jwyT_9k2A9n5IZ99UChlhfVUfO5S&ll=-3.81666561775622e-14%2C-23.028915134521867&z=1) - Punten van belang, luchthavens en 3D-steden in Microsoft Flight Simulator.

## Andere nuttige bronnen

- https://obsproject.com/ - Applicatie voor schermopname / uitzending
- https://sqlitebrowser.org/ - Blader door de Sky Dolly logboek (*.sdlog) databasebestanden, voer je eigen SQL-query's uit


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-15

---