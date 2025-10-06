
<div align="right">
  <details>
    <summary >🌐 Taal</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# MiciMike drop-in PCB vervanging voor Google Nest Mini

[MiciMike Nest Mini](https://github.com/iMike78/nest-mini-drop-in-pcb) is een drop-in PCB vervanging voor de ["Google Nest Mini" (Google's tweede generatie slimme speaker met een laadpoort met ronde connector)](https://en.wikipedia.org/wiki/Google_Nest_(smart_speakers)), maar gebaseerd op ESP32 en XMOS microcontrollers voor het draaien van open-source firmware.

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_1.png" width="1000">

Tip! Als je juist op zoek bent naar een vergelijkbare drop-in PCB vervanging voor de "Google Home Mini" (Google's eerste generatie slimme speaker hardware met een Micro-USB laadpoort), kijk dan naar het zusterproject op https://github.com/iMike78/home-mini-v1-drop-in-pcb

Beide zijn volledig open-source hardwareprojecten, met enige conceptinspiratie van de [Onju Voice](https://github.com/justLV/onju-voice), maar met als doel het volgen van de [Open Home Foundation's open voice assistants standaard met Home Assistant Voice Preview Edition als referentie](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) voor PCB-ontwerpen en specificaties.

# Projectomvang

Het doel van dit project en deze repository (die vergelijkbaar is met de [Onju Voice](https://github.com/justLV/onju-voice) maar onder een volledig open-source hardwarelicentie) is het ontwerpen van een drop-in vervangende PCB (Printed Circuit Board) met hardware schema’s die iedereen kan maken/bouwen of bestellen bij een all-in-one PCB fabrikant als een aangepaste drop-in vervangende PCB voor de Google Nest Mini (2e generatie).

Dit richt zich primair op mensen die hun oude Google Nest Mini slimme speakers willen ombouwen/hergebruiken tot open-source hardware voor [Voice Control van Home Assistant](https://www.home-assistant.io/voice_control/) en/of mediaplayerspeaker-uitvoer voor [Music Assistant](https://www.music-assistant.io), (de hardware kan echter waarschijnlijk ook met andere toepassingen gebruikt worden met andere firmware, aangezien het gebaseerd is op het populaire Espressif ESP32-platform).

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_2.png" width="1000">

Het hardwareontwerp zal (vergelijkbaar met [Home Assistant Voice Preview Edition](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)) een ESP32-S3 SoC integreren voor WiFi, BLE, en [onboard wake-word detectie](https://www.home-assistant.io/voice_control/about_wake_word/) (met no-code [ESPHome firmware](https://esphome.io/)) + een XMOS xCORE XU316 chip voor geavanceerde audiobewerking (met aangepaste firmware voor microfoonreiniging voor betere spraakherkenning door lokaal draaiende algoritmes voor Noise Suppression, Acoustic Echo Cancellation, Interference Cancellation, en Automatic Gain Control).

Qua functionaliteit is het grotendeels hardwarecompatibel gemaakt met het [Home Assistant Voice Preview Edition (ook bekend als Home Assistant Voice PE](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) referentieontwerp (dat als open-source hardwareontwerp is uitgebracht door Open Home Foundation in samenwerking met Nabu Casa). Het belangrijkste verschil zal worden bepaald door beperkingen die zijn opgelegd door de Google Nest Mini-behuizing en componenten, (d.w.z. het nest-mini-drop-in-pcb project hardwareontwerp zal worden beperkt door dezelfde soort fysieke capaciteitsinputs als de originele hardware van Google).

Als zodanig is de reikwijdte van dit project/deze repository niet het ontwikkelen van nieuwe functies/functionaliteiten voor de ESPHome firmware, dus als je dat wilt, moet je je richten op de firmwareontwikkeling van de Home Assistant Voice Preview Edition en op de upstream ESPHome mainline code:

- https://github.com/esphome/home-assistant-voice-pe
  - https://github.com/esphome/esphome
      - https://github.com/esphome/feature-requests

## Verzoek om samenwerking

Als je ervaring hebt met PCB-layoutontwerp, (en vooral met PCB-routing, ground pouring, of noise-gevoelige digitale+analoge layouts), **is je hulp zeer gewaardeerd**! Voel je vrij om een nieuw issue te openen, suggesties/verzoeken in te dienen, en input/feedback toe te voegen aan bestaande issues, of deze repository te forken.

Voor meer informatie over het concept/idee zie en draag bij aan verwante discussies, zie ook deze Home Assistant community forum thread:

- https://community.home-assistant.io/t/any-news-on-alternative-to-onju-voice-pcb-repacement-design-for-google-nest-home-mini-speakers-with-added-xmos-chip-to-match-official-home-assistant-voice-preview-edition-reference-hardware/860001/

### Huidige status

- ✅ Schema afgerond
- ✅ Componentplaatsing gedaan
- ✅ Routing is gedaan
- ✅ Ground pour, afschermingsstrategie en EMI-overwegingen gedaan
- ⚠️ 1e testbatch gefaald op twee fouten - opgelost
- 🕓 wachten op de 2e testbatch

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/3D.png" width="1000">

## Gebruikte tools

- 🛠️ KiCad 9
- 🧰 SnapEDA / LCSC voor het zoeken van footprints

## Bekende hardwarespecificaties

- 4-laags PCB
- ESP32-S3R8 bare chip (ESP32-S3 voor WiFi, BLE en ingebouwde wake-word detectie)
- XMOS XU316-1024-QF60B-C32 (XMOS XU316 xCORE DSP audioprocessing)
- Dual SPI-flash
- Dual I²S-bussen (om I2S-interfaces gelijktijdig te gebruiken, d.w.z. gelijktijdige audio-uitvoer en audio-invoer)
- MAX98357 voor luidsprekeruitvoer (I2S Klasse-D Mono Audio Versterker)
- 2x MEMS-microfoons (MSM261DHP)
- SK6812 LEDs
- Aangepaste USB-C en 14V voedingsingang

---

> ⚠️ Flashen via USB-C vereist het loskoppelen van de hoofd 14V voedingsingang. Zie de silkscreen-opmerking op de PCB voor details.

## Referenties

### Home Assistant Voice Preview Edition bronnen inclusief PCB-ontwerpbestanden
- https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/
  - https://voice-pe.home-assistant.io/resources/
    - https://support.nabucasa.com/hc/nl/articles/26195279589277-Home-Assistant-Voice-Preview-Edition-PCB-ontwerpbestanden
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
 
#### XMOS firmware van het ESPHome-project voor de Home Assistant Voice Preview Edition-hardware:

- https://github.com/esphome/voice-kit-xmos-firmware
  - https://github.com/esphome/xmos_fwk_rtos
  - https://github.com/esphome/xmos_fwk_io

## Licentie

Dit project is gelicentieerd onder de [CERN Open Hardware License Version 2 - Strongly Reciprocal (CERN-OHL-S v2)]
Elke aangepaste versie van deze hardware moet ook onder dezelfde licentie worden verspreid.

☕ Wil je dit project steunen? Voel je vrij om [een kopje koffie voor me te kopen op Ko-fi](https://ko-fi.com/imike78)!



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-06

---