
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

# Sostituzione PCB MiciMike drop-in per Google Nest Mini

[MiciMike Nest Mini](https://github.com/iMike78/nest-mini-drop-in-pcb) è una scheda PCB sostitutiva drop-in per il ["Google Nest Mini" (il secondo smart speaker di Google con connettore di ricarica a barile)](https://it.wikipedia.org/wiki/Google_Nest_(smart_speakers)), ma basata su microcontrollori ESP32 e XMOS per l’esecuzione di firmware open-source.

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_1.png" width="1000">

Consiglio! Se invece stai cercando una scheda PCB sostitutiva drop-in simile per il "Google Home Mini" (hardware della prima generazione di smart speaker Google con porta di ricarica Micro-USB) dai un’occhiata al progetto correlato su https://github.com/iMike78/home-mini-v1-drop-in-pcb

Entrambi sono progetti hardware completamente open-source, che traggono ispirazione concettuale da [Onju Voice](https://github.com/justLV/onju-voice) ma con l'obiettivo di seguire lo [standard degli assistenti vocali open della Open Home Foundation con Home Assistant Voice Preview Edition come riferimento](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) per i design e le specifiche delle PCB.

# Scopo del progetto

L'obiettivo di questo progetto e repository (simile a [Onju Voice](https://github.com/justLV/onju-voice) ma sotto una licenza hardware completamente open-source) è progettare una PCB sostitutiva (Printed Circuit Board) con schemi hardware che chiunque possa realizzare/costruire o ordinare da un produttore PCB come sostituto personalizzato per Google Nest Mini (2a gen).

Questo è principalmente rivolto a chi vuole convertire/riutilizzare i propri vecchi smart speaker Google Nest Mini in hardware open-source per il [Controllo vocale di Home Assistant](https://www.home-assistant.io/voice_control/) e/o come speaker per output multimediale per [Music Assistant](https://www.music-assistant.io), (l’hardware probabilmente può essere utilizzato anche con altre applicazioni e firmware, essendo basato sulla popolare piattaforma Espressif ESP32).

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_2.png" width="1000">

Il design hardware integrerà (similmente a [Home Assistant Voice Preview Edition](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)) un ESP32-S3 SoC per WiFi, BLE e [rilevamento wake-word integrato](https://www.home-assistant.io/voice_control/about_wake_word/) (usando firmware [ESPHome](https://esphome.io/) senza codice) + un chip XMOS xCORE XU316 per l’elaborazione audio avanzata (con firmware personalizzato per l’elaborazione del microfono, migliorando il riconoscimento vocale grazie ad algoritmi locali per Soppressione del Rumore, Cancellazione dell’Eco Acustico, Cancellazione delle Interferenze e Controllo Automatico del Guadagno).

A livello di funzionalità è progettato per essere hardware compatibile principalmente con il design di riferimento [Home Assistant Voice Preview Edition (Home Assistant Voice PE)](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) (rilasciato come hardware open-source dalla Open Home Foundation in collaborazione con Nabu Casa). La differenza principale sarà dovuta ai vincoli imposti dall’involucro e dai componenti del Google Nest Mini, (cioè il design hardware nest-mini-drop-in-pcb sarà limitato dagli stessi input fisici della versione originale di Google).

Pertanto lo scopo di questo progetto/repository non è sviluppare nuove funzionalità/feature per il firmware ESPHome, quindi se desideri farlo ti consigliamo di contribuire allo sviluppo firmware della Home Assistant Voice Preview Edition e al codice principale upstream di ESPHome:

- https://github.com/esphome/home-assistant-voice-pe
  - https://github.com/esphome/esphome
      - https://github.com/esphome/feature-requests

## Richiesta di collaborazione

Se hai esperienza con il design di PCB, (in particolare con routing, ground pouring, o layout digitali+analogici sensibili al rumore), **il tuo aiuto è molto apprezzato**! Sentiti libero di aprire una nuova issue, inviare suggerimenti/richieste, aggiungere input/feedback alle issue esistenti, o fare fork di questo repository.

Per maggiori informazioni sul concetto/idea, consulta e contribuisci anche a questa discussione nel forum della community Home Assistant:

- https://community.home-assistant.io/t/any-news-on-alternative-to-onju-voice-pcb-repacement-design-for-google-nest-home-mini-speakers-with-added-xmos-chip-to-match-official-home-assistant-voice-preview-edition-reference-hardware/860001/

### Stato attuale

- ✅ Schema completato
- ✅ Posizionamento dei componenti eseguito
- ✅ Routing completato
- ✅ Ground pour, strategia di schermatura e considerazioni EMI completate
- ⚠️ 1° lotto di test fallito su due errori - risolti
- 🕓 in attesa del 2° lotto di test

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/3D.png" width="1000">

## Strumenti utilizzati

- 🛠️ KiCad 9
- 🧰 SnapEDA / LCSC per la ricerca dei footprint

## Specifiche hardware conosciute

- PCB a 4 strati
- Chip nudo ESP32-S3R8 (ESP32-S3 per WiFi, BLE e rilevamento onboard della parola di attivazione)
- XMOS XU316-1024-QF60B-C32 (XMOS XU316 xCORE DSP per l'elaborazione audio)
- Dual SPI flash
- Doppio bus I²S (per consentire interfacce I2S simultanee, ovvero uscita audio e ingresso audio contemporanei)
- MAX98357 per uscita speaker (Amplificatore Audio Mono I2S Classe-D)
- 2x microfoni MEMS (MSM261DHP)
- LED SK6812
- Ingresso custom USB-C e alimentazione 14V

---

> ⚠️ La programmazione via USB-C richiede la disconnessione dell'alimentazione principale a 14V. Vedi la nota serigrafica sul PCB per i dettagli.

## Riferimenti

### Risorse Home Assistant Voice Preview Edition inclusi file di progettazione PCB
- https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/
  - https://voice-pe.home-assistant.io/resources/
    - https://support.nabucasa.com/hc/it/articles/26195279589277-Home-Assistant-Voice-Preview-Edition-PCB-design-files
      - https://raw.githubusercontent.com/NabuCasa/support/refs/heads/main/static/docs/voice/home_assistant_voice_pe_schematic_v1.0_241009.pdf
     
#### Firmware ESPHome per Home Assistant Voice PE (che utilizza la stessa combinazione ESP32-S3 + XMOS XU316):

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

Questo progetto è distribuito sotto la [CERN Open Hardware License Version 2 - Strongly Reciprocal (CERN-OHL-S v2)]
Qualsiasi versione modificata di questo hardware deve essere distribuita con la stessa licenza.

☕ Se vuoi supportare questo progetto, sentiti libero di [offrirmi un caffè su Ko-fi](https://ko-fi.com/imike78)!



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-06

---