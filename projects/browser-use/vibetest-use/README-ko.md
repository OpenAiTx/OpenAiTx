# Vibetest 사용법

브라우저-유즈 에이전트를 이용한 자동화 QA 테스트.

https://github.com/user-attachments/assets/9558d051-78bc-45fd-8694-9ac80eaf9494

여러 브라우저-유즈 에이전트를 실행하여 vibe-coded 웹사이트의 UI 버그, 깨진 링크, 접근성 문제 및 기타 기술적 문제를 테스트하는 MCP 서버.

라이브 웹사이트와 로컬호스트 개발 사이트 모두 테스트하기에 완벽함.

웹사이트가 제대로 작동할 때까지 Vibecode와 Vibetest를 사용하세요.

## 빠른 시작



```bash
# Install dependencies
uv venv
source .venv/bin/activate
uv pip install -e .
```
### 1) 클로드 코드


```bash
# Add MCP server via CLI
claude mcp add vibetest /full/path/to/vibetest-use/.venv/bin/vibetest-mcp -e GOOGLE_API_KEY="your_api_key"

# Test in Claude Code
> claude

> /mcp 
  ⎿  MCP Server Status

     • vibetest: connected
```
### 2) 커서 (수동)

1. **MCP 설정 UI를 통해 설치:**
   - 커서 설정 열기
   - 왼쪽 사이드바에서 "MCP" 클릭  
   - "서버 추가" 또는 "+" 버튼 클릭
   - 수동으로 구성 편집:


```json
{
  "mcpServers": {
    "vibetest": {
      "command": "/full/path/to/vibetest-use/.venv/bin/vibetest-mcp",
      "env": {
        "GOOGLE_API_KEY": "your_api_key"
      }
    }
  }
}

```


### 기본 프롬프트

```
> Vibetest my website with 5 agents: browser-use.com
> Run vibetest on localhost:3000
> Run a headless vibetest on localhost:8080 with 10 agents
```
### 지정할 수 있는 매개변수
- **URL**: 모든 웹사이트 (`https://example.com`, `localhost:3000`, `http://dev.mysite.com`)
- **에이전트 수**: `3` (기본값), `5 에이전트`, `2 에이전트` - 에이전트가 많을수록 더 철저한 테스트
- **헤드리스 모드**: `비헤드리스` (기본값) 또는 `헤드리스`

## 요구 사항

- Python 3.11+
- Google API 키 ([받기](https://developers.google.com/maps/api-security-best-practices)) (gemini-2.0-flash 지원)
- MCP 지원이 있는 Cursor/Claude

## 전체 데모


https://github.com/user-attachments/assets/6450b5b7-10e5-4019-82a4-6d726dbfbe1f



## 라이선스

MIT

---

[Browser Use](https://github.com/browser-use/browser-use) 제공



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-19

---