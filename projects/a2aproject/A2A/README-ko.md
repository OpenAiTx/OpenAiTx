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

**불투명한 에이전틱 애플리케이션 간의 통신 및 상호운용성을 가능하게 하는 오픈 프로토콜입니다.**

Agent2Agent(A2A) 프로토콜은 AI 생태계의 중요한 과제, 즉 서로 다른 기업이 다양한 프레임워크로 별도의 서버에서 실행하는 생성형 AI 에이전트가 에이전트로서 효과적으로 소통하고 협업할 수 있도록 하는 문제를 해결합니다. A2A는 에이전트 간의 공통 언어를 제공하여 더욱 상호 연결되고 강력하며 혁신적인 AI 생태계를 조성하는 것을 목표로 합니다.

A2A를 통해 에이전트는 다음을 수행할 수 있습니다:

- 서로의 역량을 발견합니다.
- 상호작용 방식(텍스트, 폼, 미디어)을 협상합니다.
- 장기 작업에서 안전하게 협업합니다.
- 내부 상태, 메모리 또는 도구를 노출하지 않고 운영합니다.

## A2A 소개 영상

[![A2A 소개 영상](https://img.youtube.com/vi/Fbr_Solax1w/hqdefault.jpg)](https://goo.gle/a2a-video)

## 왜 A2A인가?

AI 에이전트가 보편화됨에 따라, 이들의 상호운용성은 복잡하고 다기능적인 애플리케이션 구축에 필수적입니다. A2A는 다음을 목표로 합니다:

- **사일로 허물기:** 다양한 생태계의 에이전트 연결.
- **복잡한 협업 지원:** 단일 에이전트가 처리할 수 없는 작업을 전문화된 에이전트들이 함께 처리할 수 있도록 합니다.
- **오픈 스탠더드 촉진:** 에이전트 통신에 대한 커뮤니티 주도 방식을 통해 혁신과 광범위한 도입을 장려합니다.
- **불투명성 유지:** 내부 메모리, 독점 로직, 특정 도구 구현을 공유하지 않고 에이전트가 협업할 수 있도록 하여 보안성과 지적 재산 보호를 강화합니다.

### 주요 특징

- **표준화된 통신:** HTTP(S) 기반 JSON-RPC 2.0 지원.
- **에이전트 발견:** 역량과 연결 정보를 담은 "에이전트 카드" 제공.
- **유연한 상호작용:** 동기식 요청/응답, 스트리밍(SSE), 비동기 푸시 알림 지원.
- **풍부한 데이터 교환:** 텍스트, 파일, 구조화된 JSON 데이터 처리.
- **엔터프라이즈 준비:** 보안, 인증, 가시성을 고려해 설계됨.

## 시작하기

- 📚 **문서 살펴보기:** [Agent2Agent 프로토콜 문서 사이트](https://a2a-protocol.org)에서 전체 개요, 프로토콜 명세, 튜토리얼 및 가이드를 확인하세요.
- 📝 **명세 보기:** [A2A 프로토콜 명세](https://a2a-protocol.org/latest/specification/)
- SDK 사용:
    - [🐍 A2A Python SDK](https://github.com/a2aproject/a2a-python) `pip install a2a-sdk`
    - [🐿️ A2A Go SDK](https://github.com/a2aproject/a2a-go) `go get github.com/a2aproject/a2a-go`
    - [🧑‍💻 A2A JS SDK](https://github.com/a2aproject/a2a-js) `npm install @a2a-js/sdk`
    - [☕️ A2A Java SDK](https://github.com/a2aproject/a2a-java) maven 사용
    - [🔷 A2A .NET SDK](https://github.com/a2aproject/a2a-dotnet) [NuGet](https://www.nuget.org/packages/A2A) 사용 `dotnet add package A2A`
- 🎬 [샘플](https://github.com/a2aproject/a2a-samples)을 이용해 A2A의 실제 동작을 확인하세요

## 기여하기

A2A 프로토콜을 발전시키고 개선하기 위해 커뮤니티의 기여를 환영합니다!

- **질문 & 토론:** [GitHub Discussions](https://github.com/a2aproject/A2A/discussions)에 참여하세요.
- **이슈 & 피드백:** [GitHub Issues](https://github.com/a2aproject/A2A/issues)를 통해 이슈 제기 또는 개선 제안을 하세요.
- **기여 가이드:** [CONTRIBUTING.md](https://raw.githubusercontent.com/a2aproject/A2A/main/CONTRIBUTING.md)에서 기여 방법을 자세히 확인하세요.
- **비공개 피드백:** [Google Form](https://goo.gle/a2a-feedback)을 이용하세요.
- **파트너 프로그램:** Google Cloud 고객은 이 [폼](https://goo.gle/a2a-partner)을 통해 파트너 프로그램에 참여할 수 있습니다.

## 다음 단계

### 프로토콜 개선

- **에이전트 탐색:**
    - `AgentCard` 내에 인증 방식 및 선택적 자격 증명 포함을 공식화합니다.
- **에이전트 협업:**
    - 지원하지 않거나 예상치 못한 기능을 동적으로 확인할 수 있는 `QuerySkill()` 메서드 도입을 검토합니다.
- **작업 라이프사이클 & UX:**
    - 작업 내에서 동적 UX 협상을 지원합니다(예: 대화 중 오디오/비디오 추가 등).
- **클라이언트 메서드 & 전송:**
    - (작업 관리 외) 클라이언트가 시작하는 메서드 지원 확장 검토.
    - 스트리밍 신뢰성 및 푸시 알림 메커니즘 개선.

## 소개

A2A 프로토콜은 리눅스 재단 산하 오픈 소스 프로젝트로, Google이 기여하였으며 [Apache License 2.0](LICENSE) 하에 라이선스되어 커뮤니티의 기여를 환영합니다.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-30

---