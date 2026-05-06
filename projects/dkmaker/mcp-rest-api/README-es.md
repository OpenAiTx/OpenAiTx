# MCP REST API Tester
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![NPM Package](https://img.shields.io/npm/v/dkmaker-mcp-rest-api.svg)](https://www.npmjs.com/package/dkmaker-mcp-rest-api)

Un servidor MCP basado en TypeScript que permite probar APIs REST a través de Claude, Cline y otros clientes MCP. Esta herramienta te permite probar e interactuar con cualquier endpoint de API REST directamente desde tu entorno de desarrollo.

<a href="https://glama.ai/mcp/servers/izr2sp4rqo">
  <img width="380" height="200" src="https://glama.ai/mcp/servers/izr2sp4rqo/badge?refresh=1234" />
</a>

## Instalación

Instala el paquete globalmente:
```bash
npm install -g dkmaker-mcp-rest-api
```

## Configuración

### Instrucciones Personalizadas para Cline

Para asegurar que Cline entienda cómo usar esta herramienta de manera efectiva, agregue lo siguiente a sus instrucciones personalizadas de Cline (Configuración > Instrucciones Personalizadas):

```markdown
# REST API Testing Instructions

The `test_request` tool enables testing, debugging, and interacting with REST API endpoints. The tool provides comprehensive request/response information and handles authentication automatically.

## When to Use

- Testing specific API endpoints
- Debugging API responses
- Verifying API functionality
- Checking response times
- Validating request/response formats
- Testing local development servers
- Testing API sequences
- Verifying error handling

## Key Features

- Supports GET, POST, PUT, DELETE, PATCH methods
- Handles authentication (Basic, Bearer, API Key)
- Normalizes endpoints automatically
- Provides detailed response information
- Configurable SSL verification and response limits

## Resources

The following resources provide detailed documentation:

- examples: Usage examples and common patterns
- response-format: Response structure and fields
- config: Configuration options and setup guide

Access these resources to understand usage, response formats, and configuration options.

## Important Notes

- Review API implementation for expected behavior
- Handle sensitive data appropriately
- Consider rate limits and API constraints
- Restart server after configuration changes
```

### Configuración del Servidor MCP

Aunque estas instrucciones son para Cline, el servidor debería funcionar con cualquier implementación MCP. Configure según su sistema operativo:

### Windows
⚠️ **IMPORTANTE**: Debido a un problema conocido con la resolución de rutas en Windows ([issue #40](https://github.com/modelcontextprotocol/servers/issues/40)), debe usar la ruta completa en lugar de %APPDATA%.

Agregue a `C:\Users\<SuNombreDeUsuario>\AppData\Roaming\Code\User\globalStorage\saoudrizwan.claude-dev\settings\cline_mcp_settings.json`:
```json
{
  "mcpServers": {
    "rest-api": {
      "command": "node",
      "args": [
        "C:/Users/<YourUsername>/AppData/Roaming/npm/node_modules/dkmaker-mcp-rest-api/build/index.js"
      ],
      "env": {
        "REST_BASE_URL": "https://api.example.com",
        // Basic Auth
        "AUTH_BASIC_USERNAME": "your-username",
        "AUTH_BASIC_PASSWORD": "your-password",
        // OR Bearer Token
        "AUTH_BEARER": "your-token",
        // OR API Key
        "AUTH_APIKEY_HEADER_NAME": "X-API-Key",
        "AUTH_APIKEY_VALUE": "your-api-key",
        // SSL Verification (enabled by default)
        "REST_ENABLE_SSL_VERIFY": "false", // Set to false to disable SSL verification for self-signed certificates
        // Response Size Limit (optional, defaults to 10000 bytes)
        "REST_RESPONSE_SIZE_LIMIT": "10000", // Maximum response size in bytes
        // Custom Headers (optional)
        "HEADER_X-API-Version": "2.0",
        "HEADER_Custom-Client": "my-client",
        "HEADER_Accept": "application/json"
      }
    }
  }
}
```

### macOS
Agregar a `~/Library/Application Support/Code/User/globalStorage/saoudrizwan.claude-dev/settings/cline_mcp_settings.json`:
```json
{
  "mcpServers": {
    "rest-api": {
      "command": "npx",
      "args": [
        "-y",
        "dkmaker-mcp-rest-api"
      ],
      "env": {
        "REST_BASE_URL": "https://api.example.com",
        // Basic Auth
        "AUTH_BASIC_USERNAME": "your-username",
        "AUTH_BASIC_PASSWORD": "your-password",
        // OR Bearer Token
        "AUTH_BEARER": "your-token",
        // OR API Key
        "AUTH_APIKEY_HEADER_NAME": "X-API-Key",
        "AUTH_APIKEY_VALUE": "your-api-key",
        // SSL Verification (enabled by default)
        "REST_ENABLE_SSL_VERIFY": "false", // Set to false to disable SSL verification for self-signed certificates
        // Custom Headers (optional)
        "HEADER_X-API-Version": "2.0",
        "HEADER_Custom-Client": "my-client",
        "HEADER_Accept": "application/json"
      }
    }
  }
}
```
Nota: Reemplace las variables de entorno con sus valores reales. Configure solo un método de autenticación a la vez:  
1. Autenticación Básica (usuario/contraseña)  
2. Token Bearer (si no se configura Autenticación Básica)  
3. Clave API (si no se configura ni Autenticación Básica ni Token Bearer)  

## Características  

- Probar endpoints de API REST con diferentes métodos HTTP  
- Soporte para solicitudes GET, POST, PUT, DELETE y PATCH  
- Información detallada de la respuesta incluyendo estado, encabezados y cuerpo  
- Encabezados personalizados:  
  - Encabezados globales mediante variables de entorno HEADER_*  
  - Prefijo insensible a mayúsculas/minúsculas (HEADER_, header_, HeAdEr_)  
  - Preservación de mayúsculas/minúsculas en nombres de encabezados  
  - Aplicación basada en prioridad (por solicitud > autenticación > personalizado)  
- Manejo del cuerpo de la solicitud para métodos POST/PUT  
- Gestión del tamaño de la respuesta:  
  - Limitación automática del tamaño de respuesta (por defecto: 10KB/10000 bytes)  
  - Límite de tamaño configurable mediante la variable de entorno REST_RESPONSE_SIZE_LIMIT  
  - Limpieza de metadatos de truncamiento cuando las respuestas exceden el límite  
  - Preserva la estructura de la respuesta mientras solo trunca el contenido del cuerpo  

- Verificación de certificado SSL:  
  - Habilitada por defecto para operación segura  
  - Puede deshabilitarse para certificados autofirmados o entornos de desarrollo  
  - Control mediante la variable de entorno REST_ENABLE_SSL_VERIFY  
- Múltiples métodos de autenticación:  
  - Autenticación Básica (usuario/contraseña)  
  - Autenticación con Token Bearer  
  - Autenticación con Clave API (encabezado personalizado)  

## Ejemplos de uso  

Una vez instalado y configurado, puede usar el Probador de API REST a través de Cline para probar sus endpoints de API:


```typescript
// Test a GET endpoint
use_mcp_tool('rest-api', 'test_request', {
  "method": "GET",
  "endpoint": "/users"
});

// Test a POST endpoint with body
use_mcp_tool('rest-api', 'test_request', {
  "method": "POST",
  "endpoint": "/users",
  "body": {
    "name": "John Doe",
    "email": "john@example.com"
  }
});

// Test with custom headers
use_mcp_tool('rest-api', 'test_request', {
  "method": "GET",
  "endpoint": "/products",
  "headers": {
    "Accept-Language": "en-US",
    "X-Custom-Header": "custom-value"
  }
});
```

## Desarrollo

1. Clona el repositorio:
```bash
git clone https://github.com/zenturacp/mcp-rest-api.git
cd mcp-rest-api
```
2. Instalar dependencias:

```bash
npm install
```
3. Construya el proyecto:

```bash
npm run build
```
Para el desarrollo con reconstrucción automática:

```bash
npm run watch
```

## Licencia

Este proyecto está licenciado bajo la Licencia MIT - consulte el archivo [LICENSE](LICENSE) para más detalles.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-06

---