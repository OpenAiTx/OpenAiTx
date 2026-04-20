# 토탈 리콜

중요한 것은 기억하고 중요하지 않은 것은 잊어버리는 Claude Code용 메모리 시스템.

## 문제점

Claude Code는 세션 간에 모든 것을 잊어버립니다. 매번 새 대화를 시작할 때마다 기억상실증 환자와 이야기하는 것과 같습니다. 결국 자신을 반복하게 됩니다:

- "그 방법은 이미 시도해봤는데, 효과가 없었어."
- "인증 파일은 건드리지 마."
- "나는 스페이스보다 탭을 선호해."
- "고객 이름은 사라가 아니라 세라야."

이게 금방 지루해집니다.

## 토탈 리콜이 하는 일

세션 간에 이어지는 메모장을 Claude Code에게 제공합니다. 하지만 *까다로운* 메모장입니다. 모든 것이 저장되는 것은 아닙니다. 영구 저장되기 전에 간단한 테스트를 통과해야 합니다: **내일도 이 내용이 중요할까?**

몇 달 동안 유지할 선호 사항? 저장. 내린 결정과 그 이유? 저장. 5분 전에 실행한 테스트 사실? 저장하지 않음. 시스템은 스스로 깔끔하게 유지되어 Claude가 관련 없는 쓰레기 속에서 중요한 것을 찾아 헤매지 않도록 합니다.

## 작동 방식

네 개의 저장 공간이 있는 주방처럼 생각하세요:

**조리대** (`CLAUDE.local.md`): 매일 손이 가는 것들. 매 세션 자동으로 로드됩니다. 일부러 작게 유지하며, 대략 한 페이지 분량의 텍스트입니다.

**식료품 저장실** (`memory/registers/`): 카테고리별로 정리되어 있습니다. 선호 사항, 주요 결정, 프로젝트 세부사항, 함께 일하는 사람들. Claude는 특정한 것이 필요할 때 여기서 확인합니다.

**일간 노트북** (`memory/daily/`): 매일 타임스탬프가 찍힌 임시 메모. 모든 내용은 먼저 여기에 작성됩니다. 나중에 어떤 내용을 영구적으로 보관할지 결정합니다.

**저장 옷장** (`memory/archive/`): 완료되었거나 오래된 자료. 여전히 검색 가능하지만 자동으로는 로드되지 않습니다.

핵심 아이디어: **메모는 먼저 일간 노트북에 기록되고, 보관할 내용은 당신이 선택해 승격시킵니다.** Claude가 스스로 무엇을 영구 저장할지 결정하지 않습니다. 결정은 당신 몫입니다.

## 빠른 시작

### 플러그인으로 설치하기 (권장)

```
/plugin marketplace add davegoldblatt/recall-marketplace
/plugin install recall@recall-marketplace
```

### 독립 실행형 설치하기

```
git clone https://github.com/davegoldblatt/total-recall.git
cd total-recall
./install.sh /path/to/your/project
```
설치 후, Claude Code를 재시작하거나 `/hooks`를 실행하여 활성화하세요.

## 사용법

일상적인 사용 방법은 다음과 같습니다:

**Claude가 기억할 만한 것을 발견합니다.** 일일 노트북에 기록하고 알려줍니다. 별도로 할 일은 없습니다.

**Claude에게 무언가를 기억하게 하고 싶습니다.** 그냥 "이것을 기억해"라고 말하거나 쓰기 명령어를 사용하세요:


```
/recall-write Dave prefers concise error messages, no stack traces in prod
```

**하루가 끝날 때 (또는 언제든지).** 쌓인 내용을 검토하고 좋은 것을 홍보하세요:

```
/recall-promote
```

**지난주에 무언가를 찾아보세요.** 모든 것을 대상으로 검색:

```
/recall-search authentication decision
```
**당신이 Claude를 수정합니다.** 수정 사항은 매일 노트, 레지스터, 카운터에 한꺼번에 업데이트됩니다. 같은 실수는 다시 발생하지 않습니다.

### 모든 명령어

| 명령어 | 설명 |
|---|---|
| `/recall-init` | 메모리 폴더를 처음 설정합니다 |
| `/recall-write <note>` | 노트를 저장합니다 (보관할 가치가 있는지 확인하고, 위치를 제안함) |
| `/recall-log <note>` | 질문 없이 일일 노트에 빠르게 기록 |
| `/recall-search <query>` | 모든 것을 검색 |
| `/recall-promote` | 일일 노트를 검토하고, 보관할 노트를 레지스터로 이동 |
| `/recall-status` | 상태 점검. 모든 것이 잘 작동하나요? |
| `/recall-maintain` | 오래되거나 중복된 항목 정리 |
| `/recall-forget <query>` | 무효한 것으로 표시 |
| `/recall-context` | Claude가 현재 로드한 메모리를 보여줌 |

플러그인으로 설치된 경우, 명령어는 네임스페이스가 붙습니다: `/recall:recall-write` 대신 `/recall-write`.

## 작성 게이트

이것이 핵심 아이디어입니다. 영구 메모리로 승격되기 전에, 적어도 하나 이상의 검사를 통과해야 합니다:

1. **다음에 Claude의 행동 방식을 바꿀 것인가?** (선호, 경계, 패턴)
2. **누군가가 기대하는 약속인가?** (마감일, 결과물, 후속 조치)
3. **이유를 기억할 가치가 있는 결정인가?** (X를 선택한 이유)
4. **다시 등장할 안정적인 사실인가?** (내일 달라지지 않을 정보)
5. **명시적으로 "기억해둬"라고 말했는가?**

이 중 어느 것도 해당하지 않으면 일일 노트에 남아 결국 사라집니다. 메모리를 간결하게 유지합니다. 잡동사니 서랍 없음.

## 수정이 발생할 때

Claude가 잘못된 정보를 받았다고 하면, 단순히 "죄송합니다"라고 하고 넘어가지 않습니다. 일일 노트, 관련 레지스터, 카운터를 한 번에 업데이트합니다. 이전 정보는 대체됨으로 표시되며(삭제되지 않음), 무엇이 언제 변경되었는지 기록으로 남습니다.

## 자동으로 로드되는 것

매 세션마다 두 가지만 로드됩니다:

| 항목 | 위치 | 방법 |

|---|---|---|
| 규칙들 (작성 게이트, 수정 프로토콜) | `rules/total-recall.md` | Claude Code는 모든 규칙 파일을 자동으로 로드합니다 |
| 카운터 / 작업 메모리 | `CLAUDE.local.md` | Claude Code가 이를 자동으로 로드합니다 |

나머지는 필요에 따라 로드됩니다: 검색할 때, 관련 있을 때, 또는 세션 시작 시 훅을 통해서.

## 훅

두 가지 작업이 백그라운드에서 자동으로 일어납니다:

**세션이 시작될 때:** Claude는 미처리 항목과 최근 일일 노트의 요약을 받습니다. 이것이 "우리가 어디까지 했는지" 브리핑입니다.

**메모리가 압축되기 전에:** 타임스탬프가 일일 노트북에 기록되어 기록이 남습니다. 이 작업은 조용히 진행됩니다. Claude는 이것을 보지 못하며, 단지 회계용입니다.

두 훅 모두 안전하게 실패합니다. 문제가 발생해도 Claude Code 작동을 막지 않습니다.

훅은 경로를 해결하기 위해 `$CLAUDE_PROJECT_DIR` (독립형) 또는 `${CLAUDE_PLUGIN_ROOT}` (플러그인)를 사용합니다. 대화 기록을 파싱하지 않습니다. PreCompact 훅은 단지 일일 로그에 타임스탬프 마커만 씁니다. 대화 기록을 읽거나 파싱하지 않습니다.

## 아키텍처

기술적인 세부사항을 원하는 분들을 위해.

```
Conversation (ephemeral, compacted/discarded)
    |
    v  WRITE GATE: "Does this change future behavior?"
    |
Daily Log (memory/daily/YYYY-MM-DD.md)
    All writes land here first. Raw, timestamped.
    |
    v  PROMOTION: user-controlled via /recall-promote
    |
Registers (memory/registers/*.md)
    Structured claims with metadata (confidence, evidence, last_verified)
    |
    v  DISTILLATION: only what's essential for every session
    |
Working Memory (CLAUDE.local.md)
    ~1500 words. Auto-loaded. The persistent "personality."
    |
    v  EXPIRY
    |
Archive (memory/archive/)
    Searchable history. Never auto-loaded.
```
### 주요 메커니즘

**쓰기 게이트:** 노이즈를 걸러냅니다. 행동을 변화시키는 사실, 약속, 결정 및 명시적인 "이것을 기억해" 요청만 통과합니다.

**일일 로그 우선:** 모든 쓰기는 일일 로그에 기록됩니다. 레지스터로의 승격은 별도의 단계이며 사용자가 제어합니다. 이는 모델이 추론을 조기에 확정하는 것을 방지합니다.

**모순 프로토콜:** 절대 조용히 덮어쓰지 않습니다. 오래된 주장들은 날짜와 이유와 함께 `[대체됨]`으로 표시됩니다. 변경 패턴이 보존됩니다.

**수정 게이트:** 인간의 수정이 가장 높은 우선순위를 가집니다. 하나의 수정이 일일 로그 + 레지스터 + 작업 메모리에 쓰기를 트리거합니다.

### 파일 구조

**플러그인 형식** (`/plugin install`을 통해 설치됨):


```
total-recall/                     # Plugin root
├── .claude-plugin/
│   └── plugin.json               # Plugin manifest
├── skills/                       # Slash commands (namespaced)
│   ├── recall-write/SKILL.md
│   ├── recall-search/SKILL.md
│   └── ...
├── hooks/
│   ├── hooks.json                # Hook configuration
│   ├── session-start.sh
│   └── pre-compact.sh
├── rules/
│   └── total-recall.md           # Protocol (auto-loaded)
└── templates/                    # Scaffolding templates
    ├── SCHEMA.md
    ├── CLAUDE.local.md
    └── registers/
```

**독립 실행형 형식** (`install.sh`를 통해 설치됨):

```
your-project/
├── .claude/
│   ├── commands/recall-*.md      # Slash commands
│   ├── rules/total-recall.md     # Protocol (auto-loaded)
│   ├── hooks/*.sh                # Hook scripts
│   └── settings.local.json       # Hook configuration
├── memory/
│   ├── SCHEMA.md
│   ├── daily/YYYY-MM-DD.md
│   ├── registers/*.md
│   └── archive/
├── CLAUDE.md
└── CLAUDE.local.md               # Working memory (gitignored)
```
### 다른 메모리 도구와 비교

|  | Total Recall | 자동 수집 도구 |
|---|---|---|
| **저장되는 내용** | 쓰기 게이트를 통과한 것만 | 모든 것 |
| **기본 저장 위치** | 일일 로그 (나중에 승격) | 영구 저장소 |
| **문맥 비용** | 약 1500단어 작업 메모리 | 무한대로 증가 |
| **수정 사항** | 모든 계층에 즉시 전파 | 다양함 |
| **사용자 제어** | 승격이 명시적임 | 자동적임 |
| **구조** | 메타데이터가 있는 4계층 | 평면 또는 2계층 |

## 개인정보 보호

- 모든 것이 로컬에 있습니다. 네트워크 호출, 텔레메트리, 외부 서비스 없음.
- 모든 메모리는 직접 읽고 편집할 수 있는 일반 마크다운 파일입니다.
- `CLAUDE.local.md`는 기본적으로 gitignore 처리됩니다 (개인용).
- `memory/`는 기본적으로 gitignore 처리됩니다 (개인 노트 포함 가능).
- 훅은 대화 기록을 절대 읽지 않습니다.
- 정확히 무슨 일이 일어나는지 보려면: `hooks/*.sh`와 `memory/`를 확인하세요. 모두 일반 텍스트입니다.
- 제거하려면: `memory/`, `CLAUDE.local.md`, 그리고 `.claude/` 항목(또는 `/plugin uninstall recall`)을 삭제하세요.

## Superpowers와 함께 작동

[Superpowers](https://github.com/obra/superpowers)를 사용하는 경우 충돌이 없습니다. Superpowers는 Claude가 *어떻게* 작동하는지(방법론, TDD, 계획)를 처리합니다. Total Recall은 Claude가 *무엇을* 기억하는지를 처리합니다. 다른 역할, 같은 프로젝트.

## 라이선스

MIT



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-20

---