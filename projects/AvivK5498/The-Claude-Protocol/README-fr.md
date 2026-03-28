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

**L'orchestrateur** enquête, discute avec vous et planifie. Il n'écrit jamais de code. Les invites de dispatch sont automatiquement enregistrées dans le bead pour ne rien perdre.

**Les superviseurs** sont créés automatiquement en fonction de votre stack technologique. Ils lisent les commentaires du bead pour un contexte complet, travaillent dans des worktrees isolés, et poussent des PR propres.

**Les Beads** sont des tickets natifs git. Chaque tâche, chaque épique, chaque dépendance — suivie dans votre dépôt, pas un service tiers. Un bead = une unité de travail = un worktree = une PR.

### Flux de travail

**Indépendant** — Enquêter → planifier → approuver → créer un bead → dispatcher un superviseur → worktree → PR → fusionner.

**Épiques** — Le travail inter-domaines (BD + API + frontend) devient un épique avec des dépendances enfants imposées. Chaque enfant obtient son propre worktree. Les dépendances empêchent le dispatch dans le désordre.

**Correction rapide** — Pour les changements triviaux (<10 lignes), l'orchestrateur peut éditer directement sur une branche de fonctionnalité. Le hook demande à l'utilisateur une approbation avec le nom du fichier et la taille du changement. Strictement bloqué sur main — il faut utiliser le flux de beads là-bas.

Chaque tâche passe par les beads — sauf si l'utilisateur approuve explicitement une correction rapide.

### Interface Kanban

Le protocole Claude s'associe avec l’[interface Kanban Beads](https://github.com/AvivK5498/Beads-Kanban-UI) pour la gestion visuelle des tâches et GitOps directement depuis le navigateur. Suivez les épiques, sous-tâches, dépendances et l'état des PR à travers les colonnes — sans quitter le tableau.

---

## Pour commencer

```bash
npx skills add AvivK5498/The-Claude-Protocol
```

Ou via npm :

```bash
npm install -g beads-orchestration
```

Puis dans toute session Claude Code :

```bash
/create-beads-orchestration
```

La compétence vous guide dans la configuration, analyse votre pile technologique et crée des superviseurs avec les meilleures pratiques intégrées.

### Exigences

- Claude Code avec support des hooks
- Node.js (pour npx)
- Python 3 (pour bootstrap)
- CLI beads (installé automatiquement)

---

## Ce qui rend cela différent

### Application, pas des suggestions

13 hooks répartis sur 5 événements du cycle de vie. Ils ne préviennent pas — ils bloquent. L'orchestrateur ne peut pas modifier le code sur main. Les superviseurs ne peuvent pas ignorer beads. Les epics ne peuvent pas se fermer avec des enfants ouverts. `git commit --no-verify` est bloqué — les hooks pre-commit s’exécutent toujours.

### Priorité à l’investigation, piloté par les contraintes

L'orchestrateur doit lire le fichier source réel avant de déléguer — pas de devinette. Les contraintes (« ne jamais dispatcher sans lire la source ») surpassent les instructions (« pensez à enquêter »), inspirées par la recherche multi-agent de [Cursor](https://cursor.com/blog/self-driving-codebases). L'orchestrateur conserve aussi une mémoire persistante entre les sessions.

### Documentation qui s’écrit toute seule

Chaque prompt d’envoi du superviseur est automatiquement capturé comme un commentaire bead. Les agents consignent volontairement les conventions et pièges dans une base de connaissances persistante. Le démarrage de session affiche les connaissances récentes pour éviter aux agents de réinvestiguer des problèmes déjà résolus.

```bash
# Agent captures an insight
bd comment BD-001 "LEARNED: TaskGroup requires @Sendable closures in strict concurrency mode."

# Search the knowledge base
.beads/memory/recall.sh "concurrency"
```

### Traçabilité de suivi

Les perles fermées sont immuables. Les corrections de bugs deviennent de nouvelles perles liées via `bd dep relate` — historique complet, sans réouverture. Les branches fusionnées ne sont pas réutilisées. Chaque correction obtient son propre worktree et PR.

---

## Ce qui est installé

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

13 hooks appliquent à chaque étape du flux de travail. Ils bloquent avant que des actions incorrectes ne se produisent, enregistrent automatiquement après les bonnes actions, et valident avant la sortie des superviseurs.

**PreToolUse** (7 hooks) — Bloque l'orchestrateur d'écrire du code sur la branche principale. Demande l'approbation d'une correction rapide sur les branches de fonctionnalités. Bloque `--no-verify` sur les commits. Autorise les écritures dans les fichiers mémoire. Exige des beads pour la répartition des superviseurs. Implique l'isolation des worktrees. Bloque la fermeture des epics avec des enfants ouverts. Implique une répartition séquentielle des dépendances.

**PostToolUse** (3 hooks) — Enregistre automatiquement les invites de répartition comme commentaires de beads. Capture les entrées de la base de connaissances. Implique des réponses concises des superviseurs.

**SubagentStop** (1 hook) — Vérifie que le worktree existe, que le code est poussé, que le statut du bead est mis à jour.

**SessionStart** (1 hook) — Affiche le statut des tâches, les connaissances récentes, et les suggestions de nettoyage.

**UserPromptSubmit** (1 hook) — Demande des clarifications sur les requêtes ambiguës.

---

## Avancé : Fournisseurs externes

Par défaut, tous les agents s'exécutent via Task() de Claude. Pour déléguer des agents en lecture seule (éclaireur, détective, etc.) à Codex/Gemini :

```bash
/create-beads-orchestration --external-providers
```

Nécessite Codex CLI (`codex login`), éventuellement Gemini CLI, et [uv](https://github.com/astral-sh/uv).

---

## Licence

MIT

## Crédits

- [beads](https://github.com/steveyegge/beads) — Suivi des tâches natif Git par Steve Yegge
- [sub-agents.directory](https://github.com/ayush-that/sub-agents.directory) — Modèles d’agents externes


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-28

---