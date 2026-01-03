
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

Entrambi sono progetti hardware completamente open-source, che prendono ispirazione concettuale da [Onju Voice](https://github.com/justLV/onju-voice) ma mirano a seguire lo [standard open voice assistants della Open Home Foundation con Home Assistant Voice Preview Edition come riferimento](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) per design e specifiche PCB.

# Ambito del progetto

L’obiettivo di questo progetto e repository (simile a [Onju Voice](https://github.com/justLV/onju-voice) ma con licenza hardware completamente open-source) è progettare una PCB sostitutiva (Printed Circuit Board) con schemi hardware che chiunque possa realizzare/costruire o ordinare da un produttore PCB come sostituto personalizzato per Google Nest Mini (2ª Gen).

Questo progetto è principalmente rivolto a chi desidera convertire/riutilizzare i propri vecchi smart speaker Google Nest Mini in hardware open-source per il [Controllo Vocale di Home Assistant](https://www.home-assistant.io/voice_control/) e/o come uscita speaker per [Music Assistant](https://www.music-assistant.io), (l’hardware può probabilmente essere utilizzato anche per altre applicazioni con firmware diverso, essendo basato sulla piattaforma Espressif ESP32).

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_2.png" width="1000">

Il design hardware integrerà (come la [Home Assistant Voice Preview Edition](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)) un SoC ESP32-S3 per WiFi, BLE e [rilevamento onboard wake-word](https://www.home-assistant.io/voice_control/about_wake_word/) (usando firmware [ESPHome](https://esphome.io/) senza codice) + un chip XMOS xCORE XU316 per elaborazione audio avanzata (con firmware personalizzato per pulizia microfono per migliorare il riconoscimento vocale tramite algoritmi locali di Soppressione Rumore, Cancellazione Eco Acustico, Cancellazione Interferenze e Controllo Automatico del Guadagno).

A livello funzionale è progettato per essere in gran parte hardware compatibile con il riferimento [Home Assistant Voice Preview Edition (alias Home Assistant Voice PE)](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) (rilasciato come design hardware open-source dalla Open Home Foundation in collaborazione con Nabu Casa). La principale differenza sarà dovuta ai vincoli definiti dall’involucro Google Nest Mini e dai componenti, (cioè il design hardware nest-mini-drop-in-pcb sarà limitato dagli stessi tipi di input fisici della versione originale Google).

Pertanto, l’ambito di questo progetto/repository non è sviluppare nuove funzionalità/feature per il firmware ESPHome, quindi se vuoi farlo devi rivolgerti allo sviluppo firmware della Home Assistant Voice Preview Edition e al codice mainline upstream di ESPHome:

- https://github.com/esphome/home-assistant-voice-pe
  - https://github.com/esphome/esphome
      - https://github.com/esphome/feature-requests

## Richiesta di collaborazione

Se hai esperienza nel design layout PCB (soprattutto con routing PCB, ground pour o layout digitale+analogico sensibili al rumore), **il tuo aiuto è molto apprezzato**! Sentiti libero di aprire una nuova issue, inviare suggerimenti/richieste, aggiungere input/feedback alle issue esistenti, o fare fork di questo repository.

Per maggiori informazioni sul concetto/idea consulta e contribuisci anche alla discussione correlata nel thread della community Home Assistant:

- https://community.home-assistant.io/t/any-news-on-alternative-to-onju-voice-pcb-repacement-design-for-google-nest-home-mini-speakers-with-added-xmos-chip-to-match-official-home-assistant-voice-preview-edition-reference-hardware/860001/

### Stato attuale

- ✅ Schematiche completate
- ✅ Piazzamento componenti terminato
- ✅ Routing completato
- ✅ Ground pour, strategia di schermatura e considerazioni EMI completate
- ⚠️ 1ª batch di test fallita per due errori - risolti
- 🕓 in attesa della 2ª batch di test

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/3D.png" width="1000">

## Strumenti utilizzati

- 🛠️ KiCad 9
- 🧰 SnapEDA / LCSC per la ricerca di footprint

## Specifiche hardware note

- PCB a 4 strati
- Chip nudo ESP32-S3R8 (ESP32-S3 per WiFi, BLE e rilevamento onboard della parola di attivazione)
- XMOS XU316-1024-QF60B-C24 (elaborazione audio DSP XMOS XU316 xCORE)
- Dual SPI flash (poiché ESP32 e XMOS hanno ciascuno la propria SPI flash)
- Doppio bus I²S (per consentire le interfacce I2S contemporaneamente, cioè output audio e input audio simultanei)
- MAX98357 per l’uscita altoparlante (Amplificatore audio Mono Classe D I2S)
- 2x microfoni MEMS (doppi MMICT390200012 con spaziatura tra microfoni di 68 mm)
- 6x LED RGB SK6812
- Ingresso di alimentazione personalizzato USB-C e 14V (Nota! USB-C e connettore cilindrico non possono essere collegati contemporaneamente)

---

> ⚠️ La programmazione tramite USB-C richiede la disconnessione dell’alimentazione principale a 14V. Vedi la nota serigrafata sul PCB per i dettagli.

## Riferimenti

### Risorse Home Assistant Voice Preview Edition inclusi file progetto PCB
- https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/
  - https://voice-pe.home-assistant.io/resources/
    - https://support.nabucasa.com/hc/en-us/articles/26195279589277-Home-Assistant-Voice-Preview-Edition-PCB-design-files
      - https://raw.githubusercontent.com/NabuCasa/support/refs/heads/main/static/docs/voice/home_assistant_voice_pe_schematic_v1.0_241009.pdf
     
#### Firmware ESPHome per Home Assistant Voice PE (che utilizza anche la stessa combinazione ESP32-S3 + XMOS XU316):

- https://github.com/esphome/home-assistant-voice-pe
  - https://esphome.github.io/home-assistant-voice-pe/
- https://voice-pe.home-assistant.io/

### XMOS xCORE DSP (XU316-1024-QF60B-C32) MCU IC chip

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

Questo progetto è concesso sotto la [CERN Open Hardware License Version 2 - Strongly Reciprocal (CERN-OHL-S v2)]
Qualsiasi versione modificata di questo hardware deve essere distribuita sotto la stessa licenza.

☕ Se desideri supportare questo progetto, sentiti libero di [offrirmi un caffè su Ko-fi](https://ko-fi.com/imike78)!



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-03

---