# PulseQueue

Aplicación web minimalista para crear música electrónica con sintetizadores digitales.  
Inicialmente diseñada como herramienta de boceto, pero puede usarse para hacer pistas completas :musical_note::notes:

**[:link: EJECUTAR EN EL NAVEGADOR :link:](https://valent-in.github.io/pulseq)**

- Simple y fácil de usar  
- Compatible con móviles  
- Solo cliente (no se procesan datos en servidores)

- Sintetizadores sustractivos con varios efectos  
- Osciladores armónicos y FM básica  
- Secuenciador por pasos multicapa  
- Presets de sintetizador exportables  
- Exportación de audio WAV  
- Exportación MIDI

## Ejemplos musicales (YouTube)  
- [Cosmix - parte 1](https://www.youtube.com/watch?v=KkLsClq37w4)  
- [Cosmix - parte 2](https://www.youtube.com/watch?v=8_aYqIMCa2k)  
- [Clean Steps](https://www.youtube.com/watch?v=2IaCb21nIZU)

## Inicio rápido  
Para comenzar puedes experimentar con las canciones incluidas. Haz clic en el botón "Demo" en el menú de inicio y selecciona la pista de demostración. Recarga la página para volver a este menú.

**Pestañas del programa:**  
ARRANGE :cd:  
Combina patrones para formar una pista musical completa.

PATTERN :musical_keyboard:  
Coloca notas aquí. El motor de sintetizador es monofónico (una sola voz), se pueden agregar voces adicionales con capas de patrón.

SYNTH :control_knobs:  
Panel de configuración para el instrumento seleccionado. Los presets están disponibles en el menú de 3 puntos.

LIST :level_slider::level_slider:  
Contiene la lista de sintetizadores y también un mezclador.

## Tarjetas de referencia
![tarjeta de resumen](https://raw.githubusercontent.com/Valent-in/pulseq/master/refcards/refcard-overview.png)
![tarjeta de controles](https://raw.githubusercontent.com/Valent-in/pulseq/master/refcards/refcard-controls.png)
![tarjeta de enrutamiento](https://raw.githubusercontent.com/Valent-in/pulseq/master/refcards/refcard-synth.png)

## Notas de rendimiento
- Algunos efectos consumen mucho CPU (especialmente reverberación y phaser). Esto debe considerarse al usar en dispositivos móviles.  
- La duración de exportación WAV puede estar limitada en navegadores móviles a unos 10 minutos.

---
Usando Web Audio API y [Tone.js](https://github.com/Tonejs/Tone.js)  
Fuentes para exportación de archivos:  
[bufferToWave](https://github.com/rwgood18/javascript-audio-file-dynamics-compressor),  
[midi-writer](https://github.com/carter-thaxton/midi-file).

Este programa es software libre: puede redistribuirlo y/o modificarlo bajo los términos de la Licencia Pública General GNU versión 3.  
Este programa se distribuye con la esperanza de que sea útil, pero SIN NINGUNA GARANTÍA.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-17

---