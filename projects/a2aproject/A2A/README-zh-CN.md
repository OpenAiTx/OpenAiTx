# Agent2Agent (A2A) 协议

[![PyPI - 版本](https://img.shields.io/pypi/v/a2a-sdk)](https://pypi.org/project/a2a-sdk)
[![Apache 许可证](https://img.shields.io/badge/License-Apache_2.0-blue.svg)](LICENSE)
<a href="https://codewiki.google/github.com/a2aproject/a2a">
  <img src="https://www.gstatic.com/_/boq-sdlc-agents-ui/_/r/Mvosg4klCA4.svg" alt="询问代码百科" height="20">
</a>

<!-- markdownlint-disable MD041 -->
<div style="text-align: center;">
  <div class="centered-logo-text-group">
    <img src="https://raw.githubusercontent.com/a2aproject/A2A/main/docs/assets/a2a-logo-black.svg" alt="Agent2Agent 协议标志" width="100">
    <h1>Agent2Agent (A2A) 协议</h1>
  </div>
</div>

**一个开放协议，实现不透明智能代理应用之间的通信与互操作。**

Agent2Agent (A2A) 协议解决了 AI 领域的一个关键挑战：使由不同公司基于多样框架构建、运行于独立服务器上的生成式 AI 代理能够有效沟通与协作——作为代理，而不仅仅是工具。A2A 致力于为代理提供通用语言，促进更加互联、高效且创新的 AI 生态系统。

通过 A2A，代理可以：

- 发现彼此的能力。
- 协商交互方式（文本、表单、多媒体）。
- 安全协作完成长期任务。
- 在不暴露内部状态、记忆或工具的情况下操作。

## A2A 入门视频

[![A2A 入门视频](https://img.youtube.com/vi/Fbr_Solax1w/hqdefault.jpg)](https://goo.gle/a2a-video)

## 为什么选择 A2A？

随着 AI 代理的普及，它们的互操作能力对于构建复杂、多功能应用至关重要。A2A 的目标是：

- **打破孤岛：** 连接不同生态系统中的代理。
- **实现复杂协作：** 允许专业代理协作完成单一代理无法独立处理的任务。
- **推动开放标准：** 培育社区驱动的代理通信方式，鼓励创新和广泛采用。
- **保持不透明性：** 允许代理协作而无需共享内部记忆、专有逻辑或特定工具实现，增强安全性并保护知识产权。

### 主要特性

- **标准化通信：** 通过 HTTP(S) 的 JSON-RPC 2.0。
- **代理发现：** 通过详细说明能力和连接信息的“代理卡”实现。
- **灵活交互：** 支持同步请求/响应、流式（SSE）和异步推送通知。
- **丰富数据交换：** 处理文本、文件和结构化 JSON 数据。
- **企业级准备：** 设计时考虑了安全性、认证和可观测性。

## 快速开始

- 📚 **浏览文档：** 访问 [Agent2Agent 协议文档网站](https://a2a-protocol.org) 获取完整概览、完整协议规范、教程和指南。
- 📝 **查看规范：** [A2A 协议规范](https://a2a-protocol.org/latest/specification/)
- 使用 SDK：
    - [🐍 A2A Python SDK](https://github.com/a2aproject/a2a-python) `pip install a2a-sdk`
    - [🐿️ A2A Go SDK](https://github.com/a2aproject/a2a-go) `go get github.com/a2aproject/a2a-go`
    - [🧑‍💻 A2A JS SDK](https://github.com/a2aproject/a2a-js) `npm install @a2a-js/sdk`
    - [☕️ A2A Java SDK](https://github.com/a2aproject/a2a-java) 使用 maven
    - [🔷 A2A .NET SDK](https://github.com/a2aproject/a2a-dotnet) 使用 [NuGet](https://www.nuget.org/packages/A2A) `dotnet add package A2A`
- 🎬 使用我们的 [示例](https://github.com/a2aproject/a2a-samples) 观看 A2A 实际应用

## 贡献

欢迎社区贡献，共同提升和发展 A2A 协议！

- **提问与讨论：** 加入我们的 [GitHub 讨论区](https://github.com/a2aproject/A2A/discussions)。
- **问题与反馈：** 通过 [GitHub 问题](https://github.com/a2aproject/A2A/issues) 报告问题或提出改进建议。
- **贡献指南：** 参见我们的 [CONTRIBUTING.md](https://raw.githubusercontent.com/a2aproject/A2A/main/CONTRIBUTING.md) 获取贡献详情。
- **私密反馈：** 使用此 [Google 表单](https://goo.gle/a2a-feedback)。
- **合作伙伴计划：** Google Cloud 用户可通过此 [表单](https://goo.gle/a2a-partner) 加入合作伙伴计划。

## 接下来

### 协议增强

- **代理发现：**
    - 规范在 `AgentCard` 中直接包含授权方案和可选凭据。
- **代理协作：**
    - 探索 `QuerySkill()` 方法以动态检测不支持或意料之外的技能。
- **任务生命周期与用户体验：**
    - 支持任务内动态用户体验协商（例如，代理在对话中途添加音频/视频）。
- **客户端方法与传输：**
    - 探讨扩展对客户端发起方法的支持（超出任务管理范围）。
    - 改进流媒体的可靠性和推送通知机制。

## 关于

A2A协议是一个由Linux基金会托管的开源项目，由Google贡献。它采用[Apache许可证2.0](LICENSE)，欢迎社区贡献。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-24

---