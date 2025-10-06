
<div align="right">
  <details>
    <summary >🌐 Język</summary>
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

# MiciMike - wymiennik PCB typu drop-in dla Google Nest Mini

[MiciMike Nest Mini](https://github.com/iMike78/nest-mini-drop-in-pcb) to wymiennik PCB typu drop-in dla ["Google Nest Mini" (druga generacja inteligentnego głośnika Google z portem ładowania na wtyk beczkowy)](https://pl.wikipedia.org/wiki/Google_Nest_(smart_speakers)), oparty jednak na mikrokontrolerach ESP32 i XMOS do uruchamiania otwartego oprogramowania.

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_1.png" width="1000">

Wskazówka! Jeśli szukasz podobnego wymiennika PCB typu drop-in dla "Google Home Mini" (pierwsza generacja inteligentnego głośnika Google z portem ładowania Micro-USB), sprawdź projekt bliźniaczy na https://github.com/iMike78/home-mini-v1-drop-in-pcb

Oba te projekty to w pełni otwartoźródłowe projekty sprzętowe, czerpiące pewną inspirację koncepcyjną z [Onju Voice](https://github.com/justLV/onju-voice), jednak mające na celu stosowanie [otwartego standardu asystentów głosowych Open Home Foundation z Home Assistant Voice Preview Edition jako odniesienie](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) dla projektów PCB i specyfikacji.

# Zakres projektu

Celem tego projektu i repozytorium (które jest podobne do [Onju Voice](https://github.com/justLV/onju-voice), ale na w pełni otwartej licencji sprzętowej) jest zaprojektowanie płytki PCB (Printed Circuit Board) jako zamiennika typu drop-in wraz ze schematami sprzętowymi, którą każdy może wykonać/zbudować lub zamówić u dowolnego producenta PCB jako niestandardowy zamiennik PCB do Google Nest Mini (2. generacji).

Projekt skierowany jest głównie do osób chcących przekonwertować/przekształcić swoje stare inteligentne głośniki Google Nest Mini na otwartoźródłowy sprzęt dla [Sterowania głosem w Home Assistant](https://www.home-assistant.io/voice_control/) i/lub wyjście głośnikowe odtwarzacza multimedialnego dla [Music Assistant](https://www.music-assistant.io), (sprzęt można jednak najprawdopodobniej użyć także w innych zastosowaniach z innym firmware, gdyż bazuje na popularnej platformie Espressif ESP32).

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_2.png" width="1000">

Projekt sprzętu będzie (podobnie jak [Home Assistant Voice Preview Edition](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)) integrować SoC ESP32-S3 dla WiFi, BLE oraz [wbudowane wykrywanie frazy wybudzającej](https://www.home-assistant.io/voice_control/about_wake_word/) (przy użyciu firmware bez kodowania [ESPHome](https://esphome.io/)) + układ XMOS xCORE XU316 do zaawansowanego przetwarzania dźwięku (z własnym firmware do odciążania mikrofonów w celu lepszego rozpoznawania mowy przy użyciu lokalnych algorytmów: tłumienie szumów, eliminacja echa akustycznego, eliminacja zakłóceń oraz automatyczna kontrola wzmocnienia).

Funkcjonalnie został zaprojektowany jako sprzętowo w dużej mierze zgodny z [Home Assistant Voice Preview Edition (tzw. Home Assistant Voice PE](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) jako projekt referencyjny (który został udostępniony jako otwartoźródłowy projekt sprzętowy przez Open Home Foundation we współpracy z Nabu Casa). Główna różnica wynikać będzie z ograniczeń określonych przez obudowę i komponenty Google Nest Mini (czyli hardware projektu nest-mini-drop-in-pcb będzie ograniczony tymi samymi rodzajami fizycznych wejść jak oryginalny sprzęt Google).

W związku z tym zakres tego projektu/repozytorium nie obejmuje opracowywania nowych funkcji dla firmware ESPHome; jeśli tego oczekujesz, powinieneś zwrócić się do rozwoju firmware Home Assistant Voice Preview Edition oraz do głównego kodu ESPHome:

- https://github.com/esphome/home-assistant-voice-pe
  - https://github.com/esphome/esphome
      - https://github.com/esphome/feature-requests

## Prośba o współpracę

Jeśli masz doświadczenie w projektowaniu układów PCB (zwłaszcza w prowadzeniu ścieżek, wylewaniu masy czy układach cyfrowo-analogowych wrażliwych na zakłócenia), **Twoja pomoc jest bardzo mile widziana**! Śmiało otwórz nowe zgłoszenie, zgłaszaj sugestie/prośby, dodawaj uwagi/feedback do istniejących zgłoszeń lub zforkuj to repozytorium.

Więcej informacji o koncepcji/pomysłu oraz możliwość dyskusji znajdziesz również w tym wątku na forum społeczności Home Assistant:

- https://community.home-assistant.io/t/any-news-on-alternative-to-onju-voice-pcb-repacement-design-for-google-nest-home-mini-speakers-with-added-xmos-chip-to-match-official-home-assistant-voice-preview-edition-reference-hardware/860001/

### Aktualny status

- ✅ Schematic completed
- ✅ Component placement done
- ✅ Routing is done
- ✅ Ground pour, shielding strategy, and EMI considerations done
- ⚠️ 1st test batch failed on two errors - fixed
- 🕓 waiting for the 2nd test batch

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/3D.png" width="1000">

## Użyte narzędzia

- 🛠️ KiCad 9
- 🧰 SnapEDA / LCSC do pozyskiwania footprintów

## Znane specyfikacje sprzętowe

- PCB 4-warstwowy
- Goły chip ESP32-S3R8 (ESP32-S3 do WiFi, BLE i detekcji słowa budzącego na pokładzie)
- XMOS XU316-1024-QF60B-C32 (XMOS XU316 xCORE DSP do przetwarzania dźwięku)
- Podwójna pamięć SPI flash
- Podwójne magistrale I²S (umożliwiające jednoczesne interfejsy I2S, tj. równoczesny wyjście i wejście audio)
- MAX98357 do wyjścia na głośnik (I2S Class-D Mono Audio Amplifier)
- 2x mikrofony MEMS (MSM261DHP)
- Diody LED SK6812
- Niestandardowe wejście USB-C i zasilanie 14V

---

> ⚠️ Programowanie przez USB-C wymaga odłączenia głównego zasilania 14V. Szczegóły na notce silk-screen na PCB.

## Odnośniki

### Zasoby Home Assistant Voice Preview Edition, w tym pliki projektowe PCB
- https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/
  - https://voice-pe.home-assistant.io/resources/
    - https://support.nabucasa.com/hc/en-us/articles/26195279589277-Home-Assistant-Voice-Preview-Edition-PCB-design-files
      - https://raw.githubusercontent.com/NabuCasa/support/refs/heads/main/static/docs/voice/home_assistant_voice_pe_schematic_v1.0_241009.pdf
     
#### Oprogramowanie ESPHome dla Home Assistant Voice PE (które również wykorzystuje kombinację ESP32-S3 + XMOS XU316):

- https://github.com/esphome/home-assistant-voice-pe
  - https://esphome.github.io/home-assistant-voice-pe/
- https://voice-pe.home-assistant.io/

### XMOS xCORE DSP (XU316-1024-QF60B-C32) układ MCU IC

- https://www.xmos.com/download/XU316-1024-QF60B-xcore.ai-Datasheet(3).pdf
- https://www.xmos.com/software-tools/
  - https://www.xmos.com/develop/xcore-voice
  - https://www.xmos.com/usb-multichannel-audio/
  - https://www.xmos.com/xcore-ai
 
#### Oprogramowanie firmware XMOS z projektu ESPHome dla sprzętu Home Assistant Voice Preview Edition:

- https://github.com/esphome/voice-kit-xmos-firmware
  - https://github.com/esphome/xmos_fwk_rtos
  - https://github.com/esphome/xmos_fwk_io

## Licencja

Ten projekt jest objęty licencją [CERN Open Hardware License Version 2 - Strongly Reciprocal (CERN-OHL-S v2)]
Każda zmodyfikowana wersja tego sprzętu musi być również rozpowszechniana na tej samej licencji.

☕ Jeśli chcesz wesprzeć ten projekt, możesz [postawić mi kawę na Ko-fi](https://ko-fi.com/imike78)!



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-06

---