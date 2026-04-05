# codex-as-mcp

[中文版](https://raw.githubusercontent.com/kky42/codex-as-mcp/main/./README.zh-CN.md)

`codex-as-mcp` 是一个小型的 **模型上下文协议（MCP）** 服务器，允许 MCP 客户端（Claude Code、Cursor 等）将工作委托给 **Codex CLI**。

它暴露了两个在服务器当前工作目录运行 Codex 的工具：
- `spawn_agent(prompt: str)`
- `spawn_agents_parallel(agents: list[dict])`

在底层，每个代理都会运行类似以下命令：
`codex exec --cd <server cwd> --skip-git-repo-check --dangerously-bypass-approvals-and-sandbox "<prompt>"`。

注意：`--dangerously-bypass-approvals-and-sandbox` 会禁用沙箱和确认提示。请仅在您信任的仓库中使用此服务器。

## 在 Claude Code 中使用

codex-as-mcp 中有两个工具
![tools](https://raw.githubusercontent.com/kky42/codex-as-mcp/main/assets/tools.png)

您可以使用提示并行生成多个 codex 子代理。
![alt text](https://raw.githubusercontent.com/kky42/codex-as-mcp/main/assets/claude.png)

这是一个示例 Codex 会话，演示如何并行委托两个任务。
![Codex use case](https://raw.githubusercontent.com/kky42/codex-as-mcp/main/assets/codex.png)

## 快速开始

### 1. 安装 Codex CLI

**需要 Codex CLI 版本 >= 0.46.0**

```bash
npm install -g @openai/codex@latest
codex login

# Verify installation
codex --version
```
确保 Codex CLI 可以在您的机器上非交互式运行（提供者 + 凭据位于 `~/.codex/config.toml`，或通过其引用的提供者特定环境变量）。

#### 示例：第三方提供者 + `env_key`

如果您使用第三方提供者，请在 Codex `config.toml` 中进行配置，并将 `model_provider` 指向它。当提供者使用 `env_key` 时，Codex CLI 运行时会期望该环境变量存在。

示例：

```toml
model_provider = "custom_provider"

[model_providers.custom_provider]
name = "custom_provider"
base_url = "https://..."
wire_api = "responses"
env_key = "PROVIDER_API_KEY"
show_raw_agent_reasoning = true
```
使用 `codex-as-mcp` 时，确保 MCP 服务器进程已设置该环境变量，以便它可以传递给生成的 `codex` 进程。环境变量名称**必须与**上面的 `env_key` 值匹配（此处为：`PROVIDER_API_KEY`）。

**选项 A（推荐）：在您的 MCP 客户端配置中设置环境变量（如果支持）**

```json
{
  "mcpServers": {
    "codex-subagent": {
      "type": "stdio",
      "command": "uvx",
      "args": ["codex-as-mcp@latest"],
      "env": {
        "PROVIDER_API_KEY": "KEY_VALUE"
      }
    }
  }
}
```

**选项 B：通过服务器参数传递环境变量**
```bash
uvx codex-as-mcp@latest --env PROVIDER_API_KEY=KEY_VALUE
```

**选项 C：通过 Codex CLI 添加（`codex mcp add`）**
```bash
codex mcp add codex-subagent --env PROVIDER_API_KEY=KEY_VALUE -- uvx codex-as-mcp@latest
```
安全提示：通过命令行参数传递机密信息可能会在您的机器的进程列表中可见；尽可能优先选择选项A。

### 2. 配置 MCP

添加到您的 `.mcp.json`：

```json
{
  "mcpServers": {
    "codex-subagent": {
      "type": "stdio",
      "command": "uvx",
      "args": ["codex-as-mcp@latest"]
    }
  }
}
```
或者使用 Claude 桌面命令：

```bash
claude mcp add codex-subagent -- uvx codex-as-mcp@latest
```
如果您直接配置 Codex CLI（例如 `~/.config/codex/config.toml`），请添加：

```toml
[mcp_servers.subagents]
transport = "stdio"
command = "uvx"
args = ["codex-as-mcp@latest"]
# Increase if you see ~60s tool-call timeouts when running longer Codex tasks.
# tool_timeout_sec = 600
```

## 工具

- `spawn_agent(prompt: str)` – 使用服务器的工作目录生成一个自主 Codex 子代理，并返回该代理的最终消息。
- `spawn_agents_parallel(agents: list[dict])` – 并行生成多个 Codex 子代理；每个条目必须包含一个 `prompt` 键，结果中每个代理包括 `output` 或 `error`。

## 故障排除

### `spawn_agent` 在约 60 秒后超时

如果您看到类似错误：
```text
tool call failed for `subagents/spawn_agent`
timed out awaiting tools/call after 60s
deadline has elapsed
```
这通常是客户端 MCP 工具调用超时。`spawn_agent` 在被调用的 `codex exec` 进程结束之前不会返回，这可能会超过 60 秒。

解决方法：增加 MCP 客户端中的工具调用超时。

#### Codex CLI

在你的 Codex 配置文件（`~/.codex/config.toml` 或 `~/.config/codex/config.toml`）中，为 MCP 服务器设置更高的 `tool_timeout_sec`：

```toml
[mcp_servers.subagents]
transport = "stdio"
command = "uvx"
args = ["codex-as-mcp@latest"]
tool_timeout_sec = 600
```

#### MCP 检查器 / `mcp dev`

如果您正在使用 MCP 检查器进行本地测试，请增加请求超时时间（或运行 `./test.sh`，它会导出这些设置）：
```bash
export MCP_SERVER_REQUEST_TIMEOUT=300000
export MCP_REQUEST_TIMEOUT_RESET_ON_PROGRESS=true
export MCP_REQUEST_MAX_TOTAL_TIMEOUT=28800000
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-05

---