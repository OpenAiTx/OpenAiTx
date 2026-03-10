# claude-swift-engineering

[![License](https://img.shields.io/badge/license-MIT-green)](#) [![Platform](https://img.shields.io/badge/platform-iOS%2026%2B%20%7C%20macOS-blue)](#)

> Mercado de plugins Claude Code para desarrollo moderno en Swift/SwiftUI

Un conjunto de herramientas de IA especializado para construir funcionalidades profesionales en iOS/macOS con Swift 6.2 moderno, TCA (The Composable Architecture) y SwiftUI. Este plugin proporciona agentes ultraespecializados que orquestan la planificación, implementación, pruebas y despliegue.

## Plugin Swift Engineering

El **plugin swift-engineering** es un conjunto de herramientas listo para producción para desarrollo profesional en Swift:

- **12 Agentes Ultraespecializados** — Planificación (Opus), implementación (Inherit), utilidades (Haiku) con entregas claras
- **Soporte TCA** — Flujo completo desde diseño de arquitectura hasta pruebas para The Composable Architecture
- **Swift 6.2 Moderno** — iOS 26+ con concurrencia estricta, async/await, actores, Sendable
- **Calidad de Código** — Revisión de código integrada, cumplimiento de accesibilidad y verificaciones de rendimiento
- **Conocimientos Especializados** — 18 bases de conocimiento especializadas cubriendo patrones de arquitectura, frameworks, diseño y herramientas de desarrollo

## Inicio Rápido

### Instalación

Agrega el plugin a Claude Code:

```bash
# Add marketplace source
/plugin marketplace add https://github.com/johnrogers/claude-swift-engineering

# Install swift-engineering plugin
/plugin install swift-engineering
```

### Hooks (Opcional)

Habilitar ganchos de evaluación de habilidades/agentes para una mejor disciplina del flujo de trabajo:

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

Consulte [plugins/swift-engineering/hooks-scripts/README.md](https://raw.githubusercontent.com/johnrogers/claude-swift-engineering/main/plugins/swift-engineering/hooks-scripts/README.md) para la documentación completa de los hooks.

Consulte [plugins/swift-engineering/README.md](https://raw.githubusercontent.com/johnrogers/claude-swift-engineering/main/plugins/swift-engineering/README.md) para la documentación completa sobre el uso de agentes y flujos de trabajo disponibles.

## Qué Incluye

### 12 Agentes Especializados

| Tipo | Agentes | Responsabilidad |
|------|--------|-----------------|
| **Planificación** | @swift-ui-design, @swift-architect, @tca-architect | Decisiones de arquitectura (Opus, solo lectura) |
| **Implementación** | @tca-engineer, @swift-engineer, @swiftui-specialist, @swift-test-creator, @documentation-generator, @swift-code-reviewer, @swift-modernizer | Creación y revisión de código (Heredar) |
| **Utilidades** | @swift-documenter, @search | Documentación de API y búsqueda de código (Haiku) |

### 18 Habilidades de Conocimiento

Patrones de arquitectura (TCA, SwiftUI, Swift moderno, gestos avanzados), frameworks (SQLite, GRDB, StoreKit, redes), diseño de plataforma (iOS 26, HIG, localización, hápticos) y herramientas de desarrollo (pruebas, estilo, diagnósticos). Cada habilidad ofrece orientación profunda sobre patrones modernos y mejores prácticas.

## Para Colaboradores

### Estructura del Repositorio

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

### Flujo de Desarrollo

#### Incrementar Versión

Al hacer cambios, incrementa la versión del complemento:

```bash
bash plugins/swift-engineering/scripts/bump-plugin-version.sh <new-version>
```
Esta actualización modifica los números de versión en plugin.json, marketplace.json y otros archivos de metadatos.

#### Añadiendo Agentes o Habilidades

1. Crear un nuevo archivo de agente o habilidad siguiendo los patrones existentes (ver ejemplos en `agents/` o `skills/`)
2. Actualizar `plugin.json` si se definen nuevas capacidades de herramientas
3. Ejecutar pruebas básicas para validar la configuración
4. Actualizar ambos archivos README (raíz y plugin)
5. Probar la integración con el flujo de trabajo

### Organización del Código

- **Agentes** (`agents/`) — Cada agente tiene un archivo `.md` con metadatos e instrucciones
- **Habilidades** (`skills/`) — Recursos de conocimiento a los que los agentes hacen referencia, organizados por tema
- **Hooks** (`hooks-scripts/`) — Hooks ejecutables que hacen cumplir los flujos de trabajo
- **Scripts** (`scripts/`) — Scripts utilitarios de shell para automatización
- **Reglas** (`rules/`) — Prácticas de desarrollo y marcos para toma de decisiones
- **Documentación** (`docs/`) — Pruebas básicas y suite de validación

## Arquitectura y Principios de Diseño

El plugin implementa varios principios clave:

- **Ultra-Especialización** — Cada agente tiene una responsabilidad clara con entregas definidas
- **Estratificación de Modelos** — Opus para arquitectura (mejor razonamiento), Inherit para implementación (rentable), Haiku para utilidades (rápido)
- **Local-First** — Por defecto SQLite y UserDefaults, nunca SwiftData o Core Data
- **Solo Swift Moderno** — Swift 6.2 con concurrencia estricta, sin APIs obsoletas
- **Planificación Solo de Lectura** — Los agentes de planificación no pueden modificar código, asegurando separación clara
- **Coordinación por Archivo de Plan** — Los agentes comparten estado vía `docs/plans/<feature>.md`

Ver [plugins/swift-engineering/README.md](https://raw.githubusercontent.com/johnrogers/claude-swift-engineering/main/plugins/swift-engineering/README.md) para detalles de arquitectura, diagramas de flujo y modelos de entrega.

## Licencia

Licencia MIT — Ver archivo [LICENSE](LICENSE) para detalles.

## Créditos

**Autor:** John Rogers

**Repositorio:** claude-swift-engineering  
**Versión de Swift:** 6.2+  
**Objetivo de despliegue iOS:** 26.0+  

---  

Para documentación detallada, especificaciones del agente y ejemplos de uso, consulte [plugins/swift-engineering/README.md](https://raw.githubusercontent.com/johnrogers/claude-swift-engineering/main/plugins/swift-engineering/README.md).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-10

---