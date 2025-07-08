<div align="center">

# ComfyUI FLOAT 

[![python](https://img.shields.io/badge/python-3.10.12-green)](https://www.python.org/downloads/release/python-31012/)
[![arXiv](https://img.shields.io/badge/arXiv%20paper-2412.09013-b31b1b.svg)](https://arxiv.org/abs/2412.01064) 
[![by-nc-sa/4.0](https://img.shields.io/badge/license-CC--BY--NC--SA--4.0-lightgrey)](https://creativecommons.org/licenses/by-nc-sa/4.0/deed.en)

</div>

本プロジェクトは、オーディオ駆動型トーキングポートレートのための[Generative Motion Latent Flow Matching for Audio-driven Talking Portrait（FLOAT）](https://github.com/deepbrainai-research/float) のComfyUIラッパーを提供します。

より高度でメンテナンスされているバージョンは、こちらをご覧ください: [ComfyUI-FLOAT_Optimized](https://github.com/set-soft/ComfyUI-FLOAT_Optimized)

<div align="center">
  <video src="https://github.com/user-attachments/assets/36626b4a-d3e5-4db9-87a7-ca0e949daee0" />
</div> 


## ⭐ サポート
私のプロジェクトが気に入ったり、今後のアップデートや新機能を見たいと思った場合は、ぜひサポートをご検討ください。大きな助けになります！

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

## 🚀 インストール

```bash
git clone https://github.com/yuvraj108c/ComfyUI-FLOAT.git
cd ./ComfyUI-FLOAT
pip install -r requirements.txt
```

## ☀️ 使い方

- [サンプルワークフロー](https://raw.githubusercontent.com/yuvraj108c/ComfyUI-FLOAT/master/float_workflow.json) をロード
- ドライビング画像と音声をアップロードし、キューをクリック
- [モデル](https://huggingface.co/yuvraj108c/float/tree/main)は `/ComfyUI/models/float` に自動ダウンロードされます
- モデルの構成は以下の通りです:
    ```.bash
    |-- float.pth                                       # メインモデル
    |-- wav2vec2-base-960h/                             # 音声エンコーダ
    |   |-- config.json
    |   |-- model.safetensors
    |   |-- preprocessor_config.json
    |-- wav2vec-english-speech-emotion-recognition/     # 感情エンコーダ
        |-- config.json
        |-- preprocessor_config.json
        |-- pytorch_model.bin

## 🛠️ パラメータ
- `ref_image`: 顔が写っている参照画像（バッチサイズ1である必要があります）
- `ref_audio`: 参照音声（長尺の音声（例：3分以上）の場合は十分なRAM/VRAMが必要です）
- `a_cfg_scale`: 音声分類フリーガイダンススケール（デフォルト:2）
- `r_cfg_scale`: 参照分類フリーガイダンススケール（デフォルト:1）
- `emotion`: none, angry, disgust, fear, happy, neutral, sad, surprise（デフォルト:none）
- `e_cfg_scale`: 感情の強さ（デフォルト:1）。より強い感情表現の動画を作りたい場合は5～10の大きな値を試してください
- `crop`: 参照画像の顔が中央にない場合のみ有効化
- `fps`: 出力動画のフレームレート（デフォルト:25）

   
## 引用
```bibtex
@article{ki2024float,
  title={FLOAT: Generative Motion Latent Flow Matching for Audio-driven Talking Portrait},
  author={Ki, Taekyung and Min, Dongchan and Chae, Gyeongsu},
  journal={arXiv preprint arXiv:2412.01064},
  year={2024}
}
```

## 謝辞
GPUサーバーをご提供いただいた [simplepod.ai](https://simplepod.ai/) に感謝いたします。

## ライセンス

[クリエイティブ・コモンズ 表示-非営利-継承 4.0 国際（CC BY-NC-SA 4.0）](https://creativecommons.org/licenses/by-nc-sa/4.0/)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---