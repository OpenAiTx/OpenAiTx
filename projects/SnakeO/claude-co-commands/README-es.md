# Plugin de Co-Comandos Claude

3 comandos de colaboración para Claude Code que utilizan el [servidor Codex MCP](https://github.com/openai/codex) para generar planes paralelos, validar planes y generar ideas.

## Comandos

| Comando | Descripción | Cuándo usar |
|---------|-------------|-------------|
| `/co-brainstorm` | Intercambia ideas con Codex | Quieres ideas rápidas alternativas, críticas y perspectivas |
| `/co-plan` | Genera un plan paralelo vía Codex | Quieres una segunda opinión sobre tu enfoque de planificación |
| `/co-validate` | Obtén una revisión de ingeniero senior de tu plan | Quieres retroalimentación crítica antes de finalizar un plan |

## Requisitos previos

- [Node.js](https://nodejs.org/) (para `npx`)
- [Claude Code](https://docs.anthropic.com/en/docs/claude-code)

## Instalación

### Opción 1: Mercado de Plugins (Recomendado)

```bash
# Add the marketplace
/plugin marketplace add SnakeO/claude-co-commands

# Install the plugin
/plugin install co-commands@snakeo-co-commands
```

### Opción 2: Clonar con Git

```bash
git clone https://github.com/SnakeO/claude-co-commands.git
# Copy skill folders to ~/.claude/skills/
cp -r claude-co-commands/plugins/co-commands/skills/* ~/.claude/skills/
```

### Opción 3: Copia Manual

Copie el contenido de `plugins/co-commands/skills/` a `~/.claude/skills/`.

## Configuración del Servidor MCP (Requerido)

Estos comandos requieren el servidor Codex MCP.

### Opción A: CLI (Recomendado)

```bash
claude mcp add validate-plans-and-brainstorm-ideas -- npx -y @openai/codex mcp-server
```

### Opción B: Manual

Agrega esto al objeto `mcpServers` en `~/.claude.json`:

```json
"validate-plans-and-brainstorm-ideas": {
  "command": "npx",
  "args": ["-y", "@openai/codex", "mcp-server"]
}
```
Si ya tienes entradas en `mcpServers`, combina esta como una clave adicional. No sobrescribas los servidores existentes.

### Verificar

1. Reinicia Claude Code (si editaste `~/.claude.json` manualmente).
2. Ejecuta `claude mcp list` para confirmar que el servidor está registrado.
3. Prueba con `/co-brainstorm test idea` y confirma que se activa la llamada MCP.

## Detalles del Comando

### `/co-brainstorm`

Inicia una sesión interactiva de lluvia de ideas con Codex. Pasa tu tema o pregunta como argumento.


```
/co-brainstorm how should we structure the authentication system
```

Supports follow-up conversation to dig deeper into ideas.

### `/co-plan`

Generates an alternative plan in the background while you continue your own planning. Pass your task description as the argument.

```
/co-plan add user authentication with OAuth2 support
```

Compare el plan de Codex con el suyo para detectar enfoques omitidos, alternativas más simples o casos límite pasados por alto.

### `/co-validate`

Envía su plan a Codex para una revisión al estilo de un ingeniero senior. Pase la ruta a su archivo de plan.

```
/co-validate .claude/plans/my-plan.md
```
Devuelve problemas críticos, oportunidades de simplificación y enfoques alternativos. Soporta discusiones de ida y vuelta.

## Solución de problemas

| Problema | Solución |
|---------|----------|
| `npx: command not found` | Instale [Node.js](https://nodejs.org/) que incluye npm/npx |
| Herramienta MCP no encontrada en la sesión | Verifique que el nombre del servidor sea exactamente `validate-plans-and-brainstorm-ideas` en `~/.claude.json` |
| Errores de análisis JSON en `~/.claude.json` | Valide su JSON (revise comas y llaves) |
| Comandos que no aparecen después de la instalación | Reinicie Claude Code y verifique que existan las carpetas de habilidades |

## Licencia

MIT



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-03

---