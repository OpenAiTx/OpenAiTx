<p align="center">
  <img src="https://raw.githubusercontent.com/elkar-ai/elkar-a2a/main/./images/logo.jpeg" alt="Elkar product screenshot"

**Elkar는 AI 에이전트를 위한 오픈 소스 작업 관리 레이어입니다** — Google의 Agent2Agent 프로토콜(A2A)을 기반으로 합니다.
**작업을 전송, 추적 및 조율하세요** AI 에이전트 간에 — 손쉽게.

[Elkar 앱](https://app.elkar.co/)  &nbsp;&nbsp;&nbsp; [웹사이트](https://elkar.co) &nbsp;&nbsp;&nbsp; [💬 Discord](https://discord.gg/f5Znhcvm) &nbsp;&nbsp;&nbsp; 

## ✨ Elkar란?

Elkar는 개발자가 인프라 관리의 복잡성 없이 A2A 프로토콜을 사용해 협력적이고 자율적인 다중 에이전트 시스템을 구축하도록 돕습니다.

Elkar가 제공하는 것:

- 🐍 A2A 프로토콜을 사용해 AI 에이전트를 구축하고 연결할 수 있는 Python SDK (다른 언어도 곧 지원 예정)와 저장소 및 큐 관리 기능.
- 🖥️ 에이전트 작업을 관리, 모니터링 및 디버깅할 수 있는 애플리케이션과 API.

인프라 걱정은 잊으세요 — Elkar가 복잡성을 처리하니 에이전트는 중요한 일, 즉 협업에 집중할 수 있습니다.
에이전트 동작을 디버깅하든 작업을 스트리밍하든 — Elkar가 A2A를 쉽게 만들어 줍니다.





## 🔧 Elkar로 무엇을 할 수 있나요?
내부 또는 외부 AI 에이전트 간의 원활한 협업을 활성화하세요:
다음 용도로 사용하세요:
- **지속적인 작업 저장소를 통한 비동기 작업 강력 지원으로** 장기 실행 작업을 손쉽게 추적 및 관리
- **관측 및 디버깅을 위한 작업 기록 탐색 및 관리**
- **전용 SDK를 통해 에이전트 간 실시간 작업 스트리밍**
- **작업 기록, 산출물 및 서버 통신에 대한 완전한 가시성을 통해 에이전트 작업 및 A2A 서버 상호작용 심층 디버깅**
<p align="center">
  <img src="https://raw.githubusercontent.com/elkar-ai/elkar-a2a/main/./images/debugger-ui.png" alt="Elkar product screenshot"

  
**면책 조항:** 이 프로젝트는 아직 초기 개발 단계에 있습니다.

## 👩‍💻 소프트웨어 개발 키트

Elkar는 A2A 프로토콜 구현을 단순화하는 Python SDK(다른 언어 지원 예정)를 제공합니다.

주요 기능:
- A2A 프로토콜의 완전한 구현
- 인프라 관리가 아닌 작업 실행에 중점을 둔 작업 지향 설계
- 간소화된 큐잉 및 저장소를 포함한 내장 작업 관리
- 스트리밍 응답 지원
- `RequestContext`를 통한 맞춤 인증 지원

## 🚀 빠른 시작 안내

아래 단계를 따라 Elkar 플랫폼을 시작하세요:

### 1단계: 회원가입 및 API 키 받기

아래 단계를 따라 Elkar 플랫폼을 시작하세요:

1. [Elkar 플랫폼](https://app.elkar.co/login)에서 **계정 생성**.
2. **새 에이전트 생성**: 메뉴에서 **Agents \> Add a new agent**로 이동.
3. **API 키 생성**

   ⚠️ **API 키를 지금 복사하세요** — 다시는 표시되지 않습니다.

### 2단계: Elkar SDK 설치


```python
pip install elkar
```
### 3단계: 작업 핸들러 생성하기

작업 핸들러는 작업의 상태와 아티팩트를 관리하며, 작업 저장소와 상호작용하는 복잡성을 추상화합니다. 세 가지 작업을 지원합니다: `set_status`, `add_messages_to_history`, 그리고 `upsert_artifact`.

작업 핸들러는 현재 엄격한 시그니처를 가지고 있습니다: `async def my_handler(task: TaskModifierBase, request_context: RequestContext) -> None.` 이 시그니처는 현재로서는 강제되지만, 앞으로 더 유연해질 수 있습니다.


```python
from elkar.a2a_types import *
from elkar.server.server import A2AServer
from elkar.task_manager.task_manager_base import RequestContext
from elkar.task_manager.task_manager_with_task_modifier import TaskManagerWithModifier
from elkar.task_modifier.base import TaskModifierBase

async def task_handler(
    task: TaskModifierBase, request_context: RequestContext | None
) -> None:

    await task.set_status(
        TaskStatus(
            state=TaskState.WORKING,
            message=Message(
                role="agent",
                parts=[TextPart(text="I understand the task, I'm working on it...")],
            ),
        )
    )

    await task.upsert_artifacts(
        [
            Artifact(
                parts=[TextPart(text="I've finished the task, here is the result...")],
                index=0,
            )
        ]
    )

    await task.set_status(
        TaskStatus(
            state=TaskState.COMPLETED,
            message=Message(
                role="agent",
                parts=[TextPart(text="I've finished the task!")],
            ),
        ),
        is_final=True,
    )
```
### 4단계: 에이전트 카드 생성

에이전트 카드는 A2A 프로토콜의 요구사항에 따라 정의됩니다.


```python
agent_card = AgentCard(
    name="Test Agent",
    description="Test Agent Description",
    url="https://example.com",
    provider=AgentProvider(organization="Elkar", url="https://www.elkar.co"),
    documentationUrl="https://example.com/documentation",
    version="1.0.0",
    skills=[
        AgentSkill(
            id="1",
            name="Generate image",
            description="Generate images from prompt description",
            inputModes=["text"],
            outputModes=["image"],
        ),
    ],
    capabilities=AgentCapabilities(
        streaming=True,
        pushNotifications=True,
        stateTransitionHistory=True,
    ),
)
```
### 5단계: A2A 서버 생성

관리형 서비스를 작업 저장소로 사용하여 A2A 서버를 인스턴스화합니다.


```python
api_key = "YOUR_ELKAR_API_KEY"  # Replace with your actual Elkar API key
store = ElkarClientStore(base_url="https://api.elkar.co/api", api_key=api_key)

task_manager: TaskManagerWithModifier = TaskManagerWithModifier(
    agent_card, 
    send_task_handler=task_handler,
    store=store
)

# Create the server instance
server = A2AServer(task_manager, host="0.0.0.0", port=5001, endpoint="/")

server.start() # This is blocking. For production, use an ASGI server like Uvicorn.
```
이 예제를 실행하려면(예: [main.py](http://main.py)로 저장하고 [server.app](http://server.app)을 app으로 노출한 경우):  uvicorn main:app --host 0.0.0.0 --port 5001


```bash
uvicorn main:app --host 0.0.0.0 --port 5001
```
## 📦 셀프 호스팅 패키지

Elkar 셀프 호스팅 버전을 로컬 메모리에서 작업 관리 및 스트리밍이 구현된 간단한 라이브러리로 사용할 수 있습니다. PostgreSQL 또는 Redis와 같은 다른 작업 저장소 지원은 곧 제공될 예정입니다.

자세한 통합 단계는 [오픈 소스 문서](https://docs.elkar.co/opensource/selfhost)를 참조하세요.


## 🛠️ A2A 디버거 전용 모드

클라이언트를 인증 설정이나 작업 관리 없이 A2A 서버 디버깅 용도로만 실행하려면:

1. **디버거 전용 모드로 실행**

```bash
cd a2a-client
npm run a2adebugger
```
2. **브라우저를 열고** `http://localhost:5173` 에 접속하세요

이 모드는 Supabase 인증이나 백엔드 서버 통합 없이 A2A 호환 서버 디버깅에만 집중한 간소화된 인터페이스를 제공합니다.

## ✅ 지원되는 작업 업데이트

1. **상태 업데이트**
작업의 상태와 에이전트의 진행 상황을 설명합니다. 상태 메시지는 작업 기록에 추가됩니다.


```python
await task.set_status(
    TaskStatus(
        state=TaskState.COMPLETED,
        message=Message(parts=[TextPart(text="I've finished the task!")])
    )
)
```
2. **아티팩트 업데이트**

아티팩트는 작업의 결과를 나타냅니다. 인덱스는 작업 내에서 아티팩트를 식별하는 데 사용됩니다. 인덱스가 일치하고 청크가 마지막이 아닌 경우 업데이트가 기존 아티팩트에 추가됩니다.

```python
await task.upsert_artifact(
    Artifact(parts=[TextPart(text="I've finished the task!")], index=0)
)
```
3. **메시지를 히스토리에 추가**

작업과 관련된 생각이나 과거의 커뮤니케이션과 같은 관련 정보를 저장합니다. ([elkarbackup/elkarbackup-docker - GitHub](https://github.com/elkarbackup/elkarbackup-docker?utm_source=chatgpt.com))


```python
await task.add_messages_to_history(
    [Message(parts=[TextPart(text="I'm working on the task...")])]
)
```
### 📚 로드맵
- 전체 문서
- 작업 저장소:
    - PostgreSQL, Redis, 호스팅
- 작업 큐:
    - PostgreSQL, Redis, 호스팅
- SDK:
    - JavaScript/TypeScript
    - Go
    - Rust
- 테스트 및 코드 샘플
- 푸시 알림 지원
- 작업 이력 검색 기능
- 향상된 작업 관리를 위한 모델 컨텍스트 프로토콜(MCP) 통합.

자세한 내용은 [문서](https://docs.elkar.co/)를 확인하세요!

## 💬 커뮤니티
도움받기, 아이디어 공유, 업데이트를 위해 [디스코드 서버](https://discord.gg/HDB4rkqn)에 참여하세요

## 🤝 기여하기

우리는 ❤️ 피드백, PR, 아이디어를 환영합니다! 도움 주는 방법은 다음과 같습니다:

- Elkar가 유용하다면, GitHub에서 ⭐️를 눌러주세요! — 프로젝트 지원에 큰 힘이 됩니다!
- 버그 신고나 기능 요청은 [이슈](https://github.com/elkar-ai/elkar/issues)를 통해 해주세요.
- Elkar로 만든 것을 [여기](https://discord.gg/HDB4rkqn)에서 자랑해보세요!
- [풀 리퀘스트](https://github.com/elkar-ai/elkar/pulls)를 제출하면 가능한 빨리 검토하겠습니다.

## 🔒 라이선스  
이 프로젝트는 MIT 라이선스에 따라 배포됩니다 – 자세한 내용은 [LICENSE](https://github.com/elkar-ai/elkar-a2a/blob/main/LICENCE) 파일을 참조하세요.









---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-19

---