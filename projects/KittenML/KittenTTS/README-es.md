# Kitten TTS 😻

Kitten TTS es un modelo de texto a voz realista de código abierto con solo 15 millones de parámetros, diseñado para un despliegue ligero y una síntesis de voz de alta calidad.

*Actualmente en vista previa para desarrolladores*

[Únete a nuestro discord](https://discord.gg/upcyF5s6)


## ✨ Características

- **Ultra ligero**: Tamaño del modelo menor a 25MB
- **Optimizado para CPU**: Funciona sin GPU en cualquier dispositivo
- **Voces de alta calidad**: Varias opciones de voz premium disponibles
- **Inferencia rápida**: Optimizado para síntesis de voz en tiempo real



## 🚀 Inicio rápido

### Instalación

```
pip install https://github.com/KittenML/KittenTTS/releases/download/0.1/kittentts-0.1.0-py3-none-any.whl
```



 ### Basic Usage 

```
from kittentts import KittenTTS
m = KittenTTS("KittenML/kitten-tts-nano-0.1")

audio = m.generate("This high quality TTS model works without a GPU", voice='expr-voice-2-f' )

# available_voices : [  'expr-voice-2-m', 'expr-voice-2-f', 'expr-voice-3-m', 'expr-voice-3-f',  'expr-voice-4-m', 'expr-voice-4-f', 'expr-voice-5-m', 'expr-voice-5-f' ]

# Save the audio
import soundfile as sf
sf.write('output.wav', audio, 24000)

```
## 💻 Requisitos del sistema

Funciona literalmente en todas partes



## Lista de verificación 

- [x] Lanzar un modelo de vista previa
- [ ] Lanzar los pesos del modelo completamente entrenado
- [ ] Lanzar SDK para móviles 
- [ ] Lanzar versión web 








---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-09

---