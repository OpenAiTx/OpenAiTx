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

### CORE：Claude、Cursor、ChatGPT及所有AI工具的统一记忆层

<p align="center">
    <a href="https://deepwiki.com/RedPlanetHQ/core">
        <img src="https://deepwiki.com/badge.svg" alt="DeepWiki 徽章" />
    </a>
</p>
<p align="center">
    <a href="https://docs.heysol.ai/core/overview"><b>文档</b></a> •
    <a href="https://discord.gg/YGUZcvDjUa"><b>Discord 交流群</b></a>
</p>
</div>

## 🔥 研究亮点

CORE 内存在 Locomo 数据集的所有推理任务上实现了 **88.24%** 的平均准确率，显著优于其他内存提供者。更多信息请查阅这篇 [博客](https://blog.heysol.ai/we-built-memory-for-individuals-and-achieved-sota-on-locomo-benchmark/)。

<img width="6048" height="3428" alt="benchmark" src="https://github.com/user-attachments/assets/2e5fdac5-02ed-4d00-9312-c21d09974e1f" />
(1) 单跳问题仅需基于单个会话作答；(2) 多跳问题需从多个不同会话中综合信息；(3) 开放域知识问题可通过整合说话者提供的信息与常识或世界事实等外部知识进行回答；(4) 时序推理问题需通过时序推理和捕捉对话中的时间相关数据线索来回答；

## 概述

**问题**

开发者需要反复向 AI 工具解释上下文，浪费大量时间。Claude 的 token 达到上限？只能重新开始并失去所有内容。从 ChatGPT/Claude 切换到 Cursor？又要重新解释你的背景。你的对话、决策和洞察在不同会话间消失。每换一个新的 AI 工具，切换上下文的成本就更高。

**解决方案** - **CORE**（**Contextual Observation & Recall Engine**，上下文观察与回忆引擎）

CORE 是一个开源的统一持久内存层，适用于所有 AI 工具。你的上下文可以在 Cursor、Claude、ChatGPT、Claude Code 间无缝跟随。一个知识图谱记录了谁说了什么、何时说的、为什么说。只需连接一次，处处记得，无需再管理上下文，专注于构建内容。

## 🚀 快速上手
**5 分钟构建你的统一内存图谱：**

1. 在 [core.heysol.ai](https://core.heysol.ai) **注册**并创建账户
2. **添加你的第一条记忆**——分享你的个人上下文

    <img width="2088" height="1212" alt="first-memory" src="https://github.com/user-attachments/assets/ecfab88e-e91a-474d-9ef5-fc6c19b655a8" />


3. **可视化你的记忆图谱**，查看 CORE 如何自动连接事实之间的关系
5. **试用**——在会话区输入“你了解我什么？”进行体验
6. 连接你的工具：
   - [Claude](https://docs.heysol.ai/providers/claude) 与 [Cursor](https://docs.heysol.ai/providers/cursor)——带上下文编程
   - [Claude Code CLI](https://docs.heysol.ai/providers/claude-code) 与 [Gemini CLI](https://docs.heysol.ai/providers/claude-code)——基于终端的带记忆编程
   - [添加浏览器扩展](https://docs.heysol.ai/providers/browser-extension)——让你的记忆随时在任意网站可用
   - [Linear](https://docs.heysol.ai/integrations/linear)，[Github](https://docs.heysol.ai/integrations/github) - 自动添加项目上下文

## 🧩 主要功能

### 🧠 **统一、可移植的记忆**： 
通过 MCP 在 **Cursor、Windsurf、Claude Desktop、Claude Code、Gemini CLI、AWS 的 Kiro、VS Code 和 Roo Code** 中添加并回忆记忆

![core-claude](https://github.com/user-attachments/assets/56c98288-ee87-4cd0-8b02-860aca1c7f9a)


### 🕸️ **时序化 + 实体化知识图谱**： 

记住每个事实背后的故事——通过丰富的关系和完整的溯源跟踪是谁、何时、为何说了什么，而不仅仅是简单存储

![core-memory-graph](https://github.com/user-attachments/assets/5d1ee659-d519-4624-85d1-e0497cbdd60a)


### 🌐 **浏览器扩展程序**： 

可直接将 ChatGPT、Grok、Gemini、Twitter、YouTube、博客文章及任意网页上的对话和内容保存到您的 CORE 记忆中。

**扩展程序使用方法**
1. 从 Chrome 网上应用店[下载扩展程序](https://chromewebstore.google.com/detail/core-extension/cglndoindnhdbfcbijikibfjoholdjcc)。
2. 登录到 [CORE 仪表盘](https://core.heysol.ai)
   - 导航至设置（左下角）
   - 进入 API Key → 生成新密钥 → 命名为“extension”。
3. 打开扩展程序，粘贴您的 API 密钥并保存。

https://github.com/user-attachments/assets/6e629834-1b9d-4fe6-ae58-a9068986036a


### 💬 **记忆聊天**： 
可以通过“我的写作偏好是什么？”等问题，立即获取来自已连接知识的洞见

![chat-with-memory](https://github.com/user-attachments/assets/d798802f-bd51-4daf-b2b5-46de7d206f66)


### ⚡ **应用自动同步**：

自动将 Linear、Slack、Notion、GitHub 及其他已连接应用中的相关上下文捕获到您的 CORE 记忆

📖 **[查看所有集成](https://raw.githubusercontent.com/RedPlanetHQ/core/main/./integrations/README.md)** - 支持的服务及其功能的完整列表

![core-slack](https://github.com/user-attachments/assets/d5fefe38-221e-4076-8a44-8ed673960f03)


### 🔗 **MCP 集成中心**：

只需将 Linear、Slack、GitHub、Notion 一次性连接到 CORE——然后即可在 Claude、Cursor 或任何 MCP 客户端中，通过一个 URL 使用所有工具


![core-linear-claude](https://github.com/user-attachments/assets/7d59d92b-8c56-4745-a7ab-9a3c0341aa32)



## CORE 如何创建记忆

<img width="12885" height="3048" alt="memory-ingest-diagram" src="https://github.com/user-attachments/assets/c51679de-8260-4bee-bebf-aff32c6b8e13" />

CORE 的摄取流程分为四个阶段，旨在捕获不断变化的上下文：

1. **归一化**：将新信息与最近的上下文关联，将长文档拆分为连贯的片段并保持交叉引用，同时统一术语，因此在 CORE 提取知识之前，它处理的是干净、具备上下文的输入，而不是杂乱文本。
2. **抽取**：通过识别实体（人物、工具、项目、概念）从归一化文本中提取意义，将其转化为带有上下文、来源和时间的陈述，并映射关系。例如，“我们用 Next.js 编写了 CORE”会变成：实体（CORE，Next.js）、陈述（CORE 用 Next.js 开发）、关系（用...开发）。
3. **解析**：检测矛盾，跟踪偏好如何变化，并通过保留溯源信息保存多种观点，而不是覆盖它们，让记忆反映你的完整历程，而不仅仅是最新快照。
4. **图集成**：将实体、陈述和事件连接到一个时序知识图，将事实与其上下文和历史关联起来，使孤立数据变成智能体真正可以使用的知识网络。

最终结果：CORE 提供的是会随你成长和变化的记忆——保留上下文、演变和归属权，让智能体可以真正用起来。


![memory-ingest-eg](https://github.com/user-attachments/assets/1d0a8007-153a-4842-9586-f6f4de43e647)

## CORE 如何从记忆中回忆

<img width="10610" height="3454" alt="memory-search-diagram" src="https://github.com/user-attachments/assets/3541893e-f7c9-42b9-8fad-6dabf138dbeb" />

当你向 CORE 提问时，它不仅仅是查找文本——而是深入整个知识图谱，寻找最有用的答案。

1. **搜索**：CORE 会同时从多个角度查找记忆——关键词搜索用于精确匹配，语义搜索用于发现表述不同但相关的想法，以及图遍历以追踪关联概念之间的链接。
2. **重排序**：检索到的结果会被重新排序，突出最相关和最多样化的内容，确保你不仅看到明显匹配，还能发现更深层的联系。
3. **过滤**：CORE 根据时间、可靠性和关系强度应用智能过滤，只让最有意义的知识呈现出来。
4. **输出**：你将获得事实（明确陈述）和情节（它们的原始上下文），因此回忆始终有上下文、时间和故事作为基础。

结果：CORE不仅仅回忆事实——它还能在正确的上下文、时间和故事中回忆事实，使代理能够以你记忆的方式做出回应。

## 文档

查阅我们的文档，充分利用CORE

- [基本概念](https://docs.heysol.ai/concepts/memory_graph)
- [自托管](https://docs.heysol.ai/self-hosting/overview)
- [将Core MCP连接到Claude](https://docs.heysol.ai/providers/claude)
- [将Core MCP连接到Cursor](https://docs.heysol.ai/providers/cursor)

- [基本概念](https://docs.heysol.ai/overview)
- [API参考](https://docs.heysol.ai/local-setup)

## 🔒 安全性

CORE高度重视安全。我们采用行业标准的安全措施保护您的数据：

- **数据加密**：所有传输中的数据（TLS 1.3）和静态数据（AES-256）
- **身份认证**：OAuth 2.0和魔法链接认证
- **访问控制**：基于工作区的隔离和基于角色的权限
- **漏洞报告**：请将安全问题报告至 harshith@tegon.ai

有关详细的安全信息，请参阅我们的[安全政策](https://raw.githubusercontent.com/RedPlanetHQ/core/main/SECURITY.md)。

## 🧑‍💻 支持

有问题或反馈？我们随时为您服务：

- Discord：[加入core-support频道](https://discord.gg/YGUZcvDjUa)
- 文档：[docs.heysol.ai](https://docs.heysol.ai)
- 邮箱：manik@poozle.dev

## 使用指南

**存储：**

- 对话历史
- 用户偏好
- 任务上下文
- 参考资料

**请勿存储：**

- 敏感数据（个人身份信息）
- 证书
- 系统日志
- 临时数据

## 👥 贡献者

<a href="https://github.com/RedPlanetHQ/core/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=RedPlanetHQ/core" />
</a>








---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-30

---