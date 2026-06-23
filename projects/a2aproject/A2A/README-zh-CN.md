# Agent2Agent (A2A) 协议

[![PyPI - Version](https://img.shields.io/pypi/v/a2a-sdk)](https://pypi.org/project/a2a-sdk)
[![Apache License](https://img.shields.io/badge/License-Apache_2.0-blue.svg)](LICENSE)
<a href="https://codewiki.google/github.com/a2aproject/a2a">
  <img src="https://www.gstatic.com/_/boq-sdlc-agents-ui/_/r/Mvosg4klCA4.svg" alt="问代码百科" height="20">
</a>

<div style="text-align: left;">
  <details>
    <summary>🌐 语言</summary>
    <div>
      <div style="text-align: center;">
        <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=as">অসমীয়া</a>
      </div>
    </div>
  </details>
</div>

<!-- markdownlint-disable MD041 -->
<div style="text-align: center;">
  <div class="centered-logo-text-group">
    <img src="https://raw.githubusercontent.com/a2aproject/A2A/main/docs/assets/a2a_logo/color/SVG/a2a_color.svg" alt="Agent2Agent 协议标志" width="100">
    <h1>Agent2Agent (A2A) 协议</h1>
  </div>
</div>

**一个开放协议，实现不透明代理应用之间的通信与互操作性。**

Agent2Agent (A2A) 协议解决了 AI 领域的一个关键难题：使基于不同框架、由不同公司开发并运行在独立服务器上的生成式 AI 代理能够有效通信与协作——作为代理而非仅仅是工具。A2A 旨在为代理提供一种通用语言，促进更加互联、强大和创新的 AI 生态系统。

通过 A2A，代理可以：

- 发现彼此的能力。
- 协商交互方式（文本、表单、媒体）。
- 在长期任务中安全协作。
- 在不暴露其内部状态、记忆或工具的情况下运行。

## DeepLearning.AI 课程

[![A2A DeepLearning.AI](https://img.youtube.com/vi/4gYm0Rp7VHc/maxresdefault.jpg)](https://goo.gle/dlai-a2a)

参加这个由 [Holt Skinner](https://github.com/holtskinner)、[Ivan Nardini](https://github.com/inardini) 和 [Sandi Besen](https://github.com/sandijean90) 授课、与 Google Cloud 和 IBM Research 合作推出的 [A2A: The Agent2Agent Protocol](https://goo.gle/dlai-a2a) 短课程。

**你将学到：**

- **让代理兼容 A2A:** 将用 Google ADK、LangGraph 或 BeeAI 等框架构建的代理暴露为 A2A 服务器。
- **连接代理:** 从零开始或使用集成创建 A2A 客户端，连接到兼容 A2A 的代理。
- **编排工作流:** 构建兼容 A2A 代理的顺序和层级工作流。
- **多代理系统:** 使用不同框架构建医疗多代理系统，了解 A2A 如何实现协作。
- **A2A 与 MCP:** 学习 A2A 如何通过实现代理间协作来补充 MCP。

## 为什么选择 A2A？

随着 AI 代理的普及，它们的互操作性对于构建复杂的多功能应用至关重要。A2A 旨在：

- **打破孤岛:** 连接不同生态系统中的代理。
- **实现复杂协作:** 让专用代理协作完成单一代理无法独立完成的任务。
- **推动开放标准:** 倡导社区驱动的代理通信方式，促进创新和广泛采用。
- **保持不透明性:** 允许代理在不共享内部记忆、专有逻辑或特定工具实现的情况下协作，增强安全性并保护知识产权。

### 主要功能

- **标准化通信：** 使用 JSON-RPC 2.0 通过 HTTP(S)。
- **代理发现：** 通过“代理卡”提供能力和连接信息。
- **灵活交互：** 支持同步请求/响应、流式（SSE）和异步推送通知。
- **丰富数据交换：** 支持文本、文件和结构化 JSON 数据。
- **企业级准备：** 设计时考虑安全性、认证和可观测性。

## 入门指南

- 📚 **查阅文档：** 访问 [Agent2Agent 协议文档站点](https://a2a-protocol.org) 获取完整概览、协议规范、教程和指南。
- 📝 **查看规范：** [A2A 协议规范](https://a2a-protocol.org/latest/specification/)
- 使用 SDK：
    - [🐍 A2A Python SDK](https://github.com/a2aproject/a2a-python) `pip install a2a-sdk`
    - [🐿️ A2A Go SDK](https://github.com/a2aproject/a2a-go) `go get github.com/a2aproject/a2a-go`
    - [🧑‍💻 A2A JS SDK](https://github.com/a2aproject/a2a-js) `npm install @a2a-js/sdk`
    - [☕️ A2A Java SDK](https://github.com/a2aproject/a2a-java) 使用 maven
    - [🔷 A2A .NET SDK](https://github.com/a2aproject/a2a-dotnet) 使用 [NuGet](https://www.nuget.org/packages/A2A) `dotnet add package A2A`
    - [🦀 A2A Rust SDK](https://github.com/a2aproject/a2a-rs) `cargo add a2a-lf`
- 🎬 使用我们的 [示例](https://github.com/a2aproject/a2a-samples) 查看 A2A 实际应用

## 贡献

我们欢迎社区贡献来增强和发展 A2A 协议！

- **问题与讨论：** 加入我们的 [GitHub Discussions](https://github.com/a2aproject/A2A/discussions)。
- **问题与反馈：** 通过 [GitHub Issues](https://github.com/a2aproject/A2A/issues) 报告问题或提出建议。
- **贡献指南：** 查看我们的 [CONTRIBUTING.md](https://raw.githubusercontent.com/a2aproject/A2A/main/CONTRIBUTING.md) 了解贡献细节。
- **私密反馈：** 使用此 [Google 表单](https://goo.gle/a2a-feedback)。
- **合作伙伴计划：** Google Cloud 客户可通过此 [表单](https://goo.gle/a2a-partner)加入合作伙伴计划。

## 后续计划

### 协议增强

- **代理发现：**
    - 正式将授权方案和可选凭证直接包含在 `AgentCard` 中。
- **代理协作：**
    - 探索 `QuerySkill()` 方法以动态检查不支持或未预料的技能。
- **任务生命周期与用户体验：**
    - 支持任务内部的动态用户体验协商（例如，代理在对话中途添加音频/视频）。
- **客户端方法与传输：**
    - 探索扩展对客户端发起方法的支持（不仅限于任务管理）。
    - 改进流式传输的可靠性和推送通知机制。

## 关于

A2A 协议是一个在 Linux 基金会旗下的开源项目，由 Google 贡献。它遵循 [Apache License 2.0](LICENSE) 许可，并对社区贡献开放。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-23

---