<div align="center">

# ComfyUI FLOAT 

[![python](https://img.shields.io/badge/python-3.10.12-green)](https://www.python.org/downloads/release/python-31012/)
[![arXiv](https://img.shields.io/badge/arXiv%20paper-2412.09013-b31b1b.svg)](https://arxiv.org/abs/2412.01064) 
[![by-nc-sa/4.0](https://img.shields.io/badge/license-CC--BY--NC--SA--4.0-lightgrey)](https://creativecommons.org/licenses/by-nc-sa/4.0/deed.en)

</div>

यह परियोजना ऑडियो-ड्रिवन टॉकिंग पोर्ट्रेट के लिए जनरेटिव मोशन लैटेंट फ्लो मैचिंग हेतु [FLOAT](https://github.com/deepbrainai-research/float) का ComfyUI रैपर प्रदान करती है।

अधिक उन्नत और अनुरक्षित संस्करण के लिए देखें: [ComfyUI-FLOAT_Optimized](https://github.com/set-soft/ComfyUI-FLOAT_Optimized)

<div align="center">
  <video src="https://github.com/user-attachments/assets/36626b4a-d3e5-4db9-87a7-ca0e949daee0" />
</div> 


## ⭐ समर्थन करें
यदि आपको मेरे प्रोजेक्ट्स पसंद हैं और आप अपडेट्स तथा नई सुविधाएँ देखना चाहते हैं, तो कृपया मुझे समर्थन देने पर विचार करें। इससे बहुत मदद मिलती है! 

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

## 🚀 स्थापना

```bash
git clone https://github.com/yuvraj108c/ComfyUI-FLOAT.git
cd ./ComfyUI-FLOAT
pip install -r requirements.txt
```

## ☀️ उपयोग

- [example workflow](https://raw.githubusercontent.com/yuvraj108c/ComfyUI-FLOAT/master/float_workflow.json) लोड करें 
- ड्राइविंग इमेज और ऑडियो अपलोड करें, फिर queue पर क्लिक करें
- [मॉडल्स](https://huggingface.co/yuvraj108c/float/tree/main) स्वतः `/ComfyUI/models/float` में डाउनलोड हो जाते हैं
- मॉडल्स निम्नलिखित रूप में व्यवस्थित हैं:
    ```.bash
    |-- float.pth                                       # मुख्य मॉडल
    |-- wav2vec2-base-960h/                             # ऑडियो एनकोडर
    |   |-- config.json
    |   |-- model.safetensors
    |   |-- preprocessor_config.json
    |-- wav2vec-english-speech-emotion-recognition/     # इमोशन एनकोडर
        |-- config.json
        |-- preprocessor_config.json
        |-- pytorch_model.bin

## 🛠️ पैरामीटर्स
- `ref_image`: एक चेहरा वाला संदर्भ चित्र (बैच साइज 1 होना अनिवार्य)
- `ref_audio`: संदर्भ ऑडियो (लंबे ऑडियो के लिए (जैसे 3+ मिनट), यह सुनिश्चित करें कि आपके पास पर्याप्त RAM/VRAM हो)
- `a_cfg_scale`: ऑडियो क्लासिफायर-फ्री गाइडेंस स्केल (डिफॉल्ट:2)
- `r_cfg_scale`: रेफरेंस क्लासिफायर-फ्री गाइडेंस स्केल (डिफॉल्ट:1)
- `emotion`: none, angry, disgust, fear, happy, neutral, sad, surprise (डिफॉल्ट:none)
- `e_cfg_scale`: इमोशन की तीव्रता (डिफॉल्ट:1)। अधिक इमोशन इंटेंसिव वीडियो के लिए 5 से 10 तक बड़ा मान आजमाएं
- `crop`: केवल तभी सक्षम करें जब संदर्भ चित्र में चेहरा केंद्रित न हो
- `fps`: आउटपुट वीडियो का फ्रेम रेट (डिफॉल्ट:25)

   
## संदर्भ
```bibtex
@article{ki2024float,
  title={FLOAT: Generative Motion Latent Flow Matching for Audio-driven Talking Portrait},
  author={Ki, Taekyung and Min, Dongchan and Chae, Gyeongsu},
  journal={arXiv preprint arXiv:2412.01064},
  year={2024}
}
```

## आभार
GPU सर्वर उपलब्ध कराने के लिए [simplepod.ai](https://simplepod.ai/) का धन्यवाद

## लाइसेंस

[क्रिएटिव कॉमन्स एट्रिब्यूशन-नॉनकमर्शियल-शेयरअलाइक 4.0 इंटरनेशनल (CC BY-NC-SA 4.0)](https://creativecommons.org/licenses/by-nc-sa/4.0/)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---