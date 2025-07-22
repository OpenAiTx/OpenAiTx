<translate-content># 트립틱 - HTML을 위한 새로운 속성들

[트립틱](https://alexanderpetros.com/triptych)은 세 가지 작은 HTML 제안을 위한 폴리필입니다:

1. [폼에서 PUT, PATCH, DELETE 지원](https://alexanderpetros.com/triptych/form-http-methods) ([WHATWG 이슈](https://github.com/whatwg/html/issues/3577#issuecomment-2294931398))
2. [폼에 감싸지지 않은 상태에서 버튼이 HTTP 요청을 할 수 있도록 활성화](https://alexanderpetros.com/triptych/button-actions)
3. 링크, 폼, 버튼이 DOM의 일부를 교체 대상으로 지정할 수 있도록 활성화

이 제안들에 대한 작업이 진행 중입니다: 첫 번째는 공개되었고, 다음 두 가지는 곧 나옵니다.
관심 있으시면 저에게 연락해 주세요!

상태 업데이트는 다음에서 확인하세요: [https://alexanderpetros.com/triptych#status](https://alexanderpetros.com/triptych#status)

## 예시

링크를 클릭하면 `<main>`을 `GET /home` 결과로 교체합니다:
</translate-content>
```html
<a href="/home" target="main">Home</a>
<main> <!-- Existing page content --> </main>
```
버튼을 클릭하면 `DELETE /users/354`의 결과로 전체 페이지를 교체합니다:

```html
<button action="/users/354" method="DELETE"></button>
```
<translate-content>
버튼이 클릭되면 버튼을 `DELETE /users/354`의 결과로 교체합니다.
</translate-content>
```html
<button action="/users/354" method="DELETE" target="_this"></button>
```
<form이 제출되면, `<div id=user-info>`를 `PUT /users/354`의 결과로 교체합니다.

```html
<div id="user-info"></div>
<form action="/users/354" method="PUT" target="#user-info">
  <input type="text" name="name">
  <input type="text" name="bio">
  <button>Submit</button>
</form>
```
## 배경 및 설계 목표

Triptych은 HTML의 핵심 기능이면서 라이브러리 생태계에서 최근 많은 주목을 받고 있는 기능 세트인 선언적 HTTP 요청과 부분 페이지 교체를 표준 호환 방식으로 구현한 것입니다.  
이 제안들의 근거는 [Big Sky Dev Con 2024에서 제가 발표한 이 강연](https://unplannedobsolescence.com/blog/life-and-death-of-htmx/)에서 설명했습니다.

HTML은 항상 선언적 요청을 지원해왔습니다.  
하이퍼링크는 웹 문법의 기본이며, `<a>` 태그는 개발자가 HTTP 요청과 이후 페이지 네비게이션을 지정할 수 있게 합니다.  
HTML 2.0은 `<form>` 요소를 도입해 개발자가 대체 HTTP 메서드(`POST`)를 지정하고 URL 쿼리 매개변수 또는 요청 본문을 통해 사용자 입력을 받을 수 있게 했습니다.

선언적 HTTP 요청의 기존 의미론에는 두 가지 큰 누락된 부분이 있습니다: 전체 HTTP 메서드 집합(특히 `PUT`, `PATCH`, `DELETE`)을 지원하지 않고, 네비게이션과 폼 제출이라는 비교적 엄격한 패러다임만 지원한다는 점입니다.

라이브러리 생태계는 이 두 가지 기능과 더불어 세 번째 기능인 네트워크 요청 결과로 DOM을 부분 교체하는 기능에 대한 상당한 수요를 보여줍니다.  
이 기능들을 지원하는 [가장 인기 있는](https://risingstars.js.org/2023/en#section-framework) 라이브러리는 [htmx](https://htmx.org/)이지만, 혼자가 아닙니다.  
Ruby on Rails를 만든 37Signals는 HTML 인터페이스를 가진 HTML-over-the-wire 프레임워크인 [Hotwired](https://hotwired.dev/)를 유지하며, 부분 페이지 교체를 위한 [Turbo](https://turbo.hotwired.dev/)를 제공합니다.  
[Unpoly](https://unpoly.com/)는 교체할 페이지 조각을 지정할 수 있는 속성을 추가하고 전체 HTTP 메서드 범위를 지원합니다.

Triptych은 HTML 표준에 속성 기반 DOM 교체를 통합하려는 시도로,  
기존 HTML 의미론에 가장 잘 맞는 방식으로 구현했습니다.  
이 제안들의 효용성을 보여주고 HTML 표준에 추가되도록 권장하며, 그때까지는 폴리필로서 기능을 제공합니다.  
설계는 주로 [htmx](https://htmx.org/)와 [htmz](https://leanrada.com/htmz/)에서 영감을 받았습니다.

Triptych의 목표가 HTML 표준에 포함되는 것이기 때문에, 네임스페이스가 있는 사용자 정의 속성(`ng-*`, `hx-*` 등)을 사용하지 않고, 대신 기존(또는 그럴듯한) HTML 표준 속성을 하위 호환 방식으로 사용합니다.  
스크립트의 복잡성 대부분은 `target`이나 `method` 같은 기존 속성 사용을 깨뜨리지 않아야 하기 때문입니다.

## 설치

아직 CDN이 없지만, 설령 올리더라도 [사용하지 않는 것이 좋습니다](https://blog.wesleyac.com/posts/why-not-javascript-cdn).

대신 다음과 같이 설치하세요:

1. `triptych.js`를 프로젝트 내 폴더, 예를 들어 `/vendor/triptych-0.1.0.js`에 복사합니다.  
1. 그 URL에서 아주 긴 캐시 기간(보통 1년)으로 서빙합니다.  
1. 문서에 다음과 같이 포함합니다:




```html
<script src="/vendor/triptych-0.1-0.js"></script>
```
<translate-content>
파일 이름에 버전 번호를 반드시 포함하세요. 업데이트 시 캐시된 사용자가 새 버전을 다운로드할 수 있도록 하기 위해서입니다.

곧 `npm`에 업로드할 예정이니, 의존성으로 포함하여 노드 모듈에서 바로 제공할 수 있습니다(복사하는 대신).

## 제한 사항

이 기능들은 표준에 통합되기 위한 것이므로, JavaScript의 한계 내에서 원하는 브라우저 동작을 시뮬레이션합니다.

주요 제한 사항은 전체 페이지 내비게이션에 관련됩니다.
POST 폼을 제출할 때 기본 동작은 해당 URL을 주소 표시줄에 푸시하고 폼에서 반환된 HTML을 표시하는 것입니다;
새로고침 버튼을 클릭하면 사용자가 의도했음을 확인한 후 POST 요청을 다시 제출합니다.

버튼과 폼에 `target`이 제공되지 않은 경우, Triptych은 가능한 한 전체 페이지 동작을 시뮬레이션합니다.
전체 문서를 교체하고 [history API](https://developer.mozilla.org/en-US/docs/Web/API/History)를 사용하여
브라우저 URL과 기록을 업데이트합니다.
"뒤로" 버튼을 클릭하면 기본적으로 예상대로 작동해야 합니다.

그러나 (매우 합리적인) JavaScript의 제한 때문에 Triptych은 새로고침 버튼의 동작을 변경해 PUT 요청을 다시 제출하게 할 수 없습니다.
또한 POST-리디렉트 패턴을 사용하는 주된 이점 중 하나인 현재 JS 환경을 재설정하는 동작도 시뮬레이션할 수 없습니다.

또한 모든 요청에 대해 브라우저는 링크 클릭 시처럼 로딩 바를 표시해야 합니다.
이 동작은 JavaScript로 시뮬레이션할 수 없지만 브라우저에 통합되면 사용자에게 크게 유용할 것입니다—*모든* JavaScript 프레임워크에서 부족한 주요 기능 중 하나입니다.

## 개발

전체 소스는 `./triptych.js`에 있습니다.

테스트를 실행하려면 먼저 `npm install`로 개발 의존성을 설치하세요.
그런 다음 브라우저에서 `./test/index.html`을 열어 테스트를 실행합니다.

`npm run dev` 명령어로 수동 테스트도 실행해 볼 수 있습니다.

### 할 일

* 기존 GET/POST 폼이 영향을 받지 않음을 검증하는 전체 페이지 테스트 추가
* 서버 측 리타게팅 제어 조사 (아마도 헤더)
* 진행 중인 요청에 대한 CSS 속성 조사

## FAQ

### 이걸 내 프로젝트에서 사용해야 하나요?

예, 그리고 아니오.

전통적인 폴리필의 목적은 표준이 되기 전에 웹페이지에 기능을 제공하는 것입니다.
Triptych의 경우 일부 기능은 JavaScript로 시뮬레이션할 수 없습니다(위의 제한 사항 참조).

이 "폴리필"의 목적은 이러한 제안들이 기본 HTML의 기능을 어떻게 변화시킬지 데모하는 것입니다.
이 라이브러리의 기능 세트는 지원하는 제안들을 추적하며, 피드백을 반영해야 하므로 초기에는 강력한 하위 호환성을 보장할 수 없습니다.
하지만 HTML 작성이 어떻게 될 수 있는지 감을 잡는 데 확실히 사용해 보셔야 합니다.

### 여러 요소가 타겟과 일치하면 어떻게 되나요?

타게팅은 [querySelector API](https://developer.mozilla.org/en-US/docs/Web/API/Document/querySelector)를 사용하며, 문서 노드를 깊이 우선 선행 순서로 순회합니다.
타겟은 해당 알고리즘에 따라 발견된 첫 번째 일치하는 요소가 됩니다.
</translate-content>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-22

---