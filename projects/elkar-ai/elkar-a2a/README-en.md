<p align="center">
  <img src="https://raw.githubusercontent.com/elkar-ai/elkar-a2a/main/./images/logo.jpeg" alt="Elkar product screenshot"

**Elkar is an open-source task-management layer for AI agents** — based on Google's Agent2Agent Protocol (A2A).
**Send, track, and orchestrate tasks** across AI agents — effortlessly.

[Elkar app](https://app.elkar.co/)  &nbsp;&nbsp;&nbsp; [Website](https://elkar.co) &nbsp;&nbsp;&nbsp; [💬 Discord](https://discord.gg/f5Znhcvm) &nbsp;&nbsp;&nbsp; 

## ✨ What is Elkar?

Elkar helps developers build collaborative, autonomous multi-agent systems with A2A protocol without the complexity of managing infrastructure.

Elkar provides:

- 🐍 A Python SDK (other languages coming soon) to build and connect AI agents using the A2A protocol with store and queue management.
- 🖥️ An application and API to manage, monitor and debug agent tasks.

Forget about infrastructure concerns—Elkar handles the complexity so your agents can focus on what matters: working together.
Whether you're debugging agent behaviors or streaming tasks — Elkar makes A2A easy.





## 🔧 What can you do with Elkar?
Unlock seamless collaboration between your AI agents, whether they're in-house or external:
Use it to:
- **Effortlessly track and manage** long-running tasks, with robust support for asynchronous operations via a persistent task store
- **Browse and manage task history** for observability and debugging
- **Stream tasks** between agents in real-time via dedicated SDKs
- **Deeply debug agent tasks and A2A server interactions** with full visibility on task history, artifacts, and server communications
<p align="center">
  <img src="https://raw.githubusercontent.com/elkar-ai/elkar-a2a/main/./images/debugger-ui.png" alt="Elkar product screenshot"

  
**Disclaimer:** This project is still in early development.

## 👩‍💻 Software Development Kits

Elkar offers a Python SDK (with support for other languages coming soon) that simplifies the implementation of the A2A protocol. 

Key features include:
- Complete implementation of the A2A protocol
- Task-oriented design focused on executing tasks, not managing infrastructure
- Built-in task management with simplified queuing and storage
- Support for streaming responses
- Custom authentication via `RequestContext`

## 🚀 Quickstart Onboarding

Follow the steps below to get started with Elkar Platform:

### Step 1: Sign Up & Get Your API Key

Follow the steps below to get started with Elkar Platform:

1. **Create an account** on the [Elkar platform](https://app.elkar.co/login).
2. **Create a new agent**: Navigate to **Agents \> Add a new agent**.
3. **Generate an API Key**

   ⚠️ **Copy the API key now** — it won’t be shown again.

### Step 2: Install Elkar SDK


```python
pip install elkar
```
### Step 3: Create your Task Handler

The task handler manages a task’s status and artifacts, abstracting away the complexity of interacting with the Task Store. It supports three operations: `set_status`, `add_messages_to_history`, and `upsert_artifact`. 

The task handler currently has a strict signature: `async def my_handler(task: TaskModifierBase, request_context: RequestContext) -> None.`While this signature is enforced for now, it may become more flexible in the future.


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
### Step 4: Create your Agent Card

Your Agent Card is defined following the requirements from A2A Protocol.


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
### Step 5: Create your A2A Server

Instantiate your A2A Server with the Managed Service as Task Store.


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
To run this example (e.g., if saved as [main.py](http://main.py) and you expose [server.app](http://server.app) as app):  uvicorn main:app --host 0.0.0.0 --port 5001


```bash
uvicorn main:app --host 0.0.0.0 --port 5001
```
## 📦 Self-Hosting Package

You can use Elkar self-hosted version as a simple library with implemented task management and streaming in local memory. Support for other task stores as PostgreSQL or Redis will come soon. 

For detailed integration steps, see our [Open Source Documentation](https://docs.elkar.co/opensource/selfhost)


## 🛠️ A2A Debugger-Only Mode

If you want to run the client purely for debugging A2A servers without setting up authentication or task management:

1. **Run in debugger-only mode**

```bash
cd a2a-client
npm run a2adebugger
```
2. **Open your browser** at `http://localhost:5173`

This mode provides a simplified interface focused solely on debugging A2A-compatible servers without requiring Supabase authentication or backend server integration.

## ✅ Supported task updates

1. **Status Update**  
Describes the state of the task and the agent's progress. Messages in the status are appended to the task's history.


```python
await task.set_status(
    TaskStatus(
        state=TaskState.COMPLETED,
        message=Message(parts=[TextPart(text="I've finished the task!")])
    )
)
```
2. **Artifact Update**

Artifacts represent the outcome of a task. Indices are used to identify artifacts within a task. Updates will append to existing artifacts if the index matches and the chunk is not the last one.

```python
await task.upsert_artifact(
    Artifact(parts=[TextPart(text="I've finished the task!")], index=0)
)
```
3. **Append Messages to History**

Stores relevant information, such as thoughts or past communications, related to the task. ([elkarbackup/elkarbackup-docker - GitHub](https://github.com/elkarbackup/elkarbackup-docker?utm_source=chatgpt.com))


```python
await task.add_messages_to_history(
    [Message(parts=[TextPart(text="I'm working on the task...")])]
)
```
### 📚 Roadmap
- Full Documentation
- Task stores:
    - PostgreSQL, Redis, Hosted
- Task queues:
    - PostgreSQL, Redis, Hosted
- SDKs:
    - JavaScript/TypeScript
    - Go
    - Rust
- Tests and code samples
- Push notifications support
- Task history search functionality
- Integration with Model Context Protocol (MCP) for enhanced task management.

Check out our [documentation](https://docs.elkar.co/) for more details!

## 💬 Community
Join our [Discord server](https://discord.gg/HDB4rkqn) to get help, share ideas, and get updates

## 🤝 Contribute

We ❤️ feedback, PRs, and ideas! Here's how to help:

- If you find Elkar useful, a GitHub ⭐️ would mean a lot! — it helps to support the project!
- Report bugs or request features via [issues](https://github.com/elkar-ai/elkar/issues).
- Show off what you've built with Elkar [here](https://discord.gg/HDB4rkqn)! 
- Submit [pull requests](https://github.com/elkar-ai/elkar/pulls), and we'll review it as soon as possible.

## 🔒 License  
This project is licensed under the MIT License – see the [LICENSE](https://github.com/elkar-ai/elkar-a2a/blob/main/LICENCE) file for details.









---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-19

---