![image.png](https://raw.githubusercontent.com/AgibotTech/genie_sim/main/./docs/image.jpg)
<div align="center">
  <a href="https://github.com/AgibotTech/genie_sim">
    <img src="https://img.shields.io/badge/GitHub-grey?logo=GitHub" alt="GitHub">
  </a>
  <a href="https://huggingface.co/datasets/agibot-world/GenieSimAssets">
    <img src="https://img.shields.io/badge/HuggingFace-yellow?logo=HuggingFace" alt="HuggingFace">
  </a>
  <a href="https://agibot-world.com/sim-evaluation">
    <img src="https://img.shields.io/badge/Genie%20Sim%20Benchmark-blue?style=plastic" alt="Genie Sim Benchmark">
  </a>
  <a href="https://genie.agibot.com/en/geniestudio">
    <img src="https://img.shields.io/badge/Genie_Studio-green?style=flat" alt="Genie Studio">
  </a>
</div>

# 1. Genie Sim 벤치마크
Genie Sim은 AgiBot에서 개발한 시뮬레이션 프레임워크로, 개발자에게 효율적인 데이터 생성 기능과 평가 벤치마크를 제공하여 임베디드 지능 개발을 가속화합니다. Genie Sim은 궤적 생성, 모델 학습, 벤치마킹, 배포 검증까지 아우르는 포괄적인 클로즈드 루프 파이프라인을 구축하였습니다. 사용자는 이 효율적인 시뮬레이션 툴체인을 통해 알고리즘 성능을 빠르게 검증하고 모델을 최적화할 수 있습니다. 단순한 집기 작업부터 복잡한 장거리 작업에 이르기까지, Genie Sim은 매우 현실감 있는 시뮬레이션 환경과 정밀한 평가 지표를 제공하여 개발자가 로봇 기술의 개발 및 반복을 효율적으로 완료할 수 있도록 지원합니다.

Genie Sim 벤치마크는 Genie Sim의 오픈소스 평가 버전으로, 임베디드 AI 모델의 정밀한 성능 테스트 및 최적화 지원을 목표로 합니다.

# 2. 주요 특징
- 유연하고 사용하기 쉬운 시뮬레이션 구성 및 인터페이스
- 10개 이상의 조작 작업에 대한 시뮬레이션 벤치마크 및 평가 과제
- VR 및 키보드 기반의 원격 조작 기능
- 모든 관절 및 엔드 이펙터 포즈 기록 및 재생
- 550개 이상의 고정밀, 물리적으로 정확한 3D 시뮬레이션 환경 및 에셋
- 임베디드 AI 모델의 성능을 정량화하는 표준화된 평가 지표
- GO-1 모델에서 sim to real 평가 오차 5% 미만 달성
- 시뮬레이션 평가에서 UniVLA 베이스라인 모델 지원

# 3. 업데이트 내역
- [2025/6/25] v2.1
  - Agibot World Challenge 2025를 위한 10가지 추가 조작 작업 및 모든 시뮬레이션 에셋 추가
  - Huggingface에 10가지 조작 작업용 합성 데이터셋 오픈소스화
  https://huggingface.co/datasets/agibot-world/AgiBotWorldChallenge-2025/tree/main/Manipulation-SimData
  - UniVLA 정책 통합 및 모델 추론 시뮬레이션 평가 지원
  - 타 로봇의 크로스 임바디먼트 IK 솔빙을 지원하는 IK 솔버 SDK 업데이트
  - 통신 프레임워크 최적화 및 시뮬레이션 실행 속도 2배 향상
  - 더 복잡한 장거리 작업을 위한 자동 평가 프레임워크 업데이트

# 4. 목차

## 4.1 소개
Genie Sim의 임베디드 인텔리전스 시뮬레이션 벤치마크는 임베디드 AI 모델의 개발 및 평가를 위해 설계되었습니다. 이 벤치마크는 현실적인 환경, 다양한 작업, 표준화된 지표를 제공하여 로봇 AI 시스템의 성능을 측정하며, 값비싼 물리적 하드웨어 및 실제 테스트의 필요성을 줄이고, 위험하고 위험한 테스트 시나리오를 피하며, AI 에이전트의 학습 및 평가 과정을 가속화합니다.

## 4.2 시작하기
설치, 사용자 가이드 및 API 레퍼런스는 [이 페이지](https://agibot-world.com/sim-evaluation/docs/#/v2)를 참고하세요.

## 4.3 지원
<img src="https://raw.githubusercontent.com/AgibotTech/genie_sim/main/./docs/wechat.JPEG" width="30%"/>

## 4.4 TODO 목록
- [x] 더 많은 장기 벤치마크 조작 작업 릴리즈
- [x] 각 벤치마크 작업별로 더 많은 장면 및 에셋 제공
- [x] Agibot World Challenge 베이스라인 모델 지원
- [ ] 시나리오 레이아웃 및 조작 궤적 범용화 툴킷

## 4.5 자주 묻는 질문(FAQ)
- 오류가 발생하여 isaac sim 서버가 종료되지 않고 프로세스가 응답하지 않을 때 어떻게 하나요?
  터미널에서 `pkill -9 -f raise_standalone_sim` 명령으로 프로세스를 종료하세요.
- 다양한 렌더 모드는 어떻게 선택하나요?
  기본 렌더 모드는 `RaytracedLighting(RealTime)`입니다. 투명한 객체가 포함된 작업의 경우, 객체의 원근관계 표현을 위해 `RealTimePathTracing(RealTime-2.0)`을 사용하세요.

## 4.6 라이선스 및 인용
이 저장소 내 모든 데이터와 코드는 Mozilla Public License 2.0을 따릅니다.
연구에 도움이 된다면 아래 방법 중 하나로 인용해 주시기 바랍니다.
```
@misc{2025geniesim,
  title={GenieSim},
  author={GenieSim Team},
  year={2025},
  url={https://github.com/AgibotTech/genie_sim}
}
```

## 4.7 참고 문헌
1. PDDL Parser (2020). Version 1.1. [Source code]. https://github.com/pucrs-automated-planning/pddl-parser.
2. BDDL. Version 1.x.x [Source code]. https://github.com/StanfordVL/bddl
3. CUROBO [Source code]. https://github.com/NVlabs/curobo
4. Isaac Lab [Source code]. https://github.com/isaac-sim/IsaacLab
5. Omni Gibson [Source code]. https://github.com/StanfordVL/OmniGibson


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-04

---