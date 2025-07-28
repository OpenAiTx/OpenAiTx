
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
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# llama-github

[상세 문서] https://deepwiki.com/JetXu-LLM/llama-github

[![PyPI 버전](https://badge.fury.io/py/llama-github.svg)](https://badge.fury.io/py/llama-github)
[![다운로드](https://static.pepy.tech/badge/Llama-github)](https://pepy.tech/project/Llama-github)
[![라이선스](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)

Llama-github는 Agentic RAG 기반으로 GitHub에서 가장 관련 있는 코드 스니펫, 이슈, 저장소 정보를 쿼리에 따라 검색하여 가치 있는 지식 컨텍스트로 변환하는 강력한 도구입니다. 이 도구는 LLM 챗봇, AI 에이전트, Auto-dev 에이전트가 복잡한 코딩 작업을 해결할 수 있도록 지원합니다. 빠른 솔루션이 필요한 개발자이든, 고급 Auto Dev AI 에이전트를 구현하는 엔지니어이든, llama-github를 통해 쉽고 효율적으로 작업할 수 있습니다.

이 프로젝트가 마음에 들거나 잠재력이 있다고 생각하신다면, 꼭 ⭐️를 눌러주세요. 여러분의 응원이 저희의 가장 큰 동기입니다!

## 아키텍처
![고수준 아키텍처](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/./docs/high_level_architecture.drawio.svg)

## 설치
```
pip install llama-github
```
## 사용법

llama-github를 사용하는 간단한 예제는 다음과 같습니다:


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
context = github_rag.retrieve_context(
    query, # In professional mode, one query will take nearly 1 min to generate final contexts. You could set log level to INFO to monitor the retrieval progress
    # simple_mode = True
)

print(context)
```
더 고급 사용법과 예제는 [문서](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/docs/usage.md)를 참고하세요.

## 주요 기능

- **🔍 지능형 GitHub 검색**: llama-github의 강력한 기능을 활용하여 사용자 쿼리에 기반한 관련성 높은 코드 스니펫, 이슈, 저장소 정보를 GitHub에서 검색합니다. 고급 검색 기법으로 가장 적합한 정보를 빠르고 효율적으로 찾아드립니다.

- **⚡ 저장소 풀 캐싱**: llama-github는 혁신적인 저장소 풀 캐싱 메커니즘을 갖추고 있습니다. 쓰레드 간에 저장소(README, 구조, 코드, 이슈 포함)를 캐싱하여 GitHub 검색 속도를 크게 향상시키고 API 토큰 사용을 최소화합니다. 다중 쓰레드 프로덕션 환경에서도 최적의 성능과 자원 절약을 보장합니다.

- **🧠 LLM 기반 질문 분석**: 최첨단 언어 모델을 활용해 사용자 질문을 분석하고 효과적인 검색 전략과 기준을 생성합니다. llama-github는 복잡한 쿼리를 지능적으로 분해하여 광범위한 GitHub 저장소 네트워크에서 가장 관련성 높은 정보를 찾아냅니다.

- **📚 포괄적 컨텍스트 생성**: GitHub에서 검색한 정보를 최첨단 언어 모델의 추론 능력과 매끄럽게 결합하여 풍부하고 상황에 맞는 답변을 생성합니다. 복잡하고 긴 질문도 뛰어나게 처리하여 개발에 필요한 광범위한 컨텍스트를 포함한 통찰력 있는 답변을 제공합니다.

- **🚀 비동기 처리 최적화**: llama-github는 비동기 프로그래밍의 모든 잠재력을 활용하도록 처음부터 설계되었습니다. 코드베이스 전반에 세심하게 구현된 비동기 메커니즘으로 여러 요청을 동시에 처리하며 전반적인 성능을 크게 향상시킵니다. 많은 작업량도 속도나 품질 저하 없이 효율적으로 관리하는 차이를 경험해보세요.

- **🔧 유연한 LLM 통합**: 다양한 LLM 제공자, 임베딩 모델, 재순위 모델과 쉽게 통합하여 라이브러리 기능을 맞춤화할 수 있습니다. 확장 가능한 아키텍처로 llama-github 기능을 환경에 맞게 자유롭게 조정하고 향상시킬 수 있습니다.

- **🔒 강력한 인증 옵션**: 개인 액세스 토큰과 GitHub 앱 인증 모두를 지원하여 다양한 개발 환경에 유연하게 통합할 수 있습니다. 개인 개발자부터 조직 환경까지 안전하고 신뢰할 수 있는 인증 메커니즘을 제공합니다.

- **🛠️ 로깅 및 오류 처리**: 원활한 운영과 간편한 문제 해결의 중요성을 잘 알고 있습니다. 이에 따라 llama-github는 포괄적인 로깅과 오류 처리 메커니즘을 갖추고 있어 라이브러리 동작을 깊이 파악하고 문제를 신속히 진단하며 안정적인 개발 워크플로우를 유지할 수 있습니다.

## 🤖 AI 기반 PR 리뷰 도우미: LlamaPReview 체험하기

llama-github가 유용하다면 AI 기반 GitHub PR 리뷰 도우미인 LlamaPReview도 관심 가질 만합니다. 개발 워크플로우를 보완하고 코드 품질을 한층 높여줍니다.

### LlamaPReview 주요 기능:
- 🚀 원클릭 설치, 설정 불필요, 완전 자동 실행
- 💯 현재 무료 사용 - 신용카드나 결제 정보 필요 없음
- 🧠 AI 기반 자동 PR 리뷰, 깊은 코드 이해력 탑재
- 🌐 다중 프로그래밍 언어 지원

**LlamaPReview는 llama-github의 고급 컨텍스트 검색과 LLM 분석을 활용**하여 지능적이고 상황 인지적인 코드 리뷰를 제공합니다. 마치 선임 개발자가 저장소 전체 컨텍스트를 파악한 상태로 모든 PR을 자동 검토하는 것과 같습니다!

👉 [지금 LlamaPReview 설치](https://github.com/marketplace/llamapreview/) (무료)

llama-github의 컨텍스트 검색과 LlamaPReview의 코드 리뷰를 함께 사용하면 강력한 AI 강화 개발 환경을 구축할 수 있습니다.

## 비전 및 로드맵

### 비전

우리의 비전은 AI 기반 개발 솔루션의 핵심 모듈로 자리매김하여 GitHub와 원활하게 통합, LLM이 복잡한 코딩 과제를 자동으로 해결하도록 지원하는 것입니다.

![Vision Architecture](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/./docs/vision.drawio.svg)

### 로드맵

프로젝트 로드맵의 자세한 내용을 보려면 [프로젝트 로드맵](https://github.com/users/JetXu-LLM/projects/2)을 방문하세요.

## 감사의 글

다음 오픈소스 프로젝트들의 지원과 기여에 감사드립니다:

- **[LangChain](https://github.com/langchain-ai/langchain)**: llama-github 내 LLM 프롬프트 및 처리 기능의 기반 프레임워크를 제공합니다.
- **[Jina.ai](https://github.com/jina-ai/reader)**: s.jina.ai API와 오픈소스 재순위 및 임베딩 모델을 제공하여 llama-github의 컨텍스트 생성 정확도와 관련성을 높입니다.

이들의 기여가 llama-github 개발에 큰 도움이 되었으며, 더 혁신적인 솔루션을 위해 이들 프로젝트를 적극 추천합니다.

## 기여하기

llama-github에 대한 기여를 환영합니다! 자세한 내용은 [기여 가이드라인](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/CONTRIBUTING.md)을 참고하세요.

## 라이선스

본 프로젝트는 Apache 2.0 라이선스에 따라 배포됩니다. 자세한 내용은 [LICENSE](LICENSE) 파일을 참조하세요.

## 연락처

질문, 제안, 피드백이 있으시면 언제든지 [Jet Xu의 이메일](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/mailto:Voldemort.xu@foxmail.com)로 연락해 주세요.

---

llama-github를 선택해 주셔서 감사합니다! 이 라이브러리가 AI 개발 경험을 향상시키고 강력한 애플리케이션을 쉽게 구축하는 데 도움이 되길 바랍니다.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-28

---