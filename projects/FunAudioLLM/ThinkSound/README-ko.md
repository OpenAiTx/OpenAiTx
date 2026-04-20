<h1 align="center">ThinkSound</h1>

<p align="center">
  🌐
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=en">English</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=zh-CN">简体中文</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=zh-TW">繁體中文</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=es">Español</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=fr">Français</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=ja">日本語</a>
  
</p>
<p align="center">
  <img src="https://img.shields.io/badge/NeurIPS%202025-Main%20Conference-blue.svg" alt="NeurIPS 2025"/>
  &nbsp;
  <a href="https://arxiv.org/pdf/2506.21448">
    <img src="https://img.shields.io/badge/arXiv-2506.21448-b31b1b.svg" alt="arXiv"/>
  </a>
  &nbsp;
  <a href="https://thinksound-project.github.io/">
    <img src="https://img.shields.io/badge/Online%20Demo-🌐-blue" alt="Online Demo"/>
  </a>
  &nbsp;
  <a href="https://huggingface.co/spaces/FunAudioLLM/ThinkSound">
    <img src="https://img.shields.io/badge/HuggingFace-Spaces-orange?logo=huggingface" alt="Hugging Face"/>
  </a>
  &nbsp;
  <a href="https://modelscope.cn/studios/iic/ThinkSound">
    <img src="https://img.shields.io/badge/ModelScope-온라인%20체험-green" alt="ModelScope"/>
  </a>
</p>

<p align="center">
  이 프로젝트가 유용하다면,<br>
  GitHub에서 별표 ⭐를 눌러주시면 큰 도움이 됩니다!
</p>

---

## 저장소 구조

이 **ThinkSound** GitHub 저장소는 두 개의 관련 프로젝트를 별도의 브랜치에서 관리합니다:

| 브랜치 | 프로젝트 | 문서 |
|--------|---------|----------------|
| **`master`** | **ThinkSound** (NeurIPS 2025) — CoT 기반 플로우 매칭을 적용한 통합 Any2Audio 생성 | 이 파일: **`README.md`** |
| **`prismaudio`** | **PrismAudio** — 영상-오디오 변환 및 다차원 CoT-RL 후속 연구 (ICLR 2026) | [`prismaudio`](https://github.com/liuhuadai/ThinkSound/tree/prismaudio) 브랜치 내 **`README.md`** |

**ThinkSound**를 사용하려면 **`master`** 브랜치(이 README)를, **PrismAudio**는 **`prismaudio`** 브랜치로 이동하여 그 곳의 **`README.md`**를 참고하세요.

---

**ThinkSound**는 Chain-of-Thought(Cot) 추론이 이끄는 플로우 매칭 기반의 통합 Any2Audio 생성 프레임워크입니다.

비디오, 텍스트, 오디오로부터 오디오를 생성하거나 편집할 수 있는 멀티모달 오디오 생성 및 편집을 위한 PyTorch 구현체로, 멀티모달 대형 언어 모델(MLLM)의 단계적 추론을 활용합니다.

![Teaser](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig1_teaser.png)
---

## 📰 새 소식
- **2026.03.24** &nbsp; 🔥 **PrismAudio**가 동일 저장소의 [`prismaudio`](https://github.com/liuhuadai/ThinkSound/tree/prismaudio) 브랜치에서 공개 — 설치 및 모델 정보는 **`README.md`** 참고.
- **2026.01.26** &nbsp; 🎉 PrismAudio, **ICLR 2026 메인 컨퍼런스**에 채택(코드/문서는 `prismaudio` 참고).
- **2025.11.25** &nbsp; 🔥 [온라인 PrismAudio 데모](http://prismaudio-project.github.io/) 서비스 오픈.
- **2025.11.25** &nbsp; 🔥 [PrismAudio 논문](https://arxiv.org/pdf/2511.18833) arXiv 공개 — 영상-오디오 다차원 CoT-RL 기법.
- **2025.09.19** &nbsp; 🎉 **ThinkSound**가 **NeurIPS 2025 메인 컨퍼런스**에 채택!
- **2025.09.01** &nbsp; AudioCoT 데이터셋이 오픈소스로 [Hugging Face](https://huggingface.co/datasets/liuhuadai/AudioCoT)에서 공개!
- **2025.07.17** &nbsp; 🧠 파인튜닝 지원: 학습 및 파인튜닝 코드 공개, 사용법 안내와 함께 개인 데이터로 ThinkSound를 확장 가능.
- **2025.07.15** &nbsp; 📦 간편한 설치 및 사용성: PyPI 기반 의존성, 윈도우 `.bat` 스크립트로 환경 구축 및 실행 자동화.
- **2025.07.08** &nbsp;  🔧 대규모 업데이트: 모델 경량화, 메모리 및 GPU 최적화로 대용량 오디오 생성 지원!
- **2025.07.01** &nbsp; [Hugging Face Spaces](https://huggingface.co/spaces/FunAudioLLM/ThinkSound), [ModelScope](https://modelscope.cn/studios/iic/ThinkSound) 온라인 데모 공개!
- **2025.07.01** &nbsp; 추론 스크립트 및 웹 인터페이스 공개;
- **2025.06** &nbsp; [ThinkSound 논문](https://arxiv.org/pdf/2506.21448) arXiv 공개!
- **2025.06** &nbsp; [온라인 데모](http://thinksound-project.github.io/) 서비스 오픈 - 지금 바로 체험!

---


<div align="center">

### 후속 프로젝트: PrismAudio (동일 저장소, `prismaudio` 브랜치)

**PrismAudio**는 ThinkSound(ICLR 2026)의 후속 프로젝트로, 새로운 이름으로 개발되었지만 이 저장소의 **`prismaudio`** 브랜치에서 관리되고 있습니다. 설치, 체크포인트, 인용 방법은 **[해당 브랜치의 `README.md`](https://github.com/liuhuadai/ThinkSound/blob/prismaudio/README.md)**에서 확인할 수 있습니다.

👉 [`git checkout prismaudio`](https://github.com/liuhuadai/ThinkSound/tree/prismaudio) 또는 GitHub에서 해당 브랜치를 여세요.

</div>

---


## 🚀 주요 기능

- **Any2Audio**: 영상, 텍스트, 오디오 또는 이들의 조합 등 임의의 모달리티로부터 오디오 생성.
- **Video-to-Audio SOTA**: 여러 V2A 벤치마크에서 최첨단 성능 달성.
- **CoT 기반 추론**: MLLM을 통한 조합적·제어 가능한 오디오 생성을 위한 Chain-of-Thought 추론.
- **인터랙티브 객체 중심 편집**: 시각적 객체 클릭이나 텍스트 지시로 특정 사운드 이벤트를 정제·편집.
- **통합 프레임워크**: 단일 기반 모델로 생성, 편집, 인터랙티브 워크플로우 지원.

---

## ✨ 방법 개요

ThinkSound는 오디오 생성 및 편집을 MLLM 기반 Chain-of-Thought(CoT) 추론에 의해 안내되는 세 가지 상호작용 단계로 분해합니다:

1. **폴리 생성:** 영상에서 의미적, 시간적으로 정렬된 기본 사운드스케이프 생성.
2. **객체 중심 정제:** 영상 내 클릭 또는 영역 지정을 통해 사용자 지정 객체의 소리를 정제 또는 추가.
3. **타겟 오디오 편집:** 고수준 자연어 지시로 생성된 오디오를 수정.

![ThinkSound 개요](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig3_model.png)
<!-- 대규모 CoT 주석 데이터셋(**AudioCoT**)은 추론 모듈과 통합 오디오 기반 모델 학습에 사용됩니다.
![AudioCoT 파이프라인](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig2_dataset.png) -->

---

## ⚡ 빠른 시작

**환경 준비:**
```bash
# ThinkSound code: branch master. PrismAudio: clone with -b prismaudio (see README.md on that branch).
git clone -b master https://github.com/liuhuadai/ThinkSound.git
cd ThinkSound
conda create -n thinksound python=3.10
conda activate thinksound
pip install thinksound
conda install -y -c conda-forge 'ffmpeg<7'
# Download pretrained weights https://huggingface.co/liuhuadai/ThinkSound to Directory ckpts/
# model weights can be also downloaded from https://www.modelscope.cn/models/iic/ThinkSound
git lfs install
git clone https://huggingface.co/liuhuadai/ThinkSound ckpts
# To improve inference and training speed, you may optionally install a FlashAttention backend compatible with your system and PyTorch version.
```
> ✅ **Windows 팁:**  
> Windows 사용자는 `setup_windows.bat` 파일을 실행(또는 더블 클릭)하면 콘다 환경이 자동으로 생성되고, 모든 종속성(FFmpeg 포함)과 사전 학습된 모델이 다운로드됩니다 — 별도의 수동 설정이 필요하지 않습니다.  
> 스크립트를 실행하기 전에 `conda`와 `git`이 시스템 PATH에 설치되어 있고 사용 가능한지 확인하세요.


### ▶️ 데모 실행

#### **Linux/macOS**


```bash
chmod +x scripts/demo.sh
./scripts/demo.sh <path-to-your-demo-video> <title> <CoT description> [use-half]
```
#### **Windows**

대신 제공된 `.bat` 스크립트를 사용할 수 있습니다:


```bash
.\scripts\demo.bat <path-to-your-demo-video> <title> <CoT description> [use-half]
```
**참고:**

* `<path-to-your-demo-video>`: 단일 비디오의 경로
* `[use-half]` (선택사항): 마지막에 use-half를 추가하여 하프 프리시전 특징 추출을 활성화합니다.

---

### 📦 배치 추론

#### **Linux/macOS**


```bash
chmod +x scripts/eval_batch.sh
./scripts/eval_batch.sh <video_path> <csv_path> <save_path (optional)> [use-half]
```
#### **Windows**

동등한 `.bat` 스크립트를 사용하세요:


```bash
.\scripts\eval_batch.bat <video_path> <csv_path> <save_path (optional)> [use-half]
```
**참고:**

* `<video_path>`: 처리할 모든 .mp4 비디오가 포함된 루트 디렉터리의 경로 (모든 비디오는 동일한 길이여야 합니다).
* `<csv_path>`: 각 비디오에 대한 텍스트 프롬프트가 포함된 CSV 파일 (`demo_test.csv`에서 형식 참고).
* `<save_path>` (선택사항): 생성된 오디오를 저장할 위치. 기본값은 `results/features`입니다.
* `[use-half]` (선택사항): 마지막에 use-half를 추가하면 하프 프리시전 특징 추출이 활성화됩니다.

---


### 웹 인터페이스 사용법

인터랙티브한 경험을 위해 Gradio 웹 인터페이스를 실행하세요:


```bash
python app.py
```
## 🏋️ 모델 학습

[`Training.md`](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/docs/Training.md)를 참고하세요.


---


## 📄 라이선스

이 프로젝트는 Apache 2.0 라이선스 하에 공개됩니다.

> **참고:**
> 코드, 모델 및 데이터셋은 **연구 및 교육 목적으로만 사용**해야 합니다.
> **상업적 사용은 허용되지 않습니다.**
> 상업적 라이선스가 필요할 경우 저자에게 문의해 주십시오.

**📦 서드파티 구성 요소**

* **Stable Audio Open VAE** (Stability AI 제공):
  이 저장소는 [Stable Audio Open](https://huggingface.co/stabilityai/stable-audio-open-1.0/)에서 파인튜닝된 VAE를 포함하며, [Stability AI Community License](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/./third_party/LICENSE_StabilityAI.md) 하에 라이선스됩니다.
  **상업적 사용 및 재배포는 Stability AI의 사전 허가가 필요합니다.**

* 📘 **기타 모든 코드 및 모델**은 Apache License 2.0 하에 공개됩니다.

---

## 감사의 말씀

다음 분들께 깊이 감사드립니다:

* **stable-audio-tools** (Stability AI 제공):
오디오 생성 및 VAE 모듈과 가중치 제공을 위한 손쉬운 프레임워크를 제공해주셨습니다.
* **MMAudio**:
  오디오 도메인에서 MM-DiT 백본 구현을 제공해주셨습니다.

---



## 📖 인용

본 프로젝트가 연구나 작업에 유용하다면, 저희 논문을 인용해 주시기 바랍니다:

```bibtex
@misc{liu2025thinksoundchainofthoughtreasoningmultimodal,
      title={ThinkSound: Chain-of-Thought Reasoning in Multimodal Large Language Models for Audio Generation and Editing}, 
      author={Huadai Liu and Jialei Wang and Kaicheng Luo and Wen Wang and Qian Chen and Zhou Zhao and Wei Xue},
      year={2025},
      eprint={2506.21448},
      archivePrefix={arXiv},
      primaryClass={eess.AS},
      url={https://arxiv.org/abs/2506.21448}, 
}
@misc{liu2025prismaudiodecomposedchainofthoughtsmultidimensional,
          title={PrismAudio: Decomposed Chain-of-Thoughts and Multi-dimensional Rewards for Video-to-Audio Generation}, 
          author={Huadai Liu and Kaicheng Luo and Wen Wang and Qian Chen and Peiwen Sun and Rongjie Huang and Xiangang Li and Jieping Ye and Wei Xue},
          year={2025},
          eprint={2511.18833},
          archivePrefix={arXiv},
          primaryClass={cs.SD},
          url={https://arxiv.org/abs/2511.18833}, 
    }
```

---

## 📬 Contact


✨ Feel free to [open an issue](https://github.com/liuhuadai/ThinkSound/issues) or contact us via email ([liuhuadai@zju.edu.cn](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/mailto:liuhuadai@zju.edu.cn)) if you have any questions or suggestions!





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-20

---