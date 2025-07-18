# Agent2Agent (A2A) 샘플

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
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=id">Bahasa Indonesia</a>
    </div>
  </details>
</div>

이 저장소에는 [Agent2Agent (A2A) 프로토콜](https://goo.gle/a2a)을 사용하는 코드 샘플과 데모가 포함되어 있습니다.

## 관련 저장소

- [A2A](https://github.com/a2aproject/A2A) - A2A 명세 및 문서.
- [a2a-python](https://github.com/a2aproject/a2a-python) - A2A Python SDK.
- [a2a-inspector](https://github.com/a2aproject/a2a-inspector) - A2A 지원 에이전트 점검을 위한 UI 도구.

## 기여하기

기여를 환영합니다! [기여 가이드](https://raw.githubusercontent.com/a2aproject/a2a-samples/main/CONTRIBUTING.md)를 참고하세요.

## 도움 받기

제안, 피드백 또는 버그 신고는 [이슈 페이지](https://github.com/a2aproject/a2a-samples/issues)를 이용해 주세요.

## 면책 조항

이 저장소 자체는 공식적으로 지원되는 Google 제품이 아닙니다. 이 저장소의 코드는 데모 용도로만 제공됩니다.

중요: 제공된 샘플 코드는 데모 목적으로, Agent-to-Agent(A2A) 프로토콜의 메커니즘을 설명합니다. 실제 운영 환경에서 애플리케이션을 구축할 때, 직접 제어하지 않는 모든 에이전트는 잠재적으로 신뢰할 수 없는 엔터티로 취급하는 것이 중요합니다.

외부 에이전트로부터 수신된 모든 데이터(AgentCard, 메시지, 산출물, 작업 상태 등을 포함하되 이에 국한되지 않음)는 신뢰할 수 없는 입력으로 처리해야 합니다. 예를 들어, 악의적인 에이전트가 필드(예: 설명, 이름, skills.description)에 조작된 데이터를 담은 AgentCard를 제공할 수 있습니다. 만약 이 데이터가 정제 없이 대형 언어 모델(LLM) 프롬프트 구성에 사용된다면, 프롬프트 인젝션 공격에 노출될 수 있습니다. 해당 데이터를 적절히 검증 및 정제하지 않고 사용할 경우 애플리케이션에 보안 취약점이 발생할 수 있습니다.

개발자는 시스템과 사용자를 보호하기 위해 입력 검증 및 자격 증명 안전 처리 등 적절한 보안 조치를 구현할 책임이 있습니다.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---