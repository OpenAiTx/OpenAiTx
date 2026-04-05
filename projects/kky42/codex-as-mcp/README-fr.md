# codex-as-mcp

[中文版](https://raw.githubusercontent.com/kky42/codex-as-mcp/main/./README.zh-CN.md)

`codex-as-mcp` est un petit serveur **Model Context Protocol (MCP)** qui permet aux clients MCP (Claude Code, Cursor, etc.) de déléguer des tâches au **Codex CLI**.

Il expose deux outils qui exécutent Codex dans le répertoire de travail actuel du serveur :
- `spawn_agent(prompt: str)`
- `spawn_agents_parallel(agents: list[dict])`

En coulisses, chaque agent exécute quelque chose comme :
`codex exec --cd <server cwd> --skip-git-repo-check --dangerously-bypass-approvals-and-sandbox "<prompt>"`.

Remarque : `--dangerously-bypass-approvals-and-sandbox` désactive le sandboxing et les invites de confirmation. Utilisez ce serveur uniquement dans des dépôts en lesquels vous avez confiance.

## Utilisez-le dans Claude Code

Il y a deux outils dans codex-as-mcp
![tools](https://raw.githubusercontent.com/kky42/codex-as-mcp/main/assets/tools.png)

Vous pouvez lancer des sous-agents codex parallèles en utilisant un prompt.
![alt text](https://raw.githubusercontent.com/kky42/codex-as-mcp/main/assets/claude.png)

Voici une session Codex exemple déléguant deux tâches en parallèle.
![Cas d'utilisation de Codex](https://raw.githubusercontent.com/kky42/codex-as-mcp/main/assets/codex.png)

## Démarrage rapide

### 1. Installer Codex CLI

**Nécessite Codex CLI >= 0.46.0**

```bash
npm install -g @openai/codex@latest
codex login

# Verify installation
codex --version
```

Assurez-vous que Codex CLI peut s'exécuter de manière non interactive sur votre machine (fournisseur + identifiants dans `~/.codex/config.toml`, ou via la variable d'environnement spécifique au fournisseur qu'il référence).

#### Exemple : fournisseur tiers + `env_key`

Si vous utilisez un fournisseur tiers, configurez-le dans le `config.toml` de Codex et pointez `model_provider` vers celui-ci. Lorsqu'un fournisseur utilise `env_key`, Codex CLI s'attend à ce que cette variable d'environnement soit présente lors de son exécution.

Exemple :
```toml
model_provider = "custom_provider"

[model_providers.custom_provider]
name = "custom_provider"
base_url = "https://..."
wire_api = "responses"
env_key = "PROVIDER_API_KEY"
show_raw_agent_reasoning = true
```

Lors de l'utilisation de `codex-as-mcp`, assurez-vous que le processus serveur MCP a cette variable d'environnement définie, afin qu'il puisse la transmettre au processus `codex` lancé. Le nom de la variable d'environnement **doit correspondre** à la valeur `env_key` ci-dessus (ici : `PROVIDER_API_KEY`).

**Option A (recommandée) : définir la variable d'environnement dans la configuration de votre client MCP (si pris en charge)**
```json
{
  "mcpServers": {
    "codex-subagent": {
      "type": "stdio",
      "command": "uvx",
      "args": ["codex-as-mcp@latest"],
      "env": {
        "PROVIDER_API_KEY": "KEY_VALUE"
      }
    }
  }
}
```

**Option B : passer les variables d’environnement via les arguments du serveur**
```bash
uvx codex-as-mcp@latest --env PROVIDER_API_KEY=KEY_VALUE
```

**Option C : ajouter via Codex CLI (`codex mcp add`)**
```bash
codex mcp add codex-subagent --env PROVIDER_API_KEY=KEY_VALUE -- uvx codex-as-mcp@latest
```

Note de sécurité : le passage de secrets via les arguments de la ligne de commande peut être visible via les listes de processus sur votre machine ; préférez l'option A lorsque cela est possible.

### 2. Configurer MCP

Ajoutez à votre `.mcp.json` :
```json
{
  "mcpServers": {
    "codex-subagent": {
      "type": "stdio",
      "command": "uvx",
      "args": ["codex-as-mcp@latest"]
    }
  }
}
```

Ou utilisez les commandes Claude Desktop :
```bash
claude mcp add codex-subagent -- uvx codex-as-mcp@latest
```

Si vous configurez Codex CLI directement (par exemple `~/.config/codex/config.toml`), ajoutez :
```toml
[mcp_servers.subagents]
transport = "stdio"
command = "uvx"
args = ["codex-as-mcp@latest"]
# Increase if you see ~60s tool-call timeouts when running longer Codex tasks.
# tool_timeout_sec = 600
```

## Outils

- `spawn_agent(prompt: str)` – Lance un sous-agent Codex autonome en utilisant le répertoire de travail du serveur et renvoie le message final de l'agent.
- `spawn_agents_parallel(agents: list[dict])` – Lance plusieurs sous-agents Codex en parallèle ; chaque élément doit inclure une clé `prompt` et les résultats comprennent soit une `output` soit une `error` par agent.

## Dépannage

### `spawn_agent` expire après ~60s

Si vous voyez une erreur comme :
```text
tool call failed for `subagents/spawn_agent`
timed out awaiting tools/call after 60s
deadline has elapsed
```

Ceci est généralement un délai d’attente d’appel d’outil côté client MCP. `spawn_agent` ne retourne pas avant que le processus `codex exec` lancé ne se termine, ce qui peut prendre plus de 60 secondes.

Correction : augmentez le délai d’attente d’appel d’outil dans votre client MCP.

#### Codex CLI

Dans votre configuration Codex (`~/.codex/config.toml` ou `~/.config/codex/config.toml`), définissez un `tool_timeout_sec` plus élevé pour le serveur MCP :
```toml
[mcp_servers.subagents]
transport = "stdio"
command = "uvx"
args = ["codex-as-mcp@latest"]
tool_timeout_sec = 600
```

#### Inspecteur MCP / `mcp dev`

Si vous testez localement avec l'Inspecteur MCP, augmentez les délais d'attente des requêtes (ou exécutez `./test.sh`, qui exporte ces variables) :
```bash
export MCP_SERVER_REQUEST_TIMEOUT=300000
export MCP_REQUEST_TIMEOUT_RESET_ON_PROGRESS=true
export MCP_REQUEST_MAX_TOTAL_TIMEOUT=28800000
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-05

---