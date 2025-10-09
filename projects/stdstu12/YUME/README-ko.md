<div align="center">
<img src=assets/yume.png width="20%"/>
</div>

# Yume: 인터랙티브 월드 생성 모델

Yume는 텍스트, 이미지 또는 비디오 입력을 통해 인터랙티브하고 현실적이며 동적인 세계를 만드는 것을 목표로 하는 장기 프로젝트입니다.


<div align="center">




[![project page](https://img.shields.io/badge/Project-Page-2ea44f)](https://stdstu12.github.io/YUME-Project/)&nbsp;
[![arXiv](https://img.shields.io/badge/arXiv%20paper-2507.17744-b31b1b.svg)](https://arxiv.org/abs/2507.17744)&nbsp;
[![model](https://img.shields.io/badge/%F0%9F%A4%97%20Hugging%20Face-Model-blue)](https://huggingface.co/stdstu123/Yume-I2V-540P)&nbsp;
[![YouTube](https://badges.aleen42.com/src/youtube.svg)](https://www.youtube.com/watch?v=51VII_iJ1EM)&nbsp;

</div>

- 비디오 DiT를 위한 증류 레시피.
- [FramePack-Like](https://github.com/lllyasviel/FramePack) 학습 코드.
- DDP/FSDP 샘플링 지원을 통한 장기 비디오 생성 방법



## 🔧 설치
코드는 Python 3.10.0, CUDA 12.1 및 A100에서 테스트되었습니다.
```
./env_setup.sh fastvideo
pip install -r requirements.txt
```
코드 수정 후에는 반드시 `pip install .` 명령어를 실행해야 하며, 또는 수정된 파일을 직접 가상환경에 복사할 수도 있습니다. 예를 들어, `wan/image2video.py`를 수정했고 가상환경이 `yume`라면 다음 경로로 파일을 복사할 수 있습니다:  
`envs/yume/lib/python3.10/site-packages/wan/image2video.py`.

## 🚀 추론

### ODE  
이미지-투-비디오 생성을 위해 `--jpg_dir="./jpg"`로 입력 이미지 디렉토리를 지정하고 `--caption_path="./caption.txt"`로 텍스트 조건 입력을 제공합니다. 각 줄은 2초 길이의 비디오 출력을 제어하는 생성 인스턴스에 해당합니다.
```bash
# Download the model weights and place them in Path_To_Yume.
bash scripts/inference/sample_jpg.sh 
```
우리는 또한 `--test_data_dir="./val"`이 예제 데이터의 위치를 지정하는 `./val`의 데이터를 사용하여 비디오를 생성하는 것을 고려합니다.
```bash
# Download the model weights and place them in Path_To_Yume.
bash scripts/inference/sample.sh 
```
### SDE
우리는 TTS 샘플링을 수행하며, `args.sde`는 SDE 기반 샘플링 사용 여부를 제어합니다.
```bash
# Download the model weights and place them in Path_To_Yume.
bash scripts/inference/sample_tts.sh 
```
최적의 결과를 위해, Actual distance, Angular change rate (turn speed), View rotation speed를 0.1에서 10 범위 내로 유지하는 것을 권장합니다. 

주요 조정 지침:
1. Camera remains still (·) 실행 시, Actual distance 값을 줄이세요
2. Person stands still 실행 시, Angular change rate와 View rotation speed 값을 모두 줄이세요

이들 매개변수(Actual distance, Angular change rate, View rotation speed)는 생성 결과에 영향을 미칩니다. 간단한 작업을 위해 이 매개변수들을 완전히 제거하는 방법도 고려할 수 있습니다.



## 🎯 Training & Distill 
모델 훈련을 위해 `args.MVDT`를 사용하여 MVDT 프레임워크를 실행하며, 최소 16개의 A100 GPU가 필요합니다. T5를 CPU에 로드하면 GPU 메모리를 절약하는 데 도움이 됩니다. `args.Distil`을 사용하여 적대적 증류를 활성화합니다.

```bash
# Download the model weights and place them in Path_To_Yume.
bash scripts/finetune/finetune.sh
```

## 🧱 데이터셋 준비
데이터셋 다운로드는 https://github.com/Lixsp11/sekai-codebase 를 참조하세요. 처리된 데이터 형식은 `./test_video`를 참조하세요.
```
path_to_processed_dataset_folder/
├── Keys_None_Mouse_Down/ 
│   ├── video_id.mp4
│   ├── video_id.txt
├── Keys_None_Mouse_Up
│──  ...
└── Keys_S_Mouse_·
```
제공된 TXT 파일 내용은 카메라 모션 제어 매개변수 또는 애니메이션 키프레임 데이터를 기록하며, 다음과 같은 필드 정의를 포함합니다:
```
Start Frame: 2 #Starting frame number (begins at frame 2 at origin video)

End Frame: 50 #Ending frame number

Duration: 49 frames #Total duration

Keys: W #Keyboard input

Mouse: ↓ #Mouse action
```
`scripts/finetune/finetune.sh`에서 `args.root_dir`는 `path_to_processed_dataset_folder`를 나타내며, `args.root_dir`는 Sekai 데이터셋의 전체 경로를 나타냅니다.


## 📑 개발 계획
- 데이터셋 처리
  - [ ] 처리된 데이터셋 제공
- 코드 업데이트
  - [ ] fp8 지원
  - [ ] 더 나은 증류 방법
- ​​모델 업데이트
  - [ ] 양자화 및 증류된 모델
  - [ ] 720p 해상도 생성용 모델​

## 🤝 기여
모든 기여를 환영합니다.


## 감사의 말씀
다음 프로젝트에서 코드 학습 및 재사용을 하였습니다:
- [FastVideo](https://github.com/hao-ai-lab/FastVideo)
- [diffusers](https://github.com/huggingface/diffusers)
- [HunyuanVideo-I2V](https://github.com/Tencent-Hunyuan/HunyuanVideo-I2V)
- [Wan2.1](https://github.com/Wan-Video/Wan2.1)
- [Skywork-Reward-V2](https://github.com/SkyworkAI/Skywork-Reward-V2)
- [MDT](https://github.com/sail-sg/MDT)
- [AddSR](https://github.com/NJU-PCALab/AddSR)

## 인용
연구에 Yume를 사용하신다면, 저희 논문을 인용해 주세요:

```bibtex
@article{mao2025yume,
  title={Yume: An Interactive World Generation Model},
  author={Mao, Xiaofeng and Lin, Shaoheng and Li, Zhen and Li, Chuanhao and Peng, Wenshuo and He, Tong and Pang, Jiangmiao and Chi, Mingmin and Qiao, Yu and Zhang, Kaipeng},
  journal={arXiv preprint arXiv:2507.17744},
  year={2025}
}

```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-09

---