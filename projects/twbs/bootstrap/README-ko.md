<p align="center">
  <a href="https://getbootstrap.com/">
    <img src="https://getbootstrap.com/docs/5.3/assets/brand/bootstrap-logo-shadow.png" alt="Bootstrap logo" width="200" height="165">
  </a>
</p>

<h3 align="center">Bootstrap</h3>

<p align="center">
  더 빠르고 쉬운 웹 개발을 위한 세련되고 직관적이며 강력한 프론트엔드 프레임워크입니다.
  <br>
  <a href="https://getbootstrap.com/docs/5.3/"><strong>Bootstrap 문서 살펴보기 »</strong></a>
  <br>
  <br>
  <a href="https://github.com/twbs/bootstrap/issues/new?assignees=-&labels=bug&template=bug_report.yml">버그 신고</a>
  ·
  <a href="https://github.com/twbs/bootstrap/issues/new?assignees=&labels=feature&template=feature_request.yml">기능 요청</a>
  ·
  <a href="https://themes.getbootstrap.com/">테마</a>
  ·
  <a href="https://blog.getbootstrap.com/">블로그</a>
</p>


## Bootstrap 5

기본 브랜치는 Bootstrap 5 릴리스를 개발하기 위한 것입니다. Bootstrap 4의 readme, 문서, 소스 코드를 보려면 [`v4-dev` 브랜치](https://github.com/twbs/bootstrap/tree/v4-dev)를 방문하세요.


## 목차

- [빠른 시작](#빠른-시작)
- [상태](#상태)
- [포함 내용](#포함-내용)
- [버그 및 기능 요청](#버그-및-기능-요청)
- [문서](#문서)
- [기여](#기여)
- [커뮤니티](#커뮤니티)
- [버전 관리](#버전-관리)
- [제작자](#제작자)
- [감사 인사](#감사-인사)
- [저작권 및 라이선스](#저작권-및-라이선스)


## 빠른 시작

여러 가지 빠른 시작 옵션이 제공됩니다:

- [최신 릴리스 다운로드](https://github.com/twbs/bootstrap/archive/v5.3.6.zip)
- 저장소 클론: `git clone https://github.com/twbs/bootstrap.git`
- [npm](https://www.npmjs.com/)으로 설치: `npm install bootstrap@v5.3.6`
- [yarn](https://yarnpkg.com/)으로 설치: `yarn add bootstrap@v5.3.6`
- [Bun](https://bun.sh/)으로 설치: `bun add bootstrap@v5.3.6`
- [Composer](https://getcomposer.org/)로 설치: `composer require twbs/bootstrap:5.3.6`
- [NuGet](https://www.nuget.org/)으로 설치: CSS: `Install-Package bootstrap` Sass: `Install-Package bootstrap.sass`

프레임워크의 구성, 템플릿, 예시 등에 대한 정보는 [시작하기 페이지](https://getbootstrap.com/docs/5.3/getting-started/introduction/)를 참고하세요.


## 상태

[![Build Status](https://img.shields.io/github/actions/workflow/status/twbs/bootstrap/js.yml?branch=main&label=JS%20Tests&logo=github)](https://github.com/twbs/bootstrap/actions/workflows/js.yml?query=workflow%3AJS+branch%3Amain)
[![npm version](https://img.shields.io/npm/v/bootstrap?logo=npm&logoColor=fff)](https://www.npmjs.com/package/bootstrap)
[![Gem version](https://img.shields.io/gem/v/bootstrap?logo=rubygems&logoColor=fff)](https://rubygems.org/gems/bootstrap)
[![Meteor Atmosphere](https://img.shields.io/badge/meteor-twbs%3Abootstrap-blue?logo=meteor&logoColor=fff)](https://atmospherejs.com/twbs/bootstrap)
[![Packagist Prerelease](https://img.shields.io/packagist/vpre/twbs/bootstrap?logo=packagist&logoColor=fff)](https://packagist.org/packages/twbs/bootstrap)
[![NuGet](https://img.shields.io/nuget/vpre/bootstrap?logo=nuget&logoColor=fff)](https://www.nuget.org/packages/bootstrap/absoluteLatest)
[![Coverage Status](https://img.shields.io/coveralls/github/twbs/bootstrap/main?logo=coveralls&logoColor=fff)](https://coveralls.io/github/twbs/bootstrap?branch=main)
[![CSS gzip size](https://img.badgesize.io/twbs/bootstrap/main/dist/css/bootstrap.min.css?compression=gzip&label=CSS%20gzip%20size)](https://github.com/twbs/bootstrap/blob/main/dist/css/bootstrap.min.css)
[![CSS Brotli size](https://img.badgesize.io/twbs/bootstrap/main/dist/css/bootstrap.min.css?compression=brotli&label=CSS%20Brotli%20size)](https://github.com/twbs/bootstrap/blob/main/dist/css/bootstrap.min.css)
[![JS gzip size](https://img.badgesize.io/twbs/bootstrap/main/dist/js/bootstrap.min.js?compression=gzip&label=JS%20gzip%20size)](https://github.com/twbs/bootstrap/blob/main/dist/js/bootstrap.min.js)
[![JS Brotli size](https://img.badgesize.io/twbs/bootstrap/main/dist/js/bootstrap.min.js?compression=brotli&label=JS%20Brotli%20size)](https://github.com/twbs/bootstrap/blob/main/dist/js/bootstrap.min.js)
[![Backers on Open Collective](https://img.shields.io/opencollective/backers/bootstrap?logo=opencollective&logoColor=fff)](#backers)
[![Sponsors on Open Collective](https://img.shields.io/opencollective/sponsors/bootstrap?logo=opencollective&logoColor=fff)](#sponsors)


## 포함 내용

다운로드한 파일에는 다음과 같은 디렉터리와 파일이 포함되어 있으며, 공통 에셋을 논리적으로 그룹화하고 컴파일된 버전 및 축소된 버전을 제공합니다.

<details>
  <summary>다운로드 구성</summary>

  ```text
  bootstrap/
  ├── css/
  │   ├── bootstrap-grid.css
  │   ├── bootstrap-grid.css.map
  │   ├── bootstrap-grid.min.css
  │   ├── bootstrap-grid.min.css.map
  │   ├── bootstrap-grid.rtl.css
  │   ├── bootstrap-grid.rtl.css.map
  │   ├── bootstrap-grid.rtl.min.css
  │   ├── bootstrap-grid.rtl.min.css.map
  │   ├── bootstrap-reboot.css
  │   ├── bootstrap-reboot.css.map
  │   ├── bootstrap-reboot.min.css
  │   ├── bootstrap-reboot.min.css.map
  │   ├── bootstrap-reboot.rtl.css
  │   ├── bootstrap-reboot.rtl.css.map
  │   ├── bootstrap-reboot.rtl.min.css
  │   ├── bootstrap-reboot.rtl.min.css.map
  │   ├── bootstrap-utilities.css
  │   ├── bootstrap-utilities.css.map
  │   ├── bootstrap-utilities.min.css
  │   ├── bootstrap-utilities.min.css.map
  │   ├── bootstrap-utilities.rtl.css
  │   ├── bootstrap-utilities.rtl.css.map
  │   ├── bootstrap-utilities.rtl.min.css
  │   ├── bootstrap-utilities.rtl.min.css.map
  │   ├── bootstrap.css
  │   ├── bootstrap.css.map
  │   ├── bootstrap.min.css
  │   ├── bootstrap.min.css.map
  │   ├── bootstrap.rtl.css
  │   ├── bootstrap.rtl.css.map
  │   ├── bootstrap.rtl.min.css
  │   └── bootstrap.rtl.min.css.map
  └── js/
      ├── bootstrap.bundle.js
      ├── bootstrap.bundle.js.map
      ├── bootstrap.bundle.min.js
      ├── bootstrap.bundle.min.js.map
      ├── bootstrap.esm.js
      ├── bootstrap.esm.js.map
      ├── bootstrap.esm.min.js
      ├── bootstrap.esm.min.js.map
      ├── bootstrap.js
      ├── bootstrap.js.map
      ├── bootstrap.min.js
      └── bootstrap.min.js.map
  ```
</details>

컴파일된 CSS 및 JS 파일(`bootstrap.*`)과 컴파일 및 축소된 CSS 및 JS 파일(`bootstrap.min.*`)을 제공합니다. [소스 맵](https://web.dev/articles/source-maps)(`bootstrap.*.map`)은 특정 브라우저의 개발자 도구에서 사용할 수 있습니다. 번들 JS 파일(`bootstrap.bundle.js` 및 축소된 `bootstrap.bundle.min.js`)에는 [Popper](https://popper.js.org/docs/v2/)가 포함되어 있습니다.


## 버그 및 기능 요청

버그나 기능 요청이 있으신가요? 먼저 [이슈 가이드라인](https://github.com/twbs/bootstrap/blob/main/.github/CONTRIBUTING.md#using-the-issue-tracker)을 읽고, 기존 또는 닫힌 이슈를 검색해 보세요. 만약 문제가 아직 다뤄지지 않았다면, [새 이슈를 등록](https://github.com/twbs/bootstrap/issues/new/choose)해 주세요.


## 문서

Bootstrap 문서는 이 저장소의 루트 디렉터리에 포함되어 있으며, [Astro](https://astro.build/)로 빌드되고 GitHub Pages의 <https://getbootstrap.com/>에서 공개적으로 호스팅됩니다. 문서는 로컬에서도 실행할 수 있습니다.

문서 검색은 [Algolia의 DocSearch](https://docsearch.algolia.com/)가 지원합니다.

### 문서를 로컬에서 실행하기

1. `npm install`을 실행하여 Node.js 종속성(Astro 포함)을 설치합니다.
2. `npm run test`(또는 특정 npm 스크립트)를 실행하여 배포용 CSS와 JavaScript 파일, 그리고 문서 에셋을 재빌드합니다.
3. 루트 `/bootstrap` 디렉터리에서 명령줄로 `npm run docs-serve`를 실행합니다.
4. 브라우저에서 `http://localhost:9001/`을 엽니다.

Astro 사용법은 [공식 문서](https://docs.astro.build/en/getting-started/)를 참고하세요.

### 이전 릴리스 문서

이전 버전의 모든 문서는 <https://getbootstrap.com/docs/versions/>에서 확인할 수 있습니다.

[이전 릴리스](https://github.com/twbs/bootstrap/releases)와 해당 문서도 다운로드할 수 있습니다.


## 기여

[기여 가이드라인](https://github.com/twbs/bootstrap/blob/main/.github/CONTRIBUTING.md)을 읽어보세요. 이슈 등록, 코딩 표준, 개발에 관한 안내가 포함되어 있습니다.

또한, Pull Request에 JavaScript 패치나 기능이 포함된 경우 [관련 단위 테스트](https://github.com/twbs/bootstrap/tree/main/js/tests)를 반드시 포함해야 합니다. 모든 HTML 및 CSS는 [Mark Otto](https://github.com/mdo)가 관리하는 [Code Guide](https://github.com/mdo/code-guide)를 따라야 합니다.

일반 텍스트 에디터에서 쉽게 사용할 수 있도록 [editor config](https://github.com/twbs/bootstrap/blob/main/.editorconfig)가 제공됩니다. 자세한 내용과 플러그인은 <https://editorconfig.org/>에서 확인할 수 있습니다.


## 커뮤니티

Bootstrap 개발 소식을 받고, 프로젝트 관리자 및 커뮤니티 멤버들과 소통하세요.

- [@getbootstrap on X](https://x.com/getbootstrap)를 팔로우하세요.
- [공식 Bootstrap 블로그](https://blog.getbootstrap.com/)를 읽고 구독하세요.
- [GitHub Discussions](https://github.com/twbs/bootstrap/discussions)에서 질문하고 소통하세요.
- [커뮤니티 Discord](https://discord.gg/bZUvakRU3M) 또는 [Bootstrap subreddit](https://www.reddit.com/r/bootstrap/)에서 토론 및 질문하세요.
- IRC에서 Bootstrappers와 채팅하세요. `irc.libera.chat` 서버의 `#bootstrap` 채널입니다.
- Stack Overflow에서 [`bootstrap-5`](https://stackoverflow.com/questions/tagged/bootstrap-5) 태그를 사용하여 구현 관련 도움을 받을 수 있습니다.
- 개발자는 [npm](https://www.npmjs.com/browse/keyword/bootstrap) 등 패키지 배포 시 `bootstrap` 키워드를 활용해 부트스트랩 기능 확장 패키지의 검색성을 높일 수 있습니다.


## 버전 관리

릴리스 주기의 투명성과 하위 호환성 유지를 위해 Bootstrap은 [Semantic Versioning 가이드라인](https://semver.org/)을 따릅니다. 가끔 실수가 있을 수 있지만, 가능한 한 해당 규칙을 준수합니다.

각 Bootstrap 릴리스 버전의 변경 로그는 [GitHub 프로젝트의 Releases 섹션](https://github.com/twbs/bootstrap/releases)에서 확인할 수 있습니다. [공식 Bootstrap 블로그](https://blog.getbootstrap.com/)의 릴리스 공지에는 주요 변경 사항 요약이 포함되어 있습니다.


## 제작자

**Mark Otto**

- <https://x.com/mdo>
- <https://github.com/mdo>

**Jacob Thornton**

- <https://x.com/fat>
- <https://github.com/fat>


## 감사 인사

<a href="https://www.browserstack.com/">
  <img src="https://live.browserstack.com/images/opensource/browserstack-logo.svg" alt="BrowserStack" width="192" height="42">
</a>

[BrowserStack](https://www.browserstack.com/) 덕분에 실제 브라우저에서 테스트할 수 있는 인프라를 제공받고 있습니다!

<a href="https://www.netlify.com/">
  <img src="https://www.netlify.com/v3/img/components/full-logo-light.svg" alt="Netlify" width="147" height="40">
</a>

[Netlify](https://www.netlify.com/)에서 Deploy Preview를 제공해 주셔서 감사합니다!


## 스폰서

이 프로젝트의 스폰서가 되어 지원해 주세요. 귀하의 로고가 이곳에 표시되며 웹사이트로 연결됩니다. [[스폰서 되기](https://opencollective.com/bootstrap#sponsor)]

[![OC sponsor 0](https://opencollective.com/bootstrap/sponsor/0/avatar.svg)](https://opencollective.com/bootstrap/sponsor/0/website)
[![OC sponsor 1](https://opencollective.com/bootstrap/sponsor/1/avatar.svg)](https://opencollective.com/bootstrap/sponsor/1/website)
[![OC sponsor 2](https://opencollective.com/bootstrap/sponsor/2/avatar.svg)](https://opencollective.com/bootstrap/sponsor/2/website)
[![OC sponsor 3](https://opencollective.com/bootstrap/sponsor/3/avatar.svg)](https://opencollective.com/bootstrap/sponsor/3/website)
[![OC sponsor 4](https://opencollective.com/bootstrap/sponsor/4/avatar.svg)](https://opencollective.com/bootstrap/sponsor/4/website)
[![OC sponsor 5](https://opencollective.com/bootstrap/sponsor/5/avatar.svg)](https://opencollective.com/bootstrap/sponsor/5/website)
[![OC sponsor 6](https://opencollective.com/bootstrap/sponsor/6/avatar.svg)](https://opencollective.com/bootstrap/sponsor/6/website)
[![OC sponsor 7](https://opencollective.com/bootstrap/sponsor/7/avatar.svg)](https://opencollective.com/bootstrap/sponsor/7/website)
[![OC sponsor 8](https://opencollective.com/bootstrap/sponsor/8/avatar.svg)](https://opencollective.com/bootstrap/sponsor/8/website)
[![OC sponsor 9](https://opencollective.com/bootstrap/sponsor/9/avatar.svg)](https://opencollective.com/bootstrap/sponsor/9/website)


## 후원자

모든 후원자분들께 감사드립니다! 🙏 [[후원자가 되기](https://opencollective.com/bootstrap#backer)]

[![Backers](https://opencollective.com/bootstrap/backers.svg?width=890)](https://opencollective.com/bootstrap#backers)


## 저작권 및 라이선스

코드와 문서의 저작권은 2011-2025 [Bootstrap Authors](https://github.com/twbs/bootstrap/graphs/contributors)에게 있습니다. 코드는 [MIT 라이선스](https://github.com/twbs/bootstrap/blob/main/LICENSE)로, 문서는 [크리에이티브 커먼즈](https://creativecommons.org/licenses/by/3.0/)로 배포됩니다.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---