# Prompt flow

[![Python package](https://img.shields.io/pypi/v/promptflow)](https://pypi.org/project/promptflow/)
[![Python](https://img.shields.io/pypi/pyversions/promptflow.svg?maxAge=2592000)](https://pypi.python.org/pypi/promptflow/)
[![PyPI - Downloads](https://img.shields.io/pypi/dm/promptflow)](https://pypi.org/project/promptflow/)
[![CLI](https://img.shields.io/badge/CLI-reference-blue)](https://microsoft.github.io/promptflow/reference/pf-command-reference.html)
[![vsc extension](https://img.shields.io/visual-studio-marketplace/i/prompt-flow.prompt-flow?logo=Visual%20Studio&label=Extension%20)](https://marketplace.visualstudio.com/items?itemName=prompt-flow.prompt-flow)

[![Doc](https://img.shields.io/badge/Doc-online-green)](https://microsoft.github.io/promptflow/index.html)
[![Issue](https://img.shields.io/github/issues/microsoft/promptflow)](https://github.com/microsoft/promptflow/issues/new/choose)
[![Discussions](https://img.shields.io/github/discussions/microsoft/promptflow)](https://github.com/microsoft/promptflow/issues/new/choose)
[![CONTRIBUTING](https://img.shields.io/badge/Contributing-8A2BE2)](https://github.com/microsoft/promptflow/blob/main/CONTRIBUTING.md)
[![License: MIT](https://img.shields.io/github/license/microsoft/promptflow)](https://github.com/microsoft/promptflow/blob/main/LICENSE)

> 欢迎加入我们，通过参与 [讨论](https://github.com/microsoft/promptflow/discussions)、提交 [问题](https://github.com/microsoft/promptflow/issues/new/choose)、贡献 [PRs](https://github.com/microsoft/promptflow/pulls) 共同完善 prompt flow。

**Prompt flow** 是一套开发工具，旨在简化基于大语言模型（LLM）的 AI 应用从构思、原型设计、测试、评估到生产部署与监控的端到端开发流程。它极大地简化了提示工程，并助你构建具备生产质量的 LLM 应用。

使用 prompt flow，你可以：

- **创建并迭代开发流程**
    - 创建可执行的 [流程](https://microsoft.github.io/promptflow/concepts/concept-flows.html)，将 LLM、提示词、Python 代码和其他 [工具](https://microsoft.github.io/promptflow/concepts/concept-tools.html) 连接在一起。
    - 调试并迭代你的流程，尤其是 [轻松追踪与 LLM 的交互](https://microsoft.github.io/promptflow/how-to-guides/tracing/index.html)。
- **评估流程质量与性能**
    - 通过更大规模的数据集评估你的流程质量和性能。
    - 将测试与评估集成至 CI/CD 系统，确保流程质量。
- **面向生产的高效开发流程**
    - 将你的流程部署至你选择的服务平台，或轻松集成进你的应用代码库。
    - （可选但强烈推荐）通过利用 [Azure AI 中的 Prompt flow 云版本](https://learn.microsoft.com/en-us/azure/machine-learning/prompt-flow/overview-what-is-prompt-flow?view=azureml-api-2) 与团队协作。

------

## 安装

为快速入门，你可以使用预构建的开发环境。**点击下方按钮**，在 GitHub Codespaces 中打开本仓库，然后继续阅读本说明文档！

[![Open in GitHub Codespaces](https://github.com/codespaces/badge.svg)](https://codespaces.new/microsoft/promptflow?quickstart=1)

如果你想在本地环境开始，首先安装以下包：

请确保你已拥有 python 环境，推荐使用 `python>=3.9, <=3.11`。

```sh
pip install promptflow promptflow-tools
```

## 快速开始 ⚡

**使用 prompt flow 创建聊天机器人**

运行以下命令，通过聊天模板初始化一个 prompt flow，这将在当前目录下创建名为 `my_chatbot` 的文件夹，并在其中生成所需文件：

```sh
pf flow init --flow ./my_chatbot --type chat
```

**为你的 API 密钥设置连接**

对于 OpenAI 密钥，运行以下命令建立连接，使用 `my_chatbot` 文件夹中的 `openai.yaml` 文件，该文件用于存储你的 OpenAI 密钥（可通过 --set 参数覆盖密钥和名称，避免修改 yaml 文件）：

```sh
pf connection create --file ./my_chatbot/openai.yaml --set api_key=<your_api_key> --name open_ai_connection
```

对于 Azure OpenAI 密钥，运行以下命令建立连接，使用 `azure_openai.yaml` 文件：

```sh
pf connection create --file ./my_chatbot/azure_openai.yaml --set api_key=<your_api_key> api_base=<your_api_base> --name open_ai_connection
```

**与流程进行对话**

在 `my_chatbot` 文件夹中，有一个 `flow.dag.yaml` 文件，描述了流程，包括输入/输出、节点、连接和 LLM 模型等信息。

> 注意，在 `chat` 节点中，我们使用名为 `open_ai_connection` 的连接（在 `connection` 字段指定），以及 `gpt-35-turbo` 模型（在 `deployment_name` 字段指定）。deployment_name 字段用于指定 OpenAI 模型，或 Azure OpenAI 的部署资源。

通过运行以下命令与聊天机器人交互：（按下 `Ctrl + C` 结束会话）

```sh
pf flow test --flow ./my_chatbot --interactive
```

**核心价值：确保从原型到生产的“高质量”**

探索我们的[**15 分钟教程**](https://raw.githubusercontent.com/microsoft/promptflow/main/examples/tutorials/flow-fine-tuning-evaluation/promptflow-quality-improvement.md)，引导你完成提示词微调 ➡ 批量测试 ➡ 评估，助你打造生产级高质量应用。

下一步！继续阅读 **教程** 👇 部分，深入了解 prompt flow。

## 教程 🏃‍♂️

Prompt flow 是一款专为 **构建高质量 LLM 应用** 而设计的工具，其开发流程包括：开发流程、提升流程质量、部署到生产环境。

### 开发你的 LLM 应用

#### VS Code 扩展

我们还提供了 VS Code 扩展（流程设计器），带来 UI 交互式流程开发体验。

<img src="https://raw.githubusercontent.com/microsoft/promptflow/main/docs/media/readme/vsc.png" alt="vsc" width="1000"/>

你可以在 <a href="https://marketplace.visualstudio.com/items?itemName=prompt-flow.prompt-flow">Visual Studio Marketplace</a> 获取。

#### 深入流程开发

[Prompt flow 入门指南](https://raw.githubusercontent.com/microsoft/promptflow/main/docs/how-to-guides/quick-start.md)：逐步指导你如何调用第一个流程运行。

### 从用例中学习

[教程：PDF 聊天机器人](https://github.com/microsoft/promptflow/blob/main/examples/tutorials/e2e-development/chat-with-pdf.md)：端到端演示如何使用 prompt flow 构建高质量聊天应用，包括流程开发及基于指标的评估。
> 更多示例请见 [这里](https://microsoft.github.io/promptflow/tutorials/index.html#samples)。欢迎贡献新的用例！

### 贡献者环境搭建

如果你有兴趣参与贡献，请先阅读我们的开发环境搭建指南：[dev_setup.md](https://raw.githubusercontent.com/microsoft/promptflow/main/docs/dev/dev_setup.md)。

下一步！继续阅读 **贡献指南** 👇 部分，参与 prompt flow 的开发。

## 贡献指南

本项目欢迎各类贡献和建议。大多数贡献需你同意
贡献者许可协议（CLA），声明你有权利并实际授予我们
使用你的贡献的权利。详情请访问 https://cla.opensource.microsoft.com。

当你提交拉取请求（pull request）时，CLA 机器人会自动判断你是否需签署 CLA，并在 PR 上做出相应标记（如状态检查、评论）。请按照机器人的指引操作。你只需在所有使用我们 CLA 的仓库中操作一次。

本项目已采用 [Microsoft 开源行为准则](https://opensource.microsoft.com/codeofconduct/)。
更多信息请参见 [行为准则 FAQ](https://opensource.microsoft.com/codeofconduct/faq/) 或通过 [opencode@microsoft.com](mailto:opencode@microsoft.com) 联系我们。

## 商标声明

本项目可能包含项目、产品或服务的商标或徽标。经授权使用 Microsoft
商标或徽标需遵守并符合
[Microsoft 商标与品牌指南](https://www.microsoft.com/en-us/legal/intellectualproperty/trademarks/usage/general)。
在本项目的修改版中使用 Microsoft 商标或徽标不得造成混淆或暗示 Microsoft 赞助。
对第三方商标或徽标的任何使用，均须遵守第三方政策。

## 行为准则

本项目已采用
[Microsoft 开源行为准则](https://opensource.microsoft.com/codeofconduct/)。
更多信息请参见
[行为准则 FAQ](https://opensource.microsoft.com/codeofconduct/faq/)
或通过 [opencode@microsoft.com](mailto:opencode@microsoft.com)
联系我们。

## 数据收集

该软件可能会收集有关你及你对软件使用情况的信息，并在配置启用遥测的情况下发送给 Microsoft。
Microsoft 可能会使用这些信息来提供服务并改进我们的产品和服务。
你可以按仓库描述开启遥测。
软件中也可能有些功能允许你和 Microsoft
收集应用用户的数据。如使用这些功能，你需遵守相关法律，包括向
应用用户提供适当的通知并附上 Microsoft 的隐私声明副本。我们的隐私声明位于
https://go.microsoft.com/fwlink/?LinkID=824704。你可以在帮助文档和隐私声明中了解更多数据收集与使用信息。你使用本软件即表示你同意上述做法。

### 遥测配置

遥测收集默认开启。

如需关闭，请运行 `pf config set telemetry.enabled=false`。

## 许可证

版权所有 (c) Microsoft Corporation。保留所有权利。

根据 [MIT](LICENSE) 许可证授权。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---