<picture>
  <source media="(prefers-color-scheme: dark)" srcset="https://raw.githubusercontent.com/velopack/velopack/develop/artwork/velopack-white.svg">
  <img alt="Velopack Logo" src="https://raw.githubusercontent.com/velopack/velopack/develop/artwork/velopack-black.svg" width="400">
</picture>

---

[![Nuget](https://img.shields.io/nuget/v/Velopack?style=flat-square&logo=nuget&logoColor=white)](https://www.nuget.org/packages/Velopack/)
[![Discord](https://img.shields.io/badge/chat-Discord-5865F2?style=flat-square&logo=discord&logoColor=white)](https://discord.gg/M6he8ZPAAJ)
[![Build](https://img.shields.io/github/actions/workflow/status/velopack/velopack/build.yml?branch=develop&style=flat-square&logo=github&logoColor=white)](https://github.com/velopack/velopack/actions)
[![Codecov](https://img.shields.io/codecov/c/github/velopack/velopack?style=flat-square&logo=codecov&logoColor=white)](https://app.codecov.io/gh/velopack/velopack)
[![License](https://img.shields.io/github/license/velopack/velopack?style=flat-square)](https://github.com/velopack/velopack/blob/develop/LICENSE)

Velopack은 크로스 플랫폼 애플리케이션을 위한 설치 및 자동 업데이트 프레임워크입니다. 확고한 의견을 갖고 있으며, 별도의 설정 없이 매우 쉽게 사용할 수 있습니다. 단 한 번의 명령어로 설치 가능한 애플리케이션을 빠르게 시작할 수 있으며, 사용자에게도 매우 빠른 경험을 제공합니다.

## 특징

- 😍 **제로 설정** – Velopack은 컴파일러 출력물을 받아 단 한 번의 명령어로 설치 프로그램, 업데이트, 델타 패키지, 그리고 자체 업데이트가 가능한 포터블 패키지를 생성합니다.
- 🎯 **크로스 플랫폼** – Velopack은 **Windows**, **OSX**, **Linux**용 패키지 빌드를 지원하므로, 하나의 솔루션으로 모든 타겟을 대응할 수 있습니다.
- 🚀 **자동 마이그레이션** - 다른 인기 프레임워크(예: [Squirrel](https://github.com/Squirrel/Squirrel.Windows))를 사용하셨다면, Velopack이 애플리케이션을 자동으로 마이그레이션할 수 있습니다.
- ⚡️ **번개 같은 속도** – Velopack은 네이티브 성능을 위해 Rust로 작성되었습니다. 델타 패키지 덕분에 사용자는 버전 간 변경된 부분만 다운로드하면 됩니다.
- 📔 **언어 독립적** - C#, C++, JS, Rust 등 다양한 언어를 지원합니다. 프로젝트의 언어와 관계없이 익숙한 API로 업데이트를 사용할 수 있습니다.

https://github.com/velopack/velopack/assets/1287295/0ff1bea7-15ed-42ae-8bdd-9519f1033432

## 문서
- 📖 [문서 읽기](https://docs.velopack.io/)
- ⚡ [빠른 시작 가이드](https://docs.velopack.io/category/quick-start)
- 🕶️ [예제 앱 보기](https://docs.velopack.io/category/sample-apps)
- 📺 [웹사이트 및 데모 보기](https://velopack.io/)

## 커뮤니티
- ❓ [Discord](https://discord.gg/CjrCrNzd3F)에서 질문하고, 지원을 받거나 아이디어를 논의하세요
- 🗣️ [GitHub Issues](https://github.com/velopack/velopack/issues)에서 버그를 보고하거나 기능을 요청하세요

## 기여하기
- 💬 개발 논의에 참여하려면 [Discord](https://discord.gg/CjrCrNzd3F)에 참여하세요
- 🚦 [기여 가이드](https://docs.velopack.io/category/contributing)를 읽어보세요

## 사용자 후기 
이제 외부용 애플리케이션에 velopack을 사용하게 되었습니다. 정말 인상 깊습니다. 초기 빌드와 최종 사용자 컴퓨터에서의 소프트웨어 업그레이드 모두 Squirrel보다 훨씬 빠르고 완벽하게 동작하는 것 같습니다. 30년 넘게 개발을 해오면서 사용해본 것 중 최고의 설치 프로그램입니다. 정말 감사합니다! 훌륭한 작업을 하고 계십니다!
[- Stefan (Discord)](https://discord.com/channels/767856501477343282/767856501477343286/1195642674078830613)

정말 큰 감사를 드리고 싶습니다. Squirrel.Windows가 저에게 맞지 않아 수년간 Clowd.Squirrel을 사용해왔는데, 오늘 문서를 찾아보려 해당 저장소에 들렀다가 Velopack 출시 소식을 접하게 되었습니다. 정말 예상치 못했는데, 환상적으로 잘 작동하고 훨씬 빠릅니다, 와우! 다시 한 번 감사드리며, Clowd.Squirrel과 Velopack 모두에 들어간 작업량이 엄청나네요. 정말 감사하게 생각합니다.
[- Kizari (Discord)](https://discord.com/channels/767856501477343282/767856501477343286/1200837489640878180)

많은 설치 프레임워크를 사용해 봤지만 Velopack이 단연 최고입니다. 모든 것이 마법 같습니다: 설치 프로그램을 실행하면 앱이 바로 열리고 사용할 준비가 됩니다. 업데이트는 약 2초 만에 적용되고 다시 실행되며 UAC 프롬프트도 없습니다. 설치 프로그램 제작 과정도 간편하고 코드 서명과 쉽게 통합되며, 커맨드라인 도구를 통해 업데이트 파일을 간단히 업로드할 수 있습니다. 별도의 설치 스크립트 언어를 다룰 필요 없이, 이러한 후크를 메인 앱에 모두 포함할 수 있습니다! 지원도 훌륭하며, 제가 제기한 모든 문제에 대해 빠르게 대응받았습니다. 이것이 데스크탑 설치 프로그램의 미래입니다.
[- RandomEngy (Discord)](https://discord.com/channels/767856501477343282/947444323765583913/1200897478036299861)

Velopack의 릴리스 생성, 업데이트 확인 및 적용 성능에 매우 감명받았습니다. 다른 도구들보다 확연히 빠릅니다. vpk CLI는 직관적이고 복잡한 빌드 파이프라인에서도 쉽게 구현할 수 있습니다. Velopack 덕분에 작업 흐름을 간소화하고 소중한 시간을 절약할 수 있었습니다. 정말 환상적인 도구이며 적극 추천합니다!
[- khdc (Discord)](https://discord.com/channels/767856501477343282/947444323765583913/1216460920696344576)

---

Powered By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---