
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
- **🤖 Flujos de trabajo**: Orquestación de múltiples subagentes para tareas complejas
- **🔧 Herramientas**: Utilidades de propósito único para operaciones específicas

### 🤝 Requiere Subagentes de Código Claude

Estos comandos funcionan con los [Subagentes de Código Claude](https://github.com/wshobson/agents) para capacidades de orquestación.

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

Los comandos están organizados en los directorios `tools/` y `workflows/`. Úsalos con el prefijo del directorio:

```bash
/tools:api-scaffold user management with authentication
/tools:security-scan check for vulnerabilities
/workflows:feature-development implement chat functionality
```

**Nota:** Si prefiere usar comandos sin prefijos, puede aplanar los directorios:
```bash
cp tools/*.md .
cp workflows/*.md .
```
Claude Code sugiere automáticamente comandos relevantes según el contexto.

## 🤖 Flujos de trabajo

Orquestación multi-subagente para tareas complejas:

### Desarrollo de Funcionalidades
- **[feature-development](https://raw.githubusercontent.com/wshobson/commands/main/workflows/feature-development.md)** - Subagentes de backend, frontend, pruebas y despliegue construyen características completas
- **[full-review](https://raw.githubusercontent.com/wshobson/commands/main/workflows/full-review.md)** - Múltiples subagentes de revisión ofrecen análisis exhaustivo de código
- **[smart-fix](https://raw.githubusercontent.com/wshobson/commands/main/workflows/smart-fix.md)** - Analiza problemas y delega a subagentes especialistas adecuados

### Procesos de Desarrollo
- **[git-workflow](https://raw.githubusercontent.com/wshobson/commands/main/workflows/git-workflow.md)** - Implementa flujos efectivos de Git con estrategias de ramas y plantillas de PR
- **[improve-agent](https://raw.githubusercontent.com/wshobson/commands/main/workflows/improve-agent.md)** - Mejora el desempeño de subagentes mediante optimización de prompts
- **[legacy-modernize](https://raw.githubusercontent.com/wshobson/commands/main/workflows/legacy-modernize.md)** - Moderniza bases de código heredadas con subagentes especializados
- **[ml-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/workflows/ml-pipeline.md)** - Crea pipelines de ML con subagentes de datos e ingeniería de ML
- **[multi-platform](https://raw.githubusercontent.com/wshobson/commands/main/workflows/multi-platform.md)** - Construye aplicaciones multiplataforma con subagentes coordinados
- **[workflow-automate](https://raw.githubusercontent.com/wshobson/commands/main/workflows/workflow-automate.md)** - Automatiza flujos de CI/CD, monitoreo y despliegue

### Flujos Orquestados por Subagentes
- **[full-stack-feature](https://raw.githubusercontent.com/wshobson/commands/main/workflows/full-stack-feature.md)** - Funcionalidades multiplataforma con subagentes de backend, frontend y móvil
- **[security-hardening](https://raw.githubusercontent.com/wshobson/commands/main/workflows/security-hardening.md)** - Implementación con enfoque en seguridad mediante subagentes especializados
- **[data-driven-feature](https://raw.githubusercontent.com/wshobson/commands/main/workflows/data-driven-feature.md)** - Funcionalidades potenciadas por ML con subagentes de ciencia de datos
- **[performance-optimization](https://raw.githubusercontent.com/wshobson/commands/main/workflows/performance-optimization.md)** - Optimización integral con subagentes de rendimiento
- **[incident-response](https://raw.githubusercontent.com/wshobson/commands/main/workflows/incident-response.md)** - Resolución de incidentes en producción con subagentes de operaciones

## 🔧 Herramientas (Comandos de Propósito Único)

### IA y Aprendizaje Automático
- **[ai-assistant](https://raw.githubusercontent.com/wshobson/commands/main/tools/ai-assistant.md)** - Construye asistentes de IA y chatbots listos para producción
- **[ai-review](https://raw.githubusercontent.com/wshobson/commands/main/tools/ai-review.md)** - Revisión especializada para bases de código de IA/ML
- **[langchain-agent](https://raw.githubusercontent.com/wshobson/commands/main/tools/langchain-agent.md)** - Crea agentes LangChain/LangGraph con patrones modernos
- **[ml-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/tools/ml-pipeline.md)** - Crea pipelines de ML de extremo a extremo con MLOps
- **[prompt-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/prompt-optimize.md)** - Optimiza prompts de IA para desempeño y calidad

### Arquitectura y Calidad de Código
- **[code-explain](https://raw.githubusercontent.com/wshobson/commands/main/tools/code-explain.md)** - Genera explicaciones detalladas de código complejo
- **[code-migrate](https://raw.githubusercontent.com/wshobson/commands/main/tools/code-migrate.md)** - Migra código entre lenguajes, frameworks o versiones
- **[refactor-clean](https://raw.githubusercontent.com/wshobson/commands/main/tools/refactor-clean.md)** - Refactoriza código para mantenibilidad y desempeño

- **[tech-debt](https://raw.githubusercontent.com/wshobson/commands/main/tools/tech-debt.md)** - Analiza y prioriza la deuda técnica

### Datos y Base de Datos
- **[data-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/tools/data-pipeline.md)** - Diseña arquitecturas escalables de canalización de datos
- **[data-validation](https://raw.githubusercontent.com/wshobson/commands/main/tools/data-validation.md)** - Implementa sistemas de validación de datos integrales
- **[db-migrate](https://raw.githubusercontent.com/wshobson/commands/main/tools/db-migrate.md)** - Estrategias avanzadas de migración de bases de datos

### DevOps e Infraestructura
- **[deploy-checklist](https://raw.githubusercontent.com/wshobson/commands/main/tools/deploy-checklist.md)** - Genera configuraciones y listas de verificación de despliegue
- **[docker-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/docker-optimize.md)** - Estrategias avanzadas de optimización de contenedores
- **[k8s-manifest](https://raw.githubusercontent.com/wshobson/commands/main/tools/k8s-manifest.md)** - Despliegues de Kubernetes de nivel de producción
- **[monitor-setup](https://raw.githubusercontent.com/wshobson/commands/main/tools/monitor-setup.md)** - Configura monitoreo y observabilidad integral
- **[slo-implement](https://raw.githubusercontent.com/wshobson/commands/main/tools/slo-implement.md)** - Implementa Objetivos de Nivel de Servicio (SLOs)
- **[workflow-automate](https://raw.githubusercontent.com/wshobson/commands/main/tools/workflow-automate.md)** - Automatiza flujos de trabajo de desarrollo y operaciones

### Desarrollo y Pruebas
- **[api-mock](https://raw.githubusercontent.com/wshobson/commands/main/tools/api-mock.md)** - Crea simulaciones realistas de API para desarrollo y pruebas
- **[api-scaffold](https://raw.githubusercontent.com/wshobson/commands/main/tools/api-scaffold.md)** - Genera endpoints de API listos para producción con pila de implementación completa
- **[test-harness](https://raw.githubusercontent.com/wshobson/commands/main/tools/test-harness.md)** - Crea suites de pruebas integrales con detección de frameworks

### Seguridad y Cumplimiento
- **[accessibility-audit](https://raw.githubusercontent.com/wshobson/commands/main/tools/accessibility-audit.md)** - Pruebas integrales de accesibilidad y correcciones
- **[compliance-check](https://raw.githubusercontent.com/wshobson/commands/main/tools/compliance-check.md)** - Garantiza el cumplimiento normativo (GDPR, HIPAA, SOC2)
- **[security-scan](https://raw.githubusercontent.com/wshobson/commands/main/tools/security-scan.md)** - Escaneo de seguridad integral con remediación automatizada

### Depuración y Análisis
- **[debug-trace](https://raw.githubusercontent.com/wshobson/commands/main/tools/debug-trace.md)** - Estrategias avanzadas de depuración y trazado
- **[error-analysis](https://raw.githubusercontent.com/wshobson/commands/main/tools/error-analysis.md)** - Análisis profundo de patrones de errores y estrategias de resolución
- **[error-trace](https://raw.githubusercontent.com/wshobson/commands/main/tools/error-trace.md)** - Rastrea y diagnostica errores en producción
- **[issue](https://raw.githubusercontent.com/wshobson/commands/main/tools/issue.md)** - Crea incidencias bien estructuradas en GitHub/GitLab

### Dependencias y Configuración
- **[config-validate](https://raw.githubusercontent.com/wshobson/commands/main/tools/config-validate.md)** - Valida y gestiona la configuración de la aplicación
- **[deps-audit](https://raw.githubusercontent.com/wshobson/commands/main/tools/deps-audit.md)** - Audita dependencias por seguridad y licencias
- **[deps-upgrade](https://raw.githubusercontent.com/wshobson/commands/main/tools/deps-upgrade.md)** - Actualiza dependencias del proyecto de forma segura

### Documentación y Colaboración
- **[doc-generate](https://raw.githubusercontent.com/wshobson/commands/main/tools/doc-generate.md)** - Genera documentación integral
- **[git-workflow](https://raw.githubusercontent.com/wshobson/commands/main/tools/git-workflow.md)** - Implementa flujos de trabajo efectivos con Git
- **[pr-enhance](https://raw.githubusercontent.com/wshobson/commands/main/tools/pr-enhance.md)** - Mejora las solicitudes de extracción con verificaciones de calidad

### Optimización de Costos
- **[cost-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/cost-optimize.md)** - Optimiza los costos de la nube e infraestructura

### Incorporación y Configuración
- **[onboard](https://raw.githubusercontent.com/wshobson/commands/main/tools/onboard.md)** - Configura entornos de desarrollo para nuevos miembros del equipo

### Herramientas de Subagentes
- **[multi-agent-review](https://raw.githubusercontent.com/wshobson/commands/main/tools/multi-agent-review.md)** - Revisión de código desde múltiples perspectivas con subagentes especializados
- **[smart-debug](https://raw.githubusercontent.com/wshobson/commands/main/tools/smart-debug.md)** - Depuración profunda con subagentes de depuración y rendimiento
- **[multi-agent-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/multi-agent-optimize.md)** - Optimización de stack completo con múltiples subagentes
- **[context-save](https://raw.githubusercontent.com/wshobson/commands/main/tools/context-save.md)** - Guarda el contexto del proyecto usando el subagente gestor de contexto
- **[context-restore](https://raw.githubusercontent.com/wshobson/commands/main/tools/context-restore.md)** - Restaura el contexto guardado para continuidad

## Características

- Implementaciones listas para producción
- Detección automática de frameworks
- Mejores prácticas de seguridad
- Monitoreo y pruebas integrados
- Los comandos funcionan juntos sin problemas

## Conteo de Comandos

**Total: 52 comandos listos para producción** organizados en:

### 🤖 Flujos de Trabajo (14 comandos)

- Desarrollo de funcionalidades y revisión (3 comandos)
- Automatización del proceso de desarrollo (6 comandos)
- Flujos de trabajo orquestados por subagentes (5 comandos)

### 🔧 Herramientas (38 comandos)

- IA y Aprendizaje Automático (5 comandos)
- Arquitectura y Calidad de Código (4 comandos)
- Datos y Base de Datos (3 comandos)
- DevOps e Infraestructura (6 comandos)
- Desarrollo y Pruebas (3 comandos)
- Seguridad y Cumplimiento (3 comandos)
- Depuración y análisis (4 comandos)
- Dependencias y configuración (3 comandos)
- Documentación y colaboración (1 comando)
- Incorporación y configuración (1 comando)
- Herramientas específicas de subagente (5 comandos)

## Ejemplos de uso

### 🤖 Ejemplos de flujo de trabajo

```bash
# Implement a complete feature
/workflows:feature-development Add user authentication with OAuth2

# Comprehensive code review
/workflows:full-review Review the authentication module

# Smart issue resolution
/workflows:smart-fix Fix performance degradation in API response times

# Modernize legacy system
/workflows:legacy-modernize Migrate monolithic Java app to microservices

# Build comprehensive multi-platform feature
/workflows:full-stack-feature User authentication with social login across web and mobile

# Implement security-first architecture
/workflows:security-hardening Harden API endpoints and implement zero-trust security model

# Create data-driven ML feature
/workflows:data-driven-feature Build recommendation engine with real-time personalization

# Optimize entire application stack
/workflows:performance-optimization Improve response times and reduce infrastructure costs

# Respond to production incident
/workflows:incident-response High CPU usage causing service degradation in production
```

### 🔧 Ejemplos de herramientas (comandos de un solo propósito)

```bash
# Create a user management API
/tools:api-scaffold user CRUD operations with JWT auth and role-based access

# Review microservices architecture
/tools:multi-agent-review analyze our microservices for coupling and scalability issues

# Optimize LLM chat application
/tools:prompt-optimize reduce latency for customer support chatbot while maintaining accuracy

# Create fraud detection pipeline
/tools:data-pipeline real-time fraud detection with feature store and monitoring

# Debug production issue
/tools:error-trace analyze high memory usage in production pods

# Secure container images
/tools:security-scan scan and fix vulnerabilities in Docker images

# Generate API documentation
/tools:doc-generate create OpenAPI docs with examples for REST endpoints

# Onboard new developer
/tools:onboard Setup development environment for React/Node.js project

# Multi-perspective code review
/tools:multi-agent-review Review authentication module

# Deep debugging
/tools:smart-debug Investigate memory leak in production workers

# Full-stack optimization
/tools:multi-agent-optimize Optimize checkout flow for better conversion

# Save project context
/tools:context-save Save current project state and architectural decisions

# Restore project context
/tools:context-restore Load context from last week's sprint
```

## Comandos Mejorados

### Seguridad y DevOps

#### [`/security-scan`](https://raw.githubusercontent.com/wshobson/commands/main/tools/security-scan.md)

Escaneo de seguridad integral con remediación automatizada.

- **Escaneo Multiherramienta**: Bandit, Safety, Trivy, Semgrep, ESLint Security, Snyk
- **Correcciones Automáticas**: Vulnerabilidades comunes remediadas automáticamente
- **Integración CI/CD**: Puertas de seguridad para GitHub Actions/GitLab CI
- **Escaneo de Contenedores**: Análisis de vulnerabilidades de imágenes
- **Detección de Secretos**: Integración con GitLeaks y TruffleHog

#### [`/docker-optimize`](https://raw.githubusercontent.com/wshobson/commands/main/tools/docker-optimize.md)

Estrategias avanzadas de optimización de contenedores.

- **Optimización Inteligente**: Analiza y sugiere mejoras
- **Construcción Multietapa**: Dockerfiles optimizados específicos para frameworks
- **Herramientas Modernas**: BuildKit, Bun, UV para compilaciones más rápidas
- **Refuerzo de Seguridad**: Imágenes distroless, usuarios sin privilegios
- **Integración entre Comandos**: Funciona con salidas de /api-scaffold

#### [`/k8s-manifest`](https://raw.githubusercontent.com/wshobson/commands/main/tools/k8s-manifest.md)

Despliegues de Kubernetes a nivel de producción.

- **Patrones Avanzados**: Estándares de seguridad de pods, políticas de red, OPA
- **Preparado para GitOps**: Configuraciones de FluxCD y ArgoCD
- **Observabilidad**: ServiceMonitors de Prometheus, OpenTelemetry
- **Autoescalado**: Configuraciones de HPA, VPA y autoscaler de clúster
- **Malla de Servicios**: Integración con Istio/Linkerd

### Frontend y Datos

#### [`/db-migrate`](https://raw.githubusercontent.com/wshobson/commands/main/tools/db-migrate.md)

Estrategias avanzadas de migración de bases de datos.

- **Multi-Database**: PostgreSQL, MySQL, MongoDB, DynamoDB
- **Sin Tiempo de Inactividad**: Despliegues blue-green, migraciones rodantes
- **Event Sourcing**: Integración con Kafka/Kinesis para CDC
- **Multiplataforma**: Maneja persistencia poliglota
- **Monitoreo**: Verificaciones de salud de migraciones y reversión

## Combinando Flujos de Trabajo y Herramientas

El verdadero poder proviene de combinar flujos de trabajo y herramientas para ciclos completos de desarrollo:

### Ejemplo: Creando una Nueva Funcionalidad

```bash
# 1. Use a workflow to implement the feature with multiple subagents
/workflows:feature-development Add real-time chat feature with WebSocket support

# 2. Use tools for specific enhancements
/tools:test-harness Add integration tests for WebSocket connections
/tools:security-scan Check for WebSocket vulnerabilities
/tools:docker-optimize Optimize container for WebSocket connections

# 3. Use a workflow for comprehensive review
/workflows:full-review Review the entire chat feature implementation
```

### Ejemplo: Modernizando Código Heredado

```bash
# 1. Start with the modernization workflow
/workflows:legacy-modernize Migrate Express.js v4 app to modern architecture

# 2. Use specific tools for cleanup
/tools:deps-upgrade Update all dependencies to latest versions
/tools:refactor-clean Remove deprecated patterns and dead code
/tools:test-harness Ensure 100% test coverage

# 3. Optimize and deploy
/tools:docker-optimize Create multi-stage production build
/tools:k8s-manifest Deploy with zero-downtime strategy
```

## Patrones de Orquestación de Comandos

Los comandos pueden usarse individualmente o combinarse en patrones poderosos:

### Ejecución Secuencial
```bash
# Build → Test → Secure → Deploy pipeline
/tools:api-scaffold user management API
/tools:test-harness comprehensive test suite for user API  
/tools:security-scan check user API for vulnerabilities
/tools:k8s-manifest deploy user API to production
```
### Análisis Paralelo

```bash
# Multiple perspectives on the same codebase
/tools:multi-agent-review comprehensive architecture and code review
/tools:security-scan audit security posture  
/workflows:performance-optimization identify and fix bottlenecks
# Then consolidate findings
```
### Refinamiento Iterativo

```bash
# Start broad, then narrow focus
/workflows:feature-development implement payment processing
/tools:security-scan focus on payment security
/tools:compliance-check ensure PCI compliance
/tools:test-harness add payment-specific tests
```

### Integración entre dominios
```bash
# Frontend + Backend + Infrastructure
/tools:api-scaffold backend payment API
/tools:multi-agent-optimize optimize payment flow performance
/tools:docker-optimize containerize payment service
/tools:monitor-setup payment metrics and alerts
```

## Cuándo usar Flujos de Trabajo vs Herramientas

### 🔀 Flujos de trabajo y herramientas de subagente
- **Resolución de problemas**: Analizar y solucionar problemas de forma adaptativa
- **Múltiples perspectivas**: Coordinar subagentes especialistas
- **Tareas complejas**: Procesos de varios pasos en diferentes dominios
- **Soluciones desconocidas**: Permitir que los subagentes determinen el enfoque

### 🛠️ Herramientas especializadas
- **Configuración de infraestructura**: Configurar entornos
- **Generación de código**: Crear implementaciones específicas
- **Análisis**: Generar informes sin aplicar correcciones
- **Tareas de dominio**: Operaciones altamente especializadas

**Ejemplos:**
- "Implementar sistema de autenticación de usuarios" → `/workflows:feature-development`
- "Solucionar problemas de rendimiento en toda la pila" → `/workflows:smart-fix`
- "Modernizar monolito heredado" → `/workflows:legacy-modernize`

### 🔧 Usar herramientas cuando:
- **Se necesita experiencia específica** - Tarea clara y enfocada en un solo dominio
- **Se desea control preciso** - Querer dirigir detalles específicos de implementación
- **Parte de un flujo de trabajo manual** - Integración en procesos existentes
- **Se requiere alta especialización** - Necesidad de implementación a nivel experto
- **Basado en trabajo existente** - Mejorar o refinar resultados previos

**Ejemplos:**
- "Crear manifiestos de Kubernetes" → `/tools:k8s-manifest`
- "Escanear vulnerabilidades de seguridad" → `/tools:security-scan`
- "Generar documentación de API" → `/tools:doc-generate`

## Formato de comando

Los comandos de barra son archivos markdown simples donde:
- El nombre del archivo se convierte en el nombre del comando (ej.: `tools/api-scaffold.md` → `/tools:api-scaffold`)
- El contenido del archivo es el prompt/instrucciones ejecutadas al invocar
- Use el marcador `$ARGUMENTS` para la entrada del usuario

## Mejores prácticas

### Selección de Comandos
- **Deja que Claude Code sugiera automáticamente** - Analiza el contexto y selecciona los comandos óptimos
- **Usa flujos de trabajo para tareas complejas** - Subagentes coordinan implementaciones multidominio
- **Usa herramientas para tareas enfocadas** - Aplica comandos específicos para mejoras dirigidas

### Uso Efectivo
- **Proporciona contexto integral** - Incluye pila tecnológica, restricciones y requisitos
- **Encadena comandos estratégicamente** - Flujos de trabajo → Herramientas → Refinamientos
- **Construye sobre salidas previas** - Los comandos están diseñados para funcionar juntos

## Contribuir

1. Crea archivo `.md` en `workflows/` o `tools/`
2. Usa nombres en minúscula-con-guiones
3. Incluye `$ARGUMENTS` para la entrada del usuario

## Resolución de Problemas

**Comando no encontrado**: 
- Verifica que los archivos estén en `~/.claude/commands/tools/` o `~/.claude/commands/workflows/`
- Usa el prefijo correcto: `/tools:nombre-del-comando` o `/workflows:nombre-del-comando`
- O aplana los directorios si prefieres sin prefijos: `cp tools/*.md . && cp workflows/*.md .`

**Flujos de trabajo lentos**: Normal - coordinan múltiples subagentes

**Salida genérica**: Añade contexto más específico sobre tu pila tecnológica

**Problemas de integración**: Verifica rutas de archivos y secuencia de comandos

## Consejos de Rendimiento

**Selección de Comandos:**
- **Flujos de trabajo**: Coordinación de múltiples subagentes para funciones complejas
- **Herramientas**: Operaciones de un solo propósito para tareas específicas
- **Ediciones simples**: Quédate con el agente principal

**Optimización:**
- Comienza con herramientas para problemas conocidos
- Proporciona requisitos detallados desde el inicio
- Basarse en las salidas de comandos previas
- Permitir que los flujos de trabajo se completen antes de realizar modificaciones

### Añadiendo un Nuevo Flujo de Trabajo:
- Enfocarse en la orquestación y lógica de delegación de subagentes
- Especificar qué subagentes especializados usar y en qué orden
- Definir patrones de coordinación entre subagentes

### Añadiendo una Nueva Herramienta:
- Incluir implementaciones completas y listas para producción
- Estructurar el contenido con secciones claras y salidas accionables
- Incluir ejemplos, mejores prácticas y puntos de integración

## Más Información

- [Documentación de Claude Code](https://docs.anthropic.com/en/docs/claude-code)
- [Documentación de Slash Commands](https://docs.anthropic.com/en/docs/claude-code/slash-commands)
- [Documentación de Subagentes](https://docs.anthropic.com/en/docs/claude-code/sub-agents)
- [Claude Code en GitHub](https://github.com/anthropics/claude-code)
- [Colección de Subagentes Claude Code](https://github.com/wshobson/agents) - Subagentes especializados utilizados por estos comandos


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-08

---