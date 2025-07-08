<div align="center">

# ComfyUI FLOAT 

[![python](https://img.shields.io/badge/python-3.10.12-green)](https://www.python.org/downloads/release/python-31012/)
[![arXiv](https://img.shields.io/badge/arXiv%20paper-2412.09013-b31b1b.svg)](https://arxiv.org/abs/2412.01064) 
[![by-nc-sa/4.0](https://img.shields.io/badge/license-CC--BY--NC--SA--4.0-lightgrey)](https://creativecommons.org/licenses/by-nc-sa/4.0/deed.en)

</div>

이 프로젝트는 오디오 기반 토킹 포트레이트를 위한 생성적 모션 잠복 흐름 매칭 [FLOAT](https://github.com/deepbrainai-research/float)의 ComfyUI 래퍼를 제공합니다.

더 발전되고 유지 관리되는 버전은 다음을 참고하세요: [ComfyUI-FLOAT_Optimized](https://github.com/set-soft/ComfyUI-FLOAT_Optimized)

<div align="center">
  <video src="https://github.com/user-attachments/assets/36626b4a-d3e5-4db9-87a7-ca0e949daee0" />
</div> 


## ⭐ 후원
제 프로젝트를 좋아하시고 업데이트 및 새로운 기능을 보고 싶으시다면, 후원을 고려해 주세요. 큰 도움이 됩니다! 

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

## 🚀 설치

```bash
git clone https://github.com/yuvraj108c/ComfyUI-FLOAT.git
cd ./ComfyUI-FLOAT
pip install -r requirements.txt
```

## ☀️ 사용법

- [예시 워크플로우](https://raw.githubusercontent.com/yuvraj108c/ComfyUI-FLOAT/master/float_workflow.json) 불러오기
- 구동 이미지와 오디오 업로드 후, 큐(Queue) 클릭
- [모델](https://huggingface.co/yuvraj108c/float/tree/main)이 `/ComfyUI/models/float`에 자동 다운로드됨
- 모델은 다음과 같이 구성되어 있습니다:
    ```.bash
    |-- float.pth                                       # 메인 모델
    |-- wav2vec2-base-960h/                             # 오디오 인코더
    |   |-- config.json
    |   |-- model.safetensors
    |   |-- preprocessor_config.json
    |-- wav2vec-english-speech-emotion-recognition/     # 감정 인코더
        |-- config.json
        |-- preprocessor_config.json
        |-- pytorch_model.bin

## 🛠️ 파라미터
- `ref_image`: 얼굴이 포함된 참조 이미지 (배치 크기 1이어야 함)
- `ref_audio`: 참조 오디오 (오디오가 길 경우(예: 3분 이상), 충분한 RAM/VRAM이 있는지 확인)
- `a_cfg_scale`: 오디오 분류기 프리 가이던스 스케일 (기본값:2)
- `r_cfg_scale`: 참조 분류기 프리 가이던스 스케일 (기본값:1)
- `emotion`: 없음(none), 화남(angry), 혐오(disgust), 두려움(fear), 행복(happy), 중립(neutral), 슬픔(sad), 놀람(surprise) (기본값:none)
- `e_cfg_scale`: 감정 강도 (기본값:1). 더 강한 감정의 영상을 원할 경우 5~10의 큰 값을 시도
- `crop`: 참조 이미지에 얼굴이 중앙에 없을 때만 활성화
- `fps`: 출력 영상의 프레임레이트 (기본값:25)

   
## 인용
```bibtex
@article{ki2024float,
  title={FLOAT: Generative Motion Latent Flow Matching for Audio-driven Talking Portrait},
  author={Ki, Taekyung and Min, Dongchan and Chae, Gyeongsu},
  journal={arXiv preprint arXiv:2412.01064},
  year={2024}
}
```

## 감사의 글
GPU 서버를 제공해주신 [simplepod.ai](https://simplepod.ai/)에 감사드립니다.

## 라이선스

[크리에이티브 커먼즈 저작자표시-비영리-동일조건변경허락 4.0 국제(CC BY-NC-SA 4.0)](https://creativecommons.org/licenses/by-nc-sa/4.0/)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---