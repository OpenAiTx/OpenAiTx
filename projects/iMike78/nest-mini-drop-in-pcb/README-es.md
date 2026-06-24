
<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
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

# Reemplazo de PCB tipo drop-in MiciMike para Google Nest Mini

[MiciMike Nest Mini](https://github.com/iMike78/nest-mini-drop-in-pcb) es un reemplazo de PCB tipo drop-in para el ["Google Nest Mini" (el altavoz inteligente de segunda generación de Google con puerto de carga de conector cilíndrico)](https://es.wikipedia.org/wiki/Google_Nest_(altavoces_inteligentes)), pero basado en microcontroladores ESP32 y XMOS para ejecutar firmware de código abierto.

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_1.png" width="1000">

¡Consejo! Si en cambio buscas un reemplazo de PCB tipo drop-in similar para el "Google Home Mini" (hardware de altavoz inteligente de primera generación de Google con puerto de carga Micro-USB), entonces revisa el proyecto hermano en https://github.com/iMike78/home-mini-v1-drop-in-pcb

**¡Aviso!** Actualmente hay una campaña de financiación colectiva en curso para "MiciMike Home Mini Drop-In PCB" (placa para Google Home Mini de 1ª generación) que ya está activa en Crowd Supply en fase de preventa (solo vista previa del proyecto), y si tiene éxito se planea una campaña similar para el Nest Mini (2ª gen), así que échale un vistazo y apoya indirectamente este proyecto respaldándolo si puedes:

* https://www.crowdsupply.com/micimike-rev-devices/micimike-home-mini-drop-in-pcb

Ambos son proyectos de hardware totalmente open-source, tomando cierta inspiración conceptual del [Onju Voice](https://github.com/justLV/onju-voice) pero buscando seguir el [estándar abierto de asistentes de voz de Open Home Foundation con Home Assistant Voice Preview Edition como referencia](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) para el diseño y especificaciones de la PCB.

# Alcance del proyecto

El objetivo de este proyecto y repositorio (similar a [Onju Voice](https://github.com/justLV/onju-voice) pero bajo una licencia de hardware completamente open-source) es diseñar una PCB de reemplazo directo (placa de circuito impreso) con esquemáticos de hardware que cualquiera pueda fabricar/ensamblar o pedir a un fabricante de PCBs como una placa personalizada para el Google Nest Mini (2ª Gen).

Está principalmente dirigido a personas que buscan convertir/reutilizar sus antiguos altavoces inteligentes Google Nest Mini en hardware open-source para el [Control por voz de Home Assistant](https://www.home-assistant.io/voice_control/) y/o salida de altavoz para [Music Assistant](https://www.music-assistant.io), (aunque el hardware probablemente también pueda usarse con otras aplicaciones y firmware, ya que está basado en la popular plataforma Espressif ESP32).

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/front_render.jpg" width="1000" alt="Primera prueba de PCB">

El diseño de hardware integrará (similar a [Home Assistant Voice Preview Edition](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)) un SoC ESP32-S3 para WiFi, BLE y [detección de palabra de activación a bordo](https://www.home-assistant.io/voice_control/about_wake_word/) (usando firmware sin código [ESPHome](https://esphome.io/)) + un chip XMOS xCORE XU316 para procesamiento avanzado de audio (con firmware personalizado para limpieza de micrófono, mejorando el reconocimiento de voz mediante algoritmos locales de Supresión de Ruido, Cancelación de Eco Acústico, Cancelación de Interferencias y Control Automático de Ganancia).

En cuanto a funcionalidad, está hecho para ser mayormente compatible a nivel de hardware con el diseño de referencia de [Home Assistant Voice Preview Edition (también conocido como Home Assistant Voice PE](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) (que ha sido publicado como diseño de hardware open-source por Open Home Foundation en colaboración con Nabu Casa). La principal diferencia será debido a las limitaciones que impone la carcasa y componentes del Google Nest Mini, (es decir, el diseño de hardware de nest-mini-drop-in-pcb estará limitado por los mismos tipos de entradas de capacidad física que el hardware original de Google).

Por lo tanto, el alcance de este proyecto/repositorio no es desarrollar nuevas funciones/características para el firmware ESPHome; si buscas eso, debes dirigirte al desarrollo de firmware de Home Assistant Voice Preview Edition, así como al código principal de ESPHome:

- https://github.com/esphome/home-assistant-voice-pe
  - https://github.com/esphome/esphome
      - https://github.com/esphome/feature-requests

## Solicitud de colaboración

Si tienes experiencia en diseño de PCB, (y especialmente en rutear PCB, vertido de tierra o layouts digitales+análogos sensibles al ruido), **¡tu ayuda es muy apreciada**! Siéntete libre de abrir un nuevo issue, enviar sugerencias/peticiones y dar comentarios en los issues existentes, o bifurcar este repositorio.

Para más información sobre el concepto/idea consulta y contribuye en el hilo de discusión relacionado en el foro de la comunidad Home Assistant:

- https://community.home-assistant.io/t/any-news-on-alternative-to-onju-voice-pcb-repacement-design-for-google-nest-home-mini-speakers-with-added-xmos-chip-to-match-official-home-assistant-voice-preview-edition-reference-hardware/860001/

### Estado actual

- ✅ Esquemático completado
- ✅ Colocación de componentes terminada
- ✅ Ruteo terminado
- ✅ Vertido de tierra, estrategia de blindaje y consideraciones EMI terminadas
- ⛔ El primer lote de prueba falló por dos errores - corregidos
- ⚠️ Segundo lote de pruebas funcionando parcialmente
- ✅ Opción de depuración XTAG4 añadida para el próximo lote

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/back_render.jpg" width="1000">

## Herramientas utilizadas

- 🛠️ KiCad 9
- 🧰 SnapEDA / LCSC para obtención de huellas

## Especificaciones de hardware conocidas

- PCB de 4 capas
- Chip desnudo ESP32-S3R8 (ESP32-S3 para WiFi, BLE y detección de palabra clave integrada)
- XMOS XU316-1024-QF60B-C24 (procesamiento de audio DSP XMOS XU316 xCORE)
- 16 MB SPI flash (ESP32-S3)
- 4 MB SPI flash (XMOS XU316)
- Buses I²S duales (entrada y salida de audio simultáneas)
- TAS5805M (TAS5805MPWPR) amplificador estéreo Clase D con DSP integrado (audio I2S, control I2C), configurado para salida de altavoz mono BTL
- 3x micrófonos MEMS (MMICT390200012) dispuestos en un arco de radio de 34 mm - el firmware actual usa 2 micrófonos, soporte de hardware para una matriz de 3 micrófonos ya presente
- 6x LEDs RGB SK6812
- Entrada personalizada USB-C y de 14V (¡Nota! USB-C y conector de barril no pueden conectarse al mismo tiempo)
- Controlador táctil capacitivo MPR121 (usado para entrada táctil en lugar de la detección táctil nativa del ESP32-S3)

---

> ⚠️ La grabación por USB-C requiere desconectar la entrada principal de 14V. Consulte la nota de serigrafía en la PCB para más detalles.

## Referencias

### Recursos de Home Assistant Voice Preview Edition incluyendo archivos de diseño PCB
- https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/
  - https://voice-pe.home-assistant.io/resources/
    - https://support.nabucasa.com/hc/en-us/articles/26195279589277-Home-Assistant-Voice-Preview-Edition-PCB-design-files
      - https://raw.githubusercontent.com/NabuCasa/support/refs/heads/main/static/docs/voice/home_assistant_voice_pe_schematic_v1.0_241009.pdf
     
#### Firmware ESPHome para Home Assistant Voice PE (que también usa la misma combinación ESP32-S3 + XMOS XU316):

- https://github.com/esphome/home-assistant-voice-pe
  - https://esphome.github.io/home-assistant-voice-pe/
- https://voice-pe.home-assistant.io/

### XMOS xCORE DSP (XU316-1024-QF60B-C24) MCU IC chip

- https://www.xmos.com/download/XU316-1024-QF60B-xcore.ai-Datasheet(3).pdf
- https://www.xmos.com/software-tools/
  - https://www.xmos.com/develop/xcore-voice
  - https://www.xmos.com/usb-multichannel-audio/
  - https://www.xmos.com/xcore-ai
 
#### Firmware de XMOS del proyecto ESPHome para el hardware Home Assistant Voice Preview Edition:

- https://github.com/esphome/voice-kit-xmos-firmware
  - https://github.com/esphome/xmos_fwk_rtos
  - https://github.com/esphome/xmos_fwk_io

## Licencia

Este proyecto está licenciado bajo la [CERN Open Hardware License Version 2 - Strongly Reciprocal (CERN-OHL-S v2)]
Cualquier versión modificada de este hardware también debe ser distribuida bajo la misma licencia.

☕ Si deseas apoyar este proyecto, siéntete libre de [invitarme a un café en Ko-fi](https://ko-fi.com/imike78)!




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-24

---