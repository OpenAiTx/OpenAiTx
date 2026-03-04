# 🎭 Plugin d'Orchestration pour Claude Code

> _Comme N8N dans Claude Code_

### Si vous aimez le projet, pensez à lui mettre une ⭐ !<br/>

## **Orchestration de flux de travail multi-agents.** Enchaînez des agents IA pour automatiser des tâches complexes en utilisant un langage naturel ou une syntaxe déclarative.

[![Claude Code](https://img.shields.io/badge/Claude%20Code-Compatible-blue)](https://claude.com/claude-code)
[![License](https://img.shields.io/badge/License-MIT-green.svg)](LICENSE)

---

## Installation

### 1. Ajouter le Marketplace du Plugin

Tout d’abord, ajoutez le marketplace d’orchestration à votre Claude Code :

```bash
/plugin marketplace add mbruhler/claude-orchestration
```

### 2. Installer le Plugin

```bash
/plugin install orchestration@mbruhler
```
Ou utilisez le menu interactif :


```bash
/plugin
```

Puis sélectionnez **"Parcourir les Plugins"** → trouvez **orchestration** → **Installer**

### 3. Vérifier l'installation

Vérifiez que le plugin est installé :

```bash
/help
```

Vous devriez voir des commandes d'orchestration telles que `/orchestration:menu`, `/orchestration:init`, etc.

---

## Démarrage rapide

### 0. Importez vos agents personnalisés (facultatif)
```
/orchestration:init
```

Importez vos agents personnalisés depuis `~/.claude/agents/` dans le plugin d'orchestration.

**Exemple :**
```
/orchestration:init
→ Select agents to import
→ Agents become available as expert-code-implementer, etc. and the plugin can create workflows using them
```

### 1. Langage naturel
```
"Create a workflow that fetches 10 Reddit posts about startups,
analyzes competition, and shows a ratings table"
```

Le plugin :
- ✅ Crée les scripts temporaires nécessaires (Python/Node.js)
- ✅ Vous guide à travers des questions cliquables
- ✅ Génère et exécute un flux de travail optimisé
- ✅ Retourne des résultats formatés

### 2. Syntaxe directe
```flow
# Parallel bug investigation
[
  Explore:"Find related code":code ||
  general-purpose:"Check recent changes":changes ||
  general-purpose:"Search similar issues":similar
] ->
general-purpose:"Identify root cause from {code}, {changes}, {similar}":analysis ->
@review:"Approve fix?" ->
general-purpose:"Implement fix and run tests":fix ->
general-purpose:"Commit changes with detailed message"
```

### 3. Modèles
```
"Use the TDD implementation template"
```

---

## Fonctionnalités principales

### Contrôle de flux
```flow
# Sequential
step1 -> step2 -> step3

# Parallel
[task1 || task2 || task3]

# Conditional
test -> (if passed)~> deploy
     -> (if failed)~> rollback
```

### Scripts Auto Temp
Crée automatiquement des scripts Python/Node.js pour :
- 🌐 Extraction Web (BeautifulSoup, Selenium)
- 📡 API (Reddit, Twitter, GitHub)
- 📊 Traitement de données (pandas, NumPy)
- 🗄️ Requêtes de base de données

### Points de contrôle manuels
```flow
build:"Compile app" ->
@review:"Check output. Continue?" ->
deploy:"Deploy to production"
```

### Progression Visuelle
```
╔════════════════════════════════════╗
║  TDD Implementation                ║
╠════════════════════════════════════╣
║    [Write Test] ●                  ║
║         │                          ║
║    [Implement] ○                   ║
║         │                          ║
║    [@Review] ○                     ║
╠════════════════════════════════════╣
║ Status: Writing test...            ║
╚════════════════════════════════════╝
```

---

## Référence de Syntaxe

| Syntaxe | Signification | Exemple |
|--------|--------------|---------|
| `->` | Séquentiel | `étape1 -> étape2` |
| `||` | Parallèle | `[étape1 \|\| étape2]` |
| `~>` | Conditionnel | `(si réussi)~> suivant` |
| `@label` | Point de contrôle | `@révision-code` |
| `:var` | Capturer sortie | `analyser:"tâche":résultat` |
| `{var}` | Utiliser variable | `"Processus {résultat}"` |
| `$agent` | Agent temporaire | `$scanner:"Scan"` |

---

## Agents Intégrés

- **Explore** - Exploration rapide et recherche dans la base de code
- **Plan** - Planification et décomposition des tâches
- **usage général** - Agent polyvalent pour des tâches complexes en plusieurs étapes

---

## Exemples

### Analyseur de Startup Reddit
```flow
general-purpose:"Create Python PRAW script to fetch 10 r/startups posts.
                 Return JSON with title, url, description":posts ->

[
  general-purpose:"Research competition for post {posts[0]}":a1 ||
  general-purpose:"Research competition for post {posts[1]}":a2 ||
  # ... parallel analyses
] ->

general-purpose:"Rate ideas (1-10) on competition, market, feasibility.
                 Create markdown table":ratings ->

@review:"Review {ratings}. Ban any?" ->

general-purpose:"Generate top 3 opportunities summary"
```

### Implémentation TDD
```flow
# RED: Write failing test
general-purpose:"Write failing test for the feature":test ->
general-purpose:"Run test suite - verify it fails":red_result ->
@review-coverage:"Test coverage sufficient?" ->

# GREEN: Minimal implementation
general-purpose:"Write minimal code to pass the test":impl ->
general-purpose:"Run test suite - verify it passes":green_result ->
@review:"Code quality OK?" ->

# REFACTOR: Clean up
general-purpose:"Refactor code and add documentation":refactored ->
general-purpose:"Final test run and commit"
```

### Investigation de bug
```flow
# Parallel investigation
[
  Explore:"Find error pattern in codebase":code ||
  general-purpose:"Analyze error logs":logs ||
  general-purpose:"Check recent commits":commits ||
  general-purpose:"Search for similar bugs":known
] ->

# Diagnosis
general-purpose:"Identify root cause from {code}, {logs}, {commits}, {known}":cause ->
@review:"Diagnosis correct?" ->

# Fix with testing
general-purpose:"Write regression test for the bug":test ->
general-purpose:"Implement fix":fix ->

# Verification
[
  general-purpose:"Run regression test" ||
  general-purpose:"Run full test suite" ||
  general-purpose:"Perform smoke test"
] ->

@review:"Approve deployment?" ->
general-purpose:"Commit with detailed bug fix message"
```

---

## Project Structure

```
orchestration/
├── skills/              # Auto-activating skills
│   ├── creating-workflows/
│   ├── executing-workflows/
│   ├── managing-agents/
│   ├── managing-temp-scripts/
│   ├── designing-syntax/
│   ├── debugging-workflows/
│   └── using-templates/
├── agents/              # Permanent agents
├── temp-agents/         # Ephemeral (auto-cleaned)
├── temp-scripts/        # Generated scripts
├── examples/            # Templates (.flow)
└── docs/                # Documentation
```

---

## Avancé

### Exécution autonome
```bash
# Headless (no checkpoints)
claude -p "Execute @examples/tdd-implementation.flow"

# With parameters
claude -p "/orchestration:run $(cat workflow.flow)" \
  --output-format json
```

### Promotion d'Agent
```
Workflow complete!

Temp agents: security-scanner, api-wrapper

Save as permanent?
[Save all] [Save security-scanner] [Delete all]
```

### Paramètres du modèle
```yaml
---
name: api-integration
parameters:
  - API_URL: "https://api.example.com"
  - NUM_ITEMS: 10
---

workflow: |
  general-purpose:"Fetch {{NUM_ITEMS}} from {{API_URL}}":data ->
  general-purpose:"Format results":output
```

---

## Dépannage

**Le workflow bloque**
→ Le point de contrôle nécessite une réponse utilisateur ou à supprimer pour un mode sans interface

**Échec du script temporaire**
→ Vérifiez `temp-scripts/` pour le fichier généré
→ Vérifiez les identifiants API et les dépendances

**Agent non trouvé**
→ Intégré : noms exacts (Explore, usage général)
→ Plugin : utilisez le préfixe `orchestration:`
→ Temporaire : utilisez le préfixe `$`

## Historique des Étoiles

[![Graphique de l'Historique des Étoiles](https://api.star-history.com/svg?repos=mbruhler/claude-orchestration&type=date&legend=top-left)](https://www.star-history.com/#mbruhler/claude-orchestration&type=date&legend=top-left)

---

## Support

- 📖 [Documentation](docs/)
- 💬 [Discussions](https://github.com/anthropics/orchestration/discussions)
- 🐛 [Problèmes](https://github.com/anthropics/orchestration/issues)

---

**Licence MIT** | Conçu pour la communauté Claude Code


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-04

---