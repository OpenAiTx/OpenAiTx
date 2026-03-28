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
**오케스트레이터**는 조사하고, 사용자와 논의하며 계획을 세웁니다. 코드를 작성하지 않습니다. 디스패치 프롬프트는 자동으로 비드에 기록되어 어떤 것도 잃어버리지 않습니다.

**슈퍼바이저**는 기술 스택을 기반으로 자동 생성됩니다. 비드 코멘트를 읽어 전체 문맥을 파악하고, 격리된 워크트리에서 작업하며 깔끔한 PR을 푸시합니다.

**비드**는 git-네이티브 티켓입니다. 모든 작업, 모든 에픽, 모든 의존성이 타사 서비스가 아닌 리포지토리에서 추적됩니다. 하나의 비드 = 하나의 작업 단위 = 하나의 워크트리 = 하나의 PR.

### 워크플로우

**독립형** — 조사 → 계획 → 승인 → 비드 생성 → 슈퍼바이저 디스패치 → 워크트리 → PR → 병합.

**에픽** — 크로스 도메인 작업(DB + API + 프론트엔드)은 자식 의존성이 강제된 에픽이 됩니다. 각 자식은 자체 워크트리를 가집니다. 의존성은 순서 외 디스패치를 방지합니다.

**빠른 수정** — 사소한 변경(<10줄)은 오케스트레이터가 기능 브랜치에서 직접 수정할 수 있습니다. 훅이 파일명과 변경 크기로 사용자 승인을 요청합니다. 메인에서는 하드 블록되어 비드 워크플로우를 사용해야 합니다.

모든 작업은 비드를 거칩니다 — 사용자가 빠른 수정을 명시적으로 승인하지 않는 한.

### 칸반 UI

클로드 프로토콜은 [Beads Kanban UI](https://github.com/AvivK5498/Beads-Kanban-UI)와 연동되어 브라우저에서 시각적 작업 관리와 GitOps를 제공합니다. 에픽, 하위 작업, 의존성, PR 상태를 칸반 보드에서 직접 추적하세요 — 보드를 벗어나지 않고도 가능합니다.

---

## 시작하기


```bash
npx skills add AvivK5498/The-Claude-Protocol
```
또는 npm을 통해:


```bash
npm install -g beads-orchestration
```

그런 다음 모든 Claude Code 세션에서:

```bash
/create-beads-orchestration
```
스킬은 설정 과정을 안내하고, 기술 스택을 스캔하며, 최선의 관행이 주입된 감독자를 생성합니다.

### 요구 사항

- 훅 지원이 포함된 Claude Code
- Node.js (npx용)
- Python 3 (부트스트랩용)
- beads CLI (자동 설치)

---

## 차별점

### 제안이 아닌 강제

5가지 라이프사이클 이벤트에서 13개의 훅이 작동합니다. 경고하지 않고 차단합니다. 오케스트레이터는 메인에서 코드를 편집할 수 없습니다. 감독자는 beads를 건너뛸 수 없습니다. 에픽은 열린 하위 항목이 있으면 종료할 수 없습니다. `git commit --no-verify`는 차단되며, 사전 커밋 훅은 항상 실행됩니다.

### 조사 우선, 제약 조건 기반

오케스트레이터는 위임 전에 실제 소스 파일을 반드시 읽어야 하며, 추측하지 않습니다. 제약 조건("소스를 읽지 않고는 절대 디스패치하지 말 것")은 지시사항("조사하는 것을 기억하라")보다 우수하며, 이는 [Cursor의 다중 에이전트 연구](https://cursor.com/blog/self-driving-codebases)에서 영감을 받았습니다. 오케스트레이터는 세션 간 지속 메모리도 유지합니다.

### 스스로 작성되는 문서

모든 감독자 디스패치 프롬프트는 자동으로 bead 주석으로 캡처됩니다. 에이전트는 자발적으로 규약과 주의사항을 지속 지식 베이스에 기록합니다. 세션 시작 시 최근 지식이 표시되어 에이전트가 이미 해결된 문제를 재조사하지 않습니다.


```bash
# Agent captures an insight
bd comment BD-001 "LEARNED: TaskGroup requires @Sendable closures in strict concurrency mode."

# Search the knowledge base
.beads/memory/recall.sh "concurrency"
```

### 후속 추적성

닫힌 비드는 변경 불가능합니다. 버그 수정은 `bd dep relate`를 통해 연결된 새로운 비드가 됩니다 — 전체 이력 유지, 재개방 없음. 병합된 브랜치는 재사용되지 않습니다. 각 수정은 자체 작업 트리와 PR을 가집니다.

---

## 설치되는 항목

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

## 후크(Hooks)

13개의 후크가 모든 워크플로우 단계를 강제합니다. 나쁜 작업이 발생하기 전에 차단하고, 좋은 작업 후에는 자동으로 기록하며, 감독자가 종료하기 전에 검증합니다.

**PreToolUse** (7개 후크) — 오케스트레이터가 메인에 코드를 작성하지 못하도록 차단합니다. 기능 브랜치에서는 빠른 수정 승인을 요청합니다. 커밋 시 `--no-verify` 옵션을 차단합니다. 메모리 파일 쓰기는 허용합니다. 감독자 디스패치에는 비즈(beads)를 요구합니다. 작업 트리 격리를 강제합니다. 열린 하위 작업이 있는 에픽 종료를 차단합니다. 순차적 의존성 디스패치를 강제합니다.

**PostToolUse** (3개 후크) — 디스패치 프롬프트를 비즈 댓글로 자동 기록합니다. 지식 기반 항목을 캡처합니다. 간결한 감독자 응답을 강제합니다.

**SubagentStop** (1개 후크) — 작업 트리가 존재하는지, 코드가 푸시되었는지, 비즈 상태가 업데이트되었는지 확인합니다.

**SessionStart** (1개 후크) — 작업 상태, 최근 지식, 정리 제안을 표시합니다.

**UserPromptSubmit** (1개 후크) — 모호한 요청에 대해 명확화를 요청합니다.

---

## 고급: 외부 제공자

기본적으로 모든 에이전트는 Claude의 Task()를 통해 실행됩니다. 읽기 전용 에이전트(스카우트, 탐정 등)를 Codex/Gemini에 위임하려면:

```bash
/create-beads-orchestration --external-providers
```

Requires Codex CLI (`codex login`), optionally Gemini CLI, and [uv](https://github.com/astral-sh/uv).

---

## 라이선스

MIT

## 크레딧

- [beads](https://github.com/steveyegge/beads) — Steve Yegge의 Git-기반 작업 추적
- [sub-agents.directory](https://github.com/ayush-that/sub-agents.directory) — 외부 에이전트 템플릿


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-28

---