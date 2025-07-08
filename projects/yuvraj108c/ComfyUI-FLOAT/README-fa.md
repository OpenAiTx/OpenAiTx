<div align="center">

# ComfyUI FLOAT 

[![python](https://img.shields.io/badge/python-3.10.12-green)](https://www.python.org/downloads/release/python-31012/)
[![arXiv](https://img.shields.io/badge/arXiv%20paper-2412.09013-b31b1b.svg)](https://arxiv.org/abs/2412.01064) 
[![by-nc-sa/4.0](https://img.shields.io/badge/license-CC--BY--NC--SA--4.0-lightgrey)](https://creativecommons.org/licenses/by-nc-sa/4.0/deed.en)

</div>

این پروژه یک بسته‌ی رابط ComfyUI برای [FLOAT](https://github.com/deepbrainai-research/float) جهت «تطبیق جریان نهفته حرکتی مولد برای پرتره سخنگو بر اساس صوت» ارائه می‌دهد.

برای نسخه‌ای پیشرفته‌تر و به‌روزتر، به اینجا مراجعه کنید: [ComfyUI-FLOAT_Optimized](https://github.com/set-soft/ComfyUI-FLOAT_Optimized)

<div align="center">
  <video src="https://github.com/user-attachments/assets/36626b4a-d3e5-4db9-87a7-ca0e949daee0" />
</div> 


## ⭐ پشتیبانی
اگر پروژه‌های من را دوست دارید و مایل به مشاهده به‌روزرسانی‌ها و ویژگی‌های جدید هستید، لطفاً از من حمایت کنید. این کار بسیار کمک‌کننده است!

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

## 🚀 نصب

```bash
git clone https://github.com/yuvraj108c/ComfyUI-FLOAT.git
cd ./ComfyUI-FLOAT
pip install -r requirements.txt
```

## ☀️ استفاده

- [نمونه جریان کاری](https://raw.githubusercontent.com/yuvraj108c/ComfyUI-FLOAT/master/float_workflow.json) را بارگذاری کنید
- تصویر و صوت راهبر را آپلود کرده و روی صف کلیک کنید
- [مدل‌ها](https://huggingface.co/yuvraj108c/float/tree/main) به‌صورت خودکار در مسیر `/ComfyUI/models/float` دانلود می‌شوند
- ساختار مدل‌ها به شرح زیر است:
    ```.bash
    |-- float.pth                                       # مدل اصلی
    |-- wav2vec2-base-960h/                             # رمزگذار صوت
    |   |-- config.json
    |   |-- model.safetensors
    |   |-- preprocessor_config.json
    |-- wav2vec-english-speech-emotion-recognition/     # رمزگذار احساسات
        |-- config.json
        |-- preprocessor_config.json
        |-- pytorch_model.bin

## 🛠️ پارامترها
- `ref_image`: تصویر مرجع با چهره (باید دارای batch size برابر ۱ باشد)
- `ref_audio`: صوت مرجع (برای فایل‌های صوتی طولانی (مثلاً بیش از ۳ دقیقه)، مطمئن شوید که RAM/VRAM کافی دارید)
- `a_cfg_scale`: مقیاس راهنمای بدون طبقه‌بندی صوت (پیش‌فرض:۲)
- `r_cfg_scale`: مقیاس راهنمای بدون طبقه‌بندی مرجع (پیش‌فرض:۱)
- `emotion`: هیچ، عصبی، بیزار، ترس، خوشحال، خنثی، غمگین، متعجب (پیش‌فرض:هیچ)
- `e_cfg_scale`: شدت احساسات (پیش‌فرض:۱). برای ویدیوی با احساسات قوی‌تر، عدد بزرگ‌تر بین ۵ تا ۱۰ را امتحان کنید
- `crop`: فقط زمانی فعال شود که تصویر مرجع چهره در مرکز نداشته باشد
- `fps`: نرخ فریم ویدیوی خروجی (پیش‌فرض:۲۵)

   
## استناد
```bibtex
@article{ki2024float,
  title={FLOAT: Generative Motion Latent Flow Matching for Audio-driven Talking Portrait},
  author={Ki, Taekyung and Min, Dongchan and Chae, Gyeongsu},
  journal={arXiv preprint arXiv:2412.01064},
  year={2024}
}
```

## سپاسگزاری
سپاس از [simplepod.ai](https://simplepod.ai/) بابت فراهم‌کردن سرورهای GPU

## مجوز

[Creative Commons Attribution-NonCommercial-ShareAlike 4.0 International (CC BY-NC-SA 4.0)](https://creativecommons.org/licenses/by-nc-sa/4.0/)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---