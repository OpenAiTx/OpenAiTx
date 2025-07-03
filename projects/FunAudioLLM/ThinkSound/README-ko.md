# 🎶 ThinkSound

<p align="center">
  이 프로젝트가 유용하다면, GitHub에서 별표 ⭐를 눌러주시면 큰 힘이 됩니다!
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

---

**ThinkSound**는 Chain-of-Thought (CoT) 추론이 적용된 Flow Matching 기반의 통합 Any2Audio 생성 프레임워크입니다.

멀티모달 대형 언어 모델(MLLM)의 단계별 추론을 활용하여, 비디오, 텍스트, 오디오로부터 오디오를 생성하거나 편집하는 PyTorch 구현체입니다.

![Teaser](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig1_teaser.png)
---

## 📰 새 소식
- **2025.07** &nbsp; 🔥[Hugging Face Spaces](https://huggingface.co/spaces/FunAudioLLM/ThinkSound) 및 [ModelScope](https://modelscope.cn/studios/iic/ThinkSound)에서 온라인 데모 및 인터랙티브 체험 제공!
- **2025.07** &nbsp; 🔥추론 스크립트 및 웹 인터페이스 공개; 
- **2025.06** &nbsp; 🔥[ThinkSound 논문](https://arxiv.org/pdf/2506.21448) arXiv 공개!
- **2025.06** &nbsp; 🔥[온라인 데모](http://thinksound-project.github.io/) 오픈 - 지금 바로 체험해 보세요!

---

## 🚀 주요 특징

- **Any2Audio**: 비디오, 텍스트, 오디오 및 이들의 조합 등 임의의 모달리티로부터 오디오 생성.
- **비디오-투-오디오 SOTA**: 다양한 V2A 벤치마크에서 최첨단 성능 달성.
- **CoT 기반 추론**: MLLM 기반 단계별 Chain-of-Thought 추론을 통한 합성 및 제어 가능한 오디오 생성.
- **인터랙티브 객체 중심 편집**: 비주얼 객체 클릭 또는 텍스트 지시어로 특정 사운드 이벤트를 세밀하게 보정 및 편집.
- **통합 프레임워크**: 하나의 기반 모델로 생성, 편집, 인터랙티브 워크플로우 지원.

---

## ✨ 방법 개요

ThinkSound는 오디오 생성 및 편집을 MLLM 기반 Chain-of-Thought(CoT) 추론이 이끄는 세 가지 인터랙티브 단계로 분해합니다:

1. **폴리(foley) 생성:** 비디오와 의미적·시간적으로 정렬된 기초 사운드스케이프 생성.
2. **객체 중심 정제:** 비디오 내 사용자가 지정한 객체(클릭 또는 영역)를 기준으로 사운드 추가/정제.
3. **타겟 오디오 편집:** 고수준 자연어 지시어를 활용해 생성된 오디오를 수정.

![ThinkSound Overview](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig3_model.png)
<!-- 대규모 CoT 주석 데이터셋(**AudioCoT**)으로 추론 모듈과 통합 오디오 기반 모델 모두를 학습.
![AudioCoT Pipeline](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig2_dataset.png) -->

---

## ⚡ 빠른 시작

**환경 준비:**
```bash
git clone https://github.com/liuhuadai/ThinkSound.git
cd ThinkSound
pip install -r requirements.txt
conda install -y -c conda-forge 'ffmpeg<7'
# 사전학습 가중치 다운로드 https://huggingface.co/liuhuadai/ThinkSound → ckpts/ 디렉토리
# 모델 가중치는 https://www.modelscope.cn/models/iic/ThinkSound 에서도 다운로드 가능
git lfs install
git clone https://huggingface.co/liuhuadai/ThinkSound ckpts
```

**실행 권한 부여**
```bash
chmod +x scripts/demo.sh
```

**스크립트 실행**
```bash
./scripts/demo.sh <video_path> <caption> <CoT description>
```


### 웹 인터페이스 사용법

인터랙티브 체험을 원한다면, Gradio 웹 인터페이스를 실행하세요:

```bash
python app.py
```

---
## 📝 TODO

- ☐ ThinkSound 모델용 학습 스크립트 공개
- ☐ AudioCoT 데이터셋 및 자동화 파이프라인 오픈소스화
- ☐ 상세한 문서 및 API 레퍼런스 제공
- ☐ 추가 모달리티 및 다운스트림 태스크 지원 추가

---

## 📄 라이선스

이 프로젝트는 [Apache 2.0 라이선스](LICENSE) 하에 공개됩니다.

> **참고:**  
> 코드, 모델, 데이터셋은 **연구 및 교육 목적으로만 사용 가능합니다.**  
> **상업적 사용은 허가되지 않습니다.**
>
> 상업적 라이선스가 필요하신 경우, 저자에게 문의해 주세요.

---

## 📖 인용

ThinkSound가 연구나 작업에 유용하다면, 아래의 논문을 인용해 주세요:

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

✨ 궁금한 점이나 제안사항이 있으시면 [이슈를 등록](https://github.com/liuhuadai/ThinkSound/issues)하시거나 이메일([liuhuadai@zju.edu.cn](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/mailto:liuhuadai@zju.edu.cn))로 연락해 주세요!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-03

---