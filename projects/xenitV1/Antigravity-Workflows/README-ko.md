# 무중력 워크플로우 - AI 에이전트 스킬 시스템

> 무중력 IDE를 위한 종합 AI 에이전트 스킬 시스템입니다. 규칙, 워크플로우, 자동 활성화 스킬을 포함합니다.
> **참고:** 무중력은 에이전트 및 스킬 기능을 기반으로 재구성되었습니다. Maestro 스킬과 에이전트 구조가 완전히 통합되었습니다.
> 참고: [Claude Code Maestro](https://github.com/xenitV1/claude-code-maestro)

---

## 🚀 설치

### 윈도우 (PowerShell)

```powershell
# 1. Create directories
New-Item -ItemType Directory -Force -Path "$HOME\.gemini\antigravity"
New-Item -ItemType Directory -Force -Path "$HOME\.gemini\global_workflows"
New-Item -ItemType Directory -Force -Path "$HOME\.agent"

# 2. GEMINI.md -> ~/.gemini/
Copy-Item ".\GEMINI.md" "$HOME\.gemini\GEMINI.md"

# 3. Global Workflows (Commands) -> ~/.gemini/global_workflows/
Copy-Item ".\global_workflows\*" "$HOME\.gemini\global_workflows\"

# 4. Antigravity System (Skills) -> ~/.gemini/antigravity/
Copy-Item -Recurse ".\skills" "$HOME\.gemini\antigravity\"

# 5. Agents -> ~/.agent/
Copy-Item ".\.agent\*" "$HOME\.agent\" -Recurse
```
### macOS/Linux (Bash)


```bash
# 1. Create directories
mkdir -p ~/.gemini/antigravity
mkdir -p ~/.gemini/global_workflows
mkdir -p ~/.agent

# 2. GEMINI.md -> ~/.gemini/
cp GEMINI.md ~/.gemini/GEMINI.md

# 3. Global Workflows (Commands) -> ~/.gemini/global_workflows/
cp -r global_workflows/* ~/.gemini/global_workflows/

# 4. Antigravity System (Skills) -> ~/.gemini/antigravity/
cp -r skills ~/.gemini/antigravity/

# 5. Agents -> ~/.agent/
cp -r .agent/* ~/.agent/
```

---

## 📁 Post-Installation Structure

```
~/.gemini/                              # Global Config
├── GEMINI.md                           # Maestro Configuration
├── global_workflows/                   # Slash Commands (/)
│   ├── brainstorm.md                   # /brainstorm
│   ├── create.md                       # /create
│   └── ...
└── antigravity/                        # Core System
    └── skills/                         # Skill Library
        ├── ultrathink.md
        ├── architecture.md
        └── ...

~/.agent/                               # Agents
└── agents/                             # 16 Specialized Agents
    ├── orchestrator.md
    ├── backend-specialist.md
    └── ...
```

---

## 🤖 사용 가능한 에이전트 (16)

| 에이전트 | 도메인 및 집중 분야 |
|-------|----------------|
| `orchestrator` | 다중 에이전트 조정 및 통합 |
| `project-planner` | 탐색, 아키텍처, 작업 계획 |
| `backend-specialist` | 백엔드 아키텍트 (API + 데이터베이스 + 서버) |
| `database-architect` | 데이터베이스 스키마, SQL 최적화 |
| `frontend-specialist` | 프론트엔드 및 성장 (UI/UX + SEO) |
| `mobile-developer` | 모바일 전문가 (크로스 플랫폼) |
| `game-developer` | 게임 로직 및 자산 및 성능 |
| `security-auditor` | 사이버 보안 감사 |
| `debugger` | 근본 원인 분석 및 버그 수정 |
| `devops-engineer` | CI/CD, 인프라, 배포 |
| `documentation-writer` | 기술 문서 작성 |
| `explorer-agent` | 탐색, 파일 목록 작성, 분석 |
| `penetration-tester` | 공격 보안 |
| `performance-optimizer` | 속도, 주요 지표 |
| `seo-specialist` | SEO, GEO, 분석 |
| `test-engineer` | 테스트 전략, E2E, 단위 테스트 |

---

## ⚡ 슬래시 명령어 (10)

| 명령어 | 설명 |
|---------|-------------|
| `/brainstorm` | 구조화된 브레인스토밍 |
| `/create` | 새 애플리케이션 생성 |
| `/debug` | 디버그 및 문제 해결 |
| `/deploy` | 프로덕션 배포 |
| `/enhance` | 기능 추가/업데이트 |
| `/orchestrate` | 다중 에이전트 조정 |
| `/plan` | 작업 계획 |
| `/preview` | 서버 미리보기 관리 |
| `/status` | 프로젝트 상태 표시 |
| `/test` | 테스트 생성 및 실행 |

---

## 📚 기술 (35개 카테고리)

기술은 `~/.gemini/antigravity/skills/`에 정리되어 있으며 다음을 포함합니다:
- **개발:** `clean-code`, `react-patterns`, `python-patterns`
- **아키텍처:** `architecture`, `api-patterns`, `database-design`
- **품질:** `testing-patterns`, `code-review-checklist`, `tdd-workflow`
- **보안:** `vulnerability-scanner`, `red-team-tactics`
- **성능:** `performance-profiling`, `tailwind-patterns`
- **SEO/GEO:** `seo-fundamentals`, `geo-fundamentals`
- **DevOps:** `deployment-procedures`, `server-management`

_전체 목록은 `ARCHITECTURE.md`를 참조하세요._

---

## 🎯 주요 기능

- ✅ 다양한 개발 분야별 **16개 전문 에이전트**
- ✅ 풀스택 개발을 아우르는 **35개 기술 카테고리**
- ✅ 효율적 워크플로우를 위한 **10개 슬래시 명령어**
- ✅ 통합된 **Maestro v4.1 표준**
- ✅ **동적 사용자 경로** (`~/.agent/`, `~/.gemini/antigravity/`)
- ✅ 전사적 적용되는 **클린 코드 원칙**

---

## 📖 문서

- **[ARCHITECTURE.md](https://raw.githubusercontent.com/xenitV1/Antigravity-Workflows/main/ARCHITECTURE.md)** - 전체 시스템 구조
- **[GEMINI.md](https://raw.githubusercontent.com/xenitV1/Antigravity-Workflows/main/GEMINI.md)** - Maestro 구성 및 규칙
- **[CHANGELOG.md](https://raw.githubusercontent.com/xenitV1/Antigravity-Workflows/main/CHANGELOG.md)** - 버전 기록

---

## 📄 라이선스

MIT 라이선스

---

**개발자:** [@xenit-v0](https://x.com/xenit_v0)
**버전:** 0.2.2 (안티그래비티 IDE 네이티브 지원)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-12

---