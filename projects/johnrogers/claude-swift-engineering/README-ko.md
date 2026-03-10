# claude-swift-engineering

[![License](https://img.shields.io/badge/license-MIT-green)](#) [![Platform](https://img.shields.io/badge/platform-iOS%2026%2B%20%7C%20macOS-blue)](#)

> 현대 Swift/SwiftUI 개발을 위한 Claude Code 플러그인 마켓플레이스

최신 Swift 6.2, TCA(The Composable Architecture), SwiftUI를 사용하여 전문적인 iOS/macOS 기능을 구축하기 위한 특화된 AI 툴킷입니다. 이 플러그인은 기획, 구현, 테스트 및 배포를 조율하는 초특화 에이전트를 제공합니다.

## Swift Engineering Plugin

**swift-engineering 플러그인**은 전문 Swift 개발을 위한 생산 준비 완료 툴킷입니다:

- **12개의 초특화 에이전트** — 기획(Opus), 구현(Inherit), 유틸리티(Haiku)로 명확한 업무 인수인계
- **TCA 지원** — The Composable Architecture를 위한 아키텍처 설계부터 테스트까지 전체 워크플로우
- **최신 Swift 6.2** — 엄격한 동시성, async/await, 액터, Sendable을 지원하는 iOS 26 이상
- **코드 품질** — 통합 코드 리뷰, 접근성 준수, 성능 점검 기능 포함
- **지식 스킬** — 아키텍처 패턴, 프레임워크, 디자인 및 개발 도구를 아우르는 18개의 전문 지식 기반

## 빠른 시작

### 설치

Claude Code에 플러그인을 추가하세요:

```bash
# Add marketplace source
/plugin marketplace add https://github.com/johnrogers/claude-swift-engineering

# Install swift-engineering plugin
/plugin install swift-engineering
```
### 훅(선택 사항)

더 나은 작업 흐름 규율을 위해 스킬/에이전트 평가 훅을 활성화하세요:


```bash
# 1. Symlink hooks-scripts to ~/.claude
ln -s /path/to/claude-swift-engineering/plugins/swift-engineering/hooks-scripts ~/.claude/hooks-scripts

# 2. Add to ~/.claude/settings.json
{
  "hooks": {
    "UserPromptSubmit": [
      {
        "hooks": [
          {
            "type": "command",
            "command": "cat ~/.claude/hooks-scripts/UserPromptSubmit/skill-forced-eval-hook.sh"
          },
          {
            "type": "command",
            "command": "cat ~/.claude/hooks-scripts/UserPromptSubmit/agent-forced-eval-hook.sh"
          }
        ]
      }
    ]
  }
}
```
전체 후크 문서는 [plugins/swift-engineering/hooks-scripts/README.md](https://raw.githubusercontent.com/johnrogers/claude-swift-engineering/main/plugins/swift-engineering/hooks-scripts/README.md)를 참조하세요.

에이전트 사용 및 가능한 워크플로우에 대한 전체 문서는 [plugins/swift-engineering/README.md](https://raw.githubusercontent.com/johnrogers/claude-swift-engineering/main/plugins/swift-engineering/README.md)를 참조하세요.

## 포함된 내용

### 12개의 전문화된 에이전트

| 유형 | 에이전트 | 책임 |
|------|--------|-----------------|
| **기획** | @swift-ui-design, @swift-architect, @tca-architect | 아키텍처 결정 (Opus, 읽기 전용) |
| **구현** | @tca-engineer, @swift-engineer, @swiftui-specialist, @swift-test-creator, @documentation-generator, @swift-code-reviewer, @swift-modernizer | 코드 생성 및 검토 (상속) |
| **유틸리티** | @swift-documenter, @search | API 문서화 및 코드 검색 (Haiku) |

### 18가지 지식 기술

아키텍처 패턴 (TCA, SwiftUI, 최신 Swift, 고급 제스처), 프레임워크 (SQLite, GRDB, StoreKit, 네트워킹), 플랫폼 디자인 (iOS 26, HIG, 현지화, 햅틱), 개발 도구 (테스트, 스타일, 진단). 각 기술은 최신 패턴과 모범 사례에 대해 심층적인 지침을 제공합니다.

## 기여자를 위한 안내

### 저장소 구조


```
claude-swift-engineering/
├── .claude-plugin/
│   └── marketplace.json                    # Marketplace configuration
├── .github/workflows/                      # CI/CD pipelines
├── plugins/
│   └── swift-engineering/                  # Main plugin
│       ├── agents/                         # 12 specialized agents
│       ├── skills/                         # 18 comprehensive skills
│       ├── hooks-scripts/                  # Hooks system
│       ├── scripts/                        # Helper utilities
│       ├── rules/                          # Development rules
│       └── README.md                       # Plugin documentation
└── worktrees/                              # Git worktrees for features
```

### 개발 워크플로우

#### 버전 올리기

변경 사항이 있을 때는 플러그인 버전을 증가시킵니다:

```bash
bash plugins/swift-engineering/scripts/bump-plugin-version.sh <new-version>
```
이 업데이트는 plugin.json, marketplace.json 및 기타 메타데이터 파일의 버전 번호를 갱신합니다.

#### 에이전트 또는 스킬 추가

1. 기존 패턴을 따라 새로운 에이전트 또는 스킬 파일 생성 (`agents/` 또는 `skills/` 예제 참고)
2. 새로운 도구 기능 정의 시 `plugin.json` 업데이트
3. 구성 검증을 위한 스모크 테스트 실행
4. 두 README 파일(루트 및 플러그인) 업데이트
5. 워크플로우와의 통합 테스트 수행

### 코드 구성

- **에이전트** (`agents/`) — 각 에이전트는 메타데이터 및 지침이 담긴 `.md` 파일 보유
- **스킬** (`skills/`) — 에이전트가 참조하는 주제별 지식 리소스
- **훅** (`hooks-scripts/`) — 워크플로우를 강제하는 실행 가능한 훅
- **스크립트** (`scripts/`) — 자동화를 위한 유틸리티 셸 스크립트
- **규칙** (`rules/`) — 개발 관행 및 의사결정 프레임워크
- **문서** (`docs/`) — 스모크 테스트 및 검증 스위트

## 아키텍처 및 설계 원칙

플러그인은 다음의 주요 원칙들을 구현합니다:

- **초전문화(Ultra-Specialization)** — 각 에이전트는 명확한 책임과 정의된 인계 절차를 가짐
- **모델 층화(Model Stratification)** — 아키텍처용 Opus(최상의 추론), 구현용 Inherit(비용 효율적), 유틸리티용 Haiku(빠름)
- **로컬 우선(Local-First)** — 기본값은 SQLite 및 UserDefaults, SwiftData 또는 Core Data는 사용하지 않음
- **모던 스위프트 전용(Modern Swift Only)** — Swift 6.2 및 엄격한 동시성, 폐기된 API 미사용
- **읽기 전용 기획(Read-Only Planning)** — 기획 에이전트는 코드 수정 불가, 명확한 분리 보장
- **기획 파일 조정(Plan File Coordination)** — 에이전트들은 `docs/plans/<feature>.md`를 통해 상태 공유

아키텍처 세부사항, 워크플로우 다이어그램, 인계 모델은 [plugins/swift-engineering/README.md](https://raw.githubusercontent.com/johnrogers/claude-swift-engineering/main/plugins/swift-engineering/README.md) 참고.

## 라이선스

MIT 라이선스 — 자세한 내용은 [LICENSE](LICENSE) 파일 참조.

## 기여자

**저자:** John Rogers

**저장소:** claude-swift-engineering
**Swift 버전:** 6.2+
**iOS 배포 대상:** 26.0+

---

자세한 문서, 에이전트 사양 및 사용 예제는 [plugins/swift-engineering/README.md](https://raw.githubusercontent.com/johnrogers/claude-swift-engineering/main/plugins/swift-engineering/README.md)를 참조하세요.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-10

---