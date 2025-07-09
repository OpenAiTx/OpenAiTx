# LlamaIndex 워크플로우

[![단위 테스트](https://github.com/run-llama/workflows/actions/workflows/test.yml/badge.svg)](https://github.com/run-llama/workflows/actions/workflows/test.yml)
[![커버리지 상태](https://coveralls.io/repos/github/run-llama/workflows/badge.svg?branch=main)](https://coveralls.io/github/run-llama/workflows?branch=main)
[![GitHub 기여자](https://img.shields.io/github/contributors/run-llama/workflows)](https://github.com/run-llama/llama-index-workflows/graphs/contributors)


[![PyPI - 다운로드](https://img.shields.io/pypi/dm/llama-index-workflows)](https://pypi.org/project/llama-index-workflows/)
[![Discord](https://img.shields.io/discord/1059199217496772688)](https://discord.gg/dGcwcsnxhU)
[![Twitter](https://img.shields.io/twitter/follow/llama_index)](https://x.com/llama_index)
[![Reddit](https://img.shields.io/reddit/subreddit-subscribers/LlamaIndex?style=plastic&logo=reddit&label=r%2FLlamaIndex&labelColor=white)](https://www.reddit.com/r/LlamaIndex/)

LlamaIndex 워크플로우는 단계와 이벤트로 이루어진 복잡한 시스템을 조율하고 연결하는 프레임워크입니다.

## 워크플로우로 무엇을 만들 수 있나요?

워크플로우는 AI 모델, API, 의사결정이 포함된 복잡하고 다단계의 프로세스를 조율해야 할 때 탁월합니다. 다음은 워크플로우로 만들 수 있는 예시입니다:

- **AI 에이전트** - 복수 단계에 걸쳐 추론, 의사결정, 행동이 가능한 지능형 시스템을 만듭니다
- **문서 처리 파이프라인** - 다양한 처리 단계를 거치며 문서를 수집, 분석, 요약, 라우팅하는 시스템을 구축합니다
- **다중 모델 AI 애플리케이션** - 여러 AI 모델(LLM, 비전 모델 등) 간의 협력을 통해 복잡한 작업을 해결합니다
- **연구 도우미** - 정보를 검색, 분석, 종합하고 포괄적인 답변을 제공하는 워크플로우를 개발합니다
- **콘텐츠 생성 시스템** - 생성, 검토, 편집, 인간 승인 후 게시까지의 파이프라인을 구축합니다
- **고객 지원 자동화** - 고객 문의를 이해, 분류, 응답하는 지능형 라우팅 시스템을 만듭니다

비동기 우선, 이벤트 기반 아키텍처를 통해 다양한 기능 간의 라우팅, 병렬 처리 패턴 구현, 복잡한 시퀀스 반복, 여러 단계에 걸친 상태 유지 등, AI 애플리케이션을 프로덕션 환경에 적합하게 만드는 데 필요한 모든 기능을 손쉽게 구현할 수 있습니다.
## 주요 특징

- **async-first** - 워크플로우는 Python의 async 기능을 중심으로 구축되어 있습니다. 각 스텝은 asyncio 큐에서 들어오는 이벤트를 처리하고, 다른 큐로 새로운 이벤트를 내보내는 async 함수입니다. 따라서 FastAPI, Jupyter Notebooks 등과 같은 async 앱에서 워크플로우가 최적의 성능을 발휘합니다.
- **이벤트 기반(event-driven)** - 워크플로우는 스텝과 이벤트로 구성됩니다. 코드를 이벤트와 스텝 중심으로 구성하면 이해 및 테스트가 쉬워집니다.
- **상태 관리(state management)** - 워크플로우의 각 실행(run)은 독립적이며, 워크플로우를 시작하고 그 안에 정보를 저장하며, 워크플로우의 상태를 직렬화하여 나중에 이어서 실행할 수 있습니다.
- **관측 가능성(observability)** - 워크플로우는 자동으로 관측 가능성 도구가 적용되어 있습니다. 즉, `Arize Phoenix`, `OpenTelemetry`와 같은 도구를 즉시 사용할 수 있습니다.

## 빠른 시작

패키지 설치:

```bash
pip install llama-index-workflows
```

그리고 첫 번째 워크플로우를 생성하세요:

```python
import asyncio
from pydantic import BaseModel, Field
from workflows import Context, Workflow, step
from workflows.events import Event, StartEvent, StopEvent

class MyEvent(Event):
    msg: list[str]

class RunState(BaseModel):
    num_runs: int = Field(default=0)

class MyWorkflow(Workflow):
    @step
    async def start(self, ctx: Context[RunState], ev: StartEvent) -> MyEvent:
        async with ctx.store.edit_state() as state:
            state.num_runs += 1

            return MyEvent(msg=[ev.input_msg] * state.num_runs)

    @step
    async def process(self, ctx: Context[RunState], ev: MyEvent) -> StopEvent:
        data_length = len("".join(ev.msg))
        new_msg = f"Processed {len(ev.msg)} times, data length: {data_length}"
        return StopEvent(result=new_msg)

async def main():
    workflow = MyWorkflow()
```
```python
# [optional] 워크플로우에 컨텍스트 객체를 제공합니다.
ctx = Context(workflow)
result = await workflow.run(input_msg="Hello, world!", ctx=ctx)
print("Workflow result:", result)

# 동일한 컨텍스트로 다시 실행하면 상태가 유지됩니다.
result = await workflow.run(input_msg="Hello, world!", ctx=ctx)
print("Workflow result:", result)

if __name__ == "__main__":
    asyncio.run(main())
```

위의 예제에서
- `StartEvent`를 수락하는 단계가 먼저 실행됩니다.
- `StopEvent`를 반환하는 단계는 워크플로우를 종료합니다.
- 중간 이벤트는 사용자가 정의하며, 단계 간에 정보를 전달하는 데 사용할 수 있습니다.
- `Context` 객체 또한 단계 간에 정보를 공유하는 데 사용됩니다.

`llama-index`를 사용한 더 많은 예제는 [전체 문서](https://docs.llamaindex.ai/en/stable/understanding/workflows/)를 방문하세요!

## 추가 예시

- [기본 기능 실행 가이드](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/feature_walkthrough.ipynb)
- [`llama-index`로 함수 호출 에이전트 구축하기](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/agent.ipynb)
- 인간이 참여하는 반복적 문서 추출(Human-in-the-loop Iterative Document Extraction)
  - [OpenTelemetry + 계측 입문](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/observability/workflows_observability_pt1.ipynb)
  - [OpenTelemetry + LlamaIndex](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/observability/workflows_observability_pt2.ipynb)
  - [Arize Phoenix + LlamaIndex](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/observability/workflows_observablitiy_arize_phoenix.ipynb)
  - [Langfuse + LlamaIndex](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/observability/workflows_observablitiy_langfuse.ipynb)

## 관련 패키지

- [Typescript Workflows](https://github.com/run-llama/workflows-ts)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-09

---