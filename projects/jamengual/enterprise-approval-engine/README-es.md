# Motor de Aprobación Empresarial

[![en](https://img.shields.io/badge/lang-en-blue.svg)](README.md)
[![es](https://img.shields.io/badge/lang-es-yellow.svg)](ES/README.md)

Acción de GitHub de nivel empresarial para flujos de trabajo de aprobación basados en políticas con umbrales por grupo (X de N), lógica OR entre grupos y creación automática de etiquetas semver.

## Características

- **Lógica de Aprobación Flexible**: Soporte tanto para lógica AND (todos deben aprobar) como para lógica de umbral (X de N) dentro de grupos
- **Lógica OR Entre Grupos**: Múltiples rutas de aprobación: cualquier grupo que cumpla los requisitos aprueba la solicitud
- **Aprobadores Mixtos**: Combina usuarios individuales y equipos de GitHub en el mismo grupo
- **Pipelines de Despliegue Progresivos**: Seguimiento de un solo issue a través de múltiples entornos (dev → qa → stage → prod)
- **Visualización del Pipeline**: Diagramas de flujo Mermaid codificados por colores que muestran el progreso del despliegue
- **Aprobaciones de Sub-Issues**: Crear sub-issues de aprobación dedicados para cada etapa - cerrar para aprobar
- **Experiencia Mejorada en Comentarios**: Reacciones con emojis en comentarios de aprobación, sección de Acciones Rápidas con referencia de comandos
- **Protección Contra Cierre de Issues**: Evita que usuarios no autorizados cierren issues de aprobación (reapertura automática)
- **Modos de Aprobación Híbridos**: Mezcla aprobaciones basadas en comentarios y sub-issues por flujo de trabajo o etapa
- **Seguimiento de PRs y Commits**: Lista automática de PRs y commits en issues de despliegue para gestión de versiones
- **Creación de Etiquetas Semver**: Creación automática de etiquetas git tras la aprobación
- **Configuración Basada en Políticas**: Define políticas de aprobación reutilizables en YAML
- **Flujo de Trabajo Basado en Issues**: Registro de auditoría transparente mediante issues de GitHub
- **Integración con Jira**: Extrae claves de issues de commits, muestra en issues de aprobación, actualiza Fix Versions
- **Seguimiento de Despliegues**: Crea despliegues de GitHub para visibilidad en el panel de despliegue
- **Configuración Externa**: Centraliza políticas de aprobación en un repositorio compartido
- **Manejo de Límite de Tasa**: Reintentos automáticos con retroceso exponencial para límites de la API de GitHub
- **GitHub Enterprise Server**: Soporte completo para entornos GHES
- **Sin Dependencias Externas**: Acción GitHub pura, no requiere servicios externos

📋 **Véalo en acción:** [Ejemplo de issue de aprobación](https://github.com/jamengual/enterprise-approval-engine/issues/7)

## Tabla de Contenidos

- [Inicio Rápido](#quick-start)
- [Referencia de la Acción](#action-reference)
  - [Acciones](#actions)
  - [Entradas](#inputs)
  - [Salidas](#outputs)
- [Referencia de Configuración](#configuration-reference)
  - [Políticas](#policies)
  - [Flujos de trabajo](#workflows)
  - [Etiquetado](#tagging-configuration)
  - [Plantillas personalizadas](#custom-issue-templates)
  - [Valores predeterminados](#defaults)
  - [Semver](#semver)
- [Referencia completa de configuración](#complete-configuration-reference)
- [Detalles de la función](#feature-details)
  - [Palabras clave de aprobación](#approval-keywords)
  - [Soporte de equipo](#team-support)
  - [Canales de implementación progresiva](#progressive-deployment-pipelines)
  - [Estrategias de candidatos a lanzamiento](#release-candidate-strategies)
  - [Integración con Jira](#jira-integration)
  - [Seguimiento de implementaciones](#deployment-tracking)
  - [Repositorio de configuración externo](#external-config-repository)
  - [Aprobaciones bloqueantes](#blocking-approvals)
  - [Eliminación de etiquetas](#tag-deletion-on-issue-close)
- [Ejemplos completos](#complete-examples)
- [Validación de esquema](#schema-validation)
- [Servidor GitHub Enterprise](#github-enterprise-server)

## Inicio rápido

### 1. Crear configuración

Crea `.github/approvals.yml` en tu repositorio:

```yaml
version: 1

policies:
  dev-team:
    approvers: [alice, bob, charlie]
    min_approvals: 2

  platform-team:
    approvers: [team:platform-engineers]
    require_all: true

workflows:
  production-deploy:
    require:
      # OR logic: either path satisfies approval
      - policy: dev-team        # 2 of 3 developers
      - policy: platform-team   # ALL platform engineers
    on_approved:
      create_tag: true
      close_issue: true
```

### 2. Flujo de trabajo de aprobación de solicitudes

Cree `.github/workflows/request-approval.yml`:

```yaml
name: Request Deployment Approval

on:
  workflow_dispatch:
    inputs:
      version:
        description: 'Version to deploy (e.g., v1.2.3)'
        required: true
        type: string

jobs:
  request:
    runs-on: ubuntu-latest
    steps:
      - uses: actions/checkout@v4
      - uses: jamengual/enterprise-approval-engine@v1
        id: approval
        with:
          action: request
          workflow: production-deploy
          version: ${{ inputs.version }}
          token: ${{ secrets.GITHUB_TOKEN }}

      - name: Output Results
        run: |
          echo "Issue: ${{ steps.approval.outputs.issue_url }}"
          echo "Status: ${{ steps.approval.outputs.status }}"
```

### 3. Manejar Comentarios de Aprobación

Cree `.github/workflows/handle-approval.yml`:

```yaml
name: Handle Approval Comments

on:
  issue_comment:
    types: [created]

jobs:
  process:
    if: contains(github.event.issue.labels.*.name, 'approval-required')
    runs-on: ubuntu-latest
    steps:
      - uses: actions/checkout@v4
      - uses: jamengual/enterprise-approval-engine@v1
        id: process
        with:
          action: process-comment
          issue_number: ${{ github.event.issue.number }}
          token: ${{ secrets.GITHUB_TOKEN }}

      - name: Trigger Deployment
        if: steps.process.outputs.status == 'approved'
        run: |
          echo "Approved by: ${{ steps.process.outputs.approvers }}"
          echo "Tag created: ${{ steps.process.outputs.tag }}"
```

---

## Referencia de Acción

### Acciones

La acción soporta cuatro modos de operación vía la entrada `action`:

| Acción | Descripción | Cuándo usar |
|--------|-------------|-------------|
| `request` | Crear un nuevo issue de solicitud de aprobación | Al iniciar un flujo de trabajo de despliegue/liberación |
| `process-comment` | Procesar un comentario de aprobación/denegación | En eventos `issue_comment` |
| `check` | Verificar el estado actual de la aprobación | Para sondear la finalización de la aprobación |
| `close-issue` | Manejar eventos de cierre de issue | En eventos `issues: [closed]` |

### Entradas

#### Entradas principales

| Entrada | Descripción | Requerido | Predeterminado |
|-------|-------------|----------|---------|
| `action` | Acción a realizar: `request`, `check`, `process-comment`, `close-issue` | Sí | - |
| `workflow` | Nombre del flujo de trabajo desde la configuración (para acción `request`) | Para `request` | - |
| `version` | Versión Semver para creación de tag (ej., `1.2.3` o `v1.2.3`) | No | - |
| `issue_number` | Número del issue (para `check`, `process-comment`, `close-issue`) | Para check/process/close | - |
| `token` | Token de GitHub para operaciones API | Sí | - |

#### Entradas de configuración

| Entrada | Descripción | Requerido | Predeterminado |
|-------|-------------|----------|---------|
| `config_path` | Ruta al archivo de configuración approvals.yml | No | `.github/approvals.yml` |
| `config_repo` | Repositorio externo para configuración compartida (ej., `org/.github`) | No | - |

#### Entradas de sondeo (para acción `check`)

| Entrada | Descripción | Requerido | Predeterminado |
|-------|-------------|----------|---------|
| `wait` | Esperar aprobación (sondeo) en vez de devolver inmediatamente | No | `false` |
| `timeout` | Tiempo de espera para la espera (por ejemplo, `24h`, `1h30m`, `30m`) | No | `72h` |

#### Entradas de soporte de equipo

| Entrada | Descripción | Requerido | Predeterminado |
|---------|-------------|-----------|----------------|
| `app_id` | ID de la aplicación GitHub para verificaciones de membresía en el equipo | No | - |
| `app_private_key` | Clave privada de la aplicación GitHub para verificaciones de membresía en el equipo | No | - |

#### Entradas de integración Jira

| Entrada | Descripción | Requerido | Predeterminado |
|---------|-------------|-----------|----------------|
| `jira_base_url` | URL base de Jira Cloud (por ejemplo, `https://yourcompany.atlassian.net`) | No | - |
| `jira_user_email` | Correo electrónico de usuario de Jira para autenticación API | No | - |
| `jira_api_token` | Token API de Jira para autenticación | No | - |
| `jira_update_fix_version` | Actualizar los issues de Jira con la versión de corrección al aprobar | No | `true` |
| `include_jira_issues` | Incluir issues de Jira en el cuerpo de la solicitud de aprobación | No | `true` |

#### Entradas de seguimiento de despliegue

| Entrada | Descripción | Requerido | Predeterminado |
|---------|-------------|-----------|----------------|
| `create_deployment` | Crear un despliegue en GitHub para seguimiento | No | `true` |
| `deployment_environment` | Entorno objetivo (por ejemplo, `production`, `staging`) | No | `production` |
| `deployment_environment_url` | URL del entorno desplegado | No | - |

#### Otras entradas

| Entrada | Descripción | Requerido | Predeterminado |
|---------|-------------|-----------|----------------|
| `issue_action` | Acción del evento del issue para `close-issue` (`closed`, `reopened`) | No | - |
| `previous_tag` | Etiqueta anterior para comparar commits (detectada automáticamente si no se especifica) | No | - |

### Salidas

#### Salidas principales

| Salida | Descripción | Disponible para |
|--------|-------------|----------------|
| `status` | Estado de la aprobación: `pending`, `approved`, `denied`, `timeout`, `tag_deleted`, `skipped` | Todas las acciones |
| `issue_number` | Número del issue creado o revisado | Todas las acciones |
| `issue_url` | URL del issue de aprobación | Todas las acciones |

#### Salidas de Aprobación

| Salida | Descripción | Disponible Para |
|--------|-------------|----------------|
| `approvers` | Lista separada por comas de usuarios que aprobaron | `process-comment`, `check` |
| `denier` | Usuario que negó la solicitud | `process-comment`, `check` |
| `satisfied_group` | Nombre del grupo que satisfizo la aprobación | `process-comment`, `check` |
| `tag` | Nombre de la etiqueta creada | `process-comment` (en aprobación) |
| `tag_deleted` | Etiqueta que fue eliminada | `close-issue` |

#### Salidas de Jira

| Salida | Descripción | Disponible Para |
|--------|-------------|----------------|
| `jira_issues` | Lista separada por comas de claves de issues de Jira en esta versión | `request` |
| `jira_issues_json` | Array JSON con detalles de issues de Jira (clave, resumen, tipo, estado) | `request` |

#### Salidas de Despliegue

| Salida | Descripción | Disponible Para |
|--------|-------------|----------------|
| `deployment_id` | ID de despliegue de GitHub para actualizaciones de estado | `request` |
| `deployment_url` | URL al despliegue en GitHub | `request` |

#### Salidas de Notas de Versión

| Salida | Descripción | Disponible Para |
|--------|-------------|----------------|
| `release_notes` | Notas de versión generadas automáticamente a partir de commits e issues de Jira | `request` |
| `commits_count` | Número de commits en esta versión | `request` |

---

## Referencia de Configuración

### Políticas

Las políticas definen grupos reutilizables de aprobadores. Hay dos formatos:

#### Formato simple

```yaml
policies:
  # Threshold-based: X of N must approve
  dev-team:
    approvers: [alice, bob, charlie]
    min_approvals: 2

  # All must approve (AND logic)
  security:
    approvers: [team:security, security-lead]
    require_all: true

  # Mixed teams and individuals
  production:
    approvers:
      - team:sre
      - tech-lead
      - product-owner
    min_approvals: 2
```

#### Formato avanzado (umbrales por fuente)

Para requisitos complejos como "2 de plataforma Y 1 de seguridad":

```yaml
policies:
  # Complex AND gate
  production-gate:
    from:
      - team: platform-engineers
        min_approvals: 2        # 2 of the platform team
      - team: security
        min_approvals: 1        # 1 of the security team
      - user: alice             # alice must also approve
    logic: and                  # ALL sources must be satisfied

  # Flexible OR gate
  flexible-review:
    from:
      - team: security
        require_all: true       # All security team
      - team: platform
        min_approvals: 2        # OR 2 platform members
    logic: or                   # ANY source is enough

  # Executive approval: any one exec
  exec-approval:
    from:
      - user: ceo
      - user: cto
      - user: vp-engineering
    logic: or

  # User list with threshold
  leads:
    from:
      - users: [tech-lead, product-lead, design-lead]
        min_approvals: 2
```

**Tipos de fuente:**

- `team: slug` - Equipo de GitHub (requiere token de App)
- `user: username` - Usuario único (requerimiento implícito de todos)
- `users: [a, b, c]` - Lista de usuarios

**Lógica a nivel de política:**

- `logic: and` - TODAS las fuentes deben cumplirse (por defecto)
- `logic: or` - CUALQUIER fuente cumplida es suficiente

#### Lógica en línea (mezcla AND/OR)

Para expresiones complejas, use `logic:` en cada fuente para especificar cómo se conecta con la siguiente:

```yaml
policies:
  # (2 security AND 2 platform) OR alice
  complex-gate:
    from:
      - team: security
        min_approvals: 2
        logic: and              # AND with next source
      - team: platform
        min_approvals: 2
        logic: or               # OR with next source
      - user: alice            # alice alone can satisfy

  # (security AND platform) OR (alice AND bob) OR manager
  multi-path:
    from:
      - team: security
        min_approvals: 1
        logic: and
      - team: platform
        min_approvals: 1
        logic: or               # End first AND group
      - user: alice
        logic: and
      - user: bob
        logic: or               # End second AND group
      - user: manager          # Third path
```

**Precedencia de operadores:** AND tiene mayor prioridad que OR (lógica booleana estándar).

La expresión `A and B or C and D` se evalúa como `(A AND B) OR (C AND D)`.

### Flujos de trabajo

Los flujos de trabajo definen los requisitos de aprobación y las acciones:

```yaml
workflows:
  my-workflow:
    description: "Optional description"

    # Trigger conditions (for filtering)
    trigger:
      environment: production

    # Approval requirements (OR logic between items)
    require:
      - policy: dev-team
      - policy: security
      # Or inline approvers:
      - approvers: [alice, bob]
        require_all: true

    # Issue configuration
    issue:
      title: "Approval: {{version}}"
      body: |                          # Inline custom template (optional)
        ## My Custom Approval Issue
        Version: {{.Version}}
        Requested by: @{{.Requestor}}
        {{.GroupsTable}}
      body_file: "templates/my-template.md"  # Or load from file
      labels: [production, deploy]
      assignees_from_policy: true

    # Actions on approval
    on_approved:
      create_tag: true
      tag_prefix: "v"  # Creates v1.2.3
      close_issue: true
      comment: "Approved! Tag {{version}} created."

    # Actions on denial
    on_denied:
      close_issue: true
      comment: "Denied by {{denier}}."

    # Actions when issue is manually closed
    on_closed:
      delete_tag: true   # Delete the tag if issue is closed
      comment: "Deployment cancelled. Tag {{tag}} deleted."
```

### Configuración de Etiquetas

Controla cómo se crean las etiquetas por flujo de trabajo:

```yaml
workflows:
  dev-deploy:
    require:
      - policy: dev-team
    on_approved:
      tagging:
        enabled: true
        start_version: "0.1.0"      # No 'v' prefix, start at 0.1.0
        auto_increment: patch        # Auto-bump: 0.1.0 -> 0.1.1 -> 0.1.2
        env_prefix: "dev-"           # Creates: dev-0.1.0, dev-0.1.1

  staging-deploy:
    require:
      - policy: qa-team
    on_approved:
      tagging:
        enabled: true
        start_version: "v1.0.0"     # 'v' prefix (inferred from start_version)
        auto_increment: minor        # v1.0.0 -> v1.1.0 -> v1.2.0
        env_prefix: "staging-"       # Creates: staging-v1.0.0

  production-deploy:
    require:
      - policy: prod-team
    on_approved:
      tagging:
        enabled: true
        start_version: "v1.0.0"     # Manual version required (no auto_increment)
```

**Opciones de etiquetado:**

| Opción | Descripción |
|--------|-------------|
| `enabled` | Habilitar creación de etiquetas |
| `start_version` | Versión inicial y formato (ej., "v1.0.0" o "1.0.0") |
| `prefix` | Prefijo de versión (inferido de `start_version` si no se establece) |
| `auto_increment` | Auto-incremento: `major`, `minor`, `patch`, o omitir para manual |
| `env_prefix` | Prefijo de entorno (ej., "dev-" crea "dev-v1.0.0") |

### Plantillas de Issue Personalizadas

Puedes personalizar completamente el cuerpo del issue usando plantillas Go. Usa `body` para plantillas en línea o `body_file` para cargar desde un archivo.

**Variables de plantilla disponibles:**

| Variable | Descripción |
|----------|-------------|
| `{{.Title}}` | Título del issue |
| `{{.Description}}` | Descripción del flujo de trabajo |
| `{{.Version}}` | Versión semver |
| `{{.Requestor}}` | Usuario de GitHub que solicitó |
| `{{.Environment}}` | Nombre del entorno |
| `{{.RunURL}}` | Enlace a la ejecución del flujo de trabajo |
| `{{.RepoURL}}` | URL del repositorio |
| `{{.CommitSHA}}` | SHA completo del commit |
| `{{.CommitURL}}` | Enlace al commit |
| `{{.Branch}}` | Nombre de la rama |
| `{{.GroupsTable}}` | Tabla pre-renderizada de estado de aprobación |
| `{{.Timestamp}}` | Marca temporal de la solicitud |
| `{{.PreviousVersion}}` | Versión/etiqueta anterior |
| `{{.CommitsCount}}` | Número de commits en esta versión |
| `{{.HasJiraIssues}}` | Booleano - si existen issues de Jira |
| `{{.JiraIssues}}` | Array de datos de issues de Jira |
| `{{.JiraIssuesTable}}` | Tabla pre-renderizada de issues de Jira |
| `{{.PipelineTable}}` | Tabla pre-renderizada de la pipeline de despliegue |
| `{{.PipelineMermaid}}` | Diagrama de flujo Mermaid pre-renderizado |
| `{{.Vars.key}}` | Variables personalizadas |

**Funciones de plantilla:**

| Función | Ejemplo | Descripción |
|----------|---------|-------------|
| `slice` | `{{slice .CommitSHA 0 7}}` | Subcadena (SHA corto) |
| `title` | `{{.Environment \| title}}` | Mayúscula inicial |
| `upper` | `{{.Version \| upper}}` | Mayúsculas |
| `lower` | `{{.Version \| lower}}` | Minúsculas |
| `join` | `{{join .Groups ","}}` | Unir arreglo |
| `contains` | `{{if contains .Branch "feature"}}` | Verificar subcadena |
| `replace` | `{{replace .Version "v" ""}}` | Reemplazar cadena |
| `default` | `{{default "N/A" .Environment}}` | Valor por defecto |

**Ejemplo de archivo de plantilla personalizado** (`.github/templates/deploy.md`):

```markdown
## {{.Title}}

### Release Information

- **Version:** `{{.Version}}`
- **Requested by:** @{{.Requestor}}
{{- if .CommitSHA}}
- **Commit:** [{{slice .CommitSHA 0 7}}](https://raw.githubusercontent.com/jamengual/enterprise-approval-engine/main/{{.CommitURL}})
{{- end}}
{{- if .CommitsCount}}
- **Changes:** {{.CommitsCount}} commits since {{.PreviousVersion}}
{{- end}}

{{if .HasJiraIssues}}
### Jira Issues

{{.JiraIssuesTable}}
{{end}}

### Approval Status

{{.GroupsTable}}

---

**Approve:** Comment `approve` | **Deny:** Comment `deny`
```

### Valores predeterminados

Valores predeterminados globales que se aplican a todos los flujos de trabajo:

```yaml
defaults:
  timeout: 72h                    # Default approval timeout
  allow_self_approval: false      # Whether requestors can approve their own requests
  issue_labels:                   # Labels added to all approval issues
    - approval-required
```

### Semver

Configurar el manejo de versiones:

```yaml
semver:
  prefix: "v"              # Tag prefix (v1.2.3)
  strategy: input          # Use version from input
  validate: true           # Validate semver format
  allow_prerelease: true   # Allow prerelease versions (e.g., v1.0.0-beta.1)
  auto:                    # Label-based auto-increment (when strategy: auto)
    major_labels: [breaking, major]
    minor_labels: [feature, minor]
    patch_labels: [fix, patch, bug]
```

---

## Referencia Completa de Configuración

Esta sección documenta **todas las opciones de configuración** disponibles en `approvals.yml`.

### Estructura de Nivel Superior

```yaml
version: 1                    # Required: config version (always 1)
defaults: { ... }             # Optional: global defaults
policies: { ... }             # Required: reusable approval policies
workflows: { ... }            # Required: approval workflows
semver: { ... }               # Optional: version handling settings
```

### Opciones de `defaults`

| Clave | Tipo | Predeterminado | Descripción |
|-----|------|---------|-------------|
| `timeout` | duración | `72h` | Tiempo de espera para la acción `check` bloqueante con `wait: true`. Usar horas (p. ej., `168h` para 1 semana). No necesario para flujos de trabajo basados en eventos. |
| `allow_self_approval` | bool | `false` | Si el solicitante puede aprobar su propia solicitud |
| `issue_labels` | string[] | `[]` | Etiquetas añadidas a todos los problemas de aprobación |

### Opciones `policies.<name>` (Formato Simple)

| Clave | Tipo | Predeterminado | Descripción |
|-----|------|---------|-------------|
| `approvers` | string[] | - | Lista de nombres de usuario o referencias `team:slug` |
| `min_approvals` | int | 0 | Número de aprobaciones requeridas (0 = usar `require_all`) |
| `require_all` | bool | `false` | Si es verdadero, TODOS los aprobadores deben aprobar |

### Opciones `policies.<name>` (Formato Avanzado)

| Clave | Tipo | Predeterminado | Descripción |
|-----|------|---------|-------------|
| `from` | source[] | - | Lista de fuentes de aprobadores con umbrales individuales |
| `logic` | string | `"and"` | Cómo combinar fuentes: `"and"` o `"or"` |

**Opciones de Fuente de Aprobador (`from[]`):**

| Clave | Tipo | Predeterminado | Descripción |
|-----|------|---------|-------------|
| `team` | string | - | Slug del equipo (p. ej., `"platform"` o `"org/platform"`) |
| `user` | string | - | Nombre de usuario único |
| `users` | string[] | - | Lista de nombres de usuario |
| `min_approvals` | int | 1 | Aprobaciones requeridas de esta fuente |
| `require_all` | bool | `false` | Todos de esta fuente deben aprobar |
| `logic` | string | - | Lógica hacia la siguiente fuente: `"and"` o `"or"` |

### Opciones `workflows.<name>`

| Clave | Tipo | Predeterminado | Descripción |
|-----|------|---------|-------------|
| `description` | string | - | Descripción legible para humanos |
| `trigger` | mapa | - | Condiciones de activación (para filtrado) |
| `require` | requerimiento[] | - | **Requerido:** Requisitos de aprobación (lógica OR entre ítems) |
| `issue` | objeto | - | Configuración de creación de incidencia |
| `on_approved` | objeto | - | Acciones cuando se aprueba |
| `on_denied` | objeto | - | Acciones cuando se deniega |
| `on_closed` | objeto | - | Acciones cuando la incidencia se cierra manualmente |
| `pipeline` | objeto | - | Configuración de pipeline de despliegue progresivo |

### Opciones de `workflows.<name>.require[]`

| Clave | Tipo | Por defecto | Descripción |
|-------|------|-------------|-------------|
| `policy` | cadena | - | Referencia a una política definida |
| `approvers` | cadena[] | - | Aprobadores en línea (alternativa a la política) |
| `min_approvals` | int | - | Sobrescribir min_approvals de la política |
| `require_all` | bool | - | Sobrescribir require_all de la política |

### Opciones de `workflows.<name>.issue`

| Clave | Tipo | Por defecto | Descripción |
|-------|------|-------------|-------------|
| `title` | cadena | `"Approval Required: {workflow}"` | Título de la incidencia (soporta `{{version}}`, `{{environment}}`, `{{workflow}}`) |
| `body` | cadena | - | Plantilla personalizada para el cuerpo de la incidencia (sintaxis plantilla Go) |
| `body_file` | cadena | - | Ruta al archivo de plantilla (relativa a `.github/`) |
| `labels` | cadena[] | `[]` | Etiquetas adicionales para este flujo de trabajo |
| `assignees_from_policy` | bool | `false` | Asignar automáticamente usuarios individuales de las políticas (máx 10) |

### Opciones de `workflows.<name>.on_approved`

| Clave | Tipo | Por defecto | Descripción |
|-------|------|-------------|-------------|
| `create_tag` | bool | `false` | Crear una etiqueta git (usa la versión de entrada) |
| `close_issue` | bool | `false` | Cerrar la incidencia tras la aprobación |
| `comment` | cadena | - | Comentario a publicar (soporta `{{version}}`, `{{satisfied_group}}`) |
| `tagging` | objeto | - | Configuración avanzada de etiquetado |

### Opciones de `workflows.<name>.on_approved.tagging`

| Clave | Tipo | Por defecto | Descripción |
|-------|------|-------------|-------------|
| `enabled` | bool | `false` | Habilitar la creación de etiquetas |
| `start_version` | string | `"0.0.0"` | Versión inicial (por ejemplo, `"v1.0.0"` o `"1.0.0"`) |
| `prefix` | string | (inferido) | Prefijo de versión (inferido de `start_version`) |
| `auto_increment` | string | - | Auto-incremento: `"major"`, `"minor"`, `"patch"` o omitir para manual |
| `env_prefix` | string | - | Prefijo de entorno (por ejemplo, `"dev-"` crea `"dev-v1.0.0"`) |

### Opciones de `workflows.<name>.on_denied`

| Clave | Tipo | Predeterminado | Descripción |
|-------|------|----------------|-------------|
| `close_issue` | bool | `false` | Cerrar el issue tras la denegación |
| `comment` | string | - | Comentario a publicar (soporta `{{denier}}`) |

### Opciones de `workflows.<name>.on_closed`

| Clave | Tipo | Predeterminado | Descripción |
|-------|------|----------------|-------------|
| `delete_tag` | bool | `false` | Eliminar la etiqueta asociada cuando se cierra el issue |
| `comment` | string | - | Comentario a publicar (soporta `{{tag}}`, `{{version}}`) |

### Opciones de `workflows.<name>.pipeline`

| Clave | Tipo | Predeterminado | Descripción |
|-------|------|----------------|-------------|
| `stages` | stage[] | - | **Requerido:** Lista ordenada de etapas de despliegue |
| `track_prs` | bool | `false` | Incluir PRs fusionados en el cuerpo del issue |
| `track_commits` | bool | `false` | Incluir commits en el cuerpo del issue |
| `compare_from_tag` | string | - | Patrón de etiqueta para comparar (por ejemplo, `"v*"`) |
| `show_mermaid_diagram` | bool | `true` | Mostrar diagrama visual Mermaid de las etapas del pipeline |
| `release_strategy` | object | - | Estrategia de selección del candidato para la versión |

### Opciones de `workflows.<name>.pipeline.stages[]`

| Clave | Tipo | Predeterminado | Descripción |
|-------|------|----------------|-------------|
| `name` | string | - | **Requerido:** Nombre de la etapa (por ejemplo, `"dev"`, `"prod"`) |
| `environment` | string | - | Nombre del entorno en GitHub |
| `policy` | string | - | Política de aprobación para esta etapa |
| `approvers` | string[] | - | Aprobadores en línea (alternativa a la política) |
| `on_approved` | string | - | Comentario a publicar cuando la etapa es aprobada |
| `create_tag` | bool | `false` | Crear una etiqueta git en esta etapa |
| `is_final` | bool | `false` | Cerrar el issue después de esta etapa |
| `auto_approve` | bool | `false` | Aprobar automáticamente sin intervención humana |

### Opciones de `workflows.<name>.pipeline.release_strategy`

| Clave | Tipo | Predeterminado | Descripción |
|-------|------|---------------|-------------|
| `type` | string | `"tag"` | Estrategia: `"tag"`, `"branch"`, `"label"`, `"milestone"` |
| `branch` | object | - | Configuraciones de la estrategia de rama |
| `label` | object | - | Configuraciones de la estrategia de etiqueta |
| `milestone` | object | - | Configuraciones de la estrategia de hito |
| `auto_create` | object | - | Auto-crear el siguiente artefacto de lanzamiento |

### Opciones de `release_strategy.branch`

| Clave | Tipo | Predeterminado | Descripción |
|-------|------|---------------|-------------|
| `pattern` | string | `"release/{{version}}"` | Patrón de nombramiento de rama |
| `base_branch` | string | `"main"` | Rama contra la cual comparar |
| `delete_after_release` | bool | `false` | Eliminar rama después del despliegue en producción |

### Opciones de `release_strategy.label`

| Clave | Tipo | Predeterminado | Descripción |
|-------|------|---------------|-------------|
| `pattern` | string | `"release:{{version}}"` | Patrón de nombramiento de etiqueta |
| `pending_label` | string | - | Etiqueta para PRs pendientes de asignación de lanzamiento |
| `remove_after_release` | bool | `false` | Eliminar etiquetas después del despliegue en producción |

### Opciones de `release_strategy.milestone`

| Clave | Tipo | Predeterminado | Descripción |
|-------|------|---------------|-------------|
| `pattern` | string | `"v{{version}}"` | Patrón de nombramiento de hito |
| `close_after_release` | bool | `false` | Cerrar hito después del despliegue en producción |

### Opciones de `release_strategy.auto_create`

| Clave | Tipo | Predeterminado | Descripción |
|-----|------|---------|-------------|
| `enabled` | bool | `false` | Habilitar la auto-creación al completar la etapa final |
| `next_version` | string | `"patch"` | Incremento de versión: `"patch"`, `"minor"`, `"major"` |
| `create_issue` | bool | `false` | Crear un nuevo issue de aprobación para la siguiente versión |
| `comment` | string | - | Comentario para publicar sobre la próxima versión |

### Opciones de `semver`

| Clave | Tipo | Predeterminado | Descripción |
|-----|------|---------|-------------|
| `prefix` | string | `"v"` | Prefijo de la etiqueta |
| `strategy` | string | `"input"` | Estrategia de versión: `"input"`, `"auto"` |
| `validate` | bool | `false` | Validar formato semver |
| `allow_prerelease` | bool | `false` | Permitir versiones prerelease (ej., `v1.0.0-beta.1`) |
| `auto` | objeto | - | Configuraciones de auto-incremento basadas en etiquetas |

### Opciones de `semver.auto`

| Clave | Tipo | Predeterminado | Descripción |
|-----|------|---------|-------------|
| `major_labels` | string[] | `[]` | Etiquetas de PR que activan incremento mayor |
| `minor_labels` | string[] | `[]` | Etiquetas de PR que activan incremento menor |
| `patch_labels` | string[] | `[]` | Etiquetas de PR que activan incremento de parche |

---

## Detalles de la Funcionalidad

### Palabras Clave de Aprobación

Los usuarios pueden aprobar o denegar solicitudes comentando en el issue:

**Palabras clave de aprobación:** `approve`, `approved`, `lgtm`, `yes`, `/approve`

**Palabras clave de negación:** `deny`, `denied`, `reject`, `rejected`, `no`, `/deny`

### Soporte de Equipos

Para usar aprobadores basados en equipos de GitHub, se necesitan permisos elevados. El `GITHUB_TOKEN` estándar no puede listar miembros del equipo. Use un token de GitHub App:

```yaml
jobs:
  process:
    runs-on: ubuntu-latest
    steps:
      - uses: actions/checkout@v4

      # Generate GitHub App token
      - uses: actions/create-github-app-token@v2
        id: app-token
        with:
          app-id: ${{ vars.APP_ID }}
          private-key: ${{ secrets.APP_PRIVATE_KEY }}

      # Use the app token for team membership checks
      - uses: jamengual/enterprise-approval-engine@v1
        with:
          action: process-comment
          issue_number: ${{ github.event.issue.number }}
          token: ${{ steps.app-token.outputs.token }}
```

**Permisos requeridos para la aplicación de GitHub:**

- `Organización > Miembros: Lectura` - Para listar miembros del equipo

### Canalizaciones de Despliegue Progresivo

Realice un seguimiento de los despliegues a través de múltiples entornos con un único issue de aprobación. A medida que se aprueba cada etapa, el issue se actualiza para mostrar el progreso y avanza automáticamente a la siguiente etapa.

#### Configuración de la canalización

```yaml
# .github/approvals.yml or external config
version: 1

policies:
  developers:
    approvers: [dev1, dev2, dev3]
    min_approvals: 1

  qa-team:
    approvers: [qa1, qa2]
    min_approvals: 1

  tech-leads:
    approvers: [lead1, lead2]
    min_approvals: 1

  production-approvers:
    approvers: [sre1, sre2, security-lead]
    require_all: true

workflows:
  deploy:
    description: "Deploy through all environments (dev → qa → stage → prod)"
    require:
      - policy: developers  # Initial approval to start pipeline
    pipeline:
      track_prs: true       # Include PRs in the issue body
      track_commits: true   # Include commits in the issue body
      stages:
        - name: dev
          environment: development
          policy: developers
          on_approved: "✅ **DEV** deployment approved! Proceeding to QA..."
        - name: qa
          environment: qa
          policy: qa-team
          on_approved: "✅ **QA** deployment approved! Proceeding to STAGING..."
        - name: stage
          environment: staging
          policy: tech-leads
          on_approved: "✅ **STAGING** deployment approved! Ready for PRODUCTION..."
        - name: prod
          environment: production
          policy: production-approvers
          on_approved: "🚀 **PRODUCTION** deployment complete!"
          create_tag: true   # Create tag when PROD is approved
          is_final: true     # Close issue after this stage
    on_approved:
      close_issue: true
      comment: |
        🎉 **Deployment Complete!**

        Version `{{version}}` has been deployed to all environments.
```
#### Ejemplo de flujo de trabajo de la tubería


```yaml
# .github/workflows/request-pipeline.yml
name: Request Pipeline Deployment

on:
  workflow_dispatch:
    inputs:
      version:
        description: 'Version to deploy'
        required: true
        type: string

permissions:
  contents: write
  issues: write
  pull-requests: read  # Required for PR tracking

jobs:
  request:
    runs-on: ubuntu-latest
    steps:
      - uses: actions/checkout@v4
        with:
          fetch-depth: 0  # Needed for commit/PR comparison

      - uses: jamengual/enterprise-approval-engine@v1
        id: approval
        with:
          action: request
          workflow: deploy
          version: ${{ inputs.version }}
          token: ${{ secrets.GITHUB_TOKEN }}

      - name: Output Results
        run: |
          echo "## Pipeline Deployment Started" >> $GITHUB_STEP_SUMMARY
          echo "- **Issue:** #${{ steps.approval.outputs.issue_number }}" >> $GITHUB_STEP_SUMMARY
          echo "- **URL:** ${{ steps.approval.outputs.issue_url }}" >> $GITHUB_STEP_SUMMARY
```

#### Cómo Funciona

1. **Creación de Incidencias**: Cuando se activa, crea una única incidencia que muestra todas las etapas con un diagrama visual Mermaid y una tabla de progreso:

## 🚀 Canalización de Despliegue: v1.2.0

### Flujo de la Canalización

​```mermaid

flowchart LR
    DEV(⏳ DEV)
    QA(⬜ QA)
    STAGE(⬜ STAGE)
    PROD(⬜ PROD)
    DEV --> QA --> STAGE --> PROD

    classDef completed fill:#28a745,stroke:#1e7e34,color:#fff
    classDef current fill:#ffc107,stroke:#d39e00,color:#000
    classDef pending fill:#6c757d,stroke:#545b62,color:#fff
    class DEV current
    class QA,STAGE,PROD pending
​```

### Deployment Progress

| Stage | Status | Approver | Time |
|-------|--------|----------|------|
| DEV | ⏳ Awaiting | - | - |
| QA | ⬜ Pending | - | - |
| STAGE | ⬜ Pending | - | - |
| PROD | ⬜ Pending | - | - |

**Current Stage:** DEV
```

El diagrama Mermaid proporciona una vista rápida con nodos codificados por colores:  
- 🟢 **Verde** - Etapas completadas  
- 🟡 **Amarillo** - Etapa actual esperando aprobación  
- ⚪ **Gris** - Etapas pendientes  
- 🔵 **Cian** - Etapas de autoaprobación  

Para desactivar el diagrama Mermaid, configure `show_mermaid_diagram: false` en la configuración del pipeline.  

2. **Progresión de Etapas**: Comente `approve` para avanzar a la siguiente etapa. Tanto el diagrama como la tabla se actualizan automáticamente:  

```markdown
| Stage | Status | Approver | Time |
|-------|--------|----------|------|
| DEV | ✅ Deployed | @developer1 | Dec 9 10:30 |
| QA | ✅ Deployed | @qa-lead | Dec 9 14:15 |
| STAGE | ⏳ Awaiting | - | - |
| PROD | ⬜ Pending | - | - |

**Current Stage:** STAGE
```

3. **Seguimiento de PR y Commit**: Los gestores de versiones ven exactamente qué se está desplegando:

```markdown
### Pull Requests in this Release

| PR | Title | Author |
|----|-------|--------|
| [#42](https://...) | Add user authentication | @alice |
| [#45](https://...) | Fix payment processing bug | @bob |

### Commits

- [`abc1234`](https://...) feat: add OAuth2 support
- [`def5678`](https://...) fix: handle null payments
```

4. **Finalización**: Cuando se aprueba la etapa final:
   - Se crea una etiqueta (si `create_tag: true`)
   - Se publica un comentario de finalización
   - El issue se cierra automáticamente

#### Opciones de Etapa del Pipeline

| Opción | Descripción |
|--------|-------------|
| `name` | Nombre de la etapa (mostrado en la tabla) |
| `environment` | Nombre del entorno de GitHub |
| `policy` | Política de aprobación para esta etapa |
| `approvers` | Aprobadores en línea (alternativa a la política) |
| `on_approved` | Mensaje a publicar cuando la etapa sea aprobada |
| `create_tag` | Crear una etiqueta git en esta etapa |
| `is_final` | Cerrar el issue después de esta etapa |
| `auto_approve` | Aprobar automáticamente esta etapa sin intervención humana |
| `approval_mode` | Anular el modo de aprobación del flujo de trabajo para esta etapa |

#### Modos de Aprobación

Elija cómo los aprobadores interactúan con las solicitudes de aprobación:

| Modo | Descripción |
|------|-------------|
| `comments` | (Predeterminado) Los aprobadores comentan `/approve` o `approve` en el issue |
| `sub_issues` | Crea un sub-issue para cada etapa - cerrar para aprobar |
| `hybrid` | Mezcla modos por etapa - use `approval_mode` en cada etapa |

**Ejemplo de Aprobación con Sub-Issue:**

```yaml
workflows:
  deploy:
    approval_mode: sub_issues
    sub_issue_settings:
      title_template: "⏳ Approve: {{stage}} for {{version}}"  # Changes to ✅ when approved
      labels: [approval-stage]
      protection:
        only_assignee_can_close: true   # Prevents unauthorized approvals
        prevent_parent_close: true       # Parent can't close until all approved
    pipeline:
      stages:
        - name: dev
          policy: developers
        - name: prod
          policy: production-approvers
```

Con subproblemas, el problema principal muestra una tabla de subproblemas de aprobación:

```markdown
### 📋 Approval Sub-Issues

| Stage | Sub-Issue | Status | Assignees |
|-------|-----------|--------|----------|
| DEV | #124 | ⏳ Awaiting | @alice, @bob |
| PROD | #125 | ⏳ Awaiting | @sre1, @sre2 |
```

**Modo Híbrido (anulación por etapa):**

```yaml
workflows:
  deploy:
    approval_mode: comments  # Default for this workflow
    pipeline:
      stages:
        - name: dev
          policy: developers
          # Uses comments (workflow default)
        - name: prod
          policy: production-approvers
          approval_mode: sub_issues  # Override for production only
```

#### Experiencia de Usuario Mejorada para Comentarios

La acción incluye una experiencia de usuario mejorada basada en la aprobación mediante comentarios:

- **Reacciones con Emojis**: Reacciones automáticas en comentarios de aprobación
  - 👍 Aprobado
  - 👎 Denegado
  - 👀 Visto (procesando)

- **Sección de Acciones Rápidas**: El cuerpo del issue incluye una tabla de referencia de comandos:

```markdown
### ⚡ Quick Actions

| Action | Command | Description |
|--------|---------|-------------|
| ✅ Approve | `/approve` | Approve the **DEV** stage |
| ❌ Deny | `/deny [reason]` | Deny with optional reason |
| 📊 Status | `/status` | Show current approval status |
```

**Configurar a través de `comment_settings`:**

```yaml
workflows:
  deploy:
    comment_settings:
      react_to_comments: true     # Add emoji reactions (default: true)
      show_quick_actions: true    # Show Quick Actions section (default: true)
```

#### Aprobación automática para entornos inferiores

Use `auto_approve: true` en las etapas del pipeline que deben ser aprobadas automáticamente sin intervención humana. Esto es ideal para entornos inferiores como `dev` o `integration` donde desea acelerar el pipeline manteniendo aún las puertas de aprobación para producción.

**Ejemplo con aprobación automática:**

```yaml
workflows:
  deploy:
    description: "Deploy through environments"
    pipeline:
      stages:
        - name: dev
          environment: development
          auto_approve: true              # Automatically approved
          on_approved: "🤖 DEV auto-deployed"
        - name: integration
          environment: integration
          auto_approve: true              # Automatically approved
          on_approved: "🤖 INTEGRATION auto-deployed"
        - name: staging
          environment: staging
          policy: qa-team                 # Requires manual approval
          on_approved: "✅ STAGING approved"
        - name: production
          environment: production
          policy: production-approvers    # Requires manual approval
          create_tag: true
          is_final: true
```

**Cómo funciona:**

1. Cuando se crea un problema de pipeline, todas las etapas iniciales con `auto_approve: true` se completan automáticamente
2. Cuando una etapa se aprueba manualmente, todas las etapas consecutivas con `auto_approve: true` que siguen también se completan automáticamente
3. Las etapas autoaprobadas se muestran con el indicador 🤖 en la tabla del pipeline
4. El aprobador se registra como `[auto]` en el historial de la etapa

**Casos de uso:**

- **Entornos de desarrollo**: Desplegar inmediatamente sin esperar aprobación
- **Pruebas de integración**: Permitir que el pipeline CI/CD avance automáticamente a través de entornos de prueba
- **Despliegues canary**: Autoaprobar la etapa canary, requerir aprobación para el despliegue completo

#### Opciones de Configuración del Pipeline

| Opción | Predeterminado | Descripción |
|--------|----------------|-------------|
| `track_prs` | `false` | Incluir PRs fusionados en el cuerpo del issue |
| `track_commits` | `false` | Incluir commits desde la última etiqueta |
| `compare_from_tag` | - | Patrón de etiqueta personalizado para comparar desde |
| `show_mermaid_diagram` | `true` | Mostrar diagrama visual Mermaid de las etapas del pipeline |

**Nota:** El seguimiento de PR requiere el permiso `pull-requests: read` en tu flujo de trabajo.

### Estrategias de Candidatos a Lanzamiento

En entornos empresariales, los PRs fusionados a main no siempre son candidatos inmediatos a lanzamiento. El motor de aprobación soporta tres estrategias para seleccionar qué PRs pertenecen a un lanzamiento:

#### Tipos de Estrategia

| Estrategia | Descripción | Caso de Uso |
|------------|-------------|-------------|
| `tag` | PRs entre dos etiquetas git (predeterminado) | Lanzamientos simples, desarrollo basado en trunk |
| `branch` | PRs fusionados a una rama de lanzamiento | GitFlow, ramas de lanzamiento |
| `label` | PRs con una etiqueta de lanzamiento específica | Selección flexible, lanzamientos en lote |
| `milestone` | PRs asignados a un milestone de GitHub | Lanzamientos alineados con la hoja de ruta |

#### Configuración

```yaml
# .github/approvals.yml
workflows:
  deploy:
    description: "Production deployment pipeline"
    pipeline:
      track_prs: true
      track_commits: true

      # Configure release selection strategy
      release_strategy:
        type: milestone  # or: tag, branch, label

        # Milestone strategy settings
        milestone:
          pattern: "v{{version}}"        # e.g., "v1.2.0"
          close_after_release: true       # Close milestone on prod completion

        # Auto-create next release artifact on completion
        auto_create:
          enabled: true
          next_version: patch             # or: minor, major
          create_issue: true              # Create new approval issue

      stages:
        - name: dev
          policy: developers
        - name: prod
          policy: production-approvers
          is_final: true
```

#### Estrategia de Ramas

Utilice ramas de lanzamiento para el desarrollo al estilo GitFlow:

```yaml
release_strategy:
  type: branch
  branch:
    pattern: "release/{{version}}"  # Creates release/v1.2.0
    base_branch: main               # Compare against main
    delete_after_release: true      # Cleanup after prod deploy

  auto_create:
    enabled: true
    next_version: minor
```

**Cómo funciona:**
1. Crear una rama de lanzamiento: `release/v1.2.0`
2. Las PR fusionadas en la rama son candidatos a lanzamiento
3. Solicitar aprobación para esa versión
4. El issue de aprobación muestra todas las PR en la rama de lanzamiento
5. Después de producción, la rama se elimina (opcional) y se crea la siguiente rama

#### Estrategia de etiquetas

Usar etiquetas para una selección flexible de PR:

```yaml
release_strategy:
  type: label
  label:
    pattern: "release:{{version}}"      # e.g., "release:v1.2.0"
    pending_label: "pending-release"    # Applied to merged PRs awaiting release
    remove_after_release: true          # Remove label after prod deploy

  auto_create:
    enabled: true
    next_version: patch
```

**Cómo funciona:**
1. Los PRs fusionados a main reciben la etiqueta `pending-release`
2. El gestor de lanzamientos aplica `release:v1.2.0` a los PRs seleccionados
3. Solicitar aprobación para v1.2.0
4. El issue de aprobación muestra solo PRs con esa etiqueta
5. Después de producción, se eliminan las etiquetas y se crea la etiqueta para el siguiente lanzamiento

#### Estrategia de Hitos

Utilice hitos para lanzamientos alineados con la hoja de ruta:

```yaml
release_strategy:
  type: milestone
  milestone:
    pattern: "Release {{version}}"       # e.g., "Release 1.2.0"
    close_after_release: true            # Close milestone on completion

  auto_create:
    enabled: true
    next_version: minor
    create_issue: true                   # Auto-create next approval issue
```

**Cómo funciona:**
1. Crear un hito: "Versión 1.2.0"
2. Asignar PRs al hito durante el desarrollo
3. Solicitar aprobación para v1.2.0
4. El problema de aprobación muestra todos los PRs en el hito
5. Después de producción, se cierra el hito y se crea el siguiente hito

#### Creación automática al completar

Cuando se aprueba la etapa final (producción), preparar automáticamente la siguiente versión:

```yaml
auto_create:
  enabled: true
  next_version: patch      # Calculate next: patch, minor, or major
  create_issue: true       # Create new approval issue immediately
  comment: |               # Custom message (optional)
    🚀 **Next release prepared:** {{version}}
```
Esto crea:
- **Estrategia de ramas:** Nueva rama de lanzamiento desde main
- **Estrategia de etiquetas:** Nueva etiqueta de lanzamiento
- **Estrategia de hitos:** Nuevo hito

#### Opciones de limpieza

Cada estrategia tiene acciones de limpieza opcionales que se ejecutan cuando se aprueba la etapa final (producción). **Todas las opciones de limpieza tienen como valor predeterminado `false`** - la limpieza es opcional:

| Estrategia | Opción de limpieza | Descripción |
|------------|--------------------|-------------|
| Rama | `delete_after_release` | Eliminar la rama de lanzamiento |
| Etiqueta | `remove_after_release` | Eliminar etiquetas de lanzamiento de los PR |
| Hito | `close_after_release` | Cerrar el hito |


```yaml
release_strategy:
  type: branch
  branch:
    pattern: "release/{{version}}"
    delete_after_release: false   # Keep branch for reference (default)

  type: milestone
  milestone:
    pattern: "v{{version}}"
    close_after_release: true     # Close milestone when done
```

#### Despliegues de Hotfix

Para hotfixes de emergencia que necesiten evitar los flujos de trabajo normales de lanzamiento, crea un flujo de trabajo separado:

```yaml
# .github/approvals.yml
workflows:
  # Standard releases - full pipeline with milestone tracking
  deploy:
    description: "Standard release pipeline (dev → qa → stage → prod)"
    pipeline:
      release_strategy:
        type: milestone
        milestone:
          pattern: "v{{version}}"
          close_after_release: true
        auto_create:
          enabled: true
          next_version: minor
      stages:
        - name: dev
          policy: developers
        - name: qa
          policy: qa-team
        - name: stage
          policy: tech-leads
        - name: prod
          policy: production-approvers
          is_final: true

  # Hotfixes - skip stages, direct to prod
  hotfix:
    description: "Emergency hotfix - direct to production"
    pipeline:
      release_strategy:
        type: tag              # Simple tag-based, no cleanup needed
        # No auto_create - hotfixes are one-off
      stages:
        - name: prod
          policy: production-approvers
          create_tag: true
          is_final: true
    on_approved:
      close_issue: true
      comment: "🚨 Hotfix {{version}} deployed to production"
```

**Corrección rápida de emergencia vs lanzamiento regular:**

```bash
# Regular release - goes through all stages
gh workflow run request-approval.yml -f workflow_name=deploy -f version=v1.3.0

# Hotfix - goes straight to prod
gh workflow run request-approval.yml -f workflow_name=hotfix -f version=v1.2.1
```

**Patrones de corrección rápida:**

| Escenario | Estrategia | Limpieza | Auto-Creación |
|----------|----------|---------|-------------|
| Corrección de emergencia | `tag` | Ninguna | Deshabilitado |
| Lanzamiento de parche | `milestone` | `close_after_release: false` | Deshabilitado |
| Múltiples correcciones rápidas | `branch` | `delete_after_release: false` | Deshabilitado |

#### Beneficios de la estrategia de lanzamiento

| Estrategia | Ventajas | Desventajas |
|----------|------|------|
| **Tag** | Simple, sin flujo de trabajo adicional | Todos los PR fusionados incluidos |
| **Branch** | Alcance claro del lanzamiento, aislamiento | Sobrecarga en gestión de ramas |
| **Label** | Selección flexible, fácil de cambiar | Requiere etiquetado manual |
| **Milestone** | Visibilidad del roadmap, integración de planificación | Requiere disciplina en milestones |

**Recomendación:**

- Usar **tag** para proyectos simples con despliegue continuo
- Usar **branch** para entornos regulados que necesitan aislamiento de lanzamiento
- Usar **label** para lanzamientos agrupados con alcance flexible
- Usar **milestone** para desarrollo guiado por roadmap con planificación clara de lanzamientos

### Integración con Jira

Extrae automáticamente los issues de Jira desde commits y nombres de ramas. La acción soporta dos modos:

#### Modo Solo Enlaces (Sin Autenticación Requerida)

Solo proporciona `jira_base_url` para extraer claves de issues y mostrarlas como enlaces clicables:

```yaml
- uses: jamengual/enterprise-approval-engine@v1
  with:
    action: request
    workflow: production-deploy
    version: v1.2.0
    token: ${{ secrets.GITHUB_TOKEN }}
    jira_base_url: https://yourcompany.atlassian.net  # That's it!
```

Esto extrae claves de incidencias (por ejemplo, `PROJ-123`) de mensajes de commit y nombres de ramas, mostrándolas como enlaces en la incidencia de aprobación:

```markdown
### Jira Issues
- [PROJ-123](https://yourcompany.atlassian.net/browse/PROJ-123)
- [PROJ-456](https://yourcompany.atlassian.net/browse/PROJ-456)
```

#### Modo Completo (Con Acceso a la API)

Agregue credenciales para también obtener detalles de problemas y actualizar Versiones de Corrección:

```yaml
- uses: jamengual/enterprise-approval-engine@v1
  with:
    action: request
    workflow: production-deploy
    version: v1.2.0
    token: ${{ secrets.GITHUB_TOKEN }}
    # Jira configuration
    jira_base_url: https://yourcompany.atlassian.net
    jira_user_email: ${{ secrets.JIRA_EMAIL }}
    jira_api_token: ${{ secrets.JIRA_API_TOKEN }}
    jira_update_fix_version: 'true'
```

Esto muestra información detallada del problema:

```markdown
### Jira Issues in this Release

| Key | Summary | Type | Status |
|-----|---------|------|--------|
| [PROJ-123](https://...) | Fix login bug | Bug | Done |
| [PROJ-456](https://...) | Add dark mode | Feature | In Progress |
```

**Comparación de modos:**

| Modo | Autenticación Requerida | Características |
|------|------------------------|-----------------|
| Solo enlaces | No | Emitir claves como enlaces clicables |
| Completo | Sí | Enlaces + resumen, estado, emojis de tipo, actualizaciones de Versión de Corrección |

**Salidas de Jira:**

```yaml
- name: Use Jira Outputs
  run: |
    echo "Issues: ${{ steps.approval.outputs.jira_issues }}"
    # Output: PROJ-123,PROJ-456

    echo "Details: ${{ steps.approval.outputs.jira_issues_json }}"
    # Output: [{"key":"PROJ-123","summary":"Fix login bug",...}]
```

### Seguimiento de Despliegues

Cree despliegues en GitHub para visibilidad en el panel de despliegues de GitHub. Esto funciona de forma independiente de la clave `environment:` en el YAML del flujo de trabajo.

```yaml
- uses: jamengual/enterprise-approval-engine@v1
  id: approval
  with:
    action: request
    workflow: production-deploy
    version: v1.2.0
    token: ${{ secrets.GITHUB_TOKEN }}
    # Deployment tracking
    create_deployment: 'true'
    deployment_environment: production
    deployment_environment_url: https://myapp.example.com

- name: Update Deployment Status
  if: steps.approval.outputs.status == 'approved'
  run: |
    # Use the deployment_id to update status after actual deployment
    echo "Deployment ID: ${{ steps.approval.outputs.deployment_id }}"
```

**Dónde aparecen los despliegues:**

- Pestaña **Despliegues** del repositorio
- Insignias de estado del entorno en la página del repositorio
- Integración de GitHub para Jira (si está configurada)
- API de GitHub para herramientas CI/CD

**Nota:** Esto crea despliegues a través de la API de Despliegues de GitHub, que es independiente de las Reglas de Protección de Entornos nativas de GitHub. Puedes usar ambos juntos o de forma independiente.

### Repositorio de Configuración Externa

Almacena configuraciones de aprobación en un repositorio compartido para la gestión centralizada de políticas:

```yaml
- uses: jamengual/enterprise-approval-engine@v1
  with:
    action: request
    workflow: production-deploy
    token: ${{ secrets.GITHUB_TOKEN }}
    config_repo: myorg/.github  # Shared config repo
```

**Orden de resolución de configuración:**

1. `{repo-name}_approvals.yml` en el repositorio externo (por ejemplo, `myapp_approvals.yml`)
2. `approvals.yml` en el repositorio externo (predeterminado compartido)
3. `.github/approvals.yml` en el repositorio actual (respaldo local)

**Ejemplo de estructura organizacional:**

```text
myorg/.github/
├── myapp_approvals.yml      # App-specific config
├── backend_approvals.yml    # Backend repos config
└── approvals.yml            # Default for all repos
```

### Aprobaciones Bloqueantes

Para flujos de trabajo que necesitan esperar la aprobación antes de continuar:

```yaml
name: Deploy with Blocking Approval

on:
  workflow_dispatch:
    inputs:
      version:
        required: true
        type: string

jobs:
  request-approval:
    runs-on: ubuntu-latest
    outputs:
      issue_number: ${{ steps.request.outputs.issue_number }}
    steps:
      - uses: actions/checkout@v4
      - uses: jamengual/enterprise-approval-engine@v1
        id: request
        with:
          action: request
          workflow: production-deploy
          version: ${{ inputs.version }}
          token: ${{ secrets.GITHUB_TOKEN }}

  wait-for-approval:
    needs: request-approval
    runs-on: ubuntu-latest
    outputs:
      status: ${{ steps.check.outputs.status }}
      tag: ${{ steps.check.outputs.tag }}
    steps:
      - uses: actions/checkout@v4
      - uses: jamengual/enterprise-approval-engine@v1
        id: check
        with:
          action: check
          issue_number: ${{ needs.request-approval.outputs.issue_number }}
          wait: 'true'           # Poll until approved/denied
          timeout: '4h'          # Max wait time
          token: ${{ secrets.GITHUB_TOKEN }}

  deploy:
    needs: [request-approval, wait-for-approval]
    if: needs.wait-for-approval.outputs.status == 'approved'
    runs-on: ubuntu-latest
    steps:
      - name: Deploy
        run: |
          echo "Deploying ${{ needs.wait-for-approval.outputs.tag }}"
```

**Nota:** Los flujos de trabajo bloqueantes mantienen el corredor activo, lo que consume minutos de GitHub Actions. Para escenarios sensibles al costo, utilice el enfoque basado en eventos (flujo de trabajo `process-comment` separado).

### Eliminación de etiquetas al cerrar un problema

Opcionalmente, elimine etiquetas cuando los problemas de aprobación se cierren manualmente:

```yaml
workflows:
  dev-deploy:
    on_closed:
      delete_tag: true   # Delete tag when issue is closed
      comment: "Cancelled. Tag {{tag}} deleted."

  production-deploy:
    on_closed:
      delete_tag: false  # NEVER delete production tags
```

**Manejar eventos de cierre:**

```yaml
# .github/workflows/handle-close.yml
name: Handle Issue Close

on:
  issues:
    types: [closed]

jobs:
  handle:
    if: contains(github.event.issue.labels.*.name, 'approval-required')
    runs-on: ubuntu-latest
    steps:
      - uses: actions/checkout@v4
      - uses: jamengual/enterprise-approval-engine@v1
        id: close
        with:
          action: close-issue
          issue_number: ${{ github.event.issue.number }}
          issue_action: ${{ github.event.action }}
          token: ${{ secrets.GITHUB_TOKEN }}

      - name: Report
        run: |
          echo "Status: ${{ steps.close.outputs.status }}"
          echo "Deleted tag: ${{ steps.close.outputs.tag_deleted }}"
```

---

## Complete Examples

### Full-Featured Request Workflow

```yaml
name: Request Production Deployment

on:
  workflow_dispatch:
    inputs:
      version:
        description: 'Version to deploy'
        required: true
        type: string
      environment:
        description: 'Target environment'
        required: true
        type: choice
        options: [staging, production]

permissions:
  contents: write
  issues: write
  deployments: write

jobs:
  request:
    runs-on: ubuntu-latest
    outputs:
      issue_number: ${{ steps.approval.outputs.issue_number }}
      issue_url: ${{ steps.approval.outputs.issue_url }}
      deployment_id: ${{ steps.approval.outputs.deployment_id }}
      jira_issues: ${{ steps.approval.outputs.jira_issues }}
    steps:
      - uses: actions/checkout@v4
        with:
          fetch-depth: 0  # Needed for commit comparison

      - uses: jamengual/enterprise-approval-engine@v1
        id: approval
        with:
          action: request
          workflow: ${{ inputs.environment }}-deploy
          version: ${{ inputs.version }}
          token: ${{ secrets.GITHUB_TOKEN }}
          # Jira integration
          jira_base_url: https://mycompany.atlassian.net
          jira_user_email: ${{ secrets.JIRA_EMAIL }}
          jira_api_token: ${{ secrets.JIRA_API_TOKEN }}
          # Deployment tracking
          create_deployment: 'true'
          deployment_environment: ${{ inputs.environment }}
          deployment_environment_url: https://${{ inputs.environment }}.myapp.com

      - name: Summary
        run: |
          echo "## Approval Request Created" >> $GITHUB_STEP_SUMMARY
          echo "" >> $GITHUB_STEP_SUMMARY
          echo "- **Issue:** #${{ steps.approval.outputs.issue_number }}" >> $GITHUB_STEP_SUMMARY
          echo "- **URL:** ${{ steps.approval.outputs.issue_url }}" >> $GITHUB_STEP_SUMMARY
          echo "- **Jira Issues:** ${{ steps.approval.outputs.jira_issues }}" >> $GITHUB_STEP_SUMMARY
          echo "- **Commits:** ${{ steps.approval.outputs.commits_count }}" >> $GITHUB_STEP_SUMMARY
```

### Procesar comentarios con soporte del equipo

```yaml
name: Handle Approval Comments

on:
  issue_comment:
    types: [created]

permissions:
  contents: write
  issues: write

jobs:
  process:
    if: |
      github.event.issue.pull_request == null &&
      contains(github.event.issue.labels.*.name, 'approval-required')
    runs-on: ubuntu-latest
    steps:
      - uses: actions/checkout@v4

      # Generate GitHub App token for team membership checks
      - uses: actions/create-github-app-token@v2
        id: app-token
        with:
          app-id: ${{ vars.APP_ID }}
          private-key: ${{ secrets.APP_PRIVATE_KEY }}

      - uses: jamengual/enterprise-approval-engine@v1
        id: process
        with:
          action: process-comment
          issue_number: ${{ github.event.issue.number }}
          token: ${{ steps.app-token.outputs.token }}
          # Jira integration to update Fix Version on approval
          jira_base_url: https://mycompany.atlassian.net
          jira_user_email: ${{ secrets.JIRA_EMAIL }}
          jira_api_token: ${{ secrets.JIRA_API_TOKEN }}

      - name: Trigger Deployment
        if: steps.process.outputs.status == 'approved'
        uses: actions/github-script@v7
        with:
          script: |
            await github.rest.actions.createWorkflowDispatch({
              owner: context.repo.owner,
              repo: context.repo.repo,
              workflow_id: 'deploy.yml',
              ref: 'main',
              inputs: { version: '${{ steps.process.outputs.tag }}' }
            });
```

### Promoción Multi-Entorno

```yaml
# .github/approvals.yml
version: 1

policies:
  dev-team:
    approvers: [dev1, dev2, dev3]
    min_approvals: 1

  qa-team:
    approvers: [qa1, qa2]
    min_approvals: 1

  prod-team:
    approvers: [team:sre, tech-lead]
    min_approvals: 2

workflows:
  dev-deploy:
    require:
      - policy: dev-team
    on_approved:
      tagging:
        enabled: true
        auto_increment: patch
        env_prefix: "dev-"
      close_issue: true

  staging-deploy:
    require:
      - policy: qa-team
    on_approved:
      tagging:
        enabled: true
        auto_increment: minor
        env_prefix: "staging-"
      close_issue: true

  production-deploy:
    require:
      - policy: prod-team
    on_approved:
      create_tag: true
      close_issue: true
    on_closed:
      delete_tag: false  # Never delete production tags
```

### Uso de Salidas en Trabajos Subsiguientes

```yaml
name: Deploy with Approval

on:
  workflow_dispatch:
    inputs:
      version:
        required: true

jobs:
  approval:
    runs-on: ubuntu-latest
    outputs:
      status: ${{ steps.check.outputs.status }}
      tag: ${{ steps.check.outputs.tag }}
      approvers: ${{ steps.check.outputs.approvers }}
      jira_issues: ${{ steps.request.outputs.jira_issues }}
    steps:
      - uses: actions/checkout@v4

      - uses: jamengual/enterprise-approval-engine@v1
        id: request
        with:
          action: request
          workflow: production-deploy
          version: ${{ inputs.version }}
          token: ${{ secrets.GITHUB_TOKEN }}
          jira_base_url: https://mycompany.atlassian.net

      - uses: jamengual/enterprise-approval-engine@v1
        id: check
        with:
          action: check
          issue_number: ${{ steps.request.outputs.issue_number }}
          wait: 'true'
          timeout: '2h'
          token: ${{ secrets.GITHUB_TOKEN }}

  deploy:
    needs: approval
    if: needs.approval.outputs.status == 'approved'
    runs-on: ubuntu-latest
    environment: production
    steps:
      - name: Deploy
        run: |
          echo "Deploying ${{ needs.approval.outputs.tag }}"
          echo "Approved by: ${{ needs.approval.outputs.approvers }}"
          echo "Jira Issues: ${{ needs.approval.outputs.jira_issues }}"

  notify:
    needs: [approval, deploy]
    if: always()
    runs-on: ubuntu-latest
    steps:
      - name: Notify Slack
        run: |
          if [ "${{ needs.approval.outputs.status }}" == "approved" ]; then
            echo "Deployment of ${{ needs.approval.outputs.tag }} completed!"
          else
            echo "Deployment was ${{ needs.approval.outputs.status }}"
          fi
```

---

## Schema Validation

Validate your configuration using the JSON schema:

```yaml
# .github/approvals.yml
# yaml-language-server: $schema=https://raw.githubusercontent.com/jamengual/enterprise-approval-engine/main/schema.json

version: 1

policies:
  # ... your config
```
O validar en CI:


```yaml
- name: Validate Config
  run: |
    npm install -g ajv-cli
    ajv validate -s schema.json -d .github/approvals.yml
```

---

## Servidor GitHub Enterprise

La acción es totalmente compatible con GitHub Enterprise Server. Detecta automáticamente entornos GHES usando las variables de entorno `GITHUB_SERVER_URL` y `GITHUB_API_URL`.

No se requiere configuración adicional: la acción usará automáticamente los endpoints de API correctos.

**Limitación de tasa:**

La acción incluye reintentos automáticos con retroceso exponencial para errores de límite de tasa. Configuración:

- Retardo inicial: 1 segundo
- Retardo máximo: 60 segundos
- Reintentos máximos: 5
- Jitter: Aleatorio de 0-500 ms añadido para evitar avalanchas

---

## Licencia

Licencia MIT


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-22

---