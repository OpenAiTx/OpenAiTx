<picture>
  <source media="(prefers-color-scheme: light)" srcset="docs/static/img/logo-dark.svg">
  <source media="(prefers-color-scheme: dark)" srcset="docs/static/img/logo-light.svg">
  <img alt="LangChain 标志" src="docs/static/img/logo-dark.svg" width="80%">
</picture>

<div>
<br>
</div>

[![发布说明](https://img.shields.io/github/release/langchain-ai/langchain?style=flat-square)](https://github.com/langchain-ai/langchain/releases)
[![CI](https://github.com/langchain-ai/langchain/actions/workflows/check_diffs.yml/badge.svg)](https://github.com/langchain-ai/langchain/actions/workflows/check_diffs.yml)
[![PyPI - License](https://img.shields.io/pypi/l/langchain-core?style=flat-square)](https://opensource.org/licenses/MIT)
[![PyPI - Downloads](https://img.shields.io/pypi/dm/langchain-core?style=flat-square)](https://pypistats.org/packages/langchain-core)
[![GitHub star chart](https://img.shields.io/github/stars/langchain-ai/langchain?style=flat-square)](https://star-history.com/#langchain-ai/langchain)
[![未解决问题](https://img.shields.io/github/issues-raw/langchain-ai/langchain?style=flat-square)](https://github.com/langchain-ai/langchain/issues)
[![在 Dev Containers 中打开](https://img.shields.io/static/v1?label=Dev%20Containers&message=Open&color=blue&logo=visualstudiocode&style=flat-square)](https://vscode.dev/redirect?url=vscode://ms-vscode-remote.remote-containers/cloneInVolume?url=https://github.com/langchain-ai/langchain)
[<img src="https://github.com/codespaces/badge.svg" title="在 Github Codespace 打开" width="150" height="20">](https://codespaces.new/langchain-ai/langchain)
[![Twitter](https://img.shields.io/twitter/url/https/twitter.com/langchainai.svg?style=social&label=Follow%20%40LangChainAI)](https://twitter.com/langchainai)
[![CodSpeed Badge](https://img.shields.io/endpoint?url=https://codspeed.io/badge.json)](https://codspeed.io/langchain-ai/langchain)

> [!NOTE]
> 正在寻找 JS/TS 库？请查看 [LangChain.js](https://github.com/langchain-ai/langchainjs)。

LangChain 是一个用于构建由大语言模型（LLM）驱动应用的框架。它帮助你将可互操作的组件和第三方集成组合在一起，从而简化 AI 应用开发——同时在底层技术演进的过程中保护你的架构决策。

```bash
pip install -U langchain
```

想要了解更多关于 LangChain 的信息，请查看
[官方文档](https://python.langchain.com/docs/introduction/)。如果你在寻找更高级的自定义或智能体编排，请查看
[LangGraph](https://langchain-ai.github.io/langgraph/)，这是我们用于构建可控智能体工作流的框架。

## 为什么选择 LangChain？

LangChain 通过为模型、嵌入、向量存储等提供标准接口，帮助开发者构建由大语言模型驱动的应用。

使用 LangChain 的场景包括：
- **实时数据增强**。轻松将 LLM 连接到多样的数据源及外部/内部系统，利用 LangChain 大量与模型提供商、工具、向量存储、检索器等的集成库。
- **模型互操作性**。在工程团队探索以找到最适合你应用需求的模型时，可以随意切换模型。随着行业前沿的发展，快速适应——LangChain 的抽象层让你持续前进，不会失去动力。

## LangChain 生态系统

虽然 LangChain 框架可独立使用，但它也可无缝集成到任何 LangChain 产品中，为开发者在构建 LLM 应用时提供完整工具套件。

为了提升你的 LLM 应用开发体验，推荐将 LangChain 与以下产品搭配使用：

- [LangSmith](http://www.langchain.com/langsmith) - 有助于智能体评估和可观测性。调试 LLM 应用的低效运行，评估智能体轨迹，获得生产环境可视化，并持续提升性能。
- [LangGraph](https://langchain-ai.github.io/langgraph/) - 使用 LangGraph 构建能够可靠处理复杂任务的智能体，这是我们底层的智能体编排框架。LangGraph 提供可定制架构、长期记忆和人工参与工作流——并已被 LinkedIn、Uber、Klarna、GitLab 等公司在生产中信赖使用。
- [LangGraph Platform](https://langchain-ai.github.io/langgraph/concepts/langgraph_platform/) - 通过专为长时间运行、有状态工作流设计的部署平台，实现智能体的轻松部署和扩展。在团队间发现、复用、配置和共享智能体——并通过 [LangGraph Studio](https://langchain-ai.github.io/langgraph/concepts/langgraph_studio/) 的可视化原型快速迭代。

## 更多资源

- [教程](https://python.langchain.com/docs/tutorials/)：通过引导示例，简单演示如何快速入门 LangChain。
- [操作指南](https://python.langchain.com/docs/how_to/)：关于工具调用、RAG 用例等主题的简明实用代码片段。
- [概念指南](https://python.langchain.com/docs/concepts/)：对 LangChain 框架背后的关键概念进行讲解。
- [API 参考](https://python.langchain.com/api_reference/)：关于 LangChain 基础包和集成的详细参考文档。

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---