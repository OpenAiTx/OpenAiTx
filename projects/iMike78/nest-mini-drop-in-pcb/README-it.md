
<div align="right">
  <details>
    <summary >🌐 Lingua</summary>
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

# MiciMike PCB sostitutiva drop-in per Google Nest Mini

[MiciMike Nest Mini](https://github.com/iMike78/nest-mini-drop-in-pcb) è una PCB sostitutiva drop-in per il ["Google Nest Mini" (lo smart speaker di seconda generazione di Google con connettore di alimentazione a barilotto)](https://it.wikipedia.org/wiki/Google_Nest_(smart_speakers)), ma basata su microcontrollori ESP32 e XMOS per eseguire firmware open-source.

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_1.png" width="1000">

Suggerimento! Se invece stai cercando una PCB sostitutiva drop-in simile per il "Google Home Mini" (hardware dello smart speaker di prima generazione di Google con porta di ricarica Micro-USB) dai un'occhiata al progetto gemello su https://github.com/iMike78/home-mini-v1-drop-in-pcb

**Attenzione!** Prossima campagna di crowdfunding per "MiciMike Home Mini Drop-In PCB" (Google Home Mini di prima generazione) ora elencata nella fase di pre-lancio su Crowd Supply (solo anteprima del progetto), e se avrà successo sarà pianificata una campagna corrispondente per Nest Mini, quindi dai un'occhiata qui:

* https://www.crowdsupply.com/micimike-rev-devices/micimike-home-mini-drop-in-pcb

Entrambi questi sono progetti hardware completamente open-source, che prendono ispirazione concettuale da [Onju Voice](https://github.com/justLV/onju-voice) ma mirano a seguire [lo standard open degli assistenti vocali della Open Home Foundation con Home Assistant Voice Preview Edition come riferimento](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) per i progetti e le specifiche PCB.

# Ambito del progetto

L'obiettivo di questo progetto e repository (simile a [Onju Voice](https://github.com/justLV/onju-voice) ma sotto una licenza hardware completamente open-source) è progettare un PCB (Printed Circuit Board) sostitutivo plug-and-play con schemi hardware che chiunque può realizzare/costruire o ordinare da un produttore PCB tutto-in-uno come PCB personalizzato sostitutivo per Google Nest Mini (2a generazione).

Questo è principalmente rivolto a chi vuole convertire/riutilizzare i vecchi smart speaker Google Nest Mini in hardware open-source per [Controllo vocale di Home Assistant](https://www.home-assistant.io/voice_control/) e/o uscita audio per [Music Assistant](https://www.music-assistant.io), (l'hardware può probabilmente essere usato anche con altre applicazioni e firmware poiché si basa sulla diffusa piattaforma Espressif ESP32).

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_2.png" width="1000">

Il progetto hardware integrerà (similmente alla [Home Assistant Voice Preview Edition](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)) un ESP32-S3 SoC per WiFi, BLE e [rilevamento onboard della parola chiave](https://www.home-assistant.io/voice_control/about_wake_word/) (usando firmware [ESPHome senza codice](https://esphome.io/)) + un chip XMOS xCORE XU316 per elaborazione audio avanzata (con firmware personalizzato per pulizia microfono offloading per migliori capacità di riconoscimento vocale usando algoritmi locali per Soppressione Rumore, Cancellazione Eco Acustica, Cancellazione Interferenze e Controllo Automatico del Guadagno).

A livello funzionale è realizzato per essere principalmente hardware compatibile con il [Home Assistant Voice Preview Edition (a.k.a. Home Assistant Voice PE](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) design di riferimento (rilasciato come progetto hardware open-source dalla Open Home Foundation in collaborazione con Nabu Casa). La principale differenza sarà dovuta ai vincoli definiti dall'involucro e dai componenti del Google Nest Mini, (cioè il progetto nest-mini-drop-in-pcb sarà limitato dagli stessi input di capacità fisica dell'hardware originale di Google).

Pertanto l'ambito di questo progetto/repository non è sviluppare nuove funzionalità/feature per il firmware ESPHome, quindi se vuoi questo devi invece rivolgerti allo sviluppo firmware della Home Assistant Voice Preview Edition e anche al codice principale upstream ESPHome:

- https://github.com/esphome/home-assistant-voice-pe
  - https://github.com/esphome/esphome
      - https://github.com/esphome/feature-requests

## Richiesta di collaborazione

Se hai esperienza nel design layout PCB, (e specialmente con routing PCB, ground pouring, o layout digitali+analogici sensibili al rumore), **il tuo aiuto è molto apprezzato**! Sentiti libero di aprire una nuova issue, inviare suggerimenti/richieste e aggiungere input/feedback alle issue esistenti, oppure forkare questo repository.

Per maggiori informazioni sul concetto/idea vedi e contribuisci alla discussione correlata nel thread del forum della comunità Home Assistant:

- https://community.home-assistant.io/t/any-news-on-alternative-to-onju-voice-pcb-repacement-design-for-google-nest-home-mini-speakers-with-added-xmos-chip-to-match-official-home-assistant-voice-preview-edition-reference-hardware/860001/

### Stato attuale

- ✅ Schema completato
- ✅ Posizionamento componenti fatto
- ✅ Routing completato
- ✅ Ground pour, strategia schermatura e considerazioni EMI completate
- ⚠️ Primo batch di test fallito su due errori - risolti
- 🕓 in attesa del secondo lotto di test

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/3D.png" width="1000">

## Strumenti utilizzati

- 🛠️ KiCad 9
- 🧰 SnapEDA / LCSC per la ricerca di footprint

## Specifiche hardware note

- PCB a 4 strati
- ESP32-S3R8 chip nudo (ESP32-S3 per WiFi, BLE e rilevamento wake-word a bordo)
- XMOS XU316-1024-QF60B-C24 (XMOS XU316 xCORE DSP per elaborazione audio)
- Doppio SPI flash (poiché ESP32 e XMOS hanno ciascuno la propria SPI flash)
- Doppio bus I²S (per consentire interfacce I2S simultanee, cioè uscita e ingresso audio contemporanei)
- TAS5805M (TAS5805MPWPR) per uscita altoparlante (Amplificatore audio Mono I2S Classe D con configurazione DSP via I2C)
- 2x microfoni MEMS (doppio MMICT390200012 con distanza inter-microfono di 68mm)
- 6x LED RGB SK6812
- Ingresso di alimentazione personalizzato USB-C e 14V (Nota! USB-C e connettore a barilotto non possono essere collegati contemporaneamente)

---

> ⚠️ Il flashing tramite USB-C richiede la disconnessione dell'alimentazione principale a 14V. Consultare la nota serigrafica sul PCB per dettagli.

## Riferimenti

### Risorse Home Assistant Voice Preview Edition inclusi file di progetto PCB
- https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/
  - https://voice-pe.home-assistant.io/resources/
    - https://support.nabucasa.com/hc/it/articles/26195279589277-Home-Assistant-Voice-Preview-Edition-PCB-design-files
      - https://raw.githubusercontent.com/NabuCasa/support/refs/heads/main/static/docs/voice/home_assistant_voice_pe_schematic_v1.0_241009.pdf
     
#### Firmware ESPHome per Home Assistant Voice PE (che utilizza anche la stessa combinazione ESP32-S3 + XMOS XU316):

- https://github.com/esphome/home-assistant-voice-pe
  - https://esphome.github.io/home-assistant-voice-pe/
- https://voice-pe.home-assistant.io/

### XMOS xCORE DSP (XU316-1024-QF60B-C32) chip IC MCU

- https://www.xmos.com/download/XU316-1024-QF60B-xcore.ai-Datasheet(3).pdf
- https://www.xmos.com/software-tools/
  - https://www.xmos.com/develop/xcore-voice
  - https://www.xmos.com/usb-multichannel-audio/
  - https://www.xmos.com/xcore-ai
 
#### Firmware XMOS dal progetto ESPHome per l'hardware Home Assistant Voice Preview Edition:

- https://github.com/esphome/voice-kit-xmos-firmware
  - https://github.com/esphome/xmos_fwk_rtos
  - https://github.com/esphome/xmos_fwk_io

## Licenza

Questo progetto è concesso in licenza secondo la [CERN Open Hardware License Version 2 - Strongly Reciprocal (CERN-OHL-S v2)]
Qualsiasi versione modificata di questo hardware deve essere distribuita anche sotto la stessa licenza.

☕ Se vuoi supportare questo progetto, sentiti libero di [offrirmi un caffè su Ko-fi](https://ko-fi.com/imike78)!




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-22

---