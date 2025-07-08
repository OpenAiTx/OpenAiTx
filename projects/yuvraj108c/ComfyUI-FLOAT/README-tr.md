<div align="center">

# ComfyUI FLOAT 

[![python](https://img.shields.io/badge/python-3.10.12-green)](https://www.python.org/downloads/release/python-31012/)
[![arXiv](https://img.shields.io/badge/arXiv%20paper-2412.09013-b31b1b.svg)](https://arxiv.org/abs/2412.01064) 
[![by-nc-sa/4.0](https://img.shields.io/badge/license-CC--BY--NC--SA--4.0-lightgrey)](https://creativecommons.org/licenses/by-nc-sa/4.0/deed.en)

</div>

Bu proje, Sesle Yönlendirilen Konuşan Portre için Üretken Hareket Gizli Akış Eşlemesi amacıyla [FLOAT](https://github.com/deepbrainai-research/float) için bir ComfyUI sarmalayıcısı sağlar.

Daha gelişmiş ve bakımı yapılan bir sürüm için şuraya göz atın: [ComfyUI-FLOAT_Optimized](https://github.com/set-soft/ComfyUI-FLOAT_Optimized)

<div align="center">
  <video src="https://github.com/user-attachments/assets/36626b4a-d3e5-4db9-87a7-ca0e949daee0" />
</div> 


## ⭐ Destek
Projelerimi beğeniyorsanız ve güncellemeler ile yeni özellikler görmek istiyorsanız, lütfen bana destek olmayı düşünün. Çok yardımcı olur! 

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

## 🚀 Kurulum

```bash
git clone https://github.com/yuvraj108c/ComfyUI-FLOAT.git
cd ./ComfyUI-FLOAT
pip install -r requirements.txt
```

## ☀️ Kullanım

- [Örnek iş akışını](https://raw.githubusercontent.com/yuvraj108c/ComfyUI-FLOAT/master/float_workflow.json) yükleyin
- Sürücü görseli ve sesi yükleyin, kuyruğa tıklayın
- [Modeller](https://huggingface.co/yuvraj108c/float/tree/main) otomatik olarak `/ComfyUI/models/float` dizinine indirilir
- Modeller aşağıdaki gibi düzenlenmiştir:
    ```.bash
    |-- float.pth                                       # ana model
    |-- wav2vec2-base-960h/                             # ses kodlayıcı
    |   |-- config.json
    |   |-- model.safetensors
    |   |-- preprocessor_config.json
    |-- wav2vec-english-speech-emotion-recognition/     # duygu kodlayıcı
        |-- config.json
        |-- preprocessor_config.json
        |-- pytorch_model.bin

## 🛠️ Parametreler
- `ref_image`: Yüz içeren referans görsel (toplu boyutu 1 olmalı)
- `ref_audio`: Referans ses (Uzun sesler için (örn. 3+ dakika), yeterli ram/vram olduğundan emin olun)
- `a_cfg_scale`: Ses sınıflandırıcı-serbest kılavuz ölçeği (varsayılan:2)
- `r_cfg_scale`: Referans sınıflandırıcı-serbest kılavuz ölçeği (varsayılan:1)
- `emotion`: none, angry, disgust, fear, happy, neutral, sad, surprise (varsayılan:none)
- `e_cfg_scale`: Duygu yoğunluğu (varsayılan:1). Daha yoğun duygulu video için 5 ile 10 arası yüksek değerler deneyin
- `crop`: Referans görselde yüz ortalanmamışsa etkinleştirin
- `fps`: Çıktı videonun kare hızı (varsayılan:25)

   
## Atıf
```bibtex
@article{ki2024float,
  title={FLOAT: Generative Motion Latent Flow Matching for Audio-driven Talking Portrait},
  author={Ki, Taekyung ve Min, Dongchan ve Chae, Gyeongsu},
  journal={arXiv preprint arXiv:2412.01064},
  year={2024}
}
```

## Teşekkürler
GPU sunucuları sağladığı için [simplepod.ai](https://simplepod.ai/) adresine teşekkürler

## Lisans

[Creative Commons Attribution-NonCommercial-ShareAlike 4.0 International (CC BY-NC-SA 4.0)](https://creativecommons.org/licenses/by-nc-sa/4.0/)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---