# Flujos de Trabajo Antigravedad - Sistema de Habilidades de Agentes de IA

> Sistema integral de habilidades de agentes de IA para Antigravity IDE. Incluye reglas, flujos de trabajo y habilidades con activación automática.
> **Nota:** Antigravity ha sido reorganizado basado en características de agentes y habilidades. La habilidad Maestro y la estructura de agentes han sido completamente integradas.
> Referencia: [Claude Code Maestro](https://github.com/xenitV1/claude-code-maestro)

---

## 🚀 Instalación

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

## 🤖 Agentes Disponibles (16)

| Agente | Dominio y Enfoque |
|--------|-------------------|
| `orchestrator` | Coordinación y síntesis multiagente |
| `project-planner` | Descubrimiento, Arquitectura y Planificación de Tareas |
| `backend-specialist` | Arquitecto Backend (API + Base de Datos + Servidor) |
| `database-architect` | Esquema de Base de Datos, Optimización SQL |
| `frontend-specialist` | Frontend y Crecimiento (UI/UX + SEO) |
| `mobile-developer` | Especialista en Móvil (Multiplataforma) |
| `game-developer` | Lógica de Juegos, Recursos y Rendimiento |
| `security-auditor` | Auditoría de Ciberseguridad |
| `debugger` | Análisis de Causa Raíz y Corrección de Errores |
| `devops-engineer` | CI/CD, Infraestructura, Despliegue |
| `documentation-writer` | Documentación Técnica |
| `explorer-agent` | Descubrimiento, Listado y Análisis de Archivos |
| `penetration-tester` | Seguridad Ofensiva |
| `performance-optimizer` | Velocidad, Métricas Vitales |
| `seo-specialist` | SEO, GEO, Analíticas |
| `test-engineer` | Estrategia de Pruebas, E2E, Pruebas Unitarias |

---

## ⚡ Comandos Slash (10)

| Comando | Descripción |
|---------|-------------|
| `/brainstorm` | Lluvia de ideas estructurada |
| `/create` | Crear nueva aplicación |
| `/debug` | Depurar y solucionar problemas |
| `/deploy` | Despliegue en producción |
| `/enhance` | Añadir/actualizar funcionalidades |
| `/orchestrate` | Coordinación multiagente |
| `/plan` | Planificación de tareas |
| `/preview` | Gestión de servidor de vista previa |
| `/status` | Mostrar estado del proyecto |
| `/test` | Generación y ejecución de pruebas |

---

## 📚 Habilidades (35 Categorías)

Las habilidades están organizadas en `~/.gemini/antigravity/skills/` y cubren:
- **Desarrollo:** `clean-code`, `react-patterns`, `python-patterns`
- **Arquitectura:** `architecture`, `api-patterns`, `database-design`
- **Calidad:** `testing-patterns`, `code-review-checklist`, `tdd-workflow`
- **Seguridad:** `vulnerability-scanner`, `red-team-tactics`
- **Rendimiento:** `performance-profiling`, `tailwind-patterns`
- **SEO/GEO:** `seo-fundamentals`, `geo-fundamentals`
- **DevOps:** `deployment-procedures`, `server-management`

_Vea `ARCHITECTURE.md` para la lista completa._

---

## 🎯 Características Clave

- ✅ **16 Agentes Especializados** para diferentes dominios de desarrollo
- ✅ **35 Categorías de Habilidades** cubriendo desarrollo full-stack
- ✅ **10 Comandos Slash** para flujos de trabajo optimizados
- ✅ **Estándares Maestro v4.1** integrados
- ✅ **Rutas de Usuario Dinámicas** (`~/.agent/`, `~/.gemini/antigravity/`)
- ✅ **Mandato de Código Limpio** aplicado globalmente

---

## 📖 Documentación

- **[ARCHITECTURE.md](https://raw.githubusercontent.com/xenitV1/Antigravity-Workflows/main/ARCHITECTURE.md)** - Estructura completa del sistema
- **[GEMINI.md](https://raw.githubusercontent.com/xenitV1/Antigravity-Workflows/main/GEMINI.md)** - Configuración y reglas de Maestro
- **[CHANGELOG.md](https://raw.githubusercontent.com/xenitV1/Antigravity-Workflows/main/CHANGELOG.md)** - Historial de versiones

---

## 📄 Licencia

Licencia MIT

---

**Desarrollado por:** [@xenit-v0](https://x.com/xenit_v0)
**Versión:** 0.2.2 (Soporte Nativo de IDE Antigravity)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-12

---