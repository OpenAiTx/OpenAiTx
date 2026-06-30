<p align="center">
  <img src="https://raw.githubusercontent.com/sasdsamatt123/claudex/main/docs/cover.jpg" alt="claudex — one terminal, six providers, bring your own key" width="100%">
</p>

# claudex

> **通过单一终端使用 Claude Code 的多账户+多供应商（Anthropic、Z.ai、MiniMax、DeepSeek、Moonshot、OpenRouter…），自带密钥。**

`claudex` 构建于 [Claude Code](https://www.anthropic.com/claude-code) 自有的 `ANTHROPIC_BASE_URL` / `CLAUDE_CONFIG_DIR` 环境变量覆盖机制之上 — **无代理，无路由**。一条命令即可新增一个 `claudeX` 别名：输入你的 API key，选择供应商+模型，即刻准备就绪。

[英文版本见下方 ↓](#english)

---

## 🇹🇷 土耳其语

### 为什么？

- 通过 Claude Code 使用 DeepSeek / Z.ai / MiniMax 等 **更便宜或免费的** Anthropic 兼容供应商
- 在单个终端中使用独立的 `CLAUDE_CONFIG_DIR` 管理多个 **独立计费** 的 API 账户（例如个人+公司）
- 所有操作均在 Claude Code 自身的 UI/skill/MCP/agent 生态中，背后仅更换模型和密钥

> ⚠️ **此工具不是用于将 Anthropic Pro/Max 订阅共享给多用户或绕过账户限制速率。** Anthropic [消费者条款](https://www.anthropic.com/legal/consumer-terms) 和 [使用政策](https://www.anthropic.com/legal/aup) 禁止此类行为。`claudex` 仅管理**独立授权**的供应商账户/API key，作为互不干扰的配置文件。

### 前提条件

| 必需项 | 如何安装 |
|---|---|
| Node.js 20+ | https://nodejs.org/ |
| Claude Code | `npm install -g @anthropic-ai/claude-code` |
| zsh 或 bash | macOS / Linux 默认 |

### 安装（30 秒）

```bash
git clone https://github.com/sasdsamatt123/claudex.git
cd claudex
npm install && npm run build && npm link
claudex init
```

> ℹ️ `npm install -g claudex` 即将发布。暂时请使用 `git clone`。

### 第一个配置文件（带指导）

```bash
claudex quickstart
```

Z.ai → MiniMax → OpenRouter 按顺序进行。每一步：
- 显示密钥的 URL（注册 → 创建 API 密钥）
- 粘贴密钥（保密）
- 选择“我想跳过” → 回车 → 跳过
完成后执行 `source ~/.zshrc` → 输入 `claude-zai`（或 `claude-minimax`，`claude-or`）即可启动 Claude Code。

### 我应该选择哪个模型？

```bash
claudex recommend
```
交互式：“你想做什么？”→ 8个用例（快速代码/重构/长上下文/视觉/……）。显示带有理由的前三个建议，并打印你将执行的命令。

或者非交互式：

```bash
claudex recommend coding-fast --json
```

### 决策树

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

### 所有命令

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

### 内置提供商

| ID | 等级 | 站点 | 默认 |
|----|------|------|---------|
| `anthropic` | 官方 | https://console.anthropic.com | （默认） |
| `zai` | **永久免费** | https://z.ai | GLM-4.7-Flash |
| `minimax` | **免费试用**（2026年11月7日） | https://platform.minimax.io | M2.7 |
| `deepseek` | 低价付费 | https://platform.deepseek.com | deepseek-v4-pro |
| `moonshot` | 付费（长上下文专家） | https://platform.moonshot.ai | Kimi K2.5 |
| `openrouter` | 32个免费模型 | https://openrouter.ai | qwen3-coder:free |

所有都拥有**Anthropic兼容**的端点 —— 无需代理。详情 → [docs/PROVIDERS.md](https://raw.githubusercontent.com/sasdsamatt123/claudex/main/docs/PROVIDERS.md)。

### 工作原理？

Claude Code 查看5个环境变量：
- `CLAUDE_CONFIG_DIR` — 会话、历史、用户状态写入位置
- `ANTHROPIC_BASE_URL` — API端点（默认：api.anthropic.com）
- `ANTHROPIC_AUTH_TOKEN` — 端点密钥
- `ANTHROPIC_MODEL`，`ANTHROPIC_SMALL_FAST_MODEL` — 主模型 + 小型模型

`claudex add` 为每个配置文件生成一个 shell 函数。函数从 `.env` 读取密钥，设置环境变量，调用 `claude` 二进制文件。密钥不会出现在命令行参数，也不会保存到历史记录。

### 文件结构

```
~/.claudex/
├── profiles/<isim>/
│   ├── .env                # API key (mode 0600)
│   └── (CLAUDE_CONFIG_DIR — symlink veya isolated)
├── generated/aliases.sh    # ~/.zshrc tarafından source edilir
└── backups/                # her rc edit'inde otomatik backup
```

与现有的 `~/.claude/` 共享：默认情况下，agents/commands/skills/plugins/CLAUDE.md/settings.json/mcp.json 会被 **符号链接** → 每个配置文件使用相同的工具链。使用 `--no-share` 则完全隔离配置文件。

### 安全

- 密钥存储在 `~/.claudex/profiles/<名称>/.env`，权限为 0600
- `claudex` 仓库中不会提交任何密钥（自动 `.gitignore`）
- 详情 → [docs/SECURITY.md](https://raw.githubusercontent.com/sasdsamatt123/claudex/main/docs/SECURITY.md)

### 添加新提供商

向 [`src/templates/providers.json`](https://raw.githubusercontent.com/sasdsamatt123/claudex/main/src/templates/providers.json) 添加 JSON 条目，提交 PR。代码无需更改。详情 → [CONTRIBUTING.md](https://raw.githubusercontent.com/sasdsamatt123/claudex/main/CONTRIBUTING.md)。

### 路线图 (v0.3+)

- `claudex bench` — 比较配置文件的延迟和成本
- macOS 钥匙串加密的秘密（可选加入）
- 成本追踪 — 从 Claude Code 日志中统计 token 数量
- Tab 补全（zsh/bash/fish）
- Anthropic 不兼容提供商（Groq、Gemini 直连）支持 claude-code-router 代理模式

### 法律声明

`claudex` 是一个**独立**的开源工具。未得到 Anthropic、Z.ai、MiniMax、DeepSeek、Moonshot、OpenRouter 或任何其他提供商的支持或认可。遵守提供商的使用条款是你的责任。

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
- zsh 或 bash

### 安装（30秒）

```bash
git clone https://github.com/sasdsamatt123/claudex.git
cd claudex
npm install && npm run build && npm link
claudex init
```

> ℹ️ `npm install -g claudex` 发布即将推出。目前：git clone。

### 第一个配置文件（引导式）

```bash
claudex quickstart
```

引导您完成 Z.ai → MiniMax → OpenRouter（可跳过任意步骤）。完成后：`source ~/.zshrc`，然后输入 `claude-zai`（或 `claude-minimax`、`claude-or`）启动带有新模型的 Claude Code。

### 使用哪个模型？

```bash
claudex recommend
```
交互式：“你想做什么？” → 8 个用例（快速编码 / 重构 / 长上下文 / 视觉 / …）。显示前三名及其理由和安装命令。

非交互式：

```bash
claudex recommend coding-fast --json
```

### 决策树

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

### 命令

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

### 免责声明

`claudex` 是一个独立的开源工具。**与 Anthropic、Z.ai、MiniMax、DeepSeek、Moonshot、OpenRouter 或任何其他提供商无任何关联、认可或赞助。** 遵守各提供商的服务条款由您自行负责。

### 许可证

[MIT](LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-30

---