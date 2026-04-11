# PM Claude Code Setup

[![Stars](https://img.shields.io/github/stars/aakashg/pm-claude-code-setup?style=flat-square)](https://github.com/aakashg/pm-claude-code-setup/stargazers)
[![License](https://img.shields.io/github/license/aakashg/pm-claude-code-setup?style=flat-square)](LICENSE)

A production-ready Claude Code configuration for product managers. Drop these files into your project and Claude Code immediately understands PM work.

Includes a `CLAUDE.md` context file, 6 PM skills, and 4 templates. Takes 60 seconds to set up.

**This setup works standalone. The full PM Operating System goes further: 41+ skills, 7 sub-agent perspectives, a complete context library, launch templates, and sprint planning workflows refined over 100+ iterations.**

**[Get the full PM Operating System →](https://www.news.aakashg.com/p/pm-os)**

---

## What's Inside

```
pm-claude-code-setup/
├── CLAUDE.md                           # Master context file — drop in your project root
├── templates/
│   ├── prd-template.md                 # Blank PRD structure
│   ├── launch-plan.md                  # Launch planning template
│   ├── okr-template.md                 # OKR scorecard
│   └── sprint-review.md               # Sprint review template
└── .claude/
    └── skills/
        ├── prd-writer/                 # "write a PRD" → structured PRD with clarifying questions
        ├── competitive-analysis/       # "analyze competitor" → smart/weak/implications framework
        ├── launch-checklist/           # "launch checklist" → risk-scaled pre/post launch plan
        ├── metrics-definer/            # "define metrics" → primary, guardrail, and anti-metrics
        ├── sprint-planner/             # "plan sprint" → capacity-checked sprint with risks
        └── user-research/              # "synthesize research" → evidence-ranked findings
```

## Quick Setup

**Step 1:** Copy `CLAUDE.md` to your project root:
```bash
cp CLAUDE.md /path/to/your/project/
```

**Step 2:** Copy the skills folder:
```bash
cp -r .claude/ /path/to/your/project/
```

**Step 3:** Open Claude Code in your project. It loads automatically.

Done. Claude now knows you're a PM, follows your writing style, and writes PRDs on command.

## What the CLAUDE.md Does

`CLAUDE.md` is a lean config file — not a manual. It tells Claude who you are, how to write, and what rules to follow. Fill in the `[FILL IN]` fields at the top (~2 minutes), and the rest works immediately:

- **Your context** — role, product, metrics, OKRs, terminology
- **Writing rules** — enforced tone, banned words, output standards
- **Sub-agent roles** — 6 reviewers in a table (engineer, designer, executive, skeptic, customer, data analyst)
- **Output standards** — clarifying questions before generating, metrics with baselines, risks with mitigations
- **Skills reference** — points to `.claude/skills/` without duplicating their logic
- **MCP connections** — your integrations (Notion, Jira, Slack, etc.)

The file is intentionally under 60 lines. Claude follows short, specific instructions better than long ones.

## What the PRD Writer Skill Does

Say "write a PRD" or "create a PRD for [feature]" and Claude:

1. Asks 3-5 clarifying questions first (never generates blind)
2. Follows a structured format: hypothesis, problem, solution, metrics, non-goals
3. Flags missing info with `[NEED: data from X]` placeholders
4. Keeps it under 2 pages unless you ask for more
5. Includes success metrics with specific numbers and guardrails

## How to Get the Most Out of This Setup

### Chain Sub-Agents

Write a PRD → "Review as engineer" → fix gaps → "Review as skeptic" → tighten assumptions → "Review as customer" → simplify the value prop. Three passes, three minutes, dramatically better spec.

### Use @ References

Don't paste docs into chat — point to them:

```
Read @templates/prd-template.md and use that structure.
Summarize @meeting-notes/standup-03-04.md into action items.
Compare @competitor-notes/notion.md against @competitor-notes/monday.md.
```

Claude reads the file on demand. Your context window stays clean.

### Use Plan Mode (Shift+Tab)

Toggle before complex tasks. Forces Claude to outline its approach before executing. You approve the plan, then it runs. Best for PRDs with open questions, multi-file edits, anything where "undo" is expensive.

### Set Up Hooks

Unlike CLAUDE.md instructions (advisory), hooks run deterministically:

```
"Write a hook that spell-checks every file after I edit it"
"Write a hook that blocks writes to /templates/"
"Write a hook that runs a word count check — block any PRD over 1500 words"
```

Configure via `/hooks` or `.claude/settings.json`. Exit code 0 = proceed, exit code 2 = block with feedback.

### Session Management

- **`/clear` between unrelated tasks.** Context bleed is the #1 quality killer.
- **Cap conversations at ~50 exchanges.** Quality degrades past this.
- **Use handoffs.** Before ending a long session: "Write a HANDOFF.md." Next session: "Read @HANDOFF.md and continue."
- **Run parallel sessions.** Multiple terminals, each with its own Claude instance and context window.
- **Resume sessions.** `claude --continue` for last session, `claude --resume` to pick from history.

### Make CLAUDE.md Self-Improving

When Claude makes a mistake, correct it, then: "Add a rule to CLAUDE.md so you don't make that mistake again." Claude proposes the rule, you approve, it edits the file. Next session, the rule is loaded automatically. Prune quarterly.

### Customize the Skills

Skills ship with generic examples. Replace them with real examples from your product. A sprint planner that knows your team's velocity outperforms a generic one every time.

### Feed in Real Artifacts

Don't describe your Slack thread — paste it. Don't summarize the user interview — paste the transcript. Skills extract and structure messy information; raw inputs produce the best output.

### Quick Reference

```
/clear              Reset context (CLAUDE.md reloads automatically)
/hooks              Configure automation hooks
/init               Generate a starter CLAUDE.md from your project
/permissions        Set tool access rules
Shift+Tab           Toggle Plan Mode
Esc                 Cancel current generation
claude --continue   Resume last session
claude --resume     Pick a specific past session
claude -p "prompt"  Non-interactive single prompt
```

---

## Want the Full Setup?

This setup covers the core PM workflow. The full PM OS covers every PM task I run daily:

- 41+ custom skills for every PM task
- 7 sub-agent perspectives (engineer, designer, executive, skeptic, customer, data analyst, legal)
- Context library with your OKRs, terminology, and team structure
- Templates for launches, roadmaps, retros, and sprint planning
- Hooks for automated spell-checking and file protection

**[Get the full PM Operating System →](https://www.news.aakashg.com/p/pm-os)**

---

Built by [Aakash Gupta](https://www.aakashg.com) | [Product Growth Newsletter](https://www.news.aakashg.com)

---

## Troubleshooting

Common issues and fixes.

### Claude doesn't seem to follow my CLAUDE.md instructions

- **Check file location.** CLAUDE.md must be in your project root (the directory where you run `claude`). Claude Code loads it automatically from the working directory.
- **Check file size.** Beyond ~150 lines, Claude starts ignoring instructions. Prune aggressively. Move domain knowledge into skills.
- **Check for conflicting instructions.** Contradictory rules produce unpredictable behavior. Audit for conflicts.
- **Restart the session.** Run `/clear` or start a new terminal. Claude loads CLAUDE.md at session start.

### Skills aren't triggering

- **Verify the path.** Skills must be at `.claude/skills/<skill-name>/SKILL.md` (exact casing matters).
- **Check the trigger.** The SKILL.md needs a clear trigger phrase that matches how you're asking. If your SKILL.md says "triggers when user asks to write a PRD" but you say "draft a spec," Claude may not connect them.
- **Test with an explicit request.** Try: "Use the prd-writer skill to write a PRD for X." If that works but natural language doesn't, refine your trigger description.
- **Check that SKILL.md isn't empty or malformed.** Open it and verify it has content.

### Claude forgets context mid-conversation

- **Context limits.** Long conversations degrade after ~50 exchanges. Use `/clear` and start fresh with a summary.
- **Use handoffs.** Before clearing, have Claude write a HANDOFF.md summarizing state, decisions, and next steps. Start the new session with "Read @HANDOFF.md and continue."
- **Avoid pasting huge docs.** Use `@` references instead of pasting entire documents into chat.

### Hooks aren't running

- **Check `.claude/settings.json`.** Hooks are configured there, not in CLAUDE.md.
- **Check exit codes.** Hooks use exit 0 (proceed) and exit 2 (block + feedback). Other exit codes may cause unexpected behavior.
- **Check permissions.** Hook scripts need to be executable (`chmod +x`).

### MCP servers won't connect

- **Verify credentials.** Most MCP servers require API keys or OAuth tokens. Confirm yours are current.
- **Check server config.** MCP connections are configured in Claude Code settings, not CLAUDE.md. CLAUDE.md only documents them for reference.
- **Restart Claude Code.** MCP connections initialize at startup.

### "I changed CLAUDE.md but nothing changed"

Claude reads CLAUDE.md at session start. Mid-session edits require a reload:
1. Run `/clear` to reset context (CLAUDE.md reloads automatically)
2. Or start a new terminal session
