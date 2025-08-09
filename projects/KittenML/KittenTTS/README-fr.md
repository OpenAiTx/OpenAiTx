# Kitten TTS 😻

Kitten TTS est un modèle open-source de synthèse vocale réaliste avec seulement 15 millions de paramètres, conçu pour un déploiement léger et une synthèse vocale de haute qualité.

*Actuellement en aperçu développeur*

[Rejoignez notre discord](https://discord.gg/upcyF5s6)


## ✨ Fonctionnalités

- **Ultra-léger** : Taille du modèle inférieure à 25 Mo
- **Optimisé CPU** : Fonctionne sans GPU sur n’importe quel appareil
- **Voix de haute qualité** : Plusieurs options de voix premium disponibles
- **Inférence rapide** : Optimisé pour la synthèse vocale en temps réel



## 🚀 Démarrage rapide

### Installation

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
## 💻 Exigences Système

Fonctionne littéralement partout



## Liste de Contrôle 

- [x] Publier un modèle de prévisualisation
- [ ] Publier les poids du modèle entièrement entraîné
- [ ] Publier le SDK mobile 
- [ ] Publier la version web 








---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-09

---