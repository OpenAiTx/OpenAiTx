<div align="center">

# ComfyUI FLOAT 

[![python](https://img.shields.io/badge/python-3.10.12-green)](https://www.python.org/downloads/release/python-31012/)
[![arXiv](https://img.shields.io/badge/arXiv%20paper-2412.09013-b31b1b.svg)](https://arxiv.org/abs/2412.01064) 
[![by-nc-sa/4.0](https://img.shields.io/badge/license-CC--BY--NC--SA--4.0-lightgrey)](https://creativecommons.org/licenses/by-nc-sa/4.0/deed.en)

</div>

Ten projekt udostępnia wrapper ComfyUI dla [FLOAT](https://github.com/deepbrainai-research/float) służący do Generative Motion Latent Flow Matching dla portretów mówiących sterowanych dźwiękiem.

Bardziej zaawansowaną i utrzymywaną wersję znajdziesz tutaj: [ComfyUI-FLOAT_Optimized](https://github.com/set-soft/ComfyUI-FLOAT_Optimized)

<div align="center">
  <video src="https://github.com/user-attachments/assets/36626b4a-d3e5-4db9-87a7-ca0e949daee0" />
</div> 


## ⭐ Wsparcie
Jeśli podobają Ci się moje projekty i chcesz widzieć aktualizacje oraz nowe funkcje, rozważ wsparcie. To bardzo pomaga!

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

## 🚀 Instalacja

```bash
git clone https://github.com/yuvraj108c/ComfyUI-FLOAT.git
cd ./ComfyUI-FLOAT
pip install -r requirements.txt
```

## ☀️ Użytkowanie

- Wczytaj [przykładowy workflow](https://raw.githubusercontent.com/yuvraj108c/ComfyUI-FLOAT/master/float_workflow.json) 
- Prześlij obraz sterujący i dźwięk, kliknij queue
- [Modele](https://huggingface.co/yuvraj108c/float/tree/main) pobierają się automatycznie do `/ComfyUI/models/float`
- Modele są uporządkowane w następujący sposób:
    ```.bash
    |-- float.pth                                       # główny model
    |-- wav2vec2-base-960h/                             # enkoder audio
    |   |-- config.json
    |   |-- model.safetensors
    |   |-- preprocessor_config.json
    |-- wav2vec-english-speech-emotion-recognition/     # enkoder emocji
        |-- config.json
        |-- preprocessor_config.json
        |-- pytorch_model.bin

## 🛠️ Parametry
- `ref_image`: Obraz referencyjny z twarzą (musi mieć batch size 1)
- `ref_audio`: Dźwięk referencyjny (dla długich plików audio (np. 3+ minuty), upewnij się, że masz wystarczająco dużo RAM/VRAM)
- `a_cfg_scale`: Skala prowadzenia classifier-free dla dźwięku (domyślnie:2)
- `r_cfg_scale`: Skala prowadzenia classifier-free dla obrazu referencyjnego (domyślnie:1)
- `emotion`: brak, złość, obrzydzenie, strach, radość, neutralny, smutny, zaskoczenie (domyślnie: brak)
- `e_cfg_scale`: Intensywność emocji (domyślnie:1). Aby uzyskać bardziej emocjonalne wideo, spróbuj wartości od 5 do 10
- `crop`: Włącz tylko jeśli obraz referencyjny nie zawiera wycentrowanej twarzy
- `fps`: Liczba klatek na sekundę wideo wyjściowego (domyślnie:25)

   
## Cytowanie
```bibtex
@article{ki2024float,
  title={FLOAT: Generative Motion Latent Flow Matching for Audio-driven Talking Portrait},
  author={Ki, Taekyung i Min, Dongchan i Chae, Gyeongsu},
  journal={arXiv preprint arXiv:2412.01064},
  year={2024}
}
```

## Podziękowania
Podziękowania dla [simplepod.ai](https://simplepod.ai/) za udostępnienie serwerów GPU

## Licencja

[Creative Commons Uznanie autorstwa-Użycie niekomercyjne-Na tych samych warunkach 4.0 Międzynarodowa (CC BY-NC-SA 4.0)](https://creativecommons.org/licenses/by-nc-sa/4.0/)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---