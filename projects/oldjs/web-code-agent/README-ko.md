<translate-content><!-- GitHub 배지 -->
<p align="center">
  <a href="https://github.com/oldjs/web-code-agent/stargazers"><img src="https://img.shields.io/github/stars/oldjs/web-code-agent?style=social" alt="GitHub 별"></a>
  <a href="https://github.com/oldjs/web-code-agent/network/members"><img src="https://img.shields.io/github/forks/oldjs/web-code-agent?style=social" alt="GitHub 포크"></a>
  <a href="https://github.com/oldjs/web-code-agent/issues"><img src="https://img.shields.io/github/issues/oldjs/web-code-agent" alt="GitHub 이슈"></a>
</p>

<p align="center">
  <a href="https://github.com/oldjs/web-code-agent/blob/main/preview.md">
    <img src="https://img.shields.io/badge/Preview-Click%20Here-blue" alt="미리보기">
  </a>
</p>

<p align="center">
  <a href="#zh-cn">简体中文</a> | <a href="#en-us">English</a>
</p>

# Folda-Scan: 코드베이스를 위한 나만의 AI 내비게이터 및 Q&A 엔진 🚀
[![라이선스: MIT](https://img.shields.io/badge/License-MIT-green.svg)](https://opensource.org/licenses/MIT)
[![GitHub 저장소 별](https://img.shields.io/github/stars/oldjs/web-code-agent?style=social)](https://github.com/oldjs/web-code-agent/stargazers)

---

<p align="center">
  <em>AI와 함께 코드베이스를 로컬에서, 개인정보 보호는 그대로 유지하며 잠금 해제하세요.</em>xs
</p>

---

<a name="en-us"></a>

**코드 미로에 갇히셨나요? AI 협업을 위한 지루한 컨텍스트 준비에 지치셨나요? Folda-Scan이 해결해 드립니다!** 💡

**Folda-Scan**은 혁신적인 지능형 프로젝트 Q&A 도구로, **브라우저 내에서 완전히 로컬로 실행**됩니다. 고급 의미 벡터화를 사용해 코드베이스를 대화형 파트너로 변환하여 코드 이해와 AI 협업을 전례 없이 간단하고 안전하게 만듭니다.

Folda-Scan은 ([WebFS-Toolkit](https://github.com/oldjs/web-code-agent)의 일부로서) 최첨단 웹 기술과 AI 알고리즘으로 구축되어 부드럽고 효율적이며 안전한 로컬 코드 상호작용 경험을 제공합니다.

### ✨ 주요 특징 (왜 Folda-Scan인가?)

- 🛡️ **절대적인 개인정보 보호, 로컬 실행**: 모든 데이터 처리가 브라우저 내 로컬에서 이루어지며, 코드가 **기기 밖으로 절대 나가지 않습니다**.
- 💬 **자연어로 코드와 '대화'하기**: 동료와 이야기하듯 코드베이스에 질문하고 정확한 답변을 받으세요.
- 🧠 **깊은 의미 이해**: 키워드를 넘어서 코드 내 진정한 의도와 복잡한 논리를 파악합니다.
- 🎯 **즉각적인 정보 위치 지정**: 모호한 설명에도 관련 코드 스니펫과 파일을 빠르게 찾아냅니다.
- 🤖 **LLM 협업 가속기**: 한 번의 클릭으로 컨텍스트 인식 마크다운을 생성해 AI 비서(ChatGPT, Claude 등)에 완벽하게 '공급'합니다.
- 💰 **토큰 비용 절감**: LLM 상호작용을 최적화해 API 호출 비용과 지연 시간을 크게 줄입니다.
- 🛠️ **스마트 구성 생성**: `Dockerfile` 같은 프로젝트 구성 파일 생성을 지원합니다.
- 🚀 **즉시 온보딩**: 명확한 안내로 빠르게 코드 탐색 여정을 시작할 수 있습니다.

### 🚀 작동 원리

Folda-Scan의 마법은 혁신적인 **의미 벡터화 엔진**에서 나옵니다:

1.  **로컬 스캔 및 인덱싱**: 선택한 로컬 프로젝트를 안전하게 스캔하고 의미 분석을 통해 코드를 고차원 벡터로 변환하여 브라우저 내에서 지식 인덱스를 구축합니다.
2.  **지능형 자연어 처리(NLP)**: 자연어 질문을 이해하고 이를 벡터로 변환합니다.
3.  **정확한 의미 매칭**: 벡터 공간에서 질문 벡터와 코드 내용을 효율적으로 매칭해 가장 관련성 높은 답변을 제공합니다.
    _모두 브라우저 내에서 효율적으로 수행되며, 데이터 프라이버시는 완벽히 보호됩니다._

### 🛠️ 기술 공개 (기술 스택)

- **핵심 프레임워크:** [Next.js 14](https://nextjs.org/)
- **로컬 파일 상호작용:** [File System Access API](https://developer.mozilla.org/en-US/docs/Web/API/File_System_Access_API)
- **AI & NLP:** 고급 의미 벡터 분석, 자연어 처리 알고리즘
- **주요 언어:** [JavaScript/TypeScript - 명시 필요]
  ### 🏁 시작하기

#### 전제 조건

- Node.js (권장 v16+ 또는 v18+, `package.json` 참고)
- npm (`package.json`에 명시된 버전 예: npm@10.x.x) / yarn / pnpm
- File System Access API를 지원하는 최신 브라우저 (예: 최신 Chrome, Edge)

### 💡 기본 사용법

1.  **폴더 선택**: 브라우저가 로컬 코드 프로젝트에 접근하도록 권한 부여.
2.  **인덱싱 대기**: Folda-Scan이 로컬에서 빠르게 의미 인덱스를 구축합니다.
3.  **질문 시작**: 자연어로 코드베이스에 질문하며 비밀을 밝혀내세요!

### 🤝 기여 안내 (기여하기)

우리는 모든 종류의 기여를 열렬히 환영합니다! 버그 리포트, 기능 제안, 코드 제출 등 무엇이든 환영합니다. 자세한 내용은 [기여 가이드라인](https://raw.githubusercontent.com/oldjs/web-code-agent/main/CONTRIBUTING.md)을 참조하세요. 함께 더 나은 Folda-Scan을 만들어 갑시다!

### 📄 라이선스

이 프로젝트는 [MIT 라이선스](LICENSE) 하에 라이선스가 부여됩니다.

---

<p align="center">
  <a href="#en-us">맨 위로 가기</a>
</p>
---

<a name="zh-cn"></a>

## Chinese

**代码迷宫中找不到方向？与 AI 协作时上下文准备太繁琐？ Folda-Scan 来拯救您！** 💡

**Folda-Scan** 是一款革命性的智能项目问答工具，它**完全在您的浏览器本地运行**，通过先进的语义向量化技术，将您的代码库转化为可对话的智能伙伴。告别繁琐，拥抱高效，让代码理解和 AI 协作变得前所未有地简单和安全。

Folda-Scan ([WebFS-Toolkit](https://github.com/oldjs/web-code-agent)의 일부로) 최첨단 웹 기술과 AI 알고리즘을 사용하여 매끄럽고 효율적이며 안전한 로컬 코드 상호작용의 새로운 경험을 제공합니다.

### ✨ 핵심 하이라이트 (왜 Folda-Scan인가?)

- 🛡️ **절대적인 프라이버시, 로컬 실행**: 모든 데이터 처리는 브라우저 로컬에서 이루어지며, 코드는 **절대 컴퓨터를 떠나지 않습니다**.
- 💬 **자연어로 코드와 대화**: 동료와 대화하듯 코드베이스에 질문하여 정확한 답변을 얻습니다.
- 🧠 **심층 의미 이해**: 키워드를 넘어서 코드의 진짜 의도와 복잡한 로직을 이해합니다.
- 🎯 **초단위 정보 위치 지정**: 모호한 설명도 신속하게 관련 코드 조각과 파일을 찾아냅니다.
- 🤖 **LLM 협업 가속기**: 한 번의 클릭으로 문맥 인식 Markdown을 생성해 AI 비서(ChatGPT, Claude 등)에 완벽한 ‘먹이’를 제공합니다.
- 💰 **토큰 비용 대폭 절감**: LLM 상호작용을 최적화하여 API 호출 비용과 대기 시간을 크게 줄입니다.
- 🛠️ **스마트 구성 생성**: `Dockerfile` 등 프로젝트 구성 파일 생성을 지원합니다.
- 🚀 **즉시 시작 가능**: 명확한 프로젝트 실행 안내로 빠르게 코드 탐험을 시작하세요.

### 🚀 작동 원리 (How It Works)

Folda-Scan의 마법은 혁신적인 **의미 벡터화 엔진**에 기반합니다:

1.  **로컬 스캔 및 인덱싱**: 선택한 로컬 프로젝트를 안전하게 스캔하고 의미 분석을 통해 코드를 고차원 벡터로 변환하여 브라우저 내 지식 인덱스를 구축합니다.
2.  **지능형 자연어 처리(NLP)**: 사용자의 자연어 질문을 이해하고 같은 방식으로 벡터화합니다.
3.  **정확한 의미 매칭**: 벡터 공간에서 질문과 코드 내용을 효율적으로 매칭하여 가장 관련성 높은 답변을 제공합니다.
    _이 모든 과정은 데이터 프라이버시를 보장하며 브라우저 내에서 효율적으로 수행됩니다._

### 🛠️ 기술 스택 (Tech Stack)

- **핵심 프레임워크:** [Next.js 14](https://nextjs.org/)
- **로컬 파일 상호작용:** [File System Access API](https://developer.mozilla.org/en-US/docs/Web/API/File_System_Access_API)
- **AI & NLP:** 최첨단 의미 벡터 분석 및 자연어 처리 알고리즘
- **주요 언어:** [JavaScript/TypeScript - 명시 필요]
  ### 🏁 빠른 시작 (Getting Started)

#### 환경 요구사항 (Prerequisites)

- Node.js (권장 v16+ 또는 v18+, `package.json` 참조)
- npm (`package.json` 참조, 예: npm@10.x.x) / yarn / pnpm
- File System Access API를 지원하는 최신 브라우저(예: 최신 버전 Chrome, Edge)

### 💡 기본 사용법 (Basic Usage)

1.  **폴더 선택**: 브라우저가 로컬 코드 프로젝트에 접근하도록 허용합니다.
2.  **인덱스 대기**: Folda-Scan이 로컬에서 빠르게 의미 인덱스를 구축합니다.
3.  **질문 시작**: 자연어로 코드베이스에 질문하며 그 비밀을 탐험하세요!

### 🤝 기여하기 (Contributing)

모든 형태의 기여를 환영합니다! 버그 리포트, 기능 제안, 코드 제출 등은 우리의 [기여 가이드](https://raw.githubusercontent.com/oldjs/web-code-agent/main/CONTRIBUTING.md) (있는 경우)를 참조하세요. 더 나은 Folda-Scan을 함께 만들어가길 기대합니다!

### 📄 오픈 소스 라이선스 (License)

본 프로젝트는 [MIT 라이선스](LICENSE)로 오픈 소스화되어 있습니다.

---

<p align="center">
  <a href="#zh-cn">상단으로 이동 (Back to Top)</a>
</p>
---


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-17

---