# Agent2Agent (A2A) 示例

<a href="https://studio.firebase.google.com/new?template=https%3A%2F%2Fgithub.com%2Fa2aproject%2Fa2a-samples%2Ftree%2Fmain%2F.firebase-studio">
  <picture>
    <source
      media="(prefers-color-scheme: dark)"
      srcset="https://cdn.firebasestudio.dev/btn/try_light_20.svg">
    <source
      media="(prefers-color-scheme: light)"
      srcset="https://cdn.firebasestudio.dev/btn/try_dark_20.svg">
    <img
      height="20"
      alt="在 Firebase Studio 中试用"
      src="https://cdn.firebasestudio.dev/btn/try_blue_20.svg">
  </picture>
</a>

<div style="text-align: right;">
  <details>
    <summary>🌐 语言</summary>
    <div style="text-align: center;">
      <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=en">English</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=zh-CN">简体中文</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=zh-TW">繁體中文</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ja">日本語</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ko">한국어</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=hi">हिन्दी</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=th">ไทย</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=fr">Français</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=de">Deutsch</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=es">Español</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=it">Italiano</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ru">Русский</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=pt">Português</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=nl">Nederlands</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=pl">Polski</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ar">العربية</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=fa">فارسی</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=tr">Türkçe</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=vi">Tiếng Việt</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=zh">简体中文</a>
    </div>
  </details>
</div>

欢迎来到 [Agent2Agent (A2A) 协议](https://goo.gle/a2a) 的官方代码示例和演示页面。

我们非常高兴您来到这里！无论您是首次探索多智能体架构，还是构建高级互操作智能体网络，本仓库都为您提供了简单、富有启发性且易于访问的学习资源，以加速您的开发进程。

## 为什么选择 Agent2Agent？

在多样化的 AI 框架和生态系统中，智能体需要一种通用语言来进行安全的通信、协作和任务委派。A2A 协议为多智能体互操作性建立了标准化的开放标准。

我们的示例演示了如何在不同语言和主机应用之间轻松解决复杂的多智能体问题。

## 快速开始

立即启动 Helloworld 智能体并通过我们的 Python CLI 主机与其通信，快速上手。

1. **启动智能体服务器**：
   打开终端并启动 Helloworld 智能体服务器：

   ```bash
   cd samples/python/agents/helloworld
   uv run .
   ```

2. **运行主机客户端**：
   打开第二个终端并运行 CLI 客户端，将任务发送到代理：

   ```bash
   cd samples/python/agents/helloworld
   uv run test_client.py
   ```

## 仓库结构

本仓库按语言分为多个主要目录：

| 目录 | 描述 |
| --- | --- |
| [samples](/samples) | 按编程语言组织的核心 A2A 示例。 |
| [samples/python](/samples/python) | 展示使用 A2A Python SDK 的 Python 代理实现。 |
| [samples/go](/samples/go) | 展示使用 A2A Go SDK 的 Go 代理实现。 |
| [samples/dotnet](/samples/dotnet) | 展示使用 A2A .NET SDK 的 C# 代理实现。 |
| [samples/java](/samples/java) | 展示使用 A2A Java SDK 的 Java 代理实现。 |
| [samples/js](/samples/js) | 展示使用 A2A JavaScript SDK 的 Node.js 代理实现。 |

## 贡献指南

我们欢迎并鼓励所有技能水平的贡献！如果您有新的示例、错误修复或文档改进的想法，请查阅我们的 [贡献指南](https://raw.githubusercontent.com/a2aproject/a2a-samples/main/CONTRIBUTING.md)。

## 获取帮助

我们致力于营造一个友好和支持性的社区。如果您有问题、反馈或遇到任何问题，请访问我们的 [问题页面](https://github.com/a2aproject/a2a-samples/issues) 联系我们。

## 相关仓库

| 仓库 | 类别 | 描述 |
| --- | --- | --- |
| [A2A](https://github.com/a2aproject/A2A) | 核心规范 | A2A 规范和文档。 |
| [a2a-inspector](https://github.com/a2aproject/a2a-inspector) | 工具 | 用于检查 A2A 使能代理的 UI 工具。 |
| [a2a-tck](https://github.com/a2aproject/a2a-tck) | 测试 | 用于验证 A2A 协议合规性的测试套件。 |
| [a2a-itk](https://github.com/a2aproject/a2a-itk) | 测试 | 使用多跳遍历模型和多样传输协议验证不同 A2A SDK 实现及版本兼容性的工具包。 |
| [a2a-python](https://github.com/a2aproject/a2a-python) | SDK（Python） | 官方 A2A Python SDK。 |
| [a2a-go](https://github.com/a2aproject/a2a-go) | SDK（Go） | 官方 A2A Go SDK。 |
| [a2a-java](https://github.com/a2aproject/a2a-java) | SDK（Java） | 官方 A2A Java SDK。 |
| [a2a-js](https://github.com/a2aproject/a2a-js) | SDK（JavaScript） | 官方 A2A Node.js/JavaScript SDK。 |
| [a2a-dotnet](https://github.com/a2aproject/a2a-dotnet) | SDK（C#/.NET） | 官方 A2A C#/.NET SDK。 |
| [a2a-rs](https://github.com/a2aproject/a2a-rs) | SDK（Rust） | 官方 A2A Rust SDK。 |

## 免责声明

**重要提示：** 提供的示例代码仅用于演示用途，并说明了该
代理到代理（A2A）协议。在构建生产应用程序时，必须将任何在您直接控制之外运行的代理视为潜在的不受信任实体。

从外部代理接收到的所有数据——包括但不限于其 AgentCard、消息、工件和任务状态——都应作为不受信任的输入进行处理。例如，恶意代理可能会在其 AgentCard 的字段中（如描述、名称、skills.description）提供精心构造的数据。如果这些数据未经净化就被用于构建大型语言模型（LLM）的提示，可能会使您的应用程序暴露于提示注入攻击之下。未能在使用前正确验证和清理这些数据，可能会为您的应用程序带来安全漏洞。

> 开发人员有责任实施适当的安全措施，例如输入验证和凭据的安全处理，以保护其系统和用户。










---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-21

---