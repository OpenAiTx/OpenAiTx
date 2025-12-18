# iOS 시뮬레이터 스킬 for Claude Code

iOS 앱 테스트 및 빌드를 위한 프로덕션 준비 자동화. 인간 개발자와 AI 에이전트 모두에 최적화된 21개의 스크립트.

기본적으로 제 XCode MCP의 스킬 버전입니다: [https://github.com/conorluddy/xc-mcp](https://github.com/conorluddy/xc-mcp)

MCP는 활성화되면 많은 토큰을 컨텍스트 창에 로드하지만, 매우 잘 작동하는 것 같습니다. 스킬은 어떤 컨텍스트도 로드하지 않습니다. 다음에는 플러그인을 만들어 균형을 찾으려 합니다...

업데이트: 플러그인 버전은 다양한 도구 그룹에 대해 MCP를 쉽게 비활성화할 수 있습니다. xcodebuild와 같은 현재 사용 중인 도구만 활성화하여 컨텍스트 창을 최적화하세요: [https://github.com/conorluddy/xclaude-plugin](https://github.com/conorluddy/xclaude-plugin)

## 기능

UI가 변경될 때 깨지는 픽셀 기반 내비게이션 대신:

```bash
# Fragile - breaks if UI changes
idb ui tap 320 400

# Robust - finds by meaning
python scripts/navigator.py --find-text "Login" --tap
```
접근성 API에서 의미에 기반한 시맨틱 내비게이션을 사용하여 좌표가 아닌 의미로 요소와 상호작용합니다. 다양한 화면 크기에서 작동하며 UI 재설계 시에도 유지됩니다.

## 기능

- **21개의 프로덕션 스크립트** 빌드, 테스트 및 자동화용
- **시맨틱 내비게이션** - 텍스트, 타입 또는 ID로 요소 찾기
- **토큰 최적화** - 원시 도구 대비 96% 감소 (기본 3-5줄)
- **제로 설정** - macOS에서 Xcode와 즉시 작동
- **구조화된 출력** - JSON 및 형식화된 텍스트, 파싱 용이
- **자동 UDID 감지** - 매번 기기 지정 불필요
- **일괄 작업** - 여러 시뮬레이터 한 번에 부팅, 삭제, 초기화
- **포괄적 테스트** - WCAG 준수, 시각적 차이, 접근성 감사
- **CI/CD 준비 완료** - JSON 출력, 종료 코드, 자동화된 기기 수명주기

## 설치

### 클로드 코드 스킬로서


```bash
# Personal installation
git clone https://github.com/conorluddy/ios-simulator-skill.git ~/.claude/skills/ios-simulator-skill

# Project installation
git clone https://github.com/conorluddy/ios-simulator-skill.git .claude/skills/ios-simulator-skill
```
Claude Code를 재시작하세요. 스킬이 자동으로 로드됩니다.

### 릴리스부터


```bash
# Download latest release
curl -L https://github.com/conorluddy/ios-simulator-skill/releases/download/vX.X.X/ios-simulator-skill-vX.X.X.zip -o skill.zip

# Extract
unzip skill.zip -d ~/.claude/skills/ios-simulator-skill
```
## 전제 조건

- macOS 12 이상
- Xcode 명령어 도구 (`xcode-select --install`)
- Python 3
- IDB (선택 사항, 대화형 기능용: `brew tap facebook/fb && brew install idb-companion`)

## 빠른 시작


```bash
# 1. Check environment
bash ~/.claude/skills/ios-simulator-skill/scripts/sim_health_check.sh

# 2. Launch your app
python ~/.claude/skills/ios-simulator-skill/scripts/app_launcher.py --launch com.example.app

# 3. See what's on screen
python ~/.claude/skills/ios-simulator-skill/scripts/screen_mapper.py
# Output:
# Screen: LoginViewController (45 elements, 7 interactive)
# Buttons: "Login", "Cancel", "Forgot Password"
# TextFields: 2 (0 filled)

# 4. Tap login button
python ~/.claude/skills/ios-simulator-skill/scripts/navigator.py --find-text "Login" --tap

# 5. Enter text
python ~/.claude/skills/ios-simulator-skill/scripts/navigator.py --find-type TextField --enter-text "user@test.com"

# 6. Check accessibility
python ~/.claude/skills/ios-simulator-skill/scripts/accessibility_audit.py
```
## 21개의 카테고리별 스크립트

### 빌드 및 개발
- **build_and_test.py** - 프로젝트 빌드, 테스트 실행, 결과 파싱
- **log_monitor.py** - 실시간 로그 모니터링

### 내비게이션 및 상호작용
- **screen_mapper.py** - 현재 화면 분석
- **navigator.py** - 요소 찾기 및 상호작용
- **gesture.py** - 스와이프, 스크롤, 핀치
- **keyboard.py** - 텍스트 입력 및 하드웨어 버튼
- **app_launcher.py** - 앱 라이프사이클 제어

### 테스트 및 분석
- **accessibility_audit.py** - WCAG 준수 검사
- **visual_diff.py** - 스크린샷 비교
- **test_recorder.py** - 자동화 테스트 문서화
- **app_state_capture.py** - 디버깅 스냅샷
- **sim_health_check.sh** - 환경 검증

### 고급 테스트 및 권한
- **clipboard.py** - 클립보드 관리
- **status_bar.py** - 상태 표시줄 제어
- **push_notification.py** - 푸시 알림
- **privacy_manager.py** - 권한 관리

### 디바이스 라이프사이클
- **simctl_boot.py** - 시뮬레이터 부팅
- **simctl_shutdown.py** - 시뮬레이터 종료
- **simctl_create.py** - 시뮬레이터 생성
- **simctl_delete.py** - 시뮬레이터 삭제
- **simctl_erase.py** - 공장 초기화

전체 참조는 **SKILL.md**를 참조하세요.

## Claude Code와의 작동 방식

Claude Code는 요청에 따라 이 스킬을 자동으로 감지하여 사용합니다. 수동으로 호출할 필요가 없습니다.


**예시 대화:**

```
You: "Set up my iOS app for testing"
Claude: [Uses simctl_boot.py and app_launcher.py automatically]

You: "Tap the login button"
Claude: [Uses navigator.py to find and tap]

You: "Check if the form is accessible"
Claude: [Uses accessibility_audit.py]
```
필요할 때 수동으로 스크립트를 실행할 수도 있습니다.

## 사용 예제

### 예제 1: 로그인 흐름


```bash
# Launch app
python scripts/app_launcher.py --launch com.example.app

# Map screen to find fields
python scripts/screen_mapper.py

# Enter credentials
python scripts/navigator.py --find-type TextField --index 0 --enter-text "user@test.com"
python scripts/navigator.py --find-type SecureTextField --enter-text "password"

# Tap login
python scripts/navigator.py --find-text "Login" --tap

# Verify accessibility
python scripts/accessibility_audit.py
```
### 예제 2: 테스트 문서 작성


```bash
# Record test execution
python scripts/test_recorder.py --test-name "Login Flow" --output test-reports/

# Generates:
# - Screenshots per step
# - Accessibility trees
# - Markdown report with timing
```

### 예제 3: 시각적 테스트

```bash
# Capture baseline
python scripts/app_state_capture.py --output baseline/

# Make changes...

# Compare
python scripts/visual_diff.py baseline/screenshot.png current/screenshot.png
```

### 예제 4: 권한 테스트

```bash
# Grant permissions
python scripts/privacy_manager.py --bundle-id com.example.app --grant camera,location

# Test app behavior with permissions...

# Revoke permissions
python scripts/privacy_manager.py --bundle-id com.example.app --revoke camera,location
```

### 예제 5: CI/CD에서의 디바이스 수명 주기

```bash
# Create test device
DEVICE_ID=$(python scripts/simctl_create.py --device "iPhone 16 Pro" --json | jq -r '.new_udid')

# Run tests
python scripts/build_and_test.py --project MyApp.xcodeproj

# Clean up
python scripts/simctl_delete.py --udid $DEVICE_ID --yes
```
## 디자인 원칙

**의미 기반 탐색**: 픽셀 좌표가 아닌 의미(텍스트, 유형, ID)로 요소를 찾습니다. UI 변경에도 견고하며 다양한 기기 크기에서 작동합니다.

**토큰 효율성**: 기본 출력은 3-5줄입니다. 자세한 내용은 `--verbose`를, 기계 파싱용은 `--json`을 사용하세요. 원시 도구 대비 96% 감소.

**접근성 우선**: 신뢰성을 위해 iOS 접근성 API 기반으로 구축되었습니다. 접근성 필요 사용자를 위해 더 좋고 자동화에 더 견고합니다.

**제로 구성**: Xcode가 설치된 macOS에서 즉시 작동합니다. 복잡한 설정이나 구성 파일이 필요 없습니다.

**구조화된 데이터**: 스크립트는 원시 로그가 아닌 JSON 또는 포맷된 텍스트를 출력합니다. 파싱, 통합, 이해가 쉽습니다.

**자동 학습**: 빌드 시스템이 기기 선호도를 학습하고 다음에 기억합니다.

## 요구 사항

**시스템:**
- macOS 12 이상
- Xcode 명령줄 도구
- Python 3

**선택 사항:**
- IDB (대화형 기능용)
- Pillow (visual_diff.py용: `pip3 install pillow`)

## 문서

- **SKILL.md** - 완전한 스크립트 참조 및 목차
- **CLAUDE.md** - 아키텍처 및 개발자 가이드
- **references/** - 특정 주제에 대한 심층 문서
- **examples/** - 완전한 자동화 워크플로우

## 출력 효율성

모든 스크립트는 기본적으로 출력을 최소화합니다:

| 작업 | 원시 도구 | 이 스킬 | 절감율 |
|------|-----------|---------|---------|
| 화면 분석 | 200+ 줄 | 5 줄 | 97.5% |

| 버튼 찾기 및 탭 | 100+ 줄 | 1줄 | 99% |
| 텍스트 입력 | 50+ 줄 | 1줄 | 98% |
| 로그인 흐름 | 400+ 줄 | 15줄 | 96% |

이 효율성은 AI 에이전트 대화를 집중적이고 비용 효율적으로 유지합니다.

## 문제 해결

### 환경 문제

```bash
# Run health check
bash ~/.claude/skills/ios-simulator-skill/scripts/sim_health_check.sh

# Checks: macOS, Xcode, simctl, IDB, Python, simulators, packages
```

### 스크립트 도움말

```bash
# All scripts support --help
python scripts/navigator.py --help
python scripts/accessibility_audit.py --help
```

### 요소를 찾지 못함

```bash
# Use verbose mode to see all elements
python scripts/screen_mapper.py --verbose

# Check for exact text match
python scripts/navigator.py --find-text "Exact Button Text" --tap
```
## 기여하기

기여는 다음을 준수해야 합니다:
- 토큰 효율성 유지 (최소 기본 출력)
- 접근성 우선 디자인 준수
- `--help` 문서 지원
- CI/CD를 위한 `--json` 지원
- Black 포매터 및 Ruff 린터 통과
- 타입 힌트 포함
- SKILL.md 업데이트

## 라이선스

MIT 라이선스 - 상업적 사용 및 배포 허용.

## 지원

- **이슈**: 재현 단계와 함께 GitHub 이슈 생성
- **문서**: SKILL.md 및 references/ 참고
- **예제**: examples/ 디렉토리 확인
- **스킬 문서**: https://docs.claude.com/en/docs/claude-code/skills

---

**AI 에이전트를 위해 제작되었습니다. 개발자에게 최적화되었습니다.**



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-18

---