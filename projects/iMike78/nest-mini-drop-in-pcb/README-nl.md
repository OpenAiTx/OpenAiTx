
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

**Let op!** Een aankomende crowdfundingcampagne voor de "MiciMike Home Mini Drop-In PCB" (1e generatie Google Home Mini) staat nu vermeld in de pre-launchfase op Crowd Supply (project alleen als voorvertoning), en als die succesvol is, wordt er een bijbehorende campagne voor de Nest Mini gepland, dus bekijk het hier:

* https://www.crowdsupply.com/micimike-rev-devices/micimike-home-mini-drop-in-pcb

Beide zijn volledig open-source hardwareprojecten, die enige conceptinspiratie halen uit de [Onju Voice](https://github.com/justLV/onju-voice), maar met als doel de [Open Home Foundation’s open voice assistants standard met Home Assistant Voice Preview Edition als referentie](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) te volgen voor PCB-ontwerpen en specificaties.

# Projectscope

Het doel van dit project en deze repository (die vergelijkbaar is met de [Onju Voice](https://github.com/justLV/onju-voice) maar onder een volledig open-source hardwarelicentie) is het ontwerpen van een drop-in vervangende PCB (Printed Circuit Board) met hardwareschema's die iedereen kan maken/bouwen of bestellen bij een alles-in-één PCB-fabrikant als een op maat gemaakte drop-in vervangende PCB voor de Google Nest Mini (2e Gen).

Dit is primair gericht op mensen die hun oude Google Nest Mini smart speakers willen ombouwen/hergebruiken tot open-source hardware voor [Voice Control van Home Assistant](https://www.home-assistant.io/voice_control/) en/of mediaplayerspeaker-uitvoer voor [Music Assistant](https://www.music-assistant.io), (de hardware kan echter waarschijnlijk ook met andere toepassingen gebruikt worden met andere firmware omdat het gebaseerd is op het populaire Espressif ESP32-platform).

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_2.png" width="1000">

Het hardwareontwerp zal (vergelijkbaar met de [Home Assistant Voice Preview Edition](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)) een ESP32-S3 SoC integreren voor WiFi, BLE, en [onboard wake-word detectie](https://www.home-assistant.io/voice_control/about_wake_word/) (met gebruik van no-code [ESPHome firmware](https://esphome.io/)) + een XMOS xCORE XU316-chip voor geavanceerde audiobewerking (met aangepaste firmware voor microfoonopruiming voor betere spraakherkenning door lokaal draaiende algoritmes voor ruisonderdrukking, akoestische echo-onderdrukking, interferentieonderdrukking en automatische gain control).

Qua functionaliteit is het grotendeels hardwarematig compatibel gemaakt met het [Home Assistant Voice Preview Edition (ook wel Home Assistant Voice PE](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) referentieontwerp (dat als open-source hardwareontwerp is uitgebracht door de Open Home Foundation in samenwerking met Nabu Casa). Het grootste verschil zal komen door beperkingen die worden opgelegd door de Google Nest Mini-behuizing en componenten, (d.w.z. het nest-mini-drop-in-pcb-projectontwerp zal worden beperkt door dezelfde soort fysieke capaciteitsinputs als de originele hardware van Google).

Als zodanig is de scope van dit project/deze repository niet om nieuwe functies voor de ESPHome-firmware te ontwikkelen; als je dat wilt, moet je je richten op de firmwareontwikkeling van de Home Assistant Voice Preview Edition en op de upstream ESPHome-hoofdcode:

- https://github.com/esphome/home-assistant-voice-pe
  - https://github.com/esphome/esphome
      - https://github.com/esphome/feature-requests

## Oproep tot samenwerking

Als je enige ervaring hebt met PCB-layoutontwerp (en vooral met PCB-routing, ground pouring of ruisgevoelige digitale+analoge layouts), **is je hulp zeer gewaardeerd**! Voel je vrij om een nieuw issue te openen, suggesties/verzoeken in te dienen, input/feedback toe te voegen aan bestaande issues, of deze repository te forken.

Voor meer informatie over het concept/idee zie en draag bij aan de gerelateerde discussie, zie ook deze Home Assistant community forumthread:

- https://community.home-assistant.io/t/any-news-on-alternative-to-onju-voice-pcb-repacement-design-for-google-nest-home-mini-speakers-with-added-xmos-chip-to-match-official-home-assistant-voice-preview-edition-reference-hardware/860001/

### Huidige status

- ✅ Schema voltooid
- ✅ Componentplaatsing voltooid
- ✅ Routing voltooid
- ✅ Ground pour, afschermstrategie en EMI-overwegingen voltooid
- ⚠️ Eerste testbatch gefaald op twee fouten - opgelost
- 🕓 wachten op de 2e testbatch

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/3D.png" width="1000">

## Gebruikte gereedschappen

- 🛠️ KiCad 9
- 🧰 SnapEDA / LCSC voor footprint sourcing

## Bekende hardwarespecificaties

- 4-laags PCB
- ESP32-S3R8 bare chip (ESP32-S3 voor WiFi, BLE en onboard wake-word detectie)
- XMOS XU316-1024-QF60B-C24 (XMOS XU316 xCORE DSP audioprocessing)
- Dual SPI-flash (aangezien ESP32 en XMOS hun eigen SPI-flash hebben)
- Dual I²S-bussen (om gelijktijdig I2S-interfaces mogelijk te maken, d.w.z. gelijktijdige audio-uitgang en audio-ingang)
- TAS5805M (TAS5805MPWPR) voor luidsprekeruitgang (I2S Klasse-D Mono Audio Versterker met DSP-configuratie via I2C)
- 2x MEMS-microfoons (dual MMICT390200012 met 68mm afstand tussen de microfoons)
- 6x SK6812 RGB-LED's
- Custom USB-C en 14V stroomingang (Let op! USB-C en barrel-connector kunnen niet gelijktijdig aangesloten zijn)

---

> ⚠️ Flashen via USB-C vereist het loskoppelen van de hoofd 14V stroomingang. Zie de silkscreen-opmerking op de PCB voor details.

## Referenties

### Home Assistant Voice Preview Edition bronnen inclusief PCB-ontwerpbestanden
- https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/
  - https://voice-pe.home-assistant.io/resources/
    - https://support.nabucasa.com/hc/nl/articles/26195279589277-Home-Assistant-Voice-Preview-Edition-PCB-design-files
      - https://raw.githubusercontent.com/NabuCasa/support/refs/heads/main/static/docs/voice/home_assistant_voice_pe_schematic_v1.0_241009.pdf
     
#### ESPHome firmware voor Home Assistant Voice PE (die ook dezelfde ESP32-S3 + XMOS XU316 combinatie gebruikt):

- https://github.com/esphome/home-assistant-voice-pe
  - https://esphome.github.io/home-assistant-voice-pe/
- https://voice-pe.home-assistant.io/

### XMOS xCORE DSP (XU316-1024-QF60B-C32) MCU IC-chip

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

☕ Wil je dit project steunen, voel je vrij om [me een koffie te kopen op Ko-fi](https://ko-fi.com/imike78)!




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-22

---