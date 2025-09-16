
# mcp-chat

<div align="right">
  <details>
    <summary >🌐 언어</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=as">অসমীয়া</
      </div>
    </div>
  </details>

</div>

mcp 서버 및 에이전트 테스트와 평가를 위한 오픈 소스 범용 MCP 클라이언트

<p align="center">
  <img width="600" src="https://raw.githubusercontent.com/Flux159/mcp-chat/refs/heads/main/mcpchat.svg">
</p>

## 빠른 시작

`ANTHROPIC_API_KEY`가 환경 변수로 내보내졌거나 프로젝트 루트의 .env 파일에 있는지 확인하세요. API 키는 [Anthropic 콘솔 키 페이지](https://console.anthropic.com/settings/keys)에서 회원가입 후 얻을 수 있습니다.

CLI에서 파일 시스템 MCP 서버와 상호작용하는 채팅 프롬프트를 생성하는 간단한 사용 예시:

```shell
npx mcp-chat --server "npx -y @modelcontextprotocol/server-filesystem /Users/$USER/Desktop"
```
이것은 서버와 상호 작용하고 LLM과 대화할 수 있는 채팅 프롬프트를 엽니다.

## 구성

Mac의 경우 claude_desktop_config.json을 지정할 수도 있습니다:


```shell
npx mcp-chat --config "~/Library/Application Support/Claude/claude_desktop_config.json"
```

또는 (윈도우):

```shell
npx mcp-chat --config "%APPDATA%\Claude\claude_desktop_config.json"
```

## Web mode

https://github.com/user-attachments/assets/b7e8a648-8084-4955-8cdf-fc6eb141572e

You can also run mcp-chat in web mode by specifying the `--web` flag (make sure to have `ANTHROPIC_API_KEY` exported in your environment):

```shell
npx mcp-chat --web
```
웹 모드에서는 새 채팅을 시작하고, 모델에 메시지를 보내며, UI를 통해 mcp 서버를 동적으로 구성할 수 있습니다 - 명령줄에서 지정할 필요가 없습니다. 또한, 웹 UI를 통해 생성된 채팅은 CLI를 통해 생성된 채팅과 마찬가지로 ~/.mcpchats/chats에 저장됩니다.

## 기능

- [x] 대화형 모드에서 CLI를 통해 실행하거나 `-p`로 프롬프트 직접 전달
- [x] 웹 인터페이스를 통한 모델과의 채팅 웹 모드 `--web`
- [x] 프로덕션 또는 개발 중에 모든 MCP 서버(JS, Python, Docker) 연결 가능
- [x] `-m`으로 모델 선택 가능
- [x] `--system`으로 시스템 프롬프트 맞춤 설정
- [x] 웹 채팅 포함 설정과 함께 `~/.mcpchat/chats`에 채팅 기록 저장
- [x] `~/.mcpchat/history`에 명령어 저장 및 복원
- [x] mcp 서버 디버깅에 도움을 주기 위해 채팅에서 도구 호출 출력 및 인수 직접 확인

## CLI 사용법

`-p` 플래그로 CLI에서 프롬프트 실행:


```shell
npx mcp-chat --server "npx mcp-server-kubernetes" -p "List the pods in the default namespace"
```

이 명령은 kubenertes mcp-server와 함께 프롬프트를 실행하고 stdout에서 응답을 받은 후 종료합니다.

`-m` 플래그를 사용하여 CLI를 통해 대화할 모델을 선택하세요:

```shell
npx mcp-chat --server "npx mcp-server-kubernetes" -m "claude-3.5"
```
`claude-3.5` 모델을 사용하여 대화합니다. 현재는 Anthropic 모델만 지원됨을 참고하세요.

사용자 지정 시스템 프롬프트:

`--system` 플래그를 사용하여 시스템 프롬프트를 지정할 수 있습니다:


```shell
npx mcp-chat --system "Explain the output to the user in pirate speak." --server "npx mcp-server-kubernetes" -p "List the pods in the default namespace"
```

## ENV 변수

Mcp-chat은 env 변수를 mcp 서버로 전달하는 것을 지원합니다. 그러나 이는 mcp 사양에 표준화되어 있지 않으며 다른 클라이언트들은 동적 env 변수 값을 사용하여 이를 수행하지 않을 수 있습니다 - 표준 stdio mcp 클라이언트에 대해 더 알고 싶으면 [여기](https://github.com/Flux159/mcp-server-kubernetes/issues/148#issuecomment-2950181666)를 읽어보세요.

```shell
KUBECONFIG="~/.kube/config" npx mcp-chat --server "npx mcp-server-kubernetes"
```

## mcp-서버 개발자를 위해

mcp-chat과 함께 테스트하기 위해 python 또는 node mcp-서버의 로컬 빌드를 전달할 수 있습니다:

Node JS:

```shell
# Directly executing built script
npx mcp-chat --server "/path/to/mcp-server-kubernetes/dist/index.js"
# Using node / bun
npx mcp-chat --server "node /path/to/mcp-server-kubernetes/dist/index.js"
```

파이썬:

```shell
# Python: Using uv
npx mcp-chat --server "uv --directory /path/to/mcp-server-weather/ run weather.py"
# Using python / python3 - make sure to run in venv or install deps globally
npx mcp-chat --server "/path/to/mcp-server-weather/weather.py"
```

## 개발

종속성 설치 및 CLI 실행:

```shell
git clone https://github.com/Flux159/mcp-chat
bun install
bun run dev
```
mcp-server에 연결하여 mcp-chat을 개발하려면, 빌드한 후 서버 플래그와 함께 CLI를 실행하세요:


```shell
npm run build && node dist/index.js --server "npx mcp-server-kubernetes" -p "List the pods in the default namespace"
```
테스트:


```shell
bun run test
```
빌딩:


```shell
bun run build
```

게시:

```shell
bun run publish
```

도커 퍼블리싱:

```shell
bun run dockerbuild
```

### 프로젝트 구조

```
├── src/
│   ├── index.ts            # Main client implementation & CLI params
│   ├── constants.ts        # Default constants
│   ├── interactive.ts      # Interactive chat prompt handling & logic
├── test/                   # Test files
│   ├── cli.test.ts         # Test CLI params
│   ├── config.test.ts      # Test config file parsing
```
## 새 릴리스 게시

[릴리스](https://github.com/Flux159/mcp-chat/releases) 페이지로 이동하여 "Draft New Release"를 클릭하고 "Choose a tag"를 클릭한 다음 "v{major}.{minor}.{patch}" 세머버 형식을 사용하여 새 버전 번호를 입력하여 새 태그를 생성합니다. 그런 다음 릴리스 제목에 "Release v{major}.{minor}.{patch}"를 작성하고 필요에 따라 설명 / 변경 로그를 작성한 후 "Publish Release"를 클릭합니다.

이렇게 하면 cd.yml 워크플로우를 통해 새 릴리스 빌드를 트리거하는 새 태그가 생성됩니다. 빌드가 성공하면 새 릴리스가 npm에 게시됩니다. package.json 버전을 수동으로 업데이트할 필요가 없으며, 워크플로우가 package.json 파일의 버전 번호를 자동으로 업데이트하고 커밋을 main 브랜치에 푸시합니다.

## 라이선스

[MIT License](https://github.com/Flux159/mcp-chat/blob/main/LICENSE)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-16

---