<h1 align="center"><img src="https://raw.githubusercontent.com/HKUDS/CLI-Anything/main/assets/icon.png" alt="" width="64" style="vertical-align: middle;">&nbsp; CLI-Anything: 모든 소프트웨어를 에이전트 네이티브로 만들기</h1>

<p align="center">
  <strong>오늘날의 소프트웨어는 인간을 위해 작동합니다👨‍💻. 내일의 사용자는 에이전트가 될 것입니다🤖.<br>
CLI-Anything: AI 에이전트와 전 세계 소프트웨어 간의 격차를 연결합니다</strong><br>
</p>

**🌐 [CLI-Hub](https://hkuds.github.io/CLI-Anything/)**: 커뮤니티에서 만든 모든 CLI를 탐색하고 한 번의 명령으로 설치하세요. **[CLI-Hub](https://hkuds.github.io/CLI-Anything/)**에서 가능합니다. 자신만의 CLI를 추가하고 싶나요? [PR을 열어주세요](https://github.com/HKUDS/CLI-Anything/blob/main/CONTRIBUTING.md) — 허브는 즉시 업데이트됩니다.

<p align="center">
  <a href="#-quick-start"><img src="https://img.shields.io/badge/Quick_Start-5_min-blue?style=for-the-badge" alt="Quick Start"></a>
  <a href="https://hkuds.github.io/CLI-Anything/"><img src="https://img.shields.io/badge/CLI_Hub-Browse_%26_Install-ff69b4?style=for-the-badge" alt="CLI Hub"></a>
  <a href="#-demonstrations"><img src="https://img.shields.io/badge/Demos-16_Apps-green?style=for-the-badge" alt="Demos"></a>
  <a href="#-test-results"><img src="https://img.shields.io/badge/Tests-1%2C839_Passing-brightgreen?style=for-the-badge" alt="Tests"></a>
  <a href="LICENSE"><img src="https://img.shields.io/badge/License-MIT-yellow?style=for-the-badge" alt="License"></a>
</p>

<p align="center">
  <img src="https://img.shields.io/badge/python-≥3.10-blue?logo=python&logoColor=white" alt="Python">
  <img src="https://img.shields.io/badge/click-≥8.0-green" alt="Click">
  <img src="https://img.shields.io/badge/pytest-100%25_pass-brightgreen" alt="Pytest">
  <img src="https://img.shields.io/badge/coverage-unit_%2B_e2e-orange" alt="Coverage">
  <img src="https://img.shields.io/badge/output-JSON_%2B_Human-blueviolet" alt="Output">
  <a href="https://github.com/HKUDS/.github/blob/main/profile/README.md"><img src="https://img.shields.io/badge/Feishu-Group-E9DBFC?style=flat&logo=feishu&logoColor=white" alt="Feishu"></a>
<a href="https://github.com/HKUDS/.github/blob/main/profile/README.md"><img src="https://img.shields.io/badge/WeChat-Group-C5EAB4?style=flat&logo=wechat&logoColor=white" alt="WeChat"></a>
</p>

**원 커맨드 라인**: OpenClaw, nanobot, Cursor, Claude Code 등 모든 소프트웨어를 에이전트 준비 상태로 만드세요.&nbsp;&nbsp;[**중문 문서**](https://raw.githubusercontent.com/HKUDS/CLI-Anything/main/README_CN.md) | [**일본어 문서**](https://raw.githubusercontent.com/HKUDS/CLI-Anything/main/README_JA.md)

<p align="center">
  <img src="https://raw.githubusercontent.com/HKUDS/CLI-Anything/main/assets/cli-typing.gif" alt="CLI-Anything typing demo" width="800">
</p>

<p align="center">
  <img src="https://raw.githubusercontent.com/HKUDS/CLI-Anything/main/assets/teaser.png" alt="CLI-Anything Teaser" width="800">
</p>

---

## 📰 뉴스
> 커뮤니티의 소중한 노력 덕분에 감사합니다! 매일 지속적인 업데이트가 이어지고 있습니다..

- **2026-03-23** 🤖 **CLI-Hub 메타스킬** 출시 — 에이전트가 이제 [`cli-hub-meta-skill/SKILL.md`](https://raw.githubusercontent.com/HKUDS/CLI-Anything/main/cli-hub-meta-skill/SKILL.md)를 통해 CLI를 자율적으로 검색하고 설치할 수 있습니다. 카탈로그는 GitHub Actions를 통해 `registry.json`에서 자동으로 업데이트되어 전체 마켓플레이스가 에이전트 네이티브로 작동합니다.

- **2026-03-22** 🎵 **MuseScore CLI**가 전조, 내보내기, 악기 관리 기능과 통합되었습니다. 커뮤니티 기여로 도메인 커버리지가 계속 확장되고 있습니다.

- **2026-03-21** 🔧 인프라 개선 — 여러 CLI 전반에 걸쳐 테스트 하니스 및 문서가 정제되었습니다. 여러 백엔드의 Windows 호환성이 향상되었습니다.

- **2026-03-20** 🌐 OpenAI 호환 API 액세스를 위한 **Novita AI** CLI 추가. 허브 검색을 위한 레지스트리 메타데이터 개선.

- **2026-03-19** 📦 하니스 전반에 걸친 패키지 구조 정제. 명령어 문서화가 개선된 SKILL.md 생성 향상.

- **2026-03-18** 🧪 테스트 커버리지 확장 — 여러 CLI에 걸쳐 추가 E2E 시나리오 및 엣지 케이스 검증 포함.

- **2026-03-17** 🌐 **[CLI-Hub](https://hkuds.github.io/CLI-Anything/)** 출시 — 중앙 레지스트리로, 단일 `pip` 명령어로 모든 CLI를 탐색, 검색 및 설치할 수 있습니다. 기여자는 `registry.json` 항목이 포함된 PR을 열어 새 CLI를 추가하거나 기존 것을 업데이트할 수 있습니다. 허브는 병합 시 자동으로 업데이트됩니다.

<details>
<summary>이전 소식</summary>

- **2026-03-16** 🤖 **SKILL.md 생성** 추가 (6.5단계) — 이제 생성된 모든 CLI는 Python 패키지 내에 AI가 탐색 가능한 스킬 정의를 포함합니다. ReplSkin은 `pip install` 후 스킬 파일을 자동 감지하며 REPL 배너에 절대 경로를 표시해 에이전트가 인식할 수 있게 합니다. `skill_generator.py`, Jinja2 템플릿, 모든 setup.py 파일 내 `package_data`, 51개의 신규 테스트 포함.

- **2026-03-15** 🐾 커뮤니티의 **OpenClaw** 지원 추가! Windows bash 환경에서 CLI-Anything이 안정적으로 작동하도록 Windows `cygpath` 보호 기능 병합. 커뮤니티 기여로 크로스 플랫폼 지원이 계속 강화되고 있습니다.

- **2026-03-14** 🔒 GIMP Script-Fu 경로 주입 취약점 수정 및 **일본어 README** 번역 추가. OpenCode 버전 요구사항 문서화 및 여러 Windows 호환성 개선 포함.

- **2026-03-13** 🔌 커뮤니티 기여로 **Qodercli** 플러그인 공식 병합, 전용 설치 스크립트 포함. Codex 스킬에 Windows 설치 스크립트 추가, 프로젝트 전반의 플레이스홀더 URL 정리.

- **2026-03-12** 📦 CLI-Anything을 또 다른 AI 코딩 플랫폼에 연결하는 **Codex 스킬** 통합 완료. Qodercli 지원도 도입되었으며 제한사항 및 실험적 라벨을 포함한 문서 업데이트.

- **2026-03-11** 📞 11번째 지원 애플리케이션으로 **Zoom** 화상회의 하니스 추가. Shotcut 자동 저장, LibreOffice Windows/macOS 백엔드, OpenCode 지원 관련 다수의 커뮤니티 수정사항 배포.

</details>

---

## 🤔 왜 CLI인가?

CLI는 인간과 AI 에이전트 모두를 위한 보편적인 인터페이스입니다:


• **구조적이고 조합 가능함** - 텍스트 명령어가 LLM 형식과 일치하며 복잡한 워크플로우를 연결 가능

• **경량 및 범용** - 최소한의 오버헤드, 종속성 없이 모든 시스템에서 작동

• **자기 설명적** - --help 플래그가 자동 문서화를 제공하여 에이전트가 발견 가능

• **검증된 성공 사례** - Claude Code는 매일 수천 개의 실제 워크플로우를 CLI를 통해 실행

• **에이전트 우선 설계** - 구조화된 JSON 출력으로 파싱 복잡성 제거

• **결정적이고 신뢰 가능함** - 일관된 결과로 예측 가능한 에이전트 동작 가능

## 🚀 빠른 시작

### 사전 준비 사항

- **Python 3.10 이상**
- 대상 소프트웨어 설치 (예: GIMP, Blender, LibreOffice 또는 사용자 자체 애플리케이션)
- 지원되는 AI 코딩 에이전트: [Claude Code](#-claude-code) | [OpenClaw](#-openclaw) | [OpenCode](#-opencode) | [Codex](#-codex) | [Qodercli](#-qodercli) | [GitHub Copilot CLI](#-github-copilot-cli) | [추가 플랫폼](#-more-platforms-coming-soon)

### 플랫폼 선택하기

<details open>
<summary><h4 id="-claude-code">⚡ Claude Code</h4></summary>

**1단계: 마켓플레이스 추가**

CLI-Anything은 GitHub에 호스팅된 Claude Code 플러그인 마켓플레이스로 배포됩니다.

```bash
# Add the CLI-Anything marketplace
/plugin marketplace add HKUDS/CLI-Anything
```

**2단계: 플러그인 설치하기**

```bash
# Install the cli-anything plugin from the marketplace
/plugin install cli-anything
```

이게 전부입니다. 이제 플러그인이 클로드 코드 세션에서 사용 가능합니다.

> **윈도우 사용자 주의:** 클로드 코드는 `bash`를 통해 셸 명령을 실행합니다. 윈도우에서는 Git for Windows( `bash`와 `cygpath` 포함)를 설치하거나 WSL을 사용하세요. 그렇지 않으면 `cygpath: command not found` 오류가 발생할 수 있습니다.

**3단계: 한 명령어로 CLI 빌드하기**


```bash
# /cli-anything:cli-anything <software-path-or-repo>
# Generate a complete CLI for GIMP (all 7 phases)
/cli-anything:cli-anything ./gimp

# Note: If your Claude Code is under 2.x, use "/cli-anything" instead.
```
이 파이프라인을 전체 실행합니다:  
1. 🔍 **분석** — 소스 코드를 스캔하고 GUI 동작을 API에 매핑  
2. 📐 **설계** — 명령 그룹, 상태 모델, 출력 형식을 설계  
3. 🔨 **구현** — REPL, JSON 출력, 실행 취소/재실행 기능이 포함된 Click CLI 구축  
4. 📋 **테스트 계획** — 단위 및 E2E 테스트 계획이 담긴 TEST.md 생성  
5. 🧪 **테스트 작성** — 포괄적인 테스트 스위트 구현  
6. 📝 **문서화** — 결과를 반영해 TEST.md 업데이트  
7. 📦 **배포** — `setup.py` 생성, PATH에 설치  

**4단계 (선택 사항): CLI 정제 및 개선**  

초기 빌드 후 CLI를 반복적으로 정제하여 적용 범위를 확장하고 누락된 기능을 추가할 수 있습니다:


```bash
# Broad refinement — agent analyzes gaps across all capabilities
/cli-anything:refine ./gimp

# Focused refinement — target a specific functionality area
/cli-anything:refine ./gimp "I want more CLIs on image batch processing and filters"
```

refine 명령어는 소프트웨어의 전체 기능과 현재 CLI 커버리지 간의 갭 분석을 수행한 후, 식별된 갭에 대해 새로운 명령어, 테스트 및 문서를 구현합니다. 여러 번 실행하여 커버리지를 점진적으로 확장할 수 있으며, 각 실행은 증분적이고 비파괴적입니다.

<details>
<summary><strong>대안: 수동 설치</strong></summary>

마켓플레이스를 사용하지 않으려면:

```bash
# Clone the repo
git clone https://github.com/HKUDS/CLI-Anything.git

# Copy plugin to Claude Code plugins directory
cp -r CLI-Anything/cli-anything-plugin ~/.claude/plugins/cli-anything

# Reload plugins
/reload-plugins
```

</details>

</details>

<details>
<summary><h4 id="-opencode">⚡ OpenCode (실험적)</h4></summary>

**1단계: 명령어 설치하기**

> **참고:** 최신 OpenCode로 업그레이드하세요. 이전 버전은 명령어 경로가 다를 수 있습니다.

CLI-Anything 명령어 **및** `HARNESS.md` 파일을 OpenCode 명령어 디렉토리에 복사하세요:

```bash
# Clone the repo
git clone https://github.com/HKUDS/CLI-Anything.git

# Global install (available in all projects)
cp CLI-Anything/opencode-commands/*.md ~/.config/opencode/commands/
cp CLI-Anything/cli-anything-plugin/HARNESS.md ~/.config/opencode/commands/

# Or project-level install
cp CLI-Anything/opencode-commands/*.md .opencode/commands/
cp CLI-Anything/cli-anything-plugin/HARNESS.md .opencode/commands/
```

> **참고:** `HARNESS.md`는 모든 명령어가 참조하는 방법론 명세서입니다. 명령어와 동일한 디렉터리에 있어야 합니다.

이 명령어는 5개의 슬래시 명령어를 추가합니다: `/cli-anything`, `/cli-anything-refine`, `/cli-anything-test`, `/cli-anything-validate`, 그리고 `/cli-anything-list`.

**2단계: 한 명령어로 CLI 빌드하기**

```bash
# Generate a complete CLI for GIMP (all 7 phases)
/cli-anything ./gimp

# Build from a GitHub repo
/cli-anything https://github.com/blender/blender
```
명령은 하위 작업으로 실행되며 Claude Code와 동일한 7단계 방법론을 따릅니다.

**3단계 (선택 사항): CLI 개선 및 정제**


```bash
# Broad refinement — agent analyzes gaps across all capabilities
/cli-anything-refine ./gimp

# Focused refinement — target a specific functionality area
/cli-anything-refine ./gimp "batch processing and filters"
```
</details>

<details>
<summary><h4 id="-goose">⚡ Goose (데스크톱 / CLI) <sup><code>실험적</code></sup> <sup><code>커뮤니티</code></sup></h4></summary>

**1단계: Goose 설치**

운영 체제에 맞는 공식 Goose 지침을 따라 Goose(데스크톱 또는 CLI)를 설치하세요.

**2단계: CLI 공급자 구성**

Goose가 Claude Code와 같은 CLI 공급자를 사용하도록 구성하고 CLI가 설치되어 인증되었는지 확인하세요.

**3단계: Goose 세션에서 CLI-Anything 사용**

Goose가 구성되면 세션을 시작하고 위에서 설명한 Claude Code용 CLI-Anything 명령어를 사용하세요. 예를 들어:  


```bash
/cli-anything:cli-anything ./gimp
/cli-anything:refine ./gimp "batch processing and filters"
```

> 참고: Goose가 CLI 공급자를 통해 실행될 때, 해당 공급자의 기능과 명령 형식을 사용합니다.
</details>

<details>

<summary><h4 id="-qodercli">⚡ Qodercli <sup><code>커뮤니티</code></sup></h4></summary>

**1단계: 플러그인 등록하기**

```bash
git clone https://github.com/HKUDS/CLI-Anything.git
bash CLI-Anything/qoder-plugin/setup-qodercli.sh
```
이 명령은 `~/.qoder.json`에 cli-anything 플러그인을 등록합니다. 등록 후 새로운 Qodercli 세션을 시작하세요.

**2단계: Qodercli에서 CLI-Anything 사용하기**


```bash
/cli-anything:cli-anything ./gimp
/cli-anything:refine ./gimp "batch processing and filters"
/cli-anything:validate ./gimp
```
</details>

<details>

<summary><h4 id="-openclaw">⚡ OpenClaw <sup><code>Community</code></sup></h4></summary>

**1단계: 스킬 설치**

CLI-Anything은 기본 OpenClaw `SKILL.md` 파일을 제공합니다. 이를 OpenClaw 스킬 디렉토리에 복사하세요:

```bash
# Clone the repo
git clone https://github.com/HKUDS/CLI-Anything.git

# Install to the global skills folder
mkdir -p ~/.openclaw/skills/cli-anything
cp CLI-Anything/openclaw-skill/SKILL.md ~/.openclaw/skills/cli-anything/SKILL.md
```

**2단계: CLI 빌드하기**

이제 OpenClaw 내에서 스킬을 호출할 수 있습니다:

`@cli-anything build a CLI for ./gimp`

이 스킬은 Claude Code와 OpenCode와 동일한 7단계 방법론을 따릅니다.

</details>

<details>

<summary><h4 id="-codex">⚡ Codex <sup><code>실험적</code></sup> <sup><code>커뮤니티</code></sup></h4></summary>

**1단계: 스킬 설치하기**

번들 설치 프로그램을 실행하세요:

```bash
# Clone the repo
git clone https://github.com/HKUDS/CLI-Anything.git

# Install the skill
bash CLI-Anything/codex-skill/scripts/install.sh
```
Windows PowerShell에서 다음을 사용하십시오:


```powershell
.\CLI-Anything\codex-skill\scripts\install.ps1
```
이 스킬은 `$CODEX_HOME/skills/cli-anything` (또는 `CODEX_HOME`이 설정되지 않은 경우 `~/.codex/skills/cli-anything`)에 설치됩니다.

설치 후 Codex를 재시작하여 스킬이 인식되도록 하세요.

**2단계: Codex에서 CLI-Anything 사용하기**

작업을 자연어로 설명하세요, 예를 들어:


```text
Use CLI-Anything to build a harness for ./gimp
Use CLI-Anything to refine ./shotcut for picture-in-picture workflows
Use CLI-Anything to validate ./libreoffice
```
Codex 스킬은 Claude Code 플러그인과 OpenCode 명령어에서 사용된 동일한 방법론을 적용하면서,
생성된 Python 하니스 형식을 변경하지 않고 유지합니다.
</details>

<details>

<summary><h4 id="-github-copilot-cli">⚡ GitHub Copilot CLI <sup><code>Community</code></sup></h4></summary>

**1단계: 플러그인 설치하기**


```bash
git clone https://github.com/HKUDS/CLI-Anything.git
cd CLI-Anything
copilot plugin install ./cli-anything-plugin
```
이 명령은 GitHub Copilot CLI에 CLI-Anything 플러그인을 설치합니다. 플러그인은 이제 GitHub Copilot CLI 세션에서 사용 가능합니다.

**2단계: GitHub Copilot CLI에서 CLI-Anything 사용하기**


```bash
/cli-anything:cli-anything ./gimp
/cli-anything:refine ./gimp "batch processing and filters"
/cli-anything:validate ./gimp
```
</details>

<details>
<summary><h4 id="-more-platforms-coming-soon">🔮 더 많은 플랫폼 (곧 출시 예정)</h4></summary>

CLI-Anything은 플랫폼에 구애받지 않도록 설계되었습니다. 더 많은 AI 코딩 에이전트 지원이 계획되어 있습니다:

- **Codex** — `codex-skill/`에 번들로 포함된 스킬을 통해 이용 가능
- **Cursor** — 곧 출시 예정
- **Windsurf** — 곧 출시 예정
- **당신이 좋아하는 도구** — 기여 환영! 참고 구현은 `opencode-commands/` 디렉터리를 참조하세요.

</details>

### 생성된 CLI 사용법

어떤 플랫폼으로 빌드했든, 생성된 CLI는 동일하게 작동합니다:


```bash
# Install to PATH
cd gimp/agent-harness && pip install -e .

# Use from anywhere
cli-anything-gimp --help
cli-anything-gimp project new --width 1920 --height 1080 -o poster.json
cli-anything-gimp --json layer add -n "Background" --type solid --color "#1a1a2e"

# Enter interactive REPL
cli-anything-gimp
```

각 설치된 CLI는 Python 패키지 내(`cli_anything/<software>/skills/SKILL.md`)에 [`SKILL.md`](#-skillmd-generation)를 포함하고 있습니다. REPL 배너는 이 파일의 절대 경로를 자동으로 표시하여 AI 에이전트가 스킬 정의를 정확히 어디서 읽어야 하는지 알 수 있게 합니다. 추가 설정은 필요 없습니다 — `pip install`로 스킬이 탐색 가능합니다.

---

## 🤖 CLI-Hub로 에이전트 강화하기

CLI-Hub는 에이전트가 필요로 하는 CLI를 자율적으로 발견하고 설치할 수 있게 해줍니다 — 인간의 개입이 전혀 필요 없습니다.

우리는 모든 AI 에이전트가 커뮤니티 CLI 전체 카탈로그를 자유롭게 탐색하고 작업에 맞는 적절한 CLI를 선택할 수 있는 **메타-스킬**을 공개했습니다.

**한 명령어로 설치하기:**

```bash
# OpenClaw
openclaw skills install cli-anything-hub

# nanobot
nanobot skills install cli-anything-hub
```

**그런 다음 에이전트에게 프롬프트를 입력하세요:**

```
Find appropriate CLI software in CLI-Hub and complete the task: <your task here>
```
에이전트는 카탈로그를 탐색하고, 작업에 맞는 CLI를 설치한 후, 이를 모두 자율적으로 사용합니다.

**내부 작동 방식:**

1. 메타 스킬은 라이브 카탈로그 [`https://hkuds.github.io/CLI-Anything/SKILL.txt`](https://hkuds.github.io/CLI-Anything/SKILL.txt)를 가리킵니다.
2. 에이전트는 카테고리별로 정리된 20개 이상의 CLI를 한 줄 `pip install` 명령어와 함께 읽습니다.
3. 에이전트는 작업에 맞는 CLI를 설치한 후, 해당 CLI의 상세 사용법이 담긴 SKILL.md를 읽습니다.

카탈로그는 `registry.json`이 변경될 때마다 자동으로 업데이트되어 새로운 커뮤니티 CLI가 자동으로 나타납니다.

> **Claude Code 사용자용:** 동일한 자동 CLI 탐색을 위해 [`cli-hub-meta-skill/SKILL.md`](https://raw.githubusercontent.com/HKUDS/CLI-Anything/main/cli-hub-meta-skill/SKILL.md)를 프로젝트 또는 스킬 디렉토리에 복사하세요.

---

## 💡 CLI-Anything의 비전: 에이전트 네이티브 소프트웨어 구축

• 🌐 **범용 접근성** - 모든 소프트웨어가 구조화된 CLI를 통해 즉시 에이전트 제어 가능해집니다.

• 🔗 **무결점 통합** - API, GUI, 재빌드 또는 복잡한 래퍼 없이 에이전트가 모든 애플리케이션을 제어합니다.

• 🚀 **미래 지향 생태계** - 인간이 설계한 소프트웨어를 단 한 명령으로 에이전트 네이티브 도구로 변환합니다.

---

## 🔧 CLI-Anything 사용 시기

| 카테고리 | 에이전트 네이티브화 방법 | 주요 예시 |
|----------|-------------------------|----------|
| **📂 GitHub 저장소** | 자동 CLI 생성으로 모든 오픈소스 프로젝트를 에이전트 제어 도구로 전환 | VSCodium, WordPress, Calibre, Zotero, Joplin, Logseq, Penpot, Super Productivity |
| **🤖 AI/ML 플랫폼** | 구조화된 명령어로 모델 학습, 추론 파이프라인, 하이퍼파라미터 튜닝 자동화 | Stable Diffusion WebUI, ComfyUI, Ollama, InvokeAI, Text-generation-webui, Open WebUI, Fooocus, Kohya_ss, AnythingLLM, SillyTavern |
| **📊 데이터 및 분석** | 프로그래밍 방식으로 데이터 처리, 시각화 및 통계 분석 워크플로우 지원 | JupyterLab, Apache Superset, Metabase, Redash, DBeaver, KNIME, Orange, OpenSearch Dashboards, Lightdash |
| **💻 개발 도구** | 명령 인터페이스로 코드 편집, 빌드, 테스트, 배포 프로세스 간소화 | Jenkins, Gitea, Hoppscotch, Portainer, pgAdmin, SonarQube, ArgoCD, OpenLens, Insomnia, Beekeeper Studio, **[iTerm2](https://iterm2.com)** |
| **🎨 크리에이티브 및 미디어** | 콘텐츠 생성, 편집, 렌더링 워크플로우를 프로그래밍 방식으로 제어 | Blender, GIMP, OBS Studio, Audacity, Krita, Kdenlive, Shotcut, Inkscape, Darktable, LMMS, Ardour |
| **🔬 과학 컴퓨팅** | 연구 워크플로우, 시뮬레이션 및 복잡한 계산 자동화 | ImageJ, FreeCAD, QGIS, ParaView, Gephi, LibreCAD, Stellarium, KiCad, JASP, Jamovi |
| **🏢 엔터프라이즈 및 오피스** | 비즈니스 애플리케이션 및 생산성 도구를 에이전트 접근 가능 시스템으로 변환 | NextCloud, GitLab, Grafana, Mattermost, LibreOffice, AppFlowy, NocoDB, Odoo (커뮤니티), Plane, ERPNext |
| **📞 커뮤니케이션 및 협업** | 구조화된 CLI를 통해 회의 일정, 참가자 관리, 녹화 검색 및 보고 자동화 | Zoom, Jitsi Meet, BigBlueButton, Mattermost |
| **📐 다이어그램 및 시각화** | 다이어그램, 플로우차트, 아키텍처 다이어그램 및 시각 문서 프로그래밍 생성 및 조작 | Draw.io (diagrams.net), Mermaid, PlantUML, Excalidraw, yEd |
| **🌐 네트워크 및 인프라** | 구조화된 CLI 명령어로 네트워크 서비스, DNS, 광고 차단 및 인프라 관리 | AdGuardHome |
| **🔬 그래픽 및 GPU 디버깅** | GPU 프레임 캡처 분석, 파이프라인 상태 검사, 셰이더 내보내기 및 렌더링 상태 차이 비교 | RenderDoc |

| **✨ AI 콘텐츠 생성** | AI 기반 클라우드 API를 통해 전문적인 결과물(슬라이드, 문서, 다이어그램, 웹사이트, 연구 보고서) 생성 | [AnyGen](https://www.anygen.io), Gamma, Beautiful.ai, Tome |

---

## CLI-Anything의 주요 기능

### 에이전트-소프트웨어 격차
AI 에이전트는 추론은 뛰어나지만 실제 전문 소프트웨어 사용에는 매우 취약합니다. 현재 솔루션은 깨지기 쉬운 UI 자동화, 제한된 API, 또는 90% 기능이 빠진 단순 구현에 불과합니다.

**CLI-Anything의 해결책**: 기능 손실 없이 모든 전문 소프트웨어를 에이전트 네이티브 도구로 변환합니다.

| **현재 문제점** | **CLI-Anything의 해결책** |
|----------|----------------------|
| 🤖 "AI가 실제 도구를 못 써요" | 실제 소프트웨어 백엔드(Blender, LibreOffice, FFmpeg)와 직접 통합 — 완전한 전문 기능, 타협 없음 |
| 💸 "UI 자동화가 자주 깨져요" | 스크린샷, 클릭, RPA 취약성 없음. 구조화된 인터페이스를 통한 순수 커맨드라인 신뢰성 |
| 📊 "에이전트는 구조화된 데이터가 필요해요" | 에이전트 소비에 최적화된 내장 JSON 출력 + 디버깅용 사람이 읽기 쉬운 형식 |
| 🔧 "맞춤 통합은 비용이 많이 들어요" | 하나의 Claude 플러그인으로 입증된 7단계 파이프라인을 통해 모든 코드베이스에 대한 CLI 자동 생성 |
| ⚡ "프로토타입과 프로덕션 격차" | 실제 소프트웨어 검증을 거친 1,839+ 테스트. 16개 주요 애플리케이션에서 검증 완료 |

---

## 🎯 CLI-Anything으로 무엇을 할 수 있나요?

<table>
<tr>
<td width="33%">

### 🛠️ 에이전트가 작업 흐름을 맡도록 하세요

전문가용이든 일상용이든 — 코드베이스를 `/cli-anything`에 넣기만 하세요. 창작 작업용 GIMP, Blender, Shotcut. 일상 업무용 LibreOffice, OBS Studio. 소스가 없나요? 오픈소스 대안을 찾아 넣으세요. 즉시 에이전트가 사용할 수 있는 완전한 CLI를 얻게 됩니다.

</td>
<td width="33%">

### 🔗 흩어진 API를 하나의 CLI로 통합

분산된 웹 서비스 API를 관리하기 지치셨나요? 문서나 SDK 매뉴얼을 `/cli-anything`에 입력하면, 에이전트는 개별 엔드포인트를 일관된 명령 그룹으로 감싸는 **강력하고 상태를 가진 CLI**를 얻게 됩니다. 수십 개의 원시 API 호출 대신 하나의 도구 — 토큰 절약과 강력한 기능 제공.

</td>
<td width="33%">

### 🚀 GUI 에이전트 대체 또는 강화

CLI-Anything은 GUI 기반 에이전트 방식을 완전히 **대체할 수 있습니다** — 더 이상 스크린샷이나 깨지기 쉬운 픽셀 클릭이 필요 없습니다. 하지만 재미있는 점은 이겁니다: GUI 소프트웨어에 `/cli-anything`을 적용하면, 코드와 터미널만으로 **에이전트 작업, 평가자, 벤치마크**를 완전히 합성할 수 있습니다 — 완전 자동화, 반복 개선 가능, 훨씬 더 효율적입니다.

</td>
</tr>
</table>

---

## ✨ ⚙️ CLI-Anything 작동 방식

<table>
<tr>
<td width="50%">

### 🏗️ 완전 자동화 7단계 파이프라인
코드베이스 분석부터 PyPI 배포까지 — 플러그인이 아키텍처 설계, 구현, 테스트 계획, 테스트 작성, 문서화를 완전히 자동으로 처리합니다.

</td>
<td width="50%">

### 🎯 진정한 소프트웨어 통합
실제 렌더링을 위한 실제 애플리케이션 직접 호출. LibreOffice는 PDF를 생성하고, Blender는 3D 장면을 렌더링하며, Audacity는 sox를 통해 오디오를 처리합니다. **타협 없음**, **장난감 구현 전혀 없음**.

</td>
</tr>
<tr>
<td width="50%">

### 🔁 스마트 세션 관리
실행 취소/재실행 기능이 있는 지속적인 프로젝트 상태 관리, 그리고 모든 CLI에서 일관된 인터랙티브 경험을 제공하는 통합 REPL 인터페이스(ReplSkin).

</td>
<td width="50%">

### 📦 제로 설정 설치
간단한 pip install -e . 명령으로 cli-anything-<software>를 직접 PATH에 추가합니다. 에이전트는 표준 which 명령을 통해 도구를 발견합니다. 설정 불필요, 래퍼 불필요.

</td>
</tr>
<tr>
<td width="50%">

### 🧪 프로덕션급 테스트
다층 검증: 합성 데이터로 단위 테스트, 실제 파일과 소프트웨어로 엔드투엔드 테스트, 설치된 명령어의 CLI 서브프로세스 검증 포함.

</td>
<td width="50%">

### 🐍 깔끔한 패키지 아키텍처
모든 CLI는 cli_anything.* 네임스페이스 하에 조직되어 충돌 없고, pip 설치 가능하며, 일관된 명명법: cli-anything-gimp, cli-anything-blender 등.

</td>
</tr>
</table>

### 🤖 SKILL.md 생성

각 생성된 CLI는 Python 패키지 내부 `cli_anything/<software>/skills/SKILL.md`에 `SKILL.md` 파일을 포함합니다. 이 자가 포함된 스킬 정의는 AI 에이전트가 Claude Code의 스킬 시스템이나 다른 에이전트 프레임워크를 통해 CLI를 발견하고 사용할 수 있게 합니다.

**SKILL.md가 제공하는 것:**
- **YAML 프론트매터**로 에이전트 스킬 발견을 위한 이름과 설명
- **명령 그룹**과 모든 하위 명령어 문서화
- **일반 워크플로우 사용 예시**
- **에이전트 전용 안내**: JSON 출력, 에러 처리, 프로그래밍적 사용법

SKILL.md 파일은 파이프라인 6.5단계에서 `skill_generator.py`를 사용해 CLI의 Click 데코레이터, setup.py, README에서 메타데이터를 직접 추출하여 자동 생성됩니다. 파일이 패키지 내에 위치해 있어 `pip install` 시 CLI와 함께 설치되고, REPL 배너에서 자동 감지됩니다 — 에이전트는 시작 시 표시되는 절대 경로를 읽을 수 있습니다.

---

## 🎬 데모

### 🎯 범용
CLI-Anything은 코드베이스가 있는 모든 소프트웨어에서 동작 — 도메인 제한이나 아키텍처 제한 없음.

### 🏭 프로페셔널급 테스트
창작, 생산성, 커뮤니케이션, 다이어그램, AI 이미지 생성, AI 콘텐츠 생성, 네트워크 광고 차단, 로컬 LLM 추론 등 AI 에이전트가 이전에 접근하지 못했던 16개의 다양하고 복잡한 애플리케이션에서 테스트 완료.

### 🎨 다양한 도메인 커버리지  
창의적 워크플로우(이미지 편집, 3D 모델링, 벡터 그래픽)부터 생산 도구(오디오, 오피스, 라이브 스트리밍, 비디오 편집)까지.  

### ✅ 완전한 CLI 생성  
각 애플리케이션은 완전한 프로덕션 준비 CLI 인터페이스를 받았습니다 — 데모가 아니라, 전체 기능을 유지하는 포괄적 도구 접근입니다.  

<table>  
<tr>  
<th align="center">소프트웨어</th>  
<th align="center">도메인</th>  
<th align="center">CLI 명령어</th>  
<th align="center">백엔드</th>  
<th align="center">테스트</th>  
</tr>  
<tr>  
<td align="center"><strong>🎨 GIMP</strong></td>  
<td>이미지 편집</td>  
<td><code>cli-anything-gimp</code></td>  
<td>Pillow + GEGL/Script-Fu</td>  
<td align="center">✅ 107</td>  
</tr>  
<tr>  
<td align="center"><strong>🧊 Blender</strong></td>  
<td>3D 모델링 및 렌더링</td>  
<td><code>cli-anything-blender</code></td>  
<td>bpy (파이썬 스크립팅)</td>  
<td align="center">✅ 208</td>  
</tr>  
<tr>  
<td align="center"><strong>✏️ Inkscape</strong></td>  
<td>벡터 그래픽</td>  
<td><code>cli-anything-inkscape</code></td>  
<td>직접 SVG/XML 조작</td>  
<td align="center">✅ 202</td>  
</tr>  
<tr>  
<td align="center"><strong>🎵 Audacity</strong></td>  
<td>오디오 제작</td>  
<td><code>cli-anything-audacity</code></td>  
<td>파이썬 wave + sox</td>
<td align="center">✅ 161</td>
</tr>
<tr>
<td align="center"><strong>🌐 브라우저</strong></td>
<td>브라우저 자동화</td>
<td><code>cli-anything-browser</code></td>
<td>DOMShell MCP + 접근성 트리</td>
<td align="center">✅ <a href="browser/agent-harness/">새로움</a></td>
</tr>
<tr>
<td align="center"><strong>📄 리브레오피스</strong></td>
<td>오피스 스위트 (라이터, 칼크, 임프레스)</td>
<td><code>cli-anything-libreoffice</code></td>
<td>ODF 생성 + 헤드리스 LO</td>
<td align="center">✅ 158</td>
</tr>
<tr>
<td align="center"><strong>📝 <a href="mubu/agent-harness/">무부</a></strong></td>
<td>지식 관리 및 개요 작성</td>
<td><code>cli-anything-mubu</code></td>
<td>로컬 무부 데이터 + 동기화 로그</td>
<td align="center">✅ 96</td>
</tr>
<tr>
<td align="center"><strong>📹 OBS 스튜디오</strong></td>
<td>라이브 스트리밍 및 녹화</td>
<td><code>cli-anything-obs-studio</code></td>
<td>JSON 씬 + obs-websocket</td>
<td align="center">✅ 153</td>
</tr>
<tr>
<td align="center"><strong>🎞️ 케이덴라이브</strong></td>
<td>비디오 편집</td>
<td><code>cli-anything-kdenlive</code></td>
<td>MLT XML + 멜트 렌더러</td>
<td align="center">✅ 155</td>
</tr>
<tr>
<td align="center"><strong>🎬 샷컷</strong></td>
<td>비디오 편집</td>
<td><code>cli-anything-shotcut</code></td>
<td>직접 MLT XML + melt</td>
<td align="center">✅ 154</td>
</tr>
<tr>
<td align="center"><strong>📞 Zoom</strong></td>
<td>영상 회의</td>
<td><code>cli-anything-zoom</code></td>
<td>Zoom REST API (OAuth2)</td>
<td align="center">✅ 22</td>
</tr>
<tr>
<td align="center"><strong>🎵 MuseScore</strong></td>
<td>음악 표기법</td>
<td><code>cli-anything-musescore</code></td>
<td>mscore CLI (MSCX/MusicXML)</td>
<td align="center">✅ 56</td>
</tr>
<tr>
<td align="center"><strong>📐 Draw.io</strong></td>
<td>다이어그램 작성</td>
<td><code>cli-anything-drawio</code></td>
<td>mxGraph XML + draw.io CLI</td>
<td align="center">✅ 138</td>
</tr>
<tr>
<td align="center"><strong>🧜 Mermaid Live Editor</strong></td>
<td>다이어그램 작성</td>
<td><code>cli-anything-mermaid</code></td>
<td>Mermaid 상태 + mermaid.ink 렌더러</td>
<td align="center">✅ 10</td>
</tr>
<tr>
<td align="center"><strong>✨ AnyGen</strong></td>
<td>AI 콘텐츠 생성</td>
<td><code>cli-anything-anygen</code></td>
<td>AnyGen REST API (anygen.io)</td>
<td align="center">✅ 50</td>
</tr>
<tr>
<td align="center"><strong>🧠 NotebookLM</strong></td>
<td>AI 연구 보조</td>
<td><code>cli-anything-notebooklm</code></td>
<td>NotebookLM CLI 래퍼 (실험적)</td>
<td align="center">✅ 21</td>
</tr>
<tr>
<td align="center"><strong>🖼️ ComfyUI</strong></td>
<td>AI 이미지 생성</td>
<td><code>cli-anything-comfyui</code></td>
<td>ComfyUI REST API</td>
<td align="center">✅ 70</td>
</tr>
<tr>
<td align="center"><strong>🛡️ AdGuard Home</strong></td>
<td>네트워크 전체 광고 차단</td>
<td><code>cli-anything-adguardhome</code></td>
<td>AdGuard Home REST API</td>
<td align="center">✅ 36</td>
</tr>
<tr>
<td align="center"><strong>🦙 Ollama</strong></td>
<td>로컬 LLM 추론</td>
<td><code>cli-anything-ollama</code></td>
<td>Ollama REST API</td>
<td align="center">✅ 98</td>
</tr>
<tr>
<td align="center"><strong>🎨 Sketch</strong></td>
<td>UI 디자인</td>
<td><code>sketch-cli</code></td>
<td>sketch-constructor (Node.js)</td>
<td align="center">✅ 19</td>
</tr>
<tr>
<td align="center" colspan="4"><strong>총합</strong></td>
<td align="center"><strong>✅ 1,858</strong></td>
</tr>
</table>

> **100% 통과율** 모든 1,858개 테스트에서 — 1,355개 단위 테스트 + 484개 종단 간 테스트 + 19개 Node.js 테스트.

---

## 📊 테스트 결과

각 CLI 하니스는 생산 신뢰성을 보장하기 위해 엄격한 다층 테스트를 거칩니다:

| 계층 | 테스트 대상 | 예시 |
|-------|---------------|---------|
| **단위 테스트** | 합성 데이터를 사용해 모든 핵심 기능을 개별 테스트 | `test_core.py` — 프로젝트 생성, 레이어 작업, 필터 매개변수 |
| **E2E 테스트 (네이티브)** | 프로젝트 파일 생성 파이프라인 | 유효한 ODF ZIP 구조, 올바른 MLT XML, SVG 형식 적합성 |
| **E2E 테스트 (실제 백엔드)** | 실제 소프트웨어 호출 + 출력 검증 | LibreOffice → `%PDF-` 매직 바이트 포함 PDF, Blender → 렌더링된 PNG |
| **CLI 서브프로세스 테스트** | `subprocess.run`을 통한 설치된 명령 실행 | `cli-anything-gimp --json project new` → 유효한 JSON 출력 |

```
================================ Test Summary ================================
gimp          107 passed  ✅   (64 unit + 43 e2e)
blender       208 passed  ✅   (150 unit + 58 e2e)
inkscape      202 passed  ✅   (148 unit + 54 e2e)
audacity      161 passed  ✅   (107 unit + 54 e2e)
libreoffice   158 passed  ✅   (89 unit + 69 e2e)
mubu           96 passed  ✅   (85 unit + 11 e2e)
obs-studio    153 passed  ✅   (116 unit + 37 e2e)
kdenlive      155 passed  ✅   (111 unit + 44 e2e)
shotcut       154 passed  ✅   (110 unit + 44 e2e)
zoom           22 passed  ✅   (22 unit + 0 e2e)
drawio        138 passed  ✅   (116 unit + 22 e2e)
mermaid        10 passed  ✅   (5 unit + 5 e2e)
anygen         50 passed  ✅   (40 unit + 10 e2e)
notebooklm     21 passed  ✅   (21 unit + 0 e2e)
comfyui        70 passed  ✅   (60 unit + 10 e2e)
adguardhome    36 passed  ✅   (24 unit + 12 e2e)
ollama         98 passed  ✅   (87 unit + 11 e2e)
sketch         19 passed  ✅   (19 jest, Node.js)
renderdoc      59 passed  ✅   (45 unit + 14 e2e)
──────────────────────────────────────────────────────────────────────────────
TOTAL        1,917 passed  ✅   100% pass rate
```

---

## 🏗️ CLI-Anything의 아키텍처

<p align="center">
  <img src="https://raw.githubusercontent.com/HKUDS/CLI-Anything/main/assets/architecture.png" alt="CLI-Anything Architecture" width="750">
</p>

### 🎯 핵심 설계 원칙

1. **진정한 소프트웨어 통합** — CLI는 유효한 프로젝트 파일(ODF, MLT XML, SVG)을 생성하고 렌더링을 위해 실제 애플리케이션에 위임합니다. **우리는 소프트웨어를 대체하는 것이 아닌, 소프트웨어에 대한 구조화된 인터페이스를 구축합니다**.

2. **유연한 상호작용 모델** — 모든 CLI는 상태 유지 REPL 모드(대화형 에이전트 세션)와 서브커맨드 인터페이스(스크립팅/파이프라인)를 이중으로 운영합니다. **명령어만 입력 → REPL 모드 진입**.

3. **일관된 사용자 경험** — 생성된 모든 CLI는 통합된 REPL 인터페이스(repl_skin.py)를 공유하며, 브랜드 배너, 스타일링된 프롬프트, 명령 기록, 진행 표시기, 표준화된 포맷을 제공합니다.

4. **에이전트 네이티브 설계** — 모든 명령어에 내장된 --json 플래그는 기계 처리용 구조화된 데이터를 제공하며, 사람이 읽기 쉬운 테이블은 대화형 사용을 지원합니다. **에이전트는 표준 --help 및 which 명령어를 통해 기능을 탐색합니다**.

5. **무타협 종속성** — 실제 소프트웨어는 필수 조건입니다 — 대체 수단이나 점진적 저하는 없습니다. **백엔드가 없으면 테스트는 실패(건너뛰기 아님)하여 진정한 기능을 보장합니다**.

---

## 📂 프로젝트 구조

```
cli-anything/
├── 📄 README.md                          # You are here
├── 📁 assets/                            # Images and media
│   ├── icon.png                          # Project icon
│   └── teaser.png                        # Teaser figure
│
├── 🔌 cli-anything-plugin/               # The Claude Code plugin
│   ├── HARNESS.md                        # Methodology SOP (source of truth)
│   ├── README.md                         # Plugin documentation
│   ├── QUICKSTART.md                     # 5-minute getting started
│   ├── PUBLISHING.md                     # Distribution guide
│   ├── repl_skin.py                      # Unified REPL interface
│   ├── commands/                         # Plugin command definitions
│   │   ├── cli-anything.md               # Main build command
│   │   ├── refine.md                     # Expand existing harness coverage
│   │   ├── test.md                       # Test runner
│   │   └── validate.md                   # Standards validation
│   └── scripts/
│       └── setup-cli-anything.sh         # Setup script
│
├── 🤖 codex-skill/                      # Codex skill entry point
├── 🎨 gimp/agent-harness/               # GIMP CLI (107 tests)
├── 🧊 blender/agent-harness/            # Blender CLI (208 tests)
├── ✏️ inkscape/agent-harness/            # Inkscape CLI (202 tests)
├── 🎵 audacity/agent-harness/           # Audacity CLI (161 tests)
├── 🌐 browser/agent-harness/            # Browser CLI (DOMShell MCP, new)
├── 📄 libreoffice/agent-harness/        # LibreOffice CLI (158 tests)
├── 📝 mubu/agent-harness/               # Mubu CLI (96 tests)
├── 📹 obs-studio/agent-harness/         # OBS Studio CLI (153 tests)
├── 🎞️ kdenlive/agent-harness/           # Kdenlive CLI (155 tests)
├── 🎬 shotcut/agent-harness/            # Shotcut CLI (154 tests)
├── 📞 zoom/agent-harness/               # Zoom CLI (22 tests)
├── 🎵 musescore/agent-harness/          # MuseScore CLI (56 tests)
├── 📐 drawio/agent-harness/             # Draw.io CLI (138 tests)
├── 🧜 mermaid/agent-harness/            # Mermaid Live Editor CLI (10 tests)
├── ✨ anygen/agent-harness/             # AnyGen CLI (50 tests)
├── 🖼️ comfyui/agent-harness/            # ComfyUI CLI (70 tests)
├── 🧠 notebooklm/agent-harness/         # NotebookLM CLI (experimental, 21 tests)
├── 🛡️ adguardhome/agent-harness/       # AdGuard Home CLI (36 tests)
├── 🦙 ollama/agent-harness/             # Ollama CLI (98 tests)
├── 🎨 sketch/agent-harness/             # Sketch CLI (19 tests, Node.js)
└── 🔬 renderdoc/agent-harness/          # RenderDoc CLI (59 tests)
```
각 `agent-harness/`에는 Click CLI, 핵심 모듈, 유틸리티(`repl_skin.py` 및 백엔드 래퍼 포함), 그리고 포괄적인 테스트가 포함된 `cli_anything.<software>/` 하위에 설치 가능한 파이썬 패키지가 있습니다.

---

## 🎯 플러그인 명령어

| 명령어 | 설명 |
|---------|-------------|
| `/cli-anything <software-path-or-repo>` | 완전한 CLI 하네스 빌드 — 모든 7단계 |
| `/cli-anything:refine <software-path> [focus]` | 기존 하네스 개선 — 갭 분석을 통한 커버리지 확장 |
| `/cli-anything:test <software-path-or-repo>` | 테스트 실행 및 결과로 TEST.md 업데이트 |
| `/cli-anything:validate <software-path-or-repo>` | HARNESS.md 기준에 대한 검증 |

### 예시


```bash
# Build a complete CLI for GIMP from local source
/cli-anything /home/user/gimp

# Build from a GitHub repo
/cli-anything https://github.com/blender/blender

# Refine an existing harness — broad gap analysis
/cli-anything:refine /home/user/gimp

# Refine with a specific focus area
/cli-anything:refine /home/user/shotcut "vid-in-vid and picture-in-picture compositing"

# Run tests and update TEST.md
/cli-anything:test /home/user/inkscape

# Validate against HARNESS.md standards
/cli-anything:validate /home/user/audacity
```

---

## 🎮 Demo: Using a Generated CLI

Here's what an agent can do with `cli-anything-libreoffice`:

```bash
# Create a new Writer document
$ cli-anything-libreoffice document new -o report.json --type writer
✓ Created Writer document: report.json

# Add content
$ cli-anything-libreoffice --project report.json writer add-heading -t "Q1 Report" --level 1
✓ Added heading: "Q1 Report"

$ cli-anything-libreoffice --project report.json writer add-table --rows 4 --cols 3
✓ Added 4×3 table

# Export to real PDF via LibreOffice headless
$ cli-anything-libreoffice --project report.json export render output.pdf -p pdf --overwrite
✓ Exported: output.pdf (42,831 bytes) via libreoffice-headless

# JSON mode for agent consumption
$ cli-anything-libreoffice --json document info --project report.json
{
  "name": "Q1 Report",
  "type": "writer",
  "pages": 1,
  "elements": 2,
  "modified": true
}
```

### REPL 모드

```
$ cli-anything-blender
╔══════════════════════════════════════════╗
║       cli-anything-blender v1.0.0       ║
║     Blender CLI for AI Agents           ║
╚══════════════════════════════════════════╝

blender> scene new --name ProductShot
✓ Created scene: ProductShot

blender[ProductShot]> object add-mesh --type cube --location 0 0 1
✓ Added mesh: Cube at (0, 0, 1)

blender[ProductShot]*> render execute --output render.png --engine CYCLES
✓ Rendered: render.png (1920×1080, 2.3 MB) via blender --background

blender[ProductShot]> exit
Goodbye! 👋
```

---

## 📖 표준 플레이북: HARNESS.md

HARNESS.md는 모든 소프트웨어 에이전트를 자동화된 CLI 생성으로 접근 가능하게 만드는 우리의 결정적인 표준 작업 절차입니다.

자동 생성 프로세스를 통해 다듬어진 검증된 패턴과 방법론을 인코딩합니다.

이 플레이북은 16개의 다양하고 프로덕션 준비가 된 하네스를 성공적으로 구축하면서 얻은 핵심 통찰을 요약합니다.

### 중요한 교훈

| 교훈 | 설명 |
|--------|-------------|
| **실제 소프트웨어 사용** | CLI는 렌더링을 위해 반드시 실제 애플리케이션을 호출해야 합니다. GIMP를 위한 Pillow 대체물이나 Blender를 위한 맞춤 렌더러는 안 됩니다. 유효한 프로젝트 파일 생성 → 실제 백엔드 호출. |
| **렌더링 간극** | GUI 앱은 렌더 시점에 효과를 적용합니다. CLI가 프로젝트 파일을 조작하지만 단순한 내보내기 도구를 사용하면 효과가 조용히 사라집니다. 해결책: 네이티브 렌더러 → 필터 변환 → 렌더 스크립트. |
| **필터 변환** | 포맷 간 효과 매핑(MLT → ffmpeg) 시 중복 필터 병합, 혼합된 스트림 순서, 파라미터 공간 차이, 변환 불가능한 효과를 주의하세요. |
| **타임코드 정밀도** | 비정수 프레임률(29.97fps)은 누적 반올림을 초래합니다. `int()` 대신 `round()` 사용, 표시에는 정수 산술, 테스트에는 ±1 프레임 허용오차 적용. |
| **출력 검증** | 내보내기가 0으로 종료됐다고 신뢰하지 마세요. 매직 바이트, ZIP/OOXML 구조, 픽셀 분석, 오디오 RMS 레벨, 지속 시간 검사를 검증하세요. |

> 전체 방법론 보기: [`cli-anything-plugin/HARNESS.md`](https://raw.githubusercontent.com/HKUDS/CLI-Anything/main/cli-anything-plugin/HARNESS.md)

---

## 📦 설치 및 사용법

### 플러그인 사용자용 (Claude Code)

```bash
# Add marketplace & install (recommended)
/plugin marketplace add HKUDS/CLI-Anything
/plugin install cli-anything

# Build a CLI for any software with a codebase
/cli-anything <software-name>
```

### 생성된 CLI용

```bash
# Install any generated CLI
cd <software>/agent-harness
pip install -e .

# Verify
which cli-anything-<software>

# Use
cli-anything-<software> --help
cli-anything-<software>                    # enters REPL
cli-anything-<software> --json <command>   # JSON output for agents
```

### 테스트 실행하기

```bash
# Run tests for a specific CLI
cd <software>/agent-harness
python3 -m pytest cli_anything/<software>/tests/ -v

# Force-installed mode (recommended for validation)
CLI_ANYTHING_FORCE_INSTALLED=1 python3 -m pytest cli_anything/<software>/tests/ -v -s
```

---

## 🤝 기여하기

기여를 환영합니다! CLI-Anything은 확장 가능하도록 설계되었습니다:

- **새 소프트웨어 대상** — 플러그인을 사용하여 코드베이스가 있는 모든 소프트웨어에 대한 CLI를 생성한 후, [`cli-anything-plugin/PUBLISHING.md`](https://raw.githubusercontent.com/HKUDS/CLI-Anything/main/cli-anything-plugin/PUBLISHING.md) 를 통해 하네스를 제출하세요.
- **방법론 개선** — 새로운 교훈을 인코딩하는 `HARNESS.md`에 대한 PR
- **플러그인 향상** — 새로운 명령, 단계 개선, 더 나은 검증
- **테스트 커버리지** — 더 많은 E2E 시나리오, 엣지 케이스, 워크플로우 테스트

### 제한 사항

- **강력한 파운데이션 모델 필요** — CLI-Anything은 신뢰할 수 있는 하네스 생성을 위해 최첨단 모델(예: Claude Opus 4.6, Claude Sonnet 4.6, GPT-5.4)에 의존합니다. 약하거나 작은 모델은 상당한 수동 수정이 필요한 불완전하거나 부정확한 CLI를 생성할 수 있습니다.
- **사용 가능한 소스 코드에 의존** — 7단계 파이프라인은 소스 코드를 분석하고 생성합니다. 대상 소프트웨어가 디컴파일이 필요한 컴파일된 바이너리만 제공하는 경우, 하네스 품질과 커버리지가 크게 저하됩니다.
- **반복적인 정제가 필요할 수 있음** — 단일 `/cli-anything` 실행만으로 모든 기능을 완전히 커버하지 못할 수 있습니다. `/refine` 명령을 한 번 이상 실행하여 CLI의 성능과 커버리지를 프로덕션 품질로 끌어올리는 것이 자주 필요합니다.

### 로드맵

- [ ] 더 많은 애플리케이션 카테고리 지원 (CAD, DAW, IDE, EDA, 과학 도구)
- [ ] 에이전트 작업 완료율 벤치마크 스위트
- [ ] 내부/맞춤 소프트웨어용 커뮤니티 기여 CLI 하네스
- [ ] Claude Code 외 추가 에이전트 프레임워크와 통합
- [ ] 폐쇄형 소프트웨어 및 웹 서비스용 패키징 API를 CLI로 지원
- [x] 에이전트 스킬 발견 및 오케스트레이션을 위한 SKILL.md를 CLI와 함께 생성

---

## 📖 문서

| 문서 | 설명 |
|----------|-------------|
| [`cli-anything-plugin/HARNESS.md`](https://raw.githubusercontent.com/HKUDS/CLI-Anything/main/cli-anything-plugin/HARNESS.md) | 방법론 SOP — 단일 진실 소스 |
| [`cli-anything-plugin/README.md`](https://raw.githubusercontent.com/HKUDS/CLI-Anything/main/cli-anything-plugin/README.md) | 플러그인 문서 — 명령, 옵션, 단계 |
| [`cli-anything-plugin/QUICKSTART.md`](https://raw.githubusercontent.com/HKUDS/CLI-Anything/main/cli-anything-plugin/QUICKSTART.md) | 5분 시작 가이드 |
| [`cli-anything-plugin/PUBLISHING.md`](https://raw.githubusercontent.com/HKUDS/CLI-Anything/main/cli-anything-plugin/PUBLISHING.md) | 배포 및 퍼블리싱 가이드 |

생성된 각 하네스에는 다음이 포함됩니다:
- `<SOFTWARE>.md` — 해당 애플리케이션에 특화된 아키텍처 SOP
- `tests/TEST.md` — 테스트 계획 및 결과 문서

---

## ⭐ 별 히스토리

CLI-Anything이 귀하의 소프트웨어를 에이전트 네이티브로 만드는 데 도움이 된다면, 별을 눌러주세요! ⭐

<div align="center">
  <a href="https://star-history.com/#HKUDS/CLI-Anything&Date">
    <picture>
      <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=HKUDS/CLI-Anything&type=Date&theme=dark" />
      <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=HKUDS/CLI-Anything&type=Date" />
      <img alt="별 히스토리 차트" src="https://api.star-history.com/svg?repos=HKUDS/CLI-Anything&type=Date" />
    </picture>
  </a>
</div>

---

## 📄 라이선스

MIT 라이선스 — 자유롭게 사용, 수정, 배포 가능.

---

<div align="center">

**CLI-Anything** — *코드베이스가 있는 모든 소프트웨어를 에이전트 네이티브로 만드세요.*

<sub>AI 에이전트 시대를 위한 방법론 | 16개의 전문 소프트웨어 데모 | 1,839개의 테스트 통과</sub>

<br>

<img src="https://raw.githubusercontent.com/HKUDS/CLI-Anything/main/assets/icon.png" alt="CLI-Anything 아이콘" width="80">

</div>

<p align="center">
  <em> 방문해 주셔서 감사합니다 ✨ CLI-Anything!</em><br><br>
  <img src="https://visitor-badge.laobi.icu/badge?page_id=HKUDS.CLI-Anything&style=for-the-badge&color=00d4ff" alt="Views">
</p>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-29

---