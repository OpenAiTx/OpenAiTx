<div align="right">
  <details>
    <summary >🌐 语言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# llama-github

[详细文档] https://deepwiki.com/JetXu-LLM/llama-github

[![PyPI version](https://badge.fury.io/py/llama-github.svg)](https://badge.fury.io/py/llama-github)
[![下载量](https://static.pepy.tech/badge/Llama-github)](https://pepy.tech/project/Llama-github)
[![许可证](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)

Llama-github 是一款强大的工具，能够帮助你基于智能体 RAG 检索与查询最相关的 GitHub 代码片段、问题与仓库信息，并将其转化为有价值的知识上下文。它赋能 LLM 聊天机器人、AI 智能体与自动开发智能体，解决复杂的编码任务。无论你是寻求快速解决方案的开发者，还是实现高级自动开发 AI 智能体的工程师，llama-github 都让流程变得简单高效。

如果你喜欢这个项目或认为它有潜力，请给它一个⭐️。你的支持是我们最大的动力！

## 架构
![高级架构](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/./docs/high_level_architecture.drawio.svg)

## 安装

```
pip install llama-github
```

当前维护的运行时目标：Python `3.10+`。

## 用法

以下是如何使用 llama-github 的简单示例：

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
contexts = github_rag.retrieve_context(
    query,
    # simple_mode = True
)

print(contexts[0]["url"])
print(contexts[0]["context"])
```

`retrieve_context()` 返回一个上下文字典列表。每个项至少包含 `context` 和 `url`。

如需更高级的用法和示例，请参阅[文档](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/docs/usage.md)。可运行的低成本示例也可在 [`examples/`](examples) 找到。

## 主要特性

- **🔍 智能 GitHub 检索**：利用 llama-github 的强大功能，根据用户查询从 GitHub 检索高度相关的代码片段、问题和仓库信息。我们先进的检索技术确保您能够快速高效地找到最相关的信息。

- **⚡ 仓库池缓存**：Llama-github 拥有创新的仓库池缓存机制。通过在线程间缓存仓库（包括 README、结构、代码和问题），llama-github 大幅提升 GitHub 搜索检索效率，并最大程度减少 GitHub API 令牌的消耗。

- **🧠 LLM 驱动的问题分析**：利用最先进的语言模型分析用户问题，并生成高效的搜索策略和条件。llama-github 智能分解复杂查询，确保您从 GitHub 的庞大仓库网络中检索到最相关的信息。

- **📚 全面上下文生成**：通过将从 GitHub 检索到的信息与先进语言模型的推理能力无缝结合，生成丰富且高度相关的答案。llama-github 擅长处理最复杂和冗长的问题，提供详尽且有洞察力的答复，并为您的开发需求提供丰富的上下文支持。

- **🚀 卓越的异步处理**：Llama-github 从头开始充分发挥异步编程的全部潜力。异步机制精心贯穿整个代码库，llama-github 能够并发处理多个请求，大幅提升整体性能。

- **🔧 灵活的 LLM 集成**：可轻松将 llama-github 集成到各种 LLM 提供商、嵌入模型、重排序模型，或注入兼容 LangChain 的聊天模型，以满足您特定需求。

- **🔒 强大的认证选项**：Llama-github 支持个人访问令牌和 GitHub App 认证，为您集成到不同开发环境提供灵活性。无论您是个人开发者还是组织环境使用，llama-github 都为您提供安全可靠的认证机制。

- **🛠️ 日志记录和错误处理**：我们深知流畅操作和便捷排错的重要性。因此 llama-github 配备了完善的日志和错误处理机制。深入洞察库的行为，快速诊断问题，维护稳定可靠的开发流程。

## 🤖 试用我们的 AI 驱动 PR 评审助手：LlamaPReview

如果您觉得 llama-github 有用，您可能也会对我们的 AI 驱动 GitHub PR 评审助手 LlamaPReview 感兴趣。它旨在完善您的开发流程，进一步提升代码质量。

### LlamaPReview 主要特性：
- 🚀 一键安装，无需配置，完全自动运行
- 💯 目前免费使用 - 无需信用卡或支付信息
- 🧠 AI 驱动，自动 PR 评审，深度理解代码
- 🌐 支持多种编程语言

**LlamaPReview 利用 llama-github 的高级上下文检索与 LLM 驱动分析**，提供智能、具备上下文感知的代码评审。就像有一位资深开发者，带着仓库的全部上下文，为每个 PR 自动审查！

👉 [立即安装 LlamaPReview](https://github.com/marketplace/llamapreview/)（免费）

通过使用 llama-github 进行上下文检索、LlamaPReview 进行代码评审，您可以打造一个强大的 AI 增强开发环境。

## 愿景与路线图

### 愿景

我们的愿景是成为未来以 AI 为驱动的开发解决方案中的关键模块，能够无缝集成到 GitHub，赋能大语言模型自动解决复杂的编码任务。

![愿景架构](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/./docs/vision.drawio.svg)

### 路线图

如需了解早期路线图的历史视角，请访问 [愿景与路线图](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/VISION_AND_ROADMAP.md)。

## 致谢

我们要感谢以下开源项目对我们的支持和贡献：

- **[LangChain](https://github.com/langchain-ai/langchain)**：为 llama-github 提供了基础框架，赋能大语言模型的提示和处理能力。
- **[Jina.ai](https://github.com/jina-ai/reader)**：为 llama-github 提供了 s.jina.ai API 以及开源的重排序和嵌入模型，提升了生成上下文的准确性与相关性。

他们的贡献对于 llama-github 的开发至关重要，我们强烈建议您关注他们的项目，探索更多创新解决方案。

## 贡献

欢迎大家为 llama-github 做出贡献！请参阅我们的 [贡献指南](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/CONTRIBUTING.md) 了解更多信息。

## 许可证

本项目遵循 Apache 2.0 许可证条款。如需详细信息，请参见 [LICENSE](LICENSE) 文件。

## 联系方式

如有任何问题、建议或反馈，欢迎通过 [Jet Xu 的邮箱](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/mailto:Voldemort.xu@foxmail.com) 与我们联系。

---

感谢您选择 llama-github！我们希望该库能提升您的 AI 开发体验，助您轻松构建强大的应用程序。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-26

---