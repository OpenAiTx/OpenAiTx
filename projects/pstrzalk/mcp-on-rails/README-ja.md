# MCP on Rails（オプションでOAuth対応）

Ruby on Railsと[Model Context Protocol (MCP)](https://github.com/anthropics/model-context-protocol)を統合するRailsアプリケーションテンプレートです。セットアップ時に[Devise](https://github.com/heartcombo/devise)と[Doorkeeper](https://github.com/doorkeeper-gem/doorkeeper)を使ったOAuth 2.1保護を追加するかどうかを尋ねるため、1つのテンプレートでプレーンなMCPと完全認証済みのセットアップの両方に対応します。

## クイックスタート

```bash
git clone https://github.com/pstrzalk/mcp-on-rails.git
rails new myapp -m mcp-on-rails/mcp
cd myapp
rails db:migrate
rails server
```
テンプレートは次のように促します：


```
Add Devise + Doorkeeper OAuth 2.1 authentication? (y/n)
```

通常のMCPサーバーには **n** を、完全なOAuth保護には **y** を入力してください。

### 既存のRailsアプリケーションへのMCPテンプレートの追加

このテンプレートは既存のRailsアプリにも簡単に適用できます。

```bash
git clone https://github.com/pstrzalk/mcp-on-rails.git
cd your-project/
rails app:template LOCATION=../mcp-on-rails/mcp
```
---

## プレーンMCP（「n」と回答）

認証不要のオープンMCPサーバー付きのRailsアプリを作成します。

### 得られるもの

- Gemfileに追加される**`mcp` gem**
- `/mcp`にある**`McpController`** — `ActionController::API`を継承し、MCPプロトコルを処理
- **MCPルート** — `POST /mcp`、`GET /mcp`
- **スキャフォールドフック** — `rails generate scaffold`で自動的にMCPツールを作成
- **カスタムツールジェネレーター** — `rails generate mcp_tool ToolName field:type`
- **カスタムプロンプトジェネレーター** — `rails generate mcp_prompt PromptName arg arg:required`
- ApplicationRecordにある一貫したテキストフォーマット用の**`to_mcp_response`**
- 登録されたすべてのツールとプロンプトを一覧表示する**`rake mcp:tools`**と**`rake mcp:prompts`**（詳細表示には`mcp:tools:verbose` / `mcp:prompts:verbose`を使用）

### 使い方


```bash
rails new myapp -m mcp-on-rails/mcp   # answer n
cd myapp && rails db:migrate

rails generate scaffold Post title:string body:text
rails db:migrate
rails server
```
テストしてください：


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

### プロジェクト構成（プレーンモード）

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

### AIアシスタントの接続（プレーンモード）

```json
{
  "name": "my-rails-app",
  "type": "StreamableHttp",
  "url": "http://localhost:3000/mcp"
}
```
認証不要 — `/mcp` エンドポイントはオープンです。

---

## OAuth MCP（「y」と答える）

PKCE、動的クライアント登録、リソースインジケーター対応を含むOAuth 2.1保護されたMCPサーバーを備えたRailsアプリを作成します — MCPのOAuth認可フローに必要なすべてを含みます。

### 取得できるもの

プレーンモードの内容に加え、以下が含まれます：

- Gemfileに**`devise` + `doorkeeper` gems**を追加
- **Devise**によるユーザー認証（サインアップ、サインイン、パスワードリセット）
- **Doorkeeper**によるPKCE強制（S256）のOAuth 2.1プロバイダー
- `doorkeeper_authorize!`で保護され、トークンのオーディエンス検証（RFC 8707）を行う**`McpController`**
- `POST /oauth/register`での**動的クライアント登録**（RFC 7591）
- `GET /.well-known/oauth-protected-resource`での**保護リソースメタデータ**（RFC 9728）
- `GET /.well-known/oauth-authorization-server`での**認可サーバーメタデータ**（RFC 8414）
- **リソースインジケーター** — トークンは`/mcp`リソースにスコープされる（RFC 8707）

### 使い方


```bash
rails new myapp -m mcp-on-rails/mcp   # answer y
cd myapp && rails db:migrate

rails generate scaffold Post title:string body:text
rails db:migrate
rails server
```
`/mcp` エンドポイントは現在 Bearer トークンを必要とします — 認証されていないリクエストは 401 を返します。

### OAuth フロー

完全な認可フローは MCP の OAuth 仕様に従います:

1. **ディスカバリー** — クライアントは認可サーバを見つけるために `GET /.well-known/oauth-protected-resource` を取得します
2. **サーバーメタデータ** — クライアントはエンドポイントと機能のために `GET /.well-known/oauth-authorization-server` を取得します
3. **クライアント登録** — クライアントメタデータと共に `POST /oauth/register` を実行します (RFC 7591)
4. **認可** — PKCE の `code_challenge` (S256) と `resource` パラメータを付けて `GET /oauth/authorize`
5. **ユーザー認証** — Devise がサインイン/サインアップを処理します
6. **トークン交換** — `code_verifier` と `resource` パラメータを付けて `POST /oauth/token`
7. **MCP リクエスト** — `Authorization: Bearer <token>` を付けて `POST /mcp`

### サポートされる RFC

| RFC | 説明 | エンドポイント |
|-----|-------------|----------|
| OAuth 2.1 + PKCE | 認可コード交換のための証明キー付き認可 (S256) | `/oauth/authorize`, `/oauth/token` |
| RFC 7591 | 動的クライアント登録 | `POST /oauth/register` |
| RFC 8414 | 認可サーバメタデータ | `GET /.well-known/oauth-authorization-server` |
| RFC 8707 | リソースインジケータ | 認可およびトークンリクエストの `resource` パラメータ |
| RFC 9728 | 保護リソースメタデータ | `GET /.well-known/oauth-protected-resource` |

### プロジェクト構成 (OAuth モード)


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

### AIアシスタントの接続（OAuthモード）

```json
{
  "name": "my-rails-app",
  "type": "StreamableHttp",
  "url": "http://localhost:3000/mcp"
}
```

クライアントはMCPリクエストを行う前にOAuth PKCEフローを完了する必要があります — 有効なBearerトークンなしでは`/mcp`エンドポイントは401を返します。

---

## 共通機能（両モード）

### MCPツールによるモデルのスキャフォールディング

```bash
rails generate scaffold Post title:string content:text
rails db:migrate
```

これにより、標準のRailsファイルに加えて `app/tools/posts/` に5つのMCPツールが作成されます：
- `show_tool.rb` — IDで単一の投稿を取得
- `index_tool.rb` — ページネーション付きで投稿一覧を表示
- `create_tool.rb` — 新しい投稿を作成
- `update_tool.rb` — 既存の投稿を更新
- `delete_tool.rb` — 投稿を削除

### カスタムMCPツールの作成

```bash
rails generate mcp_tool WeatherCheck location:string
```

### カスタムMCPプロンプトの作成

```bash
rails generate mcp_prompt hotel_finder location:required check_in_date:required adults price_max
```

これにより、`app/prompts/hotel_finder.rb` が作成され、`MCP::Prompt` を継承したプロンプトクラスが生成されます。引数はデフォルトで任意です — 必須にするには `:required` を付け加えます。

プロンプトは `app/prompts/` から自動的に読み込まれ、MCPサーバーに登録されます。ツールとは異なり、プロンプトはスキャフォールディング中に自動生成されません — ジェネレーターを使って明示的に作成します。

### 使用可能なツールとプロンプトの一覧表示

```bash
rake mcp:tools             # compact one-line-per-tool summary
rake mcp:tools:verbose     # full details with schema
rake mcp:prompts           # compact one-line-per-prompt summary
rake mcp:prompts:verbose   # full details with arguments
```

## ライセンス

MIT ライセンス


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-17

---