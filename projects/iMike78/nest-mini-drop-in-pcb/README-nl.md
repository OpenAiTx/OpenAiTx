
<div align="right">
  <details>
    <summary >🌐 Taal</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=en">Engels</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=fr">Frans</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=de">Duits</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=es">Spaans</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=it">Italiaans</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=pt">Portugees</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=pl">Pools</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=tr">Turks</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=vi">Vietnamees</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=id">Indonesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=as">অসমীয়া</
      </div>
    </div>
  </details>

</div>

# MiciMike drop-in PCB vervanging voor Google Nest Mini

[MiciMike Nest Mini](https://github.com/iMike78/nest-mini-drop-in-pcb) is een drop-in PCB vervanging voor de ["Google Nest Mini" (Google's tweede generatie slimme speaker met een laadpoort met ronde stekker)](https://nl.wikipedia.org/wiki/Google_Nest_(smart_speakers)), maar gebaseerd op ESP32 en XMOS microcontrollers voor het draaien van open-source firmware.

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_1.png" width="1000">

Tip! Als je in plaats daarvan op zoek bent naar een vergelijkbare drop-in PCB vervanging voor de "Google Home Mini" (Google's eerste generatie slimme speaker hardware met een Micro-USB laadpoort), kijk dan naar het zusterproject op https://github.com/iMike78/home-mini-v1-drop-in-pcb

**Let op!** Er loopt momenteel een crowdfundingcampagne voor de "MiciMike Home Mini Drop-In PCB" (1e generatie Google Home Mini) die nu live is op Crowd Supply in een pre-sale fase (alleen project preview), en als dat succesvol is, wordt er een bijpassende campagne gepland voor de nieuwere Nest Mini (2e generatie), dus bekijk het hier en steun dit project indirect door het te backen als je kunt:

* https://www.crowdsupply.com/micimike-rev-devices/micimike-home-mini-drop-in-pcb

Beide zijn volledig open-source hardwareprojecten, geïnspireerd door het [Onju Voice](https://github.com/justLV/onju-voice) concept, maar met als doel te voldoen aan de [Open Home Foundation’s open voice assistants standaard met Home Assistant Voice Preview Edition als referentie](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) voor PCB-ontwerpen en specificaties.

# Projectomvang

Het doel van dit project en deze repository (vergelijkbaar met [Onju Voice](https://github.com/justLV/onju-voice) maar onder een volledig open-source hardwarelicentie) is het ontwerpen van een drop-in vervangende PCB (Printed Circuit Board) met hardware-schema’s die iedereen kan maken/bouwen of bestellen bij een PCB-fabrikant als een custom drop-in vervangende PCB voor de Google Nest Mini (2e generatie).

Dit is primair gericht op mensen die hun oude Google Nest Mini smart speakers willen ombouwen/hergebruiken tot open-source hardware voor [Voice Control van Home Assistant](https://www.home-assistant.io/voice_control/) en/of mediaplayerspeaker-output voor [Music Assistant](https://www.music-assistant.io), (de hardware kan waarschijnlijk ook met andere toepassingen gebruikt worden met andere firmware, omdat het gebaseerd is op het populaire Espressif ESP32-platform).

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/front_render.jpg" width="1000" alt="Eerste test PCB">

Het hardwareontwerp zal (net als [Home Assistant Voice Preview Edition](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)) een ESP32-S3 SoC integreren voor WiFi, BLE en [onboard wake-word detectie](https://www.home-assistant.io/voice_control/about_wake_word/) (met no-code [ESPHome firmware](https://esphome.io/)) + een XMOS xCORE XU316-chip voor geavanceerde audiobewerking (met custom firmware voor microfoon-cleanup offloading voor betere spraakherkenning via lokaal draaiende algoritmen voor ruisonderdrukking, akoestische echo-cancelling, interferentie-cancelling en automatische gain-control).

Qua functionaliteit is het grotendeels hardwarecompatibel gemaakt met het [Home Assistant Voice Preview Edition (ook wel Home Assistant Voice PE genoemd](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) referentieontwerp (dat als open-source hardwareontwerp is vrijgegeven door Open Home Foundation in samenwerking met Nabu Casa). Het grootste verschil komt door beperkingen van de Google Nest Mini-behuizing en componenten, (dus het nest-mini-drop-in-pcb project hardwareontwerp wordt beperkt door hetzelfde type fysieke capaciteit inputs als de originele hardware van Google).

De scope van dit project/deze repository is dus niet het ontwikkelen van nieuwe features/functies voor de ESPHome firmware, dus als je dat wilt, moet je je richten op de firmwareontwikkeling van de Home Assistant Voice Preview Edition en de upstream ESPHome mainline code:

- https://github.com/esphome/home-assistant-voice-pe
  - https://github.com/esphome/esphome
      - https://github.com/esphome/feature-requests

## Verzoek om samenwerking

Als je ervaring hebt met PCB-layout ontwerp, (en vooral met PCB-routing, ground pouring of ruisgevoelige digitaal+analoog layouts), **is jouw hulp zeer welkom**! Voel je vrij om een issue te openen, suggesties/requests in te dienen, en input/feedback toe te voegen aan bestaande issues, of deze repository te forken.

Voor meer informatie over het concept/idee en om bij te dragen aan gerelateerde discussies, zie ook deze Home Assistant community forum thread:

- https://community.home-assistant.io/t/any-news-on-alternative-to-onju-voice-pcb-repacement-design-for-google-nest-home-mini-speakers-with-added-xmos-chip-to-match-official-home-assistant-voice-preview-edition-reference-hardware/860001/

### Huidige status

- ✅ Schema afgerond
- ✅ Componentplaatsing gedaan
- ✅ Routing is gedaan
- ✅ Ground pour, afschermstrategie en EMI-overwegingen gedaan
- ⛔ 1e testbatch mislukt op twee fouten - opgelost
- ⚠️ 2e testbatch werkt gedeeltelijk
- ✅ XTAG4 debugoptie toegevoegd voor de volgende batch

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/back_render.jpg" width="1000">

## Gebruikte gereedschappen

- 🛠️ KiCad 9
- 🧰 SnapEDA / LCSC voor footprint sourcing

## Bekende hardwarespecificaties

- 4-laags PCB
- ESP32-S3R8 bare chip (ESP32-S3 voor WiFi, BLE, en ingebouwde wake-word detectie)
- XMOS XU316-1024-QF60B-C24 (XMOS XU316 xCORE DSP audioprocessing)
- 16 MB SPI-flash (ESP32-S3)
- 4 MB SPI-flash (XMOS XU316)
- Dubbele I²S-bussen (gelijktijdige audio-invoer en -uitvoer)
- TAS5805M (TAS5805MPWPR) stereo Class-D versterker met geïntegreerde DSP (I2S audio, I2C besturing), geconfigureerd voor mono BTL luidsprekeruitgang
- 3x MEMS-microfoons (MMICT390200012) geplaatst op een boog van 34 mm straal - huidige firmware gebruikt 2 microfoons, hardware-ondersteuning voor een array van 3 microfoons is reeds aanwezig
- 6x SK6812 RGB LED's
- Aangepaste USB-C en 14V voedingsingang (Let op! USB-C en barrel-connector kunnen niet gelijktijdig aangesloten zijn)
- MPR121 capacitieve touch controller (gebruikt voor touch input in plaats van ESP32-S3 native touch sensing)

---

> ⚠️ Flashen via USB-C vereist het loskoppelen van de hoofd 14V-voedingsingang. Zie silkscreen-opmerking op de PCB voor details.

## Referenties

### Home Assistant Voice Preview Edition bronnen inclusief PCB-ontwerpbestanden
- https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/
  - https://voice-pe.home-assistant.io/resources/
    - https://support.nabucasa.com/hc/en-us/articles/26195279589277-Home-Assistant-Voice-Preview-Edition-PCB-design-files
      - https://raw.githubusercontent.com/NabuCasa/support/refs/heads/main/static/docs/voice/home_assistant_voice_pe_schematic_v1.0_241009.pdf
     
#### ESPHome firmware voor Home Assistant Voice PE (die ook dezelfde ESP32-S3 + XMOS XU316 combinatie gebruikt):

- https://github.com/esphome/home-assistant-voice-pe
  - https://esphome.github.io/home-assistant-voice-pe/
- https://voice-pe.home-assistant.io/

### XMOS xCORE DSP (XU316-1024-QF60B-C24) MCU IC chip

- https://www.xmos.com/download/XU316-1024-QF60B-xcore.ai-Datasheet(3).pdf
- https://www.xmos.com/software-tools/
  - https://www.xmos.com/develop/xcore-voice
  - https://www.xmos.com/usb-multichannel-audio/
  - https://www.xmos.com/xcore-ai

#### XMOS firmware van het ESPHome-project voor de Home Assistant Voice Preview Edition hardware:

- https://github.com/esphome/voice-kit-xmos-firmware
  - https://github.com/esphome/xmos_fwk_rtos
  - https://github.com/esphome/xmos_fwk_io

## Licentie

Dit project is gelicentieerd onder de [CERN Open Hardware License Version 2 - Strongly Reciprocal (CERN-OHL-S v2)]
Elke aangepaste versie van deze hardware moet ook onder dezelfde licentie worden verspreid.

☕ Als je dit project wilt steunen, voel je vrij om [me een koffie te kopen op Ko-fi](https://ko-fi.com/imike78)!




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-24

---