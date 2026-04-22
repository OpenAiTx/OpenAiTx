
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

**Uwaga!** Nadchodząca kampania crowdfundingowa dla "MiciMike Home Mini Drop-In PCB" (1. generacji Google Home Mini) jest już wymieniona w fazie pre-launch na Crowd Supply (tylko podgląd projektu), a jeśli odniesie sukces, planowana będzie odpowiadająca kampania dla Nest Mini, więc sprawdź tutaj:

* https://www.crowdsupply.com/micimike-rev-devices/micimike-home-mini-drop-in-pcb

Oba te projekty to w pełni otwarte sprzętowo inicjatywy, czerpiąc częściowo inspirację z [Onju Voice](https://github.com/justLV/onju-voice), lecz dążąc do zgodności ze [standardem otwartych asystentów głosowych Open Home Foundation z wydaniem Home Assistant Voice Preview Edition jako wzorem](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) dla projektów i specyfikacji PCB.

# Zakres projektu

Celem tego projektu i repozytorium (które jest podobne do [Onju Voice](https://github.com/justLV/onju-voice), lecz na w pełni otwartej licencji sprzętowej) jest zaprojektowanie wymiennej płytki PCB (Printed Circuit Board) z dokumentacją sprzętową, którą każdy może wykonać/zbudować lub zamówić u producenta PCB jako niestandardowy zamiennik dla Google Nest Mini (2. generacji).

Projekt skierowany jest głównie do osób chcących przekształcić/wykorzystać swoje stare głośniki Google Nest Mini jako otwarte rozwiązania sprzętowe dla [Sterowania głosowego Home Assistant](https://www.home-assistant.io/voice_control/) i/lub wyjścia głośnikowego dla [Music Assistant](https://www.music-assistant.io), (sprzęt można jednak prawdopodobnie używać także w innych aplikacjach z innym firmware, ponieważ oparty jest o popularną platformę Espressif ESP32).

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_2.png" width="1000">

Projekt sprzętu będzie (podobnie jak [Home Assistant Voice Preview Edition](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)) integrować ESP32-S3 SoC dla WiFi, BLE oraz [detekcji frazy budzącej na pokładzie](https://www.home-assistant.io/voice_control/about_wake_word/) (za pomocą bezkodowego [firmware ESPHome](https://esphome.io/)) + układ XMOS xCORE XU316 dla zaawansowanego przetwarzania dźwięku (z własnym firmware do czyszczenia sygnału z mikrofonów dla lepszej rozpoznawalności głosu, dzięki lokalnym algorytmom tłumienia szumów, usuwania echa, eliminacji zakłóceń i automatycznej regulacji wzmocnienia).

Funkcjonalnie projekt będzie w dużej mierze kompatybilny sprzętowo z [Home Assistant Voice Preview Edition (czyli Home Assistant Voice PE](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) jako wzorem (który został udostępniony jako otwarty projekt sprzętowy przez Open Home Foundation we współpracy z Nabu Casa). Główna różnica wynika z ograniczeń narzuconych przez obudowę i komponenty Google Nest Mini, (czyli projekt nest-mini-drop-in-pcb będzie ograniczony tymi samymi fizycznymi wejściami jak oryginalny sprzęt Google).

W związku z tym zakres tego projektu/repozytorium nie obejmuje opracowania nowych funkcji dla firmware ESPHome; jeśli tego potrzebujesz, musisz skierować się do rozwoju firmware Home Assistant Voice Preview Edition oraz do głównego kodu ESPHome:

- https://github.com/esphome/home-assistant-voice-pe
  - https://github.com/esphome/esphome
      - https://github.com/esphome/feature-requests

## Prośba o współpracę

Jeśli masz doświadczenie w projektowaniu PCB, (szczególnie w trasowaniu, ground pouring lub układach cyfrowych/analogowych wrażliwych na zakłócenia), **Twoja pomoc będzie bardzo cenna**! Zachęcamy do otwierania nowych zgłoszeń, przesyłania sugestii/wniosków, dodawania opinii do istniejących zgłoszeń lub forka repozytorium.

Więcej informacji o koncepcji/pomysle znajdziesz i możesz wnieść wkład w powiązanej dyskusji na forum społeczności Home Assistant:

- https://community.home-assistant.io/t/any-news-on-alternative-to-onju-voice-pcb-repacement-design-for-google-nest-home-mini-speakers-with-added-xmos-chip-to-match-official-home-assistant-voice-preview-edition-reference-hardware/860001/

### Aktualny status

- ✅ Schemat ukończony
- ✅ Rozmieszczenie komponentów wykonane
- ✅ Trasowanie wykonane
- ✅ Ground pour, strategia ekranowania i rozważania EMI wykonane
- ⚠️ Pierwsza testowa partia nie powiodła się z powodu dwóch błędów - naprawione
- 🕓 oczekiwanie na drugą partię testową

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/3D.png" width="1000">

## Użyte narzędzia

- 🛠️ KiCad 9
- 🧰 SnapEDA / LCSC do pozyskiwania footprintów

## Znane specyfikacje sprzętowe

- 4-warstwowa płytka PCB
- ESP32-S3R8 goły chip (ESP32-S3 dla WiFi, BLE i detekcji słowa budzącego na pokładzie)
- XMOS XU316-1024-QF60B-C24 (XMOS XU316 xCORE DSP do przetwarzania dźwięku)
- Podwójna pamięć SPI flash (ponieważ ESP32 i XMOS mają własne SPI flash)
- Podwójne magistrale I²S (umożliwiające jednoczesne interfejsy I2S, czyli równoczesny wyjście i wejście audio)
- TAS5805M (TAS5805MPWPR) do wyjścia na głośnik (I2S Class-D Mono Audio Amplifier z konfiguracją DSP przez I2C)
- 2x mikrofony MEMS (podwójne MMICT390200012 z odstępem 68 mm między mikrofonami)
- 6x diod RGB SK6812
- Niestandardowe wejście USB-C i zasilanie 14V (Uwaga! USB-C i złącze beczkowe nie mogą być podłączone jednocześnie)

---

> ⚠️ Programowanie przez USB-C wymaga odłączenia głównego zasilania 14V. Zobacz notatkę na PCB dla szczegółów.

## Odnośniki

### Zasoby Home Assistant Voice Preview Edition, w tym pliki projektowe PCB
- https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/
  - https://voice-pe.home-assistant.io/resources/
    - https://support.nabucasa.com/hc/en-us/articles/26195279589277-Home-Assistant-Voice-Preview-Edition-PCB-design-files
      - https://raw.githubusercontent.com/NabuCasa/support/refs/heads/main/static/docs/voice/home_assistant_voice_pe_schematic_v1.0_241009.pdf
     
#### Firmware ESPHome dla Home Assistant Voice PE (które używa tego samego połączenia ESP32-S3 + XMOS XU316):

- https://github.com/esphome/home-assistant-voice-pe
  - https://esphome.github.io/home-assistant-voice-pe/
- https://voice-pe.home-assistant.io/

### XMOS xCORE DSP (XU316-1024-QF60B-C32) układ MCU IC

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

Ten projekt jest licencjonowany na [CERN Open Hardware License Version 2 - Strongly Reciprocal (CERN-OHL-S v2)]
Każda zmodyfikowana wersja tego sprzętu musi być również dystrybuowana na tej samej licencji.

☕ Jeśli chcesz wesprzeć ten projekt, możesz [postawić mi kawę na Ko-fi](https://ko-fi.com/imike78)!




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-22

---