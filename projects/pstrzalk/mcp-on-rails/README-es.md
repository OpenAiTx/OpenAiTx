# MCP on Rails (con OAuth opcional)

Una plantilla de aplicación Rails que integra el [Protocolo de Contexto de Modelo (MCP)](https://github.com/anthropics/model-context-protocol) con Ruby on Rails. Durante la configuración, la plantilla pregunta si se desea agregar protección OAuth 2.1 usando [Devise](https://github.com/heartcombo/devise) y [Doorkeeper](https://github.com/doorkeeper-gem/doorkeeper) — así que una sola plantilla soporta tanto MCP simple como configuraciones totalmente autenticadas.

## Inicio rápido

```bash
git clone https://github.com/pstrzalk/mcp-on-rails.git
rails new myapp -m mcp-on-rails/mcp
cd myapp
rails db:migrate
rails server
```
La plantilla mostrará:


```
Add Devise + Doorkeeper OAuth 2.1 authentication? (y/n)
```

Responda **n** para un servidor MCP simple o **y** para protección completa OAuth.

### Agregar la plantilla MCP a una aplicación Rails existente

También puede aplicar esta plantilla fácilmente a una aplicación Rails ya existente.

```bash
git clone https://github.com/pstrzalk/mcp-on-rails.git
cd your-project/
rails app:template LOCATION=../mcp-on-rails/mcp
```

---

## MCP simple (responder "n")

Crea una aplicación Rails con un servidor MCP abierto — no se requiere autenticación.

### Lo que obtienes

- **gema `mcp`** añadida al Gemfile  
- **`McpController`** en `/mcp` — hereda de `ActionController::API`, maneja el protocolo MCP  
- **Rutas MCP** — `POST /mcp`, `GET /mcp`  
- **Hook scaffold** — `rails generate scaffold` crea automáticamente herramientas MCP  
- **Generador de herramientas personalizado** — `rails generate mcp_tool NombreHerramienta campo:tipo`  
- **Generador de prompts personalizado** — `rails generate mcp_prompt NombrePrompt arg arg:required`  
- **`to_mcp_response`** en ApplicationRecord para formato de texto consistente  
- **`rake mcp:tools`** y **`rake mcp:prompts`** para listar todas las herramientas y prompts registrados (usa `mcp:tools:verbose` / `mcp:prompts:verbose` para detalles completos)

### Uso

```bash
rails new myapp -m mcp-on-rails/mcp   # answer n
cd myapp && rails db:migrate

rails generate scaffold Post title:string body:text
rails db:migrate
rails server
```
Pruébalo:


```bash
# MCP initialize
curl -X POST http://localhost:3000/mcp \
  -H "Content-Type: application/json" \
  -d '{"jsonrpc":"2.0","id":1,"method":"initialize","params":{"protocolVersion":"2025-03-26","capabilities":{},"clientInfo":{"name":"test","version":"1.0"}}}'

# List tools
curl -X POST http://localhost:3000/mcp \
  -H "Content-Type: application/json" \
  -d '{"jsonrpc":"2.0","id":2,"method":"tools/list"}'
```

### Estructura del proyecto (modo simple)

```
app/
├── controllers/
│   └── mcp_controller.rb              # Open MCP endpoint (no auth)
├── models/
│   └── application_record.rb          # Extended with to_mcp_response
├── prompts/                           # MCP prompts (created via generator)
└── tools/                             # MCP tools (auto-generated per scaffold)

config/
├── initializers/
│   └── mcp.rb                         # MCP tool and prompt autoloading
└── routes.rb                          # MCP routes

lib/
├── generators/                        # MCP tool and prompt generators
└── tasks/
    └── mcp.rake                       # rake mcp:tools, rake mcp:prompts (and verbose variants)
```

### Conectando asistentes de IA (modo sencillo)

```json
{
  "name": "my-rails-app",
  "type": "StreamableHttp",
  "url": "http://localhost:3000/mcp"
}
```

No se necesita autenticación: el endpoint `/mcp` está abierto.

---

## OAuth MCP (responder "y")

Crea una aplicación Rails con un servidor MCP protegido por OAuth 2.1, incluyendo PKCE, registro dinámico de clientes y soporte para indicadores de recursos — todo lo necesario para el flujo de autorización OAuth de MCP.

### Qué obtienes

Todo lo del modo básico, más:

- **Gemas `devise` + `doorkeeper`** añadidas al Gemfile
- **Autenticación de usuario Devise** (registro, inicio de sesión, restablecimiento de contraseña)
- **Proveedor OAuth 2.1 Doorkeeper** con enforcement de PKCE (S256)
- **`McpController`** protegido por `doorkeeper_authorize!` con validación de audiencia del token (RFC 8707)
- **Registro dinámico de clientes** en `POST /oauth/register` (RFC 7591)
- **Metadatos de recursos protegidos** en `GET /.well-known/oauth-protected-resource` (RFC 9728)
- **Metadatos del servidor de autorización** en `GET /.well-known/oauth-authorization-server` (RFC 8414)
- **Indicadores de recursos** — los tokens están limitados al recurso `/mcp` (RFC 8707)

### Uso

```bash
rails new myapp -m mcp-on-rails/mcp   # answer y
cd myapp && rails db:migrate

rails generate scaffold Post title:string body:text
rails db:migrate
rails server
```

El endpoint `/mcp` ahora requiere un token Bearer — las solicitudes no autenticadas retornan 401.

### Flujo OAuth

El flujo completo de autorización sigue la especificación OAuth de MCP:

1. **Descubrimiento** — El cliente obtiene `GET /.well-known/oauth-protected-resource` para encontrar el servidor de autorización
2. **Metadatos del servidor** — El cliente obtiene `GET /.well-known/oauth-authorization-server` para endpoints y capacidades
3. **Registro del cliente** — `POST /oauth/register` con metadatos del cliente (RFC 7591)
4. **Autorización** — `GET /oauth/authorize` con PKCE `code_challenge` (S256) y parámetro `resource`
5. **Autenticación del usuario** — Devise maneja el inicio de sesión/registro
6. **Intercambio de token** — `POST /oauth/token` con `code_verifier` y parámetro `resource`
7. **Solicitudes MCP** — `POST /mcp` con `Authorization: Bearer <token>`

### RFCs soportados

| RFC | Descripción | Endpoint |
|-----|-------------|----------|
| OAuth 2.1 + PKCE | Autorización con Proof Key for Code Exchange (S256) | `/oauth/authorize`, `/oauth/token` |
| RFC 7591 | Registro dinámico de clientes | `POST /oauth/register` |
| RFC 8414 | Metadatos del servidor de autorización | `GET /.well-known/oauth-authorization-server` |
| RFC 8707 | Indicadores de recurso | Parámetro `resource` en solicitudes de auth + token |
| RFC 9728 | Metadatos de recursos protegidos | `GET /.well-known/oauth-protected-resource` |

### Estructura del proyecto (modo OAuth)

```
app/
├── controllers/
│   ├── mcp_controller.rb                              # OAuth-protected MCP endpoint
│   ├── oauth_client_registration_controller.rb        # RFC 7591
│   └── oauth_authorization_server_metadata_controller.rb  # RFC 8414 + 9728
├── models/
│   ├── user.rb                                        # Devise user with OAuth associations
│   ├── oauth_application.rb
│   ├── oauth_access_token.rb
│   └── oauth_access_grant.rb
├── prompts/                                           # MCP prompts (created via generator)
├── tools/                                             # MCP tools (auto-generated per scaffold)
└── views/
    └── devise/                                        # Customizable auth views

config/
├── initializers/
│   ├── doorkeeper.rb                                  # OAuth + PKCE config
│   ├── devise.rb                                      # User auth config
│   └── mcp.rb                                         # MCP tool autoloading
└── routes.rb                                          # All OAuth + MCP routes

db/migrate/
├── *_devise_create_users.rb
├── *_create_doorkeeper_tables.rb
├── *_enable_pkce.rb
└── *_add_resource_to_oauth_tables.rb
```

### Conexión de asistentes de IA (modo OAuth)

```json
{
  "name": "my-rails-app",
  "type": "StreamableHttp",
  "url": "http://localhost:3000/mcp"
}
```

El cliente debe completar el flujo OAuth PKCE antes de realizar solicitudes MCP — el endpoint `/mcp` devuelve 401 sin un token Bearer válido.

---

## Funciones comunes (ambos modos)

### Estructuración de modelos con herramientas MCP

```bash
rails generate scaffold Post title:string content:text
rails db:migrate
```

Esto crea archivos estándar de Rails más 5 herramientas MCP en `app/tools/posts/`:
- `show_tool.rb` — Recuperar una sola publicación por ID
- `index_tool.rb` — Listar publicaciones con paginación
- `create_tool.rb` — Crear nuevas publicaciones
- `update_tool.rb` — Actualizar publicaciones existentes
- `delete_tool.rb` — Eliminar publicaciones

### Creación de herramientas MCP personalizadas

```bash
rails generate mcp_tool WeatherCheck location:string
```

### Creación de indicaciones MCP personalizadas

```bash
rails generate mcp_prompt hotel_finder location:required check_in_date:required adults price_max
```

Esto crea `app/prompts/hotel_finder.rb` con una clase de indicación que hereda de `MCP::Prompt`. Los argumentos son opcionales por defecto — agregue `:required` para hacerlos obligatorios.

Las indicaciones se cargan automáticamente desde `app/prompts/` y se registran con el servidor MCP. A diferencia de las herramientas, las indicaciones **no** se generan automáticamente durante el scaffolding — se crean explícitamente mediante el generador.

### Listando herramientas e indicaciones disponibles

```bash
rake mcp:tools             # compact one-line-per-tool summary
rake mcp:tools:verbose     # full details with schema
rake mcp:prompts           # compact one-line-per-prompt summary
rake mcp:prompts:verbose   # full details with arguments
```

## Licencia

Licencia MIT


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-17

---