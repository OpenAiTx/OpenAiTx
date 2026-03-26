
<div align="right">
  <details>
    <summary >🌐 언어</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# llama-github

[상세 문서] https://deepwiki.com/JetXu-LLM/llama-github

[![PyPI 버전](https://badge.fury.io/py/llama-github.svg)](https://badge.fury.io/py/llama-github)
[![다운로드](https://static.pepy.tech/badge/Llama-github)](https://pepy.tech/project/Llama-github)
[![라이선스](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)

Llama-github는 강력한 도구로, 쿼리에 기반하여 GitHub에서 가장 관련성 높은 코드 조각, 이슈, 저장소 정보를 Agentic RAG 기반으로 검색하여 귀중한 지식 컨텍스트로 변환합니다. 이 도구는 LLM 챗봇, AI 에이전트, 자동 개발 에이전트가 복잡한 코딩 작업을 해결할 수 있도록 지원합니다. 개발자가 빠른 솔루션을 찾거나, 엔지니어가 고급 자동 개발 AI 에이전트를 구현할 때, llama-github는 쉽고 효율적으로 작업을 수행할 수 있게 합니다.
이 프로젝트가 마음에 들거나 잠재력이 있다고 생각하신다면, ⭐️를 눌러주세요. 여러분의 응원이 저희에게 가장 큰 동기부여가 됩니다!

## 아키텍처
![상위 레벨 아키텍처](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/./docs/high_level_architecture.drawio.svg)

## 설치

```
pip install llama-github
```

현재 유지 관리되는 런타임 대상: Python `3.10+`.

## 사용법

llama-github를 사용하는 간단한 예시는 다음과 같습니다:

```python
from llama_github import GithubRAG

# Initialize GithubRAG with your credentials
github_rag = GithubRAG(
    github_access_token="your_github_access_token", 
    openai_api_key="your_openai_api_key", # Optional in Simple Mode
    jina_api_key="your_jina_api_key" # Optional - unless you want high concurrency production deployment (s.jina.ai API will be used in llama-github)
)

# Retrieve context for a coding question (simple_mode is default set to False)
query = "How to create a NumPy array in Python?"
contexts = github_rag.retrieve_context(
    query,
    # simple_mode = True
)

print(contexts[0]["url"])
print(contexts[0]["context"])
```
`retrieve_context()`는 컨텍스트 딕셔너리의 리스트를 반환합니다. 각 항목에는 최소한 `context`와 `url`이 포함되어 있습니다.

더 고급 사용법과 예제는 [문서](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/docs/usage.md)를 참조하세요. 실행 가능한 저비용 예제는 [`examples/`](examples) 디렉터리에도 제공됩니다.

## 주요 기능

- **🔍 지능형 GitHub 검색**: llama-github의 강력함을 활용하여 사용자 쿼리에 따라 GitHub에서 관련성 높은 코드 스니펫, 이슈, 저장소 정보를 검색합니다. 고급 검색 기법으로 가장 적합한 정보를 신속하고 효율적으로 찾을 수 있습니다.

- **⚡ 저장소 풀 캐싱**: llama-github는 혁신적인 저장소 풀 캐싱 메커니즘을 갖추고 있습니다. 저장소(README, 구조, 코드, 이슈 포함)를 스레드 간에 캐싱함으로써 GitHub 검색 속도를 대폭 향상시키고 GitHub API 토큰 사용을 최소화합니다.

- **🧠 LLM 기반 질문 분석**: 최신 언어 모델을 활용하여 사용자 질문을 분석하고 효과적인 검색 전략과 기준을 생성합니다. llama-github는 복잡한 쿼리도 지능적으로 분해하여 GitHub의 방대한 저장소 네트워크에서 가장 관련성 높은 정보를 검색합니다.

- **📚 포괄적 컨텍스트 생성**: GitHub에서 검색한 정보와 고급 언어 모델의 추론 능력을 결합하여 풍부하고 맥락에 맞는 답변을 생성합니다. llama-github는 복잡하고 긴 질문도 능숙하게 처리하여 개발에 필요한 광범위한 컨텍스트가 포함된 종합적이고 통찰력 있는 답변을 제공합니다.

- **🚀 비동기 처리 우수성**: llama-github는 비동기 프로그래밍의 모든 잠재력을 최대한 활용하도록 처음부터 설계되었습니다. 코드 전반에 정교하게 구현된 비동기 메커니즘으로 여러 요청을 동시에 처리하여 전반적인 성능을 크게 향상시킵니다.

- **🔧 유연한 LLM 통합**: 다양한 LLM 제공업체, 임베딩 모델, 재정렬 모델 또는 LangChain 호환 챗 모델을 쉽게 연동하여 라이브러리 기능을 특정 요구에 맞게 맞춤화할 수 있습니다.

- **🔒 강력한 인증 옵션**: llama-github는 개인 액세스 토큰과 GitHub App 인증을 모두 지원하여 다양한 개발 환경에 유연하게 통합할 수 있습니다. 개인 개발자든 조직 내에서 작업하든 안전하고 신뢰할 수 있는 인증 메커니즘을 제공합니다.

- **🛠️ 로깅 및 오류 처리**: 원활한 운영과 손쉬운 문제 해결의 중요성을 이해합니다. llama-github는 포괄적인 로깅 및 오류 처리 메커니즘을 갖추고 있어 라이브러리 동작을 깊이 있게 파악하고, 신속하게 문제를 진단하며, 안정적이고 신뢰할 수 있는 개발 워크플로우를 유지할 수 있습니다.

## 🤖 AI 기반 PR 리뷰 어시스턴트: LlamaPReview 체험

llama-github가 유용하다면, AI 기반 GitHub PR 리뷰 어시스턴트인 LlamaPReview에도 관심이 있을 수 있습니다. 개발 워크플로우를 보완하고 코드 품질을 더욱 향상시키도록 설계되었습니다.

### LlamaPReview의 주요 기능:
- 🚀 원클릭 설치, 별도 설정 불필요, 완전 자동 실행
- 💯 현재 무료 사용 가능 - 신용카드나 결제 정보 불필요
- 🧠 AI 기반, 심층 코드 이해를 통한 자동 PR 리뷰
- 🌐 다양한 프로그래밍 언어 지원

**LlamaPReview는 llama-github의 고급 컨텍스트 검색 및 LLM 기반 분석**을 활용하여 지능적이고 맥락을 이해하는 코드 리뷰를 제공합니다. 마치 저장소의 모든 맥락을 숙지한 시니어 개발자가 모든 PR을 자동으로 검토하는 것과 같습니다!

👉 [LlamaPReview 지금 설치하기](https://github.com/marketplace/llamapreview/) (무료)

llama-github로 컨텍스트를 검색하고 LlamaPReview로 코드 리뷰를 수행하면 강력한 AI 기반 개발 환경을 구축할 수 있습니다.

## 비전 및 로드맵


### 비전

우리의 비전은 AI 기반 개발 솔루션의 미래에서 핵심 모듈이 되어, GitHub와 원활하게 통합하여 LLM이 복잡한 코딩 작업을 자동으로 해결할 수 있도록 지원하는 것입니다.

![비전 아키텍처](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/./docs/vision.drawio.svg)

### 로드맵

이전 로드맵의 역사적 관점을 확인하려면 [비전 및 로드맵](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/VISION_AND_ROADMAP.md)을 방문하세요.

## 감사의 말씀

다음 오픈소스 프로젝트들의 지원과 기여에 감사의 말씀을 드립니다:

- **[LangChain](https://github.com/langchain-ai/langchain)**: llama-github의 LLM 프롬프트 및 처리 능력을 지원하는 기반 프레임워크를 제공해 주셨습니다.
- **[Jina.ai](https://github.com/jina-ai/reader)**: s.jina.ai API 및 오픈소스 리랭커와 임베딩 모델을 제공하여 llama-github에서 생성된 컨텍스트의 정확성과 관련성을 향상시켜 주셨습니다.

이들의 기여는 llama-github 개발에 중요한 역할을 했으며, 더 혁신적인 솔루션을 찾고 싶다면 이 프로젝트들을 확인해 보시길 추천합니다.

## 기여하기

llama-github에 대한 기여를 환영합니다! 자세한 내용은 [기여 가이드라인](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/CONTRIBUTING.md)을 참고하세요.

## 라이선스

이 프로젝트는 Apache 2.0 라이선스 조건에 따라 라이선스가 부여됩니다. 자세한 내용은 [LICENSE](LICENSE) 파일을 확인하세요.

## 연락처

질문, 제안 또는 피드백이 있으시면 [Jet Xu의 이메일](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/mailto:Voldemort.xu@foxmail.com)로 언제든 연락해 주세요.

---

llama-github를 선택해 주셔서 감사합니다! 이 라이브러리가 여러분의 AI 개발 경험을 향상시키고 쉽고 강력한 애플리케이션을 구축하는 데 도움이 되길 바랍니다.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-26

---