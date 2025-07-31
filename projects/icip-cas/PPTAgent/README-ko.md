# PPTAgent: 텍스트-슬라이드를 넘어 프레젠테이션 생성 및 평가
<p align="center">
  📄 <a href="https://arxiv.org/abs/2501.03936" target="_blank">논문</a> &nbsp; | &nbsp;
  🤗 <a href="https://huggingface.co/datasets/Forceless/Zenodo10K" target="_blank">데이터셋</a> &nbsp; | &nbsp;
  📝 <a href="./DOC.md" target="_blank">문서</a> &nbsp; | &nbsp;
  🙏 <a href="#citation-" target="_blank">인용</a> &nbsp; | &nbsp;
  <a href="https://deepwiki.com/icip-cas/PPTAgent" target="_blank"><img src="https://deepwiki.com/icon.png" alt="Ask DeepWiki"> DeepWiki</a>
</p>

우리는 문서로부터 자동으로 프레젠테이션을 생성하는 혁신적인 시스템 PPTAgent를 소개합니다. 인간의 프레젠테이션 제작 방식을 참고하여, 우리 시스템은 전반적인 품질을 보장하기 위해 2단계 프로세스를 적용합니다. 또한, 여러 차원에서 프레젠테이션을 평가하는 포괄적 평가 프레임워크 **PPTEval**을 소개합니다.

> [!TIP]
> 🚀 미리 구축된 도커 이미지로 빠르게 시작하세요 - [도커 안내 보기](DOC.md/#docker-)

## 데모 영상 🎥

https://github.com/user-attachments/assets/c3935a98-4d2b-4c46-9b36-e7c598d14863

## 주요 특징 ✨

- **동적 콘텐츠 생성**: 텍스트와 이미지가 자연스럽게 통합된 슬라이드 생성
- **스마트 참조 학습**: 수동 주석 없이 기존 프레젠테이션 활용
- **포괄적 품질 평가**: 다양한 품질 지표를 통해 프레젠테이션 평가

## 사례 연구 💡

- #### [아이폰 16 프로](https://www.apple.com/iphone-16-pro/)

<div style="display: flex; flex-wrap: wrap; gap: 10px;">

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/iphone16pro/0001.jpg" alt="이미지1" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/iphone16pro/0002.jpg" alt="이미지2" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/iphone16pro/0003.jpg" alt="이미지3" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/iphone16pro/0004.jpg" alt="이미지4" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/iphone16pro/0005.jpg" alt="이미지5" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/iphone16pro/0006.jpg" alt="이미지6" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/iphone16pro/0007.jpg" alt="이미지7" width="200"/>

</div>

- #### [효과적인 에이전트 구축](https://www.anthropic.com/research/building-effective-agents)

<div style="display: flex; flex-wrap: wrap; gap: 10px;">

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0001.jpg" alt="이미지1" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0002.jpg" alt="이미지2" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0003.jpg" alt="이미지3" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0004.jpg" alt="이미지4" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0005.jpg" alt="이미지5" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0006.jpg" alt="이미지6" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0007.jpg" alt="이미지7" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0008.jpg" alt="이미지8" width="200"/>

<img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0009.jpg" alt="이미지9" width="200"/>

<img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0010.jpg" alt="이미지10" width="200"/>

</div>

## PPTAgent 🤖

PPTAgent는 두 단계 접근법을 따릅니다:
1. **분석 단계**: 참조 프레젠테이션에서 패턴을 추출하고 학습
2. **생성 단계**: 구조화된 개요를 개발하고 시각적으로 일관된 슬라이드 생성

우리 시스템의 작업 흐름은 아래와 같습니다:


![PPTAgent 작업 흐름](https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/fig2.jpg)

## PPTEval ⚖️

PPTEval은 세 가지 차원에서 프레젠테이션을 평가합니다:
- **콘텐츠**: 슬라이드의 정확성과 적합성 확인
- **디자인**: 시각적 매력과 일관성 평가
- **일관성**: 아이디어의 논리적 흐름 보장

PPTEval의 작업 흐름은 아래와 같습니다:
<p align="center">
<img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/fig3.jpg" alt="PPTEval 작업 흐름" style="width:70%;"/>
</p>


## 인용 🙏

이 프로젝트가 도움이 되었다면, 다음을 인용해 주세요:
```bibtex
@article{zheng2025pptagent,
  title={PPTAgent: Generating and Evaluating Presentations Beyond Text-to-Slides},
  author={Zheng, Hao and Guan, Xinyan and Kong, Hao and Zheng, Jia and Zhou, Weixiang and Lin, Hongyu and Lu, Yaojie and He, Ben and Han, Xianpei and Sun, Le},
  journal={arXiv preprint arXiv:2501.03936},
  year={2025}
}
```

[![Star History Chart](https://api.star-history.com/svg?repos=icip-cas/PPTAgent&type=Date)](https://star-history.com/#icip-cas/PPTAgent&Date)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-31

---