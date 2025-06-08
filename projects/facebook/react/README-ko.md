# [React](https://react.dev/) &middot; [![GitHub license](https://img.shields.io/badge/license-MIT-blue.svg)](https://github.com/facebook/react/blob/main/LICENSE) [![npm version](https://img.shields.io/npm/v/react.svg?style=flat)](https://www.npmjs.com/package/react) [![(Runtime) Build and Test](https://github.com/facebook/react/actions/workflows/runtime_build_and_test.yml/badge.svg)](https://github.com/facebook/react/actions/workflows/runtime_build_and_test.yml) [![(Compiler) TypeScript](https://github.com/facebook/react/actions/workflows/compiler_typescript.yml/badge.svg?branch=main)](https://github.com/facebook/react/actions/workflows/compiler_typescript.yml) [![PRs Welcome](https://img.shields.io/badge/PRs-welcome-brightgreen.svg)](https://legacy.reactjs.org/docs/how-to-contribute.html#your-first-pull-request)

React는 사용자 인터페이스를 구축하기 위한 JavaScript 라이브러리입니다.

* **선언적(Declarative):** React는 대화형 UI를 손쉽게 만들 수 있도록 해줍니다. 애플리케이션의 각 상태에 대해 간단한 뷰를 설계하면, 데이터가 변경될 때 React가 효율적으로 적절한 컴포넌트만 업데이트하고 렌더링합니다. 선언적 뷰는 코드를 더 예측 가능하게 하고, 이해하기 쉽고, 디버깅을 쉽게 만듭니다.
* **컴포넌트 기반(Component-Based):** 자체 상태를 관리하는 캡슐화된 컴포넌트를 만들고, 이를 조합하여 복잡한 UI를 구성할 수 있습니다. 컴포넌트 로직이 템플릿이 아닌 JavaScript로 작성되기 때문에, 애플리케이션 전반에 걸쳐 풍부한 데이터를 쉽게 전달하고, 상태를 DOM 밖에서 유지할 수 있습니다.
* **한 번 배우면 어디서든 사용(Learn Once, Write Anywhere):** React는 사용자의 기술 스택에 대해 어떠한 가정도 하지 않으므로, 기존 코드를 다시 작성하지 않고도 새로운 기능을 React로 개발할 수 있습니다. 또한 [Node](https://nodejs.org/en)를 사용하여 서버에서 렌더링하거나, [React Native](https://reactnative.dev/)를 사용하여 모바일 앱을 구현할 수도 있습니다.

[React를 프로젝트에서 사용하는 방법 알아보기](https://react.dev/learn).

## 설치

React는 처음부터 점진적인 도입을 염두에 두고 설계되었으며, **필요한 만큼만 React를 사용할 수 있습니다**:

* [빠른 시작](https://react.dev/learn)으로 React를 미리 체험해 보세요.
* [기존 프로젝트에 React 추가](https://react.dev/learn/add-react-to-an-existing-project)를 통해 필요한 만큼만 React를 사용할 수 있습니다.
* 강력한 JavaScript 툴체인이 필요하다면 [새로운 React 앱 만들기](https://react.dev/learn/start-a-new-react-project)를 사용하세요.

## 문서

React 관련 문서는 [웹사이트](https://react.dev/)에서 확인할 수 있습니다.

빠르게 개요를 확인하려면 [시작하기](https://react.dev/learn) 페이지를 참고하세요.

문서는 여러 섹션으로 나뉘어 있습니다:

* [빠른 시작](https://react.dev/learn)
* [튜토리얼](https://react.dev/learn/tutorial-tic-tac-toe)
* [React로 사고하기](https://react.dev/learn/thinking-in-react)
* [설치](https://react.dev/learn/installation)
* [UI 설명하기](https://react.dev/learn/describing-the-ui)
* [상호작용 추가하기](https://react.dev/learn/adding-interactivity)
* [상태 관리](https://react.dev/learn/managing-state)
* [고급 가이드](https://react.dev/learn/escape-hatches)
* [API 레퍼런스](https://react.dev/reference/react)
* [지원 받는 곳](https://react.dev/community)
* [기여 가이드](https://legacy.reactjs.org/docs/how-to-contribute.html)

[이 저장소](https://github.com/reactjs/react.dev)에 풀 리퀘스트를 보내 문서를 개선할 수 있습니다.

## 예제

여러 예제가 [웹사이트](https://react.dev/)에 준비되어 있습니다. 시작을 위한 첫 번째 예제는 다음과 같습니다:

```jsx
import { createRoot } from 'react-dom/client';

function HelloMessage({ name }) {
  return <div>Hello {name}</div>;
}

const root = createRoot(document.getElementById('container'));
root.render(<HelloMessage name="Taylor" />);
```

이 예제는 페이지의 컨테이너에 "Hello Taylor"를 렌더링합니다.

HTML과 유사한 문법을 사용한 것을 볼 수 있습니다. [이를 JSX라고 부릅니다](https://react.dev/learn#writing-markup-with-jsx). JSX는 React 사용에 필수는 아니지만, 코드의 가독성을 높이고, 작성할 때 HTML을 작성하는 느낌을 줍니다.

## 기여

이 저장소의 주요 목적은 React 코어를 계속 발전시켜 더 빠르고 사용하기 쉽게 만드는 것입니다. React의 개발은 GitHub에서 공개적으로 진행되며, 버그 수정과 개선에 기여해 주신 커뮤니티에 감사드립니다. 아래를 읽고 React 개선에 어떻게 참여할 수 있는지 알아보세요.

### [행동 강령(Code of Conduct)](https://code.fb.com/codeofconduct)

Facebook은 프로젝트 참여자가 따라야 하는 행동 강령을 채택했습니다. [전체 텍스트](https://code.fb.com/codeofconduct)를 읽어보시고 어떤 행동이 허용되고 허용되지 않는지 이해하시기 바랍니다.

### [기여 가이드](https://legacy.reactjs.org/docs/how-to-contribute.html)

[기여 가이드](https://legacy.reactjs.org/docs/how-to-contribute.html)를 읽고, 개발 프로세스, 버그 수정 및 개선 제안 방법, React 변경 사항을 빌드하고 테스트하는 방법을 알아보세요.

### [Good First Issues](https://github.com/facebook/react/labels/good%20first%20issue)

초보자를 위해, 범위가 비교적 제한된 버그를 포함하는 [good first issues](https://github.com/facebook/react/labels/good%20first%20issue) 목록을 마련했습니다. 시작하기에 좋은 곳입니다.

### 라이선스

React는 [MIT 라이선스](./LICENSE)로 제공됩니다.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---