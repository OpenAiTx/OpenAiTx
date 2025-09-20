
<div align="right">
  <details>
    <summary >🌐 Taal</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=en">Engels</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=fr">Frans</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=de">Duits</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=es">Spaans</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=it">Italiaans</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=pt">Portugees</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=pl">Pools</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=tr">Turks</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=vi">Vietnamees</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=id">Indonesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Xbox_SMC
PIC16/Xyclops dumps van de originele Xbox en IDA-databases met enige reverse engineering.

![Afbeelding van PIC16LC63A uit een originele Xbox](https://raw.githubusercontent.com/Prehistoricman/Xbox_SMC/master/pic16lc63a.jpg)

# Xyclops flashen (XycloMod)
Zie [de Xyclops map en README](/Xyclops)

# Dumps
Het .bin-bestand voor elke PIC-dump heeft de bytes omgewisseld voor correcte laading in IDA. Dus het eerste woord van het PIC-geheugen is byte_0 + byte_1 << 8.

De .idb IDA-databases bevatten informatie over variabelen en enkele observaties op het database-notitieblok.

Zie deze wiki-pagina voor een overzicht van de SMC-versies: https://xboxdevwiki.net/Xboxen_Info

## B2A
Gedumpt van een DVT3 Xbox. Zelfde configuratiewoord als P01. Het heeft ook het apparaat-ID ingebrand in het configuratiegebied als 0000 0000 000B 002A, in tegenstelling tot de productie-PICs.

De boot-uitdaging ontbreekt volledig.

## D01
Gedumpt van XDK BETA 2 Xbox. Identiek aan P01 behalve dat de boot-uitdaging ontbreekt. De functie om de verwachte boot-uitdagingsrespons te berekenen is er nog, maar wordt nooit aangeroepen.

## DXF
Gedumpt van een XDK D2 debug kit. Zeer vergelijkbaar met D01 maar met iets andere lade-logica, oververhittingslogica en bootlogica. Boot-uitdaging ontbreekt op dezelfde manier als bij D01.

## D2E
Gedumpt van een Tuscany (v1.6) dev kit. Xyclops-chip is gemarkeerd als X01202-001, en mist de A-A02 of A-B01 lijn die retail-units hebben.

De debug-seriecode bij FC00 komt overeen met de retail P2L-dump. Er is een vreemd patroon van data van 0x4000 tot 0xFBFF.

## P01
Gedumpt van een v1.0 Xbox. Het configuratiewoord is 0x86:
- CP1:CP0 = 0 (Codebescherming ingeschakeld voor het hele geheugen)
- BODEN = 0 (Brown-out Reset uitgeschakeld)
- ~PWRTE = 0 (Power-up Timer ingeschakeld)
- WDTE = 1 (Watchdog Timer ingeschakeld)
- FOSC1:FOSC0 = 2 (HS-oscillator)

Een configuratiewaarde van 0x3FB6 is geschikt voor SMC-klonen zodat ze geen codebescherming hebben ingeschakeld.

## P11
Gedumpt van een v1.3 Xbox. Zelfde configuratiewoord als P01.

Er zijn een paar kleine wijzigingen in P11 ten opzichte van P01, waaronder een extra SMBus-commando (schrijf 0x22), andere LED-prioriteiten en meer ontspannen timings voor het opstarten.

Ik heb gescrambelde dumps van v1.3 vergeleken met v1.4 en ze kwamen overeen. Dit betekent dat het zeer waarschijnlijk is dat ze hetzelfde programma hebben.

## P2L
Gedumpt van een v1.6 Xbox. Xyclops revisie A-A02. Het bevat Intel 8051-code maar heeft veel speciale functieregisters waarvan de functie onbekend is.

De debug-serie wordt aangestuurd door de code op FC00. Het lijkt op een eenvoudige debugger die uitvoering kan pauzeren, data kan dumpen en naar registers/RAM kan schrijven.

# Xyclops dumpen

De Xyclops-chip heeft 3 pinnen voor 'debug': TXD (pin 64), RXD (pin 63), en DEBUG (pin 29). Zet de DEBUG-pin hoog om de seriële poort op de TX- en RX-pinnen te activeren. De seriële verbinding werkt op 9600 baud.

Het protocol is gebaseerd op 4-byte commando's die meestal het formaat hebben `<cmd>` `<adres MSByte>` `<adres LSByte>` `<onbelangrijk>`

Commando 0x14 dumpt telkens 64 bytes BIOS-data en 0x15 dumpt telkens 64 bytes SMC-programmadata. Een dump van Xyclops, P2L.bin, is opgenomen in de repo. [xyclops_dumper.py](/Xyclops/xyclops_dumper.py) is ook meegeleverd zodat je je eigen apparaat kunt dumpen.

# PIC dumpmethodologie
Volledig verslag op https://wiki.recessim.com/view/PIC_Burnout

De PIC heeft zijn codebeveiliging ingeschakeld, waardoor alle data als 0000 wordt gelezen. Ik gebruikte een truc om in plaats daarvan gescrambelde data te krijgen, ontdekte het scramble-algoritme met een opgeofferde chip, en gebruikte daarna een soort exploit om de ROM-data te wijzigen zodat sommige bits op bekende waarden werden gezet. Vervolgens kan ik de benodigde informatie uit de verschillende gescrambelde dumps halen om de originele data te herstellen.

# PICProgrammer
PICProgrammer is een van een paar Arduino-projecten voor de RP2040 die ik in mijn onderzoek heb gebruikt. Het biedt een eenvoudige commandoregelinterface om ICSP (in-circuit seriële programmering) bewerkingen op de PIC uit te voeren. Dit wordt verkozen boven het gebruik van een speciaal gebouwde programmer zoals de PICkit vanwege de flexibiliteit en de mogelijkheid om dingen te doen die de fabrikant niet heeft voorzien.

Je moet een goed begrip hebben van elektronica en programmeren voordat je dit gebruikt, en goed kijken naar wat commando's doen voordat je ze uitvoert.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-20

---