## Vue 2는 지원 종료(EOL)에 도달했습니다

**여러분이 보고 계신 것은 Vue 2의 더 이상 활성화되지 않는 저장소입니다. Vue의 최신 버전이 유지 관리되는 저장소는 [vuejs/core](https://github.com/vuejs/core)입니다.**

Vue는 2023년 12월 31일부로 지원 종료(EOL)에 도달했습니다. 더 이상 새로운 기능, 업데이트, 또는 수정사항을 받지 않습니다. 그러나 기존의 모든 배포 채널(CDN, 패키지 관리자, Github 등)에서는 여전히 이용 가능합니다.

새 프로젝트를 시작하는 경우, 반드시 최신 버전의 Vue(3.x)로 시작해 주시기 바랍니다. 또한 기존 Vue 2 사용자는 업그레이드를 강력히 권장드립니다([가이드](https://v3-migration.vuejs.org/)). 하지만 모든 사용자가 업그레이드할 여유나 필요가 있지는 않다는 점도 이해합니다. 만약 Vue 2를 계속 사용해야 하면서도, 유지 관리되지 않는 소프트웨어에 대한 컴플라이언스나 보안 요구사항이 있다면, [Vue 2 NES](https://www.herodevs.com/support/nes-vue?utm_source=vuejs-github&utm_medium=vue2-readme)를 확인해 주세요.

<p align="center"><a href="https://vuejs.org" target="_blank" rel="noopener noreferrer"><img width="100" src="https://vuejs.org/images/logo.png" alt="Vue logo"></a></p>

<p align="center">
  <a href="https://circleci.com/gh/vuejs/vue/tree/dev"><img src="https://img.shields.io/circleci/project/github/vuejs/vue/dev.svg?sanitize=true" alt="Build Status"></a>
  <a href="https://codecov.io/github/vuejs/vue?branch=dev"><img src="https://img.shields.io/codecov/c/github/vuejs/vue/dev.svg?sanitize=true" alt="Coverage Status"></a>
  <a href="https://npmcharts.com/compare/vue?minimal=true"><img src="https://img.shields.io/npm/dm/vue.svg?sanitize=true" alt="Downloads"></a>
  <a href="https://www.npmjs.com/package/vue"><img src="https://img.shields.io/npm/v/vue.svg?sanitize=true" alt="Version"></a>
  <a href="https://www.npmjs.com/package/vue"><img src="https://img.shields.io/npm/l/vue.svg?sanitize=true" alt="License"></a>
  <a href="https://chat.vuejs.org/"><img src="https://img.shields.io/badge/chat-on%20discord-7289da.svg?sanitize=true" alt="Chat"></a>
</p>

## 후원자

Vue.js는 MIT 라이선스의 오픈 소스 프로젝트이며, 지속적인 개발은 전적으로 이 훌륭한 [후원자들](https://github.com/vuejs/core/blob/main/BACKERS.md)의 지원으로 이루어지고 있습니다. 여러분도 이 대열에 합류하고 싶다면 [Vue 개발 후원](https://vuejs.org/sponsor/)을 고려해 주세요.

<p align="center">
  <h3 align="center">특별 후원사</h3>
</p>

<p align="center">
  <a target="_blank" href="https://github.com/appwrite/appwrite">
  <img alt="special sponsor appwrite" src="https://sponsors.vuejs.org/images/appwrite.svg" width="300">
  </a>
</p>

<p align="center">
  <a target="_blank" href="https://vuejs.org/sponsor/">
    <img alt="sponsors" src="https://sponsors.vuejs.org/sponsors.svg?v3">
  </a>
</p>

---

## 소개

Vue(발음: `/vjuː/`, 'view'와 비슷)는 사용자 인터페이스를 구축하기 위한 **점진적 프레임워크**입니다. 처음부터 점진적으로 도입할 수 있도록 설계되었으며, 다양한 사용 사례에 따라 라이브러리에서 프레임워크로 쉽게 확장할 수 있습니다. 오직 뷰(View) 레이어에만 집중하는 접근하기 쉬운 핵심 라이브러리와, 대규모 싱글 페이지 애플리케이션의 복잡성을 해결할 수 있도록 돕는 생태계 라이브러리들로 구성되어 있습니다.

#### 브라우저 호환성

Vue.js는 [ES5를 지원하는](https://compat-table.github.io/compat-table/es5/) 모든 브라우저를 지원합니다(IE8 이하 버전은 지원하지 않습니다).

## 생태계

| 프로젝트                | 상태                                                           | 설명                                               |
| --------------------- | ------------------------------------------------------------ | -------------------------------------------------- |
| [vue-router]          | [![vue-router-status]][vue-router-package]                   | 싱글 페이지 애플리케이션 라우팅                    |
| [vuex]                | [![vuex-status]][vuex-package]                               | 대규모 상태 관리                                   |
| [vue-cli]             | [![vue-cli-status]][vue-cli-package]                         | 프로젝트 스캐폴딩                                  |
| [vue-loader]          | [![vue-loader-status]][vue-loader-package]                   | 웹팩용 싱글 파일 컴포넌트(`*.vue` 파일) 로더       |
| [vue-server-renderer] | [![vue-server-renderer-status]][vue-server-renderer-package] | 서버 사이드 렌더링 지원                            |
| [vue-class-component] | [![vue-class-component-status]][vue-class-component-package] | 클래스 기반 API용 TypeScript 데코레이터            |
| [vue-rx]              | [![vue-rx-status]][vue-rx-package]                           | RxJS 통합                                          |
| [vue-devtools]        | [![vue-devtools-status]][vue-devtools-package]               | 브라우저 개발자 도구 확장                          |

[vue-router]: https://github.com/vuejs/vue-router
[vuex]: https://github.com/vuejs/vuex
[vue-cli]: https://github.com/vuejs/vue-cli
[vue-loader]: https://github.com/vuejs/vue-loader
[vue-server-renderer]: https://github.com/vuejs/vue/tree/dev/packages/vue-server-renderer
[vue-class-component]: https://github.com/vuejs/vue-class-component
[vue-rx]: https://github.com/vuejs/vue-rx
[vue-devtools]: https://github.com/vuejs/vue-devtools
[vue-router-status]: https://img.shields.io/npm/v/vue-router.svg
[vuex-status]: https://img.shields.io/npm/v/vuex.svg
[vue-cli-status]: https://img.shields.io/npm/v/@vue/cli.svg
[vue-loader-status]: https://img.shields.io/npm/v/vue-loader.svg
[vue-server-renderer-status]: https://img.shields.io/npm/v/vue-server-renderer.svg
[vue-class-component-status]: https://img.shields.io/npm/v/vue-class-component.svg
[vue-rx-status]: https://img.shields.io/npm/v/vue-rx.svg
[vue-devtools-status]: https://img.shields.io/chrome-web-store/v/nhdogjmejiglipccpnnnanhbledajbpd.svg
[vue-router-package]: https://npmjs.com/package/vue-router
[vuex-package]: https://npmjs.com/package/vuex
[vue-cli-package]: https://npmjs.com/package/@vue/cli
[vue-loader-package]: https://npmjs.com/package/vue-loader
[vue-server-renderer-package]: https://npmjs.com/package/vue-server-renderer
[vue-class-component-package]: https://npmjs.com/package/vue-class-component
[vue-rx-package]: https://npmjs.com/package/vue-rx
[vue-devtools-package]: https://chrome.google.com/webstore/detail/vuejs-devtools/nhdogjmejiglipccpnnnanhbledajbpd

## 문서

[실시간 예제](https://v2.vuejs.org/v2/examples/)와 문서를 확인하려면 [vuejs.org](https://v2.vuejs.org)를 방문해 주세요.

## 질문

질문 및 지원은 [공식 포럼](https://forum.vuejs.org)이나 [커뮤니티 채팅](https://chat.vuejs.org/)을 이용해 주세요. 이 저장소의 이슈 리스트는 **오로지** 버그 리포트 및 기능 요청용입니다.

## 이슈

이슈를 등록하기 전에 [이슈 등록 체크리스트](https://github.com/vuejs/vue/blob/dev/.github/CONTRIBUTING.md#issue-reporting-guidelines)를 반드시 읽어 주세요. 가이드라인을 따르지 않는 이슈는 즉시 닫힐 수 있습니다.

## 변경 이력

각 릴리즈의 상세 변경 사항은 [릴리즈 노트](https://github.com/vuejs/vue/releases)에서 확인할 수 있습니다.

## 소통 채널

- [트위터](https://twitter.com/vuejs)
- [블로그](https://medium.com/the-vue-point)
- [구인 게시판](https://vuejobs.com/?ref=vuejs)

## 기여

풀 리퀘스트를 보내기 전에 [기여 가이드](https://github.com/vuejs/vue/blob/dev/.github/CONTRIBUTING.md)를 꼭 읽어 주세요. Vue 관련 프로젝트/컴포넌트/도구가 있다면 [이 추천 목록](https://github.com/vuejs/awesome-vue)에 풀 리퀘스트로 추가해 주세요!

이미 Vue에 기여해 주신 모든 분들께 감사드립니다!

<a href="https://github.com/vuejs/vue/graphs/contributors"><img src="https://opencollective.com/vuejs/contributors.svg?width=890" /></a>

## 라이선스

[MIT](https://opensource.org/licenses/MIT)

Copyright (c) 2013-present, Yuxi (Evan) You

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---