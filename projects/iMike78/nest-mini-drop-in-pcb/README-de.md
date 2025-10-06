
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

# MiciMike Austausch-PCB für Google Nest Mini

[MiciMike Nest Mini](https://github.com/iMike78/nest-mini-drop-in-pcb) ist eine Austausch-PCB für den ["Google Nest Mini" (Googles Smart Speaker der zweiten Generation mit Barrel-Anschluss für das Ladegerät)](https://de.wikipedia.org/wiki/Google_Nest_(smart_speakers)), basiert jedoch auf ESP32- und XMOS-Mikrocontrollern zur Ausführung von Open-Source-Firmware.

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_1.png" width="1000">

Tipp! Falls Sie stattdessen nach einer ähnlichen Austausch-PCB für den "Google Home Mini" suchen (Googles Smart Speaker-Hardware der ersten Generation mit Micro-USB-Ladeanschluss), dann schauen Sie sich das Schwesterprojekt unter https://github.com/iMike78/home-mini-v1-drop-in-pcb an.

Beide Projekte sind vollständig Open-Source-Hardwareprojekte, die einige Konzeptideen von [Onju Voice](https://github.com/justLV/onju-voice) übernehmen, jedoch das Ziel verfolgen, dem [Open Home Foundation Standard für offene Sprachassistenten mit Home Assistant Voice Preview Edition als Referenz](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) für PCB-Designs und Spezifikationen zu folgen.

# Projektumfang

Ziel dieses Projekts und Repositories (ähnlich wie [Onju Voice](https://github.com/justLV/onju-voice), aber unter einer vollständig offenen Hardwarelizenz) ist es, eine Drop-in-Ersatz-Platine (PCB, Printed Circuit Board) mit Hardware-Schemata zu entwerfen, die jeder selbst herstellen, bauen oder bei einem PCB-Hersteller als maßgeschneiderte Drop-in-Ersatzplatine für den Google Nest Mini (2. Generation) bestellen kann.

Das Projekt richtet sich primär an Personen, die ihre alten Google Nest Mini Smart Speaker in Open-Source-Hardware für [Sprachsteuerung von Home Assistant](https://www.home-assistant.io/voice_control/) und/oder als Lautsprecherausgabe für den [Music Assistant](https://www.music-assistant.io) umwandeln/umnutzen möchten (die Hardware kann allerdings vermutlich auch mit anderen Anwendungen und Firmware genutzt werden, da sie auf der beliebten Espressif ESP32-Plattform basiert).

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_2.png" width="1000">

Das Hardware-Design wird (ähnlich wie [Home Assistant Voice Preview Edition](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)) ein ESP32-S3 SoC für WiFi, BLE und [Wake-Word-Erkennung an Bord](https://www.home-assistant.io/voice_control/about_wake_word/) (mit No-Code [ESPHome Firmware](https://esphome.io/)) + einen XMOS xCORE XU316 Chip für fortschrittliche Audioprozessierung integrieren (mit kundenspezifischer Firmware für Mikrofon-Säuberung zur besseren Spracherkennung mittels lokal laufender Algorithmen für Rauschunterdrückung, akustische Echounterdrückung, Störunterdrückung und automatische Verstärkungsregelung).

Funktionsmäßig ist sie größtenteils hardwarekompatibel mit dem [Home Assistant Voice Preview Edition (auch bekannt als Home Assistant Voice PE)](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) Referenzdesign (das als Open-Source-Hardwaredesign von der Open Home Foundation in Zusammenarbeit mit Nabu Casa veröffentlicht wurde). Der Hauptunterschied ergibt sich aus den Einschränkungen durch das Google Nest Mini Gehäuse und die Komponenten, (d.h. das nest-mini-drop-in-pcb Hardwaredesign ist durch die gleiche Art von physikalischen Eingaben wie die Originalhardware von Google begrenzt).

Der Umfang dieses Projekts/Repositories beinhaltet daher nicht die Entwicklung neuer Funktionen für die ESPHome Firmware. Falls Sie daran interessiert sind, wenden Sie sich stattdessen an die Firmware-Entwicklung der Home Assistant Voice Preview Edition sowie an den Upstream-ESPHome-Mainline-Code:

- https://github.com/esphome/home-assistant-voice-pe
  - https://github.com/esphome/esphome
      - https://github.com/esphome/feature-requests

## Kollaborationsanfrage

Wenn Sie Erfahrung mit PCB-Layout-Design haben (insbesondere mit PCB-Routing, Masseflächen, oder rauschempfindlichen digitalen + analogen Layouts), **ist Ihre Hilfe sehr willkommen**! Sie können gerne ein neues Issue eröffnen, Vorschläge/Anfragen einreichen, Feedback zu bestehenden Issues geben oder dieses Repository forken.

Weitere Informationen zum Konzept/der Idee finden und beitragen können Sie auch in diesem Thread im Home Assistant Community Forum:

- https://community.home-assistant.io/t/any-news-on-alternative-to-onju-voice-pcb-repacement-design-for-google-nest-home-mini-speakers-with-added-xmos-chip-to-match-official-home-assistant-voice-preview-edition-reference-hardware/860001/

### Aktueller Status

- ✅ Schaltplan abgeschlossen
- ✅ Bauteilplatzierung erfolgt
- ✅ Routing abgeschlossen
- ✅ Masseflächen, Abschirmungsstrategie und EMI-Betrachtungen erledigt
- ⚠️ 1. Testcharge ist an zwei Fehlern gescheitert – behoben
- 🕓 Warte auf die 2. Testcharge

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/3D.png" width="1000">

## Verwendete Tools

- 🛠️ KiCad 9
- 🧰 SnapEDA / LCSC für Footprint-Quellen

## Bekannte Hardware-Spezifikationen

- 4-lagige Leiterplatte (PCB)
- ESP32-S3R8 Bare-Chip (ESP32-S3 für WiFi, BLE und integrierte Wake-Word-Erkennung)
- XMOS XU316-1024-QF60B-C32 (XMOS XU316 xCORE DSP Audioverarbeitung)
- Dual SPI-Flash
- Dual I²S-Busse (ermöglicht gleichzeitige I2S-Schnittstellen, d. h. gleichzeitige Audioausgabe und Audioeingabe)
- MAX98357 für Lautsprecherausgang (I2S Class-D Mono Audio-Verstärker)
- 2x MEMS-Mikrofone (MSM261DHP)
- SK6812 LEDs
- Benutzerdefinierter USB-C und 14V-Stromversorgungseingang

---

> ⚠️ Das Flashen über USB-C erfordert das Trennen des Haupt-14V-Stromversorgungseingangs. Siehe Hinweis auf dem PCB-Siebdruck für Details.

## Referenzen

### Home Assistant Voice Preview Edition Ressourcen inklusive PCB-Design-Dateien
- https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/
  - https://voice-pe.home-assistant.io/resources/
    - https://support.nabucasa.com/hc/de/articles/26195279589277-Home-Assistant-Voice-Preview-Edition-PCB-Design-Dateien
      - https://raw.githubusercontent.com/NabuCasa/support/refs/heads/main/static/docs/voice/home_assistant_voice_pe_schematic_v1.0_241009.pdf
     
#### ESPHome Firmware für Home Assistant Voice PE (welche ebenfalls die Kombination ESP32-S3 + XMOS XU316 verwenden):

- https://github.com/esphome/home-assistant-voice-pe
  - https://esphome.github.io/home-assistant-voice-pe/
- https://voice-pe.home-assistant.io/

### XMOS xCORE DSP (XU316-1024-QF60B-C32) MCU IC-Chip

- https://www.xmos.com/download/XU316-1024-QF60B-xcore.ai-Datenblatt(3).pdf
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
Jede modifizierte Version dieser Hardware muss ebenfalls unter derselben Lizenz verteilt werden.

☕ Wenn Sie dieses Projekt unterstützen möchten, können Sie mir gerne [einen Kaffee auf Ko-fi kaufen](https://ko-fi.com/imike78)!



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-06

---