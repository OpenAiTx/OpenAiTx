# 反重力工作流 - AI 代理技能系统

> 反重力 IDE 的综合 AI 代理技能系统。包括规则、工作流和带有自动激活的技能。
> **注意：** 反重力已根据代理和技能特性重新组织。Maestro 技能和代理结构已完全整合。
> 参考：[Claude Code Maestro](https://github.com/xenitV1/claude-code-maestro)

---

## 🚀 安装

### Windows（PowerShell）

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

### macOS/Linux（Bash）

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

## 🤖 可用代理 (16)

| 代理 | 领域与重点 |
|-------|----------------|
| `orchestrator` | 多代理协调与综合 |
| `project-planner` | 发现、架构与任务规划 |
| `backend-specialist` | 后端架构师（API + 数据库 + 服务器） |
| `database-architect` | 数据库模式，SQL 优化 |
| `frontend-specialist` | 前端与增长（UI/UX + SEO） |
| `mobile-developer` | 移动开发专家（跨平台） |
| `game-developer` | 游戏逻辑、资源与性能 |
| `security-auditor` | 网络安全审计 |
| `debugger` | 根因分析与错误修复 |
| `devops-engineer` | CI/CD，基础设施，部署 |
| `documentation-writer` | 技术文档编写 |
| `explorer-agent` | 发现、文件列表、分析 |
| `penetration-tester` | 渗透测试 |
| `performance-optimizer` | 速度，关键指标 |
| `seo-specialist` | SEO，地理位置，分析 |
| `test-engineer` | 测试策略，端到端，单元测试 |

---

## ⚡ 斜杠命令 (10)

| 命令 | 描述 |
|---------|-------------|
| `/brainstorm` | 结构化头脑风暴 |
| `/create` | 创建新应用 |
| `/debug` | 调试与故障排除 |
| `/deploy` | 生产部署 |
| `/enhance` | 添加/更新功能 |
| `/orchestrate` | 多代理协调 |
| `/plan` | 任务规划 |
| `/preview` | 预览服务器管理 |
| `/status` | 项目状态显示 |
| `/test` | 测试生成与运行 |

---

## 📚 技能（35 类别）

技能组织在 `~/.gemini/antigravity/skills/` 目录，涵盖：
- **开发：** `clean-code`、`react-patterns`、`python-patterns`
- **架构：** `architecture`、`api-patterns`、`database-design`
- **质量：** `testing-patterns`、`code-review-checklist`、`tdd-workflow`
- **安全：** `vulnerability-scanner`、`red-team-tactics`
- **性能：** `performance-profiling`、`tailwind-patterns`
- **SEO/GEO：** `seo-fundamentals`、`geo-fundamentals`
- **运维：** `deployment-procedures`、`server-management`

_完整列表请参见 `ARCHITECTURE.md`。_

---

## 🎯 主要功能

- ✅ **16 个专用代理** 适用于不同开发领域
- ✅ **35 个技能类别** 覆盖全栈开发
- ✅ **10 个斜杠命令** 简化工作流程
- ✅ 集成 **Maestro v4.1 标准**
- ✅ 动态用户路径（`~/.agent/`、`~/.gemini/antigravity/`）
- ✅ 全局执行 **整洁代码规范**

---

## 📖 文档

- **[ARCHITECTURE.md](https://raw.githubusercontent.com/xenitV1/Antigravity-Workflows/main/ARCHITECTURE.md)** - 完整系统结构
- **[GEMINI.md](https://raw.githubusercontent.com/xenitV1/Antigravity-Workflows/main/GEMINI.md)** - Maestro 配置与规则
- **[CHANGELOG.md](https://raw.githubusercontent.com/xenitV1/Antigravity-Workflows/main/CHANGELOG.md)** - 版本历史

---

## 📄 许可证

MIT 许可证

---

**开发者：** [@xenit-v0](https://x.com/xenit_v0)
**版本：** 0.2.2（反重力 IDE 原生支持）


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-12

---