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
    <img src="https://raw.githubusercontent.com/a2aproject/A2A/main/docs/assets/a2a_logo/color/SVG/a2a_color.svg" alt="Agent2Agent Protocol Logo" width="100">
    <h1>Agent2Agent (A2A) 프로토콜</h1>
  </div>
</div>

**불투명한 에이전트형 애플리케이션 간의 통신과 상호운용성을 가능하게 하는 오픈 프로토콜입니다.**

Agent2Agent (A2A) 프로토콜은 AI 분야에서 중요한 문제를 해결합니다. 즉, 다양한 프레임워크로 구축되어 서로 다른 회사의 별도 서버에서 실행되는 생성형 AI 에이전트들이 단순한 도구가 아닌 에이전트로서 효과적으로 소통하고 협업할 수 있도록 합니다. A2A는 에이전트들을 위한 공통 언어를 제공하여 더 상호 연결되고 강력하며 혁신적인 AI 생태계를 조성하는 것을 목표로 합니다.

A2A를 사용하면 에이전트는 다음과 같은 작업이 가능합니다:

- 서로의 기능을 발견합니다.
- 상호작용 방식(텍스트, 양식, 미디어 등)을 협상합니다.
- 장기 실행 작업을 안전하게 협업합니다.
- 내부 상태, 메모리 또는 도구를 노출하지 않고 동작합니다.

## DeepLearning.AI 과정

[![A2A DeepLearning.AI](https://img.youtube.com/vi/4gYm0Rp7VHc/maxresdefault.jpg)](https://goo.gle/dlai-a2a)

[Holt Skinner](https://github.com/holtskinner), [Ivan Nardini](https://github.com/inardini), [Sandi Besen](https://github.com/sandijean90) 이 가르치는 Google Cloud 및 IBM Research와의 파트너십으로 제작된 [A2A: The Agent2Agent Protocol](https://goo.gle/dlai-a2a) 단기 과정에 참여하세요.

**배우게 될 내용:**

- **에이전트를 A2A 호환으로 만들기:** Google ADK, LangGraph, BeeAI 등으로 구축된 에이전트를 A2A 서버로 노출합니다.
- **에이전트 연결하기:** 직접 또는 통합을 통해 A2A 클라이언트를 만들어 A2A 호환 에이전트에 연결합니다.
- **워크플로 오케스트레이션:** A2A 호환 에이전트의 순차적, 계층적 워크플로를 구축합니다.
- **멀티 에이전트 시스템:** 다양한 프레임워크를 활용해 의료 분야 멀티 에이전트 시스템을 구축하고, A2A가 협업을 어떻게 지원하는지 확인합니다.
- **A2A와 MCP:** A2A가 MCP와 어떻게 보완적으로 작동하며 에이전트 간 협업을 가능하게 하는지 학습합니다.

## 왜 A2A인가?

AI 에이전트가 점점 더 보편화됨에 따라, 그들의 상호운용성은 복잡하고 다기능적인 애플리케이션을 구축하는 데 필수적입니다. A2A는 다음을 목표로 합니다:

- **사일로 허물기:** 다양한 생태계의 에이전트를 연결합니다.
- **복잡한 협업 가능:** 단일 에이전트가 처리할 수 없는 작업을 전문화된 에이전트들이 함께 수행하도록 합니다.
- **오픈 스탠더드 촉진:** 에이전트 간 통신에 대한 커뮤니티 주도의 접근 방식을 장려하여 혁신과 광범위한 채택을 도모합니다.
- **불투명성 보장:** 내부 메모리, 독점적 로직, 특정 도구 구현을 공유하지 않고도 에이전트 협업이 가능하도록 하여 보안과 지식재산 보호를 강화합니다.

### 주요 기능

- **표준화된 통신:** HTTP(S) 기반 JSON-RPC 2.0 지원.
- **에이전트 탐색:** 기능 및 연결 정보를 포함한 "에이전트 카드" 제공.
- **유연한 상호작용:** 동기 요청/응답, 스트리밍(SSE), 비동기 푸시 알림 지원.
- **풍부한 데이터 교환:** 텍스트, 파일, 구조화된 JSON 데이터 처리.
- **엔터프라이즈 준비:** 보안, 인증, 관찰성을 고려한 설계.

## 시작하기

- 📚 **문서 살펴보기:** [Agent2Agent 프로토콜 문서 사이트](https://a2a-protocol.org)에서 전체 개요, 프로토콜 명세, 튜토리얼, 가이드를 확인하세요.
- 📝 **명세 보기:** [A2A 프로토콜 명세](https://a2a-protocol.org/latest/specification/)
- SDK 사용하기:
    - [🐍 A2A Python SDK](https://github.com/a2aproject/a2a-python) `pip install a2a-sdk`
    - [🐿️ A2A Go SDK](https://github.com/a2aproject/a2a-go) `go get github.com/a2aproject/a2a-go`
    - [🧑‍💻 A2A JS SDK](https://github.com/a2aproject/a2a-js) `npm install @a2a-js/sdk`
    - [☕️ A2A Java SDK](https://github.com/a2aproject/a2a-java) maven 사용
    - [🔷 A2A .NET SDK](https://github.com/a2aproject/a2a-dotnet) [NuGet](https://www.nuget.org/packages/A2A) 사용 `dotnet add package A2A`
    - [🦀 A2A Rust SDK](https://github.com/a2aproject/a2a-rs) `cargo add a2a-lf`
- 🎬 [샘플](https://github.com/a2aproject/a2a-samples)을 활용하여 A2A의 실제 동작 확인

## 기여하기

A2A 프로토콜의 향상과 발전을 위한 커뮤니티 기여를 환영합니다!

- **질문 & 토론:** [GitHub Discussions](https://github.com/a2aproject/A2A/discussions)에 참여하세요.
- **이슈 & 피드백:** [GitHub Issues](https://github.com/a2aproject/A2A/issues)에서 문제 보고 또는 개선 사항 제안.
- **기여 가이드:** [CONTRIBUTING.md](https://raw.githubusercontent.com/a2aproject/A2A/main/CONTRIBUTING.md)에서 기여 방법 확인.
- **비공개 피드백:** [Google Form](https://goo.gle/a2a-feedback) 이용.
- **파트너 프로그램:** Google Cloud 고객은 [이 양식](https://goo.gle/a2a-partner)을 통해 파트너 프로그램 가입 가능.

## 다음 단계

### 프로토콜 개선 사항

- **에이전트 탐색:**
    - 인증 체계 및 선택적 자격 정보를 `AgentCard`에 직접 포함하는 방안을 공식화합니다.
- **에이전트 협업:**
    - 미지원 또는 예상치 못한 스킬을 동적으로 확인할 수 있는 `QuerySkill()` 메서드 도입을 검토합니다.
- **작업 수명 주기 및 UX:**
    - 작업 _내부_에서의 동적 UX 협상 지원(예: 에이전트가 대화 도중 오디오/비디오 추가).
- **클라이언트 메서드 및 전송:**
    - 클라이언트가 시작하는 메서드 지원 확장 검토(작업 관리 외).
    - 스트리밍 신뢰성 및 푸시 알림 메커니즘 개선.

## 소개

A2A 프로토콜은 Google이 기여하고 Linux Foundation 산하에 있는 오픈 소스 프로젝트입니다. [Apache License 2.0](LICENSE)에 따라 라이선스가 부여되며 커뮤니티의 기여를 환영합니다.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-23

---