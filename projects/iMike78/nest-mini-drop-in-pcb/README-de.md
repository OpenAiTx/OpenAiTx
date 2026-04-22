
<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
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

# MiciMike Drop-in-PCB-Ersatz für Google Nest Mini

[MiciMike Nest Mini](https://github.com/iMike78/nest-mini-drop-in-pcb) ist ein Drop-in-PCB-Ersatz für den ["Google Nest Mini" (Googles Smart Speaker der zweiten Generation mit Barrel-Anschluss-Ladeport)](https://en.wikipedia.org/wiki/Google_Nest_(smart_speakers)), jedoch basierend auf ESP32- und XMOS-Mikrocontrollern zur Ausführung von Open-Source-Firmware.

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_1.png" width="1000">

Tipp! Falls Sie stattdessen nach einem ähnlichen Drop-in-PCB-Ersatz für den "Google Home Mini" (Googles Smart Speaker der ersten Generation mit Micro-USB-Ladeport) suchen, schauen Sie sich das Schwesterprojekt unter https://github.com/iMike78/home-mini-v1-drop-in-pcb an.

**Achtung!** Die bevorstehende Crowdfunding-Kampagne für das "MiciMike Home Mini Drop-In PCB" (1. Generation Google Home Mini) ist jetzt in der Pre-Launch-Phase bei Crowd Supply gelistet (nur Projektvorschau). Sollte diese erfolgreich sein, ist eine entsprechende Kampagne für den Nest Mini geplant. Weitere Infos hier:

* https://www.crowdsupply.com/micimike-rev-devices/micimike-home-mini-drop-in-pcb

Beide Projekte sind vollständig Open-Source-Hardware und nehmen einige Konzeptideen von [Onju Voice](https://github.com/justLV/onju-voice) auf, zielen jedoch darauf ab, den [Open Home Foundation Standard für offene Sprachassistenten mit Home Assistant Voice Preview Edition als Referenz](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) für PCB-Design und Spezifikationen zu befolgen.

# Projektumfang

Ziel dieses Projekts und des Repositories (ähnlich wie [Onju Voice](https://github.com/justLV/onju-voice), aber unter einer vollständig offenen Hardwarelizenz) ist es, ein Drop-In-Ersatz-PCB (Leiterplatte) mit Hardwareschaltplänen zu entwerfen, das jeder selbst herstellen/bauen oder bei einem PCB-Hersteller als kundenspezifisches Drop-In-Ersatz-PCB für den Google Nest Mini (2. Generation) bestellen kann.

Dies richtet sich in erster Linie an Personen, die ihre alten Google Nest Mini Smart Speaker in Open-Source-Hardware für [Sprachsteuerung von Home Assistant](https://www.home-assistant.io/voice_control/) und/oder als Medienlautsprecher für [Music Assistant](https://www.music-assistant.io) umwandeln/umnutzen möchten. (Die Hardware kann jedoch wahrscheinlich auch mit anderen Anwendungen und anderer Firmware verwendet werden, da sie auf der weit verbreiteten Espressif ESP32-Plattform basiert).

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_2.png" width="1000">

Das Hardwaredesign wird (ähnlich wie [Home Assistant Voice Preview Edition](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)) einen ESP32-S3 SoC für WLAN, BLE und [Onboard-Wakeword-Erkennung](https://www.home-assistant.io/voice_control/about_wake_word/) (mit No-Code [ESPHome Firmware](https://esphome.io/)) + einen XMOS xCORE XU316 Chip für fortschrittliche Audioprozessierung integrieren (mit eigener Firmware für Mikrofonbereinigung zur besseren Spracherkennung durch lokal laufende Algorithmen für Rauschunterdrückung, akustische Echounterdrückung, Interferenzunterdrückung und automatische Verstärkungsregelung).

Funktional ist das Design weitgehend hardwarekompatibel zur [Home Assistant Voice Preview Edition (auch bekannt als Home Assistant Voice PE)](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) Referenz (die als Open-Source-Hardwaredesign von der Open Home Foundation in Zusammenarbeit mit Nabu Casa veröffentlicht wurde). Der Hauptunterschied ergibt sich durch die durch das Google Nest Mini-Gehäuse und dessen Komponenten definierten Einschränkungen (d. h. das nest-mini-drop-in-pcb Projekt ist durch die gleiche Art physikalischer Schnittstellen wie die Originalhardware von Google limitiert).

Der Umfang dieses Projekts/Repositories umfasst daher nicht die Entwicklung neuer Features/Funktionen für die ESPHome-Firmware. Wer dies möchte, muss sich an die Firmware-Entwicklung der Home Assistant Voice Preview Edition sowie an den Upstream-Code von ESPHome wenden:

- https://github.com/esphome/home-assistant-voice-pe
  - https://github.com/esphome/esphome
      - https://github.com/esphome/feature-requests

## Kollaborationsanfrage

Wer Erfahrung im PCB-Layout-Design hat (insbesondere mit Routing, Ground Pouring oder rauschsensitiven Digital+Analog-Layouts), **deine Hilfe ist sehr willkommen**! Gerne neue Issues eröffnen, Vorschläge/Anfragen einreichen und Input/Feedback zu bestehenden Issues hinzufügen oder dieses Repository forken.

Mehr Informationen zum Konzept/der Idee und Beiträge zur Diskussion gibt es auch im passenden Thread im Home Assistant Community-Forum:

- https://community.home-assistant.io/t/any-news-on-alternative-to-onju-voice-pcb-repacement-design-for-google-nest-home-mini-speakers-with-added-xmos-chip-to-match-official-home-assistant-voice-preview-edition-reference-hardware/860001/

### Aktueller Stand

- ✅ Schaltplan fertiggestellt
- ✅ Bauteilplatzierung abgeschlossen
- ✅ Routing abgeschlossen
- ✅ Masseflächen, Abschirmung und EMV-Überlegungen abgeschlossen
- ⚠️ 1. Testserie scheiterte an zwei Fehlern – behoben
- 🕓 Warten auf die 2. Testreihe

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/3D.png" width="1000">

## Verwendete Werkzeuge

- 🛠️ KiCad 9
- 🧰 SnapEDA / LCSC zur Footprint-Beschaffung

## Bekannte Hardwarespezifikationen

- 4-lagige Leiterplatte (PCB)
- ESP32-S3R8 Bare-Chip (ESP32-S3 für WiFi, BLE und integrierte Wake-Word-Erkennung)
- XMOS XU316-1024-QF60B-C24 (XMOS XU316 xCORE DSP Audioprozessor)
- Dual SPI-Flash (da ESP32 und XMOS jeweils ihren eigenen SPI-Flash haben)
- Dual I²S-Busse (ermöglicht gleichzeitige I2S-Schnittstellen, d. h. gleichzeitige Audioausgabe und -eingabe)
- TAS5805M (TAS5805MPWPR) für Lautsprecherausgabe (I2S Class-D Mono Audio-Verstärker mit DSP-Konfiguration über I2C)
- 2x MEMS-Mikrofone (doppelte MMICT390200012 mit 68mm Mikrofonabstand)
- 6x SK6812 RGB-LEDs
- Spezieller USB-C- und 14V-Stromanschluss (Hinweis! USB-C und Hohlstecker dürfen nicht gleichzeitig verbunden werden)

---

> ⚠️ Das Flashen über USB-C erfordert das Trennen des Haupt-14V-Stromeingangs. Siehe Hinweis auf dem Silkscreen der Leiterplatte.

## Referenzen

### Home Assistant Voice Preview Edition Ressourcen inklusive PCB-Design-Dateien
- https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/
  - https://voice-pe.home-assistant.io/resources/
    - https://support.nabucasa.com/hc/de/articles/26195279589277-Home-Assistant-Voice-Preview-Edition-PCB-design-files
      - https://raw.githubusercontent.com/NabuCasa/support/refs/heads/main/static/docs/voice/home_assistant_voice_pe_schematic_v1.0_241009.pdf
     
#### ESPHome Firmware für Home Assistant Voice PE (die ebenfalls die gleiche ESP32-S3 + XMOS XU316 Kombination verwendet):

- https://github.com/esphome/home-assistant-voice-pe
  - https://esphome.github.io/home-assistant-voice-pe/
- https://voice-pe.home-assistant.io/

### XMOS xCORE DSP (XU316-1024-QF60B-C32) MCU IC-Chip

- https://www.xmos.com/download/XU316-1024-QF60B-xcore.ai-Datasheet(3).pdf
- https://www.xmos.com/software-tools/
  - https://www.xmos.com/develop/xcore-voice
  - https://www.xmos.com/usb-multichannel-audio/
  - https://www.xmos.com/xcore-ai
 
#### XMOS-Firmware aus dem ESPHome-Projekt für die Home Assistant Voice Preview Edition Hardware:

- https://github.com/esphome/voice-kit-xmos-firmware
  - https://github.com/esphome/xmos_fwk_rtos
  - https://github.com/esphome/xmos_fwk_io

## Lizenz

Dieses Projekt steht unter der [CERN Open Hardware License Version 2 - Strongly Reciprocal (CERN-OHL-S v2)]
Jede modifizierte Version dieser Hardware muss ebenfalls unter derselben Lizenz veröffentlicht werden.

☕ Wenn Sie dieses Projekt unterstützen möchten, können Sie mir gerne [einen Kaffee auf Ko-fi spendieren](https://ko-fi.com/imike78)!




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-22

---