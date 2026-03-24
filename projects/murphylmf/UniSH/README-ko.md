<div align="center">

# UniSH: 피드포워드 패스에서 장면과 인간 재구성의 통합


**Mengfei Li**<sup>1</sup>, **Peng Li**<sup>1</sup>, **Zheng Zhang**<sup>2</sup>, **Jiahao Lu**<sup>1</sup>, **Chengfeng Zhao**<sup>1</sup>, **Wei Xue**<sup>1</sup>,
<br>
**Qifeng Liu**<sup>1</sup>, **Sida Peng**<sup>3</sup>, **Wenxiao Zhang**<sup>1</sup>, **Wenhan Luo**<sup>1</sup>, **Yuan Liu**<sup>1†</sup>, **Yike Guo**<sup>1†</sup>

<sup>1</sup>홍콩과기대, <sup>2</sup>북경우전대, <sup>3</sup>절강대

<br>

<a href="https://arxiv.org/abs/2601.01222" target="_blank"><img src="https://img.shields.io/badge/arXiv-Paper-b31b1b.svg" alt="arXiv"></a>
<a href="https://murphylmf.github.io/UniSH/" target="_blank"><img src="https://img.shields.io/badge/Project-Page-orange" alt="Project Page"></a>
<a href="https://huggingface.co/spaces/Murphyyyy/UniSH" target="_blank"><img src="https://img.shields.io/badge/%F0%9F%A4%97%20Hugging%20Face-Spaces-yellow" alt="Hugging Face Demo"></a>
<a href="https://huggingface.co/Murphyyyy/UniSH" target="_blank"><img src="https://img.shields.io/badge/%F0%9F%A4%97%20Hugging%20Face-Model-blue" alt="Hugging Face Model"></a>
<a href="LICENSE" target="_blank"><img src="https://img.shields.io/badge/License-Apache_2.0-green.svg" alt="License"></a>

</div>

---

### TL;DR
단안 비디오를 입력으로 받아, UniSH는 단일 순전파로 장면과 인간을 공동으로 재구성할 수 있어, 장면 기하학, 카메라 매개변수 및 SMPL 매개변수의 효과적인 추정이 가능합니다.


<video src="static/teaser_video_final.mp4" autoplay loop muted playsinline width="100%"></video>

<img src="https://raw.githubusercontent.com/murphylmf/UniSH/main/static/teaser.svg" width="100%" style="background-color: white;">

## 🛠️ 설치

대부분의 Linux 서버(헤드리스 서버 포함)에서 작동하는 **sudo 권한 불필요** 설치 방법을 제공합니다.

### 1단계: 저장소 클론하기

```bash
git clone https://github.com/murphylmf/UniSH.git
cd UniSH
```
### 2단계: Conda 환경 생성
이 단계에서는 Python, 시스템 컴파일러 및 OpenGL 드라이버를 설치합니다.


```bash
conda env create -f environment.yml
conda activate unish
```
### 3단계: 종속성 컴파일
이 스크립트는 2단계에서 설치한 컴파일러를 사용하여 PyTorch3D, MMCV 및 SAM2를 소스에서 컴파일합니다.

환경은 **CUDA 12.1** 및 **CUDA 11.8**에서 테스트되었습니다. 설치 스크립트에 인수로 CUDA 버전을 지정할 수 있습니다.


```bash
# Default (Auto-detect or 12.1)
bash install.sh

# For CUDA 11.8
bash install.sh 11.8

# For CUDA 12.1
bash install.sh 12.1
```

### 4단계: SMPL 모델 다운로드
[SMPL](https://smpl.is.tue.mpg.de/) 모델을 다운로드하여 `body_models` 폴더에 배치하세요.
디렉터리 구조는 다음과 같이 구성되어야 합니다:

```text
UniSH/
├── body_models/
│   └── smpl/
│       └── smpl/
│           ├── SMPL_FEMALE.pkl
│           ├── SMPL_MALE.pkl
│           └── SMPL_NEUTRAL.pkl
```

## 🚀 빠른 시작 (추론)

### 추론 실행
다음 명령어를 실행하여 비디오에서 장면과 사람을 재구성합니다:

```bash
python inference.py --output_dir inference_results/example --video_path examples/example_video.mp4 
```

추가 매개변수에 대한 자세한 내용은 `inference.py`를 참조하십시오.

## 📝 인용

이 코드를 연구에 유용하게 사용하셨다면, 저희 논문을 인용해 주시기 바랍니다:

```bibtex
@misc{li2026unishunifyingscenehuman,
      title={UniSH: Unifying Scene and Human Reconstruction in a Feed-Forward Pass}, 
      author={Mengfei Li and Peng Li and Zheng Zhang and Jiahao Lu and Chengfeng Zhao and Wei Xue and Qifeng Liu and Sida Peng and Wenxiao Zhang and Wenhan Luo and Yuan Liu and Yike Guo},
      year={2026},
      eprint={2601.01222},
      archivePrefix={arXiv},
      primaryClass={cs.CV},
      url={https://arxiv.org/abs/2601.01222}, 
}
```
## 🙏 감사의 글

다음 프로젝트들의 훌륭한 기여에 감사드립니다:

* [GVHMR](https://github.com/zju3dv/GVHMR)
* [BEDLAM](https://bedlam.is.tue.mpg.de/)
* [SMPL](https://smpl.is.tue.mpg.de/)
* [VGGT](https://github.com/facebookresearch/vggt)
* [Pi3](https://github.com/yyfz/Pi3)
* [MoGe2](https://github.com/microsoft/moge)

## 📄 라이선스
이 프로젝트는 Apache 2.0 라이선스 하에 배포됩니다. 자세한 내용은 [LICENSE](LICENSE)를 참조하세요.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-24

---