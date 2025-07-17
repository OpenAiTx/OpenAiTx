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
    <img src="https://img.shields.io/badge/ModelScope-在线体验-green" alt="ModelScope"/>
  </a>
</p>

<p align="center">
  이 프로젝트가 유용하다면,<br>
  GitHub에 별표 ⭐를 남겨주시면 감사하겠습니다!
</p>

---

**ThinkSound**는 Chain-of-Thought (CoT) 추론에 의해 안내되는 플로우 매칭 기반의 통합 Any2Audio 생성 프레임워크입니다.

멀티모달 대형 언어 모델(MLLM)의 단계별 추론으로 구동되는: 비디오, 텍스트, 오디오로부터 오디오를 생성하거나 편집하는 PyTorch 기반 멀티모달 오디오 생성 및 편집 구현체입니다.

![Teaser](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig1_teaser.png)
---

## 📰 새 소식
- **2025.07.17** &nbsp; 🧠 파인튜닝 지원: 훈련 및 파인튜닝 코드가 공개되었으며, ThinkSound를 여러분의 데이터로 커스터마이즈 및 확장할 수 있도록 명확한 사용법 안내를 포함합니다.
- **2025.07.15** &nbsp; 📦 설치 및 사용성 단순화: PyPI 의존성으로 손쉬운 크로스 플랫폼 환경 구축; Windows `.bat` 스크립트로 환경 생성 및 스크립트 실행 자동화.
- **2025.07.08** &nbsp;  🔧 대규모 업데이트: 모델 경량화 및 메모리/GPU 사용 최적화, 대규모 고처리량 오디오 생성 지원!
- **2025.07.01** &nbsp; 🔥[Hugging Face Spaces](https://huggingface.co/spaces/FunAudioLLM/ThinkSound) 및 [ModelScope](https://modelscope.cn/studios/iic/ThinkSound)에서 온라인 데모 제공 - 직접 체험해보세요!
- **2025.07.01** &nbsp; 🔥추론 스크립트 및 웹 인터페이스 공개; 
- **2025.06** &nbsp; 🔥[ThinkSound 논문](https://arxiv.org/pdf/2506.21448) arXiv 공개!
- **2025.06** &nbsp; 🔥[온라인 데모](http://thinksound-project.github.io/) 오픈 - 지금 바로 사용해보세요!

---


## 🚀 특징

- **Any2Audio**: 비디오, 텍스트, 오디오 또는 이들의 조합 등 임의의 모달리티에서 오디오 생성.
- **Video-to-Audio SOTA**: 다수의 V2A 벤치마크에서 최첨단 성능 달성.
- **CoT 기반 추론**: MLLM을 통한 조합적이고 제어 가능한 오디오 생성을 위한 Chain-of-Thought 추론.
- **인터랙티브 오브젝트 중심 편집**: 시각적 객체 클릭 또는 텍스트 명령으로 특정 사운드 이벤트를 정교하게 수정·편집.
- **통합 프레임워크**: 하나의 파운데이션 모델로 생성, 편집, 인터랙티브 워크플로우 지원.

---

## ✨ 방법 개요

ThinkSound는 오디오 생성 및 편집을 MLLM 기반 Chain-of-Thought(Cot) 추론으로 안내되는 3단계 상호작용적 과정으로 분해합니다:

1. **폴리(Foley) 생성:** 비디오로부터 의미적·시간적으로 정렬된 기초 사운드스케이프 생성.
2. **오브젝트 중심 정교화:** 비디오 내 사용자가 지정한 객체(클릭 또는 영역)를 대상으로 오디오 추가/수정.
3. **목표 지향 오디오 편집:** 고수준 자연어 지시로 생성된 오디오 수정.

![ThinkSound Overview](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig3_model.png)
<!-- 대규모 CoT 주석 데이터셋(**AudioCoT**)을 사용하여 추론 모듈과 통합 오디오 파운데이션 모델을 모두 훈련합니다.
![AudioCoT Pipeline](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig2_dataset.png) -->

---

## ⚡ 빠른 시작

**환경 준비:**
```bash
git clone https://github.com/liuhuadai/ThinkSound.git
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
## 🏋️ 모델 학습하기

[`Training.md`](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/docs/Training.md)를 참고하세요.


---

## 📝 TODO & 향후 계획
* - [ ] AudioCoT 데이터셋 및 자동화 파이프라인 오픈 소스화 (2025년 7월 23일 전 예정)
* - [ ] 더 다양한 도메인을 아우르는 강력한 파운데이션 모델 공개, 몰입감 높은 폴리 생성 지원 (2025년 8월 말까지 예정)
* - [ ] 추가 모달리티 및 다운스트림 태스크 지원 추가 (2025년 7월 말 전 예정)
* - [ ] 다양한 스케일의 모델 공개 (2025년 7월 말 전 예정)
* - [x] ThinkSound 모델 학습 스크립트 공개
* - [x] 초보자 친화적인 Windows 빠른 시작 README
---


## 📄 라이선스

이 프로젝트는 Apache 2.0 라이선스로 공개됩니다.

> **참고:**
> 코드, 모델, 데이터셋은 **연구 및 교육 목적에 한정**하여 사용 가능합니다.
> **상업적 사용은 허용되지 않습니다.**
> 상업적 라이선스가 필요한 경우 저자에게 문의하십시오.

**📦 서드파티 구성요소**

* **Stable Audio Open VAE** (Stability AI 제공):
  본 저장소에는 [Stable Audio Open](https://huggingface.co/stabilityai/stable-audio-open-1.0/)에서 파인튜닝된 VAE가 포함되어 있으며, [Stability AI 커뮤니티 라이선스](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/./third_party/LICENSE_StabilityAI.md) 하에 배포됩니다.
  **상업적 사용 및 재배포는 Stability AI의 사전 허가가 필요합니다.**

* 📘 **기타 모든 코드 및 모델**은 Apache License 2.0 하에 공개됩니다.

---

## 감사의 말씀

다음에 깊은 감사를 드립니다:

* **stable-audio-tools** (Stability AI 제공):
오디오 생성 프레임워크 및 VAE 모듈/가중치 제공에 감사드립니다.
* **MMAudio**:
  오디오 도메인의 MM-DiT 백본 구현에 감사드립니다.

---

## 📖 인용

ThinkSound가 연구나 업무에 도움이 되었다면 아래 논문을 인용해 주세요:



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
```
---

## 📬 연락처

✨ 문의 사항이나 제안이 있으시면 [이슈를 등록](https://github.com/liuhuadai/ThinkSound/issues)하시거나 이메일([liuhuadai@zju.edu.cn](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/mailto:liuhuadai@zju.edu.cn))로 언제든지 연락해 주세요!


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-17

---