# MCP REST API 테스터
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![NPM Package](https://img.shields.io/npm/v/dkmaker-mcp-rest-api.svg)](https://www.npmjs.com/package/dkmaker-mcp-rest-api)

클로드, 클라인 및 기타 MCP 클라이언트를 통해 REST API를 테스트할 수 있는 TypeScript 기반 MCP 서버입니다. 이 도구를 사용하면 개발 환경에서 직접 모든 REST API 엔드포인트를 테스트하고 상호작용할 수 있습니다.

<a href="https://glama.ai/mcp/servers/izr2sp4rqo">
  <img width="380" height="200" src="https://glama.ai/mcp/servers/izr2sp4rqo/badge?refresh=1234" />
</a>

## 설치

패키지를 전역으로 설치하세요:
```bash
npm install -g dkmaker-mcp-rest-api
```

## 구성

### Cline 맞춤 지침

Cline이 이 도구를 효과적으로 사용하는 방법을 이해하도록 하려면 다음을 Cline 맞춤 지침(설정 > 맞춤 지침)에 추가하세요:

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
### MCP 서버 구성

이 지침은 Cline용이지만, 서버는 모든 MCP 구현과 함께 작동해야 합니다. 운영 체제에 따라 구성하십시오:

### Windows
⚠️ **중요**: Windows 경로 해석의 알려진 문제([이슈 #40](https://github.com/modelcontextprotocol/servers/issues/40))로 인해 %APPDATA% 대신 전체 경로를 사용해야 합니다.

`C:\Users\<YourUsername>\AppData\Roaming\Code\User\globalStorage\saoudrizwan.claude-dev\settings\cline_mcp_settings.json`에 추가:

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
`~/Library/Application Support/Code/User/globalStorage/saoudrizwan.claude-dev/settings/cline_mcp_settings.json`에 추가:
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
참고: 환경 변수를 실제 값으로 교체하세요. 인증 방법은 한 번에 하나만 구성하십시오:
1. 기본 인증 (사용자 이름/비밀번호)
2. 베어러 토큰 (기본 인증이 구성되지 않은 경우)
3. API 키 (기본 인증과 베어러 토큰이 모두 구성되지 않은 경우)

## 기능

- 다양한 HTTP 메서드로 REST API 엔드포인트 테스트
- GET, POST, PUT, DELETE, PATCH 요청 지원
- 상태, 헤더, 본문을 포함한 상세 응답 정보
- 커스텀 헤더:
  - HEADER_* 환경 변수를 통한 전역 헤더
  - 대소문자 구분 없는 접두사 (HEADER_, header_, HeAdEr_)
  - 헤더 이름의 대소문자 보존
  - 우선 순위 기반 적용 (요청별 > 인증 > 커스텀)
- POST/PUT 메서드에 대한 요청 본문 처리
- 응답 크기 관리:
  - 자동 응답 크기 제한 (기본값: 10KB/10000 바이트)
  - REST_RESPONSE_SIZE_LIMIT 환경 변수로 크기 제한 구성 가능
  - 제한 초과 시 잘림 메타데이터 초기화
  - 응답 구조는 유지하며 본문 내용만 잘림 처리

- SSL 인증서 검증:
  - 보안 작동을 위해 기본적으로 활성화됨
  - 자체 서명 인증서 또는 개발 환경에서는 비활성화 가능
  - REST_ENABLE_SSL_VERIFY 환경 변수로 제어
- 여러 인증 방법 지원:
  - 기본 인증 (사용자 이름/비밀번호)
  - 베어러 토큰 인증
  - API 키 인증 (커스텀 헤더)

## 사용 예시

설치 및 구성 후, Cline을 통해 REST API 테스터를 사용하여 API 엔드포인트를 테스트할 수 있습니다:


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

## 개발

1. 저장소를 클론합니다:
```bash
git clone https://github.com/zenturacp/mcp-rest-api.git
cd mcp-rest-api
```

2. 종속 항목 설치:
```bash
npm install
```

3. 프로젝트 빌드:
```bash
npm run build
```

자동 재빌드와 함께 개발하려면:
```bash
npm run watch
```

## 라이선스

이 프로젝트는 MIT 라이선스 하에 있습니다 - 자세한 내용은 [LICENSE](LICENSE) 파일을 참조하세요.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-06

---