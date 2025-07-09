# LlamaIndex Workflows

[![單元測試](https://github.com/run-llama/workflows/actions/workflows/test.yml/badge.svg)](https://github.com/run-llama/workflows/actions/workflows/test.yml)
[![覆蓋率狀態](https://coveralls.io/repos/github/run-llama/workflows/badge.svg?branch=main)](https://coveralls.io/github/run-llama/workflows?branch=main)
[![GitHub 貢獻者](https://img.shields.io/github/contributors/run-llama/workflows)](https://github.com/run-llama/llama-index-workflows/graphs/contributors)


[![PyPI - 下載次數](https://img.shields.io/pypi/dm/llama-index-workflows)](https://pypi.org/project/llama-index-workflows/)
[![Discord](https://img.shields.io/discord/1059199217496772688)](https://discord.gg/dGcwcsnxhU)
[![Twitter](https://img.shields.io/twitter/follow/llama_index)](https://x.com/llama_index)
[![Reddit](https://img.shields.io/reddit/subreddit-subscribers/LlamaIndex?style=plastic&logo=reddit&label=r%2FLlamaIndex&labelColor=white)](https://www.reddit.com/r/LlamaIndex/)

LlamaIndex Workflows 是一個用於協調與串接複雜步驟與事件系統的框架。

## 你可以用 Workflows 建立什麼？

當你需要協調複雜、多步驟的流程，這些流程涉及 AI 模型、API 與決策時，Workflows 能夠大放異彩。以下是你可以構建的一些範例：

- **AI 智能代理** - 創建能夠推理、做決策並在多步驟中採取行動的智慧系統
- **文件處理管線** - 構建能夠導入、分析、摘要並將文件傳遞至不同處理階段的系統
- **多模型 AI 應用** - 協調不同的 AI 模型（LLM、大型語言模型、視覺模型等）以解決複雜任務
- **研究助理** - 開發能夠搜尋、分析、綜合資訊並提供完整答案的工作流程
- **內容生成系統** - 建立生成、審查、編輯與發佈內容的管線，並支援人工審核
- **客服自動化** - 構建能夠理解、分類並回應客戶查詢的智慧分流系統

以非同步優先、事件驅動的架構設計，使你能輕鬆建立可在不同能力間路由、實現並行處理模式、循環複雜序列並在多步驟中維持狀態的工作流程——這些都是讓你的 AI 應用達到生產就緒所需的全部功能。
## 主要特點

- **async-first** - 工作流程圍繞 Python 的 async 功能構建——步驟是 async 函數，從 asyncio 隊列處理傳入事件並將新事件發送到其他隊列。這也意味著工作流程在如 FastAPI、Jupyter Notebooks 等異步應用中表現最佳。
- **事件驅動** - 工作流程由步驟和事件組成。將程式碼組織在事件和步驟周圍，使其更易於理解和測試。
- **狀態管理** - 每次運行的工作流程都是自包含的，這意味著你可以啟動一個工作流程，在其中保存資訊，序列化其狀態，稍後再恢復。
- **可觀察性** - 工作流程自動進行可觀察性儀器化，這表示你可以直接使用如 `Arize Phoenix` 和 `OpenTelemetry` 等工具。

## 快速開始

安裝套件：

```bash
pip install llama-index-workflows
```

並創建你的第一個工作流程：

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
# [optional] 提供一個 context 物件給 workflow
ctx = Context(workflow)
result = await workflow.run(input_msg="Hello, world!", ctx=ctx)
print("Workflow result:", result)

# 使用相同 context 重新執行會保留狀態
result = await workflow.run(input_msg="Hello, world!", ctx=ctx)
print("Workflow result:", result)

if __name__ == "__main__":
    asyncio.run(main())
```

在上面的範例中
- 接受 `StartEvent` 的步驟會最先執行。
- 回傳 `StopEvent` 的步驟會結束 workflow。
- 中間事件為使用者自訂，可用於步驟間傳遞資訊。
- `Context` 物件也用於在步驟間共享資訊。

請參考[完整文件](https://docs.llamaindex.ai/en/stable/understanding/workflows/)以獲得更多 `llama-index` 的使用範例！
## 更多範例

- [基本功能演練](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/feature_walkthrough.ipynb)
- [使用 `llama-index` 建立函式呼叫代理人](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/agent.ipynb)
- [人機協作的文件抽取迭代](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/document_processing.ipynb)
- 可觀察性
  - [OpenTelemetry + 儀器化入門](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/observability/workflows_observability_pt1.ipynb)
  - [OpenTelemetry + LlamaIndex](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/observability/workflows_observability_pt2.ipynb)
  - [Arize Phoenix + LlamaIndex](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/observability/workflows_observablitiy_arize_phoenix.ipynb)
  - [Langfuse + LlamaIndex](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/observability/workflows_observablitiy_langfuse.ipynb)

## 相關套件

- [Typescript Workflows](https://github.com/run-llama/workflows-ts)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-09

---