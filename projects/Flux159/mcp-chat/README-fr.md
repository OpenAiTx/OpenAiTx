# mcp-chat

Client MCP générique Open Source pour tester et évaluer les serveurs et agents MCP

<p align="center">
  <img width="600" src="https://raw.githubusercontent.com/Flux159/mcp-chat/refs/heads/main/mcpchat.svg">
</p>

## Démarrage rapide

Assurez-vous que la variable `ANTHROPIC_API_KEY` est exportée dans votre environnement ou dans un fichier .env à la racine du projet. Vous pouvez obtenir une clé API en vous inscrivant sur la [page des clés du Console Anthropic](https://console.anthropic.com/settings/keys).

Cas d'utilisation simple qui lance une invite de chat interactive avec le serveur MCP du système de fichiers depuis la CLI :

```shell
npx mcp-chat --server "npx -y @modelcontextprotocol/server-filesystem /Users/$USER/Desktop"
```

Cela ouvrira une invite de chat que vous pouvez utiliser pour interagir avec les serveurs et discuter avec un LLM.

## Config

Vous pouvez également simplement spécifier votre claude_desktop_config.json (Mac) :

```shell
npx mcp-chat --config "~/Library/Application Support/Claude/claude_desktop_config.json"
```

Ou (Windows) :

```shell
npx mcp-chat --config "%APPDATA%\Claude\claude_desktop_config.json"
```

## Web mode

https://github.com/user-attachments/assets/b7e8a648-8084-4955-8cdf-fc6eb141572e

You can also run mcp-chat in web mode by specifying the `--web` flag (make sure to have `ANTHROPIC_API_KEY` exported in your environment):

```shell
npx mcp-chat --web
```

En mode web, vous pouvez démarrer de nouvelles conversations, envoyer des messages au modèle, et configurer dynamiquement les serveurs mcp via l’interface utilisateur - pas besoin de spécifier en ligne de commande. De plus, les conversations créées via l’interface web sont sauvegardées dans ~/.mcpchats/chats tout comme celles créées via la CLI.

## Fonctionnalités

- [x] Exécution via CLI en mode interactif ou passage direct des invites avec `-p`
- [x] Mode web pour discuter avec les modèles via une interface web `--web`
- [x] Connexion à n’importe quel serveur MCP (JS, Python, Docker) en production ou en développement
- [x] Choix entre les modèles avec `-m`
- [x] Personnalisation de l’invite système avec `--system`
- [x] Sauvegarde de l’historique des conversations avec les paramètres dans `~/.mcpchat/chats` incluant les discussions web
- [x] Sauvegarde et restauration des commandes dans `~/.mcpchat/history`
- [x] Visualisation de la sortie des appels d’outils et des arguments directement dans la conversation pour aider à déboguer les serveurs mcp

## Utilisation CLI

Exécutez les invites via la CLI avec l’option `-p` :

```shell
npx mcp-chat --server "npx mcp-server-kubernetes" -p "List the pods in the default namespace"
```

Cela exécute l'invite avec le serveur mcp Kubernetes et se termine après que la réponse est reçue sur stdout.

Choisissez un modèle pour discuter via la CLI avec le drapeau `-m` :

```shell
npx mcp-chat --server "npx mcp-server-kubernetes" -m "claude-3.5"
```
Utilise le modèle `claude-3.5` pour discuter. Notez que pour l’instant, seuls les modèles Anthropic sont pris en charge.

L’invite système personnalisée :

Le flag `--system` peut être utilisé pour spécifier une invite système :


```shell
npx mcp-chat --system "Explain the output to the user in pirate speak." --server "npx mcp-server-kubernetes" -p "List the pods in the default namespace"
```

## Variables d'environnement

Mcp-chat prend en charge le passage des variables d'environnement aux serveurs mcp. Cela n'est toutefois pas standardisé dans la spécification mcp et d'autres clients peuvent ne pas faire cela avec des valeurs dynamiques de variables d'environnement - lisez-en plus [ici](https://github.com/Flux159/mcp-server-kubernetes/issues/148#issuecomment-2950181666) sur les clients mcp stdio standard.

```shell
KUBECONFIG="~/.kube/config" npx mcp-chat --server "npx mcp-server-kubernetes"
```

## Pour les développeurs de mcp-servers

Vous pouvez utiliser une version locale d'un mcp-server en python ou node pour le tester avec mcp-chat :

Node JS :

```shell
# Directly executing built script
npx mcp-chat --server "/path/to/mcp-server-kubernetes/dist/index.js"
# Using node / bun
npx mcp-chat --server "node /path/to/mcp-server-kubernetes/dist/index.js"
```
Python :


```shell
# Python: Using uv
npx mcp-chat --server "uv --directory /path/to/mcp-server-weather/ run weather.py"
# Using python / python3 - make sure to run in venv or install deps globally
npx mcp-chat --server "/path/to/mcp-server-weather/weather.py"
```

## Développement

Installer les dépendances et exécuter l'interface en ligne de commande :

```shell
git clone https://github.com/Flux159/mcp-chat
bun install
bun run dev
```

Pour développer mcp-chat tout en se connectant à un mcp-server, effectuez une compilation et lancez l’interface en ligne de commande avec le drapeau serveur :

```shell
npm run build && node dist/index.js --server "npx mcp-server-kubernetes" -p "List the pods in the default namespace"
```

Test :

```shell
bun run test
```
Bâtiment :


```shell
bun run build
```

Publication :

```shell
bun run publish
```

Publication Docker :

```shell
bun run dockerbuild
```

### Structure du projet

```
├── src/
│   ├── index.ts            # Main client implementation & CLI params
│   ├── constants.ts        # Default constants
│   ├── interactive.ts      # Interactive chat prompt handling & logic
├── test/                   # Test files
│   ├── cli.test.ts         # Test CLI params
│   ├── config.test.ts      # Test config file parsing
```

## Publication d'une nouvelle version

Allez sur la page [releases](https://github.com/Flux159/mcp-chat/releases), cliquez sur "Draft New Release", cliquez sur "Choose a tag" et créez un nouveau tag en tapant un nouveau numéro de version au format semver "v{major}.{minor}.{patch}". Ensuite, écrivez un titre de version "Release v{major}.{minor}.{patch}" et une description / journal des modifications si nécessaire, puis cliquez sur "Publish Release".

Cela créera un nouveau tag qui déclenchera une nouvelle build de version via le workflow cd.yml. Une fois réussi, la nouvelle version sera publiée sur npm. Notez qu'il n'est pas nécessaire de mettre à jour manuellement la version dans package.json, car le workflow mettra automatiquement à jour le numéro de version dans le fichier package.json et poussera un commit vers main.

## Licence

[Licence MIT](https://github.com/Flux159/mcp-chat/blob/main/LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-21

---