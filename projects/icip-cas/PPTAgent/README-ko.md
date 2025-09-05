
<div align="right">
  <details>
    <summary >🌐 언어</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# PPTAgent: 텍스트-슬라이드 생성 그 이상, 프레젠테이션 생성 및 평가
<p align="center">
  📄 <a href="https://arxiv.org/abs/2501.03936" target="_blank">논문</a> &nbsp; | &nbsp;
  🤗 <a href="#open-source-" target="_blank">오픈소스</a> &nbsp; | &nbsp;
  📝 <a href="./DOC.md" target="_blank">문서</a> &nbsp; | &nbsp;
  🙏 <a href="#citation-" target="_blank">인용</a> &nbsp; | &nbsp;
  <a href="https://deepwiki.com/icip-cas/PPTAgent" target="_blank"><img src="https://deepwiki.com/icon.png" alt="Ask DeepWiki"> DeepWiki</a>
</p>

우리는 PPTAgent를 소개합니다. 이 혁신적인 시스템은 문서로부터 자동으로 프레젠테이션을 생성합니다. 인간의 프레젠테이션 제작 방식에서 영감을 받아, 본 시스템은 전반적인 품질의 우수성을 보장하기 위해 두 단계의 프로세스를 채택했습니다. 추가로 **PPTEval**이라는 종합 평가 프레임워크를 도입하여 다양한 측면에서 프레젠테이션을 평가합니다.

> [!TIP]
> 🚀 사전 구축된 Docker 이미지를 통해 빠르게 시작하세요 - [Docker 사용법 보기](DOC.md/#docker-)

## 오픈 소스 🤗
우리는 **PPTAgent 코드 모델**과 데이터셋을 공개하였습니다: [PPTAgent-Coder](https://huggingface.co/Forceless/PPTAgent-coder-3B), [Zenodo10k](https://huggingface.co/datasets/Forceless/Zenodo10K), [pptagent-code26k](https://huggingface.co/datasets/Forceless/pptagent-code26k).

## 데모 영상 🎥

https://github.com/user-attachments/assets/c3935a98-4d2b-4c46-9b36-e7c598d14863

## 주요 특징 ✨

- **동적 콘텐츠 생성**: 텍스트와 이미지를 완벽하게 통합하여 슬라이드를 생성
- **스마트 참조 학습**: 수작업 주석 없이 기존 프레젠테이션을 활용
- **종합 품질 평가**: 다양한 품질 지표로 프레젠테이션 평가

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

- #### [Build Effective Agents](https://www.anthropic.com/research/building-effective-agents)

<div style="display: flex; flex-wrap: wrap; gap: 10px;">

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0001.jpg" alt="图片1" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0002.jpg" alt="图片2" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0003.jpg" alt="图片3" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0004.jpg" alt="图片4" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0005.jpg" alt="图片5" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0006.jpg" alt="图片6" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0007.jpg" alt="图片7" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0008.jpg" alt="图片8" width="200"/>

<img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0009.jpg" alt="图片9" width="200"/>

<img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0010.jpg" alt="图片10" width="200"/>

</div>

## PPTAgent 🤖

PPTAgent follows a two-phase approach:
1. **Analysis Phase**: Extracts and learns from patterns in reference presentations
2. **Generation Phase**: Develops structured outlines and produces visually cohesive slides

Our system's workflow is illustrated below:


![PPTAgent Workflow](https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/fig2.jpg)

## PPTEval ⚖️

PPTEval은 프레젠테이션을 세 가지 차원에서 평가합니다:
- **내용**: 슬라이드의 정확성과 관련성을 확인합니다.
- **디자인**: 시각적 매력과 일관성을 평가합니다.
- **일관성**: 아이디어의 논리적 흐름을 보장합니다.

PPTEval의 워크플로우는 아래와 같습니다:
<p align="center">
<img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/fig3.jpg" alt="PPTEval Workflow" style="width:70%;"/>
</p>


## 인용 🙏

이 프로젝트가 도움이 되셨다면, 다음 인용문을 사용해 주세요:
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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-05

---