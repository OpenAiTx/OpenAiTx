[![Scorecard supply-chain security](https://github.com/edwinm/carbonium/actions/workflows/scorecard.yml/badge.svg)](https://github.com/edwinm/carbonium/actions/workflows/scorecard.yml) [![CodeQL](https://github.com/edwinm/carbonium/actions/workflows/codeql.yml/badge.svg)](https://github.com/edwinm/carbonium/actions/workflows/codeql.yml) [![Coverage Status](https://coveralls.io/repos/github/edwinm/carbonium/badge.svg?branch=master)](https://coveralls.io/github/edwinm/carbonium?branch=master) [![Socket Badge](https://socket.dev/api/badge/npm/package/carbonium)](https://socket.dev/npm/package/carbonium) [![CodeFactor](https://www.codefactor.io/repository/github/edwinm/carbonium/badge)](https://www.codefactor.io/repository/github/edwinm/carbonium) [![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=edwinm_carbonium&metric=alert_status)](https://sonarcloud.io/summary/new_code?id=edwinm_carbonium) [![Snyk test results](https://snyk.io/test/github/edwinm/carbonium/badge.svg)](https://snyk.io/test/github/edwinm/carbonium) [![Size](https://badgen.net/bundlephobia/minzip/carbonium)](https://bundlephobia.com/package/carbonium) [![npm version](https://badge.fury.io/js/carbonium.svg)](https://www.npmjs.com/package/carbonium) [![GitHub](https://img.shields.io/github/license/edwinm/carbonium.svg)](https://github.com/edwinm/carbonium/blob/master/LICENSE) ![CodeRabbit Pull Request Reviews](https://img.shields.io/coderabbit/prs/github/edwinm/carbonium?utm_source=oss&utm_medium=github&utm_campaign=edwinm%2Fcarbonium&labelColor=171717&color=FF570A&link=https%3A%2F%2Fcoderabbit.ai&label=CodeRabbit+Reviews)

[![Carbonium](https://raw.githubusercontent.com/edwinm/carbonium/master/assets/carbonium.svg)](#readme)

> 손쉬운 DOM 조작을 위한 1킬로바이트 라이브러리

carbonium을 사용하면 `$(selector)`를 호출할 수 있으며, 결과는 DOM 요소와 일치하는 요소들의 배열로 모두 접근할 수 있습니다.
DOM 요소 연산은 모든 일치하는 요소에 적용됩니다.

## 예제

클래스가 `indent`인 모든 요소의 `left` CSS 속성을 40픽셀로 설정하려면:

```javascript
$(".indent").style.left = "40px";
```

내용이 "priority"인 모든 div에 클래스 `important`를 추가하려면:

```javascript
$("div")
  .filter((el) => el.textContent == "priority")
  .classList.add("important");
```

carbonium을 사용하여 요소를 만들 수 있습니다:

```javascript
const error = $("<div class='error'>An error has occured!</div>")[0];
```

## 설치

```bash
npm install --save-dev carbonium
```
이제 carbonium을(를) 가져올 수 있습니다:


```javascript
import { $ } from "carbonium";
```
만약 webpack이나 rollup.js 같은 번들러를 설치하거나 사용하고 싶지 않다면, 다음과 같이 carbonium을 임포트할 수 있습니다:


```javascript
const { $ } = await import(
  "https://cdn.jsdelivr.net/npm/carbonium@1/dist/bundle.min.js"
);
```
## API

### 요소 선택

### `$(selector [, parentNode])`

#### 매개변수

| 이름       | 타입                           | 설명                                                                     |
| ---------- | ------------------------------ | ------------------------------------------------------------------------ |
| selector   | string                         | 요소를 선택할 셀렉터                                                     |
| parentNode | Document \| Element (선택사항) | 셀렉터를 적용할 문서 또는 요소, 기본값은 `document`                    |

#### 반환값

일치하는 요소들의 배열이며, 단일 요소로도 접근할 수 있습니다.

### 요소 생성

### `$(html [, parentNode])`

#### 매개변수

| 이름       | 타입                           | 설명                                                                     |
| ---------- | ------------------------------ | ------------------------------------------------------------------------ |
| html       | string                         | 생성할 요소의 HTML, "<"로 시작해야 함                                   |
| parentNode | Document \| Element (선택사항) | 셀렉터를 적용할 문서 또는 요소, 기본값은 `document`                    |

#### 반환값

생성된 하나의 요소를 담은 배열.

## TypeScript

TypeScript를 사용하는 경우, Carbonium이 TypeScript로 작성되어 모든 타입 정의를 제공합니다.
제네릭을 사용하여 특정 요소 타입을 선언할 수 있습니다.
예를 들어 `HTMLInputElement`를 사용하여 `disabled` 속성을 사용할 수 있습니다:


```typescript
$<HTMLInputElement>("input, select, button").disabled = true;
```
## 왜?

대부분의 프레임워크가 꽤 무겁고 성능에 좋지 않다는 것을 알게 될 수 있습니다 ([1](https://css-tricks.com/radeventlistener-a-tale-of-client-side-framework-performance/)).
반면에, 네이티브 DOM을 사용하고 DOM 작업을 할 때마다 `document.querySelectorAll(selector)`를 작성하는 것이 번거롭게 느껴질 수 있습니다.
자신만의 헬퍼 함수를 작성할 수 있지만, 그것은 고통의 일부만 덜어줍니다.

Carbonium은 프레임워크 사용과 네이티브 DOM 사용 사이의 적절한 균형점을 찾고자 합니다.

## jQuery

이것이 단지 jQuery이고, jQuery는 구식이며 좋은 관행이 아니지 않나요?

아닙니다. Carbonium은 jQuery의 단점을 가지고 있지 않습니다:

1. Carbonium은 매우 작습니다: 약 1킬로바이트 정도입니다.
2. 배워야 할 새로운 API가 없습니다, Carbonium은 표준 DOM API만 제공합니다.

## 브라우저 지원

Carbonium은 모든 최신 브라우저에서 지원됩니다. Firefox 79, Chrome 84, Safari 13, Edge 84 데스크톱 및 모바일에서 작동하는 것이 테스트되었습니다.
Proxy를 지원하는 모든 브라우저에서 작동해야 하며, 지원 표는 [Can I use Proxy](https://caniuse.com/#feat=proxy)를 참조하십시오.

## 이름

[<img src="https://raw.githubusercontent.com/edwinm/carbonium/master/assets/Diamond_and_graphite.jpg" align="right"
     alt="다이아몬드와 흑연 사진" width="178" height="120">](https://commons.wikimedia.org/wiki/File:Diamond_and_graphite_without_structures.jpg)

Carbonium은 탄소의 라틴어 이름입니다. 탄소는 두 가지 형태(동소체)를 가지고 있습니다: 흑연과 다이아몬드.
이 라이브러리처럼, 결과가 하나의 요소이면서 동시에 요소 목록으로 나타납니다.

[사진 CC BY-SA 3.0](https://commons.wikimedia.org/wiki/File:Diamond_and_graphite_without_structures.jpg)

## 라이선스

저작권 2023 [Edwin Martin](https://bitstorm.org/) 소유이며 MIT 라이선스 하에 배포됩니다.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-05

---