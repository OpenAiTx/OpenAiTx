<div align="right">
  <details>
    <summary >🌐 언어</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

<div align="center">
  <a href="https://core.heysol.ai">
    <img src="https://github.com/user-attachments/assets/89066cdd-204b-46c2-8ad4-4935f5ca9edd" width="200px" alt="CORE 로고" />
  </a>

### CORE: AI 앱을 위한 당신의 개인 메모리 레이어

<p align="center">
    <a href="https://deepwiki.com/RedPlanetHQ/core">
        <img src="https://deepwiki.com/badge.svg" alt="DeepWiki 배지" />
    </a>
</p>
<p align="center">
    <a href="https://docs.heysol.ai/introduction"><b>문서</b></a> •
    <a href="https://discord.gg/YGUZcvDjUa"><b>디스코드</b></a>
</p>
</div>

## 🔥 연구 하이라이트

CORE 메모리는 모든 추론 작업에서 Locomo 데이터셋 기준 **88.24%**의 평균 정확도를 달성했으며, 다른 메모리 제공자 대비 현저히 뛰어난 성능을 보였습니다. 자세한 내용은 이 [블로그](https://blog.heysol.ai/core-build-memory-knowledge-graph-for-individuals-and-achieved-sota-on-locomo-benchmark/)를 참고하세요.

<img width="6048" height="3428" alt="benchmark" src="https://github.com/user-attachments/assets/2e5fdac5-02ed-4d00-9312-c21d09974e1f" />
(1) 단일 홉 질문은 하나의 세션을 기반으로 답변이 필요합니다; (2) 다중 홉 질문은 여러 다른 세션의 정보를 종합하여 답해야 합니다; (3) 오픈 도메인 지식 질문은 화자가 제공한 정보와 상식이나 세계적 사실 등 외부 지식을 통합하여 답할 수 있습니다; (4) 시간적 추론 질문은 대화 내 시간 관련 데이터 단서를 포착하고 시간적 추론을 통해 답할 수 있습니다;

## 개요

**문제점**

개발자들은 AI 도구에 컨텍스트를 반복해서 설명하느라 시간을 낭비합니다. Claude에서 토큰 한도에 도달하면? 새로 시작하고 모든 내용을 잃게 됩니다. ChatGPT/Claude에서 Cursor로 전환하면? 다시 컨텍스트를 설명해야 합니다. 대화, 결정, 인사이트가 세션 간에 사라집니다. 새로운 AI 도구를 쓸 때마다 컨텍스트 전환 비용이 커집니다.

**해결책** - **CORE** (**Contextual Observation & Recall Engine**)

CORE는 모든 AI 도구에 사용할 수 있는 오픈소스 통합 영구 메모리 레이어입니다. Cursor에서 Claude, ChatGPT, Claude Code로 컨텍스트가 따라다닙니다. 하나의 지식 그래프가 누가 언제 무엇을 왜 말했는지 기억합니다. 한 번 연결하면 어디서든 기억합니다. 컨텍스트 관리 대신 구축에 집중하세요.

## 🚀 CORE 셀프 호스팅
CORE를 자체 인프라에 실행하고 싶으신가요? 셀프 호스팅은 데이터와 배포에 대한 완전한 제어권을 제공합니다.

**사전 조건**:

- Docker(20.10.0+) 및 Docker Compose(2.20.0+) 설치
- OpenAI API 키

> **오픈소스 모델 관련 참고:** Ollama와 GPT 모델 등 OSS 옵션도 테스트했으나, 사실 추출 및 그래프 품질이 미흡했습니다. 더 나은 옵션을 적극적으로 찾고 있습니다.

### 설치

1. 저장소를 클론하세요:
```
git clone https://github.com/RedPlanetHQ/core.git
cd core
```
2. `core/.env`에서 환경 변수를 구성합니다:
```
OPENAI_API_KEY=your_openai_api_key
```
3. 서비스를 시작합니다
```
docker-compose up -d
```
배포가 완료되면, AI 공급자(OpenAI, Anthropic)를 구성하고 메모리 그래프 구축을 시작할 수 있습니다.

👉 [전체 셀프 호스팅 가이드 보기](https://docs.heysol.ai/self-hosting/docker)

참고: Ollama나 GPT OSS 같은 오픈소스 모델을 시도했지만 사실 생성이 좋지 않아, 개선 방안을 찾고 있으며 이후 OSS 모델도 지원할 예정입니다.

## 🚀 CORE Cloud
**5분 만에 통합 메모리 그래프 구축:**

인프라 관리를 원하지 않으시나요? CORE Cloud는 개인 메모리 시스템을 즉시 구축할 수 있도록 해줍니다 - 설정 필요 없음, 서버 필요 없음, 바로 작동하는 메모리.

1. [core.heysol.ai](https://core.heysol.ai)에서 **회원가입** 후 계정 생성
2. **메모리 그래프 시각화** 및 CORE가 사실 간 연결을 자동으로 형성하는 과정 확인
3. **테스트하기** - 대화 섹션에서 "나에 대해 무엇을 알고 있나요?"라고 질문해보세요
4. 도구 연결:
   - [Claude](https://docs.heysol.ai/providers/claude) & [Cursor](https://docs.heysol.ai/providers/cursor) - 맥락 있는 코딩
   - [Claude Code CLI](https://docs.heysol.ai/providers/claude-code) & [Codex CLI](https://docs.heysol.ai/providers/codex) - 메모리 기반 터미널 코딩
   - [브라우저 확장 프로그램 추가](https://docs.heysol.ai/providers/browser-extension) - 웹사이트 어디서든 메모리 활용
   - [Linear](https://docs.heysol.ai/integrations/linear), [Github](https://docs.heysol.ai/integrations/github) - 프로젝트 맥락 자동 추가

## 🧩 주요 기능

### 🧠 **통합, 휴대형 메모리**: 
MCP를 통해 **Cursor, Windsurf, Claude Desktop, Claude Code, Gemini CLI, AWS의 Kiro, VS Code, Roo Code**에서 메모리 추가 및 조회

![core-claude](https://github.com/user-attachments/assets/56c98288-ee87-4cd0-8b02-860aca1c7f9a)


### 🕸️ **시간 기반 + 실체화 지식 그래프**: 

모든 사실의 배경 스토리 기억—누가, 언제, 왜 말했는지 풍부한 관계와 전체 출처로 추적, 단순 저장이 아님

![core-memory-graph](https://github.com/user-attachments/assets/5d1ee659-d519-4624-85d1-e0497cbdd60a)


### 🌐 **브라우저 확장 프로그램**: 

ChatGPT, Grok, Gemini, Twitter, YouTube, 블로그 글, 모든 웹페이지의 대화 및 콘텐츠를 직접 CORE 메모리에 저장하세요.


**확장 프로그램 사용 방법**
1. [Chrome 웹 스토어](https://chromewebstore.google.com/detail/core-extension/cglndoindnhdbfcbijikibfjoholdjcc)에서 확장 프로그램을 다운로드합니다.
2. [CORE 대시보드](https://core.heysol.ai)에 로그인합니다.
   - 설정(왼쪽 하단)으로 이동합니다.
   - API Key → 새 키 생성 → 이름을 “extension”으로 지정합니다.
3. 확장 프로그램을 열고, API 키를 붙여넣고 저장합니다.

https://github.com/user-attachments/assets/6e629834-1b9d-4fe6-ae58-a9068986036a


### 💬 **메모리와 채팅하기**:
"내 글쓰기 선호도는 무엇입니까?"와 같은 질문을 통해 연결된 지식에서 즉각적으로 인사이트를 얻으세요

![chat-with-memory](https://github.com/user-attachments/assets/d798802f-bd51-4daf-b2b5-46de7d206f66)


### ⚡ **앱에서 자동 동기화**:

Linear, Slack, Notion, GitHub 등 연결된 앱에서 관련 컨텍스트를 자동으로 CORE 메모리에 캡처합니다

📖 **[전체 통합 보기](https://raw.githubusercontent.com/RedPlanetHQ/core/main/./integrations/README.md)** - 지원되는 서비스와 기능의 전체 목록

![core-slack](https://github.com/user-attachments/assets/d5fefe38-221e-4076-8a44-8ed673960f03)


### 🔗 **MCP 통합 허브**: 

Linear, Slack, GitHub, Notion을 한 번 CORE에 연결하면 Claude, Cursor 또는 모든 MCP 클라이언트에서 하나의 URL로 모든 도구를 사용할 수 있습니다.


![core-linear-claude](https://github.com/user-attachments/assets/7d59d92b-8c56-4745-a7ab-9a3c0341aa32)



## CORE가 메모리를 생성하는 방법

<img width="12885" height="3048" alt="memory-ingest-diagram" src="https://github.com/user-attachments/assets/c51679de-8260-4bee-bebf-aff32c6b8e13" />

CORE의 인제션 파이프라인은 변화하는 컨텍스트를 포착하기 위해 네 가지 단계로 구성됩니다:

1. **정규화**: 새로운 정보를 최근 맥락과 연결하고, 긴 문서를 일관성 있는 청크로 분리하며 교차 참조를 유지하고, 용어를 표준화하여 CORE가 지식을 추출할 때 복잡한 텍스트 대신 깨끗하고 맥락화된 입력을 사용할 수 있도록 합니다.
2. **추출**: 정규화된 텍스트에서 의미를 추출하고, 엔티티(인물, 도구, 프로젝트, 개념)를 식별하여 맥락, 출처, 시간과 함께 진술로 변환하며, 관계를 맵핑합니다. 예를 들어 “We wrote CORE in Next.js”는 엔티티(Core, Next.js), 진술(CORE는 Next.js로 개발됨), 관계(개발에 사용됨)로 전환됩니다.
3. **해결**: 모순을 감지하고, 선호도가 어떻게 진화하는지 추적하며, 여러 관점을 출처와 함께 보존하여 최신 스냅샷만 남기는 것이 아니라 전체 여정을 기억에 반영합니다.
4. **그래프 통합**: 엔티티, 진술, 에피소드를 시간 기반 지식 그래프로 연결하여 사실을 그들의 맥락과 역사에 연결하고, 단절된 데이터를 실제로 에이전트가 활용할 수 있는 살아있는 지식망으로 전환합니다.

결과: 평면적인 데이터베이스가 아닌, CORE는 맥락, 진화, 소유권을 보존하며 여러분과 함께 성장하고 변화하는 기억을 제공하여 에이전트가 실제로 사용할 수 있도록 합니다.


![memory-ingest-eg](https://github.com/user-attachments/assets/1d0a8007-153a-4842-9586-f6f4de43e647)

## CORE가 기억에서 정보를 회상하는 방법

<img width="10610" height="3454" alt="memory-search-diagram" src="https://github.com/user-attachments/assets/3541893e-f7c9-42b9-8fad-6dabf138dbeb" />

CORE에 질문을 하면, 단순히 텍스트를 조회하는 것이 아니라 전체 지식 그래프를 탐색하여 가장 유용한 답을 찾습니다.

1. **검색**: CORE는 메모리를 여러 관점에서 동시에 탐색합니다. 키워드 검색으로 정확한 일치 항목, 의미론적 검색으로 다르게 표현된 관련 아이디어, 그래프 탐색으로 연결된 개념 간의 링크를 따라갑니다.
2. **재정렬**: 검색된 결과를 가장 관련성 높고 다양한 항목이 돋보이도록 재정렬하여, 단순한 일치뿐만 아니라 더 깊은 연결도 확인할 수 있습니다.
3. **필터링**: CORE는 시간, 신뢰도, 관계 강도를 기반으로 스마트 필터를 적용하여 가장 의미 있는 지식만을 표면화합니다.
4. **출력**: 명확한 진술(사실)과 그들이 출처가 된 에피소드(원래 맥락) 모두를 반환하므로, 회상은 항상 맥락, 시간, 스토리에 기반합니다.

결과: CORE는 단순히 사실을 회상하는 것이 아니라, 올바른 맥락, 시간, 이야기 속에서 회상하여 에이전트가 여러분이 기억하는 방식으로 응답할 수 있도록 합니다.

## 문서

CORE를 최대한 활용할 수 있도록 문서를 탐색하세요

- [기본 개념](https://docs.heysol.ai/concepts/memory_graph)
- [셀프 호스팅](https://docs.heysol.ai/self-hosting/overview)
- [Core MCP와 Claude 연결](https://docs.heysol.ai/providers/claude)
- [Core MCP와 Cursor 연결](https://docs.heysol.ai/providers/cursor)
- [Core MCP와 Claude Code 연결](https://docs.heysol.ai/providers/claude-code)
- [Core MCP와 Codex 연결](https://docs.heysol.ai/providers/codex) 

- [기본 개념](https://docs.heysol.ai/overview)
- [API 레퍼런스](https://docs.heysol.ai/api-reference/get-user-profile)

## 🔒 보안

CORE는 보안을 매우 중요하게 생각합니다. 우리는 업계 표준 보안 관행을 적용하여 여러분의 데이터를 보호합니다:

- **데이터 암호화**: 전송 중 데이터(TLS 1.3) 및 저장 데이터(AES-256)
- **인증**: OAuth 2.0 및 매직 링크 인증
- **접근 제어**: 워크스페이스 기반 격리 및 역할 기반 권한
- **취약점 신고**: 보안 문제는 harshith@poozle.dev로 신고해 주세요

자세한 보안 정보는 [보안 정책](https://raw.githubusercontent.com/RedPlanetHQ/core/main/SECURITY.md)을 참조하세요.

## 🧑‍💻 지원

질문이나 피드백이 있으신가요? 언제든 도와드리겠습니다:

- 디스코드: [core-support 채널 참여](https://discord.gg/YGUZcvDjUa)
- 문서: [docs.heysol.ai](https://docs.heysol.ai)
- 이메일: manik@poozle.dev

## 사용 지침

**저장:**

- 대화 기록
- 사용자 환경설정
- 작업 컨텍스트
- 참고 자료

**저장하지 않음:**

- 민감 데이터(PII)
- 인증 정보
- 시스템 로그
- 임시 데이터

## 👥 기여자

<a href="https://github.com/RedPlanetHQ/core/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=RedPlanetHQ/core" />
</a>















---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-16

---