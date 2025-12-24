# Agent2Agent (A2A) 프로토콜

[![PyPI - 버전](https://img.shields.io/pypi/v/a2a-sdk)](https://pypi.org/project/a2a-sdk)
[![아파치 라이선스](https://img.shields.io/badge/License-Apache_2.0-blue.svg)](LICENSE)
<a href="https://codewiki.google/github.com/a2aproject/a2a">
  <img src="https://www.gstatic.com/_/boq-sdlc-agents-ui/_/r/Mvosg4klCA4.svg" alt="Ask Code Wiki" height="20">
</a>

<!-- markdownlint-disable MD041 -->
<div style="text-align: center;">
  <div class="centered-logo-text-group">
    <img src="https://raw.githubusercontent.com/a2aproject/A2A/main/docs/assets/a2a-logo-black.svg" alt="Agent2Agent Protocol Logo" width="100">
    <h1>Agent2Agent (A2A) 프로토콜</h1>
  </div>
</div>

**불투명한 에이전트 애플리케이션 간의 통신 및 상호 운용성을 가능하게 하는 오픈 프로토콜입니다.**

Agent2Agent (A2A) 프로토콜은 AI 환경에서 중요한 문제를 해결합니다: 서로 다른 회사가 다양한 프레임워크로 구축하고 별도의 서버에서 실행하는 생성 AI 에이전트들이 단순 도구가 아닌 에이전트로서 효과적으로 통신하고 협업할 수 있도록 하는 것입니다. A2A는 에이전트 간 공통 언어를 제공하여 보다 상호 연결되고 강력하며 혁신적인 AI 생태계를 조성하는 것을 목표로 합니다.

A2A를 통해 에이전트는:

- 서로의 기능을 발견할 수 있습니다.
- 상호작용 방식(텍스트, 양식, 미디어)을 협상할 수 있습니다.
- 장기 과제에 대해 안전하게 협력할 수 있습니다.
- 내부 상태, 메모리 또는 도구를 노출하지 않고 작동할 수 있습니다.

## A2A 소개 동영상

[![A2A 소개 동영상](https://img.youtube.com/vi/Fbr_Solax1w/hqdefault.jpg)](https://goo.gle/a2a-video)

## 왜 A2A인가?

AI 에이전트가 점점 보편화됨에 따라, 이들의 상호 운용성은 복잡하고 다기능적인 애플리케이션 구축에 필수적입니다. A2A는 다음을 목표로 합니다:

- **장벽 허물기:** 서로 다른 생태계의 에이전트를 연결합니다.
- **복잡한 협업 가능:** 단일 에이전트가 처리할 수 없는 작업에 대해 전문화된 에이전트들이 함께 작업할 수 있도록 합니다.
- **오픈 표준 촉진:** 에이전트 통신에 대한 커뮤니티 주도 방식을 장려하여 혁신과 광범위한 채택을 유도합니다.
- **불투명성 유지:** 내부 메모리, 독점 로직 또는 특정 도구 구현을 공유하지 않고도 에이전트가 협력할 수 있게 하여 보안을 강화하고 지적 재산을 보호합니다.

### 주요 특징

- **표준화된 통신:** HTTP(S)를 통한 JSON-RPC 2.0.
- **에이전트 검색:** 기능 및 연결 정보를 상세히 담은 "에이전트 카드"를 통해.
- **유연한 상호작용:** 동기 요청/응답, 스트리밍(SSE), 비동기 푸시 알림 지원.
- **풍부한 데이터 교환:** 텍스트, 파일, 구조화된 JSON 데이터 처리.
- **기업용 설계:** 보안, 인증, 관찰성(오브저버빌리티)을 고려하여 설계됨.

## 시작하기

- 📚 **문서 탐색:** 전체 개요, 프로토콜 사양, 튜토리얼 및 가이드를 보려면 [Agent2Agent 프로토콜 문서 사이트](https://a2a-protocol.org)를 방문하세요.
- 📝 **사양 보기:** [A2A 프로토콜 사양](https://a2a-protocol.org/latest/specification/)
- SDK 사용:
    - [🐍 A2A Python SDK](https://github.com/a2aproject/a2a-python) `pip install a2a-sdk`
    - [🐿️ A2A Go SDK](https://github.com/a2aproject/a2a-go) `go get github.com/a2aproject/a2a-go`
    - [🧑‍💻 A2A JS SDK](https://github.com/a2aproject/a2a-js) `npm install @a2a-js/sdk`
    - [☕️ A2A Java SDK](https://github.com/a2aproject/a2a-java) maven 사용
    - [🔷 A2A .NET SDK](https://github.com/a2aproject/a2a-dotnet) [NuGet](https://www.nuget.org/packages/A2A) 사용 `dotnet add package A2A`
- 🎬 [샘플](https://github.com/a2aproject/a2a-samples)을 사용하여 A2A 작동 예시 확인

## 기여하기

A2A 프로토콜을 향상 및 발전시키기 위한 커뮤니티 기여를 환영합니다!

- **질문 및 토론:** [GitHub Discussions](https://github.com/a2aproject/A2A/discussions) 참여.
- **이슈 및 피드백:** [GitHub Issues](https://github.com/a2aproject/A2A/issues)를 통해 문제 제기 또는 개선 제안.
- **기여 가이드:** 기여 방법은 [CONTRIBUTING.md](https://raw.githubusercontent.com/a2aproject/A2A/main/CONTRIBUTING.md) 참조.
- **비공개 피드백:** 이 [Google 폼](https://goo.gle/a2a-feedback) 사용.
- **파트너 프로그램:** Google Cloud 고객은 이 [폼](https://goo.gle/a2a-partner)을 통해 파트너 프로그램 참여 가능.

## 앞으로의 계획

### 프로토콜 향상

- **에이전트 검색:**
    - `AgentCard` 내 권한 부여 방식과 선택적 자격 증명 포함을 공식화.
- **에이전트 협력:**
    - 지원하지 않거나 예상치 못한 스킬을 동적으로 확인할 수 있는 `QuerySkill()` 메서드 조사.
- **작업 생명주기 및 UX:**
    - 작업 중 동적 UX 협상 지원 (예: 대화 중 에이전트가 오디오/비디오 추가).
- **클라이언트 메서드 및 전송:**
    - 클라이언트 주도 메서드(작업 관리 외) 지원 확장 탐색.
    - 스트리밍 신뢰성 및 푸시 알림 메커니즘 개선.

## 소개

A2A 프로토콜은 구글이 기여한 리눅스 재단 산하의 오픈 소스 프로젝트입니다. [아파치 라이선스 2.0](LICENSE) 하에 라이선스가 부여되었으며, 커뮤니티의 기여를 환영합니다.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-24

---