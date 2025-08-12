# Stixview

[![npm version](https://badge.fury.io/js/stixview.svg)](https://badge.fury.io/js/stixview)

[Stixview](https://github.com/traut/stixview)는 내장 가능한 인터랙티브 STIX2 그래프를 위한 JS 라이브러리입니다.

> [!NOTE]  
> Stixview의 호스팅 버전은 [CTIChef.com](https://ctichef.com)에서 이용할 수 있습니다.

![Stixview graph](https://raw.githubusercontent.com/traut/stixview/master/.github/stixview-graph.png)

## 동기

CTI (사이버 위협 인텔리전스)는 매우 스토리텔링에 관한 것입니다. 정보는 맥락과 함께 보완되고 스토리 안에 배치될 때 인텔리전스가 됩니다. 이러한 스토리는 보통 인텔리전스 제공자가 작성한 보고서에 결정체화되어 고객에게 배포됩니다.

인텔리전스 제공자가 구조화된 기계 판독 가능 CTI에 관심이 있다면, 작성된 보고서는 [STIX2](https://oasis-open.github.io/cti-documentation/) 번들로 보완될 것입니다. 보고서에서 서술된 스토리와 STIX2 번들로 표현된 구조화된 CTI 스냅샷 사이에는 간극이 존재합니다.

[Stixview](https://github.com/traut/stixview) 라이브러리의 목적은 필요한 수준의 상호작용성을 갖춘 쉽게 내장 가능한 STIX2 그래프를 제공하여 CTI 커뮤니티가 정보성 있고 몰입감 있는 스토리를 만들 수 있도록 하는 것입니다.

## 데모

Stixview의 작동을 보려면 다음 데모 페이지를 확인하세요:

* [STIX2.1 데모](https://traut.github.io/stixview/dist/demos/stix21-demo.html) — 모든 STIX 2.1 객체가 포함된 샘플 그래프.
* [스토리라인](https://traut.github.io/stixview/dist/demos/story.html) — 한 페이지에 여러 그래프, 동일 STIX 번들에서 선택된 엔티티 렌더링.
* [뷰어](https://traut.github.io/stixview/dist/demos/viewer.html) — 맞춤형 컨트롤이 있는 그래프 뷰어.
* [드래그 앤 드롭](https://traut.github.io/stixview/dist/demos/drag-n-drop.html) — 드래그 앤 드롭이 활성화된 그래프 뷰.
* [인라인 데이터에서 다크 테마 그래프](https://traut.github.io/stixview/dist/demos/load-data.html) — 인라인 STIX2 번들과 맞춤 스타일링으로 그래프 렌더링.
* [TLP 태그 및 맞춤 사이드바 콘텐츠 렌더러](https://traut.github.io/stixview/dist/demos/tags-and-custom-sidebar.html) — TLP 마킹 정의를 태그로 표시하고 사이드바는 제공된 함수로 렌더링.
* [다양한 구성 설정 예시](https://traut.github.io/stixview/dist/demos/misc.html)

## 사용법

브라우저에서 Stixview를 사용하려면 `dist` 디렉터리에서 최신 빌드(`stixview.bundle.js`)를 다운로드하고 HTML 파일에서 참조하세요:

```html
<script src="stixview.bundle.js" type="text/javascript"></script>
```
또는 [unpkg](https://unpkg.com) CDN 서비스를 사용하세요:


```html
<script src="https://unpkg.com/stixview/dist/stixview.bundle.js" type="text/javascript"></script>
```
## API

이 라이브러리는 [데이터 속성](https://developer.mozilla.org/en-US/docs/Learn/HTML/Howto/Use_data_attributes)에 크게 의존합니다.  
페이지가 로드되면 Stixview는 `data-stix-gist-id`, `data-stix-url` 또는 `data-stix-allow-dragdrop`이 설정된 모든 HTML 요소를 찾아 이 요소들을 그래프 홀더로 사용합니다.

그래프 홀더 div의 예:


```html
<div data-stix-gist-id="6a0fbb0f6e7faf063c748b23f9c7dc62"
     data-show-sidebar=true
     data-enable-mouse-zoom=false
     data-graph-width=500
     data-graph-height=300>
</div>
```
### 데이터 속성

모든 홀더 요소는 `data-stix-gist-id`, `data-stix-url` 또는 `data-stix-allow-dragdrop` 중 하나를 _반드시_ 설정해야 하며, 그렇지 않으면 라이브러리에서 감지되지 않습니다.

Stixview는 다음 `data-` 속성을 지원합니다:

* `stix-gist-id` — STIX2 번들을 포함하는 gist의 ID. `gist-file`이 지정되지 않으면 첫 번째 파일이 사용됩니다.
* `gist-file` — gist에서 STIX2 번들로 사용할 파일 이름. `stix-gist-id`가 설정된 경우에만 사용됩니다.
* `stix-url` — 원격 STIX2 번들 JSON 파일을 가리키는 URL.
* `stix-allow-dragdrop` (기본값 `false`) — STIX2 번들을 그래프 요소로 드래그 앤 드롭할 수 있는 기능을 활성화합니다. 이 속성이 `true`로 설정되고 `stix-gist-id`와 `stix-url`이 지정되지 않은 경우 빈 그래프가 렌더링됩니다.
* `caption` — 그래프의 제목. `caption`이 설정되지 않으면 헤더가 표시되지 않습니다.
* `show-footer` (기본값 `true`) — STIX2 번들과 PNG 파일 다운로드 링크가 포함된 푸터를 표시합니다.
* `show-sidebar` (기본값 `true`) — 객체를 클릭할 때 열리는 객체 세부정보 사이드바를 활성화합니다.
* `show-tlp-as-tags` (기본값 `true`) — 연결된 TLP 마킹 정의 객체를 엔티티에 태그로 표시합니다.
* `show-marking-nodes` (기본값 `true`) — 마킹 정의 노드를 표시합니다.
* `show-labels` (기본값 `true`) — 노드 레이블을 표시합니다.
* `show-idrefs` (기본값 `false`) — 관계에서 언급되었지만 번들에 없는 ID에 대한 플레이스홀더 객체를 표시합니다.
* `graph-layout` (기본값 `cola`) — 그래프 레이아웃 알고리즘 이름. 지원하는 알고리즘은 `cola`, `klay`, `cose-bilkent`, `cise`, `grid`, `dagre`입니다.
* `enable-mouse-zoom` (기본값 `true`) — 마우스 휠 줌 기능을 활성화합니다.
* `enable-panning` (기본값 `true`) — 그래프에서 팬 기능을 활성화합니다. `false`인 경우 그래프는 고정된 뷰를 가지며 사용자는 노드를 드래그할 수 있습니다.
* `highlighted-objects` — 쉼표로 구분된 STIX2 ID 문자열. 설정되면 그래프는 _나열된 ID를 가진 객체만_ 포함합니다.
* `hidden-objects` — 쉼표로 구분된 STIX2 ID 문자열. 설정되면 나열된 ID를 가진 객체는 건너뛰고 그래프에 렌더링되지 않습니다.
* `min-zoom` (기본값 `0.3`) — 허용되는 최소 줌 레벨.
* `max-zoom` (기본값 `2.5`) — 허용되는 최대 줌 레벨.
* `graph-width` (기본값 전체 사용 가능한 너비) — 그래프 요소의 너비. 픽셀 및 % 값 모두 지원됨(예제는 misc 데모 페이지 참조).
* `graph-height` (기본값 `600` 픽셀) — 그래프 요소의 높이. 픽셀 및 % 값 모두 지원됨(예제는 misc 데모 페이지 참조).

### 브라우저 객체

브라우저에서 사용 시, 라이브러리는 `window` 객체에 다음 속성을 가진 `stixview` 변수를 등록합니다:

* `registry` — 페이지에서 초기화된 그래프들의 레지스트리.
* `onInit(selector, callback)` – 지정된 `selector` 값과 일치하는 DOM 요소에서 그래프 초기화 이벤트에 대한 리스너 훅 (사용 예시는 [데모](https://traut.github.io/stixview/dist/demos/viewer.html) 참조). 콜백은 그래프 인터페이스 인스턴스를 받습니다.
* `onLoad(selector, callback)` – 지정된 `selector` 값과 일치하는 DOM 요소에서 그래프 로드 이벤트에 대한 리스너 훅 (사용 예시는 [데모](https://traut.github.io/stixview/dist/demos/viewer.html) 참조). 콜백은 그래프 인터페이스 인스턴스를 받습니다.
* `init(element, properties, initCallback, loadCallback)` — 지정된 `element`에서 기본값을 재정의하는 `properties`와 함께 그래프 뷰를 초기화하는 메서드 (사용 예시는 [데모](https://traut.github.io/stixview/dist/demos/load-data.html) 참조).

### 그래프 객체

그래프는 다음 속성을 가진 객체입니다:

* `cy` – [cytoscape.js](http://js.cytoscape.org) 그래프 객체입니다.
* `element` — 그래프를 담고 있는 DOM 요소입니다.
* `dataProps` – 구성된 데이터 필터링 속성입니다.
* `viewProps` – 구성된 보기 속성입니다.
* `runLayout(name)` — 그래프에 특정 레이아웃을 실행합니다.
* `reloadData()` — 새로운 데이터 필터링 속성으로 그래프 데이터를 다시 불러옵니다.
* `fit()` — 그래프를 그래프 뷰에 완전히 맞춥니다.
* `toggleLabels(<bool-value>)` — 노드 라벨을 표시하거나 숨깁니다.
* `toggleLoading(<bool-value>)` — 로딩 오버레이를 표시하거나 숨깁니다.
* `loadData(data)` — `data` JSON 객체에서 STIX2 번들을 불러와 그래프에 렌더링합니다.
* `loadDataFromFile(file)` — `file` 파일 객체에서 STIX2 번들을 불러와 그래프에 렌더링합니다.
* `loadDataFromUrl(url)` — 원격 URL에서 STIX2 번들을 불러와 그래프에 렌더링합니다.
* `loadDataFromParamUrl(paramName)` — HTTP GET 매개변수 이름이 `paramName`인 원격 URL에서 STIX2 번들을 불러와 그래프에 렌더링합니다.

## 빌드


```shell
yarn build
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-12

---