<a href="https://www.buymeacoffee.com/fredrikbur3" target="_blank"><img src="https://www.buymeacoffee.com/assets/img/custom_images/orange_img.png" alt="Buy Me A Coffee" style="height: 41px !important;width: 174px !important;box-shadow: 0px 3px 2px 0px rgba(190, 190, 190, 0.5) !important;-webkit-box-shadow: 0px 3px 2px 0px rgba(190, 190, 190, 0.5) !important;" ></a>


<p align="center">
  <img src="https://raw.githubusercontent.com/streamyfin/.github/refs/heads/main/streamyfin-github-banner.png" alt="Streamyfin" width="100%">
</p>

**Streamyfin은 Expo로 제작된 사용자 친화적인 Jellyfin 비디오 스트리밍 클라이언트입니다. 다른 Jellyfin 클라이언트의 대안으로 설계되어 원활하고 안정적인 스트리밍 경험을 제공하는 것을 목표로 합니다. 미디어 스트리밍 도구 모음에 유용한 추가 기능이 되길 바랍니다.**

---

<p align="center">
  <img src="https://raw.githubusercontent.com/streamyfin/streamyfin/develop/./assets/images/screenshots/screenshot1.png" width="20%">
  &nbsp;
  <img src="https://raw.githubusercontent.com/streamyfin/streamyfin/develop/./assets/images/screenshots/screenshot3.png" width="20%">
  &nbsp;
  <img src="https://raw.githubusercontent.com/streamyfin/streamyfin/develop/./assets/images/screenshots/screenshot2.png" width="20%">
  &nbsp;
  <img src="https://raw.githubusercontent.com/streamyfin/streamyfin/develop/./assets/images/jellyseerr.PNG" width="21%">
</p>


## 🌟 기능

- 🚀 **인트로 / 크레딧 건너뛰기 지원**: 재생 중 인트로와 크레딧을 빠르게 건너뛸 수 있습니다
- 🖼️ **트릭플레이 이미지**: 탐색 시 챕터 미리보기를 위한 새로운 골든 스탠다드
- 📥 **미디어 다운로드**: 미디어를 로컬에 저장하여 오프라인으로 시청 가능
- ⚙️ **설정 관리**: 플러그인을 통해 모든 사용자의 앱 구성을 관리
- 🤖 **Seerr (구 Jellyseerr) 통합**: 앱 내에서 직접 미디어 요청 가능
- 👁️ **세션 보기:** 현재 서버에서 스트리밍 중인 모든 활성 세션 확인
- 📡 **Chromecast**: 미디어를 Chromecast 지원 기기로 캐스트

## 🧪 실험적 기능

Streamyfin은 미디어 다운로드 및 Chromecast 지원과 같은 흥미로운 실험적 기능을 제공합니다. 이 기능들은 활발히 개발 중이며, 여러분의 피드백과 인내가 더 나은 기능 완성에 큰 도움이 됩니다.

### 📥 다운로드

다운로드는 FFmpeg를 사용하여 HLS 스트림을 기기의 비디오 파일로 변환하는 방식으로 작동합니다. 이를 통해 스트리밍할 수 있는 모든 콘텐츠를 다운로드하여 시청할 수 있습니다. 변환은 다운로드 중 서버에서 Jellyfin이 실시간으로 처리합니다. 이 과정은 다소 시간이 걸릴 수 있으나, 서버가 트랜스코딩할 수 있는 모든 파일과의 호환성을 보장합니다.

### 🧩 Streamyfin 플러그인

Streamyfin용 Jellyfin 플러그인은 Jellyfin에 설치하는 플러그인으로, 클라이언트 Streamyfin의 모든 설정을 보관합니다. 이를 통해 모든 사용자 간에 설정을 동기화할 수 있습니다. 예를 들어:

- 사용자 입력 없이 자동 Seerr 로그인
- 선호하는 기본 언어 설정
- 다운로드 방법 및 검색 공급자 구성
- 홈 화면 개인화
- 그리고 더 많은 기능

[Streamyfin 플러그인](https://github.com/streamyfin/jellyfin-plugin-streamyfin)

### 📡 Chromecast

Chromecast 지원은 현재 개발 중입니다. 비디오 캐스팅은 이미 가능하며, 자막 지원과 추가 기능을 적극적으로 작업 중입니다.

### 🔍 Jellysearch

[Jellysearch](https://gitlab.com/DomiStyle/jellysearch)는 Streamyfin과 함께 작동합니다.

> Jellyfin용 빠른 전문 검색 프록시입니다. 대부분의 Jellyfin 클라이언트와 원활하게 통합됩니다.

## 🛣️ 로드맵

우리가 다음에 작업 중인 내용을 확인하려면 [로드맵](https://github.com/users/fredrikburmester/projects/5)을 참조하세요. 항상 피드백과 제안을 환영합니다. 아이디어나 기능 요청이 있으면 알려주세요.

## 📥 Streamyfin 다운로드

<div style="display: flex; gap: 5px;">
  <a href="https://apps.apple.com/app/streamyfin/id6593660679?l=en-GB"><img height=50 alt="Get Streamyfin on App Store" src="https://raw.githubusercontent.com/streamyfin/streamyfin/develop/./assets/Download_on_the_App_Store_Badge.png"/></a>
  <a href="https://play.google.com/store/apps/details?id=com.fredrikburmester.streamyfin"><img height=50 alt="Get Streamyfin on Google Play Store" src="https://raw.githubusercontent.com/streamyfin/streamyfin/develop/./assets/Google_Play_Store_badge_EN.svg"/></a>
  <a href="https://github.com/streamyfin/streamyfin/releases/latest"><img height=50 alt="Get Streamyfin on Github" src="https://raw.githubusercontent.com/streamyfin/streamyfin/develop/./assets/Download_on_Github_.png"/></a>
</div>

### 🧪 베타 테스트

Streamyfin 베타에 접속하려면 [Patreon](https://www.patreon.com/streamyfin)에서 멤버 등급(또는 그 이상)에 구독해야 합니다. 그러면 Discord의 ⁠🧪-beta-releases 채널에 즉시 접근할 수 있고, 구독 사실을 저에게 알릴 수 있습니다. 이 채널에서 APK와 IPA를 공유합니다. 자동 TestFlight 접근 권한은 제공하지 않으니, Apple에 사용하는 이메일과 함께 DM(Cagemaster)으로 연락해 주시면 수동으로 추가해 드립니다.

**참고**: Streamyfin 소스 코드에 적극적으로 기여하는 모든 분은 베타 릴리스에 자동으로 접근할 수 있습니다.

## 🚀 시작하기

### ⚙️ 사전 준비 사항

- 기기가 Jellyfin 서버와 동일한 네트워크에 연결되어 있어야 합니다 (로컬 연결용)  
- 로컬 네트워크 외부에서 연결할 계획이라면 Jellyfin 서버가 원격 액세스를 활성화한 상태에서 실행 중이어야 합니다  
- 서버 버전이 최신 상태여야 합니다 (구버전은 호환성 문제를 일으킬 수 있음)  
- 미디어 라이브러리에 접근할 수 있는 유효한 Jellyfin 사용자 계정이 있어야 합니다  
- **다운로드** 또는 **Seerr 통합**과 같은 기능을 사용할 경우, Jellyfin 서버에 필요한 플러그인이 설치 및 구성되어 있는지 확인하세요

## 🙌 기여하기

Streamyfin 개선을 위한 기여를 환영합니다. 리포지토리를 포크한 후 풀 리퀘스트를 제출하세요. 주요 변경사항이나 새로운 기능에 대해서는 먼저 이슈를 열어 아이디어를 논의하고 프로젝트 방향과 일치하는지 확인해 주세요.

## 🌍 번역

[![Crowdin Translation Status](https://badges.crowdin.net/streamyfin/localized.svg)](https://crowdin.com/project/streamyfin)

Streamyfin은 여러 언어로 제공되며, 전 세계 사용자가 앱을 이용할 수 있도록 도와줄 기여자를 항상 찾고 있습니다.  
[크라우딘 프로젝트 페이지](https://crowdin.com/project/streamyfin)에서 직접 번역에 참여할 수 있습니다.

### 👨‍💻 개발 정보

1. node `>20` 버전을 사용하세요  
2. 의존성 설치 `bun i && bun run submodule-reload`  
3. xcode 및/또는 android studio가 설치되어 있는지 확인하세요. (expo 가이드 참고: https://docs.expo.dev/workflow/android-studio-emulator/)  
4. VSCode/IDE에 BiomeJS 확장 설치 (https://biomejs.dev/)  
4. `npm run prebuild` 실행  
5. `npm run ios` 또는 `npm run android`를 실행해 expo 개발 빌드를 생성하세요. 컴퓨터에서 시뮬레이터가 열리고 앱이 실행됩니다

TV 버전은 npm 명령어 뒤에 `:tv`를 붙이세요.

`npm run prebuild:tv`  
`npm run ios:tv` 또는 `npm run android:tv`

## 👋 연락하기

도움이 필요하거나 질문이 있나요?

- **Discord:** [서버에 참여하기](https://discord.gg/BuGG9ZNhaE)
- **GitHub 이슈:** [버그 신고 또는 기능 요청](https://github.com/streamyfin/streamyfin/issues)  
- **이메일:** [developer@streamyfin.app](https://raw.githubusercontent.com/streamyfin/streamyfin/develop/mailto:developer@streamyfin.app)  


## ❓ 자주 묻는 질문

1. Q: Streamyfin에서 내 라이브러리가 보이지 않는 이유는 무엇인가요?  
   A: 서버가 최신 버전 중 하나로 실행 중인지 확인하고, 오디오 전용이 아닌 라이브러리가 최소 하나 이상 있는지 확인하세요.
2. Q: 내 음악 라이브러리가 보이지 않는 이유는 무엇인가요?  
   A: 현재 음악을 지원하지 않으며, 가까운 미래에 음악 지원이 이루어질 가능성도 낮습니다.

## 📝 크레딧

Streamyfin은 [Fredrik Burmester](https://github.com/fredrikburmester)가 개발했으며 Jellyfin과는 관련이 없습니다. 이 앱은 Expo, React Native 및 기타 오픈 소스 라이브러리를 사용하여 만들어졌습니다.

## 🎖️ 핵심 개발자

다음 기여자들의 중요한 기여에 감사드립니다:

<div align="left">
<table>
  <tr>
    <td align="center">
      <a href="https://github.com/Alexk2309">
        <img src="https://github.com/Alexk2309.png?size=55" width="55" style="border-radius: 50%;" />
        <br /><sub><b>@Alexk2309</b></sub>
      </a>
    </td>
    <td align="center">
      <a href="https://github.com/herrrta">
        <img src="https://github.com/herrrta.png?size=55" width="55" style="border-radius: 50%;" />
        <br /><sub><b>@herrrta</b></sub>
      </a>
    </td>
    <td align="center">
      <a href="https://github.com/lostb1t">
        <img src="https://github.com/lostb1t.png?size=55" width="55" style="border-radius: 50%;" />
        <br /><sub><b>@lostb1t</b></sub>
      </a>
    </td>
    <td align="center">
      <a href="https://github.com/Simon-Eklundh">
        <img src="https://github.com/Simon-Eklundh.png?size=55" width="55" style="border-radius: 50%;" />
        <br /><sub><b>@Simon-Eklundh</b></sub>
      </a>
    </td>
    <td align="center">
      <a href="https://github.com/topiga">
        <img src="https://github.com/topiga.png?size=55" width="55" style="border-radius: 50%;" />
        <br /><sub><b>@topiga</b></sub>
      </a>
    </td>
    <td align="center">
      <a href="https://github.com/lancechant">
        <img src="https://github.com/lancechant.png?size=55" width="55" style="border-radius: 50%;" />
        <br /><sub><b>@lancechant</b></sub>
      </a>
    </td>
  </tr>
  <tr>
    <td align="center">
      <a href="https://github.com/simoncaron">
        <img src="https://github.com/simoncaron.png?size=55" width="55" style="border-radius: 50%;" />
        <br /><sub><b>@simoncaron</b></sub>
      </a>
    </td>
    <td align="center">
      <a href="https://github.com/jakequade">
        <img src="https://github.com/jakequade.png?size=55" width="55" style="border-radius: 50%;" />
        <br /><sub><b>@jakequade</b></sub>
      </a>
    </td>
    <td align="center">
      <a href="https://github.com/Ryan0204">
        <img src="https://github.com/Ryan0204.png?size=55" width="55" style="border-radius: 50%;" />
        <br /><sub><b>@Ryan0204</b></sub>
      </a>
    </td>
    <td align="center">
      <a href="https://github.com/retardgerman">
        <img src="https://github.com/retardgerman.png?size=55" width="55" style="border-radius: 50%;" />
        <br /><sub><b>@retardgerman</b></sub>
      </a>
    </td>
    <td align="center">
      <a href="https://github.com/whoopsi-daisy">
        <img src="https://github.com/whoopsi-daisy.png?size=55" width="55" style="border-radius: 50%;" />
        <br /><sub><b>@whoopsi-daisy</b></sub>
      </a>
    </td>
    <td align="center">
      <a href="https://github.com/Gauvino">
        <img src="https://github.com/Gauvino.png?size=55" width="55" style="border-radius: 50%;" />
        <br /><sub><b>@Gauvino</b></sub>
      </a>
    </td>
  </tr>
</table>
</div>

## ✨ Acknowledgements

We would like to thank the Jellyfin team for their excellent software and support on Discord.

Special thanks to the official Jellyfin clients, which have served as an inspiration for Streamyfin.

We also thank all other developers who have contributed to Streamyfin, your efforts are greatly appreciated.

A special mention to the following people and projects for their contributions:

- [Reiverr](https://github.com/aleksilassila/reiverr) for invaluable help with understanding the Jellyfin API
- [Jellyfin TS SDK](https://github.com/jellyfin/jellyfin-sdk-typescript) for providing the TypeScript SDK
- [Seerr](https://github.com/seerr-team/seerr) for enabling API integration with their project


## ⭐ Star History

[![Star History Chart](https://api.star-history.com/svg?repos=streamyfin/streamyfin&type=Date)](https://star-history.com/#streamyfin/streamyfin&Date)

## 📄 License
Streamyfin은 Mozilla Public License 2.0 (MPL-2.0) 하에 라이선스가 부여되어 있습니다.  
이는 이 소프트웨어를 자유롭게 사용, 수정 및 배포할 수 있음을 의미합니다. MPL-2.0은 소프트웨어를 독점 코드와 결합하는 데 더 많은 유연성을 허용하는 카피레프트 라이선스입니다.  
MPL-2.0의 주요 내용:  

- 소프트웨어를 어떤 목적이든 사용할 수 있습니다  
- 소프트웨어를 수정하고 수정된 버전을 배포할 수 있습니다  
- 원본 저작권 및 라이선스 고지를 포함해야 합니다  
- 적용 대상 파일에 대한 수정 소스 코드를 공개해야 합니다  
- 더 큰 작업은 MPL 코드와 다른 라이선스 코드를 결합할 수 있습니다  
- MPL 라이선스 구성 요소는 MPL 하에 남아 있어야 하지만, 더 큰 작업은 다른 라이선스 하에 있을 수 있습니다  
- 라이선스 전문은 이 저장소의 LICENSE 파일을 참조하십시오  

## ⚠️ 면책 조항  
Streamyfin은 어떠한 형태의 불법 복제도 장려, 지원 또는 용인하지 않습니다. 이 앱은 사용자가 개인적으로 소유하고 제어하는 미디어 스트리밍 전용으로 설계되었습니다. 어떠한 미디어 콘텐츠도 제공하거나 포함하지 않습니다. 불법 복제에 관한 논의, 지원 요청, 참조 및 불법 복제와 관련된 도구, 소프트웨어 또는 웹사이트는 모든 채널에서 엄격히 금지됩니다.  

## 🤝 후원  
VPS 호스팅은 [Hexabyte](https://hexabyte.se/en/vps/?currency=eur)와 [SweHosting](https://swehosting.se/en/#tj%C3%A4nster)에서 후원해 주셨습니다



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-15

---