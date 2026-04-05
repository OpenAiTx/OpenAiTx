# codex-as-mcp

[中文版](https://raw.githubusercontent.com/kky42/codex-as-mcp/main/./README.zh-CN.md)

`codex-as-mcp` は、MCPクライアント（Claude Code、Cursorなど）が作業を**Codex CLI**に委任できる小さな**Model Context Protocol (MCP)**サーバーです。

サーバーの現在の作業ディレクトリでCodexを実行する2つのツールを公開しています：
- `spawn_agent(prompt: str)`
- `spawn_agents_parallel(agents: list[dict])`

内部的には、各エージェントは次のようなコマンドを実行します：
`codex exec --cd <server cwd> --skip-git-repo-check --dangerously-bypass-approvals-and-sandbox "<prompt>"`。

注意：`--dangerously-bypass-approvals-and-sandbox` はサンドボックスと確認プロンプトを無効にします。信頼できるリポジトリでのみこのサーバーを使用してください。

## Claude Codeでの使用

codex-as-mcpには2つのツールがあります
![tools](https://raw.githubusercontent.com/kky42/codex-as-mcp/main/assets/tools.png)

プロンプトを使って並列でCodexサブエージェントを起動できます。
![alt text](https://raw.githubusercontent.com/kky42/codex-as-mcp/main/assets/claude.png)

以下は2つのタスクを並列で委任するCodexセッションのサンプルです。
![Codex use case](https://raw.githubusercontent.com/kky42/codex-as-mcp/main/assets/codex.png)

## クイックスタート

### 1. Codex CLIのインストール

**Codex CLI >= 0.46.0 が必要です**

```bash
npm install -g @openai/codex@latest
codex login

# Verify installation
codex --version
```

Codex CLIがマシン上で対話なしに実行できることを確認してください（プロバイダー＋認証情報は`~/.codex/config.toml`に、または参照されているプロバイダー固有の環境変数を通じて）。

#### 例：サードパーティプロバイダー＋`env_key`

サードパーティプロバイダーを使用している場合は、Codexの`config.toml`に設定し、`model_provider`をそれに向けてください。プロバイダーが`env_key`を使用する場合、Codex CLIは実行時にその環境変数が存在することを期待します。

例：
```toml
model_provider = "custom_provider"

[model_providers.custom_provider]
name = "custom_provider"
base_url = "https://..."
wire_api = "responses"
env_key = "PROVIDER_API_KEY"
show_raw_agent_reasoning = true
```
`codex-as-mcp` を使用する場合、MCP サーバープロセスにその環境変数が設定されていることを確認してください。これにより、生成された `codex` プロセスに環境変数を渡すことができます。環境変数名は上記の `env_key` の値と**完全に一致する必要があります**（ここでは `PROVIDER_API_KEY`）。

**オプションA（推奨）：MCPクライアントの設定で環境変数を設定する（対応している場合）**

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

**オプションB: サーバー引数を介して環境変数を渡す**
```bash
uvx codex-as-mcp@latest --env PROVIDER_API_KEY=KEY_VALUE
```

**オプションC: Codex CLI（`codex mcp add`）を使用して追加**
```bash
codex mcp add codex-subagent --env PROVIDER_API_KEY=KEY_VALUE -- uvx codex-as-mcp@latest
```

セキュリティ注意: コマンドライン引数で秘密情報を渡すと、マシンのプロセスリストから見える可能性があります。可能な場合はオプションAを推奨します。

### 2. MCPの設定

`.mcp.json` に以下を追加してください:
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
またはClaude Desktopコマンドを使用してください：

```bash
claude mcp add codex-subagent -- uvx codex-as-mcp@latest
```

もしCodex CLIを直接設定している場合（例：`~/.config/codex/config.toml`）、以下を追加してください：
```toml
[mcp_servers.subagents]
transport = "stdio"
command = "uvx"
args = ["codex-as-mcp@latest"]
# Increase if you see ~60s tool-call timeouts when running longer Codex tasks.
# tool_timeout_sec = 600
```

## ツール

- `spawn_agent(prompt: str)` – サーバーの作業ディレクトリを使用して自律的なCodexサブエージェントを起動し、エージェントの最終メッセージを返します。
- `spawn_agents_parallel(agents: list[dict])` – 複数のCodexサブエージェントを並行して起動します。各項目には`prompt`キーが含まれている必要があり、結果にはエージェントごとに`output`または`error`が含まれます。

## トラブルシューティング

### `spawn_agent`が約60秒でタイムアウトする

次のようなエラーが表示される場合：
```text
tool call failed for `subagents/spawn_agent`
timed out awaiting tools/call after 60s
deadline has elapsed
```

これは通常、クライアント側のMCPツールコールタイムアウトです。`spawn_agent`は生成された`codex exec`プロセスが終了するまで戻らず、これは60秒以上かかることがあります。

修正：MCPクライアントのツールコールタイムアウトを増やしてください。

#### Codex CLI

Codexの設定ファイル（`~/.codex/config.toml`または`~/.config/codex/config.toml`）で、MCPサーバーの`tool_timeout_sec`をより大きな値に設定してください：
```toml
[mcp_servers.subagents]
transport = "stdio"
command = "uvx"
args = ["codex-as-mcp@latest"]
tool_timeout_sec = 600
```

#### MCPインスペクター / `mcp dev`

ローカルでMCPインスペクターを使ってテストする場合は、リクエストのタイムアウトを延長するか（またはこれらをエクスポートする`./test.sh`を実行してください）：
```bash
export MCP_SERVER_REQUEST_TIMEOUT=300000
export MCP_REQUEST_TIMEOUT_RESET_ON_PROGRESS=true
export MCP_REQUEST_MAX_TOTAL_TIMEOUT=28800000
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-05

---