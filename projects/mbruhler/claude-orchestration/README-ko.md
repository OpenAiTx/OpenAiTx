# 🎭 Claude Code용 오케스트레이션 플러그인

> _Claude Code의 N8N과 같음_

### 프로젝트가 마음에 드시면, ⭐을 눌러주세요!<br/>

## **멀티 에이전트 워크플로우 오케스트레이션.** 자연어 또는 선언적 구문을 사용하여 AI 에이전트들을 연결해 복잡한 작업을 자동화하세요.

[![Claude Code](https://img.shields.io/badge/Claude%20Code-Compatible-blue)](https://claude.com/claude-code)
[![License](https://img.shields.io/badge/License-MIT-green.svg)](LICENSE)

---

## 설치

### 1. 플러그인 마켓플레이스 추가

먼저, Claude Code에 오케스트레이션 마켓플레이스를 추가하세요:

```bash
/plugin marketplace add mbruhler/claude-orchestration
```

### 2. 플러그인 설치

```bash
/plugin install orchestration@mbruhler
```

또는 대화형 메뉴를 사용하세요:

```bash
/plugin
```
그런 다음 **"플러그인 찾아보기"** → **orchestration** 검색 → **설치** 선택

### 3. 설치 확인

플러그인이 설치되었는지 확인:


```bash
/help
```
오케스트레이션 명령어로 `/orchestration:menu`, `/orchestration:init` 등을 볼 수 있습니다.

---

## 빠른 시작

### 0. 사용자 지정 에이전트 가져오기 (선택 사항)

```
/orchestration:init
```

사용자 지정 에이전트를 `~/.claude/agents/`에서 오케스트레이션 플러그인으로 가져옵니다.

**예시:**
```
/orchestration:init
→ Select agents to import
→ Agents become available as expert-code-implementer, etc. and the plugin can create workflows using them
```

### 1. 자연어
```
"Create a workflow that fetches 10 Reddit posts about startups,
analyzes competition, and shows a ratings table"
```
플러그인:
- ✅ 필요한 임시 스크립트 생성 (Python/Node.js)
- ✅ 클릭 가능한 질문으로 안내
- ✅ 최적화된 워크플로우 생성 및 실행
- ✅ 형식화된 결과 반환

### 2. 직접 구문

```flow
# Parallel bug investigation
[
  Explore:"Find related code":code ||
  general-purpose:"Check recent changes":changes ||
  general-purpose:"Search similar issues":similar
] ->
general-purpose:"Identify root cause from {code}, {changes}, {similar}":analysis ->
@review:"Approve fix?" ->
general-purpose:"Implement fix and run tests":fix ->
general-purpose:"Commit changes with detailed message"
```

### 3. 템플릿
```
"Use the TDD implementation template"
```

---

## 핵심 기능

### 흐름 제어
```flow
# Sequential
step1 -> step2 -> step3

# Parallel
[task1 || task2 || task3]

# Conditional
test -> (if passed)~> deploy
     -> (if failed)~> rollback
```

### 자동 온도 스크립트
다음 용도의 Python/Node.js 스크립트를 자동 생성합니다:
- 🌐 웹 스크래핑 (BeautifulSoup, Selenium)
- 📡 API (Reddit, Twitter, GitHub)
- 📊 데이터 처리 (pandas, NumPy)
- 🗄️ 데이터베이스 쿼리

### 수동 점검 지점
```flow
build:"Compile app" ->
@review:"Check output. Continue?" ->
deploy:"Deploy to production"
```

### 시각적 진행 상황
```
╔════════════════════════════════════╗
║  TDD Implementation                ║
╠════════════════════════════════════╣
║    [Write Test] ●                  ║
║         │                          ║
║    [Implement] ○                   ║
║         │                          ║
║    [@Review] ○                     ║
╠════════════════════════════════════╣
║ Status: Writing test...            ║
╚════════════════════════════════════╝
```

---

## 문법 참조

| 문법 | 의미 | 예제 |
|--------|---------|---------|
| `->` | 순차적 | `step1 -> step2` |
| `||` | 병렬 | `[step1 \|\| step2]` |
| `~>` | 조건부 | `(if passed)~> next` |
| `@label` | 체크포인트 | `@review-code` |
| `:var` | 출력 캡처 | `analyze:"task":result` |
| `{var}` | 변수 사용 | `"Process {result}"` |
| `$agent` | 임시 에이전트 | `$scanner:"Scan"` |

---

## 내장 에이전트

- **Explore** - 빠른 코드베이스 탐색 및 검색
- **Plan** - 계획 수립 및 작업 분해
- **general-purpose** - 복잡한 다단계 작업을 위한 다목적 에이전트

---

## 예제

### Reddit 스타트업 분석기
```flow
general-purpose:"Create Python PRAW script to fetch 10 r/startups posts.
                 Return JSON with title, url, description":posts ->

[
  general-purpose:"Research competition for post {posts[0]}":a1 ||
  general-purpose:"Research competition for post {posts[1]}":a2 ||
  # ... parallel analyses
] ->

general-purpose:"Rate ideas (1-10) on competition, market, feasibility.
                 Create markdown table":ratings ->

@review:"Review {ratings}. Ban any?" ->

general-purpose:"Generate top 3 opportunities summary"
```

### TDD 구현
```flow
# RED: Write failing test
general-purpose:"Write failing test for the feature":test ->
general-purpose:"Run test suite - verify it fails":red_result ->
@review-coverage:"Test coverage sufficient?" ->

# GREEN: Minimal implementation
general-purpose:"Write minimal code to pass the test":impl ->
general-purpose:"Run test suite - verify it passes":green_result ->
@review:"Code quality OK?" ->

# REFACTOR: Clean up
general-purpose:"Refactor code and add documentation":refactored ->
general-purpose:"Final test run and commit"
```

### 버그 조사
```flow
# Parallel investigation
[
  Explore:"Find error pattern in codebase":code ||
  general-purpose:"Analyze error logs":logs ||
  general-purpose:"Check recent commits":commits ||
  general-purpose:"Search for similar bugs":known
] ->

# Diagnosis
general-purpose:"Identify root cause from {code}, {logs}, {commits}, {known}":cause ->
@review:"Diagnosis correct?" ->

# Fix with testing
general-purpose:"Write regression test for the bug":test ->
general-purpose:"Implement fix":fix ->

# Verification
[
  general-purpose:"Run regression test" ||
  general-purpose:"Run full test suite" ||
  general-purpose:"Perform smoke test"
] ->

@review:"Approve deployment?" ->
general-purpose:"Commit with detailed bug fix message"
```

---

## Project Structure

```
orchestration/
├── skills/              # Auto-activating skills
│   ├── creating-workflows/
│   ├── executing-workflows/
│   ├── managing-agents/
│   ├── managing-temp-scripts/
│   ├── designing-syntax/
│   ├── debugging-workflows/
│   └── using-templates/
├── agents/              # Permanent agents
├── temp-agents/         # Ephemeral (auto-cleaned)
├── temp-scripts/        # Generated scripts
├── examples/            # Templates (.flow)
└── docs/                # Documentation
```

---

## 고급

### 독립 실행
```bash
# Headless (no checkpoints)
claude -p "Execute @examples/tdd-implementation.flow"

# With parameters
claude -p "/orchestration:run $(cat workflow.flow)" \
  --output-format json
```

### 에이전트 프로모션
```
Workflow complete!

Temp agents: security-scanner, api-wrapper

Save as permanent?
[Save all] [Save security-scanner] [Delete all]
```

### 템플릿 매개변수
```yaml
---
name: api-integration
parameters:
  - API_URL: "https://api.example.com"
  - NUM_ITEMS: 10
---

workflow: |
  general-purpose:"Fetch {{NUM_ITEMS}} from {{API_URL}}":data ->
  general-purpose:"Format results":output
```

---

## 문제 해결

**워크플로우 중단**
→ 체크포인트가 사용자 응답을 요구하거나 무인 모드에서는 제거 필요

**임시 스크립트 실패**
→ 생성된 파일은 `temp-scripts/` 확인
→ API 자격 증명 및 종속성 확인

**에이전트가 발견되지 않음**
→ 내장: 정확한 이름 사용 (Explore, 범용)
→ 플러그인: `orchestration:` 접두사 사용
→ 임시: `$` 접두사 사용

## 스타 히스토리

[![Star History Chart](https://api.star-history.com/svg?repos=mbruhler/claude-orchestration&type=date&legend=top-left)](https://www.star-history.com/#mbruhler/claude-orchestration&type=date&legend=top-left)

---

## 지원

- 📖 [문서](docs/)
- 💬 [토론](https://github.com/anthropics/orchestration/discussions)
- 🐛 [이슈](https://github.com/anthropics/orchestration/issues)

---

**MIT 라이선스** | Claude Code 커뮤니티를 위해 제작됨


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-04

---