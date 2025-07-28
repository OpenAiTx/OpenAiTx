# llama-github

[详细文档] https://deepwiki.com/JetXu-LLM/llama-github

[![PyPI版本](https://badge.fury.io/py/llama-github.svg)](https://badge.fury.io/py/llama-github)
[![下载量](https://static.pepy.tech/badge/Llama-github)](https://pepy.tech/project/Llama-github)
[![许可证](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)

Llama-github 是一个强大的工具，基于 Agentic RAG，帮助你根据查询从 GitHub 中检索最相关的代码片段、问题和仓库信息，将其转化为有价值的知识上下文。它赋能 LLM 聊天机器人、AI 代理和自动开发代理，解决复杂的编码任务。无论你是寻找快速解决方案的开发者，还是实现高级自动开发 AI 代理的工程师，llama-github 都让这一切变得简单高效。

如果你喜欢这个项目或认为它有潜力，请给它一个 ⭐️。你的支持是我们最大的动力！

## 架构
![高级架构](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/./docs/high_level_architecture.drawio.svg)

## 安装
```
pip install llama-github
```

## 使用方法

下面是一个如何使用 llama-github 的简单示例：

```python
from llama_github import GithubRAG

# Initialize GithubRAG with your credentials
github_rag = GithubRAG(
    github_access_token="your_github_access_token", 
    openai_api_key="your_openai_api_key", # Optional in Simple Mode
    jina_api_key="your_jina_api_key" # Optional - unless you want high concurrency production deployment (s.jina.ai API will be used in llama-github)
)

# Retrieve context for a coding question (simple_mode is default set to False)
query = "How to create a NumPy array in Python?"
context = github_rag.retrieve_context(
    query, # In professional mode, one query will take nearly 1 min to generate final contexts. You could set log level to INFO to monitor the retrieval progress
    # simple_mode = True
)

print(context)
```
更多高级用法和示例，请参阅[文档](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/docs/usage.md)。

## 主要特性

- **🔍 智能 GitHub 检索**：利用 llama-github 的强大功能，根据用户查询从 GitHub 中检索高度相关的代码片段、问题和仓库信息。我们先进的检索技术确保您快速高效地找到最相关的信息。

- **⚡ 仓库池缓存**：llama-github 拥有创新的仓库池缓存机制。通过跨线程缓存仓库（包括 README、结构、代码和问题），llama-github 显著提升 GitHub 搜索检索效率，最大限度减少 GitHub API 令牌的消耗。在多线程生产环境中部署 llama-github，确保其性能最优并节省宝贵资源。

- **🧠 LLM 驱动的问题分析**：利用最先进的语言模型分析用户问题，生成高效的搜索策略和标准。llama-github 智能拆解复杂查询，确保从 GitHub 庞大的仓库网络中检索到最相关的信息。

- **📚 全面上下文生成**：通过无缝结合从 GitHub 检索的信息与先进语言模型的推理能力，生成丰富且上下文相关的答案。llama-github 擅长处理即使是最复杂和冗长的问题，提供包含大量上下文的全面且有洞察力的响应，支持您的开发需求。

- **🚀 异步处理卓越性能**：llama-github 从零开始构建，充分利用异步编程的全部潜力。代码库中精心实现的异步机制，使 llama-github 能够并发处理多个请求，显著提升整体性能。体验 llama-github 高效管理高负载工作而不牺牲速度或质量的差异。

- **🔧 灵活的 LLM 集成**：轻松将 llama-github 与各种 LLM 提供商、嵌入模型和重新排序模型集成，定制库的功能以满足您的具体需求。我们可扩展的架构允许您定制和增强 llama-github 的功能，确保其无缝适应您独特的开发环境。

- **🔒 强大的认证选项**：llama-github 支持个人访问令牌和 GitHub 应用认证，提供灵活性以集成到不同的开发设置中。无论您是个人开发者还是在组织环境中工作，llama-github 都为您提供安全可靠的认证机制。

- **🛠️ 日志记录和错误处理**：我们理解顺畅操作和便捷故障排除的重要性。因此，llama-github 配备了全面的日志记录和错误处理机制。深入洞察库的行为，快速诊断问题，维护稳定可靠的开发工作流程。

## 🤖 试用我们的 AI 驱动 PR 审查助手：LlamaPReview

如果您觉得 llama-github 有用，您可能也会对我们的 AI 驱动 GitHub PR 审查助手 LlamaPReview 感兴趣。它旨在辅助您的开发工作流，进一步提升代码质量。

### LlamaPReview 的主要特性：
- 🚀 一键安装，无需配置，完全自动运行
- 💯 目前免费使用 - 无需信用卡或支付信息
- 🧠 AI 驱动，自动 PR 审查，深度代码理解
- 🌐 支持多种编程语言

**LlamaPReview 利用 llama-github 的先进上下文检索和 LLM 驱动分析**，提供智能且上下文感知的代码审查。就像拥有一位掌握仓库全局上下文的高级开发者，自动审查每个 PR！

👉 [立即安装 LlamaPReview](https://github.com/marketplace/llamapreview/)（免费）

通过结合 llama-github 进行上下文检索和 LlamaPReview 进行代码审查，您可以创建强大的 AI 增强开发环境。

## 远景与路线图

### 远景

我们的愿景是成为未来 AI 驱动开发解决方案的关键模块，完美集成 GitHub，赋能 LLM 自动解决复杂编码任务。

![远景架构](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/./docs/vision.drawio.svg)

### 路线图

欲了解项目路线图详情，请访问我们的[项目路线图](https://github.com/users/JetXu-LLM/projects/2)。

## 致谢

我们衷心感谢以下开源项目的支持与贡献：

- **[LangChain](https://github.com/langchain-ai/langchain)**：为 llama-github 提供了基础框架，赋能 LLM 提示和处理能力。
- **[Jina.ai](https://github.com/jina-ai/reader)**：提供 s.jina.ai API 以及开源的重新排序器和嵌入模型，提升了 llama-github 生成上下文的准确性和相关性。

他们的贡献对 llama-github 的开发至关重要，我们强烈推荐关注他们的项目以获取更多创新解决方案。

## 贡献

欢迎为 llama-github 贡献代码！更多信息请参阅我们的[贡献指南](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/CONTRIBUTING.md)。

## 许可证

本项目采用 Apache 2.0 许可证。详情请参阅[LICENSE](LICENSE)文件。

## 联系方式

如有任何问题、建议或反馈，欢迎通过[Jet Xu 的邮箱](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/mailto:Voldemort.xu@foxmail.com)联系我们。

---

感谢您选择 llama-github！我们希望此库能提升您的 AI 开发体验，助您轻松构建强大应用。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-28

---