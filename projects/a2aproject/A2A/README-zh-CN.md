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
    <img src="https://raw.githubusercontent.com/a2aproject/A2A/main/docs/assets/a2a-logo-black.svg" alt="Agent2Agent 协议标志" width="100">
    <h1>Agent2Agent (A2A) 协议</h1>
  </div>
</div>

**一个开放协议，实现不透明智能体应用间的通信与互操作性。**

Agent2Agent (A2A) 协议解决了AI领域中的一个关键难题：让由不同公司基于多样化框架、运行在不同服务器上的生成式AI智能体能够有效地通信与协作——以“智能体”的身份，而不仅仅是工具。A2A旨在为智能体提供一种通用语言，推动更加互联、高效和创新的AI生态系统。

通过A2A，智能体可以：

- 发现彼此的能力。
- 协商交互方式（文本、表单、多媒体）。
- 在安全环境下协作处理长期任务。
- 在不暴露内部状态、记忆或工具的前提下运行。

## A2A简介视频

[![A2A简介视频](https://img.youtube.com/vi/Fbr_Solax1w/hqdefault.jpg)](https://goo.gle/a2a-video)

## 为什么选择A2A？

随着AI智能体日益普及，它们的互操作能力对于构建复杂、多功能应用至关重要。A2A的目标是：

- **打破壁垒：** 连接不同生态系统中的智能体。
- **实现复杂协作：** 让专用智能体协作完成单一智能体无法独立处理的任务。
- **推动开放标准：** 促进社区驱动的智能体通信标准，鼓励创新与广泛应用。
- **保持不透明性：** 智能体可在无需共享内部记忆、专有逻辑或特定工具实现的前提下协作，提升安全性并保护知识产权。

### 主要特性

- **标准化通信：** 基于HTTP(S)的JSON-RPC 2.0。
- **智能体发现：** 通过“Agent Cards”描述能力和连接信息。
- **灵活交互方式：** 支持同步请求/响应、流式（SSE）及异步推送通知。
- **丰富数据交换：** 支持文本、文件及结构化JSON数据。
- **企业级准备：** 设计注重安全、认证与可观测性。

## 快速开始
- 📚 **浏览文档：** 访问 [Agent2Agent 协议文档站点](https://a2a-protocol.org)，获取完整概览、协议规范、教程和指南。
- 📝 **查看规范：** [A2A 协议规范](https://a2a-protocol.org/latest/specification/)
- 使用 SDK：
    - [🐍 A2A Python SDK](https://github.com/a2aproject/a2a-python) `pip install a2a-sdk`
    - [🐿️ A2A Go SDK](https://github.com/a2aproject/a2a-go) `go get github.com/a2aproject/a2a-go`
    - [🧑‍💻 A2A JS SDK](https://github.com/a2aproject/a2a-js) `npm install @a2a-js/sdk`
    - [☕️ A2A Java SDK](https://github.com/a2aproject/a2a-java) 使用 maven
    - [🔷 A2A .NET SDK](https://github.com/a2aproject/a2a-dotnet) 使用 [NuGet](https://www.nuget.org/packages/A2A) `dotnet add package A2A`
- 🎬 使用我们的 [示例](https://github.com/a2aproject/a2a-samples) 了解 A2A 的实际应用

## 贡献指南

我们欢迎社区的贡献，共同完善和发展 A2A 协议！

- **问题与讨论：** 加入我们的 [GitHub Discussions](https://github.com/a2aproject/A2A/discussions)。
- **问题与反馈：** 通过 [GitHub Issues](https://github.com/a2aproject/A2A/issues) 报告问题或提出建议。
- **贡献指南：** 参见我们的 [CONTRIBUTING.md](https://raw.githubusercontent.com/a2aproject/A2A/main/CONTRIBUTING.md) 获取详细贡献流程。
- **私密反馈：** 使用此 [Google 表单](https://goo.gle/a2a-feedback)。
- **合作伙伴计划：** Google Cloud 客户可通过此 [表单](https://goo.gle/a2a-partner) 加入我们的合作伙伴计划。

## 接下来

### 协议增强

- **Agent 发现：**
    - 在 `AgentCard` 中正式加入授权方案和可选凭证。
- **Agent 协作：**
    - 探索 `QuerySkill()` 方法，以动态检测不支持或未预期的技能。
- **任务生命周期与用户体验：**
    - 支持任务内动态用户体验协商（例如，agent 在对话中途添加音频/视频）。
- **客户端方法与传输：**
    - 探索扩展对客户端发起方法（不限于任务管理）的支持。
    - 改进流式传输可靠性和推送通知机制。

## 关于

A2A 协议是由 Google 贡献并在 Linux 基金会下的开源项目，遵循 [Apache License 2.0](LICENSE) 许可，欢迎社区成员参与贡献。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-30

---