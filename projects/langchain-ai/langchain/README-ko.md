<picture>
  <source media="(prefers-color-scheme: light)" srcset="docs/static/img/logo-dark.svg">
  <source media="(prefers-color-scheme: dark)" srcset="docs/static/img/logo-light.svg">
  <img alt="LangChain 로고" src="docs/static/img/logo-dark.svg" width="80%">
</picture>

<div>
<br>
</div>

[![릴리스 노트](https://img.shields.io/github/release/langchain-ai/langchain?style=flat-square)](https://github.com/langchain-ai/langchain/releases)
[![CI](https://github.com/langchain-ai/langchain/actions/workflows/check_diffs.yml/badge.svg)](https://github.com/langchain-ai/langchain/actions/workflows/check_diffs.yml)
[![PyPI - 라이선스](https://img.shields.io/pypi/l/langchain-core?style=flat-square)](https://opensource.org/licenses/MIT)
[![PyPI - 다운로드](https://img.shields.io/pypi/dm/langchain-core?style=flat-square)](https://pypistats.org/packages/langchain-core)
[![GitHub 별 차트](https://img.shields.io/github/stars/langchain-ai/langchain?style=flat-square)](https://star-history.com/#langchain-ai/langchain)
[![오픈 이슈](https://img.shields.io/github/issues-raw/langchain-ai/langchain?style=flat-square)](https://github.com/langchain-ai/langchain/issues)
[![Dev Containers에서 열기](https://img.shields.io/static/v1?label=Dev%20Containers&message=Open&color=blue&logo=visualstudiocode&style=flat-square)](https://vscode.dev/redirect?url=vscode://ms-vscode-remote.remote-containers/cloneInVolume?url=https://github.com/langchain-ai/langchain)
[<img src="https://github.com/codespaces/badge.svg" title="Github Codespace에서 열기" width="150" height="20">](https://codespaces.new/langchain-ai/langchain)
[![트위터](https://img.shields.io/twitter/url/https/twitter.com/langchainai.svg?style=social&label=Follow%20%40LangChainAI)](https://twitter.com/langchainai)
[![CodSpeed 배지](https://img.shields.io/endpoint?url=https://codspeed.io/badge.json)](https://codspeed.io/langchain-ai/langchain)

> [!NOTE]
> JS/TS 라이브러리를 찾으시나요? [LangChain.js](https://github.com/langchain-ai/langchainjs)를 확인해보세요.

LangChain은 LLM 기반 애플리케이션을 구축하기 위한 프레임워크입니다. 상호 운용 가능한 컴포넌트와 서드파티 통합을 연결하여 AI 애플리케이션 개발을 간소화하며, 기반 기술이 진화해도 미래에 대비할 수 있도록 지원합니다.

```bash
pip install -U langchain
```

LangChain에 대해 더 알아보고 싶다면
[공식 문서](https://python.langchain.com/docs/introduction/)를 참고하세요. 더 고도화된 커스터마이징이나 에이전트 오케스트레이션이 필요하다면
[LangGraph](https://langchain-ai.github.io/langgraph/)를 확인하세요. LangGraph는 제어 가능한 에이전트 워크플로우 구축을 위한 프레임워크입니다.

## LangChain을 사용하는 이유는 무엇인가요?

LangChain은 개발자가 모델, 임베딩, 벡터 스토어 등 다양한 LLM 기반 기능을 표준 인터페이스로 활용할 수 있게 도와줍니다.

LangChain 활용 예시:
- **실시간 데이터 증강**: 다양한 데이터 소스 및 외부/내부 시스템에 LLM을 손쉽게 연결할 수 있습니다. LangChain의 방대한 통합 라이브러리를 통해 모델 제공자, 도구, 벡터 스토어, 검색기 등과 연동할 수 있습니다.
- **모델 상호 운용성**: 엔지니어링 팀이 애플리케이션에 최적화된 모델을 실험하며 쉽게 교체할 수 있습니다. 업계가 빠르게 변화하더라도, LangChain의 추상화 덕분에 속도를 잃지 않고 유연하게 대응할 수 있습니다.

## LangChain의 생태계
LangChain 프레임워크는 단독으로도 사용할 수 있지만, 모든 LangChain 제품과도 원활하게 통합되어 LLM 애플리케이션 구축 시 개발자에게 다양한 도구를 제공합니다.

LLM 애플리케이션 개발을 향상시키기 위해 LangChain을 다음과 함께 사용하세요:

- [LangSmith](http://www.langchain.com/langsmith) - 에이전트 평가 및 가시성에 유용합니다. 성능이 낮은 LLM 앱 실행을 디버깅하고, 에이전트 경로를 평가하며, 운영 환경에서 가시성을 높이고, 시간이 지남에 따라 성능을 개선할 수 있습니다.
- [LangGraph](https://langchain-ai.github.io/langgraph/) - 복잡한 작업을 안정적으로 처리할 수 있는 에이전트를 구축할 수 있습니다. LangGraph는 커스터마이징 가능한 아키텍처, 장기 메모리, 사람 개입 워크플로우를 제공합니다. LinkedIn, Uber, Klarna, GitLab 등에서 실제 운영에 사용되고 있습니다.
- [LangGraph Platform](https://langchain-ai.github.io/langgraph/concepts/langgraph_platform/) - 장기 실행, 상태 기반 워크플로우를 위한 전용 배포 플랫폼으로 에이전트를 손쉽게 배포하고 확장할 수 있습니다. 다양한 팀에서 에이전트를 발견, 재사용, 구성, 공유할 수 있으며,
[LangGraph Studio](https://langchain-ai.github.io/langgraph/concepts/langgraph_studio/)에서 비주얼 프로토타이핑으로 빠르게 반복 개발할 수 있습니다.

## 추가 자료
- [튜토리얼](https://python.langchain.com/docs/tutorials/): LangChain 시작을 위한 단계별 안내와 예시를 제공합니다.
- [How-to 가이드](https://python.langchain.com/docs/how_to/): 도구 호출, RAG 활용 사례 등 다양한 주제에 대한 빠르고 실용적인 코드 예시를 제공합니다.
- [개념 가이드](https://python.langchain.com/docs/concepts/): LangChain 프레임워크의 핵심 개념을 설명합니다.
- [API 레퍼런스](https://python.langchain.com/api_reference/): LangChain의 기본 패키지와 통합 기능에 대한 자세한 참조 문서입니다.


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---