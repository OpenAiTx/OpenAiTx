# 示例：请帮我整理我的工作文件夹

https://github.com/user-attachments/assets/48743a51-705a-4c66-9fdb-4d7147f8098b


[简体中文](https://raw.githubusercontent.com/caiqinghua/Open-Claude-Cowork/main/README_ZH.md)

# Claude Cowork

一个**桌面AI助手**，帮助你完成**编程、文件管理以及任何你能描述的任务**。

它与Claude Code的**完全相同配置兼容**，这意味着你可以使用**任何Anthropic兼容的大型语言模型**运行它。

**✨ 无需订阅Claude Max** - 支持任何Anthropic兼容的API模型，包括智谱GLM 4.7、MiniMax 2.1、Moonshot Kimi、DeepSeek等。

> 不只是一个GUI。  
> 一个真正的AI协作伙伴。  
> 无需学习Claude Agent SDK——只需创建任务并选择执行路径。


---

## ✨ 为什么选择Claude Cowork？

Claude Code功能强大——但它**只能在终端运行**。

这意味着：
- ❌ 复杂任务没有视觉反馈
- ❌ 多个会话难以追踪
- ❌ 工具输出不便检查

**Open Claude Cowork解决了这些问题：**

- 🖥️ 作为**本地桌面应用程序**运行
- 🤖 作为你的**AI协作伙伴**完成任何任务
- 🔁 重用你现有的**`~/.claude/settings.json`**
- 🧠 与Claude Code**100%兼容**

如果Claude Code能在你的机器上运行——  
**Open Claude Cowork也能运行。**

---

## 🚀 快速开始

> **💡 提示：** 本应用完全兼容 Claude Code 配置。无需 Claude Max 订阅——您可以使用智谱 GLM、MiniMax、Kimi、DeepSeek 或任何其他兼容 Anthropic 的 API 模型。

在使用 Open Claude Cowork 之前，请确保已安装并正确配置 Claude Code。

### 选项 1：下载发行版

👉 [前往发行版](https://github.com/caiqinghua/open-claude-cowork/releases)

---

### 选项 2：从源码构建

#### 先决条件

- [Bun](https://bun.sh/) 或 Node.js 22+
- 已安装并通过认证的 [Claude Code](https://docs.anthropic.com/en/docs/claude-code)

```bash
# Clone the repository
git clone https://github.com/caiqinghua/open-claude-cowork.git
cd open-claude-cowork

# Install dependencies
bun install

# Configure environment (copy .env.example to .env)
cp .env.example .env

# Run in development mode
bun run dev

# Or build production binaries
bun run dist:mac    # macOS
bun run dist:win    # Windows
bun run dist:linux  # Linux
```

---

## 🧠 核心能力

### 🤖 AI 协作伙伴 — 不仅仅是图形界面

Open Claude Cowork 是您的 AI 伙伴，可以：

* **编写和编辑代码** — 支持任何编程语言
* **管理文件** — 创建、移动和整理
* **制作PPT** — 生成演示内容和结构
* **主题分析** — 深入分析研究主题和方向
* **文章写作** — 撰写各种类型的文章和文档
* **执行任何任务** — 只要您能用自然语言描述

---

### 📂 会话管理

* 创建带有 **自定义工作目录** 的会话
* 恢复任何之前的对话
* 完整的本地会话历史（存储于 SQLite）
* 安全删除和自动持久化

---

### 🎯 实时流式输出

* **逐令牌流式输出**
* 查看 Claude 的推理过程
* Markdown 渲染，带语法高亮代码
* 可视化工具调用及状态指示

---

### 🔐 工具权限控制

* 敏感操作需明确批准
* 可逐工具允许或拒绝
* 交互式决策面板
* 完全控制Claude允许执行的操作

---

## 🔁 完全兼容Claude Code

Open Claude Cowork **与Claude Code共享配置**。

它直接重用：

text
~/.claude/settings.json


这意味着：

* 相同的API密钥
* 相同的基础URL
* 相同的模型
* 相同行为

**支持的模型包括：**
- Zhipu GLM 4.7
- MiniMax 2.1
- Moonshot Kimi
- DeepSeek
- 其他所有兼容Anthropic API的模型

> 配置一次Claude Code — 处处使用。

---

## 🔧 故障排除

### better-sqlite3 模块错误

如果遇到如下错误：

```
Error: The module was compiled against a different Node.js version using
NODE_MODULE_VERSION 127. This version of Node.js requires NODE_MODULE_VERSION 140.
```
这发生是因为 Electron 捆绑了它自己的 Node.js 版本，原生模块需要为其重新编译。

**解决方案：**


```bash
# Install electron-rebuild as a dev dependency
npm install --save-dev electron-rebuild

# Rebuild better-sqlite3 for Electron
npx electron-rebuild -f -w better-sqlite3

# Run the app again
bun run dev
```
这确保了本地模块是针对 Electron 的 Node.js 版本编译的，而不是针对您系统的 Node.js 版本。

---

## 🧩 架构概览

| 层级             | 技术                           |
| ---------------- | ------------------------------ |
| 框架             | Electron 39                    |
| 前端             | React 19, Tailwind CSS 4       |
| 状态管理         | Zustand                        |
| 数据库           | better-sqlite3（WAL 模式）      |
| 人工智能         | @anthropic-ai/claude-agent-sdk |
| 构建             | Vite, electron-builder         |

---

## 🛠 开发

bash
# 启动开发服务器（热重载）
bun run dev

# 类型检查 / 构建
bun run build


---

## 🗺 路线图

计划功能：

* 基于 GUI 的模型和 API 密钥配置
* 🚧 更多功能即将推出

---

## 🤝 贡献


欢迎提交 Pull Request。

1. Fork 此仓库
2. 创建你的功能分支
3. 提交你的更改
4. 打开一个 Pull Request

---

## ⭐ 最后的话

如果你曾经想要：

* 一个持久的桌面 AI 协作伙伴
* 对 Claude 工作方式的可视化洞察
* 跨项目的便捷会话管理

这个项目就是为你打造的。

👉 **如果它对你有帮助，请给它一个 Star。**

---

## 许可证

MIT





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-02

---