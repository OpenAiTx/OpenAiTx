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

이 저장소에는 [Agent2Agent (A2A) 프로토콜](https://goo.gle/a2a)을 사용하는 코드 샘플과 데모가 포함되어 있습니다.

## 관련 저장소

- [A2A](https://github.com/a2aproject/A2A) - A2A 명세 및 문서.
- [a2a-python](https://github.com/a2aproject/a2a-python) - A2A Python SDK.
- [a2a-inspector](https://github.com/a2aproject/a2a-inspector) - A2A 에이전트 검사용 UI 도구.

## 기여하기

기여를 환영합니다! [기여 가이드](https://raw.githubusercontent.com/a2aproject/a2a-samples/main/CONTRIBUTING.md)를 참고하세요.

## 도움 받기

제안, 피드백 또는 버그 신고는 [이슈 페이지](https://github.com/a2aproject/a2a-samples/issues)를 이용해 주세요.

## 면책 조항

이 저장소 자체는 공식적으로 지원되는 Google 제품이 아닙니다. 이 저장소의 코드는 데모 목적입니다.

중요: 제공되는 샘플 코드는 데모용이며 Agent-to-Agent(A2A) 프로토콜의 동작을 설명합니다. 실제 애플리케이션을 개발할 때, 직접 제어하지 않는 모든 에이전트는 잠재적으로 신뢰할 수 없는 엔티티로 간주해야 합니다.

외부 에이전트로부터 받은 모든 데이터—AgentCard, 메시지, 산출물, 작업 상태 등—는 신뢰할 수 없는 입력으로 처리해야 합니다. 예를 들어, 악의적인 에이전트가 필드(예: 설명, 이름, skills.description)에 조작된 데이터가 포함된 AgentCard를 제공할 수 있습니다. 이 데이터를 정제하지 않고 대형 언어 모델(LLM) 프롬프트 구성에 사용하면 프롬프트 인젝션 공격에 노출될 수 있습니다. 데이터를 사용 전에 적절히 검증 및 정제하지 않으면 애플리케이션에 보안 취약점이 발생할 수 있습니다.

개발자는 입력 검증 및 자격 증명 안전 처리 등 적절한 보안 조치를 구현하여 시스템과 사용자를 보호할 책임이 있습니다.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-19

---