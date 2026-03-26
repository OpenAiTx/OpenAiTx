
<a href="https://www.facebook.com/amplifr/">
  <img width="80" height="80" align="right"
    alt="Amplifr 후원" src="https://raw.githubusercontent.com/vrizo/uibook/master/./amplifr-logo.png" style="border-radius: 100%; margin: 10px;"/>
</a>


# Uibook

Uibook은 React 컴포넌트의 시각적 테스트를 위한 도구입니다.  
실제 미디어 쿼리와 다양한 props 조합으로 컴포넌트의 데스크톱 및 모바일 뷰를 빠르게 확인할 수 있습니다.

주요 기능:  
- 개발자를 위한 **실제 미디어 쿼리**를 활용한 반응형 테스트  
- 디자이너와 편집자를 위한 라이브 텍스트 편집 기능으로 콘텐츠 확인  
- Webpack 플러그인으로 설치되어 별도의 빌더가 필요 없습니다.

<img src="/docs/uibook.gif" align="center" alt="Uibook 주요 기능" >

:triangular_flag_on_post: Uibook 데모 프로젝트를 여기서 확인하세요:  
[https://uibook.vrizo.net/](https://uibook.vrizo.net/#Presets:ru).

## 사용법

### 빠른 설치 :hatching_chick:

Uibook은 프로젝트에 원활하게 통합되도록 설계되었습니다.  
Webpack 플러그인으로 설치하면 준비 완료입니다:  
Uibook은 별도의 번들러를 요구하지 않습니다.

_webpack.config.js_

```js
const UibookPlugin = require('uibook/plugin')

module.exports = {
  …
  plugins: [
    new UibookPlugin({
      outputPath: '/uibook',
      controller: path.join(__dirname, '../src/uibook-controller.js'),
      hot: true
    })
  ],
}
```
[설치에 대해 더 읽기 →](https://raw.githubusercontent.com/vrizo/uibook/master/docs/install.md)
[CRACO를 사용한 Create React App에 설치 →](https://raw.githubusercontent.com/vrizo/uibook/master/docs/install_craco.md)

### 페이지에서 컴포넌트 설명하기 :부화한_병아리:

두 가지 항목만 정의하면 됩니다:

1. 페이지 — 테스트할 컴포넌트 이름과 케이스가 포함된 단순 객체;
2. 케이스 — 컴포넌트에 전달할 props와 콜백 세트.

_button.uibook.js_

```js
import UibookCase from 'uibook/case'
import Button from '../src/button'

export default {
  component: Button,
  cases: [
    () => <UibookCase>Button</UibookCase>,
    () => <UibookCase props={{ isSmall: true }}>Small button</UibookCase>
  ]
}
```
[구성에 대해 자세히 알아보기 →](https://raw.githubusercontent.com/vrizo/uibook/master/docs/configure.md)

### 페이지를 컨트롤러에 전달하기 :baby_chick:

첫 번째 Uibook 페이지를 마치면, 이제
Uibook 컨트롤러를 작성할 준비가 된 것입니다.
여기는 모든 페이지가 포함되고 UibookStarter에 전달되는 곳입니다 :sparkles:

_uibook-controller.js_

```js
import UibookStarter from 'uibook/starter'
import ButtonUibook from './button.uibook'

export default UibookStarter({
  pages: {
    Button: ButtonUibook
  }
})
```
[컨트롤러에 대해 더 읽기 →](https://raw.githubusercontent.com/vrizo/uibook/master/docs/controller.md)

### 실행 :rocket:

추가 서버나 webpack 인스턴스가 필요 없습니다.  
Uibook은 프로젝트에 통합되므로, 번들러를 실행하고  
브라우저에서 `/uibook` (또는 사용자 지정 주소 — `outputPath`)를 열면 됩니다.

### 추가 정보

- **[문제 해결](https://raw.githubusercontent.com/vrizo/uibook/master/docs/troubleshooting.md)**
- [예제](https://raw.githubusercontent.com/vrizo/uibook/master/docs/examples.md)
- [문의하기](https://twitter.com/vitaliirizo)

## 라이브 텍스트 편집

이 모드는 각 케이스에 대해 `contentEditable`을 활성화하여  
관리자, 디자이너 및 인터페이스 편집자가 컴포넌트 내 콘텐츠를 미리 볼 수 있게 합니다.

<img src="/docs/text-edit-mode.gif" align="center" alt="텍스트 편집 모드" >

## 특별 감사

- [@ai](https://github.com/ai)
- [@demiazz](https://github.com/demiazz)
- [@marfitsin](https://github.com/marfitsin)
- [@iadramelk](https://github.com/iadramelk)
- [@ikowalsker](https://www.facebook.com/ikowalsker)
- [@antiflasher](https://github.com/antiflasher)
- [@HellSquirrel](https://github.com/HellSquirrel)

누구나 기여를 환영하며, 현재 작업은  
[PLAN.md](https://raw.githubusercontent.com/vrizo/uibook/master/PLAN.md)에서 확인할 수 있습니다.  
프로젝트 관련 질문에 기꺼이 답변해 드리겠습니다.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-26

---