# JustDubit: 공동 오디오-비주얼 확산을 통한 비디오 더빙

[![Website](https://img.shields.io/badge/Project-Page-181717?logo=google-chrome)](https://justdubit.github.io)
[![Model](https://img.shields.io/badge/HuggingFace-Model-orange?logo=huggingface)](https://huggingface.co/justdubit/justdubit)
[![Dataset](https://img.shields.io/badge/HuggingFace-Dataset-blue?logo=huggingface)](https://huggingface.co/datasets/justdubit/audiovisual_translation_dub/settings)

## 📰 뉴스

- [2026/02/10] 🔥 코드, 체크포인트 및 데이터 공개
- [2026/01/29] 🔥 기술 보고서 공개


---

## 📄 초록

사운드와 시각 콘텐츠를 공동 생성하도록 사전 학습된 오디오-비주얼 기초 모델은 최근 멀티모달 생성 및 편집을 모델링하는 전례 없는 능력을 보여주며, 다운스트림 작업에 새로운 기회를 열었습니다.

이 작업들 중 비디오 더빙은 이러한 사전 지식으로부터 큰 혜택을 받을 수 있지만, 대부분 기존 솔루션은 여전히 실제 환경에서 어려움을 겪는 복잡하고 작업별 특화된 파이프라인에 의존합니다.

본 연구에서는 경량 LoRA를 통해 기초 오디오-비디오 확산 모델을 비디오-투-비디오 더빙에 적응시키는 단일 모델 접근법을 소개합니다. LoRA는 입력 오디오-비디오를 조건으로 하여 번역된 오디오와 동기화된 얼굴 움직임을 공동 생성할 수 있게 합니다.

이 LoRA를 학습하기 위해, 우리는 생성 모델 자체를 활용하여 동일 화자의 다국어 비디오 쌍을 합성합니다. 구체적으로, 단일 클립 내에서 언어가 전환되는 다국어 비디오를 생성한 후, 각 절반의 얼굴과 오디오를 다른 절반의 언어에 맞게 인페인팅합니다.

오디오-비주얼 모델의 풍부한 생성 사전 지식을 활용하여, 본 접근법은 화자 정체성과 입 모양 동기화를 보존하면서 복잡한 움직임과 실제 환경 동역학에 견고합니다. 우리는 본 접근법이 기존 더빙 파이프라인에 비해 향상된 시각적 충실도, 입 모양 동기화 및 견고성을 갖춘 고품질 더빙 비디오를 생성함을 입증합니다.

---

## 🚀 빠른 링크

| 리소스 | 설명 |
|----------|-------------|
| [**추론 파이프라인**](https://raw.githubusercontent.com/justdubit/just-dub-it/main/packages/ltx-pipelines/README.md) | JustDubit 파이프라인으로 비디오 더빙 실행 |
| [**학습 가이드**](https://raw.githubusercontent.com/justdubit/just-dub-it/main/packages/ltx-trainer/README.md) | 나만의 JustDubit LoRA 학습 |

---

## 📦 저장소 구조

```
just-dub-it/
├── packages/
│   ├── ltx-pipelines/     # Inference pipeline for video dubbing
│   │   └── README.md      # Pipeline usage guide
│   ├── ltx-trainer/       # Training tools for JustDubit LoRA
│   │   └── README.md      # Training guide
│   └── ltx-core/          # Core model components
└── README.md              # This file
```

---

## 🎬 추론

다음은 [파이프라인 README](https://raw.githubusercontent.com/justdubit/just-dub-it/main/packages/ltx-pipelines/README.md)를 참조하세요:
- 설치 지침
- 모델 체크포인트 다운로드
- 프롬프트 형식 가이드
- CLI 인수 참조

---

## 🏋️ 학습

다음은 [트레이너 README](https://raw.githubusercontent.com/justdubit/just-dub-it/main/packages/ltx-trainer/README.md)를 참조하세요:
- 데이터셋 다운로드 및 준비
- 전처리 파이프라인
- 학습 구성
- 다중 GPU 학습 설정




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-20

---