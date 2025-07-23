
# Claude Code Python SDK

Claude CodeのPython SDK。詳細は[Claude Code SDKドキュメント](https://docs.anthropic.com/en/docs/claude-code/sdk)をご覧ください。

## インストール


```bash
pip install claude-code-sdk
```


**前提条件:**
- Python 3.10以上
- Node.js 
- Claude Code: `npm install -g @anthropic-ai/claude-code`

## クイックスタート


```python
import anyio
from claude_code_sdk import query

async def main():
    async for message in query(prompt="What is 2 + 2?"):
        print(message)

anyio.run(main)
```
## 使用方法

### 基本クエリ


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
### ツールの使用方法


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
### 作業ディレクトリ


```python
from pathlib import Path

options = ClaudeCodeOptions(
    cwd="/path/to/project"  # or Path("/path/to/project")
)
```
## API リファレンス

### `query(prompt, options=None)`

Claude にクエリを送るためのメインの非同期関数。

**パラメータ:**
- `prompt` (str): Claude に送信するプロンプト
- `options` (ClaudeCodeOptions): オプションの設定

**戻り値:** AsyncIterator[Message] - 応答メッセージのストリーム

### タイプ

完全な型定義については [src/claude_code_sdk/types.py](https://raw.githubusercontent.com/anthropics/claude-code-sdk-python/main/src/claude_code_sdk/types.py) を参照してください:
- `ClaudeCodeOptions` - 設定オプション
- `AssistantMessage`, `UserMessage`, `SystemMessage`, `ResultMessage` - メッセージタイプ
- `TextBlock`, `ToolUseBlock`, `ToolResultBlock` - コンテンツブロック

## エラー処理


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


すべてのエラータイプについては、[src/claude_code_sdk/_errors.py](https://raw.githubusercontent.com/anthropics/claude-code-sdk-python/main/src/claude_code_sdk/_errors.py)を参照してください。

## 利用可能なツール

利用可能なツールの完全なリストについては、[Claude Codeドキュメント](https://docs.anthropic.com/en/docs/claude-code/settings#tools-available-to-claude)を参照してください。

## 例

完全な動作例については、[examples/quick_start.py](https://raw.githubusercontent.com/anthropics/claude-code-sdk-python/main/examples/quick_start.py)を参照してください。

## ライセンス

MIT



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---