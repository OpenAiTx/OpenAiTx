# claude.sh

Claude 코드를 bash 스크립트로 재작성. 약 1,500줄. npm 패키지 없음.

## 이유

원래 Claude 코드는 약 380,000줄의 TypeScript와 266개의 npm 의존성을 가집니다. 이것은 `curl`과 `jq`만으로 bash에서 동일한 핵심 작업을 수행합니다.

## 기능

- **실시간 스트리밍** FIFO 파이프를 통해 — Claude가 생성하는 텍스트가 바로 나타납니다
- **6가지 도구**: Bash, Read, Edit, Write, Glob, Grep
- **도구 체이닝** — 한 턴에 최대 25개의 도구 호출 가능
- **권한 요청** — 안전하지 않은 명령 실행 전에 확인 요청 (`y/n/a`)
- **CLAUDE.md 로딩** — 상위 디렉토리 트리의 CLAUDE.md 파일에서 프로젝트 지침 읽기
- **Git 인식 컨텍스트** — 시스템 프롬프트에 브랜치, 상태, 최근 커밋 표시
- **세션 저장/재개** — 종료 시 자동 저장, `--resume <id>`로 재개 가능
- **백오프를 이용한 재시도** — 429/529 속도 제한 시 지수적 재시도
- **비용 추적** — 턴별 및 세션 총합
- **스피너** — 원래 스피너 동사 사용 (Clauding, Flibbertigibbeting 등)
- **슬래시 명령어** — `/help`, `/cost`, `/model`, `/clear`, `/save`, `/resume`, `/commit`, `/diff`
- **파이프 모드** — `echo "explain this" | ./claude.sh`

## 설치

```bash
git clone https://github.com/jdcodes1/claude.sh.git
cd claude.sh
chmod +x claude.sh
```
## 종속성

- `curl`
- `jq`
- 선택 사항: 더 나은 검색을 위한 `rg` (ripgrep)
- 선택 사항: 편집 도구용 `python3`

런타임 버전은 `.tool-versions`에 고정되어 있습니다. [mise](https://mise.jdx.dev/)로 설치하세요:


```bash
mise install
```

## 사용법

```bash
export ANTHROPIC_API_KEY="sk-ant-..."
./claude.sh
```
### 환경 변수

| 변수 | 기본값 | 설명 |
| --- | --- | --- |
| `ANTHROPIC_API_KEY` | (필수) | 당신의 Anthropic API 키 |
| `CLAUDE_MODEL` | `claude-sonnet-4-6` | 사용할 모델 |
| `CLAUDE_MAX_TOKENS` | `8192` | 최대 출력 토큰 수 |
| `ANTHROPIC_API_URL` | `https://api.anthropic.com` | API 기본 URL |
| `CLAUDE_SH_PERMISSIONS` | `ask` | 권한 모드: `ask`, `allow`, 또는 `deny` |

### 명령어


```txt
/help      — Show help
/cost      — Show session cost
/model     — Show/change model
/clear     — Clear conversation
/save      — Save current session
/resume    — List/resume saved sessions
/commit    — Auto-generate a git commit
/diff      — Show git diff
/quit      — Exit
```

### 세션 다시 시작하기

```bash
# List saved sessions
./claude.sh
> /resume

# Resume by number
> /resume 1

# Resume from CLI
./claude.sh --resume 20240101-120000-12345
```

## 아키텍처

```txt
claude.sh          # Main REPL loop, slash commands, process_turn()
lib/
  api.sh           # Anthropic API client, SSE streaming via FIFO, retry
  json.sh          # Message construction, session persistence, CLAUDE.md, git context
  tools.sh         # 6 tool implementations + permission system
  tui.sh           # ANSI colors, spinner, display helpers
```
## 작동 원리

1. 사용자 입력 읽기
2. `jq`로 JSON 요청 구성 (메시지, 도구, 시스템 프롬프트)
3. FIFO 파이프를 통해 `curl`로 응답 스트리밍
4. SSE 이벤트를 한 줄씩 파싱하여 텍스트 델타를 실시간 출력
5. tool_use 블록이 도착하면 도구 실행
6. 도구 결과를 메시지로 다시 전달
7. Claude가 도구 호출을 중단할 때까지 반복

## 비교

| | claude.sh | Claude 코드 (TypeScript) |
| --- | --- | --- |
| 코드 줄 수 | 약 1,500 | 약 380,000 |
| 의존성 | curl, jq | 266 npm 패키지 |
| 바이너리 크기 | 0 (스크립트) | 약 200MB node_modules |
| 시작 시간 | 즉시 | 약 500ms |

### 테스트

테스트는 [bats](https://github.com/bats-core/bats-core) (Bash 자동화 테스트 시스템)를 사용합니다:


```bash
bats test/
```

## License

[MIT](LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-04

---