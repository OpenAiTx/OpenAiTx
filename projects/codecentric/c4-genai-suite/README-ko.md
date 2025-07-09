# c4 GenAI Suite

Langchain으로 구동되며 모든 주요 대형 언어 모델(LLM) 및 임베딩 모델과 호환되는 Model Context Provider(MCP) 통합 AI 챗봇 애플리케이션입니다.

관리자는 RAG(검색 증강 생성) 서비스나 MCP 서버와 같은 확장 기능을 추가하여 다양한 기능을 가진 어시스턴트를 생성할 수 있습니다. 이 애플리케이션은 React, NestJS, 그리고 REI-S 서비스를 위한 Python FastAPI 등 최신 기술 스택을 사용하여 구축되었습니다.

사용자는 사용자 친화적인 인터페이스를 통해 어시스턴트와 상호 작용할 수 있습니다. 어시스턴트의 구성에 따라 사용자는 질문을 하거나, 자신의 파일을 업로드하거나, 기타 기능을 사용할 수 있습니다. 어시스턴트는 구성된 확장 기능을 기반으로 다양한 LLM 공급자와 상호 작용하여 응답을 제공합니다. 구성된 확장 기능이 제공하는 맥락 정보로 인해 어시스턴트는 도메인 특화 질문에 답변하고 관련 정보를 제공할 수 있습니다.

이 애플리케이션은 모듈식이고 확장 가능하도록 설계되어, 사용자가 확장 기능을 추가하여 다양한 기능을 가진 어시스턴트를 만들 수 있습니다.

![기본 사용법의 짧은 데모 영상](https://raw.githubusercontent.com/codecentric/c4-genai-suite/main/demo/preview.webp)

## 주요 기능

### 대형 언어 모델(LLM) 및 멀티모달 모델

c4 GenAI Suite는 이미 많은 모델을 직접 지원합니다. 선호하는 모델이 아직 지원되지 않는 경우, 해당 모델을 지원하는 확장 기능을 쉽게 작성할 수 있습니다.

* OpenAI 호환 모델
* Azure OpenAI 모델
* Bedrock 모델
* Google GenAI 모델
* Ollama 호환 모델
### 검색 증강 생성(RAG)

c4 GenAI Suite에는 LLM이 파일을 사용할 수 있도록 준비하는 서버인 REI-S가 포함되어 있습니다.

* REI-S, 맞춤형 통합 RAG 서버
  * 벡터 저장소
    * pgvector
    * Azure AI Search
  * 임베딩 모델
    * OpenAI 호환 임베딩
    * Azure OpenAI 임베딩
    * Ollama 호환 임베딩
  * 파일 형식:
    * pdf, docx, pptx, xlsx, ...
    * 오디오 파일 음성 전사(Whisper 사용)

### 확장 기능

c4 GenAI Suite는 확장성을 염두에 두고 설계되었습니다. 확장 프로그램을 작성하는 것도, 이미 존재하는 MCP 서버를 사용하는 것도 쉽습니다.

* 모델 컨텍스트 프로토콜(MCP) 서버
* 맞춤형 systemprompt
* Bing 검색
* 계산기
## 시작하기

### Docker-Compose 사용하기

- 프로젝트 루트에서 `docker compose up`을 실행합니다.
- 브라우저에서 [애플리케이션](http://localhost:3333)을 엽니다. 기본 로그인 자격 증명은 사용자 `admin@example.com`과 비밀번호 `secret`입니다.

![assistant 구성 동영상](https://raw.githubusercontent.com/codecentric/c4-genai-suite/main/demo/assistants.webp)

### Helm & Kubernetes 사용하기

Kubernetes 환경에서 배포하려면 [Helm Chart의 README](https://raw.githubusercontent.com/codecentric/c4-genai-suite/main/./helm-chart/README.md)를 참고하세요.

### 어시스턴트 및 확장 기능 설정

c4 GenAI Suite는 *어시스턴트*를 중심으로 작동합니다.  
각 어시스턴트는 확장 기능 세트로 구성되며, 이 확장 기능들이 LLM 모델과 사용할 수 있는 도구를 결정합니다.

- 관리자 영역(좌측 하단의 사용자명을 클릭)에서 [어시스턴트 섹션](http://localhost:3333/admin/assistants)으로 이동합니다.
- 섹션 제목 옆의 초록색 `+` 버튼을 눌러 어시스턴트를 추가합니다. 이름과 설명을 입력하세요.
- 생성한 어시스턴트를 선택하고 초록색 `+ 확장 추가` 버튼을 클릭합니다.
- 모델을 선택하고 자격 증명을 입력합니다.
- `테스트` 버튼으로 정상 동작 여부를 확인한 후 `저장`합니다.

이제 [채팅 페이지](http://localhost:3333/chat)로 돌아가서(좌측 상단의 `c4 GenAI Suite` 클릭) 새로운 어시스턴트로 대화를 시작할 수 있습니다.

> [!TIP]
> 우리의 `docker-compose`에는 CPU에서 실행되는 로컬 Ollama가 포함되어 있습니다. 빠른 테스트용으로 사용할 수 있습니다. 그러나 속도가 느리기 때문에 다른 모델 사용을 권장합니다. 만약 사용하고 싶다면, 어시스턴트에 다음과 같이 모델 확장 기능을 추가하세요.
> * 확장: `Dev: Ollama`
> * 엔드포인트: `http://ollama:11434`
> * 모델: `llama3.2`
### 모델 컨텍스트 프로토콜 (MCP) [선택 사항]

`MCP Tools` 확장 기능이 포함된 `sse` 인터페이스를 제공하는 모든 MCP 서버를 사용하세요 (또는 `mcp-tool-as-server`를 프록시로 하여 `stdio` MCP 서버 앞에 둘 수도 있습니다).
각 MCP 서버는 확장 기능으로 세부적으로 구성할 수 있습니다.

### 검색 증강 생성(RAG) / 파일 검색 [선택 사항]

사용자가 제공한 파일을 검색하기 위해 우리의 RAG 서버인 `REI-S`를 사용하세요. 어시스턴트에 대해 `Search Files` 확장 기능만 구성하면 됩니다.
이 프로세스는 [ `services/reis` 하위 디렉터리](services/reis/#example-configuration-in-c4)에서 자세히 설명되어 있습니다.

## 기여 및 개발

* 기여 방법에 대한 지침은 [CONTRIBUTING.md](https://raw.githubusercontent.com/codecentric/c4-genai-suite/main/CONTRIBUTING.md)를 참조하세요.
* 개발자 온보딩을 위해서는 [DEVELOPERS.md](https://raw.githubusercontent.com/codecentric/c4-genai-suite/main/DEVELOPERS.md)를 확인하세요.

## 주요 구성 요소

이 애플리케이션은 **프론트엔드**, **백엔드**, 그리고 **REI-S** 서비스로 구성되어 있습니다.

```
┌──────────┐
│   사용자   │
└─────┬────┘
      │ 접근
      ▼
┌──────────┐
│ 프론트엔드 │
└─────┬────┘
      │ 접근
      ▼
┌──────────┐     ┌─────────────────┐
│ 백엔드   │────►│      LLM        │
└─────┬────┘     └─────────────────┘
      │ 접근
      ▼
┌──────────┐     ┌─────────────────┐
│  REI-S   │────►│ 임베딩 모델     │
│          │     └─────────────────┘
│          │
│          │     ┌─────────────────┐
│          │────►│ 벡터 스토어     │
└──────────┘     └─────────────────┘
```
### 프론트엔드

프론트엔드는 React와 TypeScript로 구축되어, 백엔드 및 REI-S 서비스와 상호작용할 수 있는 사용자 친화적인 인터페이스를 제공합니다. 이 인터페이스는 어시스턴트, 확장 기능, 채팅 기능 관리를 위한 다양한 기능을 포함하고 있습니다.

> 소스: `/frontend`

### 백엔드

백엔드는 NestJS와 TypeScript를 사용하여 개발되었으며, 애플리케이션의 주요 API 계층 역할을 합니다. 프론트엔드에서 오는 요청을 처리하고, llm 공급자와 상호작용하여 채팅 기능을 지원합니다. 또한 백엔드는 어시스턴트 및 그 확장 기능을 관리하며, 사용자가 다양한 AI 모델을 구성하고 채팅에 사용할 수 있도록 지원합니다.

추가로, 백엔드는 사용자 인증을 관리하고, 파일 인덱싱 및 검색을 위해 REI-S 서비스와 통신합니다.

데이터 영속성을 위해 백엔드는 **PostgreSQL** 데이터베이스를 사용합니다.

> 소스: `/backend`

### REI-S

REI-S(**R**etrieval **E**xtraction **I**ngestion **S**erver)는 Python 기반의 서버로, 기본적인 RAG(Retrieval-Augmented Generation) 기능을 제공합니다. 이 서버는 파일 콘텐츠 추출, 인덱싱, 쿼리 기능을 제공하여 애플리케이션이 대용량 데이터셋을 효율적으로 처리할 수 있도록 지원합니다. REI-S 서비스는 백엔드와 원활하게 연동되도록 설계되어, 채팅 기능 및 파일 검색에 필요한 데이터를 제공합니다.

REI-S는 벡터 저장소로 Azure AI Search와 pgvector를 지원하여, 유연하고 확장 가능한 데이터 검색 옵션을 제공합니다. 서비스는 환경 변수를 통해 벡터 저장소 유형 및 연결 정보를 지정하여 구성할 수 있습니다.

> 소스: `/services/reis`

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-09

---