
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
Oba te projekty są w pełni otwartymi projektami sprzętowymi, czerpiącymi pewną inspirację koncepcyjną z [Onju Voice](https://github.com/justLV/onju-voice), jednak mającymi na celu podążanie za [standardem otwartych asystentów głosowych Open Home Foundation z edycją Home Assistant Voice Preview jako referencją](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) dla projektów i specyfikacji PCB.

# Zakres projektu

Celem tego projektu i repozytorium (które jest podobne do [Onju Voice](https://github.com/justLV/onju-voice), ale objęte w pełni otwartą licencją sprzętową) jest zaprojektowanie PCB (Płytki Drukowanej) typu drop-in replacement z dokumentacją sprzętową, którą każdy może wykonać/zbudować lub zamówić u dowolnego producenta PCB jako dedykowany zamiennik PCB do Google Nest Mini (2. generacji).

Projekt skierowany jest głównie do osób chcących przekształcić/przeznaczyć swoje stare inteligentne głośniki Google Nest Mini na otwarty sprzęt do [Sterowania Głosem w Home Assistant](https://www.home-assistant.io/voice_control/) i/lub jako wyjście głośnika do odtwarzacza [Music Assistant](https://www.music-assistant.io), (sprzęt może być jednak używany również z innymi aplikacjami i firmware, ponieważ oparty jest na popularnej platformie Espressif ESP32).

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_2.png" width="1000">

Projekt sprzętowy (podobnie jak [Home Assistant Voice Preview Edition](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)) będzie integrował układ ESP32-S3 SoC dla WiFi, BLE oraz [lokalnej detekcji frazy budzącej](https://www.home-assistant.io/voice_control/about_wake_word/) (przy użyciu firmware bez kodu [ESPHome](https://esphome.io/)) + układ XMOS xCORE XU316 dla zaawansowanego przetwarzania dźwięku (z dedykowanym firmware do odciążenia mikrofonu dla lepszego rozpoznawania mowy, dzięki lokalnym algorytmom dla Tłumienia Szumów, Akustycznej Redukcji Echa, Eliminacji Zakłóceń oraz Automatycznej Regulacji Wzmocnienia).

Funkcjonalnie sprzęt będzie w większości kompatybilny z [Home Assistant Voice Preview Edition (czyli Home Assistant Voice PE](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) jako projekt referencyjny (który został udostępniony jako otwarty sprzęt przez Open Home Foundation we współpracy z Nabu Casa). Główna różnica wynikać będzie z ograniczeń narzuconych przez obudowę i komponenty Google Nest Mini, (czyli projekt nest-mini-drop-in-pcb będzie ograniczony do takich samych typów fizycznych wejść jak oryginalny sprzęt Google).

W związku z tym zakres tego projektu/repozytorium nie obejmuje rozwoju nowych funkcji dla firmware ESPHome, więc jeśli to Cię interesuje, należy zwrócić się do zespołu firmware Home Assistant Voice Preview Edition oraz do głównego kodu ESPHome:

- https://github.com/esphome/home-assistant-voice-pe
  - https://github.com/esphome/esphome
      - https://github.com/esphome/feature-requests

## Prośba o współpracę

Jeśli masz doświadczenie w projektowaniu układów PCB (szczególnie w trasowaniu ścieżek, wylewaniu masy, lub projektowaniu układów cyfrowo-analogowych wrażliwych na zakłócenia), **Twoja pomoc będzie bardzo cenna**! Zachęcamy do otwarcia nowego zgłoszenia, przesyłania sugestii/uwag oraz dodawania opinii do istniejących zgłoszeń lub forka repozytorium.

Więcej informacji o koncepcji/pomysłach znajdziesz i możesz dołożyć swój wkład w powiązanej dyskusji na forum społeczności Home Assistant:

- https://community.home-assistant.io/t/any-news-on-alternative-to-onju-voice-pcb-repacement-design-for-google-nest-home-mini-speakers-with-added-xmos-chip-to-match-official-home-assistant-voice-preview-edition-reference-hardware/860001/

### Aktualny status

- ✅ Schemat ukończony
- ✅ Rozmieszczenie komponentów wykonane
- ✅ Trasowanie ścieżek wykonane
- ✅ Wylanie masy, strategia ekranowania i rozważenia EMI zrobione
- ⚠️ Pierwsza partia testowa nieudana przez dwa błędy - poprawione
- 🕓 oczekiwanie na drugą partię testową

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/3D.png" width="1000">


## Użyte narzędzia

- 🛠️ KiCad 9
- 🧰 SnapEDA / LCSC do pozyskiwania footprintów

## Znane specyfikacje sprzętowe

- PCB o 4 warstwach
- Goły chip ESP32-S3R8 (ESP32-S3 do WiFi, BLE i wbudowanego wykrywania słowa budzącego)
- XMOS XU316-1024-QF60B-C24 (XMOS XU316 xCORE DSP do przetwarzania dźwięku)
- Podwójna pamięć SPI flash (ESP32 i XMOS mają własne SPI flash)
- Podwójne magistrale I²S (aby umożliwić jednoczesne interfejsy I2S, tj. równoczesne wyjście i wejście audio)
- MAX98357 do wyjścia głośnikowego (I2S Klasa-D Mono Wzmacniacz Audio)
- 2x mikrofony MEMS (podwójny MMICT390200012 z rozstawem 68mm między mikrofonami)
- 6x diod RGB SK6812
- Niestandardowe wejście USB-C oraz zasilanie 14V (Uwaga! USB-C i złącze beczkowe nie mogą być podłączone jednocześnie)

---

> ⚠️ Programowanie przez USB-C wymaga odłączenia głównego zasilania 14V. Szczegóły na notatce silk-screen na PCB.

## Odnośniki

### Zasoby Home Assistant Voice Preview Edition, w tym pliki projektu PCB
- https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/
  - https://voice-pe.home-assistant.io/resources/
    - https://support.nabucasa.com/hc/en-us/articles/26195279589277-Home-Assistant-Voice-Preview-Edition-PCB-design-files
      - https://raw.githubusercontent.com/NabuCasa/support/refs/heads/main/static/docs/voice/home_assistant_voice_pe_schematic_v1.0_241009.pdf
     
#### Firmware ESPHome dla Home Assistant Voice PE (również używa kombinacji ESP32-S3 + XMOS XU316):

- https://github.com/esphome/home-assistant-voice-pe
  - https://esphome.github.io/home-assistant-voice-pe/
- https://voice-pe.home-assistant.io/

### XMOS xCORE DSP (XU316-1024-QF60B-C32) MCU IC chip

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
Każda zmodyfikowana wersja tego sprzętu musi być również rozpowszechniana na tej samej licencji.

☕ Jeśli chcesz wesprzeć ten projekt, możesz [postawić mi kawę na Ko-fi](https://ko-fi.com/imike78)!



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-03

---