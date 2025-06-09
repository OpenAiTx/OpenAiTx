# [jQuery](https://jquery.com/) — New Wave JavaScript

회의는 현재 [matrix.org 플랫폼](https://matrix.to/#/#jquery_meeting:gitter.im)에서 진행되고 있습니다.

회의록은 [meetings.jquery.org](https://meetings.jquery.org/category/core/)에서 확인할 수 있습니다.

jQuery의 최신 버전은 [https://jquery.com/download/](https://jquery.com/download/)에서 다운로드할 수 있습니다.

## 버전 지원

| 버전    | 브랜치      | 상태     |
| ------- | ---------- | -------- |
| 4.x     | main       | 베타     |
| 3.x     | 3.x-stable | 활성     |
| 2.x     | 2.x-stable | 비활성   |
| 1.x     | 1.x-stable | 비활성   |

4.0.0 정식 버전이 출시되면, 3.x 브랜치는 제한된 기간 동안 업데이트를 계속 받게 됩니다. 2.x 및 1.x 브랜치는 더 이상 지원되지 않습니다.

비활성 버전에 대한 상업적 지원은 [HeroDevs](https://herodevs.com/nes)에서 제공합니다.

[jQuery의 버전 지원](https://jquery.com/support/)에 대해 자세히 알아보세요.

## 기여 가이드

오픈소스 소프트웨어 개발의 정신에 따라, jQuery는 항상 커뮤니티의 코드 기여를 장려합니다. 시작하기 전에, 그리고 코드를 작성하기 전에, 다음의 중요한 기여 지침을 반드시 꼼꼼히 읽어보시기 바랍니다:

1. [참여하기](https://contribute.jquery.org/)
2. [코어 스타일 가이드](https://contribute.jquery.org/style-guide/js/)
3. [jQuery 프로젝트를 위한 코드 작성](https://contribute.jquery.org/code/)

### 이슈/PR 참조

GitHub 이슈/PR은 보통 `gh-NUMBER` 형식으로 참조되며, 여기서 `NUMBER`는 이슈/PR의 숫자 ID입니다. 해당 이슈/PR은 `https://github.com/jquery/jquery/issues/NUMBER`에서 확인할 수 있습니다.

jQuery는 과거에 Trac 기반의 다른 버그 트래커를 사용했으며, [bugs.jquery.com](https://bugs.jquery.com/)에서 열람할 수 있습니다. 과거 논의를 참조할 수 있도록 읽기 전용 모드로 유지되고 있습니다. jQuery 소스에서 해당 이슈를 참조할 경우 `trac-NUMBER` 형식(여기서 `NUMBER`는 이슈의 숫자 ID)을 사용합니다. 해당 이슈는 `https://bugs.jquery.com/ticket/NUMBER`에서 확인할 수 있습니다.

## jQuery를 사용할 수 있는 환경

- [브라우저 지원](https://jquery.com/browser-support/)
- jQuery는 Node, 브라우저 확장, 기타 비브라우저 환경도 지원합니다.

## jQuery 빌드에 필요한 것

jQuery를 빌드하려면 최신 Node.js/npm과 git 1.7 이상이 필요합니다. 이전 버전도 동작할 수 있으나 지원되지 않습니다.

Windows의 경우 [git](https://git-scm.com/downloads)과 [Node.js](https://nodejs.org/en/download/)를 다운로드하여 설치해야 합니다.

macOS 사용자는 [Homebrew](https://brew.sh/)를 설치해야 합니다. Homebrew 설치 후 `brew install git`으로 git을, `brew install node`로 Node.js를 설치합니다.

Linux/BSD 사용자는 각자의 패키지 매니저를 사용하여 git과 Node.js를 설치하거나, 직접 소스에서 빌드할 수 있습니다. 매우 간단합니다.

## jQuery 직접 빌드하는 방법

먼저, [jQuery git 저장소를 클론](https://help.github.com/en/github/creating-cloning-and-archiving-repositories/cloning-a-repository)합니다.

그 다음, jquery 디렉토리로 이동하여 의존성을 설치하고 빌드 스크립트를 실행하세요:

```bash
cd jquery
npm install
npm run build
```

빌드된 jQuery는 `dist/` 디렉토리에 배치되며, 축소(minified)된 사본 및 관련 맵 파일도 함께 생성됩니다.

## 모든 jQuery 릴리즈 파일 빌드

jQuery의 모든 변형을 빌드하려면 다음 명령어를 실행하세요:

```bash
npm run build:all
```

이 명령은 jQuery 릴리즈에 포함되는 모든 변형 파일(jquery.js, jquery.slim.js, jquery.module.js, jquery.slim.module.js 및 해당 축소본, 소스맵 등)을 생성합니다.

`jquery.module.js`와 `jquery.slim.module.js`는 [ECMAScript 모듈](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Guide/Modules)로서 `jQuery`와 `$`를 네임드 익스포트로 내보내며, 이 파일들은 `dist/`가 아닌 `dist-module/` 디렉토리에 배치됩니다.

## 커스텀 jQuery 빌드

빌드 스크립트를 사용하여 필요한 모듈만 포함하는 커스텀 jQuery 버전을 만들 수 있습니다.

`core`를 제외한 모든 모듈은 제외할 수 있습니다. `selector`를 제외하면 완전히 제거되는 것이 아니라, 네이티브 `querySelectorAll`을 감싼 작은 래퍼로 대체됩니다(자세한 내용은 아래 참조).

### 빌드 스크립트 도움말

빌드 스크립트에서 사용할 수 있는 모든 옵션을 보려면 다음 명령을 실행하세요:

```bash
npm run build -- --help
```

### 모듈

모듈을 제외하려면 `src` 폴더 기준 경로(확장자 `.js`는 제외)를 `--exclude` 옵션에 전달하세요. `--include` 옵션을 사용하면 기본 포함 모듈이 모두 제외되고, 지정한 모듈만 포함됩니다.

제외 또는 포함할 수 있는 예시 모듈은 다음과 같습니다:

- **ajax**: 모든 AJAX 기능: `$.ajax()`, `$.get()`, `$.post()`, `$.ajaxSetup()`, `.load()`, 전송(transports), `.ajaxStart()` 등 ajax 이벤트 단축 메서드 포함.
- **ajax/xhr**: XMLHTTPRequest AJAX 전송만 포함.
- **ajax/script**: `<script>` AJAX 전송만 포함(스크립트 가져오기 용도).
- **ajax/jsonp**: JSONP AJAX 전송만 포함(ajax/script 전송에 의존).
- **css**: `.css()` 메서드. 또한 **css**에 의존하는 모든 모듈(예: **effects**, **dimensions**, **offset**)도 함께 제거됨.
- **css/showHide**: 비애니메이션 `.show()`, `.hide()`, `.toggle()`; display 속성 설정을 위해 클래스나 명시적 `.css()` 호출만 사용할 경우 제외 가능. **effects** 모듈도 함께 제거됨.
- **deprecated**: deprecated로 문서화되었으나 아직 제거되지 않은 메서드.
- **dimensions**: `.width()` 및 `.height()` 메서드와 `inner-`, `outer-` 변형 포함.
- **effects**: `.animate()` 및 `.slideUp()`, `.hide("slow")` 등 단축 메서드 포함.
- **event**: `.on()`, `.off()` 및 모든 이벤트 기능.
- **event/trigger**: `.trigger()`, `.triggerHandler()` 메서드.
- **offset**: `.offset()`, `.position()`, `.offsetParent()`, `.scrollLeft()`, `.scrollTop()` 메서드.
- **wrap**: `.wrap()`, `.wrapAll()`, `.wrapInner()`, `.unwrap()` 메서드.
- **core/ready**: 스크립트를 body 끝에 배치한다면 ready 모듈을 제외할 수 있음. 이 경우 `jQuery()`로 바인딩된 ready 콜백은 즉시 호출됩니다. 단, `jQuery(document).ready()`는 함수가 아니며, `.on("ready", ...)` 등도 트리거되지 않습니다.
- **deferred**: jQuery.Deferred 제외. 이로 인해 **ajax**, **effects**, **queue** 등 Deferred에 의존하는 모든 모듈도 함께 제외되며, 대신 **core/ready**가 **core/ready-no-deferred**로 대체됨.
- **exports/global**: 글로벌 jQuery 변수($, jQuery)를 window에 부착하는 기능 제외.
- **exports/amd**: AMD 정의 제외.

- **selector**: 전체 jQuery 선택자 엔진. 이 모듈을 제외하면, jQuery 선택자 확장 및 향상된 의미가 없는, 브라우저의 `querySelectorAll` 기반의 기본 선택자 엔진으로 대체됩니다. 자세한 내용은 [selector-native.js](https://github.com/jquery/jquery/blob/main/src/selector-native.js) 파일을 참조하세요.

*참고*: 전체 `selector` 모듈을 제외하면, 모든 jQuery 선택자 확장(예: `effects/animatedSelector`, `css/hiddenVisibleSelectors`)도 함께 제외됩니다.

##### AMD 이름

jQuery의 AMD 정의를 위한 모듈 이름을 지정할 수 있습니다. 기본값은 "jquery"로 설정되어 있으며, 플러그인 및 서드파티 라이브러리와 호환됩니다. 이름을 변경하려면 `--amd` 파라미터에 값을 전달하세요:

```bash
npm run build -- --amd="custom-name"
```

익명으로 정의하려면 이름을 비워두면 됩니다.

```bash
npm run build -- --amd
```

##### 파일 이름 및 디렉토리

빌드된 jQuery 파일의 기본 이름은 `jquery.js`이며, `dist/` 디렉토리에 저장됩니다. `--filename`으로 파일명을, `--dir`로 디렉토리를 변경할 수 있습니다. `--dir`은 프로젝트 루트 기준 상대 경로입니다.

```bash
npm run build -- --slim --filename="jquery.slim.js" --dir="/tmp"
```

이렇게 하면 slim 버전의 jQuery가 `/tmp/jquery.slim.js`로 생성됩니다.

##### ECMAScript 모듈(ESM) 모드

기본적으로 jQuery는 일반 스크립트 JavaScript 파일을 생성합니다. `--esm` 파라미터를 사용하면 `jQuery`를 기본 익스포트로 내보내는 ECMAScript 모듈을 생성할 수 있습니다:

```bash
npm run build -- --filename=jquery.module.js --esm
```

##### 팩토리 모드

기본적으로 jQuery는 글로벌 `window`에 의존합니다. `window`가 없는 환경을 위해, 외부에서 `window`를 매개변수로 전달하는 팩토리 빌드를 생성할 수 있습니다(사용법은 [`README` of the published package](build/fixtures/README.md) 참고). `--factory` 파라미터로 팩토리 빌드를 생성할 수 있습니다:

```bash
npm run build -- --filename=jquery.factory.js --factory
```

이 옵션은 `--esm`이나 `--slim`과 같이 조합할 수 있습니다:

```bash
npm run build -- --filename=jquery.factory.slim.module.js --factory --esm --slim --dir="/dist-module"
```

#### 커스텀 빌드 예시

`npm run build`를 사용하여, 제외할 모듈을 나열하여 커스텀 빌드를 생성하세요. 최상위 모듈을 제외하면 해당 디렉토리의 모든 하위 모듈도 함께 제외됩니다.

**ajax** 기능 전체 제외:

```bash
npm run build -- --exclude=ajax
```

**css**를 제외하면 CSS에 의존하는 모듈(**effects**, **offset**, **dimensions**)도 함께 제거됩니다.

```bash
npm run build -- --exclude=css
```

여러 모듈을 한 번에 제외하기(`-e`는 `--exclude`의 별칭):

```bash
npm run build -- -e ajax/jsonp -e css -e deprecated -e dimensions -e effects -e offset -e wrap
```

공식 jQuery Slim 빌드와 동일한 설정으로 빌드를 생성하는 특별한 별칭이 있습니다:

```bash
npm run build -- --filename=jquery.slim.js --slim
```

또는, slim 빌드를 esm 모듈로 생성하려면:

```bash
npm run build -- --filename=jquery.slim.module.js --slim --esm
```
```

*비공식 커스텀 빌드는 정기적으로 테스트되지 않습니다. 사용 시 위험을 감수해야 합니다.*

## 단위 테스트 실행

필요한 종속성을 설치하세요:

```bash
npm install
```

작업 중에 jQuery를 자동 빌드하려면 `npm start`를 실행하세요:

```bash
npm start
```

PHP를 지원하는 로컬 서버에서 단위 테스트를 실행하세요. 사이트를 "test" 디렉터리가 아니라 루트 디렉터리에서 실행해야 합니다. 데이터베이스는 필요하지 않습니다. Windows와 Mac용으로 사전 구성된 php 로컬 서버가 제공됩니다. 다음은 몇 가지 옵션입니다:

- Windows: [WAMP 다운로드](https://www.wampserver.com/en/)
- Mac: [MAMP 다운로드](https://www.mamp.info/en/downloads/)
- Linux: [LAMP 설정](https://www.linux.com/training-tutorials/easy-lamp-server-installation/)
- [Mongoose (대부분의 플랫폼)](https://code.google.com/p/mongoose/)

## 필수 Git

소스 코드는 Git 버전 관리 시스템으로 관리되므로, 사용되는 몇 가지 기능을 아는 것이 유용합니다.

### 정리

작업 디렉터리를 upstream 상태로 되돌리려면, 다음 명령어를 사용할 수 있습니다(이후 작업한 모든 내용은 사라집니다):

```bash
git reset --hard upstream/main
git clean -fdx
```

### 리베이스

기능/주제 브랜치의 경우, 항상 `git pull` 시 `--rebase` 플래그를 사용해야 하며, 여러 임시 "github pull request용" 브랜치를 자주 다루는 경우 다음 명령어로 이를 자동화할 수 있습니다:

```bash
git config branch.autosetuprebase local
```

(자세한 내용은 `man git-config` 참고)

### 병합 충돌 처리

병합 시 충돌이 발생한다면, 충돌 파일을 직접 편집하는 대신,
`git mergetool` 기능을 사용할 수 있습니다. 기본 도구인 `xxdiff`가 다소 오래되어 보이지만, 꽤 유용합니다.

여기서 사용할 수 있는 몇 가지 명령어는 다음과 같습니다:

- `Ctrl + Alt + M` - 가능한 한 많이 자동 병합
- `b` - 다음 병합 충돌로 이동
- `s` - 충돌된 라인의 순서 변경
- `u` - 병합 실행 취소
- `왼쪽 마우스 버튼` - 블록을 승자로 지정
- `가운데 마우스 버튼` - 라인을 승자로 지정
- `Ctrl + S` - 저장
- `Ctrl + Q` - 종료

## [QUnit](https://api.qunitjs.com) 참고

### 테스트 메서드

```js
expect( numAssertions );
stop();
start();
```

*참고*: QUnit에서 stop/start에 인자가 추가될 예정이지만, 이 테스트 스위트에서는 무시됩니다. start와 stop을 콜백으로 전달할 때 인자를 신경 쓰지 않아도 됩니다.

### 테스트 어서션

```js
ok( value, [message] );
equal( actual, expected, [message] );
notEqual( actual, expected, [message] );
deepEqual( actual, expected, [message] );
notDeepEqual( actual, expected, [message] );
strictEqual( actual, expected, [message] );
notStrictEqual( actual, expected, [message] );
throws( block, [expected], [message] );
```

## 테스트 스위트 편의 메서드 참고

[https://raw.githubusercontent.com/jquery/jquery/main/test/data/testinit.js](https://raw.githubusercontent.com/jquery/jquery/main/test/data/testinit.js)를 참고하세요.

### 주어진 ID의 요소 배열 반환

```js
q( ... );
```

예시:

```js
q( "main", "foo", "bar" );

=> [ div#main, span#foo, input#bar ]
```

### 셀렉션이 주어진 ID들과 일치하는지 어서트

```js
t( testName, selector, [ "array", "of", "ids" ] );
```

예시:

```js
t("Check for something", "//[a]", ["foo", "bar"]);
```

### jQuery를 거치지 않고 네이티브 DOM 이벤트 발생

```js
fireNative( node, eventType );
```

예시:

```js
fireNative( jQuery( "#elem" )[ 0 ], "click" );
```

### 캐시 방지를 위해 url에 랜덤 숫자 추가

```js
url( "some/url" );
```

예시:

```js
url( "index.html" );

=> "data/index.html?10538358428943"


url( "mock.php?foo=bar" );

=> "data/mock.php?foo=bar&10538358345554"
```

### iframe에서 테스트 실행

일부 테스트는 표준 테스트 픽스처가 아닌 문서를 필요로 하며,
이런 테스트는 별도의 iframe에서 실행할 수 있습니다. 실제 테스트 코드와 어서션은
jQuery의 메인 테스트 파일에 남아 있으며, 최소한의 테스트 픽스처 마크업과
설정 코드만 iframe 파일에 작성해야 합니다.

```js
testIframe( testName, fileName,
  function testCallback(
      assert, jQuery, window, document,
	  [ additional args ] ) {
	...
  } );
```

이 코드는 fileName으로 `"./data/" + fileName` 경로의 페이지를 로드합니다.
iframe 페이지는 "/test/data/iframeTest.js" 스크립트를 포함하고,
적절한 시점에 `startIframeTest( [ additional args ] )`를 호출하여
콜백이 언제 발생하는지 결정합니다. 이는 일반적으로 document ready 또는
`window.onload`가 발생한 후가 될 수 있습니다.

`testCallback`은 이 테스트를 위해 `testIframe`에서 생성된 QUnit `assert` 객체와,
iframe의 글로벌 `jQuery`, `window`, `document`를 순서대로 전달받습니다.
iframe 코드가 `startIframeTest`에 인자를 전달하면, 이들은 `document` 인자 뒤에 따라옵니다.

## 질문이 있으신가요?

질문이 있으시면 언제든지
[Developing jQuery Core 포럼](https://forum.jquery.com/developing-jquery-core)이나 [libera](https://web.libera.chat/)의 #jquery 채널에서 문의해 주세요.
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---