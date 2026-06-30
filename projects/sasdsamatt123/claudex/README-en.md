<p align="center">
  <img src="https://raw.githubusercontent.com/sasdsamatt123/claudex/main/docs/cover.jpg" alt="claudex — one terminal, six providers, bring your own key" width="100%">
</p>

# claudex

> **Use Claude Code with multiple accounts + multiple providers (Anthropic, Z.ai, MiniMax, DeepSeek, Moonshot, OpenRouter…) from a single terminal. Bring your own keys.**

`claudex` is built on Claude Code's own `ANTHROPIC_BASE_URL` / `CLAUDE_CONFIG_DIR` env override mechanisms — **no proxy, no router**. With a single command, you add a new `claudeX` alias: enter your own API key, select the provider + model, done.

[English version below ↓](#english)

---

## 🇹🇷 Turkish

### Why?

- Use **much cheaper or free** Anthropic-compatible providers like DeepSeek / Z.ai / MiniMax through Claude Code
- Manage multiple **separately billed** API accounts (e.g., personal + company) in a single terminal with isolated `CLAUDE_CONFIG_DIR`s
- Everything stays in Claude Code’s own UI/skill/MCP/agent world, only the backend model + key changes

> ⚠️ **This tool is NOT for sharing an Anthropic Pro/Max subscription among multiple users or bypassing per-account rate limits.** Anthropic [Consumer Terms](https://www.anthropic.com/legal/consumer-terms) and [Usage Policy](https://www.anthropic.com/legal/aup) prohibit this. `claudex` only manages **separately authorized** provider accounts / API keys as independent profiles.

### Prerequisites

| Required | How to install |
|---|---|
| Node.js 20+ | https://nodejs.org/ |
| Claude Code | `npm install -g @anthropic-ai/claude-code` |
| zsh or bash | default on macOS / Linux |

### Installation (30 seconds)

```bash
git clone https://github.com/sasdsamatt123/claudex.git
cd claudex
npm install && npm run build && npm link
claudex init
```

> ℹ️ `npm install -g claudex` release coming soon. For now, `git clone`.

### First profile (guided)

```bash
claudex quickstart
```

Z.ai → MiniMax → OpenRouter proceed in order. In each:
- Shows the Key URL (register → create API key)
- You paste the Key (secret)
- "I want to skip" → enter → skipped
When finished, `source ~/.zshrc` → type `claude-zai` (or `claude-minimax`, `claude-or`) to start Claude Code.

### Which model should I choose?

```bash
claudex recommend
```
Interactive: "What do you want to do?" → 8 use-cases (quick code / refactor / long context / vision / …). Shows top-3 suggestions with rationale, prints the command you will execute.

Or non-interactive:

```bash
claudex recommend coding-fast --json
```

### Decision Tree

```
Ücretsiz?
├── Süresiz ücretsiz model → claudex add <name> --provider zai
├── 32 ücretsiz modelin biri → claudex add <name> --provider openrouter
└── Trial (Kasım 7 2026'a kadar) → claudex add <name> --provider minimax

Ucuz ödemeli?
└── DeepSeek (~10x Sonnet'ten ucuz) → claudex add <name> --provider deepseek

Birden fazla ayrı-faturalı Anthropic API hesabı (kişisel/şirket/proje izolasyonu)?
└── claudex add <name> --provider anthropic --no-share
```

### All commands

```bash
claudex init                       # ilk kurulum (~/.claudex + shell rc block)
claudex quickstart                 # 3 ücretsiz sağlayıcı için kılavuzlu setup
claudex recommend [<intent>]       # ne yapmak istediğine göre top-3 model önerisi
claudex add <isim> [-p <provider>] # yeni alias (interactive)
claudex validate <isim>            # 1-token ping ile key + model doğrula
claudex list                       # tüm profilleri listele
claudex remove <isim>              # alias kaldır
claudex providers [info <id>]      # sağlayıcı kataloğu
claudex export <isim> [-o file]    # redacted JSON template (key olmadan)
claudex import <file>              # template'i yükle, key sor, profil oluştur
claudex doctor                     # kurulum sağlığı
claudex --lang en                  # İngilizce output
```

### Bundled Providers

| ID | Tier | Site | Default |
|----|------|------|---------|
| `anthropic` | Official | https://console.anthropic.com | (default) |
| `zai` | **FREE FOREVER** | https://z.ai | GLM-4.7-Flash |
| `minimax` | **FREE TRIAL** (Nov 7 2026) | https://platform.minimax.io | M2.7 |
| `deepseek` | Low-cost paid | https://platform.deepseek.com | deepseek-v4-pro |
| `moonshot` | Paid (long-context expert) | https://platform.moonshot.ai | Kimi K2.5 |
| `openrouter` | 32 free models | https://openrouter.ai | qwen3-coder:free |

All have **Anthropic-compatible** endpoints — no proxy needed. Details → [docs/PROVIDERS.md](https://raw.githubusercontent.com/sasdsamatt123/claudex/main/docs/PROVIDERS.md).

### How does it work?

Claude Code looks at 5 env variables:
- `CLAUDE_CONFIG_DIR` — where to write sessions, history, user state
- `ANTHROPIC_BASE_URL` — API endpoint (default: api.anthropic.com)
- `ANTHROPIC_AUTH_TOKEN` — endpoint key
- `ANTHROPIC_MODEL`, `ANTHROPIC_SMALL_FAST_MODEL` — main + small models

`claudex add` generates a shell function for each profile. The function reads the key from `.env`, sets envs, calls the `claude` binary. The key does not appear in argv or history.

### File structure

```
~/.claudex/
├── profiles/<isim>/
│   ├── .env                # API key (mode 0600)
│   └── (CLAUDE_CONFIG_DIR — symlink veya isolated)
├── generated/aliases.sh    # ~/.zshrc tarafından source edilir
└── backups/                # her rc edit'inde otomatik backup
```

Sharing with existing `~/.claude/`: by default agents/commands/skills/plugins/CLAUDE.md/settings.json/mcp.json are **symlinked** → same tooling in every profile. Completely isolated profile with `--no-share`.

### Security

- Keys are in `~/.claudex/profiles/<name>/.env`, mode 0600
- No key is committed to the `claudex` repo (automatic `.gitignore`)
- Details → [docs/SECURITY.md](https://raw.githubusercontent.com/sasdsamatt123/claudex/main/docs/SECURITY.md)

### Adding a new provider

Add a JSON entry to [`src/templates/providers.json`](https://raw.githubusercontent.com/sasdsamatt123/claudex/main/src/templates/providers.json), open a PR. Code does not change. Details → [CONTRIBUTING.md](https://raw.githubusercontent.com/sasdsamatt123/claudex/main/CONTRIBUTING.md).

### Roadmap (v0.3+)

- `claudex bench` — compare profiles latency/cost
- macOS Keychain encrypted secrets (opt-in)
- Cost tracking — token counting from Claude Code logs
- Tab completion (zsh/bash/fish)
- Claude-code-router proxy mode for non-Anthropic-compatible providers (Groq, Gemini direct)

### Legal disclaimer

`claudex` is an **independent** open-source tool. It is not supported or endorsed by Anthropic, Z.ai, MiniMax, DeepSeek, Moonshot, OpenRouter, or any other provider. Compliance with provider terms of use is your responsibility.

---

## English

### Why?

- Use **much cheaper or free** Anthropic-compatible providers (DeepSeek, Z.ai, MiniMax, OpenRouter…) through Claude Code
- Manage multiple **separately-billed** API accounts (e.g., personal + company) in one terminal with isolated `CLAUDE_CONFIG_DIR`s
- Everything stays in Claude Code's UI/skills/MCP/agent ecosystem — only the model + key behind it changes

> ⚠️ **This is NOT a way to share or duplicate an Anthropic Pro/Max subscription across users, nor to circumvent per-account rate limits.** Anthropic's [Consumer Terms](https://www.anthropic.com/legal/consumer-terms) and [Usage Policy](https://www.anthropic.com/legal/aup) prohibit that. `claudex` only manages **separately authorized** provider accounts / API keys as independent profiles.

### Prerequisites

- Node.js 20+ — https://nodejs.org/
- Claude Code — `npm install -g @anthropic-ai/claude-code`
- zsh or bash

### Install (30 seconds)

```bash
git clone https://github.com/sasdsamatt123/claudex.git
cd claudex
npm install && npm run build && npm link
claudex init
```

> ℹ️ `npm install -g claudex` publish coming soon. For now: git clone.

### First profile (guided)

```bash
claudex quickstart
```
Walks you through Z.ai → MiniMax → OpenRouter (skip any). When done: `source ~/.zshrc`, then `claude-zai` (or `claude-minimax`, `claude-or`) launches Claude Code with the new model.

### Which model?


```bash
claudex recommend
```

Interactive: "What do you want to do?" → 8 use cases (fast coding / refactor / long context / vision / …). Shows top-3 with rationale and the install command.

Non-interactive:
```bash
claudex recommend coding-fast --json
```

### Decision tree

```
Free?
├── Forever-free model → claudex add <name> --provider zai
├── One of 32 free models → claudex add <name> --provider openrouter
└── Trial (until Nov 7 2026) → claudex add <name> --provider minimax

Cheap paid?
└── DeepSeek (~10x cheaper than Sonnet) → claudex add <name> --provider deepseek

Multiple separately-billed Anthropic API accounts (personal/company/project isolation)?
└── claudex add <name> --provider anthropic --no-share
```

### Commands

```bash
claudex init                        # initial setup (~/.claudex + shell rc block)
claudex quickstart                  # guided setup of 3 free providers
claudex recommend [<intent>]        # top-3 model suggestions per use case
claudex add <name> [-p <provider>]  # add an alias (interactive)
claudex validate <name>             # ping the provider with a 1-token test
claudex list                        # list all profiles
claudex remove <name>               # remove alias
claudex providers [info <id>]       # provider catalog
claudex export <name> [-o file]     # redacted JSON template (no key)
claudex import <file>               # load template, prompt for key
claudex doctor                      # health check
claudex --lang tr                   # Turkish output
```

### Disclaimer

`claudex` is an independent open-source tool. **Not affiliated with, endorsed by, or sponsored by Anthropic, Z.ai, MiniMax, DeepSeek, Moonshot, OpenRouter, or any other provider.** Compliance with each provider's terms of service is your responsibility.

### License

[MIT](LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-30

---