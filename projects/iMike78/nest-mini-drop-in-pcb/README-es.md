
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

**¡Aviso!** La próxima campaña de crowdfunding para "MiciMike Home Mini Drop-In PCB" (Google Home Mini de primera generación) ya está listada en la fase de pre-lanzamiento de Crowd Supply (solo previsualización del proyecto), y si resulta exitosa se planificará una campaña equivalente para Nest Mini, así que échale un vistazo aquí:

* https://www.crowdsupply.com/micimike-rev-devices/micimike-home-mini-drop-in-pcb

Ambos son proyectos de hardware completamente open-source, que toman inspiración conceptual de [Onju Voice](https://github.com/justLV/onju-voice), pero buscan seguir el [estándar de asistentes de voz abiertos de Open Home Foundation con Home Assistant Voice Preview Edition como referencia](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) para el diseño y especificaciones de PCB.

# Alcance del proyecto

El objetivo de este proyecto y repositorio (similar a [Onju Voice](https://github.com/justLV/onju-voice) pero bajo una licencia de hardware completamente open-source) es diseñar una PCB (placa de circuito impreso) de reemplazo drop-in con esquemáticos de hardware que cualquiera pueda fabricar/armar o pedir a un fabricante de PCB como reemplazo personalizado drop-in para el Google Nest Mini (2da generación).

Este proyecto está orientado principalmente a personas que buscan convertir/reutilizar sus antiguos altavoces inteligentes Google Nest Mini en hardware open-source para [Control por voz de Home Assistant](https://www.home-assistant.io/voice_control/) y/o salida de altavoz para [Music Assistant](https://www.music-assistant.io), (aunque el hardware probablemente también pueda usarse para otras aplicaciones con otros firmware, ya que se basa en la popular plataforma Espressif ESP32).

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_2.png" width="1000">

El diseño de hardware integrará (similar a [Home Assistant Voice Preview Edition](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)) un SoC ESP32-S3 para WiFi, BLE y [detección de palabra de activación integrada](https://www.home-assistant.io/voice_control/about_wake_word/) (usando firmware sin código [ESPHome](https://esphome.io/)) + un chip XMOS xCORE XU316 para procesamiento avanzado de audio (con firmware personalizado para limpiar el micrófono, mejorando el reconocimiento de voz mediante algoritmos locales de supresión de ruido, cancelación de eco acústico, cancelación de interferencias y control automático de ganancia).

En cuanto a funcionalidad, está diseñado para ser mayormente compatible a nivel de hardware con el diseño de referencia [Home Assistant Voice Preview Edition (a.k.a. Home Assistant Voice PE](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) (que ha sido liberado como diseño de hardware open-source por Open Home Foundation en colaboración con Nabu Casa). La principal diferencia se debe a las limitaciones definidas por el encapsulado y componentes del Google Nest Mini, (es decir, el diseño de hardware del proyecto nest-mini-drop-in-pcb estará limitado por la misma capacidad física de entradas que el hardware original de Google).

Por lo tanto, el alcance de este proyecto/repositorio no es desarrollar nuevas funciones/características para el firmware ESPHome, así que si deseas eso debes dirigirte al desarrollo de firmware de Home Assistant Voice Preview Edition y también al código principal de ESPHome:

- https://github.com/esphome/home-assistant-voice-pe
  - https://github.com/esphome/esphome
      - https://github.com/esphome/feature-requests

## Solicitud de colaboración

Si tienes experiencia en diseño de layout de PCB, (especialmente en routing de PCB, vertido de tierra o layouts digitales+analógicos sensibles al ruido), **¡tu ayuda es muy apreciada**! Siéntete libre de abrir un nuevo issue, enviar sugerencias/solicitudes y añadir comentarios/retroalimentación a issues existentes o hacer un fork de este repositorio.

Para más información sobre el concepto/idea y para contribuir a la discusión relacionada, consulta también este hilo en el foro de la comunidad de Home Assistant:

- https://community.home-assistant.io/t/any-news-on-alternative-to-onju-voice-pcb-repacement-design-for-google-nest-home-mini-speakers-with-added-xmos-chip-to-match-official-home-assistant-voice-preview-edition-reference-hardware/860001/

### Estado actual

- ✅ Esquemático completado
- ✅ Colocación de componentes realizada
- ✅ Routing completado
- ✅ Vertido de tierra, estrategia de apantallamiento y consideraciones EMI realizados
- ⚠️ Primer lote de prueba falló por dos errores - corregidos
- 🕓 esperando el segundo lote de pruebas

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/3D.png" width="1000">

## Herramientas utilizadas

- 🛠️ KiCad 9
- 🧰 SnapEDA / LCSC para obtención de huellas

## Especificaciones de hardware conocidas

- PCB de 4 capas
- Chip desnudo ESP32-S3R8 (ESP32-S3 para WiFi, BLE y detección de palabra de activación a bordo)
- XMOS XU316-1024-QF60B-C24 (Procesamiento de audio DSP XMOS XU316 xCORE)
- Doble memoria SPI flash (ya que ESP32 y XMOS tienen su propia SPI flash)
- Doble bus I²S (para permitir interfaces I2S al mismo tiempo, es decir, salida y entrada de audio simultáneas)
- TAS5805M (TAS5805MPWPR) para salida de altavoz (Amplificador Mono de Audio Class-D I2S con configuración DSP vía I2C)
- 2x micrófonos MEMS (doble MMICT390200012 con 68mm de distancia entre micrófonos)
- 6x LEDs RGB SK6812
- Entrada personalizada USB-C y de 14V (¡Nota! USB-C y el conector de barril no pueden conectarse al mismo tiempo)

---

> ⚠️ El flasheo vía USB-C requiere desconectar la entrada principal de energía de 14V. Consulte la nota en la serigrafía de la PCB para más detalles.

## Referencias

### Recursos de la Edición de Vista Previa de Home Assistant Voice incluyendo archivos de diseño PCB
- https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/
  - https://voice-pe.home-assistant.io/resources/
    - https://support.nabucasa.com/hc/en-us/articles/26195279589277-Home-Assistant-Voice-Preview-Edition-PCB-design-files
      - https://raw.githubusercontent.com/NabuCasa/support/refs/heads/main/static/docs/voice/home_assistant_voice_pe_schematic_v1.0_241009.pdf
     
#### Firmware ESPHome para Home Assistant Voice PE (que también utiliza la misma combinación ESP32-S3 + XMOS XU316):

- https://github.com/esphome/home-assistant-voice-pe
  - https://esphome.github.io/home-assistant-voice-pe/
- https://voice-pe.home-assistant.io/

### Chip IC MCU XMOS xCORE DSP (XU316-1024-QF60B-C32)

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

Este proyecto está licenciado bajo la [Licencia de Hardware Abierto CERN Versión 2 - Fuertemente Recíproca (CERN-OHL-S v2)]
Cualquier versión modificada de este hardware también debe ser distribuida bajo la misma licencia.

☕ Si deseas apoyar este proyecto, siéntete libre de [invitarme a un café en Ko-fi](https://ko-fi.com/imike78)!




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-22

---