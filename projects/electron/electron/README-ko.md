[![Electron 로고](https://electronjs.org/images/electron-logo.svg)](https://electronjs.org)

[![GitHub Actions 빌드 상태](https://github.com/electron/electron/actions/workflows/build.yml/badge.svg)](https://github.com/electron/electron/actions/workflows/build.yml)
[![Electron Discord 초대](https://img.shields.io/discord/745037351163527189?color=%237289DA&label=chat&logo=discord&logoColor=white)](https://discord.gg/electronjs)

:memo: 사용 가능한 번역: 🇨🇳 🇧🇷 🇪🇸 🇯🇵 🇷🇺 🇫🇷 🇺🇸 🇩🇪.
다른 언어로 된 문서는 우리의 [Crowdin](https://crowdin.com/project/electron) 프로젝트에서 확인할 수 있습니다.

Electron 프레임워크는 JavaScript, HTML, CSS를 사용하여 크로스 플랫폼 데스크톱 애플리케이션을 작성할 수 있게 해줍니다. [Node.js](https://nodejs.org/)와 [Chromium](https://www.chromium.org)를 기반으로 하며, [Visual Studio Code](https://github.com/Microsoft/vscode/)를 비롯한 다양한 [앱](https://electronjs.org/apps)에서 사용되고 있습니다.

중요한 소식은 Twitter의 [@electronjs](https://twitter.com/electronjs)를 팔로우하세요.

이 프로젝트는 Contributor Covenant의 [행동 강령](https://github.com/electron/electron/tree/main/CODE_OF_CONDUCT.md)을 따릅니다.
참여 시 이 강령을 준수해야 하며, 부적절한 행동은 [coc@electronjs.org](mailto:coc@electronjs.org)로 신고해주시기 바랍니다.

## 설치

사전 빌드된 Electron 바이너리를 설치하려면 [`npm`](https://docs.npmjs.com/)을 사용하세요.
권장하는 방법은 앱의 개발 의존성으로 Electron을 설치하는 것입니다:

```sh
npm install electron --save-dev
```

더 많은 설치 옵션과 문제 해결 방법은 [설치](docs/tutorial/installation.md)를 참고하세요. 앱에서 Electron 버전을 관리하는 방법은 [Electron 버전 관리](docs/tutorial/electron-versioning.md)를 참고하세요.

## 플랫폼 지원

각 Electron 릴리즈는 macOS, Windows, Linux용 바이너리를 제공합니다.

* macOS (Big Sur 이상): Electron은 macOS용 64비트 Intel 및 Apple Silicon / ARM 바이너리를 제공합니다.
* Windows (Windows 10 이상): Electron은 Windows용 `ia32`(`x86`), `x64`(`amd64`), `arm64` 바이너리를 제공합니다. Windows on ARM 지원은 Electron 5.0.8에서 추가되었습니다. Windows 7, 8, 8.1 지원은 [Chromium의 Windows 지원 중단 정책에 따라 Electron 23에서 제거되었습니다](https://www.electronjs.org/blog/windows-7-to-8-1-deprecation-notice).
* Linux: Electron의 사전 빌드 바이너리는 Ubuntu 20.04에서 빌드됩니다. 다음 환경에서도 동작이 검증되었습니다:
  * Ubuntu 18.04 이상
  * Fedora 32 이상
  * Debian 10 이상

## Electron Fiddle

[`Electron Fiddle`](https://github.com/electron/fiddle)를 사용하면 작은 Electron 실험을 빌드, 실행, 패키징할 수 있으며, Electron의 모든 API에 대한 코드 예제를 보고, 다양한 버전의 Electron을 시도해볼 수 있습니다. Electron을 처음 시작하는 데 도움을 주기 위해 설계되었습니다.

## Electron 학습 자료

* [electronjs.org/docs](https://electronjs.org/docs) - Electron의 전체 문서
* [electron/fiddle](https://github.com/electron/fiddle) - 작은 Electron 실험을 빌드, 실행, 패키징할 수 있는 도구
* [electronjs.org/community#boilerplates](https://electronjs.org/community#boilerplates) - 커뮤니티에서 만든 샘플 스타터 앱

## 프로그래밍 방식 사용

대부분은 명령줄에서 Electron을 사용하지만, **Node 앱**(Electron 앱이 아님)에서 `electron`을 require하면 바이너리의 파일 경로가 반환됩니다. Node 스크립트에서 Electron을 실행할 때 사용할 수 있습니다:

```javascript
const electron = require('electron')
const proc = require('node:child_process')

// 예시 출력: /Users/maf/.../Electron
console.log(electron)

// Electron 실행
const child = proc.spawn(electron)
```

### 미러

* [중국](https://npmmirror.com/mirrors/electron/)

커스텀 미러 사용 방법은 [고급 설치 안내](https://www.electronjs.org/docs/latest/tutorial/installation#mirror)를 참고하세요.

## 문서 번역

우리는 [Crowdin](https://crowdin.com/project/electron)을 통해 문서 번역을 진행합니다.
현재 중국어(간체), 프랑스어, 독일어, 일본어, 포르투갈어, 러시아어, 스페인어 번역을 받고 있습니다.

## 기여

문제 보고/수정 및 코드베이스에 직접 기여하고 싶으시다면, [CONTRIBUTING.md](CONTRIBUTING.md)를 참고하여 필요한 정보와 시작 방법을 확인하세요.

## 커뮤니티

버그 보고, 도움 받기, 서드파티 도구 및 샘플 앱 찾기 등 기타 정보는 [커뮤니티 페이지](https://www.electronjs.org/community)에서 확인할 수 있습니다.

## 라이선스

[MIT](https://github.com/electron/electron/blob/main/LICENSE)

Electron 로고를 사용할 때는 [OpenJS Foundation 상표 정책](https://trademark-policy.openjsf.org/)을 준수해야 합니다.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---