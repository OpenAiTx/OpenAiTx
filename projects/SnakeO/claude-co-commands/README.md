# Claude Co-Commands Plugin

3 collaboration commands for Claude Code that use the [Codex MCP server](https://github.com/openai/codex) to generate parallel plans, validate plans, and brainstorm ideas.

## Commands

| Command | Description | When to Use |
|---------|-------------|-------------|
| `/co-brainstorm` | Bounce ideas off Codex | Want fast alternative ideas, critiques, and perspectives |
| `/co-plan` | Generate a parallel plan via Codex | Want a second opinion on your planning approach |
| `/co-validate` | Get a staff engineer review of your plan | Want critical feedback before finalizing a plan |

## Prerequisites

- [Node.js](https://nodejs.org/) (for `npx`)
- [Claude Code](https://docs.anthropic.com/en/docs/claude-code)

## Installation

### Option 1: Plugin Marketplace (Recommended)

```bash
# Add the marketplace
/plugin marketplace add SnakeO/claude-co-commands

# Install the plugin
/plugin install co-commands@snakeo-co-commands
```

### Option 2: Git Clone

```bash
git clone https://github.com/SnakeO/claude-co-commands.git
# Copy skill folders to ~/.claude/skills/
cp -r claude-co-commands/plugins/co-commands/skills/* ~/.claude/skills/
```

### Option 3: Manual Copy

Copy `plugins/co-commands/skills/` contents to `~/.claude/skills/`.

## MCP Server Setup (Required)

These commands require the Codex MCP server.

### Option A: CLI (Recommended)

```bash
claude mcp add validate-plans-and-brainstorm-ideas -- npx -y @openai/codex mcp-server
```

### Option B: Manual

Add this to the `mcpServers` object in `~/.claude.json`:

```json
"validate-plans-and-brainstorm-ideas": {
  "command": "npx",
  "args": ["-y", "@openai/codex", "mcp-server"]
}
```

If you already have entries in `mcpServers`, merge this as an additional key. Do not overwrite existing servers.

### Verify

1. Restart Claude Code (if you edited `~/.claude.json` manually).
2. Run `claude mcp list` to confirm the server is registered.
3. Test with `/co-brainstorm test idea` and confirm it triggers the MCP call.

## Command Details

### `/co-brainstorm`

Starts an interactive brainstorming session with Codex. Pass your topic or question as the argument.

```
/co-brainstorm how should we structure the authentication system
```

Supports follow-up conversation to dig deeper into ideas.

### `/co-plan`

Generates an alternative plan in the background while you continue your own planning. Pass your task description as the argument.

```
/co-plan add user authentication with OAuth2 support
```

Compare the Codex plan against yours to catch missed approaches, simpler alternatives, or overlooked edge cases.

### `/co-validate`

Sends your plan to Codex for a staff-engineer-style review. Pass the path to your plan file.

```
/co-validate .claude/plans/my-plan.md
```

Returns critical issues, simplification opportunities, and alternative approaches. Supports back-and-forth discussion.

## Troubleshooting

| Problem | Solution |
|---------|----------|
| `npx: command not found` | Install [Node.js](https://nodejs.org/) which includes npm/npx |
| MCP tool not found in session | Verify the server name is exactly `validate-plans-and-brainstorm-ideas` in `~/.claude.json` |
| JSON parse errors in `~/.claude.json` | Validate your JSON (check commas and braces) |
| Commands not appearing after install | Restart Claude Code and verify skill folders exist |

## License

MIT
