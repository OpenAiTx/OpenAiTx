<div align="center">

# ComfyUI FLOAT

[![python](https://img.shields.io/badge/python-3.10.12-green)](https://www.python.org/downloads/release/python-31012/)
[![arXiv](https://img.shields.io/badge/arXiv%20paper-2412.09013-b31b1b.svg)](https://arxiv.org/abs/2412.01064) 
[![by-nc-sa/4.0](https://img.shields.io/badge/license-CC--BY--NC--SA--4.0-lightgrey)](https://creativecommons.org/licenses/by-nc-sa/4.0/deed.en)

</div>

Dieses Projekt bietet einen ComfyUI-Wrapper für [FLOAT](https://github.com/deepbrainai-research/float) für Generative Motion Latent Flow Matching für Audio-gesteuerte sprechende Porträts.

Für eine fortgeschrittenere und gepflegte Version siehe: [ComfyUI-FLOAT_Optimized](https://github.com/set-soft/ComfyUI-FLOAT_Optimized)

<div align="center">
  <video src="https://github.com/user-attachments/assets/36626b4a-d3e5-4db9-87a7-ca0e949daee0" />
</div> 


## ⭐ Unterstützung
Wenn Ihnen meine Projekte gefallen und Sie Updates sowie neue Features sehen möchten, unterstützen Sie mich bitte. Das hilft sehr! 

[![ComfyUI-Depth-Anything-Tensorrt](https://img.shields.io/badge/ComfyUI--Depth--Anything--Tensorrt-blue?style=flat-square)](https://github.com/yuvraj108c/ComfyUI-Depth-Anything-Tensorrt)
[![ComfyUI-Upscaler-Tensorrt](https://img.shields.io/badge/ComfyUI--Upscaler--Tensorrt-blue?style=flat-square)](https://github.com/yuvraj108c/ComfyUI-Upscaler-Tensorrt)
[![ComfyUI-Dwpose-Tensorrt](https://img.shields.io/badge/ComfyUI--Dwpose--Tensorrt-blue?style=flat-square)](https://github.com/yuvraj108c/ComfyUI-Dwpose-Tensorrt)
[![ComfyUI-Rife-Tensorrt](https://img.shields.io/badge/ComfyUI--Rife--Tensorrt-blue?style=flat-square)](https://github.com/yuvraj108c/ComfyUI-Rife-Tensorrt)

[![ComfyUI-Whisper](https://img.shields.io/badge/ComfyUI--Whisper-gray?style=flat-square)](https://github.com/yuvraj108c/ComfyUI-Whisper)
[![ComfyUI_InvSR](https://img.shields.io/badge/ComfyUI__InvSR-gray?style=flat-square)](https://github.com/yuvraj108c/ComfyUI_InvSR)
[![ComfyUI-FLOAT](https://img.shields.io/badge/ComfyUI--FLOAT-gray?style=flat-square)](https://github.com/yuvraj108c/ComfyUI-FLOAT)
[![ComfyUI-Thera](https://img.shields.io/badge/ComfyUI--Thera-gray?style=flat-square)](https://github.com/yuvraj108c/ComfyUI-Thera)
[![ComfyUI-Video-Depth-Anything](https://img.shields.io/badge/ComfyUI--Video--Depth--Anything-gray?style=flat-square)](https://github.com/yuvraj108c/ComfyUI-Video-Depth-Anything)
[![ComfyUI-PiperTTS](https://img.shields.io/badge/ComfyUI--PiperTTS-gray?style=flat-square)](https://github.com/yuvraj108c/ComfyUI-PiperTTS)

[![buy-me-coffees](https://i.imgur.com/3MDbAtw.png)](https://www.buymeacoffee.com/yuvraj108cZ)
[![paypal-donation](https://i.imgur.com/w5jjubk.png)](https://paypal.me/yuvraj108c)
---

## 🚀 Installation

```bash
git clone https://github.com/yuvraj108c/ComfyUI-FLOAT.git
cd ./ComfyUI-FLOAT
pip install -r requirements.txt
```

## ☀️ Verwendung

- [Beispiel-Workflow laden](https://raw.githubusercontent.com/yuvraj108c/ComfyUI-FLOAT/master/float_workflow.json) 
- Bild und Audio hochladen, dann auf „queue“ klicken
- [Modelle](https://huggingface.co/yuvraj108c/float/tree/main) werden automatisch nach `/ComfyUI/models/float` heruntergeladen
- Die Modelle sind wie folgt organisiert:
    ```.bash
    |-- float.pth                                       # Hauptmodell
    |-- wav2vec2-base-960h/                             # Audio-Encoder
    |   |-- config.json
    |   |-- model.safetensors
    |   |-- preprocessor_config.json
    |-- wav2vec-english-speech-emotion-recognition/     # Emotions-Encoder
        |-- config.json
        |-- preprocessor_config.json
        |-- pytorch_model.bin

## 🛠️ Parameter
- `ref_image`: Referenzbild mit einem Gesicht (muss Batch-Größe 1 haben)
- `ref_audio`: Referenzaudio (Bei langen Audios (z. B. 3+ Minuten) darauf achten, dass ausreichend RAM/VRAM verfügbar ist)
- `a_cfg_scale`: Audio Classifier-Free Guidance Scale (Standard:2)
- `r_cfg_scale`: Referenz Classifier-Free Guidance Scale (Standard:1)
- `emotion`: none, angry, disgust, fear, happy, neutral, sad, surprise (Standard:none)
- `e_cfg_scale`: Intensität der Emotion (Standard:1). Für emotionalere Videos einen höheren Wert wie 5 bis 10 versuchen
- `crop`: Nur aktivieren, wenn das Referenzbild kein zentriertes Gesicht zeigt
- `fps`: Bildrate des Ausgabevideos (Standard:25)

   
## Zitation
```bibtex
@article{ki2024float,
  title={FLOAT: Generative Motion Latent Flow Matching for Audio-driven Talking Portrait},
  author={Ki, Taekyung und Min, Dongchan und Chae, Gyeongsu},
  journal={arXiv preprint arXiv:2412.01064},
  year={2024}
}
```

## Danksagungen
Vielen Dank an [simplepod.ai](https://simplepod.ai/) für die Bereitstellung von GPU-Servern

## Lizenz

[Creative Commons Attribution-NonCommercial-ShareAlike 4.0 International (CC BY-NC-SA 4.0)](https://creativecommons.org/licenses/by-nc-sa/4.0/)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---