# Agent2Agent (A2A) 샘플

<a href="https://studio.firebase.google.com/new?template=https%3A%2F%2Fgithub.com%2Fa2aproject%2Fa2a-samples%2Ftree%2Fmain%2F.firebase-studio">
  <picture>
    <source
      media="(prefers-color-scheme: dark)"
      srcset="https://cdn.firebasestudio.dev/btn/try_light_20.svg">
    <source
      media="(prefers-color-scheme: light)"
      srcset="https://cdn.firebasestudio.dev/btn/try_dark_20.svg">
    <img
      height="20"
      alt="Firebase Studio에서 체험하기"
      src="https://cdn.firebasestudio.dev/btn/try_blue_20.svg">
  </picture>
</a>

<div style="text-align: right;">
  <details>
    <summary>🌐 언어</summary>
    <div style="text-align: center;">
      <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=en">English</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=zh-CN">简体中文</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=zh-TW">繁體中文</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ja">日本語</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ko">한국어</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=hi">हिन्दी</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=th">ไทย</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=fr">Français</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=de">Deutsch</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=es">Español</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=it">Italiano</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ru">Русский</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=pt">Português</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=nl">Nederlands</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=pl">Polski</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ar">العربية</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=fa">فارسی</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=tr">Türkçe</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=vi">Tiếng Việt</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ko">한국어</a>
    </div>
  </details>
</div>

[Agent2Agent (A2A) 프로토콜](https://goo.gle/a2a)의 공식 코드 샘플과 데모에 오신 것을 환영합니다.

여러분을 만나게 되어 매우 기쁩니다! 멀티 에이전트 아키텍처를 처음 탐험하시는 분이든, 고급 상호운용 에이전트 네트워크를 구축하시는 분이든, 이 저장소는 개발을 가속화할 수 있는 간단하고 영감을 주는 학습 자료를 제공합니다.

## 왜 Agent2Agent인가요?

다양한 AI 프레임워크와 생태계가 존재하는 세상에서, 에이전트는 안전하게 소통·협력하고 업무를 위임하기 위한 공통 언어가 필요합니다. A2A 프로토콜은 멀티 에이전트 상호운용성을 위한 표준화되고 오픈된 규격을 제시합니다.

저희 샘플은 다양한 언어와 호스트 애플리케이션에서 복잡한 멀티 에이전트 문제를 쉽게 해결할 수 있음을 보여줍니다.

## 빠른 시작

Helloworld 에이전트를 실행하고 Python CLI 호스트를 통해 바로 통신해보세요.

1. **에이전트 서버 시작**:
   터미널을 열고 Helloworld 에이전트 서버를 시작하세요:

   ```bash
   cd samples/python/agents/helloworld
   uv run .
   ```

2. **호스트 클라이언트 실행**:
   두 번째 터미널을 열고 CLI 클라이언트를 실행하여 에이전트에 작업을 전송하세요:

   ```bash
   cd samples/python/agents/helloworld
   uv run test_client.py
   ```

## 리포지토리 구조

리포지토리는 언어별로 여러 주요 디렉토리로 구성되어 있습니다:

| 디렉토리 | 설명 |
| --- | --- |
| [samples](/samples) | 프로그래밍 언어별로 구성된 핵심 A2A 샘플. |
| [samples/python](/samples/python) | A2A Python SDK를 사용한 Python 에이전트 구현 예시. |
| [samples/go](/samples/go) | A2A Go SDK를 사용한 Go 에이전트 구현 예시. |
| [samples/dotnet](/samples/dotnet) | A2A .NET SDK를 사용한 C# 에이전트 구현 예시. |
| [samples/java](/samples/java) | A2A Java SDK를 사용한 Java 에이전트 구현 예시. |
| [samples/js](/samples/js) | A2A JavaScript SDK를 사용한 Node.js 에이전트 구현 예시. |

## 기여하기

모든 수준의 기여를 환영하며 적극적으로 권장합니다! 새로운 샘플 아이디어, 버그 수정, 문서 개선이 있다면 [기여 가이드](https://raw.githubusercontent.com/a2aproject/a2a-samples/main/CONTRIBUTING.md)를 확인해주세요.

## 도움 받기

저희는 환영하며 지원하는 커뮤니티를 제공하기 위해 노력하고 있습니다. 질문, 피드백, 문제 발생 시 [이슈 페이지](https://github.com/a2aproject/a2a-samples/issues)로 연락해 주세요.

## 관련 리포지토리

| 리포지토리 | 카테고리 | 설명 |
| --- | --- | --- |
| [A2A](https://github.com/a2aproject/A2A) | 핵심 명세 | A2A 명세 및 문서. |
| [a2a-inspector](https://github.com/a2aproject/a2a-inspector) | 도구 | A2A 지원 에이전트 점검을 위한 UI 도구. |
| [a2a-tck](https://github.com/a2aproject/a2a-tck) | 테스트 | A2A 프로토콜 준수 검증용 테스트 스위트. |
| [a2a-itk](https://github.com/a2aproject/a2a-itk) | 테스트 | 다양한 A2A SDK 구현 및 버전 간 호환성을 다중 홉 트래버설 모델과 다양한 전송 프로토콜로 검증하는 툴킷. |
| [a2a-python](https://github.com/a2aproject/a2a-python) | SDK (Python) | 공식 A2A Python SDK. |
| [a2a-go](https://github.com/a2aproject/a2a-go) | SDK (Go) | 공식 A2A Go SDK. |
| [a2a-java](https://github.com/a2aproject/a2a-java) | SDK (Java) | 공식 A2A Java SDK. |
| [a2a-js](https://github.com/a2aproject/a2a-js) | SDK (JavaScript) | 공식 A2A Node.js/JavaScript SDK. |
| [a2a-dotnet](https://github.com/a2aproject/a2a-dotnet) | SDK (C#/.NET) | 공식 A2A C#/.NET SDK. |
| [a2a-rs](https://github.com/a2aproject/a2a-rs) | SDK (Rust) | 공식 A2A Rust SDK. |

## 면책 조항

**중요:** 제공된 샘플 코드는 시연 목적이며 동작 원리를 보여줍니다.
에이전트-투-에이전트(A2A) 프로토콜. 프로덕션 애플리케이션을 구축할 때, 직접 제어하지 않는 모든 에이전트를 잠재적으로 신뢰할 수 없는 엔티티로 취급하는 것이 중요합니다.

외부 에이전트로부터 받은 모든 데이터—AgentCard, 메시지, 아티팩트, 작업 상태 등을 포함하되 이에 국한되지 않음—는 신뢰할 수 없는 입력으로 처리해야 합니다. 예를 들어, 악의적인 에이전트가 각 필드(예: 설명, 이름, skills.description)에 조작된 데이터가 포함된 AgentCard를 제공할 수 있습니다. 이 데이터가 정제 없이 대형 언어 모델(LLM)을 위한 프롬프트를 구성하는 데 사용된다면, 프롬프트 인젝션 공격에 노출될 수 있습니다. 이 데이터를 사용하기 전에 적절히 검증하고 정제하지 않으면 애플리케이션에 보안 취약점이 발생할 수 있습니다.

> 개발자는 입력 검증, 자격 증명의 안전한 처리 등 시스템과 사용자를 보호하기 위한 적절한 보안 조치를 구현할 책임이 있습니다.










---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-21

---