<div align="center">

  <img src="https://github.com/tapframe/NuvioTV/blob/main/assets/brand/app_logo_wordmark.png" alt="Nuvio" width="300" />
  <br />
  <br />

  [![Contributors][contributors-shield]][contributors-url]
  [![Forks][forks-shield]][forks-url]
  [![Stargazers][stars-shield]][stars-url]
  [![Issues][issues-shield]][issues-url]
  [![License][license-shield]][license-url]

  <p>
    Kotlin Multiplatform과 Compose Multiplatform으로 구축된 Android 및 iOS용 현대적인 미디어 허브입니다.
    <br />
    Stremio 애드온 생태계 • 크로스 플랫폼
  </p>

</div>

## 소개

Nuvio는 원래 React Native 앱을 Kotlin Multiplatform으로 재작성한 최신 버전입니다. Android와 iOS용 공유 Compose UI를 제공하면서, 이전 앱을 형성했던 재생 중심 경험, 컬렉션 도구, 시청 진행 흐름, 다운로드 및 Stremio 애드온 생태계 통합을 유지합니다.

모바일 앱은 Android와 iOS용 네이티브 플랫폼 진입점을 갖춘 단일 공유 코드베이스 [composeApp](./composeApp)에서 빌드됩니다.

## 설치

### Android

[GitHub Releases](https://github.com/NuvioMedia/NuvioMobile/releases/latest)에서 최신 Android 빌드를 다운로드하세요.

### iOS

- [TestFlight](https://testflight.apple.com/join/u4y7MHK9)

## 개발

```bash
git clone https://github.com/NuvioMedia/NuvioMobile.git
cd NuvioMobile
./scripts/run-mobile.sh android
# or
./scripts/run-mobile.sh ios
```
### 프로젝트 구조

- `composeApp/`는 공통 Kotlin Multiplatform 및 Compose Multiplatform 앱 코드를 포함합니다.
- `composeApp/src/commonMain/`는 공통 UI, 기능, 저장소 및 플랫폼 독립적 로직을 포함합니다.
- `composeApp/src/androidMain/`는 Android 전용 통합을 포함합니다.
- `composeApp/src/iosMain/`는 iOS 전용 통합을 포함합니다.
- `iosApp/`는 네이티브 Xcode 프로젝트와 iOS 진입점을 포함합니다.

유용한 명령어:


```bash
./gradlew :composeApp:assembleDebug
./gradlew :composeApp:compileKotlinIosSimulatorArm64
./scripts/build-distribution.sh
```
버전 관리는 `iosApp/Configuration/Version.xcconfig`에서 관리되며, 이는 iOS 및 Android 빌드 모두에 대한 공유 진실 소스로 사용됩니다.

## 법적 고지 및 DMCA

Nuvio는 사용자 설치 확장 및/또는 사용자가 제공한 소스가 제공하는 메타데이터 탐색 및 미디어 재생을 위한 클라이언트 측 인터페이스로만 기능합니다. 사용자가 소유하거나 접근 권한이 있는 콘텐츠를 대상으로 합니다.

Nuvio는 제3자 확장, 카탈로그, 소스 또는 콘텐츠 제공자와 제휴하지 않습니다. 미디어 콘텐츠를 호스팅, 저장 또는 배포하지 않습니다.

전체 법적 정보, 전체 면책 조항, 제3자 확장 정책 및 DMCA/저작권 정보는 [법적 고지 및 면책 조항 페이지](https://nuvioapp.space/legal)를 참조하십시오.

## 사용 기술

- Kotlin 멀티플랫폼
- Compose 멀티플랫폼
- Kotlin
- AndroidX Media3
- AVFoundation 및 네이티브 iOS 통합

## 스타 히스토리

<a href="https://www.star-history.com/#NuvioMedia/NuvioMobile&type=date&legend=top-left">
 <picture>
   <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=NuvioMedia/NuvioMobile&type=date&theme=dark&legend=top-left" />
   <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=NuvioMedia/NuvioMobile&type=date&legend=top-left" />
   <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=NuvioMedia/NuvioMobile&type=date&legend=top-left" />
 </picture>
</a>

<!-- MARKDOWN LINKS & IMAGES -->
[contributors-shield]: https://img.shields.io/github/contributors/NuvioMedia/NuvioMobile.svg?style=for-the-badge
[contributors-url]: https://github.com/NuvioMedia/NuvioMobile/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/NuvioMedia/NuvioMobile.svg?style=for-the-badge
[forks-url]: https://github.com/NuvioMedia/NuvioMobile/network/members
[stars-shield]: https://img.shields.io/github/stars/NuvioMedia/NuvioMobile.svg?style=for-the-badge
[stars-url]: https://github.com/NuvioMedia/NuvioMobile/stargazers
[issues-shield]: https://img.shields.io/github/issues/NuvioMedia/NuvioMobile.svg?style=for-the-badge
[issues-url]: https://github.com/NuvioMedia/NuvioMobile/issues
[license-shield]: https://img.shields.io/github/license/NuvioMedia/NuvioMobile.svg?style=for-the-badge
[license-url]: https://github.com/NuvioMedia/NuvioMobile/blob/main/LICENSE


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-22

---