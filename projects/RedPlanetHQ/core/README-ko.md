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

### CORE: Claude, Cursor, ChatGPT 및 모든 AI 도구를 위한 통합 메모리 레이어

<p align="center">
    <a href="https://deepwiki.com/RedPlanetHQ/core">
        <img src="https://deepwiki.com/badge.svg" alt="DeepWiki 배지" />
    </a>
</p>
<p align="center">
    <a href="https://docs.heysol.ai/core/overview"><b>문서</b></a> •
    <a href="https://discord.gg/YGUZcvDjUa"><b>디스코드</b></a>
</p>
</div>

## 🔥 연구 하이라이트

CORE 메모리는 Locomo 데이터셋의 모든 추론 작업에서 평균 **88.24%** 정확도를 달성하며, 다른 메모리 제공자들보다 현저히 우수한 성능을 보입니다. 자세한 내용은 이 [블로그](https://blog.heysol.ai/we-built-memory-for-individuals-and-achieved-sota-on-locomo-benchmark/)를 참고하세요.

<img width="6048" height="3428" alt="benchmark" src="https://github.com/user-attachments/assets/2e5fdac5-02ed-4d00-9312-c21d09974e1f" />
(1) 싱글 홉 질문은 한 세션의 정보만으로 답변해야 합니다; (2) 멀티 홉 질문은 서로 다른 여러 세션에서 정보를 종합해야 합니다; (3) 오픈 도메인 지식 질문은 화자가 제공한 정보와 상식이나 세계 사실과 같은 외부 지식을 결합하여 답변할 수 있습니다; (4) 시간적 추론 질문은 대화 내 시간 관련 데이터 단서를 포착하여 시간 추론을 통해 답변할 수 있습니다;

## 개요

**문제점** 

개발자들은 AI 도구에 맥락을 반복해서 설명하는 데 시간을 낭비합니다. Claude에서 토큰 한도에 도달하면 모든 것을 잃고 새로 시작해야 합니다. ChatGPT/Claude에서 Cursor로 전환하면 맥락을 다시 설명해야 합니다. 당신의 대화, 결정, 인사이트가 세션 사이에서 사라집니다. 새로운 AI 도구마다 맥락 전환의 비용이 커집니다.

**해결책** - **CORE** (**Contextual Observation & Recall Engine**)

CORE는 모든 AI 도구에 사용할 수 있는 오픈소스 통합 영속적 메모리 레이어입니다. Cursor에서 Claude, ChatGPT, Claude Code로 이동해도 당신의 맥락이 따라갑니다. 하나의 지식 그래프가 누가, 언제, 무엇을, 왜 말했는지 기억합니다. 한 번 연결하면 어디서든 기억합니다. 맥락을 관리하는 대신, 바로 구축을 시작하세요.

## 🚀 시작하기
**5분 만에 통합 메모리 그래프를 구축하세요:**

1. [core.heysol.ai](https://core.heysol.ai)에서 **회원가입** 후 계정 생성
2. **첫 메모리 추가** - 자신에 대한 맥락을 공유하세요

    <img width="2088" height="1212" alt="first-memory" src="https://github.com/user-attachments/assets/ecfab88e-e91a-474d-9ef5-fc6c19b655a8" />


3. **메모리 그래프 시각화** - CORE가 사실 간 연결을 자동으로 형성하는 것을 확인
5. **테스트하기** - conversatio 섹션에서 "나에 대해 무엇을 알고 있나요?"라고 물어보세요
6. 도구에 연결:
   - [Claude](https://docs.heysol.ai/providers/claude) & [Cursor](https://docs.heysol.ai/providers/cursor) - 맥락을 포함한 코딩
   - [CLaude Code CLI](https://docs.heysol.ai/providers/claude-code) & [Gemini CLI](https://docs.heysol.ai/providers/claude-code) - 터미널 기반 메모리 코딩
   - [브라우저 확장 프로그램 추가](https://docs.heysol.ai/providers/browser-extension) - 모든 웹사이트에서 당신의 메모리를 사용하세요
   - [Linear](https://docs.heysol.ai/integrations/linear), [Github](https://docs.heysol.ai/integrations/github) - 프로젝트 컨텍스트를 자동으로 추가

## 🧩 주요 기능

### 🧠 **통합 및 휴대 가능한 메모리**: 
MCP를 통해 **Cursor, Windsurf, Claude Desktop, Claude Code, Gemini CLI, AWS의 Kiro, VS Code, Roo Code** 전반에서 메모리를 추가하고 불러올 수 있습니다.

![core-claude](https://github.com/user-attachments/assets/56c98288-ee87-4cd0-8b02-860aca1c7f9a)

### 🕸️ **시간 기반 + 실체화된 지식 그래프**: 

모든 사실의 배경 스토리를 기억합니다—누가, 언제, 왜 무엇을 말했는지 풍부한 관계와 완전한 출처로 추적하며, 단순 저장을 넘어서 관리합니다.

![core-memory-graph](https://github.com/user-attachments/assets/5d1ee659-d519-4624-85d1-e0497cbdd60a)

### 🌐 **브라우저 확장 프로그램**: 

ChatGPT, Grok, Gemini, Twitter, YouTube, 블로그 글, 그리고 모든 웹페이지에서 대화 및 콘텐츠를 CORE 메모리로 직접 저장하세요.

**확장 프로그램 사용 방법**
1. [확장 프로그램 다운로드](https://chromewebstore.google.com/detail/core-extension/cglndoindnhdbfcbijikibfjoholdjcc) 크롬 웹 스토어에서 다운로드하세요.
2. [CORE 대시보드](https://core.heysol.ai)에 로그인
   - 설정(왼쪽 하단)으로 이동
   - API 키 → 새 키 생성 → “extension”으로 이름 지정
3. 확장 프로그램을 열고 API 키를 붙여넣고 저장하세요.

https://github.com/user-attachments/assets/6e629834-1b9d-4fe6-ae58-a9068986036a

### 💬 **메모리와 대화**: 
"내 글쓰기 선호도는?"과 같은 질문을 연결된 지식에서 즉시 통찰로 받아보세요.

![chat-with-memory](https://github.com/user-attachments/assets/d798802f-bd51-4daf-b2b5-46de7d206f66)

### ⚡ **앱에서 자동 동기화**:

Linear, Slack, Notion, GitHub 및 기타 연결된 앱에서 관련 컨텍스트를 자동으로 CORE 메모리에 캡처합니다.





📖 **[모든 통합 보기](https://raw.githubusercontent.com/RedPlanetHQ/core/main/./integrations/README.md)** - 지원되는 서비스 및 기능의 전체 목록

![core-slack](https://github.com/user-attachments/assets/d5fefe38-221e-4076-8a44-8ed673960f03)


### 🔗 **MCP 통합 허브**:

Linear, Slack, GitHub, Notion을 한 번 CORE에 연결하면, Claude, Cursor 또는 MCP 클라이언트에서 단일 URL로 모든 도구를 사용할 수 있습니다.


![core-linear-claude](https://github.com/user-attachments/assets/7d59d92b-8c56-4745-a7ab-9a3c0341aa32)



## CORE가 메모리를 생성하는 방식

<img width="12885" height="3048" alt="memory-ingest-diagram" src="https://github.com/user-attachments/assets/c51679de-8260-4bee-bebf-aff32c6b8e13" />

CORE의 인게스트 파이프라인은 변화하는 컨텍스트를 포착하기 위해 네 가지 단계로 구성됩니다:

1. **정규화**: 새로운 정보를 최근 컨텍스트에 연결하고, 긴 문서를 일관성 있는 청크로 분할하며 교차 참조를 유지하고, 용어를 표준화합니다. 이를 통해 CORE가 지식을 추출할 때 깨끗하고 맥락화된 입력을 사용하게 되어 지저분한 텍스트 대신 정제된 정보를 다룹니다.
2. **추출**: 정규화된 텍스트에서 의미를 추출하여 엔티티(사람, 도구, 프로젝트, 개념)를 식별하고, 이를 컨텍스트, 출처, 시간과 함께 진술로 변환하며, 관계를 맵핑합니다. 예를 들어, “우리는 CORE를 Next.js로 작성했다”는 엔티티(Core, Next.js), 진술(CORE는 Next.js로 개발됨), 관계(개발에 사용됨)로 변환됩니다.
3. **해결**: 모순을 감지하고, 선호도의 변화를 추적하며, 여러 관점을 출처와 함께 보존하여 덮어쓰지 않고 메모리가 전체 여정을 반영하도록 합니다. 최신 스냅샷만이 아닌 모든 과정을 기억합니다.
4. **그래프 통합**: 엔티티, 진술, 에피소드를 시간적 지식 그래프로 연결하여 사실을 그들의 컨텍스트와 이력에 연결하고, 고립된 데이터를 에이전트가 실제로 사용할 수 있는 살아있는 지식 네트워크로 만듭니다.

결과: 평면 데이터베이스 대신 CORE는 컨텍스트, 진화, 소유권을 보존하는 메모리를 제공합니다. 에이전트가 실제로 활용할 수 있도록 성장하고 변화하는 메모리를 제공합니다.


![memory-ingest-eg](https://github.com/user-attachments/assets/1d0a8007-153a-4842-9586-f6f4de43e647)

## CORE가 메모리에서 정보를 호출하는 방식

<img width="10610" height="3454" alt="memory-search-diagram" src="https://github.com/user-attachments/assets/3541893e-f7c9-42b9-8fad-6dabf138dbeb" />

CORE에 질문하면 단순히 텍스트를 조회하는 것이 아니라 전체 지식 그래프를 탐색하여 가장 유용한 답을 찾습니다.

1. **검색**: CORE는 메모리를 여러 각도에서 동시에 탐색합니다. 정확한 키워드 검색, 다르게 표현된 관련 아이디어를 위한 의미 검색, 연결된 개념 사이의 링크를 따라가는 그래프 탐색을 수행합니다.
2. **재정렬**: 검색된 결과는 가장 관련성 높고 다양한 항목이 강조되도록 재정렬되어, 단순한 일치뿐만 아니라 더 깊은 연결도 볼 수 있습니다.
3. **필터링**: CORE는 시간, 신뢰성, 관계 강도를 기반으로 스마트 필터를 적용해 가장 의미 있는 지식만을 표면화합니다.
4. **출력**: 명확한 사실(선명한 진술)과 에피소드(그 사실이 나온 원래 맥락)를 모두 반환하므로, 모든 기억은 항상 맥락, 시간, 이야기 속에 기반합니다.

결과: CORE는 단순히 사실만을 기억하는 것이 아니라, 올바른 맥락, 시간, 이야기 속에서 기억하므로, 에이전트가 여러분이 기억하는 방식으로 응답할 수 있습니다.

## 문서

CORE를 최대한 활용하기 위해 문서를 탐색하세요

- [기본 개념](https://docs.heysol.ai/concepts/memory_graph)
- [셀프 호스팅](https://docs.heysol.ai/self-hosting/overview)
- [Core MCP와 Claude 연결](https://docs.heysol.ai/providers/claude)
- [Core MCP와 Cursor 연결](https://docs.heysol.ai/providers/cursor)

- [기본 개념](https://docs.heysol.ai/overview)
- [API 참조](https://docs.heysol.ai/local-setup)

## 🔒 보안

CORE는 보안을 매우 중요하게 생각합니다. 데이터 보호를 위해 업계 표준의 보안 관행을 구현합니다:

- **데이터 암호화**: 모든 전송 중 데이터(TLS 1.3) 및 저장 데이터(AES-256)
- **인증**: OAuth 2.0 및 매직 링크 인증
- **접근 제어**: 워크스페이스 기반 격리 및 역할 기반 권한
- **취약점 신고**: 보안 문제는 harshith@tegon.ai로 신고해 주세요

자세한 보안 정보는 [보안 정책](https://raw.githubusercontent.com/RedPlanetHQ/core/main/SECURITY.md)을 참조하세요.

## 🧑‍💻 지원

질문이나 피드백이 있으신가요? 저희가 도와드리겠습니다:

- Discord: [core-support 채널 참여](https://discord.gg/YGUZcvDjUa)
- 문서: [docs.heysol.ai](https://docs.heysol.ai)
- 이메일: manik@poozle.dev

## 사용 지침

**저장:**

- 대화 기록
- 사용자 환경설정
- 작업 컨텍스트
- 참고 자료

**저장하지 마세요:**

- 민감한 데이터(PII)
- 자격 증명
- 시스템 로그
- 임시 데이터

## 👥 기여자

<a href="https://github.com/RedPlanetHQ/core/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=RedPlanetHQ/core" />
</a>








---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-30

---