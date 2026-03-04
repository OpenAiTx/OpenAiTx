# 🎭 Plugin de Orquestación para Claude Code

> _Como N8N en Claude Code_

### Si te gusta el proyecto, ¡considera darle ⭐!<br/>

## **Orquestación de flujos de trabajo multiagente.** Encadena agentes de IA para automatizar tareas complejas usando lenguaje natural o sintaxis declarativa.

[![Claude Code](https://img.shields.io/badge/Claude%20Code-Compatible-blue)](https://claude.com/claude-code)
[![License](https://img.shields.io/badge/License-MIT-green.svg)](LICENSE)

---

## Instalación

### 1. Añadir el Marketplace de Plugins

Primero, añade el marketplace de orquestación a tu Claude Code:

```bash
/plugin marketplace add mbruhler/claude-orchestration
```

### 2. Instalar el Plugin

```bash
/plugin install orchestration@mbruhler
```
O use el menú interactivo:


```bash
/plugin
```

Luego seleccione **"Buscar Plugins"** → busque **orquestación** → **Instalar**

### 3. Verificar la Instalación

Verifique que el plugin esté instalado:

```bash
/help
```

Deberías ver comandos de orquestación como `/orchestration:menu`, `/orchestration:init`, etc.

---

## Inicio Rápido

### 0. Importa Tus Agentes Personalizados (Opcional)
```
/orchestration:init
```

Importa tus agentes personalizados desde `~/.claude/agents/` en el complemento de orquestación.

**Ejemplo:**
```
/orchestration:init
→ Select agents to import
→ Agents become available as expert-code-implementer, etc. and the plugin can create workflows using them
```

### 1. Lenguaje Natural
```
"Create a workflow that fetches 10 Reddit posts about startups,
analyzes competition, and shows a ratings table"
```

El complemento:
- ✅ Crea los scripts temporales necesarios (Python/Node.js)
- ✅ Te guía a través de preguntas clicables
- ✅ Genera y ejecuta un flujo de trabajo optimizado
- ✅ Devuelve resultados formateados

### 2. Sintaxis Directa
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

### 3. Plantillas
```
"Use the TDD implementation template"
```

---

## Características principales

### Control de flujo
```flow
# Sequential
step1 -> step2 -> step3

# Parallel
[task1 || task2 || task3]

# Conditional
test -> (if passed)~> deploy
     -> (if failed)~> rollback
```

### Scripts de Temperatura Automática
Crea automáticamente scripts en Python/Node.js para:
- 🌐 Web scraping (BeautifulSoup, Selenium)
- 📡 APIs (Reddit, Twitter, GitHub)
- 📊 Procesamiento de datos (pandas, NumPy)
- 🗄️ Consultas a bases de datos

### Puntos de Control Manuales
```flow
build:"Compile app" ->
@review:"Check output. Continue?" ->
deploy:"Deploy to production"
```

### Progreso Visual
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

## Referencia de Sintaxis

| Sintaxis | Significado | Ejemplo |
|--------|---------|---------|
| `->` | Secuencial | `paso1 -> paso2` |
| `||` | Paralelo | `[paso1 \|\| paso2]` |
| `~>` | Condicional | `(si aprobado)~> siguiente` |
| `@label` | Punto de control | `@revisar-codigo` |
| `:var` | Capturar salida | `analizar:"tarea":resultado` |
| `{var}` | Usar variable | `"Procesar {resultado}"` |
| `$agent` | Agente temporal | `$escaner:"Escanear"` |

---

## Agentes Incorporados

- **Explorar** - Exploración y búsqueda rápida de la base de código
- **Planificar** - Planificación y descomposición de tareas
- **propósito-general** - Agente versátil para tareas complejas de múltiples pasos

---

## Ejemplos

### Analizador de Startups en Reddit
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

### Implementación de TDD
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
### Investigación de errores

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

## Avanzado

### Ejecución independiente
```bash
# Headless (no checkpoints)
claude -p "Execute @examples/tdd-implementation.flow"

# With parameters
claude -p "/orchestration:run $(cat workflow.flow)" \
  --output-format json
```

### Promoción de Agente
```
Workflow complete!

Temp agents: security-scanner, api-wrapper

Save as permanent?
[Save all] [Save security-scanner] [Delete all]
```

### Parámetros de la plantilla
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

## Solución de Problemas

**El flujo de trabajo se detiene**
→ El punto de control requiere respuesta del usuario o eliminar para modo sin cabeza

**El script temporal falla**
→ Revisar `temp-scripts/` para archivo generado
→ Verificar credenciales de API y dependencias

**Agente no encontrado**
→ Incorporado: nombres exactos (Explore, propósito general)
→ Plugin: usar prefijo `orchestration:`
→ Temporal: usar prefijo `$`

## Historial de Estrellas

[![Gráfico de Historial de Estrellas](https://api.star-history.com/svg?repos=mbruhler/claude-orchestration&type=date&legend=top-left)](https://www.star-history.com/#mbruhler/claude-orchestration&type=date&legend=top-left)

---

## Soporte

- 📖 [Documentación](docs/)
- 💬 [Discusiones](https://github.com/anthropics/orchestration/discussions)
- 🐛 [Incidencias](https://github.com/anthropics/orchestration/issues)

---

**Licencia MIT** | Creado para la comunidad Claude Code


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-04

---