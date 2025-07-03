# Tome - 마법의 AI 주문서

<img src="https://raw.githubusercontent.com/runebookai/tome/main/static/images/repo-header.png" alt="Tome" />

<p align="center">
    <code>모든 사람의 손에 LLM과 MCP의 힘을 쥐어주는 마법 같은 데스크톱 앱</code>
</p>

<p align="center">
    <a href="https://discord.gg/9CH6us29YA" target="_blank"><img src="https://img.shields.io/discord/1365100902561742868?logo=discord&logoColor=fff&label=Join%20Us!&color=9D7CD8" alt="Join Us on Discord" /></a>
    <a href="https://opensource.org/licenses/Apache-2.0" target="_blank"><img src="https://img.shields.io/badge/License-Apache_2.0-blue.svg" alt="License: Apache 2.0" /></a>
    <a href="https://github.com/runebookai/tome/releases" target="_blank"><img src="https://img.shields.io/github/v/release/runebookai/tome" alt="GitHub Release" /></a>
</p>

<p align="center">
    🔮 Tome 데스크톱 앱 다운로드: <a href="https://github.com/runebookai/tome/releases/download/0.6.0/Tome_0.6.0_x64-setup.exe">Windows</a> | <a href="https://github.com/runebookai/tome/releases/download/0.6.0/Tome_0.6.0_aarch64.dmg">MacOS</a>
</p>

# Tome

Tome은 **누구나** LLM과 MCP의 마법을 활용할 수 있게 해주는 데스크톱 앱입니다. Tome을 다운로드하고, 원하는 로컬 또는 원격 LLM을 연결한 뒤, 수천 개의 MCP 서버와 연동하여 나만의 마법 같은 AI 주문서를 만들어보세요.

🫥 100% 로컬, 100% 프라이빗하게 사용하고 싶으신가요? Ollama와 Qwen3를 사용해 로컬 MCP 서버만으로 나만의 포켓 유니버스에서 주문을 시전하세요. ⚡ 최첨단 클라우드 모델과 최신 원격 MCP 서버를 원하시나요? 그것도 가능합니다. 모든 것은 여러분의 선택에 달려 있습니다!

🏗️ 현재는 Technical Preview 단계이므로 다소 미완성된 부분이 있을 수 있습니다. [Discord에 참여](https://discord.gg/9CH6us29YA)하여 팁, 노하우, 문제점을 공유해주세요. 이 레포에 스타를 눌러 최신 업데이트와 기능 릴리스를 받아보세요!

## 🪄 주요 기능

- 🧙 **간편하고 초보자 친화적인 경험**
  - Tome을 다운로드 및 설치하고 원하는 LLM만 연결하면 됩니다
  - JSON, Docker, python, node를 만질 필요 없음
- 🤖 **AI 모델 지원**
  - **원격**: Google Gemini, OpenAI, OpenAI API 호환 엔드포인트
  - **로컬**: Ollama, LM Studio, Cortex, OpenAI API 호환 엔드포인트
- 🔮 **향상된 MCP 지원**
  - MCP 서버 설치, 제거, 켜기/끄기 UI 제공
  - npm, uvx, node, python MCP 서버를 기본 지원
- 🏪 **[Smithery.ai](https://smithery.ai) 레지스트리와 통합**
  - 원클릭 설치로 수천 개의 MCP 서버 이용 가능
- ✏️ **컨텍스트 윈도우 및 온도 설정 커스터마이징**
- 🧰 **툴 호출 및 추론 모델 네이티브 지원**
  - 툴 호출과 사고 메시지를 명확하게 구분하는 UI 개선

## 데모

https://github.com/user-attachments/assets/0775d100-3eba-4219-9e2f-360a01f28cce

# 시작하기

## 요구 사항

- MacOS 또는 Windows (Linux는 곧 지원 예정!)
- 원하는 LLM 공급자: [Ollama](https://ollama.com/) 또는 [Gemini API 키](https://aistudio.google.com/app/apikey) (쉽고 무료)
- [Tome 최신 버전 다운로드](https://github.com/runebookai/tome/releases)

## 빠른 시작

1. [Tome](https://github.com/runebookai/tome/releases) 설치
2. 선호하는 LLM 공급자 연결 - OpenAI, Ollama, Gemini가 기본 제공되며, LM Studio 등은 http://localhost:1234/v1 주소로 추가할 수 있습니다
3. Tome에서 MCP 탭을 열고 첫 [MCP 서버](https://github.com/modelcontextprotocol/servers)를 설치하세요 (Fetch가 시작하기 쉽습니다. 서버 필드에 `uvx mcp-server-fetch`만 붙여넣으면 됩니다).
4. MCP로 구동되는 모델과 채팅하세요! Hacker News의 최신 뉴스를 요청해보세요.

# 비전

우리는 모든 사람이 로컬 LLM과 MCP를 사용할 수 있기를 바랍니다. 여러분이 엔지니어든, 취미 개발자든, 호기심 많은 사람이든, LLM으로 창의력을 발휘할 수 있도록 도구를 만들고 있습니다.

## 핵심 원칙

- **Tome은 로컬 우선입니다:** 데이터가 어디로 가는지 스스로 제어할 수 있습니다.
- **Tome은 모두를 위한 도구입니다:** 프로그래밍 언어, 패키지 매니저, json 설정 파일을 다룰 필요가 없습니다.

## 앞으로의 계획

Tome 출시 이후 지난 몇 주 동안 많은 피드백을 받았고, 앞으로의 큰 계획도 있습니다. 우리는 LLM을 단순한 채팅창에서 벗어나게 하고 싶으며, 이를 돕기 위한 다양한 기능을 준비하고 있습니다.

- 예약 작업: 컴퓨터 앞에 있지 않아도 LLM이 유용한 작업을 할 수 있어야 합니다.
- 네이티브 통합: MCP 서버는 도구와 정보를 이용할 수 있는 훌륭한 방법이지만, 더 강력한 통합 기능을 추가해 LLM과 독특하게 상호작용할 수 있도록 할 예정입니다.
- 앱 빌더: 장기적으로 최고의 경험은 채팅 인터페이스가 아닌 별도의 도구에서 이루어진다고 생각합니다. 강력한 애플리케이션과 워크플로우를 만들 수 있는 추가 도구도 준비 중입니다.
- ??? 여러분이 보고 싶은 기능을 알려주세요! 아래 링크를 통해 커뮤니티에 참여해 의견을 들려주세요.

# 커뮤니티

[Discord](https://discord.gg/9CH6us29YA) [블로그](https://blog.runebook.ai) [Bluesky](https://bsky.app/profile/gettome.app) [Twitter](https://twitter.com/get_tome) 

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-03

---