# AutoGPT: AI 에이전트 빌드, 배포 및 실행

[![Discord Follow](https://dcbadge.vercel.app/api/server/autogpt?style=flat)](https://discord.gg/autogpt) &ensp;
[![Twitter Follow](https://img.shields.io/twitter/follow/Auto_GPT?style=social)](https://twitter.com/Auto_GPT) &ensp;
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

**AutoGPT**는 복잡한 워크플로우를 자동화하는 연속적인 AI 에이전트를 생성, 배포 및 관리할 수 있는 강력한 플랫폼입니다.

## 호스팅 옵션
   - 다운로드하여 자체 호스팅
   - [클라우드 호스팅 베타 대기자 명단 가입](https://bit.ly/3ZDijAI)

## 자체 호스팅 설정 방법
> [!NOTE]
> AutoGPT 플랫폼을 직접 설정하고 호스팅하는 것은 기술적인 과정입니다.
> 간단하게 사용하고 싶으시다면 [클라우드 호스팅 베타 대기자 명단](https://bit.ly/3ZDijAI)에 가입하실 것을 권장합니다.

### 시스템 요구사항

설치를 진행하기 전에 시스템이 다음 요구사항을 충족하는지 확인하세요:

#### 하드웨어 요구사항
- CPU: 4코어 이상 권장
- RAM: 최소 8GB, 16GB 권장
- 저장공간: 최소 10GB의 여유 공간

#### 소프트웨어 요구사항
- 운영체제:
  - Linux (Ubuntu 20.04 이상 권장)
  - macOS (10.15 이상)
  - Windows 10/11 (WSL2 필요)
- 필수 소프트웨어(최소 버전):
  - Docker Engine (20.10.0 이상)
  - Docker Compose (2.0.0 이상)
  - Git (2.30 이상)
  - Node.js (16.x 이상)
  - npm (8.x 이상)
  - VSCode (1.60 이상) 또는 최신 코드 에디터

#### 네트워크 요구사항
- 안정적인 인터넷 연결
- 필요한 포트 접근 가능(Docker에서 설정)
- 외부로 HTTPS 연결 가능

### 최신 설치 안내:
저희는 완전히 관리되고 정기적으로 업데이트되는 공식 문서 사이트로 이전했습니다.

👉 [공식 자체 호스팅 가이드 따라가기](https://docs.agpt.co/platform/getting-started/)

이 튜토리얼은 Docker, VSCode, git, npm이 설치되어 있다고 가정합니다.

### 🧱 AutoGPT 프론트엔드

AutoGPT 프론트엔드는 사용자가 강력한 AI 자동화 플랫폼과 상호작용하는 곳입니다. 다양한 방법으로 AI 에이전트와 소통하고 활용할 수 있습니다. 이 인터페이스에서 AI 자동화 아이디어를 실현할 수 있습니다:

   **에이전트 빌더:** 커스터마이징을 원하는 사용자를 위해, 직관적이고 로우 코드 방식의 인터페이스를 제공하여 자신만의 AI 에이전트를 설계하고 구성할 수 있습니다.
   
   **워크플로우 관리:** 자동화 워크플로우를 쉽게 구축, 수정 및 최적화할 수 있습니다. 블록을 연결하여 각 블록이 하나의 동작을 수행하는 방식으로 에이전트를 만듭니다.
   
   **배포 제어:** 테스트부터 운영까지 에이전트의 라이프사이클을 관리할 수 있습니다.
   
   **즉시 사용 가능한 에이전트:** 직접 만들고 싶지 않다면, 미리 구성된 에이전트 라이브러리에서 선택하여 바로 사용할 수 있습니다.
   
   **에이전트 상호작용:** 직접 만든 에이전트든, 사전 구성된 에이전트든, 사용자 친화적 인터페이스를 통해 쉽게 실행하고 상호작용할 수 있습니다.

   **모니터링 및 분석:** 에이전트의 성능을 추적하고, 인사이트를 얻어 자동화 프로세스를 지속적으로 개선할 수 있습니다.

[이 가이드](https://docs.agpt.co/platform/new_blocks/)를 읽고 나만의 커스텀 블록을 만드는 방법을 알아보세요.

### 💽 AutoGPT 서버

AutoGPT 서버는 플랫폼의 핵심 엔진입니다. 여기서 에이전트가 실행됩니다. 배포 후에는 외부 소스에 의해 에이전트가 트리거될 수 있고, 연속적으로 동작할 수 있습니다. AutoGPT가 원활하게 동작하는 데 필요한 모든 핵심 구성요소가 포함되어 있습니다.

   **소스 코드:** 에이전트와 자동화 프로세스를 구동하는 핵심 로직
   **인프라:** 신뢰성과 확장성을 보장하는 견고한 시스템
   **마켓플레이스:** 다양한 미리 제작된 에이전트를 찾아 배포할 수 있는 통합 마켓플레이스

### 🐙 예제 에이전트

AutoGPT로 할 수 있는 예시 두 가지를 소개합니다:

1. **트렌드 토픽 기반 바이럴 영상 생성**
   - 이 에이전트는 Reddit의 토픽을 읽습니다.
   - 트렌디한 토픽을 식별합니다.
   - 해당 콘텐츠를 바탕으로 자동으로 짧은 형식의 영상을 만듭니다.

2. **영상에서 소셜 미디어용 최고의 인용문 추출**
   - 이 에이전트는 당신의 YouTube 채널을 구독합니다.
   - 새로운 영상을 게시하면 이를 전사합니다.
   - AI로 가장 임팩트 있는 인용문을 식별해 요약을 만듭니다.
   - 그런 다음, 소셜 미디어에 자동으로 게시할 글을 작성합니다.

이 예시는 AutoGPT로 할 수 있는 일의 일부에 불과합니다! 원하는 모든 용도에 맞는 커스텀 워크플로우를 만들어 에이전트를 개발할 수 있습니다.

---
### 미션 및 라이선스
저희의 미션은 여러분이 진정 중요한 일에 집중할 수 있도록 도구를 제공하는 것입니다:

- 🏗️ **빌드** - 놀라운 무언가의 기초를 다지세요.
- 🧪 **테스트** - 여러분의 에이전트를 완벽하게 다듬으세요.
- 🤝 **위임** - AI가 일을 하도록 맡기고, 여러분의 아이디어를 실현하세요.

혁명의 주역이 되세요! **AutoGPT**는 AI 혁신의 최전선에서 계속 발전합니다.

**📖 [문서](https://docs.agpt.co)**
&ensp;|&ensp;
**🚀 [기여하기](CONTRIBUTING.md)**

**라이선스:**

MIT 라이선스: AutoGPT 저장소의 대부분은 MIT 라이선스 하에 있습니다.

Polyform Shield License: autogpt_platform 폴더에는 이 라이선스가 적용됩니다.

자세한 정보는 https://agpt.co/blog/introducing-the-autogpt-platform 를 참고하세요.

---
## 🤖 AutoGPT 클래식
> 아래는 AutoGPT 클래식 버전에 대한 정보입니다.

**🛠️ [자체 에이전트 빌드 - 퀵스타트](classic/FORGE-QUICKSTART.md)**

### 🏗️ Forge

**자체 에이전트를 직접 구축하세요!** – Forge는 에이전트 애플리케이션을 빠르게 구축할 수 있는 툴킷입니다. 대부분의 보일러플레이트 코드를 처리해주므로, 여러분만의 에이전트를 차별화하는 데 창의력을 집중할 수 있습니다. 모든 튜토리얼은 [여기](https://medium.com/@aiedge/autogpt-forge-e3de53cc58ec)에 있습니다. [`forge`](/classic/forge/)의 컴포넌트는 개별적으로도 사용할 수 있어, 개발을 가속화하고 보일러플레이트를 줄일 수 있습니다.

🚀 [**Forge 시작하기**](https://github.com/Significant-Gravitas/AutoGPT/blob/master/classic/forge/tutorials/001_getting_started.md) –
이 가이드는 자체 에이전트를 만드는 과정과 벤치마크 및 사용자 인터페이스 사용법을 안내합니다.

📘 [Forge 자세히 알아보기](https://github.com/Significant-Gravitas/AutoGPT/tree/master/classic/forge)

### 🎯 Benchmark

**에이전트 성능을 측정하세요!** `agbenchmark`는 에이전트 프로토콜을 지원하는 모든 에이전트와 사용할 수 있으며, 프로젝트의 [CLI]와 통합되어 AutoGPT 및 forge 기반 에이전트와 더욱 쉽게 사용할 수 있습니다. 이 벤치마크는 엄격한 테스트 환경을 제공합니다. 저희 프레임워크는 자율적이고 객관적인 성능 평가를 가능하게 하여, 실제 환경에 적합한 에이전트임을 보장합니다.

<!-- TODO: 벤치마크 시각화 이미지 삽입 -->

📦 [`agbenchmark`](https://pypi.org/project/agbenchmark/) (Pypi)
&ensp;|&ensp;
📘 [Benchmark 자세히 알아보기](https://github.com/Significant-Gravitas/AutoGPT/tree/master/classic/benchmark)

### 💻 UI

**에이전트를 쉽게 사용하세요!** `frontend`는 에이전트를 제어하고 모니터링할 수 있는 사용자 친화적 인터페이스를 제공합니다. [agent protocol](#-agent-protocol)을 통해 에이전트와 연결되어, 내부 및 외부의 다양한 에이전트와 호환됩니다.

<!-- TODO: 프론트엔드 스크린샷 삽입 -->

프론트엔드는 레포 내 모든 에이전트와 바로 연동됩니다. 원하는 에이전트를 [CLI]로 실행하세요!

📘 [프론트엔드 자세히 알아보기](https://github.com/Significant-Gravitas/AutoGPT/tree/master/classic/frontend)

### ⌨️ CLI

[CLI]: #-cli

저장소가 제공하는 모든 도구를 손쉽게 사용할 수 있도록, 루트 디렉터리에 CLI가 포함되어 있습니다:

```shell
$ ./run
Usage: cli.py [OPTIONS] COMMAND [ARGS]...

Options:
  --help  Show this message and exit.

Commands:
  agent      Commands to create, start and stop agents
  benchmark  Commands to start the benchmark and list tests and categories
  setup      Installs dependencies needed for your system.
```

레포를 클론한 후, `./run setup`으로 의존성을 설치하면 바로 시작할 수 있습니다!

## 🤔 질문? 문제? 제안?

### 도움 받기 - [Discord 💬](https://discord.gg/autogpt)

[![Join us on Discord](https://invidget.switchblade.xyz/autogpt)](https://discord.gg/autogpt)

버그 제보 또는 기능 요청은 [GitHub Issue](https://github.com/Significant-Gravitas/AutoGPT/issues/new/choose)를 생성해 주세요. 동일한 이슈가 이미 생성되어 있지 않은지 확인해 주세요.

## 🤝 자매 프로젝트

### 🔄 Agent Protocol

통일된 표준을 유지하고, 다양한 현존 및 미래의 애플리케이션과 완벽한 호환성을 보장하기 위해 AutoGPT는 AI Engineer Foundation의 [agent protocol](https://agentprotocol.ai/) 표준을 채택합니다. 이 표준은 에이전트에서 프론트엔드 및 벤치마크로의 통신 경로를 표준화합니다.

---

## Stars stats

<p align="center">
<a href="https://star-history.com/#Significant-Gravitas/AutoGPT">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=Significant-Gravitas/AutoGPT&type=Date&theme=dark" />
    <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=Significant-Gravitas/AutoGPT&type=Date" />
    <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=Significant-Gravitas/AutoGPT&type=Date" />
  </picture>
</a>
</p>

## ⚡ 기여자

<a href="https://github.com/Significant-Gravitas/AutoGPT/graphs/contributors" alt="View Contributors">
  <img src="https://contrib.rocks/image?repo=Significant-Gravitas/AutoGPT&max=1000&columns=10" alt="Contributors" />
</a>

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---