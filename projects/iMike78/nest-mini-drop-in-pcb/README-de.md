
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

**Achtung!** Es läuft derzeit eine laufende Crowdfunding-Kampagne für das "MiciMike Home Mini Drop-In PCB" (1. Gen Google Home Mini), die jetzt auf Crowd Supply in einer Vorverkaufsphase (Projekt-Voransicht nur) live ist. Bei Erfolg ist eine entsprechende Kampagne für den neueren Nest Mini (2. Gen) geplant. Schauen Sie hier vorbei und unterstützen Sie das Projekt indirekt, indem Sie es nach Möglichkeit unterstützen:

* https://www.crowdsupply.com/micimike-rev-devices/micimike-home-mini-drop-in-pcb

Beide sind vollständig Open-Source-Hardware-Projekte, inspiriert vom Konzept des [Onju Voice](https://github.com/justLV/onju-voice), jedoch mit dem Ziel, dem [Open Home Foundation-Standard für offene Sprachassistenten mit Home Assistant Voice Preview Edition als Referenz](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) für PCB-Designs und Spezifikationen zu folgen.

# Projektumfang

Das Ziel dieses Projekts und Repositories (ähnlich wie [Onju Voice](https://github.com/justLV/onju-voice), jedoch unter einer vollständig offenen Hardwarelizenz) ist es, ein Drop-in-Ersatz-PCB (Leiterplatte) mit Hardwareschaltplänen zu entwerfen, das jeder als individuelles Drop-in-Ersatz-PCB für den Google Nest Mini (2. Gen) selbst bauen oder bei einem PCB-Hersteller bestellen kann.

Dies richtet sich in erster Linie an Menschen, die ihre alten Google Nest Mini Smart Speaker in Open-Source-Hardware für die [Sprachsteuerung von Home Assistant](https://www.home-assistant.io/voice_control/) und/oder als Media-Player-Lautsprecher für [Music Assistant](https://www.music-assistant.io) umwandeln/umfunktionieren möchten (die Hardware kann jedoch wahrscheinlich auch für andere Anwendungen mit anderer Firmware verwendet werden, da sie auf der beliebten Espressif ESP32-Plattform basiert).

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/front_render.jpg" width="1000" alt="First test PCB">

Das Hardwaredesign wird (ähnlich wie [Home Assistant Voice Preview Edition](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)) ein ESP32-S3 SoC für WLAN, BLE und [Onboard-Wake-Word-Erkennung](https://www.home-assistant.io/voice_control/about_wake_word/) (mithilfe der No-Code-[ESPHome-Firmware](https://esphome.io/)) + einen XMOS xCORE XU316-Chip für fortschrittliche Audioprozessierung (mit eigener Firmware für Mikrofon-Signalaufbereitung und bessere Spracherkennung dank lokal laufender Algorithmen für Geräuschunterdrückung, akustische Echounterdrückung, Interferenzunterdrückung und automatische Pegelregelung) integrieren.

Funktionsmäßig ist es so konzipiert, dass es weitgehend hardwarekompatibel mit dem [Home Assistant Voice Preview Edition (a.k.a. Home Assistant Voice PE](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) Referenzdesign ist (das als Open-Source-Hardwaredesign von der Open Home Foundation in Zusammenarbeit mit Nabu Casa veröffentlicht wurde). Der Hauptunterschied ergibt sich durch die vom Google Nest Mini-Gehäuse und den Komponenten vorgegebenen Einschränkungen, (d.h. das nest-mini-drop-in-pcb-Projektdesign ist durch die gleichen physischen Kapazitiv-Eingaben limitiert wie die Originalhardware von Google).

Der Umfang dieses Projekts/Repositories besteht daher nicht darin, neue Funktionen für die ESPHome-Firmware zu entwickeln. Wenn Sie das möchten, wenden Sie sich bitte an die Firmware-Entwicklung der Home Assistant Voice Preview Edition sowie an den Upstream-ESPHome-Mainline-Code:

- https://github.com/esphome/home-assistant-voice-pe
  - https://github.com/esphome/esphome
      - https://github.com/esphome/feature-requests

## Anfrage zur Zusammenarbeit

Wenn Sie Erfahrung im PCB-Layout haben (insbesondere bei Leiterbahnführung, Masseflächen oder rauschempfindlichen Digital+Analog-Layouts), ist **Ihre Hilfe sehr willkommen**! Gerne ein neues Issue eröffnen, Vorschläge/Wünsche einreichen und Feedback zu bestehenden Issues geben oder das Repository forken.

Weitere Informationen zum Konzept/der Idee finden und diskutieren Sie auch in diesem Thread des Home Assistant Community-Forums:

- https://community.home-assistant.io/t/any-news-on-alternative-to-onju-voice-pcb-repacement-design-for-google-nest-home-mini-speakers-with-added-xmos-chip-to-match-official-home-assistant-voice-preview-edition-reference-hardware/860001/

### Aktueller Status

- ✅ Schaltplan abgeschlossen
- ✅ Bauteilplatzierung fertig
- ✅ Routing abgeschlossen
- ✅ Masseflächen, Abschirmstrategie und EMV-Betrachtungen fertig
- ⛔ 1. Testserie ist an zwei Fehlern gescheitert – behoben
- ⚠️ 2. Testcharge funktioniert teilweise
- ✅ XTAG4 Debug-Option für den nächsten Batch hinzugefügt

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/back_render.jpg" width="1000">

## Verwendete Werkzeuge

- 🛠️ KiCad 9
- 🧰 SnapEDA / LCSC zur Footprint-Beschaffung

## Bekannte Hardwarespezifikationen

- 4-lagige Leiterplatte
- ESP32-S3R8 nackter Chip (ESP32-S3 für WiFi, BLE und integrierte Wake-Word-Erkennung)
- XMOS XU316-1024-QF60B-C24 (XMOS XU316 xCORE DSP Audioprozessierung)
- 16 MB SPI-Flash (ESP32-S3)
- 4 MB SPI-Flash (XMOS XU316)
- Zwei I²S-Busse (gleichzeitige Audioeingabe und -ausgabe)
- TAS5805M (TAS5805MPWPR) Stereo-Class-D-Verstärker mit integriertem DSP (I2S Audio, I2C Steuerung), konfiguriert für mono BTL-Lautsprecherausgang
- 3x MEMS-Mikrofone (MMICT390200012) angeordnet auf einem 34 mm Radius-Bogen – aktuelle Firmware verwendet 2 Mikrofone, Hardwareunterstützung für ein 3-Mikrofon-Array ist bereits vorhanden
- 6x SK6812 RGB-LEDs
- Benutzerdefinierter USB-C- und 14V-Stromanschluss (Achtung! USB-C und Hohlstecker dürfen nicht gleichzeitig angeschlossen werden)
- MPR121 kapazitiver Touch-Controller (wird für Touch-Eingaben verwendet anstelle der nativen Touch-Erkennung des ESP32-S3)

---

> ⚠️ Das Flashen über USB-C erfordert das Trennen des Haupt-14V-Stromanschlusses. Siehe Hinweis auf der Leiterplatte für Details.

## Referenzen

### Home Assistant Voice Preview Edition Ressourcen einschließlich PCB-Design-Dateien
- https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/
  - https://voice-pe.home-assistant.io/resources/
    - https://support.nabucasa.com/hc/de/articles/26195279589277-Home-Assistant-Voice-Preview-Edition-PCB-Design-Dateien
      - https://raw.githubusercontent.com/NabuCasa/support/refs/heads/main/static/docs/voice/home_assistant_voice_pe_schematic_v1.0_241009.pdf
     
#### ESPHome-Firmware für Home Assistant Voice PE (die ebenfalls die gleiche ESP32-S3 + XMOS XU316 Kombination verwenden):

- https://github.com/esphome/home-assistant-voice-pe
  - https://esphome.github.io/home-assistant-voice-pe/
- https://voice-pe.home-assistant.io/

### XMOS xCORE DSP (XU316-1024-QF60B-C24) MCU IC Chip

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

Dieses Projekt ist lizenziert unter der [CERN Open Hardware License Version 2 - Strongly Reciprocal (CERN-OHL-S v2)]
Jede modifizierte Version dieser Hardware muss ebenfalls unter derselben Lizenz verbreitet werden.

☕ Wenn Sie dieses Projekt unterstützen möchten, können Sie mir gerne [einen Kaffee auf Ko-fi spendieren](https://ko-fi.com/imike78)!




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-24

---