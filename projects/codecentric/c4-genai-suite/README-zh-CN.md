# c4 GenAI 套件

一个集成了模型上下文提供者（MCP）的 AI 聊天机器人应用程序，由 Langchain 提供支持，并兼容所有主流的大型语言模型（LLM）和嵌入模型。

管理员可以通过添加扩展（如 RAG（检索增强生成）服务或 MCP 服务器）来创建具备不同能力的助手。该应用采用现代技术栈构建，包括用于 REI-S 服务的 React、NestJS 和 Python FastAPI。

用户可以通过用户友好的界面与助手进行交互。根据助手的配置，用户可以提问、上传自己的文件或使用其他功能。助手通过与各种 LLM 提供商进行交互，根据已配置的扩展提供响应。由已配置扩展提供的上下文信息使助手能够回答特定领域的问题并提供相关信息。

该应用程序采用模块化和可扩展的设计，允许用户通过添加扩展来创建具备不同能力的助手。

![基本用法的简短演示视频](https://raw.githubusercontent.com/codecentric/c4-genai-suite/main/demo/preview.webp)

## 功能特性

### 大型语言模型（LLM）及多模态模型

c4 GenAI 套件已经直接支持多种模型。如果您的首选模型尚未支持，也可以很容易地编写扩展来支持它。

* 兼容 OpenAI 的模型
* Azure OpenAI 模型
* Bedrock 模型
* Google GenAI 模型
* 兼容 Ollama 的模型
### 检索增强生成（RAG）

c4 GenAI 套件包括 REI-S，这是一个为 LLM 准备文件的服务器。

* REI-S，一个定制集成的 RAG 服务器
  * 向量存储
    * pgvector
    * Azure AI Search
  * 嵌入模型
    * 兼容 OpenAI 的嵌入
    * Azure OpenAI 嵌入
    * 兼容 Ollama 的嵌入
  * 文件格式：
    * pdf、docx、pptx、xlsx 等
    * 音频文件语音转录（通过 Whisper）

### 扩展

c4 GenAI 套件专为可扩展性设计。编写扩展非常简单，使用已有的 MCP 服务器也同样方便。

* 模型上下文协议（MCP）服务器
* 自定义 systemprompt
* 必应搜索
* 计算器
## 入门指南

### 使用 Docker-Compose

- 在项目根目录下运行 `docker compose up`。
- 在浏览器中打开[应用程序](http://localhost:3333)。默认登录凭证为用户 `admin@example.com`，密码为 `secret`。

![视频展示助手配置](https://raw.githubusercontent.com/codecentric/c4-genai-suite/main/demo/assistants.webp)

### 使用 Helm & Kubernetes

如需在 Kubernetes 环境中部署，请参考我们 Helm Chart 的 [README 文档](https://raw.githubusercontent.com/codecentric/c4-genai-suite/main/./helm-chart/README.md)。

### 设置助手和扩展

c4 GenAI Suite 以*助手*为核心。
每个助手由一组扩展组成，这些扩展决定了所用的 LLM 模型以及可用的工具。

- 在管理区域（点击左下角的用户名），进入[助手管理页面](http://localhost:3333/admin/assistants)。
- 通过板块标题旁的绿色 `+` 按钮添加助手，选择名称和描述。
- 选择创建的助手，点击绿色的 `+ 添加扩展`。
- 选择模型并填写凭证信息。
- 使用 `测试` 按钮检查是否正常工作，然后点击 `保存`。

现在您可以返回到[聊天页面](http://localhost:3333/chat)（点击左上角的 `c4 GenAI Suite`）并开始与新助手的对话。

> [!TIP]
> 我们的 `docker-compose` 集成了本地 Ollama，运行于 CPU 上。您可以用它进行快速测试。但它会比较慢，建议使用其他模型。如果您想使用 Ollama，只需在助手中创建如下模型扩展：
> * 扩展：`Dev: Ollama`
> * 端点：`http://ollama:11434`
> * 模型：`llama3.2`
### 模型上下文协议（MCP）[可选]

可使用任何提供 `sse` 接口并配备 `MCP Tools` 扩展的 MCP 服务器（或者在 `stdio` MCP 服务器前端使用我们的 `mcp-tool-as-server` 作为代理）。
每个 MCP 服务器都可以作为扩展进行详细配置。

### 检索增强生成（RAG）/ 文件搜索 [可选]

使用我们的 RAG 服务器 `REI-S` 来搜索用户提供的文件。只需为助手配置一个 `搜索文件` 扩展即可。
该过程在 [ `services/reis` 子目录](services/reis/#example-configuration-in-c4) 中有详细描述。

## 贡献与开发

* 有关贡献指南，请参见 [CONTRIBUTING.md](https://raw.githubusercontent.com/codecentric/c4-genai-suite/main/CONTRIBUTING.md)。
* 开发者入门指南，请查阅 [DEVELOPERS.md](https://raw.githubusercontent.com/codecentric/c4-genai-suite/main/DEVELOPERS.md)。

## 主要构建模块

该应用程序由**前端**、**后端**和**REI-S**服务组成。

```
┌──────────┐
│   用户   │
└─────┬────┘
      │ 访问
      ▼
┌──────────┐
│ 前端     │
└─────┬────┘
      │ 访问
      ▼
┌──────────┐     ┌─────────────────┐
│ 后端     │────►│     LLM         │
└─────┬────┘     └─────────────────┘
      │ 访问
      ▼
┌──────────┐     ┌─────────────────┐
│ REI-S    │────►│ 嵌入模型        │
│          │     └─────────────────┘
│          │
│          │     ┌─────────────────┐
│          │────►│ 向量存储        │
└──────────┘     └─────────────────┘
```
### 前端

前端使用 React 和 TypeScript 构建，提供了一个用户友好的界面，用于与后端和 REI-S 服务进行交互。它包含助手管理、扩展管理和聊天功能等特性。

> 源码位置：`/frontend`

### 后端

后端使用 NestJS 和 TypeScript 开发，作为应用程序的主要 API 层。它处理来自前端的请求，并与 LLM 提供商进行交互，以实现聊天功能。后端还负责管理助手及其扩展，允许用户配置和使用各种 AI 模型进行聊天。

此外，后端还负责用户身份验证，并与 REI-S 服务通信以实现文件索引和检索。

为实现数据持久化，后端使用了 **PostgreSQL** 数据库。

> 源码位置：`/backend`

### REI-S

REI-S（**R**etrieval **E**xtraction **I**ngestion **S**erver，检索提取摄取服务器）是一个基于 Python 的服务器，提供基础的 RAG（检索增强生成）能力。它支持文件内容提取、索引和查询，使应用能够高效处理大型数据集。REI-S 服务设计与后端无缝协作，为聊天功能和文件搜索提供所需数据。

REI-S 支持 Azure AI Search 和 pgvector 用于向量存储，提供灵活且可扩展的数据检索选项。该服务可通过环境变量配置，指定向量存储类型及连接详情。

> 源码位置：`/services/reis`


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-09

---