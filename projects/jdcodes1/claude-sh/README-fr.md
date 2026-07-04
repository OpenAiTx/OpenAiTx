# claude.sh

Code Claude réécrit en script bash. ~1 500 lignes. Zéro paquet npm.

## Pourquoi

Le code original Claude fait ~380 000 lignes de TypeScript avec 266 dépendances npm. Ceci fait le même travail principal en bash avec juste `curl` et `jq`.

## Fonctionnalités

- **Streaming en temps réel** via un pipe FIFO — le texte apparaît au fur et à mesure que Claude le génère
- **6 outils** : Bash, Read, Edit, Write, Glob, Grep
- **Chaînage d’outils** — jusqu’à 25 appels d’outil par tour
- **Demande de permission** — demande avant d’exécuter des commandes non sûres (`y/n/a`)
- **Chargement CLAUDE.md** — lit les instructions du projet depuis les fichiers CLAUDE.md dans l’arborescence
- **Contexte Git intégré** — branche, statut, et commits récents dans l’invite système
- **Sauvegarde/reprise de session** — sauvegarde automatique à la sortie, reprise avec `--resume <id>`
- **Retry avec backoff** — retry exponentiel sur erreurs 429/529 de limitation de débit
- **Suivi des coûts** — totaux par tour et par session
- **Spinner** — avec les verbes originaux du spinner (Clauding, Flibbertigibbeting, etc.)
- **Commandes slash** — `/help`, `/cost`, `/model`, `/clear`, `/save`, `/resume`, `/commit`, `/diff`
- **Mode pipe** — `echo "explain this" | ./claude.sh`

## Installation

```bash
git clone https://github.com/jdcodes1/claude.sh.git
cd claude.sh
chmod +x claude.sh
```

## Dépendances

- `curl`
- `jq`
- Optionnel : `rg` (ripgrep) pour une meilleure recherche
- Optionnel : `python3` pour l'outil d'édition

Les versions d'exécution sont fixées dans `.tool-versions`. Installez-les avec [mise](https://mise.jdx.dev/) :

```bash
mise install
```

## Utilisation

```bash
export ANTHROPIC_API_KEY="sk-ant-..."
./claude.sh
```
### Variables d'environnement

| Variable | Par défaut | Description |
| --- | --- | --- |
| `ANTHROPIC_API_KEY` | (requis) | Votre clé API Anthropic |
| `CLAUDE_MODEL` | `claude-sonnet-4-6` | Modèle à utiliser |
| `CLAUDE_MAX_TOKENS` | `8192` | Nombre maximal de tokens en sortie |
| `ANTHROPIC_API_URL` | `https://api.anthropic.com` | URL de base de l'API |
| `CLAUDE_SH_PERMISSIONS` | `ask` | Mode d'autorisation : `ask`, `allow`, ou `deny` |

### Commandes


```txt
/help      — Show help
/cost      — Show session cost
/model     — Show/change model
/clear     — Clear conversation
/save      — Save current session
/resume    — List/resume saved sessions
/commit    — Auto-generate a git commit
/diff      — Show git diff
/quit      — Exit
```

### Reprendre une session

```bash
# List saved sessions
./claude.sh
> /resume

# Resume by number
> /resume 1

# Resume from CLI
./claude.sh --resume 20240101-120000-12345
```

## Architecture

```txt
claude.sh          # Main REPL loop, slash commands, process_turn()
lib/
  api.sh           # Anthropic API client, SSE streaming via FIFO, retry
  json.sh          # Message construction, session persistence, CLAUDE.md, git context
  tools.sh         # 6 tool implementations + permission system
  tui.sh           # ANSI colors, spinner, display helpers
```

## Comment ça fonctionne

1. Lire l'entrée utilisateur  
2. Construire la requête JSON avec `jq` (messages, outils, prompt système)  
3. Diffuser la réponse via `curl` à travers un pipe FIFO  
4. Analyser les événements SSE ligne par ligne, afficher les deltas de texte en temps réel  
5. Lorsque des blocs tool_use arrivent, exécuter les outils  
6. Renvoyer les résultats des outils en tant que messages  
7. Boucler jusqu'à ce que Claude arrête d'appeler les outils  

## Comparaison

| | claude.sh | Claude Code (TypeScript) |  
| --- | --- | --- |  
| Lignes de code | ~1 500 | ~380 000 |  
| Dépendances | curl, jq | 266 paquets npm |  
| Taille binaire | 0 (script) | ~200Mo node_modules |  
| Temps de démarrage | Instantané | ~500ms |  

### Tests

Les tests utilisent [bats](https://github.com/bats-core/bats-core) (Bash Automated Testing System) :

```bash
bats test/
```

## License

[MIT](LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-04

---