# codex-as-mcp

[中文版](https://raw.githubusercontent.com/kky42/codex-as-mcp/main/./README.zh-CN.md)

`codex-as-mcp`는 MCP 클라이언트(Claude Code, Cursor 등)가 작업을 **Codex CLI**에 위임할 수 있게 해주는 작은 **모델 컨텍스트 프로토콜(Model Context Protocol, MCP)** 서버입니다.

서버의 현재 작업 디렉터리에서 Codex를 실행하는 두 가지 도구를 제공합니다:
- `spawn_agent(prompt: str)`
- `spawn_agents_parallel(agents: list[dict])`

내부적으로 각 에이전트는 다음과 같이 실행됩니다:
`codex exec --cd <server cwd> --skip-git-repo-check --dangerously-bypass-approvals-and-sandbox "<prompt>"`.

참고: `--dangerously-bypass-approvals-and-sandbox`는 샌드박스와 확인 프롬프트를 비활성화합니다. 이 서버는 신뢰하는 저장소에서만 사용하세요.

## Claude Code에서 사용하기

codex-as-mcp에는 두 가지 도구가 있습니다
![tools](https://raw.githubusercontent.com/kky42/codex-as-mcp/main/assets/tools.png)

프롬프트를 사용해 병렬로 codex 서브에이전트를 생성할 수 있습니다.
![alt text](https://raw.githubusercontent.com/kky42/codex-as-mcp/main/assets/claude.png)

다음은 두 가지 작업을 병렬로 위임하는 Codex 세션 예시입니다.
![Codex use case](https://raw.githubusercontent.com/kky42/codex-as-mcp/main/assets/codex.png)

## 빠른 시작

### 1. Codex CLI 설치

**Codex CLI >= 0.46.0 필요**

```bash
npm install -g @openai/codex@latest
codex login

# Verify installation
codex --version
```
Codex CLI가 비대화식으로 실행될 수 있도록 머신에서 설정되어 있는지 확인하세요 (공급자 + 자격 증명이 `~/.codex/config.toml`에 있거나, 해당 공급자가 참조하는 특정 환경 변수로 설정).

#### 예시: 서드파티 공급자 + `env_key`

서드파티 공급자를 사용하는 경우, Codex `config.toml`에 구성하고 `model_provider`를 해당 공급자로 지정하세요. 공급자가 `env_key`를 사용하는 경우, Codex CLI는 실행 시 해당 환경 변수가 존재해야 한다고 기대합니다.

예시:

```toml
model_provider = "custom_provider"

[model_providers.custom_provider]
name = "custom_provider"
base_url = "https://..."
wire_api = "responses"
env_key = "PROVIDER_API_KEY"
show_raw_agent_reasoning = true
```

`codex-as-mcp`를 사용할 때, MCP 서버 프로세스에 해당 환경 변수가 설정되어 있어야 하며, 이를 통해 생성된 `codex` 프로세스에 전달할 수 있습니다. 환경 변수 이름은 위의 `env_key` 값과 **정확히 일치해야 합니다** (여기서는: `PROVIDER_API_KEY`).

**옵션 A (권장): MCP 클라이언트 설정에서 환경 변수 설정 (지원되는 경우)**
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

**옵션 B: 서버 인자를 통해 환경 전달**
```bash
uvx codex-as-mcp@latest --env PROVIDER_API_KEY=KEY_VALUE
```

**옵션 C: Codex CLI (`codex mcp add`)를 통해 추가**
```bash
codex mcp add codex-subagent --env PROVIDER_API_KEY=KEY_VALUE -- uvx codex-as-mcp@latest
```

보안 참고: 명령줄 인수를 통해 비밀을 전달하는 것은 머신의 프로세스 목록에서 보일 수 있으므로 가능한 경우 옵션 A를 선호하십시오.

### 2. MCP 구성

`.mcp.json`에 다음을 추가하십시오:
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
또는 Claude Desktop 명령어를 사용하세요:

```bash
claude mcp add codex-subagent -- uvx codex-as-mcp@latest
```

Codex CLI를 직접 구성하는 경우(예: `~/.config/codex/config.toml`), 다음을 추가하세요:
```toml
[mcp_servers.subagents]
transport = "stdio"
command = "uvx"
args = ["codex-as-mcp@latest"]
# Increase if you see ~60s tool-call timeouts when running longer Codex tasks.
# tool_timeout_sec = 600
```

## 도구

- `spawn_agent(prompt: str)` – 서버의 작업 디렉토리를 사용하여 자율 Codex 하위 에이전트를 생성하고 에이전트의 최종 메시지를 반환합니다.
- `spawn_agents_parallel(agents: list[dict])` – 여러 Codex 하위 에이전트를 병렬로 생성합니다; 각 항목에는 `prompt` 키가 포함되어야 하며 결과에는 에이전트별로 `output` 또는 `error`가 포함됩니다.

## 문제 해결

### `spawn_agent`가 약 60초 후에 시간 초과됨

다음과 같은 오류가 발생하면:
```text
tool call failed for `subagents/spawn_agent`
timed out awaiting tools/call after 60s
deadline has elapsed
```

이는 일반적으로 클라이언트 측 MCP 도구 호출 타임아웃입니다. `spawn_agent`는 생성된 `codex exec` 프로세스가 종료될 때까지 반환되지 않으며, 이 과정은 60초 이상 걸릴 수 있습니다.

해결 방법: MCP 클라이언트에서 도구 호출 타임아웃을 늘리십시오.

#### Codex CLI

Codex 설정 파일(`~/.codex/config.toml` 또는 `~/.config/codex/config.toml`)에서 MCP 서버에 대한 `tool_timeout_sec` 값을 더 높게 설정하십시오:
```toml
[mcp_servers.subagents]
transport = "stdio"
command = "uvx"
args = ["codex-as-mcp@latest"]
tool_timeout_sec = 600
```

#### MCP 검사기 / `mcp dev`

MCP 검사기로 로컬에서 테스트하는 경우 요청 시간 제한을 늘리거나(`./test.sh` 실행, 이 스크립트가 이를 설정함):
```bash
export MCP_SERVER_REQUEST_TIMEOUT=300000
export MCP_REQUEST_TIMEOUT_RESET_ON_PROGRESS=true
export MCP_REQUEST_MAX_TOTAL_TIMEOUT=28800000
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-05

---