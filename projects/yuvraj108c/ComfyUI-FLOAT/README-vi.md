<div align="center">

# ComfyUI FLOAT 

[![python](https://img.shields.io/badge/python-3.10.12-green)](https://www.python.org/downloads/release/python-31012/)
[![arXiv](https://img.shields.io/badge/arXiv%20paper-2412.09013-b31b1b.svg)](https://arxiv.org/abs/2412.01064) 
[![by-nc-sa/4.0](https://img.shields.io/badge/license-CC--BY--NC--SA--4.0-lightgrey)](https://creativecommons.org/licenses/by-nc-sa/4.0/deed.en)

</div>

Dự án này cung cấp một wrapper ComfyUI của [FLOAT](https://github.com/deepbrainai-research/float) cho Generative Motion Latent Flow Matching cho Audio-driven Talking Portrait

Để có phiên bản nâng cao và được duy trì tốt hơn, hãy xem: [ComfyUI-FLOAT_Optimized](https://github.com/set-soft/ComfyUI-FLOAT_Optimized)

<div align="center">
  <video src="https://github.com/user-attachments/assets/36626b4a-d3e5-4db9-87a7-ca0e949daee0" />
</div> 


## ⭐ Hỗ trợ
Nếu bạn thích các dự án của tôi và muốn thấy các bản cập nhật cùng tính năng mới, hãy cân nhắc ủng hộ tôi. Điều này giúp ích rất nhiều! 

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

## 🚀 Cài đặt

```bash
git clone https://github.com/yuvraj108c/ComfyUI-FLOAT.git
cd ./ComfyUI-FLOAT
pip install -r requirements.txt
```

## ☀️ Sử dụng

- Tải [workflow mẫu](https://raw.githubusercontent.com/yuvraj108c/ComfyUI-FLOAT/master/float_workflow.json) 
- Tải lên ảnh và âm thanh điều khiển, bấm queue
- [Models](https://huggingface.co/yuvraj108c/float/tree/main) sẽ tự động tải về `/ComfyUI/models/float`
- Các mô hình được tổ chức như sau:
    ```.bash
    |-- float.pth                                       # mô hình chính
    |-- wav2vec2-base-960h/                             # bộ mã hóa âm thanh
    |   |-- config.json
    |   |-- model.safetensors
    |   |-- preprocessor_config.json
    |-- wav2vec-english-speech-emotion-recognition/     # bộ mã hóa cảm xúc
        |-- config.json
        |-- preprocessor_config.json
        |-- pytorch_model.bin

## 🛠️ Tham số
- `ref_image`: Ảnh tham chiếu có khuôn mặt (bắt buộc batch size 1)
- `ref_audio`: Âm thanh tham chiếu (Với âm thanh dài (ví dụ trên 3 phút), đảm bảo bạn có đủ ram/vram)
- `a_cfg_scale`: Hệ số hướng dẫn classifier-free cho âm thanh (mặc định:2)
- `r_cfg_scale`: Hệ số hướng dẫn classifier-free cho ảnh tham chiếu (mặc định:1)
- `emotion`: none, angry, disgust, fear, happy, neutral, sad, surprise (mặc định:none)
- `e_cfg_scale`: Cường độ cảm xúc (mặc định:1). Nếu muốn video thể hiện cảm xúc mạnh, thử giá trị lớn từ 5 đến 10
- `crop`: Bật chỉ khi ảnh tham chiếu không có khuôn mặt ở giữa
- `fps`: Số khung hình trên giây của video xuất ra (mặc định:25)

   
## Trích dẫn
```bibtex
@article{ki2024float,
  title={FLOAT: Generative Motion Latent Flow Matching for Audio-driven Talking Portrait},
  author={Ki, Taekyung and Min, Dongchan and Chae, Gyeongsu},
  journal={arXiv preprint arXiv:2412.01064},
  year={2024}
}
```

## Ghi nhận
Cảm ơn [simplepod.ai](https://simplepod.ai/) đã cung cấp máy chủ GPU

## Giấy phép

[Creative Commons Attribution-NonCommercial-ShareAlike 4.0 International (CC BY-NC-SA 4.0)](https://creativecommons.org/licenses/by-nc-sa/4.0/)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---