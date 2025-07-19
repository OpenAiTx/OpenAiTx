<p align="center">
  <img src="https://raw.githubusercontent.com/elkar-ai/elkar-a2a/main/./images/logo.jpeg" alt="Elkar 产品截图"

**Elkar 是一个基于谷歌 Agent2Agent 协议（A2A）的开源 AI 代理任务管理层**。
**发送、跟踪和协调 AI 代理之间的任务** —— 轻松实现。

[Elkar 应用](https://app.elkar.co/)  &nbsp;&nbsp;&nbsp; [官网](https://elkar.co) &nbsp;&nbsp;&nbsp; [💬 Discord](https://discord.gg/f5Znhcvm) &nbsp;&nbsp;&nbsp; 

## ✨ 什么是 Elkar？

Elkar 帮助开发者利用 A2A 协议构建协作的自治多代理系统，无需管理复杂的基础设施。

Elkar 提供：

- 🐍 一个 Python SDK（其他语言即将推出），用于使用 A2A 协议构建和连接 AI 代理，包含存储和队列管理。
- 🖥️ 一个应用程序和 API，用于管理、监控和调试代理任务。

无需担心基础设施——Elkar 处理复杂性，让你的代理专注于重要的事情：协同工作。
无论你是在调试代理行为还是流式处理任务——Elkar 让 A2A 变得简单。





## 🔧 使用 Elkar 可以做什么？
解锁你的 AI 代理间无缝协作，无论是内部还是外部代理：
你可以用它来：
- **轻松跟踪和管理** 长时间运行的任务，强力支持通过持久任务存储的异步操作
- **浏览和管理任务历史**，便于观察和调试
- **通过专用 SDK 实时流式传输任务** 代理间协作
- **深入调试代理任务和 A2A 服务器交互**，完全可见任务历史、工件和服务器通信
<p align="center">
  <img src="https://raw.githubusercontent.com/elkar-ai/elkar-a2a/main/./images/debugger-ui.png" alt="Elkar 产品截图"

  
**免责声明：** 本项目仍处于早期开发阶段。

## 👩‍💻 软件开发工具包

Elkar 提供一个 Python SDK（其他语言支持即将推出），简化了 A2A 协议的实现。

主要功能包括：
- 完整实现 A2A 协议
- 以任务为导向，专注于执行任务而非管理基础设施
- 内置任务管理，简化排队和存储
- 支持流式响应
- 通过 `RequestContext` 进行自定义认证

## 🚀 快速入门指南

按照以下步骤开始使用 Elkar 平台：

### 第一步：注册并获取 API 密钥

按照以下步骤开始使用 Elkar 平台：

1. **在[Elkar 平台](https://app.elkar.co/login)创建账户**。
2. **创建新代理**：导航到 **代理 \> 添加新代理**。
3. **生成 API 密钥**

   ⚠️ **请立即复制 API 密钥** — 之后将不会再次显示。

### 第二步：安装 Elkar SDK


```python
pip install elkar
```
### 第3步：创建你的任务处理器

任务处理器管理任务的状态和工件，抽象出与任务存储交互的复杂性。它支持三个操作：`set_status`、`add_messages_to_history` 和 `upsert_artifact`。

任务处理器当前具有严格的签名：`async def my_handler(task: TaskModifierBase, request_context: RequestContext) -> None.`虽然目前强制执行此签名，但未来可能会更加灵活。


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
### 第4步：创建您的代理卡

您的代理卡需按照A2A协议的要求进行定义。


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
### 第5步：创建您的A2A服务器

使用托管服务作为任务存储实例化您的A2A服务器。


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
<translate-content>
运行此示例（例如，如果保存为 [main.py](http://main.py) 并将 [server.app](http://server.app) 作为 app 暴露）： uvicorn main:app --host 0.0.0.0 --port 5001
</translate-content>
```bash
uvicorn main:app --host 0.0.0.0 --port 5001
```
## 📦 自托管软件包

您可以将 Elkar 自托管版本作为一个简单的库来使用，其中实现了任务管理和本地内存中的流处理。对其他任务存储如 PostgreSQL 或 Redis 的支持即将推出。

有关详细的集成步骤，请参阅我们的[开源文档](https://docs.elkar.co/opensource/selfhost)


## 🛠️ 仅调试模式的 A2A

如果您只想运行客户端以调试 A2A 服务器，而不设置身份验证或任务管理：

1. **以仅调试模式运行**

```bash
cd a2a-client
npm run a2adebugger
```
<translate-content>
2. **打开您的浏览器**，访问 `http://localhost:5173`

此模式提供了一个简化界面，专注于调试兼容 A2A 的服务器，无需 Supabase 认证或后端服务器集成。

## ✅ 支持的任务更新

1. **状态更新**
描述任务的状态和代理的进展。状态中的消息会被追加到任务的历史记录中。
</translate-content>
```python
await task.set_status(
    TaskStatus(
        state=TaskState.COMPLETED,
        message=Message(parts=[TextPart(text="I've finished the task!")])
    )
)
```
2. **工件更新**

工件表示任务的结果。索引用于识别任务中的工件。  
如果索引匹配且该块不是最后一个，则更新会附加到现有工件中。
```python
await task.upsert_artifact(
    Artifact(parts=[TextPart(text="I've finished the task!")], index=0)
)
```
3. **将消息追加到历史记录**

存储与任务相关的相关信息，如思路或过去的通信记录。([elkarbackup/elkarbackup-docker - GitHub](https://github.com/elkarbackup/elkarbackup-docker?utm_source=chatgpt.com))


```python
await task.add_messages_to_history(
    [Message(parts=[TextPart(text="I'm working on the task...")])]
)
```
### 📚 路线图
- 完整文档
- 任务存储：
    - PostgreSQL，Redis，托管
- 任务队列：
    - PostgreSQL，Redis，托管
- SDK：
    - JavaScript/TypeScript
    - Go
    - Rust
- 测试和代码示例
- 推送通知支持
- 任务历史搜索功能
- 与模型上下文协议 (MCP) 集成以增强任务管理。

查看我们的[文档](https://docs.elkar.co/)了解更多详情！

## 💬 社区
加入我们的[Discord服务器](https://discord.gg/HDB4rkqn)获取帮助、分享想法并获取更新

## 🤝 贡献

我们 ❤️ 反馈、PR 和创意！以下是帮助方式：

- 如果你觉得 Elkar 有用，一个 GitHub ⭐️ 会非常重要！——这有助于支持项目！
- 通过[问题](https://github.com/elkar-ai/elkar/issues)报告错误或请求功能。
- 在[这里](https://discord.gg/HDB4rkqn)展示你用 Elkar 构建的项目！
- 提交[拉取请求](https://github.com/elkar-ai/elkar/pulls)，我们会尽快审核。

## 🔒 许可  
本项目采用 MIT 许可证授权 – 详情请见[许可证](https://github.com/elkar-ai/elkar-a2a/blob/main/LICENCE)文件。









---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-19

---