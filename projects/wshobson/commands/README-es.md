
<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Comandos Slash para Claude Code

Comandos slash listos para producción para [Claude Code](https://docs.anthropic.com/en/docs/claude-code) que aceleran el desarrollo mediante automatización inteligente.

**52 comandos** organizados como:
- **🤖 Flujos de trabajo**: Orquestación multi-subagente para tareas complejas
- **🔧 Herramientas**: Utilidades de propósito único para operaciones específicas

### 🤝 Requiere Subagentes de Claude Code

Estos comandos funcionan con los [Subagentes de Claude Code](https://github.com/wshobson/agents) para capacidades de orquestación.

## Instalación

```bash
cd ~/.claude
git clone https://github.com/wshobson/commands.git
git clone https://github.com/wshobson/agents.git  # Required for subagent orchestration
```

## Comandos Disponibles

- **🤖 Flujos de trabajo** - Orquestar múltiples subagentes para tareas complejas
- **🔧 Herramientas** - Comandos de propósito único para operaciones específicas

## Uso

```bash
/api-scaffold user management with authentication
/security-scan check for vulnerabilities
/feature-development implement chat functionality
```
Claude Code sugiere automáticamente comandos relevantes según el contexto.

## 🤖 Flujos de trabajo

Orquestación multi-subagente para tareas complejas:

### Desarrollo de Funcionalidades
- **[feature-development](https://raw.githubusercontent.com/wshobson/commands/main/workflows/feature-development.md)** - Subagentes de backend, frontend, pruebas y despliegue construyen funcionalidades completas
- **[full-review](https://raw.githubusercontent.com/wshobson/commands/main/workflows/full-review.md)** - Múltiples subagentes de revisión ofrecen análisis de código exhaustivos
- **[smart-fix](https://raw.githubusercontent.com/wshobson/commands/main/workflows/smart-fix.md)** - Analiza problemas y delega a subagentes especialistas adecuados

### Procesos de Desarrollo
- **[git-workflow](https://raw.githubusercontent.com/wshobson/commands/main/workflows/git-workflow.md)** - Implementa flujos de trabajo Git efectivos con estrategias de branching y plantillas PR
- **[improve-agent](https://raw.githubusercontent.com/wshobson/commands/main/workflows/improve-agent.md)** - Mejora el rendimiento de subagentes mediante optimización de prompts
- **[legacy-modernize](https://raw.githubusercontent.com/wshobson/commands/main/workflows/legacy-modernize.md)** - Moderniza bases de código legacy usando subagentes especializados
- **[ml-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/workflows/ml-pipeline.md)** - Crea pipelines ML con subagentes de datos e ingeniería ML
- **[multi-platform](https://raw.githubusercontent.com/wshobson/commands/main/workflows/multi-platform.md)** - Construye apps multiplataforma con subagentes coordinados
- **[workflow-automate](https://raw.githubusercontent.com/wshobson/commands/main/workflows/workflow-automate.md)** - Automatiza flujos de trabajo CI/CD, monitoreo y despliegue

### Flujos de Trabajo Orquestados por Subagentes
- **[full-stack-feature](https://raw.githubusercontent.com/wshobson/commands/main/workflows/full-stack-feature.md)** - Funcionalidades multiplataforma con subagentes de backend, frontend y móvil
- **[security-hardening](https://raw.githubusercontent.com/wshobson/commands/main/workflows/security-hardening.md)** - Implementación con enfoque en seguridad usando subagentes especializados
- **[data-driven-feature](https://raw.githubusercontent.com/wshobson/commands/main/workflows/data-driven-feature.md)** - Funcionalidades potenciadas por ML con subagentes de ciencia de datos
- **[performance-optimization](https://raw.githubusercontent.com/wshobson/commands/main/workflows/performance-optimization.md)** - Optimización integral con subagentes de rendimiento
- **[incident-response](https://raw.githubusercontent.com/wshobson/commands/main/workflows/incident-response.md)** - Resolución de incidentes en producción con subagentes de operaciones

## 🔧 Herramientas (Comandos de Propósito Único)

### IA y Aprendizaje Automático
- **[ai-assistant](https://raw.githubusercontent.com/wshobson/commands/main/tools/ai-assistant.md)** - Construye asistentes y chatbots de IA listos para producción
- **[ai-review](https://raw.githubusercontent.com/wshobson/commands/main/tools/ai-review.md)** - Revisión especializada para bases de código AI/ML
- **[langchain-agent](https://raw.githubusercontent.com/wshobson/commands/main/tools/langchain-agent.md)** - Crea agentes LangChain/LangGraph con patrones modernos
- **[ml-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/tools/ml-pipeline.md)** - Crea pipelines ML integrales con MLOps
- **[prompt-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/prompt-optimize.md)** - Optimiza prompts de IA para rendimiento y calidad

### Arquitectura y Calidad de Código
- **[code-explain](https://raw.githubusercontent.com/wshobson/commands/main/tools/code-explain.md)** - Genera explicaciones detalladas de código complejo
- **[code-migrate](https://raw.githubusercontent.com/wshobson/commands/main/tools/code-migrate.md)** - Migra código entre lenguajes, frameworks o versiones
- **[refactor-clean](https://raw.githubusercontent.com/wshobson/commands/main/tools/refactor-clean.md)** - Refactoriza código para mantenibilidad y rendimiento
- **[tech-debt](https://raw.githubusercontent.com/wshobson/commands/main/tools/tech-debt.md)** - Analiza y prioriza deuda técnica

### Datos y Bases de Datos
- **[data-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/tools/data-pipeline.md)** - Diseña arquitecturas escalables para pipelines de datos
- **[data-validation](https://raw.githubusercontent.com/wshobson/commands/main/tools/data-validation.md)** - Implementa sistemas integrales de validación de datos
- **[db-migrate](https://raw.githubusercontent.com/wshobson/commands/main/tools/db-migrate.md)** - Estrategias avanzadas de migración de bases de datos

### DevOps e Infraestructura
- **[deploy-checklist](https://raw.githubusercontent.com/wshobson/commands/main/tools/deploy-checklist.md)** - Genera configuraciones y listas de verificación para despliegues
- **[docker-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/docker-optimize.md)** - Estrategias avanzadas de optimización de contenedores
- **[k8s-manifest](https://raw.githubusercontent.com/wshobson/commands/main/tools/k8s-manifest.md)** - Despliegues Kubernetes de nivel producción
- **[monitor-setup](https://raw.githubusercontent.com/wshobson/commands/main/tools/monitor-setup.md)** - Configura monitoreo y observabilidad integrales
- **[slo-implement](https://raw.githubusercontent.com/wshobson/commands/main/tools/slo-implement.md)** - Implementa Objetivos de Nivel de Servicio (SLOs)
- **[workflow-automate](https://raw.githubusercontent.com/wshobson/commands/main/tools/workflow-automate.md)** - Automatiza flujos de trabajo de desarrollo y operaciones

### Desarrollo y Pruebas
- **[api-mock](https://raw.githubusercontent.com/wshobson/commands/main/tools/api-mock.md)** - Crea mocks realistas de API para desarrollo y pruebas
- **[api-scaffold](https://raw.githubusercontent.com/wshobson/commands/main/tools/api-scaffold.md)** - Genera endpoints API listos para producción con pila de implementación completa
- **[test-harness](https://raw.githubusercontent.com/wshobson/commands/main/tools/test-harness.md)** - Crea suites de pruebas completas con detección de frameworks

### Seguridad y Cumplimiento
- **[accessibility-audit](https://raw.githubusercontent.com/wshobson/commands/main/tools/accessibility-audit.md)** - Pruebas y correcciones integrales de accesibilidad
- **[compliance-check](https://raw.githubusercontent.com/wshobson/commands/main/tools/compliance-check.md)** - Asegura cumplimiento normativo (GDPR, HIPAA, SOC2)
- **[security-scan](https://raw.githubusercontent.com/wshobson/commands/main/tools/security-scan.md)** - Escaneo de seguridad integral con remediación automatizada

### Depuración y Análisis
- **[debug-trace](https://raw.githubusercontent.com/wshobson/commands/main/tools/debug-trace.md)** - Estrategias avanzadas de depuración y trazado
- **[error-analysis](https://raw.githubusercontent.com/wshobson/commands/main/tools/error-analysis.md)** - Análisis profundo de patrones de error y estrategias de resolución
- **[error-trace](https://raw.githubusercontent.com/wshobson/commands/main/tools/error-trace.md)** - Rastrea y diagnostica errores en producción
- **[issue](https://raw.githubusercontent.com/wshobson/commands/main/tools/issue.md)** - Crea issues bien estructurados para GitHub/GitLab

### Dependencias y Configuración
- **[config-validate](https://raw.githubusercontent.com/wshobson/commands/main/tools/config-validate.md)** - Valida y gestiona la configuración de aplicaciones
- **[deps-audit](https://raw.githubusercontent.com/wshobson/commands/main/tools/deps-audit.md)** - Audita dependencias para seguridad y licencias
- **[deps-upgrade](https://raw.githubusercontent.com/wshobson/commands/main/tools/deps-upgrade.md)** - Actualiza dependencias del proyecto de manera segura

### Documentación y Colaboración
- **[doc-generate](https://raw.githubusercontent.com/wshobson/commands/main/tools/doc-generate.md)** - Genera documentación completa
- **[git-workflow](https://raw.githubusercontent.com/wshobson/commands/main/tools/git-workflow.md)** - Implementa flujos de trabajo Git efectivos
- **[pr-enhance](https://raw.githubusercontent.com/wshobson/commands/main/tools/pr-enhance.md)** - Mejora pull requests con chequeos de calidad

### Optimización de Costos
- **[cost-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/cost-optimize.md)** - Optimiza costos en la nube e infraestructura

### Integración y Configuración Inicial
- **[onboard](https://raw.githubusercontent.com/wshobson/commands/main/tools/onboard.md)** - Configura entornos de desarrollo para nuevos miembros del equipo

### Herramientas de Subagentes
- **[multi-agent-review](https://raw.githubusercontent.com/wshobson/commands/main/tools/multi-agent-review.md)** - Revisión de código desde múltiples perspectivas con subagentes especializados
- **[smart-debug](https://raw.githubusercontent.com/wshobson/commands/main/tools/smart-debug.md)** - Depuración profunda con subagentes de depurador y rendimiento
- **[multi-agent-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/multi-agent-optimize.md)** - Optimización full-stack con múltiples subagentes
- **[context-save](https://raw.githubusercontent.com/wshobson/commands/main/tools/context-save.md)** - Guarda el contexto del proyecto usando el subagente gestor de contexto
- **[context-restore](https://raw.githubusercontent.com/wshobson/commands/main/tools/context-restore.md)** - Restaura contexto guardado para continuidad

## Características

- Implementaciones listas para producción
- Auto-detección de frameworks
- Mejores prácticas de seguridad
- Monitoreo y pruebas integrados

- Los comandos funcionan juntos sin problemas

## Conteo de Comandos

**Total: 52 comandos listos para producción** organizados en:

### 🤖 Flujos de Trabajo (14 comandos)

- Desarrollo y Revisión de Funcionalidades (3 comandos) 
- Automatización del Proceso de Desarrollo (6 comandos)
- Flujos de Trabajo Orquestados por Subagentes (5 comandos)

### 🔧 Herramientas (38 comandos)

- IA y Aprendizaje Automático (5 comandos)
- Arquitectura y Calidad de Código (4 comandos)
- Datos y Bases de Datos (3 comandos)
- DevOps e Infraestructura (6 comandos)
- Desarrollo y Pruebas (3 comandos)
- Seguridad y Cumplimiento (3 comandos)
- Depuración y Análisis (4 comandos)
- Dependencias y Configuración (3 comandos)
- Documentación y Colaboración (1 comando)
- Integración y Configuración Inicial (1 comando)
- Herramientas Específicas de Subagentes (5 comandos)

## Ejemplos de Uso

### 🤖 Ejemplos de Flujos de Trabajo

```bash
# Implement a complete feature
/feature-development Add user authentication with OAuth2

# Comprehensive code review
/full-review Review the authentication module

# Smart issue resolution
/smart-fix Fix performance degradation in API response times

# Modernize legacy system
/legacy-modernize Migrate monolithic Java app to microservices

# Build comprehensive multi-platform feature
/full-stack-feature User authentication with social login across web and mobile

# Implement security-first architecture
/security-hardening Harden API endpoints and implement zero-trust security model

# Create data-driven ML feature
/data-driven-feature Build recommendation engine with real-time personalization

# Optimize entire application stack
/performance-optimization Improve response times and reduce infrastructure costs

# Respond to production incident
/incident-response High CPU usage causing service degradation in production
```

### 🔧 Ejemplos de herramientas (comandos de un solo propósito)

```bash
# Create a user management API
/api-scaffold user CRUD operations with JWT auth and role-based access

# Review microservices architecture
/multi-agent-review analyze our microservices for coupling and scalability issues

# Optimize LLM chat application
/prompt-optimize reduce latency for customer support chatbot while maintaining accuracy

# Create fraud detection pipeline
/data-pipeline real-time fraud detection with feature store and monitoring

# Debug production issue
/error-trace analyze high memory usage in production pods

# Secure container images
/security-scan scan and fix vulnerabilities in Docker images

# Generate API documentation
/doc-generate create OpenAPI docs with examples for REST endpoints

# Onboard new developer
/onboard Setup development environment for React/Node.js project

# Multi-perspective code review
/multi-agent-review Review authentication module

# Deep debugging
/smart-debug Investigate memory leak in production workers

# Full-stack optimization
/multi-agent-optimize Optimize checkout flow for better conversion

# Save project context
/context-save Save current project state and architectural decisions

# Restore project context
/context-restore Load context from last week's sprint
```

## Comandos Mejorados

### Seguridad y DevOps

#### [`/security-scan`](https://raw.githubusercontent.com/wshobson/commands/main/tools/security-scan.md)

Escaneo de seguridad integral con remediación automatizada.

- **Escaneo Multi-Herramienta**: Bandit, Safety, Trivy, Semgrep, ESLint Security, Snyk
- **Correcciones Automatizadas**: Vulnerabilidades comunes auto-remediadas
- **Integración CI/CD**: Puertas de seguridad para GitHub Actions/GitLab CI
- **Escaneo de Contenedores**: Análisis de vulnerabilidades en imágenes
- **Detección de Secretos**: Integración con GitLeaks y TruffleHog

#### [`/docker-optimize`](https://raw.githubusercontent.com/wshobson/commands/main/tools/docker-optimize.md)

Estrategias avanzadas de optimización de contenedores.

- **Optimización Inteligente**: Analiza y sugiere mejoras
- **Construcciones Multi-Etapa**: Dockerfiles optimizados específicos para frameworks
- **Herramientas Modernas**: BuildKit, Bun, UV para compilaciones más rápidas
- **Endurecimiento de Seguridad**: Imágenes distroless, usuarios no root
- **Integración Cruzada de Comandos**: Funciona con salidas de /api-scaffold

#### [`/k8s-manifest`](https://raw.githubusercontent.com/wshobson/commands/main/tools/k8s-manifest.md)

Despliegues Kubernetes de nivel producción.

- **Patrones Avanzados**: Estándares de Seguridad de Pods, Políticas de Red, OPA
- **Preparado para GitOps**: Configuraciones para FluxCD y ArgoCD
- **Observabilidad**: Prometheus ServiceMonitors, OpenTelemetry
- **Autoescalado**: Configuraciones HPA, VPA y autoscaler de clúster
- **Service Mesh**: Integración con Istio/Linkerd

### Frontend y Datos

#### [`/db-migrate`](https://raw.githubusercontent.com/wshobson/commands/main/tools/db-migrate.md)

Estrategias avanzadas para migración de bases de datos.

- **Multi-Base de Datos**: PostgreSQL, MySQL, MongoDB, DynamoDB
- **Sin Tiempo de Inactividad**: Despliegues blue-green, migraciones progresivas
- **Event Sourcing**: Integración Kafka/Kinesis para CDC
- **Multiplataforma**: Maneja persistencia poliglota
- **Monitoreo**: Chequeos de salud de migraciones y reversión

## Combinando Flujos de Trabajo y Herramientas

El verdadero poder viene de combinar flujos de trabajo y herramientas para ciclos completos de desarrollo:

### Ejemplo: Construyendo una Nueva Funcionalidad

```bash
# 1. Use a workflow to implement the feature with multiple subagents
/feature-development Add real-time chat feature with WebSocket support

# 2. Use tools for specific enhancements
/test-harness Add integration tests for WebSocket connections
/security-scan Check for WebSocket vulnerabilities
/docker-optimize Optimize container for WebSocket connections

# 3. Use a workflow for comprehensive review
/full-review Review the entire chat feature implementation
```

### Ejemplo: Modernizando Código Heredado

```bash
# 1. Start with the modernization workflow
/legacy-modernize Migrate Express.js v4 app to modern architecture

# 2. Use specific tools for cleanup
/deps-upgrade Update all dependencies to latest versions
/refactor-clean Remove deprecated patterns and dead code
/test-harness Ensure 100% test coverage

# 3. Optimize and deploy
/docker-optimize Create multi-stage production build
/k8s-manifest Deploy with zero-downtime strategy
```

## Patrones de Orquestación de Comandos

Los comandos pueden usarse individualmente o combinarse en patrones poderosos:

### Ejecución Secuencial
```bash
# Build → Test → Secure → Deploy pipeline
/api-scaffold user management API
/test-harness comprehensive test suite for user API  
/security-scan check user API for vulnerabilities
/k8s-manifest deploy user API to production
```
### Análisis Paralelo

```bash
# Multiple perspectives on the same codebase
/multi-agent-review comprehensive architecture and code review
/security-scan audit security posture  
/performance-optimization identify and fix bottlenecks
# Then consolidate findings
```
### Refinamiento Iterativo

```bash
# Start broad, then narrow focus
/feature-development implement payment processing
/security-scan focus on payment security
/compliance-check ensure PCI compliance
/test-harness add payment-specific tests
```

### Integración entre dominios
```bash
# Frontend + Backend + Infrastructure
/api-scaffold backend payment API
/multi-agent-optimize optimize payment flow performance
/docker-optimize containerize payment service
/monitor-setup payment metrics and alerts
```
## Cuándo Usar Workflows vs Herramientas

### 🔀 Workflows y Herramientas de Subagentes
- **Resolución de problemas**: Analizar y corregir problemas de forma adaptativa
- **Múltiples perspectivas**: Coordinar subagentes especialistas
- **Tareas complejas**: Procesos de múltiples pasos en varios dominios
- **Soluciones desconocidas**: Permitir que los subagentes determinen el enfoque

### 🛠️ Herramientas Especializadas
- **Configuración de infraestructura**: Configurar entornos
- **Generación de código**: Crear implementaciones específicas
- **Análisis**: Generar informes sin correcciones
- **Tareas de dominio**: Operaciones altamente especializadas

**Ejemplos:**
- "Implementar sistema de autenticación de usuarios" → `/feature-development`
- "Corregir problemas de rendimiento en toda la pila" → `/smart-fix`
- "Modernizar monolito legado" → `/legacy-modernize`

### 🔧 Usar Herramientas Cuando:
- **Se requiere experiencia específica** - Tarea clara y enfocada en un dominio
- **Se desea control preciso** - Quieres dirigir detalles específicos de implementación
- **Parte de un flujo de trabajo manual** - Integración en procesos existentes
- **Se requiere especialización profunda** - Implementación a nivel experto
- **Construir sobre trabajo previo** - Mejorar o refinar salidas anteriores

**Ejemplos:**
- "Crear manifiestos de Kubernetes" → `/k8s-manifest`
- "Escanear vulnerabilidades de seguridad" → `/security-scan`
- "Generar documentación de API" → `/doc-generate`

## Formato de Comando

Los comandos slash son archivos markdown simples donde:
- El nombre del archivo se convierte en el nombre del comando (p. ej., `api-scaffold.md` → `/api-scaffold`)
- El contenido del archivo es el prompt/instrucciones que se ejecutan al invocar
- Usar el marcador `$ARGUMENTS` para la entrada del usuario

## Buenas Prácticas

### Selección de Comando
- **Dejar que Claude Code sugiera automáticamente** - Analiza el contexto y selecciona comandos óptimos
- **Usar workflows para tareas complejas** - Subagentes coordinan implementaciones multi-dominio
- **Usar herramientas para tareas focalizadas** - Aplicar comandos específicos para mejoras dirigidas

### Uso Efectivo
- **Proporcionar contexto completo** - Incluir stack tecnológico, restricciones y requisitos
- **Encadenar comandos estratégicamente** - Workflows → Herramientas → Refinamientos
- **Construir sobre salidas previas** - Los comandos están diseñados para trabajar juntos

## Contribuir

1. Crear archivo `.md` en `workflows/` o `tools/`
2. Usar nombres en minúsculas con guiones
3. Incluir `$ARGUMENTS` para entrada del usuario

## Solución de Problemas

**Comando no encontrado**: Verificar que los archivos estén en `~/.claude/commands/`

**Workflows lentos**: Normal - coordinan múltiples subagentes

**Salida genérica**: Añadir contexto más específico sobre tu stack tecnológico

**Problemas de integración**: Verificar rutas de archivos y secuencia de comandos

## Consejos de Rendimiento

**Selección de comando:**
- **Workflows**: Coordinación multi-subagente para funciones complejas
- **Herramientas**: Operaciones de propósito único para tareas específicas
- **Ediciones simples**: Mantenerse con el agente principal

**Optimización:**
- Comenzar con herramientas para problemas conocidos
- Proporcionar requisitos detallados desde el inicio
- Construir sobre salidas de comandos previos
- Dejar que los workflows terminen antes de modificaciones

### Añadiendo un Nuevo Workflow:
- Enfocarse en la orquestación y lógica de delegación de subagentes
- Especificar qué subagentes especializados usar y en qué orden
- Definir patrones de coordinación entre subagentes

### Añadiendo una Nueva Herramienta:
- Incluir implementaciones completas y listas para producción
- Estructurar contenido con secciones claras y salidas accionables
- Incluir ejemplos, mejores prácticas y puntos de integración

## Aprende Más

- [Documentación de Claude Code](https://docs.anthropic.com/en/docs/claude-code)
- [Documentación de Comandos Slash](https://docs.anthropic.com/en/docs/claude-code/slash-commands)
- [Documentación de Subagentes](https://docs.anthropic.com/en/docs/claude-code/sub-agents)
- [Claude Code en GitHub](https://github.com/anthropics/claude-code)
- [Colección de Subagentes de Claude Code](https://github.com/wshobson/agents) - Subagentes especializados usados por estos comandos



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-07

---