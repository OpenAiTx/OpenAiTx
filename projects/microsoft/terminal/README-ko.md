![terminal-logos](https://github.com/microsoft/terminal/assets/91625426/333ddc76-8ab2-4eb4-a8c0-4d7b953b1179)

[![Terminal Build Status](https://dev.azure.com/shine-oss/terminal/_apis/build/status%2FTerminal%20CI?branchName=main)](https://dev.azure.com/shine-oss/terminal/_build/latest?definitionId=1&branchName=main)

# Windows Terminal, 콘솔 및 명령줄 저장소에 오신 것을 환영합니다

<details>
  <summary><strong>목차</strong></summary>

- [Windows Terminal 설치 및 실행](#windows-terminal-설치-및-실행)
  - [Microsoft Store [권장]](#microsoft-store-권장)
  - [기타 설치 방법](#기타-설치-방법)
    - [GitHub를 통한 설치](#github를-통한-설치)
    - [Windows 패키지 관리자 CLI(winget)를 통한 설치](#windows-패키지-관리자-cli-winget를-통한-설치)
    - [Chocolatey를 통한 설치(비공식)](#chocolatey를-통한-설치비공식)
    - [Scoop을 통한 설치(비공식)](#scoop을-통한-설치비공식)
- [Windows Terminal Canary 설치](#windows-terminal-canary-설치)
- [Windows Terminal 로드맵](#windows-terminal-로드맵)
- [Terminal & Console 개요](#terminal--console-개요)
  - [Windows Terminal](#windows-terminal)
  - [Windows Console Host](#windows-console-host)
  - [공유 컴포넌트](#공유-컴포넌트)
  - [새 Windows Terminal 만들기](#새-windows-terminal-만들기)
- [자료](#자료)
- [FAQ](#faq)
  - [새 Terminal을 빌드 및 실행했는데, 이전 콘솔과 동일하게 보입니다](#새-terminal을-빌드-및-실행했는데-이전-콘솔과-동일하게-보입니다)
- [문서](#문서)
- [기여하기](#기여하기)
- [팀과의 소통](#팀과의-소통)
- [개발자 안내](#개발자-안내)
- [사전 요구사항](#사전-요구사항)
- [코드 빌드](#코드-빌드)
  - [PowerShell에서 빌드](#powershell에서-빌드)
  - [Cmd에서 빌드](#cmd에서-빌드)
- [실행 및 디버깅](#실행-및-디버깅)
  - [코딩 가이드](#코딩-가이드)
- [행동 강령](#행동-강령)

</details>

<br />

이 저장소에는 다음의 소스 코드가 포함되어 있습니다:

* [Windows Terminal](https://aka.ms/terminal)
* [Windows Terminal Preview](https://aka.ms/terminal-preview)
* Windows 콘솔 호스트(`conhost.exe`)
* 두 프로젝트에서 공유되는 컴포넌트
* [ColorTool](./src/tools/ColorTool)
* [샘플 프로젝트](./samples)
  (Windows Console API를 사용하는 방법을 보여줍니다)

관련 저장소는 다음과 같습니다:

* [Windows Terminal 문서](https://docs.microsoft.com/windows/terminal)
  ([문서 기여 저장소](https://github.com/MicrosoftDocs/terminal))
* [콘솔 API 문서](https://github.com/MicrosoftDocs/Console-Docs)
* [Cascadia Code 폰트](https://github.com/Microsoft/Cascadia-Code)

## Windows Terminal 설치 및 실행

> [!NOTE]
> Windows Terminal은 Windows 10 2004(빌드 19041) 이상이 필요합니다

### Microsoft Store [권장]

[Microsoft Store에서 Windows Terminal][store-install-link]을 설치하세요.
이 방법을 사용하면 새 빌드가 출시될 때마다 자동으로 최신 버전을 사용할 수 있습니다.

이 방법이 가장 권장되는 설치 방법입니다.

### 기타 설치 방법

#### GitHub를 통한 설치

Microsoft Store에서 Windows Terminal을 설치할 수 없는 사용자는
이 저장소의 [릴리스 페이지](https://github.com/microsoft/terminal/releases)에서
릴리스 빌드를 수동으로 다운로드할 수 있습니다.

**Assets** 섹션에서 `Microsoft.WindowsTerminal_<versionNumber>.msixbundle` 파일을 다운로드하세요.
앱을 설치하려면 `.msixbundle` 파일을 더블 클릭하면 앱 설치 관리자가 자동으로 실행됩니다.
실패하는 경우 PowerShell 프롬프트에서 아래 명령어를 시도해 볼 수 있습니다:

```powershell
# 참고: PowerShell 7 이상을 사용하는 경우,
# Add-AppxPackage를 사용하기 전에
# Import-Module Appx -UseWindowsPowerShell
# 을 실행하세요.

Add-AppxPackage Microsoft.WindowsTerminal_<versionNumber>.msixbundle
```

> [!NOTE]
> Terminal을 수동으로 설치하는 경우:
>
> * [VC++ v14 Desktop Framework Package](https://docs.microsoft.com/troubleshoot/cpp/c-runtime-packages-desktop-bridge#how-to-install-and-update-desktop-framework-packages) 설치가 필요할 수 있습니다.
>   이는 구버전 Windows 10에서만 필요하며, 프레임워크 패키지가 없다는 오류가 발생할 때만 해당됩니다.
> * Terminal은 새 빌드가 릴리스되어도 자동으로 업데이트되지 않으므로,
>   최신 수정 및 향상 기능을 받으려면 정기적으로 최신 Terminal 릴리스를 수동으로 설치해야 합니다!

#### Windows 패키지 관리자 CLI(winget)를 통한 설치

[winget](https://github.com/microsoft/winget-cli) 사용자는
`Microsoft.WindowsTerminal` 패키지를 설치하여 최신 Terminal 릴리스를 설치할 수 있습니다:

```powershell
winget install --id Microsoft.WindowsTerminal -e
```

> [!NOTE]
> 의존성 지원은 WinGet [1.6.2631 이상](https://github.com/microsoft/winget-cli/releases)에서 제공됩니다. Terminal 안정화 버전 1.18 이상을 설치하려면 WinGet 클라이언트가 최신 버전인지 확인하세요.

#### Chocolatey를 통한 설치(비공식)

[Chocolatey](https://chocolatey.org) 사용자는
`microsoft-windows-terminal` 패키지를 설치하여 최신 Terminal 릴리스를 설치할 수 있습니다:

```powershell
choco install microsoft-windows-terminal
```

Chocolatey로 Windows Terminal을 업그레이드하려면 다음을 실행하세요:

```powershell
choco upgrade microsoft-windows-terminal
```

설치/업그레이드 중 문제가 발생하면
[Windows Terminal 패키지 페이지](https://chocolatey.org/packages/microsoft-windows-terminal)에서
[Chocolatey triage process](https://chocolatey.org/docs/package-triage-process)를 참고하세요.

#### Scoop을 통한 설치(비공식)

[Scoop](https://scoop.sh) 사용자는
`windows-terminal` 패키지를 설치하여 최신 Terminal 릴리스를 설치할 수 있습니다:

```powershell
scoop bucket add extras
scoop install windows-terminal
```

Scoop으로 Windows Terminal을 업데이트하려면 다음을 실행하세요:

```powershell
scoop update windows-terminal
```

설치/업데이트 중 문제가 발생하면
[Scoop Extras 저장소의 이슈 페이지](https://github.com/lukesampson/scoop-extras/issues)를 검색하거나 새로 등록해주세요.

---

## Windows Terminal Canary 설치
Windows Terminal Canary는 Windows Terminal의 야간 빌드입니다. 이 빌드는 `main` 브랜치의 최신 코드를 포함하고 있어, Windows Terminal Preview에 반영되기 전의 기능을 미리 체험할 수 있습니다.

Windows Terminal Canary는 가장 불안정한 빌드이므로, 저희가 발견하지 못한 버그를 먼저 경험하실 수 있습니다.

Windows Terminal Canary는 App Installer 배포본과 Portable ZIP 배포본으로 제공됩니다.

App Installer 배포본은 자동 업데이트를 지원합니다. 플랫폼 제약으로 인해 이 설치 관리자는 Windows 11에서만 작동합니다.

Portable ZIP 배포본은 휴대용 애플리케이션입니다. 자동 업데이트나 업데이트 확인 기능이 없으며, Windows 10(19041+) 및 Windows 11에서 사용할 수 있습니다.

| 배포 방식       | 아키텍처         | 링크                                                    |
|----------------|:---------------:|---------------------------------------------------------|
| App Installer  | x64, arm64, x86 | [다운로드](https://aka.ms/terminal-canary-installer)    |
| Portable ZIP   | x64             | [다운로드](https://aka.ms/terminal-canary-zip-x64)      |
| Portable ZIP   | ARM64           | [다운로드](https://aka.ms/terminal-canary-zip-arm64)    |
| Portable ZIP   | x86             | [다운로드](https://aka.ms/terminal-canary-zip-x86)      |

_[Windows Terminal 배포 종류에 대해 자세히 알아보기](https://learn.microsoft.com/windows/terminal/distributions)._

---

## Windows Terminal 로드맵

Windows Terminal에 대한 계획은 [여기](/doc/roadmap-2023.md)에 설명되어 있으며,
프로젝트 진행에 따라 업데이트될 예정입니다.

## Terminal & Console 개요

코드 작업 전에 아래 개요를 잠시 검토해 주시기 바랍니다:

### Windows Terminal

Windows Terminal은 명령줄 사용자를 위한 새롭고 현대적이며 다양한 기능을 갖춘 생산성 터미널 애플리케이션입니다. 탭 지원, 리치 텍스트, 글로벌화, 설정 가능성, 테마 및 스타일링 등 Windows 커맨드라인 커뮤니티에서 가장 많이 요청된 기능들이 포함되어 있습니다.

Terminal은 빠르고 효율적으로 동작하며, 불필요하게 많은 메모리나 전력을 소모하지 않도록 저희의 목표와 기준을 충족해야 합니다.

### Windows Console Host

Windows Console 호스트(`conhost.exe`)는 Windows의 원래 명령줄 사용자 환경입니다. Windows의 명령줄 인프라, Windows Console API 서버, 입력 엔진, 렌더링 엔진, 사용자 환경설정 등을 호스팅합니다. 이 저장소의 콘솔 호스트 코드는 Windows 자체에서 빌드되는 실제 소스입니다.

2014년부터 Windows 명령줄을 담당하게 된 이후, 콘솔에 여러 새로운 기능(배경 투명도, 라인 기반 선택, [ANSI / Virtual Terminal 시퀀스](https://en.wikipedia.org/wiki/ANSI_escape_code) 지원, [24비트 컬러](https://devblogs.microsoft.com/commandline/24-bit-color-in-the-windows-console/), [Pseudoconsole("ConPTY")](https://devblogs.microsoft.com/commandline/windows-command-line-introducing-the-windows-pseudo-console-conpty/) 등)을 추가했습니다.

하지만 Windows Console의 주요 목표가 하위 호환성 유지이기 때문에, 지난 수년간 커뮤니티(및 팀)에서 원했던 탭, 유니코드 텍스트, 이모지 등 많은 기능을 추가할 수 없었습니다.

이러한 한계로 인해 새 Windows Terminal을 만들게 되었습니다.

> 명령줄의 전반적인 진화와 Windows 명령줄의 변화에 대해서는 [이 블로그 시리즈](https://devblogs.microsoft.com/commandline/windows-command-line-backgrounder/)를 참고하세요.

### 공유 컴포넌트

Windows Console을 개선하면서 코드베이스를 대폭 현대화하고, 논리적 엔터티를 모듈과 클래스로 깔끔하게 분리했으며, 주요 확장 포인트를 도입하고, 기존의 비효율적이고 위험한 컬렉션 및 컨테이너를 더 안전하고 효율적인 [STL 컨테이너](https://docs.microsoft.com/en-us/cpp/standard-library/stl-containers?view=vs-2022)로 대체했습니다. 또한 Microsoft의 [Windows Implementation Libraries - WIL](https://github.com/Microsoft/wil)을 사용하여 코드를 더 간단하고 안전하게 만들었습니다.

이 개선을 통해 콘솔의 주요 컴포넌트 여러 개가 Windows에서 다른 터미널 구현에도 재사용할 수 있게 되었습니다. 여기에는 새로운 DirectWrite 기반 텍스트 레이아웃 및 렌더링 엔진, UTF-16/UTF-8 저장이 가능한 텍스트 버퍼, VT 파서/이미터 등이 포함됩니다.

### 새 Windows Terminal 만들기

새 Windows Terminal 애플리케이션을 기획할 때 여러 접근방식과 기술 스택을 검토했습니다. 결국 기존 C++ 코드베이스에 지속적으로 투자하는 것이 우리의 목표를 달성하는 최선의 방법임을 알게 되었고, 이를 통해 기존 콘솔과 새 터미널 모두에서 앞서 언급한 현대화된 컴포넌트를 재사용할 수 있었습니다. 또한 터미널의 핵심 부분을 재사용 가능한 UI 컨트롤로 구현해, 다른 애플리케이션에서도 활용할 수 있게 했습니다.

이 작업의 결과물이 이 저장소에 포함되어 있으며, Microsoft Store 또는 [이 저장소의 릴리스 페이지](https://github.com/microsoft/terminal/releases)에서 Windows Terminal 애플리케이션으로 제공됩니다.

---

## 자료

Windows Terminal에 대해 더 알고 싶다면 다음 자료가 도움이 될 수 있습니다:

* [Command-Line 블로그](https://devblogs.microsoft.com/commandline)
* [Command-Line Backgrounder 블로그 시리즈](https://devblogs.microsoft.com/commandline/windows-command-line-backgrounder/)
* Windows Terminal 출시: [Terminal "Sizzle Video"](https://www.youtube.com/watch?v=8gw0rXPMMPE&list=PLEHMQNlPj-Jzh9DkNpqipDGCZZuOwrQwR&index=2&t=0s)
* Windows Terminal 출시: [Build 2019 세션](https://www.youtube.com/watch?v=KMudkRcwjCw)
* Run As Radio: [Show 645 - Windows Terminal with Richard Turner](https://www.runasradio.com/Shows/Show/645)
* Azure Devops Podcast: [에피소드 54 - Kayla Cinnamon과 Rich Turner가 말하는 Windows Terminal 팀의 DevOps](http://azuredevopspodcast.clear-measure.com/kayla-cinnamon-and-rich-turner-on-devops-on-the-windows-terminal-team-episode-54)
* Microsoft Ignite 2019 세션: [The Modern Windows Command Line: Windows Terminal - BRK3321](https://myignite.techcommunity.microsoft.com/sessions/81329?source=sessions)

---

## FAQ

### 새 Terminal을 빌드 및 실행했는데, 이전 콘솔과 동일하게 보입니다

원인: Visual Studio에서 올바르지 않은 솔루션을 실행하고 있습니다.

해결책: Visual Studio에서 `CascadiaPackage` 프로젝트를 빌드 및 배포해야 합니다.

> [!NOTE]
> `OpenConsole.exe`는 로컬에서 빌드된 `conhost.exe`(클래식 Windows Console)입니다. OpenConsole은 Windows Terminal이 명령줄 애플리케이션과 연결하고 통신할 때([ConPty](https://devblogs.microsoft.com/commandline/windows-command-line-introducing-the-windows-pseudo-console-conpty/) 참고) 사용됩니다.

---

## 문서

모든 프로젝트 문서는 [aka.ms/terminal-docs](https://aka.ms/terminal-docs)에 있습니다. 문서에 기여하고 싶으시다면 [Windows Terminal Documentation 저장소](https://github.com/MicrosoftDocs/terminal)에 PR을 제출해 주세요.

---

## 기여하기

여러분과 함께 Windows Terminal을 개발하고 개선하게 되어 매우 기쁩니다!

***기능/수정 작업을 시작하기 전에***, [기여자 안내서](./CONTRIBUTING.md)를 반드시 읽고 따라주세요. 중복된 작업이나 불필요한 노력을 방지할 수 있습니다.

## 팀과의 소통

팀과 소통하는 가장 쉬운 방법은 GitHub 이슈를 통해서입니다.

새로운 이슈, 기능 요청, 제안을 등록할 때는 **유사한 기존 이슈(열림/닫힘)를 먼저 검색**해 주세요.

이슈로 등록할 필요가 없다고 생각되는 질문이 있다면 Twitter로 연락해 주세요:

* Christopher Nguyen, 제품 매니저: [@nguyen_dows](https://twitter.com/nguyen_dows)
* Dustin Howett, 엔지니어링 리드: [@dhowett](https://twitter.com/DHowett)
* Mike Griese, 시니어 개발자: [@zadjii@mastodon.social](https://mastodon.social/@zadjii)
* Carlos Zamora, 개발자: [@cazamor_msft](https://twitter.com/cazamor_msft)
* Pankaj Bhojwani, 개발자
* Leonard Hecker, 개발자: [@LeonardHecker](https://twitter.com/LeonardHecker)

## 개발자 안내

## 사전 요구사항

Terminal 빌드를 위한 환경은 두 가지 방법 중 하나로 구성할 수 있습니다:

### WinGet 구성 파일 사용

저장소를 클론한 후, [WinGet 구성 파일](https://learn.microsoft.com/en-us/windows/package-manager/configuration/#use-a-winget-configuration-file-to-configure-your-machine)을 사용하여 환경을 설정할 수 있습니다. [기본 구성 파일](.config/configuration.winget)은 Visual Studio 2022 Community 및 필요한 도구를 설치합니다. [.config](.config) 폴더에는 Enterprise/Professional 에디션용 구성 파일도 있습니다. 기본 구성 파일을 실행하려면 파일을 탐색기에서 더블 클릭하거나 다음 명령어를 실행하면 됩니다:

```powershell
winget configure .config\configuration.winget
```

### 수동 구성

* Windows Terminal을 실행하려면 Windows 10 2004(빌드 >= 10.0.19041.0) 이상이 필요합니다.
* Windows Terminal을 로컬에 설치 및 실행하려면 [Windows 설정 앱에서 개발자 모드](https://docs.microsoft.com/en-us/windows/uwp/get-started/enable-your-device-for-development)를 활성화해야 합니다.
* [PowerShell 7 이상](https://github.com/PowerShell/PowerShell/releases/latest)이 설치되어 있어야 합니다.
* [Windows 11 (10.0.22621.0) SDK](https://developer.microsoft.com/en-us/windows/downloads/windows-sdk/)가 설치되어 있어야 합니다.
* 최소한 [VS 2022](https://visualstudio.microsoft.com/downloads/)가 설치되어 있어야 합니다.
* VS 설치 관리자를 통해 다음 워크로드를 설치해야 합니다. 참고: VS 2022에서 솔루션을 열면 [누락된 구성 요소를 자동으로 설치하라는 안내](https://devblogs.microsoft.com/setup/configure-visual-studio-across-your-organization-with-vsconfig/)가 표시됩니다.
  * C++ 데스크톱 개발
  * 범용 Windows 플랫폼 개발
  * **다음 개별 구성 요소**
    * C++ (v143) 범용 Windows 플랫폼 도구
* 테스트 프로젝트 빌드를 위해 [.NET Framework Targeting Pack](https://docs.microsoft.com/dotnet/framework/install/guide-for-developers#to-install-the-net-framework-developer-pack-or-targeting-pack)을 설치해야 합니다.

## 코드 빌드

OpenConsole.sln은 Visual Studio 내에서 빌드하거나, **/tools** 디렉터리의 편의 스크립트 및 도구를 사용해 명령줄에서 빌드할 수 있습니다:

### PowerShell에서 빌드

```powershell
Import-Module .\tools\OpenConsole.psm1
Set-MsBuildDevEnvironment
Invoke-OpenConsoleBuild
```

### Cmd에서 빌드

```shell
.\tools\razzle.cmd
bcz
```

## 실행 및 디버깅

VS에서 Windows Terminal을 디버깅하려면, `CascadiaPackage`(솔루션 탐색기에서)를 우클릭 후 속성(Properties)으로 이동하세요. 디버그 메뉴에서 "Application process"와 "Background task process"를 "Native Only"로 변경합니다.

그런 다음 <kbd>F5</kbd>를 눌러 Terminal 프로젝트를 빌드 및 디버깅할 수 있습니다. "x64" 또는 "x86" 플랫폼을 선택해야 하며, "Any Cpu"로는 빌드되지 않습니다(Terminal은 C++ 애플리케이션이기 때문입니다).

> 👉 WindowsTerminal.exe를 직접 실행하여 Terminal을 실행할 수는 없습니다. 자세한 내용은
> [#926](https://github.com/microsoft/terminal/issues/926),
> [#4043](https://github.com/microsoft/terminal/issues/4043) 이슈를 참고하세요.

### 코딩 가이드

아래의 간단한 문서를 참고하여 저희의 코딩 관행을 확인하세요.

> 👉 문서에 누락된 내용이 있다면 저장소 내 어떤 문서 파일에도 자유롭게 기여하거나 새로 작성해 주세요!

프로젝트에 효과적으로 기여하기 위해 제공해야 할 사항들을 계속해서 업데이트하고 있습니다.

* [코딩 스타일](./doc/STYLE.md)
* [코드 조직화](./doc/ORGANIZATION.md)
* [레거시 코드베이스에서의 예외 처리](./doc/EXCEPTIONS.md)
* [WIL에서 Windows와 연동을 위한 스마트 포인터 및 매크로](./doc/WIL.md)

---

## 행동 강령

이 프로젝트는 [Microsoft 오픈 소스 행동 강령][conduct-code]을 채택했습니다. 자세한 내용은 [행동 강령 FAQ][conduct-FAQ]를 참조하거나, 추가 질문이나 의견이 있을 경우 [opencode@microsoft.com][conduct-email]으로 연락하세요.

[conduct-code]: https://opensource.microsoft.com/codeofconduct/
[conduct-FAQ]: https://opensource.microsoft.com/codeofconduct/faq/
[conduct-email]: mailto:opencode@microsoft.com
[store-install-link]: https://aka.ms/terminal

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---