
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

**Attenzione!** Attualmente è in corso una campagna di crowdfunding per la "MiciMike Home Mini Drop-In PCB" (Google Home Mini di 1a generazione) che è ora attiva su Crowd Supply in fase di pre-vendita (solo anteprima progetto), e se avrà successo si pianificherà una campagna analoga per la nuova Nest Mini (2a generazione), quindi dai un'occhiata qui e supporta indirettamente questo progetto contribuendo se puoi:

* https://www.crowdsupply.com/micimike-rev-devices/micimike-home-mini-drop-in-pcb

Entrambi questi sono progetti hardware completamente open-source, prendendo ispirazione concettuale da [Onju Voice](https://github.com/justLV/onju-voice) ma mirando a seguire [lo standard degli assistenti vocali open di Open Home Foundation con Home Assistant Voice Preview Edition come riferimento](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) per progetti e specifiche PCB.

# Ambito del progetto

L'obiettivo di questo progetto e repository (simile a [Onju Voice](https://github.com/justLV/onju-voice) ma sotto licenza hardware totalmente open-source) è progettare un PCB (Printed Circuit Board) sostitutivo drop-in con schemi hardware che chiunque possa realizzare/costruire o ordinare da un produttore PCB come drop-in custom per Google Nest Mini (2a Gen).

Questo è principalmente rivolto a chi desidera convertire/riutilizzare i propri vecchi smart speaker Google Nest Mini in hardware open-source per [Controllo vocale di Home Assistant](https://www.home-assistant.io/voice_control/) e/o uscita audio per speaker media player per [Music Assistant](https://www.music-assistant.io), (tuttavia l'hardware può probabilmente essere usato anche con altre applicazioni e firmware, poiché è basato sulla popolare piattaforma Espressif ESP32).

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/front_render.jpg" width="1000" alt="First test PCB">

Il design hardware integrerà (similmente a [Home Assistant Voice Preview Edition](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)) un SoC ESP32-S3 per WiFi, BLE e [rilevamento wake-word integrato](https://www.home-assistant.io/voice_control/about_wake_word/) (usando il firmware [ESPHome](https://esphome.io/) senza codice) + un chip XMOS xCORE XU316 per l'elaborazione audio avanzata (con firmware personalizzato per scarico pulizia microfono per migliorare il riconoscimento vocale tramite algoritmi locali di Soppressione Rumore, Cancellazione Eco Acustico, Cancellazione Interferenze e Controllo Automatico del Guadagno).

A livello di funzionalità è progettato per essere ampiamente compatibile a livello hardware con il [Home Assistant Voice Preview Edition (detto anche Home Assistant Voice PE](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) design di riferimento (rilasciato come hardware open-source da Open Home Foundation in collaborazione con Nabu Casa). La differenza principale sarà data dai vincoli imposti dal case e componenti del Google Nest Mini, (cioè il progetto nest-mini-drop-in-pcb sarà limitato dalle stesse tipologie di ingressi fisici di capacità dell'hardware originale Google).

Pertanto, lo scopo di questo progetto/repository non è sviluppare nuove funzioni per il firmware ESPHome; se desideri questo devi invece rivolgerti allo sviluppo firmware di Home Assistant Voice Preview Edition e al codice upstream ESPHome mainline:

- https://github.com/esphome/home-assistant-voice-pe
  - https://github.com/esphome/esphome
      - https://github.com/esphome/feature-requests

## Richiesta di collaborazione

Se hai esperienza nella progettazione layout PCB, (e in particolare nel routing PCB, ground pouring, o layout digitali+analogici sensibili al rumore), **il tuo aiuto è molto apprezzato**! Sentiti libero di aprire una nuova issue, inviare suggerimenti/richieste, aggiungere input/feedback alle issue esistenti, o fare fork di questo repository.

Per maggiori informazioni sul concetto/idea vedi e contribuisci anche a questa discussione nel forum della community Home Assistant:

- https://community.home-assistant.io/t/any-news-on-alternative-to-onju-voice-pcb-repacement-design-for-google-nest-home-mini-speakers-with-added-xmos-chip-to-match-official-home-assistant-voice-preview-edition-reference-hardware/860001/

### Stato attuale

- ✅ Schema completato
- ✅ Posizionamento componenti fatto
- ✅ Routing completato
- ✅ Ground pour, strategia di schermatura e considerazioni EMI completate
- ⛔ Primo lotto di test fallito su due errori - corretto
- ⚠️ Il secondo lotto di test funziona parzialmente
- ✅ Opzione di debug XTAG4 aggiunta per il prossimo lotto

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/back_render.jpg" width="1000">

## Strumenti utilizzati

- 🛠️ KiCad 9
- 🧰 SnapEDA / LCSC per la ricerca dei footprint

## Specifiche hardware note

- PCB a 4 strati
- Chip nudo ESP32-S3R8 (ESP32-S3 per WiFi, BLE e rilevamento onboard della wake-word)
- XMOS XU316-1024-QF60B-C24 (XMOS XU316 xCORE DSP per l'elaborazione audio)
- Flash SPI da 16 MB (ESP32-S3)
- Flash SPI da 4 MB (XMOS XU316)
- Doppio bus I²S (input e output audio simultanei)
- TAS5805M (TAS5805MPWPR) amplificatore stereo Class-D con DSP integrato (audio I2S, controllo I2C), configurato per uscita speaker mono BTL
- 3x microfoni MEMS (MMICT390200012) disposti su un arco di raggio 34 mm - il firmware attuale usa 2 microfoni, il supporto hardware per un array a 3 microfoni è già presente
- 6x LED RGB SK6812
- Ingresso di alimentazione USB-C e 14V personalizzato (Nota! USB-C e connettore a barile non possono essere collegati contemporaneamente)
- Controller touch capacitivo MPR121 (utilizzato per input touch invece del rilevamento touch nativo ESP32-S3)

---

> ⚠️ La programmazione tramite USB-C richiede la disconnessione dell'ingresso di alimentazione principale da 14V. Vedi la nota sulla serigrafia del PCB per i dettagli.

## Riferimenti

### Risorse Home Assistant Voice Preview Edition inclusi i file di progettazione PCB
- https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/
  - https://voice-pe.home-assistant.io/resources/
    - https://support.nabucasa.com/hc/en-us/articles/26195279589277-Home-Assistant-Voice-Preview-Edition-PCB-design-files
      - https://raw.githubusercontent.com/NabuCasa/support/refs/heads/main/static/docs/voice/home_assistant_voice_pe_schematic_v1.0_241009.pdf
     
#### Firmware ESPHome per Home Assistant Voice PE (che utilizza anche la stessa combinazione ESP32-S3 + XMOS XU316):

- https://github.com/esphome/home-assistant-voice-pe
  - https://esphome.github.io/home-assistant-voice-pe/
- https://voice-pe.home-assistant.io/

### MCU IC chip XMOS xCORE DSP (XU316-1024-QF60B-C24)

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
Qualsiasi versione modificata di questo hardware deve essere distribuita sotto la stessa licenza.

☕ Se vuoi supportare questo progetto, sentiti libero di [offrirmi un caffè su Ko-fi](https://ko-fi.com/imike78)!




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-24

---