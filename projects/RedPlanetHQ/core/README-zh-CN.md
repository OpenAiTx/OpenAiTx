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
  <a href="https://getcore.me">
    <img width="200px" alt="CORE logo" src="https://github.com/user-attachments/assets/bd4e5e79-05b8-4d40-9aff-f1cf9e5d70de" />
  </a>

# 你的个人AI操作系统。

**运行你的操作系统。** 观察你的工作。记住重要事项。在你的工具和代理中执行操作。开源，自托管，永远属于你。

<p align="center">
    <a href="https://getcore.me">
        <img src="https://img.shields.io/badge/Website-getcore.me-c15e50?style=for-the-badge&logo=safari&logoColor=white" alt="网站" />
    </a>
    <a href="https://docs.getcore.me">
        <img src="https://img.shields.io/badge/Docs-docs.getcore.me-22C55E?style=for-the-badge&logo=readthedocs&logoColor=white" alt="文档" />
    </a>
    <a href="https://discord.gg/YGUZcvDjUa">
        <img src="https://img.shields.io/badge/Discord-community-5865F2?style=for-the-badge&logo=discord&logoColor=white" alt="Discord 社区" />
    </a>
    <a href="https://github.com/RedPlanetHQ/core/blob/main/LICENSE">
        <img src="https://img.shields.io/badge/License-AGPL%203.0-blue?style=for-the-badge" alt="许可证：AGPL 3.0" />
    </a>
</p>
</div>

---

## 实际演示

观看 CORE 完成两项编码任务的全过程：

[![CORE 演示](https://img.youtube.com/vi/7y_kt_UTYQs/maxresdefault.jpg)](https://www.youtube.com/watch?v=7y_kt_UTYQs)

---

## CORE 是什么

CORE 是面向 AI 原生工作的开源操作层。

你在草稿板上写下需要完成的事项。CORE 会拾取任务，从内存和已连接应用中加载上下文，拟定方案，通过网关运行合适的智能体，在可以的情况下处理阻碍，并在需要人工判断时返回给你。

它不是一个需要不断提示的聊天机器人。它是记忆、协调、执行和升级的操作层。

### 架构简介

| | |
|---|---|
| **监控** | 通过 MCP 获取你的 AI 对话上下文，连接 50+ 应用，并在 Mac 上获取你明确授权的任何应用数据。 |
| **记忆** | 一个知识图谱，记录你说了什么、做了什么决定、时间和原因，覆盖每个工具和对话。 |
| **执行** | 在已连接应用中直接操作，并通过网关将更长任务委托给编码和浏览器智能体。 |
| **政策** | 审批流程、升级规则、计划和审计日志，让自主权保持责任制。|

CORE决定它能安全执行的操作，在敏感行为前请求批准，并留下可供审查的记录。

---

## CORE实际应用

### 委派编码任务，回来时已生成PR。

告诉CORE需要完成什么。它从你的仓库、应用和记忆中收集上下文，拟定计划，运行Claude Code或Codex会话，尽量处理阻碍，并最终带来一个PR。完成后由你审核。

`[ ] 修复checkout流程的竞争条件，见issue #312`

### 睡觉时清理你的待办事项。

设定定期任务，在指定时间从待办列表中拉取任务。你离线时CORE自动处理。顺利完成的任务早上等待你审核，遇到阻碍的会带着具体问题回来，而不是停在卡住的页面。

`[ ] 今晚11点开始处理待办事项`

### 在警报成为打扰前先行调查。

设定定期任务监控Sentry、日志或任何警报来源。发生警报时，CORE调查，拉取相关跟踪和历史事件，决定自行处理还是升级上报。

Sentry警报在凌晨2点触发。CORE调查，提出修复建议，并在Slack上通知你审核。

### 获得懂你工作的晨间简报。

设定定期任务，每天早上从邮箱、GitHub、Linear和Slack拉取信息。CORE总结需要关注的内容，跳过无关事项，自动将后续事项转为任务。

### 随时随地委派任务。

可通过Slack、WhatsApp、Telegram、邮件或网页创建任务。网关在Docker或Railway中持续运行，即使你的电脑关闭，CORE也能接收任务。

---

## CORE内部结构

| | |
|---|---|
| **记忆** | 跟踪你在每个工具和对话中的偏好、决策、目标和指令，让每个任务都在加载上下文的基础上开始。 |
| **任务** | 一次性或周期性工作单元，包含你的规范、CORE的计划、实时状态和专属聊天线程。每个任务都可衍生编码或浏览会话。 |
| **速记板** | 用于任务、想法和进行中工作的每日页面。在任意位置输入 `[ ]`，CORE 会在 3 分钟内捕捉到。 |
| **连接器** | 通过一个 MCP 端点连接 50 多个应用，还支持 webhook 触发主动自动化。支持 GitHub、Linear、Jira、Slack、Gmail、Calendar、Sentry、Granola、Todoist 等。 |
| **技能** | 100 多个可复用指令自动根据上下文应用。可使用内置技能，也可自定义编写，实现可重复工作流。 |
| **网关** | 在你的电脑或 Docker / Railway 上运行 Claude Code、Codex、浏览器代理和本地命令，让 CORE 即使在你笔记本合盖时也能持续工作。 |
| **模型无关** | 可自选提供商：Anthropic、OpenAI 或开源权重模型。可自托管全栈实现隔离。 |

---

## CORE 不是什么

| | |
|---|---|
| **不是 RAG 封装器。** | 记忆不仅仅是嵌入片段，而是一个知识图谱，跟踪你的决策、时间和原因。 |
| **不是工作流构建器。** | 没有拖拽式 DAG。你只需写明要做什么，CORE 自动推理流程，并在需要判断时询问你。 |
| **不是另一个 Devin。** | CORE 提出计划，由你批准。CORE 请求解阻，由你决定。CORE 带回 PR，由你审核。代理不会自行合并。 |
| **不是封闭云助手。** | CORE 是开源、自托管、模型无关，并围绕你的基础设施设计。 |

---

## 快速开始

开源且可自托管。你的数据始终在你的基础设施中。

**安装并启动 CORE：**

```bash
npm install -g @redplanethq/corebrain && corebrain setup
```
安装向导会要求输入安装目录、AI 提供商、API 密钥和聊天模型。它会生成密钥，启动堆栈，并打开 `http://localhost:3033`。

大多数本地安装在 Docker 运行后只需几分钟。

**或者在 Railway 上部署：**

[![在 Railway 上部署](https://railway.app/button.svg)](https://railway.com/deploy/core)

**连接网关**，以便 CORE 能够控制你的浏览器、运行编码代理并访问本地文件夹：


```bash
corebrain login
corebrain gateway setup
```

**要求：** Docker 20.10+，Docker Compose 2.20+，4 vCPU / 8GB RAM

[完整自托管指南](https://docs.getcore.me/self-hosting/setup)

> 想要 Mac 应用？请在 [getcore.me](https://www.getcore.me/) 加入候补名单。

---

## 基准测试

CORE 在 [LoCoMo 基准测试](https://github.com/RedPlanetHQ/core-benchmark) 上在单跳、多跳、开放域和时间推理等方面实现了 **88.24%** 的平均准确率。

---

## 我们的信念

- 聊天是界面，而不是操作系统。
- 没有记忆的智能只是琐事。
- 你的 AI 应该跨所有工具了解你，而不仅仅是当前标签页。
- 工作应该从意图到行动自动流转，无需你成为粘合剂。
- 没有责任制的自动化就是混乱。

---

## 文档

- [**记忆**](https://docs.getcore.me/memory/overview) - 时间知识图谱、事实分类、基于意图的检索
- [**便签**](https://docs.getcore.me/concepts/scratchpad) - 任务和想法日常起点
- [**任务**](https://docs.getcore.me/concepts/tasks) - 计划、状态、周期性工作和任务上下文
- [**工具箱**](https://docs.getcore.me/concepts/toolkit) - 通过 MCP 跨 50+ 应用的 1000+ 动作
- [**CORE Agent**](https://docs.getcore.me/concepts/meta-agent) - 触发器、记忆、工具与执行
- [**网关**](https://docs.getcore.me/access-core/overview) - 支持 WhatsApp、Slack、Telegram、邮件、网页和 API 接入
- [**技能**](https://docs.getcore.me/skills/overview) - 可复用指令，实现可重复流程
- [**自托管**](https://docs.getcore.me/self-hosting/setup) - 完整部署指南
- [**更新日志**](https://docs.getcore.me/opensource/changelog) - 已发布内容

---

## 安全

- CASA 二级认证
- 传输中使用 TLS 1.3
- 静态存储采用 AES-256 加密
- 您的数据绝不会被用于模型训练
- 支持自部署，实现完全隔离
- [安全政策](https://raw.githubusercontent.com/RedPlanetHQ/core/main/SECURITY.md)
- 漏洞报告：harshith@poozle.dev

---

## 社区

我们正在公开构建 CORE。

我们公开分享产品路线图和架构决策，因为构建个人操作系统时遇到的最难问题，往往需要用户一起解决。请为代码仓库加星，自部署、分享你的成果，并反馈问题或缺失功能。

- [Discord](https://discord.gg/YGUZcvDjUa) - 提问、交流想法、展示作品
- [贡献文档](https://docs.getcore.me/opensource/contributing) - 如何为 CORE 做贡献
- [`good-first-issue`](https://github.com/RedPlanetHQ/core/labels/good-first-issue) - 新手从这里开始

<a href="https://github.com/RedPlanetHQ/core/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=RedPlanetHQ/core" />
</a>

---

<div align="center">

**自部署您的个人 AI 操作系统。**

[为本仓库加星](https://github.com/RedPlanetHQ/core) · [阅读文档](https://docs.getcore.me) · [加入 Discord](https://discord.gg/YGUZcvDjUa)

</div>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-19

---