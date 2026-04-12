# Antigravity Workflows - AI Agent Skills System

> Comprehensive AI Agent skill system for Antigravity IDE. Includes rules, workflows, and skills with automatic activation.
> **Note:** Antigravity has been re-organized based on agent and skill features. The Maestro skill and agent structure has been fully integrated.
> Reference: [Claude Code Maestro](https://github.com/xenitV1/claude-code-maestro)

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

## 🤖 Available Agents (16)

| Agent | Domain & Focus |
|-------|----------------|
| `orchestrator` | Multi-agent coordination and synthesis |
| `project-planner` | Discovery, Architecture, and Task Planning |
| `backend-specialist` | Backend Architect (API + Database + Server) |
| `database-architect` | Database Schema, SQL Optimization |
| `frontend-specialist` | Frontend & Growth (UI/UX + SEO) |
| `mobile-developer` | Mobile Specialist (Cross-platform) |
| `game-developer` | Game Logic & Assets & Performance |
| `security-auditor` | Cybersecurity Auditing |
| `debugger` | Root Cause Analysis & Bug Fixing |
| `devops-engineer` | CI/CD, Infrastructure, Deployment |
| `documentation-writer` | Technical Documentation |
| `explorer-agent` | Discovery, File Listing, Analysis |
| `penetration-tester` | Offensive Security |
| `performance-optimizer` | Speed, Vital Metrics |
| `seo-specialist` | SEO, GEO, Analytics |
| `test-engineer` | Testing Strategy, E2E, Unit Tests |

---

## ⚡ Slash Commands (10)

| Command | Description |
|---------|-------------|
| `/brainstorm` | Structured brainstorming |
| `/create` | Create new application |
| `/debug` | Debug and troubleshoot |
| `/deploy` | Production deployment |
| `/enhance` | Add/update features |
| `/orchestrate` | Multi-agent coordination |
| `/plan` | Task planning |
| `/preview` | Preview server management |
| `/status` | Project status display |
| `/test` | Test generation and running |

---

## 📚 Skills (35 Categories)

Skills are organized in `~/.gemini/antigravity/skills/` and cover:
- **Development:** `clean-code`, `react-patterns`, `python-patterns`
- **Architecture:** `architecture`, `api-patterns`, `database-design`
- **Quality:** `testing-patterns`, `code-review-checklist`, `tdd-workflow`
- **Security:** `vulnerability-scanner`, `red-team-tactics`
- **Performance:** `performance-profiling`, `tailwind-patterns`
- **SEO/GEO:** `seo-fundamentals`, `geo-fundamentals`
- **DevOps:** `deployment-procedures`, `server-management`

_See `ARCHITECTURE.md` for the complete list._

---

## 🎯 Key Features

- ✅ **16 Specialized Agents** for different development domains
- ✅ **35 Skill Categories** covering full-stack development
- ✅ **10 Slash Commands** for streamlined workflows
- ✅ **Maestro v4.1 Standards** integrated
- ✅ **Dynamic User Paths** (`~/.agent/`, `~/.gemini/antigravity/`)
- ✅ **Clean Code Mandate** enforced globally

---

## 📖 Documentation

- **[ARCHITECTURE.md](https://raw.githubusercontent.com/xenitV1/Antigravity-Workflows/main/ARCHITECTURE.md)** - Full system structure
- **[GEMINI.md](https://raw.githubusercontent.com/xenitV1/Antigravity-Workflows/main/GEMINI.md)** - Maestro configuration & rules
- **[CHANGELOG.md](https://raw.githubusercontent.com/xenitV1/Antigravity-Workflows/main/CHANGELOG.md)** - Version history

---

## 📄 License

MIT License

---

**Developed by:** [@xenit-v0](https://x.com/xenit_v0)
**Version:** 0.2.2 (Antigravity IDE Native Support)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-12

---