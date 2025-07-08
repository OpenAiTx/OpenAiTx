<div align="center">

# ComfyUI FLOAT 

[![python](https://img.shields.io/badge/python-3.10.12-green)](https://www.python.org/downloads/release/python-31012/)
[![arXiv](https://img.shields.io/badge/arXiv%20paper-2412.09013-b31b1b.svg)](https://arxiv.org/abs/2412.01064) 
[![by-nc-sa/4.0](https://img.shields.io/badge/license-CC--BY--NC--SA--4.0-lightgrey)](https://creativecommons.org/licenses/by-nc-sa/4.0/deed.en)

</div>

Proyek ini menyediakan pembungkus ComfyUI untuk [FLOAT](https://github.com/deepbrainai-research/float) untuk Generative Motion Latent Flow Matching for Audio-driven Talking Portrait

Untuk versi yang lebih canggih dan terus diperbarui, lihat: [ComfyUI-FLOAT_Optimized](https://github.com/set-soft/ComfyUI-FLOAT_Optimized)

<div align="center">
  <video src="https://github.com/user-attachments/assets/36626b4a-d3e5-4db9-87a7-ca0e949daee0" />
</div> 


## ⭐ Dukungan
Jika Anda menyukai proyek saya dan ingin melihat pembaruan serta fitur baru, mohon pertimbangkan untuk mendukung saya. Ini sangat membantu! 

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

## 🚀 Instalasi

```bash
git clone https://github.com/yuvraj108c/ComfyUI-FLOAT.git
cd ./ComfyUI-FLOAT
pip install -r requirements.txt
```

## ☀️ Penggunaan

- Muat [contoh workflow](https://raw.githubusercontent.com/yuvraj108c/ComfyUI-FLOAT/master/float_workflow.json) 
- Unggah gambar dan audio penggerak, klik queue
- [Model](https://huggingface.co/yuvraj108c/float/tree/main) akan terunduh otomatis ke `/ComfyUI/models/float`
- Struktur model sebagai berikut:
    ```.bash
    |-- float.pth                                       # model utama
    |-- wav2vec2-base-960h/                             # encoder audio
    |   |-- config.json
    |   |-- model.safetensors
    |   |-- preprocessor_config.json
    |-- wav2vec-english-speech-emotion-recognition/     # encoder emosi
        |-- config.json
        |-- preprocessor_config.json
        |-- pytorch_model.bin

## 🛠️ Parameter
- `ref_image`: Gambar referensi dengan wajah (harus batch size 1)
- `ref_audio`: Audio referensi (Untuk audio panjang (misal 3+ menit), pastikan RAM/VRAM Anda cukup)
- `a_cfg_scale`: Skala classifier-free guidance audio (default:2)
- `r_cfg_scale`: Skala classifier-free guidance referensi (default:1)
- `emotion`: none, angry, disgust, fear, happy, neutral, sad, surprise (default:none)
- `e_cfg_scale`: Intensitas emosi (default:1). Untuk video dengan ekspresi emosi yang lebih intens, coba nilai besar antara 5 hingga 10
- `crop`: Aktifkan hanya jika gambar referensi tidak memiliki wajah di tengah
- `fps`: Frame rate video keluaran (default:25)

   
## Sitasi
```bibtex
@article{ki2024float,
  title={FLOAT: Generative Motion Latent Flow Matching for Audio-driven Talking Portrait},
  author={Ki, Taekyung dan Min, Dongchan dan Chae, Gyeongsu},
  journal={arXiv preprint arXiv:2412.01064},
  year={2024}
}
```

## Ucapan Terima Kasih
Terima kasih kepada [simplepod.ai](https://simplepod.ai/) atas penyediaan server GPU

## Lisensi

[Creative Commons Attribution-NonCommercial-ShareAlike 4.0 International (CC BY-NC-SA 4.0)](https://creativecommons.org/licenses/by-nc-sa/4.0/)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---