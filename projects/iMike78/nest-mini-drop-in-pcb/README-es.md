
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

Ambos son proyectos de hardware completamente de código abierto, tomando algo de inspiración conceptual de [Onju Voice](https://github.com/justLV/onju-voice), pero con el objetivo de seguir el [estándar abierto de asistentes de voz de Open Home Foundation con Home Assistant Voice Preview Edition como referencia](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) para los diseños y especificaciones de PCB.

# Alcance del proyecto

El objetivo de este proyecto y repositorio (que es similar a [Onju Voice](https://github.com/justLV/onju-voice) pero bajo una licencia de hardware completamente abierta) es diseñar una PCB de reemplazo directo (placa de circuito impreso) con esquemas de hardware que cualquiera pueda fabricar/construir o pedir a un fabricante de PCB como una PCB personalizada para reemplazo directo de la Google Nest Mini (2ª Gen).

Esto está dirigido principalmente a personas que buscan convertir/reutilizar sus antiguos altavoces inteligentes Google Nest Mini en hardware de código abierto para [control por voz de Home Assistant](https://www.home-assistant.io/voice_control/) y/o salida de altavoz para reproductor multimedia para [Music Assistant](https://www.music-assistant.io), (aunque el hardware probablemente también podría usarse con otras aplicaciones y firmware, ya que está basado en la popular plataforma Espressif ESP32).

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_2.png" width="1000">

El diseño de hardware (de forma similar a [Home Assistant Voice Preview Edition](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)) integrará un ESP32-S3 SoC para WiFi, BLE y [detección de palabra de activación integrada](https://www.home-assistant.io/voice_control/about_wake_word/) (utilizando el firmware sin código [ESPHome](https://esphome.io/)) + un chip XMOS xCORE XU316 para procesamiento avanzado de audio (con firmware personalizado para descargar la limpieza de micrófono y mejorar las capacidades de reconocimiento de voz usando algoritmos locales de supresión de ruido, cancelación de eco acústico, cancelación de interferencias y control automático de ganancia).

En cuanto a funcionalidad, está hecho para ser mayormente compatible a nivel de hardware con el diseño de referencia [Home Assistant Voice Preview Edition (también conocido como Home Assistant Voice PE](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) (que ha sido publicado como hardware de código abierto por Open Home Foundation en colaboración con Nabu Casa). La principal diferencia se debe a las limitaciones definidas por la carcasa y componentes de Google Nest Mini, (es decir, el diseño de hardware de nest-mini-drop-in-pcb estará limitado por los mismos tipos de entradas físicas capacitivas que el hardware original de Google).

Por tanto, el alcance de este proyecto/repositorio no es desarrollar nuevas funciones/características para el firmware ESPHome, así que si deseas eso, deberás acudir al desarrollo de firmware de Home Assistant Voice Preview Edition y al código principal de ESPHome:

- https://github.com/esphome/home-assistant-voice-pe
  - https://github.com/esphome/esphome
      - https://github.com/esphome/feature-requests

## Solicitud de colaboración

Si tienes experiencia en el diseño de PCB, (especialmente en el ruteo de PCB, vertido de planos de masa o diseños digitales+analógicos sensibles al ruido), **¡tu ayuda es muy apreciada**! No dudes en abrir una nueva incidencia, enviar sugerencias/solicitudes, y añadir aportes/comentarios a incidencias existentes, o hacer un fork de este repositorio.

Para más información sobre el concepto/idea y contribuir a la discusión relacionada, también consulta este hilo en el foro de la comunidad Home Assistant:

- https://community.home-assistant.io/t/any-news-on-alternative-to-onju-voice-pcb-repacement-design-for-google-nest-home-mini-speakers-with-added-xmos-chip-to-match-official-home-assistant-voice-preview-edition-reference-hardware/860001/

### Estado actual

- ✅ Esquemático completado
- ✅ Colocación de componentes realizada
- ✅ Ruteo realizado
- ✅ Vertido de masa, estrategia de apantallamiento y consideraciones EMI completadas
- ⚠️ Primer lote de pruebas falló por dos errores - corregidos
- 🕓 esperando el segundo lote de pruebas

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/3D.png" width="1000">

## Herramientas utilizadas

- 🛠️ KiCad 9
- 🧰 SnapEDA / LCSC para obtención de huellas

## Especificaciones de hardware conocidas

- PCB de 4 capas
- Chip desnudo ESP32-S3R8 (ESP32-S3 para WiFi, BLE y detección de palabra clave integrada)
- XMOS XU316-1024-QF60B-C24 (Procesamiento de audio DSP xCORE de XMOS XU316)
- Doble memoria flash SPI (ya que ESP32 y XMOS tienen su propia flash SPI)
- Doble bus I²S (para permitir interfaces I2S al mismo tiempo, es decir, salida y entrada de audio simultáneas)
- MAX98357 para salida de altavoz (Amplificador de audio Mono Clase D I2S)
- 2x micrófonos MEMS (doble MMICT390200012 con separación intermicrófonos de 68mm)
- 6x LEDs RGB SK6812
- Entrada personalizada USB-C y de 14V (¡Atención! No se pueden conectar USB-C y conector de barril al mismo tiempo)

---

> ⚠️ La programación mediante USB-C requiere desconectar la entrada principal de alimentación de 14V. Consulte la nota en la serigrafía de la PCB para más detalles.

## Referencias

### Recursos de Home Assistant Voice Preview Edition incluyendo archivos de diseño de PCB
- https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/
  - https://voice-pe.home-assistant.io/resources/
    - https://support.nabucasa.com/hc/en-us/articles/26195279589277-Home-Assistant-Voice-Preview-Edition-PCB-design-files
      - https://raw.githubusercontent.com/NabuCasa/support/refs/heads/main/static/docs/voice/home_assistant_voice_pe_schematic_v1.0_241009.pdf
     
#### Firmware ESPHome para Home Assistant Voice PE (que también usa la misma combinación ESP32-S3 + XMOS XU316):

- https://github.com/esphome/home-assistant-voice-pe
  - https://esphome.github.io/home-assistant-voice-pe/
- https://voice-pe.home-assistant.io/

### XMOS xCORE DSP (XU316-1024-QF60B-C32) chip IC MCU

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
Cualquier versión modificada de este hardware también debe distribuirse bajo la misma licencia.

☕ Si quieres apoyar este proyecto, no dudes en [invitarme a un café en Ko-fi](https://ko-fi.com/imike78)!



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-03

---