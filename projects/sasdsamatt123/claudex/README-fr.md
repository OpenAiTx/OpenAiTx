<p align="center">
  <img src="https://raw.githubusercontent.com/sasdsamatt123/claudex/main/docs/cover.jpg" alt="claudex — un terminal, six fournisseurs, apportez votre propre clé" width="100%">
</p>

# claudex

> **Utilisez Claude Code avec plusieurs comptes + plusieurs fournisseurs (Anthropic, Z.ai, MiniMax, DeepSeek, Moonshot, OpenRouter…) depuis un seul terminal. Apportez vos propres clés.**

`claudex` est construit sur les mécanismes d’override d’environnement `ANTHROPIC_BASE_URL` / `CLAUDE_CONFIG_DIR` propres à [Claude Code](https://www.anthropic.com/claude-code) — **pas de proxy, pas de routeur**. Une seule commande pour ajouter un nouvel alias `claudeX` : vous entrez votre clé API, choisissez le fournisseur + le modèle, c’est prêt.

[Version anglaise ci-dessous ↓](#english)

---

## 🇹🇷 Turc

### Pourquoi ?

- Utiliser des fournisseurs compatibles Anthropic comme DeepSeek / Z.ai / MiniMax, **beaucoup moins chers ou gratuits** via Claude Code
- Gérer plusieurs comptes API **avec facturation séparée** (ex. personnel + entreprise) dans un seul terminal, avec des `CLAUDE_CONFIG_DIR` isolés
- Tout se passe dans l’univers UI/skill/MCP/agent de Claude Code, seul le modèle + la clé changent en arrière-plan

> ⚠️ **Cet outil n’est PAS destiné à partager un abonnement Anthropic Pro/Max entre plusieurs utilisateurs ni à contourner les limites de taux par compte.** Anthropic interdit cela dans ses [Conditions d’utilisation consommateurs](https://www.anthropic.com/legal/consumer-terms) et sa [Politique d’utilisation acceptable](https://www.anthropic.com/legal/aup). `claudex` gère uniquement des comptes fournisseurs / clés API **autorisés séparément** comme profils indépendants.

### Prérequis

| Nécessaire | Comment installer |
|---|---|
| Node.js 20+ | https://nodejs.org/ |
| Claude Code | `npm install -g @anthropic-ai/claude-code` |
| zsh ou bash | Par défaut sur macOS / Linux |

### Installation (30 secondes)

```bash
git clone https://github.com/sasdsamatt123/claudex.git
cd claudex
npm install && npm run build && npm link
claudex init
```

> ℹ️ `npm install -g claudex` sera bientôt publié. Pour l'instant, `git clone`.

### Premier profil (guidé)

```bash
claudex quickstart
```

Z.ai → MiniMax → OpenRouter avancent dans cet ordre. Pour chacun :
- Montre l'URL de la clé (inscription → créer une clé API)
- Tu colles la clé (confidentielle)
- "Je veux passer" → entrée → c’est sauté
Quand c’est fini, `source ~/.zshrc` → taper `claude-zai` (ou `claude-minimax`, `claude-or`) pour démarrer Claude Code.

### Quel modèle choisir ?

```bash
claudex recommend
```
Interactif : « Que veux-tu faire ? » → 8 cas d’utilisation (code rapide / refactorisation / contexte long / vision / …). Affiche les 3 meilleures suggestions avec leur justification, puis affiche la commande à exécuter.

Ou bien non interactif :

```bash
claudex recommend coding-fast --json
```

### Arbre de décision

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
### Toutes les commandes


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

### Fournisseurs inclus

| ID | Niveau | Site | Par défaut |
|----|--------|------|------------|
| `anthropic` | Officiel | https://console.anthropic.com | (par défaut) |
| `zai` | **GRATUIT POUR TOUJOURS** | https://z.ai | GLM-4.7-Flash |
| `minimax` | **ESSAI GRATUIT** (7 novembre 2026) | https://platform.minimax.io | M2.7 |
| `deepseek` | Paiement à bas coût | https://platform.deepseek.com | deepseek-v4-pro |
| `moonshot` | Payant (expert contexte long) | https://platform.moonshot.ai | Kimi K2.5 |
| `openrouter` | 32 modèles gratuits | https://openrouter.ai | qwen3-coder:free |

Ils ont tous des endpoints **compatibles Anthropic** — pas besoin de proxy. Détails → [docs/PROVIDERS.md](https://raw.githubusercontent.com/sasdsamatt123/claudex/main/docs/PROVIDERS.md).

### Comment ça fonctionne ?

Claude Code regarde 5 variables d'environnement :
- `CLAUDE_CONFIG_DIR` — où écrire sessions, historique, état utilisateur
- `ANTHROPIC_BASE_URL` — endpoint API (par défaut : api.anthropic.com)
- `ANTHROPIC_AUTH_TOKEN` — clé de l'endpoint
- `ANTHROPIC_MODEL`, `ANTHROPIC_SMALL_FAST_MODEL` — modèles principal + petit

`claudex add` génère une fonction shell pour chaque profil. La fonction lit la clé depuis `.env`, configure les variables d'environnement, appelle le binaire `claude`. La clé n'apparaît pas dans argv ni dans l'historique.

### Structure des fichiers

```
~/.claudex/
├── profiles/<isim>/
│   ├── .env                # API key (mode 0600)
│   └── (CLAUDE_CONFIG_DIR — symlink veya isolated)
├── generated/aliases.sh    # ~/.zshrc tarafından source edilir
└── backups/                # her rc edit'inde otomatik backup
```
Partage avec `~/.claude/` existant : par défaut, agents/commands/skills/plugins/CLAUDE.md/settings.json/mcp.json sont **liés par un symlink** → même tooling sur chaque profil. Profil complètement isolé avec `--no-share`.

### Sécurité

- Les clés sont dans `~/.claudex/profiles/<nom>/.env`, mode 0600
- Aucune clé n’est commitée dans le dépôt `claudex` ( `.gitignore` automatique)
- Détails → [docs/SECURITY.md](https://raw.githubusercontent.com/sasdsamatt123/claudex/main/docs/SECURITY.md)

### Ajouter un nouveau fournisseur

Ajoutez une entrée JSON dans [`src/templates/providers.json`](https://raw.githubusercontent.com/sasdsamatt123/claudex/main/src/templates/providers.json), puis ouvrez une PR. Pas de changement de code. Détails → [CONTRIBUTING.md](https://raw.githubusercontent.com/sasdsamatt123/claudex/main/CONTRIBUTING.md).

### Feuille de route (v0.3+)

- `claudex bench` — comparer latence/coût des profils
- Secrets chiffrés dans le trousseau macOS (opt-in)
- Suivi des coûts — comptage des tokens via les logs Claude Code
- Complétion tabulation (zsh/bash/fish)
- Mode proxy claude-code-router pour fournisseurs non compatibles Anthropic (Groq, Gemini direct)

### Avertissement légal

`claudex` est un outil **indépendant** open-source. Il n’est pas soutenu ni approuvé par Anthropic, Z.ai, MiniMax, DeepSeek, Moonshot, OpenRouter ou tout autre fournisseur. Le respect des conditions d’utilisation du fournisseur est votre responsabilité.

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
- zsh ou bash

### Installation (30 secondes)

```bash
git clone https://github.com/sasdsamatt123/claudex.git
cd claudex
npm install && npm run build && npm link
claudex init
```

> ℹ️ `npm install -g claudex` publication bientôt disponible. Pour l’instant : git clone.

### Premier profil (guidé)

```bash
claudex quickstart
```

Vous guide à travers Z.ai → MiniMax → OpenRouter (sautez ceux que vous voulez). Une fois terminé : `source ~/.zshrc`, puis `claude-zai` (ou `claude-minimax`, `claude-or`) lance Claude Code avec le nouveau modèle.

### Quel modèle ?

```bash
claudex recommend
```
Interactif : « Que voulez-vous faire ? » → 8 cas d’utilisation (codage rapide / refactorisation / contexte long / vision / …). Affiche les 3 premiers avec justification et la commande d’installation.

Non interactif :

```bash
claudex recommend coding-fast --json
```

### Arbre de décision

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

### Commandes

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

### Avertissement

`claudex` est un outil open-source indépendant. **Il n’est affilié, approuvé ou sponsorisé par Anthropic, Z.ai, MiniMax, DeepSeek, Moonshot, OpenRouter ou aucun autre fournisseur.** Le respect des conditions d’utilisation de chaque fournisseur est de votre responsabilité.

### Licence

[MIT](LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-30

---