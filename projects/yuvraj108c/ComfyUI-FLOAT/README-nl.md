<div align="center">

# ComfyUI FLOAT 

[![python](https://img.shields.io/badge/python-3.10.12-green)](https://www.python.org/downloads/release/python-31012/)
[![arXiv](https://img.shields.io/badge/arXiv%20paper-2412.09013-b31b1b.svg)](https://arxiv.org/abs/2412.01064) 
[![by-nc-sa/4.0](https://img.shields.io/badge/license-CC--BY--NC--SA--4.0-lightgrey)](https://creativecommons.org/licenses/by-nc-sa/4.0/deed.en)

</div>

Dit project biedt een ComfyUI-wrapper van [FLOAT](https://github.com/deepbrainai-research/float) voor Generative Motion Latent Flow Matching voor audio-gestuurde pratende portretten.

Voor een geavanceerdere en onderhouden versie, bekijk: [ComfyUI-FLOAT_Optimized](https://github.com/set-soft/ComfyUI-FLOAT_Optimized)

<div align="center">
  <video src="https://github.com/user-attachments/assets/36626b4a-d3e5-4db9-87a7-ca0e949daee0" />
</div> 


## ⭐ Ondersteuning
Als je mijn projecten leuk vindt en graag updates en nieuwe functies wilt zien, overweeg dan om mij te steunen. Het helpt enorm!

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

## 🚀 Installatie

```bash
git clone https://github.com/yuvraj108c/ComfyUI-FLOAT.git
cd ./ComfyUI-FLOAT
pip install -r requirements.txt
```

## ☀️ Gebruik

- Laad [voorbeeld workflow](https://raw.githubusercontent.com/yuvraj108c/ComfyUI-FLOAT/master/float_workflow.json) 
- Upload een sturende afbeelding en audio, klik op queue
- [Modellen](https://huggingface.co/yuvraj108c/float/tree/main) worden automatisch gedownload naar `/ComfyUI/models/float`
- De modellen zijn als volgt georganiseerd:
    ```.bash
    |-- float.pth                                       # hoofdmodel
    |-- wav2vec2-base-960h/                             # audio-encoder
    |   |-- config.json
    |   |-- model.safetensors
    |   |-- preprocessor_config.json
    |-- wav2vec-english-speech-emotion-recognition/     # emotie-encoder
        |-- config.json
        |-- preprocessor_config.json
        |-- pytorch_model.bin

## 🛠️ Parameters
- `ref_image`: Referentieafbeelding met een gezicht (moet batch size 1 hebben)
- `ref_audio`: Referentie-audio (Bij lange audio’s (bijv. 3+ minuten), zorg dat je genoeg ram/vram hebt)
- `a_cfg_scale`: Audio classifier-free guidance scale (standaard:2)
- `r_cfg_scale`: Referentie classifier-free guidance scale (standaard:1)
- `emotion`: none, angry, disgust, fear, happy, neutral, sad, surprise (standaard:none)
- `e_cfg_scale`: Intensiteit van emotie (standaard:1). Voor een emotievoller resultaat, probeer een waarde tussen 5 en 10
- `crop`: Alleen inschakelen als de referentieafbeelding geen gecentreerd gezicht heeft
- `fps`: Beeldsnelheid van de uitvoervideo (standaard:25)

   
## Referentie
```bibtex
@article{ki2024float,
  title={FLOAT: Generative Motion Latent Flow Matching for Audio-driven Talking Portrait},
  author={Ki, Taekyung en Min, Dongchan en Chae, Gyeongsu},
  journal={arXiv preprint arXiv:2412.01064},
  year={2024}
}
```

## Dankwoord
Dank aan [simplepod.ai](https://simplepod.ai/) voor het beschikbaar stellen van GPU-servers

## Licentie

[Creative Commons Naamsvermelding-NietCommercieel-GelijkDelen 4.0 Internationaal (CC BY-NC-SA 4.0)](https://creativecommons.org/licenses/by-nc-sa/4.0/)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---