# Plugin Claude Co-Commands

3 commandes de collaboration pour Claude Code qui utilisent le [serveur Codex MCP](https://github.com/openai/codex) pour générer des plans parallèles, valider des plans et brainstormer des idées.

## Commandes

| Commande | Description | Quand l'utiliser |
|---------|-------------|-------------|
| `/co-brainstorm` | Échanger des idées avec Codex | Voulez des idées alternatives rapides, des critiques et des perspectives |
| `/co-plan` | Générer un plan parallèle via Codex | Voulez un second avis sur votre approche de planification |
| `/co-validate` | Obtenir une revue d’ingénieur senior de votre plan | Voulez un retour critique avant de finaliser un plan |

## Prérequis

- [Node.js](https://nodejs.org/) (pour `npx`)
- [Claude Code](https://docs.anthropic.com/en/docs/claude-code)

## Installation

### Option 1 : Marketplace de plugins (Recommandé)

```bash
# Add the marketplace
/plugin marketplace add SnakeO/claude-co-commands

# Install the plugin
/plugin install co-commands@snakeo-co-commands
```

### Option 2 : Cloner avec Git

```bash
git clone https://github.com/SnakeO/claude-co-commands.git
# Copy skill folders to ~/.claude/skills/
cp -r claude-co-commands/plugins/co-commands/skills/* ~/.claude/skills/
```

### Option 3 : Copie manuelle

Copiez le contenu de `plugins/co-commands/skills/` dans `~/.claude/skills/`.

## Configuration du serveur MCP (Requise)

Ces commandes nécessitent le serveur Codex MCP.

### Option A : CLI (Recommandé)

```bash
claude mcp add validate-plans-and-brainstorm-ideas -- npx -y @openai/codex mcp-server
```

### Option B : Manuel

Ajoutez ceci à l'objet `mcpServers` dans `~/.claude.json` :

```json
"validate-plans-and-brainstorm-ideas": {
  "command": "npx",
  "args": ["-y", "@openai/codex", "mcp-server"]
}
```

Si vous avez déjà des entrées dans `mcpServers`, fusionnez ceci en tant que clé supplémentaire. Ne remplacez pas les serveurs existants.

### Vérifier

1. Redémarrez Claude Code (si vous avez modifié `~/.claude.json` manuellement).
2. Exécutez `claude mcp list` pour confirmer que le serveur est enregistré.
3. Testez avec `/co-brainstorm test idea` et confirmez que cela déclenche l'appel MCP.

## Détails de la commande

### `/co-brainstorm`

Démarre une session de brainstorming interactive avec Codex. Passez votre sujet ou question en argument.

```
/co-brainstorm how should we structure the authentication system
```

Supports follow-up conversation to dig deeper into ideas.

### `/co-plan`

Generates an alternative plan in the background while you continue your own planning. Pass your task description as the argument.

```
/co-plan add user authentication with OAuth2 support
```

Comparez le plan Codex avec le vôtre pour détecter les approches manquées, les alternatives plus simples ou les cas limites négligés.

### `/co-validate`

Envoie votre plan à Codex pour une revue de type ingénieur principal. Passez le chemin vers votre fichier de plan.

```
/co-validate .claude/plans/my-plan.md
```

Renvoie les problèmes critiques, les opportunités de simplification et les approches alternatives. Prend en charge les discussions aller-retour.

## Dépannage

| Problème | Solution |
|---------|----------|
| `npx: command not found` | Installez [Node.js](https://nodejs.org/) qui inclut npm/npx |
| Outil MCP introuvable dans la session | Vérifiez que le nom du serveur est exactement `validate-plans-and-brainstorm-ideas` dans `~/.claude.json` |
| Erreurs d'analyse JSON dans `~/.claude.json` | Validez votre JSON (vérifiez les virgules et les accolades) |
| Commandes n'apparaissant pas après l'installation | Redémarrez Claude Code et vérifiez que les dossiers de compétences existent |

## Licence

MIT


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-03

---