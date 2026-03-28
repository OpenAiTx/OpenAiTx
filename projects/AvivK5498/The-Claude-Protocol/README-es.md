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

**El orquestador** investiga, discute contigo y planifica. Nunca escribe código. Los prompts de despacho se registran automáticamente en el bead para que nada se pierda.

**Supervisores** se crean automáticamente según tu pila tecnológica. Leen los comentarios del bead para contexto completo, trabajan en worktrees aislados y envían PRs limpias.

**Beads** son tickets nativos de git. Cada tarea, cada épica, cada dependencia — rastreadas en tu repositorio, no en un servicio externo. Un bead = una unidad de trabajo = un worktree = un PR.

### Flujo de trabajo

**Independiente** — Investigar → planificar → aprobar → crear bead → despachar supervisor → worktree → PR → fusionar.

**Épicas** — Trabajo entre dominios (BD + API + frontend) se convierte en una épica con dependencias hijas obligatorias. Cada hijo tiene su propio worktree. Las dependencias evitan despachos fuera de orden.

**Corrección rápida** — Para cambios triviales (<10 líneas), el orquestador puede editar directamente en una rama de función. El hook solicita la aprobación del usuario con nombre de archivo y tamaño del cambio. Bloqueado en main — debe usarse el flujo de beads allí.

Cada tarea pasa por beads — a menos que el usuario apruebe explícitamente una corrección rápida.

### UI Kanban

El Protocolo Claude se combina con la [UI Kanban de Beads](https://github.com/AvivK5498/Beads-Kanban-UI) para gestión visual de tareas y GitOps directamente desde el navegador. Rastrea épicas, subtareas, dependencias y estado de PR en columnas — sin salir del tablero.

---

## Comenzando

```bash
npx skills add AvivK5498/The-Claude-Protocol
```
O a través de npm:


```bash
npm install -g beads-orchestration
```

Entonces, en cualquier sesión de Claude Code:

```bash
/create-beads-orchestration
```
La habilidad te guía en la configuración, escanea tu pila tecnológica y crea supervisores con las mejores prácticas integradas.

### Requisitos

- Claude Code con soporte para hooks  
- Node.js (para npx)  
- Python 3 (para bootstrap)  
- CLI beads (instalado automáticamente)  

---

## Qué Hace Esto Diferente

### Aplicación, No Sugerencias

13 hooks en 5 eventos del ciclo de vida. No advierten — bloquean. El orquestador no puede editar código en main. Los supervisores no pueden saltarse beads. Las épicas no pueden cerrarse con hijos abiertos. `git commit --no-verify` está bloqueado — los hooks pre-commit siempre se ejecutan.

### Investigación Primero, Restricciones Como Guía

El orquestador debe leer el archivo fuente real antes de delegar — no adivina. Las restricciones ("nunca despachar sin leer la fuente") superan las instrucciones ("recuerda investigar"), inspirado por la investigación multi-agente de [Cursor](https://cursor.com/blog/self-driving-codebases). El orquestador también mantiene memoria persistente entre sesiones.

### Documentación Que Se Escribe Sola

Cada prompt de despacho del supervisor se captura automáticamente como comentario bead. Los agentes registran voluntariamente convenciones y advertencias en una base de conocimiento persistente. Al iniciar la sesión, se muestra conocimiento reciente para que los agentes no vuelvan a investigar problemas ya resueltos.


```bash
# Agent captures an insight
bd comment BD-001 "LEARNED: TaskGroup requires @Sendable closures in strict concurrency mode."

# Search the knowledge base
.beads/memory/recall.sh "concurrency"
```

### Seguimiento de Trazabilidad

Los beads cerrados son inmutables. Las correcciones de errores se convierten en nuevos beads vinculados mediante `bd dep relate` — historial completo, sin reabrir. Las ramas fusionadas no se reutilizan. Cada corrección tiene su propio worktree y PR.

---

## Qué se instala

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

## Hooks

13 hooks hacen cumplir cada paso del flujo de trabajo. Bloquean antes de que ocurran acciones erróneas, registran automáticamente después de acciones correctas y validan antes de que los supervisores salgan.

**PreToolUse** (7 hooks) — Bloquea al orquestador de escribir código en main. Solicita aprobación de corrección rápida en ramas de funciones. Bloquea `--no-verify` en commits. Permite escrituras de archivos en memoria. Requiere cuentas para el despacho de supervisores. Hace cumplir el aislamiento del árbol de trabajo. Bloquea el cierre de épicos con hijos abiertos. Hace cumplir el despacho secuencial de dependencias.

**PostToolUse** (3 hooks) — Registra automáticamente los mensajes de despacho como comentarios de cuentas. Captura entradas de la base de conocimientos. Hace cumplir respuestas concisas de supervisores.

**SubagentStop** (1 hook) — Verifica que el árbol de trabajo exista, que el código esté empujado y que el estado de la cuenta esté actualizado.

**SessionStart** (1 hook) — Muestra el estado de la tarea, conocimientos recientes y sugerencias de limpieza.

**UserPromptSubmit** (1 hook) — Solicita aclaración en solicitudes ambiguas.

---

## Avanzado: Proveedores Externos

Por defecto, todos los agentes se ejecutan mediante Task() de Claude. Para delegar agentes solo de lectura (explorador, detective, etc.) a Codex/Gemini:

```bash
/create-beads-orchestration --external-providers
```

Requiere Codex CLI (`codex login`), opcionalmente Gemini CLI, y [uv](https://github.com/astral-sh/uv).

---

## Licencia

MIT

## Créditos

- [beads](https://github.com/steveyegge/beads) — Seguimiento de tareas nativo de Git por Steve Yegge
- [sub-agents.directory](https://github.com/ayush-that/sub-agents.directory) — Plantillas de agentes externos


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-28

---