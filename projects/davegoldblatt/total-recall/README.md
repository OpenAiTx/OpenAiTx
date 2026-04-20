# Total Recall

A memory system for Claude Code that remembers what matters and forgets what doesn't.

## The Problem

Claude Code forgets everything between sessions. Every time you start a new conversation, it's like talking to someone with amnesia. You end up repeating yourself:

- "We already tried that approach, it didn't work."
- "Don't touch the auth file."
- "I prefer tabs over spaces."
- "The client's name is Sarah, not Sara."

This gets old fast.

## What Total Recall Does

It gives Claude Code a notepad that carries over between sessions, but a *picky* notepad. Not everything goes in. Before anything gets saved permanently, it has to pass a simple test: **will this matter tomorrow?**

A preference you'll have for months? Saved. A decision you made and why? Saved. The fact that you ran a test five minutes ago? Not saved. The system keeps itself clean so Claude isn't wading through junk to find what's relevant.

## How It Works

Think of it like a kitchen with four storage areas:

**Counter** (`CLAUDE.local.md`): The stuff you reach for every day. Loads automatically, every session. Kept small on purpose, around a page of text.

**Pantry** (`memory/registers/`): Organized by category. Your preferences, key decisions, project details, people you work with. Claude checks here when it needs something specific.

**Daily notebook** (`memory/daily/`): Timestamped scratch notes from each day. Everything gets written here first. You decide later what's worth keeping permanently.

**Storage closet** (`memory/archive/`): Old stuff that's done or outdated. Still searchable, but never loaded automatically.

The key idea: **notes hit the daily notebook first, then you promote the keepers.** Claude doesn't get to decide on its own what's important enough to remember permanently. You do.

## Quick Start

### Install as a plugin (recommended)

```
/plugin marketplace add davegoldblatt/recall-marketplace
/plugin install recall@recall-marketplace
```

### Or install standalone

```
git clone https://github.com/davegoldblatt/total-recall.git
cd total-recall
./install.sh /path/to/your/project
```

After installing, restart Claude Code or run `/hooks` to activate.

## Using It

Here's your day-to-day:

**Claude notices something worth remembering.** It writes to your daily notebook and tells you. You don't have to do anything.

**You want Claude to remember something.** Just say "remember this" or use the write command:

```
/recall-write Dave prefers concise error messages, no stack traces in prod
```

**End of day (or whenever).** Review what piled up and promote the good stuff:

```
/recall-promote
```

**Find something from last week.** Search across everything:

```
/recall-search authentication decision
```

**You correct Claude.** The correction updates everywhere at once: daily notebook, registers, and the counter. The same mistake won't happen again.

### All Commands

| Command | What it does |
|---|---|
| `/recall-init` | Set up the memory folders for the first time |
| `/recall-write <note>` | Save a note (checks if it's worth keeping, suggests where) |
| `/recall-log <note>` | Quick note to the daily notebook, no questions asked |
| `/recall-search <query>` | Search everything |
| `/recall-promote` | Review daily notes, move the keepers to registers |
| `/recall-status` | Health check. Is everything working? |
| `/recall-maintain` | Clean up stale or duplicate entries |
| `/recall-forget <query>` | Mark something as outdated |
| `/recall-context` | Show what memory Claude has loaded right now |

If installed as a plugin, commands are namespaced: `/recall:recall-write` instead of `/recall-write`.

## The Write Gate

This is the core idea. Before anything gets promoted to permanent memory, it has to pass at least one of these checks:

1. **Will it change how Claude behaves next time?** (a preference, a boundary, a pattern)
2. **Is it a commitment someone's counting on?** (a deadline, a deliverable, a follow-up)
3. **Is it a decision worth remembering the reasoning for?** (why you picked X over Y)
4. **Is it a stable fact that'll come up again?** (not something that'll be different tomorrow)
5. **Did you explicitly say "remember this"?**

If none of those are true, it stays in the daily notebook and eventually ages out. This keeps memory lean. No junk drawer.

## When Corrections Happen

If you tell Claude it got something wrong, it doesn't just say "sorry" and move on. It updates the daily notebook, the relevant register, and the counter, all in one shot. The old information gets marked as superseded (not deleted) so there's a trail of what changed and when.

## What Loads Automatically

Only two things, every session:

| What | Where | How |
|---|---|---|
| The rules (write gate, correction protocol) | `rules/total-recall.md` | Claude Code loads all rules files automatically |
| Counter / working memory | `CLAUDE.local.md` | Claude Code loads this automatically |

Everything else loads on demand: when you search, when it's relevant, or at session start via hooks.

## Hooks

Two things happen automatically in the background:

**When a session starts:** Claude gets a summary of open items and recent daily notes. This is the "here's where we left off" briefing.

**Before memory gets compacted:** A timestamp gets written to the daily notebook so there's a record. This one is silent. Claude doesn't see it, it's just bookkeeping.

Both hooks fail safely. If something goes wrong, they don't block Claude Code from working.

Hooks use `$CLAUDE_PROJECT_DIR` (standalone) or `${CLAUDE_PLUGIN_ROOT}` (plugin) to resolve paths. No transcript parsing. The PreCompact hook only writes a timestamp marker to the daily log. It does not read or parse conversation transcripts.

## Architecture

For those who want the technical details.

```
Conversation (ephemeral, compacted/discarded)
    |
    v  WRITE GATE: "Does this change future behavior?"
    |
Daily Log (memory/daily/YYYY-MM-DD.md)
    All writes land here first. Raw, timestamped.
    |
    v  PROMOTION: user-controlled via /recall-promote
    |
Registers (memory/registers/*.md)
    Structured claims with metadata (confidence, evidence, last_verified)
    |
    v  DISTILLATION: only what's essential for every session
    |
Working Memory (CLAUDE.local.md)
    ~1500 words. Auto-loaded. The persistent "personality."
    |
    v  EXPIRY
    |
Archive (memory/archive/)
    Searchable history. Never auto-loaded.
```

### Key Mechanisms

**Write Gate:** Filters out noise. Only behavior-changing facts, commitments, decisions, and explicit "remember this" requests pass through.

**Daily Log First:** All writes land in the daily log. Promotion to registers is a separate step, controlled by the user. This prevents the model from prematurely solidifying inferences.

**Contradiction Protocol:** Never silently overwrites. Old claims are marked `[superseded]` with date and reason. The pattern of change is preserved.

**Correction Gate:** Human corrections get highest priority. One correction triggers writes to daily log + register + working memory.

### File Structure

**Plugin format** (installed via `/plugin install`):

```
total-recall/                     # Plugin root
├── .claude-plugin/
│   └── plugin.json               # Plugin manifest
├── skills/                       # Slash commands (namespaced)
│   ├── recall-write/SKILL.md
│   ├── recall-search/SKILL.md
│   └── ...
├── hooks/
│   ├── hooks.json                # Hook configuration
│   ├── session-start.sh
│   └── pre-compact.sh
├── rules/
│   └── total-recall.md           # Protocol (auto-loaded)
└── templates/                    # Scaffolding templates
    ├── SCHEMA.md
    ├── CLAUDE.local.md
    └── registers/
```

**Standalone format** (installed via `install.sh`):

```
your-project/
├── .claude/
│   ├── commands/recall-*.md      # Slash commands
│   ├── rules/total-recall.md     # Protocol (auto-loaded)
│   ├── hooks/*.sh                # Hook scripts
│   └── settings.local.json       # Hook configuration
├── memory/
│   ├── SCHEMA.md
│   ├── daily/YYYY-MM-DD.md
│   ├── registers/*.md
│   └── archive/
├── CLAUDE.md
└── CLAUDE.local.md               # Working memory (gitignored)
```

### Compared to Other Memory Tools

|  | Total Recall | Auto-ingest tools |
|---|---|---|
| **What gets saved** | Only what passes the write gate | Everything |
| **Default destination** | Daily log (promote later) | Permanent storage |
| **Context cost** | ~1500 words working memory | Grows unbounded |
| **Corrections** | Propagate to all tiers immediately | Varies |
| **User control** | Promotion is explicit | Automatic |
| **Architecture** | 4-tier with metadata | Flat or 2-tier |

## Privacy

- Everything is local. No network calls, no telemetry, no external services.
- All memory is plain markdown files you can read and edit yourself.
- `CLAUDE.local.md` is gitignored by default (it's personal).
- `memory/` is gitignored by default (it can contain personal notes).
- Hooks never read your conversation transcripts.
- To see exactly what's happening: check `hooks/*.sh` and `memory/`. It's all plain text.
- To uninstall: delete `memory/`, `CLAUDE.local.md`, and the `.claude/` entries (or `/plugin uninstall recall`).

## Works Alongside Superpowers

If you use [Superpowers](https://github.com/obra/superpowers), there are no conflicts. Superpowers handles *how* Claude works (methodology, TDD, plans). Total Recall handles *what* Claude remembers. Different jobs, same project.

## License

MIT
