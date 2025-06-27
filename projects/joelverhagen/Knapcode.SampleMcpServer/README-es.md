# Servidor MCP

Este README fue creado usando el proyecto de plantilla de servidor MCP de .NET. Demuestra cómo puedes crear fácilmente un servidor MCP usando .NET y luego empaquetarlo en un paquete NuGet.

Consulta [aka.ms/nuget/mcp/guide](https://aka.ms/nuget/mcp/guide) para la guía completa.

## Lista de verificación antes de publicar en NuGet.org

- Actualiza los metadatos del paquete en el archivo .csproj
- Actualiza el archivo `.mcp/server.json` para declarar las entradas de tu servidor MCP
- Prueba el servidor MCP localmente usando los pasos a continuación

## Uso del servidor MCP en VS Code

Una vez que el paquete del servidor MCP se publique en NuGet.org, puedes usar la siguiente configuración de usuario de VS Code para descargar e instalar el paquete del servidor MCP. Consulta [Usar servidores MCP en VS Code (Vista previa)](https://code.visualstudio.com/docs/copilot/chat/mcp-servers) para obtener más información sobre el uso de servidores MCP en VS Code.

```json
{
  "mcp": {
    "servers": {
      "my-custom-mcp": {
        "type": "stdio",
        "command": "dotnet",
        "args": [
          "tool",
          "exec",
          "<your package ID here>",
          "--version",
          "<your package version here>",
          "--yes",
          "--",
          "start-mcp"
        ],
        "env": {
          "MAX_RANDOM_NUMBER": 100
        }
      }
    }
  }
}
```

Ahora puedes pedirle al chat de Copilot un número aleatorio, por ejemplo `Dame 3 números aleatorios`. Debería sugerir el uso de la herramienta `GetRandomNumber` en el servidor MCP `my-custom-mcp` y mostrarte los resultados.

## Desarrollo local

Para probar este servidor MCP desde el código fuente (localmente) sin usar un paquete de servidor MCP compilado, utiliza la siguiente configuración de VS Code:

```json
{
  "mcp": {
    "servers": {
      "my-custom-mcp": {
        "type": "stdio",
        "command": "dotnet",
        "args": [
          "run",
          "--project",
          "<PATH TO PROJECT DIRECTORY>",
          "--",
          "start-mcp"
        ],
        "env": {
          "MAX_RANDOM_NUMBER": 100
        }
      }
    }
  }
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---