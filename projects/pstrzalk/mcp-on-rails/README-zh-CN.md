# MCP on Rails（可选 OAuth）

一个集成了[模型上下文协议（MCP）](https://github.com/anthropics/model-context-protocol)与 Ruby on Rails 的 Rails 应用模板。设置过程中，模板会询问是否添加使用 [Devise](https://github.com/heartcombo/devise) 和 [Doorkeeper](https://github.com/doorkeeper-gem/doorkeeper) 的 OAuth 2.1 保护——因此一个模板支持纯 MCP 和完全认证的设置。

## 快速开始

```bash
git clone https://github.com/pstrzalk/mcp-on-rails.git
rails new myapp -m mcp-on-rails/mcp
cd myapp
rails db:migrate
rails server
```
模板将提示：


```
Add Devise + Doorkeeper OAuth 2.1 authentication? (y/n)
```

回答 **n** 表示普通 MCP 服务器，回答 **y** 表示完整的 OAuth 保护。

### 将 MCP 模板添加到现有的 Rails 应用程序

您也可以轻松地将此模板应用到现有的 Rails 应用程序。

```bash
git clone https://github.com/pstrzalk/mcp-on-rails.git
cd your-project/
rails app:template LOCATION=../mcp-on-rails/mcp
```

---

## 纯MCP（回答“n”）

创建一个带有开放MCP服务器的Rails应用 — 无需身份验证。

### 你将获得

- **`mcp` gem** 被添加到Gemfile中
- **`McpController`** 位于 `/mcp` — 继承自 `ActionController::API`，处理MCP协议
- **MCP路由** — `POST /mcp`，`GET /mcp`
- **脚手架钩子** — `rails generate scaffold` 自动创建MCP工具
- **自定义工具生成器** — `rails generate mcp_tool ToolName field:type`
- **自定义提示生成器** — `rails generate mcp_prompt PromptName arg arg:required`
- **`to_mcp_response`** 在ApplicationRecord上用于一致的文本格式化
- **`rake mcp:tools`** 和 **`rake mcp:prompts`** 列出所有已注册的工具和提示（使用 `mcp:tools:verbose` / `mcp:prompts:verbose` 查看完整详情）

### 用法

```bash
rails new myapp -m mcp-on-rails/mcp   # answer n
cd myapp && rails db:migrate

rails generate scaffold Post title:string body:text
rails db:migrate
rails server
```
测试它：


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

### 项目结构（纯文本模式）

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

### 连接 AI 助手（纯文本模式）

```json
{
  "name": "my-rails-app",
  "type": "StreamableHttp",
  "url": "http://localhost:3000/mcp"
}
```

无需认证 — `/mcp` 端点是开放的。

---

## OAuth MCP（回答“y”）

创建一个带有 OAuth 2.1 保护的 MCP 服务器的 Rails 应用，包括 PKCE、动态客户端注册和资源指示器支持 — MCP 的 OAuth 授权流程所需的一切。

### 你将获得

普通模式的所有功能，外加：

- **`devise` + `doorkeeper` gems** 已添加到 Gemfile
- **Devise** 用户认证（注册、登录、密码重置）
- **Doorkeeper** OAuth 2.1 提供者，强制执行 PKCE（S256）
- **`McpController`** 由 `doorkeeper_authorize!` 保护，并进行令牌受众验证（RFC 8707）
- **动态客户端注册** 于 `POST /oauth/register`（RFC 7591）
- **受保护资源元数据** 于 `GET /.well-known/oauth-protected-resource`（RFC 9728）
- **授权服务器元数据** 于 `GET /.well-known/oauth-authorization-server`（RFC 8414）
- **资源指示器** — 令牌作用域限定为 `/mcp` 资源（RFC 8707）

### 使用方法

```bash
rails new myapp -m mcp-on-rails/mcp   # answer y
cd myapp && rails db:migrate

rails generate scaffold Post title:string body:text
rails db:migrate
rails server
```

`/mcp` 端点现在需要 Bearer 令牌 — 未认证的请求返回 401。

### OAuth 流程

完整的授权流程遵循 MCP 的 OAuth 规范：

1. **发现** — 客户端获取 `GET /.well-known/oauth-protected-resource` 以查找授权服务器
2. **服务器元数据** — 客户端获取 `GET /.well-known/oauth-authorization-server` 以获取端点和功能
3. **客户端注册** — 使用客户端元数据进行 `POST /oauth/register`（RFC 7591）
4. **授权** — 使用 PKCE `code_challenge`（S256）和 `resource` 参数进行 `GET /oauth/authorize`
5. **用户认证** — Devise 处理登录/注册
6. **令牌交换** — 使用 `code_verifier` 和 `resource` 参数进行 `POST /oauth/token`
7. **MCP 请求** — 使用 `Authorization: Bearer <token>` 进行 `POST /mcp`

### 支持的 RFC

| RFC | 描述 | 端点 |
|-----|-------------|----------|
| OAuth 2.1 + PKCE | 使用代码交换的证明密钥授权（S256） | `/oauth/authorize`, `/oauth/token` |
| RFC 7591 | 动态客户端注册 | `POST /oauth/register` |
| RFC 8414 | 授权服务器元数据 | `GET /.well-known/oauth-authorization-server` |
| RFC 8707 | 资源指示器 | 授权和令牌请求中的 `resource` 参数 |
| RFC 9728 | 受保护资源元数据 | `GET /.well-known/oauth-protected-resource` |

### 项目结构（OAuth 模式）

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

### 连接 AI 助手（OAuth 模式）

```json
{
  "name": "my-rails-app",
  "type": "StreamableHttp",
  "url": "http://localhost:3000/mcp"
}
```
客户端必须完成 OAuth PKCE 流程后才能发起 MCP 请求 — `/mcp` 端点在没有有效 Bearer 令牌时返回 401。

---

## 通用功能（两种模式）

### 使用 MCP 工具搭建模型


```bash
rails generate scaffold Post title:string content:text
rails db:migrate
```

这将在 `app/tools/posts/` 中创建标准的 Rails 文件以及 5 个 MCP 工具：
- `show_tool.rb` — 通过 ID 检索单个帖子
- `index_tool.rb` — 分页列出帖子
- `create_tool.rb` — 创建新帖子
- `update_tool.rb` — 更新现有帖子
- `delete_tool.rb` — 删除帖子

### 创建自定义 MCP 工具

```bash
rails generate mcp_tool WeatherCheck location:string
```

### 创建自定义MCP提示

```bash
rails generate mcp_prompt hotel_finder location:required check_in_date:required adults price_max
```

这将创建 `app/prompts/hotel_finder.rb`，其中包含一个继承自 `MCP::Prompt` 的提示类。参数默认是可选的——添加 `:required` 可使其成为必需参数。

提示会自动从 `app/prompts/` 加载并注册到 MCP 服务器。与工具不同，提示**不会**在脚手架生成期间自动生成——它们需要通过生成器显式创建。

### 列出可用的工具和提示

```bash
rake mcp:tools             # compact one-line-per-tool summary
rake mcp:tools:verbose     # full details with schema
rake mcp:prompts           # compact one-line-per-prompt summary
rake mcp:prompts:verbose   # full details with arguments
```

## 许可协议

MIT 许可证


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-17

---