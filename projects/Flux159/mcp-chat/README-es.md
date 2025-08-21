# mcp-chat

Cliente MCP Genérico de Código Abierto para probar y evaluar servidores y agentes MCP

<p align="center">
  <img width="600" src="https://raw.githubusercontent.com/Flux159/mcp-chat/refs/heads/main/mcpchat.svg">
</p>

## Inicio rápido

Asegúrate de tener `ANTHROPIC_API_KEY` exportada en tu entorno o en un archivo .env en la raíz del proyecto. Puedes obtener una clave API registrándote en la [página de claves de la Consola de Anthropic](https://console.anthropic.com/settings/keys).

Caso de uso simple que inicia un chat interactivo con el servidor MCP de sistema de archivos desde la CLI:

```shell
npx mcp-chat --server "npx -y @modelcontextprotocol/server-filesystem /Users/$USER/Desktop"
```

Esto abrirá un cuadro de chat que puedes usar para interactuar con los servidores y chatear con un LLM.

## Configuración

También puedes simplemente especificar tu archivo claude_desktop_config.json (Mac):

```shell
npx mcp-chat --config "~/Library/Application Support/Claude/claude_desktop_config.json"
```
O (Windows):


```shell
npx mcp-chat --config "%APPDATA%\Claude\claude_desktop_config.json"
```

## Web mode

https://github.com/user-attachments/assets/b7e8a648-8084-4955-8cdf-fc6eb141572e

You can also run mcp-chat in web mode by specifying the `--web` flag (make sure to have `ANTHROPIC_API_KEY` exported in your environment):

```shell
npx mcp-chat --web
```

En modo web, puedes iniciar nuevos chats, enviar mensajes al modelo y configurar dinámicamente los servidores mcp a través de la interfaz de usuario - no es necesario especificarlo en la línea de comandos. Además, los chats creados mediante la interfaz web se guardan en ~/.mcpchats/chats igual que los chats creados mediante la CLI.

## Características

- [x] Ejecutar vía CLI en modo interactivo o pasar directamente indicaciones con `-p`
- [x] Modo web para chatear con modelos mediante una interfaz web `--web`
- [x] Conectarse a cualquier servidor MCP (JS, Python, Docker) en producción o durante el desarrollo
- [x] Elegir entre modelos con `-m`
- [x] Personalizar la indicación del sistema con `--system`
- [x] Guarda el historial de chat con configuraciones en `~/.mcpchat/chats` incluyendo chats web
- [x] Guardar y restaurar comandos en `~/.mcpchat/history`
- [x] Ver la salida de llamadas a herramientas y argumentos directamente en el chat para ayudar a depurar servidores mcp

## Uso de la CLI

Ejecuta indicaciones vía CLI con la bandera `-p`:

```shell
npx mcp-chat --server "npx mcp-server-kubernetes" -p "List the pods in the default namespace"
```

Esto ejecuta el prompt con el servidor mcp de Kubernetes y sale después de recibir la respuesta en stdout.

Elija un modelo para chatear a través de la CLI con la bandera `-m`:

```shell
npx mcp-chat --server "npx mcp-server-kubernetes" -m "claude-3.5"
```
Utiliza el modelo `claude-3.5` para chatear. Tenga en cuenta que actualmente solo se admiten modelos de Anthropic.

El indicador del sistema personalizado:

La bandera `--system` se puede usar para especificar un indicador del sistema:


```shell
npx mcp-chat --system "Explain the output to the user in pirate speak." --server "npx mcp-server-kubernetes" -p "List the pods in the default namespace"
```

## Variables de entorno

Mcp-chat soporta pasar variables de entorno a los servidores mcp. Sin embargo, esto no está estandarizado en la especificación mcp y otros clientes pueden no hacerlo con valores dinámicos de variables de entorno; lee más [aquí](https://github.com/Flux159/mcp-server-kubernetes/issues/148#issuecomment-2950181666) sobre clientes estándar stdio mcp.

```shell
KUBECONFIG="~/.kube/config" npx mcp-chat --server "npx mcp-server-kubernetes"
```

## Para desarrolladores de mcp-servers

Puedes pasar una compilación local de un mcp-server en python o node para probarlo con mcp-chat:

Node JS:

```shell
# Directly executing built script
npx mcp-chat --server "/path/to/mcp-server-kubernetes/dist/index.js"
# Using node / bun
npx mcp-chat --server "node /path/to/mcp-server-kubernetes/dist/index.js"
```

Python:

```shell
# Python: Using uv
npx mcp-chat --server "uv --directory /path/to/mcp-server-weather/ run weather.py"
# Using python / python3 - make sure to run in venv or install deps globally
npx mcp-chat --server "/path/to/mcp-server-weather/weather.py"
```

## Desarrollo

Instale las dependencias y ejecute la CLI:

```shell
git clone https://github.com/Flux159/mcp-chat
bun install
bun run dev
```
Para desarrollar mcp-chat mientras se conecta a un mcp-server, crea una compilación y ejecuta la CLI con la bandera del servidor:


```shell
npm run build && node dist/index.js --server "npx mcp-server-kubernetes" -p "List the pods in the default namespace"
```
Pruebas:


```shell
bun run test
```
Edificio:


```shell
bun run build
```

Publicación:

```shell
bun run publish
```

Publicando Docker:

```shell
bun run dockerbuild
```

### Estructura del Proyecto

```
├── src/
│   ├── index.ts            # Main client implementation & CLI params
│   ├── constants.ts        # Default constants
│   ├── interactive.ts      # Interactive chat prompt handling & logic
├── test/                   # Test files
│   ├── cli.test.ts         # Test CLI params
│   ├── config.test.ts      # Test config file parsing
```

## Publicación de una nueva versión

Ve a la página de [releases](https://github.com/Flux159/mcp-chat/releases), haz clic en "Draft New Release", selecciona "Choose a tag" y crea una nueva etiqueta escribiendo un nuevo número de versión usando el formato semver "v{major}.{minor}.{patch}". Luego, escribe un título para la versión "Release v{major}.{minor}.{patch}" y una descripción / registro de cambios si es necesario y haz clic en "Publish Release".

Esto creará una nueva etiqueta que activará una nueva compilación de lanzamiento vía el flujo de trabajo cd.yml. Una vez exitoso, la nueva versión será publicada en npm. Nota que no es necesario actualizar manualmente la versión en package.json, ya que el flujo de trabajo actualizará automáticamente el número de versión en el archivo package.json y enviará un commit a main.

## Licencia

[Licencia MIT](https://github.com/Flux159/mcp-chat/blob/main/LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-21

---