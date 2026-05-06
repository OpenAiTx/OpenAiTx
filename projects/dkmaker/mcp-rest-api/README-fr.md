# Testeur API REST MCP
[![Licence : MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![Package NPM](https://img.shields.io/npm/v/dkmaker-mcp-rest-api.svg)](https://www.npmjs.com/package/dkmaker-mcp-rest-api)

Un serveur MCP basé sur TypeScript qui permet de tester les API REST via Claude, Cline et d'autres clients MCP. Cet outil vous permet de tester et d'interagir avec n'importe quel point de terminaison API REST directement depuis votre environnement de développement.

<a href="https://glama.ai/mcp/servers/izr2sp4rqo">
  <img width="380" height="200" src="https://glama.ai/mcp/servers/izr2sp4rqo/badge?refresh=1234" />
</a>

## Installation

Installez le package globalement :
```bash
npm install -g dkmaker-mcp-rest-api
```

## Configuration

### Instructions personnalisées pour Cline

Pour garantir que Cline comprenne comment utiliser efficacement cet outil, ajoutez ce qui suit à vos instructions personnalisées pour Cline (Paramètres > Instructions personnalisées) :

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

### Configuration du serveur MCP

Bien que ces instructions soient pour Cline, le serveur devrait fonctionner avec toute implémentation MCP. Configurez selon votre système d'exploitation :

### Windows
⚠️ **IMPORTANT** : En raison d’un problème connu avec la résolution des chemins sous Windows ([problème #40](https://github.com/modelcontextprotocol/servers/issues/40)), vous devez utiliser le chemin complet au lieu de %APPDATA%.

Ajoutez dans `C:\Users\<VotreNomUtilisateur>\AppData\Roaming\Code\User\globalStorage\saoudrizwan.claude-dev\settings\cline_mcp_settings.json` :
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
Ajouter à `~/Library/Application Support/Code/User/globalStorage/saoudrizwan.claude-dev/settings/cline_mcp_settings.json` :
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
Note : Remplacez les variables d'environnement par vos valeurs réelles. Configurez une seule méthode d'authentification à la fois :
1. Authentification Basique (nom d'utilisateur/mot de passe)
2. Jeton Bearer (si l'authentification basique n'est pas configurée)
3. Clé API (si ni l'authentification basique ni le jeton Bearer ne sont configurés)

## Fonctionnalités

- Tester les points d'accès REST API avec différentes méthodes HTTP
- Support des requêtes GET, POST, PUT, DELETE et PATCH
- Informations détaillées sur la réponse incluant statut, en-têtes et corps
- En-têtes personnalisés :
  - En-têtes globaux via les variables d'environnement HEADER_*
  - Préfixe insensible à la casse (HEADER_, header_, HeAdEr_)
  - Conservation de la casse des noms d'en-têtes
  - Application prioritaire (par requête > auth > personnalisé)
- Gestion du corps de la requête pour les méthodes POST/PUT
- Gestion de la taille des réponses :
  - Limitation automatique de la taille de réponse (par défaut : 10Ko/10000 octets)
  - Limite configurable via la variable d'environnement REST_RESPONSE_SIZE_LIMIT
  - Effacement des métadonnées de troncature lorsque les réponses dépassent la limite
  - Conservation de la structure de la réponse tout en tronquant uniquement le contenu du corps

- Vérification du certificat SSL :
  - Activée par défaut pour une opération sécurisée
  - Peut être désactivée pour les certificats auto-signés ou les environnements de développement
  - Contrôle via la variable d'environnement REST_ENABLE_SSL_VERIFY
- Plusieurs méthodes d'authentification :
  - Authentification Basique (nom d'utilisateur/mot de passe)
  - Authentification par jeton Bearer
  - Authentification par clé API (en-tête personnalisé)

## Exemples d'utilisation

Une fois installé et configuré, vous pouvez utiliser le Testeur REST API via Cline pour tester vos points d'accès API :


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

## Développement

1. Clonez le dépôt :
```bash
git clone https://github.com/zenturacp/mcp-rest-api.git
cd mcp-rest-api
```

2. Installer les dépendances :
```bash
npm install
```
3. Construisez le projet :

```bash
npm run build
```

Pour le développement avec reconstruction automatique :
```bash
npm run watch
```

## Licence

Ce projet est sous licence MIT - voir le fichier [LICENSE](LICENSE) pour plus de détails.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-06

---