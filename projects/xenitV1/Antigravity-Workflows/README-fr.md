# Flux de travail Antigravity - Système de compétences des agents IA

> Système complet de compétences pour agents IA dans Antigravity IDE. Comprend des règles, des flux de travail et des compétences avec activation automatique.
> **Remarque :** Antigravity a été réorganisé en fonction des fonctionnalités des agents et des compétences. La compétence Maestro et la structure des agents ont été entièrement intégrées.
> Référence : [Claude Code Maestro](https://github.com/xenitV1/claude-code-maestro)

---

## 🚀 Installation

### Windows (PowerShell)

```powershell
# 1. Create directories
New-Item -ItemType Directory -Force -Path "$HOME\.gemini\antigravity"
New-Item -ItemType Directory -Force -Path "$HOME\.gemini\global_workflows"
New-Item -ItemType Directory -Force -Path "$HOME\.agent"

# 2. GEMINI.md -> ~/.gemini/
Copy-Item ".\GEMINI.md" "$HOME\.gemini\GEMINI.md"

# 3. Global Workflows (Commands) -> ~/.gemini/global_workflows/
Copy-Item ".\global_workflows\*" "$HOME\.gemini\global_workflows\"

# 4. Antigravity System (Skills) -> ~/.gemini/antigravity/
Copy-Item -Recurse ".\skills" "$HOME\.gemini\antigravity\"

# 5. Agents -> ~/.agent/
Copy-Item ".\.agent\*" "$HOME\.agent\" -Recurse
```

### macOS/Linux (Bash)

```bash
# 1. Create directories
mkdir -p ~/.gemini/antigravity
mkdir -p ~/.gemini/global_workflows
mkdir -p ~/.agent

# 2. GEMINI.md -> ~/.gemini/
cp GEMINI.md ~/.gemini/GEMINI.md

# 3. Global Workflows (Commands) -> ~/.gemini/global_workflows/
cp -r global_workflows/* ~/.gemini/global_workflows/

# 4. Antigravity System (Skills) -> ~/.gemini/antigravity/
cp -r skills ~/.gemini/antigravity/

# 5. Agents -> ~/.agent/
cp -r .agent/* ~/.agent/
```

---

## 📁 Post-Installation Structure

```
~/.gemini/                              # Global Config
├── GEMINI.md                           # Maestro Configuration
├── global_workflows/                   # Slash Commands (/)
│   ├── brainstorm.md                   # /brainstorm
│   ├── create.md                       # /create
│   └── ...
└── antigravity/                        # Core System
    └── skills/                         # Skill Library
        ├── ultrathink.md
        ├── architecture.md
        └── ...

~/.agent/                               # Agents
└── agents/                             # 16 Specialized Agents
    ├── orchestrator.md
    ├── backend-specialist.md
    └── ...
```

---

## 🤖 Agents Disponibles (16)

| Agent | Domaine & Focus |
|-------|----------------|
| `orchestrator` | Coordination et synthèse multi-agents |
| `project-planner` | Découverte, Architecture et Planification des tâches |
| `backend-specialist` | Architecte Backend (API + Base de données + Serveur) |
| `database-architect` | Schéma de base de données, optimisation SQL |
| `frontend-specialist` | Frontend & Croissance (UI/UX + SEO) |
| `mobile-developer` | Spécialiste Mobile (Cross-platform) |
| `game-developer` | Logique de jeu, assets et performance |
| `security-auditor` | Audit en cybersécurité |
| `debugger` | Analyse des causes racines & correction de bugs |
| `devops-engineer` | CI/CD, Infrastructure, Déploiement |
| `documentation-writer` | Documentation technique |
| `explorer-agent` | Découverte, listing de fichiers, analyse |
| `penetration-tester` | Sécurité offensive |
| `performance-optimizer` | Vitesse, métriques vitales |
| `seo-specialist` | SEO, GEO, Analytics |
| `test-engineer` | Stratégie de test, E2E, tests unitaires |

---

## ⚡ Commandes Slash (10)

| Commande | Description |
|---------|-------------|
| `/brainstorm` | Brainstorming structuré |
| `/create` | Créer une nouvelle application |
| `/debug` | Déboguer et résoudre les problèmes |
| `/deploy` | Déploiement en production |
| `/enhance` | Ajouter/mettre à jour des fonctionnalités |
| `/orchestrate` | Coordination multi-agents |
| `/plan` | Planification des tâches |
| `/preview` | Gestion du serveur de prévisualisation |
| `/status` | Affichage du statut du projet |
| `/test` | Génération et exécution de tests |

---

## 📚 Compétences (35 Catégories)

Les compétences sont organisées dans `~/.gemini/antigravity/skills/` et couvrent :
- **Développement :** `clean-code`, `react-patterns`, `python-patterns`
- **Architecture :** `architecture`, `api-patterns`, `database-design`
- **Qualité :** `testing-patterns`, `code-review-checklist`, `tdd-workflow`
- **Sécurité :** `vulnerability-scanner`, `red-team-tactics`
- **Performance :** `performance-profiling`, `tailwind-patterns`
- **SEO/GEO :** `seo-fundamentals`, `geo-fundamentals`
- **DevOps :** `deployment-procedures`, `server-management`

_Voir `ARCHITECTURE.md` pour la liste complète._

---

## 🎯 Fonctionnalités Clés

- ✅ **16 Agents Spécialisés** pour différents domaines du développement
- ✅ **35 Catégories de Compétences** couvrant le développement full-stack
- ✅ **10 Commandes Slash** pour des flux de travail simplifiés
- ✅ **Normes Maestro v4.1** intégrées
- ✅ **Chemins Utilisateur Dynamiques** (`~/.agent/`, `~/.gemini/antigravity/`)
- ✅ **Mandat de Code Propre** appliqué globalement

---

## 📖 Documentation

- **[ARCHITECTURE.md](https://raw.githubusercontent.com/xenitV1/Antigravity-Workflows/main/ARCHITECTURE.md)** - Structure complète du système
- **[GEMINI.md](https://raw.githubusercontent.com/xenitV1/Antigravity-Workflows/main/GEMINI.md)** - Configuration & règles Maestro
- **[CHANGELOG.md](https://raw.githubusercontent.com/xenitV1/Antigravity-Workflows/main/CHANGELOG.md)** - Historique des versions

---

## 📄 Licence

Licence MIT

---

**Développé par :** [@xenit-v0](https://x.com/xenit_v0)
**Version :** 0.2.2 (Support natif Antigravity IDE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-12

---