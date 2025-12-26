# VSCode como servidor MCP

[Marketplace](https://marketplace.visualstudio.com/items?itemName=acomagu.vscode-as-mcp-server)

Una extensión de VSCode que convierte tu VSCode en un servidor MCP, permitiendo asistencia avanzada de codificación desde clientes MCP como Claude Desktop.

## Características clave

### Soporte para edición de código
- Revisa los cambios de código propuestos por un LLM mediante diffs, permitiéndote aceptar, rechazar o proporcionar retroalimentación.
- Mensajes de diagnóstico en tiempo real (p. ej., errores de tipo) enviados instantáneamente al LLM para correcciones inmediatas.

![Diferencia de edición de código](https://storage.googleapis.com/zenn-user-upload/778b7e9ad8c4-20250407.gif)

### Operaciones en terminal
- Ejecuta comandos dentro del terminal integrado de VSCode (soporta ejecución en segundo plano/primer plano y configuración de tiempo de espera).

### Herramientas de vista previa
- Previsualiza URLs directamente dentro del navegador integrado de VSCode (p. ej., abre automáticamente la vista previa del navegador tras iniciar un servidor Vite).

![Herramienta de vista previa](https://storage.googleapis.com/zenn-user-upload/8968c9ad3920-20250407.gif)

### Cambio entre múltiples instancias
- Cambia fácilmente el servidor MCP entre varias ventanas abiertas de VSCode. (Solo haciendo clic en el elemento de la barra de estado)

![Cambio de instancia](https://storage.googleapis.com/zenn-user-upload/0a2bc2bee634-20250407.gif)

### Funcionalidad de retransmisión (experimental)
- Retransmite y expone servidores MCP integrados introducidos en VSCode 1.99 de forma externa.
- Permite el acceso externo a herramientas proporcionadas por otras extensiones MCP, como GitHub Copilot.

## Herramientas integradas disponibles

- **execute_command**: Ejecuta comandos en el terminal integrado de VSCode
- **code_checker**: Recupera diagnósticos actuales de tu código
- **focus_editor**: Enfoca ubicaciones específicas dentro de archivos
- **list_debug_sessions** / **start_debug_session** / **restart_debug_session** / **stop_debug_session**: Gestiona sesiones de depuración
- **text_editor**: Operaciones con archivos (ver, reemplazar, crear, insertar, deshacer)
- **list_directory**: Lista el contenido de directorios en formato árbol
- **get_terminal_output**: Obtiene la salida de un terminal especificado
- **list_vscode_commands** / **execute_vscode_command**: Listar y ejecutar comandos arbitrarios de VSCode  
- **preview_url**: Abrir URLs dentro del navegador integrado de VSCode  

## Instalación y Configuración  

1. Instale la extensión desde el [VSCode Marketplace](https://marketplace.visualstudio.com/items?itemName=acomagu.vscode-as-mcp-server).  

2. Configure su cliente MCP:  

    - **Usando mcp-installer**: Simplemente puede indicarle que "instale el servidor MCP vscode-as-mcp-server".  
    - **Otros clientes como Claude Desktop**: Añada lo siguiente a su archivo de configuración (`claude_desktop_config.json`):

    ```json
    {
      "mcpServers": {
        "vscode": {
          "command": "npx",
          "args": ["vscode-as-mcp-server"]
        }
      }
    }
    ```
3. Compruebe el estado del servidor MCP en la barra de estado inferior derecha de VSCode:

    - (Icono del servidor): El servidor está en funcionamiento
    - ∅: Haga clic para iniciar el servidor

![Indicador de estado del servidor](https://storage.googleapis.com/zenn-user-upload/321704116d4a-20250408.png)

## Motivación

Esta extensión fue desarrollada para mitigar los altos costos asociados con herramientas de codificación medidas (como Roo Code y Cursor). Es una alternativa asequible y autoalojada integrada directamente en VSCode.

¡Los informes de errores y comentarios son muy bienvenidos! 🙇

## Hoja de ruta futura

- Capacidad para seleccionar qué servidores MCP integrados exponer
- Interfaz de aprobación basada en WebView (similar a Roo Code)
- Integración con el historial de archivos de VSCode (Línea de tiempo)
- Conmutación instantánea de aprobaciones automáticas y activación/desactivación de herramientas
- Configuración personalizable del puerto del servidor



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-26

---