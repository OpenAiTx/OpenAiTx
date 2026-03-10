# claude-swift-engineering

[![Licence](https://img.shields.io/badge/license-MIT-green)](#) [![Plateforme](https://img.shields.io/badge/platform-iOS%2026%2B%20%7C%20macOS-blue)](#)

> Marketplace de plugins Claude Code pour le développement moderne en Swift/SwiftUI

Une boîte à outils IA spécialisée pour créer des fonctionnalités professionnelles iOS/macOS avec Swift 6.2 moderne, TCA (The Composable Architecture) et SwiftUI. Ce plugin fournit des agents ultra-spécialisés qui orchestrent la planification, l’implémentation, les tests et le déploiement.

## Plugin Swift Engineering

Le **plugin swift-engineering** est une boîte à outils prête pour la production pour le développement professionnel en Swift :

- **12 Agents Ultra-Spécialisés** — Planification (Opus), implémentation (Inherit), utilitaires (Haiku) avec des transitions claires
- **Support TCA** — Flux complet du design architectural aux tests pour The Composable Architecture
- **Swift 6.2 Moderne** — iOS 26+ avec concurrence stricte, async/await, acteurs, Sendable
- **Qualité du Code** — Revue de code intégrée, conformité accessibilité, et contrôles de performance
- **Compétences de Connaissance** — 18 bases de connaissances spécialisées couvrant les patterns architecturaux, frameworks, design et outils de développement

## Démarrage Rapide

### Installation

Ajoutez le plugin à Claude Code :

```bash
# Add marketplace source
/plugin marketplace add https://github.com/johnrogers/claude-swift-engineering

# Install swift-engineering plugin
/plugin install swift-engineering
```

### Crochets (Optionnel)

Activez les crochets d'évaluation des compétences/agents pour une meilleure discipline de flux de travail :

```bash
# 1. Symlink hooks-scripts to ~/.claude
ln -s /path/to/claude-swift-engineering/plugins/swift-engineering/hooks-scripts ~/.claude/hooks-scripts

# 2. Add to ~/.claude/settings.json
{
  "hooks": {
    "UserPromptSubmit": [
      {
        "hooks": [
          {
            "type": "command",
            "command": "cat ~/.claude/hooks-scripts/UserPromptSubmit/skill-forced-eval-hook.sh"
          },
          {
            "type": "command",
            "command": "cat ~/.claude/hooks-scripts/UserPromptSubmit/agent-forced-eval-hook.sh"
          }
        ]
      }
    ]
  }
}
```
Voir [plugins/swift-engineering/hooks-scripts/README.md](https://raw.githubusercontent.com/johnrogers/claude-swift-engineering/main/plugins/swift-engineering/hooks-scripts/README.md) pour la documentation complète des hooks.

Voir [plugins/swift-engineering/README.md](https://raw.githubusercontent.com/johnrogers/claude-swift-engineering/main/plugins/swift-engineering/README.md) pour la documentation complète sur l'utilisation des agents et les workflows disponibles.

## Ce qui est inclus

### 12 Agents Spécialisés

| Type | Agents | Responsabilité |
|------|--------|-----------------|
| **Planification** | @swift-ui-design, @swift-architect, @tca-architect | Décisions d'architecture (Opus, en lecture seule) |
| **Implémentation** | @tca-engineer, @swift-engineer, @swiftui-specialist, @swift-test-creator, @documentation-generator, @swift-code-reviewer, @swift-modernizer | Création et revue de code (hérité) |
| **Utilitaires** | @swift-documenter, @search | Documentation API et recherche de code (Haiku) |

### 18 Compétences de Connaissance

Modèles d'architecture (TCA, SwiftUI, Swift moderne, gestes avancés), frameworks (SQLite, GRDB, StoreKit, réseau), conception de plateforme (iOS 26, HIG, localisation, haptiques), et outils de développement (tests, style, diagnostics). Chaque compétence offre des conseils approfondis sur les modèles modernes et les meilleures pratiques.

## Pour les Contributeurs

### Structure du Référentiel


```
claude-swift-engineering/
├── .claude-plugin/
│   └── marketplace.json                    # Marketplace configuration
├── .github/workflows/                      # CI/CD pipelines
├── plugins/
│   └── swift-engineering/                  # Main plugin
│       ├── agents/                         # 12 specialized agents
│       ├── skills/                         # 18 comprehensive skills
│       ├── hooks-scripts/                  # Hooks system
│       ├── scripts/                        # Helper utilities
│       ├── rules/                          # Development rules
│       └── README.md                       # Plugin documentation
└── worktrees/                              # Git worktrees for features
```

### Flux de développement

#### Augmentation de version

Lors de modifications, incrémentez la version du plugin :

```bash
bash plugins/swift-engineering/scripts/bump-plugin-version.sh <new-version>
```

Cette mise à jour modifie les numéros de version dans plugin.json, marketplace.json et d’autres fichiers de métadonnées.

#### Ajout d’Agents ou de Compétences

1. Créez un nouveau fichier agent ou compétence en suivant les modèles existants (voir exemples dans `agents/` ou `skills/`)
2. Mettez à jour `plugin.json` si vous définissez de nouvelles capacités d’outil
3. Exécutez des tests de fumée pour valider la configuration
4. Mettez à jour les deux fichiers README (racine et plugin)
5. Testez l’intégration avec le workflow

### Organisation du Code

- **Agents** (`agents/`) — Chaque agent possède un fichier `.md` avec des métadonnées et des instructions
- **Compétences** (`skills/`) — Ressources de connaissances référencées par les agents, organisées par sujet
- **Hooks** (`hooks-scripts/`) — Hooks exécutables qui appliquent les workflows
- **Scripts** (`scripts/`) — Scripts shell utilitaires pour l’automatisation
- **Règles** (`rules/`) — Pratiques de développement et cadres décisionnels
- **Documentation** (`docs/`) — Tests de fumée et suite de validation

## Architecture & Principes de Conception

Le plugin applique plusieurs principes clés :

- **Ultra-Spécialisation** — Chaque agent a une responsabilité claire avec des transferts définis
- **Stratification des Modèles** — Opus pour l’architecture (meilleure raison), Inherit pour l’implémentation (rentable), Haiku pour les utilitaires (rapide)
- **Local-First** — Par défaut SQLite et UserDefaults, jamais SwiftData ni Core Data
- **Swift Moderne Seulement** — Swift 6.2 avec concurrence stricte, pas d’API obsolètes
- **Planification en Lecture Seule** — Les agents de planification ne peuvent pas modifier le code, assurant une séparation claire
- **Coordination des Fichiers de Plan** — Les agents partagent l’état via `docs/plans/<feature>.md`

Voir [plugins/swift-engineering/README.md](https://raw.githubusercontent.com/johnrogers/claude-swift-engineering/main/plugins/swift-engineering/README.md) pour les détails d’architecture, diagrammes de workflow et modèles de transfert.

## Licence

Licence MIT — Voir le fichier [LICENSE](LICENSE) pour plus de détails.

## Crédits

**Auteur :** John Rogers
**Dépôt :** claude-swift-engineering  
**Version Swift :** 6.2+  
**Cible de déploiement iOS :** 26.0+  

---  

Pour une documentation détaillée, les spécifications de l'agent et des exemples d'utilisation, voir [plugins/swift-engineering/README.md](https://raw.githubusercontent.com/johnrogers/claude-swift-engineering/main/plugins/swift-engineering/README.md).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-10

---