<h1 align="center">
  <a href="https://reactnative.dev/">
    React Native
  </a>
</h1>

<p align="center">
  <strong>한 번 배우고, 어디서나 작성하세요:</strong><br>
  React로 모바일 앱을 만드세요.
</p>

<p align="center">
  <a href="https://github.com/facebook/react-native/blob/HEAD/LICENSE">
    <img src="https://img.shields.io/badge/license-MIT-blue.svg" alt="React Native is released under the MIT license." />
  </a>
  <a href="https://www.npmjs.org/package/react-native">
    <img src="https://img.shields.io/npm/v/react-native?color=brightgreen&label=npm%20package" alt="Current npm package version." />
  </a>
  <a href="https://reactnative.dev/docs/contributing">
    <img src="https://img.shields.io/badge/PRs-welcome-brightgreen.svg" alt="PRs welcome!" />
  </a>
  <a href="https://twitter.com/intent/follow?screen_name=reactnative">
    <img src="https://img.shields.io/twitter/follow/reactnative.svg?label=Follow%20@reactnative" alt="Follow @reactnative" />
  </a>
</p>

<h3 align="center">
  <a href="https://reactnative.dev/docs/getting-started">시작하기</a>
  <span> · </span>
  <a href="https://reactnative.dev/docs/tutorial">기초 배우기</a>
  <span> · </span>
  <a href="https://reactnative.dev/showcase">쇼케이스</a>
  <span> · </span>
  <a href="https://reactnative.dev/docs/contributing">기여하기</a>
  <span> · </span>
  <a href="https://reactnative.dev/help">커뮤니티</a>
  <span> · </span>
  <a href="https://github.com/facebook/react-native/blob/HEAD/.github/SUPPORT.md">지원</a>
</h3>

React Native는 [**React**][r]의 선언적 UI 프레임워크를 iOS와 Android로 가져옵니다. React Native를 사용하면 네이티브 UI 컨트롤을 사용하고 네이티브 플랫폼에 완전히 접근할 수 있습니다.

- **선언적.** React는 대화형 UI를 손쉽게 만듭니다. 선언적 뷰는 코드를 더 예측 가능하고 디버깅하기 쉽게 만듭니다.
- **컴포넌트 기반.** 상태를 관리하는 캡슐화된 컴포넌트를 만들고, 이를 조합하여 복잡한 UI를 구성하세요.
- **개발자 속도.** 변경 사항을 몇 초 만에 확인할 수 있습니다. JavaScript 코드를 변경하면 네이티브 앱을 다시 빌드하지 않고도 라이브 리로드할 수 있습니다.
- **이식성.** iOS, Android, [다른 플랫폼][p]에서도 코드를 재사용할 수 있습니다.

React Native는 여러 기업과 핵심 기여자들에 의해 개발 및 지원되고 있습니다. [에코시스템 개요][e]에서 더 알아보세요.

[r]: https://react.dev/
[p]: https://reactnative.dev/docs/out-of-tree-platforms
[e]: https://github.com/facebook/react-native/blob/HEAD/ECOSYSTEM.md

## 목차

- [요구 사항](#-requirements)
- [첫 React Native 앱 빌드하기](#-building-your-first-react-native-app)
- [문서](#-documentation)
- [업그레이드](#-upgrading)
- [기여 방법](#-how-to-contribute)
- [행동 강령](#code-of-conduct)
- [라이선스](#-license)

## 📋 요구 사항

React Native 앱은 iOS 15.1 및 Android 7.0(API 24) 이상을 지원할 수 있습니다. 개발 운영 체제로는 Windows, macOS, Linux 중 어느 것이든 사용할 수 있지만, iOS 앱의 빌드와 실행은 macOS에서만 가능합니다. [Expo](https://expo.dev)와 같은 도구를 사용해 이를 우회할 수 있습니다.

## 🎉 첫 React Native 앱 빌드하기

[시작하기 가이드](https://reactnative.dev/docs/getting-started)를 따라 진행하세요. React Native 설치 방법은 프로젝트에 따라 다릅니다. 가장 일반적인 상황별 간단 가이드를 아래에서 확인할 수 있습니다:

- [React Native 체험하기][hello-world]
- [새 애플리케이션 만들기][new-app]
- [기존 애플리케이션에 React Native 추가하기][existing]

[hello-world]: https://snack.expo.dev/@samples/hello-world
[new-app]: https://reactnative.dev/docs/getting-started
[existing]: https://reactnative.dev/docs/integration-with-existing-apps

## 📖 문서

React Native의 전체 문서는 [웹사이트][docs]에서 확인할 수 있습니다.

React Native 문서에서는 React Native에 특화된 컴포넌트, API 및 주제를 다룹니다. React Native와 React DOM에서 공유되는 React API에 대한 추가 문서는 [React 문서][r-docs]를 참고하세요.

React Native 문서와 웹사이트의 소스는 별도의 저장소인 [**@facebook/react-native-website**][repo-website]에 호스팅되어 있습니다.

[docs]: https://reactnative.dev/docs/getting-started
[r-docs]: https://react.dev/learn
[repo-website]: https://github.com/facebook/react-native-website

## 🚀 업그레이드

React Native의 새로운 버전으로 업그레이드하면 더 많은 API, 뷰, 개발자 도구 및 다양한 기능에 접근할 수 있습니다. 자세한 방법은 [업그레이드 가이드][u]를 참고하세요.

React Native 릴리스에 관한 논의는 [이 토론 저장소](https://github.com/reactwg/react-native-releases/discussions)에서 확인할 수 있습니다.

[u]: https://reactnative.dev/docs/upgrading
[repo-releases]: https://github.com/react-native-community/react-native-releases

## 👏 기여 방법

이 저장소의 주 목적은 React Native 코어의 지속적인 발전입니다. 이 프로젝트에 기여하는 과정을 최대한 쉽고 투명하게 만들고자 하며, 버그 수정과 개선에 기여해 주시는 커뮤니티에 감사드립니다. React Native 개선에 참여하는 방법은 아래를 참고하세요.

### [행동 강령][code]

Facebook은 프로젝트 참가자들이 준수해야 할 행동 강령을 채택했습니다.
[전체 텍스트][code]를 읽어 어떤 행동이 허용되고 허용되지 않는지 이해해 주시기 바랍니다.

[code]: https://code.fb.com/codeofconduct/

### [기여 가이드][contribute]

[**기여 가이드**][contribute]를 읽고 개발 프로세스, 버그 수정 및 개선 제안 방법, React Native에 대한 변경 사항을 빌드 및 테스트하는 방법을 알아보세요.

[contribute]: https://reactnative.dev/docs/contributing

### [오픈 소스 로드맵][roadmap]

[**로드맵**][roadmap]에서 React Native에 대한 우리의 비전을 더 자세히 알아볼 수 있습니다.

[roadmap]: https://github.com/facebook/react-native/wiki/Roadmap

### Good First Issues

상대적으로 범위가 제한된 버그를 포함하는 [good first issues][gfi] 목록이 있습니다. 이곳에서 시작하면 경험을 쌓고, 기여 프로세스에 익숙해질 수 있습니다.

[gfi]: https://github.com/facebook/react-native/labels/good%20first%20issue

### 토론

더 큰 논의와 제안은 [**@react-native-community/discussions-and-proposals**][repo-meta]에서 이루어집니다.

[repo-meta]: https://github.com/react-native-community/discussions-and-proposals

## 📄 라이선스

React Native는 [LICENSE][l] 파일에 명시된 대로 MIT 라이선스로 배포됩니다.

[l]: https://github.com/facebook/react-native/blob/main/LICENSE

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---