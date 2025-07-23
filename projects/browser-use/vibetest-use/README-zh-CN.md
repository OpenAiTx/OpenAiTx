
# Vibetest 使用

使用 Browser-Use 代理进行自动化 QA 测试。

https://github.com/user-attachments/assets/9558d051-78bc-45fd-8694-9ac80eaf9494

一个 MCP 服务器，启动多个 Browser-Use 代理来测试一个 vibe 编码的网站的 UI 错误、断链、无障碍问题及其他技术问题。

非常适合测试线上网站和本地主机开发网站。

Vibecode 和 vibetest，直到你的网站正常运行。

## 快速开始




```bash
# Install dependencies
uv venv
source .venv/bin/activate
uv pip install -e .
```
### 1) 克洛德代码


```bash
# Add MCP server via CLI
claude mcp add vibetest /full/path/to/vibetest-use/.venv/bin/vibetest-mcp -e GOOGLE_API_KEY="your_api_key"

# Test in Claude Code
> claude

> /mcp 
  ⎿  MCP Server Status

     • vibetest: connected
```
### 2) 光标（手动）

1. **通过 MCP 设置界面安装：**
   - 打开光标设置
   - 点击左侧边栏中的 “MCP”  
   - 点击 “添加服务器” 或 “+” 按钮
   - 手动编辑配置：


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


### 基本提示

```
> Vibetest my website with 5 agents: browser-use.com
> Run vibetest on localhost:3000
> Run a headless vibetest on localhost:8080 with 10 agents
```
### 您可以指定的参数
- **URL**：任何网站（`https://example.com`，`localhost:3000`，`http://dev.mysite.com`）
- **代理数量**：`3`（默认），`5个代理`，`2个代理` - 代理越多，测试越彻底
- **无头模式**：`非无头`（默认）或 `无头`

## 需求

- Python 3.11+
- Google API 密钥（[获取密钥](https://developers.google.com/maps/api-security-best-practices)）（我们支持 gemini-2.0-flash）
- 支持 MCP 的 Cursor/Claude

## 完整演示


https://github.com/user-attachments/assets/6450b5b7-10e5-4019-82a4-6d726dbfbe1f



## 许可证

MIT

---

由 [Browser Use](https://github.com/browser-use/browser-use) 提供支持 



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-19

---