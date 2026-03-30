
<div align="right">
  <details>
    <summary >🌐 Taal</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=en">Engels</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=ja">Japans</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=ko">Koreaans</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=hi">Hindi</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=th">Thais</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=fr">Frans</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=de">Duits</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=es">Spaans</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=it">Italiaans</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=pt">Portugees</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=pl">Pools</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=ar">Arabisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=fa">Perzisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=tr">Turks</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=vi">Vietnamees</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

﻿# Elucidate

- [Projectbeschrijving](#project-description)
- [Systeemeisen:](#os-requirements)
- [Veelgestelde vragen](#faqs)
- [Routekaart](#roadmap)
- [Schermafbeeldingen](#screenshots)

## Projectbeschrijving

Elucidate is een Windows GUI-front-end voor de command-line SnapRAID applicatie.

*Dit project zet het samenvoegen voort van het geweldige werk dat door mijzelf en andere bijdragers is gedaan.

## Systeemeisen

- Windows besturingssysteem
- .Net Runtime 4.8.0
- SnapRAID Versie 11.5 of lager
- 10MB vrije ruimte op doelschijf

## Veelgestelde Vragen

**V**: Wat is SnapRAID?<br/>
**A**: SnapRAID is een softwarematige snapshot-parity engine voor Windows en Linux besturingssystemen. Op het meest basale niveau biedt het bescherming aan de inhoud van een bestandssysteem onder zijn beheer door het berekenen van hashes van de componentbestanden en het opslaan van de resultaten in een pariteitsbestand. In het geval van een volledige harde schijfstoring kan dit pariteitsbestand worden gebruikt om de verloren gegevens te reconstrueren. Voor volledige details, bezoek SnapRAID's [officiële vergelijking van bestandsbeschermingsengines.](http://snapraid.sourceforge.net/compare.html)

**V**: Waarom een GUI, de Command Line werkt toch!<br/>
**A**: Het grotere doel is om een volledige GUI te creëren met extra beheermogelijkheden die bedoeld zijn om een gebruiker te helpen bij het onderhouden van een werkende SnapRAID-omgeving. Soms is ‘point and click’ makkelijker voor een beginner om mee aan de slag te gaan. SnapRAID's technische documentatie en diepe configureerbaarheid kunnen het onaantrekkelijk maken voor mensen die het willen proberen!

**V**: Ik twijfel nog, is er meer?<br/>
**A**: Ja, kijk eens naar de [documentatie](https://raw.githubusercontent.com/Smurf-IV/Elucidate/master/./docs/Documentation.md) voor plaatjes etc.

**V**: Wat zijn dan de "Grotere Doelen"?<br/>
**A**: Zie de __Roadmap__ hieronder voor een volledig overzicht.

## Roadmap

- [x] Fase I
  - [x] Proberen minimaal de laatste SnapRAID te ondersteunen. - __Doorlopend.__
  - [x] Gebruiksgemak
  - [x] SnapRAID heeft drie commando’s, dus laten we ze eenvoudig toegankelijk maken voor een beginner 
  - [x] Voortgangsindicator(en) 
  - [x] Logging "Interactief" en direct naar log. 
  - [x] Automatisch starten bij gebruikerslogin 
  - [x] Tool-tips om te begeleiden •

- [x] Fase II Fase II Functieaanvragen
  - [x] Pauzeren, Prioriteit wijzigen, Afbreken.
  - [x] Opdrachtuitbreiding - "Sta extra parameters toe aan de standaardwaarden die worden gebruikt."
  - [x] Planning
    - Verwijderd, gebruik de CommandLine
  - [x] Grafische weergave(n) van de beschermde data.

- [ ] Fase III (Herstart vanaf 2017-03)
  - [x] Nieuwe Compiler en .Net 4.7.x	
  - [x] Opdrachtregelinterface
  - [ ] Nieuwe lay-out via Krypton Toolkit / Navigator / etc.
    - Bezig
  - [ ] Vertalingen
  - [x] Nieuwe opdrachten
  - [ ] Mailer met statusrapporten
  - [ ] Documenteer teststappen
    - Bezig
  - [ ] Toevoegen aan documentatie / Afbeeldingen bijwerken
    - Bezig
  - [ ] Voeg _Windows EventLog_ rapportage van fouten toe
  - [x] Voeg _ExceptionLess_ toe voor online rapportage van uitzonderingen
  - [x] Toon wat hersteld kan worden.

- [ ] Fase IV (nieuwe SnapRAID-opdrachten?)
  - [ ] Uitgebreide hulp met schijfherstel - interactieve gidsen etc.
  - [ ] Waarschuw de gebruiker als hun SnapRAID-versie verouderd is
  - [ ] Interpreteer de SnapRAID-logboeken (gebruikt door de wijzigingen hieronder)
  - [ ] Geef de status van de array na het uitvoeren van een opdracht
  - [ ] Pas het sync-commando aan om een initiële diff op te nemen
  - [ ] Pas het sync-commando aan om een waarschuwing te geven als de diff problemen boven een drempelwaarde meldt
  - [ ] Voeg door de gebruiker configureerbare instellingen toe voor synchronisatiedrempelvereisten


## Schermafbeeldingen

![Startweergave](https://raw.githubusercontent.com/Smurf-IV/Elucidate/master/./Images/starting_view.png)

![Instellingenformulier](https://raw.githubusercontent.com/Smurf-IV/Elucidate/master/./Images/Settings_Form.PNG)


## Kun je Helpen?
- Op zoek naar testers (Alle .Net-platformen)
- Kan helpen vertalen 
- Hulp / gebruikersinterface gidsen 
- Andere ideeën :-) 
- Ontwikkelaars voor de ideeën 


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-30

---