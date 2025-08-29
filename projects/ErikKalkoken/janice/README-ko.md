# Janice

대용량 JSON 파일을 보기 위한 데스크탑 앱입니다.

[![GitHub Release](https://img.shields.io/github/v/release/ErikKalkoken/janice)](https://github.com/ErikKalkoken/janice)
[![Fyne](https://img.shields.io/badge/dynamic/regex?url=https%3A%2F%2Fgithub.com%2FErikKalkoken%2Fjanice%2Fblob%2Fmain%2Fgo.mod&search=fyne%5C.io%5C%2Ffyne%5C%2Fv2%20(v%5Cd*%5C.%5Cd*%5C.%5Cd*)&replace=%241&label=Fyne&cacheSeconds=https%3A%2F%2Fgithub.com%2Ffyne-io%2Ffyne)](https://github.com/fyne-io/fyne)
[![build status](https://github.com/ErikKalkoken/janice/actions/workflows/ci-cd.yml/badge.svg)](https://github.com/ErikKalkoken/janice/actions/workflows/ci-cd.yml)
[![codecov](https://codecov.io/gh/ErikKalkoken/janice/graph/badge.svg?token=nei6PLRXrD)](https://codecov.io/gh/ErikKalkoken/janice)
[![GitHub License](https://img.shields.io/github/license/ErikKalkoken/janice)](https://github.com/ErikKalkoken/janice)
[![GitHub Downloads (all assets, all releases)](https://img.shields.io/github/downloads/ErikKalkoken/janice/total)](https://github.com/ErikKalkoken/janice/releases)

[![download](https://github.com/user-attachments/assets/c8de336f-8c42-4501-86bb-dbc9c66db1f0)](https://github.com/ErikKalkoken/janice/releases/latest)

## 목차

- [설명](#description)
- [스크린샷](#screenshots)
- [실행 방법](#how-to-run)
- [자주 묻는 질문](#faq)
- [기여자](#attributions)

## 설명

Janice는 대용량 JSON 파일을 보기 위한 데스크탑 앱입니다. 주요 기능은 다음과 같습니다:

- 고전적인 트리 구조로 JSON 문서를 탐색
- JSON 파일을 파일 대화상자, 클립보드, 창에 드래그 앤 드롭 또는 명령줄 인수로 열기 가능
- 매우 큰 JSON 파일(>100MB, >10M 요소)도 지원
- 문서 내 키와 값을 검색. 와일드카드 지원
- JSON 파일의 일부를 새 파일이나 클립보드로 내보내기
- 값을 클립보드에 복사
- 단일 실행 파일, 설치 불필요
- Windows, Linux, macOS에서 실행되는 데스크탑 앱
- 자동 다크 및 라이트 테마 지원

## 스크린샷

### 라이트 테마

![light](https://cdn.imgpile.com/f/0IrYBjJ_xl.png)
### 다크 테마

![dark](https://cdn.imgpile.com/f/bdQBc3q_xl.png)

## 실행 방법

Janice를 실행하려면 최신 릴리스를 다운로드하고 컴퓨터에 압축을 푸시면 됩니다. Janice는 단일 실행 파일로 제공되어 바로 실행할 수 있습니다. 최신 패키지는 [릴리스 페이지](https://github.com/ErikKalkoken/janice/releases)에서 다운로드할 수 있습니다.

### 리눅스

리눅스 데스크탑용으로 두 가지 설치 방법을 제공합니다:

- AppImage: AppImage 버전은 설치나 루트 권한 없이 실행 파일에서 바로 앱을 실행할 수 있습니다.
- Tarball: tar 파일은 설치가 필요하지만 데스크탑 환경에 앱을 통합할 수 있습니다. 또한 tarball은 다양한 리눅스 버전에서 더 넓은 호환성을 제공합니다.

#### AppImage

> [!NOTE]
> 이 앱은 [AppImage](https://appimage.org/) 형식으로 제공되어 설치 없이 다양한 리눅스 배포판에서 실행할 수 있습니다.

1. 릴리스 페이지에서 최신 AppImage 파일을 다운로드하고 실행 권한을 부여하세요.
1. 실행하여 앱을 시작하세요.

> [!TIP]
> 다음 오류가 발생하면: `AppImages require FUSE to run.`, 시스템에 먼저 FUSE를 설치해야 합니다. 이것은 모든 AppImage가 작동하는 데 필요한 라이브러리입니다. 자세한 내용은 [이 페이지](https://docs.appimage.org/user-guide/troubleshooting/fuse.html#the-appimage-tells-me-it-needs-fuse-to-run)를 참조하세요.

#### Tarball

1. 릴리스 페이지에서 최신 tar 파일을 다운로드하세요.
1. tar 파일을 압축 해제합니다. 예: `tar xf janice-0.12.3-linux-amd64.tar.xz`
1. 현재 사용자용으로 설치하려면 `make user-install`을 실행하거나 시스템에 설치하려면 `sudo make install`을 실행하세요.

이제 데스크탑 환경의 실행기에서 앱을 시작할 수 있는 바로 가기가 있어야 합니다.

앱을 제거하려면 설치 방법에 따라 `make user-uninstall` 또는 `sudo make uninstall`을 실행하세요.

### 윈도우

1. Github 최신 릴리스에서 윈도우용 zip 파일을 다운로드하세요.

1. 파일을 원하는 디렉토리에 압축 해제한 후 .exe 파일을 실행하여 앱을 시작합니다.

### Mac OS

1. Github의 최신 릴리스에서 해당 플랫폼(arm 또는 intel)에 맞는 darwin zip 파일을 다운로드합니다.
1. 파일을 원하는 디렉토리에 압축 해제합니다.
1. .app 파일을 실행하여 앱을 시작합니다.

> [!TIP]
> MacOS는 이 앱이 Apple 인증서로 서명되지 않아 잘못 "손상됨"으로 보고할 수 있습니다. 터미널을 열고 다음 명령어를 실행하면 이 오류를 제거할 수 있습니다. 자세한 내용은 [Fyne 문제 해결](https://docs.fyne.io/faq/troubleshoot#distribution)을 참조하세요:
>
> ```sudo xattr -r -d com.apple.quarantine Janice.app```

### 저장소에서 빌드 및 실행

시스템이 [Fyne](https://fyne.io/) 앱 빌드에 구성되어 있다면, 다음 명령어로 저장소에서 직접 이 앱을 빌드하고 실행할 수 있습니다:

```sh
go run github.com/ErikKalkoken/janice@latest
```
Fyne 시스템 구성에 대한 자세한 내용은 다음을 참조하십시오: [시작하기](https://docs.fyne.io/started/).

## FAQ

### 내가 로드할 수 있는 가장 큰 JSON 파일 크기는 얼마인가요?

컴퓨터에서 로드할 수 있는 가장 큰 JSON 파일은 주로 RAM 용량과 특정 JSON 파일에 따라 다릅니다. 메모리 사용량의 주요 요인은 JSON 문서 내 요소의 수입니다.

비교를 위해 개발자 노트북에서 로드 테스트를 수행했습니다. 이 노트북은 8GB RAM과 Ubuntu 22.04 LTS를 실행합니다. 최대 4500만 개 요소가 포함된 JSON 파일을 성공적으로 로드할 수 있었습니다. 테스트 파일 크기는 약 2.5GB였습니다.

### JSON 파일은 포맷되어 있나요?

예. JSON 문서는 트리 구조로 렌더링되며 키는 알파벳 순으로 표시됩니다.

## 출처

- [Json 아이콘 - LAB Design Studio 제작 - Flaticon](https://www.flaticon.com/free-icons/json)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-29

---