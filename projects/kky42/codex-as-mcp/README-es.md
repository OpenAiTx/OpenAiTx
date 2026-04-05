# codex-as-mcp

[中文版](https://raw.githubusercontent.com/kky42/codex-as-mcp/main/./README.zh-CN.md)

`codex-as-mcp` es un pequeño servidor de **Model Context Protocol (MCP)** que permite a los clientes MCP (Claude Code, Cursor, etc.) delegar trabajo al **Codex CLI**.

Expone dos herramientas que ejecutan Codex en el directorio de trabajo actual del servidor:
- `spawn_agent(prompt: str)`
- `spawn_agents_parallel(agents: list[dict])`

En el fondo, cada agente ejecuta algo como:
`codex exec --cd <server cwd> --skip-git-repo-check --dangerously-bypass-approvals-and-sandbox "<prompt>"`.

Nota: `--dangerously-bypass-approvals-and-sandbox` desactiva la sandbox y las solicitudes de confirmación. Usa este servidor solo en repositorios que confíes.

## Úsalo en Claude Code

Hay dos herramientas en codex-as-mcp
![tools](https://raw.githubusercontent.com/kky42/codex-as-mcp/main/assets/tools.png)

Puedes iniciar subagentes codex en paralelo usando prompt.
![alt text](https://raw.githubusercontent.com/kky42/codex-as-mcp/main/assets/claude.png)

Aquí hay una sesión de Codex de ejemplo delegando dos tareas en paralelo.
![Codex use case](https://raw.githubusercontent.com/kky42/codex-as-mcp/main/assets/codex.png)

## Inicio rápido

### 1. Instala Codex CLI

**Requiere Codex CLI >= 0.46.0**

```bash
npm install -g @openai/codex@latest
codex login

# Verify installation
codex --version
```

Asegúrate de que Codex CLI pueda ejecutarse de forma no interactiva en tu máquina (proveedor + credenciales en `~/.codex/config.toml`, o mediante la variable de entorno específica del proveedor a la que hace referencia).

#### Ejemplo: proveedor externo + `env_key`

Si estás usando un proveedor externo, configúralo en el `config.toml` de Codex y apunta `model_provider` hacia él. Cuando un proveedor usa `env_key`, Codex CLI espera que esa variable de entorno esté presente cuando se ejecute.

Ejemplo:
```toml
model_provider = "custom_provider"

[model_providers.custom_provider]
name = "custom_provider"
base_url = "https://..."
wire_api = "responses"
env_key = "PROVIDER_API_KEY"
show_raw_agent_reasoning = true
```

Al usar `codex-as-mcp`, asegúrese de que el proceso del servidor MCP tenga esa variable de entorno configurada, para que pueda pasarla al proceso `codex` generado. El nombre de la variable de entorno **debe coincidir** con el valor `env_key` mencionado arriba (aquí: `PROVIDER_API_KEY`).

**Opción A (recomendada): configure la variable de entorno en la configuración de su cliente MCP (si es compatible)**
```json
{
  "mcpServers": {
    "codex-subagent": {
      "type": "stdio",
      "command": "uvx",
      "args": ["codex-as-mcp@latest"],
      "env": {
        "PROVIDER_API_KEY": "KEY_VALUE"
      }
    }
  }
}
```

**Opción B: pasar el entorno a través de argumentos del servidor**
```bash
uvx codex-as-mcp@latest --env PROVIDER_API_KEY=KEY_VALUE
```

**Opción C: agregar a través de Codex CLI (`codex mcp add`)**
```bash
codex mcp add codex-subagent --env PROVIDER_API_KEY=KEY_VALUE -- uvx codex-as-mcp@latest
```

Nota de seguridad: pasar secretos mediante argumentos de línea de comandos puede ser visible a través de listas de procesos en su máquina; prefiera la opción A cuando sea posible.

### 2. Configurar MCP

Agregue a su `.mcp.json`:
```json
{
  "mcpServers": {
    "codex-subagent": {
      "type": "stdio",
      "command": "uvx",
      "args": ["codex-as-mcp@latest"]
    }
  }
}
```

O use los comandos de Claude Desktop:
```bash
claude mcp add codex-subagent -- uvx codex-as-mcp@latest
```
Si está configurando Codex CLI directamente (por ejemplo `~/.config/codex/config.toml`), agregue:

```toml
[mcp_servers.subagents]
transport = "stdio"
command = "uvx"
args = ["codex-as-mcp@latest"]
# Increase if you see ~60s tool-call timeouts when running longer Codex tasks.
# tool_timeout_sec = 600
```

## Herramientas

- `spawn_agent(prompt: str)` – Genera un subagente autónomo de Codex usando el directorio de trabajo del servidor y devuelve el mensaje final del agente.
- `spawn_agents_parallel(agents: list[dict])` – Genera múltiples subagentes de Codex en paralelo; cada elemento debe incluir una clave `prompt` y los resultados incluyen un `output` o un `error` por agente.

## Solución de problemas

### `spawn_agent` se agota después de ~60s

Si ves un error como:
```text
tool call failed for `subagents/spawn_agent`
timed out awaiting tools/call after 60s
deadline has elapsed
```

Esto suele ser un tiempo de espera de llamada a herramienta del MCP del lado del cliente. `spawn_agent` no retorna hasta que el proceso `codex exec` lanzado termina, lo cual puede tomar más de 60 segundos.

Solución: aumente el tiempo de espera de llamada a herramienta en su cliente MCP.

#### Codex CLI

En su configuración de Codex (`~/.codex/config.toml` o `~/.config/codex/config.toml`), establezca un `tool_timeout_sec` más alto para el servidor MCP:
```toml
[mcp_servers.subagents]
transport = "stdio"
command = "uvx"
args = ["codex-as-mcp@latest"]
tool_timeout_sec = 600
```

#### Inspector MCP / `mcp dev`

Si estás probando localmente con el Inspector MCP, aumenta los tiempos de espera de las solicitudes (o ejecuta `./test.sh`, que exporta estos):
```bash
export MCP_SERVER_REQUEST_TIMEOUT=300000
export MCP_REQUEST_TIMEOUT_RESET_ON_PROGRESS=true
export MCP_REQUEST_MAX_TOTAL_TIMEOUT=28800000
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-05

---