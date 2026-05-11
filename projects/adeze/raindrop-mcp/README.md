# Raindrop.io MCP Server

[![smithery badge](https://smithery.ai/badge/@adeze/raindrop-mcp)](https://smithery.ai/server/@adeze/raindrop-mcp)
[![npm version](https://badge.fury.io/js/%40adeze%2Fraindrop-mcp.svg)](https://www.npmjs.com/package/@adeze/raindrop-mcp)
[![Claude Desktop MCPB](https://img.shields.io/badge/Claude%20Desktop-MCPB-5B61FF?logo=claude&logoColor=white)](https://github.com/adeze/raindrop-mcp/releases)

Connect Raindrop.io to your AI assistant with a simple MCP server. Use it to organize, search, and manage bookmarks with natural language.

## What it can do

- Create, update, and delete collections and bookmarks
- Search bookmarks by tags, domain, type, date, and more
- Manage tags (list, rename, merge, delete)
- Read highlights from bookmarks
- Bulk edit bookmarks in a collection
- Audit broken links and duplicates, and manage trash

## Tools

- **diagnostics** - Server diagnostic information and library health metrics
- **collection_list** - List all collections as a flat list
- **get_collection_tree** - Hierarchical view of collections with full breadcrumb paths
- **collection_manage** - Create, update, or delete collections
- **bookmark_search** - Advanced search with filters, tags, and pagination
- **bookmark_manage** - Create, update, or delete bookmarks
- **get_raindrop** - Fetch a single bookmark by ID
- **list_raindrops** - List bookmarks for a collection with pagination
- **get_suggestions** - AI-powered organization advice (tags/collections) for a URL or bookmark
- **suggest_tags** - Suggest relevant tags from bookmark metadata using AI-assisted analysis
- **bulk_edit_raindrops** - Bulk update, move, or remove bookmarks in a specific collection
- **tag_manage** - Rename, merge, or delete tags
- **highlight_manage** - Create, update, or delete highlights
- **library_audit** - Scan library for broken links, duplicates, and untagged items
- **empty_trash** - Permanently empty the trash (requires confirmation)
- **cleanup_collections** - Remove empty collections (requires confirmation)
- **remove_duplicates** - Find and remove duplicate bookmarks with safe confirmation flow

## Install

### Quick Start (One-Liners)

| Tool               | One-Liner Command                                                  |
| :----------------- | :----------------------------------------------------------------- |
| **Gemini CLI**     | `gemini extensions install https://github.com/adeze/raindrop-mcp`  |
| **Codex CLI**      | `codex mcp add raindrop -- npx -y @adeze/raindrop-mcp`             |
| **Claude Code**    | `claude mcp add raindrop -- npx -y @adeze/raindrop-mcp`            |
| **GitHub Copilot** | `gh copilot config mcp add raindrop -- npx -y @adeze/raindrop-mcp` |
| **Vercel Skills**  | `npx skills add adeze/raindrop-mcp`                                |

> **Note**: For tools adding an MCP server via `npx`, you must have the `RAINDROP_ACCESS_TOKEN` environment variable set in your shell or the tool's environment config.

### Vercel Skills (npx skills)

This project is compatible with the [Vercel Skills](https://github.com/vercel/skills) system. All necessary manifests are present:

- `manifest.json`: Standard MCP manifest for server definition.
- `SKILL.md`: Standardized skill description for agent discovery.
- `mcp.json`: Root configuration for MCP clients and registries.

To add this server to your local skill directory:

```bash
npx skills add adeze/raindrop-mcp --global
```

To contribute this to the [Vercel Skills Registry](https://github.com/vercel/skills/tree/main/registry), submit a Pull Request adding this repository URL to the registry.

### Claude Desktop (MCPB)

Download the latest raindrop-mcp.mcpb from the GitHub Release and add it to Claude Desktop:

- Releases: https://github.com/adeze/raindrop-mcp/releases

In Claude Desktop, add the bundle and set this environment variable:

- RAINDROP_ACCESS_TOKEN (from your Raindrop.io integrations settings)

### NPX (CLI)

Set your API token as an environment variable and run:

```bash
export RAINDROP_ACCESS_TOKEN=YOUR_RAINDROP_ACCESS_TOKEN
npx @adeze/raindrop-mcp
```

### Manual MCP config (mcp.json)

Add this to your MCP client configuration:

```json
{
  "servers": {
    "raindrop": {
      "type": "stdio",
      "command": "npx",
      "args": ["@adeze/raindrop-mcp@latest"],
      "env": {
        "RAINDROP_ACCESS_TOKEN": "YOUR_RAINDROP_ACCESS_TOKEN"
      }
    }
  }
}
```

## Requirements

- A Raindrop.io account
- A Raindrop.io API Access Token: https://app.raindrop.io/settings/integrations

## Support

- Issues: https://github.com/adeze/raindrop-mcp/issues

## Release

This repository uses `semantic-release` as the only supported release flow.

### How publishing works

- Releases run from pushes to `master` via `.github/workflows/ci.yml`.
- `semantic-release` analyzes Conventional Commit messages, computes the next version, updates `CHANGELOG.md`, tags/releases on GitHub, and publishes npm.
- During release preparation, `.releaserc.json` syncs `manifest.json`, `mcp.json`, and `gemini-extension.json`, then builds `raindrop-mcp.mcpb` so the GitHub Release includes the bundle.

### Pre-release dry-run

- Run `.github/workflows/release-dry-run.yml` with **Run workflow** before cutting a public release.
- This validates semantic version calculation, registry auth, and release pipeline behavior without publishing.

### Required secrets

- `GITHUB_TOKEN` is provided by GitHub Actions for release automation.

### npm trusted publishing

- npm publishing is configured via GitHub Actions OIDC trusted publishing.
- `NPM_TOKEN` is not required for the standard CI release path.

### Local validation before merge

```bash
bun run lint
bun run type-check
bun run test
bun run build
```

### Commit message examples

- `fix: handle empty tag merge payload`
- `feat: add collection path filter`
- `feat!: remove deprecated search parameter`

Do not manually bump versions, push release tags, or run manual npm publish commands for normal releases.

## 📋 Recent Enhancements (v2.4.x)

### Smart Organization & Hierarchy

- **AI Suggestions**: New `get_suggestions` tool provides organizational advice using Raindrop's API and MCP Sampling.
- **Collection Tree**: `get_collection_tree` tool provides a hierarchical view with full breadcrumb paths.
- **Bulk Move**: Added `move` operation to `bulk_edit_raindrops` for efficient library organization.
- **Pagination Support**: Standardized `list_raindrops` and `bookmark_search` with pagination for large libraries.

### Safety & Quality

- **Confirmation Logic**: Destructive tools (`empty_trash`, `cleanup_collections`) now require explicit confirmation.
- **Standardized Naming**: All tools now use consistent snake_case naming conventions.
- **CI/CD Pipeline**: Enhanced GitHub Actions with automated linting, type-checking, and cross-transport tests.
- **Code Quality**: Established ESLint and Prettier configurations for maintainable development.

## 📋 Previous Enhancements (v2.3.3)

### Advanced Cleanup & Library Audit

## 📋 Previous Enhancements (v2.3.2)

### MCP Resource Links Implementation

- Modern `resource` content following current MCP SDK best practices
- Efficient data access: tools return lightweight links instead of full payloads
- Better performance: clients fetch full bookmark/collection data only when needed
- Seamless integration with dynamic resource system (`mcp://raindrop/{id}`)

### SDK & API Updates

- Updated to the latest supported MCP SDK in this repository
- Modern tool registration with improved descriptions
- Fixed API endpoints and path parameters
- All core tools fully functional

### Tool Optimization

- Resource-efficient responses for bookmark/collection lists
- Dynamic resource access via `mcp://collection/{id}` and `mcp://raindrop/{id}`
- Better client UX with lighter list payloads
- Full MCP compliance with official SDK patterns

### Service Layer Improvements

- Reduced code through extracted common helpers
- Consistent error handling and response processing
- Enhanced type safety with generic handlers
- Centralized endpoint building

### Testing Improvements

- Stronger end-to-end coverage for MCP tool execution
- Expanded integration tests for real-world client flows

### MCP 2.0 Preparation (Bulk Ops)

- Laying groundwork for MCP 2.0 bulk-operation workflows and tooling

### OAuth (Coming Soon)

- OAuth-based auth flow to simplify setup without manual tokens

### Note

Apologies to anyone affected by the last couple of builds. Thank you for the patience and reports.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
