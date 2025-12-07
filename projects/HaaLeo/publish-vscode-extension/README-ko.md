# VS Code 확장 프로그램 배포 — GitHub 액션

[![빌드, 린트, 테스트 및 배포](https://img.shields.io/github/actions/workflow/status/HaaLeo/publish-vscode-extension/CI.yml?style=flat-square&label=Lint%2C%20Build%2C%20Test%20and%20Deploy)](https://github.com/HaaLeo/publish-vscode-extension/actions?query=workflow%3A%22Build%2C+Lint%2C+Test+and+Deploy%22) [![커버리지 상태](https://img.shields.io/coveralls/github/HaaLeo/publish-vscode-extension?style=flat-square)](https://coveralls.io/github/HaaLeo/publish-vscode-extension)  
[![라이선스](https://img.shields.io/badge/license-MIT-brightgreen.svg?style=flat-square)](https://raw.githubusercontent.com/HaaLeo/publish-vscode-extension/master/LICENSE.txt) [![별점](https://img.shields.io/github/stars/HaaLeo/publish-vscode-extension.svg?label=Stars&logo=github&style=flat-square)](https://github.com/HaaLeo/publish-vscode-extension/stargazers)  
[![기부](https://img.shields.io/badge/☕️-Buy%20Me%20a%20Coffee-blue.svg?&style=flat-square)](https://www.paypal.me/LeoHanisch/3eur)

GitHub 액션을 사용하여 VS Code 확장 프로그램을 [Open VSX Registry](https://open-vsx.org/) 또는 [Visual Studio Marketplace](https://marketplace.visualstudio.com)에 배포합니다.

> **v2**의 모든 주요 변경 사항은 [변경 로그](https://raw.githubusercontent.com/HaaLeo/publish-vscode-extension/master/CHANGELOG.md#changelog)에 나열되어 있습니다.

## 사용법

GitHub 액션을 사용하려면 워크플로우 파일에서 [액션을 참조](https://help.github.com/en/actions/configuring-and-managing-workflows/configuring-a-workflow#referencing-actions-in-your-workflow)하기만 하면 됩니다.

### 예제

다음 예제는 새 태그가 생성될 때 Open VSX Registry와 Visual Studio Marketplace에 확장 프로그램을 배포하는 워크플로우를 보여줍니다:

```yaml
on:
  push:
    tags:
      - "*"

name: Deploy Extension
jobs:
  deploy:
    runs-on: ubuntu-latest
    steps:
      - uses: actions/checkout@v4
      - uses: actions/setup-node@v4
        with:
          node-version: 20
      - run: npm ci
      - name: Publish to Open VSX Registry
        uses: HaaLeo/publish-vscode-extension@v2
        with:
          pat: ${{ secrets.OPEN_VSX_TOKEN }}
      - name: Publish to Visual Studio Marketplace
        uses: HaaLeo/publish-vscode-extension@v2
        with:
          pat: ${{ secrets.VS_MARKETPLACE_TOKEN }}
          registryUrl: https://marketplace.visualstudio.com
```
확장 프로그램을 한 번만 패키징하고 **동일한** `.vsix` 파일을 두 레지스트리에 모두 게시하려면 다음 두 단계를 대신 사용할 수 있습니다:


```yaml
- name: Publish to Open VSX Registry
  uses: HaaLeo/publish-vscode-extension@v2
  id: publishToOpenVSX
  with:
    pat: ${{ secrets.OPEN_VSX_TOKEN }}
- name: Publish to Visual Studio Marketplace
  uses: HaaLeo/publish-vscode-extension@v2
  with:
    pat: ${{ secrets.VS_MARKETPLACE_TOKEN }}
    registryUrl: https://marketplace.visualstudio.com
    extensionFile: ${{ steps.publishToOpenVSX.outputs.vsixPath }}
```
더 완전하고 복잡한 예제를 원한다면 [`HaaLeo/vscode-timing`](https://github.com/HaaLeo/vscode-timing/blob/master/.github/workflows/cicd.yml#L1)의 워크플로우를 확인할 수 있습니다.

### Open VSX 레지스트리

Open VSX 레지스트리에 게시하려면 [확장 프로그램의 네임스페이스](https://github.com/eclipse/openvsx/wiki/Publishing-Extensions#2-create-the-namespace)가 **사전에** 생성되어 있어야 합니다.  
`pat` 매개변수에는 [Open VSX 액세스 토큰](https://github.com/eclipse/openvsx/wiki/Publishing-Extensions#1-create-an-access-token)을 설정해야 합니다.  
또한, 라이선스가 명시된 확장 프로그램만 게시해야 합니다.  
Open VSX의 일정 및 확장 프로그램 라이선스에 관한 자세한 내용은 [Brian King의 블로그](https://blogs.eclipse.org/post/brian-king/open-vsx-registry-under-new-management) (섹션 "Licensing" 및 "Timeline")를 참고하세요.

현재 이 GitHub 액션은 라이선스 조건을 명시하지 않은 확장 프로그램의 게시도 허용합니다.  
하지만 이 동작은 더 이상 권장되지 않으며, 향후 릴리스에서는 라이선스가 없는 확장 프로그램을 거부할 예정입니다.  
따라서 [MIT 라이선스](https://choosealicense.com/licenses/mit/)와 같은 (허용적인) 라이선스를 가진 확장 프로그램을 게시하는 것을 강력히 권장합니다.

### Visual Studio 마켓플레이스

VS 마켓플레이스에 확장 프로그램을 업로드하려면 `pat` 옵션에 해당 [액세스 토큰](https://code.visualstudio.com/api/working-with-extensions/publishing-extension#get-a-personal-access-token)을 설정해야 합니다.  
또한, `registryUrl`은 `https://marketplace.visualstudio.com`으로 설정해야 합니다.

## 입력 매개변수

다음 입력 매개변수 중 일부 또는 모두를 설정할 수 있습니다:

|이름 |타입 |필수? |기본값 |설명
|-|-|-|-|-
|`pat` |string  |예 |-|해당 레지스트리의 개인 액세스 토큰입니다.
|`extensionFile` |string  |아니오 | - |게시할 vsix 파일 경로입니다. `packagePath`와 함께 설정할 경우 이 옵션이 우선합니다.
|`registryUrl` |string  |아니오 |`https://open-vsx.org` |이 기본 URL의 레지스트리 API를 사용합니다.
|`packagePath` |string |아니오 | `./` |패키징 및 게시할 확장 프로그램 경로입니다. `extensionFile`이 설정되면 무시됩니다.
|`baseContentUrl` |string |아니오 | - |README.md 내 모든 상대 링크에 이 URL을 접두어로 붙입니다.
|`baseImagesUrl` |string |아니오 | - |README.md 내 모든 상대 이미지 링크에 이 URL을 접두어로 붙입니다.
|`yarn` |boolean |아니오 | `false` |확장 파일을 패키징할 때 npm 대신 yarn을 사용합니다.
|`dryRun` |boolean |아니오 | `false` |이 옵션을 `true`로 설정하면 확장 프로그램을 패키징만 하고 게시하지 않습니다. 이 옵션 사용 시 `pat` 옵션은 임시값으로 설정하세요.
|`noVerify` |boolean| 아니오 |`false` |제안된 API(enableProposedApi: true)를 사용하는 확장 프로그램을 Visual Studio 마켓플레이스에 게시할 수 있게 허용합니다. vsce의 `--noVerify` 명령줄 인수와 유사합니다.
|`preRelease` |boolean| 아니오 |`false` |확장 프로그램 릴리스를 사전 릴리스로 표시합니다. 확장 프로그램 패키징 시에만 적용됩니다.
|`dependencies` |boolean| 아니오 |`true` |`package.json`에 정의된 의존성이 `node_modules`에 존재하는지 확인합니다. pnpm 또는 yarn v2+의 PnP를 사용하는 경우 `false`로 설정하세요.
|`skipDuplicate` |boolean| 아니오 |`false` |버전이 이미 마켓플레이스에 존재하면 조용히 실패합니다. vsce CLI의 `--skip-duplicate` 옵션과 동일합니다.
|`target` |string| 아니오 | - |확장 프로그램이 실행될 대상 아키텍처입니다. 여러 대상을 공백으로 구분합니다. 예: `'win32-x64 linux-x64'`



## 출력값

이 액션은 다음과 같은 출력값을 제공합니다:

|이름 |유형 |설명
|-|-|-
|`vsixPath` |string |패키징되고 게시된 VSIX 파일의 경로입니다.

## 기여

버그를 발견했거나 기능이 부족한 경우 주저하지 말고 [이슈를 등록](https://github.com/HaaLeo/publish-vscode-extension/issues/new/choose)하세요.  
풀 리퀘스트도 환영합니다!  
코드 변경을 제출하려면 먼저 [CONTRIBUTING.md](https://raw.githubusercontent.com/HaaLeo/publish-vscode-extension/master/./CONTRIBUTING.md) 파일을 확인하세요.

## 지원

이 확장 기능이 마음에 든다면 꼭 [저장소에 별표를 주세요](https://github.com/HaaLeo/publish-vscode-extension/stargazers). 저는 항상 새로운 아이디어와 피드백을 기다리고 있습니다.  
또한 [페이팔을 통한 기부](https://www.paypal.me/LeoHanisch/3eur)도 가능합니다.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-07

---