# Tome - 魔法 AI 魔法书

<img src="https://raw.githubusercontent.com/runebookai/tome/main/static/images/repo-header.png" alt="Tome" />

<p align="center">
    <code>一个神奇的桌面应用，让每个人都能掌控 LLM 和 MCP 的力量</code>
</p>

<p align="center">
    <a href="https://discord.gg/9CH6us29YA" target="_blank"><img src="https://img.shields.io/discord/1365100902561742868?logo=discord&logoColor=fff&label=Join%20Us!&color=9D7CD8" alt="Join Us on Discord" /></a>
    <a href="https://opensource.org/licenses/Apache-2.0" target="_blank"><img src="https://img.shields.io/badge/License-Apache_2.0-blue.svg" alt="License: Apache 2.0" /></a>
    <a href="https://github.com/runebookai/tome/releases" target="_blank"><img src="https://img.shields.io/github/v/release/runebookai/tome" alt="GitHub Release" /></a>
</p>

<p align="center">
    🔮 下载 Tome 桌面应用: <a href="https://github.com/runebookai/tome/releases/download/0.6.0/Tome_0.6.0_x64-setup.exe">Windows</a> | <a href="https://github.com/runebookai/tome/releases/download/0.6.0/Tome_0.6.0_aarch64.dmg">MacOS</a>
</p>

# Tome

Tome 是一个桌面应用，让**任何人**都能驾驭 LLM 和 MCP 的魔法。下载 Tome，连接任意本地或远程 LLM，并将其挂接到数千个 MCP 服务器，打造你自己的魔法 AI 魔法书。

🫥 想要 100% 本地、100% 私密？只用本地 MCP 服务器配合 Ollama 和 Qwen3，在你的私有宇宙中施展魔法。⚡ 想要最新的云端模型和最新的远程 MCP 服务器？你也可以做到。这一切都由你决定！

🏗️ 这是技术预览版，所以请注意，部分功能可能还不够完善。[加入我们的 Discord](https://discord.gg/9CH6us29YA) 分享你的经验、技巧和遇到的问题。给本仓库加星，获取最新更新和功能发布！

## 🪄 功能特性

- 🧙 **简洁新手友好体验**
  - 只需下载并安装 Tome，然后连接你喜欢的 LLM
  - 无需折腾 JSON、Docker、python 或 node
- 🤖 **AI 模型支持**
  - **远程**：Google Gemini、OpenAI、任何兼容 OpenAI API 的端点
  - **本地**：Ollama、LM Studio、Cortex、任何兼容 OpenAI API 的端点
- 🔮 **增强的 MCP 支持**
  - 图形界面安装、移除、开启/关闭 MCP 服务器
  - 原生支持 npm、uvx、node、python MCP 服务器
- 🏪 **集成到 [Smithery.ai](https://smithery.ai) 注册表**
  - 数千个 MCP 服务器一键安装
- ✏️ **上下文窗口和温度可自定义**
- 🧰 **原生支持工具调用和推理模型**
  - 界面增强，清晰区分工具调用和思考消息

## 演示

https://github.com/user-attachments/assets/0775d100-3eba-4219-9e2f-360a01f28cce

# 入门指南

## 系统要求

- MacOS 或 Windows（Linux 即将支持！）
- 你选择的 LLM 提供商：[Ollama](https://ollama.com/) 或 [Gemini API 密钥](https://aistudio.google.com/app/apikey) 简单/免费
- [下载 Tome 的最新版本](https://github.com/runebookai/tome/releases)

## 快速开始

1. 安装 [Tome](https://github.com/runebookai/tome/releases)
2. 连接你喜欢的 LLM 提供商 —— OpenAI、Ollama 和 Gemini 已预设，但你也可以通过使用 http://localhost:1234/v1 作为 URL 添加如 LM Studio 等其他提供商
3. 在 Tome 中打开 MCP 选项卡，安装你的第一个 [MCP 服务器](https://github.com/modelcontextprotocol/servers)（Fetch 是个简单的入门选择，只需将 `uvx mcp-server-fetch` 粘贴到服务器字段即可）。
4. 与你的 MCP 驱动模型聊天！让它帮你获取 Hacker News 上的头条新闻。

# 愿景

我们希望让本地 LLM 和 MCP 对每个人都易于访问。我们正在打造一个工具，无论你是工程师、极客、爱好者还是其他任何人，都能用 LLM 发挥创意。

## 核心原则

- **Tome 首先本地化：** 你掌控你的数据流向。
- **Tome 面向所有人：** 你无需管理编程语言、包管理器或 json 配置文件。

## 未来规划

自从发布 Tome 以来，我们收获了大量宝贵反馈，但我们对未来还有宏伟计划。我们希望将 LLM 从聊天框中解放出来，并为大家带来更多新功能。

- 定时任务：即使你不在电脑前，LLM 也能帮你做有用的事情。
- 原生集成：MCP 服务器是访问工具和信息的绝佳途径，但我们还想添加更强大的集成，以独特方式与 LLM 互动。
- 应用构建器：我们相信，从长远来看，最佳体验不会局限在聊天界面。我们计划添加更多工具，助你创建强大的应用和工作流。
- ??? 告诉我们你希望看到什么！通过下方链接加入我们的社区，我们期待你的声音。

# 社区

[Discord](https://discord.gg/9CH6us29YA) [博客](https://blog.runebook.ai) [Bluesky](https://bsky.app/profile/gettome.app) [Twitter](https://twitter.com/get_tome) 


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-03

---