# 프롬프트 플로우

[![Python package](https://img.shields.io/pypi/v/promptflow)](https://pypi.org/project/promptflow/)
[![Python](https://img.shields.io/pypi/pyversions/promptflow.svg?maxAge=2592000)](https://pypi.python.org/pypi/promptflow/)
[![PyPI - Downloads](https://img.shields.io/pypi/dm/promptflow)](https://pypi.org/project/promptflow/)
[![CLI](https://img.shields.io/badge/CLI-reference-blue)](https://microsoft.github.io/promptflow/reference/pf-command-reference.html)
[![vsc extension](https://img.shields.io/visual-studio-marketplace/i/prompt-flow.prompt-flow?logo=Visual%20Studio&label=Extension%20)](https://marketplace.visualstudio.com/items?itemName=prompt-flow.prompt-flow)

[![Doc](https://img.shields.io/badge/Doc-online-green)](https://microsoft.github.io/promptflow/index.html)
[![Issue](https://img.shields.io/github/issues/microsoft/promptflow)](https://github.com/microsoft/promptflow/issues/new/choose)
[![Discussions](https://img.shields.io/github/discussions/microsoft/promptflow)](https://github.com/microsoft/promptflow/issues/new/choose)
[![CONTRIBUTING](https://img.shields.io/badge/Contributing-8A2BE2)](https://github.com/microsoft/promptflow/blob/main/CONTRIBUTING.md)
[![License: MIT](https://img.shields.io/github/license/microsoft/promptflow)](https://github.com/microsoft/promptflow/blob/main/LICENSE)

> 프롬프트 플로우를 더 나은 도구로 만들기 위해
> [토론](https://github.com/microsoft/promptflow/discussions)에 참여하거나,
> [이슈](https://github.com/microsoft/promptflow/issues/new/choose)를 등록하거나,
> [PR](https://github.com/microsoft/promptflow/pulls)을 제출해 주시기 바랍니다.

**프롬프트 플로우**는 LLM 기반 AI 애플리케이션의 아이디어 구상, 프로토타이핑, 테스트, 평가, 프로덕션 배포 및 모니터링에 이르는 개발 주기를 간소화하는 개발 도구 모음입니다. 프롬프트 엔지니어링을 훨씬 쉽게 만들며, 프로덕션 품질의 LLM 앱을 구축할 수 있도록 지원합니다.

프롬프트 플로우를 사용하면 다음과 같은 작업이 가능합니다:

- **플로우 생성 및 반복 개발**
    - LLM, 프롬프트, Python 코드, 기타 [도구](https://microsoft.github.io/promptflow/concepts/concept-tools.html)들을 연결하는 실행 가능한 [플로우](https://microsoft.github.io/promptflow/concepts/concept-flows.html)를 생성할 수 있습니다.
    - 특히 [LLM과의 상호작용 추적](https://microsoft.github.io/promptflow/how-to-guides/tracing/index.html)을 통해 플로우를 쉽게 디버깅하고 반복할 수 있습니다.
- **플로우 품질 및 성능 평가**
    - 더 큰 데이터셋을 사용하여 플로우의 품질과 성능을 평가할 수 있습니다.
    - 테스트 및 평가를 CI/CD 시스템에 통합하여 플로우의 품질을 보장할 수 있습니다.
- **프로덕션을 위한 개발 주기 간소화**
    - 원하는 서빙 플랫폼에 플로우를 배포하거나 앱의 코드베이스에 쉽게 통합할 수 있습니다.
    - (선택 사항이지만 적극 권장) [Azure AI의 Prompt flow](https://learn.microsoft.com/en-us/azure/machine-learning/prompt-flow/overview-what-is-prompt-flow?view=azureml-api-2) 클라우드 버전을 활용해 팀과 협업할 수 있습니다.

------

## 설치

빠르게 시작하려면, 미리 구축된 개발 환경을 사용할 수 있습니다. **아래 버튼을 클릭**하여 GitHub Codespaces에서 레포를 열고, README를 따라 진행하세요!

[![Open in GitHub Codespaces](https://github.com/codespaces/badge.svg)](https://codespaces.new/microsoft/promptflow?quickstart=1)

로컬 환경에서 시작하려면, 먼저 패키지를 설치하세요:

파이썬 환경을 준비하고, `python>=3.9, <=3.11` 버전을 권장합니다.

```sh
pip install promptflow promptflow-tools
```

## 빠른 시작 ⚡

**프롬프트 플로우로 챗봇 만들기**

챗 템플릿에서 프롬프트 플로우를 초기화하는 명령을 실행하면, `my_chatbot`이라는 폴더가 생성되고 필요한 파일이 그 안에 생성됩니다:

```sh
pf flow init --flow ./my_chatbot --type chat
```

**API 키 연결 설정**

OpenAI 키의 경우, `my_chatbot` 폴더 내의 `openai.yaml` 파일을 사용하여 아래 명령어로 연결을 설정합니다. 이 파일에 OpenAI 키가 저장됩니다(키와 이름을 --set으로 덮어써 yaml 파일 변경 없이 사용 가능):

```sh
pf connection create --file ./my_chatbot/openai.yaml --set api_key=<your_api_key> --name open_ai_connection
```

Azure OpenAI 키의 경우, `azure_openai.yaml` 파일을 사용하여 아래 명령어로 연결을 설정합니다:

```sh
pf connection create --file ./my_chatbot/azure_openai.yaml --set api_key=<your_api_key> api_base=<your_api_base> --name open_ai_connection
```

**플로우와 대화하기**

`my_chatbot` 폴더 내에는 플로우의 입력/출력, 노드, 연결, LLM 모델 등이 정의된 `flow.dag.yaml` 파일이 있습니다.

> 참고: `chat` 노드에서는 `connection` 필드에 지정된 `open_ai_connection` 연결을 사용하고, `deployment_name` 필드에 지정된 `gpt-35-turbo` 모델을 사용합니다. deployment_name 필드는 OpenAI 모델 또는 Azure OpenAI 배포 리소스를 지정합니다.

아래 명령어로 챗봇과 대화할 수 있습니다 (`Ctrl + C`로 종료):

```sh
pf flow test --flow ./my_chatbot --interactive
```

**핵심 가치: 프로토타입에서 프로덕션까지 "고품질" 보장**

프롬프트 튜닝 ➡ 배치 테스트 ➡ 평가까지 고품질 프로덕션 준비를 위한 [**15분 튜토리얼**](https://raw.githubusercontent.com/microsoft/promptflow/main/examples/tutorials/flow-fine-tuning-evaluation/promptflow-quality-improvement.md)을 확인해보세요.

다음 단계! 프롬프트 플로우를 더 깊이 이해하려면 **튜토리얼** 👇 섹션을 계속 진행하세요.

## 튜토리얼 🏃‍♂️

프롬프트 플로우는 **고품질 LLM 앱을 구축**하기 위한 도구로, 개발 과정은 플로우 개발, 플로우 품질 향상, 프로덕션 배포의 단계로 이루어집니다.

### 나만의 LLM 앱 개발하기

#### VS Code 확장 프로그램

UI 기반의 상호작용형 플로우 개발 경험을 위한 VS Code 확장(플로우 디자이너)도 제공합니다.

<img src="https://raw.githubusercontent.com/microsoft/promptflow/main/docs/media/readme/vsc.png" alt="vsc" width="1000"/>

<a href="https://marketplace.visualstudio.com/items?itemName=prompt-flow.prompt-flow">Visual Studio Marketplace</a>에서 설치할 수 있습니다.

#### 플로우 개발 심층 탐구

[프롬프트 플로우 시작하기](https://raw.githubusercontent.com/microsoft/promptflow/main/docs/how-to-guides/quick-start.md): 플로우 실행을 단계별로 안내합니다.

### 사용 사례로 배우기

[튜토리얼: PDF와 채팅하기](https://github.com/microsoft/promptflow/blob/main/examples/tutorials/e2e-development/chat-with-pdf.md): 프롬프트 플로우로 고품질 챗 애플리케이션을 구축하는 end-to-end 튜토리얼로, 플로우 개발 및 메트릭 기반 평가를 포함합니다.
> 더 많은 예시는 [여기](https://microsoft.github.io/promptflow/tutorials/index.html#samples)에서 확인할 수 있습니다. 새로운 사용 사례의 기여를 환영합니다!

### 기여자용 환경 설정

기여에 관심이 있다면, [dev_setup.md](https://raw.githubusercontent.com/microsoft/promptflow/main/docs/dev/dev_setup.md)에서 개발 환경 설정 가이드로 시작하세요.

다음 단계! 프롬프트 플로우에 기여하려면 **Contributing** 👇 섹션을 참고하세요.

## 기여하기

이 프로젝트는 기여와 제안을 환영합니다. 대부분의 기여에는
Contributor License Agreement (CLA)에 동의해야 합니다. 이는 귀하가
기여물을 사용할 수 있는 권리를 가지고 있으며, 실제로 그 권리를 부여한다는 것을 선언합니다.
자세한 내용은 https://cla.opensource.microsoft.com 를 참고하세요.

풀 리퀘스트(PR)를 제출하면 CLA 봇이 자동으로 CLA 필요 여부를 판단하고,
PR에 상태 확인, 댓글 등으로 표시합니다. 봇의 안내를 따라주시면 됩니다.
CLA는 모든 CLA 적용 저장소에 대해 한 번만 동의하시면 됩니다.

이 프로젝트는 [Microsoft 오픈 소스 행동 강령](https://opensource.microsoft.com/codeofconduct/)을 채택하였습니다.
자세한 내용은 [행동 강령 FAQ](https://opensource.microsoft.com/codeofconduct/faq/) 또는
[opencode@microsoft.com](mailto:opencode@microsoft.com)으로 문의하세요.

## 상표

이 프로젝트에는 프로젝트, 제품 또는 서비스의 상표 또는 로고가 포함될 수 있습니다.
Microsoft 상표 또는 로고의 허가된 사용은 반드시
[Microsoft 상표 및 브랜드 가이드라인](https://www.microsoft.com/en-us/legal/intellectualproperty/trademarks/usage/general)을 따라야 합니다.
이 프로젝트의 수정된 버전에서 Microsoft 상표 또는 로고를 사용할 때 혼동을 초래하거나 Microsoft의 후원을 암시해서는 안 됩니다.
타사 상표 또는 로고의 사용은 해당 타사의 정책이 적용됩니다.

## 행동 강령

이 프로젝트는 [Microsoft 오픈 소스 행동 강령](https://opensource.microsoft.com/codeofconduct/)을 채택하였습니다.
자세한 내용은 [행동 강령 FAQ](https://opensource.microsoft.com/codeofconduct/faq/) 또는
[opencode@microsoft.com](mailto:opencode@microsoft.com)으로 문의하세요.

## 데이터 수집

이 소프트웨어는 귀하와 귀하의 소프트웨어 사용에 대한 정보를 수집하여,
설정에 따라 Microsoft로 전송할 수 있습니다.
Microsoft는 이 정보를 서비스 제공 및 제품·서비스 개선에 사용할 수 있습니다.
텔레메트리는 저장소에 안내된 대로 활성화할 수 있습니다.
또한 소프트웨어의 일부 기능을 통해 귀하와 Microsoft가 애플리케이션 사용자로부터 데이터를 수집할 수 있습니다.
이러한 기능을 사용할 경우, 관련 법률을 준수해야 하며,
애플리케이션 사용자에게 적절한 고지와 Microsoft의 개인정보처리방침 사본을 제공해야 합니다.
Microsoft의 개인정보처리방침은 https://go.microsoft.com/fwlink/?LinkID=824704 에 있습니다.
데이터 수집 및 사용에 대해 더 알고 싶다면 도움말 문서와 개인정보처리방침을 참고하세요.
소프트웨어를 사용함으로써 이러한 관행에 동의하는 것으로 간주됩니다.

### 텔레메트리 설정

텔레메트리 수집은 기본적으로 활성화되어 있습니다.

비활성화하려면 `pf config set telemetry.enabled=false` 명령어를 실행하세요.

## 라이선스

Copyright (c) Microsoft Corporation. All rights reserved.

[MIT](https://raw.githubusercontent.com/microsoft/promptflow/main/LICENSE) 라이선스 하에 제공됩니다.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---