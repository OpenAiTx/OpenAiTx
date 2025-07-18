<translate-content># Agent2Agent (A2A) 샘플

이 저장소는 [Agent2Agent (A2A) 프로토콜](https://goo.gle/a2a)을 사용하는 코드 샘플과 데모를 포함합니다.

## 관련 저장소

- [A2A](https://github.com/a2aproject/A2A) - A2A 명세 및 문서.
- [a2a-python](https://github.com/a2aproject/a2a-python) - A2A 파이썬 SDK.
- [a2a-inspector](https://github.com/a2aproject/a2a-inspector) - A2A 지원 에이전트 검사용 UI 도구.

## 기여

기여 환영합니다! [기여 가이드](https://raw.githubusercontent.com/a2aproject/a2a-samples/main/CONTRIBUTING.md)를 참조하세요.

## 도움 받기

제안, 피드백 또는 버그 신고는 [이슈 페이지](https://github.com/a2aproject/a2a-samples/issues)를 이용해 주세요.

## 면책 조항

이 저장소 자체는 공식적으로 지원되는 구글 제품이 아닙니다. 이 저장소의 코드는 데모 목적에 한합니다.

중요: 제공된 샘플 코드는 데모 용도로, Agent-to-Agent (A2A) 프로토콜의 동작 방식을 보여줍니다. 실제 생산 환경 애플리케이션을 구축할 때는 직접 통제하지 않는 에이전트를 잠재적으로 신뢰할 수 없는 개체로 간주하는 것이 중요합니다.

외부 에이전트로부터 받은 모든 데이터—AgentCard, 메시지, 아티팩트, 작업 상태 등—는 신뢰할 수 없는 입력으로 처리해야 합니다. 예를 들어, 악의적인 에이전트가 필드(예: 설명, 이름, skills.description)에 조작된 데이터를 포함하는 AgentCard를 제공할 수 있습니다. 이 데이터가 정제 없이 대형 언어 모델(LLM)의 프롬프트 구성에 사용되면, 프롬프트 인젝션 공격에 노출될 수 있습니다. 이 데이터를 사용 전에 적절히 검증하고 정제하지 않으면 보안 취약점이 발생할 수 있습니다.

개발자는 입력 검증과 자격 증명 안전 처리 같은 적절한 보안 조치를 구현하여 시스템과 사용자를 보호할 책임이 있습니다.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---