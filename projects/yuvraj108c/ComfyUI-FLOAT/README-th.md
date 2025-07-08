<div align="center">

# ComfyUI FLOAT 

[![python](https://img.shields.io/badge/python-3.10.12-green)](https://www.python.org/downloads/release/python-31012/)
[![arXiv](https://img.shields.io/badge/arXiv%20paper-2412.09013-b31b1b.svg)](https://arxiv.org/abs/2412.01064) 
[![by-nc-sa/4.0](https://img.shields.io/badge/license-CC--BY--NC--SA--4.0-lightgrey)](https://creativecommons.org/licenses/by-nc-sa/4.0/deed.en)

</div>

โปรเจคนี้ให้บริการ ComfyUI wrapper ของ [FLOAT](https://github.com/deepbrainai-research/float) สำหรับ Generative Motion Latent Flow Matching สำหรับภาพพูดที่ขับเคลื่อนด้วยเสียง

สำหรับเวอร์ชันที่ทันสมัยและได้รับการดูแลมากกว่า โปรดดูที่: [ComfyUI-FLOAT_Optimized](https://github.com/set-soft/ComfyUI-FLOAT_Optimized)

<div align="center">
  <video src="https://github.com/user-attachments/assets/36626b4a-d3e5-4db9-87a7-ca0e949daee0" />
</div> 


## ⭐ สนับสนุน
หากคุณชอบโปรเจคของฉันและต้องการเห็นการอัปเดตและฟีเจอร์ใหม่ ๆ โปรดพิจารณาสนับสนุนฉัน มันช่วยได้มาก! 

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

## 🚀 การติดตั้ง

```bash
git clone https://github.com/yuvraj108c/ComfyUI-FLOAT.git
cd ./ComfyUI-FLOAT
pip install -r requirements.txt
```

## ☀️ วิธีใช้งาน

- โหลด [ตัวอย่างเวิร์กโฟลว์](https://raw.githubusercontent.com/yuvraj108c/ComfyUI-FLOAT/master/float_workflow.json) 
- อัปโหลดภาพและไฟล์เสียงสำหรับขับเคลื่อน กด queue
- [โมเดล](https://huggingface.co/yuvraj108c/float/tree/main) จะถูกดาวน์โหลดอัตโนมัติที่ `/ComfyUI/models/float`
- โครงสร้างของโมเดลเป็นดังนี้:
    ```.bash
    |-- float.pth                                       # โมเดลหลัก
    |-- wav2vec2-base-960h/                             # ตัวเข้ารหัสเสียง
    |   |-- config.json
    |   |-- model.safetensors
    |   |-- preprocessor_config.json
    |-- wav2vec-english-speech-emotion-recognition/     # ตัวเข้ารหัสอารมณ์
        |-- config.json
        |-- preprocessor_config.json
        |-- pytorch_model.bin

## 🛠️ พารามิเตอร์
- `ref_image`: ภาพอ้างอิงที่มีใบหน้า (batch size ต้องเป็น 1 เท่านั้น)
- `ref_audio`: ไฟล์เสียงอ้างอิง (หากเสียงยาว เช่น 3 นาทีขึ้นไป ให้แน่ใจว่าคุณมี ram/vram เพียงพอ)
- `a_cfg_scale`: ระดับการนำทางแบบ classifier-free สำหรับเสียง (ค่าเริ่มต้น:2)
- `r_cfg_scale`: ระดับการนำทางแบบ classifier-free สำหรับภาพอ้างอิง (ค่าเริ่มต้น:1)
- `emotion`: none, angry, disgust, fear, happy, neutral, sad, surprise (ค่าเริ่มต้น:none)
- `e_cfg_scale`: ความเข้มข้นของอารมณ์ (ค่าเริ่มต้น:1) หากต้องการวีดีโอที่แสดงอารมณ์มากขึ้น ให้ลองค่าที่สูงขึ้น เช่น 5 ถึง 10
- `crop`: เปิดใช้งานหากภาพอ้างอิงไม่มีใบหน้าอยู่ตรงกลาง
- `fps`: อัตราเฟรมของวีดีโอผลลัพธ์ (ค่าเริ่มต้น:25)

   
## การอ้างอิง
```bibtex
@article{ki2024float,
  title={FLOAT: Generative Motion Latent Flow Matching for Audio-driven Talking Portrait},
  author={Ki, Taekyung and Min, Dongchan and Chae, Gyeongsu},
  journal={arXiv preprint arXiv:2412.01064},
  year={2024}
}
```

## คำขอบคุณ
ขอขอบคุณ [simplepod.ai](https://simplepod.ai/) ที่ให้บริการเซิร์ฟเวอร์ GPU

## ใบอนุญาต

[Creative Commons Attribution-NonCommercial-ShareAlike 4.0 International (CC BY-NC-SA 4.0)](https://creativecommons.org/licenses/by-nc-sa/4.0/)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---