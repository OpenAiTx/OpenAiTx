# Visual Studio Code - 오픈 소스 ("Code - OSS")

[![Feature Requests](https://img.shields.io/github/issues/microsoft/vscode/feature-request.svg)](https://github.com/microsoft/vscode/issues?q=is%3Aopen+is%3Aissue+label%3Afeature-request+sort%3Areactions-%2B1-desc)
[![Bugs](https://img.shields.io/github/issues/microsoft/vscode/bug.svg)](https://github.com/microsoft/vscode/issues?utf8=✓&q=is%3Aissue+is%3Aopen+label%3Abug)
[![Gitter](https://img.shields.io/badge/chat-on%20gitter-yellow.svg)](https://gitter.im/Microsoft/vscode)

## 저장소

이 저장소("`Code - OSS`")는 Microsoft가 커뮤니티와 함께 [Visual Studio Code](https://code.visualstudio.com) 제품을 개발하는 곳입니다. 여기서는 코드 및 이슈 관리뿐만 아니라, 우리의 [로드맵](https://github.com/microsoft/vscode/wiki/Roadmap), [월간 반복 계획](https://github.com/microsoft/vscode/wiki/Iteration-Plans), [엔드게임 계획](https://github.com/microsoft/vscode/wiki/Running-the-Endgame)도 게시합니다. 이 소스 코드는 표준 [MIT 라이선스](https://github.com/microsoft/vscode/blob/main/LICENSE.txt)에 따라 모든 사람에게 공개되어 있습니다.

## Visual Studio Code

<p align="center">
  <img alt="VS Code in action" src="https://user-images.githubusercontent.com/35271042/118224532-3842c400-b438-11eb-923d-a5f66fa6785a.png">
</p>

[Visual Studio Code](https://code.visualstudio.com)는 Microsoft의 맞춤화가 적용된 `Code - OSS` 저장소의 배포본으로, 전통적인 [Microsoft 제품 라이선스](https://code.visualstudio.com/License/) 하에 배포됩니다.

[Visual Studio Code](https://code.visualstudio.com)는 코드 에디터의 단순함과 개발자가 핵심적인 편집-빌드-디버그 사이클에서 필요한 기능을 결합한 제품입니다. 이 제품은 포괄적인 코드 편집, 탐색 및 이해 지원, 경량 디버깅, 풍부한 확장성 모델, 기존 도구와의 경량 통합을 제공합니다.

Visual Studio Code는 매월 새로운 기능과 버그 수정이 이루어집니다. [Visual Studio Code 웹사이트](https://code.visualstudio.com/Download)에서 Windows, macOS, Linux용으로 다운로드할 수 있습니다. 최신 릴리스를 매일 받고 싶다면 [Insiders 빌드](https://code.visualstudio.com/insiders)를 설치하세요.

## 기여 방법

이 프로젝트에 참여할 수 있는 방법은 다양합니다. 예를 들어:

* [버그 및 기능 요청 제출](https://github.com/microsoft/vscode/issues) 및 확인 작업에 도움 주기
* [소스 코드 변경 사항 검토](https://github.com/microsoft/vscode/pulls)
* [문서 검토](https://github.com/microsoft/vscode-docs) 및 오타, 추가/신규 콘텐츠에 대한 풀 리퀘스트 생성

이슈를 수정하고 코드베이스에 직접 기여하고 싶으시다면, [기여 방법](https://github.com/microsoft/vscode/wiki/How-to-Contribute) 문서를 참고하세요. 이 문서에는 다음이 포함됩니다:

* [소스에서 빌드 및 실행하는 방법](https://github.com/microsoft/vscode/wiki/How-to-Contribute)
* [디버깅 및 테스트 실행을 포함한 개발 워크플로우](https://github.com/microsoft/vscode/wiki/How-to-Contribute#debugging)
* [코딩 가이드라인](https://github.com/microsoft/vscode/wiki/Coding-Guidelines)
* [풀 리퀘스트 제출 방법](https://github.com/microsoft/vscode/wiki/How-to-Contribute#pull-requests)
* [작업할 이슈 찾기](https://github.com/microsoft/vscode/wiki/How-to-Contribute#where-to-contribute)
* [번역 기여](https://aka.ms/vscodeloc)

## 피드백

* [Stack Overflow](https://stackoverflow.com/questions/tagged/vscode)에서 질문하기
* [새로운 기능 요청](CONTRIBUTING.md)
* [인기 있는 기능 요청에 추천](https://github.com/microsoft/vscode/issues?q=is%3Aopen+is%3Aissue+label%3Afeature-request+sort%3Areactions-%2B1-desc)
* [이슈 등록](https://github.com/microsoft/vscode/issues)
* [GitHub Discussions](https://github.com/microsoft/vscode-discussions/discussions) 또는 [Slack](https://aka.ms/vscode-dev-community)에서 확장 프로그램 저자 커뮤니티와 소통
* [@code](https://twitter.com/code)를 팔로우하고 의견을 알려주세요!

각 채널에 대한 설명과 기타 커뮤니티 기반 채널 정보는 [wiki](https://github.com/microsoft/vscode/wiki/Feedback-Channels)를 참조하세요.

## 관련 프로젝트

VS Code의 핵심 구성 요소 및 확장 프로그램 중 상당수는 GitHub의 별도 저장소에 있습니다. 예를 들어, [node debug adapter](https://github.com/microsoft/vscode-node-debug)와 [mono debug adapter](https://github.com/microsoft/vscode-mono-debug) 저장소는 서로 별개입니다. 전체 목록은 우리의 [wiki](https://github.com/microsoft/vscode/wiki)의 [Related Projects](https://github.com/microsoft/vscode/wiki/Related-Projects) 페이지를 방문하세요.

## 번들 확장 프로그램

VS Code는 [extensions](extensions) 폴더에 내장 확장 프로그램 세트를 포함하고 있으며, 다양한 언어의 문법 및 스니펫을 포함합니다. 언어에 대한 풍부한 언어 지원(코드 완성, 정의로 이동 등)을 제공하는 확장 프로그램에는 `language-features` 접미사가 붙습니다. 예를 들어, `json` 확장 프로그램은 `JSON`에 대한 색상 지정 기능을 제공하고, `json-language-features` 확장 프로그램은 `JSON`에 대한 풍부한 언어 지원을 제공합니다.

## 개발 컨테이너

이 저장소에는 Visual Studio Code Dev Containers / GitHub Codespaces 개발 컨테이너가 포함되어 있습니다.

* [Dev Containers](https://aka.ms/vscode-remote/download/containers)의 경우, **Dev Containers: Clone Repository in Container Volume...** 명령을 사용하여 macOS 및 Windows에서 디스크 I/O 성능이 더 우수한 Docker 볼륨을 생성하세요.
  * 이미 VS Code와 Docker가 설치되어 있다면, [여기](https://vscode.dev/redirect?url=vscode://ms-vscode-remote.remote-containers/cloneInVolume?url=https://github.com/microsoft/vscode)를 클릭하여 시작할 수도 있습니다. 이 작업은 필요시 Dev Containers 확장 프로그램을 자동으로 설치하고, 소스 코드를 컨테이너 볼륨에 복제하며, 개발 컨테이너를 구동합니다.

* Codespaces의 경우, VS Code에 [GitHub Codespaces](https://marketplace.visualstudio.com/items?itemName=GitHub.codespaces) 확장 프로그램을 설치하고, **Codespaces: Create New Codespace** 명령을 사용하세요.

Docker 또는 Codespace는 전체 빌드를 실행하려면 최소 **4코어, 6GB RAM(권장 8GB)** 이상이어야 합니다. 자세한 내용은 [development container README](.devcontainer/README.md)를 참고하세요.

## 행동 강령

이 프로젝트는 [Microsoft 오픈 소스 행동 강령](https://opensource.microsoft.com/codeofconduct/)을 채택하고 있습니다. 자세한 내용은 [행동 강령 FAQ](https://opensource.microsoft.com/codeofconduct/faq/)를 확인하거나 추가 질문이나 의견은 [opencode@microsoft.com](mailto:opencode@microsoft.com)으로 문의하세요.

## 라이선스

Copyright (c) Microsoft Corporation. All rights reserved.

[MIT](LICENSE.txt) 라이선스 하에 사용이 허가됩니다.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---