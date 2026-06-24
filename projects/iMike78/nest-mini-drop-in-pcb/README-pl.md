
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

# MiciMike wymienna płytka PCB dla Google Nest Mini

[MiciMike Nest Mini](https://github.com/iMike78/nest-mini-drop-in-pcb) to wymienna płytka PCB dla ["Google Nest Mini" (druga generacja inteligentnego głośnika Google z okrągłym złączem zasilania)](https://pl.wikipedia.org/wiki/Google_Nest_(smart_speakers)), oparta na mikrokontrolerach ESP32 i XMOS, umożliwiająca uruchamianie otwartego oprogramowania.

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_1.png" width="1000">

Wskazówka! Jeśli szukasz podobnej wymiennej płytki PCB dla "Google Home Mini" (pierwsza generacja inteligentnego głośnika Google z portem Micro-USB), sprawdź projekt siostrzany pod adresem https://github.com/iMike78/home-mini-v1-drop-in-pcb

**Uwaga!** Obecnie trwa kampania crowdfundingowa dla "MiciMike Home Mini Drop-In PCB" (1. gen Google Home Mini), która jest już dostępna w przedsprzedaży na Crowd Supply (tylko podgląd projektu). Jeśli zakończy się sukcesem, planowana jest podobna kampania dla nowszego Nest Mini (2. gen). Zajrzyj tutaj i wesprzyj ten projekt pośrednio, wspierając go, jeśli możesz:

* https://www.crowdsupply.com/micimike-rev-devices/micimike-home-mini-drop-in-pcb

Oba te projekty są w pełni open-source hardware, czerpiąc częściowo inspirację z [Onju Voice](https://github.com/justLV/onju-voice), jednak dążą do zgodności ze standardem otwartych asystentów głosowych [Open Home Foundation oraz Home Assistant Voice Preview Edition jako odniesienie](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) dla projektowania PCB i specyfikacji.

# Zakres projektu

Celem tego projektu i repozytorium (które jest podobne do [Onju Voice](https://github.com/justLV/onju-voice), ale na pełnej licencji open-source hardware) jest zaprojektowanie wymiennej płytki PCB (Printed Circuit Board) z dokumentacją sprzętową, którą każdy może wykonać/zamówić u wybranego producenta PCB jako niestandardowy zamiennik PCB do Google Nest Mini (2. gen).

Projekt skierowany jest przede wszystkim do osób, które chcą przerobić/przeznaczyć swoje stare głośniki Google Nest Mini na open-source hardware do [Sterowania Głosem Home Assistant](https://www.home-assistant.io/voice_control/) i/lub wyjścia głośnikowego dla [Music Assistant](https://www.music-assistant.io), (sprzęt może być jednak używany z innymi zastosowaniami i innym firmware, ponieważ oparty jest na popularnej platformie Espressif ESP32).

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/front_render.jpg" width="1000" alt="First test PCB">

Projekt sprzętu będzie (podobnie jak [Home Assistant Voice Preview Edition](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)) integrować SoC ESP32-S3 dla WiFi, BLE oraz [detekcji słowa budzącego na pokładzie](https://www.home-assistant.io/voice_control/about_wake_word/) (bez kodowania, [firmware ESPHome](https://esphome.io/)) + układ XMOS xCORE XU316 do zaawansowanego przetwarzania dźwięku (z autorskim firmware do odszumiania mikrofonów, poprawiającym rozpoznawanie głosu dzięki lokalnym algorytmom redukcji szumów, AEC, usuwania zakłóceń i automatycznej kontroli wzmocnienia).

Funkcjonalnie sprzęt jest zaprojektowany tak, aby był w dużej mierze zgodny z [Home Assistant Voice Preview Edition (tzn. Home Assistant Voice PE](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) jako projekt referencyjny (który został udostępniony jako open-source hardware przez Open Home Foundation we współpracy z Nabu Casa). Główna różnica wynikać będzie z ograniczeń obudowy Google Nest Mini i elementów (czyli projekt nest-mini-drop-in-pcb ograniczony będzie do tych samych typów wejść fizycznych, co oryginalny sprzęt Google).

W związku z tym zakres tego projektu/repozytorium nie obejmuje tworzenia nowych funkcji dla firmware ESPHome, więc jeśli tego oczekujesz, należy skierować się do rozwoju firmware Home Assistant Voice Preview Edition oraz głównego kodu ESPHome:

- https://github.com/esphome/home-assistant-voice-pe
  - https://github.com/esphome/esphome
      - https://github.com/esphome/feature-requests

## Prośba o współpracę

Jeśli masz doświadczenie w projektowaniu PCB (szczególnie trasowaniu, ground pouring, czy układach czułych na zakłócenia cyfrowo-analogowe), **Twoja pomoc jest bardzo mile widziana**! Zachęcamy do otwarcia nowego zgłoszenia, przesyłania sugestii/wniosków, dodawania opinii do istniejących zgłoszeń lub forka repozytorium.

Więcej informacji o idei/założeniu oraz możliwość udziału w dyskusji znajdziesz w tym wątku na forum Home Assistant:

- https://community.home-assistant.io/t/any-news-on-alternative-to-onju-voice-pcb-repacement-design-for-google-nest-home-mini-speakers-with-added-xmos-chip-to-match-official-home-assistant-voice-preview-edition-reference-hardware/860001/

### Aktualny status

- ✅ Schemat ukończony
- ✅ Rozmieszczenie elementów wykonane
- ✅ Trasowanie wykonane
- ✅ Ground pour, strategia ekranowania i rozważania EMI zakończone
- ⛔ Pierwsza partia testowa nieudana przez dwa błędy - poprawione
- ⚠️ Druga partia testowa działa częściowo
- ✅ Dodano opcję debugowania XTAG4 dla kolejnej partii

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/back_render.jpg" width="1000">

## Użyte narzędzia

- 🛠️ KiCad 9
- 🧰 SnapEDA / LCSC do pozyskiwania footprintów

## Znane specyfikacje sprzętowe

- PCB z 4 warstwami
- Goły chip ESP32-S3R8 (ESP32-S3 do WiFi, BLE i detekcji słowa budzącego na pokładzie)
- XMOS XU316-1024-QF60B-C24 (XMOS XU316 xCORE DSP do przetwarzania dźwięku)
- 16 MB SPI flash (ESP32-S3)
- 4 MB SPI flash (XMOS XU316)
- Podwójne magistrale I²S (jednoczesny wejście i wyjście dźwięku)
- TAS5805M (TAS5805MPWPR) stereofoniczny wzmacniacz klasy D z wbudowanym DSP (audio I2S, sterowanie I2C), skonfigurowany do wyjścia głośnika mono BTL
- 3x mikrofony MEMS (MMICT390200012) rozmieszczone na łuku o promieniu 34 mm - obecne oprogramowanie wykorzystuje 2 mikrofony, sprzętowo obsługuje już układ 3-mikrofonowy
- 6x diod RGB SK6812
- Niestandardowe wejście USB-C i zasilania 14V (Uwaga! USB-C i złącze beczkowe nie mogą być podłączone jednocześnie)
- MPR121 kontroler dotyku pojemnościowego (używany do obsługi dotyku zamiast natywnego czujnika dotykowego ESP32-S3)

---

> ⚠️ Programowanie przez USB-C wymaga odłączenia głównego wejścia zasilania 14V. Szczegóły na nadruku PCB.

## Odnośniki

### Zasoby Home Assistant Voice Preview Edition, w tym pliki projektowe PCB
- https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/
  - https://voice-pe.home-assistant.io/resources/
    - https://support.nabucasa.com/hc/en-us/articles/26195279589277-Home-Assistant-Voice-Preview-Edition-PCB-design-files
      - https://raw.githubusercontent.com/NabuCasa/support/refs/heads/main/static/docs/voice/home_assistant_voice_pe_schematic_v1.0_241009.pdf
     
#### Firmware ESPHome dla Home Assistant Voice PE (również używające tego samego ESP32-S3 + XMOS XU316):

- https://github.com/esphome/home-assistant-voice-pe
  - https://esphome.github.io/home-assistant-voice-pe/
- https://voice-pe.home-assistant.io/

### Układ scalony MCU XMOS xCORE DSP (XU316-1024-QF60B-C24)

- https://www.xmos.com/download/XU316-1024-QF60B-xcore.ai-Datasheet(3).pdf
- https://www.xmos.com/software-tools/
  - https://www.xmos.com/develop/xcore-voice
  - https://www.xmos.com/usb-multichannel-audio/
  - https://www.xmos.com/xcore-ai

#### Oprogramowanie układowe XMOS z projektu ESPHome dla sprzętu Home Assistant Voice Preview Edition:

- https://github.com/esphome/voice-kit-xmos-firmware
  - https://github.com/esphome/xmos_fwk_rtos
  - https://github.com/esphome/xmos_fwk_io

## Licencja

Ten projekt jest objęty licencją [CERN Open Hardware License Version 2 - Strongly Reciprocal (CERN-OHL-S v2)]
Każda zmodyfikowana wersja tego sprzętu musi być również rozpowszechniana na tej samej licencji.

☕ Jeśli chcesz wesprzeć ten projekt, możesz [postawić mi kawę na Ko-fi](https://ko-fi.com/imike78)!




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-24

---