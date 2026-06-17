# MCP on Rails (선택적 OAuth 포함)

Ruby on Rails와 [Model Context Protocol (MCP)](https://github.com/anthropics/model-context-protocol)을 통합하는 Rails 애플리케이션 템플릿입니다. 설정 중에 [Devise](https://github.com/heartcombo/devise)와 [Doorkeeper](https://github.com/doorkeeper-gem/doorkeeper)를 사용하여 OAuth 2.1 보호를 추가할지 여부를 묻습니다 — 하나의 템플릿으로 일반 MCP와 완전 인증 설정을 모두 지원합니다.

## 빠른 시작

```bash
git clone https://github.com/pstrzalk/mcp-on-rails.git
rails new myapp -m mcp-on-rails/mcp
cd myapp
rails db:migrate
rails server
```
템플릿은 다음과 같이 프롬프트합니다:


```
Add Devise + Doorkeeper OAuth 2.1 authentication? (y/n)
```

평범한 MCP 서버에는 **n**을, 완전한 OAuth 보호에는 **y**를 입력하세요.

### 기존 Rails 애플리케이션에 MCP 템플릿 추가하기

이 템플릿을 기존 Rails 앱에도 쉽게 적용할 수 있습니다.

```bash
git clone https://github.com/pstrzalk/mcp-on-rails.git
cd your-project/
rails app:template LOCATION=../mcp-on-rails/mcp
```

---

## 일반 MCP (응답 "n")

인증 없이 열린 MCP 서버가 포함된 Rails 앱을 생성합니다.

### 제공 내용

- Gemfile에 **`mcp` gem** 추가
- `/mcp`의 **`McpController`** — `ActionController::API`를 상속하며 MCP 프로토콜 처리
- **MCP 경로** — `POST /mcp`, `GET /mcp`
- **스캐폴드 훅** — `rails generate scaffold`가 자동으로 MCP 도구 생성
- **사용자 정의 도구 생성기** — `rails generate mcp_tool ToolName field:type`
- **사용자 정의 프롬프트 생성기** — `rails generate mcp_prompt PromptName arg arg:required`
- 일관된 텍스트 포맷을 위한 ApplicationRecord의 **`to_mcp_response`**
- 등록된 모든 도구와 프롬프트를 나열하는 **`rake mcp:tools`** 및 **`rake mcp:prompts`** (전체 세부 정보는 `mcp:tools:verbose` / `mcp:prompts:verbose` 사용)

### 사용법

```bash
rails new myapp -m mcp-on-rails/mcp   # answer n
cd myapp && rails db:migrate

rails generate scaffold Post title:string body:text
rails db:migrate
rails server
```
테스트해보세요:


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

### 프로젝트 구조 (일반 모드)

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

### AI 어시스턴트 연결하기 (일반 모드)

```json
{
  "name": "my-rails-app",
  "type": "StreamableHttp",
  "url": "http://localhost:3000/mcp"
}
```
인증 불필요 — `/mcp` 엔드포인트는 열려 있습니다.

---

## OAuth MCP (답변 "y")

PKCE, 동적 클라이언트 등록, 리소스 인디케이터 지원을 포함한 OAuth 2.1로 보호되는 MCP 서버가 포함된 Rails 앱을 생성합니다 — MCP의 OAuth 인증 흐름에 필요한 모든 기능을 제공합니다.

### 제공 내용

플레인 모드의 모든 기능에 더해:

- Gemfile에 **`devise` + `doorkeeper` 젬** 추가
- **Devise** 사용자 인증 (회원가입, 로그인, 비밀번호 재설정)
- PKCE 강제 적용(S256)의 **Doorkeeper** OAuth 2.1 제공자
- 토큰 대상 검증(RFC 8707)이 적용된 `doorkeeper_authorize!`로 보호되는 **`McpController`**
- `POST /oauth/register`에서의 **동적 클라이언트 등록** (RFC 7591)
- `GET /.well-known/oauth-protected-resource`에서의 **보호된 리소스 메타데이터** (RFC 9728)
- `GET /.well-known/oauth-authorization-server`에서의 **권한 서버 메타데이터** (RFC 8414)
- **리소스 인디케이터** — 토큰이 `/mcp` 리소스 범위로 제한됨 (RFC 8707)

### 사용법


```bash
rails new myapp -m mcp-on-rails/mcp   # answer y
cd myapp && rails db:migrate

rails generate scaffold Post title:string body:text
rails db:migrate
rails server
```
`/mcp` 엔드포인트는 이제 Bearer 토큰이 필요합니다 — 인증되지 않은 요청은 401을 반환합니다.

### OAuth 흐름

전체 권한 부여 흐름은 MCP의 OAuth 사양을 따릅니다:

1. **발견** — 클라이언트가 `GET /.well-known/oauth-protected-resource`를 호출하여 인증 서버를 찾습니다
2. **서버 메타데이터** — 클라이언트가 `GET /.well-known/oauth-authorization-server`를 호출하여 엔드포인트와 기능을 확인합니다
3. **클라이언트 등록** — 클라이언트 메타데이터와 함께 `POST /oauth/register` 호출 (RFC 7591)
4. **권한 부여** — PKCE `code_challenge` (S256) 및 `resource` 파라미터와 함께 `GET /oauth/authorize` 호출
5. **사용자 인증** — Devise가 로그인/회원가입을 처리합니다
6. **토큰 교환** — `code_verifier` 및 `resource` 파라미터와 함께 `POST /oauth/token` 호출
7. **MCP 요청** — `Authorization: Bearer <token>` 헤더와 함께 `POST /mcp` 호출

### 지원하는 RFC

| RFC | 설명 | 엔드포인트 |
|-----|-------------|----------|
| OAuth 2.1 + PKCE | 코드 교환 증명 키를 통한 권한 부여 (S256) | `/oauth/authorize`, `/oauth/token` |
| RFC 7591 | 동적 클라이언트 등록 | `POST /oauth/register` |
| RFC 8414 | 인증 서버 메타데이터 | `GET /.well-known/oauth-authorization-server` |
| RFC 8707 | 리소스 지시자 | 인증 및 토큰 요청의 `resource` 파라미터 |
| RFC 9728 | 보호된 리소스 메타데이터 | `GET /.well-known/oauth-protected-resource` |

### 프로젝트 구조 (OAuth 모드)


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

### AI 어시스턴트 연결하기 (OAuth 모드)

```json
{
  "name": "my-rails-app",
  "type": "StreamableHttp",
  "url": "http://localhost:3000/mcp"
}
```
클라이언트는 MCP 요청을 하기 전에 OAuth PKCE 흐름을 완료해야 합니다 — 유효한 Bearer 토큰이 없으면 `/mcp` 엔드포인트가 401을 반환합니다.

---

## 공통 기능 (양 모드 모두)

### MCP 도구를 사용한 스캐폴딩 모델 생성


```bash
rails generate scaffold Post title:string content:text
rails db:migrate
```
이것은 표준 Rails 파일과 함께 `app/tools/posts/`에 5개의 MCP 도구를 생성합니다:  
- `show_tool.rb` — ID로 단일 게시물 조회  
- `index_tool.rb` — 페이징된 게시물 목록 조회  
- `create_tool.rb` — 새 게시물 생성  
- `update_tool.rb` — 기존 게시물 수정  
- `delete_tool.rb` — 게시물 삭제  

### 사용자 정의 MCP 도구 생성  


```bash
rails generate mcp_tool WeatherCheck location:string
```

### 맞춤형 MCP 프롬프트 생성하기

```bash
rails generate mcp_prompt hotel_finder location:required check_in_date:required adults price_max
```

이는 `MCP::Prompt`를 상속하는 프롬프트 클래스를 포함하는 `app/prompts/hotel_finder.rb`를 생성합니다. 인수는 기본적으로 선택 사항이며, 필수로 만들려면 `:required`를 덧붙이세요.

프롬프트는 `app/prompts/`에서 자동으로 로드되며 MCP 서버에 등록됩니다. 도구와 달리 프롬프트는 스캐폴딩 시 자동 생성되지 않으며, 생성기를 통해 명시적으로 생성됩니다.

### 사용 가능한 도구 및 프롬프트 목록 보기

```bash
rake mcp:tools             # compact one-line-per-tool summary
rake mcp:tools:verbose     # full details with schema
rake mcp:prompts           # compact one-line-per-prompt summary
rake mcp:prompts:verbose   # full details with arguments
```

## 라이선스

MIT 라이선스


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-17

---