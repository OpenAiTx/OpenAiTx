<div align="center">

# ComfyUI FLOAT

[![python](https://img.shields.io/badge/python-3.10.12-green)](https://www.python.org/downloads/release/python-31012/)
[![arXiv](https://img.shields.io/badge/arXiv%20paper-2412.09013-b31b1b.svg)](https://arxiv.org/abs/2412.01064)
[![by-nc-sa/4.0](https://img.shields.io/badge/license-CC--BY--NC--SA--4.0-lightgrey)](https://creativecommons.org/licenses/by-nc-sa/4.0/deed.en)

</div>

Este proyecto proporciona un wrapper de ComfyUI de [FLOAT](https://github.com/deepbrainai-research/float) para Generative Motion Latent Flow Matching for Audio-driven Talking Portrait

Para una versión más avanzada y mantenida, consulta: [ComfyUI-FLOAT_Optimized](https://github.com/set-soft/ComfyUI-FLOAT_Optimized)

<div align="center">
  <video src="https://github.com/user-attachments/assets/36626b4a-d3e5-4db9-87a7-ca0e949daee0" />
</div> 


## ⭐ Soporte
Si te gustan mis proyectos y deseas ver actualizaciones y nuevas funciones, por favor considera apoyarme. ¡Ayuda mucho!

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

## 🚀 Instalación

```bash
git clone https://github.com/yuvraj108c/ComfyUI-FLOAT.git
cd ./ComfyUI-FLOAT
pip install -r requirements.txt
```

## ☀️ Uso

- Carga el [ejemplo de workflow](https://raw.githubusercontent.com/yuvraj108c/ComfyUI-FLOAT/master/float_workflow.json)
- Sube la imagen de referencia y el audio, haz clic en queue
- [Los modelos](https://huggingface.co/yuvraj108c/float/tree/main) se descargan automáticamente en `/ComfyUI/models/float`
- Los modelos están organizados de la siguiente manera:
    ```.bash
    |-- float.pth                                       # modelo principal
    |-- wav2vec2-base-960h/                             # codificador de audio
    |   |-- config.json
    |   |-- model.safetensors
    |   |-- preprocessor_config.json
    |-- wav2vec-english-speech-emotion-recognition/     # codificador de emociones
        |-- config.json
        |-- preprocessor_config.json
        |-- pytorch_model.bin

## 🛠️ Parámetros
- `ref_image`: Imagen de referencia con un rostro (debe tener tamaño de lote 1)
- `ref_audio`: Audio de referencia (para audios largos (por ejemplo, 3+ minutos), asegúrate de tener suficiente ram/vram)
- `a_cfg_scale`: Escala de guidance libre de clasificador para audio (por defecto:2)
- `r_cfg_scale`: Escala de guidance libre de clasificador para referencia (por defecto:1)
- `emotion`: none, angry, disgust, fear, happy, neutral, sad, surprise (por defecto:none)
- `e_cfg_scale`: Intensidad de la emoción (por defecto:1). Para videos con emociones más intensas, prueba valores grandes de 5 a 10
- `crop`: Activar solo si la imagen de referencia no tiene un rostro centrado
- `fps`: Tasa de fotogramas del video de salida (por defecto:25)

   
## Citación
```bibtex
@article{ki2024float,
  title={FLOAT: Generative Motion Latent Flow Matching for Audio-driven Talking Portrait},
  author={Ki, Taekyung y Min, Dongchan y Chae, Gyeongsu},
  journal={arXiv preprint arXiv:2412.01064},
  year={2024}
}
```

## Agradecimientos
Gracias a [simplepod.ai](https://simplepod.ai/) por proporcionar servidores GPU

## Licencia

[Creative Commons Attribution-NonCommercial-ShareAlike 4.0 International (CC BY-NC-SA 4.0)](https://creativecommons.org/licenses/by-nc-sa/4.0/)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---