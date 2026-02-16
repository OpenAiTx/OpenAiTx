# Agent2Agent (A2A) 프로토콜

[![PyPI - Version](https://img.shields.io/pypi/v/a2a-sdk)](https://pypi.org/project/a2a-sdk)
[![Apache License](https://img.shields.io/badge/License-Apache_2.0-blue.svg)](LICENSE)
<a href="https://codewiki.google/github.com/a2aproject/a2a">
  <img src="https://www.gstatic.com/_/boq-sdlc-agents-ui/_/r/Mvosg4klCA4.svg" alt="Ask Code Wiki" height="20">
</a>

<div style="text-align: left;">
  <details>
    <summary>🌐 언어</summary>
    <div>
      <div style="text-align: center;">
        <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=as">অসমীয়া</a>
      </div>
    </div>
  </details>
</div>

<!-- markdownlint-disable MD041 -->
<div style="text-align: center;">
  <div class="centered-logo-text-group">
    <img src="https://raw.githubusercontent.com/a2aproject/A2A/main/docs/assets/a2a-logo-black.svg" alt="Agent2Agent Protocol Logo" width="100">
    <h1>Agent2Agent (A2A) 프로토콜</h1>
  </div>
</div>

**불투명한 에이전트형 애플리케이션 간 통신 및 상호운용성을 가능하게 하는 오픈 프로토콜입니다.**

Agent2Agent (A2A) 프로토콜은 AI 분야에서 중요한 과제를 다룹니다: 다양한 프레임워크로 구축되고 서로 다른 회사의 별도 서버에서 실행되는 생성형 AI 에이전트들이, 단순한 도구가 아닌 에이전트로서 효과적으로 소통하고 협업할 수 있도록 하는 것입니다. A2A는 에이전트들을 위한 공통 언어를 제공하여, 더욱 상호연결되고 강력하며 혁신적인 AI 생태계를 조성하는 것을 목표로 합니다.

A2A를 통해 에이전트들은 다음과 같은 일을 할 수 있습니다:

- 서로의 기능을 발견합니다.
- 상호작용 방식(텍스트, 폼, 미디어 등)을 협상합니다.
- 장기 실행되는 작업을 안전하게 협업합니다.
- 자신의 내부 상태, 메모리, 도구를 노출하지 않고 동작합니다.

## DeepLearning.AI 강좌

[![A2A DeepLearning.AI](https://img.youtube.com/vi/4gYm0Rp7VHc/maxresdefault.jpg)](https://goo.gle/dlai-a2a)

[구글 클라우드](https://goo.gle/dlai-a2a)와 IBM 리서치와의 협업으로 제작된 [A2A: Agent2Agent 프로토콜](https://goo.gle/dlai-a2a) 단기 강좌에 참여해보세요. [Holt Skinner](https://github.com/holtskinner), [Ivan Nardini](https://github.com/inardini), [Sandi Besen](https://github.com/sandijean90)가 강의합니다.

**배울 내용:**

- **에이전트를 A2A 준수로 만들기:** Google ADK, LangGraph, BeeAI와 같은 프레임워크로 만든 에이전트를 A2A 서버로 노출하는 방법
- **에이전트 연결:** A2A 클라이언트를 처음부터 만들거나 통합을 이용해 A2A 준수 에이전트에 연결
- **워크플로 오케스트레이션:** A2A 준수 에이전트의 순차적, 계층적 워크플로 구축
- **멀티 에이전트 시스템:** 다양한 프레임워크로 헬스케어 멀티 에이전트 시스템을 구축하고 A2A로 협업하는 방법 확인
- **A2A와 MCP:** 에이전트 간 협업을 가능하게 하여 A2A가 MCP를 어떻게 보완하는지 학습

## 왜 A2A인가?

AI 에이전트의 활용도가 높아질수록, 이들의 상호운용성은 복합적이고 다기능적인 애플리케이션 구축에 필수적입니다. A2A는 다음을 목표로 합니다:

- **사일로 허물기:** 다양한 생태계의 에이전트 연결
- **복잡한 협업 지원:** 단일 에이전트로는 처리할 수 없는 작업을 특화된 에이전트들이 함께 수행하도록 지원
- **오픈 표준 촉진:** 에이전트 통신의 커뮤니티 중심 접근을 조성해 혁신과 폭넓은 채택 장려
- **불투명성 유지:** 에이전트가 내부 메모리, 독점 논리, 특정 도구 구현을 공유하지 않고 협업할 수 있게 하여 보안을 강화하고 지식재산을 보호

### 주요 기능

- **표준화된 통신:** HTTP(S) 기반의 JSON-RPC 2.0 지원.
- **에이전트 탐색:** 기능 및 연결 정보를 담은 "에이전트 카드"를 통한 탐색.
- **유연한 상호작용:** 동기 요청/응답, 스트리밍(SSE), 비동기 푸시 알림 지원.
- **풍부한 데이터 교환:** 텍스트, 파일, 구조화된 JSON 데이터 처리 가능.
- **기업 환경 적합:** 보안, 인증, 관측성을 고려한 설계.

## 시작하기

- 📚 **문서 탐색:** [Agent2Agent 프로토콜 문서 사이트](https://a2a-protocol.org)에서 전체 개요, 전체 프로토콜 명세, 튜토리얼, 가이드를 확인하세요.
- 📝 **명세 보기:** [A2A 프로토콜 명세](https://a2a-protocol.org/latest/specification/)
- SDK 사용:
    - [🐍 A2A Python SDK](https://github.com/a2aproject/a2a-python) `pip install a2a-sdk`
    - [🐿️ A2A Go SDK](https://github.com/a2aproject/a2a-go) `go get github.com/a2aproject/a2a-go`
    - [🧑‍💻 A2A JS SDK](https://github.com/a2aproject/a2a-js) `npm install @a2a-js/sdk`
    - [☕️ A2A Java SDK](https://github.com/a2aproject/a2a-java) maven 사용
    - [🔷 A2A .NET SDK](https://github.com/a2aproject/a2a-dotnet) [NuGet](https://www.nuget.org/packages/A2A) 활용 `dotnet add package A2A`
- 🎬 [샘플](https://github.com/a2aproject/a2a-samples)을 통해 A2A의 실제 동작을 확인하세요

## 기여하기

A2A 프로토콜의 발전을 위해 커뮤니티의 다양한 기여를 환영합니다!

- **질문 & 토론:** [GitHub Discussions](https://github.com/a2aproject/A2A/discussions)에 참여하세요.
- **이슈 & 피드백:** [GitHub Issues](https://github.com/a2aproject/A2A/issues)를 통해 문제를 보고하거나 개선점을 제안하세요.
- **기여 안내:** [CONTRIBUTING.md](https://raw.githubusercontent.com/a2aproject/A2A/main/CONTRIBUTING.md)에서 기여 방법을 확인하세요.
- **비공개 피드백:** [Google Form](https://goo.gle/a2a-feedback)을 이용하세요.
- **파트너 프로그램:** Google Cloud 고객은 [이 양식](https://goo.gle/a2a-partner)을 통해 파트너 프로그램에 참여할 수 있습니다.

## 다음 단계

### 프로토콜 개선 사항

- **에이전트 탐색:**
    - 인증 방식 및 선택적 자격 증명을 `AgentCard` 내에 직접 포함하는 방안 공식화.
- **에이전트 협업:**
    - 미지원 또는 예측 불가 기능을 동적으로 확인하는 `QuerySkill()` 메서드 도입 검토.
- **작업 생명주기 및 UX:**
    - 작업 내에서 동적 UX 협상 지원(예: 에이전트가 대화 중에 오디오/비디오 추가).
- **클라이언트 메서드 및 전송:**
    - 클라이언트가 시작하는 메서드 지원 확장 탐색(작업 관리 외에도).
    - 스트리밍 신뢰성 및 푸시 알림 메커니즘 개선.

## 소개

A2A 프로토콜은 Google이 기여한 Linux Foundation 산하 오픈 소스 프로젝트입니다. [Apache License 2.0](LICENSE) 하에 라이선스가 부여되며 커뮤니티의 기여를 환영합니다.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-16

---