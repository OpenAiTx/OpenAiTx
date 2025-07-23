
# Claude Code Python SDK

Claude Code용 Python SDK입니다. 자세한 내용은 [Claude Code SDK 문서](https://docs.anthropic.com/en/docs/claude-code/sdk)를 참조하세요.

## 설치


```bash
pip install claude-code-sdk
```


**필수 조건:**
- Python 3.10 이상
- Node.js 
- Claude 코드: `npm install -g @anthropic-ai/claude-code`

## 빠른 시작


```python
import anyio
from claude_code_sdk import query

async def main():
    async for message in query(prompt="What is 2 + 2?"):
        print(message)

anyio.run(main)
```


## 사용법

### 기본 쿼리


```python
from claude_code_sdk import query, ClaudeCodeOptions, AssistantMessage, TextBlock

# Simple query
async for message in query(prompt="Hello Claude"):
    if isinstance(message, AssistantMessage):
        for block in message.content:
            if isinstance(block, TextBlock):
                print(block.text)

# With options
options = ClaudeCodeOptions(
    system_prompt="You are a helpful assistant",
    max_turns=1
)

async for message in query(prompt="Tell me a joke", options=options):
    print(message)
```
### 도구 사용하기


```python
options = ClaudeCodeOptions(
    allowed_tools=["Read", "Write", "Bash"],
    permission_mode='acceptEdits'  # auto-accept file edits
)

async for message in query(
    prompt="Create a hello.py file", 
    options=options
):
    # Process tool use and results
    pass
```
### 작업 디렉터리


```python
from pathlib import Path

options = ClaudeCodeOptions(
    cwd="/path/to/project"  # or Path("/path/to/project")
)
```
## API 참조

### `query(prompt, options=None)`

Claude에 쿼리하는 주요 비동기 함수입니다.

**매개변수:**
- `prompt` (str): Claude에 보낼 프롬프트
- `options` (ClaudeCodeOptions): 선택적 구성

**반환:** AsyncIterator[Message] - 응답 메시지 스트림

### 타입

전체 타입 정의는 [src/claude_code_sdk/types.py](https://raw.githubusercontent.com/anthropics/claude-code-sdk-python/main/src/claude_code_sdk/types.py)에서 확인하십시오:
- `ClaudeCodeOptions` - 구성 옵션
- `AssistantMessage`, `UserMessage`, `SystemMessage`, `ResultMessage` - 메시지 타입
- `TextBlock`, `ToolUseBlock`, `ToolResultBlock` - 콘텐츠 블록

## 오류 처리


```python
from claude_code_sdk import (
    ClaudeSDKError,      # Base error
    CLINotFoundError,    # Claude Code not installed
    CLIConnectionError,  # Connection issues
    ProcessError,        # Process failed
    CLIJSONDecodeError,  # JSON parsing issues
)

try:
    async for message in query(prompt="Hello"):
        pass
except CLINotFoundError:
    print("Please install Claude Code")
except ProcessError as e:
    print(f"Process failed with exit code: {e.exit_code}")
except CLIJSONDecodeError as e:
    print(f"Failed to parse response: {e}")
```
<src/claude_code_sdk/_errors.py](https://raw.githubusercontent.com/anthropics/claude-code-sdk-python/main/src/claude_code_sdk/_errors.py)에서 모든 오류 유형을 확인하세요.

## 사용 가능한 도구

사용 가능한 도구의 전체 목록은 [Claude Code 문서](https://docs.anthropic.com/en/docs/claude-code/settings#tools-available-to-claude)를 참조하세요.

## 예제

전체 작동 예제는 [examples/quick_start.py](https://raw.githubusercontent.com/anthropics/claude-code-sdk-python/main/examples/quick_start.py)를 참조하세요.

## 라이선스

MIT



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---