# MCP REST API テスター
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![NPM Package](https://img.shields.io/npm/v/dkmaker-mcp-rest-api.svg)](https://www.npmjs.com/package/dkmaker-mcp-rest-api)

TypeScriptベースのMCPサーバーで、Claude、Clineおよびその他のMCPクライアントを通じてREST APIのテストを可能にします。このツールは、開発環境から直接任意のREST APIエンドポイントをテストおよび操作することができます。

<a href="https://glama.ai/mcp/servers/izr2sp4rqo">
  <img width="380" height="200" src="https://glama.ai/mcp/servers/izr2sp4rqo/badge?refresh=1234" />
</a>

## インストール

パッケージをグローバルにインストールします：
```bash
npm install -g dkmaker-mcp-rest-api
```

## 設定

### Cline カスタム指示

Clineがこのツールを効果的に使用する方法を理解できるように、以下をClineのカスタム指示（設定 > カスタム指示）に追加してください：

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

### MCPサーバー設定

これらの指示はCline向けですが、サーバーは任意のMCP実装で動作するはずです。お使いのOSに応じて設定してください：

### Windows
⚠️ **重要**：Windowsのパス解決に関する既知の問題（[issue #40](https://github.com/modelcontextprotocol/servers/issues/40)）のため、%APPDATA%の代わりにフルパスを使用する必要があります。

`C:\Users\<YourUsername>\AppData\Roaming\Code\User\globalStorage\saoudrizwan.claude-dev\settings\cline_mcp_settings.json` に追加してください：
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
`~/Library/Application Support/Code/User/globalStorage/saoudrizwan.claude-dev/settings/cline_mcp_settings.json` に追加：
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
注意：環境変数は実際の値に置き換えてください。認証方法は同時に1つのみ設定してください：
1. ベーシック認証（ユーザー名/パスワード）
2. ベアラートークン（ベーシック認証が設定されていない場合）
3. APIキー（ベーシック認証もベアラートークンも設定されていない場合）

## 機能

- さまざまなHTTPメソッドでREST APIエンドポイントをテスト
- GET、POST、PUT、DELETE、PATCHリクエストに対応
- ステータス、ヘッダー、ボディを含む詳細なレスポンス情報
- カスタムヘッダー：
  - HEADER_* 環境変数によるグローバルヘッダー
  - 大文字小文字を区別しないプレフィックス（HEADER_、header_、HeAdEr_）
  - ヘッダー名の大文字小文字を維持
  - 優先順位に基づく適用（リクエスト毎 > 認証 > カスタム）
- POST/PUTメソッドのリクエストボディ処理
- レスポンスサイズ管理：
  - 自動レスポンスサイズ制限（デフォルト：10KB/10000バイト）
  - REST_RESPONSE_SIZE_LIMIT 環境変数でサイズ制限を設定可能
  - 制限超過時に切り捨てメタデータをクリア
  - レスポンス構造を維持しつつボディのみ切り捨て

- SSL証明書検証：
  - セキュアな動作のためデフォルトで有効
  - 自己署名証明書や開発環境用に無効化可能
  - REST_ENABLE_SSL_VERIFY 環境変数で制御
- 複数の認証方法：
  - ベーシック認証（ユーザー名/パスワード）
  - ベアラートークン認証
  - APIキー認証（カスタムヘッダー）

## 使用例

インストールおよび設定後、Clineを通じてREST APIテスターを使用しAPIエンドポイントをテストできます：


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

## 開発

1. リポジトリをクローンする:
```bash
git clone https://github.com/zenturacp/mcp-rest-api.git
cd mcp-rest-api
```

2. 依存関係をインストールしてください:
```bash
npm install
```

3. プロジェクトをビルドする:
```bash
npm run build
```
自動リビルドでの開発用:

```bash
npm run watch
```

## ライセンス

このプロジェクトはMITライセンスの下でライセンスされています。詳細は[LICENSE](LICENSE)ファイルを参照してください。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-06

---