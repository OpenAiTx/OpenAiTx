<div align="center">

# THE CLAUDE PROTOCOL

**Enforcement-first orchestration for Claude Code. Every agent tracked. Every decision logged. Nothing gets lost.**

**Claude Code plans great. Without structure, nothing survives past one session.**

[![npm version](https://img.shields.io/npm/v/beads-orchestration?style=for-the-badge&logo=npm&logoColor=white&color=CB3837)](https://www.npmjs.com/package/beads-orchestration)
[![GitHub stars](https://img.shields.io/github/stars/AvivK5498/The-Claude-Protocol?style=for-the-badge&logo=github&color=181717)](https://github.com/AvivK5498/The-Claude-Protocol)
[![License](https://img.shields.io/badge/license-MIT-blue?style=for-the-badge)](LICENSE)

<br>

```bash
npx skills add AvivK5498/The-Claude-Protocol
```

**macOS and Linux.**

<br>

![The Claude Protocol — Kanban UI](https://raw.githubusercontent.com/AvivK5498/The-Claude-Protocol/main/screenshots/kanbanui.png)

<br>

[Why This Exists](#why-this-exists) · [How It Works](#how-it-works) · [Getting Started](#getting-started) · [Hooks](#hooks)

</div>

---

## Why This Exists

Claude Code is the best coding agent out there. But let it run unsupervised and you get agents editing main, commits without PRs, lost context every session, and zero traceability on what was done and why.

Plan mode helps — until you need to coordinate across files, track what was planned vs what shipped, or pick up a task three sessions later. Plans vanish. Context resets. Investigation gets redone from scratch.

The Claude Protocol is the enforcement layer. It wraps Claude Code with 13 hooks that physically block bad actions, isolates every task in its own git worktree, and documents everything automatically — dispatch prompts, agent knowledge, decisions, all of it. [Beads](https://github.com/steveyegge/beads) (git-native tickets) track every unit of work from creation to merge.

The complexity is in the system. What you see: Claude plans with you, you approve, agents execute in isolation, PRs get merged. Done.

---

## How It Works

```
┌─────────────────────────────────────────┐
│         ORCHESTRATOR (Co-Pilot)         │
│  Plans with you (Plan mode)            │
│  Investigates with Grep/Read/Glob       │
│  Delegates implementation via Task()    │
└──────────────────┬──────────────────────┘
                   │
       ┌───────────┼───────────┐
       ▼           ▼           ▼
  ┌─────────┐ ┌─────────┐ ┌─────────┐
  │ react-  │ │ python- │ │ nextjs- │
  │supervisor│ │supervisor│ │supervisor│
  └────┬────┘ └────┬────┘ └────┬────┘
       │           │           │
  .worktrees/ .worktrees/ .worktrees/
  bd-BD-001   bd-BD-002   bd-BD-003
```

**协调者** 负责调查、与你讨论并进行规划。它从不编写代码。调度的提示会自动记录到 bead 中，确保信息不会丢失。

**监督者** 根据你的技术栈自动创建。它们读取 bead 评论以获取完整上下文，在独立的工作树中工作，并提交干净的 PR。

**Beads** 是 git 原生的任务单。每个任务、每个史诗、每个依赖关系——都在你的仓库中跟踪，而非第三方服务。一个 bead = 一个工作单元 = 一个工作树 = 一个 PR。

### 工作流程

**独立任务** — 调查 → 规划 → 审批 → 创建 bead → 调度监督者 → 工作树 → PR → 合并。

**史诗任务** — 跨领域工作（数据库 + API + 前端）成为一个带强制子依赖的史诗。每个子任务拥有自己的工作树。依赖关系防止乱序调度。

**快速修复** — 对于琐碎改动（<10 行），协调者可直接在功能分支上编辑。钩子提示用户审批，显示文件名和变更大小。主分支严格禁止——必须使用 bead 流程。

每个任务都通过 beads 进行——除非用户明确批准快速修复。

### 看板界面

Claude 协议配合 [Beads 看板界面](https://github.com/AvivK5498/Beads-Kanban-UI) 实现可视化任务管理和直接从浏览器操作 GitOps。跨列追踪史诗、子任务、依赖和 PR 状态——无需离开看板。

---

## 入门指南

```bash
npx skills add AvivK5498/The-Claude-Protocol
```

或者通过 npm：

```bash
npm install -g beads-orchestration
```

然后在任何 Claude 代码会话中：

```bash
/create-beads-orchestration
```
该技能引导您完成设置，扫描您的技术栈，并创建注入最佳实践的监督者。

### 需求

- 支持钩子的 Claude Code  
- Node.js（用于 npx）  
- Python 3（用于引导）  
- beads CLI（自动安装）  

---

## 与众不同之处

### 强制执行，而非建议

5 个生命周期事件中共有 13 个钩子。它们不发出警告——而是阻止操作。协调者不能在主分支上编辑代码。监督者不能跳过 beads。史诗任务不能在子任务未关闭时关闭。`git commit --no-verify` 被阻止——预提交钩子始终运行。

### 以调查为先、以约束为驱动

协调者必须在委派之前读取实际源文件——不能猜测。约束（“未读取源代码绝不派发”）优于指令（“记得调查”），灵感来源于 [Cursor 的多代理研究](https://cursor.com/blog/self-driving-codebases)。协调者还在会话之间维护持久记忆。

### 自动生成的文档

每个监督者派发提示都会自动作为 bead 注释被捕获。代理自愿将惯例和注意事项记录到持久知识库中。会话开始时展示最近的知识，避免代理重复调查已解决的问题。


```bash
# Agent captures an insight
bd comment BD-001 "LEARNED: TaskGroup requires @Sendable closures in strict concurrency mode."

# Search the knowledge base
.beads/memory/recall.sh "concurrency"
```

### 跟踪追溯

封闭的珠子是不可变的。错误修复成为通过 `bd dep relate` 关联的新珠子——完整历史，无需重新打开。合并的分支不再重复使用。每个修复都有自己的工作树和 PR。

---

## 安装内容

```
.claude/
├── agents/           # Supervisors (auto-created for your tech stack)
├── hooks/            # Workflow enforcement (13 hooks)
├── skills/           # subagents-discipline, react-best-practices
└── settings.json
CLAUDE.md             # Orchestrator instructions
.beads/               # Task database
  memory/             # Knowledge base (knowledge.jsonl + recall.sh)
.worktrees/           # Isolated worktrees per task (created dynamically)
```

---

## 钩子

13 个钩子强制执行每个工作流程步骤。它们在不良操作发生前阻止，在良好操作后自动记录，并在主管退出前进行验证。

**PreToolUse**（7 个钩子）— 阻止协调器在主分支上写代码。对功能分支提示快速修复批准。阻止提交时使用 `--no-verify`。允许内存文件写入。要求主管调度时使用珠子。强制工作树隔离。阻止关闭有未完成子任务的史诗。强制顺序依赖调度。

**PostToolUse**（3 个钩子）— 自动将调度提示记录为珠子评论。捕获知识库条目。强制主管响应简洁。

**SubagentStop**（1 个钩子）— 验证工作树存在，代码已推送，珠子状态已更新。

**SessionStart**（1 个钩子）— 显示任务状态、近期知识和清理建议。

**UserPromptSubmit**（1 个钩子）— 对模糊请求提示澄清。

---

## 高级：外部提供者

默认情况下，所有代理通过 Claude 的 Task() 运行。要将只读代理（侦察兵、侦探等）委托给 Codex/Gemini：

```bash
/create-beads-orchestration --external-providers
```
需要 Codex CLI（`codex login`），可选 Gemini CLI，以及 [uv](https://github.com/astral-sh/uv)。

---

## 许可协议

MIT

## 致谢

- [beads](https://github.com/steveyegge/beads) — 由 Steve Yegge 开发的 Git 原生任务跟踪工具
- [sub-agents.directory](https://github.com/ayush-that/sub-agents.directory) — 外部代理模板



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-28

---