
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
Beide sind vollständig Open-Source-Hardwareprojekte, die einige Konzeptinspirationen vom [Onju Voice](https://github.com/justLV/onju-voice) übernehmen, jedoch darauf abzielen, den [Open Home Foundation Open Voice Assistants Standard mit Home Assistant Voice Preview Edition als Referenz](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) für PCB-Designs und Spezifikationen zu befolgen.

# Projektumfang

Das Ziel dieses Projekts und Repositorys (ähnlich dem [Onju Voice](https://github.com/justLV/onju-voice), aber unter einer vollständig Open-Source-Hardwarelizenz) ist es, eine Drop-in-Ersatz-PCB (Leiterplatte) mit Hardware-Schemata zu entwerfen, die jeder bauen oder bei einem PCB-Hersteller als maßgeschneiderte Ersatz-PCB für das Google Nest Mini (2. Generation) bestellen kann.

Dies richtet sich primär an Personen, die ihre alten Google Nest Mini Smart Speaker in Open-Source-Hardware für [Sprachsteuerung mit Home Assistant](https://www.home-assistant.io/voice_control/) und/oder als Medienplayer-Lautsprecherausgabe für [Music Assistant](https://www.music-assistant.io) umwandeln oder wiederverwenden möchten, (die Hardware kann jedoch wahrscheinlich auch mit anderen Anwendungen und Firmware genutzt werden, da sie auf der beliebten Espressif ESP32-Plattform basiert).

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_2.png" width="1000">

Das Hardware-Design wird (ähnlich wie bei der [Home Assistant Voice Preview Edition](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)) ein ESP32-S3 SoC für WiFi, BLE und [Wake-Word-Erkennung an Bord](https://www.home-assistant.io/voice_control/about_wake_word/) (mit No-Code [ESPHome-Firmware](https://esphome.io/)) integrieren + einen XMOS xCORE XU316 Chip für fortgeschrittene Audioverarbeitung (mit kundenspezifischer Firmware für Mikrofonreinigung zur Auslagerung und besseren Spracherkennung durch lokal ausgeführte Algorithmen für Rauschunterdrückung, akustische Echounterdrückung, Störunterdrückung und automatische Verstärkungsregelung).

In Bezug auf die Funktionalität ist es weitgehend hardwarekompatibel mit dem [Home Assistant Voice Preview Edition (auch bekannt als Home Assistant Voice PE)](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) Referenzdesign (das als Open-Source-Hardwaredesign von der Open Home Foundation in Zusammenarbeit mit Nabu Casa veröffentlicht wurde). Der Hauptunterschied ergibt sich aus den Einschränkungen des Google Nest Mini-Gehäuses und der Komponenten, (d.h. das nest-mini-drop-in-pcb Projekt ist durch die gleichen physischen Kapazitätseingaben wie die Originalhardware von Google begrenzt).

Daher besteht der Umfang dieses Projekts/Repositorys nicht darin, neue Funktionen für die ESPHome-Firmware zu entwickeln; falls Sie dies wünschen, wenden Sie sich stattdessen an die Firmware-Entwicklung der Home Assistant Voice Preview Edition sowie an den upstream ESPHome-Mainline-Code:

- https://github.com/esphome/home-assistant-voice-pe
  - https://github.com/esphome/esphome
      - https://github.com/esphome/feature-requests

## Anfrage zur Zusammenarbeit

Wenn Sie Erfahrung mit PCB-Layout-Design haben (insbesondere mit PCB-Routing, Masseflächen, oder rauschsensitiven digitalen+analogen Layouts), **ist Ihre Hilfe sehr willkommen**! Öffnen Sie gerne ein neues Issue, reichen Sie Vorschläge/Wünsche ein und geben Sie Input/Feedback zu bestehenden Issues oder forken Sie dieses Repository.

Weitere Informationen zum Konzept/Idee finden und beitragen Sie zur zugehörigen Diskussion im Home Assistant Community Forum Thread:

- https://community.home-assistant.io/t/any-news-on-alternative-to-onju-voice-pcb-repacement-design-for-google-nest-home-mini-speakers-with-added-xmos-chip-to-match-official-home-assistant-voice-preview-edition-reference-hardware/860001/

### Aktueller Stand

- ✅ Schaltplan abgeschlossen
- ✅ Bauteilplatzierung abgeschlossen
- ✅ Routing abgeschlossen
- ✅ Masseflächen, Abschirmungsstrategie und EMV-Betrachtungen abgeschlossen
- ⚠️ 1. Testcharge scheiterte an zwei Fehlern – behoben
- 🕓 Warten auf die 2. Testcharge

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/3D.png" width="1000">


## Verwendete Werkzeuge

- 🛠️ KiCad 9
- 🧰 SnapEDA / LCSC zur Bezugnahme von Footprints

## Bekannte Hardwarespezifikationen

- 4-lagige Leiterplatte
- ESP32-S3R8 nackter Chip (ESP32-S3 für WiFi, BLE und integrierte Wake-Word-Erkennung)
- XMOS XU316-1024-QF60B-C24 (XMOS XU316 xCORE DSP Audioprozessor)
- Dual SPI-Flash (da ESP32 und XMOS jeweils eigenen SPI-Flash besitzen)
- Duale I²S-Busse (ermöglicht gleichzeitige I2S-Schnittstellen, d.h. parallele Audioausgabe und Audioeingabe)
- MAX98357 für Lautsprecherausgang (I2S Class-D Mono Audioverstärker)
- 2x MEMS Mikrofone (duale MMICT390200012 mit 68 mm Mikrofonabstand)
- 6x SK6812 RGB LEDs
- Individueller USB-C- und 14V-Stromanschluss (Hinweis! USB-C und Hohlstecker dürfen nicht gleichzeitig verbunden werden)

---

> ⚠️ Das Flashen über USB-C erfordert das Trennen des Haupt-14V-Stromanschlusses. Siehe Hinweis auf dem Silkscreen der Leiterplatte für Details.

## Referenzen

### Ressourcen zur Home Assistant Voice Preview Edition einschließlich PCB-Design-Dateien
- https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/
  - https://voice-pe.home-assistant.io/resources/
    - https://support.nabucasa.com/hc/de/articles/26195279589277-Home-Assistant-Voice-Preview-Edition-PCB-design-files
      - https://raw.githubusercontent.com/NabuCasa/support/refs/heads/main/static/docs/voice/home_assistant_voice_pe_schematic_v1.0_241009.pdf
     
#### ESPHome Firmware für Home Assistant Voice PE (die ebenfalls die Kombination ESP32-S3 + XMOS XU316 verwendet):

- https://github.com/esphome/home-assistant-voice-pe
  - https://esphome.github.io/home-assistant-voice-pe/
- https://voice-pe.home-assistant.io/

### XMOS xCORE DSP (XU316-1024-QF60B-C32) MCU IC Chip

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

Dieses Projekt steht unter der [CERN Open Hardware License Version 2 - Strongly Reciprocal (CERN-OHL-S v2)].
Jede modifizierte Version dieser Hardware muss ebenfalls unter derselben Lizenz verteilt werden.

☕ Wenn Sie dieses Projekt unterstützen möchten, können Sie mir gerne [einen Kaffee auf Ko-fi spendieren](https://ko-fi.com/imike78)!



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-03

---