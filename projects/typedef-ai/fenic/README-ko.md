<!-- markdownlint-disable MD041 MD033 -->
<div align="center">
    <picture>
        <source media="(prefers-color-scheme: dark)" srcset="docs/images/typedef-fenic-logo-dark.png">
        <img src="https://raw.githubusercontent.com/typedef-ai/fenic/main/docs/images/typedef-fenic-logo.png" alt="fenic, by typedef" width="90%">
    </picture>
</div>

# fenic: LLM 추론을 위해 (재)구성된 데이터프레임

[![PyPI version](https://img.shields.io/pypi/v/fenic.svg)](https://pypi.org/project/fenic/)
[![Python versions](https://img.shields.io/pypi/pyversions/fenic.svg)](https://pypi.org/project/fenic/)
[![License](https://img.shields.io/github/license/typedef-ai/fenic.svg)](https://github.com/typedef-ai/fenic/blob/main/LICENSE)
[![Discord](https://img.shields.io/discord/1381706122322513952?label=Discord&logo=discord)](https://discord.gg/GdqF3J7huR)

---

## **문서**: [docs.fenic.ai](https://docs.fenic.ai/)

fenic은 typedef.ai에서 개발한 PySpark에서 영감을 받은 의견 중심의 DataFrame 프레임워크로, AI 및 에이전트 기반 애플리케이션 구축을 위해 설계되었습니다. 친숙한 DataFrame 연산에 의미론적 지능을 더해 비정형 및 정형 데이터를 인사이트로 변환합니다. Markdown, 대화록, 의미론적 연산자에 대한 일급 지원과 더불어, 모든 모델 제공자에 대해 효율적인 배치 추론을 제공합니다.
## 설치

fenic은 Python `[3.10, 3.11, 3.12]`을 지원합니다.

```bash
pip install fenic
```

### LLM 제공자 설정

fenic은 최소 한 개의 LLM 제공자로부터 API 키가 필요합니다. 선택한 제공자에 맞는 환경 변수를 설정하세요:

```bash
# OpenAI의 경우
export OPENAI_API_KEY="your-openai-api-key"

# Anthropic의 경우
export ANTHROPIC_API_KEY="your-anthropic-api-key"

# Google
```bash
export GEMINI_API_KEY="your-google-api-key"
```

## 빠른 시작

fenic을 빠르게 배우는 가장 좋은 방법은 예제들을 살펴보는 것입니다.

아래는 이 저장소에 포함된 예제들의 간단한 목록입니다:

| 예제                                                                      | 설명                                                                                                                               |
| ------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------- |
| [Hello World!](examples/hello_world)                                      | 오류 로그 분석을 통해 fenic의 핵심 연산자를 사용한 의미론적 추출 및 분류 소개.                                                    |
| [Enrichment](examples/enrichment)                                         | 템플릿 기반 텍스트 추출, 조인, LLM 기반 변환이 포함된 다단계 DataFrame을 로그 강화 예제로 시연.                                    |
| [회의록 처리](examples/meeting_transcript_processing)                      | 회의 분석을 통해 네이티브 회의록 파싱, Pydantic 스키마 통합, 복잡한 집계 방법을 보여줌.                                           |
| [뉴스 분석](examples/news_analysis)                                       | 의미 연산자와 구조화된 데이터 처리를 사용하여 뉴스 기사에서 인사이트를 분석 및 추출.                                              |
| [팟캐스트 요약](examples/podcast_summarization)                           | 화자 인식 분석 및 주요 포인트 추출로 팟캐스트 회의록을 처리하고 요약.                                                              |
| [의미론적 조인](examples/semantic_joins)                                  | 단순한 퍼지 매칭 대신, fenic의 강력한 의미론적 조인 기능으로 테이블 간 데이터 매칭.                                                |
| [명명된 개체 인식](examples/named_entity_recognition)                     | 의미론적 추출 및 분류를 통해 텍스트에서 명명된 개체 추출 및 분류.                                                                  |
| [마크다운 처리](examples/markdown_processing)                             | 구조화된 데이터 추출 및 형식 지정을 통해 마크다운 문서를 처리 및 변환.                                                             |
| [JSON 처리](examples/json_processing)                                     | 의미 연산 및 스키마 검증을 통해 복잡한 JSON 데이터 구조 처리.                                                                      |
| [피드백 클러스터링](examples/feedback_clustering)                         | 의미 유사도 및 클러스터링 연산을 사용하여 피드백을 그룹화 및 분석.                                                                 |
| [문서 추출](examples/document_extraction)                                 | 의미 연산자를 사용하여 다양한 문서 형식에서 구조화된 정보 추출.                                                                    |

(위 예제 중 원하는 항목을 클릭하면 해당 폴더로 바로 이동할 수 있습니다.)

## 왜 fenic을 사용해야 하나요?

fenic은 생산용 AI 및 에이전트 애플리케이션 구축을 위해 설계된, PySpark에서 영감을 받은 의견이 반영된 DataFrame 프레임워크입니다.

기존의 LLM에 맞춰 개조된 전통적인 데이터 도구와 달리, fenic의 쿼리 엔진은 추론을 염두에 두고 처음부터 설계되었습니다.

익숙한 DataFrame 연산에 의미론적 지능을 더해 구조화 및 비구조화 데이터를 인사이트로 변환하세요. 마크다운, 트랜스크립트, 의미론적 연산자에 대한 일류 지원과 모든 모델 제공자에서 효율적인 배치 추론을 제공합니다.

fenic은 전통적인 데이터 파이프라인의 신뢰성을 AI 워크로드에 제공합니다.

### 주요 기능

#### LLM 추론을 위한 목적 기반 설계

- AI 워크로드를 위해 처음부터 설계된 쿼리 엔진, 개조 아님
- API 호출의 자동 배치 최적화
- 내장된 재시도 로직과 속도 제한
- 토큰 카운팅 및 비용 추적

#### 일류 시민으로서의 의미론적 연산자
- `semantic.analyze_sentiment` - 내장 감정 분석
- `semantic.classify` - 몇 개의 예시로 텍스트 분류
- `semantic.extract` - 비정형 텍스트를 스키마와 함께 구조화된 데이터로 변환
- `semantic.group_by` - 의미적 유사성에 따라 데이터 그룹화
- `semantic.join` - 값이 아닌 의미 기반으로 DataFrame 조인
- `semantic.map` - 자연어 변환 적용
- `semantic.predicate` - 자연어로 조건문을 생성해 행 필터링
- `semantic.reduce` - LLM 연산으로 그룹화된 데이터 집계

#### 네이티브 비정형 데이터 지원

일반적인 멀티모달 데이터 유형(오디오, 이미지)을 넘어, 텍스트 중심 작업을 위한 특수 유형 제공:

- Markdown 구문 분석 및 추출을 일급 데이터 유형으로 지원
- 화자 및 타임스탬프 인식이 가능한 전사본 처리(SRT, 일반 포맷)
- 중첩 데이터 처리를 위한 JQ 표현식 기반 JSON 조작
- 긴 문서에 대한 설정 가능한 중첩 자동 텍스트 청킹

#### 프로덕션 준비 인프라
- 멀티 프로바이더 지원 (OpenAI, Anthropic, Gemini)
- 로컬 및 클라우드 실행 백엔드
- 포괄적인 오류 처리 및 로깅
- 타입 안전성을 위한 Pydantic 통합

#### 익숙한 DataFrame API

- PySpark 호환 연산
- 지연 평가 및 쿼리 최적화
- 복잡한 쿼리를 위한 SQL 지원
- 기존 데이터 파이프라인과의 원활한 통합

### LLM 및 에이전트 기반 애플리케이션에 DataFrame을 사용하는 이유는 무엇인가요?

AI 및 에이전트 기반 애플리케이션은 본질적으로 파이프라인과 워크플로우입니다. 이는 DataFrame API가 처리하도록 설계된 바로 그 영역입니다. 데이터 변환, 필터링, 집계를 위한 패턴을 새로 만들기보다는, fenic은 수십 년간 검증된 엔지니어링 관행을 활용합니다.

#### 더 나은 에이전트를 위한 분리된 아키텍처

fenic은 무거운 추론 작업과 실시간 에이전트 상호작용 간에 명확한 분리를 만듭니다. 배치 처리를 에이전트 런타임 밖으로 이동함으로써 다음과 같은 이점을 얻을 수 있습니다:

- 더 예측 가능하고 반응성이 뛰어난 에이전트
- 배치 LLM 호출로 더 나은 리소스 활용
- 계획/오케스트레이션과 실행의 명확한 분리
#### 모든 엔지니어를 위해 설계됨

DataFrame은 데이터 실무자만을 위한 것이 아닙니다. 유연하고 조합 가능한 API 디자인 덕분에 모든 엔지니어가 쉽게 사용할 수 있습니다:

- 자연스럽게 연산을 체이닝: `df.filter(...).semantic.group_by(...)`
- 명령형과 선언형 스타일을 매끄럽게 혼합
- pandas/PySpark 또는 SQL에서 익숙한 패턴으로 빠르게 시작 가능

## 지원

[Discord](https://discord.gg/GdqF3J7huR) 커뮤니티에 참여하여 다른 사용자들과 소통하고, 질문을 하거나, fenic 프로젝트에 대한 도움을 받을 수 있습니다. 저희 커뮤니티는 언제나 새로운 분들을 환영합니다!

fenic이 유용하다면, 이 저장소 상단에서 ⭐을 눌러주세요. 여러분의 응원이 프레임워크의 성장과 개선에 큰 힘이 됩니다!

## 기여하기

모든 종류의 기여를 환영합니다! 코드 작성, 문서 개선, 기능 테스트, 새로운 아이디어 제안 등 어떤 형태로든 여러분의 도움이 소중합니다.

코드 변경을 계획하는 개발자라면, Pull Request를 생성하기 전에 먼저 이슈를 열어 아이디어를 논의해 주시길 권장합니다. 이는 프로젝트 방향성과의 정렬을 보장하고, 중복 작업을 방지하는 데 도움이 됩니다.

개발 프로세스 및 프로젝트 설정에 대한 자세한 내용은 [기여 가이드라인](https://raw.githubusercontent.com/typedef-ai/fenic/main/CONTRIBUTING.md)을 참고해 주세요.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-09

---