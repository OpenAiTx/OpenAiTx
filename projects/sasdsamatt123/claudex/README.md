<p align="center">
  <img src="https://raw.githubusercontent.com/sasdsamatt123/claudex/main/docs/cover.jpg" alt="claudex — one terminal, six providers, bring your own key" width="100%">
</p>

# claudex

> **Claude Code'u tek terminalden çoklu hesap + çoklu sağlayıcı (Anthropic, Z.ai, MiniMax, DeepSeek, Moonshot, OpenRouter…) ile kullan. Kendi key'lerini getir.**

`claudex`, [Claude Code](https://www.anthropic.com/claude-code)'un kendi `ANTHROPIC_BASE_URL` / `CLAUDE_CONFIG_DIR` env override mekanikleri üzerine kurulu — **proxy yok, router yok**. Tek komutla yeni bir `claudeX` alias'ı eklersin: kendi API key'ini girersin, sağlayıcıyı + modeli seçersin, hazır.

[English version below ↓](#english)

---

## 🇹🇷 Türkçe

### Neden?

- DeepSeek / Z.ai / MiniMax gibi **çok daha ucuz veya ücretsiz** Anthropic-uyumlu sağlayıcıları Claude Code üzerinden kullanmak
- Birden fazla **ayrı-faturalı** API hesabını (örn. kişisel + şirket) tek terminalde, izole `CLAUDE_CONFIG_DIR`'larla yönetmek
- Her şey Claude Code'un kendi UI/skill/MCP/agent dünyasında, sadece arkadaki model + key değişiyor

> ⚠️ **Bu araç bir Anthropic Pro/Max aboneliğini birden fazla kullanıcıya yaymak veya hesap-başı rate-limit'i dolanmak için DEĞİLDİR.** Anthropic [Tüketici Koşulları](https://www.anthropic.com/legal/consumer-terms) ve [Kullanım Politikası](https://www.anthropic.com/legal/aup) bunu yasaklar. `claudex` yalnızca **ayrı yetkilendirilmiş** sağlayıcı hesaplarını / API key'lerini birbirinden bağımsız profil olarak yönetir.

### Önkoşullar

| Gereken | Nasıl yüklerim |
|---|---|
| Node.js 20+ | https://nodejs.org/ |
| Claude Code | `npm install -g @anthropic-ai/claude-code` |
| zsh veya bash | macOS / Linux'ta default |

### Kurulum (30 saniye)

```bash
git clone https://github.com/sasdsamatt123/claudex.git
cd claudex
npm install && npm run build && npm link
claudex init
```

> ℹ️ `npm install -g claudex` yayını yakında. Şimdilik `git clone`.

### İlk profil (kılavuzlu)

```bash
claudex quickstart
```

Z.ai → MiniMax → OpenRouter sırasıyla ilerler. Her birinde:
- Key URL'sini gösterir (kayıt → API key oluştur)
- Key'i yapıştırırsın (gizli)
- "Atlamak istiyorum" → enter → atlanır
Bittiğinde `source ~/.zshrc` → `claude-zai` (veya `claude-minimax`, `claude-or`) yazınca Claude Code başlar.

### Hangi modeli seçeyim?

```bash
claudex recommend
```

İnteraktif: "Ne yapmak istiyorsun?" → 8 use-case (hızlı kod / refactor / uzun context / vision / …). Top-3 öneriyi rationale'la birlikte gösterir, kuracağın komutu yazdırır.

Veya non-interactive:
```bash
claudex recommend coding-fast --json
```

### Karar ağacı

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

### Tüm komutlar

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

### Bundled sağlayıcılar

| ID | Tier | Site | Default |
|----|------|------|---------|
| `anthropic` | Resmi | https://console.anthropic.com | (default) |
| `zai` | **ÜCRETSİZ FOREVER** | https://z.ai | GLM-4.7-Flash |
| `minimax` | **ÜCRETSİZ TRIAL** (Kasım 7 2026) | https://platform.minimax.io | M2.7 |
| `deepseek` | Ucuz ödemeli | https://platform.deepseek.com | deepseek-v4-pro |
| `moonshot` | Ödemeli (long-context uzmanı) | https://platform.moonshot.ai | Kimi K2.5 |
| `openrouter` | 32 ücretsiz model | https://openrouter.ai | qwen3-coder:free |

Hepsi **Anthropic-uyumlu** endpoint'lere sahip — proxy gerek yok. Detay → [docs/PROVIDERS.md](https://raw.githubusercontent.com/sasdsamatt123/claudex/main/docs/PROVIDERS.md).

### Nasıl çalışıyor?

Claude Code 5 env değişkenine bakar:
- `CLAUDE_CONFIG_DIR` — sessions, history, kullanıcı state'i nereye yazılsın
- `ANTHROPIC_BASE_URL` — API endpoint (default: api.anthropic.com)
- `ANTHROPIC_AUTH_TOKEN` — endpoint'in key'i
- `ANTHROPIC_MODEL`, `ANTHROPIC_SMALL_FAST_MODEL` — main + small modeller

`claudex add` her profil için bir shell function üretir. Function `.env`'den key'i okur, env'leri set eder, `claude` binary'sini çağırır. Key argv'de görünmez, history'e düşmez.

### Dosya yapısı

```
~/.claudex/
├── profiles/<isim>/
│   ├── .env                # API key (mode 0600)
│   └── (CLAUDE_CONFIG_DIR — symlink veya isolated)
├── generated/aliases.sh    # ~/.zshrc tarafından source edilir
└── backups/                # her rc edit'inde otomatik backup
```

Mevcut `~/.claude/` ile paylaşım: default olarak agents/commands/skills/plugins/CLAUDE.md/settings.json/mcp.json **symlink** edilir → her profilde aynı tooling. `--no-share` ile tamamen izole profile.

### Güvenlik

- Key'ler `~/.claudex/profiles/<isim>/.env`, mode 0600
- `claudex` repo'ya hiçbir key commit edilmez (otomatik `.gitignore`)
- Detay → [docs/SECURITY.md](https://raw.githubusercontent.com/sasdsamatt123/claudex/main/docs/SECURITY.md)

### Yeni sağlayıcı eklemek

[`src/templates/providers.json`](https://raw.githubusercontent.com/sasdsamatt123/claudex/main/src/templates/providers.json)'a JSON entry ekle, PR aç. Kod değişmez. Detay → [CONTRIBUTING.md](https://raw.githubusercontent.com/sasdsamatt123/claudex/main/CONTRIBUTING.md).

### Roadmap (v0.3+)

- `claudex bench` — profilleri latency/cost karşılaştır
- macOS Keychain encrypted secrets (opt-in)
- Cost tracking — Claude Code log'larından token sayımı
- Tab completion (zsh/bash/fish)
- Anthropic-uyumlu olmayan sağlayıcılar (Groq, Gemini direkt) için claude-code-router proxy modu

### Yasal uyarı

`claudex` **bağımsız** bir açık-kaynak araçtır. Anthropic, Z.ai, MiniMax, DeepSeek, Moonshot, OpenRouter veya başka bir sağlayıcı tarafından desteklenmez veya onaylanmaz. Sağlayıcı kullanım koşullarına uymak senin sorumluluğun.

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
