<div align="center">

# ComfyUI FLOAT 

[![python](https://img.shields.io/badge/python-3.10.12-green)](https://www.python.org/downloads/release/python-31012/)
[![arXiv](https://img.shields.io/badge/arXiv%20paper-2412.09013-b31b1b.svg)](https://arxiv.org/abs/2412.01064) 
[![by-nc-sa/4.0](https://img.shields.io/badge/license-CC--BY--NC--SA--4.0-lightgrey)](https://creativecommons.org/licenses/by-nc-sa/4.0/deed.en)

</div>

يوفر هذا المشروع غلاف ComfyUI لمشروع [FLOAT](https://github.com/deepbrainai-research/float) لتوليد حركة تدفق كامنة متطابقة للصور المتحركة المنطوقة المدفوعة بالصوت.

للحصول على نسخة أكثر تقدماً ويتم صيانتها باستمرار، راجع: [ComfyUI-FLOAT_Optimized](https://github.com/set-soft/ComfyUI-FLOAT_Optimized)

<div align="center">
  <video src="https://github.com/user-attachments/assets/36626b4a-d3e5-4db9-87a7-ca0e949daee0" />
</div> 


## ⭐ الدعم
إذا أعجبتك مشاريعي وترغب في رؤية تحديثات وميزات جديدة، يرجى التفكير في دعمي. هذا يساعد كثيراً!

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

## 🚀 التثبيت

```bash
git clone https://github.com/yuvraj108c/ComfyUI-FLOAT.git
cd ./ComfyUI-FLOAT
pip install -r requirements.txt
```

## ☀️ الاستخدام

- حمّل [سير العمل التجريبية](https://raw.githubusercontent.com/yuvraj108c/ComfyUI-FLOAT/master/float_workflow.json) 
- قم بتحميل صورة القيادة والصوت، ثم اضغط على قائمة الانتظار
- [النماذج](https://huggingface.co/yuvraj108c/float/tree/main) تُحمّل تلقائياً إلى `/ComfyUI/models/float`
- يتم تنظيم النماذج كما يلي:
    ```.bash
    |-- float.pth                                       # النموذج الرئيسي
    |-- wav2vec2-base-960h/                             # مشفر الصوت
    |   |-- config.json
    |   |-- model.safetensors
    |   |-- preprocessor_config.json
    |-- wav2vec-english-speech-emotion-recognition/     # مشفر العاطفة
        |-- config.json
        |-- preprocessor_config.json
        |-- pytorch_model.bin

## 🛠️ المعلمات
- `ref_image`: صورة مرجعية تحتوي على وجه (يجب أن يكون حجم الدُفعة 1)
- `ref_audio`: صوت مرجعي (للملفات الصوتية الطويلة (مثلاً أكثر من 3 دقائق)، تأكد من توفر ذاكرة RAM/VRAM كافية)
- `a_cfg_scale`: مقياس التوجيه الخالي من المصنف للصوت (الافتراضي:2)
- `r_cfg_scale`: مقياس التوجيه الخالي من المصنف للصورة المرجعية (الافتراضي:1)
- `emotion`: لا يوجد، غضب، اشمئزاز، خوف، سعادة، حيادي، حزن، مفاجأة (الافتراضي: لا يوجد)
- `e_cfg_scale`: شدة العاطفة (الافتراضي:1). للحصول على فيديو أكثر كثافة عاطفية، جرب قيمة كبيرة من 5 إلى 10
- `crop`: فعّل فقط إذا لم تكن الصورة المرجعية تحتوي على وجه في الوسط
- `fps`: معدل الإطارات للفيديو الناتج (الافتراضي:25)

   
## الاستشهاد
```bibtex
@article{ki2024float,
  title={FLOAT: Generative Motion Latent Flow Matching for Audio-driven Talking Portrait},
  author={Ki, Taekyung and Min, Dongchan and Chae, Gyeongsu},
  journal={arXiv preprint arXiv:2412.01064},
  year={2024}
}
```

## الشكر والتقدير
شكر خاص لـ [simplepod.ai](https://simplepod.ai/) لتوفير خوادم GPU

## الرخصة

[رخصة المشاع الإبداعي النسبية-غير تجارية-بالمثل 4.0 الدولية (CC BY-NC-SA 4.0)](https://creativecommons.org/licenses/by-nc-sa/4.0/)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---