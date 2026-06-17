# MCP on Rails (with optional OAuth)

A Rails application template that integrates the [Model Context Protocol (MCP)](https://github.com/anthropics/model-context-protocol) with Ruby on Rails. During setup, the template asks whether to add OAuth 2.1 protection using [Devise](https://github.com/heartcombo/devise) and [Doorkeeper](https://github.com/doorkeeper-gem/doorkeeper) — so one template supports both plain MCP and fully authenticated setups.

## Quick Start

```bash
git clone https://github.com/pstrzalk/mcp-on-rails.git
rails new myapp -m mcp-on-rails/mcp
cd myapp
rails db:migrate
rails server
```

The template will prompt:

```
Add Devise + Doorkeeper OAuth 2.1 authentication? (y/n)
```

Answer **n** for a plain MCP server or **y** for full OAuth protection.

### Adding the MCP template to an existing Rails application

You may just as easily apply this template to an existing Rails app.

```bash
git clone https://github.com/pstrzalk/mcp-on-rails.git
cd your-project/
rails app:template LOCATION=../mcp-on-rails/mcp
```

---

## Plain MCP (answer "n")

Creates a Rails app with an open MCP server — no authentication required.

### What you get

- **`mcp` gem** added to Gemfile
- **`McpController`** at `/mcp` — inherits `ActionController::API`, handles MCP protocol
- **MCP routes** — `POST /mcp`, `GET /mcp`
- **Scaffold hook** — `rails generate scaffold` automatically creates MCP tools
- **Custom tool generator** — `rails generate mcp_tool ToolName field:type`
- **Custom prompt generator** — `rails generate mcp_prompt PromptName arg arg:required`
- **`to_mcp_response`** on ApplicationRecord for consistent text formatting
- **`rake mcp:tools`** and **`rake mcp:prompts`** to list all registered tools and prompts (use `mcp:tools:verbose` / `mcp:prompts:verbose` for full details)

### Usage

```bash
rails new myapp -m mcp-on-rails/mcp   # answer n
cd myapp && rails db:migrate

rails generate scaffold Post title:string body:text
rails db:migrate
rails server
```

Test it:

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

### Project structure (plain mode)

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

### Connecting AI assistants (plain mode)

```json
{
  "name": "my-rails-app",
  "type": "StreamableHttp",
  "url": "http://localhost:3000/mcp"
}
```

No authentication needed — the `/mcp` endpoint is open.

---

## OAuth MCP (answer "y")

Creates a Rails app with an OAuth 2.1-protected MCP server, including PKCE, dynamic client registration, and resource indicator support — everything needed for MCP's OAuth authorization flow.

### What you get

Everything from plain mode, plus:

- **`devise` + `doorkeeper` gems** added to Gemfile
- **Devise** user authentication (sign-up, sign-in, password reset)
- **Doorkeeper** OAuth 2.1 provider with PKCE enforcement (S256)
- **`McpController`** protected by `doorkeeper_authorize!` with token audience validation (RFC 8707)
- **Dynamic client registration** at `POST /oauth/register` (RFC 7591)
- **Protected resource metadata** at `GET /.well-known/oauth-protected-resource` (RFC 9728)
- **Authorization server metadata** at `GET /.well-known/oauth-authorization-server` (RFC 8414)
- **Resource indicators** — tokens are scoped to the `/mcp` resource (RFC 8707)

### Usage

```bash
rails new myapp -m mcp-on-rails/mcp   # answer y
cd myapp && rails db:migrate

rails generate scaffold Post title:string body:text
rails db:migrate
rails server
```

The `/mcp` endpoint now requires a Bearer token — unauthenticated requests return 401.

### OAuth flow

The full authorization flow follows MCP's OAuth specification:

1. **Discovery** — Client fetches `GET /.well-known/oauth-protected-resource` to find the authorization server
2. **Server metadata** — Client fetches `GET /.well-known/oauth-authorization-server` for endpoints and capabilities
3. **Client registration** — `POST /oauth/register` with client metadata (RFC 7591)
4. **Authorization** — `GET /oauth/authorize` with PKCE `code_challenge` (S256) and `resource` parameter
5. **User authentication** — Devise handles sign-in/sign-up
6. **Token exchange** — `POST /oauth/token` with `code_verifier` and `resource` parameter
7. **MCP requests** — `POST /mcp` with `Authorization: Bearer <token>`

### Supported RFCs

| RFC | Description | Endpoint |
|-----|-------------|----------|
| OAuth 2.1 + PKCE | Authorization with Proof Key for Code Exchange (S256) | `/oauth/authorize`, `/oauth/token` |
| RFC 7591 | Dynamic Client Registration | `POST /oauth/register` |
| RFC 8414 | Authorization Server Metadata | `GET /.well-known/oauth-authorization-server` |
| RFC 8707 | Resource Indicators | `resource` parameter in auth + token requests |
| RFC 9728 | Protected Resource Metadata | `GET /.well-known/oauth-protected-resource` |

### Project structure (OAuth mode)

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

### Connecting AI assistants (OAuth mode)

```json
{
  "name": "my-rails-app",
  "type": "StreamableHttp",
  "url": "http://localhost:3000/mcp"
}
```

The client must complete the OAuth PKCE flow before making MCP requests — the `/mcp` endpoint returns 401 without a valid Bearer token.

---

## Common Features (both modes)

### Scaffolding models with MCP tools

```bash
rails generate scaffold Post title:string content:text
rails db:migrate
```

This creates standard Rails files plus 5 MCP tools in `app/tools/posts/`:
- `show_tool.rb` — Retrieve a single post by ID
- `index_tool.rb` — List posts with pagination
- `create_tool.rb` — Create new posts
- `update_tool.rb` — Update existing posts
- `delete_tool.rb` — Delete posts

### Creating custom MCP tools

```bash
rails generate mcp_tool WeatherCheck location:string
```

### Creating custom MCP prompts

```bash
rails generate mcp_prompt hotel_finder location:required check_in_date:required adults price_max
```

This creates `app/prompts/hotel_finder.rb` with a prompt class inheriting from `MCP::Prompt`. Arguments are optional by default — append `:required` to make them required.

Prompts are automatically loaded from `app/prompts/` and registered with the MCP server. Unlike tools, prompts are **not** auto-generated during scaffolding — they are created explicitly via the generator.

### Listing available tools and prompts

```bash
rake mcp:tools             # compact one-line-per-tool summary
rake mcp:tools:verbose     # full details with schema
rake mcp:prompts           # compact one-line-per-prompt summary
rake mcp:prompts:verbose   # full details with arguments
```

## License

MIT License
