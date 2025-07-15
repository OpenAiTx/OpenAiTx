## 새로운 기능: Gemini로 읽고 Claude + Diffs로 편집하기

<div align="center">
  <img width="400" alt="screenshot 2025-07-13 at 07 09 45"
       src="https://github.com/user-attachments/assets/5fccba53-71ce-4546-8aed-b1095c5a1ca8" />
</div>

---

> **참고:**  
> - Gemini CLI 설치에 이미 다른 MCP 도구가 포함되어 있으면, 이들이 gemini-mcp-tool과 상호작용하여 충돌이나 MCP가 stdout에 직접 쓰는 경우 예기치 않은 콘솔 출력이 발생할 수 있습니다.  
> - Gemini에게 스스로를 호출하도록 요청하여 프롬프트를 중첩할 수 있습니다(예: `ask gemini to ask gemini`), 하지만 요청이 할당량을 초과할 경우 자동으로 대체되지 않습니다.  
> - 더 빠르고 저렴한 flash 모델을 사용하려면 `flash`를 추가하세요(예: `... using flash ...`).

> 🚀 **경험을 공유해 주세요!** [어떻게 진행되었는지 알려주세요](https://github.com/jamubc/gemini-mcp-tool/discussions/2) 그리고 커뮤니티 성장에 도움을 주세요!

> 📚 [위키 문서](https://github.com/jamubc/gemini-mcp-tool/wiki)에는 추가 가이드와 예제가 제공됩니다.
> 
> 기여 프레임워크는 현재 테스트 중입니다. 목표는 Gemini를 사용해 gemini-mcp-tool 확장 기능을 만들고, 도구 생성 자동화 및 TUI 기반 도구 생성기를 제공하는 것입니다.

# Gemini MCP 도구

<div align="center">

[![GitHub Release](https://img.shields.io/github/v/release/jamubc/gemini-mcp-tool?logo=github&label=GitHub)](https://github.com/jamubc/gemini-mcp-tool/releases)
[![npm version](https://img.shields.io/npm/v/gemini-mcp-tool)](https://www.npmjs.com/package/gemini-mcp-tool)
[![npm downloads](https://img.shields.io/npm/dt/gemini-mcp-tool)](https://www.npmjs.com/package/gemini-mcp-tool)
[![License: MIT](https://img.shields.io/badge/License-MIT-blue.svg)](https://opensource.org/licenses/MIT)
[![Open Source](https://img.shields.io/badge/Open%20Source-❤️-red.svg)](https://github.com/jamubc/gemini-mcp-tool)

</div>

<a href="https://glama.ai/mcp/servers/@jamubc/gemini-mcp-tool">
  <img width="380" height="200" src="https://glama.ai/mcp/servers/@jamubc/gemini-mcp-tool/badge" alt="Gemini Tool MCP server" />
</a>

> 📚 **[전체 문서 보기](https://jamubc.github.io/gemini-mcp-tool/)** - 검색, 예제, FAQ, 문제 해결, 모범 사례

이 도구는 AI 어시스턴트가 [Gemini CLI](https://github.com/google-gemini/gemini-cli)와 상호작용할 수 있도록 하는 간단한 모델 컨텍스트 프로토콜(MCP) 서버입니다. AI가 `@` 구문을 사용하여 대용량 파일과 코드베이스를 포함한 대규모 분석을 위해 Gemini의 방대한 토큰 창을 활용할 수 있게 합니다.

## 요약: [![Claude](https://img.shields.io/badge/Claude-D97757?logo=claude&logoColor=fff)](#) + [![Google Gemini](https://img.shields.io/badge/Google%20Gemini-886FBF?logo=googlegemini&logoColor=fff)](#)


**목표**: Gemini의 강력한 분석 기능을 Claude 코드 내에서 직접 사용하여 토큰을 절약하고 대용량 파일을 분석합니다.

### 한 줄 설정


```bash
claude mcp add gemini-cli -- npx -y gemini-mcp-tool
```
### 설치 확인

Claude Code 내에서 `/mcp`를 입력하여 gemini-cli MCP가 활성화되었는지 확인합니다.

---

### 대안: Claude Desktop에서 가져오기

이미 Claude Desktop에 설정되어 있다면:

1. Claude Desktop 설정에 다음을 추가하세요:

```json
"gemini-cli": {
  "command": "npx",
  "args": ["-y", "gemini-mcp-tool"]
}
```
2. Claude Code로 가져오기:

```bash
claude mcp add-from-claude-desktop
```
## 전제 조건

이 도구를 사용하기 전에 다음을 확인하세요:

1. **[Node.js](https://nodejs.org/)** (버전 16.0.0 이상)
2. **[Google Gemini CLI](https://github.com/google-gemini/gemini-cli)** 설치 및 구성 완료

## 설치 옵션

### 옵션 1: NPX (권장)
설치 불필요 - `npx`를 통해 직접 도구 실행.

### 옵션 2: 전역 설치

```bash
npm install -g gemini-mcp-tool
```
## 구성

MCP 클라이언트에 MCP 서버를 등록하세요:

### NPX 사용법(권장)

이 구성을 Claude Desktop 설정 파일에 추가하세요:


```json
{
  "mcpServers": {
    "gemini-cli": {
      "command": "npx",
      "args": ["-y", "gemini-mcp-tool"]
    }
  }
}
```
### 전역 설치용

전역으로 설치한 경우, 대신 이 구성을 사용하세요:


```json
{
  "mcpServers": {
    "gemini-cli": {
      "command": "gemini-mcp"
    }
  }
}
```
**구성 파일 위치:**

- **Claude 데스크톱**:
  - **macOS**: `~/Library/Application Support/Claude/claude_desktop_config.json`
  - **Windows**: `%APPDATA%\Claude\claude_desktop_config.json`
  - **Linux**: `~/.config/claude/claude_desktop_config.json`

구성을 업데이트한 후에는 터미널 세션을 재시작하세요.

## 사용 가능한 명령어

- **자연어**: "use gemini to explain index.html", "understand the massive project using gemini", "ask gemini to search for latest news"
- **Claude 코드**: `/gemini-cli`를 입력하면 명령어가 Claude 코드 인터페이스에 나타납니다.

## 사용 예시

### 파일 참조와 함께 ( @ 구문 사용)

- `ask gemini to analyze @src/main.js and explain what it does`
- `use gemini to summarize @. the current directory`
- `analyze @package.json and tell me about dependencies`

### 일반 질문 (파일 없이)

- `ask gemini to search for the latest tech news`
- `use gemini to explain div centering`
- `ask gemini about best practices for React development related to @file_im_confused_about`

### Gemini CLI 샌드박스 모드 사용 (-s)

샌드박스 모드는 격리된 환경에서 안전하게 코드 변경을 테스트하거나 스크립트를 실행하며 위험할 수 있는 작업을 수행할 수 있게 해줍니다.

- `use gemini sandbox to create and run a Python script that processes data`
- `ask gemini to safely test @script.py and explain what it does`
- `use gemini sandbox to install numpy and create a data visualization`
- `test this code safely: Create a script that makes HTTP requests to an API`

### 도구 (AI용)

이 도구들은 AI 어시스턴트가 사용하도록 설계되었습니다.

- **`ask-gemini`**: Google Gemini에 질문하여 관점을 얻습니다. 일반 질문이나 복잡한 파일 분석에 사용할 수 있습니다.
  - **`prompt`** (필수): 분석 요청입니다. `@` 구문을 사용하여 파일 또는 디렉터리 참조를 포함할 수 있습니다 (예: `@src/main.js explain this code`) 또는 일반 질문을 할 수 있습니다 (예: `Please use a web search to find the latest news stories`).
  - **`model`** (선택): 사용할 Gemini 모델입니다. 기본값은 `gemini-2.5-flash`입니다.
  - **`sandbox`** (선택): `true`로 설정하면 샌드박스 모드에서 안전하게 코드 실행을 수행합니다.
- **`sandbox-test`**: Gemini의 샌드박스 환경에서 코드를 안전하게 실행합니다. 항상 샌드박스 모드로 실행됩니다.
  - **`prompt`** (필수): 코드 테스트 요청 (예: `Create and run a Python script that...` 또는 `@script.py Run this safely`).
  - **`model`** (선택): 사용할 Gemini 모델입니다.
- **`Ping`**: 메시지를 다시 보내는 간단한 테스트 도구입니다.
- **`Help`**: Gemini CLI 도움말 텍스트를 표시합니다.

### 슬래시 명령어 (사용자용)

이 명령어들은 Claude 코드 인터페이스에서 직접 사용할 수 있습니다 (다른 클라이언트와의 호환성은 테스트되지 않았습니다).

- **/analyze**: Gemini를 사용하여 파일이나 디렉터리를 분석하거나 일반 질문을 합니다.
  - **`prompt`** (필수): 분석 프롬프트입니다. `@` 구문을 사용하여 파일을 포함하거나 (예: `/analyze prompt:@src/ summarize this directory`) 일반 질문을 할 수 있습니다 (예: `/analyze prompt:Please use a web search to find the latest news stories`).
- **/sandbox**: Gemini의 샌드박스 환경에서 코드를 안전하게 테스트합니다.
  - **`prompt`** (필수): 코드 테스트 요청 (예: `/sandbox prompt:Create and run a Python script that processes CSV data` 또는 `/sandbox prompt:@script.py Test this script safely`).
- **/help**: Gemini CLI 도움말 정보를 표시합니다.
- **/ping**: 서버와의 연결을 테스트합니다.
  - **`message`** (선택): 다시 보낼 메시지입니다.

## 기여

기여를 환영합니다! 풀 리퀘스트 제출, 이슈 보고 및 프로젝트 기여 방법에 대해서는 [기여 가이드라인](https://raw.githubusercontent.com/jamubc/gemini-mcp-tool/main/CONTRIBUTING.md)을 참조하세요.

## 라이선스

이 프로젝트는 MIT 라이선스 하에 라이선스가 부여되었습니다. 자세한 내용은 [LICENSE](LICENSE) 파일을 참조하세요.

**면책 조항:** 이 도구는 비공식 서드파티 도구이며 Google과 제휴되거나 승인 또는 후원받지 않았습니다.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-15

---