# Claude Co-Commands Plugin

3개의 협업 명령어로 구성된 Claude Code용 플러그인으로, [Codex MCP 서버](https://github.com/openai/codex)를 사용하여 병렬 계획 생성, 계획 검증, 아이디어 브레인스토밍을 수행합니다.

## Commands

| Command | Description | When to Use |
|---------|-------------|-------------|
| `/co-brainstorm` | Codex와 아이디어를 교환 | 빠른 대안 아이디어, 비판, 관점을 원할 때 |
| `/co-plan` | Codex를 통한 병렬 계획 생성 | 계획 접근법에 대한 두 번째 의견을 원할 때 |
| `/co-validate` | 계획에 대한 수석 엔지니어 리뷰 받기 | 계획을 확정하기 전에 중요한 피드백을 원할 때 |

## Prerequisites

- [Node.js](https://nodejs.org/) (`npx` 사용용)
- [Claude Code](https://docs.anthropic.com/en/docs/claude-code)

## Installation

### Option 1: Plugin Marketplace (Recommended)

```bash
# Add the marketplace
/plugin marketplace add SnakeO/claude-co-commands

# Install the plugin
/plugin install co-commands@snakeo-co-commands
```

### 옵션 2: Git 클론

```bash
git clone https://github.com/SnakeO/claude-co-commands.git
# Copy skill folders to ~/.claude/skills/
cp -r claude-co-commands/plugins/co-commands/skills/* ~/.claude/skills/
```
### 옵션 3: 수동 복사

`plugins/co-commands/skills/` 내용을 `~/.claude/skills/`로 복사합니다.

## MCP 서버 설정 (필수)

이 명령어들은 Codex MCP 서버가 필요합니다.

### 옵션 A: CLI (권장)


```bash
claude mcp add validate-plans-and-brainstorm-ideas -- npx -y @openai/codex mcp-server
```
### 옵션 B: 수동

이 내용을 `~/.claude.json`의 `mcpServers` 객체에 추가하세요:


```json
"validate-plans-and-brainstorm-ideas": {
  "command": "npx",
  "args": ["-y", "@openai/codex", "mcp-server"]
}
```
이미 `mcpServers`에 항목이 있는 경우, 이를 추가 키로 병합하세요. 기존 서버를 덮어쓰지 마십시오.

### 확인

1. Claude Code를 재시작합니다 (`~/.claude.json`을 수동으로 편집한 경우).
2. `claude mcp list`를 실행하여 서버가 등록되었는지 확인합니다.
3. `/co-brainstorm test idea`로 테스트하고 MCP 호출이 실행되는지 확인합니다.

## 명령어 세부사항

### `/co-brainstorm`

Codex와의 인터랙티브 브레인스토밍 세션을 시작합니다. 주제나 질문을 인수로 전달하세요.


```
/co-brainstorm how should we structure the authentication system
```

Supports follow-up conversation to dig deeper into ideas.

### `/co-plan`

Generates an alternative plan in the background while you continue your own planning. Pass your task description as the argument.

```
/co-plan add user authentication with OAuth2 support
```
Codex 계획과 귀하의 계획을 비교하여 놓친 접근 방식, 더 간단한 대안 또는 간과된 경계 사례를 찾아보세요.

### `/co-validate`

귀하의 계획을 직원 엔지니어 스타일의 검토를 위해 Codex에 보냅니다. 계획 파일의 경로를 전달하세요.


```
/co-validate .claude/plans/my-plan.md
```
중대한 문제, 단순화 기회 및 대체 접근 방식을 반환합니다. 상호 토론을 지원합니다.

## 문제 해결

| 문제 | 해결책 |
|---------|----------|
| `npx: command not found` | npm/npx가 포함된 [Node.js](https://nodejs.org/)를 설치하세요 |
| 세션에서 MCP 도구를 찾을 수 없음 | `~/.claude.json`에서 서버 이름이 정확히 `validate-plans-and-brainstorm-ideas`인지 확인하세요 |
| `~/.claude.json`의 JSON 구문 오류 | JSON을 검증하세요(쉼표 및 중괄호 확인) |
| 설치 후 명령어가 나타나지 않음 | Claude Code를 재시작하고 스킬 폴더가 존재하는지 확인하세요 |

## 라이선스

MIT



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-03

---