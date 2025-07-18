<translate-content># Claude Code Python SDK

Claude Code 的 Python SDK。有关更多信息，请参阅 [Claude Code SDK 文档](https://docs.anthropic.com/en/docs/claude-code/sdk)。

## 安装
</translate-content>
```bash
pip install claude-code-sdk
```
**先决条件：**
- Python 3.10+
- Node.js 
- Claude 代码：`npm install -g @anthropic-ai/claude-code`

## 快速开始


```python
import anyio
from claude_code_sdk import query

async def main():
    async for message in query(prompt="What is 2 + 2?"):
        print(message)

anyio.run(main)
```
## 用法

### 基本查询


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
### 使用工具


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
### 工作目录


```python
from pathlib import Path

options = ClaudeCodeOptions(
    cwd="/path/to/project"  # or Path("/path/to/project")
)
```
## API 参考

### `query(prompt, options=None)`

查询 Claude 的主要异步函数。

**参数：**
- `prompt` (str)：发送给 Claude 的提示
- `options` (ClaudeCodeOptions)：可选配置

**返回：** AsyncIterator[Message] - 响应消息流

### 类型

完整类型定义请参见 [src/claude_code_sdk/types.py](https://raw.githubusercontent.com/anthropics/claude-code-sdk-python/main/src/claude_code_sdk/types.py)：
- `ClaudeCodeOptions` - 配置选项
- `AssistantMessage`、`UserMessage`、`SystemMessage`、`ResultMessage` - 消息类型
- `TextBlock`、`ToolUseBlock`、`ToolResultBlock` - 内容块

## 错误处理


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
<translate-content>
有关所有错误类型，请参见 [src/claude_code_sdk/_errors.py](https://raw.githubusercontent.com/anthropics/claude-code-sdk-python/main/src/claude_code_sdk/_errors.py)。

## 可用工具

完整的可用工具列表请参见 [Claude Code 文档](https://docs.anthropic.com/en/docs/claude-code/settings#tools-available-to-claude)。

## 示例

完整的工作示例请参见 [examples/quick_start.py](https://raw.githubusercontent.com/anthropics/claude-code-sdk-python/main/examples/quick_start.py)。

## 许可证

MIT
</translate-content>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---