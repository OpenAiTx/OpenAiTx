# MCP REST API 测试工具
[![许可证: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![NPM 包](https://img.shields.io/npm/v/dkmaker-mcp-rest-api.svg)](https://www.npmjs.com/package/dkmaker-mcp-rest-api)

一个基于 TypeScript 的 MCP 服务器，支持通过 Claude、Cline 及其他 MCP 客户端测试 REST API。该工具允许您直接从开发环境测试和交互任何 REST API 端点。

<a href="https://glama.ai/mcp/servers/izr2sp4rqo">
  <img width="380" height="200" src="https://glama.ai/mcp/servers/izr2sp4rqo/badge?refresh=1234" />
</a>

## 安装

全局安装该包：
```bash
npm install -g dkmaker-mcp-rest-api
```

## 配置

### Cline 自定义指令

为了确保 Cline 理解如何有效使用此工具，请将以下内容添加到您的 Cline 自定义指令中（设置 > 自定义指令）：

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

### MCP 服务器配置

虽然这些说明针对的是 Cline，但该服务器应适用于任何 MCP 实现。请根据您的操作系统进行配置：

### Windows
⚠️ **重要**：由于 Windows 路径解析的已知问题（[问题 #40](https://github.com/modelcontextprotocol/servers/issues/40)），您必须使用完整路径，而不是 %APPDATA%。

添加到 `C:\Users\<YourUsername>\AppData\Roaming\Code\User\globalStorage\saoudrizwan.claude-dev\settings\cline_mcp_settings.json`：
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
添加到 `~/Library/Application Support/Code/User/globalStorage/saoudrizwan.claude-dev/settings/cline_mcp_settings.json`：
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
注意：请将环境变量替换为您的实际值。一次只配置一种认证方式：
1. 基本认证（用户名/密码）
2. Bearer令牌（如果未配置基本认证）
3. API密钥（如果未配置基本认证和Bearer令牌）

## 功能

- 使用不同的HTTP方法测试REST API端点
- 支持GET、POST、PUT、DELETE和PATCH请求
- 详细的响应信息，包括状态、头信息和正文
- 自定义头部：
  - 通过HEADER_*环境变量设置全局头部
  - 不区分大小写的前缀（HEADER_，header_，HeAdEr_）
  - 保留头部名称的大小写
  - 基于优先级应用（每次请求 > 认证 > 自定义）
- POST/PUT方法的请求正文处理
- 响应大小管理：
  - 自动响应大小限制（默认：10KB/10000字节）
  - 可通过REST_RESPONSE_SIZE_LIMIT环境变量配置大小限制
  - 当响应超过限制时清除截断元数据
  - 保留响应结构，仅截断正文内容

- SSL证书验证：
  - 默认启用以确保安全操作
  - 可针对自签名证书或开发环境禁用
  - 通过REST_ENABLE_SSL_VERIFY环境变量控制
- 多种认证方式：
  - 基本认证（用户名/密码）
  - Bearer令牌认证
  - API密钥认证（自定义头部）

## 使用示例

安装并配置完成后，您可以通过Cline使用REST API测试器测试您的API端点：


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

## 开发

1. 克隆仓库：
```bash
git clone https://github.com/zenturacp/mcp-rest-api.git
cd mcp-rest-api
```
2. 安装依赖项：

```bash
npm install
```

3. 构建项目：
```bash
npm run build
```
用于自动重建的开发：

```bash
npm run watch
```

## 许可证

本项目采用 MIT 许可证 - 详情请参阅 [LICENSE](LICENSE) 文件。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-06

---