# claude-sbox

[Claude Code](https://code.claude.com) 스킬로, Claude가 Unity 패턴에 의존하지 않고 관용적인 [s&box](https://sbox.game) 코드 — C# 컴포넌트, Razor UI, 물리, 네트워킹 — 를 작성하도록 가르칩니다.

s&box는 Facepunch의 Source 2 게임 엔진에 C# 스크립팅 레이어가 추가된 것입니다. 이 엔진의 API, 생명주기, 네트워킹 모델은 Unity와 *전혀 다르기* 때문에, 일반 Claude는 `void Start()`, Unity식 `GetComponent<T>()`, `Physics.Raycast`, `[SerializeField]`, `StartCoroutine` 등을 자주 착각합니다 — s&box에서는 모두 틀렸습니다. 이 스킬은 s&box 코드를 작성할 때 로드되어 Claude를 엔진의 내보낸 스키마에 맞는 올바른 API로 안내합니다.

---

## 설치

**개인용 (모든 프로젝트에서 사용 가능):**

```bash
mkdir -p ~/.claude/skills
git clone https://github.com/gavogavogavo/claude-sbox ~/.claude/skills/sbox
```

**프로젝트 로컬 (이 게임에만 적용):**

```bash
cd my-sbox-game
mkdir -p .claude/skills
git clone https://github.com/gavogavogavo/claude-sbox .claude/skills/sbox
```
Claude Code는 스킬 파일 변경 사항을 실시간으로 감지합니다. 그러나 `~/.claude/skills/` 디렉터리가 Claude Code 세션 시작 시 존재하지 않았다면(즉, 첫 개인 스킬인 경우), `mkdir` 후에 **Claude Code를 재시작**해야 감시자가 새 디렉터리를 등록합니다.

> **왜 `sbox` 디렉터리 이름인가요 (`claude-sbox`가 아닌)?** `SKILL.md`의 `name:` 프론트매터가 `sbox`로 되어 있어 `/sbox` 슬래시 명령어가 됩니다. `~/.claude/skills/sbox/`에 클론하면 디렉터리 이름과 호출 이름이 일치합니다.

---

## 작동 여부 확인

어떤 Claude Code 세션에서든 다음을 입력하세요:


```
/sbox
```
라우터가 로드됩니다. 또는 트리거 질문을 하고 Claude가 참조 파일을 찾는 것을 지켜보세요:


```
How do I write a networked player controller in s&box?
```
Claude는 답변하기 전에 `references/core-concepts.md`, `references/networking.md`, 그리고/또는 `references/patterns-and-examples.md`를 열어야 합니다 — *이것이 스킬이 작동 중임을 알리는 신호입니다*. 만약 파일을 읽지 않고 기억에서 답변한다면 문제가 있는 것이니 [문제 해결](#troubleshooting)을 참조하세요.

---

## 내용 구성

`SKILL.md`는 참조 문서가 아니라 라우터입니다. Claude가 세부 사항이 필요할 때 다음 파일 중 하나를 엽니다:

| 파일 | 줄 수 | 내용 |
|---|---:|---|
| `SKILL.md` | 271 | 라우터 + Unity→s&box 변환표 + 10가지 규칙 |
| `references/core-concepts.md` | 575 | 씬 시스템, 게임오브젝트, 컴포넌트, 생명주기, `[Property]`, 프리팹, 씬 이벤트, `GameObjectSystem`, 비동기 |
| `references/components-builtin.md` | 729 | 144개 내장 컴포넌트 — 렌더러, 리지드바디, 콜라이더, `CharacterController`, `CameraComponent`, 조명, 오디오, UI, `NavMeshAgent`, `PlayerController`, 파티클, 후처리 |
| `references/ui-razor.md` | 834 | Razor 패널, SCSS, 플렉스박스 레이아웃, 내장 컨트롤(Button / TextEntry / DropDown / SliderControl / VirtualGrid), `NavigationHost`, 전환 효과 |
| `references/networking.md` | 672 | 로비, `Connection`, `[Sync]` + `SyncFlags`, `[Rpc.Broadcast/Host/Owner]`, 소유권, `INetworkListener`, `INetworkSpawn`, 스냅샷 데이터, 전용 서버 |
| `references/input-and-physics.md` | 597 | 입력 시스템, `SceneTrace` 빌더 API, `PhysicsWorld`, 충돌, `Vector3`/`Rotation`/`Angles`/`Transform`/`BBox`/`Ray`/`Capsule`, `TimeSince`/`TimeUntil`, `Gizmo.Draw` |
| `references/api-schema-core.md` | 930 | 가장 많이 사용되는 약 50개 타입의 전체 공개 시그니처 |
| `references/api-schema-extended.md` | 2753 | 네임스페이스별로 정리된 738개 추가 타입 인덱스 |
| `references/patterns-and-examples.md` | 1056 | 10가지 완전 실행 가능한 예제 (Health + `IDamageable`, 1인칭 `CharacterController`, 히트스캔 무기, 네트워크 게임 매니저, `[Sync]`/RPC가 적용된 플레이어, Razor HUD, 리지드바디 수류탄, NavMeshAgent AI 상태 머신, 프리팹 스포너, 트리거 픽업) |

모든 참조 파일의 API 시그니처는 s&box 엔진의 내보낸 스키마(`raw/api-schema.json`, 61개 네임스페이스에 걸친 약 1,850개 타입)와 대조 검증됩니다. 스키마는 유일한 진실의 원천입니다 — 문서와 스키마가 다를 경우 스키마가 우선합니다.

---

## 업데이트


```bash
cd ~/.claude/skills/sbox
git pull
```

Claude Code는 현재 세션 내에서 수정된 스킬 파일을 다시 로드합니다.

---

## 소스에서 재생성하기

최종 사용자는 이 기능이 필요하지 않습니다. 최신 s&box 엔진에 맞춰 참조 파일을 다시 빌드하려는 유지보수 담당자를 위한 내용입니다:

```bash
./scripts/fetch-raw.sh         # clones Facepunch/sbox-docs into raw/sbox-docs
# manually place raw/api-schema.json (see docs/DESIGN.md)
node scripts/build_extended.js # rebuilds references/api-schema-extended.md
```
전체 빌드 워크플로우 — 각 참조 파일이 어떻게 큐레이션되었는지, 스키마 검증 루프, 그리고 알려진 문제점들 — 은 [`docs/DESIGN.md`](https://raw.githubusercontent.com/gavogavogavo/claude-sbox/main/docs/DESIGN.md) 와 [`docs/BUILD_LOG.md`](https://raw.githubusercontent.com/gavogavogavo/claude-sbox/main/docs/BUILD_LOG.md) 에 문서화되어 있습니다.

---

## 문제 해결

**Claude가 s&box 질문에서 스킬을 트리거하지 않습니다.**
디렉터리가 `~/.claude/skills/sbox/` 에 있는지 확인하세요 (`~/.claude/skills/claude-sbox/` 또는 `~/.claude/skills/sbox-skill/` 가 아님). 디렉터리 이름은 `name:` 프론트매터와 일치해야 합니다. 또한 `/sbox` 명령어로 명시적으로 호출해서 설치 여부를 확인해보세요.

**Claude가 참조 파일을 열지 않고 s&box 질문에 답변합니다.**
이는 Unity 근육 기억에서 환각을 일으키는 것입니다 — 이 스킬이 방지하기 위해 존재하는 정확한 실패 상황입니다. 스킬이 로드되지 않았거나 설명이 일치하지 않는 경우입니다. `/sbox` 로 강제 로드한 뒤 질문을 다시 시도해보세요.

**스킬은 로드되지만 컴파일되지 않는 API를 제안합니다.**
제안된 코드와 Claude가 참조했다고 주장하는 참조 파일을 포함하여 이슈를 여세요. 배포된 모든 시그니처는 스키마 검증을 거쳐야 합니다; 회귀는 버그입니다.

**`~/.claude/skills/claude-sbox/` 에 클론했는데 이제 어떻게 하나요?**
디렉터리 이름을 `sbox` 로 변경하거나 `SKILL.md` 의 `name:` 필드를 `claude-sbox` 로 변경하여 일치시키세요. 프로젝트 로컬 설치도 마찬가지입니다.

---

## 기여하기

이슈와 PR 환영합니다. 제출 전에:

- **새 API 시그니처를 `raw/api-schema.json` 과 검증하세요.** 스키마가 진실의 근원입니다. 스키마에서 메서드를 찾을 수 없다면 추가하지 마세요.
- **`SKILL.md` 를 500줄 이하로 유지하세요.** 이 파일은 라우터입니다 — 참조 상세 내용은 `references/` 에 있습니다. 참조 파일을 열지 않고 `SKILL.md` 만으로 s&box 질문에 답할 수 있다면, 라우터에 너무 많은 상세가 들어간 것입니다.
- **사용자에게 보이는 변경사항은 `CHANGELOG.md` 에 업데이트하세요.**
- **기존 문체와 맞추세요** — 간결하고 밀도 높으며, 튜토리얼 독자가 아닌 Claude를 위해 작성된 스타일입니다.

---

## 라이선스

MIT — [LICENSE](LICENSE) 참조.

이 프로젝트는 Facepunch 또는 Anthropic과 제휴하거나 승인받지 않았습니다. s&box는 Facepunch Studios의 제품입니다. Claude Code와 Agent Skills 포맷은 Anthropic의 제품입니다.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-15

---