<div align="right">
  <details>
    <summary >🌐 语言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

<div align="center">
  <a href="https://core.heysol.ai">
    <img src="https://github.com/user-attachments/assets/89066cdd-204b-46c2-8ad4-4935f5ca9edd" width="200px" alt="CORE 标志" />
  </a>

### CORE：AI应用的个人记忆层

<p align="center">
    <a href="https://deepwiki.com/RedPlanetHQ/core">
        <img src="https://deepwiki.com/badge.svg" alt="DeepWiki 徽章" />
    </a>
</p>
<p align="center">
    <a href="https://docs.heysol.ai/introduction"><b>文档</b></a> •
    <a href="https://discord.gg/YGUZcvDjUa"><b>Discord 社区</b></a>
</p>
</div>

## 🔥 研究亮点

CORE memory 在 Locomo 数据集所有推理任务中实现了 **88.24%** 的平均准确率，显著优于其他记忆提供者。请参阅这篇[博客](https://blog.heysol.ai/core-build-memory-knowledge-graph-for-individuals-and-achieved-sota-on-locomo-benchmark/)获取更多信息。

<img width="6048" height="3428" alt="benchmark" src="https://github.com/user-attachments/assets/2e5fdac5-02ed-4d00-9312-c21d09974e1f" />
(1) 单跳问题只需基于一次会话回答；(2) 多跳问题需整合来自多个不同会话的信息；(3) 开放域知识问题可通过整合说话者提供的信息与外部知识（如常识或世界事实）回答；(4) 时序推理问题可通过时序推理和捕捉对话中的时间相关数据线索进行回答；

## 概述

**问题**

开发者需要反复向 AI 工具解释上下文，浪费时间。Claude 令牌数达到上限？重新开始，所有内容都丢失。ChatGPT/Claude 切换到 Cursor？又要重新解释上下文。你的对话、决策和洞见在不同会话间消失。每用一个新 AI 工具，上下文切换的成本就增加。

**解决方案** - **CORE**（**上下文观察与回忆引擎**）

CORE 是一个面向所有 AI 工具的开源统一持久记忆层。你的上下文会在 Cursor、Claude、ChatGPT、Claude Code 之间跟随你。一个知识图谱记住了是谁、何时、为何说了什么。只需连接一次，随处记忆。不再需要管理上下文，专注于创造。

## 🚀 CORE 自托管
想在自己的基础设施上运行 CORE？自托管可让你完全掌控数据和部署。

**先决条件**：

- 已安装 Docker（20.10.0+）和 Docker Compose（2.20.0+）
- OpenAI API 密钥

> **关于开源模型的说明：** 我们测试过 Ollama、GPT 等开源选项，但它们的事实提取和图谱质量不理想。我们正在积极寻找更好的方案。

### 安装步骤

1. 克隆此代码仓库：
```
git clone https://github.com/RedPlanetHQ/core.git
cd core
```
2. 在 `core/.env` 中配置环境变量：
```
OPENAI_API_KEY=your_openai_api_key
```
3. 启动服务
```
docker-compose up -d
```

部署完成后，您可以配置您的 AI 提供商（OpenAI、Anthropic），并开始构建您的记忆图谱。

👉 [查看完整自托管指南](https://docs.heysol.ai/self-hosting/docker)

注意：我们尝试过 Ollama 或 GPT OSS 等开源模型，但事实生成效果不佳，我们仍在探索改进的方法，之后也将支持 OSS 模型。

## 🚀 CORE 云端
**5 分钟内构建您的统一记忆图谱：**

不想管理基础设施？CORE 云端让您即时构建个人记忆系统——无需设置，无需服务器，只需可用的记忆。

1. **注册账号**，访问 [core.heysol.ai](https://core.heysol.ai) 创建您的账户
2. **可视化您的记忆图谱**，查看 CORE 如何自动为事实之间建立联系
3. **体验效果** ——在会话区输入“你对我了解什么？”
4. 连接您的工具：
   - [Claude](https://docs.heysol.ai/providers/claude) 和 [Cursor](https://docs.heysol.ai/providers/cursor) ——带有上下文的编程
   - [CLaude Code CLI](https://docs.heysol.ai/providers/claude-code) 和 [Codex CLI](https://docs.heysol.ai/providers/codex) ——基于终端的带记忆编程
   - [添加浏览器扩展](https://docs.heysol.ai/providers/browser-extension) ——让您的记忆延伸到任意网站
   - [Linear](https://docs.heysol.ai/integrations/linear)、[Github](https://docs.heysol.ai/integrations/github) ——自动添加项目上下文

## 🧩 主要功能

### 🧠 **统一、可移植的记忆**：
通过 MCP 在 **Cursor、Windsurf、Claude Desktop、Claude Code、Gemini CLI、AWS 的 Kiro、VS Code 和 Roo Code** 中添加和回忆您的记忆

![core-claude](https://github.com/user-attachments/assets/56c98288-ee87-4cd0-8b02-860aca1c7f9a)


### 🕸️ **时序 + 具体化知识图谱**：

记住每个事实背后的故事——通过丰富的关系和完整的溯源，跟踪谁、何时、为何说了什么，而不仅仅是扁平存储

![core-memory-graph](https://github.com/user-attachments/assets/5d1ee659-d519-4624-85d1-e0497cbdd60a)


### 🌐 **浏览器扩展**：

将 ChatGPT、Grok、Gemini、Twitter、YouTube、博客文章及任意网页上的对话和内容直接保存到您的 CORE 记忆中。

**如何使用扩展程序**
1. 从 [Chrome 网上应用店](https://chromewebstore.google.com/detail/core-extension/cglndoindnhdbfcbijikibfjoholdjcc) 下载扩展程序。
2. 登录 [CORE 仪表盘](https://core.heysol.ai)
   - 导航到设置（左下角）
   - 前往 API Key → 生成新密钥 → 命名为“extension”。
3. 打开扩展程序，粘贴您的 API 密钥并保存。

https://github.com/user-attachments/assets/6e629834-1b9d-4fe6-ae58-a9068986036a


### 💬 **带记忆聊天**：
提出诸如“我的写作偏好是什么？”等问题，实时获取来自您已连接知识的洞察

![chat-with-memory](https://github.com/user-attachments/assets/d798802f-bd51-4daf-b2b5-46de7d206f66)


### ⚡ **应用自动同步**：

自动从 Linear、Slack、Notion、GitHub 及其他已连接应用捕捉相关上下文至您的 CORE 记忆

📖 **[查看所有集成](https://raw.githubusercontent.com/RedPlanetHQ/core/main/./integrations/README.md)** - 支持服务及其功能的完整列表

![core-slack](https://github.com/user-attachments/assets/d5fefe38-221e-4076-8a44-8ed673960f03)


### 🔗 **MCP 集成中心**：

仅需一次，将 Linear、Slack、GitHub、Notion 连接至 CORE——然后可在 Claude、Cursor 或任何 MCP 客户端通过单一 URL 使用全部工具


![core-linear-claude](https://github.com/user-attachments/assets/7d59d92b-8c56-4745-a7ab-9a3c0341aa32)



## CORE 如何创建记忆

<img width="12885" height="3048" alt="memory-ingest-diagram" src="https://github.com/user-attachments/assets/c51679de-8260-4bee-bebf-aff32c6b8e13" />

CORE 的摄取流程包含四个阶段，旨在捕捉不断变化的上下文：

1. **规范化**：将新信息与最近的上下文关联，将长文档拆分为连贯的片段并保持交叉引用，标准化术语，这样在CORE提取知识时，处理的是干净、已上下文化的输入，而不是杂乱的文本。
2. **抽取**：通过识别实体（人物、工具、项目、概念）从规范化文本中提取含义，将其转化为带有上下文、来源和时间的语句，并映射关系。例如，“我们用Next.js编写了CORE”转化为：实体（CORE，Next.js），语句（CORE使用Next.js开发），关系（被开发使用）。
3. **解析**：检测矛盾，跟踪偏好的演变，并通过保留溯源的多种观点而不是覆盖它们，从而让记忆反映你的完整旅程，而不仅仅是最新快照。
4. **图集成**：将实体、语句和事件连接到一个时序知识图中，将事实与其上下文和历史联系起来，把孤立的数据变成智能体可以真正使用的动态知识网络。

结果：CORE为你提供的是随着你成长和变化而发展的记忆——保留上下文、演变和归属，让智能体真正能够使用它。


![memory-ingest-eg](https://github.com/user-attachments/assets/1d0a8007-153a-4842-9586-f6f4de43e647)

## CORE如何从记忆中回忆

<img width="10610" height="3454" alt="memory-search-diagram" src="https://github.com/user-attachments/assets/3541893e-f7c9-42b9-8fad-6dabf138dbeb" />

当你向CORE提问时，它不仅仅是查找文本——而是深入你的整个知识图，寻找最有用的答案。

1. **搜索**：CORE会从多个角度同时检索记忆——关键词搜索用于精确匹配，语义搜索用于查找相关理念即使措辞不同，图遍历用于跟踪关联概念之间的链接。
2. **重排序**：检索到的结果会被重新排序，以突出最相关和最多样化的内容，确保你不仅看到显而易见的匹配，还能发现更深层的关联。
3. **过滤**：CORE会根据时间、可靠性和关系强度应用智能过滤器，只让最有意义的知识浮现出来。
4. **输出**：你会得到事实（明确语句）和事件（它们来源的原始上下文），因此回忆总是以上下文、时间和故事为基础。

结果：CORE不仅仅回忆事实——还会在正确的上下文、时间和故事中回忆，让智能体能够像你记忆那样响应。

## 文档

浏览我们的文档，以充分利用CORE

- [基本概念](https://docs.heysol.ai/concepts/memory_graph)
- [自托管](https://docs.heysol.ai/self-hosting/overview)
- [将Core MCP连接到Claude](https://docs.heysol.ai/providers/claude)
- [将Core MCP连接到Cursor](https://docs.heysol.ai/providers/cursor)
- [将Core MCP连接到Claude Code](https://docs.heysol.ai/providers/claude-code)
- [将Core MCP连接到Codex](https://docs.heysol.ai/providers/codex) 

- [基本概念](https://docs.heysol.ai/overview)
- [API参考](https://docs.heysol.ai/api-reference/get-user-profile)

## 🔒 安全

CORE高度重视安全。我们采用行业标准的安全措施来保护您的数据：
- **数据加密**：所有传输中的数据（TLS 1.3）和静态数据（AES-256）
- **身份认证**：OAuth 2.0 和魔法链接认证
- **访问控制**：基于工作区的隔离和基于角色的权限
- **漏洞报告**：请将安全问题报告至 harshith@poozle.dev

如需详细的安全信息，请参阅我们的[安全政策](https://raw.githubusercontent.com/RedPlanetHQ/core/main/SECURITY.md)。

## 🧑‍💻 支持

有问题或反馈？我们随时为您提供帮助：

- Discord： [加入 core-support 频道](https://discord.gg/YGUZcvDjUa)
- 文档： [docs.heysol.ai](https://docs.heysol.ai)
- 邮箱： manik@poozle.dev

## 使用指南

**存储：**

- 对话历史
- 用户偏好设置
- 任务上下文
- 参考资料

**不存储：**

- 敏感数据（PII）
- 凭证
- 系统日志
- 临时数据

## 👥 贡献者

<a href="https://github.com/RedPlanetHQ/core/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=RedPlanetHQ/core" />
</a>
















---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-16

---