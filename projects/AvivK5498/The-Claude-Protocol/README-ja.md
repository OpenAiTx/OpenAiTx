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

**オーケストレーター** は調査し、あなたと議論し、計画を立てます。コードは一切書きません。ディスパッチプロンプトは自動的にビードに記録され、何も失われません。

**スーパーバイザー** はあなたの技術スタックに基づいて自動生成されます。ビードのコメントを読み込み全体の文脈を把握し、分離されたワークツリーで作業し、クリーンなPRを作成します。

**ビーズ** はgitネイティブなチケットです。すべてのタスク、エピック、依存関係がリポジトリで追跡され、サードパーティのサービスは不要です。1ビード＝1作業単位＝1ワークツリー＝1PR。

### ワークフロー

**スタンドアロン** — 調査 → 計画 → 承認 → ビード作成 → スーパーバイザーディスパッチ → ワークツリー → PR → マージ。

**エピック** — クロスドメイン作業（DB + API + フロントエンド）はエピックとなり、子依存関係が強制されます。各子は独自のワークツリーを持ちます。依存関係により順序外のディスパッチが防止されます。

**クイックフィックス** — 些細な変更（10行未満）については、オーケストレーターが直接フィーチャーブランチで編集可能です。フックはファイル名と変更規模を表示してユーザーに承認を求めます。メインでは厳格にブロックされ、必ずビードワークフローを使用する必要があります。

すべてのタスクはビーズを通過します — ユーザーが明示的にクイックフィックスを承認しない限り。

### カンバンUI

Claudeプロトコルは[Beads Kanban UI](https://github.com/AvivK5498/Beads-Kanban-UI)と連携し、ブラウザから直接タスク管理とGitOpsを視覚的に実現します。エピック、サブタスク、依存関係、PRステータスをカラムで追跡し、ボードから離れる必要はありません。

---

## はじめに

```bash
npx skills add AvivK5498/The-Claude-Protocol
```

または npm 経由で：

```bash
npm install -g beads-orchestration
```

それから、任意のClaude Codeセッションで:

```bash
/create-beads-orchestration
```
スキルはセットアップを案内し、技術スタックをスキャンし、ベストプラクティスを注入したスーパーバイザーを作成します。

### 要件

- フックサポート付きClaude Code
- Node.js（npx用）
- Python 3（ブートストラップ用）
- beads CLI（自動インストール）

---

## これが違う理由

### 提案ではなく強制

5つのライフサイクルイベントにまたがる13のフック。警告はせず、ブロックします。オーケストレーターはmain上のコードを編集できません。スーパーバイザーはbeadsをスキップできません。エピックは未完了の子を残したまま閉じられません。`git commit --no-verify`はブロックされ、プリコミットフックは常に実行されます。

### 調査優先、制約駆動

オーケストレーターは委譲前に実際のソースファイルを読む必要があり、推測はしません。制約（「ソースを読まずにディスパッチしない」）は指示（「調査を忘れないで」）より優れています。[Cursorのマルチエージェント研究](https://cursor.com/blog/self-driving-codebases)に触発されました。オーケストレーターはセッションをまたいで永続的なメモリも維持します。

### 自動生成されるドキュメント

すべてのスーパーバイザーディスパッチプロンプトは自動的にbeadコメントとして記録されます。エージェントは規約や注意点を自発的に永続的なナレッジベースに記録します。セッション開始時には最近の知識が表示され、エージェントが解決済みの問題を再調査しません。


```bash
# Agent captures an insight
bd comment BD-001 "LEARNED: TaskGroup requires @Sendable closures in strict concurrency mode."

# Search the knowledge base
.beads/memory/recall.sh "concurrency"
```

### フォローアップのトレーサビリティ

クローズドビーズは不変です。バグ修正は `bd dep relate` を介してリンクされた新しいビーズになります — 完全な履歴、再オープンなし。マージされたブランチは再利用されません。各修正には独自のワークツリーとPRが割り当てられます。

---

## インストールされるもの

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

## フック

13のフックがすべてのワークフローのステップを強制します。悪い操作が起こる前にブロックし、良い操作の後に自動ログを取り、監督者が退出する前に検証します。

**PreToolUse**（7つのフック）— オーケストレーターがmainにコードを書き込むのをブロックします。機能ブランチでのクイックフィックス承認を促します。コミット時の`--no-verify`をブロックします。メモリファイルの書き込みを許可します。監督者のディスパッチにビーズを要求します。作業ツリーの隔離を強制します。オープンな子を持つエピックのクローズをブロックします。逐次依存のディスパッチを強制します。

**PostToolUse**（3つのフック）— ディスパッチのプロンプトをビーズコメントとして自動ログします。ナレッジベースのエントリをキャプチャします。簡潔な監督者の応答を強制します。

**SubagentStop**（1つのフック）— 作業ツリーが存在すること、コードがプッシュされていること、ビーズの状態が更新されていることを検証します。

**SessionStart**（1つのフック）— タスクの状態、最近のナレッジ、クリーンアップの提案を表示します。

**UserPromptSubmit**（1つのフック）— あいまいなリクエストについて明確化を促します。

---

## 高度：外部プロバイダー

デフォルトでは、すべてのエージェントはClaudeのTask()経由で動作します。読み取り専用エージェント（スカウト、探偵など）をCodex/Geminiに委任するには：

```bash
/create-beads-orchestration --external-providers
```

Codex CLI（`codex login`）が必要で、オプションでGemini CLIおよび[uv](https://github.com/astral-sh/uv)が必要です。

---

## ライセンス

MIT

## クレジット

- [beads](https://github.com/steveyegge/beads) — Steve YeggeによるGitネイティブのタスクトラッキング
- [sub-agents.directory](https://github.com/ayush-that/sub-agents.directory) — 外部エージェントテンプレート


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-28

---