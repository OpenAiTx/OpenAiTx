# PM Claude 코드 설정

[![별점](https://img.shields.io/github/stars/aakashg/pm-claude-code-setup?style=flat-square)](https://github.com/aakashg/pm-claude-code-setup/stargazers)
[![라이선스](https://img.shields.io/github/license/aakashg/pm-claude-code-setup?style=flat-square)](LICENSE)

제품 관리자용 프로덕션 준비 완료 Claude Code 구성입니다. 이 파일들을 프로젝트에 넣으면 Claude Code가 즉시 PM 업무를 이해합니다.

`CLAUDE.md` 컨텍스트 파일, 6가지 PM 기술, 4가지 템플릿이 포함되어 있습니다. 설정하는 데 60초 걸립니다.

**이 설정은 독립 실행형으로 작동합니다. 전체 PM 운영 체제는 더 나아가 41개 이상의 기술, 7개의 하위 에이전트 관점, 완전한 컨텍스트 라이브러리, 출시 템플릿, 100회 이상의 반복으로 다듬어진 스프린트 계획 워크플로를 포함합니다.**

**[전체 PM 운영 체제 받기 →](https://www.news.aakashg.com/p/pm-os)**

---

## 내부 구성 요소

```
pm-claude-code-setup/
├── CLAUDE.md                           # Master context file — drop in your project root
├── templates/
│   ├── prd-template.md                 # Blank PRD structure
│   ├── launch-plan.md                  # Launch planning template
│   ├── okr-template.md                 # OKR scorecard
│   └── sprint-review.md               # Sprint review template
└── .claude/
    └── skills/
        ├── prd-writer/                 # "write a PRD" → structured PRD with clarifying questions
        ├── competitive-analysis/       # "analyze competitor" → smart/weak/implications framework
        ├── launch-checklist/           # "launch checklist" → risk-scaled pre/post launch plan
        ├── metrics-definer/            # "define metrics" → primary, guardrail, and anti-metrics
        ├── sprint-planner/             # "plan sprint" → capacity-checked sprint with risks
        └── user-research/              # "synthesize research" → evidence-ranked findings
```

## 빠른 설정

**1단계:** `CLAUDE.md`를 프로젝트 루트에 복사하세요:
```bash
cp CLAUDE.md /path/to/your/project/
```

**2단계:** skills 폴더를 복사하세요:
```bash
cp -r .claude/ /path/to/your/project/
```
**3단계:** 프로젝트에서 Claude Code를 엽니다. 자동으로 로드됩니다.

완료. Claude는 이제 당신이 PM임을 알고, 당신의 글쓰기 스타일을 따라가며, 명령에 따라 PRD를 작성합니다.

## CLAUDE.md가 하는 일

`CLAUDE.md`는 매뉴얼이 아닌 간결한 설정 파일입니다. Claude에게 당신이 누구인지, 어떻게 글을 써야 하는지, 어떤 규칙을 따라야 하는지를 알려줍니다. 상단의 `[FILL IN]` 필드를 (~2분 내에) 작성하면 나머지는 즉시 작동합니다:

- **당신의 컨텍스트** — 역할, 제품, 지표, OKR, 용어
- **글쓰기 규칙** — 강제 톤, 금지 단어, 출력 기준
- **서브 에이전트 역할** — 표에 6명의 리뷰어 (엔지니어, 디자이너, 임원, 회의론자, 고객, 데이터 분석가)
- **출력 기준** — 생성 전 명확화 질문, 기준선이 있는 지표, 완화책이 있는 위험
- **기술 참조** — `.claude/skills/`를 가리키며 로직 중복 방지
- **MCP 연결** — 통합 서비스 (Notion, Jira, Slack 등)

파일은 의도적으로 60줄 미만입니다. Claude는 긴 지시문보다 짧고 구체적인 지시를 더 잘 따릅니다.

## PRD 작성기 스킬이 하는 일

"PRD 작성" 또는 "[기능]에 대한 PRD 생성"이라고 말하면 Claude는:

1. 먼저 3-5개의 명확화 질문을 합니다 (무작정 생성하지 않음)
2. 구조화된 형식에 따릅니다: 가설, 문제, 해결책, 지표, 비목표
3. 누락된 정보는 `[NEED: X로부터 데이터]` 자리표시자로 표시
4. 요청하지 않는 한 2페이지 이내로 유지
5. 구체적인 숫자와 가드레일이 포함된 성공 지표 포함

## 이 설정을 최대한 활용하는 방법

### 서브 에이전트 체인 사용

PRD 작성 → "엔지니어로 리뷰" → 빈틈 보완 → "회의론자로 리뷰" → 가정 강화 → "고객으로 리뷰" → 가치 제안 단순화. 세 번의 검토, 3분, 훨씬 나은 명세서 완성.

### @ 참조 사용

문서를 채팅에 붙여넣지 말고 — 문서를 가리키세요:


```
Read @templates/prd-template.md and use that structure.
Summarize @meeting-notes/standup-03-04.md into action items.
Compare @competitor-notes/notion.md against @competitor-notes/monday.md.
```
클로드는 필요할 때 파일을 읽습니다. 당신의 컨텍스트 창은 깔끔하게 유지됩니다.

### 플랜 모드 사용하기 (Shift+Tab)

복잡한 작업 전에 토글하세요. 클로드가 실행 전에 접근 방식을 개요로 작성하도록 강제합니다. 당신이 플랜을 승인하면 실행됩니다. 미해결 질문이 있는 PRD, 다중 파일 편집, "실행 취소"가 비용이 많이 드는 작업에 가장 적합합니다.

### 후크 설정하기

CLAUDE.md 지침(권고)과 달리, 후크는 결정론적으로 실행됩니다:


```
"Write a hook that spell-checks every file after I edit it"
"Write a hook that blocks writes to /templates/"
"Write a hook that runs a word count check — block any PRD over 1500 words"
```
`/hooks` 또는 `.claude/settings.json`을 통해 구성합니다. 종료 코드 0 = 진행, 종료 코드 2 = 피드백과 함께 차단.

### 세션 관리

- **관련 없는 작업 사이에 `/clear` 사용.** 컨텍스트 누출은 품질 저하의 1위 원인입니다.
- **대화는 약 50회 교환으로 제한.** 이를 넘으면 품질이 저하됩니다.
- **핸드오프 사용.** 긴 세션 종료 전: "HANDOFF.md 작성." 다음 세션: "@HANDOFF.md 읽고 계속."
- **병렬 세션 실행.** 각기 다른 터미널에서 각각의 Claude 인스턴스 및 컨텍스트 창 사용.
- **세션 재개.** 마지막 세션은 `claude --continue`, 기록에서 선택하려면 `claude --resume`.

### CLAUDE.md를 자체 개선하도록 만들기

Claude가 실수하면 수정한 뒤: "CLAUDE.md에 해당 실수를 다시 하지 않도록 규칙 추가." Claude가 규칙을 제안하고, 승인하면 파일을 편집합니다. 다음 세션에 규칙이 자동으로 로드됩니다. 분기별로 정리하세요.

### 스킬 맞춤화

스킬은 일반 예제로 제공됩니다. 제품의 실제 예제로 교체하세요. 팀의 속도를 아는 스프린트 플래너가 일반적인 것보다 항상 뛰어납니다.

### 실제 산출물 입력

Slack 스레드를 설명하지 말고 그대로 붙여넣으세요. 사용자 인터뷰를 요약하지 말고 대본을 붙여넣으세요. 스킬은 복잡한 정보를 추출하고 구조화합니다; 원본 입력이 최상의 결과를 만듭니다.

### 빠른 참조


```
/clear              Reset context (CLAUDE.md reloads automatically)
/hooks              Configure automation hooks
/init               Generate a starter CLAUDE.md from your project
/permissions        Set tool access rules
Shift+Tab           Toggle Plan Mode
Esc                 Cancel current generation
claude --continue   Resume last session
claude --resume     Pick a specific past session
claude -p "prompt"  Non-interactive single prompt
```
---

## 전체 설정을 원하시나요?

이 설정은 핵심 PM 워크플로우를 다룹니다. 전체 PM OS는 제가 매일 수행하는 모든 PM 작업을 포함합니다:

- 모든 PM 작업을 위한 41개 이상의 맞춤 스킬
- 7개의 하위 에이전트 관점 (엔지니어, 디자이너, 임원, 회의론자, 고객, 데이터 분석가, 법무)
- OKR, 용어, 팀 구조를 담은 컨텍스트 라이브러리
- 출시, 로드맵, 회고, 스프린트 계획 템플릿
- 자동 맞춤법 검사 및 파일 보호를 위한 훅

**[전체 PM 운영 체제 받기 →](https://www.news.aakashg.com/p/pm-os)**

---

[Aakash Gupta](https://www.aakashg.com) 제작 | [제품 성장 뉴스레터](https://www.news.aakashg.com)

---

## 문제 해결

일반적인 문제 및 해결 방법.

### Claude가 내 CLAUDE.md 지침을 따르지 않는 것 같아요

- **파일 위치 확인.** CLAUDE.md는 프로젝트 루트(claude를 실행하는 디렉토리)에 있어야 합니다. Claude Code는 작업 디렉토리에서 자동으로 불러옵니다.
- **파일 크기 확인.** 약 150줄을 넘으면 Claude가 지침을 무시하기 시작합니다. 적극적으로 줄이세요. 도메인 지식은 스킬로 이동하세요.
- **상충되는 지침 확인.** 모순되는 규칙은 예측 불가능한 동작을 만듭니다. 충돌 여부를 감사하세요.
- **세션 재시작.** `/clear`를 실행하거나 새 터미널을 시작하세요. Claude는 세션 시작 시 CLAUDE.md를 불러옵니다.

### 스킬이 작동하지 않아요

- **경로 확인.** 스킬은 `.claude/skills/<skill-name>/SKILL.md`에 있어야 합니다(대소문자 정확히 맞춰야 함).
- **트리거 확인.** SKILL.md에는 요청하는 방식과 일치하는 명확한 트리거 문구가 필요합니다. SKILL.md가 "사용자가 PRD 작성을 요청할 때 작동"이라면, "초안 작성"이라고 하면 Claude가 연결하지 못할 수 있습니다.
- **명시적 요청으로 테스트.** "prd-writer 스킬을 사용해 X에 대한 PRD 작성"이라고 시도해 보세요. 이게 작동하지만 자연어가 안 되면 트리거 설명을 다듬으세요.
- **SKILL.md가 비어있거나 잘못 작성되지 않았는지 확인.** 열어보고 내용이 있는지 검증하세요.

### Claude가 대화 중간에 컨텍스트를 잊어요

- **컨텍스트 한계.** 긴 대화는 약 50회 교환 후 성능이 저하됩니다. `/clear`를 사용하고 요약과 함께 새로 시작하세요.  
- **핸드오프 사용.** 초기화를 하기 전에 Claude가 상태, 결정사항, 다음 단계를 요약한 HANDOFF.md를 작성하게 하세요. 새 세션은 "Read @HANDOFF.md and continue."로 시작하세요.  
- **거대한 문서 붙여넣기 금지.** 전체 문서를 붙여넣지 말고 `@` 참조를 사용하세요.  

### 후크가 실행되지 않을 때  

- **`.claude/settings.json` 확인.** 후크는 여기서 설정되며, CLAUDE.md에 설정하지 않습니다.  
- **종료 코드 확인.** 후크는 종료 코드 0(진행)과 2(차단 + 피드백)를 사용합니다. 다른 종료 코드는 예상치 못한 동작을 유발할 수 있습니다.  
- **권한 확인.** 후크 스크립트는 실행 가능해야 합니다(`chmod +x`).  

### MCP 서버가 연결되지 않을 때  

- **자격 증명 확인.** 대부분 MCP 서버는 API 키 또는 OAuth 토큰이 필요합니다. 현재 상태를 확인하세요.  
- **서버 설정 확인.** MCP 연결은 Claude Code 설정에서 구성되며 CLAUDE.md에는 참고용으로만 기록됩니다.  
- **Claude Code 재시작.** MCP 연결은 시작 시 초기화됩니다.  

### "CLAUDE.md를 변경했는데 변한 게 없다"  

Claude는 세션 시작 시 CLAUDE.md를 읽습니다. 세션 중 편집한 경우 다시 불러와야 합니다:  
1. `/clear`를 실행해 컨텍스트를 재설정하세요(CLAUDE.md가 자동으로 재로드됨)  
2. 또는 새 터미널 세션을 시작하세요  



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-11

---