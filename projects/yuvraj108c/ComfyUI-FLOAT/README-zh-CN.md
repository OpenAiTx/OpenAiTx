<div align="center">

# ComfyUI FLOAT 

[![python](https://img.shields.io/badge/python-3.10.12-green)](https://www.python.org/downloads/release/python-31012/)
[![arXiv](https://img.shields.io/badge/arXiv%20paper-2412.09013-b31b1b.svg)](https://arxiv.org/abs/2412.01064) 
[![by-nc-sa/4.0](https://img.shields.io/badge/license-CC--BY--NC--SA--4.0-lightgrey)](https://creativecommons.org/licenses/by-nc-sa/4.0/deed.en)

</div>

本项目为 [FLOAT](https://github.com/deepbrainai-research/float) 提供了 ComfyUI 封装，实现音频驱动的说话人像生成运动潜在流匹配。

如需更高级且持续维护的版本，请查看：[ComfyUI-FLOAT_Optimized](https://github.com/set-soft/ComfyUI-FLOAT_Optimized)

<div align="center">
  <video src="https://github.com/user-attachments/assets/36626b4a-d3e5-4db9-87a7-ca0e949daee0" />
</div> 


## ⭐ 支持
如果你喜欢我的项目，并希望看到更多更新和新功能，请考虑支持我。这对我帮助很大！

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

## 🚀 安装

```bash
git clone https://github.com/yuvraj108c/ComfyUI-FLOAT.git
cd ./ComfyUI-FLOAT
pip install -r requirements.txt
```

## ☀️ 使用方法

- 加载 [示例工作流](https://raw.githubusercontent.com/yuvraj108c/ComfyUI-FLOAT/master/float_workflow.json) 
- 上传驱动图像和音频，点击队列
- [模型](https://huggingface.co/yuvraj108c/float/tree/main) 会自动下载到 `/ComfyUI/models/float`
- 模型文件结构如下：
    ```.bash
    |-- float.pth                                       # 主模型
    |-- wav2vec2-base-960h/                             # 音频编码器
    |   |-- config.json
    |   |-- model.safetensors
    |   |-- preprocessor_config.json
    |-- wav2vec-english-speech-emotion-recognition/     # 情感编码器
        |-- config.json
        |-- preprocessor_config.json
        |-- pytorch_model.bin

## 🛠️ 参数说明
- `ref_image`：包含人脸的参考图像（必须批处理大小为1）
- `ref_audio`：参考音频（对于较长音频（例如3分钟以上），请确保有足够的内存/显存）
- `a_cfg_scale`：音频无分类器引导尺度（默认：2）
- `r_cfg_scale`：参考无分类器引导尺度（默认：1）
- `emotion`：none, angry, disgust, fear, happy, neutral, sad, surprise（默认：none）
- `e_cfg_scale`：情感强度（默认：1）。如需更强烈的情感表现，可尝试5到10的较大值
- `crop`：仅在参考图像未居中人脸时启用
- `fps`：输出视频帧率（默认：25）

   
## 引用
```bibtex
@article{ki2024float,
  title={FLOAT: Generative Motion Latent Flow Matching for Audio-driven Talking Portrait},
  author={Ki, Taekyung and Min, Dongchan and Chae, Gyeongsu},
  journal={arXiv preprint arXiv:2412.01064},
  year={2024}
}
```

## 致谢
感谢 [simplepod.ai](https://simplepod.ai/) 提供 GPU 服务器支持

## 许可协议

[知识共享署名-非商业性使用-相同方式共享 4.0 国际 (CC BY-NC-SA 4.0)](https://creativecommons.org/licenses/by-nc-sa/4.0/)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---