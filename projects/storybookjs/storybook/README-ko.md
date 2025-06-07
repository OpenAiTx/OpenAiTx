<p align="center">
  <a href="https://storybook.js.org/">
    <picture>
      <source media="(prefers-color-scheme: dark)" srcset="https://user-images.githubusercontent.com/263385/199832481-bbbf5961-6a26-481d-8224-51258cce9b33.png">
      <img src="https://user-images.githubusercontent.com/321738/63501763-88dbf600-c4cc-11e9-96cd-94adadc2fd72.png" alt="Storybook" width="400" />
    </picture>
    
  </a>
  
</p>

<p align="center">안정적인 UI 컴포넌트를 더 빠르게 빌드하세요</p>

<br/>

<p align="center">
  <a href="https://circleci.com/gh/storybookjs/storybook">
    <img src="https://circleci.com/gh/storybookjs/storybook.svg?style=shield" alt="Build Status on CircleCI" />
  </a>
  <a href="https://codecov.io/gh/storybookjs/storybook">
    <img src="https://codecov.io/gh/storybookjs/storybook/branch/main/graph/badge.svg" alt="codecov" />
  </a>
  <a href="https://github.com/storybookjs/storybook/blob/main/LICENSE">
    <img src="https://img.shields.io/github/license/storybookjs/storybook.svg" alt="License" />
  </a>
  <br/>
  <a href="https://discord.gg/storybook">
    <img src="https://img.shields.io/badge/discord-join-7289DA.svg?logo=discord&longCache=true&style=flat" />
  </a>
  <a href="https://storybook.js.org/community/">
    <img src="https://img.shields.io/badge/community-join-4BC424.svg" alt="Storybook Community" />
  </a>
  <a href="#backers">
    <img src="https://opencollective.com/storybook/backers/badge.svg" alt="Backers on Open Collective" />
  </a>
  <a href="#sponsors">
    <img src="https://opencollective.com/storybook/tiers/sponsors/badge.svg" alt="Sponsors on Open Collective" />
  </a>
  <a href="https://x.com/intent/follow?screen_name=storybookjs">
    <img src="https://img.shields.io/twitter/follow/storybookjs?color=blue&logo=twitter" alt="Official Twitter Handle" />
  </a>
  <a href="https://api.securityscorecards.dev/projects/github.com/storybookjs/storybook">
    <img src="https://api.securityscorecards.dev/projects/github.com/storybookjs/storybook/badge" alt="OpenSSF Scorecard"/>
  </a>
</p>

<p align="center">
Storybook은 UI 컴포넌트와 페이지를 독립적으로 개발할 수 있는 프론트엔드 워크숍입니다. 수천 개의 팀이 UI 개발, 테스트, 문서화에 Storybook을 사용하고 있습니다. 자세한 내용은 https://storybook.js.org 에서 확인하세요!
</p>

<center>
  <img src="https://raw.githubusercontent.com/storybookjs/storybook/main/media/storybook-intro.gif" width="100%" />
</center>

<p align="center">
  README 보기:<br/>
  <a href="https://github.com/storybookjs/storybook/blob/main/README.md" title="latest"><img alt="latest" src="https://img.shields.io/npm/v/@storybook/react/latest?style=for-the-badge&logo=storybook&logoColor=ffffff&color=66BF3C" /></a>
  <a href="https://github.com/storybookjs/storybook/blob/next/README.md" title="next"><img alt="next" src="https://img.shields.io/npm/v/@storybook/react/next?style=for-the-badge&logo=storybook&logoColor=ffffff&color=1EA7FD" /></a>
</p>

## 목차

- 🚀 [시작하기](#getting-started)
- 📒 [프로젝트](#projects)
  - 🛠 [지원 프레임워크 & 예시](#supported-frameworks)
  - 🔗[애드온](#addons)
- 🏅 [뱃지 & 발표 자료](#badges--presentation-materials)
- 👥 [커뮤니티](#community)
- 👏 [기여하기](#contributing)
  - 👨‍💻 [개발 스크립트](#development-scripts)
  - 💸 [스폰서](#sponsors)
  - 💵 [후원자](#backers)
- :memo: [라이선스](#license)

## 시작하기

[Storybook 공식 웹사이트](https://storybook.js.org)에서 Storybook에 대해 더 알아보고 시작하는 방법을 확인하세요.

### 문서

문서는 [Storybook 공식 문서 사이트](https://storybook.js.org/docs)에서 확인할 수 있습니다.

### 예시

[컴포넌트 백과사전](https://storybook.js.org/showcase)에서 선도적인 팀들이 Storybook을 어떻게 사용하는지 확인하세요.

[storybook.new](https://storybook.new)를 사용하면 Stackblitz에서 예제 프로젝트를 빠르게 생성할 수 있습니다.

Storybook에는 컴포넌트 디자인, 문서화, 테스트, 상호작용 등을 위한 다양한 [애드온](https://storybook.js.org/docs/configure/user-interface/storybook-addons)이 포함되어 있습니다. Storybook의 API를 통해 다양한 방식으로 구성 및 확장이 가능합니다. React Native, Android, iOS, Flutter 등 모바일 개발까지 확장 지원합니다.

### 커뮤니티

추가적인 도움이 필요하다면 [저장소의 GitHub Discussions](https://github.com/storybookjs/storybook/discussions/new?category=help)에서 이슈를 공유하세요.

## 프로젝트

### 지원 프레임워크

| 렌더러                                                        | 데모                                                                                                                                                                          |                                                                                                                                                 |
| ------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------- |
| [React](code/renderers/react)                                 | [![Storybook demo](https://img.shields.io/npm/v/@storybook/react/latest?style=flat-square&color=blue&label)](https://next--630511d655df72125520f051.chromatic.com/)           | [![React](https://img.shields.io/npm/dm/@storybook/react?style=flat-square&color=eee)](code/renderers/react)                                    |
| [Angular](code/frameworks/angular/)                           | [![Storybook demo](https://img.shields.io/npm/v/@storybook/angular/latest?style=flat-square&color=blue&label)](https://next--6322ce6af69825592bbb28fc.chromatic.com/)         | [![Angular](https://img.shields.io/npm/dm/@storybook/angular?style=flat-square&color=eee)](code/frameworks/angular/)                            |
| [Vue 3](code/renderers/vue3)                                 | [![Storybook demo](https://img.shields.io/npm/v/@storybook/vue3/latest?style=flat-square&color=blue&label)](https://next--630513346a8e284ae244d415.chromatic.com/)            | [![Vue 3](https://img.shields.io/npm/dm/@storybook/vue3?style=flat-square&color=eee)](code/renderers/vue3/)                                     |
| [Web components](code/renderers/web-components)               | [![Storybook demo](https://img.shields.io/npm/v/@storybook/web-components/latest?style=flat-square&color=blue&label)](https://next--638db5bf49adfdfe8cf545e0.chromatic.com/)  | [![Svelte](https://img.shields.io/npm/dm/@storybook/web-components?style=flat-square&color=eee)](code/renderers/web-components)                 |
| [React Native](https://github.com/storybookjs/react-native)   | [![](https://img.shields.io/npm/v/@storybook/react-native/latest?style=flat-square&color=blue&label)](/)                                                                      | [![React Native](https://img.shields.io/npm/dm/@storybook/react-native?style=flat-square&color=eee)](https://github.com/storybookjs/react-native) |
| [HTML](code/renderers/html)                                   | [![Storybook demo](https://img.shields.io/npm/v/@storybook/html/latest?style=flat-square&color=blue&label)](https://next--63dd39a158cf6fc05199b4bb.chromatic.com/)            | [![HTML](https://img.shields.io/npm/dm/@storybook/html?style=flat-square&color=eee)](code/renderers/html)                                       |
| [Ember](code/frameworks/ember/)                               | [![](https://img.shields.io/npm/v/@storybook/ember/latest?style=flat-square&color=blue&label)](/)                                                                             | [![Ember](https://img.shields.io/npm/dm/@storybook/ember?style=flat-square&color=eee)](code/frameworks/ember/)                                  |
| [Svelte](code/renderers/svelte)                               | [![Storybook demo](https://img.shields.io/npm/v/@storybook/svelte/latest?style=flat-square&color=blue&label)](https://next--630873996e4e3557791c069c.chromatic.com/)          | [![Svelte](https://img.shields.io/npm/dm/@storybook/svelte?style=flat-square&color=eee)](code/renderers/svelte)                                 |
| [Preact](code/renderers/preact)                               | [![Storybook demo](https://img.shields.io/npm/v/@storybook/preact/latest?style=flat-square&color=blue&label)](https://next--63b588a512565bfaace15e7c.chromatic.com/)          | [![Preact](https://img.shields.io/npm/dm/@storybook/preact?style=flat-square&color=eee)](code/renderers/preact)                                 |
| [Qwik](https://github.com/literalpie/storybook-framework-qwik) | [![](https://img.shields.io/npm/v/storybook-framework-qwik/latest?style=flat-square&color=blue&label)](/)                                                                     | [![Qwik](https://img.shields.io/npm/dm/storybook-framework-qwik?style=flat-square&color=eee)](https://github.com/literalpie/storybook-framework-qwik) |
| [SolidJS](https://github.com/storybookjs/solidjs)             | [![](https://img.shields.io/npm/v/storybook-solidjs/latest?style=flat-square&color=blue&label)](/)                                                                            | [![SolidJS](https://img.shields.io/npm/dm/storybook-solidjs?style=flat-square&color=eee)](https://github.com/storybookjs/solidjs)               |
| [Android, iOS, Flutter](https://github.com/storybookjs/native) | [![](https://img.shields.io/npm/v/@storybook/native/latest?style=flat-square&color=blue&label)](/)                                                                            | [![Native](https://img.shields.io/npm/dm/@storybook/native?style=flat-square&color=eee)](https://github.com/storybookjs/native)                 |

### 애드온

| 애드온                                                                     | 설명                                                                      |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| [a11y](code/addons/a11y/)                                                 | Storybook에서 컴포넌트의 접근성 테스트                                     |
| [actions](code/core/src/actions/)                                         | Storybook UI에서 컴포넌트와 상호작용 시 발생하는 액션 로그                  |
| [backgrounds](code/core/src/backgrounds)                                  | Storybook UI에서 배경을 선택 가능                                          |
| [cssresources](https://github.com/storybookjs/addon-cssresources)         | 컴포넌트 iframe에 CSS 리소스 동적으로 추가/제거                             |
| [design assets](https://github.com/storybookjs/addon-design-assets)       | 스토리와 함께 이미지, 비디오, 웹링크 보기                                  |
| [docs](code/addons/docs/)                                                 | 컴포넌트에 고품질 문서 추가                                               |
| [events](https://github.com/storybookjs/addon-events)                     | EventEmitter에 반응하는 컴포넌트에 이벤트 인터랙티브 트리거                |
| [google-analytics](https://github.com/storybookjs/addon-google-analytics) | 스토리에서 구글 애널리틱스 리포트                                         |
| [graphql](https://github.com/storybookjs/addon-graphql)                   | Storybook 스토리 내에서 GraphQL 서버 쿼리                                  |
| [jest](code/addons/jest/)                                                 | Storybook에서 컴포넌트 단위 테스트 결과 보기                                |
| [links](code/addons/links/)                                               | 스토리 간 링크 생성                                                        |
| [measure](code/core/src/measure/)                                         | Storybook UI에서 레이아웃 및 박스 모델 시각적으로 검사                      |
| [outline](code/core/src/outline/)                                         | Storybook UI에서 CSS 레이아웃 및 정렬 시각적 디버깅                         |
| [query params](https://github.com/storybookjs/addon-queryparams)          | 쿼리 파라미터 모킹                                                         |
| [viewport](code/core/src/viewport/)                                       | Storybook을 활용하여 반응형 컴포넌트의 디스플레이 크기 및 레이아웃 변경       |

[애드온 / 프레임워크 지원 표](https://storybook.js.org/docs/configure/integration/frameworks-feature-support)를 참고하세요.

더 나은 경험을 위해, 일부 애드온은 새로운 도구로 교체/제거될 수 있습니다.

info/notes 애드온을 사용 중이라면 [docs](code/addons/docs/)로의 이전을 강력 추천하며, [이 가이드](code/addons/docs/docs/recipes.md#migrating-from-notesinfo-addons)를 참고하세요.

contexts 애드온을 사용 중이라면 [toolbars](https://github.com/storybookjs/storybook/tree/next/code/addons/toolbars)로의 이전을 추천하며, [이 가이드](https://github.com/storybookjs/storybook/blob/next/MIGRATION.md#deprecated-addon-contexts)를 참고하세요.

addon-storyshots를 사용 중이라면 Storybook [test-runner](https://github.com/storybookjs/test-runner)로의 이전을 추천하며, [이 가이드](https://storybook.js.org/docs/writing-tests/storyshots-migration-guide)를 참고하세요.

## 뱃지 & 발표 자료

Storybook 뱃지가 있습니다! 실시간 Storybook 예제에 연결하세요.

![Storybook](https://cdn.jsdelivr.net/gh/storybookjs/brand@main/badge/badge-storybook.svg)

```md
[![Storybook](https://cdn.jsdelivr.net/gh/storybookjs/brand@main/badge/badge-storybook.svg)](사이트 링크)
```

Storybook 발표에 사용할 로고, 비디오, 색상 등 자료가 필요하다면 [브랜드 저장소](https://github.com/storybookjs/brand)에서 모두 확인할 수 있습니다.

## 커뮤니티

- [@storybookjs](https://x.com/storybookjs)로 트윗
- [storybook.js.org](https://storybook.js.org/blog/) 및 [Medium](https://medium.com/storybookjs)에서 블로그
- [Discord](https://discord.gg/storybook)에서 채팅
- [YouTube](https://www.youtube.com/channel/UCr7Quur3eIyA_oe8FNYexfg)에서 비디오 및 스트리밍

## 기여하기

Storybook에 기여는 언제나 환영합니다!

- 📥 Pull Request와 🌟 Star는 언제나 환영합니다.
- [기여 가이드](CONTRIBUTING.md)를 참고하거나,
  [Discord](https://discord.gg/storybook)에서 문의하시면 안내해드립니다.

처음 도전할 이슈를 찾고 있나요?

- 코드베이스 또는 OSS에 익숙하지 않은 분들에게 적합하다고 생각되는 이슈에는 [![Good First Issue](https://img.shields.io/github/issues/storybookjs/storybook/good%20first%20issue.svg)](https://github.com/storybookjs/storybook/issues?q=is%3Aopen+is%3Aissue+label%3A%22good+first+issue%22) 태그가 붙어 있습니다.
- [문의하기](https://discord.gg/storybook), 여러분의 기술 및 학습 관심사에 맞는 작업을 찾아드릴 수 있습니다.

### 개발 스크립트

Storybook은 모노레포로 구성되어 있습니다. 유용한 스크립트는 다음과 같습니다:

#### `yarn start`

> 테스트 스토리가 포함된 샌드박스 템플릿 Storybook 실행

#### `yarn task`

> 위와 동일하나, 샌드박스 맞춤화(예: 다른 프레임워크 선택) 옵션 제공

#### `yarn lint`

> 코드가 린트 규칙을 준수하는지 불리언 체크 - remark & eslint 사용

- `yarn lint:js` - js 체크
- `yarn lint:md` - 마크다운 + 코드 샘플 체크
- `yarn lint:js --fix` - js 자동 수정

#### `yarn test`

> 유닛 테스트가 모두 통과하는지 불리언 체크 - jest 사용

- `yarn run test --core --watch` - 코어 테스트를 watch 모드로 실행

### 스폰서

스폰서가 되어 로고와 웹사이트 URL을 Github README에 노출하세요. \[[스폰서 되기](https://opencollective.com/storybook#sponsor)]

<a href="https://opencollective.com/storybook/tiers/sponsors/0/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/0/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/1/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/1/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/2/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/2/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/3/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/3/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/4/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/4/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/5/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/5/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/6/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/6/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/7/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/7/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/8/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/8/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/9/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/9/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/10/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/10/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/11/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/11/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/12/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/12/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/13/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/13/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/14/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/14/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/15/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/15/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/16/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/16/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/17/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/17/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/18/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/18/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/19/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/19/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/20/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/20/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/21/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/21/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/22/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/22/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/23/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/23/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/24/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/24/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/25/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/25/avatar.svg?requireActive=true"></a>

### 후원자

정기 후원을 통해 저희와 저희의 작업을 지원할 수 있습니다. \[[후원자 되기](https://opencollective.com/storybook#backer)]

<a href="https://opencollective.com/storybook"><img src="https://opencollective.com/storybook/tiers/backers.svg?limit=80&button=false&avatarHeight=46&width=750"></a>

## 라이선스

[MIT](https://github.com/storybookjs/storybook/blob/main/LICENSE)

-the end-

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---