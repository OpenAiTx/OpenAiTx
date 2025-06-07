<img src=".github/splash.png" alt="Tauri" />

[![status](https://img.shields.io/badge/status-stable-blue.svg)](https://github.com/tauri-apps/tauri/tree/dev)
[![License](https://img.shields.io/badge/License-MIT%20or%20Apache%202-green.svg)](https://opencollective.com/tauri)
[![test core](https://img.shields.io/github/actions/workflow/status/tauri-apps/tauri/test-core.yml?label=test%20core&logo=github)](https://github.com/tauri-apps/tauri/actions/workflows/test-core.yml)
[![FOSSA Status](https://app.fossa.com/api/projects/git%2Bgithub.com%2Ftauri-apps%2Ftauri.svg?type=shield)](https://app.fossa.com/projects/git%2Bgithub.com%2Ftauri-apps%2Ftauri?ref=badge_shield)
[![Chat Server](https://img.shields.io/badge/chat-discord-7289da.svg)](https://discord.gg/SpmNs4S)
[![website](https://img.shields.io/badge/website-tauri.app-purple.svg)](https://tauri.app)
[![https://good-labs.github.io/greater-good-affirmation/assets/images/badge.svg](https://good-labs.github.io/greater-good-affirmation/assets/images/badge.svg)](https://good-labs.github.io/greater-good-affirmation)
[![support](https://img.shields.io/badge/sponsor-Open%20Collective-blue.svg)](https://opencollective.com/tauri)

## 소개

Tauri는 모든 주요 데스크톱 플랫폼을 위한 매우 작고, 번개처럼 빠른 실행 파일을 빌드할 수 있는 프레임워크입니다. 개발자는 HTML, JS, CSS로 컴파일되는 어떠한 프론트엔드 프레임워크든 통합하여 사용자 인터페이스를 만들 수 있습니다. 애플리케이션의 백엔드는 Rust로 작성된 바이너리이며, 프론트엔드가 상호작용할 수 있는 API를 제공합니다.

Tauri 앱의 사용자 인터페이스는 현재 macOS, Windows, Linux, Android, iOS에서 창 관리를 위해 [`tao`](https://docs.rs/tao) 라이브러리를 사용합니다. 애플리케이션을 렌더링하기 위해 Tauri는 시스템 웹뷰에 대한 통합 인터페이스를 제공하는 [WRY](https://github.com/tauri-apps/wry) 라이브러리를 사용하며, macOS 및 iOS에서는 WKWebView, Windows에서는 WebView2, Linux에서는 WebKitGTK, Android에서는 Android System WebView를 활용합니다.

이 모든 구성 요소가 어떻게 결합되어 동작하는지에 대한 자세한 내용은 [ARCHITECTURE.md](https://github.com/tauri-apps/tauri/blob/dev/ARCHITECTURE.md) 문서를 참조하세요.

## 시작하기

Tauri 앱을 만들고 싶으시다면 [문서 웹사이트](https://tauri.app)를 방문하세요.

가장 빠르게 시작하는 방법은 시스템에 맞는 [필수 구성 요소](https://v2.tauri.app/start/prerequisites/)를 설치하고 [`create-tauri-app`](https://github.com/tauri-apps/create-tauri-app/#usage)으로 새 프로젝트를 생성하는 것입니다. 예를 들어 `npm`을 사용할 경우:

```sh
npm create tauri-app@latest
```

## 주요 기능

Tauri의 기능 목록은 다음과 같으며, 이에 국한되지 않습니다:

- `.app`, `.dmg`, `.deb`, `.rpm`, `.AppImage`와 Windows 설치 파일인 `.exe`(NSIS 사용), `.msi`(WiX 사용) 등 다양한 포맷의 앱 번들을 생성하는 내장 번들러
- 내장 자동 업데이트 기능 (데스크톱 전용)
- 시스템 트레이 아이콘
- 네이티브 알림
- 네이티브 WebView 프로토콜 (tauri는 WebView 컨텐츠를 제공하기 위해 localhost http(s) 서버를 생성하지 않음)
- 간편한 CI를 위한 GitHub Action
- VS Code 확장 프로그램

### 지원 플랫폼

Tauri는 현재 다음 플랫폼에서 개발 및 배포를 지원합니다:

| 플랫폼     | 버전                                                                                                           |
| :--------- | :------------------------------------------------------------------------------------------------------------- |
| Windows    | 7 이상                                                                                                         |
| macOS      | 10.15 이상                                                                                                     |
| Linux      | Tauri v1: webkit2gtk 4.0 (예: Ubuntu 18.04), Tauri v2: webkit2gtk 4.1 (예: Ubuntu 22.04)                       |
| iOS/iPadOS | 9 이상                                                                                                         |
| Android    | 7 이상 (현재는 8 이상 지원)                                                                                    |

## 기여하기

무언가 작업을 시작하기 전에 기존 이슈가 있는지 먼저 확인하는 것이 좋습니다. 또한 Discord 서버에 들러 팀과 해당 작업의 필요성이나 이미 다른 사람이 작업하고 있지는 않은지 확인하는 것도 좋은 방법입니다.

풀 리퀘스트를 생성하기 전에 반드시 [기여 가이드](./.github/CONTRIBUTING.md)를 읽어주세요.

Tauri에 기여해주신 모든 분들께 감사드립니다!

### 문서화

다국어 시스템에서의 문서화는 까다로운 작업입니다. 이를 위해 Rust 및 JS 소스 코드 내 인라인 문서를 최대한 활용하는 것을 선호합니다. 더 자세한 내용은 문서 사이트를 호스팅하는 저장소를 참고하세요: <https://github.com/tauri-apps/tauri-docs>

## 파트너

<table>
  <tbody>
    <tr>
      <td align="center" valign="middle">
        <a href="https://crabnebula.dev" target="_blank">
          <img src=".github/sponsors/crabnebula.svg" alt="CrabNebula" width="283">
        </a>
      </td>
    </tr>
  </tbody>
</table>

전체 후원사 목록은 [웹사이트](https://tauri.app#sponsors)와 [Open Collective](https://opencollective.com/tauri)를 방문해 주세요.

## 조직

Tauri는 [지속 가능한 자유 및 오픈 소프트웨어 커뮤니티](https://sfosc.org)의 원칙을 따르는 지속 가능한 집단을 목표로 합니다. 이를 위해 [Commons Conservancy](https://commonsconservancy.org/) 내의 프로그램이 되었으며, [Open Collective](https://opencollective.com/tauri)를 통해 재정적으로 기여할 수 있습니다.

## 라이선스

코드: (c) 2015 - 현재 - The Commons Conservancy 내 Tauri Programme.

MIT 또는 해당되는 경우 MIT/Apache 2.0

로고: CC-BY-NC-ND

- 오리지널 Tauri 로고 디자인: [Alve Larsson](https://alve.io/), [Daniel Thompson-Yvetot](https://github.com/nothingismagick), [Guillaume Chau](https://github.com/akryum)

[![FOSSA Status](https://app.fossa.com/api/projects/git%2Bgithub.com%2Ftauri-apps%2Ftauri.svg?type=large)](https://app.fossa.com/projects/git%2Bgithub.com%2Ftauri-apps%2Ftauri?ref=badge_large)


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---