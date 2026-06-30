<p align="center">
  <img src="https://raw.githubusercontent.com/sasdsamatt123/claudex/main/docs/cover.jpg" alt="claudex — one terminal, six providers, bring your own key" width="100%">
</p>

# claudex

> **Claude Code'u 한 터미널에서 다중 계정 + 다중 공급자(Anthropic, Z.ai, MiniMax, DeepSeek, Moonshot, OpenRouter…)와 함께 사용하세요. 직접 키를 가져오세요.**

`claudex`는 [Claude Code](https://www.anthropic.com/claude-code)의 자체 `ANTHROPIC_BASE_URL` / `CLAUDE_CONFIG_DIR` 환경 변수 오버라이드 메커니즘 위에 구축된 — **프록시 없음, 라우터 없음** 솔루션입니다. 단일 명령어로 새로운 `claudeX` 별칭을 추가합니다: 자신의 API 키를 입력하고, 공급자와 모델을 선택하면 준비 완료입니다.

[아래에서 영어 버전 보기 ↓](#english)

---

## 🇹🇷 Türkçe

### Neden?

- DeepSeek / Z.ai / MiniMax 같은 **훨씬 저렴하거나 무료인** Anthropic 호환 공급자를 Claude Code를 통해 사용
- 여러 개의 **별도 청구** API 계정(예: 개인 + 회사)을 하나의 터미널에서, 격리된 `CLAUDE_CONFIG_DIR`로 관리
- 모든 것이 Claude Code의 자체 UI/스킬/MCP/에이전트 환경 내에서, 모델과 키만 바뀜

> ⚠️ **이 도구는 Anthropic Pro/Max 구독을 여러 사용자에게 배포하거나 계정별 속도 제한을 우회하기 위한 것이 아닙니다.** Anthropic [소비자 약관](https://www.anthropic.com/legal/consumer-terms) 및 [사용 정책](https://www.anthropic.com/legal/aup)에서 이를 금지합니다. `claudex`는 단지 **별도 권한 부여된** 공급자 계정 / API 키를 독립적인 프로필로 관리합니다.

### 전제 조건

| 필요 | 설치 방법 |
|---|---|
| Node.js 20+ | https://nodejs.org/ |
| Claude Code | `npm install -g @anthropic-ai/claude-code` |
| zsh 또는 bash | macOS / Linux 기본 셸 |

### 설치 (30초)

```bash
git clone https://github.com/sasdsamatt123/claudex.git
cd claudex
npm install && npm run build && npm link
claudex init
```

> ℹ️ `npm install -g claudex` 곧 출시 예정. 현재는 `git clone` 사용.

### 첫 번째 프로필 (가이드 포함)

```bash
claudex quickstart
```
Z.ai → MiniMax → OpenRouter 순서로 진행합니다. 각 단계에서:  
- Key URL을 보여줍니다 (등록 → API 키 생성)  
- Key를 붙여넣습니다 (비밀)  
- "건너뛰고 싶어요" → 엔터 → 건너뜁니다  
끝나면 `source ~/.zshrc` → `claude-zai` (또는 `claude-minimax`, `claude-or`)를 입력하면 Claude Code가 시작됩니다.  

### 어떤 모델을 선택할까요?


```bash
claudex recommend
```
인터랙티브: "무엇을 하고 싶습니까?" → 8가지 사용 사례 (빠른 코드 / 리팩토링 / 긴 컨텍스트 / 비전 / …). 상위 3개 제안을 근거와 함께 보여주고, 생성할 명령어를 출력합니다.

또는 비인터랙티브:

```bash
claudex recommend coding-fast --json
```

### 결정 트리

```
Ücretsiz?
├── Süresiz ücretsiz model → claudex add <name> --provider zai
├── 32 ücretsiz modelin biri → claudex add <name> --provider openrouter
└── Trial (Kasım 7 2026'a kadar) → claudex add <name> --provider minimax

Ucuz ödemeli?
└── DeepSeek (~10x Sonnet'ten ucuz) → claudex add <name> --provider deepseek

Birden fazla ayrı-faturalı Anthropic API hesabı (kişisel/şirket/proje izolasyonu)?
└── claudex add <name> --provider anthropic --no-share
```

### 모든 명령어

```bash
claudex init                       # ilk kurulum (~/.claudex + shell rc block)
claudex quickstart                 # 3 ücretsiz sağlayıcı için kılavuzlu setup
claudex recommend [<intent>]       # ne yapmak istediğine göre top-3 model önerisi
claudex add <isim> [-p <provider>] # yeni alias (interactive)
claudex validate <isim>            # 1-token ping ile key + model doğrula
claudex list                       # tüm profilleri listele
claudex remove <isim>              # alias kaldır
claudex providers [info <id>]      # sağlayıcı kataloğu
claudex export <isim> [-o file]    # redacted JSON template (key olmadan)
claudex import <file>              # template'i yükle, key sor, profil oluştur
claudex doctor                     # kurulum sağlığı
claudex --lang en                  # İngilizce output
```

### 번들 제공자

| ID | 등급 | 사이트 | 기본값 |
|----|------|--------|---------|
| `anthropic` | 공식 | https://console.anthropic.com | (기본) |
| `zai` | **영구 무료** | https://z.ai | GLM-4.7-Flash |
| `minimax` | **무료 체험** (2026년 11월 7일) | https://platform.minimax.io | M2.7 |
| `deepseek` | 저렴한 유료 | https://platform.deepseek.com | deepseek-v4-pro |
| `moonshot` | 유료 (롱 컨텍스트 전문가) | https://platform.moonshot.ai | Kimi K2.5 |
| `openrouter` | 32개 무료 모델 | https://openrouter.ai | qwen3-coder:free |

모두 **Anthropic 호환** 엔드포인트를 가짐 — 프록시 불필요. 자세한 내용 → [docs/PROVIDERS.md](https://raw.githubusercontent.com/sasdsamatt123/claudex/main/docs/PROVIDERS.md).

### 작동 방식

Claude Code는 5개의 환경 변수를 봄:
- `CLAUDE_CONFIG_DIR` — 세션, 히스토리, 사용자 상태 저장 위치
- `ANTHROPIC_BASE_URL` — API 엔드포인트 (기본값: api.anthropic.com)
- `ANTHROPIC_AUTH_TOKEN` — 엔드포인트 키
- `ANTHROPIC_MODEL`, `ANTHROPIC_SMALL_FAST_MODEL` — 메인 + 소형 모델

`claudex add`는 각 프로필에 셸 함수를 생성함. 함수는 `.env`에서 키를 읽고, 환경 변수를 설정하며, `claude` 바이너리를 호출함. 키는 argv에 나타나지 않고, 히스토리에 기록되지 않음.

### 파일 구조

```
~/.claudex/
├── profiles/<isim>/
│   ├── .env                # API key (mode 0600)
│   └── (CLAUDE_CONFIG_DIR — symlink veya isolated)
├── generated/aliases.sh    # ~/.zshrc tarafından source edilir
└── backups/                # her rc edit'inde otomatik backup
```

Mevcut `~/.claude/` 와 공유: 기본적으로 agents/commands/skills/plugins/CLAUDE.md/settings.json/mcp.json **심볼릭 링크**됨 → 모든 프로필에서 동일한 도구 사용. `--no-share` 옵션으로 완전히 분리된 프로필 생성.

### 보안

- 키는 `~/.claudex/profiles/<이름>/.env`, 모드 0600 으로 저장
- `claudex` 저장소에 어떤 키도 커밋되지 않음 (자동 `.gitignore` 적용)
- 자세한 내용 → [docs/SECURITY.md](https://raw.githubusercontent.com/sasdsamatt123/claudex/main/docs/SECURITY.md)

### 신규 공급자 추가하기

[`src/templates/providers.json`](https://raw.githubusercontent.com/sasdsamatt123/claudex/main/src/templates/providers.json) 에 JSON 항목 추가 후 PR 생성. 코드 변경 불필요. 자세한 내용 → [CONTRIBUTING.md](https://raw.githubusercontent.com/sasdsamatt123/claudex/main/CONTRIBUTING.md).

### 로드맵 (v0.3+)

- `claudex bench` — 프로필 간 지연 시간/비용 비교
- macOS 키체인 암호화 비밀 저장 (옵트인)
- 비용 추적 — Claude Code 로그에서 토큰 수 계산
- 탭 완성 (zsh/bash/fish 지원)
- Anthropic 비호환 공급자 (Groq, Gemini 직접) 위한 claude-code-router 프록시 모드

### 법적 고지

`claudex` 는 **독립적인** 오픈소스 도구입니다. Anthropic, Z.ai, MiniMax, DeepSeek, Moonshot, OpenRouter 또는 기타 공급자와 관련 없으며 승인받지 않았습니다. 공급자 이용 약관 준수는 사용자 책임입니다.

---

## 영어

### 왜?

- Claude Code를 통해 **훨씬 저렴하거나 무료인** Anthropic 호환 공급자(DeepSeek, Z.ai, MiniMax, OpenRouter 등)를 사용
- 여러 개의 **별도 청구되는** API 계정(예: 개인 + 회사)을 하나의 터미널에서 격리된 `CLAUDE_CONFIG_DIR` 로 관리
- 모든 것이 Claude Code의 UI/기능/MCP/에이전트 생태계 내에 유지됨 — 변경되는 것은 모델과 키뿐

> ⚠️ **이것은 Anthropic Pro/Max 구독을 사용자 간에 공유하거나 복제하는 방법이 아니며, 계정별 속도 제한을 우회하는 방법도 아닙니다.** Anthropic의 [소비자 약관](https://www.anthropic.com/legal/consumer-terms) 및 [사용 정책](https://www.anthropic.com/legal/aup)에서 금지하고 있습니다. `claudex` 는 **별도로 권한 부여된** 공급자 계정 / API 키를 독립 프로필로 관리합니다.

### 사전 요구사항

- Node.js 20 이상 — https://nodejs.org/
- Claude Code — `npm install -g @anthropic-ai/claude-code`
- zsh 또는 bash

### 설치 (30초)

```bash
git clone https://github.com/sasdsamatt123/claudex.git
cd claudex
npm install && npm run build && npm link
claudex init
```

> ℹ️ `npm install -g claudex` 게시 예정입니다. 현재는 git clone을 사용하세요.

### 첫 번째 프로필 (가이드)

```bash
claudex quickstart
```
Z.ai → MiniMax → OpenRouter를 안내합니다 (건너뛰기 가능). 완료되면: `source ~/.zshrc`를 실행한 후, `claude-zai` (또는 `claude-minimax`, `claude-or`)를 실행하여 새 모델로 Claude Code를 시작합니다.

### 어떤 모델인가요?


```bash
claudex recommend
```
인터랙티브: "무엇을 하시겠습니까?" → 8가지 사용 사례(빠른 코딩 / 리팩토링 / 긴 컨텍스트 / 비전 / …). 상위 3개와 그 이유 및 설치 명령어를 표시합니다.

비인터랙티브:

```bash
claudex recommend coding-fast --json
```

### 결정 트리

```
Free?
├── Forever-free model → claudex add <name> --provider zai
├── One of 32 free models → claudex add <name> --provider openrouter
└── Trial (until Nov 7 2026) → claudex add <name> --provider minimax

Cheap paid?
└── DeepSeek (~10x cheaper than Sonnet) → claudex add <name> --provider deepseek

Multiple separately-billed Anthropic API accounts (personal/company/project isolation)?
└── claudex add <name> --provider anthropic --no-share
```

### 명령어

```bash
claudex init                        # initial setup (~/.claudex + shell rc block)
claudex quickstart                  # guided setup of 3 free providers
claudex recommend [<intent>]        # top-3 model suggestions per use case
claudex add <name> [-p <provider>]  # add an alias (interactive)
claudex validate <name>             # ping the provider with a 1-token test
claudex list                        # list all profiles
claudex remove <name>               # remove alias
claudex providers [info <id>]       # provider catalog
claudex export <name> [-o file]     # redacted JSON template (no key)
claudex import <file>               # load template, prompt for key
claudex doctor                      # health check
claudex --lang tr                   # Turkish output
```

### 면책 조항

`claudex`는 독립적인 오픈 소스 도구입니다. **Anthropic, Z.ai, MiniMax, DeepSeek, Moonshot, OpenRouter 또는 기타 제공업체와 제휴, 승인, 후원하지 않습니다.** 각 제공업체의 서비스 약관 준수는 사용자 책임입니다.

### 라이선스

[MIT](LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-30

---