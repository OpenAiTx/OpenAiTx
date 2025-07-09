# LlamaIndex Workflows

[![单元测试](https://github.com/run-llama/workflows/actions/workflows/test.yml/badge.svg)](https://github.com/run-llama/workflows/actions/workflows/test.yml)
[![覆盖率状态](https://coveralls.io/repos/github/run-llama/workflows/badge.svg?branch=main)](https://coveralls.io/github/run-llama/workflows?branch=main)
[![GitHub 贡献者](https://img.shields.io/github/contributors/run-llama/workflows)](https://github.com/run-llama/llama-index-workflows/graphs/contributors)


[![PyPI - 下载量](https://img.shields.io/pypi/dm/llama-index-workflows)](https://pypi.org/project/llama-index-workflows/)
[![Discord](https://img.shields.io/discord/1059199217496772688)](https://discord.gg/dGcwcsnxhU)
[![Twitter](https://img.shields.io/twitter/follow/llama_index)](https://x.com/llama_index)
[![Reddit](https://img.shields.io/reddit/subreddit-subscribers/LlamaIndex?style=plastic&logo=reddit&label=r%2FLlamaIndex&labelColor=white)](https://www.reddit.com/r/LlamaIndex/)

LlamaIndex Workflows 是一个用于编排和串联复杂步骤与事件系统的框架。

## 使用 Workflows 可以构建什么？

当你需要编排涉及 AI 模型、API 和决策制定的复杂多步骤流程时，Workflows 能够大放异彩。以下是一些你可以构建的示例：

- **AI 智能体** - 创建能够推理、做出决策并跨多个步骤采取行动的智能系统
- **文档处理流程** - 构建能够摄取、分析、摘要和在不同处理阶段路由文档的系统
- **多模型 AI 应用** - 协调不同的 AI 模型（如 LLMs、视觉模型等）以解决复杂任务
- **研究助手** - 开发能够搜索、分析、综合信息并提供全面答案的工作流
- **内容生成系统** - 创建包含生成、审查、编辑与人工审核发布环节的内容管道
- **客户支持自动化** - 构建能够理解、分类并响应客户咨询的智能路由系统

以异步优先、事件驱动的架构为基础，Workflows 让你能够轻松构建可在不同能力间路由、实现并行处理模式、循环复杂序列，并在多个步骤间保持状态的工作流——这些都是让你的 AI 应用准备好生产环境所必需的特性。
## 主要特性

- **async-first（异步优先）** - 工作流围绕 Python 的 async（异步）功能构建——步骤是处理来自 asyncio 队列的传入事件并向其他队列发出新事件的异步函数。这也意味着工作流在你的异步应用中（如 FastAPI、Jupyter Notebooks 等）表现最佳。
- **事件驱动** - 工作流由步骤和事件组成。围绕事件和步骤组织代码，使其更易于理解和测试。
- **状态管理** - 每次工作流运行都是自包含的，这意味着你可以启动一个工作流，在其中保存信息，序列化工作流的状态并稍后恢复。
- **可观测性** - 工作流自动实现可观测性，这意味着你可以直接使用如 `Arize Phoenix` 和 `OpenTelemetry` 等工具。

## 快速开始

安装该包：

```bash
pip install llama-index-workflows
```

创建你的第一个工作流：

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
    # [可选] 为工作流提供一个上下文对象
    ctx = Context(workflow)
    result = await workflow.run(input_msg="Hello, world!", ctx=ctx)
    print("Workflow result:", result)

    # 使用相同的上下文重新运行将保留状态
    result = await workflow.run(input_msg="Hello, world!", ctx=ctx)
    print("Workflow result:", result)

if __name__ == "__main__":
    asyncio.run(main())
```

在上面的示例中
- 接受 `StartEvent` 的步骤将首先运行。
- 返回 `StopEvent` 的步骤将结束工作流。
- 中间事件由用户自定义，可用于在步骤之间传递信息。
- `Context` 对象也用于在步骤之间共享信息。

访问 [完整文档](https://docs.llamaindex.ai/en/stable/understanding/workflows/) 以获取更多使用 `llama-index` 的示例！

## 更多示例

- [基础功能演练](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/feature_walkthrough.ipynb)
- [使用 `llama-index` 构建函数调用代理](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/agent.ipynb)
- [人类参与的迭代式文档抽取](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/document_processing.ipynb)
- 可观测性
  - [OpenTelemetry + 插装入门](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/observability/workflows_observability_pt1.ipynb)
  - [OpenTelemetry + LlamaIndex](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/observability/workflows_observability_pt2.ipynb)
  - [Arize Phoenix + LlamaIndex](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/observability/workflows_observablitiy_arize_phoenix.ipynb)
  - [Langfuse + LlamaIndex](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/observability/workflows_observablitiy_langfuse.ipynb)

## 相关包

- [Typescript Workflows](https://github.com/run-llama/workflows-ts)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-09

---