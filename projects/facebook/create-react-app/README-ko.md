## Create React App [![Build & Test](https://github.com/facebook/create-react-app/actions/workflows/build-and-test.yml/badge.svg?branch=main)](https://github.com/facebook/create-react-app/actions/workflows/build-and-test.yml) [![PRs Welcome](https://img.shields.io/badge/PRs-welcome-green.svg)](https://github.com/facebook/create-react-app/blob/main/CONTRIBUTING.md)

> [!CAUTION]
>
> ## 사용 중단됨
>
> Create React App은 2017-2021년 동안 React 프로젝트를 빠르게 시작하는 데 중요한 도구 중 하나였으나, 현재는 장기 유지 관리 모드에 있으며 [새로운 React 프로젝트 시작하기](https://react.dev/learn/start-a-new-react-project)에 문서화된 React 프레임워크로 마이그레이션할 것을 권장합니다.
>
> React를 배우기 위해 튜토리얼을 따라가고 있다면 계속 진행하는 것도 의미가 있지만, Create React App을 기반으로 새로운 프로덕션 앱을 시작하는 것은 추천하지 않습니다.

<img alt="Logo" align="right" src="https://create-react-app.dev/img/logo.svg" width="20%" />

빌드 구성이 필요 없는 React 앱을 생성하세요.

- [앱 생성하기](#creating-an-app) – 새로운 앱을 만드는 방법
- [사용자 가이드](https://facebook.github.io/create-react-app/) – Create React App으로 부트스트랩된 앱을 개발하는 방법

Create React App은 macOS, Windows, Linux에서 동작합니다.<br>
문제가 발생한다면 [이슈 등록](https://github.com/facebook/create-react-app/issues/new)을 해주세요.<br>
질문이나 도움이 필요하다면 [GitHub Discussions](https://github.com/facebook/create-react-app/discussions)에서 문의하세요.

## 빠른 시작

```sh
npx create-react-app my-app
cd my-app
npm start
```

이전에 `npm install -g create-react-app`으로 `create-react-app`을 전역 설치했다면, `npm uninstall -g create-react-app` 또는 `yarn global remove create-react-app`을 사용해 패키지를 제거해 주세요. 이렇게 하면 npx가 항상 최신 버전을 사용하게 됩니다.

_([npx](https://medium.com/@maybekatz/introducing-npx-an-npm-package-runner-55f7d4bd282b)은 npm 5.2 이상에 포함되어 있습니다. [구버전 npm 사용법 참고](https://gist.github.com/gaearon/4064d3c23a77c74a3614c498a8bb1c5f))_

그 다음 [http://localhost:3000/](http://localhost:3000/)에서 앱을 확인하세요.<br>
프로덕션에 배포할 준비가 되면, `npm run build`로 번들 파일을 만드세요.

<p align='center'>
<img src='https://cdn.jsdelivr.net/gh/facebook/create-react-app@27b42ac7efa018f2541153ab30d63180f5fa39e0/screencast.svg' width='600' alt='npm start'>
</p>

### 즉시 시작하기

webpack이나 Babel 같은 도구를 설치하거나 구성할 필요가 **없습니다**.<br>
이들은 사전에 구성되어 있고 숨겨져 있어, 코드 작성에 집중할 수 있습니다.

프로젝트를 생성하면 바로 시작할 수 있습니다.

## 앱 생성하기

**로컬 개발 머신에 Node 14.0.0 이상이 필요합니다** (서버에는 필요 없음). 최신 LTS 버전 사용을 권장합니다. [nvm](https://github.com/creationix/nvm#installation) (macOS/Linux)이나 [nvm-windows](https://github.com/coreybutler/nvm-windows#node-version-manager-nvm-for-windows)를 이용해 프로젝트별로 Node 버전을 전환할 수 있습니다.

새로운 앱을 만들려면 다음 방법 중 하나를 선택하세요:

### npx

```sh
npx create-react-app my-app
```

_([npx](https://medium.com/@maybekatz/introducing-npx-an-npm-package-runner-55f7d4bd282b)은 npm 5.2 이상에 포함된 패키지 실행 도구입니다. [구버전 npm 사용법 참고](https://gist.github.com/gaearon/4064d3c23a77c74a3614c498a8bb1c5f))_

### npm

```sh
npm init react-app my-app
```

_`npm init <initializer>`는 npm 6 이상에서 사용 가능합니다_

### Yarn

```sh
yarn create react-app my-app
```

_[`yarn create <starter-kit-package>`](https://yarnpkg.com/lang/en/docs/cli/create/)는 Yarn 0.25 이상에서 사용 가능합니다_

현재 폴더 내에 `my-app`이라는 디렉토리가 생성됩니다.<br>
해당 디렉토리 내부에 초기 프로젝트 구조가 생성되고, 트랜지티브(의존) 패키지들이 설치됩니다:

```
my-app
├── README.md
├── node_modules
├── package.json
├── .gitignore
├── public
│   ├── favicon.ico
│   ├── index.html
│   └── manifest.json
└── src
    ├── App.css
    ├── App.js
    ├── App.test.js
    ├── index.css
    ├── index.js
    ├── logo.svg
    └── serviceWorker.js
    └── setupTests.js
```

구성 파일이나 복잡한 폴더 구조 없이, 앱을 만드는 데 필요한 파일만 포함되어 있습니다.<br>
설치가 완료되면 프로젝트 폴더를 열 수 있습니다:

```sh
cd my-app
```

새로 생성된 프로젝트 내에서 다음과 같은 내장 명령어를 실행할 수 있습니다:

### `npm start` 또는 `yarn start`

앱을 개발 모드로 실행합니다.<br>
[http://localhost:3000](http://localhost:3000)에서 브라우저로 확인하세요.

코드를 변경하면 페이지가 자동으로 새로고침됩니다.<br>
콘솔에서 빌드 오류와 린트 경고를 확인할 수 있습니다.

<p align='center'>
<img src='https://cdn.jsdelivr.net/gh/marionebl/create-react-app@9f6282671c54f0874afd37a72f6689727b562498/screencast-error.svg' width='600' alt='Build errors'>
</p>

### `npm test` 또는 `yarn test`

테스트 워처를 인터랙티브 모드로 실행합니다.<br>
기본적으로 마지막 커밋 이후 변경된 파일과 관련된 테스트만 실행합니다.

[테스트 실행에 대해 더 알아보기](https://facebook.github.io/create-react-app/docs/running-tests)

### `npm run build` 또는 `yarn build`

앱을 프로덕션용으로 `build` 폴더에 빌드합니다.<br>
프로덕션 모드로 React를 번들링하고, 최적의 성능을 위해 빌드를 최적화합니다.

빌드 결과는 최소화되고 파일명에 해시가 포함됩니다.<br>

앱을 바로 배포할 수 있습니다.

## 사용자 가이드

Create React App 사용법과 다양한 팁은 [공식 문서](https://facebook.github.io/create-react-app/)에서 확인하실 수 있습니다.

## 새 버전으로 업데이트하려면?

이에 대한 정보는 [사용자 가이드](https://facebook.github.io/create-react-app/docs/updating-to-new-releases)를 참고하세요.

## 철학

- **하나의 의존성:** 빌드 의존성은 하나뿐입니다. 내부적으로 webpack, Babel, ESLint 등 훌륭한 프로젝트를 사용하지만, 그 위에 일관된 경험을 제공합니다.

- **구성 필요 없음:** 별도의 설정이 필요 없습니다. 개발과 프로덕션 빌드 모두에 대해 합리적으로 좋은 구성이 제공되어 코드 작성에만 집중할 수 있습니다.

- **락인(Lock-In) 없음:** 언제든지 “eject” 명령어로 커스텀 설정으로 전환할 수 있습니다. 한 번의 명령어로 모든 구성과 빌드 의존성이 프로젝트로 이동되어, 기존 상태에서 바로 작업을 이어갈 수 있습니다.

## 포함된 기능

최신 싱글페이지 React 앱을 만드는 데 필요한 모든 환경이 제공됩니다:

- React, JSX, ES6, TypeScript, Flow 문법 지원
- ES6 이상의 문법(객체 전개 연산자 등) 지원
- Autoprefixed CSS(`-webkit-` 등 접두사 불필요)
- 커버리지 리포트 지원이 내장된 빠르고 인터랙티브한 단위 테스트 러너
- 일반적인 실수를 경고하는 라이브 개발 서버
- JS, CSS, 이미지 번들링 및 해시, 소스맵 지원 빌드 스크립트
- 오프라인 우선 [서비스 워커](https://developers.google.com/web/fundamentals/getting-started/primers/service-workers) 및 [웹앱 매니페스트](https://developers.google.com/web/fundamentals/engage-and-retain/web-app-manifest) 제공, [PWA](https://facebook.github.io/create-react-app/docs/making-a-progressive-web-app) 기준 충족 (_참고: 서비스 워커는 `react-scripts@2.0.0` 이상부터 opt-in_)
- 위 도구들을 하나의 의존성으로 간편하게 업데이트

이 도구들이 어떻게 동작하는지 개요는 [이 가이드](https://github.com/nitishdayal/cra_closer_look)를 참고하세요.

단, **이 도구들은 특정 방식으로 미리 구성되어 있습니다**. 프로젝트에 더 많은 커스터마이즈가 필요하다면 ["eject"](https://facebook.github.io/create-react-app/docs/available-scripts#npm-run-eject) 후 직접 설정을 관리할 수 있습니다.

## 인기 대안

Create React App은 다음과 같은 경우에 적합합니다:

- **React 학습:** 편안하고 다양한 기능을 갖춘 개발 환경에서 React를 학습
- **새로운 싱글페이지 React 앱 시작**
- **라이브러리/컴포넌트 예제 작성**

다음과 같은 경우 다른 도구를 고려해볼 수 있습니다:

- **수백 개의 트랜지티브 빌드 도구 의존성 없이 React를 체험하고 싶다면** [단일 HTML 파일이나 온라인 샌드박스](https://reactjs.org/docs/getting-started.html#try-react)를 사용해보세요.

- **서버사이드 템플릿 프레임워크(예: Rails, Django, Symfony)와 React를 통합하거나, 싱글페이지 앱이 아닌 경우** [nwb](https://github.com/insin/nwb) 또는 [Neutrino](https://neutrino.js.org/)가 더 유연합니다. Rails의 경우 [Rails Webpacker](https://github.com/rails/webpacker), Symfony의 경우 [Symfony의 webpack Encore](https://symfony.com/doc/current/frontend/encore/reactjs.html)를 사용하세요.

- **React 컴포넌트를 배포해야 한다면** [nwb](https://github.com/insin/nwb) 또는 [Neutrino의 react-components 프리셋](https://neutrino.js.org/packages/react-components/)을 사용하세요.

- **React와 Node.js로 서버 렌더링을 하고 싶다면** [Next.js](https://nextjs.org/) 또는 [Razzle](https://github.com/jaredpalmer/razzle)을 참고하세요. Create React App은 백엔드와 무관하며, 정적 HTML/JS/CSS 번들만 생성합니다.

- **웹사이트가 대부분 정적이라면** (예: 포트폴리오, 블로그) [Gatsby](https://www.gatsbyjs.org/)나 [Next.js](https://nextjs.org/)를 고려하세요. Gatsby는 빌드 시 HTML로 사전 렌더링하고, Next.js는 서버 렌더링과 프리렌더링을 지원합니다.

- **더 많은 커스터마이즈가 필요하다면** [Neutrino](https://neutrino.js.org/)와 그 [React 프리셋](https://neutrino.js.org/packages/react/)을 확인하세요.

위 도구들은 대부분 별도의 복잡한 설정 없이 사용 가능합니다.

빌드를 직접 구성하고 싶다면 [이 가이드](https://reactjs.org/docs/add-react-to-a-website.html)를 따라하세요.

## React Native

React Native용으로 유사한 도구를 찾고 계신가요?<br>
[Expo CLI](https://github.com/expo/expo-cli)를 참고하세요.

## 기여하기

`create-react-app`에 기여해주실 분을 환영합니다! 원하는 내용과 시작 방법은 [CONTRIBUTING.md](CONTRIBUTING.md)를 참고하세요.

## Create React App 지원하기

Create React App은 커뮤니티가 유지하는 프로젝트이며 모든 기여자는 자원봉사자입니다. 향후 개발을 지원하고 싶으시다면 [Open Collective](https://opencollective.com/create-react-app)에 기부를 고려해 주세요.

## 크레딧

이 프로젝트는 [기여자들](CONTRIBUTING.md) 덕분에 존재합니다.<br>
<a href="https://github.com/facebook/create-react-app/graphs/contributors"><img src="https://opencollective.com/create-react-app/contributors.svg?width=890&button=false" /></a>

문서 호스팅을 제공해준 [Netlify](https://www.netlify.com/)에 감사드립니다.

## 감사의 말씀

아이디어와 협업을 제공해주신 기존 관련 프로젝트의 저자분들께 감사드립니다:

- [@eanplatter](https://github.com/eanplatter)
- [@insin](https://github.com/insin)
- [@mxstbr](https://github.com/mxstbr)

## 라이선스

Create React App은 [MIT 라이선스](https://github.com/facebook/create-react-app/blob/main/LICENSE)로 오픈소스로 제공됩니다. Create React App 로고는 [Creative Commons Attribution 4.0 International license](https://creativecommons.org/licenses/by/4.0/)로 사용 가능합니다.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---