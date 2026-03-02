# 예시: 내 작업 폴더 정리를 도와주세요

https://github.com/user-attachments/assets/48743a51-705a-4c66-9fdb-4d7147f8098b


[简体中文](https://raw.githubusercontent.com/caiqinghua/Open-Claude-Cowork/main/README_ZH.md)

# Claude Cowork

**프로그래밍, 파일 관리 및 설명할 수 있는 모든 작업을 도와주는** 데스크탑 AI 비서입니다.

Claude Code와 **정확히 동일한 구성과 완벽하게 호환**되므로,  
**모든 Anthropic 호환 대형 언어 모델**과 함께 실행할 수 있습니다.

**✨ Claude Max 구독 불필요** - Zhipu GLM 4.7, MiniMax 2.1, Moonshot Kimi, DeepSeek 등  
모든 Anthropic 호환 API 모델을 지원합니다.

> 단순한 GUI가 아닙니다.  
> 진정한 AI 협업 파트너입니다.  
> Claude Agent SDK를 배울 필요 없이 — 작업을 생성하고 실행 경로만 선택하세요.


---

## ✨ 왜 Claude Cowork인가?

Claude Code는 강력하지만 — **터미널에서만 실행됩니다**.

즉:
- ❌ 복잡한 작업에 대한 시각적 피드백 없음
- ❌ 여러 세션 추적이 어려움
- ❌ 도구 출력 확인이 불편함

**Open Claude Cowork가 이러한 문제를 해결합니다:**

- 🖥️ **네이티브 데스크탑 애플리케이션으로 실행**
- 🤖 모든 작업에 대한 **AI 협업 파트너 역할 수행**
- 🔁 기존의 **`~/.claude/settings.json` 재사용**
- 🧠 Claude Code와 **100% 호환**

Claude Code가 당신의 기기에서 작동한다면 —  
**Open Claude Cowork도 작동합니다.**
---

## 🚀 빠른 시작

> **💡 팁:** 이 앱은 Claude Code 구성과 완벽하게 호환됩니다. Claude Max 구독이 필요 없으며, Zhipu GLM, MiniMax, Kimi, DeepSeek 또는 기타 Anthropic 호환 API 모델을 사용할 수 있습니다.

Open Claude Cowork를 사용하기 전에 Claude Code가 설치되어 있고 올바르게 구성되었는지 확인하세요.

### 옵션 1: 릴리스 다운로드

👉 [릴리스로 이동](https://github.com/caiqinghua/open-claude-cowork/releases)

---

### 옵션 2: 소스에서 빌드

#### 사전 요구 사항

- [Bun](https://bun.sh/) 또는 Node.js 22 이상
- [Claude Code](https://docs.anthropic.com/en/docs/claude-code) 설치 및 인증 완료


```bash
# Clone the repository
git clone https://github.com/caiqinghua/open-claude-cowork.git
cd open-claude-cowork

# Install dependencies
bun install

# Configure environment (copy .env.example to .env)
cp .env.example .env

# Run in development mode
bun run dev

# Or build production binaries
bun run dist:mac    # macOS
bun run dist:win    # Windows
bun run dist:linux  # Linux
```

---

## 🧠 핵심 기능

### 🤖 AI 협업 파트너 — 단순 GUI 그 이상

Open Claude Cowork는 다음과 같은 AI 파트너입니다:

* **코드 작성 및 편집** — 모든 프로그래밍 언어 지원
* **파일 관리** — 생성, 이동, 정리
* **PPT 작성** — 프레젠테이션 내용 및 구조 생성
* **주제 분석** — 연구 주제 및 방향에 대한 심층 분석
* **기사 작성** — 다양한 유형의 기사 및 문서 작성
* **무엇이든 수행** — 자연어로 설명할 수 있는 한

---

### 📂 세션 관리

* **사용자 지정 작업 디렉터리**로 세션 생성
* 이전 대화 재개 가능
* 완전한 로컬 세션 기록 (SQLite에 저장)
* 안전한 삭제 및 자동 저장

---

### 🎯 실시간 스트리밍 출력

* **토큰 단위 스트리밍 출력**
* Claude의 추론 과정 확인 가능
* 구문 하이라이트된 코드 포함 마크다운 렌더링
* 상태 표시기가 있는 시각화된 도구 호출

---

### 🔐 도구 권한 제어

* 민감한 작업에 대한 명시적 승인 필요
* 도구별 허용 또는 거부 가능
* 대화형 결정 패널  
* Claude가 수행할 수 있는 작업에 대한 완전한 제어  

---

## 🔁 Claude Code와 완벽 호환

Open Claude Cowork는 **Claude Code와 설정을 공유**합니다.

다음 항목을 직접 재사용합니다:

text  
~/.claude/settings.json  

이는 다음을 의미합니다:

* 동일한 API 키  
* 동일한 기본 URL  
* 동일한 모델  
* 동일한 동작  

**지원되는 모델은 다음과 같습니다:**  
- Zhipu GLM 4.7  
- MiniMax 2.1  
- Moonshot Kimi  
- DeepSeek  
- 기타 모든 Anthropic 호환 API 모델  

> Claude Code를 한 번 구성하세요 — 어디서나 사용하세요.

---

## 🔧 문제 해결

### better-sqlite3 모듈 오류

다음과 같은 오류가 발생하면:


```
Error: The module was compiled against a different Node.js version using
NODE_MODULE_VERSION 127. This version of Node.js requires NODE_MODULE_VERSION 140.
```
이것은 Electron이 자체 Node.js 버전을 번들로 제공하고 네이티브 모듈이 이에 맞게 다시 컴파일되어야 하기 때문입니다.

**해결책:**


```bash
# Install electron-rebuild as a dev dependency
npm install --save-dev electron-rebuild

# Rebuild better-sqlite3 for Electron
npx electron-rebuild -f -w better-sqlite3

# Run the app again
bun run dev
```
이것은 네이티브 모듈이 시스템의 Node.js 버전이 아닌 Electron의 Node.js 버전에 맞게 컴파일되도록 보장합니다.

---

## 🧩 아키텍처 개요

| 계층             | 기술                           |
| ---------------- | ------------------------------ |
| 프레임워크        | Electron 39                    |
| 프론트엔드       | React 19, Tailwind CSS 4       |
| 상태 관리        | Zustand                        |
| 데이터베이스      | better-sqlite3 (WAL 모드)      |
| AI               | @anthropic-ai/claude-agent-sdk |
| 빌드             | Vite, electron-builder         |

---

## 🛠 개발

bash
# 개발 서버 시작 (핫 리로드)
bun run dev

# 타입 검사 / 빌드
bun run build


---

## 🗺 로드맵

예정된 기능:

* 모델 및 API 키에 대한 GUI 기반 구성
* 🚧 곧 더 많은 기능 추가 예정

---

## 🤝 기여하기

풀 리퀘스트는 언제나 환영합니다.

1. 이 저장소를 포크하세요
2. 기능 브랜치를 만드세요
3. 변경사항을 커밋하세요
4. 풀 리퀘스트를 여세요

---

## ⭐ 마무리 말씀

만약 다음을 원하셨다면:

* 지속 가능한 데스크탑 AI 협업 파트너
* Claude 작동 방식에 대한 시각적 통찰
* 프로젝트 간 편리한 세션 관리

이 프로젝트가 바로 당신을 위해 만들어졌습니다.

👉 **도움이 되셨다면 별을 눌러주세요.**

---

## 라이선스

MIT






---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-02

---