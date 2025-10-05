# MiciMike reemplazo PCB de inserción para Google Nest Mini

[MiciMike Nest Mini](https://github.com/iMike78/nest-mini-drop-in-pcb) es un reemplazo PCB de inserción para el ["Google Nest Mini" (altavoz inteligente de segunda generación de Google con puerto de carga con conector tipo barril)](https://en.wikipedia.org/wiki/Google_Nest_(smart_speakers)), pero basado en microcontroladores ESP32 y XMOS para ejecutar firmware de código abierto.

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_1.png" width="1000">

¡Consejo! Si en cambio buscas un reemplazo PCB similar para el "Google Home Mini" (hardware de altavoz inteligente de primera generación de Google con puerto de carga Micro-USB) entonces revisa el proyecto hermano en https://github.com/iMike78/home-mini-v1-drop-in-pcb

Ambos son proyectos de hardware completamente de código abierto, tomando algo de inspiración conceptual del [Onju Voice](https://github.com/justLV/onju-voice) pero con el objetivo de seguir el [estándar de asistentes de voz abiertos de Open Home Foundation con Home Assistant Voice Preview Edition como referencia](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) para diseños y especificaciones de PCB.

# Alcance del proyecto

El objetivo de este proyecto y repositorio (similar al [Onju Voice](https://github.com/justLV/onju-voice) pero bajo una licencia de hardware completamente de código abierto) es diseñar un PCB de reemplazo de inserción (placa de circuito impreso) con esquemáticos de hardware que cualquiera pueda fabricar/construir o encargar a un fabricante de PCB de una sola parada como un reemplazo personalizado para el Google Nest Mini (2da generación).

Esto está dirigido principalmente a personas que desean convertir/reutilizar sus antiguos altavoces inteligentes Google Nest Mini en hardware de código abierto para [Control de Voz de Home Assistant](https://www.home-assistant.io/voice_control/) y/o salida de altavoz para reproductor multimedia para [Music Assistant](https://www.music-assistant.io), (sin embargo, el hardware probablemente también pueda usarse con otras aplicaciones con otro firmware ya que está basado en la popular plataforma Espressif ESP32).

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_2.png" width="1000">

El diseño de hardware integrará (similar a [Home Assistant Voice Preview Edition](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)) un SoC ESP32-S3 para WiFi, BLE, y [detección de palabra de activación integrada](https://www.home-assistant.io/voice_control/about_wake_word/) (usando firmware [ESPHome](https://esphome.io/) sin código) + un chip XMOS xCORE XU316 para procesamiento avanzado de audio (con firmware personalizado para limpieza de micrófono descargando tareas para mejores capacidades de reconocimiento de voz mediante algoritmos locales para Supresión de Ruido, Cancelación de Eco Acústico, Cancelación de Interferencias y Control Automático de Ganancia).

En funcionalidad está diseñado para ser mayormente compatible en hardware con el diseño de referencia de [Home Assistant Voice Preview Edition (también conocido como Home Assistant Voice PE)](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) (que ha sido lanzado como diseño de hardware de código abierto por Open Home Foundation en colaboración con Nabu Casa). La principal diferencia será por las limitaciones definidas por la carcasa y componentes del Google Nest Mini, (es decir, el diseño de hardware del proyecto nest-mini-drop-in-pcb estará limitado por el mismo tipo de entradas físicas que el hardware original de Google).

Por ello, el alcance de este proyecto/repositorio no es desarrollar nuevas funciones/características para el firmware ESPHome, por lo que si quieres eso deberás acudir al desarrollo del firmware de Home Assistant Voice Preview Edition así como al código principal de ESPHome:

- https://github.com/esphome/home-assistant-voice-pe
  - https://github.com/esphome/esphome
      - https://github.com/esphome/feature-requests

## Solicitud de colaboración

Si tienes algo de experiencia en diseño de distribución de PCB, (y especialmente en enrutamiento de PCB, vertido de tierra o diseños digitales+analógicos sensibles al ruido), **tu ayuda es muy apreciada**. Por favor siéntete libre de abrir un nuevo issue, enviar sugerencias/solicitudes, y añadir aportes/comentarios a issues existentes, o bifurcar este repositorio.

Para más información sobre el concepto/idea y para contribuir a la discusión relacionada también revisa este hilo del foro de la comunidad Home Assistant:

- https://community.home-assistant.io/t/any-news-on-alternative-to-onju-voice-pcb-repacement-design-for-google-nest-home-mini-speakers-with-added-xmos-chip-to-match-official-home-assistant-voice-preview-edition-reference-hardware/860001/

### Estado actual

- ✅ Esquemático completado
- ✅ Colocación de componentes realizada
- ✅ El enrutamiento está hecho  
- ✅ Vertido de tierra, estrategia de blindaje y consideraciones EMI realizadas  
- ⚠️ El primer lote de prueba falló con dos errores - corregido  
- 🕓 esperando el segundo lote de prueba  

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/3D.png" width="1000">  

## Herramientas utilizadas  

- 🛠️ KiCad 9  
- 🧰 SnapEDA / LCSC para obtención de huellas  

## Especificaciones conocidas del hardware  

- PCB de 4 capas  
- Chip desnudo ESP32-S3R8 (ESP32-S3 para WiFi, BLE y detección de palabra clave a bordo)  
- XMOS XU316-1024-QF60B-C32 (procesamiento de audio DSP XMOS XU316 xCORE)  
- Memoria flash SPI dual  
- Buses I²S duales (para permitir interfaces I2S simultáneas, es decir, salida y entrada de audio simultáneas)  
- MAX98357 para salida de altavoz (Amplificador de audio mono clase D I2S)  
- 2x micrófonos MEMS (MSM261DHP)  
- LEDs SK6812  
- Entrada personalizada USB-C y alimentación de 14V  

---  

> ⚠️ Flashear vía USB-C requiere desconectar la entrada principal de alimentación de 14V. Consulte la nota en serigrafía en la PCB para detalles.  

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

### MCU IC chip DSP XMOS xCORE (XU316-1024-QF60B-C32)

- https://www.xmos.com/download/XU316-1024-QF60B-xcore.ai-Datasheet(3).pdf
- https://www.xmos.com/software-tools/
  - https://www.xmos.com/develop/xcore-voice
  - https://www.xmos.com/usb-multichannel-audio/
  - https://www.xmos.com/xcore-ai

#### Firmware XMOS del proyecto ESPHome para el hardware Home Assistant Voice Preview Edition:

- https://github.com/esphome/voice-kit-xmos-firmware
  - https://github.com/esphome/xmos_fwk_rtos
  - https://github.com/esphome/xmos_fwk_io

## Licencia

Este proyecto está licenciado bajo la [Licencia de Hardware Abierto CERN Versión 2 - Fuertemente Recíproca (CERN-OHL-S v2)]
Cualquier versión modificada de este hardware también debe ser distribuida bajo la misma licencia.

☕ Si deseas apoyar este proyecto, siéntete libre de [invitarme a un café en Ko-fi](https://ko-fi.com/imike78)!



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-05

---