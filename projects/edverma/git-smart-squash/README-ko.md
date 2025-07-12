# Git Smart Squash

커밋을 수동으로 재정렬하는 데 시간을 낭비하지 마세요. AI가 대신 해드립니다.

## 문제점

누구나 이런 경험이 있습니다: 기능 하나에 15개의 커밋, 그 중 절반은 "fix", "typo", 또는 "WIP"입니다. 이제 PR 리뷰를 위해 정리해야 합니다. 커밋을 수동으로 합치고 메시지를 다시 쓰는 것은 번거롭습니다.

## 해결책

Git Smart Squash는 변경사항을 분석하여 논리적인 커밋과 적절한 메시지로 재구성합니다:

```bash
# 이전: 지저분한 브랜치
* fix tests
* typo  
* more auth changes
* WIP: working on auth
* update tests
* initial auth implementation

# After: clean, logical commits
* feat: JWT 인증 시스템 구현
* test: 인증 엔드포인트 커버리지 추가
```

## 빠른 시작

### 1. 설치

```bash
# pip 사용
pip install git-smart-squash

# pipx 사용 (격리된 설치 권장)
pipx install git-smart-squash

# uv 사용 (빠른 Python 패키지 매니저)
uv tool install git-smart-squash
```
### 2. AI 설정

**옵션 A: 로컬 (무료, 프라이빗)**
```bash
# https://ollama.com 에서 Ollama 설치
ollama pull devstral  # 기본 모델
```

**옵션 B: 클라우드 (더 나은 결과)**
```bash
export OPENAI_API_KEY="your-key"
export ANTHROPIC_API_KEY="your-key"
export GEMINI_API_KEY="your-key"
```

### 3. 실행

```bash
cd your-repo
git-smart-squash
```
이것으로 끝입니다. 계획을 검토하고 승인하세요.

## 커맨드 라인 파라미터

| 파라미터 | 설명 | 기본값 |
|-----------|-------------|---------|
| `--base` | 비교할 기준 브랜치 | 설정 파일 또는 `main` |
| `--ai-provider` | 사용할 AI 제공자 (openai, anthropic, local, gemini) | 설정에서 구성됨 |
| `--model` | 사용할 특정 AI 모델 (아래 추천 모델 참고) | 제공자 기본값 |
| `--config` | 사용자 지정 설정 파일 경로 | `.git-smart-squash.yml` 또는 `~/.git-smart-squash.yml` |
| `--auto-apply` | 확인 프롬프트 없이 커밋 계획 적용 | `false` |
| `--instructions`, `-i` | AI를 위한 사용자 지정 지침 (예: "기능 영역별로 그룹화") | 없음 |
| `--no-attribution` | 커밋에서 귀속 메시지 비활성화 | `false` |
| `--debug` | 상세 정보를 위한 디버그 로깅 활성화 | `false` |

## 추천 모델

### 기본 모델
- **OpenAI**: `gpt-4.1` (기본값)
- **Anthropic**: `claude-sonnet-4-20250514` (기본값)
- **Gemini**: `gemini-2.5-pro` (기본값)
- **Local/Ollama**: `devstral` (기본값)

### 모델 선택
```bash
# 다른 모델 지정
git-smart-squash --ai-provider openai --model gpt-4.1-mini

# 로컬 Ollama 사용 시
git-smart-squash --ai-provider local --model llama-3.1
```

## 사용자 정의 지침

`--instructions` 파라미터를 사용하면 커밋이 정리되는 방식을 제어할 수 있습니다:

### 예시
```bash
# 티켓 접두사 추가
git-smart-squash -i "모든 커밋 앞에 [ABC-1234]를 붙이세요"

# 유형별로 분리
git-smart-squash -i "백엔드와 프론트엔드 변경 사항을 별도의 커밋으로 유지하세요"
```
# 커밋 수 제한하기
git-smart-squash -i "총 3개의 커밋만 생성"

```

### 더 나은 결과를 위한 팁
- **구체적으로 작성하세요**: "데이터베이스 마이그레이션을 별도로 그룹화"가 "깔끔하게 정리"보다 더 효과적입니다
- **한 번에 한 가지 지시만**: 복잡한 다중 지시는 일부만 무시될 수 있습니다
- **더 나은 모델 사용**: 더 큰 모델이 작은 모델보다 지시를 더 잘 따릅니다

## 일반적인 사용 사례

### "PR 리뷰 전에 커밋을 정리하고 싶어요"
```bash
git-smart-squash              # 계획을 보여주고 확인을 요청합니다
git-smart-squash --auto-apply # 확인 없이 자동으로 적용합니다
```

### "메인 브랜치가 다를 때 사용해요"
```bash
git-smart-squash --base develop
```
### "특정 AI 공급자를 사용하고 싶습니다"
```bash
git-smart-squash --ai-provider openai
```

## 안전

**당신의 코드는 안전합니다:**
- 변경 사항을 적용하기 전에 계획을 보여줍니다
- 자동 백업 브랜치를 생성합니다
- 작업 디렉토리가 깨끗해야 합니다
- 사용자의 명령 없이 절대 푸시하지 않습니다

**문제가 발생한 경우:**
```bash
# 백업 찾기
git branch | grep backup

# 복원
git reset --hard your-branch-backup-[timestamp]
```

## AI 제공자

| 제공자      | 비용    | 프라이버시 |
|-------------|---------|------------|
| **Ollama**  | 무료    | 로컬       |
| **OpenAI**  | 약 $0.01 | 클라우드   |
| **Anthropic** | 약 $0.01 | 클라우드   |
| **Gemini**  | 약 $0.01 | 클라우드   |

## 고급 설정 (선택 사항)

커스터마이즈하고 싶으신가요? 설정 파일을 생성하세요:

**프로젝트별** (`.git-smart-squash.yml` 파일을 저장소에 생성):
```yaml
ai:
  provider: openai  # 이 프로젝트에 OpenAI 사용
base: develop       # 이 프로젝트의 기본 브랜치를 develop으로 사용
```
**Global default** (`~/.git-smart-squash.yml`):
```yaml
ai:
  provider: local   # 항상 로컬 AI를 기본값으로 사용
base: main          # 모든 프로젝트의 기본 베이스 브랜치
```

## 문제 해결

### "Invalid JSON" 오류
이 오류는 보통 AI 모델이 응답을 올바르게 포맷하지 못했을 때 발생합니다:
- **Ollama 사용 시**: `llama2`에서 `mistral` 또는 `mixtral`로 전환
- **해결 방법**: `ollama pull mistral` 실행 후 재시도
- **대안**: `--ai-provider openai` 옵션으로 클라우드 공급자 사용

### 모델이 지시를 따르지 않음
일부 모델은 복잡한 지시를 잘 처리하지 못합니다:
- **더 좋은 모델 사용**: `--model gpt-4-turbo` 또는 `--model claude-3-opus`
- **지시를 단순화**: 여러 지시보다 명확한 하나의 지시가 더 효과적임
- **명확하게 작성**: "앞에 [ABC-123]을 붙이세요"처럼 구체적으로 작성 (단순히 "티켓 번호 추가"보다 명확하게)
### "Ollama를 찾을 수 없음"
```bash
# https://ollama.com에서 설치
ollama serve
ollama pull devstral  # 기본 모델
```

### 커밋 그룹화가 미흡함
AI가 너무 많은 커밋을 생성하거나 잘 그룹화하지 못한다면:
- **모델이 충분하지 않음**: 더 큰 모델을 사용하세요
- **지침 추가**: `-i "관련 변경 사항을 그룹화하고, 최대 3개의 커밋으로 제한"`
- **피드백 제공**: GitHub에 이슈를 생성하여 어떤 일이 있었는지 알려주세요

### 설치 문제 (Mac)
pip이 없거나 격리된 설치를 선호한다면:
```bash
# pipx 사용 (권장)
brew install pipx
pipx install git-smart-squash
```
### "재구성할 변경 사항 없음"
```bash
git log --oneline main..HEAD  # 커밋이 있는지 확인
git diff main                 # 변경 사항이 있는지 확인
```

### 대용량 Diff / 토큰 제한
로컬 모델에는 약 32k 토큰 제한이 있습니다. 대규모 변경의 경우:
- 더 최근 커밋과 함께 `--base` 사용
- 클라우드로 전환: `--ai-provider openai`
- 더 작은 PR로 분할

### 추가 도움이 필요하신가요?

[자세한 문서](https://raw.githubusercontent.com/edverma/git-smart-squash/main/DOCUMENTATION.md)를 확인하거나 이슈를 등록하세요!

## 라이선스

MIT 라이선스 - 자세한 내용은 [LICENSE](LICENSE) 파일을 참조하세요.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-12

---